//--------------------------------------------------------------------------------
// <copyright file="ButtonSound.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: ButtonSound.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los ButtonSound.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos ButtonSound, conoce el nombre, tamaño, la posicion,
    /// la pantalla y las rutas del ButtonSound.
    /// HERENCIA: esta clase hereda de la clase mas general Element, tambien implementa la interfaz IButton, por lo que
    /// es un tipo de boton.
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
    /// y es de tipo Element. Ademas colabora con la Interfaz IButton ya que la implementa.
    /// Tambien colabora con la Interfaz IRenderer para dibujar el elemento correspondiente en Unity.
    /// </summary>
    public class ButtonSound : Element, IButton
    {
        private bool state;
        private string soundPath;
        private string buttonId;

        public ButtonSound(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath, string soundPath)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
            this.SoundPath = soundPath;
            this.state = false;
        }

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
        /// accion que realiza el boton de tipo ButtonSound al hacerle click.
        /// </summary>
        /// <param name="name"> nombre del boton. </param>
        public void Action(string name)
        {
            if (name == this.ButtonId)
            {
                EngineLvl1 engineLvl1 = Singleton<EngineLvl1>.Instance;
                engineLvl1.Sound(this);
            }
        }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la Interfaz IRenderer para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> IRenderer al que se le delega la responsabilidad. </param>
        public override void Render(IRenderer renderer)
        {
            renderer.RenderButtonSound(this);
        }
    }
}