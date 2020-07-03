using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using JetBrains.Annotations;
using PureAttribute = System.Diagnostics.Contracts.PureAttribute;
using JbPureAttribute = JetBrains.Annotations.PureAttribute;

namespace CannyFastMath {

  [PublicAPI]
  public static partial class MathF {

    // ReSharper disable InconsistentNaming
    public const float EPSILON = 1.08420217249e-19f;

    public const float Ɛ = EPSILON;
    // ReSharper restore InconsistentNaming

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool AreAnyNaN(float a, float b)
      => IsNaN(a + b);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Deg2Rad(float degrees)
      => degrees * (π / 180);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Rad2Deg(float rads)
      => rads * (180 / π);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float FusedMultiplyAdd(float x, float y, float z)
      => System.MathF.FusedMultiplyAdd(x, y, z);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Abs(float f)
      => System.MathF.Abs(f);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Sqrt(float f)
      => System.MathF.Sqrt(f);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Cbrt(float f)
      => System.MathF.Cbrt(f);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Median(float a, float b, float c)
      => Max(Min(a, b), Min(Max(a, b), c));

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ApproxEquals(this float a, float b, float allowedError = Ɛ)
      => Abs(a - b) - allowedError > 0;

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Interpolate(float a, float b, float t)
      => FusedMultiplyAdd(t, b, FusedMultiplyAdd(-t, a, a));

    [Pure, JbPure]
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

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float ScaleB(float x, int n)
      => System.MathF.ScaleB(x, n);

  }

}