using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    internal class ClaseEstudianteCurso
    {
        public int id_Tabla { get; private set; }
        public int DniAlumno { get; private set; }
        public int Id_Curso {  get; private set; }

        private ClaseEstudianteCurso(int dni, int idCurso)
        {
            this.DniAlumno = dni;
            this.Id_Curso = idCurso;       
        }

        public static ClaseEstudianteCurso CreaInstaciaEstudianteCurso(int dni,int id_curso)
        {
            return new ClaseEstudianteCurso(dni, id_curso);

        }
    }
}
