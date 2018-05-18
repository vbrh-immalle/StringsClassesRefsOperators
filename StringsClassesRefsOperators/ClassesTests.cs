using System;
using Xunit;
using Exercises;

namespace StringsClassesRefsOperators
{
    public class ClassesTests
    {
        [Fact]
        public void LeerlingClassShouldHaveAWorkingToStringMethod()
        {
            var lln = new Leerling();
            lln.Naam = "Joske";
            lln.Klas = "5ITN";

            Assert.Equal("Joske (5ITN)", lln.ToString());
        }
    }
}
