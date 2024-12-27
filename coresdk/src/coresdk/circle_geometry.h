/**
 * @header circle_geometry
 * @author Andrew Cain
 * @attribute group  geometry
 * @attribute static geometry
 */

#ifndef circle_geometry_hpp
#define circle_geometry_hpp

#include "types.h"
namespace splashkit_lib
{
    /**
     * Returns a circle at the indicated point and radius.
     *
     * @param  pt     The location of the center of the circle
     * @param  radius The radius of the circle
     * @return        A circle at the indicatd point and radius
     */
    circle circle_at(const point_2d &pt, double radius);

    /**
     * Returns a circle at the indicated point and radius.
     *
     * @param  x      The x location of the circle
     * @param  y      The y location of the circle
     * @param  radius The radius of the circle
     * @return        A circle at the indicatd point and radius
     *
     * @attribute suffix from_points
     */
    circle circle_at(double x, double y, double radius);

    /**
     * Detects if two circles intersect. This can be used to detect collisions between
     * bounding circles.
     *
     * @param c1    The circle to test if intersects with c2
     * @param c2    The circle to test if intersects with c1
     * @returns     True if the two circles do intersect
     */
    bool circles_intersect(circle c1, circle c2);

    /**
     * Detects if two circles intersect. This can be used to detect collisions between
     * bounding circles. The circle data is passed in as individual values.
     * 
     * @param c1_x the x location of the first circle
     * @param c1_y the y location of the first circle
     * @param c1_radius the radius of the first circle
     * @param c2_x the x location of the second circle
     * @param c2_y the y location of the second circle
     * @param c2_radius the radius of the second circle
     * @return true when the two circles intersect
     *
     * @attribute suffix using_values
     */
    bool circles_intersect(double c1_x, double c1_y, double c1_radius, double c2_x, double c2_y, double c2_radius);

    /**
     * Detects if a circle intersects with a triangle.
     * 
     * @param c The circle to test
     * @param tri The triangle to test
     * @returns True if the circle and triangle intersect
     */
    bool circle_triangle_intersect(const circle &c, const triangle &tri);

    /**
     * Detects if a circle intersects with a triangle. The closest point on the
     * triangle to the circle is assigned to p, even if the circle and triangle do not
     * intersect. If the centre of the circle is inside the triangle,
     * the point assigned to p is the centre of the circle.
     * 
     * @param c The circle to test
     * @param tri The triangle to test
     * @param p The point to set to the closest point on the triangle to the circle
     * @returns True if the circle and triangle intersect
     *
     * @attribute suffix get_closest_point
     */
    bool circle_triangle_intersect(const circle &c, const triangle &tri, point_2d &p);

    /**
     * Calculates the closest point on a triangle to a circle. If the circle and
     * triangle do not intersect, the closest point on the triangle to the circle
     * is returned. If the circle and triangle do intersect, the center of the
     * circle is returned.
     *
     * @param c   The circle to test
     * @param tri The triangle to test
     * @returns   The closest point on the triangle to the circle
     */
    point_2d closest_point_on_triangle_from_circle(const circle &c, const triangle &tri);

    /**
     *  Returns the center point of the circle.
     *
     * @param c   The circle to get the center point
     * @returns   The center point of the circle
     */
    point_2d center_point(const circle &c);

    /**
     * Calculates the two points on a circles radius that lie along the given
     * vector. This represents the points on the circle when the vector is
     * placed at the circle's center point.
     *
     * @param c     The circle
     * @param along The vector representing the line along which the points lie.
     * @param pt1   After the call, this is set to one of the widest points
     * @param pt2   After the call, this is set to one of the widest points
     */
    void widest_points(const circle &c, const vector_2d &along, point_2d &pt1, point_2d &pt2);

    /**
     * Determines the opposite side of a circle given a collision point and a
     * heading.
     *
     * @param  pt          The point from which the test is being made
     * @param  c           The circle
     * @param  heading     The direction the point is heading
     * @param  opposite_pt After the call, this is set to the point on the
     *                     opposite side of the circle from pt when it is
     *                     heading in the given direction.
     * @return             True when the `opposite_pt` is calculated, false when
     *                     the point would not collide with the circle when
     *                     heading as indicated.
     */
    bool distant_point_on_circle_heading(const point_2d &pt, const circle &c, const vector_2d &heading, point_2d &opposite_pt);

    /**
     * The furthest point on the circle to the given point.
     *
     * @param  pt      The point to test from
     * @param  c       The circle you want to get a point on its circumference
     * @return         The point on c that is furthest from `pt`
     */
    point_2d distant_point_on_circle(const point_2d &pt, const circle &c);

    /**
     * Calculates the distance from a ray cast from a point to a given circle.
     *
     * @param  ray_origin  The origin of the ray
     * @param  ray_heading The direction of the ray
     * @param  c           The circle being tested
     * @return             -1 if the ray does not hit the circle, otherwise the
     *                     distance from the origin to the circle bounds.
     */
    float ray_circle_intersect_distance(const point_2d &ray_origin, const vector_2d &ray_heading, const circle &c);

    /**
     *  Returns the circle radius.
     *
     * @param  c The circle
     * @return   The radius of the circle
     */
    float circle_radius(const circle c);

    /**
     *  Returns the circle x value.
     *
     * @param  c The circle
     * @return   The x location of the center of the circle
     */
    float circle_x(const circle &c);

    /**
     *  Returns the circle y value.
     *
     * @param  c The circle
     * @return   The y location of the center of the circle
     */
    float circle_y(const circle &c);

    /**
     * Returns the closest point on a circle's circumference to
     * a given point. If the point is equal to the center of the circle,
     * the center point is returned.
     *
     * @param  from_pt The point to test from
     * @param  c       The circle
     * @return         The point on `c`'s circumference that is closest to
     *                      `from_point`, or the center of the circle if the
     *                      point equals `c`'s center. 
     */
    point_2d closest_point_on_circle(const point_2d &from_pt, const circle &c);

    /**
     * Returns the closest point on a line to a circle.
     *
     * @param  c The circle
     * @param  l The line
     * @return   The point that is closest to `c` on `l`
     */
    point_2d closest_point_on_line_from_circle(const circle &c, const line &l);

    /**
     * Returns the closest point on a rectangle's perimeter to a circle.
     *
     * @param  c The circle
     * @param  rect The rectangle
     * @return   The point that is closest to `c` on `rect`'s perimeter
     */
    point_2d closest_point_on_rect_from_circle(const circle &c, const rectangle &rect);

    /**
     * Returns the two tangent points on the circle given the indicated point.
     *
     * @param  from_pt The source point
     * @param  c       The circle
     * @param  p1      If this returns true, then `p1` contains one of the points
     * @param  p2      If this returns true, then `p2` contains one of the points
     * @return         True if `from_pt` is outside of the circle, and tangent
     *                      points are calculated
     */
    bool tangent_points(const point_2d &from_pt, const circle &c, point_2d &p1, point_2d &p2);

}
#endif /* circle_geometry_hpp */
