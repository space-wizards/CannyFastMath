using System;
using System.Globalization;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using static CannyFastMath.Tests.Helpers;

namespace CannyFastMath.Tests {

  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Assembly, Inherited = false)]
  public class PerformanceAttribute : NUnitAttribute, IApplyToTest {

    public void ApplyToTest(Test test) {
      test.Properties.Add(PropertyNames.Category, "Performance");

      if (test.RunState == RunState.NotRunnable)
        return;

      if (DebugBuild) {
        test.RunState = RunState.Ignored;
        test.Properties.Set(PropertyNames.SkipReason, "This test is only representative of performance on Release builds.");
      }
      else {
        test.RunState = RunState.Explicit;
      }
    }

  }

}