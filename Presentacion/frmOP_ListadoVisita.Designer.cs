namespace Presentacion
{
    partial class frmOP_ListadoVisita
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_ListadoVisita));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.btnGoVendedor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoZona = new System.Windows.Forms.Button();
            this.btnGoRuta = new System.Windows.Forms.Button();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.ZON_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZON_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIS_dia_semana = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirGrillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbInformacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.menuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.btnGoVendedor);
            this.gpbInformacion.Controls.Add(this.groupBox1);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Controls.Add(this.txtFiltrar);
            this.gpbInformacion.Controls.Add(this.dgvListado);
            this.gpbInformacion.Controls.Add(this.cmbVendedor);
            this.gpbInformacion.Controls.Add(this.label3);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(6, 5);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(564, 579);
            this.gpbInformacion.TabIndex = 11;
            this.gpbInformacion.TabStop = false;
            // 
            // btnGoVendedor
            // 
            this.btnGoVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoVendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnGoVendedor.Image")));
            this.btnGoVendedor.Location = new System.Drawing.Point(429, 26);
            this.btnGoVendedor.Name = "btnGoVendedor";
            this.btnGoVendedor.Size = new System.Drawing.Size(25, 25);
            this.btnGoVendedor.TabIndex = 75;
            this.btnGoVendedor.UseVisualStyleBackColor = true;
            this.btnGoVendedor.Click += new System.EventHandler(this.btnGoVendedor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGoZona);
            this.groupBox1.Controls.Add(this.btnGoRuta);
            this.groupBox1.Controls.Add(this.cmbRuta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.cmbZona);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbDia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 88);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            // 
            // btnGoZona
            // 
            this.btnGoZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoZona.Image = ((System.Drawing.Image)(resources.GetObject("btnGoZona.Image")));
            this.btnGoZona.Location = new System.Drawing.Point(335, 44);
            this.btnGoZona.Name = "btnGoZona";
            this.btnGoZona.Size = new System.Drawing.Size(25, 25);
            this.btnGoZona.TabIndex = 78;
            this.btnGoZona.UseVisualStyleBackColor = true;
            this.btnGoZona.Click += new System.EventHandler(this.btnGoZona_Click);
            // 
            // btnGoRuta
            // 
            this.btnGoRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoRuta.Image = ((System.Drawing.Image)(resources.GetObject("btnGoRuta.Image")));
            this.btnGoRuta.Location = new System.Drawing.Point(162, 45);
            this.btnGoRuta.Name = "btnGoRuta";
            this.btnGoRuta.Size = new System.Drawing.Size(25, 25);
            this.btnGoRuta.TabIndex = 77;
            this.btnGoRuta.UseVisualStyleBackColor = true;
            this.btnGoRuta.Click += new System.EventHandler(this.btnGoRuta_Click);
            // 
            // cmbRuta
            // 
            this.cmbRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(21, 45);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(139, 25);
            this.cmbRuta.TabIndex = 6;
            this.cmbRuta.DropDown += new System.EventHandler(this.cmbRuta_DropDown);
            this.cmbRuta.SelectedIndexChanged += new System.EventHandler(this.cmbRuta_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ruta";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(473, 40);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 32);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbZona
            // 
            this.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(195, 44);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(138, 25);
            this.cmbZona.TabIndex = 3;
            this.cmbZona.DropDown += new System.EventHandler(this.cmbZona_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Día";
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES",
            "SABADO",
            "DOMINGO"});
            this.cmbDia.Location = new System.Drawing.Point(363, 44);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(104, 25);
            this.cmbDia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Zona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(322, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Filtrar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFiltrar.Location = new System.Drawing.Point(365, 151);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(185, 23);
            this.txtFiltrar.TabIndex = 50;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListado.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZON_codigo,
            this.ZON_nombre,
            this.VIS_dia_semana});
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvListado.Location = new System.Drawing.Point(14, 179);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(536, 382);
            this.dgvListado.TabIndex = 49;
            this.dgvListado.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListado_CellMouseUp);
            this.dgvListado.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellValueChanged);
            this.dgvListado.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvListado_CurrentCellDirtyStateChanged);
            // 
            // ZON_codigo
            // 
            this.ZON_codigo.DataPropertyName = "ZON_codigo";
            this.ZON_codigo.HeaderText = "Codigo";
            this.ZON_codigo.Name = "ZON_codigo";
            this.ZON_codigo.ReadOnly = true;
            this.ZON_codigo.Width = 76;
            // 
            // ZON_nombre
            // 
            this.ZON_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ZON_nombre.DataPropertyName = "ZON_nombre";
            this.ZON_nombre.HeaderText = "Zona";
            this.ZON_nombre.Name = "ZON_nombre";
            this.ZON_nombre.ReadOnly = true;
            // 
            // VIS_dia_semana
            // 
            this.VIS_dia_semana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VIS_dia_semana.DataPropertyName = "VIS_dia_semana";
            this.VIS_dia_semana.HeaderText = "Dia";
            this.VIS_dia_semana.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES",
            "SABADO",
            "DOMINGO"});
            this.VIS_dia_semana.Name = "VIS_dia_semana";
            this.VIS_dia_semana.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VIS_dia_semana.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(205, 26);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(222, 25);
            this.cmbVendedor.TabIndex = 48;
            this.cmbVendedor.DropDown += new System.EventHandler(this.cmbVendedor_DropDown);
            this.cmbVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbVendedor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vendedor";
            // 
            // menuContextual
            // 
            this.menuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.imprimirGrillaToolStripMenuItem});
            this.menuContextual.Name = "menuContextual";
            this.menuContextual.Size = new System.Drawing.Size(150, 48);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // imprimirGrillaToolStripMenuItem
            // 
            this.imprimirGrillaToolStripMenuItem.Name = "imprimirGrillaToolStripMenuItem";
            this.imprimirGrillaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.imprimirGrillaToolStripMenuItem.Text = "Imprimir grilla";
            this.imprimirGrillaToolStripMenuItem.Click += new System.EventHandler(this.imprimirGrillaToolStripMenuItem_Click);
            // 
            // frmOP_ListadoVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 596);
            this.Controls.Add(this.gpbInformacion);
            this.DoubleBuffered = true;
            this.Name = "frmOP_ListadoVisita";
            this.Text = "Listado de Visita";
            this.Load += new System.EventHandler(this.frmOP_ListadoVisita_Load);
            this.VisibleChanged += new System.EventHandler(this.frmOP_ListadoVisita_VisibleChanged);
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.menuContextual.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZON_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZON_nombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn VIS_dia_semana;
        private System.Windows.Forms.ContextMenuStrip menuContextual;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem imprimirGrillaToolStripMenuItem;
        private System.Windows.Forms.Button btnGoVendedor;
        private System.Windows.Forms.Button btnGoRuta;
        private System.Windows.Forms.Button btnGoZona;
    }
}