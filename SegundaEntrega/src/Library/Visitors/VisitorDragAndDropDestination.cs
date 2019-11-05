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

                           string name = tag.AttributeList["Name"].Value;
                           int positionY = Int32.Parse(tag.AttributeList["PositionY"].Value);
                           int positionX = Int32.Parse(tag.AttributeList["PositionX"].Value);
                           int length = Int32.Parse(tag.AttributeList["Length"].Value);
                           int width = Int32.Parse(tag.AttributeList["Width"].Value);
                           string imagePath = tag.AttributeList["ImagePath"].Value;

                           BlankSpace blankSpace = new BlankSpace(name, positionY, positionX, length, width, this.lastScreen, imagePath);
                           this.lastScreen.Add(blankSpace);
                  }

                  public override void Visit(Screen screen)
                  {
                  }
         }
}