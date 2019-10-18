using System;

/// <summary>
/// NOMBRE: Word.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos Word,
/// es de tipo DragAndDropItem.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de Word, su unica razon de cambio es modificar los datos que guardamos sobre word.
/// 
/// HERENCIA: Esta clase hereda de la clase ancestra DragAndDropItem
/// 
/// COLABORACIONES: Colabora con la clase DragAndDropItem y Screen ya que un Word debe pertenecer a una Screen 
/// y es de tipo DragAndDropItem.
/// </summary>

namespace Library
{
    public class Word : DragAndDropItem
    {
        public Word(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }
    }
}