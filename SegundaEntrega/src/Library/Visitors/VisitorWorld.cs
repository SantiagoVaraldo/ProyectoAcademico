using System;
using Proyecto.Common;

namespace Library
{
         public class VisitorWorld : Visitor
         {
                  public override void Visit(World world)
                  {
                           if (world.ListLevel.Count >= 1)
                           {
                                    this.lastLevel = world.ListLevel[world.ListLevel.Count - 1];
                                    this.lastLevel.Acept(this);
                           }
                  }

                  public override void Visit(Level level)
                  {
                           if (level.ListScreen.Count >= 1)
                           {
                                    this.lastScreen = level.ListScreen[level.ListScreen.Count - 1];
                                    this.lastScreen.Acept(this);
                           }
                  }

                  public override void Visit(Screen screen)
                  {
                           if (screen.ListElement.Count >= 1)
                           {
                                    this.lastElement = screen.ListElement[screen.ListElement.Count - 1];
                           }

                           if (screen.ListsElement.Count >= 2)
                           {
                                    this.beforeLastElement = screen.ListElement[screen.ListElement.Count - 2];
                           }
                  }
         }
}