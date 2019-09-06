using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;

/* ------------------------------------------------------------------------------------------------------------------------
NOMBRE: Finder
DESCRIPCION: esta clase se encarga de encontar los tags y los atributos de un codigo HTML y guardarlos en una lista
             para esto, la clase TagFinder tiene 2 metodos, el metodo findTags recibe un codigo HTML y devuelve los
             tags en una lista. El metodo Find recibe un codigo HTML y agrega los atributos a la misma lista.
PATRON EXPERT: 
SRP: esta clase tiene la responsabilidad de encontrar tags y atributos de un codigo HTML, tiene solo una razon de cambio,
     la razon de cambio es cambiar la manera de encontrar tags y atributos en un codigo HTML.
COLABORACIONES: esta clase colabora con las clases Tag y Atribute, ya que va a enviar mensajes a estas clases para crear
                los objetos.
---------------------------------------------------------------------------------------------------------------------------
 */

namespace ExerciseOne
{
    public static class Finder
    {
        public static List<Tag> Find(string content)
        {
            //to-do aprolijar comentarios.

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
                            string[] atributeElements = atribute.Trim().Split("=");
                            string name = atributeElements[0];
                            string value = atributeElements[1].Trim('"');
                            //crea el atributo y lo guarda en attributes
                            Attribute atr = new Attribute(name, value);
                            attributes.Add(atr);

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
