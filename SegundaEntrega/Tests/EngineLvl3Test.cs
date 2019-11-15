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
        ButtonCheck buttonCheck1;
        ButtonCheck buttonCheck2;
        ButtonCheck buttonCheck3;
        ButtonCheck buttonCheck4;
        ButtonCheck buttonCheck5;

        public EngineLvl3Test()
        {
            // seteamos una instancia "falsa" del adapter para usar en los tests
            OneAdapter.Adapter = new FalseAdapterContain(true);

            // creamos el diccionario de paginas y niveles para los tests.
            Dictionary<string, List<string>> dicc = new Dictionary<string, List<string>>();
            List<string> pagesList = new List<string>();
            pagesList.Add("Page1");
            dicc.Add("Menu", pagesList);
            Creator.PagesUnity = dicc;
            Singleton<GeneralEngine>.Instance.ActualLevel = "Menu";

            // creamos el mundo necesario para testear el motor.
            world = Singleton<World>.Instance;
            level = new Level("level", world);
            screen = new Screen("screen", level);
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
            Singleton<EngineLvl3>.Instance.Check(buttonCheck1);
            Test(buttonCheck1, true, false);

            Singleton<EngineLvl3>.Instance.Check(buttonCheck2);
            Test(buttonCheck2, true, true);

        }

        [Fact]
        public void TwoClicksIncorrectTest()
        {
            Singleton<EngineLvl3>.Instance.Check(buttonCheck4);
            Test(buttonCheck4, true, false);

            Singleton<EngineLvl3>.Instance.Check(buttonCheck5);
            Test(buttonCheck5, false, false);

        }

        [Fact]
        public void FirstCorrectAndSecondIncorrectTest()
        {
            Singleton<EngineLvl3>.Instance.Check(buttonCheck1);
            Test(buttonCheck1, true, false);

            Singleton<EngineLvl3>.Instance.Check(buttonCheck4);
            Test(buttonCheck4, false, false);

        }
        [Fact]
        public void ClickTwoThreeAndFourCorrect()
        {
            Singleton<EngineLvl3>.Instance.Check(buttonCheck4);
            Test(buttonCheck4, true, false);

            Singleton<EngineLvl3>.Instance.Check(buttonCheck1);
            Test(buttonCheck1, false, false);

            Singleton<EngineLvl3>.Instance.Check(buttonCheck2);
            Test(buttonCheck2, true, false);

            Singleton<EngineLvl3>.Instance.Check(buttonCheck3);
            Test(buttonCheck3, true, true);
        }

    }
}
