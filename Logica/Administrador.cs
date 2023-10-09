using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Administrador: Persona
    {
        protected bool _tienePermisos;

        public Administrador()
        {
                
        }
        public Administrador(string nombre, string apellido, string correo, string contra) : base(nombre, apellido, correo, contra)
        {
            _tienePermisos = true;
        }
        public static Administrador DevuelveUnAdministrador(List<Administrador> lista, string mail, string contrasenia)
        {
            foreach (Administrador administrador in lista)
            {
                if (administrador.Correo == mail && administrador.Contrasenia == contrasenia)
                {
                    return administrador;
                }
            }
            return null;
        }
    }
}
