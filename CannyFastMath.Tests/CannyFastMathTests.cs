using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using NUnit.Framework;
using static CannyFastMath.Tests.Helpers;

namespace CannyFastMath.Tests {

  public partial class CannyFastMathTests {

    [Test]
    [TestCase(250)]
    public void SinCosFuzz(int count) {
      var data = new double[count];
      PopulateRandomData(data);

      Assert.Multiple(() => {
        for (var i = 0; i < count; ++i) {
          var v = data[i];
          var expectedSin = System.Math.Sin(v);
          var expectedCos = System.Math.Cos(v);

          Math.SinCos(v, out var actualSin, out var actualCos);

          Assert.AreEqual(expectedSin, actualSin, 1e-10, $"{i} Sin({v}) Cos: {expectedCos} vs. {actualCos}");
          Assert.AreEqual(expectedCos, actualCos, 1e-10, $"{i} Cos({v}) Sin: {expectedSin} vs. {actualSin}");
        }
      });
    }
    [Test]
    [TestCase(1000)]
    public void Log2UIntFuzz(int count) {
      if (!Bmi1.IsSupported)
        Assert.Inconclusive("Need BMI1 or fallback is default system function.");
      var uints = new uint[count];
      PopulateRandomData(uints);

      for (var i = 0; i < count; ++i) {
        var expected = (uint) System.Math.Log2(uints[i]);
        var actual = Math.Log2(uints[i]);
        Assert.AreEqual(
          expected,
          actual,
          $"Log2({uints[i]})"
        );
      }
    }

  }

}