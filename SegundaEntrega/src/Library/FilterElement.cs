using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
         public class FilterElement : IFilterConditional
         {
                  public bool Result
                  {
                           get {return this.Result; }
                  }
                  public IXML Filter(Tag tag, Container container)
                  {
                           if (tag.Name == "Button")
                           {
                                    this.Result = true;
                                    Element Button = new Button(); // cambiar Tag por Element
                                    return Button;
                           }
                           else
                           {
                                    this.Result = false;
                                    return tag;
                           }

                  }
         }
}