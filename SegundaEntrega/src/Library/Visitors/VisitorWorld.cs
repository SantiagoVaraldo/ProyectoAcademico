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
                           if (level.ListaScreen.Count >= 1)
                           {
                                    this.lastScreen = level.ListaScreen[level.ListaScreen.Count - 1];
                                    this.lastScreen.Acept(this);
                           }
                  }

                  public override void Visit(Screen screen)
                  {
                           if (screen.ListaElement.Count >= 1)
                           {
                                    this.lastElement = screen.ListaElement[screen.ListaElement.Count - 1];
                           }

                           if (screen.ListaElement.Count >= 2)
                           {
                                    this.beforeLastElement = screen.ListaElement[screen.ListaElement.Count - 2];
                           }
                  }
         }
}