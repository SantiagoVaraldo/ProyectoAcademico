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
                                    Element button = new Button(tag.ListaAtributos["Name"].Valor, tag.ListaAtributos["PositionY"].Valor, tag.ListaAtributos["PositionX"].Valor, tag.ListaAtributos["Length"].Valor, tag.ListaAtributos["Width"].Valor, container, tag.ListaAtributos["ImagePath"].Valor );
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