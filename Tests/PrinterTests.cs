using System;
using Xunit;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
         public class PrinterTests
         {
                  [Fact]
                  public void CorrectCreationofaTagWithTwoParamos()
                  {
                           Printer printer = new Printer();
                           List<string> listaString = new List<string>();
                           listaString.Add("PrimerTag");
                           listaString.Add("SegundoTag");
                           listaString.Add("ClaveAtributo");
                           listaString.Add("ValorAtributo");
                  }
                  [Fact]
                  public void CreationOfATagWithASingleParameter_WithoutAtibutos()
                  {
                           Tag tag = new Tag("personas");
                           string NameExpected = "personas";
                           List<Attribute> ListaAtributosExpected = null;
                           Assert.Equal(NameExpected, tag.Name);
                           Assert.Equal(ListaAtributosExpected, tag.ListaAtributos);
                  }
                  [Fact]
                  public void CreatingaTagWithTwoParameters_ListNullAttributes()
                  {
                           Tag tag = new Tag("personas", null);
                           string NameExpected = "personas";
                           List<Attribute> ListaAtributosExpected = null;
                           Assert.Equal(NameExpected, tag.Name);
                           Assert.Equal(ListaAtributosExpected, tag.ListaAtributos);
                  }
         }
}
