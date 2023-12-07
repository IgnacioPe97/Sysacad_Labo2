﻿using EntidadesSysacad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class EstudianteJson
    {
        private int codigoEstudiante;
        private string nombre;
        private string apellido;
        private string direccion;
        private int telefono;
        private int dni;
        private string correo;
        private string contrasenia;
        private List<int> codigoDeMateriasAnotadas;
        private Carreras carreraElegida;
        private List<int> listaPagos;
        private Turnos turnoSeleccionado;
        private DateTime fechaInscripcion;

        public int CodigoEstudiante { get => codigoEstudiante; set => codigoEstudiante = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public List<int> CodigoDeMateriasAnotadas { get => codigoDeMateriasAnotadas; set => codigoDeMateriasAnotadas = value; }
        public Turnos TurnoSeleccionado { get => turnoSeleccionado; set => turnoSeleccionado = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaInscripcion { get => fechaInscripcion; set => fechaInscripcion = value; }
        public Carreras CarreraElegida { get => carreraElegida; set => carreraElegida = value; }
        public List<int> ListaPagos { get => listaPagos; set => listaPagos = value; }

        public EstudianteJson()
        {
                
        }

    

        public static EstudianteJson ConvertirAEstudianteJson(Estudiante estudiante)
        {
            EstudianteJson estuJson = new EstudianteJson
            {
                CodigoEstudiante = estudiante.CodigoEstudiante,
                Nombre = estudiante.Nombre,
                Apellido = estudiante.Apellido,
                Direccion = estudiante.Direccion,
                Dni = estudiante.Dni,
                Telefono = estudiante.Telefono,
                Correo = estudiante.Correo,
                Contrasenia = estudiante.Contrasenia,
                TurnoSeleccionado = estudiante.TurnoSeleccionado + 1,
                CarreraElegida = estudiante.PreferenciaCarrera + 1,
                fechaInscripcion = estudiante.FechaInscripcion,
                CodigoDeMateriasAnotadas = CargaCodigoDeMaterias(estudiante),
                ListaPagos = estudiante.CuotasDelEstudiante,
                FechaInscripcion = estudiante.FechaInscripcion,
            };
            return estuJson;
        }
        /// <summary>
        /// toma los codigos identificadores de los cursos para asignarlos a la lista de enteros de un un estudiante 
        /// </summary>
        /// <param name="unEstudiante"></param>
        /// <returns></returns>
        public static List<int> CargaCodigoDeMaterias(Estudiante unEstudiante)
        {
            List<int> codigos = new List<int>();
            foreach (Curso curso in unEstudiante.MateriasAnotadas)
            {
                if (curso.CodigoCurso > 0)
                {
                    codigos.Add(curso.CodigoCurso);
                }
            }
            return codigos;
        }

    
    }


}

