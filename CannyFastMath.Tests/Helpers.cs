using System;
using System.Security.Cryptography;

namespace CannyFastMath.Tests {

  public static class Helpers {

    // using static readonly instead of const to avoid warnings
    public static readonly bool DebugBuild;

    static Helpers() {
#if DEBUG
      DebugBuild = true;
#else
      DebugBuild = false;
#endif
    }

    public static unsafe void PopulateRandomData<T>(T[] data) where T : unmanaged {
      var rng = RandomNumberGenerator.Create();

      fixed (void* p = &data[0])
        rng.GetBytes(new Span<byte>(p, data.Length * sizeof(T)));
    }

    public static void ChangeNaNs(float[] data, float other = 0) {
      for (var i = 0; i < data.Length; i++) {
        ref var f = ref data[i];
        if (float.IsNaN(f))
          f = other;
      }
    }

  }

}