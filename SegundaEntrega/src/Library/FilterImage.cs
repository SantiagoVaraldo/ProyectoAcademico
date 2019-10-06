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
                  public Tag Filter(Tag tag, IContainer container)
                  {
                           if (tag.Name == "Image")
                           {
                                    this.Result = true;
                                    Element image = new Image(tag.ListaAtributos["Name"].Valor, Int32.Parse(tag.ListaAtributos["PositionY"].Valor), Int32.Parse(tag.ListaAtributos["PositionX"].Valor), Int32.Parse(tag.ListaAtributos["Length"].Valor), Int32.Parse(tag.ListaAtributos["Width"].Valor), container, tag.ListaAtributos["ImagePath"].Valor );
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