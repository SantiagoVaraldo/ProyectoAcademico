using System;

/// <summary>
/// NOMBRE: Element.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos Element.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de Element, su unica razon de cambio es modificar los datos que guardamos sobre el elemento.
/// 
/// COLABORACIONES: Colabora con la clase Level ya que un elemento debe pertenecer a un nivel.
/// </summary>

namespace Library
{
    public class Element
    {
        public Element(string Name, int PositionY, int PositionX, int Length, int Width, Level Level)
        {
            this.Name = Name;
            this.PositionY = PositionY;
            this.PositionX = PositionX;
            this.Length = Length;
            this.Width = Width;
            this.Level = Level;
        }
        private string name;
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
        private int positionY;
        public int PositionY
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
        private int positionX;
        public int PositionX
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
        private int length;
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value != null)
                {
                    this.length = value;
                }
            }
        }
        private int width;
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value != null)
                {
                    this.width = value;
                }
            }
        }
        private Level level;
        public Level Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value != null)
                {
                    this.level = value;
                }
            }
        }
    }
}
