using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public interface IReporteGenerador<T>
    {
        void GenerarReporte(List<T> data,string filePath);
    }
}
