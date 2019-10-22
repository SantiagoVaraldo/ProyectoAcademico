using Xunit;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
    public class FormaterTests
    {
        [Fact]
        public void ListFormatedCorrectly()
        {
            Formater format = new Formater();
            Dictionary<string, Attribute> listaAtributos = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("pedro", "15");
            Attribute attribute2 = new Attribute("marcos", "13");
            List<Tag> ListaTags = new List<Tag>();
            listaAtributos.Add(attribute.Clave,attribute);
            listaAtributos.Add(attribute2.Clave,attribute2);
            ListaTags.Add(new Tag("personas", listaAtributos));
            List<string> listaFormated = format.Format(ListaTags);
            List<string> ListaExpected = new List<string> { "personas", "pedro=15", "marcos=13" };
            for (int i = 0; i < ListaExpected.Count; i++)
            {
                string elemento = listaFormated[i];
                string elementoExpected = ListaExpected[i];
                Assert.Equal(elemento, elementoExpected);
            }
        }
        [Fact]
        public void ListFormatedCorrectlyWithoutAttributes()
        {
            Formater format = new Formater();
            List<Tag> ListaTags = new List<Tag>();
            ListaTags.Add(new Tag("personas"));
            ListaTags.Add(new Tag("pedro"));
            List<string> listaFormated = format.Format(ListaTags);
            List<string> ListaExpected = new List<string> { "personas", "pedro" };
            for (int i = 0; i < ListaExpected.Count; i++)
            {
                string elemento = listaFormated[i];
                string elementoExpected = ListaExpected[i];
                Assert.Equal(elemento, elementoExpected);
            }
        }
    }
}
