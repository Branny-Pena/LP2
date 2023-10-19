using SmashSoft.UniversoService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashSoft
{
    public partial class frmBusquedaUniverso : Form
    {
        private SmashSoftUniversoServiceClient _daoUniverso;

        private universo _universoSeleccionado;

        public universo UniversoSeleccionado { get => _universoSeleccionado; set => _universoSeleccionado = value; }

        public frmBusquedaUniverso()
        {
            InitializeComponent();
            _daoUniverso = new SmashSoftUniversoServiceClient();
            dgvUniverso.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvUniverso.DataSource = _daoUniverso.listarUniversosPorNombre(txtNombre.Text);
        }

        private void dgvUniverso_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            universo univ = (universo)dgvUniverso.Rows[e.RowIndex].DataBoundItem;
            dgvUniverso.Rows[e.RowIndex].Cells[0].Value = univ.idUniverso;
            dgvUniverso.Rows[e.RowIndex].Cells[1].Value = univ.nombre;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvUniverso.CurrentRow.Index != -1)
            {
                UniversoSeleccionado = (universo)dgvUniverso.CurrentRow.DataBoundItem;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
