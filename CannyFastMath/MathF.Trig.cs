using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace CannyFastMath {

  public static partial class MathF {

    // ReSharper disable once InconsistentNaming
    public const float π = System.MathF.PI;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Sin(float f)
      => System.MathF.Sin(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Cos(float f)
      => System.MathF.Cos(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SinCos(float v, out float sin, out float cos) {
      sin = Sin(v);
      cos = Cos(v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Asin(float f)
      => System.MathF.Asin(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Acos(float f)
      => System.MathF.Acos(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Tan(float f)
      => System.MathF.Tan(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Atan(float f)
      => System.MathF.Atan(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Atan2(float f, float n)
      => System.MathF.Atan2(f, n);

  }

}