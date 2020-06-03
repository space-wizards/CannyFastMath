using System.Runtime.CompilerServices;

namespace CannyFastMath {

  public static partial class MathF {

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Clamp(float v, float min, float max)
      => Min(max, Max(v, max));

  }

}