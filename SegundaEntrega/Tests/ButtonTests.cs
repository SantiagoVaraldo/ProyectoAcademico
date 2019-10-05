using System;
using Xunit;
using Library;
using System.Collections.Generic;

// usar el satus para declarar y definir el World 
/* 
namespace Tests
{
    public class ButtonTests
    {
        [Fact]
        public void PositiveTest()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1.Name);
            Screen screen = new Screen("screen1", level.Name);
            Button button = new Button("button1", 20, 20, 10, 20, screen.Name, "ImagePath");
            string NameExpected = "button1";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
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
        public void ButtonWithoutName()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1.Name);
            Screen screen = new Screen("screen1", level.Name);
            Button button = new Button(null, 20, 20, 10, 20, screen.Name, "ImagePath");
            string NameExpected = null;
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
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
        public void ButtonWithoutScreen()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1.Name);
            Screen screen = new Screen("screen1", level.Name);
            Button button = new Button("button1", 20, 20, 10, 20, null, "ImagePath");
            string NameExpected = "button1";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int WidthExpected = 20;
            Screen ScreenExpected = null;
            string ImagePathExpected = "ImagePath";
            button.Screen = null;
            Assert.Equal(button.Name, NameExpected);
            Assert.Equal(button.PositionY, PositionYExpected);
            Assert.Equal(button.PositionX, PositionXExpected);
            Assert.Equal(button.Length, LengthExpected);
            Assert.Equal(button.Width, WidthExpected);
            Assert.Equal(button.Screen, ScreenExpected);
            Assert.Equal(button.ImagePath, ImagePathExpected);
        }

        [Fact]
        public void ButtonWithoutImagePath()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1.Name);
            Screen screen = new Screen("screen1", level.Name);
            Button button = new Button("button1", 20, 20, 10, 20, screen.Name, null);
            string NameExpected = "button1";
            int PositionYExpected = 20;
            int PositionXExpected = 20;
            int LengthExpected = 10;
            int WidthExpected = 20;
            Screen ScreenExpected = screen;
            string ImagePathExpected = null;
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
        public void ButtonLengthNegative()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1.Name);
            Screen screen = new Screen("screen1", level.Name);
            Button button = new Button("button1", 20, 20, -10, 20, screen.Name, "ImagePath");
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
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1.Name);
            Screen screen = new Screen("screen1", level.Name);
            Button button = new Button("button1", 20, 20, 10, -20, screen.Name, "ImagePath");
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
*/