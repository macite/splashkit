/**
 * Geometry Unit Tests
 */

#include "catch.hpp"

#include "types.h"
#include "point_geometry.h"

using namespace splashkit_lib;

TEST_CASE("can correctly perform point geometry", "[geometry]")
{
    SECTION("can create a point")
    {
        point_2d pt = point_at(100.0, 200.0);
        REQUIRE(pt.x == 100.0);
        REQUIRE(pt.y == 200.0);
    }
    SECTION("can calculate point-point distance")
    {
        REQUIRE(point_point_distance(point_at(0.0, 0.0), point_at(0.0, 0.0)) == 0.0);
        REQUIRE(point_point_distance(point_at(100.0, 100.0), point_at(100.0, 100.0)) == 0.0);
        REQUIRE(point_point_distance(point_at(100.0, 100.0), point_at(200.0, 100.0)) == 100.0);
        REQUIRE(point_point_distance(point_at(100.0, 100.0), point_at(100.0, 200.0)) == 100.0);
        REQUIRE(point_point_distance(point_at(100.0, 100.0), point_at(200.0, 200.0)) == 100.0 * sqrt(2));
    }
    SECTION("can detect point in circle")
    {
        circle circ = circle_at(100.0, 100.0, 50.0);
        REQUIRE(point_in_circle(point_at(100.0, 100.0), circ));
        REQUIRE(point_in_circle(point_at(150.0, 100.0), circ));
        REQUIRE(point_in_circle(point_at(100.0 + 25.0 * sqrt(2.0), 100.0 + 25.0 * sqrt(2.0)), circ));
        REQUIRE_FALSE(point_in_circle(point_at(150.0, 150.0), circ));
        REQUIRE_FALSE(point_in_circle(point_at(150.0001, 100.0), circ));
    }
}