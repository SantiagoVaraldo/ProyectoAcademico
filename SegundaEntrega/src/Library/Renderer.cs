using System;
using Proyecto.Common;

namespace Library
{
    public class Renderer
    {
        private IMainViewAdapter adapter;
        public Renderer()
        {
            this.adapter = OneAdapter.Adapter;
        }
        public void RenderBlankSpace(BlankSpace blankSpace)
        {
            blankSpace.DestinationCellImageId = adapter.CreateImage((int)blankSpace.PositionX, (int)blankSpace.PositionY, (int)blankSpace.Width, (int)blankSpace.Length);
            adapter.SetImage(blankSpace.DestinationCellImageId, blankSpace.ImagePath);
        }

        public void RenderButtonCheck(ButtonCheck buttonCheck)
        {
            string buttonId = adapter.CreateButton((int)buttonCheck.PositionX, (int)buttonCheck.PositionY, (int)buttonCheck.Width, (int)buttonCheck.Length, "#FFFFFFFF", buttonCheck.Action);
            adapter.SetImage(buttonId, buttonCheck.ImagePath);
        }

        public void RenderButtonNextPage(ButtonNextPage buttonNextPage)
        {
            string buttonId = adapter.CreateButton((int)buttonNextPage.PositionX, (int)buttonNextPage.PositionY, (int)buttonNextPage.Width, (int)buttonNextPage.Length, "#FFFFFFFF", buttonNextPage.Action);
            adapter.SetImage(buttonId, buttonNextPage.ImagePath);
        }

        public void RenderButtonSound(ButtonSound buttonSound)
        {
            string buttonId = adapter.CreateButton((int)buttonSound.PositionX, (int)buttonSound.PositionY, (int)buttonSound.Width, (int)buttonSound.Length, "#FFFFFFFF", buttonSound.Action);
            adapter.SetImage(buttonId, buttonSound.ImagePath);
        }

        public void RenderDragAndDropSource(DragAndDropSource dragAndDropSource)
        {
            dragAndDropSource.SourceCellImageId = adapter.CreateImage((int)dragAndDropSource.PositionX, (int)dragAndDropSource.PositionY, (int)dragAndDropSource.Width, (int)dragAndDropSource.Length);
            adapter.SetImage(dragAndDropSource.SourceCellImageId, dragAndDropSource.ImagePath);
        }

        public void RenderExitButton(ExitButton exitButton)
        {
            string buttonId = adapter.CreateButton((int)exitButton.PositionX, (int)exitButton.PositionY, (int)exitButton.Width, (int)exitButton.Length, "#BC2FA864", exitButton.Action);
            adapter.SetImage(buttonId, exitButton.ImagePath);
        }

        public void RenderImage(Image image)
        {
            string imageId = adapter.CreateImage((int)image.PositionX, (int)image.PositionY, (int)image.Width, (int)image.Length);
            adapter.SetImage(imageId, image.ImagePath);
        }

        public void RenderLetter(Letter letter)
        {
            string buttonId = adapter.CreateButton((int)letter.PositionX, (int)letter.PositionY, (int)letter.Width, (int)letter.Length, "#FFFFFFFF", letter.Action);
            adapter.SetImage(buttonId, letter.ImagePath);
        }

        public void RenderWord(Word word)
        {
            word.ItemId = adapter.CreateImage((int)word.PositionX, (int)word.PositionY, (int)word.Width, (int)word.Length);
            adapter.SetImage(word.ItemId, word.ImagePath);
            adapter.MakeDraggable(word.ItemId, true);
            OneAdapter.Adapter.OnDrop += word.OnDrop;
            OneAdapter.Adapter.Center(word.ItemId, word.Source.SourceCellImageId);
        }
    }
}