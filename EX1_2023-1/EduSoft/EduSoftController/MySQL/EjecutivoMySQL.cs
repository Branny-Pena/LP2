using EduSoftController.DAO;
using EdusoftDBManager;
using EduSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftController.MySQL
{
    public class EjecutivoMySQL : EjecutivoDAO
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;
        public BindingList<Ejecutivo> listarEjecutivoPorNombreDNI(string nombreDNI)
        {
            BindingList<Ejecutivo> ejecutivos = new BindingList<Ejecutivo>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_EJECUTIVOS_X_NOMBRE_DNI";
                command.Parameters.AddWithValue("_nombre_DNI", nombreDNI);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Ejecutivo ejecutivo = new Ejecutivo();
                    ejecutivo.IdEjecutivo = reader.GetInt32("id_ejecutivo");
                    ejecutivo.DNI = reader.GetString("DNI");
                    ejecutivo.Nombre = reader.GetString("nombre");
                    ejecutivo.ApellidoPaterno = reader.GetString("apellido_paterno");
                    ejecutivos.Add(ejecutivo);
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
            return ejecutivos;
        }
    }
}
