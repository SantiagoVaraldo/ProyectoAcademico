using System.IO;
using System.Net;

namespace ExerciseOne
{
         /// <summary>
         /// NOMBRE: Downloader
         /// 
         /// DESCRIPCION: Descarga archivos locales y los parsea a string, de una direccion con el formato: "file:///drive:/directory/file",
         /// siendo posible modificar la clase para que acepte descargas remotas con este formato de direccion: "http://server/directory/file".
         /// 
         /// PATRON EXPERT: Esta clase conoce una URL, tiene la informacion necesaria para descargar los contenidos
         /// de esa URL.
         /// 
         /// SRP: Su unica responsabilidad es descargar los contenidos de una URL, su unica razon de cambio es modificar
         /// la manera de descargar dichos contenidos.
         /// 
         /// COLABORACIONES: No colabora con ninguna de las clases creadas por nosotros.

         /// </summary>
         public class Downloader
         {
                  private string url;

                  /// <summary>
                  /// La ubicación de la cual descargar
                  /// </summary>
                  public string Url
                  {
                           get { return url; }
                           set { url = value; }
                  }

                  /// <summary>
                  /// Crea una nueva instancia asignando la ubicación de la cual descargar
                  /// </summary>
                  /// <param name="url"></param>
                  public Downloader(string url)
                  {
                           this.url = url;
                  }

                  /// <summary>
                  /// Descarga contenido de la ubicación de la cual descargar
                  /// </summary>
                  /// <returns>Retorna el contenido descargado</returns>
                  public string Download()
                  {
                           // Creamos una nueva solicitud para el recurso especificado por la URL recibida
                           WebRequest request = WebRequest.Create(url);
                           // Asignamos las credenciales predeterminadas por si el servidor las pide
                           request.Credentials = CredentialCache.DefaultCredentials;
                           // Obtenemos la respuesta
                           WebResponse response = request.GetResponse();
                           // Obtenemos la stream con el contenido retornado por el servidor
                           Stream stream = response.GetResponseStream();
                           // Abrimos la stream con un lector para accederla más fácilmente
                           StreamReader reader = new StreamReader(stream);
                           // Leemos el contenido
                           string result = reader.ReadToEnd();
                           // Limpiamos cerrando lo que abrimos
                           reader.Close();
                           stream.Close();
                           response.Close();
                           return result;
                  }
         }
}