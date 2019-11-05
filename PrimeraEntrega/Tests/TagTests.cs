using Xunit;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

// los tests de la primera entrega no nos funcionan debido a un error que no pudimos solucionar al cambiar el framework a net472.

namespace Tests
{
    public class TagTests
    {
        [Fact]
        public void TagWithName_And_ListAttributes()
        {
            Dictionary<string, Attribute> listaAtributos = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("pedro", "15");
            Attribute attribute2 = new Attribute("marcos", "13");
            listaAtributos.Add(attribute.Key, attribute);
            listaAtributos.Add(attribute2.Key, attribute2);
            Tag tag = new Tag("personas", listaAtributos);
            string NameExpected = "personas";
            Dictionary<string, Attribute> ListaAtributosExpected = listaAtributos;
            Assert.Equal(NameExpected, tag.Name);
            Assert.Equal(ListaAtributosExpected, tag.ListaAtributos);
        }
        [Fact]
        public void TagWithout_ListAttributes()
        {
            Tag tag = new Tag("personas", null);
            string NameExpected = "personas";
            Dictionary<string, Attribute> ListaAtributosExpected = null;
            Assert.Equal(NameExpected, tag.Name);
            Assert.Equal(ListaAtributosExpected, tag.ListaAtributos);
        }
        [Fact]
        public void TagWithName_And_ListAttributesNull()
        {
            Tag tag = new Tag("personas", null);
            string NameExpected = "personas";
            Dictionary<string, Attribute> ListaAtributosExpected = null;
            Assert.Equal(NameExpected, tag.Name);
            Assert.Equal(ListaAtributosExpected, tag.ListaAtributos);
        }
    }
}
