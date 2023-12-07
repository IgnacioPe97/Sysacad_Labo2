using CapaDatos;
using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public class CursoDB : ICrudOperaciones<Curso>
    {

        private static SqlConnection _connection;
        private static string _connectionString;
        private static SqlCommand _command;

        static CursoDB()
        {
            _connectionString = @"Server=DESKTOP-V52NIC9;Database=sysacad;Trusted_Connection=True;";
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
            _command.CommandType = System.Data.CommandType.Text;
            _command.Connection = _connection;

        }
        public bool Add(CursoJson curso)
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }                
                var queryCurso = "INSERT INTO CursoJson (NombreCurso, CupoMaximo, CodigoCurso, Descripcion, CargaHoraria, NumeroAula, CodigoProfesor,CodigoRequisitos) " +
                    "VALUES (@NombreCurso, @CupoMaximo, @CodigoCurso, @Descripcion, @CargaHoraria, @NumeroAula, @CodigoProfesor,@CodigoRequisitos); SELECT SCOPE_IDENTITY();";
                _command.CommandText = queryCurso;
                _command.Parameters.AddWithValue("@NombreCurso", curso.NombreCurso);
                _command.Parameters.AddWithValue("@CupoMaximo", curso.CupoMaximo);
                _command.Parameters.AddWithValue("@CodigoCurso", curso.CodigoCurso);
                _command.Parameters.AddWithValue("@Descripcion", curso.Descripcion);
                _command.Parameters.AddWithValue("@CargaHoraria", curso.CargaHoraria);
                _command.Parameters.AddWithValue("@NumeroAula", curso.NumeroAula);
                _command.Parameters.AddWithValue("@CodigoProfesor", curso.CodigoProfesor);
                _command.Parameters.AddWithValue("@CodigoRequisitos", curso.CodigoRequisitos);

                int idCurso = Convert.ToInt32(_command.ExecuteScalar()); 
                foreach (var codigoEstudiante in curso.DniAlumnos)
                {
                    var queryEstudiantesEnCurso = "INSERT INTO EstudiantesEnCurso (IdCurso, CodigoEstudiante) VALUES (@IdCurso, @CodigoEstudiante)";
                    _command.CommandText = queryEstudiantesEnCurso;
                    _command.Parameters.Clear();
                    _command.Parameters.AddWithValue("@IdCurso", idCurso);
                    _command.Parameters.AddWithValue("@CodigoEstudiante", codigoEstudiante);
                    _command.ExecuteNonQuery();
                }

                return true;
            }
            catch (SqlErrorException ex)
            {
                throw new SqlErrorException(ex.SqlErrorCode, ex.Message);
            }
            finally
            {
                _connection.Close();
            }
     
        }

        public bool Delete(CursoJson data)
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                var queryDeleteEstudiantes = "DELETE FROM EstudiantesEnCurso WHERE IdCurso = @IdCurso";
                using (var commandDeleteEstudiantes = _connection.CreateCommand())
                {
                    commandDeleteEstudiantes.CommandText = queryDeleteEstudiantes;
                    commandDeleteEstudiantes.Parameters.AddWithValue("@IdCurso", data.CodigoCurso);
                    commandDeleteEstudiantes.ExecuteNonQuery();
                }
                var query = $"DELETE FROM CursoJson WHERE CodigoCurso = @CodigoCurso";
                _command.CommandText = query;
                _command.Parameters.AddWithValue("@CodigoCurso", data.CodigoCurso);
                _command.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                throw new SqlErrorException(ex.ErrorCode, ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Delete(int codigoCurso)
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                var query = $"DELETE FROM CursoJson WHERE CodigoCurso = @CodigoCurso";
                _command.CommandText = query;
                _command.Parameters.AddWithValue("@CodigoCurso", codigoCurso);
                _command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw new SqlErrorException(ex.ErrorCode, ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<Curso> GetAll()
        {
            List<Curso> listaCursos = new List<Curso>();

            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                var query = "SELECT * FROM CursoJson";
                _command.CommandText = query;

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int codigoCurso = Convert.ToInt32(reader["CodigoCurso"]);
                        string nombreCurso = reader["NombreCurso"].ToString();
                        int cupoMaximo = Convert.ToInt32(reader["CupoMaximo"]);
                        string descripcion = reader["Descripcion"].ToString();
                        int cargaHoraria = Convert.ToInt32(reader["CargaHoraria"]);
                        int numeroAula = Convert.ToInt32(reader["NumeroAula"]);
                        int? codigoProfesor = reader.IsDBNull(reader.GetOrdinal("CodigoProfesor")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("CodigoProfesor"));//Convert.ToInt32(reader["CodigoProfesor"]);
                        int? codigoRequisitos = reader.IsDBNull(reader.GetOrdinal("CodigoRequisitos")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("CodigoRequisitos")); //Convert.ToInt32(reader["CodigoRequisitos"]);
                        Curso curso = new Curso
                        {
                            CodigoCurso = codigoCurso,
                            NombreCurso = nombreCurso,
                            CupoMaximo = cupoMaximo,
                            Descripcion = descripcion,
                            CargaHoraria = cargaHoraria,
                            NumeroAula = numeroAula,
                            CodigoProfesorAsignado = codigoProfesor,
                            CodigoRequisitos = codigoRequisitos,
                        };
                        listaCursos.Add(curso);
                    }
                    reader.Close();  
                }
                return listaCursos;
            }
            catch (SqlException ex)
            {
                throw new SqlErrorException(ex.ErrorCode, ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        public static List<int> ObtenerEstudiantesAsociados(int codigoCurso)
        {
            var estudiantesAsociados = new List<int>();

            var queryEstudiantes = "SELECT dni_Alumno FROM EstudiantesCursos WHERE id_Curso = @CodigoCurso";

            using (var commandEstudiantes = _connection.CreateCommand())
            {
                commandEstudiantes.CommandText = queryEstudiantes;
                commandEstudiantes.Parameters.AddWithValue("@CodigoCurso", codigoCurso);

                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                using (var readerEstudiantes = commandEstudiantes.ExecuteReader())
                {
                    while (readerEstudiantes.Read())
                    {
                        int codigoEstudiante = Convert.ToInt32(readerEstudiantes["dni_Alumno"]);
                        estudiantesAsociados.Add(codigoEstudiante);
                    }
                }
            }
            return estudiantesAsociados;
        }
        public bool Update(CursoJson data)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                // Actualizar datos del curso
                var queryCurso = "UPDATE CursoJson SET " +
                "NombreCurso = @NombreCurso, " +
                "CupoMaximo = @CupoMaximo, " +
                "Descripcion = @Descripcion, " +
                "CargaHoraria = @CargaHoraria, " +
                "NumeroAula = @NumeroAula, " +
                "CodigoProfesor = @CodigoProfesor, " +
                "CodigoRequisitos = @CodigoRequisitos " +
                "WHERE CodigoCurso = @CodigoCurso";

                _command.CommandText = queryCurso;
                _command.Parameters.AddWithValue("@NombreCurso", data.NombreCurso);
                _command.Parameters.AddWithValue("@CupoMaximo", data.CupoMaximo);
              //  _command.Parameters.AddWithValue("@CodigoCurso", data.CodigoCurso);
                _command.Parameters.AddWithValue("@Descripcion", data.Descripcion);
                _command.Parameters.AddWithValue("@CargaHoraria", data.CargaHoraria);
                _command.Parameters.AddWithValue("@NumeroAula", data.NumeroAula);
                _command.Parameters.AddWithValue("@CodigoProfesor", data.CodigoProfesor);
                _command.Parameters.AddWithValue("@CodigoRequisitos", data.CodigoRequisitos ?? (object)DBNull.Value);
                _command.Parameters.AddWithValue("@CodigoCurso", data.CodigoCurso);

                _command.ExecuteNonQuery();
                foreach (var codigoEstudiante in data.DniAlumnos)
                {
                    var queryEstudiantesEnCurso = "INSERT INTO EstudiantesCursos (id_Curso, dni_Alumno) VALUES (@IdCurso, @CodigoEstudiante)";
                    _command.CommandText = queryEstudiantesEnCurso;
                    _command.Parameters.Clear();
                    _command.Parameters.AddWithValue("@IdCurso", data.CodigoCurso);
                    _command.Parameters.AddWithValue("@CodigoEstudiante", codigoEstudiante);
                    _command.ExecuteNonQuery();
                }
                return true;
            }
            catch (SqlErrorException ex)
            {
                throw new SqlErrorException(ex.SqlErrorCode, ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
       

        public bool Add(Curso data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Curso data)
        {
            throw new NotImplementedException();
        }
        public static bool GuardaRequisitos(RequisitosAcademicosParaCurso unRequisito)
        {
            try
            {
                _connection.Open();

                var query = "INSERT INTO RequisitosAcademicos (NivelCreditosAcumulados, PromedioAcademico, TieneRequisitos) " +
                            "VALUES (@NivelCreditossAcumulados, @PromedioAcademico, @TieneRequisitos)";
                _command.CommandText = query;
                _command.Parameters.AddWithValue("@NivelCreditossAcumulados", unRequisito.NivelCreditossAcumulados);
                _command.Parameters.AddWithValue("@PromedioAcademico", unRequisito.PromedioAcademico);
                _command.Parameters.AddWithValue("@TieneRequisitos", unRequisito.TieneRequisitos);
                _command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw new SqlErrorException(ex.ErrorCode, ex.Message);
            }
            finally
            {
                _connection.Close();
            }

        }

        public static bool EliminaRequisito(int CodigoRequisito)
        {
            try
            {
                _connection.Open();
                var query = $"DELETE FROM RequisitosAcademicos WHERE CodigoRequisito = @CodigoReq";
                _command.CommandText = query;
                _command.Parameters.AddWithValue("@CodigoReq", CodigoRequisito);
                _command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw new SqlErrorException(ex.ErrorCode, ex.Message);
            }
            finally
            {
                _connection.Close();
            }

        }

        object ICrudOperaciones<Curso>.GetOne(int codigo)
        {
            throw new NotImplementedException();
        }

        public bool Update(Curso data)
        {
            throw new NotImplementedException();
        }
    }
}
