//
//  images.cpp
//  splashkit
//
//  Created by Andrew Cain on 24/07/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#include "images.h"

#include "graphics_driver.h"
#include "backend_types.h"
#include "utility_functions.h"
#include "resources.h"

#include <map>
#include <cstdlib>
#include <cmath>

using std::map;
using std::to_string;

namespace splashkit_lib
{
    static map<string, bitmap> _bitmaps;

    void setup_collision_mask(bitmap bmp)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR) )
        {
            LOG(WARNING) << "Attempt to setup collision map with invalid bitmp";
            return;
        }
        
        int *pixels;
        int sz;
        int r, c;

        sz = bmp->image.surface.width * bmp->image.surface.height;
        pixels = (int *) malloc(sizeof(int) * sz);

        sk_to_pixels(&bmp->image.surface, pixels, sz);

        if ( bmp->pixel_mask == nullptr )
            bmp->pixel_mask = (bool *) malloc( sizeof(bool) * sz );

        // WriteLn(bmp^.name);
        for (r = 0; r < bmp->image.surface.height; r++)
        {
            for(c = 0; c < bmp->image.surface.width; c++)
            {
                bmp->pixel_mask[c + r * bmp->image.surface.width] = ((pixels[c + r * bmp->image.surface.width] & 0x000000FF) > 0x0000007F );
                // if b^.nonTransparentPixels[c, r] then Write(1) else Write(0);
            }
            // WriteLn();
        }
        // WriteLn();

        free(pixels);
    }
    
    bool bitmap_valid(bitmap bmp)
    {
        return VALID_PTR(bmp, BITMAP_PTR);
    }

    bool has_bitmap(string name)
    {
        return _bitmaps.count(name) > 0;
    }

    bitmap bitmap_named(string name)
    {
        if (has_bitmap(name))
            return _bitmaps[name];
        else
        {
            string filename = path_to_resource(name, IMAGE_RESOURCE);

            if ( file_exists(filename) or file_exists(name))
                return load_bitmap(name, name);
            return nullptr;
        }
    }


    bitmap load_bitmap(string name, string filename)
    {
        if (has_bitmap(name)) return bitmap_named(name);

        sk_drawing_surface surface;
        bitmap result = nullptr;

        string file_path = filename;

        if ( ! file_exists(file_path) )
        {
            file_path = path_to_resource(filename, IMAGE_RESOURCE);

            if ( ! file_exists(file_path) )
            {
                LOG(WARNING) << cat({ "Unable to locate file for ", name, " (", file_path, ")"});
                return nullptr;
            }
        }

        surface = sk_load_bitmap(file_path.c_str());
        if ( not surface._data )
        {
            LOG(WARNING) <<  cat({ "Error loading image for ", name, " (", file_path, ")"}) ;
            return nullptr;
        }

        result = new _bitmap_data;
        result->image.surface = surface;

        result->id         = BITMAP_PTR;
        result->cell_w     = surface.width;
        result->cell_h     = surface.height;
        result->cell_cols  = 1;
        result->cell_rows  = 1;
        result->cell_count = 1;
        result->pixel_mask = nullptr;

        result->name       = name;
        result->filename   = file_path;

        setup_collision_mask(result);

        _bitmaps[name] = result;

        return result;
    }

    bitmap create_bitmap(string name, int width, int height)
    {
        bitmap result = new(_bitmap_data);

        result->id = BITMAP_PTR;
        result->image.surface = sk_create_bitmap(width, height);

        result->cell_w     = width;
        result->cell_h     = height;
        result->cell_cols  = 1;
        result->cell_rows  = 1;
        result->cell_count = 1;
        result->pixel_mask = nullptr;

        result->filename   = "";

        int idx = 0;
        string key = name;
        while (has_bitmap(key))
        {
            key = name + to_string(idx);
            idx++;
        }

        result->name       = key;

        _bitmaps[key] = result;

        return result;
    }

    void free_bitmap(bitmap bmp)
    {
        if ( VALID_PTR(bmp, BITMAP_PTR) )
        {
            notify_of_free(bmp);

            _bitmaps.erase(bmp->name);
            sk_close_drawing_surface(&bmp->image.surface);
            bmp->id = NONE_PTR;  // ensure future use of this pointer will fail...
            if ( bmp->pixel_mask != nullptr )
                free(bmp->pixel_mask);
            delete(bmp);
        }
        else
        {
            LOG(WARNING) << "Delete bitmap called without valid bitmap";
        }
    }

    void free_all_bitmaps()
    {
        FREE_ALL_FROM_MAP(_bitmaps, BITMAP_PTR, free_bitmap);
    }

    string bitmap_filename(bitmap bmp)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR)) return "";

        return bmp->filename;
    }

    string bitmap_name(bitmap bmp)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR)) return "";

        return bmp->name;
    }

    void clear_bitmap(bitmap bmp, color clr)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR))
        {
            LOG(WARNING) << "Attempting to clear invalid bitmap";
            return;
        }

        sk_clear_drawing_surface(&bmp->image.surface, clr);
    }

    void clear_bitmap(string name, color clr)
    {
        clear_bitmap(bitmap_named(name), clr);
    }


    void draw_bitmap(bitmap bmp, double x, double y)
    {
        draw_bitmap(bmp, x, y, option_defaults());
    }

    void draw_bitmap(bitmap bmp, double x, double y, drawing_options opts)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR))
        {
            LOG(WARNING) << "Error trying to draw bitmap: passed in bmp is an invalid bitmap pointer.";
            return;
        }

        double src_data[4];
        double dst_data[7];
        sk_renderer_flip flip;
        sk_drawing_surface * dest;
        
        

        if ( VALID_PTR(opts.anim, ANIMATION_PTR) || opts.draw_cell >= 0 )
        {
            int cell;
            if ( opts.draw_cell >= 0 )
                cell = opts.draw_cell;
            else
                cell = animation_current_cell(opts.anim);
            
            rectangle part = bitmap_rectangle_of_cell(bmp, cell);
            src_data[0] = part.x;
            src_data[1] = part.y;
            src_data[2] = part.width;
            src_data[3] = part.height;
        }
        else if (opts.is_part)
        {
            src_data[0] = opts.part.x;
            src_data[1] = opts.part.y;
            src_data[2] = opts.part.width;
            src_data[3] = opts.part.height;
        }
        else
        {
            src_data[0] = 0;
            src_data[1] = 0;
            src_data[2] = bmp->image.surface.width;
            src_data[3] = bmp->image.surface.height;
        }

        //
        if ((opts.flip_x) and (opts.flip_y))
            flip = sk_FLIP_BOTH;
        else if (opts.flip_x)
            flip = sk_FLIP_VERTICAL;
        else if (opts.flip_y)
            flip = sk_FLIP_HORIZONTAL;
        else
            flip = sk_FLIP_NONE;

        // make up dst data
        dst_data[0] = x; // X
        dst_data[1] = y; // Y
        dst_data[2] = opts.angle; // Angle
        dst_data[3] = opts.anchor_offset_x; // Centre X
        dst_data[4] = opts.anchor_offset_y; // Centre Y
        dst_data[5] = opts.scale_x; // Scale X
        dst_data[6] = opts.scale_y; // Scale Y

        xy_from_opts(opts, dst_data[0], dst_data[1]); // Camera?

        dest = to_surface_ptr(opts.dest);
        sk_draw_bitmap(&bmp->image.surface, dest, src_data, 4, dst_data, 7, flip);
    }

    void draw_bitmap_on_window(window destination, bitmap bmp, double x, double y)
    {
        draw_bitmap(bmp, x, y, option_draw_to(destination));
    }

    void draw_bitmap_on_window(window destination, bitmap bmp, double x, double y, drawing_options opts)
    {
        draw_bitmap(bmp, x, y, option_draw_to(destination, opts));
    }

    void draw_bitmap_on_bitmap(bitmap destination, bitmap bmp, double x, double y)
    {
        draw_bitmap(bmp, x, y, option_draw_to(destination));
    }

    void draw_bitmap_on_bitmap(bitmap destination, bitmap bmp, double x, double y, drawing_options opts)
    {
        draw_bitmap(bmp, x, y, option_draw_to(destination, opts));
    }

    void draw_bitmap(string name, double x, double y)
    {
        draw_bitmap(bitmap_named(name), x, y, option_defaults());
    }

    void draw_bitmap(string name, double x, double y, drawing_options opts)
    {
        draw_bitmap(bitmap_named(name), x, y, opts);
    }

    rectangle bitmap_cell_rectangle(bitmap src, const point_2d &pt)
    {
        if ( INVALID_PTR(src, BITMAP_PTR))
        {
            LOG(WARNING) << "Attempting to get bitmap cell rectangle from invalid image";
            return rectangle_from(0, 0, 0, 0);
        }

        return rectangle_from(pt, src->cell_w, src->cell_h);
    }

    rectangle bitmap_cell_rectangle(bitmap src)
    {
        return bitmap_cell_rectangle(src, point_at(0, 0));
    }

    vector_2d bitmap_cell_offset(bitmap src, int cell)
    {
        if ( (not VALID_PTR(src, BITMAP_PTR)) or (cell >= src->cell_count) or (cell < 0) )
            return vector_to(0,0);
        return vector_to(
                         (cell % src->cell_cols) * src->cell_w,
                         (cell - (cell % src->cell_cols)) / src->cell_cols * src->cell_h);
    }

    rectangle bitmap_rectangle_of_cell(bitmap src, int cell)
    {
        rectangle result;

        if ( (not VALID_PTR(src, BITMAP_PTR)) or (cell >= src->cell_count))
            result = rectangle_from(0,0,0,0);
        else if (cell < 0)
            result = rectangle_from(0,0,src->image.surface.width, src->image.surface.width);
        else
        {
            result.x = (cell % src->cell_cols) * src->cell_w;
            result.y = (cell - (cell % src->cell_cols)) / src->cell_cols * src->cell_h;
            result.width = src->cell_w;
            result.height = src->cell_h;
        }

        return result;
    }

    rectangle bitmap_bounding_rectangle(bitmap bmp)
    {
        return bitmap_bounding_rectangle(bmp, 0, 0);
    }

    rectangle bitmap_bounding_rectangle(bitmap bmp, double x, double y)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR) )
            return rectangle_from(0, 0, 0, 0);
        else
            return rectangle_from(x, y, bitmap_width(bmp), bitmap_height(bmp));
    }


    circle bitmap_cell_circle(bitmap bmp, const point_2d pt, double scale)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR) )
        {
            LOG(WARNING) << "Attempting to get cell circle from invalid bitmap";
            return circle_at(0, 0, 0);
        }

        return circle_at(pt, sqrt(pow(bmp->cell_w / 2.0, 2.0) + pow(bmp->cell_h / 2.0, 2.0)) * scale);
    }

    circle bitmap_cell_circle(bitmap bmp, const point_2d pt)
    {
        return bitmap_cell_circle(bmp, pt, 1);
    }

    circle bitmap_cell_circle(bitmap bmp, double x, double y)
    {
        return bitmap_cell_circle(bmp, point_at(x, y), 1);
    }

    circle bitmap_bounding_circle(bitmap bmp, const point_2d &pt)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR))
        {
            return circle_at(0,0,0);
        }

        return circle_at(pt, sqrt(pow(bmp->image.surface.width / 2.0, 2.0) + pow(bmp->image.surface.height / 2.0, 2.0)));
    }

    int bitmap_cell_columns(bitmap bmp)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR))
        {
            return 0;
        }

        return bmp->cell_cols;
    }

    int bitmap_cell_rows(bitmap bmp)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR))
        {
            return 0;
        }

        return bmp->cell_rows;
    }

    void bitmap_set_cell_details(bitmap bmp, int width, int height, int columns, int rows, int count)
    {
        if ( not VALID_PTR(bmp, BITMAP_PTR))
        {
            LOG(WARNING) << "Trying to set cell details of invalid bitmap.";
            return;
        }

        bmp->cell_w     = width;
        bmp->cell_h     = height;
        bmp->cell_cols  = columns;
        bmp->cell_rows  = rows;
        bmp->cell_count = count;
    }

    int bitmap_width(bitmap bmp)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR))
        {
            LOG(WARNING) << "Attempting to get width of invalid bitmap";
            return 0;
        }

        return bmp->image.surface.width;
    }

    int bitmap_width(string name)
    {
        return bitmap_width(bitmap_named(name));
    }

    int bitmap_height(bitmap bmp)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR))
        {
            LOG(WARNING) << "Attempting to get height of invalid bitmap";
            return 0;
        }

        return bmp->image.surface.height;
    }

    int bitmap_height(string name)
    {
        return bitmap_height(bitmap_named(name));
    }

    point_2d bitmap_center(bitmap bmp)
    {
        return point_at(bitmap_width(bmp) / 2.0f, bitmap_height(bmp) / 2.0f);
    }

    int bitmap_cell_width(bitmap bmp)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR))
        {
            LOG(WARNING) << "Attempting to read details of invalid bitmap";
            return 0;
        }

        return bmp->cell_w;
    }

    int bitmap_cell_height(bitmap bmp)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR))
        {
            LOG(WARNING) << "Attempting to read details of invalid bitmap";
            return 0;
        }

        return bmp->cell_h;
    }

    point_2d bitmap_cell_center(bitmap bmp)
    {
        return point_at(bitmap_cell_width(bmp) / 2.0f, bitmap_cell_height(bmp) / 2.0f);
    }


    int bitmap_cell_count(bitmap bmp)
    {
        if ( INVALID_PTR(bmp, BITMAP_PTR))
        {
            return 0;
        }

        return bmp->cell_count;
    }

    bool pixel_drawn_at_point(bitmap bmp, double x, double y)
    {
        int px = ceil(x);
        int py = ceil(y);

        if ( INVALID_PTR(bmp, BITMAP_PTR) or px < 0 or px >= bitmap_width(bmp) or py < 0 or py >= bitmap_height(bmp) or bmp->pixel_mask == nullptr ) return false;

        return bmp->pixel_mask[px + py * bmp->image.surface.width];
    }

    bool pixel_drawn_at_point(bitmap bmp, int cell, double x, double y)
    {
        vector_2d offset = bitmap_cell_offset(bmp, cell);
        return pixel_drawn_at_point(bmp, x + offset.x, y + offset.y);
    }

    bool pixel_drawn_at_point(bitmap bmp, const point_2d &pt)
    {
        return pixel_drawn_at_point(bmp, pt.x, pt.y);
    }

    bool pixel_drawn_at_point(bitmap bmp, int cell, const point_2d &pt)
    {
        return pixel_drawn_at_point(bmp, cell, pt.x, pt.y);
    }
}
