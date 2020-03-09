using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace CannyFastMath {

  public static partial class Math {

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static long MinNaive(long a, long b) {
      var sel = (a - b) >> 63;
      return (a & sel) | (b & ~ sel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static long MinBmi1(long a, long b) {
      var sel = (a - b) >> 63;
      return (a & sel) | (long) Bmi1.X64.AndNot((ulong) sel, (ulong) b);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static long MaxNaive(long a, long b) {
      var sel = (a - b) >> 63;
      return (a & ~ sel) | (b & sel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static long MaxBmi1(long a, long b) {
      var sel = (a - b) >> 63;
      return (long) Bmi1.X64.AndNot((ulong) sel, (ulong) a) | (b & sel);
    }

#pragma warning disable 162
    // ReSharper disable ConditionIsAlwaysTrueOrFalse
    // ReSharper disable RedundantCast
    // ReSharper disable UnreachableCode
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long Min(long a, long b)
      => SlowMathIntegerMinMax ? Bmi1.X64.IsSupported ? MinBmi1(a, b) : MinNaive(a, b) : System.Math.Min(a, b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long Max(long a, long b)
      => SlowMathIntegerMinMax ? Bmi1.X64.IsSupported ? MaxBmi1(a, b) : MaxNaive(a, b) : System.Math.Max(a, b);

    // ReSharper restore UnreachableCode
    // ReSharper restore RedundantCast
    // ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 162

  }

}