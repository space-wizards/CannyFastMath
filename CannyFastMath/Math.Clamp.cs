using System.Diagnostics.Contracts;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace CannyFastMath {

  public static partial class Math {

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double ClampMinMax(double v, double min, double max)
      => Min(max, Max(v, max));

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long ClampMinMax(long v, long min, long max)
      => Min(max, Max(v, max));

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ClampMinMax(int v, int min, int max)
      => Min(max, Max(v, min));

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong ClampMinMax(ulong v, ulong min, ulong max)
      => Min(max, Max(v, max));

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint ClampMinMax(uint v, uint min, uint max)
      => Min(max, Max(v, min));

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long ClampNaive(long v, long min, long max) {
      var lt = Selector(v < min);
      var gt = Selector(v > max);
      var oor = lt | gt;

      return (v & ~ oor) | (lt & min) | (gt & max);
    }

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ClampNaive(int v, int min, int max) {
      var lt = Selector(v < min);
      var gt = Selector(v > max);
      var oor = lt | gt;

      return (v & ~ oor) | (lt & min) | (gt & max);
    }

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong ClampNaive(ulong v, ulong min, ulong max) {
      var lt = (ulong) Selector(v < min);
      var gt = (ulong) Selector(v > max);
      var oor = lt | gt;

      return (v & ~ oor) | (lt & min) | (gt & max);
    }

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint ClampNaive(uint v, uint min, uint max) {
      var lt = (uint) Selector(v < min);
      var gt = (uint) Selector(v > max);
      var oor = lt | gt;

      return (v & ~ oor) | (lt & min) | (gt & max);
    }

#pragma warning disable 162
    // ReSharper disable ConditionIsAlwaysTrueOrFalse
    // ReSharper disable RedundantCast
    // ReSharper disable UnreachableCode

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long Clamp(long v, long min, long max)
      => SlowMathIntegerMinMax ? ClampNaive(v, min, max) : ClampMinMax(v, min, max);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Clamp(int v, int min, int max)
      => SlowMathIntegerMinMax ? ClampNaive(v, min, max) : ClampMinMax(v, min, max);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong Clamp(ulong v, ulong min, ulong max)
      => SlowMathIntegerMinMax ? ClampNaive(v, min, max) : ClampMinMax(v, min, max);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Clamp(uint v, uint min, uint max)
      => SlowMathIntegerMinMax ? ClampNaive(v, min, max) : ClampMinMax(v, min, max);

    // ReSharper restore UnreachableCode
    // ReSharper restore RedundantCast
    // ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 162

  }

}