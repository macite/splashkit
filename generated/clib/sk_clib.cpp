//
// SplashKit C Generated Library Code
// DO NOT MODIFY
//

#include "sk_clib.h"
#include "lib_type_mapper.h"

int __sklib__animation_count__animation_script(__sklib_animation_script script) {
    animation_script __skparam__script = __sklib__to_animation_script(script);
    int __skreturn = animation_count(__skparam__script);
    return __sklib__to_int(__skreturn);
}
int __sklib__animation_current_cell__animation(__sklib_animation anim) {
    animation __skparam__anim = __sklib__to_animation(anim);
    int __skreturn = animation_current_cell(__skparam__anim);
    return __sklib__to_int(__skreturn);
}
__sklib_vector_2d __sklib__animation_current_vector__animation(__sklib_animation anim) {
    animation __skparam__anim = __sklib__to_animation(anim);
    vector_2d __skreturn = animation_current_vector(__skparam__anim);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
int __sklib__animation_ended__animation(__sklib_animation anim) {
    animation __skparam__anim = __sklib__to_animation(anim);
    bool __skreturn = animation_ended(__skparam__anim);
    return __sklib__to_int(__skreturn);
}
int __sklib__animation_entered_frame__animation(__sklib_animation anim) {
    animation __skparam__anim = __sklib__to_animation(anim);
    bool __skreturn = animation_entered_frame(__skparam__anim);
    return __sklib__to_int(__skreturn);
}
float __sklib__animation_frame_time__animation(__sklib_animation anim) {
    animation __skparam__anim = __sklib__to_animation(anim);
    float __skreturn = animation_frame_time(__skparam__anim);
    return __sklib__to_float(__skreturn);
}
int __sklib__animation_index__animation_script__string_ref(__sklib_animation_script script, const __sklib_string name) {
    animation_script __skparam__script = __sklib__to_animation_script(script);
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = animation_index(__skparam__script, __skparam__name);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__animation_name__animation(__sklib_animation temp) {
    animation __skparam__temp = __sklib__to_animation(temp);
    string __skreturn = animation_name(__skparam__temp);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__animation_script_name__animation_script(__sklib_animation_script script) {
    animation_script __skparam__script = __sklib__to_animation_script(script);
    string __skreturn = animation_script_name(__skparam__script);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_animation_script __sklib__animation_script_named__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    animation_script __skreturn = animation_script_named(__skparam__name);
    return __sklib__to_sklib_animation_script(__skreturn);
}
void __sklib__assign_animation__animation__animation_script__string_ref(__sklib_animation anim, __sklib_animation_script script, const __sklib_string name) {
    animation __skparam__anim = __sklib__to_animation(anim);
    animation_script __skparam__script = __sklib__to_animation_script(script);
    string __skparam__name = __sklib__to_string(name);
    assign_animation(__skparam__anim, __skparam__script, __skparam__name);
}
void __sklib__assign_animation__animation__animation_script__string_ref__bool(__sklib_animation anim, __sklib_animation_script script, const __sklib_string name, int with_sound) {
    animation __skparam__anim = __sklib__to_animation(anim);
    animation_script __skparam__script = __sklib__to_animation_script(script);
    string __skparam__name = __sklib__to_string(name);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    assign_animation(__skparam__anim, __skparam__script, __skparam__name, __skparam__with_sound);
}
void __sklib__assign_animation__animation__animation_script__int(__sklib_animation anim, __sklib_animation_script script, int idx) {
    animation __skparam__anim = __sklib__to_animation(anim);
    animation_script __skparam__script = __sklib__to_animation_script(script);
    int __skparam__idx = __sklib__to_int(idx);
    assign_animation(__skparam__anim, __skparam__script, __skparam__idx);
}
void __sklib__assign_animation__animation__animation_script__int__bool(__sklib_animation anim, __sklib_animation_script script, int idx, int with_sound) {
    animation __skparam__anim = __sklib__to_animation(anim);
    animation_script __skparam__script = __sklib__to_animation_script(script);
    int __skparam__idx = __sklib__to_int(idx);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    assign_animation(__skparam__anim, __skparam__script, __skparam__idx, __skparam__with_sound);
}
void __sklib__assign_animation__animation__string_ref__string_ref(__sklib_animation anim, const __sklib_string script_name, const __sklib_string name) {
    animation __skparam__anim = __sklib__to_animation(anim);
    string __skparam__script_name = __sklib__to_string(script_name);
    string __skparam__name = __sklib__to_string(name);
    assign_animation(__skparam__anim, __skparam__script_name, __skparam__name);
}
void __sklib__assign_animation__animation__string_ref__string_ref__bool(__sklib_animation anim, const __sklib_string script_name, const __sklib_string name, int with_sound) {
    animation __skparam__anim = __sklib__to_animation(anim);
    string __skparam__script_name = __sklib__to_string(script_name);
    string __skparam__name = __sklib__to_string(name);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    assign_animation(__skparam__anim, __skparam__script_name, __skparam__name, __skparam__with_sound);
}
void __sklib__assign_animation__animation__int(__sklib_animation anim, int idx) {
    animation __skparam__anim = __sklib__to_animation(anim);
    int __skparam__idx = __sklib__to_int(idx);
    assign_animation(__skparam__anim, __skparam__idx);
}
void __sklib__assign_animation__animation__int__bool(__sklib_animation anim, int idx, int with_sound) {
    animation __skparam__anim = __sklib__to_animation(anim);
    int __skparam__idx = __sklib__to_int(idx);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    assign_animation(__skparam__anim, __skparam__idx, __skparam__with_sound);
}
void __sklib__assign_animation__animation__string(__sklib_animation anim, __sklib_string name) {
    animation __skparam__anim = __sklib__to_animation(anim);
    string __skparam__name = __sklib__to_string(name);
    assign_animation(__skparam__anim, __skparam__name);
}
void __sklib__assign_animation__animation__string__bool(__sklib_animation anim, __sklib_string name, int with_sound) {
    animation __skparam__anim = __sklib__to_animation(anim);
    string __skparam__name = __sklib__to_string(name);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    assign_animation(__skparam__anim, __skparam__name, __skparam__with_sound);
}
__sklib_animation __sklib__create_animation__animation_script__int__bool(__sklib_animation_script script, int idx, int with_sound) {
    animation_script __skparam__script = __sklib__to_animation_script(script);
    int __skparam__idx = __sklib__to_int(idx);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    animation __skreturn = create_animation(__skparam__script, __skparam__idx, __skparam__with_sound);
    return __sklib__to_sklib_animation(__skreturn);
}
__sklib_animation __sklib__create_animation__animation_script__string_ref(__sklib_animation_script script, const __sklib_string name) {
    animation_script __skparam__script = __sklib__to_animation_script(script);
    string __skparam__name = __sklib__to_string(name);
    animation __skreturn = create_animation(__skparam__script, __skparam__name);
    return __sklib__to_sklib_animation(__skreturn);
}
__sklib_animation __sklib__create_animation__animation_script__string_ref__bool(__sklib_animation_script script, const __sklib_string name, int with_sound) {
    animation_script __skparam__script = __sklib__to_animation_script(script);
    string __skparam__name = __sklib__to_string(name);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    animation __skreturn = create_animation(__skparam__script, __skparam__name, __skparam__with_sound);
    return __sklib__to_sklib_animation(__skreturn);
}
__sklib_animation __sklib__create_animation__string_ref__string_ref(const __sklib_string script_name, const __sklib_string name) {
    string __skparam__script_name = __sklib__to_string(script_name);
    string __skparam__name = __sklib__to_string(name);
    animation __skreturn = create_animation(__skparam__script_name, __skparam__name);
    return __sklib__to_sklib_animation(__skreturn);
}
__sklib_animation __sklib__create_animation__string_ref__string_ref__bool(const __sklib_string script_name, const __sklib_string name, int with_sound) {
    string __skparam__script_name = __sklib__to_string(script_name);
    string __skparam__name = __sklib__to_string(name);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    animation __skreturn = create_animation(__skparam__script_name, __skparam__name, __skparam__with_sound);
    return __sklib__to_sklib_animation(__skreturn);
}
void __sklib__free_all_animation_scripts() {
    free_all_animation_scripts();
}
void __sklib__free_animation__animation(__sklib_animation ani) {
    animation __skparam__ani = __sklib__to_animation(ani);
    free_animation(__skparam__ani);
}
void __sklib__free_animation_script__animation_script(__sklib_animation_script script_to_free) {
    animation_script __skparam__script_to_free = __sklib__to_animation_script(script_to_free);
    free_animation_script(__skparam__script_to_free);
}
void __sklib__free_animation_script__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    free_animation_script(__skparam__name);
}
int __sklib__has_animation_named__animation_script__string_ref(__sklib_animation_script script, const __sklib_string name) {
    animation_script __skparam__script = __sklib__to_animation_script(script);
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_animation_named(__skparam__script, __skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__has_animation_script__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_animation_script(__skparam__name);
    return __sklib__to_int(__skreturn);
}
__sklib_animation_script __sklib__load_animation_script__string_ref__string_ref(const __sklib_string name, const __sklib_string filename) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__filename = __sklib__to_string(filename);
    animation_script __skreturn = load_animation_script(__skparam__name, __skparam__filename);
    return __sklib__to_sklib_animation_script(__skreturn);
}
void __sklib__restart_animation__animation(__sklib_animation anim) {
    animation __skparam__anim = __sklib__to_animation(anim);
    restart_animation(__skparam__anim);
}
void __sklib__restart_animation__animation__bool(__sklib_animation anim, int with_sound) {
    animation __skparam__anim = __sklib__to_animation(anim);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    restart_animation(__skparam__anim, __skparam__with_sound);
}
void __sklib__update_animation__animation__float__bool(__sklib_animation anim, float pct, int with_sound) {
    animation __skparam__anim = __sklib__to_animation(anim);
    float __skparam__pct = __sklib__to_float(pct);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    update_animation(__skparam__anim, __skparam__pct, __skparam__with_sound);
}
void __sklib__update_animation__animation(__sklib_animation anim) {
    animation __skparam__anim = __sklib__to_animation(anim);
    update_animation(__skparam__anim);
}
void __sklib__update_animation__animation__float(__sklib_animation anim, float pct) {
    animation __skparam__anim = __sklib__to_animation(anim);
    float __skparam__pct = __sklib__to_float(pct);
    update_animation(__skparam__anim, __skparam__pct);
}
int __sklib__audio_ready() {
    bool __skreturn = audio_ready();
    return __sklib__to_int(__skreturn);
}
void __sklib__close_audio() {
    close_audio();
}
void __sklib__open_audio() {
    open_audio();
}
int __sklib__contains__string_ref__string_ref(const __sklib_string text, const __sklib_string subtext) {
    string __skparam__text = __sklib__to_string(text);
    string __skparam__subtext = __sklib__to_string(subtext);
    bool __skreturn = contains(__skparam__text, __skparam__subtext);
    return __sklib__to_int(__skreturn);
}
double __sklib__convert_to_double__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    double __skreturn = convert_to_double(__skparam__text);
    return __sklib__to_double(__skreturn);
}
int __sklib__convert_to_integer__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    int __skreturn = convert_to_integer(__skparam__text);
    return __sklib__to_int(__skreturn);
}
int __sklib__index_of__string_ref__string_ref(const __sklib_string text, const __sklib_string subtext) {
    string __skparam__text = __sklib__to_string(text);
    string __skparam__subtext = __sklib__to_string(subtext);
    int __skreturn = index_of(__skparam__text, __skparam__subtext);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_double__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    bool __skreturn = is_double(__skparam__text);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_integer__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    bool __skreturn = is_integer(__skparam__text);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_number__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    bool __skreturn = is_number(__skparam__text);
    return __sklib__to_int(__skreturn);
}
int __sklib__length_of__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    int __skreturn = length_of(__skparam__text);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__replace_all__string_ref__string_ref__string_ref(const __sklib_string text, const __sklib_string substr, const __sklib_string newtext) {
    string __skparam__text = __sklib__to_string(text);
    string __skparam__substr = __sklib__to_string(substr);
    string __skparam__newtext = __sklib__to_string(newtext);
    string __skreturn = replace_all(__skparam__text, __skparam__substr, __skparam__newtext);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_vector_string __sklib__split__string_ref__char(const __sklib_string text, char delimiter) {
    string __skparam__text = __sklib__to_string(text);
    char __skparam__delimiter = __sklib__to_char(delimiter);
    vector<string> __skreturn = split(__skparam__text, __skparam__delimiter);
    return __sklib__to_sklib_vector_string(__skreturn);
}
__sklib_string __sklib__to_lowercase__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    string __skreturn = to_lowercase(__skparam__text);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__to_uppercase__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    string __skreturn = to_uppercase(__skparam__text);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__trim__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    string __skreturn = trim(__skparam__text);
    return __sklib__to_sklib_string(__skreturn);
}
void __sklib__free_resource_bundle__string(const __sklib_string name) {
    const string __skparam__name = __sklib__to_string(name);
    free_resource_bundle(__skparam__name);
}
int __sklib__has_resource_bundle__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_resource_bundle(__skparam__name);
    return __sklib__to_int(__skreturn);
}
void __sklib__load_resource_bundle__string_ref__string_ref(const __sklib_string name, const __sklib_string filename) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__filename = __sklib__to_string(filename);
    load_resource_bundle(__skparam__name, __skparam__filename);
}
__sklib_point_2d __sklib__camera_position() {
    point_2d __skreturn = camera_position();
    return __sklib__to_sklib_point_2d(__skreturn);
}
double __sklib__camera_x() {
    double __skreturn = camera_x();
    return __sklib__to_double(__skreturn);
}
double __sklib__camera_y() {
    double __skreturn = camera_y();
    return __sklib__to_double(__skreturn);
}
void __sklib__center_camera_on__sprite__vector_2d_ref(__sklib_sprite s, const __sklib_vector_2d offset) {
    sprite __skparam__s = __sklib__to_sprite(s);
    vector_2d __skparam__offset = __sklib__to_vector_2d(offset);
    center_camera_on(__skparam__s, __skparam__offset);
}
void __sklib__center_camera_on__sprite__double__double(__sklib_sprite s, double offset_x, double offset_y) {
    sprite __skparam__s = __sklib__to_sprite(s);
    double __skparam__offset_x = __sklib__to_double(offset_x);
    double __skparam__offset_y = __sklib__to_double(offset_y);
    center_camera_on(__skparam__s, __skparam__offset_x, __skparam__offset_y);
}
void __sklib__move_camera_by__vector_2d_ref(const __sklib_vector_2d offset) {
    vector_2d __skparam__offset = __sklib__to_vector_2d(offset);
    move_camera_by(__skparam__offset);
}
void __sklib__move_camera_by__double__double(double dx, double dy) {
    double __skparam__dx = __sklib__to_double(dx);
    double __skparam__dy = __sklib__to_double(dy);
    move_camera_by(__skparam__dx, __skparam__dy);
}
void __sklib__move_camera_to__point_2d_ref(const __sklib_point_2d pt) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    move_camera_to(__skparam__pt);
}
void __sklib__move_camera_to__double__double(double x, double y) {
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    move_camera_to(__skparam__x, __skparam__y);
}
int __sklib__point_in_window__window__point_2d_ref(__sklib_window wind, const __sklib_point_2d pt) {
    window __skparam__wind = __sklib__to_window(wind);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = point_in_window(__skparam__wind, __skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__point_on_screen__point_2d_ref(const __sklib_point_2d pt) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = point_on_screen(__skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__rect_in_window__window__rectangle_ref(__sklib_window wind, const __sklib_rectangle rect) {
    window __skparam__wind = __sklib__to_window(wind);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = rect_in_window(__skparam__wind, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
int __sklib__rect_on_screen__rectangle_ref(const __sklib_rectangle rect) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = rect_on_screen(__skparam__rect);
    return __sklib__to_int(__skreturn);
}
__sklib_point_2d __sklib__screen_center() {
    point_2d __skreturn = screen_center();
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_rectangle __sklib__screen_rectangle() {
    rectangle __skreturn = screen_rectangle();
    return __sklib__to_sklib_rectangle(__skreturn);
}
void __sklib__set_camera_position__point_2d(__sklib_point_2d pos) {
    point_2d __skparam__pos = __sklib__to_point_2d(pos);
    set_camera_position(__skparam__pos);
}
void __sklib__set_camera_x__double(double x) {
    double __skparam__x = __sklib__to_double(x);
    set_camera_x(__skparam__x);
}
void __sklib__set_camera_y__double(double y) {
    double __skparam__y = __sklib__to_double(y);
    set_camera_y(__skparam__y);
}
__sklib_point_2d __sklib__to_screen__point_2d_ref(const __sklib_point_2d pt) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    point_2d __skreturn = to_screen(__skparam__pt);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_rectangle __sklib__to_screen__rectangle_ref(const __sklib_rectangle rect) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    rectangle __skreturn = to_screen(__skparam__rect);
    return __sklib__to_sklib_rectangle(__skreturn);
}
double __sklib__to_screen_x__double(double world_x) {
    double __skparam__world_x = __sklib__to_double(world_x);
    double __skreturn = to_screen_x(__skparam__world_x);
    return __sklib__to_double(__skreturn);
}
double __sklib__to_screen_y__double(double world_y) {
    double __skparam__world_y = __sklib__to_double(world_y);
    double __skreturn = to_screen_y(__skparam__world_y);
    return __sklib__to_double(__skreturn);
}
__sklib_point_2d __sklib__to_world__point_2d_ref(const __sklib_point_2d pt) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    point_2d __skreturn = to_world(__skparam__pt);
    return __sklib__to_sklib_point_2d(__skreturn);
}
double __sklib__to_world_x__double(double screen_x) {
    double __skparam__screen_x = __sklib__to_double(screen_x);
    double __skreturn = to_world_x(__skparam__screen_x);
    return __sklib__to_double(__skreturn);
}
double __sklib__to_world_y__double(double screen_y) {
    double __skparam__screen_y = __sklib__to_double(screen_y);
    double __skreturn = to_world_y(__skparam__screen_y);
    return __sklib__to_double(__skreturn);
}
__sklib_vector_2d __sklib__vector_world_to_screen() {
    vector_2d __skreturn = vector_world_to_screen();
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_rectangle __sklib__window_area__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    rectangle __skreturn = window_area(__skparam__wind);
    return __sklib__to_sklib_rectangle(__skreturn);
}
void __sklib__draw_circle__color__circle_ref(__sklib_color clr, const __sklib_circle c) {
    color __skparam__clr = __sklib__to_color(clr);
    circle __skparam__c = __sklib__to_circle(c);
    draw_circle(__skparam__clr, __skparam__c);
}
void __sklib__draw_circle__color__circle_ref__drawing_options(__sklib_color clr, const __sklib_circle c, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    circle __skparam__c = __sklib__to_circle(c);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_circle(__skparam__clr, __skparam__c, __skparam__opts);
}
void __sklib__draw_circle__color__double__double__double(__sklib_color clr, double x, double y, double radius) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    draw_circle(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
}
void __sklib__draw_circle__color__double__double__double__drawing_options(__sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_circle(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
}
void __sklib__draw_circle_on_bitmap__bitmap__color__double__double__double(__sklib_bitmap destination, __sklib_color clr, double x, double y, double radius) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    draw_circle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
}
void __sklib__draw_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(__sklib_bitmap destination, __sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_circle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
}
void __sklib__draw_circle_on_window__window__color__double__double__double(__sklib_window destination, __sklib_color clr, double x, double y, double radius) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    draw_circle_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
}
void __sklib__draw_circle_on_window__window__color__double__double__double__drawing_options(__sklib_window destination, __sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_circle_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
}
void __sklib__fill_circle__color__circle_ref(__sklib_color clr, const __sklib_circle c) {
    color __skparam__clr = __sklib__to_color(clr);
    circle __skparam__c = __sklib__to_circle(c);
    fill_circle(__skparam__clr, __skparam__c);
}
void __sklib__fill_circle__color__circle_ref__drawing_options(__sklib_color clr, const __sklib_circle c, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    circle __skparam__c = __sklib__to_circle(c);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_circle(__skparam__clr, __skparam__c, __skparam__opts);
}
void __sklib__fill_circle__color__double__double__double(__sklib_color clr, double x, double y, double radius) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    fill_circle(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
}
void __sklib__fill_circle__color__double__double__double__drawing_options(__sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_circle(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
}
void __sklib__fill_circle_on_bitmap__bitmap__color__double__double__double(__sklib_bitmap destination, __sklib_color clr, double x, double y, double radius) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    fill_circle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
}
void __sklib__fill_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(__sklib_bitmap destination, __sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_circle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
}
void __sklib__fill_circle_on_window__window__color__double__double__double(__sklib_window destination, __sklib_color clr, double x, double y, double radius) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    fill_circle_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
}
void __sklib__fill_circle_on_window__window__color__double__double__double__drawing_options(__sklib_window destination, __sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_circle_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
}
__sklib_point_2d __sklib__center_point__circle_ref(const __sklib_circle c) {
    circle __skparam__c = __sklib__to_circle(c);
    point_2d __skreturn = center_point(__skparam__c);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_circle __sklib__circle_at__point_2d_ref__double(const __sklib_point_2d pt, double radius) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    double __skparam__radius = __sklib__to_double(radius);
    circle __skreturn = circle_at(__skparam__pt, __skparam__radius);
    return __sklib__to_sklib_circle(__skreturn);
}
__sklib_circle __sklib__circle_at__double__double__double(double x, double y, double radius) {
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__radius = __sklib__to_double(radius);
    circle __skreturn = circle_at(__skparam__x, __skparam__y, __skparam__radius);
    return __sklib__to_sklib_circle(__skreturn);
}
float __sklib__circle_radius__circle(const __sklib_circle c) {
    const circle __skparam__c = __sklib__to_circle(c);
    float __skreturn = circle_radius(__skparam__c);
    return __sklib__to_float(__skreturn);
}
int __sklib__circle_triangle_intersect__circle_ref__triangle_ref(const __sklib_circle c, const __sklib_triangle tri) {
    circle __skparam__c = __sklib__to_circle(c);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    bool __skreturn = circle_triangle_intersect(__skparam__c, __skparam__tri);
    return __sklib__to_int(__skreturn);
}
int __sklib__circle_triangle_intersect__circle_ref__triangle_ref__point_2d_ref(const __sklib_circle c, const __sklib_triangle tri, __sklib_point_2d *p) {
    circle __skparam__c = __sklib__to_circle(c);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    point_2d __skparam__p = __sklib__to_point_2d(*p);
    bool __skreturn = circle_triangle_intersect(__skparam__c, __skparam__tri, __skparam__p);
    *p = __sklib__to_sklib_point_2d(__skparam__p);
    return __sklib__to_int(__skreturn);
}
float __sklib__circle_x__circle_ref(const __sklib_circle c) {
    circle __skparam__c = __sklib__to_circle(c);
    float __skreturn = circle_x(__skparam__c);
    return __sklib__to_float(__skreturn);
}
float __sklib__circle_y__circle_ref(const __sklib_circle c) {
    circle __skparam__c = __sklib__to_circle(c);
    float __skreturn = circle_y(__skparam__c);
    return __sklib__to_float(__skreturn);
}
int __sklib__circles_intersect__circle__circle(__sklib_circle c1, __sklib_circle c2) {
    circle __skparam__c1 = __sklib__to_circle(c1);
    circle __skparam__c2 = __sklib__to_circle(c2);
    bool __skreturn = circles_intersect(__skparam__c1, __skparam__c2);
    return __sklib__to_int(__skreturn);
}
int __sklib__circles_intersect__double__double__double__double__double__double(double c1_x, double c1_y, double c1_radius, double c2_x, double c2_y, double c2_radius) {
    double __skparam__c1_x = __sklib__to_double(c1_x);
    double __skparam__c1_y = __sklib__to_double(c1_y);
    double __skparam__c1_radius = __sklib__to_double(c1_radius);
    double __skparam__c2_x = __sklib__to_double(c2_x);
    double __skparam__c2_y = __sklib__to_double(c2_y);
    double __skparam__c2_radius = __sklib__to_double(c2_radius);
    bool __skreturn = circles_intersect(__skparam__c1_x, __skparam__c1_y, __skparam__c1_radius, __skparam__c2_x, __skparam__c2_y, __skparam__c2_radius);
    return __sklib__to_int(__skreturn);
}
__sklib_point_2d __sklib__closest_point_on_circle__point_2d_ref__circle_ref(const __sklib_point_2d from_pt, const __sklib_circle c) {
    point_2d __skparam__from_pt = __sklib__to_point_2d(from_pt);
    circle __skparam__c = __sklib__to_circle(c);
    point_2d __skreturn = closest_point_on_circle(__skparam__from_pt, __skparam__c);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_point_2d __sklib__closest_point_on_line_from_circle__circle_ref__line_ref(const __sklib_circle c, const __sklib_line l) {
    circle __skparam__c = __sklib__to_circle(c);
    line __skparam__l = __sklib__to_line(l);
    point_2d __skreturn = closest_point_on_line_from_circle(__skparam__c, __skparam__l);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_point_2d __sklib__closest_point_on_rect_from_circle__circle_ref__rectangle_ref(const __sklib_circle c, const __sklib_rectangle rect) {
    circle __skparam__c = __sklib__to_circle(c);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    point_2d __skreturn = closest_point_on_rect_from_circle(__skparam__c, __skparam__rect);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_point_2d __sklib__closest_point_on_triangle_from_circle__circle_ref__triangle_ref(const __sklib_circle c, const __sklib_triangle tri) {
    circle __skparam__c = __sklib__to_circle(c);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    point_2d __skreturn = closest_point_on_triangle_from_circle(__skparam__c, __skparam__tri);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_point_2d __sklib__distant_point_on_circle__point_2d_ref__circle_ref(const __sklib_point_2d pt, const __sklib_circle c) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    circle __skparam__c = __sklib__to_circle(c);
    point_2d __skreturn = distant_point_on_circle(__skparam__pt, __skparam__c);
    return __sklib__to_sklib_point_2d(__skreturn);
}
int __sklib__distant_point_on_circle_heading__point_2d_ref__circle_ref__vector_2d_ref__point_2d_ref(const __sklib_point_2d pt, const __sklib_circle c, const __sklib_vector_2d heading, __sklib_point_2d *opposite_pt) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    circle __skparam__c = __sklib__to_circle(c);
    vector_2d __skparam__heading = __sklib__to_vector_2d(heading);
    point_2d __skparam__opposite_pt = __sklib__to_point_2d(*opposite_pt);
    bool __skreturn = distant_point_on_circle_heading(__skparam__pt, __skparam__c, __skparam__heading, __skparam__opposite_pt);
    *opposite_pt = __sklib__to_sklib_point_2d(__skparam__opposite_pt);
    return __sklib__to_int(__skreturn);
}
float __sklib__ray_circle_intersect_distance__point_2d_ref__vector_2d_ref__circle_ref(const __sklib_point_2d ray_origin, const __sklib_vector_2d ray_heading, const __sklib_circle c) {
    point_2d __skparam__ray_origin = __sklib__to_point_2d(ray_origin);
    vector_2d __skparam__ray_heading = __sklib__to_vector_2d(ray_heading);
    circle __skparam__c = __sklib__to_circle(c);
    float __skreturn = ray_circle_intersect_distance(__skparam__ray_origin, __skparam__ray_heading, __skparam__c);
    return __sklib__to_float(__skreturn);
}
int __sklib__tangent_points__point_2d_ref__circle_ref__point_2d_ref__point_2d_ref(const __sklib_point_2d from_pt, const __sklib_circle c, __sklib_point_2d *p1, __sklib_point_2d *p2) {
    point_2d __skparam__from_pt = __sklib__to_point_2d(from_pt);
    circle __skparam__c = __sklib__to_circle(c);
    point_2d __skparam__p1 = __sklib__to_point_2d(*p1);
    point_2d __skparam__p2 = __sklib__to_point_2d(*p2);
    bool __skreturn = tangent_points(__skparam__from_pt, __skparam__c, __skparam__p1, __skparam__p2);
    *p1 = __sklib__to_sklib_point_2d(__skparam__p1);
    *p2 = __sklib__to_sklib_point_2d(__skparam__p2);
    return __sklib__to_int(__skreturn);
}
void __sklib__widest_points__circle_ref__vector_2d_ref__point_2d_ref__point_2d_ref(const __sklib_circle c, const __sklib_vector_2d along, __sklib_point_2d *pt1, __sklib_point_2d *pt2) {
    circle __skparam__c = __sklib__to_circle(c);
    vector_2d __skparam__along = __sklib__to_vector_2d(along);
    point_2d __skparam__pt1 = __sklib__to_point_2d(*pt1);
    point_2d __skparam__pt2 = __sklib__to_point_2d(*pt2);
    widest_points(__skparam__c, __skparam__along, __skparam__pt1, __skparam__pt2);
    *pt1 = __sklib__to_sklib_point_2d(__skparam__pt1);
    *pt2 = __sklib__to_sklib_point_2d(__skparam__pt2);
}
__sklib_rectangle __sklib__current_clip() {
    rectangle __skreturn = current_clip();
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__current_clip__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    rectangle __skreturn = current_clip(__skparam__bmp);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__current_clip__window(__sklib_window wnd) {
    window __skparam__wnd = __sklib__to_window(wnd);
    rectangle __skreturn = current_clip(__skparam__wnd);
    return __sklib__to_sklib_rectangle(__skreturn);
}
void __sklib__pop_clip__window(__sklib_window wnd) {
    window __skparam__wnd = __sklib__to_window(wnd);
    pop_clip(__skparam__wnd);
}
void __sklib__pop_clip() {
    pop_clip();
}
void __sklib__pop_clip__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    pop_clip(__skparam__bmp);
}
void __sklib__push_clip__window__rectangle_ref(__sklib_window wnd, const __sklib_rectangle r) {
    window __skparam__wnd = __sklib__to_window(wnd);
    rectangle __skparam__r = __sklib__to_rectangle(r);
    push_clip(__skparam__wnd, __skparam__r);
}
void __sklib__push_clip__bitmap__rectangle_ref(__sklib_bitmap bmp, const __sklib_rectangle r) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    rectangle __skparam__r = __sklib__to_rectangle(r);
    push_clip(__skparam__bmp, __skparam__r);
}
void __sklib__push_clip__rectangle_ref(const __sklib_rectangle r) {
    rectangle __skparam__r = __sklib__to_rectangle(r);
    push_clip(__skparam__r);
}
void __sklib__reset_clip__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    reset_clip(__skparam__bmp);
}
void __sklib__reset_clip() {
    reset_clip();
}
void __sklib__reset_clip__window(__sklib_window wnd) {
    window __skparam__wnd = __sklib__to_window(wnd);
    reset_clip(__skparam__wnd);
}
void __sklib__set_clip__rectangle_ref(const __sklib_rectangle r) {
    rectangle __skparam__r = __sklib__to_rectangle(r);
    set_clip(__skparam__r);
}
void __sklib__set_clip__bitmap__rectangle_ref(__sklib_bitmap bmp, const __sklib_rectangle r) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    rectangle __skparam__r = __sklib__to_rectangle(r);
    set_clip(__skparam__bmp, __skparam__r);
}
void __sklib__set_clip__window__rectangle_ref(__sklib_window wnd, const __sklib_rectangle r) {
    window __skparam__wnd = __sklib__to_window(wnd);
    rectangle __skparam__r = __sklib__to_rectangle(r);
    set_clip(__skparam__wnd, __skparam__r);
}
int __sklib__bitmap_circle_collision__bitmap__point_2d_ref__circle_ref(__sklib_bitmap bmp, const __sklib_point_2d pt, const __sklib_circle circ) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    circle __skparam__circ = __sklib__to_circle(circ);
    bool __skreturn = bitmap_circle_collision(__skparam__bmp, __skparam__pt, __skparam__circ);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_circle_collision__bitmap__double__double__circle_ref(__sklib_bitmap bmp, double x, double y, const __sklib_circle circ) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    circle __skparam__circ = __sklib__to_circle(circ);
    bool __skreturn = bitmap_circle_collision(__skparam__bmp, __skparam__x, __skparam__y, __skparam__circ);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_circle_collision__bitmap__int__matrix_2d_ref__circle_ref(__sklib_bitmap bmp, int cell, const __sklib_matrix_2d translation, const __sklib_circle circ) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    matrix_2d __skparam__translation = __sklib__to_matrix_2d(translation);
    circle __skparam__circ = __sklib__to_circle(circ);
    bool __skreturn = bitmap_circle_collision(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__circ);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_circle_collision__bitmap__int__point_2d_ref__circle_ref(__sklib_bitmap bmp, int cell, const __sklib_point_2d pt, const __sklib_circle circ) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    circle __skparam__circ = __sklib__to_circle(circ);
    bool __skreturn = bitmap_circle_collision(__skparam__bmp, __skparam__cell, __skparam__pt, __skparam__circ);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_circle_collision__bitmap__int__double__double__circle_ref(__sklib_bitmap bmp, int cell, double x, double y, const __sklib_circle circ) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    circle __skparam__circ = __sklib__to_circle(circ);
    bool __skreturn = bitmap_circle_collision(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y, __skparam__circ);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_collision__bitmap__double__double__bitmap__double__double(__sklib_bitmap bmp1, double x1, double y1, __sklib_bitmap bmp2, double x2, double y2) {
    bitmap __skparam__bmp1 = __sklib__to_bitmap(bmp1);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    bitmap __skparam__bmp2 = __sklib__to_bitmap(bmp2);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    bool __skreturn = bitmap_collision(__skparam__bmp1, __skparam__x1, __skparam__y1, __skparam__bmp2, __skparam__x2, __skparam__y2);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_collision__bitmap__point_2d_ref__bitmap__point_2d_ref(__sklib_bitmap bmp1, const __sklib_point_2d pt1, __sklib_bitmap bmp2, const __sklib_point_2d pt2) {
    bitmap __skparam__bmp1 = __sklib__to_bitmap(bmp1);
    point_2d __skparam__pt1 = __sklib__to_point_2d(pt1);
    bitmap __skparam__bmp2 = __sklib__to_bitmap(bmp2);
    point_2d __skparam__pt2 = __sklib__to_point_2d(pt2);
    bool __skreturn = bitmap_collision(__skparam__bmp1, __skparam__pt1, __skparam__bmp2, __skparam__pt2);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_collision__bitmap__int__matrix_2d_ref__bitmap__int__matrix_2d_ref(__sklib_bitmap bmp1, int cell1, const __sklib_matrix_2d matrix1, __sklib_bitmap bmp2, int cell2, const __sklib_matrix_2d matrix2) {
    bitmap __skparam__bmp1 = __sklib__to_bitmap(bmp1);
    int __skparam__cell1 = __sklib__to_int(cell1);
    matrix_2d __skparam__matrix1 = __sklib__to_matrix_2d(matrix1);
    bitmap __skparam__bmp2 = __sklib__to_bitmap(bmp2);
    int __skparam__cell2 = __sklib__to_int(cell2);
    matrix_2d __skparam__matrix2 = __sklib__to_matrix_2d(matrix2);
    bool __skreturn = bitmap_collision(__skparam__bmp1, __skparam__cell1, __skparam__matrix1, __skparam__bmp2, __skparam__cell2, __skparam__matrix2);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_collision__bitmap__int__point_2d_ref__bitmap__int__point_2d_ref(__sklib_bitmap bmp1, int cell1, const __sklib_point_2d pt1, __sklib_bitmap bmp2, int cell2, const __sklib_point_2d pt2) {
    bitmap __skparam__bmp1 = __sklib__to_bitmap(bmp1);
    int __skparam__cell1 = __sklib__to_int(cell1);
    point_2d __skparam__pt1 = __sklib__to_point_2d(pt1);
    bitmap __skparam__bmp2 = __sklib__to_bitmap(bmp2);
    int __skparam__cell2 = __sklib__to_int(cell2);
    point_2d __skparam__pt2 = __sklib__to_point_2d(pt2);
    bool __skreturn = bitmap_collision(__skparam__bmp1, __skparam__cell1, __skparam__pt1, __skparam__bmp2, __skparam__cell2, __skparam__pt2);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_collision__bitmap__int__double__double__bitmap__int__double__double(__sklib_bitmap bmp1, int cell1, double x1, double y1, __sklib_bitmap bmp2, int cell2, double x2, double y2) {
    bitmap __skparam__bmp1 = __sklib__to_bitmap(bmp1);
    int __skparam__cell1 = __sklib__to_int(cell1);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    bitmap __skparam__bmp2 = __sklib__to_bitmap(bmp2);
    int __skparam__cell2 = __sklib__to_int(cell2);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    bool __skreturn = bitmap_collision(__skparam__bmp1, __skparam__cell1, __skparam__x1, __skparam__y1, __skparam__bmp2, __skparam__cell2, __skparam__x2, __skparam__y2);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_point_collision__bitmap__matrix_2d_ref__point_2d_ref(__sklib_bitmap bmp, const __sklib_matrix_2d translation, const __sklib_point_2d pt) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    matrix_2d __skparam__translation = __sklib__to_matrix_2d(translation);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = bitmap_point_collision(__skparam__bmp, __skparam__translation, __skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_point_collision__bitmap__point_2d_ref__point_2d_ref(__sklib_bitmap bmp, const __sklib_point_2d bmp_pt, const __sklib_point_2d pt) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    point_2d __skparam__bmp_pt = __sklib__to_point_2d(bmp_pt);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = bitmap_point_collision(__skparam__bmp, __skparam__bmp_pt, __skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_point_collision__bitmap__double__double__double__double(__sklib_bitmap bmp, double bmp_x, double bmp_y, double x, double y) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__bmp_x = __sklib__to_double(bmp_x);
    double __skparam__bmp_y = __sklib__to_double(bmp_y);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    bool __skreturn = bitmap_point_collision(__skparam__bmp, __skparam__bmp_x, __skparam__bmp_y, __skparam__x, __skparam__y);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_point_collision__bitmap__int__matrix_2d_ref__point_2d_ref(__sklib_bitmap bmp, int cell, const __sklib_matrix_2d translation, const __sklib_point_2d pt) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    matrix_2d __skparam__translation = __sklib__to_matrix_2d(translation);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = bitmap_point_collision(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_point_collision__bitmap__int__point_2d_ref__point_2d_ref(__sklib_bitmap bmp, int cell, const __sklib_point_2d bmp_pt, const __sklib_point_2d pt) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    point_2d __skparam__bmp_pt = __sklib__to_point_2d(bmp_pt);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = bitmap_point_collision(__skparam__bmp, __skparam__cell, __skparam__bmp_pt, __skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_point_collision__bitmap__int__double__double__double__double(__sklib_bitmap bmp, int cell, double bmp_x, double bmp_y, double x, double y) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    double __skparam__bmp_x = __sklib__to_double(bmp_x);
    double __skparam__bmp_y = __sklib__to_double(bmp_y);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    bool __skreturn = bitmap_point_collision(__skparam__bmp, __skparam__cell, __skparam__bmp_x, __skparam__bmp_y, __skparam__x, __skparam__y);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_rectangle_collision__bitmap__point_2d_ref__rectangle_ref(__sklib_bitmap bmp, const __sklib_point_2d pt, const __sklib_rectangle rect) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = bitmap_rectangle_collision(__skparam__bmp, __skparam__pt, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_rectangle_collision__bitmap__double__double__rectangle_ref(__sklib_bitmap bmp, double x, double y, const __sklib_rectangle rect) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = bitmap_rectangle_collision(__skparam__bmp, __skparam__x, __skparam__y, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_rectangle_collision__bitmap__int__matrix_2d_ref__rectangle_ref(__sklib_bitmap bmp, int cell, const __sklib_matrix_2d translation, const __sklib_rectangle rect) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    matrix_2d __skparam__translation = __sklib__to_matrix_2d(translation);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = bitmap_rectangle_collision(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_rectangle_collision__bitmap__int__point_2d_ref__rectangle_ref(__sklib_bitmap bmp, int cell, const __sklib_point_2d pt, const __sklib_rectangle rect) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = bitmap_rectangle_collision(__skparam__bmp, __skparam__cell, __skparam__pt, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_rectangle_collision__bitmap__int__double__double__rectangle_ref(__sklib_bitmap bmp, int cell, double x, double y, const __sklib_rectangle rect) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = bitmap_rectangle_collision(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_bitmap_collision__sprite__bitmap__double__double(__sklib_sprite s, __sklib_bitmap bmp, double x, double y) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    bool __skreturn = sprite_bitmap_collision(__skparam__s, __skparam__bmp, __skparam__x, __skparam__y);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_bitmap_collision__sprite__bitmap__int__point_2d_ref(__sklib_sprite s, __sklib_bitmap bmp, int cell, const __sklib_point_2d pt) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = sprite_bitmap_collision(__skparam__s, __skparam__bmp, __skparam__cell, __skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_bitmap_collision__sprite__bitmap__int__double__double(__sklib_sprite s, __sklib_bitmap bmp, int cell, double x, double y) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    bool __skreturn = sprite_bitmap_collision(__skparam__s, __skparam__bmp, __skparam__cell, __skparam__x, __skparam__y);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_collision__sprite__sprite(__sklib_sprite s1, __sklib_sprite s2) {
    sprite __skparam__s1 = __sklib__to_sprite(s1);
    sprite __skparam__s2 = __sklib__to_sprite(s2);
    bool __skreturn = sprite_collision(__skparam__s1, __skparam__s2);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_point_collision__sprite__point_2d_ref(__sklib_sprite s, const __sklib_point_2d pt) {
    sprite __skparam__s = __sklib__to_sprite(s);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = sprite_point_collision(__skparam__s, __skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_rectangle_collision__sprite__rectangle_ref(__sklib_sprite s, const __sklib_rectangle rect) {
    sprite __skparam__s = __sklib__to_sprite(s);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = sprite_rectangle_collision(__skparam__s, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
int __sklib__alpha_of__color(__sklib_color c) {
    color __skparam__c = __sklib__to_color(c);
    int __skreturn = alpha_of(__skparam__c);
    return __sklib__to_int(__skreturn);
}
int __sklib__blue_of__color(__sklib_color c) {
    color __skparam__c = __sklib__to_color(c);
    int __skreturn = blue_of(__skparam__c);
    return __sklib__to_int(__skreturn);
}
double __sklib__brightness_of__color(__sklib_color c) {
    color __skparam__c = __sklib__to_color(c);
    double __skreturn = brightness_of(__skparam__c);
    return __sklib__to_double(__skreturn);
}
__sklib_color __sklib__color_alice_blue() {
    color __skreturn = color_alice_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_antique_white() {
    color __skreturn = color_antique_white();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_aqua() {
    color __skreturn = color_aqua();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_aquamarine() {
    color __skreturn = color_aquamarine();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_azure() {
    color __skreturn = color_azure();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_beige() {
    color __skreturn = color_beige();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_bisque() {
    color __skreturn = color_bisque();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_black() {
    color __skreturn = color_black();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_blanched_almond() {
    color __skreturn = color_blanched_almond();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_blue() {
    color __skreturn = color_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_blue_violet() {
    color __skreturn = color_blue_violet();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_bright_green() {
    color __skreturn = color_bright_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_brown() {
    color __skreturn = color_brown();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_burly_wood() {
    color __skreturn = color_burly_wood();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_cadet_blue() {
    color __skreturn = color_cadet_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_chartreuse() {
    color __skreturn = color_chartreuse();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_chocolate() {
    color __skreturn = color_chocolate();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_coral() {
    color __skreturn = color_coral();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_cornflower_blue() {
    color __skreturn = color_cornflower_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_cornsilk() {
    color __skreturn = color_cornsilk();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_crimson() {
    color __skreturn = color_crimson();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_cyan() {
    color __skreturn = color_cyan();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_blue() {
    color __skreturn = color_dark_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_cyan() {
    color __skreturn = color_dark_cyan();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_goldenrod() {
    color __skreturn = color_dark_goldenrod();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_gray() {
    color __skreturn = color_dark_gray();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_green() {
    color __skreturn = color_dark_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_khaki() {
    color __skreturn = color_dark_khaki();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_magenta() {
    color __skreturn = color_dark_magenta();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_olive_green() {
    color __skreturn = color_dark_olive_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_orange() {
    color __skreturn = color_dark_orange();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_orchid() {
    color __skreturn = color_dark_orchid();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_red() {
    color __skreturn = color_dark_red();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_salmon() {
    color __skreturn = color_dark_salmon();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_sea_green() {
    color __skreturn = color_dark_sea_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_slate_blue() {
    color __skreturn = color_dark_slate_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_slate_gray() {
    color __skreturn = color_dark_slate_gray();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_turquoise() {
    color __skreturn = color_dark_turquoise();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dark_violet() {
    color __skreturn = color_dark_violet();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_deep_pink() {
    color __skreturn = color_deep_pink();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_deep_sky_blue() {
    color __skreturn = color_deep_sky_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dim_gray() {
    color __skreturn = color_dim_gray();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_dodger_blue() {
    color __skreturn = color_dodger_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_firebrick() {
    color __skreturn = color_firebrick();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_floral_white() {
    color __skreturn = color_floral_white();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_forest_green() {
    color __skreturn = color_forest_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_fuchsia() {
    color __skreturn = color_fuchsia();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_gainsboro() {
    color __skreturn = color_gainsboro();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_ghost_white() {
    color __skreturn = color_ghost_white();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_gold() {
    color __skreturn = color_gold();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_goldenrod() {
    color __skreturn = color_goldenrod();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_gray() {
    color __skreturn = color_gray();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_green() {
    color __skreturn = color_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_green_yellow() {
    color __skreturn = color_green_yellow();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_honeydew() {
    color __skreturn = color_honeydew();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_hot_pink() {
    color __skreturn = color_hot_pink();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_indian_red() {
    color __skreturn = color_indian_red();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_indigo() {
    color __skreturn = color_indigo();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_ivory() {
    color __skreturn = color_ivory();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_khaki() {
    color __skreturn = color_khaki();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_lavender() {
    color __skreturn = color_lavender();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_lavender_blush() {
    color __skreturn = color_lavender_blush();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_lawn_green() {
    color __skreturn = color_lawn_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_lemon_chiffon() {
    color __skreturn = color_lemon_chiffon();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_blue() {
    color __skreturn = color_light_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_coral() {
    color __skreturn = color_light_coral();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_cyan() {
    color __skreturn = color_light_cyan();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_goldenrod_yellow() {
    color __skreturn = color_light_goldenrod_yellow();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_gray() {
    color __skreturn = color_light_gray();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_green() {
    color __skreturn = color_light_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_pink() {
    color __skreturn = color_light_pink();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_salmon() {
    color __skreturn = color_light_salmon();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_sea_green() {
    color __skreturn = color_light_sea_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_sky_blue() {
    color __skreturn = color_light_sky_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_slate_gray() {
    color __skreturn = color_light_slate_gray();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_steel_blue() {
    color __skreturn = color_light_steel_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_light_yellow() {
    color __skreturn = color_light_yellow();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_lime() {
    color __skreturn = color_lime();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_lime_green() {
    color __skreturn = color_lime_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_linen() {
    color __skreturn = color_linen();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_magenta() {
    color __skreturn = color_magenta();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_maroon() {
    color __skreturn = color_maroon();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_medium_aquamarine() {
    color __skreturn = color_medium_aquamarine();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_medium_blue() {
    color __skreturn = color_medium_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_medium_orchid() {
    color __skreturn = color_medium_orchid();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_medium_purple() {
    color __skreturn = color_medium_purple();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_medium_sea_green() {
    color __skreturn = color_medium_sea_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_medium_slate_blue() {
    color __skreturn = color_medium_slate_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_medium_spring_green() {
    color __skreturn = color_medium_spring_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_medium_turquoise() {
    color __skreturn = color_medium_turquoise();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_medium_violet_red() {
    color __skreturn = color_medium_violet_red();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_midnight_blue() {
    color __skreturn = color_midnight_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_mint_cream() {
    color __skreturn = color_mint_cream();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_misty_rose() {
    color __skreturn = color_misty_rose();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_moccasin() {
    color __skreturn = color_moccasin();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_navajo_white() {
    color __skreturn = color_navajo_white();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_navy() {
    color __skreturn = color_navy();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_old_lace() {
    color __skreturn = color_old_lace();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_olive() {
    color __skreturn = color_olive();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_olive_drab() {
    color __skreturn = color_olive_drab();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_orange() {
    color __skreturn = color_orange();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_orange_red() {
    color __skreturn = color_orange_red();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_orchid() {
    color __skreturn = color_orchid();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_pale_goldenrod() {
    color __skreturn = color_pale_goldenrod();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_pale_green() {
    color __skreturn = color_pale_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_pale_turquoise() {
    color __skreturn = color_pale_turquoise();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_pale_violet_red() {
    color __skreturn = color_pale_violet_red();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_papaya_whip() {
    color __skreturn = color_papaya_whip();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_peach_puff() {
    color __skreturn = color_peach_puff();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_peru() {
    color __skreturn = color_peru();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_pink() {
    color __skreturn = color_pink();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_plum() {
    color __skreturn = color_plum();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_powder_blue() {
    color __skreturn = color_powder_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_purple() {
    color __skreturn = color_purple();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_red() {
    color __skreturn = color_red();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_rosy_brown() {
    color __skreturn = color_rosy_brown();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_royal_blue() {
    color __skreturn = color_royal_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_saddle_brown() {
    color __skreturn = color_saddle_brown();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_salmon() {
    color __skreturn = color_salmon();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_sandy_brown() {
    color __skreturn = color_sandy_brown();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_sea_green() {
    color __skreturn = color_sea_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_sea_shell() {
    color __skreturn = color_sea_shell();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_sienna() {
    color __skreturn = color_sienna();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_silver() {
    color __skreturn = color_silver();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_sky_blue() {
    color __skreturn = color_sky_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_slate_blue() {
    color __skreturn = color_slate_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_slate_gray() {
    color __skreturn = color_slate_gray();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_snow() {
    color __skreturn = color_snow();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_spring_green() {
    color __skreturn = color_spring_green();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_steel_blue() {
    color __skreturn = color_steel_blue();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_swinburne_red() {
    color __skreturn = color_swinburne_red();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_tan() {
    color __skreturn = color_tan();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_teal() {
    color __skreturn = color_teal();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_thistle() {
    color __skreturn = color_thistle();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_string __sklib__color_to_string__color(__sklib_color c) {
    color __skparam__c = __sklib__to_color(c);
    string __skreturn = color_to_string(__skparam__c);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_color __sklib__color_tomato() {
    color __skreturn = color_tomato();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_transparent() {
    color __skreturn = color_transparent();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_turquoise() {
    color __skreturn = color_turquoise();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_violet() {
    color __skreturn = color_violet();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_wheat() {
    color __skreturn = color_wheat();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_white() {
    color __skreturn = color_white();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_white_smoke() {
    color __skreturn = color_white_smoke();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_yellow() {
    color __skreturn = color_yellow();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_yellow_green() {
    color __skreturn = color_yellow_green();
    return __sklib__to_sklib_color(__skreturn);
}
int __sklib__green_of__color(__sklib_color c) {
    color __skparam__c = __sklib__to_color(c);
    int __skreturn = green_of(__skparam__c);
    return __sklib__to_int(__skreturn);
}
__sklib_color __sklib__hsb_color__double__double__double(double hue, double saturation, double brightness) {
    double __skparam__hue = __sklib__to_double(hue);
    double __skparam__saturation = __sklib__to_double(saturation);
    double __skparam__brightness = __sklib__to_double(brightness);
    color __skreturn = hsb_color(__skparam__hue, __skparam__saturation, __skparam__brightness);
    return __sklib__to_sklib_color(__skreturn);
}
double __sklib__hue_of__color(__sklib_color c) {
    color __skparam__c = __sklib__to_color(c);
    double __skreturn = hue_of(__skparam__c);
    return __sklib__to_double(__skreturn);
}
__sklib_color __sklib__random_color() {
    color __skreturn = random_color();
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__random_rgb_color__int(int alpha) {
    int __skparam__alpha = __sklib__to_int(alpha);
    color __skreturn = random_rgb_color(__skparam__alpha);
    return __sklib__to_sklib_color(__skreturn);
}
int __sklib__red_of__color(__sklib_color c) {
    color __skparam__c = __sklib__to_color(c);
    int __skreturn = red_of(__skparam__c);
    return __sklib__to_int(__skreturn);
}
__sklib_color __sklib__rgb_color__double__double__double(double red, double green, double blue) {
    double __skparam__red = __sklib__to_double(red);
    double __skparam__green = __sklib__to_double(green);
    double __skparam__blue = __sklib__to_double(blue);
    color __skreturn = rgb_color(__skparam__red, __skparam__green, __skparam__blue);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__rgb_color__int__int__int(int red, int green, int blue) {
    int __skparam__red = __sklib__to_int(red);
    int __skparam__green = __sklib__to_int(green);
    int __skparam__blue = __sklib__to_int(blue);
    color __skreturn = rgb_color(__skparam__red, __skparam__green, __skparam__blue);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__rgba_color__double__double__double__double(double red, double green, double blue, double alpha) {
    double __skparam__red = __sklib__to_double(red);
    double __skparam__green = __sklib__to_double(green);
    double __skparam__blue = __sklib__to_double(blue);
    double __skparam__alpha = __sklib__to_double(alpha);
    color __skreturn = rgba_color(__skparam__red, __skparam__green, __skparam__blue, __skparam__alpha);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__rgba_color__int__int__int__int(int red, int green, int blue, int alpha) {
    int __skparam__red = __sklib__to_int(red);
    int __skparam__green = __sklib__to_int(green);
    int __skparam__blue = __sklib__to_int(blue);
    int __skparam__alpha = __sklib__to_int(alpha);
    color __skreturn = rgba_color(__skparam__red, __skparam__green, __skparam__blue, __skparam__alpha);
    return __sklib__to_sklib_color(__skreturn);
}
double __sklib__saturation_of__color(__sklib_color c) {
    color __skparam__c = __sklib__to_color(c);
    double __skreturn = saturation_of(__skparam__c);
    return __sklib__to_double(__skreturn);
}
__sklib_color __sklib__string_to_color__string(__sklib_string str) {
    string __skparam__str = __sklib__to_string(str);
    color __skreturn = string_to_color(__skparam__str);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_drawing_options __sklib__option_defaults() {
    drawing_options __skreturn = option_defaults();
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_draw_to__bitmap(__sklib_bitmap dest) {
    bitmap __skparam__dest = __sklib__to_bitmap(dest);
    drawing_options __skreturn = option_draw_to(__skparam__dest);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_draw_to__bitmap__drawing_options(__sklib_bitmap dest, __sklib_drawing_options opts) {
    bitmap __skparam__dest = __sklib__to_bitmap(dest);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_draw_to(__skparam__dest, __skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_draw_to__window(__sklib_window dest) {
    window __skparam__dest = __sklib__to_window(dest);
    drawing_options __skreturn = option_draw_to(__skparam__dest);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_draw_to__window__drawing_options(__sklib_window dest, __sklib_drawing_options opts) {
    window __skparam__dest = __sklib__to_window(dest);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_draw_to(__skparam__dest, __skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_flip_x() {
    drawing_options __skreturn = option_flip_x();
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_flip_x__drawing_options(__sklib_drawing_options opts) {
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_flip_x(__skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_flip_xy() {
    drawing_options __skreturn = option_flip_xy();
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_flip_xy__drawing_options(__sklib_drawing_options opts) {
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_flip_xy(__skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_flip_y() {
    drawing_options __skreturn = option_flip_y();
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_flip_y__drawing_options(__sklib_drawing_options opts) {
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_flip_y(__skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_line_width__int(int width) {
    int __skparam__width = __sklib__to_int(width);
    drawing_options __skreturn = option_line_width(__skparam__width);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_line_width__int__drawing_options(int width, __sklib_drawing_options opts) {
    int __skparam__width = __sklib__to_int(width);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_line_width(__skparam__width, __skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_part_bmp__double__double__double__double(double x, double y, double w, double h) {
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__w = __sklib__to_double(w);
    double __skparam__h = __sklib__to_double(h);
    drawing_options __skreturn = option_part_bmp(__skparam__x, __skparam__y, __skparam__w, __skparam__h);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_part_bmp__double__double__double__double__drawing_options(double x, double y, double w, double h, __sklib_drawing_options opts) {
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__w = __sklib__to_double(w);
    double __skparam__h = __sklib__to_double(h);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_part_bmp(__skparam__x, __skparam__y, __skparam__w, __skparam__h, __skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_part_bmp__rectangle(__sklib_rectangle part) {
    rectangle __skparam__part = __sklib__to_rectangle(part);
    drawing_options __skreturn = option_part_bmp(__skparam__part);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_part_bmp__rectangle__drawing_options(__sklib_rectangle part, __sklib_drawing_options opts) {
    rectangle __skparam__part = __sklib__to_rectangle(part);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_part_bmp(__skparam__part, __skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_rotate_bmp__double(double angle) {
    double __skparam__angle = __sklib__to_double(angle);
    drawing_options __skreturn = option_rotate_bmp(__skparam__angle);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_rotate_bmp__double__double__double(double angle, double anchor_x, double anchor_y) {
    double __skparam__angle = __sklib__to_double(angle);
    double __skparam__anchor_x = __sklib__to_double(anchor_x);
    double __skparam__anchor_y = __sklib__to_double(anchor_y);
    drawing_options __skreturn = option_rotate_bmp(__skparam__angle, __skparam__anchor_x, __skparam__anchor_y);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_rotate_bmp__double__double__double__drawing_options(double angle, double anchor_x, double anchor_y, __sklib_drawing_options opts) {
    double __skparam__angle = __sklib__to_double(angle);
    double __skparam__anchor_x = __sklib__to_double(anchor_x);
    double __skparam__anchor_y = __sklib__to_double(anchor_y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_rotate_bmp(__skparam__angle, __skparam__anchor_x, __skparam__anchor_y, __skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_rotate_bmp__double__drawing_options(double angle, __sklib_drawing_options opts) {
    double __skparam__angle = __sklib__to_double(angle);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_rotate_bmp(__skparam__angle, __skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_scale_bmp__double__double(double scale_x, double scale_y) {
    double __skparam__scale_x = __sklib__to_double(scale_x);
    double __skparam__scale_y = __sklib__to_double(scale_y);
    drawing_options __skreturn = option_scale_bmp(__skparam__scale_x, __skparam__scale_y);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_scale_bmp__double__double__drawing_options(double scale_x, double scale_y, __sklib_drawing_options opts) {
    double __skparam__scale_x = __sklib__to_double(scale_x);
    double __skparam__scale_y = __sklib__to_double(scale_y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_scale_bmp(__skparam__scale_x, __skparam__scale_y, __skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_to_screen() {
    drawing_options __skreturn = option_to_screen();
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_to_screen__drawing_options(__sklib_drawing_options opts) {
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_to_screen(__skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_to_world() {
    drawing_options __skreturn = option_to_world();
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_to_world__drawing_options(__sklib_drawing_options opts) {
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_to_world(__skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_with_animation__animation(__sklib_animation anim) {
    animation __skparam__anim = __sklib__to_animation(anim);
    drawing_options __skreturn = option_with_animation(__skparam__anim);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_with_animation__animation__drawing_options(__sklib_animation anim, __sklib_drawing_options opts) {
    animation __skparam__anim = __sklib__to_animation(anim);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_with_animation(__skparam__anim, __skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_with_bitmap_cell__int(int cell) {
    int __skparam__cell = __sklib__to_int(cell);
    drawing_options __skreturn = option_with_bitmap_cell(__skparam__cell);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
__sklib_drawing_options __sklib__option_with_bitmap_cell__int__drawing_options(int cell, __sklib_drawing_options opts) {
    int __skparam__cell = __sklib__to_int(cell);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    drawing_options __skreturn = option_with_bitmap_cell(__skparam__cell, __skparam__opts);
    return __sklib__to_sklib_drawing_options(__skreturn);
}
void __sklib__draw_ellipse__color__rectangle(__sklib_color clr, const __sklib_rectangle rect) {
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    draw_ellipse(__skparam__clr, __skparam__rect);
}
void __sklib__draw_ellipse__color__rectangle__drawing_options(__sklib_color clr, const __sklib_rectangle rect, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_ellipse(__skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__draw_ellipse__color__double__double__double__double(__sklib_color clr, double x, double y, double width, double height) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    draw_ellipse(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__draw_ellipse__color__double__double__double__double__drawing_options(__sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_ellipse(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
void __sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle(__sklib_bitmap destination, __sklib_color clr, const __sklib_rectangle rect) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    draw_ellipse_on_bitmap(__skparam__destination, __skparam__clr, __skparam__rect);
}
void __sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(__sklib_bitmap destination, __sklib_color clr, const __sklib_rectangle rect, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_ellipse_on_bitmap(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double(__sklib_bitmap destination, __sklib_color clr, double x, double y, double width, double height) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    draw_ellipse_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__sklib_bitmap destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_ellipse_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
void __sklib__draw_ellipse_on_window__window__color__rectangle(__sklib_window destination, __sklib_color clr, const __sklib_rectangle rect) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    draw_ellipse_on_window(__skparam__destination, __skparam__clr, __skparam__rect);
}
void __sklib__draw_ellipse_on_window__window__color__rectangle__drawing_options(__sklib_window destination, __sklib_color clr, const __sklib_rectangle rect, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_ellipse_on_window(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__draw_ellipse_on_window__window__color__double__double__double__double(__sklib_window destination, __sklib_color clr, double x, double y, double width, double height) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    draw_ellipse_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__draw_ellipse_on_window__window__color__double__double__double__double__drawing_options(__sklib_window destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_ellipse_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
void __sklib__fill_ellipse__color__rectangle(__sklib_color clr, const __sklib_rectangle rect) {
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    fill_ellipse(__skparam__clr, __skparam__rect);
}
void __sklib__fill_ellipse__color__rectangle__drawing_options(__sklib_color clr, const __sklib_rectangle rect, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_ellipse(__skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__fill_ellipse__color__double__double__double__double(__sklib_color clr, double x, double y, double width, double height) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    fill_ellipse(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__fill_ellipse__color__double__double__double__double__drawing_options(__sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_ellipse(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
void __sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle(__sklib_bitmap destination, __sklib_color clr, const __sklib_rectangle rect) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    fill_ellipse_on_bitmap(__skparam__destination, __skparam__clr, __skparam__rect);
}
void __sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(__sklib_bitmap destination, __sklib_color clr, const __sklib_rectangle rect, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_ellipse_on_bitmap(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double(__sklib_bitmap destination, __sklib_color clr, double x, double y, double width, double height) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    fill_ellipse_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__sklib_bitmap destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_ellipse_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
void __sklib__fill_ellipse_on_window__window__color__rectangle(__sklib_window destination, __sklib_color clr, const __sklib_rectangle rect) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    fill_ellipse_on_window(__skparam__destination, __skparam__clr, __skparam__rect);
}
void __sklib__fill_ellipse_on_window__window__color__rectangle__drawing_options(__sklib_window destination, __sklib_color clr, const __sklib_rectangle rect, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    const rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_ellipse_on_window(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__fill_ellipse_on_window__window__color__double__double__double__double(__sklib_window destination, __sklib_color clr, double x, double y, double width, double height) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    fill_ellipse_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__fill_ellipse_on_window__window__color__double__double__double__double__drawing_options(__sklib_window destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_ellipse_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
float __sklib__cosine__float(float degrees) {
    float __skparam__degrees = __sklib__to_float(degrees);
    float __skreturn = cosine(__skparam__degrees);
    return __sklib__to_float(__skreturn);
}
float __sklib__sine__float(float degrees) {
    float __skparam__degrees = __sklib__to_float(degrees);
    float __skreturn = sine(__skparam__degrees);
    return __sklib__to_float(__skreturn);
}
float __sklib__tangent__float(float degrees) {
    float __skparam__degrees = __sklib__to_float(degrees);
    float __skreturn = tangent(__skparam__degrees);
    return __sklib__to_float(__skreturn);
}
void __sklib__clear_screen() {
    clear_screen();
}
void __sklib__clear_screen__color(__sklib_color clr) {
    color __skparam__clr = __sklib__to_color(clr);
    clear_screen(__skparam__clr);
}
__sklib_display __sklib__display_details__unsigned_int(unsigned int index) {
    unsigned int __skparam__index = __sklib__to_unsigned_int(index);
    display __skreturn = display_details(__skparam__index);
    return __sklib__to_sklib_display(__skreturn);
}
int __sklib__display_height__display(__sklib_display disp) {
    display __skparam__disp = __sklib__to_display(disp);
    int __skreturn = display_height(__skparam__disp);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__display_name__display(__sklib_display disp) {
    display __skparam__disp = __sklib__to_display(disp);
    string __skreturn = display_name(__skparam__disp);
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__display_width__display(__sklib_display disp) {
    display __skparam__disp = __sklib__to_display(disp);
    int __skreturn = display_width(__skparam__disp);
    return __sklib__to_int(__skreturn);
}
int __sklib__display_x__display(__sklib_display disp) {
    display __skparam__disp = __sklib__to_display(disp);
    int __skreturn = display_x(__skparam__disp);
    return __sklib__to_int(__skreturn);
}
int __sklib__display_y__display(__sklib_display disp) {
    display __skparam__disp = __sklib__to_display(disp);
    int __skreturn = display_y(__skparam__disp);
    return __sklib__to_int(__skreturn);
}
int __sklib__number_of_displays() {
    int __skreturn = number_of_displays();
    return __sklib__to_int(__skreturn);
}
void __sklib__refresh_screen() {
    refresh_screen();
}
void __sklib__refresh_screen__unsigned_int(unsigned int target_fps) {
    unsigned int __skparam__target_fps = __sklib__to_unsigned_int(target_fps);
    refresh_screen(__skparam__target_fps);
}
void __sklib__save_bitmap__bitmap__string_ref(__sklib_bitmap bmp, const __sklib_string basename) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    string __skparam__basename = __sklib__to_string(basename);
    save_bitmap(__skparam__bmp, __skparam__basename);
}
int __sklib__screen_height() {
    int __skreturn = screen_height();
    return __sklib__to_int(__skreturn);
}
int __sklib__screen_width() {
    int __skreturn = screen_width();
    return __sklib__to_int(__skreturn);
}
void __sklib__take_screenshot__string_ref(const __sklib_string basename) {
    string __skparam__basename = __sklib__to_string(basename);
    take_screenshot(__skparam__basename);
}
void __sklib__take_screenshot__window__string_ref(__sklib_window wind, const __sklib_string basename) {
    window __skparam__wind = __sklib__to_window(wind);
    string __skparam__basename = __sklib__to_string(basename);
    take_screenshot(__skparam__wind, __skparam__basename);
}
__sklib_circle __sklib__bitmap_bounding_circle__bitmap__point_2d_ref(__sklib_bitmap bmp, const __sklib_point_2d pt) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    circle __skreturn = bitmap_bounding_circle(__skparam__bmp, __skparam__pt);
    return __sklib__to_sklib_circle(__skreturn);
}
__sklib_rectangle __sklib__bitmap_bounding_rectangle__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    rectangle __skreturn = bitmap_bounding_rectangle(__skparam__bmp);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__bitmap_bounding_rectangle__bitmap__double__double(__sklib_bitmap bmp, double x, double y) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    rectangle __skreturn = bitmap_bounding_rectangle(__skparam__bmp, __skparam__x, __skparam__y);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_point_2d __sklib__bitmap_cell_center__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    point_2d __skreturn = bitmap_cell_center(__skparam__bmp);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_circle __sklib__bitmap_cell_circle__bitmap__double__double(__sklib_bitmap bmp, double x, double y) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    circle __skreturn = bitmap_cell_circle(__skparam__bmp, __skparam__x, __skparam__y);
    return __sklib__to_sklib_circle(__skreturn);
}
__sklib_circle __sklib__bitmap_cell_circle__bitmap__point_2d(__sklib_bitmap bmp, const __sklib_point_2d pt) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    const point_2d __skparam__pt = __sklib__to_point_2d(pt);
    circle __skreturn = bitmap_cell_circle(__skparam__bmp, __skparam__pt);
    return __sklib__to_sklib_circle(__skreturn);
}
__sklib_circle __sklib__bitmap_cell_circle__bitmap__point_2d__double(__sklib_bitmap bmp, const __sklib_point_2d pt, double scale) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    const point_2d __skparam__pt = __sklib__to_point_2d(pt);
    double __skparam__scale = __sklib__to_double(scale);
    circle __skreturn = bitmap_cell_circle(__skparam__bmp, __skparam__pt, __skparam__scale);
    return __sklib__to_sklib_circle(__skreturn);
}
int __sklib__bitmap_cell_columns__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skreturn = bitmap_cell_columns(__skparam__bmp);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_cell_count__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skreturn = bitmap_cell_count(__skparam__bmp);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_cell_height__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skreturn = bitmap_cell_height(__skparam__bmp);
    return __sklib__to_int(__skreturn);
}
__sklib_vector_2d __sklib__bitmap_cell_offset__bitmap__int(__sklib_bitmap src, int cell) {
    bitmap __skparam__src = __sklib__to_bitmap(src);
    int __skparam__cell = __sklib__to_int(cell);
    vector_2d __skreturn = bitmap_cell_offset(__skparam__src, __skparam__cell);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_rectangle __sklib__bitmap_cell_rectangle__bitmap(__sklib_bitmap src) {
    bitmap __skparam__src = __sklib__to_bitmap(src);
    rectangle __skreturn = bitmap_cell_rectangle(__skparam__src);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__bitmap_cell_rectangle__bitmap__point_2d_ref(__sklib_bitmap src, const __sklib_point_2d pt) {
    bitmap __skparam__src = __sklib__to_bitmap(src);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    rectangle __skreturn = bitmap_cell_rectangle(__skparam__src, __skparam__pt);
    return __sklib__to_sklib_rectangle(__skreturn);
}
int __sklib__bitmap_cell_rows__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skreturn = bitmap_cell_rows(__skparam__bmp);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_cell_width__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skreturn = bitmap_cell_width(__skparam__bmp);
    return __sklib__to_int(__skreturn);
}
__sklib_point_2d __sklib__bitmap_center__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    point_2d __skreturn = bitmap_center(__skparam__bmp);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_string __sklib__bitmap_filename__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    string __skreturn = bitmap_filename(__skparam__bmp);
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__bitmap_height__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skreturn = bitmap_height(__skparam__bmp);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_height__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = bitmap_height(__skparam__name);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__bitmap_name__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    string __skreturn = bitmap_name(__skparam__bmp);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_bitmap __sklib__bitmap_named__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bitmap __skreturn = bitmap_named(__skparam__name);
    return __sklib__to_sklib_bitmap(__skreturn);
}
__sklib_rectangle __sklib__bitmap_rectangle_of_cell__bitmap__int(__sklib_bitmap src, int cell) {
    bitmap __skparam__src = __sklib__to_bitmap(src);
    int __skparam__cell = __sklib__to_int(cell);
    rectangle __skreturn = bitmap_rectangle_of_cell(__skparam__src, __skparam__cell);
    return __sklib__to_sklib_rectangle(__skreturn);
}
void __sklib__bitmap_set_cell_details__bitmap__int__int__int__int__int(__sklib_bitmap bmp, int width, int height, int columns, int rows, int count) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__width = __sklib__to_int(width);
    int __skparam__height = __sklib__to_int(height);
    int __skparam__columns = __sklib__to_int(columns);
    int __skparam__rows = __sklib__to_int(rows);
    int __skparam__count = __sklib__to_int(count);
    bitmap_set_cell_details(__skparam__bmp, __skparam__width, __skparam__height, __skparam__columns, __skparam__rows, __skparam__count);
}
int __sklib__bitmap_valid__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    bool __skreturn = bitmap_valid(__skparam__bmp);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_width__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skreturn = bitmap_width(__skparam__bmp);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_width__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = bitmap_width(__skparam__name);
    return __sklib__to_int(__skreturn);
}
void __sklib__clear_bitmap__bitmap__color(__sklib_bitmap bmp, __sklib_color clr) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    color __skparam__clr = __sklib__to_color(clr);
    clear_bitmap(__skparam__bmp, __skparam__clr);
}
void __sklib__clear_bitmap__string__color(__sklib_string name, __sklib_color clr) {
    string __skparam__name = __sklib__to_string(name);
    color __skparam__clr = __sklib__to_color(clr);
    clear_bitmap(__skparam__name, __skparam__clr);
}
__sklib_bitmap __sklib__create_bitmap__string__int__int(__sklib_string name, int width, int height) {
    string __skparam__name = __sklib__to_string(name);
    int __skparam__width = __sklib__to_int(width);
    int __skparam__height = __sklib__to_int(height);
    bitmap __skreturn = create_bitmap(__skparam__name, __skparam__width, __skparam__height);
    return __sklib__to_sklib_bitmap(__skreturn);
}
void __sklib__draw_bitmap__bitmap__double__double(__sklib_bitmap bmp, double x, double y) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_bitmap(__skparam__bmp, __skparam__x, __skparam__y);
}
void __sklib__draw_bitmap__bitmap__double__double__drawing_options(__sklib_bitmap bmp, double x, double y, __sklib_drawing_options opts) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_bitmap(__skparam__bmp, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_bitmap__string__double__double(__sklib_string name, double x, double y) {
    string __skparam__name = __sklib__to_string(name);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_bitmap(__skparam__name, __skparam__x, __skparam__y);
}
void __sklib__draw_bitmap__string__double__double__drawing_options(__sklib_string name, double x, double y, __sklib_drawing_options opts) {
    string __skparam__name = __sklib__to_string(name);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_bitmap(__skparam__name, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double(__sklib_bitmap destination, __sklib_bitmap bmp, double x, double y) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_bitmap_on_bitmap(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y);
}
void __sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double__drawing_options(__sklib_bitmap destination, __sklib_bitmap bmp, double x, double y, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_bitmap_on_bitmap(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_bitmap_on_window__window__bitmap__double__double(__sklib_window destination, __sklib_bitmap bmp, double x, double y) {
    window __skparam__destination = __sklib__to_window(destination);
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_bitmap_on_window(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y);
}
void __sklib__draw_bitmap_on_window__window__bitmap__double__double__drawing_options(__sklib_window destination, __sklib_bitmap bmp, double x, double y, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_bitmap_on_window(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__free_all_bitmaps() {
    free_all_bitmaps();
}
void __sklib__free_bitmap__bitmap(__sklib_bitmap to_delete) {
    bitmap __skparam__to_delete = __sklib__to_bitmap(to_delete);
    free_bitmap(__skparam__to_delete);
}
int __sklib__has_bitmap__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_bitmap(__skparam__name);
    return __sklib__to_int(__skreturn);
}
__sklib_bitmap __sklib__load_bitmap__string__string(__sklib_string name, __sklib_string filename) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__filename = __sklib__to_string(filename);
    bitmap __skreturn = load_bitmap(__skparam__name, __skparam__filename);
    return __sklib__to_sklib_bitmap(__skreturn);
}
int __sklib__pixel_drawn_at_point__bitmap__point_2d_ref(__sklib_bitmap bmp, const __sklib_point_2d pt) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = pixel_drawn_at_point(__skparam__bmp, __skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__pixel_drawn_at_point__bitmap__double__double(__sklib_bitmap bmp, double x, double y) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    bool __skreturn = pixel_drawn_at_point(__skparam__bmp, __skparam__x, __skparam__y);
    return __sklib__to_int(__skreturn);
}
int __sklib__pixel_drawn_at_point__bitmap__int__point_2d_ref(__sklib_bitmap bmp, int cell, const __sklib_point_2d pt) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = pixel_drawn_at_point(__skparam__bmp, __skparam__cell, __skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__pixel_drawn_at_point__bitmap__int__double__double(__sklib_bitmap bmp, int cell, double x, double y) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    int __skparam__cell = __sklib__to_int(cell);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    bool __skreturn = pixel_drawn_at_point(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y);
    return __sklib__to_int(__skreturn);
}
void __sklib__setup_collision_mask__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    setup_collision_mask(__skparam__bmp);
}
void __sklib__process_events() {
    process_events();
}
int __sklib__quit_requested() {
    bool __skreturn = quit_requested();
    return __sklib__to_int(__skreturn);
}
void __sklib__reset_quit() {
    reset_quit();
}
void __sklib__add_column__int(int width) {
    int __skparam__width = __sklib__to_int(width);
    add_column(__skparam__width);
}
void __sklib__add_column_relative__double(double width) {
    double __skparam__width = __sklib__to_double(width);
    add_column_relative(__skparam__width);
}
int __sklib__bitmap_button__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    bool __skreturn = bitmap_button(__skparam__bmp);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_button__bitmap__rectangle_ref(__sklib_bitmap bmp, const __sklib_rectangle rect) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = bitmap_button(__skparam__bmp, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_button__bitmap__rectangle_ref__drawing_options(__sklib_bitmap bmp, const __sklib_rectangle rect, __sklib_drawing_options opts) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    bool __skreturn = bitmap_button(__skparam__bmp, __skparam__rect, __skparam__opts);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_button__bitmap__drawing_options(__sklib_bitmap bmp, __sklib_drawing_options opts) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    bool __skreturn = bitmap_button(__skparam__bmp, __skparam__opts);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_button__string_ref__bitmap(const __sklib_string label_text, __sklib_bitmap bmp) {
    string __skparam__label_text = __sklib__to_string(label_text);
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    bool __skreturn = bitmap_button(__skparam__label_text, __skparam__bmp);
    return __sklib__to_int(__skreturn);
}
int __sklib__bitmap_button__string_ref__bitmap__drawing_options(const __sklib_string label_text, __sklib_bitmap bmp, __sklib_drawing_options opts) {
    string __skparam__label_text = __sklib__to_string(label_text);
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    bool __skreturn = bitmap_button(__skparam__label_text, __skparam__bmp, __skparam__opts);
    return __sklib__to_int(__skreturn);
}
int __sklib__button__string_ref__rectangle_ref(const __sklib_string text, const __sklib_rectangle rect) {
    string __skparam__text = __sklib__to_string(text);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = button(__skparam__text, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
int __sklib__button__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    bool __skreturn = button(__skparam__text);
    return __sklib__to_int(__skreturn);
}
int __sklib__button__string_ref__string_ref(const __sklib_string label_text, const __sklib_string text) {
    string __skparam__label_text = __sklib__to_string(label_text);
    string __skparam__text = __sklib__to_string(text);
    bool __skreturn = button(__skparam__label_text, __skparam__text);
    return __sklib__to_int(__skreturn);
}
int __sklib__checkbox__string_ref__bool_ref__rectangle_ref(const __sklib_string text, const int value, const __sklib_rectangle rect) {
    string __skparam__text = __sklib__to_string(text);
    bool __skparam__value = __sklib__to_bool(value);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = checkbox(__skparam__text, __skparam__value, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
int __sklib__checkbox__string_ref__bool_ref(const __sklib_string text, const int value) {
    string __skparam__text = __sklib__to_string(text);
    bool __skparam__value = __sklib__to_bool(value);
    bool __skreturn = checkbox(__skparam__text, __skparam__value);
    return __sklib__to_int(__skreturn);
}
int __sklib__checkbox__string_ref__string_ref__bool_ref(const __sklib_string label_text, const __sklib_string text, const int value) {
    string __skparam__label_text = __sklib__to_string(label_text);
    string __skparam__text = __sklib__to_string(text);
    bool __skparam__value = __sklib__to_bool(value);
    bool __skreturn = checkbox(__skparam__label_text, __skparam__text, __skparam__value);
    return __sklib__to_int(__skreturn);
}
__sklib_color __sklib__color_slider__color_ref__rectangle_ref(const __sklib_color clr, const __sklib_rectangle rect) {
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    color __skreturn = color_slider(__skparam__clr, __skparam__rect);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_slider__color_ref(const __sklib_color clr) {
    color __skparam__clr = __sklib__to_color(clr);
    color __skreturn = color_slider(__skparam__clr);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__color_slider__string_ref__color_ref(const __sklib_string label_text, const __sklib_color clr) {
    string __skparam__label_text = __sklib__to_string(label_text);
    color __skparam__clr = __sklib__to_color(clr);
    color __skreturn = color_slider(__skparam__label_text, __skparam__clr);
    return __sklib__to_sklib_color(__skreturn);
}
void __sklib__disable_interface() {
    disable_interface();
}
void __sklib__draw_interface() {
    draw_interface();
}
void __sklib__enable_interface() {
    enable_interface();
}
void __sklib__end_inset__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    end_inset(__skparam__name);
}
void __sklib__end_panel__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    end_panel(__skparam__name);
}
void __sklib__end_popup__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    end_popup(__skparam__name);
}
void __sklib__end_treenode__string_ref(const __sklib_string label_text) {
    string __skparam__label_text = __sklib__to_string(label_text);
    end_treenode(__skparam__label_text);
}
void __sklib__enter_column() {
    enter_column();
}
int __sklib__get_interface_label_width() {
    int __skreturn = get_interface_label_width();
    return __sklib__to_int(__skreturn);
}
int __sklib__header__string_ref(const __sklib_string label_text) {
    string __skparam__label_text = __sklib__to_string(label_text);
    bool __skreturn = header(__skparam__label_text);
    return __sklib__to_int(__skreturn);
}
__sklib_color __sklib__hsb_color_slider__color_ref__rectangle_ref(const __sklib_color clr, const __sklib_rectangle rect) {
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    color __skreturn = hsb_color_slider(__skparam__clr, __skparam__rect);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__hsb_color_slider__color_ref(const __sklib_color clr) {
    color __skparam__clr = __sklib__to_color(clr);
    color __skreturn = hsb_color_slider(__skparam__clr);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__hsb_color_slider__string_ref__color_ref(const __sklib_string label_text, const __sklib_color clr) {
    string __skparam__label_text = __sklib__to_string(label_text);
    color __skparam__clr = __sklib__to_color(clr);
    color __skreturn = hsb_color_slider(__skparam__label_text, __skparam__clr);
    return __sklib__to_sklib_color(__skreturn);
}
int __sklib__interface_enabled() {
    bool __skreturn = interface_enabled();
    return __sklib__to_int(__skreturn);
}
void __sklib__interface_style_panel__rectangle_ref(const __sklib_rectangle initial_rectangle) {
    rectangle __skparam__initial_rectangle = __sklib__to_rectangle(initial_rectangle);
    interface_style_panel(__skparam__initial_rectangle);
}
void __sklib__label_element__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    label_element(__skparam__text);
}
void __sklib__label_element__string_ref__rectangle_ref(const __sklib_string text, const __sklib_rectangle rect) {
    string __skparam__text = __sklib__to_string(text);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    label_element(__skparam__text, __skparam__rect);
}
int __sklib__last_element_changed() {
    bool __skreturn = last_element_changed();
    return __sklib__to_int(__skreturn);
}
int __sklib__last_element_confirmed() {
    bool __skreturn = last_element_confirmed();
    return __sklib__to_int(__skreturn);
}
void __sklib__leave_column() {
    leave_column();
}
float __sklib__number_box__float_ref__float__rectangle_ref(const float value, float step, const __sklib_rectangle rect) {
    float __skparam__value = __sklib__to_float(value);
    float __skparam__step = __sklib__to_float(step);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    float __skreturn = number_box(__skparam__value, __skparam__step, __skparam__rect);
    return __sklib__to_float(__skreturn);
}
float __sklib__number_box__float_ref__float(const float value, float step) {
    float __skparam__value = __sklib__to_float(value);
    float __skparam__step = __sklib__to_float(step);
    float __skreturn = number_box(__skparam__value, __skparam__step);
    return __sklib__to_float(__skreturn);
}
float __sklib__number_box__string_ref__float_ref__float(const __sklib_string label_text, const float value, float step) {
    string __skparam__label_text = __sklib__to_string(label_text);
    float __skparam__value = __sklib__to_float(value);
    float __skparam__step = __sklib__to_float(step);
    float __skreturn = number_box(__skparam__label_text, __skparam__value, __skparam__step);
    return __sklib__to_float(__skreturn);
}
void __sklib__open_popup__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    open_popup(__skparam__name);
}
void __sklib__paragraph__string_ref(const __sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    paragraph(__skparam__text);
}
void __sklib__paragraph__string_ref__rectangle_ref(const __sklib_string text, const __sklib_rectangle rect) {
    string __skparam__text = __sklib__to_string(text);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    paragraph(__skparam__text, __skparam__rect);
}
void __sklib__reset_layout() {
    reset_layout();
}
void __sklib__set_interface_accent_color__color__float(__sklib_color clr, float contrast) {
    color __skparam__clr = __sklib__to_color(clr);
    float __skparam__contrast = __sklib__to_float(contrast);
    set_interface_accent_color(__skparam__clr, __skparam__contrast);
}
void __sklib__set_interface_border_color__color(__sklib_color clr) {
    color __skparam__clr = __sklib__to_color(clr);
    set_interface_border_color(__skparam__clr);
}
void __sklib__set_interface_colors_auto__color__color__float__float__float(__sklib_color main_clr, __sklib_color accent_clr, float contrast, float accent_contrast, float border_contrast) {
    color __skparam__main_clr = __sklib__to_color(main_clr);
    color __skparam__accent_clr = __sklib__to_color(accent_clr);
    float __skparam__contrast = __sklib__to_float(contrast);
    float __skparam__accent_contrast = __sklib__to_float(accent_contrast);
    float __skparam__border_contrast = __sklib__to_float(border_contrast);
    set_interface_colors_auto(__skparam__main_clr, __skparam__accent_clr, __skparam__contrast, __skparam__accent_contrast, __skparam__border_contrast);
}
void __sklib__set_interface_element_color__color__float(__sklib_color clr, float contrast) {
    color __skparam__clr = __sklib__to_color(clr);
    float __skparam__contrast = __sklib__to_float(contrast);
    set_interface_element_color(__skparam__clr, __skparam__contrast);
}
void __sklib__set_interface_element_shadows__int__color__point_2d(int radius, __sklib_color clr, __sklib_point_2d offset) {
    int __skparam__radius = __sklib__to_int(radius);
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__offset = __sklib__to_point_2d(offset);
    set_interface_element_shadows(__skparam__radius, __skparam__clr, __skparam__offset);
}
void __sklib__set_interface_font__string_ref(const __sklib_string fnt) {
    string __skparam__fnt = __sklib__to_string(fnt);
    set_interface_font(__skparam__fnt);
}
void __sklib__set_interface_font__font(__sklib_font fnt) {
    font __skparam__fnt = __sklib__to_font(fnt);
    set_interface_font(__skparam__fnt);
}
void __sklib__set_interface_font_size__int(int size) {
    int __skparam__size = __sklib__to_int(size);
    set_interface_font_size(__skparam__size);
}
void __sklib__set_interface_label_width__int(int width) {
    int __skparam__width = __sklib__to_int(width);
    set_interface_label_width(__skparam__width);
}
void __sklib__set_interface_panel_shadows__int__color__point_2d(int radius, __sklib_color clr, __sklib_point_2d offset) {
    int __skparam__radius = __sklib__to_int(radius);
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__offset = __sklib__to_point_2d(offset);
    set_interface_panel_shadows(__skparam__radius, __skparam__clr, __skparam__offset);
}
void __sklib__set_interface_root_text_color__color(__sklib_color clr) {
    color __skparam__clr = __sklib__to_color(clr);
    set_interface_root_text_color(__skparam__clr);
}
void __sklib__set_interface_shadows__int__color__point_2d(int radius, __sklib_color clr, __sklib_point_2d offset) {
    int __skparam__radius = __sklib__to_int(radius);
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__offset = __sklib__to_point_2d(offset);
    set_interface_shadows(__skparam__radius, __skparam__clr, __skparam__offset);
}
void __sklib__set_interface_spacing__int__int(int spacing, int padding) {
    int __skparam__spacing = __sklib__to_int(spacing);
    int __skparam__padding = __sklib__to_int(padding);
    set_interface_spacing(__skparam__spacing, __skparam__padding);
}
void __sklib__set_interface_style__interface_style(int style) {
    interface_style __skparam__style = __sklib__to_interface_style(style);
    set_interface_style(__skparam__style);
}
void __sklib__set_interface_style__interface_style__color(int style, __sklib_color clr) {
    interface_style __skparam__style = __sklib__to_interface_style(style);
    color __skparam__clr = __sklib__to_color(clr);
    set_interface_style(__skparam__style, __skparam__clr);
}
void __sklib__set_interface_text_color__color(__sklib_color clr) {
    color __skparam__clr = __sklib__to_color(clr);
    set_interface_text_color(__skparam__clr);
}
void __sklib__set_layout_height__int(int height) {
    int __skparam__height = __sklib__to_int(height);
    set_layout_height(__skparam__height);
}
void __sklib__single_line_layout() {
    single_line_layout();
}
float __sklib__slider__float_ref__float__float__rectangle_ref(const float value, float min_value, float max_value, const __sklib_rectangle rect) {
    float __skparam__value = __sklib__to_float(value);
    float __skparam__min_value = __sklib__to_float(min_value);
    float __skparam__max_value = __sklib__to_float(max_value);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    float __skreturn = slider(__skparam__value, __skparam__min_value, __skparam__max_value, __skparam__rect);
    return __sklib__to_float(__skreturn);
}
float __sklib__slider__float_ref__float__float(const float value, float min_value, float max_value) {
    float __skparam__value = __sklib__to_float(value);
    float __skparam__min_value = __sklib__to_float(min_value);
    float __skparam__max_value = __sklib__to_float(max_value);
    float __skreturn = slider(__skparam__value, __skparam__min_value, __skparam__max_value);
    return __sklib__to_float(__skreturn);
}
float __sklib__slider__string_ref__float_ref__float__float(const __sklib_string label_text, const float value, float min_value, float max_value) {
    string __skparam__label_text = __sklib__to_string(label_text);
    float __skparam__value = __sklib__to_float(value);
    float __skparam__min_value = __sklib__to_float(min_value);
    float __skparam__max_value = __sklib__to_float(max_value);
    float __skreturn = slider(__skparam__label_text, __skparam__value, __skparam__min_value, __skparam__max_value);
    return __sklib__to_float(__skreturn);
}
void __sklib__split_into_columns__int(int count) {
    int __skparam__count = __sklib__to_int(count);
    split_into_columns(__skparam__count);
}
void __sklib__split_into_columns__int__int(int count, int last_width) {
    int __skparam__count = __sklib__to_int(count);
    int __skparam__last_width = __sklib__to_int(last_width);
    split_into_columns(__skparam__count, __skparam__last_width);
}
void __sklib__split_into_columns_relative__int__double(int count, double last_width) {
    int __skparam__count = __sklib__to_int(count);
    double __skparam__last_width = __sklib__to_double(last_width);
    split_into_columns_relative(__skparam__count, __skparam__last_width);
}
void __sklib__start_custom_layout() {
    start_custom_layout();
}
void __sklib__start_inset__string_ref__rectangle_ref(const __sklib_string name, const __sklib_rectangle rect) {
    string __skparam__name = __sklib__to_string(name);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    start_inset(__skparam__name, __skparam__rect);
}
void __sklib__start_inset__string_ref__int(const __sklib_string name, int height) {
    string __skparam__name = __sklib__to_string(name);
    int __skparam__height = __sklib__to_int(height);
    start_inset(__skparam__name, __skparam__height);
}
int __sklib__start_panel__string_ref__rectangle(const __sklib_string name, __sklib_rectangle initial_rectangle) {
    string __skparam__name = __sklib__to_string(name);
    rectangle __skparam__initial_rectangle = __sklib__to_rectangle(initial_rectangle);
    bool __skreturn = start_panel(__skparam__name, __skparam__initial_rectangle);
    return __sklib__to_int(__skreturn);
}
int __sklib__start_popup__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = start_popup(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__start_treenode__string_ref(const __sklib_string label_text) {
    string __skparam__label_text = __sklib__to_string(label_text);
    bool __skreturn = start_treenode(__skparam__label_text);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__text_box__string_ref(const __sklib_string value) {
    string __skparam__value = __sklib__to_string(value);
    string __skreturn = text_box(__skparam__value);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__text_box__string_ref__rectangle_ref(const __sklib_string value, const __sklib_rectangle rect) {
    string __skparam__value = __sklib__to_string(value);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    string __skreturn = text_box(__skparam__value, __skparam__rect);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__text_box__string_ref__string_ref(const __sklib_string label_text, const __sklib_string value) {
    string __skparam__label_text = __sklib__to_string(label_text);
    string __skparam__value = __sklib__to_string(value);
    string __skreturn = text_box(__skparam__label_text, __skparam__value);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_json __sklib__create_json() {
    json __skreturn = create_json();
    return __sklib__to_sklib_json(__skreturn);
}
__sklib_json __sklib__create_json__string(__sklib_string json_string) {
    string __skparam__json_string = __sklib__to_string(json_string);
    json __skreturn = create_json(__skparam__json_string);
    return __sklib__to_sklib_json(__skreturn);
}
void __sklib__free_all_json() {
    free_all_json();
}
void __sklib__free_json__json(__sklib_json j) {
    json __skparam__j = __sklib__to_json(j);
    free_json(__skparam__j);
}
int __sklib__json_count_keys__json(__sklib_json j) {
    json __skparam__j = __sklib__to_json(j);
    int __skreturn = json_count_keys(__skparam__j);
    return __sklib__to_int(__skreturn);
}
__sklib_json __sklib__json_from_color__color(__sklib_color clr) {
    color __skparam__clr = __sklib__to_color(clr);
    json __skreturn = json_from_color(__skparam__clr);
    return __sklib__to_sklib_json(__skreturn);
}
__sklib_json __sklib__json_from_file__string_ref(const __sklib_string filename) {
    string __skparam__filename = __sklib__to_string(filename);
    json __skreturn = json_from_file(__skparam__filename);
    return __sklib__to_sklib_json(__skreturn);
}
__sklib_json __sklib__json_from_string__string_ref(const __sklib_string j_string) {
    string __skparam__j_string = __sklib__to_string(j_string);
    json __skreturn = json_from_string(__skparam__j_string);
    return __sklib__to_sklib_json(__skreturn);
}
int __sklib__json_has_key__json__string(__sklib_json j, __sklib_string key) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    bool __skreturn = json_has_key(__skparam__j, __skparam__key);
    return __sklib__to_int(__skreturn);
}
void __sklib__json_read_array__json__string__vector_double_ref(__sklib_json j, __sklib_string key, __sklib_vector_double *out_result) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    vector<double> __skparam__out_result = __sklib__to_vector_double(*out_result);
    json_read_array(__skparam__j, __skparam__key, __skparam__out_result);
    __sklib__update_from_vector_double(__skparam__out_result, out_result);
}
void __sklib__json_read_array__json__string__vector_json_ref(__sklib_json j, __sklib_string key, __sklib_vector_json *out_result) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    vector<json> __skparam__out_result = __sklib__to_vector_json(*out_result);
    json_read_array(__skparam__j, __skparam__key, __skparam__out_result);
    __sklib__update_from_vector_json(__skparam__out_result, out_result);
}
void __sklib__json_read_array__json__string__vector_string_ref(__sklib_json j, __sklib_string key, __sklib_vector_string *out_result) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    vector<string> __skparam__out_result = __sklib__to_vector_string(*out_result);
    json_read_array(__skparam__j, __skparam__key, __skparam__out_result);
    __sklib__update_from_vector_string(__skparam__out_result, out_result);
}
void __sklib__json_read_array__json__string__vector_bool_ref(__sklib_json j, __sklib_string key, __sklib_vector_bool *out_result) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    vector<bool> __skparam__out_result = __sklib__to_vector_bool(*out_result);
    json_read_array(__skparam__j, __skparam__key, __skparam__out_result);
    __sklib__update_from_vector_bool(__skparam__out_result, out_result);
}
int __sklib__json_read_bool__json__string(__sklib_json j, __sklib_string key) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    bool __skreturn = json_read_bool(__skparam__j, __skparam__key);
    return __sklib__to_int(__skreturn);
}
float __sklib__json_read_number__json__string(__sklib_json j, __sklib_string key) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    float __skreturn = json_read_number(__skparam__j, __skparam__key);
    return __sklib__to_float(__skreturn);
}
double __sklib__json_read_number_as_double__json__string(__sklib_json j, __sklib_string key) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    double __skreturn = json_read_number_as_double(__skparam__j, __skparam__key);
    return __sklib__to_double(__skreturn);
}
int __sklib__json_read_number_as_int__json__string(__sklib_json j, __sklib_string key) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    int __skreturn = json_read_number_as_int(__skparam__j, __skparam__key);
    return __sklib__to_int(__skreturn);
}
__sklib_json __sklib__json_read_object__json__string(__sklib_json j, __sklib_string key) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    json __skreturn = json_read_object(__skparam__j, __skparam__key);
    return __sklib__to_sklib_json(__skreturn);
}
__sklib_string __sklib__json_read_string__json__string(__sklib_json j, __sklib_string key) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    string __skreturn = json_read_string(__skparam__j, __skparam__key);
    return __sklib__to_sklib_string(__skreturn);
}
void __sklib__json_set_array__json__string__vector_string(__sklib_json j, __sklib_string key, __sklib_vector_string value) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    vector<string> __skparam__value = __sklib__to_vector_string(value);
    json_set_array(__skparam__j, __skparam__key, __skparam__value);
}
void __sklib__json_set_array__json__string__vector_double(__sklib_json j, __sklib_string key, __sklib_vector_double value) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    vector<double> __skparam__value = __sklib__to_vector_double(value);
    json_set_array(__skparam__j, __skparam__key, __skparam__value);
}
void __sklib__json_set_array__json__string__vector_bool(__sklib_json j, __sklib_string key, __sklib_vector_bool value) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    vector<bool> __skparam__value = __sklib__to_vector_bool(value);
    json_set_array(__skparam__j, __skparam__key, __skparam__value);
}
void __sklib__json_set_array__json__string__vector_json(__sklib_json j, __sklib_string key, __sklib_vector_json value) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    vector<json> __skparam__value = __sklib__to_vector_json(value);
    json_set_array(__skparam__j, __skparam__key, __skparam__value);
}
void __sklib__json_set_bool__json__string__bool(__sklib_json j, __sklib_string key, int value) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    bool __skparam__value = __sklib__to_bool(value);
    json_set_bool(__skparam__j, __skparam__key, __skparam__value);
}
void __sklib__json_set_number__json__string__int(__sklib_json j, __sklib_string key, int value) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    int __skparam__value = __sklib__to_int(value);
    json_set_number(__skparam__j, __skparam__key, __skparam__value);
}
void __sklib__json_set_number__json__string__double(__sklib_json j, __sklib_string key, double value) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    double __skparam__value = __sklib__to_double(value);
    json_set_number(__skparam__j, __skparam__key, __skparam__value);
}
void __sklib__json_set_number__json__string__float(__sklib_json j, __sklib_string key, float value) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    float __skparam__value = __sklib__to_float(value);
    json_set_number(__skparam__j, __skparam__key, __skparam__value);
}
void __sklib__json_set_object__json__string__json(__sklib_json j, __sklib_string key, __sklib_json obj) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    json __skparam__obj = __sklib__to_json(obj);
    json_set_object(__skparam__j, __skparam__key, __skparam__obj);
}
void __sklib__json_set_string__json__string__string(__sklib_json j, __sklib_string key, __sklib_string value) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__key = __sklib__to_string(key);
    string __skparam__value = __sklib__to_string(value);
    json_set_string(__skparam__j, __skparam__key, __skparam__value);
}
__sklib_color __sklib__json_to_color__json(__sklib_json j) {
    json __skparam__j = __sklib__to_json(j);
    color __skreturn = json_to_color(__skparam__j);
    return __sklib__to_sklib_color(__skreturn);
}
void __sklib__json_to_file__json__string_ref(__sklib_json j, const __sklib_string filename) {
    json __skparam__j = __sklib__to_json(j);
    string __skparam__filename = __sklib__to_string(filename);
    json_to_file(__skparam__j, __skparam__filename);
}
__sklib_string __sklib__json_to_string__json(__sklib_json j) {
    json __skparam__j = __sklib__to_json(j);
    string __skreturn = json_to_string(__skparam__j);
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__any_key_pressed() {
    bool __skreturn = any_key_pressed();
    return __sklib__to_int(__skreturn);
}
void __sklib__deregister_callback_on_key_down__key_callback_ptr(__sklib_key_callback *callback) {
    key_callback *__skparam__callback = callback;
    deregister_callback_on_key_down(__skparam__callback);
}
void __sklib__deregister_callback_on_key_typed__key_callback_ptr(__sklib_key_callback *callback) {
    key_callback *__skparam__callback = callback;
    deregister_callback_on_key_typed(__skparam__callback);
}
void __sklib__deregister_callback_on_key_up__key_callback_ptr(__sklib_key_callback *callback) {
    key_callback *__skparam__callback = callback;
    deregister_callback_on_key_up(__skparam__callback);
}
int __sklib__key_down__key_code(int key) {
    key_code __skparam__key = __sklib__to_key_code(key);
    bool __skreturn = key_down(__skparam__key);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__key_name__key_code(int key) {
    key_code __skparam__key = __sklib__to_key_code(key);
    string __skreturn = key_name(__skparam__key);
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__key_released__key_code(int key) {
    key_code __skparam__key = __sklib__to_key_code(key);
    bool __skreturn = key_released(__skparam__key);
    return __sklib__to_int(__skreturn);
}
int __sklib__key_typed__key_code(int key) {
    key_code __skparam__key = __sklib__to_key_code(key);
    bool __skreturn = key_typed(__skparam__key);
    return __sklib__to_int(__skreturn);
}
int __sklib__key_up__key_code(int key) {
    key_code __skparam__key = __sklib__to_key_code(key);
    bool __skreturn = key_up(__skparam__key);
    return __sklib__to_int(__skreturn);
}
void __sklib__register_callback_on_key_down__key_callback_ptr(__sklib_key_callback *callback) {
    key_callback *__skparam__callback = callback;
    register_callback_on_key_down(__skparam__callback);
}
void __sklib__register_callback_on_key_typed__key_callback_ptr(__sklib_key_callback *callback) {
    key_callback *__skparam__callback = callback;
    register_callback_on_key_typed(__skparam__callback);
}
void __sklib__register_callback_on_key_up__key_callback_ptr(__sklib_key_callback *callback) {
    key_callback *__skparam__callback = callback;
    register_callback_on_key_up(__skparam__callback);
}
void __sklib__draw_line__color__line_ref(__sklib_color clr, const __sklib_line l) {
    color __skparam__clr = __sklib__to_color(clr);
    line __skparam__l = __sklib__to_line(l);
    draw_line(__skparam__clr, __skparam__l);
}
void __sklib__draw_line__color__line_ref__drawing_options(__sklib_color clr, const __sklib_line l, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    line __skparam__l = __sklib__to_line(l);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_line(__skparam__clr, __skparam__l, __skparam__opts);
}
void __sklib__draw_line__color__point_2d_ref__point_2d_ref(__sklib_color clr, const __sklib_point_2d from_pt, const __sklib_point_2d to_pt) {
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__from_pt = __sklib__to_point_2d(from_pt);
    point_2d __skparam__to_pt = __sklib__to_point_2d(to_pt);
    draw_line(__skparam__clr, __skparam__from_pt, __skparam__to_pt);
}
void __sklib__draw_line__color__point_2d_ref__point_2d_ref__drawing_options_ref(__sklib_color clr, const __sklib_point_2d from_pt, const __sklib_point_2d to_pt, const __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__from_pt = __sklib__to_point_2d(from_pt);
    point_2d __skparam__to_pt = __sklib__to_point_2d(to_pt);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_line(__skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts);
}
void __sklib__draw_line__color__double__double__double__double(__sklib_color clr, double x1, double y1, double x2, double y2) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    draw_line(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
}
void __sklib__draw_line__color__double__double__double__double__drawing_options_ref(__sklib_color clr, double x1, double y1, double x2, double y2, const __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_line(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts);
}
void __sklib__draw_line_on_bitmap__bitmap__color__line_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_line l) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    line __skparam__l = __sklib__to_line(l);
    draw_line_on_bitmap(__skparam__destination, __skparam__clr, __skparam__l);
}
void __sklib__draw_line_on_bitmap__bitmap__color__line_ref__drawing_options(__sklib_bitmap destination, __sklib_color clr, const __sklib_line l, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    line __skparam__l = __sklib__to_line(l);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_line_on_bitmap(__skparam__destination, __skparam__clr, __skparam__l, __skparam__opts);
}
void __sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_point_2d from_pt, const __sklib_point_2d to_pt) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__from_pt = __sklib__to_point_2d(from_pt);
    point_2d __skparam__to_pt = __sklib__to_point_2d(to_pt);
    draw_line_on_bitmap(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt);
}
void __sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref__drawing_options_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_point_2d from_pt, const __sklib_point_2d to_pt, const __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__from_pt = __sklib__to_point_2d(from_pt);
    point_2d __skparam__to_pt = __sklib__to_point_2d(to_pt);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_line_on_bitmap(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts);
}
void __sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double(__sklib_bitmap destination, __sklib_color clr, double x1, double y1, double x2, double y2) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    draw_line_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
}
void __sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(__sklib_bitmap destination, __sklib_color clr, double x1, double y1, double x2, double y2, const __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_line_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts);
}
void __sklib__draw_line_on_window__window__color__line_ref(__sklib_window destination, __sklib_color clr, const __sklib_line l) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    line __skparam__l = __sklib__to_line(l);
    draw_line_on_window(__skparam__destination, __skparam__clr, __skparam__l);
}
void __sklib__draw_line_on_window__window__color__line_ref__drawing_options(__sklib_window destination, __sklib_color clr, const __sklib_line l, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    line __skparam__l = __sklib__to_line(l);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_line_on_window(__skparam__destination, __skparam__clr, __skparam__l, __skparam__opts);
}
void __sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref(__sklib_window destination, __sklib_color clr, const __sklib_point_2d from_pt, const __sklib_point_2d to_pt) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__from_pt = __sklib__to_point_2d(from_pt);
    point_2d __skparam__to_pt = __sklib__to_point_2d(to_pt);
    draw_line_on_window(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt);
}
void __sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref__drawing_options_ref(__sklib_window destination, __sklib_color clr, const __sklib_point_2d from_pt, const __sklib_point_2d to_pt, const __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__from_pt = __sklib__to_point_2d(from_pt);
    point_2d __skparam__to_pt = __sklib__to_point_2d(to_pt);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_line_on_window(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts);
}
void __sklib__draw_line_on_window__window__color__double__double__double__double(__sklib_window destination, __sklib_color clr, double x1, double y1, double x2, double y2) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    draw_line_on_window(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
}
void __sklib__draw_line_on_window__window__color__double__double__double__double__drawing_options_ref(__sklib_window destination, __sklib_color clr, double x1, double y1, double x2, double y2, const __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_line_on_window(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts);
}
__sklib_point_2d __sklib__closest_point_on_line__point_2d__line_ref(const __sklib_point_2d from_pt, const __sklib_line l) {
    const point_2d __skparam__from_pt = __sklib__to_point_2d(from_pt);
    line __skparam__l = __sklib__to_line(l);
    point_2d __skreturn = closest_point_on_line(__skparam__from_pt, __skparam__l);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_point_2d __sklib__closest_point_on_lines__point_2d__vector_line_ref__int_ref(const __sklib_point_2d from_pt, const __sklib_vector_line lines, int *line_idx) {
    const point_2d __skparam__from_pt = __sklib__to_point_2d(from_pt);
    vector<line> __skparam__lines = __sklib__to_vector_line(lines);
    int __skparam__line_idx = __sklib__to_int(*line_idx);
    point_2d __skreturn = closest_point_on_lines(__skparam__from_pt, __skparam__lines, __skparam__line_idx);
    *line_idx = __sklib__to_int(__skparam__line_idx);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_line __sklib__line_from__point_2d_ref__point_2d_ref(const __sklib_point_2d start, const __sklib_point_2d end_pt) {
    point_2d __skparam__start = __sklib__to_point_2d(start);
    point_2d __skparam__end_pt = __sklib__to_point_2d(end_pt);
    line __skreturn = line_from(__skparam__start, __skparam__end_pt);
    return __sklib__to_sklib_line(__skreturn);
}
__sklib_line __sklib__line_from__point_2d_ref__vector_2d_ref(const __sklib_point_2d start, const __sklib_vector_2d offset) {
    point_2d __skparam__start = __sklib__to_point_2d(start);
    vector_2d __skparam__offset = __sklib__to_vector_2d(offset);
    line __skreturn = line_from(__skparam__start, __skparam__offset);
    return __sklib__to_sklib_line(__skreturn);
}
__sklib_line __sklib__line_from__vector_2d_ref(const __sklib_vector_2d v) {
    vector_2d __skparam__v = __sklib__to_vector_2d(v);
    line __skreturn = line_from(__skparam__v);
    return __sklib__to_sklib_line(__skreturn);
}
__sklib_line __sklib__line_from__double__double__double__double(double x1, double y1, double x2, double y2) {
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    line __skreturn = line_from(__skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
    return __sklib__to_sklib_line(__skreturn);
}
int __sklib__line_intersection_point__line_ref__line_ref__point_2d_ref(const __sklib_line line1, const __sklib_line line2, __sklib_point_2d *pt) {
    line __skparam__line1 = __sklib__to_line(line1);
    line __skparam__line2 = __sklib__to_line(line2);
    point_2d __skparam__pt = __sklib__to_point_2d(*pt);
    bool __skreturn = line_intersection_point(__skparam__line1, __skparam__line2, __skparam__pt);
    *pt = __sklib__to_sklib_point_2d(__skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__line_intersects_circle__line_ref__circle_ref(const __sklib_line l, const __sklib_circle c) {
    line __skparam__l = __sklib__to_line(l);
    circle __skparam__c = __sklib__to_circle(c);
    bool __skreturn = line_intersects_circle(__skparam__l, __skparam__c);
    return __sklib__to_int(__skreturn);
}
int __sklib__line_intersects_lines__line_ref__vector_line_ref(const __sklib_line l, const __sklib_vector_line lines) {
    line __skparam__l = __sklib__to_line(l);
    vector<line> __skparam__lines = __sklib__to_vector_line(lines);
    bool __skreturn = line_intersects_lines(__skparam__l, __skparam__lines);
    return __sklib__to_int(__skreturn);
}
int __sklib__line_intersects_rect__line_ref__rectangle_ref(const __sklib_line l, const __sklib_rectangle rect) {
    line __skparam__l = __sklib__to_line(l);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = line_intersects_rect(__skparam__l, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
float __sklib__line_length__line_ref(const __sklib_line l) {
    line __skparam__l = __sklib__to_line(l);
    float __skreturn = line_length(__skparam__l);
    return __sklib__to_float(__skreturn);
}
float __sklib__line_length_squared__line_ref(const __sklib_line l) {
    line __skparam__l = __sklib__to_line(l);
    float __skreturn = line_length_squared(__skparam__l);
    return __sklib__to_float(__skreturn);
}
__sklib_point_2d __sklib__line_mid_point__line_ref(const __sklib_line l) {
    line __skparam__l = __sklib__to_line(l);
    point_2d __skreturn = line_mid_point(__skparam__l);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_vector_2d __sklib__line_normal__line_ref(const __sklib_line l) {
    line __skparam__l = __sklib__to_line(l);
    vector_2d __skreturn = line_normal(__skparam__l);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_string __sklib__line_to_string__line_ref(const __sklib_line ln) {
    line __skparam__ln = __sklib__to_line(ln);
    string __skreturn = line_to_string(__skparam__ln);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_vector_line __sklib__lines_from__rectangle_ref(const __sklib_rectangle rect) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    vector<line> __skreturn = lines_from(__skparam__rect);
    return __sklib__to_sklib_vector_line(__skreturn);
}
__sklib_vector_line __sklib__lines_from__triangle_ref(const __sklib_triangle t) {
    triangle __skparam__t = __sklib__to_triangle(t);
    vector<line> __skreturn = lines_from(__skparam__t);
    return __sklib__to_sklib_vector_line(__skreturn);
}
int __sklib__lines_intersect__line_ref__line_ref(const __sklib_line l1, const __sklib_line l2) {
    line __skparam__l1 = __sklib__to_line(l1);
    line __skparam__l2 = __sklib__to_line(l2);
    bool __skreturn = lines_intersect(__skparam__l1, __skparam__l2);
    return __sklib__to_int(__skreturn);
}
void __sklib__close_log_process() {
    close_log_process();
}
void __sklib__init_custom_logger__log_mode(int mode) {
    log_mode __skparam__mode = __sklib__to_log_mode(mode);
    init_custom_logger(__skparam__mode);
}
void __sklib__init_custom_logger__string__bool__log_mode(__sklib_string app_name, int override_prev_log, int mode) {
    string __skparam__app_name = __sklib__to_string(app_name);
    bool __skparam__override_prev_log = __sklib__to_bool(override_prev_log);
    log_mode __skparam__mode = __sklib__to_log_mode(mode);
    init_custom_logger(__skparam__app_name, __skparam__override_prev_log, __skparam__mode);
}
void __sklib__log__log_level__string(int level, __sklib_string message) {
    log_level __skparam__level = __sklib__to_log_level(level);
    string __skparam__message = __sklib__to_string(message);
    log(__skparam__level, __skparam__message);
}
void __sklib__apply_matrix__matrix_2d_ref__quad_ref(const __sklib_matrix_2d matrix, __sklib_quad *q) {
    matrix_2d __skparam__matrix = __sklib__to_matrix_2d(matrix);
    quad __skparam__q = __sklib__to_quad(*q);
    apply_matrix(__skparam__matrix, __skparam__q);
    *q = __sklib__to_sklib_quad(__skparam__q);
}
void __sklib__apply_matrix__matrix_2d_ref__triangle_ref(const __sklib_matrix_2d m, __sklib_triangle *tri) {
    matrix_2d __skparam__m = __sklib__to_matrix_2d(m);
    triangle __skparam__tri = __sklib__to_triangle(*tri);
    apply_matrix(__skparam__m, __skparam__tri);
    *tri = __sklib__to_sklib_triangle(__skparam__tri);
}
__sklib_matrix_2d __sklib__identity_matrix() {
    matrix_2d __skreturn = identity_matrix();
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
__sklib_matrix_2d __sklib__matrix_inverse__matrix_2d_ref(const __sklib_matrix_2d m) {
    matrix_2d __skparam__m = __sklib__to_matrix_2d(m);
    matrix_2d __skreturn = matrix_inverse(__skparam__m);
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
__sklib_point_2d __sklib__matrix_multiply__matrix_2d_ref__point_2d_ref(const __sklib_matrix_2d m, const __sklib_point_2d pt) {
    matrix_2d __skparam__m = __sklib__to_matrix_2d(m);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    point_2d __skreturn = matrix_multiply(__skparam__m, __skparam__pt);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_matrix_2d __sklib__matrix_multiply__matrix_2d_ref__matrix_2d_ref(const __sklib_matrix_2d m1, const __sklib_matrix_2d m2) {
    matrix_2d __skparam__m1 = __sklib__to_matrix_2d(m1);
    matrix_2d __skparam__m2 = __sklib__to_matrix_2d(m2);
    matrix_2d __skreturn = matrix_multiply(__skparam__m1, __skparam__m2);
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
__sklib_vector_2d __sklib__matrix_multiply__matrix_2d_ref__vector_2d_ref(const __sklib_matrix_2d m, const __sklib_vector_2d v) {
    matrix_2d __skparam__m = __sklib__to_matrix_2d(m);
    vector_2d __skparam__v = __sklib__to_vector_2d(v);
    vector_2d __skreturn = matrix_multiply(__skparam__m, __skparam__v);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_string __sklib__matrix_to_string__matrix_2d_ref(const __sklib_matrix_2d matrix) {
    matrix_2d __skparam__matrix = __sklib__to_matrix_2d(matrix);
    string __skreturn = matrix_to_string(__skparam__matrix);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_matrix_2d __sklib__rotation_matrix__double(double deg) {
    double __skparam__deg = __sklib__to_double(deg);
    matrix_2d __skreturn = rotation_matrix(__skparam__deg);
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
__sklib_matrix_2d __sklib__scale_matrix__point_2d_ref(const __sklib_point_2d scale) {
    point_2d __skparam__scale = __sklib__to_point_2d(scale);
    matrix_2d __skreturn = scale_matrix(__skparam__scale);
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
__sklib_matrix_2d __sklib__scale_matrix__vector_2d_ref(const __sklib_vector_2d scale) {
    vector_2d __skparam__scale = __sklib__to_vector_2d(scale);
    matrix_2d __skreturn = scale_matrix(__skparam__scale);
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
__sklib_matrix_2d __sklib__scale_matrix__double(double scale) {
    double __skparam__scale = __sklib__to_double(scale);
    matrix_2d __skreturn = scale_matrix(__skparam__scale);
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
__sklib_matrix_2d __sklib__scale_rotate_translate_matrix__point_2d_ref__double__point_2d_ref(const __sklib_point_2d scale, double deg, const __sklib_point_2d translate) {
    point_2d __skparam__scale = __sklib__to_point_2d(scale);
    double __skparam__deg = __sklib__to_double(deg);
    point_2d __skparam__translate = __sklib__to_point_2d(translate);
    matrix_2d __skreturn = scale_rotate_translate_matrix(__skparam__scale, __skparam__deg, __skparam__translate);
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
__sklib_matrix_2d __sklib__translation_matrix__point_2d_ref(const __sklib_point_2d pt) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    matrix_2d __skreturn = translation_matrix(__skparam__pt);
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
__sklib_matrix_2d __sklib__translation_matrix__vector_2d_ref(const __sklib_vector_2d pt) {
    vector_2d __skparam__pt = __sklib__to_vector_2d(pt);
    matrix_2d __skreturn = translation_matrix(__skparam__pt);
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
__sklib_matrix_2d __sklib__translation_matrix__double__double(double dx, double dy) {
    double __skparam__dx = __sklib__to_double(dx);
    double __skparam__dy = __sklib__to_double(dy);
    matrix_2d __skreturn = translation_matrix(__skparam__dx, __skparam__dy);
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
void __sklib__hide_mouse() {
    hide_mouse();
}
int __sklib__mouse_clicked__mouse_button(int button) {
    mouse_button __skparam__button = __sklib__to_mouse_button(button);
    bool __skreturn = mouse_clicked(__skparam__button);
    return __sklib__to_int(__skreturn);
}
int __sklib__mouse_down__mouse_button(int button) {
    mouse_button __skparam__button = __sklib__to_mouse_button(button);
    bool __skreturn = mouse_down(__skparam__button);
    return __sklib__to_int(__skreturn);
}
__sklib_vector_2d __sklib__mouse_movement() {
    vector_2d __skreturn = mouse_movement();
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_point_2d __sklib__mouse_position() {
    point_2d __skreturn = mouse_position();
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_vector_2d __sklib__mouse_position_vector() {
    vector_2d __skreturn = mouse_position_vector();
    return __sklib__to_sklib_vector_2d(__skreturn);
}
int __sklib__mouse_shown() {
    bool __skreturn = mouse_shown();
    return __sklib__to_int(__skreturn);
}
int __sklib__mouse_up__mouse_button(int button) {
    mouse_button __skparam__button = __sklib__to_mouse_button(button);
    bool __skreturn = mouse_up(__skparam__button);
    return __sklib__to_int(__skreturn);
}
__sklib_vector_2d __sklib__mouse_wheel_scroll() {
    vector_2d __skreturn = mouse_wheel_scroll();
    return __sklib__to_sklib_vector_2d(__skreturn);
}
float __sklib__mouse_x() {
    float __skreturn = mouse_x();
    return __sklib__to_float(__skreturn);
}
float __sklib__mouse_y() {
    float __skreturn = mouse_y();
    return __sklib__to_float(__skreturn);
}
void __sklib__move_mouse__double__double(double x, double y) {
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    move_mouse(__skparam__x, __skparam__y);
}
void __sklib__move_mouse__point_2d(__sklib_point_2d point) {
    point_2d __skparam__point = __sklib__to_point_2d(point);
    move_mouse(__skparam__point);
}
void __sklib__show_mouse() {
    show_mouse();
}
void __sklib__show_mouse__bool(int show) {
    bool __skparam__show = __sklib__to_bool(show);
    show_mouse(__skparam__show);
}
void __sklib__fade_music_in__string_ref__int(const __sklib_string name, int ms) {
    string __skparam__name = __sklib__to_string(name);
    int __skparam__ms = __sklib__to_int(ms);
    fade_music_in(__skparam__name, __skparam__ms);
}
void __sklib__fade_music_in__string_ref__int__int(const __sklib_string name, int times, int ms) {
    string __skparam__name = __sklib__to_string(name);
    int __skparam__times = __sklib__to_int(times);
    int __skparam__ms = __sklib__to_int(ms);
    fade_music_in(__skparam__name, __skparam__times, __skparam__ms);
}
void __sklib__fade_music_in__music__int(__sklib_music data, int ms) {
    music __skparam__data = __sklib__to_music(data);
    int __skparam__ms = __sklib__to_int(ms);
    fade_music_in(__skparam__data, __skparam__ms);
}
void __sklib__fade_music_in__music__int__int(__sklib_music data, int times, int ms) {
    music __skparam__data = __sklib__to_music(data);
    int __skparam__times = __sklib__to_int(times);
    int __skparam__ms = __sklib__to_int(ms);
    fade_music_in(__skparam__data, __skparam__times, __skparam__ms);
}
void __sklib__fade_music_out__int(int ms) {
    int __skparam__ms = __sklib__to_int(ms);
    fade_music_out(__skparam__ms);
}
void __sklib__free_all_music() {
    free_all_music();
}
void __sklib__free_music__music(__sklib_music effect) {
    music __skparam__effect = __sklib__to_music(effect);
    free_music(__skparam__effect);
}
int __sklib__has_music__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_music(__skparam__name);
    return __sklib__to_int(__skreturn);
}
__sklib_music __sklib__load_music__string_ref__string_ref(const __sklib_string name, const __sklib_string filename) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__filename = __sklib__to_string(filename);
    music __skreturn = load_music(__skparam__name, __skparam__filename);
    return __sklib__to_sklib_music(__skreturn);
}
__sklib_string __sklib__music_filename__music(__sklib_music data) {
    music __skparam__data = __sklib__to_music(data);
    string __skreturn = music_filename(__skparam__data);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__music_name__music(__sklib_music data) {
    music __skparam__data = __sklib__to_music(data);
    string __skreturn = music_name(__skparam__data);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_music __sklib__music_named__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    music __skreturn = music_named(__skparam__name);
    return __sklib__to_sklib_music(__skreturn);
}
int __sklib__music_playing() {
    bool __skreturn = music_playing();
    return __sklib__to_int(__skreturn);
}
int __sklib__music_valid__music(__sklib_music m) {
    music __skparam__m = __sklib__to_music(m);
    bool __skreturn = music_valid(__skparam__m);
    return __sklib__to_int(__skreturn);
}
double __sklib__music_volume() {
    double __skreturn = music_volume();
    return __sklib__to_double(__skreturn);
}
void __sklib__pause_music() {
    pause_music();
}
void __sklib__play_music__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    play_music(__skparam__name);
}
void __sklib__play_music__string_ref__int(const __sklib_string name, int times) {
    string __skparam__name = __sklib__to_string(name);
    int __skparam__times = __sklib__to_int(times);
    play_music(__skparam__name, __skparam__times);
}
void __sklib__play_music__music(__sklib_music data) {
    music __skparam__data = __sklib__to_music(data);
    play_music(__skparam__data);
}
void __sklib__play_music__music__int(__sklib_music data, int times) {
    music __skparam__data = __sklib__to_music(data);
    int __skparam__times = __sklib__to_int(times);
    play_music(__skparam__data, __skparam__times);
}
void __sklib__play_music__music__int__double(__sklib_music data, int times, double volume) {
    music __skparam__data = __sklib__to_music(data);
    int __skparam__times = __sklib__to_int(times);
    double __skparam__volume = __sklib__to_double(volume);
    play_music(__skparam__data, __skparam__times, __skparam__volume);
}
void __sklib__resume_music() {
    resume_music();
}
void __sklib__set_music_volume__double(double volume) {
    double __skparam__volume = __sklib__to_double(volume);
    set_music_volume(__skparam__volume);
}
void __sklib__stop_music() {
    stop_music();
}
int __sklib__accept_all_new_connections() {
    bool __skreturn = accept_all_new_connections();
    return __sklib__to_int(__skreturn);
}
int __sklib__accept_new_connection__server_socket(__sklib_server_socket server) {
    server_socket __skparam__server = __sklib__to_server_socket(server);
    bool __skreturn = accept_new_connection(__skparam__server);
    return __sklib__to_int(__skreturn);
}
void __sklib__broadcast_message__string_ref__server_socket(const __sklib_string a_msg, __sklib_server_socket svr) {
    string __skparam__a_msg = __sklib__to_string(a_msg);
    server_socket __skparam__svr = __sklib__to_server_socket(svr);
    broadcast_message(__skparam__a_msg, __skparam__svr);
}
void __sklib__broadcast_message__string_ref(const __sklib_string a_msg) {
    string __skparam__a_msg = __sklib__to_string(a_msg);
    broadcast_message(__skparam__a_msg);
}
void __sklib__broadcast_message__string_ref__string_ref(const __sklib_string a_msg, const __sklib_string name) {
    string __skparam__a_msg = __sklib__to_string(a_msg);
    string __skparam__name = __sklib__to_string(name);
    broadcast_message(__skparam__a_msg, __skparam__name);
}
void __sklib__check_network_activity() {
    check_network_activity();
}
void __sklib__clear_messages__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    clear_messages(__skparam__name);
}
void __sklib__clear_messages__connection(__sklib_connection a_connection) {
    connection __skparam__a_connection = __sklib__to_connection(a_connection);
    clear_messages(__skparam__a_connection);
}
void __sklib__clear_messages__server_socket(__sklib_server_socket svr) {
    server_socket __skparam__svr = __sklib__to_server_socket(svr);
    clear_messages(__skparam__svr);
}
void __sklib__close_all_connections() {
    close_all_connections();
}
void __sklib__close_all_servers() {
    close_all_servers();
}
int __sklib__close_connection__connection(__sklib_connection a_connection) {
    connection __skparam__a_connection = __sklib__to_connection(a_connection);
    bool __skreturn = close_connection(__skparam__a_connection);
    return __sklib__to_int(__skreturn);
}
int __sklib__close_connection__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = close_connection(__skparam__name);
    return __sklib__to_int(__skreturn);
}
void __sklib__close_message__message(__sklib_message msg) {
    message __skparam__msg = __sklib__to_message(msg);
    close_message(__skparam__msg);
}
int __sklib__close_server__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = close_server(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__close_server__server_socket(__sklib_server_socket svr) {
    server_socket __skparam__svr = __sklib__to_server_socket(svr);
    bool __skreturn = close_server(__skparam__svr);
    return __sklib__to_int(__skreturn);
}
unsigned int __sklib__connection_count__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    unsigned int __skreturn = connection_count(__skparam__name);
    return __sklib__to_unsigned_int(__skreturn);
}
unsigned int __sklib__connection_count__server_socket(__sklib_server_socket server) {
    server_socket __skparam__server = __sklib__to_server_socket(server);
    unsigned int __skreturn = connection_count(__skparam__server);
    return __sklib__to_unsigned_int(__skreturn);
}
unsigned int __sklib__connection_ip__connection(__sklib_connection a_connection) {
    connection __skparam__a_connection = __sklib__to_connection(a_connection);
    unsigned int __skreturn = connection_ip(__skparam__a_connection);
    return __sklib__to_unsigned_int(__skreturn);
}
unsigned int __sklib__connection_ip__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    unsigned int __skreturn = connection_ip(__skparam__name);
    return __sklib__to_unsigned_int(__skreturn);
}
__sklib_connection __sklib__connection_named__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    connection __skreturn = connection_named(__skparam__name);
    return __sklib__to_sklib_connection(__skreturn);
}
unsigned short __sklib__connection_port__connection(__sklib_connection a_connection) {
    connection __skparam__a_connection = __sklib__to_connection(a_connection);
    unsigned short __skreturn = connection_port(__skparam__a_connection);
    return __sklib__to_unsigned_short(__skreturn);
}
unsigned short __sklib__connection_port__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    unsigned short __skreturn = connection_port(__skparam__name);
    return __sklib__to_unsigned_short(__skreturn);
}
__sklib_server_socket __sklib__create_server__string_ref__unsigned_short(const __sklib_string name, unsigned short port) {
    string __skparam__name = __sklib__to_string(name);
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    server_socket __skreturn = create_server(__skparam__name, __skparam__port);
    return __sklib__to_sklib_server_socket(__skreturn);
}
__sklib_server_socket __sklib__create_server__string_ref__unsigned_short__connection_type(const __sklib_string name, unsigned short port, int protocol) {
    string __skparam__name = __sklib__to_string(name);
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    connection_type __skparam__protocol = __sklib__to_connection_type(protocol);
    server_socket __skreturn = create_server(__skparam__name, __skparam__port, __skparam__protocol);
    return __sklib__to_sklib_server_socket(__skreturn);
}
__sklib_string __sklib__dec_to_hex__unsigned_int(unsigned int a_dec) {
    unsigned int __skparam__a_dec = __sklib__to_unsigned_int(a_dec);
    string __skreturn = dec_to_hex(__skparam__a_dec);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_connection __sklib__fetch_new_connection__server_socket(__sklib_server_socket server) {
    server_socket __skparam__server = __sklib__to_server_socket(server);
    connection __skreturn = fetch_new_connection(__skparam__server);
    return __sklib__to_sklib_connection(__skreturn);
}
int __sklib__has_connection__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_connection(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__has_messages() {
    bool __skreturn = has_messages();
    return __sklib__to_int(__skreturn);
}
int __sklib__has_messages__connection(__sklib_connection con) {
    connection __skparam__con = __sklib__to_connection(con);
    bool __skreturn = has_messages(__skparam__con);
    return __sklib__to_int(__skreturn);
}
int __sklib__has_messages__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_messages(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__has_messages__server_socket(__sklib_server_socket svr) {
    server_socket __skparam__svr = __sklib__to_server_socket(svr);
    bool __skreturn = has_messages(__skparam__svr);
    return __sklib__to_int(__skreturn);
}
int __sklib__has_new_connections() {
    bool __skreturn = has_new_connections();
    return __sklib__to_int(__skreturn);
}
int __sklib__has_server__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_server(__skparam__name);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__hex_str_to_ipv4__string_ref(const __sklib_string a_hex) {
    string __skparam__a_hex = __sklib__to_string(a_hex);
    string __skreturn = hex_str_to_ipv4(__skparam__a_hex);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__hex_to_dec_string__string_ref(const __sklib_string a_hex) {
    string __skparam__a_hex = __sklib__to_string(a_hex);
    string __skreturn = hex_to_dec_string(__skparam__a_hex);
    return __sklib__to_sklib_string(__skreturn);
}
unsigned int __sklib__ipv4_to_dec__string_ref(const __sklib_string a_ip) {
    string __skparam__a_ip = __sklib__to_string(a_ip);
    unsigned int __skreturn = ipv4_to_dec(__skparam__a_ip);
    return __sklib__to_unsigned_int(__skreturn);
}
__sklib_string __sklib__ipv4_to_hex__string_ref(const __sklib_string a_ip) {
    string __skparam__a_ip = __sklib__to_string(a_ip);
    string __skreturn = ipv4_to_hex(__skparam__a_ip);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__ipv4_to_str__unsigned_int(unsigned int ip) {
    unsigned int __skparam__ip = __sklib__to_unsigned_int(ip);
    string __skreturn = ipv4_to_str(__skparam__ip);
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__is_connection_open__connection(__sklib_connection con) {
    connection __skparam__con = __sklib__to_connection(con);
    bool __skreturn = is_connection_open(__skparam__con);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_connection_open__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = is_connection_open(__skparam__name);
    return __sklib__to_int(__skreturn);
}
__sklib_connection __sklib__last_connection__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    connection __skreturn = last_connection(__skparam__name);
    return __sklib__to_sklib_connection(__skreturn);
}
__sklib_connection __sklib__last_connection__server_socket(__sklib_server_socket server) {
    server_socket __skparam__server = __sklib__to_server_socket(server);
    connection __skreturn = last_connection(__skparam__server);
    return __sklib__to_sklib_connection(__skreturn);
}
__sklib_connection __sklib__message_connection__message(__sklib_message msg) {
    message __skparam__msg = __sklib__to_message(msg);
    connection __skreturn = message_connection(__skparam__msg);
    return __sklib__to_sklib_connection(__skreturn);
}
unsigned int __sklib__message_count__server_socket(__sklib_server_socket svr) {
    server_socket __skparam__svr = __sklib__to_server_socket(svr);
    unsigned int __skreturn = message_count(__skparam__svr);
    return __sklib__to_unsigned_int(__skreturn);
}
unsigned int __sklib__message_count__connection(__sklib_connection a_connection) {
    connection __skparam__a_connection = __sklib__to_connection(a_connection);
    unsigned int __skreturn = message_count(__skparam__a_connection);
    return __sklib__to_unsigned_int(__skreturn);
}
unsigned int __sklib__message_count__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    unsigned int __skreturn = message_count(__skparam__name);
    return __sklib__to_unsigned_int(__skreturn);
}
__sklib_string __sklib__message_data__message(__sklib_message msg) {
    message __skparam__msg = __sklib__to_message(msg);
    string __skreturn = message_data(__skparam__msg);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_vector_int8_t __sklib__message_data_bytes__message(__sklib_message msg) {
    message __skparam__msg = __sklib__to_message(msg);
    vector<int8_t> __skreturn = message_data_bytes(__skparam__msg);
    return __sklib__to_sklib_vector_int8_t(__skreturn);
}
__sklib_string __sklib__message_host__message(__sklib_message msg) {
    message __skparam__msg = __sklib__to_message(msg);
    string __skreturn = message_host(__skparam__msg);
    return __sklib__to_sklib_string(__skreturn);
}
unsigned short __sklib__message_port__message(__sklib_message msg) {
    message __skparam__msg = __sklib__to_message(msg);
    unsigned short __skreturn = message_port(__skparam__msg);
    return __sklib__to_unsigned_short(__skreturn);
}
int __sklib__message_protocol__message(__sklib_message msg) {
    message __skparam__msg = __sklib__to_message(msg);
    connection_type __skreturn = message_protocol(__skparam__msg);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__my_ip() {
    string __skreturn = my_ip();
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__name_for_connection__string__unsigned_int(const __sklib_string host, const unsigned int port) {
    const string __skparam__host = __sklib__to_string(host);
    const unsigned int __skparam__port = __sklib__to_unsigned_int(port);
    string __skreturn = name_for_connection(__skparam__host, __skparam__port);
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__new_connection_count__server_socket(__sklib_server_socket server) {
    server_socket __skparam__server = __sklib__to_server_socket(server);
    int __skreturn = new_connection_count(__skparam__server);
    return __sklib__to_int(__skreturn);
}
__sklib_connection __sklib__open_connection__string_ref__string_ref__unsigned_short(const __sklib_string name, const __sklib_string host, unsigned short port) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__host = __sklib__to_string(host);
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    connection __skreturn = open_connection(__skparam__name, __skparam__host, __skparam__port);
    return __sklib__to_sklib_connection(__skreturn);
}
__sklib_connection __sklib__open_connection__string_ref__string_ref__unsigned_short__connection_type(const __sklib_string name, const __sklib_string host, unsigned short port, int protocol) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__host = __sklib__to_string(host);
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    connection_type __skparam__protocol = __sklib__to_connection_type(protocol);
    connection __skreturn = open_connection(__skparam__name, __skparam__host, __skparam__port, __skparam__protocol);
    return __sklib__to_sklib_connection(__skreturn);
}
__sklib_message __sklib__read_message() {
    message __skreturn = read_message();
    return __sklib__to_sklib_message(__skreturn);
}
__sklib_message __sklib__read_message__connection(__sklib_connection a_connection) {
    connection __skparam__a_connection = __sklib__to_connection(a_connection);
    message __skreturn = read_message(__skparam__a_connection);
    return __sklib__to_sklib_message(__skreturn);
}
__sklib_message __sklib__read_message__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    message __skreturn = read_message(__skparam__name);
    return __sklib__to_sklib_message(__skreturn);
}
__sklib_message __sklib__read_message__server_socket(__sklib_server_socket svr) {
    server_socket __skparam__svr = __sklib__to_server_socket(svr);
    message __skreturn = read_message(__skparam__svr);
    return __sklib__to_sklib_message(__skreturn);
}
__sklib_string __sklib__read_message_data__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    string __skreturn = read_message_data(__skparam__name);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__read_message_data__connection(__sklib_connection a_connection) {
    connection __skparam__a_connection = __sklib__to_connection(a_connection);
    string __skreturn = read_message_data(__skparam__a_connection);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__read_message_data__server_socket(__sklib_server_socket svr) {
    server_socket __skparam__svr = __sklib__to_server_socket(svr);
    string __skreturn = read_message_data(__skparam__svr);
    return __sklib__to_sklib_string(__skreturn);
}
void __sklib__reconnect__connection(__sklib_connection a_connection) {
    connection __skparam__a_connection = __sklib__to_connection(a_connection);
    reconnect(__skparam__a_connection);
}
void __sklib__reconnect__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    reconnect(__skparam__name);
}
void __sklib__release_all_connections() {
    release_all_connections();
}
void __sklib__reset_new_connection_count__server_socket(__sklib_server_socket server) {
    server_socket __skparam__server = __sklib__to_server_socket(server);
    reset_new_connection_count(__skparam__server);
}
__sklib_connection __sklib__retrieve_connection__string_ref__int(const __sklib_string name, int idx) {
    string __skparam__name = __sklib__to_string(name);
    int __skparam__idx = __sklib__to_int(idx);
    connection __skreturn = retrieve_connection(__skparam__name, __skparam__idx);
    return __sklib__to_sklib_connection(__skreturn);
}
__sklib_connection __sklib__retrieve_connection__server_socket__int(__sklib_server_socket server, int idx) {
    server_socket __skparam__server = __sklib__to_server_socket(server);
    int __skparam__idx = __sklib__to_int(idx);
    connection __skreturn = retrieve_connection(__skparam__server, __skparam__idx);
    return __sklib__to_sklib_connection(__skreturn);
}
int __sklib__send_message_to__string_ref__connection(const __sklib_string a_msg, __sklib_connection a_connection) {
    string __skparam__a_msg = __sklib__to_string(a_msg);
    connection __skparam__a_connection = __sklib__to_connection(a_connection);
    bool __skreturn = send_message_to(__skparam__a_msg, __skparam__a_connection);
    return __sklib__to_int(__skreturn);
}
int __sklib__send_message_to__string_ref__string_ref(const __sklib_string a_msg, const __sklib_string name) {
    string __skparam__a_msg = __sklib__to_string(a_msg);
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = send_message_to(__skparam__a_msg, __skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__server_has_new_connection__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = server_has_new_connection(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__server_has_new_connection__server_socket(__sklib_server_socket server) {
    server_socket __skparam__server = __sklib__to_server_socket(server);
    bool __skreturn = server_has_new_connection(__skparam__server);
    return __sklib__to_int(__skreturn);
}
__sklib_server_socket __sklib__server_named__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    server_socket __skreturn = server_named(__skparam__name);
    return __sklib__to_sklib_server_socket(__skreturn);
}
void __sklib__set_udp_packet_size__unsigned_int(unsigned int udp_packet_size) {
    unsigned int __skparam__udp_packet_size = __sklib__to_unsigned_int(udp_packet_size);
    set_udp_packet_size(__skparam__udp_packet_size);
}
unsigned int __sklib__udp_packet_size() {
    unsigned int __skreturn = udp_packet_size();
    return __sklib__to_unsigned_int(__skreturn);
}
void __sklib__draw_pixel__color__point_2d_ref(__sklib_color clr, const __sklib_point_2d pt) {
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    draw_pixel(__skparam__clr, __skparam__pt);
}
void __sklib__draw_pixel__color__point_2d_ref__drawing_options(__sklib_color clr, const __sklib_point_2d pt, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_pixel(__skparam__clr, __skparam__pt, __skparam__opts);
}
void __sklib__draw_pixel__color__double__double(__sklib_color clr, double x, double y) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_pixel(__skparam__clr, __skparam__x, __skparam__y);
}
void __sklib__draw_pixel__color__double__double__drawing_options(__sklib_color clr, double x, double y, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_pixel(__skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_point_2d pt) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    draw_pixel_on_bitmap(__skparam__destination, __skparam__clr, __skparam__pt);
}
void __sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref__drawing_options(__sklib_bitmap destination, __sklib_color clr, const __sklib_point_2d pt, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_pixel_on_bitmap(__skparam__destination, __skparam__clr, __skparam__pt, __skparam__opts);
}
void __sklib__draw_pixel_on_bitmap__bitmap__color__double__double(__sklib_bitmap destination, __sklib_color clr, double x, double y) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_pixel_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y);
}
void __sklib__draw_pixel_on_bitmap__bitmap__color__double__double__drawing_options(__sklib_bitmap destination, __sklib_color clr, double x, double y, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_pixel_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_pixel_on_window__window__color__point_2d_ref(__sklib_window destination, __sklib_color clr, const __sklib_point_2d pt) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    draw_pixel_on_window(__skparam__destination, __skparam__clr, __skparam__pt);
}
void __sklib__draw_pixel_on_window__window__color__point_2d_ref__drawing_options(__sklib_window destination, __sklib_color clr, const __sklib_point_2d pt, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_pixel_on_window(__skparam__destination, __skparam__clr, __skparam__pt, __skparam__opts);
}
void __sklib__draw_pixel_on_window__window__color__double__double(__sklib_window destination, __sklib_color clr, double x, double y) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_pixel_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y);
}
void __sklib__draw_pixel_on_window__window__color__double__double__drawing_options(__sklib_window destination, __sklib_color clr, double x, double y, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_pixel_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
}
__sklib_color __sklib__get_pixel__bitmap__point_2d_ref(__sklib_bitmap bmp, const __sklib_point_2d pt) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    color __skreturn = get_pixel(__skparam__bmp, __skparam__pt);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__get_pixel__bitmap__double__double(__sklib_bitmap bmp, double x, double y) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    color __skreturn = get_pixel(__skparam__bmp, __skparam__x, __skparam__y);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__get_pixel__point_2d_ref(const __sklib_point_2d pt) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    color __skreturn = get_pixel(__skparam__pt);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__get_pixel__double__double(double x, double y) {
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    color __skreturn = get_pixel(__skparam__x, __skparam__y);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__get_pixel__window__point_2d_ref(__sklib_window wnd, const __sklib_point_2d pt) {
    window __skparam__wnd = __sklib__to_window(wnd);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    color __skreturn = get_pixel(__skparam__wnd, __skparam__pt);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__get_pixel__window__double__double(__sklib_window wnd, double x, double y) {
    window __skparam__wnd = __sklib__to_window(wnd);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    color __skreturn = get_pixel(__skparam__wnd, __skparam__x, __skparam__y);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__get_pixel_from_window__window__point_2d_ref(__sklib_window destination, const __sklib_point_2d pt) {
    window __skparam__destination = __sklib__to_window(destination);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    color __skreturn = get_pixel_from_window(__skparam__destination, __skparam__pt);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_color __sklib__get_pixel_from_window__window__double__double(__sklib_window destination, double x, double y) {
    window __skparam__destination = __sklib__to_window(destination);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    color __skreturn = get_pixel_from_window(__skparam__destination, __skparam__x, __skparam__y);
    return __sklib__to_sklib_color(__skreturn);
}
__sklib_point_2d __sklib__point_at__double__double(double x, double y) {
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    point_2d __skreturn = point_at(__skparam__x, __skparam__y);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_point_2d __sklib__point_at_origin() {
    point_2d __skreturn = point_at_origin();
    return __sklib__to_sklib_point_2d(__skreturn);
}
int __sklib__point_in_circle__point_2d_ref__circle_ref(const __sklib_point_2d pt, const __sklib_circle c) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    circle __skparam__c = __sklib__to_circle(c);
    bool __skreturn = point_in_circle(__skparam__pt, __skparam__c);
    return __sklib__to_int(__skreturn);
}
int __sklib__point_in_circle__double__double__double__double__double(double ptx, double pty, double cx, double cy, double radius) {
    double __skparam__ptx = __sklib__to_double(ptx);
    double __skparam__pty = __sklib__to_double(pty);
    double __skparam__cx = __sklib__to_double(cx);
    double __skparam__cy = __sklib__to_double(cy);
    double __skparam__radius = __sklib__to_double(radius);
    bool __skreturn = point_in_circle(__skparam__ptx, __skparam__pty, __skparam__cx, __skparam__cy, __skparam__radius);
    return __sklib__to_int(__skreturn);
}
int __sklib__point_in_quad__point_2d_ref__quad_ref(const __sklib_point_2d pt, const __sklib_quad q) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    quad __skparam__q = __sklib__to_quad(q);
    bool __skreturn = point_in_quad(__skparam__pt, __skparam__q);
    return __sklib__to_int(__skreturn);
}
int __sklib__point_in_rectangle__point_2d_ref__rectangle_ref(const __sklib_point_2d pt, const __sklib_rectangle rect) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = point_in_rectangle(__skparam__pt, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
int __sklib__point_in_rectangle__double__double__double__double__double__double(double ptx, double pty, double rect_x, double rect_y, double rect_width, double rect_height) {
    double __skparam__ptx = __sklib__to_double(ptx);
    double __skparam__pty = __sklib__to_double(pty);
    double __skparam__rect_x = __sklib__to_double(rect_x);
    double __skparam__rect_y = __sklib__to_double(rect_y);
    double __skparam__rect_width = __sklib__to_double(rect_width);
    double __skparam__rect_height = __sklib__to_double(rect_height);
    bool __skreturn = point_in_rectangle(__skparam__ptx, __skparam__pty, __skparam__rect_x, __skparam__rect_y, __skparam__rect_width, __skparam__rect_height);
    return __sklib__to_int(__skreturn);
}
int __sklib__point_in_triangle__point_2d_ref__triangle_ref(const __sklib_point_2d pt, const __sklib_triangle tri) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    bool __skreturn = point_in_triangle(__skparam__pt, __skparam__tri);
    return __sklib__to_int(__skreturn);
}
float __sklib__point_line_distance__point_2d_ref__line_ref(const __sklib_point_2d pt, const __sklib_line l) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    line __skparam__l = __sklib__to_line(l);
    float __skreturn = point_line_distance(__skparam__pt, __skparam__l);
    return __sklib__to_float(__skreturn);
}
__sklib_point_2d __sklib__point_offset_by__point_2d_ref__vector_2d_ref(const __sklib_point_2d start_point, const __sklib_vector_2d offset) {
    point_2d __skparam__start_point = __sklib__to_point_2d(start_point);
    vector_2d __skparam__offset = __sklib__to_vector_2d(offset);
    point_2d __skreturn = point_offset_by(__skparam__start_point, __skparam__offset);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_point_2d __sklib__point_offset_from_origin__vector_2d_ref(const __sklib_vector_2d offset) {
    vector_2d __skparam__offset = __sklib__to_vector_2d(offset);
    point_2d __skreturn = point_offset_from_origin(__skparam__offset);
    return __sklib__to_sklib_point_2d(__skreturn);
}
int __sklib__point_on_line__point_2d_ref__line_ref(const __sklib_point_2d pt, const __sklib_line l) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    line __skparam__l = __sklib__to_line(l);
    bool __skreturn = point_on_line(__skparam__pt, __skparam__l);
    return __sklib__to_int(__skreturn);
}
int __sklib__point_on_line__point_2d_ref__line_ref__float(const __sklib_point_2d pt, const __sklib_line l, float proximity) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    line __skparam__l = __sklib__to_line(l);
    float __skparam__proximity = __sklib__to_float(proximity);
    bool __skreturn = point_on_line(__skparam__pt, __skparam__l, __skparam__proximity);
    return __sklib__to_int(__skreturn);
}
float __sklib__point_point_angle__point_2d_ref__point_2d_ref(const __sklib_point_2d pt1, const __sklib_point_2d pt2) {
    point_2d __skparam__pt1 = __sklib__to_point_2d(pt1);
    point_2d __skparam__pt2 = __sklib__to_point_2d(pt2);
    float __skreturn = point_point_angle(__skparam__pt1, __skparam__pt2);
    return __sklib__to_float(__skreturn);
}
float __sklib__point_point_distance__point_2d_ref__point_2d_ref(const __sklib_point_2d pt1, const __sklib_point_2d pt2) {
    point_2d __skparam__pt1 = __sklib__to_point_2d(pt1);
    point_2d __skparam__pt2 = __sklib__to_point_2d(pt2);
    float __skreturn = point_point_distance(__skparam__pt1, __skparam__pt2);
    return __sklib__to_float(__skreturn);
}
__sklib_string __sklib__point_to_string__point_2d_ref(const __sklib_point_2d pt) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    string __skreturn = point_to_string(__skparam__pt);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_point_2d __sklib__random_bitmap_point__bitmap(__sklib_bitmap bmp) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    point_2d __skreturn = random_bitmap_point(__skparam__bmp);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_point_2d __sklib__random_screen_point() {
    point_2d __skreturn = random_screen_point();
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_point_2d __sklib__random_window_point__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    point_2d __skreturn = random_window_point(__skparam__wind);
    return __sklib__to_sklib_point_2d(__skreturn);
}
int __sklib__same_point__point_2d_ref__point_2d_ref(const __sklib_point_2d pt1, const __sklib_point_2d pt2) {
    point_2d __skparam__pt1 = __sklib__to_point_2d(pt1);
    point_2d __skparam__pt2 = __sklib__to_point_2d(pt2);
    bool __skreturn = same_point(__skparam__pt1, __skparam__pt2);
    return __sklib__to_int(__skreturn);
}
__sklib_quad __sklib__quad_from__point_2d_ref__point_2d_ref__point_2d_ref__point_2d_ref(const __sklib_point_2d p1, const __sklib_point_2d p2, const __sklib_point_2d p3, const __sklib_point_2d p4) {
    point_2d __skparam__p1 = __sklib__to_point_2d(p1);
    point_2d __skparam__p2 = __sklib__to_point_2d(p2);
    point_2d __skparam__p3 = __sklib__to_point_2d(p3);
    point_2d __skparam__p4 = __sklib__to_point_2d(p4);
    quad __skreturn = quad_from(__skparam__p1, __skparam__p2, __skparam__p3, __skparam__p4);
    return __sklib__to_sklib_quad(__skreturn);
}
__sklib_quad __sklib__quad_from__rectangle_ref(const __sklib_rectangle rect) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    quad __skreturn = quad_from(__skparam__rect);
    return __sklib__to_sklib_quad(__skreturn);
}
__sklib_quad __sklib__quad_from__rectangle_ref__matrix_2d_ref(const __sklib_rectangle rect, const __sklib_matrix_2d transform) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    matrix_2d __skparam__transform = __sklib__to_matrix_2d(transform);
    quad __skreturn = quad_from(__skparam__rect, __skparam__transform);
    return __sklib__to_sklib_quad(__skreturn);
}
__sklib_quad __sklib__quad_from__double__double__double__double__double__double__double__double(double x_top_left, double y_top_left, double x_top_right, double y_top_right, double x_bottom_left, double y_bottom_left, double x_bottom_right, double y_bottom_right) {
    double __skparam__x_top_left = __sklib__to_double(x_top_left);
    double __skparam__y_top_left = __sklib__to_double(y_top_left);
    double __skparam__x_top_right = __sklib__to_double(x_top_right);
    double __skparam__y_top_right = __sklib__to_double(y_top_right);
    double __skparam__x_bottom_left = __sklib__to_double(x_bottom_left);
    double __skparam__y_bottom_left = __sklib__to_double(y_bottom_left);
    double __skparam__x_bottom_right = __sklib__to_double(x_bottom_right);
    double __skparam__y_bottom_right = __sklib__to_double(y_bottom_right);
    quad __skreturn = quad_from(__skparam__x_top_left, __skparam__y_top_left, __skparam__x_top_right, __skparam__y_top_right, __skparam__x_bottom_left, __skparam__y_bottom_left, __skparam__x_bottom_right, __skparam__y_bottom_right);
    return __sklib__to_sklib_quad(__skreturn);
}
int __sklib__quads_intersect__quad_ref__quad_ref(const __sklib_quad q1, const __sklib_quad q2) {
    quad __skparam__q1 = __sklib__to_quad(q1);
    quad __skparam__q2 = __sklib__to_quad(q2);
    bool __skreturn = quads_intersect(__skparam__q1, __skparam__q2);
    return __sklib__to_int(__skreturn);
}
void __sklib__set_quad_point__quad_ref__int__point_2d_ref(__sklib_quad *q, int idx, const __sklib_point_2d value) {
    quad __skparam__q = __sklib__to_quad(*q);
    int __skparam__idx = __sklib__to_int(idx);
    point_2d __skparam__value = __sklib__to_point_2d(value);
    set_quad_point(__skparam__q, __skparam__idx, __skparam__value);
    *q = __sklib__to_sklib_quad(__skparam__q);
}
__sklib_vector_triangle __sklib__triangles_from__quad_ref(const __sklib_quad q) {
    quad __skparam__q = __sklib__to_quad(q);
    vector<triangle> __skreturn = triangles_from(__skparam__q);
    return __sklib__to_sklib_vector_triangle(__skreturn);
}
int __sklib__rnd__int__int(int min, int max) {
    int __skparam__min = __sklib__to_int(min);
    int __skparam__max = __sklib__to_int(max);
    int __skreturn = rnd(__skparam__min, __skparam__max);
    return __sklib__to_int(__skreturn);
}
float __sklib__rnd() {
    float __skreturn = rnd();
    return __sklib__to_float(__skreturn);
}
int __sklib__rnd__int(int ubound) {
    int __skparam__ubound = __sklib__to_int(ubound);
    int __skreturn = rnd(__skparam__ubound);
    return __sklib__to_int(__skreturn);
}
int __sklib__has_gpio() {
    bool __skreturn = has_gpio();
    return __sklib__to_int(__skreturn);
}
void __sklib__raspi_cleanup() {
    raspi_cleanup();
}
int __sklib__raspi_get_mode__pins(int pin) {
    pins __skparam__pin = __sklib__to_pins(pin);
    pin_modes __skreturn = raspi_get_mode(__skparam__pin);
    return __sklib__to_int(__skreturn);
}
void __sklib__raspi_init() {
    raspi_init();
}
int __sklib__raspi_read__pins(int pin) {
    pins __skparam__pin = __sklib__to_pins(pin);
    pin_values __skreturn = raspi_read(__skparam__pin);
    return __sklib__to_int(__skreturn);
}
void __sklib__raspi_set_mode__pins__pin_modes(int pin, int mode) {
    pins __skparam__pin = __sklib__to_pins(pin);
    pin_modes __skparam__mode = __sklib__to_pin_modes(mode);
    raspi_set_mode(__skparam__pin, __skparam__mode);
}
void __sklib__raspi_set_pull_up_down__pins__pull_up_down(int pin, int pud) {
    pins __skparam__pin = __sklib__to_pins(pin);
    pull_up_down __skparam__pud = __sklib__to_pull_up_down(pud);
    raspi_set_pull_up_down(__skparam__pin, __skparam__pud);
}
void __sklib__raspi_set_pwm_dutycycle__pins__int(int pin, int dutycycle) {
    pins __skparam__pin = __sklib__to_pins(pin);
    int __skparam__dutycycle = __sklib__to_int(dutycycle);
    raspi_set_pwm_dutycycle(__skparam__pin, __skparam__dutycycle);
}
void __sklib__raspi_set_pwm_frequency__pins__int(int pin, int frequency) {
    pins __skparam__pin = __sklib__to_pins(pin);
    int __skparam__frequency = __sklib__to_int(frequency);
    raspi_set_pwm_frequency(__skparam__pin, __skparam__frequency);
}
void __sklib__raspi_set_pwm_range__pins__int(int pin, int range) {
    pins __skparam__pin = __sklib__to_pins(pin);
    int __skparam__range = __sklib__to_int(range);
    raspi_set_pwm_range(__skparam__pin, __skparam__range);
}
void __sklib__raspi_write__pins__pin_values(int pin, int value) {
    pins __skparam__pin = __sklib__to_pins(pin);
    pin_values __skparam__value = __sklib__to_pin_values(value);
    raspi_write(__skparam__pin, __skparam__value);
}
void __sklib__draw_quad__color__quad_ref(__sklib_color clr, const __sklib_quad q) {
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    draw_quad(__skparam__clr, __skparam__q);
}
void __sklib__draw_quad__color__quad_ref__drawing_options_ref(__sklib_color clr, const __sklib_quad q, const __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_quad(__skparam__clr, __skparam__q, __skparam__opts);
}
void __sklib__draw_quad_on_bitmap__bitmap__color__quad_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_quad q) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    draw_quad_on_bitmap(__skparam__destination, __skparam__clr, __skparam__q);
}
void __sklib__draw_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_quad q, const __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_quad_on_bitmap(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
}
void __sklib__draw_quad_on_window__window__color__quad_ref(__sklib_window destination, __sklib_color clr, const __sklib_quad q) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    draw_quad_on_window(__skparam__destination, __skparam__clr, __skparam__q);
}
void __sklib__draw_quad_on_window__window__color__quad_ref__drawing_options_ref(__sklib_window destination, __sklib_color clr, const __sklib_quad q, const __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_quad_on_window(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
}
void __sklib__draw_rectangle__color__rectangle_ref(__sklib_color clr, const __sklib_rectangle rect) {
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    draw_rectangle(__skparam__clr, __skparam__rect);
}
void __sklib__draw_rectangle__color__rectangle_ref__drawing_options_ref(__sklib_color clr, const __sklib_rectangle rect, const __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_rectangle(__skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__draw_rectangle__color__double__double__double__double(__sklib_color clr, double x, double y, double width, double height) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    draw_rectangle(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__draw_rectangle__color__double__double__double__double__drawing_options_ref(__sklib_color clr, double x, double y, double width, double height, const __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_rectangle(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
void __sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_rectangle rect) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    draw_rectangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__rect);
}
void __sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_rectangle rect, const __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_rectangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double(__sklib_bitmap destination, __sklib_color clr, double x, double y, double width, double height) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    draw_rectangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__sklib_bitmap destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_rectangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
void __sklib__draw_rectangle_on_window__window__color__rectangle_ref(__sklib_window destination, __sklib_color clr, const __sklib_rectangle rect) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    draw_rectangle_on_window(__skparam__destination, __skparam__clr, __skparam__rect);
}
void __sklib__draw_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(__sklib_window destination, __sklib_color clr, const __sklib_rectangle rect, const __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_rectangle_on_window(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__draw_rectangle_on_window__window__color__double__double__double__double(__sklib_window destination, __sklib_color clr, double x, double y, double width, double height) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    draw_rectangle_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__draw_rectangle_on_window__window__color__double__double__double__double__drawing_options(__sklib_window destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_rectangle_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
void __sklib__fill_quad__color__quad_ref(__sklib_color clr, const __sklib_quad q) {
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    fill_quad(__skparam__clr, __skparam__q);
}
void __sklib__fill_quad__color__quad_ref__drawing_options_ref(__sklib_color clr, const __sklib_quad q, const __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_quad(__skparam__clr, __skparam__q, __skparam__opts);
}
void __sklib__fill_quad_on_bitmap__bitmap__color__quad_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_quad q) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    fill_quad_on_bitmap(__skparam__destination, __skparam__clr, __skparam__q);
}
void __sklib__fill_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_quad q, const __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_quad_on_bitmap(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
}
void __sklib__fill_quad_on_window__window__color__quad_ref(__sklib_window destination, __sklib_color clr, const __sklib_quad q) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    fill_quad_on_window(__skparam__destination, __skparam__clr, __skparam__q);
}
void __sklib__fill_quad_on_window__window__color__quad_ref__drawing_options_ref(__sklib_window destination, __sklib_color clr, const __sklib_quad q, const __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    quad __skparam__q = __sklib__to_quad(q);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_quad_on_window(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
}
void __sklib__fill_rectangle__color__rectangle_ref(__sklib_color clr, const __sklib_rectangle rect) {
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    fill_rectangle(__skparam__clr, __skparam__rect);
}
void __sklib__fill_rectangle__color__rectangle_ref__drawing_options_ref(__sklib_color clr, const __sklib_rectangle rect, const __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_rectangle(__skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__fill_rectangle__color__double__double__double__double(__sklib_color clr, double x, double y, double width, double height) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    fill_rectangle(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__fill_rectangle__color__double__double__double__double__drawing_options_ref(__sklib_color clr, double x, double y, double width, double height, const __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_rectangle(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
void __sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_rectangle rect) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    fill_rectangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__rect);
}
void __sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_rectangle rect, const __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_rectangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double(__sklib_bitmap destination, __sklib_color clr, double x, double y, double width, double height) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    fill_rectangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(__sklib_bitmap destination, __sklib_color clr, double x, double y, double width, double height, const __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_rectangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
void __sklib__fill_rectangle_on_window__window__color__rectangle_ref(__sklib_window destination, __sklib_color clr, const __sklib_rectangle rect) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    fill_rectangle_on_window(__skparam__destination, __skparam__clr, __skparam__rect);
}
void __sklib__fill_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(__sklib_window destination, __sklib_color clr, const __sklib_rectangle rect, const __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_rectangle_on_window(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
}
void __sklib__fill_rectangle_on_window__window__color__double__double__double__double(__sklib_window destination, __sklib_color clr, double x, double y, double width, double height) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    fill_rectangle_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
}
void __sklib__fill_rectangle_on_window__window__color__double__double__double__double__drawing_options_ref(__sklib_window destination, __sklib_color clr, double x, double y, double width, double height, const __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_rectangle_on_window(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
}
__sklib_rectangle __sklib__inset_rectangle__rectangle_ref__float(const __sklib_rectangle rect, float inset_amount) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    float __skparam__inset_amount = __sklib__to_float(inset_amount);
    rectangle __skreturn = inset_rectangle(__skparam__rect, __skparam__inset_amount);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__intersection__rectangle_ref__rectangle_ref(const __sklib_rectangle rect1, const __sklib_rectangle rect2) {
    rectangle __skparam__rect1 = __sklib__to_rectangle(rect1);
    rectangle __skparam__rect2 = __sklib__to_rectangle(rect2);
    rectangle __skreturn = intersection(__skparam__rect1, __skparam__rect2);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__rectangle_around__circle_ref(const __sklib_circle c) {
    circle __skparam__c = __sklib__to_circle(c);
    rectangle __skreturn = rectangle_around(__skparam__c);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__rectangle_around__line_ref(const __sklib_line l) {
    line __skparam__l = __sklib__to_line(l);
    rectangle __skreturn = rectangle_around(__skparam__l);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__rectangle_around__quad_ref(const __sklib_quad q) {
    quad __skparam__q = __sklib__to_quad(q);
    rectangle __skreturn = rectangle_around(__skparam__q);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__rectangle_around__triangle_ref(const __sklib_triangle t) {
    triangle __skparam__t = __sklib__to_triangle(t);
    rectangle __skreturn = rectangle_around(__skparam__t);
    return __sklib__to_sklib_rectangle(__skreturn);
}
float __sklib__rectangle_bottom__rectangle_ref(const __sklib_rectangle rect) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    float __skreturn = rectangle_bottom(__skparam__rect);
    return __sklib__to_float(__skreturn);
}
__sklib_point_2d __sklib__rectangle_center__rectangle_ref(const __sklib_rectangle rect) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    point_2d __skreturn = rectangle_center(__skparam__rect);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_rectangle __sklib__rectangle_from__point_2d__double__double(const __sklib_point_2d pt, const double width, const double height) {
    const point_2d __skparam__pt = __sklib__to_point_2d(pt);
    const double __skparam__width = __sklib__to_double(width);
    const double __skparam__height = __sklib__to_double(height);
    rectangle __skreturn = rectangle_from(__skparam__pt, __skparam__width, __skparam__height);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__rectangle_from__point_2d__point_2d(const __sklib_point_2d pt1, const __sklib_point_2d pt2) {
    const point_2d __skparam__pt1 = __sklib__to_point_2d(pt1);
    const point_2d __skparam__pt2 = __sklib__to_point_2d(pt2);
    rectangle __skreturn = rectangle_from(__skparam__pt1, __skparam__pt2);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__rectangle_from__double__double__double__double(double x, double y, double width, double height) {
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    double __skparam__width = __sklib__to_double(width);
    double __skparam__height = __sklib__to_double(height);
    rectangle __skreturn = rectangle_from(__skparam__x, __skparam__y, __skparam__width, __skparam__height);
    return __sklib__to_sklib_rectangle(__skreturn);
}
float __sklib__rectangle_left__rectangle_ref(const __sklib_rectangle rect) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    float __skreturn = rectangle_left(__skparam__rect);
    return __sklib__to_float(__skreturn);
}
__sklib_rectangle __sklib__rectangle_offset_by__rectangle_ref__vector_2d_ref(const __sklib_rectangle rect, const __sklib_vector_2d offset) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    vector_2d __skparam__offset = __sklib__to_vector_2d(offset);
    rectangle __skreturn = rectangle_offset_by(__skparam__rect, __skparam__offset);
    return __sklib__to_sklib_rectangle(__skreturn);
}
float __sklib__rectangle_right__rectangle_ref(const __sklib_rectangle rect) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    float __skreturn = rectangle_right(__skparam__rect);
    return __sklib__to_float(__skreturn);
}
__sklib_string __sklib__rectangle_to_string__rectangle_ref(const __sklib_rectangle rect) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    string __skreturn = rectangle_to_string(__skparam__rect);
    return __sklib__to_sklib_string(__skreturn);
}
float __sklib__rectangle_top__rectangle_ref(const __sklib_rectangle rect) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    float __skreturn = rectangle_top(__skparam__rect);
    return __sklib__to_float(__skreturn);
}
int __sklib__rectangles_intersect__rectangle_ref__rectangle_ref(const __sklib_rectangle rect1, const __sklib_rectangle rect2) {
    rectangle __skparam__rect1 = __sklib__to_rectangle(rect1);
    rectangle __skparam__rect2 = __sklib__to_rectangle(rect2);
    bool __skreturn = rectangles_intersect(__skparam__rect1, __skparam__rect2);
    return __sklib__to_int(__skreturn);
}
void __sklib__deregister_free_notifier__free_notifier_ptr(__sklib_free_notifier *handler) {
    free_notifier *__skparam__handler = handler;
    deregister_free_notifier(__skparam__handler);
}
__sklib_string __sklib__path_to_resource__string_ref__resource_kind(const __sklib_string filename, int kind) {
    string __skparam__filename = __sklib__to_string(filename);
    resource_kind __skparam__kind = __sklib__to_resource_kind(kind);
    string __skreturn = path_to_resource(__skparam__filename, __skparam__kind);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__path_to_resources() {
    string __skreturn = path_to_resources();
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__path_to_resources__resource_kind(int kind) {
    resource_kind __skparam__kind = __sklib__to_resource_kind(kind);
    string __skreturn = path_to_resources(__skparam__kind);
    return __sklib__to_sklib_string(__skreturn);
}
void __sklib__register_free_notifier__free_notifier_ptr(__sklib_free_notifier *fn) {
    free_notifier *__skparam__fn = fn;
    register_free_notifier(__skparam__fn);
}
void __sklib__set_resources_path__string_ref(const __sklib_string path) {
    string __skparam__path = __sklib__to_string(path);
    set_resources_path(__skparam__path);
}
void __sklib__fade_all_sound_effects_out__int(int ms) {
    int __skparam__ms = __sklib__to_int(ms);
    fade_all_sound_effects_out(__skparam__ms);
}
void __sklib__fade_sound_effect_out__sound_effect__int(__sklib_sound_effect effect, int ms) {
    sound_effect __skparam__effect = __sklib__to_sound_effect(effect);
    int __skparam__ms = __sklib__to_int(ms);
    fade_sound_effect_out(__skparam__effect, __skparam__ms);
}
void __sklib__free_all_sound_effects() {
    free_all_sound_effects();
}
void __sklib__free_sound_effect__sound_effect(__sklib_sound_effect effect) {
    sound_effect __skparam__effect = __sklib__to_sound_effect(effect);
    free_sound_effect(__skparam__effect);
}
int __sklib__has_sound_effect__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_sound_effect(__skparam__name);
    return __sklib__to_int(__skreturn);
}
__sklib_sound_effect __sklib__load_sound_effect__string_ref__string_ref(const __sklib_string name, const __sklib_string filename) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__filename = __sklib__to_string(filename);
    sound_effect __skreturn = load_sound_effect(__skparam__name, __skparam__filename);
    return __sklib__to_sklib_sound_effect(__skreturn);
}
void __sklib__play_sound_effect__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    play_sound_effect(__skparam__name);
}
void __sklib__play_sound_effect__string_ref__double(const __sklib_string name, double volume) {
    string __skparam__name = __sklib__to_string(name);
    double __skparam__volume = __sklib__to_double(volume);
    play_sound_effect(__skparam__name, __skparam__volume);
}
void __sklib__play_sound_effect__string_ref__int(const __sklib_string name, int times) {
    string __skparam__name = __sklib__to_string(name);
    int __skparam__times = __sklib__to_int(times);
    play_sound_effect(__skparam__name, __skparam__times);
}
void __sklib__play_sound_effect__string_ref__int__double(const __sklib_string name, int times, double volume) {
    string __skparam__name = __sklib__to_string(name);
    int __skparam__times = __sklib__to_int(times);
    double __skparam__volume = __sklib__to_double(volume);
    play_sound_effect(__skparam__name, __skparam__times, __skparam__volume);
}
void __sklib__play_sound_effect__sound_effect(__sklib_sound_effect effect) {
    sound_effect __skparam__effect = __sklib__to_sound_effect(effect);
    play_sound_effect(__skparam__effect);
}
void __sklib__play_sound_effect__sound_effect__double(__sklib_sound_effect effect, double volume) {
    sound_effect __skparam__effect = __sklib__to_sound_effect(effect);
    double __skparam__volume = __sklib__to_double(volume);
    play_sound_effect(__skparam__effect, __skparam__volume);
}
void __sklib__play_sound_effect__sound_effect__int(__sklib_sound_effect effect, int times) {
    sound_effect __skparam__effect = __sklib__to_sound_effect(effect);
    int __skparam__times = __sklib__to_int(times);
    play_sound_effect(__skparam__effect, __skparam__times);
}
void __sklib__play_sound_effect__sound_effect__int__double(__sklib_sound_effect effect, int times, double volume) {
    sound_effect __skparam__effect = __sklib__to_sound_effect(effect);
    int __skparam__times = __sklib__to_int(times);
    double __skparam__volume = __sklib__to_double(volume);
    play_sound_effect(__skparam__effect, __skparam__times, __skparam__volume);
}
__sklib_string __sklib__sound_effect_filename__sound_effect(__sklib_sound_effect effect) {
    sound_effect __skparam__effect = __sklib__to_sound_effect(effect);
    string __skreturn = sound_effect_filename(__skparam__effect);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__sound_effect_name__sound_effect(__sklib_sound_effect effect) {
    sound_effect __skparam__effect = __sklib__to_sound_effect(effect);
    string __skreturn = sound_effect_name(__skparam__effect);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_sound_effect __sklib__sound_effect_named__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    sound_effect __skreturn = sound_effect_named(__skparam__name);
    return __sklib__to_sklib_sound_effect(__skreturn);
}
int __sklib__sound_effect_playing__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = sound_effect_playing(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__sound_effect_playing__sound_effect(__sklib_sound_effect effect) {
    sound_effect __skparam__effect = __sklib__to_sound_effect(effect);
    bool __skreturn = sound_effect_playing(__skparam__effect);
    return __sklib__to_int(__skreturn);
}
int __sklib__sound_effect_valid__sound_effect(__sklib_sound_effect effect) {
    sound_effect __skparam__effect = __sklib__to_sound_effect(effect);
    bool __skreturn = sound_effect_valid(__skparam__effect);
    return __sklib__to_int(__skreturn);
}
void __sklib__stop_sound_effect__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    stop_sound_effect(__skparam__name);
}
void __sklib__stop_sound_effect__sound_effect(__sklib_sound_effect effect) {
    sound_effect __skparam__effect = __sklib__to_sound_effect(effect);
    stop_sound_effect(__skparam__effect);
}
void __sklib__call_for_all_sprites__sprite_float_function_ptr__float(__sklib_sprite_float_function *fn, float val) {
    sprite_float_function *__skparam__fn = fn;
    float __skparam__val = __sklib__to_float(val);
    call_for_all_sprites(__skparam__fn, __skparam__val);
}
void __sklib__call_for_all_sprites__sprite_function_ptr(__sklib_sprite_function *fn) {
    sprite_function *__skparam__fn = fn;
    call_for_all_sprites(__skparam__fn);
}
void __sklib__call_on_sprite_event__sprite_event_handler_ptr(__sklib_sprite_event_handler *handler) {
    sprite_event_handler *__skparam__handler = handler;
    call_on_sprite_event(__skparam__handler);
}
__sklib_point_2d __sklib__center_point__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    point_2d __skreturn = center_point(__skparam__s);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_sprite __sklib__create_sprite__bitmap(__sklib_bitmap layer) {
    bitmap __skparam__layer = __sklib__to_bitmap(layer);
    sprite __skreturn = create_sprite(__skparam__layer);
    return __sklib__to_sklib_sprite(__skreturn);
}
__sklib_sprite __sklib__create_sprite__bitmap__animation_script(__sklib_bitmap layer, __sklib_animation_script ani) {
    bitmap __skparam__layer = __sklib__to_bitmap(layer);
    animation_script __skparam__ani = __sklib__to_animation_script(ani);
    sprite __skreturn = create_sprite(__skparam__layer, __skparam__ani);
    return __sklib__to_sklib_sprite(__skreturn);
}
__sklib_sprite __sklib__create_sprite__string_ref(const __sklib_string bitmap_name) {
    string __skparam__bitmap_name = __sklib__to_string(bitmap_name);
    sprite __skreturn = create_sprite(__skparam__bitmap_name);
    return __sklib__to_sklib_sprite(__skreturn);
}
__sklib_sprite __sklib__create_sprite__string_ref__bitmap(const __sklib_string name, __sklib_bitmap layer) {
    string __skparam__name = __sklib__to_string(name);
    bitmap __skparam__layer = __sklib__to_bitmap(layer);
    sprite __skreturn = create_sprite(__skparam__name, __skparam__layer);
    return __sklib__to_sklib_sprite(__skreturn);
}
__sklib_sprite __sklib__create_sprite__string_ref__bitmap__animation_script(const __sklib_string name, __sklib_bitmap layer, __sklib_animation_script ani) {
    string __skparam__name = __sklib__to_string(name);
    bitmap __skparam__layer = __sklib__to_bitmap(layer);
    animation_script __skparam__ani = __sklib__to_animation_script(ani);
    sprite __skreturn = create_sprite(__skparam__name, __skparam__layer, __skparam__ani);
    return __sklib__to_sklib_sprite(__skreturn);
}
__sklib_sprite __sklib__create_sprite__string_ref__string_ref(const __sklib_string bitmap_name, const __sklib_string animation_name) {
    string __skparam__bitmap_name = __sklib__to_string(bitmap_name);
    string __skparam__animation_name = __sklib__to_string(animation_name);
    sprite __skreturn = create_sprite(__skparam__bitmap_name, __skparam__animation_name);
    return __sklib__to_sklib_sprite(__skreturn);
}
void __sklib__create_sprite_pack__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    create_sprite_pack(__skparam__name);
}
__sklib_string __sklib__current_sprite_pack() {
    string __skreturn = current_sprite_pack();
    return __sklib__to_sklib_string(__skreturn);
}
void __sklib__draw_all_sprites() {
    draw_all_sprites();
}
void __sklib__draw_sprite__sprite__vector_2d_ref(__sklib_sprite s, const __sklib_vector_2d offset) {
    sprite __skparam__s = __sklib__to_sprite(s);
    vector_2d __skparam__offset = __sklib__to_vector_2d(offset);
    draw_sprite(__skparam__s, __skparam__offset);
}
void __sklib__draw_sprite__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    draw_sprite(__skparam__s);
}
void __sklib__draw_sprite__sprite__double__double(__sklib_sprite s, double x_offset, double y_offset) {
    sprite __skparam__s = __sklib__to_sprite(s);
    double __skparam__x_offset = __sklib__to_double(x_offset);
    double __skparam__y_offset = __sklib__to_double(y_offset);
    draw_sprite(__skparam__s, __skparam__x_offset, __skparam__y_offset);
}
void __sklib__free_all_sprites() {
    free_all_sprites();
}
void __sklib__free_sprite__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    free_sprite(__skparam__s);
}
void __sklib__free_sprite_pack__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    free_sprite_pack(__skparam__name);
}
int __sklib__has_sprite__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_sprite(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__has_sprite_pack__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_sprite_pack(__skparam__name);
    return __sklib__to_int(__skreturn);
}
void __sklib__move_sprite__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    move_sprite(__skparam__s);
}
void __sklib__move_sprite__sprite__vector_2d_ref(__sklib_sprite s, const __sklib_vector_2d distance) {
    sprite __skparam__s = __sklib__to_sprite(s);
    vector_2d __skparam__distance = __sklib__to_vector_2d(distance);
    move_sprite(__skparam__s, __skparam__distance);
}
void __sklib__move_sprite__sprite__vector_2d_ref__float(__sklib_sprite s, const __sklib_vector_2d distance, float pct) {
    sprite __skparam__s = __sklib__to_sprite(s);
    vector_2d __skparam__distance = __sklib__to_vector_2d(distance);
    float __skparam__pct = __sklib__to_float(pct);
    move_sprite(__skparam__s, __skparam__distance, __skparam__pct);
}
void __sklib__move_sprite__sprite__float(__sklib_sprite s, float pct) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__pct = __sklib__to_float(pct);
    move_sprite(__skparam__s, __skparam__pct);
}
void __sklib__move_sprite_to__sprite__double__double(__sklib_sprite s, double x, double y) {
    sprite __skparam__s = __sklib__to_sprite(s);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    move_sprite_to(__skparam__s, __skparam__x, __skparam__y);
}
void __sklib__select_sprite_pack__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    select_sprite_pack(__skparam__name);
}
int __sklib__sprite_add_layer__sprite__bitmap__string_ref(__sklib_sprite s, __sklib_bitmap new_layer, const __sklib_string layer_name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bitmap __skparam__new_layer = __sklib__to_bitmap(new_layer);
    string __skparam__layer_name = __sklib__to_string(layer_name);
    int __skreturn = sprite_add_layer(__skparam__s, __skparam__new_layer, __skparam__layer_name);
    return __sklib__to_int(__skreturn);
}
void __sklib__sprite_add_to_velocity__sprite__vector_2d_ref(__sklib_sprite s, const __sklib_vector_2d value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    vector_2d __skparam__value = __sklib__to_vector_2d(value);
    sprite_add_to_velocity(__skparam__s, __skparam__value);
}
void __sklib__sprite_add_value__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    sprite_add_value(__skparam__s, __skparam__name);
}
void __sklib__sprite_add_value__sprite__string_ref__float(__sklib_sprite s, const __sklib_string name, float init_val) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    float __skparam__init_val = __sklib__to_float(init_val);
    sprite_add_value(__skparam__s, __skparam__name, __skparam__init_val);
}
__sklib_point_2d __sklib__sprite_anchor_point__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    point_2d __skreturn = sprite_anchor_point(__skparam__s);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_point_2d __sklib__sprite_anchor_position__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    point_2d __skreturn = sprite_anchor_position(__skparam__s);
    return __sklib__to_sklib_point_2d(__skreturn);
}
int __sklib__sprite_animation_has_ended__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bool __skreturn = sprite_animation_has_ended(__skparam__s);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__sprite_animation_name__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skreturn = sprite_animation_name(__skparam__s);
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__sprite_at__sprite__point_2d_ref(__sklib_sprite s, const __sklib_point_2d pt) {
    sprite __skparam__s = __sklib__to_sprite(s);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = sprite_at(__skparam__s, __skparam__pt);
    return __sklib__to_int(__skreturn);
}
void __sklib__sprite_bring_layer_forward__sprite__int(__sklib_sprite s, int visible_layer) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__visible_layer = __sklib__to_int(visible_layer);
    sprite_bring_layer_forward(__skparam__s, __skparam__visible_layer);
}
void __sklib__sprite_bring_layer_to_front__sprite__int(__sklib_sprite s, int visible_layer) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__visible_layer = __sklib__to_int(visible_layer);
    sprite_bring_layer_to_front(__skparam__s, __skparam__visible_layer);
}
void __sklib__sprite_call_on_event__sprite__sprite_event_handler_ptr(__sklib_sprite s, __sklib_sprite_event_handler *handler) {
    sprite __skparam__s = __sklib__to_sprite(s);
    sprite_event_handler *__skparam__handler = handler;
    sprite_call_on_event(__skparam__s, __skparam__handler);
}
__sklib_circle __sklib__sprite_circle__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    circle __skreturn = sprite_circle(__skparam__s);
    return __sklib__to_sklib_circle(__skreturn);
}
__sklib_bitmap __sklib__sprite_collision_bitmap__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bitmap __skreturn = sprite_collision_bitmap(__skparam__s);
    return __sklib__to_sklib_bitmap(__skreturn);
}
__sklib_circle __sklib__sprite_collision_circle__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    circle __skreturn = sprite_collision_circle(__skparam__s);
    return __sklib__to_sklib_circle(__skreturn);
}
int __sklib__sprite_collision_kind__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    collision_test_kind __skreturn = sprite_collision_kind(__skparam__s);
    return __sklib__to_int(__skreturn);
}
__sklib_rectangle __sklib__sprite_collision_rectangle__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    rectangle __skreturn = sprite_collision_rectangle(__skparam__s);
    return __sklib__to_sklib_rectangle(__skreturn);
}
int __sklib__sprite_current_cell__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skreturn = sprite_current_cell(__skparam__s);
    return __sklib__to_int(__skreturn);
}
__sklib_rectangle __sklib__sprite_current_cell_rectangle__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    rectangle __skreturn = sprite_current_cell_rectangle(__skparam__s);
    return __sklib__to_sklib_rectangle(__skreturn);
}
float __sklib__sprite_dx__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skreturn = sprite_dx(__skparam__s);
    return __sklib__to_float(__skreturn);
}
float __sklib__sprite_dy__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skreturn = sprite_dy(__skparam__s);
    return __sklib__to_float(__skreturn);
}
int __sklib__sprite_has_value__sprite__string(__sklib_sprite s, __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = sprite_has_value(__skparam__s, __skparam__name);
    return __sklib__to_int(__skreturn);
}
float __sklib__sprite_heading__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skreturn = sprite_heading(__skparam__s);
    return __sklib__to_float(__skreturn);
}
int __sklib__sprite_height__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skreturn = sprite_height(__skparam__s);
    return __sklib__to_int(__skreturn);
}
void __sklib__sprite_hide_layer__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    sprite_hide_layer(__skparam__s, __skparam__name);
}
void __sklib__sprite_hide_layer__sprite__int(__sklib_sprite s, int id) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__id = __sklib__to_int(id);
    sprite_hide_layer(__skparam__s, __skparam__id);
}
__sklib_bitmap __sklib__sprite_layer__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    bitmap __skreturn = sprite_layer(__skparam__s, __skparam__name);
    return __sklib__to_sklib_bitmap(__skreturn);
}
__sklib_bitmap __sklib__sprite_layer__sprite__int(__sklib_sprite s, int idx) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    bitmap __skreturn = sprite_layer(__skparam__s, __skparam__idx);
    return __sklib__to_sklib_bitmap(__skreturn);
}
__sklib_circle __sklib__sprite_layer_circle__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    circle __skreturn = sprite_layer_circle(__skparam__s, __skparam__name);
    return __sklib__to_sklib_circle(__skreturn);
}
__sklib_circle __sklib__sprite_layer_circle__sprite__int(__sklib_sprite s, int idx) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    circle __skreturn = sprite_layer_circle(__skparam__s, __skparam__idx);
    return __sklib__to_sklib_circle(__skreturn);
}
int __sklib__sprite_layer_count__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skreturn = sprite_layer_count(__skparam__s);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_layer_height__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = sprite_layer_height(__skparam__s, __skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_layer_height__sprite__int(__sklib_sprite s, int idx) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    int __skreturn = sprite_layer_height(__skparam__s, __skparam__idx);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_layer_index__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = sprite_layer_index(__skparam__s, __skparam__name);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__sprite_layer_name__sprite__int(__sklib_sprite s, int idx) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    string __skreturn = sprite_layer_name(__skparam__s, __skparam__idx);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_vector_2d __sklib__sprite_layer_offset__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    vector_2d __skreturn = sprite_layer_offset(__skparam__s, __skparam__name);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__sprite_layer_offset__sprite__int(__sklib_sprite s, int idx) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    vector_2d __skreturn = sprite_layer_offset(__skparam__s, __skparam__idx);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_rectangle __sklib__sprite_layer_rectangle__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    rectangle __skreturn = sprite_layer_rectangle(__skparam__s, __skparam__name);
    return __sklib__to_sklib_rectangle(__skreturn);
}
__sklib_rectangle __sklib__sprite_layer_rectangle__sprite__int(__sklib_sprite s, int idx) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    rectangle __skreturn = sprite_layer_rectangle(__skparam__s, __skparam__idx);
    return __sklib__to_sklib_rectangle(__skreturn);
}
int __sklib__sprite_layer_width__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = sprite_layer_width(__skparam__s, __skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_layer_width__sprite__int(__sklib_sprite s, int idx) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    int __skreturn = sprite_layer_width(__skparam__s, __skparam__idx);
    return __sklib__to_int(__skreturn);
}
__sklib_matrix_2d __sklib__sprite_location_matrix__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    matrix_2d __skreturn = sprite_location_matrix(__skparam__s);
    return __sklib__to_sklib_matrix_2d(__skreturn);
}
float __sklib__sprite_mass__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skreturn = sprite_mass(__skparam__s);
    return __sklib__to_float(__skreturn);
}
int __sklib__sprite_move_from_anchor_point__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bool __skreturn = sprite_move_from_anchor_point(__skparam__s);
    return __sklib__to_int(__skreturn);
}
void __sklib__sprite_move_to__sprite__point_2d_ref__float(__sklib_sprite s, const __sklib_point_2d pt, float taking_seconds) {
    sprite __skparam__s = __sklib__to_sprite(s);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    float __skparam__taking_seconds = __sklib__to_float(taking_seconds);
    sprite_move_to(__skparam__s, __skparam__pt, __skparam__taking_seconds);
}
__sklib_string __sklib__sprite_name__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skreturn = sprite_name(__skparam__s);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_sprite __sklib__sprite_named__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    sprite __skreturn = sprite_named(__skparam__name);
    return __sklib__to_sklib_sprite(__skreturn);
}
int __sklib__sprite_offscreen__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bool __skreturn = sprite_offscreen(__skparam__s);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_on_screen_at__sprite__point_2d_ref(__sklib_sprite s, const __sklib_point_2d pt) {
    sprite __skparam__s = __sklib__to_sprite(s);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    bool __skreturn = sprite_on_screen_at(__skparam__s, __skparam__pt);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_on_screen_at__sprite__double__double(__sklib_sprite s, double x, double y) {
    sprite __skparam__s = __sklib__to_sprite(s);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    bool __skreturn = sprite_on_screen_at(__skparam__s, __skparam__x, __skparam__y);
    return __sklib__to_int(__skreturn);
}
__sklib_point_2d __sklib__sprite_position__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    point_2d __skreturn = sprite_position(__skparam__s);
    return __sklib__to_sklib_point_2d(__skreturn);
}
void __sklib__sprite_replay_animation__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    sprite_replay_animation(__skparam__s);
}
void __sklib__sprite_replay_animation__sprite__bool(__sklib_sprite s, int with_sound) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    sprite_replay_animation(__skparam__s, __skparam__with_sound);
}
float __sklib__sprite_rotation__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skreturn = sprite_rotation(__skparam__s);
    return __sklib__to_float(__skreturn);
}
float __sklib__sprite_scale__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skreturn = sprite_scale(__skparam__s);
    return __sklib__to_float(__skreturn);
}
__sklib_rectangle __sklib__sprite_screen_rectangle__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    rectangle __skreturn = sprite_screen_rectangle(__skparam__s);
    return __sklib__to_sklib_rectangle(__skreturn);
}
void __sklib__sprite_send_layer_backward__sprite__int(__sklib_sprite s, int visible_layer) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__visible_layer = __sklib__to_int(visible_layer);
    sprite_send_layer_backward(__skparam__s, __skparam__visible_layer);
}
void __sklib__sprite_send_layer_to_back__sprite__int(__sklib_sprite s, int visible_layer) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__visible_layer = __sklib__to_int(visible_layer);
    sprite_send_layer_to_back(__skparam__s, __skparam__visible_layer);
}
void __sklib__sprite_set_anchor_point__sprite__point_2d_ref(__sklib_sprite s, const __sklib_point_2d pt) {
    sprite __skparam__s = __sklib__to_sprite(s);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    sprite_set_anchor_point(__skparam__s, __skparam__pt);
}
void __sklib__sprite_set_collision_bitmap__sprite__bitmap(__sklib_sprite s, __sklib_bitmap bmp) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    sprite_set_collision_bitmap(__skparam__s, __skparam__bmp);
}
void __sklib__sprite_set_collision_kind__sprite__collision_test_kind(__sklib_sprite s, int value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    collision_test_kind __skparam__value = __sklib__to_collision_test_kind(value);
    sprite_set_collision_kind(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_dx__sprite__float(__sklib_sprite s, float value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__value = __sklib__to_float(value);
    sprite_set_dx(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_dy__sprite__float(__sklib_sprite s, float value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__value = __sklib__to_float(value);
    sprite_set_dy(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_heading__sprite__float(__sklib_sprite s, float value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__value = __sklib__to_float(value);
    sprite_set_heading(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_layer_offset__sprite__string_ref__vector_2d_ref(__sklib_sprite s, const __sklib_string name, const __sklib_vector_2d value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    vector_2d __skparam__value = __sklib__to_vector_2d(value);
    sprite_set_layer_offset(__skparam__s, __skparam__name, __skparam__value);
}
void __sklib__sprite_set_layer_offset__sprite__int__vector_2d_ref(__sklib_sprite s, int idx, const __sklib_vector_2d value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    vector_2d __skparam__value = __sklib__to_vector_2d(value);
    sprite_set_layer_offset(__skparam__s, __skparam__idx, __skparam__value);
}
void __sklib__sprite_set_mass__sprite__float(__sklib_sprite s, float value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__value = __sklib__to_float(value);
    sprite_set_mass(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_move_from_anchor_point__sprite__bool(__sklib_sprite s, int value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bool __skparam__value = __sklib__to_bool(value);
    sprite_set_move_from_anchor_point(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_position__sprite__point_2d_ref(__sklib_sprite s, const __sklib_point_2d value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    point_2d __skparam__value = __sklib__to_point_2d(value);
    sprite_set_position(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_rotation__sprite__float(__sklib_sprite s, float value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__value = __sklib__to_float(value);
    sprite_set_rotation(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_scale__sprite__float(__sklib_sprite s, float value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__value = __sklib__to_float(value);
    sprite_set_scale(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_speed__sprite__float(__sklib_sprite s, float value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__value = __sklib__to_float(value);
    sprite_set_speed(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_value__sprite__string_ref__float(__sklib_sprite s, const __sklib_string name, float val) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    float __skparam__val = __sklib__to_float(val);
    sprite_set_value(__skparam__s, __skparam__name, __skparam__val);
}
void __sklib__sprite_set_velocity__sprite__vector_2d_ref(__sklib_sprite s, const __sklib_vector_2d value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    vector_2d __skparam__value = __sklib__to_vector_2d(value);
    sprite_set_velocity(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_x__sprite__float(__sklib_sprite s, float value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__value = __sklib__to_float(value);
    sprite_set_x(__skparam__s, __skparam__value);
}
void __sklib__sprite_set_y__sprite__float(__sklib_sprite s, float value) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__value = __sklib__to_float(value);
    sprite_set_y(__skparam__s, __skparam__value);
}
int __sklib__sprite_show_layer__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = sprite_show_layer(__skparam__s, __skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_show_layer__sprite__int(__sklib_sprite s, int id) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__id = __sklib__to_int(id);
    int __skreturn = sprite_show_layer(__skparam__s, __skparam__id);
    return __sklib__to_int(__skreturn);
}
float __sklib__sprite_speed__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skreturn = sprite_speed(__skparam__s);
    return __sklib__to_float(__skreturn);
}
void __sklib__sprite_start_animation__sprite__string_ref(__sklib_sprite s, const __sklib_string named) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__named = __sklib__to_string(named);
    sprite_start_animation(__skparam__s, __skparam__named);
}
void __sklib__sprite_start_animation__sprite__string_ref__bool(__sklib_sprite s, const __sklib_string named, int with_sound) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__named = __sklib__to_string(named);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    sprite_start_animation(__skparam__s, __skparam__named, __skparam__with_sound);
}
void __sklib__sprite_start_animation__sprite__int(__sklib_sprite s, int idx) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    sprite_start_animation(__skparam__s, __skparam__idx);
}
void __sklib__sprite_start_animation__sprite__int__bool(__sklib_sprite s, int idx, int with_sound) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    sprite_start_animation(__skparam__s, __skparam__idx, __skparam__with_sound);
}
void __sklib__sprite_stop_calling_on_event__sprite__sprite_event_handler_ptr(__sklib_sprite s, __sklib_sprite_event_handler *handler) {
    sprite __skparam__s = __sklib__to_sprite(s);
    sprite_event_handler *__skparam__handler = handler;
    sprite_stop_calling_on_event(__skparam__s, __skparam__handler);
}
void __sklib__sprite_toggle_layer_visible__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    sprite_toggle_layer_visible(__skparam__s, __skparam__name);
}
void __sklib__sprite_toggle_layer_visible__sprite__int(__sklib_sprite s, int id) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__id = __sklib__to_int(id);
    sprite_toggle_layer_visible(__skparam__s, __skparam__id);
}
float __sklib__sprite_value__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    float __skreturn = sprite_value(__skparam__s, __skparam__name);
    return __sklib__to_float(__skreturn);
}
int __sklib__sprite_value_count__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skreturn = sprite_value_count(__skparam__s);
    return __sklib__to_int(__skreturn);
}
__sklib_vector_2d __sklib__sprite_velocity__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    vector_2d __skreturn = sprite_velocity(__skparam__s);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
int __sklib__sprite_visible_index_of_layer__sprite__string_ref(__sklib_sprite s, const __sklib_string name) {
    sprite __skparam__s = __sklib__to_sprite(s);
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = sprite_visible_index_of_layer(__skparam__s, __skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_visible_index_of_layer__sprite__int(__sklib_sprite s, int id) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__id = __sklib__to_int(id);
    int __skreturn = sprite_visible_index_of_layer(__skparam__s, __skparam__id);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_visible_layer__sprite__int(__sklib_sprite s, int idx) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    int __skreturn = sprite_visible_layer(__skparam__s, __skparam__idx);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_visible_layer_count__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skreturn = sprite_visible_layer_count(__skparam__s);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_visible_layer_id__sprite__int(__sklib_sprite s, int idx) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skparam__idx = __sklib__to_int(idx);
    int __skreturn = sprite_visible_layer_id(__skparam__s, __skparam__idx);
    return __sklib__to_int(__skreturn);
}
int __sklib__sprite_width__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    int __skreturn = sprite_width(__skparam__s);
    return __sklib__to_int(__skreturn);
}
float __sklib__sprite_x__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skreturn = sprite_x(__skparam__s);
    return __sklib__to_float(__skreturn);
}
float __sklib__sprite_y__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skreturn = sprite_y(__skparam__s);
    return __sklib__to_float(__skreturn);
}
void __sklib__stop_calling_on_sprite_event__sprite_event_handler_ptr(__sklib_sprite_event_handler *handler) {
    sprite_event_handler *__skparam__handler = handler;
    stop_calling_on_sprite_event(__skparam__handler);
}
void __sklib__update_all_sprites() {
    update_all_sprites();
}
void __sklib__update_all_sprites__float(float pct) {
    float __skparam__pct = __sklib__to_float(pct);
    update_all_sprites(__skparam__pct);
}
void __sklib__update_sprite__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    update_sprite(__skparam__s);
}
void __sklib__update_sprite__sprite__bool(__sklib_sprite s, int with_sound) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    update_sprite(__skparam__s, __skparam__with_sound);
}
void __sklib__update_sprite__sprite__float(__sklib_sprite s, float pct) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__pct = __sklib__to_float(pct);
    update_sprite(__skparam__s, __skparam__pct);
}
void __sklib__update_sprite__sprite__float__bool(__sklib_sprite s, float pct, int with_sound) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__pct = __sklib__to_float(pct);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    update_sprite(__skparam__s, __skparam__pct, __skparam__with_sound);
}
void __sklib__update_sprite_animation__sprite(__sklib_sprite s) {
    sprite __skparam__s = __sklib__to_sprite(s);
    update_sprite_animation(__skparam__s);
}
void __sklib__update_sprite_animation__sprite__bool(__sklib_sprite s, int with_sound) {
    sprite __skparam__s = __sklib__to_sprite(s);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    update_sprite_animation(__skparam__s, __skparam__with_sound);
}
void __sklib__update_sprite_animation__sprite__float(__sklib_sprite s, float pct) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__pct = __sklib__to_float(pct);
    update_sprite_animation(__skparam__s, __skparam__pct);
}
void __sklib__update_sprite_animation__sprite__float__bool(__sklib_sprite s, float pct, int with_sound) {
    sprite __skparam__s = __sklib__to_sprite(s);
    float __skparam__pct = __sklib__to_float(pct);
    bool __skparam__with_sound = __sklib__to_bool(with_sound);
    update_sprite_animation(__skparam__s, __skparam__pct, __skparam__with_sound);
}
__sklib_vector_2d __sklib__vector_from_center_sprite_to_point__sprite__point_2d_ref(__sklib_sprite s, const __sklib_point_2d pt) {
    sprite __skparam__s = __sklib__to_sprite(s);
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    vector_2d __skreturn = vector_from_center_sprite_to_point(__skparam__s, __skparam__pt);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_from_to__sprite__sprite(__sklib_sprite s1, __sklib_sprite s2) {
    sprite __skparam__s1 = __sklib__to_sprite(s1);
    sprite __skparam__s2 = __sklib__to_sprite(s2);
    vector_2d __skreturn = vector_from_to(__skparam__s1, __skparam__s2);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
char __sklib__read_char() {
    char __skreturn = read_char();
    return __sklib__to_char(__skreturn);
}
__sklib_string __sklib__read_line() {
    string __skreturn = read_line();
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__terminal_has_input() {
    bool __skreturn = terminal_has_input();
    return __sklib__to_int(__skreturn);
}
void __sklib__write__char(char data) {
    char __skparam__data = __sklib__to_char(data);
    write(__skparam__data);
}
void __sklib__write__double(double data) {
    double __skparam__data = __sklib__to_double(data);
    write(__skparam__data);
}
void __sklib__write__int(int data) {
    int __skparam__data = __sklib__to_int(data);
    write(__skparam__data);
}
void __sklib__write__string(__sklib_string text) {
    string __skparam__text = __sklib__to_string(text);
    write(__skparam__text);
}
void __sklib__write_line__char(char data) {
    char __skparam__data = __sklib__to_char(data);
    write_line(__skparam__data);
}
void __sklib__write_line() {
    write_line();
}
void __sklib__write_line__double(double data) {
    double __skparam__data = __sklib__to_double(data);
    write_line(__skparam__data);
}
void __sklib__write_line__int(int data) {
    int __skparam__data = __sklib__to_int(data);
    write_line(__skparam__data);
}
void __sklib__write_line__string(__sklib_string line) {
    string __skparam__line = __sklib__to_string(line);
    write_line(__skparam__line);
}
void __sklib__draw_text__string_ref__color_ref__string_ref__int__double__double(const __sklib_string text, const __sklib_color clr, const __sklib_string fnt, int font_size, double x, double y) {
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    string __skparam__fnt = __sklib__to_string(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_text(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
}
void __sklib__draw_text__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(const __sklib_string text, const __sklib_color clr, const __sklib_string fnt, int font_size, double x, double y, const __sklib_drawing_options opts) {
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    string __skparam__fnt = __sklib__to_string(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_text(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_text__string_ref__color_ref__double__double(const __sklib_string text, const __sklib_color clr, double x, double y) {
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_text(__skparam__text, __skparam__clr, __skparam__x, __skparam__y);
}
void __sklib__draw_text__string_ref__color_ref__double__double__drawing_options_ref(const __sklib_string text, const __sklib_color clr, double x, double y, const __sklib_drawing_options opts) {
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_text(__skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_text__string_ref__color_ref__font__int__double__double(const __sklib_string text, const __sklib_color clr, __sklib_font fnt, int font_size, double x, double y) {
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    font __skparam__fnt = __sklib__to_font(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_text(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
}
void __sklib__draw_text__string_ref__color_ref__font__int__double__double__drawing_options_ref(const __sklib_string text, const __sklib_color clr, __sklib_font fnt, int font_size, double x, double y, const __sklib_drawing_options opts) {
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    font __skparam__fnt = __sklib__to_font(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_text(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double(__sklib_bitmap bmp, const __sklib_string text, const __sklib_color clr, const __sklib_string fnt, int font_size, double x, double y) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    string __skparam__fnt = __sklib__to_string(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_text_on_bitmap(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
}
void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__sklib_bitmap bmp, const __sklib_string text, const __sklib_color clr, const __sklib_string fnt, int font_size, double x, double y, const __sklib_drawing_options opts) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    string __skparam__fnt = __sklib__to_string(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_text_on_bitmap(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double(__sklib_bitmap bmp, const __sklib_string text, const __sklib_color clr, double x, double y) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_text_on_bitmap(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__x, __skparam__y);
}
void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double__drawing_options_ref(__sklib_bitmap bmp, const __sklib_string text, const __sklib_color clr, double x, double y, const __sklib_drawing_options opts) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_text_on_bitmap(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double(__sklib_bitmap bmp, const __sklib_string text, const __sklib_color clr, __sklib_font fnt, int font_size, double x, double y) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    font __skparam__fnt = __sklib__to_font(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_text_on_bitmap(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
}
void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double__drawing_options_ref(__sklib_bitmap bmp, const __sklib_string text, const __sklib_color clr, __sklib_font fnt, int font_size, double x, double y, const __sklib_drawing_options opts) {
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    font __skparam__fnt = __sklib__to_font(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_text_on_bitmap(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double(__sklib_window wnd, const __sklib_string text, const __sklib_color clr, const __sklib_string fnt, int font_size, double x, double y) {
    window __skparam__wnd = __sklib__to_window(wnd);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    string __skparam__fnt = __sklib__to_string(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_text_on_window(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
}
void __sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__sklib_window wnd, const __sklib_string text, const __sklib_color clr, const __sklib_string fnt, int font_size, double x, double y, const __sklib_drawing_options opts) {
    window __skparam__wnd = __sklib__to_window(wnd);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    string __skparam__fnt = __sklib__to_string(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_text_on_window(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_text_on_window__window__string_ref__color_ref__double__double(__sklib_window wnd, const __sklib_string text, const __sklib_color clr, double x, double y) {
    window __skparam__wnd = __sklib__to_window(wnd);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_text_on_window(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__x, __skparam__y);
}
void __sklib__draw_text_on_window__window__string_ref__color_ref__double__double__drawing_options_ref(__sklib_window wnd, const __sklib_string text, const __sklib_color clr, double x, double y, const __sklib_drawing_options opts) {
    window __skparam__wnd = __sklib__to_window(wnd);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_text_on_window(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
}
void __sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double(__sklib_window wnd, const __sklib_string text, const __sklib_color clr, __sklib_font fnt, int font_size, double x, double y) {
    window __skparam__wnd = __sklib__to_window(wnd);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    font __skparam__fnt = __sklib__to_font(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    draw_text_on_window(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
}
void __sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double__drawing_options_ref(__sklib_window wnd, const __sklib_string text, const __sklib_color clr, __sklib_font fnt, int font_size, double x, double y, const __sklib_drawing_options opts) {
    window __skparam__wnd = __sklib__to_window(wnd);
    string __skparam__text = __sklib__to_string(text);
    color __skparam__clr = __sklib__to_color(clr);
    font __skparam__fnt = __sklib__to_font(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_text_on_window(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
}
int __sklib__font_has_size__string_ref__int(const __sklib_string name, int font_size) {
    string __skparam__name = __sklib__to_string(name);
    int __skparam__font_size = __sklib__to_int(font_size);
    bool __skreturn = font_has_size(__skparam__name, __skparam__font_size);
    return __sklib__to_int(__skreturn);
}
int __sklib__font_has_size__font__int(__sklib_font fnt, int font_size) {
    font __skparam__fnt = __sklib__to_font(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    bool __skreturn = font_has_size(__skparam__fnt, __skparam__font_size);
    return __sklib__to_int(__skreturn);
}
void __sklib__font_load_size__string_ref__int(const __sklib_string name, int font_size) {
    string __skparam__name = __sklib__to_string(name);
    int __skparam__font_size = __sklib__to_int(font_size);
    font_load_size(__skparam__name, __skparam__font_size);
}
void __sklib__font_load_size__font__int(__sklib_font fnt, int font_size) {
    font __skparam__fnt = __sklib__to_font(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    font_load_size(__skparam__fnt, __skparam__font_size);
}
__sklib_font __sklib__font_named__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    font __skreturn = font_named(__skparam__name);
    return __sklib__to_sklib_font(__skreturn);
}
void __sklib__free_all_fonts() {
    free_all_fonts();
}
void __sklib__free_font__font(__sklib_font fnt) {
    font __skparam__fnt = __sklib__to_font(fnt);
    free_font(__skparam__fnt);
}
int __sklib__get_font_style__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    font_style __skreturn = get_font_style(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__get_font_style__font(__sklib_font fnt) {
    font __skparam__fnt = __sklib__to_font(fnt);
    font_style __skreturn = get_font_style(__skparam__fnt);
    return __sklib__to_int(__skreturn);
}
__sklib_font __sklib__get_system_font() {
    font __skreturn = get_system_font();
    return __sklib__to_sklib_font(__skreturn);
}
int __sklib__has_font__font(__sklib_font fnt) {
    font __skparam__fnt = __sklib__to_font(fnt);
    bool __skreturn = has_font(__skparam__fnt);
    return __sklib__to_int(__skreturn);
}
int __sklib__has_font__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_font(__skparam__name);
    return __sklib__to_int(__skreturn);
}
__sklib_font __sklib__load_font__string_ref__string_ref(const __sklib_string name, const __sklib_string filename) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__filename = __sklib__to_string(filename);
    font __skreturn = load_font(__skparam__name, __skparam__filename);
    return __sklib__to_sklib_font(__skreturn);
}
void __sklib__set_font_style__string_ref__font_style(const __sklib_string name, int style) {
    string __skparam__name = __sklib__to_string(name);
    font_style __skparam__style = __sklib__to_font_style(style);
    set_font_style(__skparam__name, __skparam__style);
}
void __sklib__set_font_style__font__font_style(__sklib_font fnt, int style) {
    font __skparam__fnt = __sklib__to_font(fnt);
    font_style __skparam__style = __sklib__to_font_style(style);
    set_font_style(__skparam__fnt, __skparam__style);
}
int __sklib__text_height__string_ref__string_ref__int(const __sklib_string text, const __sklib_string fnt, int font_size) {
    string __skparam__text = __sklib__to_string(text);
    string __skparam__fnt = __sklib__to_string(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    int __skreturn = text_height(__skparam__text, __skparam__fnt, __skparam__font_size);
    return __sklib__to_int(__skreturn);
}
int __sklib__text_height__string_ref__font__int(const __sklib_string text, __sklib_font fnt, int font_size) {
    string __skparam__text = __sklib__to_string(text);
    font __skparam__fnt = __sklib__to_font(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    int __skreturn = text_height(__skparam__text, __skparam__fnt, __skparam__font_size);
    return __sklib__to_int(__skreturn);
}
int __sklib__text_width__string_ref__string_ref__int(const __sklib_string text, const __sklib_string fnt, int font_size) {
    string __skparam__text = __sklib__to_string(text);
    string __skparam__fnt = __sklib__to_string(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    int __skreturn = text_width(__skparam__text, __skparam__fnt, __skparam__font_size);
    return __sklib__to_int(__skreturn);
}
int __sklib__text_width__string_ref__font__int(const __sklib_string text, __sklib_font fnt, int font_size) {
    string __skparam__text = __sklib__to_string(text);
    font __skparam__fnt = __sklib__to_font(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    int __skreturn = text_width(__skparam__text, __skparam__fnt, __skparam__font_size);
    return __sklib__to_int(__skreturn);
}
void __sklib__draw_collected_text__color__font__int__drawing_options_ref(__sklib_color clr, __sklib_font fnt, int font_size, const __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    font __skparam__fnt = __sklib__to_font(fnt);
    int __skparam__font_size = __sklib__to_int(font_size);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_collected_text(__skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__opts);
}
void __sklib__end_reading_text() {
    end_reading_text();
}
void __sklib__end_reading_text__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    end_reading_text(__skparam__wind);
}
int __sklib__reading_text() {
    bool __skreturn = reading_text();
    return __sklib__to_int(__skreturn);
}
int __sklib__reading_text__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    bool __skreturn = reading_text(__skparam__wind);
    return __sklib__to_int(__skreturn);
}
void __sklib__start_reading_text__rectangle(__sklib_rectangle rect) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    start_reading_text(__skparam__rect);
}
void __sklib__start_reading_text__rectangle__string(__sklib_rectangle rect, __sklib_string initial_text) {
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    string __skparam__initial_text = __sklib__to_string(initial_text);
    start_reading_text(__skparam__rect, __skparam__initial_text);
}
void __sklib__start_reading_text__window__rectangle(__sklib_window wind, __sklib_rectangle rect) {
    window __skparam__wind = __sklib__to_window(wind);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    start_reading_text(__skparam__wind, __skparam__rect);
}
void __sklib__start_reading_text__window__rectangle__string(__sklib_window wind, __sklib_rectangle rect, __sklib_string initial_text) {
    window __skparam__wind = __sklib__to_window(wind);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    string __skparam__initial_text = __sklib__to_string(initial_text);
    start_reading_text(__skparam__wind, __skparam__rect, __skparam__initial_text);
}
int __sklib__text_entry_cancelled() {
    bool __skreturn = text_entry_cancelled();
    return __sklib__to_int(__skreturn);
}
int __sklib__text_entry_cancelled__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    bool __skreturn = text_entry_cancelled(__skparam__wind);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__text_input() {
    string __skreturn = text_input();
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__text_input__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    string __skreturn = text_input(__skparam__wind);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_timer __sklib__create_timer__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    timer __skreturn = create_timer(__skparam__name);
    return __sklib__to_sklib_timer(__skreturn);
}
void __sklib__free_all_timers() {
    free_all_timers();
}
void __sklib__free_timer__timer(__sklib_timer to_free) {
    timer __skparam__to_free = __sklib__to_timer(to_free);
    free_timer(__skparam__to_free);
}
int __sklib__has_timer__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = has_timer(__skparam__name);
    return __sklib__to_int(__skreturn);
}
void __sklib__pause_timer__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    pause_timer(__skparam__name);
}
void __sklib__pause_timer__timer(__sklib_timer to_pause) {
    timer __skparam__to_pause = __sklib__to_timer(to_pause);
    pause_timer(__skparam__to_pause);
}
void __sklib__reset_timer__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    reset_timer(__skparam__name);
}
void __sklib__reset_timer__timer(__sklib_timer tmr) {
    timer __skparam__tmr = __sklib__to_timer(tmr);
    reset_timer(__skparam__tmr);
}
void __sklib__resume_timer__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    resume_timer(__skparam__name);
}
void __sklib__resume_timer__timer(__sklib_timer to_resume) {
    timer __skparam__to_resume = __sklib__to_timer(to_resume);
    resume_timer(__skparam__to_resume);
}
void __sklib__start_timer__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    start_timer(__skparam__name);
}
void __sklib__start_timer__timer(__sklib_timer to_start) {
    timer __skparam__to_start = __sklib__to_timer(to_start);
    start_timer(__skparam__to_start);
}
void __sklib__stop_timer__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    stop_timer(__skparam__name);
}
void __sklib__stop_timer__timer(__sklib_timer to_stop) {
    timer __skparam__to_stop = __sklib__to_timer(to_stop);
    stop_timer(__skparam__to_stop);
}
__sklib_timer __sklib__timer_named__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    timer __skreturn = timer_named(__skparam__name);
    return __sklib__to_sklib_timer(__skreturn);
}
int __sklib__timer_paused__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = timer_paused(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__timer_paused__timer(__sklib_timer to_get) {
    timer __skparam__to_get = __sklib__to_timer(to_get);
    bool __skreturn = timer_paused(__skparam__to_get);
    return __sklib__to_int(__skreturn);
}
int __sklib__timer_started__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = timer_started(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__timer_started__timer(__sklib_timer to_get) {
    timer __skparam__to_get = __sklib__to_timer(to_get);
    bool __skreturn = timer_started(__skparam__to_get);
    return __sklib__to_int(__skreturn);
}
unsigned int __sklib__timer_ticks__string(__sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    unsigned int __skreturn = timer_ticks(__skparam__name);
    return __sklib__to_unsigned_int(__skreturn);
}
unsigned int __sklib__timer_ticks__timer(__sklib_timer to_get) {
    timer __skparam__to_get = __sklib__to_timer(to_get);
    unsigned int __skreturn = timer_ticks(__skparam__to_get);
    return __sklib__to_unsigned_int(__skreturn);
}
void __sklib__draw_triangle__color__triangle_ref(__sklib_color clr, const __sklib_triangle tri) {
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    draw_triangle(__skparam__clr, __skparam__tri);
}
void __sklib__draw_triangle__color__triangle_ref__drawing_options(__sklib_color clr, const __sklib_triangle tri, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_triangle(__skparam__clr, __skparam__tri, __skparam__opts);
}
void __sklib__draw_triangle__color__double__double__double__double__double__double(__sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    draw_triangle(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
}
void __sklib__draw_triangle__color__double__double__double__double__double__double__drawing_options(__sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_triangle(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
}
void __sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_triangle tri) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    draw_triangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__tri);
}
void __sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(__sklib_bitmap destination, __sklib_color clr, const __sklib_triangle tri, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_triangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
}
void __sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(__sklib_bitmap destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    draw_triangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
}
void __sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(__sklib_bitmap destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_triangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
}
void __sklib__draw_triangle_on_window__window__color__triangle_ref(__sklib_window destination, __sklib_color clr, const __sklib_triangle tri) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    draw_triangle_on_window(__skparam__destination, __skparam__clr, __skparam__tri);
}
void __sklib__draw_triangle_on_window__window__color__triangle_ref__drawing_options(__sklib_window destination, __sklib_color clr, const __sklib_triangle tri, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_triangle_on_window(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
}
void __sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double(__sklib_window destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    draw_triangle_on_window(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
}
void __sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(__sklib_window destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    draw_triangle_on_window(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
}
void __sklib__fill_triangle__color__triangle_ref(__sklib_color clr, const __sklib_triangle tri) {
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    fill_triangle(__skparam__clr, __skparam__tri);
}
void __sklib__fill_triangle__color__triangle_ref__drawing_options(__sklib_color clr, const __sklib_triangle tri, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_triangle(__skparam__clr, __skparam__tri, __skparam__opts);
}
void __sklib__fill_triangle__color__double__double__double__double__double__double(__sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    fill_triangle(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
}
void __sklib__fill_triangle__color__double__double__double__double__double__double__drawing_options(__sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts) {
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_triangle(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
}
void __sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref(__sklib_bitmap destination, __sklib_color clr, const __sklib_triangle tri) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    fill_triangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__tri);
}
void __sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(__sklib_bitmap destination, __sklib_color clr, const __sklib_triangle tri, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_triangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
}
void __sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(__sklib_bitmap destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    fill_triangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
}
void __sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(__sklib_bitmap destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts) {
    bitmap __skparam__destination = __sklib__to_bitmap(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_triangle_on_bitmap(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
}
void __sklib__fill_triangle_on_window__window__color__triangle_ref(__sklib_window destination, __sklib_color clr, const __sklib_triangle tri) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    fill_triangle_on_window(__skparam__destination, __skparam__clr, __skparam__tri);
}
void __sklib__fill_triangle_on_window__window__color__triangle_ref__drawing_options(__sklib_window destination, __sklib_color clr, const __sklib_triangle tri, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    triangle __skparam__tri = __sklib__to_triangle(tri);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_triangle_on_window(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
}
void __sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double(__sklib_window destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    fill_triangle_on_window(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
}
void __sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(__sklib_window destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts) {
    window __skparam__destination = __sklib__to_window(destination);
    color __skparam__clr = __sklib__to_color(clr);
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    drawing_options __skparam__opts = __sklib__to_drawing_options(opts);
    fill_triangle_on_window(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
}
__sklib_point_2d __sklib__triangle_barycenter__triangle_ref(const __sklib_triangle tri) {
    triangle __skparam__tri = __sklib__to_triangle(tri);
    point_2d __skreturn = triangle_barycenter(__skparam__tri);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_triangle __sklib__triangle_from__point_2d_ref__point_2d_ref__point_2d_ref(const __sklib_point_2d p1, const __sklib_point_2d p2, const __sklib_point_2d p3) {
    point_2d __skparam__p1 = __sklib__to_point_2d(p1);
    point_2d __skparam__p2 = __sklib__to_point_2d(p2);
    point_2d __skparam__p3 = __sklib__to_point_2d(p3);
    triangle __skreturn = triangle_from(__skparam__p1, __skparam__p2, __skparam__p3);
    return __sklib__to_sklib_triangle(__skreturn);
}
__sklib_triangle __sklib__triangle_from__double__double__double__double__double__double(double x1, double y1, double x2, double y2, double x3, double y3) {
    double __skparam__x1 = __sklib__to_double(x1);
    double __skparam__y1 = __sklib__to_double(y1);
    double __skparam__x2 = __sklib__to_double(x2);
    double __skparam__y2 = __sklib__to_double(y2);
    double __skparam__x3 = __sklib__to_double(x3);
    double __skparam__y3 = __sklib__to_double(y3);
    triangle __skreturn = triangle_from(__skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
    return __sklib__to_sklib_triangle(__skreturn);
}
int __sklib__triangle_rectangle_intersect__triangle_ref__rectangle_ref(const __sklib_triangle tri, const __sklib_rectangle rect) {
    triangle __skparam__tri = __sklib__to_triangle(tri);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = triangle_rectangle_intersect(__skparam__tri, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__triangle_to_string__triangle_ref(const __sklib_triangle tri) {
    triangle __skparam__tri = __sklib__to_triangle(tri);
    string __skreturn = triangle_to_string(__skparam__tri);
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__triangles_intersect__triangle_ref__triangle_ref(const __sklib_triangle t1, const __sklib_triangle t2) {
    triangle __skparam__t1 = __sklib__to_triangle(t1);
    triangle __skparam__t2 = __sklib__to_triangle(t2);
    bool __skreturn = triangles_intersect(__skparam__t1, __skparam__t2);
    return __sklib__to_int(__skreturn);
}
unsigned int __sklib__current_ticks() {
    unsigned int __skreturn = current_ticks();
    return __sklib__to_unsigned_int(__skreturn);
}
void __sklib__delay__int(int milliseconds) {
    int __skparam__milliseconds = __sklib__to_int(milliseconds);
    delay(__skparam__milliseconds);
}
void __sklib__display_dialog__string_ref__string_ref__font__int(const __sklib_string title, const __sklib_string msg, __sklib_font output_font, int font_size) {
    string __skparam__title = __sklib__to_string(title);
    string __skparam__msg = __sklib__to_string(msg);
    font __skparam__output_font = __sklib__to_font(output_font);
    int __skparam__font_size = __sklib__to_int(font_size);
    display_dialog(__skparam__title, __skparam__msg, __skparam__output_font, __skparam__font_size);
}
__sklib_string __sklib__file_as_string__string__resource_kind(__sklib_string filename, int kind) {
    string __skparam__filename = __sklib__to_string(filename);
    resource_kind __skparam__kind = __sklib__to_resource_kind(kind);
    string __skreturn = file_as_string(__skparam__filename, __skparam__kind);
    return __sklib__to_sklib_string(__skreturn);
}
double __sklib__angle_between__vector_2d_ref__vector_2d_ref(const __sklib_vector_2d v1, const __sklib_vector_2d v2) {
    vector_2d __skparam__v1 = __sklib__to_vector_2d(v1);
    vector_2d __skparam__v2 = __sklib__to_vector_2d(v2);
    double __skreturn = angle_between(__skparam__v1, __skparam__v2);
    return __sklib__to_double(__skreturn);
}
double __sklib__dot_product__vector_2d_ref__vector_2d_ref(const __sklib_vector_2d v1, const __sklib_vector_2d v2) {
    vector_2d __skparam__v1 = __sklib__to_vector_2d(v1);
    vector_2d __skparam__v2 = __sklib__to_vector_2d(v2);
    double __skreturn = dot_product(__skparam__v1, __skparam__v2);
    return __sklib__to_double(__skreturn);
}
int __sklib__is_zero_vector__vector_2d_ref(const __sklib_vector_2d v) {
    vector_2d __skparam__v = __sklib__to_vector_2d(v);
    bool __skreturn = is_zero_vector(__skparam__v);
    return __sklib__to_int(__skreturn);
}
int __sklib__ray_intersection_point__point_2d_ref__vector_2d_ref__line_ref__point_2d_ref(const __sklib_point_2d from_pt, const __sklib_vector_2d heading, const __sklib_line l, __sklib_point_2d *pt) {
    point_2d __skparam__from_pt = __sklib__to_point_2d(from_pt);
    vector_2d __skparam__heading = __sklib__to_vector_2d(heading);
    line __skparam__l = __sklib__to_line(l);
    point_2d __skparam__pt = __sklib__to_point_2d(*pt);
    bool __skreturn = ray_intersection_point(__skparam__from_pt, __skparam__heading, __skparam__l, __skparam__pt);
    *pt = __sklib__to_sklib_point_2d(__skparam__pt);
    return __sklib__to_int(__skreturn);
}
__sklib_vector_2d __sklib__unit_vector__vector_2d_ref(const __sklib_vector_2d v) {
    vector_2d __skparam__v = __sklib__to_vector_2d(v);
    vector_2d __skreturn = unit_vector(__skparam__v);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_add__vector_2d_ref__vector_2d_ref(const __sklib_vector_2d v1, const __sklib_vector_2d v2) {
    vector_2d __skparam__v1 = __sklib__to_vector_2d(v1);
    vector_2d __skparam__v2 = __sklib__to_vector_2d(v2);
    vector_2d __skreturn = vector_add(__skparam__v1, __skparam__v2);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
double __sklib__vector_angle__vector_2d(const __sklib_vector_2d v) {
    const vector_2d __skparam__v = __sklib__to_vector_2d(v);
    double __skreturn = vector_angle(__skparam__v);
    return __sklib__to_double(__skreturn);
}
__sklib_vector_2d __sklib__vector_from_angle__double__double(double angle, double magnitude) {
    double __skparam__angle = __sklib__to_double(angle);
    double __skparam__magnitude = __sklib__to_double(magnitude);
    vector_2d __skreturn = vector_from_angle(__skparam__angle, __skparam__magnitude);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_from_line__line_ref(const __sklib_line l) {
    line __skparam__l = __sklib__to_line(l);
    vector_2d __skreturn = vector_from_line(__skparam__l);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_from_point_to_rect__point_2d_ref__rectangle_ref(const __sklib_point_2d pt, const __sklib_rectangle rect) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    vector_2d __skreturn = vector_from_point_to_rect(__skparam__pt, __skparam__rect);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
int __sklib__vector_in_rect__vector_2d_ref__rectangle_ref(const __sklib_vector_2d v, const __sklib_rectangle rect) {
    vector_2d __skparam__v = __sklib__to_vector_2d(v);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    bool __skreturn = vector_in_rect(__skparam__v, __skparam__rect);
    return __sklib__to_int(__skreturn);
}
__sklib_vector_2d __sklib__vector_invert__vector_2d_ref(const __sklib_vector_2d v) {
    vector_2d __skparam__v = __sklib__to_vector_2d(v);
    vector_2d __skreturn = vector_invert(__skparam__v);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_limit__vector_2d_ref__double(const __sklib_vector_2d v, double limit) {
    vector_2d __skparam__v = __sklib__to_vector_2d(v);
    double __skparam__limit = __sklib__to_double(limit);
    vector_2d __skreturn = vector_limit(__skparam__v, __skparam__limit);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
double __sklib__vector_magnitude__vector_2d_ref(const __sklib_vector_2d v) {
    vector_2d __skparam__v = __sklib__to_vector_2d(v);
    double __skreturn = vector_magnitude(__skparam__v);
    return __sklib__to_double(__skreturn);
}
double __sklib__vector_magnitude_squared__vector_2d_ref(const __sklib_vector_2d v) {
    vector_2d __skparam__v = __sklib__to_vector_2d(v);
    double __skreturn = vector_magnitude_squared(__skparam__v);
    return __sklib__to_double(__skreturn);
}
__sklib_vector_2d __sklib__vector_multiply__vector_2d_ref__double(const __sklib_vector_2d v1, double s) {
    vector_2d __skparam__v1 = __sklib__to_vector_2d(v1);
    double __skparam__s = __sklib__to_double(s);
    vector_2d __skreturn = vector_multiply(__skparam__v1, __skparam__s);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_normal__vector_2d_ref(const __sklib_vector_2d v) {
    vector_2d __skparam__v = __sklib__to_vector_2d(v);
    vector_2d __skreturn = vector_normal(__skparam__v);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_out_of_circle_from_circle__circle_ref__circle_ref__vector_2d_ref(const __sklib_circle src, const __sklib_circle bounds, const __sklib_vector_2d velocity) {
    circle __skparam__src = __sklib__to_circle(src);
    circle __skparam__bounds = __sklib__to_circle(bounds);
    vector_2d __skparam__velocity = __sklib__to_vector_2d(velocity);
    vector_2d __skreturn = vector_out_of_circle_from_circle(__skparam__src, __skparam__bounds, __skparam__velocity);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_out_of_circle_from_point__point_2d_ref__circle_ref__vector_2d_ref(const __sklib_point_2d pt, const __sklib_circle c, const __sklib_vector_2d velocity) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    circle __skparam__c = __sklib__to_circle(c);
    vector_2d __skparam__velocity = __sklib__to_vector_2d(velocity);
    vector_2d __skreturn = vector_out_of_circle_from_point(__skparam__pt, __skparam__c, __skparam__velocity);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_out_of_rect_from_circle__circle_ref__rectangle_ref__vector_2d_ref(const __sklib_circle c, const __sklib_rectangle rect, const __sklib_vector_2d velocity) {
    circle __skparam__c = __sklib__to_circle(c);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    vector_2d __skparam__velocity = __sklib__to_vector_2d(velocity);
    vector_2d __skreturn = vector_out_of_rect_from_circle(__skparam__c, __skparam__rect, __skparam__velocity);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_out_of_rect_from_point__point_2d_ref__rectangle_ref__vector_2d_ref(const __sklib_point_2d pt, const __sklib_rectangle rect, const __sklib_vector_2d velocity) {
    point_2d __skparam__pt = __sklib__to_point_2d(pt);
    rectangle __skparam__rect = __sklib__to_rectangle(rect);
    vector_2d __skparam__velocity = __sklib__to_vector_2d(velocity);
    vector_2d __skreturn = vector_out_of_rect_from_point(__skparam__pt, __skparam__rect, __skparam__velocity);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_out_of_rect_from_rect__rectangle_ref__rectangle_ref__vector_2d_ref(const __sklib_rectangle src, const __sklib_rectangle bounds, const __sklib_vector_2d velocity) {
    rectangle __skparam__src = __sklib__to_rectangle(src);
    rectangle __skparam__bounds = __sklib__to_rectangle(bounds);
    vector_2d __skparam__velocity = __sklib__to_vector_2d(velocity);
    vector_2d __skreturn = vector_out_of_rect_from_rect(__skparam__src, __skparam__bounds, __skparam__velocity);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_point_to_point__point_2d_ref__point_2d_ref(const __sklib_point_2d start, const __sklib_point_2d end_pt) {
    point_2d __skparam__start = __sklib__to_point_2d(start);
    point_2d __skparam__end_pt = __sklib__to_point_2d(end_pt);
    vector_2d __skreturn = vector_point_to_point(__skparam__start, __skparam__end_pt);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_subtract__vector_2d_ref__vector_2d_ref(const __sklib_vector_2d v1, const __sklib_vector_2d v2) {
    vector_2d __skparam__v1 = __sklib__to_vector_2d(v1);
    vector_2d __skparam__v2 = __sklib__to_vector_2d(v2);
    vector_2d __skreturn = vector_subtract(__skparam__v1, __skparam__v2);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_to__point_2d_ref(const __sklib_point_2d p1) {
    point_2d __skparam__p1 = __sklib__to_point_2d(p1);
    vector_2d __skreturn = vector_to(__skparam__p1);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_vector_2d __sklib__vector_to__double__double(double x, double y) {
    double __skparam__x = __sklib__to_double(x);
    double __skparam__y = __sklib__to_double(y);
    vector_2d __skreturn = vector_to(__skparam__x, __skparam__y);
    return __sklib__to_sklib_vector_2d(__skreturn);
}
__sklib_string __sklib__vector_to_string__vector_2d_ref(const __sklib_vector_2d v) {
    vector_2d __skparam__v = __sklib__to_vector_2d(v);
    string __skreturn = vector_to_string(__skparam__v);
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__vectors_equal__vector_2d_ref__vector_2d(const __sklib_vector_2d v1, const __sklib_vector_2d v2) {
    vector_2d __skparam__v1 = __sklib__to_vector_2d(v1);
    const vector_2d __skparam__v2 = __sklib__to_vector_2d(v2);
    bool __skreturn = vectors_equal(__skparam__v1, __skparam__v2);
    return __sklib__to_int(__skreturn);
}
int __sklib__vectors_not_equal__vector_2d_ref__vector_2d(const __sklib_vector_2d v1, const __sklib_vector_2d v2) {
    vector_2d __skparam__v1 = __sklib__to_vector_2d(v1);
    const vector_2d __skparam__v2 = __sklib__to_vector_2d(v2);
    bool __skreturn = vectors_not_equal(__skparam__v1, __skparam__v2);
    return __sklib__to_int(__skreturn);
}
__sklib_bitmap __sklib__download_bitmap__string_ref__string_ref__unsigned_short(const __sklib_string name, const __sklib_string url, unsigned short port) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__url = __sklib__to_string(url);
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    bitmap __skreturn = download_bitmap(__skparam__name, __skparam__url, __skparam__port);
    return __sklib__to_sklib_bitmap(__skreturn);
}
__sklib_font __sklib__download_font__string_ref__string_ref__unsigned_short(const __sklib_string name, const __sklib_string url, unsigned short port) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__url = __sklib__to_string(url);
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    font __skreturn = download_font(__skparam__name, __skparam__url, __skparam__port);
    return __sklib__to_sklib_font(__skreturn);
}
__sklib_music __sklib__download_music__string_ref__string_ref__unsigned_short(const __sklib_string name, const __sklib_string url, unsigned short port) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__url = __sklib__to_string(url);
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    music __skreturn = download_music(__skparam__name, __skparam__url, __skparam__port);
    return __sklib__to_sklib_music(__skreturn);
}
__sklib_sound_effect __sklib__download_sound_effect__string_ref__string_ref__unsigned_short(const __sklib_string name, const __sklib_string url, unsigned short port) {
    string __skparam__name = __sklib__to_string(name);
    string __skparam__url = __sklib__to_string(url);
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    sound_effect __skreturn = download_sound_effect(__skparam__name, __skparam__url, __skparam__port);
    return __sklib__to_sklib_sound_effect(__skreturn);
}
void __sklib__free_response__http_response(__sklib_http_response response) {
    http_response __skparam__response = __sklib__to_http_response(response);
    free_response(__skparam__response);
}
__sklib_http_response __sklib__http_get__string_ref__unsigned_short(const __sklib_string url, unsigned short port) {
    string __skparam__url = __sklib__to_string(url);
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    http_response __skreturn = http_get(__skparam__url, __skparam__port);
    return __sklib__to_sklib_http_response(__skreturn);
}
__sklib_http_response __sklib__http_post__string_ref__unsigned_short__string_ref__vector_string_ref(const __sklib_string url, unsigned short port, const __sklib_string body, const __sklib_vector_string headers) {
    string __skparam__url = __sklib__to_string(url);
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    string __skparam__body = __sklib__to_string(body);
    vector<string> __skparam__headers = __sklib__to_vector_string(headers);
    http_response __skreturn = http_post(__skparam__url, __skparam__port, __skparam__body, __skparam__headers);
    return __sklib__to_sklib_http_response(__skreturn);
}
__sklib_http_response __sklib__http_post__string_ref__unsigned_short__string(const __sklib_string url, unsigned short port, __sklib_string body) {
    string __skparam__url = __sklib__to_string(url);
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    string __skparam__body = __sklib__to_string(body);
    http_response __skreturn = http_post(__skparam__url, __skparam__port, __skparam__body);
    return __sklib__to_sklib_http_response(__skreturn);
}
__sklib_string __sklib__http_response_to_string__http_response(__sklib_http_response response) {
    http_response __skparam__response = __sklib__to_http_response(response);
    string __skreturn = http_response_to_string(__skparam__response);
    return __sklib__to_sklib_string(__skreturn);
}
void __sklib__save_response_to_file__http_response__string(__sklib_http_response response, __sklib_string path) {
    http_response __skparam__response = __sklib__to_http_response(response);
    string __skparam__path = __sklib__to_string(path);
    save_response_to_file(__skparam__response, __skparam__path);
}
int __sklib__has_incoming_requests__web_server(__sklib_web_server server) {
    web_server __skparam__server = __sklib__to_web_server(server);
    bool __skreturn = has_incoming_requests(__skparam__server);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_delete_request_for__http_request__string_ref(__sklib_http_request request, const __sklib_string path) {
    http_request __skparam__request = __sklib__to_http_request(request);
    string __skparam__path = __sklib__to_string(path);
    bool __skreturn = is_delete_request_for(__skparam__request, __skparam__path);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_get_request_for__http_request__string_ref(__sklib_http_request request, const __sklib_string path) {
    http_request __skparam__request = __sklib__to_http_request(request);
    string __skparam__path = __sklib__to_string(path);
    bool __skreturn = is_get_request_for(__skparam__request, __skparam__path);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_options_request_for__http_request__string_ref(__sklib_http_request request, const __sklib_string path) {
    http_request __skparam__request = __sklib__to_http_request(request);
    string __skparam__path = __sklib__to_string(path);
    bool __skreturn = is_options_request_for(__skparam__request, __skparam__path);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_post_request_for__http_request__string_ref(__sklib_http_request request, const __sklib_string path) {
    http_request __skparam__request = __sklib__to_http_request(request);
    string __skparam__path = __sklib__to_string(path);
    bool __skreturn = is_post_request_for(__skparam__request, __skparam__path);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_put_request_for__http_request__string_ref(__sklib_http_request request, const __sklib_string path) {
    http_request __skparam__request = __sklib__to_http_request(request);
    string __skparam__path = __sklib__to_string(path);
    bool __skreturn = is_put_request_for(__skparam__request, __skparam__path);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_request_for__http_request__http_method__string_ref(__sklib_http_request request, int method, const __sklib_string path) {
    http_request __skparam__request = __sklib__to_http_request(request);
    http_method __skparam__method = __sklib__to_http_method(method);
    string __skparam__path = __sklib__to_string(path);
    bool __skreturn = is_request_for(__skparam__request, __skparam__method, __skparam__path);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_trace_request_for__http_request__string_ref(__sklib_http_request request, const __sklib_string path) {
    http_request __skparam__request = __sklib__to_http_request(request);
    string __skparam__path = __sklib__to_string(path);
    bool __skreturn = is_trace_request_for(__skparam__request, __skparam__path);
    return __sklib__to_int(__skreturn);
}
__sklib_http_request __sklib__next_web_request__web_server(__sklib_web_server server) {
    web_server __skparam__server = __sklib__to_web_server(server);
    http_request __skreturn = next_web_request(__skparam__server);
    return __sklib__to_sklib_http_request(__skreturn);
}
__sklib_string __sklib__request_body__http_request(__sklib_http_request r) {
    http_request __skparam__r = __sklib__to_http_request(r);
    string __skreturn = request_body(__skparam__r);
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__request_has_query_parameter__http_request__string_ref(__sklib_http_request r, const __sklib_string name) {
    http_request __skparam__r = __sklib__to_http_request(r);
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = request_has_query_parameter(__skparam__r, __skparam__name);
    return __sklib__to_int(__skreturn);
}
__sklib_vector_string __sklib__request_headers__http_request(__sklib_http_request r) {
    http_request __skparam__r = __sklib__to_http_request(r);
    vector<string> __skreturn = request_headers(__skparam__r);
    return __sklib__to_sklib_vector_string(__skreturn);
}
int __sklib__request_method__http_request(__sklib_http_request r) {
    http_request __skparam__r = __sklib__to_http_request(r);
    http_method __skreturn = request_method(__skparam__r);
    return __sklib__to_int(__skreturn);
}
__sklib_string __sklib__request_query_parameter__http_request__string_ref__string_ref(__sklib_http_request r, const __sklib_string name, const __sklib_string default_value) {
    http_request __skparam__r = __sklib__to_http_request(r);
    string __skparam__name = __sklib__to_string(name);
    string __skparam__default_value = __sklib__to_string(default_value);
    string __skreturn = request_query_parameter(__skparam__r, __skparam__name, __skparam__default_value);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__request_query_string__http_request(__sklib_http_request r) {
    http_request __skparam__r = __sklib__to_http_request(r);
    string __skreturn = request_query_string(__skparam__r);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_string __sklib__request_uri__http_request(__sklib_http_request r) {
    http_request __skparam__r = __sklib__to_http_request(r);
    string __skreturn = request_uri(__skparam__r);
    return __sklib__to_sklib_string(__skreturn);
}
__sklib_vector_string __sklib__request_uri_stubs__http_request(__sklib_http_request r) {
    http_request __skparam__r = __sklib__to_http_request(r);
    vector<string> __skreturn = request_uri_stubs(__skparam__r);
    return __sklib__to_sklib_vector_string(__skreturn);
}
void __sklib__send_css_file_response__http_request__string_ref(__sklib_http_request r, const __sklib_string filename) {
    http_request __skparam__r = __sklib__to_http_request(r);
    string __skparam__filename = __sklib__to_string(filename);
    send_css_file_response(__skparam__r, __skparam__filename);
}
void __sklib__send_file_response__http_request__string_ref__string_ref(__sklib_http_request r, const __sklib_string filename, const __sklib_string content_type) {
    http_request __skparam__r = __sklib__to_http_request(r);
    string __skparam__filename = __sklib__to_string(filename);
    string __skparam__content_type = __sklib__to_string(content_type);
    send_file_response(__skparam__r, __skparam__filename, __skparam__content_type);
}
void __sklib__send_html_file_response__http_request__string_ref(__sklib_http_request r, const __sklib_string filename) {
    http_request __skparam__r = __sklib__to_http_request(r);
    string __skparam__filename = __sklib__to_string(filename);
    send_html_file_response(__skparam__r, __skparam__filename);
}
void __sklib__send_javascript_file_response__http_request__string_ref(__sklib_http_request r, const __sklib_string filename) {
    http_request __skparam__r = __sklib__to_http_request(r);
    string __skparam__filename = __sklib__to_string(filename);
    send_javascript_file_response(__skparam__r, __skparam__filename);
}
void __sklib__send_response__http_request(__sklib_http_request r) {
    http_request __skparam__r = __sklib__to_http_request(r);
    send_response(__skparam__r);
}
void __sklib__send_response__http_request__string_ref(__sklib_http_request r, const __sklib_string message) {
    http_request __skparam__r = __sklib__to_http_request(r);
    string __skparam__message = __sklib__to_string(message);
    send_response(__skparam__r, __skparam__message);
}
void __sklib__send_response__http_request__http_status_code(__sklib_http_request r, int code) {
    http_request __skparam__r = __sklib__to_http_request(r);
    http_status_code __skparam__code = __sklib__to_http_status_code(code);
    send_response(__skparam__r, __skparam__code);
}
void __sklib__send_response__http_request__http_status_code__string_ref(__sklib_http_request r, int code, const __sklib_string message) {
    http_request __skparam__r = __sklib__to_http_request(r);
    http_status_code __skparam__code = __sklib__to_http_status_code(code);
    string __skparam__message = __sklib__to_string(message);
    send_response(__skparam__r, __skparam__code, __skparam__message);
}
void __sklib__send_response__http_request__http_status_code__string_ref__string_ref(__sklib_http_request r, int code, const __sklib_string message, const __sklib_string content_type) {
    http_request __skparam__r = __sklib__to_http_request(r);
    http_status_code __skparam__code = __sklib__to_http_status_code(code);
    string __skparam__message = __sklib__to_string(message);
    string __skparam__content_type = __sklib__to_string(content_type);
    send_response(__skparam__r, __skparam__code, __skparam__message, __skparam__content_type);
}
void __sklib__send_response__http_request__http_status_code__string_ref__string_ref__vector_string_ref(__sklib_http_request r, int code, const __sklib_string message, const __sklib_string content_type, const __sklib_vector_string headers) {
    http_request __skparam__r = __sklib__to_http_request(r);
    http_status_code __skparam__code = __sklib__to_http_status_code(code);
    string __skparam__message = __sklib__to_string(message);
    string __skparam__content_type = __sklib__to_string(content_type);
    vector<string> __skparam__headers = __sklib__to_vector_string(headers);
    send_response(__skparam__r, __skparam__code, __skparam__message, __skparam__content_type, __skparam__headers);
}
void __sklib__send_response__http_request__json(__sklib_http_request r, __sklib_json j) {
    http_request __skparam__r = __sklib__to_http_request(r);
    json __skparam__j = __sklib__to_json(j);
    send_response(__skparam__r, __skparam__j);
}
__sklib_vector_string __sklib__split_uri_stubs__string_ref(const __sklib_string uri) {
    string __skparam__uri = __sklib__to_string(uri);
    vector<string> __skreturn = split_uri_stubs(__skparam__uri);
    return __sklib__to_sklib_vector_string(__skreturn);
}
__sklib_web_server __sklib__start_web_server() {
    web_server __skreturn = start_web_server();
    return __sklib__to_sklib_web_server(__skreturn);
}
__sklib_web_server __sklib__start_web_server__unsigned_short(unsigned short port) {
    unsigned short __skparam__port = __sklib__to_unsigned_short(port);
    web_server __skreturn = start_web_server(__skparam__port);
    return __sklib__to_sklib_web_server(__skreturn);
}
void __sklib__stop_web_server__web_server(__sklib_web_server server) {
    web_server __skparam__server = __sklib__to_web_server(server);
    stop_web_server(__skparam__server);
}
void __sklib__clear_window__window__color(__sklib_window wind, __sklib_color clr) {
    window __skparam__wind = __sklib__to_window(wind);
    color __skparam__clr = __sklib__to_color(clr);
    clear_window(__skparam__wind, __skparam__clr);
}
void __sklib__close_all_windows() {
    close_all_windows();
}
void __sklib__close_current_window() {
    close_current_window();
}
void __sklib__close_window__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    close_window(__skparam__name);
}
void __sklib__close_window__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    close_window(__skparam__wind);
}
__sklib_window __sklib__current_window() {
    window __skreturn = current_window();
    return __sklib__to_sklib_window(__skreturn);
}
int __sklib__current_window_has_border() {
    bool __skreturn = current_window_has_border();
    return __sklib__to_int(__skreturn);
}
int __sklib__current_window_height() {
    int __skreturn = current_window_height();
    return __sklib__to_int(__skreturn);
}
int __sklib__current_window_is_fullscreen() {
    bool __skreturn = current_window_is_fullscreen();
    return __sklib__to_int(__skreturn);
}
__sklib_point_2d __sklib__current_window_position() {
    point_2d __skreturn = current_window_position();
    return __sklib__to_sklib_point_2d(__skreturn);
}
void __sklib__current_window_toggle_border() {
    current_window_toggle_border();
}
void __sklib__current_window_toggle_fullscreen() {
    current_window_toggle_fullscreen();
}
int __sklib__current_window_width() {
    int __skreturn = current_window_width();
    return __sklib__to_int(__skreturn);
}
int __sklib__current_window_x() {
    int __skreturn = current_window_x();
    return __sklib__to_int(__skreturn);
}
int __sklib__current_window_y() {
    int __skreturn = current_window_y();
    return __sklib__to_int(__skreturn);
}
int __sklib__has_window__string(__sklib_string caption) {
    string __skparam__caption = __sklib__to_string(caption);
    bool __skreturn = has_window(__skparam__caption);
    return __sklib__to_int(__skreturn);
}
int __sklib__is_current_window__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    bool __skreturn = is_current_window(__skparam__wind);
    return __sklib__to_int(__skreturn);
}
void __sklib__move_current_window_to__int__int(int x, int y) {
    int __skparam__x = __sklib__to_int(x);
    int __skparam__y = __sklib__to_int(y);
    move_current_window_to(__skparam__x, __skparam__y);
}
void __sklib__move_window_to__string_ref__int__int(const __sklib_string name, int x, int y) {
    string __skparam__name = __sklib__to_string(name);
    int __skparam__x = __sklib__to_int(x);
    int __skparam__y = __sklib__to_int(y);
    move_window_to(__skparam__name, __skparam__x, __skparam__y);
}
void __sklib__move_window_to__window__int__int(__sklib_window wind, int x, int y) {
    window __skparam__wind = __sklib__to_window(wind);
    int __skparam__x = __sklib__to_int(x);
    int __skparam__y = __sklib__to_int(y);
    move_window_to(__skparam__wind, __skparam__x, __skparam__y);
}
__sklib_window __sklib__open_window__string__int__int(__sklib_string caption, int width, int height) {
    string __skparam__caption = __sklib__to_string(caption);
    int __skparam__width = __sklib__to_int(width);
    int __skparam__height = __sklib__to_int(height);
    window __skreturn = open_window(__skparam__caption, __skparam__width, __skparam__height);
    return __sklib__to_sklib_window(__skreturn);
}
void __sklib__refresh_window__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    refresh_window(__skparam__wind);
}
void __sklib__refresh_window__window__unsigned_int(__sklib_window wind, unsigned int target_fps) {
    window __skparam__wind = __sklib__to_window(wind);
    unsigned int __skparam__target_fps = __sklib__to_unsigned_int(target_fps);
    refresh_window(__skparam__wind, __skparam__target_fps);
}
void __sklib__resize_current_window__int__int(int width, int height) {
    int __skparam__width = __sklib__to_int(width);
    int __skparam__height = __sklib__to_int(height);
    resize_current_window(__skparam__width, __skparam__height);
}
void __sklib__resize_window__window__int__int(__sklib_window wnd, int width, int height) {
    window __skparam__wnd = __sklib__to_window(wnd);
    int __skparam__width = __sklib__to_int(width);
    int __skparam__height = __sklib__to_int(height);
    resize_window(__skparam__wnd, __skparam__width, __skparam__height);
}
void __sklib__set_current_window__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    set_current_window(__skparam__name);
}
void __sklib__set_current_window__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    set_current_window(__skparam__wind);
}
__sklib_string __sklib__window_caption__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    string __skreturn = window_caption(__skparam__wind);
    return __sklib__to_sklib_string(__skreturn);
}
int __sklib__window_close_requested__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = window_close_requested(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_close_requested__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    bool __skreturn = window_close_requested(__skparam__wind);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_has_border__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = window_has_border(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_has_border__window(__sklib_window wnd) {
    window __skparam__wnd = __sklib__to_window(wnd);
    bool __skreturn = window_has_border(__skparam__wnd);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_has_focus__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    bool __skreturn = window_has_focus(__skparam__wind);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_height__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = window_height(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_height__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    int __skreturn = window_height(__skparam__wind);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_is_fullscreen__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    bool __skreturn = window_is_fullscreen(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_is_fullscreen__window(__sklib_window wnd) {
    window __skparam__wnd = __sklib__to_window(wnd);
    bool __skreturn = window_is_fullscreen(__skparam__wnd);
    return __sklib__to_int(__skreturn);
}
__sklib_window __sklib__window_named__string(__sklib_string caption) {
    string __skparam__caption = __sklib__to_string(caption);
    window __skreturn = window_named(__skparam__caption);
    return __sklib__to_sklib_window(__skreturn);
}
__sklib_point_2d __sklib__window_position__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    point_2d __skreturn = window_position(__skparam__name);
    return __sklib__to_sklib_point_2d(__skreturn);
}
__sklib_point_2d __sklib__window_position__window(__sklib_window wnd) {
    window __skparam__wnd = __sklib__to_window(wnd);
    point_2d __skreturn = window_position(__skparam__wnd);
    return __sklib__to_sklib_point_2d(__skreturn);
}
void __sklib__window_set_icon__window__bitmap(__sklib_window wind, __sklib_bitmap bmp) {
    window __skparam__wind = __sklib__to_window(wind);
    bitmap __skparam__bmp = __sklib__to_bitmap(bmp);
    window_set_icon(__skparam__wind, __skparam__bmp);
}
void __sklib__window_toggle_border__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    window_toggle_border(__skparam__name);
}
void __sklib__window_toggle_border__window(__sklib_window wnd) {
    window __skparam__wnd = __sklib__to_window(wnd);
    window_toggle_border(__skparam__wnd);
}
void __sklib__window_toggle_fullscreen__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    window_toggle_fullscreen(__skparam__name);
}
void __sklib__window_toggle_fullscreen__window(__sklib_window wnd) {
    window __skparam__wnd = __sklib__to_window(wnd);
    window_toggle_fullscreen(__skparam__wnd);
}
int __sklib__window_width__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = window_width(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_width__window(__sklib_window wind) {
    window __skparam__wind = __sklib__to_window(wind);
    int __skreturn = window_width(__skparam__wind);
    return __sklib__to_int(__skreturn);
}
__sklib_window __sklib__window_with_focus() {
    window __skreturn = window_with_focus();
    return __sklib__to_sklib_window(__skreturn);
}
int __sklib__window_x__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = window_x(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_x__window(__sklib_window wnd) {
    window __skparam__wnd = __sklib__to_window(wnd);
    int __skreturn = window_x(__skparam__wnd);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_y__string_ref(const __sklib_string name) {
    string __skparam__name = __sklib__to_string(name);
    int __skreturn = window_y(__skparam__name);
    return __sklib__to_int(__skreturn);
}
int __sklib__window_y__window(__sklib_window wnd) {
    window __skparam__wnd = __sklib__to_window(wnd);
    int __skreturn = window_y(__skparam__wnd);
    return __sklib__to_int(__skreturn);
}
