/**
 * @header  sprites
 * @author  Andrew Cain
 * @brief   SplashKit Sprites allows you to create images you can easily
 *          move and animate.
 *
 * SplashKit sprites are game elements that can be moved, and animated. Sprites
 * are located at a position in the game, have a velocity, and an animation.
 * The sprite can also have arbitary data associated with it for game specific
 * purposes.
 *
 * @attribute group  sprites
 * @attribute static sprite
 */

#ifndef sprites_h
#define sprites_h

#include "matrix_2d.h"
#include "types.h"
namespace splashkit_lib
{
    /**
     *  This enumeration contains a list of all of the different kinds of
     *  events that a Sprite can raise. When the event is raised the assocated
     *  sprite_event_kind value passed to the event handler to indicate the
     *  kind of event that has occurred.
     *
     *  @constant SPRITE_ARRIVED_EVENT   The sprite has arrived at the end of a move
     *  @constant SPRITE_ANIMATION_ENDED_EVENT The Sprite's animation has ended.
     *  @constant SPRITE_TOUCHED_EVENT         The Sprite was touched
     *  @constant SPRITE_CLICKED_EVENT         The Sprite was touched
     */
    enum sprite_event_kind
    {
        SPRITE_ARRIVED_EVENT,
        SPRITE_ANIMATION_ENDED_EVENT,
        SPRITE_TOUCHED_EVENT,
        SPRITE_CLICKED_EVENT
    };

    /**
     * This enumeration can be used to set the kind of collisions a sprite will check for.
     *
     * @constant PIXEL_COLLISIONS   The sprite will check for collisions with its collision bitmap.
     * @constant AABB_COLLISIONS    The sprite will check for collisions with a bounding box around the sprite.
     */
    enum collision_test_kind
    {
        PIXEL_COLLISIONS,
        AABB_COLLISIONS
    };

    /**
     * Sprites combine an image, with position and animation details. You can
     * create a sprite using `create_sprite`, draw it with `draw_sprite`, move it
     * using the `sprite_velocity` with `update_sprite`, and animate it using an
     * `animation_script`.
     *
     * @attribute class sprite
     */
    typedef struct _sprite_data *sprite;

    /**
     *  The sprite_event_handler function pointer is used when you want to register
     *  to receive events from a Sprite.
     *
     * @param s  The `sprite` raising the event.
     * @param evt  The `sprite_event_kind` being raised.
     */
    typedef void (sprite_event_handler) (void *s, int evt);

    /**
     *  sprite_function is used with SpritePacks to provide a procedure to be
     *  called for each of the Sprites in the SpritePack.
     *
     * @param s The `sprite` being passed to the sprite function.
     */
    typedef void (sprite_function)(void *s);

    /**
     *  The sprite single function is used with sprite packs to provide a
     *  procedure to be called for each of the Sprites in the sprite pack,
     *  where a float value is required.
     *
     * @param s The `sprite` being passed to the sprite function.
     * @param f The value to be passed to the function.
     */
    typedef void (sprite_float_function)(void *s, float f);

    //---------------------------------------------------------------------------
    // sprite creation routines
    //---------------------------------------------------------------------------

    /**
     * Creates a sprite for the passed in bitmap image. The sprite will use the
     * cell information within the bitmap if it is animated at a later stage.
     *
     * This version of create_sprite will initialise the sprite to use
     * pixel level collisions, no animations, and have one layer named 'layer1'.
     * This version of the constructor will assign a default name to the sprite
     * for resource management purposes.
     *
     * @param layer   The bitmap for the sprite's image.
     * @returns       The new sprite with image.
     *
     * @attribute class sprite
     * @attribute constructor true
     */
    sprite create_sprite(bitmap layer);

    /**
     * Creates a sprite for the passed in bitmap image. The sprite will use the
     * cell information within the bitmap if it is animated at a later stage.
     *
     * This version of create_sprite will initialise the sprite to use
     * pixel level collisions, no animations, and have one layer named 'layer1'.
     * This version of the constructor will assign a default name to the sprite
     * for resource management purposes.
     *
     * @param bitmap_name   The name of the bitmap to use as the sprite's layer
     * @returns       The new sprite with image.
     *
     * @attribute class sprite
     * @attribute constructor true
     *
     * @attribute suffix  with_bitmap_named
     */
    sprite create_sprite(const string &bitmap_name);

    /**
     * Creates a sprite. The bitmap_name is used to indicate the bitmap the sprite
     * will use, and the animation_name is used to indicate which animation_script
     * to use.
     *
     * @param bitmap_name     The name of the bitmap to use as the sprite's image.
     * @param animation_name  The name of the animation script to use for this
     *                        sprite.
     * @returns                The new sprite with the image and animation.
     *
     * @attribute class sprite
     * @attribute constructor true
     *
     * @attribute suffix  with_bitmap_and_animation_named
     */
    sprite create_sprite(const string &bitmap_name, const string &animation_name);

    /**
     * Creates a sprite for the passed in bitmap image. The sprite will use the
     * cell information within the bitmap if it is animated at a later stage.
     * This version of `create_sprite` will initialise the sprite to use
     * pixel level collisions, the specified animation template, the layer have
     * name 'layer1'.
     *
     * This version of the constructor will assign a default name to the sprite
     * for resource management purposes.
     *
     * @param layer   The bitmap for the sprite's image.
     * @param ani     The animation script for the sprite's animations.
     * @returns       The new sprite with image and animation script.
     *
     * @attribute class sprite
     * @attribute constructor true
     *
     * @attribute suffix  with_animation
     */
    sprite create_sprite(bitmap layer, animation_script ani);

    /**
     * Creates a sprite for the passed in bitmap image. The sprite will use the
     * cell information within the sprite if it is animated at a later stage.
     * This version of create_sprite will initialise the sprite to use pixel level
     * collisions, no animation, the layer have name 'layer1'.
     *
     * @param name    The name of the sprite for resource management.
     * @param layer   The bitmap for the sprite's image.
     * @returns       The new sprite with image and name.
     *
     * @attribute class sprite
     * @attribute constructor true
     *
     * @attribute suffix  named
     */
    sprite create_sprite(const string &name, bitmap layer);

    /**
     * Creates a sprite for the passed in bitmap image. The sprite will use the cell
     * information within the sprite if it is animated at a later stage. This
     * version of create_sprite will initialise the sprite to use pixel level
     * collisions, the specified animation template, the layer have name 'layer1'.
     *
     * @param name    The name of the sprite for resource management.
     * @param layer   The bitmap for the sprite's image.
     * @param ani     The animation script for the sprite's animations.
     * @returns       The new sprite with image, animation, and name.
     *
     * @attribute class sprite
     * @attribute constructor true
     *
     * @attribute suffix  named_with_animation
     */
    sprite create_sprite(const string &name, bitmap layer, animation_script ani);

