using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using JetBrains.Annotations;
using PureAttribute = System.Diagnostics.Contracts.PureAttribute;

namespace CannyFastMath {

  [PublicAPI]
  public static partial class MathF {

    // ReSharper disable InconsistentNaming
    public const float EPSILON = 1.08420217249e-19f;

    public const float Ɛ = EPSILON;
    // ReSharper restore InconsistentNaming

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool AreAnyNaN(float a, float b)
      => IsNaN(a + b);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Deg2Rad(float degrees)
      => degrees * (π / 180);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Rad2Deg(float rads)
      => rads * (180 / π);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float FusedMultiplyAdd(float x, float y, float z)
      => System.MathF.FusedMultiplyAdd(x, y, z);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Abs(float f)
      => System.MathF.Abs(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Sqrt(float f)
      => System.MathF.Sqrt(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Cbrt(float f)
      => System.MathF.Cbrt(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Median(float a, float b, float c)
      => Max(Min(a, b), Min(Max(a, b), c));

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ApproxEquals(this float a, float b, float allowedError = Ɛ)
      => Abs(a - b) - allowedError > 0;

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Interpolate(float a, float b, float t)
      => FusedMultiplyAdd(t, b, FusedMultiplyAdd(-t, a, a));

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public static float CubicInterpolate(float a0, float a1, float b0, float b1, float t)
      => FusedMultiplyAdd(.5f * t,
        FusedMultiplyAdd(t, FusedMultiplyAdd(2f, a0,
            FusedMultiplyAdd(-5f, a1,
              FusedMultiplyAdd(4f, b0,
                t * FusedMultiplyAdd(3f,
                  a1 - b0,
                  b1 - a0
                )
              ) - b1
            )
          ),
          b0 - a0
        ),
        a1
      );

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float ScaleB(float x, int n)
      => System.MathF.ScaleB(x, n);

  }

}