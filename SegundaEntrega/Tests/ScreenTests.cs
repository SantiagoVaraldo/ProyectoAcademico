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
            Level level = new Level("level1", world1);
            Screen screen = new Screen("screen1", level);
            string nameExpected = "screen1";
            Assert.Equal(screen.Name, nameExpected);
            Assert.Equal(screen.Level, level);
        }

        [Fact]
        public void ScreenWithoutName()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1);
            Screen screen = new Screen(null, level);
            string nameExpected = null;
            Level LevelExpected = level;
            Assert.Equal(screen.Name, nameExpected);
            Assert.Equal(screen.Level, LevelExpected);
        }
        [Fact]
        public void ScreenWithoutLevel()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1);
            Screen screen = new Screen("screen1", null);
            string nameExpected = "screen1";
            Level LevelExpected = null;
            Assert.Equal(screen.Name, nameExpected);
            Assert.Equal(screen.Level, LevelExpected);

        }
        [Fact]
        public void ScreenWithoutLevelAndWithoutName()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1);
            Screen screen = new Screen(null, null);
            string nameExpected = null;
            Level LevelExpected = null;
            Assert.Equal(screen.Name, nameExpected);
            Assert.Equal(screen.Level, LevelExpected);

        }

    }
}
