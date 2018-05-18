using System;
using Xunit;
using Exercises;

namespace StringsClassesRefsOperators
{
    public class StringTests
    {
        [Fact]
        public void SplitsNamenShouldSplitDashSeperatedNames()
        {
            var namenString = "Joske-Willy-Hippoliet";

            var result = Strings.SplitsNamen(namenString);

            Assert.Equal(3, result.Length);
            Assert.Contains("Joske", result);
            Assert.Contains("Willy", result);
            Assert.Contains("Hippoliet", result);
        }
    }
}
