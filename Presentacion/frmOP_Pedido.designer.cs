namespace Presentacion
{
    partial class frmOP_Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_Pedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.btnSocioNegocio = new System.Windows.Forms.Button();
            this.btnGoTipoDocumento = new System.Windows.Forms.Button();
            this.btnGoCondicionPago = new System.Windows.Forms.Button();
            this.btnGoVendedor = new System.Windows.Forms.Button();
            this.btnGoSocio = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.sbtCopiara = new wyDay.Controls.SplitButton();
            this.menuContextual2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDocVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNullCmbVendedor = new System.Windows.Forms.Button();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPercepcion = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCondicionPago = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtCodigoSocio = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCodigoVendedor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.menuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PRO_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_descripcion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DPE_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_cantidad_submultiplo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_porcentaje_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_is_bonificacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PRO_porcentaje_igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_porcentaje_isc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoIGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoISC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subunidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_monto_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isValido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbInformacion.SuspendLayout();
            this.menuContextual2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.menuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.btnSocioNegocio);
            this.gpbInformacion.Controls.Add(this.btnGoTipoDocumento);
            this.gpbInformacion.Controls.Add(this.btnGoCondicionPago);
            this.gpbInformacion.Controls.Add(this.btnGoVendedor);
            this.gpbInformacion.Controls.Add(this.btnGoSocio);
            this.gpbInformacion.Controls.Add(this.label11);
            this.gpbInformacion.Controls.Add(this.cmbTipoDocumento);
            this.gpbInformacion.Controls.Add(this.sbtCopiara);
            this.gpbInformacion.Controls.Add(this.btnNullCmbVendedor);
            this.gpbInformacion.Controls.Add(this.txtVendedor);
            this.gpbInformacion.Controls.Add(this.label6);
            this.gpbInformacion.Controls.Add(this.label5);
            this.gpbInformacion.Controls.Add(this.dgvDetalle);
            this.gpbInformacion.Controls.Add(this.label4);
            this.gpbInformacion.Controls.Add(this.label2);
            this.gpbInformacion.Controls.Add(this.txtNumeroPedido);
            this.gpbInformacion.Controls.Add(this.txtMontoTotal);
            this.gpbInformacion.Controls.Add(this.label15);
            this.gpbInformacion.Controls.Add(this.txtPercepcion);
            this.gpbInformacion.Controls.Add(this.txtComentario);
            this.gpbInformacion.Controls.Add(this.txtImpuestos);
            this.gpbInformacion.Controls.Add(this.label3);
            this.gpbInformacion.Controls.Add(this.txtSubtotal);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Controls.Add(this.cmbCondicionPago);
            this.gpbInformacion.Controls.Add(this.label16);
            this.gpbInformacion.Controls.Add(this.label18);
            this.gpbInformacion.Controls.Add(this.cmbEstado);
            this.gpbInformacion.Controls.Add(this.txtNombreSocio);
            this.gpbInformacion.Controls.Add(this.txtCodigoSocio);
            this.gpbInformacion.Controls.Add(this.label17);
            this.gpbInformacion.Controls.Add(this.txtDireccion);
            this.gpbInformacion.Controls.Add(this.label14);
            this.gpbInformacion.Controls.Add(this.label13);
            this.gpbInformacion.Controls.Add(this.cmbCodigoVendedor);
            this.gpbInformacion.Controls.Add(this.label8);
            this.gpbInformacion.Controls.Add(this.dtpFechaEntrega);
            this.gpbInformacion.Controls.Add(this.label7);
            this.gpbInformacion.Controls.Add(this.dtpFechaPedido);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(6, 56);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(925, 426);
            this.gpbInformacion.TabIndex = 7;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Informacion";
            // 
            // btnSocioNegocio
            // 
            this.btnSocioNegocio.Image = ((System.Drawing.Image)(resources.GetObject("btnSocioNegocio.Image")));
            this.btnSocioNegocio.Location = new System.Drawing.Point(200, 19);
            this.btnSocioNegocio.Name = "btnSocioNegocio";
            this.btnSocioNegocio.Size = new System.Drawing.Size(32, 27);
            this.btnSocioNegocio.TabIndex = 102;
            this.btnSocioNegocio.UseVisualStyleBackColor = true;
            this.btnSocioNegocio.Click += new System.EventHandler(this.btnSocioNegocio_Click);
            // 
            // btnGoTipoDocumento
            // 
            this.btnGoTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTipoDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnGoTipoDocumento.Image")));
            this.btnGoTipoDocumento.Location = new System.Drawing.Point(682, 331);
            this.btnGoTipoDocumento.Name = "btnGoTipoDocumento";
            this.btnGoTipoDocumento.Size = new System.Drawing.Size(25, 25);
            this.btnGoTipoDocumento.TabIndex = 101;
            this.btnGoTipoDocumento.UseVisualStyleBackColor = true;
            this.btnGoTipoDocumento.Click += new System.EventHandler(this.btnGoTipoDocumento_Click);
            // 
            // btnGoCondicionPago
            // 
            this.btnGoCondicionPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoCondicionPago.Image = ((System.Drawing.Image)(resources.GetObject("btnGoCondicionPago.Image")));
            this.btnGoCondicionPago.Location = new System.Drawing.Point(682, 300);
            this.btnGoCondicionPago.Name = "btnGoCondicionPago";
            this.btnGoCondicionPago.Size = new System.Drawing.Size(25, 25);
            this.btnGoCondicionPago.TabIndex = 100;
            this.btnGoCondicionPago.UseVisualStyleBackColor = true;
            this.btnGoCondicionPago.Click += new System.EventHandler(this.btnGoCondicionPago_Click);
            // 
            // btnGoVendedor
            // 
            this.btnGoVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoVendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnGoVendedor.Image")));
            this.btnGoVendedor.Location = new System.Drawing.Point(370, 300);
            this.btnGoVendedor.Name = "btnGoVendedor";
            this.btnGoVendedor.Size = new System.Drawing.Size(25, 25);
            this.btnGoVendedor.TabIndex = 99;
            this.btnGoVendedor.UseVisualStyleBackColor = true;
            this.btnGoVendedor.Click += new System.EventHandler(this.btnGoVendedor_Click);
            // 
            // btnGoSocio
            // 
            this.btnGoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoSocio.Image = ((System.Drawing.Image)(resources.GetObject("btnGoSocio.Image")));
            this.btnGoSocio.Location = new System.Drawing.Point(492, 20);
            this.btnGoSocio.Name = "btnGoSocio";
            this.btnGoSocio.Size = new System.Drawing.Size(25, 25);
            this.btnGoSocio.TabIndex = 98;
            this.btnGoSocio.UseVisualStyleBackColor = true;
            this.btnGoSocio.Click += new System.EventHandler(this.btnGoSocio_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 91;
            this.label11.Text = "Tipo Doc. destino";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Enabled = false;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(528, 331);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(152, 25);
            this.cmbTipoDocumento.TabIndex = 90;
            this.cmbTipoDocumento.TabStop = false;
            this.cmbTipoDocumento.DropDown += new System.EventHandler(this.cmbTipoDocumento_DropDown);
            // 
            // sbtCopiara
            // 
            this.sbtCopiara.AutoSize = true;
            this.sbtCopiara.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sbtCopiara.ContextMenuStrip = this.menuContextual2;
            this.sbtCopiara.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtCopiara.Image = ((System.Drawing.Image)(resources.GetObject("sbtCopiara.Image")));
            this.sbtCopiara.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sbtCopiara.Location = new System.Drawing.Point(556, 362);
            this.sbtCopiara.Name = "sbtCopiara";
            this.sbtCopiara.Size = new System.Drawing.Size(124, 41);
            this.sbtCopiara.SplitMenuStrip = this.menuContextual2;
            this.sbtCopiara.TabIndex = 89;
            this.sbtCopiara.Text = "Copiar a ...";
            this.sbtCopiara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sbtCopiara.UseVisualStyleBackColor = false;
            // 
            // menuContextual2
            // 
            this.menuContextual2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDocVenta});
            this.menuContextual2.Name = "contextMenuStrip1";
            this.menuContextual2.Size = new System.Drawing.Size(186, 26);
            this.menuContextual2.Text = "Documento de venta";
            this.menuContextual2.Opening += new System.ComponentModel.CancelEventHandler(this.menuContextual2_Opening);
            // 
            // menuDocVenta
            // 
            this.menuDocVenta.Image = ((System.Drawing.Image)(resources.GetObject("menuDocVenta.Image")));
            this.menuDocVenta.Name = "menuDocVenta";
            this.menuDocVenta.Size = new System.Drawing.Size(185, 22);
            this.menuDocVenta.Text = "Documento de venta";
            this.menuDocVenta.Click += new System.EventHandler(this.menuDocVenta_Click);
            // 
            // btnNullCmbVendedor
            // 
            this.btnNullCmbVendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnNullCmbVendedor.Image")));
            this.btnNullCmbVendedor.Location = new System.Drawing.Point(93, 299);
            this.btnNullCmbVendedor.Name = "btnNullCmbVendedor";
            this.btnNullCmbVendedor.Size = new System.Drawing.Size(21, 27);
            this.btnNullCmbVendedor.TabIndex = 88;
            this.btnNullCmbVendedor.UseVisualStyleBackColor = true;
            this.btnNullCmbVendedor.Click += new System.EventHandler(this.btnNullCmbVendedor_Click);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(114, 300);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(233, 25);
            this.txtVendedor.TabIndex = 87;
            this.txtVendedor.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(788, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 85;
            this.label6.Text = "S/.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(690, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Monto total";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_codigo,
            this.PRO_descripcion,
            this.DPE_cantidad,
            this.DPE_cantidad_submultiplo,
            this.DPE_precio_unitario,
            this.DPE_porcentaje_descuento,
            this.Subtotal,
            this.Impuestos,
            this.DPE_is_bonificacion,
            this.PRO_porcentaje_igv,
            this.PRO_porcentaje_isc,
            this.MontoIGV,
            this.MontoISC,
            this.Subunidades,
            this.DPE_monto_descuento,
            this.isValido});
            this.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 82);
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
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(735, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Percepción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(739, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Impuestos";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(577, 21);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(108, 25);
            this.txtNumeroPedido.TabIndex = 7;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.Color.PaleGreen;
            this.txtMontoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.Location = new System.Drawing.Point(813, 381);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 29);
            this.txtMontoTotal.TabIndex = 4;
            this.txtMontoTotal.TabStop = false;
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoTotal.TextChanged += new System.EventHandler(this.txtMontoTotal_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(526, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 81;
            this.label15.Text = "Pedido";
            // 
            // txtPercepcion
            // 
            this.txtPercepcion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercepcion.Location = new System.Drawing.Point(813, 353);
            this.txtPercepcion.Name = "txtPercepcion";
            this.txtPercepcion.ReadOnly = true;
            this.txtPercepcion.Size = new System.Drawing.Size(100, 27);
            this.txtPercepcion.TabIndex = 3;
            this.txtPercepcion.TabStop = false;
            this.txtPercepcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPercepcion.TextChanged += new System.EventHandler(this.txtPercepcion_TextChanged);
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(93, 333);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(302, 77);
            this.txtComentario.TabIndex = 13;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(813, 325);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.ReadOnly = true;
            this.txtImpuestos.Size = new System.Drawing.Size(100, 27);
            this.txtImpuestos.TabIndex = 2;
            this.txtImpuestos.TabStop = false;
            this.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImpuestos.TextChanged += new System.EventHandler(this.txtImpuestos_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Condicion de pago";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(813, 297);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 27);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(751, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // cmbCondicionPago
            // 
            this.cmbCondicionPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionPago.FormattingEnabled = true;
            this.cmbCondicionPago.Location = new System.Drawing.Point(528, 300);
            this.cmbCondicionPago.Name = "cmbCondicionPago";
            this.cmbCondicionPago.Size = new System.Drawing.Size(152, 25);
            this.cmbCondicionPago.TabIndex = 10;
            this.cmbCondicionPago.DropDown += new System.EventHandler(this.cmbCondicionPago_DropDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 335);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 70;
            this.label16.Text = "Comentario";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(527, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 17);
            this.label18.TabIndex = 74;
            this.label18.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ABIERTO",
            "CERRADO",
            "ANULADO"});
            this.cmbEstado.Location = new System.Drawing.Point(577, 51);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(108, 25);
            this.cmbEstado.TabIndex = 73;
            this.cmbEstado.TabStop = false;
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(235, 20);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(255, 25);
            this.txtNombreSocio.TabIndex = 72;
            this.txtNombreSocio.TabStop = false;
            // 
            // txtCodigoSocio
            // 
            this.txtCodigoSocio.Location = new System.Drawing.Point(105, 20);
            this.txtCodigoSocio.Name = "txtCodigoSocio";
            this.txtCodigoSocio.ReadOnly = true;
            this.txtCodigoSocio.Size = new System.Drawing.Size(95, 25);
            this.txtCodigoSocio.TabIndex = 71;
            this.txtCodigoSocio.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 17);
            this.label17.TabIndex = 70;
            this.label17.Text = "Socio negocio";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(105, 51);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(412, 25);
            this.txtDireccion.TabIndex = 67;
            this.txtDireccion.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 66;
            this.label14.Text = "Direccion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 65;
            this.label13.Text = "Vendedor";
            // 
            // cmbCodigoVendedor
            // 
            this.cmbCodigoVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoVendedor.FormattingEnabled = true;
            this.cmbCodigoVendedor.Location = new System.Drawing.Point(114, 300);
            this.cmbCodigoVendedor.Name = "cmbCodigoVendedor";
            this.cmbCodigoVendedor.Size = new System.Drawing.Size(254, 25);
            this.cmbCodigoVendedor.TabIndex = 9;
            this.cmbCodigoVendedor.DropDown += new System.EventHandler(this.cmbCodigoVendedor_DropDown);
            this.cmbCodigoVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoVendedor_SelectedIndexChanged);
            this.cmbCodigoVendedor.SelectionChangeCommitted += new System.EventHandler(this.cmbCodigoVendedor_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(695, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Fecha de entrega";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(806, 48);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(107, 25);
            this.dtpFechaEntrega.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(698, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Fecha de pedido";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPedido.Location = new System.Drawing.Point(806, 17);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(107, 25);
            this.dtpFechaPedido.TabIndex = 2;
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
            this.PRO_descripcion.Name = "PRO_descripcion";
            this.PRO_descripcion.ReadOnly = true;
            this.PRO_descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRO_descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DPE_cantidad
            // 
            this.DPE_cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_cantidad.HeaderText = "Cantidad";
            this.DPE_cantidad.Name = "DPE_cantidad";
            this.DPE_cantidad.Width = 85;
            // 
            // DPE_cantidad_submultiplo
            // 
            this.DPE_cantidad_submultiplo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_cantidad_submultiplo.HeaderText = "Sub-und";
            this.DPE_cantidad_submultiplo.Name = "DPE_cantidad_submultiplo";
            this.DPE_cantidad_submultiplo.Width = 82;
            // 
            // DPE_precio_unitario
            // 
            this.DPE_precio_unitario.HeaderText = "Precio Unit.";
            this.DPE_precio_unitario.Name = "DPE_precio_unitario";
            this.DPE_precio_unitario.ReadOnly = true;
            // 
            // DPE_porcentaje_descuento
            // 
            this.DPE_porcentaje_descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_porcentaje_descuento.HeaderText = "Dscto.%";
            this.DPE_porcentaje_descuento.Name = "DPE_porcentaje_descuento";
            this.DPE_porcentaje_descuento.ReadOnly = true;
            this.DPE_porcentaje_descuento.Width = 80;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Impuestos
            // 
            this.Impuestos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Impuestos.HeaderText = "Impuestos";
            this.Impuestos.Name = "Impuestos";
            this.Impuestos.ReadOnly = true;
            this.Impuestos.Width = 93;
            // 
            // DPE_is_bonificacion
            // 
            this.DPE_is_bonificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_is_bonificacion.HeaderText = "Boni?";
            this.DPE_is_bonificacion.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.DPE_is_bonificacion.Name = "DPE_is_bonificacion";
            this.DPE_is_bonificacion.ReadOnly = true;
            this.DPE_is_bonificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DPE_is_bonificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DPE_is_bonificacion.Visible = false;
            this.DPE_is_bonificacion.Width = 64;
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
            // DPE_monto_descuento
            // 
            this.DPE_monto_descuento.HeaderText = "Column1";
            this.DPE_monto_descuento.Name = "DPE_monto_descuento";
            this.DPE_monto_descuento.Visible = false;
            // 
            // isValido
            // 
            this.isValido.HeaderText = "isValido";
            this.isValido.Name = "isValido";
            this.isValido.Visible = false;
            // 
            // frmOP_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(937, 508);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmOP_Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.frmOP_Venta_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            this.menuContextual2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.menuContextual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCondicionPago;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtCodigoSocio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCodigoVendedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip menuContextual;
        private System.Windows.Forms.ToolStripMenuItem eliminarFilaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Button btnNullCmbVendedor;
        private wyDay.Controls.SplitButton sbtCopiara;
        private System.Windows.Forms.ContextMenuStrip menuContextual2;
        private System.Windows.Forms.ToolStripMenuItem menuDocVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Button btnGoTipoDocumento;
        private System.Windows.Forms.Button btnGoCondicionPago;
        private System.Windows.Forms.Button btnGoVendedor;
        private System.Windows.Forms.Button btnGoSocio;
        private System.Windows.Forms.Button btnSocioNegocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_codigo;
        private System.Windows.Forms.DataGridViewLinkColumn PRO_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_cantidad_submultiplo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_porcentaje_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuestos;
        private System.Windows.Forms.DataGridViewComboBoxColumn DPE_is_bonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_porcentaje_igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_porcentaje_isc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoIGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoISC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subunidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_monto_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn isValido;
    }
}