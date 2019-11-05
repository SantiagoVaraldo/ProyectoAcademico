//--------------------------------------------------------------------------------
// <copyright file="VisitorWorld.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: VisitorWorld.
    /// DESCRIPCION: .
    /// ExitButton: .
    /// VISITOR: .
    /// SRP: .
    /// COLABORACIONES: .
    /// </summary>
    public class VisitorWorld : Visitor
    {
        /// <summary>
        /// metodo para acceder al world.
        /// </summary>
        /// <param name="world"> objeto world al que accede. </param>
        public override void Visit(World world)
        {
            if (world.ListLevel.Count >= 1)
            {
                this.LastLevel = world.ListLevel[world.ListLevel.Count - 1];
                this.LastLevel.Accept(this);
            }
        }

        /// <summary>
        /// metodo para acceder al level.
        /// </summary>
        /// <param name="level"> objeto level al que se accede. </param>
        public override void Visit(Level level)
        {
            if (level.ListaScreen.Count >= 1)
            {
                this.LastScreen = level.ListaScreen[level.ListaScreen.Count - 1];
                this.LastScreen.Accept(this);
            }
        }

        /// <summary>
        /// metodo para acceder a la screen.
        /// </summary>
        /// <param name="screen"> objeto Screen a la que se accede. </param>
        public override void Visit(Screen screen)
        {
            if (screen.ListaElement.Count >= 1)
            {
                this.LastElement = screen.ListaElement[screen.ListaElement.Count - 1];
            }

            if (screen.ListaElement.Count >= 2)
            {
                this.BeforeLastElement = screen.ListaElement[screen.ListaElement.Count - 2];
            }
        }
    }
}