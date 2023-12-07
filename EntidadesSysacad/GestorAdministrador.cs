using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public static class GestorAdministrador
    {
        static List<Administrador> listaAdmin = new List<Administrador>();
        static List<Administrador> listaAdminAuxiliar = new List<Administrador>();
        static Serializacion archivo = new Serializacion();

        public static void AgregarEntidad(Persona unEstudiante)
        {
            listaAdmin.Add((Administrador)unEstudiante);
            GestorPadre.AgregarEntidad(unEstudiante);
            archivo.SerializarUnaLista(listaAdmin, "Administradores.json");
        }

        public static void EliminarEntidad(Persona unEstudiante)
        {
            listaAdminAuxiliar = listaAdmin;
            listaAdmin.Remove((Administrador)unEstudiante);
            archivo.SerializarUnaLista(listaAdmin, "Administradores.json");
            archivo.SerializarUnaLista(listaAdminAuxiliar, "AdministradoresListaAnterior.json");

        }
        public static bool ObtieneListaDeArchivo(string nombreArchivo)
        {
            bool retorno = false;
            if (nombreArchivo is not null)
            {
                listaAdmin = archivo.DeserializarUnaLista<Administrador>(nombreArchivo);
                retorno = true;
            }
            return retorno;
        }
        public static void CargaListaGestor(List<Administrador> lista)
        {
            listaAdmin = lista;
        }
        public static List<Administrador> ObtieneListaAdministradores()
        {
            return listaAdmin;
        }
        public static void GuardaListaEstudiantesEnArchivo()
        {
            archivo.SerializarUnaLista<Administrador>(listaAdmin, "Administradores.json");
            archivo.SerializarUnaLista<Administrador>(listaAdminAuxiliar, "ListaAdministradoresAnterior.json");
        }


    }
}
