using System;
using System.Diagnostics;
using NUnit.Framework;
using static CannyFastMath.Tests.Helpers;

namespace CannyFastMath.Tests {

  [Performance]
  public class PerformanceTests {

    [Test]
    [TestCase(250000)]
    public void SinCosPerf(int count) {
      var data = new double[count];
      PopulateRandomData(data);

      var output = new double[2];

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i) {
          output[0] = System.Math.Sin(data[i]);
          output[1] = System.Math.Cos(data[i]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.MathF.Sin, System.MathF.Cos processed {count} ints in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i) {
          Math.SinCos(data[i], out output[0], out output[1]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.MathF.SinCos processed {count} ints in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i) {
          (output[0], output[1]) = Math.SinCos(data[i]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.MathF.SinCos processed {count} ints in {t}ms");
      }
    }

    [Test]
    [TestCase(5000000)]
    public void FloorFloatPerf(int count) {
      var data = new float[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          System.MathF.Floor(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.MathF.Floor processed {count} floats in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          MathF.Floor(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.MathF.Floor processed {count} floats in {t}ms");
      }
    }

    [Test]
    [TestCase(5000000)]
    public void CeilingFloatPerf(int count) {
      var data = new float[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          System.MathF.Ceiling(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.MathF.Floor processed {count} floats in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          MathF.Ceiling(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.MathF.Floor processed {count} floats in {t}ms");
      }
    }

    [Test]
    [TestCase(5000000)]
    public void RoundFloatPerf(int count) {
      var data = new float[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          System.MathF.Round(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.MathF.Floor processed {count} floats in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          MathF.Round(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.MathF.Floor processed {count} floats in {t}ms");
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

    [Test]
    [TestCase(2500000)]
    public void Log2UIntPerf(int count) {
      var data = new uint[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          System.Math.Log2(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Log2 processed {count} ints in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          Math.Log2(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Log2 processed {count} ints in {t}ms");
      }
    }

    [Test]
    [TestCase(2500000)]
    public void Log2ULongPerf(int count) {
      var data = new ulong[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          System.Math.Log2(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Log2 processed {count} longs in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
          Math.Log2(data[i]);

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Log2 processed {count} longs in {t}ms");
      }
    }

    [Test]
    [TestCase(5000)]
    public void MinFloatPerf(int count) {
      var floats = new float[count];
      PopulateRandomData(floats);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          System.MathF.Min(floats[i], floats[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.MathF.Min processed {count * count} floats in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          MathF.Min(floats[i], floats[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.MathF.Min processed {count * count} floats in {t}ms");
      }
    }

    [Test]
    [TestCase(5000)]
    public void MaxFloatPerf(int count) {
      var floats = new float[count];
      PopulateRandomData(floats);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          System.MathF.Max(floats[i], floats[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.MathF.Min processed {count * count} floats in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          MathF.Max(floats[i], floats[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.MathF.Min processed {count * count} floats in {t}ms");
      }
    }

    [Test]
    [TestCase(5000)]
    public void MinDoublePerf(int count) {
      var doubles = new double[count];
      PopulateRandomData(doubles);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          System.Math.Min(doubles[i], doubles[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Min processed {count * count} doubles in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          Math.Min(doubles[i], doubles[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Min processed {count * count} doubles in {t}ms");
      }
    }

    [Test]
    [TestCase(5000)]
    public void MaxDoublePerf(int count) {
      var doubles = new double[count];
      PopulateRandomData(doubles);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          System.Math.Max(doubles[i], doubles[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Min processed {count * count} doubles in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          Math.Max(doubles[i], doubles[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Min processed {count * count} doubles in {t}ms");
      }
    }

    [Test]
    [TestCase(10000)]
    public void MinIntPerf(int count) {
      var data = new int[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          System.Math.Min(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Min processed {count * count} ints in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          Math.Min(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Min processed {count * count} ints in {t}ms");
      }
    }

    [Test]
    [TestCase(10000)]
    public void MaxIntPerf(int count) {
      var data = new int[count];
      var result = new int[count];
      PopulateRandomData(data);

      for (var r = 0; r < 2; ++r) {
        {
          var sw = Stopwatch.StartNew();
          for (var i = 0; i < count; ++i)
          for (var j = 0; j < count; ++j) {
            result[j] = System.Math.Max(data[i], data[j]);
          }

          var t = sw.ElapsedMilliseconds;
          Console.WriteLine($"System.Math.Max processed {count * count} ints in {t}ms");
        }
        {
          var sw = Stopwatch.StartNew();
          for (var i = 0; i < count; ++i)
          for (var j = 0; j < count; ++j) {
            result[j] = Math.Max(data[i], data[j]);
          }

          var t = sw.ElapsedMilliseconds;
          Console.WriteLine($"FastMath.Math.Max processed {count * count} ints in {t}ms");
        }
      }
    }

    [Test]
    [TestCase(10000)]
    public void MinUIntPerf(int count) {
      var data = new uint[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          System.Math.Min(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Min processed {count * count} uints in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          Math.Min(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Min processed {count * count} uints in {t}ms");
      }
    }

    [Test]
    [TestCase(10000)]
    public void MaxUIntPerf(int count) {
      var data = new uint[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          System.Math.Max(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Max processed {count * count} uints in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          Math.Max(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Max processed {count * count} uints in {t}ms");
      }
    }

    [Test]
    [TestCase(10000)]
    public void MinLongPerf(int count) {
      var data = new long[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          System.Math.Min(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Min processed {count * count} longs in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          Math.Min(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Min processed {count * count} longs in {t}ms");
      }
    }

    [Test]
    [TestCase(10000)]
    public void MaxLongPerf(int count) {
      var data = new int[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          System.Math.Max(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Max processed {count * count} ints in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          Math.Max(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Max processed {count * count} ints in {t}ms");
      }
    }

    [Test]
    [TestCase(10000)]
    public void MinULongPerf(int count) {
      var data = new ulong[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          System.Math.Min(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Min processed {count * count} ulongs in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          Math.Min(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Min processed {count * count} ulongs in {t}ms");
      }
    }

    [Test]
    [TestCase(10000)]
    public void MaxULongPerf(int count) {
      var data = new int[count];
      PopulateRandomData(data);

      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          System.Math.Max(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"System.Math.Max processed {count * count} ints in {t}ms");
      }
      {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < count; ++i)
        for (var j = 0; j < count; ++j) {
          Math.Max(data[i], data[j]);
        }

        var t = sw.ElapsedMilliseconds;
        Console.WriteLine($"FastMath.Math.Max processed {count * count} ints in {t}ms");
      }
    }

  }

}