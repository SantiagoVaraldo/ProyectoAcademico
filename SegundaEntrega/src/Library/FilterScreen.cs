using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
         public class FilteScreen : IFilterConditional
         {
                  public bool Result
                  {
                           get {return this.Result; }
                  }
                  public IXML Filter(Tag tag)
                  {
                           if (tag.Name == "Screen")
                           {
                                    this.Result = true;
                                    Screen screen = new Screen();
                                    return screen;
                           }
                           else
                           {
                                    this.Result = false;
                                    return tag;
                           }

                  }
         }
}