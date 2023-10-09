using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    internal class Excepciones: Exception
    {


        public Excepciones(string mensaje) : base(mensaje)
        {
            
        }
    }
}
