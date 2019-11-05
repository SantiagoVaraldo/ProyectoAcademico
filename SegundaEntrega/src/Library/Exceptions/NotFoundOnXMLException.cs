//--------------------------------------------------------------------------------
// <copyright file="NotFoundOnXMLException.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library
{
    /// <summary>
    /// NOMBRE: NotFoundOnXMLException
    ///
    /// DESCRIPCION: la idea es implementar este tipo de exepcion para cuando buscamos en el XML,
    /// la exepcion es para el caso de que no se encuentre lo que se busca.
    /// </summary>
    public class NotFoundOnXMLException : System.Exception
    {
        public NotFoundOnXMLException()
        {
        }

        public NotFoundOnXMLException(string message)
        : base(message)
        {
        }

        public NotFoundOnXMLException(string message, System.Exception inner)
        : base(message, inner)
        {
        }

        protected NotFoundOnXMLException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}