using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using PureAttribute = System.Diagnostics.Contracts.PureAttribute;
using JbPureAttribute = JetBrains.Annotations.PureAttribute;

namespace CannyFastMath {

  public static partial class Math {

    // ReSharper disable InconsistentNaming
    public const double PI = 3.1415926535_8979323846_2643383279_5028841971_6939937510;

    public const double TAU = 6.2831853071_7958647692_5286766559_0057683943_3879875021;

    public const double π = PI;

    public const double τ = TAU;
    // ReSharper restore InconsistentNaming

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Sin(double f)
      => System.Math.Sin(f);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Cos(double f)
      => System.Math.Cos(f);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SinCos(double v, out double sin, out double cos) {
      sin = Sin(v);
      cos = Cos(v);
    }

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static (double Sin, double Cos) SinCos(double v)
      => (Sin(v), Cos(v));

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Asin(double f)
      => System.Math.Asin(f);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Acos(double f)
      => System.Math.Acos(f);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Tan(double f)
      => System.Math.Tan(f);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Atan(double f)
      => System.Math.Atan(f);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Atan2(double f, double n)
      => System.Math.Atan2(f, n);

  }

}