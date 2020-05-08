namespace Presentacion
{
    partial class frmDM_Serie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_Serie));
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.btnGoTipoDocumento = new System.Windows.Forms.Button();
            this.txtCorrelativoActual = new System.Windows.Forms.TextBox();
            this.nudCorrelativoHasta = new System.Windows.Forms.NumericUpDown();
            this.nudCorrelativoDesde = new System.Windows.Forms.NumericUpDown();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).BeginInit();
            this.gpbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrelativoHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrelativoDesde)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.btnGoTipoDocumento);
            this.gpbInformacion.Controls.Add(this.txtCorrelativoActual);
            this.gpbInformacion.Controls.Add(this.nudCorrelativoHasta);
            this.gpbInformacion.Controls.Add(this.nudCorrelativoDesde);
            this.gpbInformacion.Controls.Add(this.cmbTipoDocumento);
            this.gpbInformacion.Controls.Add(this.label6);
            this.gpbInformacion.Controls.Add(this.label4);
            this.gpbInformacion.Controls.Add(this.txtSerie);
            this.gpbInformacion.Controls.Add(this.label3);
            this.gpbInformacion.Controls.Add(this.label2);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(12, 53);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(565, 194);
            this.gpbInformacion.TabIndex = 3;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Informacion";
            // 
            // btnGoTipoDocumento
            // 
            this.btnGoTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTipoDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnGoTipoDocumento.Image")));
            this.btnGoTipoDocumento.Location = new System.Drawing.Point(425, 62);
            this.btnGoTipoDocumento.Name = "btnGoTipoDocumento";
            this.btnGoTipoDocumento.Size = new System.Drawing.Size(25, 25);
            this.btnGoTipoDocumento.TabIndex = 74;
            this.btnGoTipoDocumento.UseVisualStyleBackColor = true;
            this.btnGoTipoDocumento.Click += new System.EventHandler(this.btnGoTipoDocumento_Click);
            // 
            // txtCorrelativoActual
            // 
            this.txtCorrelativoActual.Location = new System.Drawing.Point(267, 154);
            this.txtCorrelativoActual.Name = "txtCorrelativoActual";
            this.txtCorrelativoActual.Size = new System.Drawing.Size(123, 25);
            this.txtCorrelativoActual.TabIndex = 29;
            this.txtCorrelativoActual.Tag = "SER_correlativo_actual";
            // 
            // nudCorrelativoHasta
            // 
            this.nudCorrelativoHasta.Location = new System.Drawing.Point(267, 124);
            this.nudCorrelativoHasta.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudCorrelativoHasta.Name = "nudCorrelativoHasta";
            this.nudCorrelativoHasta.Size = new System.Drawing.Size(102, 25);
            this.nudCorrelativoHasta.TabIndex = 28;
            this.nudCorrelativoHasta.Tag = "SER_correlativo_hasta";
            // 
            // nudCorrelativoDesde
            // 
            this.nudCorrelativoDesde.Location = new System.Drawing.Point(267, 93);
            this.nudCorrelativoDesde.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudCorrelativoDesde.Name = "nudCorrelativoDesde";
            this.nudCorrelativoDesde.Size = new System.Drawing.Size(102, 25);
            this.nudCorrelativoDesde.TabIndex = 27;
            this.nudCorrelativoDesde.Tag = "SER_correlativo_desde";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "ADM",
            "FAC"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(267, 62);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(156, 25);
            this.cmbTipoDocumento.TabIndex = 26;
            this.cmbTipoDocumento.Tag = "TDO_codigo";
            this.cmbTipoDocumento.DropDown += new System.EventHandler(this.cmbTipoDocumento_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tipo de documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Correlativo actual";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(267, 31);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(80, 25);
            this.txtSerie.TabIndex = 17;
            this.txtSerie.Tag = "SER_serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Correlativo final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Correlativo inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Serie";
            // 
            // frmDM_Serie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 271);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmDM_Serie";
            this.Text = "Serie";
            this.Load += new System.EventHandler(this.frmDM_Serie_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).EndInit();
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrelativoHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrelativoDesde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.NumericUpDown nudCorrelativoHasta;
        private System.Windows.Forms.NumericUpDown nudCorrelativoDesde;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorrelativoActual;
        private System.Windows.Forms.Button btnGoTipoDocumento;
    }
}