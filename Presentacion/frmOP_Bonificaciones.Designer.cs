namespace Presentacion
{
    partial class frmOP_Bonificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_Bonificaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.btnGoCanal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.BON_is_especial = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PRO_codigo_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_descripcion_1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Cantidad_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_sub_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_codigo_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_descripcion_2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Cantidad_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_sub_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_esp_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_esp_sub_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BON_fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCanal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuContextual.SuspendLayout();
            this.gpbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // menuContextual
            // 
            this.menuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarFilaToolStripMenuItem});
            this.menuContextual.Name = "menuContextual";
            this.menuContextual.Size = new System.Drawing.Size(139, 26);
            // 
            // eliminarFilaToolStripMenuItem
            // 
            this.eliminarFilaToolStripMenuItem.Name = "eliminarFilaToolStripMenuItem";
            this.eliminarFilaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.eliminarFilaToolStripMenuItem.Text = "Eliminar Fila";
            this.eliminarFilaToolStripMenuItem.Click += new System.EventHandler(this.eliminarFilaToolStripMenuItem_Click);
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.btnGoCanal);
            this.gpbInformacion.Controls.Add(this.label2);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Controls.Add(this.dgvListado);
            this.gpbInformacion.Controls.Add(this.cmbCanal);
            this.gpbInformacion.Controls.Add(this.label3);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(8, 54);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(1001, 462);
            this.gpbInformacion.TabIndex = 7;
            this.gpbInformacion.TabStop = false;
            // 
            // btnGoCanal
            // 
            this.btnGoCanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoCanal.Image = ((System.Drawing.Image)(resources.GetObject("btnGoCanal.Image")));
            this.btnGoCanal.Location = new System.Drawing.Point(656, 28);
            this.btnGoCanal.Name = "btnGoCanal";
            this.btnGoCanal.Size = new System.Drawing.Size(25, 25);
            this.btnGoCanal.TabIndex = 73;
            this.btnGoCanal.UseVisualStyleBackColor = true;
            this.btnGoCanal.Click += new System.EventHandler(this.btnGoCanal_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(413, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(573, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Bonificación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(54, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Condición";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToResizeRows = false;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListado.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BON_is_especial,
            this.PRO_codigo_1,
            this.PRO_descripcion_1,
            this.Cantidad_1,
            this.Cantidad_sub_1,
            this.PRO_codigo_2,
            this.PRO_descripcion_2,
            this.Cantidad_2,
            this.Cantidad_sub_2,
            this.Cantidad_esp_2,
            this.Cantidad_esp_sub_2,
            this.BON_fecha_vencimiento});
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvListado.EnableHeadersVisualStyles = false;
            this.dgvListado.Location = new System.Drawing.Point(14, 90);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListado.RowTemplate.Height = 19;
            this.dgvListado.Size = new System.Drawing.Size(972, 357);
            this.dgvListado.TabIndex = 49;
            this.dgvListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellClick);
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListado_CellMouseUp);
            this.dgvListado.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellValueChanged);
            this.dgvListado.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvListado_CurrentCellDirtyStateChanged);
            this.dgvListado.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvListado_DataBindingComplete);
            this.dgvListado.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvListado_EditingControlShowing);
            this.dgvListado.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvListado_RowPostPaint);
            // 
            // BON_is_especial
            // 
            this.BON_is_especial.DataPropertyName = "BON_is_especial";
            this.BON_is_especial.FalseValue = "N";
            this.BON_is_especial.HeaderText = "Especial";
            this.BON_is_especial.Name = "BON_is_especial";
            this.BON_is_especial.TrueValue = "S";
            this.BON_is_especial.Width = 61;
            // 
            // PRO_codigo_1
            // 
            this.PRO_codigo_1.DataPropertyName = "PRO_codigo_1";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            this.PRO_codigo_1.DefaultCellStyle = dataGridViewCellStyle1;
            this.PRO_codigo_1.HeaderText = "Código";
            this.PRO_codigo_1.Name = "PRO_codigo_1";
            this.PRO_codigo_1.ReadOnly = true;
            this.PRO_codigo_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRO_codigo_1.Width = 76;
            // 
            // PRO_descripcion_1
            // 
            this.PRO_descripcion_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRO_descripcion_1.DataPropertyName = "PRO_descripcion_1";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRO_descripcion_1.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRO_descripcion_1.HeaderText = "Producto";
            this.PRO_descripcion_1.Name = "PRO_descripcion_1";
            this.PRO_descripcion_1.ReadOnly = true;
            this.PRO_descripcion_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRO_descripcion_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cantidad_1
            // 
            this.Cantidad_1.DataPropertyName = "Cantidad_1";
            this.Cantidad_1.HeaderText = "Cant.";
            this.Cantidad_1.Name = "Cantidad_1";
            this.Cantidad_1.Width = 62;
            // 
            // Cantidad_sub_1
            // 
            this.Cantidad_sub_1.DataPropertyName = "Cantidad_sub_1";
            this.Cantidad_sub_1.HeaderText = "Cant.Sub.";
            this.Cantidad_sub_1.Name = "Cantidad_sub_1";
            this.Cantidad_sub_1.Width = 87;
            // 
            // PRO_codigo_2
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            this.PRO_codigo_2.DefaultCellStyle = dataGridViewCellStyle3;
            this.PRO_codigo_2.HeaderText = "Código";
            this.PRO_codigo_2.Name = "PRO_codigo_2";
            this.PRO_codigo_2.ReadOnly = true;
            this.PRO_codigo_2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRO_codigo_2.Width = 76;
            // 
            // PRO_descripcion_2
            // 
            this.PRO_descripcion_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRO_descripcion_2.HeaderText = "Producto";
            this.PRO_descripcion_2.Name = "PRO_descripcion_2";
            this.PRO_descripcion_2.ReadOnly = true;
            this.PRO_descripcion_2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRO_descripcion_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cantidad_2
            // 
            this.Cantidad_2.HeaderText = "Cant.";
            this.Cantidad_2.Name = "Cantidad_2";
            this.Cantidad_2.Width = 62;
            // 
            // Cantidad_sub_2
            // 
            this.Cantidad_sub_2.HeaderText = "Cant.Sub.";
            this.Cantidad_sub_2.Name = "Cantidad_sub_2";
            this.Cantidad_sub_2.Width = 87;
            // 
            // Cantidad_esp_2
            // 
            this.Cantidad_esp_2.HeaderText = "Cant.E";
            this.Cantidad_esp_2.Name = "Cantidad_esp_2";
            this.Cantidad_esp_2.Width = 69;
            // 
            // Cantidad_esp_sub_2
            // 
            this.Cantidad_esp_sub_2.HeaderText = "Cant.Sub.E";
            this.Cantidad_esp_sub_2.Name = "Cantidad_esp_sub_2";
            this.Cantidad_esp_sub_2.Width = 94;
            // 
            // BON_fecha_vencimiento
            // 
            this.BON_fecha_vencimiento.DataPropertyName = "BON_fecha_vencimiento";
            this.BON_fecha_vencimiento.HeaderText = "F.Vencimiento";
            this.BON_fecha_vencimiento.Name = "BON_fecha_vencimiento";
            this.BON_fecha_vencimiento.ReadOnly = true;
            this.BON_fecha_vencimiento.Width = 112;
            // 
            // cmbCanal
            // 
            this.cmbCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCanal.FormattingEnabled = true;
            this.cmbCanal.Location = new System.Drawing.Point(451, 28);
            this.cmbCanal.Name = "cmbCanal";
            this.cmbCanal.Size = new System.Drawing.Size(203, 25);
            this.cmbCanal.TabIndex = 48;
            this.cmbCanal.DropDown += new System.EventHandler(this.cmbCanal_DropDown);
            this.cmbCanal.SelectedIndexChanged += new System.EventHandler(this.cmbCanal_SelectedIndexChanged);
            this.cmbCanal.SelectionChangeCommitted += new System.EventHandler(this.cmbCanal_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione canal";
            // 
            // frmOP_Bonificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 551);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmOP_Bonificaciones";
            this.Text = "Tabla de bonificaciones";
            this.Load += new System.EventHandler(this.frmOP_Bonificaciones_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            this.menuContextual.ResumeLayout(false);
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ComboBox cmbCanal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip menuContextual;
        private System.Windows.Forms.ToolStripMenuItem eliminarFilaToolStripMenuItem;
        private System.Windows.Forms.Button btnGoCanal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BON_is_especial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_codigo_1;
        private System.Windows.Forms.DataGridViewLinkColumn PRO_descripcion_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_sub_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_codigo_2;
        private System.Windows.Forms.DataGridViewLinkColumn PRO_descripcion_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_sub_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_esp_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_esp_sub_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BON_fecha_vencimiento;
    }
}