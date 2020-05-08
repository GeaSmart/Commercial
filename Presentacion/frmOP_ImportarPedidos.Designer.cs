namespace Presentacion
{
    partial class frmOP_ImportarPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_ImportarPedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkPrimeraFilaCab = new System.Windows.Forms.CheckBox();
            this.dgvCabecera = new System.Windows.Forms.DataGridView();
            this.Check1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_numero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_fecha_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEN_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_nombre_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOC_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_soc_nombre_razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_soc_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_soc_zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_porcentaje_igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_porcentaje_percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_monto_igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_monto_isc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_monto_percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_monto_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPA_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_tdo_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strOperaciones = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnAbrirCabecera = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnValidarCabecera = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtRutaCabecera = new System.Windows.Forms.ToolStripTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkPrimeraFilaDet = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAbrirDetalle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnValidarDetalle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtRutaDetalle = new System.Windows.Forms.ToolStripTextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Check2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED_numero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_is_bonificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_pro_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_cantidad_submultiplo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_monto_subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_monto_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_porcentaje_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_monto_igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_monto_isc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_porcentaje_isc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_monto_total_linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPE_memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportar = new System.Windows.Forms.Button();
            this.picEstadoValidacion = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDetalleErrores = new System.Windows.Forms.TextBox();
            this.txtCabeceraErrores = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDetalleFilas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCabeceraFilas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picEstadoResultados = new System.Windows.Forms.PictureBox();
            this.txtPedidosNoinsertados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPedidosInsertados = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabecera)).BeginInit();
            this.strOperaciones.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstadoValidacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstadoResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 396);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkPrimeraFilaCab);
            this.tabPage1.Controls.Add(this.dgvCabecera);
            this.tabPage1.Controls.Add(this.strOperaciones);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cabecera";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkPrimeraFilaCab
            // 
            this.chkPrimeraFilaCab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkPrimeraFilaCab.AutoSize = true;
            this.chkPrimeraFilaCab.Location = new System.Drawing.Point(8, 343);
            this.chkPrimeraFilaCab.Name = "chkPrimeraFilaCab";
            this.chkPrimeraFilaCab.Size = new System.Drawing.Size(402, 19);
            this.chkPrimeraFilaCab.TabIndex = 5;
            this.chkPrimeraFilaCab.Text = "La primera fila del archivo txt son encabezados o nombres de columnas";
            this.chkPrimeraFilaCab.UseVisualStyleBackColor = true;
            this.chkPrimeraFilaCab.CheckedChanged += new System.EventHandler(this.chkPrimeraFilaCab_CheckedChanged);
            // 
            // dgvCabecera
            // 
            this.dgvCabecera.AllowUserToAddRows = false;
            this.dgvCabecera.AllowUserToDeleteRows = false;
            this.dgvCabecera.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dgvCabecera.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCabecera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCabecera.BackgroundColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCabecera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabecera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check1,
            this.PED_numero1,
            this.PED_fecha,
            this.PED_fecha_entrega,
            this.VEN_codigo,
            this.PED_nombre_vendedor,
            this.SOC_codigo,
            this.PED_soc_nombre_razon,
            this.PED_soc_direccion,
            this.PED_soc_zona,
            this.PED_subtotal,
            this.PED_porcentaje_igv,
            this.PED_porcentaje_percepcion,
            this.PED_monto_igv,
            this.PED_monto_isc,
            this.PED_monto_percepcion,
            this.PED_monto_total,
            this.PED_comentario,
            this.PED_estado,
            this.CPA_codigo,
            this.PED_tdo_codigo});
            this.dgvCabecera.EnableHeadersVisualStyles = false;
            this.dgvCabecera.Location = new System.Drawing.Point(5, 59);
            this.dgvCabecera.Name = "dgvCabecera";
            this.dgvCabecera.Size = new System.Drawing.Size(762, 278);
            this.dgvCabecera.TabIndex = 4;
            this.dgvCabecera.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCabecera_DataBindingComplete);
            this.dgvCabecera.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCabecera_RowPostPaint);
            // 
            // Check1
            // 
            this.Check1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Check1.Frozen = true;
            this.Check1.HeaderText = "Check";
            this.Check1.Name = "Check1";
            this.Check1.ReadOnly = true;
            this.Check1.Width = 65;
            // 
            // PED_numero1
            // 
            this.PED_numero1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_numero1.DataPropertyName = "PED_numero";
            this.PED_numero1.HeaderText = "PED_numero";
            this.PED_numero1.Name = "PED_numero1";
            // 
            // PED_fecha
            // 
            this.PED_fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_fecha.DataPropertyName = "PED_fecha";
            this.PED_fecha.HeaderText = "PED_fecha";
            this.PED_fecha.Name = "PED_fecha";
            this.PED_fecha.Width = 87;
            // 
            // PED_fecha_entrega
            // 
            this.PED_fecha_entrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_fecha_entrega.DataPropertyName = "PED_fecha_entrega";
            this.PED_fecha_entrega.HeaderText = "PED_fecha_entrega";
            this.PED_fecha_entrega.Name = "PED_fecha_entrega";
            this.PED_fecha_entrega.Width = 132;
            // 
            // VEN_codigo
            // 
            this.VEN_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.VEN_codigo.DataPropertyName = "VEN_codigo";
            this.VEN_codigo.HeaderText = "VEN_codigo";
            this.VEN_codigo.Name = "VEN_codigo";
            this.VEN_codigo.Width = 96;
            // 
            // PED_nombre_vendedor
            // 
            this.PED_nombre_vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_nombre_vendedor.DataPropertyName = "PED_nombre_vendedor";
            this.PED_nombre_vendedor.HeaderText = "PED_nombre_vendedor";
            this.PED_nombre_vendedor.Name = "PED_nombre_vendedor";
            this.PED_nombre_vendedor.Width = 155;
            // 
            // SOC_codigo
            // 
            this.SOC_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SOC_codigo.DataPropertyName = "SOC_codigo";
            this.SOC_codigo.HeaderText = "SOC_codigo";
            this.SOC_codigo.Name = "SOC_codigo";
            this.SOC_codigo.Width = 97;
            // 
            // PED_soc_nombre_razon
            // 
            this.PED_soc_nombre_razon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PED_soc_nombre_razon.DataPropertyName = "PED_soc_nombre_razon";
            this.PED_soc_nombre_razon.HeaderText = "PED_soc_nombre_razon";
            this.PED_soc_nombre_razon.Name = "PED_soc_nombre_razon";
            this.PED_soc_nombre_razon.Width = 157;
            // 
            // PED_soc_direccion
            // 
            this.PED_soc_direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_soc_direccion.DataPropertyName = "PED_soc_direccion";
            this.PED_soc_direccion.HeaderText = "PED_soc_direccion";
            this.PED_soc_direccion.Name = "PED_soc_direccion";
            this.PED_soc_direccion.Width = 130;
            // 
            // PED_soc_zona
            // 
            this.PED_soc_zona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_soc_zona.DataPropertyName = "PED_soc_zona";
            this.PED_soc_zona.HeaderText = "PED_soc_zona";
            this.PED_soc_zona.Name = "PED_soc_zona";
            this.PED_soc_zona.Width = 106;
            // 
            // PED_subtotal
            // 
            this.PED_subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_subtotal.DataPropertyName = "PED_subtotal";
            this.PED_subtotal.HeaderText = "PED_subtotal";
            this.PED_subtotal.Name = "PED_subtotal";
            this.PED_subtotal.Width = 101;
            // 
            // PED_porcentaje_igv
            // 
            this.PED_porcentaje_igv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_porcentaje_igv.DataPropertyName = "PED_porcentaje_igv";
            this.PED_porcentaje_igv.HeaderText = "PED_porcentaje_igv";
            this.PED_porcentaje_igv.Name = "PED_porcentaje_igv";
            this.PED_porcentaje_igv.Width = 135;
            // 
            // PED_porcentaje_percepcion
            // 
            this.PED_porcentaje_percepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_porcentaje_percepcion.DataPropertyName = "PED_porcentaje_percepcion";
            this.PED_porcentaje_percepcion.HeaderText = "PED_porcentaje_percepcion";
            this.PED_porcentaje_percepcion.Name = "PED_porcentaje_percepcion";
            this.PED_porcentaje_percepcion.Width = 178;
            // 
            // PED_monto_igv
            // 
            this.PED_monto_igv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_monto_igv.DataPropertyName = "PED_monto_igv";
            this.PED_monto_igv.HeaderText = "PED_monto_igv";
            this.PED_monto_igv.Name = "PED_monto_igv";
            this.PED_monto_igv.Width = 115;
            // 
            // PED_monto_isc
            // 
            this.PED_monto_isc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_monto_isc.DataPropertyName = "PED_monto_isc";
            this.PED_monto_isc.HeaderText = "PED_monto_isc";
            this.PED_monto_isc.Name = "PED_monto_isc";
            this.PED_monto_isc.Width = 113;
            // 
            // PED_monto_percepcion
            // 
            this.PED_monto_percepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_monto_percepcion.DataPropertyName = "PED_monto_percepcion";
            this.PED_monto_percepcion.HeaderText = "PED_monto_percepcion";
            this.PED_monto_percepcion.Name = "PED_monto_percepcion";
            this.PED_monto_percepcion.Width = 158;
            // 
            // PED_monto_total
            // 
            this.PED_monto_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_monto_total.DataPropertyName = "PED_monto_total";
            this.PED_monto_total.HeaderText = "PED_monto_total";
            this.PED_monto_total.Name = "PED_monto_total";
            this.PED_monto_total.Width = 123;
            // 
            // PED_comentario
            // 
            this.PED_comentario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_comentario.DataPropertyName = "PED_comentario";
            this.PED_comentario.HeaderText = "PED_comentario";
            this.PED_comentario.Name = "PED_comentario";
            this.PED_comentario.Width = 119;
            // 
            // PED_estado
            // 
            this.PED_estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_estado.DataPropertyName = "PED_estado";
            this.PED_estado.HeaderText = "PED_estado";
            this.PED_estado.Name = "PED_estado";
            this.PED_estado.Width = 93;
            // 
            // CPA_codigo
            // 
            this.CPA_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CPA_codigo.DataPropertyName = "CPA_codigo";
            this.CPA_codigo.HeaderText = "CPA_codigo";
            this.CPA_codigo.Name = "CPA_codigo";
            this.CPA_codigo.Width = 96;
            // 
            // PED_tdo_codigo
            // 
            this.PED_tdo_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_tdo_codigo.DataPropertyName = "PED_tdo_codigo";
            this.PED_tdo_codigo.HeaderText = "PED_tdo_codigo";
            this.PED_tdo_codigo.Name = "PED_tdo_codigo";
            this.PED_tdo_codigo.Width = 118;
            // 
            // strOperaciones
            // 
            this.strOperaciones.BackColor = System.Drawing.Color.LightGreen;
            this.strOperaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.strOperaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btnAbrirCabecera,
            this.toolStripSeparator2,
            this.btnValidarCabecera,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.txtRutaCabecera});
            this.strOperaciones.Location = new System.Drawing.Point(3, 3);
            this.strOperaciones.Name = "strOperaciones";
            this.strOperaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.strOperaciones.Size = new System.Drawing.Size(766, 54);
            this.strOperaciones.TabIndex = 1;
            this.strOperaciones.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(10, 51);
            this.toolStripLabel3.Text = " ";
            // 
            // btnAbrirCabecera
            // 
            this.btnAbrirCabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbrirCabecera.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirCabecera.Image")));
            this.btnAbrirCabecera.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbrirCabecera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrirCabecera.Name = "btnAbrirCabecera";
            this.btnAbrirCabecera.Size = new System.Drawing.Size(79, 51);
            this.btnAbrirCabecera.Text = "&Abrir archivo";
            this.btnAbrirCabecera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirCabecera.Click += new System.EventHandler(this.btnAbrirCabecera_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // btnValidarCabecera
            // 
            this.btnValidarCabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnValidarCabecera.Image = ((System.Drawing.Image)(resources.GetObject("btnValidarCabecera.Image")));
            this.btnValidarCabecera.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnValidarCabecera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnValidarCabecera.Name = "btnValidarCabecera";
            this.btnValidarCabecera.Size = new System.Drawing.Size(46, 51);
            this.btnValidarCabecera.Text = "&Validar";
            this.btnValidarCabecera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnValidarCabecera.Click += new System.EventHandler(this.btnValidarCabecera_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(92, 51);
            this.toolStripLabel2.Text = "Ruta de archivo:";
            // 
            // txtRutaCabecera
            // 
            this.txtRutaCabecera.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRutaCabecera.Name = "txtRutaCabecera";
            this.txtRutaCabecera.ReadOnly = true;
            this.txtRutaCabecera.Size = new System.Drawing.Size(450, 54);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkPrimeraFilaDet);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.dgvDetalle);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkPrimeraFilaDet
            // 
            this.chkPrimeraFilaDet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkPrimeraFilaDet.AutoSize = true;
            this.chkPrimeraFilaDet.Location = new System.Drawing.Point(8, 343);
            this.chkPrimeraFilaDet.Name = "chkPrimeraFilaDet";
            this.chkPrimeraFilaDet.Size = new System.Drawing.Size(402, 19);
            this.chkPrimeraFilaDet.TabIndex = 6;
            this.chkPrimeraFilaDet.Text = "La primera fila del archivo txt son encabezados o nombres de columnas";
            this.chkPrimeraFilaDet.UseVisualStyleBackColor = true;
            this.chkPrimeraFilaDet.CheckedChanged += new System.EventHandler(this.chkPrimeraFilaDet_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnAbrirDetalle,
            this.toolStripSeparator1,
            this.btnValidarDetalle,
            this.toolStripSeparator4,
            this.toolStripLabel4,
            this.txtRutaDetalle});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(766, 54);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(10, 51);
            this.toolStripLabel1.Text = " ";
            // 
            // btnAbrirDetalle
            // 
            this.btnAbrirDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbrirDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirDetalle.Image")));
            this.btnAbrirDetalle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbrirDetalle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrirDetalle.Name = "btnAbrirDetalle";
            this.btnAbrirDetalle.Size = new System.Drawing.Size(79, 51);
            this.btnAbrirDetalle.Text = "&Abrir archivo";
            this.btnAbrirDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirDetalle.Click += new System.EventHandler(this.btnAbrirDetalle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnValidarDetalle
            // 
            this.btnValidarDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnValidarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnValidarDetalle.Image")));
            this.btnValidarDetalle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnValidarDetalle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnValidarDetalle.Name = "btnValidarDetalle";
            this.btnValidarDetalle.Size = new System.Drawing.Size(46, 51);
            this.btnValidarDetalle.Text = "&Validar";
            this.btnValidarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnValidarDetalle.Click += new System.EventHandler(this.btnValidarDetalle_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(92, 51);
            this.toolStripLabel4.Text = "Ruta de archivo:";
            // 
            // txtRutaDetalle
            // 
            this.txtRutaDetalle.Name = "txtRutaDetalle";
            this.txtRutaDetalle.ReadOnly = true;
            this.txtRutaDetalle.Size = new System.Drawing.Size(450, 54);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Honeydew;
            this.dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check2,
            this.PED_numero2,
            this.PRO_codigo,
            this.DPE_is_bonificacion,
            this.DPE_pro_descripcion,
            this.DPE_cantidad,
            this.DPE_cantidad_submultiplo,
            this.DPE_precio_unitario,
            this.DPE_monto_subtotal,
            this.DPE_monto_descuento,
            this.DPE_porcentaje_descuento,
            this.DPE_monto_igv,
            this.DPE_monto_isc,
            this.DPE_porcentaje_isc,
            this.DPE_monto_total_linea,
            this.DPE_memo});
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.Location = new System.Drawing.Point(5, 59);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(762, 278);
            this.dgvDetalle.TabIndex = 3;
            this.dgvDetalle.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDetalle_DataBindingComplete);
            this.dgvDetalle.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDetalle_RowPostPaint);
            // 
            // Check2
            // 
            this.Check2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Check2.Frozen = true;
            this.Check2.HeaderText = "Check";
            this.Check2.Name = "Check2";
            this.Check2.Width = 65;
            // 
            // PED_numero2
            // 
            this.PED_numero2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PED_numero2.DataPropertyName = "PED_numero";
            this.PED_numero2.HeaderText = "PED_numero";
            this.PED_numero2.Name = "PED_numero2";
            // 
            // PRO_codigo
            // 
            this.PRO_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PRO_codigo.DataPropertyName = "PRO_codigo";
            this.PRO_codigo.HeaderText = "PRO_codigo";
            this.PRO_codigo.Name = "PRO_codigo";
            this.PRO_codigo.Width = 97;
            // 
            // DPE_is_bonificacion
            // 
            this.DPE_is_bonificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_is_bonificacion.DataPropertyName = "DPE_is_bonificacion";
            this.DPE_is_bonificacion.HeaderText = "DPE_is_bonificacion";
            this.DPE_is_bonificacion.Name = "DPE_is_bonificacion";
            this.DPE_is_bonificacion.Width = 137;
            // 
            // DPE_pro_descripcion
            // 
            this.DPE_pro_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_pro_descripcion.DataPropertyName = "DPE_pro_descripcion";
            this.DPE_pro_descripcion.HeaderText = "DPE_pro_descripcion";
            this.DPE_pro_descripcion.Name = "DPE_pro_descripcion";
            this.DPE_pro_descripcion.Width = 142;
            // 
            // DPE_cantidad
            // 
            this.DPE_cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_cantidad.DataPropertyName = "DPE_cantidad";
            this.DPE_cantidad.HeaderText = "DPE_cantidad";
            this.DPE_cantidad.Name = "DPE_cantidad";
            this.DPE_cantidad.Width = 104;
            // 
            // DPE_cantidad_submultiplo
            // 
            this.DPE_cantidad_submultiplo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_cantidad_submultiplo.DataPropertyName = "DPE_cantidad_submultiplo";
            this.DPE_cantidad_submultiplo.HeaderText = "DPE_cantidad_submultiplo";
            this.DPE_cantidad_submultiplo.Name = "DPE_cantidad_submultiplo";
            this.DPE_cantidad_submultiplo.Width = 173;
            // 
            // DPE_precio_unitario
            // 
            this.DPE_precio_unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_precio_unitario.DataPropertyName = "DPE_precio_unitario";
            this.DPE_precio_unitario.HeaderText = "DPE_precio_unitario";
            this.DPE_precio_unitario.Name = "DPE_precio_unitario";
            this.DPE_precio_unitario.Width = 137;
            // 
            // DPE_monto_subtotal
            // 
            this.DPE_monto_subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_monto_subtotal.DataPropertyName = "DPE_monto_subtotal";
            this.DPE_monto_subtotal.HeaderText = "DPE_monto_subtotal";
            this.DPE_monto_subtotal.Name = "DPE_monto_subtotal";
            this.DPE_monto_subtotal.Width = 142;
            // 
            // DPE_monto_descuento
            // 
            this.DPE_monto_descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_monto_descuento.DataPropertyName = "DPE_monto_descuento";
            this.DPE_monto_descuento.HeaderText = "DPE_monto_descuento";
            this.DPE_monto_descuento.Name = "DPE_monto_descuento";
            this.DPE_monto_descuento.Width = 154;
            // 
            // DPE_porcentaje_descuento
            // 
            this.DPE_porcentaje_descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_porcentaje_descuento.DataPropertyName = "DPE_porcentaje_descuento";
            this.DPE_porcentaje_descuento.HeaderText = "DPE_porcentaje_descuento";
            this.DPE_porcentaje_descuento.Name = "DPE_porcentaje_descuento";
            this.DPE_porcentaje_descuento.Width = 174;
            // 
            // DPE_monto_igv
            // 
            this.DPE_monto_igv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_monto_igv.DataPropertyName = "DPE_monto_igv";
            this.DPE_monto_igv.HeaderText = "DPE_monto_igv";
            this.DPE_monto_igv.Name = "DPE_monto_igv";
            this.DPE_monto_igv.Width = 115;
            // 
            // DPE_monto_isc
            // 
            this.DPE_monto_isc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_monto_isc.DataPropertyName = "DPE_monto_isc";
            this.DPE_monto_isc.HeaderText = "DPE_monto_isc";
            this.DPE_monto_isc.Name = "DPE_monto_isc";
            this.DPE_monto_isc.Width = 113;
            // 
            // DPE_porcentaje_isc
            // 
            this.DPE_porcentaje_isc.DataPropertyName = "DPE_porcentaje_isc";
            this.DPE_porcentaje_isc.HeaderText = "DPE_porcentaje_isc";
            this.DPE_porcentaje_isc.Name = "DPE_porcentaje_isc";
            // 
            // DPE_monto_total_linea
            // 
            this.DPE_monto_total_linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_monto_total_linea.DataPropertyName = "DPE_monto_total_linea";
            this.DPE_monto_total_linea.HeaderText = "DPE_monto_total_linea";
            this.DPE_monto_total_linea.Name = "DPE_monto_total_linea";
            this.DPE_monto_total_linea.Width = 153;
            // 
            // DPE_memo
            // 
            this.DPE_memo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DPE_memo.DataPropertyName = "DPE_memo";
            this.DPE_memo.HeaderText = "DPE_memo";
            this.DPE_memo.Name = "DPE_memo";
            this.DPE_memo.Width = 93;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.Location = new System.Drawing.Point(683, 415);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(76, 70);
            this.btnImportar.TabIndex = 4;
            this.btnImportar.Text = "Importar";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // picEstadoValidacion
            // 
            this.picEstadoValidacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picEstadoValidacion.Location = new System.Drawing.Point(216, 35);
            this.picEstadoValidacion.Name = "picEstadoValidacion";
            this.picEstadoValidacion.Size = new System.Drawing.Size(32, 32);
            this.picEstadoValidacion.TabIndex = 6;
            this.picEstadoValidacion.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDetalleErrores);
            this.groupBox1.Controls.Add(this.txtCabeceraErrores);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDetalleFilas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCabeceraFilas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picEstadoValidacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(145, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Incidentes";
            // 
            // txtDetalleErrores
            // 
            this.txtDetalleErrores.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDetalleErrores.Location = new System.Drawing.Point(149, 57);
            this.txtDetalleErrores.Name = "txtDetalleErrores";
            this.txtDetalleErrores.ReadOnly = true;
            this.txtDetalleErrores.Size = new System.Drawing.Size(50, 23);
            this.txtDetalleErrores.TabIndex = 13;
            this.txtDetalleErrores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDetalleErrores.TextChanged += new System.EventHandler(this.txtDetalleErrores_TextChanged);
            // 
            // txtCabeceraErrores
            // 
            this.txtCabeceraErrores.ForeColor = System.Drawing.Color.DarkRed;
            this.txtCabeceraErrores.Location = new System.Drawing.Point(149, 31);
            this.txtCabeceraErrores.Name = "txtCabeceraErrores";
            this.txtCabeceraErrores.ReadOnly = true;
            this.txtCabeceraErrores.Size = new System.Drawing.Size(50, 23);
            this.txtCabeceraErrores.TabIndex = 12;
            this.txtCabeceraErrores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCabeceraErrores.TextChanged += new System.EventHandler(this.txtCabeceraErrores_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(104, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filas";
            // 
            // txtDetalleFilas
            // 
            this.txtDetalleFilas.Location = new System.Drawing.Point(92, 57);
            this.txtDetalleFilas.Name = "txtDetalleFilas";
            this.txtDetalleFilas.ReadOnly = true;
            this.txtDetalleFilas.Size = new System.Drawing.Size(55, 23);
            this.txtDetalleFilas.TabIndex = 10;
            this.txtDetalleFilas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDetalleFilas.TextChanged += new System.EventHandler(this.txtDetalleFilas_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Detalle:";
            // 
            // txtCabeceraFilas
            // 
            this.txtCabeceraFilas.Location = new System.Drawing.Point(92, 31);
            this.txtCabeceraFilas.Name = "txtCabeceraFilas";
            this.txtCabeceraFilas.ReadOnly = true;
            this.txtCabeceraFilas.Size = new System.Drawing.Size(55, 23);
            this.txtCabeceraFilas.TabIndex = 8;
            this.txtCabeceraFilas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCabeceraFilas.TextChanged += new System.EventHandler(this.txtCabeceraFilas_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cabecera:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.picEstadoResultados);
            this.groupBox2.Controls.Add(this.txtPedidosNoinsertados);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPedidosInsertados);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(278, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 92);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // picEstadoResultados
            // 
            this.picEstadoResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picEstadoResultados.Location = new System.Drawing.Point(214, 35);
            this.picEstadoResultados.Name = "picEstadoResultados";
            this.picEstadoResultados.Size = new System.Drawing.Size(32, 32);
            this.picEstadoResultados.TabIndex = 15;
            this.picEstadoResultados.TabStop = false;
            // 
            // txtPedidosNoinsertados
            // 
            this.txtPedidosNoinsertados.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPedidosNoinsertados.Location = new System.Drawing.Point(146, 53);
            this.txtPedidosNoinsertados.Name = "txtPedidosNoinsertados";
            this.txtPedidosNoinsertados.ReadOnly = true;
            this.txtPedidosNoinsertados.Size = new System.Drawing.Size(59, 23);
            this.txtPedidosNoinsertados.TabIndex = 10;
            this.txtPedidosNoinsertados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPedidosNoinsertados.TextChanged += new System.EventHandler(this.txtPedidosNoinsertados_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pedidos no insertados:";
            // 
            // txtPedidosInsertados
            // 
            this.txtPedidosInsertados.Location = new System.Drawing.Point(146, 27);
            this.txtPedidosInsertados.Name = "txtPedidosInsertados";
            this.txtPedidosInsertados.ReadOnly = true;
            this.txtPedidosInsertados.Size = new System.Drawing.Size(59, 23);
            this.txtPedidosInsertados.TabIndex = 8;
            this.txtPedidosInsertados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPedidosInsertados.TextChanged += new System.EventHandler(this.txtPedidosInsertados_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pedidos insertados:";
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "Error");
            this.img.Images.SetKeyName(1, "ok");
            this.img.Images.SetKeyName(2, "Warn");
            // 
            // frmOP_ImportarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmOP_ImportarPedidos";
            this.Text = "Importar pedidos";
            this.Load += new System.EventHandler(this.frmOP_ImportarPedidos_Load);
            this.VisibleChanged += new System.EventHandler(this.frmOP_ImportarPedidos_VisibleChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabecera)).EndInit();
            this.strOperaciones.ResumeLayout(false);
            this.strOperaciones.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstadoValidacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstadoResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        protected System.Windows.Forms.ToolStrip strOperaciones;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        protected System.Windows.Forms.ToolStripButton btnAbrirCabecera;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripButton btnValidarCabecera;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridView dgvCabecera;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtRutaCabecera;
        protected System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        protected System.Windows.Forms.ToolStripButton btnAbrirDetalle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton btnValidarDetalle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtRutaDetalle;
        private System.Windows.Forms.PictureBox picEstadoValidacion;
        private System.Windows.Forms.CheckBox chkPrimeraFilaCab;
        private System.Windows.Forms.CheckBox chkPrimeraFilaDet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDetalleFilas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCabeceraFilas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPedidosNoinsertados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPedidosInsertados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDetalleErrores;
        private System.Windows.Forms.TextBox txtCabeceraErrores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picEstadoResultados;
        private System.Windows.Forms.ImageList img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_numero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_fecha_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEN_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_nombre_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOC_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_soc_nombre_razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_soc_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_soc_zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_porcentaje_igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_porcentaje_percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_monto_igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_monto_isc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_monto_percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_monto_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPA_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_tdo_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_numero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_is_bonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_pro_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_cantidad_submultiplo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_monto_subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_monto_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_porcentaje_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_monto_igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_monto_isc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_porcentaje_isc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_monto_total_linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPE_memo;
    }
}