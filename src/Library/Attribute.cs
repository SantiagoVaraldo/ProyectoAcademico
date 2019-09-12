using System;

namespace ExerciseOne
{
    /// <summary>
    /// NOMBRE: Attribute.
    /// DESCRIPCION: Esta clase se encarga de crear objetos con los atributos del codigo HTML.
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    ///                de los datos para crear los objetos Attribute, conoce calve y valor del atributo.
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es crear los objetos, su unica 
    ///      razon de cambio es modificar la manera de crear objetos Attribute.
    /// COLABORACIONES: No colabora con ninguna otra clase.
    /// </summary>
    public class Attribute
    {
      
        public Attribute (string clave, string valor)
        {
            this.Clave = clave;
            this.Valor = valor;
        }
        
        private string clave;
        private string valor;
        public string Clave
        {
            get
            {
                return this.clave;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.clave = value;
                }
            }
        }
        public string Valor
        {
            get
            {
                return this.valor;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.valor = value;
                }
            }
        }
    }
}
