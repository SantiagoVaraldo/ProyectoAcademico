//--------------------------------------------------------------------------------
// <copyright file="FilterScreen.cs" company="Universidad Católica del Uruguay">
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
    /// NOMBRE: FilterScreen.
    /// DESCRIPCION: este filtro se encarga de tomar un Tag y filtrarlo para saber si debe crear un VisitorScreen.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es Crear un objeto VisitorScreen en caso
    /// de que el nombre del Tag sea el correspondiente, su unica razon de cambio es modificar como se debe filtrar.
    /// PATRON EXPERT: Conoce el filtro que se va a aplicar y el resultado de aplicar ese filtro.
    /// PRINCIPIO OCP: la creacion de pipes and filters cumple con el principio de OCP, si tenemos un nuevo elemento
    /// simplemente agregamos un nuevo filtro y un pipe extra. El codigo queda abierto a la extencion pero cerrado a la
    /// modificacion ya que no se debera modificar los pipes and filters ya creados.
    /// CHAIN OF RESPONSiBILITY: esta clase es parte de la cadena de Pipes And Filters.
    /// </summary>
    public class FilterScreen : IFilterConditional
    {
        /// <summary>
        /// resultado de aplicar el filtro.
        /// </summary>
        /// <value>bool.</value>
        public bool Result { get; set; }

        /// <summary>
        /// filtra un tag recibido por parametros.
        /// </summary>
        /// <param name="tag">Tag a filtrar.</param>
        /// <returns>Visitor correspondiente.</returns>
        public Visitor Filter(Tag tag)
        {
            if (tag.Name == "Screen")
            {
                this.Result = true;
                Visitor visitorScreen = new VisitorScreen(tag);
                return visitorScreen;
            }
            else
            {
                this.Result = false;
                return null;
            }
        }
    }
}