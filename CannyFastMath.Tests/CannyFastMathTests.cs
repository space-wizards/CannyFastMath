using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using NUnit.Framework;

namespace CannyFastMath.Tests {

  public partial class CannyFastMathTests {

    private unsafe void PopulateRandomData<T>(T[] data) where T : unmanaged {
      var rng = RandomNumberGenerator.Create();

      fixed (void* p = &data[0])
        rng.GetBytes(new Span<byte>(p, data.Length * sizeof(T)));
    }

    private void ChangeNaNs(float[] data, float other = 0) {
      for (var i = 0; i < data.Length; i++) {
        ref var f = ref data[i];
        if (float.IsNaN(f))
          f = other;
      }
    }
    [Test]
    [TestCase(250000)]
    public void SinCosPerf(int count) {
      var data = new float[count];
      PopulateRandomData(data);
      var stash = new float[count*2];

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i) {
          stash[i*2] = System.MathF.Sin(data[i]);
          stash[i*2+1] = System.MathF.Cos(data[i]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.MathF.Sin, System.MathF.Cos processed {count} ints in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          MathF.SinCos(data[i], out stash[i*2], out stash[i*2+1]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.MathF.SinCos processed {count} ints in {t}ms");
      }
    }

    [Test]
    [TestCase(2500000)]
    public void AbsIntPerf(int count) {
      var data = new int[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          System.Math.Abs(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Abs processed {count} ints in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          Math.Abs(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Abs processed {count} ints in {t}ms");
      }
    }

    [Test]
    [TestCase(2500000)]
    public void AbsLongPerf(int count) {
      var data = new long[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          System.Math.Abs(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Abs processed {count} longs in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          Math.Abs(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Abs processed {count} longs in {t}ms");
      }
    }

  }

}