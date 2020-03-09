using System.Runtime.CompilerServices;

namespace CannyFastMath {

  public static partial class Math {

    public const double ⅇ = System.Math.E;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Exp(double v)
      => System.Math.Exp(v);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Log(double v)
      => System.Math.Log(v);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Log2(double v)
      => System.Math.Log2(v);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Log10(double v)
      => System.Math.Log10(v);

  }

}