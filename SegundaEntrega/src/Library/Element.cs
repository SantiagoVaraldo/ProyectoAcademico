using System;

/// <summary>
/// NOMBRE: Element.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos es de tipo IXML.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos Element.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de Element, su unica razon de cambio es modificar los datos que guardamos sobre el elemento.
/// 
/// COLABORACIONES: Colabora con la clase Screen ya que un elemento debe pertenecer a una pantalla y con la interfaz IXML.
/// </summary>

namespace Library
{
    public class Element : IXML
    {
        public Element(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        {
            this.Name = Name;
            this.PositionY = PositionY;
            this.PositionX = PositionX;
            this.Length = Length;
            this.Width = Width;
            this.Screen = Screen;
            this.ImagePath = ImagePath;
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
                if (value <= this.Width && value >= this.Length)
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
                if (value <= this.Length && value >= this.Width) //Hay que revisar este set y el de PositionY.
                {
                    this.positionX = value;
                }
            }
        }
        private int? length;
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
        private int? width;
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
        private Screen screen;
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
        private string imagePath;
        public string ImagePath
        {
            get
            {
                return this.imagePath;
            }
            set
            {
                if (value != "") 
                {
                    this.imagePath = value;
                }
            }
        }
    }
}
