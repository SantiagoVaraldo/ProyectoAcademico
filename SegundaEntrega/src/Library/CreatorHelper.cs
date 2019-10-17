using System.Collections.Generic;
using System;
using System.IO;
using System.Reflection;
using ExerciseOne;

/// <summary>
/// NOMBRE: CreatorHelper
/// 
/// DESCRIPCION: Esta clase llama a los metodos de la clase Finder y Download de la primera entrega.
/// </summary>

namespace Library
{
    public class CreatorHelper
    {
        public CreatorHelper(String FileName)
        {
            this.FileName = FileName;
        }
        private string fileName;
        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }
        List<Tag> listtags = new List<Tag>();

        /// <summary>
        /// llama a los metodos de la clase Finder
        /// </summary>
        /// <returns>devuelve una lista de Tags</returns>
        public List<Tag> GetListTags()
        {
            string content = getContent(this.fileName);

            //Busca las tags y sus correspondientes atributos
            Finder finder = new Finder();
            this.listtags = finder.Find(content);
            return this.listtags;
        }

        /// <summary>
        /// llama a los metodos de la clase Download
        /// </summary>
        /// <param name="fileName">path del archivo xml</param>
        /// <returns>un string</returns>
        public string getContent(string fileName)
        {
            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
            UriBuilder builder = new UriBuilder("file", "", 0, path);
            String uri = builder.Uri.ToString();
            // Creamos un nuevo descargador pasándole una ubicación.
            Downloader downloader = new Downloader(uri);
            // Pedimos al descargador que descargue el contenido
            string content;
            //Carga el contenido del archivo en la variable content
            content = downloader.Download();

            return content;
        }
    }
}