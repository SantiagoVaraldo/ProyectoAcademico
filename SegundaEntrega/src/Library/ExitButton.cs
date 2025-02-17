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
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de ExitButton, su unica razon de cambio es modificar los datos que guardamos sobre ExitButton.
    /// HERENCIA: esta clase hereda de la clase mas general Element, tambien implementa la interfaz IButton, por lo que
    /// es un tipo de boton.
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
    /// y es de tipo Element. Ademas colabora con la Interfaz IButoon ya que la implementa.
    /// Tambien colabora con la Interfaz IRenderer para dibujar el elemento correspondiente en Unity.
    /// </summary>
    public class ExitButton : Element, IButton
    {
        /// <summary>
        /// constructor de ExitButton.
        /// </summary>
        /// <param name="name">nombre.</param>
        /// <param name="positionY">posicion Y.</param>
        /// <param name="positionX">posicion X.</param>
        /// <param name="length">largo.</param>
        /// <param name="width">ancho.</param>
        /// <param name="screen">Screen a la que pertenece el elemento.</param>
        /// <param name="imagePath">imagen que posee el elemento.</param>
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
            // aun no existe un metodo para salir de la app, esa era la idea de este boton
        }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la interfaz IRenderer para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> IRenderer al que se le delega la responsabilidad. </param>
        public override void Render(IRenderer renderer)
        {
            renderer.RenderExitButton(this);
        }
    }
}
