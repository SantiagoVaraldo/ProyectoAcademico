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
    public class FilterLetter : IFilterConditional
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
            if (tag.Name == "Letter")
            {
                this.Result = true;
                
                string name = tag.ListaAtributos["Name"].Valor;
                int positionY = Int32.Parse(tag.ListaAtributos["PositionY"].Valor);
                int positionX = Int32.Parse(tag.ListaAtributos["PositionX"].Valor);
                int length = Int32.Parse(tag.ListaAtributos["Length"].Valor);
                int width = Int32.Parse(tag.ListaAtributos["Width"].Valor);
                Screen screen = Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen[Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen.Count - 1];
                string imagePath = tag.ListaAtributos["ImagePath"].Valor;
                bool rigth = Convert.ToBoolean(tag.ListaAtributos["Right"].Valor); 

                IXML letter = new Letter(name, positionY, positionX, length, width, screen, imagePath, rigth);
                Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen[Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1].ListaScreen.Count - 1].Add(letter);
            }
            else
            {
                this.Result = false;
            }
            return tag;

        }
    }
}