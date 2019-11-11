//--------------------------------------------------------------------------------
// <copyright file="ButtonNextPage.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
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
    /// Tambien colabora con la clase Renderer ya que es quien dibuja un objeto de tipo ButtonNextPage en Unity.
    /// </summary>
    public class ButtonNextPage : Element, IButton
    {
        public ButtonNextPage(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
        }

        /// <summary>
        /// accion que realiza el boton de tipo ButtonNextPage al hacerle click.
        /// </summary>
        /// <param name="name"> nombre del boton. </param>
        public void Action(string name)
        {
            IObserver generalEngine = Singleton<GeneralEngine>.Instance;
            generalEngine.Update();
        }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la clase Rendere para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> objeto Renderer al que se le delega la responsabilidad. </param>
        public override void Render(Renderer renderer)
        {
            renderer.RenderButtonNextPage(this);
        }
    }
}
