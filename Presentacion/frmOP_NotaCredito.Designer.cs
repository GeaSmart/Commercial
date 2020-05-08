namespace Presentacion
{
    partial class frmOP_NotaCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_NotaCredito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGoDocumentoOrigen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDocumentoOrigen = new System.Windows.Forms.ComboBox();
            this.btnGoSocio = new System.Windows.Forms.Button();
            this.btnGoMotivoDevolucion = new System.Windows.Forms.Button();
            this.btnGoTipoDocumento = new System.Windows.Forms.Button();
            this.btnGoSerie = new System.Windows.Forms.Button();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSocioNegocio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.PRO_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_descripcion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DNC_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNC_cantidad_sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNC_precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNC_porcentaje_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_porcentaje_isc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_porcentaje_igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoIGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoISC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subunidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNC_monto_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isValido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbMotivoDevolucion = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtCodigoSocio = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSerieCorrelativo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaContabilizacion = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.menuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.menuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbInformacion.Controls.Add(this.cmbEstado);
            this.gpbInformacion.Controls.Add(this.btnGoDocumentoOrigen);
            this.gpbInformacion.Controls.Add(this.label8);
            this.gpbInformacion.Controls.Add(this.cmbDocumentoOrigen);
            this.gpbInformacion.Controls.Add(this.btnGoSocio);
            this.gpbInformacion.Controls.Add(this.btnGoMotivoDevolucion);
            this.gpbInformacion.Controls.Add(this.btnGoTipoDocumento);
            this.gpbInformacion.Controls.Add(this.btnGoSerie);
            this.gpbInformacion.Controls.Add(this.cmbSerie);
            this.gpbInformacion.Controls.Add(this.label6);
            this.gpbInformacion.Controls.Add(this.btnSocioNegocio);
            this.gpbInformacion.Controls.Add(this.label5);
            this.gpbInformacion.Controls.Add(this.dgvDetalle);
            this.gpbInformacion.Controls.Add(this.label2);
            this.gpbInformacion.Controls.Add(this.txtMontoTotal);
            this.gpbInformacion.Controls.Add(this.txtComentario);
            this.gpbInformacion.Controls.Add(this.txtImpuestos);
            this.gpbInformacion.Controls.Add(this.txtSubtotal);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Controls.Add(this.label19);
            this.gpbInformacion.Controls.Add(this.cmbMotivoDevolucion);
            this.gpbInformacion.Controls.Add(this.label16);
            this.gpbInformacion.Controls.Add(this.label18);
            this.gpbInformacion.Controls.Add(this.txtNombreSocio);
            this.gpbInformacion.Controls.Add(this.txtCodigoSocio);
            this.gpbInformacion.Controls.Add(this.label17);
            this.gpbInformacion.Controls.Add(this.label11);
            this.gpbInformacion.Controls.Add(this.label9);
            this.gpbInformacion.Controls.Add(this.txtSerieCorrelativo);
            this.gpbInformacion.Controls.Add(this.label7);
            this.gpbInformacion.Controls.Add(this.dtpFechaContabilizacion);
            this.gpbInformacion.Controls.Add(this.cmbTipoDocumento);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(7, 56);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(924, 412);
            this.gpbInformacion.TabIndex = 7;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Informacion";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ABIERTO",
            "ANULADO",
            "CERRADO"});
            this.cmbEstado.Location = new System.Drawing.Point(806, 23);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(107, 25);
            this.cmbEstado.TabIndex = 108;
            // 
            // btnGoDocumentoOrigen
            // 
            this.btnGoDocumentoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoDocumentoOrigen.Image = ((System.Drawing.Image)(resources.GetObject("btnGoDocumentoOrigen.Image")));
            this.btnGoDocumentoOrigen.Location = new System.Drawing.Point(307, 83);
            this.btnGoDocumentoOrigen.Name = "btnGoDocumentoOrigen";
            this.btnGoDocumentoOrigen.Size = new System.Drawing.Size(25, 25);
            this.btnGoDocumentoOrigen.TabIndex = 107;
            this.btnGoDocumentoOrigen.UseVisualStyleBackColor = true;
            this.btnGoDocumentoOrigen.Click += new System.EventHandler(this.btnGoDocumentoOrigen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 106;
            this.label8.Text = "Doc. Venta origen";
            // 
            // cmbDocumentoOrigen
            // 
            this.cmbDocumentoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumentoOrigen.FormattingEnabled = true;
            this.cmbDocumentoOrigen.Location = new System.Drawing.Point(117, 83);
            this.cmbDocumentoOrigen.Name = "cmbDocumentoOrigen";
            this.cmbDocumentoOrigen.Size = new System.Drawing.Size(188, 25);
            this.cmbDocumentoOrigen.TabIndex = 105;
            this.cmbDocumentoOrigen.DropDown += new System.EventHandler(this.cmbDocumentoOrigen_DropDown);
            // 
            // btnGoSocio
            // 
            this.btnGoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoSocio.Image = ((System.Drawing.Image)(resources.GetObject("btnGoSocio.Image")));
            this.btnGoSocio.Location = new System.Drawing.Point(626, 52);
            this.btnGoSocio.Name = "btnGoSocio";
            this.btnGoSocio.Size = new System.Drawing.Size(25, 25);
            this.btnGoSocio.TabIndex = 104;
            this.btnGoSocio.UseVisualStyleBackColor = true;
            this.btnGoSocio.Click += new System.EventHandler(this.btnGoSocio_Click);
            // 
            // btnGoMotivoDevolucion
            // 
            this.btnGoMotivoDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoMotivoDevolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnGoMotivoDevolucion.Image")));
            this.btnGoMotivoDevolucion.Location = new System.Drawing.Point(626, 83);
            this.btnGoMotivoDevolucion.Name = "btnGoMotivoDevolucion";
            this.btnGoMotivoDevolucion.Size = new System.Drawing.Size(25, 25);
            this.btnGoMotivoDevolucion.TabIndex = 99;
            this.btnGoMotivoDevolucion.UseVisualStyleBackColor = true;
            this.btnGoMotivoDevolucion.Click += new System.EventHandler(this.btnGoMotivoDevolucion_Click);
            // 
            // btnGoTipoDocumento
            // 
            this.btnGoTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTipoDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnGoTipoDocumento.Image")));
            this.btnGoTipoDocumento.Location = new System.Drawing.Point(257, 21);
            this.btnGoTipoDocumento.Name = "btnGoTipoDocumento";
            this.btnGoTipoDocumento.Size = new System.Drawing.Size(25, 25);
            this.btnGoTipoDocumento.TabIndex = 97;
            this.btnGoTipoDocumento.UseVisualStyleBackColor = true;
            this.btnGoTipoDocumento.Click += new System.EventHandler(this.btnGoTipoDocumento_Click);
            // 
            // btnGoSerie
            // 
            this.btnGoSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoSerie.Image = ((System.Drawing.Image)(resources.GetObject("btnGoSerie.Image")));
            this.btnGoSerie.Location = new System.Drawing.Point(372, 21);
            this.btnGoSerie.Name = "btnGoSerie";
            this.btnGoSerie.Size = new System.Drawing.Size(25, 25);
            this.btnGoSerie.TabIndex = 96;
            this.btnGoSerie.UseVisualStyleBackColor = true;
            this.btnGoSerie.Click += new System.EventHandler(this.btnGoSerie_Click);
            // 
            // cmbSerie
            // 
            this.cmbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Location = new System.Drawing.Point(289, 21);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(81, 25);
            this.cmbSerie.TabIndex = 86;
            this.cmbSerie.TabStop = false;
            this.cmbSerie.DropDown += new System.EventHandler(this.cmbSerie_DropDown);
            this.cmbSerie.SelectedIndexChanged += new System.EventHandler(this.cmbSerie_SelectedIndexChanged);
            this.cmbSerie.SelectionChangeCommitted += new System.EventHandler(this.cmbSerie_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(790, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 85;
            this.label6.Text = "S/.";
            // 
            // btnSocioNegocio
            // 
            this.btnSocioNegocio.Image = ((System.Drawing.Image)(resources.GetObject("btnSocioNegocio.Image")));
            this.btnSocioNegocio.Location = new System.Drawing.Point(213, 51);
            this.btnSocioNegocio.Name = "btnSocioNegocio";
            this.btnSocioNegocio.Size = new System.Drawing.Size(32, 27);
            this.btnSocioNegocio.TabIndex = 1;
            this.btnSocioNegocio.UseVisualStyleBackColor = true;
            this.btnSocioNegocio.Click += new System.EventHandler(this.btnSocioNegocio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(715, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Importe total";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_codigo,
            this.PRO_descripcion,
            this.DNC_cantidad,
            this.DNC_cantidad_sub,
            this.DNC_precio_unitario,
            this.DNC_porcentaje_descuento,
            this.Subtotal,
            this.PRO_porcentaje_isc,
            this.Impuestos,
            this.PRO_porcentaje_igv,
            this.MontoIGV,
            this.MontoISC,
            this.Subunidades,
            this.DNC_monto_descuento,
            this.isValido});
            this.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 115);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowTemplate.Height = 20;
            this.dgvDetalle.Size = new System.Drawing.Size(901, 210);
            this.dgvDetalle.TabIndex = 8;
            this.dgvDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellClick);
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            this.dgvDetalle.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDetalle_CellMouseUp);
            this.dgvDetalle.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDetalle_CurrentCellDirtyStateChanged);
            this.dgvDetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDetalle_EditingControlShowing);
            this.dgvDetalle.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDetalle_RowPostPaint);
            this.dgvDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDetalle_KeyPress);
            // 
            // PRO_codigo
            // 
            this.PRO_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PRO_codigo.Frozen = true;
            this.PRO_codigo.HeaderText = "Código";
            this.PRO_codigo.Name = "PRO_codigo";
            this.PRO_codigo.ReadOnly = true;
            this.PRO_codigo.Width = 76;
            // 
            // PRO_descripcion
            // 
            this.PRO_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRO_descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRO_descripcion.FillWeight = 200F;
            this.PRO_descripcion.HeaderText = "Producto";
            this.PRO_descripcion.LinkColor = System.Drawing.Color.Blue;
            this.PRO_descripcion.Name = "PRO_descripcion";
            this.PRO_descripcion.ReadOnly = true;
            this.PRO_descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRO_descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DNC_cantidad
            // 
            this.DNC_cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DNC_cantidad.HeaderText = "Cantidad";
            this.DNC_cantidad.Name = "DNC_cantidad";
            this.DNC_cantidad.Width = 85;
            // 
            // DNC_cantidad_sub
            // 
            this.DNC_cantidad_sub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DNC_cantidad_sub.HeaderText = "Sub-und";
            this.DNC_cantidad_sub.Name = "DNC_cantidad_sub";
            this.DNC_cantidad_sub.Width = 82;
            // 
            // DNC_precio_unitario
            // 
            this.DNC_precio_unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DNC_precio_unitario.HeaderText = "Precio Unit.";
            this.DNC_precio_unitario.Name = "DNC_precio_unitario";
            this.DNC_precio_unitario.ReadOnly = true;
            this.DNC_precio_unitario.Width = 99;
            // 
            // DNC_porcentaje_descuento
            // 
            this.DNC_porcentaje_descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DNC_porcentaje_descuento.HeaderText = "Dscto.%";
            this.DNC_porcentaje_descuento.Name = "DNC_porcentaje_descuento";
            this.DNC_porcentaje_descuento.Width = 80;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 81;
            // 
            // PRO_porcentaje_isc
            // 
            this.PRO_porcentaje_isc.HeaderText = "ISC";
            this.PRO_porcentaje_isc.Name = "PRO_porcentaje_isc";
            // 
            // Impuestos
            // 
            this.Impuestos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Impuestos.HeaderText = "Impuestos";
            this.Impuestos.Name = "Impuestos";
            this.Impuestos.ReadOnly = true;
            this.Impuestos.Width = 93;
            // 
            // PRO_porcentaje_igv
            // 
            this.PRO_porcentaje_igv.HeaderText = "IGV";
            this.PRO_porcentaje_igv.Name = "PRO_porcentaje_igv";
            this.PRO_porcentaje_igv.Visible = false;
            // 
            // MontoIGV
            // 
            this.MontoIGV.HeaderText = "MontoIGV";
            this.MontoIGV.Name = "MontoIGV";
            this.MontoIGV.Visible = false;
            // 
            // MontoISC
            // 
            this.MontoISC.HeaderText = "MontoISC";
            this.MontoISC.Name = "MontoISC";
            this.MontoISC.Visible = false;
            // 
            // Subunidades
            // 
            this.Subunidades.HeaderText = "Subunidades";
            this.Subunidades.Name = "Subunidades";
            this.Subunidades.Visible = false;
            // 
            // DNC_monto_descuento
            // 
            this.DNC_monto_descuento.HeaderText = "Column1";
            this.DNC_monto_descuento.Name = "DNC_monto_descuento";
            this.DNC_monto_descuento.Visible = false;
            // 
            // isValido
            // 
            this.isValido.HeaderText = "isValido";
            this.isValido.Name = "isValido";
            this.isValido.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Impuestos";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.Color.PaleGreen;
            this.txtMontoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.Location = new System.Drawing.Point(813, 378);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 23);
            this.txtMontoTotal.TabIndex = 4;
            this.txtMontoTotal.TabStop = false;
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoTotal.TextChanged += new System.EventHandler(this.txtMontoTotal_TextChanged);
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(12, 348);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(348, 53);
            this.txtComentario.TabIndex = 13;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(813, 353);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.ReadOnly = true;
            this.txtImpuestos.Size = new System.Drawing.Size(100, 23);
            this.txtImpuestos.TabIndex = 2;
            this.txtImpuestos.TabStop = false;
            this.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImpuestos.TextChanged += new System.EventHandler(this.txtImpuestos_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(813, 328);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(760, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(366, 86);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 17);
            this.label19.TabIndex = 78;
            this.label19.Text = "Motivo devolución";
            // 
            // cmbMotivoDevolucion
            // 
            this.cmbMotivoDevolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivoDevolucion.FormattingEnabled = true;
            this.cmbMotivoDevolucion.Location = new System.Drawing.Point(484, 83);
            this.cmbMotivoDevolucion.Name = "cmbMotivoDevolucion";
            this.cmbMotivoDevolucion.Size = new System.Drawing.Size(139, 25);
            this.cmbMotivoDevolucion.TabIndex = 6;
            this.cmbMotivoDevolucion.DropDown += new System.EventHandler(this.cmbMotivoDevolucion_DropDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 70;
            this.label16.Text = "Comentario";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(756, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 17);
            this.label18.TabIndex = 74;
            this.label18.Text = "Estado";
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(247, 52);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(376, 25);
            this.txtNombreSocio.TabIndex = 72;
            this.txtNombreSocio.TabStop = false;
            // 
            // txtCodigoSocio
            // 
            this.txtCodigoSocio.Location = new System.Drawing.Point(117, 52);
            this.txtCodigoSocio.Name = "txtCodigoSocio";
            this.txtCodigoSocio.ReadOnly = true;
            this.txtCodigoSocio.Size = new System.Drawing.Size(95, 25);
            this.txtCodigoSocio.TabIndex = 71;
            this.txtCodigoSocio.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 17);
            this.label17.TabIndex = 70;
            this.label17.Text = "Socio negocio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "Tipo Doc.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(409, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Documento";
            // 
            // txtSerieCorrelativo
            // 
            this.txtSerieCorrelativo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerieCorrelativo.Location = new System.Drawing.Point(492, 21);
            this.txtSerieCorrelativo.Name = "txtSerieCorrelativo";
            this.txtSerieCorrelativo.ReadOnly = true;
            this.txtSerieCorrelativo.Size = new System.Drawing.Size(159, 27);
            this.txtSerieCorrelativo.TabIndex = 57;
            this.txtSerieCorrelativo.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(654, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Fecha de contabilización";
            // 
            // dtpFechaContabilizacion
            // 
            this.dtpFechaContabilizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaContabilizacion.Location = new System.Drawing.Point(806, 52);
            this.dtpFechaContabilizacion.Name = "dtpFechaContabilizacion";
            this.dtpFechaContabilizacion.Size = new System.Drawing.Size(107, 25);
            this.dtpFechaContabilizacion.TabIndex = 2;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(117, 21);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(138, 25);
            this.cmbTipoDocumento.TabIndex = 52;
            this.cmbTipoDocumento.TabStop = false;
            this.cmbTipoDocumento.DropDown += new System.EventHandler(this.cmbTipoDocumento_DropDown);
            this.cmbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedIndexChanged);
            this.cmbTipoDocumento.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoDocumento_SelectionChangeCommitted);
            // 
            // menuContextual
            // 
            this.menuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarFilaToolStripMenuItem});
            this.menuContextual.Name = "menuContextual";
            this.menuContextual.Size = new System.Drawing.Size(137, 26);
            // 
            // eliminarFilaToolStripMenuItem
            // 
            this.eliminarFilaToolStripMenuItem.Name = "eliminarFilaToolStripMenuItem";
            this.eliminarFilaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.eliminarFilaToolStripMenuItem.Text = "Eliminar fila";
            this.eliminarFilaToolStripMenuItem.Click += new System.EventHandler(this.eliminarFilaToolStripMenuItem_Click);
            // 
            // frmOP_NotaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(938, 495);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmOP_NotaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota de credito";
            this.Load += new System.EventHandler(this.frmOP_NotaCredito_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.menuContextual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtCodigoSocio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSerieCorrelativo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaContabilizacion;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSocioNegocio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.ContextMenuStrip menuContextual;
        private System.Windows.Forms.ToolStripMenuItem eliminarFilaToolStripMenuItem;
        private System.Windows.Forms.Button btnGoTipoDocumento;
        private System.Windows.Forms.Button btnGoSerie;
        private System.Windows.Forms.Button btnGoSocio;
        private System.Windows.Forms.Button btnGoDocumentoOrigen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDocumentoOrigen;
        private System.Windows.Forms.Button btnGoMotivoDevolucion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbMotivoDevolucion;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_codigo;
        private System.Windows.Forms.DataGridViewLinkColumn PRO_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNC_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNC_cantidad_sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNC_precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNC_porcentaje_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_porcentaje_isc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_porcentaje_igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoIGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoISC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subunidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNC_monto_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn isValido;
    }
}