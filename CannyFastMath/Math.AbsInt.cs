using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace CannyFastMath {

  public static partial class Math {

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int AbsNaive(int a)
      => a * Selector(a < 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int AbsSsse3(int a)
      => (int)Sse2.ConvertToUInt32(Ssse3.Abs(Vector128.CreateScalarUnsafe(a)));

#pragma warning disable 162
    // ReSharper disable ConditionIsAlwaysTrueOrFalse
    // ReSharper disable RedundantCast
    // ReSharper disable UnreachableCode

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Abs(int a)
      => SlowMathIntegerAbs ? Ssse3.IsSupported ? AbsSsse3(a) : AbsNaive(a) : System.Math.Abs(a);

    // ReSharper restore UnreachableCode
    // ReSharper restore RedundantCast
    // ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 162
  }

}