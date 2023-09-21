using EventSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSoftController.DAO
{
    public interface LocalDAO
    {
        int insertar(Local local);
        int modificar(Local local);
        int eliminar(int id);
        BindingList<Local> listarTodas(string nombre);
    }
}
