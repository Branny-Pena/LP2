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
    public class DocenteMySQL : DocenteDAO
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;
        public BindingList<Docente> listarPorCodigoPUCPNombre(string codigoPUCPNombre)
        {
            BindingList<Docente> docentes = new BindingList<Docente>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_DOCENTES_X_CODIGOPUCP_NOMBRE";
                command.Parameters.AddWithValue("_codigoPUCP_nombre", codigoPUCPNombre);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Docente docente = new Docente();
                    docente.IdPersona = reader.GetInt32("id_persona");
                    docente.CodigoPUCP = reader.GetString("codigo_PUCP");
                    docente.Nombre = reader.GetString("nombre");
                    docente.ApellidoPaterno = reader.GetString("apellido_paterno");
                    docente.Categoria = reader.GetString("categoria");
                    docentes.Add(docente);
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
            return docentes;
        }

        public BindingList<Docente> listarPorIdProyecto(int id)
        {
            BindingList<Docente> docentes = new BindingList<Docente>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_JURADOS_X_ID_PROYECTO";
                command.Parameters.AddWithValue("_id_proyecto", id);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Docente docente = new Docente();
                    docente.IdPersona = reader.GetInt32("id_docente");
                    docente.CodigoPUCP = reader.GetString("codigo_PUCP");
                    docente.Nombre = reader.GetString("nombre");
                    docente.ApellidoPaterno = reader.GetString("apellido_paterno");
                    docente.Categoria = reader.GetString("categoria");
                    docentes.Add(docente);
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
            return docentes;
        }
    }
}
