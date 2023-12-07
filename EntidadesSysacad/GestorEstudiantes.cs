using CapaDatos;
using EntidadesSysacad;

namespace LogicaDeNegocio
{
    public static class GestorEstudiantes
    {
        static List<Estudiante> estudiantes;
        static Serializacion archivo ;
        static List<EstudianteJson> estudiantesJson ;
        static List<ListaEsperaDeCurso> listaEsperaEstudiantes;
        static GestorEstudiantes()
        {
            listaEsperaEstudiantes = new List<ListaEsperaDeCurso>();
            archivo = new Serializacion();
            estudiantesJson = new List<EstudianteJson>();
            estudiantes = new List<Estudiante>();
            EstudianteDB estu = new EstudianteDB();
            estudiantes = estu.GetAll();


            //  ObtieneListaDeArchivo(GestorCursos.ObtieneListaCursos());
        }
 
        public static Estudiante AutenticaEstudiante(string correo, string contra)
        {
            foreach (Estudiante item in estudiantes)
            {
                if (item.Correo == correo && Hash.ValidaContrasenia(contra,item.Contrasenia))
                {
                    return item;
                }
            }
            return null;
        }

        public static void AgregarEntidad(Persona unEstudiante)
        {

            EstudianteDB estudianteDB = new EstudianteDB();
            if (estudianteDB.Add((Estudiante)unEstudiante))
            {
                estudiantes.Add((Estudiante)unEstudiante);
                GestorPadre.AgregarEntidad(unEstudiante);
                if (ModificaEstudianteAEstudianteJson(estudiantes, estudiantesJson))
                {
                    archivo.SerializarUnaLista(estudiantesJson, "EstudiantesJson.json");
                }
            }
        }
        public static void AgregaAListaDeEspera(ListaEsperaDeCurso estudiante)
        {
            listaEsperaEstudiantes.Add(estudiante);
        }

        public static void EliminarEntidad(Persona unEstudiante)
        {
            EstudianteDB estudianteDB = new EstudianteDB();
            if (estudianteDB.Delete(((Estudiante)unEstudiante).Dni))
            {
                estudiantes.Remove((Estudiante)unEstudiante);
                if (ModificaEstudianteAEstudianteJson(estudiantes, estudiantesJson))
                {
                    archivo.SerializarUnaLista(estudiantesJson, "EstudiantesJson.json");
                }
            } 
        }

        public static bool ObtieneListaDeArchivo(List<Curso> cursos)
        {
            bool retorno = false;
            
            if (cursos is not null)
            {
                estudiantes = archivo.DeserializarUnaListaEstudianteJson<EstudianteJson>(cursos);
                retorno = true;
            }
            return retorno;
        }
        /*
       public static void ModificaAlumno(Estudiante estu)
        {
            EstudianteJson jota =EstudianteJson.ConvertirAEstudianteJson(estu);
            if (jota is not null)
            {
                EstudianteDB estudianteDB = new EstudianteDB();
                estudianteDB.Update(jota);
            }
        }
        */
      


        public static void GuardarListaEstudiantesEnArchivos()
        {
            
            /*
            if (ModificaEstudianteAEstudianteJson(estudiantes, estudiantesJsonOtra))
            {
                archivo.SerializarUnaLista(estudiantesJsonOtra, "EstudiantesJson.json");
            }
            */
        }
        public static void GuardaUnEstudianteEnArchivos(Estudiante unEstu,List<Curso>cursos)
        {
            string nombreArchivo = "EstudiantesJson.json";
            ObtieneListaDeArchivo(cursos);

            Estudiante estudianteExistente = estudiantes.Find(est => est.Dni == unEstu.Dni);
            if (estudianteExistente is not null)
            {
                GuardaListaEstudiantesEnArchivo();
            }
            else
            {
                GuardaListaEstudiantesEnArchivo();
            }
        }

        public static List<Estudiante> ObtenerListaDeEstudiante()
        {
            return estudiantes;
        }
        public static void GuardaListaEstudiantesEnArchivo()
        {
            archivo.SerializarUnaLista<Estudiante>(estudiantes, "Estudiantes.json");
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
        public static Estudiante RetornaEstudiantePorDni(int dni)
        {
            foreach (var item in estudiantes)
            {
                if (item.Dni == dni)
                {
                    return item;
                }
            }
            return null;
        }
        public static List<Estudiante> BuscaEstudiantePorFechaInscripcion(DateTime inicio, DateTime final)
        {
            List<Estudiante> listaDevuelta = new List<Estudiante>();
            foreach (Estudiante item in estudiantes)
            {
                if (item.FechaInscripcion >= inicio && item.FechaInscripcion <= final)
                {
                    listaDevuelta.Add(item);
                }
            }
            return listaDevuelta;
        }
        public static List<Estudiante> BuscaEstudiantesPorCarrera(Carreras carrera)
        {


            return estudiantes
                .Where(item => item.PreferenciaCarrera == (carrera))
                .ToList();
        }

        public static ListaEsperaDeCurso ObtieneListaDeEspera(int codigo)
        {
            foreach (ListaEsperaDeCurso item in listaEsperaEstudiantes)
            {
                if (item.CodigoListaEspera == codigo)
                {
                    return item;
                }
            }
            return null;
        }
        public static void GuardaListasDeEspera()
        {

            archivo.SerializarUnaLista(listaEsperaEstudiantes, "ListasDeEspera.Json");
        }
    }
}
