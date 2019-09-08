using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace ExerciseOne
{
	/// <summary>
	/// Pequeño programa para probar el funcionamiento de la clase Downloader.
	/// </summary>
	public static class Program
	{
		//variable constante con el nombre del archivo
		const String fileName = @"..\..\..\..\Library\test.html";	
		/// <summary>
		/// Punto de entrada
		/// </summary>
		public static void Main()
		{
			String path = Path.Combine( Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
			UriBuilder builder = new UriBuilder("file", "", 0, path);
			String uri = builder.Uri.ToString();
			// Creamos un nuevo descargador pasándole una ubicación.
			Downloader downloader = new Downloader(uri);
			// Pedimos al descargador que descargue el contenido
			string content;
			//Carga el contenido del archivo en la variable content
			content = downloader.Download();

			//Busca las tags y sus correspondientes atributos
			List<Tag> tags = Finder.Find(content);

			//Formatea las tags y sus atributos para mostrarlos de la manera deseada
			List<string> formatedTags = Formater.Format(tags);

			//Muestra en pantalla las tags con sus atributos
			Printer p = new Printer();
			p.Print(formatedTags);
		}
	}
}