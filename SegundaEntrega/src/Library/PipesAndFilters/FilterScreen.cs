using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
         public class FilteScreen : IFilterConditional
         {
                  public bool Result
                  {
                           get {return this.Result; }
                           set {this.Result = value;}
                  }
                  public Tag Filter(Tag tag)
                  {
                           if (tag.Name == "Screen")
                           {
                                    this.Result = true;
                                    IXML screen = new Screen(tag.ListaAtributos["Name"].Valor, Creator.world.ListaLevel[Creator.world.ListaLevel.Count -1]);
                                    Creator.world.ListaLevel[Creator.world.ListaLevel.Count -1].Add(screen);
                           }
                           else
                           {
                                    this.Result = false;
                           }
                           return tag;

                  }
         }
}