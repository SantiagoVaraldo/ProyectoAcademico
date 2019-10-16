using System;

/// <summary>
/// NOMBRE: ButtonCheck.
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
    public class ButtonCheck : Element, IButton
    {
        public ButtonCheck(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath, string ImagePath2, bool Check)
        : base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
            this.Check = Check;
            this.ImagePath2 = ImagePath2;
        }
        private bool check;
        public bool Check
        {
            get
            {
                return this.check;
            }
            set
            {
                if (value == true)
                {
                    this.check = value;
                }
            }
        }
        private string imagepath2;
        public string ImagePath2
        {
            get
            {
                return this.imagepath2;
            }
            set
            {
                if (value != null)
                {
                    this.imagepath2 = value;
                }
            }

        }
        public void Action()
        {        
        }


    }
}
