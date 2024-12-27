/**
 * Geometry Unit Tests
 */

#include "catch.hpp"

#include "types.h"
#include "point_geometry.h"

using namespace splashkit_lib;

TEST_CASE("can perform circle geometry", "[geometry]")
{
   SECTION("can detect circle-quad intersection")
   {
        circle c = circle_at(100.0, 100.0, 50.0);
        quad q = quad_from(rectangle_from(50.0, 50.0, 100.0, 100.0));
        REQUIRE(circle_quad_intersect(c, q));
        q = quad_from(rectangle_from(0.0, 0.0, 500.0, 500.0));
        REQUIRE(circle_quad_intersect(c, q));
        q = quad_from(rectangle_from(99.0, 99.0, 5.0, 5.0));
        REQUIRE(circle_quad_intersect(c, q));
        q = quad_from(rectangle_from(200.0, 200.0, 100.0, 100.0));
        REQUIRE_FALSE(circle_quad_intersect(c, q));
   }
}
TEST_CASE("can perform rectangle geometry", "[rectangle]")
{
    SECTION("can detect rectangle-circle intersection")
    {
        rectangle r = rectangle_from(100.0, 100.0, 100.0, 100.0);
        circle c = circle_at(150.0, 150.0, 50.0);
        REQUIRE(rectangle_circle_intersect(r, c));
        c = circle_at(150.0, 150.0, 1.0);
        REQUIRE(rectangle_circle_intersect(r, c));
        c = circle_at(150.0, 150.0, 500.0);
        REQUIRE(rectangle_circle_intersect(r, c));
        c = circle_at(300.0, 300.0, 50.0);
        REQUIRE_FALSE(rectangle_circle_intersect(r, c));
    }
}
TEST_CASE("can perform triangle geometry", "[triangle]")
{
    SECTION("can detect triangle-quad intersection")
    {
        triangle t = triangle_from(100.0, 100.0, 200.0, 100.0, 150.0, 150.0);
        quad q = quad_from(rectangle_from(50.0, 50.0, 100.0, 100.0));
        REQUIRE(triangle_quad_intersect(t, q));
        q = quad_from(rectangle_from(0.0, 0.0, 500.0, 500.0));
        REQUIRE(triangle_quad_intersect(t, q)); 
        q = quad_from(rectangle_from(150.0, 101.0, 5.0, 5.0));
        REQUIRE(triangle_quad_intersect(t, q));
        q = quad_from(rectangle_from(200.0, 200.0, 100.0, 100.0));
        REQUIRE_FALSE(triangle_quad_intersect(t, q));
    }
}
TEST_CASE("can perform line geometry", "[line]")
{
    SECTION("can detect line-rectangle intersection")
    {
        line l = line_from(100.0, 100.0, 200.0, 200.0);
        rectangle r = rectangle_from(150.0, 150.0, 100.0, 100.0);
        REQUIRE(line_intersects_rect(l, r));
        r = rectangle_from(90.0, 90.0, 200.0, 200.0);
        REQUIRE(line_intersects_rect(l, r));
        r = rectangle_from(250.0, 250.0, 100.0, 100.0);
        REQUIRE_FALSE(line_intersects_rect(l, r));
    }
}