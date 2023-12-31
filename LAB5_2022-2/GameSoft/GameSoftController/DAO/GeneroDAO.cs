﻿using GameSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftController.DAO
{
    public interface GeneroDAO
    {
        int insertar(Genero genero);
        int modificar(Genero genero);
        int eliminar(int idGenero);
        BindingList<Genero> listarGeneros();
    }
}
