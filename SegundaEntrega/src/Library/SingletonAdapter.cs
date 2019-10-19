using Proyecto.Common;

/// <summary>
/// SINGLETON: para todo el programa necesitamos solamente utilizar la misma instancia del Adapter,
/// por lo tanto, decidimos mediante esta clase implementar esa misma instancia para el builder y para los botones.
/// </summary>

namespace Library
{
         public class SingletonAdapter
         {
                  public static IMainViewAdapter Adapter { get; set; } 
         }
}