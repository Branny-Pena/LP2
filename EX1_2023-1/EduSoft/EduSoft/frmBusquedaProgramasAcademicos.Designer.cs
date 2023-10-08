namespace EduSoft
{
    partial class frmBusquedaProgramasAcademicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProgramas = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantHorasCreditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRealizacionInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreClave = new System.Windows.Forms.Label();
            this.txtNombreClave = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProgramas
            // 
            this.dgvProgramas.AllowUserToAddRows = false;
            this.dgvProgramas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProgramas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Clave,
            this.Nombre,
            this.CantHorasCreditos,
            this.FechaRealizacionInicio});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProgramas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProgramas.Location = new System.Drawing.Point(18, 65);
            this.dgvProgramas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProgramas.Name = "dgvProgramas";
            this.dgvProgramas.ReadOnly = true;
            this.dgvProgramas.RowHeadersWidth = 62;
            this.dgvProgramas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgramas.Size = new System.Drawing.Size(1545, 346);
            this.dgvProgramas.TabIndex = 0;
            this.dgvProgramas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProgramas_CellFormatting);
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 8;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 150;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 8;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 350;
            // 
            // CantHorasCreditos
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CantHorasCreditos.DefaultCellStyle = dataGridViewCellStyle6;
            this.CantHorasCreditos.HeaderText = "Cant. Horas/Créditos";
            this.CantHorasCreditos.MinimumWidth = 8;
            this.CantHorasCreditos.Name = "CantHorasCreditos";
            this.CantHorasCreditos.ReadOnly = true;
            this.CantHorasCreditos.Width = 200;
            // 
            // FechaRealizacionInicio
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaRealizacionInicio.DefaultCellStyle = dataGridViewCellStyle7;
            this.FechaRealizacionInicio.HeaderText = "Fecha Realización/Inicio";
            this.FechaRealizacionInicio.MinimumWidth = 8;
            this.FechaRealizacionInicio.Name = "FechaRealizacionInicio";
            this.FechaRealizacionInicio.ReadOnly = true;
            this.FechaRealizacionInicio.Width = 200;
            // 
            // lblNombreClave
            // 
            this.lblNombreClave.AutoSize = true;
            this.lblNombreClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClave.Location = new System.Drawing.Point(20, 20);
            this.lblNombreClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreClave.Name = "lblNombreClave";
            this.lblNombreClave.Size = new System.Drawing.Size(347, 22);
            this.lblNombreClave.TabIndex = 1;
            this.lblNombreClave.Text = "Ingrese nombre o clave del programa:";
            // 
            // txtNombreClave
            // 
            this.txtNombreClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClave.Location = new System.Drawing.Point(405, 18);
            this.txtNombreClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreClave.Name = "txtNombreClave";
            this.txtNombreClave.Size = new System.Drawing.Size(420, 28);
            this.txtNombreClave.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(836, 17);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(1378, 17);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(183, 35);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBusquedaProgramasAcademicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 429);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreClave);
            this.Controls.Add(this.lblNombreClave);
            this.Controls.Add(this.dgvProgramas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBusquedaProgramasAcademicos";
            this.Text = "Formulario de Búsqueda de Programas Académicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProgramas;
        private System.Windows.Forms.Label lblNombreClave;
        private System.Windows.Forms.TextBox txtNombreClave;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantHorasCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRealizacionInicio;
    }
}