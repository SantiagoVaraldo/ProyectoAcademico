using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
         public class FilterLevel : IFilterConditional
         {
                  public bool Result
                  {
                           get { return this.Result; }
                  }
                  public IXML Filter(Tag tag, Container container)
                  {
                           if (tag.Name == "Level")
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
                                    this.Result = true;
                                    // Level level = new Level();
                                    // container.AddLevel(name,container)
                                    return level;
                           }
                           else
                           {
                                    this.Result = false;
                                    return tag;
                           }

                  }
         }
}