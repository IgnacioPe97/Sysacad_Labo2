using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public static  class GestorPadre
    {
        static List<Persona> unaEntidad = new List<Persona>();
        static Serializacion archivo = new Serializacion();

        public static  void AgregarEntidad(Persona unaPersona)
        {
            unaEntidad.Add(unaPersona);
            archivo.SerializarUnaLista(unaEntidad, "Personas.json");

        }
        

        public static  void EliminarEntidad(Persona unaPersona)
        {
            unaEntidad.Remove(unaPersona);
        }
       

        public static  List<Persona> ObtenerListaDeEntidad()
        {
            return unaEntidad;
        }
        public static  bool ObtieneListaDeArchivo(string nombreArchivo)
        {
            bool retorno = false;
            if (nombreArchivo is not null)
            {
                unaEntidad = archivo.DeserializarUnaLista<Persona>(nombreArchivo);
                retorno = true;
            }
            return retorno;
        }
        public static  void ModificaEntidad(Persona personaModificada)
        {
            foreach (Persona item in unaEntidad)
            {
                

            }
        }
       
    }
}
