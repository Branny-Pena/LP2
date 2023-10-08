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
    public class ProyectoMySQL : ProyectoDAO
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;
        public int insertar(Proyecto proyecto)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "INSERTAR_PROYECTO";
                command.Parameters.Add("_id_proyecto", MySqlDbType.Int32).Direction =
                    ParameterDirection.Output;
                command.Parameters.AddWithValue("_fid_area", proyecto.Area.IdArea);
                command.Parameters.AddWithValue("_fid_estudiante", proyecto.Estudiante.IdPersona);
                command.Parameters.AddWithValue("_titulo", proyecto.Titulo);
                command.Parameters.AddWithValue("_descripcion", proyecto.Descripcion);
                command.Parameters.AddWithValue("_archivo_tema_tesis", proyecto.ArchivoTemaTesis);
                command.Parameters.AddWithValue("_foto", proyecto.Foto);
                command.ExecuteNonQuery();
                proyecto.IdProyecto =
                    Int32.Parse(command.Parameters["_id_proyecto"].Value.ToString());
                foreach (Docente doc in proyecto.Jurados)
                {
                    con = new MySqlConnection(DBManager.cadenaConexion);
                    con.Open();
                    command = new MySqlCommand();
                    command.Connection = con;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "INSERTAR_JURADO_PROYECTO";
                    command.Parameters.Add("_id_jurado", MySqlDbType.Int32).Direction =
                        ParameterDirection.Output;
                    command.Parameters.AddWithValue("_fid_docente", doc.IdPersona);
                    command.Parameters.AddWithValue("_fid_proyecto", proyecto.IdProyecto);
                    command.ExecuteNonQuery();
                }
                resultado = proyecto.IdProyecto;
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

        public BindingList<Proyecto> listarPorTituloCodigoPUCPNombre(string codigoPUCPNombre)
        {
            BindingList<Proyecto> proyectos = new BindingList<Proyecto>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_PROYECTOS_X_TITULO_CODIGOPUCP_NOMBRE_TESISTA";
                command.Parameters.AddWithValue("_titulo_codigoPUCP_nombre", codigoPUCPNombre);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Proyecto proyecto = new Proyecto();
                    proyecto.Area = new Area();
                    proyecto.Estudiante = new Estudiante();
                    proyecto.IdProyecto = reader.GetInt32("id_proyecto");
                    proyecto.Area.IdArea = reader.GetInt32("id_area");
                    proyecto.Area.Nombre = reader.GetString("nombre_area");
                    proyecto.Titulo = reader.GetString("titulo");
                    proyecto.Descripcion = reader.GetString("descripcion");
                    if (!reader.IsDBNull(reader.GetOrdinal("foto"))) proyecto.Foto = (byte[])reader["foto"];
                    if (!reader.IsDBNull(reader.GetOrdinal("archivo_tema_tesis"))) proyecto.ArchivoTemaTesis = (byte[])reader["archivo_tema_tesis"];
                    proyecto.Estudiante.IdPersona = reader.GetInt32("id_estudiante");
                    proyecto.Estudiante.CodigoPUCP = reader.GetString("codigo_PUCP");
                    proyecto.Estudiante.Nombre = reader.GetString("nombre_estudiante");
                    proyecto.Estudiante.ApellidoPaterno = reader.GetString("apellido_paterno");
                    proyecto.Estudiante.CRAEST = reader.GetDouble("CRAEST");
                    DocenteDAO _daoDocente = new DocenteMySQL();
                    proyecto.Jurados = _daoDocente.listarPorIdProyecto(proyecto.IdProyecto);
                    proyectos.Add(proyecto);
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
            return proyectos;
        }
    }
}
