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
    public class VideojuegoMySql : VideojuegoDAO
    {
        private MySqlCommand command;
        private MySqlConnection con;
        private MySqlDataReader reader;
        public int eliminar(int idVideojuego)
        {
            throw new NotImplementedException();
        }

        public int insertar(Videojuego videojuego)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "INSERTAR_VIDEOJUEGO";
                command.Parameters.Add("_id_videojuego", MySqlDbType.Int32).Direction =
                    ParameterDirection.Output;
                command.Parameters.AddWithValue("_fid_desarrolladora", videojuego.Desarrolladora.IdDesarrolladora);
                command.Parameters.AddWithValue("_fid_genero", videojuego.Genero.IdGenero);
                command.Parameters.AddWithValue("_fid_plataforma", videojuego.Plataforma);
                command.Parameters.AddWithValue("_nombre", videojuego.Nombre);
                command.Parameters.AddWithValue("_max_jugadores", videojuego.MaxJugadores);
                command.Parameters.AddWithValue("_es_cooperativo", videojuego.Cooperativo);
                command.Parameters.AddWithValue("_es_multiplayer", videojuego.Multiplayer);
                command.Parameters.AddWithValue("_es_edicion_especial", videojuego.EdicionEspecial);
                command.Parameters.AddWithValue("_precio", videojuego.Precio);
                command.Parameters.AddWithValue("_descripcion", videojuego.Descripcion);
                command.Parameters.AddWithValue("_portada", videojuego.Portada);
                resultado = command.ExecuteNonQuery();
                videojuego.IdVideojuego =
                    Int32.Parse(command.Parameters["_id_videojuego"].Value.ToString());
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

        public BindingList<Videojuego> listarTodas(string nombre)
        {
            BindingList<Videojuego> videojuegos = new BindingList<Videojuego>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                command = new MySqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LISTAR_VIDEOJUEGOS_POR_NOMBRE";
                command.Parameters.AddWithValue("_nombre", nombre);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Videojuego videojuego = new Videojuego();
                    videojuego.IdVideojuego = reader.GetInt32("v.id_videojuego");
                    videojuego.Desarrolladora.IdDesarrolladora = reader.GetInt32("d.id_desarrolladora");
                    videojuego.Desarrolladora.Nombre = reader.GetString("nombre_desarrolladora");
                    videojuego.Genero.IdGenero = reader.GetInt32("g.id_genero");
                    videojuego.Genero.Nombre = reader.GetString("nombre_genero");
                    videojuego.Plataforma = reader.GetChar("p.id_plataforma");
                    videojuego.Nombre = reader.GetString("nombre_videojuego");
                    videojuego.MaxJugadores = reader.GetInt32("v.max_jugadores");
                    videojuego.Cooperativo = (reader.GetInt32("v.es_cooperativo") != 0);
                    videojuego.Multiplayer = (reader.GetInt32("v.es_multiplayer") != 0);
                    videojuego.EdicionEspecial = (reader.GetInt32("v.es_edicion_especial") != 0);
                    videojuego.Precio = reader.GetDouble("v.precio");
                    videojuego.Descripcion = reader.GetString("v.descripcion");
                    videojuegos.Add(videojuego);
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
            return videojuegos;
        }

        public int modificar(Videojuego videojuego)
        {
            throw new NotImplementedException();
        }
    }
}
