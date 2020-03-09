using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace CannyFastMath {

  public static partial class Math {

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MinNaive(int a, int b) {
      var sel = (a - b) >> 31;
      return (a & sel) | (b & ~ sel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MinBmi1(int a, int b) {
      var sel = (a - b) >> 31;
      return (a & sel) | (int) Bmi1.AndNot((uint) sel, (uint) b);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MinSse2(int a, int b)
      => Sse2.ConvertToInt32WithTruncation(Sse2.MinScalar(
        Vector128.CreateScalarUnsafe((double) a),
        Vector128.CreateScalarUnsafe((double) b)
      ));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MinSse41(int a, int b)
      => Sse41.Min(
        Vector128.CreateScalarUnsafe(a),
        Vector128.CreateScalarUnsafe(b)
      ).ToScalar();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MaxNaive(int a, int b) {
      var sel = (a - b) >> 31;
      return (a & ~ sel) | (b & sel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MaxBmi1(int a, int b) {
      var sel = (a - b) >> 31;
      return (int) Bmi1.X64.AndNot((uint) sel, (uint) a) | (b & sel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MaxSse2(int a, int b)
      => Sse2.ConvertToInt32WithTruncation(Sse2.MaxScalar(
        Vector128.CreateScalarUnsafe((double) a),
        Vector128.CreateScalarUnsafe((double) b)
      ));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MaxSse41(int a, int b)
      => Sse41.Max(
        Vector128.CreateScalarUnsafe(a),
        Vector128.CreateScalarUnsafe(b)
        ).ToScalar();

#pragma warning disable 162
    // ReSharper disable ConditionIsAlwaysTrueOrFalse
    // ReSharper disable RedundantCast
    // ReSharper disable UnreachableCode

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Min(int a, int b)
      => SlowMathIntegerMinMax ? Sse41.IsSupported ? MinSse41(a,b) : Sse2.IsSupported ? MinSse2(a, b) : Bmi1.IsSupported ? MinBmi1(a, b) : MinNaive(a, b) : System.Math.Min(a, b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Max(int a, int b)
      => SlowMathIntegerMinMax ? Sse41.IsSupported ? MaxSse41(a,b) :Sse2.IsSupported ? MaxSse2(a, b) : Bmi1.IsSupported ? MaxBmi1(a, b) : MaxNaive(a, b) : System.Math.Max(a, b);

    // ReSharper restore UnreachableCode
    // ReSharper restore RedundantCast
    // ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 162

  }

}