using ProjectSoftController.DAO;
using ProjectSoftController.MySQL;
using ProjectSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSoft
{
    public partial class frmBusquedaDocentes : Form
    {
        private DocenteDAO _daoDocente;
        private Docente _docenteSeleccionado;
        public frmBusquedaDocentes()
        {
            InitializeComponent();
            _daoDocente = new DocenteMySQL();
        }

        public Docente DocenteSeleccionado { get => _docenteSeleccionado; set => _docenteSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDocentes.DataSource = _daoDocente.listarPorCodigoPUCPNombre(txtCodigoNombre.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvDocentes.CurrentRow.Index != -1)
            {
                DocenteSeleccionado = (Docente)dgvDocentes.CurrentRow.DataBoundItem;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void dgvDocentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Docente docente = (Docente)dgvDocentes.Rows[e.RowIndex].DataBoundItem;
            dgvDocentes.Rows[e.RowIndex].Cells[0].Value = docente.CodigoPUCP;
            dgvDocentes.Rows[e.RowIndex].Cells[1].Value = docente.Nombre + " " + docente.ApellidoPaterno;
            dgvDocentes.Rows[e.RowIndex].Cells[2].Value = docente.Categoria;
        }
    }
}
