//--------------------------------------------------------------------------------
// <copyright file="DragAndDropItem.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: DragAndDropItem.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos DragAndDropItem
    /// es de tipo Element.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos DragAndDropItem.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de DragAndDropItem, su unica razon de cambio es modificar los datos que guardamos sobre DragAndDropItem.
    /// HERENCIA: Esta clase hereda de la clase ancestra Element
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que un DragAndDropItem debe pertenecer a una Screen
    /// y es de tipo Element. Tambien colabora con DragAndDropSource y BlankSpace ya que un item debe conocer
    /// un source y un destination.
    /// </summary>
    public class DragAndDropItem : Element
    {
        private DragAndDropSource source;
        private BlankSpace destination;

        /// <summary>
        /// constructor de DragAndDropItem.
        /// </summary>
        /// <param name="name">nombre.</param>
        /// <param name="positionY">posicion Y.</param>
        /// <param name="positionX">posicion X.</param>
        /// <param name="length">largo.</param>
        /// <param name="width">ancho.</param>
        /// <param name="screen">Screen a la que pertenece el elemento.</param>
        /// <param name="imagePath">imagen que posee el elemento.</param>
        /// <param name="source">fuente del elemento.</param>
        /// <param name="destination">destino del elemento.</param>
        public DragAndDropItem(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath, DragAndDropSource source, BlankSpace destination)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
            this.Destination = destination;
            this.Source = source;
        }

        /// <summary>
        /// fuente a la que pertenece el item.
        /// </summary>
        /// <value> source. </value>
        public DragAndDropSource Source
        {
            get
            {
                return this.source;
            }

            set
            {
                this.source = value;
            }
        }

        /// <summary>
        /// destino en el que debe terminar el item.
        /// </summary>
        /// <value> destination. </value>
        public BlankSpace Destination
        {
            get
            {
                return this.destination;
            }

            set
            {
                this.destination = value;
            }
        }
    }
}
