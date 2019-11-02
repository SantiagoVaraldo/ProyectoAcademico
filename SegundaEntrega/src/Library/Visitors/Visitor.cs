using System;
using Proyecto.Common;

namespace Library
{
         public abstract class Visitor
         {
                  public World world;
                  public Level lastLevel;
                  public Screen lastScreen;
                  public Element lastElement;
                  public Element beforeLastElement;
                  public abstract void Visit(World world);
                  public abstract void Visit(Level level);
                  public abstract void Visit(Screen screen);
         }
}