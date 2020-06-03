using System.Diagnostics.Contracts;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace CannyFastMath {

  public static partial class MathF {

    // ReSharper disable once InconsistentNaming
    public const float π = System.MathF.PI;

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Sin(float f)
      => System.MathF.Sin(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Cos(float f)
      => System.MathF.Cos(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public static void SinCos(float v, out float sin, out float cos) {
      sin = Sin(v);
      cos = Cos(v);
    }

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Asin(float f)
      => System.MathF.Asin(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Acos(float f)
      => System.MathF.Acos(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Tan(float f)
      => System.MathF.Tan(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Atan(float f)
      => System.MathF.Atan(f);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Atan2(float f, float n)
      => System.MathF.Atan2(f, n);

  }

}