using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using PureAttribute = System.Diagnostics.Contracts.PureAttribute;
using JbPureAttribute = JetBrains.Annotations.PureAttribute;

namespace CannyFastMath {

  public static partial class MathF {

    // ReSharper disable InconsistentNaming
    public const float E = (float) Math.E;

    public const float LOG2 = (float) Math.LOG2;

    public const float LOG8 = (float) Math.LOG8;

    public const float LOG10 = (float) Math.LOG10;

    public const float LOG12 = (float) Math.LOG12;

    public const float LOG16 = (float) Math.LOG16;

    public const float LOG32 = (float) Math.LOG32;

    public const float LOG36 = (float) Math.LOG36;

    public const float LOG64 = (float) Math.LOG64;

    public const float ⅇ = E;

    public const float ln2 = LOG2;

    public const float ln8 = LOG8;

    public const float ln10 = LOG10;

    public const float ln12 = LOG12;

    public const float ln16 = LOG16;

    public const float ln32 = LOG32;

    public const float ln36 = LOG36;

    public const float ln64 = LOG64;
    // ReSharper restore InconsistentNaming

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Exp(float v)
      => System.MathF.Exp(v);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log(float v)
      => System.MathF.Log(v);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log(float v, float b)
      => System.MathF.Log(v, b);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log2(float v)
      => System.MathF.Log2(v);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log10(float v)
      => System.MathF.Log10(v);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Pow(float v, float b)
      => System.MathF.Pow(v, b);

  }

}