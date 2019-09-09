using System;
using System.Collections.Generic;

/*----------------------------------------------------------------------------------------------------------------------------
NOMBRE: PrintTags.
DESCRIPCION: esta clase se encarga de imprimir una lista que se le pasa por parametros.

PATRON EXPERT: Esta clase cumple con el patron Expert, porque tiene la información necesaria para poder 
               cumplir con la responsabilidad de imprimir tags.

SRP: esta clase presenta una unica responsabilidad que es imrpimir los elementos de una lista, tiene una sola 
     razon de cambio que es cambiar el metodo de impresion.

COLABORACIONES: colabora con la clase Format que es quien le pasa la lista de lo que debe imprimir.

------------------------------------------------------------------------------------------------------------------------------
 */

namespace ExerciseOne
{
    public class Printer
    {
        /// <summary>
        /// metodo static que imprime los elementos de una lista.
        /// </summary>
        /// <param name="lista">recibe un elemento de tipo ArrayList para ser recorrido</param>
        public void Print(List<string> lista)
        {
            foreach (var elemento in lista)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}