//--------------------------------------------------------------------------------
// <copyright file="IPipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using ExerciseOne;

namespace Library
{
    /// <summary>
    /// DESCRIPCION: una interfaz IPipe con la firma Send para poder crear diferentes tipos de Pipes en caso de que sea necesario.
    /// </summary>
    public interface IPipe
    {
        /// <summary>
        /// Envia el Tag a traves de la caneria.
        /// </summary>
        /// <param name="tag"> enviar el tag a traves de la cañeria. </param>
        /// <returns> el Visitor correspondiente al Tag. </returns>
        Visitor Send(Tag tag);
    }
}