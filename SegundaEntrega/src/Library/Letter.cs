//--------------------------------------------------------------------------------
// <copyright file="Letter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: Letter.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los objetos de tipo Letter.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos Letter.
    /// HERENCIA: esta clase hereda de la clase mas general Element, tambien implementa la interfaz IButton.
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
    /// y es de tipo Element. Ademas colabora con la interfaz IButton ya que la implementa.
    /// Tambien colabora con la clase Renderer ya que es quien dibuja un
    /// objeto de tipo Letter en Unity.
    /// </summary>
    public class Letter : Element, IButton
    {
        private bool right;

        public Letter(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath, bool right)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
            this.Right = right;
        }

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
        /// accion que realiza el boton de tipo Letter al hacerle click.
        /// </summary>
        /// <param name="name"> nombre de la Letter. </param>
        public void Action(string name)
        {
            IObserver generalEngine = Singleton<GeneralEngine>.Instance;
            EngineLvl1 engineLvl1 = Singleton<EngineLvl1>.Instance;
            engineLvl1.Subscribe(generalEngine);
            engineLvl1.Check(this);
        }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la clase Rendere para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> objeto Renderer al que se le delega la responsabilidad. </param>
        public override void Render(Renderer renderer)
        {
            renderer.RenderLetter(this);
        }
    }
}