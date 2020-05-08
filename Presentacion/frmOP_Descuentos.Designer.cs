namespace Presentacion
{
    partial class frmOP_Descuentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_Descuentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabDescuentos = new System.Windows.Forms.TabControl();
            this.Grupal = new System.Windows.Forms.TabPage();
            this.dgvDescuentoGrupal = new System.Windows.Forms.DataGridView();
            this.DSC_is_especial = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PRO_codigo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PRO_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSC_porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSC_esp_porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSC_fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCanal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoCanal = new System.Windows.Forms.Button();
            this.chkReplicarFecha = new System.Windows.Forms.CheckBox();
            this.chkSeleccionarTodo = new System.Windows.Forms.CheckBox();
            this.PorSocio = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGoSocio = new System.Windows.Forms.Button();
            this.dgvDescuentoSocio = new System.Windows.Forms.DataGridView();
            this.PRO_codigo2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PRO_descripcion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSC_porcentaje2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoSocio = new System.Windows.Forms.TextBox();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.btnSocio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDescuentos.SuspendLayout();
            this.Grupal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentoGrupal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PorSocio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentoSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDescuentos
            // 
            this.tabDescuentos.Controls.Add(this.Grupal);
            this.tabDescuentos.Controls.Add(this.PorSocio);
            this.tabDescuentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabDescuentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDescuentos.Location = new System.Drawing.Point(0, 58);
            this.tabDescuentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDescuentos.Name = "tabDescuentos";
            this.tabDescuentos.SelectedIndex = 0;
            this.tabDescuentos.Size = new System.Drawing.Size(721, 479);
            this.tabDescuentos.TabIndex = 0;
            this.tabDescuentos.SelectedIndexChanged += new System.EventHandler(this.tabDescuentos_SelectedIndexChanged);
            // 
            // Grupal
            // 
            this.Grupal.Controls.Add(this.dgvDescuentoGrupal);
            this.Grupal.Controls.Add(this.cmbCanal);
            this.Grupal.Controls.Add(this.label1);
            this.Grupal.Controls.Add(this.groupBox1);
            this.Grupal.Location = new System.Drawing.Point(4, 26);
            this.Grupal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grupal.Name = "Grupal";
            this.Grupal.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grupal.Size = new System.Drawing.Size(713, 449);
            this.Grupal.TabIndex = 0;
            this.Grupal.Text = "Grupal";
            this.Grupal.UseVisualStyleBackColor = true;
            // 
            // dgvDescuentoGrupal
            // 
            this.dgvDescuentoGrupal.AllowUserToAddRows = false;
            this.dgvDescuentoGrupal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvDescuentoGrupal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDescuentoGrupal.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvDescuentoGrupal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentoGrupal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DSC_is_especial,
            this.PRO_codigo,
            this.PRO_descripcion,
            this.DSC_porcentaje,
            this.DSC_esp_porcentaje,
            this.DSC_fecha_vencimiento});
            this.dgvDescuentoGrupal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDescuentoGrupal.EnableHeadersVisualStyles = false;
            this.dgvDescuentoGrupal.Location = new System.Drawing.Point(27, 54);
            this.dgvDescuentoGrupal.Name = "dgvDescuentoGrupal";
            this.dgvDescuentoGrupal.RowTemplate.Height = 21;
            this.dgvDescuentoGrupal.Size = new System.Drawing.Size(659, 370);
            this.dgvDescuentoGrupal.TabIndex = 3;
            this.dgvDescuentoGrupal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDescuentoGrupal_CellClick);
            this.dgvDescuentoGrupal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDescuentoGrupal_CellContentClick);
            this.dgvDescuentoGrupal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDescuentoGrupal_CellValueChanged);
            this.dgvDescuentoGrupal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDescuentoGrupal_CurrentCellDirtyStateChanged);
            this.dgvDescuentoGrupal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDescuentoGrupal_DataBindingComplete);
            this.dgvDescuentoGrupal.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDescuentoGrupal_RowPostPaint);
            // 
            // DSC_is_especial
            // 
            this.DSC_is_especial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DSC_is_especial.DataPropertyName = "DSC_is_especial";
            this.DSC_is_especial.FalseValue = "N";
            this.DSC_is_especial.HeaderText = "Especial";
            this.DSC_is_especial.Name = "DSC_is_especial";
            this.DSC_is_especial.TrueValue = "S";
            this.DSC_is_especial.Width = 61;
            // 
            // PRO_codigo
            // 
            this.PRO_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PRO_codigo.DataPropertyName = "PRO_codigo";
            this.PRO_codigo.HeaderText = "Codigo";
            this.PRO_codigo.Name = "PRO_codigo";
            this.PRO_codigo.ReadOnly = true;
            this.PRO_codigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRO_codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PRO_codigo.Width = 76;
            // 
            // PRO_descripcion
            // 
            this.PRO_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRO_descripcion.DataPropertyName = "PRO_descripcion";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRO_descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRO_descripcion.HeaderText = "Producto";
            this.PRO_descripcion.Name = "PRO_descripcion";
            this.PRO_descripcion.ReadOnly = true;
            // 
            // DSC_porcentaje
            // 
            this.DSC_porcentaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DSC_porcentaje.DataPropertyName = "DSC_porcentaje";
            dataGridViewCellStyle3.NullValue = null;
            this.DSC_porcentaje.DefaultCellStyle = dataGridViewCellStyle3;
            this.DSC_porcentaje.HeaderText = "Normal";
            this.DSC_porcentaje.Name = "DSC_porcentaje";
            this.DSC_porcentaje.Width = 77;
            // 
            // DSC_esp_porcentaje
            // 
            this.DSC_esp_porcentaje.DataPropertyName = "DSC_esp_porcentaje";
            this.DSC_esp_porcentaje.HeaderText = "Especial";
            this.DSC_esp_porcentaje.Name = "DSC_esp_porcentaje";
            // 
            // DSC_fecha_vencimiento
            // 
            this.DSC_fecha_vencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DSC_fecha_vencimiento.DataPropertyName = "DSC_fecha_vencimiento";
            this.DSC_fecha_vencimiento.HeaderText = "Vencimiento";
            this.DSC_fecha_vencimiento.Name = "DSC_fecha_vencimiento";
            this.DSC_fecha_vencimiento.ReadOnly = true;
            this.DSC_fecha_vencimiento.Width = 103;
            // 
            // cmbCanal
            // 
            this.cmbCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCanal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCanal.FormattingEnabled = true;
            this.cmbCanal.Location = new System.Drawing.Point(264, 22);
            this.cmbCanal.Name = "cmbCanal";
            this.cmbCanal.Size = new System.Drawing.Size(230, 23);
            this.cmbCanal.TabIndex = 2;
            this.cmbCanal.DropDown += new System.EventHandler(this.cmbCanal_DropDown);
            this.cmbCanal.SelectedIndexChanged += new System.EventHandler(this.cmbCanal_SelectedIndexChanged);
            this.cmbCanal.SelectionChangeCommitted += new System.EventHandler(this.cmbCanal_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canal:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGoCanal);
            this.groupBox1.Controls.Add(this.chkReplicarFecha);
            this.groupBox1.Controls.Add(this.chkSeleccionarTodo);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnGoCanal
            // 
            this.btnGoCanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoCanal.Image = ((System.Drawing.Image)(resources.GetObject("btnGoCanal.Image")));
            this.btnGoCanal.Location = new System.Drawing.Point(489, 20);
            this.btnGoCanal.Name = "btnGoCanal";
            this.btnGoCanal.Size = new System.Drawing.Size(25, 25);
            this.btnGoCanal.TabIndex = 73;
            this.btnGoCanal.UseVisualStyleBackColor = true;
            this.btnGoCanal.Click += new System.EventHandler(this.btnGoCanal_Click);
            // 
            // chkReplicarFecha
            // 
            this.chkReplicarFecha.AutoSize = true;
            this.chkReplicarFecha.Location = new System.Drawing.Point(571, 26);
            this.chkReplicarFecha.Name = "chkReplicarFecha";
            this.chkReplicarFecha.Size = new System.Drawing.Size(109, 21);
            this.chkReplicarFecha.TabIndex = 1;
            this.chkReplicarFecha.Text = "Replicar fecha";
            this.chkReplicarFecha.UseVisualStyleBackColor = true;
            this.chkReplicarFecha.CheckedChanged += new System.EventHandler(this.chkReplicarFecha_CheckedChanged);
            // 
            // chkSeleccionarTodo
            // 
            this.chkSeleccionarTodo.AutoSize = true;
            this.chkSeleccionarTodo.Location = new System.Drawing.Point(22, 26);
            this.chkSeleccionarTodo.Name = "chkSeleccionarTodo";
            this.chkSeleccionarTodo.Size = new System.Drawing.Size(125, 21);
            this.chkSeleccionarTodo.TabIndex = 0;
            this.chkSeleccionarTodo.Text = "Seleccionar todo";
            this.chkSeleccionarTodo.UseVisualStyleBackColor = true;
            this.chkSeleccionarTodo.CheckedChanged += new System.EventHandler(this.chkSeleccionarTodo_CheckedChanged);
            // 
            // PorSocio
            // 
            this.PorSocio.Controls.Add(this.groupBox2);
            this.PorSocio.Location = new System.Drawing.Point(4, 26);
            this.PorSocio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PorSocio.Name = "PorSocio";
            this.PorSocio.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PorSocio.Size = new System.Drawing.Size(713, 449);
            this.PorSocio.TabIndex = 1;
            this.PorSocio.Text = "Por Socio";
            this.PorSocio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGoSocio);
            this.groupBox2.Controls.Add(this.dgvDescuentoSocio);
            this.groupBox2.Controls.Add(this.txtCodigoSocio);
            this.groupBox2.Controls.Add(this.txtNombreSocio);
            this.groupBox2.Controls.Add(this.btnSocio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(74, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 442);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnGoSocio
            // 
            this.btnGoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoSocio.Image = ((System.Drawing.Image)(resources.GetObject("btnGoSocio.Image")));
            this.btnGoSocio.Location = new System.Drawing.Point(520, 19);
            this.btnGoSocio.Name = "btnGoSocio";
            this.btnGoSocio.Size = new System.Drawing.Size(25, 25);
            this.btnGoSocio.TabIndex = 105;
            this.btnGoSocio.UseVisualStyleBackColor = true;
            this.btnGoSocio.Click += new System.EventHandler(this.btnGoSocio_Click);
            // 
            // dgvDescuentoSocio
            // 
            this.dgvDescuentoSocio.AllowUserToAddRows = false;
            this.dgvDescuentoSocio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            this.dgvDescuentoSocio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDescuentoSocio.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvDescuentoSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentoSocio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_codigo2,
            this.PRO_descripcion2,
            this.DSC_porcentaje2});
            this.dgvDescuentoSocio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDescuentoSocio.Location = new System.Drawing.Point(21, 53);
            this.dgvDescuentoSocio.Name = "dgvDescuentoSocio";
            this.dgvDescuentoSocio.RowTemplate.Height = 21;
            this.dgvDescuentoSocio.Size = new System.Drawing.Size(524, 371);
            this.dgvDescuentoSocio.TabIndex = 7;
            this.dgvDescuentoSocio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDescuentoSocio_CellContentClick);
            this.dgvDescuentoSocio.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDescuentoSocio_CurrentCellDirtyStateChanged);
            this.dgvDescuentoSocio.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDescuentoSocio_DataBindingComplete);
            this.dgvDescuentoSocio.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDescuentoSocio_RowPostPaint);
            // 
            // PRO_codigo2
            // 
            this.PRO_codigo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PRO_codigo2.DataPropertyName = "PRO_codigo";
            this.PRO_codigo2.HeaderText = "Codigo";
            this.PRO_codigo2.Name = "PRO_codigo2";
            this.PRO_codigo2.ReadOnly = true;
            this.PRO_codigo2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRO_codigo2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PRO_codigo2.Width = 76;
            // 
            // PRO_descripcion2
            // 
            this.PRO_descripcion2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRO_descripcion2.DataPropertyName = "PRO_descripcion";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRO_descripcion2.DefaultCellStyle = dataGridViewCellStyle5;
            this.PRO_descripcion2.HeaderText = "Producto";
            this.PRO_descripcion2.Name = "PRO_descripcion2";
            this.PRO_descripcion2.ReadOnly = true;
            // 
            // DSC_porcentaje2
            // 
            this.DSC_porcentaje2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DSC_porcentaje2.DataPropertyName = "DSC_porcentaje";
            this.DSC_porcentaje2.HeaderText = "Porcentaje";
            this.DSC_porcentaje2.Name = "DSC_porcentaje2";
            this.DSC_porcentaje2.Width = 94;
            // 
            // txtCodigoSocio
            // 
            this.txtCodigoSocio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSocio.Location = new System.Drawing.Point(70, 20);
            this.txtCodigoSocio.Name = "txtCodigoSocio";
            this.txtCodigoSocio.ReadOnly = true;
            this.txtCodigoSocio.Size = new System.Drawing.Size(69, 23);
            this.txtCodigoSocio.TabIndex = 6;
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSocio.Location = new System.Drawing.Point(171, 20);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(347, 23);
            this.txtNombreSocio.TabIndex = 5;
            // 
            // btnSocio
            // 
            this.btnSocio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocio.Location = new System.Drawing.Point(139, 19);
            this.btnSocio.Name = "btnSocio";
            this.btnSocio.Size = new System.Drawing.Size(30, 25);
            this.btnSocio.TabIndex = 4;
            this.btnSocio.Text = "...";
            this.btnSocio.UseVisualStyleBackColor = true;
            this.btnSocio.Click += new System.EventHandler(this.btnSocio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente:";
            // 
            // frmOP_Descuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 559);
            this.Controls.Add(this.tabDescuentos);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOP_Descuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuentos";
            this.Load += new System.EventHandler(this.frmOP_Descuentos_Load);
            this.Controls.SetChildIndex(this.tabDescuentos, 0);
            this.tabDescuentos.ResumeLayout(false);
            this.Grupal.ResumeLayout(false);
            this.Grupal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentoGrupal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PorSocio.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentoSocio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabDescuentos;
        private System.Windows.Forms.TabPage Grupal;
        private System.Windows.Forms.TabPage PorSocio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDescuentoGrupal;
        private System.Windows.Forms.ComboBox cmbCanal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodigoSocio;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.Button btnSocio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDescuentoSocio;
        private System.Windows.Forms.CheckBox chkSeleccionarTodo;
        private System.Windows.Forms.CheckBox chkReplicarFecha;
        private System.Windows.Forms.Button btnGoCanal;
        private System.Windows.Forms.Button btnGoSocio;
        private System.Windows.Forms.DataGridViewLinkColumn PRO_codigo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_descripcion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSC_porcentaje2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DSC_is_especial;
        private System.Windows.Forms.DataGridViewLinkColumn PRO_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSC_porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSC_esp_porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSC_fecha_vencimiento;
    }
}