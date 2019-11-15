//--------------------------------------------------------------------------------
// <copyright file="Visitor.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: Visitor.
    /// DESCRIPCION: clase abstracta para implementar el patron Visitor.
    /// VISITOR: decidimos utilizar este patron para poder acceder a un objeto de tipo World, un objeto Level y un objeto
    /// Screen para poder acceder a algunas de sus propiedades sin la necesidad de romper con la ley de Demeter.
    /// primero lo que hacemos es visitar el World, tomamos el ultimo Level de su lista y lo visitamos, tomamos
    /// la ultima Screen de su lista y la visitamos, por ultimo visitamos esa Screen para encontrar algunos de
    /// sus elementos.
    /// </summary>
    public abstract class Visitor
    {
        private World world;
        private Level lastLevel;
        private Screen lastScreen;
        private Element wordDestination;
        private Element wordSource;

        /// <summary>
        /// World a visitar.
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
                this.world = value;
            }
        }

        /// <summary>
        /// Level a visitar.
        /// </summary>
        /// <value> Level. </value>
        public Level LastLevel
        {
            get
            {
                return this.lastLevel;
            }

            set
            {
                this.lastLevel = value;
            }
        }

        /// <summary>
        /// Screen a visitar.
        /// </summary>
        /// <value> Screen. </value>
        public Screen LastScreen
        {
            get
            {
                return this.lastScreen;
            }

            set
            {
                this.lastScreen = value;
            }
        }

        /// <summary>
        /// destination correspondiente al word.
        /// </summary>
        /// <value> destination. </value>
        public Element WordDestination
        {
            get
            {
                return this.wordDestination;
            }

            set
            {
                this.wordDestination = value;
            }
        }

        /// <summary>
        /// source correspondiente al Word.
        /// </summary>
        /// <value> source. </value>
        public Element WordSource
        {
            get
            {
                return this.wordSource;
            }

            set
            {
                this.wordSource = value;
            }
        }

        /// <summary>
        /// se accede a un World.
        /// </summary>
        /// <param name="world"> World al que se accede. </param>
        public abstract void Visit(World world);

        /// <summary>
        /// se accede a un Level.
        /// </summary>
        /// <param name="level"> Level al que se accede. </param>
        public abstract void Visit(Level level);

        /// <summary>
        /// se accede a una Screen.
        /// </summary>
        /// <param name="screen"> Screen a la que se accede. </param>
        public abstract void Visit(Screen screen);
    }
}