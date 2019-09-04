using System;
using System.Collections;

/*----------------------------------------------------------------------------------------------------------------------------
NOMBRE: PrintTags.
DESCRIPCION: esta clase se encarga de imprimir una lista que se le pasa por parametros.
PATRON EXPERT:
SRP: esta clase presenta una unica responsabilidad que es imrpimir los elementos de una lista, tiene una sola razon
     de cambio que es cambiar el metodo de impresion.
COLABORACIONES: colabora con la clase Format que es quien le pasa la lista de lo que debe imprimir.

------------------------------------------------------------------------------------------------------------------------------
 */

namespace ExerciseOne
{
         public class PrintTags
         {
                  /// <summary>
                  /// metodo static que imprime los elementos de una lista.
                  /// </summary>
                  /// <param name="lista">recibe un elemento de tipo ArrayList para ser recorrido</param>
                  public static void Print(ArrayList lista)
                  {
                           foreach (var elemento in lista)
                           {
                                    Console.WriteLine(elemento);
                           }
                  }
         }
}