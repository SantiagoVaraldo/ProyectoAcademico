using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseOne
{
    /// <summary>
    /// NOMBRE: Finder
    /// DESCRIPCION: Esta clase se encarga de encontar los tags y los atributos de un codigo HTML y guardar los objetos
    /// creados en una lista.
    /// 
    /// PATRON EXPERT: La clase Finder es experta en conocer la informacion adecuada para llevar a cabo su tarea y 
    /// cumplir con su responsabilidad, conoce una lista de objetos Tag. (explicado en la descripción).
    /// 
    /// SRP: Esta clase tiene la responsabilidad de encontrar tags y atributos en un string, tiene solo una razon de cambio,
    /// la razon de cambio es cambiar la manera de encontrar tags y atributos en un string.
    /// 
    /// COLABORACIONES: esta clase colabora con las clases Tag y Attribute, ya que va a enviar mensajes a estas clases para 
    /// instanciar los objetos.
    /// </summary>
    public class Finder
    {
        /// <summary>
        /// este metodo Find recorre el codigo y busca los tags y los atributos, la busqueda la realiza por medio de 
        /// expresiones regulares, buscando y leyendo en internet encontramos que esta era una buena manera de poder
        /// realizar esta accion, creemos que es un codigo mas claro y sencillo si se utiliza expresiones regulares
        /// </summary>
        /// <param name="content">codigo HTML en forma de string brindado por la clase Download listo para ser
        /// recorrido y utilizado</param>
        /// <returns>List<Tag> una lista de objetos tag creada a partir de los tag y atributos que se encontraron
        /// en el codigo</returns>
        public List<Tag> Find(string content)
        {

            List<Tag> tags = new List<Tag>();
            string pattern = "<\\w+((\\s+\\w+(\\s*=\\s*(?:\".*?\"|'.*?'|[^'\">\\s]+))?)+\\s*|\\s*)\\/?>";
            //Busca matches en content con el pattern del regex
            MatchCollection matches = Regex.Matches(content, pattern);
            //si encuentra matches...
            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                {
                    //transforma el match a string y le quita "<" del inicio y "/" ">" del final
                    string line = m.Groups[0].ToString();
                    line = line.TrimStart('<');
                    line = line.TrimEnd('>');
                    line = line.TrimEnd('/');

                    //divide la line por espacios
                    List<string> lineElements = line.Split(" ").ToList();
                    //si el array tiene 1 solo elemento (nombre del tag) crea una tag y la agrega al la lista de tags.
                    if (lineElements.Count == 1)
                    {
                        Tag t = new Tag(lineElements[0].Trim());
                        tags.Add(t);
                    }
                    //si el array tiene mas de 1 elemento (nombre de tag y atributo/s) crea un tag con sus atributos y guarda el tag en la lista de tags. 
                    else if (lineElements.Count > 1)
                    {
                        List<Attribute> attributes = new List<Attribute>();
                        Tag t = new Tag(lineElements[0].Trim());

                        //Quita el nombre del tag
                        lineElements.RemoveAt(0);

                        //recorre los atributos
                        foreach (string atribute in lineElements)
                        {
                            //separa entre name y value los atributos
                            string[] atributeElements = atribute.Split("=");
                            if (atributeElements.Length > 1)
                            {
                                string name = atributeElements[0];
                                string value = atributeElements[1].Trim('"');
                                //crea el atributo y lo guarda en attributes
                                Attribute atr = new Attribute(name, value);
                                attributes.Add(atr);
                            }


                        }
                        t.ListaAtributos = attributes;
                        tags.Add(t);
                    }
                }

            }
            return tags;
        }
    }
}
