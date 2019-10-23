using System;
using Proyecto.Common;

/// <summary>
/// NOMBRE: DragAndDropDestination.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos DragAndDropDestination
/// es de tipo Element.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos DragAndDropDestination.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de DragAndDropDestination, su unica razon de cambio es modificar los datos que guardamos sobre DragAndDropDestination.
/// 
/// HERENCIA: Esta clase hereda de la clase ancestra Element
/// 
/// COLABORACIONES: Colabora con la clase Element y Screen ya que un DragAndDropDestination debe pertenecer a una Screen 
/// y es de tipo Element.
/// </summary>

namespace Library
{
    public class DragAndDropDestination : Element
    {
        public string destinationCellImageId;
        public DragAndDropDestination(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }

        /// <summary>
        /// metodo que permite al objeto de tipo DragAndDropDestination renderizarce a si mismo en Unity
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce </param>
        public override void Render(IMainViewAdapter adapter)
        {
            destinationCellImageId = adapter.CreateImage((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length);
            adapter.SetImage(destinationCellImageId, this.ImagePath);
        }
    }
}