using EntidadesSysacad;

namespace LogicaDeNegocio
{
    public static class GestorCursos 
    {
        private static List<Curso> listaCursos;
        private static List<CursoJson> listaCursosJson;
        static Serializacion escrituraArchivo;

        static GestorCursos()
        {
            listaCursos = new List<Curso>();
            escrituraArchivo = new Serializacion();
            ObtieneListaDeArchivo();
            
        }
        public static void AgregarCurso(Curso unCurso)
        {
            CursoJson cursoJ = CursoJson.ConvertirACursoJson(unCurso);
            if (cursoJ is not null)
            {
                CursoDB cursodb = new CursoDB();
                cursodb.Add(cursoJ);
            }
        }

        public static void EliminaCurso(Curso curso)
        {
            CursoJson cursoJ = CursoJson.ConvertirACursoJson(curso);
            if (cursoJ is not null)
            { 
                CursoDB cursoDB = new CursoDB();
                cursoDB.Delete(cursoJ);
            }
        }

        public static void ModificaCurso(Curso curso)
        {
            CursoJson cursoJ = CursoJson.ConvertirACursoJson(curso);
            if (cursoJ is not null)
            {
                CursoDB cursoDB = new CursoDB();
                cursoDB.Update(cursoJ);
            }
        }

        public static List<Curso> ObtieneListaCursos()
        {
            CursoDB curso = new CursoDB();
            listaCursos = curso.GetAll();
            return listaCursos;
        }
        public static void ObtieneListaDeArchivo()
        {
           
           // listaCursosJson = escrituraArchivo.DeserializarListaDeCursos();
           // listaCursos = CursoJson.RetornaListaCursos(listaCursosJson);
        }
        public static void CargaListaGestor(List<Curso> lista)
        {
            listaCursos = lista;
        }


        public static void GuardaListaCursosEnArchivo()
        {
            List<CursoJson> listaJson = new List<CursoJson>();
            listaJson = CursoJson.CargaListaCursosJson(listaCursos);
            if (listaJson is not null)
            {
                foreach (CursoJson item in listaJson)
                {
                    CursoDB cursoDB = new CursoDB();
                    if (item is not null)
                    {
                        cursoDB.Add(item);
                    }
                }
                escrituraArchivo.SerializarUnaLista(listaJson, "CursosJson.json");
            }
        }

    }
}
