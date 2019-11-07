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
    /// pertinente para nuestros requisitos de crear objetos Letter asi como la accion de dicho boton.
    /// HERENCIA: esta clase hereda de la clase mas general Element, tambien implementa la interfaz IButton.
    /// COLABORACIONES: Colabora con la clase Element y Screen ya que debe conocer un objeto de tipo Screen al cual pertenecer,
    /// y es de tipo Element. Ademas colabora con la interfaz IButton ya que la implementa.
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
            OneAdapter.Adapter.Debug($"Button clicked!");
            engineLvl1.Check(this);
        }

        /// <summary>
        /// metodo que permite al objeto de tipo Letter renderizarce a si mismo en Unity.
        /// </summary>
        /// <param name="adapter"> recibe un IMainViewAdapter para renderizarce. </param>
        public override void Render(IMainViewAdapter adapter)
        {
            string buttonId = adapter.CreateButton((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length, "#FFFFFFFF", this.Action);
            adapter.SetImage(buttonId, this.ImagePath);
        }
    }
}