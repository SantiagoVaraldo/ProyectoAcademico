using System;

/// <summary>
/// NOMBRE: DragAndDrop.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos DragAndDrop.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos DragAndDrop.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de DragAndDrop, su unica razon de cambio es modificar los datos que guardamos sobre DragAndDrop.
/// 
/// COLABORACIONES: Colabora con la clase Element y Level ya que un elemento debe pertenecer a un nivel.
/// </summary>

namespace Library
{
    public class DragAndDrop : Element
    {
        public DragAndDrop(string Name, int PositionY, int PositionX, int Length, int Width, Level Level, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Level,ImagePath)
        {
        }
    }
}
