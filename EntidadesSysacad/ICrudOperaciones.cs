using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal interface ICrudOperaciones<T> where T : class
    {
        bool Add(T data);
        bool Delete(T data); //depende el comnportamiento que querramos, int cantidad de filas afectadas
        bool Delete(int i);
        bool Update(T data);
        List<T> GetAll();
        object GetOne(int codigo);

    }
}
