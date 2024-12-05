unit SplashKit;

interface

type __sklib_json__record_type = record end;
type Json = ^__sklib_json__record_type;
type __sklib_music__record_type = record end;
type Music = ^__sklib_music__record_type;
type __sklib_connection__record_type = record end;
type Connection = ^__sklib_connection__record_type;
type __sklib_message__record_type = record end;
type Message = ^__sklib_message__record_type;
type __sklib_server_socket__record_type = record end;
type ServerSocket = ^__sklib_server_socket__record_type;
type __sklib_sound_effect__record_type = record end;
type SoundEffect = ^__sklib_sound_effect__record_type;
type __sklib_sprite__record_type = record end;
type Sprite = ^__sklib_sprite__record_type;
type __sklib_timer__record_type = record end;
type Timer = ^__sklib_timer__record_type;
type __sklib_animation__record_type = record end;
type Animation = ^__sklib_animation__record_type;
type __sklib_animation_script__record_type = record end;
type AnimationScript = ^__sklib_animation_script__record_type;
type __sklib_bitmap__record_type = record end;
type Bitmap = ^__sklib_bitmap__record_type;
type __sklib_display__record_type = record end;
type Display = ^__sklib_display__record_type;
type __sklib_font__record_type = record end;
type Font = ^__sklib_font__record_type;
type __sklib_http_response__record_type = record end;
type HttpResponse = ^__sklib_http_response__record_type;
type __sklib_http_request__record_type = record end;
type HttpRequest = ^__sklib_http_request__record_type;
type __sklib_web_server__record_type = record end;
type WebServer = ^__sklib_web_server__record_type;
type __sklib_window__record_type = record end;
type Window = ^__sklib_window__record_type;
type KeyCode = (
  UNKNOWN_KEY = 0,
  BACKSPACE_KEY = 8,
  TAB_KEY = 9,
  CLEAR_KEY = 12,
  RETURN_KEY = 13,
  PAUSE_KEY = 19,
  ESCAPE_KEY = 27,
  SPACE_KEY = 32,
  EXCLAIM_KEY = 33,
  DOUBLE_QUOTE_KEY = 34,
  HASH_KEY = 35,
  DOLLAR_KEY = 36,
  AMPERSAND_KEY = 38,
  QUOTE_KEY = 39,
  LEFT_PAREN_KEY = 40,
  RIGHT_PAREN_KEY = 41,
  ASTERISK_KEY = 42,
  PLUS_KEY = 43,
  COMMA_KEY = 44,
  MINUS_KEY = 45,
  PERIOD_KEY = 46,
  SLASH_KEY = 47,
  NUM_0_KEY = 48,
  NUM_1_KEY = 49,
  NUM_2_KEY = 50,
  NUM_3_KEY = 51,
  NUM_4_KEY = 52,
  NUM_5_KEY = 53,
  NUM_6_KEY = 54,
  NUM_7_KEY = 55,
  NUM_8_KEY = 56,
  NUM_9_KEY = 57,
  COLON_KEY = 58,
  SEMI_COLON_KEY = 59,
  LESS_KEY = 60,
  EQUALS_KEY = 61,
  GREATER_KEY = 62,
  QUESTION_KEY = 63,
  AT_KEY = 64,
  LEFT_BRACKET_KEY = 91,
  BACKSLASH_KEY = 92,
  RIGHT_BRACKET_KEY = 93,
  CARET_KEY = 94,
  UNDERSCORE_KEY = 95,
  BACKQUOTE_KEY = 96,
  A_KEY = 97,
  B_KEY = 98,
  C_KEY = 99,
  D_KEY = 100,
  E_KEY = 101,
  F_KEY = 102,
  G_KEY = 103,
  H_KEY = 104,
  I_KEY = 105,
  J_KEY = 106,
  K_KEY = 107,
  L_KEY = 108,
  M_KEY = 109,
  N_KEY = 110,
  O_KEY = 111,
  P_KEY = 112,
  Q_KEY = 113,
  R_KEY = 114,
  S_KEY = 115,
  T_KEY = 116,
  U_KEY = 117,
  V_KEY = 118,
  W_KEY = 119,
  X_KEY = 120,
  Y_KEY = 121,
  Z_KEY = 122,
  DELETE_KEY = 127,
  KEYPAD_0 = 256,
  KEYPAD_1 = 257,
  KEYPAD_2 = 258,
  KEYPAD_3 = 259,
  KEYPAD_4 = 260,
  KEYPAD_5 = 261,
  KEYPAD_6 = 262,
  KEYPAD_7 = 263,
  KEYPAD_8 = 264,
  KEYPAD_9 = 265,
  KEYPAD_PERIOD = 266,
  KEYPAD_DIVIDE = 267,
  KEYPAD_MULTIPLY = 268,
  KEYPAD_MINUS = 269,
  KEYPAD_PLUS = 270,
  KEYPAD_ENTER = 271,
  KEYPAD_EQUALS = 272,
  UP_KEY = 273,
  DOWN_KEY = 274,
  RIGHT_KEY = 275,
  LEFT_KEY = 276,
  INSERT_KEY = 277,
  HOME_KEY = 278,
  END_KEY = 279,
  PAGE_UP_KEY = 280,
  PAGE_DOWN_KEY = 281,
  F1_KEY = 282,
  F2_KEY = 283,
  F3_KEY = 284,
  F4_KEY = 285,
  F5_KEY = 286,
  F6_KEY = 287,
  F7_KEY = 288,
  F8_KEY = 289,
  F9_KEY = 290,
  F10_KEY = 291,
  F11_KEY = 292,
  F12_KEY = 293,
  F13_KEY = 294,
  F14_KEY = 295,
  F15_KEY = 296,
  NUM_LOCK_KEY = 300,
  CAPS_LOCK_KEY = 301,
  SCROLL_LOCK_KEY = 302,
  RIGHT_SHIFT_KEY = 303,
  LEFT_SHIFT_KEY = 304,
  RIGHT_CTRL_KEY = 305,
  LEFT_CTRL_KEY = 306,
  RIGHT_ALT_KEY = 307,
  LEFT_ALT_KEY = 308,
  LEFT_SUPER_KEY = 311,
  RIGHT_SUPER_KEY = 312,
  MODE_KEY = 313,
  HELP_KEY = 315,
  SYS_REQ_KEY = 317,
  MENU_KEY = 319,
  POWER_KEY = 320
);
type LogLevel = (
  NONE,
  INFO,
  DEBUG,
  WARNING,
  ERROR,
  FATAL
);
type LogMode = (
  LOG_NONE,
  LOG_CONSOLE,
  LOG_FILE_ONLY,
  LOG_CONSOLE_AND_FILE
);
type MouseButton = (
  NO_BUTTON,
  LEFT_BUTTON,
  MIDDLE_BUTTON,
  RIGHT_BUTTON,
  MOUSE_X1_BUTTON,
  MOUSE_X2_BUTTON
);
type ConnectionType = (
  TCP,
  UDP,
  UNKNOWN
);
type ResourceKind = (
  ANIMATION_RESOURCE,
  BUNDLE_RESOURCE,
  FONT_RESOURCE,
  IMAGE_RESOURCE,
  JSON_RESOURCE,
  MUSIC_RESOURCE,
  SERVER_RESOURCE,
  SOUND_RESOURCE,
  TIMER_RESOURCE,
  OTHER_RESOURCE
);
type CollisionTestKind = (
  PIXEL_COLLISIONS,
  AABB_COLLISIONS
);
type SpriteEventKind = (
  SPRITE_ARRIVED_EVENT,
  SPRITE_ANIMATION_ENDED_EVENT,
  SPRITE_TOUCHED_EVENT,
  SPRITE_CLICKED_EVENT
);
type DrawingDest = (
  DRAW_TO_SCREEN,
  DRAW_TO_WORLD,
  DRAW_DEFAULT
);
type FontStyle = (
  NORMAL_FONT = 0,
  BOLD_FONT = 1,
  ITALIC_FONT = 2,
  UNDERLINE_FONT = 4
);
type HttpStatusCode = (
  HTTP_STATUS_OK = 200,
  HTTP_STATUS_CREATED = 201,
  HTTP_STATUS_NO_CONTENT = 204,
  HTTP_STATUS_MOVED_PERMANENTLY = 301,
  HTTP_STATUS_FOUND = 302,
  HTTP_STATUS_SEE_OTHER = 303,
  HTTP_STATUS_BAD_REQUEST = 400,
  HTTP_STATUS_UNAUTHORIZED = 401,
  HTTP_STATUS_FORBIDDEN = 403,
  HTTP_STATUS_NOT_FOUND = 404,
  HTTP_STATUS_METHOD_NOT_ALLOWED = 405,
  HTTP_STATUS_REQUEST_TIMEOUT = 408,
  HTTP_STATUS_CONFLICT = 409,
  HTTP_STATUS_INTERNAL_SERVER_ERROR = 500,
  HTTP_STATUS_NOT_IMPLEMENTED = 501,
  HTTP_STATUS_SERVICE_UNAVAILABLE = 503
);
type InterfaceStyle = (
  FLAT_DARK_STYLE = 0,
  SHADED_DARK_STYLE = 1,
  FLAT_LIGHT_STYLE = 2,
  SHADED_LIGHT_STYLE = 3,
  BUBBLE = 4,
  BUBBLE_MULTICOLORED = 5
);
type PinModes = (
  GPIO_INPUT = 0,
  GPIO_OUTPUT = 1,
  GPIO_ALT0 = 4,
  GPIO_ALT1 = 5,
  GPIO_ALT2 = 6,
  GPIO_ALT3 = 7,
  GPIO_ALT4 = 3,
  GPIO_ALT5 = 2,
  GPIO_DEFAULT_MODE = 1
);
type PinValues = (
  GPIO_LOW = 0,
  GPIO_HIGH = 1,
  GPIO_DEFAULT_VALUE = 1
);
type Pins = (
  PIN_1 = 1,
  PIN_2 = 2,
  PIN_3 = 3,
  PIN_4 = 4,
  PIN_5 = 5,
  PIN_6 = 6,
  PIN_7 = 7,
  PIN_8 = 8,
  PIN_9 = 9,
  PIN_10 = 10,
  PIN_11 = 11,
  PIN_12 = 12,
  PIN_13 = 13,
  PIN_14 = 14,
  PIN_15 = 15,
  PIN_16 = 16,
  PIN_17 = 17,
  PIN_18 = 18,
  PIN_19 = 19,
  PIN_20 = 20,
  PIN_21 = 21,
  PIN_22 = 22,
  PIN_23 = 23,
  PIN_24 = 24,
  PIN_25 = 25,
  PIN_26 = 26,
  PIN_27 = 27,
  PIN_28 = 28,
  PIN_29 = 29,
  PIN_30 = 30,
  PIN_31 = 31,
  PIN_32 = 32,
  PIN_33 = 33,
  PIN_34 = 34,
  PIN_35 = 35,
  PIN_36 = 36,
  PIN_37 = 37,
  PIN_38 = 38,
  PIN_39 = 39,
  PIN_40 = 40
);
type PullUpDown = (
  PUD_OFF = 0,
  PUD_DOWN = 1,
  PUD_UP = 2
);
type HttpMethod = (
  HTTP_GET_METHOD,
  HTTP_POST_METHOD,
  HTTP_PUT_METHOD,
  HTTP_DELETE_METHOD,
  HTTP_OPTIONS_METHOD,
  HTTP_TRACE_METHOD,
  UNKNOWN_HTTP_METHOD
);
type Matrix2D = record
  elements: Array [0..2, 0..2] of Double;
end;
type Point2D = record
  x: Double;
  y: Double;
end;
type Circle = record
  center: Point2D;
  radius: Double;
end;
type Color = record
  r: Single;
  g: Single;
  b: Single;
  a: Single;
end;
type Rectangle = record
  x: Double;
  y: Double;
  width: Double;
  height: Double;
end;
type DrawingOptions = record
  dest: Pointer;
  scaleX: Single;
  scaleY: Single;
  angle: Single;
  anchorOffsetX: Single;
  anchorOffsetY: Single;
  flipX: Boolean;
  flipY: Boolean;
  isPart: Boolean;
  part: Rectangle;
  drawCell: Integer;
  camera: DrawingDest;
  lineWidth: Integer;
  anim: Animation;
end;
type Line = record
  startPoint: Point2D;
  endPoint: Point2D;
end;
type Quad = record
  points: Array [0..3] of Point2D;
end;
type Triangle = record
  points: Array [0..2] of Point2D;
end;
type Vector2D = record
  x: Double;
  y: Double;
end;
type ArrayOfString = Array of String;
type ArrayOfLine = Array of Line;
type ArrayOfChar = Array of Char;
type ArrayOfTriangle = Array of Triangle;
type ArrayOfDouble = Array of Double;
type ArrayOfJson = Array of Json;
type ArrayOfBoolean = Array of Boolean;
type KeyCallback = procedure (code: Integer); cdecl;
type FreeNotifier = procedure (pointer: Pointer); cdecl;
type SpriteEventHandler = procedure (s: Pointer; evt: Integer); cdecl;
type SpriteFloatFunction = procedure (s: Pointer; f: Single); cdecl;
type SpriteFunction = procedure (s: Pointer); cdecl;
function AnimationCount(script: AnimationScript): Integer;
function AnimationCurrentCell(anim: Animation): Integer;
function AnimationCurrentVector(anim: Animation): Vector2D;
function AnimationEnded(anim: Animation): Boolean;
function AnimationEnteredFrame(anim: Animation): Boolean;
function AnimationFrameTime(anim: Animation): Single;
function AnimationIndex(script: AnimationScript; const name: String): Integer;
function AnimationName(temp: Animation): String;
function AnimationScriptName(script: AnimationScript): String;
function AnimationScriptNamed(const name: String): AnimationScript;
procedure AssignAnimation(anim: Animation; script: AnimationScript; const name: String);
procedure AssignAnimation(anim: Animation; script: AnimationScript; const name: String; withSound: Boolean);
procedure AssignAnimation(anim: Animation; script: AnimationScript; idx: Integer);
procedure AssignAnimation(anim: Animation; script: AnimationScript; idx: Integer; withSound: Boolean);
procedure AssignAnimation(anim: Animation; const scriptName: String; const name: String);
procedure AssignAnimation(anim: Animation; const scriptName: String; const name: String; withSound: Boolean);
procedure AssignAnimation(anim: Animation; idx: Integer);
procedure AssignAnimation(anim: Animation; idx: Integer; withSound: Boolean);
procedure AssignAnimation(anim: Animation; name: String);
procedure AssignAnimation(anim: Animation; name: String; withSound: Boolean);
function CreateAnimation(script: AnimationScript; idx: Integer; withSound: Boolean): Animation;
function CreateAnimation(script: AnimationScript; const name: String): Animation;
function CreateAnimation(script: AnimationScript; const name: String; withSound: Boolean): Animation;
function CreateAnimation(const scriptName: String; const name: String): Animation;
function CreateAnimation(const scriptName: String; const name: String; withSound: Boolean): Animation;
procedure FreeAllAnimationScripts();
procedure FreeAnimation(ani: Animation);
procedure FreeAnimationScript(scriptToFree: AnimationScript);
procedure FreeAnimationScript(const name: String);
function HasAnimationNamed(script: AnimationScript; const name: String): Boolean;
function HasAnimationScript(const name: String): Boolean;
function LoadAnimationScript(const name: String; const filename: String): AnimationScript;
procedure RestartAnimation(anim: Animation);
procedure RestartAnimation(anim: Animation; withSound: Boolean);
procedure UpdateAnimation(anim: Animation; pct: Single; withSound: Boolean);
procedure UpdateAnimation(anim: Animation);
procedure UpdateAnimation(anim: Animation; pct: Single);
function AudioReady(): Boolean;
procedure CloseAudio();
procedure OpenAudio();
function Contains(const text: String; const subtext: String): Boolean;
function ConvertToDouble(const text: String): Double;
function ConvertToInteger(const text: String): Integer;
function IndexOf(const text: String; const subtext: String): Integer;
function IsDouble(const text: String): Boolean;
function IsInteger(const text: String): Boolean;
function IsNumber(const text: String): Boolean;
function LengthOf(const text: String): Integer;
function ReplaceAll(const text: String; const substr: String; const newtext: String): String;
function Split(const text: String; delimiter: Char): ArrayOfString;
function ToLowercase(const text: String): String;
function ToUppercase(const text: String): String;
function Trim(const text: String): String;
procedure FreeResourceBundle(name: String);
function HasResourceBundle(const name: String): Boolean;
procedure LoadResourceBundle(const name: String; const filename: String);
function CameraPosition(): Point2D;
function CameraX(): Double;
function CameraY(): Double;
procedure CenterCameraOn(s: Sprite; const offset: Vector2D);
procedure CenterCameraOn(s: Sprite; offsetX: Double; offsetY: Double);
procedure MoveCameraBy(const offset: Vector2D);
procedure MoveCameraBy(dx: Double; dy: Double);
procedure MoveCameraTo(const pt: Point2D);
procedure MoveCameraTo(x: Double; y: Double);
function PointInWindow(wind: Window; const pt: Point2D): Boolean;
function PointOnScreen(const pt: Point2D): Boolean;
function RectInWindow(wind: Window; const rect: Rectangle): Boolean;
function RectOnScreen(const rect: Rectangle): Boolean;
function ScreenCenter(): Point2D;
function ScreenRectangle(): Rectangle;
procedure SetCameraPosition(pos: Point2D);
procedure SetCameraX(x: Double);
procedure SetCameraY(y: Double);
function ToScreen(const pt: Point2D): Point2D;
function ToScreen(const rect: Rectangle): Rectangle;
function ToScreenX(worldX: Double): Double;
function ToScreenY(worldY: Double): Double;
function ToWorld(const pt: Point2D): Point2D;
function ToWorldX(screenX: Double): Double;
function ToWorldY(screenY: Double): Double;
function VectorWorldToScreen(): Vector2D;
function WindowArea(wind: Window): Rectangle;
procedure DrawCircle(clr: Color; const c: Circle);
procedure DrawCircle(clr: Color; const c: Circle; opts: DrawingOptions);
procedure DrawCircle(clr: Color; x: Double; y: Double; radius: Double);
procedure DrawCircle(clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
procedure DrawCircleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; radius: Double);
procedure DrawCircleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
procedure DrawCircleOnWindow(destination: Window; clr: Color; x: Double; y: Double; radius: Double);
procedure DrawCircleOnWindow(destination: Window; clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
procedure FillCircle(clr: Color; const c: Circle);
procedure FillCircle(clr: Color; const c: Circle; opts: DrawingOptions);
procedure FillCircle(clr: Color; x: Double; y: Double; radius: Double);
procedure FillCircle(clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
procedure FillCircleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; radius: Double);
procedure FillCircleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
procedure FillCircleOnWindow(destination: Window; clr: Color; x: Double; y: Double; radius: Double);
procedure FillCircleOnWindow(destination: Window; clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
function CenterPoint(const c: Circle): Point2D;
function CircleAt(const pt: Point2D; radius: Double): Circle;
function CircleAt(x: Double; y: Double; radius: Double): Circle;
function CircleRadius(c: Circle): Single;
function CircleTriangleIntersect(const c: Circle; const tri: Triangle): Boolean;
function CircleTriangleIntersect(const c: Circle; const tri: Triangle; var p: Point2D): Boolean;
function CircleX(const c: Circle): Single;
function CircleY(const c: Circle): Single;
function CirclesIntersect(c1: Circle; c2: Circle): Boolean;
function CirclesIntersect(c1X: Double; c1Y: Double; c1Radius: Double; c2X: Double; c2Y: Double; c2Radius: Double): Boolean;
function ClosestPointOnCircle(const fromPt: Point2D; const c: Circle): Point2D;
function ClosestPointOnLineFromCircle(const c: Circle; const l: Line): Point2D;
function ClosestPointOnRectFromCircle(const c: Circle; const rect: Rectangle): Point2D;
function ClosestPointOnTriangleFromCircle(const c: Circle; const tri: Triangle): Point2D;
function DistantPointOnCircle(const pt: Point2D; const c: Circle): Point2D;
function DistantPointOnCircleHeading(const pt: Point2D; const c: Circle; const heading: Vector2D; var oppositePt: Point2D): Boolean;
function RayCircleIntersectDistance(const rayOrigin: Point2D; const rayHeading: Vector2D; const c: Circle): Single;
function TangentPoints(const fromPt: Point2D; const c: Circle; var p1: Point2D; var p2: Point2D): Boolean;
procedure WidestPoints(const c: Circle; const along: Vector2D; var pt1: Point2D; var pt2: Point2D);
function CurrentClip(): Rectangle;
function CurrentClip(bmp: Bitmap): Rectangle;
function CurrentClip(wnd: Window): Rectangle;
procedure PopClip(wnd: Window);
procedure PopClip();
procedure PopClip(bmp: Bitmap);
procedure PushClip(wnd: Window; const r: Rectangle);
procedure PushClip(bmp: Bitmap; const r: Rectangle);
procedure PushClip(const r: Rectangle);
procedure ResetClip(bmp: Bitmap);
procedure ResetClip();
procedure ResetClip(wnd: Window);
procedure SetClip(const r: Rectangle);
procedure SetClip(bmp: Bitmap; const r: Rectangle);
procedure SetClip(wnd: Window; const r: Rectangle);
function BitmapCircleCollision(bmp: Bitmap; const pt: Point2D; const circ: Circle): Boolean;
function BitmapCircleCollision(bmp: Bitmap; x: Double; y: Double; const circ: Circle): Boolean;
function BitmapCircleCollision(bmp: Bitmap; cell: Integer; const translation: Matrix2D; const circ: Circle): Boolean;
function BitmapCircleCollision(bmp: Bitmap; cell: Integer; const pt: Point2D; const circ: Circle): Boolean;
function BitmapCircleCollision(bmp: Bitmap; cell: Integer; x: Double; y: Double; const circ: Circle): Boolean;
function BitmapCollision(bmp1: Bitmap; x1: Double; y1: Double; bmp2: Bitmap; x2: Double; y2: Double): Boolean;
function BitmapCollision(bmp1: Bitmap; const pt1: Point2D; bmp2: Bitmap; const pt2: Point2D): Boolean;
function BitmapCollision(bmp1: Bitmap; cell1: Integer; const matrix1: Matrix2D; bmp2: Bitmap; cell2: Integer; const matrix2: Matrix2D): Boolean;
function BitmapCollision(bmp1: Bitmap; cell1: Integer; const pt1: Point2D; bmp2: Bitmap; cell2: Integer; const pt2: Point2D): Boolean;
function BitmapCollision(bmp1: Bitmap; cell1: Integer; x1: Double; y1: Double; bmp2: Bitmap; cell2: Integer; x2: Double; y2: Double): Boolean;
function BitmapPointCollision(bmp: Bitmap; const translation: Matrix2D; const pt: Point2D): Boolean;
function BitmapPointCollision(bmp: Bitmap; const bmpPt: Point2D; const pt: Point2D): Boolean;
function BitmapPointCollision(bmp: Bitmap; bmpX: Double; bmpY: Double; x: Double; y: Double): Boolean;
function BitmapPointCollision(bmp: Bitmap; cell: Integer; const translation: Matrix2D; const pt: Point2D): Boolean;
function BitmapPointCollision(bmp: Bitmap; cell: Integer; const bmpPt: Point2D; const pt: Point2D): Boolean;
function BitmapPointCollision(bmp: Bitmap; cell: Integer; bmpX: Double; bmpY: Double; x: Double; y: Double): Boolean;
function BitmapRectangleCollision(bmp: Bitmap; const pt: Point2D; const rect: Rectangle): Boolean;
function BitmapRectangleCollision(bmp: Bitmap; x: Double; y: Double; const rect: Rectangle): Boolean;
function BitmapRectangleCollision(bmp: Bitmap; cell: Integer; const translation: Matrix2D; const rect: Rectangle): Boolean;
function BitmapRectangleCollision(bmp: Bitmap; cell: Integer; const pt: Point2D; const rect: Rectangle): Boolean;
function BitmapRectangleCollision(bmp: Bitmap; cell: Integer; x: Double; y: Double; const rect: Rectangle): Boolean;
function SpriteBitmapCollision(s: Sprite; bmp: Bitmap; x: Double; y: Double): Boolean;
function SpriteBitmapCollision(s: Sprite; bmp: Bitmap; cell: Integer; const pt: Point2D): Boolean;
function SpriteBitmapCollision(s: Sprite; bmp: Bitmap; cell: Integer; x: Double; y: Double): Boolean;
function SpriteCollision(s1: Sprite; s2: Sprite): Boolean;
function SpritePointCollision(s: Sprite; const pt: Point2D): Boolean;
function SpriteRectangleCollision(s: Sprite; const rect: Rectangle): Boolean;
function AlphaOf(c: Color): Integer;
function BlueOf(c: Color): Integer;
function BrightnessOf(c: Color): Double;
function ColorAliceBlue(): Color;
function ColorAntiqueWhite(): Color;
function ColorAqua(): Color;
function ColorAquamarine(): Color;
function ColorAzure(): Color;
function ColorBeige(): Color;
function ColorBisque(): Color;
function ColorBlack(): Color;
function ColorBlanchedAlmond(): Color;
function ColorBlue(): Color;
function ColorBlueViolet(): Color;
function ColorBrightGreen(): Color;
function ColorBrown(): Color;
function ColorBurlyWood(): Color;
function ColorCadetBlue(): Color;
function ColorChartreuse(): Color;
function ColorChocolate(): Color;
function ColorCoral(): Color;
function ColorCornflowerBlue(): Color;
function ColorCornsilk(): Color;
function ColorCrimson(): Color;
function ColorCyan(): Color;
function ColorDarkBlue(): Color;
function ColorDarkCyan(): Color;
function ColorDarkGoldenrod(): Color;
function ColorDarkGray(): Color;
function ColorDarkGreen(): Color;
function ColorDarkKhaki(): Color;
function ColorDarkMagenta(): Color;
function ColorDarkOliveGreen(): Color;
function ColorDarkOrange(): Color;
function ColorDarkOrchid(): Color;
function ColorDarkRed(): Color;
function ColorDarkSalmon(): Color;
function ColorDarkSeaGreen(): Color;
function ColorDarkSlateBlue(): Color;
function ColorDarkSlateGray(): Color;
function ColorDarkTurquoise(): Color;
function ColorDarkViolet(): Color;
function ColorDeepPink(): Color;
function ColorDeepSkyBlue(): Color;
function ColorDimGray(): Color;
function ColorDodgerBlue(): Color;
function ColorFirebrick(): Color;
function ColorFloralWhite(): Color;
function ColorForestGreen(): Color;
function ColorFuchsia(): Color;
function ColorGainsboro(): Color;
function ColorGhostWhite(): Color;
function ColorGold(): Color;
function ColorGoldenrod(): Color;
function ColorGray(): Color;
function ColorGreen(): Color;
function ColorGreenYellow(): Color;
function ColorHoneydew(): Color;
function ColorHotPink(): Color;
function ColorIndianRed(): Color;
function ColorIndigo(): Color;
function ColorIvory(): Color;
function ColorKhaki(): Color;
function ColorLavender(): Color;
function ColorLavenderBlush(): Color;
function ColorLawnGreen(): Color;
function ColorLemonChiffon(): Color;
function ColorLightBlue(): Color;
function ColorLightCoral(): Color;
function ColorLightCyan(): Color;
function ColorLightGoldenrodYellow(): Color;
function ColorLightGray(): Color;
function ColorLightGreen(): Color;
function ColorLightPink(): Color;
function ColorLightSalmon(): Color;
function ColorLightSeaGreen(): Color;
function ColorLightSkyBlue(): Color;
function ColorLightSlateGray(): Color;
function ColorLightSteelBlue(): Color;
function ColorLightYellow(): Color;
function ColorLime(): Color;
function ColorLimeGreen(): Color;
function ColorLinen(): Color;
function ColorMagenta(): Color;
function ColorMaroon(): Color;
function ColorMediumAquamarine(): Color;
function ColorMediumBlue(): Color;
function ColorMediumOrchid(): Color;
function ColorMediumPurple(): Color;
function ColorMediumSeaGreen(): Color;
function ColorMediumSlateBlue(): Color;
function ColorMediumSpringGreen(): Color;
function ColorMediumTurquoise(): Color;
function ColorMediumVioletRed(): Color;
function ColorMidnightBlue(): Color;
function ColorMintCream(): Color;
function ColorMistyRose(): Color;
function ColorMoccasin(): Color;
function ColorNavajoWhite(): Color;
function ColorNavy(): Color;
function ColorOldLace(): Color;
function ColorOlive(): Color;
function ColorOliveDrab(): Color;
function ColorOrange(): Color;
function ColorOrangeRed(): Color;
function ColorOrchid(): Color;
function ColorPaleGoldenrod(): Color;
function ColorPaleGreen(): Color;
function ColorPaleTurquoise(): Color;
function ColorPaleVioletRed(): Color;
function ColorPapayaWhip(): Color;
function ColorPeachPuff(): Color;
function ColorPeru(): Color;
function ColorPink(): Color;
function ColorPlum(): Color;
function ColorPowderBlue(): Color;
function ColorPurple(): Color;
function ColorRed(): Color;
function ColorRosyBrown(): Color;
function ColorRoyalBlue(): Color;
function ColorSaddleBrown(): Color;
function ColorSalmon(): Color;
function ColorSandyBrown(): Color;
function ColorSeaGreen(): Color;
function ColorSeaShell(): Color;
function ColorSienna(): Color;
function ColorSilver(): Color;
function ColorSkyBlue(): Color;
function ColorSlateBlue(): Color;
function ColorSlateGray(): Color;
function ColorSnow(): Color;
function ColorSpringGreen(): Color;
function ColorSteelBlue(): Color;
function ColorSwinburneRed(): Color;
function ColorTan(): Color;
function ColorTeal(): Color;
function ColorThistle(): Color;
function ColorToString(c: Color): String;
function ColorTomato(): Color;
function ColorTransparent(): Color;
function ColorTurquoise(): Color;
function ColorViolet(): Color;
function ColorWheat(): Color;
function ColorWhite(): Color;
function ColorWhiteSmoke(): Color;
function ColorYellow(): Color;
function ColorYellowGreen(): Color;
function GreenOf(c: Color): Integer;
function HSBColor(hue: Double; saturation: Double; brightness: Double): Color;
function HueOf(c: Color): Double;
function RandomColor(): Color;
function RandomRGBColor(alpha: Integer): Color;
function RedOf(c: Color): Integer;
function RGBColor(red: Double; green: Double; blue: Double): Color;
function RGBColor(red: Integer; green: Integer; blue: Integer): Color;
function RGBAColor(red: Double; green: Double; blue: Double; alpha: Double): Color;
function RGBAColor(red: Integer; green: Integer; blue: Integer; alpha: Integer): Color;
function SaturationOf(c: Color): Double;
function StringToColor(str: String): Color;
function OptionDefaults(): DrawingOptions;
function OptionDrawTo(dest: Bitmap): DrawingOptions;
function OptionDrawTo(dest: Bitmap; opts: DrawingOptions): DrawingOptions;
function OptionDrawTo(dest: Window): DrawingOptions;
function OptionDrawTo(dest: Window; opts: DrawingOptions): DrawingOptions;
function OptionFlipX(): DrawingOptions;
function OptionFlipX(opts: DrawingOptions): DrawingOptions;
function OptionFlipXy(): DrawingOptions;
function OptionFlipXy(opts: DrawingOptions): DrawingOptions;
function OptionFlipY(): DrawingOptions;
function OptionFlipY(opts: DrawingOptions): DrawingOptions;
function OptionLineWidth(width: Integer): DrawingOptions;
function OptionLineWidth(width: Integer; opts: DrawingOptions): DrawingOptions;
function OptionPartBmp(x: Double; y: Double; w: Double; h: Double): DrawingOptions;
function OptionPartBmp(x: Double; y: Double; w: Double; h: Double; opts: DrawingOptions): DrawingOptions;
function OptionPartBmp(part: Rectangle): DrawingOptions;
function OptionPartBmp(part: Rectangle; opts: DrawingOptions): DrawingOptions;
function OptionRotateBmp(angle: Double): DrawingOptions;
function OptionRotateBmp(angle: Double; anchorX: Double; anchorY: Double): DrawingOptions;
function OptionRotateBmp(angle: Double; anchorX: Double; anchorY: Double; opts: DrawingOptions): DrawingOptions;
function OptionRotateBmp(angle: Double; opts: DrawingOptions): DrawingOptions;
function OptionScaleBmp(scaleX: Double; scaleY: Double): DrawingOptions;
function OptionScaleBmp(scaleX: Double; scaleY: Double; opts: DrawingOptions): DrawingOptions;
function OptionToScreen(): DrawingOptions;
function OptionToScreen(opts: DrawingOptions): DrawingOptions;
function OptionToWorld(): DrawingOptions;
function OptionToWorld(opts: DrawingOptions): DrawingOptions;
function OptionWithAnimation(anim: Animation): DrawingOptions;
function OptionWithAnimation(anim: Animation; opts: DrawingOptions): DrawingOptions;
function OptionWithBitmapCell(cell: Integer): DrawingOptions;
function OptionWithBitmapCell(cell: Integer; opts: DrawingOptions): DrawingOptions;
procedure DrawEllipse(clr: Color; rect: Rectangle);
procedure DrawEllipse(clr: Color; rect: Rectangle; opts: DrawingOptions);
procedure DrawEllipse(clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure DrawEllipse(clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
procedure DrawEllipseOnBitmap(destination: Bitmap; clr: Color; rect: Rectangle);
procedure DrawEllipseOnBitmap(destination: Bitmap; clr: Color; rect: Rectangle; opts: DrawingOptions);
procedure DrawEllipseOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure DrawEllipseOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
procedure DrawEllipseOnWindow(destination: Window; clr: Color; rect: Rectangle);
procedure DrawEllipseOnWindow(destination: Window; clr: Color; rect: Rectangle; opts: DrawingOptions);
procedure DrawEllipseOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure DrawEllipseOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
procedure FillEllipse(clr: Color; rect: Rectangle);
procedure FillEllipse(clr: Color; rect: Rectangle; opts: DrawingOptions);
procedure FillEllipse(clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure FillEllipse(clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
procedure FillEllipseOnBitmap(destination: Bitmap; clr: Color; rect: Rectangle);
procedure FillEllipseOnBitmap(destination: Bitmap; clr: Color; rect: Rectangle; opts: DrawingOptions);
procedure FillEllipseOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure FillEllipseOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
procedure FillEllipseOnWindow(destination: Window; clr: Color; rect: Rectangle);
procedure FillEllipseOnWindow(destination: Window; clr: Color; rect: Rectangle; opts: DrawingOptions);
procedure FillEllipseOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure FillEllipseOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
function Cosine(degrees: Single): Single;
function Sine(degrees: Single): Single;
function Tangent(degrees: Single): Single;
procedure ClearScreen();
procedure ClearScreen(clr: Color);
function DisplayDetails(index: Cardinal): Display;
function DisplayHeight(disp: Display): Integer;
function DisplayName(disp: Display): String;
function DisplayWidth(disp: Display): Integer;
function DisplayX(disp: Display): Integer;
function DisplayY(disp: Display): Integer;
function NumberOfDisplays(): Integer;
procedure RefreshScreen();
procedure RefreshScreen(targetFps: Cardinal);
procedure SaveBitmap(bmp: Bitmap; const basename: String);
function ScreenHeight(): Integer;
function ScreenWidth(): Integer;
procedure TakeScreenshot(const basename: String);
procedure TakeScreenshot(wind: Window; const basename: String);
function BitmapBoundingCircle(bmp: Bitmap; const pt: Point2D): Circle;
function BitmapBoundingRectangle(bmp: Bitmap): Rectangle;
function BitmapBoundingRectangle(bmp: Bitmap; x: Double; y: Double): Rectangle;
function BitmapCellCenter(bmp: Bitmap): Point2D;
function BitmapCellCircle(bmp: Bitmap; x: Double; y: Double): Circle;
function BitmapCellCircle(bmp: Bitmap; pt: Point2D): Circle;
function BitmapCellCircle(bmp: Bitmap; pt: Point2D; scale: Double): Circle;
function BitmapCellColumns(bmp: Bitmap): Integer;
function BitmapCellCount(bmp: Bitmap): Integer;
function BitmapCellHeight(bmp: Bitmap): Integer;
function BitmapCellOffset(src: Bitmap; cell: Integer): Vector2D;
function BitmapCellRectangle(src: Bitmap): Rectangle;
function BitmapCellRectangle(src: Bitmap; const pt: Point2D): Rectangle;
function BitmapCellRows(bmp: Bitmap): Integer;
function BitmapCellWidth(bmp: Bitmap): Integer;
function BitmapCenter(bmp: Bitmap): Point2D;
function BitmapFilename(bmp: Bitmap): String;
function BitmapHeight(bmp: Bitmap): Integer;
function BitmapHeight(name: String): Integer;
function BitmapName(bmp: Bitmap): String;
function BitmapNamed(name: String): Bitmap;
function BitmapRectangleOfCell(src: Bitmap; cell: Integer): Rectangle;
procedure BitmapSetCellDetails(bmp: Bitmap; width: Integer; height: Integer; columns: Integer; rows: Integer; count: Integer);
function BitmapValid(bmp: Bitmap): Boolean;
function BitmapWidth(bmp: Bitmap): Integer;
function BitmapWidth(name: String): Integer;
procedure ClearBitmap(bmp: Bitmap; clr: Color);
procedure ClearBitmap(name: String; clr: Color);
function CreateBitmap(name: String; width: Integer; height: Integer): Bitmap;
procedure DrawBitmap(bmp: Bitmap; x: Double; y: Double);
procedure DrawBitmap(bmp: Bitmap; x: Double; y: Double; opts: DrawingOptions);
procedure DrawBitmap(name: String; x: Double; y: Double);
procedure DrawBitmap(name: String; x: Double; y: Double; opts: DrawingOptions);
procedure DrawBitmapOnBitmap(destination: Bitmap; bmp: Bitmap; x: Double; y: Double);
procedure DrawBitmapOnBitmap(destination: Bitmap; bmp: Bitmap; x: Double; y: Double; opts: DrawingOptions);
procedure DrawBitmapOnWindow(destination: Window; bmp: Bitmap; x: Double; y: Double);
procedure DrawBitmapOnWindow(destination: Window; bmp: Bitmap; x: Double; y: Double; opts: DrawingOptions);
procedure FreeAllBitmaps();
procedure FreeBitmap(toDelete: Bitmap);
function HasBitmap(name: String): Boolean;
function LoadBitmap(name: String; filename: String): Bitmap;
function PixelDrawnAtPoint(bmp: Bitmap; const pt: Point2D): Boolean;
function PixelDrawnAtPoint(bmp: Bitmap; x: Double; y: Double): Boolean;
function PixelDrawnAtPoint(bmp: Bitmap; cell: Integer; const pt: Point2D): Boolean;
function PixelDrawnAtPoint(bmp: Bitmap; cell: Integer; x: Double; y: Double): Boolean;
procedure SetupCollisionMask(bmp: Bitmap);
procedure ProcessEvents();
function QuitRequested(): Boolean;
procedure ResetQuit();
procedure AddColumn(width: Integer);
procedure AddColumnRelative(width: Double);
function BitmapButton(bmp: Bitmap): Boolean;
function BitmapButton(bmp: Bitmap; const rect: Rectangle): Boolean;
function BitmapButton(bmp: Bitmap; const rect: Rectangle; opts: DrawingOptions): Boolean;
function BitmapButton(bmp: Bitmap; opts: DrawingOptions): Boolean;
function BitmapButton(const labelText: String; bmp: Bitmap): Boolean;
function BitmapButton(const labelText: String; bmp: Bitmap; opts: DrawingOptions): Boolean;
function Button(const text: String; const rect: Rectangle): Boolean;
function Button(const text: String): Boolean;
function Button(const labelText: String; const text: String): Boolean;
function Checkbox(const text: String; const value: Boolean; const rect: Rectangle): Boolean;
function Checkbox(const text: String; const value: Boolean): Boolean;
function Checkbox(const labelText: String; const text: String; const value: Boolean): Boolean;
function ColorSlider(const clr: Color; const rect: Rectangle): Color;
function ColorSlider(const clr: Color): Color;
function ColorSlider(const labelText: String; const clr: Color): Color;
procedure DisableInterface();
procedure DrawInterface();
procedure EnableInterface();
procedure EndInset(const name: String);
procedure EndPanel(const name: String);
procedure EndPopup(const name: String);
procedure EndTreenode(const labelText: String);
procedure EnterColumn();
function GetInterfaceLabelWidth(): Integer;
function Header(const labelText: String): Boolean;
function HSBColorSlider(const clr: Color; const rect: Rectangle): Color;
function HSBColorSlider(const clr: Color): Color;
function HSBColorSlider(const labelText: String; const clr: Color): Color;
function InterfaceEnabled(): Boolean;
procedure InterfaceStylePanel(const initialRectangle: Rectangle);
procedure LabelElement(const text: String);
procedure LabelElement(const text: String; const rect: Rectangle);
function LastElementChanged(): Boolean;
function LastElementConfirmed(): Boolean;
procedure LeaveColumn();
function NumberBox(const value: Single; step: Single; const rect: Rectangle): Single;
function NumberBox(const value: Single; step: Single): Single;
function NumberBox(const labelText: String; const value: Single; step: Single): Single;
procedure OpenPopup(const name: String);
procedure Paragraph(const text: String);
procedure Paragraph(const text: String; const rect: Rectangle);
procedure ResetLayout();
procedure SetInterfaceAccentColor(clr: Color; contrast: Single);
procedure SetInterfaceBorderColor(clr: Color);
procedure SetInterfaceColorsAuto(mainClr: Color; accentClr: Color; contrast: Single; accentContrast: Single; borderContrast: Single);
procedure SetInterfaceElementColor(clr: Color; contrast: Single);
procedure SetInterfaceElementShadows(radius: Integer; clr: Color; offset: Point2D);
procedure SetInterfaceFont(const fnt: String);
procedure SetInterfaceFont(fnt: Font);
procedure SetInterfaceFontSize(size: Integer);
procedure SetInterfaceLabelWidth(width: Integer);
procedure SetInterfacePanelShadows(radius: Integer; clr: Color; offset: Point2D);
procedure SetInterfaceRootTextColor(clr: Color);
procedure SetInterfaceShadows(radius: Integer; clr: Color; offset: Point2D);
procedure SetInterfaceSpacing(spacing: Integer; padding: Integer);
procedure SetInterfaceStyle(style: InterfaceStyle);
procedure SetInterfaceStyle(style: InterfaceStyle; clr: Color);
procedure SetInterfaceTextColor(clr: Color);
procedure SetLayoutHeight(height: Integer);
procedure SingleLineLayout();
function Slider(const value: Single; minValue: Single; maxValue: Single; const rect: Rectangle): Single;
function Slider(const value: Single; minValue: Single; maxValue: Single): Single;
function Slider(const labelText: String; const value: Single; minValue: Single; maxValue: Single): Single;
procedure SplitIntoColumns(count: Integer);
procedure SplitIntoColumns(count: Integer; lastWidth: Integer);
procedure SplitIntoColumnsRelative(count: Integer; lastWidth: Double);
procedure StartCustomLayout();
procedure StartInset(const name: String; const rect: Rectangle);
procedure StartInset(const name: String; height: Integer);
function StartPanel(const name: String; initialRectangle: Rectangle): Boolean;
function StartPopup(const name: String): Boolean;
function StartTreenode(const labelText: String): Boolean;
function TextBox(const value: String): String;
function TextBox(const value: String; const rect: Rectangle): String;
function TextBox(const labelText: String; const value: String): String;
function CreateJson(): Json;
function CreateJson(jsonString: String): Json;
procedure FreeAllJson();
procedure FreeJson(j: Json);
function JsonCountKeys(j: Json): Integer;
function JsonFromColor(clr: Color): Json;
function JsonFromFile(const filename: String): Json;
function JsonFromString(const jString: String): Json;
function JsonHasKey(j: Json; key: String): Boolean;
procedure JsonReadArray(j: Json; key: String; var outResult: ArrayOfDouble);
procedure JsonReadArray(j: Json; key: String; var outResult: ArrayOfJson);
procedure JsonReadArray(j: Json; key: String; var outResult: ArrayOfString);
procedure JsonReadArray(j: Json; key: String; var outResult: ArrayOfBoolean);
function JsonReadBool(j: Json; key: String): Boolean;
function JsonReadNumber(j: Json; key: String): Single;
function JsonReadNumberAsDouble(j: Json; key: String): Double;
function JsonReadNumberAsInt(j: Json; key: String): Integer;
function JsonReadObject(j: Json; key: String): Json;
function JsonReadString(j: Json; key: String): String;
procedure JsonSetArray(j: Json; key: String; value: ArrayOfString);
procedure JsonSetArray(j: Json; key: String; value: ArrayOfDouble);
procedure JsonSetArray(j: Json; key: String; value: ArrayOfBoolean);
procedure JsonSetArray(j: Json; key: String; value: ArrayOfJson);
procedure JsonSetBool(j: Json; key: String; value: Boolean);
procedure JsonSetNumber(j: Json; key: String; value: Integer);
procedure JsonSetNumber(j: Json; key: String; value: Double);
procedure JsonSetNumber(j: Json; key: String; value: Single);
procedure JsonSetObject(j: Json; key: String; obj: Json);
procedure JsonSetString(j: Json; key: String; value: String);
function JsonToColor(j: Json): Color;
procedure JsonToFile(j: Json; const filename: String);
function JsonToString(j: Json): String;
function AnyKeyPressed(): Boolean;
procedure DeregisterCallbackOnKeyDown(callback: KeyCallback);
procedure DeregisterCallbackOnKeyTyped(callback: KeyCallback);
procedure DeregisterCallbackOnKeyUp(callback: KeyCallback);
function KeyDown(key: KeyCode): Boolean;
function KeyName(key: KeyCode): String;
function KeyReleased(key: KeyCode): Boolean;
function KeyTyped(key: KeyCode): Boolean;
function KeyUp(key: KeyCode): Boolean;
procedure RegisterCallbackOnKeyDown(callback: KeyCallback);
procedure RegisterCallbackOnKeyTyped(callback: KeyCallback);
procedure RegisterCallbackOnKeyUp(callback: KeyCallback);
procedure DrawLine(clr: Color; const l: Line);
procedure DrawLine(clr: Color; const l: Line; opts: DrawingOptions);
procedure DrawLine(clr: Color; const fromPt: Point2D; const toPt: Point2D);
procedure DrawLine(clr: Color; const fromPt: Point2D; const toPt: Point2D; const opts: DrawingOptions);
procedure DrawLine(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double);
procedure DrawLine(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; const opts: DrawingOptions);
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; const l: Line);
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; const l: Line; opts: DrawingOptions);
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; const fromPt: Point2D; const toPt: Point2D);
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; const fromPt: Point2D; const toPt: Point2D; const opts: DrawingOptions);
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double);
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; const opts: DrawingOptions);
procedure DrawLineOnWindow(destination: Window; clr: Color; const l: Line);
procedure DrawLineOnWindow(destination: Window; clr: Color; const l: Line; opts: DrawingOptions);
procedure DrawLineOnWindow(destination: Window; clr: Color; const fromPt: Point2D; const toPt: Point2D);
procedure DrawLineOnWindow(destination: Window; clr: Color; const fromPt: Point2D; const toPt: Point2D; const opts: DrawingOptions);
procedure DrawLineOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double);
procedure DrawLineOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; const opts: DrawingOptions);
function ClosestPointOnLine(fromPt: Point2D; const l: Line): Point2D;
function ClosestPointOnLines(fromPt: Point2D; const lines: ArrayOfLine; var lineIdx: Integer): Point2D;
function LineFrom(const start: Point2D; const endPt: Point2D): Line;
function LineFrom(const start: Point2D; const offset: Vector2D): Line;
function LineFrom(const v: Vector2D): Line;
function LineFrom(x1: Double; y1: Double; x2: Double; y2: Double): Line;
function LineIntersectionPoint(const line1: Line; const line2: Line; var pt: Point2D): Boolean;
function LineIntersectsCircle(const l: Line; const c: Circle): Boolean;
function LineIntersectsLines(const l: Line; const lines: ArrayOfLine): Boolean;
function LineIntersectsRect(const l: Line; const rect: Rectangle): Boolean;
function LineLength(const l: Line): Single;
function LineLengthSquared(const l: Line): Single;
function LineMidPoint(const l: Line): Point2D;
function LineNormal(const l: Line): Vector2D;
function LineToString(const ln: Line): String;
function LinesFrom(const rect: Rectangle): ArrayOfLine;
function LinesFrom(const t: Triangle): ArrayOfLine;
function LinesIntersect(const l1: Line; const l2: Line): Boolean;
procedure CloseLogProcess();
procedure InitCustomLogger(mode: LogMode);
procedure InitCustomLogger(appName: String; overridePrevLog: Boolean; mode: LogMode);
procedure Log(level: LogLevel; message: String);
procedure ApplyMatrix(const matrix: Matrix2D; var q: Quad);
procedure ApplyMatrix(const m: Matrix2D; var tri: Triangle);
function IdentityMatrix(): Matrix2D;
function MatrixInverse(const m: Matrix2D): Matrix2D;
function MatrixMultiply(const m: Matrix2D; const pt: Point2D): Point2D;
function MatrixMultiply(const m1: Matrix2D; const m2: Matrix2D): Matrix2D;
function MatrixMultiply(const m: Matrix2D; const v: Vector2D): Vector2D;
function MatrixToString(const matrix: Matrix2D): String;
function RotationMatrix(deg: Double): Matrix2D;
function ScaleMatrix(const scale: Point2D): Matrix2D;
function ScaleMatrix(const scale: Vector2D): Matrix2D;
function ScaleMatrix(scale: Double): Matrix2D;
function ScaleRotateTranslateMatrix(const scale: Point2D; deg: Double; const translate: Point2D): Matrix2D;
function TranslationMatrix(const pt: Point2D): Matrix2D;
function TranslationMatrix(const pt: Vector2D): Matrix2D;
function TranslationMatrix(dx: Double; dy: Double): Matrix2D;
procedure HideMouse();
function MouseClicked(button: MouseButton): Boolean;
function MouseDown(button: MouseButton): Boolean;
function MouseMovement(): Vector2D;
function MousePosition(): Point2D;
function MousePositionVector(): Vector2D;
function MouseShown(): Boolean;
function MouseUp(button: MouseButton): Boolean;
function MouseWheelScroll(): Vector2D;
function MouseX(): Single;
function MouseY(): Single;
procedure MoveMouse(x: Double; y: Double);
procedure MoveMouse(point: Point2D);
procedure ShowMouse();
procedure ShowMouse(show: Boolean);
procedure FadeMusicIn(const name: String; ms: Integer);
procedure FadeMusicIn(const name: String; times: Integer; ms: Integer);
procedure FadeMusicIn(data: Music; ms: Integer);
procedure FadeMusicIn(data: Music; times: Integer; ms: Integer);
procedure FadeMusicOut(ms: Integer);
procedure FreeAllMusic();
procedure FreeMusic(effect: Music);
function HasMusic(const name: String): Boolean;
function LoadMusic(const name: String; const filename: String): Music;
function MusicFilename(data: Music): String;
function MusicName(data: Music): String;
function MusicNamed(const name: String): Music;
function MusicPlaying(): Boolean;
function MusicValid(m: Music): Boolean;
function MusicVolume(): Double;
procedure PauseMusic();
procedure PlayMusic(const name: String);
procedure PlayMusic(const name: String; times: Integer);
procedure PlayMusic(data: Music);
procedure PlayMusic(data: Music; times: Integer);
procedure PlayMusic(data: Music; times: Integer; volume: Double);
procedure ResumeMusic();
procedure SetMusicVolume(volume: Double);
procedure StopMusic();
function AcceptAllNewConnections(): Boolean;
function AcceptNewConnection(server: ServerSocket): Boolean;
procedure BroadcastMessage(const aMsg: String; svr: ServerSocket);
procedure BroadcastMessage(const aMsg: String);
procedure BroadcastMessage(const aMsg: String; const name: String);
procedure CheckNetworkActivity();
procedure ClearMessages(const name: String);
procedure ClearMessages(aConnection: Connection);
procedure ClearMessages(svr: ServerSocket);
procedure CloseAllConnections();
procedure CloseAllServers();
function CloseConnection(aConnection: Connection): Boolean;
function CloseConnection(const name: String): Boolean;
procedure CloseMessage(msg: Message);
function CloseServer(const name: String): Boolean;
function CloseServer(svr: ServerSocket): Boolean;
function ConnectionCount(const name: String): Cardinal;
function ConnectionCount(server: ServerSocket): Cardinal;
function ConnectionIP(aConnection: Connection): Cardinal;
function ConnectionIP(const name: String): Cardinal;
function ConnectionNamed(const name: String): Connection;
function ConnectionPort(aConnection: Connection): Word;
function ConnectionPort(const name: String): Word;
function CreateServer(const name: String; port: Word): ServerSocket;
function CreateServer(const name: String; port: Word; protocol: ConnectionType): ServerSocket;
function DecToHex(aDec: Cardinal): String;
function FetchNewConnection(server: ServerSocket): Connection;
function HasConnection(const name: String): Boolean;
function HasMessages(): Boolean;
function HasMessages(con: Connection): Boolean;
function HasMessages(const name: String): Boolean;
function HasMessages(svr: ServerSocket): Boolean;
function HasNewConnections(): Boolean;
function HasServer(const name: String): Boolean;
function HexStrToIpv4(const aHex: String): String;
function HexToDecString(const aHex: String): String;
function Ipv4ToDec(const aIP: String): Cardinal;
function Ipv4ToHex(const aIP: String): String;
function Ipv4ToStr(ip: Cardinal): String;
function IsConnectionOpen(con: Connection): Boolean;
function IsConnectionOpen(const name: String): Boolean;
function LastConnection(const name: String): Connection;
function LastConnection(server: ServerSocket): Connection;
function MessageConnection(msg: Message): Connection;
function MessageCount(svr: ServerSocket): Cardinal;
function MessageCount(aConnection: Connection): Cardinal;
function MessageCount(const name: String): Cardinal;
function MessageData(msg: Message): String;
function MessageDataBytes(msg: Message): ArrayOfChar;
function MessageHost(msg: Message): String;
function MessagePort(msg: Message): Word;
function MessageProtocol(msg: Message): ConnectionType;
function MyIP(): String;
function NameForConnection(host: String; port: Cardinal): String;
function NewConnectionCount(server: ServerSocket): Integer;
function OpenConnection(const name: String; const host: String; port: Word): Connection;
function OpenConnection(const name: String; const host: String; port: Word; protocol: ConnectionType): Connection;
function ReadMessage(): Message;
function ReadMessage(aConnection: Connection): Message;
function ReadMessage(const name: String): Message;
function ReadMessage(svr: ServerSocket): Message;
function ReadMessageData(const name: String): String;
function ReadMessageData(aConnection: Connection): String;
function ReadMessageData(svr: ServerSocket): String;
procedure Reconnect(aConnection: Connection);
procedure Reconnect(const name: String);
procedure ReleaseAllConnections();
procedure ResetNewConnectionCount(server: ServerSocket);
function RetrieveConnection(const name: String; idx: Integer): Connection;
function RetrieveConnection(server: ServerSocket; idx: Integer): Connection;
function SendMessageTo(const aMsg: String; aConnection: Connection): Boolean;
function SendMessageTo(const aMsg: String; const name: String): Boolean;
function ServerHasNewConnection(const name: String): Boolean;
function ServerHasNewConnection(server: ServerSocket): Boolean;
function ServerNamed(const name: String): ServerSocket;
procedure SetUDPPacketSize(udpPacketSize: Cardinal);
function UDPPacketSize(): Cardinal;
procedure DrawPixel(clr: Color; const pt: Point2D);
procedure DrawPixel(clr: Color; const pt: Point2D; opts: DrawingOptions);
procedure DrawPixel(clr: Color; x: Double; y: Double);
procedure DrawPixel(clr: Color; x: Double; y: Double; opts: DrawingOptions);
procedure DrawPixelOnBitmap(destination: Bitmap; clr: Color; const pt: Point2D);
procedure DrawPixelOnBitmap(destination: Bitmap; clr: Color; const pt: Point2D; opts: DrawingOptions);
procedure DrawPixelOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double);
procedure DrawPixelOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; opts: DrawingOptions);
procedure DrawPixelOnWindow(destination: Window; clr: Color; const pt: Point2D);
procedure DrawPixelOnWindow(destination: Window; clr: Color; const pt: Point2D; opts: DrawingOptions);
procedure DrawPixelOnWindow(destination: Window; clr: Color; x: Double; y: Double);
procedure DrawPixelOnWindow(destination: Window; clr: Color; x: Double; y: Double; opts: DrawingOptions);
function GetPixel(bmp: Bitmap; const pt: Point2D): Color;
function GetPixel(bmp: Bitmap; x: Double; y: Double): Color;
function GetPixel(const pt: Point2D): Color;
function GetPixel(x: Double; y: Double): Color;
function GetPixel(wnd: Window; const pt: Point2D): Color;
function GetPixel(wnd: Window; x: Double; y: Double): Color;
function GetPixelFromWindow(destination: Window; const pt: Point2D): Color;
function GetPixelFromWindow(destination: Window; x: Double; y: Double): Color;
function PointAt(x: Double; y: Double): Point2D;
function PointAtOrigin(): Point2D;
function PointInCircle(const pt: Point2D; const c: Circle): Boolean;
function PointInCircle(ptx: Double; pty: Double; cx: Double; cy: Double; radius: Double): Boolean;
function PointInQuad(const pt: Point2D; const q: Quad): Boolean;
function PointInRectangle(const pt: Point2D; const rect: Rectangle): Boolean;
function PointInRectangle(ptx: Double; pty: Double; rectX: Double; rectY: Double; rectWidth: Double; rectHeight: Double): Boolean;
function PointInTriangle(const pt: Point2D; const tri: Triangle): Boolean;
function PointLineDistance(const pt: Point2D; const l: Line): Single;
function PointOffsetBy(const startPoint: Point2D; const offset: Vector2D): Point2D;
function PointOffsetFromOrigin(const offset: Vector2D): Point2D;
function PointOnLine(const pt: Point2D; const l: Line): Boolean;
function PointOnLine(const pt: Point2D; const l: Line; proximity: Single): Boolean;
function PointPointAngle(const pt1: Point2D; const pt2: Point2D): Single;
function PointPointDistance(const pt1: Point2D; const pt2: Point2D): Single;
function PointToString(const pt: Point2D): String;
function RandomBitmapPoint(bmp: Bitmap): Point2D;
function RandomScreenPoint(): Point2D;
function RandomWindowPoint(wind: Window): Point2D;
function SamePoint(const pt1: Point2D; const pt2: Point2D): Boolean;
function QuadFrom(const p1: Point2D; const p2: Point2D; const p3: Point2D; const p4: Point2D): Quad;
function QuadFrom(const rect: Rectangle): Quad;
function QuadFrom(const rect: Rectangle; const transform: Matrix2D): Quad;
function QuadFrom(xTopLeft: Double; yTopLeft: Double; xTopRight: Double; yTopRight: Double; xBottomLeft: Double; yBottomLeft: Double; xBottomRight: Double; yBottomRight: Double): Quad;
function QuadsIntersect(const q1: Quad; const q2: Quad): Boolean;
procedure SetQuadPoint(var q: Quad; idx: Integer; const value: Point2D);
function TrianglesFrom(const q: Quad): ArrayOfTriangle;
function Rnd(min: Integer; max: Integer): Integer;
function Rnd(): Single;
function Rnd(ubound: Integer): Integer;
function HasGpio(): Boolean;
procedure RaspiCleanup();
function RaspiGetMode(pin: Pins): PinModes;
procedure RaspiInit();
function RaspiRead(pin: Pins): PinValues;
procedure RaspiSetMode(pin: Pins; mode: PinModes);
procedure RaspiSetPullUpDown(pin: Pins; pud: PullUpDown);
procedure RaspiSetPwmDutycycle(pin: Pins; dutycycle: Integer);
procedure RaspiSetPwmFrequency(pin: Pins; frequency: Integer);
procedure RaspiSetPwmRange(pin: Pins; range: Integer);
procedure RaspiWrite(pin: Pins; value: PinValues);
procedure DrawQuad(clr: Color; const q: Quad);
procedure DrawQuad(clr: Color; const q: Quad; const opts: DrawingOptions);
procedure DrawQuadOnBitmap(destination: Bitmap; clr: Color; const q: Quad);
procedure DrawQuadOnBitmap(destination: Bitmap; clr: Color; const q: Quad; const opts: DrawingOptions);
procedure DrawQuadOnWindow(destination: Window; clr: Color; const q: Quad);
procedure DrawQuadOnWindow(destination: Window; clr: Color; const q: Quad; const opts: DrawingOptions);
procedure DrawRectangle(clr: Color; const rect: Rectangle);
procedure DrawRectangle(clr: Color; const rect: Rectangle; const opts: DrawingOptions);
procedure DrawRectangle(clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure DrawRectangle(clr: Color; x: Double; y: Double; width: Double; height: Double; const opts: DrawingOptions);
procedure DrawRectangleOnBitmap(destination: Bitmap; clr: Color; const rect: Rectangle);
procedure DrawRectangleOnBitmap(destination: Bitmap; clr: Color; const rect: Rectangle; const opts: DrawingOptions);
procedure DrawRectangleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure DrawRectangleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
procedure DrawRectangleOnWindow(destination: Window; clr: Color; const rect: Rectangle);
procedure DrawRectangleOnWindow(destination: Window; clr: Color; const rect: Rectangle; const opts: DrawingOptions);
procedure DrawRectangleOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure DrawRectangleOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
procedure FillQuad(clr: Color; const q: Quad);
procedure FillQuad(clr: Color; const q: Quad; const opts: DrawingOptions);
procedure FillQuadOnBitmap(destination: Bitmap; clr: Color; const q: Quad);
procedure FillQuadOnBitmap(destination: Bitmap; clr: Color; const q: Quad; const opts: DrawingOptions);
procedure FillQuadOnWindow(destination: Window; clr: Color; const q: Quad);
procedure FillQuadOnWindow(destination: Window; clr: Color; const q: Quad; const opts: DrawingOptions);
procedure FillRectangle(clr: Color; const rect: Rectangle);
procedure FillRectangle(clr: Color; const rect: Rectangle; const opts: DrawingOptions);
procedure FillRectangle(clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure FillRectangle(clr: Color; x: Double; y: Double; width: Double; height: Double; const opts: DrawingOptions);
procedure FillRectangleOnBitmap(destination: Bitmap; clr: Color; const rect: Rectangle);
procedure FillRectangleOnBitmap(destination: Bitmap; clr: Color; const rect: Rectangle; const opts: DrawingOptions);
procedure FillRectangleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure FillRectangleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double; const opts: DrawingOptions);
procedure FillRectangleOnWindow(destination: Window; clr: Color; const rect: Rectangle);
procedure FillRectangleOnWindow(destination: Window; clr: Color; const rect: Rectangle; const opts: DrawingOptions);
procedure FillRectangleOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double);
procedure FillRectangleOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double; const opts: DrawingOptions);
function InsetRectangle(const rect: Rectangle; insetAmount: Single): Rectangle;
function Intersection(const rect1: Rectangle; const rect2: Rectangle): Rectangle;
function RectangleAround(const c: Circle): Rectangle;
function RectangleAround(const l: Line): Rectangle;
function RectangleAround(const q: Quad): Rectangle;
function RectangleAround(const t: Triangle): Rectangle;
function RectangleBottom(const rect: Rectangle): Single;
function RectangleCenter(const rect: Rectangle): Point2D;
function RectangleFrom(pt: Point2D; width: Double; height: Double): Rectangle;
function RectangleFrom(pt1: Point2D; pt2: Point2D): Rectangle;
function RectangleFrom(x: Double; y: Double; width: Double; height: Double): Rectangle;
function RectangleLeft(const rect: Rectangle): Single;
function RectangleOffsetBy(const rect: Rectangle; const offset: Vector2D): Rectangle;
function RectangleRight(const rect: Rectangle): Single;
function RectangleToString(const rect: Rectangle): String;
function RectangleTop(const rect: Rectangle): Single;
function RectanglesIntersect(const rect1: Rectangle; const rect2: Rectangle): Boolean;
procedure DeregisterFreeNotifier(handler: FreeNotifier);
function PathToResource(const filename: String; kind: ResourceKind): String;
function PathToResources(): String;
function PathToResources(kind: ResourceKind): String;
procedure RegisterFreeNotifier(fn: FreeNotifier);
procedure SetResourcesPath(const path: String);
procedure FadeAllSoundEffectsOut(ms: Integer);
procedure FadeSoundEffectOut(effect: SoundEffect; ms: Integer);
procedure FreeAllSoundEffects();
procedure FreeSoundEffect(effect: SoundEffect);
function HasSoundEffect(const name: String): Boolean;
function LoadSoundEffect(const name: String; const filename: String): SoundEffect;
procedure PlaySoundEffect(const name: String);
procedure PlaySoundEffect(const name: String; volume: Double);
procedure PlaySoundEffect(const name: String; times: Integer);
procedure PlaySoundEffect(const name: String; times: Integer; volume: Double);
procedure PlaySoundEffect(effect: SoundEffect);
procedure PlaySoundEffect(effect: SoundEffect; volume: Double);
procedure PlaySoundEffect(effect: SoundEffect; times: Integer);
procedure PlaySoundEffect(effect: SoundEffect; times: Integer; volume: Double);
function SoundEffectFilename(effect: SoundEffect): String;
function SoundEffectName(effect: SoundEffect): String;
function SoundEffectNamed(const name: String): SoundEffect;
function SoundEffectPlaying(const name: String): Boolean;
function SoundEffectPlaying(effect: SoundEffect): Boolean;
function SoundEffectValid(effect: SoundEffect): Boolean;
procedure StopSoundEffect(const name: String);
procedure StopSoundEffect(effect: SoundEffect);
procedure CallForAllSprites(fn: SpriteFloatFunction; val: Single);
procedure CallForAllSprites(fn: SpriteFunction);
procedure CallOnSpriteEvent(handler: SpriteEventHandler);
function CenterPoint(s: Sprite): Point2D;
function CreateSprite(layer: Bitmap): Sprite;
function CreateSprite(layer: Bitmap; ani: AnimationScript): Sprite;
function CreateSprite(const bitmapName: String): Sprite;
function CreateSprite(const name: String; layer: Bitmap): Sprite;
function CreateSprite(const name: String; layer: Bitmap; ani: AnimationScript): Sprite;
function CreateSprite(const bitmapName: String; const animationName: String): Sprite;
procedure CreateSpritePack(const name: String);
function CurrentSpritePack(): String;
procedure DrawAllSprites();
procedure DrawSprite(s: Sprite; const offset: Vector2D);
procedure DrawSprite(s: Sprite);
procedure DrawSprite(s: Sprite; xOffset: Double; yOffset: Double);
procedure FreeAllSprites();
procedure FreeSprite(s: Sprite);
procedure FreeSpritePack(const name: String);
function HasSprite(const name: String): Boolean;
function HasSpritePack(const name: String): Boolean;
procedure MoveSprite(s: Sprite);
procedure MoveSprite(s: Sprite; const distance: Vector2D);
procedure MoveSprite(s: Sprite; const distance: Vector2D; pct: Single);
procedure MoveSprite(s: Sprite; pct: Single);
procedure MoveSpriteTo(s: Sprite; x: Double; y: Double);
procedure SelectSpritePack(const name: String);
function SpriteAddLayer(s: Sprite; newLayer: Bitmap; const layerName: String): Integer;
procedure SpriteAddToVelocity(s: Sprite; const value: Vector2D);
procedure SpriteAddValue(s: Sprite; const name: String);
procedure SpriteAddValue(s: Sprite; const name: String; initVal: Single);
function SpriteAnchorPoint(s: Sprite): Point2D;
function SpriteAnchorPosition(s: Sprite): Point2D;
function SpriteAnimationHasEnded(s: Sprite): Boolean;
function SpriteAnimationName(s: Sprite): String;
function SpriteAt(s: Sprite; const pt: Point2D): Boolean;
procedure SpriteBringLayerForward(s: Sprite; visibleLayer: Integer);
procedure SpriteBringLayerToFront(s: Sprite; visibleLayer: Integer);
procedure SpriteCallOnEvent(s: Sprite; handler: SpriteEventHandler);
function SpriteCircle(s: Sprite): Circle;
function SpriteCollisionBitmap(s: Sprite): Bitmap;
function SpriteCollisionCircle(s: Sprite): Circle;
function SpriteCollisionKind(s: Sprite): CollisionTestKind;
function SpriteCollisionRectangle(s: Sprite): Rectangle;
function SpriteCurrentCell(s: Sprite): Integer;
function SpriteCurrentCellRectangle(s: Sprite): Rectangle;
function SpriteDx(s: Sprite): Single;
function SpriteDy(s: Sprite): Single;
function SpriteHasValue(s: Sprite; name: String): Boolean;
function SpriteHeading(s: Sprite): Single;
function SpriteHeight(s: Sprite): Integer;
procedure SpriteHideLayer(s: Sprite; const name: String);
procedure SpriteHideLayer(s: Sprite; id: Integer);
function SpriteLayer(s: Sprite; const name: String): Bitmap;
function SpriteLayer(s: Sprite; idx: Integer): Bitmap;
function SpriteLayerCircle(s: Sprite; const name: String): Circle;
function SpriteLayerCircle(s: Sprite; idx: Integer): Circle;
function SpriteLayerCount(s: Sprite): Integer;
function SpriteLayerHeight(s: Sprite; const name: String): Integer;
function SpriteLayerHeight(s: Sprite; idx: Integer): Integer;
function SpriteLayerIndex(s: Sprite; const name: String): Integer;
function SpriteLayerName(s: Sprite; idx: Integer): String;
function SpriteLayerOffset(s: Sprite; const name: String): Vector2D;
function SpriteLayerOffset(s: Sprite; idx: Integer): Vector2D;
function SpriteLayerRectangle(s: Sprite; const name: String): Rectangle;
function SpriteLayerRectangle(s: Sprite; idx: Integer): Rectangle;
function SpriteLayerWidth(s: Sprite; const name: String): Integer;
function SpriteLayerWidth(s: Sprite; idx: Integer): Integer;
function SpriteLocationMatrix(s: Sprite): Matrix2D;
function SpriteMass(s: Sprite): Single;
function SpriteMoveFromAnchorPoint(s: Sprite): Boolean;
procedure SpriteMoveTo(s: Sprite; const pt: Point2D; takingSeconds: Single);
function SpriteName(s: Sprite): String;
function SpriteNamed(const name: String): Sprite;
function SpriteOffscreen(s: Sprite): Boolean;
function SpriteOnScreenAt(s: Sprite; const pt: Point2D): Boolean;
function SpriteOnScreenAt(s: Sprite; x: Double; y: Double): Boolean;
function SpritePosition(s: Sprite): Point2D;
procedure SpriteReplayAnimation(s: Sprite);
procedure SpriteReplayAnimation(s: Sprite; withSound: Boolean);
function SpriteRotation(s: Sprite): Single;
function SpriteScale(s: Sprite): Single;
function SpriteScreenRectangle(s: Sprite): Rectangle;
procedure SpriteSendLayerBackward(s: Sprite; visibleLayer: Integer);
procedure SpriteSendLayerToBack(s: Sprite; visibleLayer: Integer);
procedure SpriteSetAnchorPoint(s: Sprite; const pt: Point2D);
procedure SpriteSetCollisionBitmap(s: Sprite; bmp: Bitmap);
procedure SpriteSetCollisionKind(s: Sprite; value: CollisionTestKind);
procedure SpriteSetDx(s: Sprite; value: Single);
procedure SpriteSetDy(s: Sprite; value: Single);
procedure SpriteSetHeading(s: Sprite; value: Single);
procedure SpriteSetLayerOffset(s: Sprite; const name: String; const value: Vector2D);
procedure SpriteSetLayerOffset(s: Sprite; idx: Integer; const value: Vector2D);
procedure SpriteSetMass(s: Sprite; value: Single);
procedure SpriteSetMoveFromAnchorPoint(s: Sprite; value: Boolean);
procedure SpriteSetPosition(s: Sprite; const value: Point2D);
procedure SpriteSetRotation(s: Sprite; value: Single);
procedure SpriteSetScale(s: Sprite; value: Single);
procedure SpriteSetSpeed(s: Sprite; value: Single);
procedure SpriteSetValue(s: Sprite; const name: String; val: Single);
procedure SpriteSetVelocity(s: Sprite; const value: Vector2D);
procedure SpriteSetX(s: Sprite; value: Single);
procedure SpriteSetY(s: Sprite; value: Single);
function SpriteShowLayer(s: Sprite; const name: String): Integer;
function SpriteShowLayer(s: Sprite; id: Integer): Integer;
function SpriteSpeed(s: Sprite): Single;
procedure SpriteStartAnimation(s: Sprite; const named: String);
procedure SpriteStartAnimation(s: Sprite; const named: String; withSound: Boolean);
procedure SpriteStartAnimation(s: Sprite; idx: Integer);
procedure SpriteStartAnimation(s: Sprite; idx: Integer; withSound: Boolean);
procedure SpriteStopCallingOnEvent(s: Sprite; handler: SpriteEventHandler);
procedure SpriteToggleLayerVisible(s: Sprite; const name: String);
procedure SpriteToggleLayerVisible(s: Sprite; id: Integer);
function SpriteValue(s: Sprite; const name: String): Single;
function SpriteValueCount(s: Sprite): Integer;
function SpriteVelocity(s: Sprite): Vector2D;
function SpriteVisibleIndexOfLayer(s: Sprite; const name: String): Integer;
function SpriteVisibleIndexOfLayer(s: Sprite; id: Integer): Integer;
function SpriteVisibleLayer(s: Sprite; idx: Integer): Integer;
function SpriteVisibleLayerCount(s: Sprite): Integer;
function SpriteVisibleLayerId(s: Sprite; idx: Integer): Integer;
function SpriteWidth(s: Sprite): Integer;
function SpriteX(s: Sprite): Single;
function SpriteY(s: Sprite): Single;
procedure StopCallingOnSpriteEvent(handler: SpriteEventHandler);
procedure UpdateAllSprites();
procedure UpdateAllSprites(pct: Single);
procedure UpdateSprite(s: Sprite);
procedure UpdateSprite(s: Sprite; withSound: Boolean);
procedure UpdateSprite(s: Sprite; pct: Single);
procedure UpdateSprite(s: Sprite; pct: Single; withSound: Boolean);
procedure UpdateSpriteAnimation(s: Sprite);
procedure UpdateSpriteAnimation(s: Sprite; withSound: Boolean);
procedure UpdateSpriteAnimation(s: Sprite; pct: Single);
procedure UpdateSpriteAnimation(s: Sprite; pct: Single; withSound: Boolean);
function VectorFromCenterSpriteToPoint(s: Sprite; const pt: Point2D): Vector2D;
function VectorFromTo(s1: Sprite; s2: Sprite): Vector2D;
function ReadChar(): Char;
function ReadLine(): String;
function TerminalHasInput(): Boolean;
procedure Write(data: Char);
procedure Write(data: Double);
procedure Write(data: Integer);
procedure Write(text: String);
procedure WriteLine(data: Char);
procedure WriteLine();
procedure WriteLine(data: Double);
procedure WriteLine(data: Integer);
procedure WriteLine(line: String);
procedure DrawText(const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double);
procedure DrawText(const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
procedure DrawText(const text: String; const clr: Color; x: Double; y: Double);
procedure DrawText(const text: String; const clr: Color; x: Double; y: Double; const opts: DrawingOptions);
procedure DrawText(const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double);
procedure DrawText(const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double);
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; x: Double; y: Double);
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; x: Double; y: Double; const opts: DrawingOptions);
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double);
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double);
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; x: Double; y: Double);
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; x: Double; y: Double; const opts: DrawingOptions);
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double);
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
function FontHasSize(const name: String; fontSize: Integer): Boolean;
function FontHasSize(fnt: Font; fontSize: Integer): Boolean;
procedure FontLoadSize(const name: String; fontSize: Integer);
procedure FontLoadSize(fnt: Font; fontSize: Integer);
function FontNamed(name: String): Font;
procedure FreeAllFonts();
procedure FreeFont(fnt: Font);
function GetFontStyle(const name: String): FontStyle;
function GetFontStyle(fnt: Font): FontStyle;
function GetSystemFont(): Font;
function HasFont(fnt: Font): Boolean;
function HasFont(name: String): Boolean;
function LoadFont(const name: String; const filename: String): Font;
procedure SetFontStyle(const name: String; style: FontStyle);
procedure SetFontStyle(fnt: Font; style: FontStyle);
function TextHeight(const text: String; const fnt: String; fontSize: Integer): Integer;
function TextHeight(const text: String; fnt: Font; fontSize: Integer): Integer;
function TextWidth(const text: String; const fnt: String; fontSize: Integer): Integer;
function TextWidth(const text: String; fnt: Font; fontSize: Integer): Integer;
procedure DrawCollectedText(clr: Color; fnt: Font; fontSize: Integer; const opts: DrawingOptions);
procedure EndReadingText();
procedure EndReadingText(wind: Window);
function ReadingText(): Boolean;
function ReadingText(wind: Window): Boolean;
procedure StartReadingText(rect: Rectangle);
procedure StartReadingText(rect: Rectangle; initialText: String);
procedure StartReadingText(wind: Window; rect: Rectangle);
procedure StartReadingText(wind: Window; rect: Rectangle; initialText: String);
function TextEntryCancelled(): Boolean;
function TextEntryCancelled(wind: Window): Boolean;
function TextInput(): String;
function TextInput(wind: Window): String;
function CreateTimer(name: String): Timer;
procedure FreeAllTimers();
procedure FreeTimer(toFree: Timer);
function HasTimer(name: String): Boolean;
procedure PauseTimer(name: String);
procedure PauseTimer(toPause: Timer);
procedure ResetTimer(name: String);
procedure ResetTimer(tmr: Timer);
procedure ResumeTimer(name: String);
procedure ResumeTimer(toResume: Timer);
procedure StartTimer(name: String);
procedure StartTimer(toStart: Timer);
procedure StopTimer(name: String);
procedure StopTimer(toStop: Timer);
function TimerNamed(name: String): Timer;
function TimerPaused(name: String): Boolean;
function TimerPaused(toGet: Timer): Boolean;
function TimerStarted(name: String): Boolean;
function TimerStarted(toGet: Timer): Boolean;
function TimerTicks(name: String): Cardinal;
function TimerTicks(toGet: Timer): Cardinal;
procedure DrawTriangle(clr: Color; const tri: Triangle);
procedure DrawTriangle(clr: Color; const tri: Triangle; opts: DrawingOptions);
procedure DrawTriangle(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
procedure DrawTriangle(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
procedure DrawTriangleOnBitmap(destination: Bitmap; clr: Color; const tri: Triangle);
procedure DrawTriangleOnBitmap(destination: Bitmap; clr: Color; const tri: Triangle; opts: DrawingOptions);
procedure DrawTriangleOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
procedure DrawTriangleOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
procedure DrawTriangleOnWindow(destination: Window; clr: Color; const tri: Triangle);
procedure DrawTriangleOnWindow(destination: Window; clr: Color; const tri: Triangle; opts: DrawingOptions);
procedure DrawTriangleOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
procedure DrawTriangleOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
procedure FillTriangle(clr: Color; const tri: Triangle);
procedure FillTriangle(clr: Color; const tri: Triangle; opts: DrawingOptions);
procedure FillTriangle(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
procedure FillTriangle(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
procedure FillTriangleOnBitmap(destination: Bitmap; clr: Color; const tri: Triangle);
procedure FillTriangleOnBitmap(destination: Bitmap; clr: Color; const tri: Triangle; opts: DrawingOptions);
procedure FillTriangleOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
procedure FillTriangleOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
procedure FillTriangleOnWindow(destination: Window; clr: Color; const tri: Triangle);
procedure FillTriangleOnWindow(destination: Window; clr: Color; const tri: Triangle; opts: DrawingOptions);
procedure FillTriangleOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
procedure FillTriangleOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
function TriangleBarycenter(const tri: Triangle): Point2D;
function TriangleFrom(const p1: Point2D; const p2: Point2D; const p3: Point2D): Triangle;
function TriangleFrom(x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double): Triangle;
function TriangleRectangleIntersect(const tri: Triangle; const rect: Rectangle): Boolean;
function TriangleToString(const tri: Triangle): String;
function TrianglesIntersect(const t1: Triangle; const t2: Triangle): Boolean;
function CurrentTicks(): Cardinal;
procedure Delay(milliseconds: Integer);
procedure DisplayDialog(const title: String; const msg: String; outputFont: Font; fontSize: Integer);
function FileAsString(filename: String; kind: ResourceKind): String;
function AngleBetween(const v1: Vector2D; const v2: Vector2D): Double;
function DotProduct(const v1: Vector2D; const v2: Vector2D): Double;
function IsZeroVector(const v: Vector2D): Boolean;
function RayIntersectionPoint(const fromPt: Point2D; const heading: Vector2D; const l: Line; var pt: Point2D): Boolean;
function UnitVector(const v: Vector2D): Vector2D;
function VectorAdd(const v1: Vector2D; const v2: Vector2D): Vector2D;
function VectorAngle(v: Vector2D): Double;
function VectorFromAngle(angle: Double; magnitude: Double): Vector2D;
function VectorFromLine(const l: Line): Vector2D;
function VectorFromPointToRect(const pt: Point2D; const rect: Rectangle): Vector2D;
function VectorInRect(const v: Vector2D; const rect: Rectangle): Boolean;
function VectorInvert(const v: Vector2D): Vector2D;
function VectorLimit(const v: Vector2D; limit: Double): Vector2D;
function VectorMagnitude(const v: Vector2D): Double;
function VectorMagnitudeSquared(const v: Vector2D): Double;
function VectorMultiply(const v1: Vector2D; s: Double): Vector2D;
function VectorNormal(const v: Vector2D): Vector2D;
function VectorOutOfCircleFromCircle(const src: Circle; const bounds: Circle; const velocity: Vector2D): Vector2D;
function VectorOutOfCircleFromPoint(const pt: Point2D; const c: Circle; const velocity: Vector2D): Vector2D;
function VectorOutOfRectFromCircle(const c: Circle; const rect: Rectangle; const velocity: Vector2D): Vector2D;
function VectorOutOfRectFromPoint(const pt: Point2D; const rect: Rectangle; const velocity: Vector2D): Vector2D;
function VectorOutOfRectFromRect(const src: Rectangle; const bounds: Rectangle; const velocity: Vector2D): Vector2D;
function VectorPointToPoint(const start: Point2D; const endPt: Point2D): Vector2D;
function VectorSubtract(const v1: Vector2D; const v2: Vector2D): Vector2D;
function VectorTo(const p1: Point2D): Vector2D;
function VectorTo(x: Double; y: Double): Vector2D;
function VectorToString(const v: Vector2D): String;
function VectorsEqual(const v1: Vector2D; v2: Vector2D): Boolean;
function VectorsNotEqual(const v1: Vector2D; v2: Vector2D): Boolean;
function DownloadBitmap(const name: String; const url: String; port: Word): Bitmap;
function DownloadFont(const name: String; const url: String; port: Word): Font;
function DownloadMusic(const name: String; const url: String; port: Word): Music;
function DownloadSoundEffect(const name: String; const url: String; port: Word): SoundEffect;
procedure FreeResponse(response: HttpResponse);
function HttpGet(const url: String; port: Word): HttpResponse;
function HttpPost(const url: String; port: Word; const body: String; const headers: ArrayOfString): HttpResponse;
function HttpPost(const url: String; port: Word; body: String): HttpResponse;
function HttpResponseToString(response: HttpResponse): String;
procedure SaveResponseToFile(response: HttpResponse; path: String);
function HasIncomingRequests(server: WebServer): Boolean;
function IsDeleteRequestFor(request: HttpRequest; const path: String): Boolean;
function IsGetRequestFor(request: HttpRequest; const path: String): Boolean;
function IsOptionsRequestFor(request: HttpRequest; const path: String): Boolean;
function IsPostRequestFor(request: HttpRequest; const path: String): Boolean;
function IsPutRequestFor(request: HttpRequest; const path: String): Boolean;
function IsRequestFor(request: HttpRequest; method: HttpMethod; const path: String): Boolean;
function IsTraceRequestFor(request: HttpRequest; const path: String): Boolean;
function NextWebRequest(server: WebServer): HttpRequest;
function RequestBody(r: HttpRequest): String;
function RequestHasQueryParameter(r: HttpRequest; const name: String): Boolean;
function RequestHeaders(r: HttpRequest): ArrayOfString;
function RequestMethod(r: HttpRequest): HttpMethod;
function RequestQueryParameter(r: HttpRequest; const name: String; const defaultValue: String): String;
function RequestQueryString(r: HttpRequest): String;
function RequestURI(r: HttpRequest): String;
function RequestURIStubs(r: HttpRequest): ArrayOfString;
procedure SendCSSFileResponse(r: HttpRequest; const filename: String);
procedure SendFileResponse(r: HttpRequest; const filename: String; const contentType: String);
procedure SendHtmlFileResponse(r: HttpRequest; const filename: String);
procedure SendJavascriptFileResponse(r: HttpRequest; const filename: String);
procedure SendResponse(r: HttpRequest);
procedure SendResponse(r: HttpRequest; const message: String);
procedure SendResponse(r: HttpRequest; code: HttpStatusCode);
procedure SendResponse(r: HttpRequest; code: HttpStatusCode; const message: String);
procedure SendResponse(r: HttpRequest; code: HttpStatusCode; const message: String; const contentType: String);
procedure SendResponse(r: HttpRequest; code: HttpStatusCode; const message: String; const contentType: String; const headers: ArrayOfString);
procedure SendResponse(r: HttpRequest; j: Json);
function SplitURIStubs(const uri: String): ArrayOfString;
function StartWebServer(): WebServer;
function StartWebServer(port: Word): WebServer;
procedure StopWebServer(server: WebServer);
procedure ClearWindow(wind: Window; clr: Color);
procedure CloseAllWindows();
procedure CloseCurrentWindow();
procedure CloseWindow(const name: String);
procedure CloseWindow(wind: Window);
function CurrentWindow(): Window;
function CurrentWindowHasBorder(): Boolean;
function CurrentWindowHeight(): Integer;
function CurrentWindowIsFullscreen(): Boolean;
function CurrentWindowPosition(): Point2D;
procedure CurrentWindowToggleBorder();
procedure CurrentWindowToggleFullscreen();
function CurrentWindowWidth(): Integer;
function CurrentWindowX(): Integer;
function CurrentWindowY(): Integer;
function HasWindow(caption: String): Boolean;
function IsCurrentWindow(wind: Window): Boolean;
procedure MoveCurrentWindowTo(x: Integer; y: Integer);
procedure MoveWindowTo(const name: String; x: Integer; y: Integer);
procedure MoveWindowTo(wind: Window; x: Integer; y: Integer);
function OpenWindow(caption: String; width: Integer; height: Integer): Window;
procedure RefreshWindow(wind: Window);
procedure RefreshWindow(wind: Window; targetFps: Cardinal);
procedure ResizeCurrentWindow(width: Integer; height: Integer);
procedure ResizeWindow(wnd: Window; width: Integer; height: Integer);
procedure SetCurrentWindow(const name: String);
procedure SetCurrentWindow(wind: Window);
function WindowCaption(wind: Window): String;
function WindowCloseRequested(const name: String): Boolean;
function WindowCloseRequested(wind: Window): Boolean;
function WindowHasBorder(const name: String): Boolean;
function WindowHasBorder(wnd: Window): Boolean;
function WindowHasFocus(wind: Window): Boolean;
function WindowHeight(const name: String): Integer;
function WindowHeight(wind: Window): Integer;
function WindowIsFullscreen(const name: String): Boolean;
function WindowIsFullscreen(wnd: Window): Boolean;
function WindowNamed(caption: String): Window;
function WindowPosition(const name: String): Point2D;
function WindowPosition(wnd: Window): Point2D;
procedure WindowSetIcon(wind: Window; bmp: Bitmap);
procedure WindowToggleBorder(const name: String);
procedure WindowToggleBorder(wnd: Window);
procedure WindowToggleFullscreen(const name: String);
procedure WindowToggleFullscreen(wnd: Window);
function WindowWidth(const name: String): Integer;
function WindowWidth(wind: Window): Integer;
function WindowWithFocus(): Window;
function WindowX(const name: String): Integer;
function WindowX(wnd: Window): Integer;
function WindowY(const name: String): Integer;
function WindowY(wnd: Window): Integer;

implementation
uses strings, math;

type __sklib_string = record
  str: PChar;
  size: Integer;
  ptr: Pointer;
end;
type __sklib_ptr = Pointer;
type __sklib_matrix_2d = record
  elements: Array [0..8] of Double;
end;
type __sklib_point_2d = record
  x: Double;
  y: Double;
end;
type __sklib_circle = record
  center: __sklib_point_2d;
  radius: Double;
end;
type __sklib_color = record
  r: Single;
  g: Single;
  b: Single;
  a: Single;
end;
type __sklib_rectangle = record
  x: Double;
  y: Double;
  width: Double;
  height: Double;
end;
type __sklib_drawing_options = record
  dest: Pointer;
  scaleX: Single;
  scaleY: Single;
  angle: Single;
  anchorOffsetX: Single;
  anchorOffsetY: Single;
  flipX: LongInt;
  flipY: LongInt;
  isPart: LongInt;
  part: __sklib_rectangle;
  drawCell: Integer;
  camera: LongInt;
  lineWidth: Integer;
  anim: __sklib_ptr;
end;
type __sklib_line = record
  startPoint: __sklib_point_2d;
  endPoint: __sklib_point_2d;
end;
type __sklib_quad = record
  points: Array [0..3] of __sklib_point_2d;
end;
type __sklib_triangle = record
  points: Array [0..2] of __sklib_point_2d;
end;
type __sklib_vector_2d = record
  x: Double;
  y: Double;
end;
function __skadapter__to_sklib_bool(v: Boolean): LongInt;
begin
  if v = true then result := -1 else result := 0;
end;
function __skadapter__to_bool(v: LongInt): Boolean;
begin
  result := v <> 0;
end;
function __skadapter__to_sklib_string(s: String): __sklib_string;
begin
  result.size := Length(s);
  result.str := StrAlloc(Length(s) + 1);
  result.ptr := nil;
  StrPCopy(result.str, s);
end;
procedure __sklib__free__sklib_string(s: __sklib_string); cdecl; external;
procedure __skadapter__free__sklib_string(s: __sklib_string);
begin
  StrDispose(s.str);
end;
function __skadapter__to_string(s: __sklib_string): String;
begin
  result := StrPas(s.str);
  __sklib__free__sklib_string(s);
end;
function __skadapter__to_sklib_int8_t(v: Char): Char;
begin
  result := v;
end;
function __skadapter__to_int8_t(v: Char): Char;
begin
  result := v;
end;
function __skadapter__to_sklib_int(v: Integer): Integer;
begin
  result := v;
end;
function __skadapter__to_int(v: Integer): Integer;
begin
  result := v;
end;
function __skadapter__to_sklib_short(v: ShortInt): ShortInt;
begin
  result := v;
end;
function __skadapter__to_short(v: ShortInt): ShortInt;
begin
  result := v;
end;
function __skadapter__to_sklib_int64_t(v: Int64): Int64;
begin
  result := v;
end;
function __skadapter__to_int64_t(v: Int64): Int64;
begin
  result := v;
end;
function __skadapter__to_sklib_float(v: Single): Single;
begin
  result := v;
end;
function __skadapter__to_float(v: Single): Single;
begin
  result := v;
end;
function __skadapter__to_sklib_double(v: Double): Double;
begin
  result := v;
end;
function __skadapter__to_double(v: Double): Double;
begin
  result := v;
end;
function __skadapter__to_sklib_byte(v: Char): Char;
begin
  result := v;
end;
function __skadapter__to_byte(v: Char): Char;
begin
  result := v;
end;
function __skadapter__to_sklib_char(v: Char): Char;
begin
  result := v;
end;
function __skadapter__to_char(v: Char): Char;
begin
  result := v;
end;
function __skadapter__to_sklib_unsigned_char(v: Char): Char;
begin
  result := v;
end;
function __skadapter__to_unsigned_char(v: Char): Char;
begin
  result := v;
end;
function __skadapter__to_sklib_unsigned_int(v: Cardinal): Cardinal;
begin
  result := v;
end;
function __skadapter__to_unsigned_int(v: Cardinal): Cardinal;
begin
  result := v;
end;
function __skadapter__to_sklib_unsigned_short(v: Word): Word;
begin
  result := v;
end;
function __skadapter__to_unsigned_short(v: Word): Word;
begin
  result := v;
end;
function __skadapter__to_key_code(v: LongInt): KeyCode;
begin
  result := KeyCode(v);
end;
function __skadapter__to_sklib_key_code(v: KeyCode): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_log_level(v: LongInt): LogLevel;
begin
  result := LogLevel(v);
end;
function __skadapter__to_sklib_log_level(v: LogLevel): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_log_mode(v: LongInt): LogMode;
begin
  result := LogMode(v);
end;
function __skadapter__to_sklib_log_mode(v: LogMode): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_mouse_button(v: LongInt): MouseButton;
begin
  result := MouseButton(v);
end;
function __skadapter__to_sklib_mouse_button(v: MouseButton): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_connection_type(v: LongInt): ConnectionType;
begin
  result := ConnectionType(v);
end;
function __skadapter__to_sklib_connection_type(v: ConnectionType): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_resource_kind(v: LongInt): ResourceKind;
begin
  result := ResourceKind(v);
end;
function __skadapter__to_sklib_resource_kind(v: ResourceKind): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_collision_test_kind(v: LongInt): CollisionTestKind;
begin
  result := CollisionTestKind(v);
end;
function __skadapter__to_sklib_collision_test_kind(v: CollisionTestKind): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_sprite_event_kind(v: LongInt): SpriteEventKind;
begin
  result := SpriteEventKind(v);
end;
function __skadapter__to_sklib_sprite_event_kind(v: SpriteEventKind): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_drawing_dest(v: LongInt): DrawingDest;
begin
  result := DrawingDest(v);
end;
function __skadapter__to_sklib_drawing_dest(v: DrawingDest): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_font_style(v: LongInt): FontStyle;
begin
  result := FontStyle(v);
end;
function __skadapter__to_sklib_font_style(v: FontStyle): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_http_status_code(v: LongInt): HttpStatusCode;
begin
  result := HttpStatusCode(v);
end;
function __skadapter__to_sklib_http_status_code(v: HttpStatusCode): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_interface_style(v: LongInt): InterfaceStyle;
begin
  result := InterfaceStyle(v);
end;
function __skadapter__to_sklib_interface_style(v: InterfaceStyle): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_pin_modes(v: LongInt): PinModes;
begin
  result := PinModes(v);
end;
function __skadapter__to_sklib_pin_modes(v: PinModes): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_pin_values(v: LongInt): PinValues;
begin
  result := PinValues(v);
end;
function __skadapter__to_sklib_pin_values(v: PinValues): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_pins(v: LongInt): Pins;
begin
  result := Pins(v);
end;
function __skadapter__to_sklib_pins(v: Pins): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_pull_up_down(v: LongInt): PullUpDown;
begin
  result := PullUpDown(v);
end;
function __skadapter__to_sklib_pull_up_down(v: PullUpDown): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_http_method(v: LongInt): HttpMethod;
begin
  result := HttpMethod(v);
end;
function __skadapter__to_sklib_http_method(v: HttpMethod): LongInt;
begin
  result := Integer(v);
end;
function __skadapter__to_sklib_ptr(v: __sklib_ptr): __sklib_ptr;
begin
  result := v;
end;
function __skadapter__to_ptr(v: __sklib_ptr): Pointer;
begin
  result := Pointer(v);
end;
function __skadapter__to_json(v: __sklib_ptr): Json;
begin
  result := Json(v);
end;
function __skadapter__to_sklib_json(v: Json): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_music(v: __sklib_ptr): Music;
begin
  result := Music(v);
end;
function __skadapter__to_sklib_music(v: Music): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_connection(v: __sklib_ptr): Connection;
begin
  result := Connection(v);
end;
function __skadapter__to_sklib_connection(v: Connection): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_message(v: __sklib_ptr): Message;
begin
  result := Message(v);
end;
function __skadapter__to_sklib_message(v: Message): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_server_socket(v: __sklib_ptr): ServerSocket;
begin
  result := ServerSocket(v);
end;
function __skadapter__to_sklib_server_socket(v: ServerSocket): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_sound_effect(v: __sklib_ptr): SoundEffect;
begin
  result := SoundEffect(v);
end;
function __skadapter__to_sklib_sound_effect(v: SoundEffect): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_sprite(v: __sklib_ptr): Sprite;
begin
  result := Sprite(v);
end;
function __skadapter__to_sklib_sprite(v: Sprite): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_timer(v: __sklib_ptr): Timer;
begin
  result := Timer(v);
end;
function __skadapter__to_sklib_timer(v: Timer): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_animation(v: __sklib_ptr): Animation;
begin
  result := Animation(v);
end;
function __skadapter__to_sklib_animation(v: Animation): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_animation_script(v: __sklib_ptr): AnimationScript;
begin
  result := AnimationScript(v);
end;
function __skadapter__to_sklib_animation_script(v: AnimationScript): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_bitmap(v: __sklib_ptr): Bitmap;
begin
  result := Bitmap(v);
end;
function __skadapter__to_sklib_bitmap(v: Bitmap): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_display(v: __sklib_ptr): Display;
begin
  result := Display(v);
end;
function __skadapter__to_sklib_display(v: Display): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_font(v: __sklib_ptr): Font;
begin
  result := Font(v);
end;
function __skadapter__to_sklib_font(v: Font): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_http_response(v: __sklib_ptr): HttpResponse;
begin
  result := HttpResponse(v);
end;
function __skadapter__to_sklib_http_response(v: HttpResponse): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_http_request(v: __sklib_ptr): HttpRequest;
begin
  result := HttpRequest(v);
end;
function __skadapter__to_sklib_http_request(v: HttpRequest): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_web_server(v: __sklib_ptr): WebServer;
begin
  result := WebServer(v);
end;
function __skadapter__to_sklib_web_server(v: WebServer): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_window(v: __sklib_ptr): Window;
begin
  result := Window(v);
end;
function __skadapter__to_sklib_window(v: Window): __sklib_ptr;
begin
  result := __sklib_ptr(v);
end;
function __skadapter__to_sklib_matrix_2d(v: Matrix2D): __sklib_matrix_2d;
begin
  result.elements[0] := __skadapter__to_sklib_double(v.elements[0,0]);
  result.elements[1] := __skadapter__to_sklib_double(v.elements[0,1]);
  result.elements[2] := __skadapter__to_sklib_double(v.elements[0,2]);
  result.elements[3] := __skadapter__to_sklib_double(v.elements[1,0]);
  result.elements[4] := __skadapter__to_sklib_double(v.elements[1,1]);
  result.elements[5] := __skadapter__to_sklib_double(v.elements[1,2]);
  result.elements[6] := __skadapter__to_sklib_double(v.elements[2,0]);
  result.elements[7] := __skadapter__to_sklib_double(v.elements[2,1]);
  result.elements[8] := __skadapter__to_sklib_double(v.elements[2,2]);
end;
function __skadapter__to_matrix_2d(v: __sklib_matrix_2d): Matrix2D;
begin
  result.elements[0,0] := __skadapter__to_double(v.elements[0]);
  result.elements[0,1] := __skadapter__to_double(v.elements[1]);
  result.elements[0,2] := __skadapter__to_double(v.elements[2]);
  result.elements[1,0] := __skadapter__to_double(v.elements[3]);
  result.elements[1,1] := __skadapter__to_double(v.elements[4]);
  result.elements[1,2] := __skadapter__to_double(v.elements[5]);
  result.elements[2,0] := __skadapter__to_double(v.elements[6]);
  result.elements[2,1] := __skadapter__to_double(v.elements[7]);
  result.elements[2,2] := __skadapter__to_double(v.elements[8]);
end;
function __skadapter__to_sklib_point_2d(v: Point2D): __sklib_point_2d;
begin
  result.x := __skadapter__to_sklib_double(v.x);
  result.y := __skadapter__to_sklib_double(v.y);
end;
function __skadapter__to_point_2d(v: __sklib_point_2d): Point2D;
begin
  result.x := __skadapter__to_double(v.x);
  result.y := __skadapter__to_double(v.y);
end;
function __skadapter__to_sklib_circle(v: Circle): __sklib_circle;
begin
  result.center := __skadapter__to_sklib_point_2d(v.center);
  result.radius := __skadapter__to_sklib_double(v.radius);
end;
function __skadapter__to_circle(v: __sklib_circle): Circle;
begin
  result.center := __skadapter__to_point_2d(v.center);
  result.radius := __skadapter__to_double(v.radius);
end;
function __skadapter__to_sklib_color(v: Color): __sklib_color;
begin
  result.r := __skadapter__to_sklib_float(v.r);
  result.g := __skadapter__to_sklib_float(v.g);
  result.b := __skadapter__to_sklib_float(v.b);
  result.a := __skadapter__to_sklib_float(v.a);
end;
function __skadapter__to_color(v: __sklib_color): Color;
begin
  result.r := __skadapter__to_float(v.r);
  result.g := __skadapter__to_float(v.g);
  result.b := __skadapter__to_float(v.b);
  result.a := __skadapter__to_float(v.a);
end;
function __skadapter__to_sklib_rectangle(v: Rectangle): __sklib_rectangle;
begin
  result.x := __skadapter__to_sklib_double(v.x);
  result.y := __skadapter__to_sklib_double(v.y);
  result.width := __skadapter__to_sklib_double(v.width);
  result.height := __skadapter__to_sklib_double(v.height);
end;
function __skadapter__to_rectangle(v: __sklib_rectangle): Rectangle;
begin
  result.x := __skadapter__to_double(v.x);
  result.y := __skadapter__to_double(v.y);
  result.width := __skadapter__to_double(v.width);
  result.height := __skadapter__to_double(v.height);
end;
function __skadapter__to_sklib_drawing_options(v: DrawingOptions): __sklib_drawing_options;
begin
  result.dest := __skadapter__to_sklib_ptr(v.dest);
  result.scaleX := __skadapter__to_sklib_float(v.scaleX);
  result.scaleY := __skadapter__to_sklib_float(v.scaleY);
  result.angle := __skadapter__to_sklib_float(v.angle);
  result.anchorOffsetX := __skadapter__to_sklib_float(v.anchorOffsetX);
  result.anchorOffsetY := __skadapter__to_sklib_float(v.anchorOffsetY);
  result.flipX := __skadapter__to_sklib_bool(v.flipX);
  result.flipY := __skadapter__to_sklib_bool(v.flipY);
  result.isPart := __skadapter__to_sklib_bool(v.isPart);
  result.part := __skadapter__to_sklib_rectangle(v.part);
  result.drawCell := __skadapter__to_sklib_int(v.drawCell);
  result.camera := __skadapter__to_sklib_drawing_dest(v.camera);
  result.lineWidth := __skadapter__to_sklib_int(v.lineWidth);
  result.anim := __skadapter__to_sklib_animation(v.anim);
end;
function __skadapter__to_drawing_options(v: __sklib_drawing_options): DrawingOptions;
begin
  result.dest := __skadapter__to_ptr(v.dest);
  result.scaleX := __skadapter__to_float(v.scaleX);
  result.scaleY := __skadapter__to_float(v.scaleY);
  result.angle := __skadapter__to_float(v.angle);
  result.anchorOffsetX := __skadapter__to_float(v.anchorOffsetX);
  result.anchorOffsetY := __skadapter__to_float(v.anchorOffsetY);
  result.flipX := __skadapter__to_bool(v.flipX);
  result.flipY := __skadapter__to_bool(v.flipY);
  result.isPart := __skadapter__to_bool(v.isPart);
  result.part := __skadapter__to_rectangle(v.part);
  result.drawCell := __skadapter__to_int(v.drawCell);
  result.camera := __skadapter__to_drawing_dest(v.camera);
  result.lineWidth := __skadapter__to_int(v.lineWidth);
  result.anim := __skadapter__to_animation(v.anim);
end;
function __skadapter__to_sklib_line(v: Line): __sklib_line;
begin
  result.startPoint := __skadapter__to_sklib_point_2d(v.startPoint);
  result.endPoint := __skadapter__to_sklib_point_2d(v.endPoint);
end;
function __skadapter__to_line(v: __sklib_line): Line;
begin
  result.startPoint := __skadapter__to_point_2d(v.startPoint);
  result.endPoint := __skadapter__to_point_2d(v.endPoint);
end;
function __skadapter__to_sklib_quad(v: Quad): __sklib_quad;
begin
  result.points[0] := __skadapter__to_sklib_point_2d(v.points[0]);
  result.points[1] := __skadapter__to_sklib_point_2d(v.points[1]);
  result.points[2] := __skadapter__to_sklib_point_2d(v.points[2]);
  result.points[3] := __skadapter__to_sklib_point_2d(v.points[3]);
end;
function __skadapter__to_quad(v: __sklib_quad): Quad;
begin
  result.points[0] := __skadapter__to_point_2d(v.points[0]);
  result.points[1] := __skadapter__to_point_2d(v.points[1]);
  result.points[2] := __skadapter__to_point_2d(v.points[2]);
  result.points[3] := __skadapter__to_point_2d(v.points[3]);
end;
function __skadapter__to_sklib_triangle(v: Triangle): __sklib_triangle;
begin
  result.points[0] := __skadapter__to_sklib_point_2d(v.points[0]);
  result.points[1] := __skadapter__to_sklib_point_2d(v.points[1]);
  result.points[2] := __skadapter__to_sklib_point_2d(v.points[2]);
end;
function __skadapter__to_triangle(v: __sklib_triangle): Triangle;
begin
  result.points[0] := __skadapter__to_point_2d(v.points[0]);
  result.points[1] := __skadapter__to_point_2d(v.points[1]);
  result.points[2] := __skadapter__to_point_2d(v.points[2]);
end;
function __skadapter__to_sklib_vector_2d(v: Vector2D): __sklib_vector_2d;
begin
  result.x := __skadapter__to_sklib_double(v.x);
  result.y := __skadapter__to_sklib_double(v.y);
end;
function __skadapter__to_vector_2d(v: __sklib_vector_2d): Vector2D;
begin
  result.x := __skadapter__to_double(v.x);
  result.y := __skadapter__to_double(v.y);
end;
type __sklib_vector_string = record
  data_from_app: Array of __sklib_string;
  size_from_app: Cardinal;
  data_from_lib: ^__sklib_string;
  size_from_lib: Cardinal;
end;
procedure __sklib__free__sklib_vector_string(v: __sklib_vector_string); cdecl; external;
procedure __skadapter__free__sklib_vector_string(var v: __sklib_vector_string);
var
  i: Integer;
begin
  for i := 0 to v.size_from_app - 1 do
  begin
      __skadapter__free__sklib_string(v.data_from_app[i]);
  end;
  SetLength(v.data_from_app, 0);
end;
function __skadapter__to_sklib_vector_string(const v: ArrayOfString): __sklib_vector_string;
var
    i: Integer;
begin
  result.size_from_lib := 0;
  result.data_from_lib := nil;
  result.size_from_app := Length(v);
  SetLength(result.data_from_app, Length(v));
  for i := 0 to High(v) do
  begin
    result.data_from_app[i] := __skadapter__to_sklib_string(v[i]);
  end;
end;
function __skadapter__to_vector_string(const v: __sklib_vector_string): ArrayOfString;
var
  i: Integer;
begin
  SetLength(result, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
    result[i] := __skadapter__to_string(v.data_from_lib[i]);
  end;
  __sklib__free__sklib_vector_string(v);
end;
procedure __skadapter__update_from_vector_string(var v: __sklib_vector_string; var __skreturn: ArrayOfString);
var
  i: Integer;
begin
  SetLength(__skreturn, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
      __skreturn[i] := __skadapter__to_string(v.data_from_lib[i]);
  end;
    __sklib__free__sklib_vector_string(v);
end;
type __sklib_vector_line = record
  data_from_app: Array of __sklib_line;
  size_from_app: Cardinal;
  data_from_lib: ^__sklib_line;
  size_from_lib: Cardinal;
end;
procedure __sklib__free__sklib_vector_line(v: __sklib_vector_line); cdecl; external;
procedure __skadapter__free__sklib_vector_line(var v: __sklib_vector_line);
begin
  SetLength(v.data_from_app, 0);
end;
function __skadapter__to_sklib_vector_line(const v: ArrayOfLine): __sklib_vector_line;
var
    i: Integer;
begin
  result.size_from_lib := 0;
  result.data_from_lib := nil;
  result.size_from_app := Length(v);
  SetLength(result.data_from_app, Length(v));
  for i := 0 to High(v) do
  begin
    result.data_from_app[i] := __skadapter__to_sklib_line(v[i]);
  end;
end;
function __skadapter__to_vector_line(const v: __sklib_vector_line): ArrayOfLine;
var
  i: Integer;
begin
  SetLength(result, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
    result[i] := __skadapter__to_line(v.data_from_lib[i]);
  end;
  __sklib__free__sklib_vector_line(v);
end;
procedure __skadapter__update_from_vector_line(var v: __sklib_vector_line; var __skreturn: ArrayOfLine);
var
  i: Integer;
begin
  SetLength(__skreturn, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
      __skreturn[i] := __skadapter__to_line(v.data_from_lib[i]);
  end;
    __sklib__free__sklib_vector_line(v);
end;
type __sklib_vector_int8_t = record
  data_from_app: Array of Char;
  size_from_app: Cardinal;
  data_from_lib: ^Char;
  size_from_lib: Cardinal;
end;
procedure __sklib__free__sklib_vector_int8_t(v: __sklib_vector_int8_t); cdecl; external;
procedure __skadapter__free__sklib_vector_int8_t(var v: __sklib_vector_int8_t);
begin
  SetLength(v.data_from_app, 0);
end;
function __skadapter__to_sklib_vector_int8_t(const v: ArrayOfChar): __sklib_vector_int8_t;
var
    i: Integer;
begin
  result.size_from_lib := 0;
  result.data_from_lib := nil;
  result.size_from_app := Length(v);
  SetLength(result.data_from_app, Length(v));
  for i := 0 to High(v) do
  begin
    result.data_from_app[i] := __skadapter__to_sklib_int8_t(v[i]);
  end;
end;
function __skadapter__to_vector_int8_t(const v: __sklib_vector_int8_t): ArrayOfChar;
var
  i: Integer;
begin
  SetLength(result, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
    result[i] := __skadapter__to_int8_t(v.data_from_lib[i]);
  end;
  __sklib__free__sklib_vector_int8_t(v);
end;
procedure __skadapter__update_from_vector_int8_t(var v: __sklib_vector_int8_t; var __skreturn: ArrayOfChar);
var
  i: Integer;
begin
  SetLength(__skreturn, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
      __skreturn[i] := __skadapter__to_int8_t(v.data_from_lib[i]);
  end;
    __sklib__free__sklib_vector_int8_t(v);
end;
type __sklib_vector_triangle = record
  data_from_app: Array of __sklib_triangle;
  size_from_app: Cardinal;
  data_from_lib: ^__sklib_triangle;
  size_from_lib: Cardinal;
end;
procedure __sklib__free__sklib_vector_triangle(v: __sklib_vector_triangle); cdecl; external;
procedure __skadapter__free__sklib_vector_triangle(var v: __sklib_vector_triangle);
begin
  SetLength(v.data_from_app, 0);
end;
function __skadapter__to_sklib_vector_triangle(const v: ArrayOfTriangle): __sklib_vector_triangle;
var
    i: Integer;
begin
  result.size_from_lib := 0;
  result.data_from_lib := nil;
  result.size_from_app := Length(v);
  SetLength(result.data_from_app, Length(v));
  for i := 0 to High(v) do
  begin
    result.data_from_app[i] := __skadapter__to_sklib_triangle(v[i]);
  end;
end;
function __skadapter__to_vector_triangle(const v: __sklib_vector_triangle): ArrayOfTriangle;
var
  i: Integer;
begin
  SetLength(result, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
    result[i] := __skadapter__to_triangle(v.data_from_lib[i]);
  end;
  __sklib__free__sklib_vector_triangle(v);
end;
procedure __skadapter__update_from_vector_triangle(var v: __sklib_vector_triangle; var __skreturn: ArrayOfTriangle);
var
  i: Integer;
begin
  SetLength(__skreturn, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
      __skreturn[i] := __skadapter__to_triangle(v.data_from_lib[i]);
  end;
    __sklib__free__sklib_vector_triangle(v);
end;
type __sklib_vector_double = record
  data_from_app: Array of Double;
  size_from_app: Cardinal;
  data_from_lib: ^Double;
  size_from_lib: Cardinal;
end;
procedure __sklib__free__sklib_vector_double(v: __sklib_vector_double); cdecl; external;
procedure __skadapter__free__sklib_vector_double(var v: __sklib_vector_double);
begin
  SetLength(v.data_from_app, 0);
end;
function __skadapter__to_sklib_vector_double(const v: ArrayOfDouble): __sklib_vector_double;
var
    i: Integer;
begin
  result.size_from_lib := 0;
  result.data_from_lib := nil;
  result.size_from_app := Length(v);
  SetLength(result.data_from_app, Length(v));
  for i := 0 to High(v) do
  begin
    result.data_from_app[i] := __skadapter__to_sklib_double(v[i]);
  end;
end;
function __skadapter__to_vector_double(const v: __sklib_vector_double): ArrayOfDouble;
var
  i: Integer;
begin
  SetLength(result, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
    result[i] := __skadapter__to_double(v.data_from_lib[i]);
  end;
  __sklib__free__sklib_vector_double(v);
end;
procedure __skadapter__update_from_vector_double(var v: __sklib_vector_double; var __skreturn: ArrayOfDouble);
var
  i: Integer;
begin
  SetLength(__skreturn, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
      __skreturn[i] := __skadapter__to_double(v.data_from_lib[i]);
  end;
    __sklib__free__sklib_vector_double(v);
end;
type __sklib_vector_json = record
  data_from_app: Array of __sklib_ptr;
  size_from_app: Cardinal;
  data_from_lib: ^__sklib_ptr;
  size_from_lib: Cardinal;
end;
procedure __sklib__free__sklib_vector_json(v: __sklib_vector_json); cdecl; external;
procedure __skadapter__free__sklib_vector_json(var v: __sklib_vector_json);
begin
  SetLength(v.data_from_app, 0);
end;
function __skadapter__to_sklib_vector_json(const v: ArrayOfJson): __sklib_vector_json;
var
    i: Integer;
begin
  result.size_from_lib := 0;
  result.data_from_lib := nil;
  result.size_from_app := Length(v);
  SetLength(result.data_from_app, Length(v));
  for i := 0 to High(v) do
  begin
    result.data_from_app[i] := __skadapter__to_sklib_json(v[i]);
  end;
end;
function __skadapter__to_vector_json(const v: __sklib_vector_json): ArrayOfJson;
var
  i: Integer;
begin
  SetLength(result, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
    result[i] := __skadapter__to_json(v.data_from_lib[i]);
  end;
  __sklib__free__sklib_vector_json(v);
end;
procedure __skadapter__update_from_vector_json(var v: __sklib_vector_json; var __skreturn: ArrayOfJson);
var
  i: Integer;
begin
  SetLength(__skreturn, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
      __skreturn[i] := __skadapter__to_json(v.data_from_lib[i]);
  end;
    __sklib__free__sklib_vector_json(v);
end;
type __sklib_vector_bool = record
  data_from_app: Array of LongInt;
  size_from_app: Cardinal;
  data_from_lib: ^LongInt;
  size_from_lib: Cardinal;
end;
procedure __sklib__free__sklib_vector_bool(v: __sklib_vector_bool); cdecl; external;
procedure __skadapter__free__sklib_vector_bool(var v: __sklib_vector_bool);
begin
  SetLength(v.data_from_app, 0);
end;
function __skadapter__to_sklib_vector_bool(const v: ArrayOfBoolean): __sklib_vector_bool;
var
    i: Integer;
begin
  result.size_from_lib := 0;
  result.data_from_lib := nil;
  result.size_from_app := Length(v);
  SetLength(result.data_from_app, Length(v));
  for i := 0 to High(v) do
  begin
    result.data_from_app[i] := __skadapter__to_sklib_bool(v[i]);
  end;
end;
function __skadapter__to_vector_bool(const v: __sklib_vector_bool): ArrayOfBoolean;
var
  i: Integer;
begin
  SetLength(result, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
    result[i] := __skadapter__to_bool(v.data_from_lib[i]);
  end;
  __sklib__free__sklib_vector_bool(v);
end;
procedure __skadapter__update_from_vector_bool(var v: __sklib_vector_bool; var __skreturn: ArrayOfBoolean);
var
  i: Integer;
begin
  SetLength(__skreturn, v.size_from_lib);
  for i := 0 to v.size_from_lib - 1 do
  begin
      __skreturn[i] := __skadapter__to_bool(v.data_from_lib[i]);
  end;
    __sklib__free__sklib_vector_bool(v);
end;
type __sklib_key_callback = KeyCallback;
function __skadapter__to_sklib_key_callback(v: KeyCallback): __sklib_key_callback;
begin
  result := v;
end;
type __sklib_free_notifier = FreeNotifier;
function __skadapter__to_sklib_free_notifier(v: FreeNotifier): __sklib_free_notifier;
begin
  result := v;
end;
type __sklib_sprite_event_handler = SpriteEventHandler;
function __skadapter__to_sklib_sprite_event_handler(v: SpriteEventHandler): __sklib_sprite_event_handler;
begin
  result := v;
end;
type __sklib_sprite_float_function = SpriteFloatFunction;
function __skadapter__to_sklib_sprite_float_function(v: SpriteFloatFunction): __sklib_sprite_float_function;
begin
  result := v;
end;
type __sklib_sprite_function = SpriteFunction;
function __skadapter__to_sklib_sprite_function(v: SpriteFunction): __sklib_sprite_function;
begin
  result := v;
end;
function __sklib__animation_count__animation_script(script: __sklib_ptr): Integer; cdecl; external;
function __sklib__animation_current_cell__animation(anim: __sklib_ptr): Integer; cdecl; external;
function __sklib__animation_current_vector__animation(anim: __sklib_ptr): __sklib_vector_2d; cdecl; external;
function __sklib__animation_ended__animation(anim: __sklib_ptr): LongInt; cdecl; external;
function __sklib__animation_entered_frame__animation(anim: __sklib_ptr): LongInt; cdecl; external;
function __sklib__animation_frame_time__animation(anim: __sklib_ptr): Single; cdecl; external;
function __sklib__animation_index__animation_script__string_ref(script: __sklib_ptr; const name: __sklib_string): Integer; cdecl; external;
function __sklib__animation_name__animation(temp: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__animation_script_name__animation_script(script: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__animation_script_named__string_ref(const name: __sklib_string): __sklib_ptr; cdecl; external;
procedure __sklib__assign_animation__animation__animation_script__string_ref(anim: __sklib_ptr; script: __sklib_ptr; const name: __sklib_string); cdecl; external;
procedure __sklib__assign_animation__animation__animation_script__string_ref__bool(anim: __sklib_ptr; script: __sklib_ptr; const name: __sklib_string; withSound: LongInt); cdecl; external;
procedure __sklib__assign_animation__animation__animation_script__int(anim: __sklib_ptr; script: __sklib_ptr; idx: Integer); cdecl; external;
procedure __sklib__assign_animation__animation__animation_script__int__bool(anim: __sklib_ptr; script: __sklib_ptr; idx: Integer; withSound: LongInt); cdecl; external;
procedure __sklib__assign_animation__animation__string_ref__string_ref(anim: __sklib_ptr; const scriptName: __sklib_string; const name: __sklib_string); cdecl; external;
procedure __sklib__assign_animation__animation__string_ref__string_ref__bool(anim: __sklib_ptr; const scriptName: __sklib_string; const name: __sklib_string; withSound: LongInt); cdecl; external;
procedure __sklib__assign_animation__animation__int(anim: __sklib_ptr; idx: Integer); cdecl; external;
procedure __sklib__assign_animation__animation__int__bool(anim: __sklib_ptr; idx: Integer; withSound: LongInt); cdecl; external;
procedure __sklib__assign_animation__animation__string(anim: __sklib_ptr; name: __sklib_string); cdecl; external;
procedure __sklib__assign_animation__animation__string__bool(anim: __sklib_ptr; name: __sklib_string; withSound: LongInt); cdecl; external;
function __sklib__create_animation__animation_script__int__bool(script: __sklib_ptr; idx: Integer; withSound: LongInt): __sklib_ptr; cdecl; external;
function __sklib__create_animation__animation_script__string_ref(script: __sklib_ptr; const name: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__create_animation__animation_script__string_ref__bool(script: __sklib_ptr; const name: __sklib_string; withSound: LongInt): __sklib_ptr; cdecl; external;
function __sklib__create_animation__string_ref__string_ref(const scriptName: __sklib_string; const name: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__create_animation__string_ref__string_ref__bool(const scriptName: __sklib_string; const name: __sklib_string; withSound: LongInt): __sklib_ptr; cdecl; external;
procedure __sklib__free_all_animation_scripts(); cdecl; external;
procedure __sklib__free_animation__animation(ani: __sklib_ptr); cdecl; external;
procedure __sklib__free_animation_script__animation_script(scriptToFree: __sklib_ptr); cdecl; external;
procedure __sklib__free_animation_script__string_ref(const name: __sklib_string); cdecl; external;
function __sklib__has_animation_named__animation_script__string_ref(script: __sklib_ptr; const name: __sklib_string): LongInt; cdecl; external;
function __sklib__has_animation_script__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__load_animation_script__string_ref__string_ref(const name: __sklib_string; const filename: __sklib_string): __sklib_ptr; cdecl; external;
procedure __sklib__restart_animation__animation(anim: __sklib_ptr); cdecl; external;
procedure __sklib__restart_animation__animation__bool(anim: __sklib_ptr; withSound: LongInt); cdecl; external;
procedure __sklib__update_animation__animation__float__bool(anim: __sklib_ptr; pct: Single; withSound: LongInt); cdecl; external;
procedure __sklib__update_animation__animation(anim: __sklib_ptr); cdecl; external;
procedure __sklib__update_animation__animation__float(anim: __sklib_ptr; pct: Single); cdecl; external;
function __sklib__audio_ready(): LongInt; cdecl; external;
procedure __sklib__close_audio(); cdecl; external;
procedure __sklib__open_audio(); cdecl; external;
function __sklib__contains__string_ref__string_ref(const text: __sklib_string; const subtext: __sklib_string): LongInt; cdecl; external;
function __sklib__convert_to_double__string_ref(const text: __sklib_string): Double; cdecl; external;
function __sklib__convert_to_integer__string_ref(const text: __sklib_string): Integer; cdecl; external;
function __sklib__index_of__string_ref__string_ref(const text: __sklib_string; const subtext: __sklib_string): Integer; cdecl; external;
function __sklib__is_double__string_ref(const text: __sklib_string): LongInt; cdecl; external;
function __sklib__is_integer__string_ref(const text: __sklib_string): LongInt; cdecl; external;
function __sklib__is_number__string_ref(const text: __sklib_string): LongInt; cdecl; external;
function __sklib__length_of__string_ref(const text: __sklib_string): Integer; cdecl; external;
function __sklib__replace_all__string_ref__string_ref__string_ref(const text: __sklib_string; const substr: __sklib_string; const newtext: __sklib_string): __sklib_string; cdecl; external;
function __sklib__split__string_ref__char(const text: __sklib_string; delimiter: Char): __sklib_vector_string; cdecl; external;
function __sklib__to_lowercase__string_ref(const text: __sklib_string): __sklib_string; cdecl; external;
function __sklib__to_uppercase__string_ref(const text: __sklib_string): __sklib_string; cdecl; external;
function __sklib__trim__string_ref(const text: __sklib_string): __sklib_string; cdecl; external;
procedure __sklib__free_resource_bundle__string(name: __sklib_string); cdecl; external;
function __sklib__has_resource_bundle__string_ref(const name: __sklib_string): LongInt; cdecl; external;
procedure __sklib__load_resource_bundle__string_ref__string_ref(const name: __sklib_string; const filename: __sklib_string); cdecl; external;
function __sklib__camera_position(): __sklib_point_2d; cdecl; external;
function __sklib__camera_x(): Double; cdecl; external;
function __sklib__camera_y(): Double; cdecl; external;
procedure __sklib__center_camera_on__sprite__vector_2d_ref(s: __sklib_ptr; const offset: __sklib_vector_2d); cdecl; external;
procedure __sklib__center_camera_on__sprite__double__double(s: __sklib_ptr; offsetX: Double; offsetY: Double); cdecl; external;
procedure __sklib__move_camera_by__vector_2d_ref(const offset: __sklib_vector_2d); cdecl; external;
procedure __sklib__move_camera_by__double__double(dx: Double; dy: Double); cdecl; external;
procedure __sklib__move_camera_to__point_2d_ref(const pt: __sklib_point_2d); cdecl; external;
procedure __sklib__move_camera_to__double__double(x: Double; y: Double); cdecl; external;
function __sklib__point_in_window__window__point_2d_ref(wind: __sklib_ptr; const pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__point_on_screen__point_2d_ref(const pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__rect_in_window__window__rectangle_ref(wind: __sklib_ptr; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__rect_on_screen__rectangle_ref(const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__screen_center(): __sklib_point_2d; cdecl; external;
function __sklib__screen_rectangle(): __sklib_rectangle; cdecl; external;
procedure __sklib__set_camera_position__point_2d(pos: __sklib_point_2d); cdecl; external;
procedure __sklib__set_camera_x__double(x: Double); cdecl; external;
procedure __sklib__set_camera_y__double(y: Double); cdecl; external;
function __sklib__to_screen__point_2d_ref(const pt: __sklib_point_2d): __sklib_point_2d; cdecl; external;
function __sklib__to_screen__rectangle_ref(const rect: __sklib_rectangle): __sklib_rectangle; cdecl; external;
function __sklib__to_screen_x__double(worldX: Double): Double; cdecl; external;
function __sklib__to_screen_y__double(worldY: Double): Double; cdecl; external;
function __sklib__to_world__point_2d_ref(const pt: __sklib_point_2d): __sklib_point_2d; cdecl; external;
function __sklib__to_world_x__double(screenX: Double): Double; cdecl; external;
function __sklib__to_world_y__double(screenY: Double): Double; cdecl; external;
function __sklib__vector_world_to_screen(): __sklib_vector_2d; cdecl; external;
function __sklib__window_area__window(wind: __sklib_ptr): __sklib_rectangle; cdecl; external;
procedure __sklib__draw_circle__color__circle_ref(clr: __sklib_color; const c: __sklib_circle); cdecl; external;
procedure __sklib__draw_circle__color__circle_ref__drawing_options(clr: __sklib_color; const c: __sklib_circle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_circle__color__double__double__double(clr: __sklib_color; x: Double; y: Double; radius: Double); cdecl; external;
procedure __sklib__draw_circle__color__double__double__double__drawing_options(clr: __sklib_color; x: Double; y: Double; radius: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_circle_on_bitmap__bitmap__color__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; radius: Double); cdecl; external;
procedure __sklib__draw_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; radius: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_circle_on_window__window__color__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; radius: Double); cdecl; external;
procedure __sklib__draw_circle_on_window__window__color__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; radius: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_circle__color__circle_ref(clr: __sklib_color; const c: __sklib_circle); cdecl; external;
procedure __sklib__fill_circle__color__circle_ref__drawing_options(clr: __sklib_color; const c: __sklib_circle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_circle__color__double__double__double(clr: __sklib_color; x: Double; y: Double; radius: Double); cdecl; external;
procedure __sklib__fill_circle__color__double__double__double__drawing_options(clr: __sklib_color; x: Double; y: Double; radius: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_circle_on_bitmap__bitmap__color__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; radius: Double); cdecl; external;
procedure __sklib__fill_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; radius: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_circle_on_window__window__color__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; radius: Double); cdecl; external;
procedure __sklib__fill_circle_on_window__window__color__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; radius: Double; opts: __sklib_drawing_options); cdecl; external;
function __sklib__center_point__circle_ref(const c: __sklib_circle): __sklib_point_2d; cdecl; external;
function __sklib__circle_at__point_2d_ref__double(const pt: __sklib_point_2d; radius: Double): __sklib_circle; cdecl; external;
function __sklib__circle_at__double__double__double(x: Double; y: Double; radius: Double): __sklib_circle; cdecl; external;
function __sklib__circle_radius__circle(c: __sklib_circle): Single; cdecl; external;
function __sklib__circle_triangle_intersect__circle_ref__triangle_ref(const c: __sklib_circle; const tri: __sklib_triangle): LongInt; cdecl; external;
function __sklib__circle_triangle_intersect__circle_ref__triangle_ref__point_2d_ref(const c: __sklib_circle; const tri: __sklib_triangle; var p: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__circle_x__circle_ref(const c: __sklib_circle): Single; cdecl; external;
function __sklib__circle_y__circle_ref(const c: __sklib_circle): Single; cdecl; external;
function __sklib__circles_intersect__circle__circle(c1: __sklib_circle; c2: __sklib_circle): LongInt; cdecl; external;
function __sklib__circles_intersect__double__double__double__double__double__double(c1X: Double; c1Y: Double; c1Radius: Double; c2X: Double; c2Y: Double; c2Radius: Double): LongInt; cdecl; external;
function __sklib__closest_point_on_circle__point_2d_ref__circle_ref(const fromPt: __sklib_point_2d; const c: __sklib_circle): __sklib_point_2d; cdecl; external;
function __sklib__closest_point_on_line_from_circle__circle_ref__line_ref(const c: __sklib_circle; const l: __sklib_line): __sklib_point_2d; cdecl; external;
function __sklib__closest_point_on_rect_from_circle__circle_ref__rectangle_ref(const c: __sklib_circle; const rect: __sklib_rectangle): __sklib_point_2d; cdecl; external;
function __sklib__closest_point_on_triangle_from_circle__circle_ref__triangle_ref(const c: __sklib_circle; const tri: __sklib_triangle): __sklib_point_2d; cdecl; external;
function __sklib__distant_point_on_circle__point_2d_ref__circle_ref(const pt: __sklib_point_2d; const c: __sklib_circle): __sklib_point_2d; cdecl; external;
function __sklib__distant_point_on_circle_heading__point_2d_ref__circle_ref__vector_2d_ref__point_2d_ref(const pt: __sklib_point_2d; const c: __sklib_circle; const heading: __sklib_vector_2d; var oppositePt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__ray_circle_intersect_distance__point_2d_ref__vector_2d_ref__circle_ref(const rayOrigin: __sklib_point_2d; const rayHeading: __sklib_vector_2d; const c: __sklib_circle): Single; cdecl; external;
function __sklib__tangent_points__point_2d_ref__circle_ref__point_2d_ref__point_2d_ref(const fromPt: __sklib_point_2d; const c: __sklib_circle; var p1: __sklib_point_2d; var p2: __sklib_point_2d): LongInt; cdecl; external;
procedure __sklib__widest_points__circle_ref__vector_2d_ref__point_2d_ref__point_2d_ref(const c: __sklib_circle; const along: __sklib_vector_2d; var pt1: __sklib_point_2d; var pt2: __sklib_point_2d); cdecl; external;
function __sklib__current_clip(): __sklib_rectangle; cdecl; external;
function __sklib__current_clip__bitmap(bmp: __sklib_ptr): __sklib_rectangle; cdecl; external;
function __sklib__current_clip__window(wnd: __sklib_ptr): __sklib_rectangle; cdecl; external;
procedure __sklib__pop_clip__window(wnd: __sklib_ptr); cdecl; external;
procedure __sklib__pop_clip(); cdecl; external;
procedure __sklib__pop_clip__bitmap(bmp: __sklib_ptr); cdecl; external;
procedure __sklib__push_clip__window__rectangle_ref(wnd: __sklib_ptr; const r: __sklib_rectangle); cdecl; external;
procedure __sklib__push_clip__bitmap__rectangle_ref(bmp: __sklib_ptr; const r: __sklib_rectangle); cdecl; external;
procedure __sklib__push_clip__rectangle_ref(const r: __sklib_rectangle); cdecl; external;
procedure __sklib__reset_clip__bitmap(bmp: __sklib_ptr); cdecl; external;
procedure __sklib__reset_clip(); cdecl; external;
procedure __sklib__reset_clip__window(wnd: __sklib_ptr); cdecl; external;
procedure __sklib__set_clip__rectangle_ref(const r: __sklib_rectangle); cdecl; external;
procedure __sklib__set_clip__bitmap__rectangle_ref(bmp: __sklib_ptr; const r: __sklib_rectangle); cdecl; external;
procedure __sklib__set_clip__window__rectangle_ref(wnd: __sklib_ptr; const r: __sklib_rectangle); cdecl; external;
function __sklib__bitmap_circle_collision__bitmap__point_2d_ref__circle_ref(bmp: __sklib_ptr; const pt: __sklib_point_2d; const circ: __sklib_circle): LongInt; cdecl; external;
function __sklib__bitmap_circle_collision__bitmap__double__double__circle_ref(bmp: __sklib_ptr; x: Double; y: Double; const circ: __sklib_circle): LongInt; cdecl; external;
function __sklib__bitmap_circle_collision__bitmap__int__matrix_2d_ref__circle_ref(bmp: __sklib_ptr; cell: Integer; const translation: __sklib_matrix_2d; const circ: __sklib_circle): LongInt; cdecl; external;
function __sklib__bitmap_circle_collision__bitmap__int__point_2d_ref__circle_ref(bmp: __sklib_ptr; cell: Integer; const pt: __sklib_point_2d; const circ: __sklib_circle): LongInt; cdecl; external;
function __sklib__bitmap_circle_collision__bitmap__int__double__double__circle_ref(bmp: __sklib_ptr; cell: Integer; x: Double; y: Double; const circ: __sklib_circle): LongInt; cdecl; external;
function __sklib__bitmap_collision__bitmap__double__double__bitmap__double__double(bmp1: __sklib_ptr; x1: Double; y1: Double; bmp2: __sklib_ptr; x2: Double; y2: Double): LongInt; cdecl; external;
function __sklib__bitmap_collision__bitmap__point_2d_ref__bitmap__point_2d_ref(bmp1: __sklib_ptr; const pt1: __sklib_point_2d; bmp2: __sklib_ptr; const pt2: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__bitmap_collision__bitmap__int__matrix_2d_ref__bitmap__int__matrix_2d_ref(bmp1: __sklib_ptr; cell1: Integer; const matrix1: __sklib_matrix_2d; bmp2: __sklib_ptr; cell2: Integer; const matrix2: __sklib_matrix_2d): LongInt; cdecl; external;
function __sklib__bitmap_collision__bitmap__int__point_2d_ref__bitmap__int__point_2d_ref(bmp1: __sklib_ptr; cell1: Integer; const pt1: __sklib_point_2d; bmp2: __sklib_ptr; cell2: Integer; const pt2: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__bitmap_collision__bitmap__int__double__double__bitmap__int__double__double(bmp1: __sklib_ptr; cell1: Integer; x1: Double; y1: Double; bmp2: __sklib_ptr; cell2: Integer; x2: Double; y2: Double): LongInt; cdecl; external;
function __sklib__bitmap_point_collision__bitmap__matrix_2d_ref__point_2d_ref(bmp: __sklib_ptr; const translation: __sklib_matrix_2d; const pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__bitmap_point_collision__bitmap__point_2d_ref__point_2d_ref(bmp: __sklib_ptr; const bmpPt: __sklib_point_2d; const pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__bitmap_point_collision__bitmap__double__double__double__double(bmp: __sklib_ptr; bmpX: Double; bmpY: Double; x: Double; y: Double): LongInt; cdecl; external;
function __sklib__bitmap_point_collision__bitmap__int__matrix_2d_ref__point_2d_ref(bmp: __sklib_ptr; cell: Integer; const translation: __sklib_matrix_2d; const pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__bitmap_point_collision__bitmap__int__point_2d_ref__point_2d_ref(bmp: __sklib_ptr; cell: Integer; const bmpPt: __sklib_point_2d; const pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__bitmap_point_collision__bitmap__int__double__double__double__double(bmp: __sklib_ptr; cell: Integer; bmpX: Double; bmpY: Double; x: Double; y: Double): LongInt; cdecl; external;
function __sklib__bitmap_rectangle_collision__bitmap__point_2d_ref__rectangle_ref(bmp: __sklib_ptr; const pt: __sklib_point_2d; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__bitmap_rectangle_collision__bitmap__double__double__rectangle_ref(bmp: __sklib_ptr; x: Double; y: Double; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__bitmap_rectangle_collision__bitmap__int__matrix_2d_ref__rectangle_ref(bmp: __sklib_ptr; cell: Integer; const translation: __sklib_matrix_2d; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__bitmap_rectangle_collision__bitmap__int__point_2d_ref__rectangle_ref(bmp: __sklib_ptr; cell: Integer; const pt: __sklib_point_2d; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__bitmap_rectangle_collision__bitmap__int__double__double__rectangle_ref(bmp: __sklib_ptr; cell: Integer; x: Double; y: Double; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__sprite_bitmap_collision__sprite__bitmap__double__double(s: __sklib_ptr; bmp: __sklib_ptr; x: Double; y: Double): LongInt; cdecl; external;
function __sklib__sprite_bitmap_collision__sprite__bitmap__int__point_2d_ref(s: __sklib_ptr; bmp: __sklib_ptr; cell: Integer; const pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__sprite_bitmap_collision__sprite__bitmap__int__double__double(s: __sklib_ptr; bmp: __sklib_ptr; cell: Integer; x: Double; y: Double): LongInt; cdecl; external;
function __sklib__sprite_collision__sprite__sprite(s1: __sklib_ptr; s2: __sklib_ptr): LongInt; cdecl; external;
function __sklib__sprite_point_collision__sprite__point_2d_ref(s: __sklib_ptr; const pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__sprite_rectangle_collision__sprite__rectangle_ref(s: __sklib_ptr; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__alpha_of__color(c: __sklib_color): Integer; cdecl; external;
function __sklib__blue_of__color(c: __sklib_color): Integer; cdecl; external;
function __sklib__brightness_of__color(c: __sklib_color): Double; cdecl; external;
function __sklib__color_alice_blue(): __sklib_color; cdecl; external;
function __sklib__color_antique_white(): __sklib_color; cdecl; external;
function __sklib__color_aqua(): __sklib_color; cdecl; external;
function __sklib__color_aquamarine(): __sklib_color; cdecl; external;
function __sklib__color_azure(): __sklib_color; cdecl; external;
function __sklib__color_beige(): __sklib_color; cdecl; external;
function __sklib__color_bisque(): __sklib_color; cdecl; external;
function __sklib__color_black(): __sklib_color; cdecl; external;
function __sklib__color_blanched_almond(): __sklib_color; cdecl; external;
function __sklib__color_blue(): __sklib_color; cdecl; external;
function __sklib__color_blue_violet(): __sklib_color; cdecl; external;
function __sklib__color_bright_green(): __sklib_color; cdecl; external;
function __sklib__color_brown(): __sklib_color; cdecl; external;
function __sklib__color_burly_wood(): __sklib_color; cdecl; external;
function __sklib__color_cadet_blue(): __sklib_color; cdecl; external;
function __sklib__color_chartreuse(): __sklib_color; cdecl; external;
function __sklib__color_chocolate(): __sklib_color; cdecl; external;
function __sklib__color_coral(): __sklib_color; cdecl; external;
function __sklib__color_cornflower_blue(): __sklib_color; cdecl; external;
function __sklib__color_cornsilk(): __sklib_color; cdecl; external;
function __sklib__color_crimson(): __sklib_color; cdecl; external;
function __sklib__color_cyan(): __sklib_color; cdecl; external;
function __sklib__color_dark_blue(): __sklib_color; cdecl; external;
function __sklib__color_dark_cyan(): __sklib_color; cdecl; external;
function __sklib__color_dark_goldenrod(): __sklib_color; cdecl; external;
function __sklib__color_dark_gray(): __sklib_color; cdecl; external;
function __sklib__color_dark_green(): __sklib_color; cdecl; external;
function __sklib__color_dark_khaki(): __sklib_color; cdecl; external;
function __sklib__color_dark_magenta(): __sklib_color; cdecl; external;
function __sklib__color_dark_olive_green(): __sklib_color; cdecl; external;
function __sklib__color_dark_orange(): __sklib_color; cdecl; external;
function __sklib__color_dark_orchid(): __sklib_color; cdecl; external;
function __sklib__color_dark_red(): __sklib_color; cdecl; external;
function __sklib__color_dark_salmon(): __sklib_color; cdecl; external;
function __sklib__color_dark_sea_green(): __sklib_color; cdecl; external;
function __sklib__color_dark_slate_blue(): __sklib_color; cdecl; external;
function __sklib__color_dark_slate_gray(): __sklib_color; cdecl; external;
function __sklib__color_dark_turquoise(): __sklib_color; cdecl; external;
function __sklib__color_dark_violet(): __sklib_color; cdecl; external;
function __sklib__color_deep_pink(): __sklib_color; cdecl; external;
function __sklib__color_deep_sky_blue(): __sklib_color; cdecl; external;
function __sklib__color_dim_gray(): __sklib_color; cdecl; external;
function __sklib__color_dodger_blue(): __sklib_color; cdecl; external;
function __sklib__color_firebrick(): __sklib_color; cdecl; external;
function __sklib__color_floral_white(): __sklib_color; cdecl; external;
function __sklib__color_forest_green(): __sklib_color; cdecl; external;
function __sklib__color_fuchsia(): __sklib_color; cdecl; external;
function __sklib__color_gainsboro(): __sklib_color; cdecl; external;
function __sklib__color_ghost_white(): __sklib_color; cdecl; external;
function __sklib__color_gold(): __sklib_color; cdecl; external;
function __sklib__color_goldenrod(): __sklib_color; cdecl; external;
function __sklib__color_gray(): __sklib_color; cdecl; external;
function __sklib__color_green(): __sklib_color; cdecl; external;
function __sklib__color_green_yellow(): __sklib_color; cdecl; external;
function __sklib__color_honeydew(): __sklib_color; cdecl; external;
function __sklib__color_hot_pink(): __sklib_color; cdecl; external;
function __sklib__color_indian_red(): __sklib_color; cdecl; external;
function __sklib__color_indigo(): __sklib_color; cdecl; external;
function __sklib__color_ivory(): __sklib_color; cdecl; external;
function __sklib__color_khaki(): __sklib_color; cdecl; external;
function __sklib__color_lavender(): __sklib_color; cdecl; external;
function __sklib__color_lavender_blush(): __sklib_color; cdecl; external;
function __sklib__color_lawn_green(): __sklib_color; cdecl; external;
function __sklib__color_lemon_chiffon(): __sklib_color; cdecl; external;
function __sklib__color_light_blue(): __sklib_color; cdecl; external;
function __sklib__color_light_coral(): __sklib_color; cdecl; external;
function __sklib__color_light_cyan(): __sklib_color; cdecl; external;
function __sklib__color_light_goldenrod_yellow(): __sklib_color; cdecl; external;
function __sklib__color_light_gray(): __sklib_color; cdecl; external;
function __sklib__color_light_green(): __sklib_color; cdecl; external;
function __sklib__color_light_pink(): __sklib_color; cdecl; external;
function __sklib__color_light_salmon(): __sklib_color; cdecl; external;
function __sklib__color_light_sea_green(): __sklib_color; cdecl; external;
function __sklib__color_light_sky_blue(): __sklib_color; cdecl; external;
function __sklib__color_light_slate_gray(): __sklib_color; cdecl; external;
function __sklib__color_light_steel_blue(): __sklib_color; cdecl; external;
function __sklib__color_light_yellow(): __sklib_color; cdecl; external;
function __sklib__color_lime(): __sklib_color; cdecl; external;
function __sklib__color_lime_green(): __sklib_color; cdecl; external;
function __sklib__color_linen(): __sklib_color; cdecl; external;
function __sklib__color_magenta(): __sklib_color; cdecl; external;
function __sklib__color_maroon(): __sklib_color; cdecl; external;
function __sklib__color_medium_aquamarine(): __sklib_color; cdecl; external;
function __sklib__color_medium_blue(): __sklib_color; cdecl; external;
function __sklib__color_medium_orchid(): __sklib_color; cdecl; external;
function __sklib__color_medium_purple(): __sklib_color; cdecl; external;
function __sklib__color_medium_sea_green(): __sklib_color; cdecl; external;
function __sklib__color_medium_slate_blue(): __sklib_color; cdecl; external;
function __sklib__color_medium_spring_green(): __sklib_color; cdecl; external;
function __sklib__color_medium_turquoise(): __sklib_color; cdecl; external;
function __sklib__color_medium_violet_red(): __sklib_color; cdecl; external;
function __sklib__color_midnight_blue(): __sklib_color; cdecl; external;
function __sklib__color_mint_cream(): __sklib_color; cdecl; external;
function __sklib__color_misty_rose(): __sklib_color; cdecl; external;
function __sklib__color_moccasin(): __sklib_color; cdecl; external;
function __sklib__color_navajo_white(): __sklib_color; cdecl; external;
function __sklib__color_navy(): __sklib_color; cdecl; external;
function __sklib__color_old_lace(): __sklib_color; cdecl; external;
function __sklib__color_olive(): __sklib_color; cdecl; external;
function __sklib__color_olive_drab(): __sklib_color; cdecl; external;
function __sklib__color_orange(): __sklib_color; cdecl; external;
function __sklib__color_orange_red(): __sklib_color; cdecl; external;
function __sklib__color_orchid(): __sklib_color; cdecl; external;
function __sklib__color_pale_goldenrod(): __sklib_color; cdecl; external;
function __sklib__color_pale_green(): __sklib_color; cdecl; external;
function __sklib__color_pale_turquoise(): __sklib_color; cdecl; external;
function __sklib__color_pale_violet_red(): __sklib_color; cdecl; external;
function __sklib__color_papaya_whip(): __sklib_color; cdecl; external;
function __sklib__color_peach_puff(): __sklib_color; cdecl; external;
function __sklib__color_peru(): __sklib_color; cdecl; external;
function __sklib__color_pink(): __sklib_color; cdecl; external;
function __sklib__color_plum(): __sklib_color; cdecl; external;
function __sklib__color_powder_blue(): __sklib_color; cdecl; external;
function __sklib__color_purple(): __sklib_color; cdecl; external;
function __sklib__color_red(): __sklib_color; cdecl; external;
function __sklib__color_rosy_brown(): __sklib_color; cdecl; external;
function __sklib__color_royal_blue(): __sklib_color; cdecl; external;
function __sklib__color_saddle_brown(): __sklib_color; cdecl; external;
function __sklib__color_salmon(): __sklib_color; cdecl; external;
function __sklib__color_sandy_brown(): __sklib_color; cdecl; external;
function __sklib__color_sea_green(): __sklib_color; cdecl; external;
function __sklib__color_sea_shell(): __sklib_color; cdecl; external;
function __sklib__color_sienna(): __sklib_color; cdecl; external;
function __sklib__color_silver(): __sklib_color; cdecl; external;
function __sklib__color_sky_blue(): __sklib_color; cdecl; external;
function __sklib__color_slate_blue(): __sklib_color; cdecl; external;
function __sklib__color_slate_gray(): __sklib_color; cdecl; external;
function __sklib__color_snow(): __sklib_color; cdecl; external;
function __sklib__color_spring_green(): __sklib_color; cdecl; external;
function __sklib__color_steel_blue(): __sklib_color; cdecl; external;
function __sklib__color_swinburne_red(): __sklib_color; cdecl; external;
function __sklib__color_tan(): __sklib_color; cdecl; external;
function __sklib__color_teal(): __sklib_color; cdecl; external;
function __sklib__color_thistle(): __sklib_color; cdecl; external;
function __sklib__color_to_string__color(c: __sklib_color): __sklib_string; cdecl; external;
function __sklib__color_tomato(): __sklib_color; cdecl; external;
function __sklib__color_transparent(): __sklib_color; cdecl; external;
function __sklib__color_turquoise(): __sklib_color; cdecl; external;
function __sklib__color_violet(): __sklib_color; cdecl; external;
function __sklib__color_wheat(): __sklib_color; cdecl; external;
function __sklib__color_white(): __sklib_color; cdecl; external;
function __sklib__color_white_smoke(): __sklib_color; cdecl; external;
function __sklib__color_yellow(): __sklib_color; cdecl; external;
function __sklib__color_yellow_green(): __sklib_color; cdecl; external;
function __sklib__green_of__color(c: __sklib_color): Integer; cdecl; external;
function __sklib__hsb_color__double__double__double(hue: Double; saturation: Double; brightness: Double): __sklib_color; cdecl; external;
function __sklib__hue_of__color(c: __sklib_color): Double; cdecl; external;
function __sklib__random_color(): __sklib_color; cdecl; external;
function __sklib__random_rgb_color__int(alpha: Integer): __sklib_color; cdecl; external;
function __sklib__red_of__color(c: __sklib_color): Integer; cdecl; external;
function __sklib__rgb_color__double__double__double(red: Double; green: Double; blue: Double): __sklib_color; cdecl; external;
function __sklib__rgb_color__int__int__int(red: Integer; green: Integer; blue: Integer): __sklib_color; cdecl; external;
function __sklib__rgba_color__double__double__double__double(red: Double; green: Double; blue: Double; alpha: Double): __sklib_color; cdecl; external;
function __sklib__rgba_color__int__int__int__int(red: Integer; green: Integer; blue: Integer; alpha: Integer): __sklib_color; cdecl; external;
function __sklib__saturation_of__color(c: __sklib_color): Double; cdecl; external;
function __sklib__string_to_color__string(str: __sklib_string): __sklib_color; cdecl; external;
function __sklib__option_defaults(): __sklib_drawing_options; cdecl; external;
function __sklib__option_draw_to__bitmap(dest: __sklib_ptr): __sklib_drawing_options; cdecl; external;
function __sklib__option_draw_to__bitmap__drawing_options(dest: __sklib_ptr; opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_draw_to__window(dest: __sklib_ptr): __sklib_drawing_options; cdecl; external;
function __sklib__option_draw_to__window__drawing_options(dest: __sklib_ptr; opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_flip_x(): __sklib_drawing_options; cdecl; external;
function __sklib__option_flip_x__drawing_options(opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_flip_xy(): __sklib_drawing_options; cdecl; external;
function __sklib__option_flip_xy__drawing_options(opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_flip_y(): __sklib_drawing_options; cdecl; external;
function __sklib__option_flip_y__drawing_options(opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_line_width__int(width: Integer): __sklib_drawing_options; cdecl; external;
function __sklib__option_line_width__int__drawing_options(width: Integer; opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_part_bmp__double__double__double__double(x: Double; y: Double; w: Double; h: Double): __sklib_drawing_options; cdecl; external;
function __sklib__option_part_bmp__double__double__double__double__drawing_options(x: Double; y: Double; w: Double; h: Double; opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_part_bmp__rectangle(part: __sklib_rectangle): __sklib_drawing_options; cdecl; external;
function __sklib__option_part_bmp__rectangle__drawing_options(part: __sklib_rectangle; opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_rotate_bmp__double(angle: Double): __sklib_drawing_options; cdecl; external;
function __sklib__option_rotate_bmp__double__double__double(angle: Double; anchorX: Double; anchorY: Double): __sklib_drawing_options; cdecl; external;
function __sklib__option_rotate_bmp__double__double__double__drawing_options(angle: Double; anchorX: Double; anchorY: Double; opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_rotate_bmp__double__drawing_options(angle: Double; opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_scale_bmp__double__double(scaleX: Double; scaleY: Double): __sklib_drawing_options; cdecl; external;
function __sklib__option_scale_bmp__double__double__drawing_options(scaleX: Double; scaleY: Double; opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_to_screen(): __sklib_drawing_options; cdecl; external;
function __sklib__option_to_screen__drawing_options(opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_to_world(): __sklib_drawing_options; cdecl; external;
function __sklib__option_to_world__drawing_options(opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_with_animation__animation(anim: __sklib_ptr): __sklib_drawing_options; cdecl; external;
function __sklib__option_with_animation__animation__drawing_options(anim: __sklib_ptr; opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
function __sklib__option_with_bitmap_cell__int(cell: Integer): __sklib_drawing_options; cdecl; external;
function __sklib__option_with_bitmap_cell__int__drawing_options(cell: Integer; opts: __sklib_drawing_options): __sklib_drawing_options; cdecl; external;
procedure __sklib__draw_ellipse__color__rectangle(clr: __sklib_color; rect: __sklib_rectangle); cdecl; external;
procedure __sklib__draw_ellipse__color__rectangle__drawing_options(clr: __sklib_color; rect: __sklib_rectangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_ellipse__color__double__double__double__double(clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__draw_ellipse__color__double__double__double__double__drawing_options(clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle(destination: __sklib_ptr; clr: __sklib_color; rect: __sklib_rectangle); cdecl; external;
procedure __sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(destination: __sklib_ptr; clr: __sklib_color; rect: __sklib_rectangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_ellipse_on_window__window__color__rectangle(destination: __sklib_ptr; clr: __sklib_color; rect: __sklib_rectangle); cdecl; external;
procedure __sklib__draw_ellipse_on_window__window__color__rectangle__drawing_options(destination: __sklib_ptr; clr: __sklib_color; rect: __sklib_rectangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_ellipse_on_window__window__color__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__draw_ellipse_on_window__window__color__double__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_ellipse__color__rectangle(clr: __sklib_color; rect: __sklib_rectangle); cdecl; external;
procedure __sklib__fill_ellipse__color__rectangle__drawing_options(clr: __sklib_color; rect: __sklib_rectangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_ellipse__color__double__double__double__double(clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__fill_ellipse__color__double__double__double__double__drawing_options(clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle(destination: __sklib_ptr; clr: __sklib_color; rect: __sklib_rectangle); cdecl; external;
procedure __sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(destination: __sklib_ptr; clr: __sklib_color; rect: __sklib_rectangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_ellipse_on_window__window__color__rectangle(destination: __sklib_ptr; clr: __sklib_color; rect: __sklib_rectangle); cdecl; external;
procedure __sklib__fill_ellipse_on_window__window__color__rectangle__drawing_options(destination: __sklib_ptr; clr: __sklib_color; rect: __sklib_rectangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_ellipse_on_window__window__color__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__fill_ellipse_on_window__window__color__double__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; opts: __sklib_drawing_options); cdecl; external;
function __sklib__cosine__float(degrees: Single): Single; cdecl; external;
function __sklib__sine__float(degrees: Single): Single; cdecl; external;
function __sklib__tangent__float(degrees: Single): Single; cdecl; external;
procedure __sklib__clear_screen(); cdecl; external;
procedure __sklib__clear_screen__color(clr: __sklib_color); cdecl; external;
function __sklib__display_details__unsigned_int(index: Cardinal): __sklib_ptr; cdecl; external;
function __sklib__display_height__display(disp: __sklib_ptr): Integer; cdecl; external;
function __sklib__display_name__display(disp: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__display_width__display(disp: __sklib_ptr): Integer; cdecl; external;
function __sklib__display_x__display(disp: __sklib_ptr): Integer; cdecl; external;
function __sklib__display_y__display(disp: __sklib_ptr): Integer; cdecl; external;
function __sklib__number_of_displays(): Integer; cdecl; external;
procedure __sklib__refresh_screen(); cdecl; external;
procedure __sklib__refresh_screen__unsigned_int(targetFps: Cardinal); cdecl; external;
procedure __sklib__save_bitmap__bitmap__string_ref(bmp: __sklib_ptr; const basename: __sklib_string); cdecl; external;
function __sklib__screen_height(): Integer; cdecl; external;
function __sklib__screen_width(): Integer; cdecl; external;
procedure __sklib__take_screenshot__string_ref(const basename: __sklib_string); cdecl; external;
procedure __sklib__take_screenshot__window__string_ref(wind: __sklib_ptr; const basename: __sklib_string); cdecl; external;
function __sklib__bitmap_bounding_circle__bitmap__point_2d_ref(bmp: __sklib_ptr; const pt: __sklib_point_2d): __sklib_circle; cdecl; external;
function __sklib__bitmap_bounding_rectangle__bitmap(bmp: __sklib_ptr): __sklib_rectangle; cdecl; external;
function __sklib__bitmap_bounding_rectangle__bitmap__double__double(bmp: __sklib_ptr; x: Double; y: Double): __sklib_rectangle; cdecl; external;
function __sklib__bitmap_cell_center__bitmap(bmp: __sklib_ptr): __sklib_point_2d; cdecl; external;
function __sklib__bitmap_cell_circle__bitmap__double__double(bmp: __sklib_ptr; x: Double; y: Double): __sklib_circle; cdecl; external;
function __sklib__bitmap_cell_circle__bitmap__point_2d(bmp: __sklib_ptr; pt: __sklib_point_2d): __sklib_circle; cdecl; external;
function __sklib__bitmap_cell_circle__bitmap__point_2d__double(bmp: __sklib_ptr; pt: __sklib_point_2d; scale: Double): __sklib_circle; cdecl; external;
function __sklib__bitmap_cell_columns__bitmap(bmp: __sklib_ptr): Integer; cdecl; external;
function __sklib__bitmap_cell_count__bitmap(bmp: __sklib_ptr): Integer; cdecl; external;
function __sklib__bitmap_cell_height__bitmap(bmp: __sklib_ptr): Integer; cdecl; external;
function __sklib__bitmap_cell_offset__bitmap__int(src: __sklib_ptr; cell: Integer): __sklib_vector_2d; cdecl; external;
function __sklib__bitmap_cell_rectangle__bitmap(src: __sklib_ptr): __sklib_rectangle; cdecl; external;
function __sklib__bitmap_cell_rectangle__bitmap__point_2d_ref(src: __sklib_ptr; const pt: __sklib_point_2d): __sklib_rectangle; cdecl; external;
function __sklib__bitmap_cell_rows__bitmap(bmp: __sklib_ptr): Integer; cdecl; external;
function __sklib__bitmap_cell_width__bitmap(bmp: __sklib_ptr): Integer; cdecl; external;
function __sklib__bitmap_center__bitmap(bmp: __sklib_ptr): __sklib_point_2d; cdecl; external;
function __sklib__bitmap_filename__bitmap(bmp: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__bitmap_height__bitmap(bmp: __sklib_ptr): Integer; cdecl; external;
function __sklib__bitmap_height__string(name: __sklib_string): Integer; cdecl; external;
function __sklib__bitmap_name__bitmap(bmp: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__bitmap_named__string(name: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__bitmap_rectangle_of_cell__bitmap__int(src: __sklib_ptr; cell: Integer): __sklib_rectangle; cdecl; external;
procedure __sklib__bitmap_set_cell_details__bitmap__int__int__int__int__int(bmp: __sklib_ptr; width: Integer; height: Integer; columns: Integer; rows: Integer; count: Integer); cdecl; external;
function __sklib__bitmap_valid__bitmap(bmp: __sklib_ptr): LongInt; cdecl; external;
function __sklib__bitmap_width__bitmap(bmp: __sklib_ptr): Integer; cdecl; external;
function __sklib__bitmap_width__string(name: __sklib_string): Integer; cdecl; external;
procedure __sklib__clear_bitmap__bitmap__color(bmp: __sklib_ptr; clr: __sklib_color); cdecl; external;
procedure __sklib__clear_bitmap__string__color(name: __sklib_string; clr: __sklib_color); cdecl; external;
function __sklib__create_bitmap__string__int__int(name: __sklib_string; width: Integer; height: Integer): __sklib_ptr; cdecl; external;
procedure __sklib__draw_bitmap__bitmap__double__double(bmp: __sklib_ptr; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_bitmap__bitmap__double__double__drawing_options(bmp: __sklib_ptr; x: Double; y: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_bitmap__string__double__double(name: __sklib_string; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_bitmap__string__double__double__drawing_options(name: __sklib_string; x: Double; y: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double(destination: __sklib_ptr; bmp: __sklib_ptr; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double__drawing_options(destination: __sklib_ptr; bmp: __sklib_ptr; x: Double; y: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_bitmap_on_window__window__bitmap__double__double(destination: __sklib_ptr; bmp: __sklib_ptr; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_bitmap_on_window__window__bitmap__double__double__drawing_options(destination: __sklib_ptr; bmp: __sklib_ptr; x: Double; y: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__free_all_bitmaps(); cdecl; external;
procedure __sklib__free_bitmap__bitmap(toDelete: __sklib_ptr); cdecl; external;
function __sklib__has_bitmap__string(name: __sklib_string): LongInt; cdecl; external;
function __sklib__load_bitmap__string__string(name: __sklib_string; filename: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__pixel_drawn_at_point__bitmap__point_2d_ref(bmp: __sklib_ptr; const pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__pixel_drawn_at_point__bitmap__double__double(bmp: __sklib_ptr; x: Double; y: Double): LongInt; cdecl; external;
function __sklib__pixel_drawn_at_point__bitmap__int__point_2d_ref(bmp: __sklib_ptr; cell: Integer; const pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__pixel_drawn_at_point__bitmap__int__double__double(bmp: __sklib_ptr; cell: Integer; x: Double; y: Double): LongInt; cdecl; external;
procedure __sklib__setup_collision_mask__bitmap(bmp: __sklib_ptr); cdecl; external;
procedure __sklib__process_events(); cdecl; external;
function __sklib__quit_requested(): LongInt; cdecl; external;
procedure __sklib__reset_quit(); cdecl; external;
procedure __sklib__add_column__int(width: Integer); cdecl; external;
procedure __sklib__add_column_relative__double(width: Double); cdecl; external;
function __sklib__bitmap_button__bitmap(bmp: __sklib_ptr): LongInt; cdecl; external;
function __sklib__bitmap_button__bitmap__rectangle_ref(bmp: __sklib_ptr; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__bitmap_button__bitmap__rectangle_ref__drawing_options(bmp: __sklib_ptr; const rect: __sklib_rectangle; opts: __sklib_drawing_options): LongInt; cdecl; external;
function __sklib__bitmap_button__bitmap__drawing_options(bmp: __sklib_ptr; opts: __sklib_drawing_options): LongInt; cdecl; external;
function __sklib__bitmap_button__string_ref__bitmap(const labelText: __sklib_string; bmp: __sklib_ptr): LongInt; cdecl; external;
function __sklib__bitmap_button__string_ref__bitmap__drawing_options(const labelText: __sklib_string; bmp: __sklib_ptr; opts: __sklib_drawing_options): LongInt; cdecl; external;
function __sklib__button__string_ref__rectangle_ref(const text: __sklib_string; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__button__string_ref(const text: __sklib_string): LongInt; cdecl; external;
function __sklib__button__string_ref__string_ref(const labelText: __sklib_string; const text: __sklib_string): LongInt; cdecl; external;
function __sklib__checkbox__string_ref__bool_ref__rectangle_ref(const text: __sklib_string; const value: LongInt; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__checkbox__string_ref__bool_ref(const text: __sklib_string; const value: LongInt): LongInt; cdecl; external;
function __sklib__checkbox__string_ref__string_ref__bool_ref(const labelText: __sklib_string; const text: __sklib_string; const value: LongInt): LongInt; cdecl; external;
function __sklib__color_slider__color_ref__rectangle_ref(const clr: __sklib_color; const rect: __sklib_rectangle): __sklib_color; cdecl; external;
function __sklib__color_slider__color_ref(const clr: __sklib_color): __sklib_color; cdecl; external;
function __sklib__color_slider__string_ref__color_ref(const labelText: __sklib_string; const clr: __sklib_color): __sklib_color; cdecl; external;
procedure __sklib__disable_interface(); cdecl; external;
procedure __sklib__draw_interface(); cdecl; external;
procedure __sklib__enable_interface(); cdecl; external;
procedure __sklib__end_inset__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__end_panel__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__end_popup__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__end_treenode__string_ref(const labelText: __sklib_string); cdecl; external;
procedure __sklib__enter_column(); cdecl; external;
function __sklib__get_interface_label_width(): Integer; cdecl; external;
function __sklib__header__string_ref(const labelText: __sklib_string): LongInt; cdecl; external;
function __sklib__hsb_color_slider__color_ref__rectangle_ref(const clr: __sklib_color; const rect: __sklib_rectangle): __sklib_color; cdecl; external;
function __sklib__hsb_color_slider__color_ref(const clr: __sklib_color): __sklib_color; cdecl; external;
function __sklib__hsb_color_slider__string_ref__color_ref(const labelText: __sklib_string; const clr: __sklib_color): __sklib_color; cdecl; external;
function __sklib__interface_enabled(): LongInt; cdecl; external;
procedure __sklib__interface_style_panel__rectangle_ref(const initialRectangle: __sklib_rectangle); cdecl; external;
procedure __sklib__label_element__string_ref(const text: __sklib_string); cdecl; external;
procedure __sklib__label_element__string_ref__rectangle_ref(const text: __sklib_string; const rect: __sklib_rectangle); cdecl; external;
function __sklib__last_element_changed(): LongInt; cdecl; external;
function __sklib__last_element_confirmed(): LongInt; cdecl; external;
procedure __sklib__leave_column(); cdecl; external;
function __sklib__number_box__float_ref__float__rectangle_ref(const value: Single; step: Single; const rect: __sklib_rectangle): Single; cdecl; external;
function __sklib__number_box__float_ref__float(const value: Single; step: Single): Single; cdecl; external;
function __sklib__number_box__string_ref__float_ref__float(const labelText: __sklib_string; const value: Single; step: Single): Single; cdecl; external;
procedure __sklib__open_popup__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__paragraph__string_ref(const text: __sklib_string); cdecl; external;
procedure __sklib__paragraph__string_ref__rectangle_ref(const text: __sklib_string; const rect: __sklib_rectangle); cdecl; external;
procedure __sklib__reset_layout(); cdecl; external;
procedure __sklib__set_interface_accent_color__color__float(clr: __sklib_color; contrast: Single); cdecl; external;
procedure __sklib__set_interface_border_color__color(clr: __sklib_color); cdecl; external;
procedure __sklib__set_interface_colors_auto__color__color__float__float__float(mainClr: __sklib_color; accentClr: __sklib_color; contrast: Single; accentContrast: Single; borderContrast: Single); cdecl; external;
procedure __sklib__set_interface_element_color__color__float(clr: __sklib_color; contrast: Single); cdecl; external;
procedure __sklib__set_interface_element_shadows__int__color__point_2d(radius: Integer; clr: __sklib_color; offset: __sklib_point_2d); cdecl; external;
procedure __sklib__set_interface_font__string_ref(const fnt: __sklib_string); cdecl; external;
procedure __sklib__set_interface_font__font(fnt: __sklib_ptr); cdecl; external;
procedure __sklib__set_interface_font_size__int(size: Integer); cdecl; external;
procedure __sklib__set_interface_label_width__int(width: Integer); cdecl; external;
procedure __sklib__set_interface_panel_shadows__int__color__point_2d(radius: Integer; clr: __sklib_color; offset: __sklib_point_2d); cdecl; external;
procedure __sklib__set_interface_root_text_color__color(clr: __sklib_color); cdecl; external;
procedure __sklib__set_interface_shadows__int__color__point_2d(radius: Integer; clr: __sklib_color; offset: __sklib_point_2d); cdecl; external;
procedure __sklib__set_interface_spacing__int__int(spacing: Integer; padding: Integer); cdecl; external;
procedure __sklib__set_interface_style__interface_style(style: LongInt); cdecl; external;
procedure __sklib__set_interface_style__interface_style__color(style: LongInt; clr: __sklib_color); cdecl; external;
procedure __sklib__set_interface_text_color__color(clr: __sklib_color); cdecl; external;
procedure __sklib__set_layout_height__int(height: Integer); cdecl; external;
procedure __sklib__single_line_layout(); cdecl; external;
function __sklib__slider__float_ref__float__float__rectangle_ref(const value: Single; minValue: Single; maxValue: Single; const rect: __sklib_rectangle): Single; cdecl; external;
function __sklib__slider__float_ref__float__float(const value: Single; minValue: Single; maxValue: Single): Single; cdecl; external;
function __sklib__slider__string_ref__float_ref__float__float(const labelText: __sklib_string; const value: Single; minValue: Single; maxValue: Single): Single; cdecl; external;
procedure __sklib__split_into_columns__int(count: Integer); cdecl; external;
procedure __sklib__split_into_columns__int__int(count: Integer; lastWidth: Integer); cdecl; external;
procedure __sklib__split_into_columns_relative__int__double(count: Integer; lastWidth: Double); cdecl; external;
procedure __sklib__start_custom_layout(); cdecl; external;
procedure __sklib__start_inset__string_ref__rectangle_ref(const name: __sklib_string; const rect: __sklib_rectangle); cdecl; external;
procedure __sklib__start_inset__string_ref__int(const name: __sklib_string; height: Integer); cdecl; external;
function __sklib__start_panel__string_ref__rectangle(const name: __sklib_string; initialRectangle: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__start_popup__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__start_treenode__string_ref(const labelText: __sklib_string): LongInt; cdecl; external;
function __sklib__text_box__string_ref(const value: __sklib_string): __sklib_string; cdecl; external;
function __sklib__text_box__string_ref__rectangle_ref(const value: __sklib_string; const rect: __sklib_rectangle): __sklib_string; cdecl; external;
function __sklib__text_box__string_ref__string_ref(const labelText: __sklib_string; const value: __sklib_string): __sklib_string; cdecl; external;
function __sklib__create_json(): __sklib_ptr; cdecl; external;
function __sklib__create_json__string(jsonString: __sklib_string): __sklib_ptr; cdecl; external;
procedure __sklib__free_all_json(); cdecl; external;
procedure __sklib__free_json__json(j: __sklib_ptr); cdecl; external;
function __sklib__json_count_keys__json(j: __sklib_ptr): Integer; cdecl; external;
function __sklib__json_from_color__color(clr: __sklib_color): __sklib_ptr; cdecl; external;
function __sklib__json_from_file__string_ref(const filename: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__json_from_string__string_ref(const jString: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__json_has_key__json__string(j: __sklib_ptr; key: __sklib_string): LongInt; cdecl; external;
procedure __sklib__json_read_array__json__string__vector_double_ref(j: __sklib_ptr; key: __sklib_string; var outResult: __sklib_vector_double); cdecl; external;
procedure __sklib__json_read_array__json__string__vector_json_ref(j: __sklib_ptr; key: __sklib_string; var outResult: __sklib_vector_json); cdecl; external;
procedure __sklib__json_read_array__json__string__vector_string_ref(j: __sklib_ptr; key: __sklib_string; var outResult: __sklib_vector_string); cdecl; external;
procedure __sklib__json_read_array__json__string__vector_bool_ref(j: __sklib_ptr; key: __sklib_string; var outResult: __sklib_vector_bool); cdecl; external;
function __sklib__json_read_bool__json__string(j: __sklib_ptr; key: __sklib_string): LongInt; cdecl; external;
function __sklib__json_read_number__json__string(j: __sklib_ptr; key: __sklib_string): Single; cdecl; external;
function __sklib__json_read_number_as_double__json__string(j: __sklib_ptr; key: __sklib_string): Double; cdecl; external;
function __sklib__json_read_number_as_int__json__string(j: __sklib_ptr; key: __sklib_string): Integer; cdecl; external;
function __sklib__json_read_object__json__string(j: __sklib_ptr; key: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__json_read_string__json__string(j: __sklib_ptr; key: __sklib_string): __sklib_string; cdecl; external;
procedure __sklib__json_set_array__json__string__vector_string(j: __sklib_ptr; key: __sklib_string; value: __sklib_vector_string); cdecl; external;
procedure __sklib__json_set_array__json__string__vector_double(j: __sklib_ptr; key: __sklib_string; value: __sklib_vector_double); cdecl; external;
procedure __sklib__json_set_array__json__string__vector_bool(j: __sklib_ptr; key: __sklib_string; value: __sklib_vector_bool); cdecl; external;
procedure __sklib__json_set_array__json__string__vector_json(j: __sklib_ptr; key: __sklib_string; value: __sklib_vector_json); cdecl; external;
procedure __sklib__json_set_bool__json__string__bool(j: __sklib_ptr; key: __sklib_string; value: LongInt); cdecl; external;
procedure __sklib__json_set_number__json__string__int(j: __sklib_ptr; key: __sklib_string; value: Integer); cdecl; external;
procedure __sklib__json_set_number__json__string__double(j: __sklib_ptr; key: __sklib_string; value: Double); cdecl; external;
procedure __sklib__json_set_number__json__string__float(j: __sklib_ptr; key: __sklib_string; value: Single); cdecl; external;
procedure __sklib__json_set_object__json__string__json(j: __sklib_ptr; key: __sklib_string; obj: __sklib_ptr); cdecl; external;
procedure __sklib__json_set_string__json__string__string(j: __sklib_ptr; key: __sklib_string; value: __sklib_string); cdecl; external;
function __sklib__json_to_color__json(j: __sklib_ptr): __sklib_color; cdecl; external;
procedure __sklib__json_to_file__json__string_ref(j: __sklib_ptr; const filename: __sklib_string); cdecl; external;
function __sklib__json_to_string__json(j: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__any_key_pressed(): LongInt; cdecl; external;
procedure __sklib__deregister_callback_on_key_down__key_callback_ptr(callback: KeyCallback); cdecl; external;
procedure __sklib__deregister_callback_on_key_typed__key_callback_ptr(callback: KeyCallback); cdecl; external;
procedure __sklib__deregister_callback_on_key_up__key_callback_ptr(callback: KeyCallback); cdecl; external;
function __sklib__key_down__key_code(key: LongInt): LongInt; cdecl; external;
function __sklib__key_name__key_code(key: LongInt): __sklib_string; cdecl; external;
function __sklib__key_released__key_code(key: LongInt): LongInt; cdecl; external;
function __sklib__key_typed__key_code(key: LongInt): LongInt; cdecl; external;
function __sklib__key_up__key_code(key: LongInt): LongInt; cdecl; external;
procedure __sklib__register_callback_on_key_down__key_callback_ptr(callback: KeyCallback); cdecl; external;
procedure __sklib__register_callback_on_key_typed__key_callback_ptr(callback: KeyCallback); cdecl; external;
procedure __sklib__register_callback_on_key_up__key_callback_ptr(callback: KeyCallback); cdecl; external;
procedure __sklib__draw_line__color__line_ref(clr: __sklib_color; const l: __sklib_line); cdecl; external;
procedure __sklib__draw_line__color__line_ref__drawing_options(clr: __sklib_color; const l: __sklib_line; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_line__color__point_2d_ref__point_2d_ref(clr: __sklib_color; const fromPt: __sklib_point_2d; const toPt: __sklib_point_2d); cdecl; external;
procedure __sklib__draw_line__color__point_2d_ref__point_2d_ref__drawing_options_ref(clr: __sklib_color; const fromPt: __sklib_point_2d; const toPt: __sklib_point_2d; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_line__color__double__double__double__double(clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double); cdecl; external;
procedure __sklib__draw_line__color__double__double__double__double__drawing_options_ref(clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_line_on_bitmap__bitmap__color__line_ref(destination: __sklib_ptr; clr: __sklib_color; const l: __sklib_line); cdecl; external;
procedure __sklib__draw_line_on_bitmap__bitmap__color__line_ref__drawing_options(destination: __sklib_ptr; clr: __sklib_color; const l: __sklib_line; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref(destination: __sklib_ptr; clr: __sklib_color; const fromPt: __sklib_point_2d; const toPt: __sklib_point_2d); cdecl; external;
procedure __sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; const fromPt: __sklib_point_2d; const toPt: __sklib_point_2d; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double); cdecl; external;
procedure __sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_line_on_window__window__color__line_ref(destination: __sklib_ptr; clr: __sklib_color; const l: __sklib_line); cdecl; external;
procedure __sklib__draw_line_on_window__window__color__line_ref__drawing_options(destination: __sklib_ptr; clr: __sklib_color; const l: __sklib_line; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref(destination: __sklib_ptr; clr: __sklib_color; const fromPt: __sklib_point_2d; const toPt: __sklib_point_2d); cdecl; external;
procedure __sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; const fromPt: __sklib_point_2d; const toPt: __sklib_point_2d; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_line_on_window__window__color__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double); cdecl; external;
procedure __sklib__draw_line_on_window__window__color__double__double__double__double__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; const opts: __sklib_drawing_options); cdecl; external;
function __sklib__closest_point_on_line__point_2d__line_ref(fromPt: __sklib_point_2d; const l: __sklib_line): __sklib_point_2d; cdecl; external;
function __sklib__closest_point_on_lines__point_2d__vector_line_ref__int_ref(fromPt: __sklib_point_2d; const lines: __sklib_vector_line; var lineIdx: Integer): __sklib_point_2d; cdecl; external;
function __sklib__line_from__point_2d_ref__point_2d_ref(const start: __sklib_point_2d; const endPt: __sklib_point_2d): __sklib_line; cdecl; external;
function __sklib__line_from__point_2d_ref__vector_2d_ref(const start: __sklib_point_2d; const offset: __sklib_vector_2d): __sklib_line; cdecl; external;
function __sklib__line_from__vector_2d_ref(const v: __sklib_vector_2d): __sklib_line; cdecl; external;
function __sklib__line_from__double__double__double__double(x1: Double; y1: Double; x2: Double; y2: Double): __sklib_line; cdecl; external;
function __sklib__line_intersection_point__line_ref__line_ref__point_2d_ref(const line1: __sklib_line; const line2: __sklib_line; var pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__line_intersects_circle__line_ref__circle_ref(const l: __sklib_line; const c: __sklib_circle): LongInt; cdecl; external;
function __sklib__line_intersects_lines__line_ref__vector_line_ref(const l: __sklib_line; const lines: __sklib_vector_line): LongInt; cdecl; external;
function __sklib__line_intersects_rect__line_ref__rectangle_ref(const l: __sklib_line; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__line_length__line_ref(const l: __sklib_line): Single; cdecl; external;
function __sklib__line_length_squared__line_ref(const l: __sklib_line): Single; cdecl; external;
function __sklib__line_mid_point__line_ref(const l: __sklib_line): __sklib_point_2d; cdecl; external;
function __sklib__line_normal__line_ref(const l: __sklib_line): __sklib_vector_2d; cdecl; external;
function __sklib__line_to_string__line_ref(const ln: __sklib_line): __sklib_string; cdecl; external;
function __sklib__lines_from__rectangle_ref(const rect: __sklib_rectangle): __sklib_vector_line; cdecl; external;
function __sklib__lines_from__triangle_ref(const t: __sklib_triangle): __sklib_vector_line; cdecl; external;
function __sklib__lines_intersect__line_ref__line_ref(const l1: __sklib_line; const l2: __sklib_line): LongInt; cdecl; external;
procedure __sklib__close_log_process(); cdecl; external;
procedure __sklib__init_custom_logger__log_mode(mode: LongInt); cdecl; external;
procedure __sklib__init_custom_logger__string__bool__log_mode(appName: __sklib_string; overridePrevLog: LongInt; mode: LongInt); cdecl; external;
procedure __sklib__log__log_level__string(level: LongInt; message: __sklib_string); cdecl; external;
procedure __sklib__apply_matrix__matrix_2d_ref__quad_ref(const matrix: __sklib_matrix_2d; var q: __sklib_quad); cdecl; external;
procedure __sklib__apply_matrix__matrix_2d_ref__triangle_ref(const m: __sklib_matrix_2d; var tri: __sklib_triangle); cdecl; external;
function __sklib__identity_matrix(): __sklib_matrix_2d; cdecl; external;
function __sklib__matrix_inverse__matrix_2d_ref(const m: __sklib_matrix_2d): __sklib_matrix_2d; cdecl; external;
function __sklib__matrix_multiply__matrix_2d_ref__point_2d_ref(const m: __sklib_matrix_2d; const pt: __sklib_point_2d): __sklib_point_2d; cdecl; external;
function __sklib__matrix_multiply__matrix_2d_ref__matrix_2d_ref(const m1: __sklib_matrix_2d; const m2: __sklib_matrix_2d): __sklib_matrix_2d; cdecl; external;
function __sklib__matrix_multiply__matrix_2d_ref__vector_2d_ref(const m: __sklib_matrix_2d; const v: __sklib_vector_2d): __sklib_vector_2d; cdecl; external;
function __sklib__matrix_to_string__matrix_2d_ref(const matrix: __sklib_matrix_2d): __sklib_string; cdecl; external;
function __sklib__rotation_matrix__double(deg: Double): __sklib_matrix_2d; cdecl; external;
function __sklib__scale_matrix__point_2d_ref(const scale: __sklib_point_2d): __sklib_matrix_2d; cdecl; external;
function __sklib__scale_matrix__vector_2d_ref(const scale: __sklib_vector_2d): __sklib_matrix_2d; cdecl; external;
function __sklib__scale_matrix__double(scale: Double): __sklib_matrix_2d; cdecl; external;
function __sklib__scale_rotate_translate_matrix__point_2d_ref__double__point_2d_ref(const scale: __sklib_point_2d; deg: Double; const translate: __sklib_point_2d): __sklib_matrix_2d; cdecl; external;
function __sklib__translation_matrix__point_2d_ref(const pt: __sklib_point_2d): __sklib_matrix_2d; cdecl; external;
function __sklib__translation_matrix__vector_2d_ref(const pt: __sklib_vector_2d): __sklib_matrix_2d; cdecl; external;
function __sklib__translation_matrix__double__double(dx: Double; dy: Double): __sklib_matrix_2d; cdecl; external;
procedure __sklib__hide_mouse(); cdecl; external;
function __sklib__mouse_clicked__mouse_button(button: LongInt): LongInt; cdecl; external;
function __sklib__mouse_down__mouse_button(button: LongInt): LongInt; cdecl; external;
function __sklib__mouse_movement(): __sklib_vector_2d; cdecl; external;
function __sklib__mouse_position(): __sklib_point_2d; cdecl; external;
function __sklib__mouse_position_vector(): __sklib_vector_2d; cdecl; external;
function __sklib__mouse_shown(): LongInt; cdecl; external;
function __sklib__mouse_up__mouse_button(button: LongInt): LongInt; cdecl; external;
function __sklib__mouse_wheel_scroll(): __sklib_vector_2d; cdecl; external;
function __sklib__mouse_x(): Single; cdecl; external;
function __sklib__mouse_y(): Single; cdecl; external;
procedure __sklib__move_mouse__double__double(x: Double; y: Double); cdecl; external;
procedure __sklib__move_mouse__point_2d(point: __sklib_point_2d); cdecl; external;
procedure __sklib__show_mouse(); cdecl; external;
procedure __sklib__show_mouse__bool(show: LongInt); cdecl; external;
procedure __sklib__fade_music_in__string_ref__int(const name: __sklib_string; ms: Integer); cdecl; external;
procedure __sklib__fade_music_in__string_ref__int__int(const name: __sklib_string; times: Integer; ms: Integer); cdecl; external;
procedure __sklib__fade_music_in__music__int(data: __sklib_ptr; ms: Integer); cdecl; external;
procedure __sklib__fade_music_in__music__int__int(data: __sklib_ptr; times: Integer; ms: Integer); cdecl; external;
procedure __sklib__fade_music_out__int(ms: Integer); cdecl; external;
procedure __sklib__free_all_music(); cdecl; external;
procedure __sklib__free_music__music(effect: __sklib_ptr); cdecl; external;
function __sklib__has_music__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__load_music__string_ref__string_ref(const name: __sklib_string; const filename: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__music_filename__music(data: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__music_name__music(data: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__music_named__string_ref(const name: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__music_playing(): LongInt; cdecl; external;
function __sklib__music_valid__music(m: __sklib_ptr): LongInt; cdecl; external;
function __sklib__music_volume(): Double; cdecl; external;
procedure __sklib__pause_music(); cdecl; external;
procedure __sklib__play_music__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__play_music__string_ref__int(const name: __sklib_string; times: Integer); cdecl; external;
procedure __sklib__play_music__music(data: __sklib_ptr); cdecl; external;
procedure __sklib__play_music__music__int(data: __sklib_ptr; times: Integer); cdecl; external;
procedure __sklib__play_music__music__int__double(data: __sklib_ptr; times: Integer; volume: Double); cdecl; external;
procedure __sklib__resume_music(); cdecl; external;
procedure __sklib__set_music_volume__double(volume: Double); cdecl; external;
procedure __sklib__stop_music(); cdecl; external;
function __sklib__accept_all_new_connections(): LongInt; cdecl; external;
function __sklib__accept_new_connection__server_socket(server: __sklib_ptr): LongInt; cdecl; external;
procedure __sklib__broadcast_message__string_ref__server_socket(const aMsg: __sklib_string; svr: __sklib_ptr); cdecl; external;
procedure __sklib__broadcast_message__string_ref(const aMsg: __sklib_string); cdecl; external;
procedure __sklib__broadcast_message__string_ref__string_ref(const aMsg: __sklib_string; const name: __sklib_string); cdecl; external;
procedure __sklib__check_network_activity(); cdecl; external;
procedure __sklib__clear_messages__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__clear_messages__connection(aConnection: __sklib_ptr); cdecl; external;
procedure __sklib__clear_messages__server_socket(svr: __sklib_ptr); cdecl; external;
procedure __sklib__close_all_connections(); cdecl; external;
procedure __sklib__close_all_servers(); cdecl; external;
function __sklib__close_connection__connection(aConnection: __sklib_ptr): LongInt; cdecl; external;
function __sklib__close_connection__string_ref(const name: __sklib_string): LongInt; cdecl; external;
procedure __sklib__close_message__message(msg: __sklib_ptr); cdecl; external;
function __sklib__close_server__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__close_server__server_socket(svr: __sklib_ptr): LongInt; cdecl; external;
function __sklib__connection_count__string_ref(const name: __sklib_string): Cardinal; cdecl; external;
function __sklib__connection_count__server_socket(server: __sklib_ptr): Cardinal; cdecl; external;
function __sklib__connection_ip__connection(aConnection: __sklib_ptr): Cardinal; cdecl; external;
function __sklib__connection_ip__string_ref(const name: __sklib_string): Cardinal; cdecl; external;
function __sklib__connection_named__string_ref(const name: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__connection_port__connection(aConnection: __sklib_ptr): Word; cdecl; external;
function __sklib__connection_port__string_ref(const name: __sklib_string): Word; cdecl; external;
function __sklib__create_server__string_ref__unsigned_short(const name: __sklib_string; port: Word): __sklib_ptr; cdecl; external;
function __sklib__create_server__string_ref__unsigned_short__connection_type(const name: __sklib_string; port: Word; protocol: LongInt): __sklib_ptr; cdecl; external;
function __sklib__dec_to_hex__unsigned_int(aDec: Cardinal): __sklib_string; cdecl; external;
function __sklib__fetch_new_connection__server_socket(server: __sklib_ptr): __sklib_ptr; cdecl; external;
function __sklib__has_connection__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__has_messages(): LongInt; cdecl; external;
function __sklib__has_messages__connection(con: __sklib_ptr): LongInt; cdecl; external;
function __sklib__has_messages__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__has_messages__server_socket(svr: __sklib_ptr): LongInt; cdecl; external;
function __sklib__has_new_connections(): LongInt; cdecl; external;
function __sklib__has_server__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__hex_str_to_ipv4__string_ref(const aHex: __sklib_string): __sklib_string; cdecl; external;
function __sklib__hex_to_dec_string__string_ref(const aHex: __sklib_string): __sklib_string; cdecl; external;
function __sklib__ipv4_to_dec__string_ref(const aIP: __sklib_string): Cardinal; cdecl; external;
function __sklib__ipv4_to_hex__string_ref(const aIP: __sklib_string): __sklib_string; cdecl; external;
function __sklib__ipv4_to_str__unsigned_int(ip: Cardinal): __sklib_string; cdecl; external;
function __sklib__is_connection_open__connection(con: __sklib_ptr): LongInt; cdecl; external;
function __sklib__is_connection_open__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__last_connection__string_ref(const name: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__last_connection__server_socket(server: __sklib_ptr): __sklib_ptr; cdecl; external;
function __sklib__message_connection__message(msg: __sklib_ptr): __sklib_ptr; cdecl; external;
function __sklib__message_count__server_socket(svr: __sklib_ptr): Cardinal; cdecl; external;
function __sklib__message_count__connection(aConnection: __sklib_ptr): Cardinal; cdecl; external;
function __sklib__message_count__string_ref(const name: __sklib_string): Cardinal; cdecl; external;
function __sklib__message_data__message(msg: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__message_data_bytes__message(msg: __sklib_ptr): __sklib_vector_int8_t; cdecl; external;
function __sklib__message_host__message(msg: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__message_port__message(msg: __sklib_ptr): Word; cdecl; external;
function __sklib__message_protocol__message(msg: __sklib_ptr): LongInt; cdecl; external;
function __sklib__my_ip(): __sklib_string; cdecl; external;
function __sklib__name_for_connection__string__unsigned_int(host: __sklib_string; port: Cardinal): __sklib_string; cdecl; external;
function __sklib__new_connection_count__server_socket(server: __sklib_ptr): Integer; cdecl; external;
function __sklib__open_connection__string_ref__string_ref__unsigned_short(const name: __sklib_string; const host: __sklib_string; port: Word): __sklib_ptr; cdecl; external;
function __sklib__open_connection__string_ref__string_ref__unsigned_short__connection_type(const name: __sklib_string; const host: __sklib_string; port: Word; protocol: LongInt): __sklib_ptr; cdecl; external;
function __sklib__read_message(): __sklib_ptr; cdecl; external;
function __sklib__read_message__connection(aConnection: __sklib_ptr): __sklib_ptr; cdecl; external;
function __sklib__read_message__string_ref(const name: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__read_message__server_socket(svr: __sklib_ptr): __sklib_ptr; cdecl; external;
function __sklib__read_message_data__string_ref(const name: __sklib_string): __sklib_string; cdecl; external;
function __sklib__read_message_data__connection(aConnection: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__read_message_data__server_socket(svr: __sklib_ptr): __sklib_string; cdecl; external;
procedure __sklib__reconnect__connection(aConnection: __sklib_ptr); cdecl; external;
procedure __sklib__reconnect__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__release_all_connections(); cdecl; external;
procedure __sklib__reset_new_connection_count__server_socket(server: __sklib_ptr); cdecl; external;
function __sklib__retrieve_connection__string_ref__int(const name: __sklib_string; idx: Integer): __sklib_ptr; cdecl; external;
function __sklib__retrieve_connection__server_socket__int(server: __sklib_ptr; idx: Integer): __sklib_ptr; cdecl; external;
function __sklib__send_message_to__string_ref__connection(const aMsg: __sklib_string; aConnection: __sklib_ptr): LongInt; cdecl; external;
function __sklib__send_message_to__string_ref__string_ref(const aMsg: __sklib_string; const name: __sklib_string): LongInt; cdecl; external;
function __sklib__server_has_new_connection__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__server_has_new_connection__server_socket(server: __sklib_ptr): LongInt; cdecl; external;
function __sklib__server_named__string_ref(const name: __sklib_string): __sklib_ptr; cdecl; external;
procedure __sklib__set_udp_packet_size__unsigned_int(udpPacketSize: Cardinal); cdecl; external;
function __sklib__udp_packet_size(): Cardinal; cdecl; external;
procedure __sklib__draw_pixel__color__point_2d_ref(clr: __sklib_color; const pt: __sklib_point_2d); cdecl; external;
procedure __sklib__draw_pixel__color__point_2d_ref__drawing_options(clr: __sklib_color; const pt: __sklib_point_2d; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_pixel__color__double__double(clr: __sklib_color; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_pixel__color__double__double__drawing_options(clr: __sklib_color; x: Double; y: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref(destination: __sklib_ptr; clr: __sklib_color; const pt: __sklib_point_2d); cdecl; external;
procedure __sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref__drawing_options(destination: __sklib_ptr; clr: __sklib_color; const pt: __sklib_point_2d; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_pixel_on_bitmap__bitmap__color__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_pixel_on_bitmap__bitmap__color__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_pixel_on_window__window__color__point_2d_ref(destination: __sklib_ptr; clr: __sklib_color; const pt: __sklib_point_2d); cdecl; external;
procedure __sklib__draw_pixel_on_window__window__color__point_2d_ref__drawing_options(destination: __sklib_ptr; clr: __sklib_color; const pt: __sklib_point_2d; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_pixel_on_window__window__color__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_pixel_on_window__window__color__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; opts: __sklib_drawing_options); cdecl; external;
function __sklib__get_pixel__bitmap__point_2d_ref(bmp: __sklib_ptr; const pt: __sklib_point_2d): __sklib_color; cdecl; external;
function __sklib__get_pixel__bitmap__double__double(bmp: __sklib_ptr; x: Double; y: Double): __sklib_color; cdecl; external;
function __sklib__get_pixel__point_2d_ref(const pt: __sklib_point_2d): __sklib_color; cdecl; external;
function __sklib__get_pixel__double__double(x: Double; y: Double): __sklib_color; cdecl; external;
function __sklib__get_pixel__window__point_2d_ref(wnd: __sklib_ptr; const pt: __sklib_point_2d): __sklib_color; cdecl; external;
function __sklib__get_pixel__window__double__double(wnd: __sklib_ptr; x: Double; y: Double): __sklib_color; cdecl; external;
function __sklib__get_pixel_from_window__window__point_2d_ref(destination: __sklib_ptr; const pt: __sklib_point_2d): __sklib_color; cdecl; external;
function __sklib__get_pixel_from_window__window__double__double(destination: __sklib_ptr; x: Double; y: Double): __sklib_color; cdecl; external;
function __sklib__point_at__double__double(x: Double; y: Double): __sklib_point_2d; cdecl; external;
function __sklib__point_at_origin(): __sklib_point_2d; cdecl; external;
function __sklib__point_in_circle__point_2d_ref__circle_ref(const pt: __sklib_point_2d; const c: __sklib_circle): LongInt; cdecl; external;
function __sklib__point_in_circle__double__double__double__double__double(ptx: Double; pty: Double; cx: Double; cy: Double; radius: Double): LongInt; cdecl; external;
function __sklib__point_in_quad__point_2d_ref__quad_ref(const pt: __sklib_point_2d; const q: __sklib_quad): LongInt; cdecl; external;
function __sklib__point_in_rectangle__point_2d_ref__rectangle_ref(const pt: __sklib_point_2d; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__point_in_rectangle__double__double__double__double__double__double(ptx: Double; pty: Double; rectX: Double; rectY: Double; rectWidth: Double; rectHeight: Double): LongInt; cdecl; external;
function __sklib__point_in_triangle__point_2d_ref__triangle_ref(const pt: __sklib_point_2d; const tri: __sklib_triangle): LongInt; cdecl; external;
function __sklib__point_line_distance__point_2d_ref__line_ref(const pt: __sklib_point_2d; const l: __sklib_line): Single; cdecl; external;
function __sklib__point_offset_by__point_2d_ref__vector_2d_ref(const startPoint: __sklib_point_2d; const offset: __sklib_vector_2d): __sklib_point_2d; cdecl; external;
function __sklib__point_offset_from_origin__vector_2d_ref(const offset: __sklib_vector_2d): __sklib_point_2d; cdecl; external;
function __sklib__point_on_line__point_2d_ref__line_ref(const pt: __sklib_point_2d; const l: __sklib_line): LongInt; cdecl; external;
function __sklib__point_on_line__point_2d_ref__line_ref__float(const pt: __sklib_point_2d; const l: __sklib_line; proximity: Single): LongInt; cdecl; external;
function __sklib__point_point_angle__point_2d_ref__point_2d_ref(const pt1: __sklib_point_2d; const pt2: __sklib_point_2d): Single; cdecl; external;
function __sklib__point_point_distance__point_2d_ref__point_2d_ref(const pt1: __sklib_point_2d; const pt2: __sklib_point_2d): Single; cdecl; external;
function __sklib__point_to_string__point_2d_ref(const pt: __sklib_point_2d): __sklib_string; cdecl; external;
function __sklib__random_bitmap_point__bitmap(bmp: __sklib_ptr): __sklib_point_2d; cdecl; external;
function __sklib__random_screen_point(): __sklib_point_2d; cdecl; external;
function __sklib__random_window_point__window(wind: __sklib_ptr): __sklib_point_2d; cdecl; external;
function __sklib__same_point__point_2d_ref__point_2d_ref(const pt1: __sklib_point_2d; const pt2: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__quad_from__point_2d_ref__point_2d_ref__point_2d_ref__point_2d_ref(const p1: __sklib_point_2d; const p2: __sklib_point_2d; const p3: __sklib_point_2d; const p4: __sklib_point_2d): __sklib_quad; cdecl; external;
function __sklib__quad_from__rectangle_ref(const rect: __sklib_rectangle): __sklib_quad; cdecl; external;
function __sklib__quad_from__rectangle_ref__matrix_2d_ref(const rect: __sklib_rectangle; const transform: __sklib_matrix_2d): __sklib_quad; cdecl; external;
function __sklib__quad_from__double__double__double__double__double__double__double__double(xTopLeft: Double; yTopLeft: Double; xTopRight: Double; yTopRight: Double; xBottomLeft: Double; yBottomLeft: Double; xBottomRight: Double; yBottomRight: Double): __sklib_quad; cdecl; external;
function __sklib__quads_intersect__quad_ref__quad_ref(const q1: __sklib_quad; const q2: __sklib_quad): LongInt; cdecl; external;
procedure __sklib__set_quad_point__quad_ref__int__point_2d_ref(var q: __sklib_quad; idx: Integer; const value: __sklib_point_2d); cdecl; external;
function __sklib__triangles_from__quad_ref(const q: __sklib_quad): __sklib_vector_triangle; cdecl; external;
function __sklib__rnd__int__int(min: Integer; max: Integer): Integer; cdecl; external;
function __sklib__rnd(): Single; cdecl; external;
function __sklib__rnd__int(ubound: Integer): Integer; cdecl; external;
function __sklib__has_gpio(): LongInt; cdecl; external;
procedure __sklib__raspi_cleanup(); cdecl; external;
function __sklib__raspi_get_mode__pins(pin: LongInt): LongInt; cdecl; external;
procedure __sklib__raspi_init(); cdecl; external;
function __sklib__raspi_read__pins(pin: LongInt): LongInt; cdecl; external;
procedure __sklib__raspi_set_mode__pins__pin_modes(pin: LongInt; mode: LongInt); cdecl; external;
procedure __sklib__raspi_set_pull_up_down__pins__pull_up_down(pin: LongInt; pud: LongInt); cdecl; external;
procedure __sklib__raspi_set_pwm_dutycycle__pins__int(pin: LongInt; dutycycle: Integer); cdecl; external;
procedure __sklib__raspi_set_pwm_frequency__pins__int(pin: LongInt; frequency: Integer); cdecl; external;
procedure __sklib__raspi_set_pwm_range__pins__int(pin: LongInt; range: Integer); cdecl; external;
procedure __sklib__raspi_write__pins__pin_values(pin: LongInt; value: LongInt); cdecl; external;
procedure __sklib__draw_quad__color__quad_ref(clr: __sklib_color; const q: __sklib_quad); cdecl; external;
procedure __sklib__draw_quad__color__quad_ref__drawing_options_ref(clr: __sklib_color; const q: __sklib_quad; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_quad_on_bitmap__bitmap__color__quad_ref(destination: __sklib_ptr; clr: __sklib_color; const q: __sklib_quad); cdecl; external;
procedure __sklib__draw_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; const q: __sklib_quad; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_quad_on_window__window__color__quad_ref(destination: __sklib_ptr; clr: __sklib_color; const q: __sklib_quad); cdecl; external;
procedure __sklib__draw_quad_on_window__window__color__quad_ref__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; const q: __sklib_quad; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_rectangle__color__rectangle_ref(clr: __sklib_color; const rect: __sklib_rectangle); cdecl; external;
procedure __sklib__draw_rectangle__color__rectangle_ref__drawing_options_ref(clr: __sklib_color; const rect: __sklib_rectangle; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_rectangle__color__double__double__double__double(clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__draw_rectangle__color__double__double__double__double__drawing_options_ref(clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref(destination: __sklib_ptr; clr: __sklib_color; const rect: __sklib_rectangle); cdecl; external;
procedure __sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; const rect: __sklib_rectangle; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_rectangle_on_window__window__color__rectangle_ref(destination: __sklib_ptr; clr: __sklib_color; const rect: __sklib_rectangle); cdecl; external;
procedure __sklib__draw_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; const rect: __sklib_rectangle; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_rectangle_on_window__window__color__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__draw_rectangle_on_window__window__color__double__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_quad__color__quad_ref(clr: __sklib_color; const q: __sklib_quad); cdecl; external;
procedure __sklib__fill_quad__color__quad_ref__drawing_options_ref(clr: __sklib_color; const q: __sklib_quad; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_quad_on_bitmap__bitmap__color__quad_ref(destination: __sklib_ptr; clr: __sklib_color; const q: __sklib_quad); cdecl; external;
procedure __sklib__fill_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; const q: __sklib_quad; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_quad_on_window__window__color__quad_ref(destination: __sklib_ptr; clr: __sklib_color; const q: __sklib_quad); cdecl; external;
procedure __sklib__fill_quad_on_window__window__color__quad_ref__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; const q: __sklib_quad; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_rectangle__color__rectangle_ref(clr: __sklib_color; const rect: __sklib_rectangle); cdecl; external;
procedure __sklib__fill_rectangle__color__rectangle_ref__drawing_options_ref(clr: __sklib_color; const rect: __sklib_rectangle; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_rectangle__color__double__double__double__double(clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__fill_rectangle__color__double__double__double__double__drawing_options_ref(clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref(destination: __sklib_ptr; clr: __sklib_color; const rect: __sklib_rectangle); cdecl; external;
procedure __sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; const rect: __sklib_rectangle; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_rectangle_on_window__window__color__rectangle_ref(destination: __sklib_ptr; clr: __sklib_color; const rect: __sklib_rectangle); cdecl; external;
procedure __sklib__fill_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; const rect: __sklib_rectangle; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_rectangle_on_window__window__color__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double); cdecl; external;
procedure __sklib__fill_rectangle_on_window__window__color__double__double__double__double__drawing_options_ref(destination: __sklib_ptr; clr: __sklib_color; x: Double; y: Double; width: Double; height: Double; const opts: __sklib_drawing_options); cdecl; external;
function __sklib__inset_rectangle__rectangle_ref__float(const rect: __sklib_rectangle; insetAmount: Single): __sklib_rectangle; cdecl; external;
function __sklib__intersection__rectangle_ref__rectangle_ref(const rect1: __sklib_rectangle; const rect2: __sklib_rectangle): __sklib_rectangle; cdecl; external;
function __sklib__rectangle_around__circle_ref(const c: __sklib_circle): __sklib_rectangle; cdecl; external;
function __sklib__rectangle_around__line_ref(const l: __sklib_line): __sklib_rectangle; cdecl; external;
function __sklib__rectangle_around__quad_ref(const q: __sklib_quad): __sklib_rectangle; cdecl; external;
function __sklib__rectangle_around__triangle_ref(const t: __sklib_triangle): __sklib_rectangle; cdecl; external;
function __sklib__rectangle_bottom__rectangle_ref(const rect: __sklib_rectangle): Single; cdecl; external;
function __sklib__rectangle_center__rectangle_ref(const rect: __sklib_rectangle): __sklib_point_2d; cdecl; external;
function __sklib__rectangle_from__point_2d__double__double(pt: __sklib_point_2d; width: Double; height: Double): __sklib_rectangle; cdecl; external;
function __sklib__rectangle_from__point_2d__point_2d(pt1: __sklib_point_2d; pt2: __sklib_point_2d): __sklib_rectangle; cdecl; external;
function __sklib__rectangle_from__double__double__double__double(x: Double; y: Double; width: Double; height: Double): __sklib_rectangle; cdecl; external;
function __sklib__rectangle_left__rectangle_ref(const rect: __sklib_rectangle): Single; cdecl; external;
function __sklib__rectangle_offset_by__rectangle_ref__vector_2d_ref(const rect: __sklib_rectangle; const offset: __sklib_vector_2d): __sklib_rectangle; cdecl; external;
function __sklib__rectangle_right__rectangle_ref(const rect: __sklib_rectangle): Single; cdecl; external;
function __sklib__rectangle_to_string__rectangle_ref(const rect: __sklib_rectangle): __sklib_string; cdecl; external;
function __sklib__rectangle_top__rectangle_ref(const rect: __sklib_rectangle): Single; cdecl; external;
function __sklib__rectangles_intersect__rectangle_ref__rectangle_ref(const rect1: __sklib_rectangle; const rect2: __sklib_rectangle): LongInt; cdecl; external;
procedure __sklib__deregister_free_notifier__free_notifier_ptr(handler: FreeNotifier); cdecl; external;
function __sklib__path_to_resource__string_ref__resource_kind(const filename: __sklib_string; kind: LongInt): __sklib_string; cdecl; external;
function __sklib__path_to_resources(): __sklib_string; cdecl; external;
function __sklib__path_to_resources__resource_kind(kind: LongInt): __sklib_string; cdecl; external;
procedure __sklib__register_free_notifier__free_notifier_ptr(fn: FreeNotifier); cdecl; external;
procedure __sklib__set_resources_path__string_ref(const path: __sklib_string); cdecl; external;
procedure __sklib__fade_all_sound_effects_out__int(ms: Integer); cdecl; external;
procedure __sklib__fade_sound_effect_out__sound_effect__int(effect: __sklib_ptr; ms: Integer); cdecl; external;
procedure __sklib__free_all_sound_effects(); cdecl; external;
procedure __sklib__free_sound_effect__sound_effect(effect: __sklib_ptr); cdecl; external;
function __sklib__has_sound_effect__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__load_sound_effect__string_ref__string_ref(const name: __sklib_string; const filename: __sklib_string): __sklib_ptr; cdecl; external;
procedure __sklib__play_sound_effect__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__play_sound_effect__string_ref__double(const name: __sklib_string; volume: Double); cdecl; external;
procedure __sklib__play_sound_effect__string_ref__int(const name: __sklib_string; times: Integer); cdecl; external;
procedure __sklib__play_sound_effect__string_ref__int__double(const name: __sklib_string; times: Integer; volume: Double); cdecl; external;
procedure __sklib__play_sound_effect__sound_effect(effect: __sklib_ptr); cdecl; external;
procedure __sklib__play_sound_effect__sound_effect__double(effect: __sklib_ptr; volume: Double); cdecl; external;
procedure __sklib__play_sound_effect__sound_effect__int(effect: __sklib_ptr; times: Integer); cdecl; external;
procedure __sklib__play_sound_effect__sound_effect__int__double(effect: __sklib_ptr; times: Integer; volume: Double); cdecl; external;
function __sklib__sound_effect_filename__sound_effect(effect: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__sound_effect_name__sound_effect(effect: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__sound_effect_named__string_ref(const name: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__sound_effect_playing__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__sound_effect_playing__sound_effect(effect: __sklib_ptr): LongInt; cdecl; external;
function __sklib__sound_effect_valid__sound_effect(effect: __sklib_ptr): LongInt; cdecl; external;
procedure __sklib__stop_sound_effect__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__stop_sound_effect__sound_effect(effect: __sklib_ptr); cdecl; external;
procedure __sklib__call_for_all_sprites__sprite_float_function_ptr__float(fn: SpriteFloatFunction; val: Single); cdecl; external;
procedure __sklib__call_for_all_sprites__sprite_function_ptr(fn: SpriteFunction); cdecl; external;
procedure __sklib__call_on_sprite_event__sprite_event_handler_ptr(handler: SpriteEventHandler); cdecl; external;
function __sklib__center_point__sprite(s: __sklib_ptr): __sklib_point_2d; cdecl; external;
function __sklib__create_sprite__bitmap(layer: __sklib_ptr): __sklib_ptr; cdecl; external;
function __sklib__create_sprite__bitmap__animation_script(layer: __sklib_ptr; ani: __sklib_ptr): __sklib_ptr; cdecl; external;
function __sklib__create_sprite__string_ref(const bitmapName: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__create_sprite__string_ref__bitmap(const name: __sklib_string; layer: __sklib_ptr): __sklib_ptr; cdecl; external;
function __sklib__create_sprite__string_ref__bitmap__animation_script(const name: __sklib_string; layer: __sklib_ptr; ani: __sklib_ptr): __sklib_ptr; cdecl; external;
function __sklib__create_sprite__string_ref__string_ref(const bitmapName: __sklib_string; const animationName: __sklib_string): __sklib_ptr; cdecl; external;
procedure __sklib__create_sprite_pack__string_ref(const name: __sklib_string); cdecl; external;
function __sklib__current_sprite_pack(): __sklib_string; cdecl; external;
procedure __sklib__draw_all_sprites(); cdecl; external;
procedure __sklib__draw_sprite__sprite__vector_2d_ref(s: __sklib_ptr; const offset: __sklib_vector_2d); cdecl; external;
procedure __sklib__draw_sprite__sprite(s: __sklib_ptr); cdecl; external;
procedure __sklib__draw_sprite__sprite__double__double(s: __sklib_ptr; xOffset: Double; yOffset: Double); cdecl; external;
procedure __sklib__free_all_sprites(); cdecl; external;
procedure __sklib__free_sprite__sprite(s: __sklib_ptr); cdecl; external;
procedure __sklib__free_sprite_pack__string_ref(const name: __sklib_string); cdecl; external;
function __sklib__has_sprite__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__has_sprite_pack__string_ref(const name: __sklib_string): LongInt; cdecl; external;
procedure __sklib__move_sprite__sprite(s: __sklib_ptr); cdecl; external;
procedure __sklib__move_sprite__sprite__vector_2d_ref(s: __sklib_ptr; const distance: __sklib_vector_2d); cdecl; external;
procedure __sklib__move_sprite__sprite__vector_2d_ref__float(s: __sklib_ptr; const distance: __sklib_vector_2d; pct: Single); cdecl; external;
procedure __sklib__move_sprite__sprite__float(s: __sklib_ptr; pct: Single); cdecl; external;
procedure __sklib__move_sprite_to__sprite__double__double(s: __sklib_ptr; x: Double; y: Double); cdecl; external;
procedure __sklib__select_sprite_pack__string_ref(const name: __sklib_string); cdecl; external;
function __sklib__sprite_add_layer__sprite__bitmap__string_ref(s: __sklib_ptr; newLayer: __sklib_ptr; const layerName: __sklib_string): Integer; cdecl; external;
procedure __sklib__sprite_add_to_velocity__sprite__vector_2d_ref(s: __sklib_ptr; const value: __sklib_vector_2d); cdecl; external;
procedure __sklib__sprite_add_value__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string); cdecl; external;
procedure __sklib__sprite_add_value__sprite__string_ref__float(s: __sklib_ptr; const name: __sklib_string; initVal: Single); cdecl; external;
function __sklib__sprite_anchor_point__sprite(s: __sklib_ptr): __sklib_point_2d; cdecl; external;
function __sklib__sprite_anchor_position__sprite(s: __sklib_ptr): __sklib_point_2d; cdecl; external;
function __sklib__sprite_animation_has_ended__sprite(s: __sklib_ptr): LongInt; cdecl; external;
function __sklib__sprite_animation_name__sprite(s: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__sprite_at__sprite__point_2d_ref(s: __sklib_ptr; const pt: __sklib_point_2d): LongInt; cdecl; external;
procedure __sklib__sprite_bring_layer_forward__sprite__int(s: __sklib_ptr; visibleLayer: Integer); cdecl; external;
procedure __sklib__sprite_bring_layer_to_front__sprite__int(s: __sklib_ptr; visibleLayer: Integer); cdecl; external;
procedure __sklib__sprite_call_on_event__sprite__sprite_event_handler_ptr(s: __sklib_ptr; handler: SpriteEventHandler); cdecl; external;
function __sklib__sprite_circle__sprite(s: __sklib_ptr): __sklib_circle; cdecl; external;
function __sklib__sprite_collision_bitmap__sprite(s: __sklib_ptr): __sklib_ptr; cdecl; external;
function __sklib__sprite_collision_circle__sprite(s: __sklib_ptr): __sklib_circle; cdecl; external;
function __sklib__sprite_collision_kind__sprite(s: __sklib_ptr): LongInt; cdecl; external;
function __sklib__sprite_collision_rectangle__sprite(s: __sklib_ptr): __sklib_rectangle; cdecl; external;
function __sklib__sprite_current_cell__sprite(s: __sklib_ptr): Integer; cdecl; external;
function __sklib__sprite_current_cell_rectangle__sprite(s: __sklib_ptr): __sklib_rectangle; cdecl; external;
function __sklib__sprite_dx__sprite(s: __sklib_ptr): Single; cdecl; external;
function __sklib__sprite_dy__sprite(s: __sklib_ptr): Single; cdecl; external;
function __sklib__sprite_has_value__sprite__string(s: __sklib_ptr; name: __sklib_string): LongInt; cdecl; external;
function __sklib__sprite_heading__sprite(s: __sklib_ptr): Single; cdecl; external;
function __sklib__sprite_height__sprite(s: __sklib_ptr): Integer; cdecl; external;
procedure __sklib__sprite_hide_layer__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string); cdecl; external;
procedure __sklib__sprite_hide_layer__sprite__int(s: __sklib_ptr; id: Integer); cdecl; external;
function __sklib__sprite_layer__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__sprite_layer__sprite__int(s: __sklib_ptr; idx: Integer): __sklib_ptr; cdecl; external;
function __sklib__sprite_layer_circle__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string): __sklib_circle; cdecl; external;
function __sklib__sprite_layer_circle__sprite__int(s: __sklib_ptr; idx: Integer): __sklib_circle; cdecl; external;
function __sklib__sprite_layer_count__sprite(s: __sklib_ptr): Integer; cdecl; external;
function __sklib__sprite_layer_height__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string): Integer; cdecl; external;
function __sklib__sprite_layer_height__sprite__int(s: __sklib_ptr; idx: Integer): Integer; cdecl; external;
function __sklib__sprite_layer_index__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string): Integer; cdecl; external;
function __sklib__sprite_layer_name__sprite__int(s: __sklib_ptr; idx: Integer): __sklib_string; cdecl; external;
function __sklib__sprite_layer_offset__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string): __sklib_vector_2d; cdecl; external;
function __sklib__sprite_layer_offset__sprite__int(s: __sklib_ptr; idx: Integer): __sklib_vector_2d; cdecl; external;
function __sklib__sprite_layer_rectangle__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string): __sklib_rectangle; cdecl; external;
function __sklib__sprite_layer_rectangle__sprite__int(s: __sklib_ptr; idx: Integer): __sklib_rectangle; cdecl; external;
function __sklib__sprite_layer_width__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string): Integer; cdecl; external;
function __sklib__sprite_layer_width__sprite__int(s: __sklib_ptr; idx: Integer): Integer; cdecl; external;
function __sklib__sprite_location_matrix__sprite(s: __sklib_ptr): __sklib_matrix_2d; cdecl; external;
function __sklib__sprite_mass__sprite(s: __sklib_ptr): Single; cdecl; external;
function __sklib__sprite_move_from_anchor_point__sprite(s: __sklib_ptr): LongInt; cdecl; external;
procedure __sklib__sprite_move_to__sprite__point_2d_ref__float(s: __sklib_ptr; const pt: __sklib_point_2d; takingSeconds: Single); cdecl; external;
function __sklib__sprite_name__sprite(s: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__sprite_named__string_ref(const name: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__sprite_offscreen__sprite(s: __sklib_ptr): LongInt; cdecl; external;
function __sklib__sprite_on_screen_at__sprite__point_2d_ref(s: __sklib_ptr; const pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__sprite_on_screen_at__sprite__double__double(s: __sklib_ptr; x: Double; y: Double): LongInt; cdecl; external;
function __sklib__sprite_position__sprite(s: __sklib_ptr): __sklib_point_2d; cdecl; external;
procedure __sklib__sprite_replay_animation__sprite(s: __sklib_ptr); cdecl; external;
procedure __sklib__sprite_replay_animation__sprite__bool(s: __sklib_ptr; withSound: LongInt); cdecl; external;
function __sklib__sprite_rotation__sprite(s: __sklib_ptr): Single; cdecl; external;
function __sklib__sprite_scale__sprite(s: __sklib_ptr): Single; cdecl; external;
function __sklib__sprite_screen_rectangle__sprite(s: __sklib_ptr): __sklib_rectangle; cdecl; external;
procedure __sklib__sprite_send_layer_backward__sprite__int(s: __sklib_ptr; visibleLayer: Integer); cdecl; external;
procedure __sklib__sprite_send_layer_to_back__sprite__int(s: __sklib_ptr; visibleLayer: Integer); cdecl; external;
procedure __sklib__sprite_set_anchor_point__sprite__point_2d_ref(s: __sklib_ptr; const pt: __sklib_point_2d); cdecl; external;
procedure __sklib__sprite_set_collision_bitmap__sprite__bitmap(s: __sklib_ptr; bmp: __sklib_ptr); cdecl; external;
procedure __sklib__sprite_set_collision_kind__sprite__collision_test_kind(s: __sklib_ptr; value: LongInt); cdecl; external;
procedure __sklib__sprite_set_dx__sprite__float(s: __sklib_ptr; value: Single); cdecl; external;
procedure __sklib__sprite_set_dy__sprite__float(s: __sklib_ptr; value: Single); cdecl; external;
procedure __sklib__sprite_set_heading__sprite__float(s: __sklib_ptr; value: Single); cdecl; external;
procedure __sklib__sprite_set_layer_offset__sprite__string_ref__vector_2d_ref(s: __sklib_ptr; const name: __sklib_string; const value: __sklib_vector_2d); cdecl; external;
procedure __sklib__sprite_set_layer_offset__sprite__int__vector_2d_ref(s: __sklib_ptr; idx: Integer; const value: __sklib_vector_2d); cdecl; external;
procedure __sklib__sprite_set_mass__sprite__float(s: __sklib_ptr; value: Single); cdecl; external;
procedure __sklib__sprite_set_move_from_anchor_point__sprite__bool(s: __sklib_ptr; value: LongInt); cdecl; external;
procedure __sklib__sprite_set_position__sprite__point_2d_ref(s: __sklib_ptr; const value: __sklib_point_2d); cdecl; external;
procedure __sklib__sprite_set_rotation__sprite__float(s: __sklib_ptr; value: Single); cdecl; external;
procedure __sklib__sprite_set_scale__sprite__float(s: __sklib_ptr; value: Single); cdecl; external;
procedure __sklib__sprite_set_speed__sprite__float(s: __sklib_ptr; value: Single); cdecl; external;
procedure __sklib__sprite_set_value__sprite__string_ref__float(s: __sklib_ptr; const name: __sklib_string; val: Single); cdecl; external;
procedure __sklib__sprite_set_velocity__sprite__vector_2d_ref(s: __sklib_ptr; const value: __sklib_vector_2d); cdecl; external;
procedure __sklib__sprite_set_x__sprite__float(s: __sklib_ptr; value: Single); cdecl; external;
procedure __sklib__sprite_set_y__sprite__float(s: __sklib_ptr; value: Single); cdecl; external;
function __sklib__sprite_show_layer__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string): Integer; cdecl; external;
function __sklib__sprite_show_layer__sprite__int(s: __sklib_ptr; id: Integer): Integer; cdecl; external;
function __sklib__sprite_speed__sprite(s: __sklib_ptr): Single; cdecl; external;
procedure __sklib__sprite_start_animation__sprite__string_ref(s: __sklib_ptr; const named: __sklib_string); cdecl; external;
procedure __sklib__sprite_start_animation__sprite__string_ref__bool(s: __sklib_ptr; const named: __sklib_string; withSound: LongInt); cdecl; external;
procedure __sklib__sprite_start_animation__sprite__int(s: __sklib_ptr; idx: Integer); cdecl; external;
procedure __sklib__sprite_start_animation__sprite__int__bool(s: __sklib_ptr; idx: Integer; withSound: LongInt); cdecl; external;
procedure __sklib__sprite_stop_calling_on_event__sprite__sprite_event_handler_ptr(s: __sklib_ptr; handler: SpriteEventHandler); cdecl; external;
procedure __sklib__sprite_toggle_layer_visible__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string); cdecl; external;
procedure __sklib__sprite_toggle_layer_visible__sprite__int(s: __sklib_ptr; id: Integer); cdecl; external;
function __sklib__sprite_value__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string): Single; cdecl; external;
function __sklib__sprite_value_count__sprite(s: __sklib_ptr): Integer; cdecl; external;
function __sklib__sprite_velocity__sprite(s: __sklib_ptr): __sklib_vector_2d; cdecl; external;
function __sklib__sprite_visible_index_of_layer__sprite__string_ref(s: __sklib_ptr; const name: __sklib_string): Integer; cdecl; external;
function __sklib__sprite_visible_index_of_layer__sprite__int(s: __sklib_ptr; id: Integer): Integer; cdecl; external;
function __sklib__sprite_visible_layer__sprite__int(s: __sklib_ptr; idx: Integer): Integer; cdecl; external;
function __sklib__sprite_visible_layer_count__sprite(s: __sklib_ptr): Integer; cdecl; external;
function __sklib__sprite_visible_layer_id__sprite__int(s: __sklib_ptr; idx: Integer): Integer; cdecl; external;
function __sklib__sprite_width__sprite(s: __sklib_ptr): Integer; cdecl; external;
function __sklib__sprite_x__sprite(s: __sklib_ptr): Single; cdecl; external;
function __sklib__sprite_y__sprite(s: __sklib_ptr): Single; cdecl; external;
procedure __sklib__stop_calling_on_sprite_event__sprite_event_handler_ptr(handler: SpriteEventHandler); cdecl; external;
procedure __sklib__update_all_sprites(); cdecl; external;
procedure __sklib__update_all_sprites__float(pct: Single); cdecl; external;
procedure __sklib__update_sprite__sprite(s: __sklib_ptr); cdecl; external;
procedure __sklib__update_sprite__sprite__bool(s: __sklib_ptr; withSound: LongInt); cdecl; external;
procedure __sklib__update_sprite__sprite__float(s: __sklib_ptr; pct: Single); cdecl; external;
procedure __sklib__update_sprite__sprite__float__bool(s: __sklib_ptr; pct: Single; withSound: LongInt); cdecl; external;
procedure __sklib__update_sprite_animation__sprite(s: __sklib_ptr); cdecl; external;
procedure __sklib__update_sprite_animation__sprite__bool(s: __sklib_ptr; withSound: LongInt); cdecl; external;
procedure __sklib__update_sprite_animation__sprite__float(s: __sklib_ptr; pct: Single); cdecl; external;
procedure __sklib__update_sprite_animation__sprite__float__bool(s: __sklib_ptr; pct: Single; withSound: LongInt); cdecl; external;
function __sklib__vector_from_center_sprite_to_point__sprite__point_2d_ref(s: __sklib_ptr; const pt: __sklib_point_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_from_to__sprite__sprite(s1: __sklib_ptr; s2: __sklib_ptr): __sklib_vector_2d; cdecl; external;
function __sklib__read_char(): Char; cdecl; external;
function __sklib__read_line(): __sklib_string; cdecl; external;
function __sklib__terminal_has_input(): LongInt; cdecl; external;
procedure __sklib__write__char(data: Char); cdecl; external;
procedure __sklib__write__double(data: Double); cdecl; external;
procedure __sklib__write__int(data: Integer); cdecl; external;
procedure __sklib__write__string(text: __sklib_string); cdecl; external;
procedure __sklib__write_line__char(data: Char); cdecl; external;
procedure __sklib__write_line(); cdecl; external;
procedure __sklib__write_line__double(data: Double); cdecl; external;
procedure __sklib__write_line__int(data: Integer); cdecl; external;
procedure __sklib__write_line__string(line: __sklib_string); cdecl; external;
procedure __sklib__draw_text__string_ref__color_ref__string_ref__int__double__double(const text: __sklib_string; const clr: __sklib_color; const fnt: __sklib_string; fontSize: Integer; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_text__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(const text: __sklib_string; const clr: __sklib_color; const fnt: __sklib_string; fontSize: Integer; x: Double; y: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_text__string_ref__color_ref__double__double(const text: __sklib_string; const clr: __sklib_color; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_text__string_ref__color_ref__double__double__drawing_options_ref(const text: __sklib_string; const clr: __sklib_color; x: Double; y: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_text__string_ref__color_ref__font__int__double__double(const text: __sklib_string; const clr: __sklib_color; fnt: __sklib_ptr; fontSize: Integer; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_text__string_ref__color_ref__font__int__double__double__drawing_options_ref(const text: __sklib_string; const clr: __sklib_color; fnt: __sklib_ptr; fontSize: Integer; x: Double; y: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double(bmp: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; const fnt: __sklib_string; fontSize: Integer; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(bmp: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; const fnt: __sklib_string; fontSize: Integer; x: Double; y: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double(bmp: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double__drawing_options_ref(bmp: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; x: Double; y: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double(bmp: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; fnt: __sklib_ptr; fontSize: Integer; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double__drawing_options_ref(bmp: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; fnt: __sklib_ptr; fontSize: Integer; x: Double; y: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double(wnd: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; const fnt: __sklib_string; fontSize: Integer; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(wnd: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; const fnt: __sklib_string; fontSize: Integer; x: Double; y: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_text_on_window__window__string_ref__color_ref__double__double(wnd: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_text_on_window__window__string_ref__color_ref__double__double__drawing_options_ref(wnd: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; x: Double; y: Double; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double(wnd: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; fnt: __sklib_ptr; fontSize: Integer; x: Double; y: Double); cdecl; external;
procedure __sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double__drawing_options_ref(wnd: __sklib_ptr; const text: __sklib_string; const clr: __sklib_color; fnt: __sklib_ptr; fontSize: Integer; x: Double; y: Double; const opts: __sklib_drawing_options); cdecl; external;
function __sklib__font_has_size__string_ref__int(const name: __sklib_string; fontSize: Integer): LongInt; cdecl; external;
function __sklib__font_has_size__font__int(fnt: __sklib_ptr; fontSize: Integer): LongInt; cdecl; external;
procedure __sklib__font_load_size__string_ref__int(const name: __sklib_string; fontSize: Integer); cdecl; external;
procedure __sklib__font_load_size__font__int(fnt: __sklib_ptr; fontSize: Integer); cdecl; external;
function __sklib__font_named__string(name: __sklib_string): __sklib_ptr; cdecl; external;
procedure __sklib__free_all_fonts(); cdecl; external;
procedure __sklib__free_font__font(fnt: __sklib_ptr); cdecl; external;
function __sklib__get_font_style__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__get_font_style__font(fnt: __sklib_ptr): LongInt; cdecl; external;
function __sklib__get_system_font(): __sklib_ptr; cdecl; external;
function __sklib__has_font__font(fnt: __sklib_ptr): LongInt; cdecl; external;
function __sklib__has_font__string(name: __sklib_string): LongInt; cdecl; external;
function __sklib__load_font__string_ref__string_ref(const name: __sklib_string; const filename: __sklib_string): __sklib_ptr; cdecl; external;
procedure __sklib__set_font_style__string_ref__font_style(const name: __sklib_string; style: LongInt); cdecl; external;
procedure __sklib__set_font_style__font__font_style(fnt: __sklib_ptr; style: LongInt); cdecl; external;
function __sklib__text_height__string_ref__string_ref__int(const text: __sklib_string; const fnt: __sklib_string; fontSize: Integer): Integer; cdecl; external;
function __sklib__text_height__string_ref__font__int(const text: __sklib_string; fnt: __sklib_ptr; fontSize: Integer): Integer; cdecl; external;
function __sklib__text_width__string_ref__string_ref__int(const text: __sklib_string; const fnt: __sklib_string; fontSize: Integer): Integer; cdecl; external;
function __sklib__text_width__string_ref__font__int(const text: __sklib_string; fnt: __sklib_ptr; fontSize: Integer): Integer; cdecl; external;
procedure __sklib__draw_collected_text__color__font__int__drawing_options_ref(clr: __sklib_color; fnt: __sklib_ptr; fontSize: Integer; const opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__end_reading_text(); cdecl; external;
procedure __sklib__end_reading_text__window(wind: __sklib_ptr); cdecl; external;
function __sklib__reading_text(): LongInt; cdecl; external;
function __sklib__reading_text__window(wind: __sklib_ptr): LongInt; cdecl; external;
procedure __sklib__start_reading_text__rectangle(rect: __sklib_rectangle); cdecl; external;
procedure __sklib__start_reading_text__rectangle__string(rect: __sklib_rectangle; initialText: __sklib_string); cdecl; external;
procedure __sklib__start_reading_text__window__rectangle(wind: __sklib_ptr; rect: __sklib_rectangle); cdecl; external;
procedure __sklib__start_reading_text__window__rectangle__string(wind: __sklib_ptr; rect: __sklib_rectangle; initialText: __sklib_string); cdecl; external;
function __sklib__text_entry_cancelled(): LongInt; cdecl; external;
function __sklib__text_entry_cancelled__window(wind: __sklib_ptr): LongInt; cdecl; external;
function __sklib__text_input(): __sklib_string; cdecl; external;
function __sklib__text_input__window(wind: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__create_timer__string(name: __sklib_string): __sklib_ptr; cdecl; external;
procedure __sklib__free_all_timers(); cdecl; external;
procedure __sklib__free_timer__timer(toFree: __sklib_ptr); cdecl; external;
function __sklib__has_timer__string(name: __sklib_string): LongInt; cdecl; external;
procedure __sklib__pause_timer__string(name: __sklib_string); cdecl; external;
procedure __sklib__pause_timer__timer(toPause: __sklib_ptr); cdecl; external;
procedure __sklib__reset_timer__string(name: __sklib_string); cdecl; external;
procedure __sklib__reset_timer__timer(tmr: __sklib_ptr); cdecl; external;
procedure __sklib__resume_timer__string(name: __sklib_string); cdecl; external;
procedure __sklib__resume_timer__timer(toResume: __sklib_ptr); cdecl; external;
procedure __sklib__start_timer__string(name: __sklib_string); cdecl; external;
procedure __sklib__start_timer__timer(toStart: __sklib_ptr); cdecl; external;
procedure __sklib__stop_timer__string(name: __sklib_string); cdecl; external;
procedure __sklib__stop_timer__timer(toStop: __sklib_ptr); cdecl; external;
function __sklib__timer_named__string(name: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__timer_paused__string(name: __sklib_string): LongInt; cdecl; external;
function __sklib__timer_paused__timer(toGet: __sklib_ptr): LongInt; cdecl; external;
function __sklib__timer_started__string(name: __sklib_string): LongInt; cdecl; external;
function __sklib__timer_started__timer(toGet: __sklib_ptr): LongInt; cdecl; external;
function __sklib__timer_ticks__string(name: __sklib_string): Cardinal; cdecl; external;
function __sklib__timer_ticks__timer(toGet: __sklib_ptr): Cardinal; cdecl; external;
procedure __sklib__draw_triangle__color__triangle_ref(clr: __sklib_color; const tri: __sklib_triangle); cdecl; external;
procedure __sklib__draw_triangle__color__triangle_ref__drawing_options(clr: __sklib_color; const tri: __sklib_triangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_triangle__color__double__double__double__double__double__double(clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double); cdecl; external;
procedure __sklib__draw_triangle__color__double__double__double__double__double__double__drawing_options(clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref(destination: __sklib_ptr; clr: __sklib_color; const tri: __sklib_triangle); cdecl; external;
procedure __sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(destination: __sklib_ptr; clr: __sklib_color; const tri: __sklib_triangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double); cdecl; external;
procedure __sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_triangle_on_window__window__color__triangle_ref(destination: __sklib_ptr; clr: __sklib_color; const tri: __sklib_triangle); cdecl; external;
procedure __sklib__draw_triangle_on_window__window__color__triangle_ref__drawing_options(destination: __sklib_ptr; clr: __sklib_color; const tri: __sklib_triangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double); cdecl; external;
procedure __sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_triangle__color__triangle_ref(clr: __sklib_color; const tri: __sklib_triangle); cdecl; external;
procedure __sklib__fill_triangle__color__triangle_ref__drawing_options(clr: __sklib_color; const tri: __sklib_triangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_triangle__color__double__double__double__double__double__double(clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double); cdecl; external;
procedure __sklib__fill_triangle__color__double__double__double__double__double__double__drawing_options(clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref(destination: __sklib_ptr; clr: __sklib_color; const tri: __sklib_triangle); cdecl; external;
procedure __sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(destination: __sklib_ptr; clr: __sklib_color; const tri: __sklib_triangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double); cdecl; external;
procedure __sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_triangle_on_window__window__color__triangle_ref(destination: __sklib_ptr; clr: __sklib_color; const tri: __sklib_triangle); cdecl; external;
procedure __sklib__fill_triangle_on_window__window__color__triangle_ref__drawing_options(destination: __sklib_ptr; clr: __sklib_color; const tri: __sklib_triangle; opts: __sklib_drawing_options); cdecl; external;
procedure __sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double); cdecl; external;
procedure __sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(destination: __sklib_ptr; clr: __sklib_color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: __sklib_drawing_options); cdecl; external;
function __sklib__triangle_barycenter__triangle_ref(const tri: __sklib_triangle): __sklib_point_2d; cdecl; external;
function __sklib__triangle_from__point_2d_ref__point_2d_ref__point_2d_ref(const p1: __sklib_point_2d; const p2: __sklib_point_2d; const p3: __sklib_point_2d): __sklib_triangle; cdecl; external;
function __sklib__triangle_from__double__double__double__double__double__double(x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double): __sklib_triangle; cdecl; external;
function __sklib__triangle_rectangle_intersect__triangle_ref__rectangle_ref(const tri: __sklib_triangle; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__triangle_to_string__triangle_ref(const tri: __sklib_triangle): __sklib_string; cdecl; external;
function __sklib__triangles_intersect__triangle_ref__triangle_ref(const t1: __sklib_triangle; const t2: __sklib_triangle): LongInt; cdecl; external;
function __sklib__current_ticks(): Cardinal; cdecl; external;
procedure __sklib__delay__int(milliseconds: Integer); cdecl; external;
procedure __sklib__display_dialog__string_ref__string_ref__font__int(const title: __sklib_string; const msg: __sklib_string; outputFont: __sklib_ptr; fontSize: Integer); cdecl; external;
function __sklib__file_as_string__string__resource_kind(filename: __sklib_string; kind: LongInt): __sklib_string; cdecl; external;
function __sklib__angle_between__vector_2d_ref__vector_2d_ref(const v1: __sklib_vector_2d; const v2: __sklib_vector_2d): Double; cdecl; external;
function __sklib__dot_product__vector_2d_ref__vector_2d_ref(const v1: __sklib_vector_2d; const v2: __sklib_vector_2d): Double; cdecl; external;
function __sklib__is_zero_vector__vector_2d_ref(const v: __sklib_vector_2d): LongInt; cdecl; external;
function __sklib__ray_intersection_point__point_2d_ref__vector_2d_ref__line_ref__point_2d_ref(const fromPt: __sklib_point_2d; const heading: __sklib_vector_2d; const l: __sklib_line; var pt: __sklib_point_2d): LongInt; cdecl; external;
function __sklib__unit_vector__vector_2d_ref(const v: __sklib_vector_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_add__vector_2d_ref__vector_2d_ref(const v1: __sklib_vector_2d; const v2: __sklib_vector_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_angle__vector_2d(v: __sklib_vector_2d): Double; cdecl; external;
function __sklib__vector_from_angle__double__double(angle: Double; magnitude: Double): __sklib_vector_2d; cdecl; external;
function __sklib__vector_from_line__line_ref(const l: __sklib_line): __sklib_vector_2d; cdecl; external;
function __sklib__vector_from_point_to_rect__point_2d_ref__rectangle_ref(const pt: __sklib_point_2d; const rect: __sklib_rectangle): __sklib_vector_2d; cdecl; external;
function __sklib__vector_in_rect__vector_2d_ref__rectangle_ref(const v: __sklib_vector_2d; const rect: __sklib_rectangle): LongInt; cdecl; external;
function __sklib__vector_invert__vector_2d_ref(const v: __sklib_vector_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_limit__vector_2d_ref__double(const v: __sklib_vector_2d; limit: Double): __sklib_vector_2d; cdecl; external;
function __sklib__vector_magnitude__vector_2d_ref(const v: __sklib_vector_2d): Double; cdecl; external;
function __sklib__vector_magnitude_squared__vector_2d_ref(const v: __sklib_vector_2d): Double; cdecl; external;
function __sklib__vector_multiply__vector_2d_ref__double(const v1: __sklib_vector_2d; s: Double): __sklib_vector_2d; cdecl; external;
function __sklib__vector_normal__vector_2d_ref(const v: __sklib_vector_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_out_of_circle_from_circle__circle_ref__circle_ref__vector_2d_ref(const src: __sklib_circle; const bounds: __sklib_circle; const velocity: __sklib_vector_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_out_of_circle_from_point__point_2d_ref__circle_ref__vector_2d_ref(const pt: __sklib_point_2d; const c: __sklib_circle; const velocity: __sklib_vector_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_out_of_rect_from_circle__circle_ref__rectangle_ref__vector_2d_ref(const c: __sklib_circle; const rect: __sklib_rectangle; const velocity: __sklib_vector_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_out_of_rect_from_point__point_2d_ref__rectangle_ref__vector_2d_ref(const pt: __sklib_point_2d; const rect: __sklib_rectangle; const velocity: __sklib_vector_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_out_of_rect_from_rect__rectangle_ref__rectangle_ref__vector_2d_ref(const src: __sklib_rectangle; const bounds: __sklib_rectangle; const velocity: __sklib_vector_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_point_to_point__point_2d_ref__point_2d_ref(const start: __sklib_point_2d; const endPt: __sklib_point_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_subtract__vector_2d_ref__vector_2d_ref(const v1: __sklib_vector_2d; const v2: __sklib_vector_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_to__point_2d_ref(const p1: __sklib_point_2d): __sklib_vector_2d; cdecl; external;
function __sklib__vector_to__double__double(x: Double; y: Double): __sklib_vector_2d; cdecl; external;
function __sklib__vector_to_string__vector_2d_ref(const v: __sklib_vector_2d): __sklib_string; cdecl; external;
function __sklib__vectors_equal__vector_2d_ref__vector_2d(const v1: __sklib_vector_2d; v2: __sklib_vector_2d): LongInt; cdecl; external;
function __sklib__vectors_not_equal__vector_2d_ref__vector_2d(const v1: __sklib_vector_2d; v2: __sklib_vector_2d): LongInt; cdecl; external;
function __sklib__download_bitmap__string_ref__string_ref__unsigned_short(const name: __sklib_string; const url: __sklib_string; port: Word): __sklib_ptr; cdecl; external;
function __sklib__download_font__string_ref__string_ref__unsigned_short(const name: __sklib_string; const url: __sklib_string; port: Word): __sklib_ptr; cdecl; external;
function __sklib__download_music__string_ref__string_ref__unsigned_short(const name: __sklib_string; const url: __sklib_string; port: Word): __sklib_ptr; cdecl; external;
function __sklib__download_sound_effect__string_ref__string_ref__unsigned_short(const name: __sklib_string; const url: __sklib_string; port: Word): __sklib_ptr; cdecl; external;
procedure __sklib__free_response__http_response(response: __sklib_ptr); cdecl; external;
function __sklib__http_get__string_ref__unsigned_short(const url: __sklib_string; port: Word): __sklib_ptr; cdecl; external;
function __sklib__http_post__string_ref__unsigned_short__string_ref__vector_string_ref(const url: __sklib_string; port: Word; const body: __sklib_string; const headers: __sklib_vector_string): __sklib_ptr; cdecl; external;
function __sklib__http_post__string_ref__unsigned_short__string(const url: __sklib_string; port: Word; body: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__http_response_to_string__http_response(response: __sklib_ptr): __sklib_string; cdecl; external;
procedure __sklib__save_response_to_file__http_response__string(response: __sklib_ptr; path: __sklib_string); cdecl; external;
function __sklib__has_incoming_requests__web_server(server: __sklib_ptr): LongInt; cdecl; external;
function __sklib__is_delete_request_for__http_request__string_ref(request: __sklib_ptr; const path: __sklib_string): LongInt; cdecl; external;
function __sklib__is_get_request_for__http_request__string_ref(request: __sklib_ptr; const path: __sklib_string): LongInt; cdecl; external;
function __sklib__is_options_request_for__http_request__string_ref(request: __sklib_ptr; const path: __sklib_string): LongInt; cdecl; external;
function __sklib__is_post_request_for__http_request__string_ref(request: __sklib_ptr; const path: __sklib_string): LongInt; cdecl; external;
function __sklib__is_put_request_for__http_request__string_ref(request: __sklib_ptr; const path: __sklib_string): LongInt; cdecl; external;
function __sklib__is_request_for__http_request__http_method__string_ref(request: __sklib_ptr; method: LongInt; const path: __sklib_string): LongInt; cdecl; external;
function __sklib__is_trace_request_for__http_request__string_ref(request: __sklib_ptr; const path: __sklib_string): LongInt; cdecl; external;
function __sklib__next_web_request__web_server(server: __sklib_ptr): __sklib_ptr; cdecl; external;
function __sklib__request_body__http_request(r: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__request_has_query_parameter__http_request__string_ref(r: __sklib_ptr; const name: __sklib_string): LongInt; cdecl; external;
function __sklib__request_headers__http_request(r: __sklib_ptr): __sklib_vector_string; cdecl; external;
function __sklib__request_method__http_request(r: __sklib_ptr): LongInt; cdecl; external;
function __sklib__request_query_parameter__http_request__string_ref__string_ref(r: __sklib_ptr; const name: __sklib_string; const defaultValue: __sklib_string): __sklib_string; cdecl; external;
function __sklib__request_query_string__http_request(r: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__request_uri__http_request(r: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__request_uri_stubs__http_request(r: __sklib_ptr): __sklib_vector_string; cdecl; external;
procedure __sklib__send_css_file_response__http_request__string_ref(r: __sklib_ptr; const filename: __sklib_string); cdecl; external;
procedure __sklib__send_file_response__http_request__string_ref__string_ref(r: __sklib_ptr; const filename: __sklib_string; const contentType: __sklib_string); cdecl; external;
procedure __sklib__send_html_file_response__http_request__string_ref(r: __sklib_ptr; const filename: __sklib_string); cdecl; external;
procedure __sklib__send_javascript_file_response__http_request__string_ref(r: __sklib_ptr; const filename: __sklib_string); cdecl; external;
procedure __sklib__send_response__http_request(r: __sklib_ptr); cdecl; external;
procedure __sklib__send_response__http_request__string_ref(r: __sklib_ptr; const message: __sklib_string); cdecl; external;
procedure __sklib__send_response__http_request__http_status_code(r: __sklib_ptr; code: LongInt); cdecl; external;
procedure __sklib__send_response__http_request__http_status_code__string_ref(r: __sklib_ptr; code: LongInt; const message: __sklib_string); cdecl; external;
procedure __sklib__send_response__http_request__http_status_code__string_ref__string_ref(r: __sklib_ptr; code: LongInt; const message: __sklib_string; const contentType: __sklib_string); cdecl; external;
procedure __sklib__send_response__http_request__http_status_code__string_ref__string_ref__vector_string_ref(r: __sklib_ptr; code: LongInt; const message: __sklib_string; const contentType: __sklib_string; const headers: __sklib_vector_string); cdecl; external;
procedure __sklib__send_response__http_request__json(r: __sklib_ptr; j: __sklib_ptr); cdecl; external;
function __sklib__split_uri_stubs__string_ref(const uri: __sklib_string): __sklib_vector_string; cdecl; external;
function __sklib__start_web_server(): __sklib_ptr; cdecl; external;
function __sklib__start_web_server__unsigned_short(port: Word): __sklib_ptr; cdecl; external;
procedure __sklib__stop_web_server__web_server(server: __sklib_ptr); cdecl; external;
procedure __sklib__clear_window__window__color(wind: __sklib_ptr; clr: __sklib_color); cdecl; external;
procedure __sklib__close_all_windows(); cdecl; external;
procedure __sklib__close_current_window(); cdecl; external;
procedure __sklib__close_window__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__close_window__window(wind: __sklib_ptr); cdecl; external;
function __sklib__current_window(): __sklib_ptr; cdecl; external;
function __sklib__current_window_has_border(): LongInt; cdecl; external;
function __sklib__current_window_height(): Integer; cdecl; external;
function __sklib__current_window_is_fullscreen(): LongInt; cdecl; external;
function __sklib__current_window_position(): __sklib_point_2d; cdecl; external;
procedure __sklib__current_window_toggle_border(); cdecl; external;
procedure __sklib__current_window_toggle_fullscreen(); cdecl; external;
function __sklib__current_window_width(): Integer; cdecl; external;
function __sklib__current_window_x(): Integer; cdecl; external;
function __sklib__current_window_y(): Integer; cdecl; external;
function __sklib__has_window__string(caption: __sklib_string): LongInt; cdecl; external;
function __sklib__is_current_window__window(wind: __sklib_ptr): LongInt; cdecl; external;
procedure __sklib__move_current_window_to__int__int(x: Integer; y: Integer); cdecl; external;
procedure __sklib__move_window_to__string_ref__int__int(const name: __sklib_string; x: Integer; y: Integer); cdecl; external;
procedure __sklib__move_window_to__window__int__int(wind: __sklib_ptr; x: Integer; y: Integer); cdecl; external;
function __sklib__open_window__string__int__int(caption: __sklib_string; width: Integer; height: Integer): __sklib_ptr; cdecl; external;
procedure __sklib__refresh_window__window(wind: __sklib_ptr); cdecl; external;
procedure __sklib__refresh_window__window__unsigned_int(wind: __sklib_ptr; targetFps: Cardinal); cdecl; external;
procedure __sklib__resize_current_window__int__int(width: Integer; height: Integer); cdecl; external;
procedure __sklib__resize_window__window__int__int(wnd: __sklib_ptr; width: Integer; height: Integer); cdecl; external;
procedure __sklib__set_current_window__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__set_current_window__window(wind: __sklib_ptr); cdecl; external;
function __sklib__window_caption__window(wind: __sklib_ptr): __sklib_string; cdecl; external;
function __sklib__window_close_requested__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__window_close_requested__window(wind: __sklib_ptr): LongInt; cdecl; external;
function __sklib__window_has_border__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__window_has_border__window(wnd: __sklib_ptr): LongInt; cdecl; external;
function __sklib__window_has_focus__window(wind: __sklib_ptr): LongInt; cdecl; external;
function __sklib__window_height__string_ref(const name: __sklib_string): Integer; cdecl; external;
function __sklib__window_height__window(wind: __sklib_ptr): Integer; cdecl; external;
function __sklib__window_is_fullscreen__string_ref(const name: __sklib_string): LongInt; cdecl; external;
function __sklib__window_is_fullscreen__window(wnd: __sklib_ptr): LongInt; cdecl; external;
function __sklib__window_named__string(caption: __sklib_string): __sklib_ptr; cdecl; external;
function __sklib__window_position__string_ref(const name: __sklib_string): __sklib_point_2d; cdecl; external;
function __sklib__window_position__window(wnd: __sklib_ptr): __sklib_point_2d; cdecl; external;
procedure __sklib__window_set_icon__window__bitmap(wind: __sklib_ptr; bmp: __sklib_ptr); cdecl; external;
procedure __sklib__window_toggle_border__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__window_toggle_border__window(wnd: __sklib_ptr); cdecl; external;
procedure __sklib__window_toggle_fullscreen__string_ref(const name: __sklib_string); cdecl; external;
procedure __sklib__window_toggle_fullscreen__window(wnd: __sklib_ptr); cdecl; external;
function __sklib__window_width__string_ref(const name: __sklib_string): Integer; cdecl; external;
function __sklib__window_width__window(wind: __sklib_ptr): Integer; cdecl; external;
function __sklib__window_with_focus(): __sklib_ptr; cdecl; external;
function __sklib__window_x__string_ref(const name: __sklib_string): Integer; cdecl; external;
function __sklib__window_x__window(wnd: __sklib_ptr): Integer; cdecl; external;
function __sklib__window_y__string_ref(const name: __sklib_string): Integer; cdecl; external;
function __sklib__window_y__window(wnd: __sklib_ptr): Integer; cdecl; external;
function AnimationCount(script: AnimationScript): Integer;
var
  __skparam__script: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__script := __skadapter__to_sklib_animation_script(script);
  __skreturn := __sklib__animation_count__animation_script(__skparam__script);
  result := __skadapter__to_int(__skreturn);
end;
function AnimationCurrentCell(anim: Animation): Integer;
var
  __skparam__anim: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skreturn := __sklib__animation_current_cell__animation(__skparam__anim);
  result := __skadapter__to_int(__skreturn);
end;
function AnimationCurrentVector(anim: Animation): Vector2D;
var
  __skparam__anim: __sklib_ptr;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skreturn := __sklib__animation_current_vector__animation(__skparam__anim);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function AnimationEnded(anim: Animation): Boolean;
var
  __skparam__anim: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skreturn := __sklib__animation_ended__animation(__skparam__anim);
  result := __skadapter__to_bool(__skreturn);
end;
function AnimationEnteredFrame(anim: Animation): Boolean;
var
  __skparam__anim: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skreturn := __sklib__animation_entered_frame__animation(__skparam__anim);
  result := __skadapter__to_bool(__skreturn);
end;
function AnimationFrameTime(anim: Animation): Single;
var
  __skparam__anim: __sklib_ptr;
  __skreturn: Single;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skreturn := __sklib__animation_frame_time__animation(__skparam__anim);
  result := __skadapter__to_float(__skreturn);
end;
function AnimationIndex(script: AnimationScript; const name: String): Integer;
var
  __skparam__script: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__script := __skadapter__to_sklib_animation_script(script);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__animation_index__animation_script__string_ref(__skparam__script, __skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
function AnimationName(temp: Animation): String;
var
  __skparam__temp: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__temp := __skadapter__to_sklib_animation(temp);
  __skreturn := __sklib__animation_name__animation(__skparam__temp);
  result := __skadapter__to_string(__skreturn);
end;
function AnimationScriptName(script: AnimationScript): String;
var
  __skparam__script: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__script := __skadapter__to_sklib_animation_script(script);
  __skreturn := __sklib__animation_script_name__animation_script(__skparam__script);
  result := __skadapter__to_string(__skreturn);
end;
function AnimationScriptNamed(const name: String): AnimationScript;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__animation_script_named__string_ref(__skparam__name);
  result := __skadapter__to_animation_script(__skreturn);
end;
procedure AssignAnimation(anim: Animation; script: AnimationScript; const name: String);
var
  __skparam__anim: __sklib_ptr;
  __skparam__script: __sklib_ptr;
  __skparam__name: __sklib_string;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__script := __skadapter__to_sklib_animation_script(script);
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__assign_animation__animation__animation_script__string_ref(__skparam__anim, __skparam__script, __skparam__name);
end;
procedure AssignAnimation(anim: Animation; script: AnimationScript; const name: String; withSound: Boolean);
var
  __skparam__anim: __sklib_ptr;
  __skparam__script: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skparam__with_sound: LongInt;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__script := __skadapter__to_sklib_animation_script(script);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__assign_animation__animation__animation_script__string_ref__bool(__skparam__anim, __skparam__script, __skparam__name, __skparam__with_sound);
end;
procedure AssignAnimation(anim: Animation; script: AnimationScript; idx: Integer);
var
  __skparam__anim: __sklib_ptr;
  __skparam__script: __sklib_ptr;
  __skparam__idx: Integer;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__script := __skadapter__to_sklib_animation_script(script);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __sklib__assign_animation__animation__animation_script__int(__skparam__anim, __skparam__script, __skparam__idx);
end;
procedure AssignAnimation(anim: Animation; script: AnimationScript; idx: Integer; withSound: Boolean);
var
  __skparam__anim: __sklib_ptr;
  __skparam__script: __sklib_ptr;
  __skparam__idx: Integer;
  __skparam__with_sound: LongInt;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__script := __skadapter__to_sklib_animation_script(script);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__assign_animation__animation__animation_script__int__bool(__skparam__anim, __skparam__script, __skparam__idx, __skparam__with_sound);
end;
procedure AssignAnimation(anim: Animation; const scriptName: String; const name: String);
var
  __skparam__anim: __sklib_ptr;
  __skparam__script_name: __sklib_string;
  __skparam__name: __sklib_string;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__script_name := __skadapter__to_sklib_string(scriptName);
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__assign_animation__animation__string_ref__string_ref(__skparam__anim, __skparam__script_name, __skparam__name);
end;
procedure AssignAnimation(anim: Animation; const scriptName: String; const name: String; withSound: Boolean);
var
  __skparam__anim: __sklib_ptr;
  __skparam__script_name: __sklib_string;
  __skparam__name: __sklib_string;
  __skparam__with_sound: LongInt;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__script_name := __skadapter__to_sklib_string(scriptName);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__assign_animation__animation__string_ref__string_ref__bool(__skparam__anim, __skparam__script_name, __skparam__name, __skparam__with_sound);
end;
procedure AssignAnimation(anim: Animation; idx: Integer);
var
  __skparam__anim: __sklib_ptr;
  __skparam__idx: Integer;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __sklib__assign_animation__animation__int(__skparam__anim, __skparam__idx);
end;
procedure AssignAnimation(anim: Animation; idx: Integer; withSound: Boolean);
var
  __skparam__anim: __sklib_ptr;
  __skparam__idx: Integer;
  __skparam__with_sound: LongInt;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__assign_animation__animation__int__bool(__skparam__anim, __skparam__idx, __skparam__with_sound);
end;
procedure AssignAnimation(anim: Animation; name: String);
var
  __skparam__anim: __sklib_ptr;
  __skparam__name: __sklib_string;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__assign_animation__animation__string(__skparam__anim, __skparam__name);
end;
procedure AssignAnimation(anim: Animation; name: String; withSound: Boolean);
var
  __skparam__anim: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skparam__with_sound: LongInt;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__assign_animation__animation__string__bool(__skparam__anim, __skparam__name, __skparam__with_sound);
end;
function CreateAnimation(script: AnimationScript; idx: Integer; withSound: Boolean): Animation;
var
  __skparam__script: __sklib_ptr;
  __skparam__idx: Integer;
  __skparam__with_sound: LongInt;
  __skreturn: __sklib_ptr;
begin
  __skparam__script := __skadapter__to_sklib_animation_script(script);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __skreturn := __sklib__create_animation__animation_script__int__bool(__skparam__script, __skparam__idx, __skparam__with_sound);
  result := __skadapter__to_animation(__skreturn);
end;
function CreateAnimation(script: AnimationScript; const name: String): Animation;
var
  __skparam__script: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__script := __skadapter__to_sklib_animation_script(script);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__create_animation__animation_script__string_ref(__skparam__script, __skparam__name);
  result := __skadapter__to_animation(__skreturn);
end;
function CreateAnimation(script: AnimationScript; const name: String; withSound: Boolean): Animation;
var
  __skparam__script: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skparam__with_sound: LongInt;
  __skreturn: __sklib_ptr;
begin
  __skparam__script := __skadapter__to_sklib_animation_script(script);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __skreturn := __sklib__create_animation__animation_script__string_ref__bool(__skparam__script, __skparam__name, __skparam__with_sound);
  result := __skadapter__to_animation(__skreturn);
end;
function CreateAnimation(const scriptName: String; const name: String): Animation;
var
  __skparam__script_name: __sklib_string;
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__script_name := __skadapter__to_sklib_string(scriptName);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__create_animation__string_ref__string_ref(__skparam__script_name, __skparam__name);
  result := __skadapter__to_animation(__skreturn);
end;
function CreateAnimation(const scriptName: String; const name: String; withSound: Boolean): Animation;
var
  __skparam__script_name: __sklib_string;
  __skparam__name: __sklib_string;
  __skparam__with_sound: LongInt;
  __skreturn: __sklib_ptr;
begin
  __skparam__script_name := __skadapter__to_sklib_string(scriptName);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __skreturn := __sklib__create_animation__string_ref__string_ref__bool(__skparam__script_name, __skparam__name, __skparam__with_sound);
  result := __skadapter__to_animation(__skreturn);
end;
procedure FreeAllAnimationScripts();
begin
  __sklib__free_all_animation_scripts();
end;
procedure FreeAnimation(ani: Animation);
var
  __skparam__ani: __sklib_ptr;
begin
  __skparam__ani := __skadapter__to_sklib_animation(ani);
  __sklib__free_animation__animation(__skparam__ani);
end;
procedure FreeAnimationScript(scriptToFree: AnimationScript);
var
  __skparam__script_to_free: __sklib_ptr;
begin
  __skparam__script_to_free := __skadapter__to_sklib_animation_script(scriptToFree);
  __sklib__free_animation_script__animation_script(__skparam__script_to_free);
end;
procedure FreeAnimationScript(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__free_animation_script__string_ref(__skparam__name);
end;
function HasAnimationNamed(script: AnimationScript; const name: String): Boolean;
var
  __skparam__script: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__script := __skadapter__to_sklib_animation_script(script);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_animation_named__animation_script__string_ref(__skparam__script, __skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function HasAnimationScript(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_animation_script__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function LoadAnimationScript(const name: String; const filename: String): AnimationScript;
var
  __skparam__name: __sklib_string;
  __skparam__filename: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __skreturn := __sklib__load_animation_script__string_ref__string_ref(__skparam__name, __skparam__filename);
  result := __skadapter__to_animation_script(__skreturn);
end;
procedure RestartAnimation(anim: Animation);
var
  __skparam__anim: __sklib_ptr;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __sklib__restart_animation__animation(__skparam__anim);
end;
procedure RestartAnimation(anim: Animation; withSound: Boolean);
var
  __skparam__anim: __sklib_ptr;
  __skparam__with_sound: LongInt;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__restart_animation__animation__bool(__skparam__anim, __skparam__with_sound);
end;
procedure UpdateAnimation(anim: Animation; pct: Single; withSound: Boolean);
var
  __skparam__anim: __sklib_ptr;
  __skparam__pct: Single;
  __skparam__with_sound: LongInt;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__pct := __skadapter__to_sklib_float(pct);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__update_animation__animation__float__bool(__skparam__anim, __skparam__pct, __skparam__with_sound);
end;
procedure UpdateAnimation(anim: Animation);
var
  __skparam__anim: __sklib_ptr;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __sklib__update_animation__animation(__skparam__anim);
end;
procedure UpdateAnimation(anim: Animation; pct: Single);
var
  __skparam__anim: __sklib_ptr;
  __skparam__pct: Single;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__pct := __skadapter__to_sklib_float(pct);
  __sklib__update_animation__animation__float(__skparam__anim, __skparam__pct);
end;
function AudioReady(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__audio_ready();
  result := __skadapter__to_bool(__skreturn);
end;
procedure CloseAudio();
begin
  __sklib__close_audio();
end;
procedure OpenAudio();
begin
  __sklib__open_audio();
end;
function Contains(const text: String; const subtext: String): Boolean;
var
  __skparam__text: __sklib_string;
  __skparam__subtext: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__subtext := __skadapter__to_sklib_string(subtext);
  __skreturn := __sklib__contains__string_ref__string_ref(__skparam__text, __skparam__subtext);
  result := __skadapter__to_bool(__skreturn);
end;
function ConvertToDouble(const text: String): Double;
var
  __skparam__text: __sklib_string;
  __skreturn: Double;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skreturn := __sklib__convert_to_double__string_ref(__skparam__text);
  result := __skadapter__to_double(__skreturn);
end;
function ConvertToInteger(const text: String): Integer;
var
  __skparam__text: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skreturn := __sklib__convert_to_integer__string_ref(__skparam__text);
  result := __skadapter__to_int(__skreturn);
end;
function IndexOf(const text: String; const subtext: String): Integer;
var
  __skparam__text: __sklib_string;
  __skparam__subtext: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__subtext := __skadapter__to_sklib_string(subtext);
  __skreturn := __sklib__index_of__string_ref__string_ref(__skparam__text, __skparam__subtext);
  result := __skadapter__to_int(__skreturn);
end;
function IsDouble(const text: String): Boolean;
var
  __skparam__text: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skreturn := __sklib__is_double__string_ref(__skparam__text);
  result := __skadapter__to_bool(__skreturn);
end;
function IsInteger(const text: String): Boolean;
var
  __skparam__text: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skreturn := __sklib__is_integer__string_ref(__skparam__text);
  result := __skadapter__to_bool(__skreturn);
end;
function IsNumber(const text: String): Boolean;
var
  __skparam__text: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skreturn := __sklib__is_number__string_ref(__skparam__text);
  result := __skadapter__to_bool(__skreturn);
end;
function LengthOf(const text: String): Integer;
var
  __skparam__text: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skreturn := __sklib__length_of__string_ref(__skparam__text);
  result := __skadapter__to_int(__skreturn);
end;
function ReplaceAll(const text: String; const substr: String; const newtext: String): String;
var
  __skparam__text: __sklib_string;
  __skparam__substr: __sklib_string;
  __skparam__newtext: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__substr := __skadapter__to_sklib_string(substr);
  __skparam__newtext := __skadapter__to_sklib_string(newtext);
  __skreturn := __sklib__replace_all__string_ref__string_ref__string_ref(__skparam__text, __skparam__substr, __skparam__newtext);
  result := __skadapter__to_string(__skreturn);
end;
function Split(const text: String; delimiter: Char): ArrayOfString;
var
  __skparam__text: __sklib_string;
  __skparam__delimiter: Char;
  __skreturn: __sklib_vector_string;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__delimiter := __skadapter__to_sklib_char(delimiter);
  __skreturn := __sklib__split__string_ref__char(__skparam__text, __skparam__delimiter);
  result := __skadapter__to_vector_string(__skreturn);
end;
function ToLowercase(const text: String): String;
var
  __skparam__text: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skreturn := __sklib__to_lowercase__string_ref(__skparam__text);
  result := __skadapter__to_string(__skreturn);
end;
function ToUppercase(const text: String): String;
var
  __skparam__text: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skreturn := __sklib__to_uppercase__string_ref(__skparam__text);
  result := __skadapter__to_string(__skreturn);
end;
function Trim(const text: String): String;
var
  __skparam__text: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skreturn := __sklib__trim__string_ref(__skparam__text);
  result := __skadapter__to_string(__skreturn);
end;
procedure FreeResourceBundle(name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__free_resource_bundle__string(__skparam__name);
end;
function HasResourceBundle(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_resource_bundle__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
procedure LoadResourceBundle(const name: String; const filename: String);
var
  __skparam__name: __sklib_string;
  __skparam__filename: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __sklib__load_resource_bundle__string_ref__string_ref(__skparam__name, __skparam__filename);
end;
function CameraPosition(): Point2D;
var
  __skreturn: __sklib_point_2d;
begin
  __skreturn := __sklib__camera_position();
  result := __skadapter__to_point_2d(__skreturn);
end;
function CameraX(): Double;
var
  __skreturn: Double;
begin
  __skreturn := __sklib__camera_x();
  result := __skadapter__to_double(__skreturn);
end;
function CameraY(): Double;
var
  __skreturn: Double;
begin
  __skreturn := __sklib__camera_y();
  result := __skadapter__to_double(__skreturn);
end;
procedure CenterCameraOn(s: Sprite; const offset: Vector2D);
var
  __skparam__s: __sklib_ptr;
  __skparam__offset: __sklib_vector_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__offset := __skadapter__to_sklib_vector_2d(offset);
  __sklib__center_camera_on__sprite__vector_2d_ref(__skparam__s, __skparam__offset);
end;
procedure CenterCameraOn(s: Sprite; offsetX: Double; offsetY: Double);
var
  __skparam__s: __sklib_ptr;
  __skparam__offset_x: Double;
  __skparam__offset_y: Double;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__offset_x := __skadapter__to_sklib_double(offsetX);
  __skparam__offset_y := __skadapter__to_sklib_double(offsetY);
  __sklib__center_camera_on__sprite__double__double(__skparam__s, __skparam__offset_x, __skparam__offset_y);
end;
procedure MoveCameraBy(const offset: Vector2D);
var
  __skparam__offset: __sklib_vector_2d;
begin
  __skparam__offset := __skadapter__to_sklib_vector_2d(offset);
  __sklib__move_camera_by__vector_2d_ref(__skparam__offset);
end;
procedure MoveCameraBy(dx: Double; dy: Double);
var
  __skparam__dx: Double;
  __skparam__dy: Double;
begin
  __skparam__dx := __skadapter__to_sklib_double(dx);
  __skparam__dy := __skadapter__to_sklib_double(dy);
  __sklib__move_camera_by__double__double(__skparam__dx, __skparam__dy);
end;
procedure MoveCameraTo(const pt: Point2D);
var
  __skparam__pt: __sklib_point_2d;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __sklib__move_camera_to__point_2d_ref(__skparam__pt);
end;
procedure MoveCameraTo(x: Double; y: Double);
var
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__move_camera_to__double__double(__skparam__x, __skparam__y);
end;
function PointInWindow(wind: Window; const pt: Point2D): Boolean;
var
  __skparam__wind: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__point_in_window__window__point_2d_ref(__skparam__wind, __skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function PointOnScreen(const pt: Point2D): Boolean;
var
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__point_on_screen__point_2d_ref(__skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function RectInWindow(wind: Window; const rect: Rectangle): Boolean;
var
  __skparam__wind: __sklib_ptr;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__rect_in_window__window__rectangle_ref(__skparam__wind, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function RectOnScreen(const rect: Rectangle): Boolean;
var
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__rect_on_screen__rectangle_ref(__skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function ScreenCenter(): Point2D;
var
  __skreturn: __sklib_point_2d;
begin
  __skreturn := __sklib__screen_center();
  result := __skadapter__to_point_2d(__skreturn);
end;
function ScreenRectangle(): Rectangle;
var
  __skreturn: __sklib_rectangle;
begin
  __skreturn := __sklib__screen_rectangle();
  result := __skadapter__to_rectangle(__skreturn);
end;
procedure SetCameraPosition(pos: Point2D);
var
  __skparam__pos: __sklib_point_2d;
begin
  __skparam__pos := __skadapter__to_sklib_point_2d(pos);
  __sklib__set_camera_position__point_2d(__skparam__pos);
end;
procedure SetCameraX(x: Double);
var
  __skparam__x: Double;
begin
  __skparam__x := __skadapter__to_sklib_double(x);
  __sklib__set_camera_x__double(__skparam__x);
end;
procedure SetCameraY(y: Double);
var
  __skparam__y: Double;
begin
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__set_camera_y__double(__skparam__y);
end;
function ToScreen(const pt: Point2D): Point2D;
var
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_point_2d;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__to_screen__point_2d_ref(__skparam__pt);
  result := __skadapter__to_point_2d(__skreturn);
end;
function ToScreen(const rect: Rectangle): Rectangle;
var
  __skparam__rect: __sklib_rectangle;
  __skreturn: __sklib_rectangle;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__to_screen__rectangle_ref(__skparam__rect);
  result := __skadapter__to_rectangle(__skreturn);
end;
function ToScreenX(worldX: Double): Double;
var
  __skparam__world_x: Double;
  __skreturn: Double;
begin
  __skparam__world_x := __skadapter__to_sklib_double(worldX);
  __skreturn := __sklib__to_screen_x__double(__skparam__world_x);
  result := __skadapter__to_double(__skreturn);
end;
function ToScreenY(worldY: Double): Double;
var
  __skparam__world_y: Double;
  __skreturn: Double;
begin
  __skparam__world_y := __skadapter__to_sklib_double(worldY);
  __skreturn := __sklib__to_screen_y__double(__skparam__world_y);
  result := __skadapter__to_double(__skreturn);
end;
function ToWorld(const pt: Point2D): Point2D;
var
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_point_2d;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__to_world__point_2d_ref(__skparam__pt);
  result := __skadapter__to_point_2d(__skreturn);
end;
function ToWorldX(screenX: Double): Double;
var
  __skparam__screen_x: Double;
  __skreturn: Double;
begin
  __skparam__screen_x := __skadapter__to_sklib_double(screenX);
  __skreturn := __sklib__to_world_x__double(__skparam__screen_x);
  result := __skadapter__to_double(__skreturn);
end;
function ToWorldY(screenY: Double): Double;
var
  __skparam__screen_y: Double;
  __skreturn: Double;
begin
  __skparam__screen_y := __skadapter__to_sklib_double(screenY);
  __skreturn := __sklib__to_world_y__double(__skparam__screen_y);
  result := __skadapter__to_double(__skreturn);
end;
function VectorWorldToScreen(): Vector2D;
var
  __skreturn: __sklib_vector_2d;
begin
  __skreturn := __sklib__vector_world_to_screen();
  result := __skadapter__to_vector_2d(__skreturn);
end;
function WindowArea(wind: Window): Rectangle;
var
  __skparam__wind: __sklib_ptr;
  __skreturn: __sklib_rectangle;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skreturn := __sklib__window_area__window(__skparam__wind);
  result := __skadapter__to_rectangle(__skreturn);
end;
procedure DrawCircle(clr: Color; const c: Circle);
var
  __skparam__clr: __sklib_color;
  __skparam__c: __sklib_circle;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __sklib__draw_circle__color__circle_ref(__skparam__clr, __skparam__c);
end;
procedure DrawCircle(clr: Color; const c: Circle; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__c: __sklib_circle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_circle__color__circle_ref__drawing_options(__skparam__clr, __skparam__c, __skparam__opts);
end;
procedure DrawCircle(clr: Color; x: Double; y: Double; radius: Double);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __sklib__draw_circle__color__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
end;
procedure DrawCircle(clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_circle__color__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
end;
procedure DrawCircleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; radius: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __sklib__draw_circle_on_bitmap__bitmap__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
end;
procedure DrawCircleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
end;
procedure DrawCircleOnWindow(destination: Window; clr: Color; x: Double; y: Double; radius: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __sklib__draw_circle_on_window__window__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
end;
procedure DrawCircleOnWindow(destination: Window; clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_circle_on_window__window__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
end;
procedure FillCircle(clr: Color; const c: Circle);
var
  __skparam__clr: __sklib_color;
  __skparam__c: __sklib_circle;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __sklib__fill_circle__color__circle_ref(__skparam__clr, __skparam__c);
end;
procedure FillCircle(clr: Color; const c: Circle; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__c: __sklib_circle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_circle__color__circle_ref__drawing_options(__skparam__clr, __skparam__c, __skparam__opts);
end;
procedure FillCircle(clr: Color; x: Double; y: Double; radius: Double);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __sklib__fill_circle__color__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
end;
procedure FillCircle(clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_circle__color__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
end;
procedure FillCircleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; radius: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __sklib__fill_circle_on_bitmap__bitmap__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
end;
procedure FillCircleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
end;
procedure FillCircleOnWindow(destination: Window; clr: Color; x: Double; y: Double; radius: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __sklib__fill_circle_on_window__window__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
end;
procedure FillCircleOnWindow(destination: Window; clr: Color; x: Double; y: Double; radius: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_circle_on_window__window__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
end;
function CenterPoint(const c: Circle): Point2D;
var
  __skparam__c: __sklib_circle;
  __skreturn: __sklib_point_2d;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skreturn := __sklib__center_point__circle_ref(__skparam__c);
  result := __skadapter__to_point_2d(__skreturn);
end;
function CircleAt(const pt: Point2D; radius: Double): Circle;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__radius: Double;
  __skreturn: __sklib_circle;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __skreturn := __sklib__circle_at__point_2d_ref__double(__skparam__pt, __skparam__radius);
  result := __skadapter__to_circle(__skreturn);
end;
function CircleAt(x: Double; y: Double; radius: Double): Circle;
var
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__radius: Double;
  __skreturn: __sklib_circle;
begin
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __skreturn := __sklib__circle_at__double__double__double(__skparam__x, __skparam__y, __skparam__radius);
  result := __skadapter__to_circle(__skreturn);
end;
function CircleRadius(c: Circle): Single;
var
  __skparam__c: __sklib_circle;
  __skreturn: Single;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skreturn := __sklib__circle_radius__circle(__skparam__c);
  result := __skadapter__to_float(__skreturn);
end;
function CircleTriangleIntersect(const c: Circle; const tri: Triangle): Boolean;
var
  __skparam__c: __sklib_circle;
  __skparam__tri: __sklib_triangle;
  __skreturn: LongInt;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skreturn := __sklib__circle_triangle_intersect__circle_ref__triangle_ref(__skparam__c, __skparam__tri);
  result := __skadapter__to_bool(__skreturn);
end;
function CircleTriangleIntersect(const c: Circle; const tri: Triangle; var p: Point2D): Boolean;
var
  __skparam__c: __sklib_circle;
  __skparam__tri: __sklib_triangle;
  __skparam__p: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skparam__p := __skadapter__to_sklib_point_2d(p);
  __skreturn := __sklib__circle_triangle_intersect__circle_ref__triangle_ref__point_2d_ref(__skparam__c, __skparam__tri, __skparam__p);
  p := __skadapter__to_point_2d(__skparam__p);
  result := __skadapter__to_bool(__skreturn);
end;
function CircleX(const c: Circle): Single;
var
  __skparam__c: __sklib_circle;
  __skreturn: Single;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skreturn := __sklib__circle_x__circle_ref(__skparam__c);
  result := __skadapter__to_float(__skreturn);
end;
function CircleY(const c: Circle): Single;
var
  __skparam__c: __sklib_circle;
  __skreturn: Single;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skreturn := __sklib__circle_y__circle_ref(__skparam__c);
  result := __skadapter__to_float(__skreturn);
end;
function CirclesIntersect(c1: Circle; c2: Circle): Boolean;
var
  __skparam__c1: __sklib_circle;
  __skparam__c2: __sklib_circle;
  __skreturn: LongInt;
begin
  __skparam__c1 := __skadapter__to_sklib_circle(c1);
  __skparam__c2 := __skadapter__to_sklib_circle(c2);
  __skreturn := __sklib__circles_intersect__circle__circle(__skparam__c1, __skparam__c2);
  result := __skadapter__to_bool(__skreturn);
end;
function CirclesIntersect(c1X: Double; c1Y: Double; c1Radius: Double; c2X: Double; c2Y: Double; c2Radius: Double): Boolean;
var
  __skparam__c1_x: Double;
  __skparam__c1_y: Double;
  __skparam__c1_radius: Double;
  __skparam__c2_x: Double;
  __skparam__c2_y: Double;
  __skparam__c2_radius: Double;
  __skreturn: LongInt;
begin
  __skparam__c1_x := __skadapter__to_sklib_double(c1X);
  __skparam__c1_y := __skadapter__to_sklib_double(c1Y);
  __skparam__c1_radius := __skadapter__to_sklib_double(c1Radius);
  __skparam__c2_x := __skadapter__to_sklib_double(c2X);
  __skparam__c2_y := __skadapter__to_sklib_double(c2Y);
  __skparam__c2_radius := __skadapter__to_sklib_double(c2Radius);
  __skreturn := __sklib__circles_intersect__double__double__double__double__double__double(__skparam__c1_x, __skparam__c1_y, __skparam__c1_radius, __skparam__c2_x, __skparam__c2_y, __skparam__c2_radius);
  result := __skadapter__to_bool(__skreturn);
end;
function ClosestPointOnCircle(const fromPt: Point2D; const c: Circle): Point2D;
var
  __skparam__from_pt: __sklib_point_2d;
  __skparam__c: __sklib_circle;
  __skreturn: __sklib_point_2d;
begin
  __skparam__from_pt := __skadapter__to_sklib_point_2d(fromPt);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skreturn := __sklib__closest_point_on_circle__point_2d_ref__circle_ref(__skparam__from_pt, __skparam__c);
  result := __skadapter__to_point_2d(__skreturn);
end;
function ClosestPointOnLineFromCircle(const c: Circle; const l: Line): Point2D;
var
  __skparam__c: __sklib_circle;
  __skparam__l: __sklib_line;
  __skreturn: __sklib_point_2d;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__l := __skadapter__to_sklib_line(l);
  __skreturn := __sklib__closest_point_on_line_from_circle__circle_ref__line_ref(__skparam__c, __skparam__l);
  result := __skadapter__to_point_2d(__skreturn);
end;
function ClosestPointOnRectFromCircle(const c: Circle; const rect: Rectangle): Point2D;
var
  __skparam__c: __sklib_circle;
  __skparam__rect: __sklib_rectangle;
  __skreturn: __sklib_point_2d;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__closest_point_on_rect_from_circle__circle_ref__rectangle_ref(__skparam__c, __skparam__rect);
  result := __skadapter__to_point_2d(__skreturn);
end;
function ClosestPointOnTriangleFromCircle(const c: Circle; const tri: Triangle): Point2D;
var
  __skparam__c: __sklib_circle;
  __skparam__tri: __sklib_triangle;
  __skreturn: __sklib_point_2d;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skreturn := __sklib__closest_point_on_triangle_from_circle__circle_ref__triangle_ref(__skparam__c, __skparam__tri);
  result := __skadapter__to_point_2d(__skreturn);
end;
function DistantPointOnCircle(const pt: Point2D; const c: Circle): Point2D;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__c: __sklib_circle;
  __skreturn: __sklib_point_2d;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skreturn := __sklib__distant_point_on_circle__point_2d_ref__circle_ref(__skparam__pt, __skparam__c);
  result := __skadapter__to_point_2d(__skreturn);
end;
function DistantPointOnCircleHeading(const pt: Point2D; const c: Circle; const heading: Vector2D; var oppositePt: Point2D): Boolean;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__c: __sklib_circle;
  __skparam__heading: __sklib_vector_2d;
  __skparam__opposite_pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__heading := __skadapter__to_sklib_vector_2d(heading);
  __skparam__opposite_pt := __skadapter__to_sklib_point_2d(oppositePt);
  __skreturn := __sklib__distant_point_on_circle_heading__point_2d_ref__circle_ref__vector_2d_ref__point_2d_ref(__skparam__pt, __skparam__c, __skparam__heading, __skparam__opposite_pt);
  oppositePt := __skadapter__to_point_2d(__skparam__opposite_pt);
  result := __skadapter__to_bool(__skreturn);
end;
function RayCircleIntersectDistance(const rayOrigin: Point2D; const rayHeading: Vector2D; const c: Circle): Single;
var
  __skparam__ray_origin: __sklib_point_2d;
  __skparam__ray_heading: __sklib_vector_2d;
  __skparam__c: __sklib_circle;
  __skreturn: Single;
begin
  __skparam__ray_origin := __skadapter__to_sklib_point_2d(rayOrigin);
  __skparam__ray_heading := __skadapter__to_sklib_vector_2d(rayHeading);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skreturn := __sklib__ray_circle_intersect_distance__point_2d_ref__vector_2d_ref__circle_ref(__skparam__ray_origin, __skparam__ray_heading, __skparam__c);
  result := __skadapter__to_float(__skreturn);
end;
function TangentPoints(const fromPt: Point2D; const c: Circle; var p1: Point2D; var p2: Point2D): Boolean;
var
  __skparam__from_pt: __sklib_point_2d;
  __skparam__c: __sklib_circle;
  __skparam__p1: __sklib_point_2d;
  __skparam__p2: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__from_pt := __skadapter__to_sklib_point_2d(fromPt);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__p1 := __skadapter__to_sklib_point_2d(p1);
  __skparam__p2 := __skadapter__to_sklib_point_2d(p2);
  __skreturn := __sklib__tangent_points__point_2d_ref__circle_ref__point_2d_ref__point_2d_ref(__skparam__from_pt, __skparam__c, __skparam__p1, __skparam__p2);
  p1 := __skadapter__to_point_2d(__skparam__p1);
  p2 := __skadapter__to_point_2d(__skparam__p2);
  result := __skadapter__to_bool(__skreturn);
end;
procedure WidestPoints(const c: Circle; const along: Vector2D; var pt1: Point2D; var pt2: Point2D);
var
  __skparam__c: __sklib_circle;
  __skparam__along: __sklib_vector_2d;
  __skparam__pt1: __sklib_point_2d;
  __skparam__pt2: __sklib_point_2d;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__along := __skadapter__to_sklib_vector_2d(along);
  __skparam__pt1 := __skadapter__to_sklib_point_2d(pt1);
  __skparam__pt2 := __skadapter__to_sklib_point_2d(pt2);
  __sklib__widest_points__circle_ref__vector_2d_ref__point_2d_ref__point_2d_ref(__skparam__c, __skparam__along, __skparam__pt1, __skparam__pt2);
  pt1 := __skadapter__to_point_2d(__skparam__pt1);
  pt2 := __skadapter__to_point_2d(__skparam__pt2);
end;
function CurrentClip(): Rectangle;
var
  __skreturn: __sklib_rectangle;
begin
  __skreturn := __sklib__current_clip();
  result := __skadapter__to_rectangle(__skreturn);
end;
function CurrentClip(bmp: Bitmap): Rectangle;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: __sklib_rectangle;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__current_clip__bitmap(__skparam__bmp);
  result := __skadapter__to_rectangle(__skreturn);
end;
function CurrentClip(wnd: Window): Rectangle;
var
  __skparam__wnd: __sklib_ptr;
  __skreturn: __sklib_rectangle;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skreturn := __sklib__current_clip__window(__skparam__wnd);
  result := __skadapter__to_rectangle(__skreturn);
end;
procedure PopClip(wnd: Window);
var
  __skparam__wnd: __sklib_ptr;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __sklib__pop_clip__window(__skparam__wnd);
end;
procedure PopClip();
begin
  __sklib__pop_clip();
end;
procedure PopClip(bmp: Bitmap);
var
  __skparam__bmp: __sklib_ptr;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __sklib__pop_clip__bitmap(__skparam__bmp);
end;
procedure PushClip(wnd: Window; const r: Rectangle);
var
  __skparam__wnd: __sklib_ptr;
  __skparam__r: __sklib_rectangle;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skparam__r := __skadapter__to_sklib_rectangle(r);
  __sklib__push_clip__window__rectangle_ref(__skparam__wnd, __skparam__r);
end;
procedure PushClip(bmp: Bitmap; const r: Rectangle);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__r: __sklib_rectangle;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__r := __skadapter__to_sklib_rectangle(r);
  __sklib__push_clip__bitmap__rectangle_ref(__skparam__bmp, __skparam__r);
end;
procedure PushClip(const r: Rectangle);
var
  __skparam__r: __sklib_rectangle;
begin
  __skparam__r := __skadapter__to_sklib_rectangle(r);
  __sklib__push_clip__rectangle_ref(__skparam__r);
end;
procedure ResetClip(bmp: Bitmap);
var
  __skparam__bmp: __sklib_ptr;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __sklib__reset_clip__bitmap(__skparam__bmp);
end;
procedure ResetClip();
begin
  __sklib__reset_clip();
end;
procedure ResetClip(wnd: Window);
var
  __skparam__wnd: __sklib_ptr;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __sklib__reset_clip__window(__skparam__wnd);
end;
procedure SetClip(const r: Rectangle);
var
  __skparam__r: __sklib_rectangle;
begin
  __skparam__r := __skadapter__to_sklib_rectangle(r);
  __sklib__set_clip__rectangle_ref(__skparam__r);
end;
procedure SetClip(bmp: Bitmap; const r: Rectangle);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__r: __sklib_rectangle;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__r := __skadapter__to_sklib_rectangle(r);
  __sklib__set_clip__bitmap__rectangle_ref(__skparam__bmp, __skparam__r);
end;
procedure SetClip(wnd: Window; const r: Rectangle);
var
  __skparam__wnd: __sklib_ptr;
  __skparam__r: __sklib_rectangle;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skparam__r := __skadapter__to_sklib_rectangle(r);
  __sklib__set_clip__window__rectangle_ref(__skparam__wnd, __skparam__r);
end;
function BitmapCircleCollision(bmp: Bitmap; const pt: Point2D; const circ: Circle): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skparam__circ: __sklib_circle;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__circ := __skadapter__to_sklib_circle(circ);
  __skreturn := __sklib__bitmap_circle_collision__bitmap__point_2d_ref__circle_ref(__skparam__bmp, __skparam__pt, __skparam__circ);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapCircleCollision(bmp: Bitmap; x: Double; y: Double; const circ: Circle): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__circ: __sklib_circle;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__circ := __skadapter__to_sklib_circle(circ);
  __skreturn := __sklib__bitmap_circle_collision__bitmap__double__double__circle_ref(__skparam__bmp, __skparam__x, __skparam__y, __skparam__circ);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapCircleCollision(bmp: Bitmap; cell: Integer; const translation: Matrix2D; const circ: Circle): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__translation: __sklib_matrix_2d;
  __skparam__circ: __sklib_circle;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__translation := __skadapter__to_sklib_matrix_2d(translation);
  __skparam__circ := __skadapter__to_sklib_circle(circ);
  __skreturn := __sklib__bitmap_circle_collision__bitmap__int__matrix_2d_ref__circle_ref(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__circ);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapCircleCollision(bmp: Bitmap; cell: Integer; const pt: Point2D; const circ: Circle): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__pt: __sklib_point_2d;
  __skparam__circ: __sklib_circle;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__circ := __skadapter__to_sklib_circle(circ);
  __skreturn := __sklib__bitmap_circle_collision__bitmap__int__point_2d_ref__circle_ref(__skparam__bmp, __skparam__cell, __skparam__pt, __skparam__circ);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapCircleCollision(bmp: Bitmap; cell: Integer; x: Double; y: Double; const circ: Circle): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__circ: __sklib_circle;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__circ := __skadapter__to_sklib_circle(circ);
  __skreturn := __sklib__bitmap_circle_collision__bitmap__int__double__double__circle_ref(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y, __skparam__circ);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapCollision(bmp1: Bitmap; x1: Double; y1: Double; bmp2: Bitmap; x2: Double; y2: Double): Boolean;
var
  __skparam__bmp1: __sklib_ptr;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__bmp2: __sklib_ptr;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skreturn: LongInt;
begin
  __skparam__bmp1 := __skadapter__to_sklib_bitmap(bmp1);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__bmp2 := __skadapter__to_sklib_bitmap(bmp2);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skreturn := __sklib__bitmap_collision__bitmap__double__double__bitmap__double__double(__skparam__bmp1, __skparam__x1, __skparam__y1, __skparam__bmp2, __skparam__x2, __skparam__y2);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapCollision(bmp1: Bitmap; const pt1: Point2D; bmp2: Bitmap; const pt2: Point2D): Boolean;
var
  __skparam__bmp1: __sklib_ptr;
  __skparam__pt1: __sklib_point_2d;
  __skparam__bmp2: __sklib_ptr;
  __skparam__pt2: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__bmp1 := __skadapter__to_sklib_bitmap(bmp1);
  __skparam__pt1 := __skadapter__to_sklib_point_2d(pt1);
  __skparam__bmp2 := __skadapter__to_sklib_bitmap(bmp2);
  __skparam__pt2 := __skadapter__to_sklib_point_2d(pt2);
  __skreturn := __sklib__bitmap_collision__bitmap__point_2d_ref__bitmap__point_2d_ref(__skparam__bmp1, __skparam__pt1, __skparam__bmp2, __skparam__pt2);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapCollision(bmp1: Bitmap; cell1: Integer; const matrix1: Matrix2D; bmp2: Bitmap; cell2: Integer; const matrix2: Matrix2D): Boolean;
var
  __skparam__bmp1: __sklib_ptr;
  __skparam__cell1: Integer;
  __skparam__matrix1: __sklib_matrix_2d;
  __skparam__bmp2: __sklib_ptr;
  __skparam__cell2: Integer;
  __skparam__matrix2: __sklib_matrix_2d;
  __skreturn: LongInt;
begin
  __skparam__bmp1 := __skadapter__to_sklib_bitmap(bmp1);
  __skparam__cell1 := __skadapter__to_sklib_int(cell1);
  __skparam__matrix1 := __skadapter__to_sklib_matrix_2d(matrix1);
  __skparam__bmp2 := __skadapter__to_sklib_bitmap(bmp2);
  __skparam__cell2 := __skadapter__to_sklib_int(cell2);
  __skparam__matrix2 := __skadapter__to_sklib_matrix_2d(matrix2);
  __skreturn := __sklib__bitmap_collision__bitmap__int__matrix_2d_ref__bitmap__int__matrix_2d_ref(__skparam__bmp1, __skparam__cell1, __skparam__matrix1, __skparam__bmp2, __skparam__cell2, __skparam__matrix2);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapCollision(bmp1: Bitmap; cell1: Integer; const pt1: Point2D; bmp2: Bitmap; cell2: Integer; const pt2: Point2D): Boolean;
var
  __skparam__bmp1: __sklib_ptr;
  __skparam__cell1: Integer;
  __skparam__pt1: __sklib_point_2d;
  __skparam__bmp2: __sklib_ptr;
  __skparam__cell2: Integer;
  __skparam__pt2: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__bmp1 := __skadapter__to_sklib_bitmap(bmp1);
  __skparam__cell1 := __skadapter__to_sklib_int(cell1);
  __skparam__pt1 := __skadapter__to_sklib_point_2d(pt1);
  __skparam__bmp2 := __skadapter__to_sklib_bitmap(bmp2);
  __skparam__cell2 := __skadapter__to_sklib_int(cell2);
  __skparam__pt2 := __skadapter__to_sklib_point_2d(pt2);
  __skreturn := __sklib__bitmap_collision__bitmap__int__point_2d_ref__bitmap__int__point_2d_ref(__skparam__bmp1, __skparam__cell1, __skparam__pt1, __skparam__bmp2, __skparam__cell2, __skparam__pt2);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapCollision(bmp1: Bitmap; cell1: Integer; x1: Double; y1: Double; bmp2: Bitmap; cell2: Integer; x2: Double; y2: Double): Boolean;
var
  __skparam__bmp1: __sklib_ptr;
  __skparam__cell1: Integer;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__bmp2: __sklib_ptr;
  __skparam__cell2: Integer;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skreturn: LongInt;
begin
  __skparam__bmp1 := __skadapter__to_sklib_bitmap(bmp1);
  __skparam__cell1 := __skadapter__to_sklib_int(cell1);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__bmp2 := __skadapter__to_sklib_bitmap(bmp2);
  __skparam__cell2 := __skadapter__to_sklib_int(cell2);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skreturn := __sklib__bitmap_collision__bitmap__int__double__double__bitmap__int__double__double(__skparam__bmp1, __skparam__cell1, __skparam__x1, __skparam__y1, __skparam__bmp2, __skparam__cell2, __skparam__x2, __skparam__y2);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapPointCollision(bmp: Bitmap; const translation: Matrix2D; const pt: Point2D): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__translation: __sklib_matrix_2d;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__translation := __skadapter__to_sklib_matrix_2d(translation);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__bitmap_point_collision__bitmap__matrix_2d_ref__point_2d_ref(__skparam__bmp, __skparam__translation, __skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapPointCollision(bmp: Bitmap; const bmpPt: Point2D; const pt: Point2D): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__bmp_pt: __sklib_point_2d;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__bmp_pt := __skadapter__to_sklib_point_2d(bmpPt);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__bitmap_point_collision__bitmap__point_2d_ref__point_2d_ref(__skparam__bmp, __skparam__bmp_pt, __skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapPointCollision(bmp: Bitmap; bmpX: Double; bmpY: Double; x: Double; y: Double): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__bmp_x: Double;
  __skparam__bmp_y: Double;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__bmp_x := __skadapter__to_sklib_double(bmpX);
  __skparam__bmp_y := __skadapter__to_sklib_double(bmpY);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__bitmap_point_collision__bitmap__double__double__double__double(__skparam__bmp, __skparam__bmp_x, __skparam__bmp_y, __skparam__x, __skparam__y);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapPointCollision(bmp: Bitmap; cell: Integer; const translation: Matrix2D; const pt: Point2D): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__translation: __sklib_matrix_2d;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__translation := __skadapter__to_sklib_matrix_2d(translation);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__bitmap_point_collision__bitmap__int__matrix_2d_ref__point_2d_ref(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapPointCollision(bmp: Bitmap; cell: Integer; const bmpPt: Point2D; const pt: Point2D): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__bmp_pt: __sklib_point_2d;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__bmp_pt := __skadapter__to_sklib_point_2d(bmpPt);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__bitmap_point_collision__bitmap__int__point_2d_ref__point_2d_ref(__skparam__bmp, __skparam__cell, __skparam__bmp_pt, __skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapPointCollision(bmp: Bitmap; cell: Integer; bmpX: Double; bmpY: Double; x: Double; y: Double): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__bmp_x: Double;
  __skparam__bmp_y: Double;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__bmp_x := __skadapter__to_sklib_double(bmpX);
  __skparam__bmp_y := __skadapter__to_sklib_double(bmpY);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__bitmap_point_collision__bitmap__int__double__double__double__double(__skparam__bmp, __skparam__cell, __skparam__bmp_x, __skparam__bmp_y, __skparam__x, __skparam__y);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapRectangleCollision(bmp: Bitmap; const pt: Point2D; const rect: Rectangle): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__bitmap_rectangle_collision__bitmap__point_2d_ref__rectangle_ref(__skparam__bmp, __skparam__pt, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapRectangleCollision(bmp: Bitmap; x: Double; y: Double; const rect: Rectangle): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__bitmap_rectangle_collision__bitmap__double__double__rectangle_ref(__skparam__bmp, __skparam__x, __skparam__y, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapRectangleCollision(bmp: Bitmap; cell: Integer; const translation: Matrix2D; const rect: Rectangle): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__translation: __sklib_matrix_2d;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__translation := __skadapter__to_sklib_matrix_2d(translation);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__bitmap_rectangle_collision__bitmap__int__matrix_2d_ref__rectangle_ref(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapRectangleCollision(bmp: Bitmap; cell: Integer; const pt: Point2D; const rect: Rectangle): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__pt: __sklib_point_2d;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__bitmap_rectangle_collision__bitmap__int__point_2d_ref__rectangle_ref(__skparam__bmp, __skparam__cell, __skparam__pt, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapRectangleCollision(bmp: Bitmap; cell: Integer; x: Double; y: Double; const rect: Rectangle): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__bitmap_rectangle_collision__bitmap__int__double__double__rectangle_ref(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function SpriteBitmapCollision(s: Sprite; bmp: Bitmap; x: Double; y: Double): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__sprite_bitmap_collision__sprite__bitmap__double__double(__skparam__s, __skparam__bmp, __skparam__x, __skparam__y);
  result := __skadapter__to_bool(__skreturn);
end;
function SpriteBitmapCollision(s: Sprite; bmp: Bitmap; cell: Integer; const pt: Point2D): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__sprite_bitmap_collision__sprite__bitmap__int__point_2d_ref(__skparam__s, __skparam__bmp, __skparam__cell, __skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function SpriteBitmapCollision(s: Sprite; bmp: Bitmap; cell: Integer; x: Double; y: Double): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__sprite_bitmap_collision__sprite__bitmap__int__double__double(__skparam__s, __skparam__bmp, __skparam__cell, __skparam__x, __skparam__y);
  result := __skadapter__to_bool(__skreturn);
end;
function SpriteCollision(s1: Sprite; s2: Sprite): Boolean;
var
  __skparam__s1: __sklib_ptr;
  __skparam__s2: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__s1 := __skadapter__to_sklib_sprite(s1);
  __skparam__s2 := __skadapter__to_sklib_sprite(s2);
  __skreturn := __sklib__sprite_collision__sprite__sprite(__skparam__s1, __skparam__s2);
  result := __skadapter__to_bool(__skreturn);
end;
function SpritePointCollision(s: Sprite; const pt: Point2D): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__sprite_point_collision__sprite__point_2d_ref(__skparam__s, __skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function SpriteRectangleCollision(s: Sprite; const rect: Rectangle): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__sprite_rectangle_collision__sprite__rectangle_ref(__skparam__s, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function AlphaOf(c: Color): Integer;
var
  __skparam__c: __sklib_color;
  __skreturn: Integer;
begin
  __skparam__c := __skadapter__to_sklib_color(c);
  __skreturn := __sklib__alpha_of__color(__skparam__c);
  result := __skadapter__to_int(__skreturn);
end;
function BlueOf(c: Color): Integer;
var
  __skparam__c: __sklib_color;
  __skreturn: Integer;
begin
  __skparam__c := __skadapter__to_sklib_color(c);
  __skreturn := __sklib__blue_of__color(__skparam__c);
  result := __skadapter__to_int(__skreturn);
end;
function BrightnessOf(c: Color): Double;
var
  __skparam__c: __sklib_color;
  __skreturn: Double;
begin
  __skparam__c := __skadapter__to_sklib_color(c);
  __skreturn := __sklib__brightness_of__color(__skparam__c);
  result := __skadapter__to_double(__skreturn);
end;
function ColorAliceBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_alice_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorAntiqueWhite(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_antique_white();
  result := __skadapter__to_color(__skreturn);
end;
function ColorAqua(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_aqua();
  result := __skadapter__to_color(__skreturn);
end;
function ColorAquamarine(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_aquamarine();
  result := __skadapter__to_color(__skreturn);
end;
function ColorAzure(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_azure();
  result := __skadapter__to_color(__skreturn);
end;
function ColorBeige(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_beige();
  result := __skadapter__to_color(__skreturn);
end;
function ColorBisque(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_bisque();
  result := __skadapter__to_color(__skreturn);
end;
function ColorBlack(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_black();
  result := __skadapter__to_color(__skreturn);
end;
function ColorBlanchedAlmond(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_blanched_almond();
  result := __skadapter__to_color(__skreturn);
end;
function ColorBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorBlueViolet(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_blue_violet();
  result := __skadapter__to_color(__skreturn);
end;
function ColorBrightGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_bright_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorBrown(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_brown();
  result := __skadapter__to_color(__skreturn);
end;
function ColorBurlyWood(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_burly_wood();
  result := __skadapter__to_color(__skreturn);
end;
function ColorCadetBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_cadet_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorChartreuse(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_chartreuse();
  result := __skadapter__to_color(__skreturn);
end;
function ColorChocolate(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_chocolate();
  result := __skadapter__to_color(__skreturn);
end;
function ColorCoral(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_coral();
  result := __skadapter__to_color(__skreturn);
end;
function ColorCornflowerBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_cornflower_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorCornsilk(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_cornsilk();
  result := __skadapter__to_color(__skreturn);
end;
function ColorCrimson(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_crimson();
  result := __skadapter__to_color(__skreturn);
end;
function ColorCyan(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_cyan();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkCyan(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_cyan();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkGoldenrod(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_goldenrod();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkGray(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_gray();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkKhaki(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_khaki();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkMagenta(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_magenta();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkOliveGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_olive_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkOrange(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_orange();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkOrchid(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_orchid();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkRed(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_red();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkSalmon(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_salmon();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkSeaGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_sea_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkSlateBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_slate_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkSlateGray(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_slate_gray();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkTurquoise(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_turquoise();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDarkViolet(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dark_violet();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDeepPink(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_deep_pink();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDeepSkyBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_deep_sky_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDimGray(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dim_gray();
  result := __skadapter__to_color(__skreturn);
end;
function ColorDodgerBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_dodger_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorFirebrick(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_firebrick();
  result := __skadapter__to_color(__skreturn);
end;
function ColorFloralWhite(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_floral_white();
  result := __skadapter__to_color(__skreturn);
end;
function ColorForestGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_forest_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorFuchsia(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_fuchsia();
  result := __skadapter__to_color(__skreturn);
end;
function ColorGainsboro(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_gainsboro();
  result := __skadapter__to_color(__skreturn);
end;
function ColorGhostWhite(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_ghost_white();
  result := __skadapter__to_color(__skreturn);
end;
function ColorGold(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_gold();
  result := __skadapter__to_color(__skreturn);
end;
function ColorGoldenrod(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_goldenrod();
  result := __skadapter__to_color(__skreturn);
end;
function ColorGray(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_gray();
  result := __skadapter__to_color(__skreturn);
end;
function ColorGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorGreenYellow(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_green_yellow();
  result := __skadapter__to_color(__skreturn);
end;
function ColorHoneydew(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_honeydew();
  result := __skadapter__to_color(__skreturn);
end;
function ColorHotPink(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_hot_pink();
  result := __skadapter__to_color(__skreturn);
end;
function ColorIndianRed(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_indian_red();
  result := __skadapter__to_color(__skreturn);
end;
function ColorIndigo(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_indigo();
  result := __skadapter__to_color(__skreturn);
end;
function ColorIvory(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_ivory();
  result := __skadapter__to_color(__skreturn);
end;
function ColorKhaki(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_khaki();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLavender(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_lavender();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLavenderBlush(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_lavender_blush();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLawnGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_lawn_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLemonChiffon(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_lemon_chiffon();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightCoral(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_coral();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightCyan(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_cyan();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightGoldenrodYellow(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_goldenrod_yellow();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightGray(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_gray();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightPink(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_pink();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightSalmon(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_salmon();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightSeaGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_sea_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightSkyBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_sky_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightSlateGray(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_slate_gray();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightSteelBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_steel_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLightYellow(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_light_yellow();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLime(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_lime();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLimeGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_lime_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorLinen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_linen();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMagenta(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_magenta();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMaroon(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_maroon();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMediumAquamarine(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_medium_aquamarine();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMediumBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_medium_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMediumOrchid(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_medium_orchid();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMediumPurple(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_medium_purple();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMediumSeaGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_medium_sea_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMediumSlateBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_medium_slate_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMediumSpringGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_medium_spring_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMediumTurquoise(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_medium_turquoise();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMediumVioletRed(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_medium_violet_red();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMidnightBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_midnight_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMintCream(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_mint_cream();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMistyRose(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_misty_rose();
  result := __skadapter__to_color(__skreturn);
end;
function ColorMoccasin(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_moccasin();
  result := __skadapter__to_color(__skreturn);
end;
function ColorNavajoWhite(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_navajo_white();
  result := __skadapter__to_color(__skreturn);
end;
function ColorNavy(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_navy();
  result := __skadapter__to_color(__skreturn);
end;
function ColorOldLace(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_old_lace();
  result := __skadapter__to_color(__skreturn);
end;
function ColorOlive(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_olive();
  result := __skadapter__to_color(__skreturn);
end;
function ColorOliveDrab(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_olive_drab();
  result := __skadapter__to_color(__skreturn);
end;
function ColorOrange(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_orange();
  result := __skadapter__to_color(__skreturn);
end;
function ColorOrangeRed(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_orange_red();
  result := __skadapter__to_color(__skreturn);
end;
function ColorOrchid(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_orchid();
  result := __skadapter__to_color(__skreturn);
end;
function ColorPaleGoldenrod(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_pale_goldenrod();
  result := __skadapter__to_color(__skreturn);
end;
function ColorPaleGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_pale_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorPaleTurquoise(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_pale_turquoise();
  result := __skadapter__to_color(__skreturn);
end;
function ColorPaleVioletRed(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_pale_violet_red();
  result := __skadapter__to_color(__skreturn);
end;
function ColorPapayaWhip(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_papaya_whip();
  result := __skadapter__to_color(__skreturn);
end;
function ColorPeachPuff(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_peach_puff();
  result := __skadapter__to_color(__skreturn);
end;
function ColorPeru(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_peru();
  result := __skadapter__to_color(__skreturn);
end;
function ColorPink(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_pink();
  result := __skadapter__to_color(__skreturn);
end;
function ColorPlum(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_plum();
  result := __skadapter__to_color(__skreturn);
end;
function ColorPowderBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_powder_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorPurple(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_purple();
  result := __skadapter__to_color(__skreturn);
end;
function ColorRed(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_red();
  result := __skadapter__to_color(__skreturn);
end;
function ColorRosyBrown(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_rosy_brown();
  result := __skadapter__to_color(__skreturn);
end;
function ColorRoyalBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_royal_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSaddleBrown(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_saddle_brown();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSalmon(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_salmon();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSandyBrown(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_sandy_brown();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSeaGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_sea_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSeaShell(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_sea_shell();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSienna(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_sienna();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSilver(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_silver();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSkyBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_sky_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSlateBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_slate_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSlateGray(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_slate_gray();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSnow(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_snow();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSpringGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_spring_green();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSteelBlue(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_steel_blue();
  result := __skadapter__to_color(__skreturn);
end;
function ColorSwinburneRed(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_swinburne_red();
  result := __skadapter__to_color(__skreturn);
end;
function ColorTan(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_tan();
  result := __skadapter__to_color(__skreturn);
end;
function ColorTeal(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_teal();
  result := __skadapter__to_color(__skreturn);
end;
function ColorThistle(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_thistle();
  result := __skadapter__to_color(__skreturn);
end;
function ColorToString(c: Color): String;
var
  __skparam__c: __sklib_color;
  __skreturn: __sklib_string;
begin
  __skparam__c := __skadapter__to_sklib_color(c);
  __skreturn := __sklib__color_to_string__color(__skparam__c);
  result := __skadapter__to_string(__skreturn);
end;
function ColorTomato(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_tomato();
  result := __skadapter__to_color(__skreturn);
end;
function ColorTransparent(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_transparent();
  result := __skadapter__to_color(__skreturn);
end;
function ColorTurquoise(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_turquoise();
  result := __skadapter__to_color(__skreturn);
end;
function ColorViolet(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_violet();
  result := __skadapter__to_color(__skreturn);
end;
function ColorWheat(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_wheat();
  result := __skadapter__to_color(__skreturn);
end;
function ColorWhite(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_white();
  result := __skadapter__to_color(__skreturn);
end;
function ColorWhiteSmoke(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_white_smoke();
  result := __skadapter__to_color(__skreturn);
end;
function ColorYellow(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_yellow();
  result := __skadapter__to_color(__skreturn);
end;
function ColorYellowGreen(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__color_yellow_green();
  result := __skadapter__to_color(__skreturn);
end;
function GreenOf(c: Color): Integer;
var
  __skparam__c: __sklib_color;
  __skreturn: Integer;
begin
  __skparam__c := __skadapter__to_sklib_color(c);
  __skreturn := __sklib__green_of__color(__skparam__c);
  result := __skadapter__to_int(__skreturn);
end;
function HSBColor(hue: Double; saturation: Double; brightness: Double): Color;
var
  __skparam__hue: Double;
  __skparam__saturation: Double;
  __skparam__brightness: Double;
  __skreturn: __sklib_color;
begin
  __skparam__hue := __skadapter__to_sklib_double(hue);
  __skparam__saturation := __skadapter__to_sklib_double(saturation);
  __skparam__brightness := __skadapter__to_sklib_double(brightness);
  __skreturn := __sklib__hsb_color__double__double__double(__skparam__hue, __skparam__saturation, __skparam__brightness);
  result := __skadapter__to_color(__skreturn);
end;
function HueOf(c: Color): Double;
var
  __skparam__c: __sklib_color;
  __skreturn: Double;
begin
  __skparam__c := __skadapter__to_sklib_color(c);
  __skreturn := __sklib__hue_of__color(__skparam__c);
  result := __skadapter__to_double(__skreturn);
end;
function RandomColor(): Color;
var
  __skreturn: __sklib_color;
begin
  __skreturn := __sklib__random_color();
  result := __skadapter__to_color(__skreturn);
end;
function RandomRGBColor(alpha: Integer): Color;
var
  __skparam__alpha: Integer;
  __skreturn: __sklib_color;
begin
  __skparam__alpha := __skadapter__to_sklib_int(alpha);
  __skreturn := __sklib__random_rgb_color__int(__skparam__alpha);
  result := __skadapter__to_color(__skreturn);
end;
function RedOf(c: Color): Integer;
var
  __skparam__c: __sklib_color;
  __skreturn: Integer;
begin
  __skparam__c := __skadapter__to_sklib_color(c);
  __skreturn := __sklib__red_of__color(__skparam__c);
  result := __skadapter__to_int(__skreturn);
end;
function RGBColor(red: Double; green: Double; blue: Double): Color;
var
  __skparam__red: Double;
  __skparam__green: Double;
  __skparam__blue: Double;
  __skreturn: __sklib_color;
begin
  __skparam__red := __skadapter__to_sklib_double(red);
  __skparam__green := __skadapter__to_sklib_double(green);
  __skparam__blue := __skadapter__to_sklib_double(blue);
  __skreturn := __sklib__rgb_color__double__double__double(__skparam__red, __skparam__green, __skparam__blue);
  result := __skadapter__to_color(__skreturn);
end;
function RGBColor(red: Integer; green: Integer; blue: Integer): Color;
var
  __skparam__red: Integer;
  __skparam__green: Integer;
  __skparam__blue: Integer;
  __skreturn: __sklib_color;
begin
  __skparam__red := __skadapter__to_sklib_int(red);
  __skparam__green := __skadapter__to_sklib_int(green);
  __skparam__blue := __skadapter__to_sklib_int(blue);
  __skreturn := __sklib__rgb_color__int__int__int(__skparam__red, __skparam__green, __skparam__blue);
  result := __skadapter__to_color(__skreturn);
end;
function RGBAColor(red: Double; green: Double; blue: Double; alpha: Double): Color;
var
  __skparam__red: Double;
  __skparam__green: Double;
  __skparam__blue: Double;
  __skparam__alpha: Double;
  __skreturn: __sklib_color;
begin
  __skparam__red := __skadapter__to_sklib_double(red);
  __skparam__green := __skadapter__to_sklib_double(green);
  __skparam__blue := __skadapter__to_sklib_double(blue);
  __skparam__alpha := __skadapter__to_sklib_double(alpha);
  __skreturn := __sklib__rgba_color__double__double__double__double(__skparam__red, __skparam__green, __skparam__blue, __skparam__alpha);
  result := __skadapter__to_color(__skreturn);
end;
function RGBAColor(red: Integer; green: Integer; blue: Integer; alpha: Integer): Color;
var
  __skparam__red: Integer;
  __skparam__green: Integer;
  __skparam__blue: Integer;
  __skparam__alpha: Integer;
  __skreturn: __sklib_color;
begin
  __skparam__red := __skadapter__to_sklib_int(red);
  __skparam__green := __skadapter__to_sklib_int(green);
  __skparam__blue := __skadapter__to_sklib_int(blue);
  __skparam__alpha := __skadapter__to_sklib_int(alpha);
  __skreturn := __sklib__rgba_color__int__int__int__int(__skparam__red, __skparam__green, __skparam__blue, __skparam__alpha);
  result := __skadapter__to_color(__skreturn);
end;
function SaturationOf(c: Color): Double;
var
  __skparam__c: __sklib_color;
  __skreturn: Double;
begin
  __skparam__c := __skadapter__to_sklib_color(c);
  __skreturn := __sklib__saturation_of__color(__skparam__c);
  result := __skadapter__to_double(__skreturn);
end;
function StringToColor(str: String): Color;
var
  __skparam__str: __sklib_string;
  __skreturn: __sklib_color;
begin
  __skparam__str := __skadapter__to_sklib_string(str);
  __skreturn := __sklib__string_to_color__string(__skparam__str);
  result := __skadapter__to_color(__skreturn);
end;
function OptionDefaults(): DrawingOptions;
var
  __skreturn: __sklib_drawing_options;
begin
  __skreturn := __sklib__option_defaults();
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionDrawTo(dest: Bitmap): DrawingOptions;
var
  __skparam__dest: __sklib_ptr;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__dest := __skadapter__to_sklib_bitmap(dest);
  __skreturn := __sklib__option_draw_to__bitmap(__skparam__dest);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionDrawTo(dest: Bitmap; opts: DrawingOptions): DrawingOptions;
var
  __skparam__dest: __sklib_ptr;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__dest := __skadapter__to_sklib_bitmap(dest);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_draw_to__bitmap__drawing_options(__skparam__dest, __skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionDrawTo(dest: Window): DrawingOptions;
var
  __skparam__dest: __sklib_ptr;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__dest := __skadapter__to_sklib_window(dest);
  __skreturn := __sklib__option_draw_to__window(__skparam__dest);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionDrawTo(dest: Window; opts: DrawingOptions): DrawingOptions;
var
  __skparam__dest: __sklib_ptr;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__dest := __skadapter__to_sklib_window(dest);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_draw_to__window__drawing_options(__skparam__dest, __skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionFlipX(): DrawingOptions;
var
  __skreturn: __sklib_drawing_options;
begin
  __skreturn := __sklib__option_flip_x();
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionFlipX(opts: DrawingOptions): DrawingOptions;
var
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_flip_x__drawing_options(__skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionFlipXy(): DrawingOptions;
var
  __skreturn: __sklib_drawing_options;
begin
  __skreturn := __sklib__option_flip_xy();
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionFlipXy(opts: DrawingOptions): DrawingOptions;
var
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_flip_xy__drawing_options(__skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionFlipY(): DrawingOptions;
var
  __skreturn: __sklib_drawing_options;
begin
  __skreturn := __sklib__option_flip_y();
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionFlipY(opts: DrawingOptions): DrawingOptions;
var
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_flip_y__drawing_options(__skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionLineWidth(width: Integer): DrawingOptions;
var
  __skparam__width: Integer;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__width := __skadapter__to_sklib_int(width);
  __skreturn := __sklib__option_line_width__int(__skparam__width);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionLineWidth(width: Integer; opts: DrawingOptions): DrawingOptions;
var
  __skparam__width: Integer;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__width := __skadapter__to_sklib_int(width);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_line_width__int__drawing_options(__skparam__width, __skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionPartBmp(x: Double; y: Double; w: Double; h: Double): DrawingOptions;
var
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__w: Double;
  __skparam__h: Double;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__w := __skadapter__to_sklib_double(w);
  __skparam__h := __skadapter__to_sklib_double(h);
  __skreturn := __sklib__option_part_bmp__double__double__double__double(__skparam__x, __skparam__y, __skparam__w, __skparam__h);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionPartBmp(x: Double; y: Double; w: Double; h: Double; opts: DrawingOptions): DrawingOptions;
var
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__w: Double;
  __skparam__h: Double;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__w := __skadapter__to_sklib_double(w);
  __skparam__h := __skadapter__to_sklib_double(h);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_part_bmp__double__double__double__double__drawing_options(__skparam__x, __skparam__y, __skparam__w, __skparam__h, __skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionPartBmp(part: Rectangle): DrawingOptions;
var
  __skparam__part: __sklib_rectangle;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__part := __skadapter__to_sklib_rectangle(part);
  __skreturn := __sklib__option_part_bmp__rectangle(__skparam__part);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionPartBmp(part: Rectangle; opts: DrawingOptions): DrawingOptions;
var
  __skparam__part: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__part := __skadapter__to_sklib_rectangle(part);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_part_bmp__rectangle__drawing_options(__skparam__part, __skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionRotateBmp(angle: Double): DrawingOptions;
var
  __skparam__angle: Double;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__angle := __skadapter__to_sklib_double(angle);
  __skreturn := __sklib__option_rotate_bmp__double(__skparam__angle);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionRotateBmp(angle: Double; anchorX: Double; anchorY: Double): DrawingOptions;
var
  __skparam__angle: Double;
  __skparam__anchor_x: Double;
  __skparam__anchor_y: Double;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__angle := __skadapter__to_sklib_double(angle);
  __skparam__anchor_x := __skadapter__to_sklib_double(anchorX);
  __skparam__anchor_y := __skadapter__to_sklib_double(anchorY);
  __skreturn := __sklib__option_rotate_bmp__double__double__double(__skparam__angle, __skparam__anchor_x, __skparam__anchor_y);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionRotateBmp(angle: Double; anchorX: Double; anchorY: Double; opts: DrawingOptions): DrawingOptions;
var
  __skparam__angle: Double;
  __skparam__anchor_x: Double;
  __skparam__anchor_y: Double;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__angle := __skadapter__to_sklib_double(angle);
  __skparam__anchor_x := __skadapter__to_sklib_double(anchorX);
  __skparam__anchor_y := __skadapter__to_sklib_double(anchorY);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_rotate_bmp__double__double__double__drawing_options(__skparam__angle, __skparam__anchor_x, __skparam__anchor_y, __skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionRotateBmp(angle: Double; opts: DrawingOptions): DrawingOptions;
var
  __skparam__angle: Double;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__angle := __skadapter__to_sklib_double(angle);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_rotate_bmp__double__drawing_options(__skparam__angle, __skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionScaleBmp(scaleX: Double; scaleY: Double): DrawingOptions;
var
  __skparam__scale_x: Double;
  __skparam__scale_y: Double;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__scale_x := __skadapter__to_sklib_double(scaleX);
  __skparam__scale_y := __skadapter__to_sklib_double(scaleY);
  __skreturn := __sklib__option_scale_bmp__double__double(__skparam__scale_x, __skparam__scale_y);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionScaleBmp(scaleX: Double; scaleY: Double; opts: DrawingOptions): DrawingOptions;
var
  __skparam__scale_x: Double;
  __skparam__scale_y: Double;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__scale_x := __skadapter__to_sklib_double(scaleX);
  __skparam__scale_y := __skadapter__to_sklib_double(scaleY);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_scale_bmp__double__double__drawing_options(__skparam__scale_x, __skparam__scale_y, __skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionToScreen(): DrawingOptions;
var
  __skreturn: __sklib_drawing_options;
begin
  __skreturn := __sklib__option_to_screen();
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionToScreen(opts: DrawingOptions): DrawingOptions;
var
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_to_screen__drawing_options(__skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionToWorld(): DrawingOptions;
var
  __skreturn: __sklib_drawing_options;
begin
  __skreturn := __sklib__option_to_world();
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionToWorld(opts: DrawingOptions): DrawingOptions;
var
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_to_world__drawing_options(__skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionWithAnimation(anim: Animation): DrawingOptions;
var
  __skparam__anim: __sklib_ptr;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skreturn := __sklib__option_with_animation__animation(__skparam__anim);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionWithAnimation(anim: Animation; opts: DrawingOptions): DrawingOptions;
var
  __skparam__anim: __sklib_ptr;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__anim := __skadapter__to_sklib_animation(anim);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_with_animation__animation__drawing_options(__skparam__anim, __skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionWithBitmapCell(cell: Integer): DrawingOptions;
var
  __skparam__cell: Integer;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skreturn := __sklib__option_with_bitmap_cell__int(__skparam__cell);
  result := __skadapter__to_drawing_options(__skreturn);
end;
function OptionWithBitmapCell(cell: Integer; opts: DrawingOptions): DrawingOptions;
var
  __skparam__cell: Integer;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: __sklib_drawing_options;
begin
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__option_with_bitmap_cell__int__drawing_options(__skparam__cell, __skparam__opts);
  result := __skadapter__to_drawing_options(__skreturn);
end;
procedure DrawEllipse(clr: Color; rect: Rectangle);
var
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__draw_ellipse__color__rectangle(__skparam__clr, __skparam__rect);
end;
procedure DrawEllipse(clr: Color; rect: Rectangle; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_ellipse__color__rectangle__drawing_options(__skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure DrawEllipse(clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__draw_ellipse__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure DrawEllipse(clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_ellipse__color__double__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
procedure DrawEllipseOnBitmap(destination: Bitmap; clr: Color; rect: Rectangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect);
end;
procedure DrawEllipseOnBitmap(destination: Bitmap; clr: Color; rect: Rectangle; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure DrawEllipseOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure DrawEllipseOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
procedure DrawEllipseOnWindow(destination: Window; clr: Color; rect: Rectangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__draw_ellipse_on_window__window__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect);
end;
procedure DrawEllipseOnWindow(destination: Window; clr: Color; rect: Rectangle; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_ellipse_on_window__window__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure DrawEllipseOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__draw_ellipse_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure DrawEllipseOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_ellipse_on_window__window__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
procedure FillEllipse(clr: Color; rect: Rectangle);
var
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__fill_ellipse__color__rectangle(__skparam__clr, __skparam__rect);
end;
procedure FillEllipse(clr: Color; rect: Rectangle; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_ellipse__color__rectangle__drawing_options(__skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure FillEllipse(clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__fill_ellipse__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure FillEllipse(clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_ellipse__color__double__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
procedure FillEllipseOnBitmap(destination: Bitmap; clr: Color; rect: Rectangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect);
end;
procedure FillEllipseOnBitmap(destination: Bitmap; clr: Color; rect: Rectangle; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure FillEllipseOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure FillEllipseOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
procedure FillEllipseOnWindow(destination: Window; clr: Color; rect: Rectangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__fill_ellipse_on_window__window__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect);
end;
procedure FillEllipseOnWindow(destination: Window; clr: Color; rect: Rectangle; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_ellipse_on_window__window__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure FillEllipseOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__fill_ellipse_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure FillEllipseOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_ellipse_on_window__window__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
function Cosine(degrees: Single): Single;
var
  __skparam__degrees: Single;
  __skreturn: Single;
begin
  __skparam__degrees := __skadapter__to_sklib_float(degrees);
  __skreturn := __sklib__cosine__float(__skparam__degrees);
  result := __skadapter__to_float(__skreturn);
end;
function Sine(degrees: Single): Single;
var
  __skparam__degrees: Single;
  __skreturn: Single;
begin
  __skparam__degrees := __skadapter__to_sklib_float(degrees);
  __skreturn := __sklib__sine__float(__skparam__degrees);
  result := __skadapter__to_float(__skreturn);
end;
function Tangent(degrees: Single): Single;
var
  __skparam__degrees: Single;
  __skreturn: Single;
begin
  __skparam__degrees := __skadapter__to_sklib_float(degrees);
  __skreturn := __sklib__tangent__float(__skparam__degrees);
  result := __skadapter__to_float(__skreturn);
end;
procedure ClearScreen();
begin
  __sklib__clear_screen();
end;
procedure ClearScreen(clr: Color);
var
  __skparam__clr: __sklib_color;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __sklib__clear_screen__color(__skparam__clr);
end;
function DisplayDetails(index: Cardinal): Display;
var
  __skparam__index: Cardinal;
  __skreturn: __sklib_ptr;
begin
  __skparam__index := __skadapter__to_sklib_unsigned_int(index);
  __skreturn := __sklib__display_details__unsigned_int(__skparam__index);
  result := __skadapter__to_display(__skreturn);
end;
function DisplayHeight(disp: Display): Integer;
var
  __skparam__disp: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__disp := __skadapter__to_sklib_display(disp);
  __skreturn := __sklib__display_height__display(__skparam__disp);
  result := __skadapter__to_int(__skreturn);
end;
function DisplayName(disp: Display): String;
var
  __skparam__disp: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__disp := __skadapter__to_sklib_display(disp);
  __skreturn := __sklib__display_name__display(__skparam__disp);
  result := __skadapter__to_string(__skreturn);
end;
function DisplayWidth(disp: Display): Integer;
var
  __skparam__disp: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__disp := __skadapter__to_sklib_display(disp);
  __skreturn := __sklib__display_width__display(__skparam__disp);
  result := __skadapter__to_int(__skreturn);
end;
function DisplayX(disp: Display): Integer;
var
  __skparam__disp: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__disp := __skadapter__to_sklib_display(disp);
  __skreturn := __sklib__display_x__display(__skparam__disp);
  result := __skadapter__to_int(__skreturn);
end;
function DisplayY(disp: Display): Integer;
var
  __skparam__disp: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__disp := __skadapter__to_sklib_display(disp);
  __skreturn := __sklib__display_y__display(__skparam__disp);
  result := __skadapter__to_int(__skreturn);
end;
function NumberOfDisplays(): Integer;
var
  __skreturn: Integer;
begin
  __skreturn := __sklib__number_of_displays();
  result := __skadapter__to_int(__skreturn);
end;
procedure RefreshScreen();
begin
  __sklib__refresh_screen();
end;
procedure RefreshScreen(targetFps: Cardinal);
var
  __skparam__target_fps: Cardinal;
begin
  __skparam__target_fps := __skadapter__to_sklib_unsigned_int(targetFps);
  __sklib__refresh_screen__unsigned_int(__skparam__target_fps);
end;
procedure SaveBitmap(bmp: Bitmap; const basename: String);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__basename: __sklib_string;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__basename := __skadapter__to_sklib_string(basename);
  __sklib__save_bitmap__bitmap__string_ref(__skparam__bmp, __skparam__basename);
end;
function ScreenHeight(): Integer;
var
  __skreturn: Integer;
begin
  __skreturn := __sklib__screen_height();
  result := __skadapter__to_int(__skreturn);
end;
function ScreenWidth(): Integer;
var
  __skreturn: Integer;
begin
  __skreturn := __sklib__screen_width();
  result := __skadapter__to_int(__skreturn);
end;
procedure TakeScreenshot(const basename: String);
var
  __skparam__basename: __sklib_string;
begin
  __skparam__basename := __skadapter__to_sklib_string(basename);
  __sklib__take_screenshot__string_ref(__skparam__basename);
end;
procedure TakeScreenshot(wind: Window; const basename: String);
var
  __skparam__wind: __sklib_ptr;
  __skparam__basename: __sklib_string;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skparam__basename := __skadapter__to_sklib_string(basename);
  __sklib__take_screenshot__window__string_ref(__skparam__wind, __skparam__basename);
end;
function BitmapBoundingCircle(bmp: Bitmap; const pt: Point2D): Circle;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_circle;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__bitmap_bounding_circle__bitmap__point_2d_ref(__skparam__bmp, __skparam__pt);
  result := __skadapter__to_circle(__skreturn);
end;
function BitmapBoundingRectangle(bmp: Bitmap): Rectangle;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: __sklib_rectangle;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_bounding_rectangle__bitmap(__skparam__bmp);
  result := __skadapter__to_rectangle(__skreturn);
end;
function BitmapBoundingRectangle(bmp: Bitmap; x: Double; y: Double): Rectangle;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: __sklib_rectangle;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__bitmap_bounding_rectangle__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y);
  result := __skadapter__to_rectangle(__skreturn);
end;
function BitmapCellCenter(bmp: Bitmap): Point2D;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: __sklib_point_2d;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_cell_center__bitmap(__skparam__bmp);
  result := __skadapter__to_point_2d(__skreturn);
end;
function BitmapCellCircle(bmp: Bitmap; x: Double; y: Double): Circle;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: __sklib_circle;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__bitmap_cell_circle__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y);
  result := __skadapter__to_circle(__skreturn);
end;
function BitmapCellCircle(bmp: Bitmap; pt: Point2D): Circle;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_circle;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__bitmap_cell_circle__bitmap__point_2d(__skparam__bmp, __skparam__pt);
  result := __skadapter__to_circle(__skreturn);
end;
function BitmapCellCircle(bmp: Bitmap; pt: Point2D; scale: Double): Circle;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skparam__scale: Double;
  __skreturn: __sklib_circle;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__scale := __skadapter__to_sklib_double(scale);
  __skreturn := __sklib__bitmap_cell_circle__bitmap__point_2d__double(__skparam__bmp, __skparam__pt, __skparam__scale);
  result := __skadapter__to_circle(__skreturn);
end;
function BitmapCellColumns(bmp: Bitmap): Integer;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_cell_columns__bitmap(__skparam__bmp);
  result := __skadapter__to_int(__skreturn);
end;
function BitmapCellCount(bmp: Bitmap): Integer;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_cell_count__bitmap(__skparam__bmp);
  result := __skadapter__to_int(__skreturn);
end;
function BitmapCellHeight(bmp: Bitmap): Integer;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_cell_height__bitmap(__skparam__bmp);
  result := __skadapter__to_int(__skreturn);
end;
function BitmapCellOffset(src: Bitmap; cell: Integer): Vector2D;
var
  __skparam__src: __sklib_ptr;
  __skparam__cell: Integer;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__src := __skadapter__to_sklib_bitmap(src);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skreturn := __sklib__bitmap_cell_offset__bitmap__int(__skparam__src, __skparam__cell);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function BitmapCellRectangle(src: Bitmap): Rectangle;
var
  __skparam__src: __sklib_ptr;
  __skreturn: __sklib_rectangle;
begin
  __skparam__src := __skadapter__to_sklib_bitmap(src);
  __skreturn := __sklib__bitmap_cell_rectangle__bitmap(__skparam__src);
  result := __skadapter__to_rectangle(__skreturn);
end;
function BitmapCellRectangle(src: Bitmap; const pt: Point2D): Rectangle;
var
  __skparam__src: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_rectangle;
begin
  __skparam__src := __skadapter__to_sklib_bitmap(src);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__bitmap_cell_rectangle__bitmap__point_2d_ref(__skparam__src, __skparam__pt);
  result := __skadapter__to_rectangle(__skreturn);
end;
function BitmapCellRows(bmp: Bitmap): Integer;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_cell_rows__bitmap(__skparam__bmp);
  result := __skadapter__to_int(__skreturn);
end;
function BitmapCellWidth(bmp: Bitmap): Integer;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_cell_width__bitmap(__skparam__bmp);
  result := __skadapter__to_int(__skreturn);
end;
function BitmapCenter(bmp: Bitmap): Point2D;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: __sklib_point_2d;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_center__bitmap(__skparam__bmp);
  result := __skadapter__to_point_2d(__skreturn);
end;
function BitmapFilename(bmp: Bitmap): String;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_filename__bitmap(__skparam__bmp);
  result := __skadapter__to_string(__skreturn);
end;
function BitmapHeight(bmp: Bitmap): Integer;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_height__bitmap(__skparam__bmp);
  result := __skadapter__to_int(__skreturn);
end;
function BitmapHeight(name: String): Integer;
var
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__bitmap_height__string(__skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
function BitmapName(bmp: Bitmap): String;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_name__bitmap(__skparam__bmp);
  result := __skadapter__to_string(__skreturn);
end;
function BitmapNamed(name: String): Bitmap;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__bitmap_named__string(__skparam__name);
  result := __skadapter__to_bitmap(__skreturn);
end;
function BitmapRectangleOfCell(src: Bitmap; cell: Integer): Rectangle;
var
  __skparam__src: __sklib_ptr;
  __skparam__cell: Integer;
  __skreturn: __sklib_rectangle;
begin
  __skparam__src := __skadapter__to_sklib_bitmap(src);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skreturn := __sklib__bitmap_rectangle_of_cell__bitmap__int(__skparam__src, __skparam__cell);
  result := __skadapter__to_rectangle(__skreturn);
end;
procedure BitmapSetCellDetails(bmp: Bitmap; width: Integer; height: Integer; columns: Integer; rows: Integer; count: Integer);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__width: Integer;
  __skparam__height: Integer;
  __skparam__columns: Integer;
  __skparam__rows: Integer;
  __skparam__count: Integer;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__width := __skadapter__to_sklib_int(width);
  __skparam__height := __skadapter__to_sklib_int(height);
  __skparam__columns := __skadapter__to_sklib_int(columns);
  __skparam__rows := __skadapter__to_sklib_int(rows);
  __skparam__count := __skadapter__to_sklib_int(count);
  __sklib__bitmap_set_cell_details__bitmap__int__int__int__int__int(__skparam__bmp, __skparam__width, __skparam__height, __skparam__columns, __skparam__rows, __skparam__count);
end;
function BitmapValid(bmp: Bitmap): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_valid__bitmap(__skparam__bmp);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapWidth(bmp: Bitmap): Integer;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_width__bitmap(__skparam__bmp);
  result := __skadapter__to_int(__skreturn);
end;
function BitmapWidth(name: String): Integer;
var
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__bitmap_width__string(__skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
procedure ClearBitmap(bmp: Bitmap; clr: Color);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__clr: __sklib_color;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __sklib__clear_bitmap__bitmap__color(__skparam__bmp, __skparam__clr);
end;
procedure ClearBitmap(name: String; clr: Color);
var
  __skparam__name: __sklib_string;
  __skparam__clr: __sklib_color;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __sklib__clear_bitmap__string__color(__skparam__name, __skparam__clr);
end;
function CreateBitmap(name: String; width: Integer; height: Integer): Bitmap;
var
  __skparam__name: __sklib_string;
  __skparam__width: Integer;
  __skparam__height: Integer;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__width := __skadapter__to_sklib_int(width);
  __skparam__height := __skadapter__to_sklib_int(height);
  __skreturn := __sklib__create_bitmap__string__int__int(__skparam__name, __skparam__width, __skparam__height);
  result := __skadapter__to_bitmap(__skreturn);
end;
procedure DrawBitmap(bmp: Bitmap; x: Double; y: Double);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_bitmap__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y);
end;
procedure DrawBitmap(bmp: Bitmap; x: Double; y: Double; opts: DrawingOptions);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_bitmap__bitmap__double__double__drawing_options(__skparam__bmp, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawBitmap(name: String; x: Double; y: Double);
var
  __skparam__name: __sklib_string;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_bitmap__string__double__double(__skparam__name, __skparam__x, __skparam__y);
end;
procedure DrawBitmap(name: String; x: Double; y: Double; opts: DrawingOptions);
var
  __skparam__name: __sklib_string;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_bitmap__string__double__double__drawing_options(__skparam__name, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawBitmapOnBitmap(destination: Bitmap; bmp: Bitmap; x: Double; y: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y);
end;
procedure DrawBitmapOnBitmap(destination: Bitmap; bmp: Bitmap; x: Double; y: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double__drawing_options(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawBitmapOnWindow(destination: Window; bmp: Bitmap; x: Double; y: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_bitmap_on_window__window__bitmap__double__double(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y);
end;
procedure DrawBitmapOnWindow(destination: Window; bmp: Bitmap; x: Double; y: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_bitmap_on_window__window__bitmap__double__double__drawing_options(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure FreeAllBitmaps();
begin
  __sklib__free_all_bitmaps();
end;
procedure FreeBitmap(toDelete: Bitmap);
var
  __skparam__to_delete: __sklib_ptr;
begin
  __skparam__to_delete := __skadapter__to_sklib_bitmap(toDelete);
  __sklib__free_bitmap__bitmap(__skparam__to_delete);
end;
function HasBitmap(name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_bitmap__string(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function LoadBitmap(name: String; filename: String): Bitmap;
var
  __skparam__name: __sklib_string;
  __skparam__filename: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __skreturn := __sklib__load_bitmap__string__string(__skparam__name, __skparam__filename);
  result := __skadapter__to_bitmap(__skreturn);
end;
function PixelDrawnAtPoint(bmp: Bitmap; const pt: Point2D): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__pixel_drawn_at_point__bitmap__point_2d_ref(__skparam__bmp, __skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function PixelDrawnAtPoint(bmp: Bitmap; x: Double; y: Double): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__pixel_drawn_at_point__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y);
  result := __skadapter__to_bool(__skreturn);
end;
function PixelDrawnAtPoint(bmp: Bitmap; cell: Integer; const pt: Point2D): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__pixel_drawn_at_point__bitmap__int__point_2d_ref(__skparam__bmp, __skparam__cell, __skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function PixelDrawnAtPoint(bmp: Bitmap; cell: Integer; x: Double; y: Double): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__cell: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__cell := __skadapter__to_sklib_int(cell);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__pixel_drawn_at_point__bitmap__int__double__double(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y);
  result := __skadapter__to_bool(__skreturn);
end;
procedure SetupCollisionMask(bmp: Bitmap);
var
  __skparam__bmp: __sklib_ptr;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __sklib__setup_collision_mask__bitmap(__skparam__bmp);
end;
procedure ProcessEvents();
begin
  __sklib__process_events();
end;
function QuitRequested(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__quit_requested();
  result := __skadapter__to_bool(__skreturn);
end;
procedure ResetQuit();
begin
  __sklib__reset_quit();
end;
procedure AddColumn(width: Integer);
var
  __skparam__width: Integer;
begin
  __skparam__width := __skadapter__to_sklib_int(width);
  __sklib__add_column__int(__skparam__width);
end;
procedure AddColumnRelative(width: Double);
var
  __skparam__width: Double;
begin
  __skparam__width := __skadapter__to_sklib_double(width);
  __sklib__add_column_relative__double(__skparam__width);
end;
function BitmapButton(bmp: Bitmap): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_button__bitmap(__skparam__bmp);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapButton(bmp: Bitmap; const rect: Rectangle): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__bitmap_button__bitmap__rectangle_ref(__skparam__bmp, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapButton(bmp: Bitmap; const rect: Rectangle; opts: DrawingOptions): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__bitmap_button__bitmap__rectangle_ref__drawing_options(__skparam__bmp, __skparam__rect, __skparam__opts);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapButton(bmp: Bitmap; opts: DrawingOptions): Boolean;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: LongInt;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__bitmap_button__bitmap__drawing_options(__skparam__bmp, __skparam__opts);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapButton(const labelText: String; bmp: Bitmap): Boolean;
var
  __skparam__label_text: __sklib_string;
  __skparam__bmp: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__bitmap_button__string_ref__bitmap(__skparam__label_text, __skparam__bmp);
  result := __skadapter__to_bool(__skreturn);
end;
function BitmapButton(const labelText: String; bmp: Bitmap; opts: DrawingOptions): Boolean;
var
  __skparam__label_text: __sklib_string;
  __skparam__bmp: __sklib_ptr;
  __skparam__opts: __sklib_drawing_options;
  __skreturn: LongInt;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __skreturn := __sklib__bitmap_button__string_ref__bitmap__drawing_options(__skparam__label_text, __skparam__bmp, __skparam__opts);
  result := __skadapter__to_bool(__skreturn);
end;
function Button(const text: String; const rect: Rectangle): Boolean;
var
  __skparam__text: __sklib_string;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__button__string_ref__rectangle_ref(__skparam__text, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function Button(const text: String): Boolean;
var
  __skparam__text: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skreturn := __sklib__button__string_ref(__skparam__text);
  result := __skadapter__to_bool(__skreturn);
end;
function Button(const labelText: String; const text: String): Boolean;
var
  __skparam__label_text: __sklib_string;
  __skparam__text: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skreturn := __sklib__button__string_ref__string_ref(__skparam__label_text, __skparam__text);
  result := __skadapter__to_bool(__skreturn);
end;
function Checkbox(const text: String; const value: Boolean; const rect: Rectangle): Boolean;
var
  __skparam__text: __sklib_string;
  __skparam__value: LongInt;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__value := __skadapter__to_sklib_bool(value);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__checkbox__string_ref__bool_ref__rectangle_ref(__skparam__text, __skparam__value, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function Checkbox(const text: String; const value: Boolean): Boolean;
var
  __skparam__text: __sklib_string;
  __skparam__value: LongInt;
  __skreturn: LongInt;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__value := __skadapter__to_sklib_bool(value);
  __skreturn := __sklib__checkbox__string_ref__bool_ref(__skparam__text, __skparam__value);
  result := __skadapter__to_bool(__skreturn);
end;
function Checkbox(const labelText: String; const text: String; const value: Boolean): Boolean;
var
  __skparam__label_text: __sklib_string;
  __skparam__text: __sklib_string;
  __skparam__value: LongInt;
  __skreturn: LongInt;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__value := __skadapter__to_sklib_bool(value);
  __skreturn := __sklib__checkbox__string_ref__string_ref__bool_ref(__skparam__label_text, __skparam__text, __skparam__value);
  result := __skadapter__to_bool(__skreturn);
end;
function ColorSlider(const clr: Color; const rect: Rectangle): Color;
var
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skreturn: __sklib_color;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__color_slider__color_ref__rectangle_ref(__skparam__clr, __skparam__rect);
  result := __skadapter__to_color(__skreturn);
end;
function ColorSlider(const clr: Color): Color;
var
  __skparam__clr: __sklib_color;
  __skreturn: __sklib_color;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skreturn := __sklib__color_slider__color_ref(__skparam__clr);
  result := __skadapter__to_color(__skreturn);
end;
function ColorSlider(const labelText: String; const clr: Color): Color;
var
  __skparam__label_text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skreturn: __sklib_color;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skreturn := __sklib__color_slider__string_ref__color_ref(__skparam__label_text, __skparam__clr);
  result := __skadapter__to_color(__skreturn);
end;
procedure DisableInterface();
begin
  __sklib__disable_interface();
end;
procedure DrawInterface();
begin
  __sklib__draw_interface();
end;
procedure EnableInterface();
begin
  __sklib__enable_interface();
end;
procedure EndInset(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__end_inset__string_ref(__skparam__name);
end;
procedure EndPanel(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__end_panel__string_ref(__skparam__name);
end;
procedure EndPopup(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__end_popup__string_ref(__skparam__name);
end;
procedure EndTreenode(const labelText: String);
var
  __skparam__label_text: __sklib_string;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __sklib__end_treenode__string_ref(__skparam__label_text);
end;
procedure EnterColumn();
begin
  __sklib__enter_column();
end;
function GetInterfaceLabelWidth(): Integer;
var
  __skreturn: Integer;
begin
  __skreturn := __sklib__get_interface_label_width();
  result := __skadapter__to_int(__skreturn);
end;
function Header(const labelText: String): Boolean;
var
  __skparam__label_text: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __skreturn := __sklib__header__string_ref(__skparam__label_text);
  result := __skadapter__to_bool(__skreturn);
end;
function HSBColorSlider(const clr: Color; const rect: Rectangle): Color;
var
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skreturn: __sklib_color;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__hsb_color_slider__color_ref__rectangle_ref(__skparam__clr, __skparam__rect);
  result := __skadapter__to_color(__skreturn);
end;
function HSBColorSlider(const clr: Color): Color;
var
  __skparam__clr: __sklib_color;
  __skreturn: __sklib_color;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skreturn := __sklib__hsb_color_slider__color_ref(__skparam__clr);
  result := __skadapter__to_color(__skreturn);
end;
function HSBColorSlider(const labelText: String; const clr: Color): Color;
var
  __skparam__label_text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skreturn: __sklib_color;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skreturn := __sklib__hsb_color_slider__string_ref__color_ref(__skparam__label_text, __skparam__clr);
  result := __skadapter__to_color(__skreturn);
end;
function InterfaceEnabled(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__interface_enabled();
  result := __skadapter__to_bool(__skreturn);
end;
procedure InterfaceStylePanel(const initialRectangle: Rectangle);
var
  __skparam__initial_rectangle: __sklib_rectangle;
begin
  __skparam__initial_rectangle := __skadapter__to_sklib_rectangle(initialRectangle);
  __sklib__interface_style_panel__rectangle_ref(__skparam__initial_rectangle);
end;
procedure LabelElement(const text: String);
var
  __skparam__text: __sklib_string;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __sklib__label_element__string_ref(__skparam__text);
end;
procedure LabelElement(const text: String; const rect: Rectangle);
var
  __skparam__text: __sklib_string;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__label_element__string_ref__rectangle_ref(__skparam__text, __skparam__rect);
end;
function LastElementChanged(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__last_element_changed();
  result := __skadapter__to_bool(__skreturn);
end;
function LastElementConfirmed(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__last_element_confirmed();
  result := __skadapter__to_bool(__skreturn);
end;
procedure LeaveColumn();
begin
  __sklib__leave_column();
end;
function NumberBox(const value: Single; step: Single; const rect: Rectangle): Single;
var
  __skparam__value: Single;
  __skparam__step: Single;
  __skparam__rect: __sklib_rectangle;
  __skreturn: Single;
begin
  __skparam__value := __skadapter__to_sklib_float(value);
  __skparam__step := __skadapter__to_sklib_float(step);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__number_box__float_ref__float__rectangle_ref(__skparam__value, __skparam__step, __skparam__rect);
  result := __skadapter__to_float(__skreturn);
end;
function NumberBox(const value: Single; step: Single): Single;
var
  __skparam__value: Single;
  __skparam__step: Single;
  __skreturn: Single;
begin
  __skparam__value := __skadapter__to_sklib_float(value);
  __skparam__step := __skadapter__to_sklib_float(step);
  __skreturn := __sklib__number_box__float_ref__float(__skparam__value, __skparam__step);
  result := __skadapter__to_float(__skreturn);
end;
function NumberBox(const labelText: String; const value: Single; step: Single): Single;
var
  __skparam__label_text: __sklib_string;
  __skparam__value: Single;
  __skparam__step: Single;
  __skreturn: Single;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __skparam__value := __skadapter__to_sklib_float(value);
  __skparam__step := __skadapter__to_sklib_float(step);
  __skreturn := __sklib__number_box__string_ref__float_ref__float(__skparam__label_text, __skparam__value, __skparam__step);
  result := __skadapter__to_float(__skreturn);
end;
procedure OpenPopup(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__open_popup__string_ref(__skparam__name);
end;
procedure Paragraph(const text: String);
var
  __skparam__text: __sklib_string;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __sklib__paragraph__string_ref(__skparam__text);
end;
procedure Paragraph(const text: String; const rect: Rectangle);
var
  __skparam__text: __sklib_string;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__paragraph__string_ref__rectangle_ref(__skparam__text, __skparam__rect);
end;
procedure ResetLayout();
begin
  __sklib__reset_layout();
end;
procedure SetInterfaceAccentColor(clr: Color; contrast: Single);
var
  __skparam__clr: __sklib_color;
  __skparam__contrast: Single;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__contrast := __skadapter__to_sklib_float(contrast);
  __sklib__set_interface_accent_color__color__float(__skparam__clr, __skparam__contrast);
end;
procedure SetInterfaceBorderColor(clr: Color);
var
  __skparam__clr: __sklib_color;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __sklib__set_interface_border_color__color(__skparam__clr);
end;
procedure SetInterfaceColorsAuto(mainClr: Color; accentClr: Color; contrast: Single; accentContrast: Single; borderContrast: Single);
var
  __skparam__main_clr: __sklib_color;
  __skparam__accent_clr: __sklib_color;
  __skparam__contrast: Single;
  __skparam__accent_contrast: Single;
  __skparam__border_contrast: Single;
begin
  __skparam__main_clr := __skadapter__to_sklib_color(mainClr);
  __skparam__accent_clr := __skadapter__to_sklib_color(accentClr);
  __skparam__contrast := __skadapter__to_sklib_float(contrast);
  __skparam__accent_contrast := __skadapter__to_sklib_float(accentContrast);
  __skparam__border_contrast := __skadapter__to_sklib_float(borderContrast);
  __sklib__set_interface_colors_auto__color__color__float__float__float(__skparam__main_clr, __skparam__accent_clr, __skparam__contrast, __skparam__accent_contrast, __skparam__border_contrast);
end;
procedure SetInterfaceElementColor(clr: Color; contrast: Single);
var
  __skparam__clr: __sklib_color;
  __skparam__contrast: Single;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__contrast := __skadapter__to_sklib_float(contrast);
  __sklib__set_interface_element_color__color__float(__skparam__clr, __skparam__contrast);
end;
procedure SetInterfaceElementShadows(radius: Integer; clr: Color; offset: Point2D);
var
  __skparam__radius: Integer;
  __skparam__clr: __sklib_color;
  __skparam__offset: __sklib_point_2d;
begin
  __skparam__radius := __skadapter__to_sklib_int(radius);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__offset := __skadapter__to_sklib_point_2d(offset);
  __sklib__set_interface_element_shadows__int__color__point_2d(__skparam__radius, __skparam__clr, __skparam__offset);
end;
procedure SetInterfaceFont(const fnt: String);
var
  __skparam__fnt: __sklib_string;
begin
  __skparam__fnt := __skadapter__to_sklib_string(fnt);
  __sklib__set_interface_font__string_ref(__skparam__fnt);
end;
procedure SetInterfaceFont(fnt: Font);
var
  __skparam__fnt: __sklib_ptr;
begin
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __sklib__set_interface_font__font(__skparam__fnt);
end;
procedure SetInterfaceFontSize(size: Integer);
var
  __skparam__size: Integer;
begin
  __skparam__size := __skadapter__to_sklib_int(size);
  __sklib__set_interface_font_size__int(__skparam__size);
end;
procedure SetInterfaceLabelWidth(width: Integer);
var
  __skparam__width: Integer;
begin
  __skparam__width := __skadapter__to_sklib_int(width);
  __sklib__set_interface_label_width__int(__skparam__width);
end;
procedure SetInterfacePanelShadows(radius: Integer; clr: Color; offset: Point2D);
var
  __skparam__radius: Integer;
  __skparam__clr: __sklib_color;
  __skparam__offset: __sklib_point_2d;
begin
  __skparam__radius := __skadapter__to_sklib_int(radius);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__offset := __skadapter__to_sklib_point_2d(offset);
  __sklib__set_interface_panel_shadows__int__color__point_2d(__skparam__radius, __skparam__clr, __skparam__offset);
end;
procedure SetInterfaceRootTextColor(clr: Color);
var
  __skparam__clr: __sklib_color;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __sklib__set_interface_root_text_color__color(__skparam__clr);
end;
procedure SetInterfaceShadows(radius: Integer; clr: Color; offset: Point2D);
var
  __skparam__radius: Integer;
  __skparam__clr: __sklib_color;
  __skparam__offset: __sklib_point_2d;
begin
  __skparam__radius := __skadapter__to_sklib_int(radius);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__offset := __skadapter__to_sklib_point_2d(offset);
  __sklib__set_interface_shadows__int__color__point_2d(__skparam__radius, __skparam__clr, __skparam__offset);
end;
procedure SetInterfaceSpacing(spacing: Integer; padding: Integer);
var
  __skparam__spacing: Integer;
  __skparam__padding: Integer;
begin
  __skparam__spacing := __skadapter__to_sklib_int(spacing);
  __skparam__padding := __skadapter__to_sklib_int(padding);
  __sklib__set_interface_spacing__int__int(__skparam__spacing, __skparam__padding);
end;
procedure SetInterfaceStyle(style: InterfaceStyle);
var
  __skparam__style: LongInt;
begin
  __skparam__style := __skadapter__to_sklib_interface_style(style);
  __sklib__set_interface_style__interface_style(__skparam__style);
end;
procedure SetInterfaceStyle(style: InterfaceStyle; clr: Color);
var
  __skparam__style: LongInt;
  __skparam__clr: __sklib_color;
begin
  __skparam__style := __skadapter__to_sklib_interface_style(style);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __sklib__set_interface_style__interface_style__color(__skparam__style, __skparam__clr);
end;
procedure SetInterfaceTextColor(clr: Color);
var
  __skparam__clr: __sklib_color;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __sklib__set_interface_text_color__color(__skparam__clr);
end;
procedure SetLayoutHeight(height: Integer);
var
  __skparam__height: Integer;
begin
  __skparam__height := __skadapter__to_sklib_int(height);
  __sklib__set_layout_height__int(__skparam__height);
end;
procedure SingleLineLayout();
begin
  __sklib__single_line_layout();
end;
function Slider(const value: Single; minValue: Single; maxValue: Single; const rect: Rectangle): Single;
var
  __skparam__value: Single;
  __skparam__min_value: Single;
  __skparam__max_value: Single;
  __skparam__rect: __sklib_rectangle;
  __skreturn: Single;
begin
  __skparam__value := __skadapter__to_sklib_float(value);
  __skparam__min_value := __skadapter__to_sklib_float(minValue);
  __skparam__max_value := __skadapter__to_sklib_float(maxValue);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__slider__float_ref__float__float__rectangle_ref(__skparam__value, __skparam__min_value, __skparam__max_value, __skparam__rect);
  result := __skadapter__to_float(__skreturn);
end;
function Slider(const value: Single; minValue: Single; maxValue: Single): Single;
var
  __skparam__value: Single;
  __skparam__min_value: Single;
  __skparam__max_value: Single;
  __skreturn: Single;
begin
  __skparam__value := __skadapter__to_sklib_float(value);
  __skparam__min_value := __skadapter__to_sklib_float(minValue);
  __skparam__max_value := __skadapter__to_sklib_float(maxValue);
  __skreturn := __sklib__slider__float_ref__float__float(__skparam__value, __skparam__min_value, __skparam__max_value);
  result := __skadapter__to_float(__skreturn);
end;
function Slider(const labelText: String; const value: Single; minValue: Single; maxValue: Single): Single;
var
  __skparam__label_text: __sklib_string;
  __skparam__value: Single;
  __skparam__min_value: Single;
  __skparam__max_value: Single;
  __skreturn: Single;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __skparam__value := __skadapter__to_sklib_float(value);
  __skparam__min_value := __skadapter__to_sklib_float(minValue);
  __skparam__max_value := __skadapter__to_sklib_float(maxValue);
  __skreturn := __sklib__slider__string_ref__float_ref__float__float(__skparam__label_text, __skparam__value, __skparam__min_value, __skparam__max_value);
  result := __skadapter__to_float(__skreturn);
end;
procedure SplitIntoColumns(count: Integer);
var
  __skparam__count: Integer;
begin
  __skparam__count := __skadapter__to_sklib_int(count);
  __sklib__split_into_columns__int(__skparam__count);
end;
procedure SplitIntoColumns(count: Integer; lastWidth: Integer);
var
  __skparam__count: Integer;
  __skparam__last_width: Integer;
begin
  __skparam__count := __skadapter__to_sklib_int(count);
  __skparam__last_width := __skadapter__to_sklib_int(lastWidth);
  __sklib__split_into_columns__int__int(__skparam__count, __skparam__last_width);
end;
procedure SplitIntoColumnsRelative(count: Integer; lastWidth: Double);
var
  __skparam__count: Integer;
  __skparam__last_width: Double;
begin
  __skparam__count := __skadapter__to_sklib_int(count);
  __skparam__last_width := __skadapter__to_sklib_double(lastWidth);
  __sklib__split_into_columns_relative__int__double(__skparam__count, __skparam__last_width);
end;
procedure StartCustomLayout();
begin
  __sklib__start_custom_layout();
end;
procedure StartInset(const name: String; const rect: Rectangle);
var
  __skparam__name: __sklib_string;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__start_inset__string_ref__rectangle_ref(__skparam__name, __skparam__rect);
end;
procedure StartInset(const name: String; height: Integer);
var
  __skparam__name: __sklib_string;
  __skparam__height: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__height := __skadapter__to_sklib_int(height);
  __sklib__start_inset__string_ref__int(__skparam__name, __skparam__height);
end;
function StartPanel(const name: String; initialRectangle: Rectangle): Boolean;
var
  __skparam__name: __sklib_string;
  __skparam__initial_rectangle: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__initial_rectangle := __skadapter__to_sklib_rectangle(initialRectangle);
  __skreturn := __sklib__start_panel__string_ref__rectangle(__skparam__name, __skparam__initial_rectangle);
  result := __skadapter__to_bool(__skreturn);
end;
function StartPopup(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__start_popup__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function StartTreenode(const labelText: String): Boolean;
var
  __skparam__label_text: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __skreturn := __sklib__start_treenode__string_ref(__skparam__label_text);
  result := __skadapter__to_bool(__skreturn);
end;
function TextBox(const value: String): String;
var
  __skparam__value: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__value := __skadapter__to_sklib_string(value);
  __skreturn := __sklib__text_box__string_ref(__skparam__value);
  result := __skadapter__to_string(__skreturn);
end;
function TextBox(const value: String; const rect: Rectangle): String;
var
  __skparam__value: __sklib_string;
  __skparam__rect: __sklib_rectangle;
  __skreturn: __sklib_string;
begin
  __skparam__value := __skadapter__to_sklib_string(value);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__text_box__string_ref__rectangle_ref(__skparam__value, __skparam__rect);
  result := __skadapter__to_string(__skreturn);
end;
function TextBox(const labelText: String; const value: String): String;
var
  __skparam__label_text: __sklib_string;
  __skparam__value: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__label_text := __skadapter__to_sklib_string(labelText);
  __skparam__value := __skadapter__to_sklib_string(value);
  __skreturn := __sklib__text_box__string_ref__string_ref(__skparam__label_text, __skparam__value);
  result := __skadapter__to_string(__skreturn);
end;
function CreateJson(): Json;
var
  __skreturn: __sklib_ptr;
begin
  __skreturn := __sklib__create_json();
  result := __skadapter__to_json(__skreturn);
end;
function CreateJson(jsonString: String): Json;
var
  __skparam__json_string: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__json_string := __skadapter__to_sklib_string(jsonString);
  __skreturn := __sklib__create_json__string(__skparam__json_string);
  result := __skadapter__to_json(__skreturn);
end;
procedure FreeAllJson();
begin
  __sklib__free_all_json();
end;
procedure FreeJson(j: Json);
var
  __skparam__j: __sklib_ptr;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __sklib__free_json__json(__skparam__j);
end;
function JsonCountKeys(j: Json): Integer;
var
  __skparam__j: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skreturn := __sklib__json_count_keys__json(__skparam__j);
  result := __skadapter__to_int(__skreturn);
end;
function JsonFromColor(clr: Color): Json;
var
  __skparam__clr: __sklib_color;
  __skreturn: __sklib_ptr;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skreturn := __sklib__json_from_color__color(__skparam__clr);
  result := __skadapter__to_json(__skreturn);
end;
function JsonFromFile(const filename: String): Json;
var
  __skparam__filename: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __skreturn := __sklib__json_from_file__string_ref(__skparam__filename);
  result := __skadapter__to_json(__skreturn);
end;
function JsonFromString(const jString: String): Json;
var
  __skparam__j_string: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__j_string := __skadapter__to_sklib_string(jString);
  __skreturn := __sklib__json_from_string__string_ref(__skparam__j_string);
  result := __skadapter__to_json(__skreturn);
end;
function JsonHasKey(j: Json; key: String): Boolean;
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skreturn := __sklib__json_has_key__json__string(__skparam__j, __skparam__key);
  result := __skadapter__to_bool(__skreturn);
end;
procedure JsonReadArray(j: Json; key: String; var outResult: ArrayOfDouble);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__out_result: __sklib_vector_double;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__out_result := __skadapter__to_sklib_vector_double(outResult);
  __sklib__json_read_array__json__string__vector_double_ref(__skparam__j, __skparam__key, __skparam__out_result);
  outResult := __skadapter__to_vector_double(__skparam__out_result);
end;
procedure JsonReadArray(j: Json; key: String; var outResult: ArrayOfJson);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__out_result: __sklib_vector_json;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__out_result := __skadapter__to_sklib_vector_json(outResult);
  __sklib__json_read_array__json__string__vector_json_ref(__skparam__j, __skparam__key, __skparam__out_result);
  outResult := __skadapter__to_vector_json(__skparam__out_result);
end;
procedure JsonReadArray(j: Json; key: String; var outResult: ArrayOfString);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__out_result: __sklib_vector_string;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__out_result := __skadapter__to_sklib_vector_string(outResult);
  __sklib__json_read_array__json__string__vector_string_ref(__skparam__j, __skparam__key, __skparam__out_result);
  outResult := __skadapter__to_vector_string(__skparam__out_result);
end;
procedure JsonReadArray(j: Json; key: String; var outResult: ArrayOfBoolean);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__out_result: __sklib_vector_bool;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__out_result := __skadapter__to_sklib_vector_bool(outResult);
  __sklib__json_read_array__json__string__vector_bool_ref(__skparam__j, __skparam__key, __skparam__out_result);
  outResult := __skadapter__to_vector_bool(__skparam__out_result);
end;
function JsonReadBool(j: Json; key: String): Boolean;
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skreturn := __sklib__json_read_bool__json__string(__skparam__j, __skparam__key);
  result := __skadapter__to_bool(__skreturn);
end;
function JsonReadNumber(j: Json; key: String): Single;
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skreturn: Single;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skreturn := __sklib__json_read_number__json__string(__skparam__j, __skparam__key);
  result := __skadapter__to_float(__skreturn);
end;
function JsonReadNumberAsDouble(j: Json; key: String): Double;
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skreturn: Double;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skreturn := __sklib__json_read_number_as_double__json__string(__skparam__j, __skparam__key);
  result := __skadapter__to_double(__skreturn);
end;
function JsonReadNumberAsInt(j: Json; key: String): Integer;
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skreturn := __sklib__json_read_number_as_int__json__string(__skparam__j, __skparam__key);
  result := __skadapter__to_int(__skreturn);
end;
function JsonReadObject(j: Json; key: String): Json;
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skreturn := __sklib__json_read_object__json__string(__skparam__j, __skparam__key);
  result := __skadapter__to_json(__skreturn);
end;
function JsonReadString(j: Json; key: String): String;
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skreturn := __sklib__json_read_string__json__string(__skparam__j, __skparam__key);
  result := __skadapter__to_string(__skreturn);
end;
procedure JsonSetArray(j: Json; key: String; value: ArrayOfString);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__value: __sklib_vector_string;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__value := __skadapter__to_sklib_vector_string(value);
  __sklib__json_set_array__json__string__vector_string(__skparam__j, __skparam__key, __skparam__value);
end;
procedure JsonSetArray(j: Json; key: String; value: ArrayOfDouble);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__value: __sklib_vector_double;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__value := __skadapter__to_sklib_vector_double(value);
  __sklib__json_set_array__json__string__vector_double(__skparam__j, __skparam__key, __skparam__value);
end;
procedure JsonSetArray(j: Json; key: String; value: ArrayOfBoolean);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__value: __sklib_vector_bool;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__value := __skadapter__to_sklib_vector_bool(value);
  __sklib__json_set_array__json__string__vector_bool(__skparam__j, __skparam__key, __skparam__value);
end;
procedure JsonSetArray(j: Json; key: String; value: ArrayOfJson);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__value: __sklib_vector_json;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__value := __skadapter__to_sklib_vector_json(value);
  __sklib__json_set_array__json__string__vector_json(__skparam__j, __skparam__key, __skparam__value);
end;
procedure JsonSetBool(j: Json; key: String; value: Boolean);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__value: LongInt;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__value := __skadapter__to_sklib_bool(value);
  __sklib__json_set_bool__json__string__bool(__skparam__j, __skparam__key, __skparam__value);
end;
procedure JsonSetNumber(j: Json; key: String; value: Integer);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__value: Integer;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__value := __skadapter__to_sklib_int(value);
  __sklib__json_set_number__json__string__int(__skparam__j, __skparam__key, __skparam__value);
end;
procedure JsonSetNumber(j: Json; key: String; value: Double);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__value: Double;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__value := __skadapter__to_sklib_double(value);
  __sklib__json_set_number__json__string__double(__skparam__j, __skparam__key, __skparam__value);
end;
procedure JsonSetNumber(j: Json; key: String; value: Single);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__value: Single;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__value := __skadapter__to_sklib_float(value);
  __sklib__json_set_number__json__string__float(__skparam__j, __skparam__key, __skparam__value);
end;
procedure JsonSetObject(j: Json; key: String; obj: Json);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__obj: __sklib_ptr;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__obj := __skadapter__to_sklib_json(obj);
  __sklib__json_set_object__json__string__json(__skparam__j, __skparam__key, __skparam__obj);
end;
procedure JsonSetString(j: Json; key: String; value: String);
var
  __skparam__j: __sklib_ptr;
  __skparam__key: __sklib_string;
  __skparam__value: __sklib_string;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__key := __skadapter__to_sklib_string(key);
  __skparam__value := __skadapter__to_sklib_string(value);
  __sklib__json_set_string__json__string__string(__skparam__j, __skparam__key, __skparam__value);
end;
function JsonToColor(j: Json): Color;
var
  __skparam__j: __sklib_ptr;
  __skreturn: __sklib_color;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skreturn := __sklib__json_to_color__json(__skparam__j);
  result := __skadapter__to_color(__skreturn);
end;
procedure JsonToFile(j: Json; const filename: String);
var
  __skparam__j: __sklib_ptr;
  __skparam__filename: __sklib_string;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __sklib__json_to_file__json__string_ref(__skparam__j, __skparam__filename);
end;
function JsonToString(j: Json): String;
var
  __skparam__j: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__j := __skadapter__to_sklib_json(j);
  __skreturn := __sklib__json_to_string__json(__skparam__j);
  result := __skadapter__to_string(__skreturn);
end;
function AnyKeyPressed(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__any_key_pressed();
  result := __skadapter__to_bool(__skreturn);
end;
procedure DeregisterCallbackOnKeyDown(callback: KeyCallback);
var
  __skparam__callback: KeyCallback;
begin
  __skparam__callback := __skadapter__to_sklib_key_callback(callback);
  __sklib__deregister_callback_on_key_down__key_callback_ptr(__skparam__callback);
end;
procedure DeregisterCallbackOnKeyTyped(callback: KeyCallback);
var
  __skparam__callback: KeyCallback;
begin
  __skparam__callback := __skadapter__to_sklib_key_callback(callback);
  __sklib__deregister_callback_on_key_typed__key_callback_ptr(__skparam__callback);
end;
procedure DeregisterCallbackOnKeyUp(callback: KeyCallback);
var
  __skparam__callback: KeyCallback;
begin
  __skparam__callback := __skadapter__to_sklib_key_callback(callback);
  __sklib__deregister_callback_on_key_up__key_callback_ptr(__skparam__callback);
end;
function KeyDown(key: KeyCode): Boolean;
var
  __skparam__key: LongInt;
  __skreturn: LongInt;
begin
  __skparam__key := __skadapter__to_sklib_key_code(key);
  __skreturn := __sklib__key_down__key_code(__skparam__key);
  result := __skadapter__to_bool(__skreturn);
end;
function KeyName(key: KeyCode): String;
var
  __skparam__key: LongInt;
  __skreturn: __sklib_string;
begin
  __skparam__key := __skadapter__to_sklib_key_code(key);
  __skreturn := __sklib__key_name__key_code(__skparam__key);
  result := __skadapter__to_string(__skreturn);
end;
function KeyReleased(key: KeyCode): Boolean;
var
  __skparam__key: LongInt;
  __skreturn: LongInt;
begin
  __skparam__key := __skadapter__to_sklib_key_code(key);
  __skreturn := __sklib__key_released__key_code(__skparam__key);
  result := __skadapter__to_bool(__skreturn);
end;
function KeyTyped(key: KeyCode): Boolean;
var
  __skparam__key: LongInt;
  __skreturn: LongInt;
begin
  __skparam__key := __skadapter__to_sklib_key_code(key);
  __skreturn := __sklib__key_typed__key_code(__skparam__key);
  result := __skadapter__to_bool(__skreturn);
end;
function KeyUp(key: KeyCode): Boolean;
var
  __skparam__key: LongInt;
  __skreturn: LongInt;
begin
  __skparam__key := __skadapter__to_sklib_key_code(key);
  __skreturn := __sklib__key_up__key_code(__skparam__key);
  result := __skadapter__to_bool(__skreturn);
end;
procedure RegisterCallbackOnKeyDown(callback: KeyCallback);
var
  __skparam__callback: KeyCallback;
begin
  __skparam__callback := __skadapter__to_sklib_key_callback(callback);
  __sklib__register_callback_on_key_down__key_callback_ptr(__skparam__callback);
end;
procedure RegisterCallbackOnKeyTyped(callback: KeyCallback);
var
  __skparam__callback: KeyCallback;
begin
  __skparam__callback := __skadapter__to_sklib_key_callback(callback);
  __sklib__register_callback_on_key_typed__key_callback_ptr(__skparam__callback);
end;
procedure RegisterCallbackOnKeyUp(callback: KeyCallback);
var
  __skparam__callback: KeyCallback;
begin
  __skparam__callback := __skadapter__to_sklib_key_callback(callback);
  __sklib__register_callback_on_key_up__key_callback_ptr(__skparam__callback);
end;
procedure DrawLine(clr: Color; const l: Line);
var
  __skparam__clr: __sklib_color;
  __skparam__l: __sklib_line;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__l := __skadapter__to_sklib_line(l);
  __sklib__draw_line__color__line_ref(__skparam__clr, __skparam__l);
end;
procedure DrawLine(clr: Color; const l: Line; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__l: __sklib_line;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__l := __skadapter__to_sklib_line(l);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_line__color__line_ref__drawing_options(__skparam__clr, __skparam__l, __skparam__opts);
end;
procedure DrawLine(clr: Color; const fromPt: Point2D; const toPt: Point2D);
var
  __skparam__clr: __sklib_color;
  __skparam__from_pt: __sklib_point_2d;
  __skparam__to_pt: __sklib_point_2d;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__from_pt := __skadapter__to_sklib_point_2d(fromPt);
  __skparam__to_pt := __skadapter__to_sklib_point_2d(toPt);
  __sklib__draw_line__color__point_2d_ref__point_2d_ref(__skparam__clr, __skparam__from_pt, __skparam__to_pt);
end;
procedure DrawLine(clr: Color; const fromPt: Point2D; const toPt: Point2D; const opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__from_pt: __sklib_point_2d;
  __skparam__to_pt: __sklib_point_2d;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__from_pt := __skadapter__to_sklib_point_2d(fromPt);
  __skparam__to_pt := __skadapter__to_sklib_point_2d(toPt);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_line__color__point_2d_ref__point_2d_ref__drawing_options_ref(__skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts);
end;
procedure DrawLine(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double);
var
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __sklib__draw_line__color__double__double__double__double(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
end;
procedure DrawLine(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; const opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_line__color__double__double__double__double__drawing_options_ref(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts);
end;
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; const l: Line);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__l: __sklib_line;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__l := __skadapter__to_sklib_line(l);
  __sklib__draw_line_on_bitmap__bitmap__color__line_ref(__skparam__destination, __skparam__clr, __skparam__l);
end;
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; const l: Line; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__l: __sklib_line;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__l := __skadapter__to_sklib_line(l);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_line_on_bitmap__bitmap__color__line_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__l, __skparam__opts);
end;
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; const fromPt: Point2D; const toPt: Point2D);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__from_pt: __sklib_point_2d;
  __skparam__to_pt: __sklib_point_2d;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__from_pt := __skadapter__to_sklib_point_2d(fromPt);
  __skparam__to_pt := __skadapter__to_sklib_point_2d(toPt);
  __sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt);
end;
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; const fromPt: Point2D; const toPt: Point2D; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__from_pt: __sklib_point_2d;
  __skparam__to_pt: __sklib_point_2d;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__from_pt := __skadapter__to_sklib_point_2d(fromPt);
  __skparam__to_pt := __skadapter__to_sklib_point_2d(toPt);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts);
end;
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
end;
procedure DrawLineOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts);
end;
procedure DrawLineOnWindow(destination: Window; clr: Color; const l: Line);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__l: __sklib_line;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__l := __skadapter__to_sklib_line(l);
  __sklib__draw_line_on_window__window__color__line_ref(__skparam__destination, __skparam__clr, __skparam__l);
end;
procedure DrawLineOnWindow(destination: Window; clr: Color; const l: Line; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__l: __sklib_line;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__l := __skadapter__to_sklib_line(l);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_line_on_window__window__color__line_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__l, __skparam__opts);
end;
procedure DrawLineOnWindow(destination: Window; clr: Color; const fromPt: Point2D; const toPt: Point2D);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__from_pt: __sklib_point_2d;
  __skparam__to_pt: __sklib_point_2d;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__from_pt := __skadapter__to_sklib_point_2d(fromPt);
  __skparam__to_pt := __skadapter__to_sklib_point_2d(toPt);
  __sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt);
end;
procedure DrawLineOnWindow(destination: Window; clr: Color; const fromPt: Point2D; const toPt: Point2D; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__from_pt: __sklib_point_2d;
  __skparam__to_pt: __sklib_point_2d;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__from_pt := __skadapter__to_sklib_point_2d(fromPt);
  __skparam__to_pt := __skadapter__to_sklib_point_2d(toPt);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts);
end;
procedure DrawLineOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __sklib__draw_line_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
end;
procedure DrawLineOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_line_on_window__window__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts);
end;
function ClosestPointOnLine(fromPt: Point2D; const l: Line): Point2D;
var
  __skparam__from_pt: __sklib_point_2d;
  __skparam__l: __sklib_line;
  __skreturn: __sklib_point_2d;
begin
  __skparam__from_pt := __skadapter__to_sklib_point_2d(fromPt);
  __skparam__l := __skadapter__to_sklib_line(l);
  __skreturn := __sklib__closest_point_on_line__point_2d__line_ref(__skparam__from_pt, __skparam__l);
  result := __skadapter__to_point_2d(__skreturn);
end;
function ClosestPointOnLines(fromPt: Point2D; const lines: ArrayOfLine; var lineIdx: Integer): Point2D;
var
  __skparam__from_pt: __sklib_point_2d;
  __skparam__lines: __sklib_vector_line;
  __skparam__line_idx: Integer;
  __skreturn: __sklib_point_2d;
begin
  __skparam__from_pt := __skadapter__to_sklib_point_2d(fromPt);
  __skparam__lines := __skadapter__to_sklib_vector_line(lines);
  __skparam__line_idx := __skadapter__to_sklib_int(lineIdx);
  __skreturn := __sklib__closest_point_on_lines__point_2d__vector_line_ref__int_ref(__skparam__from_pt, __skparam__lines, __skparam__line_idx);
  lineIdx := __skadapter__to_int(__skparam__line_idx);
  result := __skadapter__to_point_2d(__skreturn);
end;
function LineFrom(const start: Point2D; const endPt: Point2D): Line;
var
  __skparam__start: __sklib_point_2d;
  __skparam__end_pt: __sklib_point_2d;
  __skreturn: __sklib_line;
begin
  __skparam__start := __skadapter__to_sklib_point_2d(start);
  __skparam__end_pt := __skadapter__to_sklib_point_2d(endPt);
  __skreturn := __sklib__line_from__point_2d_ref__point_2d_ref(__skparam__start, __skparam__end_pt);
  result := __skadapter__to_line(__skreturn);
end;
function LineFrom(const start: Point2D; const offset: Vector2D): Line;
var
  __skparam__start: __sklib_point_2d;
  __skparam__offset: __sklib_vector_2d;
  __skreturn: __sklib_line;
begin
  __skparam__start := __skadapter__to_sklib_point_2d(start);
  __skparam__offset := __skadapter__to_sklib_vector_2d(offset);
  __skreturn := __sklib__line_from__point_2d_ref__vector_2d_ref(__skparam__start, __skparam__offset);
  result := __skadapter__to_line(__skreturn);
end;
function LineFrom(const v: Vector2D): Line;
var
  __skparam__v: __sklib_vector_2d;
  __skreturn: __sklib_line;
begin
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skreturn := __sklib__line_from__vector_2d_ref(__skparam__v);
  result := __skadapter__to_line(__skreturn);
end;
function LineFrom(x1: Double; y1: Double; x2: Double; y2: Double): Line;
var
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skreturn: __sklib_line;
begin
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skreturn := __sklib__line_from__double__double__double__double(__skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
  result := __skadapter__to_line(__skreturn);
end;
function LineIntersectionPoint(const line1: Line; const line2: Line; var pt: Point2D): Boolean;
var
  __skparam__line1: __sklib_line;
  __skparam__line2: __sklib_line;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__line1 := __skadapter__to_sklib_line(line1);
  __skparam__line2 := __skadapter__to_sklib_line(line2);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__line_intersection_point__line_ref__line_ref__point_2d_ref(__skparam__line1, __skparam__line2, __skparam__pt);
  pt := __skadapter__to_point_2d(__skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function LineIntersectsCircle(const l: Line; const c: Circle): Boolean;
var
  __skparam__l: __sklib_line;
  __skparam__c: __sklib_circle;
  __skreturn: LongInt;
begin
  __skparam__l := __skadapter__to_sklib_line(l);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skreturn := __sklib__line_intersects_circle__line_ref__circle_ref(__skparam__l, __skparam__c);
  result := __skadapter__to_bool(__skreturn);
end;
function LineIntersectsLines(const l: Line; const lines: ArrayOfLine): Boolean;
var
  __skparam__l: __sklib_line;
  __skparam__lines: __sklib_vector_line;
  __skreturn: LongInt;
begin
  __skparam__l := __skadapter__to_sklib_line(l);
  __skparam__lines := __skadapter__to_sklib_vector_line(lines);
  __skreturn := __sklib__line_intersects_lines__line_ref__vector_line_ref(__skparam__l, __skparam__lines);
  result := __skadapter__to_bool(__skreturn);
end;
function LineIntersectsRect(const l: Line; const rect: Rectangle): Boolean;
var
  __skparam__l: __sklib_line;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__l := __skadapter__to_sklib_line(l);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__line_intersects_rect__line_ref__rectangle_ref(__skparam__l, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function LineLength(const l: Line): Single;
var
  __skparam__l: __sklib_line;
  __skreturn: Single;
begin
  __skparam__l := __skadapter__to_sklib_line(l);
  __skreturn := __sklib__line_length__line_ref(__skparam__l);
  result := __skadapter__to_float(__skreturn);
end;
function LineLengthSquared(const l: Line): Single;
var
  __skparam__l: __sklib_line;
  __skreturn: Single;
begin
  __skparam__l := __skadapter__to_sklib_line(l);
  __skreturn := __sklib__line_length_squared__line_ref(__skparam__l);
  result := __skadapter__to_float(__skreturn);
end;
function LineMidPoint(const l: Line): Point2D;
var
  __skparam__l: __sklib_line;
  __skreturn: __sklib_point_2d;
begin
  __skparam__l := __skadapter__to_sklib_line(l);
  __skreturn := __sklib__line_mid_point__line_ref(__skparam__l);
  result := __skadapter__to_point_2d(__skreturn);
end;
function LineNormal(const l: Line): Vector2D;
var
  __skparam__l: __sklib_line;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__l := __skadapter__to_sklib_line(l);
  __skreturn := __sklib__line_normal__line_ref(__skparam__l);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function LineToString(const ln: Line): String;
var
  __skparam__ln: __sklib_line;
  __skreturn: __sklib_string;
begin
  __skparam__ln := __skadapter__to_sklib_line(ln);
  __skreturn := __sklib__line_to_string__line_ref(__skparam__ln);
  result := __skadapter__to_string(__skreturn);
end;
function LinesFrom(const rect: Rectangle): ArrayOfLine;
var
  __skparam__rect: __sklib_rectangle;
  __skreturn: __sklib_vector_line;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__lines_from__rectangle_ref(__skparam__rect);
  result := __skadapter__to_vector_line(__skreturn);
end;
function LinesFrom(const t: Triangle): ArrayOfLine;
var
  __skparam__t: __sklib_triangle;
  __skreturn: __sklib_vector_line;
begin
  __skparam__t := __skadapter__to_sklib_triangle(t);
  __skreturn := __sklib__lines_from__triangle_ref(__skparam__t);
  result := __skadapter__to_vector_line(__skreturn);
end;
function LinesIntersect(const l1: Line; const l2: Line): Boolean;
var
  __skparam__l1: __sklib_line;
  __skparam__l2: __sklib_line;
  __skreturn: LongInt;
begin
  __skparam__l1 := __skadapter__to_sklib_line(l1);
  __skparam__l2 := __skadapter__to_sklib_line(l2);
  __skreturn := __sklib__lines_intersect__line_ref__line_ref(__skparam__l1, __skparam__l2);
  result := __skadapter__to_bool(__skreturn);
end;
procedure CloseLogProcess();
begin
  __sklib__close_log_process();
end;
procedure InitCustomLogger(mode: LogMode);
var
  __skparam__mode: LongInt;
begin
  __skparam__mode := __skadapter__to_sklib_log_mode(mode);
  __sklib__init_custom_logger__log_mode(__skparam__mode);
end;
procedure InitCustomLogger(appName: String; overridePrevLog: Boolean; mode: LogMode);
var
  __skparam__app_name: __sklib_string;
  __skparam__override_prev_log: LongInt;
  __skparam__mode: LongInt;
begin
  __skparam__app_name := __skadapter__to_sklib_string(appName);
  __skparam__override_prev_log := __skadapter__to_sklib_bool(overridePrevLog);
  __skparam__mode := __skadapter__to_sklib_log_mode(mode);
  __sklib__init_custom_logger__string__bool__log_mode(__skparam__app_name, __skparam__override_prev_log, __skparam__mode);
end;
procedure Log(level: LogLevel; message: String);
var
  __skparam__level: LongInt;
  __skparam__message: __sklib_string;
begin
  __skparam__level := __skadapter__to_sklib_log_level(level);
  __skparam__message := __skadapter__to_sklib_string(message);
  __sklib__log__log_level__string(__skparam__level, __skparam__message);
end;
procedure ApplyMatrix(const matrix: Matrix2D; var q: Quad);
var
  __skparam__matrix: __sklib_matrix_2d;
  __skparam__q: __sklib_quad;
begin
  __skparam__matrix := __skadapter__to_sklib_matrix_2d(matrix);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __sklib__apply_matrix__matrix_2d_ref__quad_ref(__skparam__matrix, __skparam__q);
  q := __skadapter__to_quad(__skparam__q);
end;
procedure ApplyMatrix(const m: Matrix2D; var tri: Triangle);
var
  __skparam__m: __sklib_matrix_2d;
  __skparam__tri: __sklib_triangle;
begin
  __skparam__m := __skadapter__to_sklib_matrix_2d(m);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __sklib__apply_matrix__matrix_2d_ref__triangle_ref(__skparam__m, __skparam__tri);
  tri := __skadapter__to_triangle(__skparam__tri);
end;
function IdentityMatrix(): Matrix2D;
var
  __skreturn: __sklib_matrix_2d;
begin
  __skreturn := __sklib__identity_matrix();
  result := __skadapter__to_matrix_2d(__skreturn);
end;
function MatrixInverse(const m: Matrix2D): Matrix2D;
var
  __skparam__m: __sklib_matrix_2d;
  __skreturn: __sklib_matrix_2d;
begin
  __skparam__m := __skadapter__to_sklib_matrix_2d(m);
  __skreturn := __sklib__matrix_inverse__matrix_2d_ref(__skparam__m);
  result := __skadapter__to_matrix_2d(__skreturn);
end;
function MatrixMultiply(const m: Matrix2D; const pt: Point2D): Point2D;
var
  __skparam__m: __sklib_matrix_2d;
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_point_2d;
begin
  __skparam__m := __skadapter__to_sklib_matrix_2d(m);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__matrix_multiply__matrix_2d_ref__point_2d_ref(__skparam__m, __skparam__pt);
  result := __skadapter__to_point_2d(__skreturn);
end;
function MatrixMultiply(const m1: Matrix2D; const m2: Matrix2D): Matrix2D;
var
  __skparam__m1: __sklib_matrix_2d;
  __skparam__m2: __sklib_matrix_2d;
  __skreturn: __sklib_matrix_2d;
begin
  __skparam__m1 := __skadapter__to_sklib_matrix_2d(m1);
  __skparam__m2 := __skadapter__to_sklib_matrix_2d(m2);
  __skreturn := __sklib__matrix_multiply__matrix_2d_ref__matrix_2d_ref(__skparam__m1, __skparam__m2);
  result := __skadapter__to_matrix_2d(__skreturn);
end;
function MatrixMultiply(const m: Matrix2D; const v: Vector2D): Vector2D;
var
  __skparam__m: __sklib_matrix_2d;
  __skparam__v: __sklib_vector_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__m := __skadapter__to_sklib_matrix_2d(m);
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skreturn := __sklib__matrix_multiply__matrix_2d_ref__vector_2d_ref(__skparam__m, __skparam__v);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function MatrixToString(const matrix: Matrix2D): String;
var
  __skparam__matrix: __sklib_matrix_2d;
  __skreturn: __sklib_string;
begin
  __skparam__matrix := __skadapter__to_sklib_matrix_2d(matrix);
  __skreturn := __sklib__matrix_to_string__matrix_2d_ref(__skparam__matrix);
  result := __skadapter__to_string(__skreturn);
end;
function RotationMatrix(deg: Double): Matrix2D;
var
  __skparam__deg: Double;
  __skreturn: __sklib_matrix_2d;
begin
  __skparam__deg := __skadapter__to_sklib_double(deg);
  __skreturn := __sklib__rotation_matrix__double(__skparam__deg);
  result := __skadapter__to_matrix_2d(__skreturn);
end;
function ScaleMatrix(const scale: Point2D): Matrix2D;
var
  __skparam__scale: __sklib_point_2d;
  __skreturn: __sklib_matrix_2d;
begin
  __skparam__scale := __skadapter__to_sklib_point_2d(scale);
  __skreturn := __sklib__scale_matrix__point_2d_ref(__skparam__scale);
  result := __skadapter__to_matrix_2d(__skreturn);
end;
function ScaleMatrix(const scale: Vector2D): Matrix2D;
var
  __skparam__scale: __sklib_vector_2d;
  __skreturn: __sklib_matrix_2d;
begin
  __skparam__scale := __skadapter__to_sklib_vector_2d(scale);
  __skreturn := __sklib__scale_matrix__vector_2d_ref(__skparam__scale);
  result := __skadapter__to_matrix_2d(__skreturn);
end;
function ScaleMatrix(scale: Double): Matrix2D;
var
  __skparam__scale: Double;
  __skreturn: __sklib_matrix_2d;
begin
  __skparam__scale := __skadapter__to_sklib_double(scale);
  __skreturn := __sklib__scale_matrix__double(__skparam__scale);
  result := __skadapter__to_matrix_2d(__skreturn);
end;
function ScaleRotateTranslateMatrix(const scale: Point2D; deg: Double; const translate: Point2D): Matrix2D;
var
  __skparam__scale: __sklib_point_2d;
  __skparam__deg: Double;
  __skparam__translate: __sklib_point_2d;
  __skreturn: __sklib_matrix_2d;
begin
  __skparam__scale := __skadapter__to_sklib_point_2d(scale);
  __skparam__deg := __skadapter__to_sklib_double(deg);
  __skparam__translate := __skadapter__to_sklib_point_2d(translate);
  __skreturn := __sklib__scale_rotate_translate_matrix__point_2d_ref__double__point_2d_ref(__skparam__scale, __skparam__deg, __skparam__translate);
  result := __skadapter__to_matrix_2d(__skreturn);
end;
function TranslationMatrix(const pt: Point2D): Matrix2D;
var
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_matrix_2d;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__translation_matrix__point_2d_ref(__skparam__pt);
  result := __skadapter__to_matrix_2d(__skreturn);
end;
function TranslationMatrix(const pt: Vector2D): Matrix2D;
var
  __skparam__pt: __sklib_vector_2d;
  __skreturn: __sklib_matrix_2d;
begin
  __skparam__pt := __skadapter__to_sklib_vector_2d(pt);
  __skreturn := __sklib__translation_matrix__vector_2d_ref(__skparam__pt);
  result := __skadapter__to_matrix_2d(__skreturn);
end;
function TranslationMatrix(dx: Double; dy: Double): Matrix2D;
var
  __skparam__dx: Double;
  __skparam__dy: Double;
  __skreturn: __sklib_matrix_2d;
begin
  __skparam__dx := __skadapter__to_sklib_double(dx);
  __skparam__dy := __skadapter__to_sklib_double(dy);
  __skreturn := __sklib__translation_matrix__double__double(__skparam__dx, __skparam__dy);
  result := __skadapter__to_matrix_2d(__skreturn);
end;
procedure HideMouse();
begin
  __sklib__hide_mouse();
end;
function MouseClicked(button: MouseButton): Boolean;
var
  __skparam__button: LongInt;
  __skreturn: LongInt;
begin
  __skparam__button := __skadapter__to_sklib_mouse_button(button);
  __skreturn := __sklib__mouse_clicked__mouse_button(__skparam__button);
  result := __skadapter__to_bool(__skreturn);
end;
function MouseDown(button: MouseButton): Boolean;
var
  __skparam__button: LongInt;
  __skreturn: LongInt;
begin
  __skparam__button := __skadapter__to_sklib_mouse_button(button);
  __skreturn := __sklib__mouse_down__mouse_button(__skparam__button);
  result := __skadapter__to_bool(__skreturn);
end;
function MouseMovement(): Vector2D;
var
  __skreturn: __sklib_vector_2d;
begin
  __skreturn := __sklib__mouse_movement();
  result := __skadapter__to_vector_2d(__skreturn);
end;
function MousePosition(): Point2D;
var
  __skreturn: __sklib_point_2d;
begin
  __skreturn := __sklib__mouse_position();
  result := __skadapter__to_point_2d(__skreturn);
end;
function MousePositionVector(): Vector2D;
var
  __skreturn: __sklib_vector_2d;
begin
  __skreturn := __sklib__mouse_position_vector();
  result := __skadapter__to_vector_2d(__skreturn);
end;
function MouseShown(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__mouse_shown();
  result := __skadapter__to_bool(__skreturn);
end;
function MouseUp(button: MouseButton): Boolean;
var
  __skparam__button: LongInt;
  __skreturn: LongInt;
begin
  __skparam__button := __skadapter__to_sklib_mouse_button(button);
  __skreturn := __sklib__mouse_up__mouse_button(__skparam__button);
  result := __skadapter__to_bool(__skreturn);
end;
function MouseWheelScroll(): Vector2D;
var
  __skreturn: __sklib_vector_2d;
begin
  __skreturn := __sklib__mouse_wheel_scroll();
  result := __skadapter__to_vector_2d(__skreturn);
end;
function MouseX(): Single;
var
  __skreturn: Single;
begin
  __skreturn := __sklib__mouse_x();
  result := __skadapter__to_float(__skreturn);
end;
function MouseY(): Single;
var
  __skreturn: Single;
begin
  __skreturn := __sklib__mouse_y();
  result := __skadapter__to_float(__skreturn);
end;
procedure MoveMouse(x: Double; y: Double);
var
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__move_mouse__double__double(__skparam__x, __skparam__y);
end;
procedure MoveMouse(point: Point2D);
var
  __skparam__point: __sklib_point_2d;
begin
  __skparam__point := __skadapter__to_sklib_point_2d(point);
  __sklib__move_mouse__point_2d(__skparam__point);
end;
procedure ShowMouse();
begin
  __sklib__show_mouse();
end;
procedure ShowMouse(show: Boolean);
var
  __skparam__show: LongInt;
begin
  __skparam__show := __skadapter__to_sklib_bool(show);
  __sklib__show_mouse__bool(__skparam__show);
end;
procedure FadeMusicIn(const name: String; ms: Integer);
var
  __skparam__name: __sklib_string;
  __skparam__ms: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__ms := __skadapter__to_sklib_int(ms);
  __sklib__fade_music_in__string_ref__int(__skparam__name, __skparam__ms);
end;
procedure FadeMusicIn(const name: String; times: Integer; ms: Integer);
var
  __skparam__name: __sklib_string;
  __skparam__times: Integer;
  __skparam__ms: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__times := __skadapter__to_sklib_int(times);
  __skparam__ms := __skadapter__to_sklib_int(ms);
  __sklib__fade_music_in__string_ref__int__int(__skparam__name, __skparam__times, __skparam__ms);
end;
procedure FadeMusicIn(data: Music; ms: Integer);
var
  __skparam__data: __sklib_ptr;
  __skparam__ms: Integer;
begin
  __skparam__data := __skadapter__to_sklib_music(data);
  __skparam__ms := __skadapter__to_sklib_int(ms);
  __sklib__fade_music_in__music__int(__skparam__data, __skparam__ms);
end;
procedure FadeMusicIn(data: Music; times: Integer; ms: Integer);
var
  __skparam__data: __sklib_ptr;
  __skparam__times: Integer;
  __skparam__ms: Integer;
begin
  __skparam__data := __skadapter__to_sklib_music(data);
  __skparam__times := __skadapter__to_sklib_int(times);
  __skparam__ms := __skadapter__to_sklib_int(ms);
  __sklib__fade_music_in__music__int__int(__skparam__data, __skparam__times, __skparam__ms);
end;
procedure FadeMusicOut(ms: Integer);
var
  __skparam__ms: Integer;
begin
  __skparam__ms := __skadapter__to_sklib_int(ms);
  __sklib__fade_music_out__int(__skparam__ms);
end;
procedure FreeAllMusic();
begin
  __sklib__free_all_music();
end;
procedure FreeMusic(effect: Music);
var
  __skparam__effect: __sklib_ptr;
begin
  __skparam__effect := __skadapter__to_sklib_music(effect);
  __sklib__free_music__music(__skparam__effect);
end;
function HasMusic(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_music__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function LoadMusic(const name: String; const filename: String): Music;
var
  __skparam__name: __sklib_string;
  __skparam__filename: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __skreturn := __sklib__load_music__string_ref__string_ref(__skparam__name, __skparam__filename);
  result := __skadapter__to_music(__skreturn);
end;
function MusicFilename(data: Music): String;
var
  __skparam__data: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__data := __skadapter__to_sklib_music(data);
  __skreturn := __sklib__music_filename__music(__skparam__data);
  result := __skadapter__to_string(__skreturn);
end;
function MusicName(data: Music): String;
var
  __skparam__data: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__data := __skadapter__to_sklib_music(data);
  __skreturn := __sklib__music_name__music(__skparam__data);
  result := __skadapter__to_string(__skreturn);
end;
function MusicNamed(const name: String): Music;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__music_named__string_ref(__skparam__name);
  result := __skadapter__to_music(__skreturn);
end;
function MusicPlaying(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__music_playing();
  result := __skadapter__to_bool(__skreturn);
end;
function MusicValid(m: Music): Boolean;
var
  __skparam__m: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__m := __skadapter__to_sklib_music(m);
  __skreturn := __sklib__music_valid__music(__skparam__m);
  result := __skadapter__to_bool(__skreturn);
end;
function MusicVolume(): Double;
var
  __skreturn: Double;
begin
  __skreturn := __sklib__music_volume();
  result := __skadapter__to_double(__skreturn);
end;
procedure PauseMusic();
begin
  __sklib__pause_music();
end;
procedure PlayMusic(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__play_music__string_ref(__skparam__name);
end;
procedure PlayMusic(const name: String; times: Integer);
var
  __skparam__name: __sklib_string;
  __skparam__times: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__times := __skadapter__to_sklib_int(times);
  __sklib__play_music__string_ref__int(__skparam__name, __skparam__times);
end;
procedure PlayMusic(data: Music);
var
  __skparam__data: __sklib_ptr;
begin
  __skparam__data := __skadapter__to_sklib_music(data);
  __sklib__play_music__music(__skparam__data);
end;
procedure PlayMusic(data: Music; times: Integer);
var
  __skparam__data: __sklib_ptr;
  __skparam__times: Integer;
begin
  __skparam__data := __skadapter__to_sklib_music(data);
  __skparam__times := __skadapter__to_sklib_int(times);
  __sklib__play_music__music__int(__skparam__data, __skparam__times);
end;
procedure PlayMusic(data: Music; times: Integer; volume: Double);
var
  __skparam__data: __sklib_ptr;
  __skparam__times: Integer;
  __skparam__volume: Double;
begin
  __skparam__data := __skadapter__to_sklib_music(data);
  __skparam__times := __skadapter__to_sklib_int(times);
  __skparam__volume := __skadapter__to_sklib_double(volume);
  __sklib__play_music__music__int__double(__skparam__data, __skparam__times, __skparam__volume);
end;
procedure ResumeMusic();
begin
  __sklib__resume_music();
end;
procedure SetMusicVolume(volume: Double);
var
  __skparam__volume: Double;
begin
  __skparam__volume := __skadapter__to_sklib_double(volume);
  __sklib__set_music_volume__double(__skparam__volume);
end;
procedure StopMusic();
begin
  __sklib__stop_music();
end;
function AcceptAllNewConnections(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__accept_all_new_connections();
  result := __skadapter__to_bool(__skreturn);
end;
function AcceptNewConnection(server: ServerSocket): Boolean;
var
  __skparam__server: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__server := __skadapter__to_sklib_server_socket(server);
  __skreturn := __sklib__accept_new_connection__server_socket(__skparam__server);
  result := __skadapter__to_bool(__skreturn);
end;
procedure BroadcastMessage(const aMsg: String; svr: ServerSocket);
var
  __skparam__a_msg: __sklib_string;
  __skparam__svr: __sklib_ptr;
begin
  __skparam__a_msg := __skadapter__to_sklib_string(aMsg);
  __skparam__svr := __skadapter__to_sklib_server_socket(svr);
  __sklib__broadcast_message__string_ref__server_socket(__skparam__a_msg, __skparam__svr);
end;
procedure BroadcastMessage(const aMsg: String);
var
  __skparam__a_msg: __sklib_string;
begin
  __skparam__a_msg := __skadapter__to_sklib_string(aMsg);
  __sklib__broadcast_message__string_ref(__skparam__a_msg);
end;
procedure BroadcastMessage(const aMsg: String; const name: String);
var
  __skparam__a_msg: __sklib_string;
  __skparam__name: __sklib_string;
begin
  __skparam__a_msg := __skadapter__to_sklib_string(aMsg);
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__broadcast_message__string_ref__string_ref(__skparam__a_msg, __skparam__name);
end;
procedure CheckNetworkActivity();
begin
  __sklib__check_network_activity();
end;
procedure ClearMessages(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__clear_messages__string_ref(__skparam__name);
end;
procedure ClearMessages(aConnection: Connection);
var
  __skparam__a_connection: __sklib_ptr;
begin
  __skparam__a_connection := __skadapter__to_sklib_connection(aConnection);
  __sklib__clear_messages__connection(__skparam__a_connection);
end;
procedure ClearMessages(svr: ServerSocket);
var
  __skparam__svr: __sklib_ptr;
begin
  __skparam__svr := __skadapter__to_sklib_server_socket(svr);
  __sklib__clear_messages__server_socket(__skparam__svr);
end;
procedure CloseAllConnections();
begin
  __sklib__close_all_connections();
end;
procedure CloseAllServers();
begin
  __sklib__close_all_servers();
end;
function CloseConnection(aConnection: Connection): Boolean;
var
  __skparam__a_connection: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__a_connection := __skadapter__to_sklib_connection(aConnection);
  __skreturn := __sklib__close_connection__connection(__skparam__a_connection);
  result := __skadapter__to_bool(__skreturn);
end;
function CloseConnection(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__close_connection__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
procedure CloseMessage(msg: Message);
var
  __skparam__msg: __sklib_ptr;
begin
  __skparam__msg := __skadapter__to_sklib_message(msg);
  __sklib__close_message__message(__skparam__msg);
end;
function CloseServer(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__close_server__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function CloseServer(svr: ServerSocket): Boolean;
var
  __skparam__svr: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__svr := __skadapter__to_sklib_server_socket(svr);
  __skreturn := __sklib__close_server__server_socket(__skparam__svr);
  result := __skadapter__to_bool(__skreturn);
end;
function ConnectionCount(const name: String): Cardinal;
var
  __skparam__name: __sklib_string;
  __skreturn: Cardinal;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__connection_count__string_ref(__skparam__name);
  result := __skadapter__to_unsigned_int(__skreturn);
end;
function ConnectionCount(server: ServerSocket): Cardinal;
var
  __skparam__server: __sklib_ptr;
  __skreturn: Cardinal;
begin
  __skparam__server := __skadapter__to_sklib_server_socket(server);
  __skreturn := __sklib__connection_count__server_socket(__skparam__server);
  result := __skadapter__to_unsigned_int(__skreturn);
end;
function ConnectionIP(aConnection: Connection): Cardinal;
var
  __skparam__a_connection: __sklib_ptr;
  __skreturn: Cardinal;
begin
  __skparam__a_connection := __skadapter__to_sklib_connection(aConnection);
  __skreturn := __sklib__connection_ip__connection(__skparam__a_connection);
  result := __skadapter__to_unsigned_int(__skreturn);
end;
function ConnectionIP(const name: String): Cardinal;
var
  __skparam__name: __sklib_string;
  __skreturn: Cardinal;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__connection_ip__string_ref(__skparam__name);
  result := __skadapter__to_unsigned_int(__skreturn);
end;
function ConnectionNamed(const name: String): Connection;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__connection_named__string_ref(__skparam__name);
  result := __skadapter__to_connection(__skreturn);
end;
function ConnectionPort(aConnection: Connection): Word;
var
  __skparam__a_connection: __sklib_ptr;
  __skreturn: Word;
begin
  __skparam__a_connection := __skadapter__to_sklib_connection(aConnection);
  __skreturn := __sklib__connection_port__connection(__skparam__a_connection);
  result := __skadapter__to_unsigned_short(__skreturn);
end;
function ConnectionPort(const name: String): Word;
var
  __skparam__name: __sklib_string;
  __skreturn: Word;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__connection_port__string_ref(__skparam__name);
  result := __skadapter__to_unsigned_short(__skreturn);
end;
function CreateServer(const name: String; port: Word): ServerSocket;
var
  __skparam__name: __sklib_string;
  __skparam__port: Word;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skreturn := __sklib__create_server__string_ref__unsigned_short(__skparam__name, __skparam__port);
  result := __skadapter__to_server_socket(__skreturn);
end;
function CreateServer(const name: String; port: Word; protocol: ConnectionType): ServerSocket;
var
  __skparam__name: __sklib_string;
  __skparam__port: Word;
  __skparam__protocol: LongInt;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skparam__protocol := __skadapter__to_sklib_connection_type(protocol);
  __skreturn := __sklib__create_server__string_ref__unsigned_short__connection_type(__skparam__name, __skparam__port, __skparam__protocol);
  result := __skadapter__to_server_socket(__skreturn);
end;
function DecToHex(aDec: Cardinal): String;
var
  __skparam__a_dec: Cardinal;
  __skreturn: __sklib_string;
begin
  __skparam__a_dec := __skadapter__to_sklib_unsigned_int(aDec);
  __skreturn := __sklib__dec_to_hex__unsigned_int(__skparam__a_dec);
  result := __skadapter__to_string(__skreturn);
end;
function FetchNewConnection(server: ServerSocket): Connection;
var
  __skparam__server: __sklib_ptr;
  __skreturn: __sklib_ptr;
begin
  __skparam__server := __skadapter__to_sklib_server_socket(server);
  __skreturn := __sklib__fetch_new_connection__server_socket(__skparam__server);
  result := __skadapter__to_connection(__skreturn);
end;
function HasConnection(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_connection__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function HasMessages(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__has_messages();
  result := __skadapter__to_bool(__skreturn);
end;
function HasMessages(con: Connection): Boolean;
var
  __skparam__con: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__con := __skadapter__to_sklib_connection(con);
  __skreturn := __sklib__has_messages__connection(__skparam__con);
  result := __skadapter__to_bool(__skreturn);
end;
function HasMessages(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_messages__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function HasMessages(svr: ServerSocket): Boolean;
var
  __skparam__svr: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__svr := __skadapter__to_sklib_server_socket(svr);
  __skreturn := __sklib__has_messages__server_socket(__skparam__svr);
  result := __skadapter__to_bool(__skreturn);
end;
function HasNewConnections(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__has_new_connections();
  result := __skadapter__to_bool(__skreturn);
end;
function HasServer(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_server__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function HexStrToIpv4(const aHex: String): String;
var
  __skparam__a_hex: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__a_hex := __skadapter__to_sklib_string(aHex);
  __skreturn := __sklib__hex_str_to_ipv4__string_ref(__skparam__a_hex);
  result := __skadapter__to_string(__skreturn);
end;
function HexToDecString(const aHex: String): String;
var
  __skparam__a_hex: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__a_hex := __skadapter__to_sklib_string(aHex);
  __skreturn := __sklib__hex_to_dec_string__string_ref(__skparam__a_hex);
  result := __skadapter__to_string(__skreturn);
end;
function Ipv4ToDec(const aIP: String): Cardinal;
var
  __skparam__a_ip: __sklib_string;
  __skreturn: Cardinal;
begin
  __skparam__a_ip := __skadapter__to_sklib_string(aIP);
  __skreturn := __sklib__ipv4_to_dec__string_ref(__skparam__a_ip);
  result := __skadapter__to_unsigned_int(__skreturn);
end;
function Ipv4ToHex(const aIP: String): String;
var
  __skparam__a_ip: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__a_ip := __skadapter__to_sklib_string(aIP);
  __skreturn := __sklib__ipv4_to_hex__string_ref(__skparam__a_ip);
  result := __skadapter__to_string(__skreturn);
end;
function Ipv4ToStr(ip: Cardinal): String;
var
  __skparam__ip: Cardinal;
  __skreturn: __sklib_string;
begin
  __skparam__ip := __skadapter__to_sklib_unsigned_int(ip);
  __skreturn := __sklib__ipv4_to_str__unsigned_int(__skparam__ip);
  result := __skadapter__to_string(__skreturn);
end;
function IsConnectionOpen(con: Connection): Boolean;
var
  __skparam__con: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__con := __skadapter__to_sklib_connection(con);
  __skreturn := __sklib__is_connection_open__connection(__skparam__con);
  result := __skadapter__to_bool(__skreturn);
end;
function IsConnectionOpen(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__is_connection_open__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function LastConnection(const name: String): Connection;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__last_connection__string_ref(__skparam__name);
  result := __skadapter__to_connection(__skreturn);
end;
function LastConnection(server: ServerSocket): Connection;
var
  __skparam__server: __sklib_ptr;
  __skreturn: __sklib_ptr;
begin
  __skparam__server := __skadapter__to_sklib_server_socket(server);
  __skreturn := __sklib__last_connection__server_socket(__skparam__server);
  result := __skadapter__to_connection(__skreturn);
end;
function MessageConnection(msg: Message): Connection;
var
  __skparam__msg: __sklib_ptr;
  __skreturn: __sklib_ptr;
begin
  __skparam__msg := __skadapter__to_sklib_message(msg);
  __skreturn := __sklib__message_connection__message(__skparam__msg);
  result := __skadapter__to_connection(__skreturn);
end;
function MessageCount(svr: ServerSocket): Cardinal;
var
  __skparam__svr: __sklib_ptr;
  __skreturn: Cardinal;
begin
  __skparam__svr := __skadapter__to_sklib_server_socket(svr);
  __skreturn := __sklib__message_count__server_socket(__skparam__svr);
  result := __skadapter__to_unsigned_int(__skreturn);
end;
function MessageCount(aConnection: Connection): Cardinal;
var
  __skparam__a_connection: __sklib_ptr;
  __skreturn: Cardinal;
begin
  __skparam__a_connection := __skadapter__to_sklib_connection(aConnection);
  __skreturn := __sklib__message_count__connection(__skparam__a_connection);
  result := __skadapter__to_unsigned_int(__skreturn);
end;
function MessageCount(const name: String): Cardinal;
var
  __skparam__name: __sklib_string;
  __skreturn: Cardinal;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__message_count__string_ref(__skparam__name);
  result := __skadapter__to_unsigned_int(__skreturn);
end;
function MessageData(msg: Message): String;
var
  __skparam__msg: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__msg := __skadapter__to_sklib_message(msg);
  __skreturn := __sklib__message_data__message(__skparam__msg);
  result := __skadapter__to_string(__skreturn);
end;
function MessageDataBytes(msg: Message): ArrayOfChar;
var
  __skparam__msg: __sklib_ptr;
  __skreturn: __sklib_vector_int8_t;
begin
  __skparam__msg := __skadapter__to_sklib_message(msg);
  __skreturn := __sklib__message_data_bytes__message(__skparam__msg);
  result := __skadapter__to_vector_int8_t(__skreturn);
end;
function MessageHost(msg: Message): String;
var
  __skparam__msg: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__msg := __skadapter__to_sklib_message(msg);
  __skreturn := __sklib__message_host__message(__skparam__msg);
  result := __skadapter__to_string(__skreturn);
end;
function MessagePort(msg: Message): Word;
var
  __skparam__msg: __sklib_ptr;
  __skreturn: Word;
begin
  __skparam__msg := __skadapter__to_sklib_message(msg);
  __skreturn := __sklib__message_port__message(__skparam__msg);
  result := __skadapter__to_unsigned_short(__skreturn);
end;
function MessageProtocol(msg: Message): ConnectionType;
var
  __skparam__msg: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__msg := __skadapter__to_sklib_message(msg);
  __skreturn := __sklib__message_protocol__message(__skparam__msg);
  result := __skadapter__to_connection_type(__skreturn);
end;
function MyIP(): String;
var
  __skreturn: __sklib_string;
begin
  __skreturn := __sklib__my_ip();
  result := __skadapter__to_string(__skreturn);
end;
function NameForConnection(host: String; port: Cardinal): String;
var
  __skparam__host: __sklib_string;
  __skparam__port: Cardinal;
  __skreturn: __sklib_string;
begin
  __skparam__host := __skadapter__to_sklib_string(host);
  __skparam__port := __skadapter__to_sklib_unsigned_int(port);
  __skreturn := __sklib__name_for_connection__string__unsigned_int(__skparam__host, __skparam__port);
  result := __skadapter__to_string(__skreturn);
end;
function NewConnectionCount(server: ServerSocket): Integer;
var
  __skparam__server: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__server := __skadapter__to_sklib_server_socket(server);
  __skreturn := __sklib__new_connection_count__server_socket(__skparam__server);
  result := __skadapter__to_int(__skreturn);
end;
function OpenConnection(const name: String; const host: String; port: Word): Connection;
var
  __skparam__name: __sklib_string;
  __skparam__host: __sklib_string;
  __skparam__port: Word;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__host := __skadapter__to_sklib_string(host);
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skreturn := __sklib__open_connection__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__host, __skparam__port);
  result := __skadapter__to_connection(__skreturn);
end;
function OpenConnection(const name: String; const host: String; port: Word; protocol: ConnectionType): Connection;
var
  __skparam__name: __sklib_string;
  __skparam__host: __sklib_string;
  __skparam__port: Word;
  __skparam__protocol: LongInt;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__host := __skadapter__to_sklib_string(host);
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skparam__protocol := __skadapter__to_sklib_connection_type(protocol);
  __skreturn := __sklib__open_connection__string_ref__string_ref__unsigned_short__connection_type(__skparam__name, __skparam__host, __skparam__port, __skparam__protocol);
  result := __skadapter__to_connection(__skreturn);
end;
function ReadMessage(): Message;
var
  __skreturn: __sklib_ptr;
begin
  __skreturn := __sklib__read_message();
  result := __skadapter__to_message(__skreturn);
end;
function ReadMessage(aConnection: Connection): Message;
var
  __skparam__a_connection: __sklib_ptr;
  __skreturn: __sklib_ptr;
begin
  __skparam__a_connection := __skadapter__to_sklib_connection(aConnection);
  __skreturn := __sklib__read_message__connection(__skparam__a_connection);
  result := __skadapter__to_message(__skreturn);
end;
function ReadMessage(const name: String): Message;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__read_message__string_ref(__skparam__name);
  result := __skadapter__to_message(__skreturn);
end;
function ReadMessage(svr: ServerSocket): Message;
var
  __skparam__svr: __sklib_ptr;
  __skreturn: __sklib_ptr;
begin
  __skparam__svr := __skadapter__to_sklib_server_socket(svr);
  __skreturn := __sklib__read_message__server_socket(__skparam__svr);
  result := __skadapter__to_message(__skreturn);
end;
function ReadMessageData(const name: String): String;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__read_message_data__string_ref(__skparam__name);
  result := __skadapter__to_string(__skreturn);
end;
function ReadMessageData(aConnection: Connection): String;
var
  __skparam__a_connection: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__a_connection := __skadapter__to_sklib_connection(aConnection);
  __skreturn := __sklib__read_message_data__connection(__skparam__a_connection);
  result := __skadapter__to_string(__skreturn);
end;
function ReadMessageData(svr: ServerSocket): String;
var
  __skparam__svr: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__svr := __skadapter__to_sklib_server_socket(svr);
  __skreturn := __sklib__read_message_data__server_socket(__skparam__svr);
  result := __skadapter__to_string(__skreturn);
end;
procedure Reconnect(aConnection: Connection);
var
  __skparam__a_connection: __sklib_ptr;
begin
  __skparam__a_connection := __skadapter__to_sklib_connection(aConnection);
  __sklib__reconnect__connection(__skparam__a_connection);
end;
procedure Reconnect(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__reconnect__string_ref(__skparam__name);
end;
procedure ReleaseAllConnections();
begin
  __sklib__release_all_connections();
end;
procedure ResetNewConnectionCount(server: ServerSocket);
var
  __skparam__server: __sklib_ptr;
begin
  __skparam__server := __skadapter__to_sklib_server_socket(server);
  __sklib__reset_new_connection_count__server_socket(__skparam__server);
end;
function RetrieveConnection(const name: String; idx: Integer): Connection;
var
  __skparam__name: __sklib_string;
  __skparam__idx: Integer;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skreturn := __sklib__retrieve_connection__string_ref__int(__skparam__name, __skparam__idx);
  result := __skadapter__to_connection(__skreturn);
end;
function RetrieveConnection(server: ServerSocket; idx: Integer): Connection;
var
  __skparam__server: __sklib_ptr;
  __skparam__idx: Integer;
  __skreturn: __sklib_ptr;
begin
  __skparam__server := __skadapter__to_sklib_server_socket(server);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skreturn := __sklib__retrieve_connection__server_socket__int(__skparam__server, __skparam__idx);
  result := __skadapter__to_connection(__skreturn);
end;
function SendMessageTo(const aMsg: String; aConnection: Connection): Boolean;
var
  __skparam__a_msg: __sklib_string;
  __skparam__a_connection: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__a_msg := __skadapter__to_sklib_string(aMsg);
  __skparam__a_connection := __skadapter__to_sklib_connection(aConnection);
  __skreturn := __sklib__send_message_to__string_ref__connection(__skparam__a_msg, __skparam__a_connection);
  result := __skadapter__to_bool(__skreturn);
end;
function SendMessageTo(const aMsg: String; const name: String): Boolean;
var
  __skparam__a_msg: __sklib_string;
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__a_msg := __skadapter__to_sklib_string(aMsg);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__send_message_to__string_ref__string_ref(__skparam__a_msg, __skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function ServerHasNewConnection(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__server_has_new_connection__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function ServerHasNewConnection(server: ServerSocket): Boolean;
var
  __skparam__server: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__server := __skadapter__to_sklib_server_socket(server);
  __skreturn := __sklib__server_has_new_connection__server_socket(__skparam__server);
  result := __skadapter__to_bool(__skreturn);
end;
function ServerNamed(const name: String): ServerSocket;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__server_named__string_ref(__skparam__name);
  result := __skadapter__to_server_socket(__skreturn);
end;
procedure SetUDPPacketSize(udpPacketSize: Cardinal);
var
  __skparam__udp_packet_size: Cardinal;
begin
  __skparam__udp_packet_size := __skadapter__to_sklib_unsigned_int(udpPacketSize);
  __sklib__set_udp_packet_size__unsigned_int(__skparam__udp_packet_size);
end;
function UDPPacketSize(): Cardinal;
var
  __skreturn: Cardinal;
begin
  __skreturn := __sklib__udp_packet_size();
  result := __skadapter__to_unsigned_int(__skreturn);
end;
procedure DrawPixel(clr: Color; const pt: Point2D);
var
  __skparam__clr: __sklib_color;
  __skparam__pt: __sklib_point_2d;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __sklib__draw_pixel__color__point_2d_ref(__skparam__clr, __skparam__pt);
end;
procedure DrawPixel(clr: Color; const pt: Point2D; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__pt: __sklib_point_2d;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_pixel__color__point_2d_ref__drawing_options(__skparam__clr, __skparam__pt, __skparam__opts);
end;
procedure DrawPixel(clr: Color; x: Double; y: Double);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_pixel__color__double__double(__skparam__clr, __skparam__x, __skparam__y);
end;
procedure DrawPixel(clr: Color; x: Double; y: Double; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_pixel__color__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawPixelOnBitmap(destination: Bitmap; clr: Color; const pt: Point2D);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__pt: __sklib_point_2d;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__pt);
end;
procedure DrawPixelOnBitmap(destination: Bitmap; clr: Color; const pt: Point2D; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__pt: __sklib_point_2d;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__pt, __skparam__opts);
end;
procedure DrawPixelOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_pixel_on_bitmap__bitmap__color__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y);
end;
procedure DrawPixelOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_pixel_on_bitmap__bitmap__color__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawPixelOnWindow(destination: Window; clr: Color; const pt: Point2D);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__pt: __sklib_point_2d;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __sklib__draw_pixel_on_window__window__color__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__pt);
end;
procedure DrawPixelOnWindow(destination: Window; clr: Color; const pt: Point2D; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__pt: __sklib_point_2d;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_pixel_on_window__window__color__point_2d_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__pt, __skparam__opts);
end;
procedure DrawPixelOnWindow(destination: Window; clr: Color; x: Double; y: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_pixel_on_window__window__color__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y);
end;
procedure DrawPixelOnWindow(destination: Window; clr: Color; x: Double; y: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_pixel_on_window__window__color__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
end;
function GetPixel(bmp: Bitmap; const pt: Point2D): Color;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_color;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__get_pixel__bitmap__point_2d_ref(__skparam__bmp, __skparam__pt);
  result := __skadapter__to_color(__skreturn);
end;
function GetPixel(bmp: Bitmap; x: Double; y: Double): Color;
var
  __skparam__bmp: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: __sklib_color;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__get_pixel__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y);
  result := __skadapter__to_color(__skreturn);
end;
function GetPixel(const pt: Point2D): Color;
var
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_color;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__get_pixel__point_2d_ref(__skparam__pt);
  result := __skadapter__to_color(__skreturn);
end;
function GetPixel(x: Double; y: Double): Color;
var
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: __sklib_color;
begin
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__get_pixel__double__double(__skparam__x, __skparam__y);
  result := __skadapter__to_color(__skreturn);
end;
function GetPixel(wnd: Window; const pt: Point2D): Color;
var
  __skparam__wnd: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_color;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__get_pixel__window__point_2d_ref(__skparam__wnd, __skparam__pt);
  result := __skadapter__to_color(__skreturn);
end;
function GetPixel(wnd: Window; x: Double; y: Double): Color;
var
  __skparam__wnd: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: __sklib_color;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__get_pixel__window__double__double(__skparam__wnd, __skparam__x, __skparam__y);
  result := __skadapter__to_color(__skreturn);
end;
function GetPixelFromWindow(destination: Window; const pt: Point2D): Color;
var
  __skparam__destination: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_color;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__get_pixel_from_window__window__point_2d_ref(__skparam__destination, __skparam__pt);
  result := __skadapter__to_color(__skreturn);
end;
function GetPixelFromWindow(destination: Window; x: Double; y: Double): Color;
var
  __skparam__destination: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: __sklib_color;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__get_pixel_from_window__window__double__double(__skparam__destination, __skparam__x, __skparam__y);
  result := __skadapter__to_color(__skreturn);
end;
function PointAt(x: Double; y: Double): Point2D;
var
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: __sklib_point_2d;
begin
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__point_at__double__double(__skparam__x, __skparam__y);
  result := __skadapter__to_point_2d(__skreturn);
end;
function PointAtOrigin(): Point2D;
var
  __skreturn: __sklib_point_2d;
begin
  __skreturn := __sklib__point_at_origin();
  result := __skadapter__to_point_2d(__skreturn);
end;
function PointInCircle(const pt: Point2D; const c: Circle): Boolean;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__c: __sklib_circle;
  __skreturn: LongInt;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skreturn := __sklib__point_in_circle__point_2d_ref__circle_ref(__skparam__pt, __skparam__c);
  result := __skadapter__to_bool(__skreturn);
end;
function PointInCircle(ptx: Double; pty: Double; cx: Double; cy: Double; radius: Double): Boolean;
var
  __skparam__ptx: Double;
  __skparam__pty: Double;
  __skparam__cx: Double;
  __skparam__cy: Double;
  __skparam__radius: Double;
  __skreturn: LongInt;
begin
  __skparam__ptx := __skadapter__to_sklib_double(ptx);
  __skparam__pty := __skadapter__to_sklib_double(pty);
  __skparam__cx := __skadapter__to_sklib_double(cx);
  __skparam__cy := __skadapter__to_sklib_double(cy);
  __skparam__radius := __skadapter__to_sklib_double(radius);
  __skreturn := __sklib__point_in_circle__double__double__double__double__double(__skparam__ptx, __skparam__pty, __skparam__cx, __skparam__cy, __skparam__radius);
  result := __skadapter__to_bool(__skreturn);
end;
function PointInQuad(const pt: Point2D; const q: Quad): Boolean;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__q: __sklib_quad;
  __skreturn: LongInt;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __skreturn := __sklib__point_in_quad__point_2d_ref__quad_ref(__skparam__pt, __skparam__q);
  result := __skadapter__to_bool(__skreturn);
end;
function PointInRectangle(const pt: Point2D; const rect: Rectangle): Boolean;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__point_in_rectangle__point_2d_ref__rectangle_ref(__skparam__pt, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function PointInRectangle(ptx: Double; pty: Double; rectX: Double; rectY: Double; rectWidth: Double; rectHeight: Double): Boolean;
var
  __skparam__ptx: Double;
  __skparam__pty: Double;
  __skparam__rect_x: Double;
  __skparam__rect_y: Double;
  __skparam__rect_width: Double;
  __skparam__rect_height: Double;
  __skreturn: LongInt;
begin
  __skparam__ptx := __skadapter__to_sklib_double(ptx);
  __skparam__pty := __skadapter__to_sklib_double(pty);
  __skparam__rect_x := __skadapter__to_sklib_double(rectX);
  __skparam__rect_y := __skadapter__to_sklib_double(rectY);
  __skparam__rect_width := __skadapter__to_sklib_double(rectWidth);
  __skparam__rect_height := __skadapter__to_sklib_double(rectHeight);
  __skreturn := __sklib__point_in_rectangle__double__double__double__double__double__double(__skparam__ptx, __skparam__pty, __skparam__rect_x, __skparam__rect_y, __skparam__rect_width, __skparam__rect_height);
  result := __skadapter__to_bool(__skreturn);
end;
function PointInTriangle(const pt: Point2D; const tri: Triangle): Boolean;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__tri: __sklib_triangle;
  __skreturn: LongInt;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skreturn := __sklib__point_in_triangle__point_2d_ref__triangle_ref(__skparam__pt, __skparam__tri);
  result := __skadapter__to_bool(__skreturn);
end;
function PointLineDistance(const pt: Point2D; const l: Line): Single;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__l: __sklib_line;
  __skreturn: Single;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__l := __skadapter__to_sklib_line(l);
  __skreturn := __sklib__point_line_distance__point_2d_ref__line_ref(__skparam__pt, __skparam__l);
  result := __skadapter__to_float(__skreturn);
end;
function PointOffsetBy(const startPoint: Point2D; const offset: Vector2D): Point2D;
var
  __skparam__start_point: __sklib_point_2d;
  __skparam__offset: __sklib_vector_2d;
  __skreturn: __sklib_point_2d;
begin
  __skparam__start_point := __skadapter__to_sklib_point_2d(startPoint);
  __skparam__offset := __skadapter__to_sklib_vector_2d(offset);
  __skreturn := __sklib__point_offset_by__point_2d_ref__vector_2d_ref(__skparam__start_point, __skparam__offset);
  result := __skadapter__to_point_2d(__skreturn);
end;
function PointOffsetFromOrigin(const offset: Vector2D): Point2D;
var
  __skparam__offset: __sklib_vector_2d;
  __skreturn: __sklib_point_2d;
begin
  __skparam__offset := __skadapter__to_sklib_vector_2d(offset);
  __skreturn := __sklib__point_offset_from_origin__vector_2d_ref(__skparam__offset);
  result := __skadapter__to_point_2d(__skreturn);
end;
function PointOnLine(const pt: Point2D; const l: Line): Boolean;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__l: __sklib_line;
  __skreturn: LongInt;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__l := __skadapter__to_sklib_line(l);
  __skreturn := __sklib__point_on_line__point_2d_ref__line_ref(__skparam__pt, __skparam__l);
  result := __skadapter__to_bool(__skreturn);
end;
function PointOnLine(const pt: Point2D; const l: Line; proximity: Single): Boolean;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__l: __sklib_line;
  __skparam__proximity: Single;
  __skreturn: LongInt;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__l := __skadapter__to_sklib_line(l);
  __skparam__proximity := __skadapter__to_sklib_float(proximity);
  __skreturn := __sklib__point_on_line__point_2d_ref__line_ref__float(__skparam__pt, __skparam__l, __skparam__proximity);
  result := __skadapter__to_bool(__skreturn);
end;
function PointPointAngle(const pt1: Point2D; const pt2: Point2D): Single;
var
  __skparam__pt1: __sklib_point_2d;
  __skparam__pt2: __sklib_point_2d;
  __skreturn: Single;
begin
  __skparam__pt1 := __skadapter__to_sklib_point_2d(pt1);
  __skparam__pt2 := __skadapter__to_sklib_point_2d(pt2);
  __skreturn := __sklib__point_point_angle__point_2d_ref__point_2d_ref(__skparam__pt1, __skparam__pt2);
  result := __skadapter__to_float(__skreturn);
end;
function PointPointDistance(const pt1: Point2D; const pt2: Point2D): Single;
var
  __skparam__pt1: __sklib_point_2d;
  __skparam__pt2: __sklib_point_2d;
  __skreturn: Single;
begin
  __skparam__pt1 := __skadapter__to_sklib_point_2d(pt1);
  __skparam__pt2 := __skadapter__to_sklib_point_2d(pt2);
  __skreturn := __sklib__point_point_distance__point_2d_ref__point_2d_ref(__skparam__pt1, __skparam__pt2);
  result := __skadapter__to_float(__skreturn);
end;
function PointToString(const pt: Point2D): String;
var
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_string;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__point_to_string__point_2d_ref(__skparam__pt);
  result := __skadapter__to_string(__skreturn);
end;
function RandomBitmapPoint(bmp: Bitmap): Point2D;
var
  __skparam__bmp: __sklib_ptr;
  __skreturn: __sklib_point_2d;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skreturn := __sklib__random_bitmap_point__bitmap(__skparam__bmp);
  result := __skadapter__to_point_2d(__skreturn);
end;
function RandomScreenPoint(): Point2D;
var
  __skreturn: __sklib_point_2d;
begin
  __skreturn := __sklib__random_screen_point();
  result := __skadapter__to_point_2d(__skreturn);
end;
function RandomWindowPoint(wind: Window): Point2D;
var
  __skparam__wind: __sklib_ptr;
  __skreturn: __sklib_point_2d;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skreturn := __sklib__random_window_point__window(__skparam__wind);
  result := __skadapter__to_point_2d(__skreturn);
end;
function SamePoint(const pt1: Point2D; const pt2: Point2D): Boolean;
var
  __skparam__pt1: __sklib_point_2d;
  __skparam__pt2: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__pt1 := __skadapter__to_sklib_point_2d(pt1);
  __skparam__pt2 := __skadapter__to_sklib_point_2d(pt2);
  __skreturn := __sklib__same_point__point_2d_ref__point_2d_ref(__skparam__pt1, __skparam__pt2);
  result := __skadapter__to_bool(__skreturn);
end;
function QuadFrom(const p1: Point2D; const p2: Point2D; const p3: Point2D; const p4: Point2D): Quad;
var
  __skparam__p1: __sklib_point_2d;
  __skparam__p2: __sklib_point_2d;
  __skparam__p3: __sklib_point_2d;
  __skparam__p4: __sklib_point_2d;
  __skreturn: __sklib_quad;
begin
  __skparam__p1 := __skadapter__to_sklib_point_2d(p1);
  __skparam__p2 := __skadapter__to_sklib_point_2d(p2);
  __skparam__p3 := __skadapter__to_sklib_point_2d(p3);
  __skparam__p4 := __skadapter__to_sklib_point_2d(p4);
  __skreturn := __sklib__quad_from__point_2d_ref__point_2d_ref__point_2d_ref__point_2d_ref(__skparam__p1, __skparam__p2, __skparam__p3, __skparam__p4);
  result := __skadapter__to_quad(__skreturn);
end;
function QuadFrom(const rect: Rectangle): Quad;
var
  __skparam__rect: __sklib_rectangle;
  __skreturn: __sklib_quad;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__quad_from__rectangle_ref(__skparam__rect);
  result := __skadapter__to_quad(__skreturn);
end;
function QuadFrom(const rect: Rectangle; const transform: Matrix2D): Quad;
var
  __skparam__rect: __sklib_rectangle;
  __skparam__transform: __sklib_matrix_2d;
  __skreturn: __sklib_quad;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__transform := __skadapter__to_sklib_matrix_2d(transform);
  __skreturn := __sklib__quad_from__rectangle_ref__matrix_2d_ref(__skparam__rect, __skparam__transform);
  result := __skadapter__to_quad(__skreturn);
end;
function QuadFrom(xTopLeft: Double; yTopLeft: Double; xTopRight: Double; yTopRight: Double; xBottomLeft: Double; yBottomLeft: Double; xBottomRight: Double; yBottomRight: Double): Quad;
var
  __skparam__x_top_left: Double;
  __skparam__y_top_left: Double;
  __skparam__x_top_right: Double;
  __skparam__y_top_right: Double;
  __skparam__x_bottom_left: Double;
  __skparam__y_bottom_left: Double;
  __skparam__x_bottom_right: Double;
  __skparam__y_bottom_right: Double;
  __skreturn: __sklib_quad;
begin
  __skparam__x_top_left := __skadapter__to_sklib_double(xTopLeft);
  __skparam__y_top_left := __skadapter__to_sklib_double(yTopLeft);
  __skparam__x_top_right := __skadapter__to_sklib_double(xTopRight);
  __skparam__y_top_right := __skadapter__to_sklib_double(yTopRight);
  __skparam__x_bottom_left := __skadapter__to_sklib_double(xBottomLeft);
  __skparam__y_bottom_left := __skadapter__to_sklib_double(yBottomLeft);
  __skparam__x_bottom_right := __skadapter__to_sklib_double(xBottomRight);
  __skparam__y_bottom_right := __skadapter__to_sklib_double(yBottomRight);
  __skreturn := __sklib__quad_from__double__double__double__double__double__double__double__double(__skparam__x_top_left, __skparam__y_top_left, __skparam__x_top_right, __skparam__y_top_right, __skparam__x_bottom_left, __skparam__y_bottom_left, __skparam__x_bottom_right, __skparam__y_bottom_right);
  result := __skadapter__to_quad(__skreturn);
end;
function QuadsIntersect(const q1: Quad; const q2: Quad): Boolean;
var
  __skparam__q1: __sklib_quad;
  __skparam__q2: __sklib_quad;
  __skreturn: LongInt;
begin
  __skparam__q1 := __skadapter__to_sklib_quad(q1);
  __skparam__q2 := __skadapter__to_sklib_quad(q2);
  __skreturn := __sklib__quads_intersect__quad_ref__quad_ref(__skparam__q1, __skparam__q2);
  result := __skadapter__to_bool(__skreturn);
end;
procedure SetQuadPoint(var q: Quad; idx: Integer; const value: Point2D);
var
  __skparam__q: __sklib_quad;
  __skparam__idx: Integer;
  __skparam__value: __sklib_point_2d;
begin
  __skparam__q := __skadapter__to_sklib_quad(q);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skparam__value := __skadapter__to_sklib_point_2d(value);
  __sklib__set_quad_point__quad_ref__int__point_2d_ref(__skparam__q, __skparam__idx, __skparam__value);
  q := __skadapter__to_quad(__skparam__q);
end;
function TrianglesFrom(const q: Quad): ArrayOfTriangle;
var
  __skparam__q: __sklib_quad;
  __skreturn: __sklib_vector_triangle;
begin
  __skparam__q := __skadapter__to_sklib_quad(q);
  __skreturn := __sklib__triangles_from__quad_ref(__skparam__q);
  result := __skadapter__to_vector_triangle(__skreturn);
end;
function Rnd(min: Integer; max: Integer): Integer;
var
  __skparam__min: Integer;
  __skparam__max: Integer;
  __skreturn: Integer;
begin
  __skparam__min := __skadapter__to_sklib_int(min);
  __skparam__max := __skadapter__to_sklib_int(max);
  __skreturn := __sklib__rnd__int__int(__skparam__min, __skparam__max);
  result := __skadapter__to_int(__skreturn);
end;
function Rnd(): Single;
var
  __skreturn: Single;
begin
  __skreturn := __sklib__rnd();
  result := __skadapter__to_float(__skreturn);
end;
function Rnd(ubound: Integer): Integer;
var
  __skparam__ubound: Integer;
  __skreturn: Integer;
begin
  __skparam__ubound := __skadapter__to_sklib_int(ubound);
  __skreturn := __sklib__rnd__int(__skparam__ubound);
  result := __skadapter__to_int(__skreturn);
end;
function HasGpio(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__has_gpio();
  result := __skadapter__to_bool(__skreturn);
end;
procedure RaspiCleanup();
begin
  __sklib__raspi_cleanup();
end;
function RaspiGetMode(pin: Pins): PinModes;
var
  __skparam__pin: LongInt;
  __skreturn: LongInt;
begin
  __skparam__pin := __skadapter__to_sklib_pins(pin);
  __skreturn := __sklib__raspi_get_mode__pins(__skparam__pin);
  result := __skadapter__to_pin_modes(__skreturn);
end;
procedure RaspiInit();
begin
  __sklib__raspi_init();
end;
function RaspiRead(pin: Pins): PinValues;
var
  __skparam__pin: LongInt;
  __skreturn: LongInt;
begin
  __skparam__pin := __skadapter__to_sklib_pins(pin);
  __skreturn := __sklib__raspi_read__pins(__skparam__pin);
  result := __skadapter__to_pin_values(__skreturn);
end;
procedure RaspiSetMode(pin: Pins; mode: PinModes);
var
  __skparam__pin: LongInt;
  __skparam__mode: LongInt;
begin
  __skparam__pin := __skadapter__to_sklib_pins(pin);
  __skparam__mode := __skadapter__to_sklib_pin_modes(mode);
  __sklib__raspi_set_mode__pins__pin_modes(__skparam__pin, __skparam__mode);
end;
procedure RaspiSetPullUpDown(pin: Pins; pud: PullUpDown);
var
  __skparam__pin: LongInt;
  __skparam__pud: LongInt;
begin
  __skparam__pin := __skadapter__to_sklib_pins(pin);
  __skparam__pud := __skadapter__to_sklib_pull_up_down(pud);
  __sklib__raspi_set_pull_up_down__pins__pull_up_down(__skparam__pin, __skparam__pud);
end;
procedure RaspiSetPwmDutycycle(pin: Pins; dutycycle: Integer);
var
  __skparam__pin: LongInt;
  __skparam__dutycycle: Integer;
begin
  __skparam__pin := __skadapter__to_sklib_pins(pin);
  __skparam__dutycycle := __skadapter__to_sklib_int(dutycycle);
  __sklib__raspi_set_pwm_dutycycle__pins__int(__skparam__pin, __skparam__dutycycle);
end;
procedure RaspiSetPwmFrequency(pin: Pins; frequency: Integer);
var
  __skparam__pin: LongInt;
  __skparam__frequency: Integer;
begin
  __skparam__pin := __skadapter__to_sklib_pins(pin);
  __skparam__frequency := __skadapter__to_sklib_int(frequency);
  __sklib__raspi_set_pwm_frequency__pins__int(__skparam__pin, __skparam__frequency);
end;
procedure RaspiSetPwmRange(pin: Pins; range: Integer);
var
  __skparam__pin: LongInt;
  __skparam__range: Integer;
begin
  __skparam__pin := __skadapter__to_sklib_pins(pin);
  __skparam__range := __skadapter__to_sklib_int(range);
  __sklib__raspi_set_pwm_range__pins__int(__skparam__pin, __skparam__range);
end;
procedure RaspiWrite(pin: Pins; value: PinValues);
var
  __skparam__pin: LongInt;
  __skparam__value: LongInt;
begin
  __skparam__pin := __skadapter__to_sklib_pins(pin);
  __skparam__value := __skadapter__to_sklib_pin_values(value);
  __sklib__raspi_write__pins__pin_values(__skparam__pin, __skparam__value);
end;
procedure DrawQuad(clr: Color; const q: Quad);
var
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __sklib__draw_quad__color__quad_ref(__skparam__clr, __skparam__q);
end;
procedure DrawQuad(clr: Color; const q: Quad; const opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_quad__color__quad_ref__drawing_options_ref(__skparam__clr, __skparam__q, __skparam__opts);
end;
procedure DrawQuadOnBitmap(destination: Bitmap; clr: Color; const q: Quad);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __sklib__draw_quad_on_bitmap__bitmap__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q);
end;
procedure DrawQuadOnBitmap(destination: Bitmap; clr: Color; const q: Quad; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
end;
procedure DrawQuadOnWindow(destination: Window; clr: Color; const q: Quad);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __sklib__draw_quad_on_window__window__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q);
end;
procedure DrawQuadOnWindow(destination: Window; clr: Color; const q: Quad; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_quad_on_window__window__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
end;
procedure DrawRectangle(clr: Color; const rect: Rectangle);
var
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__draw_rectangle__color__rectangle_ref(__skparam__clr, __skparam__rect);
end;
procedure DrawRectangle(clr: Color; const rect: Rectangle; const opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_rectangle__color__rectangle_ref__drawing_options_ref(__skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure DrawRectangle(clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__draw_rectangle__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure DrawRectangle(clr: Color; x: Double; y: Double; width: Double; height: Double; const opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_rectangle__color__double__double__double__double__drawing_options_ref(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
procedure DrawRectangleOnBitmap(destination: Bitmap; clr: Color; const rect: Rectangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect);
end;
procedure DrawRectangleOnBitmap(destination: Bitmap; clr: Color; const rect: Rectangle; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure DrawRectangleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure DrawRectangleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
procedure DrawRectangleOnWindow(destination: Window; clr: Color; const rect: Rectangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__draw_rectangle_on_window__window__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect);
end;
procedure DrawRectangleOnWindow(destination: Window; clr: Color; const rect: Rectangle; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure DrawRectangleOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__draw_rectangle_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure DrawRectangleOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_rectangle_on_window__window__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
procedure FillQuad(clr: Color; const q: Quad);
var
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __sklib__fill_quad__color__quad_ref(__skparam__clr, __skparam__q);
end;
procedure FillQuad(clr: Color; const q: Quad; const opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_quad__color__quad_ref__drawing_options_ref(__skparam__clr, __skparam__q, __skparam__opts);
end;
procedure FillQuadOnBitmap(destination: Bitmap; clr: Color; const q: Quad);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __sklib__fill_quad_on_bitmap__bitmap__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q);
end;
procedure FillQuadOnBitmap(destination: Bitmap; clr: Color; const q: Quad; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
end;
procedure FillQuadOnWindow(destination: Window; clr: Color; const q: Quad);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __sklib__fill_quad_on_window__window__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q);
end;
procedure FillQuadOnWindow(destination: Window; clr: Color; const q: Quad; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__q: __sklib_quad;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__q := __skadapter__to_sklib_quad(q);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_quad_on_window__window__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
end;
procedure FillRectangle(clr: Color; const rect: Rectangle);
var
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__fill_rectangle__color__rectangle_ref(__skparam__clr, __skparam__rect);
end;
procedure FillRectangle(clr: Color; const rect: Rectangle; const opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_rectangle__color__rectangle_ref__drawing_options_ref(__skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure FillRectangle(clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__fill_rectangle__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure FillRectangle(clr: Color; x: Double; y: Double; width: Double; height: Double; const opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_rectangle__color__double__double__double__double__drawing_options_ref(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
procedure FillRectangleOnBitmap(destination: Bitmap; clr: Color; const rect: Rectangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect);
end;
procedure FillRectangleOnBitmap(destination: Bitmap; clr: Color; const rect: Rectangle; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure FillRectangleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure FillRectangleOnBitmap(destination: Bitmap; clr: Color; x: Double; y: Double; width: Double; height: Double; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
procedure FillRectangleOnWindow(destination: Window; clr: Color; const rect: Rectangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__fill_rectangle_on_window__window__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect);
end;
procedure FillRectangleOnWindow(destination: Window; clr: Color; const rect: Rectangle; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__rect: __sklib_rectangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
end;
procedure FillRectangleOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __sklib__fill_rectangle_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
end;
procedure FillRectangleOnWindow(destination: Window; clr: Color; x: Double; y: Double; width: Double; height: Double; const opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_rectangle_on_window__window__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
end;
function InsetRectangle(const rect: Rectangle; insetAmount: Single): Rectangle;
var
  __skparam__rect: __sklib_rectangle;
  __skparam__inset_amount: Single;
  __skreturn: __sklib_rectangle;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__inset_amount := __skadapter__to_sklib_float(insetAmount);
  __skreturn := __sklib__inset_rectangle__rectangle_ref__float(__skparam__rect, __skparam__inset_amount);
  result := __skadapter__to_rectangle(__skreturn);
end;
function Intersection(const rect1: Rectangle; const rect2: Rectangle): Rectangle;
var
  __skparam__rect1: __sklib_rectangle;
  __skparam__rect2: __sklib_rectangle;
  __skreturn: __sklib_rectangle;
begin
  __skparam__rect1 := __skadapter__to_sklib_rectangle(rect1);
  __skparam__rect2 := __skadapter__to_sklib_rectangle(rect2);
  __skreturn := __sklib__intersection__rectangle_ref__rectangle_ref(__skparam__rect1, __skparam__rect2);
  result := __skadapter__to_rectangle(__skreturn);
end;
function RectangleAround(const c: Circle): Rectangle;
var
  __skparam__c: __sklib_circle;
  __skreturn: __sklib_rectangle;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skreturn := __sklib__rectangle_around__circle_ref(__skparam__c);
  result := __skadapter__to_rectangle(__skreturn);
end;
function RectangleAround(const l: Line): Rectangle;
var
  __skparam__l: __sklib_line;
  __skreturn: __sklib_rectangle;
begin
  __skparam__l := __skadapter__to_sklib_line(l);
  __skreturn := __sklib__rectangle_around__line_ref(__skparam__l);
  result := __skadapter__to_rectangle(__skreturn);
end;
function RectangleAround(const q: Quad): Rectangle;
var
  __skparam__q: __sklib_quad;
  __skreturn: __sklib_rectangle;
begin
  __skparam__q := __skadapter__to_sklib_quad(q);
  __skreturn := __sklib__rectangle_around__quad_ref(__skparam__q);
  result := __skadapter__to_rectangle(__skreturn);
end;
function RectangleAround(const t: Triangle): Rectangle;
var
  __skparam__t: __sklib_triangle;
  __skreturn: __sklib_rectangle;
begin
  __skparam__t := __skadapter__to_sklib_triangle(t);
  __skreturn := __sklib__rectangle_around__triangle_ref(__skparam__t);
  result := __skadapter__to_rectangle(__skreturn);
end;
function RectangleBottom(const rect: Rectangle): Single;
var
  __skparam__rect: __sklib_rectangle;
  __skreturn: Single;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__rectangle_bottom__rectangle_ref(__skparam__rect);
  result := __skadapter__to_float(__skreturn);
end;
function RectangleCenter(const rect: Rectangle): Point2D;
var
  __skparam__rect: __sklib_rectangle;
  __skreturn: __sklib_point_2d;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__rectangle_center__rectangle_ref(__skparam__rect);
  result := __skadapter__to_point_2d(__skreturn);
end;
function RectangleFrom(pt: Point2D; width: Double; height: Double): Rectangle;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__width: Double;
  __skparam__height: Double;
  __skreturn: __sklib_rectangle;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skreturn := __sklib__rectangle_from__point_2d__double__double(__skparam__pt, __skparam__width, __skparam__height);
  result := __skadapter__to_rectangle(__skreturn);
end;
function RectangleFrom(pt1: Point2D; pt2: Point2D): Rectangle;
var
  __skparam__pt1: __sklib_point_2d;
  __skparam__pt2: __sklib_point_2d;
  __skreturn: __sklib_rectangle;
begin
  __skparam__pt1 := __skadapter__to_sklib_point_2d(pt1);
  __skparam__pt2 := __skadapter__to_sklib_point_2d(pt2);
  __skreturn := __sklib__rectangle_from__point_2d__point_2d(__skparam__pt1, __skparam__pt2);
  result := __skadapter__to_rectangle(__skreturn);
end;
function RectangleFrom(x: Double; y: Double; width: Double; height: Double): Rectangle;
var
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__width: Double;
  __skparam__height: Double;
  __skreturn: __sklib_rectangle;
begin
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__width := __skadapter__to_sklib_double(width);
  __skparam__height := __skadapter__to_sklib_double(height);
  __skreturn := __sklib__rectangle_from__double__double__double__double(__skparam__x, __skparam__y, __skparam__width, __skparam__height);
  result := __skadapter__to_rectangle(__skreturn);
end;
function RectangleLeft(const rect: Rectangle): Single;
var
  __skparam__rect: __sklib_rectangle;
  __skreturn: Single;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__rectangle_left__rectangle_ref(__skparam__rect);
  result := __skadapter__to_float(__skreturn);
end;
function RectangleOffsetBy(const rect: Rectangle; const offset: Vector2D): Rectangle;
var
  __skparam__rect: __sklib_rectangle;
  __skparam__offset: __sklib_vector_2d;
  __skreturn: __sklib_rectangle;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__offset := __skadapter__to_sklib_vector_2d(offset);
  __skreturn := __sklib__rectangle_offset_by__rectangle_ref__vector_2d_ref(__skparam__rect, __skparam__offset);
  result := __skadapter__to_rectangle(__skreturn);
end;
function RectangleRight(const rect: Rectangle): Single;
var
  __skparam__rect: __sklib_rectangle;
  __skreturn: Single;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__rectangle_right__rectangle_ref(__skparam__rect);
  result := __skadapter__to_float(__skreturn);
end;
function RectangleToString(const rect: Rectangle): String;
var
  __skparam__rect: __sklib_rectangle;
  __skreturn: __sklib_string;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__rectangle_to_string__rectangle_ref(__skparam__rect);
  result := __skadapter__to_string(__skreturn);
end;
function RectangleTop(const rect: Rectangle): Single;
var
  __skparam__rect: __sklib_rectangle;
  __skreturn: Single;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__rectangle_top__rectangle_ref(__skparam__rect);
  result := __skadapter__to_float(__skreturn);
end;
function RectanglesIntersect(const rect1: Rectangle; const rect2: Rectangle): Boolean;
var
  __skparam__rect1: __sklib_rectangle;
  __skparam__rect2: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__rect1 := __skadapter__to_sklib_rectangle(rect1);
  __skparam__rect2 := __skadapter__to_sklib_rectangle(rect2);
  __skreturn := __sklib__rectangles_intersect__rectangle_ref__rectangle_ref(__skparam__rect1, __skparam__rect2);
  result := __skadapter__to_bool(__skreturn);
end;
procedure DeregisterFreeNotifier(handler: FreeNotifier);
var
  __skparam__handler: FreeNotifier;
begin
  __skparam__handler := __skadapter__to_sklib_free_notifier(handler);
  __sklib__deregister_free_notifier__free_notifier_ptr(__skparam__handler);
end;
function PathToResource(const filename: String; kind: ResourceKind): String;
var
  __skparam__filename: __sklib_string;
  __skparam__kind: LongInt;
  __skreturn: __sklib_string;
begin
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __skparam__kind := __skadapter__to_sklib_resource_kind(kind);
  __skreturn := __sklib__path_to_resource__string_ref__resource_kind(__skparam__filename, __skparam__kind);
  result := __skadapter__to_string(__skreturn);
end;
function PathToResources(): String;
var
  __skreturn: __sklib_string;
begin
  __skreturn := __sklib__path_to_resources();
  result := __skadapter__to_string(__skreturn);
end;
function PathToResources(kind: ResourceKind): String;
var
  __skparam__kind: LongInt;
  __skreturn: __sklib_string;
begin
  __skparam__kind := __skadapter__to_sklib_resource_kind(kind);
  __skreturn := __sklib__path_to_resources__resource_kind(__skparam__kind);
  result := __skadapter__to_string(__skreturn);
end;
procedure RegisterFreeNotifier(fn: FreeNotifier);
var
  __skparam__fn: FreeNotifier;
begin
  __skparam__fn := __skadapter__to_sklib_free_notifier(fn);
  __sklib__register_free_notifier__free_notifier_ptr(__skparam__fn);
end;
procedure SetResourcesPath(const path: String);
var
  __skparam__path: __sklib_string;
begin
  __skparam__path := __skadapter__to_sklib_string(path);
  __sklib__set_resources_path__string_ref(__skparam__path);
end;
procedure FadeAllSoundEffectsOut(ms: Integer);
var
  __skparam__ms: Integer;
begin
  __skparam__ms := __skadapter__to_sklib_int(ms);
  __sklib__fade_all_sound_effects_out__int(__skparam__ms);
end;
procedure FadeSoundEffectOut(effect: SoundEffect; ms: Integer);
var
  __skparam__effect: __sklib_ptr;
  __skparam__ms: Integer;
begin
  __skparam__effect := __skadapter__to_sklib_sound_effect(effect);
  __skparam__ms := __skadapter__to_sklib_int(ms);
  __sklib__fade_sound_effect_out__sound_effect__int(__skparam__effect, __skparam__ms);
end;
procedure FreeAllSoundEffects();
begin
  __sklib__free_all_sound_effects();
end;
procedure FreeSoundEffect(effect: SoundEffect);
var
  __skparam__effect: __sklib_ptr;
begin
  __skparam__effect := __skadapter__to_sklib_sound_effect(effect);
  __sklib__free_sound_effect__sound_effect(__skparam__effect);
end;
function HasSoundEffect(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_sound_effect__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function LoadSoundEffect(const name: String; const filename: String): SoundEffect;
var
  __skparam__name: __sklib_string;
  __skparam__filename: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __skreturn := __sklib__load_sound_effect__string_ref__string_ref(__skparam__name, __skparam__filename);
  result := __skadapter__to_sound_effect(__skreturn);
end;
procedure PlaySoundEffect(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__play_sound_effect__string_ref(__skparam__name);
end;
procedure PlaySoundEffect(const name: String; volume: Double);
var
  __skparam__name: __sklib_string;
  __skparam__volume: Double;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__volume := __skadapter__to_sklib_double(volume);
  __sklib__play_sound_effect__string_ref__double(__skparam__name, __skparam__volume);
end;
procedure PlaySoundEffect(const name: String; times: Integer);
var
  __skparam__name: __sklib_string;
  __skparam__times: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__times := __skadapter__to_sklib_int(times);
  __sklib__play_sound_effect__string_ref__int(__skparam__name, __skparam__times);
end;
procedure PlaySoundEffect(const name: String; times: Integer; volume: Double);
var
  __skparam__name: __sklib_string;
  __skparam__times: Integer;
  __skparam__volume: Double;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__times := __skadapter__to_sklib_int(times);
  __skparam__volume := __skadapter__to_sklib_double(volume);
  __sklib__play_sound_effect__string_ref__int__double(__skparam__name, __skparam__times, __skparam__volume);
end;
procedure PlaySoundEffect(effect: SoundEffect);
var
  __skparam__effect: __sklib_ptr;
begin
  __skparam__effect := __skadapter__to_sklib_sound_effect(effect);
  __sklib__play_sound_effect__sound_effect(__skparam__effect);
end;
procedure PlaySoundEffect(effect: SoundEffect; volume: Double);
var
  __skparam__effect: __sklib_ptr;
  __skparam__volume: Double;
begin
  __skparam__effect := __skadapter__to_sklib_sound_effect(effect);
  __skparam__volume := __skadapter__to_sklib_double(volume);
  __sklib__play_sound_effect__sound_effect__double(__skparam__effect, __skparam__volume);
end;
procedure PlaySoundEffect(effect: SoundEffect; times: Integer);
var
  __skparam__effect: __sklib_ptr;
  __skparam__times: Integer;
begin
  __skparam__effect := __skadapter__to_sklib_sound_effect(effect);
  __skparam__times := __skadapter__to_sklib_int(times);
  __sklib__play_sound_effect__sound_effect__int(__skparam__effect, __skparam__times);
end;
procedure PlaySoundEffect(effect: SoundEffect; times: Integer; volume: Double);
var
  __skparam__effect: __sklib_ptr;
  __skparam__times: Integer;
  __skparam__volume: Double;
begin
  __skparam__effect := __skadapter__to_sklib_sound_effect(effect);
  __skparam__times := __skadapter__to_sklib_int(times);
  __skparam__volume := __skadapter__to_sklib_double(volume);
  __sklib__play_sound_effect__sound_effect__int__double(__skparam__effect, __skparam__times, __skparam__volume);
end;
function SoundEffectFilename(effect: SoundEffect): String;
var
  __skparam__effect: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__effect := __skadapter__to_sklib_sound_effect(effect);
  __skreturn := __sklib__sound_effect_filename__sound_effect(__skparam__effect);
  result := __skadapter__to_string(__skreturn);
end;
function SoundEffectName(effect: SoundEffect): String;
var
  __skparam__effect: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__effect := __skadapter__to_sklib_sound_effect(effect);
  __skreturn := __sklib__sound_effect_name__sound_effect(__skparam__effect);
  result := __skadapter__to_string(__skreturn);
end;
function SoundEffectNamed(const name: String): SoundEffect;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sound_effect_named__string_ref(__skparam__name);
  result := __skadapter__to_sound_effect(__skreturn);
end;
function SoundEffectPlaying(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sound_effect_playing__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function SoundEffectPlaying(effect: SoundEffect): Boolean;
var
  __skparam__effect: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__effect := __skadapter__to_sklib_sound_effect(effect);
  __skreturn := __sklib__sound_effect_playing__sound_effect(__skparam__effect);
  result := __skadapter__to_bool(__skreturn);
end;
function SoundEffectValid(effect: SoundEffect): Boolean;
var
  __skparam__effect: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__effect := __skadapter__to_sklib_sound_effect(effect);
  __skreturn := __sklib__sound_effect_valid__sound_effect(__skparam__effect);
  result := __skadapter__to_bool(__skreturn);
end;
procedure StopSoundEffect(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__stop_sound_effect__string_ref(__skparam__name);
end;
procedure StopSoundEffect(effect: SoundEffect);
var
  __skparam__effect: __sklib_ptr;
begin
  __skparam__effect := __skadapter__to_sklib_sound_effect(effect);
  __sklib__stop_sound_effect__sound_effect(__skparam__effect);
end;
procedure CallForAllSprites(fn: SpriteFloatFunction; val: Single);
var
  __skparam__fn: SpriteFloatFunction;
  __skparam__val: Single;
begin
  __skparam__fn := __skadapter__to_sklib_sprite_float_function(fn);
  __skparam__val := __skadapter__to_sklib_float(val);
  __sklib__call_for_all_sprites__sprite_float_function_ptr__float(__skparam__fn, __skparam__val);
end;
procedure CallForAllSprites(fn: SpriteFunction);
var
  __skparam__fn: SpriteFunction;
begin
  __skparam__fn := __skadapter__to_sklib_sprite_function(fn);
  __sklib__call_for_all_sprites__sprite_function_ptr(__skparam__fn);
end;
procedure CallOnSpriteEvent(handler: SpriteEventHandler);
var
  __skparam__handler: SpriteEventHandler;
begin
  __skparam__handler := __skadapter__to_sklib_sprite_event_handler(handler);
  __sklib__call_on_sprite_event__sprite_event_handler_ptr(__skparam__handler);
end;
function CenterPoint(s: Sprite): Point2D;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_point_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__center_point__sprite(__skparam__s);
  result := __skadapter__to_point_2d(__skreturn);
end;
function CreateSprite(layer: Bitmap): Sprite;
var
  __skparam__layer: __sklib_ptr;
  __skreturn: __sklib_ptr;
begin
  __skparam__layer := __skadapter__to_sklib_bitmap(layer);
  __skreturn := __sklib__create_sprite__bitmap(__skparam__layer);
  result := __skadapter__to_sprite(__skreturn);
end;
function CreateSprite(layer: Bitmap; ani: AnimationScript): Sprite;
var
  __skparam__layer: __sklib_ptr;
  __skparam__ani: __sklib_ptr;
  __skreturn: __sklib_ptr;
begin
  __skparam__layer := __skadapter__to_sklib_bitmap(layer);
  __skparam__ani := __skadapter__to_sklib_animation_script(ani);
  __skreturn := __sklib__create_sprite__bitmap__animation_script(__skparam__layer, __skparam__ani);
  result := __skadapter__to_sprite(__skreturn);
end;
function CreateSprite(const bitmapName: String): Sprite;
var
  __skparam__bitmap_name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__bitmap_name := __skadapter__to_sklib_string(bitmapName);
  __skreturn := __sklib__create_sprite__string_ref(__skparam__bitmap_name);
  result := __skadapter__to_sprite(__skreturn);
end;
function CreateSprite(const name: String; layer: Bitmap): Sprite;
var
  __skparam__name: __sklib_string;
  __skparam__layer: __sklib_ptr;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__layer := __skadapter__to_sklib_bitmap(layer);
  __skreturn := __sklib__create_sprite__string_ref__bitmap(__skparam__name, __skparam__layer);
  result := __skadapter__to_sprite(__skreturn);
end;
function CreateSprite(const name: String; layer: Bitmap; ani: AnimationScript): Sprite;
var
  __skparam__name: __sklib_string;
  __skparam__layer: __sklib_ptr;
  __skparam__ani: __sklib_ptr;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__layer := __skadapter__to_sklib_bitmap(layer);
  __skparam__ani := __skadapter__to_sklib_animation_script(ani);
  __skreturn := __sklib__create_sprite__string_ref__bitmap__animation_script(__skparam__name, __skparam__layer, __skparam__ani);
  result := __skadapter__to_sprite(__skreturn);
end;
function CreateSprite(const bitmapName: String; const animationName: String): Sprite;
var
  __skparam__bitmap_name: __sklib_string;
  __skparam__animation_name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__bitmap_name := __skadapter__to_sklib_string(bitmapName);
  __skparam__animation_name := __skadapter__to_sklib_string(animationName);
  __skreturn := __sklib__create_sprite__string_ref__string_ref(__skparam__bitmap_name, __skparam__animation_name);
  result := __skadapter__to_sprite(__skreturn);
end;
procedure CreateSpritePack(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__create_sprite_pack__string_ref(__skparam__name);
end;
function CurrentSpritePack(): String;
var
  __skreturn: __sklib_string;
begin
  __skreturn := __sklib__current_sprite_pack();
  result := __skadapter__to_string(__skreturn);
end;
procedure DrawAllSprites();
begin
  __sklib__draw_all_sprites();
end;
procedure DrawSprite(s: Sprite; const offset: Vector2D);
var
  __skparam__s: __sklib_ptr;
  __skparam__offset: __sklib_vector_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__offset := __skadapter__to_sklib_vector_2d(offset);
  __sklib__draw_sprite__sprite__vector_2d_ref(__skparam__s, __skparam__offset);
end;
procedure DrawSprite(s: Sprite);
var
  __skparam__s: __sklib_ptr;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __sklib__draw_sprite__sprite(__skparam__s);
end;
procedure DrawSprite(s: Sprite; xOffset: Double; yOffset: Double);
var
  __skparam__s: __sklib_ptr;
  __skparam__x_offset: Double;
  __skparam__y_offset: Double;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__x_offset := __skadapter__to_sklib_double(xOffset);
  __skparam__y_offset := __skadapter__to_sklib_double(yOffset);
  __sklib__draw_sprite__sprite__double__double(__skparam__s, __skparam__x_offset, __skparam__y_offset);
end;
procedure FreeAllSprites();
begin
  __sklib__free_all_sprites();
end;
procedure FreeSprite(s: Sprite);
var
  __skparam__s: __sklib_ptr;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __sklib__free_sprite__sprite(__skparam__s);
end;
procedure FreeSpritePack(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__free_sprite_pack__string_ref(__skparam__name);
end;
function HasSprite(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_sprite__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function HasSpritePack(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_sprite_pack__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
procedure MoveSprite(s: Sprite);
var
  __skparam__s: __sklib_ptr;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __sklib__move_sprite__sprite(__skparam__s);
end;
procedure MoveSprite(s: Sprite; const distance: Vector2D);
var
  __skparam__s: __sklib_ptr;
  __skparam__distance: __sklib_vector_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__distance := __skadapter__to_sklib_vector_2d(distance);
  __sklib__move_sprite__sprite__vector_2d_ref(__skparam__s, __skparam__distance);
end;
procedure MoveSprite(s: Sprite; const distance: Vector2D; pct: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__distance: __sklib_vector_2d;
  __skparam__pct: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__distance := __skadapter__to_sklib_vector_2d(distance);
  __skparam__pct := __skadapter__to_sklib_float(pct);
  __sklib__move_sprite__sprite__vector_2d_ref__float(__skparam__s, __skparam__distance, __skparam__pct);
end;
procedure MoveSprite(s: Sprite; pct: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__pct: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__pct := __skadapter__to_sklib_float(pct);
  __sklib__move_sprite__sprite__float(__skparam__s, __skparam__pct);
end;
procedure MoveSpriteTo(s: Sprite; x: Double; y: Double);
var
  __skparam__s: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__move_sprite_to__sprite__double__double(__skparam__s, __skparam__x, __skparam__y);
end;
procedure SelectSpritePack(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__select_sprite_pack__string_ref(__skparam__name);
end;
function SpriteAddLayer(s: Sprite; newLayer: Bitmap; const layerName: String): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__new_layer: __sklib_ptr;
  __skparam__layer_name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__new_layer := __skadapter__to_sklib_bitmap(newLayer);
  __skparam__layer_name := __skadapter__to_sklib_string(layerName);
  __skreturn := __sklib__sprite_add_layer__sprite__bitmap__string_ref(__skparam__s, __skparam__new_layer, __skparam__layer_name);
  result := __skadapter__to_int(__skreturn);
end;
procedure SpriteAddToVelocity(s: Sprite; const value: Vector2D);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: __sklib_vector_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_vector_2d(value);
  __sklib__sprite_add_to_velocity__sprite__vector_2d_ref(__skparam__s, __skparam__value);
end;
procedure SpriteAddValue(s: Sprite; const name: String);
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__sprite_add_value__sprite__string_ref(__skparam__s, __skparam__name);
end;
procedure SpriteAddValue(s: Sprite; const name: String; initVal: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skparam__init_val: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__init_val := __skadapter__to_sklib_float(initVal);
  __sklib__sprite_add_value__sprite__string_ref__float(__skparam__s, __skparam__name, __skparam__init_val);
end;
function SpriteAnchorPoint(s: Sprite): Point2D;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_point_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_anchor_point__sprite(__skparam__s);
  result := __skadapter__to_point_2d(__skreturn);
end;
function SpriteAnchorPosition(s: Sprite): Point2D;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_point_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_anchor_position__sprite(__skparam__s);
  result := __skadapter__to_point_2d(__skreturn);
end;
function SpriteAnimationHasEnded(s: Sprite): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_animation_has_ended__sprite(__skparam__s);
  result := __skadapter__to_bool(__skreturn);
end;
function SpriteAnimationName(s: Sprite): String;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_animation_name__sprite(__skparam__s);
  result := __skadapter__to_string(__skreturn);
end;
function SpriteAt(s: Sprite; const pt: Point2D): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__sprite_at__sprite__point_2d_ref(__skparam__s, __skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
procedure SpriteBringLayerForward(s: Sprite; visibleLayer: Integer);
var
  __skparam__s: __sklib_ptr;
  __skparam__visible_layer: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__visible_layer := __skadapter__to_sklib_int(visibleLayer);
  __sklib__sprite_bring_layer_forward__sprite__int(__skparam__s, __skparam__visible_layer);
end;
procedure SpriteBringLayerToFront(s: Sprite; visibleLayer: Integer);
var
  __skparam__s: __sklib_ptr;
  __skparam__visible_layer: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__visible_layer := __skadapter__to_sklib_int(visibleLayer);
  __sklib__sprite_bring_layer_to_front__sprite__int(__skparam__s, __skparam__visible_layer);
end;
procedure SpriteCallOnEvent(s: Sprite; handler: SpriteEventHandler);
var
  __skparam__s: __sklib_ptr;
  __skparam__handler: SpriteEventHandler;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__handler := __skadapter__to_sklib_sprite_event_handler(handler);
  __sklib__sprite_call_on_event__sprite__sprite_event_handler_ptr(__skparam__s, __skparam__handler);
end;
function SpriteCircle(s: Sprite): Circle;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_circle;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_circle__sprite(__skparam__s);
  result := __skadapter__to_circle(__skreturn);
end;
function SpriteCollisionBitmap(s: Sprite): Bitmap;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_ptr;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_collision_bitmap__sprite(__skparam__s);
  result := __skadapter__to_bitmap(__skreturn);
end;
function SpriteCollisionCircle(s: Sprite): Circle;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_circle;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_collision_circle__sprite(__skparam__s);
  result := __skadapter__to_circle(__skreturn);
end;
function SpriteCollisionKind(s: Sprite): CollisionTestKind;
var
  __skparam__s: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_collision_kind__sprite(__skparam__s);
  result := __skadapter__to_collision_test_kind(__skreturn);
end;
function SpriteCollisionRectangle(s: Sprite): Rectangle;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_rectangle;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_collision_rectangle__sprite(__skparam__s);
  result := __skadapter__to_rectangle(__skreturn);
end;
function SpriteCurrentCell(s: Sprite): Integer;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_current_cell__sprite(__skparam__s);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteCurrentCellRectangle(s: Sprite): Rectangle;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_rectangle;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_current_cell_rectangle__sprite(__skparam__s);
  result := __skadapter__to_rectangle(__skreturn);
end;
function SpriteDx(s: Sprite): Single;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_dx__sprite(__skparam__s);
  result := __skadapter__to_float(__skreturn);
end;
function SpriteDy(s: Sprite): Single;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_dy__sprite(__skparam__s);
  result := __skadapter__to_float(__skreturn);
end;
function SpriteHasValue(s: Sprite; name: String): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_has_value__sprite__string(__skparam__s, __skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function SpriteHeading(s: Sprite): Single;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_heading__sprite(__skparam__s);
  result := __skadapter__to_float(__skreturn);
end;
function SpriteHeight(s: Sprite): Integer;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_height__sprite(__skparam__s);
  result := __skadapter__to_int(__skreturn);
end;
procedure SpriteHideLayer(s: Sprite; const name: String);
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__sprite_hide_layer__sprite__string_ref(__skparam__s, __skparam__name);
end;
procedure SpriteHideLayer(s: Sprite; id: Integer);
var
  __skparam__s: __sklib_ptr;
  __skparam__id: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__id := __skadapter__to_sklib_int(id);
  __sklib__sprite_hide_layer__sprite__int(__skparam__s, __skparam__id);
end;
function SpriteLayer(s: Sprite; const name: String): Bitmap;
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_layer__sprite__string_ref(__skparam__s, __skparam__name);
  result := __skadapter__to_bitmap(__skreturn);
end;
function SpriteLayer(s: Sprite; idx: Integer): Bitmap;
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
  __skreturn: __sklib_ptr;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skreturn := __sklib__sprite_layer__sprite__int(__skparam__s, __skparam__idx);
  result := __skadapter__to_bitmap(__skreturn);
end;
function SpriteLayerCircle(s: Sprite; const name: String): Circle;
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: __sklib_circle;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_layer_circle__sprite__string_ref(__skparam__s, __skparam__name);
  result := __skadapter__to_circle(__skreturn);
end;
function SpriteLayerCircle(s: Sprite; idx: Integer): Circle;
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
  __skreturn: __sklib_circle;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skreturn := __sklib__sprite_layer_circle__sprite__int(__skparam__s, __skparam__idx);
  result := __skadapter__to_circle(__skreturn);
end;
function SpriteLayerCount(s: Sprite): Integer;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_layer_count__sprite(__skparam__s);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteLayerHeight(s: Sprite; const name: String): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_layer_height__sprite__string_ref(__skparam__s, __skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteLayerHeight(s: Sprite; idx: Integer): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skreturn := __sklib__sprite_layer_height__sprite__int(__skparam__s, __skparam__idx);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteLayerIndex(s: Sprite; const name: String): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_layer_index__sprite__string_ref(__skparam__s, __skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteLayerName(s: Sprite; idx: Integer): String;
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
  __skreturn: __sklib_string;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skreturn := __sklib__sprite_layer_name__sprite__int(__skparam__s, __skparam__idx);
  result := __skadapter__to_string(__skreturn);
end;
function SpriteLayerOffset(s: Sprite; const name: String): Vector2D;
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_layer_offset__sprite__string_ref(__skparam__s, __skparam__name);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function SpriteLayerOffset(s: Sprite; idx: Integer): Vector2D;
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skreturn := __sklib__sprite_layer_offset__sprite__int(__skparam__s, __skparam__idx);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function SpriteLayerRectangle(s: Sprite; const name: String): Rectangle;
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: __sklib_rectangle;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_layer_rectangle__sprite__string_ref(__skparam__s, __skparam__name);
  result := __skadapter__to_rectangle(__skreturn);
end;
function SpriteLayerRectangle(s: Sprite; idx: Integer): Rectangle;
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
  __skreturn: __sklib_rectangle;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skreturn := __sklib__sprite_layer_rectangle__sprite__int(__skparam__s, __skparam__idx);
  result := __skadapter__to_rectangle(__skreturn);
end;
function SpriteLayerWidth(s: Sprite; const name: String): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_layer_width__sprite__string_ref(__skparam__s, __skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteLayerWidth(s: Sprite; idx: Integer): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skreturn := __sklib__sprite_layer_width__sprite__int(__skparam__s, __skparam__idx);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteLocationMatrix(s: Sprite): Matrix2D;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_matrix_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_location_matrix__sprite(__skparam__s);
  result := __skadapter__to_matrix_2d(__skreturn);
end;
function SpriteMass(s: Sprite): Single;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_mass__sprite(__skparam__s);
  result := __skadapter__to_float(__skreturn);
end;
function SpriteMoveFromAnchorPoint(s: Sprite): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_move_from_anchor_point__sprite(__skparam__s);
  result := __skadapter__to_bool(__skreturn);
end;
procedure SpriteMoveTo(s: Sprite; const pt: Point2D; takingSeconds: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skparam__taking_seconds: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__taking_seconds := __skadapter__to_sklib_float(takingSeconds);
  __sklib__sprite_move_to__sprite__point_2d_ref__float(__skparam__s, __skparam__pt, __skparam__taking_seconds);
end;
function SpriteName(s: Sprite): String;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_name__sprite(__skparam__s);
  result := __skadapter__to_string(__skreturn);
end;
function SpriteNamed(const name: String): Sprite;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_named__string_ref(__skparam__name);
  result := __skadapter__to_sprite(__skreturn);
end;
function SpriteOffscreen(s: Sprite): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_offscreen__sprite(__skparam__s);
  result := __skadapter__to_bool(__skreturn);
end;
function SpriteOnScreenAt(s: Sprite; const pt: Point2D): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__sprite_on_screen_at__sprite__point_2d_ref(__skparam__s, __skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function SpriteOnScreenAt(s: Sprite; x: Double; y: Double): Boolean;
var
  __skparam__s: __sklib_ptr;
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__sprite_on_screen_at__sprite__double__double(__skparam__s, __skparam__x, __skparam__y);
  result := __skadapter__to_bool(__skreturn);
end;
function SpritePosition(s: Sprite): Point2D;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_point_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_position__sprite(__skparam__s);
  result := __skadapter__to_point_2d(__skreturn);
end;
procedure SpriteReplayAnimation(s: Sprite);
var
  __skparam__s: __sklib_ptr;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __sklib__sprite_replay_animation__sprite(__skparam__s);
end;
procedure SpriteReplayAnimation(s: Sprite; withSound: Boolean);
var
  __skparam__s: __sklib_ptr;
  __skparam__with_sound: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__sprite_replay_animation__sprite__bool(__skparam__s, __skparam__with_sound);
end;
function SpriteRotation(s: Sprite): Single;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_rotation__sprite(__skparam__s);
  result := __skadapter__to_float(__skreturn);
end;
function SpriteScale(s: Sprite): Single;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_scale__sprite(__skparam__s);
  result := __skadapter__to_float(__skreturn);
end;
function SpriteScreenRectangle(s: Sprite): Rectangle;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_rectangle;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_screen_rectangle__sprite(__skparam__s);
  result := __skadapter__to_rectangle(__skreturn);
end;
procedure SpriteSendLayerBackward(s: Sprite; visibleLayer: Integer);
var
  __skparam__s: __sklib_ptr;
  __skparam__visible_layer: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__visible_layer := __skadapter__to_sklib_int(visibleLayer);
  __sklib__sprite_send_layer_backward__sprite__int(__skparam__s, __skparam__visible_layer);
end;
procedure SpriteSendLayerToBack(s: Sprite; visibleLayer: Integer);
var
  __skparam__s: __sklib_ptr;
  __skparam__visible_layer: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__visible_layer := __skadapter__to_sklib_int(visibleLayer);
  __sklib__sprite_send_layer_to_back__sprite__int(__skparam__s, __skparam__visible_layer);
end;
procedure SpriteSetAnchorPoint(s: Sprite; const pt: Point2D);
var
  __skparam__s: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __sklib__sprite_set_anchor_point__sprite__point_2d_ref(__skparam__s, __skparam__pt);
end;
procedure SpriteSetCollisionBitmap(s: Sprite; bmp: Bitmap);
var
  __skparam__s: __sklib_ptr;
  __skparam__bmp: __sklib_ptr;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __sklib__sprite_set_collision_bitmap__sprite__bitmap(__skparam__s, __skparam__bmp);
end;
procedure SpriteSetCollisionKind(s: Sprite; value: CollisionTestKind);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_collision_test_kind(value);
  __sklib__sprite_set_collision_kind__sprite__collision_test_kind(__skparam__s, __skparam__value);
end;
procedure SpriteSetDx(s: Sprite; value: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_float(value);
  __sklib__sprite_set_dx__sprite__float(__skparam__s, __skparam__value);
end;
procedure SpriteSetDy(s: Sprite; value: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_float(value);
  __sklib__sprite_set_dy__sprite__float(__skparam__s, __skparam__value);
end;
procedure SpriteSetHeading(s: Sprite; value: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_float(value);
  __sklib__sprite_set_heading__sprite__float(__skparam__s, __skparam__value);
end;
procedure SpriteSetLayerOffset(s: Sprite; const name: String; const value: Vector2D);
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skparam__value: __sklib_vector_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__value := __skadapter__to_sklib_vector_2d(value);
  __sklib__sprite_set_layer_offset__sprite__string_ref__vector_2d_ref(__skparam__s, __skparam__name, __skparam__value);
end;
procedure SpriteSetLayerOffset(s: Sprite; idx: Integer; const value: Vector2D);
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
  __skparam__value: __sklib_vector_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skparam__value := __skadapter__to_sklib_vector_2d(value);
  __sklib__sprite_set_layer_offset__sprite__int__vector_2d_ref(__skparam__s, __skparam__idx, __skparam__value);
end;
procedure SpriteSetMass(s: Sprite; value: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_float(value);
  __sklib__sprite_set_mass__sprite__float(__skparam__s, __skparam__value);
end;
procedure SpriteSetMoveFromAnchorPoint(s: Sprite; value: Boolean);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_bool(value);
  __sklib__sprite_set_move_from_anchor_point__sprite__bool(__skparam__s, __skparam__value);
end;
procedure SpriteSetPosition(s: Sprite; const value: Point2D);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: __sklib_point_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_point_2d(value);
  __sklib__sprite_set_position__sprite__point_2d_ref(__skparam__s, __skparam__value);
end;
procedure SpriteSetRotation(s: Sprite; value: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_float(value);
  __sklib__sprite_set_rotation__sprite__float(__skparam__s, __skparam__value);
end;
procedure SpriteSetScale(s: Sprite; value: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_float(value);
  __sklib__sprite_set_scale__sprite__float(__skparam__s, __skparam__value);
end;
procedure SpriteSetSpeed(s: Sprite; value: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_float(value);
  __sklib__sprite_set_speed__sprite__float(__skparam__s, __skparam__value);
end;
procedure SpriteSetValue(s: Sprite; const name: String; val: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skparam__val: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__val := __skadapter__to_sklib_float(val);
  __sklib__sprite_set_value__sprite__string_ref__float(__skparam__s, __skparam__name, __skparam__val);
end;
procedure SpriteSetVelocity(s: Sprite; const value: Vector2D);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: __sklib_vector_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_vector_2d(value);
  __sklib__sprite_set_velocity__sprite__vector_2d_ref(__skparam__s, __skparam__value);
end;
procedure SpriteSetX(s: Sprite; value: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_float(value);
  __sklib__sprite_set_x__sprite__float(__skparam__s, __skparam__value);
end;
procedure SpriteSetY(s: Sprite; value: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__value: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__value := __skadapter__to_sklib_float(value);
  __sklib__sprite_set_y__sprite__float(__skparam__s, __skparam__value);
end;
function SpriteShowLayer(s: Sprite; const name: String): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_show_layer__sprite__string_ref(__skparam__s, __skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteShowLayer(s: Sprite; id: Integer): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__id: Integer;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__id := __skadapter__to_sklib_int(id);
  __skreturn := __sklib__sprite_show_layer__sprite__int(__skparam__s, __skparam__id);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteSpeed(s: Sprite): Single;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_speed__sprite(__skparam__s);
  result := __skadapter__to_float(__skreturn);
end;
procedure SpriteStartAnimation(s: Sprite; const named: String);
var
  __skparam__s: __sklib_ptr;
  __skparam__named: __sklib_string;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__named := __skadapter__to_sklib_string(named);
  __sklib__sprite_start_animation__sprite__string_ref(__skparam__s, __skparam__named);
end;
procedure SpriteStartAnimation(s: Sprite; const named: String; withSound: Boolean);
var
  __skparam__s: __sklib_ptr;
  __skparam__named: __sklib_string;
  __skparam__with_sound: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__named := __skadapter__to_sklib_string(named);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__sprite_start_animation__sprite__string_ref__bool(__skparam__s, __skparam__named, __skparam__with_sound);
end;
procedure SpriteStartAnimation(s: Sprite; idx: Integer);
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __sklib__sprite_start_animation__sprite__int(__skparam__s, __skparam__idx);
end;
procedure SpriteStartAnimation(s: Sprite; idx: Integer; withSound: Boolean);
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
  __skparam__with_sound: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__sprite_start_animation__sprite__int__bool(__skparam__s, __skparam__idx, __skparam__with_sound);
end;
procedure SpriteStopCallingOnEvent(s: Sprite; handler: SpriteEventHandler);
var
  __skparam__s: __sklib_ptr;
  __skparam__handler: SpriteEventHandler;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__handler := __skadapter__to_sklib_sprite_event_handler(handler);
  __sklib__sprite_stop_calling_on_event__sprite__sprite_event_handler_ptr(__skparam__s, __skparam__handler);
end;
procedure SpriteToggleLayerVisible(s: Sprite; const name: String);
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__sprite_toggle_layer_visible__sprite__string_ref(__skparam__s, __skparam__name);
end;
procedure SpriteToggleLayerVisible(s: Sprite; id: Integer);
var
  __skparam__s: __sklib_ptr;
  __skparam__id: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__id := __skadapter__to_sklib_int(id);
  __sklib__sprite_toggle_layer_visible__sprite__int(__skparam__s, __skparam__id);
end;
function SpriteValue(s: Sprite; const name: String): Single;
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_value__sprite__string_ref(__skparam__s, __skparam__name);
  result := __skadapter__to_float(__skreturn);
end;
function SpriteValueCount(s: Sprite): Integer;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_value_count__sprite(__skparam__s);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteVelocity(s: Sprite): Vector2D;
var
  __skparam__s: __sklib_ptr;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_velocity__sprite(__skparam__s);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function SpriteVisibleIndexOfLayer(s: Sprite; const name: String): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__sprite_visible_index_of_layer__sprite__string_ref(__skparam__s, __skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteVisibleIndexOfLayer(s: Sprite; id: Integer): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__id: Integer;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__id := __skadapter__to_sklib_int(id);
  __skreturn := __sklib__sprite_visible_index_of_layer__sprite__int(__skparam__s, __skparam__id);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteVisibleLayer(s: Sprite; idx: Integer): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skreturn := __sklib__sprite_visible_layer__sprite__int(__skparam__s, __skparam__idx);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteVisibleLayerCount(s: Sprite): Integer;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_visible_layer_count__sprite(__skparam__s);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteVisibleLayerId(s: Sprite; idx: Integer): Integer;
var
  __skparam__s: __sklib_ptr;
  __skparam__idx: Integer;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__idx := __skadapter__to_sklib_int(idx);
  __skreturn := __sklib__sprite_visible_layer_id__sprite__int(__skparam__s, __skparam__idx);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteWidth(s: Sprite): Integer;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_width__sprite(__skparam__s);
  result := __skadapter__to_int(__skreturn);
end;
function SpriteX(s: Sprite): Single;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_x__sprite(__skparam__s);
  result := __skadapter__to_float(__skreturn);
end;
function SpriteY(s: Sprite): Single;
var
  __skparam__s: __sklib_ptr;
  __skreturn: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skreturn := __sklib__sprite_y__sprite(__skparam__s);
  result := __skadapter__to_float(__skreturn);
end;
procedure StopCallingOnSpriteEvent(handler: SpriteEventHandler);
var
  __skparam__handler: SpriteEventHandler;
begin
  __skparam__handler := __skadapter__to_sklib_sprite_event_handler(handler);
  __sklib__stop_calling_on_sprite_event__sprite_event_handler_ptr(__skparam__handler);
end;
procedure UpdateAllSprites();
begin
  __sklib__update_all_sprites();
end;
procedure UpdateAllSprites(pct: Single);
var
  __skparam__pct: Single;
begin
  __skparam__pct := __skadapter__to_sklib_float(pct);
  __sklib__update_all_sprites__float(__skparam__pct);
end;
procedure UpdateSprite(s: Sprite);
var
  __skparam__s: __sklib_ptr;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __sklib__update_sprite__sprite(__skparam__s);
end;
procedure UpdateSprite(s: Sprite; withSound: Boolean);
var
  __skparam__s: __sklib_ptr;
  __skparam__with_sound: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__update_sprite__sprite__bool(__skparam__s, __skparam__with_sound);
end;
procedure UpdateSprite(s: Sprite; pct: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__pct: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__pct := __skadapter__to_sklib_float(pct);
  __sklib__update_sprite__sprite__float(__skparam__s, __skparam__pct);
end;
procedure UpdateSprite(s: Sprite; pct: Single; withSound: Boolean);
var
  __skparam__s: __sklib_ptr;
  __skparam__pct: Single;
  __skparam__with_sound: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__pct := __skadapter__to_sklib_float(pct);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__update_sprite__sprite__float__bool(__skparam__s, __skparam__pct, __skparam__with_sound);
end;
procedure UpdateSpriteAnimation(s: Sprite);
var
  __skparam__s: __sklib_ptr;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __sklib__update_sprite_animation__sprite(__skparam__s);
end;
procedure UpdateSpriteAnimation(s: Sprite; withSound: Boolean);
var
  __skparam__s: __sklib_ptr;
  __skparam__with_sound: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__update_sprite_animation__sprite__bool(__skparam__s, __skparam__with_sound);
end;
procedure UpdateSpriteAnimation(s: Sprite; pct: Single);
var
  __skparam__s: __sklib_ptr;
  __skparam__pct: Single;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__pct := __skadapter__to_sklib_float(pct);
  __sklib__update_sprite_animation__sprite__float(__skparam__s, __skparam__pct);
end;
procedure UpdateSpriteAnimation(s: Sprite; pct: Single; withSound: Boolean);
var
  __skparam__s: __sklib_ptr;
  __skparam__pct: Single;
  __skparam__with_sound: LongInt;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__pct := __skadapter__to_sklib_float(pct);
  __skparam__with_sound := __skadapter__to_sklib_bool(withSound);
  __sklib__update_sprite_animation__sprite__float__bool(__skparam__s, __skparam__pct, __skparam__with_sound);
end;
function VectorFromCenterSpriteToPoint(s: Sprite; const pt: Point2D): Vector2D;
var
  __skparam__s: __sklib_ptr;
  __skparam__pt: __sklib_point_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__s := __skadapter__to_sklib_sprite(s);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__vector_from_center_sprite_to_point__sprite__point_2d_ref(__skparam__s, __skparam__pt);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorFromTo(s1: Sprite; s2: Sprite): Vector2D;
var
  __skparam__s1: __sklib_ptr;
  __skparam__s2: __sklib_ptr;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__s1 := __skadapter__to_sklib_sprite(s1);
  __skparam__s2 := __skadapter__to_sklib_sprite(s2);
  __skreturn := __sklib__vector_from_to__sprite__sprite(__skparam__s1, __skparam__s2);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function ReadChar(): Char;
var
  __skreturn: Char;
begin
  __skreturn := __sklib__read_char();
  result := __skadapter__to_char(__skreturn);
end;
function ReadLine(): String;
var
  __skreturn: __sklib_string;
begin
  __skreturn := __sklib__read_line();
  result := __skadapter__to_string(__skreturn);
end;
function TerminalHasInput(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__terminal_has_input();
  result := __skadapter__to_bool(__skreturn);
end;
procedure Write(data: Char);
var
  __skparam__data: Char;
begin
  __skparam__data := __skadapter__to_sklib_char(data);
  __sklib__write__char(__skparam__data);
end;
procedure Write(data: Double);
var
  __skparam__data: Double;
begin
  __skparam__data := __skadapter__to_sklib_double(data);
  __sklib__write__double(__skparam__data);
end;
procedure Write(data: Integer);
var
  __skparam__data: Integer;
begin
  __skparam__data := __skadapter__to_sklib_int(data);
  __sklib__write__int(__skparam__data);
end;
procedure Write(text: String);
var
  __skparam__text: __sklib_string;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __sklib__write__string(__skparam__text);
end;
procedure WriteLine(data: Char);
var
  __skparam__data: Char;
begin
  __skparam__data := __skadapter__to_sklib_char(data);
  __sklib__write_line__char(__skparam__data);
end;
procedure WriteLine();
begin
  __sklib__write_line();
end;
procedure WriteLine(data: Double);
var
  __skparam__data: Double;
begin
  __skparam__data := __skadapter__to_sklib_double(data);
  __sklib__write_line__double(__skparam__data);
end;
procedure WriteLine(data: Integer);
var
  __skparam__data: Integer;
begin
  __skparam__data := __skadapter__to_sklib_int(data);
  __sklib__write_line__int(__skparam__data);
end;
procedure WriteLine(line: String);
var
  __skparam__line: __sklib_string;
begin
  __skparam__line := __skadapter__to_sklib_string(line);
  __sklib__write_line__string(__skparam__line);
end;
procedure DrawText(const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double);
var
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_string;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_string(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_text__string_ref__color_ref__string_ref__int__double__double(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
end;
procedure DrawText(const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
var
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_string;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_string(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_text__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawText(const text: String; const clr: Color; x: Double; y: Double);
var
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_text__string_ref__color_ref__double__double(__skparam__text, __skparam__clr, __skparam__x, __skparam__y);
end;
procedure DrawText(const text: String; const clr: Color; x: Double; y: Double; const opts: DrawingOptions);
var
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_text__string_ref__color_ref__double__double__drawing_options_ref(__skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawText(const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double);
var
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_ptr;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_text__string_ref__color_ref__font__int__double__double(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
end;
procedure DrawText(const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
var
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_ptr;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_text__string_ref__color_ref__font__int__double__double__drawing_options_ref(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_string;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_string(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
end;
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_string;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_string(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; x: Double; y: Double);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__x, __skparam__y);
end;
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; x: Double; y: Double; const opts: DrawingOptions);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double__drawing_options_ref(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_ptr;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
end;
procedure DrawTextOnBitmap(bmp: Bitmap; const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
var
  __skparam__bmp: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_ptr;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double__drawing_options_ref(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double);
var
  __skparam__wnd: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_string;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_string(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
end;
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; const fnt: String; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
var
  __skparam__wnd: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_string;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_string(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; x: Double; y: Double);
var
  __skparam__wnd: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_text_on_window__window__string_ref__color_ref__double__double(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__x, __skparam__y);
end;
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; x: Double; y: Double; const opts: DrawingOptions);
var
  __skparam__wnd: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_text_on_window__window__string_ref__color_ref__double__double__drawing_options_ref(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
end;
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double);
var
  __skparam__wnd: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_ptr;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
end;
procedure DrawTextOnWindow(wnd: Window; const text: String; const clr: Color; fnt: Font; fontSize: Integer; x: Double; y: Double; const opts: DrawingOptions);
var
  __skparam__wnd: __sklib_ptr;
  __skparam__text: __sklib_string;
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_ptr;
  __skparam__font_size: Integer;
  __skparam__x: Double;
  __skparam__y: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double__drawing_options_ref(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
end;
function FontHasSize(const name: String; fontSize: Integer): Boolean;
var
  __skparam__name: __sklib_string;
  __skparam__font_size: Integer;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skreturn := __sklib__font_has_size__string_ref__int(__skparam__name, __skparam__font_size);
  result := __skadapter__to_bool(__skreturn);
end;
function FontHasSize(fnt: Font; fontSize: Integer): Boolean;
var
  __skparam__fnt: __sklib_ptr;
  __skparam__font_size: Integer;
  __skreturn: LongInt;
begin
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skreturn := __sklib__font_has_size__font__int(__skparam__fnt, __skparam__font_size);
  result := __skadapter__to_bool(__skreturn);
end;
procedure FontLoadSize(const name: String; fontSize: Integer);
var
  __skparam__name: __sklib_string;
  __skparam__font_size: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __sklib__font_load_size__string_ref__int(__skparam__name, __skparam__font_size);
end;
procedure FontLoadSize(fnt: Font; fontSize: Integer);
var
  __skparam__fnt: __sklib_ptr;
  __skparam__font_size: Integer;
begin
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __sklib__font_load_size__font__int(__skparam__fnt, __skparam__font_size);
end;
function FontNamed(name: String): Font;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__font_named__string(__skparam__name);
  result := __skadapter__to_font(__skreturn);
end;
procedure FreeAllFonts();
begin
  __sklib__free_all_fonts();
end;
procedure FreeFont(fnt: Font);
var
  __skparam__fnt: __sklib_ptr;
begin
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __sklib__free_font__font(__skparam__fnt);
end;
function GetFontStyle(const name: String): FontStyle;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__get_font_style__string_ref(__skparam__name);
  result := __skadapter__to_font_style(__skreturn);
end;
function GetFontStyle(fnt: Font): FontStyle;
var
  __skparam__fnt: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skreturn := __sklib__get_font_style__font(__skparam__fnt);
  result := __skadapter__to_font_style(__skreturn);
end;
function GetSystemFont(): Font;
var
  __skreturn: __sklib_ptr;
begin
  __skreturn := __sklib__get_system_font();
  result := __skadapter__to_font(__skreturn);
end;
function HasFont(fnt: Font): Boolean;
var
  __skparam__fnt: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skreturn := __sklib__has_font__font(__skparam__fnt);
  result := __skadapter__to_bool(__skreturn);
end;
function HasFont(name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_font__string(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function LoadFont(const name: String; const filename: String): Font;
var
  __skparam__name: __sklib_string;
  __skparam__filename: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __skreturn := __sklib__load_font__string_ref__string_ref(__skparam__name, __skparam__filename);
  result := __skadapter__to_font(__skreturn);
end;
procedure SetFontStyle(const name: String; style: FontStyle);
var
  __skparam__name: __sklib_string;
  __skparam__style: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__style := __skadapter__to_sklib_font_style(style);
  __sklib__set_font_style__string_ref__font_style(__skparam__name, __skparam__style);
end;
procedure SetFontStyle(fnt: Font; style: FontStyle);
var
  __skparam__fnt: __sklib_ptr;
  __skparam__style: LongInt;
begin
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__style := __skadapter__to_sklib_font_style(style);
  __sklib__set_font_style__font__font_style(__skparam__fnt, __skparam__style);
end;
function TextHeight(const text: String; const fnt: String; fontSize: Integer): Integer;
var
  __skparam__text: __sklib_string;
  __skparam__fnt: __sklib_string;
  __skparam__font_size: Integer;
  __skreturn: Integer;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__fnt := __skadapter__to_sklib_string(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skreturn := __sklib__text_height__string_ref__string_ref__int(__skparam__text, __skparam__fnt, __skparam__font_size);
  result := __skadapter__to_int(__skreturn);
end;
function TextHeight(const text: String; fnt: Font; fontSize: Integer): Integer;
var
  __skparam__text: __sklib_string;
  __skparam__fnt: __sklib_ptr;
  __skparam__font_size: Integer;
  __skreturn: Integer;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skreturn := __sklib__text_height__string_ref__font__int(__skparam__text, __skparam__fnt, __skparam__font_size);
  result := __skadapter__to_int(__skreturn);
end;
function TextWidth(const text: String; const fnt: String; fontSize: Integer): Integer;
var
  __skparam__text: __sklib_string;
  __skparam__fnt: __sklib_string;
  __skparam__font_size: Integer;
  __skreturn: Integer;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__fnt := __skadapter__to_sklib_string(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skreturn := __sklib__text_width__string_ref__string_ref__int(__skparam__text, __skparam__fnt, __skparam__font_size);
  result := __skadapter__to_int(__skreturn);
end;
function TextWidth(const text: String; fnt: Font; fontSize: Integer): Integer;
var
  __skparam__text: __sklib_string;
  __skparam__fnt: __sklib_ptr;
  __skparam__font_size: Integer;
  __skreturn: Integer;
begin
  __skparam__text := __skadapter__to_sklib_string(text);
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skreturn := __sklib__text_width__string_ref__font__int(__skparam__text, __skparam__fnt, __skparam__font_size);
  result := __skadapter__to_int(__skreturn);
end;
procedure DrawCollectedText(clr: Color; fnt: Font; fontSize: Integer; const opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__fnt: __sklib_ptr;
  __skparam__font_size: Integer;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__fnt := __skadapter__to_sklib_font(fnt);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_collected_text__color__font__int__drawing_options_ref(__skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__opts);
end;
procedure EndReadingText();
begin
  __sklib__end_reading_text();
end;
procedure EndReadingText(wind: Window);
var
  __skparam__wind: __sklib_ptr;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __sklib__end_reading_text__window(__skparam__wind);
end;
function ReadingText(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__reading_text();
  result := __skadapter__to_bool(__skreturn);
end;
function ReadingText(wind: Window): Boolean;
var
  __skparam__wind: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skreturn := __sklib__reading_text__window(__skparam__wind);
  result := __skadapter__to_bool(__skreturn);
end;
procedure StartReadingText(rect: Rectangle);
var
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__start_reading_text__rectangle(__skparam__rect);
end;
procedure StartReadingText(rect: Rectangle; initialText: String);
var
  __skparam__rect: __sklib_rectangle;
  __skparam__initial_text: __sklib_string;
begin
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__initial_text := __skadapter__to_sklib_string(initialText);
  __sklib__start_reading_text__rectangle__string(__skparam__rect, __skparam__initial_text);
end;
procedure StartReadingText(wind: Window; rect: Rectangle);
var
  __skparam__wind: __sklib_ptr;
  __skparam__rect: __sklib_rectangle;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __sklib__start_reading_text__window__rectangle(__skparam__wind, __skparam__rect);
end;
procedure StartReadingText(wind: Window; rect: Rectangle; initialText: String);
var
  __skparam__wind: __sklib_ptr;
  __skparam__rect: __sklib_rectangle;
  __skparam__initial_text: __sklib_string;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__initial_text := __skadapter__to_sklib_string(initialText);
  __sklib__start_reading_text__window__rectangle__string(__skparam__wind, __skparam__rect, __skparam__initial_text);
end;
function TextEntryCancelled(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__text_entry_cancelled();
  result := __skadapter__to_bool(__skreturn);
end;
function TextEntryCancelled(wind: Window): Boolean;
var
  __skparam__wind: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skreturn := __sklib__text_entry_cancelled__window(__skparam__wind);
  result := __skadapter__to_bool(__skreturn);
end;
function TextInput(): String;
var
  __skreturn: __sklib_string;
begin
  __skreturn := __sklib__text_input();
  result := __skadapter__to_string(__skreturn);
end;
function TextInput(wind: Window): String;
var
  __skparam__wind: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skreturn := __sklib__text_input__window(__skparam__wind);
  result := __skadapter__to_string(__skreturn);
end;
function CreateTimer(name: String): Timer;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__create_timer__string(__skparam__name);
  result := __skadapter__to_timer(__skreturn);
end;
procedure FreeAllTimers();
begin
  __sklib__free_all_timers();
end;
procedure FreeTimer(toFree: Timer);
var
  __skparam__to_free: __sklib_ptr;
begin
  __skparam__to_free := __skadapter__to_sklib_timer(toFree);
  __sklib__free_timer__timer(__skparam__to_free);
end;
function HasTimer(name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__has_timer__string(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
procedure PauseTimer(name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__pause_timer__string(__skparam__name);
end;
procedure PauseTimer(toPause: Timer);
var
  __skparam__to_pause: __sklib_ptr;
begin
  __skparam__to_pause := __skadapter__to_sklib_timer(toPause);
  __sklib__pause_timer__timer(__skparam__to_pause);
end;
procedure ResetTimer(name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__reset_timer__string(__skparam__name);
end;
procedure ResetTimer(tmr: Timer);
var
  __skparam__tmr: __sklib_ptr;
begin
  __skparam__tmr := __skadapter__to_sklib_timer(tmr);
  __sklib__reset_timer__timer(__skparam__tmr);
end;
procedure ResumeTimer(name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__resume_timer__string(__skparam__name);
end;
procedure ResumeTimer(toResume: Timer);
var
  __skparam__to_resume: __sklib_ptr;
begin
  __skparam__to_resume := __skadapter__to_sklib_timer(toResume);
  __sklib__resume_timer__timer(__skparam__to_resume);
end;
procedure StartTimer(name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__start_timer__string(__skparam__name);
end;
procedure StartTimer(toStart: Timer);
var
  __skparam__to_start: __sklib_ptr;
begin
  __skparam__to_start := __skadapter__to_sklib_timer(toStart);
  __sklib__start_timer__timer(__skparam__to_start);
end;
procedure StopTimer(name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__stop_timer__string(__skparam__name);
end;
procedure StopTimer(toStop: Timer);
var
  __skparam__to_stop: __sklib_ptr;
begin
  __skparam__to_stop := __skadapter__to_sklib_timer(toStop);
  __sklib__stop_timer__timer(__skparam__to_stop);
end;
function TimerNamed(name: String): Timer;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__timer_named__string(__skparam__name);
  result := __skadapter__to_timer(__skreturn);
end;
function TimerPaused(name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__timer_paused__string(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function TimerPaused(toGet: Timer): Boolean;
var
  __skparam__to_get: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__to_get := __skadapter__to_sklib_timer(toGet);
  __skreturn := __sklib__timer_paused__timer(__skparam__to_get);
  result := __skadapter__to_bool(__skreturn);
end;
function TimerStarted(name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__timer_started__string(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function TimerStarted(toGet: Timer): Boolean;
var
  __skparam__to_get: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__to_get := __skadapter__to_sklib_timer(toGet);
  __skreturn := __sklib__timer_started__timer(__skparam__to_get);
  result := __skadapter__to_bool(__skreturn);
end;
function TimerTicks(name: String): Cardinal;
var
  __skparam__name: __sklib_string;
  __skreturn: Cardinal;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__timer_ticks__string(__skparam__name);
  result := __skadapter__to_unsigned_int(__skreturn);
end;
function TimerTicks(toGet: Timer): Cardinal;
var
  __skparam__to_get: __sklib_ptr;
  __skreturn: Cardinal;
begin
  __skparam__to_get := __skadapter__to_sklib_timer(toGet);
  __skreturn := __sklib__timer_ticks__timer(__skparam__to_get);
  result := __skadapter__to_unsigned_int(__skreturn);
end;
procedure DrawTriangle(clr: Color; const tri: Triangle);
var
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __sklib__draw_triangle__color__triangle_ref(__skparam__clr, __skparam__tri);
end;
procedure DrawTriangle(clr: Color; const tri: Triangle; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_triangle__color__triangle_ref__drawing_options(__skparam__clr, __skparam__tri, __skparam__opts);
end;
procedure DrawTriangle(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
var
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __sklib__draw_triangle__color__double__double__double__double__double__double(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
end;
procedure DrawTriangle(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_triangle__color__double__double__double__double__double__double__drawing_options(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
end;
procedure DrawTriangleOnBitmap(destination: Bitmap; clr: Color; const tri: Triangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri);
end;
procedure DrawTriangleOnBitmap(destination: Bitmap; clr: Color; const tri: Triangle; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
end;
procedure DrawTriangleOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
end;
procedure DrawTriangleOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
end;
procedure DrawTriangleOnWindow(destination: Window; clr: Color; const tri: Triangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __sklib__draw_triangle_on_window__window__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri);
end;
procedure DrawTriangleOnWindow(destination: Window; clr: Color; const tri: Triangle; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_triangle_on_window__window__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
end;
procedure DrawTriangleOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
end;
procedure DrawTriangleOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
end;
procedure FillTriangle(clr: Color; const tri: Triangle);
var
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __sklib__fill_triangle__color__triangle_ref(__skparam__clr, __skparam__tri);
end;
procedure FillTriangle(clr: Color; const tri: Triangle; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_triangle__color__triangle_ref__drawing_options(__skparam__clr, __skparam__tri, __skparam__opts);
end;
procedure FillTriangle(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
var
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __sklib__fill_triangle__color__double__double__double__double__double__double(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
end;
procedure FillTriangle(clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
var
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_triangle__color__double__double__double__double__double__double__drawing_options(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
end;
procedure FillTriangleOnBitmap(destination: Bitmap; clr: Color; const tri: Triangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri);
end;
procedure FillTriangleOnBitmap(destination: Bitmap; clr: Color; const tri: Triangle; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
end;
procedure FillTriangleOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
end;
procedure FillTriangleOnBitmap(destination: Bitmap; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_bitmap(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
end;
procedure FillTriangleOnWindow(destination: Window; clr: Color; const tri: Triangle);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __sklib__fill_triangle_on_window__window__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri);
end;
procedure FillTriangleOnWindow(destination: Window; clr: Color; const tri: Triangle; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__tri: __sklib_triangle;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_triangle_on_window__window__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
end;
procedure FillTriangleOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
end;
procedure FillTriangleOnWindow(destination: Window; clr: Color; x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double; opts: DrawingOptions);
var
  __skparam__destination: __sklib_ptr;
  __skparam__clr: __sklib_color;
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
  __skparam__opts: __sklib_drawing_options;
begin
  __skparam__destination := __skadapter__to_sklib_window(destination);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __skparam__opts := __skadapter__to_sklib_drawing_options(opts);
  __sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
end;
function TriangleBarycenter(const tri: Triangle): Point2D;
var
  __skparam__tri: __sklib_triangle;
  __skreturn: __sklib_point_2d;
begin
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skreturn := __sklib__triangle_barycenter__triangle_ref(__skparam__tri);
  result := __skadapter__to_point_2d(__skreturn);
end;
function TriangleFrom(const p1: Point2D; const p2: Point2D; const p3: Point2D): Triangle;
var
  __skparam__p1: __sklib_point_2d;
  __skparam__p2: __sklib_point_2d;
  __skparam__p3: __sklib_point_2d;
  __skreturn: __sklib_triangle;
begin
  __skparam__p1 := __skadapter__to_sklib_point_2d(p1);
  __skparam__p2 := __skadapter__to_sklib_point_2d(p2);
  __skparam__p3 := __skadapter__to_sklib_point_2d(p3);
  __skreturn := __sklib__triangle_from__point_2d_ref__point_2d_ref__point_2d_ref(__skparam__p1, __skparam__p2, __skparam__p3);
  result := __skadapter__to_triangle(__skreturn);
end;
function TriangleFrom(x1: Double; y1: Double; x2: Double; y2: Double; x3: Double; y3: Double): Triangle;
var
  __skparam__x1: Double;
  __skparam__y1: Double;
  __skparam__x2: Double;
  __skparam__y2: Double;
  __skparam__x3: Double;
  __skparam__y3: Double;
  __skreturn: __sklib_triangle;
begin
  __skparam__x1 := __skadapter__to_sklib_double(x1);
  __skparam__y1 := __skadapter__to_sklib_double(y1);
  __skparam__x2 := __skadapter__to_sklib_double(x2);
  __skparam__y2 := __skadapter__to_sklib_double(y2);
  __skparam__x3 := __skadapter__to_sklib_double(x3);
  __skparam__y3 := __skadapter__to_sklib_double(y3);
  __skreturn := __sklib__triangle_from__double__double__double__double__double__double(__skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
  result := __skadapter__to_triangle(__skreturn);
end;
function TriangleRectangleIntersect(const tri: Triangle; const rect: Rectangle): Boolean;
var
  __skparam__tri: __sklib_triangle;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__triangle_rectangle_intersect__triangle_ref__rectangle_ref(__skparam__tri, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function TriangleToString(const tri: Triangle): String;
var
  __skparam__tri: __sklib_triangle;
  __skreturn: __sklib_string;
begin
  __skparam__tri := __skadapter__to_sklib_triangle(tri);
  __skreturn := __sklib__triangle_to_string__triangle_ref(__skparam__tri);
  result := __skadapter__to_string(__skreturn);
end;
function TrianglesIntersect(const t1: Triangle; const t2: Triangle): Boolean;
var
  __skparam__t1: __sklib_triangle;
  __skparam__t2: __sklib_triangle;
  __skreturn: LongInt;
begin
  __skparam__t1 := __skadapter__to_sklib_triangle(t1);
  __skparam__t2 := __skadapter__to_sklib_triangle(t2);
  __skreturn := __sklib__triangles_intersect__triangle_ref__triangle_ref(__skparam__t1, __skparam__t2);
  result := __skadapter__to_bool(__skreturn);
end;
function CurrentTicks(): Cardinal;
var
  __skreturn: Cardinal;
begin
  __skreturn := __sklib__current_ticks();
  result := __skadapter__to_unsigned_int(__skreturn);
end;
procedure Delay(milliseconds: Integer);
var
  __skparam__milliseconds: Integer;
begin
  __skparam__milliseconds := __skadapter__to_sklib_int(milliseconds);
  __sklib__delay__int(__skparam__milliseconds);
end;
procedure DisplayDialog(const title: String; const msg: String; outputFont: Font; fontSize: Integer);
var
  __skparam__title: __sklib_string;
  __skparam__msg: __sklib_string;
  __skparam__output_font: __sklib_ptr;
  __skparam__font_size: Integer;
begin
  __skparam__title := __skadapter__to_sklib_string(title);
  __skparam__msg := __skadapter__to_sklib_string(msg);
  __skparam__output_font := __skadapter__to_sklib_font(outputFont);
  __skparam__font_size := __skadapter__to_sklib_int(fontSize);
  __sklib__display_dialog__string_ref__string_ref__font__int(__skparam__title, __skparam__msg, __skparam__output_font, __skparam__font_size);
end;
function FileAsString(filename: String; kind: ResourceKind): String;
var
  __skparam__filename: __sklib_string;
  __skparam__kind: LongInt;
  __skreturn: __sklib_string;
begin
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __skparam__kind := __skadapter__to_sklib_resource_kind(kind);
  __skreturn := __sklib__file_as_string__string__resource_kind(__skparam__filename, __skparam__kind);
  result := __skadapter__to_string(__skreturn);
end;
function AngleBetween(const v1: Vector2D; const v2: Vector2D): Double;
var
  __skparam__v1: __sklib_vector_2d;
  __skparam__v2: __sklib_vector_2d;
  __skreturn: Double;
begin
  __skparam__v1 := __skadapter__to_sklib_vector_2d(v1);
  __skparam__v2 := __skadapter__to_sklib_vector_2d(v2);
  __skreturn := __sklib__angle_between__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2);
  result := __skadapter__to_double(__skreturn);
end;
function DotProduct(const v1: Vector2D; const v2: Vector2D): Double;
var
  __skparam__v1: __sklib_vector_2d;
  __skparam__v2: __sklib_vector_2d;
  __skreturn: Double;
begin
  __skparam__v1 := __skadapter__to_sklib_vector_2d(v1);
  __skparam__v2 := __skadapter__to_sklib_vector_2d(v2);
  __skreturn := __sklib__dot_product__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2);
  result := __skadapter__to_double(__skreturn);
end;
function IsZeroVector(const v: Vector2D): Boolean;
var
  __skparam__v: __sklib_vector_2d;
  __skreturn: LongInt;
begin
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skreturn := __sklib__is_zero_vector__vector_2d_ref(__skparam__v);
  result := __skadapter__to_bool(__skreturn);
end;
function RayIntersectionPoint(const fromPt: Point2D; const heading: Vector2D; const l: Line; var pt: Point2D): Boolean;
var
  __skparam__from_pt: __sklib_point_2d;
  __skparam__heading: __sklib_vector_2d;
  __skparam__l: __sklib_line;
  __skparam__pt: __sklib_point_2d;
  __skreturn: LongInt;
begin
  __skparam__from_pt := __skadapter__to_sklib_point_2d(fromPt);
  __skparam__heading := __skadapter__to_sklib_vector_2d(heading);
  __skparam__l := __skadapter__to_sklib_line(l);
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skreturn := __sklib__ray_intersection_point__point_2d_ref__vector_2d_ref__line_ref__point_2d_ref(__skparam__from_pt, __skparam__heading, __skparam__l, __skparam__pt);
  pt := __skadapter__to_point_2d(__skparam__pt);
  result := __skadapter__to_bool(__skreturn);
end;
function UnitVector(const v: Vector2D): Vector2D;
var
  __skparam__v: __sklib_vector_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skreturn := __sklib__unit_vector__vector_2d_ref(__skparam__v);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorAdd(const v1: Vector2D; const v2: Vector2D): Vector2D;
var
  __skparam__v1: __sklib_vector_2d;
  __skparam__v2: __sklib_vector_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__v1 := __skadapter__to_sklib_vector_2d(v1);
  __skparam__v2 := __skadapter__to_sklib_vector_2d(v2);
  __skreturn := __sklib__vector_add__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorAngle(v: Vector2D): Double;
var
  __skparam__v: __sklib_vector_2d;
  __skreturn: Double;
begin
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skreturn := __sklib__vector_angle__vector_2d(__skparam__v);
  result := __skadapter__to_double(__skreturn);
end;
function VectorFromAngle(angle: Double; magnitude: Double): Vector2D;
var
  __skparam__angle: Double;
  __skparam__magnitude: Double;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__angle := __skadapter__to_sklib_double(angle);
  __skparam__magnitude := __skadapter__to_sklib_double(magnitude);
  __skreturn := __sklib__vector_from_angle__double__double(__skparam__angle, __skparam__magnitude);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorFromLine(const l: Line): Vector2D;
var
  __skparam__l: __sklib_line;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__l := __skadapter__to_sklib_line(l);
  __skreturn := __sklib__vector_from_line__line_ref(__skparam__l);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorFromPointToRect(const pt: Point2D; const rect: Rectangle): Vector2D;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__rect: __sklib_rectangle;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__vector_from_point_to_rect__point_2d_ref__rectangle_ref(__skparam__pt, __skparam__rect);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorInRect(const v: Vector2D; const rect: Rectangle): Boolean;
var
  __skparam__v: __sklib_vector_2d;
  __skparam__rect: __sklib_rectangle;
  __skreturn: LongInt;
begin
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skreturn := __sklib__vector_in_rect__vector_2d_ref__rectangle_ref(__skparam__v, __skparam__rect);
  result := __skadapter__to_bool(__skreturn);
end;
function VectorInvert(const v: Vector2D): Vector2D;
var
  __skparam__v: __sklib_vector_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skreturn := __sklib__vector_invert__vector_2d_ref(__skparam__v);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorLimit(const v: Vector2D; limit: Double): Vector2D;
var
  __skparam__v: __sklib_vector_2d;
  __skparam__limit: Double;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skparam__limit := __skadapter__to_sklib_double(limit);
  __skreturn := __sklib__vector_limit__vector_2d_ref__double(__skparam__v, __skparam__limit);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorMagnitude(const v: Vector2D): Double;
var
  __skparam__v: __sklib_vector_2d;
  __skreturn: Double;
begin
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skreturn := __sklib__vector_magnitude__vector_2d_ref(__skparam__v);
  result := __skadapter__to_double(__skreturn);
end;
function VectorMagnitudeSquared(const v: Vector2D): Double;
var
  __skparam__v: __sklib_vector_2d;
  __skreturn: Double;
begin
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skreturn := __sklib__vector_magnitude_squared__vector_2d_ref(__skparam__v);
  result := __skadapter__to_double(__skreturn);
end;
function VectorMultiply(const v1: Vector2D; s: Double): Vector2D;
var
  __skparam__v1: __sklib_vector_2d;
  __skparam__s: Double;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__v1 := __skadapter__to_sklib_vector_2d(v1);
  __skparam__s := __skadapter__to_sklib_double(s);
  __skreturn := __sklib__vector_multiply__vector_2d_ref__double(__skparam__v1, __skparam__s);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorNormal(const v: Vector2D): Vector2D;
var
  __skparam__v: __sklib_vector_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skreturn := __sklib__vector_normal__vector_2d_ref(__skparam__v);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorOutOfCircleFromCircle(const src: Circle; const bounds: Circle; const velocity: Vector2D): Vector2D;
var
  __skparam__src: __sklib_circle;
  __skparam__bounds: __sklib_circle;
  __skparam__velocity: __sklib_vector_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__src := __skadapter__to_sklib_circle(src);
  __skparam__bounds := __skadapter__to_sklib_circle(bounds);
  __skparam__velocity := __skadapter__to_sklib_vector_2d(velocity);
  __skreturn := __sklib__vector_out_of_circle_from_circle__circle_ref__circle_ref__vector_2d_ref(__skparam__src, __skparam__bounds, __skparam__velocity);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorOutOfCircleFromPoint(const pt: Point2D; const c: Circle; const velocity: Vector2D): Vector2D;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__c: __sklib_circle;
  __skparam__velocity: __sklib_vector_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__velocity := __skadapter__to_sklib_vector_2d(velocity);
  __skreturn := __sklib__vector_out_of_circle_from_point__point_2d_ref__circle_ref__vector_2d_ref(__skparam__pt, __skparam__c, __skparam__velocity);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorOutOfRectFromCircle(const c: Circle; const rect: Rectangle; const velocity: Vector2D): Vector2D;
var
  __skparam__c: __sklib_circle;
  __skparam__rect: __sklib_rectangle;
  __skparam__velocity: __sklib_vector_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__c := __skadapter__to_sklib_circle(c);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__velocity := __skadapter__to_sklib_vector_2d(velocity);
  __skreturn := __sklib__vector_out_of_rect_from_circle__circle_ref__rectangle_ref__vector_2d_ref(__skparam__c, __skparam__rect, __skparam__velocity);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorOutOfRectFromPoint(const pt: Point2D; const rect: Rectangle; const velocity: Vector2D): Vector2D;
var
  __skparam__pt: __sklib_point_2d;
  __skparam__rect: __sklib_rectangle;
  __skparam__velocity: __sklib_vector_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__pt := __skadapter__to_sklib_point_2d(pt);
  __skparam__rect := __skadapter__to_sklib_rectangle(rect);
  __skparam__velocity := __skadapter__to_sklib_vector_2d(velocity);
  __skreturn := __sklib__vector_out_of_rect_from_point__point_2d_ref__rectangle_ref__vector_2d_ref(__skparam__pt, __skparam__rect, __skparam__velocity);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorOutOfRectFromRect(const src: Rectangle; const bounds: Rectangle; const velocity: Vector2D): Vector2D;
var
  __skparam__src: __sklib_rectangle;
  __skparam__bounds: __sklib_rectangle;
  __skparam__velocity: __sklib_vector_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__src := __skadapter__to_sklib_rectangle(src);
  __skparam__bounds := __skadapter__to_sklib_rectangle(bounds);
  __skparam__velocity := __skadapter__to_sklib_vector_2d(velocity);
  __skreturn := __sklib__vector_out_of_rect_from_rect__rectangle_ref__rectangle_ref__vector_2d_ref(__skparam__src, __skparam__bounds, __skparam__velocity);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorPointToPoint(const start: Point2D; const endPt: Point2D): Vector2D;
var
  __skparam__start: __sklib_point_2d;
  __skparam__end_pt: __sklib_point_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__start := __skadapter__to_sklib_point_2d(start);
  __skparam__end_pt := __skadapter__to_sklib_point_2d(endPt);
  __skreturn := __sklib__vector_point_to_point__point_2d_ref__point_2d_ref(__skparam__start, __skparam__end_pt);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorSubtract(const v1: Vector2D; const v2: Vector2D): Vector2D;
var
  __skparam__v1: __sklib_vector_2d;
  __skparam__v2: __sklib_vector_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__v1 := __skadapter__to_sklib_vector_2d(v1);
  __skparam__v2 := __skadapter__to_sklib_vector_2d(v2);
  __skreturn := __sklib__vector_subtract__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorTo(const p1: Point2D): Vector2D;
var
  __skparam__p1: __sklib_point_2d;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__p1 := __skadapter__to_sklib_point_2d(p1);
  __skreturn := __sklib__vector_to__point_2d_ref(__skparam__p1);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorTo(x: Double; y: Double): Vector2D;
var
  __skparam__x: Double;
  __skparam__y: Double;
  __skreturn: __sklib_vector_2d;
begin
  __skparam__x := __skadapter__to_sklib_double(x);
  __skparam__y := __skadapter__to_sklib_double(y);
  __skreturn := __sklib__vector_to__double__double(__skparam__x, __skparam__y);
  result := __skadapter__to_vector_2d(__skreturn);
end;
function VectorToString(const v: Vector2D): String;
var
  __skparam__v: __sklib_vector_2d;
  __skreturn: __sklib_string;
begin
  __skparam__v := __skadapter__to_sklib_vector_2d(v);
  __skreturn := __sklib__vector_to_string__vector_2d_ref(__skparam__v);
  result := __skadapter__to_string(__skreturn);
end;
function VectorsEqual(const v1: Vector2D; v2: Vector2D): Boolean;
var
  __skparam__v1: __sklib_vector_2d;
  __skparam__v2: __sklib_vector_2d;
  __skreturn: LongInt;
begin
  __skparam__v1 := __skadapter__to_sklib_vector_2d(v1);
  __skparam__v2 := __skadapter__to_sklib_vector_2d(v2);
  __skreturn := __sklib__vectors_equal__vector_2d_ref__vector_2d(__skparam__v1, __skparam__v2);
  result := __skadapter__to_bool(__skreturn);
end;
function VectorsNotEqual(const v1: Vector2D; v2: Vector2D): Boolean;
var
  __skparam__v1: __sklib_vector_2d;
  __skparam__v2: __sklib_vector_2d;
  __skreturn: LongInt;
begin
  __skparam__v1 := __skadapter__to_sklib_vector_2d(v1);
  __skparam__v2 := __skadapter__to_sklib_vector_2d(v2);
  __skreturn := __sklib__vectors_not_equal__vector_2d_ref__vector_2d(__skparam__v1, __skparam__v2);
  result := __skadapter__to_bool(__skreturn);
end;
function DownloadBitmap(const name: String; const url: String; port: Word): Bitmap;
var
  __skparam__name: __sklib_string;
  __skparam__url: __sklib_string;
  __skparam__port: Word;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__url := __skadapter__to_sklib_string(url);
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skreturn := __sklib__download_bitmap__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port);
  result := __skadapter__to_bitmap(__skreturn);
end;
function DownloadFont(const name: String; const url: String; port: Word): Font;
var
  __skparam__name: __sklib_string;
  __skparam__url: __sklib_string;
  __skparam__port: Word;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__url := __skadapter__to_sklib_string(url);
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skreturn := __sklib__download_font__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port);
  result := __skadapter__to_font(__skreturn);
end;
function DownloadMusic(const name: String; const url: String; port: Word): Music;
var
  __skparam__name: __sklib_string;
  __skparam__url: __sklib_string;
  __skparam__port: Word;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__url := __skadapter__to_sklib_string(url);
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skreturn := __sklib__download_music__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port);
  result := __skadapter__to_music(__skreturn);
end;
function DownloadSoundEffect(const name: String; const url: String; port: Word): SoundEffect;
var
  __skparam__name: __sklib_string;
  __skparam__url: __sklib_string;
  __skparam__port: Word;
  __skreturn: __sklib_ptr;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__url := __skadapter__to_sklib_string(url);
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skreturn := __sklib__download_sound_effect__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port);
  result := __skadapter__to_sound_effect(__skreturn);
end;
procedure FreeResponse(response: HttpResponse);
var
  __skparam__response: __sklib_ptr;
begin
  __skparam__response := __skadapter__to_sklib_http_response(response);
  __sklib__free_response__http_response(__skparam__response);
end;
function HttpGet(const url: String; port: Word): HttpResponse;
var
  __skparam__url: __sklib_string;
  __skparam__port: Word;
  __skreturn: __sklib_ptr;
begin
  __skparam__url := __skadapter__to_sklib_string(url);
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skreturn := __sklib__http_get__string_ref__unsigned_short(__skparam__url, __skparam__port);
  result := __skadapter__to_http_response(__skreturn);
end;
function HttpPost(const url: String; port: Word; const body: String; const headers: ArrayOfString): HttpResponse;
var
  __skparam__url: __sklib_string;
  __skparam__port: Word;
  __skparam__body: __sklib_string;
  __skparam__headers: __sklib_vector_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__url := __skadapter__to_sklib_string(url);
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skparam__body := __skadapter__to_sklib_string(body);
  __skparam__headers := __skadapter__to_sklib_vector_string(headers);
  __skreturn := __sklib__http_post__string_ref__unsigned_short__string_ref__vector_string_ref(__skparam__url, __skparam__port, __skparam__body, __skparam__headers);
  result := __skadapter__to_http_response(__skreturn);
end;
function HttpPost(const url: String; port: Word; body: String): HttpResponse;
var
  __skparam__url: __sklib_string;
  __skparam__port: Word;
  __skparam__body: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__url := __skadapter__to_sklib_string(url);
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skparam__body := __skadapter__to_sklib_string(body);
  __skreturn := __sklib__http_post__string_ref__unsigned_short__string(__skparam__url, __skparam__port, __skparam__body);
  result := __skadapter__to_http_response(__skreturn);
end;
function HttpResponseToString(response: HttpResponse): String;
var
  __skparam__response: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__response := __skadapter__to_sklib_http_response(response);
  __skreturn := __sklib__http_response_to_string__http_response(__skparam__response);
  result := __skadapter__to_string(__skreturn);
end;
procedure SaveResponseToFile(response: HttpResponse; path: String);
var
  __skparam__response: __sklib_ptr;
  __skparam__path: __sklib_string;
begin
  __skparam__response := __skadapter__to_sklib_http_response(response);
  __skparam__path := __skadapter__to_sklib_string(path);
  __sklib__save_response_to_file__http_response__string(__skparam__response, __skparam__path);
end;
function HasIncomingRequests(server: WebServer): Boolean;
var
  __skparam__server: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__server := __skadapter__to_sklib_web_server(server);
  __skreturn := __sklib__has_incoming_requests__web_server(__skparam__server);
  result := __skadapter__to_bool(__skreturn);
end;
function IsDeleteRequestFor(request: HttpRequest; const path: String): Boolean;
var
  __skparam__request: __sklib_ptr;
  __skparam__path: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__request := __skadapter__to_sklib_http_request(request);
  __skparam__path := __skadapter__to_sklib_string(path);
  __skreturn := __sklib__is_delete_request_for__http_request__string_ref(__skparam__request, __skparam__path);
  result := __skadapter__to_bool(__skreturn);
end;
function IsGetRequestFor(request: HttpRequest; const path: String): Boolean;
var
  __skparam__request: __sklib_ptr;
  __skparam__path: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__request := __skadapter__to_sklib_http_request(request);
  __skparam__path := __skadapter__to_sklib_string(path);
  __skreturn := __sklib__is_get_request_for__http_request__string_ref(__skparam__request, __skparam__path);
  result := __skadapter__to_bool(__skreturn);
end;
function IsOptionsRequestFor(request: HttpRequest; const path: String): Boolean;
var
  __skparam__request: __sklib_ptr;
  __skparam__path: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__request := __skadapter__to_sklib_http_request(request);
  __skparam__path := __skadapter__to_sklib_string(path);
  __skreturn := __sklib__is_options_request_for__http_request__string_ref(__skparam__request, __skparam__path);
  result := __skadapter__to_bool(__skreturn);
end;
function IsPostRequestFor(request: HttpRequest; const path: String): Boolean;
var
  __skparam__request: __sklib_ptr;
  __skparam__path: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__request := __skadapter__to_sklib_http_request(request);
  __skparam__path := __skadapter__to_sklib_string(path);
  __skreturn := __sklib__is_post_request_for__http_request__string_ref(__skparam__request, __skparam__path);
  result := __skadapter__to_bool(__skreturn);
end;
function IsPutRequestFor(request: HttpRequest; const path: String): Boolean;
var
  __skparam__request: __sklib_ptr;
  __skparam__path: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__request := __skadapter__to_sklib_http_request(request);
  __skparam__path := __skadapter__to_sklib_string(path);
  __skreturn := __sklib__is_put_request_for__http_request__string_ref(__skparam__request, __skparam__path);
  result := __skadapter__to_bool(__skreturn);
end;
function IsRequestFor(request: HttpRequest; method: HttpMethod; const path: String): Boolean;
var
  __skparam__request: __sklib_ptr;
  __skparam__method: LongInt;
  __skparam__path: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__request := __skadapter__to_sklib_http_request(request);
  __skparam__method := __skadapter__to_sklib_http_method(method);
  __skparam__path := __skadapter__to_sklib_string(path);
  __skreturn := __sklib__is_request_for__http_request__http_method__string_ref(__skparam__request, __skparam__method, __skparam__path);
  result := __skadapter__to_bool(__skreturn);
end;
function IsTraceRequestFor(request: HttpRequest; const path: String): Boolean;
var
  __skparam__request: __sklib_ptr;
  __skparam__path: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__request := __skadapter__to_sklib_http_request(request);
  __skparam__path := __skadapter__to_sklib_string(path);
  __skreturn := __sklib__is_trace_request_for__http_request__string_ref(__skparam__request, __skparam__path);
  result := __skadapter__to_bool(__skreturn);
end;
function NextWebRequest(server: WebServer): HttpRequest;
var
  __skparam__server: __sklib_ptr;
  __skreturn: __sklib_ptr;
begin
  __skparam__server := __skadapter__to_sklib_web_server(server);
  __skreturn := __sklib__next_web_request__web_server(__skparam__server);
  result := __skadapter__to_http_request(__skreturn);
end;
function RequestBody(r: HttpRequest): String;
var
  __skparam__r: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skreturn := __sklib__request_body__http_request(__skparam__r);
  result := __skadapter__to_string(__skreturn);
end;
function RequestHasQueryParameter(r: HttpRequest; const name: String): Boolean;
var
  __skparam__r: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__request_has_query_parameter__http_request__string_ref(__skparam__r, __skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function RequestHeaders(r: HttpRequest): ArrayOfString;
var
  __skparam__r: __sklib_ptr;
  __skreturn: __sklib_vector_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skreturn := __sklib__request_headers__http_request(__skparam__r);
  result := __skadapter__to_vector_string(__skreturn);
end;
function RequestMethod(r: HttpRequest): HttpMethod;
var
  __skparam__r: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skreturn := __sklib__request_method__http_request(__skparam__r);
  result := __skadapter__to_http_method(__skreturn);
end;
function RequestQueryParameter(r: HttpRequest; const name: String; const defaultValue: String): String;
var
  __skparam__r: __sklib_ptr;
  __skparam__name: __sklib_string;
  __skparam__default_value: __sklib_string;
  __skreturn: __sklib_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__default_value := __skadapter__to_sklib_string(defaultValue);
  __skreturn := __sklib__request_query_parameter__http_request__string_ref__string_ref(__skparam__r, __skparam__name, __skparam__default_value);
  result := __skadapter__to_string(__skreturn);
end;
function RequestQueryString(r: HttpRequest): String;
var
  __skparam__r: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skreturn := __sklib__request_query_string__http_request(__skparam__r);
  result := __skadapter__to_string(__skreturn);
end;
function RequestURI(r: HttpRequest): String;
var
  __skparam__r: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skreturn := __sklib__request_uri__http_request(__skparam__r);
  result := __skadapter__to_string(__skreturn);
end;
function RequestURIStubs(r: HttpRequest): ArrayOfString;
var
  __skparam__r: __sklib_ptr;
  __skreturn: __sklib_vector_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skreturn := __sklib__request_uri_stubs__http_request(__skparam__r);
  result := __skadapter__to_vector_string(__skreturn);
end;
procedure SendCSSFileResponse(r: HttpRequest; const filename: String);
var
  __skparam__r: __sklib_ptr;
  __skparam__filename: __sklib_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __sklib__send_css_file_response__http_request__string_ref(__skparam__r, __skparam__filename);
end;
procedure SendFileResponse(r: HttpRequest; const filename: String; const contentType: String);
var
  __skparam__r: __sklib_ptr;
  __skparam__filename: __sklib_string;
  __skparam__content_type: __sklib_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __skparam__content_type := __skadapter__to_sklib_string(contentType);
  __sklib__send_file_response__http_request__string_ref__string_ref(__skparam__r, __skparam__filename, __skparam__content_type);
end;
procedure SendHtmlFileResponse(r: HttpRequest; const filename: String);
var
  __skparam__r: __sklib_ptr;
  __skparam__filename: __sklib_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __sklib__send_html_file_response__http_request__string_ref(__skparam__r, __skparam__filename);
end;
procedure SendJavascriptFileResponse(r: HttpRequest; const filename: String);
var
  __skparam__r: __sklib_ptr;
  __skparam__filename: __sklib_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__filename := __skadapter__to_sklib_string(filename);
  __sklib__send_javascript_file_response__http_request__string_ref(__skparam__r, __skparam__filename);
end;
procedure SendResponse(r: HttpRequest);
var
  __skparam__r: __sklib_ptr;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __sklib__send_response__http_request(__skparam__r);
end;
procedure SendResponse(r: HttpRequest; const message: String);
var
  __skparam__r: __sklib_ptr;
  __skparam__message: __sklib_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__message := __skadapter__to_sklib_string(message);
  __sklib__send_response__http_request__string_ref(__skparam__r, __skparam__message);
end;
procedure SendResponse(r: HttpRequest; code: HttpStatusCode);
var
  __skparam__r: __sklib_ptr;
  __skparam__code: LongInt;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__code := __skadapter__to_sklib_http_status_code(code);
  __sklib__send_response__http_request__http_status_code(__skparam__r, __skparam__code);
end;
procedure SendResponse(r: HttpRequest; code: HttpStatusCode; const message: String);
var
  __skparam__r: __sklib_ptr;
  __skparam__code: LongInt;
  __skparam__message: __sklib_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__code := __skadapter__to_sklib_http_status_code(code);
  __skparam__message := __skadapter__to_sklib_string(message);
  __sklib__send_response__http_request__http_status_code__string_ref(__skparam__r, __skparam__code, __skparam__message);
end;
procedure SendResponse(r: HttpRequest; code: HttpStatusCode; const message: String; const contentType: String);
var
  __skparam__r: __sklib_ptr;
  __skparam__code: LongInt;
  __skparam__message: __sklib_string;
  __skparam__content_type: __sklib_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__code := __skadapter__to_sklib_http_status_code(code);
  __skparam__message := __skadapter__to_sklib_string(message);
  __skparam__content_type := __skadapter__to_sklib_string(contentType);
  __sklib__send_response__http_request__http_status_code__string_ref__string_ref(__skparam__r, __skparam__code, __skparam__message, __skparam__content_type);
end;
procedure SendResponse(r: HttpRequest; code: HttpStatusCode; const message: String; const contentType: String; const headers: ArrayOfString);
var
  __skparam__r: __sklib_ptr;
  __skparam__code: LongInt;
  __skparam__message: __sklib_string;
  __skparam__content_type: __sklib_string;
  __skparam__headers: __sklib_vector_string;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__code := __skadapter__to_sklib_http_status_code(code);
  __skparam__message := __skadapter__to_sklib_string(message);
  __skparam__content_type := __skadapter__to_sklib_string(contentType);
  __skparam__headers := __skadapter__to_sklib_vector_string(headers);
  __sklib__send_response__http_request__http_status_code__string_ref__string_ref__vector_string_ref(__skparam__r, __skparam__code, __skparam__message, __skparam__content_type, __skparam__headers);
end;
procedure SendResponse(r: HttpRequest; j: Json);
var
  __skparam__r: __sklib_ptr;
  __skparam__j: __sklib_ptr;
begin
  __skparam__r := __skadapter__to_sklib_http_request(r);
  __skparam__j := __skadapter__to_sklib_json(j);
  __sklib__send_response__http_request__json(__skparam__r, __skparam__j);
end;
function SplitURIStubs(const uri: String): ArrayOfString;
var
  __skparam__uri: __sklib_string;
  __skreturn: __sklib_vector_string;
begin
  __skparam__uri := __skadapter__to_sklib_string(uri);
  __skreturn := __sklib__split_uri_stubs__string_ref(__skparam__uri);
  result := __skadapter__to_vector_string(__skreturn);
end;
function StartWebServer(): WebServer;
var
  __skreturn: __sklib_ptr;
begin
  __skreturn := __sklib__start_web_server();
  result := __skadapter__to_web_server(__skreturn);
end;
function StartWebServer(port: Word): WebServer;
var
  __skparam__port: Word;
  __skreturn: __sklib_ptr;
begin
  __skparam__port := __skadapter__to_sklib_unsigned_short(port);
  __skreturn := __sklib__start_web_server__unsigned_short(__skparam__port);
  result := __skadapter__to_web_server(__skreturn);
end;
procedure StopWebServer(server: WebServer);
var
  __skparam__server: __sklib_ptr;
begin
  __skparam__server := __skadapter__to_sklib_web_server(server);
  __sklib__stop_web_server__web_server(__skparam__server);
end;
procedure ClearWindow(wind: Window; clr: Color);
var
  __skparam__wind: __sklib_ptr;
  __skparam__clr: __sklib_color;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skparam__clr := __skadapter__to_sklib_color(clr);
  __sklib__clear_window__window__color(__skparam__wind, __skparam__clr);
end;
procedure CloseAllWindows();
begin
  __sklib__close_all_windows();
end;
procedure CloseCurrentWindow();
begin
  __sklib__close_current_window();
end;
procedure CloseWindow(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__close_window__string_ref(__skparam__name);
end;
procedure CloseWindow(wind: Window);
var
  __skparam__wind: __sklib_ptr;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __sklib__close_window__window(__skparam__wind);
end;
function CurrentWindow(): Window;
var
  __skreturn: __sklib_ptr;
begin
  __skreturn := __sklib__current_window();
  result := __skadapter__to_window(__skreturn);
end;
function CurrentWindowHasBorder(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__current_window_has_border();
  result := __skadapter__to_bool(__skreturn);
end;
function CurrentWindowHeight(): Integer;
var
  __skreturn: Integer;
begin
  __skreturn := __sklib__current_window_height();
  result := __skadapter__to_int(__skreturn);
end;
function CurrentWindowIsFullscreen(): Boolean;
var
  __skreturn: LongInt;
begin
  __skreturn := __sklib__current_window_is_fullscreen();
  result := __skadapter__to_bool(__skreturn);
end;
function CurrentWindowPosition(): Point2D;
var
  __skreturn: __sklib_point_2d;
begin
  __skreturn := __sklib__current_window_position();
  result := __skadapter__to_point_2d(__skreturn);
end;
procedure CurrentWindowToggleBorder();
begin
  __sklib__current_window_toggle_border();
end;
procedure CurrentWindowToggleFullscreen();
begin
  __sklib__current_window_toggle_fullscreen();
end;
function CurrentWindowWidth(): Integer;
var
  __skreturn: Integer;
begin
  __skreturn := __sklib__current_window_width();
  result := __skadapter__to_int(__skreturn);
end;
function CurrentWindowX(): Integer;
var
  __skreturn: Integer;
begin
  __skreturn := __sklib__current_window_x();
  result := __skadapter__to_int(__skreturn);
end;
function CurrentWindowY(): Integer;
var
  __skreturn: Integer;
begin
  __skreturn := __sklib__current_window_y();
  result := __skadapter__to_int(__skreturn);
end;
function HasWindow(caption: String): Boolean;
var
  __skparam__caption: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__caption := __skadapter__to_sklib_string(caption);
  __skreturn := __sklib__has_window__string(__skparam__caption);
  result := __skadapter__to_bool(__skreturn);
end;
function IsCurrentWindow(wind: Window): Boolean;
var
  __skparam__wind: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skreturn := __sklib__is_current_window__window(__skparam__wind);
  result := __skadapter__to_bool(__skreturn);
end;
procedure MoveCurrentWindowTo(x: Integer; y: Integer);
var
  __skparam__x: Integer;
  __skparam__y: Integer;
begin
  __skparam__x := __skadapter__to_sklib_int(x);
  __skparam__y := __skadapter__to_sklib_int(y);
  __sklib__move_current_window_to__int__int(__skparam__x, __skparam__y);
end;
procedure MoveWindowTo(const name: String; x: Integer; y: Integer);
var
  __skparam__name: __sklib_string;
  __skparam__x: Integer;
  __skparam__y: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skparam__x := __skadapter__to_sklib_int(x);
  __skparam__y := __skadapter__to_sklib_int(y);
  __sklib__move_window_to__string_ref__int__int(__skparam__name, __skparam__x, __skparam__y);
end;
procedure MoveWindowTo(wind: Window; x: Integer; y: Integer);
var
  __skparam__wind: __sklib_ptr;
  __skparam__x: Integer;
  __skparam__y: Integer;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skparam__x := __skadapter__to_sklib_int(x);
  __skparam__y := __skadapter__to_sklib_int(y);
  __sklib__move_window_to__window__int__int(__skparam__wind, __skparam__x, __skparam__y);
end;
function OpenWindow(caption: String; width: Integer; height: Integer): Window;
var
  __skparam__caption: __sklib_string;
  __skparam__width: Integer;
  __skparam__height: Integer;
  __skreturn: __sklib_ptr;
begin
  __skparam__caption := __skadapter__to_sklib_string(caption);
  __skparam__width := __skadapter__to_sklib_int(width);
  __skparam__height := __skadapter__to_sklib_int(height);
  __skreturn := __sklib__open_window__string__int__int(__skparam__caption, __skparam__width, __skparam__height);
  result := __skadapter__to_window(__skreturn);
end;
procedure RefreshWindow(wind: Window);
var
  __skparam__wind: __sklib_ptr;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __sklib__refresh_window__window(__skparam__wind);
end;
procedure RefreshWindow(wind: Window; targetFps: Cardinal);
var
  __skparam__wind: __sklib_ptr;
  __skparam__target_fps: Cardinal;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skparam__target_fps := __skadapter__to_sklib_unsigned_int(targetFps);
  __sklib__refresh_window__window__unsigned_int(__skparam__wind, __skparam__target_fps);
end;
procedure ResizeCurrentWindow(width: Integer; height: Integer);
var
  __skparam__width: Integer;
  __skparam__height: Integer;
begin
  __skparam__width := __skadapter__to_sklib_int(width);
  __skparam__height := __skadapter__to_sklib_int(height);
  __sklib__resize_current_window__int__int(__skparam__width, __skparam__height);
end;
procedure ResizeWindow(wnd: Window; width: Integer; height: Integer);
var
  __skparam__wnd: __sklib_ptr;
  __skparam__width: Integer;
  __skparam__height: Integer;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skparam__width := __skadapter__to_sklib_int(width);
  __skparam__height := __skadapter__to_sklib_int(height);
  __sklib__resize_window__window__int__int(__skparam__wnd, __skparam__width, __skparam__height);
end;
procedure SetCurrentWindow(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__set_current_window__string_ref(__skparam__name);
end;
procedure SetCurrentWindow(wind: Window);
var
  __skparam__wind: __sklib_ptr;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __sklib__set_current_window__window(__skparam__wind);
end;
function WindowCaption(wind: Window): String;
var
  __skparam__wind: __sklib_ptr;
  __skreturn: __sklib_string;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skreturn := __sklib__window_caption__window(__skparam__wind);
  result := __skadapter__to_string(__skreturn);
end;
function WindowCloseRequested(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__window_close_requested__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function WindowCloseRequested(wind: Window): Boolean;
var
  __skparam__wind: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skreturn := __sklib__window_close_requested__window(__skparam__wind);
  result := __skadapter__to_bool(__skreturn);
end;
function WindowHasBorder(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__window_has_border__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function WindowHasBorder(wnd: Window): Boolean;
var
  __skparam__wnd: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skreturn := __sklib__window_has_border__window(__skparam__wnd);
  result := __skadapter__to_bool(__skreturn);
end;
function WindowHasFocus(wind: Window): Boolean;
var
  __skparam__wind: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skreturn := __sklib__window_has_focus__window(__skparam__wind);
  result := __skadapter__to_bool(__skreturn);
end;
function WindowHeight(const name: String): Integer;
var
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__window_height__string_ref(__skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
function WindowHeight(wind: Window): Integer;
var
  __skparam__wind: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skreturn := __sklib__window_height__window(__skparam__wind);
  result := __skadapter__to_int(__skreturn);
end;
function WindowIsFullscreen(const name: String): Boolean;
var
  __skparam__name: __sklib_string;
  __skreturn: LongInt;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__window_is_fullscreen__string_ref(__skparam__name);
  result := __skadapter__to_bool(__skreturn);
end;
function WindowIsFullscreen(wnd: Window): Boolean;
var
  __skparam__wnd: __sklib_ptr;
  __skreturn: LongInt;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skreturn := __sklib__window_is_fullscreen__window(__skparam__wnd);
  result := __skadapter__to_bool(__skreturn);
end;
function WindowNamed(caption: String): Window;
var
  __skparam__caption: __sklib_string;
  __skreturn: __sklib_ptr;
begin
  __skparam__caption := __skadapter__to_sklib_string(caption);
  __skreturn := __sklib__window_named__string(__skparam__caption);
  result := __skadapter__to_window(__skreturn);
end;
function WindowPosition(const name: String): Point2D;
var
  __skparam__name: __sklib_string;
  __skreturn: __sklib_point_2d;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__window_position__string_ref(__skparam__name);
  result := __skadapter__to_point_2d(__skreturn);
end;
function WindowPosition(wnd: Window): Point2D;
var
  __skparam__wnd: __sklib_ptr;
  __skreturn: __sklib_point_2d;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skreturn := __sklib__window_position__window(__skparam__wnd);
  result := __skadapter__to_point_2d(__skreturn);
end;
procedure WindowSetIcon(wind: Window; bmp: Bitmap);
var
  __skparam__wind: __sklib_ptr;
  __skparam__bmp: __sklib_ptr;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skparam__bmp := __skadapter__to_sklib_bitmap(bmp);
  __sklib__window_set_icon__window__bitmap(__skparam__wind, __skparam__bmp);
end;
procedure WindowToggleBorder(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__window_toggle_border__string_ref(__skparam__name);
end;
procedure WindowToggleBorder(wnd: Window);
var
  __skparam__wnd: __sklib_ptr;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __sklib__window_toggle_border__window(__skparam__wnd);
end;
procedure WindowToggleFullscreen(const name: String);
var
  __skparam__name: __sklib_string;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __sklib__window_toggle_fullscreen__string_ref(__skparam__name);
end;
procedure WindowToggleFullscreen(wnd: Window);
var
  __skparam__wnd: __sklib_ptr;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __sklib__window_toggle_fullscreen__window(__skparam__wnd);
end;
function WindowWidth(const name: String): Integer;
var
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__window_width__string_ref(__skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
function WindowWidth(wind: Window): Integer;
var
  __skparam__wind: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__wind := __skadapter__to_sklib_window(wind);
  __skreturn := __sklib__window_width__window(__skparam__wind);
  result := __skadapter__to_int(__skreturn);
end;
function WindowWithFocus(): Window;
var
  __skreturn: __sklib_ptr;
begin
  __skreturn := __sklib__window_with_focus();
  result := __skadapter__to_window(__skreturn);
end;
function WindowX(const name: String): Integer;
var
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__window_x__string_ref(__skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
function WindowX(wnd: Window): Integer;
var
  __skparam__wnd: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skreturn := __sklib__window_x__window(__skparam__wnd);
  result := __skadapter__to_int(__skreturn);
end;
function WindowY(const name: String): Integer;
var
  __skparam__name: __sklib_string;
  __skreturn: Integer;
begin
  __skparam__name := __skadapter__to_sklib_string(name);
  __skreturn := __sklib__window_y__string_ref(__skparam__name);
  result := __skadapter__to_int(__skreturn);
end;
function WindowY(wnd: Window): Integer;
var
  __skparam__wnd: __sklib_ptr;
  __skreturn: Integer;
begin
  __skparam__wnd := __skadapter__to_sklib_window(wnd);
  __skreturn := __sklib__window_y__window(__skparam__wnd);
  result := __skadapter__to_int(__skreturn);
end;

begin
  SetExceptionMask([exInvalidOp, exDenormalized, exZeroDivide, exOverflow, exUnderflow, exPrecision]);
end.
