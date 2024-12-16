//
//  rectangle_geometry.cpp
//  splashkit
//
//  Created by Jacob Milligan on 19/08/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

// Include class header
#include "rectangle_geometry.h"
#include "utility_functions.h"

#include <sstream>
#include <cmath>

using std::ostringstream;

namespace splashkit_lib
{
    rectangle rectangle_from(double x, double y, double width, double height)
    {
        rectangle result;
        result.x = x;
        result.y = y;
        result.width = width;
        result.height = height;

        return result;
    }

    rectangle rectangle_from(const point_2d pt1, const point_2d pt2)
    {
        rectangle result;
        result.x = pt1.x;
        result.y = pt1.y;
        result.width = ceil(pt2.x - pt1.x);
        result.height = ceil(pt2.y - pt1.y);
        return result;
    }

    rectangle rectangle_from(const point_2d pt, const double width, const double height)
    {
        return rectangle_from(pt.x, pt.y, width, height);
    }

    rectangle rectangle_offset_by(const rectangle &rect, const vector_2d &offset)
    {
        rectangle result = rect;
        result.x += offset.x;
        result.y += offset.y;
        return result;
    }

    point_2d rectangle_center(const rectangle &rect)
    {
        point_2d result;
        result.x = rect.x + (rect.width / 2);
        result.y = rect.y + (rect.height / 2);
        return result;
    }

    rectangle rectangle_around(const line &l)
    {
        rectangle result;
        result.x = MIN(l.start_point.x, l.end_point.x);
        result.y = MIN(l.start_point.y, l.end_point.y);
        result.width = ceil(MAX(l.start_point.x, l.end_point.x) - result.x);
        result.height = ceil(MAX(l.start_point.y, l.end_point.y) - result.y);
        return result;
    }

    rectangle rectangle_around(const quad &q)
    {
        rectangle result;

        float minX = q.points[0].x, maxX = q.points[0].x;
        float minY = q.points[0].y, maxY = q.points[0].y;

        for ( int i = 1; i < 4; i++ )
        {
            minX = MIN(q.points[i].x, minX);
            maxX = MAX(q.points[i].x, maxX);
            minY = MIN(q.points[i].y, minY);
            maxY = MAX(q.points[i].y, maxY);
        }

        result.x = minX;
        result.y = minY;
        result.width = ceil(maxX - minX);
        result.height = ceil(maxY - minY);

        return result;
    }

    rectangle rectangle_around(const circle &c)
    {
        rectangle result;
        result.x = c.center.x - c.radius;
        result.y = c.center.y - c.radius;
        result.width = ceil(2 * c.radius);
        result.height = result.width;
        return result;
    }

    rectangle rectangle_around(const triangle &t)
    {
        rectangle result;

        float minX = t.points[0].x, maxX = t.points[0].x;
        float minY = t.points[0].y, maxY = t.points[0].y;

        for ( int i = 1; i < 3; i++ ) {

            if ( t.points[i].x < minX ) {
                minX = t.points[i].x;
            } else if ( t.points[i].x > maxX ) {
                maxX = t.points[i].x;
            }

            if ( t.points[i].y < minY ) {
                minY = t.points[i].y;
            } else if ( t.points[i].y > maxY ) {
                maxY = t.points[i].y;
            }

        }

        result.x = minX;
        result.y = minY;
        result.width = ceil(maxX - minX);
        result.height = ceil(maxY - minY);

        return result;
    }

    string rectangle_to_string(const rectangle &rect)
    {
        ostringstream result;

        result << "Rect @" << rect.x << "," << rect.y << " " << rect.width << "x" << rect.height;

        return result.str();
    }

    rectangle intersection(const rectangle &rect1, const rectangle &rect2)
    {
        float r, l, b, t;

        b = MIN(rectangle_bottom(rect1), rectangle_bottom(rect2));
        t = MAX(rectangle_top(rect1), rectangle_top(rect2));
        r = MIN(rectangle_right(rect1), rectangle_right(rect2));
        l = MAX(rectangle_left(rect1), rectangle_left(rect2));

        if ((r < l) or (b < t))
            return rectangle_from(0, 0, 0, 0);
        else
            return rectangle_from(l, t, r - l, b - t);
    }

