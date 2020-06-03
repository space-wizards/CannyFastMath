using System.Diagnostics.Contracts;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;

namespace CannyFastMath {

  public static partial class Math {

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double MinNaive(double a, double b)
      => a > b ? b : a;

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double MaxNaive(double a, double b)
      => a > b ? a : b;

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double MinSse2(double a, double b)
      => Sse2.MinScalar(
        Vector128.CreateScalarUnsafe(a),
        Vector128.CreateScalarUnsafe(b)
      ).ToScalar();

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double MaxSse2(double a, double b)
      => Sse2.MaxScalar(
        Vector128.CreateScalarUnsafe(a),
        Vector128.CreateScalarUnsafe(b)
      ).ToScalar();

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Min(double a, double b)
      => Sse2.IsSupported ? MinSse2(a, b) : MinNaive(a, b);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Max(double a, double b)
      => Sse2.IsSupported ? MaxSse2(a, b) : MaxNaive(a, b);

  }

}