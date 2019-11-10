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
    /// POLIMORFISMO: cuando se recorre la lista de niveles del World, se hace element.Render(), en este momento se hace
    /// uso del polimorfismo ya que no se sabe cual es el tipo de elemento, simplemente se renderiza el elemento de la
    /// forma que corresponda sin preguntar por el tipo del elemento.
    /// COLABORACIONES: Colabora con la clase World y la interfaz IMainviewadapter y es de tipo IBuilder ya que debe conocer un objeto de tipo World.
    /// </summary>
    public class Builder : IBuilder
    {
        private IMainViewAdapter adapter;
        private string firstPageName;

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

            this.firstPageName = this.adapter.AddPage();
            Creator.ListPages.Add(this.firstPageName);

            this.adapter.ChangeLayout(Layout.ContentSizeFitter);
            string buttonid = this.adapter.CreateButton(150, 100, 100, 100, "#09FF0064", this.GoToNextPage);

            Creator creator = new Creator();
            creator.Create();
            World world = Singleton<World>.Instance;

            foreach (Level level in world.ListLevel)
            {
                foreach (Screen screen in level.ScreenList)
                {
                    this.nextPageName = this.adapter.AddPage();
                    Creator.ListPages.Add(this.nextPageName);
                    this.adapter.ChangeLayout(Layout.ContentSizeFitter);

                    foreach (Element element in screen.ElementList)
                    {
                        Renderer renderer = new Renderer();
                        element.Render(renderer);
                    }
                }
            }
        }

        public void AfterBuildShowFirstPage()
        {
            this.adapter.ShowPage(this.firstPageName);
        }

        public void AfterBuildShowPage(string page)
        {
            this.adapter.ShowPage(page);
        }

        private void GoToFirstPage()
        {
            this.adapter.ShowPage(this.firstPageName);

            // this.adapter.PlayAudio("Speech On.wav");
        }

        private void GoToNextPage(string name)
        {
            this.adapter.ShowPage(Creator.ListPages[1]);

            // cambiar a Creator.ListPages
        }

        private void OnClick()
        {
            this.adapter.Debug($"Button clicked!");

            // this.adapter.ShowPage("MainPage");
        }
    }
}
