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
        public void Setup()
        {
            world1 = new World("world1", 50, 50);
            level = new Level("level1", world1);
            screen = new Screen("screen1", level);
        }
        public void Compared(Element element, string NameExpected, int PositionYExpected, int PositionXExpected, int? LengthExpected, int? WidthExpected, Screen ScreenExpected, string ImagePathExpected)
        {
            Assert.Equal(element.Name, NameExpected);
            Assert.Equal(element.PositionY, PositionYExpected);
            Assert.Equal(element.PositionX, PositionXExpected);
            Assert.Equal(element.Length, LengthExpected);
            Assert.Equal(element.Width, WidthExpected);
            Assert.Equal(element.Screen, ScreenExpected);
            Assert.Equal(element.ImagePath, ImagePathExpected);
        }

        [Fact]
        public void PositiveTest()
        {
            Setup();
            Element element = new Element("element", 20, 20, 10, 20, screen, "ImagePath");
            string NameExpected = "element";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int WidthExpected = 20;
            Screen ScreenExpected = screen;
            string ImagePathExpected = "ImagePath";
            element.Screen = screen;
            Compared(element, NameExpected, PositionYExpected, PositionXExpected, LengthExpected, WidthExpected, ScreenExpected, ImagePathExpected);
        }
        [Fact]
        public void WithoutName()
        {
            Setup();
            Element element = new Element(null, 20, 20, 10, 20, screen, "ImagePath");
            string NameExpected = null;
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int WidthExpected = 20;
            Screen ScreenExpected = screen;
            string ImagePathExpected = "ImagePath";
            element.Screen = screen;
            Compared(element, NameExpected, PositionYExpected, PositionXExpected, LengthExpected, WidthExpected, ScreenExpected, ImagePathExpected);

        }
        [Fact]
        public void WithoutScreen()
        {
            Setup();
            Element element = new Element("element", 20, 20, 10, 20, null, "ImagePath");
            string NameExpected = "element";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int WidthExpected = 20;
            Screen ScreenExpected = null;
            string ImagePathExpected = "ImagePath";
            element.Screen = null;
            Compared(element, NameExpected, PositionYExpected, PositionXExpected, LengthExpected, WidthExpected, ScreenExpected, ImagePathExpected);
        }

        [Fact]
        public void WithoutImagePath()
        {
            Setup();
            Element element = new Element("element", 20, 20, 10, 20, screen, null);
            string NameExpected = "element";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int WidthExpected = 20;
            Screen ScreenExpected = screen;
            string ImagePathExpected = null;
            element.Screen = screen;
            Compared(element, NameExpected, PositionYExpected, PositionXExpected, LengthExpected, WidthExpected, ScreenExpected, ImagePathExpected);
        }

        [Fact]
        public void LengthNegative()
        {
            Setup();
            Element element = new Element("element", 20, 20, -10, 20, screen, "ImagePath");
            string NameExpected = "element";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int? LengthExpected = null;
            int WidthExpected = 20;
            Screen ScreenExpected = screen;
            string ImagePathExpected = "ImagePath";
            element.Screen = screen;

            Compared(element, NameExpected, PositionYExpected, PositionXExpected, LengthExpected, (int)WidthExpected, ScreenExpected, ImagePathExpected);
        }
        [Fact]
        public void WidthNegative()
        {
            Setup();
            Element element = new Element("element", 20, 20, 10, -20, screen, "ImagePath");
            string NameExpected = "element";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int? WidthExpected = null;
            Screen ScreenExpected = screen;
            string ImagePathExpected = "ImagePath";
            element.Screen = screen;
            Compared(element, NameExpected, PositionYExpected, PositionXExpected, LengthExpected, WidthExpected, ScreenExpected, ImagePathExpected);
        }
        [Fact]
        public void PositionXPositive()
        {
            Setup();
            Element element = new Element("element", -50, 20, 10, 20, screen, "ImagePath");
            string NameExpected = "element";
            int PositionYExpected = -50;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int? WidthExpected = 20;
            Screen ScreenExpected = screen;
            string ImagePathExpected = "ImagePath";
            element.Screen = screen;
            Compared(element, NameExpected, PositionYExpected, PositionXExpected, (int)LengthExpected, (int)WidthExpected, ScreenExpected, ImagePathExpected);
        }
        [Fact]
        public void PositionYPositive()
        {
            Setup();
            Element element = new Element("element", 50, -20, 10, 20, screen, "ImagePath");
            string NameExpected = "element";
            int PositionYExpected = 50;
            int PositionXExpected = -20;
            int LengthExpected = 10;
            int? WidthExpected = 20;
            Screen ScreenExpected = screen;
            string ImagePathExpected = "ImagePath";
            element.Screen = screen;
            Compared(element, NameExpected, PositionYExpected, PositionXExpected, (int)LengthExpected, (int)WidthExpected, ScreenExpected, ImagePathExpected);
        }
    }
}