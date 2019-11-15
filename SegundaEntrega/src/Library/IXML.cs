//--------------------------------------------------------------------------------
// <copyright file="IXML.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ExerciseOne;

namespace Library
{
    /// <summary>
    /// esta interfaz no implementa ningun metodo, simplemente tiene un atributo Name de tipo string.
    /// </summary>
    public interface IXML
    {
        /// <summary>
        /// nombre.
        /// </summary>
        /// <value>string.</value>
        string Name { get; set; }
    }
}