using System.Collections.Generic;

namespace ExerciseOne
{
    /// <summary>
    /// NOMBRE: Formater
    /// 
    /// DESCRIPCION: Esta clase se encarga de darle formato a los elementos de una lista para ser impresos 
    /// por una subclase de IPrinter (interfaz).
    /// 
    /// PATRON EXPERT: Conoce una List<string> que va a ser llenada de la manera deseada con elementos de otra lista
    /// List<Tag> que se le brinda por parametros, conoce la informacion necesaria para cumplir 
    /// con su responsabilidad.
    /// 
    /// SRP: Esta clase presenta una unica responsabilidad que es dar formato a elementos para que puedan ser impresos adecuadamente.
    /// 
    /// COLABORACIONES: Colabora con la clase Finder que le brinda una lista con objetos Tag para ser formateados.
    /// </summary>
    public class Formater
    {
        public List<string> formatedList = new List<string>();
        /// <summary>
        /// metodo que crea una lista formateada para ser impresa.
        /// </summary>
        /// <param name="tags">List<Tag> una lista con objetos Tag para ser formateada y preparada para imprimir</param>
        /// <returns>List<string> una lista de string formateada lista para imprimir</returns>
        public List<string> Format(List<Tag> tags)
        {
            foreach (Tag t in tags)
            {
                formatedList.Add(t.Name);
                if (t.AttributeList != null)
                {
                    foreach (Attribute att in t.AttributeList.Values)
                    {
                        string attributeInfo = att.Key + "=" + att.Value;
                        formatedList.Add(attributeInfo);
                    }
                }

            }
            return formatedList;
        }
    }
}