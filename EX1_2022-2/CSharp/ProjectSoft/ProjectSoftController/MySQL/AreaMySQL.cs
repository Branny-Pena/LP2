using MySql.Data.MySqlClient;
using ProjectSoftController.DAO;
using ProjectSoftDBManager;
using ProjectSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSoftController.MySQL
{
    public class AreaMySQL : AreaDAO
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;
        public BindingList<Area> listarTodas()
        {
            BindingList<Area> areas = new BindingList<Area>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_AREAS_TODAS";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Area area = new Area();
                    area.IdArea = reader.GetInt32("id_area");
                    area.Nombre = reader.GetString("nombre");
                    areas.Add(area);
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
            return areas;
        }
    }
}
