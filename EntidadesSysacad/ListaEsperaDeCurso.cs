using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public class ListaEsperaDeCurso
    {
        private int codigoListaEspera;
        private List<EstudiantesEnListaDeEsperaParaCurso> Estudiantes;
        private int codigoCurso;

        public ListaEsperaDeCurso(int codigoCurso)
        {
            this.DniEstudiantes = new List<EstudiantesEnListaDeEsperaParaCurso>();
            this.codigoCurso = codigoCurso;
            codigoListaEspera = GenerarCodigoUnico();
        }

        public int CodigoCurso { get => codigoCurso; set => codigoCurso = value; }
        public int CodigoListaEspera { get => codigoListaEspera; set => codigoListaEspera = value; }
        public List<EstudiantesEnListaDeEsperaParaCurso> DniEstudiantes { get => Estudiantes1; set => Estudiantes1 = value; }
        public List<EstudiantesEnListaDeEsperaParaCurso> Estudiantes1 { get => Estudiantes; set => Estudiantes = value; }

        public static string ObtieneNombreCurso(int codigo)
        {
            List<Curso> listaCurso = GestorCursos.ObtieneListaCursos();
            Curso curso = listaCurso.FirstOrDefault(c => c.CodigoCurso == codigo);
            return curso != null ? curso.NombreCurso : "Curso no encontrado";
        }
        public static string ObtieneNombreEstudiante(int dni)
        {
            Estudiante estu = GestorEstudiantes.RetornaEstudiantePorDni(dni);
            return estu != null ? estu.Nombre + estu.Apellido : "Estudiante no encontrado";
        }
   
        public  void AgregaEstudianteAListaEspera(int dni)
        {
            EstudiantesEnListaDeEsperaParaCurso estudianteEspera = new EstudiantesEnListaDeEsperaParaCurso(DateTime.Now,dni);
            DniEstudiantes.Add(estudianteEspera);
        }
        public void EliminaEstudianteAListaEspera(int dni)
        {
            Estudiantes1.RemoveAll(estudiante => estudiante.DniEstudiante == dni);
        }
        private int GenerarCodigoUnico()
        {
            Random random = new Random();
            return random.Next(1000, 2001);
        }




    }
}
