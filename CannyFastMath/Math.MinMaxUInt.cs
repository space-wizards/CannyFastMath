using System.Diagnostics.Contracts;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace CannyFastMath {

  public static partial class Math {

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint MinNaive(uint a, uint b) {
      var sel = (uint) Selector(a < b);
      return (a & sel) | (b & ~ sel);
    }

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint MaxNaive(uint a, uint b) {
      var sel = (uint) Selector(a < b);
      return (a & sel) | (b & ~ sel);
    }

#pragma warning disable 162
// ReSharper disable ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode
    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Min(uint a, uint b)
      => SlowMathIntegerMinMax ? MinNaive(a, b) : System.Math.Min(a, b);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Max(uint a, uint b)
      => SlowMathIntegerMinMax ? MaxNaive(a, b) : System.Math.Max(a, b);

// ReSharper restore ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode
#pragma warning restore 162

  }

}