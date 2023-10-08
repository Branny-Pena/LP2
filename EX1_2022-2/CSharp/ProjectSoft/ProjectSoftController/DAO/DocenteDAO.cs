using ProjectSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSoftController.DAO
{
    public interface DocenteDAO
    {
        BindingList<Docente> listarPorCodigoPUCPNombre(string codigoPUCPNombre);
        BindingList<Docente> listarPorIdProyecto(int id);
    }
}
