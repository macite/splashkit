/**
 * @header triangle_geometry
 * @author Andrew Cain
 * @attribute group  geometry
 * @attribute static geometry
 */

#ifndef triangle_geometry_h
#define triangle_geometry_h

#include "types.h"

namespace splashkit_lib
{
    /**
     * Generate a triangle from a set of points.
     *
     * @param  x1 The x coordinate for the first point
     * @param  y1 The y coordinate for the first point
     * @param  x2 The x coordinate for the second point
     * @param  y2 The y coordinate for the second point
     * @param  x3 The x coordinate for the third point
     * @param  y3 The y coordinate for the third point
     * @return    A triangle at the indicated points
     *
     * @attribute suffix  _from_coordinates
     */
    triangle triangle_from(double x1, double y1, double x2, double y2, double x3, double y3);

    /**
     * Generate a triangle from a set of points.
     *
     * @param  p1 The first point of the triangle
     * @param  p2 The second point of the triangle
     * @param  p3 The third point of the triangle
     * @return    A triangle with the indicated points
     */
    triangle triangle_from(const point_2d &p1, const point_2d &p2, const point_2d &p3);

    /**
     * Returns true if the triangle intersects with the rectangle.
     *
     * @param  tri  The triangle to test
     * @param  rect The rectangle to test
     * @return      True if the triangle and rect intersect
     */
    bool triangle_rectangle_intersect(const triangle &tri, const rectangle &rect);

    /**
     * Detects if a ray intersects a triangle.
     * 
     * @param origin        The starting point of the ray
     * @param heading       The direction of the ray as a vector
     * @param tri           The triangle to check for intersection
     * @returns             True if the ray intersects the triangle, false otherwise
     */
    bool triangle_ray_intersection(const point_2d &origin, const vector_2d &heading, const triangle &tri);

    /**
     * Detects if a ray intersects a triangle. If an intersection is found, the
     * `hit_point` and `hit_distance` are set to the point of intersection and the
     * distance from the ray's origin to the intersection point. If the ray's `origin`
     * is contained within the triangle, `hit_point` is set to the `origin` and `hit_distance`
     * is set to 0. If no intersection is found, `hit_point` and `hit_distance` are not modified.
     * 
     * @param origin        The starting point of the ray
     * @param heading       The direction of the ray as a vector
     * @param tri           The triangle to check for intersection
     * @param hit_point     The point to set to where the ray intersects the triangle
     * @param hit_distance  The double to set to the distance from the ray's origin to
     *                      the intersection point
     * @returns             True if the ray intersects the triangle, false otherwise
     * 
     * @attribute suffix    with_hit_point_and_distance
     */
    bool triangle_ray_intersection(const point_2d &origin, const vector_2d &heading, const triangle &tri, point_2d &hit_point, double &hit_distance);

    /**
     * Returns true if the two triangles intersect.
     *
     * @param  t1 The first triangle
     * @param  t2 The other triangle
     * @return    True if the two triangles intersect
     */
    bool triangles_intersect(const triangle &t1, const triangle &t2);

    /**
     * Return the barycenter of the triangle. This is one way of calculating the
     * center point of a triangle.
     *
     * @param  tri The triangle to get the center of
     * @return     The point that is the barycenter of `tri`
     */
    point_2d triangle_barycenter(const triangle  &tri);

    /**
     * Returns a text description of the triangle.
     *
     * @param  tri The triangle
     * @return     A text description of the triangle.
     */
    string triangle_to_string(const triangle  &tri);
}

#endif /* triangle_geometry_h */
