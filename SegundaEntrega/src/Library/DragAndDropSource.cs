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
    /// y es de tipo Element. Tambien colabora con la Interfaz IRenderer para dibujar el elemento correspondiente en Unity.
    /// </summary>
    public class DragAndDropSource : Element
    {
        /// <summary>
        /// constructor de DragAndDropSource.
        /// </summary>
        /// <param name="name">nombre.</param>
        /// <param name="positionY">posicion Y.</param>
        /// <param name="positionX">posicion X.</param>
        /// <param name="length">largo.</param>
        /// <param name="width">ancho.</param>
        /// <param name="screen">Screen a la que pertenece el elemento.</param>
        /// <param name="imagePath">imagen que posee el elemento.</param>
        public DragAndDropSource(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
        }

        /// <summary>
        /// Id que corresponde con la imagen.
        /// </summary>
        /// <value> sourceId. </value>
        public string SourceCellImageId { get; set; }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la interfaz IRenderer para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> IRenderer al que se le delega la responsabilidad. </param>
        public override void Render(IRenderer renderer)
        {
            renderer.RenderDragAndDropSource(this);
        }
    }
}