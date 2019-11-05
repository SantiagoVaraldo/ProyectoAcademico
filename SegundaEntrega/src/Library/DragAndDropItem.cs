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
    /// y es de tipo Element.
    /// </summary>
    public class DragAndDropItem : Element
    {
        private DragAndDropSource source;
        private BlankSpace destination;

        public DragAndDropItem(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath, DragAndDropSource source, BlankSpace destination)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
            this.Destination = destination;
            this.Source = source;
        }

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
