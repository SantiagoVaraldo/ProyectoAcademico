using System;
using System.IO;
using System.Net;
using System.Collections;

namespace ExerciseOne 
{
         public class Etiquetas
         {
                  TextReader archivo1;
                  ArrayList lista_etiquetas = new ArrayList();
                  // la idea es recorrer ese archivo de texto creado en la otra clase y agregar a la lista todas las etiquetas
                  public void leer_archivos()
                  {
                           archivo1 = new StreamReader("archivo.txt");
                           archivo1.Close();
                  }
         }
}
