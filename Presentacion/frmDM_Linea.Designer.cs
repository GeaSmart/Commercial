namespace Presentacion
{
    partial class frmDM_Linea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_Linea));
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.btnGoCategoria = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).BeginInit();
            this.gpbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.btnGoCategoria);
            this.gpbInformacion.Controls.Add(this.cmbCategoria);
            this.gpbInformacion.Controls.Add(this.label2);
            this.gpbInformacion.Controls.Add(this.txtNombre);
            this.gpbInformacion.Controls.Add(this.label4);
            this.gpbInformacion.Controls.Add(this.txtCodigo);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(10, 53);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(565, 137);
            this.gpbInformacion.TabIndex = 8;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Informacion";
            // 
            // btnGoCategoria
            // 
            this.btnGoCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnGoCategoria.Image")));
            this.btnGoCategoria.Location = new System.Drawing.Point(456, 93);
            this.btnGoCategoria.Name = "btnGoCategoria";
            this.btnGoCategoria.Size = new System.Drawing.Size(25, 25);
            this.btnGoCategoria.TabIndex = 78;
            this.btnGoCategoria.UseVisualStyleBackColor = true;
            this.btnGoCategoria.Click += new System.EventHandler(this.btnGoCategoria_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(191, 93);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(249, 25);
            this.cmbCategoria.TabIndex = 31;
            this.cmbCategoria.Tag = "CAT_codigo";
            this.cmbCategoria.DropDown += new System.EventHandler(this.cmbCategoria_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Categoría";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(191, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 25);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.Tag = "LIN_nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(191, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(123, 25);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.Tag = "LIN_codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codigo";
            // 
            // frmDM_Linea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 215);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmDM_Linea";
            this.Text = "Linea";
            this.Load += new System.EventHandler(this.frmDM_Linea_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).EndInit();
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoCategoria;
    }
}