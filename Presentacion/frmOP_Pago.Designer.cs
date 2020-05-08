namespace Presentacion
{
    partial class frmOP_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_Pago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkSeleccionarTodosPago = new System.Windows.Forms.CheckBox();
            this.chkSoloAbiertos = new System.Windows.Forms.CheckBox();
            this.btnCargarDocumentos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTodoSerie = new System.Windows.Forms.CheckBox();
            this.dgvSerie = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TDO_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SER_serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SER_correlativo_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SER_correlativo_desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SER_correlativo_hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPago = new System.Windows.Forms.DataGridView();
            this.checkPago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VTA_serie_correlativo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.SOC_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOC_nombre_razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VTA_fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VTA_monto_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pendiente_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VTA_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MPA_nombre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PAG_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTodoCondicionPago = new System.Windows.Forms.CheckBox();
            this.dgvCondicionPago = new System.Windows.Forms.DataGridView();
            this.check2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CPA_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPA_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPA_dias_limite_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoChofer = new System.Windows.Forms.Button();
            this.btnGoTipoVenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbChofer = new System.Windows.Forms.ComboBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoVenta = new System.Windows.Forms.ComboBox();
            this.txtTotalTablaPendientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTotalFilasAbonos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalFilasPendientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidadFilas = new System.Windows.Forms.Label();
            this.lblCantidadFilasSeleccionadas = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionPago)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSeleccionarTodosPago
            // 
            this.chkSeleccionarTodosPago.AutoSize = true;
            this.chkSeleccionarTodosPago.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeleccionarTodosPago.Location = new System.Drawing.Point(12, 529);
            this.chkSeleccionarTodosPago.Name = "chkSeleccionarTodosPago";
            this.chkSeleccionarTodosPago.Size = new System.Drawing.Size(247, 17);
            this.chkSeleccionarTodosPago.TabIndex = 65;
            this.chkSeleccionarTodosPago.Text = "Seleccionar todos los documentos abiertos";
            this.chkSeleccionarTodosPago.UseVisualStyleBackColor = true;
            this.chkSeleccionarTodosPago.CheckedChanged += new System.EventHandler(this.chkSeleccionarTodosPago_CheckedChanged);
            // 
            // chkSoloAbiertos
            // 
            this.chkSoloAbiertos.AutoSize = true;
            this.chkSoloAbiertos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoloAbiertos.Location = new System.Drawing.Point(173, 189);
            this.chkSoloAbiertos.Name = "chkSoloAbiertos";
            this.chkSoloAbiertos.Size = new System.Drawing.Size(131, 17);
            this.chkSoloAbiertos.TabIndex = 64;
            this.chkSoloAbiertos.Text = "Cargar sólo Abiertos";
            this.chkSoloAbiertos.UseVisualStyleBackColor = true;
            // 
            // btnCargarDocumentos
            // 
            this.btnCargarDocumentos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDocumentos.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarDocumentos.Image")));
            this.btnCargarDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarDocumentos.Location = new System.Drawing.Point(14, 183);
            this.btnCargarDocumentos.Name = "btnCargarDocumentos";
            this.btnCargarDocumentos.Size = new System.Drawing.Size(153, 29);
            this.btnCargarDocumentos.TabIndex = 63;
            this.btnCargarDocumentos.Text = "Cargar documentos";
            this.btnCargarDocumentos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCargarDocumentos.UseVisualStyleBackColor = true;
            this.btnCargarDocumentos.Click += new System.EventHandler(this.btnCargarDocumentos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTodoSerie);
            this.groupBox2.Controls.Add(this.dgvSerie);
            this.groupBox2.Location = new System.Drawing.Point(322, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 154);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serie";
            // 
            // chkTodoSerie
            // 
            this.chkTodoSerie.AutoSize = true;
            this.chkTodoSerie.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodoSerie.Location = new System.Drawing.Point(19, 129);
            this.chkTodoSerie.Name = "chkTodoSerie";
            this.chkTodoSerie.Size = new System.Drawing.Size(51, 17);
            this.chkTodoSerie.TabIndex = 59;
            this.chkTodoSerie.Text = "Todo";
            this.chkTodoSerie.UseVisualStyleBackColor = true;
            this.chkTodoSerie.CheckedChanged += new System.EventHandler(this.chkTodoSerie_CheckedChanged);
            // 
            // dgvSerie
            // 
            this.dgvSerie.AllowUserToAddRows = false;
            this.dgvSerie.AllowUserToDeleteRows = false;
            this.dgvSerie.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvSerie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSerie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSerie.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.TDO_codigo,
            this.SER_serie,
            this.SER_correlativo_actual,
            this.SER_correlativo_desde,
            this.SER_correlativo_hasta});
            this.dgvSerie.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSerie.Location = new System.Drawing.Point(76, 18);
            this.dgvSerie.Name = "dgvSerie";
            this.dgvSerie.RowHeadersVisible = false;
            this.dgvSerie.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSerie.RowTemplate.Height = 19;
            this.dgvSerie.Size = new System.Drawing.Size(208, 129);
            this.dgvSerie.TabIndex = 49;
            // 
            // check
            // 
            this.check.DataPropertyName = "PRO_codigo";
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.Width = 19;
            // 
            // TDO_codigo
            // 
            this.TDO_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TDO_codigo.DataPropertyName = "TDO_codigo";
            this.TDO_codigo.HeaderText = "Tipo Doc.";
            this.TDO_codigo.Name = "TDO_codigo";
            // 
            // SER_serie
            // 
            this.SER_serie.DataPropertyName = "SER_serie";
            this.SER_serie.HeaderText = "Serie";
            this.SER_serie.Name = "SER_serie";
            this.SER_serie.Width = 57;
            // 
            // SER_correlativo_actual
            // 
            this.SER_correlativo_actual.DataPropertyName = "SER_correlativo_actual";
            this.SER_correlativo_actual.HeaderText = "SER_correlativo_actual";
            this.SER_correlativo_actual.Name = "SER_correlativo_actual";
            this.SER_correlativo_actual.Visible = false;
            this.SER_correlativo_actual.Width = 149;
            // 
            // SER_correlativo_desde
            // 
            this.SER_correlativo_desde.DataPropertyName = "SER_correlativo_desde";
            this.SER_correlativo_desde.HeaderText = "SER_correlativo_desde";
            this.SER_correlativo_desde.Name = "SER_correlativo_desde";
            this.SER_correlativo_desde.Visible = false;
            this.SER_correlativo_desde.Width = 148;
            // 
            // SER_correlativo_hasta
            // 
            this.SER_correlativo_hasta.DataPropertyName = "SER_correlativo_hasta";
            this.SER_correlativo_hasta.HeaderText = "SER_correlativo_hasta";
            this.SER_correlativo_hasta.Name = "SER_correlativo_hasta";
            this.SER_correlativo_hasta.Visible = false;
            this.SER_correlativo_hasta.Width = 145;
            // 
            // dgvPago
            // 
            this.dgvPago.AllowUserToAddRows = false;
            this.dgvPago.AllowUserToDeleteRows = false;
            this.dgvPago.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            this.dgvPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPago.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkPago,
            this.VTA_serie_correlativo,
            this.SOC_codigo,
            this.SOC_nombre_razon_social,
            this.VTA_fecha_vencimiento,
            this.VTA_monto_total,
            this.Pendiente_pago,
            this.Monto_pago,
            this.VTA_estado,
            this.MPA_nombre,
            this.PAG_referencia});
            this.dgvPago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPago.Location = new System.Drawing.Point(14, 214);
            this.dgvPago.Name = "dgvPago";
            this.dgvPago.RowHeadersVisible = false;
            this.dgvPago.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPago.RowTemplate.Height = 18;
            this.dgvPago.Size = new System.Drawing.Size(911, 309);
            this.dgvPago.TabIndex = 62;
            this.dgvPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPago_CellContentClick);
            this.dgvPago.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPago_CellValueChanged);
            this.dgvPago.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPago_CurrentCellDirtyStateChanged);
            // 
            // checkPago
            // 
            this.checkPago.HeaderText = "";
            this.checkPago.Name = "checkPago";
            this.checkPago.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkPago.Width = 19;
            // 
            // VTA_serie_correlativo
            // 
            this.VTA_serie_correlativo.DataPropertyName = "VTA_serie_correlativo";
            this.VTA_serie_correlativo.HeaderText = "Doc.Vta.";
            this.VTA_serie_correlativo.Name = "VTA_serie_correlativo";
            this.VTA_serie_correlativo.ReadOnly = true;
            this.VTA_serie_correlativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VTA_serie_correlativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VTA_serie_correlativo.Width = 76;
            // 
            // SOC_codigo
            // 
            this.SOC_codigo.DataPropertyName = "SOC_codigo";
            this.SOC_codigo.HeaderText = "Cod.";
            this.SOC_codigo.Name = "SOC_codigo";
            this.SOC_codigo.ReadOnly = true;
            this.SOC_codigo.Width = 57;
            // 
            // SOC_nombre_razon_social
            // 
            this.SOC_nombre_razon_social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOC_nombre_razon_social.DataPropertyName = "SOC_nombre_razon_social";
            this.SOC_nombre_razon_social.HeaderText = "Cliente";
            this.SOC_nombre_razon_social.Name = "SOC_nombre_razon_social";
            this.SOC_nombre_razon_social.ReadOnly = true;
            // 
            // VTA_fecha_vencimiento
            // 
            this.VTA_fecha_vencimiento.DataPropertyName = "VTA_fecha_vencimiento";
            this.VTA_fecha_vencimiento.HeaderText = "Vencimiento";
            this.VTA_fecha_vencimiento.Name = "VTA_fecha_vencimiento";
            this.VTA_fecha_vencimiento.ReadOnly = true;
            this.VTA_fecha_vencimiento.Width = 98;
            // 
            // VTA_monto_total
            // 
            this.VTA_monto_total.DataPropertyName = "VTA_monto_total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.VTA_monto_total.DefaultCellStyle = dataGridViewCellStyle3;
            this.VTA_monto_total.HeaderText = "Total";
            this.VTA_monto_total.Name = "VTA_monto_total";
            this.VTA_monto_total.ReadOnly = true;
            this.VTA_monto_total.Width = 58;
            // 
            // Pendiente_pago
            // 
            this.Pendiente_pago.DataPropertyName = "Pendiente_pago";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Pendiente_pago.DefaultCellStyle = dataGridViewCellStyle4;
            this.Pendiente_pago.HeaderText = "Pendiente";
            this.Pendiente_pago.Name = "Pendiente_pago";
            this.Pendiente_pago.ReadOnly = true;
            this.Pendiente_pago.Width = 85;
            // 
            // Monto_pago
            // 
            this.Monto_pago.DataPropertyName = "Monto_pago";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            this.Monto_pago.DefaultCellStyle = dataGridViewCellStyle5;
            this.Monto_pago.HeaderText = "Abono";
            this.Monto_pago.Name = "Monto_pago";
            this.Monto_pago.Width = 68;
            // 
            // VTA_estado
            // 
            this.VTA_estado.DataPropertyName = "VTA_estado";
            this.VTA_estado.HeaderText = "Estado";
            this.VTA_estado.Name = "VTA_estado";
            this.VTA_estado.ReadOnly = true;
            this.VTA_estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VTA_estado.Width = 67;
            // 
            // MPA_nombre
            // 
            this.MPA_nombre.DataPropertyName = "MPA_nombre";
            this.MPA_nombre.HeaderText = "Met.Pago";
            this.MPA_nombre.Name = "MPA_nombre";
            this.MPA_nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MPA_nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MPA_nombre.Width = 83;
            // 
            // PAG_referencia
            // 
            this.PAG_referencia.HeaderText = "Referencia";
            this.PAG_referencia.Name = "PAG_referencia";
            this.PAG_referencia.Width = 87;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTodoCondicionPago);
            this.groupBox3.Controls.Add(this.dgvCondicionPago);
            this.groupBox3.Location = new System.Drawing.Point(627, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 154);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Condicion de pago";
            // 
            // chkTodoCondicionPago
            // 
            this.chkTodoCondicionPago.AutoSize = true;
            this.chkTodoCondicionPago.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodoCondicionPago.Location = new System.Drawing.Point(18, 129);
            this.chkTodoCondicionPago.Name = "chkTodoCondicionPago";
            this.chkTodoCondicionPago.Size = new System.Drawing.Size(51, 17);
            this.chkTodoCondicionPago.TabIndex = 59;
            this.chkTodoCondicionPago.Text = "Todo";
            this.chkTodoCondicionPago.UseVisualStyleBackColor = true;
            this.chkTodoCondicionPago.CheckedChanged += new System.EventHandler(this.chkTodoCondicionPago_CheckedChanged);
            // 
            // dgvCondicionPago
            // 
            this.dgvCondicionPago.AllowUserToAddRows = false;
            this.dgvCondicionPago.AllowUserToDeleteRows = false;
            this.dgvCondicionPago.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender;
            this.dgvCondicionPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCondicionPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCondicionPago.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvCondicionPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondicionPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check2,
            this.CPA_codigo,
            this.CPA_descripcion,
            this.CPA_dias_limite_pago});
            this.dgvCondicionPago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCondicionPago.Location = new System.Drawing.Point(75, 18);
            this.dgvCondicionPago.Name = "dgvCondicionPago";
            this.dgvCondicionPago.RowHeadersVisible = false;
            this.dgvCondicionPago.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCondicionPago.RowTemplate.Height = 18;
            this.dgvCondicionPago.Size = new System.Drawing.Size(208, 129);
            this.dgvCondicionPago.TabIndex = 49;
            // 
            // check2
            // 
            this.check2.DataPropertyName = "PRO_codigo";
            this.check2.HeaderText = "";
            this.check2.Name = "check2";
            this.check2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check2.Width = 19;
            // 
            // CPA_codigo
            // 
            this.CPA_codigo.DataPropertyName = "CPA_codigo";
            this.CPA_codigo.HeaderText = "CPA_codigo";
            this.CPA_codigo.Name = "CPA_codigo";
            this.CPA_codigo.Visible = false;
            this.CPA_codigo.Width = 101;
            // 
            // CPA_descripcion
            // 
            this.CPA_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPA_descripcion.DataPropertyName = "CPA_descripcion";
            this.CPA_descripcion.HeaderText = "Condicion pago";
            this.CPA_descripcion.Name = "CPA_descripcion";
            // 
            // CPA_dias_limite_pago
            // 
            this.CPA_dias_limite_pago.DataPropertyName = "CPA_dias_limite_pago";
            this.CPA_dias_limite_pago.HeaderText = "CPA_dias_limite_pago";
            this.CPA_dias_limite_pago.Name = "CPA_dias_limite_pago";
            this.CPA_dias_limite_pago.Visible = false;
            this.CPA_dias_limite_pago.Width = 156;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGoChofer);
            this.groupBox1.Controls.Add(this.btnGoTipoVenta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbChofer);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.cmbTipoVenta);
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 126);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha y tipo";
            // 
            // btnGoChofer
            // 
            this.btnGoChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoChofer.Image = ((System.Drawing.Image)(resources.GetObject("btnGoChofer.Image")));
            this.btnGoChofer.Location = new System.Drawing.Point(262, 94);
            this.btnGoChofer.Name = "btnGoChofer";
            this.btnGoChofer.Size = new System.Drawing.Size(23, 23);
            this.btnGoChofer.TabIndex = 103;
            this.btnGoChofer.UseVisualStyleBackColor = true;
            this.btnGoChofer.Click += new System.EventHandler(this.btnGoChofer_Click);
            // 
            // btnGoTipoVenta
            // 
            this.btnGoTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTipoVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnGoTipoVenta.Image")));
            this.btnGoTipoVenta.Location = new System.Drawing.Point(262, 69);
            this.btnGoTipoVenta.Name = "btnGoTipoVenta";
            this.btnGoTipoVenta.Size = new System.Drawing.Size(23, 23);
            this.btnGoTipoVenta.TabIndex = 102;
            this.btnGoTipoVenta.UseVisualStyleBackColor = true;
            this.btnGoTipoVenta.Click += new System.EventHandler(this.btnGoTipoVenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Chofer";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(102, 19);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(114, 23);
            this.dtpDesde.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Tipo de venta";
            // 
            // cmbChofer
            // 
            this.cmbChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChofer.FormattingEnabled = true;
            this.cmbChofer.Location = new System.Drawing.Point(102, 94);
            this.cmbChofer.Name = "cmbChofer";
            this.cmbChofer.Size = new System.Drawing.Size(158, 23);
            this.cmbChofer.TabIndex = 59;
            this.cmbChofer.DropDown += new System.EventHandler(this.cmbChofer_DropDown);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(102, 44);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(114, 23);
            this.dtpHasta.TabIndex = 53;
            // 
            // cmbTipoVenta
            // 
            this.cmbTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVenta.FormattingEnabled = true;
            this.cmbTipoVenta.Location = new System.Drawing.Point(102, 69);
            this.cmbTipoVenta.Name = "cmbTipoVenta";
            this.cmbTipoVenta.Size = new System.Drawing.Size(158, 23);
            this.cmbTipoVenta.TabIndex = 48;
            this.cmbTipoVenta.DropDown += new System.EventHandler(this.cmbTipoVenta_DropDown);
            this.cmbTipoVenta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVenta_SelectedIndexChanged);
            // 
            // txtTotalTablaPendientes
            // 
            this.txtTotalTablaPendientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTablaPendientes.ForeColor = System.Drawing.Color.Black;
            this.txtTotalTablaPendientes.Location = new System.Drawing.Point(87, 21);
            this.txtTotalTablaPendientes.Name = "txtTotalTablaPendientes";
            this.txtTotalTablaPendientes.Size = new System.Drawing.Size(106, 25);
            this.txtTotalTablaPendientes.TabIndex = 50;
            this.txtTotalTablaPendientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalTablaPendientes.TextChanged += new System.EventHandler(this.txtTotalTablaPendientes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pendientes";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTotalTablaPendientes);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(320, 527);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 59);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total documentos abiertos";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTotalFilasAbonos);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtTotalFilasPendientes);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(537, 527);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(385, 59);
            this.groupBox5.TabIndex = 67;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total filas seleccionadas";
            // 
            // txtTotalFilasAbonos
            // 
            this.txtTotalFilasAbonos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFilasAbonos.ForeColor = System.Drawing.Color.Black;
            this.txtTotalFilasAbonos.Location = new System.Drawing.Point(258, 21);
            this.txtTotalFilasAbonos.Name = "txtTotalFilasAbonos";
            this.txtTotalFilasAbonos.Size = new System.Drawing.Size(106, 25);
            this.txtTotalFilasAbonos.TabIndex = 52;
            this.txtTotalFilasAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalFilasAbonos.TextChanged += new System.EventHandler(this.txtTotalFilasAbonos_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Abonos";
            // 
            // txtTotalFilasPendientes
            // 
            this.txtTotalFilasPendientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFilasPendientes.ForeColor = System.Drawing.Color.Black;
            this.txtTotalFilasPendientes.Location = new System.Drawing.Point(87, 21);
            this.txtTotalFilasPendientes.Name = "txtTotalFilasPendientes";
            this.txtTotalFilasPendientes.Size = new System.Drawing.Size(106, 25);
            this.txtTotalFilasPendientes.TabIndex = 50;
            this.txtTotalFilasPendientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalFilasPendientes.TextChanged += new System.EventHandler(this.txtTotalFilasPendientes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pendientes";
            // 
            // lblCantidadFilas
            // 
            this.lblCantidadFilas.AutoSize = true;
            this.lblCantidadFilas.Location = new System.Drawing.Point(12, 551);
            this.lblCantidadFilas.Name = "lblCantidadFilas";
            this.lblCantidadFilas.Size = new System.Drawing.Size(43, 15);
            this.lblCantidadFilas.TabIndex = 69;
            this.lblCantidadFilas.Text = " 0 filas.";
            // 
            // lblCantidadFilasSeleccionadas
            // 
            this.lblCantidadFilasSeleccionadas.AutoSize = true;
            this.lblCantidadFilasSeleccionadas.Location = new System.Drawing.Point(12, 571);
            this.lblCantidadFilasSeleccionadas.Name = "lblCantidadFilasSeleccionadas";
            this.lblCantidadFilasSeleccionadas.Size = new System.Drawing.Size(119, 15);
            this.lblCantidadFilasSeleccionadas.TabIndex = 70;
            this.lblCantidadFilasSeleccionadas.Text = " 0 filas seleccionadas.";
            // 
            // frmOP_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 613);
            this.Controls.Add(this.lblCantidadFilasSeleccionadas);
            this.Controls.Add(this.lblCantidadFilas);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chkSeleccionarTodosPago);
            this.Controls.Add(this.chkSoloAbiertos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCargarDocumentos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPago);
            this.Name = "frmOP_Pago";
            this.Text = "Asistente de pagos";
            this.Load += new System.EventHandler(this.frmOP_Pago_Load);
            this.Controls.SetChildIndex(this.dgvPago, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.btnCargarDocumentos, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.chkSoloAbiertos, 0);
            this.Controls.SetChildIndex(this.chkSeleccionarTodosPago, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.lblCantidadFilas, 0);
            this.Controls.SetChildIndex(this.lblCantidadFilasSeleccionadas, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionPago)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTotalTablaPendientes;
        private System.Windows.Forms.ComboBox cmbTipoVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPago;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkTodoCondicionPago;
        private System.Windows.Forms.DataGridView dgvCondicionPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbChofer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTodoSerie;
        private System.Windows.Forms.DataGridView dgvSerie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDO_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SER_serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn SER_correlativo_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn SER_correlativo_desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn SER_correlativo_hasta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPA_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPA_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPA_dias_limite_pago;
        private System.Windows.Forms.Button btnCargarDocumentos;
        private System.Windows.Forms.CheckBox chkSoloAbiertos;
        private System.Windows.Forms.CheckBox chkSeleccionarTodosPago;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTotalFilasAbonos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalFilasPendientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidadFilas;
        private System.Windows.Forms.Label lblCantidadFilasSeleccionadas;
        private System.Windows.Forms.Button btnGoChofer;
        private System.Windows.Forms.Button btnGoTipoVenta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkPago;
        private System.Windows.Forms.DataGridViewLinkColumn VTA_serie_correlativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOC_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOC_nombre_razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn VTA_fecha_vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn VTA_monto_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pendiente_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn VTA_estado;
        private System.Windows.Forms.DataGridViewComboBoxColumn MPA_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAG_referencia;
    }
}