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
    /// Pipe al que se envia el Tag en caso de que sea filtrado con ExitButtono, es de tipo IPipe.
    /// No es necesario tener un PipeNull pero decidimos deguir la estructura de Pipes que hemos visto.
    /// </summary>
    public class PipeNull : IPipe
    {
        private Tag tag;

        /// <summary>
        ///  Recibe un tag, lo guarda en una variable Tag y la retorna.
        /// </summary>
        /// <param name="tag">Tag a recibir.</param>
        /// <returns>el mismo Tag.</returns>
        public Tag Send(Tag tag)
        {
            this.tag = tag;
            return tag;
        }
    }
}
