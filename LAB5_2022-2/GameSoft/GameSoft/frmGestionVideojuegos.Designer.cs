﻿namespace GameSoft
{
    partial class frmGestionVideojuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionVideojuegos));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblGestionVideojuegos = new System.Windows.Forms.Label();
            this.txtIdVideojuego = new System.Windows.Forms.TextBox();
            this.lblIdVideojuego = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblMaxJugadores = new System.Windows.Forms.Label();
            this.cbCooperativo = new System.Windows.Forms.CheckBox();
            this.cbMultiplayer = new System.Windows.Forms.CheckBox();
            this.cbEdicionEspecial = new System.Windows.Forms.CheckBox();
            this.rbPlaystation = new System.Windows.Forms.RadioButton();
            this.rbNintendo = new System.Windows.Forms.RadioButton();
            this.rbXbox = new System.Windows.Forms.RadioButton();
            this.lblPlataforma = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.nudMaxJugadores = new System.Windows.Forms.NumericUpDown();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEspecificaciones = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDesarrolladora = new System.Windows.Forms.TextBox();
            this.lblDesarrolladora = new System.Windows.Forms.Label();
            this.btnSubirPortada = new System.Windows.Forms.Button();
            this.btnBuscarDesarrolladora = new System.Windows.Forms.Button();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.ofdPortada = new System.Windows.Forms.OpenFileDialog();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
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
            this.tsMenu.Size = new System.Drawing.Size(1106, 34);
            this.tsMenu.TabIndex = 1;
            this.tsMenu.Text = "toolStrip1";
            this.tsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMenu_ItemClicked);
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
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 29);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblGestionVideojuegos
            // 
            this.lblGestionVideojuegos.AutoSize = true;
            this.lblGestionVideojuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionVideojuegos.Location = new System.Drawing.Point(18, 52);
            this.lblGestionVideojuegos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionVideojuegos.Name = "lblGestionVideojuegos";
            this.lblGestionVideojuegos.Size = new System.Drawing.Size(242, 25);
            this.lblGestionVideojuegos.TabIndex = 2;
            this.lblGestionVideojuegos.Text = "Gestión de Videojuegos";
            // 
            // txtIdVideojuego
            // 
            this.txtIdVideojuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVideojuego.Location = new System.Drawing.Point(438, 105);
            this.txtIdVideojuego.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdVideojuego.Name = "txtIdVideojuego";
            this.txtIdVideojuego.ReadOnly = true;
            this.txtIdVideojuego.Size = new System.Drawing.Size(97, 26);
            this.txtIdVideojuego.TabIndex = 3;
            // 
            // lblIdVideojuego
            // 
            this.lblIdVideojuego.AutoSize = true;
            this.lblIdVideojuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVideojuego.Location = new System.Drawing.Point(398, 109);
            this.lblIdVideojuego.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdVideojuego.Name = "lblIdVideojuego";
            this.lblIdVideojuego.Size = new System.Drawing.Size(34, 20);
            this.lblIdVideojuego.TabIndex = 4;
            this.lblIdVideojuego.Text = "ID:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(352, 146);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(438, 142);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(637, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(356, 225);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(76, 20);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Género:";
            // 
            // cboGenero
            // 
            this.cboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(438, 218);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(316, 28);
            this.cboGenero.TabIndex = 8;
            this.cboGenero.SelectedIndexChanged += new System.EventHandler(this.cboGenero_SelectedIndexChanged);
            // 
            // lblMaxJugadores
            // 
            this.lblMaxJugadores.AutoSize = true;
            this.lblMaxJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxJugadores.Location = new System.Drawing.Point(302, 303);
            this.lblMaxJugadores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxJugadores.Name = "lblMaxJugadores";
            this.lblMaxJugadores.Size = new System.Drawing.Size(147, 20);
            this.lblMaxJugadores.TabIndex = 9;
            this.lblMaxJugadores.Text = "Máx. Jugadores:";
            // 
            // cbCooperativo
            // 
            this.cbCooperativo.AutoSize = true;
            this.cbCooperativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCooperativo.Location = new System.Drawing.Point(471, 342);
            this.cbCooperativo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCooperativo.Name = "cbCooperativo";
            this.cbCooperativo.Size = new System.Drawing.Size(135, 24);
            this.cbCooperativo.TabIndex = 10;
            this.cbCooperativo.Text = "Cooperativo";
            this.cbCooperativo.UseVisualStyleBackColor = true;
            // 
            // cbMultiplayer
            // 
            this.cbMultiplayer.AutoSize = true;
            this.cbMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMultiplayer.Location = new System.Drawing.Point(622, 342);
            this.cbMultiplayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMultiplayer.Name = "cbMultiplayer";
            this.cbMultiplayer.Size = new System.Drawing.Size(194, 24);
            this.cbMultiplayer.TabIndex = 11;
            this.cbMultiplayer.Text = "Multi-player Online";
            this.cbMultiplayer.UseVisualStyleBackColor = true;
            // 
            // cbEdicionEspecial
            // 
            this.cbEdicionEspecial.AutoSize = true;
            this.cbEdicionEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEdicionEspecial.Location = new System.Drawing.Point(828, 342);
            this.cbEdicionEspecial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEdicionEspecial.Name = "cbEdicionEspecial";
            this.cbEdicionEspecial.Size = new System.Drawing.Size(175, 24);
            this.cbEdicionEspecial.TabIndex = 12;
            this.cbEdicionEspecial.Text = "Edición Especial";
            this.cbEdicionEspecial.UseVisualStyleBackColor = true;
            // 
            // rbPlaystation
            // 
            this.rbPlaystation.AutoSize = true;
            this.rbPlaystation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlaystation.Location = new System.Drawing.Point(442, 263);
            this.rbPlaystation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPlaystation.Name = "rbPlaystation";
            this.rbPlaystation.Size = new System.Drawing.Size(143, 24);
            this.rbPlaystation.TabIndex = 13;
            this.rbPlaystation.TabStop = true;
            this.rbPlaystation.Text = "Playstation 5";
            this.rbPlaystation.UseVisualStyleBackColor = true;
            // 
            // rbNintendo
            // 
            this.rbNintendo.AutoSize = true;
            this.rbNintendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNintendo.Location = new System.Drawing.Point(606, 263);
            this.rbNintendo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbNintendo.Name = "rbNintendo";
            this.rbNintendo.Size = new System.Drawing.Size(170, 24);
            this.rbNintendo.TabIndex = 14;
            this.rbNintendo.TabStop = true;
            this.rbNintendo.Text = "Nintendo Switch";
            this.rbNintendo.UseVisualStyleBackColor = true;
            // 
            // rbXbox
            // 
            this.rbXbox.AutoSize = true;
            this.rbXbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbXbox.Location = new System.Drawing.Point(798, 263);
            this.rbXbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbXbox.Name = "rbXbox";
            this.rbXbox.Size = new System.Drawing.Size(115, 24);
            this.rbXbox.TabIndex = 15;
            this.rbXbox.TabStop = true;
            this.rbXbox.Text = "Xbox One";
            this.rbXbox.UseVisualStyleBackColor = true;
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.AutoSize = true;
            this.lblPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlataforma.Location = new System.Drawing.Point(327, 265);
            this.lblPlataforma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(106, 20);
            this.lblPlataforma.TabIndex = 16;
            this.lblPlataforma.Text = "Plataforma:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(22, 422);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(1052, 124);
            this.txtDescripcion.TabIndex = 17;
            // 
            // nudMaxJugadores
            // 
            this.nudMaxJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxJugadores.Location = new System.Drawing.Point(460, 300);
            this.nudMaxJugadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMaxJugadores.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudMaxJugadores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxJugadores.Name = "nudMaxJugadores";
            this.nudMaxJugadores.Size = new System.Drawing.Size(104, 26);
            this.nudMaxJugadores.TabIndex = 18;
            this.nudMaxJugadores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(18, 391);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(116, 20);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblEspecificaciones
            // 
            this.lblEspecificaciones.AutoSize = true;
            this.lblEspecificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecificaciones.Location = new System.Drawing.Point(302, 343);
            this.lblEspecificaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecificaciones.Name = "lblEspecificaciones";
            this.lblEspecificaciones.Size = new System.Drawing.Size(158, 20);
            this.lblEspecificaciones.TabIndex = 20;
            this.lblEspecificaciones.Text = "Especificaciones:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(302, 378);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(69, 20);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(376, 374);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(158, 26);
            this.txtPrecio.TabIndex = 22;
            // 
            // txtDesarrolladora
            // 
            this.txtDesarrolladora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesarrolladora.Location = new System.Drawing.Point(438, 180);
            this.txtDesarrolladora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesarrolladora.Name = "txtDesarrolladora";
            this.txtDesarrolladora.ReadOnly = true;
            this.txtDesarrolladora.Size = new System.Drawing.Size(595, 26);
            this.txtDesarrolladora.TabIndex = 23;
            // 
            // lblDesarrolladora
            // 
            this.lblDesarrolladora.AutoSize = true;
            this.lblDesarrolladora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesarrolladora.Location = new System.Drawing.Point(294, 186);
            this.lblDesarrolladora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesarrolladora.Name = "lblDesarrolladora";
            this.lblDesarrolladora.Size = new System.Drawing.Size(140, 20);
            this.lblDesarrolladora.TabIndex = 25;
            this.lblDesarrolladora.Text = "Desarrolladora:";
            // 
            // btnSubirPortada
            // 
            this.btnSubirPortada.BackgroundImage = global::GameSoft.Properties.Resources.upload;
            this.btnSubirPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirPortada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirPortada.Location = new System.Drawing.Point(231, 325);
            this.btnSubirPortada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubirPortada.Name = "btnSubirPortada";
            this.btnSubirPortada.Size = new System.Drawing.Size(48, 48);
            this.btnSubirPortada.TabIndex = 26;
            this.btnSubirPortada.UseVisualStyleBackColor = true;
            this.btnSubirPortada.Click += new System.EventHandler(this.btnSubirPortada_Click);
            // 
            // btnBuscarDesarrolladora
            // 
            this.btnBuscarDesarrolladora.BackgroundImage = global::GameSoft.Properties.Resources.lupa;
            this.btnBuscarDesarrolladora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarDesarrolladora.Location = new System.Drawing.Point(1040, 178);
            this.btnBuscarDesarrolladora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarDesarrolladora.Name = "btnBuscarDesarrolladora";
            this.btnBuscarDesarrolladora.Size = new System.Drawing.Size(38, 35);
            this.btnBuscarDesarrolladora.TabIndex = 24;
            this.btnBuscarDesarrolladora.UseVisualStyleBackColor = true;
            this.btnBuscarDesarrolladora.Click += new System.EventHandler(this.btnBuscarDesarrolladora_Click);
            // 
            // pbPortada
            // 
            this.pbPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPortada.Location = new System.Drawing.Point(22, 100);
            this.pbPortada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(256, 271);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // ofdPortada
            // 
            this.ofdPortada.FileName = "openFileDialog1";
            // 
            // frmGestionVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 569);
            this.Controls.Add(this.btnSubirPortada);
            this.Controls.Add(this.lblDesarrolladora);
            this.Controls.Add(this.btnBuscarDesarrolladora);
            this.Controls.Add(this.txtDesarrolladora);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblEspecificaciones);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.nudMaxJugadores);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblPlataforma);
            this.Controls.Add(this.rbXbox);
            this.Controls.Add(this.rbNintendo);
            this.Controls.Add(this.rbPlaystation);
            this.Controls.Add(this.cbEdicionEspecial);
            this.Controls.Add(this.cbMultiplayer);
            this.Controls.Add(this.cbCooperativo);
            this.Controls.Add(this.lblMaxJugadores);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdVideojuego);
            this.Controls.Add(this.txtIdVideojuego);
            this.Controls.Add(this.lblGestionVideojuegos);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.pbPortada);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGestionVideojuegos";
            this.Text = "Formulario de Gestión de Videojuegos";
            this.Load += new System.EventHandler(this.frmGestionVideojuegos_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblGestionVideojuegos;
        private System.Windows.Forms.TextBox txtIdVideojuego;
        private System.Windows.Forms.Label lblIdVideojuego;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblMaxJugadores;
        private System.Windows.Forms.CheckBox cbCooperativo;
        private System.Windows.Forms.CheckBox cbMultiplayer;
        private System.Windows.Forms.CheckBox cbEdicionEspecial;
        private System.Windows.Forms.RadioButton rbPlaystation;
        private System.Windows.Forms.RadioButton rbNintendo;
        private System.Windows.Forms.RadioButton rbXbox;
        private System.Windows.Forms.Label lblPlataforma;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown nudMaxJugadores;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEspecificaciones;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDesarrolladora;
        private System.Windows.Forms.Button btnBuscarDesarrolladora;
        private System.Windows.Forms.Label lblDesarrolladora;
        private System.Windows.Forms.Button btnSubirPortada;
        private System.Windows.Forms.OpenFileDialog ofdPortada;
    }
}

