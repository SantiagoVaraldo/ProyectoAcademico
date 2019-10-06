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
                           set {this.Result = value;}
                  }
                  public Tag Filter(Tag tag)
                  {
                           if (tag.Name == "Level")
                           {
                                    this.Result = true;
                                    Level level = new Level(tag.ListaAtributos["Name"].Valor, Creator.world);
                                    Creator.world.Add(level);
                           }
                           else
                           {
                                    this.Result = false;
                           }
                           return tag;
                  }
         }
}