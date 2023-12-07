using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    internal class EstudianteBDD
    {
        public int Id_Alumno { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int DNI { get; private set; }
        public static EstudianteBDD estudianteBDD { get; private set; }


        private EstudianteBDD(int id_Alumno, string nombre, string apellido, int dni)
        {
            Id_Alumno = id_Alumno;
            Nombre = nombre;
            Apellido= apellido;
            DNI= dni;
        }
       public static EstudianteBDD CreaInstanciaEstudiante(int id, string nombre, string apellido, int dni)
        {
            estudianteBDD = new EstudianteBDD(id,nombre,apellido,dni);
            return estudianteBDD;
        }
    }
}
