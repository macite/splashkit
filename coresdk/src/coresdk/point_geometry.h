/**
 * @header point_geometry
 * @author Andrew Cain
 * @attribute group  geometry
 * @attribute static geometry
 */

#ifndef point_geometry_h
#define point_geometry_h

#include "types.h"
#include "window_manager.h"
#include "images.h"

namespace splashkit_lib
{
    /**
     * Returns a point at the given location.
     *
     * @param  x The x value of the coordinate
     * @param  y The y value of the coordinate
     * @returns   A point at the given location
     */
    point_2d point_at(double x, double y);

    /**
     *  Returns a point representing the origin.
     *
     * @returns   A point with x and y set to 0
     */
    point_2d point_at_origin();

    /**
     *  Calculate the `point_2d` that is offset from the `start_point` by the
     *  `offset`
     *
     * @param  start_point The starting point
     * @param  offset      The distance and direction to move
     * @return             A new point as a result of moving by the offset from
     *                     the starting point
     */
    point_2d point_offset_by(const point_2d &start_point, const vector_2d &offset);

    /**
     *  Returns the point offset from the origin by the provided vector.
     *
     * @param  offset The distance and direction to move
     * @return        A new point as a result of moving by the offset from
     *                the starting point
     */
    point_2d point_offset_from_origin(const vector_2d &offset);

    /**
     *  Get a text description of the `point_2d`.
     *
     * @param  pt The point details
     * @return    A string representation of the point
     */
    string point_to_string(const point_2d &pt);

    /**
     *  Returns a random point on the current window.
     *
     * @return A point within the bounds of the current window
     */
    point_2d random_screen_point();

    /**
     *  Returns a random point on the provided window.
     *
     * @param  wind The window
     * @return      A point within the bounds of the window
     */
    point_2d random_window_point(window wind);

    /**
     *  Returns a random point within the bounds of the bitmap.
     *
     * @param  bmp The bitmap
     * @return     A point within the bounds of the bitmap
     */
    point_2d random_bitmap_point(bitmap bmp);

    /**
     *  Returns true if the point `pt` is in the Triangle `tri`.
     *
     * @param  pt  The point to test
     * @param  tri The triangle to check
     * @return     True if the point is within the triangle
     */
    bool point_in_triangle(const point_2d &pt, const triangle &tri);

    /**
     *  Returns true if point `pt` is in the Rectangle `rect`.
     *
     * @param  pt   The point to test
     * @param  rect The rectangle to check
     * @return      True if the point is within the rectangle
     */
    bool point_in_rectangle(const point_2d &pt, const rectangle &rect);

    /**
     * Returns true if the point is within the bounds of a Rectangle.
     * 
     * @param ptx the x value of the point
     * @param pty the y value of the point
     * @param rect_x x value of the rectangle
     * @param rect_y y value of the rectangle
     * @param rect_width width of the rectangle
     * @param rect_height height of the rectangle
     * @returns true when the point is in the rectangle, otherwise it returns false.
     *
     * @attribute suffix  with_values
     */
    bool point_in_rectangle(double ptx, double pty, double rect_x, double rect_y, double rect_width, double rect_height);

    /**
     *  Tests if a point is in a quad.
     *
     * @param pt    The point to test.
     * @param q     The quad to check if the point is within.
     * @returns      True if pt lies within the area of q.
     */
    bool point_in_quad(const point_2d &pt, const quad &q);

    /**
     *  Returns true if the point `pt` is in the circle `c`.
     *
     * @param  pt The point to test
     * @param  c  The circle to check
     * @return    True if the point is within the area of the circle
     */
    bool point_in_circle(const point_2d &pt, const circle &c);

    /**
     * Return true if the point is in the circle.
     * 
     * @param ptx the x value of the point
     * @param pty the y value of the point
     * @param cx the x value of the centre of the circle
     * @param cy the y value of the centre of the circle
     * @param radius the radius of the circle
     * @returns True when the point is in the circle, otherwise it returns false.
     * 
     * @attribute suffix  with_values
     */
    bool point_in_circle(double ptx, double pty, double cx, double cy, double radius);

    /**
     *  Returns true if point `pt` is on the line `l`.
     *
     * @param  pt The point to test
     * @param  l  The line to check
     * @return    True if the point is on the line
     */
    bool point_on_line(const point_2d &pt, const line &l);

    /**
     * Returns true when the point `pt` is on the line `l`. The
     * proximity value is used to set the sensitivity -- higher values
     * effectively make the line thicker.
     *
     * @param  pt The point to test
     * @param  l  The line to check
     * @param  proximity The sensitivity to allow close approximities
     * @return    True if the point is on the line
     *
     * @attribute suffix  with_proximity
     */
    bool point_on_line(const point_2d &pt, const line &l, float proximity);

    /**
     *  Returns True of `pt1` is at the same point as `pt2`. This checks at an
     *  integer level, indicating the two points refer to the same pixel.
     *
     * @param  pt1 The first point
     * @param  pt2 The other point
     * @return     True if the two points are at the same location
     */
    bool same_point(const point_2d &pt1, const point_2d &pt2);

    /**
     *  Returns the angle between two points in degrees.
     *
     * @param  pt1 The first point
     * @param  pt2 The other point
     * @return     The angle (in degrees) of the line between the points
     */
    float point_point_angle(const point_2d &pt1, const point_2d &pt2);

    /**
     *  Returns the distance between two points.
     *
     * @param  pt1 The first point
     * @param  pt2 The other point
     * @return     The distance between the two points
     */
    double point_point_distance(const point_2d &pt1, const point_2d &pt2);

    /**
     * Returns the distance from a point to a line.
     *
     * @param  pt The point
     * @param  l  The line
     * @return    The distance from `pt` to `l`
     */
    float point_line_distance(const point_2d &pt, const line &l);
}
#endif /* point_geometry_h */
