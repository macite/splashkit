from ctypes import *
from enum import Enum
from platform import system
import os

search_paths = []

if system() == 'Darwin':
    # macOS uses .dylib extension
    search_paths = ["/usr/local/lib/libSplashKit.dylib", os.path.expanduser("~") + "/.splashkit/lib/macos/libSplashKit.dylib"]
elif system() == 'Linux':
    # Linux uses .so extension
    search_paths = ["/usr/local/lib/libSplashKit.so", os.path.expanduser("~") + "/.splashkit/lib/linux/libSplashKit.so"]
else:
    # Windows uses .dll extension
    search_paths = ["C:/msys64/mingw64/lib/SplashKit.dll", "C:/msys64/home/" + os.getlogin() + "/.splashkit/lib/win64/SplashKit.dll"]

# find path to use -> format above is: ["global/path", ".splashkit/path"]
for path in search_paths:
    if (os.path.isfile(path)):
        # load the library
        cdll.LoadLibrary(path)
        sklib = CDLL(path)
        break

class _sklib_string(Structure):
    _fields_ = [
      ( "str",  c_char_p),
      ( "size", c_int ),
      ( "ptr", c_void_p ),
    ]

    def __init__(self, s):
        self.size = len(s)
        bytes = str.encode(s)
        self.str = c_char_p(bytes)
        self.ptr = None
class KeyCode(Enum):
    unknown_key = 0
    backspace_key = 8
    tab_key = 9
    clear_key = 12
    return_key = 13
    pause_key = 19
    escape_key = 27
    space_key = 32
    exclaim_key = 33
    double_quote_key = 34
    hash_key = 35
    dollar_key = 36
    ampersand_key = 38
    quote_key = 39
    left_paren_key = 40
    right_paren_key = 41
    asterisk_key = 42
    plus_key = 43
    comma_key = 44
    minus_key = 45
    period_key = 46
    slash_key = 47
    num_0_key = 48
    num_1_key = 49
    num_2_key = 50
    num_3_key = 51
    num_4_key = 52
    num_5_key = 53
    num_6_key = 54
    num_7_key = 55
    num_8_key = 56
    num_9_key = 57
    colon_key = 58
    semi_colon_key = 59
    less_key = 60
    equals_key = 61
    greater_key = 62
    question_key = 63
    at_key = 64
    left_bracket_key = 91
    backslash_key = 92
    right_bracket_key = 93
    caret_key = 94
    underscore_key = 95
    backquote_key = 96
    a_key = 97
    b_key = 98
    c_key = 99
    d_key = 100
    e_key = 101
    f_key = 102
    g_key = 103
    h_key = 104
    i_key = 105
    j_key = 106
    k_key = 107
    l_key = 108
    m_key = 109
    n_key = 110
    o_key = 111
    p_key = 112
    q_key = 113
    r_key = 114
    s_key = 115
    t_key = 116
    u_key = 117
    v_key = 118
    w_key = 119
    x_key = 120
    y_key = 121
    z_key = 122
    delete_key = 127
    keypad_0 = 256
    keypad_1 = 257
    keypad_2 = 258
    keypad_3 = 259
    keypad_4 = 260
    keypad_5 = 261
    keypad_6 = 262
    keypad_7 = 263
    keypad_8 = 264
    keypad_9 = 265
    keypad_period = 266
    keypad_divide = 267
    keypad_multiply = 268
    keypad_minus = 269
    keypad_plus = 270
    keypad_enter = 271
    keypad_equals = 272
    up_key = 273
    down_key = 274
    right_key = 275
    left_key = 276
    insert_key = 277
    home_key = 278
    end_key = 279
    page_up_key = 280
    page_down_key = 281
    f1_key = 282
    f2_key = 283
    f3_key = 284
    f4_key = 285
    f5_key = 286
    f6_key = 287
    f7_key = 288
    f8_key = 289
    f9_key = 290
    f10_key = 291
    f11_key = 292
    f12_key = 293
    f13_key = 294
    f14_key = 295
    f15_key = 296
    num_lock_key = 300
    caps_lock_key = 301
    scroll_lock_key = 302
    right_shift_key = 303
    left_shift_key = 304
    right_ctrl_key = 305
    left_ctrl_key = 306
    right_alt_key = 307
    left_alt_key = 308
    left_super_key = 311
    right_super_key = 312
    mode_key = 313
    help_key = 315
    sys_req_key = 317
    menu_key = 319
    power_key = 320
class LogLevel(Enum):
    none = 0
    info = 1
    debug = 2
    warning = 3
    error = 4
    fatal = 5
class LogMode(Enum):
    log_none = 0
    log_console = 1
    log_file_only = 2
    log_console_and_file = 3
class MouseButton(Enum):
    no_button = 0
    left_button = 1
    middle_button = 2
    right_button = 3
    mouse_x1_button = 4
    mouse_x2_button = 5
class ConnectionType(Enum):
    tcp = 0
    udp = 1
    unknown = 2
class ResourceKind(Enum):
    animation_resource = 0
    bundle_resource = 1
    font_resource = 2
    image_resource = 3
    json_resource = 4
    music_resource = 5
    server_resource = 6
    sound_resource = 7
    timer_resource = 8
    other_resource = 9
class CollisionTestKind(Enum):
    pixel_collisions = 0
    aabb_collisions = 1
class SpriteEventKind(Enum):
    sprite_arrived_event = 0
    sprite_animation_ended_event = 1
    sprite_touched_event = 2
    sprite_clicked_event = 3
class DrawingDest(Enum):
    draw_to_screen = 0
    draw_to_world = 1
    draw_default = 2
class FontStyle(Enum):
    normal_font = 0
    bold_font = 1
    italic_font = 2
    underline_font = 4
class HttpStatusCode(Enum):
    http_status_ok = 200
    http_status_created = 201
    http_status_no_content = 204
    http_status_moved_permanently = 301
    http_status_found = 302
    http_status_see_other = 303
    http_status_bad_request = 400
    http_status_unauthorized = 401
    http_status_forbidden = 403
    http_status_not_found = 404
    http_status_method_not_allowed = 405
    http_status_request_timeout = 408
    http_status_conflict = 409
    http_status_internal_server_error = 500
    http_status_not_implemented = 501
    http_status_service_unavailable = 503
class InterfaceStyle(Enum):
    flat_dark_style = 0
    shaded_dark_style = 1
    flat_light_style = 2
    shaded_light_style = 3
    bubble = 4
    bubble_multicolored = 5
class PinModes(Enum):
    gpio_input = 0
    gpio_output = 1
    gpio_alt0 = 4
    gpio_alt1 = 5
    gpio_alt2 = 6
    gpio_alt3 = 7
    gpio_alt4 = 3
    gpio_alt5 = 2
    gpio_default_mode = 1
class PinValues(Enum):
    gpio_low = 0
    gpio_high = 1
    gpio_default_value = 1
class Pins(Enum):
    pin_1 = 1
    pin_2 = 2
    pin_3 = 3
    pin_4 = 4
    pin_5 = 5
    pin_6 = 6
    pin_7 = 7
    pin_8 = 8
    pin_9 = 9
    pin_10 = 10
    pin_11 = 11
    pin_12 = 12
    pin_13 = 13
    pin_14 = 14
    pin_15 = 15
    pin_16 = 16
    pin_17 = 17
    pin_18 = 18
    pin_19 = 19
    pin_20 = 20
    pin_21 = 21
    pin_22 = 22
    pin_23 = 23
    pin_24 = 24
    pin_25 = 25
    pin_26 = 26
    pin_27 = 27
    pin_28 = 28
    pin_29 = 29
    pin_30 = 30
    pin_31 = 31
    pin_32 = 32
    pin_33 = 33
    pin_34 = 34
    pin_35 = 35
    pin_36 = 36
    pin_37 = 37
    pin_38 = 38
    pin_39 = 39
    pin_40 = 40
class PullUpDown(Enum):
    pud_off = 0
    pud_down = 1
    pud_up = 2
class HttpMethod(Enum):
    http_get_method = 0
    http_post_method = 1
    http_put_method = 2
    http_delete_method = 3
    http_options_method = 4
    http_trace_method = 5
    unknown_http_method = 6

class _FieldIndexer:
    def __init__(self, obj, field, dim1, dim2):
        self.obj = obj
        self.field = field
        self.dim1 = dim1
        self.dim2 = dim2

    def __getitem__(self, index):
        if ( isinstance(index, tuple)  ):
            return getattr(self.obj, self.field)[index[0] * self.dim2 + index[1]]
        else:
            return getattr(self.obj, self.field)[index]

    def __setitem__(self, index, value):
        if ( isinstance(index, tuple)  ):
            getattr(self.obj, self.field)[index[0] * self.dim2 + index[1]] = value
        else:
            getattr(self.obj, self.field)[index] = value


class _sklib_matrix_2d(Structure):
    _fields_ = [
        ("_elements", c_double * 9),
    ]

    def __init__(self):
      self.elements = _FieldIndexer(self, "_elements", 3, 3)
      super().__init__()

Matrix2D = _sklib_matrix_2d
class _sklib_point_2d(Structure):
    _fields_ = [
        ("x", c_double),
        ("y", c_double),
    ]

    def __init__(self):
      super().__init__()

Point2D = _sklib_point_2d
class _sklib_circle(Structure):
    _fields_ = [
        ("center", _sklib_point_2d),
        ("radius", c_double),
    ]

    def __init__(self):
      super().__init__()

Circle = _sklib_circle
class _sklib_color(Structure):
    _fields_ = [
        ("r", c_float),
        ("g", c_float),
        ("b", c_float),
        ("a", c_float),
    ]

    def __init__(self):
      super().__init__()

Color = _sklib_color
class _sklib_rectangle(Structure):
    _fields_ = [
        ("x", c_double),
        ("y", c_double),
        ("width", c_double),
        ("height", c_double),
    ]

    def __init__(self):
      super().__init__()

Rectangle = _sklib_rectangle
class _sklib_drawing_options(Structure):
    _fields_ = [
        ("dest", c_void_p),
        ("scale_x", c_float),
        ("scale_y", c_float),
        ("angle", c_float),
        ("anchor_offset_x", c_float),
        ("anchor_offset_y", c_float),
        ("flip_x", c_bool),
        ("flip_y", c_bool),
        ("is_part", c_bool),
        ("part", _sklib_rectangle),
        ("draw_cell", c_int),
        ("_camera", c_int),
        ("line_width", c_int),
        ("anim", c_void_p),
    ]

    def __init__(self):
      super().__init__()

    @property
    def camera(self):
        return DrawingDest(self._camera)

    @camera.setter
    def camera(self, value):
        if isinstance(value, DrawingDest):
            self._camera = value.value
        else:
            self._camera = value

DrawingOptions = _sklib_drawing_options
class _sklib_line(Structure):
    _fields_ = [
        ("start_point", _sklib_point_2d),
        ("end_point", _sklib_point_2d),
    ]

    def __init__(self):
      super().__init__()

Line = _sklib_line
class _sklib_quad(Structure):
    _fields_ = [
        ("_points", _sklib_point_2d * 4),
    ]

    def __init__(self):
      self.points = _FieldIndexer(self, "_points", 4, 0)
      super().__init__()

Quad = _sklib_quad
class _sklib_triangle(Structure):
    _fields_ = [
        ("_points", _sklib_point_2d * 3),
    ]

    def __init__(self):
      self.points = _FieldIndexer(self, "_points", 3, 0)
      super().__init__()

Triangle = _sklib_triangle
class _sklib_vector_2d(Structure):
    _fields_ = [
        ("x", c_double),
        ("y", c_double),
    ]

    def __init__(self):
      super().__init__()

Vector2D = _sklib_vector_2d
KeyCallback = CFUNCTYPE(None, c_int)
FreeNotifier = CFUNCTYPE(None, c_void_p)
SpriteEventHandler = CFUNCTYPE(None, c_void_p, c_int)
SpriteFloatFunction = CFUNCTYPE(None, c_void_p, c_float)
SpriteFunction = CFUNCTYPE(None, c_void_p)
class _PointerWrapper:
    def __init__(self, ptr):
        self._as_parameter_ = ptr

class Json(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class Music(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class Connection(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class Message(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class ServerSocket(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class SoundEffect(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class Sprite(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class Timer(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class Animation(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class AnimationScript(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class Bitmap(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class Display(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class Font(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class HttpResponse(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class HttpRequest(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class WebServer(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)
class Window(_PointerWrapper):
    def __init__(self, ptr):
        super().__init__(ptr)

def __skadapter__to_sklib_bool(v):
    if isinstance(v, c_bool):
        return v

    if v:
        return -1
    else:
        return 0

def __skadapter__to_bool(v):
    if isinstance(v, c_bool):
        return v
    return v != 0;
def __skadapter__to_sklib_char(v):
    if isinstance(v, str):
        return c_char(str.encode(v)[0])
    if isinstance(v, c_char):
        return v
    return c_char(v);

def __skadapter__to_char(v):
    if isinstance(v, bytes):
        return bytes.decode(v)
    return v

def __skadapter__to_sklib_unsigned_char(v):
    if isinstance(v, c_ubyte):
        return v
    if isinstance(v, str):
        return c_ubyte(ord(v[0]))
    return c_ubyte(ord(v));

def __skadapter__to_unsigned_char(v):
    if isinstance(v, c_ubyte):
        return v
    return chr(v)
def __skadapter__to_sklib_int(v):
    if isinstance(v, c_int):
        return v
    return c_int(v);

def __skadapter__to_int(v):
    return v

def __skadapter__to_sklib_short(v):
    if isinstance(v, c_short):
        return v
    return c_short(v);

def __skadapter__to_short(v):
    return v

def __skadapter__to_sklib_int64_t(v):
    if isinstance(v, c_int64):
        return v
    return c_int64(v);

def __skadapter__to_int64_t(v):
    return v

def __skadapter__to_sklib_float(v):
    if isinstance(v, c_float):
        return v
    return c_float(v);

def __skadapter__to_float(v):
    return v

def __skadapter__to_sklib_double(v):
    if isinstance(v, c_double):
        return v
    return c_double(v);

def __skadapter__to_double(v):
    return v

def __skadapter__to_sklib_int8_t(v):
    if isinstance(v, c_byte):
        return v
    return c_byte(v);

def __skadapter__to_int8_t(v):
    return v

def __skadapter__to_sklib_byte(v):
    if isinstance(v, c_byte):
        return v
    return c_byte(v);

def __skadapter__to_byte(v):
    return v

def __skadapter__to_sklib_unsigned_int(v):
    if isinstance(v, c_uint):
        return v
    return c_uint(v);

def __skadapter__to_unsigned_int(v):
    return v

def __skadapter__to_sklib_unsigned_short(v):
    if isinstance(v, c_ushort):
        return v
    return c_ushort(v);

def __skadapter__to_unsigned_short(v):
    return v

def __skadapter__to_key_code(v):
    if isinstance(v, KeyCode):
        return v
    return KeyCode(v)

def __skadapter__to_sklib_key_code(v):
    return c_int(v.value)

def __skadapter__to_log_level(v):
    if isinstance(v, LogLevel):
        return v
    return LogLevel(v)

def __skadapter__to_sklib_log_level(v):
    return c_int(v.value)

def __skadapter__to_log_mode(v):
    if isinstance(v, LogMode):
        return v
    return LogMode(v)

def __skadapter__to_sklib_log_mode(v):
    return c_int(v.value)

def __skadapter__to_mouse_button(v):
    if isinstance(v, MouseButton):
        return v
    return MouseButton(v)

def __skadapter__to_sklib_mouse_button(v):
    return c_int(v.value)

def __skadapter__to_connection_type(v):
    if isinstance(v, ConnectionType):
        return v
    return ConnectionType(v)

def __skadapter__to_sklib_connection_type(v):
    return c_int(v.value)

def __skadapter__to_resource_kind(v):
    if isinstance(v, ResourceKind):
        return v
    return ResourceKind(v)

def __skadapter__to_sklib_resource_kind(v):
    return c_int(v.value)

def __skadapter__to_collision_test_kind(v):
    if isinstance(v, CollisionTestKind):
        return v
    return CollisionTestKind(v)

def __skadapter__to_sklib_collision_test_kind(v):
    return c_int(v.value)

def __skadapter__to_sprite_event_kind(v):
    if isinstance(v, SpriteEventKind):
        return v
    return SpriteEventKind(v)

def __skadapter__to_sklib_sprite_event_kind(v):
    return c_int(v.value)

def __skadapter__to_drawing_dest(v):
    if isinstance(v, DrawingDest):
        return v
    return DrawingDest(v)

def __skadapter__to_sklib_drawing_dest(v):
    return c_int(v.value)

def __skadapter__to_font_style(v):
    if isinstance(v, FontStyle):
        return v
    return FontStyle(v)

def __skadapter__to_sklib_font_style(v):
    return c_int(v.value)

def __skadapter__to_http_status_code(v):
    if isinstance(v, HttpStatusCode):
        return v
    return HttpStatusCode(v)

def __skadapter__to_sklib_http_status_code(v):
    return c_int(v.value)

def __skadapter__to_interface_style(v):
    if isinstance(v, InterfaceStyle):
        return v
    return InterfaceStyle(v)

def __skadapter__to_sklib_interface_style(v):
    return c_int(v.value)

def __skadapter__to_pin_modes(v):
    if isinstance(v, PinModes):
        return v
    return PinModes(v)

def __skadapter__to_sklib_pin_modes(v):
    return c_int(v.value)

def __skadapter__to_pin_values(v):
    if isinstance(v, PinValues):
        return v
    return PinValues(v)

def __skadapter__to_sklib_pin_values(v):
    return c_int(v.value)

def __skadapter__to_pins(v):
    if isinstance(v, Pins):
        return v
    return Pins(v)

def __skadapter__to_sklib_pins(v):
    return c_int(v.value)

def __skadapter__to_pull_up_down(v):
    if isinstance(v, PullUpDown):
        return v
    return PullUpDown(v)

def __skadapter__to_sklib_pull_up_down(v):
    return c_int(v.value)

def __skadapter__to_http_method(v):
    if isinstance(v, HttpMethod):
        return v
    return HttpMethod(v)

def __skadapter__to_sklib_http_method(v):
    return c_int(v.value)

def __skadapter__to_sklib_matrix_2d(v):
    if isinstance(v, _sklib_matrix_2d):
        return v

    result = Matrix2D()
    result.elements[0] = __skadapter__to_sklib_double(v.elements[0][0])
    result.elements[1] = __skadapter__to_sklib_double(v.elements[0][1])
    result.elements[2] = __skadapter__to_sklib_double(v.elements[0][2])
    result.elements[3] = __skadapter__to_sklib_double(v.elements[1][0])
    result.elements[4] = __skadapter__to_sklib_double(v.elements[1][1])
    result.elements[5] = __skadapter__to_sklib_double(v.elements[1][2])
    result.elements[6] = __skadapter__to_sklib_double(v.elements[2][0])
    result.elements[7] = __skadapter__to_sklib_double(v.elements[2][1])
    result.elements[8] = __skadapter__to_sklib_double(v.elements[2][2])
    return result
def __skadapter__to_matrix_2d(v):
    if isinstance(v, Matrix2D):
        return v
    result = Matrix2D()
    result.elements[0][0] = __skadapter__to_double(v.elements[0]);
    result.elements[0][1] = __skadapter__to_double(v.elements[1]);
    result.elements[0][2] = __skadapter__to_double(v.elements[2]);
    result.elements[1][0] = __skadapter__to_double(v.elements[3]);
    result.elements[1][1] = __skadapter__to_double(v.elements[4]);
    result.elements[1][2] = __skadapter__to_double(v.elements[5]);
    result.elements[2][0] = __skadapter__to_double(v.elements[6]);
    result.elements[2][1] = __skadapter__to_double(v.elements[7]);
    result.elements[2][2] = __skadapter__to_double(v.elements[8]);
    return result
def __skadapter__to_sklib_point_2d(v):
    if isinstance(v, _sklib_point_2d):
        return v

    result = Point2D()
    result.x = __skadapter__to_sklib_double(v.x)
    result.y = __skadapter__to_sklib_double(v.y)
    return result
def __skadapter__to_point_2d(v):
    if isinstance(v, Point2D):
        return v
    result = Point2D()
    result.x = __skadapter__to_double(v.x)
    result.y = __skadapter__to_double(v.y)
    return result
def __skadapter__to_sklib_circle(v):
    if isinstance(v, _sklib_circle):
        return v

    result = Circle()
    result.center = __skadapter__to_sklib_point_2d(v.center)
    result.radius = __skadapter__to_sklib_double(v.radius)
    return result
def __skadapter__to_circle(v):
    if isinstance(v, Circle):
        return v
    result = Circle()
    result.center = __skadapter__to_point_2d(v.center)
    result.radius = __skadapter__to_double(v.radius)
    return result
def __skadapter__to_sklib_color(v):
    if isinstance(v, _sklib_color):
        return v

    result = Color()
    result.r = __skadapter__to_sklib_float(v.r)
    result.g = __skadapter__to_sklib_float(v.g)
    result.b = __skadapter__to_sklib_float(v.b)
    result.a = __skadapter__to_sklib_float(v.a)
    return result
def __skadapter__to_color(v):
    if isinstance(v, Color):
        return v
    result = Color()
    result.r = __skadapter__to_float(v.r)
    result.g = __skadapter__to_float(v.g)
    result.b = __skadapter__to_float(v.b)
    result.a = __skadapter__to_float(v.a)
    return result
def __skadapter__to_sklib_rectangle(v):
    if isinstance(v, _sklib_rectangle):
        return v

    result = Rectangle()
    result.x = __skadapter__to_sklib_double(v.x)
    result.y = __skadapter__to_sklib_double(v.y)
    result.width = __skadapter__to_sklib_double(v.width)
    result.height = __skadapter__to_sklib_double(v.height)
    return result
def __skadapter__to_rectangle(v):
    if isinstance(v, Rectangle):
        return v
    result = Rectangle()
    result.x = __skadapter__to_double(v.x)
    result.y = __skadapter__to_double(v.y)
    result.width = __skadapter__to_double(v.width)
    result.height = __skadapter__to_double(v.height)
    return result
def __skadapter__to_sklib_drawing_options(v):
    if isinstance(v, _sklib_drawing_options):
        return v

    result = DrawingOptions()
    result.dest = __skadapter__to_sklib_ptr(v.dest)
    result.scale_x = __skadapter__to_sklib_float(v.scale_x)
    result.scale_y = __skadapter__to_sklib_float(v.scale_y)
    result.angle = __skadapter__to_sklib_float(v.angle)
    result.anchor_offset_x = __skadapter__to_sklib_float(v.anchor_offset_x)
    result.anchor_offset_y = __skadapter__to_sklib_float(v.anchor_offset_y)
    result.flip_x = __skadapter__to_sklib_bool(v.flip_x)
    result.flip_y = __skadapter__to_sklib_bool(v.flip_y)
    result.is_part = __skadapter__to_sklib_bool(v.is_part)
    result.part = __skadapter__to_sklib_rectangle(v.part)
    result.draw_cell = __skadapter__to_sklib_int(v.draw_cell)
    result.camera = __skadapter__to_sklib_drawing_dest(v.camera)
    result.line_width = __skadapter__to_sklib_int(v.line_width)
    result.anim = __skadapter__to_sklib_animation(v.anim)
    return result
def __skadapter__to_drawing_options(v):
    if isinstance(v, DrawingOptions):
        return v
    result = DrawingOptions()
    result.dest = __skadapter__to_ptr(v.dest)
    result.scale_x = __skadapter__to_float(v.scale_x)
    result.scale_y = __skadapter__to_float(v.scale_y)
    result.angle = __skadapter__to_float(v.angle)
    result.anchor_offset_x = __skadapter__to_float(v.anchor_offset_x)
    result.anchor_offset_y = __skadapter__to_float(v.anchor_offset_y)
    result.flip_x = __skadapter__to_bool(v.flip_x)
    result.flip_y = __skadapter__to_bool(v.flip_y)
    result.is_part = __skadapter__to_bool(v.is_part)
    result.part = __skadapter__to_rectangle(v.part)
    result.draw_cell = __skadapter__to_int(v.draw_cell)
    result.camera = __skadapter__to_drawing_dest(v.camera)
    result.line_width = __skadapter__to_int(v.line_width)
    result.anim = __skadapter__to_animation(v.anim)
    return result
def __skadapter__to_sklib_line(v):
    if isinstance(v, _sklib_line):
        return v

    result = Line()
    result.start_point = __skadapter__to_sklib_point_2d(v.start_point)
    result.end_point = __skadapter__to_sklib_point_2d(v.end_point)
    return result
def __skadapter__to_line(v):
    if isinstance(v, Line):
        return v
    result = Line()
    result.start_point = __skadapter__to_point_2d(v.start_point)
    result.end_point = __skadapter__to_point_2d(v.end_point)
    return result
def __skadapter__to_sklib_quad(v):
    if isinstance(v, _sklib_quad):
        return v

    result = Quad()
    result.points[0] = __skadapter__to_sklib_point_2d(v.points[0])
    result.points[1] = __skadapter__to_sklib_point_2d(v.points[1])
    result.points[2] = __skadapter__to_sklib_point_2d(v.points[2])
    result.points[3] = __skadapter__to_sklib_point_2d(v.points[3])
    return result
def __skadapter__to_quad(v):
    if isinstance(v, Quad):
        return v
    result = Quad()
    result.points[0] = __skadapter__to_point_2d(v.points[0]);
    result.points[1] = __skadapter__to_point_2d(v.points[1]);
    result.points[2] = __skadapter__to_point_2d(v.points[2]);
    result.points[3] = __skadapter__to_point_2d(v.points[3]);
    return result
def __skadapter__to_sklib_triangle(v):
    if isinstance(v, _sklib_triangle):
        return v

    result = Triangle()
    result.points[0] = __skadapter__to_sklib_point_2d(v.points[0])
    result.points[1] = __skadapter__to_sklib_point_2d(v.points[1])
    result.points[2] = __skadapter__to_sklib_point_2d(v.points[2])
    return result
def __skadapter__to_triangle(v):
    if isinstance(v, Triangle):
        return v
    result = Triangle()
    result.points[0] = __skadapter__to_point_2d(v.points[0]);
    result.points[1] = __skadapter__to_point_2d(v.points[1]);
    result.points[2] = __skadapter__to_point_2d(v.points[2]);
    return result
def __skadapter__to_sklib_vector_2d(v):
    if isinstance(v, _sklib_vector_2d):
        return v

    result = Vector2D()
    result.x = __skadapter__to_sklib_double(v.x)
    result.y = __skadapter__to_sklib_double(v.y)
    return result
def __skadapter__to_vector_2d(v):
    if isinstance(v, Vector2D):
        return v
    result = Vector2D()
    result.x = __skadapter__to_double(v.x)
    result.y = __skadapter__to_double(v.y)
    return result
class _sklib_vector_string(Structure):
    _fields_ = [
      ("data_from_app", POINTER(_sklib_string)),
      ("size_from_app", c_uint),
      ("data_from_lib", POINTER(_sklib_string)),
      ("size_from_lib", c_uint),
    ]

    def __init__(self, num):
        elems = (_sklib_string * num)()
        self.data_from_app = cast(elems, POINTER(_sklib_string))
        self.size_from_app = num
        self.data_from_lib = None
        self.size_from_lib = 0

sklib.__sklib__free__sklib_vector_string.argtypes = [ _sklib_vector_string ]
sklib.__sklib__free__sklib_vector_string.restype = None
def __skadapter__free__sklib_vector_string(v):
    for i in range(0, v.size_from_app):
        __skadapter__free__sklib_string(v.data_from_app[i])
    v.data_from_app = None

def __skadapter__to_sklib_vector_string(v):
    result = _sklib_vector_string(len(v))
    for i in range(0, len(v)):
        result.data_from_app[i] = __skadapter__to_sklib_string(v[i])
    return result

def __skadapter__to_vector_string(v):
    result = []
    for i in range(0, v.size_from_lib):
        result.append ( __skadapter__to_string(v.data_from_lib[i]) )
    sklib.__sklib__free__sklib_vector_string(v)
    return result
def __skadapter__update_from_vector_string(v, __skreturn):
    del __skreturn[:]
    for i in range(0, v.size_from_lib):
        __skreturn.append( __skadapter__to_string(v.data_from_lib[i]) )

    sklib.__sklib__free__sklib_vector_string(v)
class _sklib_vector_line(Structure):
    _fields_ = [
      ("data_from_app", POINTER(_sklib_line)),
      ("size_from_app", c_uint),
      ("data_from_lib", POINTER(_sklib_line)),
      ("size_from_lib", c_uint),
    ]

    def __init__(self, num):
        elems = (_sklib_line * num)()
        self.data_from_app = cast(elems, POINTER(_sklib_line))
        self.size_from_app = num
        self.data_from_lib = None
        self.size_from_lib = 0

sklib.__sklib__free__sklib_vector_line.argtypes = [ _sklib_vector_line ]
sklib.__sklib__free__sklib_vector_line.restype = None
def __skadapter__free__sklib_vector_line(v):
    v.data_from_app = None

def __skadapter__to_sklib_vector_line(v):
    result = _sklib_vector_line(len(v))
    for i in range(0, len(v)):
        result.data_from_app[i] = __skadapter__to_sklib_line(v[i])
    return result

def __skadapter__to_vector_line(v):
    result = []
    for i in range(0, v.size_from_lib):
        result.append ( __skadapter__to_line(v.data_from_lib[i]) )
    sklib.__sklib__free__sklib_vector_line(v)
    return result
def __skadapter__update_from_vector_line(v, __skreturn):
    del __skreturn[:]
    for i in range(0, v.size_from_lib):
        __skreturn.append( __skadapter__to_line(v.data_from_lib[i]) )

    sklib.__sklib__free__sklib_vector_line(v)
class _sklib_vector_int8_t(Structure):
    _fields_ = [
      ("data_from_app", POINTER(c_byte)),
      ("size_from_app", c_uint),
      ("data_from_lib", POINTER(c_byte)),
      ("size_from_lib", c_uint),
    ]

    def __init__(self, num):
        elems = (c_byte * num)()
        self.data_from_app = cast(elems, POINTER(c_byte))
        self.size_from_app = num
        self.data_from_lib = None
        self.size_from_lib = 0

sklib.__sklib__free__sklib_vector_int8_t.argtypes = [ _sklib_vector_int8_t ]
sklib.__sklib__free__sklib_vector_int8_t.restype = None
def __skadapter__free__sklib_vector_int8_t(v):
    v.data_from_app = None

def __skadapter__to_sklib_vector_int8_t(v):
    result = _sklib_vector_int8_t(len(v))
    for i in range(0, len(v)):
        result.data_from_app[i] = __skadapter__to_sklib_int8_t(v[i])
    return result

def __skadapter__to_vector_int8_t(v):
    result = []
    for i in range(0, v.size_from_lib):
        result.append ( __skadapter__to_int8_t(v.data_from_lib[i]) )
    sklib.__sklib__free__sklib_vector_int8_t(v)
    return result
def __skadapter__update_from_vector_int8_t(v, __skreturn):
    del __skreturn[:]
    for i in range(0, v.size_from_lib):
        __skreturn.append( __skadapter__to_int8_t(v.data_from_lib[i]) )

    sklib.__sklib__free__sklib_vector_int8_t(v)
class _sklib_vector_triangle(Structure):
    _fields_ = [
      ("data_from_app", POINTER(_sklib_triangle)),
      ("size_from_app", c_uint),
      ("data_from_lib", POINTER(_sklib_triangle)),
      ("size_from_lib", c_uint),
    ]

    def __init__(self, num):
        elems = (_sklib_triangle * num)()
        self.data_from_app = cast(elems, POINTER(_sklib_triangle))
        self.size_from_app = num
        self.data_from_lib = None
        self.size_from_lib = 0

sklib.__sklib__free__sklib_vector_triangle.argtypes = [ _sklib_vector_triangle ]
sklib.__sklib__free__sklib_vector_triangle.restype = None
def __skadapter__free__sklib_vector_triangle(v):
    v.data_from_app = None

def __skadapter__to_sklib_vector_triangle(v):
    result = _sklib_vector_triangle(len(v))
    for i in range(0, len(v)):
        result.data_from_app[i] = __skadapter__to_sklib_triangle(v[i])
    return result

def __skadapter__to_vector_triangle(v):
    result = []
    for i in range(0, v.size_from_lib):
        result.append ( __skadapter__to_triangle(v.data_from_lib[i]) )
    sklib.__sklib__free__sklib_vector_triangle(v)
    return result
def __skadapter__update_from_vector_triangle(v, __skreturn):
    del __skreturn[:]
    for i in range(0, v.size_from_lib):
        __skreturn.append( __skadapter__to_triangle(v.data_from_lib[i]) )

    sklib.__sklib__free__sklib_vector_triangle(v)
class _sklib_vector_double(Structure):
    _fields_ = [
      ("data_from_app", POINTER(c_double)),
      ("size_from_app", c_uint),
      ("data_from_lib", POINTER(c_double)),
      ("size_from_lib", c_uint),
    ]

    def __init__(self, num):
        elems = (c_double * num)()
        self.data_from_app = cast(elems, POINTER(c_double))
        self.size_from_app = num
        self.data_from_lib = None
        self.size_from_lib = 0

sklib.__sklib__free__sklib_vector_double.argtypes = [ _sklib_vector_double ]
sklib.__sklib__free__sklib_vector_double.restype = None
def __skadapter__free__sklib_vector_double(v):
    v.data_from_app = None

def __skadapter__to_sklib_vector_double(v):
    result = _sklib_vector_double(len(v))
    for i in range(0, len(v)):
        result.data_from_app[i] = __skadapter__to_sklib_double(v[i])
    return result

def __skadapter__to_vector_double(v):
    result = []
    for i in range(0, v.size_from_lib):
        result.append ( __skadapter__to_double(v.data_from_lib[i]) )
    sklib.__sklib__free__sklib_vector_double(v)
    return result
def __skadapter__update_from_vector_double(v, __skreturn):
    del __skreturn[:]
    for i in range(0, v.size_from_lib):
        __skreturn.append( __skadapter__to_double(v.data_from_lib[i]) )

    sklib.__sklib__free__sklib_vector_double(v)
class _sklib_vector_json(Structure):
    _fields_ = [
      ("data_from_app", POINTER(c_void_p)),
      ("size_from_app", c_uint),
      ("data_from_lib", POINTER(c_void_p)),
      ("size_from_lib", c_uint),
    ]

    def __init__(self, num):
        elems = (c_void_p * num)()
        self.data_from_app = cast(elems, POINTER(c_void_p))
        self.size_from_app = num
        self.data_from_lib = None
        self.size_from_lib = 0

sklib.__sklib__free__sklib_vector_json.argtypes = [ _sklib_vector_json ]
sklib.__sklib__free__sklib_vector_json.restype = None
def __skadapter__free__sklib_vector_json(v):
    v.data_from_app = None

def __skadapter__to_sklib_vector_json(v):
    result = _sklib_vector_json(len(v))
    for i in range(0, len(v)):
        result.data_from_app[i] = __skadapter__to_sklib_json(v[i])
    return result

def __skadapter__to_vector_json(v):
    result = []
    for i in range(0, v.size_from_lib):
        result.append ( __skadapter__to_json(v.data_from_lib[i]) )
    sklib.__sklib__free__sklib_vector_json(v)
    return result
def __skadapter__update_from_vector_json(v, __skreturn):
    del __skreturn[:]
    for i in range(0, v.size_from_lib):
        __skreturn.append( __skadapter__to_json(v.data_from_lib[i]) )

    sklib.__sklib__free__sklib_vector_json(v)
class _sklib_vector_bool(Structure):
    _fields_ = [
      ("data_from_app", POINTER(c_bool)),
      ("size_from_app", c_uint),
      ("data_from_lib", POINTER(c_bool)),
      ("size_from_lib", c_uint),
    ]

    def __init__(self, num):
        elems = (c_bool * num)()
        self.data_from_app = cast(elems, POINTER(c_bool))
        self.size_from_app = num
        self.data_from_lib = None
        self.size_from_lib = 0

sklib.__sklib__free__sklib_vector_bool.argtypes = [ _sklib_vector_bool ]
sklib.__sklib__free__sklib_vector_bool.restype = None
def __skadapter__free__sklib_vector_bool(v):
    v.data_from_app = None

def __skadapter__to_sklib_vector_bool(v):
    result = _sklib_vector_bool(len(v))
    for i in range(0, len(v)):
        result.data_from_app[i] = __skadapter__to_sklib_bool(v[i])
    return result

def __skadapter__to_vector_bool(v):
    result = []
    for i in range(0, v.size_from_lib):
        result.append ( __skadapter__to_bool(v.data_from_lib[i]) )
    sklib.__sklib__free__sklib_vector_bool(v)
    return result
def __skadapter__update_from_vector_bool(v, __skreturn):
    del __skreturn[:]
    for i in range(0, v.size_from_lib):
        __skreturn.append( __skadapter__to_bool(v.data_from_lib[i]) )

    sklib.__sklib__free__sklib_vector_bool(v)
def __skadapter__to_sklib_string(s):
    return _sklib_string(s.replace('\r',''))

sklib.__sklib__free__sklib_string.argtypes = [ _sklib_string ]
sklib.__sklib__free__sklib_string.restype = None

def __skadapter__free__sklib_string(s):
    pass

def __skadapter__to_string(s):
    result = bytes.decode(s.str)
    sklib.__sklib__free__sklib_string(s)
    return result
def __skadapter__to_sklib_key_callback(v):
    if isinstance(v, KeyCallback):
        return v
    return KeyCallback(v)

def __skadapter__to_sklib_free_notifier(v):
    if isinstance(v, FreeNotifier):
        return v
    return FreeNotifier(v)

def __skadapter__to_sklib_sprite_event_handler(v):
    if isinstance(v, SpriteEventHandler):
        return v
    return SpriteEventHandler(v)

def __skadapter__to_sklib_sprite_float_function(v):
    if isinstance(v, SpriteFloatFunction):
        return v
    return SpriteFloatFunction(v)

def __skadapter__to_sklib_sprite_function(v):
    if isinstance(v, SpriteFunction):
        return v
    return SpriteFunction(v)

_pointer_register = {}

def _find_pointer_resource(ptr, cls):
    if ptr in _pointer_register:
        return _pointer_register[ptr]
    else:
        module = __import__("splashkit")
        class_ = getattr(module, cls)
        instance = class_(ptr)
        _pointer_register[ptr] = instance
        return instance

def _free_pointer_resource(ptr):
    del _pointer_register[ptr]

def __skadapter__to_sklib_ptr(v):
    return v

def __skadapter__to_ptr(v):
    pass

def __skadapter__to_json(v):
    return _find_pointer_resource(v, "Json")

def __skadapter__to_sklib_json(v):
    return v

def __skadapter__to_music(v):
    return _find_pointer_resource(v, "Music")

def __skadapter__to_sklib_music(v):
    return v

def __skadapter__to_connection(v):
    return _find_pointer_resource(v, "Connection")

def __skadapter__to_sklib_connection(v):
    return v

def __skadapter__to_message(v):
    return _find_pointer_resource(v, "Message")

def __skadapter__to_sklib_message(v):
    return v

def __skadapter__to_server_socket(v):
    return _find_pointer_resource(v, "ServerSocket")

def __skadapter__to_sklib_server_socket(v):
    return v

def __skadapter__to_sound_effect(v):
    return _find_pointer_resource(v, "SoundEffect")

def __skadapter__to_sklib_sound_effect(v):
    return v

def __skadapter__to_sprite(v):
    return _find_pointer_resource(v, "Sprite")

def __skadapter__to_sklib_sprite(v):
    return v

def __skadapter__to_timer(v):
    return _find_pointer_resource(v, "Timer")

def __skadapter__to_sklib_timer(v):
    return v

def __skadapter__to_animation(v):
    return _find_pointer_resource(v, "Animation")

def __skadapter__to_sklib_animation(v):
    return v

def __skadapter__to_animation_script(v):
    return _find_pointer_resource(v, "AnimationScript")

def __skadapter__to_sklib_animation_script(v):
    return v

def __skadapter__to_bitmap(v):
    return _find_pointer_resource(v, "Bitmap")

def __skadapter__to_sklib_bitmap(v):
    return v

def __skadapter__to_display(v):
    return _find_pointer_resource(v, "Display")

def __skadapter__to_sklib_display(v):
    return v

def __skadapter__to_font(v):
    return _find_pointer_resource(v, "Font")

def __skadapter__to_sklib_font(v):
    return v

def __skadapter__to_http_response(v):
    return _find_pointer_resource(v, "HttpResponse")

def __skadapter__to_sklib_http_response(v):
    return v

def __skadapter__to_http_request(v):
    return _find_pointer_resource(v, "HttpRequest")

def __skadapter__to_sklib_http_request(v):
    return v

def __skadapter__to_web_server(v):
    return _find_pointer_resource(v, "WebServer")

def __skadapter__to_sklib_web_server(v):
    return v

def __skadapter__to_window(v):
    return _find_pointer_resource(v, "Window")

def __skadapter__to_sklib_window(v):
    return v


sklib.__sklib__animation_count__animation_script.argtypes = [ c_void_p ]
sklib.__sklib__animation_count__animation_script.restype = c_int
sklib.__sklib__animation_current_cell__animation.argtypes = [ c_void_p ]
sklib.__sklib__animation_current_cell__animation.restype = c_int
sklib.__sklib__animation_current_vector__animation.argtypes = [ c_void_p ]
sklib.__sklib__animation_current_vector__animation.restype = _sklib_vector_2d
sklib.__sklib__animation_ended__animation.argtypes = [ c_void_p ]
sklib.__sklib__animation_ended__animation.restype = c_bool
sklib.__sklib__animation_entered_frame__animation.argtypes = [ c_void_p ]
sklib.__sklib__animation_entered_frame__animation.restype = c_bool
sklib.__sklib__animation_frame_time__animation.argtypes = [ c_void_p ]
sklib.__sklib__animation_frame_time__animation.restype = c_float
sklib.__sklib__animation_index__animation_script__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__animation_index__animation_script__string_ref.restype = c_int
sklib.__sklib__animation_name__animation.argtypes = [ c_void_p ]
sklib.__sklib__animation_name__animation.restype = _sklib_string
sklib.__sklib__animation_script_name__animation_script.argtypes = [ c_void_p ]
sklib.__sklib__animation_script_name__animation_script.restype = _sklib_string
sklib.__sklib__animation_script_named__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__animation_script_named__string_ref.restype = c_void_p
sklib.__sklib__assign_animation__animation__animation_script__string_ref.argtypes = [ c_void_p, c_void_p, _sklib_string ]
sklib.__sklib__assign_animation__animation__animation_script__string_ref.restype = None
sklib.__sklib__assign_animation__animation__animation_script__string_ref__bool.argtypes = [ c_void_p, c_void_p, _sklib_string, c_bool ]
sklib.__sklib__assign_animation__animation__animation_script__string_ref__bool.restype = None
sklib.__sklib__assign_animation__animation__animation_script__int.argtypes = [ c_void_p, c_void_p, c_int ]
sklib.__sklib__assign_animation__animation__animation_script__int.restype = None
sklib.__sklib__assign_animation__animation__animation_script__int__bool.argtypes = [ c_void_p, c_void_p, c_int, c_bool ]
sklib.__sklib__assign_animation__animation__animation_script__int__bool.restype = None
sklib.__sklib__assign_animation__animation__string_ref__string_ref.argtypes = [ c_void_p, _sklib_string, _sklib_string ]
sklib.__sklib__assign_animation__animation__string_ref__string_ref.restype = None
sklib.__sklib__assign_animation__animation__string_ref__string_ref__bool.argtypes = [ c_void_p, _sklib_string, _sklib_string, c_bool ]
sklib.__sklib__assign_animation__animation__string_ref__string_ref__bool.restype = None
sklib.__sklib__assign_animation__animation__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__assign_animation__animation__int.restype = None
sklib.__sklib__assign_animation__animation__int__bool.argtypes = [ c_void_p, c_int, c_bool ]
sklib.__sklib__assign_animation__animation__int__bool.restype = None
sklib.__sklib__assign_animation__animation__string.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__assign_animation__animation__string.restype = None
sklib.__sklib__assign_animation__animation__string__bool.argtypes = [ c_void_p, _sklib_string, c_bool ]
sklib.__sklib__assign_animation__animation__string__bool.restype = None
sklib.__sklib__create_animation__animation_script__int__bool.argtypes = [ c_void_p, c_int, c_bool ]
sklib.__sklib__create_animation__animation_script__int__bool.restype = c_void_p
sklib.__sklib__create_animation__animation_script__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__create_animation__animation_script__string_ref.restype = c_void_p
sklib.__sklib__create_animation__animation_script__string_ref__bool.argtypes = [ c_void_p, _sklib_string, c_bool ]
sklib.__sklib__create_animation__animation_script__string_ref__bool.restype = c_void_p
sklib.__sklib__create_animation__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__create_animation__string_ref__string_ref.restype = c_void_p
sklib.__sklib__create_animation__string_ref__string_ref__bool.argtypes = [ _sklib_string, _sklib_string, c_bool ]
sklib.__sklib__create_animation__string_ref__string_ref__bool.restype = c_void_p
sklib.__sklib__free_all_animation_scripts.argtypes = [  ]
sklib.__sklib__free_all_animation_scripts.restype = None
sklib.__sklib__free_animation__animation.argtypes = [ c_void_p ]
sklib.__sklib__free_animation__animation.restype = None
sklib.__sklib__free_animation_script__animation_script.argtypes = [ c_void_p ]
sklib.__sklib__free_animation_script__animation_script.restype = None
sklib.__sklib__free_animation_script__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__free_animation_script__string_ref.restype = None
sklib.__sklib__has_animation_named__animation_script__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__has_animation_named__animation_script__string_ref.restype = c_bool
sklib.__sklib__has_animation_script__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__has_animation_script__string_ref.restype = c_bool
sklib.__sklib__load_animation_script__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__load_animation_script__string_ref__string_ref.restype = c_void_p
sklib.__sklib__restart_animation__animation.argtypes = [ c_void_p ]
sklib.__sklib__restart_animation__animation.restype = None
sklib.__sklib__restart_animation__animation__bool.argtypes = [ c_void_p, c_bool ]
sklib.__sklib__restart_animation__animation__bool.restype = None
sklib.__sklib__update_animation__animation__float__bool.argtypes = [ c_void_p, c_float, c_bool ]
sklib.__sklib__update_animation__animation__float__bool.restype = None
sklib.__sklib__update_animation__animation.argtypes = [ c_void_p ]
sklib.__sklib__update_animation__animation.restype = None
sklib.__sklib__update_animation__animation__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__update_animation__animation__float.restype = None
sklib.__sklib__audio_ready.argtypes = [  ]
sklib.__sklib__audio_ready.restype = c_bool
sklib.__sklib__close_audio.argtypes = [  ]
sklib.__sklib__close_audio.restype = None
sklib.__sklib__open_audio.argtypes = [  ]
sklib.__sklib__open_audio.restype = None
sklib.__sklib__contains__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__contains__string_ref__string_ref.restype = c_bool
sklib.__sklib__convert_to_double__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__convert_to_double__string_ref.restype = c_double
sklib.__sklib__convert_to_integer__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__convert_to_integer__string_ref.restype = c_int
sklib.__sklib__index_of__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__index_of__string_ref__string_ref.restype = c_int
sklib.__sklib__is_double__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__is_double__string_ref.restype = c_bool
sklib.__sklib__is_integer__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__is_integer__string_ref.restype = c_bool
sklib.__sklib__is_number__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__is_number__string_ref.restype = c_bool
sklib.__sklib__length_of__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__length_of__string_ref.restype = c_int
sklib.__sklib__replace_all__string_ref__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string, _sklib_string ]
sklib.__sklib__replace_all__string_ref__string_ref__string_ref.restype = _sklib_string
sklib.__sklib__split__string_ref__char.argtypes = [ _sklib_string, c_char ]
sklib.__sklib__split__string_ref__char.restype = _sklib_vector_string
sklib.__sklib__to_lowercase__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__to_lowercase__string_ref.restype = _sklib_string
sklib.__sklib__to_uppercase__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__to_uppercase__string_ref.restype = _sklib_string
sklib.__sklib__trim__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__trim__string_ref.restype = _sklib_string
sklib.__sklib__free_resource_bundle__string.argtypes = [ _sklib_string ]
sklib.__sklib__free_resource_bundle__string.restype = None
sklib.__sklib__has_resource_bundle__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__has_resource_bundle__string_ref.restype = c_bool
sklib.__sklib__load_resource_bundle__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__load_resource_bundle__string_ref__string_ref.restype = None
sklib.__sklib__camera_position.argtypes = [  ]
sklib.__sklib__camera_position.restype = _sklib_point_2d
sklib.__sklib__camera_x.argtypes = [  ]
sklib.__sklib__camera_x.restype = c_double
sklib.__sklib__camera_y.argtypes = [  ]
sklib.__sklib__camera_y.restype = c_double
sklib.__sklib__center_camera_on__sprite__vector_2d_ref.argtypes = [ c_void_p, _sklib_vector_2d ]
sklib.__sklib__center_camera_on__sprite__vector_2d_ref.restype = None
sklib.__sklib__center_camera_on__sprite__double__double.argtypes = [ c_void_p, c_double, c_double ]
sklib.__sklib__center_camera_on__sprite__double__double.restype = None
sklib.__sklib__move_camera_by__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__move_camera_by__vector_2d_ref.restype = None
sklib.__sklib__move_camera_by__double__double.argtypes = [ c_double, c_double ]
sklib.__sklib__move_camera_by__double__double.restype = None
sklib.__sklib__move_camera_to__point_2d_ref.argtypes = [ _sklib_point_2d ]
sklib.__sklib__move_camera_to__point_2d_ref.restype = None
sklib.__sklib__move_camera_to__double__double.argtypes = [ c_double, c_double ]
sklib.__sklib__move_camera_to__double__double.restype = None
sklib.__sklib__point_in_window__window__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__point_in_window__window__point_2d_ref.restype = c_bool
sklib.__sklib__point_on_screen__point_2d_ref.argtypes = [ _sklib_point_2d ]
sklib.__sklib__point_on_screen__point_2d_ref.restype = c_bool
sklib.__sklib__rect_in_window__window__rectangle_ref.argtypes = [ c_void_p, _sklib_rectangle ]
sklib.__sklib__rect_in_window__window__rectangle_ref.restype = c_bool
sklib.__sklib__rect_on_screen__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__rect_on_screen__rectangle_ref.restype = c_bool
sklib.__sklib__screen_center.argtypes = [  ]
sklib.__sklib__screen_center.restype = _sklib_point_2d
sklib.__sklib__screen_rectangle.argtypes = [  ]
sklib.__sklib__screen_rectangle.restype = _sklib_rectangle
sklib.__sklib__set_camera_position__point_2d.argtypes = [ _sklib_point_2d ]
sklib.__sklib__set_camera_position__point_2d.restype = None
sklib.__sklib__set_camera_x__double.argtypes = [ c_double ]
sklib.__sklib__set_camera_x__double.restype = None
sklib.__sklib__set_camera_y__double.argtypes = [ c_double ]
sklib.__sklib__set_camera_y__double.restype = None
sklib.__sklib__to_screen__point_2d_ref.argtypes = [ _sklib_point_2d ]
sklib.__sklib__to_screen__point_2d_ref.restype = _sklib_point_2d
sklib.__sklib__to_screen__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__to_screen__rectangle_ref.restype = _sklib_rectangle
sklib.__sklib__to_screen_x__double.argtypes = [ c_double ]
sklib.__sklib__to_screen_x__double.restype = c_double
sklib.__sklib__to_screen_y__double.argtypes = [ c_double ]
sklib.__sklib__to_screen_y__double.restype = c_double
sklib.__sklib__to_world__point_2d_ref.argtypes = [ _sklib_point_2d ]
sklib.__sklib__to_world__point_2d_ref.restype = _sklib_point_2d
sklib.__sklib__to_world_x__double.argtypes = [ c_double ]
sklib.__sklib__to_world_x__double.restype = c_double
sklib.__sklib__to_world_y__double.argtypes = [ c_double ]
sklib.__sklib__to_world_y__double.restype = c_double
sklib.__sklib__vector_world_to_screen.argtypes = [  ]
sklib.__sklib__vector_world_to_screen.restype = _sklib_vector_2d
sklib.__sklib__window_area__window.argtypes = [ c_void_p ]
sklib.__sklib__window_area__window.restype = _sklib_rectangle
sklib.__sklib__draw_circle__color__circle_ref.argtypes = [ _sklib_color, _sklib_circle ]
sklib.__sklib__draw_circle__color__circle_ref.restype = None
sklib.__sklib__draw_circle__color__circle_ref__drawing_options.argtypes = [ _sklib_color, _sklib_circle, _sklib_drawing_options ]
sklib.__sklib__draw_circle__color__circle_ref__drawing_options.restype = None
sklib.__sklib__draw_circle__color__double__double__double.argtypes = [ _sklib_color, c_double, c_double, c_double ]
sklib.__sklib__draw_circle__color__double__double__double.restype = None
sklib.__sklib__draw_circle__color__double__double__double__drawing_options.argtypes = [ _sklib_color, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_circle__color__double__double__double__drawing_options.restype = None
sklib.__sklib__draw_circle_on_bitmap__bitmap__color__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double ]
sklib.__sklib__draw_circle_on_bitmap__bitmap__color__double__double__double.restype = None
sklib.__sklib__draw_circle_on_bitmap__bitmap__color__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_circle_on_bitmap__bitmap__color__double__double__double__drawing_options.restype = None
sklib.__sklib__draw_circle_on_window__window__color__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double ]
sklib.__sklib__draw_circle_on_window__window__color__double__double__double.restype = None
sklib.__sklib__draw_circle_on_window__window__color__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_circle_on_window__window__color__double__double__double__drawing_options.restype = None
sklib.__sklib__fill_circle__color__circle_ref.argtypes = [ _sklib_color, _sklib_circle ]
sklib.__sklib__fill_circle__color__circle_ref.restype = None
sklib.__sklib__fill_circle__color__circle_ref__drawing_options.argtypes = [ _sklib_color, _sklib_circle, _sklib_drawing_options ]
sklib.__sklib__fill_circle__color__circle_ref__drawing_options.restype = None
sklib.__sklib__fill_circle__color__double__double__double.argtypes = [ _sklib_color, c_double, c_double, c_double ]
sklib.__sklib__fill_circle__color__double__double__double.restype = None
sklib.__sklib__fill_circle__color__double__double__double__drawing_options.argtypes = [ _sklib_color, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_circle__color__double__double__double__drawing_options.restype = None
sklib.__sklib__fill_circle_on_bitmap__bitmap__color__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double ]
sklib.__sklib__fill_circle_on_bitmap__bitmap__color__double__double__double.restype = None
sklib.__sklib__fill_circle_on_bitmap__bitmap__color__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_circle_on_bitmap__bitmap__color__double__double__double__drawing_options.restype = None
sklib.__sklib__fill_circle_on_window__window__color__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double ]
sklib.__sklib__fill_circle_on_window__window__color__double__double__double.restype = None
sklib.__sklib__fill_circle_on_window__window__color__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_circle_on_window__window__color__double__double__double__drawing_options.restype = None
sklib.__sklib__center_point__circle_ref.argtypes = [ _sklib_circle ]
sklib.__sklib__center_point__circle_ref.restype = _sklib_point_2d
sklib.__sklib__circle_at__point_2d_ref__double.argtypes = [ _sklib_point_2d, c_double ]
sklib.__sklib__circle_at__point_2d_ref__double.restype = _sklib_circle
sklib.__sklib__circle_at__double__double__double.argtypes = [ c_double, c_double, c_double ]
sklib.__sklib__circle_at__double__double__double.restype = _sklib_circle
sklib.__sklib__circle_radius__circle.argtypes = [ _sklib_circle ]
sklib.__sklib__circle_radius__circle.restype = c_float
sklib.__sklib__circle_triangle_intersect__circle_ref__triangle_ref.argtypes = [ _sklib_circle, _sklib_triangle ]
sklib.__sklib__circle_triangle_intersect__circle_ref__triangle_ref.restype = c_bool
sklib.__sklib__circle_triangle_intersect__circle_ref__triangle_ref__point_2d_ref.argtypes = [ _sklib_circle, _sklib_triangle, POINTER(_sklib_point_2d) ]
sklib.__sklib__circle_triangle_intersect__circle_ref__triangle_ref__point_2d_ref.restype = c_bool
sklib.__sklib__circle_x__circle_ref.argtypes = [ _sklib_circle ]
sklib.__sklib__circle_x__circle_ref.restype = c_float
sklib.__sklib__circle_y__circle_ref.argtypes = [ _sklib_circle ]
sklib.__sklib__circle_y__circle_ref.restype = c_float
sklib.__sklib__circles_intersect__circle__circle.argtypes = [ _sklib_circle, _sklib_circle ]
sklib.__sklib__circles_intersect__circle__circle.restype = c_bool
sklib.__sklib__circles_intersect__double__double__double__double__double__double.argtypes = [ c_double, c_double, c_double, c_double, c_double, c_double ]
sklib.__sklib__circles_intersect__double__double__double__double__double__double.restype = c_bool
sklib.__sklib__closest_point_on_circle__point_2d_ref__circle_ref.argtypes = [ _sklib_point_2d, _sklib_circle ]
sklib.__sklib__closest_point_on_circle__point_2d_ref__circle_ref.restype = _sklib_point_2d
sklib.__sklib__closest_point_on_line_from_circle__circle_ref__line_ref.argtypes = [ _sklib_circle, _sklib_line ]
sklib.__sklib__closest_point_on_line_from_circle__circle_ref__line_ref.restype = _sklib_point_2d
sklib.__sklib__closest_point_on_rect_from_circle__circle_ref__rectangle_ref.argtypes = [ _sklib_circle, _sklib_rectangle ]
sklib.__sklib__closest_point_on_rect_from_circle__circle_ref__rectangle_ref.restype = _sklib_point_2d
sklib.__sklib__closest_point_on_triangle_from_circle__circle_ref__triangle_ref.argtypes = [ _sklib_circle, _sklib_triangle ]
sklib.__sklib__closest_point_on_triangle_from_circle__circle_ref__triangle_ref.restype = _sklib_point_2d
sklib.__sklib__distant_point_on_circle__point_2d_ref__circle_ref.argtypes = [ _sklib_point_2d, _sklib_circle ]
sklib.__sklib__distant_point_on_circle__point_2d_ref__circle_ref.restype = _sklib_point_2d
sklib.__sklib__distant_point_on_circle_heading__point_2d_ref__circle_ref__vector_2d_ref__point_2d_ref.argtypes = [ _sklib_point_2d, _sklib_circle, _sklib_vector_2d, POINTER(_sklib_point_2d) ]
sklib.__sklib__distant_point_on_circle_heading__point_2d_ref__circle_ref__vector_2d_ref__point_2d_ref.restype = c_bool
sklib.__sklib__ray_circle_intersect_distance__point_2d_ref__vector_2d_ref__circle_ref.argtypes = [ _sklib_point_2d, _sklib_vector_2d, _sklib_circle ]
sklib.__sklib__ray_circle_intersect_distance__point_2d_ref__vector_2d_ref__circle_ref.restype = c_float
sklib.__sklib__tangent_points__point_2d_ref__circle_ref__point_2d_ref__point_2d_ref.argtypes = [ _sklib_point_2d, _sklib_circle, POINTER(_sklib_point_2d), POINTER(_sklib_point_2d) ]
sklib.__sklib__tangent_points__point_2d_ref__circle_ref__point_2d_ref__point_2d_ref.restype = c_bool
sklib.__sklib__widest_points__circle_ref__vector_2d_ref__point_2d_ref__point_2d_ref.argtypes = [ _sklib_circle, _sklib_vector_2d, POINTER(_sklib_point_2d), POINTER(_sklib_point_2d) ]
sklib.__sklib__widest_points__circle_ref__vector_2d_ref__point_2d_ref__point_2d_ref.restype = None
sklib.__sklib__current_clip.argtypes = [  ]
sklib.__sklib__current_clip.restype = _sklib_rectangle
sklib.__sklib__current_clip__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__current_clip__bitmap.restype = _sklib_rectangle
sklib.__sklib__current_clip__window.argtypes = [ c_void_p ]
sklib.__sklib__current_clip__window.restype = _sklib_rectangle
sklib.__sklib__pop_clip__window.argtypes = [ c_void_p ]
sklib.__sklib__pop_clip__window.restype = None
sklib.__sklib__pop_clip.argtypes = [  ]
sklib.__sklib__pop_clip.restype = None
sklib.__sklib__pop_clip__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__pop_clip__bitmap.restype = None
sklib.__sklib__push_clip__window__rectangle_ref.argtypes = [ c_void_p, _sklib_rectangle ]
sklib.__sklib__push_clip__window__rectangle_ref.restype = None
sklib.__sklib__push_clip__bitmap__rectangle_ref.argtypes = [ c_void_p, _sklib_rectangle ]
sklib.__sklib__push_clip__bitmap__rectangle_ref.restype = None
sklib.__sklib__push_clip__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__push_clip__rectangle_ref.restype = None
sklib.__sklib__reset_clip__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__reset_clip__bitmap.restype = None
sklib.__sklib__reset_clip.argtypes = [  ]
sklib.__sklib__reset_clip.restype = None
sklib.__sklib__reset_clip__window.argtypes = [ c_void_p ]
sklib.__sklib__reset_clip__window.restype = None
sklib.__sklib__set_clip__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__set_clip__rectangle_ref.restype = None
sklib.__sklib__set_clip__bitmap__rectangle_ref.argtypes = [ c_void_p, _sklib_rectangle ]
sklib.__sklib__set_clip__bitmap__rectangle_ref.restype = None
sklib.__sklib__set_clip__window__rectangle_ref.argtypes = [ c_void_p, _sklib_rectangle ]
sklib.__sklib__set_clip__window__rectangle_ref.restype = None
sklib.__sklib__bitmap_circle_collision__bitmap__point_2d_ref__circle_ref.argtypes = [ c_void_p, _sklib_point_2d, _sklib_circle ]
sklib.__sklib__bitmap_circle_collision__bitmap__point_2d_ref__circle_ref.restype = c_bool
sklib.__sklib__bitmap_circle_collision__bitmap__double__double__circle_ref.argtypes = [ c_void_p, c_double, c_double, _sklib_circle ]
sklib.__sklib__bitmap_circle_collision__bitmap__double__double__circle_ref.restype = c_bool
sklib.__sklib__bitmap_circle_collision__bitmap__int__matrix_2d_ref__circle_ref.argtypes = [ c_void_p, c_int, _sklib_matrix_2d, _sklib_circle ]
sklib.__sklib__bitmap_circle_collision__bitmap__int__matrix_2d_ref__circle_ref.restype = c_bool
sklib.__sklib__bitmap_circle_collision__bitmap__int__point_2d_ref__circle_ref.argtypes = [ c_void_p, c_int, _sklib_point_2d, _sklib_circle ]
sklib.__sklib__bitmap_circle_collision__bitmap__int__point_2d_ref__circle_ref.restype = c_bool
sklib.__sklib__bitmap_circle_collision__bitmap__int__double__double__circle_ref.argtypes = [ c_void_p, c_int, c_double, c_double, _sklib_circle ]
sklib.__sklib__bitmap_circle_collision__bitmap__int__double__double__circle_ref.restype = c_bool
sklib.__sklib__bitmap_collision__bitmap__double__double__bitmap__double__double.argtypes = [ c_void_p, c_double, c_double, c_void_p, c_double, c_double ]
sklib.__sklib__bitmap_collision__bitmap__double__double__bitmap__double__double.restype = c_bool
sklib.__sklib__bitmap_collision__bitmap__point_2d_ref__bitmap__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d, c_void_p, _sklib_point_2d ]
sklib.__sklib__bitmap_collision__bitmap__point_2d_ref__bitmap__point_2d_ref.restype = c_bool
sklib.__sklib__bitmap_collision__bitmap__int__matrix_2d_ref__bitmap__int__matrix_2d_ref.argtypes = [ c_void_p, c_int, _sklib_matrix_2d, c_void_p, c_int, _sklib_matrix_2d ]
sklib.__sklib__bitmap_collision__bitmap__int__matrix_2d_ref__bitmap__int__matrix_2d_ref.restype = c_bool
sklib.__sklib__bitmap_collision__bitmap__int__point_2d_ref__bitmap__int__point_2d_ref.argtypes = [ c_void_p, c_int, _sklib_point_2d, c_void_p, c_int, _sklib_point_2d ]
sklib.__sklib__bitmap_collision__bitmap__int__point_2d_ref__bitmap__int__point_2d_ref.restype = c_bool
sklib.__sklib__bitmap_collision__bitmap__int__double__double__bitmap__int__double__double.argtypes = [ c_void_p, c_int, c_double, c_double, c_void_p, c_int, c_double, c_double ]
sklib.__sklib__bitmap_collision__bitmap__int__double__double__bitmap__int__double__double.restype = c_bool
sklib.__sklib__bitmap_point_collision__bitmap__matrix_2d_ref__point_2d_ref.argtypes = [ c_void_p, _sklib_matrix_2d, _sklib_point_2d ]
sklib.__sklib__bitmap_point_collision__bitmap__matrix_2d_ref__point_2d_ref.restype = c_bool
sklib.__sklib__bitmap_point_collision__bitmap__point_2d_ref__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__bitmap_point_collision__bitmap__point_2d_ref__point_2d_ref.restype = c_bool
sklib.__sklib__bitmap_point_collision__bitmap__double__double__double__double.argtypes = [ c_void_p, c_double, c_double, c_double, c_double ]
sklib.__sklib__bitmap_point_collision__bitmap__double__double__double__double.restype = c_bool
sklib.__sklib__bitmap_point_collision__bitmap__int__matrix_2d_ref__point_2d_ref.argtypes = [ c_void_p, c_int, _sklib_matrix_2d, _sklib_point_2d ]
sklib.__sklib__bitmap_point_collision__bitmap__int__matrix_2d_ref__point_2d_ref.restype = c_bool
sklib.__sklib__bitmap_point_collision__bitmap__int__point_2d_ref__point_2d_ref.argtypes = [ c_void_p, c_int, _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__bitmap_point_collision__bitmap__int__point_2d_ref__point_2d_ref.restype = c_bool
sklib.__sklib__bitmap_point_collision__bitmap__int__double__double__double__double.argtypes = [ c_void_p, c_int, c_double, c_double, c_double, c_double ]
sklib.__sklib__bitmap_point_collision__bitmap__int__double__double__double__double.restype = c_bool
sklib.__sklib__bitmap_rectangle_collision__bitmap__point_2d_ref__rectangle_ref.argtypes = [ c_void_p, _sklib_point_2d, _sklib_rectangle ]
sklib.__sklib__bitmap_rectangle_collision__bitmap__point_2d_ref__rectangle_ref.restype = c_bool
sklib.__sklib__bitmap_rectangle_collision__bitmap__double__double__rectangle_ref.argtypes = [ c_void_p, c_double, c_double, _sklib_rectangle ]
sklib.__sklib__bitmap_rectangle_collision__bitmap__double__double__rectangle_ref.restype = c_bool
sklib.__sklib__bitmap_rectangle_collision__bitmap__int__matrix_2d_ref__rectangle_ref.argtypes = [ c_void_p, c_int, _sklib_matrix_2d, _sklib_rectangle ]
sklib.__sklib__bitmap_rectangle_collision__bitmap__int__matrix_2d_ref__rectangle_ref.restype = c_bool
sklib.__sklib__bitmap_rectangle_collision__bitmap__int__point_2d_ref__rectangle_ref.argtypes = [ c_void_p, c_int, _sklib_point_2d, _sklib_rectangle ]
sklib.__sklib__bitmap_rectangle_collision__bitmap__int__point_2d_ref__rectangle_ref.restype = c_bool
sklib.__sklib__bitmap_rectangle_collision__bitmap__int__double__double__rectangle_ref.argtypes = [ c_void_p, c_int, c_double, c_double, _sklib_rectangle ]
sklib.__sklib__bitmap_rectangle_collision__bitmap__int__double__double__rectangle_ref.restype = c_bool
sklib.__sklib__sprite_bitmap_collision__sprite__bitmap__double__double.argtypes = [ c_void_p, c_void_p, c_double, c_double ]
sklib.__sklib__sprite_bitmap_collision__sprite__bitmap__double__double.restype = c_bool
sklib.__sklib__sprite_bitmap_collision__sprite__bitmap__int__point_2d_ref.argtypes = [ c_void_p, c_void_p, c_int, _sklib_point_2d ]
sklib.__sklib__sprite_bitmap_collision__sprite__bitmap__int__point_2d_ref.restype = c_bool
sklib.__sklib__sprite_bitmap_collision__sprite__bitmap__int__double__double.argtypes = [ c_void_p, c_void_p, c_int, c_double, c_double ]
sklib.__sklib__sprite_bitmap_collision__sprite__bitmap__int__double__double.restype = c_bool
sklib.__sklib__sprite_collision__sprite__sprite.argtypes = [ c_void_p, c_void_p ]
sklib.__sklib__sprite_collision__sprite__sprite.restype = c_bool
sklib.__sklib__sprite_point_collision__sprite__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__sprite_point_collision__sprite__point_2d_ref.restype = c_bool
sklib.__sklib__sprite_rectangle_collision__sprite__rectangle_ref.argtypes = [ c_void_p, _sklib_rectangle ]
sklib.__sklib__sprite_rectangle_collision__sprite__rectangle_ref.restype = c_bool
sklib.__sklib__alpha_of__color.argtypes = [ _sklib_color ]
sklib.__sklib__alpha_of__color.restype = c_int
sklib.__sklib__blue_of__color.argtypes = [ _sklib_color ]
sklib.__sklib__blue_of__color.restype = c_int
sklib.__sklib__brightness_of__color.argtypes = [ _sklib_color ]
sklib.__sklib__brightness_of__color.restype = c_double
sklib.__sklib__color_alice_blue.argtypes = [  ]
sklib.__sklib__color_alice_blue.restype = _sklib_color
sklib.__sklib__color_antique_white.argtypes = [  ]
sklib.__sklib__color_antique_white.restype = _sklib_color
sklib.__sklib__color_aqua.argtypes = [  ]
sklib.__sklib__color_aqua.restype = _sklib_color
sklib.__sklib__color_aquamarine.argtypes = [  ]
sklib.__sklib__color_aquamarine.restype = _sklib_color
sklib.__sklib__color_azure.argtypes = [  ]
sklib.__sklib__color_azure.restype = _sklib_color
sklib.__sklib__color_beige.argtypes = [  ]
sklib.__sklib__color_beige.restype = _sklib_color
sklib.__sklib__color_bisque.argtypes = [  ]
sklib.__sklib__color_bisque.restype = _sklib_color
sklib.__sklib__color_black.argtypes = [  ]
sklib.__sklib__color_black.restype = _sklib_color
sklib.__sklib__color_blanched_almond.argtypes = [  ]
sklib.__sklib__color_blanched_almond.restype = _sklib_color
sklib.__sklib__color_blue.argtypes = [  ]
sklib.__sklib__color_blue.restype = _sklib_color
sklib.__sklib__color_blue_violet.argtypes = [  ]
sklib.__sklib__color_blue_violet.restype = _sklib_color
sklib.__sklib__color_bright_green.argtypes = [  ]
sklib.__sklib__color_bright_green.restype = _sklib_color
sklib.__sklib__color_brown.argtypes = [  ]
sklib.__sklib__color_brown.restype = _sklib_color
sklib.__sklib__color_burly_wood.argtypes = [  ]
sklib.__sklib__color_burly_wood.restype = _sklib_color
sklib.__sklib__color_cadet_blue.argtypes = [  ]
sklib.__sklib__color_cadet_blue.restype = _sklib_color
sklib.__sklib__color_chartreuse.argtypes = [  ]
sklib.__sklib__color_chartreuse.restype = _sklib_color
sklib.__sklib__color_chocolate.argtypes = [  ]
sklib.__sklib__color_chocolate.restype = _sklib_color
sklib.__sklib__color_coral.argtypes = [  ]
sklib.__sklib__color_coral.restype = _sklib_color
sklib.__sklib__color_cornflower_blue.argtypes = [  ]
sklib.__sklib__color_cornflower_blue.restype = _sklib_color
sklib.__sklib__color_cornsilk.argtypes = [  ]
sklib.__sklib__color_cornsilk.restype = _sklib_color
sklib.__sklib__color_crimson.argtypes = [  ]
sklib.__sklib__color_crimson.restype = _sklib_color
sklib.__sklib__color_cyan.argtypes = [  ]
sklib.__sklib__color_cyan.restype = _sklib_color
sklib.__sklib__color_dark_blue.argtypes = [  ]
sklib.__sklib__color_dark_blue.restype = _sklib_color
sklib.__sklib__color_dark_cyan.argtypes = [  ]
sklib.__sklib__color_dark_cyan.restype = _sklib_color
sklib.__sklib__color_dark_goldenrod.argtypes = [  ]
sklib.__sklib__color_dark_goldenrod.restype = _sklib_color
sklib.__sklib__color_dark_gray.argtypes = [  ]
sklib.__sklib__color_dark_gray.restype = _sklib_color
sklib.__sklib__color_dark_green.argtypes = [  ]
sklib.__sklib__color_dark_green.restype = _sklib_color
sklib.__sklib__color_dark_khaki.argtypes = [  ]
sklib.__sklib__color_dark_khaki.restype = _sklib_color
sklib.__sklib__color_dark_magenta.argtypes = [  ]
sklib.__sklib__color_dark_magenta.restype = _sklib_color
sklib.__sklib__color_dark_olive_green.argtypes = [  ]
sklib.__sklib__color_dark_olive_green.restype = _sklib_color
sklib.__sklib__color_dark_orange.argtypes = [  ]
sklib.__sklib__color_dark_orange.restype = _sklib_color
sklib.__sklib__color_dark_orchid.argtypes = [  ]
sklib.__sklib__color_dark_orchid.restype = _sklib_color
sklib.__sklib__color_dark_red.argtypes = [  ]
sklib.__sklib__color_dark_red.restype = _sklib_color
sklib.__sklib__color_dark_salmon.argtypes = [  ]
sklib.__sklib__color_dark_salmon.restype = _sklib_color
sklib.__sklib__color_dark_sea_green.argtypes = [  ]
sklib.__sklib__color_dark_sea_green.restype = _sklib_color
sklib.__sklib__color_dark_slate_blue.argtypes = [  ]
sklib.__sklib__color_dark_slate_blue.restype = _sklib_color
sklib.__sklib__color_dark_slate_gray.argtypes = [  ]
sklib.__sklib__color_dark_slate_gray.restype = _sklib_color
sklib.__sklib__color_dark_turquoise.argtypes = [  ]
sklib.__sklib__color_dark_turquoise.restype = _sklib_color
sklib.__sklib__color_dark_violet.argtypes = [  ]
sklib.__sklib__color_dark_violet.restype = _sklib_color
sklib.__sklib__color_deep_pink.argtypes = [  ]
sklib.__sklib__color_deep_pink.restype = _sklib_color
sklib.__sklib__color_deep_sky_blue.argtypes = [  ]
sklib.__sklib__color_deep_sky_blue.restype = _sklib_color
sklib.__sklib__color_dim_gray.argtypes = [  ]
sklib.__sklib__color_dim_gray.restype = _sklib_color
sklib.__sklib__color_dodger_blue.argtypes = [  ]
sklib.__sklib__color_dodger_blue.restype = _sklib_color
sklib.__sklib__color_firebrick.argtypes = [  ]
sklib.__sklib__color_firebrick.restype = _sklib_color
sklib.__sklib__color_floral_white.argtypes = [  ]
sklib.__sklib__color_floral_white.restype = _sklib_color
sklib.__sklib__color_forest_green.argtypes = [  ]
sklib.__sklib__color_forest_green.restype = _sklib_color
sklib.__sklib__color_fuchsia.argtypes = [  ]
sklib.__sklib__color_fuchsia.restype = _sklib_color
sklib.__sklib__color_gainsboro.argtypes = [  ]
sklib.__sklib__color_gainsboro.restype = _sklib_color
sklib.__sklib__color_ghost_white.argtypes = [  ]
sklib.__sklib__color_ghost_white.restype = _sklib_color
sklib.__sklib__color_gold.argtypes = [  ]
sklib.__sklib__color_gold.restype = _sklib_color
sklib.__sklib__color_goldenrod.argtypes = [  ]
sklib.__sklib__color_goldenrod.restype = _sklib_color
sklib.__sklib__color_gray.argtypes = [  ]
sklib.__sklib__color_gray.restype = _sklib_color
sklib.__sklib__color_green.argtypes = [  ]
sklib.__sklib__color_green.restype = _sklib_color
sklib.__sklib__color_green_yellow.argtypes = [  ]
sklib.__sklib__color_green_yellow.restype = _sklib_color
sklib.__sklib__color_honeydew.argtypes = [  ]
sklib.__sklib__color_honeydew.restype = _sklib_color
sklib.__sklib__color_hot_pink.argtypes = [  ]
sklib.__sklib__color_hot_pink.restype = _sklib_color
sklib.__sklib__color_indian_red.argtypes = [  ]
sklib.__sklib__color_indian_red.restype = _sklib_color
sklib.__sklib__color_indigo.argtypes = [  ]
sklib.__sklib__color_indigo.restype = _sklib_color
sklib.__sklib__color_ivory.argtypes = [  ]
sklib.__sklib__color_ivory.restype = _sklib_color
sklib.__sklib__color_khaki.argtypes = [  ]
sklib.__sklib__color_khaki.restype = _sklib_color
sklib.__sklib__color_lavender.argtypes = [  ]
sklib.__sklib__color_lavender.restype = _sklib_color
sklib.__sklib__color_lavender_blush.argtypes = [  ]
sklib.__sklib__color_lavender_blush.restype = _sklib_color
sklib.__sklib__color_lawn_green.argtypes = [  ]
sklib.__sklib__color_lawn_green.restype = _sklib_color
sklib.__sklib__color_lemon_chiffon.argtypes = [  ]
sklib.__sklib__color_lemon_chiffon.restype = _sklib_color
sklib.__sklib__color_light_blue.argtypes = [  ]
sklib.__sklib__color_light_blue.restype = _sklib_color
sklib.__sklib__color_light_coral.argtypes = [  ]
sklib.__sklib__color_light_coral.restype = _sklib_color
sklib.__sklib__color_light_cyan.argtypes = [  ]
sklib.__sklib__color_light_cyan.restype = _sklib_color
sklib.__sklib__color_light_goldenrod_yellow.argtypes = [  ]
sklib.__sklib__color_light_goldenrod_yellow.restype = _sklib_color
sklib.__sklib__color_light_gray.argtypes = [  ]
sklib.__sklib__color_light_gray.restype = _sklib_color
sklib.__sklib__color_light_green.argtypes = [  ]
sklib.__sklib__color_light_green.restype = _sklib_color
sklib.__sklib__color_light_pink.argtypes = [  ]
sklib.__sklib__color_light_pink.restype = _sklib_color
sklib.__sklib__color_light_salmon.argtypes = [  ]
sklib.__sklib__color_light_salmon.restype = _sklib_color
sklib.__sklib__color_light_sea_green.argtypes = [  ]
sklib.__sklib__color_light_sea_green.restype = _sklib_color
sklib.__sklib__color_light_sky_blue.argtypes = [  ]
sklib.__sklib__color_light_sky_blue.restype = _sklib_color
sklib.__sklib__color_light_slate_gray.argtypes = [  ]
sklib.__sklib__color_light_slate_gray.restype = _sklib_color
sklib.__sklib__color_light_steel_blue.argtypes = [  ]
sklib.__sklib__color_light_steel_blue.restype = _sklib_color
sklib.__sklib__color_light_yellow.argtypes = [  ]
sklib.__sklib__color_light_yellow.restype = _sklib_color
sklib.__sklib__color_lime.argtypes = [  ]
sklib.__sklib__color_lime.restype = _sklib_color
sklib.__sklib__color_lime_green.argtypes = [  ]
sklib.__sklib__color_lime_green.restype = _sklib_color
sklib.__sklib__color_linen.argtypes = [  ]
sklib.__sklib__color_linen.restype = _sklib_color
sklib.__sklib__color_magenta.argtypes = [  ]
sklib.__sklib__color_magenta.restype = _sklib_color
sklib.__sklib__color_maroon.argtypes = [  ]
sklib.__sklib__color_maroon.restype = _sklib_color
sklib.__sklib__color_medium_aquamarine.argtypes = [  ]
sklib.__sklib__color_medium_aquamarine.restype = _sklib_color
sklib.__sklib__color_medium_blue.argtypes = [  ]
sklib.__sklib__color_medium_blue.restype = _sklib_color
sklib.__sklib__color_medium_orchid.argtypes = [  ]
sklib.__sklib__color_medium_orchid.restype = _sklib_color
sklib.__sklib__color_medium_purple.argtypes = [  ]
sklib.__sklib__color_medium_purple.restype = _sklib_color
sklib.__sklib__color_medium_sea_green.argtypes = [  ]
sklib.__sklib__color_medium_sea_green.restype = _sklib_color
sklib.__sklib__color_medium_slate_blue.argtypes = [  ]
sklib.__sklib__color_medium_slate_blue.restype = _sklib_color
sklib.__sklib__color_medium_spring_green.argtypes = [  ]
sklib.__sklib__color_medium_spring_green.restype = _sklib_color
sklib.__sklib__color_medium_turquoise.argtypes = [  ]
sklib.__sklib__color_medium_turquoise.restype = _sklib_color
sklib.__sklib__color_medium_violet_red.argtypes = [  ]
sklib.__sklib__color_medium_violet_red.restype = _sklib_color
sklib.__sklib__color_midnight_blue.argtypes = [  ]
sklib.__sklib__color_midnight_blue.restype = _sklib_color
sklib.__sklib__color_mint_cream.argtypes = [  ]
sklib.__sklib__color_mint_cream.restype = _sklib_color
sklib.__sklib__color_misty_rose.argtypes = [  ]
sklib.__sklib__color_misty_rose.restype = _sklib_color
sklib.__sklib__color_moccasin.argtypes = [  ]
sklib.__sklib__color_moccasin.restype = _sklib_color
sklib.__sklib__color_navajo_white.argtypes = [  ]
sklib.__sklib__color_navajo_white.restype = _sklib_color
sklib.__sklib__color_navy.argtypes = [  ]
sklib.__sklib__color_navy.restype = _sklib_color
sklib.__sklib__color_old_lace.argtypes = [  ]
sklib.__sklib__color_old_lace.restype = _sklib_color
sklib.__sklib__color_olive.argtypes = [  ]
sklib.__sklib__color_olive.restype = _sklib_color
sklib.__sklib__color_olive_drab.argtypes = [  ]
sklib.__sklib__color_olive_drab.restype = _sklib_color
sklib.__sklib__color_orange.argtypes = [  ]
sklib.__sklib__color_orange.restype = _sklib_color
sklib.__sklib__color_orange_red.argtypes = [  ]
sklib.__sklib__color_orange_red.restype = _sklib_color
sklib.__sklib__color_orchid.argtypes = [  ]
sklib.__sklib__color_orchid.restype = _sklib_color
sklib.__sklib__color_pale_goldenrod.argtypes = [  ]
sklib.__sklib__color_pale_goldenrod.restype = _sklib_color
sklib.__sklib__color_pale_green.argtypes = [  ]
sklib.__sklib__color_pale_green.restype = _sklib_color
sklib.__sklib__color_pale_turquoise.argtypes = [  ]
sklib.__sklib__color_pale_turquoise.restype = _sklib_color
sklib.__sklib__color_pale_violet_red.argtypes = [  ]
sklib.__sklib__color_pale_violet_red.restype = _sklib_color
sklib.__sklib__color_papaya_whip.argtypes = [  ]
sklib.__sklib__color_papaya_whip.restype = _sklib_color
sklib.__sklib__color_peach_puff.argtypes = [  ]
sklib.__sklib__color_peach_puff.restype = _sklib_color
sklib.__sklib__color_peru.argtypes = [  ]
sklib.__sklib__color_peru.restype = _sklib_color
sklib.__sklib__color_pink.argtypes = [  ]
sklib.__sklib__color_pink.restype = _sklib_color
sklib.__sklib__color_plum.argtypes = [  ]
sklib.__sklib__color_plum.restype = _sklib_color
sklib.__sklib__color_powder_blue.argtypes = [  ]
sklib.__sklib__color_powder_blue.restype = _sklib_color
sklib.__sklib__color_purple.argtypes = [  ]
sklib.__sklib__color_purple.restype = _sklib_color
sklib.__sklib__color_red.argtypes = [  ]
sklib.__sklib__color_red.restype = _sklib_color
sklib.__sklib__color_rosy_brown.argtypes = [  ]
sklib.__sklib__color_rosy_brown.restype = _sklib_color
sklib.__sklib__color_royal_blue.argtypes = [  ]
sklib.__sklib__color_royal_blue.restype = _sklib_color
sklib.__sklib__color_saddle_brown.argtypes = [  ]
sklib.__sklib__color_saddle_brown.restype = _sklib_color
sklib.__sklib__color_salmon.argtypes = [  ]
sklib.__sklib__color_salmon.restype = _sklib_color
sklib.__sklib__color_sandy_brown.argtypes = [  ]
sklib.__sklib__color_sandy_brown.restype = _sklib_color
sklib.__sklib__color_sea_green.argtypes = [  ]
sklib.__sklib__color_sea_green.restype = _sklib_color
sklib.__sklib__color_sea_shell.argtypes = [  ]
sklib.__sklib__color_sea_shell.restype = _sklib_color
sklib.__sklib__color_sienna.argtypes = [  ]
sklib.__sklib__color_sienna.restype = _sklib_color
sklib.__sklib__color_silver.argtypes = [  ]
sklib.__sklib__color_silver.restype = _sklib_color
sklib.__sklib__color_sky_blue.argtypes = [  ]
sklib.__sklib__color_sky_blue.restype = _sklib_color
sklib.__sklib__color_slate_blue.argtypes = [  ]
sklib.__sklib__color_slate_blue.restype = _sklib_color
sklib.__sklib__color_slate_gray.argtypes = [  ]
sklib.__sklib__color_slate_gray.restype = _sklib_color
sklib.__sklib__color_snow.argtypes = [  ]
sklib.__sklib__color_snow.restype = _sklib_color
sklib.__sklib__color_spring_green.argtypes = [  ]
sklib.__sklib__color_spring_green.restype = _sklib_color
sklib.__sklib__color_steel_blue.argtypes = [  ]
sklib.__sklib__color_steel_blue.restype = _sklib_color
sklib.__sklib__color_swinburne_red.argtypes = [  ]
sklib.__sklib__color_swinburne_red.restype = _sklib_color
sklib.__sklib__color_tan.argtypes = [  ]
sklib.__sklib__color_tan.restype = _sklib_color
sklib.__sklib__color_teal.argtypes = [  ]
sklib.__sklib__color_teal.restype = _sklib_color
sklib.__sklib__color_thistle.argtypes = [  ]
sklib.__sklib__color_thistle.restype = _sklib_color
sklib.__sklib__color_to_string__color.argtypes = [ _sklib_color ]
sklib.__sklib__color_to_string__color.restype = _sklib_string
sklib.__sklib__color_tomato.argtypes = [  ]
sklib.__sklib__color_tomato.restype = _sklib_color
sklib.__sklib__color_transparent.argtypes = [  ]
sklib.__sklib__color_transparent.restype = _sklib_color
sklib.__sklib__color_turquoise.argtypes = [  ]
sklib.__sklib__color_turquoise.restype = _sklib_color
sklib.__sklib__color_violet.argtypes = [  ]
sklib.__sklib__color_violet.restype = _sklib_color
sklib.__sklib__color_wheat.argtypes = [  ]
sklib.__sklib__color_wheat.restype = _sklib_color
sklib.__sklib__color_white.argtypes = [  ]
sklib.__sklib__color_white.restype = _sklib_color
sklib.__sklib__color_white_smoke.argtypes = [  ]
sklib.__sklib__color_white_smoke.restype = _sklib_color
sklib.__sklib__color_yellow.argtypes = [  ]
sklib.__sklib__color_yellow.restype = _sklib_color
sklib.__sklib__color_yellow_green.argtypes = [  ]
sklib.__sklib__color_yellow_green.restype = _sklib_color
sklib.__sklib__green_of__color.argtypes = [ _sklib_color ]
sklib.__sklib__green_of__color.restype = c_int
sklib.__sklib__hsb_color__double__double__double.argtypes = [ c_double, c_double, c_double ]
sklib.__sklib__hsb_color__double__double__double.restype = _sklib_color
sklib.__sklib__hue_of__color.argtypes = [ _sklib_color ]
sklib.__sklib__hue_of__color.restype = c_double
sklib.__sklib__random_color.argtypes = [  ]
sklib.__sklib__random_color.restype = _sklib_color
sklib.__sklib__random_rgb_color__int.argtypes = [ c_int ]
sklib.__sklib__random_rgb_color__int.restype = _sklib_color
sklib.__sklib__red_of__color.argtypes = [ _sklib_color ]
sklib.__sklib__red_of__color.restype = c_int
sklib.__sklib__rgb_color__double__double__double.argtypes = [ c_double, c_double, c_double ]
sklib.__sklib__rgb_color__double__double__double.restype = _sklib_color
sklib.__sklib__rgb_color__int__int__int.argtypes = [ c_int, c_int, c_int ]
sklib.__sklib__rgb_color__int__int__int.restype = _sklib_color
sklib.__sklib__rgba_color__double__double__double__double.argtypes = [ c_double, c_double, c_double, c_double ]
sklib.__sklib__rgba_color__double__double__double__double.restype = _sklib_color
sklib.__sklib__rgba_color__int__int__int__int.argtypes = [ c_int, c_int, c_int, c_int ]
sklib.__sklib__rgba_color__int__int__int__int.restype = _sklib_color
sklib.__sklib__saturation_of__color.argtypes = [ _sklib_color ]
sklib.__sklib__saturation_of__color.restype = c_double
sklib.__sklib__string_to_color__string.argtypes = [ _sklib_string ]
sklib.__sklib__string_to_color__string.restype = _sklib_color
sklib.__sklib__option_defaults.argtypes = [  ]
sklib.__sklib__option_defaults.restype = _sklib_drawing_options
sklib.__sklib__option_draw_to__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__option_draw_to__bitmap.restype = _sklib_drawing_options
sklib.__sklib__option_draw_to__bitmap__drawing_options.argtypes = [ c_void_p, _sklib_drawing_options ]
sklib.__sklib__option_draw_to__bitmap__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_draw_to__window.argtypes = [ c_void_p ]
sklib.__sklib__option_draw_to__window.restype = _sklib_drawing_options
sklib.__sklib__option_draw_to__window__drawing_options.argtypes = [ c_void_p, _sklib_drawing_options ]
sklib.__sklib__option_draw_to__window__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_flip_x.argtypes = [  ]
sklib.__sklib__option_flip_x.restype = _sklib_drawing_options
sklib.__sklib__option_flip_x__drawing_options.argtypes = [ _sklib_drawing_options ]
sklib.__sklib__option_flip_x__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_flip_xy.argtypes = [  ]
sklib.__sklib__option_flip_xy.restype = _sklib_drawing_options
sklib.__sklib__option_flip_xy__drawing_options.argtypes = [ _sklib_drawing_options ]
sklib.__sklib__option_flip_xy__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_flip_y.argtypes = [  ]
sklib.__sklib__option_flip_y.restype = _sklib_drawing_options
sklib.__sklib__option_flip_y__drawing_options.argtypes = [ _sklib_drawing_options ]
sklib.__sklib__option_flip_y__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_line_width__int.argtypes = [ c_int ]
sklib.__sklib__option_line_width__int.restype = _sklib_drawing_options
sklib.__sklib__option_line_width__int__drawing_options.argtypes = [ c_int, _sklib_drawing_options ]
sklib.__sklib__option_line_width__int__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_part_bmp__double__double__double__double.argtypes = [ c_double, c_double, c_double, c_double ]
sklib.__sklib__option_part_bmp__double__double__double__double.restype = _sklib_drawing_options
sklib.__sklib__option_part_bmp__double__double__double__double__drawing_options.argtypes = [ c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__option_part_bmp__double__double__double__double__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_part_bmp__rectangle.argtypes = [ _sklib_rectangle ]
sklib.__sklib__option_part_bmp__rectangle.restype = _sklib_drawing_options
sklib.__sklib__option_part_bmp__rectangle__drawing_options.argtypes = [ _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__option_part_bmp__rectangle__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_rotate_bmp__double.argtypes = [ c_double ]
sklib.__sklib__option_rotate_bmp__double.restype = _sklib_drawing_options
sklib.__sklib__option_rotate_bmp__double__double__double.argtypes = [ c_double, c_double, c_double ]
sklib.__sklib__option_rotate_bmp__double__double__double.restype = _sklib_drawing_options
sklib.__sklib__option_rotate_bmp__double__double__double__drawing_options.argtypes = [ c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__option_rotate_bmp__double__double__double__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_rotate_bmp__double__drawing_options.argtypes = [ c_double, _sklib_drawing_options ]
sklib.__sklib__option_rotate_bmp__double__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_scale_bmp__double__double.argtypes = [ c_double, c_double ]
sklib.__sklib__option_scale_bmp__double__double.restype = _sklib_drawing_options
sklib.__sklib__option_scale_bmp__double__double__drawing_options.argtypes = [ c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__option_scale_bmp__double__double__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_to_screen.argtypes = [  ]
sklib.__sklib__option_to_screen.restype = _sklib_drawing_options
sklib.__sklib__option_to_screen__drawing_options.argtypes = [ _sklib_drawing_options ]
sklib.__sklib__option_to_screen__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_to_world.argtypes = [  ]
sklib.__sklib__option_to_world.restype = _sklib_drawing_options
sklib.__sklib__option_to_world__drawing_options.argtypes = [ _sklib_drawing_options ]
sklib.__sklib__option_to_world__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_with_animation__animation.argtypes = [ c_void_p ]
sklib.__sklib__option_with_animation__animation.restype = _sklib_drawing_options
sklib.__sklib__option_with_animation__animation__drawing_options.argtypes = [ c_void_p, _sklib_drawing_options ]
sklib.__sklib__option_with_animation__animation__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__option_with_bitmap_cell__int.argtypes = [ c_int ]
sklib.__sklib__option_with_bitmap_cell__int.restype = _sklib_drawing_options
sklib.__sklib__option_with_bitmap_cell__int__drawing_options.argtypes = [ c_int, _sklib_drawing_options ]
sklib.__sklib__option_with_bitmap_cell__int__drawing_options.restype = _sklib_drawing_options
sklib.__sklib__draw_ellipse__color__rectangle.argtypes = [ _sklib_color, _sklib_rectangle ]
sklib.__sklib__draw_ellipse__color__rectangle.restype = None
sklib.__sklib__draw_ellipse__color__rectangle__drawing_options.argtypes = [ _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__draw_ellipse__color__rectangle__drawing_options.restype = None
sklib.__sklib__draw_ellipse__color__double__double__double__double.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_ellipse__color__double__double__double__double.restype = None
sklib.__sklib__draw_ellipse__color__double__double__double__double__drawing_options.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_ellipse__color__double__double__double__double__drawing_options.restype = None
sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle ]
sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle.restype = None
sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options.restype = None
sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double.restype = None
sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options.restype = None
sklib.__sklib__draw_ellipse_on_window__window__color__rectangle.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle ]
sklib.__sklib__draw_ellipse_on_window__window__color__rectangle.restype = None
sklib.__sklib__draw_ellipse_on_window__window__color__rectangle__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__draw_ellipse_on_window__window__color__rectangle__drawing_options.restype = None
sklib.__sklib__draw_ellipse_on_window__window__color__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_ellipse_on_window__window__color__double__double__double__double.restype = None
sklib.__sklib__draw_ellipse_on_window__window__color__double__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_ellipse_on_window__window__color__double__double__double__double__drawing_options.restype = None
sklib.__sklib__fill_ellipse__color__rectangle.argtypes = [ _sklib_color, _sklib_rectangle ]
sklib.__sklib__fill_ellipse__color__rectangle.restype = None
sklib.__sklib__fill_ellipse__color__rectangle__drawing_options.argtypes = [ _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__fill_ellipse__color__rectangle__drawing_options.restype = None
sklib.__sklib__fill_ellipse__color__double__double__double__double.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__fill_ellipse__color__double__double__double__double.restype = None
sklib.__sklib__fill_ellipse__color__double__double__double__double__drawing_options.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_ellipse__color__double__double__double__double__drawing_options.restype = None
sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle ]
sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle.restype = None
sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options.restype = None
sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double.restype = None
sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options.restype = None
sklib.__sklib__fill_ellipse_on_window__window__color__rectangle.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle ]
sklib.__sklib__fill_ellipse_on_window__window__color__rectangle.restype = None
sklib.__sklib__fill_ellipse_on_window__window__color__rectangle__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__fill_ellipse_on_window__window__color__rectangle__drawing_options.restype = None
sklib.__sklib__fill_ellipse_on_window__window__color__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__fill_ellipse_on_window__window__color__double__double__double__double.restype = None
sklib.__sklib__fill_ellipse_on_window__window__color__double__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_ellipse_on_window__window__color__double__double__double__double__drawing_options.restype = None
sklib.__sklib__cosine__float.argtypes = [ c_float ]
sklib.__sklib__cosine__float.restype = c_float
sklib.__sklib__sine__float.argtypes = [ c_float ]
sklib.__sklib__sine__float.restype = c_float
sklib.__sklib__tangent__float.argtypes = [ c_float ]
sklib.__sklib__tangent__float.restype = c_float
sklib.__sklib__clear_screen.argtypes = [  ]
sklib.__sklib__clear_screen.restype = None
sklib.__sklib__clear_screen__color.argtypes = [ _sklib_color ]
sklib.__sklib__clear_screen__color.restype = None
sklib.__sklib__display_details__unsigned_int.argtypes = [ c_uint ]
sklib.__sklib__display_details__unsigned_int.restype = c_void_p
sklib.__sklib__display_height__display.argtypes = [ c_void_p ]
sklib.__sklib__display_height__display.restype = c_int
sklib.__sklib__display_name__display.argtypes = [ c_void_p ]
sklib.__sklib__display_name__display.restype = _sklib_string
sklib.__sklib__display_width__display.argtypes = [ c_void_p ]
sklib.__sklib__display_width__display.restype = c_int
sklib.__sklib__display_x__display.argtypes = [ c_void_p ]
sklib.__sklib__display_x__display.restype = c_int
sklib.__sklib__display_y__display.argtypes = [ c_void_p ]
sklib.__sklib__display_y__display.restype = c_int
sklib.__sklib__number_of_displays.argtypes = [  ]
sklib.__sklib__number_of_displays.restype = c_int
sklib.__sklib__refresh_screen.argtypes = [  ]
sklib.__sklib__refresh_screen.restype = None
sklib.__sklib__refresh_screen__unsigned_int.argtypes = [ c_uint ]
sklib.__sklib__refresh_screen__unsigned_int.restype = None
sklib.__sklib__save_bitmap__bitmap__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__save_bitmap__bitmap__string_ref.restype = None
sklib.__sklib__screen_height.argtypes = [  ]
sklib.__sklib__screen_height.restype = c_int
sklib.__sklib__screen_width.argtypes = [  ]
sklib.__sklib__screen_width.restype = c_int
sklib.__sklib__take_screenshot__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__take_screenshot__string_ref.restype = None
sklib.__sklib__take_screenshot__window__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__take_screenshot__window__string_ref.restype = None
sklib.__sklib__bitmap_bounding_circle__bitmap__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__bitmap_bounding_circle__bitmap__point_2d_ref.restype = _sklib_circle
sklib.__sklib__bitmap_bounding_rectangle__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_bounding_rectangle__bitmap.restype = _sklib_rectangle
sklib.__sklib__bitmap_bounding_rectangle__bitmap__double__double.argtypes = [ c_void_p, c_double, c_double ]
sklib.__sklib__bitmap_bounding_rectangle__bitmap__double__double.restype = _sklib_rectangle
sklib.__sklib__bitmap_cell_center__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_cell_center__bitmap.restype = _sklib_point_2d
sklib.__sklib__bitmap_cell_circle__bitmap__double__double.argtypes = [ c_void_p, c_double, c_double ]
sklib.__sklib__bitmap_cell_circle__bitmap__double__double.restype = _sklib_circle
sklib.__sklib__bitmap_cell_circle__bitmap__point_2d.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__bitmap_cell_circle__bitmap__point_2d.restype = _sklib_circle
sklib.__sklib__bitmap_cell_circle__bitmap__point_2d__double.argtypes = [ c_void_p, _sklib_point_2d, c_double ]
sklib.__sklib__bitmap_cell_circle__bitmap__point_2d__double.restype = _sklib_circle
sklib.__sklib__bitmap_cell_columns__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_cell_columns__bitmap.restype = c_int
sklib.__sklib__bitmap_cell_count__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_cell_count__bitmap.restype = c_int
sklib.__sklib__bitmap_cell_height__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_cell_height__bitmap.restype = c_int
sklib.__sklib__bitmap_cell_offset__bitmap__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__bitmap_cell_offset__bitmap__int.restype = _sklib_vector_2d
sklib.__sklib__bitmap_cell_rectangle__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_cell_rectangle__bitmap.restype = _sklib_rectangle
sklib.__sklib__bitmap_cell_rectangle__bitmap__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__bitmap_cell_rectangle__bitmap__point_2d_ref.restype = _sklib_rectangle
sklib.__sklib__bitmap_cell_rows__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_cell_rows__bitmap.restype = c_int
sklib.__sklib__bitmap_cell_width__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_cell_width__bitmap.restype = c_int
sklib.__sklib__bitmap_center__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_center__bitmap.restype = _sklib_point_2d
sklib.__sklib__bitmap_filename__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_filename__bitmap.restype = _sklib_string
sklib.__sklib__bitmap_height__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_height__bitmap.restype = c_int
sklib.__sklib__bitmap_height__string.argtypes = [ _sklib_string ]
sklib.__sklib__bitmap_height__string.restype = c_int
sklib.__sklib__bitmap_name__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_name__bitmap.restype = _sklib_string
sklib.__sklib__bitmap_named__string.argtypes = [ _sklib_string ]
sklib.__sklib__bitmap_named__string.restype = c_void_p
sklib.__sklib__bitmap_rectangle_of_cell__bitmap__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__bitmap_rectangle_of_cell__bitmap__int.restype = _sklib_rectangle
sklib.__sklib__bitmap_set_cell_details__bitmap__int__int__int__int__int.argtypes = [ c_void_p, c_int, c_int, c_int, c_int, c_int ]
sklib.__sklib__bitmap_set_cell_details__bitmap__int__int__int__int__int.restype = None
sklib.__sklib__bitmap_valid__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_valid__bitmap.restype = c_bool
sklib.__sklib__bitmap_width__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_width__bitmap.restype = c_int
sklib.__sklib__bitmap_width__string.argtypes = [ _sklib_string ]
sklib.__sklib__bitmap_width__string.restype = c_int
sklib.__sklib__clear_bitmap__bitmap__color.argtypes = [ c_void_p, _sklib_color ]
sklib.__sklib__clear_bitmap__bitmap__color.restype = None
sklib.__sklib__clear_bitmap__string__color.argtypes = [ _sklib_string, _sklib_color ]
sklib.__sklib__clear_bitmap__string__color.restype = None
sklib.__sklib__create_bitmap__string__int__int.argtypes = [ _sklib_string, c_int, c_int ]
sklib.__sklib__create_bitmap__string__int__int.restype = c_void_p
sklib.__sklib__draw_bitmap__bitmap__double__double.argtypes = [ c_void_p, c_double, c_double ]
sklib.__sklib__draw_bitmap__bitmap__double__double.restype = None
sklib.__sklib__draw_bitmap__bitmap__double__double__drawing_options.argtypes = [ c_void_p, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_bitmap__bitmap__double__double__drawing_options.restype = None
sklib.__sklib__draw_bitmap__string__double__double.argtypes = [ _sklib_string, c_double, c_double ]
sklib.__sklib__draw_bitmap__string__double__double.restype = None
sklib.__sklib__draw_bitmap__string__double__double__drawing_options.argtypes = [ _sklib_string, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_bitmap__string__double__double__drawing_options.restype = None
sklib.__sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double.argtypes = [ c_void_p, c_void_p, c_double, c_double ]
sklib.__sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double.restype = None
sklib.__sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double__drawing_options.argtypes = [ c_void_p, c_void_p, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double__drawing_options.restype = None
sklib.__sklib__draw_bitmap_on_window__window__bitmap__double__double.argtypes = [ c_void_p, c_void_p, c_double, c_double ]
sklib.__sklib__draw_bitmap_on_window__window__bitmap__double__double.restype = None
sklib.__sklib__draw_bitmap_on_window__window__bitmap__double__double__drawing_options.argtypes = [ c_void_p, c_void_p, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_bitmap_on_window__window__bitmap__double__double__drawing_options.restype = None
sklib.__sklib__free_all_bitmaps.argtypes = [  ]
sklib.__sklib__free_all_bitmaps.restype = None
sklib.__sklib__free_bitmap__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__free_bitmap__bitmap.restype = None
sklib.__sklib__has_bitmap__string.argtypes = [ _sklib_string ]
sklib.__sklib__has_bitmap__string.restype = c_bool
sklib.__sklib__load_bitmap__string__string.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__load_bitmap__string__string.restype = c_void_p
sklib.__sklib__pixel_drawn_at_point__bitmap__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__pixel_drawn_at_point__bitmap__point_2d_ref.restype = c_bool
sklib.__sklib__pixel_drawn_at_point__bitmap__double__double.argtypes = [ c_void_p, c_double, c_double ]
sklib.__sklib__pixel_drawn_at_point__bitmap__double__double.restype = c_bool
sklib.__sklib__pixel_drawn_at_point__bitmap__int__point_2d_ref.argtypes = [ c_void_p, c_int, _sklib_point_2d ]
sklib.__sklib__pixel_drawn_at_point__bitmap__int__point_2d_ref.restype = c_bool
sklib.__sklib__pixel_drawn_at_point__bitmap__int__double__double.argtypes = [ c_void_p, c_int, c_double, c_double ]
sklib.__sklib__pixel_drawn_at_point__bitmap__int__double__double.restype = c_bool
sklib.__sklib__setup_collision_mask__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__setup_collision_mask__bitmap.restype = None
sklib.__sklib__process_events.argtypes = [  ]
sklib.__sklib__process_events.restype = None
sklib.__sklib__quit_requested.argtypes = [  ]
sklib.__sklib__quit_requested.restype = c_bool
sklib.__sklib__reset_quit.argtypes = [  ]
sklib.__sklib__reset_quit.restype = None
sklib.__sklib__add_column__int.argtypes = [ c_int ]
sklib.__sklib__add_column__int.restype = None
sklib.__sklib__add_column_relative__double.argtypes = [ c_double ]
sklib.__sklib__add_column_relative__double.restype = None
sklib.__sklib__bitmap_button__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__bitmap_button__bitmap.restype = c_bool
sklib.__sklib__bitmap_button__bitmap__rectangle_ref.argtypes = [ c_void_p, _sklib_rectangle ]
sklib.__sklib__bitmap_button__bitmap__rectangle_ref.restype = c_bool
sklib.__sklib__bitmap_button__bitmap__rectangle_ref__drawing_options.argtypes = [ c_void_p, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__bitmap_button__bitmap__rectangle_ref__drawing_options.restype = c_bool
sklib.__sklib__bitmap_button__bitmap__drawing_options.argtypes = [ c_void_p, _sklib_drawing_options ]
sklib.__sklib__bitmap_button__bitmap__drawing_options.restype = c_bool
sklib.__sklib__bitmap_button__string_ref__bitmap.argtypes = [ _sklib_string, c_void_p ]
sklib.__sklib__bitmap_button__string_ref__bitmap.restype = c_bool
sklib.__sklib__bitmap_button__string_ref__bitmap__drawing_options.argtypes = [ _sklib_string, c_void_p, _sklib_drawing_options ]
sklib.__sklib__bitmap_button__string_ref__bitmap__drawing_options.restype = c_bool
sklib.__sklib__button__string_ref__rectangle_ref.argtypes = [ _sklib_string, _sklib_rectangle ]
sklib.__sklib__button__string_ref__rectangle_ref.restype = c_bool
sklib.__sklib__button__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__button__string_ref.restype = c_bool
sklib.__sklib__button__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__button__string_ref__string_ref.restype = c_bool
sklib.__sklib__checkbox__string_ref__bool_ref__rectangle_ref.argtypes = [ _sklib_string, c_bool, _sklib_rectangle ]
sklib.__sklib__checkbox__string_ref__bool_ref__rectangle_ref.restype = c_bool
sklib.__sklib__checkbox__string_ref__bool_ref.argtypes = [ _sklib_string, c_bool ]
sklib.__sklib__checkbox__string_ref__bool_ref.restype = c_bool
sklib.__sklib__checkbox__string_ref__string_ref__bool_ref.argtypes = [ _sklib_string, _sklib_string, c_bool ]
sklib.__sklib__checkbox__string_ref__string_ref__bool_ref.restype = c_bool
sklib.__sklib__color_slider__color_ref__rectangle_ref.argtypes = [ _sklib_color, _sklib_rectangle ]
sklib.__sklib__color_slider__color_ref__rectangle_ref.restype = _sklib_color
sklib.__sklib__color_slider__color_ref.argtypes = [ _sklib_color ]
sklib.__sklib__color_slider__color_ref.restype = _sklib_color
sklib.__sklib__color_slider__string_ref__color_ref.argtypes = [ _sklib_string, _sklib_color ]
sklib.__sklib__color_slider__string_ref__color_ref.restype = _sklib_color
sklib.__sklib__disable_interface.argtypes = [  ]
sklib.__sklib__disable_interface.restype = None
sklib.__sklib__draw_interface.argtypes = [  ]
sklib.__sklib__draw_interface.restype = None
sklib.__sklib__enable_interface.argtypes = [  ]
sklib.__sklib__enable_interface.restype = None
sklib.__sklib__end_inset__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__end_inset__string_ref.restype = None
sklib.__sklib__end_panel__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__end_panel__string_ref.restype = None
sklib.__sklib__end_popup__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__end_popup__string_ref.restype = None
sklib.__sklib__end_treenode__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__end_treenode__string_ref.restype = None
sklib.__sklib__enter_column.argtypes = [  ]
sklib.__sklib__enter_column.restype = None
sklib.__sklib__get_interface_label_width.argtypes = [  ]
sklib.__sklib__get_interface_label_width.restype = c_int
sklib.__sklib__header__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__header__string_ref.restype = c_bool
sklib.__sklib__hsb_color_slider__color_ref__rectangle_ref.argtypes = [ _sklib_color, _sklib_rectangle ]
sklib.__sklib__hsb_color_slider__color_ref__rectangle_ref.restype = _sklib_color
sklib.__sklib__hsb_color_slider__color_ref.argtypes = [ _sklib_color ]
sklib.__sklib__hsb_color_slider__color_ref.restype = _sklib_color
sklib.__sklib__hsb_color_slider__string_ref__color_ref.argtypes = [ _sklib_string, _sklib_color ]
sklib.__sklib__hsb_color_slider__string_ref__color_ref.restype = _sklib_color
sklib.__sklib__interface_enabled.argtypes = [  ]
sklib.__sklib__interface_enabled.restype = c_bool
sklib.__sklib__interface_style_panel__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__interface_style_panel__rectangle_ref.restype = None
sklib.__sklib__label_element__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__label_element__string_ref.restype = None
sklib.__sklib__label_element__string_ref__rectangle_ref.argtypes = [ _sklib_string, _sklib_rectangle ]
sklib.__sklib__label_element__string_ref__rectangle_ref.restype = None
sklib.__sklib__last_element_changed.argtypes = [  ]
sklib.__sklib__last_element_changed.restype = c_bool
sklib.__sklib__last_element_confirmed.argtypes = [  ]
sklib.__sklib__last_element_confirmed.restype = c_bool
sklib.__sklib__leave_column.argtypes = [  ]
sklib.__sklib__leave_column.restype = None
sklib.__sklib__number_box__float_ref__float__rectangle_ref.argtypes = [ c_float, c_float, _sklib_rectangle ]
sklib.__sklib__number_box__float_ref__float__rectangle_ref.restype = c_float
sklib.__sklib__number_box__float_ref__float.argtypes = [ c_float, c_float ]
sklib.__sklib__number_box__float_ref__float.restype = c_float
sklib.__sklib__number_box__string_ref__float_ref__float.argtypes = [ _sklib_string, c_float, c_float ]
sklib.__sklib__number_box__string_ref__float_ref__float.restype = c_float
sklib.__sklib__open_popup__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__open_popup__string_ref.restype = None
sklib.__sklib__paragraph__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__paragraph__string_ref.restype = None
sklib.__sklib__paragraph__string_ref__rectangle_ref.argtypes = [ _sklib_string, _sklib_rectangle ]
sklib.__sklib__paragraph__string_ref__rectangle_ref.restype = None
sklib.__sklib__reset_layout.argtypes = [  ]
sklib.__sklib__reset_layout.restype = None
sklib.__sklib__set_interface_accent_color__color__float.argtypes = [ _sklib_color, c_float ]
sklib.__sklib__set_interface_accent_color__color__float.restype = None
sklib.__sklib__set_interface_border_color__color.argtypes = [ _sklib_color ]
sklib.__sklib__set_interface_border_color__color.restype = None
sklib.__sklib__set_interface_colors_auto__color__color__float__float__float.argtypes = [ _sklib_color, _sklib_color, c_float, c_float, c_float ]
sklib.__sklib__set_interface_colors_auto__color__color__float__float__float.restype = None
sklib.__sklib__set_interface_element_color__color__float.argtypes = [ _sklib_color, c_float ]
sklib.__sklib__set_interface_element_color__color__float.restype = None
sklib.__sklib__set_interface_element_shadows__int__color__point_2d.argtypes = [ c_int, _sklib_color, _sklib_point_2d ]
sklib.__sklib__set_interface_element_shadows__int__color__point_2d.restype = None
sklib.__sklib__set_interface_font__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__set_interface_font__string_ref.restype = None
sklib.__sklib__set_interface_font__font.argtypes = [ c_void_p ]
sklib.__sklib__set_interface_font__font.restype = None
sklib.__sklib__set_interface_font_size__int.argtypes = [ c_int ]
sklib.__sklib__set_interface_font_size__int.restype = None
sklib.__sklib__set_interface_label_width__int.argtypes = [ c_int ]
sklib.__sklib__set_interface_label_width__int.restype = None
sklib.__sklib__set_interface_panel_shadows__int__color__point_2d.argtypes = [ c_int, _sklib_color, _sklib_point_2d ]
sklib.__sklib__set_interface_panel_shadows__int__color__point_2d.restype = None
sklib.__sklib__set_interface_root_text_color__color.argtypes = [ _sklib_color ]
sklib.__sklib__set_interface_root_text_color__color.restype = None
sklib.__sklib__set_interface_shadows__int__color__point_2d.argtypes = [ c_int, _sklib_color, _sklib_point_2d ]
sklib.__sklib__set_interface_shadows__int__color__point_2d.restype = None
sklib.__sklib__set_interface_spacing__int__int.argtypes = [ c_int, c_int ]
sklib.__sklib__set_interface_spacing__int__int.restype = None
sklib.__sklib__set_interface_style__interface_style.argtypes = [ c_int ]
sklib.__sklib__set_interface_style__interface_style.restype = None
sklib.__sklib__set_interface_style__interface_style__color.argtypes = [ c_int, _sklib_color ]
sklib.__sklib__set_interface_style__interface_style__color.restype = None
sklib.__sklib__set_interface_text_color__color.argtypes = [ _sklib_color ]
sklib.__sklib__set_interface_text_color__color.restype = None
sklib.__sklib__set_layout_height__int.argtypes = [ c_int ]
sklib.__sklib__set_layout_height__int.restype = None
sklib.__sklib__single_line_layout.argtypes = [  ]
sklib.__sklib__single_line_layout.restype = None
sklib.__sklib__slider__float_ref__float__float__rectangle_ref.argtypes = [ c_float, c_float, c_float, _sklib_rectangle ]
sklib.__sklib__slider__float_ref__float__float__rectangle_ref.restype = c_float
sklib.__sklib__slider__float_ref__float__float.argtypes = [ c_float, c_float, c_float ]
sklib.__sklib__slider__float_ref__float__float.restype = c_float
sklib.__sklib__slider__string_ref__float_ref__float__float.argtypes = [ _sklib_string, c_float, c_float, c_float ]
sklib.__sklib__slider__string_ref__float_ref__float__float.restype = c_float
sklib.__sklib__split_into_columns__int.argtypes = [ c_int ]
sklib.__sklib__split_into_columns__int.restype = None
sklib.__sklib__split_into_columns__int__int.argtypes = [ c_int, c_int ]
sklib.__sklib__split_into_columns__int__int.restype = None
sklib.__sklib__split_into_columns_relative__int__double.argtypes = [ c_int, c_double ]
sklib.__sklib__split_into_columns_relative__int__double.restype = None
sklib.__sklib__start_custom_layout.argtypes = [  ]
sklib.__sklib__start_custom_layout.restype = None
sklib.__sklib__start_inset__string_ref__rectangle_ref.argtypes = [ _sklib_string, _sklib_rectangle ]
sklib.__sklib__start_inset__string_ref__rectangle_ref.restype = None
sklib.__sklib__start_inset__string_ref__int.argtypes = [ _sklib_string, c_int ]
sklib.__sklib__start_inset__string_ref__int.restype = None
sklib.__sklib__start_panel__string_ref__rectangle.argtypes = [ _sklib_string, _sklib_rectangle ]
sklib.__sklib__start_panel__string_ref__rectangle.restype = c_bool
sklib.__sklib__start_popup__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__start_popup__string_ref.restype = c_bool
sklib.__sklib__start_treenode__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__start_treenode__string_ref.restype = c_bool
sklib.__sklib__text_box__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__text_box__string_ref.restype = _sklib_string
sklib.__sklib__text_box__string_ref__rectangle_ref.argtypes = [ _sklib_string, _sklib_rectangle ]
sklib.__sklib__text_box__string_ref__rectangle_ref.restype = _sklib_string
sklib.__sklib__text_box__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__text_box__string_ref__string_ref.restype = _sklib_string
sklib.__sklib__create_json.argtypes = [  ]
sklib.__sklib__create_json.restype = c_void_p
sklib.__sklib__create_json__string.argtypes = [ _sklib_string ]
sklib.__sklib__create_json__string.restype = c_void_p
sklib.__sklib__free_all_json.argtypes = [  ]
sklib.__sklib__free_all_json.restype = None
sklib.__sklib__free_json__json.argtypes = [ c_void_p ]
sklib.__sklib__free_json__json.restype = None
sklib.__sklib__json_count_keys__json.argtypes = [ c_void_p ]
sklib.__sklib__json_count_keys__json.restype = c_int
sklib.__sklib__json_from_color__color.argtypes = [ _sklib_color ]
sklib.__sklib__json_from_color__color.restype = c_void_p
sklib.__sklib__json_from_file__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__json_from_file__string_ref.restype = c_void_p
sklib.__sklib__json_from_string__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__json_from_string__string_ref.restype = c_void_p
sklib.__sklib__json_has_key__json__string.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__json_has_key__json__string.restype = c_bool
sklib.__sklib__json_read_array__json__string__vector_double_ref.argtypes = [ c_void_p, _sklib_string, POINTER(_sklib_vector_double) ]
sklib.__sklib__json_read_array__json__string__vector_double_ref.restype = None
sklib.__sklib__json_read_array__json__string__vector_json_ref.argtypes = [ c_void_p, _sklib_string, POINTER(_sklib_vector_json) ]
sklib.__sklib__json_read_array__json__string__vector_json_ref.restype = None
sklib.__sklib__json_read_array__json__string__vector_string_ref.argtypes = [ c_void_p, _sklib_string, POINTER(_sklib_vector_string) ]
sklib.__sklib__json_read_array__json__string__vector_string_ref.restype = None
sklib.__sklib__json_read_array__json__string__vector_bool_ref.argtypes = [ c_void_p, _sklib_string, POINTER(_sklib_vector_bool) ]
sklib.__sklib__json_read_array__json__string__vector_bool_ref.restype = None
sklib.__sklib__json_read_bool__json__string.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__json_read_bool__json__string.restype = c_bool
sklib.__sklib__json_read_number__json__string.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__json_read_number__json__string.restype = c_float
sklib.__sklib__json_read_number_as_double__json__string.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__json_read_number_as_double__json__string.restype = c_double
sklib.__sklib__json_read_number_as_int__json__string.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__json_read_number_as_int__json__string.restype = c_int
sklib.__sklib__json_read_object__json__string.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__json_read_object__json__string.restype = c_void_p
sklib.__sklib__json_read_string__json__string.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__json_read_string__json__string.restype = _sklib_string
sklib.__sklib__json_set_array__json__string__vector_string.argtypes = [ c_void_p, _sklib_string, _sklib_vector_string ]
sklib.__sklib__json_set_array__json__string__vector_string.restype = None
sklib.__sklib__json_set_array__json__string__vector_double.argtypes = [ c_void_p, _sklib_string, _sklib_vector_double ]
sklib.__sklib__json_set_array__json__string__vector_double.restype = None
sklib.__sklib__json_set_array__json__string__vector_bool.argtypes = [ c_void_p, _sklib_string, _sklib_vector_bool ]
sklib.__sklib__json_set_array__json__string__vector_bool.restype = None
sklib.__sklib__json_set_array__json__string__vector_json.argtypes = [ c_void_p, _sklib_string, _sklib_vector_json ]
sklib.__sklib__json_set_array__json__string__vector_json.restype = None
sklib.__sklib__json_set_bool__json__string__bool.argtypes = [ c_void_p, _sklib_string, c_bool ]
sklib.__sklib__json_set_bool__json__string__bool.restype = None
sklib.__sklib__json_set_number__json__string__int.argtypes = [ c_void_p, _sklib_string, c_int ]
sklib.__sklib__json_set_number__json__string__int.restype = None
sklib.__sklib__json_set_number__json__string__double.argtypes = [ c_void_p, _sklib_string, c_double ]
sklib.__sklib__json_set_number__json__string__double.restype = None
sklib.__sklib__json_set_number__json__string__float.argtypes = [ c_void_p, _sklib_string, c_float ]
sklib.__sklib__json_set_number__json__string__float.restype = None
sklib.__sklib__json_set_object__json__string__json.argtypes = [ c_void_p, _sklib_string, c_void_p ]
sklib.__sklib__json_set_object__json__string__json.restype = None
sklib.__sklib__json_set_string__json__string__string.argtypes = [ c_void_p, _sklib_string, _sklib_string ]
sklib.__sklib__json_set_string__json__string__string.restype = None
sklib.__sklib__json_to_color__json.argtypes = [ c_void_p ]
sklib.__sklib__json_to_color__json.restype = _sklib_color
sklib.__sklib__json_to_file__json__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__json_to_file__json__string_ref.restype = None
sklib.__sklib__json_to_string__json.argtypes = [ c_void_p ]
sklib.__sklib__json_to_string__json.restype = _sklib_string
sklib.__sklib__any_key_pressed.argtypes = [  ]
sklib.__sklib__any_key_pressed.restype = c_bool
sklib.__sklib__deregister_callback_on_key_down__key_callback_ptr.argtypes = [ KeyCallback ]
sklib.__sklib__deregister_callback_on_key_down__key_callback_ptr.restype = None
sklib.__sklib__deregister_callback_on_key_typed__key_callback_ptr.argtypes = [ KeyCallback ]
sklib.__sklib__deregister_callback_on_key_typed__key_callback_ptr.restype = None
sklib.__sklib__deregister_callback_on_key_up__key_callback_ptr.argtypes = [ KeyCallback ]
sklib.__sklib__deregister_callback_on_key_up__key_callback_ptr.restype = None
sklib.__sklib__key_down__key_code.argtypes = [ c_int ]
sklib.__sklib__key_down__key_code.restype = c_bool
sklib.__sklib__key_name__key_code.argtypes = [ c_int ]
sklib.__sklib__key_name__key_code.restype = _sklib_string
sklib.__sklib__key_released__key_code.argtypes = [ c_int ]
sklib.__sklib__key_released__key_code.restype = c_bool
sklib.__sklib__key_typed__key_code.argtypes = [ c_int ]
sklib.__sklib__key_typed__key_code.restype = c_bool
sklib.__sklib__key_up__key_code.argtypes = [ c_int ]
sklib.__sklib__key_up__key_code.restype = c_bool
sklib.__sklib__register_callback_on_key_down__key_callback_ptr.argtypes = [ KeyCallback ]
sklib.__sklib__register_callback_on_key_down__key_callback_ptr.restype = None
sklib.__sklib__register_callback_on_key_typed__key_callback_ptr.argtypes = [ KeyCallback ]
sklib.__sklib__register_callback_on_key_typed__key_callback_ptr.restype = None
sklib.__sklib__register_callback_on_key_up__key_callback_ptr.argtypes = [ KeyCallback ]
sklib.__sklib__register_callback_on_key_up__key_callback_ptr.restype = None
sklib.__sklib__draw_line__color__line_ref.argtypes = [ _sklib_color, _sklib_line ]
sklib.__sklib__draw_line__color__line_ref.restype = None
sklib.__sklib__draw_line__color__line_ref__drawing_options.argtypes = [ _sklib_color, _sklib_line, _sklib_drawing_options ]
sklib.__sklib__draw_line__color__line_ref__drawing_options.restype = None
sklib.__sklib__draw_line__color__point_2d_ref__point_2d_ref.argtypes = [ _sklib_color, _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__draw_line__color__point_2d_ref__point_2d_ref.restype = None
sklib.__sklib__draw_line__color__point_2d_ref__point_2d_ref__drawing_options_ref.argtypes = [ _sklib_color, _sklib_point_2d, _sklib_point_2d, _sklib_drawing_options ]
sklib.__sklib__draw_line__color__point_2d_ref__point_2d_ref__drawing_options_ref.restype = None
sklib.__sklib__draw_line__color__double__double__double__double.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_line__color__double__double__double__double.restype = None
sklib.__sklib__draw_line__color__double__double__double__double__drawing_options_ref.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_line__color__double__double__double__double__drawing_options_ref.restype = None
sklib.__sklib__draw_line_on_bitmap__bitmap__color__line_ref.argtypes = [ c_void_p, _sklib_color, _sklib_line ]
sklib.__sklib__draw_line_on_bitmap__bitmap__color__line_ref.restype = None
sklib.__sklib__draw_line_on_bitmap__bitmap__color__line_ref__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_line, _sklib_drawing_options ]
sklib.__sklib__draw_line_on_bitmap__bitmap__color__line_ref__drawing_options.restype = None
sklib.__sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref.argtypes = [ c_void_p, _sklib_color, _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref.restype = None
sklib.__sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, _sklib_point_2d, _sklib_point_2d, _sklib_drawing_options ]
sklib.__sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref__drawing_options_ref.restype = None
sklib.__sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double.restype = None
sklib.__sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref.restype = None
sklib.__sklib__draw_line_on_window__window__color__line_ref.argtypes = [ c_void_p, _sklib_color, _sklib_line ]
sklib.__sklib__draw_line_on_window__window__color__line_ref.restype = None
sklib.__sklib__draw_line_on_window__window__color__line_ref__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_line, _sklib_drawing_options ]
sklib.__sklib__draw_line_on_window__window__color__line_ref__drawing_options.restype = None
sklib.__sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref.argtypes = [ c_void_p, _sklib_color, _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref.restype = None
sklib.__sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, _sklib_point_2d, _sklib_point_2d, _sklib_drawing_options ]
sklib.__sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref__drawing_options_ref.restype = None
sklib.__sklib__draw_line_on_window__window__color__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_line_on_window__window__color__double__double__double__double.restype = None
sklib.__sklib__draw_line_on_window__window__color__double__double__double__double__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_line_on_window__window__color__double__double__double__double__drawing_options_ref.restype = None
sklib.__sklib__closest_point_on_line__point_2d__line_ref.argtypes = [ _sklib_point_2d, _sklib_line ]
sklib.__sklib__closest_point_on_line__point_2d__line_ref.restype = _sklib_point_2d
sklib.__sklib__closest_point_on_lines__point_2d__vector_line_ref__int_ref.argtypes = [ _sklib_point_2d, _sklib_vector_line, POINTER(c_int) ]
sklib.__sklib__closest_point_on_lines__point_2d__vector_line_ref__int_ref.restype = _sklib_point_2d
sklib.__sklib__line_from__point_2d_ref__point_2d_ref.argtypes = [ _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__line_from__point_2d_ref__point_2d_ref.restype = _sklib_line
sklib.__sklib__line_from__point_2d_ref__vector_2d_ref.argtypes = [ _sklib_point_2d, _sklib_vector_2d ]
sklib.__sklib__line_from__point_2d_ref__vector_2d_ref.restype = _sklib_line
sklib.__sklib__line_from__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__line_from__vector_2d_ref.restype = _sklib_line
sklib.__sklib__line_from__double__double__double__double.argtypes = [ c_double, c_double, c_double, c_double ]
sklib.__sklib__line_from__double__double__double__double.restype = _sklib_line
sklib.__sklib__line_intersection_point__line_ref__line_ref__point_2d_ref.argtypes = [ _sklib_line, _sklib_line, POINTER(_sklib_point_2d) ]
sklib.__sklib__line_intersection_point__line_ref__line_ref__point_2d_ref.restype = c_bool
sklib.__sklib__line_intersects_circle__line_ref__circle_ref.argtypes = [ _sklib_line, _sklib_circle ]
sklib.__sklib__line_intersects_circle__line_ref__circle_ref.restype = c_bool
sklib.__sklib__line_intersects_lines__line_ref__vector_line_ref.argtypes = [ _sklib_line, _sklib_vector_line ]
sklib.__sklib__line_intersects_lines__line_ref__vector_line_ref.restype = c_bool
sklib.__sklib__line_intersects_rect__line_ref__rectangle_ref.argtypes = [ _sklib_line, _sklib_rectangle ]
sklib.__sklib__line_intersects_rect__line_ref__rectangle_ref.restype = c_bool
sklib.__sklib__line_length__line_ref.argtypes = [ _sklib_line ]
sklib.__sklib__line_length__line_ref.restype = c_float
sklib.__sklib__line_length_squared__line_ref.argtypes = [ _sklib_line ]
sklib.__sklib__line_length_squared__line_ref.restype = c_float
sklib.__sklib__line_mid_point__line_ref.argtypes = [ _sklib_line ]
sklib.__sklib__line_mid_point__line_ref.restype = _sklib_point_2d
sklib.__sklib__line_normal__line_ref.argtypes = [ _sklib_line ]
sklib.__sklib__line_normal__line_ref.restype = _sklib_vector_2d
sklib.__sklib__line_to_string__line_ref.argtypes = [ _sklib_line ]
sklib.__sklib__line_to_string__line_ref.restype = _sklib_string
sklib.__sklib__lines_from__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__lines_from__rectangle_ref.restype = _sklib_vector_line
sklib.__sklib__lines_from__triangle_ref.argtypes = [ _sklib_triangle ]
sklib.__sklib__lines_from__triangle_ref.restype = _sklib_vector_line
sklib.__sklib__lines_intersect__line_ref__line_ref.argtypes = [ _sklib_line, _sklib_line ]
sklib.__sklib__lines_intersect__line_ref__line_ref.restype = c_bool
sklib.__sklib__close_log_process.argtypes = [  ]
sklib.__sklib__close_log_process.restype = None
sklib.__sklib__init_custom_logger__log_mode.argtypes = [ c_int ]
sklib.__sklib__init_custom_logger__log_mode.restype = None
sklib.__sklib__init_custom_logger__string__bool__log_mode.argtypes = [ _sklib_string, c_bool, c_int ]
sklib.__sklib__init_custom_logger__string__bool__log_mode.restype = None
sklib.__sklib__log__log_level__string.argtypes = [ c_int, _sklib_string ]
sklib.__sklib__log__log_level__string.restype = None
sklib.__sklib__apply_matrix__matrix_2d_ref__quad_ref.argtypes = [ _sklib_matrix_2d, POINTER(_sklib_quad) ]
sklib.__sklib__apply_matrix__matrix_2d_ref__quad_ref.restype = None
sklib.__sklib__apply_matrix__matrix_2d_ref__triangle_ref.argtypes = [ _sklib_matrix_2d, POINTER(_sklib_triangle) ]
sklib.__sklib__apply_matrix__matrix_2d_ref__triangle_ref.restype = None
sklib.__sklib__identity_matrix.argtypes = [  ]
sklib.__sklib__identity_matrix.restype = _sklib_matrix_2d
sklib.__sklib__matrix_inverse__matrix_2d_ref.argtypes = [ _sklib_matrix_2d ]
sklib.__sklib__matrix_inverse__matrix_2d_ref.restype = _sklib_matrix_2d
sklib.__sklib__matrix_multiply__matrix_2d_ref__point_2d_ref.argtypes = [ _sklib_matrix_2d, _sklib_point_2d ]
sklib.__sklib__matrix_multiply__matrix_2d_ref__point_2d_ref.restype = _sklib_point_2d
sklib.__sklib__matrix_multiply__matrix_2d_ref__matrix_2d_ref.argtypes = [ _sklib_matrix_2d, _sklib_matrix_2d ]
sklib.__sklib__matrix_multiply__matrix_2d_ref__matrix_2d_ref.restype = _sklib_matrix_2d
sklib.__sklib__matrix_multiply__matrix_2d_ref__vector_2d_ref.argtypes = [ _sklib_matrix_2d, _sklib_vector_2d ]
sklib.__sklib__matrix_multiply__matrix_2d_ref__vector_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__matrix_to_string__matrix_2d_ref.argtypes = [ _sklib_matrix_2d ]
sklib.__sklib__matrix_to_string__matrix_2d_ref.restype = _sklib_string
sklib.__sklib__rotation_matrix__double.argtypes = [ c_double ]
sklib.__sklib__rotation_matrix__double.restype = _sklib_matrix_2d
sklib.__sklib__scale_matrix__point_2d_ref.argtypes = [ _sklib_point_2d ]
sklib.__sklib__scale_matrix__point_2d_ref.restype = _sklib_matrix_2d
sklib.__sklib__scale_matrix__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__scale_matrix__vector_2d_ref.restype = _sklib_matrix_2d
sklib.__sklib__scale_matrix__double.argtypes = [ c_double ]
sklib.__sklib__scale_matrix__double.restype = _sklib_matrix_2d
sklib.__sklib__scale_rotate_translate_matrix__point_2d_ref__double__point_2d_ref.argtypes = [ _sklib_point_2d, c_double, _sklib_point_2d ]
sklib.__sklib__scale_rotate_translate_matrix__point_2d_ref__double__point_2d_ref.restype = _sklib_matrix_2d
sklib.__sklib__translation_matrix__point_2d_ref.argtypes = [ _sklib_point_2d ]
sklib.__sklib__translation_matrix__point_2d_ref.restype = _sklib_matrix_2d
sklib.__sklib__translation_matrix__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__translation_matrix__vector_2d_ref.restype = _sklib_matrix_2d
sklib.__sklib__translation_matrix__double__double.argtypes = [ c_double, c_double ]
sklib.__sklib__translation_matrix__double__double.restype = _sklib_matrix_2d
sklib.__sklib__hide_mouse.argtypes = [  ]
sklib.__sklib__hide_mouse.restype = None
sklib.__sklib__mouse_clicked__mouse_button.argtypes = [ c_int ]
sklib.__sklib__mouse_clicked__mouse_button.restype = c_bool
sklib.__sklib__mouse_down__mouse_button.argtypes = [ c_int ]
sklib.__sklib__mouse_down__mouse_button.restype = c_bool
sklib.__sklib__mouse_movement.argtypes = [  ]
sklib.__sklib__mouse_movement.restype = _sklib_vector_2d
sklib.__sklib__mouse_position.argtypes = [  ]
sklib.__sklib__mouse_position.restype = _sklib_point_2d
sklib.__sklib__mouse_position_vector.argtypes = [  ]
sklib.__sklib__mouse_position_vector.restype = _sklib_vector_2d
sklib.__sklib__mouse_shown.argtypes = [  ]
sklib.__sklib__mouse_shown.restype = c_bool
sklib.__sklib__mouse_up__mouse_button.argtypes = [ c_int ]
sklib.__sklib__mouse_up__mouse_button.restype = c_bool
sklib.__sklib__mouse_wheel_scroll.argtypes = [  ]
sklib.__sklib__mouse_wheel_scroll.restype = _sklib_vector_2d
sklib.__sklib__mouse_x.argtypes = [  ]
sklib.__sklib__mouse_x.restype = c_float
sklib.__sklib__mouse_y.argtypes = [  ]
sklib.__sklib__mouse_y.restype = c_float
sklib.__sklib__move_mouse__double__double.argtypes = [ c_double, c_double ]
sklib.__sklib__move_mouse__double__double.restype = None
sklib.__sklib__move_mouse__point_2d.argtypes = [ _sklib_point_2d ]
sklib.__sklib__move_mouse__point_2d.restype = None
sklib.__sklib__show_mouse.argtypes = [  ]
sklib.__sklib__show_mouse.restype = None
sklib.__sklib__show_mouse__bool.argtypes = [ c_bool ]
sklib.__sklib__show_mouse__bool.restype = None
sklib.__sklib__fade_music_in__string_ref__int.argtypes = [ _sklib_string, c_int ]
sklib.__sklib__fade_music_in__string_ref__int.restype = None
sklib.__sklib__fade_music_in__string_ref__int__int.argtypes = [ _sklib_string, c_int, c_int ]
sklib.__sklib__fade_music_in__string_ref__int__int.restype = None
sklib.__sklib__fade_music_in__music__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__fade_music_in__music__int.restype = None
sklib.__sklib__fade_music_in__music__int__int.argtypes = [ c_void_p, c_int, c_int ]
sklib.__sklib__fade_music_in__music__int__int.restype = None
sklib.__sklib__fade_music_out__int.argtypes = [ c_int ]
sklib.__sklib__fade_music_out__int.restype = None
sklib.__sklib__free_all_music.argtypes = [  ]
sklib.__sklib__free_all_music.restype = None
sklib.__sklib__free_music__music.argtypes = [ c_void_p ]
sklib.__sklib__free_music__music.restype = None
sklib.__sklib__has_music__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__has_music__string_ref.restype = c_bool
sklib.__sklib__load_music__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__load_music__string_ref__string_ref.restype = c_void_p
sklib.__sklib__music_filename__music.argtypes = [ c_void_p ]
sklib.__sklib__music_filename__music.restype = _sklib_string
sklib.__sklib__music_name__music.argtypes = [ c_void_p ]
sklib.__sklib__music_name__music.restype = _sklib_string
sklib.__sklib__music_named__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__music_named__string_ref.restype = c_void_p
sklib.__sklib__music_playing.argtypes = [  ]
sklib.__sklib__music_playing.restype = c_bool
sklib.__sklib__music_valid__music.argtypes = [ c_void_p ]
sklib.__sklib__music_valid__music.restype = c_bool
sklib.__sklib__music_volume.argtypes = [  ]
sklib.__sklib__music_volume.restype = c_double
sklib.__sklib__pause_music.argtypes = [  ]
sklib.__sklib__pause_music.restype = None
sklib.__sklib__play_music__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__play_music__string_ref.restype = None
sklib.__sklib__play_music__string_ref__int.argtypes = [ _sklib_string, c_int ]
sklib.__sklib__play_music__string_ref__int.restype = None
sklib.__sklib__play_music__music.argtypes = [ c_void_p ]
sklib.__sklib__play_music__music.restype = None
sklib.__sklib__play_music__music__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__play_music__music__int.restype = None
sklib.__sklib__play_music__music__int__double.argtypes = [ c_void_p, c_int, c_double ]
sklib.__sklib__play_music__music__int__double.restype = None
sklib.__sklib__resume_music.argtypes = [  ]
sklib.__sklib__resume_music.restype = None
sklib.__sklib__set_music_volume__double.argtypes = [ c_double ]
sklib.__sklib__set_music_volume__double.restype = None
sklib.__sklib__stop_music.argtypes = [  ]
sklib.__sklib__stop_music.restype = None
sklib.__sklib__accept_all_new_connections.argtypes = [  ]
sklib.__sklib__accept_all_new_connections.restype = c_bool
sklib.__sklib__accept_new_connection__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__accept_new_connection__server_socket.restype = c_bool
sklib.__sklib__broadcast_message__string_ref__server_socket.argtypes = [ _sklib_string, c_void_p ]
sklib.__sklib__broadcast_message__string_ref__server_socket.restype = None
sklib.__sklib__broadcast_message__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__broadcast_message__string_ref.restype = None
sklib.__sklib__broadcast_message__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__broadcast_message__string_ref__string_ref.restype = None
sklib.__sklib__check_network_activity.argtypes = [  ]
sklib.__sklib__check_network_activity.restype = None
sklib.__sklib__clear_messages__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__clear_messages__string_ref.restype = None
sklib.__sklib__clear_messages__connection.argtypes = [ c_void_p ]
sklib.__sklib__clear_messages__connection.restype = None
sklib.__sklib__clear_messages__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__clear_messages__server_socket.restype = None
sklib.__sklib__close_all_connections.argtypes = [  ]
sklib.__sklib__close_all_connections.restype = None
sklib.__sklib__close_all_servers.argtypes = [  ]
sklib.__sklib__close_all_servers.restype = None
sklib.__sklib__close_connection__connection.argtypes = [ c_void_p ]
sklib.__sklib__close_connection__connection.restype = c_bool
sklib.__sklib__close_connection__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__close_connection__string_ref.restype = c_bool
sklib.__sklib__close_message__message.argtypes = [ c_void_p ]
sklib.__sklib__close_message__message.restype = None
sklib.__sklib__close_server__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__close_server__string_ref.restype = c_bool
sklib.__sklib__close_server__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__close_server__server_socket.restype = c_bool
sklib.__sklib__connection_count__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__connection_count__string_ref.restype = c_uint
sklib.__sklib__connection_count__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__connection_count__server_socket.restype = c_uint
sklib.__sklib__connection_ip__connection.argtypes = [ c_void_p ]
sklib.__sklib__connection_ip__connection.restype = c_uint
sklib.__sklib__connection_ip__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__connection_ip__string_ref.restype = c_uint
sklib.__sklib__connection_named__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__connection_named__string_ref.restype = c_void_p
sklib.__sklib__connection_port__connection.argtypes = [ c_void_p ]
sklib.__sklib__connection_port__connection.restype = c_ushort
sklib.__sklib__connection_port__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__connection_port__string_ref.restype = c_ushort
sklib.__sklib__create_server__string_ref__unsigned_short.argtypes = [ _sklib_string, c_ushort ]
sklib.__sklib__create_server__string_ref__unsigned_short.restype = c_void_p
sklib.__sklib__create_server__string_ref__unsigned_short__connection_type.argtypes = [ _sklib_string, c_ushort, c_int ]
sklib.__sklib__create_server__string_ref__unsigned_short__connection_type.restype = c_void_p
sklib.__sklib__dec_to_hex__unsigned_int.argtypes = [ c_uint ]
sklib.__sklib__dec_to_hex__unsigned_int.restype = _sklib_string
sklib.__sklib__fetch_new_connection__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__fetch_new_connection__server_socket.restype = c_void_p
sklib.__sklib__has_connection__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__has_connection__string_ref.restype = c_bool
sklib.__sklib__has_messages.argtypes = [  ]
sklib.__sklib__has_messages.restype = c_bool
sklib.__sklib__has_messages__connection.argtypes = [ c_void_p ]
sklib.__sklib__has_messages__connection.restype = c_bool
sklib.__sklib__has_messages__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__has_messages__string_ref.restype = c_bool
sklib.__sklib__has_messages__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__has_messages__server_socket.restype = c_bool
sklib.__sklib__has_new_connections.argtypes = [  ]
sklib.__sklib__has_new_connections.restype = c_bool
sklib.__sklib__has_server__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__has_server__string_ref.restype = c_bool
sklib.__sklib__hex_str_to_ipv4__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__hex_str_to_ipv4__string_ref.restype = _sklib_string
sklib.__sklib__hex_to_dec_string__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__hex_to_dec_string__string_ref.restype = _sklib_string
sklib.__sklib__ipv4_to_dec__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__ipv4_to_dec__string_ref.restype = c_uint
sklib.__sklib__ipv4_to_hex__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__ipv4_to_hex__string_ref.restype = _sklib_string
sklib.__sklib__ipv4_to_str__unsigned_int.argtypes = [ c_uint ]
sklib.__sklib__ipv4_to_str__unsigned_int.restype = _sklib_string
sklib.__sklib__is_connection_open__connection.argtypes = [ c_void_p ]
sklib.__sklib__is_connection_open__connection.restype = c_bool
sklib.__sklib__is_connection_open__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__is_connection_open__string_ref.restype = c_bool
sklib.__sklib__last_connection__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__last_connection__string_ref.restype = c_void_p
sklib.__sklib__last_connection__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__last_connection__server_socket.restype = c_void_p
sklib.__sklib__message_connection__message.argtypes = [ c_void_p ]
sklib.__sklib__message_connection__message.restype = c_void_p
sklib.__sklib__message_count__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__message_count__server_socket.restype = c_uint
sklib.__sklib__message_count__connection.argtypes = [ c_void_p ]
sklib.__sklib__message_count__connection.restype = c_uint
sklib.__sklib__message_count__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__message_count__string_ref.restype = c_uint
sklib.__sklib__message_data__message.argtypes = [ c_void_p ]
sklib.__sklib__message_data__message.restype = _sklib_string
sklib.__sklib__message_data_bytes__message.argtypes = [ c_void_p ]
sklib.__sklib__message_data_bytes__message.restype = _sklib_vector_int8_t
sklib.__sklib__message_host__message.argtypes = [ c_void_p ]
sklib.__sklib__message_host__message.restype = _sklib_string
sklib.__sklib__message_port__message.argtypes = [ c_void_p ]
sklib.__sklib__message_port__message.restype = c_ushort
sklib.__sklib__message_protocol__message.argtypes = [ c_void_p ]
sklib.__sklib__message_protocol__message.restype = c_int
sklib.__sklib__my_ip.argtypes = [  ]
sklib.__sklib__my_ip.restype = _sklib_string
sklib.__sklib__name_for_connection__string__unsigned_int.argtypes = [ _sklib_string, c_uint ]
sklib.__sklib__name_for_connection__string__unsigned_int.restype = _sklib_string
sklib.__sklib__new_connection_count__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__new_connection_count__server_socket.restype = c_int
sklib.__sklib__open_connection__string_ref__string_ref__unsigned_short.argtypes = [ _sklib_string, _sklib_string, c_ushort ]
sklib.__sklib__open_connection__string_ref__string_ref__unsigned_short.restype = c_void_p
sklib.__sklib__open_connection__string_ref__string_ref__unsigned_short__connection_type.argtypes = [ _sklib_string, _sklib_string, c_ushort, c_int ]
sklib.__sklib__open_connection__string_ref__string_ref__unsigned_short__connection_type.restype = c_void_p
sklib.__sklib__read_message.argtypes = [  ]
sklib.__sklib__read_message.restype = c_void_p
sklib.__sklib__read_message__connection.argtypes = [ c_void_p ]
sklib.__sklib__read_message__connection.restype = c_void_p
sklib.__sklib__read_message__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__read_message__string_ref.restype = c_void_p
sklib.__sklib__read_message__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__read_message__server_socket.restype = c_void_p
sklib.__sklib__read_message_data__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__read_message_data__string_ref.restype = _sklib_string
sklib.__sklib__read_message_data__connection.argtypes = [ c_void_p ]
sklib.__sklib__read_message_data__connection.restype = _sklib_string
sklib.__sklib__read_message_data__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__read_message_data__server_socket.restype = _sklib_string
sklib.__sklib__reconnect__connection.argtypes = [ c_void_p ]
sklib.__sklib__reconnect__connection.restype = None
sklib.__sklib__reconnect__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__reconnect__string_ref.restype = None
sklib.__sklib__release_all_connections.argtypes = [  ]
sklib.__sklib__release_all_connections.restype = None
sklib.__sklib__reset_new_connection_count__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__reset_new_connection_count__server_socket.restype = None
sklib.__sklib__retrieve_connection__string_ref__int.argtypes = [ _sklib_string, c_int ]
sklib.__sklib__retrieve_connection__string_ref__int.restype = c_void_p
sklib.__sklib__retrieve_connection__server_socket__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__retrieve_connection__server_socket__int.restype = c_void_p
sklib.__sklib__send_message_to__string_ref__connection.argtypes = [ _sklib_string, c_void_p ]
sklib.__sklib__send_message_to__string_ref__connection.restype = c_bool
sklib.__sklib__send_message_to__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__send_message_to__string_ref__string_ref.restype = c_bool
sklib.__sklib__server_has_new_connection__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__server_has_new_connection__string_ref.restype = c_bool
sklib.__sklib__server_has_new_connection__server_socket.argtypes = [ c_void_p ]
sklib.__sklib__server_has_new_connection__server_socket.restype = c_bool
sklib.__sklib__server_named__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__server_named__string_ref.restype = c_void_p
sklib.__sklib__set_udp_packet_size__unsigned_int.argtypes = [ c_uint ]
sklib.__sklib__set_udp_packet_size__unsigned_int.restype = None
sklib.__sklib__udp_packet_size.argtypes = [  ]
sklib.__sklib__udp_packet_size.restype = c_uint
sklib.__sklib__draw_pixel__color__point_2d_ref.argtypes = [ _sklib_color, _sklib_point_2d ]
sklib.__sklib__draw_pixel__color__point_2d_ref.restype = None
sklib.__sklib__draw_pixel__color__point_2d_ref__drawing_options.argtypes = [ _sklib_color, _sklib_point_2d, _sklib_drawing_options ]
sklib.__sklib__draw_pixel__color__point_2d_ref__drawing_options.restype = None
sklib.__sklib__draw_pixel__color__double__double.argtypes = [ _sklib_color, c_double, c_double ]
sklib.__sklib__draw_pixel__color__double__double.restype = None
sklib.__sklib__draw_pixel__color__double__double__drawing_options.argtypes = [ _sklib_color, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_pixel__color__double__double__drawing_options.restype = None
sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref.argtypes = [ c_void_p, _sklib_color, _sklib_point_2d ]
sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref.restype = None
sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_point_2d, _sklib_drawing_options ]
sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref__drawing_options.restype = None
sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double ]
sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__double__double.restype = None
sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__double__double__drawing_options.restype = None
sklib.__sklib__draw_pixel_on_window__window__color__point_2d_ref.argtypes = [ c_void_p, _sklib_color, _sklib_point_2d ]
sklib.__sklib__draw_pixel_on_window__window__color__point_2d_ref.restype = None
sklib.__sklib__draw_pixel_on_window__window__color__point_2d_ref__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_point_2d, _sklib_drawing_options ]
sklib.__sklib__draw_pixel_on_window__window__color__point_2d_ref__drawing_options.restype = None
sklib.__sklib__draw_pixel_on_window__window__color__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double ]
sklib.__sklib__draw_pixel_on_window__window__color__double__double.restype = None
sklib.__sklib__draw_pixel_on_window__window__color__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_pixel_on_window__window__color__double__double__drawing_options.restype = None
sklib.__sklib__get_pixel__bitmap__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__get_pixel__bitmap__point_2d_ref.restype = _sklib_color
sklib.__sklib__get_pixel__bitmap__double__double.argtypes = [ c_void_p, c_double, c_double ]
sklib.__sklib__get_pixel__bitmap__double__double.restype = _sklib_color
sklib.__sklib__get_pixel__point_2d_ref.argtypes = [ _sklib_point_2d ]
sklib.__sklib__get_pixel__point_2d_ref.restype = _sklib_color
sklib.__sklib__get_pixel__double__double.argtypes = [ c_double, c_double ]
sklib.__sklib__get_pixel__double__double.restype = _sklib_color
sklib.__sklib__get_pixel__window__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__get_pixel__window__point_2d_ref.restype = _sklib_color
sklib.__sklib__get_pixel__window__double__double.argtypes = [ c_void_p, c_double, c_double ]
sklib.__sklib__get_pixel__window__double__double.restype = _sklib_color
sklib.__sklib__get_pixel_from_window__window__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__get_pixel_from_window__window__point_2d_ref.restype = _sklib_color
sklib.__sklib__get_pixel_from_window__window__double__double.argtypes = [ c_void_p, c_double, c_double ]
sklib.__sklib__get_pixel_from_window__window__double__double.restype = _sklib_color
sklib.__sklib__point_at__double__double.argtypes = [ c_double, c_double ]
sklib.__sklib__point_at__double__double.restype = _sklib_point_2d
sklib.__sklib__point_at_origin.argtypes = [  ]
sklib.__sklib__point_at_origin.restype = _sklib_point_2d
sklib.__sklib__point_in_circle__point_2d_ref__circle_ref.argtypes = [ _sklib_point_2d, _sklib_circle ]
sklib.__sklib__point_in_circle__point_2d_ref__circle_ref.restype = c_bool
sklib.__sklib__point_in_circle__double__double__double__double__double.argtypes = [ c_double, c_double, c_double, c_double, c_double ]
sklib.__sklib__point_in_circle__double__double__double__double__double.restype = c_bool
sklib.__sklib__point_in_quad__point_2d_ref__quad_ref.argtypes = [ _sklib_point_2d, _sklib_quad ]
sklib.__sklib__point_in_quad__point_2d_ref__quad_ref.restype = c_bool
sklib.__sklib__point_in_rectangle__point_2d_ref__rectangle_ref.argtypes = [ _sklib_point_2d, _sklib_rectangle ]
sklib.__sklib__point_in_rectangle__point_2d_ref__rectangle_ref.restype = c_bool
sklib.__sklib__point_in_rectangle__double__double__double__double__double__double.argtypes = [ c_double, c_double, c_double, c_double, c_double, c_double ]
sklib.__sklib__point_in_rectangle__double__double__double__double__double__double.restype = c_bool
sklib.__sklib__point_in_triangle__point_2d_ref__triangle_ref.argtypes = [ _sklib_point_2d, _sklib_triangle ]
sklib.__sklib__point_in_triangle__point_2d_ref__triangle_ref.restype = c_bool
sklib.__sklib__point_line_distance__point_2d_ref__line_ref.argtypes = [ _sklib_point_2d, _sklib_line ]
sklib.__sklib__point_line_distance__point_2d_ref__line_ref.restype = c_float
sklib.__sklib__point_offset_by__point_2d_ref__vector_2d_ref.argtypes = [ _sklib_point_2d, _sklib_vector_2d ]
sklib.__sklib__point_offset_by__point_2d_ref__vector_2d_ref.restype = _sklib_point_2d
sklib.__sklib__point_offset_from_origin__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__point_offset_from_origin__vector_2d_ref.restype = _sklib_point_2d
sklib.__sklib__point_on_line__point_2d_ref__line_ref.argtypes = [ _sklib_point_2d, _sklib_line ]
sklib.__sklib__point_on_line__point_2d_ref__line_ref.restype = c_bool
sklib.__sklib__point_on_line__point_2d_ref__line_ref__float.argtypes = [ _sklib_point_2d, _sklib_line, c_float ]
sklib.__sklib__point_on_line__point_2d_ref__line_ref__float.restype = c_bool
sklib.__sklib__point_point_angle__point_2d_ref__point_2d_ref.argtypes = [ _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__point_point_angle__point_2d_ref__point_2d_ref.restype = c_float
sklib.__sklib__point_point_distance__point_2d_ref__point_2d_ref.argtypes = [ _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__point_point_distance__point_2d_ref__point_2d_ref.restype = c_float
sklib.__sklib__point_to_string__point_2d_ref.argtypes = [ _sklib_point_2d ]
sklib.__sklib__point_to_string__point_2d_ref.restype = _sklib_string
sklib.__sklib__random_bitmap_point__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__random_bitmap_point__bitmap.restype = _sklib_point_2d
sklib.__sklib__random_screen_point.argtypes = [  ]
sklib.__sklib__random_screen_point.restype = _sklib_point_2d
sklib.__sklib__random_window_point__window.argtypes = [ c_void_p ]
sklib.__sklib__random_window_point__window.restype = _sklib_point_2d
sklib.__sklib__same_point__point_2d_ref__point_2d_ref.argtypes = [ _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__same_point__point_2d_ref__point_2d_ref.restype = c_bool
sklib.__sklib__quad_from__point_2d_ref__point_2d_ref__point_2d_ref__point_2d_ref.argtypes = [ _sklib_point_2d, _sklib_point_2d, _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__quad_from__point_2d_ref__point_2d_ref__point_2d_ref__point_2d_ref.restype = _sklib_quad
sklib.__sklib__quad_from__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__quad_from__rectangle_ref.restype = _sklib_quad
sklib.__sklib__quad_from__rectangle_ref__matrix_2d_ref.argtypes = [ _sklib_rectangle, _sklib_matrix_2d ]
sklib.__sklib__quad_from__rectangle_ref__matrix_2d_ref.restype = _sklib_quad
sklib.__sklib__quad_from__double__double__double__double__double__double__double__double.argtypes = [ c_double, c_double, c_double, c_double, c_double, c_double, c_double, c_double ]
sklib.__sklib__quad_from__double__double__double__double__double__double__double__double.restype = _sklib_quad
sklib.__sklib__quads_intersect__quad_ref__quad_ref.argtypes = [ _sklib_quad, _sklib_quad ]
sklib.__sklib__quads_intersect__quad_ref__quad_ref.restype = c_bool
sklib.__sklib__set_quad_point__quad_ref__int__point_2d_ref.argtypes = [ POINTER(_sklib_quad), c_int, _sklib_point_2d ]
sklib.__sklib__set_quad_point__quad_ref__int__point_2d_ref.restype = None
sklib.__sklib__triangles_from__quad_ref.argtypes = [ _sklib_quad ]
sklib.__sklib__triangles_from__quad_ref.restype = _sklib_vector_triangle
sklib.__sklib__rnd__int__int.argtypes = [ c_int, c_int ]
sklib.__sklib__rnd__int__int.restype = c_int
sklib.__sklib__rnd.argtypes = [  ]
sklib.__sklib__rnd.restype = c_float
sklib.__sklib__rnd__int.argtypes = [ c_int ]
sklib.__sklib__rnd__int.restype = c_int
sklib.__sklib__has_gpio.argtypes = [  ]
sklib.__sklib__has_gpio.restype = c_bool
sklib.__sklib__raspi_cleanup.argtypes = [  ]
sklib.__sklib__raspi_cleanup.restype = None
sklib.__sklib__raspi_get_mode__pins.argtypes = [ c_int ]
sklib.__sklib__raspi_get_mode__pins.restype = c_int
sklib.__sklib__raspi_init.argtypes = [  ]
sklib.__sklib__raspi_init.restype = None
sklib.__sklib__raspi_read__pins.argtypes = [ c_int ]
sklib.__sklib__raspi_read__pins.restype = c_int
sklib.__sklib__raspi_set_mode__pins__pin_modes.argtypes = [ c_int, c_int ]
sklib.__sklib__raspi_set_mode__pins__pin_modes.restype = None
sklib.__sklib__raspi_set_pull_up_down__pins__pull_up_down.argtypes = [ c_int, c_int ]
sklib.__sklib__raspi_set_pull_up_down__pins__pull_up_down.restype = None
sklib.__sklib__raspi_set_pwm_dutycycle__pins__int.argtypes = [ c_int, c_int ]
sklib.__sklib__raspi_set_pwm_dutycycle__pins__int.restype = None
sklib.__sklib__raspi_set_pwm_frequency__pins__int.argtypes = [ c_int, c_int ]
sklib.__sklib__raspi_set_pwm_frequency__pins__int.restype = None
sklib.__sklib__raspi_set_pwm_range__pins__int.argtypes = [ c_int, c_int ]
sklib.__sklib__raspi_set_pwm_range__pins__int.restype = None
sklib.__sklib__raspi_write__pins__pin_values.argtypes = [ c_int, c_int ]
sklib.__sklib__raspi_write__pins__pin_values.restype = None
sklib.__sklib__draw_quad__color__quad_ref.argtypes = [ _sklib_color, _sklib_quad ]
sklib.__sklib__draw_quad__color__quad_ref.restype = None
sklib.__sklib__draw_quad__color__quad_ref__drawing_options_ref.argtypes = [ _sklib_color, _sklib_quad, _sklib_drawing_options ]
sklib.__sklib__draw_quad__color__quad_ref__drawing_options_ref.restype = None
sklib.__sklib__draw_quad_on_bitmap__bitmap__color__quad_ref.argtypes = [ c_void_p, _sklib_color, _sklib_quad ]
sklib.__sklib__draw_quad_on_bitmap__bitmap__color__quad_ref.restype = None
sklib.__sklib__draw_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, _sklib_quad, _sklib_drawing_options ]
sklib.__sklib__draw_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref.restype = None
sklib.__sklib__draw_quad_on_window__window__color__quad_ref.argtypes = [ c_void_p, _sklib_color, _sklib_quad ]
sklib.__sklib__draw_quad_on_window__window__color__quad_ref.restype = None
sklib.__sklib__draw_quad_on_window__window__color__quad_ref__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, _sklib_quad, _sklib_drawing_options ]
sklib.__sklib__draw_quad_on_window__window__color__quad_ref__drawing_options_ref.restype = None
sklib.__sklib__draw_rectangle__color__rectangle_ref.argtypes = [ _sklib_color, _sklib_rectangle ]
sklib.__sklib__draw_rectangle__color__rectangle_ref.restype = None
sklib.__sklib__draw_rectangle__color__rectangle_ref__drawing_options_ref.argtypes = [ _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__draw_rectangle__color__rectangle_ref__drawing_options_ref.restype = None
sklib.__sklib__draw_rectangle__color__double__double__double__double.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_rectangle__color__double__double__double__double.restype = None
sklib.__sklib__draw_rectangle__color__double__double__double__double__drawing_options_ref.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_rectangle__color__double__double__double__double__drawing_options_ref.restype = None
sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle ]
sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref.restype = None
sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref.restype = None
sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double.restype = None
sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options.restype = None
sklib.__sklib__draw_rectangle_on_window__window__color__rectangle_ref.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle ]
sklib.__sklib__draw_rectangle_on_window__window__color__rectangle_ref.restype = None
sklib.__sklib__draw_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__draw_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref.restype = None
sklib.__sklib__draw_rectangle_on_window__window__color__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_rectangle_on_window__window__color__double__double__double__double.restype = None
sklib.__sklib__draw_rectangle_on_window__window__color__double__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_rectangle_on_window__window__color__double__double__double__double__drawing_options.restype = None
sklib.__sklib__fill_quad__color__quad_ref.argtypes = [ _sklib_color, _sklib_quad ]
sklib.__sklib__fill_quad__color__quad_ref.restype = None
sklib.__sklib__fill_quad__color__quad_ref__drawing_options_ref.argtypes = [ _sklib_color, _sklib_quad, _sklib_drawing_options ]
sklib.__sklib__fill_quad__color__quad_ref__drawing_options_ref.restype = None
sklib.__sklib__fill_quad_on_bitmap__bitmap__color__quad_ref.argtypes = [ c_void_p, _sklib_color, _sklib_quad ]
sklib.__sklib__fill_quad_on_bitmap__bitmap__color__quad_ref.restype = None
sklib.__sklib__fill_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, _sklib_quad, _sklib_drawing_options ]
sklib.__sklib__fill_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref.restype = None
sklib.__sklib__fill_quad_on_window__window__color__quad_ref.argtypes = [ c_void_p, _sklib_color, _sklib_quad ]
sklib.__sklib__fill_quad_on_window__window__color__quad_ref.restype = None
sklib.__sklib__fill_quad_on_window__window__color__quad_ref__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, _sklib_quad, _sklib_drawing_options ]
sklib.__sklib__fill_quad_on_window__window__color__quad_ref__drawing_options_ref.restype = None
sklib.__sklib__fill_rectangle__color__rectangle_ref.argtypes = [ _sklib_color, _sklib_rectangle ]
sklib.__sklib__fill_rectangle__color__rectangle_ref.restype = None
sklib.__sklib__fill_rectangle__color__rectangle_ref__drawing_options_ref.argtypes = [ _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__fill_rectangle__color__rectangle_ref__drawing_options_ref.restype = None
sklib.__sklib__fill_rectangle__color__double__double__double__double.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__fill_rectangle__color__double__double__double__double.restype = None
sklib.__sklib__fill_rectangle__color__double__double__double__double__drawing_options_ref.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_rectangle__color__double__double__double__double__drawing_options_ref.restype = None
sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle ]
sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref.restype = None
sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref.restype = None
sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double.restype = None
sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref.restype = None
sklib.__sklib__fill_rectangle_on_window__window__color__rectangle_ref.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle ]
sklib.__sklib__fill_rectangle_on_window__window__color__rectangle_ref.restype = None
sklib.__sklib__fill_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, _sklib_rectangle, _sklib_drawing_options ]
sklib.__sklib__fill_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref.restype = None
sklib.__sklib__fill_rectangle_on_window__window__color__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double ]
sklib.__sklib__fill_rectangle_on_window__window__color__double__double__double__double.restype = None
sklib.__sklib__fill_rectangle_on_window__window__color__double__double__double__double__drawing_options_ref.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_rectangle_on_window__window__color__double__double__double__double__drawing_options_ref.restype = None
sklib.__sklib__inset_rectangle__rectangle_ref__float.argtypes = [ _sklib_rectangle, c_float ]
sklib.__sklib__inset_rectangle__rectangle_ref__float.restype = _sklib_rectangle
sklib.__sklib__intersection__rectangle_ref__rectangle_ref.argtypes = [ _sklib_rectangle, _sklib_rectangle ]
sklib.__sklib__intersection__rectangle_ref__rectangle_ref.restype = _sklib_rectangle
sklib.__sklib__rectangle_around__circle_ref.argtypes = [ _sklib_circle ]
sklib.__sklib__rectangle_around__circle_ref.restype = _sklib_rectangle
sklib.__sklib__rectangle_around__line_ref.argtypes = [ _sklib_line ]
sklib.__sklib__rectangle_around__line_ref.restype = _sklib_rectangle
sklib.__sklib__rectangle_around__quad_ref.argtypes = [ _sklib_quad ]
sklib.__sklib__rectangle_around__quad_ref.restype = _sklib_rectangle
sklib.__sklib__rectangle_around__triangle_ref.argtypes = [ _sklib_triangle ]
sklib.__sklib__rectangle_around__triangle_ref.restype = _sklib_rectangle
sklib.__sklib__rectangle_bottom__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__rectangle_bottom__rectangle_ref.restype = c_float
sklib.__sklib__rectangle_center__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__rectangle_center__rectangle_ref.restype = _sklib_point_2d
sklib.__sklib__rectangle_from__point_2d__double__double.argtypes = [ _sklib_point_2d, c_double, c_double ]
sklib.__sklib__rectangle_from__point_2d__double__double.restype = _sklib_rectangle
sklib.__sklib__rectangle_from__point_2d__point_2d.argtypes = [ _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__rectangle_from__point_2d__point_2d.restype = _sklib_rectangle
sklib.__sklib__rectangle_from__double__double__double__double.argtypes = [ c_double, c_double, c_double, c_double ]
sklib.__sklib__rectangle_from__double__double__double__double.restype = _sklib_rectangle
sklib.__sklib__rectangle_left__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__rectangle_left__rectangle_ref.restype = c_float
sklib.__sklib__rectangle_offset_by__rectangle_ref__vector_2d_ref.argtypes = [ _sklib_rectangle, _sklib_vector_2d ]
sklib.__sklib__rectangle_offset_by__rectangle_ref__vector_2d_ref.restype = _sklib_rectangle
sklib.__sklib__rectangle_right__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__rectangle_right__rectangle_ref.restype = c_float
sklib.__sklib__rectangle_to_string__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__rectangle_to_string__rectangle_ref.restype = _sklib_string
sklib.__sklib__rectangle_top__rectangle_ref.argtypes = [ _sklib_rectangle ]
sklib.__sklib__rectangle_top__rectangle_ref.restype = c_float
sklib.__sklib__rectangles_intersect__rectangle_ref__rectangle_ref.argtypes = [ _sklib_rectangle, _sklib_rectangle ]
sklib.__sklib__rectangles_intersect__rectangle_ref__rectangle_ref.restype = c_bool
sklib.__sklib__deregister_free_notifier__free_notifier_ptr.argtypes = [ FreeNotifier ]
sklib.__sklib__deregister_free_notifier__free_notifier_ptr.restype = None
sklib.__sklib__path_to_resource__string_ref__resource_kind.argtypes = [ _sklib_string, c_int ]
sklib.__sklib__path_to_resource__string_ref__resource_kind.restype = _sklib_string
sklib.__sklib__path_to_resources.argtypes = [  ]
sklib.__sklib__path_to_resources.restype = _sklib_string
sklib.__sklib__path_to_resources__resource_kind.argtypes = [ c_int ]
sklib.__sklib__path_to_resources__resource_kind.restype = _sklib_string
sklib.__sklib__register_free_notifier__free_notifier_ptr.argtypes = [ FreeNotifier ]
sklib.__sklib__register_free_notifier__free_notifier_ptr.restype = None
sklib.__sklib__set_resources_path__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__set_resources_path__string_ref.restype = None
sklib.__sklib__fade_all_sound_effects_out__int.argtypes = [ c_int ]
sklib.__sklib__fade_all_sound_effects_out__int.restype = None
sklib.__sklib__fade_sound_effect_out__sound_effect__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__fade_sound_effect_out__sound_effect__int.restype = None
sklib.__sklib__free_all_sound_effects.argtypes = [  ]
sklib.__sklib__free_all_sound_effects.restype = None
sklib.__sklib__free_sound_effect__sound_effect.argtypes = [ c_void_p ]
sklib.__sklib__free_sound_effect__sound_effect.restype = None
sklib.__sklib__has_sound_effect__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__has_sound_effect__string_ref.restype = c_bool
sklib.__sklib__load_sound_effect__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__load_sound_effect__string_ref__string_ref.restype = c_void_p
sklib.__sklib__play_sound_effect__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__play_sound_effect__string_ref.restype = None
sklib.__sklib__play_sound_effect__string_ref__double.argtypes = [ _sklib_string, c_double ]
sklib.__sklib__play_sound_effect__string_ref__double.restype = None
sklib.__sklib__play_sound_effect__string_ref__int.argtypes = [ _sklib_string, c_int ]
sklib.__sklib__play_sound_effect__string_ref__int.restype = None
sklib.__sklib__play_sound_effect__string_ref__int__double.argtypes = [ _sklib_string, c_int, c_double ]
sklib.__sklib__play_sound_effect__string_ref__int__double.restype = None
sklib.__sklib__play_sound_effect__sound_effect.argtypes = [ c_void_p ]
sklib.__sklib__play_sound_effect__sound_effect.restype = None
sklib.__sklib__play_sound_effect__sound_effect__double.argtypes = [ c_void_p, c_double ]
sklib.__sklib__play_sound_effect__sound_effect__double.restype = None
sklib.__sklib__play_sound_effect__sound_effect__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__play_sound_effect__sound_effect__int.restype = None
sklib.__sklib__play_sound_effect__sound_effect__int__double.argtypes = [ c_void_p, c_int, c_double ]
sklib.__sklib__play_sound_effect__sound_effect__int__double.restype = None
sklib.__sklib__sound_effect_filename__sound_effect.argtypes = [ c_void_p ]
sklib.__sklib__sound_effect_filename__sound_effect.restype = _sklib_string
sklib.__sklib__sound_effect_name__sound_effect.argtypes = [ c_void_p ]
sklib.__sklib__sound_effect_name__sound_effect.restype = _sklib_string
sklib.__sklib__sound_effect_named__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__sound_effect_named__string_ref.restype = c_void_p
sklib.__sklib__sound_effect_playing__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__sound_effect_playing__string_ref.restype = c_bool
sklib.__sklib__sound_effect_playing__sound_effect.argtypes = [ c_void_p ]
sklib.__sklib__sound_effect_playing__sound_effect.restype = c_bool
sklib.__sklib__sound_effect_valid__sound_effect.argtypes = [ c_void_p ]
sklib.__sklib__sound_effect_valid__sound_effect.restype = c_bool
sklib.__sklib__stop_sound_effect__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__stop_sound_effect__string_ref.restype = None
sklib.__sklib__stop_sound_effect__sound_effect.argtypes = [ c_void_p ]
sklib.__sklib__stop_sound_effect__sound_effect.restype = None
sklib.__sklib__call_for_all_sprites__sprite_float_function_ptr__float.argtypes = [ SpriteFloatFunction, c_float ]
sklib.__sklib__call_for_all_sprites__sprite_float_function_ptr__float.restype = None
sklib.__sklib__call_for_all_sprites__sprite_function_ptr.argtypes = [ SpriteFunction ]
sklib.__sklib__call_for_all_sprites__sprite_function_ptr.restype = None
sklib.__sklib__call_on_sprite_event__sprite_event_handler_ptr.argtypes = [ SpriteEventHandler ]
sklib.__sklib__call_on_sprite_event__sprite_event_handler_ptr.restype = None
sklib.__sklib__center_point__sprite.argtypes = [ c_void_p ]
sklib.__sklib__center_point__sprite.restype = _sklib_point_2d
sklib.__sklib__create_sprite__bitmap.argtypes = [ c_void_p ]
sklib.__sklib__create_sprite__bitmap.restype = c_void_p
sklib.__sklib__create_sprite__bitmap__animation_script.argtypes = [ c_void_p, c_void_p ]
sklib.__sklib__create_sprite__bitmap__animation_script.restype = c_void_p
sklib.__sklib__create_sprite__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__create_sprite__string_ref.restype = c_void_p
sklib.__sklib__create_sprite__string_ref__bitmap.argtypes = [ _sklib_string, c_void_p ]
sklib.__sklib__create_sprite__string_ref__bitmap.restype = c_void_p
sklib.__sklib__create_sprite__string_ref__bitmap__animation_script.argtypes = [ _sklib_string, c_void_p, c_void_p ]
sklib.__sklib__create_sprite__string_ref__bitmap__animation_script.restype = c_void_p
sklib.__sklib__create_sprite__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__create_sprite__string_ref__string_ref.restype = c_void_p
sklib.__sklib__create_sprite_pack__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__create_sprite_pack__string_ref.restype = None
sklib.__sklib__current_sprite_pack.argtypes = [  ]
sklib.__sklib__current_sprite_pack.restype = _sklib_string
sklib.__sklib__draw_all_sprites.argtypes = [  ]
sklib.__sklib__draw_all_sprites.restype = None
sklib.__sklib__draw_sprite__sprite__vector_2d_ref.argtypes = [ c_void_p, _sklib_vector_2d ]
sklib.__sklib__draw_sprite__sprite__vector_2d_ref.restype = None
sklib.__sklib__draw_sprite__sprite.argtypes = [ c_void_p ]
sklib.__sklib__draw_sprite__sprite.restype = None
sklib.__sklib__draw_sprite__sprite__double__double.argtypes = [ c_void_p, c_double, c_double ]
sklib.__sklib__draw_sprite__sprite__double__double.restype = None
sklib.__sklib__free_all_sprites.argtypes = [  ]
sklib.__sklib__free_all_sprites.restype = None
sklib.__sklib__free_sprite__sprite.argtypes = [ c_void_p ]
sklib.__sklib__free_sprite__sprite.restype = None
sklib.__sklib__free_sprite_pack__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__free_sprite_pack__string_ref.restype = None
sklib.__sklib__has_sprite__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__has_sprite__string_ref.restype = c_bool
sklib.__sklib__has_sprite_pack__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__has_sprite_pack__string_ref.restype = c_bool
sklib.__sklib__move_sprite__sprite.argtypes = [ c_void_p ]
sklib.__sklib__move_sprite__sprite.restype = None
sklib.__sklib__move_sprite__sprite__vector_2d_ref.argtypes = [ c_void_p, _sklib_vector_2d ]
sklib.__sklib__move_sprite__sprite__vector_2d_ref.restype = None
sklib.__sklib__move_sprite__sprite__vector_2d_ref__float.argtypes = [ c_void_p, _sklib_vector_2d, c_float ]
sklib.__sklib__move_sprite__sprite__vector_2d_ref__float.restype = None
sklib.__sklib__move_sprite__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__move_sprite__sprite__float.restype = None
sklib.__sklib__move_sprite_to__sprite__double__double.argtypes = [ c_void_p, c_double, c_double ]
sklib.__sklib__move_sprite_to__sprite__double__double.restype = None
sklib.__sklib__select_sprite_pack__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__select_sprite_pack__string_ref.restype = None
sklib.__sklib__sprite_add_layer__sprite__bitmap__string_ref.argtypes = [ c_void_p, c_void_p, _sklib_string ]
sklib.__sklib__sprite_add_layer__sprite__bitmap__string_ref.restype = c_int
sklib.__sklib__sprite_add_to_velocity__sprite__vector_2d_ref.argtypes = [ c_void_p, _sklib_vector_2d ]
sklib.__sklib__sprite_add_to_velocity__sprite__vector_2d_ref.restype = None
sklib.__sklib__sprite_add_value__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_add_value__sprite__string_ref.restype = None
sklib.__sklib__sprite_add_value__sprite__string_ref__float.argtypes = [ c_void_p, _sklib_string, c_float ]
sklib.__sklib__sprite_add_value__sprite__string_ref__float.restype = None
sklib.__sklib__sprite_anchor_point__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_anchor_point__sprite.restype = _sklib_point_2d
sklib.__sklib__sprite_anchor_position__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_anchor_position__sprite.restype = _sklib_point_2d
sklib.__sklib__sprite_animation_has_ended__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_animation_has_ended__sprite.restype = c_bool
sklib.__sklib__sprite_animation_name__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_animation_name__sprite.restype = _sklib_string
sklib.__sklib__sprite_at__sprite__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__sprite_at__sprite__point_2d_ref.restype = c_bool
sklib.__sklib__sprite_bring_layer_forward__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_bring_layer_forward__sprite__int.restype = None
sklib.__sklib__sprite_bring_layer_to_front__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_bring_layer_to_front__sprite__int.restype = None
sklib.__sklib__sprite_call_on_event__sprite__sprite_event_handler_ptr.argtypes = [ c_void_p, SpriteEventHandler ]
sklib.__sklib__sprite_call_on_event__sprite__sprite_event_handler_ptr.restype = None
sklib.__sklib__sprite_circle__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_circle__sprite.restype = _sklib_circle
sklib.__sklib__sprite_collision_bitmap__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_collision_bitmap__sprite.restype = c_void_p
sklib.__sklib__sprite_collision_circle__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_collision_circle__sprite.restype = _sklib_circle
sklib.__sklib__sprite_collision_kind__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_collision_kind__sprite.restype = c_int
sklib.__sklib__sprite_collision_rectangle__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_collision_rectangle__sprite.restype = _sklib_rectangle
sklib.__sklib__sprite_current_cell__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_current_cell__sprite.restype = c_int
sklib.__sklib__sprite_current_cell_rectangle__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_current_cell_rectangle__sprite.restype = _sklib_rectangle
sklib.__sklib__sprite_dx__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_dx__sprite.restype = c_float
sklib.__sklib__sprite_dy__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_dy__sprite.restype = c_float
sklib.__sklib__sprite_has_value__sprite__string.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_has_value__sprite__string.restype = c_bool
sklib.__sklib__sprite_heading__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_heading__sprite.restype = c_float
sklib.__sklib__sprite_height__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_height__sprite.restype = c_int
sklib.__sklib__sprite_hide_layer__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_hide_layer__sprite__string_ref.restype = None
sklib.__sklib__sprite_hide_layer__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_hide_layer__sprite__int.restype = None
sklib.__sklib__sprite_layer__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_layer__sprite__string_ref.restype = c_void_p
sklib.__sklib__sprite_layer__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_layer__sprite__int.restype = c_void_p
sklib.__sklib__sprite_layer_circle__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_layer_circle__sprite__string_ref.restype = _sklib_circle
sklib.__sklib__sprite_layer_circle__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_layer_circle__sprite__int.restype = _sklib_circle
sklib.__sklib__sprite_layer_count__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_layer_count__sprite.restype = c_int
sklib.__sklib__sprite_layer_height__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_layer_height__sprite__string_ref.restype = c_int
sklib.__sklib__sprite_layer_height__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_layer_height__sprite__int.restype = c_int
sklib.__sklib__sprite_layer_index__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_layer_index__sprite__string_ref.restype = c_int
sklib.__sklib__sprite_layer_name__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_layer_name__sprite__int.restype = _sklib_string
sklib.__sklib__sprite_layer_offset__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_layer_offset__sprite__string_ref.restype = _sklib_vector_2d
sklib.__sklib__sprite_layer_offset__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_layer_offset__sprite__int.restype = _sklib_vector_2d
sklib.__sklib__sprite_layer_rectangle__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_layer_rectangle__sprite__string_ref.restype = _sklib_rectangle
sklib.__sklib__sprite_layer_rectangle__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_layer_rectangle__sprite__int.restype = _sklib_rectangle
sklib.__sklib__sprite_layer_width__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_layer_width__sprite__string_ref.restype = c_int
sklib.__sklib__sprite_layer_width__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_layer_width__sprite__int.restype = c_int
sklib.__sklib__sprite_location_matrix__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_location_matrix__sprite.restype = _sklib_matrix_2d
sklib.__sklib__sprite_mass__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_mass__sprite.restype = c_float
sklib.__sklib__sprite_move_from_anchor_point__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_move_from_anchor_point__sprite.restype = c_bool
sklib.__sklib__sprite_move_to__sprite__point_2d_ref__float.argtypes = [ c_void_p, _sklib_point_2d, c_float ]
sklib.__sklib__sprite_move_to__sprite__point_2d_ref__float.restype = None
sklib.__sklib__sprite_name__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_name__sprite.restype = _sklib_string
sklib.__sklib__sprite_named__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__sprite_named__string_ref.restype = c_void_p
sklib.__sklib__sprite_offscreen__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_offscreen__sprite.restype = c_bool
sklib.__sklib__sprite_on_screen_at__sprite__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__sprite_on_screen_at__sprite__point_2d_ref.restype = c_bool
sklib.__sklib__sprite_on_screen_at__sprite__double__double.argtypes = [ c_void_p, c_double, c_double ]
sklib.__sklib__sprite_on_screen_at__sprite__double__double.restype = c_bool
sklib.__sklib__sprite_position__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_position__sprite.restype = _sklib_point_2d
sklib.__sklib__sprite_replay_animation__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_replay_animation__sprite.restype = None
sklib.__sklib__sprite_replay_animation__sprite__bool.argtypes = [ c_void_p, c_bool ]
sklib.__sklib__sprite_replay_animation__sprite__bool.restype = None
sklib.__sklib__sprite_rotation__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_rotation__sprite.restype = c_float
sklib.__sklib__sprite_scale__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_scale__sprite.restype = c_float
sklib.__sklib__sprite_screen_rectangle__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_screen_rectangle__sprite.restype = _sklib_rectangle
sklib.__sklib__sprite_send_layer_backward__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_send_layer_backward__sprite__int.restype = None
sklib.__sklib__sprite_send_layer_to_back__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_send_layer_to_back__sprite__int.restype = None
sklib.__sklib__sprite_set_anchor_point__sprite__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__sprite_set_anchor_point__sprite__point_2d_ref.restype = None
sklib.__sklib__sprite_set_collision_bitmap__sprite__bitmap.argtypes = [ c_void_p, c_void_p ]
sklib.__sklib__sprite_set_collision_bitmap__sprite__bitmap.restype = None
sklib.__sklib__sprite_set_collision_kind__sprite__collision_test_kind.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_set_collision_kind__sprite__collision_test_kind.restype = None
sklib.__sklib__sprite_set_dx__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__sprite_set_dx__sprite__float.restype = None
sklib.__sklib__sprite_set_dy__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__sprite_set_dy__sprite__float.restype = None
sklib.__sklib__sprite_set_heading__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__sprite_set_heading__sprite__float.restype = None
sklib.__sklib__sprite_set_layer_offset__sprite__string_ref__vector_2d_ref.argtypes = [ c_void_p, _sklib_string, _sklib_vector_2d ]
sklib.__sklib__sprite_set_layer_offset__sprite__string_ref__vector_2d_ref.restype = None
sklib.__sklib__sprite_set_layer_offset__sprite__int__vector_2d_ref.argtypes = [ c_void_p, c_int, _sklib_vector_2d ]
sklib.__sklib__sprite_set_layer_offset__sprite__int__vector_2d_ref.restype = None
sklib.__sklib__sprite_set_mass__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__sprite_set_mass__sprite__float.restype = None
sklib.__sklib__sprite_set_move_from_anchor_point__sprite__bool.argtypes = [ c_void_p, c_bool ]
sklib.__sklib__sprite_set_move_from_anchor_point__sprite__bool.restype = None
sklib.__sklib__sprite_set_position__sprite__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__sprite_set_position__sprite__point_2d_ref.restype = None
sklib.__sklib__sprite_set_rotation__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__sprite_set_rotation__sprite__float.restype = None
sklib.__sklib__sprite_set_scale__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__sprite_set_scale__sprite__float.restype = None
sklib.__sklib__sprite_set_speed__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__sprite_set_speed__sprite__float.restype = None
sklib.__sklib__sprite_set_value__sprite__string_ref__float.argtypes = [ c_void_p, _sklib_string, c_float ]
sklib.__sklib__sprite_set_value__sprite__string_ref__float.restype = None
sklib.__sklib__sprite_set_velocity__sprite__vector_2d_ref.argtypes = [ c_void_p, _sklib_vector_2d ]
sklib.__sklib__sprite_set_velocity__sprite__vector_2d_ref.restype = None
sklib.__sklib__sprite_set_x__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__sprite_set_x__sprite__float.restype = None
sklib.__sklib__sprite_set_y__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__sprite_set_y__sprite__float.restype = None
sklib.__sklib__sprite_show_layer__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_show_layer__sprite__string_ref.restype = c_int
sklib.__sklib__sprite_show_layer__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_show_layer__sprite__int.restype = c_int
sklib.__sklib__sprite_speed__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_speed__sprite.restype = c_float
sklib.__sklib__sprite_start_animation__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_start_animation__sprite__string_ref.restype = None
sklib.__sklib__sprite_start_animation__sprite__string_ref__bool.argtypes = [ c_void_p, _sklib_string, c_bool ]
sklib.__sklib__sprite_start_animation__sprite__string_ref__bool.restype = None
sklib.__sklib__sprite_start_animation__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_start_animation__sprite__int.restype = None
sklib.__sklib__sprite_start_animation__sprite__int__bool.argtypes = [ c_void_p, c_int, c_bool ]
sklib.__sklib__sprite_start_animation__sprite__int__bool.restype = None
sklib.__sklib__sprite_stop_calling_on_event__sprite__sprite_event_handler_ptr.argtypes = [ c_void_p, SpriteEventHandler ]
sklib.__sklib__sprite_stop_calling_on_event__sprite__sprite_event_handler_ptr.restype = None
sklib.__sklib__sprite_toggle_layer_visible__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_toggle_layer_visible__sprite__string_ref.restype = None
sklib.__sklib__sprite_toggle_layer_visible__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_toggle_layer_visible__sprite__int.restype = None
sklib.__sklib__sprite_value__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_value__sprite__string_ref.restype = c_float
sklib.__sklib__sprite_value_count__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_value_count__sprite.restype = c_int
sklib.__sklib__sprite_velocity__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_velocity__sprite.restype = _sklib_vector_2d
sklib.__sklib__sprite_visible_index_of_layer__sprite__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__sprite_visible_index_of_layer__sprite__string_ref.restype = c_int
sklib.__sklib__sprite_visible_index_of_layer__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_visible_index_of_layer__sprite__int.restype = c_int
sklib.__sklib__sprite_visible_layer__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_visible_layer__sprite__int.restype = c_int
sklib.__sklib__sprite_visible_layer_count__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_visible_layer_count__sprite.restype = c_int
sklib.__sklib__sprite_visible_layer_id__sprite__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__sprite_visible_layer_id__sprite__int.restype = c_int
sklib.__sklib__sprite_width__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_width__sprite.restype = c_int
sklib.__sklib__sprite_x__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_x__sprite.restype = c_float
sklib.__sklib__sprite_y__sprite.argtypes = [ c_void_p ]
sklib.__sklib__sprite_y__sprite.restype = c_float
sklib.__sklib__stop_calling_on_sprite_event__sprite_event_handler_ptr.argtypes = [ SpriteEventHandler ]
sklib.__sklib__stop_calling_on_sprite_event__sprite_event_handler_ptr.restype = None
sklib.__sklib__update_all_sprites.argtypes = [  ]
sklib.__sklib__update_all_sprites.restype = None
sklib.__sklib__update_all_sprites__float.argtypes = [ c_float ]
sklib.__sklib__update_all_sprites__float.restype = None
sklib.__sklib__update_sprite__sprite.argtypes = [ c_void_p ]
sklib.__sklib__update_sprite__sprite.restype = None
sklib.__sklib__update_sprite__sprite__bool.argtypes = [ c_void_p, c_bool ]
sklib.__sklib__update_sprite__sprite__bool.restype = None
sklib.__sklib__update_sprite__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__update_sprite__sprite__float.restype = None
sklib.__sklib__update_sprite__sprite__float__bool.argtypes = [ c_void_p, c_float, c_bool ]
sklib.__sklib__update_sprite__sprite__float__bool.restype = None
sklib.__sklib__update_sprite_animation__sprite.argtypes = [ c_void_p ]
sklib.__sklib__update_sprite_animation__sprite.restype = None
sklib.__sklib__update_sprite_animation__sprite__bool.argtypes = [ c_void_p, c_bool ]
sklib.__sklib__update_sprite_animation__sprite__bool.restype = None
sklib.__sklib__update_sprite_animation__sprite__float.argtypes = [ c_void_p, c_float ]
sklib.__sklib__update_sprite_animation__sprite__float.restype = None
sklib.__sklib__update_sprite_animation__sprite__float__bool.argtypes = [ c_void_p, c_float, c_bool ]
sklib.__sklib__update_sprite_animation__sprite__float__bool.restype = None
sklib.__sklib__vector_from_center_sprite_to_point__sprite__point_2d_ref.argtypes = [ c_void_p, _sklib_point_2d ]
sklib.__sklib__vector_from_center_sprite_to_point__sprite__point_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_from_to__sprite__sprite.argtypes = [ c_void_p, c_void_p ]
sklib.__sklib__vector_from_to__sprite__sprite.restype = _sklib_vector_2d
sklib.__sklib__read_char.argtypes = [  ]
sklib.__sklib__read_char.restype = c_char
sklib.__sklib__read_line.argtypes = [  ]
sklib.__sklib__read_line.restype = _sklib_string
sklib.__sklib__terminal_has_input.argtypes = [  ]
sklib.__sklib__terminal_has_input.restype = c_bool
sklib.__sklib__write__char.argtypes = [ c_char ]
sklib.__sklib__write__char.restype = None
sklib.__sklib__write__double.argtypes = [ c_double ]
sklib.__sklib__write__double.restype = None
sklib.__sklib__write__int.argtypes = [ c_int ]
sklib.__sklib__write__int.restype = None
sklib.__sklib__write__string.argtypes = [ _sklib_string ]
sklib.__sklib__write__string.restype = None
sklib.__sklib__write_line__char.argtypes = [ c_char ]
sklib.__sklib__write_line__char.restype = None
sklib.__sklib__write_line.argtypes = [  ]
sklib.__sklib__write_line.restype = None
sklib.__sklib__write_line__double.argtypes = [ c_double ]
sklib.__sklib__write_line__double.restype = None
sklib.__sklib__write_line__int.argtypes = [ c_int ]
sklib.__sklib__write_line__int.restype = None
sklib.__sklib__write_line__string.argtypes = [ _sklib_string ]
sklib.__sklib__write_line__string.restype = None
sklib.__sklib__draw_text__string_ref__color_ref__string_ref__int__double__double.argtypes = [ _sklib_string, _sklib_color, _sklib_string, c_int, c_double, c_double ]
sklib.__sklib__draw_text__string_ref__color_ref__string_ref__int__double__double.restype = None
sklib.__sklib__draw_text__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref.argtypes = [ _sklib_string, _sklib_color, _sklib_string, c_int, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_text__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref.restype = None
sklib.__sklib__draw_text__string_ref__color_ref__double__double.argtypes = [ _sklib_string, _sklib_color, c_double, c_double ]
sklib.__sklib__draw_text__string_ref__color_ref__double__double.restype = None
sklib.__sklib__draw_text__string_ref__color_ref__double__double__drawing_options_ref.argtypes = [ _sklib_string, _sklib_color, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_text__string_ref__color_ref__double__double__drawing_options_ref.restype = None
sklib.__sklib__draw_text__string_ref__color_ref__font__int__double__double.argtypes = [ _sklib_string, _sklib_color, c_void_p, c_int, c_double, c_double ]
sklib.__sklib__draw_text__string_ref__color_ref__font__int__double__double.restype = None
sklib.__sklib__draw_text__string_ref__color_ref__font__int__double__double__drawing_options_ref.argtypes = [ _sklib_string, _sklib_color, c_void_p, c_int, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_text__string_ref__color_ref__font__int__double__double__drawing_options_ref.restype = None
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double.argtypes = [ c_void_p, _sklib_string, _sklib_color, _sklib_string, c_int, c_double, c_double ]
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double.restype = None
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref.argtypes = [ c_void_p, _sklib_string, _sklib_color, _sklib_string, c_int, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref.restype = None
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double.argtypes = [ c_void_p, _sklib_string, _sklib_color, c_double, c_double ]
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double.restype = None
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double__drawing_options_ref.argtypes = [ c_void_p, _sklib_string, _sklib_color, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double__drawing_options_ref.restype = None
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double.argtypes = [ c_void_p, _sklib_string, _sklib_color, c_void_p, c_int, c_double, c_double ]
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double.restype = None
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double__drawing_options_ref.argtypes = [ c_void_p, _sklib_string, _sklib_color, c_void_p, c_int, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double__drawing_options_ref.restype = None
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double.argtypes = [ c_void_p, _sklib_string, _sklib_color, _sklib_string, c_int, c_double, c_double ]
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double.restype = None
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref.argtypes = [ c_void_p, _sklib_string, _sklib_color, _sklib_string, c_int, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref.restype = None
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__double__double.argtypes = [ c_void_p, _sklib_string, _sklib_color, c_double, c_double ]
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__double__double.restype = None
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__double__double__drawing_options_ref.argtypes = [ c_void_p, _sklib_string, _sklib_color, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__double__double__drawing_options_ref.restype = None
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double.argtypes = [ c_void_p, _sklib_string, _sklib_color, c_void_p, c_int, c_double, c_double ]
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double.restype = None
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double__drawing_options_ref.argtypes = [ c_void_p, _sklib_string, _sklib_color, c_void_p, c_int, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double__drawing_options_ref.restype = None
sklib.__sklib__font_has_size__string_ref__int.argtypes = [ _sklib_string, c_int ]
sklib.__sklib__font_has_size__string_ref__int.restype = c_bool
sklib.__sklib__font_has_size__font__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__font_has_size__font__int.restype = c_bool
sklib.__sklib__font_load_size__string_ref__int.argtypes = [ _sklib_string, c_int ]
sklib.__sklib__font_load_size__string_ref__int.restype = None
sklib.__sklib__font_load_size__font__int.argtypes = [ c_void_p, c_int ]
sklib.__sklib__font_load_size__font__int.restype = None
sklib.__sklib__font_named__string.argtypes = [ _sklib_string ]
sklib.__sklib__font_named__string.restype = c_void_p
sklib.__sklib__free_all_fonts.argtypes = [  ]
sklib.__sklib__free_all_fonts.restype = None
sklib.__sklib__free_font__font.argtypes = [ c_void_p ]
sklib.__sklib__free_font__font.restype = None
sklib.__sklib__get_font_style__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__get_font_style__string_ref.restype = c_int
sklib.__sklib__get_font_style__font.argtypes = [ c_void_p ]
sklib.__sklib__get_font_style__font.restype = c_int
sklib.__sklib__get_system_font.argtypes = [  ]
sklib.__sklib__get_system_font.restype = c_void_p
sklib.__sklib__has_font__font.argtypes = [ c_void_p ]
sklib.__sklib__has_font__font.restype = c_bool
sklib.__sklib__has_font__string.argtypes = [ _sklib_string ]
sklib.__sklib__has_font__string.restype = c_bool
sklib.__sklib__load_font__string_ref__string_ref.argtypes = [ _sklib_string, _sklib_string ]
sklib.__sklib__load_font__string_ref__string_ref.restype = c_void_p
sklib.__sklib__set_font_style__string_ref__font_style.argtypes = [ _sklib_string, c_int ]
sklib.__sklib__set_font_style__string_ref__font_style.restype = None
sklib.__sklib__set_font_style__font__font_style.argtypes = [ c_void_p, c_int ]
sklib.__sklib__set_font_style__font__font_style.restype = None
sklib.__sklib__text_height__string_ref__string_ref__int.argtypes = [ _sklib_string, _sklib_string, c_int ]
sklib.__sklib__text_height__string_ref__string_ref__int.restype = c_int
sklib.__sklib__text_height__string_ref__font__int.argtypes = [ _sklib_string, c_void_p, c_int ]
sklib.__sklib__text_height__string_ref__font__int.restype = c_int
sklib.__sklib__text_width__string_ref__string_ref__int.argtypes = [ _sklib_string, _sklib_string, c_int ]
sklib.__sklib__text_width__string_ref__string_ref__int.restype = c_int
sklib.__sklib__text_width__string_ref__font__int.argtypes = [ _sklib_string, c_void_p, c_int ]
sklib.__sklib__text_width__string_ref__font__int.restype = c_int
sklib.__sklib__draw_collected_text__color__font__int__drawing_options_ref.argtypes = [ _sklib_color, c_void_p, c_int, _sklib_drawing_options ]
sklib.__sklib__draw_collected_text__color__font__int__drawing_options_ref.restype = None
sklib.__sklib__end_reading_text.argtypes = [  ]
sklib.__sklib__end_reading_text.restype = None
sklib.__sklib__end_reading_text__window.argtypes = [ c_void_p ]
sklib.__sklib__end_reading_text__window.restype = None
sklib.__sklib__reading_text.argtypes = [  ]
sklib.__sklib__reading_text.restype = c_bool
sklib.__sklib__reading_text__window.argtypes = [ c_void_p ]
sklib.__sklib__reading_text__window.restype = c_bool
sklib.__sklib__start_reading_text__rectangle.argtypes = [ _sklib_rectangle ]
sklib.__sklib__start_reading_text__rectangle.restype = None
sklib.__sklib__start_reading_text__rectangle__string.argtypes = [ _sklib_rectangle, _sklib_string ]
sklib.__sklib__start_reading_text__rectangle__string.restype = None
sklib.__sklib__start_reading_text__window__rectangle.argtypes = [ c_void_p, _sklib_rectangle ]
sklib.__sklib__start_reading_text__window__rectangle.restype = None
sklib.__sklib__start_reading_text__window__rectangle__string.argtypes = [ c_void_p, _sklib_rectangle, _sklib_string ]
sklib.__sklib__start_reading_text__window__rectangle__string.restype = None
sklib.__sklib__text_entry_cancelled.argtypes = [  ]
sklib.__sklib__text_entry_cancelled.restype = c_bool
sklib.__sklib__text_entry_cancelled__window.argtypes = [ c_void_p ]
sklib.__sklib__text_entry_cancelled__window.restype = c_bool
sklib.__sklib__text_input.argtypes = [  ]
sklib.__sklib__text_input.restype = _sklib_string
sklib.__sklib__text_input__window.argtypes = [ c_void_p ]
sklib.__sklib__text_input__window.restype = _sklib_string
sklib.__sklib__create_timer__string.argtypes = [ _sklib_string ]
sklib.__sklib__create_timer__string.restype = c_void_p
sklib.__sklib__free_all_timers.argtypes = [  ]
sklib.__sklib__free_all_timers.restype = None
sklib.__sklib__free_timer__timer.argtypes = [ c_void_p ]
sklib.__sklib__free_timer__timer.restype = None
sklib.__sklib__has_timer__string.argtypes = [ _sklib_string ]
sklib.__sklib__has_timer__string.restype = c_bool
sklib.__sklib__pause_timer__string.argtypes = [ _sklib_string ]
sklib.__sklib__pause_timer__string.restype = None
sklib.__sklib__pause_timer__timer.argtypes = [ c_void_p ]
sklib.__sklib__pause_timer__timer.restype = None
sklib.__sklib__reset_timer__string.argtypes = [ _sklib_string ]
sklib.__sklib__reset_timer__string.restype = None
sklib.__sklib__reset_timer__timer.argtypes = [ c_void_p ]
sklib.__sklib__reset_timer__timer.restype = None
sklib.__sklib__resume_timer__string.argtypes = [ _sklib_string ]
sklib.__sklib__resume_timer__string.restype = None
sklib.__sklib__resume_timer__timer.argtypes = [ c_void_p ]
sklib.__sklib__resume_timer__timer.restype = None
sklib.__sklib__start_timer__string.argtypes = [ _sklib_string ]
sklib.__sklib__start_timer__string.restype = None
sklib.__sklib__start_timer__timer.argtypes = [ c_void_p ]
sklib.__sklib__start_timer__timer.restype = None
sklib.__sklib__stop_timer__string.argtypes = [ _sklib_string ]
sklib.__sklib__stop_timer__string.restype = None
sklib.__sklib__stop_timer__timer.argtypes = [ c_void_p ]
sklib.__sklib__stop_timer__timer.restype = None
sklib.__sklib__timer_named__string.argtypes = [ _sklib_string ]
sklib.__sklib__timer_named__string.restype = c_void_p
sklib.__sklib__timer_paused__string.argtypes = [ _sklib_string ]
sklib.__sklib__timer_paused__string.restype = c_bool
sklib.__sklib__timer_paused__timer.argtypes = [ c_void_p ]
sklib.__sklib__timer_paused__timer.restype = c_bool
sklib.__sklib__timer_started__string.argtypes = [ _sklib_string ]
sklib.__sklib__timer_started__string.restype = c_bool
sklib.__sklib__timer_started__timer.argtypes = [ c_void_p ]
sklib.__sklib__timer_started__timer.restype = c_bool
sklib.__sklib__timer_ticks__string.argtypes = [ _sklib_string ]
sklib.__sklib__timer_ticks__string.restype = c_uint
sklib.__sklib__timer_ticks__timer.argtypes = [ c_void_p ]
sklib.__sklib__timer_ticks__timer.restype = c_uint
sklib.__sklib__draw_triangle__color__triangle_ref.argtypes = [ _sklib_color, _sklib_triangle ]
sklib.__sklib__draw_triangle__color__triangle_ref.restype = None
sklib.__sklib__draw_triangle__color__triangle_ref__drawing_options.argtypes = [ _sklib_color, _sklib_triangle, _sklib_drawing_options ]
sklib.__sklib__draw_triangle__color__triangle_ref__drawing_options.restype = None
sklib.__sklib__draw_triangle__color__double__double__double__double__double__double.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_triangle__color__double__double__double__double__double__double.restype = None
sklib.__sklib__draw_triangle__color__double__double__double__double__double__double__drawing_options.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_triangle__color__double__double__double__double__double__double__drawing_options.restype = None
sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref.argtypes = [ c_void_p, _sklib_color, _sklib_triangle ]
sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref.restype = None
sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_triangle, _sklib_drawing_options ]
sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options.restype = None
sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double.restype = None
sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options.restype = None
sklib.__sklib__draw_triangle_on_window__window__color__triangle_ref.argtypes = [ c_void_p, _sklib_color, _sklib_triangle ]
sklib.__sklib__draw_triangle_on_window__window__color__triangle_ref.restype = None
sklib.__sklib__draw_triangle_on_window__window__color__triangle_ref__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_triangle, _sklib_drawing_options ]
sklib.__sklib__draw_triangle_on_window__window__color__triangle_ref__drawing_options.restype = None
sklib.__sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double ]
sklib.__sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double.restype = None
sklib.__sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options.restype = None
sklib.__sklib__fill_triangle__color__triangle_ref.argtypes = [ _sklib_color, _sklib_triangle ]
sklib.__sklib__fill_triangle__color__triangle_ref.restype = None
sklib.__sklib__fill_triangle__color__triangle_ref__drawing_options.argtypes = [ _sklib_color, _sklib_triangle, _sklib_drawing_options ]
sklib.__sklib__fill_triangle__color__triangle_ref__drawing_options.restype = None
sklib.__sklib__fill_triangle__color__double__double__double__double__double__double.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double ]
sklib.__sklib__fill_triangle__color__double__double__double__double__double__double.restype = None
sklib.__sklib__fill_triangle__color__double__double__double__double__double__double__drawing_options.argtypes = [ _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_triangle__color__double__double__double__double__double__double__drawing_options.restype = None
sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref.argtypes = [ c_void_p, _sklib_color, _sklib_triangle ]
sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref.restype = None
sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_triangle, _sklib_drawing_options ]
sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options.restype = None
sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double ]
sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double.restype = None
sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options.restype = None
sklib.__sklib__fill_triangle_on_window__window__color__triangle_ref.argtypes = [ c_void_p, _sklib_color, _sklib_triangle ]
sklib.__sklib__fill_triangle_on_window__window__color__triangle_ref.restype = None
sklib.__sklib__fill_triangle_on_window__window__color__triangle_ref__drawing_options.argtypes = [ c_void_p, _sklib_color, _sklib_triangle, _sklib_drawing_options ]
sklib.__sklib__fill_triangle_on_window__window__color__triangle_ref__drawing_options.restype = None
sklib.__sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double ]
sklib.__sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double.restype = None
sklib.__sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options.argtypes = [ c_void_p, _sklib_color, c_double, c_double, c_double, c_double, c_double, c_double, _sklib_drawing_options ]
sklib.__sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options.restype = None
sklib.__sklib__triangle_barycenter__triangle_ref.argtypes = [ _sklib_triangle ]
sklib.__sklib__triangle_barycenter__triangle_ref.restype = _sklib_point_2d
sklib.__sklib__triangle_from__point_2d_ref__point_2d_ref__point_2d_ref.argtypes = [ _sklib_point_2d, _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__triangle_from__point_2d_ref__point_2d_ref__point_2d_ref.restype = _sklib_triangle
sklib.__sklib__triangle_from__double__double__double__double__double__double.argtypes = [ c_double, c_double, c_double, c_double, c_double, c_double ]
sklib.__sklib__triangle_from__double__double__double__double__double__double.restype = _sklib_triangle
sklib.__sklib__triangle_rectangle_intersect__triangle_ref__rectangle_ref.argtypes = [ _sklib_triangle, _sklib_rectangle ]
sklib.__sklib__triangle_rectangle_intersect__triangle_ref__rectangle_ref.restype = c_bool
sklib.__sklib__triangle_to_string__triangle_ref.argtypes = [ _sklib_triangle ]
sklib.__sklib__triangle_to_string__triangle_ref.restype = _sklib_string
sklib.__sklib__triangles_intersect__triangle_ref__triangle_ref.argtypes = [ _sklib_triangle, _sklib_triangle ]
sklib.__sklib__triangles_intersect__triangle_ref__triangle_ref.restype = c_bool
sklib.__sklib__current_ticks.argtypes = [  ]
sklib.__sklib__current_ticks.restype = c_uint
sklib.__sklib__delay__int.argtypes = [ c_int ]
sklib.__sklib__delay__int.restype = None
sklib.__sklib__display_dialog__string_ref__string_ref__font__int.argtypes = [ _sklib_string, _sklib_string, c_void_p, c_int ]
sklib.__sklib__display_dialog__string_ref__string_ref__font__int.restype = None
sklib.__sklib__file_as_string__string__resource_kind.argtypes = [ _sklib_string, c_int ]
sklib.__sklib__file_as_string__string__resource_kind.restype = _sklib_string
sklib.__sklib__angle_between__vector_2d_ref__vector_2d_ref.argtypes = [ _sklib_vector_2d, _sklib_vector_2d ]
sklib.__sklib__angle_between__vector_2d_ref__vector_2d_ref.restype = c_double
sklib.__sklib__dot_product__vector_2d_ref__vector_2d_ref.argtypes = [ _sklib_vector_2d, _sklib_vector_2d ]
sklib.__sklib__dot_product__vector_2d_ref__vector_2d_ref.restype = c_double
sklib.__sklib__is_zero_vector__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__is_zero_vector__vector_2d_ref.restype = c_bool
sklib.__sklib__ray_intersection_point__point_2d_ref__vector_2d_ref__line_ref__point_2d_ref.argtypes = [ _sklib_point_2d, _sklib_vector_2d, _sklib_line, POINTER(_sklib_point_2d) ]
sklib.__sklib__ray_intersection_point__point_2d_ref__vector_2d_ref__line_ref__point_2d_ref.restype = c_bool
sklib.__sklib__unit_vector__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__unit_vector__vector_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_add__vector_2d_ref__vector_2d_ref.argtypes = [ _sklib_vector_2d, _sklib_vector_2d ]
sklib.__sklib__vector_add__vector_2d_ref__vector_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_angle__vector_2d.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__vector_angle__vector_2d.restype = c_double
sklib.__sklib__vector_from_angle__double__double.argtypes = [ c_double, c_double ]
sklib.__sklib__vector_from_angle__double__double.restype = _sklib_vector_2d
sklib.__sklib__vector_from_line__line_ref.argtypes = [ _sklib_line ]
sklib.__sklib__vector_from_line__line_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_from_point_to_rect__point_2d_ref__rectangle_ref.argtypes = [ _sklib_point_2d, _sklib_rectangle ]
sklib.__sklib__vector_from_point_to_rect__point_2d_ref__rectangle_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_in_rect__vector_2d_ref__rectangle_ref.argtypes = [ _sklib_vector_2d, _sklib_rectangle ]
sklib.__sklib__vector_in_rect__vector_2d_ref__rectangle_ref.restype = c_bool
sklib.__sklib__vector_invert__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__vector_invert__vector_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_limit__vector_2d_ref__double.argtypes = [ _sklib_vector_2d, c_double ]
sklib.__sklib__vector_limit__vector_2d_ref__double.restype = _sklib_vector_2d
sklib.__sklib__vector_magnitude__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__vector_magnitude__vector_2d_ref.restype = c_double
sklib.__sklib__vector_magnitude_squared__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__vector_magnitude_squared__vector_2d_ref.restype = c_double
sklib.__sklib__vector_multiply__vector_2d_ref__double.argtypes = [ _sklib_vector_2d, c_double ]
sklib.__sklib__vector_multiply__vector_2d_ref__double.restype = _sklib_vector_2d
sklib.__sklib__vector_normal__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__vector_normal__vector_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_out_of_circle_from_circle__circle_ref__circle_ref__vector_2d_ref.argtypes = [ _sklib_circle, _sklib_circle, _sklib_vector_2d ]
sklib.__sklib__vector_out_of_circle_from_circle__circle_ref__circle_ref__vector_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_out_of_circle_from_point__point_2d_ref__circle_ref__vector_2d_ref.argtypes = [ _sklib_point_2d, _sklib_circle, _sklib_vector_2d ]
sklib.__sklib__vector_out_of_circle_from_point__point_2d_ref__circle_ref__vector_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_out_of_rect_from_circle__circle_ref__rectangle_ref__vector_2d_ref.argtypes = [ _sklib_circle, _sklib_rectangle, _sklib_vector_2d ]
sklib.__sklib__vector_out_of_rect_from_circle__circle_ref__rectangle_ref__vector_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_out_of_rect_from_point__point_2d_ref__rectangle_ref__vector_2d_ref.argtypes = [ _sklib_point_2d, _sklib_rectangle, _sklib_vector_2d ]
sklib.__sklib__vector_out_of_rect_from_point__point_2d_ref__rectangle_ref__vector_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_out_of_rect_from_rect__rectangle_ref__rectangle_ref__vector_2d_ref.argtypes = [ _sklib_rectangle, _sklib_rectangle, _sklib_vector_2d ]
sklib.__sklib__vector_out_of_rect_from_rect__rectangle_ref__rectangle_ref__vector_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_point_to_point__point_2d_ref__point_2d_ref.argtypes = [ _sklib_point_2d, _sklib_point_2d ]
sklib.__sklib__vector_point_to_point__point_2d_ref__point_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_subtract__vector_2d_ref__vector_2d_ref.argtypes = [ _sklib_vector_2d, _sklib_vector_2d ]
sklib.__sklib__vector_subtract__vector_2d_ref__vector_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_to__point_2d_ref.argtypes = [ _sklib_point_2d ]
sklib.__sklib__vector_to__point_2d_ref.restype = _sklib_vector_2d
sklib.__sklib__vector_to__double__double.argtypes = [ c_double, c_double ]
sklib.__sklib__vector_to__double__double.restype = _sklib_vector_2d
sklib.__sklib__vector_to_string__vector_2d_ref.argtypes = [ _sklib_vector_2d ]
sklib.__sklib__vector_to_string__vector_2d_ref.restype = _sklib_string
sklib.__sklib__vectors_equal__vector_2d_ref__vector_2d.argtypes = [ _sklib_vector_2d, _sklib_vector_2d ]
sklib.__sklib__vectors_equal__vector_2d_ref__vector_2d.restype = c_bool
sklib.__sklib__vectors_not_equal__vector_2d_ref__vector_2d.argtypes = [ _sklib_vector_2d, _sklib_vector_2d ]
sklib.__sklib__vectors_not_equal__vector_2d_ref__vector_2d.restype = c_bool
sklib.__sklib__download_bitmap__string_ref__string_ref__unsigned_short.argtypes = [ _sklib_string, _sklib_string, c_ushort ]
sklib.__sklib__download_bitmap__string_ref__string_ref__unsigned_short.restype = c_void_p
sklib.__sklib__download_font__string_ref__string_ref__unsigned_short.argtypes = [ _sklib_string, _sklib_string, c_ushort ]
sklib.__sklib__download_font__string_ref__string_ref__unsigned_short.restype = c_void_p
sklib.__sklib__download_music__string_ref__string_ref__unsigned_short.argtypes = [ _sklib_string, _sklib_string, c_ushort ]
sklib.__sklib__download_music__string_ref__string_ref__unsigned_short.restype = c_void_p
sklib.__sklib__download_sound_effect__string_ref__string_ref__unsigned_short.argtypes = [ _sklib_string, _sklib_string, c_ushort ]
sklib.__sklib__download_sound_effect__string_ref__string_ref__unsigned_short.restype = c_void_p
sklib.__sklib__free_response__http_response.argtypes = [ c_void_p ]
sklib.__sklib__free_response__http_response.restype = None
sklib.__sklib__http_get__string_ref__unsigned_short.argtypes = [ _sklib_string, c_ushort ]
sklib.__sklib__http_get__string_ref__unsigned_short.restype = c_void_p
sklib.__sklib__http_post__string_ref__unsigned_short__string_ref__vector_string_ref.argtypes = [ _sklib_string, c_ushort, _sklib_string, _sklib_vector_string ]
sklib.__sklib__http_post__string_ref__unsigned_short__string_ref__vector_string_ref.restype = c_void_p
sklib.__sklib__http_post__string_ref__unsigned_short__string.argtypes = [ _sklib_string, c_ushort, _sklib_string ]
sklib.__sklib__http_post__string_ref__unsigned_short__string.restype = c_void_p
sklib.__sklib__http_response_to_string__http_response.argtypes = [ c_void_p ]
sklib.__sklib__http_response_to_string__http_response.restype = _sklib_string
sklib.__sklib__save_response_to_file__http_response__string.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__save_response_to_file__http_response__string.restype = None
sklib.__sklib__has_incoming_requests__web_server.argtypes = [ c_void_p ]
sklib.__sklib__has_incoming_requests__web_server.restype = c_bool
sklib.__sklib__is_delete_request_for__http_request__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__is_delete_request_for__http_request__string_ref.restype = c_bool
sklib.__sklib__is_get_request_for__http_request__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__is_get_request_for__http_request__string_ref.restype = c_bool
sklib.__sklib__is_options_request_for__http_request__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__is_options_request_for__http_request__string_ref.restype = c_bool
sklib.__sklib__is_post_request_for__http_request__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__is_post_request_for__http_request__string_ref.restype = c_bool
sklib.__sklib__is_put_request_for__http_request__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__is_put_request_for__http_request__string_ref.restype = c_bool
sklib.__sklib__is_request_for__http_request__http_method__string_ref.argtypes = [ c_void_p, c_int, _sklib_string ]
sklib.__sklib__is_request_for__http_request__http_method__string_ref.restype = c_bool
sklib.__sklib__is_trace_request_for__http_request__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__is_trace_request_for__http_request__string_ref.restype = c_bool
sklib.__sklib__next_web_request__web_server.argtypes = [ c_void_p ]
sklib.__sklib__next_web_request__web_server.restype = c_void_p
sklib.__sklib__request_body__http_request.argtypes = [ c_void_p ]
sklib.__sklib__request_body__http_request.restype = _sklib_string
sklib.__sklib__request_has_query_parameter__http_request__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__request_has_query_parameter__http_request__string_ref.restype = c_bool
sklib.__sklib__request_headers__http_request.argtypes = [ c_void_p ]
sklib.__sklib__request_headers__http_request.restype = _sklib_vector_string
sklib.__sklib__request_method__http_request.argtypes = [ c_void_p ]
sklib.__sklib__request_method__http_request.restype = c_int
sklib.__sklib__request_query_parameter__http_request__string_ref__string_ref.argtypes = [ c_void_p, _sklib_string, _sklib_string ]
sklib.__sklib__request_query_parameter__http_request__string_ref__string_ref.restype = _sklib_string
sklib.__sklib__request_query_string__http_request.argtypes = [ c_void_p ]
sklib.__sklib__request_query_string__http_request.restype = _sklib_string
sklib.__sklib__request_uri__http_request.argtypes = [ c_void_p ]
sklib.__sklib__request_uri__http_request.restype = _sklib_string
sklib.__sklib__request_uri_stubs__http_request.argtypes = [ c_void_p ]
sklib.__sklib__request_uri_stubs__http_request.restype = _sklib_vector_string
sklib.__sklib__send_css_file_response__http_request__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__send_css_file_response__http_request__string_ref.restype = None
sklib.__sklib__send_file_response__http_request__string_ref__string_ref.argtypes = [ c_void_p, _sklib_string, _sklib_string ]
sklib.__sklib__send_file_response__http_request__string_ref__string_ref.restype = None
sklib.__sklib__send_html_file_response__http_request__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__send_html_file_response__http_request__string_ref.restype = None
sklib.__sklib__send_javascript_file_response__http_request__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__send_javascript_file_response__http_request__string_ref.restype = None
sklib.__sklib__send_response__http_request.argtypes = [ c_void_p ]
sklib.__sklib__send_response__http_request.restype = None
sklib.__sklib__send_response__http_request__string_ref.argtypes = [ c_void_p, _sklib_string ]
sklib.__sklib__send_response__http_request__string_ref.restype = None
sklib.__sklib__send_response__http_request__http_status_code.argtypes = [ c_void_p, c_int ]
sklib.__sklib__send_response__http_request__http_status_code.restype = None
sklib.__sklib__send_response__http_request__http_status_code__string_ref.argtypes = [ c_void_p, c_int, _sklib_string ]
sklib.__sklib__send_response__http_request__http_status_code__string_ref.restype = None
sklib.__sklib__send_response__http_request__http_status_code__string_ref__string_ref.argtypes = [ c_void_p, c_int, _sklib_string, _sklib_string ]
sklib.__sklib__send_response__http_request__http_status_code__string_ref__string_ref.restype = None
sklib.__sklib__send_response__http_request__http_status_code__string_ref__string_ref__vector_string_ref.argtypes = [ c_void_p, c_int, _sklib_string, _sklib_string, _sklib_vector_string ]
sklib.__sklib__send_response__http_request__http_status_code__string_ref__string_ref__vector_string_ref.restype = None
sklib.__sklib__send_response__http_request__json.argtypes = [ c_void_p, c_void_p ]
sklib.__sklib__send_response__http_request__json.restype = None
sklib.__sklib__split_uri_stubs__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__split_uri_stubs__string_ref.restype = _sklib_vector_string
sklib.__sklib__start_web_server.argtypes = [  ]
sklib.__sklib__start_web_server.restype = c_void_p
sklib.__sklib__start_web_server__unsigned_short.argtypes = [ c_ushort ]
sklib.__sklib__start_web_server__unsigned_short.restype = c_void_p
sklib.__sklib__stop_web_server__web_server.argtypes = [ c_void_p ]
sklib.__sklib__stop_web_server__web_server.restype = None
sklib.__sklib__clear_window__window__color.argtypes = [ c_void_p, _sklib_color ]
sklib.__sklib__clear_window__window__color.restype = None
sklib.__sklib__close_all_windows.argtypes = [  ]
sklib.__sklib__close_all_windows.restype = None
sklib.__sklib__close_current_window.argtypes = [  ]
sklib.__sklib__close_current_window.restype = None
sklib.__sklib__close_window__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__close_window__string_ref.restype = None
sklib.__sklib__close_window__window.argtypes = [ c_void_p ]
sklib.__sklib__close_window__window.restype = None
sklib.__sklib__current_window.argtypes = [  ]
sklib.__sklib__current_window.restype = c_void_p
sklib.__sklib__current_window_has_border.argtypes = [  ]
sklib.__sklib__current_window_has_border.restype = c_bool
sklib.__sklib__current_window_height.argtypes = [  ]
sklib.__sklib__current_window_height.restype = c_int
sklib.__sklib__current_window_is_fullscreen.argtypes = [  ]
sklib.__sklib__current_window_is_fullscreen.restype = c_bool
sklib.__sklib__current_window_position.argtypes = [  ]
sklib.__sklib__current_window_position.restype = _sklib_point_2d
sklib.__sklib__current_window_toggle_border.argtypes = [  ]
sklib.__sklib__current_window_toggle_border.restype = None
sklib.__sklib__current_window_toggle_fullscreen.argtypes = [  ]
sklib.__sklib__current_window_toggle_fullscreen.restype = None
sklib.__sklib__current_window_width.argtypes = [  ]
sklib.__sklib__current_window_width.restype = c_int
sklib.__sklib__current_window_x.argtypes = [  ]
sklib.__sklib__current_window_x.restype = c_int
sklib.__sklib__current_window_y.argtypes = [  ]
sklib.__sklib__current_window_y.restype = c_int
sklib.__sklib__has_window__string.argtypes = [ _sklib_string ]
sklib.__sklib__has_window__string.restype = c_bool
sklib.__sklib__is_current_window__window.argtypes = [ c_void_p ]
sklib.__sklib__is_current_window__window.restype = c_bool
sklib.__sklib__move_current_window_to__int__int.argtypes = [ c_int, c_int ]
sklib.__sklib__move_current_window_to__int__int.restype = None
sklib.__sklib__move_window_to__string_ref__int__int.argtypes = [ _sklib_string, c_int, c_int ]
sklib.__sklib__move_window_to__string_ref__int__int.restype = None
sklib.__sklib__move_window_to__window__int__int.argtypes = [ c_void_p, c_int, c_int ]
sklib.__sklib__move_window_to__window__int__int.restype = None
sklib.__sklib__open_window__string__int__int.argtypes = [ _sklib_string, c_int, c_int ]
sklib.__sklib__open_window__string__int__int.restype = c_void_p
sklib.__sklib__refresh_window__window.argtypes = [ c_void_p ]
sklib.__sklib__refresh_window__window.restype = None
sklib.__sklib__refresh_window__window__unsigned_int.argtypes = [ c_void_p, c_uint ]
sklib.__sklib__refresh_window__window__unsigned_int.restype = None
sklib.__sklib__resize_current_window__int__int.argtypes = [ c_int, c_int ]
sklib.__sklib__resize_current_window__int__int.restype = None
sklib.__sklib__resize_window__window__int__int.argtypes = [ c_void_p, c_int, c_int ]
sklib.__sklib__resize_window__window__int__int.restype = None
sklib.__sklib__set_current_window__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__set_current_window__string_ref.restype = None
sklib.__sklib__set_current_window__window.argtypes = [ c_void_p ]
sklib.__sklib__set_current_window__window.restype = None
sklib.__sklib__window_caption__window.argtypes = [ c_void_p ]
sklib.__sklib__window_caption__window.restype = _sklib_string
sklib.__sklib__window_close_requested__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__window_close_requested__string_ref.restype = c_bool
sklib.__sklib__window_close_requested__window.argtypes = [ c_void_p ]
sklib.__sklib__window_close_requested__window.restype = c_bool
sklib.__sklib__window_has_border__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__window_has_border__string_ref.restype = c_bool
sklib.__sklib__window_has_border__window.argtypes = [ c_void_p ]
sklib.__sklib__window_has_border__window.restype = c_bool
sklib.__sklib__window_has_focus__window.argtypes = [ c_void_p ]
sklib.__sklib__window_has_focus__window.restype = c_bool
sklib.__sklib__window_height__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__window_height__string_ref.restype = c_int
sklib.__sklib__window_height__window.argtypes = [ c_void_p ]
sklib.__sklib__window_height__window.restype = c_int
sklib.__sklib__window_is_fullscreen__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__window_is_fullscreen__string_ref.restype = c_bool
sklib.__sklib__window_is_fullscreen__window.argtypes = [ c_void_p ]
sklib.__sklib__window_is_fullscreen__window.restype = c_bool
sklib.__sklib__window_named__string.argtypes = [ _sklib_string ]
sklib.__sklib__window_named__string.restype = c_void_p
sklib.__sklib__window_position__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__window_position__string_ref.restype = _sklib_point_2d
sklib.__sklib__window_position__window.argtypes = [ c_void_p ]
sklib.__sklib__window_position__window.restype = _sklib_point_2d
sklib.__sklib__window_set_icon__window__bitmap.argtypes = [ c_void_p, c_void_p ]
sklib.__sklib__window_set_icon__window__bitmap.restype = None
sklib.__sklib__window_toggle_border__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__window_toggle_border__string_ref.restype = None
sklib.__sklib__window_toggle_border__window.argtypes = [ c_void_p ]
sklib.__sklib__window_toggle_border__window.restype = None
sklib.__sklib__window_toggle_fullscreen__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__window_toggle_fullscreen__string_ref.restype = None
sklib.__sklib__window_toggle_fullscreen__window.argtypes = [ c_void_p ]
sklib.__sklib__window_toggle_fullscreen__window.restype = None
sklib.__sklib__window_width__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__window_width__string_ref.restype = c_int
sklib.__sklib__window_width__window.argtypes = [ c_void_p ]
sklib.__sklib__window_width__window.restype = c_int
sklib.__sklib__window_with_focus.argtypes = [  ]
sklib.__sklib__window_with_focus.restype = c_void_p
sklib.__sklib__window_x__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__window_x__string_ref.restype = c_int
sklib.__sklib__window_x__window.argtypes = [ c_void_p ]
sklib.__sklib__window_x__window.restype = c_int
sklib.__sklib__window_y__string_ref.argtypes = [ _sklib_string ]
sklib.__sklib__window_y__string_ref.restype = c_int
sklib.__sklib__window_y__window.argtypes = [ c_void_p ]
sklib.__sklib__window_y__window.restype = c_int

def animation_count ( script ):
    __skparam__script = __skadapter__to_sklib_animation_script(script)
    __skreturn = sklib.__sklib__animation_count__animation_script(__skparam__script)
    return __skadapter__to_int(__skreturn)
def animation_current_cell ( anim ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skreturn = sklib.__sklib__animation_current_cell__animation(__skparam__anim)
    return __skadapter__to_int(__skreturn)
def animation_current_vector ( anim ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skreturn = sklib.__sklib__animation_current_vector__animation(__skparam__anim)
    return __skadapter__to_vector_2d(__skreturn)
def animation_ended ( anim ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skreturn = sklib.__sklib__animation_ended__animation(__skparam__anim)
    return __skadapter__to_bool(__skreturn)
def animation_entered_frame ( anim ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skreturn = sklib.__sklib__animation_entered_frame__animation(__skparam__anim)
    return __skadapter__to_bool(__skreturn)
def animation_frame_time ( anim ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skreturn = sklib.__sklib__animation_frame_time__animation(__skparam__anim)
    return __skadapter__to_float(__skreturn)
def animation_index ( script, name ):
    __skparam__script = __skadapter__to_sklib_animation_script(script)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__animation_index__animation_script__string_ref(__skparam__script, __skparam__name)
    return __skadapter__to_int(__skreturn)
def animation_name ( temp ):
    __skparam__temp = __skadapter__to_sklib_animation(temp)
    __skreturn = sklib.__sklib__animation_name__animation(__skparam__temp)
    return __skadapter__to_string(__skreturn)
def animation_script_name ( script ):
    __skparam__script = __skadapter__to_sklib_animation_script(script)
    __skreturn = sklib.__sklib__animation_script_name__animation_script(__skparam__script)
    return __skadapter__to_string(__skreturn)
def animation_script_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__animation_script_named__string_ref(__skparam__name)
    return __skadapter__to_animation_script(__skreturn)
def assign_animation_with_script ( anim, script, name ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__script = __skadapter__to_sklib_animation_script(script)
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__assign_animation__animation__animation_script__string_ref(__skparam__anim, __skparam__script, __skparam__name)
def assign_animation_with_script_and_sound ( anim, script, name, with_sound ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__script = __skadapter__to_sklib_animation_script(script)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__assign_animation__animation__animation_script__string_ref__bool(__skparam__anim, __skparam__script, __skparam__name, __skparam__with_sound)
def assign_animation_index_with_script ( anim, script, idx ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__script = __skadapter__to_sklib_animation_script(script)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    sklib.__sklib__assign_animation__animation__animation_script__int(__skparam__anim, __skparam__script, __skparam__idx)
def assign_animation_index_with_script_and_sound ( anim, script, idx, with_sound ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__script = __skadapter__to_sklib_animation_script(script)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__assign_animation__animation__animation_script__int__bool(__skparam__anim, __skparam__script, __skparam__idx, __skparam__with_sound)
def assign_animation_with_script_named ( anim, script_name, name ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__script_name = __skadapter__to_sklib_string(script_name)
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__assign_animation__animation__string_ref__string_ref(__skparam__anim, __skparam__script_name, __skparam__name)
def assign_animation_with_script_named_and_sound ( anim, script_name, name, with_sound ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__script_name = __skadapter__to_sklib_string(script_name)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__assign_animation__animation__string_ref__string_ref__bool(__skparam__anim, __skparam__script_name, __skparam__name, __skparam__with_sound)
def assign_animation_index ( anim, idx ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    sklib.__sklib__assign_animation__animation__int(__skparam__anim, __skparam__idx)
def assign_animation_index_with_sound ( anim, idx, with_sound ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__assign_animation__animation__int__bool(__skparam__anim, __skparam__idx, __skparam__with_sound)
def assign_animation ( anim, name ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__assign_animation__animation__string(__skparam__anim, __skparam__name)
def assign_animation_with_sound ( anim, name, with_sound ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__assign_animation__animation__string__bool(__skparam__anim, __skparam__name, __skparam__with_sound)
def create_animation_from_index_with_sound ( script, idx, with_sound ):
    __skparam__script = __skadapter__to_sklib_animation_script(script)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    __skreturn = sklib.__sklib__create_animation__animation_script__int__bool(__skparam__script, __skparam__idx, __skparam__with_sound)
    return __skadapter__to_animation(__skreturn)
def create_animation ( script, name ):
    __skparam__script = __skadapter__to_sklib_animation_script(script)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__create_animation__animation_script__string_ref(__skparam__script, __skparam__name)
    return __skadapter__to_animation(__skreturn)
def create_animation_with_sound ( script, name, with_sound ):
    __skparam__script = __skadapter__to_sklib_animation_script(script)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    __skreturn = sklib.__sklib__create_animation__animation_script__string_ref__bool(__skparam__script, __skparam__name, __skparam__with_sound)
    return __skadapter__to_animation(__skreturn)
def create_animation_from_script_named ( script_name, name ):
    __skparam__script_name = __skadapter__to_sklib_string(script_name)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__create_animation__string_ref__string_ref(__skparam__script_name, __skparam__name)
    return __skadapter__to_animation(__skreturn)
def create_animation_from_script_named_with_sound ( script_name, name, with_sound ):
    __skparam__script_name = __skadapter__to_sklib_string(script_name)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    __skreturn = sklib.__sklib__create_animation__string_ref__string_ref__bool(__skparam__script_name, __skparam__name, __skparam__with_sound)
    return __skadapter__to_animation(__skreturn)
def free_all_animation_scripts (  ):
    sklib.__sklib__free_all_animation_scripts()
def free_animation ( ani ):
    __skparam__ani = __skadapter__to_sklib_animation(ani)
    sklib.__sklib__free_animation__animation(__skparam__ani)
def free_animation_script ( script_to_free ):
    __skparam__script_to_free = __skadapter__to_sklib_animation_script(script_to_free)
    sklib.__sklib__free_animation_script__animation_script(__skparam__script_to_free)
def free_animation_script_with_name ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__free_animation_script__string_ref(__skparam__name)
def has_animation_named ( script, name ):
    __skparam__script = __skadapter__to_sklib_animation_script(script)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_animation_named__animation_script__string_ref(__skparam__script, __skparam__name)
    return __skadapter__to_bool(__skreturn)
def has_animation_script ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_animation_script__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def load_animation_script ( name, filename ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__filename = __skadapter__to_sklib_string(filename)
    __skreturn = sklib.__sklib__load_animation_script__string_ref__string_ref(__skparam__name, __skparam__filename)
    return __skadapter__to_animation_script(__skreturn)
def restart_animation ( anim ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    sklib.__sklib__restart_animation__animation(__skparam__anim)
def restart_animation_with_sound ( anim, with_sound ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__restart_animation__animation__bool(__skparam__anim, __skparam__with_sound)
def update_animation_percent_with_sound ( anim, pct, with_sound ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__pct = __skadapter__to_sklib_float(pct)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__update_animation__animation__float__bool(__skparam__anim, __skparam__pct, __skparam__with_sound)
def update_animation ( anim ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    sklib.__sklib__update_animation__animation(__skparam__anim)
def update_animation_percent ( anim, pct ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__pct = __skadapter__to_sklib_float(pct)
    sklib.__sklib__update_animation__animation__float(__skparam__anim, __skparam__pct)
def audio_ready (  ):
    __skreturn = sklib.__sklib__audio_ready()
    return __skadapter__to_bool(__skreturn)
def close_audio (  ):
    sklib.__sklib__close_audio()
def open_audio (  ):
    sklib.__sklib__open_audio()
def contains ( text, subtext ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__subtext = __skadapter__to_sklib_string(subtext)
    __skreturn = sklib.__sklib__contains__string_ref__string_ref(__skparam__text, __skparam__subtext)
    return __skadapter__to_bool(__skreturn)
def convert_to_double ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skreturn = sklib.__sklib__convert_to_double__string_ref(__skparam__text)
    return __skadapter__to_double(__skreturn)
def convert_to_integer ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skreturn = sklib.__sklib__convert_to_integer__string_ref(__skparam__text)
    return __skadapter__to_int(__skreturn)
def index_of ( text, subtext ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__subtext = __skadapter__to_sklib_string(subtext)
    __skreturn = sklib.__sklib__index_of__string_ref__string_ref(__skparam__text, __skparam__subtext)
    return __skadapter__to_int(__skreturn)
def is_double ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skreturn = sklib.__sklib__is_double__string_ref(__skparam__text)
    return __skadapter__to_bool(__skreturn)
def is_integer ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skreturn = sklib.__sklib__is_integer__string_ref(__skparam__text)
    return __skadapter__to_bool(__skreturn)
def is_number ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skreturn = sklib.__sklib__is_number__string_ref(__skparam__text)
    return __skadapter__to_bool(__skreturn)
def length_of ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skreturn = sklib.__sklib__length_of__string_ref(__skparam__text)
    return __skadapter__to_int(__skreturn)
def replace_all ( text, substr, newtext ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__substr = __skadapter__to_sklib_string(substr)
    __skparam__newtext = __skadapter__to_sklib_string(newtext)
    __skreturn = sklib.__sklib__replace_all__string_ref__string_ref__string_ref(__skparam__text, __skparam__substr, __skparam__newtext)
    return __skadapter__to_string(__skreturn)
def split ( text, delimiter ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__delimiter = __skadapter__to_sklib_char(delimiter)
    __skreturn = sklib.__sklib__split__string_ref__char(__skparam__text, __skparam__delimiter)
    return __skadapter__to_vector_string(__skreturn)
def to_lowercase ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skreturn = sklib.__sklib__to_lowercase__string_ref(__skparam__text)
    return __skadapter__to_string(__skreturn)
def to_uppercase ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skreturn = sklib.__sklib__to_uppercase__string_ref(__skparam__text)
    return __skadapter__to_string(__skreturn)
def trim ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skreturn = sklib.__sklib__trim__string_ref(__skparam__text)
    return __skadapter__to_string(__skreturn)
def free_resource_bundle ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__free_resource_bundle__string(__skparam__name)
def has_resource_bundle ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_resource_bundle__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def load_resource_bundle ( name, filename ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__filename = __skadapter__to_sklib_string(filename)
    sklib.__sklib__load_resource_bundle__string_ref__string_ref(__skparam__name, __skparam__filename)
def camera_position (  ):
    __skreturn = sklib.__sklib__camera_position()
    return __skadapter__to_point_2d(__skreturn)
def camera_x (  ):
    __skreturn = sklib.__sklib__camera_x()
    return __skadapter__to_double(__skreturn)
def camera_y (  ):
    __skreturn = sklib.__sklib__camera_y()
    return __skadapter__to_double(__skreturn)
def center_camera_on_vector ( s, offset ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__offset = __skadapter__to_sklib_vector_2d(offset)
    sklib.__sklib__center_camera_on__sprite__vector_2d_ref(__skparam__s, __skparam__offset)
def center_camera_on ( s, offset_x, offset_y ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__offset_x = __skadapter__to_sklib_double(offset_x)
    __skparam__offset_y = __skadapter__to_sklib_double(offset_y)
    sklib.__sklib__center_camera_on__sprite__double__double(__skparam__s, __skparam__offset_x, __skparam__offset_y)
def move_camera_by_vector ( offset ):
    __skparam__offset = __skadapter__to_sklib_vector_2d(offset)
    sklib.__sklib__move_camera_by__vector_2d_ref(__skparam__offset)
def move_camera_by ( dx, dy ):
    __skparam__dx = __skadapter__to_sklib_double(dx)
    __skparam__dy = __skadapter__to_sklib_double(dy)
    sklib.__sklib__move_camera_by__double__double(__skparam__dx, __skparam__dy)
def move_camera_to_point ( pt ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    sklib.__sklib__move_camera_to__point_2d_ref(__skparam__pt)
def move_camera_to ( x, y ):
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__move_camera_to__double__double(__skparam__x, __skparam__y)
def point_in_window ( wind, pt ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__point_in_window__window__point_2d_ref(__skparam__wind, __skparam__pt)
    return __skadapter__to_bool(__skreturn)
def point_on_screen ( pt ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__point_on_screen__point_2d_ref(__skparam__pt)
    return __skadapter__to_bool(__skreturn)
def rect_in_window ( wind, rect ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__rect_in_window__window__rectangle_ref(__skparam__wind, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def rect_on_screen ( rect ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__rect_on_screen__rectangle_ref(__skparam__rect)
    return __skadapter__to_bool(__skreturn)
def screen_center (  ):
    __skreturn = sklib.__sklib__screen_center()
    return __skadapter__to_point_2d(__skreturn)
def screen_rectangle (  ):
    __skreturn = sklib.__sklib__screen_rectangle()
    return __skadapter__to_rectangle(__skreturn)
def set_camera_position ( pos ):
    __skparam__pos = __skadapter__to_sklib_point_2d(pos)
    sklib.__sklib__set_camera_position__point_2d(__skparam__pos)
def set_camera_x ( x ):
    __skparam__x = __skadapter__to_sklib_double(x)
    sklib.__sklib__set_camera_x__double(__skparam__x)
def set_camera_y ( y ):
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__set_camera_y__double(__skparam__y)
def to_screen_point ( pt ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__to_screen__point_2d_ref(__skparam__pt)
    return __skadapter__to_point_2d(__skreturn)
def to_screen_rectangle ( rect ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__to_screen__rectangle_ref(__skparam__rect)
    return __skadapter__to_rectangle(__skreturn)
def to_screen_x ( world_x ):
    __skparam__world_x = __skadapter__to_sklib_double(world_x)
    __skreturn = sklib.__sklib__to_screen_x__double(__skparam__world_x)
    return __skadapter__to_double(__skreturn)
def to_screen_y ( world_y ):
    __skparam__world_y = __skadapter__to_sklib_double(world_y)
    __skreturn = sklib.__sklib__to_screen_y__double(__skparam__world_y)
    return __skadapter__to_double(__skreturn)
def to_world ( pt ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__to_world__point_2d_ref(__skparam__pt)
    return __skadapter__to_point_2d(__skreturn)
def to_world_x ( screen_x ):
    __skparam__screen_x = __skadapter__to_sklib_double(screen_x)
    __skreturn = sklib.__sklib__to_world_x__double(__skparam__screen_x)
    return __skadapter__to_double(__skreturn)
def to_world_y ( screen_y ):
    __skparam__screen_y = __skadapter__to_sklib_double(screen_y)
    __skreturn = sklib.__sklib__to_world_y__double(__skparam__screen_y)
    return __skadapter__to_double(__skreturn)
def vector_world_to_screen (  ):
    __skreturn = sklib.__sklib__vector_world_to_screen()
    return __skadapter__to_vector_2d(__skreturn)
def window_area ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skreturn = sklib.__sklib__window_area__window(__skparam__wind)
    return __skadapter__to_rectangle(__skreturn)
def draw_circle_record ( clr, c ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__c = __skadapter__to_sklib_circle(c)
    sklib.__sklib__draw_circle__color__circle_ref(__skparam__clr, __skparam__c)
def draw_circle_record_with_options ( clr, c, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_circle__color__circle_ref__drawing_options(__skparam__clr, __skparam__c, __skparam__opts)
def draw_circle ( clr, x, y, radius ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    sklib.__sklib__draw_circle__color__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius)
def draw_circle_with_options ( clr, x, y, radius, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_circle__color__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts)
def draw_circle_on_bitmap ( destination, clr, x, y, radius ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    sklib.__sklib__draw_circle_on_bitmap__bitmap__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius)
def draw_circle_on_bitmap_with_options ( destination, clr, x, y, radius, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts)
def draw_circle_on_window ( destination, clr, x, y, radius ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    sklib.__sklib__draw_circle_on_window__window__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius)
def draw_circle_on_window_with_options ( destination, clr, x, y, radius, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_circle_on_window__window__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts)
def fill_circle_record ( clr, c ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__c = __skadapter__to_sklib_circle(c)
    sklib.__sklib__fill_circle__color__circle_ref(__skparam__clr, __skparam__c)
def fill_circle_record_with_options ( clr, c, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_circle__color__circle_ref__drawing_options(__skparam__clr, __skparam__c, __skparam__opts)
def fill_circle ( clr, x, y, radius ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    sklib.__sklib__fill_circle__color__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius)
def fill_circle_with_options ( clr, x, y, radius, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_circle__color__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts)
def fill_circle_on_bitmap ( destination, clr, x, y, radius ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    sklib.__sklib__fill_circle_on_bitmap__bitmap__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius)
def fill_circle_on_bitmap_with_options ( destination, clr, x, y, radius, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts)
def fill_circle_on_window ( destination, clr, x, y, radius ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    sklib.__sklib__fill_circle_on_window__window__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius)
def fill_circle_on_window_with_options ( destination, clr, x, y, radius, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_circle_on_window__window__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts)
def center_point ( c ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skreturn = sklib.__sklib__center_point__circle_ref(__skparam__c)
    return __skadapter__to_point_2d(__skreturn)
def circle_at ( pt, radius ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    __skreturn = sklib.__sklib__circle_at__point_2d_ref__double(__skparam__pt, __skparam__radius)
    return __skadapter__to_circle(__skreturn)
def circle_at_from_points ( x, y, radius ):
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    __skreturn = sklib.__sklib__circle_at__double__double__double(__skparam__x, __skparam__y, __skparam__radius)
    return __skadapter__to_circle(__skreturn)
def circle_radius ( c ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skreturn = sklib.__sklib__circle_radius__circle(__skparam__c)
    return __skadapter__to_float(__skreturn)
def circle_triangle_intersect ( c, tri ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skreturn = sklib.__sklib__circle_triangle_intersect__circle_ref__triangle_ref(__skparam__c, __skparam__tri)
    return __skadapter__to_bool(__skreturn)
def circle_triangle_intersect_get_closest_point ( c, tri, p ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skparam__p = __skadapter__to_sklib_point_2d(p)
    __skreturn = sklib.__sklib__circle_triangle_intersect__circle_ref__triangle_ref__point_2d_ref(__skparam__c, __skparam__tri, byref(__skparam__p))
    p = __skadapter__to_point_2d(__skparam__p)
    return __skadapter__to_bool(__skreturn)
def circle_x ( c ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skreturn = sklib.__sklib__circle_x__circle_ref(__skparam__c)
    return __skadapter__to_float(__skreturn)
def circle_y ( c ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skreturn = sklib.__sklib__circle_y__circle_ref(__skparam__c)
    return __skadapter__to_float(__skreturn)
def circles_intersect ( c1, c2 ):
    __skparam__c1 = __skadapter__to_sklib_circle(c1)
    __skparam__c2 = __skadapter__to_sklib_circle(c2)
    __skreturn = sklib.__sklib__circles_intersect__circle__circle(__skparam__c1, __skparam__c2)
    return __skadapter__to_bool(__skreturn)
def circles_intersect_using_values ( c1_x, c1_y, c1_radius, c2_x, c2_y, c2_radius ):
    __skparam__c1_x = __skadapter__to_sklib_double(c1_x)
    __skparam__c1_y = __skadapter__to_sklib_double(c1_y)
    __skparam__c1_radius = __skadapter__to_sklib_double(c1_radius)
    __skparam__c2_x = __skadapter__to_sklib_double(c2_x)
    __skparam__c2_y = __skadapter__to_sklib_double(c2_y)
    __skparam__c2_radius = __skadapter__to_sklib_double(c2_radius)
    __skreturn = sklib.__sklib__circles_intersect__double__double__double__double__double__double(__skparam__c1_x, __skparam__c1_y, __skparam__c1_radius, __skparam__c2_x, __skparam__c2_y, __skparam__c2_radius)
    return __skadapter__to_bool(__skreturn)
def closest_point_on_circle ( from_pt, c ):
    __skparam__from_pt = __skadapter__to_sklib_point_2d(from_pt)
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skreturn = sklib.__sklib__closest_point_on_circle__point_2d_ref__circle_ref(__skparam__from_pt, __skparam__c)
    return __skadapter__to_point_2d(__skreturn)
def closest_point_on_line_from_circle ( c, l ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__l = __skadapter__to_sklib_line(l)
    __skreturn = sklib.__sklib__closest_point_on_line_from_circle__circle_ref__line_ref(__skparam__c, __skparam__l)
    return __skadapter__to_point_2d(__skreturn)
def closest_point_on_rect_from_circle ( c, rect ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__closest_point_on_rect_from_circle__circle_ref__rectangle_ref(__skparam__c, __skparam__rect)
    return __skadapter__to_point_2d(__skreturn)
def closest_point_on_triangle_from_circle ( c, tri ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skreturn = sklib.__sklib__closest_point_on_triangle_from_circle__circle_ref__triangle_ref(__skparam__c, __skparam__tri)
    return __skadapter__to_point_2d(__skreturn)
def distant_point_on_circle ( pt, c ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skreturn = sklib.__sklib__distant_point_on_circle__point_2d_ref__circle_ref(__skparam__pt, __skparam__c)
    return __skadapter__to_point_2d(__skreturn)
def distant_point_on_circle_heading ( pt, c, heading, opposite_pt ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__heading = __skadapter__to_sklib_vector_2d(heading)
    __skparam__opposite_pt = __skadapter__to_sklib_point_2d(opposite_pt)
    __skreturn = sklib.__sklib__distant_point_on_circle_heading__point_2d_ref__circle_ref__vector_2d_ref__point_2d_ref(__skparam__pt, __skparam__c, __skparam__heading, byref(__skparam__opposite_pt))
    opposite_pt = __skadapter__to_point_2d(__skparam__opposite_pt)
    return __skadapter__to_bool(__skreturn)
def ray_circle_intersect_distance ( ray_origin, ray_heading, c ):
    __skparam__ray_origin = __skadapter__to_sklib_point_2d(ray_origin)
    __skparam__ray_heading = __skadapter__to_sklib_vector_2d(ray_heading)
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skreturn = sklib.__sklib__ray_circle_intersect_distance__point_2d_ref__vector_2d_ref__circle_ref(__skparam__ray_origin, __skparam__ray_heading, __skparam__c)
    return __skadapter__to_float(__skreturn)
def tangent_points ( from_pt, c, p1, p2 ):
    __skparam__from_pt = __skadapter__to_sklib_point_2d(from_pt)
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__p1 = __skadapter__to_sklib_point_2d(p1)
    __skparam__p2 = __skadapter__to_sklib_point_2d(p2)
    __skreturn = sklib.__sklib__tangent_points__point_2d_ref__circle_ref__point_2d_ref__point_2d_ref(__skparam__from_pt, __skparam__c, byref(__skparam__p1), byref(__skparam__p2))
    p1 = __skadapter__to_point_2d(__skparam__p1)
    p2 = __skadapter__to_point_2d(__skparam__p2)
    return __skadapter__to_bool(__skreturn)
def widest_points ( c, along, pt1, pt2 ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__along = __skadapter__to_sklib_vector_2d(along)
    __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1)
    __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2)
    sklib.__sklib__widest_points__circle_ref__vector_2d_ref__point_2d_ref__point_2d_ref(__skparam__c, __skparam__along, byref(__skparam__pt1), byref(__skparam__pt2))
    pt1 = __skadapter__to_point_2d(__skparam__pt1)
    pt2 = __skadapter__to_point_2d(__skparam__pt2)
def current_clip (  ):
    __skreturn = sklib.__sklib__current_clip()
    return __skadapter__to_rectangle(__skreturn)
def current_clip_for_bitmap ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__current_clip__bitmap(__skparam__bmp)
    return __skadapter__to_rectangle(__skreturn)
def current_clip_for_window ( wnd ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skreturn = sklib.__sklib__current_clip__window(__skparam__wnd)
    return __skadapter__to_rectangle(__skreturn)
def pop_clip_for_window ( wnd ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    sklib.__sklib__pop_clip__window(__skparam__wnd)
def pop_clip (  ):
    sklib.__sklib__pop_clip()
def pop_clip_for_bitmap ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    sklib.__sklib__pop_clip__bitmap(__skparam__bmp)
def push_clip_for_window ( wnd, r ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skparam__r = __skadapter__to_sklib_rectangle(r)
    sklib.__sklib__push_clip__window__rectangle_ref(__skparam__wnd, __skparam__r)
def push_clip_for_bitmap ( bmp, r ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__r = __skadapter__to_sklib_rectangle(r)
    sklib.__sklib__push_clip__bitmap__rectangle_ref(__skparam__bmp, __skparam__r)
def push_clip ( r ):
    __skparam__r = __skadapter__to_sklib_rectangle(r)
    sklib.__sklib__push_clip__rectangle_ref(__skparam__r)
def reset_clip_for_bitmap ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    sklib.__sklib__reset_clip__bitmap(__skparam__bmp)
def reset_clip (  ):
    sklib.__sklib__reset_clip()
def reset_clip_for_window ( wnd ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    sklib.__sklib__reset_clip__window(__skparam__wnd)
def set_clip ( r ):
    __skparam__r = __skadapter__to_sklib_rectangle(r)
    sklib.__sklib__set_clip__rectangle_ref(__skparam__r)
def set_clip_for_bitmap ( bmp, r ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__r = __skadapter__to_sklib_rectangle(r)
    sklib.__sklib__set_clip__bitmap__rectangle_ref(__skparam__bmp, __skparam__r)
def set_clip_for_window ( wnd, r ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skparam__r = __skadapter__to_sklib_rectangle(r)
    sklib.__sklib__set_clip__window__rectangle_ref(__skparam__wnd, __skparam__r)
def bitmap_circle_collision_at_point ( bmp, pt, circ ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__circ = __skadapter__to_sklib_circle(circ)
    __skreturn = sklib.__sklib__bitmap_circle_collision__bitmap__point_2d_ref__circle_ref(__skparam__bmp, __skparam__pt, __skparam__circ)
    return __skadapter__to_bool(__skreturn)
def bitmap_circle_collision ( bmp, x, y, circ ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__circ = __skadapter__to_sklib_circle(circ)
    __skreturn = sklib.__sklib__bitmap_circle_collision__bitmap__double__double__circle_ref(__skparam__bmp, __skparam__x, __skparam__y, __skparam__circ)
    return __skadapter__to_bool(__skreturn)
def bitmap_circle_collision_for_cell_with_translation ( bmp, cell, translation, circ ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__translation = __skadapter__to_sklib_matrix_2d(translation)
    __skparam__circ = __skadapter__to_sklib_circle(circ)
    __skreturn = sklib.__sklib__bitmap_circle_collision__bitmap__int__matrix_2d_ref__circle_ref(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__circ)
    return __skadapter__to_bool(__skreturn)
def bitmap_circle_collision_for_cell_at_point ( bmp, cell, pt, circ ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__circ = __skadapter__to_sklib_circle(circ)
    __skreturn = sklib.__sklib__bitmap_circle_collision__bitmap__int__point_2d_ref__circle_ref(__skparam__bmp, __skparam__cell, __skparam__pt, __skparam__circ)
    return __skadapter__to_bool(__skreturn)
def bitmap_circle_collision_for_cell ( bmp, cell, x, y, circ ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__circ = __skadapter__to_sklib_circle(circ)
    __skreturn = sklib.__sklib__bitmap_circle_collision__bitmap__int__double__double__circle_ref(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y, __skparam__circ)
    return __skadapter__to_bool(__skreturn)
def bitmap_collision ( bmp1, x1, y1, bmp2, x2, y2 ):
    __skparam__bmp1 = __skadapter__to_sklib_bitmap(bmp1)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__bmp2 = __skadapter__to_sklib_bitmap(bmp2)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skreturn = sklib.__sklib__bitmap_collision__bitmap__double__double__bitmap__double__double(__skparam__bmp1, __skparam__x1, __skparam__y1, __skparam__bmp2, __skparam__x2, __skparam__y2)
    return __skadapter__to_bool(__skreturn)
def bitmap_collision_at_points ( bmp1, pt1, bmp2, pt2 ):
    __skparam__bmp1 = __skadapter__to_sklib_bitmap(bmp1)
    __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1)
    __skparam__bmp2 = __skadapter__to_sklib_bitmap(bmp2)
    __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2)
    __skreturn = sklib.__sklib__bitmap_collision__bitmap__point_2d_ref__bitmap__point_2d_ref(__skparam__bmp1, __skparam__pt1, __skparam__bmp2, __skparam__pt2)
    return __skadapter__to_bool(__skreturn)
def bitmap_collision_for_cells_with_translations ( bmp1, cell1, matrix1, bmp2, cell2, matrix2 ):
    __skparam__bmp1 = __skadapter__to_sklib_bitmap(bmp1)
    __skparam__cell1 = __skadapter__to_sklib_int(cell1)
    __skparam__matrix1 = __skadapter__to_sklib_matrix_2d(matrix1)
    __skparam__bmp2 = __skadapter__to_sklib_bitmap(bmp2)
    __skparam__cell2 = __skadapter__to_sklib_int(cell2)
    __skparam__matrix2 = __skadapter__to_sklib_matrix_2d(matrix2)
    __skreturn = sklib.__sklib__bitmap_collision__bitmap__int__matrix_2d_ref__bitmap__int__matrix_2d_ref(__skparam__bmp1, __skparam__cell1, __skparam__matrix1, __skparam__bmp2, __skparam__cell2, __skparam__matrix2)
    return __skadapter__to_bool(__skreturn)
def bitmap_collision_for_cells_at_points ( bmp1, cell1, pt1, bmp2, cell2, pt2 ):
    __skparam__bmp1 = __skadapter__to_sklib_bitmap(bmp1)
    __skparam__cell1 = __skadapter__to_sklib_int(cell1)
    __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1)
    __skparam__bmp2 = __skadapter__to_sklib_bitmap(bmp2)
    __skparam__cell2 = __skadapter__to_sklib_int(cell2)
    __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2)
    __skreturn = sklib.__sklib__bitmap_collision__bitmap__int__point_2d_ref__bitmap__int__point_2d_ref(__skparam__bmp1, __skparam__cell1, __skparam__pt1, __skparam__bmp2, __skparam__cell2, __skparam__pt2)
    return __skadapter__to_bool(__skreturn)
def bitmap_collision_for_cells ( bmp1, cell1, x1, y1, bmp2, cell2, x2, y2 ):
    __skparam__bmp1 = __skadapter__to_sklib_bitmap(bmp1)
    __skparam__cell1 = __skadapter__to_sklib_int(cell1)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__bmp2 = __skadapter__to_sklib_bitmap(bmp2)
    __skparam__cell2 = __skadapter__to_sklib_int(cell2)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skreturn = sklib.__sklib__bitmap_collision__bitmap__int__double__double__bitmap__int__double__double(__skparam__bmp1, __skparam__cell1, __skparam__x1, __skparam__y1, __skparam__bmp2, __skparam__cell2, __skparam__x2, __skparam__y2)
    return __skadapter__to_bool(__skreturn)
def bitmap_point_collision_with_translation ( bmp, translation, pt ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__translation = __skadapter__to_sklib_matrix_2d(translation)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__bitmap_point_collision__bitmap__matrix_2d_ref__point_2d_ref(__skparam__bmp, __skparam__translation, __skparam__pt)
    return __skadapter__to_bool(__skreturn)
def bitmap_point_collision_at_point ( bmp, bmp_pt, pt ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__bmp_pt = __skadapter__to_sklib_point_2d(bmp_pt)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__bitmap_point_collision__bitmap__point_2d_ref__point_2d_ref(__skparam__bmp, __skparam__bmp_pt, __skparam__pt)
    return __skadapter__to_bool(__skreturn)
def bitmap_point_collision ( bmp, bmp_x, bmp_y, x, y ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__bmp_x = __skadapter__to_sklib_double(bmp_x)
    __skparam__bmp_y = __skadapter__to_sklib_double(bmp_y)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__bitmap_point_collision__bitmap__double__double__double__double(__skparam__bmp, __skparam__bmp_x, __skparam__bmp_y, __skparam__x, __skparam__y)
    return __skadapter__to_bool(__skreturn)
def bitmap_point_collision_for_cell_with_translation ( bmp, cell, translation, pt ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__translation = __skadapter__to_sklib_matrix_2d(translation)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__bitmap_point_collision__bitmap__int__matrix_2d_ref__point_2d_ref(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__pt)
    return __skadapter__to_bool(__skreturn)
def bitmap_point_collision_for_cell_at_point ( bmp, cell, bmp_pt, pt ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__bmp_pt = __skadapter__to_sklib_point_2d(bmp_pt)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__bitmap_point_collision__bitmap__int__point_2d_ref__point_2d_ref(__skparam__bmp, __skparam__cell, __skparam__bmp_pt, __skparam__pt)
    return __skadapter__to_bool(__skreturn)
def bitmap_point_collision_for_cell ( bmp, cell, bmp_x, bmp_y, x, y ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__bmp_x = __skadapter__to_sklib_double(bmp_x)
    __skparam__bmp_y = __skadapter__to_sklib_double(bmp_y)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__bitmap_point_collision__bitmap__int__double__double__double__double(__skparam__bmp, __skparam__cell, __skparam__bmp_x, __skparam__bmp_y, __skparam__x, __skparam__y)
    return __skadapter__to_bool(__skreturn)
def bitmap_rectangle_collision_at_point ( bmp, pt, rect ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__bitmap_rectangle_collision__bitmap__point_2d_ref__rectangle_ref(__skparam__bmp, __skparam__pt, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def bitmap_rectangle_collision ( bmp, x, y, rect ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__bitmap_rectangle_collision__bitmap__double__double__rectangle_ref(__skparam__bmp, __skparam__x, __skparam__y, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def bitmap_rectangle_collision_for_cell_with_translation ( bmp, cell, translation, rect ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__translation = __skadapter__to_sklib_matrix_2d(translation)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__bitmap_rectangle_collision__bitmap__int__matrix_2d_ref__rectangle_ref(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def bitmap_rectangle_collision_for_cell_at_point ( bmp, cell, pt, rect ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__bitmap_rectangle_collision__bitmap__int__point_2d_ref__rectangle_ref(__skparam__bmp, __skparam__cell, __skparam__pt, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def bitmap_rectangle_collision_for_cell ( bmp, cell, x, y, rect ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__bitmap_rectangle_collision__bitmap__int__double__double__rectangle_ref(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def sprite_bitmap_collision ( s, bmp, x, y ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__sprite_bitmap_collision__sprite__bitmap__double__double(__skparam__s, __skparam__bmp, __skparam__x, __skparam__y)
    return __skadapter__to_bool(__skreturn)
def sprite_bitmap_collision_with_cell_at_point ( s, bmp, cell, pt ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__sprite_bitmap_collision__sprite__bitmap__int__point_2d_ref(__skparam__s, __skparam__bmp, __skparam__cell, __skparam__pt)
    return __skadapter__to_bool(__skreturn)
def sprite_bitmap_collision_with_cell ( s, bmp, cell, x, y ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__sprite_bitmap_collision__sprite__bitmap__int__double__double(__skparam__s, __skparam__bmp, __skparam__cell, __skparam__x, __skparam__y)
    return __skadapter__to_bool(__skreturn)
def sprite_collision ( s1, s2 ):
    __skparam__s1 = __skadapter__to_sklib_sprite(s1)
    __skparam__s2 = __skadapter__to_sklib_sprite(s2)
    __skreturn = sklib.__sklib__sprite_collision__sprite__sprite(__skparam__s1, __skparam__s2)
    return __skadapter__to_bool(__skreturn)
def sprite_point_collision ( s, pt ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__sprite_point_collision__sprite__point_2d_ref(__skparam__s, __skparam__pt)
    return __skadapter__to_bool(__skreturn)
def sprite_rectangle_collision ( s, rect ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__sprite_rectangle_collision__sprite__rectangle_ref(__skparam__s, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def alpha_of ( c ):
    __skparam__c = __skadapter__to_sklib_color(c)
    __skreturn = sklib.__sklib__alpha_of__color(__skparam__c)
    return __skadapter__to_int(__skreturn)
def blue_of ( c ):
    __skparam__c = __skadapter__to_sklib_color(c)
    __skreturn = sklib.__sklib__blue_of__color(__skparam__c)
    return __skadapter__to_int(__skreturn)
def brightness_of ( c ):
    __skparam__c = __skadapter__to_sklib_color(c)
    __skreturn = sklib.__sklib__brightness_of__color(__skparam__c)
    return __skadapter__to_double(__skreturn)
def color_alice_blue (  ):
    __skreturn = sklib.__sklib__color_alice_blue()
    return __skadapter__to_color(__skreturn)
def color_antique_white (  ):
    __skreturn = sklib.__sklib__color_antique_white()
    return __skadapter__to_color(__skreturn)
def color_aqua (  ):
    __skreturn = sklib.__sklib__color_aqua()
    return __skadapter__to_color(__skreturn)
def color_aquamarine (  ):
    __skreturn = sklib.__sklib__color_aquamarine()
    return __skadapter__to_color(__skreturn)
def color_azure (  ):
    __skreturn = sklib.__sklib__color_azure()
    return __skadapter__to_color(__skreturn)
def color_beige (  ):
    __skreturn = sklib.__sklib__color_beige()
    return __skadapter__to_color(__skreturn)
def color_bisque (  ):
    __skreturn = sklib.__sklib__color_bisque()
    return __skadapter__to_color(__skreturn)
def color_black (  ):
    __skreturn = sklib.__sklib__color_black()
    return __skadapter__to_color(__skreturn)
def color_blanched_almond (  ):
    __skreturn = sklib.__sklib__color_blanched_almond()
    return __skadapter__to_color(__skreturn)
def color_blue (  ):
    __skreturn = sklib.__sklib__color_blue()
    return __skadapter__to_color(__skreturn)
def color_blue_violet (  ):
    __skreturn = sklib.__sklib__color_blue_violet()
    return __skadapter__to_color(__skreturn)
def color_bright_green (  ):
    __skreturn = sklib.__sklib__color_bright_green()
    return __skadapter__to_color(__skreturn)
def color_brown (  ):
    __skreturn = sklib.__sklib__color_brown()
    return __skadapter__to_color(__skreturn)
def color_burly_wood (  ):
    __skreturn = sklib.__sklib__color_burly_wood()
    return __skadapter__to_color(__skreturn)
def color_cadet_blue (  ):
    __skreturn = sklib.__sklib__color_cadet_blue()
    return __skadapter__to_color(__skreturn)
def color_chartreuse (  ):
    __skreturn = sklib.__sklib__color_chartreuse()
    return __skadapter__to_color(__skreturn)
def color_chocolate (  ):
    __skreturn = sklib.__sklib__color_chocolate()
    return __skadapter__to_color(__skreturn)
def color_coral (  ):
    __skreturn = sklib.__sklib__color_coral()
    return __skadapter__to_color(__skreturn)
def color_cornflower_blue (  ):
    __skreturn = sklib.__sklib__color_cornflower_blue()
    return __skadapter__to_color(__skreturn)
def color_cornsilk (  ):
    __skreturn = sklib.__sklib__color_cornsilk()
    return __skadapter__to_color(__skreturn)
def color_crimson (  ):
    __skreturn = sklib.__sklib__color_crimson()
    return __skadapter__to_color(__skreturn)
def color_cyan (  ):
    __skreturn = sklib.__sklib__color_cyan()
    return __skadapter__to_color(__skreturn)
def color_dark_blue (  ):
    __skreturn = sklib.__sklib__color_dark_blue()
    return __skadapter__to_color(__skreturn)
def color_dark_cyan (  ):
    __skreturn = sklib.__sklib__color_dark_cyan()
    return __skadapter__to_color(__skreturn)
def color_dark_goldenrod (  ):
    __skreturn = sklib.__sklib__color_dark_goldenrod()
    return __skadapter__to_color(__skreturn)
def color_dark_gray (  ):
    __skreturn = sklib.__sklib__color_dark_gray()
    return __skadapter__to_color(__skreturn)
def color_dark_green (  ):
    __skreturn = sklib.__sklib__color_dark_green()
    return __skadapter__to_color(__skreturn)
def color_dark_khaki (  ):
    __skreturn = sklib.__sklib__color_dark_khaki()
    return __skadapter__to_color(__skreturn)
def color_dark_magenta (  ):
    __skreturn = sklib.__sklib__color_dark_magenta()
    return __skadapter__to_color(__skreturn)
def color_dark_olive_green (  ):
    __skreturn = sklib.__sklib__color_dark_olive_green()
    return __skadapter__to_color(__skreturn)
def color_dark_orange (  ):
    __skreturn = sklib.__sklib__color_dark_orange()
    return __skadapter__to_color(__skreturn)
def color_dark_orchid (  ):
    __skreturn = sklib.__sklib__color_dark_orchid()
    return __skadapter__to_color(__skreturn)
def color_dark_red (  ):
    __skreturn = sklib.__sklib__color_dark_red()
    return __skadapter__to_color(__skreturn)
def color_dark_salmon (  ):
    __skreturn = sklib.__sklib__color_dark_salmon()
    return __skadapter__to_color(__skreturn)
def color_dark_sea_green (  ):
    __skreturn = sklib.__sklib__color_dark_sea_green()
    return __skadapter__to_color(__skreturn)
def color_dark_slate_blue (  ):
    __skreturn = sklib.__sklib__color_dark_slate_blue()
    return __skadapter__to_color(__skreturn)
def color_dark_slate_gray (  ):
    __skreturn = sklib.__sklib__color_dark_slate_gray()
    return __skadapter__to_color(__skreturn)
def color_dark_turquoise (  ):
    __skreturn = sklib.__sklib__color_dark_turquoise()
    return __skadapter__to_color(__skreturn)
def color_dark_violet (  ):
    __skreturn = sklib.__sklib__color_dark_violet()
    return __skadapter__to_color(__skreturn)
def color_deep_pink (  ):
    __skreturn = sklib.__sklib__color_deep_pink()
    return __skadapter__to_color(__skreturn)
def color_deep_sky_blue (  ):
    __skreturn = sklib.__sklib__color_deep_sky_blue()
    return __skadapter__to_color(__skreturn)
def color_dim_gray (  ):
    __skreturn = sklib.__sklib__color_dim_gray()
    return __skadapter__to_color(__skreturn)
def color_dodger_blue (  ):
    __skreturn = sklib.__sklib__color_dodger_blue()
    return __skadapter__to_color(__skreturn)
def color_firebrick (  ):
    __skreturn = sklib.__sklib__color_firebrick()
    return __skadapter__to_color(__skreturn)
def color_floral_white (  ):
    __skreturn = sklib.__sklib__color_floral_white()
    return __skadapter__to_color(__skreturn)
def color_forest_green (  ):
    __skreturn = sklib.__sklib__color_forest_green()
    return __skadapter__to_color(__skreturn)
def color_fuchsia (  ):
    __skreturn = sklib.__sklib__color_fuchsia()
    return __skadapter__to_color(__skreturn)
def color_gainsboro (  ):
    __skreturn = sklib.__sklib__color_gainsboro()
    return __skadapter__to_color(__skreturn)
def color_ghost_white (  ):
    __skreturn = sklib.__sklib__color_ghost_white()
    return __skadapter__to_color(__skreturn)
def color_gold (  ):
    __skreturn = sklib.__sklib__color_gold()
    return __skadapter__to_color(__skreturn)
def color_goldenrod (  ):
    __skreturn = sklib.__sklib__color_goldenrod()
    return __skadapter__to_color(__skreturn)
def color_gray (  ):
    __skreturn = sklib.__sklib__color_gray()
    return __skadapter__to_color(__skreturn)
def color_green (  ):
    __skreturn = sklib.__sklib__color_green()
    return __skadapter__to_color(__skreturn)
def color_green_yellow (  ):
    __skreturn = sklib.__sklib__color_green_yellow()
    return __skadapter__to_color(__skreturn)
def color_honeydew (  ):
    __skreturn = sklib.__sklib__color_honeydew()
    return __skadapter__to_color(__skreturn)
def color_hot_pink (  ):
    __skreturn = sklib.__sklib__color_hot_pink()
    return __skadapter__to_color(__skreturn)
def color_indian_red (  ):
    __skreturn = sklib.__sklib__color_indian_red()
    return __skadapter__to_color(__skreturn)
def color_indigo (  ):
    __skreturn = sklib.__sklib__color_indigo()
    return __skadapter__to_color(__skreturn)
def color_ivory (  ):
    __skreturn = sklib.__sklib__color_ivory()
    return __skadapter__to_color(__skreturn)
def color_khaki (  ):
    __skreturn = sklib.__sklib__color_khaki()
    return __skadapter__to_color(__skreturn)
def color_lavender (  ):
    __skreturn = sklib.__sklib__color_lavender()
    return __skadapter__to_color(__skreturn)
def color_lavender_blush (  ):
    __skreturn = sklib.__sklib__color_lavender_blush()
    return __skadapter__to_color(__skreturn)
def color_lawn_green (  ):
    __skreturn = sklib.__sklib__color_lawn_green()
    return __skadapter__to_color(__skreturn)
def color_lemon_chiffon (  ):
    __skreturn = sklib.__sklib__color_lemon_chiffon()
    return __skadapter__to_color(__skreturn)
def color_light_blue (  ):
    __skreturn = sklib.__sklib__color_light_blue()
    return __skadapter__to_color(__skreturn)
def color_light_coral (  ):
    __skreturn = sklib.__sklib__color_light_coral()
    return __skadapter__to_color(__skreturn)
def color_light_cyan (  ):
    __skreturn = sklib.__sklib__color_light_cyan()
    return __skadapter__to_color(__skreturn)
def color_light_goldenrod_yellow (  ):
    __skreturn = sklib.__sklib__color_light_goldenrod_yellow()
    return __skadapter__to_color(__skreturn)
def color_light_gray (  ):
    __skreturn = sklib.__sklib__color_light_gray()
    return __skadapter__to_color(__skreturn)
def color_light_green (  ):
    __skreturn = sklib.__sklib__color_light_green()
    return __skadapter__to_color(__skreturn)
def color_light_pink (  ):
    __skreturn = sklib.__sklib__color_light_pink()
    return __skadapter__to_color(__skreturn)
def color_light_salmon (  ):
    __skreturn = sklib.__sklib__color_light_salmon()
    return __skadapter__to_color(__skreturn)
def color_light_sea_green (  ):
    __skreturn = sklib.__sklib__color_light_sea_green()
    return __skadapter__to_color(__skreturn)
def color_light_sky_blue (  ):
    __skreturn = sklib.__sklib__color_light_sky_blue()
    return __skadapter__to_color(__skreturn)
def color_light_slate_gray (  ):
    __skreturn = sklib.__sklib__color_light_slate_gray()
    return __skadapter__to_color(__skreturn)
def color_light_steel_blue (  ):
    __skreturn = sklib.__sklib__color_light_steel_blue()
    return __skadapter__to_color(__skreturn)
def color_light_yellow (  ):
    __skreturn = sklib.__sklib__color_light_yellow()
    return __skadapter__to_color(__skreturn)
def color_lime (  ):
    __skreturn = sklib.__sklib__color_lime()
    return __skadapter__to_color(__skreturn)
def color_lime_green (  ):
    __skreturn = sklib.__sklib__color_lime_green()
    return __skadapter__to_color(__skreturn)
def color_linen (  ):
    __skreturn = sklib.__sklib__color_linen()
    return __skadapter__to_color(__skreturn)
def color_magenta (  ):
    __skreturn = sklib.__sklib__color_magenta()
    return __skadapter__to_color(__skreturn)
def color_maroon (  ):
    __skreturn = sklib.__sklib__color_maroon()
    return __skadapter__to_color(__skreturn)
def color_medium_aquamarine (  ):
    __skreturn = sklib.__sklib__color_medium_aquamarine()
    return __skadapter__to_color(__skreturn)
def color_medium_blue (  ):
    __skreturn = sklib.__sklib__color_medium_blue()
    return __skadapter__to_color(__skreturn)
def color_medium_orchid (  ):
    __skreturn = sklib.__sklib__color_medium_orchid()
    return __skadapter__to_color(__skreturn)
def color_medium_purple (  ):
    __skreturn = sklib.__sklib__color_medium_purple()
    return __skadapter__to_color(__skreturn)
def color_medium_sea_green (  ):
    __skreturn = sklib.__sklib__color_medium_sea_green()
    return __skadapter__to_color(__skreturn)
def color_medium_slate_blue (  ):
    __skreturn = sklib.__sklib__color_medium_slate_blue()
    return __skadapter__to_color(__skreturn)
def color_medium_spring_green (  ):
    __skreturn = sklib.__sklib__color_medium_spring_green()
    return __skadapter__to_color(__skreturn)
def color_medium_turquoise (  ):
    __skreturn = sklib.__sklib__color_medium_turquoise()
    return __skadapter__to_color(__skreturn)
def color_medium_violet_red (  ):
    __skreturn = sklib.__sklib__color_medium_violet_red()
    return __skadapter__to_color(__skreturn)
def color_midnight_blue (  ):
    __skreturn = sklib.__sklib__color_midnight_blue()
    return __skadapter__to_color(__skreturn)
def color_mint_cream (  ):
    __skreturn = sklib.__sklib__color_mint_cream()
    return __skadapter__to_color(__skreturn)
def color_misty_rose (  ):
    __skreturn = sklib.__sklib__color_misty_rose()
    return __skadapter__to_color(__skreturn)
def color_moccasin (  ):
    __skreturn = sklib.__sklib__color_moccasin()
    return __skadapter__to_color(__skreturn)
def color_navajo_white (  ):
    __skreturn = sklib.__sklib__color_navajo_white()
    return __skadapter__to_color(__skreturn)
def color_navy (  ):
    __skreturn = sklib.__sklib__color_navy()
    return __skadapter__to_color(__skreturn)
def color_old_lace (  ):
    __skreturn = sklib.__sklib__color_old_lace()
    return __skadapter__to_color(__skreturn)
def color_olive (  ):
    __skreturn = sklib.__sklib__color_olive()
    return __skadapter__to_color(__skreturn)
def color_olive_drab (  ):
    __skreturn = sklib.__sklib__color_olive_drab()
    return __skadapter__to_color(__skreturn)
def color_orange (  ):
    __skreturn = sklib.__sklib__color_orange()
    return __skadapter__to_color(__skreturn)
def color_orange_red (  ):
    __skreturn = sklib.__sklib__color_orange_red()
    return __skadapter__to_color(__skreturn)
def color_orchid (  ):
    __skreturn = sklib.__sklib__color_orchid()
    return __skadapter__to_color(__skreturn)
def color_pale_goldenrod (  ):
    __skreturn = sklib.__sklib__color_pale_goldenrod()
    return __skadapter__to_color(__skreturn)
def color_pale_green (  ):
    __skreturn = sklib.__sklib__color_pale_green()
    return __skadapter__to_color(__skreturn)
def color_pale_turquoise (  ):
    __skreturn = sklib.__sklib__color_pale_turquoise()
    return __skadapter__to_color(__skreturn)
def color_pale_violet_red (  ):
    __skreturn = sklib.__sklib__color_pale_violet_red()
    return __skadapter__to_color(__skreturn)
def color_papaya_whip (  ):
    __skreturn = sklib.__sklib__color_papaya_whip()
    return __skadapter__to_color(__skreturn)
def color_peach_puff (  ):
    __skreturn = sklib.__sklib__color_peach_puff()
    return __skadapter__to_color(__skreturn)
def color_peru (  ):
    __skreturn = sklib.__sklib__color_peru()
    return __skadapter__to_color(__skreturn)
def color_pink (  ):
    __skreturn = sklib.__sklib__color_pink()
    return __skadapter__to_color(__skreturn)
def color_plum (  ):
    __skreturn = sklib.__sklib__color_plum()
    return __skadapter__to_color(__skreturn)
def color_powder_blue (  ):
    __skreturn = sklib.__sklib__color_powder_blue()
    return __skadapter__to_color(__skreturn)
def color_purple (  ):
    __skreturn = sklib.__sklib__color_purple()
    return __skadapter__to_color(__skreturn)
def color_red (  ):
    __skreturn = sklib.__sklib__color_red()
    return __skadapter__to_color(__skreturn)
def color_rosy_brown (  ):
    __skreturn = sklib.__sklib__color_rosy_brown()
    return __skadapter__to_color(__skreturn)
def color_royal_blue (  ):
    __skreturn = sklib.__sklib__color_royal_blue()
    return __skadapter__to_color(__skreturn)
def color_saddle_brown (  ):
    __skreturn = sklib.__sklib__color_saddle_brown()
    return __skadapter__to_color(__skreturn)
def color_salmon (  ):
    __skreturn = sklib.__sklib__color_salmon()
    return __skadapter__to_color(__skreturn)
def color_sandy_brown (  ):
    __skreturn = sklib.__sklib__color_sandy_brown()
    return __skadapter__to_color(__skreturn)
def color_sea_green (  ):
    __skreturn = sklib.__sklib__color_sea_green()
    return __skadapter__to_color(__skreturn)
def color_sea_shell (  ):
    __skreturn = sklib.__sklib__color_sea_shell()
    return __skadapter__to_color(__skreturn)
def color_sienna (  ):
    __skreturn = sklib.__sklib__color_sienna()
    return __skadapter__to_color(__skreturn)
def color_silver (  ):
    __skreturn = sklib.__sklib__color_silver()
    return __skadapter__to_color(__skreturn)
def color_sky_blue (  ):
    __skreturn = sklib.__sklib__color_sky_blue()
    return __skadapter__to_color(__skreturn)
def color_slate_blue (  ):
    __skreturn = sklib.__sklib__color_slate_blue()
    return __skadapter__to_color(__skreturn)
def color_slate_gray (  ):
    __skreturn = sklib.__sklib__color_slate_gray()
    return __skadapter__to_color(__skreturn)
def color_snow (  ):
    __skreturn = sklib.__sklib__color_snow()
    return __skadapter__to_color(__skreturn)
def color_spring_green (  ):
    __skreturn = sklib.__sklib__color_spring_green()
    return __skadapter__to_color(__skreturn)
def color_steel_blue (  ):
    __skreturn = sklib.__sklib__color_steel_blue()
    return __skadapter__to_color(__skreturn)
def color_swinburne_red (  ):
    __skreturn = sklib.__sklib__color_swinburne_red()
    return __skadapter__to_color(__skreturn)
def color_tan (  ):
    __skreturn = sklib.__sklib__color_tan()
    return __skadapter__to_color(__skreturn)
def color_teal (  ):
    __skreturn = sklib.__sklib__color_teal()
    return __skadapter__to_color(__skreturn)
def color_thistle (  ):
    __skreturn = sklib.__sklib__color_thistle()
    return __skadapter__to_color(__skreturn)
def color_to_string ( c ):
    __skparam__c = __skadapter__to_sklib_color(c)
    __skreturn = sklib.__sklib__color_to_string__color(__skparam__c)
    return __skadapter__to_string(__skreturn)
def color_tomato (  ):
    __skreturn = sklib.__sklib__color_tomato()
    return __skadapter__to_color(__skreturn)
def color_transparent (  ):
    __skreturn = sklib.__sklib__color_transparent()
    return __skadapter__to_color(__skreturn)
def color_turquoise (  ):
    __skreturn = sklib.__sklib__color_turquoise()
    return __skadapter__to_color(__skreturn)
def color_violet (  ):
    __skreturn = sklib.__sklib__color_violet()
    return __skadapter__to_color(__skreturn)
def color_wheat (  ):
    __skreturn = sklib.__sklib__color_wheat()
    return __skadapter__to_color(__skreturn)
def color_white (  ):
    __skreturn = sklib.__sklib__color_white()
    return __skadapter__to_color(__skreturn)
def color_white_smoke (  ):
    __skreturn = sklib.__sklib__color_white_smoke()
    return __skadapter__to_color(__skreturn)
def color_yellow (  ):
    __skreturn = sklib.__sklib__color_yellow()
    return __skadapter__to_color(__skreturn)
def color_yellow_green (  ):
    __skreturn = sklib.__sklib__color_yellow_green()
    return __skadapter__to_color(__skreturn)
def green_of ( c ):
    __skparam__c = __skadapter__to_sklib_color(c)
    __skreturn = sklib.__sklib__green_of__color(__skparam__c)
    return __skadapter__to_int(__skreturn)
def hsb_color ( hue, saturation, brightness ):
    __skparam__hue = __skadapter__to_sklib_double(hue)
    __skparam__saturation = __skadapter__to_sklib_double(saturation)
    __skparam__brightness = __skadapter__to_sklib_double(brightness)
    __skreturn = sklib.__sklib__hsb_color__double__double__double(__skparam__hue, __skparam__saturation, __skparam__brightness)
    return __skadapter__to_color(__skreturn)
def hue_of ( c ):
    __skparam__c = __skadapter__to_sklib_color(c)
    __skreturn = sklib.__sklib__hue_of__color(__skparam__c)
    return __skadapter__to_double(__skreturn)
def random_color (  ):
    __skreturn = sklib.__sklib__random_color()
    return __skadapter__to_color(__skreturn)
def random_rgb_color ( alpha ):
    __skparam__alpha = __skadapter__to_sklib_int(alpha)
    __skreturn = sklib.__sklib__random_rgb_color__int(__skparam__alpha)
    return __skadapter__to_color(__skreturn)
def red_of ( c ):
    __skparam__c = __skadapter__to_sklib_color(c)
    __skreturn = sklib.__sklib__red_of__color(__skparam__c)
    return __skadapter__to_int(__skreturn)
def rgb_color_from_double ( red, green, blue ):
    __skparam__red = __skadapter__to_sklib_double(red)
    __skparam__green = __skadapter__to_sklib_double(green)
    __skparam__blue = __skadapter__to_sklib_double(blue)
    __skreturn = sklib.__sklib__rgb_color__double__double__double(__skparam__red, __skparam__green, __skparam__blue)
    return __skadapter__to_color(__skreturn)
def rgb_color ( red, green, blue ):
    __skparam__red = __skadapter__to_sklib_int(red)
    __skparam__green = __skadapter__to_sklib_int(green)
    __skparam__blue = __skadapter__to_sklib_int(blue)
    __skreturn = sklib.__sklib__rgb_color__int__int__int(__skparam__red, __skparam__green, __skparam__blue)
    return __skadapter__to_color(__skreturn)
def rgba_color_from_double ( red, green, blue, alpha ):
    __skparam__red = __skadapter__to_sklib_double(red)
    __skparam__green = __skadapter__to_sklib_double(green)
    __skparam__blue = __skadapter__to_sklib_double(blue)
    __skparam__alpha = __skadapter__to_sklib_double(alpha)
    __skreturn = sklib.__sklib__rgba_color__double__double__double__double(__skparam__red, __skparam__green, __skparam__blue, __skparam__alpha)
    return __skadapter__to_color(__skreturn)
def rgba_color ( red, green, blue, alpha ):
    __skparam__red = __skadapter__to_sklib_int(red)
    __skparam__green = __skadapter__to_sklib_int(green)
    __skparam__blue = __skadapter__to_sklib_int(blue)
    __skparam__alpha = __skadapter__to_sklib_int(alpha)
    __skreturn = sklib.__sklib__rgba_color__int__int__int__int(__skparam__red, __skparam__green, __skparam__blue, __skparam__alpha)
    return __skadapter__to_color(__skreturn)
def saturation_of ( c ):
    __skparam__c = __skadapter__to_sklib_color(c)
    __skreturn = sklib.__sklib__saturation_of__color(__skparam__c)
    return __skadapter__to_double(__skreturn)
def string_to_color ( str ):
    __skparam__str = __skadapter__to_sklib_string(str)
    __skreturn = sklib.__sklib__string_to_color__string(__skparam__str)
    return __skadapter__to_color(__skreturn)
def option_defaults (  ):
    __skreturn = sklib.__sklib__option_defaults()
    return __skadapter__to_drawing_options(__skreturn)
def option_draw_to_bitmap ( dest ):
    __skparam__dest = __skadapter__to_sklib_bitmap(dest)
    __skreturn = sklib.__sklib__option_draw_to__bitmap(__skparam__dest)
    return __skadapter__to_drawing_options(__skreturn)
def option_draw_to_bitmap_with_options ( dest, opts ):
    __skparam__dest = __skadapter__to_sklib_bitmap(dest)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_draw_to__bitmap__drawing_options(__skparam__dest, __skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_draw_to_window ( dest ):
    __skparam__dest = __skadapter__to_sklib_window(dest)
    __skreturn = sklib.__sklib__option_draw_to__window(__skparam__dest)
    return __skadapter__to_drawing_options(__skreturn)
def option_draw_to_window_with_options ( dest, opts ):
    __skparam__dest = __skadapter__to_sklib_window(dest)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_draw_to__window__drawing_options(__skparam__dest, __skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_flip_x (  ):
    __skreturn = sklib.__sklib__option_flip_x()
    return __skadapter__to_drawing_options(__skreturn)
def option_flip_x_with_options ( opts ):
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_flip_x__drawing_options(__skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_flip_xy (  ):
    __skreturn = sklib.__sklib__option_flip_xy()
    return __skadapter__to_drawing_options(__skreturn)
def option_flip_xy_with_options ( opts ):
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_flip_xy__drawing_options(__skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_flip_y (  ):
    __skreturn = sklib.__sklib__option_flip_y()
    return __skadapter__to_drawing_options(__skreturn)
def option_flip_y_with_options ( opts ):
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_flip_y__drawing_options(__skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_line_width ( width ):
    __skparam__width = __skadapter__to_sklib_int(width)
    __skreturn = sklib.__sklib__option_line_width__int(__skparam__width)
    return __skadapter__to_drawing_options(__skreturn)
def option_line_width_with_options ( width, opts ):
    __skparam__width = __skadapter__to_sklib_int(width)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_line_width__int__drawing_options(__skparam__width, __skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_part_bmp ( x, y, w, h ):
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__w = __skadapter__to_sklib_double(w)
    __skparam__h = __skadapter__to_sklib_double(h)
    __skreturn = sklib.__sklib__option_part_bmp__double__double__double__double(__skparam__x, __skparam__y, __skparam__w, __skparam__h)
    return __skadapter__to_drawing_options(__skreturn)
def option_part_bmp_with_options ( x, y, w, h, opts ):
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__w = __skadapter__to_sklib_double(w)
    __skparam__h = __skadapter__to_sklib_double(h)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_part_bmp__double__double__double__double__drawing_options(__skparam__x, __skparam__y, __skparam__w, __skparam__h, __skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_part_bmp_from_rectangle ( part ):
    __skparam__part = __skadapter__to_sklib_rectangle(part)
    __skreturn = sklib.__sklib__option_part_bmp__rectangle(__skparam__part)
    return __skadapter__to_drawing_options(__skreturn)
def option_part_bmp_from_rectangle_with_options ( part, opts ):
    __skparam__part = __skadapter__to_sklib_rectangle(part)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_part_bmp__rectangle__drawing_options(__skparam__part, __skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_rotate_bmp ( angle ):
    __skparam__angle = __skadapter__to_sklib_double(angle)
    __skreturn = sklib.__sklib__option_rotate_bmp__double(__skparam__angle)
    return __skadapter__to_drawing_options(__skreturn)
def option_rotate_bmp_with_anchor ( angle, anchor_x, anchor_y ):
    __skparam__angle = __skadapter__to_sklib_double(angle)
    __skparam__anchor_x = __skadapter__to_sklib_double(anchor_x)
    __skparam__anchor_y = __skadapter__to_sklib_double(anchor_y)
    __skreturn = sklib.__sklib__option_rotate_bmp__double__double__double(__skparam__angle, __skparam__anchor_x, __skparam__anchor_y)
    return __skadapter__to_drawing_options(__skreturn)
def option_rotate_bmp_with_anchor_and_options ( angle, anchor_x, anchor_y, opts ):
    __skparam__angle = __skadapter__to_sklib_double(angle)
    __skparam__anchor_x = __skadapter__to_sklib_double(anchor_x)
    __skparam__anchor_y = __skadapter__to_sklib_double(anchor_y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_rotate_bmp__double__double__double__drawing_options(__skparam__angle, __skparam__anchor_x, __skparam__anchor_y, __skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_rotate_bmp_with_options ( angle, opts ):
    __skparam__angle = __skadapter__to_sklib_double(angle)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_rotate_bmp__double__drawing_options(__skparam__angle, __skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_scale_bmp ( scale_x, scale_y ):
    __skparam__scale_x = __skadapter__to_sklib_double(scale_x)
    __skparam__scale_y = __skadapter__to_sklib_double(scale_y)
    __skreturn = sklib.__sklib__option_scale_bmp__double__double(__skparam__scale_x, __skparam__scale_y)
    return __skadapter__to_drawing_options(__skreturn)
def option_scale_bmp_with_options ( scale_x, scale_y, opts ):
    __skparam__scale_x = __skadapter__to_sklib_double(scale_x)
    __skparam__scale_y = __skadapter__to_sklib_double(scale_y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_scale_bmp__double__double__drawing_options(__skparam__scale_x, __skparam__scale_y, __skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_to_screen (  ):
    __skreturn = sklib.__sklib__option_to_screen()
    return __skadapter__to_drawing_options(__skreturn)
def option_to_screen_with_options ( opts ):
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_to_screen__drawing_options(__skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_to_world (  ):
    __skreturn = sklib.__sklib__option_to_world()
    return __skadapter__to_drawing_options(__skreturn)
def option_to_world_with_options ( opts ):
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_to_world__drawing_options(__skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_with_animation ( anim ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skreturn = sklib.__sklib__option_with_animation__animation(__skparam__anim)
    return __skadapter__to_drawing_options(__skreturn)
def option_with_animation_with_options ( anim, opts ):
    __skparam__anim = __skadapter__to_sklib_animation(anim)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_with_animation__animation__drawing_options(__skparam__anim, __skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def option_with_bitmap_cell ( cell ):
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skreturn = sklib.__sklib__option_with_bitmap_cell__int(__skparam__cell)
    return __skadapter__to_drawing_options(__skreturn)
def option_with_bitmap_cell_with_options ( cell, opts ):
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__option_with_bitmap_cell__int__drawing_options(__skparam__cell, __skparam__opts)
    return __skadapter__to_drawing_options(__skreturn)
def draw_ellipse_within_rectangle ( clr, rect ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__draw_ellipse__color__rectangle(__skparam__clr, __skparam__rect)
def draw_ellipse_within_rectangle_with_options ( clr, rect, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_ellipse__color__rectangle__drawing_options(__skparam__clr, __skparam__rect, __skparam__opts)
def draw_ellipse ( clr, x, y, width, height ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__draw_ellipse__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def draw_ellipse_with_options ( clr, x, y, width, height, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_ellipse__color__double__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def draw_ellipse_on_bitmap_within_rectangle ( destination, clr, rect ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect)
def draw_ellipse_on_bitmap_within_rectangle_with_options ( destination, clr, rect, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts)
def draw_ellipse_on_bitmap ( destination, clr, x, y, width, height ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def draw_ellipse_on_bitmap_with_options ( destination, clr, x, y, width, height, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def draw_ellipse_on_window_within_rectangle ( destination, clr, rect ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__draw_ellipse_on_window__window__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect)
def draw_ellipse_on_window_within_rectangle_with_options ( destination, clr, rect, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_ellipse_on_window__window__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts)
def draw_ellipse_on_window ( destination, clr, x, y, width, height ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__draw_ellipse_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def draw_ellipse_on_window_with_options ( destination, clr, x, y, width, height, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_ellipse_on_window__window__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def fill_ellipse_within_rectangle ( clr, rect ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__fill_ellipse__color__rectangle(__skparam__clr, __skparam__rect)
def fill_ellipse_within_rectangle_with_options ( clr, rect, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_ellipse__color__rectangle__drawing_options(__skparam__clr, __skparam__rect, __skparam__opts)
def fill_ellipse ( clr, x, y, width, height ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__fill_ellipse__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def fill_ellipse_with_options ( clr, x, y, width, height, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_ellipse__color__double__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def fill_ellipse_on_bitmap_within_rectangle ( destination, clr, rect ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect)
def fill_ellipse_on_bitmap_within_rectangle_with_options ( destination, clr, rect, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts)
def fill_ellipse_on_bitmap ( destination, clr, x, y, width, height ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def fill_ellipse_on_bitmap_with_options ( destination, clr, x, y, width, height, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def fill_ellipse_on_window_within_rectangle ( destination, clr, rect ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__fill_ellipse_on_window__window__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect)
def fill_ellipse_on_window_within_rectangle_with_options ( destination, clr, rect, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_ellipse_on_window__window__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts)
def fill_ellipse_on_window ( destination, clr, x, y, width, height ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__fill_ellipse_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def fill_ellipse_on_window_with_options ( destination, clr, x, y, width, height, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_ellipse_on_window__window__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def cosine ( degrees ):
    __skparam__degrees = __skadapter__to_sklib_float(degrees)
    __skreturn = sklib.__sklib__cosine__float(__skparam__degrees)
    return __skadapter__to_float(__skreturn)
def sine ( degrees ):
    __skparam__degrees = __skadapter__to_sklib_float(degrees)
    __skreturn = sklib.__sklib__sine__float(__skparam__degrees)
    return __skadapter__to_float(__skreturn)
def tangent ( degrees ):
    __skparam__degrees = __skadapter__to_sklib_float(degrees)
    __skreturn = sklib.__sklib__tangent__float(__skparam__degrees)
    return __skadapter__to_float(__skreturn)
def clear_screen_to_white (  ):
    sklib.__sklib__clear_screen()
def clear_screen ( clr ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    sklib.__sklib__clear_screen__color(__skparam__clr)
def display_details ( index ):
    __skparam__index = __skadapter__to_sklib_unsigned_int(index)
    __skreturn = sklib.__sklib__display_details__unsigned_int(__skparam__index)
    return __skadapter__to_display(__skreturn)
def display_height ( disp ):
    __skparam__disp = __skadapter__to_sklib_display(disp)
    __skreturn = sklib.__sklib__display_height__display(__skparam__disp)
    return __skadapter__to_int(__skreturn)
def display_name ( disp ):
    __skparam__disp = __skadapter__to_sklib_display(disp)
    __skreturn = sklib.__sklib__display_name__display(__skparam__disp)
    return __skadapter__to_string(__skreturn)
def display_width ( disp ):
    __skparam__disp = __skadapter__to_sklib_display(disp)
    __skreturn = sklib.__sklib__display_width__display(__skparam__disp)
    return __skadapter__to_int(__skreturn)
def display_x ( disp ):
    __skparam__disp = __skadapter__to_sklib_display(disp)
    __skreturn = sklib.__sklib__display_x__display(__skparam__disp)
    return __skadapter__to_int(__skreturn)
def display_y ( disp ):
    __skparam__disp = __skadapter__to_sklib_display(disp)
    __skreturn = sklib.__sklib__display_y__display(__skparam__disp)
    return __skadapter__to_int(__skreturn)
def number_of_displays (  ):
    __skreturn = sklib.__sklib__number_of_displays()
    return __skadapter__to_int(__skreturn)
def refresh_screen (  ):
    sklib.__sklib__refresh_screen()
def refresh_screen_with_target_fps ( target_fps ):
    __skparam__target_fps = __skadapter__to_sklib_unsigned_int(target_fps)
    sklib.__sklib__refresh_screen__unsigned_int(__skparam__target_fps)
def save_bitmap ( bmp, basename ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__basename = __skadapter__to_sklib_string(basename)
    sklib.__sklib__save_bitmap__bitmap__string_ref(__skparam__bmp, __skparam__basename)
def screen_height (  ):
    __skreturn = sklib.__sklib__screen_height()
    return __skadapter__to_int(__skreturn)
def screen_width (  ):
    __skreturn = sklib.__sklib__screen_width()
    return __skadapter__to_int(__skreturn)
def take_screenshot ( basename ):
    __skparam__basename = __skadapter__to_sklib_string(basename)
    sklib.__sklib__take_screenshot__string_ref(__skparam__basename)
def take_screenshot_of_window ( wind, basename ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skparam__basename = __skadapter__to_sklib_string(basename)
    sklib.__sklib__take_screenshot__window__string_ref(__skparam__wind, __skparam__basename)
def bitmap_bounding_circle ( bmp, pt ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__bitmap_bounding_circle__bitmap__point_2d_ref(__skparam__bmp, __skparam__pt)
    return __skadapter__to_circle(__skreturn)
def bitmap_bounding_rectangle ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_bounding_rectangle__bitmap(__skparam__bmp)
    return __skadapter__to_rectangle(__skreturn)
def bitmap_bounding_rectangle_at_location ( bmp, x, y ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__bitmap_bounding_rectangle__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y)
    return __skadapter__to_rectangle(__skreturn)
def bitmap_cell_center ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_cell_center__bitmap(__skparam__bmp)
    return __skadapter__to_point_2d(__skreturn)
def bitmap_cell_circle ( bmp, x, y ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__bitmap_cell_circle__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y)
    return __skadapter__to_circle(__skreturn)
def bitmap_cell_circle_at_point ( bmp, pt ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__bitmap_cell_circle__bitmap__point_2d(__skparam__bmp, __skparam__pt)
    return __skadapter__to_circle(__skreturn)
def bitmap_cell_circle_at_point_with_scale ( bmp, pt, scale ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__scale = __skadapter__to_sklib_double(scale)
    __skreturn = sklib.__sklib__bitmap_cell_circle__bitmap__point_2d__double(__skparam__bmp, __skparam__pt, __skparam__scale)
    return __skadapter__to_circle(__skreturn)
def bitmap_cell_columns ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_cell_columns__bitmap(__skparam__bmp)
    return __skadapter__to_int(__skreturn)
def bitmap_cell_count ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_cell_count__bitmap(__skparam__bmp)
    return __skadapter__to_int(__skreturn)
def bitmap_cell_height ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_cell_height__bitmap(__skparam__bmp)
    return __skadapter__to_int(__skreturn)
def bitmap_cell_offset ( src, cell ):
    __skparam__src = __skadapter__to_sklib_bitmap(src)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skreturn = sklib.__sklib__bitmap_cell_offset__bitmap__int(__skparam__src, __skparam__cell)
    return __skadapter__to_vector_2d(__skreturn)
def bitmap_cell_rectangle ( src ):
    __skparam__src = __skadapter__to_sklib_bitmap(src)
    __skreturn = sklib.__sklib__bitmap_cell_rectangle__bitmap(__skparam__src)
    return __skadapter__to_rectangle(__skreturn)
def bitmap_cell_rectangle_at_point ( src, pt ):
    __skparam__src = __skadapter__to_sklib_bitmap(src)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__bitmap_cell_rectangle__bitmap__point_2d_ref(__skparam__src, __skparam__pt)
    return __skadapter__to_rectangle(__skreturn)
def bitmap_cell_rows ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_cell_rows__bitmap(__skparam__bmp)
    return __skadapter__to_int(__skreturn)
def bitmap_cell_width ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_cell_width__bitmap(__skparam__bmp)
    return __skadapter__to_int(__skreturn)
def bitmap_center ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_center__bitmap(__skparam__bmp)
    return __skadapter__to_point_2d(__skreturn)
def bitmap_filename ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_filename__bitmap(__skparam__bmp)
    return __skadapter__to_string(__skreturn)
def bitmap_height ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_height__bitmap(__skparam__bmp)
    return __skadapter__to_int(__skreturn)
def bitmap_height_of_bitmap_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__bitmap_height__string(__skparam__name)
    return __skadapter__to_int(__skreturn)
def bitmap_name ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_name__bitmap(__skparam__bmp)
    return __skadapter__to_string(__skreturn)
def bitmap_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__bitmap_named__string(__skparam__name)
    return __skadapter__to_bitmap(__skreturn)
def bitmap_rectangle_of_cell ( src, cell ):
    __skparam__src = __skadapter__to_sklib_bitmap(src)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skreturn = sklib.__sklib__bitmap_rectangle_of_cell__bitmap__int(__skparam__src, __skparam__cell)
    return __skadapter__to_rectangle(__skreturn)
def bitmap_set_cell_details ( bmp, width, height, columns, rows, count ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__width = __skadapter__to_sklib_int(width)
    __skparam__height = __skadapter__to_sklib_int(height)
    __skparam__columns = __skadapter__to_sklib_int(columns)
    __skparam__rows = __skadapter__to_sklib_int(rows)
    __skparam__count = __skadapter__to_sklib_int(count)
    sklib.__sklib__bitmap_set_cell_details__bitmap__int__int__int__int__int(__skparam__bmp, __skparam__width, __skparam__height, __skparam__columns, __skparam__rows, __skparam__count)
def bitmap_valid ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_valid__bitmap(__skparam__bmp)
    return __skadapter__to_bool(__skreturn)
def bitmap_width ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_width__bitmap(__skparam__bmp)
    return __skadapter__to_int(__skreturn)
def bitmap_width_of_bitmap_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__bitmap_width__string(__skparam__name)
    return __skadapter__to_int(__skreturn)
def clear_bitmap ( bmp, clr ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    sklib.__sklib__clear_bitmap__bitmap__color(__skparam__bmp, __skparam__clr)
def clear_bitmap_named ( name, clr ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    sklib.__sklib__clear_bitmap__string__color(__skparam__name, __skparam__clr)
def create_bitmap ( name, width, height ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__width = __skadapter__to_sklib_int(width)
    __skparam__height = __skadapter__to_sklib_int(height)
    __skreturn = sklib.__sklib__create_bitmap__string__int__int(__skparam__name, __skparam__width, __skparam__height)
    return __skadapter__to_bitmap(__skreturn)
def draw_bitmap ( bmp, x, y ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_bitmap__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y)
def draw_bitmap_with_options ( bmp, x, y, opts ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_bitmap__bitmap__double__double__drawing_options(__skparam__bmp, __skparam__x, __skparam__y, __skparam__opts)
def draw_bitmap_named ( name, x, y ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_bitmap__string__double__double(__skparam__name, __skparam__x, __skparam__y)
def draw_bitmap_named_with_options ( name, x, y, opts ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_bitmap__string__double__double__drawing_options(__skparam__name, __skparam__x, __skparam__y, __skparam__opts)
def draw_bitmap_on_bitmap_on_bitmap ( destination, bmp, x, y ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y)
def draw_bitmap_on_bitmap_on_bitmap_with_options ( destination, bmp, x, y, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double__drawing_options(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y, __skparam__opts)
def draw_bitmap_on_window ( destination, bmp, x, y ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_bitmap_on_window__window__bitmap__double__double(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y)
def draw_bitmap_on_window_with_options ( destination, bmp, x, y, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_bitmap_on_window__window__bitmap__double__double__drawing_options(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y, __skparam__opts)
def free_all_bitmaps (  ):
    sklib.__sklib__free_all_bitmaps()
def free_bitmap ( to_delete ):
    __skparam__to_delete = __skadapter__to_sklib_bitmap(to_delete)
    sklib.__sklib__free_bitmap__bitmap(__skparam__to_delete)
def has_bitmap ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_bitmap__string(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def load_bitmap ( name, filename ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__filename = __skadapter__to_sklib_string(filename)
    __skreturn = sklib.__sklib__load_bitmap__string__string(__skparam__name, __skparam__filename)
    return __skadapter__to_bitmap(__skreturn)
def pixel_drawn_at_point_pt ( bmp, pt ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__pixel_drawn_at_point__bitmap__point_2d_ref(__skparam__bmp, __skparam__pt)
    return __skadapter__to_bool(__skreturn)
def pixel_drawn_at_point ( bmp, x, y ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__pixel_drawn_at_point__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y)
    return __skadapter__to_bool(__skreturn)
def pixel_drawn_at_point_in_cell_pt ( bmp, cell, pt ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__pixel_drawn_at_point__bitmap__int__point_2d_ref(__skparam__bmp, __skparam__cell, __skparam__pt)
    return __skadapter__to_bool(__skreturn)
def pixel_drawn_at_point_in_cell ( bmp, cell, x, y ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__cell = __skadapter__to_sklib_int(cell)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__pixel_drawn_at_point__bitmap__int__double__double(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y)
    return __skadapter__to_bool(__skreturn)
def setup_collision_mask ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    sklib.__sklib__setup_collision_mask__bitmap(__skparam__bmp)
def process_events (  ):
    sklib.__sklib__process_events()
def quit_requested (  ):
    __skreturn = sklib.__sklib__quit_requested()
    return __skadapter__to_bool(__skreturn)
def reset_quit (  ):
    sklib.__sklib__reset_quit()
def add_column ( width ):
    __skparam__width = __skadapter__to_sklib_int(width)
    sklib.__sklib__add_column__int(__skparam__width)
def add_column_relative ( width ):
    __skparam__width = __skadapter__to_sklib_double(width)
    sklib.__sklib__add_column_relative__double(__skparam__width)
def bitmap_button ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_button__bitmap(__skparam__bmp)
    return __skadapter__to_bool(__skreturn)
def bitmap_button_at_position ( bmp, rect ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__bitmap_button__bitmap__rectangle_ref(__skparam__bmp, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def bitmap_button_at_position_with_options ( bmp, rect, opts ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__bitmap_button__bitmap__rectangle_ref__drawing_options(__skparam__bmp, __skparam__rect, __skparam__opts)
    return __skadapter__to_bool(__skreturn)
def bitmap_button_with_options ( bmp, opts ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__bitmap_button__bitmap__drawing_options(__skparam__bmp, __skparam__opts)
    return __skadapter__to_bool(__skreturn)
def bitmap_button_labeled ( label_text, bmp ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__bitmap_button__string_ref__bitmap(__skparam__label_text, __skparam__bmp)
    return __skadapter__to_bool(__skreturn)
def bitmap_button_labeled_with_options ( label_text, bmp, opts ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    __skreturn = sklib.__sklib__bitmap_button__string_ref__bitmap__drawing_options(__skparam__label_text, __skparam__bmp, __skparam__opts)
    return __skadapter__to_bool(__skreturn)
def button_at_position ( text, rect ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__button__string_ref__rectangle_ref(__skparam__text, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def button ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skreturn = sklib.__sklib__button__string_ref(__skparam__text)
    return __skadapter__to_bool(__skreturn)
def button_labeled ( label_text, text ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skreturn = sklib.__sklib__button__string_ref__string_ref(__skparam__label_text, __skparam__text)
    return __skadapter__to_bool(__skreturn)
def checkbox_at_position ( text, value, rect ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__value = __skadapter__to_sklib_bool(value)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__checkbox__string_ref__bool_ref__rectangle_ref(__skparam__text, __skparam__value, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def checkbox ( text, value ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__value = __skadapter__to_sklib_bool(value)
    __skreturn = sklib.__sklib__checkbox__string_ref__bool_ref(__skparam__text, __skparam__value)
    return __skadapter__to_bool(__skreturn)
def checkbox_labeled ( label_text, text, value ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__value = __skadapter__to_sklib_bool(value)
    __skreturn = sklib.__sklib__checkbox__string_ref__string_ref__bool_ref(__skparam__label_text, __skparam__text, __skparam__value)
    return __skadapter__to_bool(__skreturn)
def color_slider_at_position ( clr, rect ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__color_slider__color_ref__rectangle_ref(__skparam__clr, __skparam__rect)
    return __skadapter__to_color(__skreturn)
def color_slider ( clr ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skreturn = sklib.__sklib__color_slider__color_ref(__skparam__clr)
    return __skadapter__to_color(__skreturn)
def color_slider_labeled ( label_text, clr ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skreturn = sklib.__sklib__color_slider__string_ref__color_ref(__skparam__label_text, __skparam__clr)
    return __skadapter__to_color(__skreturn)
def disable_interface (  ):
    sklib.__sklib__disable_interface()
def draw_interface (  ):
    sklib.__sklib__draw_interface()
def enable_interface (  ):
    sklib.__sklib__enable_interface()
def end_inset ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__end_inset__string_ref(__skparam__name)
def end_panel ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__end_panel__string_ref(__skparam__name)
def end_popup ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__end_popup__string_ref(__skparam__name)
def end_treenode ( label_text ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    sklib.__sklib__end_treenode__string_ref(__skparam__label_text)
def enter_column (  ):
    sklib.__sklib__enter_column()
def get_interface_label_width (  ):
    __skreturn = sklib.__sklib__get_interface_label_width()
    return __skadapter__to_int(__skreturn)
def header ( label_text ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    __skreturn = sklib.__sklib__header__string_ref(__skparam__label_text)
    return __skadapter__to_bool(__skreturn)
def hsb_color_slider_at_position ( clr, rect ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__hsb_color_slider__color_ref__rectangle_ref(__skparam__clr, __skparam__rect)
    return __skadapter__to_color(__skreturn)
def hsb_color_slider ( clr ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skreturn = sklib.__sklib__hsb_color_slider__color_ref(__skparam__clr)
    return __skadapter__to_color(__skreturn)
def hsb_color_slider_labeled ( label_text, clr ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skreturn = sklib.__sklib__hsb_color_slider__string_ref__color_ref(__skparam__label_text, __skparam__clr)
    return __skadapter__to_color(__skreturn)
def interface_enabled (  ):
    __skreturn = sklib.__sklib__interface_enabled()
    return __skadapter__to_bool(__skreturn)
def interface_style_panel ( initial_rectangle ):
    __skparam__initial_rectangle = __skadapter__to_sklib_rectangle(initial_rectangle)
    sklib.__sklib__interface_style_panel__rectangle_ref(__skparam__initial_rectangle)
def label_element ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    sklib.__sklib__label_element__string_ref(__skparam__text)
def label_element_at_position ( text, rect ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__label_element__string_ref__rectangle_ref(__skparam__text, __skparam__rect)
def last_element_changed (  ):
    __skreturn = sklib.__sklib__last_element_changed()
    return __skadapter__to_bool(__skreturn)
def last_element_confirmed (  ):
    __skreturn = sklib.__sklib__last_element_confirmed()
    return __skadapter__to_bool(__skreturn)
def leave_column (  ):
    sklib.__sklib__leave_column()
def number_box_at_position ( value, step, rect ):
    __skparam__value = __skadapter__to_sklib_float(value)
    __skparam__step = __skadapter__to_sklib_float(step)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__number_box__float_ref__float__rectangle_ref(__skparam__value, __skparam__step, __skparam__rect)
    return __skadapter__to_float(__skreturn)
def number_box ( value, step ):
    __skparam__value = __skadapter__to_sklib_float(value)
    __skparam__step = __skadapter__to_sklib_float(step)
    __skreturn = sklib.__sklib__number_box__float_ref__float(__skparam__value, __skparam__step)
    return __skadapter__to_float(__skreturn)
def number_box_labeled ( label_text, value, step ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    __skparam__value = __skadapter__to_sklib_float(value)
    __skparam__step = __skadapter__to_sklib_float(step)
    __skreturn = sklib.__sklib__number_box__string_ref__float_ref__float(__skparam__label_text, __skparam__value, __skparam__step)
    return __skadapter__to_float(__skreturn)
def open_popup ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__open_popup__string_ref(__skparam__name)
def paragraph ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    sklib.__sklib__paragraph__string_ref(__skparam__text)
def paragraph_at_position ( text, rect ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__paragraph__string_ref__rectangle_ref(__skparam__text, __skparam__rect)
def reset_layout (  ):
    sklib.__sklib__reset_layout()
def set_interface_accent_color ( clr, contrast ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__contrast = __skadapter__to_sklib_float(contrast)
    sklib.__sklib__set_interface_accent_color__color__float(__skparam__clr, __skparam__contrast)
def set_interface_border_color ( clr ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    sklib.__sklib__set_interface_border_color__color(__skparam__clr)
def set_interface_colors_auto ( main_clr, accent_clr, contrast, accent_contrast, border_contrast ):
    __skparam__main_clr = __skadapter__to_sklib_color(main_clr)
    __skparam__accent_clr = __skadapter__to_sklib_color(accent_clr)
    __skparam__contrast = __skadapter__to_sklib_float(contrast)
    __skparam__accent_contrast = __skadapter__to_sklib_float(accent_contrast)
    __skparam__border_contrast = __skadapter__to_sklib_float(border_contrast)
    sklib.__sklib__set_interface_colors_auto__color__color__float__float__float(__skparam__main_clr, __skparam__accent_clr, __skparam__contrast, __skparam__accent_contrast, __skparam__border_contrast)
def set_interface_element_color ( clr, contrast ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__contrast = __skadapter__to_sklib_float(contrast)
    sklib.__sklib__set_interface_element_color__color__float(__skparam__clr, __skparam__contrast)
def set_interface_element_shadows ( radius, clr, offset ):
    __skparam__radius = __skadapter__to_sklib_int(radius)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__offset = __skadapter__to_sklib_point_2d(offset)
    sklib.__sklib__set_interface_element_shadows__int__color__point_2d(__skparam__radius, __skparam__clr, __skparam__offset)
def set_interface_font_font_as_string ( fnt ):
    __skparam__fnt = __skadapter__to_sklib_string(fnt)
    sklib.__sklib__set_interface_font__string_ref(__skparam__fnt)
def set_interface_font ( fnt ):
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    sklib.__sklib__set_interface_font__font(__skparam__fnt)
def set_interface_font_size ( size ):
    __skparam__size = __skadapter__to_sklib_int(size)
    sklib.__sklib__set_interface_font_size__int(__skparam__size)
def set_interface_label_width ( width ):
    __skparam__width = __skadapter__to_sklib_int(width)
    sklib.__sklib__set_interface_label_width__int(__skparam__width)
def set_interface_panel_shadows ( radius, clr, offset ):
    __skparam__radius = __skadapter__to_sklib_int(radius)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__offset = __skadapter__to_sklib_point_2d(offset)
    sklib.__sklib__set_interface_panel_shadows__int__color__point_2d(__skparam__radius, __skparam__clr, __skparam__offset)
def set_interface_root_text_color ( clr ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    sklib.__sklib__set_interface_root_text_color__color(__skparam__clr)
def set_interface_shadows ( radius, clr, offset ):
    __skparam__radius = __skadapter__to_sklib_int(radius)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__offset = __skadapter__to_sklib_point_2d(offset)
    sklib.__sklib__set_interface_shadows__int__color__point_2d(__skparam__radius, __skparam__clr, __skparam__offset)
def set_interface_spacing ( spacing, padding ):
    __skparam__spacing = __skadapter__to_sklib_int(spacing)
    __skparam__padding = __skadapter__to_sklib_int(padding)
    sklib.__sklib__set_interface_spacing__int__int(__skparam__spacing, __skparam__padding)
def set_interface_style ( style ):
    __skparam__style = __skadapter__to_sklib_interface_style(style)
    sklib.__sklib__set_interface_style__interface_style(__skparam__style)
def set_interface_style_with_color ( style, clr ):
    __skparam__style = __skadapter__to_sklib_interface_style(style)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    sklib.__sklib__set_interface_style__interface_style__color(__skparam__style, __skparam__clr)
def set_interface_text_color ( clr ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    sklib.__sklib__set_interface_text_color__color(__skparam__clr)
def set_layout_height ( height ):
    __skparam__height = __skadapter__to_sklib_int(height)
    sklib.__sklib__set_layout_height__int(__skparam__height)
def single_line_layout (  ):
    sklib.__sklib__single_line_layout()
def slider_at_position ( value, min_value, max_value, rect ):
    __skparam__value = __skadapter__to_sklib_float(value)
    __skparam__min_value = __skadapter__to_sklib_float(min_value)
    __skparam__max_value = __skadapter__to_sklib_float(max_value)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__slider__float_ref__float__float__rectangle_ref(__skparam__value, __skparam__min_value, __skparam__max_value, __skparam__rect)
    return __skadapter__to_float(__skreturn)
def slider ( value, min_value, max_value ):
    __skparam__value = __skadapter__to_sklib_float(value)
    __skparam__min_value = __skadapter__to_sklib_float(min_value)
    __skparam__max_value = __skadapter__to_sklib_float(max_value)
    __skreturn = sklib.__sklib__slider__float_ref__float__float(__skparam__value, __skparam__min_value, __skparam__max_value)
    return __skadapter__to_float(__skreturn)
def slider_labeled ( label_text, value, min_value, max_value ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    __skparam__value = __skadapter__to_sklib_float(value)
    __skparam__min_value = __skadapter__to_sklib_float(min_value)
    __skparam__max_value = __skadapter__to_sklib_float(max_value)
    __skreturn = sklib.__sklib__slider__string_ref__float_ref__float__float(__skparam__label_text, __skparam__value, __skparam__min_value, __skparam__max_value)
    return __skadapter__to_float(__skreturn)
def split_into_columns ( count ):
    __skparam__count = __skadapter__to_sklib_int(count)
    sklib.__sklib__split_into_columns__int(__skparam__count)
def split_into_columns_with_last_width ( count, last_width ):
    __skparam__count = __skadapter__to_sklib_int(count)
    __skparam__last_width = __skadapter__to_sklib_int(last_width)
    sklib.__sklib__split_into_columns__int__int(__skparam__count, __skparam__last_width)
def split_into_columns_relative_with_last_width ( count, last_width ):
    __skparam__count = __skadapter__to_sklib_int(count)
    __skparam__last_width = __skadapter__to_sklib_double(last_width)
    sklib.__sklib__split_into_columns_relative__int__double(__skparam__count, __skparam__last_width)
def start_custom_layout (  ):
    sklib.__sklib__start_custom_layout()
def start_inset_at_position ( name, rect ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__start_inset__string_ref__rectangle_ref(__skparam__name, __skparam__rect)
def start_inset ( name, height ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__height = __skadapter__to_sklib_int(height)
    sklib.__sklib__start_inset__string_ref__int(__skparam__name, __skparam__height)
def start_panel ( name, initial_rectangle ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__initial_rectangle = __skadapter__to_sklib_rectangle(initial_rectangle)
    __skreturn = sklib.__sklib__start_panel__string_ref__rectangle(__skparam__name, __skparam__initial_rectangle)
    return __skadapter__to_bool(__skreturn)
def start_popup ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__start_popup__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def start_treenode ( label_text ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    __skreturn = sklib.__sklib__start_treenode__string_ref(__skparam__label_text)
    return __skadapter__to_bool(__skreturn)
def text_box ( value ):
    __skparam__value = __skadapter__to_sklib_string(value)
    __skreturn = sklib.__sklib__text_box__string_ref(__skparam__value)
    return __skadapter__to_string(__skreturn)
def text_box_at_position ( value, rect ):
    __skparam__value = __skadapter__to_sklib_string(value)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__text_box__string_ref__rectangle_ref(__skparam__value, __skparam__rect)
    return __skadapter__to_string(__skreturn)
def text_box_labeled ( label_text, value ):
    __skparam__label_text = __skadapter__to_sklib_string(label_text)
    __skparam__value = __skadapter__to_sklib_string(value)
    __skreturn = sklib.__sklib__text_box__string_ref__string_ref(__skparam__label_text, __skparam__value)
    return __skadapter__to_string(__skreturn)
def create_json (  ):
    __skreturn = sklib.__sklib__create_json()
    return __skadapter__to_json(__skreturn)
def create_json_from_string ( json_string ):
    __skparam__json_string = __skadapter__to_sklib_string(json_string)
    __skreturn = sklib.__sklib__create_json__string(__skparam__json_string)
    return __skadapter__to_json(__skreturn)
def free_all_json (  ):
    sklib.__sklib__free_all_json()
def free_json ( j ):
    __skparam__j = __skadapter__to_sklib_json(j)
    sklib.__sklib__free_json__json(__skparam__j)
def json_count_keys ( j ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skreturn = sklib.__sklib__json_count_keys__json(__skparam__j)
    return __skadapter__to_int(__skreturn)
def json_from_color ( clr ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skreturn = sklib.__sklib__json_from_color__color(__skparam__clr)
    return __skadapter__to_json(__skreturn)
def json_from_file ( filename ):
    __skparam__filename = __skadapter__to_sklib_string(filename)
    __skreturn = sklib.__sklib__json_from_file__string_ref(__skparam__filename)
    return __skadapter__to_json(__skreturn)
def json_from_string ( j_string ):
    __skparam__j_string = __skadapter__to_sklib_string(j_string)
    __skreturn = sklib.__sklib__json_from_string__string_ref(__skparam__j_string)
    return __skadapter__to_json(__skreturn)
def json_has_key ( j, key ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skreturn = sklib.__sklib__json_has_key__json__string(__skparam__j, __skparam__key)
    return __skadapter__to_bool(__skreturn)
def json_read_array_of_double ( j, key, out_result ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__out_result = __skadapter__to_sklib_vector_double(out_result)
    sklib.__sklib__json_read_array__json__string__vector_double_ref(__skparam__j, __skparam__key, byref(__skparam__out_result))
    __skadapter__update_from_vector_double(__skparam__out_result, out_result)
def json_read_array_of_json ( j, key, out_result ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__out_result = __skadapter__to_sklib_vector_json(out_result)
    sklib.__sklib__json_read_array__json__string__vector_json_ref(__skparam__j, __skparam__key, byref(__skparam__out_result))
    __skadapter__update_from_vector_json(__skparam__out_result, out_result)
def json_read_array_of_string ( j, key, out_result ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__out_result = __skadapter__to_sklib_vector_string(out_result)
    sklib.__sklib__json_read_array__json__string__vector_string_ref(__skparam__j, __skparam__key, byref(__skparam__out_result))
    __skadapter__update_from_vector_string(__skparam__out_result, out_result)
def json_read_array_of_bool ( j, key, out_result ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__out_result = __skadapter__to_sklib_vector_bool(out_result)
    sklib.__sklib__json_read_array__json__string__vector_bool_ref(__skparam__j, __skparam__key, byref(__skparam__out_result))
    __skadapter__update_from_vector_bool(__skparam__out_result, out_result)
def json_read_bool ( j, key ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skreturn = sklib.__sklib__json_read_bool__json__string(__skparam__j, __skparam__key)
    return __skadapter__to_bool(__skreturn)
def json_read_number ( j, key ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skreturn = sklib.__sklib__json_read_number__json__string(__skparam__j, __skparam__key)
    return __skadapter__to_float(__skreturn)
def json_read_number_as_double ( j, key ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skreturn = sklib.__sklib__json_read_number_as_double__json__string(__skparam__j, __skparam__key)
    return __skadapter__to_double(__skreturn)
def json_read_number_as_int ( j, key ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skreturn = sklib.__sklib__json_read_number_as_int__json__string(__skparam__j, __skparam__key)
    return __skadapter__to_int(__skreturn)
def json_read_object ( j, key ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skreturn = sklib.__sklib__json_read_object__json__string(__skparam__j, __skparam__key)
    return __skadapter__to_json(__skreturn)
def json_read_string ( j, key ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skreturn = sklib.__sklib__json_read_string__json__string(__skparam__j, __skparam__key)
    return __skadapter__to_string(__skreturn)
def json_set_array_of_string ( j, key, value ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__value = __skadapter__to_sklib_vector_string(value)
    sklib.__sklib__json_set_array__json__string__vector_string(__skparam__j, __skparam__key, __skparam__value)
def json_set_array_of_double ( j, key, value ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__value = __skadapter__to_sklib_vector_double(value)
    sklib.__sklib__json_set_array__json__string__vector_double(__skparam__j, __skparam__key, __skparam__value)
def json_set_array_of_bool ( j, key, value ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__value = __skadapter__to_sklib_vector_bool(value)
    sklib.__sklib__json_set_array__json__string__vector_bool(__skparam__j, __skparam__key, __skparam__value)
def json_set_array_of_json ( j, key, value ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__value = __skadapter__to_sklib_vector_json(value)
    sklib.__sklib__json_set_array__json__string__vector_json(__skparam__j, __skparam__key, __skparam__value)
def json_set_bool ( j, key, value ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__value = __skadapter__to_sklib_bool(value)
    sklib.__sklib__json_set_bool__json__string__bool(__skparam__j, __skparam__key, __skparam__value)
def json_set_number_integer ( j, key, value ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__value = __skadapter__to_sklib_int(value)
    sklib.__sklib__json_set_number__json__string__int(__skparam__j, __skparam__key, __skparam__value)
def json_set_number_double ( j, key, value ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__value = __skadapter__to_sklib_double(value)
    sklib.__sklib__json_set_number__json__string__double(__skparam__j, __skparam__key, __skparam__value)
def json_set_number_float ( j, key, value ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__value = __skadapter__to_sklib_float(value)
    sklib.__sklib__json_set_number__json__string__float(__skparam__j, __skparam__key, __skparam__value)
def json_set_object ( j, key, obj ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__obj = __skadapter__to_sklib_json(obj)
    sklib.__sklib__json_set_object__json__string__json(__skparam__j, __skparam__key, __skparam__obj)
def json_set_string ( j, key, value ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__key = __skadapter__to_sklib_string(key)
    __skparam__value = __skadapter__to_sklib_string(value)
    sklib.__sklib__json_set_string__json__string__string(__skparam__j, __skparam__key, __skparam__value)
def json_to_color ( j ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skreturn = sklib.__sklib__json_to_color__json(__skparam__j)
    return __skadapter__to_color(__skreturn)
def json_to_file ( j, filename ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skparam__filename = __skadapter__to_sklib_string(filename)
    sklib.__sklib__json_to_file__json__string_ref(__skparam__j, __skparam__filename)
def json_to_string ( j ):
    __skparam__j = __skadapter__to_sklib_json(j)
    __skreturn = sklib.__sklib__json_to_string__json(__skparam__j)
    return __skadapter__to_string(__skreturn)
def any_key_pressed (  ):
    __skreturn = sklib.__sklib__any_key_pressed()
    return __skadapter__to_bool(__skreturn)
def deregister_callback_on_key_down ( callback ):
    __skparam__callback = __skadapter__to_sklib_key_callback(callback)
    sklib.__sklib__deregister_callback_on_key_down__key_callback_ptr(__skparam__callback)
def deregister_callback_on_key_typed ( callback ):
    __skparam__callback = __skadapter__to_sklib_key_callback(callback)
    sklib.__sklib__deregister_callback_on_key_typed__key_callback_ptr(__skparam__callback)
def deregister_callback_on_key_up ( callback ):
    __skparam__callback = __skadapter__to_sklib_key_callback(callback)
    sklib.__sklib__deregister_callback_on_key_up__key_callback_ptr(__skparam__callback)
def key_down ( key ):
    __skparam__key = __skadapter__to_sklib_key_code(key)
    __skreturn = sklib.__sklib__key_down__key_code(__skparam__key)
    return __skadapter__to_bool(__skreturn)
def key_name ( key ):
    __skparam__key = __skadapter__to_sklib_key_code(key)
    __skreturn = sklib.__sklib__key_name__key_code(__skparam__key)
    return __skadapter__to_string(__skreturn)
def key_released ( key ):
    __skparam__key = __skadapter__to_sklib_key_code(key)
    __skreturn = sklib.__sklib__key_released__key_code(__skparam__key)
    return __skadapter__to_bool(__skreturn)
def key_typed ( key ):
    __skparam__key = __skadapter__to_sklib_key_code(key)
    __skreturn = sklib.__sklib__key_typed__key_code(__skparam__key)
    return __skadapter__to_bool(__skreturn)
def key_up ( key ):
    __skparam__key = __skadapter__to_sklib_key_code(key)
    __skreturn = sklib.__sklib__key_up__key_code(__skparam__key)
    return __skadapter__to_bool(__skreturn)
def register_callback_on_key_down ( callback ):
    __skparam__callback = __skadapter__to_sklib_key_callback(callback)
    sklib.__sklib__register_callback_on_key_down__key_callback_ptr(__skparam__callback)
def register_callback_on_key_typed ( callback ):
    __skparam__callback = __skadapter__to_sklib_key_callback(callback)
    sklib.__sklib__register_callback_on_key_typed__key_callback_ptr(__skparam__callback)
def register_callback_on_key_up ( callback ):
    __skparam__callback = __skadapter__to_sklib_key_callback(callback)
    sklib.__sklib__register_callback_on_key_up__key_callback_ptr(__skparam__callback)
def draw_line_record ( clr, l ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__l = __skadapter__to_sklib_line(l)
    sklib.__sklib__draw_line__color__line_ref(__skparam__clr, __skparam__l)
def draw_line_record_with_options ( clr, l, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__l = __skadapter__to_sklib_line(l)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_line__color__line_ref__drawing_options(__skparam__clr, __skparam__l, __skparam__opts)
def draw_line_point_to_point ( clr, from_pt, to_pt ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__from_pt = __skadapter__to_sklib_point_2d(from_pt)
    __skparam__to_pt = __skadapter__to_sklib_point_2d(to_pt)
    sklib.__sklib__draw_line__color__point_2d_ref__point_2d_ref(__skparam__clr, __skparam__from_pt, __skparam__to_pt)
def draw_line_point_to_point_with_options ( clr, from_pt, to_pt, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__from_pt = __skadapter__to_sklib_point_2d(from_pt)
    __skparam__to_pt = __skadapter__to_sklib_point_2d(to_pt)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_line__color__point_2d_ref__point_2d_ref__drawing_options_ref(__skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts)
def draw_line ( clr, x1, y1, x2, y2 ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    sklib.__sklib__draw_line__color__double__double__double__double(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2)
def draw_line_with_options ( clr, x1, y1, x2, y2, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_line__color__double__double__double__double__drawing_options_ref(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts)
def draw_line_on_bitmap_record ( destination, clr, l ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__l = __skadapter__to_sklib_line(l)
    sklib.__sklib__draw_line_on_bitmap__bitmap__color__line_ref(__skparam__destination, __skparam__clr, __skparam__l)
def draw_line_on_bitmap_record_with_options ( destination, clr, l, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__l = __skadapter__to_sklib_line(l)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_line_on_bitmap__bitmap__color__line_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__l, __skparam__opts)
def draw_line_on_bitmap_point_to_point ( destination, clr, from_pt, to_pt ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__from_pt = __skadapter__to_sklib_point_2d(from_pt)
    __skparam__to_pt = __skadapter__to_sklib_point_2d(to_pt)
    sklib.__sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt)
def draw_line_on_bitmap_point_to_point_with_options ( destination, clr, from_pt, to_pt, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__from_pt = __skadapter__to_sklib_point_2d(from_pt)
    __skparam__to_pt = __skadapter__to_sklib_point_2d(to_pt)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts)
def draw_line_on_bitmap ( destination, clr, x1, y1, x2, y2 ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    sklib.__sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2)
def draw_line_on_bitmap_with_options ( destination, clr, x1, y1, x2, y2, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts)
def draw_line_on_window_record ( destination, clr, l ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__l = __skadapter__to_sklib_line(l)
    sklib.__sklib__draw_line_on_window__window__color__line_ref(__skparam__destination, __skparam__clr, __skparam__l)
def draw_line_on_window_record_with_options ( destination, clr, l, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__l = __skadapter__to_sklib_line(l)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_line_on_window__window__color__line_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__l, __skparam__opts)
def draw_line_on_window_point_to_point ( destination, clr, from_pt, to_pt ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__from_pt = __skadapter__to_sklib_point_2d(from_pt)
    __skparam__to_pt = __skadapter__to_sklib_point_2d(to_pt)
    sklib.__sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt)
def draw_line_on_window_point_to_point_with_options ( destination, clr, from_pt, to_pt, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__from_pt = __skadapter__to_sklib_point_2d(from_pt)
    __skparam__to_pt = __skadapter__to_sklib_point_2d(to_pt)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts)
def draw_line_on_window ( destination, clr, x1, y1, x2, y2 ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    sklib.__sklib__draw_line_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2)
def draw_line_on_window_with_options ( destination, clr, x1, y1, x2, y2, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_line_on_window__window__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts)
def closest_point_on_line ( from_pt, l ):
    __skparam__from_pt = __skadapter__to_sklib_point_2d(from_pt)
    __skparam__l = __skadapter__to_sklib_line(l)
    __skreturn = sklib.__sklib__closest_point_on_line__point_2d__line_ref(__skparam__from_pt, __skparam__l)
    return __skadapter__to_point_2d(__skreturn)
def closest_point_on_lines ( from_pt, lines, line_idx ):
    __skparam__from_pt = __skadapter__to_sklib_point_2d(from_pt)
    __skparam__lines = __skadapter__to_sklib_vector_line(lines)
    __skparam__line_idx = __skadapter__to_sklib_int(line_idx)
    __skreturn = sklib.__sklib__closest_point_on_lines__point_2d__vector_line_ref__int_ref(__skparam__from_pt, __skparam__lines, byref(__skparam__line_idx))
    line_idx = __skadapter__to_int(__skparam__line_idx)
    return __skadapter__to_point_2d(__skreturn)
def line_from_point_to_point ( start, end_pt ):
    __skparam__start = __skadapter__to_sklib_point_2d(start)
    __skparam__end_pt = __skadapter__to_sklib_point_2d(end_pt)
    __skreturn = sklib.__sklib__line_from__point_2d_ref__point_2d_ref(__skparam__start, __skparam__end_pt)
    return __skadapter__to_line(__skreturn)
def line_from_start_with_offset ( start, offset ):
    __skparam__start = __skadapter__to_sklib_point_2d(start)
    __skparam__offset = __skadapter__to_sklib_vector_2d(offset)
    __skreturn = sklib.__sklib__line_from__point_2d_ref__vector_2d_ref(__skparam__start, __skparam__offset)
    return __skadapter__to_line(__skreturn)
def line_from_vector ( v ):
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skreturn = sklib.__sklib__line_from__vector_2d_ref(__skparam__v)
    return __skadapter__to_line(__skreturn)
def line_from ( x1, y1, x2, y2 ):
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skreturn = sklib.__sklib__line_from__double__double__double__double(__skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2)
    return __skadapter__to_line(__skreturn)
def line_intersection_point ( line1, line2, pt ):
    __skparam__line1 = __skadapter__to_sklib_line(line1)
    __skparam__line2 = __skadapter__to_sklib_line(line2)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__line_intersection_point__line_ref__line_ref__point_2d_ref(__skparam__line1, __skparam__line2, byref(__skparam__pt))
    pt = __skadapter__to_point_2d(__skparam__pt)
    return __skadapter__to_bool(__skreturn)
def line_intersects_circle ( l, c ):
    __skparam__l = __skadapter__to_sklib_line(l)
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skreturn = sklib.__sklib__line_intersects_circle__line_ref__circle_ref(__skparam__l, __skparam__c)
    return __skadapter__to_bool(__skreturn)
def line_intersects_lines ( l, lines ):
    __skparam__l = __skadapter__to_sklib_line(l)
    __skparam__lines = __skadapter__to_sklib_vector_line(lines)
    __skreturn = sklib.__sklib__line_intersects_lines__line_ref__vector_line_ref(__skparam__l, __skparam__lines)
    return __skadapter__to_bool(__skreturn)
def line_intersects_rect ( l, rect ):
    __skparam__l = __skadapter__to_sklib_line(l)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__line_intersects_rect__line_ref__rectangle_ref(__skparam__l, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def line_length ( l ):
    __skparam__l = __skadapter__to_sklib_line(l)
    __skreturn = sklib.__sklib__line_length__line_ref(__skparam__l)
    return __skadapter__to_float(__skreturn)
def line_length_squared ( l ):
    __skparam__l = __skadapter__to_sklib_line(l)
    __skreturn = sklib.__sklib__line_length_squared__line_ref(__skparam__l)
    return __skadapter__to_float(__skreturn)
def line_mid_point ( l ):
    __skparam__l = __skadapter__to_sklib_line(l)
    __skreturn = sklib.__sklib__line_mid_point__line_ref(__skparam__l)
    return __skadapter__to_point_2d(__skreturn)
def line_normal ( l ):
    __skparam__l = __skadapter__to_sklib_line(l)
    __skreturn = sklib.__sklib__line_normal__line_ref(__skparam__l)
    return __skadapter__to_vector_2d(__skreturn)
def line_to_string ( ln ):
    __skparam__ln = __skadapter__to_sklib_line(ln)
    __skreturn = sklib.__sklib__line_to_string__line_ref(__skparam__ln)
    return __skadapter__to_string(__skreturn)
def lines_from_rectangle ( rect ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__lines_from__rectangle_ref(__skparam__rect)
    return __skadapter__to_vector_line(__skreturn)
def lines_from_triangle ( t ):
    __skparam__t = __skadapter__to_sklib_triangle(t)
    __skreturn = sklib.__sklib__lines_from__triangle_ref(__skparam__t)
    return __skadapter__to_vector_line(__skreturn)
def lines_intersect ( l1, l2 ):
    __skparam__l1 = __skadapter__to_sklib_line(l1)
    __skparam__l2 = __skadapter__to_sklib_line(l2)
    __skreturn = sklib.__sklib__lines_intersect__line_ref__line_ref(__skparam__l1, __skparam__l2)
    return __skadapter__to_bool(__skreturn)
def close_log_process (  ):
    sklib.__sklib__close_log_process()
def init_custom_logger ( mode ):
    __skparam__mode = __skadapter__to_sklib_log_mode(mode)
    sklib.__sklib__init_custom_logger__log_mode(__skparam__mode)
def init_custom_logger__name_override_mode ( app_name, override_prev_log, mode ):
    __skparam__app_name = __skadapter__to_sklib_string(app_name)
    __skparam__override_prev_log = __skadapter__to_sklib_bool(override_prev_log)
    __skparam__mode = __skadapter__to_sklib_log_mode(mode)
    sklib.__sklib__init_custom_logger__string__bool__log_mode(__skparam__app_name, __skparam__override_prev_log, __skparam__mode)
def log ( level, message ):
    __skparam__level = __skadapter__to_sklib_log_level(level)
    __skparam__message = __skadapter__to_sklib_string(message)
    sklib.__sklib__log__log_level__string(__skparam__level, __skparam__message)
def apply_matrix_to_quad ( matrix, q ):
    __skparam__matrix = __skadapter__to_sklib_matrix_2d(matrix)
    __skparam__q = __skadapter__to_sklib_quad(q)
    sklib.__sklib__apply_matrix__matrix_2d_ref__quad_ref(__skparam__matrix, byref(__skparam__q))
    q = __skadapter__to_quad(__skparam__q)
def apply_matrix_to_triangle ( m, tri ):
    __skparam__m = __skadapter__to_sklib_matrix_2d(m)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    sklib.__sklib__apply_matrix__matrix_2d_ref__triangle_ref(__skparam__m, byref(__skparam__tri))
    tri = __skadapter__to_triangle(__skparam__tri)
def identity_matrix (  ):
    __skreturn = sklib.__sklib__identity_matrix()
    return __skadapter__to_matrix_2d(__skreturn)
def matrix_inverse ( m ):
    __skparam__m = __skadapter__to_sklib_matrix_2d(m)
    __skreturn = sklib.__sklib__matrix_inverse__matrix_2d_ref(__skparam__m)
    return __skadapter__to_matrix_2d(__skreturn)
def matrix_multiply_point ( m, pt ):
    __skparam__m = __skadapter__to_sklib_matrix_2d(m)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__matrix_multiply__matrix_2d_ref__point_2d_ref(__skparam__m, __skparam__pt)
    return __skadapter__to_point_2d(__skreturn)
def matrix_multiply_matrix ( m1, m2 ):
    __skparam__m1 = __skadapter__to_sklib_matrix_2d(m1)
    __skparam__m2 = __skadapter__to_sklib_matrix_2d(m2)
    __skreturn = sklib.__sklib__matrix_multiply__matrix_2d_ref__matrix_2d_ref(__skparam__m1, __skparam__m2)
    return __skadapter__to_matrix_2d(__skreturn)
def matrix_multiply_vector ( m, v ):
    __skparam__m = __skadapter__to_sklib_matrix_2d(m)
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skreturn = sklib.__sklib__matrix_multiply__matrix_2d_ref__vector_2d_ref(__skparam__m, __skparam__v)
    return __skadapter__to_vector_2d(__skreturn)
def matrix_to_string ( matrix ):
    __skparam__matrix = __skadapter__to_sklib_matrix_2d(matrix)
    __skreturn = sklib.__sklib__matrix_to_string__matrix_2d_ref(__skparam__matrix)
    return __skadapter__to_string(__skreturn)
def rotation_matrix ( deg ):
    __skparam__deg = __skadapter__to_sklib_double(deg)
    __skreturn = sklib.__sklib__rotation_matrix__double(__skparam__deg)
    return __skadapter__to_matrix_2d(__skreturn)
def scale_matrix_from_point ( scale ):
    __skparam__scale = __skadapter__to_sklib_point_2d(scale)
    __skreturn = sklib.__sklib__scale_matrix__point_2d_ref(__skparam__scale)
    return __skadapter__to_matrix_2d(__skreturn)
def scale_matrix_from_vector ( scale ):
    __skparam__scale = __skadapter__to_sklib_vector_2d(scale)
    __skreturn = sklib.__sklib__scale_matrix__vector_2d_ref(__skparam__scale)
    return __skadapter__to_matrix_2d(__skreturn)
def scale_matrix ( scale ):
    __skparam__scale = __skadapter__to_sklib_double(scale)
    __skreturn = sklib.__sklib__scale_matrix__double(__skparam__scale)
    return __skadapter__to_matrix_2d(__skreturn)
def scale_rotate_translate_matrix ( scale, deg, translate ):
    __skparam__scale = __skadapter__to_sklib_point_2d(scale)
    __skparam__deg = __skadapter__to_sklib_double(deg)
    __skparam__translate = __skadapter__to_sklib_point_2d(translate)
    __skreturn = sklib.__sklib__scale_rotate_translate_matrix__point_2d_ref__double__point_2d_ref(__skparam__scale, __skparam__deg, __skparam__translate)
    return __skadapter__to_matrix_2d(__skreturn)
def translation_matrix_to_point ( pt ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__translation_matrix__point_2d_ref(__skparam__pt)
    return __skadapter__to_matrix_2d(__skreturn)
def translation_matrix_from_vector ( pt ):
    __skparam__pt = __skadapter__to_sklib_vector_2d(pt)
    __skreturn = sklib.__sklib__translation_matrix__vector_2d_ref(__skparam__pt)
    return __skadapter__to_matrix_2d(__skreturn)
def translation_matrix ( dx, dy ):
    __skparam__dx = __skadapter__to_sklib_double(dx)
    __skparam__dy = __skadapter__to_sklib_double(dy)
    __skreturn = sklib.__sklib__translation_matrix__double__double(__skparam__dx, __skparam__dy)
    return __skadapter__to_matrix_2d(__skreturn)
def hide_mouse (  ):
    sklib.__sklib__hide_mouse()
def mouse_clicked ( button ):
    __skparam__button = __skadapter__to_sklib_mouse_button(button)
    __skreturn = sklib.__sklib__mouse_clicked__mouse_button(__skparam__button)
    return __skadapter__to_bool(__skreturn)
def mouse_down ( button ):
    __skparam__button = __skadapter__to_sklib_mouse_button(button)
    __skreturn = sklib.__sklib__mouse_down__mouse_button(__skparam__button)
    return __skadapter__to_bool(__skreturn)
def mouse_movement (  ):
    __skreturn = sklib.__sklib__mouse_movement()
    return __skadapter__to_vector_2d(__skreturn)
def mouse_position (  ):
    __skreturn = sklib.__sklib__mouse_position()
    return __skadapter__to_point_2d(__skreturn)
def mouse_position_vector (  ):
    __skreturn = sklib.__sklib__mouse_position_vector()
    return __skadapter__to_vector_2d(__skreturn)
def mouse_shown (  ):
    __skreturn = sklib.__sklib__mouse_shown()
    return __skadapter__to_bool(__skreturn)
def mouse_up ( button ):
    __skparam__button = __skadapter__to_sklib_mouse_button(button)
    __skreturn = sklib.__sklib__mouse_up__mouse_button(__skparam__button)
    return __skadapter__to_bool(__skreturn)
def mouse_wheel_scroll (  ):
    __skreturn = sklib.__sklib__mouse_wheel_scroll()
    return __skadapter__to_vector_2d(__skreturn)
def mouse_x (  ):
    __skreturn = sklib.__sklib__mouse_x()
    return __skadapter__to_float(__skreturn)
def mouse_y (  ):
    __skreturn = sklib.__sklib__mouse_y()
    return __skadapter__to_float(__skreturn)
def move_mouse ( x, y ):
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__move_mouse__double__double(__skparam__x, __skparam__y)
def move_mouse_to_point ( point ):
    __skparam__point = __skadapter__to_sklib_point_2d(point)
    sklib.__sklib__move_mouse__point_2d(__skparam__point)
def show_mouse (  ):
    sklib.__sklib__show_mouse()
def show_mouse_with_boolean ( show ):
    __skparam__show = __skadapter__to_sklib_bool(show)
    sklib.__sklib__show_mouse__bool(__skparam__show)
def fade_music_in_named ( name, ms ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__ms = __skadapter__to_sklib_int(ms)
    sklib.__sklib__fade_music_in__string_ref__int(__skparam__name, __skparam__ms)
def fade_music_in_named_with_times ( name, times, ms ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__times = __skadapter__to_sklib_int(times)
    __skparam__ms = __skadapter__to_sklib_int(ms)
    sklib.__sklib__fade_music_in__string_ref__int__int(__skparam__name, __skparam__times, __skparam__ms)
def fade_music_in ( data, ms ):
    __skparam__data = __skadapter__to_sklib_music(data)
    __skparam__ms = __skadapter__to_sklib_int(ms)
    sklib.__sklib__fade_music_in__music__int(__skparam__data, __skparam__ms)
def fade_music_in_with_times ( data, times, ms ):
    __skparam__data = __skadapter__to_sklib_music(data)
    __skparam__times = __skadapter__to_sklib_int(times)
    __skparam__ms = __skadapter__to_sklib_int(ms)
    sklib.__sklib__fade_music_in__music__int__int(__skparam__data, __skparam__times, __skparam__ms)
def fade_music_out ( ms ):
    __skparam__ms = __skadapter__to_sklib_int(ms)
    sklib.__sklib__fade_music_out__int(__skparam__ms)
def free_all_music (  ):
    sklib.__sklib__free_all_music()
def free_music ( effect ):
    __skparam__effect = __skadapter__to_sklib_music(effect)
    sklib.__sklib__free_music__music(__skparam__effect)
def has_music ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_music__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def load_music ( name, filename ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__filename = __skadapter__to_sklib_string(filename)
    __skreturn = sklib.__sklib__load_music__string_ref__string_ref(__skparam__name, __skparam__filename)
    return __skadapter__to_music(__skreturn)
def music_filename ( data ):
    __skparam__data = __skadapter__to_sklib_music(data)
    __skreturn = sklib.__sklib__music_filename__music(__skparam__data)
    return __skadapter__to_string(__skreturn)
def music_name ( data ):
    __skparam__data = __skadapter__to_sklib_music(data)
    __skreturn = sklib.__sklib__music_name__music(__skparam__data)
    return __skadapter__to_string(__skreturn)
def music_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__music_named__string_ref(__skparam__name)
    return __skadapter__to_music(__skreturn)
def music_playing (  ):
    __skreturn = sklib.__sklib__music_playing()
    return __skadapter__to_bool(__skreturn)
def music_valid ( m ):
    __skparam__m = __skadapter__to_sklib_music(m)
    __skreturn = sklib.__sklib__music_valid__music(__skparam__m)
    return __skadapter__to_bool(__skreturn)
def music_volume (  ):
    __skreturn = sklib.__sklib__music_volume()
    return __skadapter__to_double(__skreturn)
def pause_music (  ):
    sklib.__sklib__pause_music()
def play_music_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__play_music__string_ref(__skparam__name)
def play_music_named_with_times ( name, times ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__times = __skadapter__to_sklib_int(times)
    sklib.__sklib__play_music__string_ref__int(__skparam__name, __skparam__times)
def play_music ( data ):
    __skparam__data = __skadapter__to_sklib_music(data)
    sklib.__sklib__play_music__music(__skparam__data)
def play_music_with_times ( data, times ):
    __skparam__data = __skadapter__to_sklib_music(data)
    __skparam__times = __skadapter__to_sklib_int(times)
    sklib.__sklib__play_music__music__int(__skparam__data, __skparam__times)
def play_music_with_times_and_volume ( data, times, volume ):
    __skparam__data = __skadapter__to_sklib_music(data)
    __skparam__times = __skadapter__to_sklib_int(times)
    __skparam__volume = __skadapter__to_sklib_double(volume)
    sklib.__sklib__play_music__music__int__double(__skparam__data, __skparam__times, __skparam__volume)
def resume_music (  ):
    sklib.__sklib__resume_music()
def set_music_volume ( volume ):
    __skparam__volume = __skadapter__to_sklib_double(volume)
    sklib.__sklib__set_music_volume__double(__skparam__volume)
def stop_music (  ):
    sklib.__sklib__stop_music()
def accept_all_new_connections (  ):
    __skreturn = sklib.__sklib__accept_all_new_connections()
    return __skadapter__to_bool(__skreturn)
def accept_new_connection ( server ):
    __skparam__server = __skadapter__to_sklib_server_socket(server)
    __skreturn = sklib.__sklib__accept_new_connection__server_socket(__skparam__server)
    return __skadapter__to_bool(__skreturn)
def broadcast_message ( a_msg, svr ):
    __skparam__a_msg = __skadapter__to_sklib_string(a_msg)
    __skparam__svr = __skadapter__to_sklib_server_socket(svr)
    sklib.__sklib__broadcast_message__string_ref__server_socket(__skparam__a_msg, __skparam__svr)
def broadcast_message_to_all ( a_msg ):
    __skparam__a_msg = __skadapter__to_sklib_string(a_msg)
    sklib.__sklib__broadcast_message__string_ref(__skparam__a_msg)
def broadcast_message_to_server_named ( a_msg, name ):
    __skparam__a_msg = __skadapter__to_sklib_string(a_msg)
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__broadcast_message__string_ref__string_ref(__skparam__a_msg, __skparam__name)
def check_network_activity (  ):
    sklib.__sklib__check_network_activity()
def clear_messages_from_name ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__clear_messages__string_ref(__skparam__name)
def clear_messages_from_connection ( a_connection ):
    __skparam__a_connection = __skadapter__to_sklib_connection(a_connection)
    sklib.__sklib__clear_messages__connection(__skparam__a_connection)
def clear_messages_from_server ( svr ):
    __skparam__svr = __skadapter__to_sklib_server_socket(svr)
    sklib.__sklib__clear_messages__server_socket(__skparam__svr)
def close_all_connections (  ):
    sklib.__sklib__close_all_connections()
def close_all_servers (  ):
    sklib.__sklib__close_all_servers()
def close_connection ( a_connection ):
    __skparam__a_connection = __skadapter__to_sklib_connection(a_connection)
    __skreturn = sklib.__sklib__close_connection__connection(__skparam__a_connection)
    return __skadapter__to_bool(__skreturn)
def close_connection_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__close_connection__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def close_message ( msg ):
    __skparam__msg = __skadapter__to_sklib_message(msg)
    sklib.__sklib__close_message__message(__skparam__msg)
def close_server_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__close_server__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def close_server ( svr ):
    __skparam__svr = __skadapter__to_sklib_server_socket(svr)
    __skreturn = sklib.__sklib__close_server__server_socket(__skparam__svr)
    return __skadapter__to_bool(__skreturn)
def connection_count_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__connection_count__string_ref(__skparam__name)
    return __skadapter__to_unsigned_int(__skreturn)
def connection_count ( server ):
    __skparam__server = __skadapter__to_sklib_server_socket(server)
    __skreturn = sklib.__sklib__connection_count__server_socket(__skparam__server)
    return __skadapter__to_unsigned_int(__skreturn)
def connection_ip ( a_connection ):
    __skparam__a_connection = __skadapter__to_sklib_connection(a_connection)
    __skreturn = sklib.__sklib__connection_ip__connection(__skparam__a_connection)
    return __skadapter__to_unsigned_int(__skreturn)
def connection_ip_from_name ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__connection_ip__string_ref(__skparam__name)
    return __skadapter__to_unsigned_int(__skreturn)
def connection_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__connection_named__string_ref(__skparam__name)
    return __skadapter__to_connection(__skreturn)
def connection_port ( a_connection ):
    __skparam__a_connection = __skadapter__to_sklib_connection(a_connection)
    __skreturn = sklib.__sklib__connection_port__connection(__skparam__a_connection)
    return __skadapter__to_unsigned_short(__skreturn)
def connection_port_from_name ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__connection_port__string_ref(__skparam__name)
    return __skadapter__to_unsigned_short(__skreturn)
def create_server_with_port ( name, port ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skreturn = sklib.__sklib__create_server__string_ref__unsigned_short(__skparam__name, __skparam__port)
    return __skadapter__to_server_socket(__skreturn)
def create_server_with_port_and_protocol ( name, port, protocol ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skparam__protocol = __skadapter__to_sklib_connection_type(protocol)
    __skreturn = sklib.__sklib__create_server__string_ref__unsigned_short__connection_type(__skparam__name, __skparam__port, __skparam__protocol)
    return __skadapter__to_server_socket(__skreturn)
def dec_to_hex ( a_dec ):
    __skparam__a_dec = __skadapter__to_sklib_unsigned_int(a_dec)
    __skreturn = sklib.__sklib__dec_to_hex__unsigned_int(__skparam__a_dec)
    return __skadapter__to_string(__skreturn)
def fetch_new_connection ( server ):
    __skparam__server = __skadapter__to_sklib_server_socket(server)
    __skreturn = sklib.__sklib__fetch_new_connection__server_socket(__skparam__server)
    return __skadapter__to_connection(__skreturn)
def has_connection ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_connection__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def has_messages (  ):
    __skreturn = sklib.__sklib__has_messages()
    return __skadapter__to_bool(__skreturn)
def has_messages_on_connection ( con ):
    __skparam__con = __skadapter__to_sklib_connection(con)
    __skreturn = sklib.__sklib__has_messages__connection(__skparam__con)
    return __skadapter__to_bool(__skreturn)
def has_messages_on_name ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_messages__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def has_messages_on_server ( svr ):
    __skparam__svr = __skadapter__to_sklib_server_socket(svr)
    __skreturn = sklib.__sklib__has_messages__server_socket(__skparam__svr)
    return __skadapter__to_bool(__skreturn)
def has_new_connections (  ):
    __skreturn = sklib.__sklib__has_new_connections()
    return __skadapter__to_bool(__skreturn)
def has_server ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_server__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def hex_str_to_ipv4 ( a_hex ):
    __skparam__a_hex = __skadapter__to_sklib_string(a_hex)
    __skreturn = sklib.__sklib__hex_str_to_ipv4__string_ref(__skparam__a_hex)
    return __skadapter__to_string(__skreturn)
def hex_to_dec_string ( a_hex ):
    __skparam__a_hex = __skadapter__to_sklib_string(a_hex)
    __skreturn = sklib.__sklib__hex_to_dec_string__string_ref(__skparam__a_hex)
    return __skadapter__to_string(__skreturn)
def ipv4_to_dec ( a_ip ):
    __skparam__a_ip = __skadapter__to_sklib_string(a_ip)
    __skreturn = sklib.__sklib__ipv4_to_dec__string_ref(__skparam__a_ip)
    return __skadapter__to_unsigned_int(__skreturn)
def ipv4_to_hex ( a_ip ):
    __skparam__a_ip = __skadapter__to_sklib_string(a_ip)
    __skreturn = sklib.__sklib__ipv4_to_hex__string_ref(__skparam__a_ip)
    return __skadapter__to_string(__skreturn)
def ipv4_to_str ( ip ):
    __skparam__ip = __skadapter__to_sklib_unsigned_int(ip)
    __skreturn = sklib.__sklib__ipv4_to_str__unsigned_int(__skparam__ip)
    return __skadapter__to_string(__skreturn)
def is_connection_open ( con ):
    __skparam__con = __skadapter__to_sklib_connection(con)
    __skreturn = sklib.__sklib__is_connection_open__connection(__skparam__con)
    return __skadapter__to_bool(__skreturn)
def is_connection_open_from_name ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__is_connection_open__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def last_connection_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__last_connection__string_ref(__skparam__name)
    return __skadapter__to_connection(__skreturn)
def last_connection ( server ):
    __skparam__server = __skadapter__to_sklib_server_socket(server)
    __skreturn = sklib.__sklib__last_connection__server_socket(__skparam__server)
    return __skadapter__to_connection(__skreturn)
def message_connection ( msg ):
    __skparam__msg = __skadapter__to_sklib_message(msg)
    __skreturn = sklib.__sklib__message_connection__message(__skparam__msg)
    return __skadapter__to_connection(__skreturn)
def message_count_on_server ( svr ):
    __skparam__svr = __skadapter__to_sklib_server_socket(svr)
    __skreturn = sklib.__sklib__message_count__server_socket(__skparam__svr)
    return __skadapter__to_unsigned_int(__skreturn)
def message_count_on_connection ( a_connection ):
    __skparam__a_connection = __skadapter__to_sklib_connection(a_connection)
    __skreturn = sklib.__sklib__message_count__connection(__skparam__a_connection)
    return __skadapter__to_unsigned_int(__skreturn)
def message_count_from_name ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__message_count__string_ref(__skparam__name)
    return __skadapter__to_unsigned_int(__skreturn)
def message_data ( msg ):
    __skparam__msg = __skadapter__to_sklib_message(msg)
    __skreturn = sklib.__sklib__message_data__message(__skparam__msg)
    return __skadapter__to_string(__skreturn)
def message_data_bytes ( msg ):
    __skparam__msg = __skadapter__to_sklib_message(msg)
    __skreturn = sklib.__sklib__message_data_bytes__message(__skparam__msg)
    return __skadapter__to_vector_int8_t(__skreturn)
def message_host ( msg ):
    __skparam__msg = __skadapter__to_sklib_message(msg)
    __skreturn = sklib.__sklib__message_host__message(__skparam__msg)
    return __skadapter__to_string(__skreturn)
def message_port ( msg ):
    __skparam__msg = __skadapter__to_sklib_message(msg)
    __skreturn = sklib.__sklib__message_port__message(__skparam__msg)
    return __skadapter__to_unsigned_short(__skreturn)
def message_protocol ( msg ):
    __skparam__msg = __skadapter__to_sklib_message(msg)
    __skreturn = sklib.__sklib__message_protocol__message(__skparam__msg)
    return __skadapter__to_connection_type(__skreturn)
def my_ip (  ):
    __skreturn = sklib.__sklib__my_ip()
    return __skadapter__to_string(__skreturn)
def name_for_connection ( host, port ):
    __skparam__host = __skadapter__to_sklib_string(host)
    __skparam__port = __skadapter__to_sklib_unsigned_int(port)
    __skreturn = sklib.__sklib__name_for_connection__string__unsigned_int(__skparam__host, __skparam__port)
    return __skadapter__to_string(__skreturn)
def new_connection_count ( server ):
    __skparam__server = __skadapter__to_sklib_server_socket(server)
    __skreturn = sklib.__sklib__new_connection_count__server_socket(__skparam__server)
    return __skadapter__to_int(__skreturn)
def open_connection ( name, host, port ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__host = __skadapter__to_sklib_string(host)
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skreturn = sklib.__sklib__open_connection__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__host, __skparam__port)
    return __skadapter__to_connection(__skreturn)
def open_connection_with_protocol ( name, host, port, protocol ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__host = __skadapter__to_sklib_string(host)
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skparam__protocol = __skadapter__to_sklib_connection_type(protocol)
    __skreturn = sklib.__sklib__open_connection__string_ref__string_ref__unsigned_short__connection_type(__skparam__name, __skparam__host, __skparam__port, __skparam__protocol)
    return __skadapter__to_connection(__skreturn)
def read_message (  ):
    __skreturn = sklib.__sklib__read_message()
    return __skadapter__to_message(__skreturn)
def read_message_from_connection ( a_connection ):
    __skparam__a_connection = __skadapter__to_sklib_connection(a_connection)
    __skreturn = sklib.__sklib__read_message__connection(__skparam__a_connection)
    return __skadapter__to_message(__skreturn)
def read_message_from_name ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__read_message__string_ref(__skparam__name)
    return __skadapter__to_message(__skreturn)
def read_message_from_server ( svr ):
    __skparam__svr = __skadapter__to_sklib_server_socket(svr)
    __skreturn = sklib.__sklib__read_message__server_socket(__skparam__svr)
    return __skadapter__to_message(__skreturn)
def read_message_data_from_name ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__read_message_data__string_ref(__skparam__name)
    return __skadapter__to_string(__skreturn)
def read_message_data_from_connection ( a_connection ):
    __skparam__a_connection = __skadapter__to_sklib_connection(a_connection)
    __skreturn = sklib.__sklib__read_message_data__connection(__skparam__a_connection)
    return __skadapter__to_string(__skreturn)
def read_message_data_from_server ( svr ):
    __skparam__svr = __skadapter__to_sklib_server_socket(svr)
    __skreturn = sklib.__sklib__read_message_data__server_socket(__skparam__svr)
    return __skadapter__to_string(__skreturn)
def reconnect ( a_connection ):
    __skparam__a_connection = __skadapter__to_sklib_connection(a_connection)
    sklib.__sklib__reconnect__connection(__skparam__a_connection)
def reconnect_from_name ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__reconnect__string_ref(__skparam__name)
def release_all_connections (  ):
    sklib.__sklib__release_all_connections()
def reset_new_connection_count ( server ):
    __skparam__server = __skadapter__to_sklib_server_socket(server)
    sklib.__sklib__reset_new_connection_count__server_socket(__skparam__server)
def retrieve_connection_named ( name, idx ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skreturn = sklib.__sklib__retrieve_connection__string_ref__int(__skparam__name, __skparam__idx)
    return __skadapter__to_connection(__skreturn)
def retrieve_connection ( server, idx ):
    __skparam__server = __skadapter__to_sklib_server_socket(server)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skreturn = sklib.__sklib__retrieve_connection__server_socket__int(__skparam__server, __skparam__idx)
    return __skadapter__to_connection(__skreturn)
def send_message_to_connection ( a_msg, a_connection ):
    __skparam__a_msg = __skadapter__to_sklib_string(a_msg)
    __skparam__a_connection = __skadapter__to_sklib_connection(a_connection)
    __skreturn = sklib.__sklib__send_message_to__string_ref__connection(__skparam__a_msg, __skparam__a_connection)
    return __skadapter__to_bool(__skreturn)
def send_message_to_name ( a_msg, name ):
    __skparam__a_msg = __skadapter__to_sklib_string(a_msg)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__send_message_to__string_ref__string_ref(__skparam__a_msg, __skparam__name)
    return __skadapter__to_bool(__skreturn)
def server_has_new_connection_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__server_has_new_connection__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def server_has_new_connection ( server ):
    __skparam__server = __skadapter__to_sklib_server_socket(server)
    __skreturn = sklib.__sklib__server_has_new_connection__server_socket(__skparam__server)
    return __skadapter__to_bool(__skreturn)
def server_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__server_named__string_ref(__skparam__name)
    return __skadapter__to_server_socket(__skreturn)
def set_udp_packet_size ( udp_packet_size ):
    __skparam__udp_packet_size = __skadapter__to_sklib_unsigned_int(udp_packet_size)
    sklib.__sklib__set_udp_packet_size__unsigned_int(__skparam__udp_packet_size)
def udp_packet_size (  ):
    __skreturn = sklib.__sklib__udp_packet_size()
    return __skadapter__to_unsigned_int(__skreturn)
def draw_pixel_at_point ( clr, pt ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    sklib.__sklib__draw_pixel__color__point_2d_ref(__skparam__clr, __skparam__pt)
def draw_pixel_at_point_with_options ( clr, pt, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_pixel__color__point_2d_ref__drawing_options(__skparam__clr, __skparam__pt, __skparam__opts)
def draw_pixel ( clr, x, y ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_pixel__color__double__double(__skparam__clr, __skparam__x, __skparam__y)
def draw_pixel_with_options ( clr, x, y, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_pixel__color__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__opts)
def draw_pixel_on_bitmap_at_point ( destination, clr, pt ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__pt)
def draw_pixel_on_bitmap_at_point_with_options ( destination, clr, pt, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__pt, __skparam__opts)
def draw_pixel_on_bitmap ( destination, clr, x, y ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y)
def draw_pixel_on_bitmap_with_options ( destination, clr, x, y, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_pixel_on_bitmap__bitmap__color__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts)
def draw_pixel_on_window_at_point ( destination, clr, pt ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    sklib.__sklib__draw_pixel_on_window__window__color__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__pt)
def draw_pixel_on_window_at_point_with_options ( destination, clr, pt, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_pixel_on_window__window__color__point_2d_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__pt, __skparam__opts)
def draw_pixel_on_window ( destination, clr, x, y ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_pixel_on_window__window__color__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y)
def draw_pixel_on_window_with_options ( destination, clr, x, y, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_pixel_on_window__window__color__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts)
def get_pixel_from_bitmap_at_point ( bmp, pt ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__get_pixel__bitmap__point_2d_ref(__skparam__bmp, __skparam__pt)
    return __skadapter__to_color(__skreturn)
def get_pixel_from_bitmap ( bmp, x, y ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__get_pixel__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y)
    return __skadapter__to_color(__skreturn)
def get_pixel_at_point ( pt ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__get_pixel__point_2d_ref(__skparam__pt)
    return __skadapter__to_color(__skreturn)
def get_pixel ( x, y ):
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__get_pixel__double__double(__skparam__x, __skparam__y)
    return __skadapter__to_color(__skreturn)
def get_pixel_from_window_at_point ( wnd, pt ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__get_pixel__window__point_2d_ref(__skparam__wnd, __skparam__pt)
    return __skadapter__to_color(__skreturn)
def get_pixel_from_window ( wnd, x, y ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__get_pixel__window__double__double(__skparam__wnd, __skparam__x, __skparam__y)
    return __skadapter__to_color(__skreturn)
def get_pixel_from_window_at_point_from_window ( destination, pt ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__get_pixel_from_window__window__point_2d_ref(__skparam__destination, __skparam__pt)
    return __skadapter__to_color(__skreturn)
def get_pixel_from_window_from_window ( destination, x, y ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__get_pixel_from_window__window__double__double(__skparam__destination, __skparam__x, __skparam__y)
    return __skadapter__to_color(__skreturn)
def point_at ( x, y ):
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__point_at__double__double(__skparam__x, __skparam__y)
    return __skadapter__to_point_2d(__skreturn)
def point_at_origin (  ):
    __skreturn = sklib.__sklib__point_at_origin()
    return __skadapter__to_point_2d(__skreturn)
def point_in_circle ( pt, c ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skreturn = sklib.__sklib__point_in_circle__point_2d_ref__circle_ref(__skparam__pt, __skparam__c)
    return __skadapter__to_bool(__skreturn)
def point_in_circle_with_values ( ptx, pty, cx, cy, radius ):
    __skparam__ptx = __skadapter__to_sklib_double(ptx)
    __skparam__pty = __skadapter__to_sklib_double(pty)
    __skparam__cx = __skadapter__to_sklib_double(cx)
    __skparam__cy = __skadapter__to_sklib_double(cy)
    __skparam__radius = __skadapter__to_sklib_double(radius)
    __skreturn = sklib.__sklib__point_in_circle__double__double__double__double__double(__skparam__ptx, __skparam__pty, __skparam__cx, __skparam__cy, __skparam__radius)
    return __skadapter__to_bool(__skreturn)
def point_in_quad ( pt, q ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__q = __skadapter__to_sklib_quad(q)
    __skreturn = sklib.__sklib__point_in_quad__point_2d_ref__quad_ref(__skparam__pt, __skparam__q)
    return __skadapter__to_bool(__skreturn)
def point_in_rectangle ( pt, rect ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__point_in_rectangle__point_2d_ref__rectangle_ref(__skparam__pt, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def point_in_rectangle_with_values ( ptx, pty, rect_x, rect_y, rect_width, rect_height ):
    __skparam__ptx = __skadapter__to_sklib_double(ptx)
    __skparam__pty = __skadapter__to_sklib_double(pty)
    __skparam__rect_x = __skadapter__to_sklib_double(rect_x)
    __skparam__rect_y = __skadapter__to_sklib_double(rect_y)
    __skparam__rect_width = __skadapter__to_sklib_double(rect_width)
    __skparam__rect_height = __skadapter__to_sklib_double(rect_height)
    __skreturn = sklib.__sklib__point_in_rectangle__double__double__double__double__double__double(__skparam__ptx, __skparam__pty, __skparam__rect_x, __skparam__rect_y, __skparam__rect_width, __skparam__rect_height)
    return __skadapter__to_bool(__skreturn)
def point_in_triangle ( pt, tri ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skreturn = sklib.__sklib__point_in_triangle__point_2d_ref__triangle_ref(__skparam__pt, __skparam__tri)
    return __skadapter__to_bool(__skreturn)
def point_line_distance ( pt, l ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__l = __skadapter__to_sklib_line(l)
    __skreturn = sklib.__sklib__point_line_distance__point_2d_ref__line_ref(__skparam__pt, __skparam__l)
    return __skadapter__to_float(__skreturn)
def point_offset_by ( start_point, offset ):
    __skparam__start_point = __skadapter__to_sklib_point_2d(start_point)
    __skparam__offset = __skadapter__to_sklib_vector_2d(offset)
    __skreturn = sklib.__sklib__point_offset_by__point_2d_ref__vector_2d_ref(__skparam__start_point, __skparam__offset)
    return __skadapter__to_point_2d(__skreturn)
def point_offset_from_origin ( offset ):
    __skparam__offset = __skadapter__to_sklib_vector_2d(offset)
    __skreturn = sklib.__sklib__point_offset_from_origin__vector_2d_ref(__skparam__offset)
    return __skadapter__to_point_2d(__skreturn)
def point_on_line ( pt, l ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__l = __skadapter__to_sklib_line(l)
    __skreturn = sklib.__sklib__point_on_line__point_2d_ref__line_ref(__skparam__pt, __skparam__l)
    return __skadapter__to_bool(__skreturn)
def point_on_line_with_proximity ( pt, l, proximity ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__l = __skadapter__to_sklib_line(l)
    __skparam__proximity = __skadapter__to_sklib_float(proximity)
    __skreturn = sklib.__sklib__point_on_line__point_2d_ref__line_ref__float(__skparam__pt, __skparam__l, __skparam__proximity)
    return __skadapter__to_bool(__skreturn)
def point_point_angle ( pt1, pt2 ):
    __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1)
    __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2)
    __skreturn = sklib.__sklib__point_point_angle__point_2d_ref__point_2d_ref(__skparam__pt1, __skparam__pt2)
    return __skadapter__to_float(__skreturn)
def point_point_distance ( pt1, pt2 ):
    __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1)
    __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2)
    __skreturn = sklib.__sklib__point_point_distance__point_2d_ref__point_2d_ref(__skparam__pt1, __skparam__pt2)
    return __skadapter__to_float(__skreturn)
def point_to_string ( pt ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__point_to_string__point_2d_ref(__skparam__pt)
    return __skadapter__to_string(__skreturn)
def random_bitmap_point ( bmp ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skreturn = sklib.__sklib__random_bitmap_point__bitmap(__skparam__bmp)
    return __skadapter__to_point_2d(__skreturn)
def random_screen_point (  ):
    __skreturn = sklib.__sklib__random_screen_point()
    return __skadapter__to_point_2d(__skreturn)
def random_window_point ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skreturn = sklib.__sklib__random_window_point__window(__skparam__wind)
    return __skadapter__to_point_2d(__skreturn)
def same_point ( pt1, pt2 ):
    __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1)
    __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2)
    __skreturn = sklib.__sklib__same_point__point_2d_ref__point_2d_ref(__skparam__pt1, __skparam__pt2)
    return __skadapter__to_bool(__skreturn)
def quad_from_points ( p1, p2, p3, p4 ):
    __skparam__p1 = __skadapter__to_sklib_point_2d(p1)
    __skparam__p2 = __skadapter__to_sklib_point_2d(p2)
    __skparam__p3 = __skadapter__to_sklib_point_2d(p3)
    __skparam__p4 = __skadapter__to_sklib_point_2d(p4)
    __skreturn = sklib.__sklib__quad_from__point_2d_ref__point_2d_ref__point_2d_ref__point_2d_ref(__skparam__p1, __skparam__p2, __skparam__p3, __skparam__p4)
    return __skadapter__to_quad(__skreturn)
def quad_from_rectangle ( rect ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__quad_from__rectangle_ref(__skparam__rect)
    return __skadapter__to_quad(__skreturn)
def quad_from_rectangle_with_transformation ( rect, transform ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__transform = __skadapter__to_sklib_matrix_2d(transform)
    __skreturn = sklib.__sklib__quad_from__rectangle_ref__matrix_2d_ref(__skparam__rect, __skparam__transform)
    return __skadapter__to_quad(__skreturn)
def quad_from ( x_top_left, y_top_left, x_top_right, y_top_right, x_bottom_left, y_bottom_left, x_bottom_right, y_bottom_right ):
    __skparam__x_top_left = __skadapter__to_sklib_double(x_top_left)
    __skparam__y_top_left = __skadapter__to_sklib_double(y_top_left)
    __skparam__x_top_right = __skadapter__to_sklib_double(x_top_right)
    __skparam__y_top_right = __skadapter__to_sklib_double(y_top_right)
    __skparam__x_bottom_left = __skadapter__to_sklib_double(x_bottom_left)
    __skparam__y_bottom_left = __skadapter__to_sklib_double(y_bottom_left)
    __skparam__x_bottom_right = __skadapter__to_sklib_double(x_bottom_right)
    __skparam__y_bottom_right = __skadapter__to_sklib_double(y_bottom_right)
    __skreturn = sklib.__sklib__quad_from__double__double__double__double__double__double__double__double(__skparam__x_top_left, __skparam__y_top_left, __skparam__x_top_right, __skparam__y_top_right, __skparam__x_bottom_left, __skparam__y_bottom_left, __skparam__x_bottom_right, __skparam__y_bottom_right)
    return __skadapter__to_quad(__skreturn)
def quads_intersect ( q1, q2 ):
    __skparam__q1 = __skadapter__to_sklib_quad(q1)
    __skparam__q2 = __skadapter__to_sklib_quad(q2)
    __skreturn = sklib.__sklib__quads_intersect__quad_ref__quad_ref(__skparam__q1, __skparam__q2)
    return __skadapter__to_bool(__skreturn)
def set_quad_point ( q, idx, value ):
    __skparam__q = __skadapter__to_sklib_quad(q)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skparam__value = __skadapter__to_sklib_point_2d(value)
    sklib.__sklib__set_quad_point__quad_ref__int__point_2d_ref(byref(__skparam__q), __skparam__idx, __skparam__value)
    q = __skadapter__to_quad(__skparam__q)
def triangles_from ( q ):
    __skparam__q = __skadapter__to_sklib_quad(q)
    __skreturn = sklib.__sklib__triangles_from__quad_ref(__skparam__q)
    return __skadapter__to_vector_triangle(__skreturn)
def rnd_range ( min, max ):
    __skparam__min = __skadapter__to_sklib_int(min)
    __skparam__max = __skadapter__to_sklib_int(max)
    __skreturn = sklib.__sklib__rnd__int__int(__skparam__min, __skparam__max)
    return __skadapter__to_int(__skreturn)
def rnd (  ):
    __skreturn = sklib.__sklib__rnd()
    return __skadapter__to_float(__skreturn)
def rnd_int ( ubound ):
    __skparam__ubound = __skadapter__to_sklib_int(ubound)
    __skreturn = sklib.__sklib__rnd__int(__skparam__ubound)
    return __skadapter__to_int(__skreturn)
def has_gpio (  ):
    __skreturn = sklib.__sklib__has_gpio()
    return __skadapter__to_bool(__skreturn)
def raspi_cleanup (  ):
    sklib.__sklib__raspi_cleanup()
def raspi_get_mode ( pin ):
    __skparam__pin = __skadapter__to_sklib_pins(pin)
    __skreturn = sklib.__sklib__raspi_get_mode__pins(__skparam__pin)
    return __skadapter__to_pin_modes(__skreturn)
def raspi_init (  ):
    sklib.__sklib__raspi_init()
def raspi_read ( pin ):
    __skparam__pin = __skadapter__to_sklib_pins(pin)
    __skreturn = sklib.__sklib__raspi_read__pins(__skparam__pin)
    return __skadapter__to_pin_values(__skreturn)
def raspi_set_mode ( pin, mode ):
    __skparam__pin = __skadapter__to_sklib_pins(pin)
    __skparam__mode = __skadapter__to_sklib_pin_modes(mode)
    sklib.__sklib__raspi_set_mode__pins__pin_modes(__skparam__pin, __skparam__mode)
def raspi_set_pull_up_down ( pin, pud ):
    __skparam__pin = __skadapter__to_sklib_pins(pin)
    __skparam__pud = __skadapter__to_sklib_pull_up_down(pud)
    sklib.__sklib__raspi_set_pull_up_down__pins__pull_up_down(__skparam__pin, __skparam__pud)
def raspi_set_pwm_dutycycle ( pin, dutycycle ):
    __skparam__pin = __skadapter__to_sklib_pins(pin)
    __skparam__dutycycle = __skadapter__to_sklib_int(dutycycle)
    sklib.__sklib__raspi_set_pwm_dutycycle__pins__int(__skparam__pin, __skparam__dutycycle)
def raspi_set_pwm_frequency ( pin, frequency ):
    __skparam__pin = __skadapter__to_sklib_pins(pin)
    __skparam__frequency = __skadapter__to_sklib_int(frequency)
    sklib.__sklib__raspi_set_pwm_frequency__pins__int(__skparam__pin, __skparam__frequency)
def raspi_set_pwm_range ( pin, range ):
    __skparam__pin = __skadapter__to_sklib_pins(pin)
    __skparam__range = __skadapter__to_sklib_int(range)
    sklib.__sklib__raspi_set_pwm_range__pins__int(__skparam__pin, __skparam__range)
def raspi_write ( pin, value ):
    __skparam__pin = __skadapter__to_sklib_pins(pin)
    __skparam__value = __skadapter__to_sklib_pin_values(value)
    sklib.__sklib__raspi_write__pins__pin_values(__skparam__pin, __skparam__value)
def draw_quad ( clr, q ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    sklib.__sklib__draw_quad__color__quad_ref(__skparam__clr, __skparam__q)
def draw_quad_with_options ( clr, q, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_quad__color__quad_ref__drawing_options_ref(__skparam__clr, __skparam__q, __skparam__opts)
def draw_quad_on_bitmap ( destination, clr, q ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    sklib.__sklib__draw_quad_on_bitmap__bitmap__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q)
def draw_quad_on_bitmap_with_options ( destination, clr, q, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts)
def draw_quad_on_window ( destination, clr, q ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    sklib.__sklib__draw_quad_on_window__window__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q)
def draw_quad_on_window_with_options ( destination, clr, q, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_quad_on_window__window__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts)
def draw_rectangle_record ( clr, rect ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__draw_rectangle__color__rectangle_ref(__skparam__clr, __skparam__rect)
def draw_rectangle_record_with_options ( clr, rect, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_rectangle__color__rectangle_ref__drawing_options_ref(__skparam__clr, __skparam__rect, __skparam__opts)
def draw_rectangle ( clr, x, y, width, height ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__draw_rectangle__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def draw_rectangle_with_options ( clr, x, y, width, height, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_rectangle__color__double__double__double__double__drawing_options_ref(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def draw_rectangle_on_bitmap_record ( destination, clr, rect ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect)
def draw_rectangle_on_bitmap_record_with_options ( destination, clr, rect, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts)
def draw_rectangle_on_bitmap ( destination, clr, x, y, width, height ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def draw_rectangle_on_bitmap_with_options ( destination, clr, x, y, width, height, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def draw_rectangle_on_window_record ( destination, clr, rect ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__draw_rectangle_on_window__window__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect)
def draw_rectangle_on_window_record_with_options ( destination, clr, rect, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts)
def draw_rectangle_on_window ( destination, clr, x, y, width, height ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__draw_rectangle_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def draw_rectangle_on_window_with_options ( destination, clr, x, y, width, height, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_rectangle_on_window__window__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def fill_quad ( clr, q ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    sklib.__sklib__fill_quad__color__quad_ref(__skparam__clr, __skparam__q)
def fill_quad_with_options ( clr, q, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_quad__color__quad_ref__drawing_options_ref(__skparam__clr, __skparam__q, __skparam__opts)
def fill_quad_on_bitmap ( destination, clr, q ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    sklib.__sklib__fill_quad_on_bitmap__bitmap__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q)
def fill_quad_on_bitmap_with_options ( destination, clr, q, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts)
def fill_quad_on_window ( destination, clr, q ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    sklib.__sklib__fill_quad_on_window__window__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q)
def fill_quad_on_window_with_options ( destination, clr, q, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__q = __skadapter__to_sklib_quad(q)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_quad_on_window__window__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts)
def fill_rectangle_record ( clr, rect ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__fill_rectangle__color__rectangle_ref(__skparam__clr, __skparam__rect)
def fill_rectangle_record_with_options ( clr, rect, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_rectangle__color__rectangle_ref__drawing_options_ref(__skparam__clr, __skparam__rect, __skparam__opts)
def fill_rectangle ( clr, x, y, width, height ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__fill_rectangle__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def fill_rectangle_with_options ( clr, x, y, width, height, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_rectangle__color__double__double__double__double__drawing_options_ref(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def fill_rectangle_on_bitmap_record ( destination, clr, rect ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect)
def fill_rectangle_on_bitmap_record_with_options ( destination, clr, rect, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts)
def fill_rectangle_on_bitmap ( destination, clr, x, y, width, height ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def fill_rectangle_on_bitmap_with_options ( destination, clr, x, y, width, height, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def fill_rectangle_on_window_record ( destination, clr, rect ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__fill_rectangle_on_window__window__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect)
def fill_rectangle_on_window_record_with_options ( destination, clr, rect, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts)
def fill_rectangle_on_window ( destination, clr, x, y, width, height ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    sklib.__sklib__fill_rectangle_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height)
def fill_rectangle_on_window_with_options ( destination, clr, x, y, width, height, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_rectangle_on_window__window__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts)
def inset_rectangle ( rect, inset_amount ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__inset_amount = __skadapter__to_sklib_float(inset_amount)
    __skreturn = sklib.__sklib__inset_rectangle__rectangle_ref__float(__skparam__rect, __skparam__inset_amount)
    return __skadapter__to_rectangle(__skreturn)
def intersection ( rect1, rect2 ):
    __skparam__rect1 = __skadapter__to_sklib_rectangle(rect1)
    __skparam__rect2 = __skadapter__to_sklib_rectangle(rect2)
    __skreturn = sklib.__sklib__intersection__rectangle_ref__rectangle_ref(__skparam__rect1, __skparam__rect2)
    return __skadapter__to_rectangle(__skreturn)
def rectangle_around_circle ( c ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skreturn = sklib.__sklib__rectangle_around__circle_ref(__skparam__c)
    return __skadapter__to_rectangle(__skreturn)
def rectangle_around_line ( l ):
    __skparam__l = __skadapter__to_sklib_line(l)
    __skreturn = sklib.__sklib__rectangle_around__line_ref(__skparam__l)
    return __skadapter__to_rectangle(__skreturn)
def rectangle_around_quad ( q ):
    __skparam__q = __skadapter__to_sklib_quad(q)
    __skreturn = sklib.__sklib__rectangle_around__quad_ref(__skparam__q)
    return __skadapter__to_rectangle(__skreturn)
def rectangle_around_triangle ( t ):
    __skparam__t = __skadapter__to_sklib_triangle(t)
    __skreturn = sklib.__sklib__rectangle_around__triangle_ref(__skparam__t)
    return __skadapter__to_rectangle(__skreturn)
def rectangle_bottom ( rect ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__rectangle_bottom__rectangle_ref(__skparam__rect)
    return __skadapter__to_float(__skreturn)
def rectangle_center ( rect ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__rectangle_center__rectangle_ref(__skparam__rect)
    return __skadapter__to_point_2d(__skreturn)
def rectangle_from_point_and_size ( pt, width, height ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skreturn = sklib.__sklib__rectangle_from__point_2d__double__double(__skparam__pt, __skparam__width, __skparam__height)
    return __skadapter__to_rectangle(__skreturn)
def rectangle_from_points ( pt1, pt2 ):
    __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1)
    __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2)
    __skreturn = sklib.__sklib__rectangle_from__point_2d__point_2d(__skparam__pt1, __skparam__pt2)
    return __skadapter__to_rectangle(__skreturn)
def rectangle_from ( x, y, width, height ):
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__width = __skadapter__to_sklib_double(width)
    __skparam__height = __skadapter__to_sklib_double(height)
    __skreturn = sklib.__sklib__rectangle_from__double__double__double__double(__skparam__x, __skparam__y, __skparam__width, __skparam__height)
    return __skadapter__to_rectangle(__skreturn)
def rectangle_left ( rect ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__rectangle_left__rectangle_ref(__skparam__rect)
    return __skadapter__to_float(__skreturn)
def rectangle_offset_by ( rect, offset ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__offset = __skadapter__to_sklib_vector_2d(offset)
    __skreturn = sklib.__sklib__rectangle_offset_by__rectangle_ref__vector_2d_ref(__skparam__rect, __skparam__offset)
    return __skadapter__to_rectangle(__skreturn)
def rectangle_right ( rect ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__rectangle_right__rectangle_ref(__skparam__rect)
    return __skadapter__to_float(__skreturn)
def rectangle_to_string ( rect ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__rectangle_to_string__rectangle_ref(__skparam__rect)
    return __skadapter__to_string(__skreturn)
def rectangle_top ( rect ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__rectangle_top__rectangle_ref(__skparam__rect)
    return __skadapter__to_float(__skreturn)
def rectangles_intersect ( rect1, rect2 ):
    __skparam__rect1 = __skadapter__to_sklib_rectangle(rect1)
    __skparam__rect2 = __skadapter__to_sklib_rectangle(rect2)
    __skreturn = sklib.__sklib__rectangles_intersect__rectangle_ref__rectangle_ref(__skparam__rect1, __skparam__rect2)
    return __skadapter__to_bool(__skreturn)
def deregister_free_notifier ( handler ):
    __skparam__handler = __skadapter__to_sklib_free_notifier(handler)
    sklib.__sklib__deregister_free_notifier__free_notifier_ptr(__skparam__handler)
def path_to_resource ( filename, kind ):
    __skparam__filename = __skadapter__to_sklib_string(filename)
    __skparam__kind = __skadapter__to_sklib_resource_kind(kind)
    __skreturn = sklib.__sklib__path_to_resource__string_ref__resource_kind(__skparam__filename, __skparam__kind)
    return __skadapter__to_string(__skreturn)
def path_to_resources (  ):
    __skreturn = sklib.__sklib__path_to_resources()
    return __skadapter__to_string(__skreturn)
def path_to_resources_for_kind ( kind ):
    __skparam__kind = __skadapter__to_sklib_resource_kind(kind)
    __skreturn = sklib.__sklib__path_to_resources__resource_kind(__skparam__kind)
    return __skadapter__to_string(__skreturn)
def register_free_notifier ( fn ):
    __skparam__fn = __skadapter__to_sklib_free_notifier(fn)
    sklib.__sklib__register_free_notifier__free_notifier_ptr(__skparam__fn)
def set_resources_path ( path ):
    __skparam__path = __skadapter__to_sklib_string(path)
    sklib.__sklib__set_resources_path__string_ref(__skparam__path)
def fade_all_sound_effects_out ( ms ):
    __skparam__ms = __skadapter__to_sklib_int(ms)
    sklib.__sklib__fade_all_sound_effects_out__int(__skparam__ms)
def fade_sound_effect_out ( effect, ms ):
    __skparam__effect = __skadapter__to_sklib_sound_effect(effect)
    __skparam__ms = __skadapter__to_sklib_int(ms)
    sklib.__sklib__fade_sound_effect_out__sound_effect__int(__skparam__effect, __skparam__ms)
def free_all_sound_effects (  ):
    sklib.__sklib__free_all_sound_effects()
def free_sound_effect ( effect ):
    __skparam__effect = __skadapter__to_sklib_sound_effect(effect)
    sklib.__sklib__free_sound_effect__sound_effect(__skparam__effect)
def has_sound_effect ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_sound_effect__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def load_sound_effect ( name, filename ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__filename = __skadapter__to_sklib_string(filename)
    __skreturn = sklib.__sklib__load_sound_effect__string_ref__string_ref(__skparam__name, __skparam__filename)
    return __skadapter__to_sound_effect(__skreturn)
def play_sound_effect_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__play_sound_effect__string_ref(__skparam__name)
def play_sound_effect_named_with_volume ( name, volume ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__volume = __skadapter__to_sklib_double(volume)
    sklib.__sklib__play_sound_effect__string_ref__double(__skparam__name, __skparam__volume)
def play_sound_effect_named_with_times ( name, times ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__times = __skadapter__to_sklib_int(times)
    sklib.__sklib__play_sound_effect__string_ref__int(__skparam__name, __skparam__times)
def play_sound_effect_named_with_times_and_volume ( name, times, volume ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__times = __skadapter__to_sklib_int(times)
    __skparam__volume = __skadapter__to_sklib_double(volume)
    sklib.__sklib__play_sound_effect__string_ref__int__double(__skparam__name, __skparam__times, __skparam__volume)
def play_sound_effect ( effect ):
    __skparam__effect = __skadapter__to_sklib_sound_effect(effect)
    sklib.__sklib__play_sound_effect__sound_effect(__skparam__effect)
def play_sound_effect_with_volume ( effect, volume ):
    __skparam__effect = __skadapter__to_sklib_sound_effect(effect)
    __skparam__volume = __skadapter__to_sklib_double(volume)
    sklib.__sklib__play_sound_effect__sound_effect__double(__skparam__effect, __skparam__volume)
def play_sound_effect_with_times ( effect, times ):
    __skparam__effect = __skadapter__to_sklib_sound_effect(effect)
    __skparam__times = __skadapter__to_sklib_int(times)
    sklib.__sklib__play_sound_effect__sound_effect__int(__skparam__effect, __skparam__times)
def play_sound_effect_with_times_and_volume ( effect, times, volume ):
    __skparam__effect = __skadapter__to_sklib_sound_effect(effect)
    __skparam__times = __skadapter__to_sklib_int(times)
    __skparam__volume = __skadapter__to_sklib_double(volume)
    sklib.__sklib__play_sound_effect__sound_effect__int__double(__skparam__effect, __skparam__times, __skparam__volume)
def sound_effect_filename ( effect ):
    __skparam__effect = __skadapter__to_sklib_sound_effect(effect)
    __skreturn = sklib.__sklib__sound_effect_filename__sound_effect(__skparam__effect)
    return __skadapter__to_string(__skreturn)
def sound_effect_name ( effect ):
    __skparam__effect = __skadapter__to_sklib_sound_effect(effect)
    __skreturn = sklib.__sklib__sound_effect_name__sound_effect(__skparam__effect)
    return __skadapter__to_string(__skreturn)
def sound_effect_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sound_effect_named__string_ref(__skparam__name)
    return __skadapter__to_sound_effect(__skreturn)
def sound_effect_playing_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sound_effect_playing__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def sound_effect_playing ( effect ):
    __skparam__effect = __skadapter__to_sklib_sound_effect(effect)
    __skreturn = sklib.__sklib__sound_effect_playing__sound_effect(__skparam__effect)
    return __skadapter__to_bool(__skreturn)
def sound_effect_valid ( effect ):
    __skparam__effect = __skadapter__to_sklib_sound_effect(effect)
    __skreturn = sklib.__sklib__sound_effect_valid__sound_effect(__skparam__effect)
    return __skadapter__to_bool(__skreturn)
def stop_sound_effect_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__stop_sound_effect__string_ref(__skparam__name)
def stop_sound_effect ( effect ):
    __skparam__effect = __skadapter__to_sklib_sound_effect(effect)
    sklib.__sklib__stop_sound_effect__sound_effect(__skparam__effect)
def call_for_all_sprites_with_value ( fn, val ):
    __skparam__fn = __skadapter__to_sklib_sprite_float_function(fn)
    __skparam__val = __skadapter__to_sklib_float(val)
    sklib.__sklib__call_for_all_sprites__sprite_float_function_ptr__float(__skparam__fn, __skparam__val)
def call_for_all_sprites ( fn ):
    __skparam__fn = __skadapter__to_sklib_sprite_function(fn)
    sklib.__sklib__call_for_all_sprites__sprite_function_ptr(__skparam__fn)
def call_on_sprite_event ( handler ):
    __skparam__handler = __skadapter__to_sklib_sprite_event_handler(handler)
    sklib.__sklib__call_on_sprite_event__sprite_event_handler_ptr(__skparam__handler)
def center_point ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__center_point__sprite(__skparam__s)
    return __skadapter__to_point_2d(__skreturn)
def create_sprite ( layer ):
    __skparam__layer = __skadapter__to_sklib_bitmap(layer)
    __skreturn = sklib.__sklib__create_sprite__bitmap(__skparam__layer)
    return __skadapter__to_sprite(__skreturn)
def create_sprite_with_animation ( layer, ani ):
    __skparam__layer = __skadapter__to_sklib_bitmap(layer)
    __skparam__ani = __skadapter__to_sklib_animation_script(ani)
    __skreturn = sklib.__sklib__create_sprite__bitmap__animation_script(__skparam__layer, __skparam__ani)
    return __skadapter__to_sprite(__skreturn)
def create_sprite_with_bitmap_named ( bitmap_name ):
    __skparam__bitmap_name = __skadapter__to_sklib_string(bitmap_name)
    __skreturn = sklib.__sklib__create_sprite__string_ref(__skparam__bitmap_name)
    return __skadapter__to_sprite(__skreturn)
def create_sprite_named ( name, layer ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__layer = __skadapter__to_sklib_bitmap(layer)
    __skreturn = sklib.__sklib__create_sprite__string_ref__bitmap(__skparam__name, __skparam__layer)
    return __skadapter__to_sprite(__skreturn)
def create_sprite_named_with_animation ( name, layer, ani ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__layer = __skadapter__to_sklib_bitmap(layer)
    __skparam__ani = __skadapter__to_sklib_animation_script(ani)
    __skreturn = sklib.__sklib__create_sprite__string_ref__bitmap__animation_script(__skparam__name, __skparam__layer, __skparam__ani)
    return __skadapter__to_sprite(__skreturn)
def create_sprite_with_bitmap_and_animation_named ( bitmap_name, animation_name ):
    __skparam__bitmap_name = __skadapter__to_sklib_string(bitmap_name)
    __skparam__animation_name = __skadapter__to_sklib_string(animation_name)
    __skreturn = sklib.__sklib__create_sprite__string_ref__string_ref(__skparam__bitmap_name, __skparam__animation_name)
    return __skadapter__to_sprite(__skreturn)
def create_sprite_pack ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__create_sprite_pack__string_ref(__skparam__name)
def current_sprite_pack (  ):
    __skreturn = sklib.__sklib__current_sprite_pack()
    return __skadapter__to_string(__skreturn)
def draw_all_sprites (  ):
    sklib.__sklib__draw_all_sprites()
def draw_sprite_offset_by ( s, offset ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__offset = __skadapter__to_sklib_vector_2d(offset)
    sklib.__sklib__draw_sprite__sprite__vector_2d_ref(__skparam__s, __skparam__offset)
def draw_sprite ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    sklib.__sklib__draw_sprite__sprite(__skparam__s)
def draw_sprite_offset_x_y ( s, x_offset, y_offset ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__x_offset = __skadapter__to_sklib_double(x_offset)
    __skparam__y_offset = __skadapter__to_sklib_double(y_offset)
    sklib.__sklib__draw_sprite__sprite__double__double(__skparam__s, __skparam__x_offset, __skparam__y_offset)
def free_all_sprites (  ):
    sklib.__sklib__free_all_sprites()
def free_sprite ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    sklib.__sklib__free_sprite__sprite(__skparam__s)
def free_sprite_pack ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__free_sprite_pack__string_ref(__skparam__name)
def has_sprite ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_sprite__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def has_sprite_pack ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_sprite_pack__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def move_sprite ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    sklib.__sklib__move_sprite__sprite(__skparam__s)
def move_sprite_by_vector ( s, distance ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__distance = __skadapter__to_sklib_vector_2d(distance)
    sklib.__sklib__move_sprite__sprite__vector_2d_ref(__skparam__s, __skparam__distance)
def move_sprite_by_vector_percent ( s, distance, pct ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__distance = __skadapter__to_sklib_vector_2d(distance)
    __skparam__pct = __skadapter__to_sklib_float(pct)
    sklib.__sklib__move_sprite__sprite__vector_2d_ref__float(__skparam__s, __skparam__distance, __skparam__pct)
def move_sprite_percent ( s, pct ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__pct = __skadapter__to_sklib_float(pct)
    sklib.__sklib__move_sprite__sprite__float(__skparam__s, __skparam__pct)
def move_sprite_to ( s, x, y ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__move_sprite_to__sprite__double__double(__skparam__s, __skparam__x, __skparam__y)
def select_sprite_pack ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__select_sprite_pack__string_ref(__skparam__name)
def sprite_add_layer ( s, new_layer, layer_name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__new_layer = __skadapter__to_sklib_bitmap(new_layer)
    __skparam__layer_name = __skadapter__to_sklib_string(layer_name)
    __skreturn = sklib.__sklib__sprite_add_layer__sprite__bitmap__string_ref(__skparam__s, __skparam__new_layer, __skparam__layer_name)
    return __skadapter__to_int(__skreturn)
def sprite_add_to_velocity ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_vector_2d(value)
    sklib.__sklib__sprite_add_to_velocity__sprite__vector_2d_ref(__skparam__s, __skparam__value)
def sprite_add_value ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__sprite_add_value__sprite__string_ref(__skparam__s, __skparam__name)
def sprite_add_value_with_default ( s, name, init_val ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__init_val = __skadapter__to_sklib_float(init_val)
    sklib.__sklib__sprite_add_value__sprite__string_ref__float(__skparam__s, __skparam__name, __skparam__init_val)
def sprite_anchor_point ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_anchor_point__sprite(__skparam__s)
    return __skadapter__to_point_2d(__skreturn)
def sprite_anchor_position ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_anchor_position__sprite(__skparam__s)
    return __skadapter__to_point_2d(__skreturn)
def sprite_animation_has_ended ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_animation_has_ended__sprite(__skparam__s)
    return __skadapter__to_bool(__skreturn)
def sprite_animation_name ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_animation_name__sprite(__skparam__s)
    return __skadapter__to_string(__skreturn)
def sprite_at ( s, pt ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__sprite_at__sprite__point_2d_ref(__skparam__s, __skparam__pt)
    return __skadapter__to_bool(__skreturn)
def sprite_bring_layer_forward ( s, visible_layer ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__visible_layer = __skadapter__to_sklib_int(visible_layer)
    sklib.__sklib__sprite_bring_layer_forward__sprite__int(__skparam__s, __skparam__visible_layer)
def sprite_bring_layer_to_front ( s, visible_layer ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__visible_layer = __skadapter__to_sklib_int(visible_layer)
    sklib.__sklib__sprite_bring_layer_to_front__sprite__int(__skparam__s, __skparam__visible_layer)
def sprite_call_on_event ( s, handler ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__handler = __skadapter__to_sklib_sprite_event_handler(handler)
    sklib.__sklib__sprite_call_on_event__sprite__sprite_event_handler_ptr(__skparam__s, __skparam__handler)
def sprite_circle ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_circle__sprite(__skparam__s)
    return __skadapter__to_circle(__skreturn)
def sprite_collision_bitmap ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_collision_bitmap__sprite(__skparam__s)
    return __skadapter__to_bitmap(__skreturn)
def sprite_collision_circle ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_collision_circle__sprite(__skparam__s)
    return __skadapter__to_circle(__skreturn)
def sprite_collision_kind ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_collision_kind__sprite(__skparam__s)
    return __skadapter__to_collision_test_kind(__skreturn)
def sprite_collision_rectangle ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_collision_rectangle__sprite(__skparam__s)
    return __skadapter__to_rectangle(__skreturn)
def sprite_current_cell ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_current_cell__sprite(__skparam__s)
    return __skadapter__to_int(__skreturn)
def sprite_current_cell_rectangle ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_current_cell_rectangle__sprite(__skparam__s)
    return __skadapter__to_rectangle(__skreturn)
def sprite_dx ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_dx__sprite(__skparam__s)
    return __skadapter__to_float(__skreturn)
def sprite_dy ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_dy__sprite(__skparam__s)
    return __skadapter__to_float(__skreturn)
def sprite_has_value ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_has_value__sprite__string(__skparam__s, __skparam__name)
    return __skadapter__to_bool(__skreturn)
def sprite_heading ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_heading__sprite(__skparam__s)
    return __skadapter__to_float(__skreturn)
def sprite_height ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_height__sprite(__skparam__s)
    return __skadapter__to_int(__skreturn)
def sprite_hide_layer_named ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__sprite_hide_layer__sprite__string_ref(__skparam__s, __skparam__name)
def sprite_hide_layer ( s, id ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__id = __skadapter__to_sklib_int(id)
    sklib.__sklib__sprite_hide_layer__sprite__int(__skparam__s, __skparam__id)
def sprite_layer_named ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_layer__sprite__string_ref(__skparam__s, __skparam__name)
    return __skadapter__to_bitmap(__skreturn)
def sprite_layer_at_index ( s, idx ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skreturn = sklib.__sklib__sprite_layer__sprite__int(__skparam__s, __skparam__idx)
    return __skadapter__to_bitmap(__skreturn)
def sprite_layer_circle_named ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_layer_circle__sprite__string_ref(__skparam__s, __skparam__name)
    return __skadapter__to_circle(__skreturn)
def sprite_layer_circle_at_index ( s, idx ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skreturn = sklib.__sklib__sprite_layer_circle__sprite__int(__skparam__s, __skparam__idx)
    return __skadapter__to_circle(__skreturn)
def sprite_layer_count ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_layer_count__sprite(__skparam__s)
    return __skadapter__to_int(__skreturn)
def sprite_layer_height_named ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_layer_height__sprite__string_ref(__skparam__s, __skparam__name)
    return __skadapter__to_int(__skreturn)
def sprite_layer_height ( s, idx ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skreturn = sklib.__sklib__sprite_layer_height__sprite__int(__skparam__s, __skparam__idx)
    return __skadapter__to_int(__skreturn)
def sprite_layer_index ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_layer_index__sprite__string_ref(__skparam__s, __skparam__name)
    return __skadapter__to_int(__skreturn)
def sprite_layer_name ( s, idx ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skreturn = sklib.__sklib__sprite_layer_name__sprite__int(__skparam__s, __skparam__idx)
    return __skadapter__to_string(__skreturn)
def sprite_layer_offset_named ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_layer_offset__sprite__string_ref(__skparam__s, __skparam__name)
    return __skadapter__to_vector_2d(__skreturn)
def sprite_layer_offset ( s, idx ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skreturn = sklib.__sklib__sprite_layer_offset__sprite__int(__skparam__s, __skparam__idx)
    return __skadapter__to_vector_2d(__skreturn)
def sprite_layer_rectangle_named ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_layer_rectangle__sprite__string_ref(__skparam__s, __skparam__name)
    return __skadapter__to_rectangle(__skreturn)
def sprite_layer_rectangle_at_index ( s, idx ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skreturn = sklib.__sklib__sprite_layer_rectangle__sprite__int(__skparam__s, __skparam__idx)
    return __skadapter__to_rectangle(__skreturn)
def sprite_layer_width_named ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_layer_width__sprite__string_ref(__skparam__s, __skparam__name)
    return __skadapter__to_int(__skreturn)
def sprite_layer_width ( s, idx ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skreturn = sklib.__sklib__sprite_layer_width__sprite__int(__skparam__s, __skparam__idx)
    return __skadapter__to_int(__skreturn)
def sprite_location_matrix ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_location_matrix__sprite(__skparam__s)
    return __skadapter__to_matrix_2d(__skreturn)
def sprite_mass ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_mass__sprite(__skparam__s)
    return __skadapter__to_float(__skreturn)
def sprite_move_from_anchor_point ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_move_from_anchor_point__sprite(__skparam__s)
    return __skadapter__to_bool(__skreturn)
def sprite_move_to_taking_seconds ( s, pt, taking_seconds ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__taking_seconds = __skadapter__to_sklib_float(taking_seconds)
    sklib.__sklib__sprite_move_to__sprite__point_2d_ref__float(__skparam__s, __skparam__pt, __skparam__taking_seconds)
def sprite_name ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_name__sprite(__skparam__s)
    return __skadapter__to_string(__skreturn)
def sprite_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_named__string_ref(__skparam__name)
    return __skadapter__to_sprite(__skreturn)
def sprite_offscreen ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_offscreen__sprite(__skparam__s)
    return __skadapter__to_bool(__skreturn)
def sprite_on_screen_at_point ( s, pt ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__sprite_on_screen_at__sprite__point_2d_ref(__skparam__s, __skparam__pt)
    return __skadapter__to_bool(__skreturn)
def sprite_on_screen_at ( s, x, y ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__sprite_on_screen_at__sprite__double__double(__skparam__s, __skparam__x, __skparam__y)
    return __skadapter__to_bool(__skreturn)
def sprite_position ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_position__sprite(__skparam__s)
    return __skadapter__to_point_2d(__skreturn)
def sprite_replay_animation ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    sklib.__sklib__sprite_replay_animation__sprite(__skparam__s)
def sprite_replay_animation_with_sound ( s, with_sound ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__sprite_replay_animation__sprite__bool(__skparam__s, __skparam__with_sound)
def sprite_rotation ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_rotation__sprite(__skparam__s)
    return __skadapter__to_float(__skreturn)
def sprite_scale ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_scale__sprite(__skparam__s)
    return __skadapter__to_float(__skreturn)
def sprite_screen_rectangle ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_screen_rectangle__sprite(__skparam__s)
    return __skadapter__to_rectangle(__skreturn)
def sprite_send_layer_backward ( s, visible_layer ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__visible_layer = __skadapter__to_sklib_int(visible_layer)
    sklib.__sklib__sprite_send_layer_backward__sprite__int(__skparam__s, __skparam__visible_layer)
def sprite_send_layer_to_back ( s, visible_layer ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__visible_layer = __skadapter__to_sklib_int(visible_layer)
    sklib.__sklib__sprite_send_layer_to_back__sprite__int(__skparam__s, __skparam__visible_layer)
def sprite_set_anchor_point ( s, pt ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    sklib.__sklib__sprite_set_anchor_point__sprite__point_2d_ref(__skparam__s, __skparam__pt)
def sprite_set_collision_bitmap ( s, bmp ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    sklib.__sklib__sprite_set_collision_bitmap__sprite__bitmap(__skparam__s, __skparam__bmp)
def sprite_set_collision_kind ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_collision_test_kind(value)
    sklib.__sklib__sprite_set_collision_kind__sprite__collision_test_kind(__skparam__s, __skparam__value)
def sprite_set_dx ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_float(value)
    sklib.__sklib__sprite_set_dx__sprite__float(__skparam__s, __skparam__value)
def sprite_set_dy ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_float(value)
    sklib.__sklib__sprite_set_dy__sprite__float(__skparam__s, __skparam__value)
def sprite_set_heading ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_float(value)
    sklib.__sklib__sprite_set_heading__sprite__float(__skparam__s, __skparam__value)
def sprite_set_layer_offset_named ( s, name, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__value = __skadapter__to_sklib_vector_2d(value)
    sklib.__sklib__sprite_set_layer_offset__sprite__string_ref__vector_2d_ref(__skparam__s, __skparam__name, __skparam__value)
def sprite_set_layer_offset_at_index ( s, idx, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skparam__value = __skadapter__to_sklib_vector_2d(value)
    sklib.__sklib__sprite_set_layer_offset__sprite__int__vector_2d_ref(__skparam__s, __skparam__idx, __skparam__value)
def sprite_set_mass ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_float(value)
    sklib.__sklib__sprite_set_mass__sprite__float(__skparam__s, __skparam__value)
def sprite_set_move_from_anchor_point ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_bool(value)
    sklib.__sklib__sprite_set_move_from_anchor_point__sprite__bool(__skparam__s, __skparam__value)
def sprite_set_position ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_point_2d(value)
    sklib.__sklib__sprite_set_position__sprite__point_2d_ref(__skparam__s, __skparam__value)
def sprite_set_rotation ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_float(value)
    sklib.__sklib__sprite_set_rotation__sprite__float(__skparam__s, __skparam__value)
def sprite_set_scale ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_float(value)
    sklib.__sklib__sprite_set_scale__sprite__float(__skparam__s, __skparam__value)
def sprite_set_speed ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_float(value)
    sklib.__sklib__sprite_set_speed__sprite__float(__skparam__s, __skparam__value)
def sprite_set_value_named ( s, name, val ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__val = __skadapter__to_sklib_float(val)
    sklib.__sklib__sprite_set_value__sprite__string_ref__float(__skparam__s, __skparam__name, __skparam__val)
def sprite_set_velocity ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_vector_2d(value)
    sklib.__sklib__sprite_set_velocity__sprite__vector_2d_ref(__skparam__s, __skparam__value)
def sprite_set_x ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_float(value)
    sklib.__sklib__sprite_set_x__sprite__float(__skparam__s, __skparam__value)
def sprite_set_y ( s, value ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__value = __skadapter__to_sklib_float(value)
    sklib.__sklib__sprite_set_y__sprite__float(__skparam__s, __skparam__value)
def sprite_show_layer_named ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_show_layer__sprite__string_ref(__skparam__s, __skparam__name)
    return __skadapter__to_int(__skreturn)
def sprite_show_layer ( s, id ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__id = __skadapter__to_sklib_int(id)
    __skreturn = sklib.__sklib__sprite_show_layer__sprite__int(__skparam__s, __skparam__id)
    return __skadapter__to_int(__skreturn)
def sprite_speed ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_speed__sprite(__skparam__s)
    return __skadapter__to_float(__skreturn)
def sprite_start_animation_named ( s, named ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__named = __skadapter__to_sklib_string(named)
    sklib.__sklib__sprite_start_animation__sprite__string_ref(__skparam__s, __skparam__named)
def sprite_start_animation_named_with_sound ( s, named, with_sound ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__named = __skadapter__to_sklib_string(named)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__sprite_start_animation__sprite__string_ref__bool(__skparam__s, __skparam__named, __skparam__with_sound)
def sprite_start_animation ( s, idx ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    sklib.__sklib__sprite_start_animation__sprite__int(__skparam__s, __skparam__idx)
def sprite_start_animation_with_sound ( s, idx, with_sound ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__sprite_start_animation__sprite__int__bool(__skparam__s, __skparam__idx, __skparam__with_sound)
def sprite_stop_calling_on_event ( s, handler ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__handler = __skadapter__to_sklib_sprite_event_handler(handler)
    sklib.__sklib__sprite_stop_calling_on_event__sprite__sprite_event_handler_ptr(__skparam__s, __skparam__handler)
def sprite_toggle_layer_visible_named ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__sprite_toggle_layer_visible__sprite__string_ref(__skparam__s, __skparam__name)
def sprite_toggle_layer_visible ( s, id ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__id = __skadapter__to_sklib_int(id)
    sklib.__sklib__sprite_toggle_layer_visible__sprite__int(__skparam__s, __skparam__id)
def sprite_value ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_value__sprite__string_ref(__skparam__s, __skparam__name)
    return __skadapter__to_float(__skreturn)
def sprite_value_count ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_value_count__sprite(__skparam__s)
    return __skadapter__to_int(__skreturn)
def sprite_velocity ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_velocity__sprite(__skparam__s)
    return __skadapter__to_vector_2d(__skreturn)
def sprite_visible_index_of_layer_named ( s, name ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__sprite_visible_index_of_layer__sprite__string_ref(__skparam__s, __skparam__name)
    return __skadapter__to_int(__skreturn)
def sprite_visible_index_of_layer ( s, id ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__id = __skadapter__to_sklib_int(id)
    __skreturn = sklib.__sklib__sprite_visible_index_of_layer__sprite__int(__skparam__s, __skparam__id)
    return __skadapter__to_int(__skreturn)
def sprite_visible_layer ( s, idx ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skreturn = sklib.__sklib__sprite_visible_layer__sprite__int(__skparam__s, __skparam__idx)
    return __skadapter__to_int(__skreturn)
def sprite_visible_layer_count ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_visible_layer_count__sprite(__skparam__s)
    return __skadapter__to_int(__skreturn)
def sprite_visible_layer_id ( s, idx ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__idx = __skadapter__to_sklib_int(idx)
    __skreturn = sklib.__sklib__sprite_visible_layer_id__sprite__int(__skparam__s, __skparam__idx)
    return __skadapter__to_int(__skreturn)
def sprite_width ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_width__sprite(__skparam__s)
    return __skadapter__to_int(__skreturn)
def sprite_x ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_x__sprite(__skparam__s)
    return __skadapter__to_float(__skreturn)
def sprite_y ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skreturn = sklib.__sklib__sprite_y__sprite(__skparam__s)
    return __skadapter__to_float(__skreturn)
def stop_calling_on_sprite_event ( handler ):
    __skparam__handler = __skadapter__to_sklib_sprite_event_handler(handler)
    sklib.__sklib__stop_calling_on_sprite_event__sprite_event_handler_ptr(__skparam__handler)
def update_all_sprites (  ):
    sklib.__sklib__update_all_sprites()
def update_all_sprites_percent ( pct ):
    __skparam__pct = __skadapter__to_sklib_float(pct)
    sklib.__sklib__update_all_sprites__float(__skparam__pct)
def update_sprite ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    sklib.__sklib__update_sprite__sprite(__skparam__s)
def update_sprite_with_sound ( s, with_sound ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__update_sprite__sprite__bool(__skparam__s, __skparam__with_sound)
def update_sprite_percent ( s, pct ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__pct = __skadapter__to_sklib_float(pct)
    sklib.__sklib__update_sprite__sprite__float(__skparam__s, __skparam__pct)
def update_sprite_percent_with_sound ( s, pct, with_sound ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__pct = __skadapter__to_sklib_float(pct)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__update_sprite__sprite__float__bool(__skparam__s, __skparam__pct, __skparam__with_sound)
def update_sprite_animation ( s ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    sklib.__sklib__update_sprite_animation__sprite(__skparam__s)
def update_sprite_animation_with_sound ( s, with_sound ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__update_sprite_animation__sprite__bool(__skparam__s, __skparam__with_sound)
def update_sprite_animation_percent ( s, pct ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__pct = __skadapter__to_sklib_float(pct)
    sklib.__sklib__update_sprite_animation__sprite__float(__skparam__s, __skparam__pct)
def update_sprite_animation_percent_with_sound ( s, pct, with_sound ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__pct = __skadapter__to_sklib_float(pct)
    __skparam__with_sound = __skadapter__to_sklib_bool(with_sound)
    sklib.__sklib__update_sprite_animation__sprite__float__bool(__skparam__s, __skparam__pct, __skparam__with_sound)
def vector_from_center_sprite_to_point_point ( s, pt ):
    __skparam__s = __skadapter__to_sklib_sprite(s)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__vector_from_center_sprite_to_point__sprite__point_2d_ref(__skparam__s, __skparam__pt)
    return __skadapter__to_vector_2d(__skreturn)
def vector_from_to ( s1, s2 ):
    __skparam__s1 = __skadapter__to_sklib_sprite(s1)
    __skparam__s2 = __skadapter__to_sklib_sprite(s2)
    __skreturn = sklib.__sklib__vector_from_to__sprite__sprite(__skparam__s1, __skparam__s2)
    return __skadapter__to_vector_2d(__skreturn)
def read_char (  ):
    __skreturn = sklib.__sklib__read_char()
    return __skadapter__to_char(__skreturn)
def read_line (  ):
    __skreturn = sklib.__sklib__read_line()
    return __skadapter__to_string(__skreturn)
def terminal_has_input (  ):
    __skreturn = sklib.__sklib__terminal_has_input()
    return __skadapter__to_bool(__skreturn)
def write_char ( data ):
    __skparam__data = __skadapter__to_sklib_char(data)
    sklib.__sklib__write__char(__skparam__data)
def write_double ( data ):
    __skparam__data = __skadapter__to_sklib_double(data)
    sklib.__sklib__write__double(__skparam__data)
def write_int ( data ):
    __skparam__data = __skadapter__to_sklib_int(data)
    sklib.__sklib__write__int(__skparam__data)
def write ( text ):
    __skparam__text = __skadapter__to_sklib_string(text)
    sklib.__sklib__write__string(__skparam__text)
def write_line_char ( data ):
    __skparam__data = __skadapter__to_sklib_char(data)
    sklib.__sklib__write_line__char(__skparam__data)
def write_line_empty (  ):
    sklib.__sklib__write_line()
def write_line_double ( data ):
    __skparam__data = __skadapter__to_sklib_double(data)
    sklib.__sklib__write_line__double(__skparam__data)
def write_line_int ( data ):
    __skparam__data = __skadapter__to_sklib_int(data)
    sklib.__sklib__write_line__int(__skparam__data)
def write_line ( line ):
    __skparam__line = __skadapter__to_sklib_string(line)
    sklib.__sklib__write_line__string(__skparam__line)
def draw_text_font_as_string ( text, clr, fnt, font_size, x, y ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_string(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_text__string_ref__color_ref__string_ref__int__double__double(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y)
def draw_text_with_options_font_as_string ( text, clr, fnt, font_size, x, y, opts ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_string(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_text__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts)
def draw_text_no_font_no_size ( text, clr, x, y ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_text__string_ref__color_ref__double__double(__skparam__text, __skparam__clr, __skparam__x, __skparam__y)
def draw_text_no_font_no_size_with_options ( text, clr, x, y, opts ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_text__string_ref__color_ref__double__double__drawing_options_ref(__skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts)
def draw_text ( text, clr, fnt, font_size, x, y ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_text__string_ref__color_ref__font__int__double__double(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y)
def draw_text_with_options ( text, clr, fnt, font_size, x, y, opts ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_text__string_ref__color_ref__font__int__double__double__drawing_options_ref(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts)
def draw_text_on_bitmap_font_as_string ( bmp, text, clr, fnt, font_size, x, y ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_string(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y)
def draw_text_on_bitmap_with_options_font_as_string ( bmp, text, clr, fnt, font_size, x, y, opts ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_string(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts)
def draw_text_on_bitmap_no_font_no_size ( bmp, text, clr, x, y ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__x, __skparam__y)
def draw_text_on_bitmap_no_font_no_size_with_options ( bmp, text, clr, x, y, opts ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double__drawing_options_ref(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts)
def draw_text_on_bitmap ( bmp, text, clr, fnt, font_size, x, y ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y)
def draw_text_on_bitmap_with_options ( bmp, text, clr, fnt, font_size, x, y, opts ):
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double__drawing_options_ref(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts)
def draw_text_on_window_font_as_string ( wnd, text, clr, fnt, font_size, x, y ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_string(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y)
def draw_text_on_window_with_options_font_as_string ( wnd, text, clr, fnt, font_size, x, y, opts ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_string(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts)
def draw_text_on_window_no_font_no_size ( wnd, text, clr, x, y ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__double__double(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__x, __skparam__y)
def draw_text_on_window_no_font_no_size_with_options ( wnd, text, clr, x, y, opts ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__double__double__drawing_options_ref(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts)
def draw_text_on_window ( wnd, text, clr, fnt, font_size, x, y ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y)
def draw_text_on_window_with_options ( wnd, text, clr, fnt, font_size, x, y, opts ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double__drawing_options_ref(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts)
def font_has_size_name_as_string ( name, font_size ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skreturn = sklib.__sklib__font_has_size__string_ref__int(__skparam__name, __skparam__font_size)
    return __skadapter__to_bool(__skreturn)
def font_has_size ( fnt, font_size ):
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skreturn = sklib.__sklib__font_has_size__font__int(__skparam__fnt, __skparam__font_size)
    return __skadapter__to_bool(__skreturn)
def font_load_size_name_as_string ( name, font_size ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    sklib.__sklib__font_load_size__string_ref__int(__skparam__name, __skparam__font_size)
def font_load_size ( fnt, font_size ):
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    sklib.__sklib__font_load_size__font__int(__skparam__fnt, __skparam__font_size)
def font_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__font_named__string(__skparam__name)
    return __skadapter__to_font(__skreturn)
def free_all_fonts (  ):
    sklib.__sklib__free_all_fonts()
def free_font ( fnt ):
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    sklib.__sklib__free_font__font(__skparam__fnt)
def get_font_style_name_as_string ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__get_font_style__string_ref(__skparam__name)
    return __skadapter__to_font_style(__skreturn)
def get_font_style ( fnt ):
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skreturn = sklib.__sklib__get_font_style__font(__skparam__fnt)
    return __skadapter__to_font_style(__skreturn)
def get_system_font (  ):
    __skreturn = sklib.__sklib__get_system_font()
    return __skadapter__to_font(__skreturn)
def has_font ( fnt ):
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skreturn = sklib.__sklib__has_font__font(__skparam__fnt)
    return __skadapter__to_bool(__skreturn)
def has_font_name_as_string ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_font__string(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def load_font ( name, filename ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__filename = __skadapter__to_sklib_string(filename)
    __skreturn = sklib.__sklib__load_font__string_ref__string_ref(__skparam__name, __skparam__filename)
    return __skadapter__to_font(__skreturn)
def set_font_style_name_as_string ( name, style ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__style = __skadapter__to_sklib_font_style(style)
    sklib.__sklib__set_font_style__string_ref__font_style(__skparam__name, __skparam__style)
def set_font_style ( fnt, style ):
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__style = __skadapter__to_sklib_font_style(style)
    sklib.__sklib__set_font_style__font__font_style(__skparam__fnt, __skparam__style)
def text_height_font_named ( text, fnt, font_size ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__fnt = __skadapter__to_sklib_string(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skreturn = sklib.__sklib__text_height__string_ref__string_ref__int(__skparam__text, __skparam__fnt, __skparam__font_size)
    return __skadapter__to_int(__skreturn)
def text_height ( text, fnt, font_size ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skreturn = sklib.__sklib__text_height__string_ref__font__int(__skparam__text, __skparam__fnt, __skparam__font_size)
    return __skadapter__to_int(__skreturn)
def text_width_font_named ( text, fnt, font_size ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__fnt = __skadapter__to_sklib_string(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skreturn = sklib.__sklib__text_width__string_ref__string_ref__int(__skparam__text, __skparam__fnt, __skparam__font_size)
    return __skadapter__to_int(__skreturn)
def text_width ( text, fnt, font_size ):
    __skparam__text = __skadapter__to_sklib_string(text)
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skreturn = sklib.__sklib__text_width__string_ref__font__int(__skparam__text, __skparam__fnt, __skparam__font_size)
    return __skadapter__to_int(__skreturn)
def draw_collected_text ( clr, fnt, font_size, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__fnt = __skadapter__to_sklib_font(fnt)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_collected_text__color__font__int__drawing_options_ref(__skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__opts)
def end_reading_text (  ):
    sklib.__sklib__end_reading_text()
def end_reading_text_in_window ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    sklib.__sklib__end_reading_text__window(__skparam__wind)
def reading_text (  ):
    __skreturn = sklib.__sklib__reading_text()
    return __skadapter__to_bool(__skreturn)
def reading_text_in_window ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skreturn = sklib.__sklib__reading_text__window(__skparam__wind)
    return __skadapter__to_bool(__skreturn)
def start_reading_text ( rect ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__start_reading_text__rectangle(__skparam__rect)
def start_reading_text_with_initial_text ( rect, initial_text ):
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__initial_text = __skadapter__to_sklib_string(initial_text)
    sklib.__sklib__start_reading_text__rectangle__string(__skparam__rect, __skparam__initial_text)
def start_reading_text_in_window ( wind, rect ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    sklib.__sklib__start_reading_text__window__rectangle(__skparam__wind, __skparam__rect)
def start_reading_text_in_window_with_initial_text ( wind, rect, initial_text ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__initial_text = __skadapter__to_sklib_string(initial_text)
    sklib.__sklib__start_reading_text__window__rectangle__string(__skparam__wind, __skparam__rect, __skparam__initial_text)
def text_entry_cancelled (  ):
    __skreturn = sklib.__sklib__text_entry_cancelled()
    return __skadapter__to_bool(__skreturn)
def text_entry_cancelled_in_window ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skreturn = sklib.__sklib__text_entry_cancelled__window(__skparam__wind)
    return __skadapter__to_bool(__skreturn)
def text_input (  ):
    __skreturn = sklib.__sklib__text_input()
    return __skadapter__to_string(__skreturn)
def text_input_in_window ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skreturn = sklib.__sklib__text_input__window(__skparam__wind)
    return __skadapter__to_string(__skreturn)
def create_timer ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__create_timer__string(__skparam__name)
    return __skadapter__to_timer(__skreturn)
def free_all_timers (  ):
    sklib.__sklib__free_all_timers()
def free_timer ( to_free ):
    __skparam__to_free = __skadapter__to_sklib_timer(to_free)
    sklib.__sklib__free_timer__timer(__skparam__to_free)
def has_timer__named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__has_timer__string(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def pause_timer__named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__pause_timer__string(__skparam__name)
def pause_timer ( to_pause ):
    __skparam__to_pause = __skadapter__to_sklib_timer(to_pause)
    sklib.__sklib__pause_timer__timer(__skparam__to_pause)
def reset_timer__named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__reset_timer__string(__skparam__name)
def reset_timer ( tmr ):
    __skparam__tmr = __skadapter__to_sklib_timer(tmr)
    sklib.__sklib__reset_timer__timer(__skparam__tmr)
def resume_timer__named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__resume_timer__string(__skparam__name)
def resume_timer ( to_resume ):
    __skparam__to_resume = __skadapter__to_sklib_timer(to_resume)
    sklib.__sklib__resume_timer__timer(__skparam__to_resume)
def start_timer__named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__start_timer__string(__skparam__name)
def start_timer ( to_start ):
    __skparam__to_start = __skadapter__to_sklib_timer(to_start)
    sklib.__sklib__start_timer__timer(__skparam__to_start)
def stop_timer__named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__stop_timer__string(__skparam__name)
def stop_timer ( to_stop ):
    __skparam__to_stop = __skadapter__to_sklib_timer(to_stop)
    sklib.__sklib__stop_timer__timer(__skparam__to_stop)
def timer_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__timer_named__string(__skparam__name)
    return __skadapter__to_timer(__skreturn)
def timer_paused__named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__timer_paused__string(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def timer_paused ( to_get ):
    __skparam__to_get = __skadapter__to_sklib_timer(to_get)
    __skreturn = sklib.__sklib__timer_paused__timer(__skparam__to_get)
    return __skadapter__to_bool(__skreturn)
def timer_started__named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__timer_started__string(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def timer_started ( to_get ):
    __skparam__to_get = __skadapter__to_sklib_timer(to_get)
    __skreturn = sklib.__sklib__timer_started__timer(__skparam__to_get)
    return __skadapter__to_bool(__skreturn)
def timer_ticks__named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__timer_ticks__string(__skparam__name)
    return __skadapter__to_unsigned_int(__skreturn)
def timer_ticks ( to_get ):
    __skparam__to_get = __skadapter__to_sklib_timer(to_get)
    __skreturn = sklib.__sklib__timer_ticks__timer(__skparam__to_get)
    return __skadapter__to_unsigned_int(__skreturn)
def draw_triangle_record ( clr, tri ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    sklib.__sklib__draw_triangle__color__triangle_ref(__skparam__clr, __skparam__tri)
def draw_triangle_record_with_options ( clr, tri, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_triangle__color__triangle_ref__drawing_options(__skparam__clr, __skparam__tri, __skparam__opts)
def draw_triangle ( clr, x1, y1, x2, y2, x3, y3 ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    sklib.__sklib__draw_triangle__color__double__double__double__double__double__double(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3)
def draw_triangle_with_options ( clr, x1, y1, x2, y2, x3, y3, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_triangle__color__double__double__double__double__double__double__drawing_options(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts)
def draw_triangle_on_bitmap_record ( destination, clr, tri ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri)
def draw_triangle_on_bitmap_record_with_options ( destination, clr, tri, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts)
def draw_triangle_on_bitmap ( destination, clr, x1, y1, x2, y2, x3, y3 ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3)
def draw_triangle_on_bitmap_with_options ( destination, clr, x1, y1, x2, y2, x3, y3, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts)
def draw_triangle_on_window_record ( destination, clr, tri ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    sklib.__sklib__draw_triangle_on_window__window__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri)
def draw_triangle_on_window_record_with_options ( destination, clr, tri, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_triangle_on_window__window__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts)
def draw_triangle_on_window ( destination, clr, x1, y1, x2, y2, x3, y3 ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    sklib.__sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3)
def draw_triangle_on_window_with_options ( destination, clr, x1, y1, x2, y2, x3, y3, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts)
def fill_triangle_record ( clr, tri ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    sklib.__sklib__fill_triangle__color__triangle_ref(__skparam__clr, __skparam__tri)
def fill_triangle_record_with_options ( clr, tri, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_triangle__color__triangle_ref__drawing_options(__skparam__clr, __skparam__tri, __skparam__opts)
def fill_triangle ( clr, x1, y1, x2, y2, x3, y3 ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    sklib.__sklib__fill_triangle__color__double__double__double__double__double__double(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3)
def fill_triangle_with_options ( clr, x1, y1, x2, y2, x3, y3, opts ):
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_triangle__color__double__double__double__double__double__double__drawing_options(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts)
def fill_triangle_on_bitmap_record ( destination, clr, tri ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri)
def fill_triangle_on_bitmap_record_with_options ( destination, clr, tri, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts)
def fill_triangle_on_bitmap ( destination, clr, x1, y1, x2, y2, x3, y3 ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3)
def fill_triangle_on_bitmap_with_options ( destination, clr, x1, y1, x2, y2, x3, y3, opts ):
    __skparam__destination = __skadapter__to_sklib_bitmap(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts)
def fill_triangle_on_window_record ( destination, clr, tri ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    sklib.__sklib__fill_triangle_on_window__window__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri)
def fill_triangle_on_window_record_with_options ( destination, clr, tri, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_triangle_on_window__window__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts)
def fill_triangle_on_window ( destination, clr, x1, y1, x2, y2, x3, y3 ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    sklib.__sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3)
def fill_triangle_on_window_with_options ( destination, clr, x1, y1, x2, y2, x3, y3, opts ):
    __skparam__destination = __skadapter__to_sklib_window(destination)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    __skparam__opts = __skadapter__to_sklib_drawing_options(opts)
    sklib.__sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts)
def triangle_barycenter ( tri ):
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skreturn = sklib.__sklib__triangle_barycenter__triangle_ref(__skparam__tri)
    return __skadapter__to_point_2d(__skreturn)
def triangle_from ( p1, p2, p3 ):
    __skparam__p1 = __skadapter__to_sklib_point_2d(p1)
    __skparam__p2 = __skadapter__to_sklib_point_2d(p2)
    __skparam__p3 = __skadapter__to_sklib_point_2d(p3)
    __skreturn = sklib.__sklib__triangle_from__point_2d_ref__point_2d_ref__point_2d_ref(__skparam__p1, __skparam__p2, __skparam__p3)
    return __skadapter__to_triangle(__skreturn)
def triangle_from__from_coordinates ( x1, y1, x2, y2, x3, y3 ):
    __skparam__x1 = __skadapter__to_sklib_double(x1)
    __skparam__y1 = __skadapter__to_sklib_double(y1)
    __skparam__x2 = __skadapter__to_sklib_double(x2)
    __skparam__y2 = __skadapter__to_sklib_double(y2)
    __skparam__x3 = __skadapter__to_sklib_double(x3)
    __skparam__y3 = __skadapter__to_sklib_double(y3)
    __skreturn = sklib.__sklib__triangle_from__double__double__double__double__double__double(__skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3)
    return __skadapter__to_triangle(__skreturn)
def triangle_rectangle_intersect ( tri, rect ):
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__triangle_rectangle_intersect__triangle_ref__rectangle_ref(__skparam__tri, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def triangle_to_string ( tri ):
    __skparam__tri = __skadapter__to_sklib_triangle(tri)
    __skreturn = sklib.__sklib__triangle_to_string__triangle_ref(__skparam__tri)
    return __skadapter__to_string(__skreturn)
def triangles_intersect ( t1, t2 ):
    __skparam__t1 = __skadapter__to_sklib_triangle(t1)
    __skparam__t2 = __skadapter__to_sklib_triangle(t2)
    __skreturn = sklib.__sklib__triangles_intersect__triangle_ref__triangle_ref(__skparam__t1, __skparam__t2)
    return __skadapter__to_bool(__skreturn)
def current_ticks (  ):
    __skreturn = sklib.__sklib__current_ticks()
    return __skadapter__to_unsigned_int(__skreturn)
def delay ( milliseconds ):
    __skparam__milliseconds = __skadapter__to_sklib_int(milliseconds)
    sklib.__sklib__delay__int(__skparam__milliseconds)
def display_dialog ( title, msg, output_font, font_size ):
    __skparam__title = __skadapter__to_sklib_string(title)
    __skparam__msg = __skadapter__to_sklib_string(msg)
    __skparam__output_font = __skadapter__to_sklib_font(output_font)
    __skparam__font_size = __skadapter__to_sklib_int(font_size)
    sklib.__sklib__display_dialog__string_ref__string_ref__font__int(__skparam__title, __skparam__msg, __skparam__output_font, __skparam__font_size)
def file_as_string ( filename, kind ):
    __skparam__filename = __skadapter__to_sklib_string(filename)
    __skparam__kind = __skadapter__to_sklib_resource_kind(kind)
    __skreturn = sklib.__sklib__file_as_string__string__resource_kind(__skparam__filename, __skparam__kind)
    return __skadapter__to_string(__skreturn)
def angle_between ( v1, v2 ):
    __skparam__v1 = __skadapter__to_sklib_vector_2d(v1)
    __skparam__v2 = __skadapter__to_sklib_vector_2d(v2)
    __skreturn = sklib.__sklib__angle_between__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2)
    return __skadapter__to_double(__skreturn)
def dot_product ( v1, v2 ):
    __skparam__v1 = __skadapter__to_sklib_vector_2d(v1)
    __skparam__v2 = __skadapter__to_sklib_vector_2d(v2)
    __skreturn = sklib.__sklib__dot_product__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2)
    return __skadapter__to_double(__skreturn)
def is_zero_vector ( v ):
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skreturn = sklib.__sklib__is_zero_vector__vector_2d_ref(__skparam__v)
    return __skadapter__to_bool(__skreturn)
def ray_intersection_point ( from_pt, heading, l, pt ):
    __skparam__from_pt = __skadapter__to_sklib_point_2d(from_pt)
    __skparam__heading = __skadapter__to_sklib_vector_2d(heading)
    __skparam__l = __skadapter__to_sklib_line(l)
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skreturn = sklib.__sklib__ray_intersection_point__point_2d_ref__vector_2d_ref__line_ref__point_2d_ref(__skparam__from_pt, __skparam__heading, __skparam__l, byref(__skparam__pt))
    pt = __skadapter__to_point_2d(__skparam__pt)
    return __skadapter__to_bool(__skreturn)
def unit_vector ( v ):
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skreturn = sklib.__sklib__unit_vector__vector_2d_ref(__skparam__v)
    return __skadapter__to_vector_2d(__skreturn)
def vector_add ( v1, v2 ):
    __skparam__v1 = __skadapter__to_sklib_vector_2d(v1)
    __skparam__v2 = __skadapter__to_sklib_vector_2d(v2)
    __skreturn = sklib.__sklib__vector_add__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2)
    return __skadapter__to_vector_2d(__skreturn)
def vector_angle ( v ):
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skreturn = sklib.__sklib__vector_angle__vector_2d(__skparam__v)
    return __skadapter__to_double(__skreturn)
def vector_from_angle ( angle, magnitude ):
    __skparam__angle = __skadapter__to_sklib_double(angle)
    __skparam__magnitude = __skadapter__to_sklib_double(magnitude)
    __skreturn = sklib.__sklib__vector_from_angle__double__double(__skparam__angle, __skparam__magnitude)
    return __skadapter__to_vector_2d(__skreturn)
def vector_from_line ( l ):
    __skparam__l = __skadapter__to_sklib_line(l)
    __skreturn = sklib.__sklib__vector_from_line__line_ref(__skparam__l)
    return __skadapter__to_vector_2d(__skreturn)
def vector_from_point_to_rect ( pt, rect ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__vector_from_point_to_rect__point_2d_ref__rectangle_ref(__skparam__pt, __skparam__rect)
    return __skadapter__to_vector_2d(__skreturn)
def vector_in_rect ( v, rect ):
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skreturn = sklib.__sklib__vector_in_rect__vector_2d_ref__rectangle_ref(__skparam__v, __skparam__rect)
    return __skadapter__to_bool(__skreturn)
def vector_invert ( v ):
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skreturn = sklib.__sklib__vector_invert__vector_2d_ref(__skparam__v)
    return __skadapter__to_vector_2d(__skreturn)
def vector_limit ( v, limit ):
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skparam__limit = __skadapter__to_sklib_double(limit)
    __skreturn = sklib.__sklib__vector_limit__vector_2d_ref__double(__skparam__v, __skparam__limit)
    return __skadapter__to_vector_2d(__skreturn)
def vector_magnitude ( v ):
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skreturn = sklib.__sklib__vector_magnitude__vector_2d_ref(__skparam__v)
    return __skadapter__to_double(__skreturn)
def vector_magnitude_squared ( v ):
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skreturn = sklib.__sklib__vector_magnitude_squared__vector_2d_ref(__skparam__v)
    return __skadapter__to_double(__skreturn)
def vector_multiply ( v1, s ):
    __skparam__v1 = __skadapter__to_sklib_vector_2d(v1)
    __skparam__s = __skadapter__to_sklib_double(s)
    __skreturn = sklib.__sklib__vector_multiply__vector_2d_ref__double(__skparam__v1, __skparam__s)
    return __skadapter__to_vector_2d(__skreturn)
def vector_normal ( v ):
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skreturn = sklib.__sklib__vector_normal__vector_2d_ref(__skparam__v)
    return __skadapter__to_vector_2d(__skreturn)
def vector_out_of_circle_from_circle ( src, bounds, velocity ):
    __skparam__src = __skadapter__to_sklib_circle(src)
    __skparam__bounds = __skadapter__to_sklib_circle(bounds)
    __skparam__velocity = __skadapter__to_sklib_vector_2d(velocity)
    __skreturn = sklib.__sklib__vector_out_of_circle_from_circle__circle_ref__circle_ref__vector_2d_ref(__skparam__src, __skparam__bounds, __skparam__velocity)
    return __skadapter__to_vector_2d(__skreturn)
def vector_out_of_circle_from_point ( pt, c, velocity ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__velocity = __skadapter__to_sklib_vector_2d(velocity)
    __skreturn = sklib.__sklib__vector_out_of_circle_from_point__point_2d_ref__circle_ref__vector_2d_ref(__skparam__pt, __skparam__c, __skparam__velocity)
    return __skadapter__to_vector_2d(__skreturn)
def vector_out_of_rect_from_circle ( c, rect, velocity ):
    __skparam__c = __skadapter__to_sklib_circle(c)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__velocity = __skadapter__to_sklib_vector_2d(velocity)
    __skreturn = sklib.__sklib__vector_out_of_rect_from_circle__circle_ref__rectangle_ref__vector_2d_ref(__skparam__c, __skparam__rect, __skparam__velocity)
    return __skadapter__to_vector_2d(__skreturn)
def vector_out_of_rect_from_point ( pt, rect, velocity ):
    __skparam__pt = __skadapter__to_sklib_point_2d(pt)
    __skparam__rect = __skadapter__to_sklib_rectangle(rect)
    __skparam__velocity = __skadapter__to_sklib_vector_2d(velocity)
    __skreturn = sklib.__sklib__vector_out_of_rect_from_point__point_2d_ref__rectangle_ref__vector_2d_ref(__skparam__pt, __skparam__rect, __skparam__velocity)
    return __skadapter__to_vector_2d(__skreturn)
def vector_out_of_rect_from_rect ( src, bounds, velocity ):
    __skparam__src = __skadapter__to_sklib_rectangle(src)
    __skparam__bounds = __skadapter__to_sklib_rectangle(bounds)
    __skparam__velocity = __skadapter__to_sklib_vector_2d(velocity)
    __skreturn = sklib.__sklib__vector_out_of_rect_from_rect__rectangle_ref__rectangle_ref__vector_2d_ref(__skparam__src, __skparam__bounds, __skparam__velocity)
    return __skadapter__to_vector_2d(__skreturn)
def vector_point_to_point ( start, end_pt ):
    __skparam__start = __skadapter__to_sklib_point_2d(start)
    __skparam__end_pt = __skadapter__to_sklib_point_2d(end_pt)
    __skreturn = sklib.__sklib__vector_point_to_point__point_2d_ref__point_2d_ref(__skparam__start, __skparam__end_pt)
    return __skadapter__to_vector_2d(__skreturn)
def vector_subtract ( v1, v2 ):
    __skparam__v1 = __skadapter__to_sklib_vector_2d(v1)
    __skparam__v2 = __skadapter__to_sklib_vector_2d(v2)
    __skreturn = sklib.__sklib__vector_subtract__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2)
    return __skadapter__to_vector_2d(__skreturn)
def vector_to_point ( p1 ):
    __skparam__p1 = __skadapter__to_sklib_point_2d(p1)
    __skreturn = sklib.__sklib__vector_to__point_2d_ref(__skparam__p1)
    return __skadapter__to_vector_2d(__skreturn)
def vector_to ( x, y ):
    __skparam__x = __skadapter__to_sklib_double(x)
    __skparam__y = __skadapter__to_sklib_double(y)
    __skreturn = sklib.__sklib__vector_to__double__double(__skparam__x, __skparam__y)
    return __skadapter__to_vector_2d(__skreturn)
def vector_to_string ( v ):
    __skparam__v = __skadapter__to_sklib_vector_2d(v)
    __skreturn = sklib.__sklib__vector_to_string__vector_2d_ref(__skparam__v)
    return __skadapter__to_string(__skreturn)
def vectors_equal ( v1, v2 ):
    __skparam__v1 = __skadapter__to_sklib_vector_2d(v1)
    __skparam__v2 = __skadapter__to_sklib_vector_2d(v2)
    __skreturn = sklib.__sklib__vectors_equal__vector_2d_ref__vector_2d(__skparam__v1, __skparam__v2)
    return __skadapter__to_bool(__skreturn)
def vectors_not_equal ( v1, v2 ):
    __skparam__v1 = __skadapter__to_sklib_vector_2d(v1)
    __skparam__v2 = __skadapter__to_sklib_vector_2d(v2)
    __skreturn = sklib.__sklib__vectors_not_equal__vector_2d_ref__vector_2d(__skparam__v1, __skparam__v2)
    return __skadapter__to_bool(__skreturn)
def download_bitmap ( name, url, port ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__url = __skadapter__to_sklib_string(url)
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skreturn = sklib.__sklib__download_bitmap__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port)
    return __skadapter__to_bitmap(__skreturn)
def download_font ( name, url, port ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__url = __skadapter__to_sklib_string(url)
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skreturn = sklib.__sklib__download_font__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port)
    return __skadapter__to_font(__skreturn)
def download_music ( name, url, port ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__url = __skadapter__to_sklib_string(url)
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skreturn = sklib.__sklib__download_music__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port)
    return __skadapter__to_music(__skreturn)
def download_sound_effect ( name, url, port ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__url = __skadapter__to_sklib_string(url)
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skreturn = sklib.__sklib__download_sound_effect__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port)
    return __skadapter__to_sound_effect(__skreturn)
def free_response ( response ):
    __skparam__response = __skadapter__to_sklib_http_response(response)
    sklib.__sklib__free_response__http_response(__skparam__response)
def http_get ( url, port ):
    __skparam__url = __skadapter__to_sklib_string(url)
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skreturn = sklib.__sklib__http_get__string_ref__unsigned_short(__skparam__url, __skparam__port)
    return __skadapter__to_http_response(__skreturn)
def http_post_with_headers ( url, port, body, headers ):
    __skparam__url = __skadapter__to_sklib_string(url)
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skparam__body = __skadapter__to_sklib_string(body)
    __skparam__headers = __skadapter__to_sklib_vector_string(headers)
    __skreturn = sklib.__sklib__http_post__string_ref__unsigned_short__string_ref__vector_string_ref(__skparam__url, __skparam__port, __skparam__body, __skparam__headers)
    return __skadapter__to_http_response(__skreturn)
def http_post ( url, port, body ):
    __skparam__url = __skadapter__to_sklib_string(url)
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skparam__body = __skadapter__to_sklib_string(body)
    __skreturn = sklib.__sklib__http_post__string_ref__unsigned_short__string(__skparam__url, __skparam__port, __skparam__body)
    return __skadapter__to_http_response(__skreturn)
def http_response_to_string ( response ):
    __skparam__response = __skadapter__to_sklib_http_response(response)
    __skreturn = sklib.__sklib__http_response_to_string__http_response(__skparam__response)
    return __skadapter__to_string(__skreturn)
def save_response_to_file ( response, path ):
    __skparam__response = __skadapter__to_sklib_http_response(response)
    __skparam__path = __skadapter__to_sklib_string(path)
    sklib.__sklib__save_response_to_file__http_response__string(__skparam__response, __skparam__path)
def has_incoming_requests ( server ):
    __skparam__server = __skadapter__to_sklib_web_server(server)
    __skreturn = sklib.__sklib__has_incoming_requests__web_server(__skparam__server)
    return __skadapter__to_bool(__skreturn)
def is_delete_request_for ( request, path ):
    __skparam__request = __skadapter__to_sklib_http_request(request)
    __skparam__path = __skadapter__to_sklib_string(path)
    __skreturn = sklib.__sklib__is_delete_request_for__http_request__string_ref(__skparam__request, __skparam__path)
    return __skadapter__to_bool(__skreturn)
def is_get_request_for ( request, path ):
    __skparam__request = __skadapter__to_sklib_http_request(request)
    __skparam__path = __skadapter__to_sklib_string(path)
    __skreturn = sklib.__sklib__is_get_request_for__http_request__string_ref(__skparam__request, __skparam__path)
    return __skadapter__to_bool(__skreturn)
def is_options_request_for ( request, path ):
    __skparam__request = __skadapter__to_sklib_http_request(request)
    __skparam__path = __skadapter__to_sklib_string(path)
    __skreturn = sklib.__sklib__is_options_request_for__http_request__string_ref(__skparam__request, __skparam__path)
    return __skadapter__to_bool(__skreturn)
def is_post_request_for ( request, path ):
    __skparam__request = __skadapter__to_sklib_http_request(request)
    __skparam__path = __skadapter__to_sklib_string(path)
    __skreturn = sklib.__sklib__is_post_request_for__http_request__string_ref(__skparam__request, __skparam__path)
    return __skadapter__to_bool(__skreturn)
def is_put_request_for ( request, path ):
    __skparam__request = __skadapter__to_sklib_http_request(request)
    __skparam__path = __skadapter__to_sklib_string(path)
    __skreturn = sklib.__sklib__is_put_request_for__http_request__string_ref(__skparam__request, __skparam__path)
    return __skadapter__to_bool(__skreturn)
def is_request_for ( request, method, path ):
    __skparam__request = __skadapter__to_sklib_http_request(request)
    __skparam__method = __skadapter__to_sklib_http_method(method)
    __skparam__path = __skadapter__to_sklib_string(path)
    __skreturn = sklib.__sklib__is_request_for__http_request__http_method__string_ref(__skparam__request, __skparam__method, __skparam__path)
    return __skadapter__to_bool(__skreturn)
def is_trace_request_for ( request, path ):
    __skparam__request = __skadapter__to_sklib_http_request(request)
    __skparam__path = __skadapter__to_sklib_string(path)
    __skreturn = sklib.__sklib__is_trace_request_for__http_request__string_ref(__skparam__request, __skparam__path)
    return __skadapter__to_bool(__skreturn)
def next_web_request ( server ):
    __skparam__server = __skadapter__to_sklib_web_server(server)
    __skreturn = sklib.__sklib__next_web_request__web_server(__skparam__server)
    return __skadapter__to_http_request(__skreturn)
def request_body ( r ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skreturn = sklib.__sklib__request_body__http_request(__skparam__r)
    return __skadapter__to_string(__skreturn)
def request_has_query_parameter ( r, name ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__request_has_query_parameter__http_request__string_ref(__skparam__r, __skparam__name)
    return __skadapter__to_bool(__skreturn)
def request_headers ( r ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skreturn = sklib.__sklib__request_headers__http_request(__skparam__r)
    return __skadapter__to_vector_string(__skreturn)
def request_method ( r ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skreturn = sklib.__sklib__request_method__http_request(__skparam__r)
    return __skadapter__to_http_method(__skreturn)
def request_query_parameter ( r, name, default_value ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__default_value = __skadapter__to_sklib_string(default_value)
    __skreturn = sklib.__sklib__request_query_parameter__http_request__string_ref__string_ref(__skparam__r, __skparam__name, __skparam__default_value)
    return __skadapter__to_string(__skreturn)
def request_query_string ( r ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skreturn = sklib.__sklib__request_query_string__http_request(__skparam__r)
    return __skadapter__to_string(__skreturn)
def request_uri ( r ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skreturn = sklib.__sklib__request_uri__http_request(__skparam__r)
    return __skadapter__to_string(__skreturn)
def request_uri_stubs ( r ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skreturn = sklib.__sklib__request_uri_stubs__http_request(__skparam__r)
    return __skadapter__to_vector_string(__skreturn)
def send_css_file_response ( r, filename ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__filename = __skadapter__to_sklib_string(filename)
    sklib.__sklib__send_css_file_response__http_request__string_ref(__skparam__r, __skparam__filename)
def send_file_response ( r, filename, content_type ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__filename = __skadapter__to_sklib_string(filename)
    __skparam__content_type = __skadapter__to_sklib_string(content_type)
    sklib.__sklib__send_file_response__http_request__string_ref__string_ref(__skparam__r, __skparam__filename, __skparam__content_type)
def send_html_file_response ( r, filename ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__filename = __skadapter__to_sklib_string(filename)
    sklib.__sklib__send_html_file_response__http_request__string_ref(__skparam__r, __skparam__filename)
def send_javascript_file_response ( r, filename ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__filename = __skadapter__to_sklib_string(filename)
    sklib.__sklib__send_javascript_file_response__http_request__string_ref(__skparam__r, __skparam__filename)
def send_response_empty ( r ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    sklib.__sklib__send_response__http_request(__skparam__r)
def send_response ( r, message ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__message = __skadapter__to_sklib_string(message)
    sklib.__sklib__send_response__http_request__string_ref(__skparam__r, __skparam__message)
def send_response_json_with_status ( r, code ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__code = __skadapter__to_sklib_http_status_code(code)
    sklib.__sklib__send_response__http_request__http_status_code(__skparam__r, __skparam__code)
def send_response_with_status ( r, code, message ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__code = __skadapter__to_sklib_http_status_code(code)
    __skparam__message = __skadapter__to_sklib_string(message)
    sklib.__sklib__send_response__http_request__http_status_code__string_ref(__skparam__r, __skparam__code, __skparam__message)
def send_response_with_status_and_content_type ( r, code, message, content_type ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__code = __skadapter__to_sklib_http_status_code(code)
    __skparam__message = __skadapter__to_sklib_string(message)
    __skparam__content_type = __skadapter__to_sklib_string(content_type)
    sklib.__sklib__send_response__http_request__http_status_code__string_ref__string_ref(__skparam__r, __skparam__code, __skparam__message, __skparam__content_type)
def send_response_with_status_and_content_type_and_headers ( r, code, message, content_type, headers ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__code = __skadapter__to_sklib_http_status_code(code)
    __skparam__message = __skadapter__to_sklib_string(message)
    __skparam__content_type = __skadapter__to_sklib_string(content_type)
    __skparam__headers = __skadapter__to_sklib_vector_string(headers)
    sklib.__sklib__send_response__http_request__http_status_code__string_ref__string_ref__vector_string_ref(__skparam__r, __skparam__code, __skparam__message, __skparam__content_type, __skparam__headers)
def send_response_json ( r, j ):
    __skparam__r = __skadapter__to_sklib_http_request(r)
    __skparam__j = __skadapter__to_sklib_json(j)
    sklib.__sklib__send_response__http_request__json(__skparam__r, __skparam__j)
def split_uri_stubs ( uri ):
    __skparam__uri = __skadapter__to_sklib_string(uri)
    __skreturn = sklib.__sklib__split_uri_stubs__string_ref(__skparam__uri)
    return __skadapter__to_vector_string(__skreturn)
def start_web_server_with_default_port (  ):
    __skreturn = sklib.__sklib__start_web_server()
    return __skadapter__to_web_server(__skreturn)
def start_web_server ( port ):
    __skparam__port = __skadapter__to_sklib_unsigned_short(port)
    __skreturn = sklib.__sklib__start_web_server__unsigned_short(__skparam__port)
    return __skadapter__to_web_server(__skreturn)
def stop_web_server ( server ):
    __skparam__server = __skadapter__to_sklib_web_server(server)
    sklib.__sklib__stop_web_server__web_server(__skparam__server)
def clear_window ( wind, clr ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skparam__clr = __skadapter__to_sklib_color(clr)
    sklib.__sklib__clear_window__window__color(__skparam__wind, __skparam__clr)
def close_all_windows (  ):
    sklib.__sklib__close_all_windows()
def close_current_window (  ):
    sklib.__sklib__close_current_window()
def close_window_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__close_window__string_ref(__skparam__name)
def close_window ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    sklib.__sklib__close_window__window(__skparam__wind)
def current_window (  ):
    __skreturn = sklib.__sklib__current_window()
    return __skadapter__to_window(__skreturn)
def current_window_has_border (  ):
    __skreturn = sklib.__sklib__current_window_has_border()
    return __skadapter__to_bool(__skreturn)
def current_window_height (  ):
    __skreturn = sklib.__sklib__current_window_height()
    return __skadapter__to_int(__skreturn)
def current_window_is_fullscreen (  ):
    __skreturn = sklib.__sklib__current_window_is_fullscreen()
    return __skadapter__to_bool(__skreturn)
def current_window_position (  ):
    __skreturn = sklib.__sklib__current_window_position()
    return __skadapter__to_point_2d(__skreturn)
def current_window_toggle_border (  ):
    sklib.__sklib__current_window_toggle_border()
def current_window_toggle_fullscreen (  ):
    sklib.__sklib__current_window_toggle_fullscreen()
def current_window_width (  ):
    __skreturn = sklib.__sklib__current_window_width()
    return __skadapter__to_int(__skreturn)
def current_window_x (  ):
    __skreturn = sklib.__sklib__current_window_x()
    return __skadapter__to_int(__skreturn)
def current_window_y (  ):
    __skreturn = sklib.__sklib__current_window_y()
    return __skadapter__to_int(__skreturn)
def has_window ( caption ):
    __skparam__caption = __skadapter__to_sklib_string(caption)
    __skreturn = sklib.__sklib__has_window__string(__skparam__caption)
    return __skadapter__to_bool(__skreturn)
def is_current_window ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skreturn = sklib.__sklib__is_current_window__window(__skparam__wind)
    return __skadapter__to_bool(__skreturn)
def move_current_window_to ( x, y ):
    __skparam__x = __skadapter__to_sklib_int(x)
    __skparam__y = __skadapter__to_sklib_int(y)
    sklib.__sklib__move_current_window_to__int__int(__skparam__x, __skparam__y)
def move_window_to_named ( name, x, y ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skparam__x = __skadapter__to_sklib_int(x)
    __skparam__y = __skadapter__to_sklib_int(y)
    sklib.__sklib__move_window_to__string_ref__int__int(__skparam__name, __skparam__x, __skparam__y)
def move_window_to ( wind, x, y ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skparam__x = __skadapter__to_sklib_int(x)
    __skparam__y = __skadapter__to_sklib_int(y)
    sklib.__sklib__move_window_to__window__int__int(__skparam__wind, __skparam__x, __skparam__y)
def open_window ( caption, width, height ):
    __skparam__caption = __skadapter__to_sklib_string(caption)
    __skparam__width = __skadapter__to_sklib_int(width)
    __skparam__height = __skadapter__to_sklib_int(height)
    __skreturn = sklib.__sklib__open_window__string__int__int(__skparam__caption, __skparam__width, __skparam__height)
    return __skadapter__to_window(__skreturn)
def refresh_window ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    sklib.__sklib__refresh_window__window(__skparam__wind)
def refresh_window_with_target_fps ( wind, target_fps ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skparam__target_fps = __skadapter__to_sklib_unsigned_int(target_fps)
    sklib.__sklib__refresh_window__window__unsigned_int(__skparam__wind, __skparam__target_fps)
def resize_current_window ( width, height ):
    __skparam__width = __skadapter__to_sklib_int(width)
    __skparam__height = __skadapter__to_sklib_int(height)
    sklib.__sklib__resize_current_window__int__int(__skparam__width, __skparam__height)
def resize_window ( wnd, width, height ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skparam__width = __skadapter__to_sklib_int(width)
    __skparam__height = __skadapter__to_sklib_int(height)
    sklib.__sklib__resize_window__window__int__int(__skparam__wnd, __skparam__width, __skparam__height)
def set_current_window_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__set_current_window__string_ref(__skparam__name)
def set_current_window ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    sklib.__sklib__set_current_window__window(__skparam__wind)
def window_caption ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skreturn = sklib.__sklib__window_caption__window(__skparam__wind)
    return __skadapter__to_string(__skreturn)
def window_close_requested_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__window_close_requested__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def window_close_requested ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skreturn = sklib.__sklib__window_close_requested__window(__skparam__wind)
    return __skadapter__to_bool(__skreturn)
def window_has_border_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__window_has_border__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def window_has_border ( wnd ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skreturn = sklib.__sklib__window_has_border__window(__skparam__wnd)
    return __skadapter__to_bool(__skreturn)
def window_has_focus ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skreturn = sklib.__sklib__window_has_focus__window(__skparam__wind)
    return __skadapter__to_bool(__skreturn)
def window_height_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__window_height__string_ref(__skparam__name)
    return __skadapter__to_int(__skreturn)
def window_height ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skreturn = sklib.__sklib__window_height__window(__skparam__wind)
    return __skadapter__to_int(__skreturn)
def window_is_fullscreen_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__window_is_fullscreen__string_ref(__skparam__name)
    return __skadapter__to_bool(__skreturn)
def window_is_fullscreen ( wnd ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skreturn = sklib.__sklib__window_is_fullscreen__window(__skparam__wnd)
    return __skadapter__to_bool(__skreturn)
def window_named ( caption ):
    __skparam__caption = __skadapter__to_sklib_string(caption)
    __skreturn = sklib.__sklib__window_named__string(__skparam__caption)
    return __skadapter__to_window(__skreturn)
def window_position_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__window_position__string_ref(__skparam__name)
    return __skadapter__to_point_2d(__skreturn)
def window_position ( wnd ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skreturn = sklib.__sklib__window_position__window(__skparam__wnd)
    return __skadapter__to_point_2d(__skreturn)
def window_set_icon ( wind, bmp ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skparam__bmp = __skadapter__to_sklib_bitmap(bmp)
    sklib.__sklib__window_set_icon__window__bitmap(__skparam__wind, __skparam__bmp)
def window_toggle_border_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__window_toggle_border__string_ref(__skparam__name)
def window_toggle_border ( wnd ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    sklib.__sklib__window_toggle_border__window(__skparam__wnd)
def window_toggle_fullscreen_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    sklib.__sklib__window_toggle_fullscreen__string_ref(__skparam__name)
def window_toggle_fullscreen ( wnd ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    sklib.__sklib__window_toggle_fullscreen__window(__skparam__wnd)
def window_width_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__window_width__string_ref(__skparam__name)
    return __skadapter__to_int(__skreturn)
def window_width ( wind ):
    __skparam__wind = __skadapter__to_sklib_window(wind)
    __skreturn = sklib.__sklib__window_width__window(__skparam__wind)
    return __skadapter__to_int(__skreturn)
def window_with_focus (  ):
    __skreturn = sklib.__sklib__window_with_focus()
    return __skadapter__to_window(__skreturn)
def window_x_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__window_x__string_ref(__skparam__name)
    return __skadapter__to_int(__skreturn)
def window_x ( wnd ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skreturn = sklib.__sklib__window_x__window(__skparam__wnd)
    return __skadapter__to_int(__skreturn)
def window_y_named ( name ):
    __skparam__name = __skadapter__to_sklib_string(name)
    __skreturn = sklib.__sklib__window_y__string_ref(__skparam__name)
    return __skadapter__to_int(__skreturn)
def window_y ( wnd ):
    __skparam__wnd = __skadapter__to_sklib_window(wnd)
    __skreturn = sklib.__sklib__window_y__window(__skparam__wnd)
    return __skadapter__to_int(__skreturn)