    /**
     * Free the resources associated with a sprite.
     *
     * @param s   The sprite to be destroyed.
     *
     * @attribute class sprite
     * @attribute destructor true
     */
    void free_sprite(sprite s);

    //---------------------------------------------------------------------------
    // sprite Resource management code
    //---------------------------------------------------------------------------

    /**
     * Determines if SplashKit has a sprite for the supplied name.
     * This checks against all sprites, those loaded without a name
     * are assigned a default.
     *
     * @param name  The name of the sprite to locate.
     * @returns     True if you have created a sprite with this name.
     */
    bool has_sprite(const string &name);

    /**
     * Returns the `sprite` with the specified name.
     *
     * @param name  The name of the sprite to locate.
     * @returns     The sprite with that name.
     */
    sprite sprite_named(const string &name);

    /**
     * Releases all of the sprites that have been loaded.
     */
    void free_all_sprites();

    //---------------------------------------------------------------------------
    // Event Code
    //---------------------------------------------------------------------------

    /**
     * Register a procedure to be called when an events occur on any sprite.
     *
     * @param handler The function to call when any sprite raises an event
     */
    void call_on_sprite_event(sprite_event_handler *handler);

    /**
     * Removes an global event handler, stopping events calling the indicated void.
     *
     * @param handler The function to remove from the list of sprite event handlers.
     */
    void stop_calling_on_sprite_event(sprite_event_handler *handler);

    /**
     * Register a procedure to call when events occur on the sprite.
     *
     * @param s       The sprite to add the handler to.
     * @param handler The function to call when this sprite raises an event.
     *
     * @attribute class   sprite
     * @attribute method  call_on_event
     * @attribute self    s
     */
    void sprite_call_on_event(sprite s, sprite_event_handler *handler);

    /**
     * Removes an event handler from the sprite, stopping events from this
     * sprite calling the indicated method.
     *
     * @param s       The sprite to remove the handler from
     * @param handler The function to remove from this sprites handlers
     *
     * @attribute class   sprite
     * @attribute method  stop_calling_on_event
     * @attribute self    s
     */
    void sprite_stop_calling_on_event(sprite s, sprite_event_handler *handler);

    //---------------------------------------------------------------------------
    // layer code
    //---------------------------------------------------------------------------

    /**
     * Adds a new layer to the sprite.
     *
     * @param s           The sprite to add the layer to.
     * @param new_layer   The new layer's bitmap.
     * @param layer_name  The name of the new layer.
     *
     * @returns The index of the new layer.
     *
     * @attribute class   sprite
     * @attribute method  add_layer
     * @attribute self    s
     */
    int sprite_add_layer(sprite s, bitmap new_layer, const string &layer_name);

    /**
     * Returns the bitmap of the indicated layer of the sprite.
     *
     * @param s     The sprite to get the layer from
     * @param name  The name of the layer to fetch
     * @returns     The bitmap at the layer with the indicated name
     *
     * @attribute class sprite
     * @attribute method layer
     *
     * @attribute suffix  named
     */
    bitmap sprite_layer(sprite s, const string &name);

    /**
     * Returns the bitmap of the indicated layer of the sprite.
     *
     * @param s   The sprite to get the layer from
     * @param idx The index of the layer
     *
     * @returns   The bitmap of the sprite at that layer
     *
     * @attribute class sprite
     * @attribute method layer
     *
     * @attribute suffix  at_index
     */
    bitmap sprite_layer(sprite s, int idx);

    /**
     * Returns the index of the specified layer.
     *
     * @param s     The sprite to get the layer from
     * @param name  The name of the layer to get the index of
     * @returns     The index of the layer in the sprite
     *
     * @attribute class sprite
     * @attribute method Index_of_layer
     */
    int sprite_layer_index(sprite s, const string &name);

    /**
     * Returns the name of the specified layer.
     *
     * @param s   The sprite to get the layer name from
     * @param idx The index of the layer you want the name of
     * @returns   The name of the sprite's layer at that index
     *
     * @attribute class sprite
     * @attribute method layer_name
     */
    string sprite_layer_name(sprite s, int idx);

    /**
     * Show the specified layer of the sprite.
     *
     * @param s     The sprite to show the layer of.
     * @param name  The layer to show.
     * @returns     The index of the layer shown, or -1 if no layer found.
     *
     * @attribute class sprite
     * @attribute method show_layer
     * @attribute suffix named
     */
    int sprite_show_layer(sprite s, const string &name);

    /**
     * Show the specified layer of the sprite.
     *
     * @param s     The sprite to show the layer of.
     * @param id    The index to show.
     * @returns     The index of the layer shown, or -1 if no layer found.
     *
     * @attribute class sprite
     * @attribute method show_layer
     */
    int sprite_show_layer(sprite s, int id);

    /**
     * Hide the specified layer of the sprite.
     *
     * @param s     The sprite to hide the layer of.
     * @param name  The name of the layer to hide.
     *
     * @attribute class sprite
     * @attribute method hide_layer
     * @attribute suffix named
     */
    void sprite_hide_layer(sprite s, const string &name);

    /**
     * Hide the specified layer of the sprite.
     *
     * @param s     The sprite to hide the layer of.
     * @param id    The index of the layer to hide.
     *
     * @attribute class sprite
     * @attribute method Hide_layer
     */
    void sprite_hide_layer(sprite s, int id);

    /**
     * Toggle the visibility of the specified layer of the sprite.
     *
     * @param s     The sprite to change.
     * @param name  The name of the layer to toggle.
     *
     * @attribute class sprite
     * @attribute method toggle_layer_visible
     * @attribute suffix named
     */
    void sprite_toggle_layer_visible(sprite s, const string &name);

    /**
     * Toggle the visibility of the specified layer of the sprite.
     *
     * @param s     The sprite to change.
     * @param id    The index of the layer to toggle.
     *
     * @attribute class sprite
     * @attribute method Toggle_layer_visible
     */
    void sprite_toggle_layer_visible(sprite s, int id);

    /**
     * Returns the index (z-order) of the sprite's layer.
     *
     * @param s     The sprite to get the details from.
     * @param name  The name of the layer to get the z index of.
     * @returns     The z index of the sprite's layer
     *
     * @attribute class sprite
     * @attribute method visible_index_of_layer
     * @attribute suffix named
     */
    int sprite_visible_index_of_layer(sprite s, const string &name);

