using System;
using Proyecto.Common;
using ExerciseOne;

namespace Library
{
         public class VisitorWord : Visitor
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

                  public VisitorWord(Tag Tag)
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
                           if (level.ScreenList.Count >= 1)
                           {
                                    this.lastScreen = level.ScreenList[level.ScreenList.Count - 1];
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

                           string name = tag.AttributeList["Name"].Value;
                           int positionY = Int32.Parse(tag.AttributeList["PositionY"].Value);
                           int positionX = Int32.Parse(tag.AttributeList["PositionX"].Value);
                           int length = Int32.Parse(tag.AttributeList["Length"].Value);
                           int width = Int32.Parse(tag.AttributeList["Width"].Value);
                           string imagePath = tag.AttributeList["ImagePath"].Value;

                           IXML word = new Word(name, positionY, positionX, length, width, this.lastScreen, imagePath, (DragAndDropSource)this.beforeLastElement, (BlankSpace)this.lastElement);
                           this.lastScreen.Add(word);
                  }
         }
}