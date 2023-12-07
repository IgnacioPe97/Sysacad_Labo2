using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    internal class CursoBDD
    {
        public int id_CodigoMateria { get; private set; }
        public string nombreMateria { get; private set; }
        public int cargaHoraria { get; private set; }
        public int numeroAula { get; private set;}
        public  int cupoMaximo { get; private set; }
        public string descrpcion { get; private set; }

        private CursoBDD(int id, string nombre, int carga, int aula, int cupo, string descripcion)
        {
            this.id_CodigoMateria = id;
            this.nombreMateria = nombre;
            this.cargaHoraria = carga;
            this.numeroAula = aula;
            this.cupoMaximo = cupo;
            this.descrpcion = descripcion;     
        }

        public static CursoBDD CreaInstanciaCurso(int id, string nombre, int carga, int aula, int cupo, string descripcion)
        {
            return new CursoBDD(id, nombre, carga, aula, cupo, descripcion);
        }

    }
}
