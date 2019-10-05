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
                  public IXML Filter(Tag tag, IContainer container)
                  {
                           if (tag.Name == "World")
                           {
                                    this.Result = true;
                                    World world = new World();
                                    return world;
                           }
                           else
                           {
                                    this.Result = false;
                                    return tag;
                           }

                  }
         }
}