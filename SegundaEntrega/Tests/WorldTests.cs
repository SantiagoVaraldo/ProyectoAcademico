using System;
using Xunit;
using Library;
using System.Collections.Generic;

namespace Tests
{
    public class WorldTests
    {
        [Fact]
        public void PositiveTest()
        {
            World world1 = new World("world1",50,50);
            string nameExpected = "world1";
            int lengthExpected = 50;
            int widthExpected = 50;
            Assert.Equal(world1.Name,nameExpected);
            Assert.Equal(world1.Length,lengthExpected);
            Assert.Equal(world1.Width,widthExpected);

        }

        [Fact]
        public void WorldWithoutName()
        {
            World world1 = new World(null,50,50);
            string nameExpected = null;
            int lengthExpected = 50;
            int widthExpected = 50;
            Assert.Equal(world1.Name,nameExpected);
            Assert.Equal(world1.Length,lengthExpected);
            Assert.Equal(world1.Width,widthExpected);

        }

        [Fact]
        public void WorldLengthNegative()
        {
            World world1 = new World("world1",-50,50);
            string nameExpected = "world1";
            int? lengthExpected = null;
            int widthExpected = 50;
            Assert.Equal(world1.Name,nameExpected);
            Assert.Equal(world1.Length,lengthExpected);
            Assert.Equal(world1.Width,widthExpected);

        }

        [Fact]
        public void WorldWidthNegative()
        {
            World world1 = new World("world1",50,-50);
            string nameExpected = "world1";
            int lengthExpected = 50;
            int? widthExpected = null;
            Assert.Equal(world1.Name,nameExpected);
            Assert.Equal(world1.Length,lengthExpected);
            Assert.Equal(world1.Width,widthExpected);

        }
    }
}
