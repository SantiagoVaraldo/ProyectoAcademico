//--------------------------------------------------------------------------------
// <copyright file="BlankSpace.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: BlankSpace.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos BlankSpace,
    /// es de tipo DragAndDropDestination.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de BlankSpace, su unica razon de cambio es modificar los datos que guardamos sobre BlankSpace.
    /// HERENCIA: Esta clase hereda de la clase ancestra DragAndDropDestination
    /// COLABORACIONES: Colabora con la clase DragAndDropDestination y Screen ya que un BlankSpace debe pertenecer a una Screen
    /// y es de tipo DragAndDropDestination.
    /// </summary>
    public class BlankSpace : DragAndDropDestination
    {
        private bool filled;
        public BlankSpace(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath)
        : base(name, positionY, positionX, length, width, screen, imagePath)
        {
            this.Filled = false;
        }

        public string DestinationCellImageId { get; set; }

        public bool Filled
        {
            get
            {
                return this.filled;
            }

            set
            {
                this.filled = value;
            }
        }

        /// <summary>
        /// cambia atributo Filled a true.
        /// </summary>
        public void Fill()
        {
            this.Filled = true;
        }

        /// <summary>
        /// cambia atributo Filled a false.
        /// </summary>
        public void Unfill()
        {
            this.Filled = false;
        }

        /// <summary>
        /// metodo que llama al metodo correspondiente de la clase Rendere para renderizarce en Unity.
        /// </summary>
        /// <param name="renderer"> objeto Renderer al que se le delega la responsabilidad. </param>
        public override void Render(Renderer renderer)
        {
            renderer.RenderBlankSpace(this);
        }
    }
}