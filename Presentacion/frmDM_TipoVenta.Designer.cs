﻿namespace Presentacion
{
    partial class frmDM_TipoVenta
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).BeginInit();
            this.gpbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.txtDescripcion);
            this.gpbInformacion.Controls.Add(this.txtCodigo);
            this.gpbInformacion.Controls.Add(this.label2);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(10, 53);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(565, 138);
            this.gpbInformacion.TabIndex = 4;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Informacion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 75);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(330, 25);
            this.txtDescripcion.TabIndex = 18;
            this.txtDescripcion.Tag = "TVE_descripcion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(147, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(156, 25);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.Tag = "TVE_codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codigo";
            // 
            // frmDM_TipoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 217);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmDM_TipoVenta";
            this.Text = "Tipo Venta";
            this.Load += new System.EventHandler(this.frmDM_TipoVenta_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).EndInit();
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}