/**
 * @header  collisions
 * @author  Andrew Cain
 * @brief   SplashKit Collisions library allow you to perform tests between
 *          bitmaps, sprites and shapes to determin if a collision has occured.
 *
 * @attribute group  physics
 * @attribute static collisions
 */

#ifndef collisions_h
#define collisions_h

#include "images.h"
#include "matrix_2d.h"
#include "sprites.h"
#include "types.h"
namespace splashkit_lib
{
    /**
     *  This enumeration contains a list of directions that an
     *  object can collide with another object. For example, a
     *  collider object which is colliding with another object
     *  on its top edge would have a collision direction of TOP.
     *  
     *  @constant TOP           The top of the object
     *  @constant BOTTOM        The bottom of the object
     *  @constant LEFT          The left of the object
     *  @constant RIGHT         The right of the object
     *  @constant TOP_LEFT      The top left of the object
     *  @constant TOP_RIGHT     The top right of the object
     *  @constant BOTTOM_LEFT   The bottom left of the object
     *  @constant BOTTOM_RIGHT  The bottom right of the object
     *  @constant NONE          No collision
     */
    enum collision_direction
    {
        TOP,
        BOTTOM,
        LEFT,
        RIGHT,
        TOP_LEFT,
        TOP_RIGHT,
        BOTTOM_LEFT,
        BOTTOM_RIGHT,
        NONE,
    };
    
    /**
     * Tests if a bitmap drawn using the passed in translation matrix would draw a pixel
     * at the passed in point. Use to check collisions between a point and a bitmap.
     *
     * @param bmp           The bitmap to test.
     * @param translation   The translation matrix that represents the position, scale,
     *                      and rotation of the bitmap when it is drawn.
     * @param pt            The point in the resulting drawing that is being tested.
     * @returns             True if drawing the bitmap, using the passed in translation,
     *                      will draw a pixel at the indicated point.
     *
     * @attribute suffix    with_translation
     *
     * @attribute class bitmap
     * @attribute method point_collision
     */
    bool bitmap_point_collision(bitmap bmp, const matrix_2d& translation, const point_2d& pt);

    /**
     * Tests if a bitmap drawn at the `bmp_pt` point would draw a pixel
     * at point `pt`. Use to check collisions between a point and a bitmap.
     *
     * @param bmp           The bitmap to test.
     * @param bmp_pt        The point where the bitmap is drawn.
     * @param pt            The point in the resulting drawing that is being tested.
     * @returns             True if drawing the bitmap, at `bmp_pt`,
     *                      will draw a pixel at the indicated point (`pt`).
     *
     * @attribute suffix    at_point
     *
     * @attribute class bitmap
     * @attribute method point_collision
     */
    bool bitmap_point_collision(bitmap bmp, const point_2d &bmp_pt, const point_2d& pt);

    /**
     * Tests if a bitmap drawn at x,y would draw a pixel at the passed in point. Use 
     * to check collisions between a point and a bitmap.
     *
     * @param bmp   The bitmap to test.
     * @param bmp_x The x location where the bitmap is drawn
     * @param bmp_y The y location where the bitmap is drawn
     * @param  x    The x location of the point to test
     * @param  y    The y location of the point to test
     * @returns     True if drawing the bitmap, at the indicated location,
     *              will draw a pixel at the indicated point.
     *
     * @attribute class bitmap
     * @attribute method point_collision
     */
    bool bitmap_point_collision(bitmap bmp, double bmp_x, double bmp_y, double x, double y);

    /**
     * Tests if a cell of a bitmap drawn at x,y would draw a pixel at the passed in point. Use
     * to check collisions between a point and a bitmap.
     *
     * @param bmp           The bitmap to test
     * @param cell          The cell of the bitmap to test
     * @param bmp_pt        The point where the bitmap is drawn.
     * @param pt            The point in the resulting drawing that is being tested.
     * @returns             True if drawing the bitmap cell, at the indicated location,
     *                      will draw a pixel at the indicated point.
     *
     * @attribute class bitmap
     * @attribute method point_collision
     *
     * @attribute suffix    for_cell_at_point
     */
    bool bitmap_point_collision(bitmap bmp, int cell, const point_2d &bmp_pt, const point_2d& pt);

    /**
     * Tests if a cell of a bitmap drawn at x,y would draw a pixel at the passed in point. Use
     * to check collisions between a point and a bitmap.
     *
     * @param bmp   The bitmap to test
     * @param cell  The cell of the bitmap to test
     * @param bmp_x The x location where the bitmap is drawn
     * @param bmp_y The y location where the bitmap is drawn
     * @param  x    The x location of the point to test
     * @param  y    The y location of the point to test
     * @returns     True if drawing the bitmap cell, at the indicated location,
     *              will draw a pixel at the indicated point.
     *
     * @attribute class bitmap
     * @attribute method point_collision
     *
     * @attribute suffix    for_cell
     */
    bool bitmap_point_collision(bitmap bmp, int cell, double bmp_x, double bmp_y, double x, double y);
    
    /**
     * Tests if a bitmap cell drawn using the passed in translation matrix would draw a pixel
     * at the passed in point.
     *
     * @param bmp           The bitmap to test.
     * @param cell          The cell of the bitmap to check.
     * @param translation   The translation matrix that represents the position, scale,
     *                      and rotation of the bitmap when it is drawn.
     * @param pt            The point in the resulting drawing that is being tested.
     * @returns             True if drawing the bitmap, using the passed in translation,
     *                      will draw a pixel at the indicated point.
     *
     * @attribute suffix    for_cell_with_translation
     *
     * @attribute class bitmap
     * @attribute method point_collision
     */
    bool bitmap_point_collision(bitmap bmp, int cell, const matrix_2d& translation, const point_2d& pt);

    /**
     * Tests if a bitmap cell drawn using a passed in translation, will
     * intersect with a rectangle. You can use this to detect collisions between
     * bitmaps and rectangles.
     *
     * @param  bmp         The bitmap to test
     * @param  cell        The cell of the bitmap to check
     * @param  translation The matrix used to transfrom the bitmap when drawing
     * @param  rect        The rectangle to test
     * @return             True if a drawn pixel in the cell of the bitmap will
     *                     intersect with `rect` when drawn.
     *
     * @attribute suffix    for_cell_with_translation
     *
     * @attribute class bitmap
     * @attribute method rectangle_collision
     */
    bool bitmap_rectangle_collision(bitmap bmp, int cell, const matrix_2d& translation, const rectangle& rect);

