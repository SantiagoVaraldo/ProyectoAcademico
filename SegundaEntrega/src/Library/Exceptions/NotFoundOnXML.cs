/// <summary>
/// NOMBRE: NotFoundOnXML
/// 
/// DESCRIPCION: la idea es implementar este tipo de exepcion para cuando buscamos en el XML,
/// la exepcion es para el caso de que no se encuentre lo que se busca.
/// </summary>

namespace Library
{
    public class NotFoundOnXML : System.Exception
    {
        public NotFoundOnXML() { }
        public NotFoundOnXML(string message) : base(message) { }
        public NotFoundOnXML(string message, System.Exception inner) : base(message, inner) { }
        protected NotFoundOnXML(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}