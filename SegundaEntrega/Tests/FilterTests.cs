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
        public void FilterLevelTest()
        {
            IPipe pipeNull = new PipeNull();

            //Creamos una tag falsa de Level
            Dictionary<string, Attribute> attributeList = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("Name", "level1");

            attributeList.Add(attribute.Key, attribute);
            Tag tag = new Tag("Level", attributeList);

            //Creamos un filter Level
            IFilterConditional filterLevel = new FilterLevel();
            IPipe pipe0 = new PipeConditional(filterLevel, pipeNull, pipeNull);
            
            //Nos fijamos que el resultado de la pipe sea un VisitorLevel
            Assert.True(pipe0.Send(tag) is VisitorLevel);
        }
        [Fact]
        public void FilterScreen()
        {
            IPipe pipeNull = new PipeNull();

            //Creamos una tag de Screen falsa
            Dictionary<string, Attribute> attributeList = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("Name", "screen1");
            attributeList.Add(attribute.Key, attribute);
            Tag tag = new Tag("Screen", attributeList);

            //Creamos un filterScreen
            IFilterConditional filterScreen = new FilterScreen();
            IPipe pipe0 = new PipeConditional(filterScreen, pipeNull, pipeNull);
            
            //Nos fijamos que devuelva el Visitor correcto
            Assert.True(pipe0.Send(tag) is VisitorScreen);
        }
        [Fact]
        public void FilterElement()
        {
            IPipe pipeNull = new PipeNull();

            //Creamos una tag de Image
            Dictionary<string, Attribute> attributeList = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("Name", "image1");
            Attribute attribute2 = new Attribute("PositionY", "100");
            Attribute attribute3 = new Attribute("PositionX", "100");
            Attribute attribute4 = new Attribute("Length", "100");
            Attribute attribute5 = new Attribute("Width", "100");
            Attribute attribute6 = new Attribute("ImagePath", "Oceano.jpg");
            attributeList.Add(attribute.Key, attribute);
            attributeList.Add(attribute2.Key, attribute2);
            attributeList.Add(attribute3.Key, attribute3);
            attributeList.Add(attribute4.Key, attribute4);
            attributeList.Add(attribute5.Key, attribute5);
            attributeList.Add(attribute6.Key, attribute6);
            Tag tag = new Tag("Image", attributeList);

            //Creamos un filterImage
            IFilterConditional filterImage = new FilterImage();
            IPipe pipe0 = new PipeConditional(filterImage, pipeNull, pipeNull);

            //Testeamos que el resultado de la pipe sea el correcto.
            Assert.True(pipe0.Send(tag) is VisitorImage);
        }
    }
}