    /**
     * Tests if a bitmap cell drawn at `pt` would intersect with a rectangle.
     *
     * @param  bmp  The bitmap to test
     * @param  cell The cell of the bitmap to check
     * @param  pt   The location where the bitmap is drawn
     * @param  rect The rectangle to test
     * @return      True if a drawn pixel in the cell of the bitmap will
     *              intersect with `rect` when drawn.
     *
     * @attribute suffix    for_cell_at_point
     *
     * @attribute class bitmap
     * @attribute method rectangle_collision
     */
    bool bitmap_rectangle_collision(bitmap bmp, int cell, const point_2d& pt, const rectangle& rect);

    /**
     * Tests if a cell of the bitmap drawn at `x`, `y` would intersect with a rectangle.
     *
     * @param  bmp  The bitmap to test
     * @param  cell The cell of the bitmap to check
     * @param  x    The x location where the bitmap is drawn
     * @param  y    The y location where the bitmap is drawn
     * @param  rect The rectangle to test
     * @return      True if a drawn pixel in the bitmap will
     *              intersect with `rect` when drawn.
     *
     * @attribute suffix    for_cell
     *
     * @attribute class bitmap
     * @attribute method rectangle_collision
     */
    bool bitmap_rectangle_collision(bitmap bmp, int cell, double x, double y, const rectangle& rect);
    
    /**
     * Tests if a bitmap drawn at `x`, `y` would intersect with a rectangle.
     *
     * @param  bmp  The bitmap to test
     * @param  x    The x location where the bitmap is drawn
     * @param  y    The y location where the bitmap is drawn
     * @param  rect The rectangle to test
     * @return      True if a drawn pixel in the bitmap will
     *              intersect with `rect` when drawn.
     *
     * @attribute class bitmap
     * @attribute method rectangle_collision
     */
    bool bitmap_rectangle_collision(bitmap bmp, double x, double y, const rectangle& rect);
    
    /**
     * Tests if a bitmap drawn at `pt` would intersect with a rectangle.
     *
     * @param  bmp  The bitmap to test
     * @param  pt   The location where the bitmap is drawn
     * @param  rect The rectangle to test
     * @return      True if a drawn pixel in the cell of the bitmap will
     *              intersect with `rect` when drawn.
     *
     * @attribute suffix    at_point
     *
     * @attribute class bitmap
     * @attribute method rectangle_collision
     */
    bool bitmap_rectangle_collision(bitmap bmp, const point_2d& pt, const rectangle& rect);
    
    
    /**
     * Tests if a bitmap cell drawn using a passed in translation, will
     * intersect with a circle. You can use this to detect collisions between
     * bitmaps and circles.
     *
     * @param  bmp         The bitmap to test
     * @param  cell        The cell of the bitmap to check
     * @param  translation The matrix used to transfrom the bitmap when drawing
     * @param  circ        The circle to test
     * @return             True if a drawn pixel in the cell of the bitmap will
     *                     intersect with `circ` when drawn.
     *
     * @attribute suffix    for_cell_with_translation
     *
     * @attribute class bitmap
     * @attribute method circle_collision
     */
    bool bitmap_circle_collision(bitmap bmp, int cell, const matrix_2d& translation, const circle& circ);
    
    /**
     * Tests if a bitmap cell drawn at `pt` would intersect with a circle.
     *
     * @param  bmp  The bitmap to test
     * @param  cell The cell of the bitmap to check
     * @param  pt   The location where the bitmap is drawn
     * @param  circ The circle to test
     * @return      True if a drawn pixel in the cell of the bitmap will
     *              intersect with `circ` when drawn.
     *
     * @attribute suffix    for_cell_at_point
     *
     * @attribute class bitmap
     * @attribute method circle_collision
     */
    bool bitmap_circle_collision(bitmap bmp, int cell, const point_2d& pt, const circle& circ);
    
    /**
     * Tests if a bitmap cell drawn at `x`, `y` would intersect with a circle.
     *
     * @param  bmp  The bitmap to test
     * @param  cell The cell of the bitmap to check
     * @param  x    The x location where the bitmap is drawn
     * @param  y    The y location where the bitmap is drawn
     * @param  circ The circle to test
     * @return      True if a drawn pixel in the bitmap will
     *              intersect with `circ` when drawn.
     *
     * @attribute suffix    for_cell
     *
     * @attribute class bitmap
     * @attribute method circle_collision
     */
    bool bitmap_circle_collision(bitmap bmp, int cell, double x, double y, const circle& circ);
    
    /**
     * Tests if a bitmap drawn at `x`, `y` would intersect with a circle.
     *
     * @param  bmp  The bitmap to test
     * @param  x    The x location where the bitmap is drawn
     * @param  y    The y location where the bitmap is drawn
     * @param  circ The circle to test
     * @return      True if a drawn pixel in the bitmap will
     *              intersect with `circ` when drawn.
     *
     * @attribute class bitmap
     * @attribute method circle_collision
     */
    bool bitmap_circle_collision(bitmap bmp, double x, double y, const circle& circ);
    
    /**
     * Tests if a bitmap drawn at `pt` would intersect with a circle.
     *
     * @param  bmp  The bitmap to test
     * @param  pt   The location where the bitmap is drawn
     * @param  circ The circle to test
     * @return      True if a drawn pixel in the cell of the bitmap will
     *              intersect with `circ` when drawn.
     *
     * @attribute suffix    at_point
     *
     * @attribute class bitmap
     * @attribute method circle_collision
     */
    bool bitmap_circle_collision(bitmap bmp, const point_2d& pt, const circle& circ);

    /**
     * Tests if a bitmap cell drawn using a passed in translation, will
     * intersect with a triangle. You can use this to detect collisions between
     * bitmaps and triangles.
     *
     * @param  bmp         The bitmap to test
     * @param  cell        The cell of the bitmap to check
     * @param  translation The matrix used to transfrom the bitmap when drawing
     * @param  tri         The triangle to test
     * @return             True if a drawn pixel in the cell of the bitmap will
     *                     intersect with `tri` when drawn.
     *
     * @attribute suffix    for_cell_with_translation
     *
     * @attribute class bitmap
     * @attribute method triangle_collision
     */
    bool bitmap_triangle_collision(bitmap bmp, int cell, const matrix_2d &translation, const triangle &tri);

    /**
     * Tests if a bitmap cell drawn at `pt` would intersect with a triangle.
     *
     * @param  bmp  The bitmap to test
     * @param  cell The cell of the bitmap to check
     * @param  pt   The location where the bitmap is drawn
     * @param  tri  The triangle to test
     * @return      True if a drawn pixel in the cell of the bitmap will
     *              intersect with `tri` when drawn.
     *
     * @attribute suffix    for_cell_at_point
     *
     * @attribute class bitmap
     * @attribute method triangle_collision
     */
    bool bitmap_triangle_collision(bitmap bmp, int cell, const point_2d& pt, const triangle &tri);

