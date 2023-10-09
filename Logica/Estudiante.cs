using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Estudiante : Persona
    {
        protected static int proximoId = 1;
        private int dni;
        private int telefono;
        private string direccion;
        private string preferenciaCarrera;
        private int cantidadMaterias;
        private Turnos turnoSeleccionado;
        private List<Curso> materiasAnotadas;
        private bool tienePermisos;
        private int codigoEstudiante;
        private bool cambiarContrasenia;
        private const int cantidadMaximaMaterias = 5;
        private List<Pagos> cuotasDelEstudiante;

        internal int Dni { get => dni; set => dni = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        protected string PreferenciaCarrera { get => preferenciaCarrera; set => preferenciaCarrera = value; }
        public List<Curso> MateriasAnotadas { get => materiasAnotadas; set => materiasAnotadas = value; }
        public bool TienePermisos { get => tienePermisos; private set => tienePermisos = value; }
        public bool CambiarContrasenia { get => cambiarContrasenia; set => cambiarContrasenia = value; }
        public Turnos TurnoSeleccionado { get => turnoSeleccionado; set => turnoSeleccionado = value; }
        public int CodigoEstudiante { get => codigoEstudiante; set => codigoEstudiante = value; }
        public List<Pagos> CuotasDelEstudiante { get => cuotasDelEstudiante; set => cuotasDelEstudiante = value; }

        public Estudiante()
        {

        }

        public Estudiante(string nombre, string apellido, string correo, string contra, int dni, int telefono, string direccion, bool cambiaContra, Turnos preferenciaDeTurno) : base(nombre, apellido, correo, contra)
        {
            this.Dni = dni;
            this.Telefono = telefono;
            this.Direccion = direccion;
            CambiarContrasenia = cambiaContra;
            materiasAnotadas = new List<Curso>();
            CodigoEstudiante = proximoId;
            TienePermisos = false;
            cantidadMaterias = 0;
            proximoId++;
            this.materiasAnotadas = new List<Curso>(); 
            this.TurnoSeleccionado = preferenciaDeTurno;
            this.cuotasDelEstudiante = new List<Pagos>();
            this.CargarDeuda();

        }

        public Estudiante(string nombre, string apellido, string correo, string contra, int dni, int telefono, string direccion, string carrera, bool cambiaContra, Turnos preferenciaDeTurno) : base(nombre, apellido, correo, contra)
        {
            this.Dni = dni;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.CambiarContrasenia = cambiaContra;
            this.PreferenciaCarrera = carrera;
            this.TurnoSeleccionado = preferenciaDeTurno;
            this.materiasAnotadas = new List<Curso>();
            this.CodigoEstudiante = proximoId;
            this.TienePermisos = false;
            this.cantidadMaterias = 0;
            proximoId++;
            this.cuotasDelEstudiante = new List<Pagos>();
            this.CargarDeuda();

        }
        
        /// <summary>
        /// Carga las deudas de los estudiantes creados
        /// </summary>
        private void CargarDeuda()
        {
            Pagos cuotaUno = new Pagos(Meses.Marzo, false);
            Pagos cuotaDos = new Pagos(Meses.Abril, false);
            Pagos cuotaTres = new Pagos(Meses.Mayo, false);
            Pagos cuotaCuatro = new Pagos(Meses.Junio, false);
            Pagos cuotaCinco = new Pagos(Meses.Julio, false);
            Pagos cuotaSeis = new Pagos(Meses.Agosto, false);
            Pagos cuotaSiete = new Pagos(Meses.Septiembre, false);
            Pagos cuotaOcho = new Pagos(Meses.Octubre, false);
            Pagos cuotaNueve = new Pagos(Meses.Noviembre, false);
            Pagos cuotaDiez = new Pagos(Meses.Diciembre, false);
            Pagos cuotaOnce = new Pagos(Meses.Enero, false);
            Pagos cuotaDoce = new Pagos(Meses.Febrero, false);
            Pagos cuotaMatricula = new Pagos(Meses.Matricula, false);
            CuotasDelEstudiante.Add(cuotaUno);
            CuotasDelEstudiante.Add(cuotaDos);
            CuotasDelEstudiante.Add(cuotaTres);
            CuotasDelEstudiante.Add(cuotaCuatro);
            CuotasDelEstudiante.Add(cuotaCinco);
            CuotasDelEstudiante.Add(cuotaSeis);
            CuotasDelEstudiante.Add(cuotaSiete);
            CuotasDelEstudiante.Add(cuotaOcho);
            CuotasDelEstudiante.Add(cuotaNueve);
            CuotasDelEstudiante.Add(cuotaDiez);
            CuotasDelEstudiante.Add(cuotaOnce);
            CuotasDelEstudiante.Add(cuotaDoce);
            CuotasDelEstudiante.Add(cuotaMatricula);


        }

        /// <summary>
        /// permite tomar una cuota elegida y pasarla de no paga a paga
        /// </summary>
        /// <param name="unMes">Mes elegido a pagar</param>
        /// <returns></returns>
        public bool PagarCuota(Meses unMes)
        {
            foreach (Pagos item in this.CuotasDelEstudiante)
            {
                if (item.Mes == unMes)
                {
                    if (item.EstaPago)
                    {
                        return false;
                    }
                    item.EstaPago = true;
                    break;
                }
            }
            return true;
        }

        /// <summary>
        /// asigna un alumno a un curso seleccionado
        /// </summary>
        /// <param name="unCurso">curso seleccionado</param>
        /// <returns></returns>
        public bool AgregaMateriaParaAlumno(Curso unCurso)
        {
            if (this.cantidadMaterias < cantidadMaximaMaterias && VerificaNoEstarAnotadoEnMateria(unCurso))
            {
                materiasAnotadas.Add(unCurso);
                cantidadMaterias++;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica que un alumno no este anotado en esa materia, 
        /// </summary>
        /// <param name="unCurso">curso para verificar</param>
        /// <returns></returns>
        private bool VerificaNoEstarAnotadoEnMateria(Curso unCurso)
        {
            foreach (Curso cursoAnotado in materiasAnotadas)
            {
                if (cursoAnotado.CodigoCurso.Equals(unCurso.CodigoCurso) || cantidadMaterias > cantidadMaximaMaterias)
                {
                    return false;
                }
            }
            return true;
        }
    /// <summary>
    /// Muestra los datos de las materias anotadas de ese alumno
    /// </summary>
    /// <returns></returns>
        public string MuestraMateriasConHorarios()
        {
            StringBuilder sb = new StringBuilder();
            if (this.MateriasAnotadas.Count > 0)
            {
                foreach (Curso curso in MateriasAnotadas)
                {
                    sb.Append(curso.NombreCurso + " - ");

                    foreach (Horario horario in curso.Horario)
                    {
                        sb.Append(horario.Dia + ": " + horario.HoraInicio.ToString() + " a " + horario.HoraFin.ToString() + ", ");
                    }

                    sb.AppendLine("Aula N° " + curso.NumeroAula.ToString());
                }
            }
            else
            {
                sb.AppendLine("Sin materias anotadas");
            }
            return sb.ToString();
          
        }
        /// <summary>
        /// Transforma un estudiante json desde los archivos a un estudiante 
        /// </summary>
        /// <param name="estuJson">el estudiante a transformar</param>
        /// <param name="cursos"> cursos anotados</param>
        /// <returns></returns>
        public static Estudiante ModificaEstudianteJsonAEstudiante(EstudianteJson estuJson,List<Curso>cursos)
        {
            Estudiante estudiante = new Estudiante
            {
                Nombre = estuJson.Nombre,
                Apellido = estuJson.Apellido,
                dni = estuJson.Dni,
                telefono = estuJson.Telefono,
                Direccion = estuJson.Direccion,
                TurnoSeleccionado = estuJson.TurnoSeleccionado,
                MateriasAnotadas = Curso.RetornaCursoPorCodigoIdentificador(cursos, estuJson),
                CodigoEstudiante = estuJson.CodigoEstudiante,
                CuotasDelEstudiante = estuJson.ListaPagos,
            
            };
            return estudiante;
        }
        public static List<Estudiante> RetornaListaEstudiantesModificadaDeJson(List<EstudianteJson> lista, List<Curso> cursos)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            if (lista is not null && cursos is not null)
            {
                foreach (EstudianteJson item in lista)
                {
                    Estudiante estudiante = ModificaEstudianteJsonAEstudiante(item, cursos);
                    if (estudiante is not null)
                    {
                        listaEstudiantes.Add(estudiante);
                    }
                }
            }
            return listaEstudiantes;
        }
        public static Estudiante DevuelveEstudianteRandomDeLista(List<Estudiante> lista)
        {
            if (lista == null)
            {
                throw new Excepciones("La lista esta vacia");
            }
            Random rand = new Random();
            int indiceAleatorio = rand.Next(0, lista.Count);
            return lista[indiceAleatorio];

        } 

    }
}
