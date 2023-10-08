using EduSoftController.DAO;
using EduSoftController.MySQL;
using EduSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduSoft
{
    public partial class frmBusquedaSedes : Form
    {
        private SedeDAO _daoSede;

        private Sede _sedeSeleccionada;

        public Sede SedeSeleccionada { get => _sedeSeleccionada; set => _sedeSeleccionada = value; }

        public frmBusquedaSedes()
        {
            InitializeComponent();
            _daoSede = new SedeMySQL();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvSedes.CurrentRow.Index != -1)
            {
                _sedeSeleccionada = (Sede)dgvSedes.CurrentRow.DataBoundItem;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvSedes.DataSource = _daoSede.listarPorNombre(txtNombre.Text);
        }

        private void dgvSedes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Sede sede = (Sede)dgvSedes.Rows[e.RowIndex].DataBoundItem;
            dgvSedes.Rows[e.RowIndex].Cells[0].Value = sede.IdSede;
            dgvSedes.Rows[e.RowIndex].Cells[1].Value = sede.Nombre;
            dgvSedes.Rows[e.RowIndex].Cells[2].Value = sede.Direccion;
        }
    }
}
