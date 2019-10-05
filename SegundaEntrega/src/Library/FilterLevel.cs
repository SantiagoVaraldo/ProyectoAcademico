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
                  public Tag Filter(Tag tag, IContainer container)
                  {
                           if (tag.Name == "Level")
                           {
                                    this.Result = true;
                                    IContainer level = new Level(tag.ListaAtributos["Name"].Valor, container);
                                    container.Add(level);
                           }
                           else
                           {
                                    this.Result = false;
                           }
                           return tag;
                  }
         }
}