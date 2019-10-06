using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
         public class FilterButton : IFilterConditional
         {
                  public bool Result
                  {
                           get {return this.Result; }
                  }
                  public Tag Filter(Tag tag, IContainer container)
                  {
                           if (tag.Name == "Button")
                           {
                                    this.Result = true;
                                    Element button = new Button(tag.ListaAtributos["Name"].Valor, Int32.Parse(tag.ListaAtributos["PositionY"].Valor), Int32.Parse(tag.ListaAtributos["PositionX"].Valor), Int32.Parse(tag.ListaAtributos["Length"].Valor), Int32.Parse(tag.ListaAtributos["Width"].Valor), container, tag.ListaAtributos["ImagePath"].Valor );
                                    container.Add(button);
                           }
                           else
                           {
                                    this.Result = false;
                           }
                           return tag;

                  }
         }
}