//--------------------------------------------------------------------------------
// <copyright file="FilterLevel.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using ExerciseOne;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
    /// <summary>
    /// NOMBRE: FilterLevel.
    /// DESCRIPCION: este filtro se encarga de tomar un Tag y filtrarlo para saber si debe crear un objeto Level.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es Crear un objeto Level en caso
    /// de que el nombre del Tag sea el correspondiente, su unica razon de cambio es modificar como se debe filtrar.
    /// PATRON EXPERT: Conoce el filtro que se va a aplicar y el resultado de aplicar ese filtro.
    /// PATRON CREATOR: los objetos son creados en el filtro, el filtro no es el experto en conocer todo lo necesario para
    /// crear dicho objeto, sin embargo al intentar cumplir con el patron aparecian otras dificultades mayores
    /// (cuando llamamos al metodo Add del IContainer, es ahi donde deberia instanciarse el objeto ya que el contenedor
    /// si conoce los datos necesarios)
    /// PRINCIPIO OCP: la creacion de pipes and filters cumple con el principio de OCP, si tenemos un nuevo elemento
    /// simplemente agregamos un nuevo filtro y un pipe extra. El codigo queda abierto a la extencion pero cerrado a la
    /// modificacion ya que no se debera modificar los pipes and filters ya creados.
    /// CHAIN RESPONSiBILITY: esta clase es parte de la cadena de Pipes And Filters.
    /// </summary>
    public class FilterLevel : IFilterConditional
    {
        private bool result;

        public bool Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        /// <summary>
        /// filtra un Tag recibido.
        /// </summary>
        /// <param name="tag">el Tag a filtrar.</param>
        /// <returns>retorna el Tag.</returns>
        public Visitor Filter(Tag tag)
        {
            if (tag.Name == "Level")
            {
                this.Result = true;
                Visitor visitorLevel = new VisitorLevel(tag);
                return visitorLevel;
            }
            else
            {
                this.Result = false;
                return null;
            }
        }
    }
}