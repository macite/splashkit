//
//  test_sprites.cpp
//  splashkit
//
//  Created by Andrew Cain on 25/08/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#include "collisions.h"
#include "geometry.h"
#include "graphics.h"
#include "images.h"
#include "input.h"
#include "sprites.h"
#include "window_manager.h"
#include <iostream>

constexpr int COLLISION_INDICATOR_WIDTH = 4;

using namespace splashkit_lib;

enum class object_type
{
    SPRITE,
    RECTANGLE,
    CIRCLE,
    TRIANGLE,
    QUAD,
};

enum class collision_test_type
{
    MULTIPLE_DYNAMIC,
    SPRITE_FIXED,
    RECTANGLE_FIXED,
    CIRCLE_FIXED,
    TRIANGLE_FIXED,
    QUAD_FIXED,
};

enum class sprite_perimeter_segment
{
    TOP_LEFT,
    TOP_CENTER,
    TOP_RIGHT,
    BOTTOM_LEFT,
    BOTTOM_CENTER,
    BOTTOM_RIGHT,
    LEFT_TOP,
    LEFT_CENTER,
    LEFT_BOTTOM,
    RIGHT_TOP,
    RIGHT_CENTER,
    RIGHT_BOTTOM,
};

void draw_rect_perimeter_segment(const rectangle& r, sprite_perimeter_segment segment, color clr, int line_width)
{
    switch (segment)
    {
    case sprite_perimeter_segment::TOP_LEFT:
        draw_line(clr, r.x, r.y, r.x + r.width / 3.0, r.y, option_line_width(line_width));
        break;
    case sprite_perimeter_segment::TOP_CENTER:
        draw_line(clr, r.x + r.width / 3.0, r.y, r.x + r.width * 2.0 / 3.0, r.y, option_line_width(line_width));
        break;
    case sprite_perimeter_segment::TOP_RIGHT:
        draw_line(clr, r.x + r.width * 2.0 / 3.0, r.y, r.x + r.width, r.y, option_line_width(line_width));
        break;
    case sprite_perimeter_segment::BOTTOM_LEFT:
        draw_line(clr, r.x, r.y + r.height, r.x + r.width / 3.0, r.y + r.height, option_line_width(line_width));
        break;
    case sprite_perimeter_segment::BOTTOM_CENTER:
        draw_line(clr, r.x + r.width / 3.0, r.y + r.height, r.x + r.width * 2.0 / 3.0, r.y + r.height, option_line_width(line_width));
        break;
    case sprite_perimeter_segment::BOTTOM_RIGHT:
        draw_line(clr, r.x + r.width * 2.0 / 3.0, r.y + r.height, r.x + r.width, r.y + r.height, option_line_width(line_width));
        break;
    case sprite_perimeter_segment::LEFT_TOP:
        draw_line(clr, r.x, r.y, r.x, r.y + r.height / 3.0, option_line_width(line_width));
        break;
    case sprite_perimeter_segment::LEFT_CENTER:
        draw_line(clr, r.x, r.y + r.height / 3.0, r.x, r.y + r.height * 2.0 / 3.0, option_line_width(line_width));
        break;
    case sprite_perimeter_segment::LEFT_BOTTOM:
        draw_line(clr, r.x, r.y + r.height * 2.0 / 3.0, r.x, r.y + r.height, option_line_width(line_width));
        break;
    case sprite_perimeter_segment::RIGHT_TOP:
        draw_line(clr, r.x + r.width, r.y, r.x + r.width, r.y + r.height / 3.0, option_line_width(line_width));
        break;
    case sprite_perimeter_segment::RIGHT_CENTER:
        draw_line(clr, r.x + r.width, r.y + r.height / 3.0, r.x + r.width, r.y + r.height * 2.0 / 3.0, option_line_width(line_width));
        break;
    case sprite_perimeter_segment::RIGHT_BOTTOM:
        draw_line(clr, r.x + r.width, r.y + r.height * 2.0 / 3.0, r.x + r.width, r.y + r.height, option_line_width(line_width));
        break;
    };
}

void draw_rect_perimeter_segments(const rectangle& r, const std::vector<sprite_perimeter_segment>& segments, color clr, int line_width)
{
    for (const auto& segment : segments)
    {
        draw_rect_perimeter_segment(r, segment, clr, line_width);
    }
}

void draw_rect_perimeter_by_collision(const rectangle& r, collision_direction direction, color clr, int line_width)
{
    switch (direction)
    {
    case collision_direction::TOP:
        draw_rect_perimeter_segments(r, {sprite_perimeter_segment::TOP_LEFT, sprite_perimeter_segment::TOP_CENTER, sprite_perimeter_segment::TOP_RIGHT}, clr, line_width);
        break;
    case collision_direction::BOTTOM:
        draw_rect_perimeter_segments(r, {sprite_perimeter_segment::BOTTOM_LEFT, sprite_perimeter_segment::BOTTOM_CENTER, sprite_perimeter_segment::BOTTOM_RIGHT}, clr, line_width);
        break;
    case collision_direction::LEFT:
        draw_rect_perimeter_segments(r, {sprite_perimeter_segment::LEFT_TOP, sprite_perimeter_segment::LEFT_CENTER, sprite_perimeter_segment::LEFT_BOTTOM}, clr, line_width);
        break;
    case collision_direction::RIGHT:
        draw_rect_perimeter_segments(r, {sprite_perimeter_segment::RIGHT_TOP, sprite_perimeter_segment::RIGHT_CENTER, sprite_perimeter_segment::RIGHT_BOTTOM}, clr, line_width);
        break;
    case collision_direction::TOP_LEFT:
        draw_rect_perimeter_segments(r, {sprite_perimeter_segment::TOP_LEFT, sprite_perimeter_segment::LEFT_TOP}, clr, line_width);
        break;
    case collision_direction::TOP_RIGHT:
        draw_rect_perimeter_segments(r, {sprite_perimeter_segment::TOP_RIGHT, sprite_perimeter_segment::RIGHT_TOP}, clr, line_width);
        break;
    case collision_direction::BOTTOM_LEFT:
        draw_rect_perimeter_segments(r, {sprite_perimeter_segment::BOTTOM_LEFT, sprite_perimeter_segment::LEFT_BOTTOM}, clr, line_width);
        break;
    case collision_direction::BOTTOM_RIGHT:
        draw_rect_perimeter_segments(r, {sprite_perimeter_segment::BOTTOM_RIGHT, sprite_perimeter_segment::RIGHT_BOTTOM}, clr, line_width);
        break;
    };
}

