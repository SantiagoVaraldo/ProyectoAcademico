//--------------------------------------------------------------------------------
// <copyright file="IRenderer.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: IRenderer.
    /// DIP: esta interfaz fue creada para aplicar el patron de inversion de dependencias, el proposito es hacer
    /// que nuestro modelo no dependa de Renderer ya que Renderer depende del adapter, para esto hacemos
    /// que nuestro modelo dependa de esta interfaz IRenderer, y que la clase Renderer la implemente.
    /// </summary>
    public interface IRenderer
    {
        /// <summary>
        /// dibuja un BlankSpace.
        /// </summary>
        /// <param name="blankSpace"> BlankSpace dibujado. </param>
        void RenderBlankSpace(BlankSpace blankSpace);

        /// <summary>
        /// dibuja un ButtonCheck.
        /// </summary>
        /// <param name="buttonCheck"> ButtonCheck dibujado. </param>
        void RenderButtonCheck(ButtonCheck buttonCheck);

        /// <summary>
        /// dibuja un ButtonNextPage.
        /// </summary>
        /// <param name="buttonNextPage"> ButtonNextPage dibujado. </param>
        void RenderButtonNextPage(ButtonNextPage buttonNextPage);

        /// <summary>
        /// dibuja un ButtonSound.
        /// </summary>
        /// <param name="buttonSound"> ButtonSound dibujado. </param>
        void RenderButtonSound(ButtonSound buttonSound);

        /// <summary>
        /// dibuja un DragAndDropSource.
        /// </summary>
        /// <param name="dragAndDropSource"> DragAndDropSource dibujado. </param>
        void RenderDragAndDropSource(DragAndDropSource dragAndDropSource);

        /// <summary>
        /// dibuja un ExitButton.
        /// </summary>
        /// <param name="exitButton"> ExitButton dibujado. </param>
        void RenderExitButton(ExitButton exitButton);

        /// <summary>
        /// dibuja una imagen.
        /// </summary>
        /// <param name="image"> Image dibujada. </param>
        void RenderImage(Image image);

        /// <summary>
        /// dibuja una Letter.
        /// </summary>
        /// <param name="letter"> Letter dibujada. </param>
        void RenderLetter(Letter letter);

        /// <summary>
        /// dibuja un Word.
        /// </summary>
        /// <param name="word"> Word dibujado. </param>
        void RenderWord(Word word);
    }
}