    bool rectangles_intersect(const rectangle& rect1, const rectangle& rect2)
    {
        rectangle intersect = intersection(rect1, rect2);

        return (abs((long long)intersect.width) + abs((long long)intersect.height)) != 0;
    }

    float rectangle_top(const rectangle &rect)
    {
        if ( rect.height >= 0) return rect.y;
        else return rect.y + rect.height;
    }
    
    float rectangle_bottom(const rectangle &rect)
    {
        if ( rect.height >= 0) return rect.y + rect.height;
        else return rect.y;
    }
    
    float rectangle_left(const rectangle &rect)
    {
        if ( rect.width >= 0) return rect.x;
        else return rect.x + rect.width;
    }
    
    float rectangle_right(const rectangle &rect)
    {
        if ( rect.width >= 0) return rect.x + rect.width;
        else return rect.x;
    }

    rectangle fix_rectangle(const rectangle &rect)
    {
        rectangle result = rect;

        if ( rect.width < 0 )
        {
            result.width = -result.width;
            result.x -= result.width;
        }

        if ( rect.height < 0 )
        {
            result.height = -result.height;
            result.y -= result.height;
        }

        return result;
    }

    rectangle inset_rectangle(const rectangle &rect, float inset_amount)
    {
        rectangle result = fix_rectangle(rect);

        float dbl_amt = 2 * inset_amount;

        if ( result.width <= dbl_amt or result.height <= dbl_amt)
            return result;

        result.x = result.x + inset_amount;
        result.y = result.y + inset_amount;
        result.width = result.width - dbl_amt;
        result.height = result.height - dbl_amt;

        return result;
    }

    bool rectangle_ray_intersection(const point_2d &origin, const vector_2d &heading, const rectangle &rect)
    {
        point_2d hit_point;
        double hit_distance;
        return rectangle_ray_intersection(origin, heading, rect, hit_point, hit_distance);
    }

    bool rectangle_ray_intersection(const point_2d &origin, const vector_2d &heading, const rectangle &rect, point_2d &hit_point, double &hit_distance)
    {
        vector_2d unit_heading = unit_vector(heading);
        
        // check whether unit heading is a zero vector
        if (vector_magnitude_squared(unit_heading) < __DBL_EPSILON__)
        {
            return false;
        }
        
        if (point_in_rectangle(origin, rect))
        {
            hit_point = origin;
            hit_distance = 0.0;
            return true;
        }

        // Compute the inverse of the ray direction (for faster calculations)
        vector_2d inv_dir = vector_to(1.0 / unit_heading.x, 1.0 / unit_heading.y);

        // Calculate entry and exit distances for the rectangle's x and y boundaries
        double entry_distance_x = (rect.x - origin.x) * inv_dir.x;
        double exit_distance_x = (rect.x + rect.width - origin.x) * inv_dir.x;

        double entry_distance_y = (rect.y - origin.y) * inv_dir.y;
        double exit_distance_y = (rect.y + rect.height - origin.y) * inv_dir.y;

        // Determine the nearest entry point and the farthest exit point
        double min_intersection_distance = std::max(std::min(entry_distance_x, exit_distance_x), std::min(entry_distance_y, exit_distance_y));
        double max_intersection_distance = std::min(std::max(entry_distance_x, exit_distance_x), std::max(entry_distance_y, exit_distance_y));

        // If the ray misses the rectangle or the intersection is behind the ray's origin
        if (min_intersection_distance > max_intersection_distance || max_intersection_distance < 0.0)
        {
            return false;
        }

        // Compute the point of intersection
        hit_distance = min_intersection_distance;
        vector_2d hit_vector = vector_multiply(unit_heading, min_intersection_distance);
        hit_point = point_at(origin.x + hit_vector.x, origin.y + hit_vector.y);

        return true;
    }
}
