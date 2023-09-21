using EventSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSoftController.DAO
{
    public interface EstiloArquitectonicoDAO
    {
        int insertar(EstiloArquitectonico estiloArquitectonico);
        int modificar(EstiloArquitectonico estiloArquitectonico);
        int eliminar(int id);
        BindingList<EstiloArquitectonico> listarTodas();
    }
}
