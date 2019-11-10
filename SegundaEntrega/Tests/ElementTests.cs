using System;
using Xunit;
using Library;
using System.Collections.Generic;

// usar el satus para declarar y definir el World 

namespace Tests
{
    public class ElementTests
    {
        World world1;
        Level level;
        Screen screen;
        public ElementTests()
        {
            world1 = Singleton<World>.Instance;
            level = new Level("level1", world1);
            screen = new Screen("screen1", level);
        }
        public void Compared(Element element, string nameExpected, int positionYExpected, int positionXExpected, int? lengthExpected, int? widthExpected, Screen screenExpected, string imagePathExpected)
        {
            Assert.Equal(element.Name, nameExpected);
            Assert.Equal(element.PositionY, positionYExpected);
            Assert.Equal(element.PositionX, positionXExpected);
            Assert.Equal(element.Length, lengthExpected);
            Assert.Equal(element.Width, widthExpected);
            Assert.Equal(element.Screen, screenExpected);
            Assert.Equal(element.ImagePath, imagePathExpected);
        }

        [Fact]
        public void PositiveTest()
        {
            Element element = new Element("element", 20, 20, 10, 20, screen, "ImagePath");
            string nameExpected = "element";
            int positionYExpected = 20;
            int positionXExpected = 20;
            int lengthExpected = 10;
            int widthExpected = 20;
            Screen screenExpected = screen;
            string imagePathExpected = "ImagePath";
            element.Screen = screen;
            Compared(element, nameExpected, positionYExpected, positionXExpected, lengthExpected, widthExpected, screenExpected, imagePathExpected);
        }
        [Fact]
        public void WithoutName()
        {
            Element element = new Element(null, 20, 20, 10, 20, screen, "ImagePath");
            string nameExpected = null;
            int positionYExpected = 20;
            int positionXExpected = 20;
            int lengthExpected = 10;
            int widthExpected = 20;
            Screen screenExpected = screen;
            string imagePathExpected = "ImagePath";
            element.Screen = screen;
            Compared(element, nameExpected, positionYExpected, positionXExpected, lengthExpected, widthExpected, screenExpected, imagePathExpected);

        }
        [Fact]
        public void WithoutScreen()
        {
            Element element = new Element("element", 20, 20, 10, 20, null, "ImagePath");
            string nameExpected = "element";
            int positionYExpected = 20;
            int positionXExpected = 20;
            int lengthExpected = 10;
            int widthExpected = 20;
            Screen screenExpected = null;
            string imagePathExpected = "ImagePath";
            element.Screen = null;
            Compared(element, nameExpected, positionYExpected, positionXExpected, lengthExpected, widthExpected, screenExpected, imagePathExpected);
        }

        [Fact]
        public void WithoutImagePath()
        {
            Element element = new Element("element", 20, 20, 10, 20, screen, null);
            string nameExpected = "element";
            int positionYExpected = 20;
            int positionXExpected = 20;
            int lengthExpected = 10;
            int widthExpected = 20;
            Screen screenExpected = screen;
            string imagePathExpected = null;
            element.Screen = screen;
            Compared(element, nameExpected, positionYExpected, positionXExpected, lengthExpected, widthExpected, screenExpected, imagePathExpected);
        }

        [Fact]
        public void LengthNegative()
        {
            Element element = new Element("element", 20, 20, -10, 20, screen, "ImagePath");
            string nameExpected = "element";
            int positionYExpected = 20;
            int positionXExpected = 20;
            int? lengthExpected = null;
            int widthExpected = 20;
            Screen screenExpected = screen;
            string imagePathExpected = "ImagePath";
            element.Screen = screen;

            Compared(element, nameExpected, positionYExpected, positionXExpected, lengthExpected, (int)widthExpected, screenExpected, imagePathExpected);
        }
        [Fact]
        public void WidthNegative()
        {
            Element element = new Element("element", 20, 20, 10, -20, screen, "ImagePath");
            string nameExpected = "element";
            int positionYExpected = 20;
            int positionXExpected = 20;
            int lengthExpected = 10;
            int? widthExpected = null;
            Screen screenExpected = screen;
            string imagePathExpected = "ImagePath";
            element.Screen = screen;
            Compared(element, nameExpected, positionYExpected, positionXExpected, lengthExpected, widthExpected, screenExpected, imagePathExpected);
        }
        [Fact]
        public void PositionXPositive()
        {
            Element element = new Element("element", -50, 20, 10, 20, screen, "ImagePath");
            string nameExpected = "element";
            int positionYExpected = -50;
            int positionXExpected = 20;
            int lengthExpected = 10;
            int? widthExpected = 20;
            Screen screenExpected = screen;
            string imagePathExpected = "ImagePath";
            element.Screen = screen;
            Compared(element, nameExpected, positionYExpected, positionXExpected, (int)lengthExpected, (int)widthExpected, screenExpected, imagePathExpected);
        }
        [Fact]
        public void PositionYPositive()
        {
            Element element = new Element("element", 50, -20, 10, 20, screen, "ImagePath");
            string nameExpected = "element";
            int positionYExpected = 50;
            int positionXExpected = -20;
            int lengthExpected = 10;
            int? widthExpected = 20;
            Screen screenExpected = screen;
            string imagePathExpected = "ImagePath";
            element.Screen = screen;
            Compared(element, nameExpected, positionYExpected, positionXExpected, (int)lengthExpected, (int)widthExpected, screenExpected, imagePathExpected);
        }
    }
}