namespace Presentacion
{
    partial class frmOP_GeneracionDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_GeneracionDocumentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbOrigen = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSumaPedidosAbiertos = new System.Windows.Forms.TextBox();
            this.picSum = new System.Windows.Forms.PictureBox();
            this.txtSumaPedidos = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvOrigen = new System.Windows.Forms.DataGridView();
            this.PED_tdo_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abierto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cerrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chkReasignacion = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbDestino = new System.Windows.Forms.GroupBox();
            this.btnGoSerie = new System.Windows.Forms.Button();
            this.btnGoTipoDocumento = new System.Windows.Forms.Button();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLabeDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtCantidadDocumentos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCorrelativoInicial = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gpbOrigen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).BeginInit();
            this.gpbDestino.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOrigen
            // 
            this.gpbOrigen.Controls.Add(this.pictureBox1);
            this.gpbOrigen.Controls.Add(this.txtSumaPedidosAbiertos);
            this.gpbOrigen.Controls.Add(this.picSum);
            this.gpbOrigen.Controls.Add(this.txtSumaPedidos);
            this.gpbOrigen.Controls.Add(this.dtpFecha);
            this.gpbOrigen.Controls.Add(this.dgvOrigen);
            this.gpbOrigen.Controls.Add(this.textBox2);
            this.gpbOrigen.Controls.Add(this.chkReasignacion);
            this.gpbOrigen.Controls.Add(this.label2);
            this.gpbOrigen.Location = new System.Drawing.Point(12, 5);
            this.gpbOrigen.Name = "gpbOrigen";
            this.gpbOrigen.Size = new System.Drawing.Size(259, 373);
            this.gpbOrigen.TabIndex = 0;
            this.gpbOrigen.TabStop = false;
            this.gpbOrigen.Text = "Pedidos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txtSumaPedidosAbiertos
            // 
            this.txtSumaPedidosAbiertos.BackColor = System.Drawing.Color.Silver;
            this.txtSumaPedidosAbiertos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaPedidosAbiertos.Location = new System.Drawing.Point(73, 276);
            this.txtSumaPedidosAbiertos.Name = "txtSumaPedidosAbiertos";
            this.txtSumaPedidosAbiertos.Size = new System.Drawing.Size(85, 25);
            this.txtSumaPedidosAbiertos.TabIndex = 20;
            this.txtSumaPedidosAbiertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // picSum
            // 
            this.picSum.BackColor = System.Drawing.Color.Silver;
            this.picSum.Image = ((System.Drawing.Image)(resources.GetObject("picSum.Image")));
            this.picSum.Location = new System.Drawing.Point(161, 280);
            this.picSum.Name = "picSum";
            this.picSum.Size = new System.Drawing.Size(16, 16);
            this.picSum.TabIndex = 19;
            this.picSum.TabStop = false;
            // 
            // txtSumaPedidos
            // 
            this.txtSumaPedidos.BackColor = System.Drawing.Color.Silver;
            this.txtSumaPedidos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaPedidos.Location = new System.Drawing.Point(159, 276);
            this.txtSumaPedidos.Name = "txtSumaPedidos";
            this.txtSumaPedidos.Size = new System.Drawing.Size(85, 25);
            this.txtSumaPedidos.TabIndex = 18;
            this.txtSumaPedidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.Orange;
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.Orange;
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.Color.Gold;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(128, 32);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(108, 25);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.CloseUp += new System.EventHandler(this.dtpFecha_CloseUp);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dgvOrigen
            // 
            this.dgvOrigen.AllowUserToAddRows = false;
            this.dgvOrigen.AllowUserToDeleteRows = false;
            this.dgvOrigen.AllowUserToResizeRows = false;
            this.dgvOrigen.BackgroundColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrigen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PED_tdo_codigo,
            this.Abierto,
            this.Cerrado});
            this.dgvOrigen.EnableHeadersVisualStyles = false;
            this.dgvOrigen.Location = new System.Drawing.Point(12, 109);
            this.dgvOrigen.Name = "dgvOrigen";
            this.dgvOrigen.ReadOnly = true;
            this.dgvOrigen.RowHeadersVisible = false;
            this.dgvOrigen.Size = new System.Drawing.Size(234, 166);
            this.dgvOrigen.TabIndex = 10;
            this.dgvOrigen.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrigen_DataBindingComplete);
            // 
            // PED_tdo_codigo
            // 
            this.PED_tdo_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PED_tdo_codigo.DataPropertyName = "PED_tdo_codigo";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Orange;
            this.PED_tdo_codigo.DefaultCellStyle = dataGridViewCellStyle4;
            this.PED_tdo_codigo.HeaderText = "Tipo Doc.";
            this.PED_tdo_codigo.Name = "PED_tdo_codigo";
            this.PED_tdo_codigo.ReadOnly = true;
            // 
            // Abierto
            // 
            this.Abierto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Abierto.DataPropertyName = "Abierto";
            this.Abierto.HeaderText = "Abiertos";
            this.Abierto.Name = "Abierto";
            this.Abierto.ReadOnly = true;
            this.Abierto.Width = 82;
            // 
            // Cerrado
            // 
            this.Cerrado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cerrado.DataPropertyName = "Cerrado";
            this.Cerrado.HeaderText = "Cerrados";
            this.Cerrado.Name = "Cerrado";
            this.Cerrado.ReadOnly = true;
            this.Cerrado.Width = 87;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(14, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 18);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "INFORMACIÓN";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkReasignacion
            // 
            this.chkReasignacion.AutoSize = true;
            this.chkReasignacion.Location = new System.Drawing.Point(12, 308);
            this.chkReasignacion.Name = "chkReasignacion";
            this.chkReasignacion.Size = new System.Drawing.Size(234, 21);
            this.chkReasignacion.TabIndex = 2;
            this.chkReasignacion.Text = "Es una reasignación de correlativos";
            this.chkReasignacion.UseVisualStyleBackColor = true;
            this.chkReasignacion.CheckedChanged += new System.EventHandler(this.chkReasignacion_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de pedidos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpbDestino
            // 
            this.gpbDestino.BackColor = System.Drawing.SystemColors.Control;
            this.gpbDestino.Controls.Add(this.btnGoSerie);
            this.gpbDestino.Controls.Add(this.btnGoTipoDocumento);
            this.gpbDestino.Controls.Add(this.cmbSerie);
            this.gpbDestino.Controls.Add(this.cmbTipoDocumento);
            this.gpbDestino.Controls.Add(this.label8);
            this.gpbDestino.Controls.Add(this.label7);
            this.gpbDestino.Controls.Add(this.panel1);
            this.gpbDestino.Enabled = false;
            this.gpbDestino.Location = new System.Drawing.Point(277, 5);
            this.gpbDestino.Name = "gpbDestino";
            this.gpbDestino.Size = new System.Drawing.Size(420, 373);
            this.gpbDestino.TabIndex = 1;
            this.gpbDestino.TabStop = false;
            this.gpbDestino.Text = "Documentos de venta";
            // 
            // btnGoSerie
            // 
            this.btnGoSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoSerie.Image = ((System.Drawing.Image)(resources.GetObject("btnGoSerie.Image")));
            this.btnGoSerie.Location = new System.Drawing.Point(316, 65);
            this.btnGoSerie.Name = "btnGoSerie";
            this.btnGoSerie.Size = new System.Drawing.Size(25, 25);
            this.btnGoSerie.TabIndex = 99;
            this.btnGoSerie.UseVisualStyleBackColor = true;
            this.btnGoSerie.Click += new System.EventHandler(this.btnGoSerie_Click);
            // 
            // btnGoTipoDocumento
            // 
            this.btnGoTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTipoDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnGoTipoDocumento.Image")));
            this.btnGoTipoDocumento.Location = new System.Drawing.Point(367, 35);
            this.btnGoTipoDocumento.Name = "btnGoTipoDocumento";
            this.btnGoTipoDocumento.Size = new System.Drawing.Size(25, 25);
            this.btnGoTipoDocumento.TabIndex = 98;
            this.btnGoTipoDocumento.UseVisualStyleBackColor = true;
            this.btnGoTipoDocumento.Click += new System.EventHandler(this.btnGoTipoDocumento_Click);
            // 
            // cmbSerie
            // 
            this.cmbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Location = new System.Drawing.Point(193, 65);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(121, 25);
            this.cmbSerie.TabIndex = 16;
            this.cmbSerie.DropDown += new System.EventHandler(this.cmbSerie_DropDown);
            this.cmbSerie.SelectedIndexChanged += new System.EventHandler(this.cmbSerie_SelectedIndexChanged);
            this.cmbSerie.SelectionChangeCommitted += new System.EventHandler(this.cmbSerie_SelectionChangeCommitted);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(193, 35);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(172, 25);
            this.cmbTipoDocumento.TabIndex = 15;
            this.cmbTipoDocumento.DropDown += new System.EventHandler(this.cmbTipoDocumento_DropDown);
            this.cmbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedIndexChanged);
            this.cmbTipoDocumento.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoDocumento_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Seleccione Serie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Seleccione tipo documento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtLabeDocumento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpFechaEntrega);
            this.panel1.Controls.Add(this.txtCantidadDocumentos);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCorrelativoInicial);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Location = new System.Drawing.Point(16, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 242);
            this.panel1.TabIndex = 5;
            // 
            // txtLabeDocumento
            // 
            this.txtLabeDocumento.BackColor = System.Drawing.Color.Orange;
            this.txtLabeDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabeDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabeDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLabeDocumento.Location = new System.Drawing.Point(79, 11);
            this.txtLabeDocumento.Name = "txtLabeDocumento";
            this.txtLabeDocumento.Size = new System.Drawing.Size(230, 22);
            this.txtLabeDocumento.TabIndex = 17;
            this.txtLabeDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha de contab. y entrega";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(224, 54);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(108, 25);
            this.dtpFechaEntrega.TabIndex = 22;
            // 
            // txtCantidadDocumentos
            // 
            this.txtCantidadDocumentos.BackColor = System.Drawing.Color.Silver;
            this.txtCantidadDocumentos.Location = new System.Drawing.Point(224, 85);
            this.txtCantidadDocumentos.Name = "txtCantidadDocumentos";
            this.txtCantidadDocumentos.ReadOnly = true;
            this.txtCantidadDocumentos.Size = new System.Drawing.Size(66, 25);
            this.txtCantidadDocumentos.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cantidad de documentos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Correlativo inicial";
            // 
            // txtCorrelativoInicial
            // 
            this.txtCorrelativoInicial.BackColor = System.Drawing.SystemColors.Window;
            this.txtCorrelativoInicial.Location = new System.Drawing.Point(223, 116);
            this.txtCorrelativoInicial.Name = "txtCorrelativoInicial";
            this.txtCorrelativoInicial.ReadOnly = true;
            this.txtCorrelativoInicial.Size = new System.Drawing.Size(109, 25);
            this.txtCorrelativoInicial.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(148, 161);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(98, 55);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmOP_GeneracionDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(708, 388);
            this.Controls.Add(this.gpbDestino);
            this.Controls.Add(this.gpbOrigen);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOP_GeneracionDocumentos";
            this.Text = "Generación de documentos";
            this.Load += new System.EventHandler(this.frmOP_GeneracionDocumentos_Load);
            this.VisibleChanged += new System.EventHandler(this.frmOP_GeneracionDocumentos_VisibleChanged);
            this.gpbOrigen.ResumeLayout(false);
            this.gpbOrigen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).EndInit();
            this.gpbDestino.ResumeLayout(false);
            this.gpbDestino.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOrigen;
        private System.Windows.Forms.GroupBox gpbDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.CheckBox chkReasignacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvOrigen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidadDocumentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCorrelativoInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSumaPedidosAbiertos;
        private System.Windows.Forms.PictureBox picSum;
        private System.Windows.Forms.TextBox txtSumaPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_tdo_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abierto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cerrado;
        private System.Windows.Forms.TextBox txtLabeDocumento;
        private System.Windows.Forms.Button btnGoTipoDocumento;
        private System.Windows.Forms.Button btnGoSerie;
    }
}