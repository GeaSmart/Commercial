﻿namespace Presentacion
{
    partial class frmDM_Marca
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
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.txtNombre);
            this.gpbInformacion.Controls.Add(this.label4);
            this.gpbInformacion.Controls.Add(this.txtCodigo);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(10, 53);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(565, 107);
            this.gpbInformacion.TabIndex = 9;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Informacion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(191, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 25);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.Tag = "MAR_nombre";
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
            this.txtCodigo.Tag = "MAR_codigo";
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
            // errMensaje
            // 
            this.errMensaje.ContainerControl = this;
            // 
            // frmDM_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 186);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmDM_Marca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.frmDM_Marca_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errMensaje;
    }
}