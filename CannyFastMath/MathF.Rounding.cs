using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;

namespace CannyFastMath {

  public static partial class MathF {
    
    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float FloorSse41(float x) {
      var f = Vector128.CreateScalarUnsafe(x);
      var r = Sse41.FloorScalar(f);
      return r.ToScalar();
    }
    
    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float CeilingSse41(float x) {
      var f = Vector128.CreateScalarUnsafe(x);
      var r = Sse41.CeilingScalar(f);
      return r.ToScalar();
    }
    
    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float RoundSse41(float x) {
      var f = Vector128.CreateScalarUnsafe(x);
      var r = Sse41.RoundToNearestIntegerScalar(f);
      return r.ToScalar();
    }

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float TruncateSse41(float x) {
      var f = Vector128.CreateScalarUnsafe(x);
      var r = Sse41.RoundToZero(f);
      return r.ToScalar();
    }

#pragma warning disable 162
    // ReSharper disable ConditionIsAlwaysTrueOrFalse
    // ReSharper disable RedundantCast
    // ReSharper disable UnreachableCode

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Floor(float a)
      => Sse41.IsSupported ? FloorSse41(a) : System.MathF.Floor(a);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Ceiling(float a)
      => Sse41.IsSupported ? CeilingSse41(a) : System.MathF.Ceiling(a);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Round(float a)
      => Sse41.IsSupported ? RoundSse41(a) : System.MathF.Round(a);

    [NonVersionable]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Truncate(float a)
      => Sse41.IsSupported ? TruncateSse41(a) : System.MathF.Truncate(a);

    // ReSharper restore UnreachableCode
    // ReSharper restore RedundantCast
    // ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 162

  }

}