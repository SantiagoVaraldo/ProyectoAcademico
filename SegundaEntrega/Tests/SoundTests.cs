using System;
using Xunit;
using Library;
using System.Collections.Generic;

// usar el satus para declarar y definir el World 

namespace Tests
{
    public class SoundTests
    {
        [Fact]
        public void PositiveTest()
        {
            Sound sound1 = new Sound("audio.wav");
            string SoundPathExpected = "audio.wav";
            Assert.Equal(sound1.SoundPath,SoundPathExpected);


        }
        [Fact]
        public void SoundWithoutPath()
        {
            Sound sound1 = new Sound(null);
            string SoundPathExpected = null;
            Assert.Equal(sound1.SoundPath,SoundPathExpected);
        }
        
    }
    
}
