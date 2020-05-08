namespace Presentacion
{
    partial class frmOP_ListaPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_ListaPrecios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.btnGoListaPrecios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PRO_codigo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PRO_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DLP_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.btnGoListaPrecios);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Controls.Add(this.txtFiltrar);
            this.gpbInformacion.Controls.Add(this.dgvListado);
            this.gpbInformacion.Controls.Add(this.cmbListaPrecio);
            this.gpbInformacion.Controls.Add(this.label3);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(6, 52);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(564, 507);
            this.gpbInformacion.TabIndex = 6;
            this.gpbInformacion.TabStop = false;
            // 
            // btnGoListaPrecios
            // 
            this.btnGoListaPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoListaPrecios.Image = ((System.Drawing.Image)(resources.GetObject("btnGoListaPrecios.Image")));
            this.btnGoListaPrecios.Location = new System.Drawing.Point(446, 26);
            this.btnGoListaPrecios.Name = "btnGoListaPrecios";
            this.btnGoListaPrecios.Size = new System.Drawing.Size(25, 25);
            this.btnGoListaPrecios.TabIndex = 76;
            this.btnGoListaPrecios.UseVisualStyleBackColor = true;
            this.btnGoListaPrecios.Click += new System.EventHandler(this.btnGoListaPrecios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Filtrar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFiltrar.Location = new System.Drawing.Point(67, 64);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListado.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_codigo,
            this.PRO_descripcion,
            this.DLP_precio});
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvListado.Location = new System.Drawing.Point(14, 91);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(536, 398);
            this.dgvListado.TabIndex = 49;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvListado_CurrentCellDirtyStateChanged);
            this.dgvListado.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvListado_RowPostPaint);
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(222, 26);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(222, 25);
            this.cmbListaPrecio.TabIndex = 48;
            this.cmbListaPrecio.DropDown += new System.EventHandler(this.cmbListaPrecio_DropDown);
            this.cmbListaPrecio.SelectedIndexChanged += new System.EventHandler(this.cmbListaPrecio_SelectedIndexChanged);
            this.cmbListaPrecio.SelectionChangeCommitted += new System.EventHandler(this.cmbListaPrecio_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista de precios";
            // 
            // PRO_codigo
            // 
            this.PRO_codigo.DataPropertyName = "PRO_codigo";
            this.PRO_codigo.HeaderText = "Código";
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
            this.PRO_descripcion.HeaderText = "Producto";
            this.PRO_descripcion.Name = "PRO_descripcion";
            this.PRO_descripcion.ReadOnly = true;
            // 
            // DLP_precio
            // 
            this.DLP_precio.DataPropertyName = "DLP_precio";
            this.DLP_precio.HeaderText = "Precio (S/.)";
            this.DLP_precio.Name = "DLP_precio";
            this.DLP_precio.Width = 96;
            // 
            // frmOP_ListaPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(577, 583);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmOP_ListaPrecios";
            this.Text = "Asignación de Lista de Precios";
            this.Load += new System.EventHandler(this.frmOP_AsignarListaPrecios_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ComboBox cmbListaPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btnGoListaPrecios;
        private System.Windows.Forms.DataGridViewLinkColumn PRO_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DLP_precio;
    }
}