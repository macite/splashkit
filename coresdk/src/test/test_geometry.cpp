//
//  test_geometry.cpp
//  splashkit
//
//  Created by Jacob on 19/08/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#include <iostream>
using namespace std;

#include "geometry.h"
#include "window_manager.h"
#include "graphics.h"
#include "input.h"

using namespace splashkit_lib;

enum class geometry_test_shape_type
{
    RECTANGLE,
    CIRCLE,
    TRIANGLE,
    QUAD,
    NONE
};

void test_points()
{
    point_2d p = point_at(10, 20);
    cout << "Point is at 10,20" << endl;
    cout << point_to_string(p) << endl;
    
    window w1 = open_window("Point Tests", 600, 600);
    
    triangle t1 = triangle_from(10, 10, 50, 50, 70, 55);
    rectangle r1 = rectangle_from(200, 200, -75, -100);
    circle c1 = circle_at(300, 300, 100);
    circle c2 = circle_at(300, 300, -10);
    line l = line_from(point_at_origin(), random_screen_point());
    
    cout << "Angle of line is " << point_point_angle(point_at_origin(), l.end_point) << endl;
    
    while (not window_close_requested(w1))
    {
        process_events();
        
        clear_screen(COLOR_WHEAT);
        
        if ( point_in_triangle(mouse_position(), t1) )
        {
            fill_triangle(COLOR_TAN, t1);
        }
        draw_triangle(COLOR_RED, t1);

        if ( point_in_rectangle(mouse_position(), r1) )
        {
            fill_rectangle(COLOR_TAN, r1);
        }
        draw_rectangle(COLOR_RED, r1);

        if ( point_in_circle(mouse_position(), c1) )
        {
            fill_circle(COLOR_TAN, c1);
        }
        draw_circle(COLOR_RED, c1);
        
        
        if ( point_in_circle(mouse_position(), c2) )
        {
            fill_circle(COLOR_RED, c2);
        }
        draw_circle(COLOR_RED, c2);
        
        if ( point_on_line(mouse_position(), l))
        {
            fill_circle(COLOR_RED, circle_at(l.start_point, 5));
            fill_circle(COLOR_RED, circle_at(l.end_point, 5));
        }
        draw_line(COLOR_RED, l);
        
        refresh_screen();
    }
    
    close_window(w1);
}

void test_rectangle()
{
    auto r1 = rectangle_from(10, 20, 30, 40);
    auto r2 = rectangle_from(15, 30, 100, 100);
    
    cout << "Created rectangle 10,20 30x40" << endl;
    cout << rectangle_to_string(r1) << endl;
    
    cout << "Top    (should be 20): " << rectangle_top(r1) << endl;
    cout << "Bottom (should be 60): " << rectangle_bottom(r1) << endl;
    cout << "Left   (should be 10): " << rectangle_left(r1) << endl;
    cout << "Right  (should be 40): " << rectangle_right(r1) << endl;
    
    auto center = rectangle_center(r1);
    cout << "Center (should be 25,40): " << center.x << "," << center.y << endl;
    
    auto intersect = intersection(r1, r2);
    cout << "Intersection should be 15,30 25x30" << endl;
    cout << "Intersection is " << rectangle_to_string(intersect) << endl;
    
    auto t1 = triangle_from(300, 300, 350, 350, 370, 355);
    auto t2 = triangle_from(300, 100, 250, 250, 150, 250);
    auto c1 = circle_at(450, 450, 50);
    auto r3 = rectangle_around(t1);
    auto r4 = rectangle_around(t2);
    auto r5 = rectangle_around(c1);
    
    
    window w1 = open_window("Rectangle Tests", 600, 800);
    while ( !window_close_requested(w1) ) {
        process_events();
        
        clear_screen(COLOR_WHEAT);
        
        draw_rectangle(COLOR_RED, r1);
        draw_rectangle(COLOR_RED, r2);
        draw_rectangle(COLOR_YELLOW, intersect);
        
        draw_triangle(COLOR_RED, t1);
        draw_triangle(COLOR_RED, t2);
        draw_circle(COLOR_RED, c1);
        
        draw_rectangle(COLOR_RED, r3);
        draw_rectangle(COLOR_RED, r4);
        draw_rectangle(COLOR_RED, r5);
        
        refresh_screen();
    }
    close_window(w1);
}

