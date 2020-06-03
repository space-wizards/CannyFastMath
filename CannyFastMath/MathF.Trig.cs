using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace CannyFastMath {

  public static partial class MathF {

    // ReSharper disable once InconsistentNaming
    public const float π = System.MathF.PI;

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Sin(float f)
      => System.MathF.Sin(f);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Cos(float f)
      => System.MathF.Cos(f);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public static void SinCos(float v, out float sin, out float cos) {
      sin = Sin(v);
      cos = Cos(v);
    }

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Asin(float f)
      => System.MathF.Asin(f);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Acos(float f)
      => System.MathF.Acos(f);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Tan(float f)
      => System.MathF.Tan(f);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Atan(float f)
      => System.MathF.Atan(f);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Atan2(float f, float n)
      => System.MathF.Atan2(f, n);

  }

}