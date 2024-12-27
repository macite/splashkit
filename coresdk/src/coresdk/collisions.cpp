//
//  collisions.cpp
//  splashkit
//
//  Created by Andrew Cain on 25/08/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#include "collisions.h"
#include "physics.h"
#include "sprites.h"
#include "utility_functions.h"

#include <cmath>
#include <functional>

#include "graphics.h"
#include "utils.h"

constexpr int BRACKET_ITERATIONS = 40;
constexpr double ITERATION_POWER = 1.5;

using std::function;

namespace splashkit_lib
{
    enum class _obj_movement_direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
        UP_LEFT,
        UP_RIGHT,
        DOWN_LEFT,
        DOWN_RIGHT,
        NONE,
    };
    
    //#define DEBUG_STEP

    // Step over pixels in the two areas based on the supplied matrix
    //
    // See http://www.austincc.edu/cchrist1/GAME1343/TransformedCollision/TransformedCollision.htm
    bool _step_through_pixels (
                               double w1, double h1,
                               const matrix_2d &matrix1,
                               double w2, double h2,
                               const matrix_2d &matrix2,
                               function<bool(int, int, int, int)> end_fn )
    {
        bool a_is_1;
        double h_a, w_a;
        double h_b, w_b;
        matrix_2d transform_a_to_b;

        // Determine the smaller area to step through.
        if ( w1 * h1 <= w2 * h2 ) // use bitmap 1 as the one to scan
        {
            a_is_1 = true;
            h_a = h1;
            w_a = w1;

            h_b = h2;
            w_b = w2;

            // Calculate a matrix which transforms from 1's local space into
            // world space and then into 2's local space
            transform_a_to_b = matrix_multiply(matrix1, matrix_inverse(matrix2));
        }
        else // use bitmap 2
        {
            a_is_1 = false;
            h_a = h2;
            w_a = w2;

            h_b = h1;
            w_b = w1;

            // Calculate a matrix which transforms from 1's local space into
            // world space and then into 2's local space
            transform_a_to_b = matrix_multiply(matrix2, matrix_inverse(matrix1));
        }

        vector_2d step_x, step_y, y_pos_in_b, pos_in_b;

        // Calculate the top left corner of A in B's local space
        // This variable will be reused to keep track of the start of each row
        y_pos_in_b = matrix_multiply(transform_a_to_b, vector_to(0,0));

        // When a point moves in A's local space, it moves in B's local space with a
        // fixed direction and distance proportional to the movement in A.
        // This algorithm steps through A one pixel at a time along A's X and Y axes
        // Calculate the analogous steps in B:
        step_x = vector_subtract(matrix_multiply(transform_a_to_b, vector_to(1, 0)), y_pos_in_b);
        step_y = vector_subtract(matrix_multiply(transform_a_to_b, vector_to(0, 1)), y_pos_in_b); // y inverted for drawing

        int x_b, y_b;

        // have to check all pixels of one bitmap
        // For each row of pixels in A (the smaller)
        for (int y_a = 0; y_a < h_a; y_a++)
        {
            pos_in_b = y_pos_in_b;

            // For each pixel in this row
            for (int x_a = 0; x_a < w_a; x_a++)
            {
                // Calculate this pixel's location in B
                // positionInB = transform_a_to_b * vector_to(xA, yA);

                // Round to the nearest pixel
                x_b = trunc(pos_in_b.x);
                y_b = trunc(pos_in_b.y);

                // If the pixel lies within the bounds of B
                if  ( (0 <= x_b) and (x_b < w_b) and (0 <= y_b) and (y_b < h_b) )
                {
                    if ( ( a_is_1 and end_fn(x_a, y_a, x_b, y_b) )
                        or ( (not a_is_1) and end_fn(x_b, y_b, x_a, y_a)) )
                    {
                        return true;
                    }
                }

                // Move to the next pixel in the row
                pos_in_b = vector_add(pos_in_b, step_x);
            }

            // Move to the next row
            y_pos_in_b = vector_add(y_pos_in_b, step_y);
        }

        // No intersection found
        return false;
    }

    bool _collision_within_bitmap_images_with_translation(bitmap bmp1, int c1, const matrix_2d& matrix1, bitmap bmp2, int c2, const matrix_2d& matrix2)
    {
        return _step_through_pixels(bitmap_cell_width(bmp1), bitmap_cell_height(bmp1), matrix1,
                                    bitmap_cell_width(bmp2), bitmap_cell_height(bmp2), matrix2,
                                    [&] (int ax, int ay, int bx, int by)
                                    {
#if DEBUG_STEP
                                        point_2d apt, bpt;
                                        apt = matrix_multiply(matrix1, point_at(ax,ay));
                                        if ( pixel_drawn_at_point(bmp1, c1, ax, ay) )
                                            draw_circle(COLOR_RED, apt.x, apt.y, 3);
                                        bpt = matrix_multiply(matrix2, point_at(bx,by));
                                        if ( pixel_drawn_at_point(bmp2, c2, bx, by) )
                                            draw_circle(COLOR_PINK, bpt.x, bpt.y, 2);

                                        if ( pixel_drawn_at_point(bmp1, c1, ax, ay) and pixel_drawn_at_point(bmp2, c2, bx, by) )
                                        {
                                            fill_circle(COLOR_GREEN, apt.x, apt.y, 1);
                                            fill_circle(COLOR_YELLOW, bpt.x, bpt.y, 3);
                                        }
#endif
                                        return pixel_drawn_at_point(bmp1, c1, ax, ay) and pixel_drawn_at_point(bmp2, c2, bx, by);
                                    });
    }

    _obj_movement_direction _opposite_direction(_obj_movement_direction direction)
    {
        switch (direction)
        {
        case _obj_movement_direction::UP:
            return _obj_movement_direction::DOWN;
        case _obj_movement_direction::DOWN:
            return _obj_movement_direction::UP;
        case _obj_movement_direction::LEFT:
            return _obj_movement_direction::RIGHT;
        case _obj_movement_direction::RIGHT:
            return _obj_movement_direction::LEFT;
        case _obj_movement_direction::UP_LEFT:
            return _obj_movement_direction::DOWN_RIGHT;
        case _obj_movement_direction::UP_RIGHT:
            return _obj_movement_direction::DOWN_LEFT;
        case _obj_movement_direction::DOWN_LEFT:
            return _obj_movement_direction::UP_RIGHT;
        case _obj_movement_direction::DOWN_RIGHT:
            return _obj_movement_direction::UP_LEFT;
        };
        return _obj_movement_direction::NONE;
    }

    _obj_movement_direction _direction_from_collision(collision_direction direction)
    {
        switch (direction)
        {
        case collision_direction::TOP:
            return _obj_movement_direction::DOWN;
        case collision_direction::BOTTOM:
            return _obj_movement_direction::UP;
        case collision_direction::LEFT:
            return _obj_movement_direction::RIGHT;
        case collision_direction::RIGHT:
            return _obj_movement_direction::LEFT;
        case collision_direction::TOP_LEFT:
            return _obj_movement_direction::DOWN_RIGHT;
        case collision_direction::TOP_RIGHT:
            return _obj_movement_direction::DOWN_LEFT;
        case collision_direction::BOTTOM_LEFT:
            return _obj_movement_direction::UP_RIGHT;
        case collision_direction::BOTTOM_RIGHT:
            return _obj_movement_direction::UP_LEFT;
        };
        return _obj_movement_direction::NONE;
    }

    void _move_sprite_by_vector(void* sprt, const vector_2d& amount)
    {
        sprite s = *static_cast<const sprite*>(sprt);
        
        sprite_set_x(s, sprite_x(s) + amount.x);
        sprite_set_y(s, sprite_y(s) + amount.y);
    }

    void _move_rectangle_by_vector(void* rect, const vector_2d& amount)
    {
        rectangle* r = static_cast<rectangle*>(rect);
        
        r->x += amount.x;
        r->y += amount.y;
    }

    void _move_circle_by_vector(void* circ, const vector_2d& amount)
    {
        circle* c = static_cast<circle*>(circ);
        
        c->center.x += amount.x;
        c->center.y += amount.y;
    }

    void _move_triangle_by_vector(void* tri, const vector_2d& amount)
    {
        triangle* t = static_cast<triangle*>(tri);

        t->points[0].x += amount.x;
        t->points[0].y += amount.y;
        t->points[1].x += amount.x;
        t->points[1].y += amount.y;
        t->points[2].x += amount.x;
        t->points[2].y += amount.y;
    }

    void _move_quad_by_vector(void* q, const vector_2d& amount)
    {
        quad* qd = static_cast<quad*>(q);

        qd->points[0].x += amount.x;
        qd->points[0].y += amount.y;
        qd->points[1].x += amount.x;
        qd->points[1].y += amount.y;
        qd->points[2].x += amount.x;
        qd->points[2].y += amount.y;
        qd->points[3].x += amount.x;
        qd->points[3].y += amount.y;
    }

    void _move_object_by_direction(void* obj, std::function<void(void*, const vector_2d& amount)> move_func,
                                                            _obj_movement_direction direction, const vector_2d& amount)
    {
        if (amount.x == 0.0 && amount.y == 0.0)
        {
            return;
        }
        
        switch (direction)
        {
        case _obj_movement_direction::UP:
            move_func(obj, vector_to(0.0, -amount.y));
            break;
        case _obj_movement_direction::DOWN:
            move_func(obj, vector_to(0.0, amount.y));
            break;
        case _obj_movement_direction::LEFT:
            move_func(obj, vector_to(-amount.x, 0.0));
            break;
        case _obj_movement_direction::RIGHT:
            move_func(obj, vector_to(amount.x, 0.0));
            break;
        case _obj_movement_direction::UP_LEFT:
            move_func(obj, vector_to(-amount.x, -amount.y));
            break;
        case _obj_movement_direction::UP_RIGHT:
            move_func(obj, vector_to(amount.x, -amount.y));
            break;
        case _obj_movement_direction::DOWN_LEFT:
            move_func(obj, vector_to(-amount.x, amount.y));
            break;
        default: // _obj_movement_direction::DOWN_RIGHT:
            move_func(obj, vector_to(amount.x, amount.y));
            break;
        };
    }

    void _move_object_by_direction_relative_to_size(void* obj, const rectangle& obj_aabb,
        std::function<void(void*, const vector_2d& amount)> move_func,
            _obj_movement_direction direction, double relative_amount = 1.0)
    {
        double relative_width = obj_aabb.width * relative_amount;
        double relative_height = obj_aabb.height * relative_amount;

        switch (direction)
        {
        case _obj_movement_direction::UP:
            _move_object_by_direction(obj, move_func, _obj_movement_direction::UP, vector_to(0.0, relative_height));
            break;
        case _obj_movement_direction::DOWN:
            _move_object_by_direction(obj, move_func, _obj_movement_direction::DOWN, vector_to(0.0, relative_height));
            break;
        case _obj_movement_direction::LEFT:
            _move_object_by_direction(obj, move_func, _obj_movement_direction::LEFT, vector_to(relative_width, 0.0));
            break;
        case _obj_movement_direction::RIGHT:
            _move_object_by_direction(obj, move_func, _obj_movement_direction::RIGHT, vector_to(relative_width, 0.0));
            break;
        case _obj_movement_direction::UP_LEFT:
            _move_object_by_direction(obj, move_func, _obj_movement_direction::UP_LEFT, vector_to(relative_width, relative_height));
            break;
        case _obj_movement_direction::UP_RIGHT:
            _move_object_by_direction(obj, move_func, _obj_movement_direction::UP_RIGHT, vector_to(relative_width, relative_height));
            break;
        case _obj_movement_direction::DOWN_LEFT:
            _move_object_by_direction(obj, move_func, _obj_movement_direction::DOWN_LEFT, vector_to(relative_width, relative_height));
            break;
        default: // _obj_movement_direction::DOWN_RIGHT:
            _move_object_by_direction(obj, move_func, _obj_movement_direction::DOWN_RIGHT, vector_to(relative_width, relative_height));
            break;
        };
    }

    bool _sprite_sprite_collision_func(const void* s1, const void* s2)
    {
        return sprite_collision(*static_cast<const sprite*>(s1), *static_cast<const sprite*>(s2));
    }

    bool _sprite_rectangle_collision_func(const void* s, const void* rect)
    {
        return sprite_rectangle_collision(*static_cast<const sprite*>(s), *static_cast<const rectangle*>(rect));
    }

    bool _sprite_circle_collision_func(const void* s, const void* circ)
    {
        return sprite_circle_collision(*static_cast<const sprite*>(s), *static_cast<const circle*>(circ));
    }

    bool _sprite_triangle_collision_func(const void* s, const void* tri)
    {
        return sprite_triangle_collision(*static_cast<const sprite*>(s), *static_cast<const triangle*>(tri));
    }

    bool _sprite_quad_collision_func(const void* s, const void* q)
    {
        return sprite_quad_collision(*static_cast<const sprite*>(s), *static_cast<const quad*>(q));
    }

    bool _rectangle_sprite_collision_func(const void* rect, const void* s)
    {
        return _sprite_rectangle_collision_func(s, rect);
    }

    bool _rectangle_rectangle_collision_func(const void* r1, const void* r2)
    {
        return rectangles_intersect(*static_cast<const rectangle*>(r1), *static_cast<const rectangle*>(r2));
    }

    bool _rectangle_circle_collision_func(const void* r, const void* c)
    {
        return rectangle_circle_intersect(*static_cast<const rectangle*>(r), *static_cast<const circle*>(c));
    }

    bool _rectangle_triangle_collision_func(const void* r, const void* t)
    {
        return triangle_rectangle_intersect(*static_cast<const triangle*>(t), *static_cast<const rectangle*>(r));
    }

    bool _rectangle_quad_collision_func(const void* r, const void* q)
    {
        return quads_intersect(quad_from(*static_cast<const rectangle*>(r)), *static_cast<const quad*>(q));
    }

    bool _circle_sprite_collision_func(const void* c, const void* s)
    {
        return _sprite_circle_collision_func(s, c);
    }

    bool _circle_rectangle_collision_func(const void* c, const void* r)
    {
        return _rectangle_circle_collision_func(r, c);
    }

    bool _circle_circle_collision_func(const void* c1, const void* c2)
    {
        return circles_intersect(*static_cast<const circle*>(c1), *static_cast<const circle*>(c2));
    }

    bool _circle_triangle_collision_func(const void* c, const void* t)
    {
        return circle_triangle_intersect(*static_cast<const circle*>(c), *static_cast<const triangle*>(t));
    }

    bool _circle_quad_collision_func(const void* c, const void* q)
    {
        return circle_quad_intersect(*static_cast<const circle*>(c), *static_cast<const quad*>(q));
    }

    bool _triangle_sprite_collision_func(const void* t, const void* s)
    {
        return _sprite_triangle_collision_func(s, t);
    }

    bool _triangle_rectangle_collision_func(const void* t, const void* r)
    {
        return _rectangle_triangle_collision_func(r, t);
    }

    bool _triangle_circle_collision_func(const void* t, const void* c)
    {
        return _circle_triangle_collision_func(c, t);
    }

    bool _triangle_triangle_collision_func(const void* t1, const void* t2)
    {
        return triangles_intersect(*static_cast<const triangle*>(t1), *static_cast<const triangle*>(t2));
    }

    bool _triangle_quad_collision_func(const void* t, const void* q)
    {
        return triangle_quad_intersect(*static_cast<const triangle*>(t), *static_cast<const quad*>(q));
    }

    bool _quad_sprite_collision_func(const void* q, const void* s)
    {
        return _sprite_quad_collision_func(s, q);
    }

    bool _quad_rectangle_collision_func(const void* q, const void* r)
    {
        return _rectangle_quad_collision_func(r, q);
    }

    bool _quad_circle_collision_func(const void* q, const void* c)
    {
        return _circle_quad_collision_func(c, q);
    }

    bool _quad_triangle_collision_func(const void* q, const void* t)
    {
        return _triangle_quad_collision_func(t, q);
    }

    bool _quad_quad_collision_func(const void* q1, const void* q2)
    {
        return quads_intersect(*static_cast<const quad*>(q1), *static_cast<const quad*>(q2));
    }

    /** 
     * Moves the object back and forth with decreasing step size for
     * the given number of iterations.
    */ 
    bool _bracket_object_collision(bool colliding, int i, void* collider, const rectangle& collider_aabb,
                                        std::function<void(void*, const vector_2d& amount)> move_func,
                                                                _obj_movement_direction collider_direction)
    {
        if (colliding)
        {
            _move_object_by_direction_relative_to_size(collider, collider_aabb,
                                                        move_func, collider_direction,
                                                            1.0 / pow(ITERATION_POWER, static_cast<double>(i)));
        }
        else if (i == 1) // no collision in the first iteration
        {
            return false;
        }
        else
        {
            _move_object_by_direction_relative_to_size(collider, collider_aabb,
                                                        move_func, _opposite_direction(collider_direction),
                                                            1.0 / pow(ITERATION_POWER, static_cast<double>(i)));
        }
        return true;
    }

    bool _bracket_object_collision_generic(void* collider, std::function<bool(const void*, const void*)> collision_func,
                                            const void* collidee, const rectangle& collider_aabb,
                                            std::function<void(void*, const vector_2d& amount)> move_func,
                                            _obj_movement_direction collider_direction, int iterations)
    {
        for (int i = 1; i <= iterations; i++)
        {
            if (!_bracket_object_collision(collision_func(collider, collidee), i, collider,
                                                collider_aabb, move_func, collider_direction))
            {
                return false;
            }
        }
        return true;
    }

    bool _bracket_sprite_sprite_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _sprite_sprite_collision_func, collidee,
                                                sprite_collision_rectangle(*static_cast<const sprite*>(collider)),
                                                _move_sprite_by_vector, collider_direction, iterations);
    }

    bool _bracket_sprite_rectangle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _sprite_rectangle_collision_func, collidee,
                                                sprite_collision_rectangle(*static_cast<const sprite*>(collider)),
                                                _move_sprite_by_vector, collider_direction, iterations);
    }

    bool _bracket_sprite_circle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _sprite_circle_collision_func, collidee,
                                                sprite_collision_rectangle(*static_cast<const sprite*>(collider)),
                                                _move_sprite_by_vector, collider_direction, iterations);
    }

    bool _bracket_sprite_triangle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _sprite_triangle_collision_func, collidee,
                                                sprite_collision_rectangle(*static_cast<const sprite*>(collider)),
                                                _move_sprite_by_vector, collider_direction, iterations);
    }

    bool _bracket_sprite_quad_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _sprite_quad_collision_func, collidee,
                                                sprite_collision_rectangle(*static_cast<const sprite*>(collider)),
                                                _move_sprite_by_vector, collider_direction, iterations);
    }

    bool _bracket_rectangle_sprite_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _rectangle_sprite_collision_func, collidee,
                                                *static_cast<const rectangle*>(collider),
                                                _move_rectangle_by_vector, collider_direction, iterations);
    }

    bool _bracket_rectangle_rectangle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _rectangle_rectangle_collision_func, collidee,
                                                *static_cast<const rectangle*>(collider),
                                                _move_rectangle_by_vector, collider_direction, iterations);
    }

    bool _bracket_rectangle_circle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _rectangle_circle_collision_func, collidee,
                                                *static_cast<const rectangle*>(collider),
                                                _move_rectangle_by_vector, collider_direction, iterations);
    }

    bool _bracket_rectangle_triangle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _rectangle_triangle_collision_func, collidee,
                                                *static_cast<const rectangle*>(collider),
                                                _move_rectangle_by_vector, collider_direction, iterations);
    }

    bool _bracket_rectangle_quad_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _rectangle_quad_collision_func, collidee,
                                                *static_cast<const rectangle*>(collider),
                                                _move_rectangle_by_vector, collider_direction, iterations);
    }

    bool _bracket_circle_sprite_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _circle_sprite_collision_func, collidee,
                                                rectangle_around(*static_cast<const circle*>(collider)),
                                                _move_circle_by_vector, collider_direction, iterations);
    }

    bool _bracket_circle_rectangle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _circle_rectangle_collision_func, collidee,
                                                rectangle_around(*static_cast<const circle*>(collider)),
                                                _move_circle_by_vector, collider_direction, iterations);
    }

    bool _bracket_circle_circle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _circle_circle_collision_func, collidee,
                                                rectangle_around(*static_cast<const circle*>(collider)),
                                                _move_circle_by_vector, collider_direction, iterations);
    }

    bool _bracket_circle_triangle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _circle_triangle_collision_func, collidee,
                                                rectangle_around(*static_cast<const circle*>(collider)),
                                                _move_circle_by_vector, collider_direction, iterations);
    }

    bool _bracket_circle_quad_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _circle_quad_collision_func, collidee,
                                                rectangle_around(*static_cast<const circle*>(collider)),
                                                _move_circle_by_vector, collider_direction, iterations);
    }

    bool _bracket_triangle_sprite_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _triangle_sprite_collision_func, collidee,
                                                rectangle_around(*static_cast<const triangle*>(collider)),
                                                _move_triangle_by_vector, collider_direction, iterations);
    }

    bool _bracket_triangle_rectangle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _triangle_rectangle_collision_func, collidee,
                                                rectangle_around(*static_cast<const triangle*>(collider)),
                                                _move_triangle_by_vector, collider_direction, iterations);
    }

    bool _bracket_triangle_circle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _triangle_circle_collision_func, collidee,
                                                rectangle_around(*static_cast<const triangle*>(collider)),
                                                _move_triangle_by_vector, collider_direction, iterations);
    }

    bool _bracket_triangle_triangle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _triangle_triangle_collision_func, collidee,
                                                rectangle_around(*static_cast<const triangle*>(collider)),
                                                _move_triangle_by_vector, collider_direction, iterations);
    }

    bool _bracket_triangle_quad_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _triangle_quad_collision_func, collidee,
                                                rectangle_around(*static_cast<const triangle*>(collider)),
                                                _move_triangle_by_vector, collider_direction, iterations);
    }

    bool _bracket_quad_sprite_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _quad_sprite_collision_func, collidee,
                                                rectangle_around(*static_cast<const quad*>(collider)),
                                                _move_quad_by_vector, collider_direction, iterations);
    }

    bool _bracket_quad_rectangle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _quad_rectangle_collision_func, collidee,
                                                rectangle_around(*static_cast<const quad*>(collider)),
                                                _move_quad_by_vector, collider_direction, iterations);
    }

    bool _bracket_quad_circle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _quad_circle_collision_func, collidee,
                                                rectangle_around(*static_cast<const quad*>(collider)),
                                                _move_quad_by_vector, collider_direction, iterations);
    }

    bool _bracket_quad_triangle_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _quad_triangle_collision_func, collidee,
                                                rectangle_around(*static_cast<const quad*>(collider)),
                                                _move_quad_by_vector, collider_direction, iterations);
    }

    bool _bracket_quad_quad_collision(void* collider, const void* collidee,
                                      _obj_movement_direction collider_direction, int iterations)
    {
        return _bracket_object_collision_generic(collider, _quad_quad_collision_func, collidee,
                                                rectangle_around(*static_cast<const quad*>(collider)),
                                                _move_quad_by_vector, collider_direction, iterations);
    }

    collision_direction _compare_point_collision_depth_horizontal(const point_2d& collider, const point_2d& collidee)
    {
        if (collider.x < collidee.x)
        {
            return collision_direction::RIGHT;
        }
        return collision_direction::LEFT;
    }

    collision_direction _compare_point_collision_depth_vertical(const point_2d& collider, const point_2d& collidee)
    {
        if (collider.y < collidee.y)
        {
            return collision_direction::BOTTOM;
        }
        return collision_direction::TOP;
    }

    collision_direction _calculate_containing_collision_direction(const rectangle& collider, const rectangle& collidee)
    {
        // calculate the direction of the greatest distance between the two sprites
        point_2d collider_center = rectangle_center(collider);
        point_2d collidee_center = rectangle_center(collidee);
        double x_distance = collider_center.x - collidee_center.x;
        if (x_distance < 0.0)
        {
            x_distance *= -1;
        }

        double y_distance = collider_center.y - collidee_center.y;
        if (y_distance < 0.0)
        {
            y_distance *= -1;
        }

        if (x_distance < y_distance)
        {
            return _compare_point_collision_depth_horizontal(collider_center, collidee_center);
        }
        return _compare_point_collision_depth_vertical(collider_center, collidee_center);
    }

    collision_direction _rectangle_rectangle_collision_direction(const rectangle& collider, const rectangle& collidee)
    {
        vector<line> collider_lines = lines_from(collider);
        line collider_top_edge = collider_lines[0];
        line collider_left_edge = collider_lines[1];
        line collider_right_edge = collider_lines[2];
        line collider_bottom_edge = collider_lines[3];

        bool left_edge = line_intersects_rect(collider_left_edge, collidee);
        bool right_edge = line_intersects_rect(collider_right_edge, collidee);
        bool top_edge = line_intersects_rect(collider_top_edge, collidee);
        bool bottom_edge = line_intersects_rect(collider_bottom_edge, collidee);

        if (left_edge && right_edge && top_edge && bottom_edge) // collidee is equal size of collider
        {
            return _calculate_containing_collision_direction(collider, collidee);
        }
        if ((left_edge && right_edge && top_edge) || (top_edge && !(left_edge || right_edge || bottom_edge)))
        {
            return collision_direction::TOP;
        }
        if ((left_edge && right_edge && bottom_edge) || (bottom_edge && !(left_edge || right_edge || top_edge)))
        {
            return collision_direction::BOTTOM;
        }
        if ((top_edge && bottom_edge && right_edge) || (right_edge && !(left_edge || top_edge || bottom_edge)))
        {
            return collision_direction::RIGHT;
        }
        if ((top_edge && bottom_edge && left_edge) || (left_edge && !(right_edge || top_edge || bottom_edge)))
        {
            return collision_direction::LEFT;
        }
        if (left_edge && right_edge)
        {
            // check if the collider is more to the left or right of the collidee
            return _compare_point_collision_depth_horizontal(rectangle_center(collider), rectangle_center(collidee));
        }
        if (top_edge && bottom_edge)
        {
            // check if the collider is more to the top or bottom of the collidee
            return _compare_point_collision_depth_vertical(rectangle_center(collider), rectangle_center(collidee));
        }
        if (left_edge && top_edge)
        {
            return collision_direction::TOP_LEFT;
        }
        if (left_edge && bottom_edge)
        {
            return collision_direction::BOTTOM_LEFT;
        }
        if (right_edge && top_edge)
        {
            return collision_direction::TOP_RIGHT;
        }
        if (right_edge && bottom_edge)
        {
            return collision_direction::BOTTOM_RIGHT;
        }

        // collider contains collidee or collidee contains collider
        return _calculate_containing_collision_direction(collider, collidee);
    }

    collision_direction _calculate_object_collision_direction(const void* collider, const void* collidee,
                                                        const rectangle& collider_rect, const rectangle& collidee_rect,
                                                        std::function<bool(const void*, const void*)> collision_func)
    {
        if (!collision_func(collider, collidee))
        {
            return collision_direction::NONE;
        }

        return _rectangle_rectangle_collision_direction(collider_rect, collidee_rect);
    }

    void _resolve_object_AABB_collision(void* collider, const rectangle& collider_rect, const rectangle& collidee_rect,
                                collision_direction direction, std::function<void(void*, const vector_2d& amount)> move_func)
    {
        // get the intersection rectangle
        rectangle inter = intersection(collider_rect, collidee_rect);
        vector_2d amount = vector_to(inter.width, inter.height);

        _move_object_by_direction(collider, move_func, _direction_from_collision(direction), amount);
    }

    bool _resolve_object_collision(void* collider, const void* collidee, collision_test_kind collider_kind,
        collision_test_kind collidee_kind, const rectangle& collider_rect, const rectangle& collidee_rect,
            collision_direction direction, std::function<void(void*, const vector_2d& amount)> move_func,
                std::function<bool(const void*, const void*)> collision_func,
                    std::function<bool(void*, const void*, _obj_movement_direction, int)> bracket_func)
    {
        // check if the sprites are colliding
        if (direction == collision_direction::NONE || !collision_func(collider, collidee))
        {
            return false;
        }

        if (collider_kind == AABB_COLLISIONS && collidee_kind == AABB_COLLISIONS)
        {
            _resolve_object_AABB_collision(collider, collider_rect, collidee_rect, direction, move_func);
        }
        else // one or both of the sprites are using pixel collision
        {
            bracket_func(collider, collidee, _direction_from_collision(direction), BRACKET_ITERATIONS);
        }

        return true;
    }

    bool bitmap_point_collision(bitmap bmp, int cell, const matrix_2d& translation, const point_2d& pt )
    {
        if (INVALID_PTR(bmp, BITMAP_PTR))
        {
            return false;
        }

        if ( not point_in_quad(pt, quad_from(bitmap_cell_rectangle(bmp), translation)) )
        {
            return false;
        }

        return _step_through_pixels(1, 1, translation_matrix(pt.x, pt.y), bmp->cell_w, bmp->cell_h, translation, [&] (int ax, int ay, int bx, int by)
                                    {
#if DEBUG_STEP
                                        point_2d bpt;
                                        bpt = matrix_multiply(translation, point_at(bx,by));
                                        if ( pixel_drawn_at_point(bmp, cell, bx, by) )
                                            fill_rectangle(COLOR_PINK, bpt.x, bpt.y, translation.elements[0][0], translation.elements[1][1] );
#endif
                                        return pixel_drawn_at_point(bmp, cell, bx, by);
                                    });
    }

    bool bitmap_point_collision(bitmap bmp, const matrix_2d& translation, const point_2d& pt)
    {
        return bitmap_point_collision(bmp, 0, translation, pt);
    }

    bool bitmap_point_collision(bitmap bmp, const point_2d &bmp_pt, const point_2d& pt)
    {
        return bitmap_point_collision(bmp, translation_matrix(bmp_pt), pt);
    }

    bool bitmap_point_collision(bitmap bmp, double bmp_x, double bmp_y, double x, double y)
    {
        return bitmap_point_collision(bmp, 0, translation_matrix(bmp_x, bmp_y), point_at(x, y));
    }
    
    bool bitmap_point_collision(bitmap bmp, int cell, const point_2d &bmp_pt, const point_2d& pt)
    {
        return bitmap_point_collision(bmp, cell, translation_matrix(bmp_pt), pt);
    }
    
    bool bitmap_point_collision(bitmap bmp, int cell, double bmp_x, double bmp_y, double x, double y)
    {
        return bitmap_point_collision(bmp, cell, translation_matrix(bmp_x, bmp_y), point_at(x, y));
    }

    bool bitmap_rectangle_collision(bitmap bmp, int cell, const matrix_2d& translation, const rectangle& rect)
    {
        if (INVALID_PTR(bmp, BITMAP_PTR))
        {
            return false;
        }

        quad q1, q2;

        q1 = quad_from(bitmap_cell_rectangle(bmp), translation);
        q2 = quad_from(rect);

        if ( not quads_intersect(q1, q2) ) return false;

        return _step_through_pixels(rect.width, rect.height, translation_matrix(rect.x, rect.y), bmp->cell_w, bmp->cell_h, translation, [&] (int ax, int ay, int bx, int by)
                                    {
                                        return pixel_drawn_at_point(bmp, cell, bx, by);
                                    });
    }

    bool bitmap_rectangle_collision(bitmap bmp, int cell, const point_2d& pt, const rectangle& rect)
    {
        return bitmap_rectangle_collision(bmp, cell, translation_matrix(pt), rect);
    }
    
    bool bitmap_rectangle_collision(bitmap bmp, const point_2d& pt, const rectangle& rect)
    {
        return bitmap_rectangle_collision(bmp, 0, translation_matrix(pt), rect);
    }
    
    bool bitmap_rectangle_collision(bitmap bmp, double x, double y, const rectangle& rect)
    {
        return bitmap_rectangle_collision(bmp, 0, translation_matrix(x, y), rect);
    }
    
    bool bitmap_rectangle_collision(bitmap bmp, int cell, double x, double y, const rectangle& rect)
    {
        return bitmap_rectangle_collision(bmp, cell, translation_matrix(x, y), rect);
    }
    
    bool bitmap_circle_collision(bitmap bmp, int cell, const matrix_2d& translation, const circle& circ)
    {
        if (INVALID_PTR(bmp, BITMAP_PTR))
        {
            return false;
        }
        
        quad q1, q2;
        
        q1 = quad_from(bitmap_cell_rectangle(bmp), translation);
        rectangle rect = rectangle_around(circ);
        q2 = quad_from(rect);
        
        if ( not quads_intersect(q1, q2) ) return false;
        
        return _step_through_pixels(rect.width, rect.height, translation_matrix(rect.x, rect.y), bmp->cell_w, bmp->cell_h, translation, [&] (int ax, int ay, int bx, int by)
                                    {
                                        return pixel_drawn_at_point(bmp, cell, bx, by) && point_in_circle(point_at(rect.x + ax, rect.y + ay), circ);
                                    });
    }
    
    bool bitmap_circle_collision(bitmap bmp, int cell, const point_2d& pt, const circle& circ)
    {
        return bitmap_circle_collision(bmp, cell, translation_matrix(pt), circ);
    }

    bool bitmap_circle_collision(bitmap bmp, const point_2d& pt, const circle& circ)
    {
        return bitmap_circle_collision(bmp, 0, translation_matrix(pt), circ);
    }
    
    bool bitmap_circle_collision(bitmap bmp, double x, double y, const circle& circ)
    {
        return bitmap_circle_collision(bmp, 0, translation_matrix(x, y), circ);
    }
    
    bool bitmap_circle_collision(bitmap bmp, int cell, double x, double y, const circle& circ)
    {
        return bitmap_circle_collision(bmp, cell, translation_matrix(x, y), circ);
    }

    bool bitmap_triangle_collision(bitmap bmp, int cell, const matrix_2d &translation, const triangle &tri)
    {
        if (INVALID_PTR(bmp, BITMAP_PTR))
        {
            return false;
        }
        
        quad q1 = quad_from(bitmap_cell_rectangle(bmp), translation);
        rectangle rect = rectangle_around(tri);

        if (! triangle_quad_intersect(tri, q1))
        {
            return false;
        }
        
        return _step_through_pixels(rect.width, rect.height, translation_matrix(rect.x, rect.y), bmp->cell_w, bmp->cell_h, translation, [&] (int ax, int ay, int bx, int by)
                                    {
                                        return pixel_drawn_at_point(bmp, cell, bx, by) && point_in_triangle(point_at(rect.x + ax, rect.y + ay), tri);
                                    }); 
    }

    bool bitmap_triangle_collision(bitmap bmp, int cell, const point_2d& pt, const triangle &tri)
    {
        return bitmap_triangle_collision(bmp, cell, translation_matrix(pt), tri);
    }

    bool bitmap_triangle_collision(bitmap bmp, int cell, double x, double y, const triangle &tri)
    {
        return bitmap_triangle_collision(bmp, cell, translation_matrix(x, y), tri);
    }

    bool bitmap_triangle_collision(bitmap bmp, double x, double y, const triangle &tri)
    {
        return bitmap_triangle_collision(bmp, 0, translation_matrix(x, y), tri);
    }

    bool bitmap_triangle_collision(bitmap bmp, const point_2d& pt, const triangle &tri)
    {
        return bitmap_triangle_collision(bmp, 0, translation_matrix(pt), tri);
    }

    bool bitmap_quad_collision(bitmap bmp, int cell, const matrix_2d &translation, const quad &q)
    {
        if (INVALID_PTR(bmp, BITMAP_PTR))
        {
            return false;
        }
        
        quad q1 = quad_from(bitmap_cell_rectangle(bmp), translation);
        rectangle rect = rectangle_around(q);
        
        if ( not quads_intersect(q1, q) ) return false;
        
        return _step_through_pixels(rect.width, rect.height, translation_matrix(rect.x, rect.y), bmp->cell_w, bmp->cell_h, translation, [&] (int ax, int ay, int bx, int by)
                                    {
                                        return pixel_drawn_at_point(bmp, cell, bx, by) && point_in_quad(point_at(rect.x + ax, rect.y + ay), q);
                                    });
    }

    bool bitmap_quad_collision(bitmap bmp, int cell, const point_2d& pt, const quad &q)
    {
        return bitmap_quad_collision(bmp, cell, translation_matrix(pt), q);
    }

    bool bitmap_quad_collision(bitmap bmp, int cell, double x, double y, const quad &q)
    {
        return bitmap_quad_collision(bmp, cell, translation_matrix(x, y), q);
    }

    bool bitmap_quad_collision(bitmap bmp, double x, double y, const quad &q)
    {
        return bitmap_quad_collision(bmp, 0, translation_matrix(x, y), q);
    }

    bool bitmap_quad_collision(bitmap bmp, const point_2d& pt, const quad &q)
    {
        return bitmap_quad_collision(bmp, 0, translation_matrix(pt), q);
    }

    bool sprite_bitmap_collision(sprite s, bitmap bmp, int cell, double x, double y)
    {
        if (!rectangles_intersect(sprite_collision_rectangle(s), bitmap_cell_rectangle(bmp, point_at(x, y))))
        {
            return false;
        }

        if (sprite_collision_kind(s) == AABB_COLLISIONS)
        {
            return bitmap_rectangle_collision(bmp, cell, point_at(x, y), sprite_collision_rectangle(s));
        }

        return _collision_within_bitmap_images_with_translation(
                    sprite_collision_bitmap(s), sprite_current_cell(s),
                    sprite_location_matrix(s),
                    bmp,
                    cell,
                    translation_matrix(x, y));
    }

    bool sprite_bitmap_collision(sprite s, bitmap bmp, int cell, const point_2d &pt)
    {
        return sprite_bitmap_collision(s, bmp, cell, pt.x, pt.y);
    }

    bool sprite_bitmap_collision(sprite s, bitmap bmp, double x, double y)
    {
        return sprite_bitmap_collision(s, bmp, 0, x, y);
    }
    
    bool sprite_point_collision(sprite s, const point_2d &pt)
    {
        if (!point_in_circle(pt, sprite_collision_circle(s)))
        {
            return false;
        }
        else if (bitmap_cell_count(sprite_collision_bitmap(s)) > 1)
        {
            return bitmap_point_collision(sprite_collision_bitmap(s), sprite_current_cell(s), sprite_location_matrix(s), pt);
        }
        else
        {
            return bitmap_point_collision(sprite_collision_bitmap(s), sprite_location_matrix(s), pt);
        }
    }
    
    bool sprite_rectangle_collision(sprite s, const rectangle& rect)
    {
        if (!rectangles_intersect(sprite_collision_rectangle(s), rect))
        {
            return false;
        }
        
        return bitmap_rectangle_collision(sprite_collision_bitmap(s), sprite_current_cell(s), sprite_location_matrix(s), rect);
    }

    bool sprite_circle_collision(sprite s, const circle &c)
    {
        if (!circles_intersect(sprite_collision_circle(s), c))
        {
            return false;
        }
        
        return bitmap_circle_collision(sprite_collision_bitmap(s), sprite_current_cell(s), sprite_location_matrix(s), c);
    }

    bool sprite_triangle_collision(sprite s, const triangle &t)
    {
        if (!triangle_rectangle_intersect(t, sprite_collision_rectangle(s)))
        {
            return false;
        }
        
        return bitmap_triangle_collision(sprite_collision_bitmap(s), sprite_current_cell(s), sprite_location_matrix(s), t);
    }

    bool sprite_quad_collision(sprite s, const quad &q)
    {
        if (!rectangles_intersect(sprite_collision_rectangle(s), rectangle_around(q)))
        {
            return false;
        }
        
        return bitmap_quad_collision(sprite_collision_bitmap(s), sprite_current_cell(s), sprite_location_matrix(s), q);
    }
    
    bool sprite_collision(sprite s1, sprite s2)
    {
        if (!rectangles_intersect(sprite_collision_rectangle(s1), sprite_collision_rectangle(s2)))
        {
            return false;
        }
        
        if (sprite_collision_kind(s1) == AABB_COLLISIONS)
        {
            return sprite_rectangle_collision(s2, sprite_collision_rectangle(s1));
        }
        
        if (sprite_collision_kind(s2) == AABB_COLLISIONS)
        {
            return sprite_rectangle_collision(s1, sprite_collision_rectangle(s2));
        }
        
        return _collision_within_bitmap_images_with_translation (
                                                                 sprite_collision_bitmap(s1), sprite_current_cell(s1), sprite_location_matrix(s1),
                                                                 sprite_collision_bitmap(s2), sprite_current_cell(s2), sprite_location_matrix(s2) );
    }

    bool bitmap_collision(bitmap bmp1, int cell1, const matrix_2d &matrix1, bitmap bmp2, int cell2, const matrix_2d &matrix2)
    {
        quad q1 = quad_from(bitmap_cell_rectangle(bmp1), matrix1);
        quad q2 = quad_from(bitmap_cell_rectangle(bmp2), matrix2);

        if ( not quads_intersect(q1, q2) )
        {
            return false;
        }

        return _collision_within_bitmap_images_with_translation(bmp1, cell1, matrix1,
                                                                bmp2, cell2, matrix2);
    }

    bool bitmap_collision(bitmap bmp1, int cell1, const point_2d &pt1, bitmap bmp2, int cell2, const point_2d &pt2)
    {
        return bitmap_collision(bmp1, cell1, translation_matrix(pt1), bmp2, cell2, translation_matrix(pt2));
    }

    bool bitmap_collision(bitmap bmp1, int cell1, double x1, double y1, bitmap bmp2, int cell2, double x2, double y2)
    {
        return bitmap_collision(bmp1, cell1, translation_matrix(x1, y1), bmp2, cell2, translation_matrix(x2, y2));
    }

    bool bitmap_collision(bitmap bmp1, const point_2d &pt1, bitmap bmp2, const point_2d &pt2)
    {
        return bitmap_collision(bmp1, 0, pt1.x, pt1.y, bmp2, 0, pt2.x, pt2.y);
    }

    bool bitmap_collision(bitmap bmp1, double x1, double y1, bitmap bmp2, double x2, double y2)
    {
        return bitmap_collision(bmp1, 0, translation_matrix(x1, y1), bmp2, 0, translation_matrix(x2, y2));
    }

    collision_direction calculate_collision_direction(const sprite collider, const sprite collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, sprite_collision_rectangle(collider),
                                                    sprite_collision_rectangle(collidee), _sprite_sprite_collision_func);
    }

    collision_direction calculate_collision_direction(const sprite collider, const rectangle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, sprite_collision_rectangle(collider),
                                                        collidee, _sprite_rectangle_collision_func);
    }

    collision_direction calculate_collision_direction(const sprite collider, const circle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, sprite_collision_rectangle(collider),
                                                        rectangle_around(collidee), _sprite_circle_collision_func);
    }

    collision_direction calculate_collision_direction(const sprite collider, const triangle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, sprite_collision_rectangle(collider),
                                                        rectangle_around(collidee), _sprite_triangle_collision_func);
    }

    collision_direction calculate_collision_direction(const sprite collider, const quad& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, sprite_collision_rectangle(collider),
                                                        rectangle_around(collidee), _sprite_quad_collision_func);
    }

    collision_direction calculate_collision_direction(const rectangle& collider, const sprite collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, collider,
                                                        sprite_collision_rectangle(collidee), _rectangle_sprite_collision_func);
    }

    collision_direction calculate_collision_direction(const rectangle& collider, const rectangle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, collider, collidee, _rectangle_rectangle_collision_func);
    }

    collision_direction calculate_collision_direction(const rectangle& collider, const circle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, collider,
                                                        rectangle_around(collidee), _rectangle_circle_collision_func);
    }

    collision_direction calculate_collision_direction(const rectangle& collider, const triangle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, collider,
                                                        rectangle_around(collidee), _rectangle_triangle_collision_func);
    }

    collision_direction calculate_collision_direction(const rectangle& collider, const quad& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, collider,
                                                        rectangle_around(collidee), _rectangle_quad_collision_func);
    }

    collision_direction calculate_collision_direction(const circle& collider, const sprite collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        sprite_collision_rectangle(collidee), _circle_sprite_collision_func);
    }

    collision_direction calculate_collision_direction(const circle& collider, const rectangle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        collidee, _circle_rectangle_collision_func);
    }

    collision_direction calculate_collision_direction(const circle& collider, const circle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        rectangle_around(collidee), _circle_circle_collision_func);
    }

    collision_direction calculate_collision_direction(const circle& collider, const triangle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        rectangle_around(collidee), _circle_triangle_collision_func);
    }

    collision_direction calculate_collision_direction(const circle& collider, const quad& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        rectangle_around(collidee), _circle_quad_collision_func);
    }

    collision_direction calculate_collision_direction(const triangle& collider, const sprite collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        sprite_collision_rectangle(collidee), _triangle_sprite_collision_func);
    }

    collision_direction calculate_collision_direction(const triangle& collider, const rectangle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        collidee, _triangle_rectangle_collision_func);
    }

    collision_direction calculate_collision_direction(const triangle& collider, const circle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        rectangle_around(collidee), _triangle_circle_collision_func);
    }

    collision_direction calculate_collision_direction(const triangle& collider, const triangle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        rectangle_around(collidee), _triangle_triangle_collision_func);
    }

    collision_direction calculate_collision_direction(const triangle& collider, const quad& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        rectangle_around(collidee), _triangle_quad_collision_func);
    }

    collision_direction calculate_collision_direction(const quad& collider, const sprite collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        sprite_collision_rectangle(collidee), _quad_sprite_collision_func);
    }

    collision_direction calculate_collision_direction(const quad& collider, const rectangle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        collidee, _quad_rectangle_collision_func);
    }

    collision_direction calculate_collision_direction(const quad& collider, const circle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        rectangle_around(collidee), _quad_circle_collision_func);
    }

    collision_direction calculate_collision_direction(const quad& collider, const triangle& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        rectangle_around(collidee), _quad_triangle_collision_func);
    }

    collision_direction calculate_collision_direction(const quad& collider, const quad& collidee)
    {
        return _calculate_object_collision_direction(&collider, &collidee, rectangle_around(collider),
                                                        rectangle_around(collidee), _quad_quad_collision_func);
    }

    bool resolve_collision(sprite collider, const sprite collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, sprite_collision_kind(collider),
            sprite_collision_kind(collidee), sprite_collision_rectangle(collider),
                sprite_collision_rectangle(collidee), direction, _move_sprite_by_vector,
                    _sprite_sprite_collision_func, _bracket_sprite_sprite_collision);
    }

    bool resolve_collision(sprite collider, const rectangle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, sprite_collision_kind(collider),
            AABB_COLLISIONS, sprite_collision_rectangle(collider),
                collidee, direction, _move_sprite_by_vector,
                    _sprite_rectangle_collision_func, _bracket_sprite_rectangle_collision);
    }

    bool resolve_collision(sprite collider, const circle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, sprite_collision_kind(collider),
            AABB_COLLISIONS, sprite_collision_rectangle(collider),
                rectangle_around(collidee), direction, _move_sprite_by_vector,
                    _sprite_circle_collision_func, _bracket_sprite_circle_collision);
    }

    bool resolve_collision(sprite collider, const triangle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, sprite_collision_kind(collider),
            AABB_COLLISIONS, sprite_collision_rectangle(collider),
                rectangle_around(collidee), direction, _move_sprite_by_vector,
                    _sprite_triangle_collision_func, _bracket_sprite_triangle_collision);
    }

    bool resolve_collision(sprite collider, const quad& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, sprite_collision_kind(collider),
            AABB_COLLISIONS, sprite_collision_rectangle(collider),
                rectangle_around(collidee), direction, _move_sprite_by_vector,
                    _sprite_quad_collision_func, _bracket_sprite_quad_collision);
    }

    bool resolve_collision(rectangle& collider, const sprite collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, AABB_COLLISIONS,
            sprite_collision_kind(collidee), collider,
                sprite_collision_rectangle(collidee), direction, _move_rectangle_by_vector,
                    _rectangle_sprite_collision_func, _bracket_rectangle_sprite_collision);
    }

    bool resolve_collision(rectangle& collider, const rectangle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, AABB_COLLISIONS,
            AABB_COLLISIONS, collider, collidee, direction, _move_rectangle_by_vector,
                _rectangle_rectangle_collision_func, _bracket_rectangle_rectangle_collision);
    }

    bool resolve_collision(rectangle& collider, const circle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, AABB_COLLISIONS,
            PIXEL_COLLISIONS, collider, rectangle_around(collidee), direction, _move_rectangle_by_vector,
                _rectangle_circle_collision_func, _bracket_rectangle_circle_collision);
    }

    bool resolve_collision(rectangle& collider, const triangle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, AABB_COLLISIONS,
            PIXEL_COLLISIONS, collider, rectangle_around(collidee), direction, _move_rectangle_by_vector,
                _rectangle_triangle_collision_func, _bracket_rectangle_triangle_collision);
    }

    bool resolve_collision(rectangle& collider, const quad& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, AABB_COLLISIONS,
            PIXEL_COLLISIONS, collider, rectangle_around(collidee), direction, _move_rectangle_by_vector,
                _rectangle_quad_collision_func, _bracket_rectangle_quad_collision);
    }

    bool resolve_collision(circle& collider, const sprite collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            sprite_collision_kind(collidee), rectangle_around(collider),
                sprite_collision_rectangle(collidee), direction, _move_circle_by_vector,
                    _circle_sprite_collision_func, _bracket_circle_sprite_collision);
    }

    bool resolve_collision(circle& collider, const rectangle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            AABB_COLLISIONS, rectangle_around(collider),
                collidee, direction, _move_circle_by_vector,
                    _circle_rectangle_collision_func, _bracket_circle_rectangle_collision);
    }

    bool resolve_collision(circle& collider, const circle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            PIXEL_COLLISIONS, rectangle_around(collider),
                rectangle_around(collidee), direction, _move_circle_by_vector,
                    _circle_circle_collision_func, _bracket_circle_circle_collision);
    }

    bool resolve_collision(circle& collider, const triangle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            PIXEL_COLLISIONS, rectangle_around(collider),
                rectangle_around(collidee), direction, _move_circle_by_vector,
                    _circle_triangle_collision_func, _bracket_circle_triangle_collision);
    }

    bool resolve_collision(circle& collider, const quad& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            PIXEL_COLLISIONS, rectangle_around(collider),
                rectangle_around(collidee), direction, _move_circle_by_vector,
                    _circle_quad_collision_func, _bracket_circle_quad_collision);
    }

    bool resolve_collision(triangle& collider, const sprite collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            sprite_collision_kind(collidee), rectangle_around(collider),
                sprite_collision_rectangle(collidee), direction, _move_triangle_by_vector,
                    _triangle_sprite_collision_func, _bracket_triangle_sprite_collision);
    }

    bool resolve_collision(triangle& collider, const rectangle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            AABB_COLLISIONS, rectangle_around(collider),
                collidee, direction, _move_triangle_by_vector,
                    _triangle_rectangle_collision_func, _bracket_triangle_rectangle_collision);
    }

    bool resolve_collision(triangle& collider, const circle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            PIXEL_COLLISIONS, rectangle_around(collider),
                rectangle_around(collidee), direction, _move_triangle_by_vector,
                    _triangle_circle_collision_func, _bracket_triangle_circle_collision);
    }

    bool resolve_collision(triangle& collider, const triangle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            PIXEL_COLLISIONS, rectangle_around(collider),
                rectangle_around(collidee), direction, _move_triangle_by_vector,
                    _triangle_triangle_collision_func, _bracket_triangle_triangle_collision);
    }

    bool resolve_collision(triangle& collider, const quad& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            PIXEL_COLLISIONS, rectangle_around(collider),
                rectangle_around(collidee), direction, _move_triangle_by_vector,
                    _triangle_quad_collision_func, _bracket_triangle_quad_collision);
    }

    bool resolve_collision(quad& collider, const sprite collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            sprite_collision_kind(collidee), rectangle_around(collider),
                sprite_collision_rectangle(collidee), direction, _move_quad_by_vector,
                    _quad_sprite_collision_func, _bracket_quad_sprite_collision);
    }

    bool resolve_collision(quad& collider, const rectangle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            AABB_COLLISIONS, rectangle_around(collider),
                collidee, direction, _move_quad_by_vector,
                    _quad_rectangle_collision_func, _bracket_quad_rectangle_collision);
    }

    bool resolve_collision(quad& collider, const circle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            PIXEL_COLLISIONS, rectangle_around(collider),
                rectangle_around(collidee), direction, _move_quad_by_vector,
                    _quad_circle_collision_func, _bracket_quad_circle_collision);
    }

    bool resolve_collision(quad& collider, const triangle& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            PIXEL_COLLISIONS, rectangle_around(collider),
                rectangle_around(collidee), direction, _move_quad_by_vector,
                    _quad_triangle_collision_func, _bracket_quad_triangle_collision);
    }

    bool resolve_collision(quad& collider, const quad& collidee, collision_direction direction)
    {
        return _resolve_object_collision(&collider, &collidee, PIXEL_COLLISIONS,
            PIXEL_COLLISIONS, rectangle_around(collider),
                rectangle_around(collidee), direction, _move_quad_by_vector,
                    _quad_quad_collision_func, _bracket_quad_quad_collision);
    }
}
