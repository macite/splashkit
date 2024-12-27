//
//  quad_geometry.cpp
//  splashkit
//
//  Created by Andrew Cain on 23/08/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#include "geometry.h"
#include "matrix_2d.h"
#include "vector_2d.h"

namespace splashkit_lib
{
    quad quad_from(double x_top_left, double y_top_left,
                   double x_top_right, double y_top_right,
                   double x_bottom_left, double y_bottom_left,
                   double x_bottom_right, double y_bottom_right)
    {
        quad result;
        result.points[0].x = x_top_left;
        result.points[0].y = y_top_left;
        result.points[1].x = x_top_right;
        result.points[1].y = y_top_right;
        result.points[2].x = x_bottom_left;
        result.points[2].y = y_bottom_left;
        result.points[3].x = x_bottom_right;
        result.points[3].y = y_bottom_right;
        return result;
    }

    quad quad_from(const rectangle &rect)
    {
        quad result;
        result = quad_from(
                           rectangle_left(rect), rectangle_top(rect),
                           rectangle_right(rect), rectangle_top(rect),
                           rectangle_left(rect), rectangle_bottom(rect),
                           rectangle_right(rect), rectangle_bottom(rect) );
        return result;
    }

    quad quad_from(const point_2d &p1, const point_2d &p2, const point_2d &p3, const point_2d &p4)
    {
        quad result;

        result.points[0] = p1;
        result.points[1] = p2;
        result.points[2] = p3;
        result.points[3] = p4;

        return result;
    }

    quad quad_from(const rectangle &rect, const matrix_2d &transform)
    {
        quad result = quad_from(rect);
        apply_matrix(transform, result);
        return result;
    }

    void set_quad_point(quad &q, int idx, const point_2d &value)
    {
        if (idx >= 0 && idx <= 3)
        {
            q.points[idx] = value;
        }
    }

    vector<triangle> triangles_from(const quad &q)
    {
        vector<triangle> result;

        result.push_back(triangle_from(q.points[0], q.points[1], q.points[2]));
        result.push_back(triangle_from(q.points[2], q.points[3], q.points[1]));

        return result;
    }

    bool quads_intersect(const quad &q1, const quad &q2)
    {
        vector<triangle> q1_triangles = triangles_from(q1);
        vector<triangle> q2_triangles = triangles_from(q2);

        for (triangle t1 : q1_triangles)
        {
            for (triangle t2 : q2_triangles)
            {
                if ( triangles_intersect(t1, t2) )
                {
                    return true;
                }
            }
        }

        return false;
    }

}