    /**
     * Returns the index (z-order) of the sprite's layer.
     *
     * @param s     The sprite to get the details from.
     * @param id    The index of the layer to get the z index of.
     * @returns     The z index of the sprite's layer
     *
     * @attribute class sprite
     * @attribute method visible_index_of_layer
     */
    int sprite_visible_index_of_layer(sprite s, int id);

    /**
     * Returns the number of layers within the sprite.
     *
     * @param s   The sprite to get the layer count from.
     * @returns   The number of image layers in the sprite.
     *
     * @attribute class sprite
     * @attribute getter layer_count
     */
    int sprite_layer_count(sprite s);

    /**
     * Returns the number of layers that are currently visible for the sprite.
     *
     * @param s   The sprite to get the details from.
     * @returns   The number of visible layers for the sprite.
     *
     * @attribute class sprite
     * @attribute getter visible_layer_count
     */
    int sprite_visible_layer_count(sprite s);

    /**
     * Returns the id of the layer at index `idx` that is currently visible.
     * Index 0 is the background, with larger indexes moving toward the foreground.
     * This returns -1 if there are no visible layers.
     *
     * @param s   The sprite to get the details from.
     * @param idx The index of the visible layer.
     * @returns   The layer index of the visible layer.
     *
     * @attribute class sprite
     * @attribute method visible_layer_id_at
     */
    int sprite_visible_layer_id(sprite s, int idx);

    /**
     * Gets the offset of the specified layer.
     *
     * @param s     The sprite to get the details from.
     * @param name  The name of the layer to get the offset of.
     * @returns     The offset of the named layer in the sprite.
     *
     * @attribute class sprite
     * @attribute method layer_offset
     * @attribute suffix named
     */
    vector_2d sprite_layer_offset(sprite s, const string &name);

    /**
     * Gets the offset of the specified layer.
     *
     * @param s     The sprite to get the details from.
     * @param idx   The index of the layer to get the offset of.
     * @returns     The offset of the layer in the sprite.
     *
     * @attribute class sprite
     * @attribute method layer_offset
     */
    vector_2d sprite_layer_offset(sprite s, int idx);

    /**
     * Sets the offset of the specified layer. The offset is used when the layer
     * is drawn in the sprite, and moves the image relative to the sprite.
     *
     * @param s     The sprite to change.
     * @param name  The name of the layer to change.
     * @param value The new offset.
     *
     * @attribute class sprite
     * @attribute method set_layer_offset
     * @attribute suffix named
     */
    void sprite_set_layer_offset(sprite s, const string &name, const vector_2d &value);

    /**
     * Sets the offset of the specified layer.
     *
     * @param s     The sprite to change.
     * @param idx   The index of the layer to change.
     * @param value The new offset.
     *
     * @attribute class sprite
     * @attribute method set_layer_offset
     * @attribute suffix at_index
     */
    void sprite_set_layer_offset(sprite s, int idx, const vector_2d &value);

    /**
     * Returns the index of the n'th (idx parameter) visible layer.
     *
     * @param s     The sprite to get the details from.
     * @param idx   The index of the visible layer to fetch.
     * @returns     The layer index of the selected visible layer.
     *
     * @attribute class sprite
     * @attribute method visible_layer
     */
    int sprite_visible_layer(sprite s, int idx);

    /**
     * Sends the layer specified to the back in the visible layer order.
     *
     * @param s             The sprite to change
     * @param visible_layer The visible layer to send to back
     *
     * @attribute class sprite
     * @attribute method send_layer_to_back
     */
    void sprite_send_layer_to_back(sprite s, int visible_layer);

    /**
     * Sends the layer specified backward in the visible layer order.
     *
     * @param s             The sprite to change
     * @param visible_layer The visible layer to send to backward
     *
     * @attribute class sprite
     * @attribute method Send_layer_toBackward
     */
    void sprite_send_layer_backward(sprite s, int visible_layer);

    /**
     * Sends the layer specified forward in the visible layer order.
     *
     * @param s             The sprite to change
     * @param visible_layer The visible layer to bring forward
     *
     * @attribute class sprite
     * @attribute method send_layer_forward
     */
    void sprite_bring_layer_forward(sprite s, int visible_layer);

    /**
     * Sends the layer specified to the front in the visible layer order.
     *
     * @param s             The sprite to change
     * @param visible_layer The visible layer to bring to the front
     *
     * @attribute class sprite
     * @attribute method Send_layer_toFront
     */
    void sprite_bring_layer_to_front(sprite s, int visible_layer);

    /**
     * Gets a rectangle that surrounds the indicated layer.
     *
     * @param s     The sprite to get the details from.
     * @param name  The name of the layer.
     * @returns     A bounding rectangle that surrounds the sprite's layer
     *
     * @attribute class sprite
     * @attribute method layer_rectangle
     *
     * @attribute suffix  named
     */
    rectangle sprite_layer_rectangle(sprite s, const string &name);

    /**
     * Gets a rectangle that surrounds the indicated layer.
     *
     * @param s     The sprite to get the details from.
     * @param idx   The index of the layer.
     * @returns     A bounding rectangle that surrounds the sprite's layer
     *
     * @attribute class sprite
     * @attribute method layer_rectangle
     *
     * @attribute suffix  at_index
     */
    rectangle sprite_layer_rectangle(sprite s, int idx);

    /**
     * Returns the collision rectangle for the specified sprite.
     *
     * @param s     The sprite to get the details from.
     * @returns     A collision rectangle that surrounds the sprite.
     *
     * @attribute class sprite
     * @attribute getter collision_rectangle
     */
    rectangle sprite_collision_rectangle(sprite s);

    /**
     * Gets a circle in the bounds of the indicated layer.
     *
     * @param s     The sprite to get the details from.
     * @param name  The name of the layer.
     * @returns     A bounding circle that surrounds the sprite's layer
     *
     * @attribute class sprite
     * @attribute method layer_circle
     *
     * @attribute suffix  named
     */
    circle sprite_layer_circle(sprite s, const string &name);

    /**
     * Gets a circle in the bounds of the indicated layer.
     *
     * @param s     The sprite to get the details from.
     * @param idx   The index of the layer.
     * @returns     A bounding circle that surrounds the sprite's layer
     *
     * @attribute class sprite
     * @attribute method layer_circle
     *
     * @attribute suffix  at_index
     */
    circle sprite_layer_circle(sprite s, int idx);

    /**
     * Gets a circle in the bounds of the base layer of the indicated sprite.
     *
     * @param s     The sprite to get the details from.
     * @returns     A bounding circle that surrounds the sprite
     *
     * @attribute class sprite
     * @attribute method circle
     */
    circle sprite_circle(sprite s);

