using System;
using Xunit;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
    public class FormaterTests
    {
        [Fact]
        public void CreacionCorrectaDeUnTkonDosParametros()
        {
            Formater format = new Formater();
            List<Attribute> listaAtributos = new List<Attribute>();
            listaAtributos.Add(new Attribute("pedro","15"));
            listaAtributos.Add(new Attribute("marcos","13"));
            List<Tag> ListaTags = new List<Tag>();
            ListaTags.Add(new Tag("personas",listaAtributos));
            List<string> listaFormated = format.Format(ListaTags);
            List<string> ListaExpected = new List<string>{"personas","pedro=15","marcos=13"};
            for (int i=0; i <= ListaExpected.Count; i++)
            {
                Assert.Equal(ListaExpected[i],listaFormated[i]);
            }
            //CollectionAssert.AreEquivalent(ListaExpected, format.Format(ListaTags));

        }
    }
}
