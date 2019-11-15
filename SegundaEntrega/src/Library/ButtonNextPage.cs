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
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de ButtonNextPage, su unica razon de cambio es modificar los datos que guardamos sobre ButtonNextPage.
    /// HERENCIA: esta clase hereda de la clase mas general Element, tambien implementa la interfaz IButton, por lo que
    /// es un tipo de boton.
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
    /// y es de tipo Element. Ademas colabora con la Interfaz IButoon ya que la implementa.
    /// Tambien colabora con la Interfaz IRenderer para dibujar el elemento correspondiente en Unity.
    /// </summary>
    public class ButtonNextPage : Element, IButton
    {
        private string buttonId;
        private string text;

        public ButtonNextPage(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath, string text)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
            this.Text = text;
        }

        /// <summary>
        /// id que corresponde con el boton creado.
        /// </summary>
        /// <value> id. </value>
        public string ButtonId
        {
            get
            {
                return this.buttonId;
            }

            set
            {
                this.buttonId = value;
            }
        }

        /// <summary>
        /// texto que se ve en el boton.
        /// </summary>
        /// <value> texto. </value>
        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                this.text = value;
            }
        }

        /// <summary>
        /// accion que realiza el boton de tipo ButtonNextPage al hacerle click.
        /// </summary>
        /// <param name="name"> nombre del boton. </param>
        public void Action(string name)
        {
            if (name == this.ButtonId)
            {
                GeneralEngine generalEngine = Singleton<GeneralEngine>.Instance;
                generalEngine.ChangeLevel(this.Name);
                generalEngine.Update();
            }
        }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la interfaz IRenderer para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> IRenderer al que se le delega la responsabilidad. </param>
        public override void Render(IRenderer renderer)
        {
            renderer.RenderButtonNextPage(this);
        }
    }
}