void test_lines()
{
    std::vector<line> lines;
    lines.push_back(line_from(110, 100, 110, 150));
    lines.push_back(line_from(120, 100, 120, 150));
    lines.push_back(line_from(130, 100, 130, 150));

    int line_idx = 0;

    point_2d pt = point_at(100, 105);
    point_2d closest = closest_point_on_lines(pt, lines, line_idx);
    cout << "Closest point should be (110,105 on line 0): " << point_to_string(closest) << " on line " << line_idx << endl;

    pt = point_at(135, 108);
    closest = closest_point_on_lines(pt, lines, line_idx);
    cout << "Closest point should be (130,108 on line 2): " << point_to_string(closest) << " on line " << line_idx << endl;

    pt = point_at(121, 103);
    closest = closest_point_on_lines(pt, lines, line_idx);
    cout << "Closest point (should be 120,103 on line 1): " << point_to_string(closest) << " on line " << line_idx << endl;

    // no lines
    closest = closest_point_on_lines(pt, {}, line_idx);
    cout << "Closest point (should be 0,0 on line -1): " << point_to_string(closest) << " on line " << line_idx << endl;

    circle c1 = circle_at(300, 300, 2);

    lines.push_back(line_from(200, 200, 400, 400));
    lines.push_back(line_from(200, 400, 400, 200));
    lines.push_back(line_from(15, 15, 400, 30));
    lines.push_back(line_from(100, 500, 500, 400));
    lines.push_back(line_from(550, 700, 550, 790));
    lines.push_back(line_from(30, 550, 230, 650));

    window w1 = open_window("Line Tests", 600, 800);
    while ( !window_close_requested(w1) ) {
        process_events();

        clear_screen(COLOR_WHEAT);

        c1.center = mouse_position();

        point_2d p1 = closest_point_on_lines(c1.center, lines, line_idx);

        for (int i = 0; i < lines.size(); i++)
        {
            if (i == line_idx)
                draw_line(COLOR_RED, lines[i]);
            else
                draw_line(COLOR_BLACK, lines[i]);
        }
        draw_circle(COLOR_RED, p1.x, p1.y, 5);
        fill_circle(COLOR_RED, c1);

        refresh_screen();
    }
    close_window(w1);
}

void test_triangle()
{
    auto t1 = triangle_from(110, 110, 120, 150, 170, 190);
    auto t2 = triangle_from(200, 200, 200, 500, 500, 500);
    auto t3 = triangle_from(300, 20, 280, 240, 550, 60);
    auto t4 = triangle_from(150, 700, 265, 600, 510, 610);
    auto c1 = circle_at(300, 300, 50);

    window w1 = open_window("Triangle Tests", 600, 800);
    while ( !window_close_requested(w1) ) {
        process_events();
        
        if (key_down(UP_KEY))
            c1.radius += 0.05;

        if (key_down(DOWN_KEY))
            c1.radius -= 0.05;

        clear_screen(COLOR_WHEAT);

        c1.center = mouse_position();

        point_2d p1, p2, p3, p4;

        if (circle_triangle_intersect(c1, t1, p1))
            fill_triangle(COLOR_TAN, t1);

        if (circle_triangle_intersect(c1, t2, p2))
            fill_triangle(COLOR_TAN, t2);

        if (circle_triangle_intersect(c1, t3, p3))
            fill_triangle(COLOR_TAN, t3);

        if (circle_triangle_intersect(c1, t4, p4))
            fill_triangle(COLOR_TAN, t4);

        draw_triangle(COLOR_RED, t1);
        draw_triangle(COLOR_RED, t2);
        draw_triangle(COLOR_RED, t3);
        draw_triangle(COLOR_RED, t4);

        draw_circle(COLOR_RED, p1.x, p1.y, 5);
        draw_circle(COLOR_RED, p2.x, p2.y, 5);
        draw_circle(COLOR_RED, p3.x, p3.y, 5);
        draw_circle(COLOR_RED, p4.x, p4.y, 5);

        draw_circle(COLOR_RED, c1);

        refresh_screen();
    }
    close_window(w1);
}

void draw_ray_shape_intersection(const line& l, const point_2d& circ_center, color& clr)
{
    draw_line(COLOR_BLACK, l);
    fill_circle(COLOR_RED, circle_at(circ_center, 5.0));
    clr = COLOR_RED;
}

geometry_test_shape_type calculate_min_dist_shape(bool rect, bool circ, bool tri, bool quad, double rect_dist,
                                    double circ_dist, double tri_dist, double quad_dist)
{
    double min_dist = __DBL_MAX__;
    geometry_test_shape_type result = geometry_test_shape_type::NONE;

    if (rect && rect_dist < min_dist)
    {
        min_dist = rect_dist;
        result = geometry_test_shape_type::RECTANGLE;
    }
    if (circ && circ_dist < min_dist)
    {
        min_dist = circ_dist;
        result = geometry_test_shape_type::CIRCLE;
    }
    if (tri && tri_dist < min_dist)
    {
        min_dist = tri_dist;
        result = geometry_test_shape_type::TRIANGLE;
    }
    if (quad && quad_dist < min_dist)
    {
        min_dist = quad_dist;
        result = geometry_test_shape_type::QUAD;
    }

    return result;
}

