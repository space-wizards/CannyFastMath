using System.Diagnostics.Contracts;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace CannyFastMath {

  public static partial class MathF {

    public const float ⅇ = System.MathF.E;

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Exp(float v)
      => System.MathF.Exp(v);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log(float v)
      => System.MathF.Log(v);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log2(float v)
      => System.MathF.Log2(v);

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log10(float v)
      => System.MathF.Log10(v);

  }

}