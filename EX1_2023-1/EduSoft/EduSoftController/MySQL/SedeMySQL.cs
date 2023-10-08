using EduSoftController.DAO;
using EdusoftDBManager;
using EduSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftController.MySQL
{
    public class SedeMySQL : SedeDAO
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;
        
        public int insertar(Sede sede)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "INSERTAR_SEDE";
                command.Parameters.Add("_id_sede", MySqlDbType.Int32).Direction =
                    ParameterDirection.Output;
                command.Parameters.AddWithValue("_fid_tipo_sede", sede.TipoSede.IdTipoSede);
                command.Parameters.AddWithValue("_fid_ejecutivo_responsable", sede.Ejecutivo.IdEjecutivo);
                command.Parameters.AddWithValue("_nombre", sede.Nombre);
                command.Parameters.AddWithValue("_direccion", sede.Direccion);
                command.Parameters.AddWithValue("_fecha_inauguracion", sede.FechaInauguracion);
                command.Parameters.AddWithValue("_cantidad_aulas", sede.CantidadAulas);
                command.Parameters.AddWithValue("_aforo_total", sede.AforoTotal);
                command.Parameters.AddWithValue("_foto", sede.Foto);
                command.Parameters.AddWithValue("_tiene_auditorio", sede.TieneAuditorio);
                command.Parameters.AddWithValue("_tiene_biblioteca", sede.TieneBiblioteca);
                command.Parameters.AddWithValue("_tiene_estacionamiento", sede.TieneEstacionamiento);
                command.Parameters.AddWithValue("_tiene_salas_estudio", sede.TieneSalasEstudio);
                command.Parameters.AddWithValue("_tiene_cafeteria", sede.TieneCafeteria);
                command.ExecuteNonQuery();
                sede.IdSede =
                    Int32.Parse(command.Parameters["_id_sede"].Value.ToString());
                foreach(ProgramaAcademico pro in sede.ProgramasAcademicos)
                {
                    con = new MySqlConnection(DBManager.cadenaConexion);
                    con.Open();
                    command = new MySqlCommand();
                    command.Connection = con;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "INSERTAR_SEDE_PROGRAMA_ACADEMICO";
                    command.Parameters.Add("_id_sede_programa_academico", MySqlDbType.Int32).Direction =
                        ParameterDirection.Output;
                    command.Parameters.AddWithValue("_fid_sede", sede.IdSede);
                    command.Parameters.AddWithValue("_fid_programa_academico", pro.IdProgramaAcademico);
                    command.ExecuteNonQuery();
                }
                resultado = sede.IdSede;
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

        public BindingList<Sede> listarPorNombre(string nombre)
        {
            BindingList<Sede> sedes = new BindingList<Sede>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_SEDES_X_NOMBRE";
                command.Parameters.AddWithValue("_nombre", nombre);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Sede sede = new Sede();
                    sede.TipoSede = new TipoSede();
                    sede.Ejecutivo = new Ejecutivo();
                    sede.IdSede = reader.GetInt32("id_sede");
                    sede.TipoSede.IdTipoSede = reader.GetChar("id_tipo_sede");
                    sede.TipoSede.Nombre = reader.GetString("nombre_tipo_sede");
                    sede.Nombre = reader.GetString("nombre_sede");
                    sede.Direccion = reader.GetString("direccion");
                    sede.FechaInauguracion = reader.GetDateTime("fecha_inauguracion");
                    sede.CantidadAulas = reader.GetInt32("cantidad_aulas");
                    sede.AforoTotal = reader.GetInt32("aforo_total");
                    if (!reader.IsDBNull(reader.GetOrdinal("foto"))) sede.Foto = (byte[])reader["foto"];
                    sede.TieneAuditorio = reader.GetInt32("tiene_auditorio") == 1;
                    sede.TieneBiblioteca = reader.GetInt32("tiene_biblioteca") == 1;
                    sede.TieneEstacionamiento = reader.GetInt32("tiene_estacionamiento") == 1;
                    sede.TieneSalasEstudio = reader.GetInt32("tiene_salas_estudio") == 1;
                    sede.TieneCafeteria = reader.GetInt32("tiene_cafeteria") == 1;
                    sede.Ejecutivo.IdEjecutivo = reader.GetInt32("id_ejecutivo");
                    sede.Ejecutivo.DNI = reader.GetString("DNI");
                    sede.Ejecutivo.Nombre = reader.GetString("nombre_ejecutivo");
                    sede.Ejecutivo.ApellidoPaterno = reader.GetString("apellido_paterno");
                    ProgramaAcademicoDAO _daoProgAcad = new ProgramaAcademicoMySQL();
                    sede.ProgramasAcademicos = _daoProgAcad.listarPorIdSede(sede.IdSede);
                    sedes.Add(sede);
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
            return sedes;
        }
    }
}
