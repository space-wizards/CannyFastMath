using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using NUnit.Framework;
using static CannyFastMath.Tests.Helpers;

namespace CannyFastMath.Tests {

  public partial class CannyFastMathTests {


    [Test]
    [TestCase(1000)]
    public void FloorFloatFuzz(int count) {
      if (!Sse41.IsSupported)
        Assert.Inconclusive("Need SSE4.1 or fallback is default system function.");
      var floats = new float[count];
      PopulateRandomData(floats);
      // CannyFastMath does not guarantee NaN propagation
      ChangeNaNs(floats, RandomNumberGenerator.GetInt32(int.MinValue, int.MaxValue));

      for (var i = 0; i < count; ++i) {
        var expected = System.MathF.Floor(floats[i]);
        var actual = MathF.Floor(floats[i]);
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
    public void CeilingFloatFuzz(int count) {
      if (!Sse41.IsSupported)
        Assert.Inconclusive("Need SSE4.1 or fallback is default system function.");
      var floats = new float[count];
      PopulateRandomData(floats);
      // CannyFastMath does not guarantee NaN propagation
      ChangeNaNs(floats, RandomNumberGenerator.GetInt32(int.MinValue, int.MaxValue));

      for (var i = 0; i < count; ++i) {
        var expected = System.MathF.Ceiling(floats[i]);
        var actual = MathF.Ceiling(floats[i]);
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
    public void RoundFloatFuzz(int count) {
      if (!Sse41.IsSupported)
        Assert.Inconclusive("Need SSE4.1 or fallback is default system function.");
      var floats = new float[count];
      PopulateRandomData(floats);
      // CannyFastMath does not guarantee NaN propagation
      ChangeNaNs(floats, RandomNumberGenerator.GetInt32(int.MinValue, int.MaxValue));

      for (var i = 0; i < count; ++i) {
        var expected = System.MathF.Round(floats[i]);
        var actual = MathF.Round(floats[i]);
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
    public void TruncateFloatFuzz(int count) {
      if (!Sse41.IsSupported)
        Assert.Inconclusive("Need SSE4.1 or fallback is default system function.");
      var floats = new float[count];
      PopulateRandomData(floats);
      // CannyFastMath does not guarantee NaN propagation
      ChangeNaNs(floats, RandomNumberGenerator.GetInt32(int.MinValue, int.MaxValue));

      for (var i = 0; i < count; ++i) {
        var expected = System.MathF.Truncate(floats[i]);
        var actual = MathF.Truncate(floats[i]);
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