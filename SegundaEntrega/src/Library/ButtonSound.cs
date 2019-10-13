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
/// HERENCIA: esta clase hereda de la clase mas general Element, de momento el boton va a heredar todo de elemento
/// y no agrega comportamiento ni atributos extras.(optamos pr herencia en lugar de composicion ya que necesitabamos 
/// todo los datos de Element y no ibamos a crear comportamiento)
/// 
/// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
/// y es de tipo Element.
/// </summary>

namespace Library
{
    public class ButtonSound : Button
    {
        public ButtonSound(string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, string SoundPath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
            this.SoundPath = SoundPath;
        }
        private string soundPath;
        public string SoundPath
        {
            get 
            {
                return this.soundPath;
            }
            set 
            {
                if (value != null)
                {
                    this.soundPath = value;
                }
            }
        }
        
    }
}