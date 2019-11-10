using System;
using Xunit;
using Library;
using System.Collections.Generic;


namespace Tests
{
    public class EngineLvl3Test
    {
        World world;
        Level level;
        Screen screen;
        EngineLvl3 engine;
        ButtonCheck buttonCheck1, buttonCheck2, buttonCheck3, buttonCheck4, buttonCheck5;

        public EngineLvl3Test()
        {
            world = Singleton<World>.Instance;
            level = new Level("level", world);
            screen = new Screen("screen", level);
            engine = new EngineLvl3();
            buttonCheck1 = new ButtonCheck("ButtonCheck1", 10, 10, 10, 10, screen, "path", "path2", true);
            buttonCheck2 = new ButtonCheck("ButtonCheck2", 20, 20, 20, 20, screen, "path", "path2", true);
            buttonCheck3 = new ButtonCheck("ButtonCheck3", 30, 30, 30, 30, screen, "path", "path2", true);
            buttonCheck4 = new ButtonCheck("ButtonCheck4", 40, 40, 40, 40, screen, "path", "path2", false);
            buttonCheck5 = new ButtonCheck("ButtonCheck5", 50, 50, 50, 50, screen, "path", "path2", false);
        }

        public void Test(ButtonCheck buttonCheck, bool expectedSelectedButton, bool expectedState)
        {
            //checkeamos que el boton fue seleccionado
            bool actualSelectedButton = buttonCheck.State;
            Assert.Equal(expectedSelectedButton, actualSelectedButton);

            //checkeamos que no se paso de nivel
            bool actualState = buttonCheck.Screen.State;
            Assert.Equal(expectedState, actualState);
        }

        [Fact]
        public void PositiveTest()
        {
            engine.Check(buttonCheck1);
            Test(buttonCheck1, true, false);

            engine.Check(buttonCheck2);
            Test(buttonCheck2, true, true);

        }

        [Fact]
        public void TwoClicksIncorrectTest()
        {
            engine.Check(buttonCheck4);
            Test(buttonCheck4, true, false);

            engine.Check(buttonCheck5);
            Test(buttonCheck5, false, false);

        }

        [Fact]
        public void FirstCorrectAndSecondIncorrectTest()
        {
            engine.Check(buttonCheck1);
            Test(buttonCheck1, true, false);

            engine.Check(buttonCheck4);
            Test(buttonCheck4, false, false);

        }
        [Fact]
        public void ClickTwoThreeAndFourCorrect()
        {
            engine.Check(buttonCheck4);
            Test(buttonCheck4, true, false);

            engine.Check(buttonCheck1);
            Test(buttonCheck1, false, false);

            engine.Check(buttonCheck2);
            Test(buttonCheck2, true, false);

            engine.Check(buttonCheck3);
            Test(buttonCheck3, true, true);

        }

    }
}
