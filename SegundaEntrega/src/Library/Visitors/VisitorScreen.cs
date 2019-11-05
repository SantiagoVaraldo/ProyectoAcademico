using System;
using Proyecto.Common;
using ExerciseOne;

namespace Library
{
         public class VisitorScreen : Visitor
         {
                  private Tag tag;

                  public Tag Tag
                  {
                           get
                           {
                                    return this.tag;
                           }
                           set
                           {
                                    this.tag = value;
                           }
                  }

                  public VisitorScreen(Tag Tag)
                  {
                           this.Tag = Tag;
                  }

                  public override void Visit(World world)
                  {
                           if (world.ListLevel.Count >= 1)
                           {
                                    this.lastLevel = world.ListLevel[world.ListLevel.Count - 1];
                           }

                           string name = tag.ListaAtributos["Name"].Value;
                           
                           Screen screen = new Screen(name, this.lastLevel);
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