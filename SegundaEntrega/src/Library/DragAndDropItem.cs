using System;
using Proyecto.Common;

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

namespace Library
{
    public class DragAndDropItem : Element
    {
        public DragAndDropItem(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath, DragAndDropSource source, BlankSpace destination)
        : base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
            this.Destination = destination;
            this.Source = source;
        }

        private DragAndDropSource source;
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

        private BlankSpace destination;
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
