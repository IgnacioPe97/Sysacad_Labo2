using CapaDatos;
using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public class CursoJson
    {
        private string nombreCurso;
        private int cupoMaximo;
        private int codigoCurso;
        private string descripcion;
        private int cargaHoraria;
        private int numeroAula;
        private List<int> dniAlumnos;
        private List<int>? horarios;
        private int? codigoProfesor;
        private int ?codigoRequisitos;

        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }
        public int CupoMaximo { get => cupoMaximo; set => cupoMaximo = value; }
        public int CodigoCurso { get => codigoCurso; set => codigoCurso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }
        public int NumeroAula { get => numeroAula; set => numeroAula = value; }
        public List<int> DniAlumnos { get => dniAlumnos; set => dniAlumnos = value; }
        public int? CodigoProfesor { get => codigoProfesor; set => codigoProfesor = value; }
        public int ?CodigoRequisitos { get => codigoRequisitos; set => codigoRequisitos = value; }
        public List<int> Horarios { get => horarios; set => horarios = value; }

        public CursoJson()
        {
        }

        public static CursoJson ConvertirACursoJson(Curso unCurso)
        {
            CursoJson cursoJson = new CursoJson
            {
                NombreCurso = unCurso.NombreCurso,
                CupoMaximo = unCurso.CupoMaximo,
                CodigoCurso = unCurso.CodigoCurso,
                Descripcion = unCurso.Descripcion,
                CargaHoraria = unCurso.CargaHoraria,
                NumeroAula = unCurso.NumeroAula,
                DniAlumnos = unCurso.Estudiantes,
                CodigoProfesor = unCurso.CodigoProfesorAsignado??0,
                CodigoRequisitos = unCurso.CodigoRequisitos??0,

            };return cursoJson;

        }


        public static  List<int> CargaListaConDni(List<Estudiante> estudiantes)
        {
            List<int> listaDni = new List<int>();
            foreach (Estudiante item in estudiantes)
            {
                if (item.Dni > 0)
                {
                    listaDni.Add(item.Dni);
                }
            }
            return listaDni;
        }
        public static List<CursoJson> CargaListaCursosJson(List<Curso> cursos)
        {
            List<CursoJson> cursosJson = new List<CursoJson>();
            foreach (Curso item in cursos)
            {
                CursoJson cursoJ = ConvertirACursoJson(item);
                if (cursoJ is not null )
                {
                    cursosJson.Add(cursoJ);
                }
            }
            return cursosJson;
        }
        public static Curso CasteaCursoJsonACurso(CursoJson curso)
        {
            Curso unCurso = new Curso
            {
                NombreCurso = curso.NombreCurso,
                CupoMaximo = curso.CupoMaximo,
                CodigoCurso = curso.CodigoCurso,
                Descripcion = curso.Descripcion,
                CargaHoraria = curso.CargaHoraria,
                NumeroAula = curso.NumeroAula,
                Horario = curso.Horarios,
                Estudiantes = curso.DniAlumnos,
            };return unCurso;
        }

        

        public static List<Curso> RetornaListaCursos(List<CursoJson> listaCursosJson)
        {
            List<Curso> listaCursos = new List<Curso>();
            foreach (CursoJson item in listaCursosJson)
            {
                Curso unCurso = CasteaCursoJsonACurso(item);
                if (unCurso is not null)
                {
                    listaCursos.Add(unCurso);
                }
            }
            return listaCursos;
        }
        private static List<Estudiante> RetornaListaEstudiante(List<int> dnis)
        {
            List<Estudiante>listaEstu = new List<Estudiante>();
            if (dnis is not null)
            {
                foreach (var item in dnis)
                {
                    Estudiante estu = GestorEstudiantes.RetornaEstudiantePorDni(item);
                    if (estu is not null)
                    {
                        listaEstu.Add(estu);
                    }
                }
            }
            return listaEstu;
        }
    

    }
}
