using System.Diagnostics.Contracts;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;

namespace CannyFastMath {

  public static partial class MathF {

#pragma warning disable 162, 1718
// ReSharper disable ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode, EqualExpressionComparison, CompareOfFloatsByEqualityOperator

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNaN(float x)
      => x != x;

// ReSharper restore ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode, EqualExpressionComparison, CompareOfFloatsByEqualityOperator
#pragma warning restore 162, 1718

  }

}