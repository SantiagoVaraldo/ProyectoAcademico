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

        /// <summary>
        /// constructor de VisitorDragAndDropSource.
        /// </summary>
        /// <param name="tag">Tag recibido.</param>
        public VisitorDragAndDropSource(Tag tag)
        {
            this.Tag = tag;
        }

        /// <summary>
        /// Tag con los datos para crear el modelo.
        /// </summary>
        /// <value> Tag. </value>
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
            if (level.ScreenList.Count >= 1)
            {
                this.LastScreen = level.ScreenList[level.ScreenList.Count - 1];
            }

            try
            {
                string name = this.tag.AttributeList["Name"].Value;
                int positionY = Int32.Parse(this.tag.AttributeList["PositionY"].Value);
                int positionX = Int32.Parse(this.tag.AttributeList["PositionX"].Value);
                int length = Int32.Parse(this.tag.AttributeList["Length"].Value);
                int width = Int32.Parse(this.tag.AttributeList["Width"].Value);
                string imagePath = this.tag.AttributeList["ImagePath"].Value;

                IXML dragAndDropSource = new DragAndDropSource(name, positionY, positionX, length, width, this.LastScreen, imagePath);
                this.LastScreen.Add(dragAndDropSource);
            }
            catch (Exception)
            {
                string message = "there was an error while fetching data from the XML file";
                throw new NotFoundOnXMLException(message);
            }
        }

        /// <summary>
        /// metodo para acceder a la screen.
        /// </summary>
        /// <param name="screen"> objeto Screen a la que se accede. </param>
        public override void Visit(Screen screen)
        {
            // linea en blanco intencionalmente
        }
    }
}