void sprite_test()
{
    sprite sprt, s2, s3, s4;
    triangle tri, init_tri;
    triangle tri_b, init_tri_b;
    rectangle r;
    quad q;

    open_window("Sprite Rotation", 600, 600);
    
    hide_mouse();

    sprt = create_sprite("rocket_sprt.png");
    sprite_set_move_from_anchor_point(sprt, true);
    sprite_set_x(sprt, 300);
    sprite_set_y(sprt, 300);

    s2 = create_sprite(bitmap_named("rocket_sprt.png"));
    sprite_set_move_from_anchor_point(s2, true);
    sprite_set_x(s2, 100);
    sprite_set_y(s2, 100);

    s3 = create_sprite(bitmap_named("rocket_sprt.png"));
    sprite_set_move_from_anchor_point(s3, true);
    sprite_set_x(s3, 100);
    sprite_set_y(s3, 400);

    s4 = create_sprite(bitmap_named("rocket_sprt.png"));
    sprite_set_move_from_anchor_point(s4, true);
    sprite_set_x(s4, 400);
    sprite_set_y(s4, 400);
    sprite_set_collision_kind(s4, AABB_COLLISIONS);

    r = rectangle_from(400, 100, 100, 50);
    q = quad_from(r);
    apply_matrix(matrix_multiply(translation_matrix(0, 50), rotation_matrix(45)), q);

    init_tri = triangle_from(0, 0, bitmap_width(bitmap_named("rocket_sprt.png")), bitmap_height(bitmap_named("rocket_sprt.png")), 0, bitmap_height(bitmap_named("rocket_sprt.png")));
    init_tri_b = triangle_from(bitmap_width(bitmap_named("rocket_sprt.png")), 0, bitmap_width(bitmap_named("rocket_sprt.png")), bitmap_height(bitmap_named("rocket_sprt.png")), 0, 0);

    while ( not quit_requested() )
    {
        process_events();

        clear_screen(COLOR_WHITE);

        if ( key_down(LEFT_KEY) )
            sprite_set_rotation(sprt, sprite_rotation(sprt) - 5);

        if ( key_down(RIGHT_KEY) )
            sprite_set_rotation(sprt, sprite_rotation(sprt) + 5);

        if ( key_down(LEFT_SHIFT_KEY) or key_down(RIGHT_SHIFT_KEY) )
        {
            if ( key_down(UP_KEY) )
                sprite_set_scale(sprt, sprite_scale(sprt) + 0.1);

            if ( key_down(DOWN_KEY) )
                sprite_set_scale(sprt, sprite_scale(sprt) - 0.1);
        }
        else
        {
            if ( key_down(UP_KEY) )
                sprite_set_dy(sprt, sprite_dy(sprt) - 0.1);

            if ( key_down(DOWN_KEY) )
                sprite_set_dy(sprt, sprite_dy(sprt) + 0.1);
        }

        if ( key_typed(NUM_0_KEY) ) sprite_set_rotation(sprt, 0);
        if ( key_typed(NUM_9_KEY) ) sprite_set_rotation(sprt, 45);

        tri = init_tri;
        tri_b = init_tri_b;
        
        apply_matrix(sprite_location_matrix(sprt), tri);
        apply_matrix(sprite_location_matrix(sprt), tri_b);
        
        fill_triangle(COLOR_GREEN, tri);
        fill_triangle(COLOR_GREEN, tri_b);

        tri = init_tri;
        tri_b = init_tri_b;
        apply_matrix(sprite_location_matrix(s2), tri);
        apply_matrix(sprite_location_matrix(s2), tri_b);
        
        fill_triangle(COLOR_BLUE, tri);
        fill_triangle(COLOR_BLUE, tri_b);
        // FillQuad(RGBAColor(0,0,255,62), q);

        draw_sprite(sprt);
        draw_sprite(s2);
        draw_sprite(s3);
        draw_sprite(s4);
        
        if (sprite_rectangle_collision(sprt, r))
		{
            draw_rectangle(COLOR_RED, r);
		}
        else
		{
            draw_rectangle(COLOR_PURPLE, r);
		}

        draw_bitmap("ufo.png", 400, 300);

        if (sprite_bitmap_collision(sprt, bitmap_named("ufo.png"), 400, 300))
		{
            draw_rectangle(COLOR_PURPLE, 400, 300, bitmap_width(bitmap_named("ufo.png")), bitmap_height(bitmap_named("ufo.png")));
		}

        if (sprite_at(sprt, mouse_position()))
		{
            draw_circle(COLOR_RED, sprite_collision_circle(sprt));
            draw_circle(COLOR_RED, mouse_x(), mouse_y(), 1);
		}
        else
        {
            draw_circle(COLOR_PLUM, mouse_x(), mouse_y(), 1);
            draw_circle(COLOR_GREEN, sprite_collision_circle(sprt));
        }

        update_sprite(sprt);

        if (sprite_collision(sprt, s2))
		{
            draw_circle(COLOR_RED, sprite_collision_circle(s2));
		}

        if (sprite_collision(sprt, s3))
        {
            collision_direction dir = calculate_collision_direction(sprt, s3);
            resolve_collision(sprt, s3, dir);
            draw_rect_perimeter_by_collision(sprite_collision_rectangle(sprt), dir, COLOR_RED, 4);
        }

        if (sprite_collision(sprt, s4))
        {
            collision_direction dir = calculate_collision_direction(sprt, s4);
            resolve_collision(sprt, s4, dir);
            draw_rect_perimeter_by_collision(sprite_collision_rectangle(sprt), dir, COLOR_RED, 4);
        }

        draw_rectangle(COLOR_GREEN, sprite_collision_rectangle(sprt));
        draw_rectangle(COLOR_RED, sprite_collision_rectangle(s4));

        draw_line(COLOR_GREEN, line_from(center_point(sprt), matrix_multiply(rotation_matrix(sprite_rotation(sprt)), vector_multiply(sprite_velocity(sprt), 30.0))));

        refresh_screen(60);
    }
    
    show_mouse();
    
    close_all_windows();
}

void reset_sprite(sprite s)
{
    sprite_set_x(s, 300.0);
    sprite_set_y(s, 300.0);
    sprite_set_rotation(s, 0.0f);
    sprite_set_scale(s, 1.0f);
    sprite_set_dx(s, 0.0);
    sprite_set_dy(s, 0.0);
    sprite_set_collision_kind(s, PIXEL_COLLISIONS);
}

void reset_rectangle(rectangle &r)
{
    r = rectangle_from(300.0, 300.0, 150.0, 50.0);
}

void reset_circle(circle &c)
{
    c = circle_at(300.0, 300.0, 40.0);
}

void reset_triangle(triangle &t)
{
    t = triangle_from(300.0, 300.0, 400.0, 300.0, 350.0, 250.0);
}

void reset_quad(quad &q)
{
    rectangle r = rectangle_from(300, 300, 100, 50);
    q = quad_from(r);
    apply_matrix(matrix_multiply(translation_matrix(0.0, -150.0), rotation_matrix(45.0)), q);
}

void resolve_and_draw(void* collider, const void* collidee,  object_type collider_type,
                                object_type collidee_type, collision_direction direction)
{
    if (direction == collision_direction::NONE)
    {
        return;
    }

    rectangle perimeter;
    bool collision = false;
    
    switch (collider_type)
    {
    case object_type::SPRITE:
    {
        sprite s = *static_cast<sprite*>(collider);
        perimeter = sprite_collision_rectangle(s);

        switch (collidee_type)
        {
        case object_type::SPRITE:
            collision = resolve_collision(s, *static_cast<const sprite*>(collidee), direction);
            break;
        case object_type::RECTANGLE:
            collision = resolve_collision(s, *static_cast<const rectangle*>(collidee), direction);
            break;
        case object_type::CIRCLE:
            collision = resolve_collision(s, *static_cast<const circle*>(collidee), direction);
            break;
        case object_type::TRIANGLE:
            collision = resolve_collision(s, *static_cast<const triangle*>(collidee), direction);
            break;
        case object_type::QUAD:
            collision = resolve_collision(s, *static_cast<const quad*>(collidee), direction);
            break;
        };
        break;
    }
    case object_type::RECTANGLE:
    {
        rectangle* r = static_cast<rectangle*>(collider);
        perimeter = *r;

        switch (collidee_type)
        {
        case object_type::SPRITE:
            collision = resolve_collision(*r, *static_cast<const sprite*>(collidee), direction);
            break;
        case object_type::RECTANGLE:
            collision = resolve_collision(*r, *static_cast<const rectangle*>(collidee), direction);
            break;
        case object_type::CIRCLE:
            collision = resolve_collision(*r, *static_cast<const circle*>(collidee), direction);
            break;
        case object_type::TRIANGLE:
            collision = resolve_collision(*r, *static_cast<const triangle*>(collidee), direction);
            break;
        case object_type::QUAD:
            collision = resolve_collision(*r, *static_cast<const quad*>(collidee), direction);
            break;
        };
        break;
    }
    case object_type::CIRCLE:
    {
        circle* c = static_cast<circle*>(collider);
        perimeter = rectangle_around(*c);

        switch (collidee_type)
        {
        case object_type::SPRITE:
            collision = resolve_collision(*c, *static_cast<const sprite*>(collidee), direction);
            break;
        case object_type::RECTANGLE:
            collision = resolve_collision(*c, *static_cast<const rectangle*>(collidee), direction);
            break;
        case object_type::CIRCLE:
            collision = resolve_collision(*c, *static_cast<const circle*>(collidee), direction);
            break;
        case object_type::TRIANGLE:
            collision = resolve_collision(*c, *static_cast<const triangle*>(collidee), direction);
            break;
        case object_type::QUAD:
            collision = resolve_collision(*c, *static_cast<const quad*>(collidee), direction);
            break;
        };
        break;
    }
    case object_type::TRIANGLE:
    {
        triangle* t = static_cast<triangle*>(collider);
        perimeter = rectangle_around(*t);

        switch (collidee_type)
        {
        case object_type::SPRITE:
            collision = resolve_collision(*t, *static_cast<const sprite*>(collidee), direction);
            break;
        case object_type::RECTANGLE:
            collision = resolve_collision(*t, *static_cast<const rectangle*>(collidee), direction);
            break;
        case object_type::CIRCLE:
            collision = resolve_collision(*t, *static_cast<const circle*>(collidee), direction);
            break;
        case object_type::TRIANGLE:
            collision = resolve_collision(*t, *static_cast<const triangle*>(collidee), direction);
            break;
        case object_type::QUAD:
            collision = resolve_collision(*t, *static_cast<const quad*>(collidee), direction);
            break;
        };
        break;
    }
    case object_type::QUAD:
    {
        quad* q = static_cast<quad*>(collider);
        perimeter = rectangle_around(*q);

        switch (collidee_type)
        {
        case object_type::SPRITE:
            collision = resolve_collision(*q, *static_cast<const sprite*>(collidee), direction);
            break;
        case object_type::RECTANGLE:
            collision = resolve_collision(*q, *static_cast<const rectangle*>(collidee), direction);
            break;
        case object_type::CIRCLE:
            collision = resolve_collision(*q, *static_cast<const circle*>(collidee), direction);
            break;
        case object_type::TRIANGLE:
            collision = resolve_collision(*q, *static_cast<const triangle*>(collidee), direction);
            break;
        case object_type::QUAD:
            collision = resolve_collision(*q, *static_cast<const quad*>(collidee), direction);
            break;
        };
        break;
    }
    };

    if (collision)
    {
        draw_rect_perimeter_by_collision(perimeter, direction, COLOR_RED, COLLISION_INDICATOR_WIDTH);
    }
}

