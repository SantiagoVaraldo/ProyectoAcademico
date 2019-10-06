using System;
using System.Collections.Generic;
/// <summary>
/// NOMBRE: Level.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los niveles.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos Levels, conoce nombre y un objeto World al que 
/// pertenece el Level.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de Level, su unica razon de cambio es modificar los datos que guardamos sobre el nivel.
/// 
/// COLABORACIONES: Colabora con la clase World ya que debe conocer un objeto de tipo World.
/// </summary>

namespace Library
{
         public class Level : IContainer
         {
                  public Level(string Name, World World)
                  {
                           this.Name = Name;
                           this.World = World;
                  }
                  private string name;
                  private World world;
                  private List<Screen> listascreen = new List<Screen>();
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
                  public World World
                  {
                           get
                           {
                                    return this.world;
                           }
                           set
                           {
                                    if (value != null)
                                    {
                                             this.world = value;
                                    }
                           }
                  }

                  public List<Screen> ListaScreen
                  {
                           get
                           {
                                    return this.listascreen;
                           }
                           set
                           {
                                    this.listascreen = value;
                           }
                  }
                  public void Add(IXML ixml)
                  {
                           if (ixml is Screen)
                           {
                                    this.ListaScreen.Add((Screen)ixml);
                           }
                  }
         }
}
