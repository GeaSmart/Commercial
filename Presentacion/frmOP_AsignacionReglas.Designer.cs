namespace Presentacion
{
    partial class frmOP_AsignacionReglas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_AsignacionReglas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.btnGoPerfil = new System.Windows.Forms.Button();
            this.chkSeleccionarTodo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.PRE_is_activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.REG_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REG_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REG_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.gpbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.btnGoPerfil);
            this.gpbInformacion.Controls.Add(this.chkSeleccionarTodo);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Controls.Add(this.txtFiltrar);
            this.gpbInformacion.Controls.Add(this.dgvListado);
            this.gpbInformacion.Controls.Add(this.cmbPerfil);
            this.gpbInformacion.Controls.Add(this.label3);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(9, 54);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(734, 507);
            this.gpbInformacion.TabIndex = 6;
            this.gpbInformacion.TabStop = false;
            // 
            // btnGoPerfil
            // 
            this.btnGoPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnGoPerfil.Image")));
            this.btnGoPerfil.Location = new System.Drawing.Point(548, 26);
            this.btnGoPerfil.Name = "btnGoPerfil";
            this.btnGoPerfil.Size = new System.Drawing.Size(25, 25);
            this.btnGoPerfil.TabIndex = 98;
            this.btnGoPerfil.UseVisualStyleBackColor = true;
            this.btnGoPerfil.Click += new System.EventHandler(this.btnGoPerfil_Click);
            // 
            // chkSeleccionarTodo
            // 
            this.chkSeleccionarTodo.AutoSize = true;
            this.chkSeleccionarTodo.Location = new System.Drawing.Point(593, 59);
            this.chkSeleccionarTodo.Name = "chkSeleccionarTodo";
            this.chkSeleccionarTodo.Size = new System.Drawing.Size(125, 21);
            this.chkSeleccionarTodo.TabIndex = 52;
            this.chkSeleccionarTodo.Text = "Seleccionar todo";
            this.chkSeleccionarTodo.UseVisualStyleBackColor = true;
            this.chkSeleccionarTodo.CheckedChanged += new System.EventHandler(this.chkSeleccionarTodo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Filtrar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFiltrar.Location = new System.Drawing.Point(63, 61);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(156, 23);
            this.txtFiltrar.TabIndex = 50;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListado.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRE_is_activo,
            this.REG_codigo,
            this.REG_nombre,
            this.REG_descripcion});
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvListado.Location = new System.Drawing.Point(16, 86);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(702, 405);
            this.dgvListado.TabIndex = 49;
            this.dgvListado.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvListado_CurrentCellDirtyStateChanged);
            this.dgvListado.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvListado_RowPostPaint);
            // 
            // PRE_is_activo
            // 
            this.PRE_is_activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PRE_is_activo.DataPropertyName = "PRE_is_activo";
            this.PRE_is_activo.FalseValue = "N";
            this.PRE_is_activo.HeaderText = "Seleccionar";
            this.PRE_is_activo.Name = "PRE_is_activo";
            this.PRE_is_activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRE_is_activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PRE_is_activo.TrueValue = "S";
            this.PRE_is_activo.Width = 99;
            // 
            // REG_codigo
            // 
            this.REG_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.REG_codigo.DataPropertyName = "REG_codigo";
            this.REG_codigo.HeaderText = "REG_codigo";
            this.REG_codigo.Name = "REG_codigo";
            this.REG_codigo.ReadOnly = true;
            this.REG_codigo.Visible = false;
            // 
            // REG_nombre
            // 
            this.REG_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.REG_nombre.DataPropertyName = "REG_nombre";
            this.REG_nombre.HeaderText = "Regla";
            this.REG_nombre.Name = "REG_nombre";
            this.REG_nombre.ReadOnly = true;
            this.REG_nombre.Width = 66;
            // 
            // REG_descripcion
            // 
            this.REG_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.REG_descripcion.DataPropertyName = "REG_descripcion";
            this.REG_descripcion.HeaderText = "Descripcion";
            this.REG_descripcion.Name = "REG_descripcion";
            this.REG_descripcion.ReadOnly = true;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(227, 26);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(319, 25);
            this.cmbPerfil.TabIndex = 48;
            this.cmbPerfil.DropDown += new System.EventHandler(this.cmbPerfil_DropDown);
            this.cmbPerfil.SelectedIndexChanged += new System.EventHandler(this.cmbPerfil_SelectedIndexChanged);
            this.cmbPerfil.SelectionChangeCommitted += new System.EventHandler(this.cmbPerfil_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Perfil";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 51);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmOP_AsignacionReglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(752, 587);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmOP_AsignacionReglas";
            this.Text = "Asignación de Reglas y permisos";
            this.Load += new System.EventHandler(this.frmOP_AsignacionReglas_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PRE_is_activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn REG_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn REG_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn REG_descripcion;
        private System.Windows.Forms.CheckBox chkSeleccionarTodo;
        protected System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Button btnGoPerfil;
    }
}