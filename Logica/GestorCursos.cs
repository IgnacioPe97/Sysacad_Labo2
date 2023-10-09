using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public static class GestorCursos 
    {
        private static List<Curso> listaCursos = new List<Curso>();
        private static List<Curso> listaCursosAuxiliar = new List<Curso>();
        static Serializacion escrituraArchivo = new Serializacion();


        public static void AgregarCurso(Curso unCurso)
        {
            listaCursos.Add(unCurso);
            escrituraArchivo.SerializarUnaLista(listaCursos, "Cursos.json");
        }

        public static void EliminaCurso(Curso curso)
        {
            listaCursosAuxiliar = listaCursos;
            listaCursos.Remove(curso);
            escrituraArchivo.SerializarUnaLista(listaCursos, "Cursos.json");
            escrituraArchivo.SerializarUnaLista(listaCursosAuxiliar, "ListaCursosAnterior.json");

        }
        public static List<Curso> ObtieneListaCursos()
        {
            return listaCursos;
        }
        public static bool ObtieneListaDeArchivo(string nombreArchivo)
        {
            bool retorno = false;
            if (nombreArchivo is not null)
            {
                listaCursos = escrituraArchivo.DeserializarUnaLista<Curso>(nombreArchivo);
                retorno = true;
            }
            return retorno;
        }
        public static void CargaListaGestor(List<Curso> lista)
        {
            listaCursosAuxiliar = listaCursos;
            listaCursos = lista;
        }


        public static void GuardaListaCursosEnArchivo()
        {
            escrituraArchivo.SerializarUnaLista<Curso>(listaCursos, "Cursos.json");
            escrituraArchivo.SerializarUnaLista<Curso>(listaCursosAuxiliar, "ListaCursosAnterior.json");

        }

    }
}
