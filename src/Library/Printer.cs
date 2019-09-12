using System;
using System.Collections.Generic;

namespace ExerciseOne
{
    /// <summary>
    /// NOMBRE: PrintTags.
    /// DESCRIPCION: esta clase se encarga de imprimir una lista que se le pasa por parametros.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque tiene la información necesaria para poder 
    ///                cumplir con la responsabilidad. no necesita conocer mas nada, solo se encarga de imprimir por 
    ///                consola una lista formateada.
    /// SRP: esta clase presenta una unica responsabilidad que es imrpimir los elementos de una lista, tiene una sola 
    ///      razon de cambio que es cambiar el metodo de impresion.
    /// COLABORACIONES: colabora con IPrinter (interface con la firma Print).
    /// </summary>
    public class Printer : IPrinter
    {
        /// <summary>
        /// recorre los elementos de una lista de tipo List<string> e imprime sus elementos uno por linea
        /// </summary>
        /// <param name="lista">recibe un elemento de tipo List<string> brindado por la clase Formater para ser impreso</param>
        public void Print(List<string> lista)
        {
            foreach (var elemento in lista)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}