using ExerciseOne;

/// <summary>
/// DESCRIPCION: una interfaz IPipe con la firma Send para poder crear diferentes tipos de Pipes en caso de que sea necesario.
/// </summary>  

namespace Library

{
         public interface IPipe
         {
                  /// <summary>
                  /// Envia el Tag a traves de la caneria.
                  /// </summary>
                  /// <param name="tag">el Tag a enviar</param>
                  Tag Send(Tag tag);
         }
}