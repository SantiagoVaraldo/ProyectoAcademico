//--------------------------------------------------------------------------------
// <copyright file="IButton.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// interfaz IButton con la firma Action(se utiliza para que cada tipo de boton tenga una accion particular).
    /// </summary>
    public interface IButton
    {
        /// <summary>
        /// se ejecuta al hacer click en un boton.
        /// </summary>
        /// <param name="name"></param>
        void Action(string name);
    }
}