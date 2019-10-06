using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;
using System.IO;

namespace Library
{
    public class FilterWorld : IFilterConditional
    {
        private bool result;
        public bool Result
        {
            get { return this.result; }
            set { this.result = value; }
        }
        public Tag Filter(Tag tag)
        {
            if (tag.Name == "World")
            {
                this.Result = true;
                World world = new World(tag.ListaAtributos["Name"].Valor, Int32.Parse(tag.ListaAtributos["Length"].Valor), Int32.Parse(tag.ListaAtributos["Width"].Valor));
                Creator.world = world;
            }
            else
            {
                this.Result = false;
            }
            return tag;

        }
    }
}