using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace CannyFastMath {

  public static partial class Math {

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint MinNaive(uint a, uint b) {
      var sel = (uint) Selector(a < b);
      return (a & sel) | (b & ~ sel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint MinBmi1(uint a, uint b) {
      var sel = (uint) Selector(a < b);
      return (a & sel) | Bmi1.AndNot(sel, b);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint MinSse41(uint a, uint b)
      => Sse2.ConvertToUInt32(
        Sse41.Min(
          Vector128.CreateScalarUnsafe(a),
          Vector128.CreateScalarUnsafe(b)
        )
      );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint MaxNaive(uint a, uint b) {
      var sel = (uint) Selector(a < b);
      return (a & sel) | (b & ~ sel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint MaxBmi1(uint a, uint b) {
      var sel = (uint) Selector(a < b);
      return (a & sel) | Bmi1.AndNot(sel, b);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint MaxSse41(uint a, uint b)
      => Sse2.ConvertToUInt32(
        Sse41.Max(
          Vector128.CreateScalarUnsafe(a),
          Vector128.CreateScalarUnsafe(b)
        )
      );

#pragma warning disable 162
    // ReSharper disable ConditionIsAlwaysTrueOrFalse
    // ReSharper disable RedundantCast
    // ReSharper disable UnreachableCode

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Min(uint a, uint b)
      => SlowMathIntegerMinMax ? Sse41.IsSupported ? MinSse41(a, b) : Bmi1.IsSupported ? MinBmi1(a, b) : MinNaive(a, b) : System.Math.Min(a, b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Max(uint a, uint b)
      => SlowMathIntegerMinMax ? Sse41.IsSupported ? MaxSse41(a, b) : Bmi1.IsSupported ? MaxBmi1(a, b) : MaxNaive(a, b) : System.Math.Max(a, b);

    // ReSharper restore UnreachableCode
    // ReSharper restore RedundantCast
    // ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 162

  }

}