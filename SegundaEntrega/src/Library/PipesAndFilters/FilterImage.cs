using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;
using System.IO;

namespace Library
{
         public class FilterImage : IFilterConditional
         {
                  public bool Result
                  {
                           get {return this.Result; }
                           set {this.Result = value;}
                  }
                  public Tag Filter(Tag tag)
                  {
                           if (tag.Name == "Image")
                           {
                                    this.Result = true;
                                    IXML image = new Image(tag.ListaAtributos["Name"].Valor, Int32.Parse(tag.ListaAtributos["PositionY"].Valor), Int32.Parse(tag.ListaAtributos["PositionX"].Valor), Int32.Parse(tag.ListaAtributos["Length"].Valor), Int32.Parse(tag.ListaAtributos["Width"].Valor), Creator.world.ListaLevel[Creator.world.ListaLevel.Count -1].ListaScreen[Creator.world.ListaLevel[Creator.world.ListaLevel.Count -1].ListaScreen.Count-1], tag.ListaAtributos["ImagePath"].Valor );
                                    Creator.world.ListaLevel[Creator.world.ListaLevel.Count -1].ListaScreen[Creator.world.ListaLevel[Creator.world.ListaLevel.Count -1].ListaScreen.Count-1].Add(image);
                           }
                           else
                           {
                                    this.Result = false;
                           }
                           return tag;

                  }
         }
}