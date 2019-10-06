using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
         public class FilterWorld : IFilterConditional
         {
                  public bool Result
                  {
                           get {return this.Result; }
                           set {this.Result = value;}
                  }
                  public Tag Filter(Tag tag)
                  {
                           if (tag.Name == "World")
                           {
                                    this.Result = true;
                                    World world = new World(tag.ListaAtributos["Name"].Valor, Int32.Parse(tag.ListaAtributos["Length"].Valor), Int32.Parse(tag.ListaAtributos["Width"].Valor) );
                                    Creator.world = world;
                           }
                           else
                           {
                                    this.Result = false;
                           }
                           return tag;

                  }
         }
}