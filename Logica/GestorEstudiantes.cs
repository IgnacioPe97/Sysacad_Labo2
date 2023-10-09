using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public static class GestorEstudiantes
    {
        static List<Estudiante> estudiantes = new List<Estudiante>();
        static List<Estudiante> listaEstudiantesAuxiliar = new List<Estudiante>();
        static Serializacion archivo = new Serializacion();
        static List<EstudianteJson> estudiantesJson = new List<EstudianteJson>();
        static List<EstudianteJson> estudiantesJsonAux = new List<EstudianteJson>();


        public static void AgregarEntidad(Persona unEstudiante)
        {

            estudiantesJsonAux = estudiantesJson;
            estudiantes.Add((Estudiante)unEstudiante);
            GestorPadre.AgregarEntidad(unEstudiante);
            if (ModificaEstudianteAEstudianteJson(estudiantes, estudiantesJson))
            {
                archivo.SerializarUnaLista(estudiantesJson, "EstudiantesJsonAnterior.json");
                archivo.SerializarUnaLista(estudiantesJson, "EstudiantesJson.json");
            }
        }

        public static void EliminarEntidad(Persona unEstudiante)
        {

            estudiantesJsonAux = estudiantesJson;
            estudiantes.Remove((Estudiante)unEstudiante);
            if (ModificaEstudianteAEstudianteJson(estudiantes, estudiantesJson))
            {
                archivo.SerializarUnaLista(estudiantesJsonAux, "EstudiantesJsonAnterior.json");
                archivo.SerializarUnaLista(estudiantesJson, "EstudiantesJson.json");
            }
        }

        public static bool ObtieneListaDeArchivo(string nombreArchivo, List<Curso> cursos)
        {
            bool retorno = false;
            if (nombreArchivo is not null)
            {
                estudiantes = archivo.DeserializarUnaListaEstudianteJson<EstudianteJson>(nombreArchivo,cursos);
                retorno = true;
            }
            return retorno;
        }

    
        
        public static void GuardarListaEstudiantesEnArchivos()
        {
            List<EstudianteJson> estudiantesJsonOtra = new List<EstudianteJson>();
            if (ModificaEstudianteAEstudianteJson(estudiantes, estudiantesJsonOtra))
            {
                archivo.SerializarUnaLista(estudiantesJsonOtra, "EstudiantesJson.json");
            }
        }

        public static List<Estudiante> ObtenerListaDeEstudiante()
        {
            return estudiantes;
        }
        public static void GuardaListaEstudiantesEnArchivo()
        {
            archivo.SerializarUnaLista<Estudiante>(estudiantes, "Estudiantes.json");
            archivo.SerializarUnaLista<Estudiante>(listaEstudiantesAuxiliar, "ListaEstudiantesAnterior.json");
        }
        private static bool ModificaEstudianteAEstudianteJson(List<Estudiante> estudiantes,List<EstudianteJson>listaEstuJson)
        {
            bool retorno = false;
            foreach (Estudiante unEstudiante in estudiantes)
            {
                   EstudianteJson estudianteJson = EstudianteJson.ConvertirAEstudianteJson(unEstudiante);
                if (estudianteJson is not null)
                {
                    listaEstuJson.Add(estudianteJson);
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
