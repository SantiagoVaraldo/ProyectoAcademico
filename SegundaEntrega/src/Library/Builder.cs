using System;
using Proyecto.Common;
using Library;
using System.Collections.Generic;

/// <summary>
/// NOMBRE: Builder.
/// 
/// DESCRIPCION: contiene un IMainvieadapter, contiene un metodo build que crea el mundo en unity a partir del World
/// utilizando los metodos del IMainviewadapter.
/// 
/// POLIMORFISMO: en un principio intentamos hacer uso de polimorfismo añadiendo un metodo Render a la clase Element para
/// posteriormente al recorrer la lista de elementos, se llamara al metodo Render sin especificarle que tipo de elemento
/// fuera.
///  
/// COLABORACIONES: Colabora con la clase World y la interfaz IMainviewadapter y es de tipo IBuilder ya que debe conocer un objeto de tipo World.
/// 
/// COMENTARIO: intentamos aplicar el Patron Visitor en builder pero no fuimos capaces de lograrlo exitosamente.
/// </summary>
namespace Proyecto.StudentsCode
{
    public class Builder : IBuilder
    {
        private IMainViewAdapter adapter;
        private string firstPageName;

        private string nextPageName;

        public void Build(IMainViewAdapter providedAdapter)
        {

            this.adapter = providedAdapter ?? throw new ArgumentNullException(nameof(providedAdapter));

            this.adapter.ToDoAfterBuild(this.AfterBuildShowFirstPage);

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

        private void GoToNextPage()
        {
            this.adapter.ShowPage(this.nextPageName);
            //this.adapter.PlayAudio("Speech Off.wav");
        }

        private void OnClick()
        {
            this.adapter.Debug($"Button clicked!");
            //this.adapter.ShowPage("MainPage");
        }
    }
}
