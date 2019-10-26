using System;
using Xunit;
using Library;
using System.Collections.Generic;


namespace Tests
{
    public class MotorLvl3Test
    {
        World world;
        Level level;
        Screen screen;
        MotorLvl3 motor;
        ButtonCheck buttonCheck1, buttonCheck2, buttonCheck3, buttonCheck4, buttonCheck5;
        public void Create()
        {
            world = new World("world", 50, 50);
            level = new Level("level", world);
            screen = new Screen("screen", level);
            motor = new MotorLvl3();
            buttonCheck1 = new ButtonCheck("ButtonCheck1", 10, 10, 10, 10, screen, "path", "path2", true);
            buttonCheck2 = new ButtonCheck("ButtonCheck2", 20, 20, 20, 20, screen, "path", "path2", true);
            buttonCheck3 = new ButtonCheck("ButtonCheck3", 30, 30, 30, 30, screen, "path", "path2", true);
            buttonCheck4 = new ButtonCheck("ButtonCheck4", 40, 40, 40, 40, screen, "path", "path2", false);
            buttonCheck5 = new ButtonCheck("ButtonCheck5", 50, 50, 50, 50, screen, "path", "path2", false);
        }

        [Fact]
        public void PositiveTest()
        {
            //creamos los objetos
            Create();

            motor.Check(buttonCheck1);

            //checkeamos que el boton fue seleccionado
            bool expectedSelectedButton = true;
            bool actualSelectedButton = buttonCheck1.State;
            Assert.Equal(expectedSelectedButton, actualSelectedButton);

            //checkeamos que no se paso de nivel
            bool actualState = buttonCheck1.Screen.State;
            bool expectedState = false;
            Assert.Equal(actualState, expectedState);

            motor.Check(buttonCheck2);

            //checkeamos que el boton fue seleccionado
            expectedSelectedButton = true;
            actualSelectedButton = buttonCheck2.State;
            Assert.Equal(expectedSelectedButton, actualSelectedButton);

            //checheamos que se paso de nivel
            bool actualState2 = buttonCheck2.Screen.State;
            bool expectedState2 = true;
            Assert.Equal(actualState2, expectedState2);
            
            
        }

        [Fact]
        public void TwoClicksIncorrectTest()
        {
            Create();
            motor.Check(buttonCheck4);

            bool expectedSelectedButton = true;
            bool actualSelectedButton = buttonCheck4.State;
            Assert.Equal(expectedSelectedButton, actualSelectedButton);

            bool actualState = buttonCheck4.Screen.State;
            bool expectedState = false;
            Assert.Equal(actualState, expectedState);

            motor.Check(buttonCheck5);

            expectedSelectedButton = false;
            actualSelectedButton = buttonCheck5.State;
            Assert.Equal(expectedSelectedButton, actualSelectedButton);

            bool actualState2 = buttonCheck5.Screen.State;
            bool expectedState2 = false;
            Assert.Equal(actualState2, expectedState2);
        }
        [Fact]
        public void FirstCorrectAndSecondIncorrectTest()
        {
            Create();
            motor.Check(buttonCheck1);

            //checkeamos que el boton fue seleccionado
            bool expectedSelectedButton = true;
            bool actualSelectedButton = buttonCheck1.State;
            Assert.Equal(expectedSelectedButton, actualSelectedButton);

            bool actualState = buttonCheck1.Screen.State;
            bool expectedState = false;
            Assert.Equal(actualState, expectedState);

            motor.Check(buttonCheck4);

            //checkeamos que el boton fue seleccionado
            expectedSelectedButton = false;
            actualSelectedButton = buttonCheck1.State;
            Assert.Equal(expectedSelectedButton, actualSelectedButton);

            bool actualState2 = buttonCheck4.Screen.State;
            bool expectedState2 = false;
            Assert.Equal(actualState2, expectedState2);
        }
        [Fact]
        public void ClickTwoThreeAndFourCorrect()
        {
            Create();
            motor.Check(buttonCheck4);

            //checkeamos que el boton fue seleccionado
            bool expectedSelectedButton = true;
            bool actualSelectedButton = buttonCheck4.State;
            Assert.Equal(expectedSelectedButton, actualSelectedButton);

            bool actualState = buttonCheck4.Screen.State;
            bool expectedState = false;
            Assert.Equal(actualState, expectedState);

            motor.Check(buttonCheck1);

            expectedSelectedButton = false;
            actualSelectedButton = buttonCheck4.State;
            Assert.Equal(expectedSelectedButton, actualSelectedButton);

            bool actualState2 = buttonCheck1.Screen.State;
            bool expectedState2 = false;
            Assert.Equal(actualState2, expectedState2);

            motor.Check(buttonCheck2);

            expectedSelectedButton = true;
            actualSelectedButton = buttonCheck2.State;
            Assert.Equal(expectedSelectedButton, actualSelectedButton);

            bool actualState3 = buttonCheck2.Screen.State;
            bool expectedState3 = false;
            Assert.Equal(actualState3, expectedState3);

            motor.Check(buttonCheck3);

            expectedSelectedButton = true;
            actualSelectedButton = buttonCheck3.State;
            Assert.Equal(expectedSelectedButton, actualSelectedButton);

            bool actualState4 = buttonCheck3.Screen.State;
            bool expectedState4 = true;
            Assert.Equal(actualState4, expectedState4);
        }

    }
}
