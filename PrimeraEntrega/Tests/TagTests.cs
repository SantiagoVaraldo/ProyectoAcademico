using Xunit;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

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
            listaAtributos.Add(attribute.Clave, attribute);
            listaAtributos.Add(attribute2.Clave, attribute2);
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
