using System;
using System.Diagnostics;
using System.Security.Cryptography;
using NUnit.Framework;

namespace CannyFastMath.Tests {

  public partial class CannyFastMathTests {

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

    [Test]
    [TestCase(1000)]
    public void MinFloatFuzz(int count) {
      var floats = new float[count];
      PopulateRandomData(floats);
      // CannyFastMath does not guarantee NaN propagation
      ChangeNaNs(floats, RandomNumberGenerator.GetInt32(int.MinValue, int.MaxValue));

      for (var i = 0; i < count; ++i)
      for (var j = 0; j < count; ++j) {
        var expected = System.MathF.Min(floats[i], floats[j]);
        var actual = MathF.Min(floats[i], floats[j]);
        if (float.IsNaN(expected))
          Assert.IsNaN(actual);
        else
          Assert.AreEqual(
            expected,
            actual
          );
      }
    }

    [Test]
    [TestCase(1000)]
    public void MaxFloatFuzz(int count) {
      var floats = new float[count];
      PopulateRandomData(floats);
      // CannyFastMath does not guarantee NaN propagation
      ChangeNaNs(floats, RandomNumberGenerator.GetInt32(int.MinValue, int.MaxValue));

      for (var i = 0; i < count; ++i)
      for (var j = 0; j < count; ++j) {
        var expected = System.MathF.Min(floats[i], floats[j]);
        var actual = MathF.Min(floats[i], floats[j]);
        if (float.IsNaN(expected))
          Assert.IsNaN(actual);
        else
          Assert.AreEqual(
            expected,
            actual
          );
      }
    }

  }

}