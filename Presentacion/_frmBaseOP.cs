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
    public partial class _frmBaseOP : DevComponents.DotNetBar.Metro.MetroForm
    {
        public string tabla = "";

        public _frmBaseOP()
        {
            InitializeComponent();
        }

        private void _frmBaseDM_Load(object sender, EventArgs e)
        {
            this.btnCrear.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnAnular.Enabled = true;
            this.btnPrimero.Enabled = true;
            this.btnAnterior.Enabled = true;
            this.btnSiguiente.Enabled = true;
            this.btnUltimo.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.btnCancelar.Visible = false;

            verificarPermisos();
        }

        private void verificarPermisos()
        {
            this.btnCrear.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso(tabla + "_CREAR"), (SharedData.Instance().Reglas ?? ""));
            this.btnActualizar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso(tabla + "_MODIFICAR"), (SharedData.Instance().Reglas ?? ""));
            this.btnAnular.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso(tabla + "_ANULAR"), (SharedData.Instance().Reglas ?? ""));
        }

        public virtual void Crear() { }
        public virtual bool Guardar() { return false; }
        public virtual bool Actualizar() { return false; }
        public virtual bool Anular() { return false; }
        public virtual void Primero() { }
        public virtual void Anterior() { }
        public virtual void Siguiente() { }
        public virtual void Ultimo() { }
        public virtual void Buscar() { }
        public virtual void Cancelar() { }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Crear();

            this.btnCrear.Enabled = true;
            this.btnGuardar.Visible = true;
            this.btnGuardar.Enabled = true;
            this.btnActualizar.Enabled = false;
            this.btnAnular.Enabled = false;
            this.btnPrimero.Enabled = false;
            this.btnAnterior.Enabled = false;
            this.btnSiguiente.Enabled = false;
            this.btnUltimo.Enabled = false;
            this.btnBuscar.Enabled = false;
            this.btnCancelar.Visible = true;
            this.btnCancelar.Enabled = true;

            verificarPermisos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Guardar())
            {
                this.btnCrear.Enabled = true;
                this.btnGuardar.Visible = false;
                this.btnActualizar.Enabled = true;
                this.btnAnular.Enabled = true;
                this.btnPrimero.Enabled = true;
                this.btnAnterior.Enabled = true;
                this.btnSiguiente.Enabled = true;
                this.btnUltimo.Enabled = true;
                this.btnBuscar.Enabled = true;
                this.btnCancelar.Visible = false;

                Ultimo();                                
            }
            verificarPermisos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea actualizar la información del elemento actual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Actualizar())
                {
                    this.btnCrear.Enabled = true;
                    this.btnGuardar.Visible = false;
                    this.btnActualizar.Enabled = true;
                    this.btnAnular.Enabled = true;
                    this.btnPrimero.Enabled = true;
                    this.btnAnterior.Enabled = true;
                    this.btnSiguiente.Enabled = true;
                    this.btnUltimo.Enabled = true;
                    this.btnBuscar.Enabled = true;
                    this.btnCancelar.Visible = false;
                }                
            }
            verificarPermisos();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea anular el elemento actual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Anular())
                {
                    this.btnCrear.Enabled = true;
                    this.btnGuardar.Visible = false;
                    this.btnActualizar.Enabled = true;
                    this.btnAnular.Enabled = true;
                    this.btnPrimero.Enabled = true;
                    this.btnAnterior.Enabled = true;
                    this.btnSiguiente.Enabled = true;
                    this.btnUltimo.Enabled = true;
                    this.btnBuscar.Enabled = true;
                    this.btnCancelar.Visible = false;

                    Ultimo();
                }
            }
            verificarPermisos();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            Primero();

            this.btnCrear.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnAnular.Enabled = true;
            this.btnPrimero.Enabled = true;
            this.btnAnterior.Enabled = true;
            this.btnSiguiente.Enabled = true;
            this.btnUltimo.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.btnCancelar.Visible = false;

            verificarPermisos();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Anterior();

            this.btnCrear.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnAnular.Enabled = true;
            this.btnPrimero.Enabled = true;
            this.btnAnterior.Enabled = true;
            this.btnSiguiente.Enabled = true;
            this.btnUltimo.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.btnCancelar.Visible = false;

            verificarPermisos();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Siguiente();

            this.btnCrear.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnAnular.Enabled = true;
            this.btnPrimero.Enabled = true;
            this.btnAnterior.Enabled = true;
            this.btnSiguiente.Enabled = true;
            this.btnUltimo.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.btnCancelar.Visible = false;

            verificarPermisos();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            Ultimo();

            this.btnCrear.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnAnular.Enabled = true;
            this.btnPrimero.Enabled = true;
            this.btnAnterior.Enabled = true;
            this.btnSiguiente.Enabled = true;
            this.btnUltimo.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.btnCancelar.Visible = false;

            verificarPermisos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();

            this.btnCrear.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnAnular.Enabled = true;
            this.btnPrimero.Enabled = true;
            this.btnAnterior.Enabled = true;
            this.btnSiguiente.Enabled = true;
            this.btnUltimo.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.btnCancelar.Visible = false;

            verificarPermisos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
            Ultimo();

            this.btnCrear.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnAnular.Enabled = true;
            this.btnPrimero.Enabled = true;
            this.btnAnterior.Enabled = true;
            this.btnSiguiente.Enabled = true;
            this.btnUltimo.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.btnCancelar.Visible = false;

            verificarPermisos();
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
        
        int i = 0;
        private void _frmBaseOP_VisibleChanged(object sender, EventArgs e)
        {            
            i++;
            //MessageBox.Show(i.ToString());
            if (tabla.Length > 0)
            {
                if (!balUSUARIO.TieneRegla(SharedData.Instance().getPermiso((tabla ?? "") + "_VER"), (SharedData.Instance().Reglas ?? "")) && (i == 1))
                {
                    this.Close();
                    MessageBox.Show("Su usuario no tiene permiso para ver este formulario.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void mensaje(string operacionCorrecta)
        {
            switch (operacionCorrecta)
            {
                case "guardar":
                    this.lblMensaje.Text = "";
                    this.lblMensaje.Text = "El registro fue insertado correctamente";
                    this.lblSeparador.Visible = false;
                    break;
                case "actualizar":
                    this.lblMensaje.Text = "";
                    this.lblMensaje.Text = "El registro fue actualizado correctamente";
                    this.lblSeparador.Visible = false;
                    break;
                case "anular":
                    this.lblMensaje.Text = "";
                    this.lblMensaje.Text = "El registro fue anulado correctamente";
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
