namespace Presentacion
{
    partial class frmDM_Vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_Vendedor));
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnExportarImagen = new System.Windows.Forms.Button();
            this.btnBorrarImagen = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).BeginInit();
            this.gpbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.txtComentario);
            this.gpbInformacion.Controls.Add(this.label4);
            this.gpbInformacion.Controls.Add(this.txtTelefono);
            this.gpbInformacion.Controls.Add(this.label3);
            this.gpbInformacion.Controls.Add(this.txtDNI);
            this.gpbInformacion.Controls.Add(this.label2);
            this.gpbInformacion.Controls.Add(this.chkEstado);
            this.gpbInformacion.Controls.Add(this.btnExportarImagen);
            this.gpbInformacion.Controls.Add(this.btnBorrarImagen);
            this.gpbInformacion.Controls.Add(this.label23);
            this.gpbInformacion.Controls.Add(this.btnCambiarImagen);
            this.gpbInformacion.Controls.Add(this.picImagen);
            this.gpbInformacion.Controls.Add(this.txtNombreCompleto);
            this.gpbInformacion.Controls.Add(this.label12);
            this.gpbInformacion.Controls.Add(this.txtCodigo);
            this.gpbInformacion.Controls.Add(this.label1);
            this.gpbInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(10, 53);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(565, 286);
            this.gpbInformacion.TabIndex = 6;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Informacion";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(124, 154);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(248, 82);
            this.txtComentario.TabIndex = 76;
            this.txtComentario.Tag = "VEN_comentario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Comentario";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(124, 123);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(134, 25);
            this.txtTelefono.TabIndex = 74;
            this.txtTelefono.Tag = "VEN_telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Telefono";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(124, 92);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(98, 25);
            this.txtDNI.TabIndex = 72;
            this.txtDNI.Tag = "VEN_dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "DNI";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(124, 244);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(90, 21);
            this.chkEstado.TabIndex = 70;
            this.chkEstado.Text = "Está Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnExportarImagen
            // 
            this.btnExportarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarImagen.Image")));
            this.btnExportarImagen.Location = new System.Drawing.Point(447, 213);
            this.btnExportarImagen.Name = "btnExportarImagen";
            this.btnExportarImagen.Size = new System.Drawing.Size(30, 23);
            this.btnExportarImagen.TabIndex = 68;
            this.btnExportarImagen.UseVisualStyleBackColor = true;
            this.btnExportarImagen.Click += new System.EventHandler(this.btnExportarImagen_Click);
            // 
            // btnBorrarImagen
            // 
            this.btnBorrarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarImagen.Image")));
            this.btnBorrarImagen.Location = new System.Drawing.Point(415, 213);
            this.btnBorrarImagen.Name = "btnBorrarImagen";
            this.btnBorrarImagen.Size = new System.Drawing.Size(30, 23);
            this.btnBorrarImagen.TabIndex = 67;
            this.btnBorrarImagen.UseVisualStyleBackColor = true;
            this.btnBorrarImagen.Click += new System.EventHandler(this.btnBorrarImagen_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(381, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 17);
            this.label23.TabIndex = 66;
            this.label23.Text = "Foto";
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarImagen.Image")));
            this.btnCambiarImagen.Location = new System.Drawing.Point(383, 213);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(30, 23);
            this.btnCambiarImagen.TabIndex = 64;
            this.btnCambiarImagen.UseVisualStyleBackColor = true;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // picImagen
            // 
            this.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagen.Location = new System.Drawing.Point(384, 40);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(170, 170);
            this.picImagen.TabIndex = 65;
            this.picImagen.TabStop = false;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(124, 61);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(248, 25);
            this.txtNombreCompleto.TabIndex = 23;
            this.txtNombreCompleto.Tag = "VEN_nombre_completo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Nombre completo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(124, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(84, 25);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.Tag = "VEN_codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // frmDM_Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 363);
            this.Controls.Add(this.gpbInformacion);
            this.Name = "frmDM_Vendedor";
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.frmDM_Vendedor_Load);
            this.Controls.SetChildIndex(this.gpbInformacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).EndInit();
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button btnExportarImagen;
        private System.Windows.Forms.Button btnBorrarImagen;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnCambiarImagen;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}