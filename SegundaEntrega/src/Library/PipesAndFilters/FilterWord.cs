//--------------------------------------------------------------------------------
// <copyright file="FilterWord.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using ExerciseOne;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
    /// <summary>
    /// NOMBRE: FilterWord.
    /// DESCRIPCION: este filtro se encarga de tomar un Tag y filtrarlo para saber si debe crear un VisitorWord.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es Crear un objeto VisitorWord en caso
    /// de que el nombre del Tag sea el correspondiente, su unica razon de cambio es modificar como se debe filtrar.
    /// PATRON EXPERT: Conoce el filtro que se va a aplicar y el resultado de aplicar ese filtro.
    /// PRINCIPIO OCP: la creacion de pipes and filters cumple con el principio de OCP, si tenemos un nuevo elemento
    /// simplemente agregamos un nuevo filtro y un pipe extra. El codigo queda abierto a la extencion pero cerrado a la
    /// modificacion ya que no se debera modificar los pipes and filters ya creados.
    /// CHAIN OF RESPONSiBILITY: esta clase es parte de la cadena de Pipes And Filters.
    /// </summary>
    public class FilterWord : IFilterConditional
    {
        /// <summary>
        /// resultado de aplicar el filtro.
        /// </summary>
        /// <value>bool.</value>
        public bool Result { get; set; }

        /// <summary>
        /// filtra el Tag recibido.
        /// </summary>
        /// <param name="tag">Tag a filtrar.</param>
        /// <returns>retorna el Visitor correspondiente.</returns>
        public Visitor Filter(Tag tag)
        {
            if (tag.Name == "Word")
            {
                this.Result = true;
                Visitor visitorWord = new VisitorWord(tag);
                return visitorWord;
            }
            else
            {
                this.Result = false;
                return null;
            }
        }
    }
}