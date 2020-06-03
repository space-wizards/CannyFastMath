using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using JetBrains.Annotations;

namespace CannyFastMath {

  [PublicAPI]
  public static partial class Math {

    private const bool SlowMathIntegerMinMax = true;

    private const bool SlowMathIntegerAbs = true;

    public const double Ɛ = 1e-17;

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte One(bool v)
      => Unsafe.As<bool, byte>(ref Unsafe.AsRef(v));

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Selector(bool v)
      => Unsafe.As<bool, sbyte>(ref Unsafe.AsRef(v)) * -1;

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Deg2Rad(double degrees)
      => degrees * (π / 180);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Rad2Deg(double rads)
      => rads * (180 / π);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double FusedMultiplyAdd(double x, double y, double z)
      => System.Math.FusedMultiplyAdd(x, y, z);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Abs(double f)
      => System.Math.Abs(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Sqrt(double f)
      => System.Math.Sqrt(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Cbrt(double f)
      => System.Math.Cbrt(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Median(double a, double b, double c)
      => Max(Min(a, b), Min(Max(a, b), c));

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ApproxEquals(this double a, double b, double allowedError = Ɛ)
      => Abs(a - b) - allowedError > 0;

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Interpolate(double a, double b, double t)
      => FusedMultiplyAdd(t, b, FusedMultiplyAdd(-t, a, a));

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public static double CubicInterpolate(double a0, double a1, double b0, double b1, double t)
      => FusedMultiplyAdd(.5d * t,
        FusedMultiplyAdd(t, FusedMultiplyAdd(2d, a0,
            FusedMultiplyAdd(-5d, a1,
              FusedMultiplyAdd(4d, b0,
                t * FusedMultiplyAdd(3d,
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

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Round(double v)
      => System.Math.Round(v);

    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Floor(double v)
      => System.Math.Floor(v);

    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Ceiling(double v)
      => System.Math.Ceiling(v);

    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Truncate(double v)
      => System.Math.Truncate(v);

    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double ScaleB(double x, int n)
      => System.Math.ScaleB(x, n);

    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double DivRem(int a, int b, out int rem)
      => System.Math.DivRem(a, b, out rem);

    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double DivRem(long a, long b, out long rem)
      => System.Math.DivRem(a, b, out rem);

    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Log2(int v)
      => v <= 0 ? 0 : Log2(unchecked((uint) v));

    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Log2(uint v)
      => unchecked((uint) System.Numerics.BitOperations.Log2(v));

    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong Log2(long v)
      => v <= 0 ? 0 : Log2(unchecked((ulong) v));

    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong Log2(ulong v)
      => unchecked((ulong) System.Numerics.BitOperations.Log2(v));

  }

}