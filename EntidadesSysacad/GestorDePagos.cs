using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public static class GestorDePagos
    {
        static List<PagosRealizadosPorUsuario> listaPagos;
        static Serializacion serializar;
        private const string  nombreArchivo = "ListaPagosUsuario.Json";

        static GestorDePagos()
        {
            serializar = new Serializacion();
            ObtieneListaDeArchivos();

        }
        public static void AgregaPagoAListaPagosRealizados(PagosRealizadosPorUsuario unPago)
        {
            if (unPago is not null)
            {
                listaPagos.Add(unPago);
            }
        }

        public static void GuardaListaDePagos()
        {
            if (listaPagos is not null)
            {
             serializar.SerializarUnaLista(listaPagos,nombreArchivo);

            }
        }
        public static void ObtieneListaDeArchivos()
        {
            listaPagos = serializar.DeserializarUnaLista<PagosRealizadosPorUsuario>(nombreArchivo);

        }

        public static List<PagosRealizadosPorUsuario> ObtieneListaPagosDeUsuarios(DateTime inicio, DateTime final)
        {
            List<PagosRealizadosPorUsuario> pagos = new List<PagosRealizadosPorUsuario>();
            foreach (PagosRealizadosPorUsuario item in listaPagos)
            {
                if (item.FechaDePago <= inicio && item.FechaDePago <= final)
                {
                    pagos.Add(item);
                }
            }
            return pagos;
        }

    }
}
