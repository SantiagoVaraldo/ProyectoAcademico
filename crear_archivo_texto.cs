using System;
using System.IO;
using System.Net;
using System.Collections;

namespace ExerciseOne 
{
         public class ArchivoTexto
         {
                  TextWriter archivo;
                  // la variable content es el codigo HTML, lo pueden ver en el programa principal
                  // esto crea un archivo de texto con ese codigo para despues poder recorrerlo 
                  public void escribir(string content)
                  {
                           archivo = new StreamWriter("archivo.txt");
                           archivo.WriteLine(content);
                           archivo.Close();
                  }
         }
}

