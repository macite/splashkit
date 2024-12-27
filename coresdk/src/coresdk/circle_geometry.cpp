//
//  circle_geometry.cpp
//  splashkit
//
//  Created by Andrew Cain on 22/08/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#include "circle_geometry.h"

#include "geometry.h"
#include "vector_2d.h"
#include "line_geometry.h"

#include <cmath>

using std::abs;

namespace splashkit_lib
{
    circle circle_at(const point_2d &pt, double radius)
    {
        circle result;
        result.center = pt;
        result.radius = radius;
        return result;
    }

    circle circle_at(double x, double y, double radius)
    {
        return circle_at(point_at(x, y), radius);
    }

    point_2d center_point(const circle &c)
    {
        return c.center;
    }

    void widest_points(const circle &c, const vector_2d &along, point_2d &pt1, point_2d &pt2)
    {
        pt1 = point_offset_by(c.center, vector_multiply(unit_vector(along), c.radius));
        pt2 = point_offset_by(c.center, vector_multiply(unit_vector(along), -c.radius));
    }

    point_2d distant_point_on_circle(const point_2d &pt, const circle &c)
    {
        return point_offset_by(c.center, vector_multiply(unit_vector(vector_point_to_point(c.center, pt)), -c.radius));
    }

    bool distant_point_on_circle_heading(const point_2d &pt, const circle &c, const vector_2d &heading, point_2d &opposite_pt)
    {
        float dist, dot_prod;
        point_2d pt_on_circle, chk_pt;
        vector_2d to_center, head;

        head = unit_vector(heading);

        //Move pt back 2 * radius to ensure it is outside of the circle...
        //  but still on same alignment
        chk_pt = point_offset_by(pt, vector_multiply(vector_invert(head), 2 * c.radius));
        //DrawCircle(ColorBlue, chk_pt, 1);

        dist = ray_circle_intersect_distance(chk_pt, head, c);
        if (dist < 0) return false;

        // Get point on circle by moving from chk_pt dist distance in heading direction
        pt_on_circle = point_offset_by(chk_pt, vector_multiply(head, dist));
        //DrawLine(ColorMagenta, chk_pt, pt_on_circle);
        //DrawCircle(ColorMagenta, pt_on_circle, 2);

        //Project the ray to the other side of the circle
        to_center = vector_point_to_point(pt_on_circle, c.center);
        dot_prod = dot_product(to_center, head);
        //WriteLn(dot_prod:4:2);

        opposite_pt = point_offset_by(pt_on_circle, vector_multiply(head, 2 * dot_prod));
        //FillCircle(ColorRed, oppositePt, 2);
        return true;
    }

    float ray_circle_intersect_distance(const point_2d &ray_origin, const vector_2d &ray_heading, const circle &c)
    {
        vector_2d to_circle, unit_heading;
        float length, v, d;

        unit_heading = unit_vector(ray_heading);
        to_circle = vector_point_to_point(ray_origin, c.center);
        length = vector_magnitude(to_circle);

        v = dot_product(to_circle, unit_heading);
        d = c.radius*c.radius - (length*length - v*v);

        if (d < 0.0)
            // if there was no intersection, return -1
            return -1.0;
        else
            // return the distance to the (first) intersection point
            return (v - sqrt(d));
    }

    bool circles_intersect(circle c1, circle c2)
    {
        return point_point_distance(c1.center, c2.center) < c1.radius + c2.radius;
    }

    bool circles_intersect(double c1_x, double c1_y, double c1_radius, double c2_x, double c2_y, double c2_radius)
    {
        return point_point_distance(point_at(c1_x, c1_y), point_at(c2_x, c2_y)) < c1_radius + c2_radius;
    }

    bool circle_triangle_intersect(const circle &c, const triangle &tri)
    {
        point_2d p;
        return circle_triangle_intersect(c, tri, p);
    }

    bool circle_triangle_intersect(const circle &c, const triangle &tri, point_2d &p)
    {
        // Check if the sphere center is inside the triangle
        if (point_in_triangle(c.center, tri))
        {
            p = c.center;
            return true;
        }

        int idx;
        // Find the closest point on the triangle to the sphere center
        p = closest_point_on_lines(c.center, lines_from(tri), idx);

        // Circle and triangle intersect if the squared distance from circle
        // center to point p is less than the squared circle radius
        return vector_magnitude_squared(vector_point_to_point(c.center, p)) < c.radius * c.radius;
    }

    point_2d closest_point_on_triangle_from_circle(const circle &c, const triangle &tri)
    {
        point_2d p;
        circle_triangle_intersect(c, tri, p);
        return p;
    }

    float circle_radius(const circle c)
    {
        return c.radius;
    }

    float circle_x(const circle &c)
    {
        return c.center.x;
    }

    float circle_y(const circle &c)
    {
        return c.center.y;
    }

    point_2d closest_point_on_circle(const point_2d &from_pt, const circle &c)
    {
        return point_offset_by(c.center, vector_multiply(unit_vector(vector_point_to_point(c.center, from_pt)), c.radius));
    }

    point_2d closest_point_on_line_from_circle(const circle &c, const line &l)
    {
        return closest_point_on_line(c.center, l);
    }

    point_2d closest_point_on_rect_from_circle(const circle &c, const rectangle &rect)
    {
        int idx;
        return closest_point_on_lines(c.center, lines_from(rect), idx);
    }

    bool tangent_points(const point_2d &from_pt, const circle &c, point_2d &p1, point_2d &p2)
    {
        vector_2d pm_c = vector_point_to_point(c.center, from_pt);

        double sqr_len = vector_magnitude_squared(pm_c);
        double r_sqr = c.radius * c.radius;

        // Quick check for P inside the circle, return False if so
        if ( sqr_len <= r_sqr or sqr_len == 0 )
            return false; // tangent objects are not returned.

        // time to work out the real tangent points then
        double inv_sqr_len = 1.0 / sqr_len;
        double root = sqrt(abs(sqr_len - r_sqr));

        p1.x = c.center.x + c.radius * (c.radius * pm_c.x - pm_c.y * root) * inv_sqr_len;
        p1.y = c.center.y + c.radius * (c.radius * pm_c.y + pm_c.x * root) * inv_sqr_len;
        p2.x = c.center.x + c.radius * (c.radius * pm_c.x + pm_c.y * root) * inv_sqr_len;
        p2.y = c.center.y + c.radius * (c.radius * pm_c.y - pm_c.x * root) * inv_sqr_len;

        return true;
    }
}
