namespace Presentacion
{
    partial class frmDM_Chofer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_Chofer));
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.btnGoVehiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).BeginInit();
            this.gpbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.btnGoVehiculo);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Controls.Add(this.cmbVehiculo);
            this.gpbInformacion.Controls.Add(this.txtLicencia);
            this.gpbInformacion.Controls.Add(this.label5);
            this.gpbInformacion.Controls.Add(this.txtDNI);
            this.gpbInformacion.Controls.Add(this.txtNombreCompleto);
            this.gpbInformacion.Controls.Add(this.txtCodigo);
            this.gpbInformacion.Controls.Add(this.label3);
            this.gpbInformacion.Controls.Add(this.label2);
            this.gpbInformacion.Controls.Add(this.Codigo);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(12, 53);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(565, 198);
            this.gpbInformacion.TabIndex = 3;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Informacion";
            // 
            // btnGoVehiculo
            // 
            this.btnGoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnGoVehiculo.Image")));
            this.btnGoVehiculo.Location = new System.Drawing.Point(435, 121);
            this.btnGoVehiculo.Name = "btnGoVehiculo";
            this.btnGoVehiculo.Size = new System.Drawing.Size(25, 25);
            this.btnGoVehiculo.TabIndex = 77;
            this.btnGoVehiculo.UseVisualStyleBackColor = true;
            this.btnGoVehiculo.Click += new System.EventHandler(this.btnGoVehiculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Vehiculo";
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(187, 121);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(246, 25);
            this.cmbVehiculo.TabIndex = 24;
            this.cmbVehiculo.Tag = "VEH_placa";
            this.cmbVehiculo.DropDown += new System.EventHandler(this.cmbVehiculo_DropDown);
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(187, 152);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(156, 25);
            this.txtLicencia.TabIndex = 23;
            this.txtLicencia.Tag = "CHO_licencia_conducir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Licencia para conducir";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(187, 90);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(96, 25);
            this.txtDNI.TabIndex = 19;
            this.txtDNI.Tag = "CHO_dni";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(187, 59);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(330, 25);
            this.txtNombreCompleto.TabIndex = 18;
            this.txtNombreCompleto.Tag = "CHO_nombre_completo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(187, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(96, 25);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.Tag = "CHO_codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre completo";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(134, 31);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(51, 17);
            this.Codigo.TabIndex = 14;
            this.Codigo.Text = "Codigo";
            // 
            // frmDM_Chofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 277);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmDM_Chofer";
            this.Text = "Chofer";
            this.Load += new System.EventHandler(this.frmDM_Chofer_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).EndInit();
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Button btnGoVehiculo;
    }
}