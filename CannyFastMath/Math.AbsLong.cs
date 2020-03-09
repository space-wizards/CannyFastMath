using System.Runtime.CompilerServices;

namespace CannyFastMath {

  public static partial class Math {

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static long AbsNaive(long a)
      => a * Selector(a < 0);

#pragma warning disable 162
    // ReSharper disable ConditionIsAlwaysTrueOrFalse
    // ReSharper disable RedundantCast
    // ReSharper disable UnreachableCode

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long Abs(long a)
      => SlowMathIntegerAbs ? AbsNaive(a) : System.Math.Abs(a);

    // ReSharper restore UnreachableCode
    // ReSharper restore RedundantCast
    // ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 162
  }

}