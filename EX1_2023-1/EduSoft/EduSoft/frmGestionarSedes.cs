using EduSoftController.DAO;
using EduSoftController.MySQL;
using EduSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduSoft
{
    /* Coloque sus datos
        * -------------------------------------------------
        * Nombre Completo: 
        * Código PUCP:
        * Fecha de Modificación: 
    */
    public partial class frmGestionarSedes : Form
    {

        private Estado _estado;
        private string _rutaFotoLocal;

        private TipoSedeDAO _daoTipoSede;
        private SedeDAO _daoSede;

        private Ejecutivo _ejecutivo;
        private ProgramaAcademico _programaAcademico;
        private Sede _sede;

        public frmGestionarSedes()
        {
            InitializeComponent();
            dgvProgramasAcademicos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProgramasAcademicos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _estado = Estado.Inicial;
            _daoTipoSede = new TipoSedeMySQL();
            _daoSede = new SedeMySQL();
            cboTipoSede.DataSource = _daoTipoSede.listarTodos();
            cboTipoSede.DisplayMember = "Nombre";
            cboTipoSede.ValueMember = "IdTipoSede";
            limpiarComponentes();
            establecerEstadoComponentes();
            
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
                    btnSubirFoto.Enabled = false;
                    btnBuscarEjecutivoResponsable.Enabled = false;
                    btnBuscarPrograma.Enabled = false;
                    btnAgregarProgramaAcademico.Enabled = false;
                    btnEliminarProgramaAcademico.Enabled = false;
                    txtIDSede.Enabled = false;
                    txtNombre.Enabled = false;
                    txtNombre.ReadOnly = false;
                    txtDireccion.Enabled = false;
                    txtDireccion.ReadOnly = false;
                    dtpFechaInauguracion.Enabled = false;
                    cboTipoSede.Enabled = false;
                    txtCantAulas.Enabled = false;
                    txtCantAulas.ReadOnly = false;
                    txtAforo.Enabled = false;
                    txtAforo.ReadOnly = false;
                    txtDNIEjecutivoResp.Enabled = false;
                    txtNombreEjecutivoResp.Enabled = false;
                    cbAuditorio.Enabled = false;
                    cbBiblioteca.Enabled = false;
                    cbEstacionamiento.Enabled = false;
                    cbSalasEstudio.Enabled = false;
                    cbCafeteria.Enabled = false;
                    txtClavePrograma.Enabled = false;
                    txtTipoPrograma.Enabled = false;
                    txtNombrePrograma.Enabled = false;
                    dgvProgramasAcademicos.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    btnBuscarEjecutivoResponsable.Enabled = true;
                    btnBuscarPrograma.Enabled = true;
                    btnAgregarProgramaAcademico.Enabled = true;
                    btnEliminarProgramaAcademico.Enabled = true;
                    txtIDSede.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = false;
                    txtDireccion.Enabled = true;
                    txtDireccion.ReadOnly = false;
                    dtpFechaInauguracion.Enabled = true;
                    cboTipoSede.Enabled = true;
                    txtCantAulas.Enabled = true;
                    txtCantAulas.ReadOnly = false;
                    txtAforo.Enabled = true;
                    txtAforo.ReadOnly = false;
                    txtDNIEjecutivoResp.Enabled = true;
                    txtNombreEjecutivoResp.Enabled = true;
                    cbAuditorio.Enabled = true;
                    cbBiblioteca.Enabled = true;
                    cbEstacionamiento.Enabled = true;
                    cbSalasEstudio.Enabled = true;
                    cbCafeteria.Enabled = true;
                    txtClavePrograma.Enabled = true;
                    txtTipoPrograma.Enabled = true;
                    txtNombrePrograma.Enabled = true;
                    dgvProgramasAcademicos.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    btnBuscarEjecutivoResponsable.Enabled = false;
                    btnBuscarPrograma.Enabled = false;
                    btnAgregarProgramaAcademico.Enabled = false;
                    btnEliminarProgramaAcademico.Enabled = false;
                    txtIDSede.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = true;
                    txtDireccion.Enabled = true;
                    txtDireccion.ReadOnly = true;
                    dtpFechaInauguracion.Enabled = false;
                    cboTipoSede.Enabled = false;
                    txtCantAulas.Enabled = true;
                    txtCantAulas.ReadOnly = true;
                    txtAforo.Enabled = true;
                    txtAforo.ReadOnly = true;
                    txtDNIEjecutivoResp.Enabled = true;
                    txtNombreEjecutivoResp.Enabled = true;
                    cbAuditorio.Enabled = false;
                    cbBiblioteca.Enabled = false;
                    cbEstacionamiento.Enabled = false;
                    cbSalasEstudio.Enabled = false;
                    cbCafeteria.Enabled = false;
                    txtClavePrograma.Enabled = false;
                    txtTipoPrograma.Enabled = false;
                    txtNombrePrograma.Enabled = false;
                    dgvProgramasAcademicos.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDSede.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            dtpFechaInauguracion.Value = DateTime.Now;
            cboTipoSede.SelectedIndex = -1;
            txtCantAulas.Text = "";
            txtAforo.Text = "";
            pbFoto.Image = null;
            txtDNIEjecutivoResp.Text = "";
            txtNombreEjecutivoResp.Text = "";
            cbAuditorio.Checked = false;
            cbBiblioteca.Checked = false;
            cbEstacionamiento.Checked = false;
            cbSalasEstudio.Checked = false;
            cbCafeteria.Checked = false;
            dgvProgramasAcademicos.DataSource = null;
            _sede = new Sede();
            _sede.ProgramasAcademicos = new BindingList<ProgramaAcademico>();
            dgvProgramasAcademicos.DataSource = _sede.ProgramasAcademicos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
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

        private void btnBuscarEjecutivoResponsable_Click(object sender, EventArgs e)
        {
            //_estado = Estado.Buscar;
            //establecerEstadoComponentes();
            frmBusquedaEjecutivos formBusqEjec = new frmBusquedaEjecutivos();
            if (formBusqEjec.ShowDialog() == DialogResult.OK)
            {
                _ejecutivo = formBusqEjec.EjecutivoSeleccionado;
                txtDNIEjecutivoResp.Text = _ejecutivo.DNI.ToString();
                txtNombreEjecutivoResp.Text = _ejecutivo.Nombre + " " + _ejecutivo.ApellidoPaterno;
            }

        }

        private void btnBuscarPrograma_Click(object sender, EventArgs e)
        {
            frmBusquedaProgramasAcademicos formBusqProg = new frmBusquedaProgramasAcademicos();
            if(formBusqProg.ShowDialog() == DialogResult.OK)
            {
                _programaAcademico = formBusqProg.ProgramaAcademicoSeleccionado;
                txtClavePrograma.Text = _programaAcademico.Clave;
                if (_programaAcademico.TipoProgramaAcademico == 'C')
                {
                    txtTipoPrograma.Text = "CURSO";
                }
                if(_programaAcademico.TipoProgramaAcademico == 'T')
                {
                    txtTipoPrograma.Text = "CURSO";
                }
                txtNombrePrograma.Text = _programaAcademico.Nombre;
            }
        }

        private void btnAgregarProgramaAcademico_Click(object sender, EventArgs e)
        {
            if (txtClavePrograma.Text == "")
            {
                MessageBox.Show("Debe seleccionar un programa academico", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _sede.ProgramasAcademicos.Add(_programaAcademico);
            txtClavePrograma.Text = "";
            txtTipoPrograma.Text = "";
            txtNombrePrograma.Text = "";
        }

        private void dgvProgramasAcademicos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                ProgramaAcademico programaAcademico = (ProgramaAcademico)dgvProgramasAcademicos.Rows[e.RowIndex].DataBoundItem;
                if (programaAcademico.TipoProgramaAcademico == 'C')
                {
                    dgvProgramasAcademicos.Rows[e.RowIndex].Cells[0].Value = "CURSO";
                    dgvProgramasAcademicos.Rows[e.RowIndex].Cells[3].Value = ((Curso)programaAcademico).CantidadCreditos;
                    dgvProgramasAcademicos.Rows[e.RowIndex].Cells[4].Value = ((Curso)programaAcademico).FechaInicio.ToShortDateString();
                }
                if (programaAcademico.TipoProgramaAcademico == 'T')
                {
                    dgvProgramasAcademicos.Rows[e.RowIndex].Cells[0].Value = "TALLER";
                    dgvProgramasAcademicos.Rows[e.RowIndex].Cells[3].Value = ((Taller)programaAcademico).CantidadHoras;
                    dgvProgramasAcademicos.Rows[e.RowIndex].Cells[4].Value = ((Taller)programaAcademico).FechaRealizacion.ToShortDateString();
                }
                dgvProgramasAcademicos.Rows[e.RowIndex].Cells[1].Value = programaAcademico.Clave;
                dgvProgramasAcademicos.Rows[e.RowIndex].Cells[2].Value = programaAcademico.Nombre;
            }
            catch(Exception ex)
            {

            }
            
        }

        private void btnEliminarProgramaAcademico_Click(object sender, EventArgs e)
        {
            if (dgvProgramasAcademicos.CurrentRow != null)
            {
                ProgramaAcademico progAcad = (ProgramaAcademico)dgvProgramasAcademicos.CurrentRow.DataBoundItem;
                this._sede.ProgramasAcademicos.Remove(progAcad);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una linea de orden de venta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _sede.Ejecutivo = _ejecutivo;
            _sede.Nombre = txtNombre.Text;
            _sede.Direccion = txtDireccion.Text;
            _sede.FechaInauguracion = dtpFechaInauguracion.Value;
            _sede.TipoSede = new TipoSede();
            _sede.TipoSede.IdTipoSede = (int)cboTipoSede.SelectedValue;
            _sede.CantidadAulas = Int32.Parse(txtCantAulas.Text);
            _sede.AforoTotal = Int32.Parse(txtAforo.Text);
            _sede.Ejecutivo = _ejecutivo;
            _sede.TieneAuditorio = cbAuditorio.Checked;
            _sede.TieneBiblioteca = cbBiblioteca.Checked;   
            _sede.TieneEstacionamiento = cbEstacionamiento.Checked;
            _sede.TieneSalasEstudio = cbSalasEstudio.Checked;
            _sede.TieneCafeteria = cbCafeteria.Checked;
            FileStream fs = new FileStream(_rutaFotoLocal, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _sede.Foto = br.ReadBytes((int)fs.Length);
            fs.Close();
            int resultado = _daoSede.insertar(_sede);
            if (resultado != 0)
            {
                txtIDSede.Text = _sede.IdSede.ToString();
                MessageBox.Show("Se ha registrado con éxito la sede", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
                MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaSedes formBusquSedes = new frmBusquedaSedes();
            if(formBusquSedes.ShowDialog() == DialogResult.OK)
            {
                _sede = formBusquSedes.SedeSeleccionada;
                txtIDSede.Text = _sede.IdSede.ToString();
                txtNombre.Text = _sede.Nombre;
                txtDireccion.Text = _sede.Direccion;
                dtpFechaInauguracion.Value = _sede.FechaInauguracion;
                txtCantAulas.Text = _sede.CantidadAulas.ToString();
                txtAforo.Text = _sede.AforoTotal.ToString();
                txtDNIEjecutivoResp.Text = _sede.Ejecutivo.DNI;
                txtNombreEjecutivoResp.Text = _sede.Ejecutivo.Nombre + " " + _sede.Ejecutivo.ApellidoPaterno;
                cbAuditorio.Checked = _sede.TieneAuditorio;
                cbBiblioteca.Checked = _sede.TieneBiblioteca;
                cbCafeteria.Checked = _sede.TieneCafeteria;
                cbEstacionamiento.Checked = _sede.TieneEstacionamiento;
                cbSalasEstudio.Checked = _sede.TieneSalasEstudio;
                cboTipoSede.Text = _sede.TipoSede.Nombre;
                MemoryStream ms = new MemoryStream(_sede.Foto);
                pbFoto.Image = new Bitmap(ms);
                dgvProgramasAcademicos.DataSource = _sede.ProgramasAcademicos;
            }
        }
    }
}
