using Proyecto.Common;
using System;

/// <summary>
/// NOMBRE: Image.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a las imagenes.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos Image.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de Image, su unica razon de cambio es modificar los datos que guardamos sobre la imagen.
/// 
/// HERENCIA: esta clase hereda de la clase mas general Element, de momento la imagen va a heredar todo de elemento
/// y no agrega comportamiento ni atributos extras.(optamos pr herencia en lugar de composicion ya que necesitabamos 
/// todo los datos de Element y no ibamos a crear comportamiento)
/// 
/// COLABORACIONES: Colabora con la clase Element y Screen ya que una imagen debe pertenecer a una Screen y ademas
/// es de tipo Element.
/// </summary>

namespace Library
{
    public class Image : Element
    {
        public Image(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }
        public override void Render(IMainViewAdapter adapter)
        {
            string imageId = adapter.CreateImage((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length);
            adapter.SetImage(imageId, this.ImagePath);
        }
    }
    
}
