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
                                    this.lastLevel.Accept(this);
                           }
                  }

                  public override void Visit(Level level)
                  {
                           if (level.ScreenList.Count >= 1)
                           {
                                    this.lastScreen = level.ScreenList[level.ScreenList.Count - 1];
                                    this.lastScreen.Accept(this);
                           }
                  }

                  public override void Visit(Screen screen)
                  {
                           if (screen.ElementList.Count >= 1)
                           {
                                    this.lastElement = screen.ElementList[screen.ElementList.Count - 1];
                           }

                           if (screen.ElementList.Count >= 2)
                           {
                                    this.beforeLastElement = screen.ElementList[screen.ElementList.Count - 2];
                           }
                  }
         }
}