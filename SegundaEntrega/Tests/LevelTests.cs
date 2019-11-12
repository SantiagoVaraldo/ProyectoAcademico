using System;
using Xunit;
using Library;
using System.Collections.Generic;

// usar el satus para declarar y definir el World 
/* 
namespace Tests
{
    public class LevelTests
    {
        [Fact]
        public void PositiveTest()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", world1);
            string nameExpected = "level1";
            World WorldExpected = world1;
            Assert.Equal(level.Name, nameExpected);
            Assert.Equal(level.World, WorldExpected);


        }
        [Fact]
        public void LevelWithoutName()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level(null, world1);
            string nameExpected = null;
            World WorldExpected = world1;
            Assert.Equal(level.Name, nameExpected);
            Assert.Equal(level.World, WorldExpected);
        }
        [Fact]
        public void LevelWithoutWorld()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level("level1", null);
            string nameExpected = "level1";
            World WorldExpected = null;
            Assert.Equal(level.Name, nameExpected);
            Assert.Equal(level.World, WorldExpected);

        }

        [Fact]
        public void LevelWithoutWorldAndWithoutName()
        {
            World world1 = new World("world1", 50, 50);
            Level level = new Level(null, null);
            string nameExpected = null;
            World WorldExpected = null;
            Assert.Equal(level.Name, nameExpected);
            Assert.Equal(level.World, WorldExpected);

        }
    }
}
 */