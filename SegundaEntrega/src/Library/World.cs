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
    /// pertinente para nuestros requisitos de crear objetos Worlds, conoce nombre, tamaño del World y una lista con
    /// los niveles pertinentes a ese World.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de World, su unica razon de cambio es modificar los datos que guardamos sobre el mundo.
    /// COLABORACIONES: Colabora con Level ya que conoce una lista de Level y con la interfaz IContainer.
    /// </summary>
    public class World : IContainer
    {
        private string name;
        private int? length;
        private int? width;
        private List<Level> listLevel = new List<Level>();

        public World(string name, int length, int width)
        {
            this.Name = name;
            this.Length = length;
            this.Width = width;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

        public int? Length
        {
            get
            {
                return this.length;
            }

            set
            {
                if (value > 0)
                {
                    this.length = value;
                }
            }
        }

        public int? Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
            }
        }

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
        /// metodo implementado para la utilizacion del patron Visitor.
        /// </summary>
        /// <param name="visitor"> instancia de Visitor. </param>
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
