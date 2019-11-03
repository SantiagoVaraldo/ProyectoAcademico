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
                           if (level.ListaScreen.Count >= 1)
                           {
                                    this.lastScreen = level.ListaScreen[level.ListaScreen.Count - 1];
                                    this.lastScreen.Accept(this);
                           }
                  }

                  public override void Visit(Screen screen)
                  {
                           if (screen.ListaElement.Count >= 1)
                           {
                                    this.lastElement = (BlankSpace)screen.ListaElement[screen.ListaElement.Count - 1];
                           }

                           if (screen.ListaElement.Count >= 2)
                           {
                                    this.beforeLastElement = (DragAndDropSource)screen.ListaElement[screen.ListaElement.Count - 2];
                           }
                  }
         }
}