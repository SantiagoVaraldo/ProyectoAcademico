using System;
using Proyecto.Common;

namespace Library
{
         public class VisitorScreen : Visitor
         {
                  private string name;

                  public string Name
                  {
                           get
                           {
                                    return this.name;
                           }
                           set
                           {
                                    this.name = value;
                           }
                  }

                  public VisitorScreen(string Name)
                  {
                           this.Name = Name;
                  }

                  public override void Visit(World world)
                  {
                           if (world.ListLevel.Count >= 1)
                           {
                                    this.lastLevel = world.ListLevel[world.ListLevel.Count - 1];
                           }

                           Screen screen = new Screen(this.name, this.lastLevel);
                           this.lastLevel.Add(screen);
                  }

                  public override void Visit(Level level)
                  {
                  }

                  public override void Visit(Screen screen)
                  {
                  }
         }
}