    /**
     * Tests if a bitmap cell drawn at `x`, `y` would intersect with a triangle.
     *
     * @param  bmp  The bitmap to test
     * @param  cell The cell of the bitmap to check
     * @param  x    The x location where the bitmap is drawn
     * @param  y    The y location where the bitmap is drawn
     * @param  tri  The triangle to test
     * @return      True if a drawn pixel in the bitmap will
     *              intersect with `tri` when drawn.
     *
     * @attribute suffix    for_cell
     *
     * @attribute class bitmap
     * @attribute method triangle_collision
     */
    bool bitmap_triangle_collision(bitmap bmp, int cell, double x, double y, const triangle &tri);

    /**
     * Tests if a bitmap drawn at `x`, `y` would intersect with a triangle.
     *
     * @param  bmp  The bitmap to test
     * @param  x    The x location where the bitmap is drawn
     * @param  y    The y location where the bitmap is drawn
     * @param  tri  The triangle to test
     * @return      True if a drawn pixel in the bitmap will
     *              intersect with `tri` when drawn.
     *
     * @attribute class bitmap
     * @attribute method triangle_collision
     */
    bool bitmap_triangle_collision(bitmap bmp, double x, double y, const triangle &tri);

    /**
     * Tests if a bitmap drawn at `pt` would intersect with a triangle.
     *
     * @param  bmp  The bitmap to test
     * @param  pt   The location where the bitmap is drawn
     * @param  tri  The triangle to test
     * @return      True if a drawn pixel in the cell of the bitmap will
     *              intersect with `tri` when drawn.
     *
     * @attribute suffix    at_point
     *
     * @attribute class bitmap
     * @attribute method triangle_collision
     */
    bool bitmap_triangle_collision(bitmap bmp, const point_2d& pt, const triangle &tri);

    /**
     * Tests if a bitmap cell drawn using a passed in translation, will
     * intersect with a quad. You can use this to detect collisions between
     * bitmaps and quads.
     *
     * @param  bmp         The bitmap to test
     * @param  cell        The cell of the bitmap to check
     * @param  translation The matrix used to transfrom the bitmap when drawing
     * @param  q           The quad to test
     * @return             True if a drawn pixel in the cell of the bitmap will
     *                     intersect with `q` when drawn.
     *
     * @attribute suffix    for_cell_with_translation
     *
     * @attribute class bitmap
     * @attribute method quad_collision
     */
    bool bitmap_quad_collision(bitmap bmp, int cell, const matrix_2d &translation, const quad &q);

    /**
     * Tests if a bitmap cell drawn at `pt` would intersect with a quad.
     *
     * @param  bmp  The bitmap to test
     * @param  cell The cell of the bitmap to check
     * @param  pt   The location where the bitmap is drawn
     * @param  q    The quad to test
     * @return      True if a drawn pixel in the cell of the bitmap will
     *              intersect with `q` when drawn.
     *
     * @attribute suffix    for_cell_at_point
     *
     * @attribute class bitmap
     * @attribute method quad_collision
     */
    bool bitmap_quad_collision(bitmap bmp, int cell, const point_2d& pt, const quad &q);

    /**
     * Tests if a bitmap cell drawn at `x`, `y` would intersect with a quad.
     *
     * @param  bmp  The bitmap to test
     * @param  cell The cell of the bitmap to check
     * @param  x    The x location where the bitmap is drawn
     * @param  y    The y location where the bitmap is drawn
     * @param  q    The quad to test
     * @return      True if a drawn pixel in the bitmap will
     *              intersect with `q` when drawn.
     *
     * @attribute suffix    for_cell
     *
     * @attribute class bitmap
     * @attribute method quad_collision
     */
    bool bitmap_quad_collision(bitmap bmp, int cell, double x, double y, const quad &q);

    /**
     * Tests if a bitmap drawn at `x`, `y` would intersect with a quad.
     *
     * @param  bmp  The bitmap to test
     * @param  x    The x location where the bitmap is drawn
     * @param  y    The y location where the bitmap is drawn
     * @param  q    The quad to test
     * @return      True if a drawn pixel in the bitmap will
     *              intersect with `q` when drawn.
     *
     * @attribute class bitmap
     * @attribute method quad_collision
     */
    bool bitmap_quad_collision(bitmap bmp, double x, double y, const quad &q);

    /**
     * Tests if a bitmap drawn at `pt` would intersect with a quad.
     *
     * @param  bmp  The bitmap to test
     * @param  pt   The location where the bitmap is drawn
     * @param  q    The quad to test
     * @return      True if a drawn pixel in the cell of the bitmap will
     *              intersect with `q` when drawn.
     *
     * @attribute suffix    at_point
     *
     * @attribute class bitmap
     * @attribute method quad_collision
     */
    bool bitmap_quad_collision(bitmap bmp, const point_2d& pt, const quad &q);
    
    /**
     * Tests if a sprite will collide with a bitmap drawn at the indicated
     * location.
     *
     * @param  s    The sprite to test
     * @param  bmp  The bitmap to test
     * @param  cell The cell of the bitmap to check
     * @param  x    The x location where the bitmap is drawn
     * @param  y    The y location where the bitmap is drawn
     * @return      True if the sprite collides with the bitmap cell when drawn
     *              at the indicated location.
     *
     * @attribute suffix    with_cell
     *
     * @attribute class sprite
     * @attribute method bitmap_collision
     */
    bool sprite_bitmap_collision(sprite s, bitmap bmp, int cell, double x, double y);

    /**
     * Tests if a sprite will collide with a bitmap drawn at the indicated
     * location.
     *
     * @param  s    The sprite to test
     * @param  bmp  The bitmap to test
     * @param  cell The cell of the bitmap to check
     * @param  pt   The point where the bitmap is drawn
     * @return      True if the sprite collides with the bitmap cell when drawn
     *              at the indicated location.
     *
     * @attribute suffix    with_cell_at_point
     *
     * @attribute class sprite
     * @attribute method bitmap_collision
     */
    bool sprite_bitmap_collision(sprite s, bitmap bmp, int cell, const point_2d &pt);

