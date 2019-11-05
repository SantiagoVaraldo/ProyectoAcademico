using System.Collections.Generic;

namespace ExerciseOne
{
    /// <summary>
    /// NOMBRE: Tag.
    /// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los tags.
    /// 
    /// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
    /// pertinente para nuestros requisitos de crear objetos Tag, conoce el nombre de un Tag y una lista de
    ///  objetos Attribute.
    /// 
    /// SRP: Esta clase presenta una unica responsabilidad que es conocer la informacion
    /// de tags, su unica razon de cambio es modificar los datos que guardamos sobre tags.
    /// 
    /// COLABORACIONES: Colabora con la clase Attribute ya que debe conocer una lista 
    /// de objetos Attribute.
    /// </summary>
    public class Tag
    {
        public Tag(string Name, Dictionary<string, Attribute> attributeList)
        {
            this.Name = Name;
            this.attributeList = attributeList;
        }
        public Tag(string Name)
        {
            this.Name = Name;
            this.attributeList = null;
        }

        private Dictionary<string, Attribute> attributeList = new Dictionary<string, Attribute>();
        public Dictionary<string, Attribute> AttributeList
        {
            get { return this.attributeList; }
            //set { this.attributeList = value; }
        }
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public void AddAttribute(Attribute attribute)
        {
            if (this.attributeList == null)
            {
                this.attributeList = new Dictionary<string, Attribute>();
            }
            this.attributeList.Add(attribute.Key, attribute);
        }
    }
}
