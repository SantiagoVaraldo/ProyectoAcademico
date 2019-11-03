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

                           string name = tag.ListaAtributos["Name"].Valor;
                           int positionY = Int32.Parse(tag.ListaAtributos["PositionY"].Valor);
                           int positionX = Int32.Parse(tag.ListaAtributos["PositionX"].Valor);
                           int length = Int32.Parse(tag.ListaAtributos["Length"].Valor);
                           int width = Int32.Parse(tag.ListaAtributos["Width"].Valor);
                           string imagePath = tag.ListaAtributos["ImagePath"].Valor;
                           string soundPath = tag.ListaAtributos["SoundPath"].Valor;

                           IXML button = new ButtonSound(name, positionY, positionX, length, width, this.lastScreen, imagePath, soundPath);
                           this.lastScreen.Add(button);
                  }

                  public override void Visit(Screen screen)
                  {
                  }
         }
}