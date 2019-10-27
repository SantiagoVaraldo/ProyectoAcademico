using System;
using Xunit;
using Library;
using System.Collections.Generic;


namespace Tests
{
         public class MotorLvl2AndLvl4Test
         {
                  World world;
                  Level level;
                  Screen screen;
                  MotorLvl2AndLvl4 motor;
                  BlanckSpace destination1, destination2, destination3, destination4;
                  DragAndDropSource source1, source2, source3, source4;
                  Word word1, word2, word3, word4;
                  public void Create()
                  {
                           world = new World("world", 50, 50);
                           level = new Level("level", world);
                           screen = new Screen("screen", level);

                           destination1 = new BlanckSpace("destination1", 10, 10, 50, 50, screen, "path");
                           source1 = new DragAndDropSource("source1", 50, 50, 50, 50, screen, "path");
                           destination2 = new BlanckSpace("destination2", 20, 20, 50, 50, screen, "path");
                           source2 = new DragAndDropSource("source2", 50, 50, 50, 50, screen, "path");
                           destination3 = new BlanckSpace("destination3", 30, 30, 50, 50, screen, "path");
                           source3 = new DragAndDropSource("source3", 50, 50, 50, 50, screen, "path");
                           destination4 = new BlanckSpace("destination4", 40, 40, 50, 50, screen, "path");
                           source4 = new DragAndDropSource("source4", 50, 50, 50, 50, screen, "path");

                           word1 = new Word("word1", 10, 10, 50, 50, screen, "path1", source1, destination1);
                           word2 = new Word("word2", 10, 10, 50, 50, screen, "path2", source2, destination2);
                           word3 = new Word("word3", 10, 10, 50, 50, screen, "path3", source3, destination3);
                           word4 = new Word("word4", 10, 10, 50, 50, screen, "path4", source4, destination4);

                           motor = new MotorLvl2AndLvl4();
                  }

                  [Fact]
                  public void PositiveTest()
                  {
                           Create();

                           LevelPass(word1, destination1, true, false);
                           LevelPass(word2, destination2, true, false);
                           LevelPass(word3, destination3, true, false);
                           LevelPass(word4, destination4, true, true);
                  }

                  [Fact]
                  public void NegativeTest()
                  {
                           Create();

                           LevelPass(word1, destination1, true, false);
                           LevelPass(word2, destination2, true, false);
                           LevelPass(word3, destination3, true, false);
                           LevelPass(word4, destination1, false, false);

                  }

                  public void LevelPass(Word word, BlanckSpace destination, bool expectedFill, bool expectedState)
                  {
                           //Con esto simulamos que el objeto fue movido a alguna posicion.
                           word.PositionX = destination.PositionX;
                           word.PositionY = destination.PositionY;

                           motor.Check(word);

                           //nos fijamos si el destination tiene un objeto dentro
                           bool actualFill = word.Destination.Filled;
                           Assert.Equal(expectedFill, actualFill);

                           //nos fijamos si se paso de nivel
                           bool actualState = word.Screen.State;
                           Assert.Equal(actualState, expectedState);
                  }
         }
}
