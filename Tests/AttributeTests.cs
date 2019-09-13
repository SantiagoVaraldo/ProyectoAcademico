using System;
using Xunit;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
         public class AttributeTests
         {

                  [Fact]
                  public void InvalidKey()
                  {
                           string expected = null;
                           string valor = "nombre";
                           Attribute attribute = new Attribute("", valor);
                           Assert.Equal(attribute.Clave, expected);
                  }

                  [Fact]
                  public void InvalidValue()
                  {
                           string expected = null;
                           string clave = "clave";
                           Attribute attribute = new Attribute(clave, "");
                           Assert.Equal(attribute.Valor, expected);
                  }
                  [Fact]
                  public void ValueAndKeyValid()
                  {
                           string ClaveExpected = "color";
                           string ValorExpected = "rojo";
                           Attribute attribute = new Attribute("color", "rojo");
                           Assert.Equal(attribute.Valor, ValorExpected);
                           Assert.Equal(attribute.Clave, ClaveExpected);
                  }
         }
}