void multi_object_collision_resolution_test()
{
    object_type collider_type = object_type::SPRITE;
    collision_test_type test_type = collision_test_type::MULTIPLE_DYNAMIC;

    sprite collider_sprt, sprt_pixel, sprt_AABB, sprt_TOP, sprt_BOTTOM, sprt_LEFT,
        sprt_RIGHT, sprt_TOP_LEFT, sprt_TOP_RIGHT, sprt_BOTTOM_LEFT, sprt_BOTTOM_RIGHT;
    bitmap bmp;
    rectangle collider_rect, rect, rect_TOP, rect_BOTTOM, rect_LEFT, rect_RIGHT, rect_TOP_LEFT,
        rect_TOP_RIGHT, rect_BOTTOM_LEFT, rect_BOTTOM_RIGHT;
    circle collider_circ, circ, circ_TOP, circ_BOTTOM, circ_LEFT, circ_RIGHT, circ_TOP_LEFT,
        circ_TOP_RIGHT, circ_BOTTOM_LEFT, circ_BOTTOM_RIGHT;
    triangle collider_tri, tri, tri_TOP, tri_BOTTOM, tri_LEFT, tri_RIGHT, tri_TOP_LEFT,
        tri_TOP_RIGHT, tri_BOTTOM_LEFT, tri_BOTTOM_RIGHT;
    quad collider_quad, q, quad_TOP, quad_BOTTOM, quad_LEFT, quad_RIGHT, quad_TOP_LEFT,
        quad_TOP_RIGHT, quad_BOTTOM_LEFT, quad_BOTTOM_RIGHT;

    open_window("Object Collision Resolution", 600, 600);

    hide_mouse();

    collider_sprt = create_sprite("rocket_sprt.png");
    reset_sprite(collider_sprt);
    reset_rectangle(collider_rect);
    reset_circle(collider_circ);
    reset_triangle(collider_tri);
    reset_quad(collider_quad);

    sprt_pixel = create_sprite("rocket_sprt.png");
    sprite_set_x(sprt_pixel, 100.0);
    sprite_set_y(sprt_pixel, 100.0);
    sprite_set_collision_kind(sprt_pixel, PIXEL_COLLISIONS);

    sprt_AABB = create_sprite("rocket_sprt.png");
    sprite_set_x(sprt_AABB, 50.0);
    sprite_set_y(sprt_AABB, 400.0);
    sprite_set_collision_kind(sprt_AABB, AABB_COLLISIONS);

    sprt_TOP = create_sprite("rocket_sprt.png");
    sprite_set_x(sprt_TOP, 300.0);
    sprite_set_y(sprt_TOP, 100.0);
    sprite_set_collision_kind(sprt_TOP, PIXEL_COLLISIONS);

    sprt_BOTTOM = create_sprite("rocket_sprt.png");
    sprite_set_x(sprt_BOTTOM, 300.0);
    sprite_set_y(sprt_BOTTOM, 500.0);
    sprite_set_collision_kind(sprt_BOTTOM, PIXEL_COLLISIONS);

    sprt_LEFT = create_sprite("rocket_sprt.png");
    sprite_set_x(sprt_LEFT, 100.0);
    sprite_set_y(sprt_LEFT, 300.0);
    sprite_set_collision_kind(sprt_LEFT, PIXEL_COLLISIONS);

    sprt_RIGHT = create_sprite("rocket_sprt.png");
    sprite_set_x(sprt_RIGHT, 500.0);
    sprite_set_y(sprt_RIGHT, 300.0);
    sprite_set_collision_kind(sprt_RIGHT, PIXEL_COLLISIONS);

    sprt_TOP_LEFT = create_sprite("rocket_sprt.png");
    sprite_set_x(sprt_TOP_LEFT, 100.0);
    sprite_set_y(sprt_TOP_LEFT, 100.0);
    sprite_set_collision_kind(sprt_TOP_LEFT, PIXEL_COLLISIONS);

    sprt_TOP_RIGHT = create_sprite("rocket_sprt.png");
    sprite_set_x(sprt_TOP_RIGHT, 500.0);
    sprite_set_y(sprt_TOP_RIGHT, 100.0);
    sprite_set_collision_kind(sprt_TOP_RIGHT, PIXEL_COLLISIONS);

    sprt_BOTTOM_LEFT = create_sprite("rocket_sprt.png");
    sprite_set_x(sprt_BOTTOM_LEFT, 100.0);
    sprite_set_y(sprt_BOTTOM_LEFT, 500.0);
    sprite_set_collision_kind(sprt_BOTTOM_LEFT, PIXEL_COLLISIONS);

    sprt_BOTTOM_RIGHT = create_sprite("rocket_sprt.png");
    sprite_set_x(sprt_BOTTOM_RIGHT, 500.0);
    sprite_set_y(sprt_BOTTOM_RIGHT, 500.0);
    sprite_set_collision_kind(sprt_BOTTOM_RIGHT, PIXEL_COLLISIONS);

    rect = rectangle_from(400.0, 450.0, 100.0, 50.0);
    rect_TOP = rectangle_from(300.0, 100.0, 100.0, 50.0);
    rect_BOTTOM = rectangle_from(300.0, 500.0, 100.0, 50.0);
    rect_LEFT = rectangle_from(100.0, 300.0, 50.0, 100.0);
    rect_RIGHT = rectangle_from(500.0, 300.0, 50.0, 100.0);
    rect_TOP_LEFT = rectangle_from(100.0, 100.0, 50.0, 50.0);
    rect_TOP_RIGHT = rectangle_from(500.0, 100.0, 50.0, 50.0);
    rect_BOTTOM_LEFT = rectangle_from(100.0, 500.0, 50.0, 50.0);
    rect_BOTTOM_RIGHT = rectangle_from(500.0, 500.0, 50.0, 50.0);

    circ = circle_at(400.0, 300.0, 50.0);
    circ_TOP = circle_at(300.0, 100.0, 50.0);
    circ_BOTTOM = circle_at(300.0, 500.0, 50.0);
    circ_LEFT = circle_at(100.0, 300.0, 50.0);
    circ_RIGHT = circle_at(500.0, 300.0, 50.0);
    circ_TOP_LEFT = circle_at(100.0, 100.0, 50.0);
    circ_TOP_RIGHT = circle_at(500.0, 100.0, 50.0);
    circ_BOTTOM_LEFT = circle_at(100.0, 500.0, 50.0);
    circ_BOTTOM_RIGHT = circle_at(500.0, 500.0, 50.0);

    tri_TOP = triangle_from(300.0, 100.0, 400.0, 100.0, 350.0, 150.0);
    tri_BOTTOM = triangle_from(300.0, 500.0, 400.0, 500.0, 350.0, 450.0);
    tri_LEFT = triangle_from(100.0, 300.0, 100.0, 400.0, 150.0, 350.0);
    tri_RIGHT = triangle_from(500.0, 300.0, 500.0, 400.0, 450.0, 350.0);
    tri_TOP_LEFT = triangle_from(100.0, 150.0, 150.0, 100.0, 150.0, 150.0);
    tri_TOP_RIGHT = triangle_from(500.0, 150.0, 450.0, 100.0, 450.0, 150.0);
    tri_BOTTOM_LEFT = triangle_from(100.0, 450.0, 150.0, 500.0, 150.0, 450.0);
    tri_BOTTOM_RIGHT = triangle_from(500.0, 450.0, 450.0, 500.0, 450.0, 450.0);

    tri = triangle_from(400.0, 100.0, 500.0, 100.0, 450.0, 50.0);

    rectangle r = rectangle_from(400, 100, 100, 50);
    q = quad_from(r);
    apply_matrix(matrix_multiply(translation_matrix(0.0, 50.0), rotation_matrix(45.0)), q);
    r = rectangle_from(0.0, 0.0, 100.0, 50.0);
    quad_TOP = quad_from(r);
    apply_matrix(matrix_multiply(rotation_matrix(45.0), translation_matrix(300.0, 20.0)), quad_TOP);
    quad_BOTTOM = quad_from(r);
    apply_matrix(matrix_multiply(rotation_matrix(45.0), translation_matrix(300.0, 470.0)), quad_BOTTOM);
    quad_LEFT = quad_from(r);
    apply_matrix(matrix_multiply(rotation_matrix(45.0), translation_matrix(50.0, 270.0)), quad_LEFT);
    quad_RIGHT = quad_from(r);
    apply_matrix(matrix_multiply(rotation_matrix(45.0), translation_matrix(500.0, 270.0)), quad_RIGHT);
    quad_TOP_LEFT = quad_from(r);
    apply_matrix(matrix_multiply(rotation_matrix(45.0), translation_matrix(50.0, 20.0)), quad_TOP_LEFT);
    quad_TOP_RIGHT = quad_from(r);
    apply_matrix(matrix_multiply(rotation_matrix(45.0), translation_matrix(500.0, 20.0)), quad_TOP_RIGHT);
    quad_BOTTOM_LEFT = quad_from(r);
    apply_matrix(matrix_multiply(rotation_matrix(45.0), translation_matrix(50.0, 470.0)), quad_BOTTOM_LEFT);
    quad_BOTTOM_RIGHT = quad_from(r);
    apply_matrix(matrix_multiply(rotation_matrix(45.0), translation_matrix(500.0, 470.0)), quad_BOTTOM_RIGHT);

    while (! quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        // Change the object type with number keys
        if (key_typed(NUM_1_KEY))
        {
            collider_type = object_type::SPRITE;
            reset_sprite(collider_sprt);
        }
        if (key_typed(NUM_2_KEY))
        {
            collider_type = object_type::RECTANGLE;
            reset_rectangle(collider_rect);
        }
        if (key_typed(NUM_3_KEY))
        {
            collider_type = object_type::CIRCLE;
            reset_circle(collider_circ);
        }
        if (key_typed(NUM_4_KEY))
        {
            collider_type = object_type::TRIANGLE;
            reset_triangle(collider_tri);
        }
        if (key_typed(NUM_5_KEY))
        {
            collider_type = object_type::QUAD;
            reset_quad(collider_quad);
        }
        if (key_typed(NUM_6_KEY))
        {
            test_type = collision_test_type::MULTIPLE_DYNAMIC;
        }
        if (key_typed(NUM_7_KEY))
        {
            test_type = collision_test_type::SPRITE_FIXED;
        }
        if (key_typed(NUM_8_KEY))
        {
            test_type = collision_test_type::RECTANGLE_FIXED;
        }
        if (key_typed(NUM_9_KEY))
        {
            test_type = collision_test_type::CIRCLE_FIXED;
        }
        if (key_typed(NUM_0_KEY))
        {
            test_type = collision_test_type::TRIANGLE_FIXED;
        }
        if (key_typed(MINUS_KEY))
        {
            test_type = collision_test_type::QUAD_FIXED;
        }

        if (collider_type == object_type::SPRITE)
        {
            if ( key_down(LEFT_KEY) )
            sprite_set_rotation(collider_sprt, sprite_rotation(collider_sprt) - 5.0);

            if ( key_down(RIGHT_KEY) )
                sprite_set_rotation(collider_sprt, sprite_rotation(collider_sprt) + 5.0);

            if ( key_down(LEFT_SHIFT_KEY) or key_down(RIGHT_SHIFT_KEY) )
            {
                if ( key_down(UP_KEY) )
                    sprite_set_scale(collider_sprt, sprite_scale(collider_sprt) + 0.1);

                if ( key_down(DOWN_KEY) )
                    sprite_set_scale(collider_sprt, sprite_scale(collider_sprt) - 0.1);
            }
            else
            {
                if ( key_down(UP_KEY) )
                    sprite_set_dy(collider_sprt, sprite_dy(collider_sprt) - 0.1);

                if ( key_down(DOWN_KEY) )
                    sprite_set_dy(collider_sprt, sprite_dy(collider_sprt) + 0.1);
            }

            update_sprite(collider_sprt);
        }
        else if (collider_type == object_type::RECTANGLE)
        {
            if ( key_down(LEFT_KEY) )
                collider_rect.x -= 1.0;

            if ( key_down(RIGHT_KEY) )
                collider_rect.x += 1.0;

            if ( key_down(UP_KEY) )
                collider_rect.y -= 1.0;

            if ( key_down(DOWN_KEY) )
                collider_rect.y += 1.0;
        }
        else if (collider_type == object_type::CIRCLE)
        {
            if ( key_down(LEFT_KEY) )
                collider_circ.center.x -= 1.0;

            if ( key_down(RIGHT_KEY) )
                collider_circ.center.x += 1.0;

            if ( key_down(UP_KEY) )
                collider_circ.center.y -= 1.0;

            if ( key_down(DOWN_KEY) )
                collider_circ.center.y += 1.0;
        }
        else if (collider_type == object_type::TRIANGLE)
        {
            if ( key_down(LEFT_KEY) )
            {
                collider_tri.points[0].x -= 1.0;
                collider_tri.points[1].x -= 1.0;
                collider_tri.points[2].x -= 1.0;
            }
            if ( key_down(RIGHT_KEY) )
            {
                collider_tri.points[0].x += 1.0;
                collider_tri.points[1].x += 1.0;
                collider_tri.points[2].x += 1.0;
            }
            if ( key_down(UP_KEY) )
            {
                collider_tri.points[0].y -= 1.0;
                collider_tri.points[1].y -= 1.0;
                collider_tri.points[2].y -= 1.0;
            }
            if ( key_down(DOWN_KEY) )
            {
                collider_tri.points[0].y += 1.0;
                collider_tri.points[1].y += 1.0;
                collider_tri.points[2].y += 1.0;
            }
        }
        else if (collider_type == object_type::QUAD)
        {
            if ( key_down(LEFT_KEY) )
            {
                collider_quad.points[0].x -= 1.0;
                collider_quad.points[1].x -= 1.0;
                collider_quad.points[2].x -= 1.0;
                collider_quad.points[3].x -= 1.0;
            }
            if ( key_down(RIGHT_KEY) )
            {
                collider_quad.points[0].x += 1.0;
                collider_quad.points[1].x += 1.0;
                collider_quad.points[2].x += 1.0;
                collider_quad.points[3].x += 1.0;
            }
            if ( key_down(UP_KEY) )
            {
                collider_quad.points[0].y -= 1.0;
                collider_quad.points[1].y -= 1.0;
                collider_quad.points[2].y -= 1.0;
                collider_quad.points[3].y -= 1.0;
            }
            if ( key_down(DOWN_KEY) )
            {
                collider_quad.points[0].y += 1.0;
                collider_quad.points[1].y += 1.0;
                collider_quad.points[2].y += 1.0;
                collider_quad.points[3].y += 1.0;
            }
        }

                    

        if (test_type == collision_test_type::MULTIPLE_DYNAMIC)
        {
            draw_rectangle(COLOR_RED, sprite_collision_rectangle(sprt_AABB));
            fill_rectangle(COLOR_GREEN, rect);
            fill_circle(COLOR_GREEN, circ);
            fill_triangle(COLOR_GREEN, tri);
            fill_quad(COLOR_GREEN, q);
            draw_sprite(sprt_pixel);
            draw_sprite(sprt_AABB);

            if (collider_type == object_type::SPRITE) // sprite vs. multiple dynamic objects
            {
                resolve_and_draw(&collider_sprt, &sprt_pixel, collider_type, object_type::SPRITE, calculate_collision_direction(collider_sprt, sprt_pixel));
                resolve_and_draw(&collider_sprt, &sprt_AABB, collider_type, object_type::SPRITE, calculate_collision_direction(collider_sprt, sprt_AABB));
                resolve_and_draw(&collider_sprt, &rect, collider_type, object_type::RECTANGLE, calculate_collision_direction(collider_sprt, rect));
                resolve_and_draw(&collider_sprt, &circ, collider_type, object_type::CIRCLE, calculate_collision_direction(collider_sprt, circ));
                resolve_and_draw(&collider_sprt, &tri, collider_type, object_type::TRIANGLE, calculate_collision_direction(collider_sprt, tri));
                resolve_and_draw(&collider_sprt, &q, collider_type, object_type::QUAD, calculate_collision_direction(collider_sprt, q));

                draw_sprite(collider_sprt);
                draw_rectangle(COLOR_GREEN, sprite_collision_rectangle(collider_sprt));
            }
            else if (collider_type == object_type::RECTANGLE) // rect vs. multiple dynamic objects
            {
                resolve_and_draw(&collider_rect, &sprt_pixel, collider_type, object_type::SPRITE, calculate_collision_direction(collider_rect, sprt_pixel));
                resolve_and_draw(&collider_rect, &sprt_AABB, collider_type, object_type::SPRITE, calculate_collision_direction(collider_rect, sprt_AABB));
                resolve_and_draw(&collider_rect, &rect, collider_type, object_type::RECTANGLE, calculate_collision_direction(collider_rect, rect));
                resolve_and_draw(&collider_rect, &circ, collider_type, object_type::CIRCLE, calculate_collision_direction(collider_rect, circ));
                resolve_and_draw(&collider_rect, &tri, collider_type, object_type::TRIANGLE, calculate_collision_direction(collider_rect, tri));
                resolve_and_draw(&collider_rect, &q, collider_type, object_type::QUAD, calculate_collision_direction(collider_rect, q));

                fill_rectangle(COLOR_ORANGE, collider_rect);
            }
            else if (collider_type == object_type::CIRCLE) // circle vs. multiple dynamic objects
            {
                resolve_and_draw(&collider_circ, &sprt_pixel, collider_type, object_type::SPRITE, calculate_collision_direction(collider_circ, sprt_pixel));
                resolve_and_draw(&collider_circ, &sprt_AABB, collider_type, object_type::SPRITE, calculate_collision_direction(collider_circ, sprt_AABB));
                resolve_and_draw(&collider_circ, &rect, collider_type, object_type::RECTANGLE, calculate_collision_direction(collider_circ, rect));
                resolve_and_draw(&collider_circ, &circ, collider_type, object_type::CIRCLE, calculate_collision_direction(collider_circ, circ));
                resolve_and_draw(&collider_circ, &tri, collider_type, object_type::TRIANGLE, calculate_collision_direction(collider_circ, tri));
                resolve_and_draw(&collider_circ, &q, collider_type, object_type::QUAD, calculate_collision_direction(collider_circ, q));

                fill_circle(COLOR_ORANGE, collider_circ);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_circ));
            }
            else if (collider_type == object_type::TRIANGLE) // triangle vs. multiple dynamic objects
            {
                resolve_and_draw(&collider_tri, &sprt_pixel, collider_type, object_type::SPRITE, calculate_collision_direction(collider_tri, sprt_pixel));
                resolve_and_draw(&collider_tri, &sprt_AABB, collider_type, object_type::SPRITE, calculate_collision_direction(collider_tri, sprt_AABB));
                resolve_and_draw(&collider_tri, &rect, collider_type, object_type::RECTANGLE, calculate_collision_direction(collider_tri, rect));
                resolve_and_draw(&collider_tri, &circ, collider_type, object_type::CIRCLE, calculate_collision_direction(collider_tri, circ));
                resolve_and_draw(&collider_tri, &tri, collider_type, object_type::TRIANGLE, calculate_collision_direction(collider_tri, tri));
                resolve_and_draw(&collider_tri, &q, collider_type, object_type::QUAD, calculate_collision_direction(collider_tri, q));

                fill_triangle(COLOR_ORANGE, collider_tri);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_tri));
            }
            else if (collider_type == object_type::QUAD) // quad vs. multiple dynamic objects
            {
                resolve_and_draw(&collider_quad, &sprt_pixel, collider_type, object_type::SPRITE, calculate_collision_direction(collider_quad, sprt_pixel));
                resolve_and_draw(&collider_quad, &sprt_AABB, collider_type, object_type::SPRITE, calculate_collision_direction(collider_quad, sprt_AABB));
                resolve_and_draw(&collider_quad, &rect, collider_type, object_type::RECTANGLE, calculate_collision_direction(collider_quad, rect));
                resolve_and_draw(&collider_quad, &circ, collider_type, object_type::CIRCLE, calculate_collision_direction(collider_quad, circ));
                resolve_and_draw(&collider_quad, &tri, collider_type, object_type::TRIANGLE, calculate_collision_direction(collider_quad, tri));
                resolve_and_draw(&collider_quad, &q, collider_type, object_type::QUAD, calculate_collision_direction(collider_quad, q));

                fill_quad(COLOR_ORANGE, collider_quad);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_quad));
            }
        }
        else if (test_type == collision_test_type::SPRITE_FIXED)
        {
            draw_sprite(sprt_TOP);
            draw_sprite(sprt_BOTTOM);
            draw_sprite(sprt_LEFT);
            draw_sprite(sprt_RIGHT);
            draw_sprite(sprt_TOP_LEFT);
            draw_sprite(sprt_TOP_RIGHT);
            draw_sprite(sprt_BOTTOM_LEFT);
            draw_sprite(sprt_BOTTOM_RIGHT);

            if (collider_type == object_type::SPRITE) // sprite vs. fixed sprite objects
            {
                resolve_and_draw(&collider_sprt, &sprt_TOP, collider_type, object_type::SPRITE, collision_direction::TOP);
                resolve_and_draw(&collider_sprt, &sprt_BOTTOM, collider_type, object_type::SPRITE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_sprt, &sprt_LEFT, collider_type, object_type::SPRITE, collision_direction::LEFT);
                resolve_and_draw(&collider_sprt, &sprt_RIGHT, collider_type, object_type::SPRITE, collision_direction::RIGHT);
                resolve_and_draw(&collider_sprt, &sprt_TOP_LEFT, collider_type, object_type::SPRITE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_sprt, &sprt_TOP_RIGHT, collider_type, object_type::SPRITE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_sprt, &sprt_BOTTOM_LEFT, collider_type, object_type::SPRITE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_sprt, &sprt_BOTTOM_RIGHT, collider_type, object_type::SPRITE, collision_direction::BOTTOM_RIGHT);

                draw_sprite(collider_sprt);
                draw_rectangle(COLOR_GREEN, sprite_collision_rectangle(collider_sprt));
            }
            else if (collider_type == object_type::RECTANGLE) // rect vs. fixed sprite objects
            {
                resolve_and_draw(&collider_rect, &sprt_TOP, collider_type, object_type::SPRITE, collision_direction::TOP);
                resolve_and_draw(&collider_rect, &sprt_BOTTOM, collider_type, object_type::SPRITE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_rect, &sprt_LEFT, collider_type, object_type::SPRITE, collision_direction::LEFT);
                resolve_and_draw(&collider_rect, &sprt_RIGHT, collider_type, object_type::SPRITE, collision_direction::RIGHT);
                resolve_and_draw(&collider_rect, &sprt_TOP_LEFT, collider_type, object_type::SPRITE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_rect, &sprt_TOP_RIGHT, collider_type, object_type::SPRITE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_rect, &sprt_BOTTOM_LEFT, collider_type, object_type::SPRITE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_rect, &sprt_BOTTOM_RIGHT, collider_type, object_type::SPRITE, collision_direction::BOTTOM_RIGHT);

                fill_rectangle(COLOR_ORANGE, collider_rect);
            }
            else if (collider_type == object_type::CIRCLE) // circle vs. fixed sprite objects
            {
                resolve_and_draw(&collider_circ, &sprt_TOP, collider_type, object_type::SPRITE, collision_direction::TOP);
                resolve_and_draw(&collider_circ, &sprt_BOTTOM, collider_type, object_type::SPRITE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_circ, &sprt_LEFT, collider_type, object_type::SPRITE, collision_direction::LEFT);
                resolve_and_draw(&collider_circ, &sprt_RIGHT, collider_type, object_type::SPRITE, collision_direction::RIGHT);
                resolve_and_draw(&collider_circ, &sprt_TOP_LEFT, collider_type, object_type::SPRITE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_circ, &sprt_TOP_RIGHT, collider_type, object_type::SPRITE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_circ, &sprt_BOTTOM_LEFT, collider_type, object_type::SPRITE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_circ, &sprt_BOTTOM_RIGHT, collider_type, object_type::SPRITE, collision_direction::BOTTOM_RIGHT);

                fill_circle(COLOR_ORANGE, collider_circ);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_circ));
            }
            else if (collider_type == object_type::TRIANGLE) // triangle vs. fixed sprite objects
            {
                resolve_and_draw(&collider_tri, &sprt_TOP, collider_type, object_type::SPRITE, collision_direction::TOP);
                resolve_and_draw(&collider_tri, &sprt_BOTTOM, collider_type, object_type::SPRITE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_tri, &sprt_LEFT, collider_type, object_type::SPRITE, collision_direction::LEFT);
                resolve_and_draw(&collider_tri, &sprt_RIGHT, collider_type, object_type::SPRITE, collision_direction::RIGHT);
                resolve_and_draw(&collider_tri, &sprt_TOP_LEFT, collider_type, object_type::SPRITE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_tri, &sprt_TOP_RIGHT, collider_type, object_type::SPRITE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_tri, &sprt_BOTTOM_LEFT, collider_type, object_type::SPRITE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_tri, &sprt_BOTTOM_RIGHT, collider_type, object_type::SPRITE, collision_direction::BOTTOM_RIGHT);

                fill_triangle(COLOR_ORANGE, collider_tri);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_tri));
            }
            else if (collider_type == object_type::QUAD) // quad vs. fixed sprite objects
            {
                resolve_and_draw(&collider_quad, &sprt_TOP, collider_type, object_type::SPRITE, collision_direction::TOP);
                resolve_and_draw(&collider_quad, &sprt_BOTTOM, collider_type, object_type::SPRITE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_quad, &sprt_LEFT, collider_type, object_type::SPRITE, collision_direction::LEFT);
                resolve_and_draw(&collider_quad, &sprt_RIGHT, collider_type, object_type::SPRITE, collision_direction::RIGHT);
                resolve_and_draw(&collider_quad, &sprt_TOP_LEFT, collider_type, object_type::SPRITE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_quad, &sprt_TOP_RIGHT, collider_type, object_type::SPRITE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_quad, &sprt_BOTTOM_LEFT, collider_type, object_type::SPRITE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_quad, &sprt_BOTTOM_RIGHT, collider_type, object_type::SPRITE, collision_direction::BOTTOM_RIGHT);

                fill_quad(COLOR_ORANGE, collider_quad);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_quad));
            }
        }
        else if (test_type == collision_test_type::RECTANGLE_FIXED)
        {
            fill_rectangle(COLOR_GREEN, rect_TOP);
            fill_rectangle(COLOR_GREEN, rect_BOTTOM);
            fill_rectangle(COLOR_GREEN, rect_LEFT);
            fill_rectangle(COLOR_GREEN, rect_RIGHT);
            fill_rectangle(COLOR_GREEN, rect_TOP_LEFT);
            fill_rectangle(COLOR_GREEN, rect_TOP_RIGHT);
            fill_rectangle(COLOR_GREEN, rect_BOTTOM_LEFT);
            fill_rectangle(COLOR_GREEN, rect_BOTTOM_RIGHT);

            if (collider_type == object_type::SPRITE) // sprite vs. fixed rectangle objects
            {
                resolve_and_draw(&collider_sprt, &rect_TOP, collider_type, object_type::RECTANGLE, collision_direction::TOP);
                resolve_and_draw(&collider_sprt, &rect_BOTTOM, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_sprt, &rect_LEFT, collider_type, object_type::RECTANGLE, collision_direction::LEFT);
                resolve_and_draw(&collider_sprt, &rect_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_sprt, &rect_TOP_LEFT, collider_type, object_type::RECTANGLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_sprt, &rect_TOP_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_sprt, &rect_BOTTOM_LEFT, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_sprt, &rect_BOTTOM_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM_RIGHT);

                draw_sprite(collider_sprt);
                draw_rectangle(COLOR_GREEN, sprite_collision_rectangle(collider_sprt));
            }
            else if (collider_type == object_type::RECTANGLE) // rect vs. fixed rectangle objects
            {
                resolve_and_draw(&collider_rect, &rect_TOP, collider_type, object_type::RECTANGLE, collision_direction::TOP);
                resolve_and_draw(&collider_rect, &rect_BOTTOM, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_rect, &rect_LEFT, collider_type, object_type::RECTANGLE, collision_direction::LEFT);
                resolve_and_draw(&collider_rect, &rect_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_rect, &rect_TOP_LEFT, collider_type, object_type::RECTANGLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_rect, &rect_TOP_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_rect, &rect_BOTTOM_LEFT, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_rect, &rect_BOTTOM_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM_RIGHT);

                fill_rectangle(COLOR_ORANGE, collider_rect);
            }
            else if (collider_type == object_type::CIRCLE) // circle vs. fixed rectangle objects
            {
                resolve_and_draw(&collider_circ, &rect_TOP, collider_type, object_type::RECTANGLE, collision_direction::TOP);
                resolve_and_draw(&collider_circ, &rect_BOTTOM, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_circ, &rect_LEFT, collider_type, object_type::RECTANGLE, collision_direction::LEFT);
                resolve_and_draw(&collider_circ, &rect_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_circ, &rect_TOP_LEFT, collider_type, object_type::RECTANGLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_circ, &rect_TOP_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_circ, &rect_BOTTOM_LEFT, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_circ, &rect_BOTTOM_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM_RIGHT);

                fill_circle(COLOR_ORANGE, collider_circ);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_circ));
            }
            else if (collider_type == object_type::TRIANGLE) // triangle vs. fixed rectangle objects
            {
                resolve_and_draw(&collider_tri, &rect_TOP, collider_type, object_type::RECTANGLE, collision_direction::TOP);
                resolve_and_draw(&collider_tri, &rect_BOTTOM, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_tri, &rect_LEFT, collider_type, object_type::RECTANGLE, collision_direction::LEFT);
                resolve_and_draw(&collider_tri, &rect_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_tri, &rect_TOP_LEFT, collider_type, object_type::RECTANGLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_tri, &rect_TOP_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_tri, &rect_BOTTOM_LEFT, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_tri, &rect_BOTTOM_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM_RIGHT);

                fill_triangle(COLOR_ORANGE, collider_tri);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_tri));
            }
            else if (collider_type == object_type::QUAD) // quad vs. fixed rectangle objects
            {
                resolve_and_draw(&collider_quad, &rect_TOP, collider_type, object_type::RECTANGLE, collision_direction::TOP);
                resolve_and_draw(&collider_quad, &rect_BOTTOM, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_quad, &rect_LEFT, collider_type, object_type::RECTANGLE, collision_direction::LEFT);
                resolve_and_draw(&collider_quad, &rect_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_quad, &rect_TOP_LEFT, collider_type, object_type::RECTANGLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_quad, &rect_TOP_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_quad, &rect_BOTTOM_LEFT, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_quad, &rect_BOTTOM_RIGHT, collider_type, object_type::RECTANGLE, collision_direction::BOTTOM_RIGHT);

                fill_quad(COLOR_ORANGE, collider_quad);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_quad));
            }
        }
        else if (test_type == collision_test_type::CIRCLE_FIXED)
        {
            fill_circle(COLOR_GREEN, circ_TOP);
            fill_circle(COLOR_GREEN, circ_BOTTOM);
            fill_circle(COLOR_GREEN, circ_LEFT);
            fill_circle(COLOR_GREEN, circ_RIGHT);
            fill_circle(COLOR_GREEN, circ_TOP_LEFT);
            fill_circle(COLOR_GREEN, circ_TOP_RIGHT);
            fill_circle(COLOR_GREEN, circ_BOTTOM_LEFT);
            fill_circle(COLOR_GREEN, circ_BOTTOM_RIGHT);

            if (collider_type == object_type::SPRITE) // sprite vs. fixed circle objects
            {
                resolve_and_draw(&collider_sprt, &circ_TOP, collider_type, object_type::CIRCLE, collision_direction::TOP);
                resolve_and_draw(&collider_sprt, &circ_BOTTOM, collider_type, object_type::CIRCLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_sprt, &circ_LEFT, collider_type, object_type::CIRCLE, collision_direction::LEFT);
                resolve_and_draw(&collider_sprt, &circ_RIGHT, collider_type, object_type::CIRCLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_sprt, &circ_TOP_LEFT, collider_type, object_type::CIRCLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_sprt, &circ_TOP_RIGHT, collider_type, object_type::CIRCLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_sprt, &circ_BOTTOM_LEFT, collider_type, object_type::CIRCLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_sprt, &circ_BOTTOM_RIGHT, collider_type, object_type::CIRCLE, collision_direction::BOTTOM_RIGHT);

                draw_sprite(collider_sprt);
                draw_rectangle(COLOR_GREEN, sprite_collision_rectangle(collider_sprt));
            }
            else if (collider_type == object_type::RECTANGLE) // rect vs. fixed circle objects
            {
                resolve_and_draw(&collider_rect, &circ_TOP, collider_type, object_type::CIRCLE, collision_direction::TOP);
                resolve_and_draw(&collider_rect, &circ_BOTTOM, collider_type, object_type::CIRCLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_rect, &circ_LEFT, collider_type, object_type::CIRCLE, collision_direction::LEFT);
                resolve_and_draw(&collider_rect, &circ_RIGHT, collider_type, object_type::CIRCLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_rect, &circ_TOP_LEFT, collider_type, object_type::CIRCLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_rect, &circ_TOP_RIGHT, collider_type, object_type::CIRCLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_rect, &circ_BOTTOM_LEFT, collider_type, object_type::CIRCLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_rect, &circ_BOTTOM_RIGHT, collider_type, object_type::CIRCLE, collision_direction::BOTTOM_RIGHT);

                fill_rectangle(COLOR_ORANGE, collider_rect);
            }
            else if (collider_type == object_type::CIRCLE) // circle vs. fixed circle objects
            {
                resolve_and_draw(&collider_circ, &circ_TOP, collider_type, object_type::CIRCLE, collision_direction::TOP);
                resolve_and_draw(&collider_circ, &circ_BOTTOM, collider_type, object_type::CIRCLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_circ, &circ_LEFT, collider_type, object_type::CIRCLE, collision_direction::LEFT);
                resolve_and_draw(&collider_circ, &circ_RIGHT, collider_type, object_type::CIRCLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_circ, &circ_TOP_LEFT, collider_type, object_type::CIRCLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_circ, &circ_TOP_RIGHT, collider_type, object_type::CIRCLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_circ, &circ_BOTTOM_LEFT, collider_type, object_type::CIRCLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_circ, &circ_BOTTOM_RIGHT, collider_type, object_type::CIRCLE, collision_direction::BOTTOM_RIGHT);

                fill_circle(COLOR_ORANGE, collider_circ);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_circ));
            }
            else if (collider_type == object_type::TRIANGLE) // triangle vs. fixed circle objects
            {
                resolve_and_draw(&collider_tri, &circ_TOP, collider_type, object_type::CIRCLE, collision_direction::TOP);
                resolve_and_draw(&collider_tri, &circ_BOTTOM, collider_type, object_type::CIRCLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_tri, &circ_LEFT, collider_type, object_type::CIRCLE, collision_direction::LEFT);
                resolve_and_draw(&collider_tri, &circ_RIGHT, collider_type, object_type::CIRCLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_tri, &circ_TOP_LEFT, collider_type, object_type::CIRCLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_tri, &circ_TOP_RIGHT, collider_type, object_type::CIRCLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_tri, &circ_BOTTOM_LEFT, collider_type, object_type::CIRCLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_tri, &circ_BOTTOM_RIGHT, collider_type, object_type::CIRCLE, collision_direction::BOTTOM_RIGHT);

                fill_triangle(COLOR_ORANGE, collider_tri);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_tri));
            }
            else if (collider_type == object_type::QUAD) // quad vs. fixed circle objects
            {
                resolve_and_draw(&collider_quad, &circ_TOP, collider_type, object_type::CIRCLE, collision_direction::TOP);
                resolve_and_draw(&collider_quad, &circ_BOTTOM, collider_type, object_type::CIRCLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_quad, &circ_LEFT, collider_type, object_type::CIRCLE, collision_direction::LEFT);
                resolve_and_draw(&collider_quad, &circ_RIGHT, collider_type, object_type::CIRCLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_quad, &circ_TOP_LEFT, collider_type, object_type::CIRCLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_quad, &circ_TOP_RIGHT, collider_type, object_type::CIRCLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_quad, &circ_BOTTOM_LEFT, collider_type, object_type::CIRCLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_quad, &circ_BOTTOM_RIGHT, collider_type, object_type::CIRCLE, collision_direction::BOTTOM_RIGHT);

                fill_quad(COLOR_ORANGE, collider_quad);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_quad));
            }
        }
        else if (test_type == collision_test_type::TRIANGLE_FIXED)
        {
            fill_triangle(COLOR_GREEN, tri_TOP);
            fill_triangle(COLOR_GREEN, tri_BOTTOM);
            fill_triangle(COLOR_GREEN, tri_LEFT);
            fill_triangle(COLOR_GREEN, tri_RIGHT);
            fill_triangle(COLOR_GREEN, tri_TOP_LEFT);
            fill_triangle(COLOR_GREEN, tri_TOP_RIGHT);
            fill_triangle(COLOR_GREEN, tri_BOTTOM_LEFT);
            fill_triangle(COLOR_GREEN, tri_BOTTOM_RIGHT);

            if (collider_type == object_type::SPRITE) // sprite vs. fixed triangle objects
            {
                resolve_and_draw(&collider_sprt, &tri_TOP, collider_type, object_type::TRIANGLE, collision_direction::TOP);
                resolve_and_draw(&collider_sprt, &tri_BOTTOM, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_sprt, &tri_LEFT, collider_type, object_type::TRIANGLE, collision_direction::LEFT);
                resolve_and_draw(&collider_sprt, &tri_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_sprt, &tri_TOP_LEFT, collider_type, object_type::TRIANGLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_sprt, &tri_TOP_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_sprt, &tri_BOTTOM_LEFT, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_sprt, &tri_BOTTOM_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM_RIGHT);

                draw_sprite(collider_sprt);
                draw_rectangle(COLOR_GREEN, sprite_collision_rectangle(collider_sprt));
            }
            else if (collider_type == object_type::RECTANGLE) // rect vs. fixed triangle objects
            {
                resolve_and_draw(&collider_rect, &tri_TOP, collider_type, object_type::TRIANGLE, collision_direction::TOP);
                resolve_and_draw(&collider_rect, &tri_BOTTOM, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_rect, &tri_LEFT, collider_type, object_type::TRIANGLE, collision_direction::LEFT);
                resolve_and_draw(&collider_rect, &tri_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_rect, &tri_TOP_LEFT, collider_type, object_type::TRIANGLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_rect, &tri_TOP_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_rect, &tri_BOTTOM_LEFT, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_rect, &tri_BOTTOM_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM_RIGHT);

                fill_rectangle(COLOR_ORANGE, collider_rect);
            }
            else if (collider_type == object_type::CIRCLE) // circle vs. fixed triangle objects
            {
                resolve_and_draw(&collider_circ, &tri_TOP, collider_type, object_type::TRIANGLE, collision_direction::TOP);
                resolve_and_draw(&collider_circ, &tri_BOTTOM, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_circ, &tri_LEFT, collider_type, object_type::TRIANGLE, collision_direction::LEFT);
                resolve_and_draw(&collider_circ, &tri_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_circ, &tri_TOP_LEFT, collider_type, object_type::TRIANGLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_circ, &tri_TOP_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_circ, &tri_BOTTOM_LEFT, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_circ, &tri_BOTTOM_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM_RIGHT);

                fill_circle(COLOR_ORANGE, collider_circ);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_circ));
            }
            else if (collider_type == object_type::TRIANGLE) // triangle vs. fixed triangle objects
            {
                resolve_and_draw(&collider_tri, &tri_TOP, collider_type, object_type::TRIANGLE, collision_direction::TOP);
                resolve_and_draw(&collider_tri, &tri_BOTTOM, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_tri, &tri_LEFT, collider_type, object_type::TRIANGLE, collision_direction::LEFT);
                resolve_and_draw(&collider_tri, &tri_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_tri, &tri_TOP_LEFT, collider_type, object_type::TRIANGLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_tri, &tri_TOP_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_tri, &tri_BOTTOM_LEFT, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_tri, &tri_BOTTOM_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM_RIGHT);

                fill_triangle(COLOR_ORANGE, collider_tri);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_tri));
            }
            else if (collider_type == object_type::QUAD) // quad vs. fixed triangle objects
            {
                resolve_and_draw(&collider_quad, &tri_TOP, collider_type, object_type::TRIANGLE, collision_direction::TOP);
                resolve_and_draw(&collider_quad, &tri_BOTTOM, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM);
                resolve_and_draw(&collider_quad, &tri_LEFT, collider_type, object_type::TRIANGLE, collision_direction::LEFT);
                resolve_and_draw(&collider_quad, &tri_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::RIGHT);
                resolve_and_draw(&collider_quad, &tri_TOP_LEFT, collider_type, object_type::TRIANGLE, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_quad, &tri_TOP_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_quad, &tri_BOTTOM_LEFT, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_quad, &tri_BOTTOM_RIGHT, collider_type, object_type::TRIANGLE, collision_direction::BOTTOM_RIGHT);

                fill_quad(COLOR_ORANGE, collider_quad);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_quad));
            }
        }
        else if (test_type == collision_test_type::QUAD_FIXED)
        {
            fill_quad(COLOR_GREEN, quad_TOP);
            fill_quad(COLOR_GREEN, quad_BOTTOM);
            fill_quad(COLOR_GREEN, quad_LEFT);
            fill_quad(COLOR_GREEN, quad_RIGHT);
            fill_quad(COLOR_GREEN, quad_TOP_LEFT);
            fill_quad(COLOR_GREEN, quad_TOP_RIGHT);
            fill_quad(COLOR_GREEN, quad_BOTTOM_LEFT);
            fill_quad(COLOR_GREEN, quad_BOTTOM_RIGHT);

            if (collider_type == object_type::SPRITE) // sprite vs. fixed quad objects
            {
                resolve_and_draw(&collider_sprt, &quad_TOP, collider_type, object_type::QUAD, collision_direction::TOP);
                resolve_and_draw(&collider_sprt, &quad_BOTTOM, collider_type, object_type::QUAD, collision_direction::BOTTOM);
                resolve_and_draw(&collider_sprt, &quad_LEFT, collider_type, object_type::QUAD, collision_direction::LEFT);
                resolve_and_draw(&collider_sprt, &quad_RIGHT, collider_type, object_type::QUAD, collision_direction::RIGHT);
                resolve_and_draw(&collider_sprt, &quad_TOP_LEFT, collider_type, object_type::QUAD, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_sprt, &quad_TOP_RIGHT, collider_type, object_type::QUAD, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_sprt, &quad_BOTTOM_LEFT, collider_type, object_type::QUAD, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_sprt, &quad_BOTTOM_RIGHT, collider_type, object_type::QUAD, collision_direction::BOTTOM_RIGHT);

                draw_sprite(collider_sprt);
                draw_rectangle(COLOR_GREEN, sprite_collision_rectangle(collider_sprt));
            }
            else if (collider_type == object_type::RECTANGLE) // rect vs. fixed quad objects
            {
                resolve_and_draw(&collider_rect, &quad_TOP, collider_type, object_type::QUAD, collision_direction::TOP);
                resolve_and_draw(&collider_rect, &quad_BOTTOM, collider_type, object_type::QUAD, collision_direction::BOTTOM);
                resolve_and_draw(&collider_rect, &quad_LEFT, collider_type, object_type::QUAD, collision_direction::LEFT);
                resolve_and_draw(&collider_rect, &quad_RIGHT, collider_type, object_type::QUAD, collision_direction::RIGHT);
                resolve_and_draw(&collider_rect, &quad_TOP_LEFT, collider_type, object_type::QUAD, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_rect, &quad_TOP_RIGHT, collider_type, object_type::QUAD, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_rect, &quad_BOTTOM_LEFT, collider_type, object_type::QUAD, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_rect, &quad_BOTTOM_RIGHT, collider_type, object_type::QUAD, collision_direction::BOTTOM_RIGHT);

                fill_rectangle(COLOR_ORANGE, collider_rect);
            }
            else if (collider_type == object_type::CIRCLE) // circle vs. fixed quad objects
            {
                resolve_and_draw(&collider_circ, &quad_TOP, collider_type, object_type::QUAD, collision_direction::TOP);
                resolve_and_draw(&collider_circ, &quad_BOTTOM, collider_type, object_type::QUAD, collision_direction::BOTTOM);
                resolve_and_draw(&collider_circ, &quad_LEFT, collider_type, object_type::QUAD, collision_direction::LEFT);
                resolve_and_draw(&collider_circ, &quad_RIGHT, collider_type, object_type::QUAD, collision_direction::RIGHT);
                resolve_and_draw(&collider_circ, &quad_TOP_LEFT, collider_type, object_type::QUAD, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_circ, &quad_TOP_RIGHT, collider_type, object_type::QUAD, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_circ, &quad_BOTTOM_LEFT, collider_type, object_type::QUAD, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_circ, &quad_BOTTOM_RIGHT, collider_type, object_type::QUAD, collision_direction::BOTTOM_RIGHT);

                fill_circle(COLOR_ORANGE, collider_circ);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_circ));
            }
            else if (collider_type == object_type::TRIANGLE) // triangle vs. fixed quad objects
            {
                resolve_and_draw(&collider_tri, &quad_TOP, collider_type, object_type::QUAD, collision_direction::TOP);
                resolve_and_draw(&collider_tri, &quad_BOTTOM, collider_type, object_type::QUAD, collision_direction::BOTTOM);
                resolve_and_draw(&collider_tri, &quad_LEFT, collider_type, object_type::QUAD, collision_direction::LEFT);
                resolve_and_draw(&collider_tri, &quad_RIGHT, collider_type, object_type::QUAD, collision_direction::RIGHT);
                resolve_and_draw(&collider_tri, &quad_TOP_LEFT, collider_type, object_type::QUAD, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_tri, &quad_TOP_RIGHT, collider_type, object_type::QUAD, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_tri, &quad_BOTTOM_LEFT, collider_type, object_type::QUAD, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_tri, &quad_BOTTOM_RIGHT, collider_type, object_type::QUAD, collision_direction::BOTTOM_RIGHT);

                fill_triangle(COLOR_ORANGE, collider_tri);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_tri));
            }
            else if (collider_type == object_type::QUAD) // quad vs. fixed quad objects
            {
                resolve_and_draw(&collider_quad, &quad_TOP, collider_type, object_type::QUAD, collision_direction::TOP);
                resolve_and_draw(&collider_quad, &quad_BOTTOM, collider_type, object_type::QUAD, collision_direction::BOTTOM);
                resolve_and_draw(&collider_quad, &quad_LEFT, collider_type, object_type::QUAD, collision_direction::LEFT);
                resolve_and_draw(&collider_quad, &quad_RIGHT, collider_type, object_type::QUAD, collision_direction::RIGHT);
                resolve_and_draw(&collider_quad, &quad_TOP_LEFT, collider_type, object_type::QUAD, collision_direction::TOP_LEFT);
                resolve_and_draw(&collider_quad, &quad_TOP_RIGHT, collider_type, object_type::QUAD, collision_direction::TOP_RIGHT);
                resolve_and_draw(&collider_quad, &quad_BOTTOM_LEFT, collider_type, object_type::QUAD, collision_direction::BOTTOM_LEFT);
                resolve_and_draw(&collider_quad, &quad_BOTTOM_RIGHT, collider_type, object_type::QUAD, collision_direction::BOTTOM_RIGHT);

                fill_quad(COLOR_ORANGE, collider_quad);
                draw_rectangle(COLOR_GREEN, rectangle_around(collider_quad));
            }
        } // end if

        refresh_screen(60);

    } // end while

    show_mouse();
    close_all_windows();
}

void run_sprite_test()
{
    sprite_test();
    multi_object_collision_resolution_test();
}