    /**
     * Gets a circle in the bounds of the indicated sprite's collision rectangle.
     *
     * @param s     The sprite to get the details from.
     * @returns     A bounding circle that surrounds the sprite
     *
     * @attribute class sprite
     * @attribute method collision_circle
     */
    circle sprite_collision_circle(sprite s);

    /**
     * Returns a matrix that can be used to transform points into the coordinate
     * space of the passed in sprite.
     *
     * @param s     The sprite to get the details from.
     * @returns     A matrix that transforms points into the sprites coordinate
     *              space.
     *
     * @attribute class sprite
     * @attribute getter location_matrix
     */
    matrix_2d sprite_location_matrix(sprite s);

    //---------------------------------------------------------------------------
    // sprite animation code
    //---------------------------------------------------------------------------

    /**
     * Restart the sprite's current animation, this will play a sound if the
     * first cell of the animation is associated with a sound effect.
     *
     * @param s The sprite to replay the animation of.
     *
     * @attribute class sprite
     * @attribute method Replay_animation
     */
    void sprite_replay_animation(sprite s);

    /**
     * Restart the sprite's current animation, this will play a sound if
     * with_sound is true and the first cell of the animation is associated
     * with a sound effect.
     *
     * @param s           The sprite to replay the animation of.
     * @param with_sound  If false, the animation will not play associated sound
     *                    effects when restarted.
     *
     * @attribute class sprite
     * @attribute method replay_animation
     * @attribute suffix with_sound
     */
    void sprite_replay_animation(sprite s, bool with_sound);

    /**
     * Start playing an animation from the sprite's animation template.
     * This will play a sound effect if the first cell of the animation
     * has a sound.
     *
     * @param s      The sprite to start the animation of.
     * @param named  The name of the animation to start from the animation script.
     *
     * @attribute class sprite
     * @attribute method start_animation
     * @attribute suffix named
     */
    void sprite_start_animation(sprite s, const string &named);

    /**
     * Start playing an animation from the sprite's animation template.
     * The with_sound parameter determines whether to play a sound effect
     * if the first cell of the animation has a sound.
     *
     * @param s      The sprite to start the animation of.
     * @param named  The name of the animation to start from the animation script.
     * @param with_sound  If false, the animation will not play associated sound
     *                    effects when started.
     *
     * @attribute class sprite
     * @attribute method start_animation
     * @attribute suffix named_with_sound
     */
    void sprite_start_animation(sprite s, const string &named, bool with_sound);

    /**
     * Start playing an animation from the sprite's animation template.
     * This will play a sound effect if the first cell of the animation
     * has a sound.
     *
     * @param s    The sprite to start the animation of.
     * @param idx  The index of the animation to start from the animation script.
     *
     * @attribute class sprite
     * @attribute method start_animation
     */
    void sprite_start_animation(sprite s, int idx);

    /**
     * Start playing an animation from the sprite's animation template.
     * The with_sound parameter determines whether to play a sound effect
     * if the first cell of the animation has a sound.
     *
     * @param s       The sprite to start the animation of.
     * @param idx     The index of the animation to start from the animation script.
     * @param with_sound  If false, the animation will not play associated sound
     *                    effects when started.
     *
     * @attribute class sprite
     * @attribute method start_animation
     * @attribute suffix with_sound
     */
    void sprite_start_animation(sprite s, int idx, bool with_sound);

    /**
     * Returns the name of the sprite's current animation.
     *
     * @param s     The sprite to get the details from.
     * @returns     The name of the current animation.
     *
     * @attribute class sprite
     * @attribute method animation_name
     */
    string sprite_animation_name(sprite s);

    //---------------------------------------------------------------------------
    // sprite Update code
    //---------------------------------------------------------------------------

    /**
     * Update the position and animation details of the sprite.
     * This will play a sound effect if the new cell of the animation
     * has a sound.
     *
     * @param s The sprite to update.
     *
     * @attribute class sprite
     * @attribute method update
     */
    void update_sprite(sprite s);

    /**
     * Update the position and animation details of the sprite.
     * This will play a sound effect if the new cell of the animation
     * has a sound and with_sound is true.
     *
     * @param s The sprite to update
     * @param with_sound  If false, animations will not play associated sound
     *                    effects when updated.
     *
     * @attribute class sprite
     * @attribute method update
     * @attribute suffix with_sound
     */
    void update_sprite(sprite s, bool with_sound);

    /**
     * Update the position and animation details of the sprite by a
     * given percentage of a single unit of movement/animation.
     * This will play a sound effect if the new cell of the animation
     * has a sound.
     *
     * @param s   The sprite to update.
     * @param pct The percent to update.
     *
     * @attribute class sprite
     * @attribute method update
     * @attribute suffix percent
     */
    void update_sprite(sprite s, float pct);

    /**
     * Update the position and animation details of the sprite by a
     * given percentage of a single unit of movement/animation.
     * This will play a sound effect if the new cell of the animation
     * has a sound and with_sound is true.
     *
     * @param s   The sprite to update.
     * @param pct The percent to update.
     * @param with_sound  If false, animations will not play associated sound
     *                    effects when updated.
     *
     * @attribute class sprite
     * @attribute method update
     * @attribute suffix percent_with_sound
     */
    void update_sprite(sprite s, float pct, bool with_sound);

    /**
     * Updates the animation details of the sprite.
     * This will play a sound effect if the new cell of the animation
     * has a sound.
     *
     * @param s   The sprite to update.
     *
     * @attribute class sprite
     * @attribute method update_animation
     */
    void update_sprite_animation(sprite s);

    /**
     * Update the animation details of the sprite.
     * This will play a sound effect if the new cell of the animation
     * has a sound and with_sound is true.
     *
     * @param s           The sprite to update.
     * @param with_sound  If false, animations will not play associated sound
     *                    effects when updated.
     *
     * @attribute class sprite
     * @attribute method update_animation
     * @attribute suffix with_sound
     */
    void update_sprite_animation(sprite s, bool with_sound);

    /**
     * Update the animation details of the sprite by a
     * given percentage of a single unit of movement/animation.
     * This will play a sound effect if the new cell of the animation
     * has a sound.
     *
     * @param s   The sprite to update.
     * @param pct The percent to update.
     *
     * @attribute class sprite
     * @attribute method update_animation
     * @attribute suffix percent
     */
    void update_sprite_animation(sprite s, float pct);

    /**
     * Update the position and animation details of the sprite by a
     * given percentage of a single unit of movement/animation.
     * This will play a sound effect if the new cell of the animation
     * has a sound and with_sound is true.
     *
     * @param s   The sprite to update.
     * @param pct The percent to update.
     * @param with_sound  If false, animations will not play associated sound
     *                    effects when updated.
     *
     * @attribute class sprite
     * @attribute method update_animation
     * @attribute suffix percent_with_sound
     */
    void update_sprite_animation(sprite s, float pct, bool with_sound);

