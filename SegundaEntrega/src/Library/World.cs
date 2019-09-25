using System;

/// <summary>
/// NOMBRE: World.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los Mundos.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos Worlds, conoce nombre y tamaño del World.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de World, su unica razon de cambio es modificar los datos que guardamos sobre el mundo.
/// 
/// COLABORACIONES: No colabora con ninguna otra clase.
/// </summary>

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
                                    if (size > 0)
                                    {
                                             this.size = size;// verificar que size sea mayor que 0
                                    }

                           }
                  }
         }
}
