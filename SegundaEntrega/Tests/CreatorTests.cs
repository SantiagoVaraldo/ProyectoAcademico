using System;
using Xunit;
using Library;
using System.Collections.Generic;
using ExerciseOne;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
    public class CreatorTests
    {
        [Fact]
        public void CreatorPositive()
        {
            string input = @"..\..\..\CreatorTest.xml";

            CreatorHelper creatorHelper = new CreatorHelper(input);
            List<Tag> listTags = creatorHelper.GetListTags();

            // creamos un pipeNull
            IPipe pipeNull = new PipeNull();

            // creamos instancias de todos los filtros que nos interecen
            IFilterConditional filterLevel = new FilterLevel();
            IFilterConditional filterScreen = new FilterScreen();
            IFilterConditional filterImage = new FilterImage();

            // creamos instancias de todos los pipeSerial que vayamos a utilizar
            //IPipe pipeserial7 = new PipeSerial(filtertwitter,pipeNull);
            IPipe pipe3 = new PipeConditional(filterImage, pipeNull, pipeNull);
            IPipe pipe2 = new PipeConditional(filterScreen, pipeNull, pipe3);
            IPipe pipe1 = new PipeConditional(filterLevel, pipeNull, pipe2);

            foreach (Tag tag in listTags)
            {
                pipe1.Send(tag);
            }

            string NameLevelExpected = "Level";
            string NameScreenExpected = "Screen";
            string NameElementExpected = "ImageBanana";
            
            Assert.Equal(Singleton<World>.Instance.ListLevel[0].Name, NameLevelExpected);
            Assert.Equal(Singleton<World>.Instance.ListLevel[0].ScreenList[0].Name, NameScreenExpected);
            Assert.Equal(Singleton<World>.Instance.ListLevel[0].ScreenList[0].ElementList[0].Name, NameElementExpected);
        }
    }
}

