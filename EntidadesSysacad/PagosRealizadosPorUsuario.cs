using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public class PagosRealizadosPorUsuario
    {
        private int dniEstudiante;
        private int pago;
        private DateTime fechaDePago;
        private Meses MesPago;

        public PagosRealizadosPorUsuario(int dniEstudiante, int pago, DateTime fechaDePago, Meses mesPago)
        {
            this.DniEstudiante = dniEstudiante;
            this.Pago = pago;
            this.FechaDePago = fechaDePago;
            MesPago1 = mesPago;
        }

        public int DniEstudiante { get => dniEstudiante; set => dniEstudiante = value; }
        public int Pago { get => pago; set => pago = value; }
        public DateTime FechaDePago { get => fechaDePago; set => fechaDePago = value; }
        public Meses MesPago1 { get => MesPago; set => MesPago = value; }
    }
}
