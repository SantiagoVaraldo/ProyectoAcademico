using System;
using Xunit;
using Library;
using System.Collections.Generic;
using ExerciseOne;
using Attribute = ExerciseOne.Attribute;
/* 
namespace Tests
{
        public class CreatorTests
        {
                 [Fact]
                 public void CreatorPositive()
                 {
                          string input = @"C:/Users/FIT/programacion2/ProyectoFinal/pii_2019_2_equipo9/SegundaEntrega/src/Library/test.xml";
                          CreatorHelper creatorHelper = new CreatorHelper(input);
                          List<Tag> listTags = creatorHelper.GetListTags();

                          // creamos un pipeNull
                          IPipe pipeNull = new PipeNull();

                          // creamos instancias de todos los filtros que nos interecen
                          IFilterConditional filterWorld = new FilterWorld();
                          IFilterConditional filterLevel = new FilterLevel();
                          IFilterConditional filterScreen = new FilterScreen();
                          IFilterConditional filterImage = new FilterImage();

                          // creamos instancias de todos los pipeSerial que vayamos a utilizar
                          //IPipe pipeserial7 = new PipeSerial(filtertwitter,pipeNull);
                          IPipe pipe3 = new PipeConditional(filterImage, pipeNull, pipeNull);
                          IPipe pipe2 = new PipeConditional(filterScreen, pipeNull, pipe3);
                          IPipe pipe1 = new PipeConditional(filterLevel, pipeNull, pipe2);
                          IPipe pipe0 = new PipeConditional(filterWorld, pipeNull, pipe1);

                          foreach (Tag tag in listTags)
                          {
                                   pipe0.Send(tag);
                          }

                          string NameWorldExpected = "TheWorld";
                          string NameLevelExpected = "Level";
                          string NameScreenExpected = "Screen";
                          string NameElementExpected = "ImageBanana";

                          Assert.Equal(Creator.world.Name, NameWorldExpected);
                          Assert.Equal(Creator.world.ListLevel[0].Name, NameLevelExpected);
                          Assert.Equal(Creator.world.ListLevel[0].ScreenList[0].Name, NameScreenExpected);
                          Assert.Equal(Creator.world.ListLevel[0].ScreenList[0].ElementList[0].Name, NameElementExpected);
                 }
        }
}
*/
