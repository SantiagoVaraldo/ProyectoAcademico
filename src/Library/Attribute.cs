namespace ExerciseOne
{
    /// <summary>
    /// NOMBRE: Attribute.
    /// 
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los atributos.
    /// 
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos Attribute, conoce clave y valor del atributo.
    /// 
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de atributos, su unica razon de cambio es modificar los datos que guardamos sobre atributos.
    /// 
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
