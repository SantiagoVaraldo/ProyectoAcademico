using System;
using System.Collections.Generic;
using ExerciseOne;
using Attribute = ExerciseOne.Attribute;


namespace Library
{
         public class CreateElements
         {   // hacer un metodo para cada objeto
                  World world;
                  List<Screen> listScreen = new List<Screen>();
                  List<Element> listElements = new List<Element>();
                  List<Level> listLevels = new List<Level>();

                  public World Create(List<Tag> listTags)
                  {

                           foreach (Tag tag in listTags)
                           {
                                    if (tag.Name == "World")
                                    {
                                             //Precisamos: Name, Width, Lenght
                                             string name = null;
                                             int width = 0;
                                             int length = 0;
                                             foreach (Attribute attribute in tag.ListaAtributos)
                                             {
                                                      if (attribute.Clave == "Name")
                                                      {
                                                               name = attribute.Valor;
                                                      }
                                                      else if (attribute.Clave == "Width")
                                                      {
                                                               width = Int32.Parse(attribute.Valor);
                                                      }
                                                      else if (attribute.Clave == "Length")
                                                      {
                                                               length = Int32.Parse(attribute.Valor);
                                                      }
                                             }
                                             world = new World(name, length, width);
                                    }
                                    else if (tag.Name == "Level")
                                    {
                                             string name = null;
                                             string worldname = null;
                                             foreach (Attribute attribute in tag.ListaAtributos)
                                             {
                                                      if (attribute.Clave == "Name")
                                                      {
                                                               name = attribute.Valor;
                                                      }
                                                      else if (attribute.Clave == "World")
                                                      {
                                                               worldname = attribute.Valor;
                                                      }
                                             }
                                             listLevels.Add(new Level(name, worldname));
                                    }
                                    else if (tag.Name == "Screen")
                                    {
                                             string name = null;
                                             string levelname = null;
                                             foreach (Attribute attribute in tag.ListaAtributos)
                                             {
                                                      if (attribute.Clave == "Name")
                                                      {
                                                               name = attribute.Valor;
                                                      }
                                                      else if (attribute.Clave == "Level")
                                                      {
                                                               levelname = attribute.Valor;
                                                      }
                                             }
                                             listScreen.Add(new Screen(name, levelname));
                                    }
                                    else if (tag.Name == "Image")
                                    {
                                             string name = null;
                                             string screenname = null;
                                             int width = 0;
                                             int length = 0;
                                             int posicionY = 0;
                                             int posicionX = 0;
                                             string imagepath = null;
                                             foreach (Attribute attribute in tag.ListaAtributos)
                                             {
                                                      if (attribute.Clave == "Name")
                                                      {
                                                               name = attribute.Valor;
                                                      }
                                                      else if (attribute.Clave == "Screen")
                                                      {
                                                               screenname = attribute.Valor;
                                                      }
                                                      else if (attribute.Clave == "Length")
                                                      {
                                                               length = Int32.Parse(attribute.Valor);
                                                      }
                                                      else if (attribute.Clave == "Width")
                                                      {
                                                               width = Int32.Parse(attribute.Valor);
                                                      }
                                                      else if (attribute.Clave == "Imagepath")
                                                      {
                                                               imagepath = attribute.Valor;
                                                      }
                                                      else if (attribute.Clave == "Posicion_x")
                                                      {
                                                               posicionX = Int32.Parse(attribute.Valor);
                                                      }
                                                      else if (attribute.Clave == "Posicion_y")
                                                      {
                                                               posicionY = Int32.Parse(attribute.Valor);
                                                      }
                                             }
                                             listElements.Add(new Image(name, posicionY, posicionX, length, width, screenname, imagepath));
                                    }
                                    else if (tag.Name == "Button")
                                    {
                                             string name = null;
                                             string screenname = null;
                                             int width = 0;
                                             int length = 0;
                                             int posicionY = 0;
                                             int posicionX = 0;
                                             string imagepath = null;
                                             foreach (Attribute attribute in tag.ListaAtributos)
                                             {
                                                      if (attribute.Clave == "Name")
                                                      {
                                                               name = attribute.Valor;
                                                      }
                                                      else if (attribute.Clave == "Screen")
                                                      {
                                                               screenname = attribute.Valor;
                                                      }
                                                      else if (attribute.Clave == "Length")
                                                      {
                                                               length = Int32.Parse(attribute.Valor);
                                                      }
                                                      else if (attribute.Clave == "Width")
                                                      {
                                                               width = Int32.Parse(attribute.Valor);
                                                      }
                                                      else if (attribute.Clave == "Posicion_x")
                                                      {
                                                               posicionX = Int32.Parse(attribute.Valor);
                                                      }
                                                      else if (attribute.Clave == "Posicion_y")
                                                      {
                                                               posicionY = Int32.Parse(attribute.Valor);
                                                      }
                                                      else if (attribute.Clave == "Imagepath")
                                                      {
                                                               imagepath = attribute.Valor;
                                                      }
                                             }
                                             listElements.Add(new Button(name, posicionY, posicionX, length, width, screenname, imagepath));
                                    }
                           }

                           foreach (Element element in listElements)
                           {
                                    foreach (Screen screen in listScreen)
                                    {
                                             if (screen.Name == element.ScreenName)
                                             {
                                                      element.Screen = screen;
                                             }
                                    }
                           }
                           foreach (Screen screen in listScreen)
                           {
                                    foreach (Level level in listLevels)
                                    {
                                             if (level.Name == screen.LevelName)
                                             {
                                                      screen.Level = level;
                                             }
                                    }
                           }
                           foreach (Level level in listLevels)
                           {
                                    if (world.Name == level.WorldName)
                                    {
                                             level.World = world;
                                    }
                           }
                           return world;
                  }
         }
}