using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public class GestorProfesores
    {

        private static List<Profesores> listaProfesores;

        static GestorProfesores()
        {
            listaProfesores = new List<Profesores>();
            ProfesoresDB db = new ProfesoresDB();
            listaProfesores=db.GetAll();
        }

        public  static bool VerificaDuplicidad(Profesores profe)
        {
            bool retorno = false;
            if (profe is not null)
            {
                ProfesoresDB profesoresDB = new ProfesoresDB();
                retorno = profesoresDB.PreguntaSiExisteProfesor(profe);
            }
            return retorno;
        }

        public static bool AgregaProfesor(Profesores unprofe)
        {
            if (unprofe is not null && VerificaDuplicidad(unprofe) == false)
            {
                ProfesoresDB profesoresDB = new ProfesoresDB();
                profesoresDB.Add(unprofe);
                return true;
            }
            return false;
        }

        public static bool ModificaProfesor(Profesores unprofe)
        {
            if (unprofe is not null)
            {
                ProfesoresDB profe = new ProfesoresDB();
                profe.Update(unprofe);
                return true;
            }
            return false;

        }
        public static bool VerificaCorreoDuplicado(string correo)
        {
            foreach (Profesores item in listaProfesores)
            {
                if (item.Correo == correo)
                {
                    return false;
                }
            }
            return true;
        }
        public static void AgregaProfesorALista(Profesores profe)
        {
            if (profe is not null)
            {
                listaProfesores.Add(profe);
            }
        }
        public static List<Profesores> ObtieneListaProfesores()
        {
            return listaProfesores;
        }
    }
}
