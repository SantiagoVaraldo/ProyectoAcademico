using System;
using Xunit;
using ExerciseOne;
using System.Collections.Generic;
using Finder = ExerciseOne.Finder;

namespace Tests
{
    public class FinderTests
    {

        [Fact]
        public void ClaveInvalida()
        {
            string expected = null;
            string valor = "nombre";
            Finder attribute = new Finder();
            Assert.Equal(attribute.Clave, expected);
        }
    }
}