using GameSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftController.DAO
{
    public interface VideojuegoDAO
    {
        int insertar(Videojuego videojuego);
        int modificar(Videojuego videojuego);
        int eliminar(int idVideojuego);
        BindingList<Videojuego> listarTodas(string nombre);
    }
}
