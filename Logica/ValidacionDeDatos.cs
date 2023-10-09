using System.Text.RegularExpressions;

namespace LogicaDeNegocio
{
    public class ValidacionDeDatos
    {

        public bool ValidacionDeCorreo(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                return false;
            }
            return true;
        }

        public bool ValidacionDeUsuario(string email, string contrasenia)
        {
            return true;
        }
        public bool BuscaUsuarioYContraseniaEnListas(string email, string contrasenia)
        {
            return true;
        }
        public bool ValidaNombre(string nombre)
        {
            string patron = @"^[a-zA-Z\s]+$";

            if (!Regex.IsMatch(nombre, patron))
            {
                return false;
            }
            return true;
        }

        public bool EsTelefonoValido(string telefono)
        {
            string patron = @"^\d{7,10}$";
            return Regex.IsMatch(telefono, patron);
        }
        public bool EsDNIValido(string dni)
        {
            string patron = @"^\d{8}$";
            return Regex.IsMatch(dni, patron);
        }
        public bool EsDniUnico(List<Estudiante> lista, int dni)
        {
            foreach (Estudiante item in lista)
            {
                if (item.Dni == dni)
                {
                    return false;
                }
            }
            return true;
        }
        public bool EsCupoValido(int cantidad)
        {
            if (cantidad > 100 || cantidad < 0)
            {
                return false;
            }
            return true;
        }
        public bool EsValidoCantidadPalabras(string descripcion)
        {
            string[] palabras = descripcion.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (palabras.Length > 200)
            {
                return false;
            }
            return true;
        }

        public bool EsValidaCargaHoras(int carga)
        {
            if (carga > 8 || carga < 0)
            {
                return false;
            }
            return true;
        }

        public bool EsValidoCodigoCurso(List<Curso> cursos, int numeroCodigo)
        {

            foreach (Curso item in cursos)
            {
                if (numeroCodigo == item.CodigoCurso)
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsValidoNumeroTarjeta(string numeroTarjeta)
        {
            if (numeroTarjeta.Length < 13 || numeroTarjeta.Length > 19)
            {
                return false;
            }
            return true;
        }
        public bool ContieneSoloNumeros(string cadena)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(cadena);
        }
        public bool EsValidoCodigoTarjeta(string codigo)
        {
            if (codigo.Length > 4 || codigo.Length < 0)
            {
                return false;
            }
            return true;
        }


    }
}