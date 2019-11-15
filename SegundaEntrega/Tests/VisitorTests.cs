using System;
using Xunit;
using Library;
using System.Collections.Generic;
using ExerciseOne;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
    public class VisitorTests
    {
        [Fact]
        public void FilterLevelTest()
        {
            World world = Singleton<World>.Instance;
            Dictionary<string, Attribute> attributeList = new Dictionary<string, Attribute>();
            String levelName = "level1";
            Attribute attribute = new Attribute("Name", levelName);

            attributeList.Add(attribute.Key, attribute);
            Tag tag = new Tag("Level", attributeList);

            VisitorLevel visitor = new VisitorLevel(tag);
            visitor.Visit(world);

            Level expectedLevel = new Level(levelName, world);

            Assert.Equal(world.ListLevel.Count, 1);
            Assert.True(world.ListLevel[0] is Level);
            Assert.Equal(world.ListLevel[0].Name, levelName);
        }
        [Fact]
        public void FilterScreen()
        {
            String screenName = "screen1";
            String levelName = "level1";

            World world = Singleton<World>.Instance;
            Level level = new Level(levelName, world);
            world.Add(level);

            Dictionary<string, Attribute> attributeList = new Dictionary<string, Attribute>();
            
            Attribute attributeName = new Attribute("Name", screenName);
            Attribute attributeLevel = new Attribute("Level", levelName);

            attributeList.Add(attributeName.Key, attributeName);
            attributeList.Add(attributeLevel.Key, attributeLevel);

            Tag tag = new Tag("Screen", attributeList);

            VisitorScreen visitor = new VisitorScreen(tag);
            visitor.Visit(world);

            Screen expectedScreen = new Screen(screenName, world.ListLevel[1]);

            Assert.Equal(world.ListLevel[1].ScreenList.Count, 1);
            Assert.True(world.ListLevel[1].ScreenList[0] is Screen);
            Assert.Equal(world.ListLevel[1].ScreenList[0].Name, screenName);
        }
        [Fact]
        public void FilterElement()
        {
            String screenName = "screen1";
            String levelName = "level1";

            World world = Singleton<World>.Instance;
            Level level = new Level(levelName, world);
            Screen screen = new Screen(screenName, level);
            world.Add(level);
            level.Add(screen);

            Dictionary<string, Attribute> attributeList = new Dictionary<string, Attribute>();

            string name = "image1";
            string length = "100";
            string width = "100";
            string positionY = "100";
            string positionX = "100";
            string imagePath = "Oceano.jpg";

            Attribute attributeName = new Attribute("Name", name);
            Attribute attributeScreen = new Attribute("Screen", screenName);
            Attribute attributeLenght = new Attribute("Length", length);
            Attribute attributeWidth = new Attribute("Width", width);
            Attribute attributePositionY = new Attribute("PositionY", positionY);
            Attribute attributePositionX = new Attribute("PositionX", positionX);
            Attribute attributeImagePath = new Attribute("ImagePath", imagePath);

            attributeList.Add(attributeName.Key, attributeName);
            attributeList.Add(attributeScreen.Key, attributeScreen);
            attributeList.Add(attributeLenght.Key, attributeLenght);
            attributeList.Add(attributeWidth.Key, attributeWidth);
            attributeList.Add(attributePositionY.Key, attributePositionY);
            attributeList.Add(attributePositionX.Key, attributePositionX);
            attributeList.Add(attributeImagePath.Key, attributeImagePath);

            Tag tag = new Tag("Image", attributeList);

            VisitorImage visitor = new VisitorImage(tag);
            visitor.Visit(world);

            Image expectedImage = new Image(name, Int32.Parse(positionY), Int32.Parse(positionX), Int32.Parse(length), Int32.Parse(width), screen, imagePath);

            Assert.True(world.ListLevel[2].ScreenList[0].ElementList[0] is Image);
            Assert.Equal(world.ListLevel[2].ScreenList[0].ElementList[0].Name, name);
        }
    }
}
