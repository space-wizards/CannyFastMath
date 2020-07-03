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
    private static int MinNaive(int a, int b) {
      var sel = Selector(a < b);
      return (a & sel) | (b & ~ sel);
    }

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MaxNaive(int a, int b) {
      var sel = Selector(a < b);
      return (a & ~ sel) | (b & sel);
    }

#pragma warning disable 162
    // ReSharper disable ConditionIsAlwaysTrueOrFalse
    // ReSharper disable RedundantCast
    // ReSharper disable UnreachableCode

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Min(int a, int b)
      => SlowMathIntegerMinMax ? MinNaive(a, b) : System.Math.Min(a, b);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Max(int a, int b)
      => SlowMathIntegerMinMax ? MaxNaive(a, b) : System.Math.Max(a, b);

    // ReSharper restore UnreachableCode
    // ReSharper restore RedundantCast
    // ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 162

  }

}