//--------------------------------------------------------------------------------
// <copyright file="Level.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// NOMBRE: Level.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los niveles es de tipo IContainer,
    /// conoce una lista de Screen donde se almacenan todas las pantallas correspondientes al nivel.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos Levels, conoce nombre y un objeto World al que
    /// pertenece el Level.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de Level, su unica razon de cambio es modificar los datos que guardamos sobre el nivel.
    /// COLABORACIONES: Colabora con la clase World y Screen ya que debe conocer un objeto de tipo World y una lista de Screen
    /// y ademas con la interfaz IContainer. Tambien colabora con Visitor ya que es parte de la implemetacion de
    /// dicho patron por medio del metodo Accept.
    /// </summary>
    public class Level : IContainer
    {
        private string name;
        private World world;
        private List<Screen> screenList = new List<Screen>();

        /// <summary>
        /// constructor del nivel.
        /// </summary>
        /// <param name="name">nombre.</param>
        /// <param name="world">mundo al que pertenece el nivel.</param>
        public Level(string name, World world)
        {
            this.Name = name;
            this.World = world;
        }

        /// <summary>
        /// nombre del Level.
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
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

        /// <summary>
        /// World al que pertenece el Level.
        /// </summary>
        /// <value> World. </value>
        public World World
        {
            get
            {
                return this.world;
            }

            set
            {
                if (value != null)
                {
                    this.world = value;
                }
            }
        }

        /// <summary>
        /// lista de Screen que contiene el Level.
        /// </summary>
        /// <value> lista de Screens. </value>
        public List<Screen> ScreenList
        {
            get
            {
                return this.screenList;
            }
        }

        /// <summary>
        /// metodo de la interfaz IContainer donde agrega un elemento de tipo
        /// IXML en este caso una Screen a la lista de Screen.
        /// </summary>
        /// <param name="ixml"> recibe un IXML para agregar a la lista. </param>
        public void Add(IXML ixml)
        {
            if (ixml is Screen)
            {
                this.ScreenList.Add((Screen)ixml);
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
