using System;
using Proyecto.Common;

/// <summary>
/// NOMBRE: Box.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos Box,
/// es de tipo DragAndDropSource.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de Box, su unica razon de cambio es modificar los datos que guardamos sobre Box.
/// 
/// HERENCIA: Esta clase hereda de la clase ancestra DragAndDropSource
/// 
/// COLABORACIONES: Colabora con la clase DragAndDropSource y Screen ya que un Box debe pertenecer a una Screen 
/// y es de tipo DragAndDropSource.
/// </summary>

namespace Library
{
    public class Box : DragAndDropSource
    {
        public string SourceCellImageId; 
        public Box(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }

        /// <summary>
        /// metodo que permite al objeto de tipo Box renderizarce a si mismo en Unity
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce </param>
        public override void Render(IMainViewAdapter adapter)
        {
            SourceCellImageId = adapter.CreateImage((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length);
            adapter.SetImage(SourceCellImageId, this.ImagePath);
        }

    }
}