    /**
     * Tests if a sprite will collide with a bitmap drawn at the indicated
     * location.
     *
     * @param  s    The sprite to test
     * @param  bmp  The bitmap to test
     * @param  x    The x location where the bitmap is drawn
     * @param  y    The y location where the bitmap is drawn
     * @return      True if the sprite collides with the bitmap when drawn
     *              at the indicated location.
     *
     * @attribute class sprite
     * @attribute method bitmap_collision
     */
    bool sprite_bitmap_collision(sprite s, bitmap bmp, double x, double y);

    /**
     * Tests if a sprite is drawn at a given point.
     *
     * @param  s  The sprite to test
     * @param  pt The point to check
     * @return    True if the sprite it drawn at the indicated point
     *
     * @attribute class sprite
     * @attribute method point_collision
     */
    bool sprite_point_collision(sprite s, const point_2d& pt);

    /**
     * Tests if a sprite is drawn within an given area (rectangle).
     *
     * @param  s    The sprite to test
     * @param  rect The rectangle to check
     * @return      True if the sprite it drawn in the rectangle area
     *
     * @attribute class sprite
     * @attribute method rectangle_collision
     */
    bool sprite_rectangle_collision(sprite s, const rectangle& rect);

    /**
     * Tests if a sprite is drawn within an given area (circle).
     *
     * @param  s    The sprite to test
     * @param  c    The circle to check
     * @return      True if the sprite it drawn in the circle area
     *
     * @attribute class sprite
     * @attribute method circle_collision
     */
    bool sprite_circle_collision(sprite s, const circle &c);

    /**
     * Tests if a sprite is drawn within an given area (triangle).
     *
     * @param  s    The sprite to test
     * @param  t    The triangle to check
     * @return      True if the sprite it drawn in the triangle area
     *
     * @attribute class sprite
     * @attribute method triangle_collision
     */
    bool sprite_triangle_collision(sprite s, const triangle &t);

    /**
     * Tests if a sprite is drawn within an given area (quad).
     *
     * @param  s    The sprite to test
     * @param  q    The quad to check
     * @return      True if the sprite it drawn in the quad area
     *
     * @attribute class sprite
     * @attribute method quad_collision
     */
    bool sprite_quad_collision(sprite s, const quad &q);

    /**
     * Tests if two given sprites `s1` and `s2` are collided
     * @param  s1 the first `sprite` to test
     * @param  s2 the second `sprite` to test
     *
     * @returns return `true` if both `s1` and `s2` are colliding, false otherwise.
     *
     * @attribute class   sprite
     * @attribute method  sprite_collision
     * @attribute self    s1
     */
    bool sprite_collision(sprite s1, sprite s2);

    /**
     * Check if two bitmaps collide, based on their cell and transform
     * matricies.
     *
     * @param  bmp1    The first bitmap
     * @param  cell1   The cell of the first bitmap.
     * @param  matrix1 The transformation for the first matrix
     * @param  bmp2    The second bitmap
     * @param  cell2   The cell of the second bitmap.
     * @param  matrix2 The transformation for the second matrix
     * @return         True if pixels in the two bitmaps would collide/overlap
     *
     * @attribute suffix    for_cells_with_translations
     *
     * @attribute class bitmap
     * @attribute method bitmap_collision
     */
    bool bitmap_collision(bitmap bmp1, int cell1, const matrix_2d &matrix1, bitmap bmp2, int cell2, const matrix_2d &matrix2);

    /**
     * Check if two bitmaps collide.
     *
     * @param  bmp1   The first bitmap
     * @param  cell1  The cell of the first bitmap.
     * @param  pt1    The point where bitmap 1 is drawn
     * @param  bmp2   The second bitmap
     * @param  cell2  The cell of the second bitmap.
     * @param  pt2    The point where bitmap 2 is drawn
     * @return        True if pixels in the two bitmaps would collide/overlap
     *
     * @attribute suffix    for_cells_at_points
     *
     * @attribute class bitmap
     * @attribute method bitmap_collision
     */
    bool bitmap_collision(bitmap bmp1, int cell1, const point_2d &pt1, bitmap bmp2, int cell2, const point_2d &pt2);

    /**
     * Check if two bitmaps collide.
     *
     * @param  bmp1   The first bitmap
     * @param  cell1  The cell of the first bitmap.
     * @param  x1     The x location where the first bitmap is drawn
     * @param  y1     The y location where the first bitmap is drawn
     * @param  bmp2   The second bitmap
     * @param  cell2  The cell of the second bitmap.
     * @param  x2     The x location where the second bitmap is drawn
     * @param  y2     The y location where the second bitmap is drawn
     * @return        True if pixels in the two bitmaps would collide/overlap
     *
     * @attribute suffix    for_cells
     *
     * @attribute class bitmap
     * @attribute method bitmap_collision
     */
    bool bitmap_collision(bitmap bmp1, int cell1, double x1, double y1, bitmap bmp2, int cell2, double x2, double y2);

    /**
     * Check if two bitmaps collide.
     *
     * @param  bmp1   The first bitmap
     * @param  pt1    The point where bitmap 1 is drawn
     * @param  bmp2   The second bitmap
     * @param  pt2    The point where bitmap 2 is drawn
     * @return        True if pixels in the two bitmaps would collide/overlap
     *
     * @attribute suffix    at_points
     *
     * @attribute class bitmap
     * @attribute method bitmap_collision
     */
    bool bitmap_collision(bitmap bmp1, const point_2d &pt1, bitmap bmp2, const point_2d &pt2);

    /**
     * Check if two bitmaps collide.
     *
     * @param  bmp1   The first bitmap
     * @param  x1     The x location where the first bitmap is drawn
     * @param  y1     The y location where the first bitmap is drawn
     * @param  bmp2   The second bitmap
     * @param  x2     The x location where the second bitmap is drawn
     * @param  y2     The y location where the second bitmap is drawn
     * @return        True if pixels in the two bitmaps would collide/overlap
     *
     * @attribute class bitmap
     * @attribute method bitmap_collision
     */
    bool bitmap_collision(bitmap bmp1, double x1, double y1, bitmap bmp2, double x2, double y2);

    /**
     * Returns the direction of the collision between two sprites
     * relative to the collider sprite. If the sprites are not colliding,
     * this function will return NONE.
     * 
     * @param collider  The sprite that is colliding
     * @param collidee  The sprite that is being collided with
     * @return          The direction of the collision relative to the collider sprite.
     *                  If the sprites are not colliding, this function will return NONE.
     * 
     * @attribute class     sprite
     * @attribute suffix    between_sprites
     */
    collision_direction calculate_collision_direction(const sprite collider, const sprite collidee);

