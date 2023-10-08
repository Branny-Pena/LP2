using MySql.Data.MySqlClient;
using ProjectSoftController.DAO;
using ProjectSoftDBManager;
using ProjectSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSoftController.MySQL
{
    public class EstudianteMySQL : EstudianteDAO
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;
        public BindingList<Estudiante> listarPorCodigoPUCPNombre(string codigoNombre)
        {
            BindingList<Estudiante> estudiantes = new BindingList<Estudiante>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_ESTUDIANTES_X_CODIGOPUCP_NOMBRE";
                command.Parameters.AddWithValue("_codigoPUCP_nombre", codigoNombre);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Estudiante estudiante = new Estudiante();
                    estudiante.IdPersona = reader.GetInt32("id_persona");
                    estudiante.CodigoPUCP = reader.GetString("codigo_PUCP");
                    estudiante.Nombre = reader.GetString("nombre");
                    estudiante.ApellidoPaterno = reader.GetString("apellido_paterno");
                    estudiante.CRAEST = reader.GetDouble("CRAEST");
                    estudiantes.Add(estudiante);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                try { con.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
            }
            return estudiantes;
        }
    }
}
