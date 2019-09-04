using System;
using System.Collections;
using System.Collections.Generic;

/*----------------------------------------------------------------------------------------------------------------------------
NOMBRE: Tag.
DESCRIPCION: esta clase se encarga de crear objetos con los tags del codigo HTML.
PATRON EXPERT:
SRP: esta clase presenta una unica responsabilidad que es crear los objetos, su unica razon de cambio es
     modificar la manera de crear objetos Tag.
COLABORACIONES: colabora con la clase Atribute ya que recibe como parametro de creacion del Tag una lista de objetos
                Atribute.

------------------------------------------------------------------------------------------------------------------------------
 */

namespace ExerciseOne
{
    public class Tag
    {
        public List<Atribute> ListaAtributos = new List<Atribute>();
        public string Name;
        public Tag (string name, List<Atribute> lista_atributos)
        {
            this.Name = name;
            this.ListaAtributos = lista_atributos;
        }
    }
}