    /**
     * Indicates if the sprites animation has ended.
     *
     * @param s   The sprite to get the details from.
     * @returns   True if the sprite animation has ended.
     *
     * @attribute class sprite
     * @attribute getter animation_has_ended
     */
    bool sprite_animation_has_ended(sprite s);

    //---------------------------------------------------------------------------
    // Positioning code
    //---------------------------------------------------------------------------

    /**
     * Returns a `vector_2d` that is the difference in the position of two sprites
     * (`s1` and `s2`).
     *
     * @param s1  The sprite that is at the start of the vector.
     * @param s2  The sprite that is at the end of the vector.
     * @returns   A vector that points from s1 to s2.
     *
     * @attribute class sprite
     * @attribute method vector_to
     */
    vector_2d vector_from_to(sprite s1, sprite s2);

    /**
     * Returns a `vector_2d` that is the difference in location from the center of
     * the sprite `s` to the point `pt`.
     *
     * @param s   The sprite that is at the start of the vector.
     * @param pt  The point that is at the end of the vector.
     * @returns   A vector pointing from the sprite to the point.
     *
     * @attribute class sprite
     * @attribute method vector_to
     * @attribute suffix point
     */
    vector_2d vector_from_center_sprite_to_point(sprite s, const point_2d &pt);

    //---------------------------------------------------------------------------
    // drawing code
    //---------------------------------------------------------------------------

    /**
     * Draws the sprite at its location in the world. This is affected by the
     * position of the camera and the sprites current location.
     *
     * This is the standard routine for drawing sprites to the screen and should be
     * used in most cases.
     *
     * @param s   The sprite to draw.
     *
     * @attribute class sprite
     * @attribute method draw
     */
    void draw_sprite(sprite s);

    /**
     * Draws the sprite at its position in the game offset by a given amount. Only
     * use this method when you want to draw the sprite displaced from its location
     * in your game. Otherwise you should change the sprite's location and then
     * use the standard `draw_sprite` routine.
     *
     * @param s         The sprite to draw.
     * @param x_offset  The amount to offset on the x axis.
     * @param y_offset  The amount to offset on the y axis.
     *
     * @attribute class sprite
     * @attribute method draw
     * @attribute suffix offset_x_y
     */
    void draw_sprite(sprite s, double x_offset, double y_offset);

    /**
     * Draws the sprite at its position in the game offset by a given amount. Only
     * use this method when you want to draw the sprite displaced from its location
     * in your game. Otherwise you should change the sprite's location and then
     * use the standard ''draw_sprite'' routine.
     *
     * @param s         The sprite to draw.
     * @param offset    The amount to offset the sprite.
     *
     * @attribute class sprite
     * @attribute method draw
     * @attribute suffix offset_by
     */
    void draw_sprite(sprite s, const vector_2d &offset);

    //---------------------------------------------------------------------------
    // movement code
    //---------------------------------------------------------------------------

    /**
     * moves the sprite as indicated by its velocity. You can call this directly ot
     * alternatively, this action is performed when the sprite is updated using
     * the ''update_sprite'' routine.
     *
     * @param s   The sprite to move.
     *
     * @attribute class sprite
     * @attribute method move
     */
    void move_sprite(sprite s);

    /**
     * Moves the sprite as indicated by a percentage of its velocity. You can call
     * this directly ot alternatively, this action is performed when the sprite is
     * updated using the ''update_sprite'' routines that require a percentage.
     *
     * @param s   The sprite to move.
     * @param pct The percentage of the sprite's velocity to move.
     *
     * @attribute class sprite
     * @attribute method move
     * @attribute suffix percent
     */
    void move_sprite(sprite s, float pct);

    /**
     * Moves the sprite a given distance based on the value passed in rather than
     * based on the sprite's velocity. Typically this method is used to apply
     * other movement actions to the sprite and the velocity of the sprite is
     * used the intended movement of the sprite.
     *
     * @param s   The sprite to move.
     * @param distance  The vector that represents the direction and distance to
     *                  move the sprite.
     *
     * @attribute class sprite
     * @attribute method move
     * @attribute suffix by_vector
     */
    void move_sprite(sprite s, const vector_2d &distance);

    /**
     * Moves the sprite a percentage of a given distance based on the value
     * passed in rather than based on the sprite's velocity. Typically this
     * method is used to apply other movement actions to the sprite and the
     * velocity of the sprite is used the intended movement of the sprite.
     *
     * @param s   The sprite to move.
     * @param distance  The vector that represents the direction and distance to
     *                  move the sprite.
     * @param pct The percentage of the distance to move the sprite.
     *
     * @attribute class sprite
     * @attribute method move
     * @attribute suffix by_vector_percent
     */
    void move_sprite(sprite s, const vector_2d &distance, float pct);

    /**
     * This method moves a sprite to a given position in the game.
     *
     * @param s   The sprite to move.
     * @param x   The sprite's new x location.
     * @param y   The sprite's new y location.
     *
     * @attribute class sprite
     * @attribute method move_to
     */
    void move_sprite_to(sprite s, double x, double y);

    /**
     * This void starts the sprite moving to the indicated
     * destination point, over a specified number of seconds. When the
     * sprite arrives it will raise the sprite_arrived event.
     *
     * @param s   The sprite to move.
     * @param pt  The sprite's destination.
     * @param taking_seconds  The time the sprite should take to get to pt.
     *
     * @attribute class sprite
     * @attribute method move_to
     * @attribute suffix taking_seconds
     */
    void sprite_move_to(sprite s, const point_2d &pt, float taking_seconds);

    //---------------------------------------------------------------------------
    // sprite Screen Position Tests
    //---------------------------------------------------------------------------

    /**
     * Returns true if a pixel of the `sprite` `s` is at the screen location
     * specified.
     *
     * @param s   The sprite to test.
     * @param x   The x location in screen coordinates to check.
     * @param y   The y location in screen coordinates to check.
     * @returns   True if the sprite would draw something at this coordinate on
     *            the screen when drawn.
     *
     * @attribute class sprite
     * @attribute method on_screen_at
     */
    bool sprite_on_screen_at(sprite s, double x, double y);

    /**
     * Returns true if a pixel of the `sprite` `s` is at the screen location
     * specified (`pt`), which is converted to a world location.
     *
     * @param s   The sprite to test.
     * @param pt  The location in screen coordinates to check.
     * @returns   True if the sprite would draw something at this coordinate on
     *            the screen when drawn.
     *
     * @attribute class sprite
     * @attribute method on_screen_at
     * @attribute suffix point
     */
    bool sprite_on_screen_at(sprite s, const point_2d &pt);

