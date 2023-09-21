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
    public partial class frmBusquedaVideojuegos : Form
    {
        private VideojuegoDAO _daoVideojuego;
        public frmBusquedaVideojuegos()
        {
            _daoVideojuego = new VideojuegoMySql();
            InitializeComponent();
            dgvVideojuegos.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvVideojuegos.DataSource = _daoVideojuego.listarTodas(txtNombre.Text);

        }

        private void dgvVideojuegos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Videojuego videojuego = (Videojuego) dgvVideojuegos.Rows[e.RowIndex].DataBoundItem;
            dgvVideojuegos.Rows[e.RowIndex].Cells[0].Value = videojuego.IdVideojuego;
            dgvVideojuegos.Rows[e.RowIndex].Cells[1].Value = videojuego.Nombre;
            dgvVideojuegos.Rows[e.RowIndex].Cells[2].Value = videojuego.Plataforma;
        }

        private void frmBusquedaVideojuegos_Load(object sender, EventArgs e)
        {

        }
    }
}
