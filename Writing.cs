using System;
using System.IO;
using System.Net;
using System.Collections;

namespace ExerciseOne 
{
         public class Writing
         { 
             public Writing(TextWriter archivo)
             {
                 this.Archivo = archivo;
             }

            public TextWriter Archivo { get;set;}
            ArrayList lista_etiquetas = new ArrayList();

            // la variable content es el codigo HTML, lo pueden ver en el programa principal
            // esto crea un archivo de texto con ese codigo para despues poder recorrerlo 
            public void AgregarContenido(string content)
                {
                    this.lista_etiquetas.Add(content);
                }
            public void escribir()
                {
                    Archivo = new StreamWriter("archivo.txt");
                    foreach(string item in this.lista_etiquetas)
                    {
                        Archivo.WriteLine(item + "/n");   
                    }
                          
                    Archivo.Close();
                }
         }
        
}

