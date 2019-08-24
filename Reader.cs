using System;
using System.IO;
using System.Net;
using System.Collections;

namespace ExerciseOne 
{
         public class Reader
         {
             public Reader(TextReader archivoLeer)
             {
                 this.ArchivoLeer = archivoLeer;
             }
             public TextReader ArchivoLeer { get;set;}
                  
            // la idea es recorrer ese archivo de texto creado en la otra clase y agregar a la lista todas las etiquetas
        
                  public void leer_archivos()
                  {
                           ArchivoLeer = new StreamReader("archivo.txt");
                           Console.WriteLine(ArchivoLeer.ReadToEnd());
                           ArchivoLeer.Close();
                           
                  }
                  


         }
}
