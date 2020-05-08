namespace Presentacion
{
    partial class frmRPT_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRPT_Inventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picSum2 = new System.Windows.Forms.PictureBox();
            this.txtSumaGeneral = new System.Windows.Forms.TextBox();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeroFilas = new System.Windows.Forms.Label();
            this.menuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ocultarColumnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picSum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            this.menuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSum2
            // 
            this.picSum2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picSum2.BackColor = System.Drawing.Color.LightGreen;
            this.picSum2.Image = ((System.Drawing.Image)(resources.GetObject("picSum2.Image")));
            this.picSum2.Location = new System.Drawing.Point(791, 587);
            this.picSum2.Name = "picSum2";
            this.picSum2.Size = new System.Drawing.Size(16, 18);
            this.picSum2.TabIndex = 53;
            this.picSum2.TabStop = false;
            // 
            // txtSumaGeneral
            // 
            this.txtSumaGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumaGeneral.BackColor = System.Drawing.Color.LightGreen;
            this.txtSumaGeneral.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaGeneral.Location = new System.Drawing.Point(789, 581);
            this.txtSumaGeneral.Name = "txtSumaGeneral";
            this.txtSumaGeneral.Size = new System.Drawing.Size(135, 29);
            this.txtSumaGeneral.TabIndex = 52;
            this.txtSumaGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvStocks
            // 
            this.dgvStocks.AllowUserToAddRows = false;
            this.dgvStocks.AllowUserToDeleteRows = false;
            this.dgvStocks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStocks.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo});
            this.dgvStocks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvStocks.Location = new System.Drawing.Point(14, 89);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.ReadOnly = true;
            this.dgvStocks.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStocks.RowTemplate.Height = 19;
            this.dgvStocks.Size = new System.Drawing.Size(910, 487);
            this.dgvStocks.TabIndex = 51;
            this.dgvStocks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStocks_CellContentClick);
            this.dgvStocks.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStocks_CellMouseUp);
            this.dgvStocks.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStocks_DataBindingComplete);
            this.dgvStocks.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStocks_RowPostPaint);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 57;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Location = new System.Drawing.Point(700, 59);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(225, 23);
            this.txtFiltrar.TabIndex = 17;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Detalle de stocks";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Filtrar";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Total general";
            // 
            // lblNumeroFilas
            // 
            this.lblNumeroFilas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroFilas.AutoSize = true;
            this.lblNumeroFilas.Location = new System.Drawing.Point(17, 587);
            this.lblNumeroFilas.Name = "lblNumeroFilas";
            this.lblNumeroFilas.Size = new System.Drawing.Size(12, 17);
            this.lblNumeroFilas.TabIndex = 57;
            this.lblNumeroFilas.Text = " ";
            // 
            // menuContextual
            // 
            this.menuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocultarColumnaToolStripMenuItem});
            this.menuContextual.Name = "menuContextual";
            this.menuContextual.Size = new System.Drawing.Size(188, 26);
            // 
            // ocultarColumnaToolStripMenuItem
            // 
            this.ocultarColumnaToolStripMenuItem.Name = "ocultarColumnaToolStripMenuItem";
            this.ocultarColumnaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ocultarColumnaToolStripMenuItem.Text = "Ocultar esta columna";
            this.ocultarColumnaToolStripMenuItem.Click += new System.EventHandler(this.ocultarColumnaToolStripMenuItem_Click);
            // 
            // frmRPT_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 615);
            this.Controls.Add(this.lblNumeroFilas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picSum2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSumaGeneral);
            this.Controls.Add(this.dgvStocks);
            this.Controls.Add(this.txtFiltrar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRPT_Inventario";
            this.Text = "Reporte de Inventario de almacenes";
            this.Load += new System.EventHandler(this.frmRPT_Inventario_Load);
            this.Controls.SetChildIndex(this.txtFiltrar, 0);
            this.Controls.SetChildIndex(this.dgvStocks, 0);
            this.Controls.SetChildIndex(this.txtSumaGeneral, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.picSum2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblNumeroFilas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picSum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            this.menuContextual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.PictureBox picSum2;
        private System.Windows.Forms.TextBox txtSumaGeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeroFilas;
        private System.Windows.Forms.ContextMenuStrip menuContextual;
        private System.Windows.Forms.ToolStripMenuItem ocultarColumnaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewLinkColumn Codigo;
    }
}