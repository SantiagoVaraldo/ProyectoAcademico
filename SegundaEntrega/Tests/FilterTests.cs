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

            Dictionary<string, Attribute> attributeList = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("Name", "level1");

            attributeList.Add(attribute.Key, attribute);
            Tag tag = new Tag("Level", attributeList);

            IFilterConditional filterLevel = new FilterLevel();
            IPipe pipe0 = new PipeConditional(filterLevel, pipeNull, pipeNull);
            pipe0.Send(tag);

            string NameExpected = "level1";
            World world = Singleton<World>.Instance;

            Assert.Equal(Singleton<World>.Instance.ListLevel[0].Name, NameExpected);
            Assert.Equal(Singleton<World>.Instance.ListLevel[0].World, world);
        }
        [Fact]
        public void FilterScreen()
        {
            IPipe pipeNull = new PipeNull();

            Dictionary<string, Attribute> attributeList = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("Name", "screen1");
            attributeList.Add(attribute.Key, attribute);
            Tag tag = new Tag("Screen", attributeList);

            IFilterConditional filterScreen = new FilterScreen();
            IPipe pipe0 = new PipeConditional(filterScreen, pipeNull, pipeNull);
            pipe0.Send(tag);

            string nameExpected = "screen1";
            Level level = Singleton<World>.Instance.ListLevel[0];

            Assert.Equal(level.ScreenList[0].Name, nameExpected);
            Assert.Equal(level.ScreenList[0].Level, level);
        }
        [Fact]
        public void FilterElement()
        {
            IPipe pipeNull = new PipeNull();

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

            IFilterConditional filterImage = new FilterImage();
            IPipe pipe0 = new PipeConditional(filterImage, pipeNull, pipeNull);
            pipe0.Send(tag);

            string nameExpected = "image1";
            Level level = Singleton<World>.Instance.ListLevel[0];
            Screen screen = level.ScreenList[0];
            int lengthExpected = 100;
            int widthExpected = 100;
            int positionYExpected = 100;
            int positionXExpected = 100;
            string imagePathExpected = "Oceano.jpg";

            Assert.Equal(screen.ElementList[0].Name, nameExpected);
            Assert.Equal(screen.ElementList[0].Screen, screen);
            Assert.Equal(screen.ElementList[0].PositionY, positionYExpected);
            Assert.Equal(screen.ElementList[0].PositionX, positionXExpected);
            Assert.Equal(screen.ElementList[0].Length, lengthExpected);
            Assert.Equal(screen.ElementList[0].Width, widthExpected);
            Assert.Equal(screen.ElementList[0].ImagePath, imagePathExpected);
        }
    }
}