    /**
     * Returns the direction of the collision between a sprite
     * and a rectangle relative to the sprite. If the sprite and
     * rectangle are not colliding, this function will return NONE.
     * 
     * @param collider  The sprite that is colliding
     * @param collidee  The rectangle that is being collided with
     * @return          The direction of the collision relative to the sprite.
     *                  If the sprite and rectangle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     sprite
     * @attribute suffix    between_sprite_and_rectangle
     */
    collision_direction calculate_collision_direction(const sprite collider, const rectangle& collidee);

    /**
     * Returns the direction of the collision between a sprite
     * and a circle relative to the sprite. If the sprite and
     * circle are not colliding, this function will return NONE.
     * 
     * @param collider  The sprite that is colliding
     * @param collidee  The circle that is being collided with
     * @return          The direction of the collision relative to the sprite.
     *                  If the sprite and circle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     sprite
     * @attribute suffix    between_sprite_and_circle
     */
    collision_direction calculate_collision_direction(const sprite collider, const circle& collidee);

    /**
     * Returns the direction of the collision between a sprite
     * and a triangle relative to the sprite. If the sprite and
     * triangle are not colliding, this function will return NONE.
     * 
     * @param collider  The sprite that is colliding
     * @param collidee  The triangle that is being collided with
     * @return          The direction of the collision relative to the sprite.
     *                  If the sprite and triangle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     sprite
     * @attribute suffix    between_sprite_and_triangle
     */
    collision_direction calculate_collision_direction(const sprite collider, const triangle& collidee);

    /**
     * Returns the direction of the collision between a sprite
     * and a quad relative to the sprite. If the sprite and
     * quad are not colliding, this function will return NONE.
     * 
     * @param collider  The sprite that is colliding
     * @param collidee  The quad that is being collided with
     * @return          The direction of the collision relative to the sprite.
     *                  If the sprite and quad are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     sprite
     * @attribute suffix    between_sprite_and_quad
     */
    collision_direction calculate_collision_direction(const sprite collider, const quad& collidee);

    /**
     * Returns the direction of the collision between a rectangle
     * and a sprite relative to the rectangle. If the rectangle and
     * sprite are not colliding, this function will return NONE.
     * 
     * @param collider  The rectangle that is colliding
     * @param collidee  The sprite that is being collided with
     * @return          The direction of the collision relative to the rectangle.
     *                  If the rectangle and sprite are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     rectangle
     * @attribute suffix    between_rectangle_and_sprite
     */
    collision_direction calculate_collision_direction(const rectangle& collider, const sprite collidee);

    /**
     * Returns the direction of the collision between a collider rectangle
     * and a collidee rectangle relative to the collider rectangle. If the rectangles are not
     * colliding, this function will return NONE.
     * 
     * @param collider  The rectangle that is colliding
     * @param collidee  The rectangle that is being collided with
     * @return          The direction of the collision relative to the collider rectangle.
     *                  If the rectangles are not colliding, this function will return NONE.
     * 
     * @attribute class     rectangle
     * @attribute suffix    between_rectangles
     */
    collision_direction calculate_collision_direction(const rectangle& collider, const rectangle& collidee);

    /**
     * Returns the direction of the collision between a rectangle
     * and a circle relative to the rectangle. If the rectangle and
     * sprite are not colliding, this function will return NONE.
     * 
     * @param collider  The rectangle that is colliding
     * @param collidee  The circle that is being collided with
     * @return          The direction of the collision relative to the rectangle.
     *                  If the rectangle and circle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     rectangle
     * @attribute suffix    between_rectangle_and_circle
     */
    collision_direction calculate_collision_direction(const rectangle& collider, const circle& collidee);

    /**
     * Returns the direction of the collision between a rectangle
     * and a triangle relative to the rectangle. If the rectangle and
     * sprite are not colliding, this function will return NONE.
     * 
     * @param collider  The rectangle that is colliding
     * @param collidee  The triangle that is being collided with
     * @return          The direction of the collision relative to the rectangle.
     *                  If the rectangle and triangle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     rectangle
     * @attribute suffix    between_rectangle_and_triangle
     */
    collision_direction calculate_collision_direction(const rectangle& collider, const triangle& collidee);

    /**
     * Returns the direction of the collision between a rectangle
     * and a quad relative to the rectangle. If the rectangle and
     * sprite are not colliding, this function will return NONE.
     * 
     * @param collider  The rectangle that is colliding
     * @param collidee  The quad that is being collided with
     * @return          The direction of the collision relative to the rectangle.
     *                  If the rectangle and quad are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     rectangle
     * @attribute suffix    between_rectangle_and_quad
     */
    collision_direction calculate_collision_direction(const rectangle& collider, const quad& collidee);

    /**
     * Returns the direction of the collision between a circle
     * and a sprite relative to the circle. If the circle and
     * sprite are not colliding, this function will return NONE.
     * 
     * @param collider  The circle that is colliding
     * @param collidee  The sprite that is being collided with
     * @return          The direction of the collision relative to the circle.
     *                  If the circle and sprite are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     circle
     * @attribute suffix    between_circle_and_sprite
     */
    collision_direction calculate_collision_direction(const circle& collider, const sprite collidee);

    /**
     * Returns the direction of the collision between a circle
     * and a rectangle relative to the circle. If the circle and
     * rectangle are not colliding, this function will return NONE.
     * 
     * @param collider  The circle that is colliding
     * @param collidee  The rectangle that is being collided with
     * @return          The direction of the collision relative to the circle.
     *                  If the circle and rectangle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     circle
     * @attribute suffix    between_circle_and_rectangle
     */
    collision_direction calculate_collision_direction(const circle& collider, const rectangle& collidee);

    /**
     * Returns the direction of the collision between a collider circle
     * and a collidee circle relative to the collider circle. If the circles are not
     * colliding, this function will return NONE.
     * 
     * @param collider  The circle that is colliding
     * @param collidee  The circle that is being collided with
     * @return          The direction of the collision relative to the collider circle.
     *                  If the circles are not colliding, this function will return NONE.
     * 
     * @attribute class     circle
     * @attribute suffix    between_circles
     */
    collision_direction calculate_collision_direction(const circle& collider, const circle& collidee);

    /**
     * Returns the direction of the collision between a circle
     * and a triangle relative to the circle. If the circle and
     * triangle are not colliding, this function will return NONE.
     * 
     * @param collider  The circle that is colliding
     * @param collidee  The triangle that is being collided with
     * @return          The direction of the collision relative to the circle.
     *                  If the circle and triangle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     circle
     * @attribute suffix    between_circle_and_triangle
     */
    collision_direction calculate_collision_direction(const circle& collider, const triangle& collidee);

