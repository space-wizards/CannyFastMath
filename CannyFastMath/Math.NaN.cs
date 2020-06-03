using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using JetBrains.Annotations;

namespace CannyFastMath {

  public static partial class Math {

#pragma warning disable 162
    // ReSharper disable ConditionIsAlwaysTrueOrFalse
    // ReSharper disable RedundantCast
    // ReSharper disable UnreachableCode

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNaN(double x)
      => double.IsNaN(x);

    // ReSharper restore UnreachableCode
    // ReSharper restore RedundantCast
    // ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 162

  }

}