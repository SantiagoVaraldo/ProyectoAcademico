using System;
using System.Collections.Generic;

/*----------------------------------------------------------------------------------------------------------------------------
NOMBRE: IPrinter.
DESCRIPCION: 
PATRON EXPERT: 
SRP: 
COLABORACIONES: 
------------------------------------------------------------------------------------------------------------------------------
 */

namespace ExerciseOne
{
    public interface IPrinter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lista">recibe un elemento de tipo ArrayList para ser recorrido</param>
        void Print(List<string> lista);
    }
}