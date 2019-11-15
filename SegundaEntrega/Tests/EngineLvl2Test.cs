//--------------------------------------------------------------------------------
// <copyright file="EngineLvl2Test.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Xunit;
using Library;
using System.Collections.Generic;

namespace Tests
{
    public class EngineLvl2Test
    {
        World world;
        Level level;
        Screen screen;
        BlankSpace destination1;
        BlankSpace destination2;
        DragAndDropSource source1;
        DragAndDropSource source2;
        Word word1;
        Word word2;
        FalseAdapterContain falseAdapterContainTrue;
        public EngineLvl2Test()
        {
            // seteamos una instancia "falsa" del adapter para usar en los tests.
            OneAdapter.Adapter = new FalseAdapterContain(true);

            // creamos el diccionario de paginas y niveles para los tests.
            Dictionary<string, List<string>> dicc = new Dictionary<string, List<string>>();
            List<string> list = new List<string>();
            list.Add("Page1");
            dicc.Add("Menu", list);
            Creator.UnityPages = dicc;

            // creamos el mundo necesario para testear el motor.
            Singleton<GeneralEngine>.Instance.ActualLevel = "Menu";

            level = new Level("level", world);
            screen = new Screen("screen", level);

            destination1 = new BlankSpace("destination1", 10, 10, 50, 50, screen, "path");
            source1 = new DragAndDropSource("source1", 50, 50, 50, 50, screen, "path");
            destination2 = new BlankSpace("destination2", 20, 20, 50, 50, screen, "path");
            source2 = new DragAndDropSource("source2", 50, 50, 50, 50, screen, "path");

            word1 = new Word("word1", 10, 10, 50, 50, screen, "path1", source1, destination1);
            word2 = new Word("word2", 10, 10, 50, 50, screen, "path2", source2, destination2);

            screen.Add(word1);
            screen.Add(word2);
            screen.Add(destination1);
            screen.Add(destination2);
        }

        [Fact]
        public void PositiveTest()
        {

            // simulamos que nuestros objetos Word se encuentran en el lugar correcto.
            if (OneAdapter.Adapter.Contains(word1.Name, 50, 50))
            {
                Singleton<EngineLvl2>.Instance.Check(word1);
                Singleton<EngineLvl2>.Instance.AddWord(word1);
                Singleton<EngineLvl2>.Instance.NextLevel(word1);
                this.LevelPass(word1, true, false);
            }

            if (OneAdapter.Adapter.Contains(word2.Name, 50, 50))
            {
                Singleton<EngineLvl2>.Instance.Check(word2);
                Singleton<EngineLvl2>.Instance.AddWord(word2);
                Singleton<EngineLvl2>.Instance.NextLevel(word2);
                this.LevelPass(word2, true, true);
            }
        }

        [Fact]
        public void NegativeTest()
        {
            // simulamos que nuestros objetos Word se encuentran en el lugar incorrecto.
            if (!OneAdapter.Adapter.Contains(word1.Name, 50, 50))
            {
                Singleton<EngineLvl2>.Instance.Check(word1);
                Singleton<EngineLvl2>.Instance.AddWord(word1);
                Singleton<EngineLvl2>.Instance.NextLevel(word1);
                this.LevelPass(word1, true, false);
            }

            if (!OneAdapter.Adapter.Contains(word2.Name, 50, 50))
            {
                Singleton<EngineLvl2>.Instance.Check(word2);
                Singleton<EngineLvl2>.Instance.AddWord(word2);
                Singleton<EngineLvl2>.Instance.NextLevel(word2);
                this.LevelPass(word2, true, false);
            }
        }

        public void LevelPass(Word word, bool expectedFill, bool expectedState)
        {
            //nos fijamos si el destination tiene un objeto dentro
            bool actualFill = word.Destination.Filled;
            Assert.Equal(expectedFill, actualFill);

            //nos fijamos si se paso de nivel
            bool actualState = word.Screen.State;
            Assert.Equal(actualState, expectedState);
        }
    }
}
