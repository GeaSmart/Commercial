namespace Presentacion
{
    partial class frmOP_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_Compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.btnSocioNegocio = new System.Windows.Forms.Button();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtPercepcion = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtDocumentoOrigen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGoSocio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtCodigoSocio = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaDocumento = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PRO_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_descripcion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DCO_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCO_cantidad_submultiplo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCO_precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCO_porcentaje_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_produccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCO_is_bonificacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PRO_porcentaje_igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_porcentaje_isc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoIGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoISC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subunidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCO_monto_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isValido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.btnSocioNegocio);
            this.gpbInformacion.Controls.Add(this.txtMontoTotal);
            this.gpbInformacion.Controls.Add(this.txtPercepcion);
            this.gpbInformacion.Controls.Add(this.txtImpuestos);
            this.gpbInformacion.Controls.Add(this.label10);
            this.gpbInformacion.Controls.Add(this.cmbTipoDocumento);
            this.gpbInformacion.Controls.Add(this.txtDocumentoOrigen);
            this.gpbInformacion.Controls.Add(this.label9);
            this.gpbInformacion.Controls.Add(this.btnGoSocio);
            this.gpbInformacion.Controls.Add(this.label6);
            this.gpbInformacion.Controls.Add(this.label5);
            this.gpbInformacion.Controls.Add(this.dgvDetalle);
            this.gpbInformacion.Controls.Add(this.label4);
            this.gpbInformacion.Controls.Add(this.label2);
            this.gpbInformacion.Controls.Add(this.txtNumero);
            this.gpbInformacion.Controls.Add(this.label15);
            this.gpbInformacion.Controls.Add(this.txtComentario);
            this.gpbInformacion.Controls.Add(this.txtSubtotal);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Controls.Add(this.label16);
            this.gpbInformacion.Controls.Add(this.label18);
            this.gpbInformacion.Controls.Add(this.cmbEstado);
            this.gpbInformacion.Controls.Add(this.txtNombreSocio);
            this.gpbInformacion.Controls.Add(this.txtCodigoSocio);
            this.gpbInformacion.Controls.Add(this.label17);
            this.gpbInformacion.Controls.Add(this.label8);
            this.gpbInformacion.Controls.Add(this.dtpFechaVencimiento);
            this.gpbInformacion.Controls.Add(this.label7);
            this.gpbInformacion.Controls.Add(this.dtpFechaDocumento);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(5, 54);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(969, 484);
            this.gpbInformacion.TabIndex = 8;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Informacion";
            // 
            // btnSocioNegocio
            // 
            this.btnSocioNegocio.Image = ((System.Drawing.Image)(resources.GetObject("btnSocioNegocio.Image")));
            this.btnSocioNegocio.Location = new System.Drawing.Point(137, 46);
            this.btnSocioNegocio.Name = "btnSocioNegocio";
            this.btnSocioNegocio.Size = new System.Drawing.Size(30, 25);
            this.btnSocioNegocio.TabIndex = 109;
            this.btnSocioNegocio.UseVisualStyleBackColor = true;
            this.btnSocioNegocio.Click += new System.EventHandler(this.btnSocioNegocio_Click);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.Color.LightCyan;
            this.txtMontoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.Location = new System.Drawing.Point(864, 445);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 25);
            this.txtMontoTotal.TabIndex = 108;
            this.txtMontoTotal.TabStop = false;
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPercepcion
            // 
            this.txtPercepcion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercepcion.Location = new System.Drawing.Point(864, 417);
            this.txtPercepcion.Name = "txtPercepcion";
            this.txtPercepcion.ReadOnly = true;
            this.txtPercepcion.Size = new System.Drawing.Size(100, 25);
            this.txtPercepcion.TabIndex = 107;
            this.txtPercepcion.TabStop = false;
            this.txtPercepcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(864, 389);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.ReadOnly = true;
            this.txtImpuestos.Size = new System.Drawing.Size(100, 25);
            this.txtImpuestos.TabIndex = 106;
            this.txtImpuestos.TabStop = false;
            this.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 105;
            this.label10.Text = "Tipo doc";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "ABIERTO",
            "CERRADO",
            "ANULADO"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(199, 21);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(141, 23);
            this.cmbTipoDocumento.TabIndex = 104;
            this.cmbTipoDocumento.TabStop = false;
            // 
            // txtDocumentoOrigen
            // 
            this.txtDocumentoOrigen.Location = new System.Drawing.Point(455, 21);
            this.txtDocumentoOrigen.Name = "txtDocumentoOrigen";
            this.txtDocumentoOrigen.Size = new System.Drawing.Size(117, 23);
            this.txtDocumentoOrigen.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 102;
            this.label9.Text = "Documento origen";
            // 
            // btnGoSocio
            // 
            this.btnGoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoSocio.Image = ((System.Drawing.Image)(resources.GetObject("btnGoSocio.Image")));
            this.btnGoSocio.Location = new System.Drawing.Point(549, 47);
            this.btnGoSocio.Name = "btnGoSocio";
            this.btnGoSocio.Size = new System.Drawing.Size(23, 23);
            this.btnGoSocio.TabIndex = 98;
            this.btnGoSocio.UseVisualStyleBackColor = true;
            this.btnGoSocio.Click += new System.EventHandler(this.btnGoSocio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(839, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 85;
            this.label6.Text = "S/.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(740, 445);
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
            this.DCO_cantidad,
            this.DCO_cantidad_submultiplo,
            this.DCO_precio_unitario,
            this.DCO_porcentaje_descuento,
            this.Subtotal,
            this.Impuestos,
            this.Fecha_produccion,
            this.Fecha_vencimiento,
            this.DCO_is_bonificacion,
            this.PRO_porcentaje_igv,
            this.PRO_porcentaje_isc,
            this.MontoIGV,
            this.MontoISC,
            this.Subunidades,
            this.DCO_monto_descuento,
            this.isValido});
            this.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.Location = new System.Drawing.Point(6, 77);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowTemplate.Height = 20;
            this.dgvDetalle.Size = new System.Drawing.Size(957, 278);
            this.dgvDetalle.TabIndex = 8;
            this.dgvDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellClick);
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            this.dgvDetalle.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDetalle_CellMouseUp);
            this.dgvDetalle.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDetalle_CurrentCellDirtyStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(796, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Percepción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(800, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Impuestos";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(73, 21);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 23);
            this.txtNumero.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 17);
            this.label15.TabIndex = 81;
            this.label15.Text = "Número";
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(12, 385);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.Size = new System.Drawing.Size(302, 85);
            this.txtComentario.TabIndex = 13;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(864, 361);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 25);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(811, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 366);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 15);
            this.label16.TabIndex = 70;
            this.label16.Text = "Comentarios";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(576, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 15);
            this.label18.TabIndex = 74;
            this.label18.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ABIERTO",
            "PAGADO",
            "ANULADO"});
            this.cmbEstado.Location = new System.Drawing.Point(620, 21);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(107, 23);
            this.cmbEstado.TabIndex = 73;
            this.cmbEstado.TabStop = false;
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(170, 47);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(377, 23);
            this.txtNombreSocio.TabIndex = 72;
            this.txtNombreSocio.TabStop = false;
            // 
            // txtCodigoSocio
            // 
            this.txtCodigoSocio.Location = new System.Drawing.Point(73, 47);
            this.txtCodigoSocio.Name = "txtCodigoSocio";
            this.txtCodigoSocio.ReadOnly = true;
            this.txtCodigoSocio.Size = new System.Drawing.Size(63, 23);
            this.txtCodigoSocio.TabIndex = 71;
            this.txtCodigoSocio.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 15);
            this.label17.TabIndex = 70;
            this.label17.Text = "Socio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(730, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 15);
            this.label8.TabIndex = 56;
            this.label8.Text = "Fecha de vencimiento";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(855, 47);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(107, 23);
            this.dtpFechaVencimiento.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(731, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "Fecha del documento";
            // 
            // dtpFechaDocumento
            // 
            this.dtpFechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDocumento.Location = new System.Drawing.Point(855, 21);
            this.dtpFechaDocumento.Name = "dtpFechaDocumento";
            this.dtpFechaDocumento.Size = new System.Drawing.Size(107, 23);
            this.dtpFechaDocumento.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarFilaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
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
            this.PRO_codigo.Width = 71;
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
            // DCO_cantidad
            // 
            this.DCO_cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DCO_cantidad.HeaderText = "Cantidad";
            this.DCO_cantidad.Name = "DCO_cantidad";
            this.DCO_cantidad.Width = 80;
            // 
            // DCO_cantidad_submultiplo
            // 
            this.DCO_cantidad_submultiplo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DCO_cantidad_submultiplo.HeaderText = "Sub-und";
            this.DCO_cantidad_submultiplo.Name = "DCO_cantidad_submultiplo";
            this.DCO_cantidad_submultiplo.Width = 78;
            // 
            // DCO_precio_unitario
            // 
            this.DCO_precio_unitario.HeaderText = "Precio Unit.";
            this.DCO_precio_unitario.Name = "DCO_precio_unitario";
            // 
            // DCO_porcentaje_descuento
            // 
            this.DCO_porcentaje_descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DCO_porcentaje_descuento.HeaderText = "Dscto.%";
            this.DCO_porcentaje_descuento.Name = "DCO_porcentaje_descuento";
            this.DCO_porcentaje_descuento.Width = 75;
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
            this.Impuestos.Width = 87;
            // 
            // Fecha_produccion
            // 
            this.Fecha_produccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fecha_produccion.HeaderText = "F.Prod.";
            this.Fecha_produccion.Name = "Fecha_produccion";
            this.Fecha_produccion.ReadOnly = true;
            this.Fecha_produccion.Width = 69;
            // 
            // Fecha_vencimiento
            // 
            this.Fecha_vencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fecha_vencimiento.HeaderText = "F.Venc.";
            this.Fecha_vencimiento.Name = "Fecha_vencimiento";
            this.Fecha_vencimiento.ReadOnly = true;
            this.Fecha_vencimiento.Width = 69;
            // 
            // DCO_is_bonificacion
            // 
            this.DCO_is_bonificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DCO_is_bonificacion.HeaderText = "Boni?";
            this.DCO_is_bonificacion.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.DCO_is_bonificacion.Name = "DCO_is_bonificacion";
            this.DCO_is_bonificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DCO_is_bonificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DCO_is_bonificacion.Width = 61;
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
            // DCO_monto_descuento
            // 
            this.DCO_monto_descuento.HeaderText = "Column1";
            this.DCO_monto_descuento.Name = "DCO_monto_descuento";
            this.DCO_monto_descuento.Visible = false;
            // 
            // isValido
            // 
            this.isValido.HeaderText = "isValido";
            this.isValido.Name = "isValido";
            this.isValido.Visible = false;
            // 
            // frmOP_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 564);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmOP_Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.frmOP_Compra_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.Button btnGoSocio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtCodigoSocio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaDocumento;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.TextBox txtPercepcion;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox txtDocumentoOrigen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSocioNegocio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarFilaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_codigo;
        private System.Windows.Forms.DataGridViewLinkColumn PRO_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCO_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCO_cantidad_submultiplo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCO_precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCO_porcentaje_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_vencimiento;
        private System.Windows.Forms.DataGridViewComboBoxColumn DCO_is_bonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_porcentaje_igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_porcentaje_isc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoIGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoISC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subunidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCO_monto_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn isValido;
    }
}