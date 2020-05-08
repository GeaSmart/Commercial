namespace Presentacion
{
    partial class frmDM_ListaPrecio
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
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnotaciones = new System.Windows.Forms.TextBox();
            this.chkIsActivo = new System.Windows.Forms.CheckBox();
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
            this.gpbInformacion.Controls.Add(this.label2);
            this.gpbInformacion.Controls.Add(this.txtAnotaciones);
            this.gpbInformacion.Controls.Add(this.chkIsActivo);
            this.gpbInformacion.Controls.Add(this.txtNombre);
            this.gpbInformacion.Controls.Add(this.label4);
            this.gpbInformacion.Controls.Add(this.txtCodigo);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(10, 53);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(565, 222);
            this.gpbInformacion.TabIndex = 11;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Informacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Anotaciones";
            // 
            // txtAnotaciones
            // 
            this.txtAnotaciones.Location = new System.Drawing.Point(191, 93);
            this.txtAnotaciones.Multiline = true;
            this.txtAnotaciones.Name = "txtAnotaciones";
            this.txtAnotaciones.Size = new System.Drawing.Size(249, 90);
            this.txtAnotaciones.TabIndex = 31;
            this.txtAnotaciones.Tag = "LPR_anotaciones";
            // 
            // chkIsActivo
            // 
            this.chkIsActivo.AutoSize = true;
            this.chkIsActivo.Location = new System.Drawing.Point(191, 189);
            this.chkIsActivo.Name = "chkIsActivo";
            this.chkIsActivo.Size = new System.Drawing.Size(89, 21);
            this.chkIsActivo.TabIndex = 30;
            this.chkIsActivo.Text = "Está activo";
            this.chkIsActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(191, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 25);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.Tag = "LPR_nombre";
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
            this.txtCodigo.Tag = "LPR_codigo";
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
            // frmDM_ListaPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 300);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmDM_ListaPrecio";
            this.Text = "Listas de Precio";
            this.Load += new System.EventHandler(this.frmDM_ListaPrecio_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).EndInit();
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.TextBox txtAnotaciones;
        private System.Windows.Forms.CheckBox chkIsActivo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}