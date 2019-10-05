using System;

/// <summary>
/// NOMBRE: Button.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los botones.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos Button, conoce el nombre, tamaño, la posicion
/// y la pantalla de Button.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de Button, su unica razon de cambio es modificar los datos que guardamos sobre un boton.
/// 
/// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen, y debe 
/// conocer la informacion de un objeto Element.
/// </summary>

namespace Library
{
    public class Button : Element
    {
        public Button(string Name, int PositionY, int PositionX, int Length,int Width,Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }
    }
}
