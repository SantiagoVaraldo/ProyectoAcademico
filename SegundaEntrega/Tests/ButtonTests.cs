using System;
using Xunit;
using Library;
using System.Collections.Generic;

// usar el satus para declarar y definir el World 

namespace Tests
{
    public class ButtonTests
    {
        World world1;
        Level level;
        Screen screen;
        public static void Setup()
        {
            world1 = new World("world1", 50, 50);
            level = new Level("level1", world1);
            screen = new Screen("screen1", level);
        }
        public static void Compared(Button button, string NameExpected, int PositionYExpected, int PositionXExpected, int LengthExpected, int WidthExpected, Screen ScreenExpected, string ImagePathExpected)
        {
            Assert.Equal(button.Name, NameExpected);
            Assert.Equal(button.PositionY, PositionYExpected);
            Assert.Equal(button.PositionX, PositionXExpected);
            Assert.Equal(button.Length, LengthExpected);
            Assert.Equal(button.Width, WidthExpected);
            Assert.Equal(button.Screen, ScreenExpected);
            Assert.Equal(button.ImagePath, ImagePathExpected);
        }

        [Fact]
        public void PositiveTest()
        {
            Setup();
            Button button = new Button("button1", 20, 20, 10, 20, screen, "ImagePath");
            string NameExpected = "button1";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int WidthExpected = 20;
            Screen ScreenExpected = screen;
            string ImagePathExpected = "ImagePath";
            button.Screen = screen;
            ButtonTests.Compared(button, NameExpected, PositionYExpected, PositionXExpected, LengthExpected, WidthExpected, ScreenExpected, ImagePathExpected);
        }
        [Fact]
        public void ButtonWithoutName()
        {
            Setup();
            Button button = new Button(null, 20, 20, 10, 20, screen, "ImagePath");
            string NameExpected = null;
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int WidthExpected = 20;
            Screen ScreenExpected = screen;
            string ImagePathExpected = "ImagePath";
            button.Screen = screen;
            ButtonTests.Compared(button, NameExpected, PositionYExpected, PositionXExpected, LengthExpected, WidthExpected, ScreenExpected, ImagePathExpected);

        }
        [Fact]
        public void ButtonWithoutScreen()
        {
            Setup();
            Button button = new Button("button1", 20, 20, 10, 20, null, "ImagePath");
            string NameExpected = "button1";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int WidthExpected = 20;
            Screen ScreenExpected = null;
            string ImagePathExpected = "ImagePath";
            button.Screen = null;
            ButtonTests.Compared(button, NameExpected, PositionYExpected, PositionXExpected, LengthExpected, WidthExpected, ScreenExpected, ImagePathExpected);
        }

        [Fact]
        public void ButtonWithoutImagePath()
        {
            Setup();
            Button button = new Button("button1", 20, 20, 10, 20, screen, null);
            string NameExpected = "button1";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int WidthExpected = 20;
            Screen ScreenExpected = screen;
            string ImagePathExpected = null;
            button.Screen = screen;
            ButtonTests.Compared(button, NameExpected, PositionYExpected, PositionXExpected, LengthExpected, WidthExpected, ScreenExpected, ImagePathExpected);
        }

        [Fact]
        public void ButtonLengthNegative()
        {
            Setup();
            Button button = new Button("button1", 20, 20, -10, 20, screen, "ImagePath");
            string NameExpected = "button1";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int? LengthExpected = null;
            int WidthExpected = 20;
            Screen ScreenExpected = screen;
            string ImagePathExpected = "ImagePath";
            button.Screen = screen;
            Assert.Equal(button.Name, NameExpected);
            Assert.Equal(button.PositionY, PositionYExpected);
            Assert.Equal(button.PositionX, PositionXExpected);
            Assert.Equal(button.Length, LengthExpected);
            Assert.Equal(button.Width, WidthExpected);
            Assert.Equal(button.Screen, ScreenExpected);
            Assert.Equal(button.ImagePath, ImagePathExpected);

        }
        [Fact]
        public void ButtonWidthNegative()
        {
            Setup();
            Button button = new Button("button1", 20, 20, 10, -20, screen, "ImagePath");
            string NameExpected = "button1";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int? WidthExpected = null;
            Screen ScreenExpected = screen;
            string ImagePathExpected = "ImagePath";
            button.Screen = screen;
            Assert.Equal(button.Name, NameExpected);
            Assert.Equal(button.PositionY, PositionYExpected);
            Assert.Equal(button.PositionX, PositionXExpected);
            Assert.Equal(button.Length, LengthExpected);
            Assert.Equal(button.Width, WidthExpected);
            Assert.Equal(button.Screen, ScreenExpected);
            Assert.Equal(button.ImagePath, ImagePathExpected);

        }

    }
}