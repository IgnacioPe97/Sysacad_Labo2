using EntidadesSysacad;

namespace LogicaDeNegocio
{
    public class Curso
    {
        private string nombreCurso;
        private int cupoMaximo;
        private int codigoCurso;
        private string descripcion;
        private int cargaHoraria;
        private int numeroAula;
        private int codigoListaEspera;
        private List<int>horario;
        private List<int> estudiantes;
        public int? CodigoRequisitos { get; set; }
        public int? CodigoProfesorAsignado { get; set; }

        private const int CargaDeHorario = 2;


        public static List<Horario> HorariosManana { get; set; }
        public static List<Horario> HorariosTarde { get; set; }
        public static List<Horario> HorariosNoche { get; set; }
        public static List<int> AulasOcupadas { get; } = new List<int>();
        /// <summary>
        /// Sobrecarga estatica que me carga las aulas fijas y horarios para cursada
        /// </summary>
        static Curso()
        {
            CargarAulasOcupadas(300, 320);
            CargaHorarios();
        }

     

        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }
        public int CupoMaximo { get => cupoMaximo; set => cupoMaximo = value; }
        public int CodigoCurso { get => codigoCurso; set => codigoCurso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }
        public int NumeroAula { get => numeroAula; set => numeroAula = value; }
        public List<int> Estudiantes
        {
            get
            {
                if (estudiantes == null)
                {
                    estudiantes = CursoDB.ObtenerEstudiantesAsociados(this.CodigoCurso);
                }
                return estudiantes;
            }
            set => estudiantes = value;
        }
        public List<int> Horario { get => horario; set => horario = value; }
        public int CodigoListaEspera { get => codigoListaEspera; set => codigoListaEspera = value; }
        

        public Curso(string nombreCurso, int cupoMaximo, int codigoCurso, string descripcion, int cargaHoraria)
        {
            this.NombreCurso = nombreCurso;
            this.CupoMaximo = cupoMaximo;
            this.CodigoCurso = codigoCurso;
            this.Descripcion = descripcion;
            this.CargaHoraria = cargaHoraria;
            this.CodigoListaEspera = 0;
            this.estudiantes = new List<int>();
            this.Horario = new List<int>();
            this.CodigoProfesorAsignado = 0;
            this.CodigoRequisitos = 0;
        }
        
        public Curso()
        {

        }

        /// <summary>
        /// Asigna aulas a una lista de aulas para ocupar
        /// </summary>
        /// <param name="desde">numero de aula mas bajo</param>
        /// <param name="hasta">num de aula mas alto</param>
        private static void CargarAulasOcupadas(int desde, int hasta)
        {
            for (int aula = desde; aula <= hasta; aula++)
            {
                AulasOcupadas.Add(aula);
            }
        }

