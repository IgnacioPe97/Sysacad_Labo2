using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public class Profesores
    {
        private string nombre;
        private string apellido;
        private int numeroIdentificador;
        private string correo;
        private string contrasenia;
        private int telefono; 
        private int codigosMaterias;

        public Profesores(string nombre, string apellido, string correo,string contra ,int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroIdentificador = GenerarCodigoUnico(); 
            this.correo = correo;
            this.Contrasenia = contra;
            this.telefono = telefono;
            CodigosMaterias = 0;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumeroIdentificador { get => numeroIdentificador; set => numeroIdentificador = value; }
        public string Correo { get => correo; set => correo = value; }
     
        public int Telefono { get => telefono; set => telefono = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public int CodigosMaterias { get => codigosMaterias; set => codigosMaterias = value; }

        public bool AgregaMateriaAProfesor(int codigoMateria)
        {
            if (codigoMateria > 0)
            {
                this.codigosMaterias = codigoMateria; 
                return true;
            }
            return false;

        }
        private int GenerarCodigoUnico()
        {
            Random random = new Random();
            return random.Next(100, 201);
        }
    }
}
