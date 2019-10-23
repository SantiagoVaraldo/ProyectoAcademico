using System;
using Xunit;
using Library;
using System.Collections.Generic;


namespace Tests
{
    public class MotorLvl3Test
    {
        [Fact]
        public void PositiveTest()
        {
            World world = new World("world", 50, 50);
            Level level = new Level("level", world);
            Screen screen = new Screen("screen", level);

            //string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath, string ImagePath2, bool Check
            ButtonCheck buttonCheck = new ButtonCheck("ButtonCheck", 10, 10, 10, 10, screen, "path", "path2", true);
            ButtonCheck buttonCheck2 = new ButtonCheck("ButtonCheck2", 20, 20, 20, 20, screen, "path", "path2", true);
            MotorLvl3 motor = new MotorLvl3();
            motor.Check(buttonCheck, buttonCheck2);

            bool actualState = buttonCheck.Screen.State;
            bool expectedState = true;
            bool actualState2 = buttonCheck2.Screen.State;
            bool expectedState2 = true;

            Assert.Equal(actualState, expectedState);
            Assert.Equal(actualState2, expectedState2);
        }
        
        [Fact]
       public void NegativeTest()
        {
            World world = new World("world", 50, 50);
            Level level = new Level("level", world);
            Screen screen = new Screen("screen", level);

            //string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath, string ImagePath2, bool Check
            ButtonCheck buttonCheck = new ButtonCheck("ButtonCheck", 10, 10, 10, 10, screen, "path", "path2", false);
            ButtonCheck buttonCheck2 = new ButtonCheck("ButtonCheck2", 20, 20, 20, 20, screen, "path", "path2", false);
            MotorLvl3 motor = new MotorLvl3();
            motor.Check(buttonCheck, buttonCheck2);

            bool actualState = buttonCheck.Screen.State;
            bool expectedState = false;
            bool actualState2 = buttonCheck2.Screen.State;
            bool expectedState2 = false;

            Assert.Equal(actualState, expectedState);
            Assert.Equal(actualState2, expectedState2);
        }  
        
    }
}
