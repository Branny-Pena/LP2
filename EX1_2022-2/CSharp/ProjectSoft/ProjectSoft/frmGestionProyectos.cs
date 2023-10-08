using ProjectSoftController.DAO;
using ProjectSoftController.MySQL;
using ProjectSoftModel;
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

namespace ProjectSoft
{
    public partial class frmGestionProyectos : Form
    {
        private Estado _estado;
        private string _rutaArchivoPDF = "";
        private string _rutaFoto = "";

        private AreaDAO _daoArea;
        private ProyectoDAO _daoProyecto;

        private Estudiante _estudiante;
        private Docente _docente;
        private Proyecto _proyecto;
        public frmGestionProyectos()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            _daoArea = new AreaMySQL();
            _daoProyecto = new ProyectoMySQL();
            cboArea.DataSource = _daoArea.listarTodas();
            cboArea.ValueMember = "IdArea";
            cboArea.DisplayMember = "Nombre";
            dgvJurados.AutoGenerateColumns = false;
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
                    txtEstudiante.Enabled = false;
                    btnBuscarEstudiante.Enabled = false;
                    txtTitulo.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cboArea.Enabled = false;
                    btnSubirArchivo.Enabled = false;
                    btnDescargarArchivo.Enabled = false;
                    txtRutaArchivo.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    txtCodigoPUCPDocente.Enabled = false;
                    txtNombreCompletoDocente.Enabled = false;
                    btnBuscarDocente.Enabled = false;
                    btnAgregarJurado.Enabled = false;
                    btnEliminarJurado.Enabled = false;
                    dgvJurados.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtEstudiante.Enabled = true;
                    btnBuscarEstudiante.Enabled = true;
                    txtTitulo.Enabled = true;
                    txtDescripcion.Enabled = true;
                    cboArea.Enabled = true;
                    btnSubirArchivo.Enabled = true;
                    btnDescargarArchivo.Enabled = false;
                    txtRutaArchivo.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    txtCodigoPUCPDocente.Enabled = true;
                    txtNombreCompletoDocente.Enabled = true;
                    btnBuscarDocente.Enabled = true;
                    btnAgregarJurado.Enabled = true;
                    btnEliminarJurado.Enabled = true;
                    dgvJurados.Enabled = true;
                    break;
                case Estado.Guardar:
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtEstudiante.Enabled = true;
                    btnBuscarEstudiante.Enabled = false;
                    txtTitulo.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cboArea.Enabled = false;
                    btnSubirArchivo.Enabled = false;
                    btnDescargarArchivo.Enabled = true;
                    txtRutaArchivo.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    txtCodigoPUCPDocente.Enabled = false;
                    txtNombreCompletoDocente.Enabled = false;
                    btnBuscarDocente.Enabled = false;
                    btnAgregarJurado.Enabled = false;
                    btnEliminarJurado.Enabled = false;
                    dgvJurados.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtEstudiante.Text = "";
            txtTitulo.Text = "";
            txtDescripcion.Text = "";
            cboArea.SelectedIndex = -1;
            pbFoto.Image = null;
            _rutaArchivoPDF = "";
            _rutaFoto = "";
            txtCodigoPUCPDocente.Text = "";
            txtNombreCompletoDocente.Text = "";
            dgvJurados.DataSource = null;
            txtRutaArchivo.Text = "";
            _proyecto = new Proyecto();
            _proyecto.Jurados = new BindingList<Docente>();
            dgvJurados.DataSource = _proyecto.Jurados;
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            frmBusquedaEstudiantes formBusqEst = new frmBusquedaEstudiantes();
            if(formBusqEst.ShowDialog() == DialogResult.OK)
            {
                _estudiante = formBusqEst.EstudianteSeleccionado;
                txtEstudiante.Text = _estudiante.CodigoPUCP.ToString() + " - " + _estudiante.Nombre + " " + _estudiante.ApellidoPaterno +
                    " - " + _estudiante.CRAEST.ToString();
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFoto);
                    /*
                    FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _proyecto.Foto = br.ReadBytes((int)fs.Length);
                     */
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
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdArchivo.ShowDialog() == DialogResult.OK)
                {
                    _rutaArchivoPDF = ofdArchivo.FileName;
                    txtRutaArchivo.Text = _rutaArchivoPDF;
                    FileStream fs = new FileStream(_rutaArchivoPDF, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    //Asignamos el archivo al objeto
                    //this._proyecto.ArchivoTemaTesis = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al seleccionar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargarArchivo_Click(object sender, EventArgs e)
        {
            if (sfdArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String archivoGenerar = sfdArchivo.FileName;
                    //Convertimos el arreglo de Bytes a archivo
                    File.WriteAllBytes(archivoGenerar, this._proyecto.ArchivoTemaTesis);
                    MessageBox.Show("Se ha guardado el archivo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha generado un error al momento de guardar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            frmBusquedaDocentes formBusqDoce = new frmBusquedaDocentes();
            if(formBusqDoce.ShowDialog() == DialogResult.OK)
            {
                _docente = formBusqDoce.DocenteSeleccionado;
                txtCodigoPUCPDocente.Text = _docente.CodigoPUCP;
                txtNombreCompletoDocente.Text = _docente.Nombre + " " + _docente.ApellidoPaterno;
            }
        }

        private void btnAgregarJurado_Click(object sender, EventArgs e)
        {
            if (txtCodigoPUCPDocente.Text == "")
            {
                MessageBox.Show("Debe seleccionar un docente", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _proyecto.Jurados.Add(_docente);
            txtCodigoPUCPDocente.Text = "";
            txtNombreCompletoDocente.Text = "";
        }

        private void dgvJurados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                Docente docente = (Docente)dgvJurados.Rows[e.RowIndex].DataBoundItem;
                dgvJurados.Rows[e.RowIndex].Cells[0].Value = docente.CodigoPUCP;
                dgvJurados.Rows[e.RowIndex].Cells[1].Value = docente.Nombre + " " + docente.ApellidoPaterno;
                dgvJurados.Rows[e.RowIndex].Cells[2].Value = docente.Categoria;
            }
            catch(Exception ex)
            {

            }
        }

        private void btnEliminarJurado_Click(object sender, EventArgs e)
        {
            if (dgvJurados.CurrentRow != null)
            {
                Docente docente = (Docente)dgvJurados.CurrentRow.DataBoundItem;
                this._proyecto.Jurados.Remove(docente);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un jurado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _proyecto.Estudiante = _estudiante;
            _proyecto.Titulo = txtTitulo.Text;
            _proyecto.Descripcion = txtDescripcion.Text;
            _proyecto.Area = new Area();
            _proyecto.Area.IdArea = (int) cboArea.SelectedValue;
            FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _proyecto.Foto = br.ReadBytes((int)fs.Length);
            fs.Close();
            fs = new FileStream(_rutaArchivoPDF, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            _proyecto.ArchivoTemaTesis = br.ReadBytes((int)fs.Length);
            fs.Close();
            int resultado = _daoProyecto.insertar(_proyecto);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha registrado con éxito el proyecto", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
                MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaProyectos formBusqProy = new frmBusquedaProyectos();
            if(formBusqProy.ShowDialog() == DialogResult.OK)
            {
                _proyecto = formBusqProy.ProyectoSeleccionado;
                txtEstudiante.Text = _proyecto.Estudiante.CodigoPUCP.ToString() + " - " + _proyecto.Estudiante.Nombre + " " 
                    + _proyecto.Estudiante.ApellidoPaterno +
                    " - " + _proyecto.Estudiante.CRAEST.ToString();
                txtTitulo.Text = _proyecto.Titulo;
                txtDescripcion.Text = _proyecto.Descripcion;
                MemoryStream ms = new MemoryStream(_proyecto.Foto);
                pbFoto.Image = new Bitmap(ms);
                cboArea.Text = _proyecto.Area.Nombre;
                dgvJurados.DataSource = _proyecto.Jurados;
                btnDescargarArchivo.Enabled = true;
            }
        }
    }
}
