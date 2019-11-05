//--------------------------------------------------------------------------------
// <copyright file="CreatorHelper.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ExerciseOne;

namespace Library
{
    /// <summary>
    /// NOMBRE: CreatorHelper
    /// DESCRIPCION: Esta clase llama a los metodos de la clase Finder y Download de la primera entrega.
    /// </summary>
    public class CreatorHelper
    {
        private string fileName;
        private List<Tag> listtags = new List<Tag>();

        public CreatorHelper(string fileName)
        {
            this.FileName = fileName;
        }

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

        public List<Tag> Listtags
        {
            get
            {
                return this.listtags;
            }
        }

        /// <summary>
        /// llama a los metodos de la clase Download.
        /// </summary>
        /// <param name="fileName"> path del archivo xml. </param>
        /// <returns> un string. </returns>
        public static string GetContent(string fileName)
        {
            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
            UriBuilder builder = new UriBuilder("file", string.Empty, 0, path);
            String uri = builder.Uri.ToString();

            // Creamos un nuevo descargador pasándole una ubicación.
            Downloader downloader = new Downloader(uri);

            // Pedimos al descargador que descargue el contenido
            string content;

            // Carga el contenido del archivo en la variable content
            content = downloader.Download();

            return content;
        }

        /// <summary>
        /// llama a los metodos de la clase Finder.
        /// </summary>
        /// <returns> devuelve una lista de Tags. </returns>
        public List<Tag> GetListTags()
        {
            string content = GetContent(this.fileName);

            // Busca las tags y sus correspondientes atributos
            Finder finder = new Finder();
            this.listtags = finder.Find(content);
            return this.listtags;
        }
    }
}