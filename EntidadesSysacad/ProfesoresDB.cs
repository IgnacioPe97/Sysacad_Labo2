using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public class ProfesoresDB: ICrudOperaciones<Profesores>
    {
     
        private static SqlConnection _connection;
        private static string _connectionString;
        private static SqlCommand _command;


        static ProfesoresDB() 
        {
            _connectionString = @"Server=DESKTOP-V52NIC9;Database=sysacad;Trusted_Connection=True;";
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
            _command.CommandType = System.Data.CommandType.Text;
            _command.Connection = _connection;
        }

        public bool Add(Profesores profesor)
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                var query = "INSERT INTO Profesores (Nombre, Apellido, NumeroIdentificador, Correo, Contrasenia, Telefono, CodigosMaterias) " +
                              "VALUES (@Nombre, @Apellido, @NumeroIdentificador, @Correo, @Contrasenia, @Telefono, @CodigosMaterias)";
                _command.CommandText = query;
                _command.Parameters.Clear(); // Limpiar parámetros antes de agregar nuevos

                _command.Parameters.AddWithValue("@Nombre", profesor.Nombre);
                _command.Parameters.AddWithValue("@Apellido", profesor.Apellido);
                _command.Parameters.AddWithValue("@NumeroIdentificador", profesor.NumeroIdentificador);
                _command.Parameters.AddWithValue("@Correo", profesor.Correo);
                _command.Parameters.AddWithValue("@Contrasenia", profesor.Contrasenia);
                _command.Parameters.AddWithValue("@Telefono", profesor.Telefono);
                _command.Parameters.AddWithValue("@CodigosMaterias", (object)profesor.CodigosMaterias ?? DBNull.Value);

                _command.ExecuteNonQuery();
                return true;

            }
            catch(SqlErrorException ex)
            {
                throw new SqlErrorException(ex.SqlErrorCode, ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Delete(Profesores data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int i)
        {
            throw new NotImplementedException();
        }

        public List<Profesores> GetAll()
        {
            List<Profesores> listaProfesores = new List<Profesores>();

            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                var query = "SELECT * FROM Profesores";
                _command.CommandText = query;

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var nombre = reader["Nombre"].ToString() ?? "";
                        var apellido = reader["Apellido"].ToString() ?? "";
                        var numeroIdentificador = Convert.ToInt32(reader["NumeroIdentificador"]);
                        var correo = reader["Correo"].ToString() ?? "";
                        var contra = reader["Contrasenia"].ToString() ?? "";
                        var telefono = Convert.ToInt32(reader["Telefono"]);

                        Profesores nuevoProfesor = new Profesores(nombre, apellido, correo, contra, telefono)
                        {
                            NumeroIdentificador = numeroIdentificador
                        };

                        listaProfesores.Add(nuevoProfesor);
                    }
                }
                return listaProfesores;
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


        public static List<int> ObtieneCursoParaProfesor(int codigo)
        {
            var cursosParaProfesor = new List<int>();

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                var query = "SELECT CodigoCurso FROM CursoJson WHERE CodigoProfesor = @CodigoProfesor";
                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@CodigoProfesor", codigo);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int codigoCurso = Convert.ToInt32(reader["CodigoCurso"]);
                            cursosParaProfesor.Add(codigoCurso);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new SqlErrorException(ex.ErrorCode, ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return cursosParaProfesor;

        }
        public object GetOne(int codigo)
        {
            throw new NotImplementedException();
        }
        public bool PreguntaSiExisteProfesor(Profesores prof)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                var query = "SELECT COUNT(*) FROM Profesores WHERE Correo = @Correo";

                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@Correo", prof.Correo);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
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

        public bool Update(Profesores data)
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                var query = "UPDATE Profesores SET Nombre = @Nombre, Apellido = @Apellido, " +
                            "Correo = @Correo, Contrasenia = @Contrasenia, Telefono = @Telefono, " +
                            "CodigosMaterias = @CodigoMaterias " +
                            "WHERE NumeroIdentificador = @NumeroIdentificador";

                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@Nombre", data.Nombre);
                    command.Parameters.AddWithValue("@Apellido", data.Apellido);
                    command.Parameters.AddWithValue("@Correo", data.Correo);
                    command.Parameters.AddWithValue("@Contrasenia", data.Contrasenia);
                    command.Parameters.AddWithValue("@Telefono", data.Telefono);
                    command.Parameters.AddWithValue("@CodigoMaterias", data.CodigosMaterias);
                    command.Parameters.AddWithValue("@NumeroIdentificador", data.NumeroIdentificador);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
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
    }
}
