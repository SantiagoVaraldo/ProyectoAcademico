using Library;
using ExerciseOne;

namespace Library
{
    public class PipeNull : IPipe
    {
        Tag Tag;

        /// <summary>
        ///  Recibe un tag, lo guarda en una variable Tag y la retorna.
        /// </summary>
        /// <param name="tag">Tag a recibir</param>
        /// <returns>La misma imagen</returns>
        public Tag Send(Tag tag)
        {
            this.Tag = tag;
            return Tag;
        }

    }
}
