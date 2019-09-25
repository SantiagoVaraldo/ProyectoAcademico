using System;

namespace Library
{
         public class Screen
         {
                  public Screen(string name, Level level)
                  {
                           this.name = name;
                           this.level = level;
                  }
                  private string name;
                  private Level level;
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
