using System;
using Proyecto.Common;
using Library;

/// <summary>
/// NOMBRE: Builder.
/// 
/// DESCRIPCION: .
/// 
/// PATRON EXPERT: .
/// 
/// SRP: .
/// 
/// COLABORACIONES: Colabora con la clase World y es de tipo IBuilder ya que debe conocer un objeto de tipo World.
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
                            Render.renderImage((Image)element, adapter);
                        }
                        else if (element is Button)
                        {
                            Button button = (Button) element;
                            //Render.renderButton((Button)element, adapter);
                            string buttonId = adapter.CreateButton(button.PositionX, button.PositionY, (int)button.Width, (int)button.Length, "#BC2FA864", this.GoToNextPage);
                            adapter.SetImage(buttonId, button.ImagePath);
                        }

                    }
                }
            }



            /*
            imageId = this.adapter.CreateImage(-(1024 / 2 - 100 / 2), -(768 / 2 - 100 / 2), 100, 100);
            try
            {
                this.adapter.SetImage(imageId, "Martillo.jpg");
            }
            catch (Exception ex)
            {
                this.adapter.Debug(ex.Message);
            }
            imageId = this.adapter.CreateImage(1024 / 2 - 100 / 2, 768 / 2 - 100 / 2, 100, 100);
            this.adapter.SetImage(imageId, "Martillo.jpg");

            string sourceCellImageId = this.adapter.CreateDragAndDropSource(50, 180, 100, 200);
            this.adapter.SetImage(sourceCellImageId, "Martillo.jpg");

            string destinationCellImageId = this.adapter.CreateDragAndDropDestination(250, 180, 200, 100);
            this.adapter.SetImage(destinationCellImageId, "Martillo.jpg");

            string itemId = this.adapter.CreateDragAndDropItem(0, 0, 100, 100);
            this.adapter.SetImage(itemId, "Martillo.jpg");
            this.adapter.AddItemToDragAndDropSource(sourceCellImageId, itemId);

            imageId = this.adapter.CreateImage(40, 100, 100, 100);
            this.adapter.SetImage(imageId, "Martillo.jpg");

            string buttonId = this.adapter.CreateButton(150, 100, 100, 100, "#09FF0064", this.GoToNextPage);
            this.adapter.SetImage(buttonId, "Martillo.jpg");

            this.nextPageName = this.adapter.AddPage();
            this.adapter.ChangeLayout(Layout.Grid);

            buttonId = this.adapter.CreateButton(100, 100, 100, 100, "#BC2FA864", this.GoToFirstPage);
            this.adapter.SetImage(buttonId, "Arco.jpg");
            imageId = this.adapter.CreateImage(40, 100, 100, 100);
            this.adapter.SetImage(imageId, "Martillo.jpg");
        }
        */
        }
        public void AfterBuildShowFirstPage()
        {
            this.adapter.ShowPage(this.firstPageName);
        }

        private void GoToFirstPage()
        {
            this.adapter.ShowPage(this.firstPageName);
            this.adapter.PlayAudio("Speech On.wav");
        }

        private void GoToNextPage()
        {
            this.adapter.ShowPage(this.nextPageName);
            this.adapter.PlayAudio("Speech Off.wav");
        }

        private void OnClick()
        {
            this.adapter.Debug($"Button clicked!");
            this.adapter.ShowPage("MainPage");
        }
    }
}
