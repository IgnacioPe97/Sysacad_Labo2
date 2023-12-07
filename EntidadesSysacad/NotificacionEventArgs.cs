using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public class NotificacionEventArgs: EventArgs
    {
        public string Mensaje { get; set; }
        public NotificacionEventArgs(string mensaje)
        {
                Mensaje = mensaje;
        }
    }
}
