using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using PureAttribute = System.Diagnostics.Contracts.PureAttribute;
using JbPureAttribute = JetBrains.Annotations.PureAttribute;

namespace CannyFastMath {

  public static partial class Math {

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Clamp(double v, double min, double max)
      => Max(min, Min(v, max));

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static long ClampMinMax(long v, long min, long max)
      => Max(min, Min(v, max));

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int ClampMinMax(int v, int min, int max)
      => Max(min, Min(v, max));

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ulong ClampMinMax(ulong v, ulong min, ulong max)
      => Max(min, Min(v, max));

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint ClampMinMax(uint v, uint min, uint max)
      => Max(min, Min(v, max));

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static long ClampNaive(long v, long min, long max) {
      var lt = Selector(v < min);
      var gt = Selector(v > max);
      var oor = lt | gt;

      return (v & ~ oor) | (lt & min) | (gt & max);
    }

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int ClampNaive(int v, int min, int max) {
      var lt = Selector(v < min);
      var gt = Selector(v > max);
      var oor = lt | gt;

      return (v & ~ oor) | (lt & min) | (gt & max);
    }

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ulong ClampNaive(ulong v, ulong min, ulong max) {
      var lt = (ulong) Selector(v < min);
      var gt = (ulong) Selector(v > max);
      var oor = lt | gt;

      return (v & ~ oor) | (lt & min) | (gt & max);
    }

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint ClampNaive(uint v, uint min, uint max) {
      var lt = (uint) Selector(v < min);
      var gt = (uint) Selector(v > max);
      var oor = lt | gt;

      return (v & ~ oor) | (lt & min) | (gt & max);
    }

#pragma warning disable 162
// ReSharper disable ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode
    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long Clamp(long v, long min, long max)
      => SlowMathIntegerMinMax ? ClampNaive(v, min, max) : ClampMinMax(v, min, max);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Clamp(int v, int min, int max)
      => SlowMathIntegerMinMax ? ClampNaive(v, min, max) : ClampMinMax(v, min, max);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong Clamp(ulong v, ulong min, ulong max)
      => SlowMathIntegerMinMax ? ClampNaive(v, min, max) : ClampMinMax(v, min, max);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Clamp(uint v, uint min, uint max)
      => SlowMathIntegerMinMax ? ClampNaive(v, min, max) : ClampMinMax(v, min, max);

// ReSharper restore ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode
#pragma warning restore 162

  }

}