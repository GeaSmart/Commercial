namespace Presentacion
{
    partial class _frmExportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmExportar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.strOperaciones = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnExportar = new System.Windows.Forms.ToolStripButton();
            this.dgvExportar = new System.Windows.Forms.DataGridView();
            this.strOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // strOperaciones
            // 
            this.strOperaciones.AutoSize = false;
            this.strOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.strOperaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.strOperaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btnExportar});
            this.strOperaciones.Location = new System.Drawing.Point(0, 0);
            this.strOperaciones.Name = "strOperaciones";
            this.strOperaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.strOperaciones.Size = new System.Drawing.Size(744, 54);
            this.strOperaciones.TabIndex = 12;
            this.strOperaciones.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(10, 51);
            this.toolStripLabel3.Text = " ";
            // 
            // btnExportar
            // 
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(54, 51);
            this.btnExportar.Text = "&Exportar";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvExportar
            // 
            this.dgvExportar.AllowUserToAddRows = false;
            this.dgvExportar.AllowUserToDeleteRows = false;
            this.dgvExportar.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            this.dgvExportar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExportar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvExportar.BackgroundColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExportar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExportar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExportar.EnableHeadersVisualStyles = false;
            this.dgvExportar.Location = new System.Drawing.Point(0, 57);
            this.dgvExportar.MultiSelect = false;
            this.dgvExportar.Name = "dgvExportar";
            this.dgvExportar.ReadOnly = true;
            this.dgvExportar.RowHeadersVisible = false;
            this.dgvExportar.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExportar.RowTemplate.Height = 18;
            this.dgvExportar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExportar.Size = new System.Drawing.Size(744, 498);
            this.dgvExportar.TabIndex = 13;
            // 
            // _frmExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 556);
            this.Controls.Add(this.dgvExportar);
            this.Controls.Add(this.strOperaciones);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "_frmExportar";
            this.ShowInTaskbar = false;
            this.Text = "Exportar datos maestros";
            this.Load += new System.EventHandler(this._frmExportar_Load);
            this.strOperaciones.ResumeLayout(false);
            this.strOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ToolStrip strOperaciones;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        protected System.Windows.Forms.ToolStripButton btnExportar;
        protected System.Windows.Forms.DataGridView dgvExportar;
    }
}