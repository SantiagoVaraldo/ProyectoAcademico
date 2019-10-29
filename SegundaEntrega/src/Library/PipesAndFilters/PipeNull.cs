using Library;
using ExerciseOne;

/// <summary>
/// Pipe al que se envia el Tag en caso de que sea filtrado con exito, es de tipo IPipe.
/// No es necesario tener un PipeNull pero decidimos deguir la estructura de Pipes que hemos visto.
/// </summary>

namespace Library
{
    public class PipeNull : IPipe
    {
        Tag Tag;

        /// <summary>
        ///  Recibe un tag, lo guarda en una variable Tag y la retorna.
        /// </summary>
        /// <param name="tag">Tag a recibir</param>
        /// <returns>el mismo Tag</returns>
        public Tag Send(Tag tag)
        {
            this.Tag = tag;
            return Tag;
        }
    }
}
