using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using PureAttribute = System.Diagnostics.Contracts.PureAttribute;
using JbPureAttribute = JetBrains.Annotations.PureAttribute;

namespace CannyFastMath {

  public static partial class MathF {

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float MinNaive(float a, float b)
      => a > b ? b : a;

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float MaxNaive(float a, float b)
      => a > b ? a : b;

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float MinSse(float a, float b)
      => Sse.MinScalar(
        Vector128.CreateScalarUnsafe(a),
        Vector128.CreateScalarUnsafe(b)
      ).ToScalar();

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float MaxSse(float a, float b)
      => Sse.MaxScalar(
        Vector128.CreateScalarUnsafe(a),
        Vector128.CreateScalarUnsafe(b)
      ).ToScalar();

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Min(float a, float b) {
      if (AreAnyNaN(a, b)) return float.NaN;

      return Sse.IsSupported ? MinSse(a, b) : MinNaive(a, b);
    }

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Max(float a, float b) {
      if (AreAnyNaN(a, b)) return float.NaN;

      return Sse.IsSupported ? MaxSse(a, b) : MaxNaive(a, b);
    }

  }

}