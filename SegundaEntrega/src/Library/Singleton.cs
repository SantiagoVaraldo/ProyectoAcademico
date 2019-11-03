using System.Collections.Generic;

/// <summary>
/// NOMBRE: Singleton<T>
/// SINGLETON: clase implementada para aplicar el patron singleton, esta clase crea una instancia del objeto T, en caso
/// de que exista ya una instancia simplemente te devuelve la misma, es usada para los motores
/// </summary>

namespace Library
{
         public class Singleton<T> where T : new ()
         {
                  private static T instance;
                  public static T Instance
                  {
                           get
                           {
                                    if (instance == null)
                                    {
                                             instance = new T();
                                    }

                                    return instance;
                           }
                  }
         }
}