using System;
using Xunit;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
    public class TagTests
    {
        [Fact]
        public void CreacionCorrectaDeUnTag()
        {
            List<Attribute> listaAtributos = new List<Attribute>();
            listaAtributos.Add(new Attribute("pedro","15"));
            listaAtributos.Add(new Attribute("marcos","13"));
            Tag tag = new Tag("personas",listaAtributos);
            string NameExpected = "personas";
            List<Attribute> ListaAtributosExpected = listaAtributos;
            Assert.Equal(NameExpected,tag.Name);
            Assert.Equal(ListaAtributosExpected,tag.ListaAtributos);
        }
        //[Fact]
        //public void Test2()
        //{
        //    List<Attribute> listaAtributos = new List<Attribute>();
        //}
    }
}
