//
//  sprites.cpp
//  splashkit
//
//  Created by Andrew Cain on 23/08/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#include "animations.h"
#include "backend_types.h"
#include "camera.h"
#include "collisions.h"
#include "geometry.h"
#include "images.h"
#include "mouse_input.h"
#include "sprites.h"
#include "timers.h"
#include "utility_functions.h"
#include "vector_2d.h"

#include <cmath>
#include <map>
#include <vector>

using std::map;
using std::vector;
using std::to_string;
using std::swap;

namespace splashkit_lib
{
    timer _sprite_timer = nullptr;
    vector<sprite_event_handler *> _global_sprite_event_handlers;

    map<string, sprite> _sprites;

    // Sprite pack data
#define INITIAL_PACK_NAME "default"
    map<string, vector<void *>> _sprite_packs;
    string _current_pack = INITIAL_PACK_NAME;

    vector<void *> &current_pack()
    {
        return _sprite_packs[_current_pack];
    }

#define SCALE_KEY       "scale"
#define ROTATION_KEY    "rotation"
#define MASS_KEY        "mass"

    struct _sprite_data
    {
        pointer_identifier  id;
        string name;                          // The name of the sprite for resource management

        vector<bitmap>      layers;           // Layers of the sprites
        map<string, int>    layer_names;
        vector<int>         visible_layers;   // The indexes of the visible layers
        vector<vector_2d>   layer_offsets;    // Offsets from drawing the layers

        map<string, float>  values;           // Values associated with this sprite


        animation           animation_info;   // The data used to animate this sprite
        animation_script    script;           // The template for this sprite"s animations

        point_2d            position;         // The game location of the sprite
        vector_2d           velocity;         // The velocity of the sprite

        collision_test_kind collision_kind;   //The kind of collisions used by this sprite
        bitmap              collision_bitmap; // The bitmap used for collision testing (default to first image)

        point_2d            anchor_point;
        bool                position_at_anchor_point;
        bool                draw_at_anchor_point;

        bool                is_moving;          // Used for events to indicate the sprite is moving
        point_2d            destination;        // The destination the sprite is moving to
        vector_2d           moving_vec;         // The sprite"s movement vector
        float               arrive_in_sec;      // Amount of time in seconds to arrive at point
        int                 last_update;        // Time of last update

        bool                announced_animation_end; // Used to avoid multiple announcements of an end of an animation

        vector<sprite_event_handler *> evts;    // The call backs listening for sprite events

        vector<void *>      &pack;              // Points the the SpritePack that contains this sprite

        _sprite_data() : pack( current_pack() )
        {
        }
    };

    //-----------------------------------------------------------------------------
    // Event Utility Code
    //-----------------------------------------------------------------------------

    //
    // loop through all event listeners and notif(y them of the event )
    //
    void sprite_raise_event(sprite s, sprite_event_kind evt)
    {
        if( ( INVALID_PTR(s, SPRITE_PTR) ) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }
        int i;

        // this sprite"s event handlers
        for (i = 0; i < s->evts.size(); i++)
        {
            s->evts[i](s, evt);
        }

        // global sprite event handlers
        for (i = 0; i < _global_sprite_event_handlers.size(); i++)
        {
            _global_sprite_event_handlers[i](s, evt);
        }
    }

    //-----------------------------------------------------------------------------
    // Vector stuff...
    //-----------------------------------------------------------------------------

    vector_2d vector_from_to(sprite s1, sprite s2)
    {
        return vector_point_to_point(center_point(s1), center_point(s2));
    }

    vector_2d vector_from_center_sprite_to_point(sprite s, const point_2d &pt)
    {
        return vector_point_to_point(center_point(s), pt);
    }

    //-----------------------------------------------------------------------------
    // Sprite creation...
    //-----------------------------------------------------------------------------

    sprite create_sprite(bitmap layer)
    {
        return create_sprite(layer, nullptr);
    }

    sprite create_sprite(const string &bitmap_name)
    {
        return create_sprite(bitmap_named(bitmap_name), nullptr);
    }

    sprite create_sprite(const string &bitmap_name, const string &animation_name)
    {
        return create_sprite(bitmap_named(bitmap_name), animation_script_named(animation_name));
    }

    sprite create_sprite(bitmap layer, animation_script ani)
    {
        return create_sprite("sprite", layer, ani);
    }

    sprite create_sprite(const string &name, bitmap layer)
    {
        return create_sprite(name, layer, nullptr);
    }

