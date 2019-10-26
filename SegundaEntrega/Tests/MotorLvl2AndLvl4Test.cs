using System;
using Xunit;
using Library;
using System.Collections.Generic;


namespace Tests
{
    public class MotorLvl2AndLvl4Test
    {
        [Fact]
        public void PositiveTest()
        {
            World world = new World("world", 50, 50);
            Level level = new Level("level", world);
            Screen screen = new Screen("screen", level);

            BlanckSpace destination1 = new BlanckSpace("destination1", 10, 10, 50, 50, screen, "path");
            DragAndDropSource source1 = new DragAndDropSource("source1", 50, 50, 50, 50, screen, "path");
            BlanckSpace destination2 = new BlanckSpace("destination2", 20, 20, 50, 50, screen, "path");
            DragAndDropSource source2 = new DragAndDropSource("source2", 50, 50, 50, 50, screen, "path");
            BlanckSpace destination3 = new BlanckSpace("destination3", 30, 30, 50, 50, screen, "path");
            DragAndDropSource source3 = new DragAndDropSource("source3", 50, 50, 50, 50, screen, "path");
            BlanckSpace destination4 = new BlanckSpace("destination4", 40, 40, 50, 50, screen, "path");
            DragAndDropSource source4 = new DragAndDropSource("source4", 50, 50, 50, 50, screen, "path");

            //string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, bool Right
            Word word1 = new Word("word1", 10, 10, 50, 50, screen, "path1", source1, destination1);
            Word word2 = new Word("word2", 20, 20, 50, 50, screen, "path2", source2, destination2);
            Word word3 = new Word("word3", 30, 30, 50, 50, screen, "path3", source3, destination3);
            Word word4 = new Word("word4", 40, 40, 50, 50, screen, "path4", source4, destination4);

            MotorLvl2AndLvl4 motor = new MotorLvl2AndLvl4();

            motor.Check(word1);
            bool actualState1 = word1.Screen.State;
            bool expectedState1 = false;
            Assert.Equal(actualState1, expectedState1);

            motor.Check(word2);
            bool actualState2 = word2.Screen.State;
            bool expectedState2 = false;
            Assert.Equal(actualState2, expectedState2);

            motor.Check(word3);
            bool actualState3 = word3.Screen.State;
            bool expectedState3 = false;
            Assert.Equal(actualState3, expectedState3);

            motor.Check(word4);
            bool actualState4 = word4.Screen.State;
            bool expectedState4 = true;
            Assert.Equal(actualState4, expectedState4);
        }
        /*
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
        */
    }

}
