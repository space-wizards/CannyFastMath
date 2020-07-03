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
    private static int AbsNaive(int a)
      => a * Selector(a < 0);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int AbsSsse3(int a)
      => (int) Sse2.ConvertToUInt32(Ssse3.Abs(Vector128.CreateScalarUnsafe(a)));

#pragma warning disable 162
// ReSharper disable ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode
    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Abs(int a)
      => SlowMathIntegerAbs ? Ssse3.IsSupported ? AbsSsse3(a) : AbsNaive(a) : System.Math.Abs(a);

// ReSharper restore ConditionIsAlwaysTrueOrFalse, RedundantCast, UnreachableCode
#pragma warning restore 162

  }

}