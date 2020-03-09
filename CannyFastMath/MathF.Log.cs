using System.Runtime.CompilerServices;

namespace CannyFastMath {

  public static partial class MathF {

    public const float ⅇ = System.MathF.E;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Exp(float v)
      => System.MathF.Exp(v);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log(float v)
      => System.MathF.Log(v);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log2(float v)
      => System.MathF.Log2(v);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log10(float v)
      => System.MathF.Log10(v);

  }

}