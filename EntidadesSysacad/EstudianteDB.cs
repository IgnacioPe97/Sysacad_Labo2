using EntidadesSysacad;
using LogicaDeNegocio;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EstudianteDB : ICrudOperaciones<Estudiante>
    {
        private static SqlConnection _connection;
        private static string _connectionString;
        private static SqlCommand _command;

         static EstudianteDB()
        {
            _connectionString = @"Server=DESKTOP-V52NIC9;Database=sysacad;Trusted_Connection=True;";
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
            _command.CommandType = System.Data.CommandType.Text;
            _command.Connection = _connection;
        }
        public  bool Add(Estudiante estudiante)
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                var query = "INSERT INTO Alumnos (Nombre, Apellido, Correo, Contrasenia, Dni, Telefono, Direccion,FechaInscripcion ,CambiarContrasenia, TurnoSeleccionado, PreferenciaCarrera) " +
                        "VALUES (@Nombre, @Apellido, @Correo, @Contrasenia, @Dni, @Telefono, @Direccion,@FechaInscripcion ,@CambiarContrasenia, @TurnoSeleccionado, @PreferenciaCarrera)";
                _command.CommandText = query;
                _command.Parameters.Clear(); // Limpiar parámetros antes de agregar nuevos


                _command.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                _command.Parameters.AddWithValue("@Apellido", estudiante.Apellido);
                _command.Parameters.AddWithValue("@Correo", estudiante.Correo);
                _command.Parameters.AddWithValue("@Contrasenia", estudiante.Contrasenia);
                _command.Parameters.AddWithValue("@Dni", estudiante.Dni);
                _command.Parameters.AddWithValue("@Telefono", estudiante.Telefono);
                _command.Parameters.AddWithValue("@Direccion", estudiante.Direccion);
                _command.Parameters.AddWithValue("@FechaInscripcion",estudiante.FechaInscripcion);
                _command.Parameters.AddWithValue("@CambiarContrasenia", estudiante.CambiarContrasenia);
                _command.Parameters.AddWithValue("@TurnoSeleccionado", (int)estudiante.TurnoSeleccionado);
                _command.Parameters.AddWithValue("@PreferenciaCarrera", (int)estudiante.PreferenciaCarrera);

                _command.ExecuteNonQuery();
                return true;
            }
            catch(SqlErrorException ex)
            { 
                throw  new SqlErrorException(ex.SqlErrorCode, ex.Message); 
            }
            finally
            {
                _connection.Close();
            }        
        }

        public bool Delete(Estudiante data)
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                var query = $"DELETE FROM Alumnos WHERE dni = @Dni";
                _command.CommandText = query;
                _command.Parameters.AddWithValue("@Dni",data.Dni);
                _command.ExecuteNonQuery();
                return true;
            }
            catch(SqlException ex)
            {
                throw new SqlErrorException(ex.ErrorCode, ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Delete(int dni)
        {
            try
            {
                _connection.Open();
                var query = $"DELETE FROM Alumnos WHERE dni = @Dni";
                _command.CommandText = query;
                _command.Parameters.AddWithValue("@Dni", dni);
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
        public List<Estudiante> GetAll()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                var query = $"SELECT * FROM Alumnos";
                _command.CommandText = query;

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var nombre = reader["Nombre"].ToString() ?? "";
                        var apellido = reader["Apellido"].ToString() ?? "";
                        var correo = reader["Correo"].ToString() ?? "";
                        var contra = reader["Contrasenia"].ToString() ?? "";
                        var dni = Convert.ToInt32(reader["Dni"]);
                        var telefono = Convert.ToInt32(reader["Telefono"]);
                        var direccion = reader["Direccion"].ToString() ?? "";
                        var cambiaContra = Convert.ToBoolean(reader["CambiarContrasenia"]);
                        var preferenciaDeTurno = (Turnos)Convert.ToInt32(reader["TurnoSeleccionado"]);
                        var carreraElegida = (Carreras)Convert.ToInt32(reader["PreferenciaCarrera"]);

                        Estudiante nuevoEstudiante = new Estudiante(nombre, apellido, correo, contra, dni, telefono, direccion, cambiaContra, preferenciaDeTurno, carreraElegida);
                        estudiantes.Add(nuevoEstudiante);
                    }
                    return estudiantes;
                }
            }
            catch(SqlException ex)
            {
                throw new SqlErrorException(ex.ErrorCode, ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        public  object GetOne(int codigo)
        {
            Estudiante estudiante = new Estudiante();
            try
            {
                _connection.Open();
                var query = $"SELECT * FROM Alumnos WHERE Dni = @Dni";
                _command.CommandText = query;

                _command.Parameters.AddWithValue("@Dni", codigo);

                using (var reader = _command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var nombre = reader["Nombre"].ToString() ?? "";
                        var apellido = reader["Apellido"].ToString() ?? "";
                        var correo = reader["Correo"].ToString() ?? "";
                        var contra = reader["Contrasenia"].ToString() ?? "";
                        var telefono = Convert.ToInt32(reader["Telefono"]);
                        var direccion = reader["Direccion"].ToString() ?? "";
                        var cambiaContra = Convert.ToBoolean(reader["CambiarContrasenia"]);
                        var preferenciaDeTurno = (Turnos)Convert.ToInt32(reader["TurnoSeleccionado"]);
                        var carreraElegida = (Carreras)Convert.ToInt32(reader["PreferenciaCarrera"]);

                        estudiante = new Estudiante(nombre, apellido, correo, contra, codigo, telefono, direccion, cambiaContra, preferenciaDeTurno, carreraElegida);
                    }
                    return (Estudiante)estudiante;

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
        public bool Update(Estudiante data)
        {
            throw new NotImplementedException();
        }
        public static bool GuardaListaPago(List<Pagos> list)
        {

            try
            {
                _connection.Open();

                foreach (var pago in list)
                {
                    var query = "INSERT INTO Pagos (CodigoEstudiante, Mes, EstaPago, ValorCuota) " +
                                "VALUES (@CodigoEstudiante, @Mes, @EstaPago, @ValorCuota)";

                    using (var command = new SqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@CodigoEstudiante", pago.CodigoEstudiante);
                        command.Parameters.AddWithValue("@Mes", (int)pago.Mes);
                        command.Parameters.AddWithValue("@EstaPago", pago.EstaPago);
                        command.Parameters.AddWithValue("@ValorCuota", pago.ValorCuota);

                        command.ExecuteNonQuery();
                    }
                }

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
        public static List<Pagos> ObtieneListaPagosDeUnAlumno(int dni)
        {
            List<Pagos> listaPagos = new List<Pagos>();

            try
            {
                _connection.Open();

                var query = "SELECT * FROM Pagos WHERE CodigoEstudiante = @Dni";
                _command.CommandText = query;
                _command.Parameters.AddWithValue("@Dni", dni);

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int codigoDePago = Convert.ToInt32(reader["CodigoDePago"]);
                        Meses mes = (Meses)Enum.Parse(typeof(Meses), reader["Mes"].ToString());
                        bool estaPago = Convert.ToBoolean(reader["EstaPago"]);


                        Pagos pago = new Pagos(mes, estaPago, dni);
                   
                        listaPagos.Add(pago);
                    }
                }

                return listaPagos;
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

    [Serializable]
    internal class SqlErrorException : Exception
    {
        public int SqlErrorCode { get; }
        public SqlErrorException()
        {
        }

        public SqlErrorException(int errorCode,string message) : base(message)
        {
            SqlErrorCode = errorCode;
        }

      

       
    }
}
