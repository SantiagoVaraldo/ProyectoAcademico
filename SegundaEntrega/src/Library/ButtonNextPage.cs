using System;
using Proyecto.Common;

/// <summary>
/// NOMBRE: ButtonNextPage.
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los ButtonNextPage.
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos ButtonNextPage, conoce el nombre, tamaño, la posicion,
/// la pantalla y la ruta del ButtonNextPage. 
/// HERENCIA: esta clase hereda de la clase mas general Element, tambien implementa la interfaz IButton, por lo que
/// es un tipo de boton.
/// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
/// y es de tipo Element. Ademas colabora con la Interfaz IButoon ya que la implementa.
/// </summary>

namespace Library
{
    public class ButtonNextPage : Element, IButton
    {
        public ButtonNextPage(string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }

        /// <summary>
        /// accion que realiza el boton de tipo ButtonNextPage al hacerle click
        /// </summary>
        public void Action(string name)
        {
            SingletonAdapter.Adapter.Debug($"Button clicked!");//ShowPage(this.nextPageName); hay q pasarle la pagina q debe mostrar
        }

        /// <summary>
        /// metodo que permite al objeto de tipo ButtonNextPage renderizarce a si mismo en Unity
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce </param>
        public override void Render(IMainViewAdapter adapter)
        {
            string buttonId = adapter.CreateButton((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length, "#BC2FA864", this.Action);
            //adapter.SetImage(buttonId, this.ImagePath);
        }
    }
}