    /**
     * Returns true if the sprite is entirely off the current screen.
     *
     * @param s   The sprite to test.
     * @return    True if the sprite is entirely off the current window.
     *
     * @attribute class sprite
     * @attribute method offscreen
     */
    bool sprite_offscreen(sprite s);

    //---------------------------------------------------------------------------
    // sprite Width and Heigth - centerpoint
    //---------------------------------------------------------------------------

    /**
     * The current height of the sprite (aligned to the Y axis).
     *
     * @param s   The sprite to get the details from.
     * @returns   The height of the sprite in pixels.
     *
     * @attribute class sprite
     * @attribute getter Height
     */
    int sprite_height(sprite s);

    /**
     * The height of a given layer of the sprite (aligned to the Y axis).
     *
     * @param s     The sprite to get the details from.
     * @param name  The name of the layer to get the details of.
     * @returns     The height of the sprite's layer in pixels.
     *
     * @attribute class sprite
     * @attribute method layer_height
     * @attribute suffix named
     */
    int sprite_layer_height(sprite s, const string &name);

    /**
     * The height of a given layer of the sprite (aligned to the Y axis).
     *
     * @param s     The sprite to get the details from.
     * @param idx   The index of the layer to get the details of.
     * @returns     The height of the sprite's layer in pixels.
     *
     * @attribute class sprite
     * @attribute method layer_height
     */
    int sprite_layer_height(sprite s, int idx);

    /**
     * The current Width of the sprite (aligned to the X axis).
     *
     * @param s     The sprite to get the details from.
     * @returns     The width of the sprite's layer in pixels.
     *
     * @attribute class sprite
     * @attribute getter Width
     */
    int sprite_width(sprite s);

    /**
     * The width of a given layer of the sprite (aligned to the X axis).
     *
     * @param s     The sprite to get the details from.
     * @param name  The name of the layer to get the details of.
     * @returns     The width of the sprite's layer in pixels.
     *
     * @attribute class sprite
     * @attribute method layer_width
     * @attribute suffix named
     */
    int sprite_layer_width(sprite s, const string &name);

    /**
     * The width of a given layer of the sprite (aligned to the X axis).
     *
     * @param s     The sprite to get the details from.
     * @param idx   The index of the layer to get the details of.
     * @returns     The width of the sprite's layer in pixels.
     *
     * @attribute class sprite
     * @attribute method layer_width
     */
    int sprite_layer_width(sprite s, int idx);

    /**
     * Returns the center point of the passed in sprite. This is based on the sprite's
     * Position, Width and Height.
     *
     * @param s     The sprite to get the details from.
     * @return      The center point of the sprite
     *
     * @attribute class sprite
     * @attribute getter center_point
     */
    point_2d center_point(sprite s);

    /**
     * Returns the anchor point of the sprite. This is the point around which the
     * sprite rotates. This is in sprite coordinates, so as if the sprite is drawn
     * at 0,0.
     *
     * @param s     The sprite to get the details from.
     * @returns     The anchor point of the sprite.
     *
     * @attribute class sprite
     * @attribute getter anchor_point
     */
    point_2d sprite_anchor_point(sprite s);

    /**
     * Allows you to set the anchor point for the sprite. This is the point around
     * which the sprite rotates. This is in sprite coordinates, as if the sprite
     * is drawn at 0,0.
     *
     * @param s   The sprite to change.
     * @param pt  The new anchor point in sprite coordinates.
     *
     * @attribute class sprite
     * @attribute setter anchor_point
     */
    void sprite_set_anchor_point(sprite s, const point_2d &pt);

    /**
     * The sprite anchor position, is the location of the anchor point in world
     * coordinates, based upon the position of the sprite.
     *
     * @param s The sprite to find where the anchor is in world coordinates
     * @returns The location of the sprite's anchor point positioned at the sprite's location
     */
    point_2d sprite_anchor_position(sprite s);

    /**
     * Indicates if the sprite is moved from its anchor point, or from its top left.
     * When this returns true the location of the sprite will indicate its anchor point.
     * When this returns false the location of the sprite is its top left corner.
     *
     * @param s The sprite to get the details of.
     * @returns  True if the sprite moves from its anchor point.
     *
     * @attribute class sprite
     * @attribute getter move_from_anchor_point
     */
    bool sprite_move_from_anchor_point(sprite s);

    /**
     * Allows you to indicate if the sprite is moved from its anchor point, or from its
     * top left.
     *
     * When set to true the location of the sprite will be its anchor point.
     * When set to false the location of the sprite is its top left corner.
     *
     * @param s The sprite to change.
     * @param value The value to set this option.
     *
     * @attribute class sprite
     * @attribute setter move_from_anchor_point
     */
    void sprite_set_move_from_anchor_point(sprite s, bool value);

    //---------------------------------------------------------------------------
    // sprite velocity
    //---------------------------------------------------------------------------

    /**
     * Returns the current velocity of the sprite. When the sprite is updated
     * (see `update_sprite`) this vector_2d is used to move the sprite.
     *
     * @param s   The sprite to get the details from.
     * @returns   The sprite's velocity.
     *
     * @attribute class sprite
     * @attribute getter velocity
     */
    vector_2d sprite_velocity(sprite s);

    /**
     * Sets the current velocity of the sprite. When the sprite is updated
     * (see `update_sprite`) this vector_2d is used to move the sprite.
     *
     * @param s The sprite to change.
     * @param value The new sprite velocity.
     *
     * @attribute class sprite
     * @attribute setter velocity
     */
    void sprite_set_velocity(sprite s, const vector_2d &value);

    /**
     * Alters the current velocity of the sprite, adding the passed in vector_2d to the current velocity.
     * When the sprite is updated (see `update_sprite`)
     * this vector_2d is used to move the sprite.
     *
     * @param s     The sprite to change.
     * @param value The amount to add to the sprite's velocity.
     *
     * @attribute class sprite
     * @attribute method add_to_velocity
     */
    void sprite_add_to_velocity(sprite s, const vector_2d &value);

    //---------------------------------------------------------------------------
    // sprite Cell_count
    //---------------------------------------------------------------------------

    /**
     * Returns a rectangle of the current cell within the sprite's image. This is used
     * to determine what part of the bitmap should be used when the sprite is drawn.
     *
     * @param s   The sprite to get the details from.
     * @returns   The current cell rectangle of the sprite.
     *
     * @attribute class sprite
     * @attribute getter current_cell_rectangle
     */
    rectangle sprite_current_cell_rectangle(sprite s);

