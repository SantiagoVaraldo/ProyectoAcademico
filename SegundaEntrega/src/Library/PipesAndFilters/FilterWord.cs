using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;
using System.IO;

/// <summary>
/// 
/// 
/// CHAIN RESPONSiBILITY: esta clase es parte de la cadena de Pipes And Filters.
/// </summary>

namespace Library
{
    public class FilterWord : IFilterConditional
    {
        private bool result;
        public bool Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        /// <summary>
        /// filtra el Tag recibido
        /// </summary>
        /// <param name="tag">Tag a filtrar</param>
        /// <returns>retorna el Tag</returns>
        public Tag Filter(Tag tag)
        {
            if (tag.Name == "Word")
            {
                this.Result = true;
                IXML word = new Word(tag.ListaAtributos["Name"].Valor, Int32.Parse(tag.ListaAtributos["PositionY"].Valor), Int32.Parse(tag.ListaAtributos["PositionX"].Valor), Int32.Parse(tag.ListaAtributos["Length"].Valor), Int32.Parse(tag.ListaAtributos["Width"].Valor), Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen[Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen.Count - 1], tag.ListaAtributos["ImagePath"].Valor);
                Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen[Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen.Count - 1].Add(word);
            }
            else
            {
                this.Result = false;
            }
            return tag;

        }
    }
}