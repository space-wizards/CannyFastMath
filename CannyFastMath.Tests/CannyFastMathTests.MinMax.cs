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
    public void MinFloatEdges(
      [Values(float.NaN, float.PositiveInfinity, float.NegativeInfinity, float.Epsilon, 0, 1)]
      float a,
      [Values(float.NaN, float.PositiveInfinity, float.NegativeInfinity, float.Epsilon, 0, 1)]
      float b
    ) {
      var expected = System.Math.Min(a, b);
      var actual = Math.Min(a, b);
      if (float.IsNaN(expected))
        Assert.IsNaN(actual);
      else
        Assert.AreEqual(
          expected,
          actual
        );
    }

    [Test]
    [TestCase(1000)]
    public void MaxFloatFuzz(int count) {
      var floats = new float[count];
      PopulateRandomData(floats);
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
    public void MaxFloatEdges(
      [Values(float.NaN, float.PositiveInfinity, float.NegativeInfinity, float.Epsilon, 0, 1)]
      float a,
      [Values(float.NaN, float.PositiveInfinity, float.NegativeInfinity, float.Epsilon, 0, 1)]
      float b
    ) {
      var expected = System.Math.Max(a, b);
      var actual = Math.Max(a, b);
      if (float.IsNaN(expected))
        Assert.IsNaN(actual);
      else
        Assert.AreEqual(
          expected,
          actual
        );
    }

    [Test]
    [TestCase(1000)]
    public void MinDoubleFuzz(int count) {
      var floats = new double[count];
      PopulateRandomData(floats);
      for (var i = 0; i < count; ++i)
      for (var j = 0; j < count; ++j) {
        var expected = System.Math.Min(floats[i], floats[j]);
        var actual = Math.Min(floats[i], floats[j]);
        if (double.IsNaN(expected))
          Assert.IsNaN(actual);
        else
          Assert.AreEqual(
            expected,
            actual
          );
      }
    }

    [Test]
    public void MinDoubleEdges(
      [Values(double.NaN, double.PositiveInfinity, double.NegativeInfinity, double.Epsilon, 0, 1)]
      double a,
      [Values(double.NaN, double.PositiveInfinity, double.NegativeInfinity, double.Epsilon, 0, 1)]
      double b
    ) {
      var expected = System.Math.Min(a, b);
      var actual = Math.Min(a, b);
      if (double.IsNaN(expected))
        Assert.IsNaN(actual);
      else
        Assert.AreEqual(
          expected,
          actual
        );
    }

    [Test]
    [TestCase(1000)]
    public void MaxDoubleFuzz(int count) {
      var floats = new double[count];
      PopulateRandomData(floats);
      for (var i = 0; i < count; ++i)
      for (var j = 0; j < count; ++j) {
        var expected = System.Math.Min(floats[i], floats[j]);
        var actual = Math.Min(floats[i], floats[j]);
        if (double.IsNaN(expected))
          Assert.IsNaN(actual);
        else
          Assert.AreEqual(
            expected,
            actual
          );
      }
    }

    [Test]
    public void MaxDoubleEdges(
      [Values(double.NaN, double.PositiveInfinity, double.NegativeInfinity, double.Epsilon, 0, 1)]
      double a,
      [Values(double.NaN, double.PositiveInfinity, double.NegativeInfinity, double.Epsilon, 0, 1)]
      double b
    ) {
      var expected = System.Math.Max(a, b);
      var actual = Math.Max(a, b);
      if (double.IsNaN(expected))
        Assert.IsNaN(actual);
      else
        Assert.AreEqual(
          expected,
          actual
        );
    }

  }

}