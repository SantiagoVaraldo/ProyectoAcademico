using ExerciseOne;

namespace Library

{
    /// <summary>
    /// Una caneria a traves de la cual pasa un Tag.
    /// </summary>
    public interface IPipe
    {        
        /// <summary>
        /// Envia el tag a traves de la caneria.
        /// </summary>
        /// <param name="tag">el tag a enviar</param>
        Tag Send(Tag tag); // cambiar por object

    }
}