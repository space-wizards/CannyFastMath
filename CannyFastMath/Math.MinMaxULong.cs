using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace CannyFastMath {

  public static partial class Math {

#pragma warning disable 162
    // ReSharper disable ConditionIsAlwaysTrueOrFalse
    // ReSharper disable RedundantCast
    // ReSharper disable UnreachableCode

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong Min(ulong a, ulong b)
      => System.Math.Min(a, b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong Max(ulong a, ulong b)
      => System.Math.Max(a, b);

    // ReSharper restore UnreachableCode
    // ReSharper restore RedundantCast
    // ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 162

  }

}