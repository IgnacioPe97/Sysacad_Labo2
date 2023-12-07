using CapaDatos;
using EntidadesSysacad;
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
        protected static int proximoId = 10;
        private int dni;
        private int telefono;
        private string direccion;
        private Carreras preferenciaCarrera;
        private int cantidadMaterias;
        private Turnos turnoSeleccionado;
        private List<Curso> materiasAnotadas;
        private bool tienePermisos;
        private int codigoEstudiante;
        private bool cambiarContrasenia;
        private const int cantidadMaximaMaterias = 5;
        private List<int> cuotasDelEstudiante;
        private DateTime fechaInscripcion;
        private Sistema _sistema;

        public int Dni { get => dni; private set => dni = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Curso> MateriasAnotadas { get => materiasAnotadas; set => materiasAnotadas = value; }
        public bool TienePermisos { get => tienePermisos; private set => tienePermisos = value; }
        public bool CambiarContrasenia { get => cambiarContrasenia; set => cambiarContrasenia = value; }
        public Turnos TurnoSeleccionado { get => turnoSeleccionado; set => turnoSeleccionado = value; }
        public int CodigoEstudiante { get => codigoEstudiante; private  set => codigoEstudiante = value; }
        public DateTime FechaInscripcion { get => fechaInscripcion; set => fechaInscripcion = value; }
        public Carreras PreferenciaCarrera { get => preferenciaCarrera; set => preferenciaCarrera = value; }
        public List<int> CuotasDelEstudiante { get => cuotasDelEstudiante; set => cuotasDelEstudiante = value; }

        public Estudiante()
        {

        }




        public Estudiante(string nombre, string apellido, string correo, string contra, int dni, int telefono, string direccion, bool cambiaContra, Turnos preferenciaDeTurno, Carreras carreraElegida, DateTime? fechaInscripcion = null) : base(nombre, apellido, correo, contra)
        {
            this.Dni = dni;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.CambiarContrasenia = cambiaContra;
            this.PreferenciaCarrera = carreraElegida;
            this.TurnoSeleccionado = preferenciaDeTurno;
            this.materiasAnotadas = new List<Curso>();
            this.CodigoEstudiante = Interlocked.Increment(ref proximoId);
            this.TienePermisos = false;
            this.cantidadMaterias = 0;
            this.CuotasDelEstudiante = new List<int>();

            this.FechaInscripcion = fechaInscripcion ?? DateTime.Now;
        }
        private void SimularInicioSesion()
        {
            // Supongamos que la fecha límite de inscripción es el 09/12/2023
            DateTime fechaLimiteInscripcion = new DateTime(2023, 12, 9);
            DateTime fechaActual = DateTime.Now;

            // Verificar si estamos cerca de la fecha límite
            int diasRestantes = (fechaLimiteInscripcion - fechaActual).Days;

            // Disparar el evento si estamos a menos de X días de la fecha límite
            if (diasRestantes <= 7) // Puedes ajustar el número de días según tus necesidades
            {
                // Activar el evento desde aquí
                _sistema.OnFechaLimiteInscripcion(new NotificacionEventArgs($"Quedan {diasRestantes} días para la fecha límite de inscripción a cursos."));
            }
        }
        /// <summary>
        /// Carga las deudas de los estudiantes creados
        /// </summary>
        public  void CargarDeuda()
        {
            Pagos cuotaUno = new Pagos(Meses.Marzo, false,Dni);
            Pagos cuotaDos = new Pagos(Meses.Abril, false, Dni);
            Pagos cuotaTres = new Pagos(Meses.Mayo, false, Dni);
            Pagos cuotaCuatro = new Pagos(Meses.Junio, false, Dni);
            Pagos cuotaCinco = new Pagos(Meses.Julio, false, Dni);
            Pagos cuotaSeis = new Pagos(Meses.Agosto, false, Dni);
            Pagos cuotaSiete = new Pagos(Meses.Septiembre, false, Dni);
            Pagos cuotaOcho = new Pagos(Meses.Octubre, false, Dni);
            Pagos cuotaNueve = new Pagos(Meses.Noviembre, false, Dni);
            Pagos cuotaDiez = new Pagos(Meses.Diciembre, false, Dni);
            Pagos cuotaOnce = new Pagos(Meses.Enero, false, Dni);
            Pagos cuotaDoce = new Pagos(Meses.Febrero, false, Dni);
            Pagos cuotaMatricula = new Pagos(Meses.Matricula, false, Dni);
            CuotasDelEstudiante.Add(cuotaUno.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaDos.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaTres.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaCuatro.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaCinco.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaSeis.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaSiete.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaOcho.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaNueve.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaDiez.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaOnce.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaDoce.CodigoDePago);
            CuotasDelEstudiante.Add(cuotaMatricula.CodigoDePago);
            List<Pagos> listaPagos = new List<Pagos>();
            listaPagos.Add(cuotaUno);
            listaPagos.Add(cuotaDos);
            listaPagos.Add(cuotaTres);
            listaPagos.Add(cuotaCuatro);
            listaPagos.Add(cuotaCinco);
            listaPagos.Add(cuotaSeis);
            listaPagos.Add(cuotaSiete);
            listaPagos.Add(cuotaOcho);
            listaPagos.Add(cuotaNueve);
            listaPagos.Add(cuotaDiez);
            listaPagos.Add(cuotaOnce);
            listaPagos.Add(cuotaDoce);
            listaPagos.Add(cuotaMatricula);
            EstudianteDB.GuardaListaPago(listaPagos);
        }

        /// <summary>
        /// permite tomar una cuota elegida y pasarla de no paga a paga
        /// </summary>
        /// <param name="unMes">Mes elegido a pagar</param>
        /// <returns></returns>
        ///
         /*
        public bool PagarCuota(Meses unMes)
        {
            foreach (int item in this.CuotasDelEstudiante)
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
         */
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
                if (cursoAnotado.CodigoCurso.Equals(unCurso.CodigoCurso) || cantidadMaterias >= cantidadMaximaMaterias)
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
    ///
    /*
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
        */
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
                Contrasenia = estuJson.Contrasenia,
                Correo = estuJson.Correo,
                TurnoSeleccionado = estuJson.TurnoSeleccionado,
                PreferenciaCarrera = estuJson.CarreraElegida,
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
        public static List<Estudiante> DevuelveEstudiantePorListaDeDni(List<int> lista)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            foreach (var item in lista)
            {
                Estudiante estu = GestorEstudiantes.RetornaEstudiantePorDni(item);
                if (estu is not null)
                {
                    estudiantes.Add(estu);
                }
            }
            return estudiantes;
        }
     
     

    }
}