    /**
     * Returns the rectangle representing the location of the sprite on the
     * screen.
     *
     * @param s   The sprite to get the details from.
     * @returns   A rectangle indicating where the sprite is on the screen.
     *
     * @attribute class sprite
     * @attribute getter screen_rectangle
     */
    rectangle sprite_screen_rectangle(sprite s);

    //---------------------------------------------------------------------------
    // sprite X,Y
    //---------------------------------------------------------------------------

    /**
     * Sets the X position of the sprite.
     *
     * @param s The sprite to change.
     * @param value The new x location.
     *
     * @attribute class sprite
     * @attribute setter x
     */
    void sprite_set_x(sprite s, double value);

    /**
     * Returns the X position of the sprite.
     *
     * @param s   The sprite to get the details from.
     * @returns   The x location of the sprite
     *
     * @attribute class sprite
     * @attribute getter x
     */
    double sprite_x(sprite s);

    /**
     * Sets the Y position of the sprite.
     *
     * @param s The sprite to change.
     * @param value The new sprite y.
     *
     * @attribute class sprite
     * @attribute setter y
     */
    void sprite_set_y(sprite s, double value);

    /**
     * Returns the Y position of the sprite.
     *
     * @param s   The sprite to get the details from.
     * @returns   The sprite's y location.
     *
     * @attribute class sprite
     * @attribute getter y
     */
    double sprite_y(sprite s);

    //---------------------------------------------------------------------------
    // sprite position
    //---------------------------------------------------------------------------

    /**
     * Returns the sprite's position.
     *
     * @param s   The sprite to get the details from.
     * @returns   The location of the sprite.
     *
     * @attribute class sprite
     * @attribute getter Position
     */
    point_2d sprite_position(sprite s);

    /**
     * Sets the sprite's position.
     *
     * @param s The sprite to change.
     * @param value The new location for the sprite.
     *
     * @attribute class sprite
     * @attribute setter Position
     */
    void sprite_set_position(sprite s, const point_2d &value);

    //---------------------------------------------------------------------------
    // sprite dx,dy
    //---------------------------------------------------------------------------

    /**
     * Sets the X value of the sprite's velocity.
     *
     * @param s The sprite to change.
     * @param value The new x component of the sprite's velocity.
     *
     * @attribute class sprite
     * @attribute setter dx
     */
    void sprite_set_dx(sprite s, double value);

    /**
     * Returns the X value of the sprite's velocity.
     *
     * @param s   The sprite to get the details from.
     * @returns   The x component of the sprite's velocity.
     *
     * @attribute class sprite
     * @attribute getter dx
     */
    double sprite_dx(sprite s);

    /**
     * Sets the Y value of the sprite's velocity.
     *
     * @param s The sprite to change.
     * @param value The new y component of the sprite's velocity.
     *
     * @attribute class sprite
     * @attribute setter dy
     */
    void sprite_set_dy(sprite s, double value);

    /**
     * Returns the Y value of the sprite's velocity.
     *
     * @param s   The sprite to get the details from.
     * @returns   The y component of the sprite's velocity.
     *
     * @attribute class sprite
     * @attribute getter dy
     */
    double sprite_dy(sprite s);

    //---------------------------------------------------------------------------
    // sprite speed and heading
    //---------------------------------------------------------------------------

    /**
     * Returns the current speed (distance travelled per update) of the sprite.
     *
     * @param s   The sprite to get the details from.
     * @returns   The speed of the sprite (pixels per update).
     *
     * @attribute class sprite
     * @attribute getter speed
     */
    double sprite_speed(sprite s);

    /**
     * Alters the speed of the sprite without effecting the direction.
     *
     * @param s The sprite to change.
     * @param value The new speed of the sprite -- direction will remain the same.
     *
     * @attribute class sprite
     * @attribute setter speed
     */
    void sprite_set_speed(sprite s, double value);

    /**
     * Returns the direction the sprite is heading in degrees.
     *
     * @param s   The sprite to get the details from.
     * @returns   The angle of the sprite velocity.
     *
     * @attribute class sprite
     * @attribute getter heading
     */
    float sprite_heading(sprite s);

    /**
     * Alters the direction the sprite is heading without changing the speed.
     *
     * @param s The sprite to change.
     * @param value The new angle for the sprite's velocity -- distance remains the
     *              same.
     *
     * @attribute class sprite
     * @attribute setter heading
     */
    void sprite_set_heading(sprite s, float value);

    //---------------------------------------------------------------------------
    // sprite current Frame
    //---------------------------------------------------------------------------

    /**
     * Returns the current animation cell for an animated sprite. The cell is
     * updated when the sprite's animation data is updated.
     *
     * @param s   The sprite to get the details from.
     * @returns   The current cell animation of the sprite.
     *
     * @attribute class sprite
     * @attribute getter current_cell
     */
    int sprite_current_cell(sprite s);

    //---------------------------------------------------------------------------
    // sprite collision details
    //---------------------------------------------------------------------------

    /**
     * Determines if a sprite is at a given point.
     *
     * @param s     The sprite to test
     * @param pt    The point to check (in world coordinates)
     * @return      True if the sprite is at the given point
     */
    bool sprite_at(sprite s, const point_2d &pt);

    /**
     * Returns the bitmap used by the sprite to determine if it has collided with
     * other objects in the game.
     *
     * @param s   The sprite to get the details from.
     * @returns   The bitmap used for collisions with this sprite.
     *
     * @attribute class sprite
     * @attribute getter collision_bitmap
     */
    bitmap sprite_collision_bitmap(sprite s);

    /**
     * Sets the bitmap used by the sprite to determine if it has collided with
     * other objects in the game. By default the collision_bitmap is set to the
     * bitmap from the sprite's first layer.
     *
     * @param s The sprite to change.
     * @param bmp The new collision bitmap for the sprite.
     *
     * @attribute class sprite
     * @attribute setter collision_bitmap
     */
    void sprite_set_collision_bitmap(sprite s, bitmap bmp);

    /**
     * Returns the kind of collision used with this sprite. This is used when
     * determining if the sprite has collided with other objects in the game.
     *
     * @param s   The sprite to get the details from.
     * @returns   The kind of collisions performed with this sprite.
     *
     * @attribute class sprite
     * @attribute getter collision_kind
     */
    collision_test_kind sprite_collision_kind(sprite s);

    /**
     * Sets the kind of collision used with this sprite. This is used when
     * determining if the sprite has collided with other objects in the game.
     *
     * @param s The sprite to change.
     * @param value The new kind of collision test for this sprite.
     *
     * @attribute class sprite
     * @attribute setter collision_kind
     */
    void sprite_set_collision_kind(sprite s, collision_test_kind value);

    //---------------------------------------------------------------------------
    // sprite mass
    //---------------------------------------------------------------------------

