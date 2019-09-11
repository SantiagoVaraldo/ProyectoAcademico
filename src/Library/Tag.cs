using System;
using System.Collections;
using System.Collections.Generic;

namespace ExerciseOne
{
    /// <summary>
    /// NOMBRE: Tag.
    /// DESCRIPCION: esta clase se encarga de crear objetos con los tags del codigo HTML.
    /// PATRON EXPERT: esta clase cumple con el patron expert, porque es experta en conocer el nombre de un tag.
    /// SRP: esta clase presenta una unica responsabilidad que es crear los objetos, su unica razon de cambio es
    ///      modificar la manera de crear objetos Tag.
    /// COLABORACIONES: colabora con la clase Atribute ya que recibe como parametro de creacion del Tag una lista 
    ///                 de objetos Atribute.
    /// </summary>
    public class Tag
    {
        private List<Attribute> listaAtributos = new List<Attribute>();
        public List<Attribute> ListaAtributos
        {
            get { return this.listaAtributos; }
            set { this.listaAtributos = value; }
        }
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Tag(string Name, List<Attribute> Lista_atributos)
        {
            this.Name = Name;
            this.ListaAtributos = Lista_atributos;
        }
        public Tag(string Name)
        {
            this.Name = Name;
            this.ListaAtributos = null;
        }
    }
}
