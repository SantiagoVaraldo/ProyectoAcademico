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
                  }
                  public Tag Filter(Tag tag, IContainer container)
                  {
                           if (tag.Name == "World")
                           {
                                    this.Result = true;
                                    IContainer world = new World(tag.ListaAtributos["Name"].Valor, Int32.Parse(tag.ListaAtributos["Length"].Valor), Int32.Parse(tag.ListaAtributos["Width"].Valor) );
                                    container.Add(world);
                           }
                           else
                           {
                                    this.Result = false;
                           }
                           return tag;

                  }
         }
}