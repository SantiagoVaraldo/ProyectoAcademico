using System;

/// <summary>
/// NOMBRE: Image.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los imagenes.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos Image.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de Image, su unica razon de cambio es modificar los datos que guardamos sobre la imagen.
/// 
/// COLABORACIONES: Colabora con la clase Element y Level ya que un elemento debe pertenecer a un nivel.
/// </summary>

namespace Library
{
    public class Image : Element
    {
        public Image(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }
    }
}
