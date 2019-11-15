//--------------------------------------------------------------------------------
// <copyright file="World.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// NOMBRE: World.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los Mundos, implementa la interfaz
    /// IContainer.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos World, conoce nombre del World y una lista con
    /// los niveles pertinentes a ese World.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de World, su unica razon de cambio es modificar los datos que guardamos sobre el mundo.
    /// COLABORACIONES: Colabora con Level ya que conoce una lista de Level, con la interfaz IContainer ya
    /// que es un tipo de contenedor y con la clase Visitor, ya que implementa el patron mediante el metodo
    /// Accept.
    /// </summary>
    public class World : IContainer
    {
        private string name;
        private List<Level> listLevel = new List<Level>();

        public World()
        {
            this.Name = "TheWorld";
        }

        /// <summary>
        /// nombre del world.
        /// </summary>
        /// <value> nombre. </value>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// lista de niveles del World.
        /// </summary>
        /// <value> lista de niveles. </value>
        public List<Level> ListLevel
        {
            get
            {
                return this.listLevel;
            }
        }

        /// <summary>
        /// metodo de la interfaz IContainer donde agrega un elemento de tipo
        /// IXML en este caso un level a la lista de niveles.
        /// </summary>
        /// <param name="ixml"> recibe un IXML para agregar a la lista. </param>
        public void Add(IXML ixml)
        {
            if (ixml is Level)
            {
                this.ListLevel.Add((Level)ixml);
            }
        }

        /// <summary>
        /// metodo que forma parte de la implementacion del patron Visitor.
        /// </summary>
        /// <param name="visitor"> instancia de Visitor. </param>
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
