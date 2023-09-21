using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftRRHHModel
{
    internal class Empleado : Persona
    {
        private string _cargo;
        private double _sueldo;
        private bool _activo;
        private Area _area;

        public string Cargo { get => _cargo; set => _cargo = value; }
        public double Sueldo { get => _sueldo; set => _sueldo = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public Area Area { get => _area; set => _area = value; }
    }
}
