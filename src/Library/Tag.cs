using System;
using System.Collections;
using System.Collections.Generic;

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
