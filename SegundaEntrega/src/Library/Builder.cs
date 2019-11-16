//--------------------------------------------------------------------------------
// <copyright file="Builder.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Library;
using Proyecto.Common;

namespace Proyecto.StudentsCode
{
    /// <summary>
    /// NOMBRE: Builder.
    /// DESCRIPCION: contiene un IMainvieadapter, contiene un metodo build que crea el mundo en unity a partir del World.
    /// POLIMORFISMO: cuando se recorre la lista de niveles del World, se hace element.Render(renderer), en este momento se hace
    /// uso del polimorfismo ya que no se sabe cual es el tipo de elemento, simplemente se renderiza el elemento de la
    /// forma que corresponda sin preguntar por el tipo del elemento.
    /// COLABORACIONES: Colabora con la clase World y la interfaz IMainviewadapter y es de tipo IBuilder ya que debe conocer un objeto de tipo World.
    /// </summary>
    public class Builder : IBuilder
    {
        private IMainViewAdapter adapter;

        private string nextPageName;

        /// <summary>
        /// metodo que crea el mundo en Unity.
        /// </summary>
        /// <param name="providedAdapter"> recibe un IMainViewAdapter para crear el mundo. </param>
        public void Build(IMainViewAdapter providedAdapter)
        {
            this.adapter = providedAdapter ?? throw new ArgumentNullException(nameof(providedAdapter));

            OneAdapter.Adapter = this.adapter;

            this.adapter.AfterBuild += this.AfterBuildShowFirstPage;

            Creator creator = new Creator();
            try
            {
                creator.Create();
            }
            catch (NotFoundOnXMLException e)
            {
                this.adapter.Debug(e.Message);
            }

            World world = Singleton<World>.Instance;

            foreach (Level level in world.ListLevel)
            {
                Creator.UnityPages.Add(level.Name, new List<string>());
                foreach (Screen screen in level.ScreenList)
                {
                    this.nextPageName = this.adapter.AddPage();
                    Creator.UnityPages[level.Name].Add(this.nextPageName);
                    this.adapter.ChangeLayout(Layout.ContentSizeFitter);

                    foreach (Element element in screen.ElementList)
                    {
                        IRenderer renderer = new Renderer();
                        element.Render(renderer);
                    }
                }
            }
        }

        /// <summary>
        /// muestra la primera pagina luego de que se cree.
        /// </summary>
        public void AfterBuildShowFirstPage()
        {
            this.adapter.ShowPage(Creator.UnityPages["Menu"][0]);
        }
    }
}
