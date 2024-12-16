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

constexpr double RAY_QUAD_LINE_THICKNESS = 1.0;

using std::function;

namespace splashkit_lib
{
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

    bool bitmap_quad_collision(bitmap bmp, int cell, const matrix_2d &translation, const quad& q)
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

    bool bitmap_ray_collision(bitmap bmp, int cell, const matrix_2d& translation, const point_2d& origin, const vector_2d& heading)
    {
        if (INVALID_PTR(bmp, BITMAP_PTR))
        {
            return false;
        }
        
        point_2d bmp_position = matrix_multiply(translation, point_at(0.0, 0.0));
        point_2d bmp_center = point_offset_by(bmp_position, vector_to(bitmap_center(bmp)));
        circle bmp_bounding_circle = bitmap_bounding_circle(bmp, bmp_center);

        vector_2d unit_ray_heading = unit_vector(heading);

        // get point which will allow segment to fully pass through the bitmap
        double distance_to_center = vector_magnitude(vector_point_to_point(origin, bmp_center));
        point_2d ray_end = point_offset_by(origin, vector_multiply(unit_ray_heading, distance_to_center + bmp_bounding_circle.radius));

        quad ray_quad = quad_from(origin, ray_end, RAY_QUAD_LINE_THICKNESS);
        return bitmap_quad_collision(bmp, cell, translation, ray_quad);
    }

    bool bitmap_ray_collision(bitmap bmp, int cell, const point_2d& pt, const point_2d& origin, const vector_2d& heading)
    {
        return bitmap_ray_collision(bmp, cell, translation_matrix(pt), origin, heading);
    }

    bool bitmap_ray_collision(bitmap bmp, int cell, double x, double y, const point_2d& origin, const vector_2d& heading)
    {
        return bitmap_ray_collision(bmp, cell, translation_matrix(x, y), origin, heading);
    }

    bool bitmap_ray_collision(bitmap bmp, double x, double y, const point_2d& origin, const vector_2d& heading)
    {
        return bitmap_ray_collision(bmp, 0, translation_matrix(x, y), origin, heading);
    }

    bool bitmap_ray_collision(bitmap bmp, const point_2d& pt, const point_2d& origin, const vector_2d& heading)
    {
        return bitmap_ray_collision(bmp, 0, translation_matrix(pt), origin, heading);
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

    bool sprite_ray_collision(sprite s, const point_2d& origin, const vector_2d& heading)
    {
        return bitmap_ray_collision(sprite_collision_bitmap(s), sprite_current_cell(s), sprite_location_matrix(s), origin, heading);
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

}
