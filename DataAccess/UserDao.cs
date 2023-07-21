using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class UserDao : ConnectionToSql
    {
        private const CommandType text = CommandType.Text;
        #region Actividades
        public DataTable MostrarActividades()
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select *from actividades AC INNER JOIN area AR ON AR.idArea=AC.idArea INNER JOIN maquinaria M ON AC.idMaquina=M.idMaquina";
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public void AgregarActividad(int idArea, int idMaquina, string nombreActividad, int recursoHumano,
            string descripcion, double tiempo, int periodo, DateTime fechaProgramada, int asignada)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "AgregarActividad";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idArea", idArea);
                    command.Parameters.AddWithValue("@idMaquina", idMaquina);
                    command.Parameters.AddWithValue("@nombreActividad", nombreActividad);
                    command.Parameters.AddWithValue("@recursoHumano", recursoHumano);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@tiempo", tiempo);
                    command.Parameters.AddWithValue("@periodo", periodo);
                    command.Parameters.AddWithValue("@fechaProgramada", fechaProgramada);
                    command.Parameters.AddWithValue("@asignada", asignada);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EditarActividad(int idActividad, int idArea, int idMaquina, string nombreActividad, int recursoHumano,
            string descripcion, double tiempo, int periodo, DateTime fechaProgramada, int asignada)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EditarActividad";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idActividad", idActividad);
                    command.Parameters.AddWithValue("@idArea", idArea);
                    command.Parameters.AddWithValue("@idMaquina", idMaquina);
                    command.Parameters.AddWithValue("@nombreActividad", nombreActividad);
                    command.Parameters.AddWithValue("@recursoHumano", recursoHumano);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@tiempo", tiempo);
                    command.Parameters.AddWithValue("@periodo", periodo);
                    command.Parameters.AddWithValue("@fechaProgramada", fechaProgramada);
                    command.Parameters.AddWithValue("@asignada", asignada);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EliminarActividad(int idActividad)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EliminarActividad";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idActividad", idActividad);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        #endregion
        #region Registro de Actividades
        public DataTable MostrarRegistroActividades()
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT *FROM registro_actividades re INNER JOIN actividades a ON re.idActividad = a.idActividad INNER JOIN maquinaria m ON re.idMaquina = m.idMaquina INNER JOIN area ar ON m.idArea = ar.idArea WHERE fechaRealizacion='2000-01-01' AND a.fechaProgramada<=GETDATE()";
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public void AgregarRegistroActividad(string idOrden, int idActividad, int idMaquina, int idTrabajador, DateTime fechaProgramada,
            DateTime fechaRealizacion, string notas, int idTrabajadorSupervisor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "AgregarRegistroActividad";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idOrden", idOrden);
                    command.Parameters.AddWithValue("@idActividad", idActividad);
                    command.Parameters.AddWithValue("@idMaquina", idMaquina);
                    command.Parameters.AddWithValue("@idTrabajador", idTrabajador);
                    command.Parameters.AddWithValue("@fechaProgramada", fechaProgramada);
                    command.Parameters.AddWithValue("@fechaRealizacion", fechaRealizacion);
                    command.Parameters.AddWithValue("@notas", notas);
                    command.Parameters.AddWithValue("@idTrabajadorSupervisor", idTrabajadorSupervisor);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EditarRegistroActividad(int id, string idOrden, int idActividad, int idMaquina, int idTrabajador, DateTime fechaProgramada,
            DateTime fechaRealizacion, string notas, int idTrabajadorSupervisor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EditarRegistroActividad";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@idOrden", idOrden);
                    command.Parameters.AddWithValue("@idActividad", idActividad);
                    command.Parameters.AddWithValue("@idMaquina", idMaquina);
                    command.Parameters.AddWithValue("@idTrabajador", idTrabajador);
                    command.Parameters.AddWithValue("@fechaProgramada", fechaProgramada);
                    command.Parameters.AddWithValue("@fechaRealizacion", fechaRealizacion);
                    command.Parameters.AddWithValue("@notas", notas);
                    command.Parameters.AddWithValue("@idTrabajadorSupervisor", idTrabajadorSupervisor);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EliminarRegistroActividad(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EliminarRegistroActividad";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        #region Indicadores
        public DataTable MostrarActividadesRealizadas(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ObtenerActividadesRealizadasPorFecha";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public DataTable RegistroPreventivoDashboard(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "RegistroPreventivoDashboard";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public DataTable ObtenerPreventivoAreaFecha(DateTime fechaInicio, DateTime fechaFin, int[] idArea)
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Convertir el arreglo de idArea en una cadena separada por comas
                    string idAreaString = string.Join(",", idArea);

                    command.CommandText = "SELECT * FROM registro_actividades a " +
                        "INNER JOIN maquinaria m ON a.idMaquina = m.idMaquina " +
                        "INNER JOIN trabajadores t ON a.idTrabajador = t.idTrabajador " +
                        "WHERE m.idArea IN (" + idAreaString + ") " +
                        "AND a.fechaRealizacion BETWEEN @fechaInicio AND @fechaFin " +
                        "AND a.fechaProgramada BETWEEN DATEFROMPARTS(YEAR(@fechaInicio), MONTH(@fechaInicio), 1) AND EOMONTH(@fechaInicio)";

                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin);

                    leer = command.ExecuteReader();
                    table.Load(leer);

                    connection.Close();

                    return table;
                }
            }
        }
        public DataTable MostrarRegistrosFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "SELECT * FROM registro_actividades WHERE fechaProgramada BETWEEN @fechaInicio AND @fechaFin " +
                        "AND fechaRealizacion BETWEEN @fechaInicio AND @fechaFin";

                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        #endregion
        #endregion
        #region Mantenimeinto Correctivo
        public DataTable MostrarCorrectivos()
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT *FROM registro_mantenimiento_correctivo rc " +
                        "INNER JOIN maquinaria m " +
                        "ON rc.idMaquina=m.idMaquina " +
                        "INNER JOIN area a " +
                        "ON m.idArea=a.idArea " +
                        "INNER JOIN trabajadores t " +
                        "ON rc.idTrabajador=t.idTrabajador ORDER BY rc.id DESC";
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public void AgregarCorrectivo(int idMaquina, int idTrabajador, double tiempoParo,
                string descripcion, DateTime fecha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "AgregarCorrectivo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idMaquina", idMaquina);
                    command.Parameters.AddWithValue("@idTrabajador", idTrabajador);
                    command.Parameters.AddWithValue("@tiempoParo", tiempoParo);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EditarCorrectivo(int id, int idMaquina, int idTrabajador, double tiempoParo,
                string descripcion, DateTime fecha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EditarCorrectivo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@idMaquina", idMaquina);
                    command.Parameters.AddWithValue("@idTrabajador", idTrabajador);
                    command.Parameters.AddWithValue("@tiempoParo", tiempoParo);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EliminarCorrectivo(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EliminarCorrectivo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        #region Indicadores
        public DataTable RegistroCorrectivoDashboard(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "RegistroCorrectivoDashboard";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public float[] CorrectivoVsPreventivoDashboard(DateTime fechaInicio, DateTime fechaFin)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        command.CommandText = "PreventivoVsCorrectivoDashboard";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);
                        command.Parameters.Add("@conteoHrsCorrectivo", SqlDbType.Real).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@conteoHrsPreventivo", SqlDbType.Real).Direction = ParameterDirection.Output;
                        command.ExecuteNonQuery();
                        float[] array = new float[2];
                        array[0] = (float)command.Parameters["@conteoHrsCorrectivo"].Value;
                        array[1] = (float)command.Parameters["@conteoHrsPreventivo"].Value;
                        return array;
                    }
                    catch
                    {
                        return null;
                    }
                    
                }
            }        
        }
        public DataTable TiempoParoMaquinaDashboard(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "TiempoParoMaquinaDashboard";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public float[] CorrectivoVsPreventivoArea(DateTime fechaInicio, DateTime fechaFin, int[] idArea)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "PreventivoVsCorrectivoArea";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin);

                    // Convert int[] to delimited string
                    string idAreaString = string.Join(",", idArea);
                    command.Parameters.AddWithValue("@idAreaString", idAreaString);

                    command.Parameters.Add("@conteoHrsCorrectivo", SqlDbType.Real).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@conteoHrsPreventivo", SqlDbType.Real).Direction = ParameterDirection.Output;
                    command.ExecuteNonQuery();
                    float[] array = new float[2];
                    array[0] = (float)command.Parameters["@conteoHrsCorrectivo"].Value;
                    array[1] = (float)command.Parameters["@conteoHrsPreventivo"].Value;
                    return array;
                }
            }
        }

        public DataTable ObtenerCorrectivoAreaFecha(DateTime fechaInicio, DateTime fechaFin, int[] idArea)
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    // Construir la consulta SQL dinámicamente
                    string query = "SELECT * FROM registro_mantenimiento_correctivo rc " +
                        "INNER JOIN maquinaria m ON rc.idMaquina = m.idMaquina " +
                        "INNER JOIN trabajadores t ON rc.idTrabajador = t.idTrabajador " +
                        "WHERE m.idArea IN ({0}) AND rc.fecha BETWEEN @fechaInicio AND @fechaFin";

                    // Crear los parámetros para cada valor de idArea
                    List<string> parameterNames = new List<string>();
                    for (int i = 0; i < idArea.Length; i++)
                    {
                        string parameterName = "@idArea" + i;
                        command.Parameters.AddWithValue(parameterName, idArea[i]);
                        parameterNames.Add(parameterName);
                    }

                    // Combinar los parámetros en una cadena separada por comas
                    string parameterString = string.Join(", ", parameterNames);

                    // Reemplazar el marcador de posición en la consulta SQL con los parámetros
                    string formattedQuery = string.Format(query, parameterString);

                    command.CommandText = formattedQuery;
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }

        public DataTable ObtenerCorrectivosFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "SELECT * FROM registro_mantenimiento_correctivo WHERE fecha BETWEEN @fechaInicio AND @fechaFin";
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }

        #endregion
        #endregion
        #region Listado Trabajadores Correctivos
        public DataTable MostrarListado()
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT *FROM listado_trabajadores_RMC lt " +
                        "INNER JOIN registro_mantenimiento_correctivo rc " +
                        "ON lt.idActividadCorrectiva=rc.id " +
                        "INNER JOIN trabajadores t " +
                        "ON lt.idTrabajador=t.idTrabajador";
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public void AgregarListado(int idActividadCorrectiva, int idTrabajador, string descripcion, double horasTrabajadas)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "AgregarListadoCorrectivo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idActividadCorrectiva", idActividadCorrectiva);
                    command.Parameters.AddWithValue("@idTrabajador", idTrabajador);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@horasTrabajadas", horasTrabajadas);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EditarListadoCorrectivo(int id, int idActividadCorrectiva, int idTrabajador, string descripcion, int horasTrabajadas)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EditarListadoCorrectivo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@idActividadCorrectiva", idActividadCorrectiva);
                    command.Parameters.AddWithValue("@idTrabajador", idTrabajador);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@horasTrabajadas", horasTrabajadas);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EliminarListadoCorrectivo(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EliminarListadoCorrectivo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        #endregion
        #region Areas
        public DataTable MostrarAreas()
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM area";
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        #endregion
        #region Maquinaria
        public DataTable MostrarMaquinas()
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM maquinaria m " +
                        "INNER JOIN area a ON m.idArea=a.idArea";
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public DataTable MostrarMaquinasArea(int idArea)
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM maquinaria WHERE idArea=@idArea";
                    command.Parameters.AddWithValue("@idArea", idArea);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public void AgregarMaquina(int idArea, string descripcion, string modelo, int fabricacion, string marca)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO maquinaria VALUES (@idArea, @descripcion, @modelo, @fabricacion, @marca)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idArea", idArea);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@modelo", modelo);
                    command.Parameters.AddWithValue("@fabricacion", fabricacion);
                    command.Parameters.AddWithValue("@marca", marca);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EliminarMaquina(int idMaquina)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM maquinaria WHERE idMaquina=@idMaquina";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idMaquina", idMaquina);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }

        #endregion
        #region Trabajadores
        public DataTable MostrarTrabajadores()
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM trabajadores";
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public bool Login(string user, string pass)
        {
            using (SqlConnection sqlConnection = GetConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM trabajadores WHERE usuario=@user AND pass COLLATE Latin1_General_CS_AS =@pass";
                    sqlCommand.Parameters.AddWithValue("@user", user);
                    sqlCommand.Parameters.AddWithValue("@pass", pass);
                    sqlCommand.CommandType = CommandType.Text;

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                Usuario.Nombre = sqlDataReader.GetString(2);
                                Usuario.Apellido = sqlDataReader.GetString(3);
                                Usuario.Puesto = sqlDataReader.GetString(4);
                                Usuario.IdArea = sqlDataReader.GetInt32(1);
                                Usuario.IdTrabajador = sqlDataReader.GetInt32(0);
                                Usuario.User = sqlDataReader.GetString(5);
                                Usuario.IdRol = sqlDataReader.GetInt32(7);
                            }

                            return true;
                        }
                    }
                }
            }

            return false;
        }

        #endregion
        #region Refacciones
        public DataTable MostrarRefacciones()
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM refacciones";
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public DataTable MostrarGruposRefacciones()
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT grupo FROM refacciones GROUP BY grupo";
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public void AgregarRefaccion(string grupo, string descripcion,string unidad, string maquina, int precio, string proveedor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO refacciones VALUES (@grupo, @descripcion, @unidad, @maquina, @precio, @proveedor)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@grupo", grupo);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@unidad", unidad);
                    command.Parameters.AddWithValue("@maquina", maquina);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@proveedor", proveedor);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EditarRefaccion(int idRefaccion, string grupo, string descripcion, string unidad, string maquina, int precio, string proveedor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE refacciones SET grupo = @grupo, descripcion = @descripcion, unidad = @unidad, maquina = @maquina, precio = @precio, proveedor = @proveedor WHERE idRefaccion = @idRefaccion";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idRefaccion", idRefaccion);
                    command.Parameters.AddWithValue("@grupo", grupo);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@unidad", unidad);
                    command.Parameters.AddWithValue("@maquina", maquina);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@proveedor", proveedor);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EliminarRefaccion(int idRefaccion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM refacciones WHERE idRefaccion=@idRefaccion";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idRefaccion", idRefaccion);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        #endregion
        #region AlmacenRefacciones
        public DataTable MostrarAlmacenRefacciones()
        {
            SqlDataReader leer;
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM almacen_refacciones TOP 200";
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                    return table;
                }
            }
        }
        public void AgregarMovimientoRefaccion(int idRefaccion, int idStatus, int cantidad, DateTime fechaMovimiento)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO almacen_refacciones VALUES (@idRefaccion, @idStatus, @fechaMovimiento, @cantidad)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idRefaccion", idRefaccion);
                    command.Parameters.AddWithValue("@idStatus", idStatus);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@fechaMovimiento", fechaMovimiento);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EditarMovimientoRefaccion(int id, int idRefaccion, int idStatus, int cantidad, DateTime fechaMovimiento)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE almacen_refacciones SET idRefaccion = @idRefaccion, idStatus = @idStatus, fechaMovimiento = @fechaMovimiento, cantidad = @cantidad WHERE idSerial = @id";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@idRefaccion", idRefaccion);
                    command.Parameters.AddWithValue("@idStatus", idStatus);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@fechaMovimiento", fechaMovimiento);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void EliminarMovimientoRefaccion(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM almacen_refacciones WHERE idSerial=@id";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        #endregion
    }
}
