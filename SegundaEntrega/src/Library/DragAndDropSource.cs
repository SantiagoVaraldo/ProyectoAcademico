//--------------------------------------------------------------------------------
// <copyright file="DragAndDropSource.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: DragAndDropSource.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos DragAndDropSource
    /// es de tipo Element.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos DragAndDropSource.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de DragAndDropSource, su unica razon de cambio es modificar los datos que guardamos sobre DragAndDropSource.
    /// HERENCIA: Esta clase hereda de la clase ancestra Element
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que un DragAndDropSource debe pertenecer a una Screen
    /// y es de tipo Element. Tambien colabora con la clase Renderer ya que es quien dibuja un objeto de tipo
    /// DragAndDropSource en Unity.
    /// </summary>
    public class DragAndDropSource : Element
    {
        public DragAndDropSource(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
        }

        public string SourceCellImageId { get; set; }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la clase Rendere para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> objeto Renderer al que se le delega la responsabilidad. </param>
        public override void Render(Renderer renderer)
        {
            renderer.RenderDragAndDropSource(this);
        }
    }
}