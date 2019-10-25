using System;
using Proyecto.Common;

/// <summary>
/// NOMBRE: ButtonCheck.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los ButtonCheck.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos ButtonCheck, conoce el nombre, tamaño, la posicion,
/// la pantalla, las rutas y la variable check del ButtonCheck. 
/// 
/// HERENCIA: esta clase hereda de la clase mas general Element, tambien implementa la interfaz IButton, por lo que
/// es un tipo de boton.
/// 
/// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
/// y es de tipo Element. Ademas colabora con la Interfaz IButoon ya que la implementa.
/// </summary>

namespace Library
{
    public class ButtonCheck : Element, IButton
    {
        public ButtonCheck(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath, string ImagePath2, bool Check)
        : base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
            this.Check = Check;
            this.State = false;
            this.ImagePath2 = ImagePath2;
        }
        private bool state;
        public bool State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;

            }
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
                this.check = value;

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

        /// <summary>
        /// accion que realiza el boton de tipo ButtonCheck al hacerle click
        /// </summary>
        public void Action(string name)
        {
            SingletonAdapter.Adapter.Debug($"Button clicked!");//algo
            //this.State = true;
            //MotorLvl3.CheckWon();
        }

        /// <summary>
        /// metodo que deselecciona el boton
        /// </summary>
        public void Unselect()
        {
            this.State = false;
        }

        /// <summary>
        /// metodo que permite al objeto de tipo ButtonCheck renderizarce a si mismo en Unity
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce </param>
        public override void Render(IMainViewAdapter adapter)
        {
            string buttonId = adapter.CreateButton((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length, "#BC2FA864", this.Action);
            //adapter.SetImage(buttonId, this.ImagePath);
        }


    }
}
