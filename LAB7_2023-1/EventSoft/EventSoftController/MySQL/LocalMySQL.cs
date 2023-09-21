using EventSoftController.DAO;
using EventSoftDBManager;
using EventSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventSoftController.MySQL
{
    public class LocalMySQL : LocalDAO
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public int eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int modificar(Local local)
        {
            throw new NotImplementedException();
        }

        public int insertar(Local local)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "INSERTAR_LOCAL";
                command.Parameters.Add("_id_local", MySqlDbType.Int32).Direction =
                    ParameterDirection.Output;
                command.Parameters.AddWithValue("_fid_estilo_arquitectonico", local.EstiloArquitectonico.IdEstiloArquitectonico);
                command.Parameters.AddWithValue("_nombre", local.Nombre);
                command.Parameters.AddWithValue("_direccion", local.Direccion);
                command.Parameters.AddWithValue("_fecha_construccion", local.FechaConstruccion); 
                command.Parameters.AddWithValue("_aforo", local.Aforo); 
                command.Parameters.AddWithValue("_tiene_palco", local.TienePalco); 
                command.Parameters.AddWithValue("_tiene_proyector", local.TieneProyector); 
                command.Parameters.AddWithValue("_tiene_vestibulo", local.TieneVestibulo);
                command.Parameters.AddWithValue("_resenha", local.Resenha);
                command.Parameters.AddWithValue("_foto", local.Foto);
                command.Parameters.AddWithValue("_plano", local.Plano);
                resultado = command.ExecuteNonQuery();
                local.IdLocal = Int32.Parse(command.Parameters["_id_local"].Value.ToString());
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                try { con.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
            }
            return resultado;
        }

        public BindingList<Local> listarTodas(string nombre)
        {
            BindingList<Local> locales = new BindingList<Local>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_AREAS";
                command.Parameters.AddWithValue("_nombre", nombre);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Local local = new Local();
                    local.IdLocal = reader.GetInt32("l.id_local");
                    local.EstiloArquitectonico.IdEstiloArquitectonico = reader.GetInt32("e.id_estilo_arquitectonico");
                    local.Nombre = reader.GetString("l.nombre");
                    locales.Add(local);
                }
            }
            catch(Exception ex)
            {
                throw new Exception (ex.Message);
            }
            finally
            {
                try { con.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
            }
            return locales;
        }

    }
}
