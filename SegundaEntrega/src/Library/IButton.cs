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
        void Action(string name);
    }
}