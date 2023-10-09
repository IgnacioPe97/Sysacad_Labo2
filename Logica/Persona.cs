using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string correo;
        private string contrasenia;
        public Persona(string nombre, string apellido, string correo, string contra)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Contrasenia = contra;
        }
        public Persona()
        {
                
        }

        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
