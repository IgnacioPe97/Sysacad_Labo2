using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Pagos
    {
        private Meses mes;
        private bool estaPago;
        private int valorCuota;
        private bool estaPagaMatricula;
        private const int valor = 25000;
        private const int valorMatricula = 10000;


        public Pagos(Meses mes, bool estaPago)
        {
            this.Mes = mes;
            this.EstaPago = estaPago;
            this.estaPagaMatricula = false;
            this.GeneraValorDeCuota();
        }

        public Meses Mes { get => mes; set => mes = value; }
        public bool EstaPago { get => estaPago; set => estaPago = value; }
        public int ValorCuota { get => valorCuota; set => valorCuota = value;}
        private void GeneraValorDeCuota()
        {
            if (this.Mes == Meses.Matricula)
            {
                this.valorCuota = valorMatricula;
            }
            else
            {
                this.valorCuota = valor;
            }

        }
        /*
        public static Pagos RetornaPagosEstudiante 
        */
    }
}
