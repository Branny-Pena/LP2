using LP2SoftRRHHController.DAO;
using LP2SoftRRHHController.MySQL;
using LP2SoftRRHHModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2SoftAE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Area area = new Area();
            area.Nombre = textBox1.Text;
            //insertar el area
            AreaDAO daoArea = new AreaMySQL();
            int resultado = daoArea.insertar(area);
            if(resultado != 0)
            {
                textBox2.Text = area.IdArea.ToString();
                MessageBox.Show("Se ha registrado con exito",
                    "Mensaje de confirmacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
