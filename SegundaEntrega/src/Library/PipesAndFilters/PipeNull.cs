//--------------------------------------------------------------------------------
// <copyright file="PipeNull.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using ExerciseOne;
using Library;

namespace Library
{
    /// <summary>
    /// Pipe al que se envia el Tag en caso de que sea filtrado con Exito, es de tipo IPipe.
    /// No es necesario tener un PipeNull pero decidimos seguir la estructura de Pipes que hemos venido haciendo.
    /// </summary>
    public class PipeNull : IPipe
    {
        private Tag tag;

        /// <summary>
        ///  Recibe un tag, lo guarda en una variable Tag y la retorna.
        /// </summary>
        /// <param name="tag">Tag a recibir.</param>
        /// <returns>el mismo Tag.</returns>
        public Visitor Send(Tag tag)
        {
            this.tag = tag;
            return null;
        }
    }
}
