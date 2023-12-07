using System.Runtime.Serialization;

namespace formEntradaUsuario
{
    [Serializable]
    internal class NoHayEstudiantesRegistradosException : Exception
    {
        public NoHayEstudiantesRegistradosException()
        {
        }

        public NoHayEstudiantesRegistradosException(string? message) : base(message)
        {
        }

        public NoHayEstudiantesRegistradosException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoHayEstudiantesRegistradosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}