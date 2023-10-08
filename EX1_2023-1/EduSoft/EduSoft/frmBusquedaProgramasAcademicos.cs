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
using EduSoftController.DAO;
using EduSoftController.MySQL;

namespace EduSoft
{
    public partial class frmBusquedaProgramasAcademicos : Form
    {
        public ProgramaAcademicoDAO _daoProgramaAcademico;
        private ProgramaAcademico _programaAcademicoSeleccionado;

        public ProgramaAcademico ProgramaAcademicoSeleccionado { get => _programaAcademicoSeleccionado; set => _programaAcademicoSeleccionado = value; }

        public frmBusquedaProgramasAcademicos()
        {
            InitializeComponent();
            dgvProgramas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProgramas.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProgramas.AutoGenerateColumns = false;
            _daoProgramaAcademico = new ProgramaAcademicoMySQL();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProgramas.DataSource = _daoProgramaAcademico.listarPorNombreClave(txtNombreClave.Text);
        }

        private void dgvProgramas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ProgramaAcademico programaAcademico = (ProgramaAcademico)dgvProgramas.Rows[e.RowIndex].DataBoundItem;
            if (programaAcademico.TipoProgramaAcademico == 'C')
            {
                dgvProgramas.Rows[e.RowIndex].Cells[0].Value = "CURSO";
                dgvProgramas.Rows[e.RowIndex].Cells[3].Value = ((Curso)programaAcademico).CantidadCreditos;
                dgvProgramas.Rows[e.RowIndex].Cells[4].Value = ((Curso)programaAcademico).FechaInicio.ToShortDateString();
            }
            if (programaAcademico.TipoProgramaAcademico == 'T')
            {
                dgvProgramas.Rows[e.RowIndex].Cells[0].Value = "TALLER";
                dgvProgramas.Rows[e.RowIndex].Cells[3].Value = ((Taller)programaAcademico).CantidadHoras;
                dgvProgramas.Rows[e.RowIndex].Cells[4].Value = ((Taller)programaAcademico).FechaRealizacion.ToShortDateString();
            }
            dgvProgramas.Rows[e.RowIndex].Cells[1].Value = programaAcademico.Clave;
            dgvProgramas.Rows[e.RowIndex].Cells[2].Value = programaAcademico.Nombre;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvProgramas.CurrentRow.Index != -1)
            {
                _programaAcademicoSeleccionado = (ProgramaAcademico)dgvProgramas.CurrentRow.DataBoundItem;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
