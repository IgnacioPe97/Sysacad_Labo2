using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public class RequisitosAcademicosParaCurso
    {
        public int CodigoMateriasCorrelativas { get; set; }
        public int NivelCreditossAcumulados { get; set; }
        public double PromedioAcademico { get; set; }
        public bool TieneRequisitos { get; set; }
        public int codigoRequisito { get; set; }

        public RequisitosAcademicosParaCurso()
        {
                
        }
        public RequisitosAcademicosParaCurso(int materias, int creditos, double promedio)
        {
            this.CodigoMateriasCorrelativas = materias;
            this.NivelCreditossAcumulados = creditos;
            this.PromedioAcademico = promedio;
            TieneRequisitos = true;
            this.codigoRequisito = GenerarCodigoUnico();
        }
        private int GenerarCodigoUnico()
        {
            Random random = new Random();
            return random.Next(3000, 4001);
        }

    }
}
