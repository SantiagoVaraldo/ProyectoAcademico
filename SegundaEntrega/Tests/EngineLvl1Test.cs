using System;
using Xunit;
using Library;
using System.Collections.Generic;


namespace Tests
{
    public class EngineLvl1Test
    {
        World world;
        Level level;
        Screen screen;
        EngineLvl1 engine;
        public void Create()
        {
            world = new World("world", 50, 50);
            level = new Level("level", world);
            screen = new Screen("screen", level);
            engine = new EngineLvl1();
        }

        [Fact]
        public void PositiveTest()
        {
            Create();
            //string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, bool Right
            Letter letter = new Letter("letter", 10, 10, 10, 10, screen, "path", true);
            engine.Check(letter);

            bool actualState = letter.Screen.State;
            bool expectedState = true;

            Assert.Equal(actualState, expectedState);
        }

        [Fact]
        public void NegativeTest()
        {
            Create();
            //string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, bool Right
            Letter letter = new Letter("letter", 10, 10, 10, 10, screen, "path", false);
            engine.Check(letter);

            bool actualState = letter.Screen.State;
            bool expectedState = false;

            Assert.Equal(actualState, expectedState);
        }
    }
}
