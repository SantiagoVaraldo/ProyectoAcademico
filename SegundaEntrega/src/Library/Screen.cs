using System;

/// <summary>
/// NOMBRE: Screen.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a las pantallas.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos Screen, conoce el nombre y un Level
/// al que pertenece la Screen.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de Screen, su unica razon de cambio es modificar los datos que guardamos sobre la pantalla.
/// 
/// COLABORACIONES: Colabora con la clase Level ya que debe conocer un objeto de tipo Level.
/// </summary>

namespace Library
{
         public class Screen
         {
                  public Screen(string name, Level level)
                  {
                           this.name = name;
                           this.level = level;
                  }
                  private string name;
                  private Level level;
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
         }
}
