using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using PureAttribute = System.Diagnostics.Contracts.PureAttribute;
using JbPureAttribute = JetBrains.Annotations.PureAttribute;

namespace CannyFastMath {

  public static partial class Math {

    // ReSharper disable InconsistentNaming
    public const double E = 2.7182818284_5904523536_0287471352_6624977572_4709369995;

    public const double LOG2 = 0.6931471805_5994530941_7232121458_1765680755_0013436025;

    public const double LOG8 = 2.0794415416_7983592825_1696364374_5297042265_0040308076;

    public const double LOG10 = 2.3025850929_9404568401_7991454684_3642076011_0148862877;

    public const double LOG12 = 2.4849066497_8800031022_9709479838_8788407984_9082654325;

    public const double LOG16 = 2.7725887222_3978123766_8928485832_7062723020_0053744102;

    public const double LOG32 = 3.4657359027_9972654708_6160607290_8828403775_0067180127;

    public const double LOG36 = 3.5835189384_5611000162_4954716761_4045454459_8138436600;

    public const double LOG64 = 4.1588830833_5967185650_3392728749_0594084530_0080616153;

    public const double ⅇ = E;

    public const double ln2 = LOG2;

    public const double ln8 = LOG8;

    public const double ln10 = LOG10;

    public const double ln12 = LOG12;

    public const double ln16 = LOG16;

    public const double ln32 = LOG32;

    public const double ln36 = LOG36;

    public const double ln64 = LOG64;
    // ReSharper restore InconsistentNaming

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Exp(double v)
      => System.Math.Exp(v);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Log(double v)
      => System.Math.Log(v);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Log(double v, double b)
      => System.Math.Log(v, b);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Log2(double v)
      => System.Math.Log2(v);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Log10(double v)
      => System.Math.Log10(v);

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Log2(int v)
      => v <= 0 ? 0 : Log2(unchecked((uint) v));

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Log2(uint v)
      => unchecked((uint) System.Numerics.BitOperations.Log2(v));

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong Log2(long v)
      => v <= 0 ? 0 : Log2(unchecked((ulong) v));

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong Log2(ulong v)
      => unchecked((ulong) System.Numerics.BitOperations.Log2(v));

    [Pure, JbPure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Pow(double v, double b)
      => System.Math.Pow(v, b);

  }

}