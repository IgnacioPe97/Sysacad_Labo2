using System.Runtime.Serialization;

namespace LogicaDeNegocio
{
    [Serializable]
    internal class ErrorAlAbrirArchivoJsonException : Exception
    {
        public ErrorAlAbrirArchivoJsonException(string? message) : base(message)
        {
        }
        public ErrorAlAbrirArchivoJsonException( ) : base("No Existe ruta de archivo")
        {
        }




    }
}