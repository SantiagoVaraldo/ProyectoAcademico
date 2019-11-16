//--------------------------------------------------------------------------------
// <copyright file="Renderer.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: Renderer.
    /// DESCRIPCION: Contiene un metodo de renderizacion para cada uno de nuestros elementos que vamos a usar en Unity.
    /// COLABORACIONES: Esta clase colabora con IMainViewAdapter ya que conoce un adapter, colabora con todo el modelo
    /// de nuestro juego, es una especie de intermediario entre nuestro modelo y Unity.
    /// DIP: implementa la interfaz IRenderer para cumplir el patron de inversion de dependencias.
    /// </summary>
    public class Renderer : IRenderer
    {
        private IMainViewAdapter adapter;

        /// <summary>
        /// constructor de la clase.
        /// </summary>
        public Renderer()
        {
            this.adapter = OneAdapter.Adapter;
        }

        /// <summary>
        /// metodo que dibuja un BlankSpace en Unity.
        /// </summary>
        /// <param name="blankSpace"> BlankSpace a dibujar. </param>
        public void RenderBlankSpace(BlankSpace blankSpace)
        {
            blankSpace.DestinationCellImageId = this.adapter.CreateImage((int)blankSpace.PositionX, (int)blankSpace.PositionY, (int)blankSpace.Width, (int)blankSpace.Length);
            this.adapter.SetImage(blankSpace.DestinationCellImageId, blankSpace.ImagePath);
        }

        /// <summary>
        /// metodo que dibuja un ButtonCheck en Unity.
        /// </summary>
        /// <param name="buttonCheck"> ButtonCheck a dibujar. </param>
        public void RenderButtonCheck(ButtonCheck buttonCheck)
        {
            buttonCheck.ButtonId = this.adapter.CreateButton((int)buttonCheck.PositionX, (int)buttonCheck.PositionY, (int)buttonCheck.Width, (int)buttonCheck.Length, "#FFFFFFFF", buttonCheck.Action);
            this.adapter.SetImage(buttonCheck.ButtonId, buttonCheck.ImagePath);
            this.adapter.SetText(buttonCheck.ButtonId, string.Empty);
        }

        /// <summary>
        /// metodo que dibuja un ButtonNextPage en Unity.
        /// </summary>
        /// <param name="buttonNextPage"> ButtonNextPage a dibujar. </param>
        public void RenderButtonNextPage(ButtonNextPage buttonNextPage)
        {
            buttonNextPage.ButtonId = this.adapter.CreateButton((int)buttonNextPage.PositionX, (int)buttonNextPage.PositionY, (int)buttonNextPage.Width, (int)buttonNextPage.Length, "#FFFFFFFF", buttonNextPage.Action);
            this.adapter.SetImage(buttonNextPage.ButtonId, buttonNextPage.ImagePath);
            this.adapter.SetText(buttonNextPage.ButtonId, buttonNextPage.Text);
        }

        /// <summary>
        /// metodo que dibuja un ButtonSound en Unity.
        /// </summary>
        /// <param name="buttonSound"> ButtonSound a dibujar. </param>
        public void RenderButtonSound(ButtonSound buttonSound)
        {
            buttonSound.ButtonId = this.adapter.CreateButton((int)buttonSound.PositionX, (int)buttonSound.PositionY, (int)buttonSound.Width, (int)buttonSound.Length, "#FFFFFFFF", buttonSound.Action);
            this.adapter.SetImage(buttonSound.ButtonId, buttonSound.ImagePath);
            this.adapter.SetText(buttonSound.ButtonId, string.Empty);
        }

        /// <summary>
        /// metodo que dibuja un DragAndDropSource en Unity.
        /// </summary>
        /// <param name="dragAndDropSource"> DragAndDropSource a dibujar. </param>
        public void RenderDragAndDropSource(DragAndDropSource dragAndDropSource)
        {
            dragAndDropSource.SourceCellImageId = this.adapter.CreateImage((int)dragAndDropSource.PositionX, (int)dragAndDropSource.PositionY, (int)dragAndDropSource.Width, (int)dragAndDropSource.Length);
            this.adapter.SetImage(dragAndDropSource.SourceCellImageId, dragAndDropSource.ImagePath);
        }

        /// <summary>
        /// metodo que dibuja un ExitButton en Unity.
        /// </summary>
        /// <param name="exitButton"> ExitButton a dibujar. </param>
        public void RenderExitButton(ExitButton exitButton)
        {
            string buttonId = this.adapter.CreateButton((int)exitButton.PositionX, (int)exitButton.PositionY, (int)exitButton.Width, (int)exitButton.Length, "#BC2FA864", exitButton.Action);
            this.adapter.SetImage(buttonId, exitButton.ImagePath);
        }

        /// <summary>
        /// metodo que dibuja una Image en Unity.
        /// </summary>
        /// <param name="image"> Image a dibujar. </param>
        public void RenderImage(Image image)
        {
            string imageId = this.adapter.CreateImage((int)image.PositionX, (int)image.PositionY, (int)image.Width, (int)image.Length);
            this.adapter.SetImage(imageId, image.ImagePath);
        }

        /// <summary>
        /// metodo que dibuja una Letter en Unity.
        /// </summary>
        /// <param name="letter"> Letter a dibujar. </param>
        public void RenderLetter(Letter letter)
        {
            letter.ButtonId = this.adapter.CreateButton((int)letter.PositionX, (int)letter.PositionY, (int)letter.Width, (int)letter.Length, "#FFFFFFFF", letter.Action);
            this.adapter.SetImage(letter.ButtonId, letter.ImagePath);
            this.adapter.SetText(letter.ButtonId, string.Empty);
        }

        /// <summary>
        /// metodo que dibuja una Word en Unity.
        /// </summary>
        /// <param name="word"> Word a dibujar. </param>
        public void RenderWord(Word word)
        {
            word.ItemId = this.adapter.CreateImage((int)word.PositionX, (int)word.PositionY, (int)word.Width, (int)word.Length);
            this.adapter.SetImage(word.ItemId, word.ImagePath);
            this.adapter.MakeDraggable(word.ItemId, true);
            OneAdapter.Adapter.OnDrop += word.OnDrop;
            OneAdapter.Adapter.Center(word.ItemId, word.Source.SourceCellImageId);
        }
    }
}