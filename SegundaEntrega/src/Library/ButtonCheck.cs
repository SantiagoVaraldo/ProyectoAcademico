//--------------------------------------------------------------------------------
// <copyright file="ButtonCheck.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: ButtonCheck.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los ButtonCheck.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos ButtonCheck, conoce el nombre, tamaño, la posicion,
    /// la pantalla, las rutas y la variable check del ButtonCheck.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de ButtonCheck, su unica razon de cambio es modificar los datos que guardamos sobre ButtonCheck.
    /// HERENCIA: esta clase hereda de la clase mas general Element, tambien implementa la interfaz IButton, por lo que
    /// es un tipo de boton.
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
    /// y es de tipo Element. Ademas colabora con la Interfaz IButton ya que la implementa.
    /// Tambien colabora con la Interfaz IRenderer para dibujar el elemento correspondiente en Unity.
    /// </summary>
    public class ButtonCheck : Element, IButton
    {
        private bool state;
        private bool check;
        private string imagepath2;
        private string buttonId;

        /// <summary>
        /// constructor de ButtonCheck.
        /// </summary>
        /// <param name="name">nombre.</param>
        /// <param name="positionY">posicion Y.</param>
        /// <param name="positionX">posicion X.</param>
        /// <param name="length">largo.</param>
        /// <param name="width">ancho.</param>
        /// <param name="screen">Screen a la que pertenece el Elemento.</param>
        /// <param name="imagePath">imagen 1 del elemento.</param>
        /// <param name="imagePath2">imagen 2 del elemento.</param>
        /// <param name="check">indica si este elemento es el correcto.</param>
        public ButtonCheck(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath, string imagePath2, bool check)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
            this.Check = check;
            this.State = false;
            this.ImagePath2 = imagePath2;
        }

        /// <summary>
        /// Id que corresponde con el boton creado.
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
        /// estado del boton.
        /// </summary>
        /// <value> estado bool. </value>
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

        /// <summary>
        /// indica si es el boton correcto.
        /// </summary>
        /// <value> correcto bool. </value>
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

        /// <summary>
        /// segunda imagen del boton.
        /// </summary>
        /// <value> path image. </value>
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
        /// accion que realiza el boton de tipo ButtonCheck al hacerle click.
        /// </summary>
        /// <param name="name"> nombre del boton. </param>
        public void Action(string name)
        {
            if (name == this.ButtonId)
            {
                EngineLvl3 engineLvl3 = Singleton<EngineLvl3>.Instance;
                if (engineLvl3.Check(this))
                {
                    engineLvl3.Reset(this.Screen);
                }
            }
        }

        /// <summary>
        /// metodo que selecciona el boton.
        /// </summary>
        public void Select()
        {
            this.State = true;
        }

        /// <summary>
        /// metodo que deselecciona el boton.
        /// </summary>
        public void Unselect()
        {
            this.State = false;
        }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la interfaz IRenderer para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> IRenderer al que se le delega la responsabilidad. </param>
        public override void Render(IRenderer renderer)
        {
            renderer.RenderButtonCheck(this);
        }
    }
}
