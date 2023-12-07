using System.Runtime.Serialization;

namespace formEntradaUsuario
{
    [Serializable]
    internal class NoHayEstudiantesRegistradosException : Exception
    {
        
        public NoHayEstudiantesRegistradosException(string? message) : base(message)
        {
        }
        public NoHayEstudiantesRegistradosException() : base("No hay estudiantes registrados")
        {
        }




    }
}