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
            format.Format(ListaTags);
            List<string> ListaExpected = new List<string>{"personas","pedro=15","marcos=13"};
            //CollectionAssert.AreEquivalent(ListaExpected, format.Format(ListaTags));

        }
    }
}
