using System;
using Proyecto.Common;

/// <summary>
/// NOMBRE: Letter.
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los objetos de tipo Letter.
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos Letter asi como la accion de dicho boton.
/// HERENCIA: esta clase hereda de la clase mas general Element, tambien implementa la interfaz IButton.
/// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
/// y es de tipo Element. Ademas colabora con la interfaz IButton ya que la implementa.
/// </summary>

namespace Library
{
    public class Letter : Element, IButton
    {
        public Letter(string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, bool Right)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
            this.Right = Right;
        }

        private bool right;
        public bool Right
        {
            get 
            {
                return this.right;
            }
            set 
            {
                this.right = value;        
            }
        }

        /// <summary>
        /// accion que realiza el boton de tipo Letter al hacerle click
        /// </summary>
        public void Action(string name)
        {
            OneAdapter.Adapter.Debug($"Button clicked!"); //hacer_algo
        }

        /// <summary>
        /// metodo que permite al objeto de tipo Letter renderizarce a si mismo en Unity
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce </param>
        public override void Render(IMainViewAdapter adapter)
        {
            string buttonId = adapter.CreateButton((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length, "#BC2FA864", this.Action);

            //adapter.SetImage(buttonId, this.ImagePath);
        }
    }
}