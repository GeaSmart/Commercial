namespace Presentacion
{
    partial class frmOP_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_Venta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.btnGoSocio = new System.Windows.Forms.Button();
            this.btnGoVendedor = new System.Windows.Forms.Button();
            this.btnGoCondicionPago = new System.Windows.Forms.Button();
            this.btnGoTipoVenta = new System.Windows.Forms.Button();
            this.btnGoChofer = new System.Windows.Forms.Button();
            this.btnGoMotivoDevolucion = new System.Windows.Forms.Button();
            this.btnGoPedido = new System.Windows.Forms.Button();
            this.btnGoTipoDocumento = new System.Windows.Forms.Button();
            this.btnGoSerie = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImporteCobrado = new System.Windows.Forms.TextBox();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.btnNullCmbChofer = new System.Windows.Forms.Button();
            this.btnNullCmbVendedor = new System.Windows.Forms.Button();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSocioNegocio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsVentaOficina = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPercepcion = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.chkIsComisionable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCondicionPago = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbMotivoDevolucion = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbTipoVenta = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtCodigoSocio = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCodigoVendedor = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbChofer = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSerieCorrelativo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaContabilizacion = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.menuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PRO_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_descripcion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DVE_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVE_cantidad_sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVE_precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVE_porcentaje_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVE_is_bonificacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PRO_porcentaje_igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_porcentaje_isc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoIGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoISC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subunidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVE_monto_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isValido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.menuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.btnGoSocio);
            this.gpbInformacion.Controls.Add(this.btnGoVendedor);
            this.gpbInformacion.Controls.Add(this.btnGoCondicionPago);
            this.gpbInformacion.Controls.Add(this.btnGoTipoVenta);
            this.gpbInformacion.Controls.Add(this.btnGoChofer);
            this.gpbInformacion.Controls.Add(this.btnGoMotivoDevolucion);
            this.gpbInformacion.Controls.Add(this.btnGoPedido);
            this.gpbInformacion.Controls.Add(this.btnGoTipoDocumento);
            this.gpbInformacion.Controls.Add(this.btnGoSerie);
            this.gpbInformacion.Controls.Add(this.txtEstado);
            this.gpbInformacion.Controls.Add(this.label21);
            this.gpbInformacion.Controls.Add(this.label10);
            this.gpbInformacion.Controls.Add(this.txtImporteCobrado);
            this.gpbInformacion.Controls.Add(this.txtChofer);
            this.gpbInformacion.Controls.Add(this.btnNullCmbChofer);
            this.gpbInformacion.Controls.Add(this.btnNullCmbVendedor);
            this.gpbInformacion.Controls.Add(this.txtVendedor);
            this.gpbInformacion.Controls.Add(this.cmbSerie);
            this.gpbInformacion.Controls.Add(this.label6);
            this.gpbInformacion.Controls.Add(this.btnSocioNegocio);
            this.gpbInformacion.Controls.Add(this.label5);
            this.gpbInformacion.Controls.Add(this.dgvDetalle);
            this.gpbInformacion.Controls.Add(this.label4);
            this.gpbInformacion.Controls.Add(this.chkIsVentaOficina);
            this.gpbInformacion.Controls.Add(this.label2);
            this.gpbInformacion.Controls.Add(this.txtPedido);
            this.gpbInformacion.Controls.Add(this.txtMontoTotal);
            this.gpbInformacion.Controls.Add(this.label15);
            this.gpbInformacion.Controls.Add(this.txtPercepcion);
            this.gpbInformacion.Controls.Add(this.txtComentario);
            this.gpbInformacion.Controls.Add(this.txtImpuestos);
            this.gpbInformacion.Controls.Add(this.chkIsComisionable);
            this.gpbInformacion.Controls.Add(this.label3);
            this.gpbInformacion.Controls.Add(this.txtSubtotal);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Controls.Add(this.cmbCondicionPago);
            this.gpbInformacion.Controls.Add(this.label19);
            this.gpbInformacion.Controls.Add(this.cmbMotivoDevolucion);
            this.gpbInformacion.Controls.Add(this.label16);
            this.gpbInformacion.Controls.Add(this.label20);
            this.gpbInformacion.Controls.Add(this.cmbTipoVenta);
            this.gpbInformacion.Controls.Add(this.label18);
            this.gpbInformacion.Controls.Add(this.txtNombreSocio);
            this.gpbInformacion.Controls.Add(this.txtCodigoSocio);
            this.gpbInformacion.Controls.Add(this.label17);
            this.gpbInformacion.Controls.Add(this.txtDireccion);
            this.gpbInformacion.Controls.Add(this.label14);
            this.gpbInformacion.Controls.Add(this.label13);
            this.gpbInformacion.Controls.Add(this.cmbCodigoVendedor);
            this.gpbInformacion.Controls.Add(this.label12);
            this.gpbInformacion.Controls.Add(this.cmbChofer);
            this.gpbInformacion.Controls.Add(this.label11);
            this.gpbInformacion.Controls.Add(this.label9);
            this.gpbInformacion.Controls.Add(this.txtSerieCorrelativo);
            this.gpbInformacion.Controls.Add(this.label8);
            this.gpbInformacion.Controls.Add(this.dtpFechaVencimiento);
            this.gpbInformacion.Controls.Add(this.label7);
            this.gpbInformacion.Controls.Add(this.dtpFechaContabilizacion);
            this.gpbInformacion.Controls.Add(this.cmbTipoDocumento);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(6, 56);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(925, 483);
            this.gpbInformacion.TabIndex = 7;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Informacion";
            // 
            // btnGoSocio
            // 
            this.btnGoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoSocio.Image = ((System.Drawing.Image)(resources.GetObject("btnGoSocio.Image")));
            this.btnGoSocio.Location = new System.Drawing.Point(623, 52);
            this.btnGoSocio.Name = "btnGoSocio";
            this.btnGoSocio.Size = new System.Drawing.Size(25, 25);
            this.btnGoSocio.TabIndex = 104;
            this.btnGoSocio.UseVisualStyleBackColor = true;
            this.btnGoSocio.Click += new System.EventHandler(this.btnGoSocio_Click);
            // 
            // btnGoVendedor
            // 
            this.btnGoVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoVendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnGoVendedor.Image")));
            this.btnGoVendedor.Location = new System.Drawing.Point(344, 361);
            this.btnGoVendedor.Name = "btnGoVendedor";
            this.btnGoVendedor.Size = new System.Drawing.Size(25, 25);
            this.btnGoVendedor.TabIndex = 103;
            this.btnGoVendedor.UseVisualStyleBackColor = true;
            this.btnGoVendedor.Click += new System.EventHandler(this.btnGoVendedor_Click);
            // 
            // btnGoCondicionPago
            // 
            this.btnGoCondicionPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoCondicionPago.Image = ((System.Drawing.Image)(resources.GetObject("btnGoCondicionPago.Image")));
            this.btnGoCondicionPago.Location = new System.Drawing.Point(707, 361);
            this.btnGoCondicionPago.Name = "btnGoCondicionPago";
            this.btnGoCondicionPago.Size = new System.Drawing.Size(25, 25);
            this.btnGoCondicionPago.TabIndex = 102;
            this.btnGoCondicionPago.UseVisualStyleBackColor = true;
            this.btnGoCondicionPago.Click += new System.EventHandler(this.btnGoCondicionPago_Click);
            // 
            // btnGoTipoVenta
            // 
            this.btnGoTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTipoVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnGoTipoVenta.Image")));
            this.btnGoTipoVenta.Location = new System.Drawing.Point(201, 113);
            this.btnGoTipoVenta.Name = "btnGoTipoVenta";
            this.btnGoTipoVenta.Size = new System.Drawing.Size(23, 23);
            this.btnGoTipoVenta.TabIndex = 101;
            this.btnGoTipoVenta.UseVisualStyleBackColor = true;
            this.btnGoTipoVenta.Click += new System.EventHandler(this.btnGoTipoVenta_Click);
            // 
            // btnGoChofer
            // 
            this.btnGoChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoChofer.Image = ((System.Drawing.Image)(resources.GetObject("btnGoChofer.Image")));
            this.btnGoChofer.Location = new System.Drawing.Point(436, 114);
            this.btnGoChofer.Name = "btnGoChofer";
            this.btnGoChofer.Size = new System.Drawing.Size(23, 23);
            this.btnGoChofer.TabIndex = 100;
            this.btnGoChofer.UseVisualStyleBackColor = true;
            this.btnGoChofer.Click += new System.EventHandler(this.btnGoChofer_Click);
            // 
            // btnGoMotivoDevolucion
            // 
            this.btnGoMotivoDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoMotivoDevolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnGoMotivoDevolucion.Image")));
            this.btnGoMotivoDevolucion.Location = new System.Drawing.Point(721, 114);
            this.btnGoMotivoDevolucion.Name = "btnGoMotivoDevolucion";
            this.btnGoMotivoDevolucion.Size = new System.Drawing.Size(25, 25);
            this.btnGoMotivoDevolucion.TabIndex = 99;
            this.btnGoMotivoDevolucion.UseVisualStyleBackColor = true;
            this.btnGoMotivoDevolucion.Click += new System.EventHandler(this.btnGoMotivoDevolucion_Click);
            // 
            // btnGoPedido
            // 
            this.btnGoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnGoPedido.Image")));
            this.btnGoPedido.Location = new System.Drawing.Point(888, 114);
            this.btnGoPedido.Name = "btnGoPedido";
            this.btnGoPedido.Size = new System.Drawing.Size(25, 25);
            this.btnGoPedido.TabIndex = 98;
            this.btnGoPedido.UseVisualStyleBackColor = true;
            this.btnGoPedido.Click += new System.EventHandler(this.btnGoPedido_Click);
            // 
            // btnGoTipoDocumento
            // 
            this.btnGoTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTipoDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnGoTipoDocumento.Image")));
            this.btnGoTipoDocumento.Location = new System.Drawing.Point(254, 21);
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
            this.btnGoSerie.Location = new System.Drawing.Point(369, 21);
            this.btnGoSerie.Name = "btnGoSerie";
            this.btnGoSerie.Size = new System.Drawing.Size(25, 25);
            this.btnGoSerie.TabIndex = 96;
            this.btnGoSerie.UseVisualStyleBackColor = true;
            this.btnGoSerie.Click += new System.EventHandler(this.btnGoSerie_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(806, 25);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(107, 23);
            this.txtEstado.TabIndex = 95;
            this.txtEstado.TabStop = false;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(790, 457);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 15);
            this.label21.TabIndex = 94;
            this.label21.Text = "S/.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(695, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 15);
            this.label10.TabIndex = 93;
            this.label10.Text = "Importe cobrado";
            // 
            // txtImporteCobrado
            // 
            this.txtImporteCobrado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteCobrado.Location = new System.Drawing.Point(813, 454);
            this.txtImporteCobrado.Name = "txtImporteCobrado";
            this.txtImporteCobrado.ReadOnly = true;
            this.txtImporteCobrado.Size = new System.Drawing.Size(100, 23);
            this.txtImporteCobrado.TabIndex = 92;
            this.txtImporteCobrado.TabStop = false;
            this.txtImporteCobrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteCobrado.TextChanged += new System.EventHandler(this.txtImporteCobrado_TextChanged);
            // 
            // txtChofer
            // 
            this.txtChofer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChofer.Location = new System.Drawing.Point(291, 114);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.ReadOnly = true;
            this.txtChofer.Size = new System.Drawing.Size(126, 23);
            this.txtChofer.TabIndex = 91;
            this.txtChofer.TabStop = false;
            // 
            // btnNullCmbChofer
            // 
            this.btnNullCmbChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNullCmbChofer.Image = ((System.Drawing.Image)(resources.GetObject("btnNullCmbChofer.Image")));
            this.btnNullCmbChofer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNullCmbChofer.Location = new System.Drawing.Point(267, 114);
            this.btnNullCmbChofer.Name = "btnNullCmbChofer";
            this.btnNullCmbChofer.Size = new System.Drawing.Size(22, 23);
            this.btnNullCmbChofer.TabIndex = 90;
            this.btnNullCmbChofer.UseVisualStyleBackColor = true;
            this.btnNullCmbChofer.Click += new System.EventHandler(this.btnNullCmbChofer_Click);
            // 
            // btnNullCmbVendedor
            // 
            this.btnNullCmbVendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnNullCmbVendedor.Image")));
            this.btnNullCmbVendedor.Location = new System.Drawing.Point(93, 360);
            this.btnNullCmbVendedor.Name = "btnNullCmbVendedor";
            this.btnNullCmbVendedor.Size = new System.Drawing.Size(26, 27);
            this.btnNullCmbVendedor.TabIndex = 88;
            this.btnNullCmbVendedor.UseVisualStyleBackColor = true;
            this.btnNullCmbVendedor.Click += new System.EventHandler(this.btnNullCmbVendedor_Click);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(119, 361);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(205, 25);
            this.txtVendedor.TabIndex = 87;
            this.txtVendedor.TabStop = false;
            // 
            // cmbSerie
            // 
            this.cmbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerie.Enabled = false;
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Location = new System.Drawing.Point(286, 21);
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
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(790, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 85;
            this.label6.Text = "S/.";
            // 
            // btnSocioNegocio
            // 
            this.btnSocioNegocio.Image = ((System.Drawing.Image)(resources.GetObject("btnSocioNegocio.Image")));
            this.btnSocioNegocio.Location = new System.Drawing.Point(210, 51);
            this.btnSocioNegocio.Name = "btnSocioNegocio";
            this.btnSocioNegocio.Size = new System.Drawing.Size(32, 27);
            this.btnSocioNegocio.TabIndex = 1;
            this.btnSocioNegocio.UseVisualStyleBackColor = true;
            this.btnSocioNegocio.Click += new System.EventHandler(this.btnSocioNegocio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(715, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Importe total";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_codigo,
            this.PRO_descripcion,
            this.DVE_cantidad,
            this.DVE_cantidad_sub,
            this.DVE_precio_unitario,
            this.DVE_porcentaje_descuento,
            this.Subtotal,
            this.Impuestos,
            this.DVE_is_bonificacion,
            this.PRO_porcentaje_igv,
            this.PRO_porcentaje_isc,
            this.MontoIGV,
            this.MontoISC,
            this.Subunidades,
            this.DVE_monto_descuento,
            this.isValido});
            this.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 145);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(745, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Percepción";
            // 
            // chkIsVentaOficina
            // 
            this.chkIsVentaOficina.AutoSize = true;
            this.chkIsVentaOficina.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsVentaOficina.Location = new System.Drawing.Point(395, 422);
            this.chkIsVentaOficina.Name = "chkIsVentaOficina";
            this.chkIsVentaOficina.Size = new System.Drawing.Size(119, 21);
            this.chkIsVentaOficina.TabIndex = 12;
            this.chkIsVentaOficina.Text = "Venta en oficina";
            this.chkIsVentaOficina.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Impuestos";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(806, 114);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(80, 25);
            this.txtPedido.TabIndex = 7;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.Color.PaleGreen;
            this.txtMontoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.Location = new System.Drawing.Point(813, 430);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 23);
            this.txtMontoTotal.TabIndex = 4;
            this.txtMontoTotal.TabStop = false;
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoTotal.TextChanged += new System.EventHandler(this.txtMontoTotal_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(755, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 81;
            this.label15.Text = "Pedido";
            // 
            // txtPercepcion
            // 
            this.txtPercepcion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercepcion.Location = new System.Drawing.Point(813, 406);
            this.txtPercepcion.Name = "txtPercepcion";
            this.txtPercepcion.ReadOnly = true;
            this.txtPercepcion.Size = new System.Drawing.Size(100, 23);
            this.txtPercepcion.TabIndex = 3;
            this.txtPercepcion.TabStop = false;
            this.txtPercepcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPercepcion.TextChanged += new System.EventHandler(this.txtPercepcion_TextChanged);
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(93, 394);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(276, 70);
            this.txtComentario.TabIndex = 13;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(813, 382);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.ReadOnly = true;
            this.txtImpuestos.Size = new System.Drawing.Size(100, 23);
            this.txtImpuestos.TabIndex = 2;
            this.txtImpuestos.TabStop = false;
            this.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImpuestos.TextChanged += new System.EventHandler(this.txtImpuestos_TextChanged);
            // 
            // chkIsComisionable
            // 
            this.chkIsComisionable.AutoSize = true;
            this.chkIsComisionable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsComisionable.Location = new System.Drawing.Point(395, 396);
            this.chkIsComisionable.Name = "chkIsComisionable";
            this.chkIsComisionable.Size = new System.Drawing.Size(121, 21);
            this.chkIsComisionable.TabIndex = 11;
            this.chkIsComisionable.Text = "Es comisionable";
            this.chkIsComisionable.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Condicion de pago";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(813, 358);
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
            this.label1.Location = new System.Drawing.Point(760, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // cmbCondicionPago
            // 
            this.cmbCondicionPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionPago.FormattingEnabled = true;
            this.cmbCondicionPago.Location = new System.Drawing.Point(514, 361);
            this.cmbCondicionPago.Name = "cmbCondicionPago";
            this.cmbCondicionPago.Size = new System.Drawing.Size(191, 25);
            this.cmbCondicionPago.TabIndex = 10;
            this.cmbCondicionPago.DropDown += new System.EventHandler(this.cmbCondicionPago_DropDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(461, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 17);
            this.label19.TabIndex = 78;
            this.label19.Text = "Motivo devolución";
            // 
            // cmbMotivoDevolucion
            // 
            this.cmbMotivoDevolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivoDevolucion.FormattingEnabled = true;
            this.cmbMotivoDevolucion.Location = new System.Drawing.Point(579, 114);
            this.cmbMotivoDevolucion.Name = "cmbMotivoDevolucion";
            this.cmbMotivoDevolucion.Size = new System.Drawing.Size(140, 25);
            this.cmbMotivoDevolucion.TabIndex = 6;
            this.cmbMotivoDevolucion.DropDown += new System.EventHandler(this.cmbMotivoDevolucion_DropDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 396);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 70;
            this.label16.Text = "Comentario";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(45, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 15);
            this.label20.TabIndex = 76;
            this.label20.Text = "Tipo venta";
            // 
            // cmbTipoVenta
            // 
            this.cmbTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVenta.FormattingEnabled = true;
            this.cmbTipoVenta.Location = new System.Drawing.Point(114, 113);
            this.cmbTipoVenta.Name = "cmbTipoVenta";
            this.cmbTipoVenta.Size = new System.Drawing.Size(85, 23);
            this.cmbTipoVenta.TabIndex = 4;
            this.cmbTipoVenta.DropDown += new System.EventHandler(this.cmbTipoVenta_DropDown);
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
            this.txtNombreSocio.Location = new System.Drawing.Point(244, 52);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(376, 25);
            this.txtNombreSocio.TabIndex = 72;
            this.txtNombreSocio.TabStop = false;
            // 
            // txtCodigoSocio
            // 
            this.txtCodigoSocio.Location = new System.Drawing.Point(114, 52);
            this.txtCodigoSocio.Name = "txtCodigoSocio";
            this.txtCodigoSocio.ReadOnly = true;
            this.txtCodigoSocio.Size = new System.Drawing.Size(95, 25);
            this.txtCodigoSocio.TabIndex = 71;
            this.txtCodigoSocio.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 17);
            this.label17.TabIndex = 70;
            this.label17.Text = "Socio negocio";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(114, 83);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(534, 25);
            this.txtDireccion.TabIndex = 67;
            this.txtDireccion.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 66;
            this.label14.Text = "Direccion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 65;
            this.label13.Text = "Vendedor";
            // 
            // cmbCodigoVendedor
            // 
            this.cmbCodigoVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoVendedor.FormattingEnabled = true;
            this.cmbCodigoVendedor.Location = new System.Drawing.Point(119, 361);
            this.cmbCodigoVendedor.Name = "cmbCodigoVendedor";
            this.cmbCodigoVendedor.Size = new System.Drawing.Size(223, 25);
            this.cmbCodigoVendedor.TabIndex = 9;
            this.cmbCodigoVendedor.DropDown += new System.EventHandler(this.cmbCodigoVendedor_DropDown);
            this.cmbCodigoVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoVendedor_SelectedIndexChanged);
            this.cmbCodigoVendedor.SelectionChangeCommitted += new System.EventHandler(this.cmbCodigoVendedor_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(225, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 63;
            this.label12.Text = "Chofer";
            // 
            // cmbChofer
            // 
            this.cmbChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChofer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChofer.FormattingEnabled = true;
            this.cmbChofer.Location = new System.Drawing.Point(291, 114);
            this.cmbChofer.Name = "cmbChofer";
            this.cmbChofer.Size = new System.Drawing.Size(143, 23);
            this.cmbChofer.TabIndex = 5;
            this.cmbChofer.DropDown += new System.EventHandler(this.cmbChofer_DropDown);
            this.cmbChofer.SelectedIndexChanged += new System.EventHandler(this.cmbChofer_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "Tipo Doc.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Documento";
            // 
            // txtSerieCorrelativo
            // 
            this.txtSerieCorrelativo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerieCorrelativo.Location = new System.Drawing.Point(489, 21);
            this.txtSerieCorrelativo.Name = "txtSerieCorrelativo";
            this.txtSerieCorrelativo.ReadOnly = true;
            this.txtSerieCorrelativo.Size = new System.Drawing.Size(159, 27);
            this.txtSerieCorrelativo.TabIndex = 57;
            this.txtSerieCorrelativo.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Fecha de vencimiento";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(806, 83);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(107, 25);
            this.dtpFechaVencimiento.TabIndex = 3;
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
            this.cmbTipoDocumento.Enabled = false;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(114, 21);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRO_descripcion.DefaultCellStyle = dataGridViewCellStyle1;
            this.PRO_descripcion.FillWeight = 200F;
            this.PRO_descripcion.HeaderText = "Producto";
            this.PRO_descripcion.LinkColor = System.Drawing.Color.Blue;
            this.PRO_descripcion.Name = "PRO_descripcion";
            this.PRO_descripcion.ReadOnly = true;
            this.PRO_descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRO_descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DVE_cantidad
            // 
            this.DVE_cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DVE_cantidad.HeaderText = "Cantidad";
            this.DVE_cantidad.Name = "DVE_cantidad";
            this.DVE_cantidad.Width = 85;
            // 
            // DVE_cantidad_sub
            // 
            this.DVE_cantidad_sub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DVE_cantidad_sub.HeaderText = "Sub-und";
            this.DVE_cantidad_sub.Name = "DVE_cantidad_sub";
            this.DVE_cantidad_sub.Width = 82;
            // 
            // DVE_precio_unitario
            // 
            this.DVE_precio_unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DVE_precio_unitario.HeaderText = "Precio Unit.";
            this.DVE_precio_unitario.Name = "DVE_precio_unitario";
            this.DVE_precio_unitario.ReadOnly = true;
            this.DVE_precio_unitario.Width = 99;
            // 
            // DVE_porcentaje_descuento
            // 
            this.DVE_porcentaje_descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DVE_porcentaje_descuento.HeaderText = "Dscto.%";
            this.DVE_porcentaje_descuento.Name = "DVE_porcentaje_descuento";
            this.DVE_porcentaje_descuento.ReadOnly = true;
            this.DVE_porcentaje_descuento.Width = 80;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 81;
            // 
            // Impuestos
            // 
            this.Impuestos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Impuestos.HeaderText = "Impuestos";
            this.Impuestos.Name = "Impuestos";
            this.Impuestos.ReadOnly = true;
            this.Impuestos.Width = 93;
            // 
            // DVE_is_bonificacion
            // 
            this.DVE_is_bonificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DVE_is_bonificacion.HeaderText = "Boni?";
            this.DVE_is_bonificacion.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.DVE_is_bonificacion.Name = "DVE_is_bonificacion";
            this.DVE_is_bonificacion.ReadOnly = true;
            this.DVE_is_bonificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DVE_is_bonificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DVE_is_bonificacion.Visible = false;
            this.DVE_is_bonificacion.Width = 64;
            // 
            // PRO_porcentaje_igv
            // 
            this.PRO_porcentaje_igv.HeaderText = "IGV";
            this.PRO_porcentaje_igv.Name = "PRO_porcentaje_igv";
            this.PRO_porcentaje_igv.Visible = false;
            // 
            // PRO_porcentaje_isc
            // 
            this.PRO_porcentaje_isc.HeaderText = "ISC";
            this.PRO_porcentaje_isc.Name = "PRO_porcentaje_isc";
            this.PRO_porcentaje_isc.Visible = false;
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
            // DVE_monto_descuento
            // 
            this.DVE_monto_descuento.HeaderText = "Column1";
            this.DVE_monto_descuento.Name = "DVE_monto_descuento";
            this.DVE_monto_descuento.Visible = false;
            // 
            // isValido
            // 
            this.isValido.HeaderText = "isValido";
            this.isValido.Name = "isValido";
            this.isValido.Visible = false;
            // 
            // frmOP_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(937, 565);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmOP_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documento de venta";
            this.Load += new System.EventHandler(this.frmOP_Venta_Load);
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
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCondicionPago;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbMotivoDevolucion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbTipoVenta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtCodigoSocio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCodigoVendedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbChofer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSerieCorrelativo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaContabilizacion;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.TextBox txtPercepcion;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkIsComisionable;
        private System.Windows.Forms.CheckBox chkIsVentaOficina;
        private System.Windows.Forms.Button btnSocioNegocio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.ContextMenuStrip menuContextual;
        private System.Windows.Forms.ToolStripMenuItem eliminarFilaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Button btnNullCmbVendedor;
        private System.Windows.Forms.TextBox txtChofer;
        private System.Windows.Forms.Button btnNullCmbChofer;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtImporteCobrado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnGoVendedor;
        private System.Windows.Forms.Button btnGoCondicionPago;
        private System.Windows.Forms.Button btnGoTipoVenta;
        private System.Windows.Forms.Button btnGoChofer;
        private System.Windows.Forms.Button btnGoMotivoDevolucion;
        private System.Windows.Forms.Button btnGoPedido;
        private System.Windows.Forms.Button btnGoTipoDocumento;
        private System.Windows.Forms.Button btnGoSerie;
        private System.Windows.Forms.Button btnGoSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_codigo;
        private System.Windows.Forms.DataGridViewLinkColumn PRO_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVE_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVE_cantidad_sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVE_precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVE_porcentaje_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuestos;
        private System.Windows.Forms.DataGridViewComboBoxColumn DVE_is_bonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_porcentaje_igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_porcentaje_isc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoIGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoISC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subunidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVE_monto_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn isValido;
    }
}