using System.Runtime.CompilerServices;

namespace CannyFastMath {

  public static partial class Math {

    // ReSharper disable once InconsistentNaming
    public const double π = System.Math.PI;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Sin(double f)
      => System.Math.Sin(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Cos(double f)
      => System.Math.Cos(f);
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SinCos(double v, out double sin, out double cos) {
      sin = Sin(v);
      cos = Cos(v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Asin(double f)
      => System.Math.Asin(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Acos(double f)
      => System.Math.Acos(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Tan(double f)
      => System.Math.Tan(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Atan(double f)
      => System.Math.Atan(f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Atan2(double f, double n)
      => System.Math.Atan2(f, n);

  }

}