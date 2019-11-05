//--------------------------------------------------------------------------------
// <copyright file="VisitorButtonCheck.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ExerciseOne;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: VisitorButtonCheck.
    /// DESCRIPCION: obtiene el ultimo Level del World, la ultima Screen del Level y crea un objeto de tipo ButtonCheck.
    /// VISITOR: hereda de la clase Visitor, es parte de la implementacion del patron mencionado en Visitor.
    /// SRP: esta clase implementa una unica responsabilidad, crear objetos de tipo ButtonCheck, su unica razon de cambio
    /// es modificar la manera de instanciar dichos objetos.
    /// COLABORACIONES: colabora con la clase Visitor, ya que hereda de la misma, colabora con la clase Tag ya que conoce
    /// un objeto Tag, colabora con Word, Level y Screen ya que son los objetos que va a "Visitar", por ultimo colabora
    /// con ButtonCheck ya que va a instanciar dichos objetos.
    /// </summary>
    public class VisitorButtonCheck : Visitor
    {
        private Tag tag;

        public VisitorButtonCheck(Tag tag)
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
            if (level.ScreenList.Count >= 1)
            {
                this.LastScreen = level.ScreenList[level.ScreenList.Count - 1];
            }

            string name = this.tag.AttributeList["Name"].Value;
            int positionY = Int32.Parse(this.tag.AttributeList["PositionY"].Value);
            int positionX = Int32.Parse(this.tag.AttributeList["PositionX"].Value);
            int length = Int32.Parse(this.tag.AttributeList["Length"].Value);
            int width = Int32.Parse(this.tag.AttributeList["Width"].Value);
            bool check = Convert.ToBoolean(this.tag.AttributeList["Check"].Value);
            string imagePath = this.tag.AttributeList["ImagePath"].Value;
            string imagePath2 = this.tag.AttributeList["ImagePath2"].Value;

            IXML button = new ButtonCheck(name, positionY, positionX, length, width, this.LastScreen, imagePath, imagePath2, check);
            this.LastScreen.Add(button);
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