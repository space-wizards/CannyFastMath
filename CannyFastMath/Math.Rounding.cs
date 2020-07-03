using System;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using PureAttribute = System.Diagnostics.Contracts.PureAttribute;
using JbPureAttribute = JetBrains.Annotations.PureAttribute;

namespace CannyFastMath {

  public static partial class Math {

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double RoundSse41(double v)
      => Sse41.RoundCurrentDirectionScalar(Vector128.CreateScalarUnsafe(v)).ToScalar();

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double FloorSse41(double v)
      => Sse41.FloorScalar(Vector128.CreateScalarUnsafe(v)).ToScalar();

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double CeilingSse41(double v)
      => Sse41.CeilingScalar(Vector128.CreateScalarUnsafe(v)).ToScalar();

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double TruncateSse41(double v)
      => Sse41.RoundToZeroScalar(Vector128.CreateScalarUnsafe(v)).ToScalar();

    [System.Diagnostics.Contracts.Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double RoundSse41(double x, MidpointRounding mpr) {
      var f = Vector128.CreateScalarUnsafe(x);
      return (mpr switch {
        MidpointRounding.ToEven => Sse41.RoundToNearestIntegerScalar(f),
        MidpointRounding.AwayFromZero => Sse41.RoundCurrentDirectionScalar(f),
        MidpointRounding.ToZero => Sse41.RoundToZeroScalar(f),
        MidpointRounding.ToNegativeInfinity => Sse41.RoundToNegativeInfinityScalar(f),
        MidpointRounding.ToPositiveInfinity => Sse41.RoundToPositiveInfinityScalar(f),
        _ => throw new ArgumentOutOfRangeException(nameof(mpr), mpr, "Midpoint Rounding must be a valid value.")
      }).ToScalar();
    }
    
    
#pragma warning disable 162
// ReSharper disable ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode
    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Floor(double a)
      => Sse41.IsSupported ? FloorSse41(a) : System.Math.Floor(a);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Ceiling(double a)
      => Sse41.IsSupported ? CeilingSse41(a) : System.Math.Ceiling(a);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Round(double a)
      => Sse41.IsSupported ? RoundSse41(a) : System.Math.Round(a, MidpointRounding.AwayFromZero);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Truncate(double a)
      => Sse41.IsSupported ? TruncateSse41(a) : System.Math.Truncate(a);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Round(double a, MidpointRounding mpr)
      => Sse41.IsSupported ? RoundSse41(a, mpr) : System.Math.Round(a, mpr);

// ReSharper restore ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode
#pragma warning restore 162
    
  }

}