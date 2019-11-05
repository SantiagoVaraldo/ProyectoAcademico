//--------------------------------------------------------------------------------
// <copyright file="VisitorScreen.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ExerciseOne;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: VisitorScreen.
    /// DESCRIPCION: crea un objeto de tipo Screen.
    /// VISITOR: hereda de la clase Visitor, es parte de la implementacion del patron mencionado en Visitor.
    /// SRP: esta clase implementa una unica responsabilidad, crear objetos de tipo Screen,
    /// su unica razon de cambio es modificar la manera de instanciar dichos objetos.
    /// COLABORACIONES: colabora con la clase Visitor, ya que hereda de la misma, colabora con la clase Tag ya que conoce
    /// un objeto Tag, colabora con Word, Level y Screen.
    /// </summary>
    public class VisitorScreen : Visitor
    {
        private Tag tag;

        public VisitorScreen(Tag tag)
        {
            this.Tag = tag;
        }

        public Tag Tag
        {
            get
            {
                return this.tag;
            }

            set
            {
                this.tag = value;
            }
        }

        /// <summary>
        /// metodo para acceder al world.
        /// </summary>
        /// <param name="world"> objeto world al que accede. </param>
        public override void Visit(World world)
        {
            if (world.ListLevel.Count >= 1)
            {
                this.LastLevel = world.ListLevel[world.ListLevel.Count - 1];
            }

            string name = this.tag.ListaAtributos["Name"].Valor;

            Screen screen = new Screen(name, this.LastLevel);
            this.LastLevel.Add(screen);
        }

        /// <summary>
        /// metodo para acceder al level.
        /// </summary>
        /// <param name="level"> objeto level al que se accede. </param>
        public override void Visit(Level level)
        {
        }

        /// <summary>
        /// metodo para acceder a la screen.
        /// </summary>
        /// <param name="screen"> objeto Screen a la que se accede. </param>
        public override void Visit(Screen screen)
        {
        }
    }
}