struct test_shape
{
    color clr = COLOR_BLUE;
    point_2d hit_point = point_at(0.0, 0.0);
    double distance = 0.0;
    bool intersection = false;
};

void test_rect_circ_tri_ray_intersection()
{
    auto r1 = rectangle_from(100.0, 100.0, 100.0, 100.0);
    test_shape r1_shape;
    auto c1 = circle_at(300.0, 200.0, 60.0);
    test_shape c1_shape;
    auto t1 = triangle_from(400.0, 400.0, 550.0, 410.0, 390.0, 550.0);
    test_shape t1_shape;
    auto q1 = quad_from(100.0, 300.0, 200.0, 350.0, 100.0, 550.0, 200.0, 500.0);
    test_shape q1_shape;
    auto player = point_at(300.0, 300.0);

    bool rect_true = rectangle_ray_intersection(point_at(90.0, 110.0), vector_to(1.0, 0.0), r1);
    bool rect_false = rectangle_ray_intersection(point_at(90.0, 110.0), vector_to(__DBL_MIN__, 0.0), r1);

    cout << "Rectangle ray intersection test (should be true): " << rect_true << endl;
    cout << "Rectangle ray intersection test (should be false): " << rect_false << endl;

    window w1 = open_window("Ray Intersection Tests", 600, 800);
    while ( !window_close_requested(w1) ) {
        process_events();
        
        clear_screen(COLOR_WHEAT);

        if (key_down(UP_KEY))
            player.y -= 1;
        if (key_down(DOWN_KEY))
            player.y += 1;
        if (key_down(LEFT_KEY))
            player.x -= 1;
        if (key_down(RIGHT_KEY))
            player.x += 1;

        vector_2d player_heading = vector_point_to_point(player, mouse_position());

        r1_shape.intersection = rectangle_ray_intersection(player, player_heading, r1, r1_shape.hit_point, r1_shape.distance);
        c1_shape.intersection = circle_ray_intersection(player, player_heading, c1, c1_shape.hit_point, c1_shape.distance);
        t1_shape.intersection = triangle_ray_intersection(player, player_heading, t1, t1_shape.hit_point, t1_shape.distance);
        q1_shape.intersection = quad_ray_intersection(player, player_heading, q1, q1_shape.hit_point, q1_shape.distance);

        r1_shape.clr = COLOR_BLUE;
        c1_shape.clr = COLOR_BLUE;
        t1_shape.clr = COLOR_BLUE;
        q1_shape.clr = COLOR_BLUE;

        geometry_test_shape_type min_dist_shape = calculate_min_dist_shape(r1_shape.intersection, c1_shape.intersection,
                                                                            t1_shape.intersection, q1_shape.intersection,
                                                                            r1_shape.distance, c1_shape.distance,
                                                                            t1_shape.distance, q1_shape.distance);

        switch (min_dist_shape)
        {
            case geometry_test_shape_type::RECTANGLE:
                draw_ray_shape_intersection(line_from(player, r1_shape.hit_point), r1_shape.hit_point, r1_shape.clr);
                break;
            case geometry_test_shape_type::CIRCLE:
                draw_ray_shape_intersection(line_from(player, c1_shape.hit_point), c1_shape.hit_point, c1_shape.clr);
                break;
            case geometry_test_shape_type::TRIANGLE:
                draw_ray_shape_intersection(line_from(player, t1_shape.hit_point), t1_shape.hit_point, t1_shape.clr);
                break;
            case geometry_test_shape_type::QUAD:
                draw_ray_shape_intersection(line_from(player, q1_shape.hit_point), q1_shape.hit_point, q1_shape.clr);
                break;
            default: // shape_type::NONE:
                draw_line(COLOR_BLACK, player, point_offset_by(player, vector_multiply(unit_vector(player_heading), 1000.0)));
        };

        draw_rectangle(r1_shape.clr, r1);
        draw_circle(c1_shape.clr, c1);
        draw_triangle(t1_shape.clr, t1);
        draw_quad(q1_shape.clr, q1);

        draw_circle(COLOR_BLACK, circle_at(player, 5.0));

        refresh_screen();
    }
    close_window(w1);
}

void run_geometry_test()
{
    test_rectangle();
    test_points();
    test_lines();
    test_triangle();
    test_rect_circ_tri_ray_intersection();
}