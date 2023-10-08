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
    public class ProgramaAcademicoMySQL : ProgramaAcademicoDAO
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public BindingList<ProgramaAcademico> listarPorIdSede(int id)
        {
            BindingList<ProgramaAcademico> programasAcademicos = new BindingList<ProgramaAcademico>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_PROGRAMAS_ACADEMICOS_X_ID_SEDE";
                command.Parameters.AddWithValue("_id_sede", id);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProgramaAcademico programaAcademico = new ProgramaAcademico();
                    programaAcademico.IdProgramaAcademico = reader.GetInt32("id_programa_academico");
                    programaAcademico.TipoProgramaAcademico = reader.GetChar("fid_tipo_programa_academico");
                    programaAcademico.Clave = reader.GetString("clave");
                    programaAcademico.Nombre = reader.GetString("nombre");
                    if (programaAcademico.TipoProgramaAcademico == 'T')
                    {
                        Taller taller = new Taller();
                        taller.IdProgramaAcademico = programaAcademico.IdProgramaAcademico;
                        taller.TipoProgramaAcademico = programaAcademico.TipoProgramaAcademico;
                        taller.Clave = programaAcademico.Clave;
                        taller.Nombre = programaAcademico.Nombre;
                        taller.CantidadHoras = reader.GetInt32("cantidad_horas");
                        taller.FechaRealizacion = reader.GetDateTime("fecha_realizacion");
                        programasAcademicos.Add(taller);
                    }
                    if (programaAcademico.TipoProgramaAcademico == 'C')
                    {
                        Curso curso = new Curso();
                        curso.IdProgramaAcademico = programaAcademico.IdProgramaAcademico;
                        curso.TipoProgramaAcademico = programaAcademico.TipoProgramaAcademico;
                        curso.Clave = programaAcademico.Clave;
                        curso.Nombre = programaAcademico.Nombre;
                        curso.CantidadCreditos = reader.GetInt32("cantidad_creditos");
                        curso.FechaInicio = reader.GetDateTime("fecha_inicio");
                        programasAcademicos.Add(curso);
                    }
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
            return programasAcademicos;
        }

        public BindingList<ProgramaAcademico> listarPorNombreClave(string nombreClave)
        {
            BindingList<ProgramaAcademico> programasAcademicos = new BindingList<ProgramaAcademico>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_PROGRAMAS_ACADEMICOS_X_NOMBRE_CLAVE";
                command.Parameters.AddWithValue("_nombre_clave", nombreClave);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProgramaAcademico programaAcademico = new ProgramaAcademico();
                    programaAcademico.IdProgramaAcademico = reader.GetInt32("id_programa_academico");
                    programaAcademico.TipoProgramaAcademico = reader.GetChar("fid_tipo_programa_academico");
                    programaAcademico.Clave = reader.GetString("clave");
                    programaAcademico.Nombre = reader.GetString("nombre");
                    if (programaAcademico.TipoProgramaAcademico == 'T')
                    {
                        Taller taller = new Taller();
                        taller.IdProgramaAcademico = programaAcademico.IdProgramaAcademico;
                        taller.TipoProgramaAcademico = programaAcademico.TipoProgramaAcademico;
                        taller.Clave = programaAcademico.Clave;
                        taller.Nombre = programaAcademico.Nombre;
                        taller.CantidadHoras = reader.GetInt32("cantidad_horas");
                        taller.FechaRealizacion = reader.GetDateTime("fecha_realizacion");
                        programasAcademicos.Add(taller);
                    }                       
                    if (programaAcademico.TipoProgramaAcademico == 'C')
                    {
                        Curso curso = new Curso();
                        curso.IdProgramaAcademico = programaAcademico.IdProgramaAcademico;
                        curso.TipoProgramaAcademico = programaAcademico.TipoProgramaAcademico;
                        curso.Clave = programaAcademico.Clave;
                        curso.Nombre = programaAcademico.Nombre;
                        curso.CantidadCreditos = reader.GetInt32("cantidad_creditos");
                        curso.FechaInicio = reader.GetDateTime("fecha_inicio");
                        programasAcademicos.Add(curso);
                    }
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
            return programasAcademicos;
        }
    }
}
