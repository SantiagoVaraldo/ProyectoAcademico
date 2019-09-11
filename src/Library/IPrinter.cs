using System;
using System.Collections.Generic;

namespace ExerciseOne
{
         /// <summary>
         /// NOMBRE: IPrinter.
         /// DESCRIPCION: interface Iprinter con la firma Print
         /// PATRON EXPERT:
         /// SRP:
         /// COLABORACIONES: 
         /// </summary>
         public interface IPrinter
         {
                  /// <summary>
                  /// metodo Print utilizado en la clase Printer para imprimir en consola una lista de elementos formateada
                  /// </summary>
                  /// <param name="lista">recibe un elemento de tipo List<string> para ser recorrido</param>
                  void Print(List<string> lista);
         }
}