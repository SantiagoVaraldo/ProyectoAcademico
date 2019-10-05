using System;
using Xunit;
using Library;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;
using ExerciseOne;

/* 
namespace Tests
{
         public class CreateElementsTests
         {
                  [Fact]
                  public void PositiveTest()
                  {
                           CreateElements createelements = new CreateElements();
                           List<Attribute> listaAtributos = new List<Attribute>();
                           listaAtributos.Add(new Attribute("Name", "world"));
                           listaAtributos.Add(new Attribute("Length", "50"));
                           listaAtributos.Add(new Attribute("Width", "50"));
                           List<Tag> ListaTags = new List<Tag>();
                           ListaTags.Add(new Tag("World", listaAtributos));

                           List<Attribute> listaAtributos1 = new List<Attribute>();
                           listaAtributos1.Add(new Attribute("Name", "level"));
                           listaAtributos1.Add(new Attribute("World", "world"));
                           ListaTags.Add(new Tag("Level", listaAtributos1));

                           List<Attribute> listaAtributos2 = new List<Attribute>();
                           listaAtributos2.Add(new Attribute("Name", "screen"));
                           listaAtributos2.Add(new Attribute("Level", "level"));
                           ListaTags.Add(new Tag("Screen", listaAtributos2));

                           List<Attribute> listaAtributos3 = new List<Attribute>();
                           listaAtributos3.Add(new Attribute("Name", "image"));
                           listaAtributos3.Add(new Attribute("Posicion_y", "10"));
                           listaAtributos3.Add(new Attribute("Posicion_x", "10"));
                           listaAtributos3.Add(new Attribute("Length", "10"));
                           listaAtributos3.Add(new Attribute("Width", "10"));
                           listaAtributos3.Add(new Attribute("Screen", "screen"));
                           listaAtributos3.Add(new Attribute("ImagePath", "imagepath"));
                           ListaTags.Add(new Tag("Image", listaAtributos3));

                           World world = createelements.Create(ListaTags);
                           foreach (Level level in createelements.listLevels)
                           {
                                    Assert.Equal(level.Name, "level");
                                    Assert.Equal(level.WorldName, "world");
                           }
                           foreach (Screen screen in createelements.listScreen)
                           {
                                    Assert.Equal(screen.Name, "screen");
                                    Assert.Equal(screen.LevelName, "level");
                           }
                           foreach (Element element in createelements.listElements)
                           {
                                    Console.WriteLine(element.PositionY);
                                    Assert.Equal("image", element.Name);
                                    // Assert.Equal(10, element.PositionY);
                                    //Assert.Equal(10, element.PositionX);  modificar sets de elemento
                                    Assert.Equal(10, element.Length);
                                    Assert.Equal(10, element.Width);
                                    Assert.Equal("screen", element.ScreenName);
                                    Assert.Equal("imagepath", element.ImagePath);
                           }
                           Assert.Equal(createelements.world.Name, "world");
                           Assert.Equal(createelements.world.Length, 50);
                           Assert.Equal(createelements.world.Width, 50);
                  }
         }
}
*/