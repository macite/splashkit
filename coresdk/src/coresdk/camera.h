//
//  camera.hpp
//  splashkit
//
//  Created by Andrew Cain on 24/07/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#ifndef camera_hpp
#define camera_hpp

#include "geometry.h"

/// Returns the x location of the camera in game coordinates. This represents
/// the left most x value shown on the screen, with the right of the screen
/// being at camera x + screen width.
///
float camera_x();

/// Returns the y location of the camera in game coordinates. This represents
/// the stop most y value shown on the screen, with bottom of screen being
/// at camera y + screen height.
///
float camera_y();

/// Change the X position of the camera to a specified world coordinate. This
/// will then be the new left most position of the screen within the world.
///
void set_camera_x(float x);

/// Change the Y position of the camera to a specified world coordinate. This
/// will then be the new top most position of the screen within the world.
///
void set_camera_y(float y);

/// Change the position of the camera to a specified world coordinate. This
/// will then be the new top left most position of the screen within the world.
///
void set_camera_pos(point_2d pos);



//---------------------------------------------------------------------------
// World-To-Screen Translation
//---------------------------------------------------------------------------

/// Translate a world x value to the current screen x value which is based on
/// the camera position.
///
float to_screen_x(float world_x);

/// Translate a world y value to the current screen y value set by the camera.
///
float to_screen_y(float world_y);


//---------------------------------------------------------------------------
// Screen-To-World Translation
//---------------------------------------------------------------------------

/// Translate a screen x value (based on the camera) to a world x value
///
float to_world_x(float screen_x);

/// Translate a screen y value (based on the camera) to a world y value
///
float to_world_y(float screen_y);


#endif /* camera_hpp */
