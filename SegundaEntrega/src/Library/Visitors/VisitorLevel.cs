using System;
using Proyecto.Common;

namespace Library
{
         public class VisitorLevel : Visitor
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

                  public VisitorLevel(string Name)
                  {
                           this.Name = Name;
                  }

                  public override void Visit(World world)
                  {
                           Level level = new Level(this.name,world);
                           world.Add(level);
                  }

                  public override void Visit(Level level)
                  {
                  }

                  public override void Visit(Screen screen)
                  {
                  }
         }
}