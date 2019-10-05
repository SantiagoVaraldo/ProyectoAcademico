using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
         public class FilterImage : IFilterConditional
         {
                  public bool Result
                  {
                           get {return this.Result; }
                  }
                  public Tag Filter(Tag tag, Container container)
                  {
                           if (tag.Name == "Image")
                           {
                                    this.Result = true;
                                    Element image = new Image(tag.ListaAtributos["Name"].Valor, tag.ListaAtributos["PositionY"].Valor, tag.ListaAtributos["PositionX"].Valor, tag.ListaAtributos["Length"].Valor, tag.ListaAtributos["Width"].Valor, container, tag.ListaAtributos["ImagePath"].Valor );
                                    container.Add(image);
                           }
                           else
                           {
                                    this.Result = false;
                           }
                           return tag;

                  }
         }
}