    /**
     * This indicates the mass of the sprite for any of the collide methods from
     * Physics. The mass of two colliding sprites will determine the relative
     * velocitys after the collision.
     *
     * @param s   The sprite to get the details from.
     * @returns   The mass of the sprite.
     *
     * @attribute class sprite
     * @attribute getter mass
     */
    float sprite_mass(sprite s);

    /**
     * Allows you to change the mass of a sprite.
     *
     * @param s The sprite to change.
     * @param value The new mass for the sprite.
     *
     * @attribute class sprite
     * @attribute setter mass
     */
    void sprite_set_mass(sprite s, float value);

    //---------------------------------------------------------------------------
    // sprite rotation
    //---------------------------------------------------------------------------

    /**
     * This indicates the angle of rotation of the sprite. This will rotate any
     * images of the sprite before drawing, which can be very slow. avoid using
     * this method with bitmap based sprites where possible.
     *
     * @param s   The sprite to get the details from.
     * @returns   The angle of the sprite rotation.
     *
     * @attribute class sprite
     * @attribute getter rotation
     */
    float sprite_rotation(sprite s);

    /**
     * Allows you to change the rotation of a sprite.
     * @attribute class sprite
     *
     * @param s The sprite to change.
     * @param value The new rotation angle for the sprite
     *
     * @attribute class sprite
     * @attribute setter rotation
     */
    void sprite_set_rotation(sprite s, float value);

    //---------------------------------------------------------------------------
    // sprite scale
    //---------------------------------------------------------------------------

    /**
     * This indicates the scale of the sprite. This will scale any
     * images of the sprite before drawing, which can be very slow. avoid using
     * this method with bitmap based sprites where possible.
     *
     * @param s   The sprite to get the details from.
     * @returns   The scale of the sprite.
     *
     * @attribute class sprite
     * @attribute getter scale
     */
    float sprite_scale(sprite s);

    /**
     * Allows you to change the scale of a sprite.
     *
     * @param s     The sprite to change.
     * @param value The new scale for the sprite.
     *
     * @attribute class sprite
     * @attribute setter scale
     */
    void sprite_set_scale(sprite s, float value);

    //---------------------------------------------------------------------------
    // sprite value code
    //---------------------------------------------------------------------------

    /**
     * Returns the number of sprite's values.
     *
     * @param s   The sprite to get the details from.
     * @returns   The number of values stored in the sprite.
     *
     * @attribute class sprite
     * @attribute getter value_count
     */
    int sprite_value_count(sprite s);

    /**
     * Returns the indicated value of the sprite
     *
     * @param s     The sprite to get the details from.
     * @param name  The name of the value to fetch.
     * @returns     The value from the sprite's data store.
     *
     * @attribute class sprite
     * @attribute method value
     */
    float sprite_value(sprite s, const string &name);

    /**
     * Adds a new kind of value to the sprite
     *
     * @param s     The sprite to change.
     * @param name  The name of the new value to store in the sprite.
     *
     * @attribute class sprite
     * @attribute method add_value
     */
    void sprite_add_value(sprite s, const string &name);

    /**
     * Adds a new kind of value to the sprite, setting the initial value
     * to the value passed in.
     *
     * @param s         The sprite to change.
     * @param name      The name of the new value to store in the sprite.
     * @param init_val  The initial value.
     *
     * @attribute class sprite
     * @attribute method add_value
     * @attribute suffix with_default
     */
    void sprite_add_value(sprite s, const string &name, float init_val);

    /**
     * Assigns a value to the sprite.
     *
     * @param s     The sprite to change.
     * @param name  The name of the value to change
     * @param val   The new value.
     *
     * @attribute class sprite
     * @attribute method set_value
     * @attribute suffix named
     */
    void sprite_set_value(sprite s, const string &name, float val);

    /**
     * Indicates if the sprite has a value with the given name.
     *
     * @param s     The sprite to get the details from.
     * @param name  The name of the value to check.
     * @returns     True if the sprite has a value with that name.
     */
    bool sprite_has_value(sprite s, string name);

    //---------------------------------------------------------------------------
    // sprite name
    //---------------------------------------------------------------------------

    /**
     * Returns the name of the sprite. This name is used for resource management
     * and can be used to interact with the sprite in various routines.
     *
     * @param s   The sprite to get the details from.
     * @returns   The name of the sprite.
     *
     * @attribute class sprite
     * @attribute getter name
     */
    string sprite_name(sprite s);

    //---------------------------------------------------------------------------
    // sprite Packs
    //---------------------------------------------------------------------------

    /**
     * draws all of the sprites in the current sprite pack. Packs can be
     * switched to select between different sets of sprites.
     */
    void draw_all_sprites();

    /**
     * Update all of the sprites in the current sprite pack.
     */
    void update_all_sprites();

    /**
     * Update all of the sprites in the current sprite pack, passing in a
     * percentage value to indicate the percentage to update.
     *
     * @param pct The percentage of the update to apply.
     *
     * @attribute suffix  percent
     */
    void update_all_sprites(float pct);

    /**
     * Call the supplied function for all sprites in the current pack.
     *
     * @param fn The sprite function to call on all sprites.
     */
    void call_for_all_sprites(sprite_function *fn);

    /**
     * Call the supplied function for all sprites in the current pack.
     *
     * @param fn  The sprite function to call on all sprites.
     * @param val The value passed to the function for each sprite.
     *
     * @attribute suffix  with_value
     */
    void call_for_all_sprites(sprite_float_function *fn, float val);

    /**
     * Create a new sprite_pack with a given name. This pack can then be
     * selected and used to control which sprites are drawn/updated in
     * the calls to draw_all_sprites and update_all_sprites.
     *
     * @param name The name of the new sprite pack.
     */
    void create_sprite_pack(const string &name);

    /**
     * Frees the sprite pack and all of its sprites.
     *
     * @param name The name of the sprite pack to destroy.
     */
    void free_sprite_pack(const string &name);

    /**
     * Indicates if a given sprite_pack has already been created.
     *
     * @param name The name for the sprite pack.
     * @returns True if a sprite pack exists with the indicated name.
     */
    bool has_sprite_pack(const string &name);

    /**
     * Selects the named sprite_pack (if it has been created). The
     * selected sprite_pack determines which sprites are drawn and updated
     * with the draw_all_sprites and update_all_sprites code.
     *
     * @param name The name of the sprite pack to select.
     */
    void select_sprite_pack(const string &name);

    /**
     * Returns the name of the currently selected sprite_pack.
     *
     * @returns The name of the current sprite pack.
     */
    string current_sprite_pack();
}
#endif /* sprites_h */
