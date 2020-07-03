using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using PureAttribute = System.Diagnostics.Contracts.PureAttribute;
using JbPureAttribute = JetBrains.Annotations.PureAttribute;

namespace CannyFastMath {

  public static partial class Math {

#pragma warning disable 162, 1718
// ReSharper disable ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode, EqualExpressionComparison, CompareOfFloatsByEqualityOperator

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNaN(double x)
      => x != x;

// ReSharper restore ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode, EqualExpressionComparison, CompareOfFloatsByEqualityOperator
#pragma warning restore 162, 1718

  }

}