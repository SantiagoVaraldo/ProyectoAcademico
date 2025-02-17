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
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de Letter, su unica razon de cambio es modificar los datos que guardamos sobre Letter.
    /// HERENCIA: esta clase hereda de la clase mas general Element, tambien implementa la interfaz IButton.
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
    /// y es de tipo Element. Ademas colabora con la interfaz IButton ya que la implementa.
    /// Tambien colabora con la Interfaz IRenderer para dibujar el elemento correspondiente en Unity.
    /// </summary>
    public class Letter : Element, IButton
    {
        private bool right;
        private string buttonId;

        /// <summary>
        /// constructor de la letra.
        /// </summary>
        /// <param name="name">nombre.</param>
        /// <param name="positionY">posicion Y.</param>
        /// <param name="positionX">posicion X.</param>
        /// <param name="length">largo.</param>
        /// <param name="width">ancho.</param>
        /// <param name="screen">Screen a la que pertenece la letra.</param>
        /// <param name="imagePath">imagen que posee la letra.</param>
        /// <param name="right">indica si la letra es correcta.</param>
        public Letter(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath, bool right)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
            this.Right = right;
        }

        /// <summary>
        /// indica si es la letra correcta.
        /// </summary>
        /// <value> rigth bool. </value>
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
        /// Id que pertenece al boton creado.
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
        /// accion que realiza el boton de tipo Letter al hacerle click.
        /// </summary>
        /// <param name="name"> nombre de la Letter. </param>
        public void Action(string name)
        {
            if (name == this.ButtonId)
            {
                EngineLvl1 engineLvl1 = Singleton<EngineLvl1>.Instance;
                engineLvl1.Check(this);
                engineLvl1.Reset(this.Screen);
            }
        }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la interfaz IRenderer para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> IRenderer al que se le delega la responsabilidad. </param>
        public override void Render(IRenderer renderer)
        {
            renderer.RenderLetter(this);
        }
    }
}