namespace ExerciseOne
{
    /// <summary>
    /// NOMBRE: Attribute.
    /// 
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los atributos.
    /// 
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos Attribute, conoce key y value del atributo.
    /// 
    /// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
    /// de atributos, su unica razon de cambio es modificar los datos que guardamos sobre atributos.
    /// 
    /// COLABORACIONES: No colabora con ninguna otra clase.
    /// </summary>
    public class Attribute
    {

        public Attribute(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        private string key;
        private string value;
        public string Key
        {
            get
            {
                return this.key;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.key = value;
                }
            }
        }
        public string Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.value = value;
                }
            }
        }
    }
}
