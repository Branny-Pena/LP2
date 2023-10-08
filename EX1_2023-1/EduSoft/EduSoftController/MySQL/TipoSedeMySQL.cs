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
    public class TipoSedeMySQL : TipoSedeDAO
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;
        public BindingList<TipoSede> listarTodos()
        {
            BindingList<TipoSede> tiposSedes = new BindingList<TipoSede>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_TIPOS_SEDE_TODOS";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoSede tipoSede= new TipoSede();
                    tipoSede.IdTipoSede = reader.GetInt32("id_tipo_sede");
                    tipoSede.Nombre = reader.GetString("nombre");
                    tiposSedes.Add(tipoSede);
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
            return tiposSedes;
        }
    }
}
