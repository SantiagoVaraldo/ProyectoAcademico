using System;
using Proyecto.Common;

/// <summary>
/// NOMBRE: DragAndDropSource.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos DragAndDropSource
/// es de tipo Element.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos DragAndDropSource.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de DragAndDropSource, su unica razon de cambio es modificar los datos que guardamos sobre DragAndDropSource.
/// 
/// HERENCIA: Esta clase hereda de la clase ancestra Element
/// 
/// COLABORACIONES: Colabora con la clase Element y Screen ya que un DragAndDropSource debe pertenecer a una Screen 
/// y es de tipo Element.
/// </summary>

namespace Library
{
    public class DragAndDropSource : Element
    {
        public DragAndDropSource(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }

        /// <summary>
        /// metodo que permite al objeto de tipo DragAndDropSource renderizarce a si mismo en Unity
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce </param>
        public override void Render(IMainViewAdapter adapter)
        {
            string sourceCellImageId = adapter.CreateImage((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length);
            adapter.SetImage(sourceCellImageId, this.ImagePath);
        }
    }
}