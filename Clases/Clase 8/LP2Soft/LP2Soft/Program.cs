using LP2SoftRRHHController.DAO;
using LP2SoftRRHHController.MySQL;
using LP2SoftRRHHModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2Soft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area1 = new Area();
            area1.Nombre = "FINANZAS";

            AreaDAO daoArea = new AreaMySQL();
            //int resultado = daoArea.insertar(area1);
            //if (resultado == 1)
            //{
            //    System.Console.WriteLine("Se ha registrado con exito");
            //}
            //else
            //    System.Console.WriteLine("Ha ocurrido un error con el registro");
            //System.Console.ReadLine();

            BindingList<Area> areas = daoArea.listarTodas();
            foreach (Area area in areas) {
                System.Console.WriteLine(area.IdArea + ". " + area.Nombre);
            }
            System.Console.ReadLine();
        }
    }
}
