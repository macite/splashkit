/**
 * Geometry Unit Tests
 */

#include "catch.hpp"

#include "types.h"
#include "point_geometry.h"

using namespace splashkit_lib;

constexpr double EPSILON = 1.0E-13;

TEST_CASE("can correctly perform point geometry", "[geometry]")
{
    SECTION("can create a point")
    {
        point_2d pt = point_at(100.0, 200.0);
        REQUIRE(pt.x == 100.0);
        REQUIRE(pt.y == 200.0);
        pt = point_at(__DBL_MAX__, -__DBL_MAX__);
        REQUIRE(pt.x == __DBL_MAX__);
        REQUIRE(pt.y == -__DBL_MAX__);
    }
    SECTION("can create a point at the origin")
    {
        point_2d pt = point_at_origin();
        REQUIRE(pt.x == 0.0);
        REQUIRE(pt.y == 0.0);
    }
    SECTION("can offset a point")
    {
        point_2d pt = point_at(100.0, 200.0);
        vector_2d offset = vector_to(50.0, 50.0);
        point_2d new_pt = point_offset_by(pt, offset);
        REQUIRE(new_pt.x == 150.0);
        REQUIRE(new_pt.y == 250.0);
    }
    SECTION("can offset a point from origin")
    {
        vector_2d offset = vector_to(50.0, 50.0);
        point_2d new_pt = point_offset_from_origin(offset);
        REQUIRE(new_pt.x == 50.0);
        REQUIRE(new_pt.y == 50.0);
    }
    SECTION("can convert point to string")
    {
        point_2d pt = point_at(100.0, 200.0);
        REQUIRE(point_to_string(pt) == "Pt @100.000000:200.000000");
    }
    SECTION("can retrieve random point in bitmap")
    {
        bitmap bmp = load_bitmap("rocket", "rocket_sprt.png");
        REQUIRE(bmp != nullptr);
        REQUIRE(bitmap_valid(bmp));
        point_2d pt = random_bitmap_point(bmp);
        REQUIRE(pt.x >= 0.0);
        REQUIRE(pt.y >= 0.0);
        REQUIRE(pt.x < bitmap_width(bmp));
        REQUIRE(pt.y < bitmap_height(bmp));
    }
    SECTION("can calculate point-point distance")
    {
        REQUIRE(point_point_distance(point_at(0.0, 0.0), point_at(0.0, 0.0)) == 0.0);
        REQUIRE(point_point_distance(point_at(100.0, 100.0), point_at(100.0, 100.0)) == 0.0);
        REQUIRE(point_point_distance(point_at(100.0, 100.0), point_at(200.0, 100.0)) == 100.0);
        REQUIRE(point_point_distance(point_at(100.0, 100.0), point_at(100.0, 200.0)) == 100.0);
        REQUIRE(point_point_distance(point_at(100.0, 100.0), point_at(200.0, 200.0)) == 100.0 * sqrtf(2.0f));
    }
    SECTION("can detect point in rectangle")
    {
        rectangle rect = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(point_in_rectangle(point_at(100.0, 100.0), rect));
        REQUIRE(point_in_rectangle(point_at(300.0, 300.0), rect));
        REQUIRE(point_in_rectangle(100.0, 300.0, 100.0, 100.0, 200.0, 200.0));
        REQUIRE_FALSE(point_in_rectangle(point_at(99.0, 100.0), rect));
        REQUIRE_FALSE(point_in_rectangle(point_at(100.0, 99.0), rect));
        REQUIRE_FALSE(point_in_rectangle(point_at(300.0, 301.0), rect));
        REQUIRE_FALSE(point_in_rectangle(point_at(100.0 - EPSILON, 150.0), rect));
    }
    SECTION("can detect point in triangle")
    {
        triangle t = triangle_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0));
        REQUIRE(point_in_triangle(point_at(50.0, 50.0), t));
        REQUIRE(point_in_triangle(point_at(100.0, EPSILON), t));
        REQUIRE_FALSE(point_in_triangle(point_at(-100.0, 0.0), t));
        REQUIRE_FALSE(point_in_triangle(point_at(100.0, -EPSILON), t));
    }
    SECTION("can detect point in quad")
    {
        quad q = quad_from(point_at(100.0, 100.0), point_at(500.0, 100.0), point_at(200.0, 500.0), point_at(400.0, 600.0));
        REQUIRE(point_in_quad(point_at(100.0 + EPSILON, 100.0 + EPSILON), q));
        REQUIRE(point_in_quad(point_at(200.0, 200.0), q));
        REQUIRE(point_in_quad(point_at(300.0, 300.0), q));
        REQUIRE_FALSE(point_in_quad(point_at(100.0, 100.0), q));
        REQUIRE_FALSE(point_in_quad(point_at(200.0, 100.0), q));
        REQUIRE_FALSE(point_in_quad(point_at(500.0, 100.0), q));
        REQUIRE_FALSE(point_in_quad(point_at(200.0, 500.0), q));
    }
    SECTION("can detect point in circle")
    {
        circle circ = circle_at(100.0, 100.0, 50.0);
        REQUIRE(point_in_circle(point_at(100.0, 100.0), circ));
        REQUIRE(point_in_circle(point_at(150.0, 100.0), circ));
        REQUIRE(point_in_circle(point_at(100.0 + 25.0 * sqrt(2.0), 100.0 + 25.0 * sqrt(2.0)), circ));
        REQUIRE_FALSE(point_in_circle(150.0, 150.0, 100.0, 100.0, 50.0));
        REQUIRE_FALSE(point_in_circle(point_at(150.0001, 100.0), circ));
    }
    SECTION("can detect point on line with default proximity")
    {
        float proximity = 1.5f;
        line l = line_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(point_on_line(point_at(100.0, 100.0), l));
        REQUIRE(point_on_line(point_at(200.0, 200.0), l));
        REQUIRE(point_on_line(point_at(150.0, 150.0), l));
        REQUIRE_FALSE(point_on_line(point_at(100.0, 100.0 + proximity), l));
        REQUIRE_FALSE(point_on_line(point_at(100.0 + proximity, 100.0), l));
        REQUIRE_FALSE(point_on_line(point_at(200.0 - proximity, 200.0), l));
        REQUIRE_FALSE(point_on_line(point_at(200.0, 200.0 - proximity), l));
    }
    SECTION("can detect point on line with custom proximity")
    {
        float proximity = 0.5f;
        line l = line_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(point_on_line(point_at(100.0, 100.0), l, proximity));
        REQUIRE(point_on_line(point_at(200.0, 200.0), l, proximity));
        REQUIRE(point_on_line(point_at(150.0, 150.0), l, proximity));
        REQUIRE_FALSE(point_on_line(point_at(100.0, 100.0 + proximity + 0.1), l, proximity));
        REQUIRE_FALSE(point_on_line(point_at(100.0 + proximity + 0.1, 100.0), l, proximity));
        REQUIRE_FALSE(point_on_line(point_at(200.0 - proximity - 0.1, 200.0), l, proximity));
        REQUIRE_FALSE(point_on_line(point_at(200.0, 200.0 - proximity - 0.1), l, proximity));
    }
    SECTION("can detect same point when rounded to integer")
    {
        point_2d pt1 = point_at(100.0, 100.0);
        point_2d pt2 = point_at(100.0, 100.0);
        REQUIRE(same_point(pt1, pt2));
        pt2 = point_at(100.499, 100.0);
        REQUIRE(same_point(pt1, pt2));
        point_2d pt3 = point_at(100.0, 101.0);
        REQUIRE_FALSE(same_point(pt1, pt3));
    }
    SECTION("can calculate the angle between two points in degrees")
    {
        point_2d pt1 = point_at(100.0, 100.0);
        point_2d pt2 = point_at(200.0, 200.0);
        REQUIRE(point_point_angle(pt1, pt2) == Approx(45.0f).margin(__FLT_EPSILON__));
        pt2 = point_at(100.0, 200.0);
        REQUIRE(point_point_angle(pt1, pt2) == Approx(90.0f).margin(__FLT_EPSILON__));
        pt2 = point_at(200.0, 100.0);
        REQUIRE(point_point_angle(pt1, pt2) == 0.0f);
    }
    SECTION("can calculate the distance from a point to a line")
    {
        point_2d pt = point_at(100.0, 100.0);
        line l = line_from(0.0, 0.0, 200.0, 200.0);
        REQUIRE(point_line_distance(pt, l) == 0.0f);
        l = line_from(0.0, 0.0, 200.0, 0.0);
        REQUIRE(point_line_distance(pt, l) == 100.0f);
        l = line_from(0.0, 0.0, 0.0, 200.0);
        REQUIRE(point_line_distance(pt, l) == 100.0f);
        l = line_from(0.0, 0.0, 200.0, 100.0);
        REQUIRE(point_line_distance(pt, l) == Approx(sqrtf(20.0f * 20.0f + 40.0f * 40.0f)).margin(__FLT_EPSILON__));
    }
}
TEST_CASE("can perform circle geometry", "[geometry]")
{
    SECTION("can create a circle")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        REQUIRE(c.center.x == 100.0);
        REQUIRE(c.center.y == 100.0);
        REQUIRE(c.radius == 50.0);
    }
    SECTION("can retrieve circle radius")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        REQUIRE(circle_radius(c) == 50.0);
    }
    SECTION("can retrieve circle x value")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        REQUIRE(circle_x(c) == 100.0);
    }
    SECTION("can retrieve circle y value")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        REQUIRE(circle_y(c) == 100.0);
    }
    SECTION("can calculate center point")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        point_2d center = center_point(c);
        REQUIRE(center.x == 100.0);
        REQUIRE(center.y == 100.0);
    }
    SECTION("can detect circle intersection")
    {
        circle c1 = circle_at(100.0, 100.0, 50.0);
        circle c2 = circle_at(150.0, 100.0, 50.0);
        circle c3 = circle_at(200.0, 100.0, 50.0);
        circle c4 = circle_at(200.0, 100.0, 50.0);
        REQUIRE(circles_intersect(c1, c2));
        REQUIRE(circles_intersect(c2, c3));
        REQUIRE_FALSE(circles_intersect(c1, c3));
        REQUIRE_FALSE(circles_intersect(c1, c4));

        SECTION("can detect circle intersection using values")
        {
            REQUIRE(circles_intersect(100.0, 100.0, 50.0, 150.0, 100.0, 50.0));
            REQUIRE(circles_intersect(150.0, 100.0, 50.0, 200.0, 100.0, 50.0));
            REQUIRE_FALSE(circles_intersect(100.0, 100.0, 50.0, 200.0, 100.0, 50.0));
        }
        SECTION("can detect intersection between equal circles")
        {
            REQUIRE(circles_intersect(c4, c4));
        }
        SECTION("can detect small intersection")
        {
            circle c5 = circle_at(0.0, 0.0, 1.0);
            circle c6 = circle_at(2.0 + __DBL_EPSILON__, 0.0, 1.0);
            REQUIRE_FALSE(circles_intersect(c5, c6));
            circle c7 = circle_at(2.0 - __DBL_EPSILON__, 0.0, 1.0);
            REQUIRE(circles_intersect(c5, c7));
        }
    }
    SECTION("can detect circle-triangle intersection")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        triangle t = triangle_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0));
        REQUIRE(circle_triangle_intersect(c, t));
        point_2d p;
        REQUIRE(circle_triangle_intersect(c, t, p));
        REQUIRE(point_in_triangle(p, t));
        triangle t2 = triangle_from(point_at(150.0, 0.0), point_at(150.0, 200.0), point_at(200.0, 100.0));
        REQUIRE_FALSE(circle_triangle_intersect(c, t2));

        SECTION("can detect small intersection")
        {
            circle c2 = circle_at(0.0, 0.0, 1.0);
            triangle t3 = triangle_from(point_at(0.0, 0.0), point_at(2.0, 0.0), point_at(0.0, 2.0));
            REQUIRE(circle_triangle_intersect(c2, t3));
            point_2d p2;
            REQUIRE(circle_triangle_intersect(c2, t3, p2));
            REQUIRE(p2.x == Approx(0.0).margin(__DBL_EPSILON__));
            REQUIRE(p2.y == Approx(0.0).margin(__DBL_EPSILON__));
            triangle t4 = triangle_from(point_at(-1.0, 1.0), point_at(1.0, 1.0), point_at(0.0, 2.0));
            REQUIRE_FALSE(circle_triangle_intersect(c2, t4));
        }
    }
    SECTION("can calculate widest points along vector")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        vector_2d v = vector_to(10.0, 0.0);
        point_2d p1, p2;
        widest_points(c, v, p1, p2);
        REQUIRE(p1.x == 150.0);
        REQUIRE(p1.y == 100.0);
        REQUIRE(p2.x == 50.0);
        REQUIRE(p2.y == 100.0);
        v = vector_to(0.0, 10.0);
        widest_points(c, v, p1, p2);
        REQUIRE(p1.x == 100.0);
        REQUIRE(p1.y == 150.0);
        REQUIRE(p2.x == 100.0);
        REQUIRE(p2.y == 50.0);
        v = vector_to(10.0, -10.0);
        widest_points(c, v, p1, p2);
        double angle = 45.0 * (M_PI / 180.0);
        REQUIRE(p1.x == Approx(100.0 + 50.0 * cos(angle)).margin(__DBL_EPSILON__));
        REQUIRE(p1.y == Approx(100.0 - 50.0 * sin(angle)).margin(__DBL_EPSILON__));
        REQUIRE(p2.x == Approx(100.0 - 50.0 * sin(angle)).margin(__DBL_EPSILON__));
        REQUIRE(p2.y == Approx(100.0 + 50.0 * cos(angle)).margin(__DBL_EPSILON__));
    }
    SECTION("can calculate distant point on circle heading")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        point_2d p = point_at(100.0, 25.0);
        vector_2d v = vector_to(0.0, 1.0);
        point_2d opposite;
        REQUIRE(distant_point_on_circle_heading(p, c, v, opposite));
        REQUIRE(opposite.x == 100.0);
        REQUIRE(opposite.y == 150.0);
        v = vector_to(0.0, -1.0);
        REQUIRE_FALSE(distant_point_on_circle_heading(p, c, v, opposite));
        p = point_at(100.0, 100.0);
        v = vector_to(1.0, 1.0);
        REQUIRE(distant_point_on_circle_heading(p, c, v, opposite));
        double angle = 45.0 * (M_PI / 180.0);
        REQUIRE(opposite.x == Approx(100.0 + 50.0 * cos(angle)).margin(__DBL_EPSILON__));
        REQUIRE(opposite.y == Approx(100.0 + 50.0 * sin(angle)).margin(__DBL_EPSILON__));
    }
    SECTION("can calculate distant point on circle")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        point_2d p = point_at(100.0, 25.0);
        point_2d opposite = distant_point_on_circle(p, c);
        REQUIRE(opposite.x == 100.0);
        REQUIRE(opposite.y == 150.0);
        p = point_at(100.0 + EPSILON, 100.0);
        opposite = distant_point_on_circle(p, c);
        REQUIRE(opposite.x == 50.0);
        REQUIRE(opposite.y == 100.0);
    }
    SECTION("can calculate ray circle intersect distance")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        point_2d origin = point_at(155.0, 100.0);
        vector_2d heading = vector_to(-1.0, 0.0);
        REQUIRE(ray_circle_intersect_distance(origin, heading, c) == Approx(5.0f).margin(__FLT_EPSILON__));
        origin = point_at(45.0, 100.0);
        heading = vector_to(1.0, 0.0);
        REQUIRE(ray_circle_intersect_distance(origin, heading, c) == Approx(5.0f).margin(__FLT_EPSILON__));
        origin = point_at(100.0, 155.0);
        heading = vector_to(0.0, -1.0);
        REQUIRE(ray_circle_intersect_distance(origin, heading, c) == Approx(5.0f).margin(__FLT_EPSILON__));
        origin = point_at(100.0, 45.0);
        heading = vector_to(0.0, 1.0);
        REQUIRE(ray_circle_intersect_distance(origin, heading, c) == Approx(5.0f).margin(__FLT_EPSILON__));
        origin = point_at(100.0, 100.0 + EPSILON);
        heading = vector_to(0.0, 1.0);
        REQUIRE(ray_circle_intersect_distance(origin, heading, c) == Approx(-50.0f).margin(__FLT_EPSILON__));
        origin = point_at(0.0, 0.0);
        heading = vector_to(1.0, 1.0);
        REQUIRE(ray_circle_intersect_distance(origin, heading, c) == Approx(100.0f * sqrt(2.0f) - 50.0f).margin(__FLT_EPSILON__));
        origin = point_at(0.0, 0.0);
        heading = vector_to(-1.0, 0.0);
        REQUIRE(ray_circle_intersect_distance(origin, heading, c) == -1.0f);
    }
    SECTION("can calculate closest point on circle")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        point_2d p = point_at(100.0, 25.0);
        point_2d closest = closest_point_on_circle(p, c);
        REQUIRE(closest.x == 100.0);
        REQUIRE(closest.y == 50.0);
        p = point_at(25.0, 100.0);
        closest = closest_point_on_circle(p, c);
        REQUIRE(closest.x == 50.0);
        REQUIRE(closest.y == 100.0);
        p = point_at(100.0, 175.0);
        closest = closest_point_on_circle(p, c);
        REQUIRE(closest.x == 100.0);
        REQUIRE(closest.y == 150.0);
        p = point_at(175.0, 100.0);
        closest = closest_point_on_circle(p, c);
        REQUIRE(closest.x == 150.0);
        REQUIRE(closest.y == 100.0);
        p = point_at(100.0 + EPSILON, 100.0);
        closest = closest_point_on_circle(p, c);
        REQUIRE(closest.x == 150.0);
        REQUIRE(closest.y == 100.0);
        p = point_at(c.center.x, c.center.y);
        closest = closest_point_on_circle(p, c);
        REQUIRE(closest.x == 100.0);
        REQUIRE(closest.y == 100.0);
    }
    SECTION("can calculate closest point on line from circle")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        line l = line_from(0.0, 0.0, 200.0, 200.0);
        point_2d closest = closest_point_on_line_from_circle(c, l);
        REQUIRE(closest.x == 100.0);
        REQUIRE(closest.y == 100.0);
        l = line_from(0.0, 0.0, 200.0, 0.0);
        closest = closest_point_on_line_from_circle(c, l);
        REQUIRE(closest.x == 100.0);
        REQUIRE(closest.y == 0.0);
        l = line_from(0.0, 0.0, 0.0, 200.0);
        closest = closest_point_on_line_from_circle(c, l);
        REQUIRE(closest.x == 0.0);
        REQUIRE(closest.y == 100.0);
        l = line_from(0.0, 0.0, 200.0, 100.0);
        closest = closest_point_on_line_from_circle(c, l);
        REQUIRE(closest.x == Approx(120.0).margin(__DBL_EPSILON__));
        REQUIRE(closest.y == Approx(60.0).margin(__DBL_EPSILON__));
    }
    SECTION("can calculate closest point on rectangle from circle")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        rectangle r = rectangle_from(150.0, 150.0, 100.0, 100.0);
        point_2d closest = closest_point_on_rect_from_circle(c, r);
        REQUIRE(closest.x == 150.0);
        REQUIRE(closest.y == 150.0);
        r = rectangle_from(75.0, 75.0, 50.0, 50.0);
        closest = closest_point_on_rect_from_circle(c, r);
        REQUIRE(closest.x == 100.0);
        REQUIRE(closest.y == 75.0);
        r = rectangle_from(0.0, 0.0, 200.0, 200.0);
        closest = closest_point_on_rect_from_circle(c, r);
        REQUIRE(closest.x == 100.0);
        REQUIRE(closest.y == 0.0);
    }
    SECTION("can calculate the tangent points on a circle from a point")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        point_2d p = point_at(100.0, 1.0E50);
        point_2d p1, p2;
        REQUIRE(tangent_points(p, c, p1, p2));
        REQUIRE(p1.x == 50.0);
        REQUIRE(p1.y == 100.0);
        REQUIRE(p2.x == 150.0);
        REQUIRE(p2.y == 100.0);
        p = point_at(200.0, 100.0);
        REQUIRE(tangent_points(p, c, p1, p2));
        REQUIRE(p1.x == 125.0);
        REQUIRE(p1.y == Approx(100.0 + sqrt(50.0 * 50.0 - 25.0 * 25.0)).margin(__DBL_EPSILON__));
        REQUIRE(p2.x == 125.0);
        REQUIRE(p2.y == Approx(100.0 - sqrt(50.0 * 50.0 - 25.0 * 25.0)).margin(__DBL_EPSILON__));
        p = point_at(100.0, 100.0);
        REQUIRE_FALSE(tangent_points(p, c, p1, p2));
    }
}
TEST_CASE("can perform rectangle geometry", "[rectangle]")
{
    SECTION("can create rectangle")
    {
        rectangle r = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(r.x == 100.0);
        REQUIRE(r.y == 100.0);
        REQUIRE(r.width == 200.0);
        REQUIRE(r.height == 200.0);
        r = rectangle_from(point_at(100.0, 100.0), point_at(200.0, 200.0));
        REQUIRE(r.x == 100.0);
        REQUIRE(r.y == 100.0);
        REQUIRE(r.width == 100.0);
        REQUIRE(r.height == 100.0);
        r = rectangle_from(point_at(200.0, 200.0), 200.0, 200.0);
        REQUIRE(r.x == 200.0);
        REQUIRE(r.y == 200.0);
        REQUIRE(r.width == 200.0);
        REQUIRE(r.height == 200.0);
    }
    SECTION("can offset rectangle by vector")
    {
        rectangle r = rectangle_from(100.0, 100.0, 200.0, 200.0);
        vector_2d offset = vector_to(50.0, 50.0);
        rectangle new_r = rectangle_offset_by(r, offset);
        REQUIRE(new_r.x == 150.0);
        REQUIRE(new_r.y == 150.0);
        REQUIRE(new_r.width == 200.0);
        REQUIRE(new_r.height == 200.0);
    }
    SECTION("can calculate rectangle center")
    {
        rectangle r = rectangle_from(100.0, 100.0, 200.0, 200.0);
        point_2d center = rectangle_center(r);
        REQUIRE(center.x == 200.0);
        REQUIRE(center.y == 200.0);
    }
    SECTION("can calculate rectangle around line")
    {
        line l = line_from(100.0, 100.0, 200.0, 200.0);
        rectangle r = rectangle_around(l);
        REQUIRE(r.x == 100.0);
        REQUIRE(r.y == 100.0);
        REQUIRE(r.width == 100.0);
        REQUIRE(r.height == 100.0);
        l = line_from(100.0, 100.0, 200.0, 100.0);
        r = rectangle_around(l);
        REQUIRE(r.x == 100.0);
        REQUIRE(r.y == 100.0);
        REQUIRE(r.width == 100.0);
        REQUIRE(r.height == 0.0);
    }
    SECTION("can calculate rectangle around quad")
    {
        quad q = quad_from(point_at(100.0, 100.0), point_at(500.0, 100.0), point_at(200.0, 500.0), point_at(400.0, 600.0));
        rectangle r = rectangle_around(q);
        REQUIRE(r.x == 100.0);
        REQUIRE(r.y == 100.0);
        REQUIRE(r.width == 400.0);
        REQUIRE(r.height == 500.0);
    }
    SECTION("can calculate rectangle around circle")
    {
        circle c = circle_at(100.0, 100.0, 50.0);
        rectangle r = rectangle_around(c);
        REQUIRE(r.x == 50.0);
        REQUIRE(r.y == 50.0);
        REQUIRE(r.width == 100.0);
        REQUIRE(r.height == 100.0);
    }
    SECTION("can calculate intersection")
    {
        rectangle r1 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        rectangle r2 = rectangle_from(150.0, 150.0, 200.0, 200.0);
        REQUIRE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(300.0, 300.0, 200.0, 200.0);
        REQUIRE_FALSE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangles_intersect(r1, r2));
        r2 = rectangle_from(100.0, 100.0, 200.0, 200.0);
    }
    SECTION("can calculate rectangle-rectangle intersection")
    {
        rectangle r1 = rectangle_from(100.0, 100.0, 200.0, 200.0);
        rectangle r2 = rectangle_from(150.0, 150.0, 200.0, 200.0);
        rectangle r3 = intersection(r1, r2);
        REQUIRE(r3.x == 150.0);
        REQUIRE(r3.y == 150.0);
        REQUIRE(r3.width == 150.0);
        REQUIRE(r3.height == 150.0);
        r2 = rectangle_from(300.0, 300.0, 200.0, 200.0);
        r3 = intersection(r1, r2);
        REQUIRE(r3.width == 0.0);
        REQUIRE(r3.height == 0.0);
    }
    SECTION("can calculate rectangle edge positions")
    {
        rectangle r = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangle_top(r) == 100.0);
        REQUIRE(rectangle_bottom(r) == 300.0);
        REQUIRE(rectangle_left(r) == 100.0);
        REQUIRE(rectangle_right(r) == 300.0);
    }
    SECTION("can convert rectangle to string")
    {
        rectangle r = rectangle_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(rectangle_to_string(r) == "Rect @100,100 200x200");
    }
    SECTION("can calculate inset rectangle")
    {
        rectangle r = rectangle_from(100.0, 100.0, 200.0, 200.0);
        rectangle inset = inset_rectangle(r, 50.0f);
        REQUIRE(inset.x == 150.0);
        REQUIRE(inset.y == 150.0);
        REQUIRE(inset.width == 100.0);
        REQUIRE(inset.height == 100.0);
    }
}
TEST_CASE("can perform triangle geometry", "[triangle]")
{
    SECTION("can create triangle")
    {
        triangle t = triangle_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0));
        REQUIRE(t.points[0].x == 0.0);
        REQUIRE(t.points[0].y == 0.0);
        REQUIRE(t.points[1].x == 200.0);
        REQUIRE(t.points[1].y == 0.0);
        REQUIRE(t.points[2].x == 100.0);
        REQUIRE(t.points[2].y == 200.0);
        t = triangle_from(0.0, 0.0, 200.0, 0.0, 100.0, 200.0);
        REQUIRE(t.points[0].x == 0.0);
        REQUIRE(t.points[0].y == 0.0);
        REQUIRE(t.points[1].x == 200.0);
        REQUIRE(t.points[1].y == 0.0);
        REQUIRE(t.points[2].x == 100.0);
        REQUIRE(t.points[2].y == 200.0);
    }
    SECTION("can detect triangle-rectangle intersection")
    {
        triangle t = triangle_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0));
        rectangle r = rectangle_from(50.0, 50.0, 100.0, 100.0);
        REQUIRE(triangle_rectangle_intersect(t, r));
        r = rectangle_from(300.0, 300.0, 200.0, 200.0);
        REQUIRE_FALSE(triangle_rectangle_intersect(t, r));
    }
    SECTION("can detect-triangle-triangle intersection")
    {
        triangle t1 = triangle_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0));
        triangle t2 = triangle_from(point_at(50.0, 50.0), point_at(150.0, 50.0), point_at(100.0, 150.0));
        REQUIRE(triangles_intersect(t1, t2));
        t2 = triangle_from(point_at(300.0, 300.0), point_at(400.0, 300.0), point_at(350.0, 400.0));
        REQUIRE_FALSE(triangles_intersect(t1, t2));
    }
    SECTION("can calculate triangle barycenter")
    {
        triangle t = triangle_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0));
        point_2d barycenter = triangle_barycenter(t);
        REQUIRE(barycenter.x == 100.0);
        REQUIRE(barycenter.y == 200.0 / 3.0);
    }
    SECTION("can convert triangle to string")
    {
        triangle t = triangle_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0));
        REQUIRE(triangle_to_string(t) == "Triangle @Pt @0.000000:0.000000 - Pt @200.000000:0.000000 - Pt @100.000000:200.000000");
    }
}
TEST_CASE("can perform line geometry", "[line]")
{
    SECTION("can create line")
    {
        line l = line_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(l.start_point.x == 100.0);
        REQUIRE(l.start_point.y == 100.0);
        REQUIRE(l.end_point.x == 200.0);
        REQUIRE(l.end_point.y == 200.0);
        l = line_from(point_at(100.0, 100.0), point_at(200.0, 200.0));
        REQUIRE(l.start_point.x == 100.0);
        REQUIRE(l.start_point.y == 100.0);
        REQUIRE(l.end_point.x == 200.0);
        REQUIRE(l.end_point.y == 200.0);
        l = line_from(point_at(100.0, 100.0), vector_to(200.0, 200.0));
        REQUIRE(l.start_point.x == 100.0);
        REQUIRE(l.start_point.y == 100.0);
        REQUIRE(l.end_point.x == 300.0);
        REQUIRE(l.end_point.y == 300.0);
        l = line_from(vector_to(100.0, 100.0));
        REQUIRE(l.start_point.x == 0.0);
        REQUIRE(l.start_point.y == 0.0);
        REQUIRE(l.end_point.x == 100.0);
        REQUIRE(l.end_point.y == 100.0);
    }
    SECTION("can calculate squared line length")
    {
        line l = line_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(line_length_squared(l) == 20000.0f);
    }
    SECTION("can calculate line length")
    {
        line l = line_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(line_length(l) == Approx(100.0f * sqrtf(2.0f)).margin(__FLT_EPSILON__));
    }
    SECTION("can calculate lines from triangle")
    {
        triangle t = triangle_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0));
        std::vector<line> lines = lines_from(t);
        REQUIRE(lines.size() == 3);
        REQUIRE(lines[0].start_point.x == 0.0);
        REQUIRE(lines[0].start_point.y == 0.0);
        REQUIRE(lines[0].end_point.x == 200.0);
        REQUIRE(lines[0].end_point.y == 0.0);
        REQUIRE(lines[1].start_point.x == 200.0);
        REQUIRE(lines[1].start_point.y == 0.0);
        REQUIRE(lines[1].end_point.x == 100.0);
        REQUIRE(lines[1].end_point.y == 200.0);
        REQUIRE(lines[2].start_point.x == 100.0);
        REQUIRE(lines[2].start_point.y == 200.0);
        REQUIRE(lines[2].end_point.x == 0.0);
        REQUIRE(lines[2].end_point.y == 0.0);
    }
    SECTION("can calculate lines from rectangle")
    {
        rectangle r = rectangle_from(100.0, 100.0, 200.0, 200.0);
        std::vector<line> lines = lines_from(r);
        REQUIRE(lines.size() == 4);
        REQUIRE(lines[0].start_point.x == 100.0);
        REQUIRE(lines[0].start_point.y == 100.0);
        REQUIRE(lines[0].end_point.x == 300.0);
        REQUIRE(lines[0].end_point.y == 100.0);
        REQUIRE(lines[1].start_point.x == 100.0);
        REQUIRE(lines[1].start_point.y == 100.0);
        REQUIRE(lines[1].end_point.x == 100.0);
        REQUIRE(lines[1].end_point.y == 300.0);
        REQUIRE(lines[2].start_point.x == 300.0);
        REQUIRE(lines[2].start_point.y == 100.0);
        REQUIRE(lines[2].end_point.x == 300.0);
        REQUIRE(lines[2].end_point.y == 300.0);
        REQUIRE(lines[3].start_point.x == 100.0);
        REQUIRE(lines[3].start_point.y == 300.0);
        REQUIRE(lines[3].end_point.x == 300.0);
        REQUIRE(lines[3].end_point.y == 300.0);
    }
    SECTION("can calculate line intersection point")
    {
        line l1 = line_from(100.0, 100.0, 200.0, 200.0);
        line l2 = line_from(100.0, 200.0, 200.0, 100.0);
        point_2d intersection;
        REQUIRE(line_intersection_point(l1, l2, intersection));
        REQUIRE(intersection.x == 150.0);
        REQUIRE(intersection.y == 150.0);
        l2 = line_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE_FALSE(line_intersection_point(l1, l2, intersection));
    }
    SECTION("can calculate closest point on line")
    {
        line l = line_from(100.0, 100.0, 200.0, 100.0);
        point_2d p = point_at(150.0, 50.0);
        point_2d closest = closest_point_on_line(p, l);
        REQUIRE(closest.x == 150.0);
        REQUIRE(closest.y == 100.0);
        p = point_at(50.0, 50.0);
        closest = closest_point_on_line(p, l);
        REQUIRE(closest.x == 100.0);
        REQUIRE(closest.y == 100.0);
        p = point_at(250.0, 50.0);
        closest = closest_point_on_line(p, l);
        REQUIRE(closest.x == 200.0);
        REQUIRE(closest.y == 100.0);
    }
    SECTION("can calculate closest point on lines")
    {
        line l1 = line_from(100.0, 100.0, 200.0, 100.0);
        line l2 = line_from(150.0, 50.0, 150.0, 150.0);
        std::vector<line> lines = {l1, l2};
        point_2d p = point_at(150.0, 50.0);
        int idx;
        point_2d closest = closest_point_on_lines(p, lines, idx);
        REQUIRE(closest.x == 150.0);
        REQUIRE(closest.y == 50.0);
        REQUIRE(idx == 1);
        p = point_at(150.0, 150.0);
        closest = closest_point_on_lines(p, lines, idx);
        REQUIRE(closest.x == 150.0);
        REQUIRE(closest.y == 150.0);
        REQUIRE(idx == 1);
    }
    SECTION("can detect line intersection")
    {
        line l1 = line_from(100.0, 100.0, 200.0, 200.0);
        line l2 = line_from(100.0, 200.0, 200.0, 100.0);
        REQUIRE(lines_intersect(l1, l2));
        l2 = line_from(100.0, 100.0, 200.0, 100.0);
        REQUIRE(lines_intersect(l1, l2));
        l2 = line_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE_FALSE(lines_intersect(l1, l2));
    }
    SECTION("can detect line intersecting rectangle")
    {
        line l = line_from(100.0, 100.0, 200.0, 200.0);
        rectangle r = rectangle_from(150.0, 150.0, 200.0, 200.0);
        REQUIRE(line_intersects_rect(l, r));
        r = rectangle_from(300.0, 300.0, 200.0, 200.0);
        REQUIRE_FALSE(line_intersects_rect(l, r));
        r = rectangle_from(50.0, 50.0, 500.0, 500.0);
        REQUIRE(line_intersects_rect(l, r));
    }
    SECTION("can calculate line midpoint")
    {
        line l = line_from(100.0, 100.0, 200.0, 200.0);
        point_2d midpoint = line_mid_point(l);
        REQUIRE(midpoint.x == 150.0);
        REQUIRE(midpoint.y == 150.0);
    }
    SECTION("can calculate line normal")
    {
        line l = line_from(100.0, 100.0, 200.0, 200.0);
        vector_2d normal = line_normal(l);
        REQUIRE(normal.x == Approx(-sqrt(2.0) / 2.0).margin(__DBL_EPSILON__));
        REQUIRE(normal.y == Approx(sqrt(2.0) / 2.0).margin(__DBL_EPSILON__));
    }
    SECTION("can convert line to string")
    {
        line l = line_from(100.0, 100.0, 200.0, 200.0);
        REQUIRE(line_to_string(l) == "Line from Pt @100.000000:100.000000 to Pt @200.000000:200.000000");
    }
    SECTION("can detect line intersection with lines")
    {
        line l1 = line_from(100.0, 100.0, 200.0, 200.0);
        line l2 = line_from(100.0, 200.0, 200.0, 100.0);
        std::vector<line> lines = {l1, l2};
        line l = line_from(150.0, 50.0, 150.0, 150.0);
        REQUIRE(line_intersects_lines(l, lines));
        l = line_from(150.0, 50.0, 150.0, 150.0);
        REQUIRE(line_intersects_lines(l, lines));
        l = line_from(150.0, 50.0, 150.0, 150.0);
        REQUIRE(line_intersects_lines(l, lines));
        l2 = l1;
        l = line_from(200.0, 200.0, 300.0, 300.0);
        lines = {l1, l2};
        REQUIRE_FALSE(line_intersects_lines(l, lines));
    }
}
TEST_CASE("can perform quad geometry", "[quad]")
{
    SECTION("can create quad")
    {
        quad q = quad_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0), point_at(300.0, 200.0));
        REQUIRE(q.points[0].x == 0.0);
        REQUIRE(q.points[0].y == 0.0);
        REQUIRE(q.points[1].x == 200.0);
        REQUIRE(q.points[1].y == 0.0);
        REQUIRE(q.points[2].x == 100.0);
        REQUIRE(q.points[2].y == 200.0);
        REQUIRE(q.points[3].x == 300.0);
        REQUIRE(q.points[3].y == 200.0);
        q = quad_from(0.0, 0.0, 200.0, 0.0, 100.0, 200.0, 300.0, 200.0);
        REQUIRE(q.points[0].x == 0.0);
        REQUIRE(q.points[0].y == 0.0);
        REQUIRE(q.points[1].x == 200.0);
        REQUIRE(q.points[1].y == 0.0);
        REQUIRE(q.points[2].x == 100.0);
        REQUIRE(q.points[2].y == 200.0);
        REQUIRE(q.points[3].x == 300.0);
        REQUIRE(q.points[3].y == 200.0);
        q = quad_from(rectangle_from(100.0, 100.0, 200.0, 200.0));
        REQUIRE(q.points[0].x == 100.0);
        REQUIRE(q.points[0].y == 100.0);
        REQUIRE(q.points[1].x == 300.0);
        REQUIRE(q.points[1].y == 100.0);
        REQUIRE(q.points[2].x == 100.0);
        REQUIRE(q.points[2].y == 300.0);
        REQUIRE(q.points[3].x == 300.0);
        REQUIRE(q.points[3].y == 300.0);
    }
    SECTION("can create quad with matrix transform")
    {
        rectangle r = rectangle_from(100.0, 100.0, 200.0, 200.0);
        matrix_2d m = scale_matrix(point_at(2.0, 2.0));
        quad q = quad_from(r, m);
        REQUIRE(q.points[0].x == 200.0);
        REQUIRE(q.points[0].y == 200.0);
        REQUIRE(q.points[1].x == 600.0);
        REQUIRE(q.points[1].y == 200.0);
        REQUIRE(q.points[2].x == 200.0);
        REQUIRE(q.points[2].y == 600.0);
        REQUIRE(q.points[3].x == 600.0);
        REQUIRE(q.points[3].y == 600.0);
        m = translation_matrix(100.0, 100.0);
        q = quad_from(r, m);
        REQUIRE(q.points[0].x == 200.0);
        REQUIRE(q.points[0].y == 200.0);
        REQUIRE(q.points[1].x == 400.0);
        REQUIRE(q.points[1].y == 200.0);
        REQUIRE(q.points[2].x == 200.0);
        REQUIRE(q.points[2].y == 400.0);
        REQUIRE(q.points[3].x == 400.0);
        REQUIRE(q.points[3].y == 400.0);
        m = rotation_matrix(90.0);
        q = quad_from(r, m);
        REQUIRE(q.points[0].x == -100.0);
        REQUIRE(q.points[0].y == 100.0);
        REQUIRE(q.points[1].x == Approx(-100.0).margin(__DBL_EPSILON__));
        REQUIRE(q.points[1].y == 300.0);
        REQUIRE(q.points[2].x == -300.0);
        REQUIRE(q.points[2].y == Approx(100.0).margin(__DBL_EPSILON__));
        REQUIRE(q.points[3].x == -300.0);
        REQUIRE(q.points[3].y == 300.0);
    }
    SECTION("can set quad point")
    {
        quad q = quad_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0), point_at(300.0, 200.0));
        set_quad_point(q, 0, point_at(100.0, 100.0));
        REQUIRE(q.points[0].x == 100.0);
        REQUIRE(q.points[0].y == 100.0);
        REQUIRE(q.points[1].x == 200.0);
        REQUIRE(q.points[1].y == 0.0);
        REQUIRE(q.points[2].x == 100.0);
        REQUIRE(q.points[2].y == 200.0);
        REQUIRE(q.points[3].x == 300.0);
        REQUIRE(q.points[3].y == 200.0);
        set_quad_point(q, 1, point_at(99.0, 99.0));
        REQUIRE(q.points[0].x == 100.0);
        REQUIRE(q.points[0].y == 100.0);
        REQUIRE(q.points[1].x == 99.0);
        REQUIRE(q.points[1].y == 99.0);
        REQUIRE(q.points[2].x == 100.0);
        REQUIRE(q.points[2].y == 200.0);
        REQUIRE(q.points[3].x == 300.0);
        REQUIRE(q.points[3].y == 200.0);
        set_quad_point(q, 2, point_at(98.0, 98.0));
        REQUIRE(q.points[0].x == 100.0);
        REQUIRE(q.points[0].y == 100.0);
        REQUIRE(q.points[1].x == 99.0);
        REQUIRE(q.points[1].y == 99.0);
        REQUIRE(q.points[2].x == 98.0);
        REQUIRE(q.points[2].y == 98.0);
        REQUIRE(q.points[3].x == 300.0);
        REQUIRE(q.points[3].y == 200.0);
        set_quad_point(q, 3, point_at(97.0, 97.0));
        REQUIRE(q.points[0].x == 100.0);
        REQUIRE(q.points[0].y == 100.0);
        REQUIRE(q.points[1].x == 99.0);
        REQUIRE(q.points[1].y == 99.0);
        REQUIRE(q.points[2].x == 98.0);
        REQUIRE(q.points[2].y == 98.0);
        REQUIRE(q.points[3].x == 97.0);
        REQUIRE(q.points[3].y == 97.0);
    }
    SECTION("can detect quad intersection")
    {
        quad q1 = quad_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0), point_at(300.0, 200.0));
        quad q2 = quad_from(point_at(50.0, 50.0), point_at(150.0, 50.0), point_at(100.0, 150.0), point_at(200.0, 150.0));
        REQUIRE(quads_intersect(q1, q2));
        q2 = quad_from(point_at(300.0, 300.0), point_at(400.0, 300.0), point_at(350.0, 400.0), point_at(450.0, 400.0));
        REQUIRE_FALSE(quads_intersect(q1, q2));
    }
    SECTION("can get triangles from quad")
    {
        quad q = quad_from(point_at(0.0, 0.0), point_at(200.0, 0.0), point_at(100.0, 200.0), point_at(300.0, 200.0));
        std::vector<triangle> triangles = triangles_from(q);
        REQUIRE(triangles.size() == 2);
        REQUIRE(triangles[0].points[0].x == 0.0);
        REQUIRE(triangles[0].points[0].y == 0.0);
        REQUIRE(triangles[0].points[1].x == 200.0);
        REQUIRE(triangles[0].points[1].y == 0.0);
        REQUIRE(triangles[0].points[2].x == 100.0);
        REQUIRE(triangles[0].points[2].y == 200.0);
        REQUIRE(triangles[1].points[0].x == 100.0);
        REQUIRE(triangles[1].points[0].y == 200.0);
        REQUIRE(triangles[1].points[1].x == 300.0);
        REQUIRE(triangles[1].points[1].y == 200.0);
        REQUIRE(triangles[1].points[2].x == 200.0);
        REQUIRE(triangles[1].points[2].y == 0.0);
    }
}
TEST_CASE("can perform trigonometric calculations", "[trigonometry]")
{
    SECTION("can calculate cosine")
    {
        REQUIRE(cosine(0.0f) == 1.0f);
        REQUIRE(cosine(90.0f) == Approx(0.0f).margin(__FLT_EPSILON__));
        REQUIRE(cosine(180.0f) == Approx(-1.0f).margin(__FLT_EPSILON__));
        REQUIRE(cosine(270.0f) == Approx(0.0f).margin(__FLT_EPSILON__));
        REQUIRE(cosine(360.0f) == 1.0f);
    }
    SECTION("can calculate sine")
    {
        REQUIRE(sine(0.0f) == 0.0f);
        REQUIRE(sine(90.0f) == 1.0f);
        REQUIRE(sine(180.0f) == Approx(0.0f).margin(__FLT_EPSILON__));
        REQUIRE(sine(270.0f) == -1.0f);
        REQUIRE(sine(360.0f) == Approx(0.0f).margin(__FLT_EPSILON__));
    }
    SECTION("can calculate tangent")
    {
        REQUIRE(tangent(0.0f) == 0.0f);
        REQUIRE(tangent(45.0f) == 1.0f);
        REQUIRE(tangent(91.0f) == Approx(-57.29f).margin(__FLT_EPSILON__));
        REQUIRE(tangent(135.0f) == Approx(-1.0).margin(__FLT_EPSILON__));
        REQUIRE(tangent(180.0f) == Approx(0.0f).margin(__FLT_EPSILON__));
        REQUIRE(tangent(225.0f) == 1.0f);
        REQUIRE(tangent(269.0f) == Approx(57.29f).margin(__FLT_EPSILON__));
        REQUIRE(tangent(315.0f) == Approx(-1.0f).margin(__FLT_EPSILON__));
        REQUIRE(tangent(360.0f) == Approx(0.0f).margin(__FLT_EPSILON__));
    }
}
