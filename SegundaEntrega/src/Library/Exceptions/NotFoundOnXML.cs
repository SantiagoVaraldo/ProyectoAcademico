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