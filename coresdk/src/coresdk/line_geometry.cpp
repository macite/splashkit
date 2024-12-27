//
//  line_geometry.cpp
//  splashkit
//
//  Created by Andrew Cain on 20/08/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#include "line_geometry.h"
#include "point_geometry.h"
#include "utility_functions.h"

#include <cmath>

namespace splashkit_lib
{
    line line_from(const point_2d &start, const point_2d &end_pt)
    {
        return {start, end_pt};
    }

    line line_from(double x1, double y1, double x2, double y2)
    {
        return line_from(point_at(x1, y1), point_at(x2, y2));
    }

    line line_from(const point_2d &start, const vector_2d &offset)
    {
        return line_from(start, point_offset_by(start, offset) );
    }

    float line_length_squared(const line &l)
    {
        return (l.end_point.x - l.start_point.x) * (l.end_point.x - l.start_point.x) +
        (l.end_point.y - l.start_point.y) * (l.end_point.y - l.start_point.y);
    }

    line line_from(const vector_2d &v)
    {
        return { {0,0}, {static_cast<float>(v.x), static_cast<float>(v.y)} };
    }

    bool line_intersection_point(const line &line1, const line &line2, point_2d &pt)
    {
        // convert lines to the eqn
        // c = ax + by
        float a1, b1, c1;
        float a2, b2, c2;
        float det;

        pt.x = 0;
        pt.y = 0;

        //Convert lines to eqn c = ax + by
        a1 = line1.end_point.y - line1.start_point.y; //y12 - y11;
        b1 = line1.start_point.x - line1.end_point.x; //x11 - x12;
        c1 = a1 * line1.start_point.x + b1 * line1.start_point.y; //a1 * x11 + b1 * y11;

        a2 = line2.end_point.y - line2.start_point.y; //y22 - y21;
        b2 = line2.start_point.x - line2.end_point.x; //x21 - x22;
        c2 = a2 * line2.start_point.x + b2 * line2.start_point.y; //a2 * x21 + b2 * y21;

        det = (a1 * b2) - (a2 * b1);

        if (det == 0)
            return false;
        else
        {
            pt.x = (b2*c1 - b1*c2) / det;
            pt.y = (a1*c2 - a2*c1) / det;
            return true;
        }
    }

    point_2d closest_point_on_line(const point_2d from_pt, const line &l)
    {
        float sq_line_mag, u;

        // see Paul Bourke's original article(s)
        // square of line's magnitude (see note in function LineMagnitude)
        sq_line_mag = line_length_squared(l);
        if ( sq_line_mag < EPSEPS)
        {
            LOG(WARNING) << "Cannot determine intersection point on line, line is too short";
            return point_at(0,0);
        }

        u = ( (from_pt.x - l.start_point.x)*(l.end_point.x - l.start_point.x) + (from_pt.y - l.start_point.y) * (l.end_point.y - l.start_point.y) ) / sq_line_mag;

        if ((u < EPS) or (u > 1))
        {
            //  Closest point does not fall within the line segment,
            //    take the shorter distance to an endpoint
            if (line_length_squared(line_from(from_pt.x, from_pt.y, l.start_point.x, l.start_point.y)) < line_length_squared(line_from(from_pt.x, from_pt.y, l.end_point.x, l.end_point.y)))
                return l.start_point;
            else
                return l.end_point;
        } //  if (u < EPS) or (u > 1)
        else
        {
            //  Intersecting point is on the line, use the formula
            return point_at(
                            l.start_point.x + u * (l.end_point.x - l.start_point.x),
                            l.start_point.y + u * (l.end_point.y - l.start_point.y));
            
        } //  else NOT (u < EPS) or (u > 1)
    }

    point_2d closest_point_on_lines(const point_2d from_pt, const vector<line> &lines, int &line_idx)
    {
        line_idx = -1;
        point_2d result = point_at_origin();

        if (lines.size() < 1) return result;

        float min_dist = std::numeric_limits<float>::max(), dst;
        point_2d pt;

        for (int i = 0; i < lines.size(); i++)
        {
            pt = closest_point_on_line(from_pt, lines[i]);
            dst = point_point_distance(pt, from_pt);

            if (min_dist > dst)
            {
                line_idx = i;
                min_dist = dst;
                result = pt;
            }
        }
        return result;
    }

    vector<line> lines_from(const triangle &t)
    {
        vector<line> result;

        result.push_back(line_from(t.points[0], t.points[1]));
        result.push_back(line_from(t.points[1], t.points[2]));
        result.push_back(line_from(t.points[2], t.points[0]));

        return result;
    }

    vector<line> lines_from(const rectangle &rect)
    {
        vector<line> result;
        result.push_back(line_from(rect.x, rect.y, rect.x + rect.width, rect.y));
        result.push_back(line_from(rect.x, rect.y, rect.x, rect.y + rect.height));
        result.push_back(line_from(rect.x + rect.width, rect.y, rect.x + rect.width, rect.y + rect.height));
        result.push_back(line_from(rect.x, rect.y + rect.height, rect.x + rect.width, rect.y + rect.height));
        return result;
    }

    float line_length(const line &l)
    {
        return sqrt(line_length_squared(l));
    }

    bool lines_intersect(const line &l1, const line &l2)
    {
        if ( line_length(l1) == 0 || line_length(l2) == 0 ) return false;

        point_2d pt;
        return line_intersection_point(l1, l2, pt) and point_on_line(pt, l1) and point_on_line(pt, l2);
    }

    bool line_intersects_circle(const line &l, const circle &c)
    {
        point_2d pt = closest_point_on_line_from_circle(c, l);
        return point_in_circle(pt, c);
    }

    bool line_intersects_rect(const line &l, const rectangle &rect)
    {
        // if the line is completely within the rectangle, then it intersects
        if (point_in_rectangle(l.start_point, rect) && point_in_rectangle(l.end_point, rect))
        {
            return true;
        }
        
        return line_intersects_lines(l, lines_from(rect));
    }

    point_2d line_mid_point(const line &l)
    {
        point_2d result;
        result.x = l.start_point.x + (l.end_point.x - l.start_point.x) / 2;
        result.y = l.start_point.y + (l.end_point.y - l.start_point.y) / 2;
        return result;
    }

    vector_2d line_normal(const line &l)
    {
        return vector_normal(vector_from_line(l));
    }

    string line_to_string(const line &ln)
    {
        return "Line from " + point_to_string(ln.start_point) + " to " + point_to_string(ln.end_point);
    }

    bool line_intersects_lines(const line &l, const vector<line> &lines)
    {
        int i;
        point_2d pt;

        for (i = 0; i < lines.size(); i++)
        {
            if ( line_intersection_point(l, lines[i], pt) and point_on_line(pt, lines[i]) and point_on_line(pt, l))
            {
                return true;
            }
        }
        return false;
    }
}
