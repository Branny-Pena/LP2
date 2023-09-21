using EventSoftController.DAO;
using EventSoftController.MySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSoft
{
    public partial class frmBusquedaLocales : Form
    {
        private LocalDAO _localDAO;
        public frmBusquedaLocales()
        {   
            _localDAO = new LocalMySQL();
            InitializeComponent();
            dgvLocales.AutoGenerateColumns = false;
        }

        private void frmBusquedaLocales_Load(object sender, EventArgs e)
        {

        }

        private void dgvLocales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            dgvLocales.DataSource = _localDAO.listarTodas(nombre);
        }
    }
}
