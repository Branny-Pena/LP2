using GameSoftController.DAO;
using GameSoftDBManager;
using GameSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftController.MySQL
{
    public class DesarrolladoraMySql : DesarrolladoraDAO
    {
        private MySqlCommand command;
        private MySqlConnection con;
        private MySqlDataReader reader;
        public int eliminar(int idDesarrolladora)
        {
            throw new NotImplementedException();
        }

        public int insertar(Desarrolladora desarroladora)
        {
            throw new NotImplementedException();
        }

        public BindingList<Desarrolladora> listarTodas(string nombre)
        {
            BindingList<Desarrolladora> desarrolladoras = new BindingList<Desarrolladora>();
            try
            { 
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_DESARROLLADORAS_POR_NOMBRE";
                command.Parameters.AddWithValue("_nombre", nombre);
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    Desarrolladora desarrolladora = new Desarrolladora();
                    desarrolladora.IdDesarrolladora = reader.GetInt32("id_desarrolladora");
                    desarrolladora.Nombre = reader.GetString("nombre");
                    desarrolladoras.Add(desarrolladora);
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
            return desarrolladoras;
        }

        public int modificar(Desarrolladora desarrolladora)
        {
            throw new NotImplementedException();
        }
    }
}
