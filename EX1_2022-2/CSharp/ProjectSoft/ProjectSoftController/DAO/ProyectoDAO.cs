using ProjectSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSoftController.DAO
{
    public interface ProyectoDAO
    {
        int insertar(Proyecto proyecto);
        BindingList<Proyecto> listarPorTituloCodigoPUCPNombre(string codigoPUCPNombre);
    }
}