    sprite create_sprite(const string &name, bitmap layer, animation_script ani)
    {
        string sn;
        int idx;

        // Find a unique name for this sprite
        idx = 0;
        sn = name;

        while (has_sprite(sn))
        {
            sn = name + to_string(idx);
            idx += 1;
        }

        //allocate the space for the sprite
        sprite result = new _sprite_data();

        result->id = SPRITE_PTR;
        result->name = sn;

        //Set lengths of the layer arrays
        result->layer_names["base_layer"] = 0;
        result->layers.push_back(layer);
        result->layer_offsets.push_back(vector_to(0,0));

        result->anchor_point = point_at(bitmap_width(layer) / 2, bitmap_height(layer) / 2);
        result->position_at_anchor_point = false;
        result->draw_at_anchor_point = false;

        // Set the first layer as visible.
        result->visible_layers.push_back(0);                //The first layer (at idx 0) is drawn

        // Setup the values
        result->values[MASS_KEY] = 1;
        result->values[ROTATION_KEY] = 0;
        result->values[SCALE_KEY] = 1;

        // Position the sprite
        result->position = point_at(0,0);

        // Initialise sprite movement
        result->velocity = vector_to(0,0);

        // Setup animation detials
        result->script         = ani;
        result->animation_info           = nullptr;

        // Setup collision details
        result->collision_kind           = PIXEL_COLLISIONS;
        result->collision_bitmap         = layer;

        // Event details
        result->announced_animation_end = false;
        result->is_moving = false;
        result->destination = point_at(0,0);
        result->moving_vec = vector_to(0,0);
        result->arrive_in_sec = 0;

        if ( _sprite_timer == nullptr )
        {
            _sprite_timer = create_timer("*SK* SpriteTimer");
            start_timer(_sprite_timer);
        }

        result->last_update = timer_ticks(_sprite_timer);

        // Write_ln("adding for ", name, " ", Hex_str(obj));
        _sprites[name] = result;

        current_pack().push_back(result);

        return result;
    }

