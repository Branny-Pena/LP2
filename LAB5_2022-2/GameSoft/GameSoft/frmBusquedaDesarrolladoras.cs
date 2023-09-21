using GameSoftController.DAO;
using GameSoftController.MySQL;
using GameSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSoft
{
    public partial class frmBusquedaDesarrolladoras : Form
    {
        private DesarrolladoraDAO _daoDesarrolladora;
        private Desarrolladora _desarrolladora;
        public frmBusquedaDesarrolladoras()
        {
            _daoDesarrolladora = new DesarrolladoraMySql();
            InitializeComponent();
            dgvDesarrolladoras.AutoGenerateColumns = false;
        }

        private void frmBusquedaDesarrolladoras_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDesarrolladoras.DataSource = _daoDesarrolladora.listarTodas(txtNombre.Text);
        }

        private void dgvDesarrolladoras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDesarrolladoras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Desarrolladora desarrolladora = (Desarrolladora)dgvDesarrolladoras.Rows[e.RowIndex].DataBoundItem;
            dgvDesarrolladoras.Rows[e.RowIndex].Cells[0].Value = desarrolladora.IdDesarrolladora;
            dgvDesarrolladoras.Rows[e.RowIndex].Cells[1].Value = desarrolladora.Nombre;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
