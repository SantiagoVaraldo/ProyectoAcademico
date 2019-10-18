using System;
using Proyecto.Common;

/// <summary>
/// NOMBRE: DragAndDropItem.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos DragAndDropItem
/// es de tipo Element.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos DragAndDropItem.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de DragAndDropItem, su unica razon de cambio es modificar los datos que guardamos sobre DragAndDropItem.
/// 
/// HERENCIA: Esta clase hereda de la clase ancestra Element
/// 
/// COLABORACIONES: Colabora con la clase Element y Screen ya que un DragAndDropItem debe pertenecer a una Screen 
/// y es de tipo Element.
/// </summary>

namespace Library
{
    public class DragAndDropItem : Element
    {
        public DragAndDropItem(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }

        /// <summary>
        /// metodo que permite al objeto de tipo DragAndDropItem renderizarce a si mismo en Unity
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce </param>
        public override void Render(IMainViewAdapter adapter)
        {
            string itemId = adapter.CreateDragAndDropItem((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length);
            adapter.SetImage(itemId, this.ImagePath);
            //this.adapter.AddItemToDragAndDropSource(sourceCellImageId, itemId);
            //this.adapter.SetImage(destinationCellImageId, "Cell.png");
        }
    }
}
