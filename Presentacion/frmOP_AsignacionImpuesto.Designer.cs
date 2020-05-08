namespace Presentacion
{
    partial class frmOP_AsignacionImpuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_AsignacionImpuesto));
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.IMP_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIM_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIM_porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGoImpuesto = new System.Windows.Forms.Button();
            this.cmbImpuesto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.menuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.menuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.dgvListado);
            this.gpbInformacion.Controls.Add(this.btnGoImpuesto);
            this.gpbInformacion.Controls.Add(this.cmbImpuesto);
            this.gpbInformacion.Controls.Add(this.label3);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(7, 54);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(391, 270);
            this.gpbInformacion.TabIndex = 6;
            this.gpbInformacion.TabStop = false;
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToResizeRows = false;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListado.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMP_codigo,
            this.DIM_numero,
            this.DIM_porcentaje});
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvListado.EnableHeadersVisualStyles = false;
            this.dgvListado.Location = new System.Drawing.Point(128, 57);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListado.RowTemplate.Height = 19;
            this.dgvListado.Size = new System.Drawing.Size(171, 197);
            this.dgvListado.TabIndex = 99;
            this.dgvListado.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListado_CellMouseUp);
            this.dgvListado.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvListado_CurrentCellDirtyStateChanged);
            this.dgvListado.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvListado_DataError);
            this.dgvListado.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvListado_EditingControlShowing);
            // 
            // IMP_codigo
            // 
            this.IMP_codigo.DataPropertyName = "IMP_codigo";
            this.IMP_codigo.HeaderText = "IMP_codigo";
            this.IMP_codigo.Name = "IMP_codigo";
            this.IMP_codigo.Visible = false;
            this.IMP_codigo.Width = 101;
            // 
            // DIM_numero
            // 
            this.DIM_numero.DataPropertyName = "DIM_numero";
            this.DIM_numero.HeaderText = "DIM_numero";
            this.DIM_numero.Name = "DIM_numero";
            this.DIM_numero.Visible = false;
            this.DIM_numero.Width = 107;
            // 
            // DIM_porcentaje
            // 
            this.DIM_porcentaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIM_porcentaje.DataPropertyName = "DIM_porcentaje";
            this.DIM_porcentaje.HeaderText = "Porcentaje";
            this.DIM_porcentaje.Name = "DIM_porcentaje";
            // 
            // btnGoImpuesto
            // 
            this.btnGoImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoImpuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnGoImpuesto.Image")));
            this.btnGoImpuesto.Location = new System.Drawing.Point(301, 26);
            this.btnGoImpuesto.Name = "btnGoImpuesto";
            this.btnGoImpuesto.Size = new System.Drawing.Size(25, 25);
            this.btnGoImpuesto.TabIndex = 98;
            this.btnGoImpuesto.UseVisualStyleBackColor = true;
            this.btnGoImpuesto.Click += new System.EventHandler(this.btnGoImpuesto_Click);
            // 
            // cmbImpuesto
            // 
            this.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpuesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImpuesto.FormattingEnabled = true;
            this.cmbImpuesto.Location = new System.Drawing.Point(128, 26);
            this.cmbImpuesto.Name = "cmbImpuesto";
            this.cmbImpuesto.Size = new System.Drawing.Size(171, 23);
            this.cmbImpuesto.TabIndex = 48;
            this.cmbImpuesto.DropDown += new System.EventHandler(this.cmbImpuesto_DropDown);
            this.cmbImpuesto.SelectedIndexChanged += new System.EventHandler(this.cmbImpuesto_SelectedIndexChanged);
            this.cmbImpuesto.SelectionChangeCommitted += new System.EventHandler(this.cmbImpuesto_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Impuesto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 51);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // frmOP_AsignacionImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(404, 353);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmOP_AsignacionImpuesto";
            this.Text = "Asignación de Impuestos";
            this.Load += new System.EventHandler(this.frmOP_AsignacionImpuesto_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.menuContextual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbImpuesto;
        protected System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Button btnGoImpuesto;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMP_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIM_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIM_porcentaje;
        private System.Windows.Forms.ContextMenuStrip menuContextual;
        private System.Windows.Forms.ToolStripMenuItem eliminarFilaToolStripMenuItem;
    }
}