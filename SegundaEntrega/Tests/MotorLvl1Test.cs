using System;
using Xunit;
using Library;
using System.Collections.Generic;


namespace Tests
{
    public class MotorLvl1Test
    {
        [Fact]
        public void PositiveTest()
        {
            World world = new World("world", 50, 50);
            Level level = new Level("level", world);
            Screen screen = new Screen("screen", level);

            //string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, bool Right
            Letter letter = new Letter("letter", 10, 10, 10, 10, screen, "path", true);
            MotorLvl1 motor = new MotorLvl1();
            motor.Check(letter);

            bool actualState = letter.Screen.State;
            bool expectedState = true;

            Assert.Equal(actualState, expectedState);
            

        }
        [Fact]
        public void NegativeTest()
        {
            World world = new World("world", 50, 50);
            Level level = new Level("level", world);
            Screen screen = new Screen("screen", level);

            //string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, bool Right
            Letter letter = new Letter("letter", 10, 10, 10, 10, screen, "path", false);
            MotorLvl1 motor = new MotorLvl1();
            motor.Check(letter);

            bool actualState = letter.Screen.State;
            bool expectedState = false;

            Assert.Equal(actualState, expectedState);
            

        }
    
        
    }
}
