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
    public partial class frmBusquedaEstudiantes : Form
    {
        private EstudianteDAO _daoEstudiante;

        private Estudiante _estudianteSeleccionado;
        public frmBusquedaEstudiantes()
        {
            InitializeComponent();
            dgvEstudiantes.AutoGenerateColumns = false;
            _daoEstudiante = new EstudianteMySQL();
        }

        public Estudiante EstudianteSeleccionado { get => _estudianteSeleccionado; set => _estudianteSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = _daoEstudiante.listarPorCodigoPUCPNombre(txtCodigoNombre.Text);
        }

        private void dgvEstudiantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Estudiante estudiante = (Estudiante)dgvEstudiantes.Rows[e.RowIndex].DataBoundItem;
            dgvEstudiantes.Rows[e.RowIndex].Cells[0].Value = estudiante.CodigoPUCP;
            dgvEstudiantes.Rows[e.RowIndex].Cells[1].Value = estudiante.Nombre + " " + estudiante.ApellidoPaterno;
            dgvEstudiantes.Rows[e.RowIndex].Cells[2].Value = estudiante.CRAEST;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow.Index != -1)
            {
                _estudianteSeleccionado = (Estudiante)dgvEstudiantes.CurrentRow.DataBoundItem;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
