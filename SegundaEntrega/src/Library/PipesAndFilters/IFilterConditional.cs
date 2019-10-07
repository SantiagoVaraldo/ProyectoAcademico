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
        /// <summary>
        /// Procesa el Tag pasado por parametro y crea un objeto en caso correcto
        /// </summary>
        /// <param name="tag">El Tag a procesar</param>
        /// <returns>El mismo Tag</returns>
        Tag Filter(Tag tag);
        bool Result {get;}
    }
}