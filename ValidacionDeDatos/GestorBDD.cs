using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    internal class GestorBDD
    {




        /*
        public EstudianteBDD MappeaEntidad(Estudiante unEstudiante)
        {
            if (unEstudiante is not null)
            {
                EstudianteBDD estuBDD= EstudianteBDD.CreaInstanciaEstudiante(unEstudiante.CodigoEstudiante,unEstudiante.Nombre,unEstudiante.Apellido,unEstudiante.Dni);
                List<CursoBDD> cursos = MappeaCursos(unEstudiante.MateriasAnotadas);
                List<ClaseEstudianteCurso> estuCursos = MappeaEstudianteCurso(cursos, unEstudiante.Dni);
                //mandarlos a la base de datos


            }
        }
        */
        private  List<CursoBDD> MappeaCursos(List<Curso> cursos)
        {
            List<CursoBDD> cursosBDD = new List<CursoBDD>();
            if (cursos is not null)
            {
                foreach (var item in cursos)
                {
                    if (item is not null)
                    {
                        CursoBDD cursoBDD = CursoBDD.CreaInstanciaCurso(item.CodigoCurso, item.NombreCurso, item.CargaHoraria, item.NumeroAula, item.CupoMaximo, item.Descripcion);
                        cursosBDD.Add(cursoBDD);
                    }
                }
            }
             return cursosBDD;
        }
        private List<ClaseEstudianteCurso> MappeaEstudianteCurso(List<CursoBDD> lista, int dni)
        {
            List<ClaseEstudianteCurso> list = new List<ClaseEstudianteCurso>();
            if (lista is not null)
            {
                foreach (var item in lista)
                {
                    if (item is not null)
                    {
                        ClaseEstudianteCurso claseEstuCurso = ClaseEstudianteCurso.CreaInstaciaEstudianteCurso(dni, item.id_CodigoMateria);
                        list.Add(claseEstuCurso);
                    }
                }
            }
            return list;
        }
    }
}
