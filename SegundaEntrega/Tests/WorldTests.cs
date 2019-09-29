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
            string NameExpected = "world1";
            int LengthExpected = 50;
            int WidthExpected = 50;
            Assert.Equal(world1.Name,NameExpected);
            Assert.Equal(world1.Length,LengthExpected);
            Assert.Equal(world1.Width,WidthExpected);

        }
        [Fact]
        public void WorldWithoutName()
        {
            World world1 = new World(null,50,50);
            string NameExpected = null;
            int LengthExpected = 50;
            int WidthExpected = 50;
            Assert.Equal(world1.Name,NameExpected);
            Assert.Equal(world1.Length,LengthExpected);
            Assert.Equal(world1.Width,WidthExpected);

        }
        [Fact]
        public void WorldLengthNegative()
        {
            World world1 = new World("world1",-50,50);
            string NameExpected = "world1";
            int? LengthExpected = null;
            int WidthExpected = 50;
            Assert.Equal(world1.Name,NameExpected);
            Assert.Equal(world1.Length,LengthExpected);
            Assert.Equal(world1.Width,WidthExpected);

        }
        [Fact]
        public void WorldWidthNegative()
        {
            World world1 = new World("world1",50,-50);
            string NameExpected = "world1";
            int LengthExpected = 50;
            int? WidthExpected = null;
            Assert.Equal(world1.Name,NameExpected);
            Assert.Equal(world1.Length,LengthExpected);
            Assert.Equal(world1.Width,WidthExpected);

        }
    }
}
