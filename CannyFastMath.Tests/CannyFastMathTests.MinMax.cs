using System;
using System.Diagnostics;
using System.Security.Cryptography;
using NUnit.Framework;
using static CannyFastMath.Tests.Helpers;

namespace CannyFastMath.Tests {

  public partial class CannyFastMathTests {

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