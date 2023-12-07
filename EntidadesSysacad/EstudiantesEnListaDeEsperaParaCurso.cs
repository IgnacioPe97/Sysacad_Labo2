using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public class EstudiantesEnListaDeEsperaParaCurso: IEquatable<EstudiantesEnListaDeEsperaParaCurso>
    {
        private DateTime diaInscripcion;
        private int dniEstudiante;

        public EstudiantesEnListaDeEsperaParaCurso(DateTime diaInscripcion, int dniEstudiante)
        {
            this.DiaInscripcion = diaInscripcion;
            this.DniEstudiante = dniEstudiante;
        }

        public DateTime DiaInscripcion { get => diaInscripcion; set => diaInscripcion = value; }
        public int DniEstudiante { get => dniEstudiante; set => dniEstudiante = value; }
        public bool Equals(EstudiantesEnListaDeEsperaParaCurso other)
        {
            // Comparar por el DniEstudiante
            return other != null && this.DniEstudiante == other.DniEstudiante;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as EstudiantesEnListaDeEsperaParaCurso);
        }

        public override int GetHashCode()
        {
            return DniEstudiante.GetHashCode();
        }

    }
}