    /**
     * Returns the direction of the collision between a circle
     * and a quad relative to the circle. If the circle and
     * quad are not colliding, this function will return NONE.
     * 
     * @param collider  The circle that is colliding
     * @param collidee  The quad that is being collided with
     * @return          The direction of the collision relative to the circle.
     *                  If the circle and quad are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     circle
     * @attribute suffix    between_circle_and_quad
     */
    collision_direction calculate_collision_direction(const circle& collider, const quad& collidee);

    /**
     * Returns the direction of the collision between a triangle
     * and a sprite relative to the triangle. If the triangle and
     * sprite are not colliding, this function will return NONE.
     * 
     * @param collider  The triangle that is colliding
     * @param collidee  The sprite that is being collided with
     * @return          The direction of the collision relative to the triangle.
     *                  If the triangle and sprite are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     triangle
     * @attribute suffix    between_triangle_and_sprite
     */
    collision_direction calculate_collision_direction(const triangle& collider, const sprite collidee);

    /**
     * Returns the direction of the collision between a triangle
     * and a rectangle relative to the triangle. If the triangle and
     * rectangle are not colliding, this function will return NONE.
     * 
     * @param collider  The triangle that is colliding
     * @param collidee  The rectangle that is being collided with
     * @return          The direction of the collision relative to the triangle.
     *                  If the triangle and rectangle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     triangle
     * @attribute suffix    between_triangle_and_rectangle
     */
    collision_direction calculate_collision_direction(const triangle& collider, const rectangle& collidee);

    /**
     * Returns the direction of the collision between a triangle
     * and a circle relative to the triangle. If the triangle and
     * circle are not colliding, this function will return NONE.
     * 
     * @param collider  The triangle that is colliding
     * @param collidee  The circle that is being collided with
     * @return          The direction of the collision relative to the triangle.
     *                  If the triangle and circle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     triangle
     * @attribute suffix    between_triangle_and_circle
     */
    collision_direction calculate_collision_direction(const triangle& collider, const circle& collidee);

    /**
     * Returns the direction of the collision between a collider triangle
     * and a collidee triangle relative to the collider triangle. If the triangles are not
     * colliding, this function will return NONE.
     * 
     * @param collider  The triangle that is colliding
     * @param collidee  The triangle that is being collided with
     * @return          The direction of the collision relative to the collider triangle.
     *                  If the triangles are not colliding, this function will return NONE.
     * 
     * @attribute class     triangle
     * @attribute suffix    between_triangles
     */
    collision_direction calculate_collision_direction(const triangle& collider, const triangle& collidee);

    /**
     * Returns the direction of the collision between a triangle
     * and a quad relative to the triangle. If the triangle and
     * quad are not colliding, this function will return NONE.
     * 
     * @param collider  The triangle that is colliding
     * @param collidee  The quad that is being collided with
     * @return          The direction of the collision relative to the triangle.
     *                  If the triangle and quad are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     triangle
     * @attribute suffix    between_triangle_and_quad
     */
    collision_direction calculate_collision_direction(const triangle& collider, const quad& collidee);

    /**
     * Returns the direction of the collision between a quad
     * and a sprite relative to the quad. If the quad and
     * sprite are not colliding, this function will return NONE.
     * 
     * @param collider  The quad that is colliding
     * @param collidee  The sprite that is being collided with
     * @return          The direction of the collision relative to the quad.
     *                  If the quad and sprite are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     quad
     * @attribute suffix    between_quad_and_sprite
     */
    collision_direction calculate_collision_direction(const quad& collider, const sprite collidee);

    /**
     * Returns the direction of the collision between a quad
     * and a rectangle relative to the quad. If the quad and
     * rectangle are not colliding, this function will return NONE.
     * 
     * @param collider  The quad that is colliding
     * @param collidee  The rectangle that is being collided with
     * @return          The direction of the collision relative to the quad.
     *                  If the quad and rectangle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     quad
     * @attribute suffix    between_quad_and_rectangle
     */
    collision_direction calculate_collision_direction(const quad& collider, const rectangle& collidee);

    /**
     * Returns the direction of the collision between a quad
     * and a circle relative to the quad. If the quad and
     * circle are not colliding, this function will return NONE.
     * 
     * @param collider  The quad that is colliding
     * @param collidee  The circle that is being collided with
     * @return          The direction of the collision relative to the quad.
     *                  If the quad and circle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     quad
     * @attribute suffix    between_quad_and_circle
     */
    collision_direction calculate_collision_direction(const quad& collider, const circle& collidee);

    /**
     * Returns the direction of the collision between a quad
     * and a triangle relative to the quad. If the quad and
     * triangle are not colliding, this function will return NONE.
     * 
     * @param collider  The quad that is colliding
     * @param collidee  The triangle that is being collided with
     * @return          The direction of the collision relative to the quad.
     *                  If the quad and triangle are not colliding,
     *                  this function will return NONE.
     * 
     * @attribute class     quad
     * @attribute suffix    between_quad_and_triangle
     */
    collision_direction calculate_collision_direction(const quad& collider, const triangle& collidee);

    /**
     * Returns the direction of the collision between a collider quad
     * and a collidee quad relative to the collider quad. If the quads are not
     * colliding, this function will return NONE.
     * 
     * @param collider  The quad that is colliding
     * @param collidee  The quad that is being collided with
     * @return          The direction of the collision relative to the collider quad.
     *                  If the quads are not colliding, this function will return NONE.
     * 
     * @attribute class     quad
     * @attribute suffix    between_quads
     */
    collision_direction calculate_collision_direction(const quad& collider, const quad& collidee);

    /**
     * Resolves the collision between two sprites by moving the
     * collider sprite to the edge of the collidee sprite. The direction of the
     * resolution is determined by the `direction` parameter. If the sprites are not
     * colliding, this function will return false.
     * 
     * @param collider  The sprite which will be altered if there is a collision
     * @param collidee  The sprite which will not be altered
     * @param direction The direction of the collision relative to the collider sprite.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the sprites are colliding and the collision was resolved,
     *                  false if the sprites are not colliding
     * 
     * @atrribute class     sprite
     * @attribute suffix    between_sprites
     */
    bool resolve_collision(sprite collider, const sprite collidee, collision_direction direction);

