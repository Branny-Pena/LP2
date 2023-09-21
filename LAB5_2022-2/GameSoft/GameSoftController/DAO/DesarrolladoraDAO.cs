using GameSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftController.DAO
{
    public interface DesarrolladoraDAO
    {
        int insertar(Desarrolladora desarroladora);
        int modificar(Desarrolladora desarrolladora);
        int eliminar(int idDesarrolladora);
        BindingList<Desarrolladora> listarTodas(string nombre);
    }
}
