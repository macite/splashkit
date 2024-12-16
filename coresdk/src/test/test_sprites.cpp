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

using namespace splashkit_lib;

void sprite_test()
{
    sprite sprt, s2;
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

        draw_rectangle(COLOR_GREEN, sprite_collision_rectangle(sprt));

        draw_line(COLOR_GREEN, line_from(center_point(sprt), matrix_multiply(rotation_matrix(sprite_rotation(sprt)), vector_multiply(sprite_velocity(sprt), 30.0))));

        refresh_screen(60);
    }
    
    show_mouse();
    
    close_all_windows();
}

void test_sprite_ray_collision()
{
    window w1 = open_window("Sprite Ray Collision", 800, 600);
    sprite s1 = create_sprite("on_med.png");
    sprite_set_position(s1, point_at(200.0, 200.0));
    sprite_set_rotation(s1, 45.0f);
    sprite s2 = create_sprite("rocket_sprt.png");
    sprite_set_position(s2, point_at(500.0, 100.0));
    sprite s3 = create_sprite("up_pole.png");
    sprite_set_position(s3, point_at(600.0, 300.0));
    sprite_set_rotation(s3, 10.0f);
    point_2d ray_origin = point_at(100, 100);
    vector_2d ray_heading = vector_to(200, 200);
    
    while ( !window_close_requested(w1) ) {
        process_events();
        
        clear_screen(COLOR_WHITE);

        if (key_down(UP_KEY))
            ray_origin.y -= 1.0;
        if (key_down(DOWN_KEY))
            ray_origin.y += 1.0;
        if (key_down(LEFT_KEY))
            ray_origin.x -= 1.0;
        if (key_down(RIGHT_KEY))
            ray_origin.x += 1.0;
        
        bool collision_1 = sprite_ray_collision(s1, ray_origin, ray_heading);
        bool collision_2 = sprite_ray_collision(s2, ray_origin, ray_heading);
        bool collision_3 = sprite_ray_collision(s3, ray_origin, ray_heading);

        draw_sprite(s1);
        if (collision_1)
        {
            fill_circle(COLOR_RED, circle_at(sprite_collision_circle(s1).center, 30.0));
        }

        draw_sprite(s2);
        if (collision_2)
        {
            fill_circle(COLOR_RED, circle_at(sprite_collision_circle(s2).center, 8.0));
        }

        draw_sprite(s3);
        if (collision_3)
        {
            fill_circle(COLOR_RED, circle_at(sprite_collision_circle(s3).center, 30.0));
        }

        ray_heading = vector_point_to_point(ray_origin, mouse_position());
        vector_2d normal_heading = unit_vector(ray_heading);
        draw_line(COLOR_BLACK, ray_origin, point_offset_by(ray_origin, vector_multiply(normal_heading, 800.0)));

        circle mouse_circle = circle_at(mouse_position(), 3.0);
        draw_circle(COLOR_GREEN, mouse_circle);

        circle ray_origin_circle = circle_at(ray_origin, 3.0);
        draw_circle(COLOR_BLUE, ray_origin_circle);
        
        refresh_screen();
    }
    close_window(w1);
}

void run_sprite_test()
{
    sprite_test();
    test_sprite_ray_collision();
}