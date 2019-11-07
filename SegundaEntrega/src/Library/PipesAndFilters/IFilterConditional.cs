//--------------------------------------------------------------------------------
// <copyright file="IFilterConditional.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ExerciseOne;

namespace Library
{
    /// <summary>
    /// Un filtro con condicion.
    /// </summary>
    /// <remarks>
    /// Un filtro procesa un Tag, creando un objeto en caso que corresponda.
    /// </remarks>
    public interface IFilterConditional
    {
        bool Result { get; }

        /// <summary>
        /// Procesa el Tag pasado por parametro y crea un objeto en caso correcto.
        /// </summary>
        /// <param name="tag">El Tag a procesar.</param>
        /// <returns>El mismo Tag.</returns>
        Visitor Filter(Tag tag);
    }
}