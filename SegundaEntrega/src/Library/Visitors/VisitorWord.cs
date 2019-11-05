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
                           if (level.ListaScreen.Count >= 1)
                           {
                                    this.lastScreen = level.ListaScreen[level.ListaScreen.Count - 1];
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

                           string name = tag.ListaAtributos["Name"].Value;
                           int positionY = Int32.Parse(tag.ListaAtributos["PositionY"].Value);
                           int positionX = Int32.Parse(tag.ListaAtributos["PositionX"].Value);
                           int length = Int32.Parse(tag.ListaAtributos["Length"].Value);
                           int width = Int32.Parse(tag.ListaAtributos["Width"].Value);
                           string imagePath = tag.ListaAtributos["ImagePath"].Value;

                           IXML word = new Word(name, positionY, positionX, length, width, this.lastScreen, imagePath, (DragAndDropSource)this.beforeLastElement, (BlankSpace)this.lastElement);
                           this.lastScreen.Add(word);
                  }
         }
}