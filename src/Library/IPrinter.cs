using System.Collections.Generic;

namespace ExerciseOne
{
         /// <summary>
         /// NOMBRE: IPrinter.
         /// DESCRIPCION: Interface Iprinter con la firma Print
         /// PATRON POLIMORFISMO: Decidimos usar el patron polimorfismo pensando a futuro, imaginando que podriamos utilizar 
         /// otras maneras de mostrar el resultado de nuestro programa. Utilizando esta interfaz podremos crear otras clases
         /// que implementen dicha interfaz, controlando que tambien tengan un metodo Print().
         /// </summary>
         public interface IPrinter
         {
                  /// <summary>
                  /// El metodo Print() en esta interfaz forzara que todas las clases hijas la tengan en su codigo, 
                  /// permitiendo que puedan printear el contenido de la lista de la manera correspondiente a 
                  /// sus requisitos.
                  /// </summary>
                  /// <param name="lista">Recibe un elemento de tipo List<string> como parametro</param>
                  void Print(List<string> lista);
         }
}