        /// <summary>
        /// Carga horarios disponibles para las materias y sus turnos
        /// </summary>
        private static void CargaHorarios()
        {
            HorariosManana = new List<Horario>
            {
                new Horario ("Lunes",  new TimeSpan(8, 0, 0), new TimeSpan(10, 0, 0)) ,
                new Horario ("Lunes", new TimeSpan(10, 0, 0), new TimeSpan(12, 0, 0)),
                new Horario ("Martes", new TimeSpan(10, 0, 0), new TimeSpan(12, 0, 0)),
                new Horario ("Martes",  new TimeSpan(8, 0, 0), new TimeSpan(10, 0, 0)) ,
                new Horario ("Miercoles", new TimeSpan(10, 0, 0), new TimeSpan(12, 0, 0)),
                new Horario ("Miercoles",  new TimeSpan(8, 0, 0), new TimeSpan(10, 0, 0)) ,
                new Horario ("Jueves", new TimeSpan(10, 0, 0), new TimeSpan(12, 0, 0)),
                new Horario ("Jueves",  new TimeSpan(8, 0, 0), new TimeSpan(10, 0, 0)),
                new Horario ("Viernes",  new TimeSpan(8, 0, 0), new TimeSpan(10, 0, 0)),
                new Horario ("Viernes", new TimeSpan(10, 0, 0), new TimeSpan(12, 0, 0)),
            };
            HorariosTarde = new List<Horario>
            {
               new Horario ("Lunes",  new TimeSpan(14, 0, 0), new TimeSpan(16, 0, 0)) ,
                new Horario ("Lunes", new TimeSpan(16, 0, 0), new TimeSpan(18, 0, 0)),
                new Horario ("Martes", new TimeSpan(14, 0, 0), new TimeSpan(16, 0, 0)),
                new Horario ("Martes",  new TimeSpan(16, 0, 0), new TimeSpan(18, 0, 0)) ,
                new Horario ("Miercoles", new TimeSpan(14, 0, 0), new TimeSpan(16, 0, 0)),
                new Horario ("Miercoles",  new TimeSpan(16, 0, 0), new TimeSpan(18, 0, 0)) ,
                new Horario ("Jueves", new TimeSpan(14, 0, 0), new TimeSpan(16, 0, 0)),
                new Horario ("Jueves",  new TimeSpan(16, 0, 0), new TimeSpan(18, 0, 0)),
                new Horario ("Viernes",  new TimeSpan(14, 0, 0), new TimeSpan(16, 0, 0)),
                new Horario ("Viernes", new TimeSpan(16, 0, 0), new TimeSpan(18, 0, 0)),
            };
            HorariosNoche = new List<Horario>
            {
                new Horario ("Lunes",  new TimeSpan(18, 0, 0), new TimeSpan(20, 0, 0)) ,
                new Horario ("Lunes", new TimeSpan(20, 0, 0), new TimeSpan(22, 0, 0)),
                new Horario ("Martes", new TimeSpan(18, 0, 0), new TimeSpan(20, 0, 0)),
                new Horario ("Martes",  new TimeSpan(20, 0, 0), new TimeSpan(22, 0, 0)) ,
                new Horario ("Miercoles", new TimeSpan(18, 0, 0), new TimeSpan(20, 0, 0)),
                new Horario ("Miercoles",  new TimeSpan(20, 0, 0), new TimeSpan(22, 0, 0)) ,
                new Horario ("Jueves", new TimeSpan(18, 0, 0), new TimeSpan(20, 0, 0)),
                new Horario ("Jueves",  new TimeSpan(20, 0, 0), new TimeSpan(22, 0, 0)),
                new Horario ("Viernes",  new TimeSpan(18, 0, 0), new TimeSpan(20, 0, 0)),
                new Horario ("Viernes", new TimeSpan(20, 0, 0), new TimeSpan(22, 0, 0)),
            };
        }
        /// <summary>
        /// agrega estudiante a la lista de estudiantes de una materia
        /// </summary>
        /// <param name="unEstudiante"></param>
        /// <returns></returns>
        public bool AgregaEstudianteAMateria(Estudiante unEstudiante)
        {
            if (cupoMaximo  > 0 )
            {
                Estudiantes.Add(unEstudiante.Dni);
                cupoMaximo--;
                return true;
            }
            return false;
        }
        public bool EstudianteEstaAnotado(Estudiante unEstudiante)
        {
            foreach (int estudiante in this.Estudiantes)
            {
                if (estudiante.Equals(unEstudiante.Dni))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// asigna un aula para curso de forma aleatoria y la elimina de la lista
        /// </summary>
        /// <param name="unCurso"></param>
        /// <returns></returns>
        public bool AsignaAulaParaCurso(Curso unCurso)
        {
            bool retorno = false;
            if (unCurso.NumeroAula == 0)
            {
                List<int> aulasDisponibles = AulasOcupadas;

                if (aulasDisponibles.Count > 0)
                {
                    Random rand = new Random();
                    int indiceDeAula = rand.Next(0, aulasDisponibles.Count);
                    unCurso.NumeroAula = aulasDisponibles[indiceDeAula];
                    aulasDisponibles.RemoveAt(indiceDeAula);
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Asigna un horario para una materia dependiendo del turno que se haya elegido
        /// </summary>
        /// <param name="unCurso">curso elegido para darle horario</param>
        /// <param name="turno">turno elegido por el usuario</param>
        /// <returns></returns>
        public bool AsignaHorarioParaCurso(Curso unCurso, Turnos turno)
        {
            bool retorno = false;
            ;
            if (ObtenerHorariosParaTurno(unCurso,turno))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// obtiene la lista de turnos disponibles segun el horario
        /// </summary>
        /// <param name="curso"></param>
        /// <param name="turno"></param>
        /// <returns></returns>
        private bool ObtenerHorariosParaTurno(Curso curso, Turnos turno)
        {
            bool retorno = false;
            
                switch (turno)
                {
                    case Turnos.Maniana:
                        retorno = CargaHorarioManiana(curso);
                        break;
                    case Turnos.Tarde:
                        retorno = CargaHorarioTarde(curso);
                        break;
                    case Turnos.Noche:
                        retorno = CargaHorarioNoche(curso);
                        break;
                
            }
            return retorno;
          
        }

        /// <summary>
        /// Le carga horarios a la lista de horarios de ese curso, y hasta no cumplir las horas asignadas no deja de asignar
        /// </summary>
        /// <param name="unCurso"></param>
        /// <returns></returns>
        private bool CargaHorarioManiana(Curso unCurso)
        {
            List<Horario> listaTurnoManana = HorariosManana;
            Random rand = new Random();
            Horario horario = new Horario();
            int horasAsignadas = 0;
            while (!(horasAsignadas == unCurso.CargaHoraria))
            {
                if (listaTurnoManana.Count == 0)
                {
                    return false;
                }
                int indiceHorario = rand.Next(0, listaTurnoManana.Count);
                horario = listaTurnoManana[indiceHorario];
                horasAsignadas += CargaDeHorario;
                unCurso.Horario.Add(horario.CodigoHorario);
                listaTurnoManana.RemoveAt(indiceHorario);
            }
            return true;
        }
        private bool CargaHorarioTarde(Curso unCurso)
        {
            List<Horario> listaTurnoTarde = HorariosTarde;
            Random rand = new Random();
            Horario horario = new Horario();
            int horasAsignadas = 0;
            while (!(horasAsignadas == unCurso.CargaHoraria))
            {
                if (listaTurnoTarde.Count == 0)
                {
                    return false;
                }
                int indiceHorario = rand.Next(0, listaTurnoTarde.Count);
                horario = listaTurnoTarde[indiceHorario];
                horasAsignadas += CargaDeHorario;
                unCurso.Horario.Add(horario.CodigoHorario);
                listaTurnoTarde.RemoveAt(indiceHorario);
            }
            return true;
        }
        private bool CargaHorarioNoche(Curso unCurso)
        {
            List<Horario> listaTurnoNoche = HorariosNoche;
            Random rand = new Random();
            Horario horario = new Horario();

            int horasAsignadas = 0;
            while (!(horasAsignadas == unCurso.CargaHoraria))
            {
                if (listaTurnoNoche.Count == 0)
                {
                    return false;
                }
                int indiceHorario = rand.Next(0, listaTurnoNoche.Count);
                horario = listaTurnoNoche[indiceHorario];
                horasAsignadas += CargaDeHorario;
                unCurso.Horario.Add(horario.CodigoHorario);
                listaTurnoNoche.RemoveAt(indiceHorario);

            }
            return true;

        }

        /// <summary>
        /// a traves de un codigo identificador y unico, me devuelve un curso 
        /// </summary>
        /// <param name="cursos"></param>
        /// <param name="estuJson"></param>
        /// <returns></returns>
        public static List<Curso> RetornaCursoPorCodigoIdentificador(List<Curso>cursos ,EstudianteJson estuJson)
        {
            List<Curso> listaCurso = new List<Curso>();
            HashSet<int> cursosAnotados = new HashSet<int>(estuJson.CodigoDeMateriasAnotadas);
            if (cursosAnotados.Count > 0)
            {
                foreach (Curso item in cursos)
                {
                    if (cursosAnotados.Contains(item.CodigoCurso))
                    {
                        listaCurso.Add(item);
                        cursosAnotados.Remove(item.CodigoCurso);
                    }
                }
            }
            return listaCurso;
        }

        public void AgregaRequisitosACurso(int codigos,int cred,double promedio)
        {
            RequisitosAcademicosParaCurso nuevoRequi = new RequisitosAcademicosParaCurso(codigos,cred,promedio);
            if (nuevoRequi is not null )
            {
                this.CodigoRequisitos = nuevoRequi.codigoRequisito;
                //CursoDB.GuardaRequisitos(nuevoRequi);
            }
        }

        public void DarBajaRequisitos()
        {
            if (this.CodigoRequisitos is not null)
            {
                CursoDB.EliminaRequisito(CodigoRequisitos.Value);

            }
        }
        public void AgregaProfesorAMateria(int codigoProfesor)
        {
            if (codigoProfesor > 0)
            {
                this.CodigoProfesorAsignado = codigoProfesor;
            }

        }
    }
}
