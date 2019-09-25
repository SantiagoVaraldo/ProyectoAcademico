using System;

namespace Library
{
         public class Level
         {
                  public Level(string name, World world)
                  {
                           this.name = name;
                           this.world = world;
                  }
                  private string name;
                  private World world;
                  public string Name
                  {
                           get
                           {
                                    return this.name;
                           }
                           set
                           {
                                    if (!string.IsNullOrEmpty(value))
                                    {
                                             this.name = value;
                                    }
                           }
                  }
         }
}
