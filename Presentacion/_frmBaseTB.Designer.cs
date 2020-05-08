namespace Presentacion
{
    partial class _frmBaseTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmBaseTB));
            this.strOperaciones = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.stsMensaje = new System.Windows.Forms.StatusStrip();
            this.lblMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInfoSistema = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparador = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInfoControl = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.strOperaciones.SuspendLayout();
            this.stsMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // strOperaciones
            // 
            this.strOperaciones.AutoSize = false;
            this.strOperaciones.BackColor = System.Drawing.Color.PaleGreen;
            this.strOperaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.strOperaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btnGuardar});
            this.strOperaciones.Location = new System.Drawing.Point(0, 0);
            this.strOperaciones.Name = "strOperaciones";
            this.strOperaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.strOperaciones.Size = new System.Drawing.Size(678, 54);
            this.strOperaciones.TabIndex = 11;
            this.strOperaciones.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(10, 51);
            this.toolStripLabel3.Text = " ";
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // stsMensaje
            // 
            this.stsMensaje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMensaje,
            this.toolStripStatusLabel1,
            this.lblInfoSistema,
            this.lblSeparador,
            this.lblInfoControl});
            this.stsMensaje.Location = new System.Drawing.Point(0, 599);
            this.stsMensaje.Name = "stsMensaje";
            this.stsMensaje.Size = new System.Drawing.Size(678, 22);
            this.stsMensaje.TabIndex = 12;
            this.stsMensaje.Text = "statusStrip1";
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.SystemColors.Control;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(10, 17);
            this.lblMensaje.Text = " ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(598, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = " ";
            // 
            // lblInfoSistema
            // 
            this.lblInfoSistema.BackColor = System.Drawing.SystemColors.Control;
            this.lblInfoSistema.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoSistema.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInfoSistema.Name = "lblInfoSistema";
            this.lblInfoSistema.Size = new System.Drawing.Size(10, 17);
            this.lblInfoSistema.Text = " ";
            this.lblInfoSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeparador
            // 
            this.lblSeparador.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparador.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblSeparador.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(4, 17);
            // 
            // lblInfoControl
            // 
            this.lblInfoControl.BackColor = System.Drawing.SystemColors.Control;
            this.lblInfoControl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInfoControl.Name = "lblInfoControl";
            this.lblInfoControl.Size = new System.Drawing.Size(10, 17);
            this.lblInfoControl.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // _frmBaseTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 621);
            this.Controls.Add(this.stsMensaje);
            this.Controls.Add(this.strOperaciones);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "_frmBaseTB";
            this.Text = "_frmBaseTB";
            this.Load += new System.EventHandler(this._frmBaseTB_Load);
            this.VisibleChanged += new System.EventHandler(this._frmBaseTB_VisibleChanged);
            this.strOperaciones.ResumeLayout(false);
            this.strOperaciones.PerformLayout();
            this.stsMensaje.ResumeLayout(false);
            this.stsMensaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStrip strOperaciones;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        protected System.Windows.Forms.ToolStripButton btnGuardar;
        protected System.Windows.Forms.StatusStrip stsMensaje;
        protected System.Windows.Forms.ToolStripStatusLabel lblMensaje;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblInfoSistema;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparador;
        private System.Windows.Forms.ToolStripStatusLabel lblInfoControl;
        private System.Windows.Forms.Timer timer1;
    }
}