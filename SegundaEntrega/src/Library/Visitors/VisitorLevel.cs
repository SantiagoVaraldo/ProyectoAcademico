using System;
using Proyecto.Common;
using ExerciseOne;

namespace Library
{
         public class VisitorLevel : Visitor
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

                  public VisitorLevel(Tag Tag)
                  {
                           this.Tag = Tag;
                  }

                  public override void Visit(World world)
                  {
                           string name = tag.ListaAtributos["Name"].Valor;
                           Level level = new Level(name,world);
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