using System;
using Xunit;
using Library;
using System.Collections.Generic;
using ExerciseOne;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
    public class FilterTests
    {
        [Fact]
        public void FilterWorld()
        {
            IPipe pipenull = new PipeNull();

            Dictionary<string, Attribute> listaAtributos = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("Name", "world1");
            Attribute attribute2 = new Attribute("Length", "100");
            Attribute attribute3 = new Attribute("Width", "100");
            listaAtributos.Add(attribute.Clave, attribute);
            listaAtributos.Add(attribute2.Clave, attribute2);
            listaAtributos.Add(attribute3.Clave, attribute3);
            Tag tag = new Tag("World", listaAtributos);

            IFilterConditional filterworld = new FilterWorld();
            IPipe pipe0 = new PipeConditional(filterworld, pipenull, pipenull);
            pipe0.Send(tag);

            string NameExpected = "world1";
            int LengthExpected = 100;
            int WidthExpected = 100;

            Assert.Equal(Creator.World.Name, NameExpected);
            Assert.Equal(Creator.World.Length, LengthExpected);
            Assert.Equal(Creator.World.Width, WidthExpected);
        }
        [Fact]
        public void FilterLevelTest()
        {
            IPipe pipenull = new PipeNull();

            Dictionary<string, Attribute> listaAtributos = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("Name", "level1");

            listaAtributos.Add(attribute.Clave, attribute);
            Tag tag = new Tag("Level", listaAtributos);

            IFilterConditional filterlevel = new FilterLevel();
            IPipe pipe0 = new PipeConditional(filterlevel, pipenull, pipenull);
            pipe0.Send(tag);

            string NameExpected = "level1";
            World world = Creator.World;

            Assert.Equal(Creator.World.ListLevel[0].Name, NameExpected);
            Assert.Equal(Creator.World.ListLevel[0].World, world);
        }
        [Fact]
        public void FilterScreen()
        {
            IPipe pipenull = new PipeNull();

            Dictionary<string, Attribute> listaAtributos = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("Name", "screen1");
            listaAtributos.Add(attribute.Clave, attribute);
            Tag tag = new Tag("Screen", listaAtributos);

            IFilterConditional filterscreen = new FilterScreen();
            IPipe pipe0 = new PipeConditional(filterscreen, pipenull, pipenull);
            pipe0.Send(tag);

            string NameExpected = "screen1";
            Level level = Creator.World.ListLevel[0];

            Assert.Equal(level.ListaScreen[0].Name, NameExpected);
            Assert.Equal(level.ListaScreen[0].Level, level);
        }
        [Fact]
        public void FilterElement()
        {
            IPipe pipenull = new PipeNull();

            Dictionary<string, Attribute> listaAtributos = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("Name", "image1");
            Attribute attribute2 = new Attribute("PositionY", "100");
            Attribute attribute3 = new Attribute("PositionX", "100");
            Attribute attribute4 = new Attribute("Length", "100");
            Attribute attribute5 = new Attribute("Width", "100");
            Attribute attribute6 = new Attribute("ImagePath", "Oceano.jpg");
            listaAtributos.Add(attribute.Clave, attribute);
            listaAtributos.Add(attribute2.Clave, attribute2);
            listaAtributos.Add(attribute3.Clave, attribute3);
            listaAtributos.Add(attribute4.Clave, attribute4);
            listaAtributos.Add(attribute5.Clave, attribute5);
            listaAtributos.Add(attribute6.Clave, attribute6);
            Tag tag = new Tag("Image", listaAtributos);

            IFilterConditional filterImage = new FilterImage();
            IPipe pipe0 = new PipeConditional(filterImage, pipenull, pipenull);
            pipe0.Send(tag);

            string NameExpected = "image1";
            Level level = Creator.World.ListLevel[0];
            Screen screen = level.ListaScreen[0];
            int LengthExpected = 100;
            int WidthExpected = 100;
            int PositionYExpected = 100;
            int PositionXExpected = 100;
            string ImagePathExpected = "Oceano.jpg";

            Assert.Equal(screen.ListaElement[0].Name, NameExpected);
            Assert.Equal(screen.ListaElement[0].Screen, screen);
            Assert.Equal(screen.ListaElement[0].PositionY, PositionYExpected);
            Assert.Equal(screen.ListaElement[0].PositionX, PositionXExpected);
            Assert.Equal(screen.ListaElement[0].Length, LengthExpected);
            Assert.Equal(screen.ListaElement[0].Width, WidthExpected);
            Assert.Equal(screen.ListaElement[0].ImagePath, ImagePathExpected);
        }
    }
}
