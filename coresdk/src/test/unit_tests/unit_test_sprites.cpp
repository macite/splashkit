/**
 * Sprites Unit Tests
 */

#include "catch.hpp"

#include "sprites.h"
#include "images.h"

using namespace splashkit_lib;

constexpr int ROCKET_WIDTH = 36, ROCKET_HEIGHT = 72,
    FROG_WIDTH = 294, FROG_HEIGHT = 422,
        BACKGROUND_WIDTH = 864, BACKGROUND_HEIGHT = 769;

bitmap rocket_bmp, frog_bmp, background_bmp;

TEST_CASE("bitmaps can be created", "[bitmap]")
{
    rocket_bmp = load_bitmap("rocket_sprt", "rocket_sprt.png");
    REQUIRE(bitmap_valid(rocket_bmp));
    REQUIRE(rocket_bmp != nullptr);
    REQUIRE(bitmap_width(rocket_bmp) == ROCKET_WIDTH);
    REQUIRE(bitmap_height(rocket_bmp) == ROCKET_HEIGHT);
    frog_bmp = load_bitmap("frog", "frog.png");
    REQUIRE(bitmap_valid(frog_bmp));
    REQUIRE(frog_bmp != nullptr);
    REQUIRE(bitmap_width(frog_bmp) == FROG_WIDTH);
    REQUIRE(bitmap_height(frog_bmp) == FROG_HEIGHT);
    background_bmp = load_bitmap("background", "background.png");
    REQUIRE(bitmap_valid(background_bmp));
    REQUIRE(background_bmp != nullptr);
    REQUIRE(bitmap_width(background_bmp) == BACKGROUND_WIDTH);
    REQUIRE(bitmap_height(background_bmp) == BACKGROUND_HEIGHT);
}
TEST_CASE("sprites can be created and freed", "[sprite]")
{
    SECTION("can detect non-existent sprite")
    {
        REQUIRE_FALSE(has_sprite("non_existent"));
        bitmap non_bmp = bitmap_named("non_existent");
        REQUIRE(non_bmp == nullptr);
        REQUIRE_FALSE(has_sprite("non_existent"));
        sprite no_sprite = create_sprite("non-existent", non_bmp);
        REQUIRE_FALSE(has_sprite("non_existent"));
    }
    SECTION("can create and free sprite")
    {
        REQUIRE_FALSE(has_sprite("rocket"));
        sprite sprt = create_sprite("rocket", rocket_bmp);
        REQUIRE(has_sprite("rocket"));
        REQUIRE(sprite_named("rocket") == sprt);
        REQUIRE(sprite_name(sprt) == "rocket");
        free_sprite(sprt);
        REQUIRE_FALSE(has_sprite("rocket"));
    }
    SECTION("can create and free sprite with animation")
    {
        animation_script kermit = load_animation_script("kermit", "kermit.txt");
        REQUIRE(has_animation_script("kermit"));
        REQUIRE_FALSE(has_sprite("frog"));
        sprite sprt = create_sprite("frog", frog_bmp, kermit);
        REQUIRE(has_sprite("frog"));
        free_sprite(sprt);
        REQUIRE_FALSE(has_sprite("frog"));
        free_animation_script(kermit);
        REQUIRE_FALSE(has_animation_script("kermit"));
    }
    SECTION("can free multiple sprites")
    {
        REQUIRE_FALSE(has_sprite("rocket"));
        sprite sprt = create_sprite("rocket", rocket_bmp);
        REQUIRE(has_sprite("rocket"));
        sprite sprt2 = create_sprite("rocket2", rocket_bmp);
        REQUIRE(has_sprite("rocket2"));
        free_all_sprites();
        REQUIRE_FALSE(has_sprite("rocket"));
        REQUIRE_FALSE(has_sprite("rocket2"));
    }
}
TEST_CASE("default sprite data can be retrieved", "[sprite]")
{
    sprite sprt = create_sprite("rocket", rocket_bmp);
    REQUIRE(sprite_width(sprt) == ROCKET_WIDTH);
    REQUIRE(sprite_height(sprt) == ROCKET_HEIGHT);
    SECTION("can retrieve sprite layer details")
    {
        REQUIRE(sprite_layer_count(sprt) == 1);
        REQUIRE(sprite_visible_layer_count(sprt) == 1);
        REQUIRE(sprite_layer(sprt, 0) == rocket_bmp);
        REQUIRE(sprite_visible_layer(sprt, 0) == 0);
        REQUIRE(sprite_visible_layer_id(sprt, 0) == 0);
        REQUIRE(sprite_visible_index_of_layer(sprt, 0) == 0);
    }
    SECTION("can retrieve sprite layer dimensions")
    {
        REQUIRE(sprite_layer_width(sprt, 0) == ROCKET_WIDTH);
        REQUIRE(sprite_layer_height(sprt, 0) == ROCKET_HEIGHT);
    }
    SECTION("can retrieve sprite layer rectangle")
    {
        rectangle layer_rec = sprite_layer_rectangle(sprt, 0);
        REQUIRE(layer_rec.height == ROCKET_HEIGHT);
        REQUIRE(layer_rec.width == ROCKET_WIDTH);
        REQUIRE(layer_rec.x == 0.0);
        REQUIRE(layer_rec.y == 0.0);
    }
    SECTION("can retrieve sprite collision rectangle")
    {
        rectangle coll_rec = sprite_collision_rectangle(sprt);
        REQUIRE(coll_rec.height == ROCKET_HEIGHT);
        REQUIRE(coll_rec.width == ROCKET_WIDTH);
        REQUIRE(coll_rec.x == 0.0);
        REQUIRE(coll_rec.y == 0.0);
    } 
    SECTION("can retrieve sprite layer offset")
    {
        vector_2d offset = sprite_layer_offset(sprt, 0);
        REQUIRE(offset.x == 0.0);
        REQUIRE(offset.y == 0.0);
    }
    SECTION("can retrieve sprite anchor point")
    {
        point_2d anchor = sprite_anchor_point(sprt);
        REQUIRE(anchor.x == ROCKET_WIDTH / 2.0);
        REQUIRE(anchor.y == ROCKET_HEIGHT / 2.0);
    }
    SECTION("can retrieve sprite center point")
    {
        point_2d center = center_point(sprt);
        REQUIRE(center.x == ROCKET_WIDTH / 2.0);
        REQUIRE(center.y == ROCKET_HEIGHT / 2.0);
    }
    SECTION("can retrieve sprite collision circle")
    {
        circle circ = sprite_collision_circle(sprt);
        REQUIRE(circ.center.x == ROCKET_WIDTH / 2.0);
        REQUIRE(circ.center.y == ROCKET_HEIGHT / 2.0);
        REQUIRE(circ.radius == sqrt(pow(ROCKET_WIDTH / 2.0, 2.0) + pow(ROCKET_HEIGHT / 2.0, 2.0)));
    }
    SECTION("can retrieve sprite layer circle")
    {
        circle circ = sprite_layer_circle(sprt, 0);
        REQUIRE(circ.center.x == ROCKET_WIDTH / 2.0);
        REQUIRE(circ.center.y == ROCKET_HEIGHT / 2.0);
        REQUIRE(circ.radius == sqrt(pow(ROCKET_WIDTH / 2.0, 2.0) + pow(ROCKET_HEIGHT / 2.0, 2.0)));
    }
    SECTION("can retrieve sprite circle")
    {
        circle circ = sprite_circle(sprt);
        REQUIRE(circ.center.x == ROCKET_WIDTH / 2.0);
        REQUIRE(circ.center.y == ROCKET_HEIGHT / 2.0);
        REQUIRE(circ.radius == sqrt(pow(ROCKET_WIDTH / 2.0, 2.0) + pow(ROCKET_HEIGHT / 2.0, 2.0)));
    }
    SECTION("can retrieve sprite collision bitmap")
    {
        bitmap bmp = sprite_collision_bitmap(sprt);
        REQUIRE(bmp == rocket_bmp);
    }
    SECTION("can retrieve sprite collision kind")
    {
        REQUIRE(sprite_collision_kind(sprt) == PIXEL_COLLISIONS);
    }
    SECTION("can retrieve sprite default matrix")
    {
        matrix_2d m = sprite_location_matrix(sprt);
        rectangle r = sprite_collision_rectangle(sprt);
        matrix_2d translation = translation_matrix(r.x, r.y);
        REQUIRE(m.elements[0][0] == translation.elements[0][0]);
        REQUIRE(m.elements[0][1] == translation.elements[0][1]);
        REQUIRE(m.elements[0][2] == translation.elements[0][2]);
        REQUIRE(m.elements[1][0] == translation.elements[1][0]);
        REQUIRE(m.elements[1][1] == translation.elements[1][1]);
        REQUIRE(m.elements[1][2] == translation.elements[1][2]);
        REQUIRE(m.elements[2][0] == translation.elements[2][0]);
        REQUIRE(m.elements[2][1] == translation.elements[2][1]);
        REQUIRE(m.elements[2][2] == translation.elements[2][2]);
    }
    free_sprite(sprt);
}
TEST_CASE("sprite can be moved", "[sprite]")
{
    sprite sprt = create_sprite("rocket", rocket_bmp);
    REQUIRE(has_sprite("rocket"));

    SECTION("initial position is (0, 0)")
    {
        REQUIRE(sprite_x(sprt) == 0.0);
        REQUIRE(sprite_y(sprt) == 0.0);
    }
    SECTION("can set sprite position")
    {
        sprite_set_x(sprt, 100.0);
        sprite_set_y(sprt, 200.0);
        point_2d pos = sprite_position(sprt);
        REQUIRE(pos.x == 100.0);
        REQUIRE(pos.y == 200.0);
        REQUIRE(sprite_x(sprt) == 100.0);
        REQUIRE(sprite_y(sprt) == 200.0);
    }
    SECTION("can set sprite position with point")
    {
        sprite_set_position(sprt, point_at(300.0, 400.0));
        point_2d pos = sprite_position(sprt);
        REQUIRE(pos.x == 300.0);
        REQUIRE(pos.y == 400.0);
        REQUIRE(sprite_x(sprt) == 300.0);
        REQUIRE(sprite_y(sprt) == 400.0);
        sprite_set_position(sprt, point_at(0.0, 0.0));
        pos = sprite_position(sprt);
        REQUIRE(pos.x == 0.0);
        REQUIRE(pos.y == 0.0);
        REQUIRE(sprite_x(sprt) == 0.0);
        REQUIRE(sprite_y(sprt) == 0.0);

        SECTION("can set sprite position to extreme values")
        {
            sprite_set_position(sprt, point_at(__DBL_MAX__, -__DBL_MAX__));
            pos = sprite_position(sprt);
            REQUIRE(pos.x == __DBL_MAX__);
            REQUIRE(pos.y == -__DBL_MAX__);
            REQUIRE(sprite_x(sprt) == __DBL_MAX__);
            REQUIRE(sprite_y(sprt) == -__DBL_MAX__);
            sprite_set_position(sprt, point_at(__DBL_MIN__, -__DBL_MIN__));
            pos = sprite_position(sprt);
            REQUIRE(pos.x == __DBL_MIN__);
            REQUIRE(pos.y == -__DBL_MIN__);
            REQUIRE(sprite_x(sprt) == __DBL_MIN__);
            REQUIRE(sprite_y(sprt) == -__DBL_MIN__);
        }
    }
    SECTION("can move sprite by anchor point")
    {
        sprite_set_move_from_anchor_point(sprt, true);
        sprite_set_anchor_point(sprt, point_at(30.0, 50.0));
        move_sprite_to(sprt, 500.0, 500.0);
        REQUIRE(sprite_x(sprt) == 500.0 - 30.0);
        REQUIRE(sprite_y(sprt) == 500.0 - 50.0);
    }
    SECTION("can move sprite from origin")
    {
        sprite_set_move_from_anchor_point(sprt, false);
        move_sprite_to(sprt, 10.0, 20.0);
        REQUIRE(sprite_x(sprt) == 10.0);
        REQUIRE(sprite_y(sprt) == 20.0);
    }
    SECTION("can get center point of sprite")
    {
        SECTION("sprite dimensions can be retrieved")
        {
            REQUIRE(sprite_width(sprt) == ROCKET_WIDTH);
            REQUIRE(sprite_height(sprt) == ROCKET_HEIGHT);
        }
        point_2d pos = sprite_position(sprt);
        point_2d center = center_point(sprt);
        REQUIRE(center.x == pos.x + ROCKET_WIDTH / 2.0);
        REQUIRE(center.y == pos.y + ROCKET_HEIGHT / 2.0);
    }
    free_sprite(sprt);
}
TEST_CASE("can check sprite intersection", "[sprite]")
{
    sprite sprt = create_sprite("background", background_bmp);
    REQUIRE(has_sprite("background"));
    sprite_set_move_from_anchor_point(sprt, false);
    sprite sprt2 = create_sprite("background_2", background_bmp);
    REQUIRE(has_sprite("background_2"));
    sprite_set_move_from_anchor_point(sprt2, false);

    SECTION("can check AABB collision")
    {
        sprite_set_collision_kind(sprt, AABB_COLLISIONS);
        sprite_set_collision_kind(sprt2, AABB_COLLISIONS);
        sprite_set_position(sprt, point_at(100.0, 100.0));
        sprite_set_position(sprt2, point_at(1300.0, 1300.0));
        REQUIRE_FALSE(sprite_collision(sprt, sprt2));
        REQUIRE_FALSE(sprite_rectangle_collision(sprt, sprite_collision_rectangle(sprt2)));
        sprite_set_position(sprt2, point_at(100.0, 100.0));
        REQUIRE(sprite_collision(sprt, sprt2));
        REQUIRE(sprite_rectangle_collision(sprt, sprite_collision_rectangle(sprt2)));

        SECTION("can detect small intersection")
        {
            sprite_set_position(sprt2, point_at(0.0, 0.0));
            sprite_set_position(sprt, point_at(sprite_width(sprt2), 0.0));
            REQUIRE_FALSE(sprite_collision(sprt, sprt2));
            REQUIRE_FALSE(sprite_rectangle_collision(sprt, sprite_collision_rectangle(sprt2)));
            sprite_set_position(sprt, point_at(sprite_width(sprt2) - 0.001, 0.0));
            REQUIRE(sprite_collision(sprt, sprt2));
            REQUIRE(sprite_rectangle_collision(sprt, sprite_collision_rectangle(sprt2)));
        }
    }
    SECTION("can check pixel collision")
    {
        sprite_set_collision_kind(sprt, PIXEL_COLLISIONS);
        sprite_set_collision_kind(sprt2, PIXEL_COLLISIONS);
        sprite_set_position(sprt, point_at(100.0, 100.0));
        sprite_set_position(sprt2, point_at(1500.0, 1500.0));
        REQUIRE_FALSE(sprite_collision(sprt, sprt2));
        sprite_set_position(sprt2, point_at(100.0, 100.0));
        REQUIRE(sprite_collision(sprt, sprt2));
    }
    SECTION("can check sprite intersection with bitmap")
    {
        sprite_set_collision_kind(sprt, PIXEL_COLLISIONS);
        sprite_set_position(sprt, point_at(100.0, 100.0));
        REQUIRE_FALSE(sprite_bitmap_collision(sprt, frog_bmp, 0, 1500.0, 1500.0));
        REQUIRE(sprite_bitmap_collision(sprt, frog_bmp, 0, 100.0, 100.0));
    }
    SECTION("can check sprite intersection with point")
    {
        sprite_set_collision_kind(sprt2, AABB_COLLISIONS);
        sprite_set_move_from_anchor_point(sprt2, false);
        sprite_set_position(sprt2, point_at(0.0, 0.0));
        REQUIRE_FALSE(sprite_point_collision(sprt2, point_at(2000.0, 2000.0)));
        REQUIRE_FALSE(sprite_at(sprt2, point_at(2000.0, 2000.0)));
        REQUIRE(sprite_point_collision(sprt2, point_at(400.0, 400.0)));
        REQUIRE(sprite_at(sprt2, point_at(400.0, 400.0)));
        REQUIRE_FALSE(sprite_point_collision(sprt2, point_at(0.0, 0.0)));
        REQUIRE_FALSE(sprite_at(sprt2, point_at(0.0, 0.0)));

        point_2d pt1 = point_at(0.1, 0.1);
        circle c = sprite_collision_circle(sprt2);
        point_2d center = center_point(sprt2);
        REQUIRE(c.center.x == center.x);
        REQUIRE(c.center.y == center.y);
        REQUIRE(c.radius == sqrt(pow(BACKGROUND_WIDTH / 2.0, 2.0) + pow(BACKGROUND_HEIGHT / 2.0, 2.0)));
        REQUIRE(point_in_circle(pt1, c));
        REQUIRE(sprite_point_collision(sprt2, pt1));

        point_2d pt2 = point_at(0.000001, 0.000001);
        REQUIRE(point_in_circle(pt2, sprite_collision_circle(sprt2)));
        REQUIRE(sprite_point_collision(sprt2, pt2));
    }
    free_sprite(sprt);
    free_sprite(sprt2);
}
TEST_CASE("can set sprite velocity components", "[sprite]")
{
    sprite sprt = create_sprite("background", background_bmp);
    REQUIRE(has_sprite("background"));
    sprite_set_move_from_anchor_point(sprt, false);
    sprite_set_position(sprt, point_at(100.0, 100.0));
    SECTION("can set sprite velocity x")
    {
        sprite_set_dx(sprt, 10.0);
        REQUIRE(sprite_dx(sprt) == 10.0);
        sprite_set_dx(sprt, __DBL_MIN__);
        REQUIRE(sprite_dx(sprt) == __DBL_MIN__);
        sprite_set_dx(sprt, -__DBL_MAX__);
        REQUIRE(sprite_dx(sprt) == -__DBL_MAX__);
    }
    SECTION("can set sprite velocity y")
    {
        sprite_set_dy(sprt, 20.0);
        REQUIRE(sprite_dy(sprt) == 20.0);
        sprite_set_dy(sprt, __DBL_MIN__);
        REQUIRE(sprite_dy(sprt) == __DBL_MIN__);
        sprite_set_dy(sprt, -__DBL_MAX__);
        REQUIRE(sprite_dy(sprt) == -__DBL_MAX__);
    }
    free_sprite(sprt);
}
TEST_CASE("can perform sprite vector functions", "[sprite]")
{
    sprite sprt = create_sprite("background", background_bmp);
    REQUIRE(has_sprite("background"));
    sprite_set_move_from_anchor_point(sprt, false);
    sprite_set_position(sprt, point_at(100.0, 100.0));
    SECTION("can get default sprite velocity vector")
    {
        vector_2d vec = sprite_velocity(sprt);
        REQUIRE(vec.x == 0.0);
        REQUIRE(vec.y == 0.0);
    }
    SECTION("can set sprite vector")
    {
        sprite_set_velocity(sprt, vector_to(10.0, 20.0));
        vector_2d vec = sprite_velocity(sprt);
        REQUIRE(vec.x == 10.0);
        REQUIRE(vec.y == 20.0);
    }
    SECTION("can move sprite by vector")
    {
        move_sprite(sprt, vector_to(30.0, 40.0));
        REQUIRE(sprite_x(sprt) == 100.0 + 30.0);
        REQUIRE(sprite_y(sprt) == 100.0 + 40.0);
    }
    SECTION("can move sprite by vector with scale")
    {
        move_sprite(sprt, vector_to(30.0, 40.0), 2.0);
        REQUIRE(sprite_x(sprt) == 100.0 + 30.0 * 2.0);
        REQUIRE(sprite_y(sprt) == 100.0 + 40.0 * 2.0);
    }
    SECTION("can move sprite by velocity")
    {
        sprite_set_velocity(sprt, vector_to(50.0, 60.0));
        move_sprite(sprt);
        REQUIRE(sprite_x(sprt) == 100.0 + 50.0);
        REQUIRE(sprite_y(sprt) == 100.0 + 60.0);
    }
    SECTION("can move sprite by vector with percentage")
    {
        sprite_set_velocity(sprt, vector_to(30.0, 20.0));
        move_sprite(sprt, 0.5);
        REQUIRE(sprite_x(sprt) == 100.0 + 30.0 * 0.5);
        REQUIRE(sprite_y(sprt) == 100.0 + 20.0 * 0.5);
    }
    SECTION("can move sprive by vector with percentage")
    {
        move_sprite(sprt, vector_to(150.0, 60.0), 0.5);
        REQUIRE(sprite_x(sprt) == 100.0 + 150.0 * 0.5);
        REQUIRE(sprite_y(sprt) == 100.0 + 60.0 * 0.5);
    }
    SECTION("can add velocity to sprite")
    {
        sprite_set_velocity(sprt, vector_to(10.0, 20.0));
        sprite_add_to_velocity(sprt, vector_to(30.0, 40.0));
        vector_2d vec = sprite_velocity(sprt);
        REQUIRE(vec.x == 10.0 + 30.0);
        REQUIRE(vec.y == 20.0 + 40.0);
    }
    SECTION("can get vector from center of sprite to point")
    {
        vector_2d vec = vector_from_center_sprite_to_point(sprt, point_at(200.0, 200.0));
        point_2d center = center_point(sprt);
        REQUIRE(vec.x == 200.0 - center.x);
        REQUIRE(vec.y == 200.0 - center.y);
    }
    SECTION("can get vector between two sprites")
    {
        sprite sprt2 = create_sprite("background_2", background_bmp);
        sprite_set_move_from_anchor_point(sprt2, false);
        sprite_set_position(sprt2, point_at(200.0, 200.0));
        vector_2d vec = vector_from_to(sprt, sprt2);
        point_2d center1 = center_point(sprt);
        point_2d center2 = center_point(sprt2);
        REQUIRE(vec.x == center2.x - center1.x);
        REQUIRE(vec.y == center2.y - center1.y);
        free_sprite(sprt2);
    }
    free_sprite(sprt);
}
TEST_CASE("sprite speed can be set and retrieved", "[sprite]")
{
    sprite sprt = create_sprite("background", background_bmp);
    REQUIRE(has_sprite("background"));
    sprite_set_move_from_anchor_point(sprt, false);
    sprite_set_position(sprt, point_at(100.0, 100.0));
    SECTION("can get default sprite speed")
    {
        REQUIRE(sprite_speed(sprt) == 0.0);
    }
    SECTION("can set sprite speed")
    {
        sprite_set_velocity(sprt, vector_to(10.0, -10.0));
        sprite_set_speed(sprt, 20.0);
        REQUIRE(sprite_speed(sprt) == Approx(20.0).margin(__DBL_EPSILON__));
        sprite_set_speed(sprt, 50.0);
        REQUIRE(sprite_speed(sprt) == Approx(50.0).margin(__DBL_EPSILON__));
        sprite_set_speed(sprt, -800.0);
        REQUIRE(sprite_speed(sprt) == Approx(800.0).margin(__DBL_EPSILON__));
        sprite_set_speed(sprt, __DBL_MAX__);
        REQUIRE(sprite_speed(sprt) == Approx(__DBL_MAX__).margin(__DBL_EPSILON__));
    }
    free_sprite(sprt);
}
TEST_CASE("sprite heading can be set and retrieved", "[sprite]")
{
    sprite sprt = create_sprite("background", background_bmp);
    REQUIRE(has_sprite("background"));
    sprite_set_move_from_anchor_point(sprt, false);
    sprite_set_position(sprt, point_at(100.0, 100.0));
    SECTION("can get default sprite heading")
    {
        REQUIRE(sprite_heading(sprt) == 90.0f);
    }
    SECTION("can set sprite heading")
    {
        sprite_set_speed(sprt, 10.0f);
        sprite_set_heading(sprt, 0.0f);
        REQUIRE(sprite_heading(sprt) == 0.0f);
        sprite_set_heading(sprt, 180.0f);
        REQUIRE(sprite_heading(sprt) == Approx(180.0f).margin(__FLT_EPSILON__));
        sprite_set_heading(sprt, 270.0f);
        REQUIRE(sprite_heading(sprt) == Approx(-90.0f).margin(__FLT_EPSILON__));
        sprite_set_heading(sprt, -90.0f);
        REQUIRE(sprite_heading(sprt) == Approx(-90.0f).margin(__FLT_EPSILON__));
        sprite_set_heading(sprt, 360.0f);
        REQUIRE(sprite_heading(sprt) == Approx(0.0f).margin(__FLT_EPSILON__));
        sprite_set_heading(sprt, 450.0f);
        REQUIRE(sprite_heading(sprt) == Approx(90.0f).margin(__FLT_EPSILON__));
        sprite_set_heading(sprt, -450.0f);
        REQUIRE(sprite_heading(sprt) == Approx(-90.0f).margin(__FLT_EPSILON__));
        sprite_set_heading(sprt, 360.0f * 10000 + 1.0f);
        REQUIRE(sprite_heading(sprt) == Approx(1.0).margin(__FLT_EPSILON__));
    }
    free_sprite(sprt);
}
TEST_CASE("sprite mass can be set and retrieved", "[sprite]")
{
    sprite sprt = create_sprite("background", background_bmp);
    REQUIRE(has_sprite("background"));
    SECTION("can get default sprite mass")
    {
        REQUIRE(sprite_mass(sprt) == 1.0f);
    }
    SECTION("can set sprite mass")
    {
        sprite_set_mass(sprt, 10.0f);
        REQUIRE(sprite_mass(sprt) == 10.0f);
        sprite_set_mass(sprt, 0.0f);
        REQUIRE(sprite_mass(sprt) == 0.0f);
        sprite_set_mass(sprt, -800.0f);
        REQUIRE(sprite_mass(sprt) == -800.0f);
        sprite_set_mass(sprt, __FLT_MAX__);
        REQUIRE(sprite_mass(sprt) == __FLT_MAX__);
        sprite_set_mass(sprt, -__FLT_MIN__);
        REQUIRE(sprite_mass(sprt) == -__FLT_MIN__);
    }
    free_sprite(sprt);
}
TEST_CASE("sprite rotation can be set and retrieved", "[sprite]")
{
    sprite sprt = create_sprite("background", background_bmp);
    REQUIRE(has_sprite("background"));
    SECTION("can get default sprite rotation")
    {
        REQUIRE(sprite_rotation(sprt) == 0.0f);
    }
    SECTION("can set sprite rotation")
    {
        sprite_set_rotation(sprt, 10.0f);
        REQUIRE(sprite_rotation(sprt) == 10.0f);
        sprite_set_rotation(sprt, 0.0f);
        REQUIRE(sprite_rotation(sprt) == 0.0f);
        sprite_set_rotation(sprt, 360.0f);
        REQUIRE(sprite_rotation(sprt) == 0.0f);
        sprite_set_rotation(sprt, 450.0f);
        REQUIRE(sprite_rotation(sprt) == 90.0f);
        sprite_set_rotation(sprt, -450.0f);
        REQUIRE(sprite_rotation(sprt) == 270.0f);
        sprite_set_rotation(sprt, 360.0f * 10000 + 1.0f);
        REQUIRE(sprite_rotation(sprt) == 1.0f);
    }
    free_sprite(sprt);
}
TEST_CASE("sprite scale can be set and retrieved", "[sprite]")
{
    sprite sprt = create_sprite("background", background_bmp);
    REQUIRE(has_sprite("background"));
    SECTION("can get default sprite scale")
    {
        REQUIRE(sprite_scale(sprt) == 1.0f);
    }
    SECTION("can set sprite scale")
    {
        sprite_set_scale(sprt, 10.0f);
        REQUIRE(sprite_scale(sprt) == 10.0f);
        sprite_set_scale(sprt, 0.0f);
        REQUIRE(sprite_scale(sprt) == 0.0f);
        sprite_set_scale(sprt, -800.0f);
        REQUIRE(sprite_scale(sprt) == -800.0f);
        sprite_set_scale(sprt, __FLT_MAX__);
        REQUIRE(sprite_scale(sprt) == __FLT_MAX__);
        sprite_set_scale(sprt, -__FLT_MIN__);
        REQUIRE(sprite_scale(sprt) == -__FLT_MIN__);
    }
    free_sprite(sprt);
}
TEST_CASE("sprite values can be created, modified, and retrieved", "[sprite]")
{
    sprite sprt = create_sprite("background", background_bmp);
    REQUIRE(has_sprite("background"));
    SECTION("can get default sprite values")
    {
        REQUIRE(sprite_value_count(sprt) == 3);
        REQUIRE(sprite_has_value(sprt, "mass"));
        REQUIRE(sprite_value(sprt, "mass") == 1.0f);
        REQUIRE(sprite_has_value(sprt, "rotation"));
        REQUIRE(sprite_value(sprt, "rotation") == 0.0f);
        REQUIRE(sprite_has_value(sprt, "scale"));
        REQUIRE(sprite_value(sprt, "scale") == 1.0f);
    }
    SECTION("can add sprite values")
    {
        sprite_add_value(sprt, "speed");
        REQUIRE(sprite_value_count(sprt) == 4);
        REQUIRE(sprite_has_value(sprt, "speed"));
        REQUIRE(sprite_value(sprt, "speed") == 0.0f);

        SECTION("can set sprite values")
        { 
            sprite_set_value(sprt, "speed", 20.0f);
            REQUIRE(sprite_value(sprt, "speed") == 20.0f);
        }
    }
    SECTION("can add sprite values with initial value")
    {
        sprite_add_value(sprt, "ammo", 10.0f);
        REQUIRE(sprite_value_count(sprt) == 4);
        REQUIRE(sprite_has_value(sprt, "ammo"));
        REQUIRE(sprite_value(sprt, "ammo") == 10.0f);

        SECTION("can set sprite values")
        {
            sprite_set_value(sprt, "ammo", 5.0f);
            REQUIRE(sprite_value(sprt, "ammo") == 5.0f);
        }
    }
    free_sprite(sprt);
}
void test_sprite_function(void *s)
{
    sprite_set_dx(static_cast<sprite>(s), 10.0);
}
void test_sprite_float_function(void *s, float f)
{
    sprite_set_dx(static_cast<sprite>(s), f);
}
TEST_CASE("sprite functions can be called", "[sprite]")
{
    sprite sprt = create_sprite("background", background_bmp);
    REQUIRE(has_sprite("background"));
    REQUIRE(sprite_dx(sprt) == 0.0);
    sprite sprt2 = create_sprite("background_2", background_bmp);
    REQUIRE(has_sprite("background_2"));
    REQUIRE(sprite_dx(sprt2) == 0.0);
    SECTION("can call sprite function")
    {
        call_for_all_sprites(test_sprite_function);
        REQUIRE(sprite_dx(sprt) == 10.0);
        REQUIRE(sprite_dx(sprt2) == 10.0);
    }
    SECTION("can call sprite function with float argument")
    {
        call_for_all_sprites(test_sprite_float_function, 20.0);
        REQUIRE(sprite_dx(sprt) == 20.0);
        REQUIRE(sprite_dx(sprt2) == 20.0);
    }
    free_sprite(sprt);
    free_sprite(sprt2);
}
TEST_CASE("sprite pack functions can be used", "[sprite]")
{
    SECTION("can access default sprite pack")
    {
        REQUIRE(has_sprite_pack("default"));
        REQUIRE(current_sprite_pack() == "default");
    }
    SECTION("can add sprite to default sprite pack")
    {
        sprite sprt = create_sprite("sprite_1", background_bmp);
        REQUIRE(has_sprite("sprite_1"));
        SECTION("can call sprite function")
        {
            REQUIRE(sprite_dx(sprt) == 0.0);
            call_for_all_sprites(test_sprite_function);
            REQUIRE(sprite_dx(sprt) == 10.0);
        }
        free_sprite(sprt);
    }
    SECTION("can create sprite pack")
    {
        create_sprite_pack("test_pack");
        REQUIRE(has_sprite_pack("test_pack"));
    }
    SECTION("can change sprite pack")
    {
        select_sprite_pack("test_pack");
        REQUIRE(current_sprite_pack() == "test_pack");
    }
    SECTION("can confirm that only sprites in current pack are affected")
    {
        sprite sprt = create_sprite("sprite_1", background_bmp);
        REQUIRE(has_sprite("sprite_1"));
        REQUIRE(sprite_dx(sprt) == 0.0);

        select_sprite_pack("default");

        sprite sprt2 = create_sprite("sprite_2", background_bmp);
        REQUIRE(has_sprite("sprite_2"));
        REQUIRE(sprite_dx(sprt2) == 0.0);

        select_sprite_pack("test_pack");
        call_for_all_sprites(test_sprite_function);
        REQUIRE(sprite_dx(sprt) == 10.0);
        sprite_set_dx(sprt, 90.0);
        REQUIRE(sprite_dx(sprt2) == 0.0);

        select_sprite_pack("default");
        call_for_all_sprites(test_sprite_function);
        REQUIRE(sprite_dx(sprt) == 90.0);
        REQUIRE(sprite_dx(sprt2) == 10.0);
        free_sprite(sprt);
        free_sprite(sprt2);
    }
}
void test_sprite_arrived_event(void *s, int evt)
{
    sprite_event_kind event = static_cast<sprite_event_kind>(evt);
    sprite sprt = static_cast<sprite>(s);

    switch (event)
    {
    case SPRITE_ARRIVED_EVENT:
        sprite_set_mass(sprt, 75.0f);
        break;
    case SPRITE_ANIMATION_ENDED_EVENT:
        sprite_set_mass(sprt, 85.0f);
        break;
    case SPRITE_TOUCHED_EVENT:
        sprite_set_mass(sprt, 95.0f);
        break;
    default: // SPRITE_CUSTOM_EVENT
        sprite_set_mass(sprt, 105.0f);
        break;
    };
}
TEST_CASE("sprite events can be created and handled", "[sprite]")
{
    SECTION("can trigger sprite event on single sprite")
    {
        sprite sprt = create_sprite("frog", frog_bmp);
        REQUIRE(has_sprite("frog"));
        REQUIRE(sprite_mass(sprt) == 1.0f);
        SECTION("can add sprite event")
        {
            sprite_call_on_event(sprt, test_sprite_arrived_event);
        }
        update_sprite(sprt);
        REQUIRE(sprite_mass(sprt) == 85.0f);
        free_sprite(sprt);
    }
    SECTION("can remove sprite event on single sprite")
    {
        sprite sprt = create_sprite("frog2", frog_bmp);
        REQUIRE(has_sprite("frog2"));
        REQUIRE(sprite_mass(sprt) == 1.0f);
        SECTION("can confirm that event is functioning")
        {
            sprite_call_on_event(sprt, test_sprite_arrived_event);
            update_sprite(sprt);
            REQUIRE(sprite_mass(sprt) == 85.0f);
        }
        sprite_set_mass(sprt, 1.0f);
        REQUIRE(sprite_mass(sprt) == 1.0f);
        sprite_stop_calling_on_event(sprt, test_sprite_arrived_event);
        update_sprite(sprt);
        REQUIRE(sprite_mass(sprt) == 1.0f);
        free_sprite(sprt);
    }
    SECTION("can trigger sprite event on all sprites")
    {
        sprite sprt = create_sprite("frog", frog_bmp);
        REQUIRE(has_sprite("frog"));
        sprite sprt2 = create_sprite("frog2", frog_bmp);
        REQUIRE(has_sprite("frog2"));
        REQUIRE(sprite_mass(sprt) == 1.0f);
        REQUIRE(sprite_mass(sprt2) == 1.0f);
        SECTION("can add sprite event")
        {
            call_on_sprite_event(test_sprite_arrived_event);
        }
        update_sprite(sprt);
        update_sprite(sprt2);
        REQUIRE(sprite_mass(sprt) == 85.0f);
        REQUIRE(sprite_mass(sprt2) == 85.0f);
        free_sprite(sprt);
        free_sprite(sprt2);
    }
    SECTION("can remove sprite event on all sprites")
    {
        sprite sprt = create_sprite("frog", frog_bmp);
        REQUIRE(has_sprite("frog"));
        sprite sprt2 = create_sprite("frog2", frog_bmp);
        REQUIRE(has_sprite("frog2"));
        REQUIRE(sprite_mass(sprt) == 1.0f);
        REQUIRE(sprite_mass(sprt2) == 1.0f);
        SECTION("can confirm that event is functioning")
        {
            call_on_sprite_event(test_sprite_arrived_event);
            update_sprite(sprt);
            update_sprite(sprt2);
            REQUIRE(sprite_mass(sprt) == 85.0f);
            REQUIRE(sprite_mass(sprt2) == 85.0f);
        }
        sprite_set_mass(sprt, 1.0f);
        sprite_set_mass(sprt2, 1.0f);
        REQUIRE(sprite_mass(sprt) == 1.0f);
        REQUIRE(sprite_mass(sprt2) == 1.0f);
        stop_calling_on_sprite_event(test_sprite_arrived_event);
        update_sprite(sprt);
        update_sprite(sprt2);
        REQUIRE(sprite_mass(sprt) == 1.0f);
        REQUIRE(sprite_mass(sprt2) == 1.0f);
        free_sprite(sprt);
        free_sprite(sprt2);
    }
}
TEST_CASE("bitmaps can be freed", "[bitmap]")
{
    free_bitmap(rocket_bmp);
    REQUIRE_FALSE(has_bitmap("rocket_sprt"));
    free_bitmap(frog_bmp);
    REQUIRE_FALSE(has_bitmap("frog"));
    free_bitmap(background_bmp);
    REQUIRE_FALSE(has_bitmap("background"));
}
