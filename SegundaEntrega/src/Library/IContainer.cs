//--------------------------------------------------------------------------------
// <copyright file="IContainer.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using ExerciseOne;
using Attribute = ExerciseOne.Attribute;

namespace Library
{
    /// <summary>
    /// esta interfaz es de tipo IXML, contiene la firma Add la cual hace que todas las clases que implementan esta
    /// interfaz, deban tener un metodo Add.
    /// </summary>
    public interface IContainer : IXML
    {
        /// <summary>
        /// añade un elemento a una lista.
        /// </summary>
        /// <param name="ixml"> elemento a agregar. </param>
        void Add(IXML ixml);
    }
}