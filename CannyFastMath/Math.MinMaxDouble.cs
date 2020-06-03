using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;

namespace CannyFastMath {

  public static partial class Math {
    
    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Min(double a, double b) {
      if (a <= b || b != b) return a;
      else return b;
    }

    [Pure]
    [NonVersionable, TargetedPatchingOptOut("")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Max(double a, double b) {
      if (b <= a || b != b) return a; 
      else return b;
    }

  }

}