using System;
using System.Collections;

/*----------------------------------------------------------------------------------------------------------------------------
NOMBRE: Format
DESCRIPCION: esta clase se encarga de darle formato a los elementos de una lista para ser impresos.
PATRON EXPERT:
SRP: esta clase presenta una unica responsabilidad que es dar formato a elements para que puedan ser impresos adecuadamente.
COLABORACIONES: colabora con la clase TagFinder que le brinda una lista con elementos para ser formateados.

------------------------------------------------------------------------------------------------------------------------------
 */

 // se puede separar en una clase Format que me devuelva una lista con lo que voy a imprimir y una clase Print que la recorra e imprima

namespace ExerciseOne
{
         public class Format
         {
                  public static ArrayList lista_formated = new ArrayList();
                  /// <summary>
                  /// metodo static que crea formatea una lista para ser impresa.
                  /// </summary>
                  /// <param name="lista">recibe un elemento de tipo ArrayList para ser recorrido</param>
                  public static ArrayList formater(ArrayList lista)
                  {
                           foreach (Tag elemento in lista)
                           {
                                    Format.lista_formated.Add(elemento.Name + "\n");
                                    if (elemento.ListaAtributos != null)
                                    {
                                             foreach(Atribute Elemento in elemento.ListaAtributos)
                                             {
                                                      Format.lista_formated.Add(Elemento.Clave + "=" + Elemento.Valor);
                                             }
                                    }
                           }
                           return Format.lista_formated;
                  }
         }
}