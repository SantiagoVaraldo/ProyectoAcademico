//--------------------------------------------------------------------------------
// <copyright file="VisitorLevel.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ExerciseOne;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: VisitorLevel.
    /// DESCRIPCION: crea un objeto de tipo Level.
    /// VISITOR: hereda de la clase Visitor, es parte de la implementacion del patron mencionado en Visitor.
    /// SRP: esta clase implementa una unica responsabilidad, crear objetos de tipo Level,
    /// su unica razon de cambio es modificar la manera de instanciar dichos objetos.
    /// COLABORACIONES: colabora con la clase Visitor, ya que hereda de la misma, colabora con la clase Tag ya que conoce
    /// un objeto Tag, colabora con Word, Level y Screen.
    /// </summary>
    public class VisitorLevel : Visitor
    {
        private Tag tag;

        /// <summary>
        /// constructor de VisitorLevel.
        /// </summary>
        /// <param name="tag">Tag recibido.</param>
        public VisitorLevel(Tag tag)
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
            try
            {
                string name = this.tag.AttributeList["Name"].Value;
                IXML level = new Level(name, world);
                world.Add(level);
            }
            catch (Exception)
            {
                string message = "there was an error while fetching data from the XML file";
                throw new NotFoundOnXMLException(message);
            }
        }

        /// <summary>
        /// metodo para acceder al level.
        /// </summary>
        /// <param name="level"> objeto level al que se accede. </param>
        public override void Visit(Level level)
        {
            // linea en blanco intencionalmente
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