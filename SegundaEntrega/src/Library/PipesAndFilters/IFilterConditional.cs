using System;
using ExerciseOne;

namespace Library
{
    /// <summary>
    /// Un filtro con condicion.
    /// </summary>
    /// <remarks>
    /// Un filtro procesa un tag, creando un objeto en caso que corresponda.
    /// </remarks>
    public interface IFilterConditional
    {
        /// <summary>
        /// Procesa el tag pasado por parametro y crea un objeto en caso correcto
        /// </summary>
        /// <param name="tag">El tag a procesar</param>
        /// <returns>El mismo tag</returns>
        Tag Filter(Tag tag);
        bool Result {get;}
    }
}