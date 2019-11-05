using System;
using Proyecto.Common;
using ExerciseOne;

namespace Library
{
         public class VisitorDragAndDropDestination : Visitor
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

                  public VisitorDragAndDropDestination(Tag Tag)
                  {
                           this.Tag = Tag;
                  }

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
                           }

                           string name = tag.ListaAtributos["Name"].Value;
                           int positionY = Int32.Parse(tag.ListaAtributos["PositionY"].Value);
                           int positionX = Int32.Parse(tag.ListaAtributos["PositionX"].Value);
                           int length = Int32.Parse(tag.ListaAtributos["Length"].Value);
                           int width = Int32.Parse(tag.ListaAtributos["Width"].Value);
                           string imagePath = tag.ListaAtributos["ImagePath"].Value;

                           BlankSpace blankSpace = new BlankSpace(name, positionY, positionX, length, width, this.lastScreen, imagePath);
                           this.lastScreen.Add(blankSpace);
                  }

                  public override void Visit(Screen screen)
                  {
                  }
         }
}