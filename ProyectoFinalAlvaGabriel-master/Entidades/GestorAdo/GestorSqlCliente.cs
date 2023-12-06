using Entidades.Excepciones;
using Entidades.Modelos;
using System.Data.SqlClient;
namespace Entidades.GestorAdo
{
    public static class GestorSqlCliente
    {
        private static string stringConection;


        static GestorSqlCliente()
        {
            GestorSqlCliente.stringConection = "Server=LocalHost;Database=ProyectoGym;Trusted_Connection=True;";
        }

        public static List<ModeloCliente> ObtenerClientePorIdProfesor()
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(GestorSqlCliente.stringConection))
                {
                    List<ModeloCliente> clientes = new List<ModeloCliente>();
                    string query = "SELECT * FROM TablaGym WHERE Id_Profesor = ";
                    SqlCommand command = new SqlCommand(query, conection);
                    conection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ModeloCliente cliente = new ModeloCliente();
                            cliente.IdCliente = reader.GetInt32(0);
                            cliente.Nombre = reader.GetString(1);
                            cliente.Apellido = reader.GetString(2);
                            cliente.Disciplinas = (Edisciplinas)Enum.Parse(typeof(Edisciplinas), reader.GetString(3));
                            cliente.CuotaAbonada = reader.GetString(4);
                            cliente.IdProfesor = reader.GetInt32(5);
                            clientes.Add(cliente);
                        }
                        return clientes;
                    }
                    else
                    {
                        throw new Exception("No se obtuvieron datos");
                    }
                }
            }
            catch (Exception)
            {
                throw new SinConexionBaseDeDatosException("Error al conectar a la base de datos");
            }
        }

        public static List<ModeloCliente> ObtenerTodasLasPersonas()
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(GestorSqlCliente.stringConection))
                {
                    List<ModeloCliente> clientes = new List<ModeloCliente>();
                    string query = "SELECT * FROM TablaGym";
                    SqlCommand command = new SqlCommand(query, conection);
                    conection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ModeloCliente cliente = new ModeloCliente();
                            cliente.IdCliente = reader.GetInt32(0);
                            cliente.Nombre = reader.GetString(1);
                            cliente.Apellido = reader.GetString(2);
                            cliente.Disciplinas = (Edisciplinas)Enum.Parse(typeof(Edisciplinas), reader.GetString(3));
                            cliente.CuotaAbonada = reader.GetString(4);
                            cliente.IdProfesor = reader.GetInt32(5);
                            clientes.Add(cliente);
                        }
                        return clientes;
                    }
                    else
                    {
                        throw new Exception("No se obtuvieron datos");
                    }
                }
            }
            catch (Exception)
            {
                throw new SinConexionBaseDeDatosException("Error al conectar a la base de datos");
            }
        }
        public static bool AgregarNuevoCliente(ModeloCliente cliente)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(GestorSqlCliente.stringConection))
                {
                    string query = "INSERT INTO TablaGym (Nombre, Apellido, Disciplina, Cuota_Abonada, Id_Profesor)" +
                        "values (@nombre,@apellido,@disciplina,@cuotaAbonada,@IdProfesor)";
                    SqlCommand command = new SqlCommand(query, conection);
                    command.Parameters.AddWithValue("nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("disciplina", cliente.Disciplinas);
                    command.Parameters.AddWithValue("cuotaAbonada", cliente.CuotaAbonada);
                    command.Parameters.AddWithValue("IdProfesor", cliente.IdProfesor);
                    conection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new SinConexionBaseDeDatosException("No hay conexion a la base de datos para agregar un cliente.");
            }
        }

        public static bool BorrarUnClientePorId(int id)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(GestorSqlCliente.stringConection))
                {
                    string query = "DELETE FROM TablaGym WHERE ID_CLIENTE=@id";
                    SqlCommand command = new SqlCommand(query, conection);
                    command.Parameters.AddWithValue("id", id);
                    conection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new SinConexionBaseDeDatosException("No hay conexion a la base de datos para eliminar un cliente.");
            }
        }

        public static bool ActualizarClientePorId(ModeloCliente cliente, int id)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(GestorSqlCliente.stringConection))
                {
                    string query = "UPDATE TablaGym SET Nombre = @nombre,Apellido=@apellido,Disciplina=@disciplina,Cuota_Abonada=@cuotaAbonada,"
                        + "Id_Profesor=@IdProfesor WHERE ID_CLIENTE=@id";
                    SqlCommand command = new SqlCommand(query, conection);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("disciplina", cliente.Disciplinas);
                    command.Parameters.AddWithValue("cuotaAbonada", cliente.CuotaAbonada);
                    command.Parameters.AddWithValue("IdProfesor", cliente.IdProfesor);
                    conection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new SinConexionBaseDeDatosException("No hay conexion a la base de datos para moidificar un cliente.");
            }

        }

        public static bool comprobarExistente(ModeloCliente clienteComprobado)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(GestorSqlCliente.stringConection))
                {
                    string query = "SELECT * FROM TablaGym WHERE Nombre=@nombre AND Apellido=@apellido AND Disciplina=@disciplina";
                    SqlCommand command = new SqlCommand(query, conection);
                    command.Parameters.AddWithValue("nombre", clienteComprobado.Nombre);
                    command.Parameters.AddWithValue("apellido", clienteComprobado.Apellido);
                    command.Parameters.AddWithValue("disciplina", clienteComprobado.Disciplinas);
                    conection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                throw new SinConexionBaseDeDatosException("No hay conexion a la base de datos para realizar la busqueda.");
            }
        }

        public static bool buscarClientePorIdProfesor(int idProfesor)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(GestorSqlCliente.stringConection))
                {
                    string query = "SELECT * FROM TablaGym WHERE Id_Profesor=@id";
                    SqlCommand command = new SqlCommand(query, conection);
                    command.Parameters.AddWithValue("id", idProfesor);
                    conection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                throw new SinConexionBaseDeDatosException("No hay conexion a la base de datos para eliminar un cliente.");
            }
        }

        public static List<ModeloCliente> buscarClienteClase(string clase)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(GestorSqlCliente.stringConection))
                {
                    List<ModeloCliente> clientes = new List<ModeloCliente>();
                    string query = "SELECT * FROM TablaGym WHERE Disciplina=@clase";
                    SqlCommand command = new SqlCommand(query, conection);
                    command.Parameters.AddWithValue("clase", clase);
                    conection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ModeloCliente cliente = new ModeloCliente();
                            cliente.IdCliente = reader.GetInt32(0);
                            cliente.Nombre = reader.GetString(1);
                            cliente.Apellido = reader.GetString(2);
                            cliente.Disciplinas = (Edisciplinas)Enum.Parse(typeof(Edisciplinas), reader.GetString(3));
                            cliente.CuotaAbonada = reader.GetString(4);
                            cliente.IdProfesor = reader.GetInt32(5);
                            clientes.Add(cliente);
                        }
                        return clientes;
                    }
                    else
                    {
                        throw new Exception("No se obtuvieron datos");
                    }
                }
            }
            catch (Exception)
            {
                throw new SinConexionBaseDeDatosException("No hay conexion a la base de datos para eliminar un cliente.");
            }
        }
        public static List<ModeloCliente> buscarClienteDeudor()
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(GestorSqlCliente.stringConection))
                {
                    List<ModeloCliente> clientes = new List<ModeloCliente>();
                    string query = "SELECT * FROM TablaGym WHERE Cuota_Abonada= 'no'";
                    SqlCommand command = new SqlCommand(query, conection);
                    conection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ModeloCliente cliente = new ModeloCliente();
                            cliente.IdCliente = reader.GetInt32(0);
                            cliente.Nombre = reader.GetString(1);
                            cliente.Apellido = reader.GetString(2);
                            cliente.Disciplinas = (Edisciplinas)Enum.Parse(typeof(Edisciplinas), reader.GetString(3));
                            cliente.CuotaAbonada = reader.GetString(4);
                            cliente.IdProfesor = reader.GetInt32(5);
                            clientes.Add(cliente);
                        }
                        return clientes;
                    }
                    else
                    {
                        throw new Exception("No se obtuvieron datos");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
