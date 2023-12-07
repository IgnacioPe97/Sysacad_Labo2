using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Horario
    {
        private int codigoHorario;
        private string dia;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;

        public string Dia { get => dia; set => dia = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public TimeSpan HoraFin { get => horaFin; set => horaFin = value; }
        public int CodigoHorario { get => codigoHorario; set => codigoHorario = value; }

        public Horario(string dia, TimeSpan horaInit, TimeSpan horaEnd)
        {
            codigoHorario = GenerarCodigoUnico();
            Dia = dia;
            HoraInicio = horaInit;
            HoraFin = horaEnd;       
        }
        public Horario()
        {
                
        }
        private int GenerarCodigoUnico()
        {
            Random random = new Random();
            return random.Next(10, 51);
        }

    }
   
}
