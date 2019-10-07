using System;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

/// <summary>
/// NOMBRE: FilterLevel.
/// 
/// DESCRIPCION: este filtro se encarga de tomar un Tag y filtrarlo para saber si debe crear un objeto Level.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es Crear un objeto Level en caso
/// de que el nombre del Tag sea el correspondiente, su unica razon de cambio es modificar que es lo que necesita un Level
/// para ser creada.
/// 
/// PATRON EXPERT: Conoce el filtro que se va a aplicar y el resultado de aplicar ese filtro.
/// 
/// CHAIN RESPONSiBILITY: esta clase es parte de la cadena de Pipes And Filters.
/// </summary>

namespace Library
{
    public class FilterLevel : IFilterConditional
    {
        private bool result;
        public bool Result
        {
            get { return this.result; }
            set { this.result = value; }
        }
        /// <summary>
        /// filtra un Tag recibido
        /// </summary>
        /// <param name="tag">el Tag a filtrar</param>
        /// <returns>retorna el Tag</returns>
        public Tag Filter(Tag tag)
        {
            if (tag.Name == "Level")
            {
                this.Result = true;
                IXML level = new Level(tag.ListaAtributos["Name"].Valor, Creator.world);
                Creator.world.Add(level);
            }
            else
            {
                this.Result = false;
            }
            return tag;
        }
    }
}