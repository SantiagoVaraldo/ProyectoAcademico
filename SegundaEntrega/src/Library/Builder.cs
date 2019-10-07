using System;
using Proyecto.Common;
using Library;

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

            string imageId;

            this.adapter = providedAdapter ?? throw new ArgumentNullException(nameof(providedAdapter));

            this.adapter.ToDoAfterBuild(this.AfterBuildShowFirstPage);

            this.firstPageName = this.adapter.AddPage();

            this.adapter.ChangeLayout(Layout.ContentSizeFitter);

            Creator creator = new Creator();
            creator.Create();
            World world = Creator.world;

            foreach (Level level in world.ListaLevel)
            {
                foreach (Screen screen in level.ListaScreen)
                {
                    //screen.Render();

                    foreach (Element element in screen.ListaElement)
                    {
                        if (element is Image)
                        {
                            Image image = (Image)element;
                            imageId = adapter.CreateImage((int)image.PositionX, (int)image.PositionY, (int)image.Width, (int)image.Length);
                            adapter.SetImage(imageId, image.ImagePath);
                        }
                        else if (element is Button)
                        {
                            Button button = (Button)element;
                            //Render.renderButton((Button)element, adapter);
                            string buttonId = adapter.CreateButton((int)button.PositionX, (int)button.PositionY, (int)button.Width, (int)button.Length, "#BC2FA864", this.GoToNextPage);
                            //adapter.SetImage(buttonId, button.ImagePath);
                        }
                    }
                    this.nextPageName = this.adapter.AddPage();
                    this.adapter.ChangeLayout(Layout.Grid);
                }
            }

        }
        public void AfterBuildShowFirstPage()
        {
            this.adapter.ShowPage(this.firstPageName);
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
