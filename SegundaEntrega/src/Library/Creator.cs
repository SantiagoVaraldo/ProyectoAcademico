using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using ExerciseOne;

namespace Library
{
         public class Creator
         {
                  public static World world;
                  public void Create()
                  {
                           //variable constante con el nombre del archivo
                           const String fileName = @"test.xml";
                           /// <summary>
                           /// Punto de entrada
                           /// </summary>
                           String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
                           UriBuilder builder = new UriBuilder("file", "", 0, path);
                           String uri = builder.Uri.ToString();
                           // Creamos un nuevo descargador pasándole una ubicación.
                           Downloader downloader = new Downloader(uri);
                           // Pedimos al descargador que descargue el contenido
                           string content;
                           //Carga el contenido del archivo en la variable content
                           content = downloader.Download();

                           //Busca las tags y sus correspondientes atributos
                           Finder finder = new Finder();
                           List<Tag> listtags = finder.Find(content);
                           // creamos un pipeNull
                           IPipe pipenull = new PipeNull();

                           // creamos instancias de todos los filtros que nos interecen
                           IFilterConditional filterworld = new FilterWorld();
                           IFilterConditional filterlevel = new FilterLevel();
                           IFilterConditional filterscreen = new FilteScreen();
                           IFilterConditional filterbutton = new FilterButton();
                           IFilterConditional filterimage = new FilterImage();

                           // creamos instancias de todos los pipeSerial que vayamos a utilizar
                           //IPipe pipeserial7 = new PipeSerial(filtertwitter,pipenull);

                           IPipe pipe4 = new PipeConditional(filterimage, pipenull, pipenull);
                           IPipe pipe3 = new PipeConditional(filterbutton, pipenull, pipe4);
                           IPipe pipe2 = new PipeConditional(filterscreen, pipenull, pipe3);
                           IPipe pipe1 = new PipeConditional(filterlevel, pipenull, pipe2);
                           IPipe pipe0 = new PipeConditional(filterworld, pipenull, pipe1);

                           foreach (Tag tag in listtags)
                           {
                                    pipe0.Send(tag);
                           }
                           // enviamos la imagen al primer pipeSerial
                  }
         }
}