    string sprite_name(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return"";
        }
        return s->name;
    }

    //-----------------------------------------------------------------------------
    // Free sprites
    //-----------------------------------------------------------------------------

    void free_sprite(sprite s)
    {
        if( (INVALID_PTR(s, SPRITE_PTR)) )
        {
            LOG(WARNING) << "Attempting to free invalid sprite";
            return;
        }

        //Dispose sprite
        notify_of_free(s);

        // Free pointers
        if( (ASSIGNED(s->animation_info)) )
            free_animation(s->animation_info);

        // nullptr pointers to resources managed by sgResources
        s->script = nullptr;

        //Free buffered rotation image
        s->collision_bitmap = nullptr;

        if( ( not erase_from_vector(s->pack, static_cast<void *>(s)) ) )
        {
            LOG(WARNING) << "Error removing sprite from sprite pack!";
        }

        // Remove from hashtable
        // Write_ln("Freeing sprite named: ", s->name);
        _sprites.erase(s->name);

        s->id = NONE_PTR;
        delete s;
    }

    void free_all_sprites()
    {
        FREE_ALL_FROM_MAP(_sprites, SPRITE_PTR, free_sprite);
    }

    //-----------------------------------------------------------------------------
    // Sprite fetching functions
    //-----------------------------------------------------------------------------

    bool has_sprite(const string &name)
    {
        return _sprites.count(name) > 0;
    }

    sprite sprite_named(const string &name)
    {
        if( (has_sprite(name)) )
            return _sprites[name];
        else
            return nullptr;
    }

    //-----------------------------------------------------------------------------
    // Sprite layer code
    //-----------------------------------------------------------------------------

    int sprite_add_layer(sprite s, bitmap new_layer, const string &layer_names)
    {
        if( INVALID_PTR(new_layer, BITMAP_PTR) )
        {
            LOG(WARNING) << "Cannot add non-existing bitmap as layer to sprite";
            return -1;
        }

        if( INVALID_PTR(s, SPRITE_PTR)  )
        {
            LOG(WARNING) << "No sprite to add layer to";
            return -1;
        }

        s->layers.push_back(new_layer);
        int result = static_cast<int>(s->layers.size() - 1);
        s->layer_names[layer_names] = result;
        s->layer_offsets.push_back(vector_to(0,0));

        return result;
    }

    bool sprite_has_layer(sprite s, const string &name)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to access layer details of invalid sprite";
            return false;
        }
        else
        {
            return s->layer_names.count(name) > 0;
        }
    }

    bool sprite_has_layer(sprite s, int idx)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to access layer details of invalid sprite";
            return false;
        }
        else
        {
            return idx >= 0 and idx < s->layers.size();
        }
    }

    bitmap sprite_layer(sprite s, const string &name)
    {
        if ( not sprite_has_layer(s, name) )
        {
            return nullptr;
        }
        else
        {
            return sprite_layer(s, s->layer_names[name]);
        }
    }

    bitmap sprite_layer(sprite s, int idx)
    {
        if ( not sprite_has_layer(s, idx) )
        {
            return nullptr;
        }

        return s->layers[idx];
    }

    int sprite_layer_index(sprite s, const string &name)
    {
        if( not sprite_has_layer(s, name) )
            return -1;
        else
            return s->layer_names[name];
    }

    string sprite_layer_name(sprite s, int idx)
    {
        if ( sprite_has_layer(s, idx) )
        {
            return "";
        }
        else
        {
            string result = "";
            if ( not key_of_value(s->layer_names, idx, result) )
            {
                LOG(WARNING) << "Sprite has invalid state. Please report this issue to the SplashKit dev team.";
            }
            return result;
        }
    }

    int sprite_show_layer(sprite s, const string &name)
    {
        if ( not sprite_has_layer(s, name) )
            return -1;
        else
            return sprite_show_layer(s, s->layer_names[name]);
    }

    int sprite_show_layer(sprite s, int id)
    {
        if( not sprite_has_layer(s, id) )
            return -1;

        //Scan for the current ID
        int result = sprite_visible_index_of_layer(s, id);
        if ( result >= 0 ) return result;

        //Extend layers and add index
        s->visible_layers.push_back(id);

        return static_cast<int>(s->visible_layers.size() - 1);
    }

    void sprite_hide_layer(sprite s, const string &name)
    {
        if ( not sprite_has_layer(s, name) )
            return;
        else
            sprite_hide_layer(s, s->layer_names[name]);
    }

    void sprite_hide_layer(sprite s, int id)
    {
        if ( not sprite_has_layer(s, id) )
            return;

        erase_from_vector(s->visible_layers, id);
    }

    void sprite_toggle_layer_visible(sprite s, const string &name)
    {
        if ( not sprite_has_layer(s, name) )
            return;
        else
            sprite_toggle_layer_visible(s, s->layer_names[name]);
    }

    void sprite_toggle_layer_visible(sprite s, int id)
    {
        if ( not sprite_has_layer(s, id) ) return;

        if ( sprite_visible_index_of_layer(s, id) < 0 )
            sprite_show_layer(s, id);
        else
            sprite_hide_layer(s, id);
    }

    int sprite_layer_count(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to access layer details of invalid sprite";
            return -1;
        }
        else return static_cast<int>(s->layers.size());
    }

    int sprite_visible_layer_count(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to access layer details of invalid sprite";
            return -1;
        }
        else return static_cast<int>(s->visible_layers.size());
    }

    bool sprite_has_visible_layer(sprite s, int idx)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to access layer details of invalid sprite";
            return false;
        }
        else
            return idx >= 0 && idx < s->visible_layers.size();
    }

    int sprite_visible_layer_id(sprite s, int idx)
    {
        if ( not sprite_has_visible_layer(s, idx) ) return -1;
        else
            return s->visible_layers[idx];
    }

    vector_2d sprite_layer_offset(sprite s, const string &name)
    {
        if ( not sprite_has_layer(s, name) ) return vector_to(0,0);
        else return sprite_layer_offset(s, s->layer_names[name]);
    }

    vector_2d sprite_layer_offset(sprite s, int idx)
    {
        if ( not sprite_has_layer(s, idx) ) return vector_to(0,0);
        else return s->layer_offsets[idx];
    }

    void sprite_set_layer_offset(sprite s, const string &name, const vector_2d &value)
    {
        if ( not sprite_has_layer(s, name) ) return;
        sprite_set_layer_offset(s, s->layer_names[name], value);
    }

    void sprite_set_layer_offset(sprite s, int idx, const vector_2d &value)
    {
        if ( not sprite_has_layer(s, idx) )
            return;
        s->layer_offsets[idx] = value;
    }

    int sprite_visible_index_of_layer(sprite s, const string &name)
    {
        if ( not sprite_has_layer(s, name) ) return -1;
        else return sprite_visible_index_of_layer(s, s->layer_names[name]);
    }

    int sprite_visible_index_of_layer(sprite s, int id)
    {
        if ( not sprite_has_layer(s, id) )
            return -1;
        else
            return index_of(s->visible_layers, id);
    }

    int sprite_visible_layer(sprite s, int idx)
    {
        if ( not sprite_has_layer(s, idx) ) return -1;
        else return s->visible_layers[idx];
    }

    void sprite_send_layer_to_back(sprite s, int visible_layer)
    {
        if ( not sprite_has_visible_layer(s, visible_layer) ) return;

        if ( visible_layer < s->visible_layers.size() - 1 )
            move_range(s->visible_layers, sprite_visible_index_of_layer(s, visible_layer), 1, s->visible_layers.size() - 1 );
    }

    void sprite_send_layer_backward(sprite s, int visible_layer)
    {
        if( not sprite_has_visible_layer(s, visible_layer) ) return;

        if ( visible_layer < s->visible_layers.size() - 1 )
            swap(s->visible_layers[visible_layer], s->visible_layers[visible_layer + 1]);
    }

    void sprite_bring_layer_forward(sprite s, int visible_layer)
    {
        if( not sprite_has_visible_layer(s, visible_layer) ) return;

        if ( visible_layer > 0 )
            swap(s->visible_layers[visible_layer], s->visible_layers[visible_layer - 1]);
    }

    void sprite_bring_layer_to_front(sprite s, int visible_layer)
    {
        if( not sprite_has_visible_layer(s, visible_layer) ) return;

        if ( visible_layer > 0 )
            move_range(s->visible_layers, sprite_visible_index_of_layer(s, visible_layer), 1, 0 );
    }

    rectangle sprite_layer_rectangle(sprite s, const string &name)
    {
        if ( not sprite_has_layer(s, name) )
            return rectangle_from(0,0,0,0);
        else
            return sprite_layer_rectangle(s, s->layer_names[name]);
    }

    rectangle sprite_layer_rectangle(sprite s, int idx)
    {
        if ( not sprite_has_layer(s, idx) )
            return rectangle_from(0,0,0,0);
        else
            return bitmap_cell_rectangle(s->layers[idx], point_offset_by(s->position, s->layer_offsets[idx]));
    }

    circle sprite_circle(sprite s)
    {
        return sprite_layer_circle(s, 0);
    }

    circle sprite_layer_circle(sprite s, const string &name)
    {
        if ( not sprite_has_layer(s, name) ) return circle_at(0,0,0);
        else return sprite_layer_circle(s, s->layer_names[name]);
    }

    circle sprite_layer_circle(sprite s, int idx)
    {
        if ( not sprite_has_layer(s, idx) )
            return circle_at(0, 0, 0);
        else
            return bitmap_cell_circle(s->layers[idx], center_point(s), sprite_scale(s));
    }

    int sprite_layer_height(sprite s, const string &name)
    {
        if ( not sprite_has_layer(s, name) )
            return 0;
        else
            return sprite_layer_height(s, s->layer_names[name]);
    }

    int sprite_layer_height(sprite s, int idx)
    {
        if ( not sprite_has_layer(s, idx) )
            return 0;
        else
            return bitmap_cell_height(s->layers[idx]);
    }

    int sprite_layer_width(sprite s, const string &name)
    {
        if ( not sprite_has_layer(s, name) )
            return 0;
        else
            return sprite_layer_width(s, s->layer_names[name]);
    }

    int sprite_layer_width(sprite s, int idx)
    {
        if ( not sprite_has_layer(s, idx) )
            return 0;
        else
            return bitmap_cell_width(s->layers[idx]);
    }

    int sprite_width(sprite s)
    {
        return sprite_layer_width(s, 0);
    }

    int  sprite_height(sprite s)
    {
        return sprite_layer_height(s, 0);
    }

    point_2d center_point(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            return point_at(0,0);
        }

        return point_at(
                        s->position.x + sprite_width(s) / 2.0f,
                        s->position.y + sprite_height(s) / 2.0f);
    }

    //-----------------------------------------------------------------------------
    // Sprite animation related details
    //-----------------------------------------------------------------------------

    void sprite_replay_animation(sprite s)
    {
        sprite_replay_animation(s, true);
    }

    void sprite_replay_animation(sprite s, bool with_sound)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to replay animation with invalid sprite";
            return;
        }

        restart_animation(s->animation_info, with_sound);
        if (not sprite_animation_has_ended(s)) s->announced_animation_end = false;
    }

    void sprite_start_animation(sprite s, const string &named)
    {
        sprite_start_animation(s, named, true);
    }

    void sprite_start_animation(sprite s, const string &named, bool with_sound)
    {

        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }
        if ( INVALID_PTR(s->script, ANIMATION_SCRIPT_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid animation script";
            return;
        }

        int idx = animation_index(s->script, named);
        if ((idx < 0) or (idx >= animation_count(s->script)))
        {
            LOG(WARNING) << "Unable to create animation \"" + named + "\" for sprite " + s->name + " from script " + animation_script_name(s->script);
            return;
        }

        sprite_start_animation(s, idx, with_sound);
    }

    void sprite_start_animation(sprite s, int idx)
    {
        sprite_start_animation(s, idx, true);
    }

    void sprite_start_animation(sprite s, int idx, bool with_sound)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }

        if ( INVALID_PTR(s->script, ANIMATION_SCRIPT_PTR)) return;
        if ( (idx < 0) or (idx >= animation_count(s->script)))
        {
            LOG(WARNING) << "Unable to create animation no. " + to_string(idx) + " for sprite " + s->name + " from script " + animation_script_name(s->script);
            return;
        }

        if ( VALID_PTR(s->animation_info, ANIMATION_PTR) )
            assign_animation(s->animation_info, s->script, idx, with_sound);
        else
            s->animation_info = create_animation(s->script, idx, with_sound);

        if ( not sprite_animation_has_ended(s) )
            s->announced_animation_end = false;
    }

    string sprite_animation_name(sprite s)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
            return animation_name(s->animation_info);
        else
            return "";
    }

    void update_sprite_animation(sprite s)
    {
        update_sprite_animation(s, 1.0, true);
    }

    void update_sprite_animation(sprite s, bool with_sound)
    {
        update_sprite_animation(s, 1.0, with_sound);
    }

    void update_sprite_animation(sprite s, float pct)
    {
        update_sprite_animation(s, pct, true);
    }

    void update_sprite_animation(sprite s, float pct, bool with_sound)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }

        update_animation(s->animation_info, pct, with_sound);
        move_sprite(s, animation_current_vector(s->animation_info), pct);
    }

    rectangle sprite_current_cell_rectangle(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to get details from invalid sprite.";
            return rectangle_from(0,0,0,0);
        }
        else
        {
            return bitmap_rectangle_of_cell(s->layers[0], animation_current_cell(s->animation_info));
        }
    }

    int sprite_current_cell(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to get details from invalid sprite.";
            return -1;
        }
        else
            return animation_current_cell(s->animation_info);
    }

    bool sprite_animation_has_ended(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) ) return false;
        else return animation_ended(s->animation_info);
    }

    //-----------------------------------------------------------------------------
    // Update Sprites
    //-----------------------------------------------------------------------------

    void update_sprite(sprite s)
    {
        update_sprite(s, 1.0, true);
    }

    void update_sprite(sprite s, bool with_sound)
    {
        update_sprite(s, 1.0, with_sound);
    }

    void update_sprite(sprite s, float pct)
    {
        update_sprite(s, pct, true);
    }

    void update_sprite(sprite s, float pct, bool with_sound)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
        {
            move_sprite(s, pct);
            update_sprite_animation(s, pct, with_sound);

            //   if mouse_clicked(LEFT_BUTTON) and circle_circle_collision(sprite_collision_circle(s), circle_at(mouse_x(), mouse_y(), 17))
            //   {
            //     sprite_raise_event(s, sprite_touched_event);
            //   }

            if ( mouse_clicked(LEFT_BUTTON) and circles_intersect(sprite_collision_circle(s), circle_at(mouse_x(), mouse_y(), 1)))
            {
                sprite_raise_event(s, SPRITE_CLICKED_EVENT);
            }

            if ( sprite_animation_has_ended(s) and (not s->announced_animation_end) )
            {
                s->announced_animation_end = true;
                sprite_raise_event(s, SPRITE_ANIMATION_ENDED_EVENT);
            }
        }
    }

    //-----------------------------------------------------------------------------
    // Sprite drawing
    //-----------------------------------------------------------------------------

    void draw_sprite(sprite s)
    {
        draw_sprite(s, 0, 0);
    }

    void draw_sprite(sprite s, const vector_2d &offset)
    {
        draw_sprite(s, offset.x, offset.y);
    }

    void draw_sprite(sprite s, double x_offset, double y_offset)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }

        float angle = sprite_rotation(s);
        drawing_options opts;

        if (angle != 0)
            opts = option_rotate_bmp( angle,
                                     s->anchor_point.x - sprite_layer_width(s, 0) / 2.0f,
                                     s->anchor_point.y  - sprite_layer_height(s, 0) / 2.0f );
        else
            opts = option_defaults();

        float scale = sprite_scale(s);
        if (scale != 1)
            opts = option_scale_bmp( scale, scale, opts );

        opts = option_with_animation( s->animation_info, opts );

        int idx;
        for (int i = 0; i < s->visible_layers.size(); i++)
        {
            idx = s->visible_layers[i];
            if ( s->draw_at_anchor_point )
                draw_bitmap(
                            sprite_layer(s, idx),
                            s->position.x - s->anchor_point.x + x_offset + s->layer_offsets[idx].x,
                            s->position.y -s->anchor_point.y + y_offset + s->layer_offsets[idx].y,
                            opts);
            else
                draw_bitmap(
                            sprite_layer(s, idx),
                            s->position.x + x_offset + s->layer_offsets[idx].x,
                            s->position.y + y_offset + s->layer_offsets[idx].y,
                            opts);
        }
    }

    rectangle sprite_screen_rectangle(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) or INVALID_PTR(s->animation_info, ANIMATION_PTR) )
            return rectangle_from(0,0,0,0);
        else
            return to_screen(sprite_layer_rectangle(s, 0));
    }

    point_2d sprite_anchor_point(sprite s)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
        {
            return s->anchor_point;
        }
        else
        {
            LOG(WARNING) << "Attempting to get anchor point of invalid sprite";
            return point_at(0,0);
        }
    }

    void sprite_set_anchor_point(sprite s, const point_2d &pt)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
        {
            s->anchor_point = pt;
        }
        else
        {
            LOG(WARNING) << "Attempting to set anchor point of invalid sprite";
        }
    }

    point_2d sprite_anchor_position(sprite s)
    {
        point_2d result = sprite_position(s);
        point_2d anchor = sprite_anchor_point(s);
        result.x += anchor.x;
        result.y += anchor.y;
        return result;
    }

    //-----------------------------------------------------------------------------
    // Sprite Movement
    //-----------------------------------------------------------------------------

    void move_sprite(sprite s, const vector_2d &distance )
    {
        move_sprite(s, distance, 1.0);
    }

    void move_sprite(sprite s, const vector_2d &distance, float pct)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "No sprite supplied to move_sprite";
            return;
        }

        vector_2d mvmt;
        float angle = sprite_rotation(s);

        if (angle != 0)
        {
            matrix_2d trans = rotation_matrix(angle);
            mvmt = matrix_multiply(trans, distance);
        }
        else
        {
            mvmt = distance;
        }

        s->position.x += pct * mvmt.x;
        s->position.y += pct * mvmt.y;

        if ( s->is_moving )
        {
            pct = (timer_ticks(_sprite_timer) - s->last_update) / 1000;

            if ( pct <= 0 ) return;

            s->last_update = timer_ticks(_sprite_timer);

            s->position.x += pct * s->moving_vec.x;
            s->position.y += pct * s->moving_vec.y;

            s->arrive_in_sec -= pct;
            if ( s->arrive_in_sec <= 0 )
            {
                s->is_moving = false;
                s->arrive_in_sec = 0;

                sprite_raise_event(s, SPRITE_ARRIVED_EVENT);
            }
        }
    }

    void move_sprite_to(sprite s, double x, double y)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "No sprite supplied";
            return;
        }

        s->position.x = x;
        s->position.y = y;

        if (s->position_at_anchor_point)
        {
            s->position.x -= s->anchor_point.x;
            s->position.y -= s->anchor_point.y;
        }
    }

    void move_sprite(sprite s)
    {
        move_sprite(s, 1.0);
    }

    void move_sprite(sprite s, float pct)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
            move_sprite(s, s->velocity, pct);
    }

    vector_2d sprite_velocity(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return vector_to(0,0);
        }

        return s->velocity;
    }

    void sprite_set_velocity(sprite s, const vector_2d &value)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }

        s->velocity = value;
    }

    void sprite_add_to_velocity(sprite s, const vector_2d &value)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }

        s->velocity = vector_add(s->velocity, value);
    }

    void sprite_set_x(sprite s, double value)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }

        s->position.x = value;
    }

    double sprite_x(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return 0;
        }

        return s->position.x;
    }

    void sprite_set_y(sprite s, double value)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }

        s->position.y = value;
    }

    double sprite_y(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return 0;
        }

        return s->position.y;
    }

    point_2d sprite_position(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return point_at(0,0);
        }
        else
        {
            return s->position;
        }
    }

    void sprite_set_position(sprite s, const point_2d &value)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
        {
            s->position = value;
        }
        else
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
        }
    }

    void sprite_set_dx(sprite s, double value)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
        {
            s->velocity.x = value;
        }
        else
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
        }
    }

    double sprite_dx(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return 0;
        }
        else
        {
            return s->velocity.x;
        }

    }

    void sprite_set_dy(sprite s, double value)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
        {
            s->velocity.y = value;
        }
        else
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
        }
    }

    double sprite_dy(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return 0;
        }
        else
        {
            return s->velocity.y;
        }
    }

    double sprite_speed(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
            return 0;
        else
            return vector_magnitude(s->velocity);
    }

    void sprite_set_speed(sprite s, double value)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
        }
        if (value == 0.0)
        {
            s->velocity = vector_to(0.0, 0.0);
        }
        else if (vector_magnitude(s->velocity) == 0.0)
        {
            s->velocity = vector_to(1.0, 0.0);
        }
        s->velocity = vector_multiply(unit_vector(s->velocity), value);
    }

    float sprite_heading(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
            return 0;
        else
            return vector_angle(s->velocity);
    }

    void sprite_set_heading(sprite s, float value)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
            s->velocity = vector_from_angle(value, vector_magnitude(s->velocity));
    }

    bool sprite_move_from_anchor_point(sprite s)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
            return s->position_at_anchor_point;
        else
            return false;
    }

    void sprite_set_move_from_anchor_point(sprite s, bool value)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
        {
            s->position_at_anchor_point = value;
        }
    }

    bool sprite_draw_at_anchor_point(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR)) return false;
        return s->draw_at_anchor_point;
    }

    void sprite_set_draw_at_anchor_point(sprite s, bool value)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) ) return;
        s->draw_at_anchor_point = value;
    }

    void sprite_move_to(sprite s, const point_2d &pt, float taking_seconds)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }

        s->destination = pt;
        s->arrive_in_sec = taking_seconds;
        s->is_moving = true;
        s->moving_vec = vector_multiply(unit_vector(vector_point_to_point(center_point(s), pt)), point_point_distance(center_point(s), pt) / taking_seconds);
        s->last_update = timer_ticks(_sprite_timer);
    }

    matrix_2d sprite_location_matrix(sprite s)
    {
        matrix_2d result = identity_matrix();

        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return result;
        }

        float scale = sprite_scale(s);
        float w = sprite_layer_width(s, 0);
        float h = sprite_layer_height(s, 0);

        matrix_2d anchor_matrix = translation_matrix(sprite_anchor_point(s));

        result = matrix_multiply(result, matrix_inverse(anchor_matrix));
        result = matrix_multiply(result, rotation_matrix(sprite_rotation(s)));
        result = matrix_multiply(result, anchor_matrix);

        float new_x = sprite_x(s) - (w * scale / 2.0) + (w / 2.0);
        float new_y = sprite_y(s) - (h * scale / 2.0) + (h / 2.0);
        result = matrix_multiply(result, translation_matrix(new_x / scale, new_y / scale));

        return matrix_multiply(result, scale_matrix(scale));
    }

    //---------------------------------------------------------------------------
    // Sprite values
    //---------------------------------------------------------------------------

    float sprite_mass(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "sprite_mass: Attempting to use invalid sprite";
            return 0;
        }
        else
        {
            return s->values[MASS_KEY];
        }

    }

    void sprite_set_mass(sprite s, float value)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
            s->values[MASS_KEY] = value;
    }

    float sprite_rotation(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "sprite_rotation: Attempting to use invalid sprite";
            return 0;
        }
        else
        {
            return s->values[ROTATION_KEY];
        }

    }

    void sprite_set_rotation(sprite s, float value)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
        {
            if (value < 0)
            {
                value = 360 + (value + abs((long long)(trunc(value / 360) * 360)));
            }

            if (value >= 360)
            {
                value = value - trunc(value / 360) * 360;
            }

            s->values[ROTATION_KEY] = value;
        }
        else
        {
            LOG(WARNING) << "sprite_set_rotation: Attempting to use invalid sprite";
        }
    }

    float sprite_scale(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
            return 0;
        else
            return s->values[SCALE_KEY];
    }

    void sprite_set_scale(sprite s, float value)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
        {
            s->values[SCALE_KEY] = value;
        }
    }

    int sprite_value_count(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return -1;
        }

        return static_cast<int>(s->values.size());
    }

    bool sprite_has_value(sprite s, string name)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return false;
        }

        return s->values.count(name) > 0;
    }

    float sprite_value(sprite s, const string &name)
    {
        if ( not sprite_has_value(s, name) )
        {
            return 0;
        }
        return s->values[name];
    }

    void sprite_add_value(sprite s, const string &name)
    {
        sprite_add_value(s, name, 0);
    }

    void sprite_add_value(sprite s, const string &name, float init_val)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }

        if ( sprite_has_value(s, name) ) return;

        s->values[name] = init_val;
    }

    void sprite_set_value(sprite s, const string &name, float val)
    {
        if ( not sprite_has_value(s, name) )
        {
            LOG(WARNING) << "Attempting to use invalid sprite";
            return;
        }

        s->values[name] = val;
    }

    //---------------------------------------------------------------------------
    // Event Code
    //---------------------------------------------------------------------------

    void call_on_sprite_event(sprite_event_handler *handler)
    {
        _global_sprite_event_handlers.push_back(handler);
    }

    void stop_calling_on_sprite_event(sprite_event_handler *handler)
    {
        erase_from_vector(_global_sprite_event_handlers, handler);
    }

    void sprite_call_on_event(sprite s, sprite_event_handler *handler)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
        {
            s->evts.push_back(handler);
        }
    }

    void sprite_stop_calling_on_event(sprite s, sprite_event_handler *handler)
    {
        if ( VALID_PTR(s, SPRITE_PTR) )
        {
            erase_from_vector(s->evts, handler);
        }
    }

    //---------------------------------------------------------------------------
    // sprite Packs
    //---------------------------------------------------------------------------

    // Duplicate for the update_sprite for use in update_all_sprites... as it
    // currently does not select the correct overload.
    void _update_sprite_pct(void *s, float pct)
    {
        update_sprite(static_cast<sprite>(s), pct);
    }

    void _draw_sprite(void *s)
    {
        draw_sprite(static_cast<sprite>(s));
    }

    void _free_sprite(void *s)
    {
        free_sprite(static_cast<sprite>(s));
    }

    void _call_for_all_sprites(vector<void *> &sprites, sprite_function *fn)
    {
        for(void *s : sprites)
        {
            fn(s);
        }
    }

    void _call_for_all_sprites(vector<void *> &sprites, sprite_float_function *fn, float val)
    {
        // use a local copy so changes to the sprite pack do not effect loop
        vector<void *> local_copy = sprites;
        for(void *s : local_copy)
        {
            fn(s, val);
        }
    }

    void draw_all_sprites()
    {
        call_for_all_sprites(&_draw_sprite);
    }

    void update_all_sprites(float pct)
    {
        call_for_all_sprites(&_update_sprite_pct, pct);
    }

    void call_for_all_sprites(sprite_function *fn)
    {
        _call_for_all_sprites(current_pack(), fn);
    }

    void call_for_all_sprites(sprite_float_function *fn, float val)
    {
        _call_for_all_sprites(current_pack(), fn, val);
    }

    void update_all_sprites()
    {
        update_all_sprites(1.0);
    }

    bool has_sprite_pack(const string &name)
    {
        return _sprite_packs.count(name) > 0;
    }


    void create_sprite_pack(const string &name)
    {
        if ( not has_sprite_pack(name) )
        {
            _sprite_packs[name].resize(0);
        }
        else
        {
            LOG(WARNING) << "The sprite_pack " + name + " already exists";
        }
    }

    string current_sprite_pack()
    {
        return _current_pack;
    }

    void select_sprite_pack(const string &name)
    {
        if ( has_sprite_pack(name) )
            _current_pack = name;
        else
            LOG(WARNING) << "No sprite_pack named " + name + " to select.";
    }

    void free_sprite_pack(const string &name)
    {
        if  (not has_sprite_pack(name)) return;

        // TODO: Temporarily do not call due to 70c30d4
        vector<void *> &pack = _sprite_packs[name];
        _call_for_all_sprites(pack, &_free_sprite);

        _sprite_packs.erase(name);
    }

    void free_all_sprite_packs()
    {
        size_t sz = _sprite_packs.size();

        for(size_t i = 0; i < sz; i++)
        {
            string name = _sprite_packs.begin()->first;
            free_sprite_pack(name);
        }

        _current_pack = INITIAL_PACK_NAME;
    }

    //---------------------------------------------------------------------------
    // sprite collision details
    //---------------------------------------------------------------------------

    bool sprite_offscreen(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR))
            return false;
        else
            return not rectangles_intersect(sprite_layer_rectangle(s, 0), screen_rectangle());
    }


    bool sprite_on_screen_at(sprite s, double x, double y)
    {
        return sprite_on_screen_at(s, point_at(x, y));
    }

    bool sprite_on_screen_at(sprite s, const point_2d &pt)
    {
        return sprite_at(s, to_world(pt));
    }

    bool sprite_at(sprite s, const point_2d &pt)
    {
        return sprite_point_collision(s, pt);
    }

    rectangle sprite_collision_rectangle(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
            return rectangle_from(0,0,0,0);
        else if (sprite_rotation(s) == 0 and sprite_scale(s) == 1)
            return bitmap_cell_rectangle(s->collision_bitmap, s->position);
        else
        {
            int cw = bitmap_cell_width(s->collision_bitmap);
            int ch = bitmap_cell_height(s->collision_bitmap);

            point_2d pts[4];
            pts[0] = point_at(0, 0);
            pts[1] = point_at(0, ch - 1);
            pts[2] = point_at(cw - 1, 0);
            pts[3] = point_at(cw - 1, ch - 1);

            matrix_2d m = sprite_location_matrix(s);

            for (int i = 0; i < 4; i++)
            {
                pts[i] = matrix_multiply(m, pts[i]);
            }

            float min_x = pts[0].x;
            float max_x = pts[0].x;
            float min_y = pts[0].y;
            float max_y = pts[0].y;

            for (int i = 1; i < 4; i++)
            {
                if ( pts[i].x < min_x ) min_x = pts[i].x;
                else if ( pts[i].x > max_x ) max_x = pts[i].x;

                if ( pts[i].y < min_y ) min_y = pts[i].y;
                else if ( pts[i].y > max_y ) max_y = pts[i].y;
            }

            return rectangle_from(min_x, min_y, max_x - min_x, max_y - min_y);
        }
    }

    circle sprite_collision_circle(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) or INVALID_PTR(s->collision_bitmap, BITMAP_PTR) )
            return circle_at(0, 0, 0);
        else
            return bitmap_cell_circle(s->collision_bitmap, center_point(s), sprite_scale(s));
    }

    collision_test_kind sprite_collision_kind(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
            return AABB_COLLISIONS;
        else
            return s->collision_kind;
    }

    void sprite_set_collision_kind(sprite s, collision_test_kind value)
    {
        if ( VALID_PTR(s, SPRITE_PTR) ) s->collision_kind = value;
    }

    bitmap sprite_collision_bitmap(sprite s)
    {
        if ( INVALID_PTR(s, SPRITE_PTR) )
            return nullptr;
        else
            return s->collision_bitmap;
    }

    void sprite_set_collision_bitmap(sprite s, bitmap bmp)
    {
        if ( VALID_PTR(s, SPRITE_PTR) ) s->collision_bitmap = bmp;
    }
}
