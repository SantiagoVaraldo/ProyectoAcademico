using System;
using System.Collections;

/*----------------------------------------------------------------------------------------------------------------------------
NOMBRE: PrintTags.
DESCRIPCION: esta clase se encarga de imprimir una lista de tags que se le pasa por parametros.
PATRON EXPERT:
SRP: esta clase presenta una unica responsabilidad que es imrpimir los elementos de una lista, tiene una sola razon
     de cambio.

------------------------------------------------------------------------------------------------------------------------------
 */

 // se puede separar en una clase Format que me devuelva una lista con lo que voy a imprimir y una clase Print que la recorra e imprima

namespace ExerciseOne
{
         public class PrintTags
         {
                  /// <summary>
                  /// metodo static que imprime los elementos de una lista.
                  /// </summary>
                  /// <param name="lista">recibe un elemento de tipo ArrayList para ser recorrido</param>
                  public static void Print(ArrayList listaTags)
                  {
                           foreach (Tag elemento in listaTags)
                           {
                                    Console.WriteLine(elemento.Name + "\n");
                                    if (elemento.ListaAtributos != null)
                                    {
                                             foreach(Atribute Elemento in elemento.ListaAtributos)
                                             {
                                                      Console.WriteLine(Elemento.Clave + "=" + Elemento.Valor);
                                             }
                                    }
                           }
                  }
         }
}