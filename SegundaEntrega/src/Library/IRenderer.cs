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
        void RenderBlankSpace(BlankSpace blankSpace);

        void RenderButtonCheck(ButtonCheck buttonCheck);

        void RenderButtonNextPage(ButtonNextPage buttonNextPage);

        void RenderButtonSound(ButtonSound buttonSound);

        void RenderDragAndDropSource(DragAndDropSource dragAndDropSource);

        void RenderExitButton(ExitButton exitButton);

        void RenderImage(Image image);

        void RenderLetter(Letter letter);

        void RenderWord(Word word);
    }
}