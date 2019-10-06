using System;
using ExerciseOne;

namespace Library
{
    /// <summary>
    /// Un filtro grafico.
    /// </summary>
    /// <remarks>
    /// Un filtro procesa un tag, creando un objeto en caso que corresponda.
    /// </remarks>
    public interface IFilterConditional
    {
        /// <summary>
        /// Procesa el tag pasado por parametro y devuelve un objeto creado o el mismo tag.
        /// </summary>
        /// <param name="tag">El tag a procesar</param>
        /// <returns>El mismo tag o un objeto creado</returns>
        Tag Filter(Tag tag); // crear un tipo mas generico que contenga todas nuestras clases
        bool Result {get;}
    }
}