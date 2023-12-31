﻿namespace ProjectSoft
{
    partial class frmGestionProyectos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionProyectos));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tcProyecto = new System.Windows.Forms.TabControl();
            this.tpDatosGenerales = new System.Windows.Forms.TabPage();
            this.btnDescargarArchivo = new System.Windows.Forms.Button();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            this.lblArchivoTemaTesis = new System.Windows.Forms.Label();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tpJurados = new System.Windows.Forms.TabPage();
            this.btnBuscarDocente = new System.Windows.Forms.Button();
            this.btnEliminarJurado = new System.Windows.Forms.Button();
            this.btnAgregarJurado = new System.Windows.Forms.Button();
            this.txtNombreCompletoDocente = new System.Windows.Forms.TextBox();
            this.txtCodigoPUCPDocente = new System.Windows.Forms.TextBox();
            this.lblNombreCompletoDocente = new System.Windows.Forms.Label();
            this.lblCodigoPUCPDocente = new System.Windows.Forms.Label();
            this.dgvJurados = new System.Windows.Forms.DataGridView();
            this.CodigoPUCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.sfdArchivo = new System.Windows.Forms.SaveFileDialog();
            this.tsMenu.SuspendLayout();
            this.tcProyecto.SuspendLayout();
            this.tpDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tpJurados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJurados)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMenu.Size = new System.Drawing.Size(1174, 34);
            this.tsMenu.TabIndex = 1;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 29);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 29);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 29);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 33);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tcProyecto
            // 
            this.tcProyecto.Controls.Add(this.tpDatosGenerales);
            this.tcProyecto.Controls.Add(this.tpJurados);
            this.tcProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcProyecto.Location = new System.Drawing.Point(18, 43);
            this.tcProyecto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcProyecto.Name = "tcProyecto";
            this.tcProyecto.SelectedIndex = 0;
            this.tcProyecto.Size = new System.Drawing.Size(1138, 512);
            this.tcProyecto.TabIndex = 3;
            // 
            // tpDatosGenerales
            // 
            this.tpDatosGenerales.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatosGenerales.Controls.Add(this.btnDescargarArchivo);
            this.tpDatosGenerales.Controls.Add(this.btnSubirArchivo);
            this.tpDatosGenerales.Controls.Add(this.lblArchivoTemaTesis);
            this.tpDatosGenerales.Controls.Add(this.btnBuscarEstudiante);
            this.tpDatosGenerales.Controls.Add(this.txtEstudiante);
            this.tpDatosGenerales.Controls.Add(this.lblEstudiante);
            this.tpDatosGenerales.Controls.Add(this.lblArea);
            this.tpDatosGenerales.Controls.Add(this.cboArea);
            this.tpDatosGenerales.Controls.Add(this.btnSubirFoto);
            this.tpDatosGenerales.Controls.Add(this.txtRutaArchivo);
            this.tpDatosGenerales.Controls.Add(this.txtDescripcion);
            this.tpDatosGenerales.Controls.Add(this.lblDescripcion);
            this.tpDatosGenerales.Controls.Add(this.txtTitulo);
            this.tpDatosGenerales.Controls.Add(this.lblTitulo);
            this.tpDatosGenerales.Controls.Add(this.pbFoto);
            this.tpDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDatosGenerales.Location = new System.Drawing.Point(4, 29);
            this.tpDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpDatosGenerales.Name = "tpDatosGenerales";
            this.tpDatosGenerales.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpDatosGenerales.Size = new System.Drawing.Size(1130, 479);
            this.tpDatosGenerales.TabIndex = 0;
            this.tpDatosGenerales.Text = "Datos Generales del Proyecto de Tesis";
            // 
            // btnDescargarArchivo
            // 
            this.btnDescargarArchivo.Location = new System.Drawing.Point(964, 382);
            this.btnDescargarArchivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDescargarArchivo.Name = "btnDescargarArchivo";
            this.btnDescargarArchivo.Size = new System.Drawing.Size(144, 35);
            this.btnDescargarArchivo.TabIndex = 20;
            this.btnDescargarArchivo.Text = "Descargar";
            this.btnDescargarArchivo.UseVisualStyleBackColor = true;
            this.btnDescargarArchivo.Click += new System.EventHandler(this.btnDescargarArchivo_Click);
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.Location = new System.Drawing.Point(812, 382);
            this.btnSubirArchivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(144, 35);
            this.btnSubirArchivo.TabIndex = 19;
            this.btnSubirArchivo.Text = "Subir";
            this.btnSubirArchivo.UseVisualStyleBackColor = true;
            this.btnSubirArchivo.Click += new System.EventHandler(this.btnSubirArchivo_Click);
            // 
            // lblArchivoTemaTesis
            // 
            this.lblArchivoTemaTesis.AutoSize = true;
            this.lblArchivoTemaTesis.Location = new System.Drawing.Point(18, 397);
            this.lblArchivoTemaTesis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchivoTemaTesis.Name = "lblArchivoTemaTesis";
            this.lblArchivoTemaTesis.Size = new System.Drawing.Size(282, 20);
            this.lblArchivoTemaTesis.TabIndex = 18;
            this.lblArchivoTemaTesis.Text = "Archivo PDF del Tema de Tesis:";
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(1053, 65);
            this.btnBuscarEstudiante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(56, 35);
            this.btnBuscarEstudiante.TabIndex = 17;
            this.btnBuscarEstudiante.Text = "...";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(288, 66);
            this.txtEstudiante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.ReadOnly = true;
            this.txtEstudiante.Size = new System.Drawing.Size(754, 26);
            this.txtEstudiante.TabIndex = 16;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(284, 40);
            this.lblEstudiante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(104, 20);
            this.lblEstudiante.TabIndex = 15;
            this.lblEstudiante.Text = "Estudiante:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(18, 338);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(137, 20);
            this.lblArea.TabIndex = 14;
            this.lblArea.Text = "Área Temática:";
            // 
            // cboArea
            // 
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(166, 334);
            this.cboArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(940, 28);
            this.cboArea.TabIndex = 13;
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Location = new System.Drawing.Point(228, 291);
            this.btnSubirFoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(46, 34);
            this.btnSubirFoto.TabIndex = 12;
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(18, 422);
            this.txtRutaArchivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.ReadOnly = true;
            this.txtRutaArchivo.Size = new System.Drawing.Size(1088, 26);
            this.txtRutaArchivo.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(288, 232);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(818, 90);
            this.txtDescripcion.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(284, 208);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(116, 20);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(288, 131);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(818, 64);
            this.txtTitulo.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(284, 106);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 20);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Título:";
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(22, 40);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(251, 284);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 6;
            this.pbFoto.TabStop = false;
            // 
            // tpJurados
            // 
            this.tpJurados.BackColor = System.Drawing.SystemColors.Control;
            this.tpJurados.Controls.Add(this.btnBuscarDocente);
            this.tpJurados.Controls.Add(this.btnEliminarJurado);
            this.tpJurados.Controls.Add(this.btnAgregarJurado);
            this.tpJurados.Controls.Add(this.txtNombreCompletoDocente);
            this.tpJurados.Controls.Add(this.txtCodigoPUCPDocente);
            this.tpJurados.Controls.Add(this.lblNombreCompletoDocente);
            this.tpJurados.Controls.Add(this.lblCodigoPUCPDocente);
            this.tpJurados.Controls.Add(this.dgvJurados);
            this.tpJurados.Location = new System.Drawing.Point(4, 29);
            this.tpJurados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpJurados.Name = "tpJurados";
            this.tpJurados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpJurados.Size = new System.Drawing.Size(1130, 479);
            this.tpJurados.TabIndex = 1;
            this.tpJurados.Text = "Jurados del Proyecto";
            // 
            // btnBuscarDocente
            // 
            this.btnBuscarDocente.Location = new System.Drawing.Point(442, 25);
            this.btnBuscarDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarDocente.Name = "btnBuscarDocente";
            this.btnBuscarDocente.Size = new System.Drawing.Size(50, 35);
            this.btnBuscarDocente.TabIndex = 8;
            this.btnBuscarDocente.Text = "...";
            this.btnBuscarDocente.UseVisualStyleBackColor = true;
            this.btnBuscarDocente.Click += new System.EventHandler(this.btnBuscarDocente_Click);
            // 
            // btnEliminarJurado
            // 
            this.btnEliminarJurado.Location = new System.Drawing.Point(1042, 68);
            this.btnEliminarJurado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarJurado.Name = "btnEliminarJurado";
            this.btnEliminarJurado.Size = new System.Drawing.Size(62, 35);
            this.btnEliminarJurado.TabIndex = 7;
            this.btnEliminarJurado.Text = "-";
            this.btnEliminarJurado.UseVisualStyleBackColor = true;
            this.btnEliminarJurado.Click += new System.EventHandler(this.btnEliminarJurado_Click);
            // 
            // btnAgregarJurado
            // 
            this.btnAgregarJurado.Location = new System.Drawing.Point(980, 68);
            this.btnAgregarJurado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarJurado.Name = "btnAgregarJurado";
            this.btnAgregarJurado.Size = new System.Drawing.Size(62, 35);
            this.btnAgregarJurado.TabIndex = 6;
            this.btnAgregarJurado.Text = "+";
            this.btnAgregarJurado.UseVisualStyleBackColor = true;
            this.btnAgregarJurado.Click += new System.EventHandler(this.btnAgregarJurado_Click);
            // 
            // txtNombreCompletoDocente
            // 
            this.txtNombreCompletoDocente.Location = new System.Drawing.Point(202, 71);
            this.txtNombreCompletoDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreCompletoDocente.Name = "txtNombreCompletoDocente";
            this.txtNombreCompletoDocente.ReadOnly = true;
            this.txtNombreCompletoDocente.Size = new System.Drawing.Size(637, 26);
            this.txtNombreCompletoDocente.TabIndex = 5;
            // 
            // txtCodigoPUCPDocente
            // 
            this.txtCodigoPUCPDocente.Location = new System.Drawing.Point(202, 28);
            this.txtCodigoPUCPDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoPUCPDocente.Name = "txtCodigoPUCPDocente";
            this.txtCodigoPUCPDocente.ReadOnly = true;
            this.txtCodigoPUCPDocente.Size = new System.Drawing.Size(229, 26);
            this.txtCodigoPUCPDocente.TabIndex = 4;
            // 
            // lblNombreCompletoDocente
            // 
            this.lblNombreCompletoDocente.AutoSize = true;
            this.lblNombreCompletoDocente.Location = new System.Drawing.Point(28, 75);
            this.lblNombreCompletoDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompletoDocente.Name = "lblNombreCompletoDocente";
            this.lblNombreCompletoDocente.Size = new System.Drawing.Size(165, 20);
            this.lblNombreCompletoDocente.TabIndex = 3;
            this.lblNombreCompletoDocente.Text = "Nombre Completo:";
            // 
            // lblCodigoPUCPDocente
            // 
            this.lblCodigoPUCPDocente.AutoSize = true;
            this.lblCodigoPUCPDocente.Location = new System.Drawing.Point(63, 32);
            this.lblCodigoPUCPDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPUCPDocente.Name = "lblCodigoPUCPDocente";
            this.lblCodigoPUCPDocente.Size = new System.Drawing.Size(129, 20);
            this.lblCodigoPUCPDocente.TabIndex = 2;
            this.lblCodigoPUCPDocente.Text = "Código PUCP:";
            // 
            // dgvJurados
            // 
            this.dgvJurados.AllowUserToAddRows = false;
            this.dgvJurados.AllowUserToDeleteRows = false;
            this.dgvJurados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJurados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPUCP,
            this.NombreCompleto,
            this.Categoria});
            this.dgvJurados.Location = new System.Drawing.Point(18, 122);
            this.dgvJurados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvJurados.Name = "dgvJurados";
            this.dgvJurados.ReadOnly = true;
            this.dgvJurados.RowHeadersWidth = 62;
            this.dgvJurados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJurados.Size = new System.Drawing.Size(1086, 331);
            this.dgvJurados.TabIndex = 1;
            this.dgvJurados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvJurados_CellFormatting);
            // 
            // CodigoPUCP
            // 
            this.CodigoPUCP.HeaderText = "Código PUCP";
            this.CodigoPUCP.MinimumWidth = 8;
            this.CodigoPUCP.Name = "CodigoPUCP";
            this.CodigoPUCP.ReadOnly = true;
            this.CodigoPUCP.Width = 130;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 350;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 8;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 170;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "openFileDialog1";
            // 
            // frmGestionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 574);
            this.Controls.Add(this.tcProyecto);
            this.Controls.Add(this.tsMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGestionProyectos";
            this.Text = "Formulario de Gestión de Proyectos";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tcProyecto.ResumeLayout(false);
            this.tpDatosGenerales.ResumeLayout(false);
            this.tpDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tpJurados.ResumeLayout(false);
            this.tpJurados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJurados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TabControl tcProyecto;
        private System.Windows.Forms.TabPage tpDatosGenerales;
        private System.Windows.Forms.TabPage tpJurados;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.DataGridView dgvJurados;
        private System.Windows.Forms.Button btnDescargarArchivo;
        private System.Windows.Forms.Button btnSubirArchivo;
        private System.Windows.Forms.Label lblArchivoTemaTesis;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtNombreCompletoDocente;
        private System.Windows.Forms.TextBox txtCodigoPUCPDocente;
        private System.Windows.Forms.Label lblNombreCompletoDocente;
        private System.Windows.Forms.Label lblCodigoPUCPDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPUCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.Button btnBuscarDocente;
        private System.Windows.Forms.Button btnEliminarJurado;
        private System.Windows.Forms.Button btnAgregarJurado;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private System.Windows.Forms.SaveFileDialog sfdArchivo;
    }
}

