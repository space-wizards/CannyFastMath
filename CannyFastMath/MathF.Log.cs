using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace CannyFastMath {

  public static partial class MathF {

    public const float ⅇ = System.MathF.E;

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Exp(float v)
      => System.MathF.Exp(v);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log(float v)
      => System.MathF.Log(v);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log2(float v)
      => System.MathF.Log2(v);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Log10(float v)
      => System.MathF.Log10(v);

  }

}