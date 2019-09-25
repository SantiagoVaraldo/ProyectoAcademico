using System;

namespace Library
{
         public class Element
         {
                  public Element(string name, int size, int posicionX, int posicionY, Screen screen)
                  {
                           this.name = name;
                           this.size = size;
                           this.posicionX = posicionX;
                           this.posicionY = posicionY;
                           this.screen = screen;
                  }
                  private string name;
                  private int size;
                  private int posicionX;
                  private int posicionY;
                  private Screen screen;
                  public string Name
                  {
                           get
                           {
                                    return this.name;
                           }
                           set
                           {
                                    if (!string.IsNullOrEmpty(value))
                                    {
                                             this.name = value;
                                    }
                           }
                  }
                  public int Size
                  {
                           get
                           {
                                    return this.size;
                           }
                           set
                           {
                                    // verificar que el size sea mayor a 0
                           }
                  }
                  public int PosicionX
                  {
                           get
                           {
                                    return this.posicionX;
                           }
                           set
                           {
                                    // verificar que la posicionX este dentro de la ventana del World
                           }
                  }
                  public int PosicionY
                  {
                           get
                           {
                                    return this.posicionY;
                           }
                           set
                           {
                                    // verificar que la posicionY este dentro de la ventana del World
                           }
                  }
         }
}
