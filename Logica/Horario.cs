using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Horario
    {
        private string dia;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;

        public string Dia { get => dia; set => dia = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public TimeSpan HoraFin { get => horaFin; set => horaFin = value; }

        public Horario(string dia, TimeSpan horaInit, TimeSpan horaEnd)
        {
            Dia = dia;
            HoraInicio = horaInit;
            HoraFin = horaEnd;       
        }
        public Horario()
        {
                
        }

    }
   
}
