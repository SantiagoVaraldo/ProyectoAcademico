using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

/// <summary>
/// NOMBRE: FilterScreen.
/// 
/// DESCRIPCION: este filtro se encarga de tomar un Tag y filtrarlo para saber si debe crear un objeto Screen.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es Crear un objeto Screen en caso
/// de que el nombre del Tag sea el correspondiente, su unica razon de cambio es modificar que es lo que necesita una Screen
/// para ser creada.
/// 
/// PATRON EXPERT: Conoce el filtro que se va a aplicar y el resultado de aplicar ese filtro.
/// 
/// CHAIN RESPONSiBILITY: esta clase es parte de la cadena de Pipes And Filters.
/// </summary>

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

        /// <summary>
        /// filtra un tag recibido por parametros
        /// </summary>
        /// <param name="tag">Tag a filtrar</param>
        /// <returns>Tag</returns>
        public Tag Filter(Tag tag)
        {
            if (tag.Name == "Screen")
            {
                this.Result = true;
                IXML screen = new Screen(tag.ListaAtributos["Name"].Valor, Creator.world.ListaLevel[Creator.world.ListaLevel.Count - 1]);
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