using GameSoftController.DAO;
using GameSoftController.MySQL;
using GameSoftModel;
using Microsoft.CSharp.RuntimeBinder;
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
    public partial class frmGestionVideojuegos : Form
    {
        private string _rutaFotoPortada = "";
        private Estado _estado;
        private VideojuegoDAO _daoVideojuego;
        private GeneroDAO _daoGenero;
        private Videojuego _videojuego;
        public frmGestionVideojuegos()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            _daoVideojuego = new VideojuegoMySql();
            _daoGenero = new GeneroMySql();
            cboGenero.DataSource = _daoGenero.listarGeneros();
            cboGenero.DisplayMember = "Nombre";
            cboGenero.ValueMember = "IdGenero";
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void limpiarComponentes()
        {
            txtIdVideojuego.Text = "";
            txtNombre.Text = "";
            txtDesarrolladora.Text = "";
            cboGenero.SelectedIndex = -1;
            rbPlaystation.Checked = false;
            rbNintendo.Checked = false;
            rbXbox.Checked = false;
            nudMaxJugadores.Value = 1;
            cbCooperativo.Checked = false;
            cbMultiplayer.Checked = false;
            cbEdicionEspecial.Checked = false;
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            pbPortada.Image = null;
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscarDesarrolladora.Enabled = false;
                    btnSubirPortada.Enabled = false;
                    txtIdVideojuego.Enabled = false;
                    txtNombre.Enabled = false;
                    txtDesarrolladora.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cboGenero.Enabled = false;
                    rbPlaystation.Enabled = false;
                    rbNintendo.Enabled = false;
                    rbXbox.Enabled = false;
                    nudMaxJugadores.Enabled = false;
                    cbCooperativo.Enabled = false;
                    cbMultiplayer.Enabled = false;
                    cbEdicionEspecial.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscarDesarrolladora.Enabled = true;
                    btnSubirPortada.Enabled = true;
                    txtIdVideojuego.Enabled = true;
                    txtNombre.Enabled = true;
                    txtDesarrolladora.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtDescripcion.Enabled = true;
                    cboGenero.Enabled = true;
                    rbPlaystation.Enabled = true;
                    rbNintendo.Enabled = true;
                    rbXbox.Enabled = true;
                    nudMaxJugadores.Enabled = true;
                    cbCooperativo.Enabled = true;
                    cbMultiplayer.Enabled = true;
                    cbEdicionEspecial.Enabled = true;
                    break;
            }
        }

        private void btnSubirPortada_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPortada.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoPortada = ofdPortada.FileName;
                    pbPortada.Image = Image.FromFile(_rutaFotoPortada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _videojuego = new Videojuego();
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _videojuego.Desarrolladora = new Desarrolladora();
            _videojuego.Genero = new Genero();
            _videojuego.Desarrolladora.IdDesarrolladora = 1;
            _videojuego.Nombre = txtNombre.Text;
            _videojuego.Genero.IdGenero = (int)cboGenero.SelectedValue;
            if (rbNintendo.Checked) _videojuego.Plataforma = 'N';
            if (rbPlaystation.Checked) _videojuego.Plataforma = 'P';
            if (rbXbox.Checked) _videojuego.Plataforma = 'X';
            _videojuego.MaxJugadores = Int32.Parse(nudMaxJugadores.Text);
            _videojuego.Cooperativo = cbCooperativo.Checked;
            _videojuego.Multiplayer = cbMultiplayer.Checked;
            _videojuego.EdicionEspecial = cbEdicionEspecial.Checked;
            _videojuego.Precio = Double.Parse(txtPrecio.Text);
            _videojuego.Descripcion = txtDescripcion.Text;
            int resultado = _daoVideojuego.insertar(_videojuego);
            if (resultado != 0)
            {
                txtIdVideojuego.Text = _videojuego.IdVideojuego.ToString();
                MessageBox.Show("El empleado se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscarDesarrolladora_Click(object sender, EventArgs e)
        {
            frmBusquedaDesarrolladoras formBusqDesa = new frmBusquedaDesarrolladoras();
            if (formBusqDesa.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmGestionVideojuegos_Load(object sender, EventArgs e)
        {

        }
    }
}
