using System;
using System.Collections.Generic;

namespace ExerciseOne
{
    /// <summary>
    /// NOMBRE: Format
    /// DESCRIPCION: esta clase se encarga de darle formato a los elementos de una lista para ser impresos.
    /// PATRON EXPERT: conoce una List<string> que va a ser llenada de la manera deseada con elementos do otra lista
    ///                List<Tag> que se le brinda por parametros, conoce la informacion necesaria para cumplir 
    ///                con su responsabilidad.
    /// SRP: esta clase presenta una unica responsabilidad que es dar formato a elementos para que puedan ser impresos adecuadamente.
    /// COLABORACIONES: colabora con la clase Finder que le brinda una lista con objetos Tag para ser formateados.
    /// </summary>
    public class Formater
    {
        public List<string> lista_formated = new List<string>();
        /// <summary>
        /// /// metodo que crea una lista formateada para ser impresa.
        /// </summary>
        /// <param name="tags">List<Tag> una lista con objetos Tag para ser formateada y preparada para imprimir</param>
        /// <returns>List<string> una lista de string formateada lista para imprimir</returns>
        public List<string> Format(List<Tag> tags)
        {
            foreach (Tag t in tags)
            {
                lista_formated.Add(t.Name);
                if (t.ListaAtributos != null)
                {
                    foreach (Attribute att in t.ListaAtributos)
                    {
                        string attributeInfo = att.Clave + "=" + att.Valor;
                        lista_formated.Add(attributeInfo);
                    }
                }

            }
            return lista_formated;
        }
    }
}