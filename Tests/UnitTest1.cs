using System;
using Xunit;
using ExerciseOne;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ClaveInvalida()
        {
            string expected = null;
            string valor = "nombre";
            Attribute attribute = new Attribute("", valor);
            Assert.Equal(attribute.Clave, expected);
        }

        [Fact]
        public void ValorInvalido()
        {
            string expected = null;
            string clave = "clave";
            Attribute attribute = new Attribute(clave, "");
            Assert.Equal(attribute.Valor, expected);
        }
    }
}
