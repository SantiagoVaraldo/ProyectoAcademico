//--------------------------------------------------------------------------------
// <copyright file="VisitorDragAndDropSource.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ExerciseOne;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: VisitorDragAndDropSource.
    /// DESCRIPCION: obtiene el ultimo Level del World, la ultima Screen del Level y crea un objeto de tipo
    /// DragAndDropSource.
    /// VISITOR: hereda de la clase Visitor, es parte de la implementacion del patron mencionado en Visitor.
    /// SRP: esta clase implementa una unica responsabilidad, crear objetos de tipo DragAndDropSource,
    /// su unica razon de cambio es modificar la manera de instanciar dichos objetos.
    /// COLABORACIONES: colabora con la clase Visitor, ya que hereda de la misma, colabora con la clase Tag ya que conoce
    /// un objeto Tag, colabora con Word, Level y Screen ya que son los objetos que va a "Visitar", por ultimo colabora
    /// con DragAndDropSource ya que va a instanciar dichos objetos.
    /// </summary>
    public class VisitorDragAndDropSource : Visitor
    {
        private Tag tag;

        public VisitorDragAndDropSource(Tag tag)
        {
            this.Tag = tag;
        }

        public Tag Tag
        {
            get
            {
                return this.tag;
            }

            set
            {
                this.tag = value;
            }
        }

        /// <summary>
        /// metodo para acceder al world.
        /// </summary>
        /// <param name="world"> objeto world al que accede. </param>
        public override void Visit(World world)
        {
            if (world.ListLevel.Count >= 1)
            {
                this.LastLevel = world.ListLevel[world.ListLevel.Count - 1];
                this.LastLevel.Accept(this);
            }
        }

        /// <summary>
        /// metodo para acceder al level.
        /// </summary>
        /// <param name="level"> objeto level al que se accede. </param>
        public override void Visit(Level level)
        {
            if (level.ListaScreen.Count >= 1)
            {
                this.LastScreen = level.ListaScreen[level.ListaScreen.Count - 1];
            }

            string name = this.tag.ListaAtributos["Name"].Valor;
            int positionY = Int32.Parse(this.tag.ListaAtributos["PositionY"].Valor);
            int positionX = Int32.Parse(this.tag.ListaAtributos["PositionX"].Valor);
            int length = Int32.Parse(this.tag.ListaAtributos["Length"].Valor);
            int width = Int32.Parse(this.tag.ListaAtributos["Width"].Valor);
            string imagePath = this.tag.ListaAtributos["ImagePath"].Valor;

            DragAndDropSource dragAndDropSource = new DragAndDropSource(name, positionY, positionX, length, width, this.LastScreen, imagePath);
            this.LastScreen.Add(dragAndDropSource);
        }

        /// <summary>
        /// metodo para acceder a la screen.
        /// </summary>
        /// <param name="screen"> objeto Screen a la que se accede. </param>
        public override void Visit(Screen screen)
        {
        }
    }
}