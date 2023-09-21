using EventSoftController.DAO;
using EventSoftDBManager;
using EventSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSoftController.MySQL
{
    public class EstiloArquitectonicoMySQL : EstiloArquitectonicoDAO
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public int eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int insertar(EstiloArquitectonico estiloArquitectonico)
        {
            throw new NotImplementedException();
        }

        public BindingList<EstiloArquitectonico> listarTodas()
        {
            BindingList<EstiloArquitectonico> estilosArq = new BindingList<EstiloArquitectonico>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_ESTILOS_ARQUITECTONICOS_TODOS";
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    EstiloArquitectonico ea = new EstiloArquitectonico();
                    ea.IdEstiloArquitectonico = reader.GetInt32("id_estilo_arquitectonico");
                    ea.Nombre = reader.GetString("nombre");
                    int activo = reader.GetInt32("activo");
                    if (activo != 0){ ea.Activo = true; }
                    else { ea.Activo = false; }
                    estilosArq.Add(ea);
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
            return estilosArq;
        }

        public int modificar(EstiloArquitectonico estiloArquitectonico)
        {
            throw new NotImplementedException();
        }
    }
}
