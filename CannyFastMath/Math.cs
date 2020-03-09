using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace CannyFastMath {

  [PublicAPI]
  public static partial class Math {

    private const bool SlowMathIntegerMinMax = true;

    private const bool SlowMathIntegerAbs = true;

    public const double Ɛ = 1e-17;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte One(in bool v)
      => Unsafe.As<bool, sbyte>(ref Unsafe.AsRef(v));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Selector(in bool v)
      => Unsafe.As<bool, sbyte>(ref Unsafe.AsRef(v)) * -1;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Deg2Rad(double degrees)
      => degrees * (π / 180);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Rad2Deg(double rads)
      => rads * (180 / π);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double FusedMultiplyAdd(double x, double y, double z)
      => System.Math.FusedMultiplyAdd(x, y, z);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Abs(double f)
      => System.Math.Abs(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Sqrt(double f)
      => System.Math.Sqrt(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Cbrt(double f)
      => System.Math.Cbrt(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Median(double a, double b, double c)
      => Max(Min(a, b), Min(Max(a, b), c));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ApproxEquals(this double a, double b, double allowedError = Ɛ)
      => Abs(a - b) - allowedError > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Interpolate(double a, double b, double t)
      => FusedMultiplyAdd(t, b, FusedMultiplyAdd(-t, a, a));

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

    public static double Round(double v)
      => System.Math.Round(v);

    public static double Floor(double v)
      => System.Math.Floor(v);

    public static double Ceiling(double v)
      => System.Math.Ceiling(v);

    public static double Truncate(double v)
      => System.Math.Truncate(v);
    
    public static double ScaleB(double x, int n)
      => System.Math.ScaleB(x, n);
    
    public static double DivRem(int a, int b, out int rem)
      => System.Math.DivRem(a, b, out rem);
    
    public static double DivRem(long a, long b, out long rem)
      => System.Math.DivRem(a, b, out rem);

  }

}