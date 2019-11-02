using System;
using Proyecto.Common;
using Library;
using System.Collections.Generic;

/// <summary>
/// NOMBRE: Builder.
/// DESCRIPCION: contiene un IMainvieadapter, contiene un metodo build que crea el mundo en unity a partir del World.
/// POLIMORFISMO: cuando se recorre la lista de niveles del World, se hace element.Render(), en este momento se hace 
/// uso del polimorfismo ya que no se sabe cual es el tipo de elemento, simplemente se renderiza el elemento de la 
/// forma que corresponda sin preguntar por el tipo del elemento.
/// COLABORACIONES: Colabora con la clase World y la interfaz IMainviewadapter y es de tipo IBuilder ya que debe conocer un objeto de tipo World.
/// </summary>
namespace Proyecto.StudentsCode
{
    public class Builder : IBuilder
    {
        private IMainViewAdapter adapter;
        private string firstPageName;

        private string nextPageName;

        /// <summary>
        /// metodo que crea el mundo en Unity
        /// </summary>
        /// <param name="providedAdapter"> recibe un IMainViewAdapter para crear el mundo </param>

        public void Build(IMainViewAdapter providedAdapter)
        {

            this.adapter = providedAdapter ?? throw new ArgumentNullException(nameof(providedAdapter));

            SingletonAdapter.Adapter = adapter;

            this.adapter.AfterBuild += this.AfterBuildShowFirstPage;

            this.firstPageName = this.adapter.AddPage();

            this.adapter.ChangeLayout(Layout.ContentSizeFitter);
            string buttonid = this.adapter.CreateButton(150, 100, 100, 100, "#09FF0064", this.GoToNextPage);

            Creator creator = new Creator();
            creator.Create();
            World world = Creator.world;

            foreach (Level level in world.ListaLevel)
            {
                foreach (Screen screen in level.ListaScreen)
                {
                    this.nextPageName = this.adapter.AddPage();
                    //Creator.listPages.Add(this.nextPageName);  // agrego esto
                    this.adapter.ChangeLayout(Layout.ContentSizeFitter);
                    //this.AfterBuildShowPage(this.nextPageName);   

                    foreach (Element element in screen.ListaElement)
                    {
                        element.Render(this.adapter);
                    }
                    //this.nextPageName = this.adapter.AddPage();
                    //this.adapter.ChangeLayout(Layout.Grid);
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
            //this.adapter.PlayAudio("Speech On.wav");
        }

        private void GoToNextPage(string name)
        {
            this.adapter.ShowPage(this.nextPageName); // cambiar a Creator.listPages
            //this.adapter.PlayAudio("Speech Off.wav");
        }

        private void OnClick()
        {
            this.adapter.Debug($"Button clicked!");
            //this.adapter.ShowPage("MainPage");
        }
    }
}
