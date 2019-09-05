using System.Text.RegularExpressions;
using System.Collections.Generic;

/* ------------------------------------------------------------------------------------------------------------------------
NOMBRE: Finder
DESCRIPCION: esta clase se encarga de encontar los tags y los atributos de un codigo HTML y guardarlos en una lista
             para esto, la clase TagFinder tiene 2 metodos, el metodo findTags recibe un codigo HTML y devuelve los
             tags en una lista. El metodo findAtributes recibe un codigo HTML y agrega los atributos a la misma lista.
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

            List<Tag> dom = new List<Tag>();
            List<string> lines = new List<string>();
            string pattern = "<\\w+((\\s+\\w+(\\s*=\\s*(?:\".*?\"|'.*?'|[^'\">\\s]+))?)+\\s*|\\s*)\\/?>";
            //Busca matches en content con el pattern del regex
            MatchCollection matches = Regex.Matches(content, pattern);
            //si encuentra matches...
            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                {
                    //transforma el match a string y le quita "<" del inicio y "/" ">" del final
                    string linea = m.Groups[0].ToString();
                    linea = linea.TrimStart('<');
                    linea = linea.TrimEnd('>');
                    linea = linea.TrimEnd('/');

                    //divide la linea por espacios
                    string[] lineas = linea.Split(" ");
                    
                    //si el array tiene 1 solo elemento (nombre del tag) crea una tag y la agrega al la lista de tags.
                    if (lineas.Length == 1)
                    {
                        Tag t = new Tag(lineas[0]);
                        dom.Add(t);
                    }
                    //si el array tiene mas de 1 elemento (nombre de tag y atributo/s) crea un tag con sus atributos y guarda el tag en la lista de tags. 
                    else if (lineas.Length > 1)
                    {
                        List<Attribute> attributes = new List<Attribute>();
                        //first pass sirve para solo crear tags con el segundo elemento de lineas, ignorando la primera pasada (nombre de tag)
                        bool firstPass = true;

                        //recorre los atributos
                        foreach (string atribute in lineas){
                            //si es el nombre del tag continua.
                            if (firstPass){
                                firstPass = false;
                                continue;
                            }else{
                                //si es atributo
                                //separa entre name y value
                                string[] atributeElements = atribute.Split("=");
                                string name = atributeElements[0];
                                string value = atributeElements[1].Trim('"');
                                //crea el atributo y lo guarda en attributes
                                Attribute atr = new Attribute(name, value);
                                attributes.Add(atr);
                            }
                        }

                        Tag t = new Tag(lineas[0], attributes);
                        dom.Add(t);
                    }
                }

            }
        return dom;



        }
    }
}
