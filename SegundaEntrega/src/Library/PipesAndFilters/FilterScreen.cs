using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
    public class FilteScreen : IFilterConditional
    {
        private bool result;
        public bool Result
        {
            get { return this.result; }
            set { this.result = value; }
        }
        public Tag Filter(Tag tag)
        {
            if (tag.Name == "Screen")
            {
                this.Result = true;
                Screen screen = new Screen(tag.ListaAtributos["Name"].Valor, Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1]);
                Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].Add(screen);
            }
            else
            {
                this.Result = false;
            }
            return tag;

        }
    }
}