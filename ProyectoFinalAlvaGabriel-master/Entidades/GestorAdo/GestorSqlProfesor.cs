using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.GestorAdo
{
    public static class GestorSqlProfesor
    {
        private static string stringConection;


        static GestorSqlProfesor()
        {
            stringConection = "Server=LocalHost;Database=ProyectoGym;Trusted_Connection=True;";
        }

        public static List<ModeloProfesor> ObtenerTodasLasPersonas()
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(stringConection))
                {
                    List<ModeloProfesor> profesores = new List<ModeloProfesor>();
                    string query = "SELECT * FROM TablaProfesor";
                    SqlCommand command = new SqlCommand(query, conection);
                    conection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ModeloProfesor profesor = new ModeloProfesor();
                            profesor.ID_Profesor = reader.GetInt32(0);
                            profesor.Nombre = reader.GetString(1);
                            profesor.Apellido = reader.GetString(2);
                            profesor.Sueldo = reader.GetInt32(3);
                            profesor.Disciplina = reader.GetString(4);
                            profesores.Add(profesor);
                        }
                        return profesores;
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


        public static bool BorrarUnProfePorId(int id)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(stringConection))
                {
                    string query = "DELETE FROM TablaProfesor WHERE ID_Profesor=@id";
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
    }
}
