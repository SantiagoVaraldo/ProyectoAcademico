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
            Dictionary<string, Attribute> attributeList = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("pedro", "15");
            Attribute attribute2 = new Attribute("marcos", "13");
            attributeList.Add(attribute.Key, attribute);
            attributeList.Add(attribute2.Key, attribute2);
            Tag tag = new Tag("personas", attributeList);
            string nameExpected = "personas";
            Dictionary<string, Attribute> ListaAtributosExpected = attributeList;
            Assert.Equal(nameExpected, tag.Name);
            Assert.Equal(ListaAtributosExpected, tag.AttributeList);
        }
        [Fact]
        public void TagWithout_ListAttributes()
        {
            Tag tag = new Tag("personas", null);
            string nameExpected = "personas";
            Dictionary<string, Attribute> ListaAtributosExpected = null;
            Assert.Equal(nameExpected, tag.Name);
            Assert.Equal(ListaAtributosExpected, tag.AttributeList);
        }
        [Fact]
        public void TagWithName_And_ListAttributesNull()
        {
            Tag tag = new Tag("personas", null);
            string nameExpected = "personas";
            Dictionary<string, Attribute> ListaAtributosExpected = null;
            Assert.Equal(nameExpected, tag.Name);
            Assert.Equal(ListaAtributosExpected, tag.AttributeList);
        }
    }
}
