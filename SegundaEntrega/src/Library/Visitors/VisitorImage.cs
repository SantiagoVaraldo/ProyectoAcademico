using System;
using Proyecto.Common;

namespace Library
{
         public class VisitorImage : Visitor
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

                  private int? positionY;
                  public int? PositionY
                  {
                           get
                           {
                                    return this.positionY;
                           }
                           set
                           {
                                    this.positionY = value;
                           }
                  }

                  private int? positionX;
                  public int? PositionX
                  {
                           get
                           {
                                    return this.positionX;
                           }
                           set
                           {
                                    this.positionX = value;
                           }
                  }

                  private int? length;
                  public int? Length
                  {
                           get
                           {
                                    return this.length;
                           }
                           set
                           {
                                    this.length = value;
                           }
                  }

                  private int? width;
                  public int? Width
                  {
                           get
                           {
                                    return this.width;
                           }
                           set
                           {
                                    this.width = value;
                           }
                  }

                  private string imagePath;
                  public string ImagePath
                  {
                           get
                           {
                                    return this.imagePath;
                           }
                           set
                           {
                                    this.imagePath = value;
                           }
                  }

                  public VisitorScreen(string Name, int PositionY, int PositionY, int Length, int Width, string ImagePath)
                  {
                           this.Name = Name;
                           this.PositionY = PositionY;
                           this.PositionX = PositionX;
                           this.Length = Length;
                           this.Width = Width;
                           this.ImagePath = ImagePath;
                  }

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
                           if (level.ListScreen.Count >= 1)
                           {
                                    this.lastScreen = level.ListScreen[level.ListScreen.Count - 1];
                           }

                           Image image = new Image(name, positionY, positionX, length, width, this.lastScreen, imagePath);
                           this.lastScreen.Add(image);
                  }

                  public override void Visit(Screen screen)
                  {
                  }
         }
}