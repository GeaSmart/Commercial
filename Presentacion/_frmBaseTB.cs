using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class _frmBaseTB : DevComponents.DotNetBar.Metro.MetroForm
    {
        public string tabla = "";

        public _frmBaseTB()
        {
            InitializeComponent();
        }

        public virtual void Guardar() { }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            verificarPermisos();
        }

        private void _frmBaseTB_Load(object sender, EventArgs e)
        {
            verificarPermisos();
        }

        private void verificarPermisos()
        {
            if(tabla.Length>0)
                this.btnGuardar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso(tabla + "_MODIFICAR"), (SharedData.Instance().Reglas ?? ""));
        }

        int i = 0;
        private void _frmBaseTB_VisibleChanged(object sender, EventArgs e)
        {
            i++;
            if (tabla.Length > 0)
            {
                if (!balUSUARIO.TieneRegla(SharedData.Instance().getPermiso((tabla ?? "") + "_VER"), (SharedData.Instance().Reglas ?? "")) && (i == 1))
                {
                    this.Close();
                    MessageBox.Show("Su usuario no tiene permiso para ver este formulario.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        public void mensaje(string operacionCorrecta, int correctos, int incorrectos)
        {
            switch (operacionCorrecta)
            {
                case "guardar":
                    this.lblMensaje.Text = "";
                    this.lblMensaje.Text = "Se guardaron correctamente " + correctos + " registros, se omitieron " + incorrectos + " registros.";
                    this.lblSeparador.Visible = false;
                    break;
                case "actualizar":
                    this.lblMensaje.Text = "";
                    this.lblMensaje.Text = "El registro fue actualizado correctamente";
                    this.lblSeparador.Visible = false;
                    break;
                case "eliminar":
                    this.lblMensaje.Text = "";
                    this.lblMensaje.Text = "El registro fue eliminado correctamente";
                    this.lblSeparador.Visible = false;
                    break;
            }
            this.timer1.Stop();
            this.timer1.Start();
            this.stsMensaje.BackColor = Color.LightGreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblMensaje.Text = "";
            this.stsMensaje.BackColor = Color.Empty;
            this.lblSeparador.Visible = true;
            this.timer1.Stop();
        }
    }
}
