//--------------------------------------------------------------------------------
// <copyright file="ExitButton.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: ExitButton.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los ExitButton.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos ExitButton, conoce el nombre, tamaño, la posicion,
    /// la pantalla y la ruta del ExitButton.
    /// HERENCIA: esta clase hereda de la clase mas general Element, tambien implementa la interfaz IButton, por lo que
    /// es un tipo de boton.
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
    /// y es de tipo Element. Ademas colabora con la Interfaz IButoon ya que la implementa.
    /// </summary>
    public class ExitButton : Element, IButton
    {
        public ExitButton(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
        }

        /// <summary>
        /// accion que realiza el boton de tipo ExitButton al hacerle click.
        /// </summary>
        /// <param name="name"> nombre del boton. </param>
        public void Action(string name)
        {
            OneAdapter.Adapter.Debug($"Button clicked!");
        }

        /// <summary>
        /// metodo que permite al objeto de tipo ExitButton renderizarce a si mismo en Unity.
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce. </param>
        public override void Render(IMainViewAdapter adapter)
        {
            string buttonId = adapter.CreateButton((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length, "#BC2FA864", this.Action);

            // adapter.SetImage(buttonId, this.ImagePath);
        }
    }
}
