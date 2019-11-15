//--------------------------------------------------------------------------------
// <copyright file="Element.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: Element.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos es de tipo IXML.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos Element.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de Element, su unica razon de cambio es modificar los datos que guardamos sobre el elemento.
    /// COLABORACIONES: Colabora con la clase Screen ya que un elemento debe pertenecer a una pantalla y con la interfaz IXML.
    /// Tambien colabora con la Interfaz IRenderer para dibujar el elemento correspondiente en Unity.
    /// </summary>
    public class Element : IXML
    {
        private string name;
        private int? positionY;
        private int? positionX;
        private int? length;
        private int? width;
        private Screen screen;
        private string imagePath;

        public Element(string name, int positionY, int positionX, int length, int width, Screen screen, string imagePath)
        {
            this.Name = name;
            this.PositionY = positionY;
            this.PositionX = positionX;
            this.Length = length;
            this.Width = width;
            this.Screen = screen;
            this.ImagePath = imagePath;
        }

        /// <summary>
        /// nombre del elemento.
        /// </summary>
        /// <value> nombre. </value>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

        /// <summary>
        /// posicion y del elemento.
        /// </summary>
        /// <value> posicion y .</value>
        public int? PositionY
        {
            get
            {
                return this.positionY;
            }

            set
            {
                if (value != null)
                {
                    this.positionY = value;
                }
            }
        }

        /// <summary>
        /// posicion x del elemento.
        /// </summary>
        /// <value> posicion x. </value>
        public int? PositionX
        {
            get
            {
                return this.positionX;
            }

            set
            {
                if (value != null)
                {
                    this.positionX = value;
                }
            }
        }

        /// <summary>
        /// largo del elemento.
        /// </summary>
        /// <value> largo. </value>
        public int? Length
        {
            get
            {
                return this.length;
            }

            set
            {
                if (value > 0)
                {
                    this.length = value;
                }
            }
        }

        /// <summary>
        /// ancho del elemento.
        /// </summary>
        /// <value> ancho. </value>
        public int? Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
            }
        }

        /// <summary>
        /// Screen a la que pertenece el elemento.
        /// </summary>
        /// <value> Screen. </value>
        public Screen Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                if (value != null)
                {
                    this.screen = value;
                }
            }
        }

        /// <summary>
        /// imagen que posee el elemento.
        /// </summary>
        /// <value> imagePath. </value>
        public string ImagePath
        {
            get
            {
                return this.imagePath;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.imagePath = value;
                }
            }
        }

        /// <summary>
        /// metodo virtual el cual es remplazado por los metodos Render particulares de las clases que heredan de Element.
        /// </summary>
        /// <param name="renderer"> IRenderer al que se le delega la responsabilidad. </param>
        public virtual void Render(IRenderer renderer)
        {
        }
    }
}
