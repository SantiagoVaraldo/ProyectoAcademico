using System;
using System.Collections.Generic;

/// <summary>
/// NOMBRE: Screen.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a las pantallas.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos Screen, conoce el nombre y un Level
/// al que pertenece la Screen.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de Screen, su unica razon de cambio es modificar los datos que guardamos sobre la pantalla.
/// 
/// COLABORACIONES: Colabora con la clase Level ya que debe conocer un objeto de tipo Level.
/// </summary>

namespace Library
{
    public class Screen
    {
        public Screen(string Name, Level Level)
        {
            this.Name = Name;
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
        private Level level;
        public Level Level
        {
            get
            {
                return this.level; // al ser un objeto no se que tan bueno sea esto
            }
            set
            {
                if (value != null)
                {
                    this.level = value;
                }
            }
        }
        private List<Element> listaelement = new List<Element>();
        public List<Element> ListaElement
        {
            get
            {
                return this.listaelement;
            }
            set
            {
                this.listaelement = value;
            }
        }
    }
}
