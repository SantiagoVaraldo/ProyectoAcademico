using System;
using Xunit;
using Library;
using System.Collections.Generic;

// usar el satus para declarar y definir el World y el Level

namespace Tests
{
    public class ScreenTests
    {
        [Fact]
        public void PositiveTest()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1.Name);
            Screen screen = new Screen("screen1", level.Name);
            screen.Level = level;
            string NameExpected = "screen1";
            Level LevelExpected = level;
            Assert.Equal(screen.Name, NameExpected);
            Assert.Equal(screen.LevelName, LevelExpected.Name);
            Assert.Equal(screen.Level, LevelExpected);

        }
        [Fact]
        public void ScreenWithoutName()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1.Name);
            Screen screen = new Screen(null, level.Name);
            string NameExpected = null;
            Level LevelExpected = level;
            screen.Level = level;
            Assert.Equal(screen.Name, NameExpected);
            Assert.Equal(screen.LevelName, LevelExpected.Name);
            Assert.Equal(screen.Level, LevelExpected);
        }
        [Fact]
        public void ScreenWithoutLevel()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1.Name);
            Screen screen = new Screen("screen1", level.Name);
            screen.Level = null;
            string NameExpected = "screen1";
            Level LevelExpected = null;
            Assert.Equal(screen.Name, NameExpected);
            Assert.Equal(screen.LevelName, level.Name);
            Assert.Equal(screen.Level, LevelExpected);
        }
    }
}
