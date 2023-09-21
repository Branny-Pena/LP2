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
    public class GeneroMySql : GeneroDAO
    {
        private MySqlCommand command;
        private MySqlConnection con;
        private MySqlDataReader reader;
        public int eliminar(int idGenero)
        {
            throw new NotImplementedException();
        }

        public int insertar(Genero genero)
        {
            throw new NotImplementedException();
        }

        public BindingList<Genero> listarGeneros()
        {
            BindingList<Genero> generos = new BindingList<Genero>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_GENEROS_TODOS";
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    Genero genero = new Genero();
                    genero.IdGenero = reader.GetInt32("id_genero");
                    genero.Nombre = reader.GetString("nombre");
                    generos.Add(genero);
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
            return generos;
        }

        public int modificar(Genero genero)
        {
            throw new NotImplementedException();
        }
    }
}
