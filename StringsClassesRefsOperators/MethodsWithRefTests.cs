using System;
using Xunit;
using Exercises;

namespace StringsClassesRefsOperators
{
    public class MethodsWithRefTests
    {
        [Fact]
        public void ChangeTo10ShouldChangeTheIntParameterTo10()
        {
            var x = 3;
            MethodsWithRefs.ChangeTo10(ref x);

            Assert.Equal(10, x);
        }
    }
}
