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
                  }
                  public Tag Filter(Tag tag, IContainer container)
                  {
                           if (tag.Name == "Screen")
                           {
                                    this.Result = true;
                                    IContainer screen = new Screen(tag.ListaAtributos["Name"].Valor, container);
                                    container.Add(screen);
                           }
                           else
                           {
                                    this.Result = false;
                           }
                           return tag;

                  }
         }
}