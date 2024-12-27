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

void test_tangent_points()
{
    circle c1 = circle_at(100, 100, 50);
    point_2d pp = point_at(100, 25);
    point_2d p11, p22;
    tangent_points(pp, c1, p11, p22);
    cout << "Tangent points for circle at 100,100,50 from 100,25 are " << point_to_string(p11) << " and " << point_to_string(p22) << endl;
    
    circle c = circle_at(300.0, 300.0, 150.0);
    point_2d p, p1, p2;
    tangent_points(p, c, p1, p2);

    window w1 = open_window("Tangent Point Tests", 600, 800);
    while ( !window_close_requested(w1) ) {
        process_events();
        
        if (key_down(UP_KEY))
            c.radius += 0.05;

        if (key_down(DOWN_KEY))
            c.radius -= 0.05;

        clear_screen(COLOR_WHEAT);

        p = mouse_position();

        if(tangent_points(p, c, p1, p2))
        {
            draw_circle(COLOR_RED, c.center.x, c.center.y, 5);
            draw_circle(COLOR_RED, p1.x, p1.y, 5);
            draw_circle(COLOR_RED, p2.x, p2.y, 5);
            draw_line(COLOR_RED, line_from(p1, c.center));
            draw_line(COLOR_RED, line_from(p2, c.center));
            draw_line(COLOR_RED, line_from(p, p1));
            draw_line(COLOR_RED, line_from(p, p2));
        }
        draw_circle(COLOR_RED, c);

        refresh_screen();
    }
    close_window(w1);
}

void test_triangle_rectangle_intersect()
{
    auto t1 = triangle_from(110, 110, 120, 150, 170, 190);
    auto t2 = triangle_from(200, 200, 200, 500, 500, 500);
    auto t3 = triangle_from(300, 20, 280, 240, 550, 60);
    auto t4 = triangle_from(150, 700, 265, 600, 510, 610);

    window w1 = open_window("Triangle Tests", 600, 800);
    while ( !window_close_requested(w1) ) {
        process_events();

        clear_screen(COLOR_WHEAT);

        point_2d mouse = mouse_position();
        auto r1 = rectangle_from(mouse.x - 25, mouse.y - 25, 50, 50);

        if (triangle_rectangle_intersect(t1, r1))
            fill_triangle(COLOR_TAN, t1);

        if (triangle_rectangle_intersect(t2, r1))
            fill_triangle(COLOR_TAN, t2);

        if (triangle_rectangle_intersect(t3, r1))
            fill_triangle(COLOR_TAN, t3);

        if (triangle_rectangle_intersect(t4, r1))
            fill_triangle(COLOR_TAN, t4);

        draw_triangle(COLOR_RED, t1);
        draw_triangle(COLOR_RED, t2);
        draw_triangle(COLOR_RED, t3);
        draw_triangle(COLOR_RED, t4);

        draw_rectangle(COLOR_RED, r1);

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
    test_tangent_points();
    test_triangle_rectangle_intersect();
}