    /**
     * Resolves the collision between a sprite and a rectangle by moving the
     * sprite to the edge of the rectangle. The direction of the
     * resolution is determined by the `direction` parameter. If the sprite and
     * rectangle are not colliding, this function will return false.
     * 
     * @param collider  The sprite which will be altered if there is a collision
     * @param collidee  The rectangle which will not be altered
     * @param direction The direction of the collision relative to the sprite.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the sprite and rectangle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     sprite
     * @attribute suffix    between_sprite_and_rectangle
     */
    bool resolve_collision(sprite collider, const rectangle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a sprite and a circle by moving the
     * sprite to the edge of the circle. The direction of the
     * resolution is determined by the `direction` parameter. If the sprite and
     * circle are not colliding, this function will return false.
     * 
     * @param collider  The sprite which will be altered if there is a collision
     * @param collidee  The circle which will not be altered
     * @param direction The direction of the collision relative to the sprite.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the sprite and circle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     sprite
     * @attribute suffix    between_sprite_and_circle
     */
    bool resolve_collision(sprite collider, const circle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a sprite and a triangle by moving the
     * sprite to the edge of the triangle. The direction of the
     * resolution is determined by the `direction` parameter. If the sprite and
     * triangle are not colliding, this function will return false.
     * 
     * @param collider  The sprite which will be altered if there is a collision
     * @param collidee  The triangle which will not be altered
     * @param direction The direction of the collision relative to the sprite.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the sprite and triangle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     sprite
     * @attribute suffix    between_sprite_and_triangle
     */
    bool resolve_collision(sprite collider, const triangle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a sprite and a quad by moving the
     * sprite to the edge of the quad. The direction of the
     * resolution is determined by the `direction` parameter. If the sprite and
     * quad are not colliding, this function will return false.
     * 
     * @param collider  The sprite which will be altered if there is a collision
     * @param collidee  The quad which will not be altered
     * @param direction The direction of the collision relative to the sprite.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the sprite and quad are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     sprite
     * @attribute suffix    between_sprite_and_quad
     */
    bool resolve_collision(sprite collider, const quad& collidee, collision_direction direction);

    /**
     * Resolves the collision between a rectangle and a sprite by moving the
     * rectangle to the edge of the sprite. The direction of the
     * resolution is determined by the `direction` parameter. If the rectangle and
     * sprite are not colliding, this function will return false.
     * 
     * @param collider  The rectangle which will be altered if there is a collision
     * @param collidee  The sprite which will not be altered
     * @param direction The direction of the collision relative to the rectangle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the rectangle and sprite are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     rectangle
     * @attribute suffix    between_rectangle_and_sprite
     */
    bool resolve_collision(rectangle& collider, const sprite collidee, collision_direction direction);

    /**
     * Resolves the collision between two rectangles by moving the
     * collider rectangle to the edge of the collidee rectangle. The direction of the
     * resolution is determined by the `direction` parameter. If the rectangles are not
     * colliding, this function will return false.
     * 
     * @param collider  The rectangle which will be altered if there is a collision
     * @param collidee  The rectangle which will not be altered
     * @param direction The direction of the collision relative to the collider rectangle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the rectangles are colliding and the collision was resolved,
     *                  false if the rectangles are not colliding
     * 
     * @atrribute class     rectangle
     * @attribute suffix    between_rectangles
     */
    bool resolve_collision(rectangle& collider, const rectangle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a rectangle and a circle by moving the
     * rectangle to the edge of the circle. The direction of the
     * resolution is determined by the `direction` parameter. If the rectangle and
     * circle are not colliding, this function will return false.
     * 
     * @param collider  The rectangle which will be altered if there is a collision
     * @param collidee  The circle which will not be altered
     * @param direction The direction of the collision relative to the rectangle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the rectangle and circle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     rectangle
     * @attribute suffix    between_rectangle_and_circle
     */
    bool resolve_collision(rectangle& collider, const circle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a rectangle and a triangle by moving the
     * rectangle to the edge of the triangle. The direction of the
     * resolution is determined by the `direction` parameter. If the rectangle and
     * triangle are not colliding, this function will return false.
     * 
     * @param collider  The rectangle which will be altered if there is a collision
     * @param collidee  The triangle which will not be altered
     * @param direction The direction of the collision relative to the rectangle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the rectangle and triangle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     rectangle
     * @attribute suffix    between_rectangle_and_triangle
     */
    bool resolve_collision(rectangle& collider, const triangle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a rectangle and a quad by moving the
     * rectangle to the edge of the quad. The direction of the
     * resolution is determined by the `direction` parameter. If the rectangle and
     * quad are not colliding, this function will return false.
     * 
     * @param collider  The rectangle which will be altered if there is a collision
     * @param collidee  The quad which will not be altered
     * @param direction The direction of the collision relative to the rectangle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the rectangle and quad are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     rectangle
     * @attribute suffix    between_rectangle_and_quad
     */
    bool resolve_collision(rectangle& collider, const quad& collidee, collision_direction direction);

    /**
     * Resolves the collision between a circle and a sprite by moving the
     * circle to the edge of the sprite. The direction of the
     * resolution is determined by the `direction` parameter. If the circle and
     * sprite are not colliding, this function will return false.
     * 
     * @param collider  The circle which will be altered if there is a collision
     * @param collidee  The sprite which will not be altered
     * @param direction The direction of the collision relative to the circle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the circle and sprite are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     circle
     * @attribute suffix    between_circle_and_sprite
     */
    bool resolve_collision(circle& collider, const sprite collidee, collision_direction direction);

    /**
     * Resolves the collision between a circle and a rectangle by moving the
     * circle to the edge of the rectangle. The direction of the
     * resolution is determined by the `direction` parameter. If the circle and
     * rectangle are not colliding, this function will return false.
     * 
     * @param collider  The circle which will be altered if there is a collision
     * @param collidee  The rectangle which will not be altered
     * @param direction The direction of the collision relative to the circle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the circle and rectangle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     circle
     * @attribute suffix    between_circle_and_rectangle
     */
    bool resolve_collision(circle& collider, const rectangle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a collider circle and a collidee circle by moving the
     * collider circle to the edge of the collidee circle. The direction of the
     * resolution is determined by the `direction` parameter. If the circles are not
     * colliding, this function will return false.
     * 
     * @param collider  The circle which will be altered if there is a collision
     * @param collidee  The circle which will not be altered
     * @param direction The direction of the collision relative to the collider circle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the circles are colliding and the collision was resolved,
     *                  false if the circles are not colliding
     * 
     * @atrribute class     circle
     * @attribute suffix    between_circles
     */
    bool resolve_collision(circle& collider, const circle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a circle and a triangle by moving the
     * circle to the edge of the triangle. The direction of the
     * resolution is determined by the `direction` parameter. If the circle and
     * triangle are not colliding, this function will return false.
     * 
     * @param collider  The circle which will be altered if there is a collision
     * @param collidee  The triangle which will not be altered
     * @param direction The direction of the collision relative to the circle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the circle and triangle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     circle
     * @attribute suffix    between_circle_and_triangle
     */
    bool resolve_collision(circle& collider, const triangle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a circle and a quad by moving the
     * circle to the edge of the quad. The direction of the
     * resolution is determined by the `direction` parameter. If the circle and
     * quad are not colliding, this function will return false.
     * 
     * @param collider  The circle which will be altered if there is a collision
     * @param collidee  The quad which will not be altered
     * @param direction The direction of the collision relative to the circle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the circle and quad are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     circle
     * @attribute suffix    between_circle_and_quad
     */
    bool resolve_collision(circle& collider, const quad& collidee, collision_direction direction);

    /**
     * Resolves the collision between a triangle and a sprite by moving the
     * triangle to the edge of the sprite. The direction of the
     * resolution is determined by the `direction` parameter. If the triangle and
     * sprite are not colliding, this function will return false.
     * 
     * @param collider  The triangle which will be altered if there is a collision
     * @param collidee  The sprite which will not be altered
     * @param direction The direction of the collision relative to the triangle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the triangle and sprite are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     triangle
     * @attribute suffix    between_triangle_and_sprite
     */
    bool resolve_collision(triangle& collider, const sprite collidee, collision_direction direction);

    /**
     * Resolves the collision between a triangle and a rectangle by moving the
     * triangle to the edge of the rectangle. The direction of the
     * resolution is determined by the `direction` parameter. If the triangle and
     * rectangle are not colliding, this function will return false.
     * 
     * @param collider  The triangle which will be altered if there is a collision
     * @param collidee  The rectangle which will not be altered
     * @param direction The direction of the collision relative to the triangle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the triangle and rectangle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     triangle
     * @attribute suffix    between_triangle_and_rectangle
     */
    bool resolve_collision(triangle& collider, const rectangle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a triangle and a circle by moving the
     * triangle to the edge of the circle. The direction of the
     * resolution is determined by the `direction` parameter. If the triangle and
     * circle are not colliding, this function will return false.
     * 
     * @param collider  The triangle which will be altered if there is a collision
     * @param collidee  The circle which will not be altered
     * @param direction The direction of the collision relative to the triangle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the triangle and circle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     triangle
     * @attribute suffix    between_triangle_and_circle
     */
    bool resolve_collision(triangle& collider, const circle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a collider triangle and a collidee triangle by moving the
     * collider triangle to the edge of the collidee triangle. The direction of the
     * resolution is determined by the `direction` parameter. If the triangles are not
     * colliding, this function will return false.
     * 
     * @param collider  The triangle which will be altered if there is a collision
     * @param collidee  The triangle which will not be altered
     * @param direction The direction of the collision relative to the collider triangle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the triangles are colliding and the collision was resolved,
     *                  false if the triangles are not colliding
     * 
     * @atrribute class     triangle
     * @attribute suffix    between_triangles
     */
    bool resolve_collision(triangle& collider, const triangle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a triangle and a quad by moving the
     * triangle to the edge of the quad. The direction of the
     * resolution is determined by the `direction` parameter. If the triangle and
     * quad are not colliding, this function will return false.
     * 
     * @param collider  The triangle which will be altered if there is a collision
     * @param collidee  The quad which will not be altered
     * @param direction The direction of the collision relative to the triangle.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the triangle and quad are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     triangle
     * @attribute suffix    between_triangle_and_quad
     */
    bool resolve_collision(triangle& collider, const quad& collidee, collision_direction direction);

    /**
     * Resolves the collision between a quad and a sprite by moving the
     * quad to the edge of the sprite. The direction of the
     * resolution is determined by the `direction` parameter. If the quad and
     * sprite are not colliding, this function will return false.
     * 
     * @param collider  The quad which will be altered if there is a collision
     * @param collidee  The sprite which will not be altered
     * @param direction The direction of the collision relative to the quad.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the quad and sprite are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     quad
     * @attribute suffix    between_quad_and_sprite
     */
    bool resolve_collision(quad& collider, const sprite collidee, collision_direction direction);

    /**
     * Resolves the collision between a quad and a rectangle by moving the
     * quad to the edge of the rectangle. The direction of the
     * resolution is determined by the `direction` parameter. If the quad and
     * rectangle are not colliding, this function will return false.
     * 
     * @param collider  The quad which will be altered if there is a collision
     * @param collidee  The rectangle which will not be altered
     * @param direction The direction of the collision relative to the quad.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the quad and rectangle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     quad
     * @attribute suffix    between_quad_and_rectangle
     */
    bool resolve_collision(quad& collider, const rectangle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a quad and a circle by moving the
     * quad to the edge of the circle. The direction of the
     * resolution is determined by the `direction` parameter. If the quad and
     * circle are not colliding, this function will return false.
     * 
     * @param collider  The quad which will be altered if there is a collision
     * @param collidee  The circle which will not be altered
     * @param direction The direction of the collision relative to the quad.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the quad and circle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     quad
     * @attribute suffix    between_quad_and_circle
     */
    bool resolve_collision(quad& collider, const circle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a quad and a triangle by moving the
     * quad to the edge of the triangle. The direction of the
     * resolution is determined by the `direction` parameter. If the quad and
     * triangle are not colliding, this function will return false.
     * 
     * @param collider  The quad which will be altered if there is a collision
     * @param collidee  The triangle which will not be altered
     * @param direction The direction of the collision relative to the quad.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the quad and triangle are colliding and the collision
     *                  was resolved, false if they are not colliding
     * 
     * @atrribute class     quad
     * @attribute suffix    between_quad_and_triangle
     */
    bool resolve_collision(quad& collider, const triangle& collidee, collision_direction direction);

    /**
     * Resolves the collision between a collider quad and a collidee quad by moving the
     * collider quad to the edge of the collidee quad. The direction of the
     * resolution is determined by the `direction` parameter. If the quads are not
     * colliding, this function will return false.
     * 
     * @param collider  The quad which will be altered if there is a collision
     * @param collidee  The quad which will not be altered
     * @param direction The direction of the collision relative to the collider quad.
     *                  If NONE is passed, the function will not resolve the collision.
     * @return          True if the quads are colliding and the collision was resolved,
     *                  false if the quads are not colliding
     * 
     * @atrribute class     quad
     * @attribute suffix    between_quads
     */
    bool resolve_collision(quad& collider, const quad& collidee, collision_direction direction);

}
#endif /* collisions_h */
