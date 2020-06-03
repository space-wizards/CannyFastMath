using System;
using System.Diagnostics.Contracts;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;

namespace CannyFastMath {

  public static partial class MathF {

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float FloorSse41(float x) {
      var f = Vector128.CreateScalarUnsafe(x);
      var r = Sse41.FloorScalar(f);
      return r.ToScalar();
    }

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float CeilingSse41(float x) {
      var f = Vector128.CreateScalarUnsafe(x);
      var r = Sse41.CeilingScalar(f);
      return r.ToScalar();
    }

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float RoundSse41(float x) {
      var f = Vector128.CreateScalarUnsafe(x);
      var r = Sse41.RoundCurrentDirectionScalar(f);
      return r.ToScalar();
    }

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float TruncateSse41(float x) {
      var f = Vector128.CreateScalarUnsafe(x);
      var r = Sse41.RoundToZero(f);
      return r.ToScalar();
    }

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float RoundSse41(float x, MidpointRounding mpr) {
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
    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Floor(float a)
      => Sse41.IsSupported ? FloorSse41(a) : System.MathF.Floor(a);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Ceiling(float a)
      => Sse41.IsSupported ? CeilingSse41(a) : System.MathF.Ceiling(a);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Round(float a)
      => Sse41.IsSupported ? RoundSse41(a) : System.MathF.Round(a, MidpointRounding.AwayFromZero);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Truncate(float a)
      => Sse41.IsSupported ? TruncateSse41(a) : System.MathF.Truncate(a);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Round(float a, MidpointRounding mpr)
      => Sse41.IsSupported ? RoundSse41(a, mpr) : System.MathF.Round(a, mpr);

// ReSharper restore ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode
#pragma warning restore 162

  }

}