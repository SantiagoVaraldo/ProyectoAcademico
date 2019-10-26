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

            motor.Check(buttonCheck);
            bool actualState = buttonCheck.Screen.State;
            bool expectedState = false;
            Assert.Equal(actualState, expectedState);

            motor.Check(buttonCheck2);
            bool actualState2 = buttonCheck2.Screen.State;
            bool expectedState2 = true;
            Assert.Equal(actualState2, expectedState2);
        }

        [Fact]
        public void TwoClicksIncorrectTest()
        {
            World world = new World("world", 50, 50);
            Level level = new Level("level", world);
            Screen screen = new Screen("screen", level);

            //string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath, string ImagePath2, bool Check
            ButtonCheck buttonCheck = new ButtonCheck("ButtonCheck", 10, 10, 10, 10, screen, "path", "path2", false);
            ButtonCheck buttonCheck2 = new ButtonCheck("ButtonCheck2", 20, 20, 20, 20, screen, "path", "path2", false);
            MotorLvl3 motor = new MotorLvl3();

            motor.Check(buttonCheck);
            bool actualState = buttonCheck.Screen.State;
            bool expectedState = false;
            Assert.Equal(actualState, expectedState);

            motor.Check(buttonCheck2);
            bool actualState2 = buttonCheck2.Screen.State;
            bool expectedState2 = false;
            Assert.Equal(actualState2, expectedState2);
        }
        [Fact]
        public void FirstCorrectAndSecondIncorrectTest()
        {
            World world = new World("world", 50, 50);
            Level level = new Level("level", world);
            Screen screen = new Screen("screen", level);

            //string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath, string ImagePath2, bool Check
            ButtonCheck buttonCheck = new ButtonCheck("ButtonCheck", 10, 10, 10, 10, screen, "path", "path2", true);
            ButtonCheck buttonCheck2 = new ButtonCheck("ButtonCheck2", 20, 20, 20, 20, screen, "path", "path2", false);
            MotorLvl3 motor = new MotorLvl3();

            motor.Check(buttonCheck);
            bool actualState = buttonCheck.Screen.State;
            bool expectedState = false;
            Assert.Equal(actualState, expectedState);

            motor.Check(buttonCheck2);
            bool actualState2 = buttonCheck2.Screen.State;
            bool expectedState2 = false;
            Assert.Equal(actualState2, expectedState2);
        }
        [Fact]
        public void ClickTwoThreeAndFourCorrect()
        {
            World world = new World("world", 50, 50);
            Level level = new Level("level", world);
            Screen screen = new Screen("screen", level);

            //string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath, string ImagePath2, bool Check
            ButtonCheck buttonCheck = new ButtonCheck("ButtonCheck", 10, 10, 10, 10, screen, "path", "path2", false);
            ButtonCheck buttonCheck2 = new ButtonCheck("ButtonCheck2", 20, 20, 20, 20, screen, "path", "path2", true);
            ButtonCheck buttonCheck3 = new ButtonCheck("ButtonCheck3", 30, 30, 30, 30, screen, "path", "path3", true);
            ButtonCheck buttonCheck4 = new ButtonCheck("ButtonCheck4", 40, 40, 40, 40, screen, "path", "path4", true);
            MotorLvl3 motor = new MotorLvl3();

            motor.Check(buttonCheck);
            bool actualState = buttonCheck.Screen.State;
            bool expectedState = false;
            Assert.Equal(actualState, expectedState);

            motor.Check(buttonCheck2);
            bool actualState2 = buttonCheck2.Screen.State;
            bool expectedState2 = false;
            Assert.Equal(actualState2, expectedState2);

            motor.Check(buttonCheck3);
            bool actualState3 = buttonCheck3.Screen.State;
            bool expectedState3 = false;
            Assert.Equal(actualState3, expectedState3);

            motor.Check(buttonCheck4);
            bool actualState4 = buttonCheck4.Screen.State;
            bool expectedState4 = true;
            Assert.Equal(actualState4, expectedState4);
        }

    }
}
