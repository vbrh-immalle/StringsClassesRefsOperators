using System;
using Xunit;
using Exercises;

namespace StringsClassesRefsOperators
{
    public class OperatorsTests
    {
        [Fact]
        public void AndMethodShouldReturnLogicalAndOfTheTwoParameters()
        {
            Assert.True(Operators.And(true, true));
            Assert.False(Operators.And(true, false));
            Assert.False(Operators.And(false, true));
            Assert.False(Operators.And(false, false));
        }
    }
}
