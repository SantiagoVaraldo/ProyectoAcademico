using System;
using System.Collections.Generic;

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
    public class Formater
    {
        public static List<string> lista_formated = new List<string>();
        /// <summary>
        /// metodo static que crea formatea una lista para ser impresa.
        /// </summary>
        /// <param name="lista">recibe un elemento de tipo ArrayList para ser recorrido</param>
        public static List<string> Format(List<Tag> tags)
        {
            foreach (Tag t in tags)
            {
                Console.WriteLine(t.Name);
                if (t.ListaAtributos != null)
                {
                    foreach (Attribute att in t.ListaAtributos)
                    {
                        string attributeInfo = att.Clave + "=" + att.Valor;
                        Console.WriteLine(attributeInfo);
                    }
                }

            }
            return lista_formated;
        }
    }
}