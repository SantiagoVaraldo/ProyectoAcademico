using System;
using Proyecto.Common;
using ExerciseOne;

namespace Library
{
         public class VisitorSound : Visitor
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

                  public VisitorSound(Tag Tag)
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
                           string soundPath = tag.AttributeList["SoundPath"].Value;

                           IXML button = new ButtonSound(name, positionY, positionX, length, width, this.lastScreen, imagePath, soundPath);
                           this.lastScreen.Add(button);
                  }

                  public override void Visit(Screen screen)
                  {
                  }
         }
}