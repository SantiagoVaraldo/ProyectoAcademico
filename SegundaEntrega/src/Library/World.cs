using System;
using System.Collections.Generic;
/// <summary>
/// NOMBRE: World.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los Mundos, implementa la interfaz
/// IContainer.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos Worlds, conoce nombre, tamaño del World y una lista con
/// los niveles pertinentes a ese World.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de World, su unica razon de cambio es modificar los datos que guardamos sobre el mundo.
/// 
/// COLABORACIONES: No colabora con ninguna otra clase.
/// </summary>

namespace Library
{
         // crear una clase singleton para aplicar el patron con World
         public class World : IContainer
         {
                  public World(string Name, int Length, int Width)
                  {
                           this.Name = Name;
                           this.Length = Length;
                           this.Width = Width;
                  }
                  private string name;
                  private int? length;
                  private int? width;
                  private List<Level> listalevel = new List<Level>();
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
                  public int? Length
                  {
                           get
                           {
                                    return this.length;
                           }
                           set
                           {
                                    if (value > 0)
                                    {
                                             this.length = value;
                                    }

                           }
                  }
                  public int? Width
                  {
                           get
                           {
                                    return this.width;
                           }
                           set
                           {
                                    if (value > 0)
                                    {
                                             this.width = value;
                                    }

                           }
                  }

                  public List<Level> ListaLevel
                  {
                           get
                           {
                                    return this.listalevel;
                           }
                           set
                           {
                                    this.listalevel = value;
                           }
                  }
                  public void Add(IXML ixml)
                  {
                           if (ixml is Level)
                           {
                                    this.ListaLevel.Add((Level)ixml);
                           }
                  }


         }
}
