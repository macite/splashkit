using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using __sklib_ptr = System.IntPtr;

namespace SplashKitSDK
{
  public static class SplashKit
  {
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_bool(bool v) { return v ? -1 : 0; }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool __skadapter__to_bool(int v) { return v != 0; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_ptr(IntPtr v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_ptr(IntPtr v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static byte __skadapter__to_sklib_int8_t(byte v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static byte __skadapter__to_int8_t(byte v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_int(int v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_int(int v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static short __skadapter__to_sklib_short(short v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static short __skadapter__to_short(short v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static long __skadapter__to_sklib_int64_t(long v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static long __skadapter__to_int64_t(long v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float __skadapter__to_sklib_float(float v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float __skadapter__to_float(float v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double __skadapter__to_sklib_double(double v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double __skadapter__to_double(double v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static byte __skadapter__to_sklib_byte(byte v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static byte __skadapter__to_byte(byte v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static char __skadapter__to_sklib_char(char v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static char __skadapter__to_char(char v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static byte __skadapter__to_sklib_unsigned_char(byte v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static byte __skadapter__to_unsigned_char(byte v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint __skadapter__to_sklib_unsigned_int(uint v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint __skadapter__to_unsigned_int(uint v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ushort __skadapter__to_sklib_unsigned_short(ushort v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ushort __skadapter__to_unsigned_short(ushort v) { return v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_key_code(KeyCode v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static KeyCode __skadapter__to_key_code(int v) { return (KeyCode)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_log_level(LogLevel v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static LogLevel __skadapter__to_log_level(int v) { return (LogLevel)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_log_mode(LogMode v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static LogMode __skadapter__to_log_mode(int v) { return (LogMode)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_mouse_button(MouseButton v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static MouseButton __skadapter__to_mouse_button(int v) { return (MouseButton)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_connection_type(ConnectionType v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ConnectionType __skadapter__to_connection_type(int v) { return (ConnectionType)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_resource_kind(ResourceKind v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ResourceKind __skadapter__to_resource_kind(int v) { return (ResourceKind)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_collision_test_kind(CollisionTestKind v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static CollisionTestKind __skadapter__to_collision_test_kind(int v) { return (CollisionTestKind)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_sprite_event_kind(SpriteEventKind v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static SpriteEventKind __skadapter__to_sprite_event_kind(int v) { return (SpriteEventKind)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_drawing_dest(DrawingDest v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static DrawingDest __skadapter__to_drawing_dest(int v) { return (DrawingDest)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_font_style(FontStyle v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FontStyle __skadapter__to_font_style(int v) { return (FontStyle)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_http_status_code(HttpStatusCode v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static HttpStatusCode __skadapter__to_http_status_code(int v) { return (HttpStatusCode)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_interface_style(InterfaceStyle v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static InterfaceStyle __skadapter__to_interface_style(int v) { return (InterfaceStyle)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_pin_modes(PinModes v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static PinModes __skadapter__to_pin_modes(int v) { return (PinModes)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_pin_values(PinValues v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static PinValues __skadapter__to_pin_values(int v) { return (PinValues)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_pins(Pins v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Pins __skadapter__to_pins(int v) { return (Pins)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_pull_up_down(PullUpDown v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static PullUpDown __skadapter__to_pull_up_down(int v) { return (PullUpDown)v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int __skadapter__to_sklib_http_method(HttpMethod v) { return (int)v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static HttpMethod __skadapter__to_http_method(int v) { return (HttpMethod)v; }

    [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi ) ]
    private struct __sklib_string
    {
      internal IntPtr str;
      internal int    size;
      internal IntPtr ptr;
    }

    private static __sklib_string __skadapter__to_sklib_string(string s)
    {
      s = s == null ? "": s;
      int totalLength = s.Length + 1;
      __sklib_string result;
      result.size = totalLength;

      result.str = Marshal.AllocHGlobal(totalLength);

      Marshal.Copy(System.Text.Encoding.ASCII.GetBytes(s), 0, result.str, s.Length);
      Marshal.WriteByte(result.str, s.Length, 0);

      result.ptr = IntPtr.Zero;
      return result;
    }

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free__sklib_string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free__sklib_string(__sklib_string s);

    private static void __skadapter__free__sklib_string(ref __sklib_string s)
    {
      Marshal.FreeHGlobal(s.str);
      s.str = IntPtr.Zero;
    }

    private static string __skadapter__to_string(__sklib_string s)
    {
      byte[] bytes = new byte[s.size];
      Marshal.Copy(s.str, bytes, 0, bytes.Length);

      string result = System.Text.Encoding.ASCII.GetString (bytes);
      __sklib__free__sklib_string(s);
      return result;
    }

    private static __sklib_matrix_2d __skadapter__to_sklib_matrix_2d(Matrix2D v)
    {
      __sklib_matrix_2d __skreturn;
      __skreturn.Elements_0 = __skadapter__to_sklib_double(v.Elements[0,0]);
      __skreturn.Elements_1 = __skadapter__to_sklib_double(v.Elements[0,1]);
      __skreturn.Elements_2 = __skadapter__to_sklib_double(v.Elements[0,2]);
      __skreturn.Elements_3 = __skadapter__to_sklib_double(v.Elements[1,0]);
      __skreturn.Elements_4 = __skadapter__to_sklib_double(v.Elements[1,1]);
      __skreturn.Elements_5 = __skadapter__to_sklib_double(v.Elements[1,2]);
      __skreturn.Elements_6 = __skadapter__to_sklib_double(v.Elements[2,0]);
      __skreturn.Elements_7 = __skadapter__to_sklib_double(v.Elements[2,1]);
      __skreturn.Elements_8 = __skadapter__to_sklib_double(v.Elements[2,2]);
      return __skreturn;
    }
    private static Matrix2D __skadapter__to_matrix_2d(__sklib_matrix_2d v)
    {
      Matrix2D __skreturn;
      __skreturn.Elements = new double[3,3];
      __skreturn.Elements[0,0] = __skadapter__to_double(v.Elements_0);
      __skreturn.Elements[0,1] = __skadapter__to_double(v.Elements_1);
      __skreturn.Elements[0,2] = __skadapter__to_double(v.Elements_2);
      __skreturn.Elements[1,0] = __skadapter__to_double(v.Elements_3);
      __skreturn.Elements[1,1] = __skadapter__to_double(v.Elements_4);
      __skreturn.Elements[1,2] = __skadapter__to_double(v.Elements_5);
      __skreturn.Elements[2,0] = __skadapter__to_double(v.Elements_6);
      __skreturn.Elements[2,1] = __skadapter__to_double(v.Elements_7);
      __skreturn.Elements[2,2] = __skadapter__to_double(v.Elements_8);
      return __skreturn;
    }


    private static __sklib_point_2d __skadapter__to_sklib_point_2d(Point2D v)
    {
      __sklib_point_2d __skreturn;
      __skreturn.X = __skadapter__to_sklib_double(v.X);
      __skreturn.Y = __skadapter__to_sklib_double(v.Y);
      return __skreturn;
    }
    private static Point2D __skadapter__to_point_2d(__sklib_point_2d v)
    {
      Point2D __skreturn;
      __skreturn.X = __skadapter__to_double(v.X);
      __skreturn.Y = __skadapter__to_double(v.Y);
      return __skreturn;
    }


    private static __sklib_circle __skadapter__to_sklib_circle(Circle v)
    {
      __sklib_circle __skreturn;
      __skreturn.Center = __skadapter__to_sklib_point_2d(v.Center);
      __skreturn.Radius = __skadapter__to_sklib_double(v.Radius);
      return __skreturn;
    }
    private static Circle __skadapter__to_circle(__sklib_circle v)
    {
      Circle __skreturn;
      __skreturn.Center = __skadapter__to_point_2d(v.Center);
      __skreturn.Radius = __skadapter__to_double(v.Radius);
      return __skreturn;
    }


    private static __sklib_color __skadapter__to_sklib_color(Color v)
    {
      __sklib_color __skreturn;
      __skreturn.R = __skadapter__to_sklib_float(v.R);
      __skreturn.G = __skadapter__to_sklib_float(v.G);
      __skreturn.B = __skadapter__to_sklib_float(v.B);
      __skreturn.A = __skadapter__to_sklib_float(v.A);
      return __skreturn;
    }
    private static Color __skadapter__to_color(__sklib_color v)
    {
      Color __skreturn;
      __skreturn.R = __skadapter__to_float(v.R);
      __skreturn.G = __skadapter__to_float(v.G);
      __skreturn.B = __skadapter__to_float(v.B);
      __skreturn.A = __skadapter__to_float(v.A);
      return __skreturn;
    }


    private static __sklib_rectangle __skadapter__to_sklib_rectangle(Rectangle v)
    {
      __sklib_rectangle __skreturn;
      __skreturn.X = __skadapter__to_sklib_double(v.X);
      __skreturn.Y = __skadapter__to_sklib_double(v.Y);
      __skreturn.Width = __skadapter__to_sklib_double(v.Width);
      __skreturn.Height = __skadapter__to_sklib_double(v.Height);
      return __skreturn;
    }
    private static Rectangle __skadapter__to_rectangle(__sklib_rectangle v)
    {
      Rectangle __skreturn;
      __skreturn.X = __skadapter__to_double(v.X);
      __skreturn.Y = __skadapter__to_double(v.Y);
      __skreturn.Width = __skadapter__to_double(v.Width);
      __skreturn.Height = __skadapter__to_double(v.Height);
      return __skreturn;
    }


    private static __sklib_drawing_options __skadapter__to_sklib_drawing_options(DrawingOptions v)
    {
      __sklib_drawing_options __skreturn;
      __skreturn.Dest = __skadapter__to_sklib_ptr(v.Dest);
      __skreturn.ScaleX = __skadapter__to_sklib_float(v.ScaleX);
      __skreturn.ScaleY = __skadapter__to_sklib_float(v.ScaleY);
      __skreturn.Angle = __skadapter__to_sklib_float(v.Angle);
      __skreturn.AnchorOffsetX = __skadapter__to_sklib_float(v.AnchorOffsetX);
      __skreturn.AnchorOffsetY = __skadapter__to_sklib_float(v.AnchorOffsetY);
      __skreturn.FlipX = __skadapter__to_sklib_bool(v.FlipX);
      __skreturn.FlipY = __skadapter__to_sklib_bool(v.FlipY);
      __skreturn.IsPart = __skadapter__to_sklib_bool(v.IsPart);
      __skreturn.Part = __skadapter__to_sklib_rectangle(v.Part);
      __skreturn.DrawCell = __skadapter__to_sklib_int(v.DrawCell);
      __skreturn.Camera = __skadapter__to_sklib_drawing_dest(v.Camera);
      __skreturn.LineWidth = __skadapter__to_sklib_int(v.LineWidth);
      __skreturn.Anim = __skadapter__to_sklib_animation(v.Anim);
      return __skreturn;
    }
    private static DrawingOptions __skadapter__to_drawing_options(__sklib_drawing_options v)
    {
      DrawingOptions __skreturn;
      __skreturn.Dest = __skadapter__to_ptr(v.Dest);
      __skreturn.ScaleX = __skadapter__to_float(v.ScaleX);
      __skreturn.ScaleY = __skadapter__to_float(v.ScaleY);
      __skreturn.Angle = __skadapter__to_float(v.Angle);
      __skreturn.AnchorOffsetX = __skadapter__to_float(v.AnchorOffsetX);
      __skreturn.AnchorOffsetY = __skadapter__to_float(v.AnchorOffsetY);
      __skreturn.FlipX = __skadapter__to_bool(v.FlipX);
      __skreturn.FlipY = __skadapter__to_bool(v.FlipY);
      __skreturn.IsPart = __skadapter__to_bool(v.IsPart);
      __skreturn.Part = __skadapter__to_rectangle(v.Part);
      __skreturn.DrawCell = __skadapter__to_int(v.DrawCell);
      __skreturn.Camera = __skadapter__to_drawing_dest(v.Camera);
      __skreturn.LineWidth = __skadapter__to_int(v.LineWidth);
      __skreturn.Anim = __skadapter__to_animation(v.Anim);
      return __skreturn;
    }


    private static __sklib_line __skadapter__to_sklib_line(Line v)
    {
      __sklib_line __skreturn;
      __skreturn.StartPoint = __skadapter__to_sklib_point_2d(v.StartPoint);
      __skreturn.EndPoint = __skadapter__to_sklib_point_2d(v.EndPoint);
      return __skreturn;
    }
    private static Line __skadapter__to_line(__sklib_line v)
    {
      Line __skreturn;
      __skreturn.StartPoint = __skadapter__to_point_2d(v.StartPoint);
      __skreturn.EndPoint = __skadapter__to_point_2d(v.EndPoint);
      return __skreturn;
    }


    private static __sklib_quad __skadapter__to_sklib_quad(Quad v)
    {
      __sklib_quad __skreturn;
      __skreturn.Points_0 = __skadapter__to_sklib_point_2d(v.Points[0]);
      __skreturn.Points_1 = __skadapter__to_sklib_point_2d(v.Points[1]);
      __skreturn.Points_2 = __skadapter__to_sklib_point_2d(v.Points[2]);
      __skreturn.Points_3 = __skadapter__to_sklib_point_2d(v.Points[3]);
      return __skreturn;
    }
    private static Quad __skadapter__to_quad(__sklib_quad v)
    {
      Quad __skreturn;
      __skreturn.Points = new Point2D[4];
      __skreturn.Points[0] = __skadapter__to_point_2d(v.Points_0);
      __skreturn.Points[1] = __skadapter__to_point_2d(v.Points_1);
      __skreturn.Points[2] = __skadapter__to_point_2d(v.Points_2);
      __skreturn.Points[3] = __skadapter__to_point_2d(v.Points_3);
      return __skreturn;
    }


    private static __sklib_triangle __skadapter__to_sklib_triangle(Triangle v)
    {
      __sklib_triangle __skreturn;
      __skreturn.Points_0 = __skadapter__to_sklib_point_2d(v.Points[0]);
      __skreturn.Points_1 = __skadapter__to_sklib_point_2d(v.Points[1]);
      __skreturn.Points_2 = __skadapter__to_sklib_point_2d(v.Points[2]);
      return __skreturn;
    }
    private static Triangle __skadapter__to_triangle(__sklib_triangle v)
    {
      Triangle __skreturn;
      __skreturn.Points = new Point2D[3];
      __skreturn.Points[0] = __skadapter__to_point_2d(v.Points_0);
      __skreturn.Points[1] = __skadapter__to_point_2d(v.Points_1);
      __skreturn.Points[2] = __skadapter__to_point_2d(v.Points_2);
      return __skreturn;
    }


    private static __sklib_vector_2d __skadapter__to_sklib_vector_2d(Vector2D v)
    {
      __sklib_vector_2d __skreturn;
      __skreturn.X = __skadapter__to_sklib_double(v.X);
      __skreturn.Y = __skadapter__to_sklib_double(v.Y);
      return __skreturn;
    }
    private static Vector2D __skadapter__to_vector_2d(__sklib_vector_2d v)
    {
      Vector2D __skreturn;
      __skreturn.X = __skadapter__to_double(v.X);
      __skreturn.Y = __skadapter__to_double(v.Y);
      return __skreturn;
    }


    // Based on: https://social.msdn.microsoft.com/Forums/vstudio/en-US/0f5ba27d-92c2-4b41-b717-16e759b68087/how-to-marshal-an-array-of-struct-pointer?forum=csharpgeneral
    private static IntPtr ToIntPtr<T>(T[] items) where T : struct
    {
        IntPtr result, tmp = IntPtr.Zero;

        int length = Marshal.SizeOf<T>();
        int totalLength = length * items.Length;

        result = Marshal.AllocHGlobal(totalLength);

        int start = 0;
        byte[] data = new byte[totalLength];   //prepare to get the whole items array to this bytes array
        foreach (T item in items)
        {
            tmp = Marshal.AllocHGlobal(length);
            Marshal.StructureToPtr(item, tmp, false);

            Marshal.Copy(tmp, data, start, length);
            start += length;
            Marshal.FreeHGlobal(tmp);
        }
        Marshal.Copy(data, 0, result, totalLength);

        return result;
    }

    private static T[] FromIntPtr<T>(IntPtr ptr, int count) where T : struct
    {
        T[] result = new T[count];
        IntPtr tmp;

        int size = Marshal.SizeOf<T>();
        int totalSize = size * count;
        byte[] data = new byte[totalSize];

        Marshal.Copy(ptr, data, 0, totalSize);

        tmp = Marshal.AllocHGlobal(size);

        for (int i = 0; i < count; i++)
        {
          Marshal.Copy(data, i * size, tmp, size);
          result[i] = Marshal.PtrToStructure<T>(tmp);
        }

        Marshal.FreeHGlobal(tmp);
        return result;
    }


    [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi )]
    private struct __sklib_vector_string    {
      internal IntPtr _data_from_app;
      public __sklib_string[] data_from_app
      {
        set
        {
          _data_from_app = ToIntPtr(value);
        }
      }
      public uint size_from_app;
      private IntPtr _data_from_lib;
      public __sklib_string[] data_from_lib
      {
        get
        {
          return FromIntPtr<__sklib_string>(_data_from_lib, (int)size_from_lib);
        }
      }
      public uint size_from_lib;
    }

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free__sklib_vector_string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free__sklib_vector_string(__sklib_vector_string v);

    private static void __skadapter__free__sklib_vector_string(ref __sklib_vector_string v)
    {
      // System.Console.WriteLine("Freeing data");
      Marshal.FreeHGlobal(v._data_from_app);
    }
    private static __sklib_vector_string __skadapter__to_sklib_vector_string(List<string> v)
    {
      int i = 0;
      __sklib_vector_string result = new __sklib_vector_string();

      result.size_from_lib = 0;
      result.size_from_app = (uint)v.Count;
      __sklib_string[] tmp = new __sklib_string[result.size_from_app];

      foreach(string d in v)
      {
        tmp[i] = __skadapter__to_sklib_string(v[i]);
        i++;
      }

      result.data_from_app = tmp;
      return result;
    }
    private static List<string> __skadapter__to_vector_string(__sklib_vector_string v)
    {
      List<string> result = new List<string>();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        result.Add(__skadapter__to_string(v.data_from_lib[i]));
      }
      __sklib__free__sklib_vector_string(v);
      return result;
    }
    private static void __skadapter__update_from_vector_string(ref __sklib_vector_string v, List<string> __skreturn)
    {
      __skreturn.Clear();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        __skreturn.Add(__skadapter__to_string(v.data_from_lib[i]));
      }
            __sklib__free__sklib_vector_string(v);
    }

    [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi )]
    private struct __sklib_vector_line    {
      internal IntPtr _data_from_app;
      public __sklib_line[] data_from_app
      {
        set
        {
          _data_from_app = ToIntPtr(value);
        }
      }
      public uint size_from_app;
      private IntPtr _data_from_lib;
      public __sklib_line[] data_from_lib
      {
        get
        {
          return FromIntPtr<__sklib_line>(_data_from_lib, (int)size_from_lib);
        }
      }
      public uint size_from_lib;
    }

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free__sklib_vector_line", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free__sklib_vector_line(__sklib_vector_line v);

    private static void __skadapter__free__sklib_vector_line(ref __sklib_vector_line v)
    {
      // System.Console.WriteLine("Freeing data");
      Marshal.FreeHGlobal(v._data_from_app);
    }
    private static __sklib_vector_line __skadapter__to_sklib_vector_line(List<Line> v)
    {
      int i = 0;
      __sklib_vector_line result = new __sklib_vector_line();

      result.size_from_lib = 0;
      result.size_from_app = (uint)v.Count;
      __sklib_line[] tmp = new __sklib_line[result.size_from_app];

      foreach(Line d in v)
      {
        tmp[i] = __skadapter__to_sklib_line(v[i]);
        i++;
      }

      result.data_from_app = tmp;
      return result;
    }
    private static List<Line> __skadapter__to_vector_line(__sklib_vector_line v)
    {
      List<Line> result = new List<Line>();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        result.Add(__skadapter__to_line(v.data_from_lib[i]));
      }
      __sklib__free__sklib_vector_line(v);
      return result;
    }
    private static void __skadapter__update_from_vector_line(ref __sklib_vector_line v, List<Line> __skreturn)
    {
      __skreturn.Clear();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        __skreturn.Add(__skadapter__to_line(v.data_from_lib[i]));
      }
            __sklib__free__sklib_vector_line(v);
    }

    [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi )]
    private struct __sklib_vector_int8_t    {
      internal IntPtr _data_from_app;
      public byte[] data_from_app
      {
        set
        {
          _data_from_app = ToIntPtr(value);
        }
      }
      public uint size_from_app;
      private IntPtr _data_from_lib;
      public byte[] data_from_lib
      {
        get
        {
          return FromIntPtr<byte>(_data_from_lib, (int)size_from_lib);
        }
      }
      public uint size_from_lib;
    }

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free__sklib_vector_int8_t", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free__sklib_vector_int8_t(__sklib_vector_int8_t v);

    private static void __skadapter__free__sklib_vector_int8_t(ref __sklib_vector_int8_t v)
    {
      // System.Console.WriteLine("Freeing data");
      Marshal.FreeHGlobal(v._data_from_app);
    }
    private static __sklib_vector_int8_t __skadapter__to_sklib_vector_int8_t(List<byte> v)
    {
      int i = 0;
      __sklib_vector_int8_t result = new __sklib_vector_int8_t();

      result.size_from_lib = 0;
      result.size_from_app = (uint)v.Count;
      byte[] tmp = new byte[result.size_from_app];

      foreach(byte d in v)
      {
        tmp[i] = __skadapter__to_sklib_int8_t(v[i]);
        i++;
      }

      result.data_from_app = tmp;
      return result;
    }
    private static List<byte> __skadapter__to_vector_int8_t(__sklib_vector_int8_t v)
    {
      List<byte> result = new List<byte>();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        result.Add(__skadapter__to_int8_t(v.data_from_lib[i]));
      }
      __sklib__free__sklib_vector_int8_t(v);
      return result;
    }
    private static void __skadapter__update_from_vector_int8_t(ref __sklib_vector_int8_t v, List<byte> __skreturn)
    {
      __skreturn.Clear();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        __skreturn.Add(__skadapter__to_int8_t(v.data_from_lib[i]));
      }
            __sklib__free__sklib_vector_int8_t(v);
    }

    [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi )]
    private struct __sklib_vector_triangle    {
      internal IntPtr _data_from_app;
      public __sklib_triangle[] data_from_app
      {
        set
        {
          _data_from_app = ToIntPtr(value);
        }
      }
      public uint size_from_app;
      private IntPtr _data_from_lib;
      public __sklib_triangle[] data_from_lib
      {
        get
        {
          return FromIntPtr<__sklib_triangle>(_data_from_lib, (int)size_from_lib);
        }
      }
      public uint size_from_lib;
    }

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free__sklib_vector_triangle", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free__sklib_vector_triangle(__sklib_vector_triangle v);

    private static void __skadapter__free__sklib_vector_triangle(ref __sklib_vector_triangle v)
    {
      // System.Console.WriteLine("Freeing data");
      Marshal.FreeHGlobal(v._data_from_app);
    }
    private static __sklib_vector_triangle __skadapter__to_sklib_vector_triangle(List<Triangle> v)
    {
      int i = 0;
      __sklib_vector_triangle result = new __sklib_vector_triangle();

      result.size_from_lib = 0;
      result.size_from_app = (uint)v.Count;
      __sklib_triangle[] tmp = new __sklib_triangle[result.size_from_app];

      foreach(Triangle d in v)
      {
        tmp[i] = __skadapter__to_sklib_triangle(v[i]);
        i++;
      }

      result.data_from_app = tmp;
      return result;
    }
    private static List<Triangle> __skadapter__to_vector_triangle(__sklib_vector_triangle v)
    {
      List<Triangle> result = new List<Triangle>();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        result.Add(__skadapter__to_triangle(v.data_from_lib[i]));
      }
      __sklib__free__sklib_vector_triangle(v);
      return result;
    }
    private static void __skadapter__update_from_vector_triangle(ref __sklib_vector_triangle v, List<Triangle> __skreturn)
    {
      __skreturn.Clear();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        __skreturn.Add(__skadapter__to_triangle(v.data_from_lib[i]));
      }
            __sklib__free__sklib_vector_triangle(v);
    }

    [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi )]
    private struct __sklib_vector_double    {
      internal IntPtr _data_from_app;
      public double[] data_from_app
      {
        set
        {
          _data_from_app = ToIntPtr(value);
        }
      }
      public uint size_from_app;
      private IntPtr _data_from_lib;
      public double[] data_from_lib
      {
        get
        {
          return FromIntPtr<double>(_data_from_lib, (int)size_from_lib);
        }
      }
      public uint size_from_lib;
    }

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free__sklib_vector_double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free__sklib_vector_double(__sklib_vector_double v);

    private static void __skadapter__free__sklib_vector_double(ref __sklib_vector_double v)
    {
      // System.Console.WriteLine("Freeing data");
      Marshal.FreeHGlobal(v._data_from_app);
    }
    private static __sklib_vector_double __skadapter__to_sklib_vector_double(List<double> v)
    {
      int i = 0;
      __sklib_vector_double result = new __sklib_vector_double();

      result.size_from_lib = 0;
      result.size_from_app = (uint)v.Count;
      double[] tmp = new double[result.size_from_app];

      foreach(double d in v)
      {
        tmp[i] = __skadapter__to_sklib_double(v[i]);
        i++;
      }

      result.data_from_app = tmp;
      return result;
    }
    private static List<double> __skadapter__to_vector_double(__sklib_vector_double v)
    {
      List<double> result = new List<double>();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        result.Add(__skadapter__to_double(v.data_from_lib[i]));
      }
      __sklib__free__sklib_vector_double(v);
      return result;
    }
    private static void __skadapter__update_from_vector_double(ref __sklib_vector_double v, List<double> __skreturn)
    {
      __skreturn.Clear();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        __skreturn.Add(__skadapter__to_double(v.data_from_lib[i]));
      }
            __sklib__free__sklib_vector_double(v);
    }

    [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi )]
    private struct __sklib_vector_json    {
      internal IntPtr _data_from_app;
      public __sklib_ptr[] data_from_app
      {
        set
        {
          _data_from_app = ToIntPtr(value);
        }
      }
      public uint size_from_app;
      private IntPtr _data_from_lib;
      public __sklib_ptr[] data_from_lib
      {
        get
        {
          return FromIntPtr<__sklib_ptr>(_data_from_lib, (int)size_from_lib);
        }
      }
      public uint size_from_lib;
    }

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free__sklib_vector_json", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free__sklib_vector_json(__sklib_vector_json v);

    private static void __skadapter__free__sklib_vector_json(ref __sklib_vector_json v)
    {
      // System.Console.WriteLine("Freeing data");
      Marshal.FreeHGlobal(v._data_from_app);
    }
    private static __sklib_vector_json __skadapter__to_sklib_vector_json(List<Json> v)
    {
      int i = 0;
      __sklib_vector_json result = new __sklib_vector_json();

      result.size_from_lib = 0;
      result.size_from_app = (uint)v.Count;
      __sklib_ptr[] tmp = new __sklib_ptr[result.size_from_app];

      foreach(Json d in v)
      {
        tmp[i] = __skadapter__to_sklib_json(v[i]);
        i++;
      }

      result.data_from_app = tmp;
      return result;
    }
    private static List<Json> __skadapter__to_vector_json(__sklib_vector_json v)
    {
      List<Json> result = new List<Json>();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        result.Add(__skadapter__to_json(v.data_from_lib[i]));
      }
      __sklib__free__sklib_vector_json(v);
      return result;
    }
    private static void __skadapter__update_from_vector_json(ref __sklib_vector_json v, List<Json> __skreturn)
    {
      __skreturn.Clear();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        __skreturn.Add(__skadapter__to_json(v.data_from_lib[i]));
      }
            __sklib__free__sklib_vector_json(v);
    }

    [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi )]
    private struct __sklib_vector_bool    {
      internal IntPtr _data_from_app;
      public int[] data_from_app
      {
        set
        {
          _data_from_app = ToIntPtr(value);
        }
      }
      public uint size_from_app;
      private IntPtr _data_from_lib;
      public int[] data_from_lib
      {
        get
        {
          return FromIntPtr<int>(_data_from_lib, (int)size_from_lib);
        }
      }
      public uint size_from_lib;
    }

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free__sklib_vector_bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free__sklib_vector_bool(__sklib_vector_bool v);

    private static void __skadapter__free__sklib_vector_bool(ref __sklib_vector_bool v)
    {
      // System.Console.WriteLine("Freeing data");
      Marshal.FreeHGlobal(v._data_from_app);
    }
    private static __sklib_vector_bool __skadapter__to_sklib_vector_bool(List<bool> v)
    {
      int i = 0;
      __sklib_vector_bool result = new __sklib_vector_bool();

      result.size_from_lib = 0;
      result.size_from_app = (uint)v.Count;
      int[] tmp = new int[result.size_from_app];

      foreach(bool d in v)
      {
        tmp[i] = __skadapter__to_sklib_bool(v[i]);
        i++;
      }

      result.data_from_app = tmp;
      return result;
    }
    private static List<bool> __skadapter__to_vector_bool(__sklib_vector_bool v)
    {
      List<bool> result = new List<bool>();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        result.Add(__skadapter__to_bool(v.data_from_lib[i]));
      }
      __sklib__free__sklib_vector_bool(v);
      return result;
    }
    private static void __skadapter__update_from_vector_bool(ref __sklib_vector_bool v, List<bool> __skreturn)
    {
      __skreturn.Clear();
      for (int i = 0; i < v.size_from_lib; i++)
      {
        __skreturn.Add(__skadapter__to_bool(v.data_from_lib[i]));
      }
            __sklib__free__sklib_vector_bool(v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static KeyCallback __skadapter__to_sklib_key_callback(KeyCallback v) { return v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FreeNotifier __skadapter__to_sklib_free_notifier(FreeNotifier v) { return v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static SpriteEventHandler __skadapter__to_sklib_sprite_event_handler(SpriteEventHandler v) { return v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static SpriteFloatFunction __skadapter__to_sklib_sprite_float_function(SpriteFloatFunction v) { return v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static SpriteFunction __skadapter__to_sklib_sprite_function(SpriteFunction v) { return v; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_json(Json v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Json __skadapter__to_json(IntPtr v) { return Json.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_music(Music v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Music __skadapter__to_music(IntPtr v) { return Music.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_connection(Connection v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Connection __skadapter__to_connection(IntPtr v) { return Connection.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_message(Message v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Message __skadapter__to_message(IntPtr v) { return Message.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_server_socket(ServerSocket v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ServerSocket __skadapter__to_server_socket(IntPtr v) { return ServerSocket.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_sound_effect(SoundEffect v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static SoundEffect __skadapter__to_sound_effect(IntPtr v) { return SoundEffect.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_sprite(Sprite v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Sprite __skadapter__to_sprite(IntPtr v) { return Sprite.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_timer(Timer v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Timer __skadapter__to_timer(IntPtr v) { return Timer.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_animation(Animation v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Animation __skadapter__to_animation(IntPtr v) { return Animation.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_animation_script(AnimationScript v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static AnimationScript __skadapter__to_animation_script(IntPtr v) { return AnimationScript.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_bitmap(Bitmap v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Bitmap __skadapter__to_bitmap(IntPtr v) { return Bitmap.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_display(Display v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Display __skadapter__to_display(IntPtr v) { return Display.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_font(Font v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Font __skadapter__to_font(IntPtr v) { return Font.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_http_response(HttpResponse v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static HttpResponse __skadapter__to_http_response(IntPtr v) { return HttpResponse.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_http_request(HttpRequest v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static HttpRequest __skadapter__to_http_request(IntPtr v) { return HttpRequest.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_web_server(WebServer v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static WebServer __skadapter__to_web_server(IntPtr v) { return WebServer.FetchOrCreate(v); }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr __skadapter__to_sklib_window(Window v) { return v; }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Window __skadapter__to_window(IntPtr v) { return Window.FetchOrCreate(v); }
    
    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__animation_count__animation_script", CharSet=CharSet.Ansi)]
    private static extern int __sklib__animation_count__animation_script(__sklib_ptr script);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__animation_current_cell__animation", CharSet=CharSet.Ansi)]
    private static extern int __sklib__animation_current_cell__animation(__sklib_ptr anim);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__animation_current_vector__animation", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__animation_current_vector__animation(__sklib_ptr anim);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__animation_ended__animation", CharSet=CharSet.Ansi)]
    private static extern int __sklib__animation_ended__animation(__sklib_ptr anim);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__animation_entered_frame__animation", CharSet=CharSet.Ansi)]
    private static extern int __sklib__animation_entered_frame__animation(__sklib_ptr anim);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__animation_frame_time__animation", CharSet=CharSet.Ansi)]
    private static extern float __sklib__animation_frame_time__animation(__sklib_ptr anim);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__animation_index__animation_script__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__animation_index__animation_script__string_ref(__sklib_ptr script, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__animation_name__animation", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__animation_name__animation(__sklib_ptr temp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__animation_script_name__animation_script", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__animation_script_name__animation_script(__sklib_ptr script);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__animation_script_named__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__animation_script_named__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__assign_animation__animation__animation_script__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__assign_animation__animation__animation_script__string_ref(__sklib_ptr anim, __sklib_ptr script, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__assign_animation__animation__animation_script__string_ref__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__assign_animation__animation__animation_script__string_ref__bool(__sklib_ptr anim, __sklib_ptr script, __sklib_string name, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__assign_animation__animation__animation_script__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__assign_animation__animation__animation_script__int(__sklib_ptr anim, __sklib_ptr script, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__assign_animation__animation__animation_script__int__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__assign_animation__animation__animation_script__int__bool(__sklib_ptr anim, __sklib_ptr script, int idx, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__assign_animation__animation__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__assign_animation__animation__string_ref__string_ref(__sklib_ptr anim, __sklib_string scriptName, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__assign_animation__animation__string_ref__string_ref__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__assign_animation__animation__string_ref__string_ref__bool(__sklib_ptr anim, __sklib_string scriptName, __sklib_string name, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__assign_animation__animation__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__assign_animation__animation__int(__sklib_ptr anim, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__assign_animation__animation__int__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__assign_animation__animation__int__bool(__sklib_ptr anim, int idx, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__assign_animation__animation__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__assign_animation__animation__string(__sklib_ptr anim, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__assign_animation__animation__string__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__assign_animation__animation__string__bool(__sklib_ptr anim, __sklib_string name, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_animation__animation_script__int__bool", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_animation__animation_script__int__bool(__sklib_ptr script, int idx, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_animation__animation_script__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_animation__animation_script__string_ref(__sklib_ptr script, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_animation__animation_script__string_ref__bool", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_animation__animation_script__string_ref__bool(__sklib_ptr script, __sklib_string name, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_animation__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_animation__string_ref__string_ref(__sklib_string scriptName, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_animation__string_ref__string_ref__bool", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_animation__string_ref__string_ref__bool(__sklib_string scriptName, __sklib_string name, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_all_animation_scripts", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_all_animation_scripts();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_animation__animation", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_animation__animation(__sklib_ptr ani);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_animation_script__animation_script", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_animation_script__animation_script(__sklib_ptr scriptToFree);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_animation_script__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_animation_script__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_animation_named__animation_script__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_animation_named__animation_script__string_ref(__sklib_ptr script, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_animation_script__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_animation_script__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__load_animation_script__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__load_animation_script__string_ref__string_ref(__sklib_string name, __sklib_string filename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__restart_animation__animation", CharSet=CharSet.Ansi)]
    private static extern void __sklib__restart_animation__animation(__sklib_ptr anim);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__restart_animation__animation__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__restart_animation__animation__bool(__sklib_ptr anim, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_animation__animation__float__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_animation__animation__float__bool(__sklib_ptr anim, float pct, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_animation__animation", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_animation__animation(__sklib_ptr anim);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_animation__animation__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_animation__animation__float(__sklib_ptr anim, float pct);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__audio_ready", CharSet=CharSet.Ansi)]
    private static extern int __sklib__audio_ready();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_audio", CharSet=CharSet.Ansi)]
    private static extern void __sklib__close_audio();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__open_audio", CharSet=CharSet.Ansi)]
    private static extern void __sklib__open_audio();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__contains__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__contains__string_ref__string_ref(__sklib_string text, __sklib_string subtext);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__convert_to_double__string_ref", CharSet=CharSet.Ansi)]
    private static extern double __sklib__convert_to_double__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__convert_to_integer__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__convert_to_integer__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__index_of__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__index_of__string_ref__string_ref(__sklib_string text, __sklib_string subtext);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_double__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_double__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_integer__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_integer__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_number__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_number__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__length_of__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__length_of__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__replace_all__string_ref__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__replace_all__string_ref__string_ref__string_ref(__sklib_string text, __sklib_string substr, __sklib_string newtext);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__split__string_ref__char", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_string __sklib__split__string_ref__char(__sklib_string text, char delimiter);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__to_lowercase__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__to_lowercase__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__to_uppercase__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__to_uppercase__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__trim__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__trim__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_resource_bundle__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_resource_bundle__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_resource_bundle__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_resource_bundle__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__load_resource_bundle__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__load_resource_bundle__string_ref__string_ref(__sklib_string name, __sklib_string filename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__camera_position", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__camera_position();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__camera_x", CharSet=CharSet.Ansi)]
    private static extern double __sklib__camera_x();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__camera_y", CharSet=CharSet.Ansi)]
    private static extern double __sklib__camera_y();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__center_camera_on__sprite__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__center_camera_on__sprite__vector_2d_ref(__sklib_ptr s, __sklib_vector_2d offset);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__center_camera_on__sprite__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__center_camera_on__sprite__double__double(__sklib_ptr s, double offsetX, double offsetY);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_camera_by__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_camera_by__vector_2d_ref(__sklib_vector_2d offset);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_camera_by__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_camera_by__double__double(double dx, double dy);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_camera_to__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_camera_to__point_2d_ref(__sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_camera_to__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_camera_to__double__double(double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_in_window__window__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__point_in_window__window__point_2d_ref(__sklib_ptr wind, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_on_screen__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__point_on_screen__point_2d_ref(__sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rect_in_window__window__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__rect_in_window__window__rectangle_ref(__sklib_ptr wind, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rect_on_screen__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__rect_on_screen__rectangle_ref(__sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__screen_center", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__screen_center();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__screen_rectangle", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__screen_rectangle();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_camera_position__point_2d", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_camera_position__point_2d(__sklib_point_2d pos);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_camera_x__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_camera_x__double(double x);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_camera_y__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_camera_y__double(double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__to_screen__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__to_screen__point_2d_ref(__sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__to_screen__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__to_screen__rectangle_ref(__sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__to_screen_x__double", CharSet=CharSet.Ansi)]
    private static extern double __sklib__to_screen_x__double(double worldX);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__to_screen_y__double", CharSet=CharSet.Ansi)]
    private static extern double __sklib__to_screen_y__double(double worldY);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__to_world__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__to_world__point_2d_ref(__sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__to_world_x__double", CharSet=CharSet.Ansi)]
    private static extern double __sklib__to_world_x__double(double screenX);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__to_world_y__double", CharSet=CharSet.Ansi)]
    private static extern double __sklib__to_world_y__double(double screenY);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_world_to_screen", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_world_to_screen();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_area__window", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__window_area__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_circle__color__circle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_circle__color__circle_ref(__sklib_color clr, __sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_circle__color__circle_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_circle__color__circle_ref__drawing_options(__sklib_color clr, __sklib_circle c, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_circle__color__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_circle__color__double__double__double(__sklib_color clr, double x, double y, double radius);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_circle__color__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_circle__color__double__double__double__drawing_options(__sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_circle_on_bitmap__bitmap__color__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_circle_on_bitmap__bitmap__color__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double radius);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_circle_on_bitmap__bitmap__color__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_circle_on_window__window__color__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_circle_on_window__window__color__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double radius);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_circle_on_window__window__color__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_circle_on_window__window__color__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_circle__color__circle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_circle__color__circle_ref(__sklib_color clr, __sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_circle__color__circle_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_circle__color__circle_ref__drawing_options(__sklib_color clr, __sklib_circle c, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_circle__color__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_circle__color__double__double__double(__sklib_color clr, double x, double y, double radius);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_circle__color__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_circle__color__double__double__double__drawing_options(__sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_circle_on_bitmap__bitmap__color__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_circle_on_bitmap__bitmap__color__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double radius);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_circle_on_bitmap__bitmap__color__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_circle_on_window__window__color__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_circle_on_window__window__color__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double radius);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_circle_on_window__window__color__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_circle_on_window__window__color__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, double radius, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__center_point__circle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__center_point__circle_ref(__sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__circle_at__point_2d_ref__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_circle __sklib__circle_at__point_2d_ref__double(__sklib_point_2d pt, double radius);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__circle_at__double__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_circle __sklib__circle_at__double__double__double(double x, double y, double radius);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__circle_radius__circle", CharSet=CharSet.Ansi)]
    private static extern float __sklib__circle_radius__circle(__sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__circle_triangle_intersect__circle_ref__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__circle_triangle_intersect__circle_ref__triangle_ref(__sklib_circle c, __sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__circle_triangle_intersect__circle_ref__triangle_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__circle_triangle_intersect__circle_ref__triangle_ref__point_2d_ref(__sklib_circle c, __sklib_triangle tri, ref __sklib_point_2d p);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__circle_x__circle_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__circle_x__circle_ref(__sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__circle_y__circle_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__circle_y__circle_ref(__sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__circles_intersect__circle__circle", CharSet=CharSet.Ansi)]
    private static extern int __sklib__circles_intersect__circle__circle(__sklib_circle c1, __sklib_circle c2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__circles_intersect__double__double__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__circles_intersect__double__double__double__double__double__double(double c1X, double c1Y, double c1Radius, double c2X, double c2Y, double c2Radius);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__closest_point_on_circle__point_2d_ref__circle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__closest_point_on_circle__point_2d_ref__circle_ref(__sklib_point_2d fromPt, __sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__closest_point_on_line_from_circle__circle_ref__line_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__closest_point_on_line_from_circle__circle_ref__line_ref(__sklib_circle c, __sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__closest_point_on_rect_from_circle__circle_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__closest_point_on_rect_from_circle__circle_ref__rectangle_ref(__sklib_circle c, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__closest_point_on_triangle_from_circle__circle_ref__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__closest_point_on_triangle_from_circle__circle_ref__triangle_ref(__sklib_circle c, __sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__distant_point_on_circle__point_2d_ref__circle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__distant_point_on_circle__point_2d_ref__circle_ref(__sklib_point_2d pt, __sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__distant_point_on_circle_heading__point_2d_ref__circle_ref__vector_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__distant_point_on_circle_heading__point_2d_ref__circle_ref__vector_2d_ref__point_2d_ref(__sklib_point_2d pt, __sklib_circle c, __sklib_vector_2d heading, ref __sklib_point_2d oppositePt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__ray_circle_intersect_distance__point_2d_ref__vector_2d_ref__circle_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__ray_circle_intersect_distance__point_2d_ref__vector_2d_ref__circle_ref(__sklib_point_2d rayOrigin, __sklib_vector_2d rayHeading, __sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__tangent_points__point_2d_ref__circle_ref__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__tangent_points__point_2d_ref__circle_ref__point_2d_ref__point_2d_ref(__sklib_point_2d fromPt, __sklib_circle c, ref __sklib_point_2d p1, ref __sklib_point_2d p2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__widest_points__circle_ref__vector_2d_ref__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__widest_points__circle_ref__vector_2d_ref__point_2d_ref__point_2d_ref(__sklib_circle c, __sklib_vector_2d along, ref __sklib_point_2d pt1, ref __sklib_point_2d pt2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_clip", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__current_clip();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_clip__bitmap", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__current_clip__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_clip__window", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__current_clip__window(__sklib_ptr wnd);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__pop_clip__window", CharSet=CharSet.Ansi)]
    private static extern void __sklib__pop_clip__window(__sklib_ptr wnd);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__pop_clip", CharSet=CharSet.Ansi)]
    private static extern void __sklib__pop_clip();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__pop_clip__bitmap", CharSet=CharSet.Ansi)]
    private static extern void __sklib__pop_clip__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__push_clip__window__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__push_clip__window__rectangle_ref(__sklib_ptr wnd, __sklib_rectangle r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__push_clip__bitmap__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__push_clip__bitmap__rectangle_ref(__sklib_ptr bmp, __sklib_rectangle r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__push_clip__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__push_clip__rectangle_ref(__sklib_rectangle r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reset_clip__bitmap", CharSet=CharSet.Ansi)]
    private static extern void __sklib__reset_clip__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reset_clip", CharSet=CharSet.Ansi)]
    private static extern void __sklib__reset_clip();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reset_clip__window", CharSet=CharSet.Ansi)]
    private static extern void __sklib__reset_clip__window(__sklib_ptr wnd);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_clip__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_clip__rectangle_ref(__sklib_rectangle r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_clip__bitmap__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_clip__bitmap__rectangle_ref(__sklib_ptr bmp, __sklib_rectangle r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_clip__window__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_clip__window__rectangle_ref(__sklib_ptr wnd, __sklib_rectangle r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_circle_collision__bitmap__point_2d_ref__circle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_circle_collision__bitmap__point_2d_ref__circle_ref(__sklib_ptr bmp, __sklib_point_2d pt, __sklib_circle circ);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_circle_collision__bitmap__double__double__circle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_circle_collision__bitmap__double__double__circle_ref(__sklib_ptr bmp, double x, double y, __sklib_circle circ);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_circle_collision__bitmap__int__matrix_2d_ref__circle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_circle_collision__bitmap__int__matrix_2d_ref__circle_ref(__sklib_ptr bmp, int cell, __sklib_matrix_2d translation, __sklib_circle circ);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_circle_collision__bitmap__int__point_2d_ref__circle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_circle_collision__bitmap__int__point_2d_ref__circle_ref(__sklib_ptr bmp, int cell, __sklib_point_2d pt, __sklib_circle circ);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_circle_collision__bitmap__int__double__double__circle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_circle_collision__bitmap__int__double__double__circle_ref(__sklib_ptr bmp, int cell, double x, double y, __sklib_circle circ);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_collision__bitmap__double__double__bitmap__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_collision__bitmap__double__double__bitmap__double__double(__sklib_ptr bmp1, double x1, double y1, __sklib_ptr bmp2, double x2, double y2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_collision__bitmap__point_2d_ref__bitmap__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_collision__bitmap__point_2d_ref__bitmap__point_2d_ref(__sklib_ptr bmp1, __sklib_point_2d pt1, __sklib_ptr bmp2, __sklib_point_2d pt2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_collision__bitmap__int__matrix_2d_ref__bitmap__int__matrix_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_collision__bitmap__int__matrix_2d_ref__bitmap__int__matrix_2d_ref(__sklib_ptr bmp1, int cell1, __sklib_matrix_2d matrix1, __sklib_ptr bmp2, int cell2, __sklib_matrix_2d matrix2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_collision__bitmap__int__point_2d_ref__bitmap__int__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_collision__bitmap__int__point_2d_ref__bitmap__int__point_2d_ref(__sklib_ptr bmp1, int cell1, __sklib_point_2d pt1, __sklib_ptr bmp2, int cell2, __sklib_point_2d pt2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_collision__bitmap__int__double__double__bitmap__int__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_collision__bitmap__int__double__double__bitmap__int__double__double(__sklib_ptr bmp1, int cell1, double x1, double y1, __sklib_ptr bmp2, int cell2, double x2, double y2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_point_collision__bitmap__matrix_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_point_collision__bitmap__matrix_2d_ref__point_2d_ref(__sklib_ptr bmp, __sklib_matrix_2d translation, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_point_collision__bitmap__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_point_collision__bitmap__point_2d_ref__point_2d_ref(__sklib_ptr bmp, __sklib_point_2d bmpPt, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_point_collision__bitmap__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_point_collision__bitmap__double__double__double__double(__sklib_ptr bmp, double bmpX, double bmpY, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_point_collision__bitmap__int__matrix_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_point_collision__bitmap__int__matrix_2d_ref__point_2d_ref(__sklib_ptr bmp, int cell, __sklib_matrix_2d translation, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_point_collision__bitmap__int__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_point_collision__bitmap__int__point_2d_ref__point_2d_ref(__sklib_ptr bmp, int cell, __sklib_point_2d bmpPt, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_point_collision__bitmap__int__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_point_collision__bitmap__int__double__double__double__double(__sklib_ptr bmp, int cell, double bmpX, double bmpY, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_rectangle_collision__bitmap__point_2d_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_rectangle_collision__bitmap__point_2d_ref__rectangle_ref(__sklib_ptr bmp, __sklib_point_2d pt, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_rectangle_collision__bitmap__double__double__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_rectangle_collision__bitmap__double__double__rectangle_ref(__sklib_ptr bmp, double x, double y, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_rectangle_collision__bitmap__int__matrix_2d_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_rectangle_collision__bitmap__int__matrix_2d_ref__rectangle_ref(__sklib_ptr bmp, int cell, __sklib_matrix_2d translation, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_rectangle_collision__bitmap__int__point_2d_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_rectangle_collision__bitmap__int__point_2d_ref__rectangle_ref(__sklib_ptr bmp, int cell, __sklib_point_2d pt, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_rectangle_collision__bitmap__int__double__double__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_rectangle_collision__bitmap__int__double__double__rectangle_ref(__sklib_ptr bmp, int cell, double x, double y, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_bitmap_collision__sprite__bitmap__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_bitmap_collision__sprite__bitmap__double__double(__sklib_ptr s, __sklib_ptr bmp, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_bitmap_collision__sprite__bitmap__int__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_bitmap_collision__sprite__bitmap__int__point_2d_ref(__sklib_ptr s, __sklib_ptr bmp, int cell, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_bitmap_collision__sprite__bitmap__int__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_bitmap_collision__sprite__bitmap__int__double__double(__sklib_ptr s, __sklib_ptr bmp, int cell, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_collision__sprite__sprite", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_collision__sprite__sprite(__sklib_ptr s1, __sklib_ptr s2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_point_collision__sprite__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_point_collision__sprite__point_2d_ref(__sklib_ptr s, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_rectangle_collision__sprite__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_rectangle_collision__sprite__rectangle_ref(__sklib_ptr s, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__alpha_of__color", CharSet=CharSet.Ansi)]
    private static extern int __sklib__alpha_of__color(__sklib_color c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__blue_of__color", CharSet=CharSet.Ansi)]
    private static extern int __sklib__blue_of__color(__sklib_color c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__brightness_of__color", CharSet=CharSet.Ansi)]
    private static extern double __sklib__brightness_of__color(__sklib_color c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_alice_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_alice_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_antique_white", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_antique_white();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_aqua", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_aqua();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_aquamarine", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_aquamarine();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_azure", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_azure();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_beige", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_beige();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_bisque", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_bisque();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_black", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_black();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_blanched_almond", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_blanched_almond();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_blue_violet", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_blue_violet();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_bright_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_bright_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_brown", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_brown();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_burly_wood", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_burly_wood();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_cadet_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_cadet_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_chartreuse", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_chartreuse();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_chocolate", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_chocolate();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_coral", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_coral();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_cornflower_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_cornflower_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_cornsilk", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_cornsilk();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_crimson", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_crimson();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_cyan", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_cyan();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_cyan", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_cyan();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_goldenrod", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_goldenrod();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_gray", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_gray();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_khaki", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_khaki();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_magenta", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_magenta();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_olive_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_olive_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_orange", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_orange();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_orchid", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_orchid();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_red", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_red();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_salmon", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_salmon();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_sea_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_sea_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_slate_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_slate_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_slate_gray", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_slate_gray();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_turquoise", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_turquoise();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dark_violet", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dark_violet();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_deep_pink", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_deep_pink();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_deep_sky_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_deep_sky_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dim_gray", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dim_gray();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_dodger_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_dodger_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_firebrick", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_firebrick();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_floral_white", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_floral_white();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_forest_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_forest_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_fuchsia", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_fuchsia();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_gainsboro", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_gainsboro();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_ghost_white", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_ghost_white();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_gold", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_gold();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_goldenrod", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_goldenrod();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_gray", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_gray();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_green_yellow", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_green_yellow();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_honeydew", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_honeydew();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_hot_pink", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_hot_pink();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_indian_red", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_indian_red();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_indigo", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_indigo();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_ivory", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_ivory();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_khaki", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_khaki();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_lavender", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_lavender();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_lavender_blush", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_lavender_blush();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_lawn_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_lawn_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_lemon_chiffon", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_lemon_chiffon();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_coral", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_coral();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_cyan", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_cyan();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_goldenrod_yellow", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_goldenrod_yellow();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_gray", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_gray();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_pink", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_pink();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_salmon", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_salmon();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_sea_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_sea_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_sky_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_sky_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_slate_gray", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_slate_gray();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_steel_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_steel_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_light_yellow", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_light_yellow();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_lime", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_lime();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_lime_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_lime_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_linen", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_linen();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_magenta", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_magenta();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_maroon", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_maroon();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_medium_aquamarine", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_medium_aquamarine();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_medium_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_medium_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_medium_orchid", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_medium_orchid();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_medium_purple", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_medium_purple();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_medium_sea_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_medium_sea_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_medium_slate_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_medium_slate_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_medium_spring_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_medium_spring_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_medium_turquoise", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_medium_turquoise();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_medium_violet_red", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_medium_violet_red();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_midnight_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_midnight_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_mint_cream", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_mint_cream();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_misty_rose", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_misty_rose();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_moccasin", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_moccasin();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_navajo_white", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_navajo_white();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_navy", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_navy();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_old_lace", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_old_lace();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_olive", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_olive();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_olive_drab", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_olive_drab();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_orange", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_orange();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_orange_red", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_orange_red();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_orchid", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_orchid();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_pale_goldenrod", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_pale_goldenrod();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_pale_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_pale_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_pale_turquoise", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_pale_turquoise();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_pale_violet_red", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_pale_violet_red();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_papaya_whip", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_papaya_whip();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_peach_puff", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_peach_puff();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_peru", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_peru();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_pink", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_pink();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_plum", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_plum();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_powder_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_powder_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_purple", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_purple();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_red", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_red();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_rosy_brown", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_rosy_brown();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_royal_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_royal_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_saddle_brown", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_saddle_brown();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_salmon", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_salmon();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_sandy_brown", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_sandy_brown();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_sea_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_sea_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_sea_shell", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_sea_shell();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_sienna", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_sienna();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_silver", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_silver();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_sky_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_sky_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_slate_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_slate_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_slate_gray", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_slate_gray();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_snow", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_snow();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_spring_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_spring_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_steel_blue", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_steel_blue();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_swinburne_red", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_swinburne_red();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_tan", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_tan();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_teal", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_teal();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_thistle", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_thistle();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_to_string__color", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__color_to_string__color(__sklib_color c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_tomato", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_tomato();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_transparent", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_transparent();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_turquoise", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_turquoise();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_violet", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_violet();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_wheat", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_wheat();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_white", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_white();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_white_smoke", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_white_smoke();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_yellow", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_yellow();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_yellow_green", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_yellow_green();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__green_of__color", CharSet=CharSet.Ansi)]
    private static extern int __sklib__green_of__color(__sklib_color c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__hsb_color__double__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__hsb_color__double__double__double(double hue, double saturation, double brightness);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__hue_of__color", CharSet=CharSet.Ansi)]
    private static extern double __sklib__hue_of__color(__sklib_color c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__random_color", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__random_color();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__random_rgb_color__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__random_rgb_color__int(int alpha);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__red_of__color", CharSet=CharSet.Ansi)]
    private static extern int __sklib__red_of__color(__sklib_color c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rgb_color__double__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__rgb_color__double__double__double(double red, double green, double blue);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rgb_color__int__int__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__rgb_color__int__int__int(int red, int green, int blue);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rgba_color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__rgba_color__double__double__double__double(double red, double green, double blue, double alpha);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rgba_color__int__int__int__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__rgba_color__int__int__int__int(int red, int green, int blue, int alpha);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__saturation_of__color", CharSet=CharSet.Ansi)]
    private static extern double __sklib__saturation_of__color(__sklib_color c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__string_to_color__string", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__string_to_color__string(__sklib_string str);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_defaults", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_defaults();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_draw_to__bitmap", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_draw_to__bitmap(__sklib_ptr dest);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_draw_to__bitmap__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_draw_to__bitmap__drawing_options(__sklib_ptr dest, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_draw_to__window", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_draw_to__window(__sklib_ptr dest);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_draw_to__window__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_draw_to__window__drawing_options(__sklib_ptr dest, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_flip_x", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_flip_x();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_flip_x__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_flip_x__drawing_options(__sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_flip_xy", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_flip_xy();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_flip_xy__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_flip_xy__drawing_options(__sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_flip_y", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_flip_y();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_flip_y__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_flip_y__drawing_options(__sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_line_width__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_line_width__int(int width);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_line_width__int__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_line_width__int__drawing_options(int width, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_part_bmp__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_part_bmp__double__double__double__double(double x, double y, double w, double h);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_part_bmp__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_part_bmp__double__double__double__double__drawing_options(double x, double y, double w, double h, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_part_bmp__rectangle", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_part_bmp__rectangle(__sklib_rectangle part);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_part_bmp__rectangle__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_part_bmp__rectangle__drawing_options(__sklib_rectangle part, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_rotate_bmp__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_rotate_bmp__double(double angle);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_rotate_bmp__double__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_rotate_bmp__double__double__double(double angle, double anchorX, double anchorY);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_rotate_bmp__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_rotate_bmp__double__double__double__drawing_options(double angle, double anchorX, double anchorY, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_rotate_bmp__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_rotate_bmp__double__drawing_options(double angle, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_scale_bmp__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_scale_bmp__double__double(double scaleX, double scaleY);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_scale_bmp__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_scale_bmp__double__double__drawing_options(double scaleX, double scaleY, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_to_screen", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_to_screen();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_to_screen__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_to_screen__drawing_options(__sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_to_world", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_to_world();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_to_world__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_to_world__drawing_options(__sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_with_animation__animation", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_with_animation__animation(__sklib_ptr anim);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_with_animation__animation__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_with_animation__animation__drawing_options(__sklib_ptr anim, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_with_bitmap_cell__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_with_bitmap_cell__int(int cell);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__option_with_bitmap_cell__int__drawing_options", CharSet=CharSet.Ansi)]
    private static extern __sklib_drawing_options __sklib__option_with_bitmap_cell__int__drawing_options(int cell, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse__color__rectangle", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse__color__rectangle(__sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse__color__rectangle__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse__color__rectangle__drawing_options(__sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse__color__double__double__double__double(__sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse__color__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse__color__double__double__double__double__drawing_options(__sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse_on_window__window__color__rectangle", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse_on_window__window__color__rectangle(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse_on_window__window__color__rectangle__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse_on_window__window__color__rectangle__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse_on_window__window__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse_on_window__window__color__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_ellipse_on_window__window__color__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_ellipse_on_window__window__color__double__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse__color__rectangle", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse__color__rectangle(__sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse__color__rectangle__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse__color__rectangle__drawing_options(__sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse__color__double__double__double__double(__sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse__color__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse__color__double__double__double__double__drawing_options(__sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse_on_window__window__color__rectangle", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse_on_window__window__color__rectangle(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse_on_window__window__color__rectangle__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse_on_window__window__color__rectangle__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse_on_window__window__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse_on_window__window__color__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_ellipse_on_window__window__color__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_ellipse_on_window__window__color__double__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__cosine__float", CharSet=CharSet.Ansi)]
    private static extern float __sklib__cosine__float(float degrees);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sine__float", CharSet=CharSet.Ansi)]
    private static extern float __sklib__sine__float(float degrees);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__tangent__float", CharSet=CharSet.Ansi)]
    private static extern float __sklib__tangent__float(float degrees);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__clear_screen", CharSet=CharSet.Ansi)]
    private static extern void __sklib__clear_screen();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__clear_screen__color", CharSet=CharSet.Ansi)]
    private static extern void __sklib__clear_screen__color(__sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__display_details__unsigned_int", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__display_details__unsigned_int(uint index);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__display_height__display", CharSet=CharSet.Ansi)]
    private static extern int __sklib__display_height__display(__sklib_ptr disp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__display_name__display", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__display_name__display(__sklib_ptr disp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__display_width__display", CharSet=CharSet.Ansi)]
    private static extern int __sklib__display_width__display(__sklib_ptr disp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__display_x__display", CharSet=CharSet.Ansi)]
    private static extern int __sklib__display_x__display(__sklib_ptr disp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__display_y__display", CharSet=CharSet.Ansi)]
    private static extern int __sklib__display_y__display(__sklib_ptr disp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__number_of_displays", CharSet=CharSet.Ansi)]
    private static extern int __sklib__number_of_displays();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__refresh_screen", CharSet=CharSet.Ansi)]
    private static extern void __sklib__refresh_screen();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__refresh_screen__unsigned_int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__refresh_screen__unsigned_int(uint targetFps);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__save_bitmap__bitmap__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__save_bitmap__bitmap__string_ref(__sklib_ptr bmp, __sklib_string basename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__screen_height", CharSet=CharSet.Ansi)]
    private static extern int __sklib__screen_height();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__screen_width", CharSet=CharSet.Ansi)]
    private static extern int __sklib__screen_width();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__take_screenshot__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__take_screenshot__string_ref(__sklib_string basename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__take_screenshot__window__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__take_screenshot__window__string_ref(__sklib_ptr wind, __sklib_string basename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_bounding_circle__bitmap__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_circle __sklib__bitmap_bounding_circle__bitmap__point_2d_ref(__sklib_ptr bmp, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_bounding_rectangle__bitmap", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__bitmap_bounding_rectangle__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_bounding_rectangle__bitmap__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__bitmap_bounding_rectangle__bitmap__double__double(__sklib_ptr bmp, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_center__bitmap", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__bitmap_cell_center__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_circle__bitmap__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_circle __sklib__bitmap_cell_circle__bitmap__double__double(__sklib_ptr bmp, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_circle__bitmap__point_2d", CharSet=CharSet.Ansi)]
    private static extern __sklib_circle __sklib__bitmap_cell_circle__bitmap__point_2d(__sklib_ptr bmp, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_circle__bitmap__point_2d__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_circle __sklib__bitmap_cell_circle__bitmap__point_2d__double(__sklib_ptr bmp, __sklib_point_2d pt, double scale);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_columns__bitmap", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_cell_columns__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_count__bitmap", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_cell_count__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_height__bitmap", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_cell_height__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_offset__bitmap__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__bitmap_cell_offset__bitmap__int(__sklib_ptr src, int cell);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_rectangle__bitmap", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__bitmap_cell_rectangle__bitmap(__sklib_ptr src);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_rectangle__bitmap__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__bitmap_cell_rectangle__bitmap__point_2d_ref(__sklib_ptr src, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_rows__bitmap", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_cell_rows__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_cell_width__bitmap", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_cell_width__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_center__bitmap", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__bitmap_center__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_filename__bitmap", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__bitmap_filename__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_height__bitmap", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_height__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_height__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_height__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_name__bitmap", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__bitmap_name__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_named__string", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__bitmap_named__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_rectangle_of_cell__bitmap__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__bitmap_rectangle_of_cell__bitmap__int(__sklib_ptr src, int cell);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_set_cell_details__bitmap__int__int__int__int__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__bitmap_set_cell_details__bitmap__int__int__int__int__int(__sklib_ptr bmp, int width, int height, int columns, int rows, int count);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_valid__bitmap", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_valid__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_width__bitmap", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_width__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_width__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_width__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__clear_bitmap__bitmap__color", CharSet=CharSet.Ansi)]
    private static extern void __sklib__clear_bitmap__bitmap__color(__sklib_ptr bmp, __sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__clear_bitmap__string__color", CharSet=CharSet.Ansi)]
    private static extern void __sklib__clear_bitmap__string__color(__sklib_string name, __sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_bitmap__string__int__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_bitmap__string__int__int(__sklib_string name, int width, int height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_bitmap__bitmap__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_bitmap__bitmap__double__double(__sklib_ptr bmp, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_bitmap__bitmap__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_bitmap__bitmap__double__double__drawing_options(__sklib_ptr bmp, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_bitmap__string__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_bitmap__string__double__double(__sklib_string name, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_bitmap__string__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_bitmap__string__double__double__drawing_options(__sklib_string name, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double(__sklib_ptr destination, __sklib_ptr bmp, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double__drawing_options(__sklib_ptr destination, __sklib_ptr bmp, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_bitmap_on_window__window__bitmap__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_bitmap_on_window__window__bitmap__double__double(__sklib_ptr destination, __sklib_ptr bmp, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_bitmap_on_window__window__bitmap__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_bitmap_on_window__window__bitmap__double__double__drawing_options(__sklib_ptr destination, __sklib_ptr bmp, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_all_bitmaps", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_all_bitmaps();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_bitmap__bitmap", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_bitmap__bitmap(__sklib_ptr toDelete);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_bitmap__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_bitmap__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__load_bitmap__string__string", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__load_bitmap__string__string(__sklib_string name, __sklib_string filename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__pixel_drawn_at_point__bitmap__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__pixel_drawn_at_point__bitmap__point_2d_ref(__sklib_ptr bmp, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__pixel_drawn_at_point__bitmap__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__pixel_drawn_at_point__bitmap__double__double(__sklib_ptr bmp, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__pixel_drawn_at_point__bitmap__int__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__pixel_drawn_at_point__bitmap__int__point_2d_ref(__sklib_ptr bmp, int cell, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__pixel_drawn_at_point__bitmap__int__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__pixel_drawn_at_point__bitmap__int__double__double(__sklib_ptr bmp, int cell, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__setup_collision_mask__bitmap", CharSet=CharSet.Ansi)]
    private static extern void __sklib__setup_collision_mask__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__process_events", CharSet=CharSet.Ansi)]
    private static extern void __sklib__process_events();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__quit_requested", CharSet=CharSet.Ansi)]
    private static extern int __sklib__quit_requested();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reset_quit", CharSet=CharSet.Ansi)]
    private static extern void __sklib__reset_quit();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__add_column__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__add_column__int(int width);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__add_column_relative__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__add_column_relative__double(double width);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_button__bitmap", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_button__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_button__bitmap__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_button__bitmap__rectangle_ref(__sklib_ptr bmp, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_button__bitmap__rectangle_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_button__bitmap__rectangle_ref__drawing_options(__sklib_ptr bmp, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_button__bitmap__drawing_options", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_button__bitmap__drawing_options(__sklib_ptr bmp, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_button__string_ref__bitmap", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_button__string_ref__bitmap(__sklib_string labelText, __sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__bitmap_button__string_ref__bitmap__drawing_options", CharSet=CharSet.Ansi)]
    private static extern int __sklib__bitmap_button__string_ref__bitmap__drawing_options(__sklib_string labelText, __sklib_ptr bmp, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__button__string_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__button__string_ref__rectangle_ref(__sklib_string text, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__button__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__button__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__button__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__button__string_ref__string_ref(__sklib_string labelText, __sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__checkbox__string_ref__bool_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__checkbox__string_ref__bool_ref__rectangle_ref(__sklib_string text, int value, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__checkbox__string_ref__bool_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__checkbox__string_ref__bool_ref(__sklib_string text, int value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__checkbox__string_ref__string_ref__bool_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__checkbox__string_ref__string_ref__bool_ref(__sklib_string labelText, __sklib_string text, int value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_slider__color_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_slider__color_ref__rectangle_ref(__sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_slider__color_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_slider__color_ref(__sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__color_slider__string_ref__color_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__color_slider__string_ref__color_ref(__sklib_string labelText, __sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__disable_interface", CharSet=CharSet.Ansi)]
    private static extern void __sklib__disable_interface();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_interface", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_interface();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__enable_interface", CharSet=CharSet.Ansi)]
    private static extern void __sklib__enable_interface();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__end_inset__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__end_inset__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__end_panel__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__end_panel__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__end_popup__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__end_popup__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__end_treenode__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__end_treenode__string_ref(__sklib_string labelText);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__enter_column", CharSet=CharSet.Ansi)]
    private static extern void __sklib__enter_column();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_interface_label_width", CharSet=CharSet.Ansi)]
    private static extern int __sklib__get_interface_label_width();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__header__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__header__string_ref(__sklib_string labelText);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__hsb_color_slider__color_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__hsb_color_slider__color_ref__rectangle_ref(__sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__hsb_color_slider__color_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__hsb_color_slider__color_ref(__sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__hsb_color_slider__string_ref__color_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__hsb_color_slider__string_ref__color_ref(__sklib_string labelText, __sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__interface_enabled", CharSet=CharSet.Ansi)]
    private static extern int __sklib__interface_enabled();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__interface_style_panel__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__interface_style_panel__rectangle_ref(__sklib_rectangle initialRectangle);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__label_element__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__label_element__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__label_element__string_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__label_element__string_ref__rectangle_ref(__sklib_string text, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__last_element_changed", CharSet=CharSet.Ansi)]
    private static extern int __sklib__last_element_changed();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__last_element_confirmed", CharSet=CharSet.Ansi)]
    private static extern int __sklib__last_element_confirmed();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__leave_column", CharSet=CharSet.Ansi)]
    private static extern void __sklib__leave_column();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__number_box__float_ref__float__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__number_box__float_ref__float__rectangle_ref(float value, float step, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__number_box__float_ref__float", CharSet=CharSet.Ansi)]
    private static extern float __sklib__number_box__float_ref__float(float value, float step);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__number_box__string_ref__float_ref__float", CharSet=CharSet.Ansi)]
    private static extern float __sklib__number_box__string_ref__float_ref__float(__sklib_string labelText, float value, float step);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__open_popup__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__open_popup__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__paragraph__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__paragraph__string_ref(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__paragraph__string_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__paragraph__string_ref__rectangle_ref(__sklib_string text, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reset_layout", CharSet=CharSet.Ansi)]
    private static extern void __sklib__reset_layout();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_accent_color__color__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_accent_color__color__float(__sklib_color clr, float contrast);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_border_color__color", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_border_color__color(__sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_colors_auto__color__color__float__float__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_colors_auto__color__color__float__float__float(__sklib_color mainClr, __sklib_color accentClr, float contrast, float accentContrast, float borderContrast);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_element_color__color__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_element_color__color__float(__sklib_color clr, float contrast);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_element_shadows__int__color__point_2d", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_element_shadows__int__color__point_2d(int radius, __sklib_color clr, __sklib_point_2d offset);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_font__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_font__string_ref(__sklib_string fnt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_font__font", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_font__font(__sklib_ptr fnt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_font_size__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_font_size__int(int size);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_label_width__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_label_width__int(int width);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_panel_shadows__int__color__point_2d", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_panel_shadows__int__color__point_2d(int radius, __sklib_color clr, __sklib_point_2d offset);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_root_text_color__color", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_root_text_color__color(__sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_shadows__int__color__point_2d", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_shadows__int__color__point_2d(int radius, __sklib_color clr, __sklib_point_2d offset);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_spacing__int__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_spacing__int__int(int spacing, int padding);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_style__interface_style", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_style__interface_style(int style);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_style__interface_style__color", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_style__interface_style__color(int style, __sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_interface_text_color__color", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_interface_text_color__color(__sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_layout_height__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_layout_height__int(int height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__single_line_layout", CharSet=CharSet.Ansi)]
    private static extern void __sklib__single_line_layout();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__slider__float_ref__float__float__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__slider__float_ref__float__float__rectangle_ref(float value, float minValue, float maxValue, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__slider__float_ref__float__float", CharSet=CharSet.Ansi)]
    private static extern float __sklib__slider__float_ref__float__float(float value, float minValue, float maxValue);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__slider__string_ref__float_ref__float__float", CharSet=CharSet.Ansi)]
    private static extern float __sklib__slider__string_ref__float_ref__float__float(__sklib_string labelText, float value, float minValue, float maxValue);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__split_into_columns__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__split_into_columns__int(int count);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__split_into_columns__int__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__split_into_columns__int__int(int count, int lastWidth);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__split_into_columns_relative__int__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__split_into_columns_relative__int__double(int count, double lastWidth);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_custom_layout", CharSet=CharSet.Ansi)]
    private static extern void __sklib__start_custom_layout();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_inset__string_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__start_inset__string_ref__rectangle_ref(__sklib_string name, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_inset__string_ref__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__start_inset__string_ref__int(__sklib_string name, int height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_panel__string_ref__rectangle", CharSet=CharSet.Ansi)]
    private static extern int __sklib__start_panel__string_ref__rectangle(__sklib_string name, __sklib_rectangle initialRectangle);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_popup__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__start_popup__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_treenode__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__start_treenode__string_ref(__sklib_string labelText);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__text_box__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__text_box__string_ref(__sklib_string value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__text_box__string_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__text_box__string_ref__rectangle_ref(__sklib_string value, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__text_box__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__text_box__string_ref__string_ref(__sklib_string labelText, __sklib_string value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_json", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_json();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_json__string", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_json__string(__sklib_string jsonString);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_all_json", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_all_json();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_json__json", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_json__json(__sklib_ptr j);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_count_keys__json", CharSet=CharSet.Ansi)]
    private static extern int __sklib__json_count_keys__json(__sklib_ptr j);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_from_color__color", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__json_from_color__color(__sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_from_file__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__json_from_file__string_ref(__sklib_string filename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_from_string__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__json_from_string__string_ref(__sklib_string jString);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_has_key__json__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__json_has_key__json__string(__sklib_ptr j, __sklib_string key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_read_array__json__string__vector_double_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_read_array__json__string__vector_double_ref(__sklib_ptr j, __sklib_string key, ref __sklib_vector_double outResult);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_read_array__json__string__vector_json_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_read_array__json__string__vector_json_ref(__sklib_ptr j, __sklib_string key, ref __sklib_vector_json outResult);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_read_array__json__string__vector_string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_read_array__json__string__vector_string_ref(__sklib_ptr j, __sklib_string key, ref __sklib_vector_string outResult);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_read_array__json__string__vector_bool_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_read_array__json__string__vector_bool_ref(__sklib_ptr j, __sklib_string key, ref __sklib_vector_bool outResult);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_read_bool__json__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__json_read_bool__json__string(__sklib_ptr j, __sklib_string key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_read_number__json__string", CharSet=CharSet.Ansi)]
    private static extern float __sklib__json_read_number__json__string(__sklib_ptr j, __sklib_string key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_read_number_as_double__json__string", CharSet=CharSet.Ansi)]
    private static extern double __sklib__json_read_number_as_double__json__string(__sklib_ptr j, __sklib_string key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_read_number_as_int__json__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__json_read_number_as_int__json__string(__sklib_ptr j, __sklib_string key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_read_object__json__string", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__json_read_object__json__string(__sklib_ptr j, __sklib_string key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_read_string__json__string", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__json_read_string__json__string(__sklib_ptr j, __sklib_string key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_set_array__json__string__vector_string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_set_array__json__string__vector_string(__sklib_ptr j, __sklib_string key, __sklib_vector_string value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_set_array__json__string__vector_double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_set_array__json__string__vector_double(__sklib_ptr j, __sklib_string key, __sklib_vector_double value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_set_array__json__string__vector_bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_set_array__json__string__vector_bool(__sklib_ptr j, __sklib_string key, __sklib_vector_bool value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_set_array__json__string__vector_json", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_set_array__json__string__vector_json(__sklib_ptr j, __sklib_string key, __sklib_vector_json value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_set_bool__json__string__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_set_bool__json__string__bool(__sklib_ptr j, __sklib_string key, int value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_set_number__json__string__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_set_number__json__string__int(__sklib_ptr j, __sklib_string key, int value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_set_number__json__string__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_set_number__json__string__double(__sklib_ptr j, __sklib_string key, double value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_set_number__json__string__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_set_number__json__string__float(__sklib_ptr j, __sklib_string key, float value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_set_object__json__string__json", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_set_object__json__string__json(__sklib_ptr j, __sklib_string key, __sklib_ptr obj);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_set_string__json__string__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_set_string__json__string__string(__sklib_ptr j, __sklib_string key, __sklib_string value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_to_color__json", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__json_to_color__json(__sklib_ptr j);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_to_file__json__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__json_to_file__json__string_ref(__sklib_ptr j, __sklib_string filename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__json_to_string__json", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__json_to_string__json(__sklib_ptr j);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__any_key_pressed", CharSet=CharSet.Ansi)]
    private static extern int __sklib__any_key_pressed();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__deregister_callback_on_key_down__key_callback_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__deregister_callback_on_key_down__key_callback_ptr(KeyCallback callback);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__deregister_callback_on_key_typed__key_callback_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__deregister_callback_on_key_typed__key_callback_ptr(KeyCallback callback);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__deregister_callback_on_key_up__key_callback_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__deregister_callback_on_key_up__key_callback_ptr(KeyCallback callback);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__key_down__key_code", CharSet=CharSet.Ansi)]
    private static extern int __sklib__key_down__key_code(int key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__key_name__key_code", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__key_name__key_code(int key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__key_released__key_code", CharSet=CharSet.Ansi)]
    private static extern int __sklib__key_released__key_code(int key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__key_typed__key_code", CharSet=CharSet.Ansi)]
    private static extern int __sklib__key_typed__key_code(int key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__key_up__key_code", CharSet=CharSet.Ansi)]
    private static extern int __sklib__key_up__key_code(int key);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__register_callback_on_key_down__key_callback_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__register_callback_on_key_down__key_callback_ptr(KeyCallback callback);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__register_callback_on_key_typed__key_callback_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__register_callback_on_key_typed__key_callback_ptr(KeyCallback callback);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__register_callback_on_key_up__key_callback_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__register_callback_on_key_up__key_callback_ptr(KeyCallback callback);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line__color__line_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line__color__line_ref(__sklib_color clr, __sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line__color__line_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line__color__line_ref__drawing_options(__sklib_color clr, __sklib_line l, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line__color__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line__color__point_2d_ref__point_2d_ref(__sklib_color clr, __sklib_point_2d fromPt, __sklib_point_2d toPt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line__color__point_2d_ref__point_2d_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line__color__point_2d_ref__point_2d_ref__drawing_options_ref(__sklib_color clr, __sklib_point_2d fromPt, __sklib_point_2d toPt, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line__color__double__double__double__double(__sklib_color clr, double x1, double y1, double x2, double y2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line__color__double__double__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line__color__double__double__double__double__drawing_options_ref(__sklib_color clr, double x1, double y1, double x2, double y2, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_bitmap__bitmap__color__line_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_bitmap__bitmap__color__line_ref(__sklib_ptr destination, __sklib_color clr, __sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_bitmap__bitmap__color__line_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_bitmap__bitmap__color__line_ref__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_line l, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref(__sklib_ptr destination, __sklib_color clr, __sklib_point_2d fromPt, __sklib_point_2d toPt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, __sklib_point_2d fromPt, __sklib_point_2d toPt, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_window__window__color__line_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_window__window__color__line_ref(__sklib_ptr destination, __sklib_color clr, __sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_window__window__color__line_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_window__window__color__line_ref__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_line l, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref(__sklib_ptr destination, __sklib_color clr, __sklib_point_2d fromPt, __sklib_point_2d toPt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, __sklib_point_2d fromPt, __sklib_point_2d toPt, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_window__window__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_window__window__color__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_line_on_window__window__color__double__double__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_line_on_window__window__color__double__double__double__double__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__closest_point_on_line__point_2d__line_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__closest_point_on_line__point_2d__line_ref(__sklib_point_2d fromPt, __sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__closest_point_on_lines__point_2d__vector_line_ref__int_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__closest_point_on_lines__point_2d__vector_line_ref__int_ref(__sklib_point_2d fromPt, __sklib_vector_line lines, ref int lineIdx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_from__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_line __sklib__line_from__point_2d_ref__point_2d_ref(__sklib_point_2d start, __sklib_point_2d endPt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_from__point_2d_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_line __sklib__line_from__point_2d_ref__vector_2d_ref(__sklib_point_2d start, __sklib_vector_2d offset);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_from__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_line __sklib__line_from__vector_2d_ref(__sklib_vector_2d v);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_from__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_line __sklib__line_from__double__double__double__double(double x1, double y1, double x2, double y2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_intersection_point__line_ref__line_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__line_intersection_point__line_ref__line_ref__point_2d_ref(__sklib_line line1, __sklib_line line2, ref __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_intersects_circle__line_ref__circle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__line_intersects_circle__line_ref__circle_ref(__sklib_line l, __sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_intersects_lines__line_ref__vector_line_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__line_intersects_lines__line_ref__vector_line_ref(__sklib_line l, __sklib_vector_line lines);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_intersects_rect__line_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__line_intersects_rect__line_ref__rectangle_ref(__sklib_line l, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_length__line_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__line_length__line_ref(__sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_length_squared__line_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__line_length_squared__line_ref(__sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_mid_point__line_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__line_mid_point__line_ref(__sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_normal__line_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__line_normal__line_ref(__sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__line_to_string__line_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__line_to_string__line_ref(__sklib_line ln);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__lines_from__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_line __sklib__lines_from__rectangle_ref(__sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__lines_from__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_line __sklib__lines_from__triangle_ref(__sklib_triangle t);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__lines_intersect__line_ref__line_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__lines_intersect__line_ref__line_ref(__sklib_line l1, __sklib_line l2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_log_process", CharSet=CharSet.Ansi)]
    private static extern void __sklib__close_log_process();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__init_custom_logger__log_mode", CharSet=CharSet.Ansi)]
    private static extern void __sklib__init_custom_logger__log_mode(int mode);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__init_custom_logger__string__bool__log_mode", CharSet=CharSet.Ansi)]
    private static extern void __sklib__init_custom_logger__string__bool__log_mode(__sklib_string appName, int overridePrevLog, int mode);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__log__log_level__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__log__log_level__string(int level, __sklib_string message);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__apply_matrix__matrix_2d_ref__quad_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__apply_matrix__matrix_2d_ref__quad_ref(__sklib_matrix_2d matrix, ref __sklib_quad q);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__apply_matrix__matrix_2d_ref__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__apply_matrix__matrix_2d_ref__triangle_ref(__sklib_matrix_2d m, ref __sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__identity_matrix", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__identity_matrix();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__matrix_inverse__matrix_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__matrix_inverse__matrix_2d_ref(__sklib_matrix_2d m);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__matrix_multiply__matrix_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__matrix_multiply__matrix_2d_ref__point_2d_ref(__sklib_matrix_2d m, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__matrix_multiply__matrix_2d_ref__matrix_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__matrix_multiply__matrix_2d_ref__matrix_2d_ref(__sklib_matrix_2d m1, __sklib_matrix_2d m2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__matrix_multiply__matrix_2d_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__matrix_multiply__matrix_2d_ref__vector_2d_ref(__sklib_matrix_2d m, __sklib_vector_2d v);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__matrix_to_string__matrix_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__matrix_to_string__matrix_2d_ref(__sklib_matrix_2d matrix);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rotation_matrix__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__rotation_matrix__double(double deg);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__scale_matrix__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__scale_matrix__point_2d_ref(__sklib_point_2d scale);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__scale_matrix__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__scale_matrix__vector_2d_ref(__sklib_vector_2d scale);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__scale_matrix__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__scale_matrix__double(double scale);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__scale_rotate_translate_matrix__point_2d_ref__double__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__scale_rotate_translate_matrix__point_2d_ref__double__point_2d_ref(__sklib_point_2d scale, double deg, __sklib_point_2d translate);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__translation_matrix__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__translation_matrix__point_2d_ref(__sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__translation_matrix__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__translation_matrix__vector_2d_ref(__sklib_vector_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__translation_matrix__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__translation_matrix__double__double(double dx, double dy);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__hide_mouse", CharSet=CharSet.Ansi)]
    private static extern void __sklib__hide_mouse();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__mouse_clicked__mouse_button", CharSet=CharSet.Ansi)]
    private static extern int __sklib__mouse_clicked__mouse_button(int button);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__mouse_down__mouse_button", CharSet=CharSet.Ansi)]
    private static extern int __sklib__mouse_down__mouse_button(int button);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__mouse_movement", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__mouse_movement();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__mouse_position", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__mouse_position();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__mouse_position_vector", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__mouse_position_vector();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__mouse_shown", CharSet=CharSet.Ansi)]
    private static extern int __sklib__mouse_shown();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__mouse_up__mouse_button", CharSet=CharSet.Ansi)]
    private static extern int __sklib__mouse_up__mouse_button(int button);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__mouse_wheel_scroll", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__mouse_wheel_scroll();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__mouse_x", CharSet=CharSet.Ansi)]
    private static extern float __sklib__mouse_x();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__mouse_y", CharSet=CharSet.Ansi)]
    private static extern float __sklib__mouse_y();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_mouse__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_mouse__double__double(double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_mouse__point_2d", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_mouse__point_2d(__sklib_point_2d point);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__show_mouse", CharSet=CharSet.Ansi)]
    private static extern void __sklib__show_mouse();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__show_mouse__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__show_mouse__bool(int show);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fade_music_in__string_ref__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fade_music_in__string_ref__int(__sklib_string name, int ms);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fade_music_in__string_ref__int__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fade_music_in__string_ref__int__int(__sklib_string name, int times, int ms);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fade_music_in__music__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fade_music_in__music__int(__sklib_ptr data, int ms);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fade_music_in__music__int__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fade_music_in__music__int__int(__sklib_ptr data, int times, int ms);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fade_music_out__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fade_music_out__int(int ms);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_all_music", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_all_music();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_music__music", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_music__music(__sklib_ptr effect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_music__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_music__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__load_music__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__load_music__string_ref__string_ref(__sklib_string name, __sklib_string filename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__music_filename__music", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__music_filename__music(__sklib_ptr data);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__music_name__music", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__music_name__music(__sklib_ptr data);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__music_named__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__music_named__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__music_playing", CharSet=CharSet.Ansi)]
    private static extern int __sklib__music_playing();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__music_valid__music", CharSet=CharSet.Ansi)]
    private static extern int __sklib__music_valid__music(__sklib_ptr m);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__music_volume", CharSet=CharSet.Ansi)]
    private static extern double __sklib__music_volume();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__pause_music", CharSet=CharSet.Ansi)]
    private static extern void __sklib__pause_music();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_music__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_music__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_music__string_ref__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_music__string_ref__int(__sklib_string name, int times);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_music__music", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_music__music(__sklib_ptr data);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_music__music__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_music__music__int(__sklib_ptr data, int times);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_music__music__int__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_music__music__int__double(__sklib_ptr data, int times, double volume);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__resume_music", CharSet=CharSet.Ansi)]
    private static extern void __sklib__resume_music();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_music_volume__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_music_volume__double(double volume);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__stop_music", CharSet=CharSet.Ansi)]
    private static extern void __sklib__stop_music();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__accept_all_new_connections", CharSet=CharSet.Ansi)]
    private static extern int __sklib__accept_all_new_connections();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__accept_new_connection__server_socket", CharSet=CharSet.Ansi)]
    private static extern int __sklib__accept_new_connection__server_socket(__sklib_ptr server);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__broadcast_message__string_ref__server_socket", CharSet=CharSet.Ansi)]
    private static extern void __sklib__broadcast_message__string_ref__server_socket(__sklib_string aMsg, __sklib_ptr svr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__broadcast_message__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__broadcast_message__string_ref(__sklib_string aMsg);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__broadcast_message__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__broadcast_message__string_ref__string_ref(__sklib_string aMsg, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__check_network_activity", CharSet=CharSet.Ansi)]
    private static extern void __sklib__check_network_activity();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__clear_messages__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__clear_messages__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__clear_messages__connection", CharSet=CharSet.Ansi)]
    private static extern void __sklib__clear_messages__connection(__sklib_ptr aConnection);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__clear_messages__server_socket", CharSet=CharSet.Ansi)]
    private static extern void __sklib__clear_messages__server_socket(__sklib_ptr svr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_all_connections", CharSet=CharSet.Ansi)]
    private static extern void __sklib__close_all_connections();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_all_servers", CharSet=CharSet.Ansi)]
    private static extern void __sklib__close_all_servers();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_connection__connection", CharSet=CharSet.Ansi)]
    private static extern int __sklib__close_connection__connection(__sklib_ptr aConnection);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_connection__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__close_connection__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_message__message", CharSet=CharSet.Ansi)]
    private static extern void __sklib__close_message__message(__sklib_ptr msg);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_server__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__close_server__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_server__server_socket", CharSet=CharSet.Ansi)]
    private static extern int __sklib__close_server__server_socket(__sklib_ptr svr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__connection_count__string_ref", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__connection_count__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__connection_count__server_socket", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__connection_count__server_socket(__sklib_ptr server);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__connection_ip__connection", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__connection_ip__connection(__sklib_ptr aConnection);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__connection_ip__string_ref", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__connection_ip__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__connection_named__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__connection_named__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__connection_port__connection", CharSet=CharSet.Ansi)]
    private static extern ushort __sklib__connection_port__connection(__sklib_ptr aConnection);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__connection_port__string_ref", CharSet=CharSet.Ansi)]
    private static extern ushort __sklib__connection_port__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_server__string_ref__unsigned_short", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_server__string_ref__unsigned_short(__sklib_string name, ushort port);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_server__string_ref__unsigned_short__connection_type", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_server__string_ref__unsigned_short__connection_type(__sklib_string name, ushort port, int protocol);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__dec_to_hex__unsigned_int", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__dec_to_hex__unsigned_int(uint aDec);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fetch_new_connection__server_socket", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__fetch_new_connection__server_socket(__sklib_ptr server);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_connection__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_connection__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_messages", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_messages();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_messages__connection", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_messages__connection(__sklib_ptr con);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_messages__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_messages__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_messages__server_socket", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_messages__server_socket(__sklib_ptr svr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_new_connections", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_new_connections();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_server__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_server__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__hex_str_to_ipv4__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__hex_str_to_ipv4__string_ref(__sklib_string aHex);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__hex_to_dec_string__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__hex_to_dec_string__string_ref(__sklib_string aHex);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__ipv4_to_dec__string_ref", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__ipv4_to_dec__string_ref(__sklib_string aIP);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__ipv4_to_hex__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__ipv4_to_hex__string_ref(__sklib_string aIP);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__ipv4_to_str__unsigned_int", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__ipv4_to_str__unsigned_int(uint ip);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_connection_open__connection", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_connection_open__connection(__sklib_ptr con);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_connection_open__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_connection_open__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__last_connection__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__last_connection__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__last_connection__server_socket", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__last_connection__server_socket(__sklib_ptr server);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__message_connection__message", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__message_connection__message(__sklib_ptr msg);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__message_count__server_socket", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__message_count__server_socket(__sklib_ptr svr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__message_count__connection", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__message_count__connection(__sklib_ptr aConnection);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__message_count__string_ref", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__message_count__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__message_data__message", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__message_data__message(__sklib_ptr msg);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__message_data_bytes__message", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_int8_t __sklib__message_data_bytes__message(__sklib_ptr msg);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__message_host__message", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__message_host__message(__sklib_ptr msg);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__message_port__message", CharSet=CharSet.Ansi)]
    private static extern ushort __sklib__message_port__message(__sklib_ptr msg);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__message_protocol__message", CharSet=CharSet.Ansi)]
    private static extern int __sklib__message_protocol__message(__sklib_ptr msg);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__my_ip", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__my_ip();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__name_for_connection__string__unsigned_int", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__name_for_connection__string__unsigned_int(__sklib_string host, uint port);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__new_connection_count__server_socket", CharSet=CharSet.Ansi)]
    private static extern int __sklib__new_connection_count__server_socket(__sklib_ptr server);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__open_connection__string_ref__string_ref__unsigned_short", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__open_connection__string_ref__string_ref__unsigned_short(__sklib_string name, __sklib_string host, ushort port);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__open_connection__string_ref__string_ref__unsigned_short__connection_type", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__open_connection__string_ref__string_ref__unsigned_short__connection_type(__sklib_string name, __sklib_string host, ushort port, int protocol);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__read_message", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__read_message();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__read_message__connection", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__read_message__connection(__sklib_ptr aConnection);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__read_message__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__read_message__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__read_message__server_socket", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__read_message__server_socket(__sklib_ptr svr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__read_message_data__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__read_message_data__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__read_message_data__connection", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__read_message_data__connection(__sklib_ptr aConnection);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__read_message_data__server_socket", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__read_message_data__server_socket(__sklib_ptr svr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reconnect__connection", CharSet=CharSet.Ansi)]
    private static extern void __sklib__reconnect__connection(__sklib_ptr aConnection);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reconnect__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__reconnect__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__release_all_connections", CharSet=CharSet.Ansi)]
    private static extern void __sklib__release_all_connections();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reset_new_connection_count__server_socket", CharSet=CharSet.Ansi)]
    private static extern void __sklib__reset_new_connection_count__server_socket(__sklib_ptr server);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__retrieve_connection__string_ref__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__retrieve_connection__string_ref__int(__sklib_string name, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__retrieve_connection__server_socket__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__retrieve_connection__server_socket__int(__sklib_ptr server, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_message_to__string_ref__connection", CharSet=CharSet.Ansi)]
    private static extern int __sklib__send_message_to__string_ref__connection(__sklib_string aMsg, __sklib_ptr aConnection);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_message_to__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__send_message_to__string_ref__string_ref(__sklib_string aMsg, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__server_has_new_connection__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__server_has_new_connection__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__server_has_new_connection__server_socket", CharSet=CharSet.Ansi)]
    private static extern int __sklib__server_has_new_connection__server_socket(__sklib_ptr server);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__server_named__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__server_named__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_udp_packet_size__unsigned_int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_udp_packet_size__unsigned_int(uint udpPacketSize);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__udp_packet_size", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__udp_packet_size();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel__color__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel__color__point_2d_ref(__sklib_color clr, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel__color__point_2d_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel__color__point_2d_ref__drawing_options(__sklib_color clr, __sklib_point_2d pt, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel__color__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel__color__double__double(__sklib_color clr, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel__color__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel__color__double__double__drawing_options(__sklib_color clr, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref(__sklib_ptr destination, __sklib_color clr, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_point_2d pt, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel_on_bitmap__bitmap__color__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel_on_bitmap__bitmap__color__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel_on_bitmap__bitmap__color__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel_on_bitmap__bitmap__color__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel_on_window__window__color__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel_on_window__window__color__point_2d_ref(__sklib_ptr destination, __sklib_color clr, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel_on_window__window__color__point_2d_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel_on_window__window__color__point_2d_ref__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_point_2d pt, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel_on_window__window__color__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel_on_window__window__color__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_pixel_on_window__window__color__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_pixel_on_window__window__color__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_pixel__bitmap__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__get_pixel__bitmap__point_2d_ref(__sklib_ptr bmp, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_pixel__bitmap__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__get_pixel__bitmap__double__double(__sklib_ptr bmp, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_pixel__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__get_pixel__point_2d_ref(__sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_pixel__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__get_pixel__double__double(double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_pixel__window__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__get_pixel__window__point_2d_ref(__sklib_ptr wnd, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_pixel__window__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__get_pixel__window__double__double(__sklib_ptr wnd, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_pixel_from_window__window__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__get_pixel_from_window__window__point_2d_ref(__sklib_ptr destination, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_pixel_from_window__window__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_color __sklib__get_pixel_from_window__window__double__double(__sklib_ptr destination, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_at__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__point_at__double__double(double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_at_origin", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__point_at_origin();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_in_circle__point_2d_ref__circle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__point_in_circle__point_2d_ref__circle_ref(__sklib_point_2d pt, __sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_in_circle__double__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__point_in_circle__double__double__double__double__double(double ptx, double pty, double cx, double cy, double radius);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_in_quad__point_2d_ref__quad_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__point_in_quad__point_2d_ref__quad_ref(__sklib_point_2d pt, __sklib_quad q);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_in_rectangle__point_2d_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__point_in_rectangle__point_2d_ref__rectangle_ref(__sklib_point_2d pt, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_in_rectangle__double__double__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__point_in_rectangle__double__double__double__double__double__double(double ptx, double pty, double rectX, double rectY, double rectWidth, double rectHeight);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_in_triangle__point_2d_ref__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__point_in_triangle__point_2d_ref__triangle_ref(__sklib_point_2d pt, __sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_line_distance__point_2d_ref__line_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__point_line_distance__point_2d_ref__line_ref(__sklib_point_2d pt, __sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_offset_by__point_2d_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__point_offset_by__point_2d_ref__vector_2d_ref(__sklib_point_2d startPoint, __sklib_vector_2d offset);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_offset_from_origin__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__point_offset_from_origin__vector_2d_ref(__sklib_vector_2d offset);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_on_line__point_2d_ref__line_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__point_on_line__point_2d_ref__line_ref(__sklib_point_2d pt, __sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_on_line__point_2d_ref__line_ref__float", CharSet=CharSet.Ansi)]
    private static extern int __sklib__point_on_line__point_2d_ref__line_ref__float(__sklib_point_2d pt, __sklib_line l, float proximity);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_point_angle__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__point_point_angle__point_2d_ref__point_2d_ref(__sklib_point_2d pt1, __sklib_point_2d pt2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_point_distance__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__point_point_distance__point_2d_ref__point_2d_ref(__sklib_point_2d pt1, __sklib_point_2d pt2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__point_to_string__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__point_to_string__point_2d_ref(__sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__random_bitmap_point__bitmap", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__random_bitmap_point__bitmap(__sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__random_screen_point", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__random_screen_point();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__random_window_point__window", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__random_window_point__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__same_point__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__same_point__point_2d_ref__point_2d_ref(__sklib_point_2d pt1, __sklib_point_2d pt2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__quad_from__point_2d_ref__point_2d_ref__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_quad __sklib__quad_from__point_2d_ref__point_2d_ref__point_2d_ref__point_2d_ref(__sklib_point_2d p1, __sklib_point_2d p2, __sklib_point_2d p3, __sklib_point_2d p4);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__quad_from__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_quad __sklib__quad_from__rectangle_ref(__sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__quad_from__rectangle_ref__matrix_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_quad __sklib__quad_from__rectangle_ref__matrix_2d_ref(__sklib_rectangle rect, __sklib_matrix_2d transform);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__quad_from__double__double__double__double__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_quad __sklib__quad_from__double__double__double__double__double__double__double__double(double xTopLeft, double yTopLeft, double xTopRight, double yTopRight, double xBottomLeft, double yBottomLeft, double xBottomRight, double yBottomRight);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__quads_intersect__quad_ref__quad_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__quads_intersect__quad_ref__quad_ref(__sklib_quad q1, __sklib_quad q2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_quad_point__quad_ref__int__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_quad_point__quad_ref__int__point_2d_ref(ref __sklib_quad q, int idx, __sklib_point_2d value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__triangles_from__quad_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_triangle __sklib__triangles_from__quad_ref(__sklib_quad q);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rnd__int__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__rnd__int__int(int min, int max);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rnd", CharSet=CharSet.Ansi)]
    private static extern float __sklib__rnd();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rnd__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__rnd__int(int ubound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_gpio", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_gpio();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__raspi_cleanup", CharSet=CharSet.Ansi)]
    private static extern void __sklib__raspi_cleanup();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__raspi_get_mode__pins", CharSet=CharSet.Ansi)]
    private static extern int __sklib__raspi_get_mode__pins(int pin);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__raspi_init", CharSet=CharSet.Ansi)]
    private static extern void __sklib__raspi_init();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__raspi_read__pins", CharSet=CharSet.Ansi)]
    private static extern int __sklib__raspi_read__pins(int pin);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__raspi_set_mode__pins__pin_modes", CharSet=CharSet.Ansi)]
    private static extern void __sklib__raspi_set_mode__pins__pin_modes(int pin, int mode);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__raspi_set_pull_up_down__pins__pull_up_down", CharSet=CharSet.Ansi)]
    private static extern void __sklib__raspi_set_pull_up_down__pins__pull_up_down(int pin, int pud);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__raspi_set_pwm_dutycycle__pins__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__raspi_set_pwm_dutycycle__pins__int(int pin, int dutycycle);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__raspi_set_pwm_frequency__pins__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__raspi_set_pwm_frequency__pins__int(int pin, int frequency);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__raspi_set_pwm_range__pins__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__raspi_set_pwm_range__pins__int(int pin, int range);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__raspi_write__pins__pin_values", CharSet=CharSet.Ansi)]
    private static extern void __sklib__raspi_write__pins__pin_values(int pin, int value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_quad__color__quad_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_quad__color__quad_ref(__sklib_color clr, __sklib_quad q);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_quad__color__quad_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_quad__color__quad_ref__drawing_options_ref(__sklib_color clr, __sklib_quad q, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_quad_on_bitmap__bitmap__color__quad_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_quad_on_bitmap__bitmap__color__quad_ref(__sklib_ptr destination, __sklib_color clr, __sklib_quad q);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, __sklib_quad q, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_quad_on_window__window__color__quad_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_quad_on_window__window__color__quad_ref(__sklib_ptr destination, __sklib_color clr, __sklib_quad q);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_quad_on_window__window__color__quad_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_quad_on_window__window__color__quad_ref__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, __sklib_quad q, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle__color__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle__color__rectangle_ref(__sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle__color__rectangle_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle__color__rectangle_ref__drawing_options_ref(__sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle__color__double__double__double__double(__sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle__color__double__double__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle__color__double__double__double__double__drawing_options_ref(__sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle_on_window__window__color__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle_on_window__window__color__rectangle_ref(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle_on_window__window__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle_on_window__window__color__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_rectangle_on_window__window__color__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_rectangle_on_window__window__color__double__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_quad__color__quad_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_quad__color__quad_ref(__sklib_color clr, __sklib_quad q);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_quad__color__quad_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_quad__color__quad_ref__drawing_options_ref(__sklib_color clr, __sklib_quad q, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_quad_on_bitmap__bitmap__color__quad_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_quad_on_bitmap__bitmap__color__quad_ref(__sklib_ptr destination, __sklib_color clr, __sklib_quad q);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, __sklib_quad q, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_quad_on_window__window__color__quad_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_quad_on_window__window__color__quad_ref(__sklib_ptr destination, __sklib_color clr, __sklib_quad q);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_quad_on_window__window__color__quad_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_quad_on_window__window__color__quad_ref__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, __sklib_quad q, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle__color__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle__color__rectangle_ref(__sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle__color__rectangle_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle__color__rectangle_ref__drawing_options_ref(__sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle__color__double__double__double__double(__sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle__color__double__double__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle__color__double__double__double__double__drawing_options_ref(__sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle_on_window__window__color__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle_on_window__window__color__rectangle_ref(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, __sklib_rectangle rect, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle_on_window__window__color__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle_on_window__window__color__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_rectangle_on_window__window__color__double__double__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_rectangle_on_window__window__color__double__double__double__double__drawing_options_ref(__sklib_ptr destination, __sklib_color clr, double x, double y, double width, double height, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__inset_rectangle__rectangle_ref__float", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__inset_rectangle__rectangle_ref__float(__sklib_rectangle rect, float insetAmount);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__intersection__rectangle_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__intersection__rectangle_ref__rectangle_ref(__sklib_rectangle rect1, __sklib_rectangle rect2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_around__circle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__rectangle_around__circle_ref(__sklib_circle c);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_around__line_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__rectangle_around__line_ref(__sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_around__quad_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__rectangle_around__quad_ref(__sklib_quad q);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_around__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__rectangle_around__triangle_ref(__sklib_triangle t);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_bottom__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__rectangle_bottom__rectangle_ref(__sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_center__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__rectangle_center__rectangle_ref(__sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_from__point_2d__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__rectangle_from__point_2d__double__double(__sklib_point_2d pt, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_from__point_2d__point_2d", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__rectangle_from__point_2d__point_2d(__sklib_point_2d pt1, __sklib_point_2d pt2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_from__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__rectangle_from__double__double__double__double(double x, double y, double width, double height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_left__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__rectangle_left__rectangle_ref(__sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_offset_by__rectangle_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__rectangle_offset_by__rectangle_ref__vector_2d_ref(__sklib_rectangle rect, __sklib_vector_2d offset);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_right__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__rectangle_right__rectangle_ref(__sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_to_string__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__rectangle_to_string__rectangle_ref(__sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangle_top__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__rectangle_top__rectangle_ref(__sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__rectangles_intersect__rectangle_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__rectangles_intersect__rectangle_ref__rectangle_ref(__sklib_rectangle rect1, __sklib_rectangle rect2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__deregister_free_notifier__free_notifier_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__deregister_free_notifier__free_notifier_ptr(FreeNotifier handler);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__path_to_resource__string_ref__resource_kind", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__path_to_resource__string_ref__resource_kind(__sklib_string filename, int kind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__path_to_resources", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__path_to_resources();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__path_to_resources__resource_kind", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__path_to_resources__resource_kind(int kind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__register_free_notifier__free_notifier_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__register_free_notifier__free_notifier_ptr(FreeNotifier fn);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_resources_path__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_resources_path__string_ref(__sklib_string path);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fade_all_sound_effects_out__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fade_all_sound_effects_out__int(int ms);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fade_sound_effect_out__sound_effect__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fade_sound_effect_out__sound_effect__int(__sklib_ptr effect, int ms);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_all_sound_effects", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_all_sound_effects();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_sound_effect__sound_effect", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_sound_effect__sound_effect(__sklib_ptr effect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_sound_effect__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_sound_effect__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__load_sound_effect__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__load_sound_effect__string_ref__string_ref(__sklib_string name, __sklib_string filename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_sound_effect__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_sound_effect__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_sound_effect__string_ref__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_sound_effect__string_ref__double(__sklib_string name, double volume);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_sound_effect__string_ref__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_sound_effect__string_ref__int(__sklib_string name, int times);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_sound_effect__string_ref__int__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_sound_effect__string_ref__int__double(__sklib_string name, int times, double volume);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_sound_effect__sound_effect", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_sound_effect__sound_effect(__sklib_ptr effect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_sound_effect__sound_effect__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_sound_effect__sound_effect__double(__sklib_ptr effect, double volume);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_sound_effect__sound_effect__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_sound_effect__sound_effect__int(__sklib_ptr effect, int times);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__play_sound_effect__sound_effect__int__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__play_sound_effect__sound_effect__int__double(__sklib_ptr effect, int times, double volume);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sound_effect_filename__sound_effect", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__sound_effect_filename__sound_effect(__sklib_ptr effect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sound_effect_name__sound_effect", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__sound_effect_name__sound_effect(__sklib_ptr effect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sound_effect_named__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__sound_effect_named__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sound_effect_playing__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sound_effect_playing__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sound_effect_playing__sound_effect", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sound_effect_playing__sound_effect(__sklib_ptr effect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sound_effect_valid__sound_effect", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sound_effect_valid__sound_effect(__sklib_ptr effect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__stop_sound_effect__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__stop_sound_effect__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__stop_sound_effect__sound_effect", CharSet=CharSet.Ansi)]
    private static extern void __sklib__stop_sound_effect__sound_effect(__sklib_ptr effect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__call_for_all_sprites__sprite_float_function_ptr__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__call_for_all_sprites__sprite_float_function_ptr__float(SpriteFloatFunction fn, float val);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__call_for_all_sprites__sprite_function_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__call_for_all_sprites__sprite_function_ptr(SpriteFunction fn);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__call_on_sprite_event__sprite_event_handler_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__call_on_sprite_event__sprite_event_handler_ptr(SpriteEventHandler handler);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__center_point__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__center_point__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_sprite__bitmap", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_sprite__bitmap(__sklib_ptr layer);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_sprite__bitmap__animation_script", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_sprite__bitmap__animation_script(__sklib_ptr layer, __sklib_ptr ani);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_sprite__string_ref(__sklib_string bitmapName);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_sprite__string_ref__bitmap", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_sprite__string_ref__bitmap(__sklib_string name, __sklib_ptr layer);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_sprite__string_ref__bitmap__animation_script", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_sprite__string_ref__bitmap__animation_script(__sklib_string name, __sklib_ptr layer, __sklib_ptr ani);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_sprite__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_sprite__string_ref__string_ref(__sklib_string bitmapName, __sklib_string animationName);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_sprite_pack__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__create_sprite_pack__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_sprite_pack", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__current_sprite_pack();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_all_sprites", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_all_sprites();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_sprite__sprite__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_sprite__sprite__vector_2d_ref(__sklib_ptr s, __sklib_vector_2d offset);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_sprite__sprite", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_sprite__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_sprite__sprite__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_sprite__sprite__double__double(__sklib_ptr s, double xOffset, double yOffset);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_all_sprites", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_all_sprites();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_sprite__sprite", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_sprite__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_sprite_pack__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_sprite_pack__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_sprite__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_sprite_pack__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_sprite_pack__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_sprite__sprite", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_sprite__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_sprite__sprite__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_sprite__sprite__vector_2d_ref(__sklib_ptr s, __sklib_vector_2d distance);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_sprite__sprite__vector_2d_ref__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_sprite__sprite__vector_2d_ref__float(__sklib_ptr s, __sklib_vector_2d distance, float pct);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_sprite__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_sprite__sprite__float(__sklib_ptr s, float pct);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_sprite_to__sprite__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_sprite_to__sprite__double__double(__sklib_ptr s, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__select_sprite_pack__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__select_sprite_pack__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_add_layer__sprite__bitmap__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_add_layer__sprite__bitmap__string_ref(__sklib_ptr s, __sklib_ptr newLayer, __sklib_string layerName);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_add_to_velocity__sprite__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_add_to_velocity__sprite__vector_2d_ref(__sklib_ptr s, __sklib_vector_2d value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_add_value__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_add_value__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_add_value__sprite__string_ref__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_add_value__sprite__string_ref__float(__sklib_ptr s, __sklib_string name, float initVal);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_anchor_point__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__sprite_anchor_point__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_anchor_position__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__sprite_anchor_position__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_animation_has_ended__sprite", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_animation_has_ended__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_animation_name__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__sprite_animation_name__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_at__sprite__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_at__sprite__point_2d_ref(__sklib_ptr s, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_bring_layer_forward__sprite__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_bring_layer_forward__sprite__int(__sklib_ptr s, int visibleLayer);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_bring_layer_to_front__sprite__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_bring_layer_to_front__sprite__int(__sklib_ptr s, int visibleLayer);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_call_on_event__sprite__sprite_event_handler_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_call_on_event__sprite__sprite_event_handler_ptr(__sklib_ptr s, SpriteEventHandler handler);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_circle__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_circle __sklib__sprite_circle__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_collision_bitmap__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__sprite_collision_bitmap__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_collision_circle__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_circle __sklib__sprite_collision_circle__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_collision_kind__sprite", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_collision_kind__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_collision_rectangle__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__sprite_collision_rectangle__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_current_cell__sprite", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_current_cell__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_current_cell_rectangle__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__sprite_current_cell_rectangle__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_dx__sprite", CharSet=CharSet.Ansi)]
    private static extern float __sklib__sprite_dx__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_dy__sprite", CharSet=CharSet.Ansi)]
    private static extern float __sklib__sprite_dy__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_has_value__sprite__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_has_value__sprite__string(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_heading__sprite", CharSet=CharSet.Ansi)]
    private static extern float __sklib__sprite_heading__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_height__sprite", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_height__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_hide_layer__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_hide_layer__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_hide_layer__sprite__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_hide_layer__sprite__int(__sklib_ptr s, int id);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__sprite_layer__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer__sprite__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__sprite_layer__sprite__int(__sklib_ptr s, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_circle__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_circle __sklib__sprite_layer_circle__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_circle__sprite__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_circle __sklib__sprite_layer_circle__sprite__int(__sklib_ptr s, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_count__sprite", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_layer_count__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_height__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_layer_height__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_height__sprite__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_layer_height__sprite__int(__sklib_ptr s, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_index__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_layer_index__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_name__sprite__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__sprite_layer_name__sprite__int(__sklib_ptr s, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_offset__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__sprite_layer_offset__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_offset__sprite__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__sprite_layer_offset__sprite__int(__sklib_ptr s, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_rectangle__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__sprite_layer_rectangle__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_rectangle__sprite__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__sprite_layer_rectangle__sprite__int(__sklib_ptr s, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_width__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_layer_width__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_layer_width__sprite__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_layer_width__sprite__int(__sklib_ptr s, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_location_matrix__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_matrix_2d __sklib__sprite_location_matrix__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_mass__sprite", CharSet=CharSet.Ansi)]
    private static extern float __sklib__sprite_mass__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_move_from_anchor_point__sprite", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_move_from_anchor_point__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_move_to__sprite__point_2d_ref__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_move_to__sprite__point_2d_ref__float(__sklib_ptr s, __sklib_point_2d pt, float takingSeconds);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_name__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__sprite_name__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_named__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__sprite_named__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_offscreen__sprite", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_offscreen__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_on_screen_at__sprite__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_on_screen_at__sprite__point_2d_ref(__sklib_ptr s, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_on_screen_at__sprite__double__double", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_on_screen_at__sprite__double__double(__sklib_ptr s, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_position__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__sprite_position__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_replay_animation__sprite", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_replay_animation__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_replay_animation__sprite__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_replay_animation__sprite__bool(__sklib_ptr s, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_rotation__sprite", CharSet=CharSet.Ansi)]
    private static extern float __sklib__sprite_rotation__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_scale__sprite", CharSet=CharSet.Ansi)]
    private static extern float __sklib__sprite_scale__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_screen_rectangle__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_rectangle __sklib__sprite_screen_rectangle__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_send_layer_backward__sprite__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_send_layer_backward__sprite__int(__sklib_ptr s, int visibleLayer);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_send_layer_to_back__sprite__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_send_layer_to_back__sprite__int(__sklib_ptr s, int visibleLayer);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_anchor_point__sprite__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_anchor_point__sprite__point_2d_ref(__sklib_ptr s, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_collision_bitmap__sprite__bitmap", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_collision_bitmap__sprite__bitmap(__sklib_ptr s, __sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_collision_kind__sprite__collision_test_kind", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_collision_kind__sprite__collision_test_kind(__sklib_ptr s, int value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_dx__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_dx__sprite__float(__sklib_ptr s, float value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_dy__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_dy__sprite__float(__sklib_ptr s, float value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_heading__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_heading__sprite__float(__sklib_ptr s, float value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_layer_offset__sprite__string_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_layer_offset__sprite__string_ref__vector_2d_ref(__sklib_ptr s, __sklib_string name, __sklib_vector_2d value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_layer_offset__sprite__int__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_layer_offset__sprite__int__vector_2d_ref(__sklib_ptr s, int idx, __sklib_vector_2d value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_mass__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_mass__sprite__float(__sklib_ptr s, float value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_move_from_anchor_point__sprite__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_move_from_anchor_point__sprite__bool(__sklib_ptr s, int value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_position__sprite__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_position__sprite__point_2d_ref(__sklib_ptr s, __sklib_point_2d value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_rotation__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_rotation__sprite__float(__sklib_ptr s, float value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_scale__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_scale__sprite__float(__sklib_ptr s, float value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_speed__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_speed__sprite__float(__sklib_ptr s, float value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_value__sprite__string_ref__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_value__sprite__string_ref__float(__sklib_ptr s, __sklib_string name, float val);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_velocity__sprite__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_velocity__sprite__vector_2d_ref(__sklib_ptr s, __sklib_vector_2d value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_x__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_x__sprite__float(__sklib_ptr s, float value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_set_y__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_set_y__sprite__float(__sklib_ptr s, float value);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_show_layer__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_show_layer__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_show_layer__sprite__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_show_layer__sprite__int(__sklib_ptr s, int id);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_speed__sprite", CharSet=CharSet.Ansi)]
    private static extern float __sklib__sprite_speed__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_start_animation__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_start_animation__sprite__string_ref(__sklib_ptr s, __sklib_string named);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_start_animation__sprite__string_ref__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_start_animation__sprite__string_ref__bool(__sklib_ptr s, __sklib_string named, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_start_animation__sprite__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_start_animation__sprite__int(__sklib_ptr s, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_start_animation__sprite__int__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_start_animation__sprite__int__bool(__sklib_ptr s, int idx, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_stop_calling_on_event__sprite__sprite_event_handler_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_stop_calling_on_event__sprite__sprite_event_handler_ptr(__sklib_ptr s, SpriteEventHandler handler);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_toggle_layer_visible__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_toggle_layer_visible__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_toggle_layer_visible__sprite__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__sprite_toggle_layer_visible__sprite__int(__sklib_ptr s, int id);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_value__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern float __sklib__sprite_value__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_value_count__sprite", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_value_count__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_velocity__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__sprite_velocity__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_visible_index_of_layer__sprite__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_visible_index_of_layer__sprite__string_ref(__sklib_ptr s, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_visible_index_of_layer__sprite__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_visible_index_of_layer__sprite__int(__sklib_ptr s, int id);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_visible_layer__sprite__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_visible_layer__sprite__int(__sklib_ptr s, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_visible_layer_count__sprite", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_visible_layer_count__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_visible_layer_id__sprite__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_visible_layer_id__sprite__int(__sklib_ptr s, int idx);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_width__sprite", CharSet=CharSet.Ansi)]
    private static extern int __sklib__sprite_width__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_x__sprite", CharSet=CharSet.Ansi)]
    private static extern float __sklib__sprite_x__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__sprite_y__sprite", CharSet=CharSet.Ansi)]
    private static extern float __sklib__sprite_y__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__stop_calling_on_sprite_event__sprite_event_handler_ptr", CharSet=CharSet.Ansi)]
    private static extern void __sklib__stop_calling_on_sprite_event__sprite_event_handler_ptr(SpriteEventHandler handler);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_all_sprites", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_all_sprites();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_all_sprites__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_all_sprites__float(float pct);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_sprite__sprite", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_sprite__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_sprite__sprite__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_sprite__sprite__bool(__sklib_ptr s, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_sprite__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_sprite__sprite__float(__sklib_ptr s, float pct);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_sprite__sprite__float__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_sprite__sprite__float__bool(__sklib_ptr s, float pct, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_sprite_animation__sprite", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_sprite_animation__sprite(__sklib_ptr s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_sprite_animation__sprite__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_sprite_animation__sprite__bool(__sklib_ptr s, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_sprite_animation__sprite__float", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_sprite_animation__sprite__float(__sklib_ptr s, float pct);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__update_sprite_animation__sprite__float__bool", CharSet=CharSet.Ansi)]
    private static extern void __sklib__update_sprite_animation__sprite__float__bool(__sklib_ptr s, float pct, int withSound);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_from_center_sprite_to_point__sprite__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_from_center_sprite_to_point__sprite__point_2d_ref(__sklib_ptr s, __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_from_to__sprite__sprite", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_from_to__sprite__sprite(__sklib_ptr s1, __sklib_ptr s2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__read_char", CharSet=CharSet.Ansi)]
    private static extern char __sklib__read_char();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__read_line", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__read_line();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__terminal_has_input", CharSet=CharSet.Ansi)]
    private static extern int __sklib__terminal_has_input();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__write__char", CharSet=CharSet.Ansi)]
    private static extern void __sklib__write__char(char data);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__write__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__write__double(double data);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__write__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__write__int(int data);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__write__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__write__string(__sklib_string text);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__write_line__char", CharSet=CharSet.Ansi)]
    private static extern void __sklib__write_line__char(char data);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__write_line", CharSet=CharSet.Ansi)]
    private static extern void __sklib__write_line();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__write_line__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__write_line__double(double data);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__write_line__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__write_line__int(int data);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__write_line__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__write_line__string(__sklib_string line);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text__string_ref__color_ref__string_ref__int__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text__string_ref__color_ref__string_ref__int__double__double(__sklib_string text, __sklib_color clr, __sklib_string fnt, int fontSize, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__sklib_string text, __sklib_color clr, __sklib_string fnt, int fontSize, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text__string_ref__color_ref__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text__string_ref__color_ref__double__double(__sklib_string text, __sklib_color clr, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text__string_ref__color_ref__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text__string_ref__color_ref__double__double__drawing_options_ref(__sklib_string text, __sklib_color clr, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text__string_ref__color_ref__font__int__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text__string_ref__color_ref__font__int__double__double(__sklib_string text, __sklib_color clr, __sklib_ptr fnt, int fontSize, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text__string_ref__color_ref__font__int__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text__string_ref__color_ref__font__int__double__double__drawing_options_ref(__sklib_string text, __sklib_color clr, __sklib_ptr fnt, int fontSize, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double(__sklib_ptr bmp, __sklib_string text, __sklib_color clr, __sklib_string fnt, int fontSize, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__sklib_ptr bmp, __sklib_string text, __sklib_color clr, __sklib_string fnt, int fontSize, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double(__sklib_ptr bmp, __sklib_string text, __sklib_color clr, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double__drawing_options_ref(__sklib_ptr bmp, __sklib_string text, __sklib_color clr, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double(__sklib_ptr bmp, __sklib_string text, __sklib_color clr, __sklib_ptr fnt, int fontSize, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double__drawing_options_ref(__sklib_ptr bmp, __sklib_string text, __sklib_color clr, __sklib_ptr fnt, int fontSize, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double(__sklib_ptr wnd, __sklib_string text, __sklib_color clr, __sklib_string fnt, int fontSize, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__sklib_ptr wnd, __sklib_string text, __sklib_color clr, __sklib_string fnt, int fontSize, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_window__window__string_ref__color_ref__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_window__window__string_ref__color_ref__double__double(__sklib_ptr wnd, __sklib_string text, __sklib_color clr, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_window__window__string_ref__color_ref__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_window__window__string_ref__color_ref__double__double__drawing_options_ref(__sklib_ptr wnd, __sklib_string text, __sklib_color clr, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double(__sklib_ptr wnd, __sklib_string text, __sklib_color clr, __sklib_ptr fnt, int fontSize, double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double__drawing_options_ref(__sklib_ptr wnd, __sklib_string text, __sklib_color clr, __sklib_ptr fnt, int fontSize, double x, double y, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__font_has_size__string_ref__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__font_has_size__string_ref__int(__sklib_string name, int fontSize);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__font_has_size__font__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__font_has_size__font__int(__sklib_ptr fnt, int fontSize);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__font_load_size__string_ref__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__font_load_size__string_ref__int(__sklib_string name, int fontSize);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__font_load_size__font__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__font_load_size__font__int(__sklib_ptr fnt, int fontSize);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__font_named__string", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__font_named__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_all_fonts", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_all_fonts();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_font__font", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_font__font(__sklib_ptr fnt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_font_style__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__get_font_style__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_font_style__font", CharSet=CharSet.Ansi)]
    private static extern int __sklib__get_font_style__font(__sklib_ptr fnt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__get_system_font", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__get_system_font();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_font__font", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_font__font(__sklib_ptr fnt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_font__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_font__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__load_font__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__load_font__string_ref__string_ref(__sklib_string name, __sklib_string filename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_font_style__string_ref__font_style", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_font_style__string_ref__font_style(__sklib_string name, int style);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_font_style__font__font_style", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_font_style__font__font_style(__sklib_ptr fnt, int style);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__text_height__string_ref__string_ref__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__text_height__string_ref__string_ref__int(__sklib_string text, __sklib_string fnt, int fontSize);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__text_height__string_ref__font__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__text_height__string_ref__font__int(__sklib_string text, __sklib_ptr fnt, int fontSize);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__text_width__string_ref__string_ref__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__text_width__string_ref__string_ref__int(__sklib_string text, __sklib_string fnt, int fontSize);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__text_width__string_ref__font__int", CharSet=CharSet.Ansi)]
    private static extern int __sklib__text_width__string_ref__font__int(__sklib_string text, __sklib_ptr fnt, int fontSize);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_collected_text__color__font__int__drawing_options_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_collected_text__color__font__int__drawing_options_ref(__sklib_color clr, __sklib_ptr fnt, int fontSize, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__end_reading_text", CharSet=CharSet.Ansi)]
    private static extern void __sklib__end_reading_text();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__end_reading_text__window", CharSet=CharSet.Ansi)]
    private static extern void __sklib__end_reading_text__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reading_text", CharSet=CharSet.Ansi)]
    private static extern int __sklib__reading_text();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reading_text__window", CharSet=CharSet.Ansi)]
    private static extern int __sklib__reading_text__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_reading_text__rectangle", CharSet=CharSet.Ansi)]
    private static extern void __sklib__start_reading_text__rectangle(__sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_reading_text__rectangle__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__start_reading_text__rectangle__string(__sklib_rectangle rect, __sklib_string initialText);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_reading_text__window__rectangle", CharSet=CharSet.Ansi)]
    private static extern void __sklib__start_reading_text__window__rectangle(__sklib_ptr wind, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_reading_text__window__rectangle__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__start_reading_text__window__rectangle__string(__sklib_ptr wind, __sklib_rectangle rect, __sklib_string initialText);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__text_entry_cancelled", CharSet=CharSet.Ansi)]
    private static extern int __sklib__text_entry_cancelled();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__text_entry_cancelled__window", CharSet=CharSet.Ansi)]
    private static extern int __sklib__text_entry_cancelled__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__text_input", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__text_input();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__text_input__window", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__text_input__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__create_timer__string", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__create_timer__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_all_timers", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_all_timers();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_timer__timer", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_timer__timer(__sklib_ptr toFree);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_timer__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_timer__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__pause_timer__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__pause_timer__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__pause_timer__timer", CharSet=CharSet.Ansi)]
    private static extern void __sklib__pause_timer__timer(__sklib_ptr toPause);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reset_timer__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__reset_timer__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__reset_timer__timer", CharSet=CharSet.Ansi)]
    private static extern void __sklib__reset_timer__timer(__sklib_ptr tmr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__resume_timer__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__resume_timer__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__resume_timer__timer", CharSet=CharSet.Ansi)]
    private static extern void __sklib__resume_timer__timer(__sklib_ptr toResume);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_timer__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__start_timer__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_timer__timer", CharSet=CharSet.Ansi)]
    private static extern void __sklib__start_timer__timer(__sklib_ptr toStart);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__stop_timer__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__stop_timer__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__stop_timer__timer", CharSet=CharSet.Ansi)]
    private static extern void __sklib__stop_timer__timer(__sklib_ptr toStop);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__timer_named__string", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__timer_named__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__timer_paused__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__timer_paused__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__timer_paused__timer", CharSet=CharSet.Ansi)]
    private static extern int __sklib__timer_paused__timer(__sklib_ptr toGet);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__timer_started__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__timer_started__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__timer_started__timer", CharSet=CharSet.Ansi)]
    private static extern int __sklib__timer_started__timer(__sklib_ptr toGet);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__timer_ticks__string", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__timer_ticks__string(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__timer_ticks__timer", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__timer_ticks__timer(__sklib_ptr toGet);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle__color__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle__color__triangle_ref(__sklib_color clr, __sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle__color__triangle_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle__color__triangle_ref__drawing_options(__sklib_color clr, __sklib_triangle tri, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle__color__double__double__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle__color__double__double__double__double__double__double(__sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle__color__double__double__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle__color__double__double__double__double__double__double__drawing_options(__sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref(__sklib_ptr destination, __sklib_color clr, __sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_triangle tri, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle_on_window__window__color__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle_on_window__window__color__triangle_ref(__sklib_ptr destination, __sklib_color clr, __sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle_on_window__window__color__triangle_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle_on_window__window__color__triangle_ref__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_triangle tri, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle__color__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle__color__triangle_ref(__sklib_color clr, __sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle__color__triangle_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle__color__triangle_ref__drawing_options(__sklib_color clr, __sklib_triangle tri, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle__color__double__double__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle__color__double__double__double__double__double__double(__sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle__color__double__double__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle__color__double__double__double__double__double__double__drawing_options(__sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref(__sklib_ptr destination, __sklib_color clr, __sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_triangle tri, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle_on_window__window__color__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle_on_window__window__color__triangle_ref(__sklib_ptr destination, __sklib_color clr, __sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle_on_window__window__color__triangle_ref__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle_on_window__window__color__triangle_ref__drawing_options(__sklib_ptr destination, __sklib_color clr, __sklib_triangle tri, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options", CharSet=CharSet.Ansi)]
    private static extern void __sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(__sklib_ptr destination, __sklib_color clr, double x1, double y1, double x2, double y2, double x3, double y3, __sklib_drawing_options opts);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__triangle_barycenter__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__triangle_barycenter__triangle_ref(__sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__triangle_from__point_2d_ref__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_triangle __sklib__triangle_from__point_2d_ref__point_2d_ref__point_2d_ref(__sklib_point_2d p1, __sklib_point_2d p2, __sklib_point_2d p3);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__triangle_from__double__double__double__double__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_triangle __sklib__triangle_from__double__double__double__double__double__double(double x1, double y1, double x2, double y2, double x3, double y3);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__triangle_rectangle_intersect__triangle_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__triangle_rectangle_intersect__triangle_ref__rectangle_ref(__sklib_triangle tri, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__triangle_to_string__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__triangle_to_string__triangle_ref(__sklib_triangle tri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__triangles_intersect__triangle_ref__triangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__triangles_intersect__triangle_ref__triangle_ref(__sklib_triangle t1, __sklib_triangle t2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_ticks", CharSet=CharSet.Ansi)]
    private static extern uint __sklib__current_ticks();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__delay__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__delay__int(int milliseconds);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__display_dialog__string_ref__string_ref__font__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__display_dialog__string_ref__string_ref__font__int(__sklib_string title, __sklib_string msg, __sklib_ptr outputFont, int fontSize);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__file_as_string__string__resource_kind", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__file_as_string__string__resource_kind(__sklib_string filename, int kind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__angle_between__vector_2d_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern double __sklib__angle_between__vector_2d_ref__vector_2d_ref(__sklib_vector_2d v1, __sklib_vector_2d v2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__dot_product__vector_2d_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern double __sklib__dot_product__vector_2d_ref__vector_2d_ref(__sklib_vector_2d v1, __sklib_vector_2d v2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_zero_vector__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_zero_vector__vector_2d_ref(__sklib_vector_2d v);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__ray_intersection_point__point_2d_ref__vector_2d_ref__line_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__ray_intersection_point__point_2d_ref__vector_2d_ref__line_ref__point_2d_ref(__sklib_point_2d fromPt, __sklib_vector_2d heading, __sklib_line l, ref __sklib_point_2d pt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__unit_vector__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__unit_vector__vector_2d_ref(__sklib_vector_2d v);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_add__vector_2d_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_add__vector_2d_ref__vector_2d_ref(__sklib_vector_2d v1, __sklib_vector_2d v2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_angle__vector_2d", CharSet=CharSet.Ansi)]
    private static extern double __sklib__vector_angle__vector_2d(__sklib_vector_2d v);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_from_angle__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_from_angle__double__double(double angle, double magnitude);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_from_line__line_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_from_line__line_ref(__sklib_line l);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_from_point_to_rect__point_2d_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_from_point_to_rect__point_2d_ref__rectangle_ref(__sklib_point_2d pt, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_in_rect__vector_2d_ref__rectangle_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__vector_in_rect__vector_2d_ref__rectangle_ref(__sklib_vector_2d v, __sklib_rectangle rect);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_invert__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_invert__vector_2d_ref(__sklib_vector_2d v);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_limit__vector_2d_ref__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_limit__vector_2d_ref__double(__sklib_vector_2d v, double limit);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_magnitude__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern double __sklib__vector_magnitude__vector_2d_ref(__sklib_vector_2d v);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_magnitude_squared__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern double __sklib__vector_magnitude_squared__vector_2d_ref(__sklib_vector_2d v);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_multiply__vector_2d_ref__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_multiply__vector_2d_ref__double(__sklib_vector_2d v1, double s);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_normal__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_normal__vector_2d_ref(__sklib_vector_2d v);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_out_of_circle_from_circle__circle_ref__circle_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_out_of_circle_from_circle__circle_ref__circle_ref__vector_2d_ref(__sklib_circle src, __sklib_circle bounds, __sklib_vector_2d velocity);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_out_of_circle_from_point__point_2d_ref__circle_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_out_of_circle_from_point__point_2d_ref__circle_ref__vector_2d_ref(__sklib_point_2d pt, __sklib_circle c, __sklib_vector_2d velocity);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_out_of_rect_from_circle__circle_ref__rectangle_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_out_of_rect_from_circle__circle_ref__rectangle_ref__vector_2d_ref(__sklib_circle c, __sklib_rectangle rect, __sklib_vector_2d velocity);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_out_of_rect_from_point__point_2d_ref__rectangle_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_out_of_rect_from_point__point_2d_ref__rectangle_ref__vector_2d_ref(__sklib_point_2d pt, __sklib_rectangle rect, __sklib_vector_2d velocity);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_out_of_rect_from_rect__rectangle_ref__rectangle_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_out_of_rect_from_rect__rectangle_ref__rectangle_ref__vector_2d_ref(__sklib_rectangle src, __sklib_rectangle bounds, __sklib_vector_2d velocity);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_point_to_point__point_2d_ref__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_point_to_point__point_2d_ref__point_2d_ref(__sklib_point_2d start, __sklib_point_2d endPt);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_subtract__vector_2d_ref__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_subtract__vector_2d_ref__vector_2d_ref(__sklib_vector_2d v1, __sklib_vector_2d v2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_to__point_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_to__point_2d_ref(__sklib_point_2d p1);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_to__double__double", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_2d __sklib__vector_to__double__double(double x, double y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vector_to_string__vector_2d_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__vector_to_string__vector_2d_ref(__sklib_vector_2d v);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vectors_equal__vector_2d_ref__vector_2d", CharSet=CharSet.Ansi)]
    private static extern int __sklib__vectors_equal__vector_2d_ref__vector_2d(__sklib_vector_2d v1, __sklib_vector_2d v2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__vectors_not_equal__vector_2d_ref__vector_2d", CharSet=CharSet.Ansi)]
    private static extern int __sklib__vectors_not_equal__vector_2d_ref__vector_2d(__sklib_vector_2d v1, __sklib_vector_2d v2);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__download_bitmap__string_ref__string_ref__unsigned_short", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__download_bitmap__string_ref__string_ref__unsigned_short(__sklib_string name, __sklib_string url, ushort port);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__download_font__string_ref__string_ref__unsigned_short", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__download_font__string_ref__string_ref__unsigned_short(__sklib_string name, __sklib_string url, ushort port);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__download_music__string_ref__string_ref__unsigned_short", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__download_music__string_ref__string_ref__unsigned_short(__sklib_string name, __sklib_string url, ushort port);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__download_sound_effect__string_ref__string_ref__unsigned_short", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__download_sound_effect__string_ref__string_ref__unsigned_short(__sklib_string name, __sklib_string url, ushort port);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__free_response__http_response", CharSet=CharSet.Ansi)]
    private static extern void __sklib__free_response__http_response(__sklib_ptr response);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__http_get__string_ref__unsigned_short", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__http_get__string_ref__unsigned_short(__sklib_string url, ushort port);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__http_post__string_ref__unsigned_short__string_ref__vector_string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__http_post__string_ref__unsigned_short__string_ref__vector_string_ref(__sklib_string url, ushort port, __sklib_string body, __sklib_vector_string headers);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__http_post__string_ref__unsigned_short__string", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__http_post__string_ref__unsigned_short__string(__sklib_string url, ushort port, __sklib_string body);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__http_response_to_string__http_response", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__http_response_to_string__http_response(__sklib_ptr response);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__save_response_to_file__http_response__string", CharSet=CharSet.Ansi)]
    private static extern void __sklib__save_response_to_file__http_response__string(__sklib_ptr response, __sklib_string path);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_incoming_requests__web_server", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_incoming_requests__web_server(__sklib_ptr server);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_delete_request_for__http_request__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_delete_request_for__http_request__string_ref(__sklib_ptr request, __sklib_string path);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_get_request_for__http_request__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_get_request_for__http_request__string_ref(__sklib_ptr request, __sklib_string path);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_options_request_for__http_request__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_options_request_for__http_request__string_ref(__sklib_ptr request, __sklib_string path);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_post_request_for__http_request__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_post_request_for__http_request__string_ref(__sklib_ptr request, __sklib_string path);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_put_request_for__http_request__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_put_request_for__http_request__string_ref(__sklib_ptr request, __sklib_string path);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_request_for__http_request__http_method__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_request_for__http_request__http_method__string_ref(__sklib_ptr request, int method, __sklib_string path);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_trace_request_for__http_request__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_trace_request_for__http_request__string_ref(__sklib_ptr request, __sklib_string path);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__next_web_request__web_server", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__next_web_request__web_server(__sklib_ptr server);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__request_body__http_request", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__request_body__http_request(__sklib_ptr r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__request_has_query_parameter__http_request__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__request_has_query_parameter__http_request__string_ref(__sklib_ptr r, __sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__request_headers__http_request", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_string __sklib__request_headers__http_request(__sklib_ptr r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__request_method__http_request", CharSet=CharSet.Ansi)]
    private static extern int __sklib__request_method__http_request(__sklib_ptr r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__request_query_parameter__http_request__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__request_query_parameter__http_request__string_ref__string_ref(__sklib_ptr r, __sklib_string name, __sklib_string defaultValue);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__request_query_string__http_request", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__request_query_string__http_request(__sklib_ptr r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__request_uri__http_request", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__request_uri__http_request(__sklib_ptr r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__request_uri_stubs__http_request", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_string __sklib__request_uri_stubs__http_request(__sklib_ptr r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_css_file_response__http_request__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__send_css_file_response__http_request__string_ref(__sklib_ptr r, __sklib_string filename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_file_response__http_request__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__send_file_response__http_request__string_ref__string_ref(__sklib_ptr r, __sklib_string filename, __sklib_string contentType);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_html_file_response__http_request__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__send_html_file_response__http_request__string_ref(__sklib_ptr r, __sklib_string filename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_javascript_file_response__http_request__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__send_javascript_file_response__http_request__string_ref(__sklib_ptr r, __sklib_string filename);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_response__http_request", CharSet=CharSet.Ansi)]
    private static extern void __sklib__send_response__http_request(__sklib_ptr r);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_response__http_request__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__send_response__http_request__string_ref(__sklib_ptr r, __sklib_string message);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_response__http_request__http_status_code", CharSet=CharSet.Ansi)]
    private static extern void __sklib__send_response__http_request__http_status_code(__sklib_ptr r, int code);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_response__http_request__http_status_code__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__send_response__http_request__http_status_code__string_ref(__sklib_ptr r, int code, __sklib_string message);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_response__http_request__http_status_code__string_ref__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__send_response__http_request__http_status_code__string_ref__string_ref(__sklib_ptr r, int code, __sklib_string message, __sklib_string contentType);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_response__http_request__http_status_code__string_ref__string_ref__vector_string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__send_response__http_request__http_status_code__string_ref__string_ref__vector_string_ref(__sklib_ptr r, int code, __sklib_string message, __sklib_string contentType, __sklib_vector_string headers);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__send_response__http_request__json", CharSet=CharSet.Ansi)]
    private static extern void __sklib__send_response__http_request__json(__sklib_ptr r, __sklib_ptr j);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__split_uri_stubs__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_vector_string __sklib__split_uri_stubs__string_ref(__sklib_string uri);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_web_server", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__start_web_server();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__start_web_server__unsigned_short", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__start_web_server__unsigned_short(ushort port);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__stop_web_server__web_server", CharSet=CharSet.Ansi)]
    private static extern void __sklib__stop_web_server__web_server(__sklib_ptr server);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__clear_window__window__color", CharSet=CharSet.Ansi)]
    private static extern void __sklib__clear_window__window__color(__sklib_ptr wind, __sklib_color clr);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_all_windows", CharSet=CharSet.Ansi)]
    private static extern void __sklib__close_all_windows();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_current_window", CharSet=CharSet.Ansi)]
    private static extern void __sklib__close_current_window();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_window__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__close_window__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__close_window__window", CharSet=CharSet.Ansi)]
    private static extern void __sklib__close_window__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_window", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__current_window();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_window_has_border", CharSet=CharSet.Ansi)]
    private static extern int __sklib__current_window_has_border();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_window_height", CharSet=CharSet.Ansi)]
    private static extern int __sklib__current_window_height();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_window_is_fullscreen", CharSet=CharSet.Ansi)]
    private static extern int __sklib__current_window_is_fullscreen();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_window_position", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__current_window_position();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_window_toggle_border", CharSet=CharSet.Ansi)]
    private static extern void __sklib__current_window_toggle_border();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_window_toggle_fullscreen", CharSet=CharSet.Ansi)]
    private static extern void __sklib__current_window_toggle_fullscreen();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_window_width", CharSet=CharSet.Ansi)]
    private static extern int __sklib__current_window_width();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_window_x", CharSet=CharSet.Ansi)]
    private static extern int __sklib__current_window_x();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__current_window_y", CharSet=CharSet.Ansi)]
    private static extern int __sklib__current_window_y();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__has_window__string", CharSet=CharSet.Ansi)]
    private static extern int __sklib__has_window__string(__sklib_string caption);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__is_current_window__window", CharSet=CharSet.Ansi)]
    private static extern int __sklib__is_current_window__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_current_window_to__int__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_current_window_to__int__int(int x, int y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_window_to__string_ref__int__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_window_to__string_ref__int__int(__sklib_string name, int x, int y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__move_window_to__window__int__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__move_window_to__window__int__int(__sklib_ptr wind, int x, int y);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__open_window__string__int__int", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__open_window__string__int__int(__sklib_string caption, int width, int height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__refresh_window__window", CharSet=CharSet.Ansi)]
    private static extern void __sklib__refresh_window__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__refresh_window__window__unsigned_int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__refresh_window__window__unsigned_int(__sklib_ptr wind, uint targetFps);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__resize_current_window__int__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__resize_current_window__int__int(int width, int height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__resize_window__window__int__int", CharSet=CharSet.Ansi)]
    private static extern void __sklib__resize_window__window__int__int(__sklib_ptr wnd, int width, int height);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_current_window__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_current_window__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__set_current_window__window", CharSet=CharSet.Ansi)]
    private static extern void __sklib__set_current_window__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_caption__window", CharSet=CharSet.Ansi)]
    private static extern __sklib_string __sklib__window_caption__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_close_requested__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_close_requested__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_close_requested__window", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_close_requested__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_has_border__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_has_border__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_has_border__window", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_has_border__window(__sklib_ptr wnd);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_has_focus__window", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_has_focus__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_height__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_height__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_height__window", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_height__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_is_fullscreen__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_is_fullscreen__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_is_fullscreen__window", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_is_fullscreen__window(__sklib_ptr wnd);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_named__string", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__window_named__string(__sklib_string caption);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_position__string_ref", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__window_position__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_position__window", CharSet=CharSet.Ansi)]
    private static extern __sklib_point_2d __sklib__window_position__window(__sklib_ptr wnd);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_set_icon__window__bitmap", CharSet=CharSet.Ansi)]
    private static extern void __sklib__window_set_icon__window__bitmap(__sklib_ptr wind, __sklib_ptr bmp);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_toggle_border__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__window_toggle_border__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_toggle_border__window", CharSet=CharSet.Ansi)]
    private static extern void __sklib__window_toggle_border__window(__sklib_ptr wnd);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_toggle_fullscreen__string_ref", CharSet=CharSet.Ansi)]
    private static extern void __sklib__window_toggle_fullscreen__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_toggle_fullscreen__window", CharSet=CharSet.Ansi)]
    private static extern void __sklib__window_toggle_fullscreen__window(__sklib_ptr wnd);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_width__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_width__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_width__window", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_width__window(__sklib_ptr wind);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_with_focus", CharSet=CharSet.Ansi)]
    private static extern __sklib_ptr __sklib__window_with_focus();

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_x__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_x__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_x__window", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_x__window(__sklib_ptr wnd);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_y__string_ref", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_y__string_ref(__sklib_string name);

    [DllImport("SplashKit", CallingConvention=CallingConvention.Cdecl, EntryPoint="__sklib__window_y__window", CharSet=CharSet.Ansi)]
    private static extern int __sklib__window_y__window(__sklib_ptr wnd);

    public static int AnimationCount(AnimationScript script)
    {
      __sklib_ptr __skparam__script;
      int __skreturn;
      __skparam__script = __skadapter__to_sklib_animation_script(script);
      __skreturn = __sklib__animation_count__animation_script(__skparam__script);
      return __skadapter__to_int(__skreturn);
    }
    public static int AnimationCurrentCell(Animation anim)
    {
      __sklib_ptr __skparam__anim;
      int __skreturn;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skreturn = __sklib__animation_current_cell__animation(__skparam__anim);
      return __skadapter__to_int(__skreturn);
    }
    public static Vector2D AnimationCurrentVector(Animation anim)
    {
      __sklib_ptr __skparam__anim;
      __sklib_vector_2d __skreturn;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skreturn = __sklib__animation_current_vector__animation(__skparam__anim);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static bool AnimationEnded(Animation anim)
    {
      __sklib_ptr __skparam__anim;
      int __skreturn;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skreturn = __sklib__animation_ended__animation(__skparam__anim);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool AnimationEnteredFrame(Animation anim)
    {
      __sklib_ptr __skparam__anim;
      int __skreturn;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skreturn = __sklib__animation_entered_frame__animation(__skparam__anim);
      return __skadapter__to_bool(__skreturn);
    }
    public static float AnimationFrameTime(Animation anim)
    {
      __sklib_ptr __skparam__anim;
      float __skreturn;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skreturn = __sklib__animation_frame_time__animation(__skparam__anim);
      return __skadapter__to_float(__skreturn);
    }
    public static int AnimationIndex(AnimationScript script, string name)
    {
      __sklib_ptr __skparam__script;
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__script = __skadapter__to_sklib_animation_script(script);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__animation_index__animation_script__string_ref(__skparam__script, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static string AnimationName(Animation temp)
    {
      __sklib_ptr __skparam__temp;
      __sklib_string __skreturn;
      __skparam__temp = __skadapter__to_sklib_animation(temp);
      __skreturn = __sklib__animation_name__animation(__skparam__temp);
      return __skadapter__to_string(__skreturn);
    }
    public static string AnimationScriptName(AnimationScript script)
    {
      __sklib_ptr __skparam__script;
      __sklib_string __skreturn;
      __skparam__script = __skadapter__to_sklib_animation_script(script);
      __skreturn = __sklib__animation_script_name__animation_script(__skparam__script);
      return __skadapter__to_string(__skreturn);
    }
    public static AnimationScript AnimationScriptNamed(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__animation_script_named__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_animation_script(__skreturn);
    }
    public static void AssignAnimation(Animation anim, AnimationScript script, string name)
    {
      __sklib_ptr __skparam__anim;
      __sklib_ptr __skparam__script;
      __sklib_string __skparam__name;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__script = __skadapter__to_sklib_animation_script(script);
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__assign_animation__animation__animation_script__string_ref(__skparam__anim, __skparam__script, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void AssignAnimation(Animation anim, AnimationScript script, string name, bool withSound)
    {
      __sklib_ptr __skparam__anim;
      __sklib_ptr __skparam__script;
      __sklib_string __skparam__name;
      int __skparam__with_sound;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__script = __skadapter__to_sklib_animation_script(script);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__assign_animation__animation__animation_script__string_ref__bool(__skparam__anim, __skparam__script, __skparam__name, __skparam__with_sound);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void AssignAnimation(Animation anim, AnimationScript script, int idx)
    {
      __sklib_ptr __skparam__anim;
      __sklib_ptr __skparam__script;
      int __skparam__idx;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__script = __skadapter__to_sklib_animation_script(script);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __sklib__assign_animation__animation__animation_script__int(__skparam__anim, __skparam__script, __skparam__idx);
    }
    public static void AssignAnimation(Animation anim, AnimationScript script, int idx, bool withSound)
    {
      __sklib_ptr __skparam__anim;
      __sklib_ptr __skparam__script;
      int __skparam__idx;
      int __skparam__with_sound;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__script = __skadapter__to_sklib_animation_script(script);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__assign_animation__animation__animation_script__int__bool(__skparam__anim, __skparam__script, __skparam__idx, __skparam__with_sound);
    }
    public static void AssignAnimation(Animation anim, string scriptName, string name)
    {
      __sklib_ptr __skparam__anim;
      __sklib_string __skparam__script_name;
      __sklib_string __skparam__name;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__script_name = __skadapter__to_sklib_string(scriptName);
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__assign_animation__animation__string_ref__string_ref(__skparam__anim, __skparam__script_name, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__script_name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void AssignAnimation(Animation anim, string scriptName, string name, bool withSound)
    {
      __sklib_ptr __skparam__anim;
      __sklib_string __skparam__script_name;
      __sklib_string __skparam__name;
      int __skparam__with_sound;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__script_name = __skadapter__to_sklib_string(scriptName);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__assign_animation__animation__string_ref__string_ref__bool(__skparam__anim, __skparam__script_name, __skparam__name, __skparam__with_sound);
    __skadapter__free__sklib_string(ref __skparam__script_name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void AssignAnimation(Animation anim, int idx)
    {
      __sklib_ptr __skparam__anim;
      int __skparam__idx;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __sklib__assign_animation__animation__int(__skparam__anim, __skparam__idx);
    }
    public static void AssignAnimation(Animation anim, int idx, bool withSound)
    {
      __sklib_ptr __skparam__anim;
      int __skparam__idx;
      int __skparam__with_sound;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__assign_animation__animation__int__bool(__skparam__anim, __skparam__idx, __skparam__with_sound);
    }
    public static void AssignAnimation(Animation anim, string name)
    {
      __sklib_ptr __skparam__anim;
      __sklib_string __skparam__name;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__assign_animation__animation__string(__skparam__anim, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void AssignAnimation(Animation anim, string name, bool withSound)
    {
      __sklib_ptr __skparam__anim;
      __sklib_string __skparam__name;
      int __skparam__with_sound;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__assign_animation__animation__string__bool(__skparam__anim, __skparam__name, __skparam__with_sound);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static Animation CreateAnimation(AnimationScript script, int idx, bool withSound)
    {
      __sklib_ptr __skparam__script;
      int __skparam__idx;
      int __skparam__with_sound;
      __sklib_ptr __skreturn;
      __skparam__script = __skadapter__to_sklib_animation_script(script);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __skreturn = __sklib__create_animation__animation_script__int__bool(__skparam__script, __skparam__idx, __skparam__with_sound);
      return __skadapter__to_animation(__skreturn);
    }
    public static Animation CreateAnimation(AnimationScript script, string name)
    {
      __sklib_ptr __skparam__script;
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__script = __skadapter__to_sklib_animation_script(script);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__create_animation__animation_script__string_ref(__skparam__script, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_animation(__skreturn);
    }
    public static Animation CreateAnimation(AnimationScript script, string name, bool withSound)
    {
      __sklib_ptr __skparam__script;
      __sklib_string __skparam__name;
      int __skparam__with_sound;
      __sklib_ptr __skreturn;
      __skparam__script = __skadapter__to_sklib_animation_script(script);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __skreturn = __sklib__create_animation__animation_script__string_ref__bool(__skparam__script, __skparam__name, __skparam__with_sound);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_animation(__skreturn);
    }
    public static Animation CreateAnimation(string scriptName, string name)
    {
      __sklib_string __skparam__script_name;
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__script_name = __skadapter__to_sklib_string(scriptName);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__create_animation__string_ref__string_ref(__skparam__script_name, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__script_name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_animation(__skreturn);
    }
    public static Animation CreateAnimation(string scriptName, string name, bool withSound)
    {
      __sklib_string __skparam__script_name;
      __sklib_string __skparam__name;
      int __skparam__with_sound;
      __sklib_ptr __skreturn;
      __skparam__script_name = __skadapter__to_sklib_string(scriptName);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __skreturn = __sklib__create_animation__string_ref__string_ref__bool(__skparam__script_name, __skparam__name, __skparam__with_sound);
    __skadapter__free__sklib_string(ref __skparam__script_name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_animation(__skreturn);
    }
    public static void FreeAllAnimationScripts()
    {
      __sklib__free_all_animation_scripts();
    }
    public static void FreeAnimation(Animation ani)
    {
      __sklib_ptr __skparam__ani;
      __skparam__ani = __skadapter__to_sklib_animation(ani);
      __sklib__free_animation__animation(__skparam__ani);
    }
    public static void FreeAnimationScript(AnimationScript scriptToFree)
    {
      __sklib_ptr __skparam__script_to_free;
      __skparam__script_to_free = __skadapter__to_sklib_animation_script(scriptToFree);
      __sklib__free_animation_script__animation_script(__skparam__script_to_free);
    }
    public static void FreeAnimationScript(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__free_animation_script__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static bool HasAnimationNamed(AnimationScript script, string name)
    {
      __sklib_ptr __skparam__script;
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__script = __skadapter__to_sklib_animation_script(script);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_animation_named__animation_script__string_ref(__skparam__script, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool HasAnimationScript(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_animation_script__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static AnimationScript LoadAnimationScript(string name, string filename)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__filename;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __skreturn = __sklib__load_animation_script__string_ref__string_ref(__skparam__name, __skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__filename);
      return __skadapter__to_animation_script(__skreturn);
    }
    public static void RestartAnimation(Animation anim)
    {
      __sklib_ptr __skparam__anim;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __sklib__restart_animation__animation(__skparam__anim);
    }
    public static void RestartAnimation(Animation anim, bool withSound)
    {
      __sklib_ptr __skparam__anim;
      int __skparam__with_sound;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__restart_animation__animation__bool(__skparam__anim, __skparam__with_sound);
    }
    public static void UpdateAnimation(Animation anim, float pct, bool withSound)
    {
      __sklib_ptr __skparam__anim;
      float __skparam__pct;
      int __skparam__with_sound;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__pct = __skadapter__to_sklib_float(pct);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__update_animation__animation__float__bool(__skparam__anim, __skparam__pct, __skparam__with_sound);
    }
    public static void UpdateAnimation(Animation anim)
    {
      __sklib_ptr __skparam__anim;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __sklib__update_animation__animation(__skparam__anim);
    }
    public static void UpdateAnimation(Animation anim, float pct)
    {
      __sklib_ptr __skparam__anim;
      float __skparam__pct;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__pct = __skadapter__to_sklib_float(pct);
      __sklib__update_animation__animation__float(__skparam__anim, __skparam__pct);
    }
    public static bool AudioReady()
    {
      int __skreturn;
      __skreturn = __sklib__audio_ready();
      return __skadapter__to_bool(__skreturn);
    }
    public static void CloseAudio()
    {
      __sklib__close_audio();
    }
    public static void OpenAudio()
    {
      __sklib__open_audio();
    }
    public static bool Contains(string text, string subtext)
    {
      __sklib_string __skparam__text;
      __sklib_string __skparam__subtext;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__subtext = __skadapter__to_sklib_string(subtext);
      __skreturn = __sklib__contains__string_ref__string_ref(__skparam__text, __skparam__subtext);
    __skadapter__free__sklib_string(ref __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__subtext);
      return __skadapter__to_bool(__skreturn);
    }
    public static double ConvertToDouble(string text)
    {
      __sklib_string __skparam__text;
      double __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skreturn = __sklib__convert_to_double__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_double(__skreturn);
    }
    public static int ConvertToInteger(string text)
    {
      __sklib_string __skparam__text;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skreturn = __sklib__convert_to_integer__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_int(__skreturn);
    }
    public static int IndexOf(string text, string subtext)
    {
      __sklib_string __skparam__text;
      __sklib_string __skparam__subtext;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__subtext = __skadapter__to_sklib_string(subtext);
      __skreturn = __sklib__index_of__string_ref__string_ref(__skparam__text, __skparam__subtext);
    __skadapter__free__sklib_string(ref __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__subtext);
      return __skadapter__to_int(__skreturn);
    }
    public static bool IsDouble(string text)
    {
      __sklib_string __skparam__text;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skreturn = __sklib__is_double__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool IsInteger(string text)
    {
      __sklib_string __skparam__text;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skreturn = __sklib__is_integer__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool IsNumber(string text)
    {
      __sklib_string __skparam__text;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skreturn = __sklib__is_number__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_bool(__skreturn);
    }
    public static int LengthOf(string text)
    {
      __sklib_string __skparam__text;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skreturn = __sklib__length_of__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_int(__skreturn);
    }
    public static string ReplaceAll(string text, string substr, string newtext)
    {
      __sklib_string __skparam__text;
      __sklib_string __skparam__substr;
      __sklib_string __skparam__newtext;
      __sklib_string __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__substr = __skadapter__to_sklib_string(substr);
      __skparam__newtext = __skadapter__to_sklib_string(newtext);
      __skreturn = __sklib__replace_all__string_ref__string_ref__string_ref(__skparam__text, __skparam__substr, __skparam__newtext);
    __skadapter__free__sklib_string(ref __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__substr);
    __skadapter__free__sklib_string(ref __skparam__newtext);
      return __skadapter__to_string(__skreturn);
    }
    public static List<string> Split(string text, char delimiter)
    {
      __sklib_string __skparam__text;
      char __skparam__delimiter;
      __sklib_vector_string __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__delimiter = __skadapter__to_sklib_char(delimiter);
      __skreturn = __sklib__split__string_ref__char(__skparam__text, __skparam__delimiter);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_vector_string(__skreturn);
    }
    public static string ToLowercase(string text)
    {
      __sklib_string __skparam__text;
      __sklib_string __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skreturn = __sklib__to_lowercase__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_string(__skreturn);
    }
    public static string ToUppercase(string text)
    {
      __sklib_string __skparam__text;
      __sklib_string __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skreturn = __sklib__to_uppercase__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_string(__skreturn);
    }
    public static string Trim(string text)
    {
      __sklib_string __skparam__text;
      __sklib_string __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skreturn = __sklib__trim__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_string(__skreturn);
    }
    public static void FreeResourceBundle(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__free_resource_bundle__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static bool HasResourceBundle(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_resource_bundle__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static void LoadResourceBundle(string name, string filename)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__filename;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __sklib__load_resource_bundle__string_ref__string_ref(__skparam__name, __skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__filename);
    }
    public static Point2D CameraPosition()
    {
      __sklib_point_2d __skreturn;
      __skreturn = __sklib__camera_position();
      return __skadapter__to_point_2d(__skreturn);
    }
    public static double CameraX()
    {
      double __skreturn;
      __skreturn = __sklib__camera_x();
      return __skadapter__to_double(__skreturn);
    }
    public static double CameraY()
    {
      double __skreturn;
      __skreturn = __sklib__camera_y();
      return __skadapter__to_double(__skreturn);
    }
    public static void CenterCameraOn(Sprite s, Vector2D offset)
    {
      __sklib_ptr __skparam__s;
      __sklib_vector_2d __skparam__offset;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__offset = __skadapter__to_sklib_vector_2d(offset);
      __sklib__center_camera_on__sprite__vector_2d_ref(__skparam__s, __skparam__offset);
    }
    public static void CenterCameraOn(Sprite s, double offsetX, double offsetY)
    {
      __sklib_ptr __skparam__s;
      double __skparam__offset_x;
      double __skparam__offset_y;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__offset_x = __skadapter__to_sklib_double(offsetX);
      __skparam__offset_y = __skadapter__to_sklib_double(offsetY);
      __sklib__center_camera_on__sprite__double__double(__skparam__s, __skparam__offset_x, __skparam__offset_y);
    }
    public static void MoveCameraBy(Vector2D offset)
    {
      __sklib_vector_2d __skparam__offset;
      __skparam__offset = __skadapter__to_sklib_vector_2d(offset);
      __sklib__move_camera_by__vector_2d_ref(__skparam__offset);
    }
    public static void MoveCameraBy(double dx, double dy)
    {
      double __skparam__dx;
      double __skparam__dy;
      __skparam__dx = __skadapter__to_sklib_double(dx);
      __skparam__dy = __skadapter__to_sklib_double(dy);
      __sklib__move_camera_by__double__double(__skparam__dx, __skparam__dy);
    }
    public static void MoveCameraTo(Point2D pt)
    {
      __sklib_point_2d __skparam__pt;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __sklib__move_camera_to__point_2d_ref(__skparam__pt);
    }
    public static void MoveCameraTo(double x, double y)
    {
      double __skparam__x;
      double __skparam__y;
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__move_camera_to__double__double(__skparam__x, __skparam__y);
    }
    public static bool PointInWindow(Window wind, Point2D pt)
    {
      __sklib_ptr __skparam__wind;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__point_in_window__window__point_2d_ref(__skparam__wind, __skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool PointOnScreen(Point2D pt)
    {
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__point_on_screen__point_2d_ref(__skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool RectInWindow(Window wind, Rectangle rect)
    {
      __sklib_ptr __skparam__wind;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__rect_in_window__window__rectangle_ref(__skparam__wind, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool RectOnScreen(Rectangle rect)
    {
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__rect_on_screen__rectangle_ref(__skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static Point2D ScreenCenter()
    {
      __sklib_point_2d __skreturn;
      __skreturn = __sklib__screen_center();
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Rectangle ScreenRectangle()
    {
      __sklib_rectangle __skreturn;
      __skreturn = __sklib__screen_rectangle();
      return __skadapter__to_rectangle(__skreturn);
    }
    public static void SetCameraPosition(Point2D pos)
    {
      __sklib_point_2d __skparam__pos;
      __skparam__pos = __skadapter__to_sklib_point_2d(pos);
      __sklib__set_camera_position__point_2d(__skparam__pos);
    }
    public static void SetCameraX(double x)
    {
      double __skparam__x;
      __skparam__x = __skadapter__to_sklib_double(x);
      __sklib__set_camera_x__double(__skparam__x);
    }
    public static void SetCameraY(double y)
    {
      double __skparam__y;
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__set_camera_y__double(__skparam__y);
    }
    public static Point2D ToScreen(Point2D pt)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_point_2d __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__to_screen__point_2d_ref(__skparam__pt);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Rectangle ToScreen(Rectangle rect)
    {
      __sklib_rectangle __skparam__rect;
      __sklib_rectangle __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__to_screen__rectangle_ref(__skparam__rect);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static double ToScreenX(double worldX)
    {
      double __skparam__world_x;
      double __skreturn;
      __skparam__world_x = __skadapter__to_sklib_double(worldX);
      __skreturn = __sklib__to_screen_x__double(__skparam__world_x);
      return __skadapter__to_double(__skreturn);
    }
    public static double ToScreenY(double worldY)
    {
      double __skparam__world_y;
      double __skreturn;
      __skparam__world_y = __skadapter__to_sklib_double(worldY);
      __skreturn = __sklib__to_screen_y__double(__skparam__world_y);
      return __skadapter__to_double(__skreturn);
    }
    public static Point2D ToWorld(Point2D pt)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_point_2d __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__to_world__point_2d_ref(__skparam__pt);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static double ToWorldX(double screenX)
    {
      double __skparam__screen_x;
      double __skreturn;
      __skparam__screen_x = __skadapter__to_sklib_double(screenX);
      __skreturn = __sklib__to_world_x__double(__skparam__screen_x);
      return __skadapter__to_double(__skreturn);
    }
    public static double ToWorldY(double screenY)
    {
      double __skparam__screen_y;
      double __skreturn;
      __skparam__screen_y = __skadapter__to_sklib_double(screenY);
      __skreturn = __sklib__to_world_y__double(__skparam__screen_y);
      return __skadapter__to_double(__skreturn);
    }
    public static Vector2D VectorWorldToScreen()
    {
      __sklib_vector_2d __skreturn;
      __skreturn = __sklib__vector_world_to_screen();
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Rectangle WindowArea(Window wind)
    {
      __sklib_ptr __skparam__wind;
      __sklib_rectangle __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skreturn = __sklib__window_area__window(__skparam__wind);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static void DrawCircle(Color clr, Circle c)
    {
      __sklib_color __skparam__clr;
      __sklib_circle __skparam__c;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __sklib__draw_circle__color__circle_ref(__skparam__clr, __skparam__c);
    }
    public static void DrawCircle(Color clr, Circle c, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_circle __skparam__c;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_circle__color__circle_ref__drawing_options(__skparam__clr, __skparam__c, __skparam__opts);
    }
    public static void DrawCircle(Color clr, double x, double y, double radius)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __sklib__draw_circle__color__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
    }
    public static void DrawCircle(Color clr, double x, double y, double radius, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_circle__color__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
    }
    public static void DrawCircleOnBitmap(Bitmap destination, Color clr, double x, double y, double radius)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __sklib__draw_circle_on_bitmap__bitmap__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
    }
    public static void DrawCircleOnBitmap(Bitmap destination, Color clr, double x, double y, double radius, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
    }
    public static void DrawCircleOnWindow(Window destination, Color clr, double x, double y, double radius)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __sklib__draw_circle_on_window__window__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
    }
    public static void DrawCircleOnWindow(Window destination, Color clr, double x, double y, double radius, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_circle_on_window__window__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
    }
    public static void FillCircle(Color clr, Circle c)
    {
      __sklib_color __skparam__clr;
      __sklib_circle __skparam__c;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __sklib__fill_circle__color__circle_ref(__skparam__clr, __skparam__c);
    }
    public static void FillCircle(Color clr, Circle c, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_circle __skparam__c;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_circle__color__circle_ref__drawing_options(__skparam__clr, __skparam__c, __skparam__opts);
    }
    public static void FillCircle(Color clr, double x, double y, double radius)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __sklib__fill_circle__color__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
    }
    public static void FillCircle(Color clr, double x, double y, double radius, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_circle__color__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
    }
    public static void FillCircleOnBitmap(Bitmap destination, Color clr, double x, double y, double radius)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __sklib__fill_circle_on_bitmap__bitmap__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
    }
    public static void FillCircleOnBitmap(Bitmap destination, Color clr, double x, double y, double radius, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_circle_on_bitmap__bitmap__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
    }
    public static void FillCircleOnWindow(Window destination, Color clr, double x, double y, double radius)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __sklib__fill_circle_on_window__window__color__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius);
    }
    public static void FillCircleOnWindow(Window destination, Color clr, double x, double y, double radius, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_circle_on_window__window__color__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__radius, __skparam__opts);
    }
    public static Point2D CenterPoint(Circle c)
    {
      __sklib_circle __skparam__c;
      __sklib_point_2d __skreturn;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skreturn = __sklib__center_point__circle_ref(__skparam__c);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Circle CircleAt(Point2D pt, double radius)
    {
      __sklib_point_2d __skparam__pt;
      double __skparam__radius;
      __sklib_circle __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __skreturn = __sklib__circle_at__point_2d_ref__double(__skparam__pt, __skparam__radius);
      return __skadapter__to_circle(__skreturn);
    }
    public static Circle CircleAt(double x, double y, double radius)
    {
      double __skparam__x;
      double __skparam__y;
      double __skparam__radius;
      __sklib_circle __skreturn;
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __skreturn = __sklib__circle_at__double__double__double(__skparam__x, __skparam__y, __skparam__radius);
      return __skadapter__to_circle(__skreturn);
    }
    public static float CircleRadius(Circle c)
    {
      __sklib_circle __skparam__c;
      float __skreturn;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skreturn = __sklib__circle_radius__circle(__skparam__c);
      return __skadapter__to_float(__skreturn);
    }
    public static bool CircleTriangleIntersect(Circle c, Triangle tri)
    {
      __sklib_circle __skparam__c;
      __sklib_triangle __skparam__tri;
      int __skreturn;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skreturn = __sklib__circle_triangle_intersect__circle_ref__triangle_ref(__skparam__c, __skparam__tri);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool CircleTriangleIntersect(Circle c, Triangle tri, ref Point2D p)
    {
      __sklib_circle __skparam__c;
      __sklib_triangle __skparam__tri;
      __sklib_point_2d __skparam__p;
      int __skreturn;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skparam__p = __skadapter__to_sklib_point_2d(p);
      __skreturn = __sklib__circle_triangle_intersect__circle_ref__triangle_ref__point_2d_ref(__skparam__c, __skparam__tri, ref __skparam__p);
      p = __skadapter__to_point_2d(__skparam__p);
      return __skadapter__to_bool(__skreturn);
    }
    public static float CircleX(Circle c)
    {
      __sklib_circle __skparam__c;
      float __skreturn;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skreturn = __sklib__circle_x__circle_ref(__skparam__c);
      return __skadapter__to_float(__skreturn);
    }
    public static float CircleY(Circle c)
    {
      __sklib_circle __skparam__c;
      float __skreturn;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skreturn = __sklib__circle_y__circle_ref(__skparam__c);
      return __skadapter__to_float(__skreturn);
    }
    public static bool CirclesIntersect(Circle c1, Circle c2)
    {
      __sklib_circle __skparam__c1;
      __sklib_circle __skparam__c2;
      int __skreturn;
      __skparam__c1 = __skadapter__to_sklib_circle(c1);
      __skparam__c2 = __skadapter__to_sklib_circle(c2);
      __skreturn = __sklib__circles_intersect__circle__circle(__skparam__c1, __skparam__c2);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool CirclesIntersect(double c1X, double c1Y, double c1Radius, double c2X, double c2Y, double c2Radius)
    {
      double __skparam__c1_x;
      double __skparam__c1_y;
      double __skparam__c1_radius;
      double __skparam__c2_x;
      double __skparam__c2_y;
      double __skparam__c2_radius;
      int __skreturn;
      __skparam__c1_x = __skadapter__to_sklib_double(c1X);
      __skparam__c1_y = __skadapter__to_sklib_double(c1Y);
      __skparam__c1_radius = __skadapter__to_sklib_double(c1Radius);
      __skparam__c2_x = __skadapter__to_sklib_double(c2X);
      __skparam__c2_y = __skadapter__to_sklib_double(c2Y);
      __skparam__c2_radius = __skadapter__to_sklib_double(c2Radius);
      __skreturn = __sklib__circles_intersect__double__double__double__double__double__double(__skparam__c1_x, __skparam__c1_y, __skparam__c1_radius, __skparam__c2_x, __skparam__c2_y, __skparam__c2_radius);
      return __skadapter__to_bool(__skreturn);
    }
    public static Point2D ClosestPointOnCircle(Point2D fromPt, Circle c)
    {
      __sklib_point_2d __skparam__from_pt;
      __sklib_circle __skparam__c;
      __sklib_point_2d __skreturn;
      __skparam__from_pt = __skadapter__to_sklib_point_2d(fromPt);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skreturn = __sklib__closest_point_on_circle__point_2d_ref__circle_ref(__skparam__from_pt, __skparam__c);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Point2D ClosestPointOnLineFromCircle(Circle c, Line l)
    {
      __sklib_circle __skparam__c;
      __sklib_line __skparam__l;
      __sklib_point_2d __skreturn;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__l = __skadapter__to_sklib_line(l);
      __skreturn = __sklib__closest_point_on_line_from_circle__circle_ref__line_ref(__skparam__c, __skparam__l);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Point2D ClosestPointOnRectFromCircle(Circle c, Rectangle rect)
    {
      __sklib_circle __skparam__c;
      __sklib_rectangle __skparam__rect;
      __sklib_point_2d __skreturn;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__closest_point_on_rect_from_circle__circle_ref__rectangle_ref(__skparam__c, __skparam__rect);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Point2D ClosestPointOnTriangleFromCircle(Circle c, Triangle tri)
    {
      __sklib_circle __skparam__c;
      __sklib_triangle __skparam__tri;
      __sklib_point_2d __skreturn;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skreturn = __sklib__closest_point_on_triangle_from_circle__circle_ref__triangle_ref(__skparam__c, __skparam__tri);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Point2D DistantPointOnCircle(Point2D pt, Circle c)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_circle __skparam__c;
      __sklib_point_2d __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skreturn = __sklib__distant_point_on_circle__point_2d_ref__circle_ref(__skparam__pt, __skparam__c);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static bool DistantPointOnCircleHeading(Point2D pt, Circle c, Vector2D heading, ref Point2D oppositePt)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_circle __skparam__c;
      __sklib_vector_2d __skparam__heading;
      __sklib_point_2d __skparam__opposite_pt;
      int __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__heading = __skadapter__to_sklib_vector_2d(heading);
      __skparam__opposite_pt = __skadapter__to_sklib_point_2d(oppositePt);
      __skreturn = __sklib__distant_point_on_circle_heading__point_2d_ref__circle_ref__vector_2d_ref__point_2d_ref(__skparam__pt, __skparam__c, __skparam__heading, ref __skparam__opposite_pt);
      oppositePt = __skadapter__to_point_2d(__skparam__opposite_pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static float RayCircleIntersectDistance(Point2D rayOrigin, Vector2D rayHeading, Circle c)
    {
      __sklib_point_2d __skparam__ray_origin;
      __sklib_vector_2d __skparam__ray_heading;
      __sklib_circle __skparam__c;
      float __skreturn;
      __skparam__ray_origin = __skadapter__to_sklib_point_2d(rayOrigin);
      __skparam__ray_heading = __skadapter__to_sklib_vector_2d(rayHeading);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skreturn = __sklib__ray_circle_intersect_distance__point_2d_ref__vector_2d_ref__circle_ref(__skparam__ray_origin, __skparam__ray_heading, __skparam__c);
      return __skadapter__to_float(__skreturn);
    }
    public static bool TangentPoints(Point2D fromPt, Circle c, ref Point2D p1, ref Point2D p2)
    {
      __sklib_point_2d __skparam__from_pt;
      __sklib_circle __skparam__c;
      __sklib_point_2d __skparam__p1;
      __sklib_point_2d __skparam__p2;
      int __skreturn;
      __skparam__from_pt = __skadapter__to_sklib_point_2d(fromPt);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__p1 = __skadapter__to_sklib_point_2d(p1);
      __skparam__p2 = __skadapter__to_sklib_point_2d(p2);
      __skreturn = __sklib__tangent_points__point_2d_ref__circle_ref__point_2d_ref__point_2d_ref(__skparam__from_pt, __skparam__c, ref __skparam__p1, ref __skparam__p2);
      p1 = __skadapter__to_point_2d(__skparam__p1);
      p2 = __skadapter__to_point_2d(__skparam__p2);
      return __skadapter__to_bool(__skreturn);
    }
    public static void WidestPoints(Circle c, Vector2D along, ref Point2D pt1, ref Point2D pt2)
    {
      __sklib_circle __skparam__c;
      __sklib_vector_2d __skparam__along;
      __sklib_point_2d __skparam__pt1;
      __sklib_point_2d __skparam__pt2;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__along = __skadapter__to_sklib_vector_2d(along);
      __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1);
      __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2);
      __sklib__widest_points__circle_ref__vector_2d_ref__point_2d_ref__point_2d_ref(__skparam__c, __skparam__along, ref __skparam__pt1, ref __skparam__pt2);
      pt1 = __skadapter__to_point_2d(__skparam__pt1);
      pt2 = __skadapter__to_point_2d(__skparam__pt2);
    }
    public static Rectangle CurrentClip()
    {
      __sklib_rectangle __skreturn;
      __skreturn = __sklib__current_clip();
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle CurrentClip(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_rectangle __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__current_clip__bitmap(__skparam__bmp);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle CurrentClip(Window wnd)
    {
      __sklib_ptr __skparam__wnd;
      __sklib_rectangle __skreturn;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skreturn = __sklib__current_clip__window(__skparam__wnd);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static void PopClip(Window wnd)
    {
      __sklib_ptr __skparam__wnd;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __sklib__pop_clip__window(__skparam__wnd);
    }
    public static void PopClip()
    {
      __sklib__pop_clip();
    }
    public static void PopClip(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __sklib__pop_clip__bitmap(__skparam__bmp);
    }
    public static void PushClip(Window wnd, Rectangle r)
    {
      __sklib_ptr __skparam__wnd;
      __sklib_rectangle __skparam__r;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skparam__r = __skadapter__to_sklib_rectangle(r);
      __sklib__push_clip__window__rectangle_ref(__skparam__wnd, __skparam__r);
    }
    public static void PushClip(Bitmap bmp, Rectangle r)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_rectangle __skparam__r;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__r = __skadapter__to_sklib_rectangle(r);
      __sklib__push_clip__bitmap__rectangle_ref(__skparam__bmp, __skparam__r);
    }
    public static void PushClip(Rectangle r)
    {
      __sklib_rectangle __skparam__r;
      __skparam__r = __skadapter__to_sklib_rectangle(r);
      __sklib__push_clip__rectangle_ref(__skparam__r);
    }
    public static void ResetClip(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __sklib__reset_clip__bitmap(__skparam__bmp);
    }
    public static void ResetClip()
    {
      __sklib__reset_clip();
    }
    public static void ResetClip(Window wnd)
    {
      __sklib_ptr __skparam__wnd;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __sklib__reset_clip__window(__skparam__wnd);
    }
    public static void SetClip(Rectangle r)
    {
      __sklib_rectangle __skparam__r;
      __skparam__r = __skadapter__to_sklib_rectangle(r);
      __sklib__set_clip__rectangle_ref(__skparam__r);
    }
    public static void SetClip(Bitmap bmp, Rectangle r)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_rectangle __skparam__r;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__r = __skadapter__to_sklib_rectangle(r);
      __sklib__set_clip__bitmap__rectangle_ref(__skparam__bmp, __skparam__r);
    }
    public static void SetClip(Window wnd, Rectangle r)
    {
      __sklib_ptr __skparam__wnd;
      __sklib_rectangle __skparam__r;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skparam__r = __skadapter__to_sklib_rectangle(r);
      __sklib__set_clip__window__rectangle_ref(__skparam__wnd, __skparam__r);
    }
    public static bool BitmapCircleCollision(Bitmap bmp, Point2D pt, Circle circ)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_point_2d __skparam__pt;
      __sklib_circle __skparam__circ;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__circ = __skadapter__to_sklib_circle(circ);
      __skreturn = __sklib__bitmap_circle_collision__bitmap__point_2d_ref__circle_ref(__skparam__bmp, __skparam__pt, __skparam__circ);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapCircleCollision(Bitmap bmp, double x, double y, Circle circ)
    {
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      __sklib_circle __skparam__circ;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__circ = __skadapter__to_sklib_circle(circ);
      __skreturn = __sklib__bitmap_circle_collision__bitmap__double__double__circle_ref(__skparam__bmp, __skparam__x, __skparam__y, __skparam__circ);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapCircleCollision(Bitmap bmp, int cell, Matrix2D translation, Circle circ)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      __sklib_matrix_2d __skparam__translation;
      __sklib_circle __skparam__circ;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__translation = __skadapter__to_sklib_matrix_2d(translation);
      __skparam__circ = __skadapter__to_sklib_circle(circ);
      __skreturn = __sklib__bitmap_circle_collision__bitmap__int__matrix_2d_ref__circle_ref(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__circ);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapCircleCollision(Bitmap bmp, int cell, Point2D pt, Circle circ)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      __sklib_point_2d __skparam__pt;
      __sklib_circle __skparam__circ;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__circ = __skadapter__to_sklib_circle(circ);
      __skreturn = __sklib__bitmap_circle_collision__bitmap__int__point_2d_ref__circle_ref(__skparam__bmp, __skparam__cell, __skparam__pt, __skparam__circ);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapCircleCollision(Bitmap bmp, int cell, double x, double y, Circle circ)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      double __skparam__x;
      double __skparam__y;
      __sklib_circle __skparam__circ;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__circ = __skadapter__to_sklib_circle(circ);
      __skreturn = __sklib__bitmap_circle_collision__bitmap__int__double__double__circle_ref(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y, __skparam__circ);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapCollision(Bitmap bmp1, double x1, double y1, Bitmap bmp2, double x2, double y2)
    {
      __sklib_ptr __skparam__bmp1;
      double __skparam__x1;
      double __skparam__y1;
      __sklib_ptr __skparam__bmp2;
      double __skparam__x2;
      double __skparam__y2;
      int __skreturn;
      __skparam__bmp1 = __skadapter__to_sklib_bitmap(bmp1);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__bmp2 = __skadapter__to_sklib_bitmap(bmp2);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skreturn = __sklib__bitmap_collision__bitmap__double__double__bitmap__double__double(__skparam__bmp1, __skparam__x1, __skparam__y1, __skparam__bmp2, __skparam__x2, __skparam__y2);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapCollision(Bitmap bmp1, Point2D pt1, Bitmap bmp2, Point2D pt2)
    {
      __sklib_ptr __skparam__bmp1;
      __sklib_point_2d __skparam__pt1;
      __sklib_ptr __skparam__bmp2;
      __sklib_point_2d __skparam__pt2;
      int __skreturn;
      __skparam__bmp1 = __skadapter__to_sklib_bitmap(bmp1);
      __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1);
      __skparam__bmp2 = __skadapter__to_sklib_bitmap(bmp2);
      __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2);
      __skreturn = __sklib__bitmap_collision__bitmap__point_2d_ref__bitmap__point_2d_ref(__skparam__bmp1, __skparam__pt1, __skparam__bmp2, __skparam__pt2);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapCollision(Bitmap bmp1, int cell1, Matrix2D matrix1, Bitmap bmp2, int cell2, Matrix2D matrix2)
    {
      __sklib_ptr __skparam__bmp1;
      int __skparam__cell1;
      __sklib_matrix_2d __skparam__matrix1;
      __sklib_ptr __skparam__bmp2;
      int __skparam__cell2;
      __sklib_matrix_2d __skparam__matrix2;
      int __skreturn;
      __skparam__bmp1 = __skadapter__to_sklib_bitmap(bmp1);
      __skparam__cell1 = __skadapter__to_sklib_int(cell1);
      __skparam__matrix1 = __skadapter__to_sklib_matrix_2d(matrix1);
      __skparam__bmp2 = __skadapter__to_sklib_bitmap(bmp2);
      __skparam__cell2 = __skadapter__to_sklib_int(cell2);
      __skparam__matrix2 = __skadapter__to_sklib_matrix_2d(matrix2);
      __skreturn = __sklib__bitmap_collision__bitmap__int__matrix_2d_ref__bitmap__int__matrix_2d_ref(__skparam__bmp1, __skparam__cell1, __skparam__matrix1, __skparam__bmp2, __skparam__cell2, __skparam__matrix2);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapCollision(Bitmap bmp1, int cell1, Point2D pt1, Bitmap bmp2, int cell2, Point2D pt2)
    {
      __sklib_ptr __skparam__bmp1;
      int __skparam__cell1;
      __sklib_point_2d __skparam__pt1;
      __sklib_ptr __skparam__bmp2;
      int __skparam__cell2;
      __sklib_point_2d __skparam__pt2;
      int __skreturn;
      __skparam__bmp1 = __skadapter__to_sklib_bitmap(bmp1);
      __skparam__cell1 = __skadapter__to_sklib_int(cell1);
      __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1);
      __skparam__bmp2 = __skadapter__to_sklib_bitmap(bmp2);
      __skparam__cell2 = __skadapter__to_sklib_int(cell2);
      __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2);
      __skreturn = __sklib__bitmap_collision__bitmap__int__point_2d_ref__bitmap__int__point_2d_ref(__skparam__bmp1, __skparam__cell1, __skparam__pt1, __skparam__bmp2, __skparam__cell2, __skparam__pt2);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapCollision(Bitmap bmp1, int cell1, double x1, double y1, Bitmap bmp2, int cell2, double x2, double y2)
    {
      __sklib_ptr __skparam__bmp1;
      int __skparam__cell1;
      double __skparam__x1;
      double __skparam__y1;
      __sklib_ptr __skparam__bmp2;
      int __skparam__cell2;
      double __skparam__x2;
      double __skparam__y2;
      int __skreturn;
      __skparam__bmp1 = __skadapter__to_sklib_bitmap(bmp1);
      __skparam__cell1 = __skadapter__to_sklib_int(cell1);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__bmp2 = __skadapter__to_sklib_bitmap(bmp2);
      __skparam__cell2 = __skadapter__to_sklib_int(cell2);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skreturn = __sklib__bitmap_collision__bitmap__int__double__double__bitmap__int__double__double(__skparam__bmp1, __skparam__cell1, __skparam__x1, __skparam__y1, __skparam__bmp2, __skparam__cell2, __skparam__x2, __skparam__y2);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapPointCollision(Bitmap bmp, Matrix2D translation, Point2D pt)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_matrix_2d __skparam__translation;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__translation = __skadapter__to_sklib_matrix_2d(translation);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__bitmap_point_collision__bitmap__matrix_2d_ref__point_2d_ref(__skparam__bmp, __skparam__translation, __skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapPointCollision(Bitmap bmp, Point2D bmpPt, Point2D pt)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_point_2d __skparam__bmp_pt;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__bmp_pt = __skadapter__to_sklib_point_2d(bmpPt);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__bitmap_point_collision__bitmap__point_2d_ref__point_2d_ref(__skparam__bmp, __skparam__bmp_pt, __skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapPointCollision(Bitmap bmp, double bmpX, double bmpY, double x, double y)
    {
      __sklib_ptr __skparam__bmp;
      double __skparam__bmp_x;
      double __skparam__bmp_y;
      double __skparam__x;
      double __skparam__y;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__bmp_x = __skadapter__to_sklib_double(bmpX);
      __skparam__bmp_y = __skadapter__to_sklib_double(bmpY);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__bitmap_point_collision__bitmap__double__double__double__double(__skparam__bmp, __skparam__bmp_x, __skparam__bmp_y, __skparam__x, __skparam__y);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapPointCollision(Bitmap bmp, int cell, Matrix2D translation, Point2D pt)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      __sklib_matrix_2d __skparam__translation;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__translation = __skadapter__to_sklib_matrix_2d(translation);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__bitmap_point_collision__bitmap__int__matrix_2d_ref__point_2d_ref(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapPointCollision(Bitmap bmp, int cell, Point2D bmpPt, Point2D pt)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      __sklib_point_2d __skparam__bmp_pt;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__bmp_pt = __skadapter__to_sklib_point_2d(bmpPt);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__bitmap_point_collision__bitmap__int__point_2d_ref__point_2d_ref(__skparam__bmp, __skparam__cell, __skparam__bmp_pt, __skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapPointCollision(Bitmap bmp, int cell, double bmpX, double bmpY, double x, double y)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      double __skparam__bmp_x;
      double __skparam__bmp_y;
      double __skparam__x;
      double __skparam__y;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__bmp_x = __skadapter__to_sklib_double(bmpX);
      __skparam__bmp_y = __skadapter__to_sklib_double(bmpY);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__bitmap_point_collision__bitmap__int__double__double__double__double(__skparam__bmp, __skparam__cell, __skparam__bmp_x, __skparam__bmp_y, __skparam__x, __skparam__y);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapRectangleCollision(Bitmap bmp, Point2D pt, Rectangle rect)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_point_2d __skparam__pt;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__bitmap_rectangle_collision__bitmap__point_2d_ref__rectangle_ref(__skparam__bmp, __skparam__pt, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapRectangleCollision(Bitmap bmp, double x, double y, Rectangle rect)
    {
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__bitmap_rectangle_collision__bitmap__double__double__rectangle_ref(__skparam__bmp, __skparam__x, __skparam__y, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapRectangleCollision(Bitmap bmp, int cell, Matrix2D translation, Rectangle rect)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      __sklib_matrix_2d __skparam__translation;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__translation = __skadapter__to_sklib_matrix_2d(translation);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__bitmap_rectangle_collision__bitmap__int__matrix_2d_ref__rectangle_ref(__skparam__bmp, __skparam__cell, __skparam__translation, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapRectangleCollision(Bitmap bmp, int cell, Point2D pt, Rectangle rect)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      __sklib_point_2d __skparam__pt;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__bitmap_rectangle_collision__bitmap__int__point_2d_ref__rectangle_ref(__skparam__bmp, __skparam__cell, __skparam__pt, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapRectangleCollision(Bitmap bmp, int cell, double x, double y, Rectangle rect)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      double __skparam__x;
      double __skparam__y;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__bitmap_rectangle_collision__bitmap__int__double__double__rectangle_ref(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool SpriteBitmapCollision(Sprite s, Bitmap bmp, double x, double y)
    {
      __sklib_ptr __skparam__s;
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__sprite_bitmap_collision__sprite__bitmap__double__double(__skparam__s, __skparam__bmp, __skparam__x, __skparam__y);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool SpriteBitmapCollision(Sprite s, Bitmap bmp, int cell, Point2D pt)
    {
      __sklib_ptr __skparam__s;
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__sprite_bitmap_collision__sprite__bitmap__int__point_2d_ref(__skparam__s, __skparam__bmp, __skparam__cell, __skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool SpriteBitmapCollision(Sprite s, Bitmap bmp, int cell, double x, double y)
    {
      __sklib_ptr __skparam__s;
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      double __skparam__x;
      double __skparam__y;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__sprite_bitmap_collision__sprite__bitmap__int__double__double(__skparam__s, __skparam__bmp, __skparam__cell, __skparam__x, __skparam__y);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool SpriteCollision(Sprite s1, Sprite s2)
    {
      __sklib_ptr __skparam__s1;
      __sklib_ptr __skparam__s2;
      int __skreturn;
      __skparam__s1 = __skadapter__to_sklib_sprite(s1);
      __skparam__s2 = __skadapter__to_sklib_sprite(s2);
      __skreturn = __sklib__sprite_collision__sprite__sprite(__skparam__s1, __skparam__s2);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool SpritePointCollision(Sprite s, Point2D pt)
    {
      __sklib_ptr __skparam__s;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__sprite_point_collision__sprite__point_2d_ref(__skparam__s, __skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool SpriteRectangleCollision(Sprite s, Rectangle rect)
    {
      __sklib_ptr __skparam__s;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__sprite_rectangle_collision__sprite__rectangle_ref(__skparam__s, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static int AlphaOf(Color c)
    {
      __sklib_color __skparam__c;
      int __skreturn;
      __skparam__c = __skadapter__to_sklib_color(c);
      __skreturn = __sklib__alpha_of__color(__skparam__c);
      return __skadapter__to_int(__skreturn);
    }
    public static int BlueOf(Color c)
    {
      __sklib_color __skparam__c;
      int __skreturn;
      __skparam__c = __skadapter__to_sklib_color(c);
      __skreturn = __sklib__blue_of__color(__skparam__c);
      return __skadapter__to_int(__skreturn);
    }
    public static double BrightnessOf(Color c)
    {
      __sklib_color __skparam__c;
      double __skreturn;
      __skparam__c = __skadapter__to_sklib_color(c);
      __skreturn = __sklib__brightness_of__color(__skparam__c);
      return __skadapter__to_double(__skreturn);
    }
    public static Color ColorAliceBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_alice_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorAntiqueWhite()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_antique_white();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorAqua()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_aqua();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorAquamarine()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_aquamarine();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorAzure()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_azure();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorBeige()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_beige();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorBisque()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_bisque();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorBlack()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_black();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorBlanchedAlmond()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_blanched_almond();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorBlueViolet()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_blue_violet();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorBrightGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_bright_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorBrown()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_brown();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorBurlyWood()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_burly_wood();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorCadetBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_cadet_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorChartreuse()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_chartreuse();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorChocolate()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_chocolate();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorCoral()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_coral();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorCornflowerBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_cornflower_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorCornsilk()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_cornsilk();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorCrimson()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_crimson();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorCyan()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_cyan();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkCyan()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_cyan();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkGoldenrod()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_goldenrod();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkGray()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_gray();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkKhaki()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_khaki();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkMagenta()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_magenta();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkOliveGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_olive_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkOrange()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_orange();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkOrchid()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_orchid();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkRed()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_red();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkSalmon()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_salmon();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkSeaGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_sea_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkSlateBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_slate_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkSlateGray()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_slate_gray();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkTurquoise()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_turquoise();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDarkViolet()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dark_violet();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDeepPink()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_deep_pink();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDeepSkyBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_deep_sky_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDimGray()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dim_gray();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorDodgerBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_dodger_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorFirebrick()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_firebrick();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorFloralWhite()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_floral_white();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorForestGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_forest_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorFuchsia()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_fuchsia();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorGainsboro()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_gainsboro();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorGhostWhite()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_ghost_white();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorGold()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_gold();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorGoldenrod()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_goldenrod();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorGray()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_gray();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorGreenYellow()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_green_yellow();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorHoneydew()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_honeydew();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorHotPink()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_hot_pink();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorIndianRed()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_indian_red();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorIndigo()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_indigo();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorIvory()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_ivory();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorKhaki()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_khaki();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLavender()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_lavender();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLavenderBlush()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_lavender_blush();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLawnGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_lawn_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLemonChiffon()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_lemon_chiffon();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightCoral()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_coral();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightCyan()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_cyan();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightGoldenrodYellow()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_goldenrod_yellow();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightGray()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_gray();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightPink()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_pink();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightSalmon()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_salmon();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightSeaGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_sea_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightSkyBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_sky_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightSlateGray()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_slate_gray();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightSteelBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_steel_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLightYellow()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_light_yellow();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLime()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_lime();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLimeGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_lime_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorLinen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_linen();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMagenta()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_magenta();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMaroon()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_maroon();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMediumAquamarine()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_medium_aquamarine();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMediumBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_medium_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMediumOrchid()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_medium_orchid();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMediumPurple()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_medium_purple();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMediumSeaGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_medium_sea_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMediumSlateBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_medium_slate_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMediumSpringGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_medium_spring_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMediumTurquoise()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_medium_turquoise();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMediumVioletRed()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_medium_violet_red();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMidnightBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_midnight_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMintCream()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_mint_cream();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMistyRose()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_misty_rose();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorMoccasin()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_moccasin();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorNavajoWhite()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_navajo_white();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorNavy()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_navy();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorOldLace()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_old_lace();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorOlive()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_olive();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorOliveDrab()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_olive_drab();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorOrange()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_orange();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorOrangeRed()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_orange_red();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorOrchid()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_orchid();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorPaleGoldenrod()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_pale_goldenrod();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorPaleGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_pale_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorPaleTurquoise()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_pale_turquoise();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorPaleVioletRed()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_pale_violet_red();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorPapayaWhip()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_papaya_whip();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorPeachPuff()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_peach_puff();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorPeru()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_peru();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorPink()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_pink();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorPlum()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_plum();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorPowderBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_powder_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorPurple()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_purple();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorRed()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_red();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorRosyBrown()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_rosy_brown();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorRoyalBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_royal_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSaddleBrown()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_saddle_brown();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSalmon()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_salmon();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSandyBrown()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_sandy_brown();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSeaGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_sea_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSeaShell()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_sea_shell();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSienna()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_sienna();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSilver()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_silver();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSkyBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_sky_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSlateBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_slate_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSlateGray()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_slate_gray();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSnow()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_snow();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSpringGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_spring_green();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSteelBlue()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_steel_blue();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSwinburneRed()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_swinburne_red();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorTan()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_tan();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorTeal()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_teal();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorThistle()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_thistle();
      return __skadapter__to_color(__skreturn);
    }
    public static string ColorToString(Color c)
    {
      __sklib_color __skparam__c;
      __sklib_string __skreturn;
      __skparam__c = __skadapter__to_sklib_color(c);
      __skreturn = __sklib__color_to_string__color(__skparam__c);
      return __skadapter__to_string(__skreturn);
    }
    public static Color ColorTomato()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_tomato();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorTransparent()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_transparent();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorTurquoise()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_turquoise();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorViolet()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_violet();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorWheat()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_wheat();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorWhite()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_white();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorWhiteSmoke()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_white_smoke();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorYellow()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_yellow();
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorYellowGreen()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__color_yellow_green();
      return __skadapter__to_color(__skreturn);
    }
    public static int GreenOf(Color c)
    {
      __sklib_color __skparam__c;
      int __skreturn;
      __skparam__c = __skadapter__to_sklib_color(c);
      __skreturn = __sklib__green_of__color(__skparam__c);
      return __skadapter__to_int(__skreturn);
    }
    public static Color HSBColor(double hue, double saturation, double brightness)
    {
      double __skparam__hue;
      double __skparam__saturation;
      double __skparam__brightness;
      __sklib_color __skreturn;
      __skparam__hue = __skadapter__to_sklib_double(hue);
      __skparam__saturation = __skadapter__to_sklib_double(saturation);
      __skparam__brightness = __skadapter__to_sklib_double(brightness);
      __skreturn = __sklib__hsb_color__double__double__double(__skparam__hue, __skparam__saturation, __skparam__brightness);
      return __skadapter__to_color(__skreturn);
    }
    public static double HueOf(Color c)
    {
      __sklib_color __skparam__c;
      double __skreturn;
      __skparam__c = __skadapter__to_sklib_color(c);
      __skreturn = __sklib__hue_of__color(__skparam__c);
      return __skadapter__to_double(__skreturn);
    }
    public static Color RandomColor()
    {
      __sklib_color __skreturn;
      __skreturn = __sklib__random_color();
      return __skadapter__to_color(__skreturn);
    }
    public static Color RandomRGBColor(int alpha)
    {
      int __skparam__alpha;
      __sklib_color __skreturn;
      __skparam__alpha = __skadapter__to_sklib_int(alpha);
      __skreturn = __sklib__random_rgb_color__int(__skparam__alpha);
      return __skadapter__to_color(__skreturn);
    }
    public static int RedOf(Color c)
    {
      __sklib_color __skparam__c;
      int __skreturn;
      __skparam__c = __skadapter__to_sklib_color(c);
      __skreturn = __sklib__red_of__color(__skparam__c);
      return __skadapter__to_int(__skreturn);
    }
    public static Color RGBColor(double red, double green, double blue)
    {
      double __skparam__red;
      double __skparam__green;
      double __skparam__blue;
      __sklib_color __skreturn;
      __skparam__red = __skadapter__to_sklib_double(red);
      __skparam__green = __skadapter__to_sklib_double(green);
      __skparam__blue = __skadapter__to_sklib_double(blue);
      __skreturn = __sklib__rgb_color__double__double__double(__skparam__red, __skparam__green, __skparam__blue);
      return __skadapter__to_color(__skreturn);
    }
    public static Color RGBColor(int red, int green, int blue)
    {
      int __skparam__red;
      int __skparam__green;
      int __skparam__blue;
      __sklib_color __skreturn;
      __skparam__red = __skadapter__to_sklib_int(red);
      __skparam__green = __skadapter__to_sklib_int(green);
      __skparam__blue = __skadapter__to_sklib_int(blue);
      __skreturn = __sklib__rgb_color__int__int__int(__skparam__red, __skparam__green, __skparam__blue);
      return __skadapter__to_color(__skreturn);
    }
    public static Color RGBAColor(double red, double green, double blue, double alpha)
    {
      double __skparam__red;
      double __skparam__green;
      double __skparam__blue;
      double __skparam__alpha;
      __sklib_color __skreturn;
      __skparam__red = __skadapter__to_sklib_double(red);
      __skparam__green = __skadapter__to_sklib_double(green);
      __skparam__blue = __skadapter__to_sklib_double(blue);
      __skparam__alpha = __skadapter__to_sklib_double(alpha);
      __skreturn = __sklib__rgba_color__double__double__double__double(__skparam__red, __skparam__green, __skparam__blue, __skparam__alpha);
      return __skadapter__to_color(__skreturn);
    }
    public static Color RGBAColor(int red, int green, int blue, int alpha)
    {
      int __skparam__red;
      int __skparam__green;
      int __skparam__blue;
      int __skparam__alpha;
      __sklib_color __skreturn;
      __skparam__red = __skadapter__to_sklib_int(red);
      __skparam__green = __skadapter__to_sklib_int(green);
      __skparam__blue = __skadapter__to_sklib_int(blue);
      __skparam__alpha = __skadapter__to_sklib_int(alpha);
      __skreturn = __sklib__rgba_color__int__int__int__int(__skparam__red, __skparam__green, __skparam__blue, __skparam__alpha);
      return __skadapter__to_color(__skreturn);
    }
    public static double SaturationOf(Color c)
    {
      __sklib_color __skparam__c;
      double __skreturn;
      __skparam__c = __skadapter__to_sklib_color(c);
      __skreturn = __sklib__saturation_of__color(__skparam__c);
      return __skadapter__to_double(__skreturn);
    }
    public static Color StringToColor(string str)
    {
      __sklib_string __skparam__str;
      __sklib_color __skreturn;
      __skparam__str = __skadapter__to_sklib_string(str);
      __skreturn = __sklib__string_to_color__string(__skparam__str);
    __skadapter__free__sklib_string(ref __skparam__str);
      return __skadapter__to_color(__skreturn);
    }
    public static DrawingOptions OptionDefaults()
    {
      __sklib_drawing_options __skreturn;
      __skreturn = __sklib__option_defaults();
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionDrawTo(Bitmap dest)
    {
      __sklib_ptr __skparam__dest;
      __sklib_drawing_options __skreturn;
      __skparam__dest = __skadapter__to_sklib_bitmap(dest);
      __skreturn = __sklib__option_draw_to__bitmap(__skparam__dest);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionDrawTo(Bitmap dest, DrawingOptions opts)
    {
      __sklib_ptr __skparam__dest;
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__dest = __skadapter__to_sklib_bitmap(dest);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_draw_to__bitmap__drawing_options(__skparam__dest, __skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionDrawTo(Window dest)
    {
      __sklib_ptr __skparam__dest;
      __sklib_drawing_options __skreturn;
      __skparam__dest = __skadapter__to_sklib_window(dest);
      __skreturn = __sklib__option_draw_to__window(__skparam__dest);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionDrawTo(Window dest, DrawingOptions opts)
    {
      __sklib_ptr __skparam__dest;
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__dest = __skadapter__to_sklib_window(dest);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_draw_to__window__drawing_options(__skparam__dest, __skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionFlipX()
    {
      __sklib_drawing_options __skreturn;
      __skreturn = __sklib__option_flip_x();
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionFlipX(DrawingOptions opts)
    {
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_flip_x__drawing_options(__skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionFlipXy()
    {
      __sklib_drawing_options __skreturn;
      __skreturn = __sklib__option_flip_xy();
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionFlipXy(DrawingOptions opts)
    {
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_flip_xy__drawing_options(__skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionFlipY()
    {
      __sklib_drawing_options __skreturn;
      __skreturn = __sklib__option_flip_y();
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionFlipY(DrawingOptions opts)
    {
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_flip_y__drawing_options(__skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionLineWidth(int width)
    {
      int __skparam__width;
      __sklib_drawing_options __skreturn;
      __skparam__width = __skadapter__to_sklib_int(width);
      __skreturn = __sklib__option_line_width__int(__skparam__width);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionLineWidth(int width, DrawingOptions opts)
    {
      int __skparam__width;
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__width = __skadapter__to_sklib_int(width);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_line_width__int__drawing_options(__skparam__width, __skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionPartBmp(double x, double y, double w, double h)
    {
      double __skparam__x;
      double __skparam__y;
      double __skparam__w;
      double __skparam__h;
      __sklib_drawing_options __skreturn;
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__w = __skadapter__to_sklib_double(w);
      __skparam__h = __skadapter__to_sklib_double(h);
      __skreturn = __sklib__option_part_bmp__double__double__double__double(__skparam__x, __skparam__y, __skparam__w, __skparam__h);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionPartBmp(double x, double y, double w, double h, DrawingOptions opts)
    {
      double __skparam__x;
      double __skparam__y;
      double __skparam__w;
      double __skparam__h;
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__w = __skadapter__to_sklib_double(w);
      __skparam__h = __skadapter__to_sklib_double(h);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_part_bmp__double__double__double__double__drawing_options(__skparam__x, __skparam__y, __skparam__w, __skparam__h, __skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionPartBmp(Rectangle part)
    {
      __sklib_rectangle __skparam__part;
      __sklib_drawing_options __skreturn;
      __skparam__part = __skadapter__to_sklib_rectangle(part);
      __skreturn = __sklib__option_part_bmp__rectangle(__skparam__part);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionPartBmp(Rectangle part, DrawingOptions opts)
    {
      __sklib_rectangle __skparam__part;
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__part = __skadapter__to_sklib_rectangle(part);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_part_bmp__rectangle__drawing_options(__skparam__part, __skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionRotateBmp(double angle)
    {
      double __skparam__angle;
      __sklib_drawing_options __skreturn;
      __skparam__angle = __skadapter__to_sklib_double(angle);
      __skreturn = __sklib__option_rotate_bmp__double(__skparam__angle);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionRotateBmp(double angle, double anchorX, double anchorY)
    {
      double __skparam__angle;
      double __skparam__anchor_x;
      double __skparam__anchor_y;
      __sklib_drawing_options __skreturn;
      __skparam__angle = __skadapter__to_sklib_double(angle);
      __skparam__anchor_x = __skadapter__to_sklib_double(anchorX);
      __skparam__anchor_y = __skadapter__to_sklib_double(anchorY);
      __skreturn = __sklib__option_rotate_bmp__double__double__double(__skparam__angle, __skparam__anchor_x, __skparam__anchor_y);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionRotateBmp(double angle, double anchorX, double anchorY, DrawingOptions opts)
    {
      double __skparam__angle;
      double __skparam__anchor_x;
      double __skparam__anchor_y;
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__angle = __skadapter__to_sklib_double(angle);
      __skparam__anchor_x = __skadapter__to_sklib_double(anchorX);
      __skparam__anchor_y = __skadapter__to_sklib_double(anchorY);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_rotate_bmp__double__double__double__drawing_options(__skparam__angle, __skparam__anchor_x, __skparam__anchor_y, __skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionRotateBmp(double angle, DrawingOptions opts)
    {
      double __skparam__angle;
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__angle = __skadapter__to_sklib_double(angle);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_rotate_bmp__double__drawing_options(__skparam__angle, __skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionScaleBmp(double scaleX, double scaleY)
    {
      double __skparam__scale_x;
      double __skparam__scale_y;
      __sklib_drawing_options __skreturn;
      __skparam__scale_x = __skadapter__to_sklib_double(scaleX);
      __skparam__scale_y = __skadapter__to_sklib_double(scaleY);
      __skreturn = __sklib__option_scale_bmp__double__double(__skparam__scale_x, __skparam__scale_y);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionScaleBmp(double scaleX, double scaleY, DrawingOptions opts)
    {
      double __skparam__scale_x;
      double __skparam__scale_y;
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__scale_x = __skadapter__to_sklib_double(scaleX);
      __skparam__scale_y = __skadapter__to_sklib_double(scaleY);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_scale_bmp__double__double__drawing_options(__skparam__scale_x, __skparam__scale_y, __skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionToScreen()
    {
      __sklib_drawing_options __skreturn;
      __skreturn = __sklib__option_to_screen();
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionToScreen(DrawingOptions opts)
    {
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_to_screen__drawing_options(__skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionToWorld()
    {
      __sklib_drawing_options __skreturn;
      __skreturn = __sklib__option_to_world();
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionToWorld(DrawingOptions opts)
    {
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_to_world__drawing_options(__skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionWithAnimation(Animation anim)
    {
      __sklib_ptr __skparam__anim;
      __sklib_drawing_options __skreturn;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skreturn = __sklib__option_with_animation__animation(__skparam__anim);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionWithAnimation(Animation anim, DrawingOptions opts)
    {
      __sklib_ptr __skparam__anim;
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__anim = __skadapter__to_sklib_animation(anim);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_with_animation__animation__drawing_options(__skparam__anim, __skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionWithBitmapCell(int cell)
    {
      int __skparam__cell;
      __sklib_drawing_options __skreturn;
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skreturn = __sklib__option_with_bitmap_cell__int(__skparam__cell);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static DrawingOptions OptionWithBitmapCell(int cell, DrawingOptions opts)
    {
      int __skparam__cell;
      __sklib_drawing_options __skparam__opts;
      __sklib_drawing_options __skreturn;
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__option_with_bitmap_cell__int__drawing_options(__skparam__cell, __skparam__opts);
      return __skadapter__to_drawing_options(__skreturn);
    }
    public static void DrawEllipse(Color clr, Rectangle rect)
    {
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__draw_ellipse__color__rectangle(__skparam__clr, __skparam__rect);
    }
    public static void DrawEllipse(Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_ellipse__color__rectangle__drawing_options(__skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void DrawEllipse(Color clr, double x, double y, double width, double height)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__draw_ellipse__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void DrawEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_ellipse__color__double__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static void DrawEllipseOnBitmap(Bitmap destination, Color clr, Rectangle rect)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect);
    }
    public static void DrawEllipseOnBitmap(Bitmap destination, Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void DrawEllipseOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void DrawEllipseOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static void DrawEllipseOnWindow(Window destination, Color clr, Rectangle rect)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__draw_ellipse_on_window__window__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect);
    }
    public static void DrawEllipseOnWindow(Window destination, Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_ellipse_on_window__window__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void DrawEllipseOnWindow(Window destination, Color clr, double x, double y, double width, double height)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__draw_ellipse_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void DrawEllipseOnWindow(Window destination, Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_ellipse_on_window__window__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static void FillEllipse(Color clr, Rectangle rect)
    {
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__fill_ellipse__color__rectangle(__skparam__clr, __skparam__rect);
    }
    public static void FillEllipse(Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_ellipse__color__rectangle__drawing_options(__skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void FillEllipse(Color clr, double x, double y, double width, double height)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__fill_ellipse__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void FillEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_ellipse__color__double__double__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static void FillEllipseOnBitmap(Bitmap destination, Color clr, Rectangle rect)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect);
    }
    public static void FillEllipseOnBitmap(Bitmap destination, Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_ellipse_on_bitmap__bitmap__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void FillEllipseOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void FillEllipseOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_ellipse_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static void FillEllipseOnWindow(Window destination, Color clr, Rectangle rect)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__fill_ellipse_on_window__window__color__rectangle(__skparam__destination, __skparam__clr, __skparam__rect);
    }
    public static void FillEllipseOnWindow(Window destination, Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_ellipse_on_window__window__color__rectangle__drawing_options(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void FillEllipseOnWindow(Window destination, Color clr, double x, double y, double width, double height)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__fill_ellipse_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void FillEllipseOnWindow(Window destination, Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_ellipse_on_window__window__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static float Cosine(float degrees)
    {
      float __skparam__degrees;
      float __skreturn;
      __skparam__degrees = __skadapter__to_sklib_float(degrees);
      __skreturn = __sklib__cosine__float(__skparam__degrees);
      return __skadapter__to_float(__skreturn);
    }
    public static float Sine(float degrees)
    {
      float __skparam__degrees;
      float __skreturn;
      __skparam__degrees = __skadapter__to_sklib_float(degrees);
      __skreturn = __sklib__sine__float(__skparam__degrees);
      return __skadapter__to_float(__skreturn);
    }
    public static float Tangent(float degrees)
    {
      float __skparam__degrees;
      float __skreturn;
      __skparam__degrees = __skadapter__to_sklib_float(degrees);
      __skreturn = __sklib__tangent__float(__skparam__degrees);
      return __skadapter__to_float(__skreturn);
    }
    public static void ClearScreen()
    {
      __sklib__clear_screen();
    }
    public static void ClearScreen(Color clr)
    {
      __sklib_color __skparam__clr;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __sklib__clear_screen__color(__skparam__clr);
    }
    public static Display DisplayDetails(uint index)
    {
      uint __skparam__index;
      __sklib_ptr __skreturn;
      __skparam__index = __skadapter__to_sklib_unsigned_int(index);
      __skreturn = __sklib__display_details__unsigned_int(__skparam__index);
      return __skadapter__to_display(__skreturn);
    }
    public static int DisplayHeight(Display disp)
    {
      __sklib_ptr __skparam__disp;
      int __skreturn;
      __skparam__disp = __skadapter__to_sklib_display(disp);
      __skreturn = __sklib__display_height__display(__skparam__disp);
      return __skadapter__to_int(__skreturn);
    }
    public static string DisplayName(Display disp)
    {
      __sklib_ptr __skparam__disp;
      __sklib_string __skreturn;
      __skparam__disp = __skadapter__to_sklib_display(disp);
      __skreturn = __sklib__display_name__display(__skparam__disp);
      return __skadapter__to_string(__skreturn);
    }
    public static int DisplayWidth(Display disp)
    {
      __sklib_ptr __skparam__disp;
      int __skreturn;
      __skparam__disp = __skadapter__to_sklib_display(disp);
      __skreturn = __sklib__display_width__display(__skparam__disp);
      return __skadapter__to_int(__skreturn);
    }
    public static int DisplayX(Display disp)
    {
      __sklib_ptr __skparam__disp;
      int __skreturn;
      __skparam__disp = __skadapter__to_sklib_display(disp);
      __skreturn = __sklib__display_x__display(__skparam__disp);
      return __skadapter__to_int(__skreturn);
    }
    public static int DisplayY(Display disp)
    {
      __sklib_ptr __skparam__disp;
      int __skreturn;
      __skparam__disp = __skadapter__to_sklib_display(disp);
      __skreturn = __sklib__display_y__display(__skparam__disp);
      return __skadapter__to_int(__skreturn);
    }
    public static int NumberOfDisplays()
    {
      int __skreturn;
      __skreturn = __sklib__number_of_displays();
      return __skadapter__to_int(__skreturn);
    }
    public static void RefreshScreen()
    {
      __sklib__refresh_screen();
    }
    public static void RefreshScreen(uint targetFps)
    {
      uint __skparam__target_fps;
      __skparam__target_fps = __skadapter__to_sklib_unsigned_int(targetFps);
      __sklib__refresh_screen__unsigned_int(__skparam__target_fps);
    }
    public static void SaveBitmap(Bitmap bmp, string basename)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_string __skparam__basename;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__basename = __skadapter__to_sklib_string(basename);
      __sklib__save_bitmap__bitmap__string_ref(__skparam__bmp, __skparam__basename);
    __skadapter__free__sklib_string(ref __skparam__basename);
    }
    public static int ScreenHeight()
    {
      int __skreturn;
      __skreturn = __sklib__screen_height();
      return __skadapter__to_int(__skreturn);
    }
    public static int ScreenWidth()
    {
      int __skreturn;
      __skreturn = __sklib__screen_width();
      return __skadapter__to_int(__skreturn);
    }
    public static void TakeScreenshot(string basename)
    {
      __sklib_string __skparam__basename;
      __skparam__basename = __skadapter__to_sklib_string(basename);
      __sklib__take_screenshot__string_ref(__skparam__basename);
    __skadapter__free__sklib_string(ref __skparam__basename);
    }
    public static void TakeScreenshot(Window wind, string basename)
    {
      __sklib_ptr __skparam__wind;
      __sklib_string __skparam__basename;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skparam__basename = __skadapter__to_sklib_string(basename);
      __sklib__take_screenshot__window__string_ref(__skparam__wind, __skparam__basename);
    __skadapter__free__sklib_string(ref __skparam__basename);
    }
    public static Circle BitmapBoundingCircle(Bitmap bmp, Point2D pt)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_point_2d __skparam__pt;
      __sklib_circle __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__bitmap_bounding_circle__bitmap__point_2d_ref(__skparam__bmp, __skparam__pt);
      return __skadapter__to_circle(__skreturn);
    }
    public static Rectangle BitmapBoundingRectangle(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_rectangle __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_bounding_rectangle__bitmap(__skparam__bmp);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle BitmapBoundingRectangle(Bitmap bmp, double x, double y)
    {
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      __sklib_rectangle __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__bitmap_bounding_rectangle__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Point2D BitmapCellCenter(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_point_2d __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_cell_center__bitmap(__skparam__bmp);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Circle BitmapCellCircle(Bitmap bmp, double x, double y)
    {
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      __sklib_circle __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__bitmap_cell_circle__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y);
      return __skadapter__to_circle(__skreturn);
    }
    public static Circle BitmapCellCircle(Bitmap bmp, Point2D pt)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_point_2d __skparam__pt;
      __sklib_circle __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__bitmap_cell_circle__bitmap__point_2d(__skparam__bmp, __skparam__pt);
      return __skadapter__to_circle(__skreturn);
    }
    public static Circle BitmapCellCircle(Bitmap bmp, Point2D pt, double scale)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_point_2d __skparam__pt;
      double __skparam__scale;
      __sklib_circle __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__scale = __skadapter__to_sklib_double(scale);
      __skreturn = __sklib__bitmap_cell_circle__bitmap__point_2d__double(__skparam__bmp, __skparam__pt, __skparam__scale);
      return __skadapter__to_circle(__skreturn);
    }
    public static int BitmapCellColumns(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_cell_columns__bitmap(__skparam__bmp);
      return __skadapter__to_int(__skreturn);
    }
    public static int BitmapCellCount(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_cell_count__bitmap(__skparam__bmp);
      return __skadapter__to_int(__skreturn);
    }
    public static int BitmapCellHeight(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_cell_height__bitmap(__skparam__bmp);
      return __skadapter__to_int(__skreturn);
    }
    public static Vector2D BitmapCellOffset(Bitmap src, int cell)
    {
      __sklib_ptr __skparam__src;
      int __skparam__cell;
      __sklib_vector_2d __skreturn;
      __skparam__src = __skadapter__to_sklib_bitmap(src);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skreturn = __sklib__bitmap_cell_offset__bitmap__int(__skparam__src, __skparam__cell);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Rectangle BitmapCellRectangle(Bitmap src)
    {
      __sklib_ptr __skparam__src;
      __sklib_rectangle __skreturn;
      __skparam__src = __skadapter__to_sklib_bitmap(src);
      __skreturn = __sklib__bitmap_cell_rectangle__bitmap(__skparam__src);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle BitmapCellRectangle(Bitmap src, Point2D pt)
    {
      __sklib_ptr __skparam__src;
      __sklib_point_2d __skparam__pt;
      __sklib_rectangle __skreturn;
      __skparam__src = __skadapter__to_sklib_bitmap(src);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__bitmap_cell_rectangle__bitmap__point_2d_ref(__skparam__src, __skparam__pt);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static int BitmapCellRows(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_cell_rows__bitmap(__skparam__bmp);
      return __skadapter__to_int(__skreturn);
    }
    public static int BitmapCellWidth(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_cell_width__bitmap(__skparam__bmp);
      return __skadapter__to_int(__skreturn);
    }
    public static Point2D BitmapCenter(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_point_2d __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_center__bitmap(__skparam__bmp);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static string BitmapFilename(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_string __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_filename__bitmap(__skparam__bmp);
      return __skadapter__to_string(__skreturn);
    }
    public static int BitmapHeight(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_height__bitmap(__skparam__bmp);
      return __skadapter__to_int(__skreturn);
    }
    public static int BitmapHeight(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__bitmap_height__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static string BitmapName(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_string __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_name__bitmap(__skparam__bmp);
      return __skadapter__to_string(__skreturn);
    }
    public static Bitmap BitmapNamed(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__bitmap_named__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bitmap(__skreturn);
    }
    public static Rectangle BitmapRectangleOfCell(Bitmap src, int cell)
    {
      __sklib_ptr __skparam__src;
      int __skparam__cell;
      __sklib_rectangle __skreturn;
      __skparam__src = __skadapter__to_sklib_bitmap(src);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skreturn = __sklib__bitmap_rectangle_of_cell__bitmap__int(__skparam__src, __skparam__cell);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static void BitmapSetCellDetails(Bitmap bmp, int width, int height, int columns, int rows, int count)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__width;
      int __skparam__height;
      int __skparam__columns;
      int __skparam__rows;
      int __skparam__count;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__width = __skadapter__to_sklib_int(width);
      __skparam__height = __skadapter__to_sklib_int(height);
      __skparam__columns = __skadapter__to_sklib_int(columns);
      __skparam__rows = __skadapter__to_sklib_int(rows);
      __skparam__count = __skadapter__to_sklib_int(count);
      __sklib__bitmap_set_cell_details__bitmap__int__int__int__int__int(__skparam__bmp, __skparam__width, __skparam__height, __skparam__columns, __skparam__rows, __skparam__count);
    }
    public static bool BitmapValid(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_valid__bitmap(__skparam__bmp);
      return __skadapter__to_bool(__skreturn);
    }
    public static int BitmapWidth(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_width__bitmap(__skparam__bmp);
      return __skadapter__to_int(__skreturn);
    }
    public static int BitmapWidth(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__bitmap_width__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static void ClearBitmap(Bitmap bmp, Color clr)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_color __skparam__clr;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __sklib__clear_bitmap__bitmap__color(__skparam__bmp, __skparam__clr);
    }
    public static void ClearBitmap(string name, Color clr)
    {
      __sklib_string __skparam__name;
      __sklib_color __skparam__clr;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __sklib__clear_bitmap__string__color(__skparam__name, __skparam__clr);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static Bitmap CreateBitmap(string name, int width, int height)
    {
      __sklib_string __skparam__name;
      int __skparam__width;
      int __skparam__height;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__width = __skadapter__to_sklib_int(width);
      __skparam__height = __skadapter__to_sklib_int(height);
      __skreturn = __sklib__create_bitmap__string__int__int(__skparam__name, __skparam__width, __skparam__height);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bitmap(__skreturn);
    }
    public static void DrawBitmap(Bitmap bmp, double x, double y)
    {
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_bitmap__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y);
    }
    public static void DrawBitmap(Bitmap bmp, double x, double y, DrawingOptions opts)
    {
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_bitmap__bitmap__double__double__drawing_options(__skparam__bmp, __skparam__x, __skparam__y, __skparam__opts);
    }
    public static void DrawBitmap(string name, double x, double y)
    {
      __sklib_string __skparam__name;
      double __skparam__x;
      double __skparam__y;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_bitmap__string__double__double(__skparam__name, __skparam__x, __skparam__y);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void DrawBitmap(string name, double x, double y, DrawingOptions opts)
    {
      __sklib_string __skparam__name;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_bitmap__string__double__double__drawing_options(__skparam__name, __skparam__x, __skparam__y, __skparam__opts);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void DrawBitmapOnBitmap(Bitmap destination, Bitmap bmp, double x, double y)
    {
      __sklib_ptr __skparam__destination;
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y);
    }
    public static void DrawBitmapOnBitmap(Bitmap destination, Bitmap bmp, double x, double y, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_bitmap_on_bitmap__bitmap__bitmap__double__double__drawing_options(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y, __skparam__opts);
    }
    public static void DrawBitmapOnWindow(Window destination, Bitmap bmp, double x, double y)
    {
      __sklib_ptr __skparam__destination;
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_bitmap_on_window__window__bitmap__double__double(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y);
    }
    public static void DrawBitmapOnWindow(Window destination, Bitmap bmp, double x, double y, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_bitmap_on_window__window__bitmap__double__double__drawing_options(__skparam__destination, __skparam__bmp, __skparam__x, __skparam__y, __skparam__opts);
    }
    public static void FreeAllBitmaps()
    {
      __sklib__free_all_bitmaps();
    }
    public static void FreeBitmap(Bitmap toDelete)
    {
      __sklib_ptr __skparam__to_delete;
      __skparam__to_delete = __skadapter__to_sklib_bitmap(toDelete);
      __sklib__free_bitmap__bitmap(__skparam__to_delete);
    }
    public static bool HasBitmap(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_bitmap__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static Bitmap LoadBitmap(string name, string filename)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__filename;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __skreturn = __sklib__load_bitmap__string__string(__skparam__name, __skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__filename);
      return __skadapter__to_bitmap(__skreturn);
    }
    public static bool PixelDrawnAtPoint(Bitmap bmp, Point2D pt)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__pixel_drawn_at_point__bitmap__point_2d_ref(__skparam__bmp, __skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool PixelDrawnAtPoint(Bitmap bmp, double x, double y)
    {
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__pixel_drawn_at_point__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool PixelDrawnAtPoint(Bitmap bmp, int cell, Point2D pt)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__pixel_drawn_at_point__bitmap__int__point_2d_ref(__skparam__bmp, __skparam__cell, __skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool PixelDrawnAtPoint(Bitmap bmp, int cell, double x, double y)
    {
      __sklib_ptr __skparam__bmp;
      int __skparam__cell;
      double __skparam__x;
      double __skparam__y;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__cell = __skadapter__to_sklib_int(cell);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__pixel_drawn_at_point__bitmap__int__double__double(__skparam__bmp, __skparam__cell, __skparam__x, __skparam__y);
      return __skadapter__to_bool(__skreturn);
    }
    public static void SetupCollisionMask(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __sklib__setup_collision_mask__bitmap(__skparam__bmp);
    }
    public static void ProcessEvents()
    {
      __sklib__process_events();
    }
    public static bool QuitRequested()
    {
      int __skreturn;
      __skreturn = __sklib__quit_requested();
      return __skadapter__to_bool(__skreturn);
    }
    public static void ResetQuit()
    {
      __sklib__reset_quit();
    }
    public static void AddColumn(int width)
    {
      int __skparam__width;
      __skparam__width = __skadapter__to_sklib_int(width);
      __sklib__add_column__int(__skparam__width);
    }
    public static void AddColumnRelative(double width)
    {
      double __skparam__width;
      __skparam__width = __skadapter__to_sklib_double(width);
      __sklib__add_column_relative__double(__skparam__width);
    }
    public static bool BitmapButton(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_button__bitmap(__skparam__bmp);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapButton(Bitmap bmp, Rectangle rect)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__bitmap_button__bitmap__rectangle_ref(__skparam__bmp, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapButton(Bitmap bmp, Rectangle rect, DrawingOptions opts)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__bitmap_button__bitmap__rectangle_ref__drawing_options(__skparam__bmp, __skparam__rect, __skparam__opts);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapButton(Bitmap bmp, DrawingOptions opts)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_drawing_options __skparam__opts;
      int __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__bitmap_button__bitmap__drawing_options(__skparam__bmp, __skparam__opts);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapButton(string labelText, Bitmap bmp)
    {
      __sklib_string __skparam__label_text;
      __sklib_ptr __skparam__bmp;
      int __skreturn;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__bitmap_button__string_ref__bitmap(__skparam__label_text, __skparam__bmp);
    __skadapter__free__sklib_string(ref __skparam__label_text);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool BitmapButton(string labelText, Bitmap bmp, DrawingOptions opts)
    {
      __sklib_string __skparam__label_text;
      __sklib_ptr __skparam__bmp;
      __sklib_drawing_options __skparam__opts;
      int __skreturn;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __skreturn = __sklib__bitmap_button__string_ref__bitmap__drawing_options(__skparam__label_text, __skparam__bmp, __skparam__opts);
    __skadapter__free__sklib_string(ref __skparam__label_text);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool Button(string text, Rectangle rect)
    {
      __sklib_string __skparam__text;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__button__string_ref__rectangle_ref(__skparam__text, __skparam__rect);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool Button(string text)
    {
      __sklib_string __skparam__text;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skreturn = __sklib__button__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool Button(string labelText, string text)
    {
      __sklib_string __skparam__label_text;
      __sklib_string __skparam__text;
      int __skreturn;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skreturn = __sklib__button__string_ref__string_ref(__skparam__label_text, __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__label_text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool Checkbox(string text, bool value, Rectangle rect)
    {
      __sklib_string __skparam__text;
      int __skparam__value;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__value = __skadapter__to_sklib_bool(value);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__checkbox__string_ref__bool_ref__rectangle_ref(__skparam__text, __skparam__value, __skparam__rect);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool Checkbox(string text, bool value)
    {
      __sklib_string __skparam__text;
      int __skparam__value;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__value = __skadapter__to_sklib_bool(value);
      __skreturn = __sklib__checkbox__string_ref__bool_ref(__skparam__text, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool Checkbox(string labelText, string text, bool value)
    {
      __sklib_string __skparam__label_text;
      __sklib_string __skparam__text;
      int __skparam__value;
      int __skreturn;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__value = __skadapter__to_sklib_bool(value);
      __skreturn = __sklib__checkbox__string_ref__string_ref__bool_ref(__skparam__label_text, __skparam__text, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__label_text);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_bool(__skreturn);
    }
    public static Color ColorSlider(Color clr, Rectangle rect)
    {
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_color __skreturn;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__color_slider__color_ref__rectangle_ref(__skparam__clr, __skparam__rect);
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSlider(Color clr)
    {
      __sklib_color __skparam__clr;
      __sklib_color __skreturn;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skreturn = __sklib__color_slider__color_ref(__skparam__clr);
      return __skadapter__to_color(__skreturn);
    }
    public static Color ColorSlider(string labelText, Color clr)
    {
      __sklib_string __skparam__label_text;
      __sklib_color __skparam__clr;
      __sklib_color __skreturn;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skreturn = __sklib__color_slider__string_ref__color_ref(__skparam__label_text, __skparam__clr);
    __skadapter__free__sklib_string(ref __skparam__label_text);
      return __skadapter__to_color(__skreturn);
    }
    public static void DisableInterface()
    {
      __sklib__disable_interface();
    }
    public static void DrawInterface()
    {
      __sklib__draw_interface();
    }
    public static void EnableInterface()
    {
      __sklib__enable_interface();
    }
    public static void EndInset(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__end_inset__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void EndPanel(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__end_panel__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void EndPopup(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__end_popup__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void EndTreenode(string labelText)
    {
      __sklib_string __skparam__label_text;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __sklib__end_treenode__string_ref(__skparam__label_text);
    __skadapter__free__sklib_string(ref __skparam__label_text);
    }
    public static void EnterColumn()
    {
      __sklib__enter_column();
    }
    public static int GetInterfaceLabelWidth()
    {
      int __skreturn;
      __skreturn = __sklib__get_interface_label_width();
      return __skadapter__to_int(__skreturn);
    }
    public static bool Header(string labelText)
    {
      __sklib_string __skparam__label_text;
      int __skreturn;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __skreturn = __sklib__header__string_ref(__skparam__label_text);
    __skadapter__free__sklib_string(ref __skparam__label_text);
      return __skadapter__to_bool(__skreturn);
    }
    public static Color HSBColorSlider(Color clr, Rectangle rect)
    {
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_color __skreturn;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__hsb_color_slider__color_ref__rectangle_ref(__skparam__clr, __skparam__rect);
      return __skadapter__to_color(__skreturn);
    }
    public static Color HSBColorSlider(Color clr)
    {
      __sklib_color __skparam__clr;
      __sklib_color __skreturn;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skreturn = __sklib__hsb_color_slider__color_ref(__skparam__clr);
      return __skadapter__to_color(__skreturn);
    }
    public static Color HSBColorSlider(string labelText, Color clr)
    {
      __sklib_string __skparam__label_text;
      __sklib_color __skparam__clr;
      __sklib_color __skreturn;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skreturn = __sklib__hsb_color_slider__string_ref__color_ref(__skparam__label_text, __skparam__clr);
    __skadapter__free__sklib_string(ref __skparam__label_text);
      return __skadapter__to_color(__skreturn);
    }
    public static bool InterfaceEnabled()
    {
      int __skreturn;
      __skreturn = __sklib__interface_enabled();
      return __skadapter__to_bool(__skreturn);
    }
    public static void InterfaceStylePanel(Rectangle initialRectangle)
    {
      __sklib_rectangle __skparam__initial_rectangle;
      __skparam__initial_rectangle = __skadapter__to_sklib_rectangle(initialRectangle);
      __sklib__interface_style_panel__rectangle_ref(__skparam__initial_rectangle);
    }
    public static void LabelElement(string text)
    {
      __sklib_string __skparam__text;
      __skparam__text = __skadapter__to_sklib_string(text);
      __sklib__label_element__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void LabelElement(string text, Rectangle rect)
    {
      __sklib_string __skparam__text;
      __sklib_rectangle __skparam__rect;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__label_element__string_ref__rectangle_ref(__skparam__text, __skparam__rect);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static bool LastElementChanged()
    {
      int __skreturn;
      __skreturn = __sklib__last_element_changed();
      return __skadapter__to_bool(__skreturn);
    }
    public static bool LastElementConfirmed()
    {
      int __skreturn;
      __skreturn = __sklib__last_element_confirmed();
      return __skadapter__to_bool(__skreturn);
    }
    public static void LeaveColumn()
    {
      __sklib__leave_column();
    }
    public static float NumberBox(float value, float step, Rectangle rect)
    {
      float __skparam__value;
      float __skparam__step;
      __sklib_rectangle __skparam__rect;
      float __skreturn;
      __skparam__value = __skadapter__to_sklib_float(value);
      __skparam__step = __skadapter__to_sklib_float(step);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__number_box__float_ref__float__rectangle_ref(__skparam__value, __skparam__step, __skparam__rect);
      return __skadapter__to_float(__skreturn);
    }
    public static float NumberBox(float value, float step)
    {
      float __skparam__value;
      float __skparam__step;
      float __skreturn;
      __skparam__value = __skadapter__to_sklib_float(value);
      __skparam__step = __skadapter__to_sklib_float(step);
      __skreturn = __sklib__number_box__float_ref__float(__skparam__value, __skparam__step);
      return __skadapter__to_float(__skreturn);
    }
    public static float NumberBox(string labelText, float value, float step)
    {
      __sklib_string __skparam__label_text;
      float __skparam__value;
      float __skparam__step;
      float __skreturn;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __skparam__value = __skadapter__to_sklib_float(value);
      __skparam__step = __skadapter__to_sklib_float(step);
      __skreturn = __sklib__number_box__string_ref__float_ref__float(__skparam__label_text, __skparam__value, __skparam__step);
    __skadapter__free__sklib_string(ref __skparam__label_text);
      return __skadapter__to_float(__skreturn);
    }
    public static void OpenPopup(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__open_popup__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void Paragraph(string text)
    {
      __sklib_string __skparam__text;
      __skparam__text = __skadapter__to_sklib_string(text);
      __sklib__paragraph__string_ref(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void Paragraph(string text, Rectangle rect)
    {
      __sklib_string __skparam__text;
      __sklib_rectangle __skparam__rect;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__paragraph__string_ref__rectangle_ref(__skparam__text, __skparam__rect);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void ResetLayout()
    {
      __sklib__reset_layout();
    }
    public static void SetInterfaceAccentColor(Color clr, float contrast)
    {
      __sklib_color __skparam__clr;
      float __skparam__contrast;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__contrast = __skadapter__to_sklib_float(contrast);
      __sklib__set_interface_accent_color__color__float(__skparam__clr, __skparam__contrast);
    }
    public static void SetInterfaceBorderColor(Color clr)
    {
      __sklib_color __skparam__clr;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __sklib__set_interface_border_color__color(__skparam__clr);
    }
    public static void SetInterfaceColorsAuto(Color mainClr, Color accentClr, float contrast, float accentContrast, float borderContrast)
    {
      __sklib_color __skparam__main_clr;
      __sklib_color __skparam__accent_clr;
      float __skparam__contrast;
      float __skparam__accent_contrast;
      float __skparam__border_contrast;
      __skparam__main_clr = __skadapter__to_sklib_color(mainClr);
      __skparam__accent_clr = __skadapter__to_sklib_color(accentClr);
      __skparam__contrast = __skadapter__to_sklib_float(contrast);
      __skparam__accent_contrast = __skadapter__to_sklib_float(accentContrast);
      __skparam__border_contrast = __skadapter__to_sklib_float(borderContrast);
      __sklib__set_interface_colors_auto__color__color__float__float__float(__skparam__main_clr, __skparam__accent_clr, __skparam__contrast, __skparam__accent_contrast, __skparam__border_contrast);
    }
    public static void SetInterfaceElementColor(Color clr, float contrast)
    {
      __sklib_color __skparam__clr;
      float __skparam__contrast;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__contrast = __skadapter__to_sklib_float(contrast);
      __sklib__set_interface_element_color__color__float(__skparam__clr, __skparam__contrast);
    }
    public static void SetInterfaceElementShadows(int radius, Color clr, Point2D offset)
    {
      int __skparam__radius;
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__offset;
      __skparam__radius = __skadapter__to_sklib_int(radius);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__offset = __skadapter__to_sklib_point_2d(offset);
      __sklib__set_interface_element_shadows__int__color__point_2d(__skparam__radius, __skparam__clr, __skparam__offset);
    }
    public static void SetInterfaceFont(string fnt)
    {
      __sklib_string __skparam__fnt;
      __skparam__fnt = __skadapter__to_sklib_string(fnt);
      __sklib__set_interface_font__string_ref(__skparam__fnt);
    __skadapter__free__sklib_string(ref __skparam__fnt);
    }
    public static void SetInterfaceFont(Font fnt)
    {
      __sklib_ptr __skparam__fnt;
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __sklib__set_interface_font__font(__skparam__fnt);
    }
    public static void SetInterfaceFontSize(int size)
    {
      int __skparam__size;
      __skparam__size = __skadapter__to_sklib_int(size);
      __sklib__set_interface_font_size__int(__skparam__size);
    }
    public static void SetInterfaceLabelWidth(int width)
    {
      int __skparam__width;
      __skparam__width = __skadapter__to_sklib_int(width);
      __sklib__set_interface_label_width__int(__skparam__width);
    }
    public static void SetInterfacePanelShadows(int radius, Color clr, Point2D offset)
    {
      int __skparam__radius;
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__offset;
      __skparam__radius = __skadapter__to_sklib_int(radius);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__offset = __skadapter__to_sklib_point_2d(offset);
      __sklib__set_interface_panel_shadows__int__color__point_2d(__skparam__radius, __skparam__clr, __skparam__offset);
    }
    public static void SetInterfaceRootTextColor(Color clr)
    {
      __sklib_color __skparam__clr;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __sklib__set_interface_root_text_color__color(__skparam__clr);
    }
    public static void SetInterfaceShadows(int radius, Color clr, Point2D offset)
    {
      int __skparam__radius;
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__offset;
      __skparam__radius = __skadapter__to_sklib_int(radius);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__offset = __skadapter__to_sklib_point_2d(offset);
      __sklib__set_interface_shadows__int__color__point_2d(__skparam__radius, __skparam__clr, __skparam__offset);
    }
    public static void SetInterfaceSpacing(int spacing, int padding)
    {
      int __skparam__spacing;
      int __skparam__padding;
      __skparam__spacing = __skadapter__to_sklib_int(spacing);
      __skparam__padding = __skadapter__to_sklib_int(padding);
      __sklib__set_interface_spacing__int__int(__skparam__spacing, __skparam__padding);
    }
    public static void SetInterfaceStyle(InterfaceStyle style)
    {
      int __skparam__style;
      __skparam__style = __skadapter__to_sklib_interface_style(style);
      __sklib__set_interface_style__interface_style(__skparam__style);
    }
    public static void SetInterfaceStyle(InterfaceStyle style, Color clr)
    {
      int __skparam__style;
      __sklib_color __skparam__clr;
      __skparam__style = __skadapter__to_sklib_interface_style(style);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __sklib__set_interface_style__interface_style__color(__skparam__style, __skparam__clr);
    }
    public static void SetInterfaceTextColor(Color clr)
    {
      __sklib_color __skparam__clr;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __sklib__set_interface_text_color__color(__skparam__clr);
    }
    public static void SetLayoutHeight(int height)
    {
      int __skparam__height;
      __skparam__height = __skadapter__to_sklib_int(height);
      __sklib__set_layout_height__int(__skparam__height);
    }
    public static void SingleLineLayout()
    {
      __sklib__single_line_layout();
    }
    public static float Slider(float value, float minValue, float maxValue, Rectangle rect)
    {
      float __skparam__value;
      float __skparam__min_value;
      float __skparam__max_value;
      __sklib_rectangle __skparam__rect;
      float __skreturn;
      __skparam__value = __skadapter__to_sklib_float(value);
      __skparam__min_value = __skadapter__to_sklib_float(minValue);
      __skparam__max_value = __skadapter__to_sklib_float(maxValue);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__slider__float_ref__float__float__rectangle_ref(__skparam__value, __skparam__min_value, __skparam__max_value, __skparam__rect);
      return __skadapter__to_float(__skreturn);
    }
    public static float Slider(float value, float minValue, float maxValue)
    {
      float __skparam__value;
      float __skparam__min_value;
      float __skparam__max_value;
      float __skreturn;
      __skparam__value = __skadapter__to_sklib_float(value);
      __skparam__min_value = __skadapter__to_sklib_float(minValue);
      __skparam__max_value = __skadapter__to_sklib_float(maxValue);
      __skreturn = __sklib__slider__float_ref__float__float(__skparam__value, __skparam__min_value, __skparam__max_value);
      return __skadapter__to_float(__skreturn);
    }
    public static float Slider(string labelText, float value, float minValue, float maxValue)
    {
      __sklib_string __skparam__label_text;
      float __skparam__value;
      float __skparam__min_value;
      float __skparam__max_value;
      float __skreturn;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __skparam__value = __skadapter__to_sklib_float(value);
      __skparam__min_value = __skadapter__to_sklib_float(minValue);
      __skparam__max_value = __skadapter__to_sklib_float(maxValue);
      __skreturn = __sklib__slider__string_ref__float_ref__float__float(__skparam__label_text, __skparam__value, __skparam__min_value, __skparam__max_value);
    __skadapter__free__sklib_string(ref __skparam__label_text);
      return __skadapter__to_float(__skreturn);
    }
    public static void SplitIntoColumns(int count)
    {
      int __skparam__count;
      __skparam__count = __skadapter__to_sklib_int(count);
      __sklib__split_into_columns__int(__skparam__count);
    }
    public static void SplitIntoColumns(int count, int lastWidth)
    {
      int __skparam__count;
      int __skparam__last_width;
      __skparam__count = __skadapter__to_sklib_int(count);
      __skparam__last_width = __skadapter__to_sklib_int(lastWidth);
      __sklib__split_into_columns__int__int(__skparam__count, __skparam__last_width);
    }
    public static void SplitIntoColumnsRelative(int count, double lastWidth)
    {
      int __skparam__count;
      double __skparam__last_width;
      __skparam__count = __skadapter__to_sklib_int(count);
      __skparam__last_width = __skadapter__to_sklib_double(lastWidth);
      __sklib__split_into_columns_relative__int__double(__skparam__count, __skparam__last_width);
    }
    public static void StartCustomLayout()
    {
      __sklib__start_custom_layout();
    }
    public static void StartInset(string name, Rectangle rect)
    {
      __sklib_string __skparam__name;
      __sklib_rectangle __skparam__rect;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__start_inset__string_ref__rectangle_ref(__skparam__name, __skparam__rect);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void StartInset(string name, int height)
    {
      __sklib_string __skparam__name;
      int __skparam__height;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__height = __skadapter__to_sklib_int(height);
      __sklib__start_inset__string_ref__int(__skparam__name, __skparam__height);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static bool StartPanel(string name, Rectangle initialRectangle)
    {
      __sklib_string __skparam__name;
      __sklib_rectangle __skparam__initial_rectangle;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__initial_rectangle = __skadapter__to_sklib_rectangle(initialRectangle);
      __skreturn = __sklib__start_panel__string_ref__rectangle(__skparam__name, __skparam__initial_rectangle);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool StartPopup(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__start_popup__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool StartTreenode(string labelText)
    {
      __sklib_string __skparam__label_text;
      int __skreturn;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __skreturn = __sklib__start_treenode__string_ref(__skparam__label_text);
    __skadapter__free__sklib_string(ref __skparam__label_text);
      return __skadapter__to_bool(__skreturn);
    }
    public static string TextBox(string value)
    {
      __sklib_string __skparam__value;
      __sklib_string __skreturn;
      __skparam__value = __skadapter__to_sklib_string(value);
      __skreturn = __sklib__text_box__string_ref(__skparam__value);
    __skadapter__free__sklib_string(ref __skparam__value);
      return __skadapter__to_string(__skreturn);
    }
    public static string TextBox(string value, Rectangle rect)
    {
      __sklib_string __skparam__value;
      __sklib_rectangle __skparam__rect;
      __sklib_string __skreturn;
      __skparam__value = __skadapter__to_sklib_string(value);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__text_box__string_ref__rectangle_ref(__skparam__value, __skparam__rect);
    __skadapter__free__sklib_string(ref __skparam__value);
      return __skadapter__to_string(__skreturn);
    }
    public static string TextBox(string labelText, string value)
    {
      __sklib_string __skparam__label_text;
      __sklib_string __skparam__value;
      __sklib_string __skreturn;
      __skparam__label_text = __skadapter__to_sklib_string(labelText);
      __skparam__value = __skadapter__to_sklib_string(value);
      __skreturn = __sklib__text_box__string_ref__string_ref(__skparam__label_text, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__label_text);
    __skadapter__free__sklib_string(ref __skparam__value);
      return __skadapter__to_string(__skreturn);
    }
    public static Json CreateJson()
    {
      __sklib_ptr __skreturn;
      __skreturn = __sklib__create_json();
      return __skadapter__to_json(__skreturn);
    }
    public static Json CreateJson(string jsonString)
    {
      __sklib_string __skparam__json_string;
      __sklib_ptr __skreturn;
      __skparam__json_string = __skadapter__to_sklib_string(jsonString);
      __skreturn = __sklib__create_json__string(__skparam__json_string);
    __skadapter__free__sklib_string(ref __skparam__json_string);
      return __skadapter__to_json(__skreturn);
    }
    public static void FreeAllJson()
    {
      __sklib__free_all_json();
    }
    public static void FreeJson(Json j)
    {
      __sklib_ptr __skparam__j;
      __skparam__j = __skadapter__to_sklib_json(j);
      __sklib__free_json__json(__skparam__j);
    }
    public static int JsonCountKeys(Json j)
    {
      __sklib_ptr __skparam__j;
      int __skreturn;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skreturn = __sklib__json_count_keys__json(__skparam__j);
      return __skadapter__to_int(__skreturn);
    }
    public static Json JsonFromColor(Color clr)
    {
      __sklib_color __skparam__clr;
      __sklib_ptr __skreturn;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skreturn = __sklib__json_from_color__color(__skparam__clr);
      return __skadapter__to_json(__skreturn);
    }
    public static Json JsonFromFile(string filename)
    {
      __sklib_string __skparam__filename;
      __sklib_ptr __skreturn;
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __skreturn = __sklib__json_from_file__string_ref(__skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__filename);
      return __skadapter__to_json(__skreturn);
    }
    public static Json JsonFromString(string jString)
    {
      __sklib_string __skparam__j_string;
      __sklib_ptr __skreturn;
      __skparam__j_string = __skadapter__to_sklib_string(jString);
      __skreturn = __sklib__json_from_string__string_ref(__skparam__j_string);
    __skadapter__free__sklib_string(ref __skparam__j_string);
      return __skadapter__to_json(__skreturn);
    }
    public static bool JsonHasKey(Json j, string key)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      int __skreturn;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skreturn = __sklib__json_has_key__json__string(__skparam__j, __skparam__key);
    __skadapter__free__sklib_string(ref __skparam__key);
      return __skadapter__to_bool(__skreturn);
    }
    public static void JsonReadArray(Json j, string key, ref List<double> outResult)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_vector_double __skparam__out_result;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__out_result = __skadapter__to_sklib_vector_double(outResult);
      __sklib__json_read_array__json__string__vector_double_ref(__skparam__j, __skparam__key, ref __skparam__out_result);
      outResult = __skadapter__to_vector_double(__skparam__out_result);
    __skadapter__free__sklib_string(ref __skparam__key);
    __skadapter__free__sklib_vector_double(ref __skparam__out_result);
    }
    public static void JsonReadArray(Json j, string key, ref List<Json> outResult)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_vector_json __skparam__out_result;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__out_result = __skadapter__to_sklib_vector_json(outResult);
      __sklib__json_read_array__json__string__vector_json_ref(__skparam__j, __skparam__key, ref __skparam__out_result);
      outResult = __skadapter__to_vector_json(__skparam__out_result);
    __skadapter__free__sklib_string(ref __skparam__key);
    __skadapter__free__sklib_vector_json(ref __skparam__out_result);
    }
    public static void JsonReadArray(Json j, string key, ref List<string> outResult)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_vector_string __skparam__out_result;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__out_result = __skadapter__to_sklib_vector_string(outResult);
      __sklib__json_read_array__json__string__vector_string_ref(__skparam__j, __skparam__key, ref __skparam__out_result);
      outResult = __skadapter__to_vector_string(__skparam__out_result);
    __skadapter__free__sklib_string(ref __skparam__key);
    __skadapter__free__sklib_vector_string(ref __skparam__out_result);
    }
    public static void JsonReadArray(Json j, string key, ref List<bool> outResult)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_vector_bool __skparam__out_result;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__out_result = __skadapter__to_sklib_vector_bool(outResult);
      __sklib__json_read_array__json__string__vector_bool_ref(__skparam__j, __skparam__key, ref __skparam__out_result);
      outResult = __skadapter__to_vector_bool(__skparam__out_result);
    __skadapter__free__sklib_string(ref __skparam__key);
    __skadapter__free__sklib_vector_bool(ref __skparam__out_result);
    }
    public static bool JsonReadBool(Json j, string key)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      int __skreturn;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skreturn = __sklib__json_read_bool__json__string(__skparam__j, __skparam__key);
    __skadapter__free__sklib_string(ref __skparam__key);
      return __skadapter__to_bool(__skreturn);
    }
    public static float JsonReadNumber(Json j, string key)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      float __skreturn;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skreturn = __sklib__json_read_number__json__string(__skparam__j, __skparam__key);
    __skadapter__free__sklib_string(ref __skparam__key);
      return __skadapter__to_float(__skreturn);
    }
    public static double JsonReadNumberAsDouble(Json j, string key)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      double __skreturn;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skreturn = __sklib__json_read_number_as_double__json__string(__skparam__j, __skparam__key);
    __skadapter__free__sklib_string(ref __skparam__key);
      return __skadapter__to_double(__skreturn);
    }
    public static int JsonReadNumberAsInt(Json j, string key)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      int __skreturn;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skreturn = __sklib__json_read_number_as_int__json__string(__skparam__j, __skparam__key);
    __skadapter__free__sklib_string(ref __skparam__key);
      return __skadapter__to_int(__skreturn);
    }
    public static Json JsonReadObject(Json j, string key)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_ptr __skreturn;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skreturn = __sklib__json_read_object__json__string(__skparam__j, __skparam__key);
    __skadapter__free__sklib_string(ref __skparam__key);
      return __skadapter__to_json(__skreturn);
    }
    public static string JsonReadString(Json j, string key)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_string __skreturn;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skreturn = __sklib__json_read_string__json__string(__skparam__j, __skparam__key);
    __skadapter__free__sklib_string(ref __skparam__key);
      return __skadapter__to_string(__skreturn);
    }
    public static void JsonSetArray(Json j, string key, List<string> value)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_vector_string __skparam__value;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__value = __skadapter__to_sklib_vector_string(value);
      __sklib__json_set_array__json__string__vector_string(__skparam__j, __skparam__key, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__key);
    __skadapter__free__sklib_vector_string(ref __skparam__value);
    }
    public static void JsonSetArray(Json j, string key, List<double> value)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_vector_double __skparam__value;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__value = __skadapter__to_sklib_vector_double(value);
      __sklib__json_set_array__json__string__vector_double(__skparam__j, __skparam__key, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__key);
    __skadapter__free__sklib_vector_double(ref __skparam__value);
    }
    public static void JsonSetArray(Json j, string key, List<bool> value)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_vector_bool __skparam__value;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__value = __skadapter__to_sklib_vector_bool(value);
      __sklib__json_set_array__json__string__vector_bool(__skparam__j, __skparam__key, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__key);
    __skadapter__free__sklib_vector_bool(ref __skparam__value);
    }
    public static void JsonSetArray(Json j, string key, List<Json> value)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_vector_json __skparam__value;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__value = __skadapter__to_sklib_vector_json(value);
      __sklib__json_set_array__json__string__vector_json(__skparam__j, __skparam__key, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__key);
    __skadapter__free__sklib_vector_json(ref __skparam__value);
    }
    public static void JsonSetBool(Json j, string key, bool value)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      int __skparam__value;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__value = __skadapter__to_sklib_bool(value);
      __sklib__json_set_bool__json__string__bool(__skparam__j, __skparam__key, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__key);
    }
    public static void JsonSetNumber(Json j, string key, int value)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      int __skparam__value;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__value = __skadapter__to_sklib_int(value);
      __sklib__json_set_number__json__string__int(__skparam__j, __skparam__key, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__key);
    }
    public static void JsonSetNumber(Json j, string key, double value)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      double __skparam__value;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__value = __skadapter__to_sklib_double(value);
      __sklib__json_set_number__json__string__double(__skparam__j, __skparam__key, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__key);
    }
    public static void JsonSetNumber(Json j, string key, float value)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      float __skparam__value;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__value = __skadapter__to_sklib_float(value);
      __sklib__json_set_number__json__string__float(__skparam__j, __skparam__key, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__key);
    }
    public static void JsonSetObject(Json j, string key, Json obj)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_ptr __skparam__obj;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__obj = __skadapter__to_sklib_json(obj);
      __sklib__json_set_object__json__string__json(__skparam__j, __skparam__key, __skparam__obj);
    __skadapter__free__sklib_string(ref __skparam__key);
    }
    public static void JsonSetString(Json j, string key, string value)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__key;
      __sklib_string __skparam__value;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__key = __skadapter__to_sklib_string(key);
      __skparam__value = __skadapter__to_sklib_string(value);
      __sklib__json_set_string__json__string__string(__skparam__j, __skparam__key, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__key);
    __skadapter__free__sklib_string(ref __skparam__value);
    }
    public static Color JsonToColor(Json j)
    {
      __sklib_ptr __skparam__j;
      __sklib_color __skreturn;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skreturn = __sklib__json_to_color__json(__skparam__j);
      return __skadapter__to_color(__skreturn);
    }
    public static void JsonToFile(Json j, string filename)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skparam__filename;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __sklib__json_to_file__json__string_ref(__skparam__j, __skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__filename);
    }
    public static string JsonToString(Json j)
    {
      __sklib_ptr __skparam__j;
      __sklib_string __skreturn;
      __skparam__j = __skadapter__to_sklib_json(j);
      __skreturn = __sklib__json_to_string__json(__skparam__j);
      return __skadapter__to_string(__skreturn);
    }
    public static bool AnyKeyPressed()
    {
      int __skreturn;
      __skreturn = __sklib__any_key_pressed();
      return __skadapter__to_bool(__skreturn);
    }
    public static void DeregisterCallbackOnKeyDown(KeyCallback callback)
    {
      KeyCallback __skparam__callback;
      __skparam__callback = __skadapter__to_sklib_key_callback(callback);
      __sklib__deregister_callback_on_key_down__key_callback_ptr(__skparam__callback);
    }
    public static void DeregisterCallbackOnKeyTyped(KeyCallback callback)
    {
      KeyCallback __skparam__callback;
      __skparam__callback = __skadapter__to_sklib_key_callback(callback);
      __sklib__deregister_callback_on_key_typed__key_callback_ptr(__skparam__callback);
    }
    public static void DeregisterCallbackOnKeyUp(KeyCallback callback)
    {
      KeyCallback __skparam__callback;
      __skparam__callback = __skadapter__to_sklib_key_callback(callback);
      __sklib__deregister_callback_on_key_up__key_callback_ptr(__skparam__callback);
    }
    public static bool KeyDown(KeyCode key)
    {
      int __skparam__key;
      int __skreturn;
      __skparam__key = __skadapter__to_sklib_key_code(key);
      __skreturn = __sklib__key_down__key_code(__skparam__key);
      return __skadapter__to_bool(__skreturn);
    }
    public static string KeyName(KeyCode key)
    {
      int __skparam__key;
      __sklib_string __skreturn;
      __skparam__key = __skadapter__to_sklib_key_code(key);
      __skreturn = __sklib__key_name__key_code(__skparam__key);
      return __skadapter__to_string(__skreturn);
    }
    public static bool KeyReleased(KeyCode key)
    {
      int __skparam__key;
      int __skreturn;
      __skparam__key = __skadapter__to_sklib_key_code(key);
      __skreturn = __sklib__key_released__key_code(__skparam__key);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool KeyTyped(KeyCode key)
    {
      int __skparam__key;
      int __skreturn;
      __skparam__key = __skadapter__to_sklib_key_code(key);
      __skreturn = __sklib__key_typed__key_code(__skparam__key);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool KeyUp(KeyCode key)
    {
      int __skparam__key;
      int __skreturn;
      __skparam__key = __skadapter__to_sklib_key_code(key);
      __skreturn = __sklib__key_up__key_code(__skparam__key);
      return __skadapter__to_bool(__skreturn);
    }
    public static void RegisterCallbackOnKeyDown(KeyCallback callback)
    {
      KeyCallback __skparam__callback;
      __skparam__callback = __skadapter__to_sklib_key_callback(callback);
      __sklib__register_callback_on_key_down__key_callback_ptr(__skparam__callback);
    }
    public static void RegisterCallbackOnKeyTyped(KeyCallback callback)
    {
      KeyCallback __skparam__callback;
      __skparam__callback = __skadapter__to_sklib_key_callback(callback);
      __sklib__register_callback_on_key_typed__key_callback_ptr(__skparam__callback);
    }
    public static void RegisterCallbackOnKeyUp(KeyCallback callback)
    {
      KeyCallback __skparam__callback;
      __skparam__callback = __skadapter__to_sklib_key_callback(callback);
      __sklib__register_callback_on_key_up__key_callback_ptr(__skparam__callback);
    }
    public static void DrawLine(Color clr, Line l)
    {
      __sklib_color __skparam__clr;
      __sklib_line __skparam__l;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__l = __skadapter__to_sklib_line(l);
      __sklib__draw_line__color__line_ref(__skparam__clr, __skparam__l);
    }
    public static void DrawLine(Color clr, Line l, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_line __skparam__l;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__l = __skadapter__to_sklib_line(l);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_line__color__line_ref__drawing_options(__skparam__clr, __skparam__l, __skparam__opts);
    }
    public static void DrawLine(Color clr, Point2D fromPt, Point2D toPt)
    {
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__from_pt;
      __sklib_point_2d __skparam__to_pt;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__from_pt = __skadapter__to_sklib_point_2d(fromPt);
      __skparam__to_pt = __skadapter__to_sklib_point_2d(toPt);
      __sklib__draw_line__color__point_2d_ref__point_2d_ref(__skparam__clr, __skparam__from_pt, __skparam__to_pt);
    }
    public static void DrawLine(Color clr, Point2D fromPt, Point2D toPt, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__from_pt;
      __sklib_point_2d __skparam__to_pt;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__from_pt = __skadapter__to_sklib_point_2d(fromPt);
      __skparam__to_pt = __skadapter__to_sklib_point_2d(toPt);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_line__color__point_2d_ref__point_2d_ref__drawing_options_ref(__skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts);
    }
    public static void DrawLine(Color clr, double x1, double y1, double x2, double y2)
    {
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __sklib__draw_line__color__double__double__double__double(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
    }
    public static void DrawLine(Color clr, double x1, double y1, double x2, double y2, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_line__color__double__double__double__double__drawing_options_ref(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts);
    }
    public static void DrawLineOnBitmap(Bitmap destination, Color clr, Line l)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_line __skparam__l;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__l = __skadapter__to_sklib_line(l);
      __sklib__draw_line_on_bitmap__bitmap__color__line_ref(__skparam__destination, __skparam__clr, __skparam__l);
    }
    public static void DrawLineOnBitmap(Bitmap destination, Color clr, Line l, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_line __skparam__l;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__l = __skadapter__to_sklib_line(l);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_line_on_bitmap__bitmap__color__line_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__l, __skparam__opts);
    }
    public static void DrawLineOnBitmap(Bitmap destination, Color clr, Point2D fromPt, Point2D toPt)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__from_pt;
      __sklib_point_2d __skparam__to_pt;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__from_pt = __skadapter__to_sklib_point_2d(fromPt);
      __skparam__to_pt = __skadapter__to_sklib_point_2d(toPt);
      __sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt);
    }
    public static void DrawLineOnBitmap(Bitmap destination, Color clr, Point2D fromPt, Point2D toPt, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__from_pt;
      __sklib_point_2d __skparam__to_pt;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__from_pt = __skadapter__to_sklib_point_2d(fromPt);
      __skparam__to_pt = __skadapter__to_sklib_point_2d(toPt);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_line_on_bitmap__bitmap__color__point_2d_ref__point_2d_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts);
    }
    public static void DrawLineOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
    }
    public static void DrawLineOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_line_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts);
    }
    public static void DrawLineOnWindow(Window destination, Color clr, Line l)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_line __skparam__l;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__l = __skadapter__to_sklib_line(l);
      __sklib__draw_line_on_window__window__color__line_ref(__skparam__destination, __skparam__clr, __skparam__l);
    }
    public static void DrawLineOnWindow(Window destination, Color clr, Line l, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_line __skparam__l;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__l = __skadapter__to_sklib_line(l);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_line_on_window__window__color__line_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__l, __skparam__opts);
    }
    public static void DrawLineOnWindow(Window destination, Color clr, Point2D fromPt, Point2D toPt)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__from_pt;
      __sklib_point_2d __skparam__to_pt;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__from_pt = __skadapter__to_sklib_point_2d(fromPt);
      __skparam__to_pt = __skadapter__to_sklib_point_2d(toPt);
      __sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt);
    }
    public static void DrawLineOnWindow(Window destination, Color clr, Point2D fromPt, Point2D toPt, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__from_pt;
      __sklib_point_2d __skparam__to_pt;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__from_pt = __skadapter__to_sklib_point_2d(fromPt);
      __skparam__to_pt = __skadapter__to_sklib_point_2d(toPt);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_line_on_window__window__color__point_2d_ref__point_2d_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__from_pt, __skparam__to_pt, __skparam__opts);
    }
    public static void DrawLineOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __sklib__draw_line_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
    }
    public static void DrawLineOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_line_on_window__window__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__opts);
    }
    public static Point2D ClosestPointOnLine(Point2D fromPt, Line l)
    {
      __sklib_point_2d __skparam__from_pt;
      __sklib_line __skparam__l;
      __sklib_point_2d __skreturn;
      __skparam__from_pt = __skadapter__to_sklib_point_2d(fromPt);
      __skparam__l = __skadapter__to_sklib_line(l);
      __skreturn = __sklib__closest_point_on_line__point_2d__line_ref(__skparam__from_pt, __skparam__l);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Point2D ClosestPointOnLines(Point2D fromPt, List<Line> lines, ref int lineIdx)
    {
      __sklib_point_2d __skparam__from_pt;
      __sklib_vector_line __skparam__lines;
      int __skparam__line_idx;
      __sklib_point_2d __skreturn;
      __skparam__from_pt = __skadapter__to_sklib_point_2d(fromPt);
      __skparam__lines = __skadapter__to_sklib_vector_line(lines);
      __skparam__line_idx = __skadapter__to_sklib_int(lineIdx);
      __skreturn = __sklib__closest_point_on_lines__point_2d__vector_line_ref__int_ref(__skparam__from_pt, __skparam__lines, ref __skparam__line_idx);
      lineIdx = __skadapter__to_int(__skparam__line_idx);
    __skadapter__free__sklib_vector_line(ref __skparam__lines);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Line LineFrom(Point2D start, Point2D endPt)
    {
      __sklib_point_2d __skparam__start;
      __sklib_point_2d __skparam__end_pt;
      __sklib_line __skreturn;
      __skparam__start = __skadapter__to_sklib_point_2d(start);
      __skparam__end_pt = __skadapter__to_sklib_point_2d(endPt);
      __skreturn = __sklib__line_from__point_2d_ref__point_2d_ref(__skparam__start, __skparam__end_pt);
      return __skadapter__to_line(__skreturn);
    }
    public static Line LineFrom(Point2D start, Vector2D offset)
    {
      __sklib_point_2d __skparam__start;
      __sklib_vector_2d __skparam__offset;
      __sklib_line __skreturn;
      __skparam__start = __skadapter__to_sklib_point_2d(start);
      __skparam__offset = __skadapter__to_sklib_vector_2d(offset);
      __skreturn = __sklib__line_from__point_2d_ref__vector_2d_ref(__skparam__start, __skparam__offset);
      return __skadapter__to_line(__skreturn);
    }
    public static Line LineFrom(Vector2D v)
    {
      __sklib_vector_2d __skparam__v;
      __sklib_line __skreturn;
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skreturn = __sklib__line_from__vector_2d_ref(__skparam__v);
      return __skadapter__to_line(__skreturn);
    }
    public static Line LineFrom(double x1, double y1, double x2, double y2)
    {
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      __sklib_line __skreturn;
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skreturn = __sklib__line_from__double__double__double__double(__skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2);
      return __skadapter__to_line(__skreturn);
    }
    public static bool LineIntersectionPoint(Line line1, Line line2, ref Point2D pt)
    {
      __sklib_line __skparam__line1;
      __sklib_line __skparam__line2;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__line1 = __skadapter__to_sklib_line(line1);
      __skparam__line2 = __skadapter__to_sklib_line(line2);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__line_intersection_point__line_ref__line_ref__point_2d_ref(__skparam__line1, __skparam__line2, ref __skparam__pt);
      pt = __skadapter__to_point_2d(__skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool LineIntersectsCircle(Line l, Circle c)
    {
      __sklib_line __skparam__l;
      __sklib_circle __skparam__c;
      int __skreturn;
      __skparam__l = __skadapter__to_sklib_line(l);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skreturn = __sklib__line_intersects_circle__line_ref__circle_ref(__skparam__l, __skparam__c);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool LineIntersectsLines(Line l, List<Line> lines)
    {
      __sklib_line __skparam__l;
      __sklib_vector_line __skparam__lines;
      int __skreturn;
      __skparam__l = __skadapter__to_sklib_line(l);
      __skparam__lines = __skadapter__to_sklib_vector_line(lines);
      __skreturn = __sklib__line_intersects_lines__line_ref__vector_line_ref(__skparam__l, __skparam__lines);
    __skadapter__free__sklib_vector_line(ref __skparam__lines);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool LineIntersectsRect(Line l, Rectangle rect)
    {
      __sklib_line __skparam__l;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__l = __skadapter__to_sklib_line(l);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__line_intersects_rect__line_ref__rectangle_ref(__skparam__l, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static float LineLength(Line l)
    {
      __sklib_line __skparam__l;
      float __skreturn;
      __skparam__l = __skadapter__to_sklib_line(l);
      __skreturn = __sklib__line_length__line_ref(__skparam__l);
      return __skadapter__to_float(__skreturn);
    }
    public static float LineLengthSquared(Line l)
    {
      __sklib_line __skparam__l;
      float __skreturn;
      __skparam__l = __skadapter__to_sklib_line(l);
      __skreturn = __sklib__line_length_squared__line_ref(__skparam__l);
      return __skadapter__to_float(__skreturn);
    }
    public static Point2D LineMidPoint(Line l)
    {
      __sklib_line __skparam__l;
      __sklib_point_2d __skreturn;
      __skparam__l = __skadapter__to_sklib_line(l);
      __skreturn = __sklib__line_mid_point__line_ref(__skparam__l);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Vector2D LineNormal(Line l)
    {
      __sklib_line __skparam__l;
      __sklib_vector_2d __skreturn;
      __skparam__l = __skadapter__to_sklib_line(l);
      __skreturn = __sklib__line_normal__line_ref(__skparam__l);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static string LineToString(Line ln)
    {
      __sklib_line __skparam__ln;
      __sklib_string __skreturn;
      __skparam__ln = __skadapter__to_sklib_line(ln);
      __skreturn = __sklib__line_to_string__line_ref(__skparam__ln);
      return __skadapter__to_string(__skreturn);
    }
    public static List<Line> LinesFrom(Rectangle rect)
    {
      __sklib_rectangle __skparam__rect;
      __sklib_vector_line __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__lines_from__rectangle_ref(__skparam__rect);
      return __skadapter__to_vector_line(__skreturn);
    }
    public static List<Line> LinesFrom(Triangle t)
    {
      __sklib_triangle __skparam__t;
      __sklib_vector_line __skreturn;
      __skparam__t = __skadapter__to_sklib_triangle(t);
      __skreturn = __sklib__lines_from__triangle_ref(__skparam__t);
      return __skadapter__to_vector_line(__skreturn);
    }
    public static bool LinesIntersect(Line l1, Line l2)
    {
      __sklib_line __skparam__l1;
      __sklib_line __skparam__l2;
      int __skreturn;
      __skparam__l1 = __skadapter__to_sklib_line(l1);
      __skparam__l2 = __skadapter__to_sklib_line(l2);
      __skreturn = __sklib__lines_intersect__line_ref__line_ref(__skparam__l1, __skparam__l2);
      return __skadapter__to_bool(__skreturn);
    }
    public static void CloseLogProcess()
    {
      __sklib__close_log_process();
    }
    public static void InitCustomLogger(LogMode mode)
    {
      int __skparam__mode;
      __skparam__mode = __skadapter__to_sklib_log_mode(mode);
      __sklib__init_custom_logger__log_mode(__skparam__mode);
    }
    public static void InitCustomLogger(string appName, bool overridePrevLog, LogMode mode)
    {
      __sklib_string __skparam__app_name;
      int __skparam__override_prev_log;
      int __skparam__mode;
      __skparam__app_name = __skadapter__to_sklib_string(appName);
      __skparam__override_prev_log = __skadapter__to_sklib_bool(overridePrevLog);
      __skparam__mode = __skadapter__to_sklib_log_mode(mode);
      __sklib__init_custom_logger__string__bool__log_mode(__skparam__app_name, __skparam__override_prev_log, __skparam__mode);
    __skadapter__free__sklib_string(ref __skparam__app_name);
    }
    public static void Log(LogLevel level, string message)
    {
      int __skparam__level;
      __sklib_string __skparam__message;
      __skparam__level = __skadapter__to_sklib_log_level(level);
      __skparam__message = __skadapter__to_sklib_string(message);
      __sklib__log__log_level__string(__skparam__level, __skparam__message);
    __skadapter__free__sklib_string(ref __skparam__message);
    }
    public static void ApplyMatrix(Matrix2D matrix, ref Quad q)
    {
      __sklib_matrix_2d __skparam__matrix;
      __sklib_quad __skparam__q;
      __skparam__matrix = __skadapter__to_sklib_matrix_2d(matrix);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __sklib__apply_matrix__matrix_2d_ref__quad_ref(__skparam__matrix, ref __skparam__q);
      q = __skadapter__to_quad(__skparam__q);
    }
    public static void ApplyMatrix(Matrix2D m, ref Triangle tri)
    {
      __sklib_matrix_2d __skparam__m;
      __sklib_triangle __skparam__tri;
      __skparam__m = __skadapter__to_sklib_matrix_2d(m);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __sklib__apply_matrix__matrix_2d_ref__triangle_ref(__skparam__m, ref __skparam__tri);
      tri = __skadapter__to_triangle(__skparam__tri);
    }
    public static Matrix2D IdentityMatrix()
    {
      __sklib_matrix_2d __skreturn;
      __skreturn = __sklib__identity_matrix();
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static Matrix2D MatrixInverse(Matrix2D m)
    {
      __sklib_matrix_2d __skparam__m;
      __sklib_matrix_2d __skreturn;
      __skparam__m = __skadapter__to_sklib_matrix_2d(m);
      __skreturn = __sklib__matrix_inverse__matrix_2d_ref(__skparam__m);
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static Point2D MatrixMultiply(Matrix2D m, Point2D pt)
    {
      __sklib_matrix_2d __skparam__m;
      __sklib_point_2d __skparam__pt;
      __sklib_point_2d __skreturn;
      __skparam__m = __skadapter__to_sklib_matrix_2d(m);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__matrix_multiply__matrix_2d_ref__point_2d_ref(__skparam__m, __skparam__pt);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Matrix2D MatrixMultiply(Matrix2D m1, Matrix2D m2)
    {
      __sklib_matrix_2d __skparam__m1;
      __sklib_matrix_2d __skparam__m2;
      __sklib_matrix_2d __skreturn;
      __skparam__m1 = __skadapter__to_sklib_matrix_2d(m1);
      __skparam__m2 = __skadapter__to_sklib_matrix_2d(m2);
      __skreturn = __sklib__matrix_multiply__matrix_2d_ref__matrix_2d_ref(__skparam__m1, __skparam__m2);
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static Vector2D MatrixMultiply(Matrix2D m, Vector2D v)
    {
      __sklib_matrix_2d __skparam__m;
      __sklib_vector_2d __skparam__v;
      __sklib_vector_2d __skreturn;
      __skparam__m = __skadapter__to_sklib_matrix_2d(m);
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skreturn = __sklib__matrix_multiply__matrix_2d_ref__vector_2d_ref(__skparam__m, __skparam__v);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static string MatrixToString(Matrix2D matrix)
    {
      __sklib_matrix_2d __skparam__matrix;
      __sklib_string __skreturn;
      __skparam__matrix = __skadapter__to_sklib_matrix_2d(matrix);
      __skreturn = __sklib__matrix_to_string__matrix_2d_ref(__skparam__matrix);
      return __skadapter__to_string(__skreturn);
    }
    public static Matrix2D RotationMatrix(double deg)
    {
      double __skparam__deg;
      __sklib_matrix_2d __skreturn;
      __skparam__deg = __skadapter__to_sklib_double(deg);
      __skreturn = __sklib__rotation_matrix__double(__skparam__deg);
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static Matrix2D ScaleMatrix(Point2D scale)
    {
      __sklib_point_2d __skparam__scale;
      __sklib_matrix_2d __skreturn;
      __skparam__scale = __skadapter__to_sklib_point_2d(scale);
      __skreturn = __sklib__scale_matrix__point_2d_ref(__skparam__scale);
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static Matrix2D ScaleMatrix(Vector2D scale)
    {
      __sklib_vector_2d __skparam__scale;
      __sklib_matrix_2d __skreturn;
      __skparam__scale = __skadapter__to_sklib_vector_2d(scale);
      __skreturn = __sklib__scale_matrix__vector_2d_ref(__skparam__scale);
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static Matrix2D ScaleMatrix(double scale)
    {
      double __skparam__scale;
      __sklib_matrix_2d __skreturn;
      __skparam__scale = __skadapter__to_sklib_double(scale);
      __skreturn = __sklib__scale_matrix__double(__skparam__scale);
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static Matrix2D ScaleRotateTranslateMatrix(Point2D scale, double deg, Point2D translate)
    {
      __sklib_point_2d __skparam__scale;
      double __skparam__deg;
      __sklib_point_2d __skparam__translate;
      __sklib_matrix_2d __skreturn;
      __skparam__scale = __skadapter__to_sklib_point_2d(scale);
      __skparam__deg = __skadapter__to_sklib_double(deg);
      __skparam__translate = __skadapter__to_sklib_point_2d(translate);
      __skreturn = __sklib__scale_rotate_translate_matrix__point_2d_ref__double__point_2d_ref(__skparam__scale, __skparam__deg, __skparam__translate);
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static Matrix2D TranslationMatrix(Point2D pt)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_matrix_2d __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__translation_matrix__point_2d_ref(__skparam__pt);
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static Matrix2D TranslationMatrix(Vector2D pt)
    {
      __sklib_vector_2d __skparam__pt;
      __sklib_matrix_2d __skreturn;
      __skparam__pt = __skadapter__to_sklib_vector_2d(pt);
      __skreturn = __sklib__translation_matrix__vector_2d_ref(__skparam__pt);
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static Matrix2D TranslationMatrix(double dx, double dy)
    {
      double __skparam__dx;
      double __skparam__dy;
      __sklib_matrix_2d __skreturn;
      __skparam__dx = __skadapter__to_sklib_double(dx);
      __skparam__dy = __skadapter__to_sklib_double(dy);
      __skreturn = __sklib__translation_matrix__double__double(__skparam__dx, __skparam__dy);
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static void HideMouse()
    {
      __sklib__hide_mouse();
    }
    public static bool MouseClicked(MouseButton button)
    {
      int __skparam__button;
      int __skreturn;
      __skparam__button = __skadapter__to_sklib_mouse_button(button);
      __skreturn = __sklib__mouse_clicked__mouse_button(__skparam__button);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool MouseDown(MouseButton button)
    {
      int __skparam__button;
      int __skreturn;
      __skparam__button = __skadapter__to_sklib_mouse_button(button);
      __skreturn = __sklib__mouse_down__mouse_button(__skparam__button);
      return __skadapter__to_bool(__skreturn);
    }
    public static Vector2D MouseMovement()
    {
      __sklib_vector_2d __skreturn;
      __skreturn = __sklib__mouse_movement();
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Point2D MousePosition()
    {
      __sklib_point_2d __skreturn;
      __skreturn = __sklib__mouse_position();
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Vector2D MousePositionVector()
    {
      __sklib_vector_2d __skreturn;
      __skreturn = __sklib__mouse_position_vector();
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static bool MouseShown()
    {
      int __skreturn;
      __skreturn = __sklib__mouse_shown();
      return __skadapter__to_bool(__skreturn);
    }
    public static bool MouseUp(MouseButton button)
    {
      int __skparam__button;
      int __skreturn;
      __skparam__button = __skadapter__to_sklib_mouse_button(button);
      __skreturn = __sklib__mouse_up__mouse_button(__skparam__button);
      return __skadapter__to_bool(__skreturn);
    }
    public static Vector2D MouseWheelScroll()
    {
      __sklib_vector_2d __skreturn;
      __skreturn = __sklib__mouse_wheel_scroll();
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static float MouseX()
    {
      float __skreturn;
      __skreturn = __sklib__mouse_x();
      return __skadapter__to_float(__skreturn);
    }
    public static float MouseY()
    {
      float __skreturn;
      __skreturn = __sklib__mouse_y();
      return __skadapter__to_float(__skreturn);
    }
    public static void MoveMouse(double x, double y)
    {
      double __skparam__x;
      double __skparam__y;
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__move_mouse__double__double(__skparam__x, __skparam__y);
    }
    public static void MoveMouse(Point2D point)
    {
      __sklib_point_2d __skparam__point;
      __skparam__point = __skadapter__to_sklib_point_2d(point);
      __sklib__move_mouse__point_2d(__skparam__point);
    }
    public static void ShowMouse()
    {
      __sklib__show_mouse();
    }
    public static void ShowMouse(bool show)
    {
      int __skparam__show;
      __skparam__show = __skadapter__to_sklib_bool(show);
      __sklib__show_mouse__bool(__skparam__show);
    }
    public static void FadeMusicIn(string name, int ms)
    {
      __sklib_string __skparam__name;
      int __skparam__ms;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__ms = __skadapter__to_sklib_int(ms);
      __sklib__fade_music_in__string_ref__int(__skparam__name, __skparam__ms);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void FadeMusicIn(string name, int times, int ms)
    {
      __sklib_string __skparam__name;
      int __skparam__times;
      int __skparam__ms;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__times = __skadapter__to_sklib_int(times);
      __skparam__ms = __skadapter__to_sklib_int(ms);
      __sklib__fade_music_in__string_ref__int__int(__skparam__name, __skparam__times, __skparam__ms);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void FadeMusicIn(Music data, int ms)
    {
      __sklib_ptr __skparam__data;
      int __skparam__ms;
      __skparam__data = __skadapter__to_sklib_music(data);
      __skparam__ms = __skadapter__to_sklib_int(ms);
      __sklib__fade_music_in__music__int(__skparam__data, __skparam__ms);
    }
    public static void FadeMusicIn(Music data, int times, int ms)
    {
      __sklib_ptr __skparam__data;
      int __skparam__times;
      int __skparam__ms;
      __skparam__data = __skadapter__to_sklib_music(data);
      __skparam__times = __skadapter__to_sklib_int(times);
      __skparam__ms = __skadapter__to_sklib_int(ms);
      __sklib__fade_music_in__music__int__int(__skparam__data, __skparam__times, __skparam__ms);
    }
    public static void FadeMusicOut(int ms)
    {
      int __skparam__ms;
      __skparam__ms = __skadapter__to_sklib_int(ms);
      __sklib__fade_music_out__int(__skparam__ms);
    }
    public static void FreeAllMusic()
    {
      __sklib__free_all_music();
    }
    public static void FreeMusic(Music effect)
    {
      __sklib_ptr __skparam__effect;
      __skparam__effect = __skadapter__to_sklib_music(effect);
      __sklib__free_music__music(__skparam__effect);
    }
    public static bool HasMusic(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_music__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static Music LoadMusic(string name, string filename)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__filename;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __skreturn = __sklib__load_music__string_ref__string_ref(__skparam__name, __skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__filename);
      return __skadapter__to_music(__skreturn);
    }
    public static string MusicFilename(Music data)
    {
      __sklib_ptr __skparam__data;
      __sklib_string __skreturn;
      __skparam__data = __skadapter__to_sklib_music(data);
      __skreturn = __sklib__music_filename__music(__skparam__data);
      return __skadapter__to_string(__skreturn);
    }
    public static string MusicName(Music data)
    {
      __sklib_ptr __skparam__data;
      __sklib_string __skreturn;
      __skparam__data = __skadapter__to_sklib_music(data);
      __skreturn = __sklib__music_name__music(__skparam__data);
      return __skadapter__to_string(__skreturn);
    }
    public static Music MusicNamed(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__music_named__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_music(__skreturn);
    }
    public static bool MusicPlaying()
    {
      int __skreturn;
      __skreturn = __sklib__music_playing();
      return __skadapter__to_bool(__skreturn);
    }
    public static bool MusicValid(Music m)
    {
      __sklib_ptr __skparam__m;
      int __skreturn;
      __skparam__m = __skadapter__to_sklib_music(m);
      __skreturn = __sklib__music_valid__music(__skparam__m);
      return __skadapter__to_bool(__skreturn);
    }
    public static double MusicVolume()
    {
      double __skreturn;
      __skreturn = __sklib__music_volume();
      return __skadapter__to_double(__skreturn);
    }
    public static void PauseMusic()
    {
      __sklib__pause_music();
    }
    public static void PlayMusic(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__play_music__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void PlayMusic(string name, int times)
    {
      __sklib_string __skparam__name;
      int __skparam__times;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__times = __skadapter__to_sklib_int(times);
      __sklib__play_music__string_ref__int(__skparam__name, __skparam__times);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void PlayMusic(Music data)
    {
      __sklib_ptr __skparam__data;
      __skparam__data = __skadapter__to_sklib_music(data);
      __sklib__play_music__music(__skparam__data);
    }
    public static void PlayMusic(Music data, int times)
    {
      __sklib_ptr __skparam__data;
      int __skparam__times;
      __skparam__data = __skadapter__to_sklib_music(data);
      __skparam__times = __skadapter__to_sklib_int(times);
      __sklib__play_music__music__int(__skparam__data, __skparam__times);
    }
    public static void PlayMusic(Music data, int times, double volume)
    {
      __sklib_ptr __skparam__data;
      int __skparam__times;
      double __skparam__volume;
      __skparam__data = __skadapter__to_sklib_music(data);
      __skparam__times = __skadapter__to_sklib_int(times);
      __skparam__volume = __skadapter__to_sklib_double(volume);
      __sklib__play_music__music__int__double(__skparam__data, __skparam__times, __skparam__volume);
    }
    public static void ResumeMusic()
    {
      __sklib__resume_music();
    }
    public static void SetMusicVolume(double volume)
    {
      double __skparam__volume;
      __skparam__volume = __skadapter__to_sklib_double(volume);
      __sklib__set_music_volume__double(__skparam__volume);
    }
    public static void StopMusic()
    {
      __sklib__stop_music();
    }
    public static bool AcceptAllNewConnections()
    {
      int __skreturn;
      __skreturn = __sklib__accept_all_new_connections();
      return __skadapter__to_bool(__skreturn);
    }
    public static bool AcceptNewConnection(ServerSocket server)
    {
      __sklib_ptr __skparam__server;
      int __skreturn;
      __skparam__server = __skadapter__to_sklib_server_socket(server);
      __skreturn = __sklib__accept_new_connection__server_socket(__skparam__server);
      return __skadapter__to_bool(__skreturn);
    }
    public static void BroadcastMessage(string aMsg, ServerSocket svr)
    {
      __sklib_string __skparam__a_msg;
      __sklib_ptr __skparam__svr;
      __skparam__a_msg = __skadapter__to_sklib_string(aMsg);
      __skparam__svr = __skadapter__to_sklib_server_socket(svr);
      __sklib__broadcast_message__string_ref__server_socket(__skparam__a_msg, __skparam__svr);
    __skadapter__free__sklib_string(ref __skparam__a_msg);
    }
    public static void BroadcastMessage(string aMsg)
    {
      __sklib_string __skparam__a_msg;
      __skparam__a_msg = __skadapter__to_sklib_string(aMsg);
      __sklib__broadcast_message__string_ref(__skparam__a_msg);
    __skadapter__free__sklib_string(ref __skparam__a_msg);
    }
    public static void BroadcastMessage(string aMsg, string name)
    {
      __sklib_string __skparam__a_msg;
      __sklib_string __skparam__name;
      __skparam__a_msg = __skadapter__to_sklib_string(aMsg);
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__broadcast_message__string_ref__string_ref(__skparam__a_msg, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__a_msg);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void CheckNetworkActivity()
    {
      __sklib__check_network_activity();
    }
    public static void ClearMessages(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__clear_messages__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void ClearMessages(Connection aConnection)
    {
      __sklib_ptr __skparam__a_connection;
      __skparam__a_connection = __skadapter__to_sklib_connection(aConnection);
      __sklib__clear_messages__connection(__skparam__a_connection);
    }
    public static void ClearMessages(ServerSocket svr)
    {
      __sklib_ptr __skparam__svr;
      __skparam__svr = __skadapter__to_sklib_server_socket(svr);
      __sklib__clear_messages__server_socket(__skparam__svr);
    }
    public static void CloseAllConnections()
    {
      __sklib__close_all_connections();
    }
    public static void CloseAllServers()
    {
      __sklib__close_all_servers();
    }
    public static bool CloseConnection(Connection aConnection)
    {
      __sklib_ptr __skparam__a_connection;
      int __skreturn;
      __skparam__a_connection = __skadapter__to_sklib_connection(aConnection);
      __skreturn = __sklib__close_connection__connection(__skparam__a_connection);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool CloseConnection(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__close_connection__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static void CloseMessage(Message msg)
    {
      __sklib_ptr __skparam__msg;
      __skparam__msg = __skadapter__to_sklib_message(msg);
      __sklib__close_message__message(__skparam__msg);
    }
    public static bool CloseServer(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__close_server__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool CloseServer(ServerSocket svr)
    {
      __sklib_ptr __skparam__svr;
      int __skreturn;
      __skparam__svr = __skadapter__to_sklib_server_socket(svr);
      __skreturn = __sklib__close_server__server_socket(__skparam__svr);
      return __skadapter__to_bool(__skreturn);
    }
    public static uint ConnectionCount(string name)
    {
      __sklib_string __skparam__name;
      uint __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__connection_count__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static uint ConnectionCount(ServerSocket server)
    {
      __sklib_ptr __skparam__server;
      uint __skreturn;
      __skparam__server = __skadapter__to_sklib_server_socket(server);
      __skreturn = __sklib__connection_count__server_socket(__skparam__server);
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static uint ConnectionIP(Connection aConnection)
    {
      __sklib_ptr __skparam__a_connection;
      uint __skreturn;
      __skparam__a_connection = __skadapter__to_sklib_connection(aConnection);
      __skreturn = __sklib__connection_ip__connection(__skparam__a_connection);
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static uint ConnectionIP(string name)
    {
      __sklib_string __skparam__name;
      uint __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__connection_ip__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static Connection ConnectionNamed(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__connection_named__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_connection(__skreturn);
    }
    public static ushort ConnectionPort(Connection aConnection)
    {
      __sklib_ptr __skparam__a_connection;
      ushort __skreturn;
      __skparam__a_connection = __skadapter__to_sklib_connection(aConnection);
      __skreturn = __sklib__connection_port__connection(__skparam__a_connection);
      return __skadapter__to_unsigned_short(__skreturn);
    }
    public static ushort ConnectionPort(string name)
    {
      __sklib_string __skparam__name;
      ushort __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__connection_port__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_unsigned_short(__skreturn);
    }
    public static ServerSocket CreateServer(string name, ushort port)
    {
      __sklib_string __skparam__name;
      ushort __skparam__port;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skreturn = __sklib__create_server__string_ref__unsigned_short(__skparam__name, __skparam__port);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_server_socket(__skreturn);
    }
    public static ServerSocket CreateServer(string name, ushort port, ConnectionType protocol)
    {
      __sklib_string __skparam__name;
      ushort __skparam__port;
      int __skparam__protocol;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skparam__protocol = __skadapter__to_sklib_connection_type(protocol);
      __skreturn = __sklib__create_server__string_ref__unsigned_short__connection_type(__skparam__name, __skparam__port, __skparam__protocol);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_server_socket(__skreturn);
    }
    public static string DecToHex(uint aDec)
    {
      uint __skparam__a_dec;
      __sklib_string __skreturn;
      __skparam__a_dec = __skadapter__to_sklib_unsigned_int(aDec);
      __skreturn = __sklib__dec_to_hex__unsigned_int(__skparam__a_dec);
      return __skadapter__to_string(__skreturn);
    }
    public static Connection FetchNewConnection(ServerSocket server)
    {
      __sklib_ptr __skparam__server;
      __sklib_ptr __skreturn;
      __skparam__server = __skadapter__to_sklib_server_socket(server);
      __skreturn = __sklib__fetch_new_connection__server_socket(__skparam__server);
      return __skadapter__to_connection(__skreturn);
    }
    public static bool HasConnection(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_connection__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool HasMessages()
    {
      int __skreturn;
      __skreturn = __sklib__has_messages();
      return __skadapter__to_bool(__skreturn);
    }
    public static bool HasMessages(Connection con)
    {
      __sklib_ptr __skparam__con;
      int __skreturn;
      __skparam__con = __skadapter__to_sklib_connection(con);
      __skreturn = __sklib__has_messages__connection(__skparam__con);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool HasMessages(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_messages__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool HasMessages(ServerSocket svr)
    {
      __sklib_ptr __skparam__svr;
      int __skreturn;
      __skparam__svr = __skadapter__to_sklib_server_socket(svr);
      __skreturn = __sklib__has_messages__server_socket(__skparam__svr);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool HasNewConnections()
    {
      int __skreturn;
      __skreturn = __sklib__has_new_connections();
      return __skadapter__to_bool(__skreturn);
    }
    public static bool HasServer(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_server__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static string HexStrToIpv4(string aHex)
    {
      __sklib_string __skparam__a_hex;
      __sklib_string __skreturn;
      __skparam__a_hex = __skadapter__to_sklib_string(aHex);
      __skreturn = __sklib__hex_str_to_ipv4__string_ref(__skparam__a_hex);
    __skadapter__free__sklib_string(ref __skparam__a_hex);
      return __skadapter__to_string(__skreturn);
    }
    public static string HexToDecString(string aHex)
    {
      __sklib_string __skparam__a_hex;
      __sklib_string __skreturn;
      __skparam__a_hex = __skadapter__to_sklib_string(aHex);
      __skreturn = __sklib__hex_to_dec_string__string_ref(__skparam__a_hex);
    __skadapter__free__sklib_string(ref __skparam__a_hex);
      return __skadapter__to_string(__skreturn);
    }
    public static uint Ipv4ToDec(string aIP)
    {
      __sklib_string __skparam__a_ip;
      uint __skreturn;
      __skparam__a_ip = __skadapter__to_sklib_string(aIP);
      __skreturn = __sklib__ipv4_to_dec__string_ref(__skparam__a_ip);
    __skadapter__free__sklib_string(ref __skparam__a_ip);
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static string Ipv4ToHex(string aIP)
    {
      __sklib_string __skparam__a_ip;
      __sklib_string __skreturn;
      __skparam__a_ip = __skadapter__to_sklib_string(aIP);
      __skreturn = __sklib__ipv4_to_hex__string_ref(__skparam__a_ip);
    __skadapter__free__sklib_string(ref __skparam__a_ip);
      return __skadapter__to_string(__skreturn);
    }
    public static string Ipv4ToStr(uint ip)
    {
      uint __skparam__ip;
      __sklib_string __skreturn;
      __skparam__ip = __skadapter__to_sklib_unsigned_int(ip);
      __skreturn = __sklib__ipv4_to_str__unsigned_int(__skparam__ip);
      return __skadapter__to_string(__skreturn);
    }
    public static bool IsConnectionOpen(Connection con)
    {
      __sklib_ptr __skparam__con;
      int __skreturn;
      __skparam__con = __skadapter__to_sklib_connection(con);
      __skreturn = __sklib__is_connection_open__connection(__skparam__con);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool IsConnectionOpen(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__is_connection_open__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static Connection LastConnection(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__last_connection__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_connection(__skreturn);
    }
    public static Connection LastConnection(ServerSocket server)
    {
      __sklib_ptr __skparam__server;
      __sklib_ptr __skreturn;
      __skparam__server = __skadapter__to_sklib_server_socket(server);
      __skreturn = __sklib__last_connection__server_socket(__skparam__server);
      return __skadapter__to_connection(__skreturn);
    }
    public static Connection MessageConnection(Message msg)
    {
      __sklib_ptr __skparam__msg;
      __sklib_ptr __skreturn;
      __skparam__msg = __skadapter__to_sklib_message(msg);
      __skreturn = __sklib__message_connection__message(__skparam__msg);
      return __skadapter__to_connection(__skreturn);
    }
    public static uint MessageCount(ServerSocket svr)
    {
      __sklib_ptr __skparam__svr;
      uint __skreturn;
      __skparam__svr = __skadapter__to_sklib_server_socket(svr);
      __skreturn = __sklib__message_count__server_socket(__skparam__svr);
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static uint MessageCount(Connection aConnection)
    {
      __sklib_ptr __skparam__a_connection;
      uint __skreturn;
      __skparam__a_connection = __skadapter__to_sklib_connection(aConnection);
      __skreturn = __sklib__message_count__connection(__skparam__a_connection);
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static uint MessageCount(string name)
    {
      __sklib_string __skparam__name;
      uint __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__message_count__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static string MessageData(Message msg)
    {
      __sklib_ptr __skparam__msg;
      __sklib_string __skreturn;
      __skparam__msg = __skadapter__to_sklib_message(msg);
      __skreturn = __sklib__message_data__message(__skparam__msg);
      return __skadapter__to_string(__skreturn);
    }
    public static List<byte> MessageDataBytes(Message msg)
    {
      __sklib_ptr __skparam__msg;
      __sklib_vector_int8_t __skreturn;
      __skparam__msg = __skadapter__to_sklib_message(msg);
      __skreturn = __sklib__message_data_bytes__message(__skparam__msg);
      return __skadapter__to_vector_int8_t(__skreturn);
    }
    public static string MessageHost(Message msg)
    {
      __sklib_ptr __skparam__msg;
      __sklib_string __skreturn;
      __skparam__msg = __skadapter__to_sklib_message(msg);
      __skreturn = __sklib__message_host__message(__skparam__msg);
      return __skadapter__to_string(__skreturn);
    }
    public static ushort MessagePort(Message msg)
    {
      __sklib_ptr __skparam__msg;
      ushort __skreturn;
      __skparam__msg = __skadapter__to_sklib_message(msg);
      __skreturn = __sklib__message_port__message(__skparam__msg);
      return __skadapter__to_unsigned_short(__skreturn);
    }
    public static ConnectionType MessageProtocol(Message msg)
    {
      __sklib_ptr __skparam__msg;
      int __skreturn;
      __skparam__msg = __skadapter__to_sklib_message(msg);
      __skreturn = __sklib__message_protocol__message(__skparam__msg);
      return __skadapter__to_connection_type(__skreturn);
    }
    public static string MyIP()
    {
      __sklib_string __skreturn;
      __skreturn = __sklib__my_ip();
      return __skadapter__to_string(__skreturn);
    }
    public static string NameForConnection(string host, uint port)
    {
      __sklib_string __skparam__host;
      uint __skparam__port;
      __sklib_string __skreturn;
      __skparam__host = __skadapter__to_sklib_string(host);
      __skparam__port = __skadapter__to_sklib_unsigned_int(port);
      __skreturn = __sklib__name_for_connection__string__unsigned_int(__skparam__host, __skparam__port);
    __skadapter__free__sklib_string(ref __skparam__host);
      return __skadapter__to_string(__skreturn);
    }
    public static int NewConnectionCount(ServerSocket server)
    {
      __sklib_ptr __skparam__server;
      int __skreturn;
      __skparam__server = __skadapter__to_sklib_server_socket(server);
      __skreturn = __sklib__new_connection_count__server_socket(__skparam__server);
      return __skadapter__to_int(__skreturn);
    }
    public static Connection OpenConnection(string name, string host, ushort port)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__host;
      ushort __skparam__port;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__host = __skadapter__to_sklib_string(host);
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skreturn = __sklib__open_connection__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__host, __skparam__port);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__host);
      return __skadapter__to_connection(__skreturn);
    }
    public static Connection OpenConnection(string name, string host, ushort port, ConnectionType protocol)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__host;
      ushort __skparam__port;
      int __skparam__protocol;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__host = __skadapter__to_sklib_string(host);
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skparam__protocol = __skadapter__to_sklib_connection_type(protocol);
      __skreturn = __sklib__open_connection__string_ref__string_ref__unsigned_short__connection_type(__skparam__name, __skparam__host, __skparam__port, __skparam__protocol);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__host);
      return __skadapter__to_connection(__skreturn);
    }
    public static Message ReadMessage()
    {
      __sklib_ptr __skreturn;
      __skreturn = __sklib__read_message();
      return __skadapter__to_message(__skreturn);
    }
    public static Message ReadMessage(Connection aConnection)
    {
      __sklib_ptr __skparam__a_connection;
      __sklib_ptr __skreturn;
      __skparam__a_connection = __skadapter__to_sklib_connection(aConnection);
      __skreturn = __sklib__read_message__connection(__skparam__a_connection);
      return __skadapter__to_message(__skreturn);
    }
    public static Message ReadMessage(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__read_message__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_message(__skreturn);
    }
    public static Message ReadMessage(ServerSocket svr)
    {
      __sklib_ptr __skparam__svr;
      __sklib_ptr __skreturn;
      __skparam__svr = __skadapter__to_sklib_server_socket(svr);
      __skreturn = __sklib__read_message__server_socket(__skparam__svr);
      return __skadapter__to_message(__skreturn);
    }
    public static string ReadMessageData(string name)
    {
      __sklib_string __skparam__name;
      __sklib_string __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__read_message_data__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_string(__skreturn);
    }
    public static string ReadMessageData(Connection aConnection)
    {
      __sklib_ptr __skparam__a_connection;
      __sklib_string __skreturn;
      __skparam__a_connection = __skadapter__to_sklib_connection(aConnection);
      __skreturn = __sklib__read_message_data__connection(__skparam__a_connection);
      return __skadapter__to_string(__skreturn);
    }
    public static string ReadMessageData(ServerSocket svr)
    {
      __sklib_ptr __skparam__svr;
      __sklib_string __skreturn;
      __skparam__svr = __skadapter__to_sklib_server_socket(svr);
      __skreturn = __sklib__read_message_data__server_socket(__skparam__svr);
      return __skadapter__to_string(__skreturn);
    }
    public static void Reconnect(Connection aConnection)
    {
      __sklib_ptr __skparam__a_connection;
      __skparam__a_connection = __skadapter__to_sklib_connection(aConnection);
      __sklib__reconnect__connection(__skparam__a_connection);
    }
    public static void Reconnect(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__reconnect__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void ReleaseAllConnections()
    {
      __sklib__release_all_connections();
    }
    public static void ResetNewConnectionCount(ServerSocket server)
    {
      __sklib_ptr __skparam__server;
      __skparam__server = __skadapter__to_sklib_server_socket(server);
      __sklib__reset_new_connection_count__server_socket(__skparam__server);
    }
    public static Connection RetrieveConnection(string name, int idx)
    {
      __sklib_string __skparam__name;
      int __skparam__idx;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skreturn = __sklib__retrieve_connection__string_ref__int(__skparam__name, __skparam__idx);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_connection(__skreturn);
    }
    public static Connection RetrieveConnection(ServerSocket server, int idx)
    {
      __sklib_ptr __skparam__server;
      int __skparam__idx;
      __sklib_ptr __skreturn;
      __skparam__server = __skadapter__to_sklib_server_socket(server);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skreturn = __sklib__retrieve_connection__server_socket__int(__skparam__server, __skparam__idx);
      return __skadapter__to_connection(__skreturn);
    }
    public static bool SendMessageTo(string aMsg, Connection aConnection)
    {
      __sklib_string __skparam__a_msg;
      __sklib_ptr __skparam__a_connection;
      int __skreturn;
      __skparam__a_msg = __skadapter__to_sklib_string(aMsg);
      __skparam__a_connection = __skadapter__to_sklib_connection(aConnection);
      __skreturn = __sklib__send_message_to__string_ref__connection(__skparam__a_msg, __skparam__a_connection);
    __skadapter__free__sklib_string(ref __skparam__a_msg);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool SendMessageTo(string aMsg, string name)
    {
      __sklib_string __skparam__a_msg;
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__a_msg = __skadapter__to_sklib_string(aMsg);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__send_message_to__string_ref__string_ref(__skparam__a_msg, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__a_msg);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool ServerHasNewConnection(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__server_has_new_connection__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool ServerHasNewConnection(ServerSocket server)
    {
      __sklib_ptr __skparam__server;
      int __skreturn;
      __skparam__server = __skadapter__to_sklib_server_socket(server);
      __skreturn = __sklib__server_has_new_connection__server_socket(__skparam__server);
      return __skadapter__to_bool(__skreturn);
    }
    public static ServerSocket ServerNamed(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__server_named__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_server_socket(__skreturn);
    }
    public static void SetUDPPacketSize(uint udpPacketSize)
    {
      uint __skparam__udp_packet_size;
      __skparam__udp_packet_size = __skadapter__to_sklib_unsigned_int(udpPacketSize);
      __sklib__set_udp_packet_size__unsigned_int(__skparam__udp_packet_size);
    }
    public static uint UDPPacketSize()
    {
      uint __skreturn;
      __skreturn = __sklib__udp_packet_size();
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static void DrawPixel(Color clr, Point2D pt)
    {
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__pt;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __sklib__draw_pixel__color__point_2d_ref(__skparam__clr, __skparam__pt);
    }
    public static void DrawPixel(Color clr, Point2D pt, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__pt;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_pixel__color__point_2d_ref__drawing_options(__skparam__clr, __skparam__pt, __skparam__opts);
    }
    public static void DrawPixel(Color clr, double x, double y)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_pixel__color__double__double(__skparam__clr, __skparam__x, __skparam__y);
    }
    public static void DrawPixel(Color clr, double x, double y, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_pixel__color__double__double__drawing_options(__skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
    }
    public static void DrawPixelOnBitmap(Bitmap destination, Color clr, Point2D pt)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__pt;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__pt);
    }
    public static void DrawPixelOnBitmap(Bitmap destination, Color clr, Point2D pt, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__pt;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_pixel_on_bitmap__bitmap__color__point_2d_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__pt, __skparam__opts);
    }
    public static void DrawPixelOnBitmap(Bitmap destination, Color clr, double x, double y)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_pixel_on_bitmap__bitmap__color__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y);
    }
    public static void DrawPixelOnBitmap(Bitmap destination, Color clr, double x, double y, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_pixel_on_bitmap__bitmap__color__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
    }
    public static void DrawPixelOnWindow(Window destination, Color clr, Point2D pt)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__pt;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __sklib__draw_pixel_on_window__window__color__point_2d_ref(__skparam__destination, __skparam__clr, __skparam__pt);
    }
    public static void DrawPixelOnWindow(Window destination, Color clr, Point2D pt, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_point_2d __skparam__pt;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_pixel_on_window__window__color__point_2d_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__pt, __skparam__opts);
    }
    public static void DrawPixelOnWindow(Window destination, Color clr, double x, double y)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_pixel_on_window__window__color__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y);
    }
    public static void DrawPixelOnWindow(Window destination, Color clr, double x, double y, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_pixel_on_window__window__color__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
    }
    public static Color GetPixel(Bitmap bmp, Point2D pt)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_point_2d __skparam__pt;
      __sklib_color __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__get_pixel__bitmap__point_2d_ref(__skparam__bmp, __skparam__pt);
      return __skadapter__to_color(__skreturn);
    }
    public static Color GetPixel(Bitmap bmp, double x, double y)
    {
      __sklib_ptr __skparam__bmp;
      double __skparam__x;
      double __skparam__y;
      __sklib_color __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__get_pixel__bitmap__double__double(__skparam__bmp, __skparam__x, __skparam__y);
      return __skadapter__to_color(__skreturn);
    }
    public static Color GetPixel(Point2D pt)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_color __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__get_pixel__point_2d_ref(__skparam__pt);
      return __skadapter__to_color(__skreturn);
    }
    public static Color GetPixel(double x, double y)
    {
      double __skparam__x;
      double __skparam__y;
      __sklib_color __skreturn;
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__get_pixel__double__double(__skparam__x, __skparam__y);
      return __skadapter__to_color(__skreturn);
    }
    public static Color GetPixel(Window wnd, Point2D pt)
    {
      __sklib_ptr __skparam__wnd;
      __sklib_point_2d __skparam__pt;
      __sklib_color __skreturn;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__get_pixel__window__point_2d_ref(__skparam__wnd, __skparam__pt);
      return __skadapter__to_color(__skreturn);
    }
    public static Color GetPixel(Window wnd, double x, double y)
    {
      __sklib_ptr __skparam__wnd;
      double __skparam__x;
      double __skparam__y;
      __sklib_color __skreturn;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__get_pixel__window__double__double(__skparam__wnd, __skparam__x, __skparam__y);
      return __skadapter__to_color(__skreturn);
    }
    public static Color GetPixelFromWindow(Window destination, Point2D pt)
    {
      __sklib_ptr __skparam__destination;
      __sklib_point_2d __skparam__pt;
      __sklib_color __skreturn;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__get_pixel_from_window__window__point_2d_ref(__skparam__destination, __skparam__pt);
      return __skadapter__to_color(__skreturn);
    }
    public static Color GetPixelFromWindow(Window destination, double x, double y)
    {
      __sklib_ptr __skparam__destination;
      double __skparam__x;
      double __skparam__y;
      __sklib_color __skreturn;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__get_pixel_from_window__window__double__double(__skparam__destination, __skparam__x, __skparam__y);
      return __skadapter__to_color(__skreturn);
    }
    public static Point2D PointAt(double x, double y)
    {
      double __skparam__x;
      double __skparam__y;
      __sklib_point_2d __skreturn;
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__point_at__double__double(__skparam__x, __skparam__y);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Point2D PointAtOrigin()
    {
      __sklib_point_2d __skreturn;
      __skreturn = __sklib__point_at_origin();
      return __skadapter__to_point_2d(__skreturn);
    }
    public static bool PointInCircle(Point2D pt, Circle c)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_circle __skparam__c;
      int __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skreturn = __sklib__point_in_circle__point_2d_ref__circle_ref(__skparam__pt, __skparam__c);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool PointInCircle(double ptx, double pty, double cx, double cy, double radius)
    {
      double __skparam__ptx;
      double __skparam__pty;
      double __skparam__cx;
      double __skparam__cy;
      double __skparam__radius;
      int __skreturn;
      __skparam__ptx = __skadapter__to_sklib_double(ptx);
      __skparam__pty = __skadapter__to_sklib_double(pty);
      __skparam__cx = __skadapter__to_sklib_double(cx);
      __skparam__cy = __skadapter__to_sklib_double(cy);
      __skparam__radius = __skadapter__to_sklib_double(radius);
      __skreturn = __sklib__point_in_circle__double__double__double__double__double(__skparam__ptx, __skparam__pty, __skparam__cx, __skparam__cy, __skparam__radius);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool PointInQuad(Point2D pt, Quad q)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_quad __skparam__q;
      int __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __skreturn = __sklib__point_in_quad__point_2d_ref__quad_ref(__skparam__pt, __skparam__q);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool PointInRectangle(Point2D pt, Rectangle rect)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__point_in_rectangle__point_2d_ref__rectangle_ref(__skparam__pt, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool PointInRectangle(double ptx, double pty, double rectX, double rectY, double rectWidth, double rectHeight)
    {
      double __skparam__ptx;
      double __skparam__pty;
      double __skparam__rect_x;
      double __skparam__rect_y;
      double __skparam__rect_width;
      double __skparam__rect_height;
      int __skreturn;
      __skparam__ptx = __skadapter__to_sklib_double(ptx);
      __skparam__pty = __skadapter__to_sklib_double(pty);
      __skparam__rect_x = __skadapter__to_sklib_double(rectX);
      __skparam__rect_y = __skadapter__to_sklib_double(rectY);
      __skparam__rect_width = __skadapter__to_sklib_double(rectWidth);
      __skparam__rect_height = __skadapter__to_sklib_double(rectHeight);
      __skreturn = __sklib__point_in_rectangle__double__double__double__double__double__double(__skparam__ptx, __skparam__pty, __skparam__rect_x, __skparam__rect_y, __skparam__rect_width, __skparam__rect_height);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool PointInTriangle(Point2D pt, Triangle tri)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_triangle __skparam__tri;
      int __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skreturn = __sklib__point_in_triangle__point_2d_ref__triangle_ref(__skparam__pt, __skparam__tri);
      return __skadapter__to_bool(__skreturn);
    }
    public static float PointLineDistance(Point2D pt, Line l)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_line __skparam__l;
      float __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__l = __skadapter__to_sklib_line(l);
      __skreturn = __sklib__point_line_distance__point_2d_ref__line_ref(__skparam__pt, __skparam__l);
      return __skadapter__to_float(__skreturn);
    }
    public static Point2D PointOffsetBy(Point2D startPoint, Vector2D offset)
    {
      __sklib_point_2d __skparam__start_point;
      __sklib_vector_2d __skparam__offset;
      __sklib_point_2d __skreturn;
      __skparam__start_point = __skadapter__to_sklib_point_2d(startPoint);
      __skparam__offset = __skadapter__to_sklib_vector_2d(offset);
      __skreturn = __sklib__point_offset_by__point_2d_ref__vector_2d_ref(__skparam__start_point, __skparam__offset);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Point2D PointOffsetFromOrigin(Vector2D offset)
    {
      __sklib_vector_2d __skparam__offset;
      __sklib_point_2d __skreturn;
      __skparam__offset = __skadapter__to_sklib_vector_2d(offset);
      __skreturn = __sklib__point_offset_from_origin__vector_2d_ref(__skparam__offset);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static bool PointOnLine(Point2D pt, Line l)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_line __skparam__l;
      int __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__l = __skadapter__to_sklib_line(l);
      __skreturn = __sklib__point_on_line__point_2d_ref__line_ref(__skparam__pt, __skparam__l);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool PointOnLine(Point2D pt, Line l, float proximity)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_line __skparam__l;
      float __skparam__proximity;
      int __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__l = __skadapter__to_sklib_line(l);
      __skparam__proximity = __skadapter__to_sklib_float(proximity);
      __skreturn = __sklib__point_on_line__point_2d_ref__line_ref__float(__skparam__pt, __skparam__l, __skparam__proximity);
      return __skadapter__to_bool(__skreturn);
    }
    public static float PointPointAngle(Point2D pt1, Point2D pt2)
    {
      __sklib_point_2d __skparam__pt1;
      __sklib_point_2d __skparam__pt2;
      float __skreturn;
      __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1);
      __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2);
      __skreturn = __sklib__point_point_angle__point_2d_ref__point_2d_ref(__skparam__pt1, __skparam__pt2);
      return __skadapter__to_float(__skreturn);
    }
    public static float PointPointDistance(Point2D pt1, Point2D pt2)
    {
      __sklib_point_2d __skparam__pt1;
      __sklib_point_2d __skparam__pt2;
      float __skreturn;
      __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1);
      __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2);
      __skreturn = __sklib__point_point_distance__point_2d_ref__point_2d_ref(__skparam__pt1, __skparam__pt2);
      return __skadapter__to_float(__skreturn);
    }
    public static string PointToString(Point2D pt)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_string __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__point_to_string__point_2d_ref(__skparam__pt);
      return __skadapter__to_string(__skreturn);
    }
    public static Point2D RandomBitmapPoint(Bitmap bmp)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_point_2d __skreturn;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skreturn = __sklib__random_bitmap_point__bitmap(__skparam__bmp);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Point2D RandomScreenPoint()
    {
      __sklib_point_2d __skreturn;
      __skreturn = __sklib__random_screen_point();
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Point2D RandomWindowPoint(Window wind)
    {
      __sklib_ptr __skparam__wind;
      __sklib_point_2d __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skreturn = __sklib__random_window_point__window(__skparam__wind);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static bool SamePoint(Point2D pt1, Point2D pt2)
    {
      __sklib_point_2d __skparam__pt1;
      __sklib_point_2d __skparam__pt2;
      int __skreturn;
      __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1);
      __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2);
      __skreturn = __sklib__same_point__point_2d_ref__point_2d_ref(__skparam__pt1, __skparam__pt2);
      return __skadapter__to_bool(__skreturn);
    }
    public static Quad QuadFrom(Point2D p1, Point2D p2, Point2D p3, Point2D p4)
    {
      __sklib_point_2d __skparam__p1;
      __sklib_point_2d __skparam__p2;
      __sklib_point_2d __skparam__p3;
      __sklib_point_2d __skparam__p4;
      __sklib_quad __skreturn;
      __skparam__p1 = __skadapter__to_sklib_point_2d(p1);
      __skparam__p2 = __skadapter__to_sklib_point_2d(p2);
      __skparam__p3 = __skadapter__to_sklib_point_2d(p3);
      __skparam__p4 = __skadapter__to_sklib_point_2d(p4);
      __skreturn = __sklib__quad_from__point_2d_ref__point_2d_ref__point_2d_ref__point_2d_ref(__skparam__p1, __skparam__p2, __skparam__p3, __skparam__p4);
      return __skadapter__to_quad(__skreturn);
    }
    public static Quad QuadFrom(Rectangle rect)
    {
      __sklib_rectangle __skparam__rect;
      __sklib_quad __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__quad_from__rectangle_ref(__skparam__rect);
      return __skadapter__to_quad(__skreturn);
    }
    public static Quad QuadFrom(Rectangle rect, Matrix2D transform)
    {
      __sklib_rectangle __skparam__rect;
      __sklib_matrix_2d __skparam__transform;
      __sklib_quad __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__transform = __skadapter__to_sklib_matrix_2d(transform);
      __skreturn = __sklib__quad_from__rectangle_ref__matrix_2d_ref(__skparam__rect, __skparam__transform);
      return __skadapter__to_quad(__skreturn);
    }
    public static Quad QuadFrom(double xTopLeft, double yTopLeft, double xTopRight, double yTopRight, double xBottomLeft, double yBottomLeft, double xBottomRight, double yBottomRight)
    {
      double __skparam__x_top_left;
      double __skparam__y_top_left;
      double __skparam__x_top_right;
      double __skparam__y_top_right;
      double __skparam__x_bottom_left;
      double __skparam__y_bottom_left;
      double __skparam__x_bottom_right;
      double __skparam__y_bottom_right;
      __sklib_quad __skreturn;
      __skparam__x_top_left = __skadapter__to_sklib_double(xTopLeft);
      __skparam__y_top_left = __skadapter__to_sklib_double(yTopLeft);
      __skparam__x_top_right = __skadapter__to_sklib_double(xTopRight);
      __skparam__y_top_right = __skadapter__to_sklib_double(yTopRight);
      __skparam__x_bottom_left = __skadapter__to_sklib_double(xBottomLeft);
      __skparam__y_bottom_left = __skadapter__to_sklib_double(yBottomLeft);
      __skparam__x_bottom_right = __skadapter__to_sklib_double(xBottomRight);
      __skparam__y_bottom_right = __skadapter__to_sklib_double(yBottomRight);
      __skreturn = __sklib__quad_from__double__double__double__double__double__double__double__double(__skparam__x_top_left, __skparam__y_top_left, __skparam__x_top_right, __skparam__y_top_right, __skparam__x_bottom_left, __skparam__y_bottom_left, __skparam__x_bottom_right, __skparam__y_bottom_right);
      return __skadapter__to_quad(__skreturn);
    }
    public static bool QuadsIntersect(Quad q1, Quad q2)
    {
      __sklib_quad __skparam__q1;
      __sklib_quad __skparam__q2;
      int __skreturn;
      __skparam__q1 = __skadapter__to_sklib_quad(q1);
      __skparam__q2 = __skadapter__to_sklib_quad(q2);
      __skreturn = __sklib__quads_intersect__quad_ref__quad_ref(__skparam__q1, __skparam__q2);
      return __skadapter__to_bool(__skreturn);
    }
    public static void SetQuadPoint(ref Quad q, int idx, Point2D value)
    {
      __sklib_quad __skparam__q;
      int __skparam__idx;
      __sklib_point_2d __skparam__value;
      __skparam__q = __skadapter__to_sklib_quad(q);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skparam__value = __skadapter__to_sklib_point_2d(value);
      __sklib__set_quad_point__quad_ref__int__point_2d_ref(ref __skparam__q, __skparam__idx, __skparam__value);
      q = __skadapter__to_quad(__skparam__q);
    }
    public static List<Triangle> TrianglesFrom(Quad q)
    {
      __sklib_quad __skparam__q;
      __sklib_vector_triangle __skreturn;
      __skparam__q = __skadapter__to_sklib_quad(q);
      __skreturn = __sklib__triangles_from__quad_ref(__skparam__q);
      return __skadapter__to_vector_triangle(__skreturn);
    }
    public static int Rnd(int min, int max)
    {
      int __skparam__min;
      int __skparam__max;
      int __skreturn;
      __skparam__min = __skadapter__to_sklib_int(min);
      __skparam__max = __skadapter__to_sklib_int(max);
      __skreturn = __sklib__rnd__int__int(__skparam__min, __skparam__max);
      return __skadapter__to_int(__skreturn);
    }
    public static float Rnd()
    {
      float __skreturn;
      __skreturn = __sklib__rnd();
      return __skadapter__to_float(__skreturn);
    }
    public static int Rnd(int ubound)
    {
      int __skparam__ubound;
      int __skreturn;
      __skparam__ubound = __skadapter__to_sklib_int(ubound);
      __skreturn = __sklib__rnd__int(__skparam__ubound);
      return __skadapter__to_int(__skreturn);
    }
    public static bool HasGpio()
    {
      int __skreturn;
      __skreturn = __sklib__has_gpio();
      return __skadapter__to_bool(__skreturn);
    }
    public static void RaspiCleanup()
    {
      __sklib__raspi_cleanup();
    }
    public static PinModes RaspiGetMode(Pins pin)
    {
      int __skparam__pin;
      int __skreturn;
      __skparam__pin = __skadapter__to_sklib_pins(pin);
      __skreturn = __sklib__raspi_get_mode__pins(__skparam__pin);
      return __skadapter__to_pin_modes(__skreturn);
    }
    public static void RaspiInit()
    {
      __sklib__raspi_init();
    }
    public static PinValues RaspiRead(Pins pin)
    {
      int __skparam__pin;
      int __skreturn;
      __skparam__pin = __skadapter__to_sklib_pins(pin);
      __skreturn = __sklib__raspi_read__pins(__skparam__pin);
      return __skadapter__to_pin_values(__skreturn);
    }
    public static void RaspiSetMode(Pins pin, PinModes mode)
    {
      int __skparam__pin;
      int __skparam__mode;
      __skparam__pin = __skadapter__to_sklib_pins(pin);
      __skparam__mode = __skadapter__to_sklib_pin_modes(mode);
      __sklib__raspi_set_mode__pins__pin_modes(__skparam__pin, __skparam__mode);
    }
    public static void RaspiSetPullUpDown(Pins pin, PullUpDown pud)
    {
      int __skparam__pin;
      int __skparam__pud;
      __skparam__pin = __skadapter__to_sklib_pins(pin);
      __skparam__pud = __skadapter__to_sklib_pull_up_down(pud);
      __sklib__raspi_set_pull_up_down__pins__pull_up_down(__skparam__pin, __skparam__pud);
    }
    public static void RaspiSetPwmDutycycle(Pins pin, int dutycycle)
    {
      int __skparam__pin;
      int __skparam__dutycycle;
      __skparam__pin = __skadapter__to_sklib_pins(pin);
      __skparam__dutycycle = __skadapter__to_sklib_int(dutycycle);
      __sklib__raspi_set_pwm_dutycycle__pins__int(__skparam__pin, __skparam__dutycycle);
    }
    public static void RaspiSetPwmFrequency(Pins pin, int frequency)
    {
      int __skparam__pin;
      int __skparam__frequency;
      __skparam__pin = __skadapter__to_sklib_pins(pin);
      __skparam__frequency = __skadapter__to_sklib_int(frequency);
      __sklib__raspi_set_pwm_frequency__pins__int(__skparam__pin, __skparam__frequency);
    }
    public static void RaspiSetPwmRange(Pins pin, int range)
    {
      int __skparam__pin;
      int __skparam__range;
      __skparam__pin = __skadapter__to_sklib_pins(pin);
      __skparam__range = __skadapter__to_sklib_int(range);
      __sklib__raspi_set_pwm_range__pins__int(__skparam__pin, __skparam__range);
    }
    public static void RaspiWrite(Pins pin, PinValues value)
    {
      int __skparam__pin;
      int __skparam__value;
      __skparam__pin = __skadapter__to_sklib_pins(pin);
      __skparam__value = __skadapter__to_sklib_pin_values(value);
      __sklib__raspi_write__pins__pin_values(__skparam__pin, __skparam__value);
    }
    public static void DrawQuad(Color clr, Quad q)
    {
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __sklib__draw_quad__color__quad_ref(__skparam__clr, __skparam__q);
    }
    public static void DrawQuad(Color clr, Quad q, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_quad__color__quad_ref__drawing_options_ref(__skparam__clr, __skparam__q, __skparam__opts);
    }
    public static void DrawQuadOnBitmap(Bitmap destination, Color clr, Quad q)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __sklib__draw_quad_on_bitmap__bitmap__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q);
    }
    public static void DrawQuadOnBitmap(Bitmap destination, Color clr, Quad q, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
    }
    public static void DrawQuadOnWindow(Window destination, Color clr, Quad q)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __sklib__draw_quad_on_window__window__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q);
    }
    public static void DrawQuadOnWindow(Window destination, Color clr, Quad q, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_quad_on_window__window__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
    }
    public static void DrawRectangle(Color clr, Rectangle rect)
    {
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__draw_rectangle__color__rectangle_ref(__skparam__clr, __skparam__rect);
    }
    public static void DrawRectangle(Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_rectangle__color__rectangle_ref__drawing_options_ref(__skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void DrawRectangle(Color clr, double x, double y, double width, double height)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__draw_rectangle__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void DrawRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_rectangle__color__double__double__double__double__drawing_options_ref(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static void DrawRectangleOnBitmap(Bitmap destination, Color clr, Rectangle rect)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect);
    }
    public static void DrawRectangleOnBitmap(Bitmap destination, Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void DrawRectangleOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void DrawRectangleOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static void DrawRectangleOnWindow(Window destination, Color clr, Rectangle rect)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__draw_rectangle_on_window__window__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect);
    }
    public static void DrawRectangleOnWindow(Window destination, Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void DrawRectangleOnWindow(Window destination, Color clr, double x, double y, double width, double height)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__draw_rectangle_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void DrawRectangleOnWindow(Window destination, Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_rectangle_on_window__window__color__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static void FillQuad(Color clr, Quad q)
    {
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __sklib__fill_quad__color__quad_ref(__skparam__clr, __skparam__q);
    }
    public static void FillQuad(Color clr, Quad q, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_quad__color__quad_ref__drawing_options_ref(__skparam__clr, __skparam__q, __skparam__opts);
    }
    public static void FillQuadOnBitmap(Bitmap destination, Color clr, Quad q)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __sklib__fill_quad_on_bitmap__bitmap__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q);
    }
    public static void FillQuadOnBitmap(Bitmap destination, Color clr, Quad q, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_quad_on_bitmap__bitmap__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
    }
    public static void FillQuadOnWindow(Window destination, Color clr, Quad q)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __sklib__fill_quad_on_window__window__color__quad_ref(__skparam__destination, __skparam__clr, __skparam__q);
    }
    public static void FillQuadOnWindow(Window destination, Color clr, Quad q, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_quad __skparam__q;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__q = __skadapter__to_sklib_quad(q);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_quad_on_window__window__color__quad_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__q, __skparam__opts);
    }
    public static void FillRectangle(Color clr, Rectangle rect)
    {
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__fill_rectangle__color__rectangle_ref(__skparam__clr, __skparam__rect);
    }
    public static void FillRectangle(Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_rectangle__color__rectangle_ref__drawing_options_ref(__skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void FillRectangle(Color clr, double x, double y, double width, double height)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__fill_rectangle__color__double__double__double__double(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void FillRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_rectangle__color__double__double__double__double__drawing_options_ref(__skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static void FillRectangleOnBitmap(Bitmap destination, Color clr, Rectangle rect)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect);
    }
    public static void FillRectangleOnBitmap(Bitmap destination, Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_rectangle_on_bitmap__bitmap__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void FillRectangleOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void FillRectangleOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_rectangle_on_bitmap__bitmap__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static void FillRectangleOnWindow(Window destination, Color clr, Rectangle rect)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__fill_rectangle_on_window__window__color__rectangle_ref(__skparam__destination, __skparam__clr, __skparam__rect);
    }
    public static void FillRectangleOnWindow(Window destination, Color clr, Rectangle rect, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_rectangle __skparam__rect;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_rectangle_on_window__window__color__rectangle_ref__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__rect, __skparam__opts);
    }
    public static void FillRectangleOnWindow(Window destination, Color clr, double x, double y, double width, double height)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __sklib__fill_rectangle_on_window__window__color__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height);
    }
    public static void FillRectangleOnWindow(Window destination, Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_rectangle_on_window__window__color__double__double__double__double__drawing_options_ref(__skparam__destination, __skparam__clr, __skparam__x, __skparam__y, __skparam__width, __skparam__height, __skparam__opts);
    }
    public static Rectangle InsetRectangle(Rectangle rect, float insetAmount)
    {
      __sklib_rectangle __skparam__rect;
      float __skparam__inset_amount;
      __sklib_rectangle __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__inset_amount = __skadapter__to_sklib_float(insetAmount);
      __skreturn = __sklib__inset_rectangle__rectangle_ref__float(__skparam__rect, __skparam__inset_amount);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle Intersection(Rectangle rect1, Rectangle rect2)
    {
      __sklib_rectangle __skparam__rect1;
      __sklib_rectangle __skparam__rect2;
      __sklib_rectangle __skreturn;
      __skparam__rect1 = __skadapter__to_sklib_rectangle(rect1);
      __skparam__rect2 = __skadapter__to_sklib_rectangle(rect2);
      __skreturn = __sklib__intersection__rectangle_ref__rectangle_ref(__skparam__rect1, __skparam__rect2);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle RectangleAround(Circle c)
    {
      __sklib_circle __skparam__c;
      __sklib_rectangle __skreturn;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skreturn = __sklib__rectangle_around__circle_ref(__skparam__c);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle RectangleAround(Line l)
    {
      __sklib_line __skparam__l;
      __sklib_rectangle __skreturn;
      __skparam__l = __skadapter__to_sklib_line(l);
      __skreturn = __sklib__rectangle_around__line_ref(__skparam__l);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle RectangleAround(Quad q)
    {
      __sklib_quad __skparam__q;
      __sklib_rectangle __skreturn;
      __skparam__q = __skadapter__to_sklib_quad(q);
      __skreturn = __sklib__rectangle_around__quad_ref(__skparam__q);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle RectangleAround(Triangle t)
    {
      __sklib_triangle __skparam__t;
      __sklib_rectangle __skreturn;
      __skparam__t = __skadapter__to_sklib_triangle(t);
      __skreturn = __sklib__rectangle_around__triangle_ref(__skparam__t);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static float RectangleBottom(Rectangle rect)
    {
      __sklib_rectangle __skparam__rect;
      float __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__rectangle_bottom__rectangle_ref(__skparam__rect);
      return __skadapter__to_float(__skreturn);
    }
    public static Point2D RectangleCenter(Rectangle rect)
    {
      __sklib_rectangle __skparam__rect;
      __sklib_point_2d __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__rectangle_center__rectangle_ref(__skparam__rect);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Rectangle RectangleFrom(Point2D pt, double width, double height)
    {
      __sklib_point_2d __skparam__pt;
      double __skparam__width;
      double __skparam__height;
      __sklib_rectangle __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skreturn = __sklib__rectangle_from__point_2d__double__double(__skparam__pt, __skparam__width, __skparam__height);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle RectangleFrom(Point2D pt1, Point2D pt2)
    {
      __sklib_point_2d __skparam__pt1;
      __sklib_point_2d __skparam__pt2;
      __sklib_rectangle __skreturn;
      __skparam__pt1 = __skadapter__to_sklib_point_2d(pt1);
      __skparam__pt2 = __skadapter__to_sklib_point_2d(pt2);
      __skreturn = __sklib__rectangle_from__point_2d__point_2d(__skparam__pt1, __skparam__pt2);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle RectangleFrom(double x, double y, double width, double height)
    {
      double __skparam__x;
      double __skparam__y;
      double __skparam__width;
      double __skparam__height;
      __sklib_rectangle __skreturn;
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__width = __skadapter__to_sklib_double(width);
      __skparam__height = __skadapter__to_sklib_double(height);
      __skreturn = __sklib__rectangle_from__double__double__double__double(__skparam__x, __skparam__y, __skparam__width, __skparam__height);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static float RectangleLeft(Rectangle rect)
    {
      __sklib_rectangle __skparam__rect;
      float __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__rectangle_left__rectangle_ref(__skparam__rect);
      return __skadapter__to_float(__skreturn);
    }
    public static Rectangle RectangleOffsetBy(Rectangle rect, Vector2D offset)
    {
      __sklib_rectangle __skparam__rect;
      __sklib_vector_2d __skparam__offset;
      __sklib_rectangle __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__offset = __skadapter__to_sklib_vector_2d(offset);
      __skreturn = __sklib__rectangle_offset_by__rectangle_ref__vector_2d_ref(__skparam__rect, __skparam__offset);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static float RectangleRight(Rectangle rect)
    {
      __sklib_rectangle __skparam__rect;
      float __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__rectangle_right__rectangle_ref(__skparam__rect);
      return __skadapter__to_float(__skreturn);
    }
    public static string RectangleToString(Rectangle rect)
    {
      __sklib_rectangle __skparam__rect;
      __sklib_string __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__rectangle_to_string__rectangle_ref(__skparam__rect);
      return __skadapter__to_string(__skreturn);
    }
    public static float RectangleTop(Rectangle rect)
    {
      __sklib_rectangle __skparam__rect;
      float __skreturn;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__rectangle_top__rectangle_ref(__skparam__rect);
      return __skadapter__to_float(__skreturn);
    }
    public static bool RectanglesIntersect(Rectangle rect1, Rectangle rect2)
    {
      __sklib_rectangle __skparam__rect1;
      __sklib_rectangle __skparam__rect2;
      int __skreturn;
      __skparam__rect1 = __skadapter__to_sklib_rectangle(rect1);
      __skparam__rect2 = __skadapter__to_sklib_rectangle(rect2);
      __skreturn = __sklib__rectangles_intersect__rectangle_ref__rectangle_ref(__skparam__rect1, __skparam__rect2);
      return __skadapter__to_bool(__skreturn);
    }
    public static void DeregisterFreeNotifier(FreeNotifier handler)
    {
      FreeNotifier __skparam__handler;
      __skparam__handler = __skadapter__to_sklib_free_notifier(handler);
      __sklib__deregister_free_notifier__free_notifier_ptr(__skparam__handler);
    }
    public static string PathToResource(string filename, ResourceKind kind)
    {
      __sklib_string __skparam__filename;
      int __skparam__kind;
      __sklib_string __skreturn;
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __skparam__kind = __skadapter__to_sklib_resource_kind(kind);
      __skreturn = __sklib__path_to_resource__string_ref__resource_kind(__skparam__filename, __skparam__kind);
    __skadapter__free__sklib_string(ref __skparam__filename);
      return __skadapter__to_string(__skreturn);
    }
    public static string PathToResources()
    {
      __sklib_string __skreturn;
      __skreturn = __sklib__path_to_resources();
      return __skadapter__to_string(__skreturn);
    }
    public static string PathToResources(ResourceKind kind)
    {
      int __skparam__kind;
      __sklib_string __skreturn;
      __skparam__kind = __skadapter__to_sklib_resource_kind(kind);
      __skreturn = __sklib__path_to_resources__resource_kind(__skparam__kind);
      return __skadapter__to_string(__skreturn);
    }
    public static void RegisterFreeNotifier(FreeNotifier fn)
    {
      FreeNotifier __skparam__fn;
      __skparam__fn = __skadapter__to_sklib_free_notifier(fn);
      __sklib__register_free_notifier__free_notifier_ptr(__skparam__fn);
    }
    public static void SetResourcesPath(string path)
    {
      __sklib_string __skparam__path;
      __skparam__path = __skadapter__to_sklib_string(path);
      __sklib__set_resources_path__string_ref(__skparam__path);
    __skadapter__free__sklib_string(ref __skparam__path);
    }
    public static void FadeAllSoundEffectsOut(int ms)
    {
      int __skparam__ms;
      __skparam__ms = __skadapter__to_sklib_int(ms);
      __sklib__fade_all_sound_effects_out__int(__skparam__ms);
    }
    public static void FadeSoundEffectOut(SoundEffect effect, int ms)
    {
      __sklib_ptr __skparam__effect;
      int __skparam__ms;
      __skparam__effect = __skadapter__to_sklib_sound_effect(effect);
      __skparam__ms = __skadapter__to_sklib_int(ms);
      __sklib__fade_sound_effect_out__sound_effect__int(__skparam__effect, __skparam__ms);
    }
    public static void FreeAllSoundEffects()
    {
      __sklib__free_all_sound_effects();
    }
    public static void FreeSoundEffect(SoundEffect effect)
    {
      __sklib_ptr __skparam__effect;
      __skparam__effect = __skadapter__to_sklib_sound_effect(effect);
      __sklib__free_sound_effect__sound_effect(__skparam__effect);
    }
    public static bool HasSoundEffect(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_sound_effect__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static SoundEffect LoadSoundEffect(string name, string filename)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__filename;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __skreturn = __sklib__load_sound_effect__string_ref__string_ref(__skparam__name, __skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__filename);
      return __skadapter__to_sound_effect(__skreturn);
    }
    public static void PlaySoundEffect(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__play_sound_effect__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void PlaySoundEffect(string name, double volume)
    {
      __sklib_string __skparam__name;
      double __skparam__volume;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__volume = __skadapter__to_sklib_double(volume);
      __sklib__play_sound_effect__string_ref__double(__skparam__name, __skparam__volume);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void PlaySoundEffect(string name, int times)
    {
      __sklib_string __skparam__name;
      int __skparam__times;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__times = __skadapter__to_sklib_int(times);
      __sklib__play_sound_effect__string_ref__int(__skparam__name, __skparam__times);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void PlaySoundEffect(string name, int times, double volume)
    {
      __sklib_string __skparam__name;
      int __skparam__times;
      double __skparam__volume;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__times = __skadapter__to_sklib_int(times);
      __skparam__volume = __skadapter__to_sklib_double(volume);
      __sklib__play_sound_effect__string_ref__int__double(__skparam__name, __skparam__times, __skparam__volume);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void PlaySoundEffect(SoundEffect effect)
    {
      __sklib_ptr __skparam__effect;
      __skparam__effect = __skadapter__to_sklib_sound_effect(effect);
      __sklib__play_sound_effect__sound_effect(__skparam__effect);
    }
    public static void PlaySoundEffect(SoundEffect effect, double volume)
    {
      __sklib_ptr __skparam__effect;
      double __skparam__volume;
      __skparam__effect = __skadapter__to_sklib_sound_effect(effect);
      __skparam__volume = __skadapter__to_sklib_double(volume);
      __sklib__play_sound_effect__sound_effect__double(__skparam__effect, __skparam__volume);
    }
    public static void PlaySoundEffect(SoundEffect effect, int times)
    {
      __sklib_ptr __skparam__effect;
      int __skparam__times;
      __skparam__effect = __skadapter__to_sklib_sound_effect(effect);
      __skparam__times = __skadapter__to_sklib_int(times);
      __sklib__play_sound_effect__sound_effect__int(__skparam__effect, __skparam__times);
    }
    public static void PlaySoundEffect(SoundEffect effect, int times, double volume)
    {
      __sklib_ptr __skparam__effect;
      int __skparam__times;
      double __skparam__volume;
      __skparam__effect = __skadapter__to_sklib_sound_effect(effect);
      __skparam__times = __skadapter__to_sklib_int(times);
      __skparam__volume = __skadapter__to_sklib_double(volume);
      __sklib__play_sound_effect__sound_effect__int__double(__skparam__effect, __skparam__times, __skparam__volume);
    }
    public static string SoundEffectFilename(SoundEffect effect)
    {
      __sklib_ptr __skparam__effect;
      __sklib_string __skreturn;
      __skparam__effect = __skadapter__to_sklib_sound_effect(effect);
      __skreturn = __sklib__sound_effect_filename__sound_effect(__skparam__effect);
      return __skadapter__to_string(__skreturn);
    }
    public static string SoundEffectName(SoundEffect effect)
    {
      __sklib_ptr __skparam__effect;
      __sklib_string __skreturn;
      __skparam__effect = __skadapter__to_sklib_sound_effect(effect);
      __skreturn = __sklib__sound_effect_name__sound_effect(__skparam__effect);
      return __skadapter__to_string(__skreturn);
    }
    public static SoundEffect SoundEffectNamed(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sound_effect_named__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_sound_effect(__skreturn);
    }
    public static bool SoundEffectPlaying(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sound_effect_playing__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool SoundEffectPlaying(SoundEffect effect)
    {
      __sklib_ptr __skparam__effect;
      int __skreturn;
      __skparam__effect = __skadapter__to_sklib_sound_effect(effect);
      __skreturn = __sklib__sound_effect_playing__sound_effect(__skparam__effect);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool SoundEffectValid(SoundEffect effect)
    {
      __sklib_ptr __skparam__effect;
      int __skreturn;
      __skparam__effect = __skadapter__to_sklib_sound_effect(effect);
      __skreturn = __sklib__sound_effect_valid__sound_effect(__skparam__effect);
      return __skadapter__to_bool(__skreturn);
    }
    public static void StopSoundEffect(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__stop_sound_effect__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void StopSoundEffect(SoundEffect effect)
    {
      __sklib_ptr __skparam__effect;
      __skparam__effect = __skadapter__to_sklib_sound_effect(effect);
      __sklib__stop_sound_effect__sound_effect(__skparam__effect);
    }
    public static void CallForAllSprites(SpriteFloatFunction fn, float val)
    {
      SpriteFloatFunction __skparam__fn;
      float __skparam__val;
      __skparam__fn = __skadapter__to_sklib_sprite_float_function(fn);
      __skparam__val = __skadapter__to_sklib_float(val);
      __sklib__call_for_all_sprites__sprite_float_function_ptr__float(__skparam__fn, __skparam__val);
    }
    public static void CallForAllSprites(SpriteFunction fn)
    {
      SpriteFunction __skparam__fn;
      __skparam__fn = __skadapter__to_sklib_sprite_function(fn);
      __sklib__call_for_all_sprites__sprite_function_ptr(__skparam__fn);
    }
    public static void CallOnSpriteEvent(SpriteEventHandler handler)
    {
      SpriteEventHandler __skparam__handler;
      __skparam__handler = __skadapter__to_sklib_sprite_event_handler(handler);
      __sklib__call_on_sprite_event__sprite_event_handler_ptr(__skparam__handler);
    }
    public static Point2D CenterPoint(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_point_2d __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__center_point__sprite(__skparam__s);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Sprite CreateSprite(Bitmap layer)
    {
      __sklib_ptr __skparam__layer;
      __sklib_ptr __skreturn;
      __skparam__layer = __skadapter__to_sklib_bitmap(layer);
      __skreturn = __sklib__create_sprite__bitmap(__skparam__layer);
      return __skadapter__to_sprite(__skreturn);
    }
    public static Sprite CreateSprite(Bitmap layer, AnimationScript ani)
    {
      __sklib_ptr __skparam__layer;
      __sklib_ptr __skparam__ani;
      __sklib_ptr __skreturn;
      __skparam__layer = __skadapter__to_sklib_bitmap(layer);
      __skparam__ani = __skadapter__to_sklib_animation_script(ani);
      __skreturn = __sklib__create_sprite__bitmap__animation_script(__skparam__layer, __skparam__ani);
      return __skadapter__to_sprite(__skreturn);
    }
    public static Sprite CreateSprite(string bitmapName)
    {
      __sklib_string __skparam__bitmap_name;
      __sklib_ptr __skreturn;
      __skparam__bitmap_name = __skadapter__to_sklib_string(bitmapName);
      __skreturn = __sklib__create_sprite__string_ref(__skparam__bitmap_name);
    __skadapter__free__sklib_string(ref __skparam__bitmap_name);
      return __skadapter__to_sprite(__skreturn);
    }
    public static Sprite CreateSprite(string name, Bitmap layer)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skparam__layer;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__layer = __skadapter__to_sklib_bitmap(layer);
      __skreturn = __sklib__create_sprite__string_ref__bitmap(__skparam__name, __skparam__layer);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_sprite(__skreturn);
    }
    public static Sprite CreateSprite(string name, Bitmap layer, AnimationScript ani)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skparam__layer;
      __sklib_ptr __skparam__ani;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__layer = __skadapter__to_sklib_bitmap(layer);
      __skparam__ani = __skadapter__to_sklib_animation_script(ani);
      __skreturn = __sklib__create_sprite__string_ref__bitmap__animation_script(__skparam__name, __skparam__layer, __skparam__ani);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_sprite(__skreturn);
    }
    public static Sprite CreateSprite(string bitmapName, string animationName)
    {
      __sklib_string __skparam__bitmap_name;
      __sklib_string __skparam__animation_name;
      __sklib_ptr __skreturn;
      __skparam__bitmap_name = __skadapter__to_sklib_string(bitmapName);
      __skparam__animation_name = __skadapter__to_sklib_string(animationName);
      __skreturn = __sklib__create_sprite__string_ref__string_ref(__skparam__bitmap_name, __skparam__animation_name);
    __skadapter__free__sklib_string(ref __skparam__bitmap_name);
    __skadapter__free__sklib_string(ref __skparam__animation_name);
      return __skadapter__to_sprite(__skreturn);
    }
    public static void CreateSpritePack(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__create_sprite_pack__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static string CurrentSpritePack()
    {
      __sklib_string __skreturn;
      __skreturn = __sklib__current_sprite_pack();
      return __skadapter__to_string(__skreturn);
    }
    public static void DrawAllSprites()
    {
      __sklib__draw_all_sprites();
    }
    public static void DrawSprite(Sprite s, Vector2D offset)
    {
      __sklib_ptr __skparam__s;
      __sklib_vector_2d __skparam__offset;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__offset = __skadapter__to_sklib_vector_2d(offset);
      __sklib__draw_sprite__sprite__vector_2d_ref(__skparam__s, __skparam__offset);
    }
    public static void DrawSprite(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __sklib__draw_sprite__sprite(__skparam__s);
    }
    public static void DrawSprite(Sprite s, double xOffset, double yOffset)
    {
      __sklib_ptr __skparam__s;
      double __skparam__x_offset;
      double __skparam__y_offset;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__x_offset = __skadapter__to_sklib_double(xOffset);
      __skparam__y_offset = __skadapter__to_sklib_double(yOffset);
      __sklib__draw_sprite__sprite__double__double(__skparam__s, __skparam__x_offset, __skparam__y_offset);
    }
    public static void FreeAllSprites()
    {
      __sklib__free_all_sprites();
    }
    public static void FreeSprite(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __sklib__free_sprite__sprite(__skparam__s);
    }
    public static void FreeSpritePack(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__free_sprite_pack__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static bool HasSprite(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_sprite__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool HasSpritePack(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_sprite_pack__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static void MoveSprite(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __sklib__move_sprite__sprite(__skparam__s);
    }
    public static void MoveSprite(Sprite s, Vector2D distance)
    {
      __sklib_ptr __skparam__s;
      __sklib_vector_2d __skparam__distance;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__distance = __skadapter__to_sklib_vector_2d(distance);
      __sklib__move_sprite__sprite__vector_2d_ref(__skparam__s, __skparam__distance);
    }
    public static void MoveSprite(Sprite s, Vector2D distance, float pct)
    {
      __sklib_ptr __skparam__s;
      __sklib_vector_2d __skparam__distance;
      float __skparam__pct;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__distance = __skadapter__to_sklib_vector_2d(distance);
      __skparam__pct = __skadapter__to_sklib_float(pct);
      __sklib__move_sprite__sprite__vector_2d_ref__float(__skparam__s, __skparam__distance, __skparam__pct);
    }
    public static void MoveSprite(Sprite s, float pct)
    {
      __sklib_ptr __skparam__s;
      float __skparam__pct;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__pct = __skadapter__to_sklib_float(pct);
      __sklib__move_sprite__sprite__float(__skparam__s, __skparam__pct);
    }
    public static void MoveSpriteTo(Sprite s, double x, double y)
    {
      __sklib_ptr __skparam__s;
      double __skparam__x;
      double __skparam__y;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__move_sprite_to__sprite__double__double(__skparam__s, __skparam__x, __skparam__y);
    }
    public static void SelectSpritePack(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__select_sprite_pack__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static int SpriteAddLayer(Sprite s, Bitmap newLayer, string layerName)
    {
      __sklib_ptr __skparam__s;
      __sklib_ptr __skparam__new_layer;
      __sklib_string __skparam__layer_name;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__new_layer = __skadapter__to_sklib_bitmap(newLayer);
      __skparam__layer_name = __skadapter__to_sklib_string(layerName);
      __skreturn = __sklib__sprite_add_layer__sprite__bitmap__string_ref(__skparam__s, __skparam__new_layer, __skparam__layer_name);
    __skadapter__free__sklib_string(ref __skparam__layer_name);
      return __skadapter__to_int(__skreturn);
    }
    public static void SpriteAddToVelocity(Sprite s, Vector2D value)
    {
      __sklib_ptr __skparam__s;
      __sklib_vector_2d __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_vector_2d(value);
      __sklib__sprite_add_to_velocity__sprite__vector_2d_ref(__skparam__s, __skparam__value);
    }
    public static void SpriteAddValue(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__sprite_add_value__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void SpriteAddValue(Sprite s, string name, float initVal)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      float __skparam__init_val;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__init_val = __skadapter__to_sklib_float(initVal);
      __sklib__sprite_add_value__sprite__string_ref__float(__skparam__s, __skparam__name, __skparam__init_val);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static Point2D SpriteAnchorPoint(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_point_2d __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_anchor_point__sprite(__skparam__s);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Point2D SpriteAnchorPosition(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_point_2d __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_anchor_position__sprite(__skparam__s);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static bool SpriteAnimationHasEnded(Sprite s)
    {
      __sklib_ptr __skparam__s;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_animation_has_ended__sprite(__skparam__s);
      return __skadapter__to_bool(__skreturn);
    }
    public static string SpriteAnimationName(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_animation_name__sprite(__skparam__s);
      return __skadapter__to_string(__skreturn);
    }
    public static bool SpriteAt(Sprite s, Point2D pt)
    {
      __sklib_ptr __skparam__s;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__sprite_at__sprite__point_2d_ref(__skparam__s, __skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static void SpriteBringLayerForward(Sprite s, int visibleLayer)
    {
      __sklib_ptr __skparam__s;
      int __skparam__visible_layer;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__visible_layer = __skadapter__to_sklib_int(visibleLayer);
      __sklib__sprite_bring_layer_forward__sprite__int(__skparam__s, __skparam__visible_layer);
    }
    public static void SpriteBringLayerToFront(Sprite s, int visibleLayer)
    {
      __sklib_ptr __skparam__s;
      int __skparam__visible_layer;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__visible_layer = __skadapter__to_sklib_int(visibleLayer);
      __sklib__sprite_bring_layer_to_front__sprite__int(__skparam__s, __skparam__visible_layer);
    }
    public static void SpriteCallOnEvent(Sprite s, SpriteEventHandler handler)
    {
      __sklib_ptr __skparam__s;
      SpriteEventHandler __skparam__handler;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__handler = __skadapter__to_sklib_sprite_event_handler(handler);
      __sklib__sprite_call_on_event__sprite__sprite_event_handler_ptr(__skparam__s, __skparam__handler);
    }
    public static Circle SpriteCircle(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_circle __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_circle__sprite(__skparam__s);
      return __skadapter__to_circle(__skreturn);
    }
    public static Bitmap SpriteCollisionBitmap(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_ptr __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_collision_bitmap__sprite(__skparam__s);
      return __skadapter__to_bitmap(__skreturn);
    }
    public static Circle SpriteCollisionCircle(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_circle __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_collision_circle__sprite(__skparam__s);
      return __skadapter__to_circle(__skreturn);
    }
    public static CollisionTestKind SpriteCollisionKind(Sprite s)
    {
      __sklib_ptr __skparam__s;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_collision_kind__sprite(__skparam__s);
      return __skadapter__to_collision_test_kind(__skreturn);
    }
    public static Rectangle SpriteCollisionRectangle(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_rectangle __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_collision_rectangle__sprite(__skparam__s);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static int SpriteCurrentCell(Sprite s)
    {
      __sklib_ptr __skparam__s;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_current_cell__sprite(__skparam__s);
      return __skadapter__to_int(__skreturn);
    }
    public static Rectangle SpriteCurrentCellRectangle(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_rectangle __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_current_cell_rectangle__sprite(__skparam__s);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static float SpriteDx(Sprite s)
    {
      __sklib_ptr __skparam__s;
      float __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_dx__sprite(__skparam__s);
      return __skadapter__to_float(__skreturn);
    }
    public static float SpriteDy(Sprite s)
    {
      __sklib_ptr __skparam__s;
      float __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_dy__sprite(__skparam__s);
      return __skadapter__to_float(__skreturn);
    }
    public static bool SpriteHasValue(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_has_value__sprite__string(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static float SpriteHeading(Sprite s)
    {
      __sklib_ptr __skparam__s;
      float __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_heading__sprite(__skparam__s);
      return __skadapter__to_float(__skreturn);
    }
    public static int SpriteHeight(Sprite s)
    {
      __sklib_ptr __skparam__s;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_height__sprite(__skparam__s);
      return __skadapter__to_int(__skreturn);
    }
    public static void SpriteHideLayer(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__sprite_hide_layer__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void SpriteHideLayer(Sprite s, int id)
    {
      __sklib_ptr __skparam__s;
      int __skparam__id;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__id = __skadapter__to_sklib_int(id);
      __sklib__sprite_hide_layer__sprite__int(__skparam__s, __skparam__id);
    }
    public static Bitmap SpriteLayer(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_layer__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bitmap(__skreturn);
    }
    public static Bitmap SpriteLayer(Sprite s, int idx)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      __sklib_ptr __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skreturn = __sklib__sprite_layer__sprite__int(__skparam__s, __skparam__idx);
      return __skadapter__to_bitmap(__skreturn);
    }
    public static Circle SpriteLayerCircle(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      __sklib_circle __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_layer_circle__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_circle(__skreturn);
    }
    public static Circle SpriteLayerCircle(Sprite s, int idx)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      __sklib_circle __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skreturn = __sklib__sprite_layer_circle__sprite__int(__skparam__s, __skparam__idx);
      return __skadapter__to_circle(__skreturn);
    }
    public static int SpriteLayerCount(Sprite s)
    {
      __sklib_ptr __skparam__s;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_layer_count__sprite(__skparam__s);
      return __skadapter__to_int(__skreturn);
    }
    public static int SpriteLayerHeight(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_layer_height__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static int SpriteLayerHeight(Sprite s, int idx)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skreturn = __sklib__sprite_layer_height__sprite__int(__skparam__s, __skparam__idx);
      return __skadapter__to_int(__skreturn);
    }
    public static int SpriteLayerIndex(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_layer_index__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static string SpriteLayerName(Sprite s, int idx)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      __sklib_string __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skreturn = __sklib__sprite_layer_name__sprite__int(__skparam__s, __skparam__idx);
      return __skadapter__to_string(__skreturn);
    }
    public static Vector2D SpriteLayerOffset(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      __sklib_vector_2d __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_layer_offset__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D SpriteLayerOffset(Sprite s, int idx)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      __sklib_vector_2d __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skreturn = __sklib__sprite_layer_offset__sprite__int(__skparam__s, __skparam__idx);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Rectangle SpriteLayerRectangle(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      __sklib_rectangle __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_layer_rectangle__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static Rectangle SpriteLayerRectangle(Sprite s, int idx)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      __sklib_rectangle __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skreturn = __sklib__sprite_layer_rectangle__sprite__int(__skparam__s, __skparam__idx);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static int SpriteLayerWidth(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_layer_width__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static int SpriteLayerWidth(Sprite s, int idx)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skreturn = __sklib__sprite_layer_width__sprite__int(__skparam__s, __skparam__idx);
      return __skadapter__to_int(__skreturn);
    }
    public static Matrix2D SpriteLocationMatrix(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_matrix_2d __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_location_matrix__sprite(__skparam__s);
      return __skadapter__to_matrix_2d(__skreturn);
    }
    public static float SpriteMass(Sprite s)
    {
      __sklib_ptr __skparam__s;
      float __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_mass__sprite(__skparam__s);
      return __skadapter__to_float(__skreturn);
    }
    public static bool SpriteMoveFromAnchorPoint(Sprite s)
    {
      __sklib_ptr __skparam__s;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_move_from_anchor_point__sprite(__skparam__s);
      return __skadapter__to_bool(__skreturn);
    }
    public static void SpriteMoveTo(Sprite s, Point2D pt, float takingSeconds)
    {
      __sklib_ptr __skparam__s;
      __sklib_point_2d __skparam__pt;
      float __skparam__taking_seconds;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__taking_seconds = __skadapter__to_sklib_float(takingSeconds);
      __sklib__sprite_move_to__sprite__point_2d_ref__float(__skparam__s, __skparam__pt, __skparam__taking_seconds);
    }
    public static string SpriteName(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_name__sprite(__skparam__s);
      return __skadapter__to_string(__skreturn);
    }
    public static Sprite SpriteNamed(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_named__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_sprite(__skreturn);
    }
    public static bool SpriteOffscreen(Sprite s)
    {
      __sklib_ptr __skparam__s;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_offscreen__sprite(__skparam__s);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool SpriteOnScreenAt(Sprite s, Point2D pt)
    {
      __sklib_ptr __skparam__s;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__sprite_on_screen_at__sprite__point_2d_ref(__skparam__s, __skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool SpriteOnScreenAt(Sprite s, double x, double y)
    {
      __sklib_ptr __skparam__s;
      double __skparam__x;
      double __skparam__y;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__sprite_on_screen_at__sprite__double__double(__skparam__s, __skparam__x, __skparam__y);
      return __skadapter__to_bool(__skreturn);
    }
    public static Point2D SpritePosition(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_point_2d __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_position__sprite(__skparam__s);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static void SpriteReplayAnimation(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __sklib__sprite_replay_animation__sprite(__skparam__s);
    }
    public static void SpriteReplayAnimation(Sprite s, bool withSound)
    {
      __sklib_ptr __skparam__s;
      int __skparam__with_sound;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__sprite_replay_animation__sprite__bool(__skparam__s, __skparam__with_sound);
    }
    public static float SpriteRotation(Sprite s)
    {
      __sklib_ptr __skparam__s;
      float __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_rotation__sprite(__skparam__s);
      return __skadapter__to_float(__skreturn);
    }
    public static float SpriteScale(Sprite s)
    {
      __sklib_ptr __skparam__s;
      float __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_scale__sprite(__skparam__s);
      return __skadapter__to_float(__skreturn);
    }
    public static Rectangle SpriteScreenRectangle(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_rectangle __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_screen_rectangle__sprite(__skparam__s);
      return __skadapter__to_rectangle(__skreturn);
    }
    public static void SpriteSendLayerBackward(Sprite s, int visibleLayer)
    {
      __sklib_ptr __skparam__s;
      int __skparam__visible_layer;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__visible_layer = __skadapter__to_sklib_int(visibleLayer);
      __sklib__sprite_send_layer_backward__sprite__int(__skparam__s, __skparam__visible_layer);
    }
    public static void SpriteSendLayerToBack(Sprite s, int visibleLayer)
    {
      __sklib_ptr __skparam__s;
      int __skparam__visible_layer;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__visible_layer = __skadapter__to_sklib_int(visibleLayer);
      __sklib__sprite_send_layer_to_back__sprite__int(__skparam__s, __skparam__visible_layer);
    }
    public static void SpriteSetAnchorPoint(Sprite s, Point2D pt)
    {
      __sklib_ptr __skparam__s;
      __sklib_point_2d __skparam__pt;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __sklib__sprite_set_anchor_point__sprite__point_2d_ref(__skparam__s, __skparam__pt);
    }
    public static void SpriteSetCollisionBitmap(Sprite s, Bitmap bmp)
    {
      __sklib_ptr __skparam__s;
      __sklib_ptr __skparam__bmp;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __sklib__sprite_set_collision_bitmap__sprite__bitmap(__skparam__s, __skparam__bmp);
    }
    public static void SpriteSetCollisionKind(Sprite s, CollisionTestKind value)
    {
      __sklib_ptr __skparam__s;
      int __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_collision_test_kind(value);
      __sklib__sprite_set_collision_kind__sprite__collision_test_kind(__skparam__s, __skparam__value);
    }
    public static void SpriteSetDx(Sprite s, float value)
    {
      __sklib_ptr __skparam__s;
      float __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_float(value);
      __sklib__sprite_set_dx__sprite__float(__skparam__s, __skparam__value);
    }
    public static void SpriteSetDy(Sprite s, float value)
    {
      __sklib_ptr __skparam__s;
      float __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_float(value);
      __sklib__sprite_set_dy__sprite__float(__skparam__s, __skparam__value);
    }
    public static void SpriteSetHeading(Sprite s, float value)
    {
      __sklib_ptr __skparam__s;
      float __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_float(value);
      __sklib__sprite_set_heading__sprite__float(__skparam__s, __skparam__value);
    }
    public static void SpriteSetLayerOffset(Sprite s, string name, Vector2D value)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      __sklib_vector_2d __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__value = __skadapter__to_sklib_vector_2d(value);
      __sklib__sprite_set_layer_offset__sprite__string_ref__vector_2d_ref(__skparam__s, __skparam__name, __skparam__value);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void SpriteSetLayerOffset(Sprite s, int idx, Vector2D value)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      __sklib_vector_2d __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skparam__value = __skadapter__to_sklib_vector_2d(value);
      __sklib__sprite_set_layer_offset__sprite__int__vector_2d_ref(__skparam__s, __skparam__idx, __skparam__value);
    }
    public static void SpriteSetMass(Sprite s, float value)
    {
      __sklib_ptr __skparam__s;
      float __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_float(value);
      __sklib__sprite_set_mass__sprite__float(__skparam__s, __skparam__value);
    }
    public static void SpriteSetMoveFromAnchorPoint(Sprite s, bool value)
    {
      __sklib_ptr __skparam__s;
      int __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_bool(value);
      __sklib__sprite_set_move_from_anchor_point__sprite__bool(__skparam__s, __skparam__value);
    }
    public static void SpriteSetPosition(Sprite s, Point2D value)
    {
      __sklib_ptr __skparam__s;
      __sklib_point_2d __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_point_2d(value);
      __sklib__sprite_set_position__sprite__point_2d_ref(__skparam__s, __skparam__value);
    }
    public static void SpriteSetRotation(Sprite s, float value)
    {
      __sklib_ptr __skparam__s;
      float __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_float(value);
      __sklib__sprite_set_rotation__sprite__float(__skparam__s, __skparam__value);
    }
    public static void SpriteSetScale(Sprite s, float value)
    {
      __sklib_ptr __skparam__s;
      float __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_float(value);
      __sklib__sprite_set_scale__sprite__float(__skparam__s, __skparam__value);
    }
    public static void SpriteSetSpeed(Sprite s, float value)
    {
      __sklib_ptr __skparam__s;
      float __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_float(value);
      __sklib__sprite_set_speed__sprite__float(__skparam__s, __skparam__value);
    }
    public static void SpriteSetValue(Sprite s, string name, float val)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      float __skparam__val;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__val = __skadapter__to_sklib_float(val);
      __sklib__sprite_set_value__sprite__string_ref__float(__skparam__s, __skparam__name, __skparam__val);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void SpriteSetVelocity(Sprite s, Vector2D value)
    {
      __sklib_ptr __skparam__s;
      __sklib_vector_2d __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_vector_2d(value);
      __sklib__sprite_set_velocity__sprite__vector_2d_ref(__skparam__s, __skparam__value);
    }
    public static void SpriteSetX(Sprite s, float value)
    {
      __sklib_ptr __skparam__s;
      float __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_float(value);
      __sklib__sprite_set_x__sprite__float(__skparam__s, __skparam__value);
    }
    public static void SpriteSetY(Sprite s, float value)
    {
      __sklib_ptr __skparam__s;
      float __skparam__value;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__value = __skadapter__to_sklib_float(value);
      __sklib__sprite_set_y__sprite__float(__skparam__s, __skparam__value);
    }
    public static int SpriteShowLayer(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_show_layer__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static int SpriteShowLayer(Sprite s, int id)
    {
      __sklib_ptr __skparam__s;
      int __skparam__id;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__id = __skadapter__to_sklib_int(id);
      __skreturn = __sklib__sprite_show_layer__sprite__int(__skparam__s, __skparam__id);
      return __skadapter__to_int(__skreturn);
    }
    public static float SpriteSpeed(Sprite s)
    {
      __sklib_ptr __skparam__s;
      float __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_speed__sprite(__skparam__s);
      return __skadapter__to_float(__skreturn);
    }
    public static void SpriteStartAnimation(Sprite s, string named)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__named;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__named = __skadapter__to_sklib_string(named);
      __sklib__sprite_start_animation__sprite__string_ref(__skparam__s, __skparam__named);
    __skadapter__free__sklib_string(ref __skparam__named);
    }
    public static void SpriteStartAnimation(Sprite s, string named, bool withSound)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__named;
      int __skparam__with_sound;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__named = __skadapter__to_sklib_string(named);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__sprite_start_animation__sprite__string_ref__bool(__skparam__s, __skparam__named, __skparam__with_sound);
    __skadapter__free__sklib_string(ref __skparam__named);
    }
    public static void SpriteStartAnimation(Sprite s, int idx)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __sklib__sprite_start_animation__sprite__int(__skparam__s, __skparam__idx);
    }
    public static void SpriteStartAnimation(Sprite s, int idx, bool withSound)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      int __skparam__with_sound;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__sprite_start_animation__sprite__int__bool(__skparam__s, __skparam__idx, __skparam__with_sound);
    }
    public static void SpriteStopCallingOnEvent(Sprite s, SpriteEventHandler handler)
    {
      __sklib_ptr __skparam__s;
      SpriteEventHandler __skparam__handler;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__handler = __skadapter__to_sklib_sprite_event_handler(handler);
      __sklib__sprite_stop_calling_on_event__sprite__sprite_event_handler_ptr(__skparam__s, __skparam__handler);
    }
    public static void SpriteToggleLayerVisible(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__sprite_toggle_layer_visible__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void SpriteToggleLayerVisible(Sprite s, int id)
    {
      __sklib_ptr __skparam__s;
      int __skparam__id;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__id = __skadapter__to_sklib_int(id);
      __sklib__sprite_toggle_layer_visible__sprite__int(__skparam__s, __skparam__id);
    }
    public static float SpriteValue(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      float __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_value__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_float(__skreturn);
    }
    public static int SpriteValueCount(Sprite s)
    {
      __sklib_ptr __skparam__s;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_value_count__sprite(__skparam__s);
      return __skadapter__to_int(__skreturn);
    }
    public static Vector2D SpriteVelocity(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __sklib_vector_2d __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_velocity__sprite(__skparam__s);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static int SpriteVisibleIndexOfLayer(Sprite s, string name)
    {
      __sklib_ptr __skparam__s;
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__sprite_visible_index_of_layer__sprite__string_ref(__skparam__s, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static int SpriteVisibleIndexOfLayer(Sprite s, int id)
    {
      __sklib_ptr __skparam__s;
      int __skparam__id;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__id = __skadapter__to_sklib_int(id);
      __skreturn = __sklib__sprite_visible_index_of_layer__sprite__int(__skparam__s, __skparam__id);
      return __skadapter__to_int(__skreturn);
    }
    public static int SpriteVisibleLayer(Sprite s, int idx)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skreturn = __sklib__sprite_visible_layer__sprite__int(__skparam__s, __skparam__idx);
      return __skadapter__to_int(__skreturn);
    }
    public static int SpriteVisibleLayerCount(Sprite s)
    {
      __sklib_ptr __skparam__s;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_visible_layer_count__sprite(__skparam__s);
      return __skadapter__to_int(__skreturn);
    }
    public static int SpriteVisibleLayerId(Sprite s, int idx)
    {
      __sklib_ptr __skparam__s;
      int __skparam__idx;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__idx = __skadapter__to_sklib_int(idx);
      __skreturn = __sklib__sprite_visible_layer_id__sprite__int(__skparam__s, __skparam__idx);
      return __skadapter__to_int(__skreturn);
    }
    public static int SpriteWidth(Sprite s)
    {
      __sklib_ptr __skparam__s;
      int __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_width__sprite(__skparam__s);
      return __skadapter__to_int(__skreturn);
    }
    public static float SpriteX(Sprite s)
    {
      __sklib_ptr __skparam__s;
      float __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_x__sprite(__skparam__s);
      return __skadapter__to_float(__skreturn);
    }
    public static float SpriteY(Sprite s)
    {
      __sklib_ptr __skparam__s;
      float __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skreturn = __sklib__sprite_y__sprite(__skparam__s);
      return __skadapter__to_float(__skreturn);
    }
    public static void StopCallingOnSpriteEvent(SpriteEventHandler handler)
    {
      SpriteEventHandler __skparam__handler;
      __skparam__handler = __skadapter__to_sklib_sprite_event_handler(handler);
      __sklib__stop_calling_on_sprite_event__sprite_event_handler_ptr(__skparam__handler);
    }
    public static void UpdateAllSprites()
    {
      __sklib__update_all_sprites();
    }
    public static void UpdateAllSprites(float pct)
    {
      float __skparam__pct;
      __skparam__pct = __skadapter__to_sklib_float(pct);
      __sklib__update_all_sprites__float(__skparam__pct);
    }
    public static void UpdateSprite(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __sklib__update_sprite__sprite(__skparam__s);
    }
    public static void UpdateSprite(Sprite s, bool withSound)
    {
      __sklib_ptr __skparam__s;
      int __skparam__with_sound;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__update_sprite__sprite__bool(__skparam__s, __skparam__with_sound);
    }
    public static void UpdateSprite(Sprite s, float pct)
    {
      __sklib_ptr __skparam__s;
      float __skparam__pct;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__pct = __skadapter__to_sklib_float(pct);
      __sklib__update_sprite__sprite__float(__skparam__s, __skparam__pct);
    }
    public static void UpdateSprite(Sprite s, float pct, bool withSound)
    {
      __sklib_ptr __skparam__s;
      float __skparam__pct;
      int __skparam__with_sound;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__pct = __skadapter__to_sklib_float(pct);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__update_sprite__sprite__float__bool(__skparam__s, __skparam__pct, __skparam__with_sound);
    }
    public static void UpdateSpriteAnimation(Sprite s)
    {
      __sklib_ptr __skparam__s;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __sklib__update_sprite_animation__sprite(__skparam__s);
    }
    public static void UpdateSpriteAnimation(Sprite s, bool withSound)
    {
      __sklib_ptr __skparam__s;
      int __skparam__with_sound;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__update_sprite_animation__sprite__bool(__skparam__s, __skparam__with_sound);
    }
    public static void UpdateSpriteAnimation(Sprite s, float pct)
    {
      __sklib_ptr __skparam__s;
      float __skparam__pct;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__pct = __skadapter__to_sklib_float(pct);
      __sklib__update_sprite_animation__sprite__float(__skparam__s, __skparam__pct);
    }
    public static void UpdateSpriteAnimation(Sprite s, float pct, bool withSound)
    {
      __sklib_ptr __skparam__s;
      float __skparam__pct;
      int __skparam__with_sound;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__pct = __skadapter__to_sklib_float(pct);
      __skparam__with_sound = __skadapter__to_sklib_bool(withSound);
      __sklib__update_sprite_animation__sprite__float__bool(__skparam__s, __skparam__pct, __skparam__with_sound);
    }
    public static Vector2D VectorFromCenterSpriteToPoint(Sprite s, Point2D pt)
    {
      __sklib_ptr __skparam__s;
      __sklib_point_2d __skparam__pt;
      __sklib_vector_2d __skreturn;
      __skparam__s = __skadapter__to_sklib_sprite(s);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__vector_from_center_sprite_to_point__sprite__point_2d_ref(__skparam__s, __skparam__pt);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorFromTo(Sprite s1, Sprite s2)
    {
      __sklib_ptr __skparam__s1;
      __sklib_ptr __skparam__s2;
      __sklib_vector_2d __skreturn;
      __skparam__s1 = __skadapter__to_sklib_sprite(s1);
      __skparam__s2 = __skadapter__to_sklib_sprite(s2);
      __skreturn = __sklib__vector_from_to__sprite__sprite(__skparam__s1, __skparam__s2);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static char ReadChar()
    {
      char __skreturn;
      __skreturn = __sklib__read_char();
      return __skadapter__to_char(__skreturn);
    }
    public static string ReadLine()
    {
      __sklib_string __skreturn;
      __skreturn = __sklib__read_line();
      return __skadapter__to_string(__skreturn);
    }
    public static bool TerminalHasInput()
    {
      int __skreturn;
      __skreturn = __sklib__terminal_has_input();
      return __skadapter__to_bool(__skreturn);
    }
    public static void Write(char data)
    {
      char __skparam__data;
      __skparam__data = __skadapter__to_sklib_char(data);
      __sklib__write__char(__skparam__data);
    }
    public static void Write(double data)
    {
      double __skparam__data;
      __skparam__data = __skadapter__to_sklib_double(data);
      __sklib__write__double(__skparam__data);
    }
    public static void Write(int data)
    {
      int __skparam__data;
      __skparam__data = __skadapter__to_sklib_int(data);
      __sklib__write__int(__skparam__data);
    }
    public static void Write(string text)
    {
      __sklib_string __skparam__text;
      __skparam__text = __skadapter__to_sklib_string(text);
      __sklib__write__string(__skparam__text);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void WriteLine(char data)
    {
      char __skparam__data;
      __skparam__data = __skadapter__to_sklib_char(data);
      __sklib__write_line__char(__skparam__data);
    }
    public static void WriteLine()
    {
      __sklib__write_line();
    }
    public static void WriteLine(double data)
    {
      double __skparam__data;
      __skparam__data = __skadapter__to_sklib_double(data);
      __sklib__write_line__double(__skparam__data);
    }
    public static void WriteLine(int data)
    {
      int __skparam__data;
      __skparam__data = __skadapter__to_sklib_int(data);
      __sklib__write_line__int(__skparam__data);
    }
    public static void WriteLine(string line)
    {
      __sklib_string __skparam__line;
      __skparam__line = __skadapter__to_sklib_string(line);
      __sklib__write_line__string(__skparam__line);
    __skadapter__free__sklib_string(ref __skparam__line);
    }
    public static void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y)
    {
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_string __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_string(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_text__string_ref__color_ref__string_ref__int__double__double(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
    __skadapter__free__sklib_string(ref __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__fnt);
    }
    public static void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y, DrawingOptions opts)
    {
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_string __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_string(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_text__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
    __skadapter__free__sklib_string(ref __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__fnt);
    }
    public static void DrawText(string text, Color clr, double x, double y)
    {
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_text__string_ref__color_ref__double__double(__skparam__text, __skparam__clr, __skparam__x, __skparam__y);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void DrawText(string text, Color clr, double x, double y, DrawingOptions opts)
    {
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_text__string_ref__color_ref__double__double__drawing_options_ref(__skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y)
    {
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_ptr __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_text__string_ref__color_ref__font__int__double__double(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y, DrawingOptions opts)
    {
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_ptr __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_text__string_ref__color_ref__font__int__double__double__drawing_options_ref(__skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, string fnt, int fontSize, double x, double y)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_string __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_string(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
    __skadapter__free__sklib_string(ref __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__fnt);
    }
    public static void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, string fnt, int fontSize, double x, double y, DrawingOptions opts)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_string __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_string(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
    __skadapter__free__sklib_string(ref __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__fnt);
    }
    public static void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, double x, double y)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__x, __skparam__y);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, double x, double y, DrawingOptions opts)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__double__double__drawing_options_ref(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, Font fnt, int fontSize, double x, double y)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_ptr __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, Font fnt, int fontSize, double x, double y, DrawingOptions opts)
    {
      __sklib_ptr __skparam__bmp;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_ptr __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_text_on_bitmap__bitmap__string_ref__color_ref__font__int__double__double__drawing_options_ref(__skparam__bmp, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void DrawTextOnWindow(Window wnd, string text, Color clr, string fnt, int fontSize, double x, double y)
    {
      __sklib_ptr __skparam__wnd;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_string __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_string(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
    __skadapter__free__sklib_string(ref __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__fnt);
    }
    public static void DrawTextOnWindow(Window wnd, string text, Color clr, string fnt, int fontSize, double x, double y, DrawingOptions opts)
    {
      __sklib_ptr __skparam__wnd;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_string __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_string(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_text_on_window__window__string_ref__color_ref__string_ref__int__double__double__drawing_options_ref(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
    __skadapter__free__sklib_string(ref __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__fnt);
    }
    public static void DrawTextOnWindow(Window wnd, string text, Color clr, double x, double y)
    {
      __sklib_ptr __skparam__wnd;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_text_on_window__window__string_ref__color_ref__double__double(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__x, __skparam__y);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void DrawTextOnWindow(Window wnd, string text, Color clr, double x, double y, DrawingOptions opts)
    {
      __sklib_ptr __skparam__wnd;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_text_on_window__window__string_ref__color_ref__double__double__drawing_options_ref(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__x, __skparam__y, __skparam__opts);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void DrawTextOnWindow(Window wnd, string text, Color clr, Font fnt, int fontSize, double x, double y)
    {
      __sklib_ptr __skparam__wnd;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_ptr __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static void DrawTextOnWindow(Window wnd, string text, Color clr, Font fnt, int fontSize, double x, double y, DrawingOptions opts)
    {
      __sklib_ptr __skparam__wnd;
      __sklib_string __skparam__text;
      __sklib_color __skparam__clr;
      __sklib_ptr __skparam__fnt;
      int __skparam__font_size;
      double __skparam__x;
      double __skparam__y;
      __sklib_drawing_options __skparam__opts;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_text_on_window__window__string_ref__color_ref__font__int__double__double__drawing_options_ref(__skparam__wnd, __skparam__text, __skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__x, __skparam__y, __skparam__opts);
    __skadapter__free__sklib_string(ref __skparam__text);
    }
    public static bool FontHasSize(string name, int fontSize)
    {
      __sklib_string __skparam__name;
      int __skparam__font_size;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skreturn = __sklib__font_has_size__string_ref__int(__skparam__name, __skparam__font_size);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool FontHasSize(Font fnt, int fontSize)
    {
      __sklib_ptr __skparam__fnt;
      int __skparam__font_size;
      int __skreturn;
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skreturn = __sklib__font_has_size__font__int(__skparam__fnt, __skparam__font_size);
      return __skadapter__to_bool(__skreturn);
    }
    public static void FontLoadSize(string name, int fontSize)
    {
      __sklib_string __skparam__name;
      int __skparam__font_size;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __sklib__font_load_size__string_ref__int(__skparam__name, __skparam__font_size);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void FontLoadSize(Font fnt, int fontSize)
    {
      __sklib_ptr __skparam__fnt;
      int __skparam__font_size;
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __sklib__font_load_size__font__int(__skparam__fnt, __skparam__font_size);
    }
    public static Font FontNamed(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__font_named__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_font(__skreturn);
    }
    public static void FreeAllFonts()
    {
      __sklib__free_all_fonts();
    }
    public static void FreeFont(Font fnt)
    {
      __sklib_ptr __skparam__fnt;
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __sklib__free_font__font(__skparam__fnt);
    }
    public static FontStyle GetFontStyle(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__get_font_style__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_font_style(__skreturn);
    }
    public static FontStyle GetFontStyle(Font fnt)
    {
      __sklib_ptr __skparam__fnt;
      int __skreturn;
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skreturn = __sklib__get_font_style__font(__skparam__fnt);
      return __skadapter__to_font_style(__skreturn);
    }
    public static Font GetSystemFont()
    {
      __sklib_ptr __skreturn;
      __skreturn = __sklib__get_system_font();
      return __skadapter__to_font(__skreturn);
    }
    public static bool HasFont(Font fnt)
    {
      __sklib_ptr __skparam__fnt;
      int __skreturn;
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skreturn = __sklib__has_font__font(__skparam__fnt);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool HasFont(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_font__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static Font LoadFont(string name, string filename)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__filename;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __skreturn = __sklib__load_font__string_ref__string_ref(__skparam__name, __skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__filename);
      return __skadapter__to_font(__skreturn);
    }
    public static void SetFontStyle(string name, FontStyle style)
    {
      __sklib_string __skparam__name;
      int __skparam__style;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__style = __skadapter__to_sklib_font_style(style);
      __sklib__set_font_style__string_ref__font_style(__skparam__name, __skparam__style);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void SetFontStyle(Font fnt, FontStyle style)
    {
      __sklib_ptr __skparam__fnt;
      int __skparam__style;
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__style = __skadapter__to_sklib_font_style(style);
      __sklib__set_font_style__font__font_style(__skparam__fnt, __skparam__style);
    }
    public static int TextHeight(string text, string fnt, int fontSize)
    {
      __sklib_string __skparam__text;
      __sklib_string __skparam__fnt;
      int __skparam__font_size;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__fnt = __skadapter__to_sklib_string(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skreturn = __sklib__text_height__string_ref__string_ref__int(__skparam__text, __skparam__fnt, __skparam__font_size);
    __skadapter__free__sklib_string(ref __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__fnt);
      return __skadapter__to_int(__skreturn);
    }
    public static int TextHeight(string text, Font fnt, int fontSize)
    {
      __sklib_string __skparam__text;
      __sklib_ptr __skparam__fnt;
      int __skparam__font_size;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skreturn = __sklib__text_height__string_ref__font__int(__skparam__text, __skparam__fnt, __skparam__font_size);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_int(__skreturn);
    }
    public static int TextWidth(string text, string fnt, int fontSize)
    {
      __sklib_string __skparam__text;
      __sklib_string __skparam__fnt;
      int __skparam__font_size;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__fnt = __skadapter__to_sklib_string(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skreturn = __sklib__text_width__string_ref__string_ref__int(__skparam__text, __skparam__fnt, __skparam__font_size);
    __skadapter__free__sklib_string(ref __skparam__text);
    __skadapter__free__sklib_string(ref __skparam__fnt);
      return __skadapter__to_int(__skreturn);
    }
    public static int TextWidth(string text, Font fnt, int fontSize)
    {
      __sklib_string __skparam__text;
      __sklib_ptr __skparam__fnt;
      int __skparam__font_size;
      int __skreturn;
      __skparam__text = __skadapter__to_sklib_string(text);
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skreturn = __sklib__text_width__string_ref__font__int(__skparam__text, __skparam__fnt, __skparam__font_size);
    __skadapter__free__sklib_string(ref __skparam__text);
      return __skadapter__to_int(__skreturn);
    }
    public static void DrawCollectedText(Color clr, Font fnt, int fontSize, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_ptr __skparam__fnt;
      int __skparam__font_size;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__fnt = __skadapter__to_sklib_font(fnt);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_collected_text__color__font__int__drawing_options_ref(__skparam__clr, __skparam__fnt, __skparam__font_size, __skparam__opts);
    }
    public static void EndReadingText()
    {
      __sklib__end_reading_text();
    }
    public static void EndReadingText(Window wind)
    {
      __sklib_ptr __skparam__wind;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __sklib__end_reading_text__window(__skparam__wind);
    }
    public static bool ReadingText()
    {
      int __skreturn;
      __skreturn = __sklib__reading_text();
      return __skadapter__to_bool(__skreturn);
    }
    public static bool ReadingText(Window wind)
    {
      __sklib_ptr __skparam__wind;
      int __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skreturn = __sklib__reading_text__window(__skparam__wind);
      return __skadapter__to_bool(__skreturn);
    }
    public static void StartReadingText(Rectangle rect)
    {
      __sklib_rectangle __skparam__rect;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__start_reading_text__rectangle(__skparam__rect);
    }
    public static void StartReadingText(Rectangle rect, string initialText)
    {
      __sklib_rectangle __skparam__rect;
      __sklib_string __skparam__initial_text;
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__initial_text = __skadapter__to_sklib_string(initialText);
      __sklib__start_reading_text__rectangle__string(__skparam__rect, __skparam__initial_text);
    __skadapter__free__sklib_string(ref __skparam__initial_text);
    }
    public static void StartReadingText(Window wind, Rectangle rect)
    {
      __sklib_ptr __skparam__wind;
      __sklib_rectangle __skparam__rect;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __sklib__start_reading_text__window__rectangle(__skparam__wind, __skparam__rect);
    }
    public static void StartReadingText(Window wind, Rectangle rect, string initialText)
    {
      __sklib_ptr __skparam__wind;
      __sklib_rectangle __skparam__rect;
      __sklib_string __skparam__initial_text;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__initial_text = __skadapter__to_sklib_string(initialText);
      __sklib__start_reading_text__window__rectangle__string(__skparam__wind, __skparam__rect, __skparam__initial_text);
    __skadapter__free__sklib_string(ref __skparam__initial_text);
    }
    public static bool TextEntryCancelled()
    {
      int __skreturn;
      __skreturn = __sklib__text_entry_cancelled();
      return __skadapter__to_bool(__skreturn);
    }
    public static bool TextEntryCancelled(Window wind)
    {
      __sklib_ptr __skparam__wind;
      int __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skreturn = __sklib__text_entry_cancelled__window(__skparam__wind);
      return __skadapter__to_bool(__skreturn);
    }
    public static string TextInput()
    {
      __sklib_string __skreturn;
      __skreturn = __sklib__text_input();
      return __skadapter__to_string(__skreturn);
    }
    public static string TextInput(Window wind)
    {
      __sklib_ptr __skparam__wind;
      __sklib_string __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skreturn = __sklib__text_input__window(__skparam__wind);
      return __skadapter__to_string(__skreturn);
    }
    public static Timer CreateTimer(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__create_timer__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_timer(__skreturn);
    }
    public static void FreeAllTimers()
    {
      __sklib__free_all_timers();
    }
    public static void FreeTimer(Timer toFree)
    {
      __sklib_ptr __skparam__to_free;
      __skparam__to_free = __skadapter__to_sklib_timer(toFree);
      __sklib__free_timer__timer(__skparam__to_free);
    }
    public static bool HasTimer(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__has_timer__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static void PauseTimer(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__pause_timer__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void PauseTimer(Timer toPause)
    {
      __sklib_ptr __skparam__to_pause;
      __skparam__to_pause = __skadapter__to_sklib_timer(toPause);
      __sklib__pause_timer__timer(__skparam__to_pause);
    }
    public static void ResetTimer(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__reset_timer__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void ResetTimer(Timer tmr)
    {
      __sklib_ptr __skparam__tmr;
      __skparam__tmr = __skadapter__to_sklib_timer(tmr);
      __sklib__reset_timer__timer(__skparam__tmr);
    }
    public static void ResumeTimer(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__resume_timer__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void ResumeTimer(Timer toResume)
    {
      __sklib_ptr __skparam__to_resume;
      __skparam__to_resume = __skadapter__to_sklib_timer(toResume);
      __sklib__resume_timer__timer(__skparam__to_resume);
    }
    public static void StartTimer(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__start_timer__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void StartTimer(Timer toStart)
    {
      __sklib_ptr __skparam__to_start;
      __skparam__to_start = __skadapter__to_sklib_timer(toStart);
      __sklib__start_timer__timer(__skparam__to_start);
    }
    public static void StopTimer(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__stop_timer__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void StopTimer(Timer toStop)
    {
      __sklib_ptr __skparam__to_stop;
      __skparam__to_stop = __skadapter__to_sklib_timer(toStop);
      __sklib__stop_timer__timer(__skparam__to_stop);
    }
    public static Timer TimerNamed(string name)
    {
      __sklib_string __skparam__name;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__timer_named__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_timer(__skreturn);
    }
    public static bool TimerPaused(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__timer_paused__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool TimerPaused(Timer toGet)
    {
      __sklib_ptr __skparam__to_get;
      int __skreturn;
      __skparam__to_get = __skadapter__to_sklib_timer(toGet);
      __skreturn = __sklib__timer_paused__timer(__skparam__to_get);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool TimerStarted(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__timer_started__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool TimerStarted(Timer toGet)
    {
      __sklib_ptr __skparam__to_get;
      int __skreturn;
      __skparam__to_get = __skadapter__to_sklib_timer(toGet);
      __skreturn = __sklib__timer_started__timer(__skparam__to_get);
      return __skadapter__to_bool(__skreturn);
    }
    public static uint TimerTicks(string name)
    {
      __sklib_string __skparam__name;
      uint __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__timer_ticks__string(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static uint TimerTicks(Timer toGet)
    {
      __sklib_ptr __skparam__to_get;
      uint __skreturn;
      __skparam__to_get = __skadapter__to_sklib_timer(toGet);
      __skreturn = __sklib__timer_ticks__timer(__skparam__to_get);
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static void DrawTriangle(Color clr, Triangle tri)
    {
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __sklib__draw_triangle__color__triangle_ref(__skparam__clr, __skparam__tri);
    }
    public static void DrawTriangle(Color clr, Triangle tri, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_triangle__color__triangle_ref__drawing_options(__skparam__clr, __skparam__tri, __skparam__opts);
    }
    public static void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3)
    {
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __sklib__draw_triangle__color__double__double__double__double__double__double(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
    }
    public static void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_triangle__color__double__double__double__double__double__double__drawing_options(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
    }
    public static void DrawTriangleOnBitmap(Bitmap destination, Color clr, Triangle tri)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri);
    }
    public static void DrawTriangleOnBitmap(Bitmap destination, Color clr, Triangle tri, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
    }
    public static void DrawTriangleOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
    }
    public static void DrawTriangleOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
    }
    public static void DrawTriangleOnWindow(Window destination, Color clr, Triangle tri)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __sklib__draw_triangle_on_window__window__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri);
    }
    public static void DrawTriangleOnWindow(Window destination, Color clr, Triangle tri, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_triangle_on_window__window__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
    }
    public static void DrawTriangleOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
    }
    public static void DrawTriangleOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__draw_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
    }
    public static void FillTriangle(Color clr, Triangle tri)
    {
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __sklib__fill_triangle__color__triangle_ref(__skparam__clr, __skparam__tri);
    }
    public static void FillTriangle(Color clr, Triangle tri, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_triangle__color__triangle_ref__drawing_options(__skparam__clr, __skparam__tri, __skparam__opts);
    }
    public static void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3)
    {
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __sklib__fill_triangle__color__double__double__double__double__double__double(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
    }
    public static void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts)
    {
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __sklib_drawing_options __skparam__opts;
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_triangle__color__double__double__double__double__double__double__drawing_options(__skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
    }
    public static void FillTriangleOnBitmap(Bitmap destination, Color clr, Triangle tri)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri);
    }
    public static void FillTriangleOnBitmap(Bitmap destination, Color clr, Triangle tri, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_triangle_on_bitmap__bitmap__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
    }
    public static void FillTriangleOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
    }
    public static void FillTriangleOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_bitmap(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_triangle_on_bitmap__bitmap__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
    }
    public static void FillTriangleOnWindow(Window destination, Color clr, Triangle tri)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __sklib__fill_triangle_on_window__window__color__triangle_ref(__skparam__destination, __skparam__clr, __skparam__tri);
    }
    public static void FillTriangleOnWindow(Window destination, Color clr, Triangle tri, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      __sklib_triangle __skparam__tri;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_triangle_on_window__window__color__triangle_ref__drawing_options(__skparam__destination, __skparam__clr, __skparam__tri, __skparam__opts);
    }
    public static void FillTriangleOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
    }
    public static void FillTriangleOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts)
    {
      __sklib_ptr __skparam__destination;
      __sklib_color __skparam__clr;
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __sklib_drawing_options __skparam__opts;
      __skparam__destination = __skadapter__to_sklib_window(destination);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __skparam__opts = __skadapter__to_sklib_drawing_options(opts);
      __sklib__fill_triangle_on_window__window__color__double__double__double__double__double__double__drawing_options(__skparam__destination, __skparam__clr, __skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3, __skparam__opts);
    }
    public static Point2D TriangleBarycenter(Triangle tri)
    {
      __sklib_triangle __skparam__tri;
      __sklib_point_2d __skreturn;
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skreturn = __sklib__triangle_barycenter__triangle_ref(__skparam__tri);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Triangle TriangleFrom(Point2D p1, Point2D p2, Point2D p3)
    {
      __sklib_point_2d __skparam__p1;
      __sklib_point_2d __skparam__p2;
      __sklib_point_2d __skparam__p3;
      __sklib_triangle __skreturn;
      __skparam__p1 = __skadapter__to_sklib_point_2d(p1);
      __skparam__p2 = __skadapter__to_sklib_point_2d(p2);
      __skparam__p3 = __skadapter__to_sklib_point_2d(p3);
      __skreturn = __sklib__triangle_from__point_2d_ref__point_2d_ref__point_2d_ref(__skparam__p1, __skparam__p2, __skparam__p3);
      return __skadapter__to_triangle(__skreturn);
    }
    public static Triangle TriangleFrom(double x1, double y1, double x2, double y2, double x3, double y3)
    {
      double __skparam__x1;
      double __skparam__y1;
      double __skparam__x2;
      double __skparam__y2;
      double __skparam__x3;
      double __skparam__y3;
      __sklib_triangle __skreturn;
      __skparam__x1 = __skadapter__to_sklib_double(x1);
      __skparam__y1 = __skadapter__to_sklib_double(y1);
      __skparam__x2 = __skadapter__to_sklib_double(x2);
      __skparam__y2 = __skadapter__to_sklib_double(y2);
      __skparam__x3 = __skadapter__to_sklib_double(x3);
      __skparam__y3 = __skadapter__to_sklib_double(y3);
      __skreturn = __sklib__triangle_from__double__double__double__double__double__double(__skparam__x1, __skparam__y1, __skparam__x2, __skparam__y2, __skparam__x3, __skparam__y3);
      return __skadapter__to_triangle(__skreturn);
    }
    public static bool TriangleRectangleIntersect(Triangle tri, Rectangle rect)
    {
      __sklib_triangle __skparam__tri;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__triangle_rectangle_intersect__triangle_ref__rectangle_ref(__skparam__tri, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static string TriangleToString(Triangle tri)
    {
      __sklib_triangle __skparam__tri;
      __sklib_string __skreturn;
      __skparam__tri = __skadapter__to_sklib_triangle(tri);
      __skreturn = __sklib__triangle_to_string__triangle_ref(__skparam__tri);
      return __skadapter__to_string(__skreturn);
    }
    public static bool TrianglesIntersect(Triangle t1, Triangle t2)
    {
      __sklib_triangle __skparam__t1;
      __sklib_triangle __skparam__t2;
      int __skreturn;
      __skparam__t1 = __skadapter__to_sklib_triangle(t1);
      __skparam__t2 = __skadapter__to_sklib_triangle(t2);
      __skreturn = __sklib__triangles_intersect__triangle_ref__triangle_ref(__skparam__t1, __skparam__t2);
      return __skadapter__to_bool(__skreturn);
    }
    public static uint CurrentTicks()
    {
      uint __skreturn;
      __skreturn = __sklib__current_ticks();
      return __skadapter__to_unsigned_int(__skreturn);
    }
    public static void Delay(int milliseconds)
    {
      int __skparam__milliseconds;
      __skparam__milliseconds = __skadapter__to_sklib_int(milliseconds);
      __sklib__delay__int(__skparam__milliseconds);
    }
    public static void DisplayDialog(string title, string msg, Font outputFont, int fontSize)
    {
      __sklib_string __skparam__title;
      __sklib_string __skparam__msg;
      __sklib_ptr __skparam__output_font;
      int __skparam__font_size;
      __skparam__title = __skadapter__to_sklib_string(title);
      __skparam__msg = __skadapter__to_sklib_string(msg);
      __skparam__output_font = __skadapter__to_sklib_font(outputFont);
      __skparam__font_size = __skadapter__to_sklib_int(fontSize);
      __sklib__display_dialog__string_ref__string_ref__font__int(__skparam__title, __skparam__msg, __skparam__output_font, __skparam__font_size);
    __skadapter__free__sklib_string(ref __skparam__title);
    __skadapter__free__sklib_string(ref __skparam__msg);
    }
    public static string FileAsString(string filename, ResourceKind kind)
    {
      __sklib_string __skparam__filename;
      int __skparam__kind;
      __sklib_string __skreturn;
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __skparam__kind = __skadapter__to_sklib_resource_kind(kind);
      __skreturn = __sklib__file_as_string__string__resource_kind(__skparam__filename, __skparam__kind);
    __skadapter__free__sklib_string(ref __skparam__filename);
      return __skadapter__to_string(__skreturn);
    }
    public static double AngleBetween(Vector2D v1, Vector2D v2)
    {
      __sklib_vector_2d __skparam__v1;
      __sklib_vector_2d __skparam__v2;
      double __skreturn;
      __skparam__v1 = __skadapter__to_sklib_vector_2d(v1);
      __skparam__v2 = __skadapter__to_sklib_vector_2d(v2);
      __skreturn = __sklib__angle_between__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2);
      return __skadapter__to_double(__skreturn);
    }
    public static double DotProduct(Vector2D v1, Vector2D v2)
    {
      __sklib_vector_2d __skparam__v1;
      __sklib_vector_2d __skparam__v2;
      double __skreturn;
      __skparam__v1 = __skadapter__to_sklib_vector_2d(v1);
      __skparam__v2 = __skadapter__to_sklib_vector_2d(v2);
      __skreturn = __sklib__dot_product__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2);
      return __skadapter__to_double(__skreturn);
    }
    public static bool IsZeroVector(Vector2D v)
    {
      __sklib_vector_2d __skparam__v;
      int __skreturn;
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skreturn = __sklib__is_zero_vector__vector_2d_ref(__skparam__v);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool RayIntersectionPoint(Point2D fromPt, Vector2D heading, Line l, ref Point2D pt)
    {
      __sklib_point_2d __skparam__from_pt;
      __sklib_vector_2d __skparam__heading;
      __sklib_line __skparam__l;
      __sklib_point_2d __skparam__pt;
      int __skreturn;
      __skparam__from_pt = __skadapter__to_sklib_point_2d(fromPt);
      __skparam__heading = __skadapter__to_sklib_vector_2d(heading);
      __skparam__l = __skadapter__to_sklib_line(l);
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skreturn = __sklib__ray_intersection_point__point_2d_ref__vector_2d_ref__line_ref__point_2d_ref(__skparam__from_pt, __skparam__heading, __skparam__l, ref __skparam__pt);
      pt = __skadapter__to_point_2d(__skparam__pt);
      return __skadapter__to_bool(__skreturn);
    }
    public static Vector2D UnitVector(Vector2D v)
    {
      __sklib_vector_2d __skparam__v;
      __sklib_vector_2d __skreturn;
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skreturn = __sklib__unit_vector__vector_2d_ref(__skparam__v);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorAdd(Vector2D v1, Vector2D v2)
    {
      __sklib_vector_2d __skparam__v1;
      __sklib_vector_2d __skparam__v2;
      __sklib_vector_2d __skreturn;
      __skparam__v1 = __skadapter__to_sklib_vector_2d(v1);
      __skparam__v2 = __skadapter__to_sklib_vector_2d(v2);
      __skreturn = __sklib__vector_add__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static double VectorAngle(Vector2D v)
    {
      __sklib_vector_2d __skparam__v;
      double __skreturn;
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skreturn = __sklib__vector_angle__vector_2d(__skparam__v);
      return __skadapter__to_double(__skreturn);
    }
    public static Vector2D VectorFromAngle(double angle, double magnitude)
    {
      double __skparam__angle;
      double __skparam__magnitude;
      __sklib_vector_2d __skreturn;
      __skparam__angle = __skadapter__to_sklib_double(angle);
      __skparam__magnitude = __skadapter__to_sklib_double(magnitude);
      __skreturn = __sklib__vector_from_angle__double__double(__skparam__angle, __skparam__magnitude);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorFromLine(Line l)
    {
      __sklib_line __skparam__l;
      __sklib_vector_2d __skreturn;
      __skparam__l = __skadapter__to_sklib_line(l);
      __skreturn = __sklib__vector_from_line__line_ref(__skparam__l);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorFromPointToRect(Point2D pt, Rectangle rect)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_rectangle __skparam__rect;
      __sklib_vector_2d __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__vector_from_point_to_rect__point_2d_ref__rectangle_ref(__skparam__pt, __skparam__rect);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static bool VectorInRect(Vector2D v, Rectangle rect)
    {
      __sklib_vector_2d __skparam__v;
      __sklib_rectangle __skparam__rect;
      int __skreturn;
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skreturn = __sklib__vector_in_rect__vector_2d_ref__rectangle_ref(__skparam__v, __skparam__rect);
      return __skadapter__to_bool(__skreturn);
    }
    public static Vector2D VectorInvert(Vector2D v)
    {
      __sklib_vector_2d __skparam__v;
      __sklib_vector_2d __skreturn;
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skreturn = __sklib__vector_invert__vector_2d_ref(__skparam__v);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorLimit(Vector2D v, double limit)
    {
      __sklib_vector_2d __skparam__v;
      double __skparam__limit;
      __sklib_vector_2d __skreturn;
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skparam__limit = __skadapter__to_sklib_double(limit);
      __skreturn = __sklib__vector_limit__vector_2d_ref__double(__skparam__v, __skparam__limit);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static double VectorMagnitude(Vector2D v)
    {
      __sklib_vector_2d __skparam__v;
      double __skreturn;
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skreturn = __sklib__vector_magnitude__vector_2d_ref(__skparam__v);
      return __skadapter__to_double(__skreturn);
    }
    public static double VectorMagnitudeSquared(Vector2D v)
    {
      __sklib_vector_2d __skparam__v;
      double __skreturn;
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skreturn = __sklib__vector_magnitude_squared__vector_2d_ref(__skparam__v);
      return __skadapter__to_double(__skreturn);
    }
    public static Vector2D VectorMultiply(Vector2D v1, double s)
    {
      __sklib_vector_2d __skparam__v1;
      double __skparam__s;
      __sklib_vector_2d __skreturn;
      __skparam__v1 = __skadapter__to_sklib_vector_2d(v1);
      __skparam__s = __skadapter__to_sklib_double(s);
      __skreturn = __sklib__vector_multiply__vector_2d_ref__double(__skparam__v1, __skparam__s);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorNormal(Vector2D v)
    {
      __sklib_vector_2d __skparam__v;
      __sklib_vector_2d __skreturn;
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skreturn = __sklib__vector_normal__vector_2d_ref(__skparam__v);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorOutOfCircleFromCircle(Circle src, Circle bounds, Vector2D velocity)
    {
      __sklib_circle __skparam__src;
      __sklib_circle __skparam__bounds;
      __sklib_vector_2d __skparam__velocity;
      __sklib_vector_2d __skreturn;
      __skparam__src = __skadapter__to_sklib_circle(src);
      __skparam__bounds = __skadapter__to_sklib_circle(bounds);
      __skparam__velocity = __skadapter__to_sklib_vector_2d(velocity);
      __skreturn = __sklib__vector_out_of_circle_from_circle__circle_ref__circle_ref__vector_2d_ref(__skparam__src, __skparam__bounds, __skparam__velocity);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorOutOfCircleFromPoint(Point2D pt, Circle c, Vector2D velocity)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_circle __skparam__c;
      __sklib_vector_2d __skparam__velocity;
      __sklib_vector_2d __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__velocity = __skadapter__to_sklib_vector_2d(velocity);
      __skreturn = __sklib__vector_out_of_circle_from_point__point_2d_ref__circle_ref__vector_2d_ref(__skparam__pt, __skparam__c, __skparam__velocity);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorOutOfRectFromCircle(Circle c, Rectangle rect, Vector2D velocity)
    {
      __sklib_circle __skparam__c;
      __sklib_rectangle __skparam__rect;
      __sklib_vector_2d __skparam__velocity;
      __sklib_vector_2d __skreturn;
      __skparam__c = __skadapter__to_sklib_circle(c);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__velocity = __skadapter__to_sklib_vector_2d(velocity);
      __skreturn = __sklib__vector_out_of_rect_from_circle__circle_ref__rectangle_ref__vector_2d_ref(__skparam__c, __skparam__rect, __skparam__velocity);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorOutOfRectFromPoint(Point2D pt, Rectangle rect, Vector2D velocity)
    {
      __sklib_point_2d __skparam__pt;
      __sklib_rectangle __skparam__rect;
      __sklib_vector_2d __skparam__velocity;
      __sklib_vector_2d __skreturn;
      __skparam__pt = __skadapter__to_sklib_point_2d(pt);
      __skparam__rect = __skadapter__to_sklib_rectangle(rect);
      __skparam__velocity = __skadapter__to_sklib_vector_2d(velocity);
      __skreturn = __sklib__vector_out_of_rect_from_point__point_2d_ref__rectangle_ref__vector_2d_ref(__skparam__pt, __skparam__rect, __skparam__velocity);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorOutOfRectFromRect(Rectangle src, Rectangle bounds, Vector2D velocity)
    {
      __sklib_rectangle __skparam__src;
      __sklib_rectangle __skparam__bounds;
      __sklib_vector_2d __skparam__velocity;
      __sklib_vector_2d __skreturn;
      __skparam__src = __skadapter__to_sklib_rectangle(src);
      __skparam__bounds = __skadapter__to_sklib_rectangle(bounds);
      __skparam__velocity = __skadapter__to_sklib_vector_2d(velocity);
      __skreturn = __sklib__vector_out_of_rect_from_rect__rectangle_ref__rectangle_ref__vector_2d_ref(__skparam__src, __skparam__bounds, __skparam__velocity);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorPointToPoint(Point2D start, Point2D endPt)
    {
      __sklib_point_2d __skparam__start;
      __sklib_point_2d __skparam__end_pt;
      __sklib_vector_2d __skreturn;
      __skparam__start = __skadapter__to_sklib_point_2d(start);
      __skparam__end_pt = __skadapter__to_sklib_point_2d(endPt);
      __skreturn = __sklib__vector_point_to_point__point_2d_ref__point_2d_ref(__skparam__start, __skparam__end_pt);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorSubtract(Vector2D v1, Vector2D v2)
    {
      __sklib_vector_2d __skparam__v1;
      __sklib_vector_2d __skparam__v2;
      __sklib_vector_2d __skreturn;
      __skparam__v1 = __skadapter__to_sklib_vector_2d(v1);
      __skparam__v2 = __skadapter__to_sklib_vector_2d(v2);
      __skreturn = __sklib__vector_subtract__vector_2d_ref__vector_2d_ref(__skparam__v1, __skparam__v2);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorTo(Point2D p1)
    {
      __sklib_point_2d __skparam__p1;
      __sklib_vector_2d __skreturn;
      __skparam__p1 = __skadapter__to_sklib_point_2d(p1);
      __skreturn = __sklib__vector_to__point_2d_ref(__skparam__p1);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static Vector2D VectorTo(double x, double y)
    {
      double __skparam__x;
      double __skparam__y;
      __sklib_vector_2d __skreturn;
      __skparam__x = __skadapter__to_sklib_double(x);
      __skparam__y = __skadapter__to_sklib_double(y);
      __skreturn = __sklib__vector_to__double__double(__skparam__x, __skparam__y);
      return __skadapter__to_vector_2d(__skreturn);
    }
    public static string VectorToString(Vector2D v)
    {
      __sklib_vector_2d __skparam__v;
      __sklib_string __skreturn;
      __skparam__v = __skadapter__to_sklib_vector_2d(v);
      __skreturn = __sklib__vector_to_string__vector_2d_ref(__skparam__v);
      return __skadapter__to_string(__skreturn);
    }
    public static bool VectorsEqual(Vector2D v1, Vector2D v2)
    {
      __sklib_vector_2d __skparam__v1;
      __sklib_vector_2d __skparam__v2;
      int __skreturn;
      __skparam__v1 = __skadapter__to_sklib_vector_2d(v1);
      __skparam__v2 = __skadapter__to_sklib_vector_2d(v2);
      __skreturn = __sklib__vectors_equal__vector_2d_ref__vector_2d(__skparam__v1, __skparam__v2);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool VectorsNotEqual(Vector2D v1, Vector2D v2)
    {
      __sklib_vector_2d __skparam__v1;
      __sklib_vector_2d __skparam__v2;
      int __skreturn;
      __skparam__v1 = __skadapter__to_sklib_vector_2d(v1);
      __skparam__v2 = __skadapter__to_sklib_vector_2d(v2);
      __skreturn = __sklib__vectors_not_equal__vector_2d_ref__vector_2d(__skparam__v1, __skparam__v2);
      return __skadapter__to_bool(__skreturn);
    }
    public static Bitmap DownloadBitmap(string name, string url, ushort port)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__url;
      ushort __skparam__port;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__url = __skadapter__to_sklib_string(url);
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skreturn = __sklib__download_bitmap__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__url);
      return __skadapter__to_bitmap(__skreturn);
    }
    public static Font DownloadFont(string name, string url, ushort port)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__url;
      ushort __skparam__port;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__url = __skadapter__to_sklib_string(url);
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skreturn = __sklib__download_font__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__url);
      return __skadapter__to_font(__skreturn);
    }
    public static Music DownloadMusic(string name, string url, ushort port)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__url;
      ushort __skparam__port;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__url = __skadapter__to_sklib_string(url);
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skreturn = __sklib__download_music__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__url);
      return __skadapter__to_music(__skreturn);
    }
    public static SoundEffect DownloadSoundEffect(string name, string url, ushort port)
    {
      __sklib_string __skparam__name;
      __sklib_string __skparam__url;
      ushort __skparam__port;
      __sklib_ptr __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__url = __skadapter__to_sklib_string(url);
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skreturn = __sklib__download_sound_effect__string_ref__string_ref__unsigned_short(__skparam__name, __skparam__url, __skparam__port);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__url);
      return __skadapter__to_sound_effect(__skreturn);
    }
    public static void FreeResponse(HttpResponse response)
    {
      __sklib_ptr __skparam__response;
      __skparam__response = __skadapter__to_sklib_http_response(response);
      __sklib__free_response__http_response(__skparam__response);
    }
    public static HttpResponse HttpGet(string url, ushort port)
    {
      __sklib_string __skparam__url;
      ushort __skparam__port;
      __sklib_ptr __skreturn;
      __skparam__url = __skadapter__to_sklib_string(url);
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skreturn = __sklib__http_get__string_ref__unsigned_short(__skparam__url, __skparam__port);
    __skadapter__free__sklib_string(ref __skparam__url);
      return __skadapter__to_http_response(__skreturn);
    }
    public static HttpResponse HttpPost(string url, ushort port, string body, List<string> headers)
    {
      __sklib_string __skparam__url;
      ushort __skparam__port;
      __sklib_string __skparam__body;
      __sklib_vector_string __skparam__headers;
      __sklib_ptr __skreturn;
      __skparam__url = __skadapter__to_sklib_string(url);
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skparam__body = __skadapter__to_sklib_string(body);
      __skparam__headers = __skadapter__to_sklib_vector_string(headers);
      __skreturn = __sklib__http_post__string_ref__unsigned_short__string_ref__vector_string_ref(__skparam__url, __skparam__port, __skparam__body, __skparam__headers);
    __skadapter__free__sklib_string(ref __skparam__url);
    __skadapter__free__sklib_string(ref __skparam__body);
    __skadapter__free__sklib_vector_string(ref __skparam__headers);
      return __skadapter__to_http_response(__skreturn);
    }
    public static HttpResponse HttpPost(string url, ushort port, string body)
    {
      __sklib_string __skparam__url;
      ushort __skparam__port;
      __sklib_string __skparam__body;
      __sklib_ptr __skreturn;
      __skparam__url = __skadapter__to_sklib_string(url);
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skparam__body = __skadapter__to_sklib_string(body);
      __skreturn = __sklib__http_post__string_ref__unsigned_short__string(__skparam__url, __skparam__port, __skparam__body);
    __skadapter__free__sklib_string(ref __skparam__url);
    __skadapter__free__sklib_string(ref __skparam__body);
      return __skadapter__to_http_response(__skreturn);
    }
    public static string HttpResponseToString(HttpResponse response)
    {
      __sklib_ptr __skparam__response;
      __sklib_string __skreturn;
      __skparam__response = __skadapter__to_sklib_http_response(response);
      __skreturn = __sklib__http_response_to_string__http_response(__skparam__response);
      return __skadapter__to_string(__skreturn);
    }
    public static void SaveResponseToFile(HttpResponse response, string path)
    {
      __sklib_ptr __skparam__response;
      __sklib_string __skparam__path;
      __skparam__response = __skadapter__to_sklib_http_response(response);
      __skparam__path = __skadapter__to_sklib_string(path);
      __sklib__save_response_to_file__http_response__string(__skparam__response, __skparam__path);
    __skadapter__free__sklib_string(ref __skparam__path);
    }
    public static bool HasIncomingRequests(WebServer server)
    {
      __sklib_ptr __skparam__server;
      int __skreturn;
      __skparam__server = __skadapter__to_sklib_web_server(server);
      __skreturn = __sklib__has_incoming_requests__web_server(__skparam__server);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool IsDeleteRequestFor(HttpRequest request, string path)
    {
      __sklib_ptr __skparam__request;
      __sklib_string __skparam__path;
      int __skreturn;
      __skparam__request = __skadapter__to_sklib_http_request(request);
      __skparam__path = __skadapter__to_sklib_string(path);
      __skreturn = __sklib__is_delete_request_for__http_request__string_ref(__skparam__request, __skparam__path);
    __skadapter__free__sklib_string(ref __skparam__path);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool IsGetRequestFor(HttpRequest request, string path)
    {
      __sklib_ptr __skparam__request;
      __sklib_string __skparam__path;
      int __skreturn;
      __skparam__request = __skadapter__to_sklib_http_request(request);
      __skparam__path = __skadapter__to_sklib_string(path);
      __skreturn = __sklib__is_get_request_for__http_request__string_ref(__skparam__request, __skparam__path);
    __skadapter__free__sklib_string(ref __skparam__path);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool IsOptionsRequestFor(HttpRequest request, string path)
    {
      __sklib_ptr __skparam__request;
      __sklib_string __skparam__path;
      int __skreturn;
      __skparam__request = __skadapter__to_sklib_http_request(request);
      __skparam__path = __skadapter__to_sklib_string(path);
      __skreturn = __sklib__is_options_request_for__http_request__string_ref(__skparam__request, __skparam__path);
    __skadapter__free__sklib_string(ref __skparam__path);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool IsPostRequestFor(HttpRequest request, string path)
    {
      __sklib_ptr __skparam__request;
      __sklib_string __skparam__path;
      int __skreturn;
      __skparam__request = __skadapter__to_sklib_http_request(request);
      __skparam__path = __skadapter__to_sklib_string(path);
      __skreturn = __sklib__is_post_request_for__http_request__string_ref(__skparam__request, __skparam__path);
    __skadapter__free__sklib_string(ref __skparam__path);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool IsPutRequestFor(HttpRequest request, string path)
    {
      __sklib_ptr __skparam__request;
      __sklib_string __skparam__path;
      int __skreturn;
      __skparam__request = __skadapter__to_sklib_http_request(request);
      __skparam__path = __skadapter__to_sklib_string(path);
      __skreturn = __sklib__is_put_request_for__http_request__string_ref(__skparam__request, __skparam__path);
    __skadapter__free__sklib_string(ref __skparam__path);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool IsRequestFor(HttpRequest request, HttpMethod method, string path)
    {
      __sklib_ptr __skparam__request;
      int __skparam__method;
      __sklib_string __skparam__path;
      int __skreturn;
      __skparam__request = __skadapter__to_sklib_http_request(request);
      __skparam__method = __skadapter__to_sklib_http_method(method);
      __skparam__path = __skadapter__to_sklib_string(path);
      __skreturn = __sklib__is_request_for__http_request__http_method__string_ref(__skparam__request, __skparam__method, __skparam__path);
    __skadapter__free__sklib_string(ref __skparam__path);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool IsTraceRequestFor(HttpRequest request, string path)
    {
      __sklib_ptr __skparam__request;
      __sklib_string __skparam__path;
      int __skreturn;
      __skparam__request = __skadapter__to_sklib_http_request(request);
      __skparam__path = __skadapter__to_sklib_string(path);
      __skreturn = __sklib__is_trace_request_for__http_request__string_ref(__skparam__request, __skparam__path);
    __skadapter__free__sklib_string(ref __skparam__path);
      return __skadapter__to_bool(__skreturn);
    }
    public static HttpRequest NextWebRequest(WebServer server)
    {
      __sklib_ptr __skparam__server;
      __sklib_ptr __skreturn;
      __skparam__server = __skadapter__to_sklib_web_server(server);
      __skreturn = __sklib__next_web_request__web_server(__skparam__server);
      return __skadapter__to_http_request(__skreturn);
    }
    public static string RequestBody(HttpRequest r)
    {
      __sklib_ptr __skparam__r;
      __sklib_string __skreturn;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skreturn = __sklib__request_body__http_request(__skparam__r);
      return __skadapter__to_string(__skreturn);
    }
    public static bool RequestHasQueryParameter(HttpRequest r, string name)
    {
      __sklib_ptr __skparam__r;
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__request_has_query_parameter__http_request__string_ref(__skparam__r, __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static List<string> RequestHeaders(HttpRequest r)
    {
      __sklib_ptr __skparam__r;
      __sklib_vector_string __skreturn;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skreturn = __sklib__request_headers__http_request(__skparam__r);
      return __skadapter__to_vector_string(__skreturn);
    }
    public static HttpMethod RequestMethod(HttpRequest r)
    {
      __sklib_ptr __skparam__r;
      int __skreturn;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skreturn = __sklib__request_method__http_request(__skparam__r);
      return __skadapter__to_http_method(__skreturn);
    }
    public static string RequestQueryParameter(HttpRequest r, string name, string defaultValue)
    {
      __sklib_ptr __skparam__r;
      __sklib_string __skparam__name;
      __sklib_string __skparam__default_value;
      __sklib_string __skreturn;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__default_value = __skadapter__to_sklib_string(defaultValue);
      __skreturn = __sklib__request_query_parameter__http_request__string_ref__string_ref(__skparam__r, __skparam__name, __skparam__default_value);
    __skadapter__free__sklib_string(ref __skparam__name);
    __skadapter__free__sklib_string(ref __skparam__default_value);
      return __skadapter__to_string(__skreturn);
    }
    public static string RequestQueryString(HttpRequest r)
    {
      __sklib_ptr __skparam__r;
      __sklib_string __skreturn;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skreturn = __sklib__request_query_string__http_request(__skparam__r);
      return __skadapter__to_string(__skreturn);
    }
    public static string RequestURI(HttpRequest r)
    {
      __sklib_ptr __skparam__r;
      __sklib_string __skreturn;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skreturn = __sklib__request_uri__http_request(__skparam__r);
      return __skadapter__to_string(__skreturn);
    }
    public static List<string> RequestURIStubs(HttpRequest r)
    {
      __sklib_ptr __skparam__r;
      __sklib_vector_string __skreturn;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skreturn = __sklib__request_uri_stubs__http_request(__skparam__r);
      return __skadapter__to_vector_string(__skreturn);
    }
    public static void SendCSSFileResponse(HttpRequest r, string filename)
    {
      __sklib_ptr __skparam__r;
      __sklib_string __skparam__filename;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __sklib__send_css_file_response__http_request__string_ref(__skparam__r, __skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__filename);
    }
    public static void SendFileResponse(HttpRequest r, string filename, string contentType)
    {
      __sklib_ptr __skparam__r;
      __sklib_string __skparam__filename;
      __sklib_string __skparam__content_type;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __skparam__content_type = __skadapter__to_sklib_string(contentType);
      __sklib__send_file_response__http_request__string_ref__string_ref(__skparam__r, __skparam__filename, __skparam__content_type);
    __skadapter__free__sklib_string(ref __skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__content_type);
    }
    public static void SendHtmlFileResponse(HttpRequest r, string filename)
    {
      __sklib_ptr __skparam__r;
      __sklib_string __skparam__filename;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __sklib__send_html_file_response__http_request__string_ref(__skparam__r, __skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__filename);
    }
    public static void SendJavascriptFileResponse(HttpRequest r, string filename)
    {
      __sklib_ptr __skparam__r;
      __sklib_string __skparam__filename;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__filename = __skadapter__to_sklib_string(filename);
      __sklib__send_javascript_file_response__http_request__string_ref(__skparam__r, __skparam__filename);
    __skadapter__free__sklib_string(ref __skparam__filename);
    }
    public static void SendResponse(HttpRequest r)
    {
      __sklib_ptr __skparam__r;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __sklib__send_response__http_request(__skparam__r);
    }
    public static void SendResponse(HttpRequest r, string message)
    {
      __sklib_ptr __skparam__r;
      __sklib_string __skparam__message;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__message = __skadapter__to_sklib_string(message);
      __sklib__send_response__http_request__string_ref(__skparam__r, __skparam__message);
    __skadapter__free__sklib_string(ref __skparam__message);
    }
    public static void SendResponse(HttpRequest r, HttpStatusCode code)
    {
      __sklib_ptr __skparam__r;
      int __skparam__code;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__code = __skadapter__to_sklib_http_status_code(code);
      __sklib__send_response__http_request__http_status_code(__skparam__r, __skparam__code);
    }
    public static void SendResponse(HttpRequest r, HttpStatusCode code, string message)
    {
      __sklib_ptr __skparam__r;
      int __skparam__code;
      __sklib_string __skparam__message;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__code = __skadapter__to_sklib_http_status_code(code);
      __skparam__message = __skadapter__to_sklib_string(message);
      __sklib__send_response__http_request__http_status_code__string_ref(__skparam__r, __skparam__code, __skparam__message);
    __skadapter__free__sklib_string(ref __skparam__message);
    }
    public static void SendResponse(HttpRequest r, HttpStatusCode code, string message, string contentType)
    {
      __sklib_ptr __skparam__r;
      int __skparam__code;
      __sklib_string __skparam__message;
      __sklib_string __skparam__content_type;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__code = __skadapter__to_sklib_http_status_code(code);
      __skparam__message = __skadapter__to_sklib_string(message);
      __skparam__content_type = __skadapter__to_sklib_string(contentType);
      __sklib__send_response__http_request__http_status_code__string_ref__string_ref(__skparam__r, __skparam__code, __skparam__message, __skparam__content_type);
    __skadapter__free__sklib_string(ref __skparam__message);
    __skadapter__free__sklib_string(ref __skparam__content_type);
    }
    public static void SendResponse(HttpRequest r, HttpStatusCode code, string message, string contentType, List<string> headers)
    {
      __sklib_ptr __skparam__r;
      int __skparam__code;
      __sklib_string __skparam__message;
      __sklib_string __skparam__content_type;
      __sklib_vector_string __skparam__headers;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__code = __skadapter__to_sklib_http_status_code(code);
      __skparam__message = __skadapter__to_sklib_string(message);
      __skparam__content_type = __skadapter__to_sklib_string(contentType);
      __skparam__headers = __skadapter__to_sklib_vector_string(headers);
      __sklib__send_response__http_request__http_status_code__string_ref__string_ref__vector_string_ref(__skparam__r, __skparam__code, __skparam__message, __skparam__content_type, __skparam__headers);
    __skadapter__free__sklib_string(ref __skparam__message);
    __skadapter__free__sklib_string(ref __skparam__content_type);
    __skadapter__free__sklib_vector_string(ref __skparam__headers);
    }
    public static void SendResponse(HttpRequest r, Json j)
    {
      __sklib_ptr __skparam__r;
      __sklib_ptr __skparam__j;
      __skparam__r = __skadapter__to_sklib_http_request(r);
      __skparam__j = __skadapter__to_sklib_json(j);
      __sklib__send_response__http_request__json(__skparam__r, __skparam__j);
    }
    public static List<string> SplitURIStubs(string uri)
    {
      __sklib_string __skparam__uri;
      __sklib_vector_string __skreturn;
      __skparam__uri = __skadapter__to_sklib_string(uri);
      __skreturn = __sklib__split_uri_stubs__string_ref(__skparam__uri);
    __skadapter__free__sklib_string(ref __skparam__uri);
      return __skadapter__to_vector_string(__skreturn);
    }
    public static WebServer StartWebServer()
    {
      __sklib_ptr __skreturn;
      __skreturn = __sklib__start_web_server();
      return __skadapter__to_web_server(__skreturn);
    }
    public static WebServer StartWebServer(ushort port)
    {
      ushort __skparam__port;
      __sklib_ptr __skreturn;
      __skparam__port = __skadapter__to_sklib_unsigned_short(port);
      __skreturn = __sklib__start_web_server__unsigned_short(__skparam__port);
      return __skadapter__to_web_server(__skreturn);
    }
    public static void StopWebServer(WebServer server)
    {
      __sklib_ptr __skparam__server;
      __skparam__server = __skadapter__to_sklib_web_server(server);
      __sklib__stop_web_server__web_server(__skparam__server);
    }
    public static void ClearWindow(Window wind, Color clr)
    {
      __sklib_ptr __skparam__wind;
      __sklib_color __skparam__clr;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skparam__clr = __skadapter__to_sklib_color(clr);
      __sklib__clear_window__window__color(__skparam__wind, __skparam__clr);
    }
    public static void CloseAllWindows()
    {
      __sklib__close_all_windows();
    }
    public static void CloseCurrentWindow()
    {
      __sklib__close_current_window();
    }
    public static void CloseWindow(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__close_window__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void CloseWindow(Window wind)
    {
      __sklib_ptr __skparam__wind;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __sklib__close_window__window(__skparam__wind);
    }
    public static Window CurrentWindow()
    {
      __sklib_ptr __skreturn;
      __skreturn = __sklib__current_window();
      return __skadapter__to_window(__skreturn);
    }
    public static bool CurrentWindowHasBorder()
    {
      int __skreturn;
      __skreturn = __sklib__current_window_has_border();
      return __skadapter__to_bool(__skreturn);
    }
    public static int CurrentWindowHeight()
    {
      int __skreturn;
      __skreturn = __sklib__current_window_height();
      return __skadapter__to_int(__skreturn);
    }
    public static bool CurrentWindowIsFullscreen()
    {
      int __skreturn;
      __skreturn = __sklib__current_window_is_fullscreen();
      return __skadapter__to_bool(__skreturn);
    }
    public static Point2D CurrentWindowPosition()
    {
      __sklib_point_2d __skreturn;
      __skreturn = __sklib__current_window_position();
      return __skadapter__to_point_2d(__skreturn);
    }
    public static void CurrentWindowToggleBorder()
    {
      __sklib__current_window_toggle_border();
    }
    public static void CurrentWindowToggleFullscreen()
    {
      __sklib__current_window_toggle_fullscreen();
    }
    public static int CurrentWindowWidth()
    {
      int __skreturn;
      __skreturn = __sklib__current_window_width();
      return __skadapter__to_int(__skreturn);
    }
    public static int CurrentWindowX()
    {
      int __skreturn;
      __skreturn = __sklib__current_window_x();
      return __skadapter__to_int(__skreturn);
    }
    public static int CurrentWindowY()
    {
      int __skreturn;
      __skreturn = __sklib__current_window_y();
      return __skadapter__to_int(__skreturn);
    }
    public static bool HasWindow(string caption)
    {
      __sklib_string __skparam__caption;
      int __skreturn;
      __skparam__caption = __skadapter__to_sklib_string(caption);
      __skreturn = __sklib__has_window__string(__skparam__caption);
    __skadapter__free__sklib_string(ref __skparam__caption);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool IsCurrentWindow(Window wind)
    {
      __sklib_ptr __skparam__wind;
      int __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skreturn = __sklib__is_current_window__window(__skparam__wind);
      return __skadapter__to_bool(__skreturn);
    }
    public static void MoveCurrentWindowTo(int x, int y)
    {
      int __skparam__x;
      int __skparam__y;
      __skparam__x = __skadapter__to_sklib_int(x);
      __skparam__y = __skadapter__to_sklib_int(y);
      __sklib__move_current_window_to__int__int(__skparam__x, __skparam__y);
    }
    public static void MoveWindowTo(string name, int x, int y)
    {
      __sklib_string __skparam__name;
      int __skparam__x;
      int __skparam__y;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skparam__x = __skadapter__to_sklib_int(x);
      __skparam__y = __skadapter__to_sklib_int(y);
      __sklib__move_window_to__string_ref__int__int(__skparam__name, __skparam__x, __skparam__y);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void MoveWindowTo(Window wind, int x, int y)
    {
      __sklib_ptr __skparam__wind;
      int __skparam__x;
      int __skparam__y;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skparam__x = __skadapter__to_sklib_int(x);
      __skparam__y = __skadapter__to_sklib_int(y);
      __sklib__move_window_to__window__int__int(__skparam__wind, __skparam__x, __skparam__y);
    }
    public static Window OpenWindow(string caption, int width, int height)
    {
      __sklib_string __skparam__caption;
      int __skparam__width;
      int __skparam__height;
      __sklib_ptr __skreturn;
      __skparam__caption = __skadapter__to_sklib_string(caption);
      __skparam__width = __skadapter__to_sklib_int(width);
      __skparam__height = __skadapter__to_sklib_int(height);
      __skreturn = __sklib__open_window__string__int__int(__skparam__caption, __skparam__width, __skparam__height);
    __skadapter__free__sklib_string(ref __skparam__caption);
      return __skadapter__to_window(__skreturn);
    }
    public static void RefreshWindow(Window wind)
    {
      __sklib_ptr __skparam__wind;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __sklib__refresh_window__window(__skparam__wind);
    }
    public static void RefreshWindow(Window wind, uint targetFps)
    {
      __sklib_ptr __skparam__wind;
      uint __skparam__target_fps;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skparam__target_fps = __skadapter__to_sklib_unsigned_int(targetFps);
      __sklib__refresh_window__window__unsigned_int(__skparam__wind, __skparam__target_fps);
    }
    public static void ResizeCurrentWindow(int width, int height)
    {
      int __skparam__width;
      int __skparam__height;
      __skparam__width = __skadapter__to_sklib_int(width);
      __skparam__height = __skadapter__to_sklib_int(height);
      __sklib__resize_current_window__int__int(__skparam__width, __skparam__height);
    }
    public static void ResizeWindow(Window wnd, int width, int height)
    {
      __sklib_ptr __skparam__wnd;
      int __skparam__width;
      int __skparam__height;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skparam__width = __skadapter__to_sklib_int(width);
      __skparam__height = __skadapter__to_sklib_int(height);
      __sklib__resize_window__window__int__int(__skparam__wnd, __skparam__width, __skparam__height);
    }
    public static void SetCurrentWindow(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__set_current_window__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void SetCurrentWindow(Window wind)
    {
      __sklib_ptr __skparam__wind;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __sklib__set_current_window__window(__skparam__wind);
    }
    public static string WindowCaption(Window wind)
    {
      __sklib_ptr __skparam__wind;
      __sklib_string __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skreturn = __sklib__window_caption__window(__skparam__wind);
      return __skadapter__to_string(__skreturn);
    }
    public static bool WindowCloseRequested(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__window_close_requested__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool WindowCloseRequested(Window wind)
    {
      __sklib_ptr __skparam__wind;
      int __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skreturn = __sklib__window_close_requested__window(__skparam__wind);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool WindowHasBorder(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__window_has_border__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool WindowHasBorder(Window wnd)
    {
      __sklib_ptr __skparam__wnd;
      int __skreturn;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skreturn = __sklib__window_has_border__window(__skparam__wnd);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool WindowHasFocus(Window wind)
    {
      __sklib_ptr __skparam__wind;
      int __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skreturn = __sklib__window_has_focus__window(__skparam__wind);
      return __skadapter__to_bool(__skreturn);
    }
    public static int WindowHeight(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__window_height__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static int WindowHeight(Window wind)
    {
      __sklib_ptr __skparam__wind;
      int __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skreturn = __sklib__window_height__window(__skparam__wind);
      return __skadapter__to_int(__skreturn);
    }
    public static bool WindowIsFullscreen(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__window_is_fullscreen__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_bool(__skreturn);
    }
    public static bool WindowIsFullscreen(Window wnd)
    {
      __sklib_ptr __skparam__wnd;
      int __skreturn;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skreturn = __sklib__window_is_fullscreen__window(__skparam__wnd);
      return __skadapter__to_bool(__skreturn);
    }
    public static Window WindowNamed(string caption)
    {
      __sklib_string __skparam__caption;
      __sklib_ptr __skreturn;
      __skparam__caption = __skadapter__to_sklib_string(caption);
      __skreturn = __sklib__window_named__string(__skparam__caption);
    __skadapter__free__sklib_string(ref __skparam__caption);
      return __skadapter__to_window(__skreturn);
    }
    public static Point2D WindowPosition(string name)
    {
      __sklib_string __skparam__name;
      __sklib_point_2d __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__window_position__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static Point2D WindowPosition(Window wnd)
    {
      __sklib_ptr __skparam__wnd;
      __sklib_point_2d __skreturn;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skreturn = __sklib__window_position__window(__skparam__wnd);
      return __skadapter__to_point_2d(__skreturn);
    }
    public static void WindowSetIcon(Window wind, Bitmap bmp)
    {
      __sklib_ptr __skparam__wind;
      __sklib_ptr __skparam__bmp;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skparam__bmp = __skadapter__to_sklib_bitmap(bmp);
      __sklib__window_set_icon__window__bitmap(__skparam__wind, __skparam__bmp);
    }
    public static void WindowToggleBorder(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__window_toggle_border__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void WindowToggleBorder(Window wnd)
    {
      __sklib_ptr __skparam__wnd;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __sklib__window_toggle_border__window(__skparam__wnd);
    }
    public static void WindowToggleFullscreen(string name)
    {
      __sklib_string __skparam__name;
      __skparam__name = __skadapter__to_sklib_string(name);
      __sklib__window_toggle_fullscreen__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
    }
    public static void WindowToggleFullscreen(Window wnd)
    {
      __sklib_ptr __skparam__wnd;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __sklib__window_toggle_fullscreen__window(__skparam__wnd);
    }
    public static int WindowWidth(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__window_width__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static int WindowWidth(Window wind)
    {
      __sklib_ptr __skparam__wind;
      int __skreturn;
      __skparam__wind = __skadapter__to_sklib_window(wind);
      __skreturn = __sklib__window_width__window(__skparam__wind);
      return __skadapter__to_int(__skreturn);
    }
    public static Window WindowWithFocus()
    {
      __sklib_ptr __skreturn;
      __skreturn = __sklib__window_with_focus();
      return __skadapter__to_window(__skreturn);
    }
    public static int WindowX(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__window_x__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static int WindowX(Window wnd)
    {
      __sklib_ptr __skparam__wnd;
      int __skreturn;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skreturn = __sklib__window_x__window(__skparam__wnd);
      return __skadapter__to_int(__skreturn);
    }
    public static int WindowY(string name)
    {
      __sklib_string __skparam__name;
      int __skreturn;
      __skparam__name = __skadapter__to_sklib_string(name);
      __skreturn = __sklib__window_y__string_ref(__skparam__name);
    __skadapter__free__sklib_string(ref __skparam__name);
      return __skadapter__to_int(__skreturn);
    }
    public static int WindowY(Window wnd)
    {
      __sklib_ptr __skparam__wnd;
      int __skreturn;
      __skparam__wnd = __skadapter__to_sklib_window(wnd);
      __skreturn = __sklib__window_y__window(__skparam__wnd);
      return __skadapter__to_int(__skreturn);
    }
  }

    public enum KeyCode
  {
    UnknownKey = 0,
    BackspaceKey = 8,
    TabKey = 9,
    ClearKey = 12,
    ReturnKey = 13,
    PauseKey = 19,
    EscapeKey = 27,
    SpaceKey = 32,
    ExclaimKey = 33,
    DoubleQuoteKey = 34,
    HashKey = 35,
    DollarKey = 36,
    AmpersandKey = 38,
    QuoteKey = 39,
    LeftParenKey = 40,
    RightParenKey = 41,
    AsteriskKey = 42,
    PlusKey = 43,
    CommaKey = 44,
    MinusKey = 45,
    PeriodKey = 46,
    SlashKey = 47,
    Num0Key = 48,
    Num1Key = 49,
    Num2Key = 50,
    Num3Key = 51,
    Num4Key = 52,
    Num5Key = 53,
    Num6Key = 54,
    Num7Key = 55,
    Num8Key = 56,
    Num9Key = 57,
    ColonKey = 58,
    SemiColonKey = 59,
    LessKey = 60,
    EqualsKey = 61,
    GreaterKey = 62,
    QuestionKey = 63,
    AtKey = 64,
    LeftBracketKey = 91,
    BackslashKey = 92,
    RightBracketKey = 93,
    CaretKey = 94,
    UnderscoreKey = 95,
    BackquoteKey = 96,
    AKey = 97,
    BKey = 98,
    CKey = 99,
    DKey = 100,
    EKey = 101,
    FKey = 102,
    GKey = 103,
    HKey = 104,
    IKey = 105,
    JKey = 106,
    KKey = 107,
    LKey = 108,
    MKey = 109,
    NKey = 110,
    OKey = 111,
    PKey = 112,
    QKey = 113,
    RKey = 114,
    SKey = 115,
    TKey = 116,
    UKey = 117,
    VKey = 118,
    WKey = 119,
    XKey = 120,
    YKey = 121,
    ZKey = 122,
    DeleteKey = 127,
    Keypad0 = 256,
    Keypad1 = 257,
    Keypad2 = 258,
    Keypad3 = 259,
    Keypad4 = 260,
    Keypad5 = 261,
    Keypad6 = 262,
    Keypad7 = 263,
    Keypad8 = 264,
    Keypad9 = 265,
    KeypadPeriod = 266,
    KeypadDivide = 267,
    KeypadMultiply = 268,
    KeypadMinus = 269,
    KeypadPlus = 270,
    KeypadEnter = 271,
    KeypadEquals = 272,
    UpKey = 273,
    DownKey = 274,
    RightKey = 275,
    LeftKey = 276,
    InsertKey = 277,
    HomeKey = 278,
    EndKey = 279,
    PageUpKey = 280,
    PageDownKey = 281,
    F1Key = 282,
    F2Key = 283,
    F3Key = 284,
    F4Key = 285,
    F5Key = 286,
    F6Key = 287,
    F7Key = 288,
    F8Key = 289,
    F9Key = 290,
    F10Key = 291,
    F11Key = 292,
    F12Key = 293,
    F13Key = 294,
    F14Key = 295,
    F15Key = 296,
    NumLockKey = 300,
    CapsLockKey = 301,
    ScrollLockKey = 302,
    RightShiftKey = 303,
    LeftShiftKey = 304,
    RightCtrlKey = 305,
    LeftCtrlKey = 306,
    RightAltKey = 307,
    LeftAltKey = 308,
    LeftSuperKey = 311,
    RightSuperKey = 312,
    ModeKey = 313,
    HelpKey = 315,
    SysReqKey = 317,
    MenuKey = 319,
    PowerKey = 320
  }
  public enum LogLevel
  {
    None,
    Info,
    Debug,
    Warning,
    Error,
    Fatal
  }
  public enum LogMode
  {
    LogNone,
    LogConsole,
    LogFileOnly,
    LogConsoleAndFile
  }
  public enum MouseButton
  {
    NoButton,
    LeftButton,
    MiddleButton,
    RightButton,
    MouseX1Button,
    MouseX2Button
  }
  public enum ConnectionType
  {
    TCP,
    UDP,
    Unknown
  }
  public enum ResourceKind
  {
    AnimationResource,
    BundleResource,
    FontResource,
    ImageResource,
    JsonResource,
    MusicResource,
    ServerResource,
    SoundResource,
    TimerResource,
    OtherResource
  }
  public enum CollisionTestKind
  {
    PixelCollisions,
    AabbCollisions
  }
  public enum SpriteEventKind
  {
    SpriteArrivedEvent,
    SpriteAnimationEndedEvent,
    SpriteTouchedEvent,
    SpriteClickedEvent
  }
  public enum DrawingDest
  {
    DrawToScreen,
    DrawToWorld,
    DrawDefault
  }
  public enum FontStyle
  {
    NormalFont = 0,
    BoldFont = 1,
    ItalicFont = 2,
    UnderlineFont = 4
  }
  public enum HttpStatusCode
  {
    HttpStatusOk = 200,
    HttpStatusCreated = 201,
    HttpStatusNoContent = 204,
    HttpStatusMovedPermanently = 301,
    HttpStatusFound = 302,
    HttpStatusSeeOther = 303,
    HttpStatusBadRequest = 400,
    HttpStatusUnauthorized = 401,
    HttpStatusForbidden = 403,
    HttpStatusNotFound = 404,
    HttpStatusMethodNotAllowed = 405,
    HttpStatusRequestTimeout = 408,
    HttpStatusConflict = 409,
    HttpStatusInternalServerError = 500,
    HttpStatusNotImplemented = 501,
    HttpStatusServiceUnavailable = 503
  }
  public enum InterfaceStyle
  {
    FlatDarkStyle = 0,
    ShadedDarkStyle = 1,
    FlatLightStyle = 2,
    ShadedLightStyle = 3,
    Bubble = 4,
    BubbleMulticolored = 5
  }
  public enum PinModes
  {
    GpioInput = 0,
    GpioOutput = 1,
    GpioAlt0 = 4,
    GpioAlt1 = 5,
    GpioAlt2 = 6,
    GpioAlt3 = 7,
    GpioAlt4 = 3,
    GpioAlt5 = 2,
    GpioDefaultMode = 1
  }
  public enum PinValues
  {
    GpioLow = 0,
    GpioHigh = 1,
    GpioDefaultValue = 1
  }
  public enum Pins
  {
    Pin1 = 1,
    Pin2 = 2,
    Pin3 = 3,
    Pin4 = 4,
    Pin5 = 5,
    Pin6 = 6,
    Pin7 = 7,
    Pin8 = 8,
    Pin9 = 9,
    Pin10 = 10,
    Pin11 = 11,
    Pin12 = 12,
    Pin13 = 13,
    Pin14 = 14,
    Pin15 = 15,
    Pin16 = 16,
    Pin17 = 17,
    Pin18 = 18,
    Pin19 = 19,
    Pin20 = 20,
    Pin21 = 21,
    Pin22 = 22,
    Pin23 = 23,
    Pin24 = 24,
    Pin25 = 25,
    Pin26 = 26,
    Pin27 = 27,
    Pin28 = 28,
    Pin29 = 29,
    Pin30 = 30,
    Pin31 = 31,
    Pin32 = 32,
    Pin33 = 33,
    Pin34 = 34,
    Pin35 = 35,
    Pin36 = 36,
    Pin37 = 37,
    Pin38 = 38,
    Pin39 = 39,
    Pin40 = 40
  }
  public enum PullUpDown
  {
    PudOff = 0,
    PudDown = 1,
    PudUp = 2
  }
  public enum HttpMethod
  {
    HttpGetMethod,
    HttpPostMethod,
    HttpPutMethod,
    HttpDeleteMethod,
    HttpOptionsMethod,
    HttpTraceMethod,
    UnknownHttpMethod
  }

  [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi ) ]
  internal struct __sklib_matrix_2d
  {
    // Unpacking array due to C# Marshalling limitations
    public double Elements_0;
    public double Elements_1;
    public double Elements_2;
    public double Elements_3;
    public double Elements_4;
    public double Elements_5;
    public double Elements_6;
    public double Elements_7;
    public double Elements_8;

  }

  public struct Matrix2D
  {
    public double[,] Elements;
  }

  [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi ) ]
  internal struct __sklib_point_2d
  {
    public double X;
    public double Y;

  }

  public struct Point2D
  {
    public double X;
    public double Y;
  }

  [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi ) ]
  internal struct __sklib_circle
  {
    public __sklib_point_2d Center;
    public double Radius;

  }

  public struct Circle
  {
    public Point2D Center;
    public double Radius;

    public void Draw(Color clr)
    {
        SplashKit.DrawCircle(clr, this);
    }


    public void Draw(Color clr, DrawingOptions opts)
    {
        SplashKit.DrawCircle(clr, this, opts);
    }


    public void Fill(Color clr)
    {
        SplashKit.FillCircle(clr, this);
    }


    public void Fill(Color clr, DrawingOptions opts)
    {
        SplashKit.FillCircle(clr, this, opts);
    }

  }

  [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi ) ]
  internal struct __sklib_color
  {
    public float R;
    public float G;
    public float B;
    public float A;

  }

  public struct Color
  {
    public float R;
    public float G;
    public float B;
    public float A;

    public static Color HSBColor(double hue, double saturation, double brightness)
    {
        return SplashKit.HSBColor(hue, saturation, brightness);
    }


    public static Color Random()
    {
        return SplashKit.RandomColor();
    }


    public static Color RandomRGB(int alpha)
    {
        return SplashKit.RandomRGBColor(alpha);
    }


    public static Color RGBColor(double red, double green, double blue)
    {
        return SplashKit.RGBColor(red, green, blue);
    }


    public static Color RGBColor(int red, int green, int blue)
    {
        return SplashKit.RGBColor(red, green, blue);
    }


    public static Color RGBAColor(double red, double green, double blue, double alpha)
    {
        return SplashKit.RGBAColor(red, green, blue, alpha);
    }


    public static Color RGBAColor(int red, int green, int blue, int alpha)
    {
        return SplashKit.RGBAColor(red, green, blue, alpha);
    }

    public static Color AliceBlue
    {
        get { return SplashKit.ColorAliceBlue(); }
    }
    public static Color AntiqueWhite
    {
        get { return SplashKit.ColorAntiqueWhite(); }
    }
    public static Color Aqua
    {
        get { return SplashKit.ColorAqua(); }
    }
    public static Color Aquamarine
    {
        get { return SplashKit.ColorAquamarine(); }
    }
    public static Color Azure
    {
        get { return SplashKit.ColorAzure(); }
    }
    public static Color Beige
    {
        get { return SplashKit.ColorBeige(); }
    }
    public static Color Bisque
    {
        get { return SplashKit.ColorBisque(); }
    }
    public static Color Black
    {
        get { return SplashKit.ColorBlack(); }
    }
    public static Color BlanchedAlmond
    {
        get { return SplashKit.ColorBlanchedAlmond(); }
    }
    public static Color Blue
    {
        get { return SplashKit.ColorBlue(); }
    }
    public static Color BlueViolet
    {
        get { return SplashKit.ColorBlueViolet(); }
    }
    public static Color BrightGreen
    {
        get { return SplashKit.ColorBrightGreen(); }
    }
    public static Color Brown
    {
        get { return SplashKit.ColorBrown(); }
    }
    public static Color BurlyWood
    {
        get { return SplashKit.ColorBurlyWood(); }
    }
    public static Color CadetBlue
    {
        get { return SplashKit.ColorCadetBlue(); }
    }
    public static Color Chartreuse
    {
        get { return SplashKit.ColorChartreuse(); }
    }
    public static Color Chocolate
    {
        get { return SplashKit.ColorChocolate(); }
    }
    public static Color Coral
    {
        get { return SplashKit.ColorCoral(); }
    }
    public static Color CornflowerBlue
    {
        get { return SplashKit.ColorCornflowerBlue(); }
    }
    public static Color Cornsilk
    {
        get { return SplashKit.ColorCornsilk(); }
    }
    public static Color Crimson
    {
        get { return SplashKit.ColorCrimson(); }
    }
    public static Color Cyan
    {
        get { return SplashKit.ColorCyan(); }
    }
    public static Color DarkBlue
    {
        get { return SplashKit.ColorDarkBlue(); }
    }
    public static Color DarkCyan
    {
        get { return SplashKit.ColorDarkCyan(); }
    }
    public static Color DarkGoldenrod
    {
        get { return SplashKit.ColorDarkGoldenrod(); }
    }
    public static Color DarkGray
    {
        get { return SplashKit.ColorDarkGray(); }
    }
    public static Color DarkGreen
    {
        get { return SplashKit.ColorDarkGreen(); }
    }
    public static Color DarkKhaki
    {
        get { return SplashKit.ColorDarkKhaki(); }
    }
    public static Color DarkMagenta
    {
        get { return SplashKit.ColorDarkMagenta(); }
    }
    public static Color DarkOliveGreen
    {
        get { return SplashKit.ColorDarkOliveGreen(); }
    }
    public static Color DarkOrange
    {
        get { return SplashKit.ColorDarkOrange(); }
    }
    public static Color DarkOrchid
    {
        get { return SplashKit.ColorDarkOrchid(); }
    }
    public static Color DarkRed
    {
        get { return SplashKit.ColorDarkRed(); }
    }
    public static Color DarkSalmon
    {
        get { return SplashKit.ColorDarkSalmon(); }
    }
    public static Color DarkSeaGreen
    {
        get { return SplashKit.ColorDarkSeaGreen(); }
    }
    public static Color DarkSlateBlue
    {
        get { return SplashKit.ColorDarkSlateBlue(); }
    }
    public static Color DarkSlateGray
    {
        get { return SplashKit.ColorDarkSlateGray(); }
    }
    public static Color DarkTurquoise
    {
        get { return SplashKit.ColorDarkTurquoise(); }
    }
    public static Color DarkViolet
    {
        get { return SplashKit.ColorDarkViolet(); }
    }
    public static Color DeepPink
    {
        get { return SplashKit.ColorDeepPink(); }
    }
    public static Color DeepSkyBlue
    {
        get { return SplashKit.ColorDeepSkyBlue(); }
    }
    public static Color DimGray
    {
        get { return SplashKit.ColorDimGray(); }
    }
    public static Color DodgerBlue
    {
        get { return SplashKit.ColorDodgerBlue(); }
    }
    public static Color Firebrick
    {
        get { return SplashKit.ColorFirebrick(); }
    }
    public static Color FloralWhite
    {
        get { return SplashKit.ColorFloralWhite(); }
    }
    public static Color ForestGreen
    {
        get { return SplashKit.ColorForestGreen(); }
    }
    public static Color Fuchsia
    {
        get { return SplashKit.ColorFuchsia(); }
    }
    public static Color Gainsboro
    {
        get { return SplashKit.ColorGainsboro(); }
    }
    public static Color GhostWhite
    {
        get { return SplashKit.ColorGhostWhite(); }
    }
    public static Color Gold
    {
        get { return SplashKit.ColorGold(); }
    }
    public static Color Goldenrod
    {
        get { return SplashKit.ColorGoldenrod(); }
    }
    public static Color Gray
    {
        get { return SplashKit.ColorGray(); }
    }
    public static Color Green
    {
        get { return SplashKit.ColorGreen(); }
    }
    public static Color GreenYellow
    {
        get { return SplashKit.ColorGreenYellow(); }
    }
    public static Color Honeydew
    {
        get { return SplashKit.ColorHoneydew(); }
    }
    public static Color HotPink
    {
        get { return SplashKit.ColorHotPink(); }
    }
    public static Color IndianRed
    {
        get { return SplashKit.ColorIndianRed(); }
    }
    public static Color Indigo
    {
        get { return SplashKit.ColorIndigo(); }
    }
    public static Color Ivory
    {
        get { return SplashKit.ColorIvory(); }
    }
    public static Color Khaki
    {
        get { return SplashKit.ColorKhaki(); }
    }
    public static Color Lavender
    {
        get { return SplashKit.ColorLavender(); }
    }
    public static Color LavenderBlush
    {
        get { return SplashKit.ColorLavenderBlush(); }
    }
    public static Color LawnGreen
    {
        get { return SplashKit.ColorLawnGreen(); }
    }
    public static Color LemonChiffon
    {
        get { return SplashKit.ColorLemonChiffon(); }
    }
    public static Color LightBlue
    {
        get { return SplashKit.ColorLightBlue(); }
    }
    public static Color LightCoral
    {
        get { return SplashKit.ColorLightCoral(); }
    }
    public static Color LightCyan
    {
        get { return SplashKit.ColorLightCyan(); }
    }
    public static Color LightGoldenrodYellow
    {
        get { return SplashKit.ColorLightGoldenrodYellow(); }
    }
    public static Color LightGray
    {
        get { return SplashKit.ColorLightGray(); }
    }
    public static Color LightGreen
    {
        get { return SplashKit.ColorLightGreen(); }
    }
    public static Color LightPink
    {
        get { return SplashKit.ColorLightPink(); }
    }
    public static Color LightSalmon
    {
        get { return SplashKit.ColorLightSalmon(); }
    }
    public static Color LightSeaGreen
    {
        get { return SplashKit.ColorLightSeaGreen(); }
    }
    public static Color LightSkyBlue
    {
        get { return SplashKit.ColorLightSkyBlue(); }
    }
    public static Color LightSlateGray
    {
        get { return SplashKit.ColorLightSlateGray(); }
    }
    public static Color LightSteelBlue
    {
        get { return SplashKit.ColorLightSteelBlue(); }
    }
    public static Color LightYellow
    {
        get { return SplashKit.ColorLightYellow(); }
    }
    public static Color Lime
    {
        get { return SplashKit.ColorLime(); }
    }
    public static Color LimeGreen
    {
        get { return SplashKit.ColorLimeGreen(); }
    }
    public static Color Linen
    {
        get { return SplashKit.ColorLinen(); }
    }
    public static Color Magenta
    {
        get { return SplashKit.ColorMagenta(); }
    }
    public static Color Maroon
    {
        get { return SplashKit.ColorMaroon(); }
    }
    public static Color MediumAquamarine
    {
        get { return SplashKit.ColorMediumAquamarine(); }
    }
    public static Color MediumBlue
    {
        get { return SplashKit.ColorMediumBlue(); }
    }
    public static Color MediumOrchid
    {
        get { return SplashKit.ColorMediumOrchid(); }
    }
    public static Color MediumPurple
    {
        get { return SplashKit.ColorMediumPurple(); }
    }
    public static Color MediumSeaGreen
    {
        get { return SplashKit.ColorMediumSeaGreen(); }
    }
    public static Color MediumSlateBlue
    {
        get { return SplashKit.ColorMediumSlateBlue(); }
    }
    public static Color MediumSpringGreen
    {
        get { return SplashKit.ColorMediumSpringGreen(); }
    }
    public static Color MediumTurquoise
    {
        get { return SplashKit.ColorMediumTurquoise(); }
    }
    public static Color MediumVioletRed
    {
        get { return SplashKit.ColorMediumVioletRed(); }
    }
    public static Color MidnightBlue
    {
        get { return SplashKit.ColorMidnightBlue(); }
    }
    public static Color MintCream
    {
        get { return SplashKit.ColorMintCream(); }
    }
    public static Color MistyRose
    {
        get { return SplashKit.ColorMistyRose(); }
    }
    public static Color Moccasin
    {
        get { return SplashKit.ColorMoccasin(); }
    }
    public static Color NavajoWhite
    {
        get { return SplashKit.ColorNavajoWhite(); }
    }
    public static Color Navy
    {
        get { return SplashKit.ColorNavy(); }
    }
    public static Color OldLace
    {
        get { return SplashKit.ColorOldLace(); }
    }
    public static Color Olive
    {
        get { return SplashKit.ColorOlive(); }
    }
    public static Color OliveDrab
    {
        get { return SplashKit.ColorOliveDrab(); }
    }
    public static Color Orange
    {
        get { return SplashKit.ColorOrange(); }
    }
    public static Color OrangeRed
    {
        get { return SplashKit.ColorOrangeRed(); }
    }
    public static Color Orchid
    {
        get { return SplashKit.ColorOrchid(); }
    }
    public static Color PaleGoldenrod
    {
        get { return SplashKit.ColorPaleGoldenrod(); }
    }
    public static Color PaleGreen
    {
        get { return SplashKit.ColorPaleGreen(); }
    }
    public static Color PaleTurquoise
    {
        get { return SplashKit.ColorPaleTurquoise(); }
    }
    public static Color PaleVioletRed
    {
        get { return SplashKit.ColorPaleVioletRed(); }
    }
    public static Color PapayaWhip
    {
        get { return SplashKit.ColorPapayaWhip(); }
    }
    public static Color PeachPuff
    {
        get { return SplashKit.ColorPeachPuff(); }
    }
    public static Color Peru
    {
        get { return SplashKit.ColorPeru(); }
    }
    public static Color Pink
    {
        get { return SplashKit.ColorPink(); }
    }
    public static Color Plum
    {
        get { return SplashKit.ColorPlum(); }
    }
    public static Color PowderBlue
    {
        get { return SplashKit.ColorPowderBlue(); }
    }
    public static Color Purple
    {
        get { return SplashKit.ColorPurple(); }
    }
    public static Color Red
    {
        get { return SplashKit.ColorRed(); }
    }
    public static Color RosyBrown
    {
        get { return SplashKit.ColorRosyBrown(); }
    }
    public static Color RoyalBlue
    {
        get { return SplashKit.ColorRoyalBlue(); }
    }
    public static Color SaddleBrown
    {
        get { return SplashKit.ColorSaddleBrown(); }
    }
    public static Color Salmon
    {
        get { return SplashKit.ColorSalmon(); }
    }
    public static Color SandyBrown
    {
        get { return SplashKit.ColorSandyBrown(); }
    }
    public static Color SeaGreen
    {
        get { return SplashKit.ColorSeaGreen(); }
    }
    public static Color SeaShell
    {
        get { return SplashKit.ColorSeaShell(); }
    }
    public static Color Sienna
    {
        get { return SplashKit.ColorSienna(); }
    }
    public static Color Silver
    {
        get { return SplashKit.ColorSilver(); }
    }
    public static Color SkyBlue
    {
        get { return SplashKit.ColorSkyBlue(); }
    }
    public static Color SlateBlue
    {
        get { return SplashKit.ColorSlateBlue(); }
    }
    public static Color SlateGray
    {
        get { return SplashKit.ColorSlateGray(); }
    }
    public static Color Snow
    {
        get { return SplashKit.ColorSnow(); }
    }
    public static Color SpringGreen
    {
        get { return SplashKit.ColorSpringGreen(); }
    }
    public static Color SteelBlue
    {
        get { return SplashKit.ColorSteelBlue(); }
    }
    public static Color SwinburneRed
    {
        get { return SplashKit.ColorSwinburneRed(); }
    }
    public static Color Tan
    {
        get { return SplashKit.ColorTan(); }
    }
    public static Color Teal
    {
        get { return SplashKit.ColorTeal(); }
    }
    public static Color Thistle
    {
        get { return SplashKit.ColorThistle(); }
    }
    public static Color Tomato
    {
        get { return SplashKit.ColorTomato(); }
    }
    public static Color Transparent
    {
        get { return SplashKit.ColorTransparent(); }
    }
    public static Color Turquoise
    {
        get { return SplashKit.ColorTurquoise(); }
    }
    public static Color Violet
    {
        get { return SplashKit.ColorViolet(); }
    }
    public static Color Wheat
    {
        get { return SplashKit.ColorWheat(); }
    }
    public static Color White
    {
        get { return SplashKit.ColorWhite(); }
    }
    public static Color WhiteSmoke
    {
        get { return SplashKit.ColorWhiteSmoke(); }
    }
    public static Color Yellow
    {
        get { return SplashKit.ColorYellow(); }
    }
    public static Color YellowGreen
    {
        get { return SplashKit.ColorYellowGreen(); }
    }
  }

  [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi ) ]
  internal struct __sklib_rectangle
  {
    public double X;
    public double Y;
    public double Width;
    public double Height;

  }

  public struct Rectangle
  {
    public double X;
    public double Y;
    public double Width;
    public double Height;
  }

  [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi ) ]
  internal struct __sklib_drawing_options
  {
    public IntPtr Dest;
    public float ScaleX;
    public float ScaleY;
    public float Angle;
    public float AnchorOffsetX;
    public float AnchorOffsetY;
    public int FlipX;
    public int FlipY;
    public int IsPart;
    public __sklib_rectangle Part;
    public int DrawCell;
    public int Camera;
    public int LineWidth;
    public __sklib_ptr Anim;

  }

  public struct DrawingOptions
  {
    public IntPtr Dest;
    public float ScaleX;
    public float ScaleY;
    public float Angle;
    public float AnchorOffsetX;
    public float AnchorOffsetY;
    public bool FlipX;
    public bool FlipY;
    public bool IsPart;
    public Rectangle Part;
    public int DrawCell;
    public DrawingDest Camera;
    public int LineWidth;
    public Animation Anim;
  }

  [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi ) ]
  internal struct __sklib_line
  {
    public __sklib_point_2d StartPoint;
    public __sklib_point_2d EndPoint;

  }

  public struct Line
  {
    public Point2D StartPoint;
    public Point2D EndPoint;
  }

  [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi ) ]
  internal struct __sklib_quad
  {
    // Unpacking array due to C# Marshalling limitations
    public __sklib_point_2d Points_0;
    public __sklib_point_2d Points_1;
    public __sklib_point_2d Points_2;
    public __sklib_point_2d Points_3;

  }

  public struct Quad
  {
    public Point2D[] Points;
  }

  [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi ) ]
  internal struct __sklib_triangle
  {
    // Unpacking array due to C# Marshalling limitations
    public __sklib_point_2d Points_0;
    public __sklib_point_2d Points_1;
    public __sklib_point_2d Points_2;

  }

  public struct Triangle
  {
    public Point2D[] Points;
  }

  [ StructLayout( LayoutKind.Sequential, CharSet=CharSet.Ansi ) ]
  internal struct __sklib_vector_2d
  {
    public double X;
    public double Y;

  }

  public struct Vector2D
  {
    public double X;
    public double Y;
  }

    [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
    public delegate void KeyCallback(int code);

    [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
    public delegate void FreeNotifier(IntPtr pointer);

    [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
    public delegate void SpriteEventHandler(IntPtr s, int evt);

    [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
    public delegate void SpriteFloatFunction(IntPtr s, float f);

    [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
    public delegate void SpriteFunction(IntPtr s);
//----------------------------------------------------------------------------
// PointerWrapper.cs
//----------------------------------------------------------------------------
//
//  Contains code used by the SplashKit resources.
//
//----------------------------------------------------------------------------

    /// <summary>
    /// Wraps a pointer to a SplashKit resource
    /// </summary>
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public abstract class PointerWrapper : IDisposable
    {
        /// <summary>
        /// The ptrRegistry is responsible for maintaining copies of all wrapped SplashKit pointers.
        /// </summary>
        protected static readonly Dictionary<IntPtr, PointerWrapper> _ptrRegister;

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        internal static void Remove(IntPtr ptr)
        {
            // System.Console.WriteLine("Delete {0}", ptr);
            if (_ptrRegister.ContainsKey(ptr))
            {
                _ptrRegister.Remove(ptr);
            }
        }

        private static FreeNotifier _RemoveMethod = PointerWrapper.Remove;

        static PointerWrapper()
        {
            //Register Remove with SplashKit
            //Console.WriteLine("Registering");
            _ptrRegister = new Dictionary<IntPtr, PointerWrapper>();
            SplashKit.RegisterFreeNotifier(_RemoveMethod);
        }

        /// <summary>
        /// "Super Dodgy" (but correct) work around for the fact that C# has no unload methods for classes.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        internal class ReleaserClass
        {
            ~ReleaserClass()
            {
                //Console.WriteLine("Deregistering");
                SplashKit.DeregisterFreeNotifier(_RemoveMethod);
            }
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        internal static ReleaserClass releaser = new ReleaserClass();

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected internal IntPtr Pointer;

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected internal abstract void DoFree();

        [System.Diagnostics.DebuggerNonUserCode(), System.Diagnostics.DebuggerStepThrough(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        internal PointerWrapper(IntPtr ptr, bool register)
        {
            Pointer = ptr;

            if ( ! register ) return;

            if ( PointerWrapper._ptrRegister.ContainsKey(ptr) ) throw new InvalidOperationException("Error managing resources -- attempting to create/load object twice.");
            PointerWrapper._ptrRegister[ptr] = this;
        }

        protected PointerWrapper(PointerWrapper other)
        {
          Pointer = other.Pointer;
        }

        [System.Diagnostics.DebuggerNonUserCode(), System.Diagnostics.DebuggerStepThrough(),System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static implicit operator IntPtr(PointerWrapper? p)
        {
            if ( p == null ) return IntPtr.Zero;
            else return p.Pointer;
        }

        #region IDisposable Members

        /// <summary>
        /// Clean up the native resources used by this resource.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode(), System.Diagnostics.DebuggerStepThrough()]
        public void Dispose()
        {
            if (PointerWrapper._ptrRegister.ContainsKey(this.Pointer))
                DoFree();
        }

        #endregion

        /// <summary>
        /// Returns a string representation of the resource. This is in the format
        /// "Type @address".
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode(), System.Diagnostics.DebuggerStepThrough()]
        public override String ToString()
        {
            return String.Format("{0} @{1:x}", GetType().Name, Pointer);
        }

        /// <summary>
        /// Determines if the PointerWrappers is equal to the passed in object.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode(), System.Diagnostics.DebuggerStepThrough()]
        public override bool Equals(object? other)
        {
            if (other == null) return this.Pointer == IntPtr.Zero;
            if (other is PointerWrapper) return this.Pointer == ((PointerWrapper)other).Pointer;
            else if (other is IntPtr) return this.Pointer == ((IntPtr)other);
            else return false;
        }

        /// <summary>
        /// Returns the hash code of the PointerWrapper based on what it points to.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode(), System.Diagnostics.DebuggerStepThrough()]
        public override int GetHashCode()
        {
            return this.Pointer.GetHashCode();
        }

        /// <summary>
        /// Determines if two PointerWrappers are equal.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode(), System.Diagnostics.DebuggerStepThrough()]
        public static bool operator ==(PointerWrapper? pw1, PointerWrapper? pw2)
        {
            if ((object?)pw1 == null && (object?)pw2 == null) return true;
            if ((object?)pw1 == null || (object?)pw2 == null) return false;
            return pw1.Pointer == pw2.Pointer;
        }

        /// <summary>
        /// Determines if two PointerWrappers are not equal.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode(), System.Diagnostics.DebuggerStepThrough()]
        public static bool operator !=(PointerWrapper? pw1, PointerWrapper? pw2)
        {
            if ((object?)pw1 == null && (object?)pw2 == null) return false;
            if ((object?)pw1 == null || (object?)pw2 == null) return true;
            return pw1.Pointer != pw2.Pointer;
        }
    }

public class Json : PointerWrapper
{
  private Json(IntPtr ptr) : base(ptr, true) {}

  internal static Json FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as Json;
    #pragma warning restore CS8603
    return new Json(ptr);
  }

    public Json() : base ( SplashKit.CreateJson(), false )
    { }

    public Json(string jsonString) : base ( SplashKit.CreateJson(jsonString), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.FreeJson(this);
    }

    public static void FreeAll()
    {
        SplashKit.FreeAllJson();
    }


    public int CountKeys()
    {
        return SplashKit.JsonCountKeys(this);
    }


    public static Json FromFile(string filename)
    {
        return SplashKit.JsonFromFile(filename);
    }


    public static Json FromJsonString(string jString)
    {
        return SplashKit.JsonFromString(jString);
    }


    public bool HasKey(string key)
    {
        return SplashKit.JsonHasKey(this, key);
    }


    public void ReadArray(string key, ref List<double> outResult)
    {
        SplashKit.JsonReadArray(this, key, ref outResult);
    }


    public void ReadArray(string key, ref List<Json> outResult)
    {
        SplashKit.JsonReadArray(this, key, ref outResult);
    }


    public void ReadArray(string key, ref List<string> outResult)
    {
        SplashKit.JsonReadArray(this, key, ref outResult);
    }


    public void ReadArray(string key, ref List<bool> outResult)
    {
        SplashKit.JsonReadArray(this, key, ref outResult);
    }


    public bool ReadBool(string key)
    {
        return SplashKit.JsonReadBool(this, key);
    }


    public float ReadNumber(string key)
    {
        return SplashKit.JsonReadNumber(this, key);
    }


    public double ReadDouble(string key)
    {
        return SplashKit.JsonReadNumberAsDouble(this, key);
    }


    public int ReadInteger(string key)
    {
        return SplashKit.JsonReadNumberAsInt(this, key);
    }


    public Json ReadObject(string key)
    {
        return SplashKit.JsonReadObject(this, key);
    }


    public string ReadString(string key)
    {
        return SplashKit.JsonReadString(this, key);
    }


    public void AddArray(string key, List<string> value)
    {
        SplashKit.JsonSetArray(this, key, value);
    }


    public void AddArray(string key, List<double> value)
    {
        SplashKit.JsonSetArray(this, key, value);
    }


    public void AddArray(string key, List<bool> value)
    {
        SplashKit.JsonSetArray(this, key, value);
    }


    public void AddArray(string key, List<Json> value)
    {
        SplashKit.JsonSetArray(this, key, value);
    }


    public void AddBool(string key, bool value)
    {
        SplashKit.JsonSetBool(this, key, value);
    }


    public void AddNumber(string key, int value)
    {
        SplashKit.JsonSetNumber(this, key, value);
    }


    public void AddNumber(string key, double value)
    {
        SplashKit.JsonSetNumber(this, key, value);
    }


    public void AddNumber(string key, float value)
    {
        SplashKit.JsonSetNumber(this, key, value);
    }


    public void AddObject(string key, Json obj)
    {
        SplashKit.JsonSetObject(this, key, obj);
    }


    public void AddString(string key, string value)
    {
        SplashKit.JsonSetString(this, key, value);
    }


    public static void ToFile(Json j, string filename)
    {
        SplashKit.JsonToFile(j, filename);
    }


    public static string ToJsonString(Json j)
    {
        return SplashKit.JsonToString(j);
    }

}
public class Music : PointerWrapper
{
  private Music(IntPtr ptr) : base(ptr, true) {}

  internal static Music FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as Music;
    #pragma warning restore CS8603
    return new Music(ptr);
  }

    public Music(string name, string filename) : base ( SplashKit.LoadMusic(name, filename), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.FreeMusic(this);
    }

    public void FadeIn(int ms)
    {
        SplashKit.FadeMusicIn(this, ms);
    }


    public void FadeIn(int times, int ms)
    {
        SplashKit.FadeMusicIn(this, times, ms);
    }


    public void Play()
    {
        SplashKit.PlayMusic(this);
    }


    public void Play(int times)
    {
        SplashKit.PlayMusic(this, times);
    }


    public void Play(int times, double volume)
    {
        SplashKit.PlayMusic(this, times, volume);
    }

    public string Filename
    {
        get { return SplashKit.MusicFilename(this); }
    }
    public string Name
    {
        get { return SplashKit.MusicName(this); }
    }
}
public class Connection : PointerWrapper
{
  private Connection(IntPtr ptr) : base(ptr, true) {}

  internal static Connection FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as Connection;
    #pragma warning restore CS8603
    return new Connection(ptr);
  }

    public Connection(string name, string host, ushort port) : base ( SplashKit.OpenConnection(name, host, port), false )
    { }

    public Connection(string name, string host, ushort port, ConnectionType protocol) : base ( SplashKit.OpenConnection(name, host, port, protocol), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.CloseConnection(this);
    }

    public void ClearMessages()
    {
        SplashKit.ClearMessages(this);
    }


    public bool Close()
    {
        return SplashKit.CloseConnection(this);
    }


    public Message ReadMessage()
    {
        return SplashKit.ReadMessage(this);
    }


    public string ReadMessageData()
    {
        return SplashKit.ReadMessageData(this);
    }


    public void Reconnect()
    {
        SplashKit.Reconnect(this);
    }


    public bool SendMessage(string aMsg)
    {
        return SplashKit.SendMessageTo(aMsg, this);
    }

    public uint IP
    {
        get { return SplashKit.ConnectionIP(this); }
    }
    public ushort Port
    {
        get { return SplashKit.ConnectionPort(this); }
    }
    public bool HasMessages
    {
        get { return SplashKit.HasMessages(this); }
    }
    public bool IsOpen
    {
        get { return SplashKit.IsConnectionOpen(this); }
    }
    public uint MessageCount
    {
        get { return SplashKit.MessageCount(this); }
    }
}
public class Message : PointerWrapper
{
  private Message(IntPtr ptr) : base(ptr, true) {}

  internal static Message FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as Message;
    #pragma warning restore CS8603
    return new Message(ptr);
  }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.CloseMessage(this);
    }

    public void Close()
    {
        SplashKit.CloseMessage(this);
    }

    public string Data
    {
        get { return SplashKit.MessageData(this); }
    }
    public List<byte> DataBytes
    {
        get { return SplashKit.MessageDataBytes(this); }
    }
    public string Host
    {
        get { return SplashKit.MessageHost(this); }
    }
    public ushort Port
    {
        get { return SplashKit.MessagePort(this); }
    }
    public ConnectionType Protocol
    {
        get { return SplashKit.MessageProtocol(this); }
    }
}
public class ServerSocket : PointerWrapper
{
  private ServerSocket(IntPtr ptr) : base(ptr, true) {}

  internal static ServerSocket FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as ServerSocket;
    #pragma warning restore CS8603
    return new ServerSocket(ptr);
  }

    public ServerSocket(string name, ushort port) : base ( SplashKit.CreateServer(name, port), false )
    { }

    public ServerSocket(string name, ushort port, ConnectionType protocol) : base ( SplashKit.CreateServer(name, port, protocol), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.CloseServer(this);
    }

    public bool AcceptNewConnection()
    {
        return SplashKit.AcceptNewConnection(this);
    }


    public void BroadcastMessage(string aMsg)
    {
        SplashKit.BroadcastMessage(aMsg, this);
    }


    public void ClearMessages()
    {
        SplashKit.ClearMessages(this);
    }


    public bool Close()
    {
        return SplashKit.CloseServer(this);
    }


    public Connection FetchNewConnection()
    {
        return SplashKit.FetchNewConnection(this);
    }


    public Message ReadMessage()
    {
        return SplashKit.ReadMessage(this);
    }


    public string ReadMessageData()
    {
        return SplashKit.ReadMessageData(this);
    }


    public void ResetNewConnectionCount()
    {
        SplashKit.ResetNewConnectionCount(this);
    }


    public Connection RetrieveConnection(int idx)
    {
        return SplashKit.RetrieveConnection(this, idx);
    }

    public uint ConnectionCount
    {
        get { return SplashKit.ConnectionCount(this); }
    }
    public bool HasMessages
    {
        get { return SplashKit.HasMessages(this); }
    }
    public Connection LastConnection
    {
        get { return SplashKit.LastConnection(this); }
    }
    public uint MessageCount
    {
        get { return SplashKit.MessageCount(this); }
    }
    public int NewConnectionCount
    {
        get { return SplashKit.NewConnectionCount(this); }
    }
    public bool HasNewConnections
    {
        get { return SplashKit.ServerHasNewConnection(this); }
    }
}
public class SoundEffect : PointerWrapper
{
  private SoundEffect(IntPtr ptr) : base(ptr, true) {}

  internal static SoundEffect FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as SoundEffect;
    #pragma warning restore CS8603
    return new SoundEffect(ptr);
  }

    public SoundEffect(string name, string filename) : base ( SplashKit.LoadSoundEffect(name, filename), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.FreeSoundEffect(this);
    }

    public void FadeOut(int ms)
    {
        SplashKit.FadeSoundEffectOut(this, ms);
    }


    public void Close()
    {
        SplashKit.FreeSoundEffect(this);
    }


    public void Play()
    {
        SplashKit.PlaySoundEffect(this);
    }


    public void Play(double volume)
    {
        SplashKit.PlaySoundEffect(this, volume);
    }


    public void Play(int times)
    {
        SplashKit.PlaySoundEffect(this, times);
    }


    public void Play(int times, double volume)
    {
        SplashKit.PlaySoundEffect(this, times, volume);
    }


    public void Stop()
    {
        SplashKit.StopSoundEffect(this);
    }

    public string Filename
    {
        get { return SplashKit.SoundEffectFilename(this); }
    }
    public string Name
    {
        get { return SplashKit.SoundEffectName(this); }
    }
    public bool IsPlaying
    {
        get { return SplashKit.SoundEffectPlaying(this); }
    }
}
public class Sprite : PointerWrapper
{
  private Sprite(IntPtr ptr) : base(ptr, true) {}

  internal static Sprite FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as Sprite;
    #pragma warning restore CS8603
    return new Sprite(ptr);
  }

    public Sprite(Bitmap layer) : base ( SplashKit.CreateSprite(layer), false )
    { }

    public Sprite(Bitmap layer, AnimationScript ani) : base ( SplashKit.CreateSprite(layer, ani), false )
    { }

    public Sprite(string bitmapName) : base ( SplashKit.CreateSprite(bitmapName), false )
    { }

    public Sprite(string name, Bitmap layer) : base ( SplashKit.CreateSprite(name, layer), false )
    { }

    public Sprite(string name, Bitmap layer, AnimationScript ani) : base ( SplashKit.CreateSprite(name, layer, ani), false )
    { }

    public Sprite(string bitmapName, string animationName) : base ( SplashKit.CreateSprite(bitmapName, animationName), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.FreeSprite(this);
    }

    public bool BitmapCollision(Bitmap bmp, double x, double y)
    {
        return SplashKit.SpriteBitmapCollision(this, bmp, x, y);
    }


    public bool BitmapCollision(Bitmap bmp, int cell, Point2D pt)
    {
        return SplashKit.SpriteBitmapCollision(this, bmp, cell, pt);
    }


    public bool BitmapCollision(Bitmap bmp, int cell, double x, double y)
    {
        return SplashKit.SpriteBitmapCollision(this, bmp, cell, x, y);
    }


    public bool SpriteCollision(Sprite s2)
    {
        return SplashKit.SpriteCollision(this, s2);
    }


    public bool PointCollision(Point2D pt)
    {
        return SplashKit.SpritePointCollision(this, pt);
    }


    public bool RectangleCollision(Rectangle rect)
    {
        return SplashKit.SpriteRectangleCollision(this, rect);
    }


    public void Draw(Vector2D offset)
    {
        SplashKit.DrawSprite(this, offset);
    }


    public void Draw()
    {
        SplashKit.DrawSprite(this);
    }


    public void Draw(double xOffset, double yOffset)
    {
        SplashKit.DrawSprite(this, xOffset, yOffset);
    }


    public void Move()
    {
        SplashKit.MoveSprite(this);
    }


    public void Move(Vector2D distance)
    {
        SplashKit.MoveSprite(this, distance);
    }


    public void Move(Vector2D distance, float pct)
    {
        SplashKit.MoveSprite(this, distance, pct);
    }


    public void Move(float pct)
    {
        SplashKit.MoveSprite(this, pct);
    }


    public void MoveTo(double x, double y)
    {
        SplashKit.MoveSpriteTo(this, x, y);
    }


    public int AddLayer(Bitmap newLayer, string layerName)
    {
        return SplashKit.SpriteAddLayer(this, newLayer, layerName);
    }


    public void AddToVelocity(Vector2D value)
    {
        SplashKit.SpriteAddToVelocity(this, value);
    }


    public void AddValue(string name)
    {
        SplashKit.SpriteAddValue(this, name);
    }


    public void AddValue(string name, float initVal)
    {
        SplashKit.SpriteAddValue(this, name, initVal);
    }


    public string AnimationName()
    {
        return SplashKit.SpriteAnimationName(this);
    }


    public void SendLayerForward(int visibleLayer)
    {
        SplashKit.SpriteBringLayerForward(this, visibleLayer);
    }


    public void SendLayerTofront(int visibleLayer)
    {
        SplashKit.SpriteBringLayerToFront(this, visibleLayer);
    }


    public void CallOnEvent(SpriteEventHandler handler)
    {
        SplashKit.SpriteCallOnEvent(this, handler);
    }


    public Circle Circle()
    {
        return SplashKit.SpriteCircle(this);
    }


    public Circle CollisionCircle()
    {
        return SplashKit.SpriteCollisionCircle(this);
    }


    public void HideLayer(string name)
    {
        SplashKit.SpriteHideLayer(this, name);
    }


    public void HideLayer(int id)
    {
        SplashKit.SpriteHideLayer(this, id);
    }


    public Bitmap Layer(string name)
    {
        return SplashKit.SpriteLayer(this, name);
    }


    public Bitmap Layer(int idx)
    {
        return SplashKit.SpriteLayer(this, idx);
    }


    public Circle LayerCircle(string name)
    {
        return SplashKit.SpriteLayerCircle(this, name);
    }


    public Circle LayerCircle(int idx)
    {
        return SplashKit.SpriteLayerCircle(this, idx);
    }


    public int LayerHeight(string name)
    {
        return SplashKit.SpriteLayerHeight(this, name);
    }


    public int LayerHeight(int idx)
    {
        return SplashKit.SpriteLayerHeight(this, idx);
    }


    public int IndexOfLayer(string name)
    {
        return SplashKit.SpriteLayerIndex(this, name);
    }


    public string LayerName(int idx)
    {
        return SplashKit.SpriteLayerName(this, idx);
    }


    public Vector2D LayerOffset(string name)
    {
        return SplashKit.SpriteLayerOffset(this, name);
    }


    public Vector2D LayerOffset(int idx)
    {
        return SplashKit.SpriteLayerOffset(this, idx);
    }


    public Rectangle LayerRectangle(string name)
    {
        return SplashKit.SpriteLayerRectangle(this, name);
    }


    public Rectangle LayerRectangle(int idx)
    {
        return SplashKit.SpriteLayerRectangle(this, idx);
    }


    public int LayerWidth(string name)
    {
        return SplashKit.SpriteLayerWidth(this, name);
    }


    public int LayerWidth(int idx)
    {
        return SplashKit.SpriteLayerWidth(this, idx);
    }


    public void MoveTo(Point2D pt, float takingSeconds)
    {
        SplashKit.SpriteMoveTo(this, pt, takingSeconds);
    }


    public bool Offscreen()
    {
        return SplashKit.SpriteOffscreen(this);
    }


    public bool OnScreenAt(Point2D pt)
    {
        return SplashKit.SpriteOnScreenAt(this, pt);
    }


    public bool OnScreenAt(double x, double y)
    {
        return SplashKit.SpriteOnScreenAt(this, x, y);
    }


    public void ReplayAnimation()
    {
        SplashKit.SpriteReplayAnimation(this);
    }


    public void ReplayAnimation(bool withSound)
    {
        SplashKit.SpriteReplayAnimation(this, withSound);
    }


    public void SendLayerTobackward(int visibleLayer)
    {
        SplashKit.SpriteSendLayerBackward(this, visibleLayer);
    }


    public void SendLayerToBack(int visibleLayer)
    {
        SplashKit.SpriteSendLayerToBack(this, visibleLayer);
    }


    public void SetLayerOffset(string name, Vector2D value)
    {
        SplashKit.SpriteSetLayerOffset(this, name, value);
    }


    public void SetLayerOffset(int idx, Vector2D value)
    {
        SplashKit.SpriteSetLayerOffset(this, idx, value);
    }


    public void SetValue(string name, float val)
    {
        SplashKit.SpriteSetValue(this, name, val);
    }


    public int ShowLayer(string name)
    {
        return SplashKit.SpriteShowLayer(this, name);
    }


    public int ShowLayer(int id)
    {
        return SplashKit.SpriteShowLayer(this, id);
    }


    public void StartAnimation(string named)
    {
        SplashKit.SpriteStartAnimation(this, named);
    }


    public void StartAnimation(string named, bool withSound)
    {
        SplashKit.SpriteStartAnimation(this, named, withSound);
    }


    public void StartAnimation(int idx)
    {
        SplashKit.SpriteStartAnimation(this, idx);
    }


    public void StartAnimation(int idx, bool withSound)
    {
        SplashKit.SpriteStartAnimation(this, idx, withSound);
    }


    public void StopCallingOnEvent(SpriteEventHandler handler)
    {
        SplashKit.SpriteStopCallingOnEvent(this, handler);
    }


    public void ToggleLayerVisible(string name)
    {
        SplashKit.SpriteToggleLayerVisible(this, name);
    }


    public void ToggleLayerVisible(int id)
    {
        SplashKit.SpriteToggleLayerVisible(this, id);
    }


    public float Value(string name)
    {
        return SplashKit.SpriteValue(this, name);
    }


    public int VisibleIndexOfLayer(string name)
    {
        return SplashKit.SpriteVisibleIndexOfLayer(this, name);
    }


    public int VisibleIndexOfLayer(int id)
    {
        return SplashKit.SpriteVisibleIndexOfLayer(this, id);
    }


    public int VisibleLayer(int idx)
    {
        return SplashKit.SpriteVisibleLayer(this, idx);
    }


    public int VisibleLayerIdAt(int idx)
    {
        return SplashKit.SpriteVisibleLayerId(this, idx);
    }


    public void Update()
    {
        SplashKit.UpdateSprite(this);
    }


    public void Update(bool withSound)
    {
        SplashKit.UpdateSprite(this, withSound);
    }


    public void Update(float pct)
    {
        SplashKit.UpdateSprite(this, pct);
    }


    public void Update(float pct, bool withSound)
    {
        SplashKit.UpdateSprite(this, pct, withSound);
    }


    public void UpdateAnimation()
    {
        SplashKit.UpdateSpriteAnimation(this);
    }


    public void UpdateAnimation(bool withSound)
    {
        SplashKit.UpdateSpriteAnimation(this, withSound);
    }


    public void UpdateAnimation(float pct)
    {
        SplashKit.UpdateSpriteAnimation(this, pct);
    }


    public void UpdateAnimation(float pct, bool withSound)
    {
        SplashKit.UpdateSpriteAnimation(this, pct, withSound);
    }


    public Vector2D VectorTo(Point2D pt)
    {
        return SplashKit.VectorFromCenterSpriteToPoint(this, pt);
    }


    public Vector2D VectorTo(Sprite s2)
    {
        return SplashKit.VectorFromTo(this, s2);
    }

    public Point2D CenterPoint
    {
        get { return SplashKit.CenterPoint(this); }
    }
    public Point2D AnchorPoint
    {
        get { return SplashKit.SpriteAnchorPoint(this); }
          set { SplashKit.SpriteSetAnchorPoint(this, value); }
    }
    public bool AnimationHasEnded
    {
        get { return SplashKit.SpriteAnimationHasEnded(this); }
    }
    public Bitmap CollisionBitmap
    {
        get { return SplashKit.SpriteCollisionBitmap(this); }
          set { SplashKit.SpriteSetCollisionBitmap(this, value); }
    }
    public CollisionTestKind CollisionKind
    {
        get { return SplashKit.SpriteCollisionKind(this); }
          set { SplashKit.SpriteSetCollisionKind(this, value); }
    }
    public Rectangle CollisionRectangle
    {
        get { return SplashKit.SpriteCollisionRectangle(this); }
    }
    public int CurrentCell
    {
        get { return SplashKit.SpriteCurrentCell(this); }
    }
    public Rectangle CurrentCellRectangle
    {
        get { return SplashKit.SpriteCurrentCellRectangle(this); }
    }
    public float Dx
    {
        get { return SplashKit.SpriteDx(this); }
          set { SplashKit.SpriteSetDx(this, value); }
    }
    public float Dy
    {
        get { return SplashKit.SpriteDy(this); }
          set { SplashKit.SpriteSetDy(this, value); }
    }
    public float Heading
    {
        get { return SplashKit.SpriteHeading(this); }
          set { SplashKit.SpriteSetHeading(this, value); }
    }
    public int Height
    {
        get { return SplashKit.SpriteHeight(this); }
    }
    public int LayerCount
    {
        get { return SplashKit.SpriteLayerCount(this); }
    }
    public Matrix2D LocationMatrix
    {
        get { return SplashKit.SpriteLocationMatrix(this); }
    }
    public float Mass
    {
        get { return SplashKit.SpriteMass(this); }
          set { SplashKit.SpriteSetMass(this, value); }
    }
    public bool MoveFromAnchorPoint
    {
        get { return SplashKit.SpriteMoveFromAnchorPoint(this); }
          set { SplashKit.SpriteSetMoveFromAnchorPoint(this, value); }
    }
    public string Name
    {
        get { return SplashKit.SpriteName(this); }
    }
    public Point2D Position
    {
        get { return SplashKit.SpritePosition(this); }
          set { SplashKit.SpriteSetPosition(this, value); }
    }
    public float Rotation
    {
        get { return SplashKit.SpriteRotation(this); }
          set { SplashKit.SpriteSetRotation(this, value); }
    }
    public float Scale
    {
        get { return SplashKit.SpriteScale(this); }
          set { SplashKit.SpriteSetScale(this, value); }
    }
    public Rectangle ScreenRectangle
    {
        get { return SplashKit.SpriteScreenRectangle(this); }
    }
    public float Speed
    {
        get { return SplashKit.SpriteSpeed(this); }
          set { SplashKit.SpriteSetSpeed(this, value); }
    }
    public Vector2D Velocity
    {
        get { return SplashKit.SpriteVelocity(this); }
          set { SplashKit.SpriteSetVelocity(this, value); }
    }
    public float X
    {
        get { return SplashKit.SpriteX(this); }
          set { SplashKit.SpriteSetX(this, value); }
    }
    public float Y
    {
        get { return SplashKit.SpriteY(this); }
          set { SplashKit.SpriteSetY(this, value); }
    }
    public int ValueCount
    {
        get { return SplashKit.SpriteValueCount(this); }
    }
    public int VisibleLayerCount
    {
        get { return SplashKit.SpriteVisibleLayerCount(this); }
    }
    public int Width
    {
        get { return SplashKit.SpriteWidth(this); }
    }
}
public class Timer : PointerWrapper
{
  private Timer(IntPtr ptr) : base(ptr, true) {}

  internal static Timer FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as Timer;
    #pragma warning restore CS8603
    return new Timer(ptr);
  }

    public Timer(string name) : base ( SplashKit.CreateTimer(name), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.FreeTimer(this);
    }

    public void Pause()
    {
        SplashKit.PauseTimer(this);
    }


    public void Reset()
    {
        SplashKit.ResetTimer(this);
    }


    public void Resume()
    {
        SplashKit.ResumeTimer(this);
    }


    public void Start()
    {
        SplashKit.StartTimer(this);
    }


    public void Stop()
    {
        SplashKit.StopTimer(this);
    }

    public bool IsPaused
    {
        get { return SplashKit.TimerPaused(this); }
    }
    public bool IsStarted
    {
        get { return SplashKit.TimerStarted(this); }
    }
    public uint Ticks
    {
        get { return SplashKit.TimerTicks(this); }
    }
}
public class Animation : PointerWrapper
{
  private Animation(IntPtr ptr) : base(ptr, true) {}

  internal static Animation FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as Animation;
    #pragma warning restore CS8603
    return new Animation(ptr);
  }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.FreeAnimation(this);
    }

    public void Assign(AnimationScript script, string name)
    {
        SplashKit.AssignAnimation(this, script, name);
    }


    public void Assign(AnimationScript script, string name, bool withSound)
    {
        SplashKit.AssignAnimation(this, script, name, withSound);
    }


    public void Assign(AnimationScript script, int idx)
    {
        SplashKit.AssignAnimation(this, script, idx);
    }


    public void Assign(AnimationScript script, int idx, bool withSound)
    {
        SplashKit.AssignAnimation(this, script, idx, withSound);
    }


    public void Assign(string scriptName, string name)
    {
        SplashKit.AssignAnimation(this, scriptName, name);
    }


    public void Assign(string scriptName, string name, bool withSound)
    {
        SplashKit.AssignAnimation(this, scriptName, name, withSound);
    }


    public void Assign(int idx)
    {
        SplashKit.AssignAnimation(this, idx);
    }


    public void Assign(int idx, bool withSound)
    {
        SplashKit.AssignAnimation(this, idx, withSound);
    }


    public void Assign(string name)
    {
        SplashKit.AssignAnimation(this, name);
    }


    public void Assign(string name, bool withSound)
    {
        SplashKit.AssignAnimation(this, name, withSound);
    }


    public static void FreeAll()
    {
        SplashKit.FreeAllAnimationScripts();
    }


    public void Restart()
    {
        SplashKit.RestartAnimation(this);
    }


    public void Restart(bool withSound)
    {
        SplashKit.RestartAnimation(this, withSound);
    }


    public void Update()
    {
        SplashKit.UpdateAnimation(this);
    }


    public void Update(float pct)
    {
        SplashKit.UpdateAnimation(this, pct);
    }

    public int CurrentCell
    {
        get { return SplashKit.AnimationCurrentCell(this); }
    }
    public Vector2D CurrentVector
    {
        get { return SplashKit.AnimationCurrentVector(this); }
    }
    public bool Ended
    {
        get { return SplashKit.AnimationEnded(this); }
    }
    public bool EnteredFrame
    {
        get { return SplashKit.AnimationEnteredFrame(this); }
    }
    public float FrameTime
    {
        get { return SplashKit.AnimationFrameTime(this); }
    }
    public string Name
    {
        get { return SplashKit.AnimationName(this); }
    }
}
public class AnimationScript : PointerWrapper
{
  private AnimationScript(IntPtr ptr) : base(ptr, true) {}

  internal static AnimationScript FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as AnimationScript;
    #pragma warning restore CS8603
    return new AnimationScript(ptr);
  }

    public AnimationScript(string name, string filename) : base ( SplashKit.LoadAnimationScript(name, filename), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.FreeAnimationScript(this);
    }

    public int AnimationIndex(string name)
    {
        return SplashKit.AnimationIndex(this, name);
    }


    public Animation CreateAnimation(string name)
    {
        return SplashKit.CreateAnimation(this, name);
    }


    public Animation CreateAnimation(string name, bool withSound)
    {
        return SplashKit.CreateAnimation(this, name, withSound);
    }

    public int AnimationCount
    {
        get { return SplashKit.AnimationCount(this); }
    }
    public string Name
    {
        get { return SplashKit.AnimationScriptName(this); }
    }
}
public class Bitmap : PointerWrapper
{
  private Bitmap(IntPtr ptr) : base(ptr, true) {}

  internal static Bitmap FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as Bitmap;
    #pragma warning restore CS8603
    return new Bitmap(ptr);
  }

    public Bitmap(string name, int width, int height) : base ( SplashKit.CreateBitmap(name, width, height), false )
    { }

    public Bitmap(string name, string filename) : base ( SplashKit.LoadBitmap(name, filename), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.FreeBitmap(this);
    }

    public void DrawCircle(Color clr, double x, double y, double radius)
    {
        SplashKit.DrawCircleOnBitmap(this, clr, x, y, radius);
    }


    public void DrawCircle(Color clr, double x, double y, double radius, DrawingOptions opts)
    {
        SplashKit.DrawCircleOnBitmap(this, clr, x, y, radius, opts);
    }


    public void FillCircle(Color clr, double x, double y, double radius)
    {
        SplashKit.FillCircleOnBitmap(this, clr, x, y, radius);
    }


    public void FillCircle(Color clr, double x, double y, double radius, DrawingOptions opts)
    {
        SplashKit.FillCircleOnBitmap(this, clr, x, y, radius, opts);
    }


    public bool CircleCollision(Point2D pt, Circle circ)
    {
        return SplashKit.BitmapCircleCollision(this, pt, circ);
    }


    public bool CircleCollision(double x, double y, Circle circ)
    {
        return SplashKit.BitmapCircleCollision(this, x, y, circ);
    }


    public bool CircleCollision(int cell, Matrix2D translation, Circle circ)
    {
        return SplashKit.BitmapCircleCollision(this, cell, translation, circ);
    }


    public bool CircleCollision(int cell, Point2D pt, Circle circ)
    {
        return SplashKit.BitmapCircleCollision(this, cell, pt, circ);
    }


    public bool CircleCollision(int cell, double x, double y, Circle circ)
    {
        return SplashKit.BitmapCircleCollision(this, cell, x, y, circ);
    }


    public bool BitmapCollision(double x1, double y1, Bitmap bmp2, double x2, double y2)
    {
        return SplashKit.BitmapCollision(this, x1, y1, bmp2, x2, y2);
    }


    public bool BitmapCollision(Point2D pt1, Bitmap bmp2, Point2D pt2)
    {
        return SplashKit.BitmapCollision(this, pt1, bmp2, pt2);
    }


    public bool BitmapCollision(int cell1, Matrix2D matrix1, Bitmap bmp2, int cell2, Matrix2D matrix2)
    {
        return SplashKit.BitmapCollision(this, cell1, matrix1, bmp2, cell2, matrix2);
    }


    public bool BitmapCollision(int cell1, Point2D pt1, Bitmap bmp2, int cell2, Point2D pt2)
    {
        return SplashKit.BitmapCollision(this, cell1, pt1, bmp2, cell2, pt2);
    }


    public bool BitmapCollision(int cell1, double x1, double y1, Bitmap bmp2, int cell2, double x2, double y2)
    {
        return SplashKit.BitmapCollision(this, cell1, x1, y1, bmp2, cell2, x2, y2);
    }


    public bool PointCollision(Matrix2D translation, Point2D pt)
    {
        return SplashKit.BitmapPointCollision(this, translation, pt);
    }


    public bool PointCollision(Point2D bmpPt, Point2D pt)
    {
        return SplashKit.BitmapPointCollision(this, bmpPt, pt);
    }


    public bool PointCollision(double bmpX, double bmpY, double x, double y)
    {
        return SplashKit.BitmapPointCollision(this, bmpX, bmpY, x, y);
    }


    public bool PointCollision(int cell, Matrix2D translation, Point2D pt)
    {
        return SplashKit.BitmapPointCollision(this, cell, translation, pt);
    }


    public bool PointCollision(int cell, Point2D bmpPt, Point2D pt)
    {
        return SplashKit.BitmapPointCollision(this, cell, bmpPt, pt);
    }


    public bool PointCollision(int cell, double bmpX, double bmpY, double x, double y)
    {
        return SplashKit.BitmapPointCollision(this, cell, bmpX, bmpY, x, y);
    }


    public bool RectangleCollision(Point2D pt, Rectangle rect)
    {
        return SplashKit.BitmapRectangleCollision(this, pt, rect);
    }


    public bool RectangleCollision(double x, double y, Rectangle rect)
    {
        return SplashKit.BitmapRectangleCollision(this, x, y, rect);
    }


    public bool RectangleCollision(int cell, Matrix2D translation, Rectangle rect)
    {
        return SplashKit.BitmapRectangleCollision(this, cell, translation, rect);
    }


    public bool RectangleCollision(int cell, Point2D pt, Rectangle rect)
    {
        return SplashKit.BitmapRectangleCollision(this, cell, pt, rect);
    }


    public bool RectangleCollision(int cell, double x, double y, Rectangle rect)
    {
        return SplashKit.BitmapRectangleCollision(this, cell, x, y, rect);
    }


    public void DrawEllipse(Color clr, Rectangle rect)
    {
        SplashKit.DrawEllipseOnBitmap(this, clr, rect);
    }


    public void DrawEllipse(Color clr, Rectangle rect, DrawingOptions opts)
    {
        SplashKit.DrawEllipseOnBitmap(this, clr, rect, opts);
    }


    public void DrawEllipse(Color clr, double x, double y, double width, double height)
    {
        SplashKit.DrawEllipseOnBitmap(this, clr, x, y, width, height);
    }


    public void DrawEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
        SplashKit.DrawEllipseOnBitmap(this, clr, x, y, width, height, opts);
    }


    public void FillEllipse(Color clr, Rectangle rect)
    {
        SplashKit.FillEllipseOnBitmap(this, clr, rect);
    }


    public void FillEllipse(Color clr, Rectangle rect, DrawingOptions opts)
    {
        SplashKit.FillEllipseOnBitmap(this, clr, rect, opts);
    }


    public void FillEllipse(Color clr, double x, double y, double width, double height)
    {
        SplashKit.FillEllipseOnBitmap(this, clr, x, y, width, height);
    }


    public void FillEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
        SplashKit.FillEllipseOnBitmap(this, clr, x, y, width, height, opts);
    }


    public Circle BoundingCircle(Point2D pt)
    {
        return SplashKit.BitmapBoundingCircle(this, pt);
    }


    public Rectangle BoundingRectangle()
    {
        return SplashKit.BitmapBoundingRectangle(this);
    }


    public Rectangle BoundingRectangle(double x, double y)
    {
        return SplashKit.BitmapBoundingRectangle(this, x, y);
    }


    public Circle CellCircle(double x, double y)
    {
        return SplashKit.BitmapCellCircle(this, x, y);
    }


    public Circle CellCircle(Point2D pt)
    {
        return SplashKit.BitmapCellCircle(this, pt);
    }


    public Circle CellCircle(Point2D pt, double scale)
    {
        return SplashKit.BitmapCellCircle(this, pt, scale);
    }


    public Vector2D CellOffset(int cell)
    {
        return SplashKit.BitmapCellOffset(this, cell);
    }


    public Rectangle CellRectangle()
    {
        return SplashKit.BitmapCellRectangle(this);
    }


    public Rectangle CellRectangle(Point2D pt)
    {
        return SplashKit.BitmapCellRectangle(this, pt);
    }


    public Rectangle RectangleOfCell(int cell)
    {
        return SplashKit.BitmapRectangleOfCell(this, cell);
    }


    public void SetCellDetails(int width, int height, int columns, int rows, int count)
    {
        SplashKit.BitmapSetCellDetails(this, width, height, columns, rows, count);
    }


    public void Clear(Color clr)
    {
        SplashKit.ClearBitmap(this, clr);
    }


    public void Draw(double x, double y)
    {
        SplashKit.DrawBitmap(this, x, y);
    }


    public void Draw(double x, double y, DrawingOptions opts)
    {
        SplashKit.DrawBitmap(this, x, y, opts);
    }


    public void DrawBitmap(Bitmap destination, double x, double y)
    {
        SplashKit.DrawBitmapOnBitmap(destination, this, x, y);
    }


    public void DrawBitmap(Bitmap destination, double x, double y, DrawingOptions opts)
    {
        SplashKit.DrawBitmapOnBitmap(destination, this, x, y, opts);
    }


    public void Free()
    {
        SplashKit.FreeBitmap(this);
    }


    public bool PixelDrawnAtPoint(Point2D pt)
    {
        return SplashKit.PixelDrawnAtPoint(this, pt);
    }


    public bool PixelDrawnAtPoint(double x, double y)
    {
        return SplashKit.PixelDrawnAtPoint(this, x, y);
    }


    public bool PixelDrawnAtPointInCell(int cell, Point2D pt)
    {
        return SplashKit.PixelDrawnAtPoint(this, cell, pt);
    }


    public bool PixelDrawnAtPoint(int cell, double x, double y)
    {
        return SplashKit.PixelDrawnAtPoint(this, cell, x, y);
    }


    public void SetupCollisionMask()
    {
        SplashKit.SetupCollisionMask(this);
    }


    public void DrawLine(Color clr, Line l)
    {
        SplashKit.DrawLineOnBitmap(this, clr, l);
    }


    public void DrawLine(Color clr, Line l, DrawingOptions opts)
    {
        SplashKit.DrawLineOnBitmap(this, clr, l, opts);
    }


    public void DrawLine(Color clr, Point2D fromPt, Point2D toPt)
    {
        SplashKit.DrawLineOnBitmap(this, clr, fromPt, toPt);
    }


    public void DrawLine(Color clr, Point2D fromPt, Point2D toPt, DrawingOptions opts)
    {
        SplashKit.DrawLineOnBitmap(this, clr, fromPt, toPt, opts);
    }


    public void DrawLine(Color clr, double x1, double y1, double x2, double y2)
    {
        SplashKit.DrawLineOnBitmap(this, clr, x1, y1, x2, y2);
    }


    public void DrawLine(Color clr, double x1, double y1, double x2, double y2, DrawingOptions opts)
    {
        SplashKit.DrawLineOnBitmap(this, clr, x1, y1, x2, y2, opts);
    }


    public void DrawPixel(Color clr, Point2D pt)
    {
        SplashKit.DrawPixelOnBitmap(this, clr, pt);
    }


    public void DrawPixel(Color clr, Point2D pt, DrawingOptions opts)
    {
        SplashKit.DrawPixelOnBitmap(this, clr, pt, opts);
    }


    public void DrawPixel(Color clr, double x, double y)
    {
        SplashKit.DrawPixelOnBitmap(this, clr, x, y);
    }


    public void DrawPixel(Color clr, double x, double y, DrawingOptions opts)
    {
        SplashKit.DrawPixelOnBitmap(this, clr, x, y, opts);
    }


    public void DrawQuad(Color clr, Quad q)
    {
        SplashKit.DrawQuadOnBitmap(this, clr, q);
    }


    public void DrawQuad(Color clr, Quad q, DrawingOptions opts)
    {
        SplashKit.DrawQuadOnBitmap(this, clr, q, opts);
    }


    public void DrawRectangle(Color clr, Rectangle rect)
    {
        SplashKit.DrawRectangleOnBitmap(this, clr, rect);
    }


    public void DrawRectangle(Color clr, Rectangle rect, DrawingOptions opts)
    {
        SplashKit.DrawRectangleOnBitmap(this, clr, rect, opts);
    }


    public void DrawRectangle(Color clr, double x, double y, double width, double height)
    {
        SplashKit.DrawRectangleOnBitmap(this, clr, x, y, width, height);
    }


    public void DrawRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
        SplashKit.DrawRectangleOnBitmap(this, clr, x, y, width, height, opts);
    }


    public void FillQuad(Color clr, Quad q)
    {
        SplashKit.FillQuadOnBitmap(this, clr, q);
    }


    public void FillQuad(Color clr, Quad q, DrawingOptions opts)
    {
        SplashKit.FillQuadOnBitmap(this, clr, q, opts);
    }


    public void FillRectangle(Color clr, Rectangle rect)
    {
        SplashKit.FillRectangleOnBitmap(this, clr, rect);
    }


    public void FillRectangle(Color clr, Rectangle rect, DrawingOptions opts)
    {
        SplashKit.FillRectangleOnBitmap(this, clr, rect, opts);
    }


    public void FillRectangle(Color clr, double x, double y, double width, double height)
    {
        SplashKit.FillRectangleOnBitmap(this, clr, x, y, width, height);
    }


    public void FillRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
        SplashKit.FillRectangleOnBitmap(this, clr, x, y, width, height, opts);
    }


    public void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y)
    {
        SplashKit.DrawTextOnBitmap(this, text, clr, fnt, fontSize, x, y);
    }


    public void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y, DrawingOptions opts)
    {
        SplashKit.DrawTextOnBitmap(this, text, clr, fnt, fontSize, x, y, opts);
    }


    public void DrawText(string text, Color clr, double x, double y)
    {
        SplashKit.DrawTextOnBitmap(this, text, clr, x, y);
    }


    public void DrawText(string text, Color clr, double x, double y, DrawingOptions opts)
    {
        SplashKit.DrawTextOnBitmap(this, text, clr, x, y, opts);
    }


    public void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y)
    {
        SplashKit.DrawTextOnBitmap(this, text, clr, fnt, fontSize, x, y);
    }


    public void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y, DrawingOptions opts)
    {
        SplashKit.DrawTextOnBitmap(this, text, clr, fnt, fontSize, x, y, opts);
    }


    public void DrawTriangle(Color clr, Triangle tri)
    {
        SplashKit.DrawTriangleOnBitmap(this, clr, tri);
    }


    public void DrawTriangle(Color clr, Triangle tri, DrawingOptions opts)
    {
        SplashKit.DrawTriangleOnBitmap(this, clr, tri, opts);
    }


    public void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3)
    {
        SplashKit.DrawTriangleOnBitmap(this, clr, x1, y1, x2, y2, x3, y3);
    }


    public void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts)
    {
        SplashKit.DrawTriangleOnBitmap(this, clr, x1, y1, x2, y2, x3, y3, opts);
    }


    public void FillTriangle(Color clr, Triangle tri)
    {
        SplashKit.FillTriangleOnBitmap(this, clr, tri);
    }


    public void FillTriangle(Color clr, Triangle tri, DrawingOptions opts)
    {
        SplashKit.FillTriangleOnBitmap(this, clr, tri, opts);
    }


    public void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3)
    {
        SplashKit.FillTriangleOnBitmap(this, clr, x1, y1, x2, y2, x3, y3);
    }


    public void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts)
    {
        SplashKit.FillTriangleOnBitmap(this, clr, x1, y1, x2, y2, x3, y3, opts);
    }

    public Point2D CellCenter
    {
        get { return SplashKit.BitmapCellCenter(this); }
    }
    public int CellColumns
    {
        get { return SplashKit.BitmapCellColumns(this); }
    }
    public int CellCount
    {
        get { return SplashKit.BitmapCellCount(this); }
    }
    public int CellHeight
    {
        get { return SplashKit.BitmapCellHeight(this); }
    }
    public int CellRows
    {
        get { return SplashKit.BitmapCellRows(this); }
    }
    public int CellWidth
    {
        get { return SplashKit.BitmapCellWidth(this); }
    }
    public Point2D Center
    {
        get { return SplashKit.BitmapCenter(this); }
    }
    public string Filename
    {
        get { return SplashKit.BitmapFilename(this); }
    }
    public int Height
    {
        get { return SplashKit.BitmapHeight(this); }
    }
    public string Name
    {
        get { return SplashKit.BitmapName(this); }
    }
    public int Width
    {
        get { return SplashKit.BitmapWidth(this); }
    }
}
public class Display : PointerWrapper
{
  private Display(IntPtr ptr) : base(ptr, true) {}

  internal static Display FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as Display;
    #pragma warning restore CS8603
    return new Display(ptr);
  }
        protected internal override void DoFree()
        {}
        public int Height
    {
        get { return SplashKit.DisplayHeight(this); }
    }
    public string Name
    {
        get { return SplashKit.DisplayName(this); }
    }
    public int Width
    {
        get { return SplashKit.DisplayWidth(this); }
    }
    public int X
    {
        get { return SplashKit.DisplayX(this); }
    }
    public int Y
    {
        get { return SplashKit.DisplayY(this); }
    }
}
public class Font : PointerWrapper
{
  private Font(IntPtr ptr) : base(ptr, true) {}

  internal static Font FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as Font;
    #pragma warning restore CS8603
    return new Font(ptr);
  }

    public Font(string name, string filename) : base ( SplashKit.LoadFont(name, filename), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.FreeFont(this);
    }

    public bool HasSize(int fontSize)
    {
        return SplashKit.FontHasSize(this, fontSize);
    }


    public void LoadSize(int fontSize)
    {
        SplashKit.FontLoadSize(this, fontSize);
    }


    public void Free()
    {
        SplashKit.FreeFont(this);
    }

    public FontStyle Style
    {
        get { return SplashKit.GetFontStyle(this); }
          set { SplashKit.SetFontStyle(this, value); }
    }
}
public class HttpResponse : PointerWrapper
{
  private HttpResponse(IntPtr ptr) : base(ptr, true) {}

  internal static HttpResponse FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as HttpResponse;
    #pragma warning restore CS8603
    return new HttpResponse(ptr);
  }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.FreeResponse(this);
    }

    public void Free()
    {
        SplashKit.FreeResponse(this);
    }

}
public class HttpRequest : PointerWrapper
{
  private HttpRequest(IntPtr ptr) : base(ptr, true) {}

  internal static HttpRequest FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as HttpRequest;
    #pragma warning restore CS8603
    return new HttpRequest(ptr);
  }
        protected internal override void DoFree()
        {}
    
    public bool IsDeleteRequestFor(string path)
    {
        return SplashKit.IsDeleteRequestFor(this, path);
    }


    public bool IsGetRequestFor(string path)
    {
        return SplashKit.IsGetRequestFor(this, path);
    }


    public bool IsOptionsRequestFor(string path)
    {
        return SplashKit.IsOptionsRequestFor(this, path);
    }


    public bool IsPostRequestFor(string path)
    {
        return SplashKit.IsPostRequestFor(this, path);
    }


    public bool IsPutRequestFor(string path)
    {
        return SplashKit.IsPutRequestFor(this, path);
    }


    public bool IsRequestFor(HttpMethod method, string path)
    {
        return SplashKit.IsRequestFor(this, method, path);
    }


    public bool IsTraceRequestFor(string path)
    {
        return SplashKit.IsTraceRequestFor(this, path);
    }


    public bool HasQueryParameter(string name)
    {
        return SplashKit.RequestHasQueryParameter(this, name);
    }


    public string QueryParameter(string name, string defaultValue)
    {
        return SplashKit.RequestQueryParameter(this, name, defaultValue);
    }


    public void SendCSSFileResponse(string filename)
    {
        SplashKit.SendCSSFileResponse(this, filename);
    }


    public void SendFileResponse(string filename, string contentType)
    {
        SplashKit.SendFileResponse(this, filename, contentType);
    }


    public void SendHtmlFileResponse(string filename)
    {
        SplashKit.SendHtmlFileResponse(this, filename);
    }


    public void SendJavascriptFileResponse(string filename)
    {
        SplashKit.SendJavascriptFileResponse(this, filename);
    }


    public void SendResponse()
    {
        SplashKit.SendResponse(this);
    }


    public void SendResponse(string message)
    {
        SplashKit.SendResponse(this, message);
    }


    public void SendResponse(HttpStatusCode code)
    {
        SplashKit.SendResponse(this, code);
    }


    public void SendResponse(HttpStatusCode code, string message)
    {
        SplashKit.SendResponse(this, code, message);
    }


    public void SendResponse(HttpStatusCode code, string message, string contentType)
    {
        SplashKit.SendResponse(this, code, message, contentType);
    }


    public void SendResponse(HttpStatusCode code, string message, string contentType, List<string> headers)
    {
        SplashKit.SendResponse(this, code, message, contentType, headers);
    }


    public void SendResponse(Json j)
    {
        SplashKit.SendResponse(this, j);
    }

    public string Body
    {
        get { return SplashKit.RequestBody(this); }
    }
    public List<string> Headers
    {
        get { return SplashKit.RequestHeaders(this); }
    }
    public HttpMethod Method
    {
        get { return SplashKit.RequestMethod(this); }
    }
    public string QueryString
    {
        get { return SplashKit.RequestQueryString(this); }
    }
    public string URI
    {
        get { return SplashKit.RequestURI(this); }
    }
    public List<string> URIStubs
    {
        get { return SplashKit.RequestURIStubs(this); }
    }
}
public class WebServer : PointerWrapper
{
  private WebServer(IntPtr ptr) : base(ptr, true) {}

  internal static WebServer FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as WebServer;
    #pragma warning restore CS8603
    return new WebServer(ptr);
  }

    public WebServer() : base ( SplashKit.StartWebServer(), false )
    { }

    public WebServer(ushort port) : base ( SplashKit.StartWebServer(port), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.StopWebServer(this);
    }

    public void Stop()
    {
        SplashKit.StopWebServer(this);
    }

    public bool HasIncomingRequests
    {
        get { return SplashKit.HasIncomingRequests(this); }
    }
    public HttpRequest NextWebRequest
    {
        get { return SplashKit.NextWebRequest(this); }
    }
}
public class Window : PointerWrapper
{
  private Window(IntPtr ptr) : base(ptr, true) {}

  internal static Window FetchOrCreate(IntPtr ptr)
  {
    #pragma warning disable CS8603
    if (ptr == IntPtr.Zero) return null;

    if (_ptrRegister.ContainsKey(ptr)) return _ptrRegister[ptr] as Window;
    #pragma warning restore CS8603
    return new Window(ptr);
  }

    public Window(string caption, int width, int height) : base ( SplashKit.OpenWindow(caption, width, height), false )
    { }
    protected internal override void DoFree()
    {
        // System.Console.WriteLine("TODO: Free!");
        SplashKit.CloseWindow(this);
    }

    public void DrawCircle(Color clr, double x, double y, double radius)
    {
        SplashKit.DrawCircleOnWindow(this, clr, x, y, radius);
    }


    public void DrawCircle(Color clr, double x, double y, double radius, DrawingOptions opts)
    {
        SplashKit.DrawCircleOnWindow(this, clr, x, y, radius, opts);
    }


    public void FillCircle(Color clr, double x, double y, double radius)
    {
        SplashKit.FillCircleOnWindow(this, clr, x, y, radius);
    }


    public void FillCircle(Color clr, double x, double y, double radius, DrawingOptions opts)
    {
        SplashKit.FillCircleOnWindow(this, clr, x, y, radius, opts);
    }


    public void DrawEllipse(Color clr, Rectangle rect)
    {
        SplashKit.DrawEllipseOnWindow(this, clr, rect);
    }


    public void DrawEllipse(Color clr, Rectangle rect, DrawingOptions opts)
    {
        SplashKit.DrawEllipseOnWindow(this, clr, rect, opts);
    }


    public void DrawEllipse(Color clr, double x, double y, double width, double height)
    {
        SplashKit.DrawEllipseOnWindow(this, clr, x, y, width, height);
    }


    public void DrawEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
        SplashKit.DrawEllipseOnWindow(this, clr, x, y, width, height, opts);
    }


    public void FillEllipse(Color clr, Rectangle rect)
    {
        SplashKit.FillEllipseOnWindow(this, clr, rect);
    }


    public void FillEllipse(Color clr, Rectangle rect, DrawingOptions opts)
    {
        SplashKit.FillEllipseOnWindow(this, clr, rect, opts);
    }


    public void FillEllipse(Color clr, double x, double y, double width, double height)
    {
        SplashKit.FillEllipseOnWindow(this, clr, x, y, width, height);
    }


    public void FillEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
        SplashKit.FillEllipseOnWindow(this, clr, x, y, width, height, opts);
    }


    public void DrawBitmap(Bitmap bmp, double x, double y)
    {
        SplashKit.DrawBitmapOnWindow(this, bmp, x, y);
    }


    public void DrawBitmap(Bitmap bmp, double x, double y, DrawingOptions opts)
    {
        SplashKit.DrawBitmapOnWindow(this, bmp, x, y, opts);
    }


    public void DrawLine(Color clr, Line l)
    {
        SplashKit.DrawLineOnWindow(this, clr, l);
    }


    public void DrawLine(Color clr, Line l, DrawingOptions opts)
    {
        SplashKit.DrawLineOnWindow(this, clr, l, opts);
    }


    public void DrawLine(Color clr, Point2D fromPt, Point2D toPt)
    {
        SplashKit.DrawLineOnWindow(this, clr, fromPt, toPt);
    }


    public void DrawLine(Color clr, Point2D fromPt, Point2D toPt, DrawingOptions opts)
    {
        SplashKit.DrawLineOnWindow(this, clr, fromPt, toPt, opts);
    }


    public void DrawLine(Color clr, double x1, double y1, double x2, double y2)
    {
        SplashKit.DrawLineOnWindow(this, clr, x1, y1, x2, y2);
    }


    public void DrawLine(Color clr, double x1, double y1, double x2, double y2, DrawingOptions opts)
    {
        SplashKit.DrawLineOnWindow(this, clr, x1, y1, x2, y2, opts);
    }


    public void DrawQuad(Color clr, Quad q)
    {
        SplashKit.DrawQuadOnWindow(this, clr, q);
    }


    public void DrawQuad(Color clr, Quad q, DrawingOptions opts)
    {
        SplashKit.DrawQuadOnWindow(this, clr, q, opts);
    }


    public void DrawRectangle(Color clr, Rectangle rect)
    {
        SplashKit.DrawRectangleOnWindow(this, clr, rect);
    }


    public void DrawRectangle(Color clr, Rectangle rect, DrawingOptions opts)
    {
        SplashKit.DrawRectangleOnWindow(this, clr, rect, opts);
    }


    public void DrawRectangle(Color clr, double x, double y, double width, double height)
    {
        SplashKit.DrawRectangleOnWindow(this, clr, x, y, width, height);
    }


    public void DrawRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
        SplashKit.DrawRectangleOnWindow(this, clr, x, y, width, height, opts);
    }


    public void FillQuad(Color clr, Quad q)
    {
        SplashKit.FillQuadOnWindow(this, clr, q);
    }


    public void FillRectangle(Color clr, Rectangle rect)
    {
        SplashKit.FillRectangleOnWindow(this, clr, rect);
    }


    public void FillRectangle(Color clr, Rectangle rect, DrawingOptions opts)
    {
        SplashKit.FillRectangleOnWindow(this, clr, rect, opts);
    }


    public void FillRectangle(Color clr, double x, double y, double width, double height)
    {
        SplashKit.FillRectangleOnWindow(this, clr, x, y, width, height);
    }


    public void FillRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts)
    {
        SplashKit.FillRectangleOnWindow(this, clr, x, y, width, height, opts);
    }


    public void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y)
    {
        SplashKit.DrawTextOnWindow(this, text, clr, fnt, fontSize, x, y);
    }


    public void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y, DrawingOptions opts)
    {
        SplashKit.DrawTextOnWindow(this, text, clr, fnt, fontSize, x, y, opts);
    }


    public void DrawText(string text, Color clr, double x, double y)
    {
        SplashKit.DrawTextOnWindow(this, text, clr, x, y);
    }


    public void DrawText(string text, Color clr, double x, double y, DrawingOptions opts)
    {
        SplashKit.DrawTextOnWindow(this, text, clr, x, y, opts);
    }


    public void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y)
    {
        SplashKit.DrawTextOnWindow(this, text, clr, fnt, fontSize, x, y);
    }


    public void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y, DrawingOptions opts)
    {
        SplashKit.DrawTextOnWindow(this, text, clr, fnt, fontSize, x, y, opts);
    }


    public void DrawTriangle(Color clr, Triangle tri)
    {
        SplashKit.DrawTriangleOnWindow(this, clr, tri);
    }


    public void DrawTriangle(Color clr, Triangle tri, DrawingOptions opts)
    {
        SplashKit.DrawTriangleOnWindow(this, clr, tri, opts);
    }


    public void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3)
    {
        SplashKit.DrawTriangleOnWindow(this, clr, x1, y1, x2, y2, x3, y3);
    }


    public void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts)
    {
        SplashKit.DrawTriangleOnWindow(this, clr, x1, y1, x2, y2, x3, y3, opts);
    }


    public void FillTriangle(Color clr, Triangle tri)
    {
        SplashKit.FillTriangleOnWindow(this, clr, tri);
    }


    public void FillTriangle(Color clr, Triangle tri, DrawingOptions opts)
    {
        SplashKit.FillTriangleOnWindow(this, clr, tri, opts);
    }


    public void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3)
    {
        SplashKit.FillTriangleOnWindow(this, clr, x1, y1, x2, y2, x3, y3);
    }


    public void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts)
    {
        SplashKit.FillTriangleOnWindow(this, clr, x1, y1, x2, y2, x3, y3, opts);
    }


    public void Clear(Color clr)
    {
        SplashKit.ClearWindow(this, clr);
    }


    public void Close()
    {
        SplashKit.CloseWindow(this);
    }


    public void MoveTo(int x, int y)
    {
        SplashKit.MoveWindowTo(this, x, y);
    }


    public void Refresh()
    {
        SplashKit.RefreshWindow(this);
    }


    public void Refresh(uint targetFps)
    {
        SplashKit.RefreshWindow(this, targetFps);
    }


    public void Resize(int width, int height)
    {
        SplashKit.ResizeWindow(this, width, height);
    }


    public void MakeCurrent()
    {
        SplashKit.SetCurrentWindow(this);
    }


    public void ToggleBorder()
    {
        SplashKit.WindowToggleBorder(this);
    }


    public void ToggleFullscreen()
    {
        SplashKit.WindowToggleFullscreen(this);
    }

    public Rectangle Area
    {
        get { return SplashKit.WindowArea(this); }
    }
    public bool IsCurrentWindow
    {
        get { return SplashKit.IsCurrentWindow(this); }
    }
    public string Caption
    {
        get { return SplashKit.WindowCaption(this); }
    }
    public bool CloseRequested
    {
        get { return SplashKit.WindowCloseRequested(this); }
    }
    public bool HasBorder
    {
        get { return SplashKit.WindowHasBorder(this); }
    }
    public bool HasFocus
    {
        get { return SplashKit.WindowHasFocus(this); }
    }
    public int Height
    {
        get { return SplashKit.WindowHeight(this); }
    }
    public bool IsFullscreen
    {
        get { return SplashKit.WindowIsFullscreen(this); }
    }
    public Point2D Position
    {
        get { return SplashKit.WindowPosition(this); }
    }
    public Bitmap Icon
    {
          set { SplashKit.WindowSetIcon(this, value); }
    }
    public int Width
    {
        get { return SplashKit.WindowWidth(this); }
    }
    public int X
    {
        get { return SplashKit.WindowX(this); }
    }
    public int Y
    {
        get { return SplashKit.WindowY(this); }
    }
}
public static class Audio{

    public static void FadeOut(int ms)
    {
        SplashKit.FadeMusicOut(ms);
    }


    public static void FreeAllMusic()
    {
        SplashKit.FreeAllMusic();
    }


    public static void Pause()
    {
        SplashKit.PauseMusic();
    }


    public static void Resume()
    {
        SplashKit.ResumeMusic();
    }


    public static void Stop()
    {
        SplashKit.StopMusic();
    }

    public static bool IsReady
    {
        get { return SplashKit.AudioReady(); }
    }
    public static bool Playing
    {
        get { return SplashKit.MusicPlaying(); }
    }
    public static double Volume
    {
        get { return SplashKit.MusicVolume(); }
          set { SplashKit.SetMusicVolume(value); }
    }
}
public static class Camera{

    public static void CenterOn(Sprite s, Vector2D offset)
    {
        SplashKit.CenterCameraOn(s, offset);
    }


    public static void CenterOn(Sprite s, double offsetX, double offsetY)
    {
        SplashKit.CenterCameraOn(s, offsetX, offsetY);
    }


    public static void MoveBy(Vector2D offset)
    {
        SplashKit.MoveCameraBy(offset);
    }


    public static void MoveBy(double dx, double dy)
    {
        SplashKit.MoveCameraBy(dx, dy);
    }


    public static void MoveTo(Point2D pt)
    {
        SplashKit.MoveCameraTo(pt);
    }


    public static void MoveTo(double x, double y)
    {
        SplashKit.MoveCameraTo(x, y);
    }


    public static bool PointInWindow(Window wind, Point2D pt)
    {
        return SplashKit.PointInWindow(wind, pt);
    }


    public static bool PointOnScreen(Point2D pt)
    {
        return SplashKit.PointOnScreen(pt);
    }


    public static bool RectInWindow(Window wind, Rectangle rect)
    {
        return SplashKit.RectInWindow(wind, rect);
    }


    public static bool RectOnScreen(Rectangle rect)
    {
        return SplashKit.RectOnScreen(rect);
    }


    public static Point2D ToScreen(Point2D pt)
    {
        return SplashKit.ToScreen(pt);
    }


    public static Rectangle ToScreen(Rectangle rect)
    {
        return SplashKit.ToScreen(rect);
    }


    public static double ToScreenX(double worldX)
    {
        return SplashKit.ToScreenX(worldX);
    }


    public static double ToScreenY(double worldY)
    {
        return SplashKit.ToScreenY(worldY);
    }


    public static Point2D ToWorld(Point2D pt)
    {
        return SplashKit.ToWorld(pt);
    }


    public static double ToWorldX(double screenX)
    {
        return SplashKit.ToWorldX(screenX);
    }


    public static double ToWorldY(double screenY)
    {
        return SplashKit.ToWorldY(screenY);
    }

    public static Point2D Position
    {
        get { return SplashKit.CameraPosition(); }
          set { SplashKit.SetCameraPosition(value); }
    }
    public static double X
    {
        get { return SplashKit.CameraX(); }
          set { SplashKit.SetCameraX(value); }
    }
    public static double Y
    {
        get { return SplashKit.CameraY(); }
          set { SplashKit.SetCameraY(value); }
    }
    public static Point2D ScreenCenter
    {
        get { return SplashKit.ScreenCenter(); }
    }
    public static Rectangle ScreenRectangle
    {
        get { return SplashKit.ScreenRectangle(); }
    }
    public static Vector2D VectorWorldToScreen
    {
        get { return SplashKit.VectorWorldToScreen(); }
    }
}
public static class Networking{
    public static bool HasMessages
    {
        get { return SplashKit.HasMessages(); }
    }
    public static uint UDPPacketSize
    {
        get { return SplashKit.UDPPacketSize(); }
          set { SplashKit.SetUDPPacketSize(value); }
    }
}
public static class Text{

    public static void FreeAll()
    {
        SplashKit.FreeAllFonts();
    }


    public static int Height(string text, string fnt, int fontSize)
    {
        return SplashKit.TextHeight(text, fnt, fontSize);
    }


    public static int Height(string text, Font fnt, int fontSize)
    {
        return SplashKit.TextHeight(text, fnt, fontSize);
    }


    public static int Width(string text, string fnt, int fontSize)
    {
        return SplashKit.TextWidth(text, fnt, fontSize);
    }


    public static int Width(string text, Font fnt, int fontSize)
    {
        return SplashKit.TextWidth(text, fnt, fontSize);
    }

}
}
