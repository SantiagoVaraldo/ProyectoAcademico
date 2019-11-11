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
        private Element lastElement;
        private Element beforeLastElement;

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

        public Element LastElement
        {
            get
            {
                return this.lastElement;
            }

            set
            {
                this.lastElement = value;
            }
        }

        public Element BeforeLastElement
        {
            get
            {
                return this.beforeLastElement;
            }

            set
            {
                this.beforeLastElement = value;
            }
        }

        public abstract void Visit(World world);

        public abstract void Visit(Level level);

        public abstract void Visit(Screen screen);
    }
}