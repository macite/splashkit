//
//  point_geometry.cpp
//  splashkit
//
//  Created by Andrew Cain on 19/08/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#include "point_geometry.h"

#include "random.h"
#include "graphics.h"
#include "vector_2d.h"

#include "geometry.h"

#include "utility_functions.h"

#include <cmath>

using std::to_string;

// Used in checking point similarities
#define SMALL 1.4
namespace splashkit_lib
{
    point_2d point_at(double x, double y)
    {
        point_2d result;
        result.x = x;
        result.y = y;
        return result;
    }

    point_2d point_at_origin()
    {
        return point_at(0, 0);
    }

    point_2d point_offset_by(const point_2d &start_point, const vector_2d &offset)
    {
        return point_at(start_point.x + offset.x, start_point.y + offset.y);
    }

    point_2d point_offset_from_origin(const vector_2d &offset)
    {
        return point_offset_by(point_at_origin(), offset);
    }

    string point_to_string(const point_2d &pt)
    {
        return "Pt @" + to_string(pt.x) + ":" + to_string(pt.y);
    }

    point_2d random_screen_point()
    {
        return random_window_point(current_window());
    }

    point_2d random_window_point(window wind)
    {
        point_2d result;
        result.x = rnd() * screen_width();
        result.y = rnd() * screen_height();
        return result;
    }

    point_2d random_bitmap_point(bitmap bmp)
    {
        point_2d result;
        result.x = rnd() * bitmap_width(bmp);
        result.y = rnd() * bitmap_height(bmp);
        return result;
    }

    bool point_in_triangle(const point_2d &pt, const triangle &tri)
    {
        vector_2d v0, v1, v2;
        vector_2d a, b, c, p;
        double dot00, dot01, dot02, dot11, dot12;
        double inv_denom, u, v;

        //Convert Points to vectors
        p = vector_to(pt);
        a = vector_to(tri.points[0]);
        b = vector_to(tri.points[1]);
        c = vector_to(tri.points[2]);

        // Compute vectors
        v0 = vector_subtract(c, a);
        v1 = vector_subtract(b, a);
        v2 = vector_subtract(p, a);

        // Compute dot products
        dot00 = dot_product(v0, v0);
        dot01 = dot_product(v0, v1);
        dot02 = dot_product(v0, v2);
        dot11 = dot_product(v1, v1);
        dot12 = dot_product(v1, v2);

        // Compute barycentric coordinates
        if (dot00 * dot11 - dot01 * dot01 == 0.0)
            return false;

        inv_denom = 1.0 / (dot00 * dot11 - dot01 * dot01);
        u = (dot11 * dot02 - dot01 * dot12) * inv_denom;
        v = (dot00 * dot12 - dot01 * dot02) * inv_denom;

        // Check if point is in triangle
        return ((u > 0.0) and (v > 0.0) and (u + v < 1.0));
    }

    bool point_in_rectangle(const point_2d &pt, const rectangle &rect)
    {
        if (pt.x < rectangle_left(rect)) return false;
        else if (pt.x > rectangle_right(rect)) return false;
        else if (pt.y < rectangle_top(rect)) return false;
        else if (pt.y > rectangle_bottom(rect)) return false;
        else return true;
    }

    bool point_in_rectangle(double ptx, double pty, double rect_x, double rect_y, double rect_width, double rect_height)
    {
        return point_in_rectangle(point_at(ptx, pty), rectangle_from(rect_x, rect_y, rect_width, rect_height));
    }

    bool point_in_quad(const point_2d &pt, const quad &q)
    {
        return
        point_in_triangle(pt, triangle_from(q.points[0], q.points[1], q.points[2])) or
        point_in_triangle(pt, triangle_from(q.points[3], q.points[1], q.points[2]));
    }

    bool same_point(const point_2d &pt1, const point_2d &pt2)
    {
        return static_cast<int>(pt1.x) == static_cast<int>(pt2.x) and static_cast<int>(pt1.y) == static_cast<int>(pt2.y);
    }

    bool point_in_circle(const point_2d &pt, const circle &c)
    {
        return point_point_distance(c.center, pt) <= abs((long long)c.radius);
    }

    bool point_in_circle(double ptx, double pty, double cx, double cy, double radius)
    {
        return point_in_circle(point_at(ptx, pty), circle_at(cx, cy, radius));
    }

    bool point_on_line(const point_2d &pt, const line &l)
    {
        return point_on_line(pt, l, SMALL);
    }

    bool point_on_line(const point_2d &pt, const line &l, float proximity)
    {
        auto simple_comparison_x_same = [&] ()
        {
            float min_y, max_y;

            min_y = MIN(l.start_point.y, l.end_point.y);
            max_y = MAX(l.start_point.y, l.end_point.y);

            return (pt.x >= l.start_point.x - proximity) and (pt.x <= l.start_point.x + proximity) and (pt.y >= min_y) and (pt.y <= max_y);
        };

        auto simple_comparison_y_same = [&] ()
        {
            float min_x, max_x;

            min_x = MIN(l.start_point.x, l.end_point.x);
            max_x = MAX(l.start_point.x, l.end_point.x);

            return (pt.y >= l.start_point.y - proximity) and (pt.y <= l.start_point.y + proximity) and (pt.x >= min_x) and (pt.x <= max_x);
        };

        float sq_line_mag, lx, ly, m, c;

        //Lines Magnitude must be at least 0.0001
        sq_line_mag = line_length_squared(l);
        if (sq_line_mag < 1.0)
        {
            return same_point(pt, l.start_point) or same_point(pt, l.end_point);
        }

        //Obtain the other variables for the Line Algorithm
        if ( l.end_point.x == l.start_point.x )
        {
            return simple_comparison_x_same();
        }
        if ( l.end_point.y == l.start_point.y)
        {
            return simple_comparison_y_same();
        }

        m = (l.end_point.y - l.start_point.y) / (l.end_point.x - l.start_point.x);
        c = l.start_point.y - (m * l.start_point.x);

        ly = (m * pt.x) + c;
        lx = (pt.y - c) / m;

        return (lx >= pt.x - proximity) and
        (lx <= pt.x + proximity) and
        (ly >= pt.y - proximity) and
        (ly <= pt.y + proximity) and
        point_in_rectangle(pt, rectangle_around(l));
    }

    /**
     *  Returns the angle between two points in degrees.
     */
    float point_point_angle(const point_2d &pt1, const point_2d &pt2)
    {
        float o, a, oa, rads, result;

        if ((pt1.x == pt2.x) and (pt2.y < pt1.y)) return -90;
        else if ((pt1.x == pt2.x) and (pt2.y >= pt1.y)) return 90;
        else if ((pt1.y == pt2.y) and (pt2.x < pt1.x)) return 180;
        else if ((pt1.y == pt2.y) and (pt2.x >= pt1.x)) return 0;
        else
        {
            o = (pt2.y - pt1.y);
            a = (pt2.x - pt1.x);
            oa = o / a;
            rads = atan(oa);
            result = rad_to_deg(rads);
            
            if(pt2.x < pt1.x)
            {
                if (pt2.y < pt1.y) result = result - 180;
                else result = result + 180;
            }
            
            return result;
        }
    }
    
    /**
     *  Returns the distance between two points.
     */
    float point_point_distance(const point_2d &pt1, const point_2d &pt2)
    {
        vector_2d temp = vector_point_to_point(pt1, pt2);
        return vector_magnitude(temp);
    }

    float point_line_distance(const point_2d &pt, const line &l)
    {
        return point_point_distance(pt, closest_point_on_line(pt, l));
    }
    
}
