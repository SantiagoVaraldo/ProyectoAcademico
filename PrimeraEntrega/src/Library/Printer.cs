using System;
using System.Collections.Generic;

namespace ExerciseOne
{
    /// <summary>
    /// NOMBRE: Printer.
    /// 
    /// DESCRIPCION: Esta clase se encarga de imprimir por consola una lista de Tags.
    /// 
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque tiene la información necesaria para poder 
    /// cumplir con su responsabilidad. No necesita conocer mas nada, solo se encarga de imprimir por 
    /// consola una lista formateada.
    /// 
    /// SRP: Esta clase presenta una unica responsabilidad que es imprimir los elementos de una lista. Tiene una sola 
    /// razon de cambio que es cambiar la manera en la cual se imprime los contenidos de la lista de Tags.
    /// 
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