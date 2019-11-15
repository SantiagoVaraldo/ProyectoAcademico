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
        public EngineLvl1Test()
        {

            level = new Level("level", world);
            screen = new Screen("screen", level);
        }

        [Fact]
        public void PositiveTest()
        {
            // string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, bool Right
            Letter letter = new Letter("letter", 10, 10, 10, 10, screen, "path", true);
            Singleton<EngineLvl1>.Instance.Check(letter);

            bool actualState = letter.Screen.State;
            bool expectedState = true;

            Assert.Equal(actualState, expectedState);

            Singleton<EngineLvl1>.Instance.Reset(screen);
        }

        [Fact]
        public void NegativeTest()
        {
            OneAdapter.Adapter = new FalseAdapterContain(true);
            //string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, bool Right
            Letter letter = new Letter("letter", 10, 10, 10, 10, screen, "path", false);
            Singleton<EngineLvl1>.Instance.Check(letter);

            bool actualState = letter.Screen.State;
            bool expectedState = false;

            Assert.Equal(actualState, expectedState);
        }
    }
}
