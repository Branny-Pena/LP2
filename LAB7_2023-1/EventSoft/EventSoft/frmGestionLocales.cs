using EventSoftController.DAO;
using EventSoftController.MySQL;
using EventSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Coloque sus datos
    * -------------------------------------------
    * Nombre Completo:
    * Código PUCP:
    * Fecha de Modificación: 
*/

namespace EventSoft
{
    public partial class frmGestionLocales : Form
    {
        
        private string _rutaFotoLocal = "";
        private string _rutaArchivoPlano = "";
        private Estado _estado;
        private Local _local;
        private LocalDAO _localDAO;
        private EstiloArquitectonicoDAO _estiloArquiDAO;
        public frmGestionLocales()
        {
            InitializeComponent();
            _localDAO = new LocalMySQL();
            _estiloArquiDAO = new EstiloArquitectonicoMySQL();
            _estado = Estado.Inicial;
            cboEstiloArquitectonico.DataSource = _estiloArquiDAO.listarTodas();
            cboEstiloArquitectonico.DisplayMember = "Nombre";
            cboEstiloArquitectonico.ValueMember = "IdEstiloArquitectonico";
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoLocal = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFotoLocal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gbDatosGenerales.Enabled = false;
                    btnSubirPDF.Enabled = false;
                    btnDescargarPDF.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    txtNombre.ReadOnly = false;
                    txtDireccion.ReadOnly = false;
                    txtAforo.ReadOnly = false;
                    txtResenha.ReadOnly = false;
                    dtpFechaConstruccion.Enabled = false;
                    cboEstiloArquitectonico.Enabled = false;
                    cbPalco.Enabled = false;
                    cbProyector.Enabled = false;
                    cbVestibulo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gbDatosGenerales.Enabled = true;
                    btnSubirPDF.Enabled = true;
                    btnDescargarPDF.Enabled = false;
                    btnSubirFoto.Enabled = true;
                    txtNombre.ReadOnly = false;
                    txtDireccion.ReadOnly = false;
                    txtAforo.ReadOnly = false;
                    txtResenha.ReadOnly = false;
                    dtpFechaConstruccion.Enabled = true;
                    cboEstiloArquitectonico.Enabled = true;
                    cbPalco.Enabled = true;
                    cbProyector.Enabled = true;
                    cbVestibulo.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gbDatosGenerales.Enabled = true;
                    btnSubirPDF.Enabled = false;
                    btnDescargarPDF.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    txtNombre.ReadOnly = true;
                    txtDireccion.ReadOnly = true;
                    txtAforo.ReadOnly = true;
                    txtResenha.ReadOnly = true;
                    dtpFechaConstruccion.Enabled = false;
                    cboEstiloArquitectonico.Enabled = false;
                    cbPalco.Enabled = false;
                    cbProyector.Enabled = false;
                    cbVestibulo.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtAforo.Text = "";
            dtpFechaConstruccion.Value = DateTime.Now;
            cboEstiloArquitectonico.SelectedIndex = -1;
            cbPalco.Checked = false;
            cbProyector.Checked = false;
            cbVestibulo.Checked = false;
            txtResenha.Text = "";
            txtPlano.Text = "";
            pbFoto.Image = null;
            _rutaFotoLocal = "";
            _rutaArchivoPlano = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _local = new Local();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnSubirPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPlano.ShowDialog() == DialogResult.OK)
                {
                    _rutaArchivoPlano = ofdPlano.FileName;
                    txtPlano.Text = _rutaArchivoPlano;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al seleccionar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaLocales formBusqLoc = new frmBusquedaLocales();
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            if(formBusqLoc.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            if (sfdPlano.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String archivoGenerar = sfdPlano.FileName;
                    MessageBox.Show("Se ha guardado el archivo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha generado un error al momento de guardar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmGestionLocales_Load(object sender, EventArgs e)
        {

        }

        private void gbDatosGenerales_Enter(object sender, EventArgs e)
        {

        }

        private void cboEstiloArquitectonico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _local.EstiloArquitectonico = new EstiloArquitectonico();
            _local.Nombre = txtNombre.Text;
            _local.Direccion = txtDireccion.Text;
            if (cbVestibulo.Checked) _local.TieneVestibulo = true;
            else _local.TieneVestibulo = false;
            if (cbPalco.Checked) _local.TienePalco = true;
            else _local.TienePalco = false;
            if(cbProyector.Checked) _local.TieneProyector = true;
            else _local.TieneProyector = false;
            _local.Resenha = txtResenha.Text;
            _local.FechaConstruccion = dtpFechaConstruccion.Value;
            _local.EstiloArquitectonico.IdEstiloArquitectonico = (int)cboEstiloArquitectonico.SelectedValue;
            int resultado = _localDAO.insertar(_local);
            if (resultado != 0)
            {
                txtID.Text = _local.IdLocal.ToString();
                MessageBox.Show("El local se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
