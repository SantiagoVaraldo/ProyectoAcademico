//--------------------------------------------------------------------------------
// <copyright file="VisitorWord.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ExerciseOne;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: VisitorWord.
    /// DESCRIPCION: obtiene el ultimo Level del World, la ultima Screen del Level y crea un objeto de tipo
    /// Word.
    /// VISITOR: hereda de la clase Visitor, es parte de la implementacion del patron mencionado en Visitor.
    /// SRP: esta clase implementa una unica responsabilidad, crear objetos de tipo Word,
    /// su unica razon de cambio es modificar la manera de instanciar dichos objetos.
    /// COLABORACIONES: colabora con la clase Visitor, ya que hereda de la misma, colabora con la clase Tag ya que conoce
    /// un objeto Tag, colabora con Word, Level y Screen ya que son los objetos que va a "Visitar", por ultimo colabora
    /// con Word, BlankSpace y DragAndDropSource ya que va a instanciar objetos Word.
    /// </summary>
    public class VisitorWord : Visitor
    {
        private Tag tag;

        /// <summary>
        /// constructor de VisitorWord.
        /// </summary>
        /// <param name="tag">Tag recibido.</param>
        public VisitorWord(Tag tag)
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
                this.LastScreen.Accept(this);
            }
        }

        /// <summary>
        /// metodo para acceder a la screen.
        /// </summary>
        /// <param name="screen"> objeto Screen a la que se accede. </param>
        public override void Visit(Screen screen)
        {
            try
            {
                string name = this.tag.AttributeList["Name"].Value;
                int positionY = Int32.Parse(this.tag.AttributeList["PositionY"].Value);
                int positionX = Int32.Parse(this.tag.AttributeList["PositionX"].Value);
                int length = Int32.Parse(this.tag.AttributeList["Length"].Value);
                int width = Int32.Parse(this.tag.AttributeList["Width"].Value);
                string imagePath = this.tag.AttributeList["ImagePath"].Value;

                foreach (Element element in screen.ElementList)
                {
                    if (element is BlankSpace && element.Name == name)
                    {
                        this.WordDestination = element;
                    }

                    else if (element is DragAndDropSource && element.Name == name)
                    {
                        this.WordSource = element;
                    }
                }

                IXML word = new Word(name, positionY, positionX, length, width, this.LastScreen, imagePath, (DragAndDropSource)this.WordSource, (BlankSpace)this.WordDestination);
                this.LastScreen.Add(word);
            }
            catch (Exception)
            {
                string message = "there was an error while fetching data from the XML file";
                throw new NotFoundOnXMLException(message);
            }
        }
    }
}