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
                           CreatorHelper creatorhelper = new CreatorHelper(input);
                           List<Tag> listtags = creatorhelper.GetListTags();

                           // creamos un pipeNull
                           IPipe pipenull = new PipeNull();

                           // creamos instancias de todos los filtros que nos interecen
                           IFilterConditional filterworld = new FilterWorld();
                           IFilterConditional filterlevel = new FilterLevel();
                           IFilterConditional filterscreen = new FilterScreen();
                           IFilterConditional filterimage = new FilterImage();

                           // creamos instancias de todos los pipeSerial que vayamos a utilizar
                           //IPipe pipeserial7 = new PipeSerial(filtertwitter,pipenull);
                           IPipe pipe3 = new PipeConditional(filterimage, pipenull, pipenull);
                           IPipe pipe2 = new PipeConditional(filterscreen, pipenull, pipe3);
                           IPipe pipe1 = new PipeConditional(filterlevel, pipenull, pipe2);
                           IPipe pipe0 = new PipeConditional(filterworld, pipenull, pipe1);

                           foreach (Tag tag in listtags)
                           {
                                    pipe0.Send(tag);
                           }

                           string NameWorldExpected = "TheWorld";
                           string NameLevelExpected = "Level";
                           string NameScreenExpected = "Screen";
                           string NameElementExpected = "ImageBanana";

                           Assert.Equal(Creator.World.Name, NameWorldExpected);
                           Assert.Equal(Creator.World.ListLevel[0].Name, NameLevelExpected);
                           Assert.Equal(Creator.World.ListLevel[0].ListaScreen[0].Name, NameScreenExpected);
                           Assert.Equal(Creator.World.ListLevel[0].ListaScreen[0].ListaElement[0].Name, NameElementExpected);
                  }
         }
}
*/