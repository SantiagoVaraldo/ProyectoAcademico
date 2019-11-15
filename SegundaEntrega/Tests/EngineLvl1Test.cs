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
            OneAdapter.Adapter = new FalseAdapterContain(true);

            world = Singleton<World>.Instance;
            level = new Level("level", world);
            screen = new Screen("screen", level);

            // creamos el diccionario de paginas y niveles para los tests.
            Dictionary<string, List<string>> dicc = new Dictionary<string, List<string>>();
            List<string> pagesList = new List<string>();
            pagesList.Add("Page1");
            dicc.Add("Menu", pagesList);
            Creator.PagesUnity = dicc;
            Singleton<GeneralEngine>.Instance.ActualLevel = "Menu";
        }

        [Fact]
        public void PositiveTest()
        {
            // string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, bool Right
            Letter letter = new Letter("letter", 10, 10, 10, 10, screen, "path", true);
            screen.Add(letter);

            Singleton<EngineLvl1>.Instance.Check(letter);

            bool actualState = letter.Screen.State;
            bool expectedState = true;

            Assert.Equal(actualState, expectedState);

            Singleton<EngineLvl1>.Instance.Reset(screen);
        }

        [Fact]
        public void NegativeTest()
        {
            //string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, bool Right
            Letter letter = new Letter("letter", 10, 10, 10, 10, screen, "path", false);
            Singleton<EngineLvl1>.Instance.Check(letter);

            bool actualState = letter.Screen.State;
            bool expectedState = false;

            Assert.Equal(actualState, expectedState);
        }
    }
}
