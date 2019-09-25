﻿using System;

namespace Library
{
         // crear una clase singleton para aplicar el patron con World
         public class World
         {
                  public World(string name, int size)
                  {
                           this.name = name;
                           this.size = size;
                  }
                  private string name;
                  private int size;
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
                                    // verificar que size sea mayor que 0
                           }
                  }
         }
}
