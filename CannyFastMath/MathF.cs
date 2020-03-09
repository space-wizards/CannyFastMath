using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace CannyFastMath {

  [PublicAPI]
  public static partial class MathF {

    public const float Ɛ = 1e-7f;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Deg2Rad(float degrees)
      => degrees * (π / 180);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Rad2Deg(float rads)
      => rads * (180 / π);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float FusedMultiplyAdd(float x, float y, float z)
      => System.MathF.FusedMultiplyAdd(x, y, z);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Abs(float f)
      => System.MathF.Abs(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Sqrt(float f)
      => System.MathF.Sqrt(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Cbrt(float f)
      => System.MathF.Cbrt(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Median(float a, float b, float c)
      => Max(Min(a, b), Min(Max(a, b), c));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ApproxEquals(this float a, float b, float allowedError = Ɛ)
      => Abs(a - b) - allowedError > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Interpolate(float a, float b, float t)
      => FusedMultiplyAdd(t, b, FusedMultiplyAdd(-t, a, a));

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public static float CubicInterpolate(float a0, float a1, float b0, float b1, float t)
      => FusedMultiplyAdd(.5f * t,
        FusedMultiplyAdd(t, FusedMultiplyAdd(2f, a0,
            FusedMultiplyAdd(-5f, a1,
              FusedMultiplyAdd(4f, b0,
                t * FusedMultiplyAdd(3f,
                  a1 - b0,
                  b1 - a0
                )
              ) - b1
            )
          ),
          b0 - a0
        ),
        a1
      );

    public static float ScaleB(float x, int n)
      => System.MathF.ScaleB(x, n);

  }

}