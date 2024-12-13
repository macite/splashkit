/**
 * Bitmap Unit Tests
 */

#include "catch.hpp"

#include "types.h"
#include "graphics.h"
#include "resources.h"

using namespace splashkit_lib;

constexpr int ROCKET_WIDTH = 36, ROCKET_HEIGHT = 72;

TEST_CASE("bitmaps can be created and freed", "[bitmap]")
{
    SECTION("can detect non-existent bitmap")
    {
        REQUIRE(has_bitmap("non_existent") == false);
        bitmap no_bmp = load_bitmap("non_existent", "non_existent.jpg");
        REQUIRE(no_bmp == nullptr);
        REQUIRE(has_bitmap("non_existent") == false);
    }
    SECTION("can load and free bitmap")
    {
        bitmap bmp;
        string filename = "cottage_door_and_window_199195.jpg", name = "cottage";
        int width = 500, height = 333;
        SECTION("can load bitmap")
        {
            REQUIRE(has_bitmap(name) == false);
            bmp = load_bitmap(name, filename);
            REQUIRE(bmp != nullptr);
            REQUIRE(has_bitmap(name) == true);
            REQUIRE(bitmap_valid(bmp) == true);
            REQUIRE(bitmap_width(bmp) == width);
            REQUIRE(bitmap_height(bmp) == height);
            REQUIRE(bitmap_name(bmp) == name);
            REQUIRE(bitmap_filename(bmp) == path_to_resource(filename, IMAGE_RESOURCE));
            REQUIRE(bitmap_named(name) == bmp);
        }
        SECTION("can free bitmap")
        {
            free_bitmap(bmp);
            REQUIRE(has_bitmap(name) == false);
        }
    }
    SECTION("can load and free multiple bitmaps")
    {
        bitmap bmp1, bmp2;
        string filename1 = "player.png", name1 = "player", filename2 = "ufo.png", name2 = "ufo";
        int width1 = 300, height1 = 42, width2 = 35, height2 = 33;
        SECTION("can load and create two bitmaps")
        {
            REQUIRE(has_bitmap(name1) == false);
            bmp1 = load_bitmap(name1, filename1);
            REQUIRE(bmp1 != nullptr);
            REQUIRE(has_bitmap(name1) == true);
            REQUIRE(bitmap_valid(bmp1) == true);
            REQUIRE(bitmap_width(bmp1) == 300);
            REQUIRE(bitmap_height(bmp1) == 42);
            REQUIRE(bitmap_name(bmp1) == name1);
            REQUIRE(bitmap_filename(bmp1) == path_to_resource(filename1, IMAGE_RESOURCE));
            REQUIRE(bitmap_named(name1) == bmp1);

            REQUIRE(has_bitmap(name2) == false);
            bmp2 = load_bitmap(name2, filename2);
            REQUIRE(bmp2 != nullptr);
            REQUIRE(has_bitmap(name2) == true);
            REQUIRE(bitmap_valid(bmp2) == true);
            REQUIRE(bitmap_width(bmp2) == 35);
            REQUIRE(bitmap_height(bmp2) == 33);
            REQUIRE(bitmap_name(bmp2) == name2);
            REQUIRE(bitmap_filename(bmp2) == path_to_resource(filename2, IMAGE_RESOURCE));
            REQUIRE(bitmap_named(name2) == bmp2);
        }
        SECTION("can free all bitmaps")
        {
            free_all_bitmaps();
            REQUIRE(has_bitmap(name1) == false);
            REQUIRE(has_bitmap(name2) == false);
        }
    }
}
TEST_CASE("bitmap bounding details can be retrieved", "[bitmap]")
{
    bitmap bmp = load_bitmap("rocket", "rocket_sprt.png");
    REQUIRE(bmp != nullptr);
    REQUIRE(bitmap_valid(bmp));
    SECTION("can get bitmap width")
    {
        REQUIRE(bitmap_width(bmp) == ROCKET_WIDTH);
    }
    SECTION("can get bitmap height")
    {
        REQUIRE(bitmap_height(bmp) == ROCKET_HEIGHT);
    }
    SECTION("can get bitmap center")
    {
        point_2d center = bitmap_center(bmp);
        REQUIRE(center.x == ROCKET_WIDTH / 2.0);
        REQUIRE(center.y == ROCKET_HEIGHT / 2.0);
    }
    SECTION("can get bitmap bounding rectangle")
    {
        rectangle rect = bitmap_bounding_rectangle(bmp);
        REQUIRE(rect.x == 0.0);
        REQUIRE(rect.y == 0.0);
        REQUIRE(rect.width == ROCKET_WIDTH);
        REQUIRE(rect.height == ROCKET_HEIGHT);
    }
    double center_corner_dist = sqrt(pow(ROCKET_WIDTH / 2.0, 2.0) + pow(ROCKET_HEIGHT / 2.0, 2.0));

    SECTION("can get bitmap bounding circle")
    {
        circle circ = bitmap_bounding_circle(bmp, point_at(100.0, 100.0));
        REQUIRE(circ.center.x == 100.0);
        REQUIRE(circ.center.y == 100.0);
        REQUIRE(circ.radius == center_corner_dist);
    }
    SECTION("can get bitmap cell circle")
    {
        point_2d pt = point_at(100.0, 100.0);
        circle circ = bitmap_cell_circle(bmp, pt);
        REQUIRE(circ.center.x == pt.x);
        REQUIRE(circ.center.y == pt.y);
        REQUIRE(circ.radius == center_corner_dist);
        circle circ2 = bitmap_cell_circle(bmp, pt.x, pt.y);
        REQUIRE(circ2.center.x == pt.x);
        REQUIRE(circ2.center.y == pt.y);
        REQUIRE(circ2.radius == center_corner_dist);
        
        SECTION("can get bitmap cell circle with scale")
        {
            double scale = 2.0;
            circle circ2 = bitmap_cell_circle(bmp, pt, scale);
            REQUIRE(circ2.center.x == pt.x);
            REQUIRE(circ2.center.y == pt.y);
            REQUIRE(circ2.radius == center_corner_dist * scale);
        }
    }
    free_bitmap(bmp);
}