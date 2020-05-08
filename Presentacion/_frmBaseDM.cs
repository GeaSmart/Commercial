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
    public partial class _frmBaseDM : DevComponents.DotNetBar.Metro.MetroForm
    {
        public string tabla = "";        
        
        public _frmBaseDM()
        {
            InitializeComponent();
        }
        
        private void _frmBaseDM_Load(object sender, EventArgs e)
        {
            this.btnNuevo.Enabled = true;
            this.btnGuardar.Visible = false;//
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnPrimero.Enabled = true;
            this.btnAnterior.Enabled = true;
            this.btnSiguiente.Enabled = true;
            this.btnUltimo.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.btnCancelar.Visible = false;

            verificarPermisos();
            
            //foreach (Control d in this.Controls)
            //{
            //    if (d is GroupBox)
            //    {
            //        foreach (Control c in d.Controls)
            //        {
            //            if ((c is TextBox || c is ComboBox || c is CheckBox || c is NumericUpDown || c is DateTimePicker))
            //            {
            //                c.MouseEnter += delegate { this.lblInfoSistema.Text = c.Tag != null ? c.Tag.ToString() : ""; };
            //                c.MouseLeave += delegate { this.lblInfoSistema.Text = ""; };
            //                c.MouseEnter += delegate { this.lblInfoControl.Text = c.Name; };
            //                c.MouseLeave += delegate { this.lblInfoControl.Text = ""; };
            //            }
            //            foreach (Control x in c.Controls)
            //            {
            //                if ((x is TextBox || x is ComboBox || x is CheckBox || x is NumericUpDown || x is DateTimePicker))
            //                {
            //                    x.MouseEnter += delegate { this.lblInfoSistema.Text = x.Tag != null ? x.Tag.ToString() : ""; };
            //                    x.MouseLeave += delegate { this.lblInfoSistema.Text = ""; };
            //                    x.MouseEnter += delegate { this.lblInfoControl.Text = x.Name; };
            //                    x.MouseLeave += delegate { this.lblInfoControl.Text = ""; };
            //                }
            //            }
            //        }
            //    }

            //    if ((d is TextBox || d is ComboBox || d is CheckBox || d is NumericUpDown || d is DateTimePicker) && d.Tag != null)
            //    {
            //        d.MouseEnter += delegate { this.lblInfoSistema.Text = d.Tag != null ? d.Tag.ToString() : ""; };
            //        d.MouseLeave += delegate { this.lblInfoSistema.Text = ""; };
            //        d.MouseEnter += delegate { this.lblInfoControl.Text = d.Name; };
            //        d.MouseLeave += delegate { this.lblInfoControl.Text = ""; };
            //    }

            //    if (d is ToolStrip)
            //    {
            //        foreach (ToolStripItem item in ((ToolStrip)d).Items)
            //        {
            //            if (item is ToolStripButton)
            //            {
            //                item.MouseEnter += delegate { this.lblInfoControl.Text = item.Name; };
            //                item.MouseLeave += delegate { this.lblInfoControl.Text = ""; };
            //            }
            //        }
            //    }
            //}
        }

        private void verificarPermisos()
        {            
            this.btnNuevo.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso(tabla + "_CREAR"), (SharedData.Instance().Reglas ?? ""));
            this.btnActualizar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso(tabla + "_MODIFICAR"), (SharedData.Instance().Reglas ?? ""));
            this.btnEliminar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso(tabla + "_ELIMINAR"), (SharedData.Instance().Reglas ?? ""));
            this.lblInfoSistema.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("INFOSISTEMA"), (SharedData.Instance().Reglas ?? ""));
            this.lblInfoControl.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("INFOSISTEMA"), (SharedData.Instance().Reglas ?? ""));
        }

        public virtual void Nuevo() { }
        public virtual bool Guardar() { return false; }
        public virtual bool Actualizar() { return false; }
        public virtual bool Eliminar() { return false; }
        public virtual void Primero() { }
        public virtual void Anterior() { }
        public virtual void Siguiente() { }
        public virtual void Ultimo() { }
        public virtual void Buscar() { }
        public virtual void Cancelar() { }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();

            this.errValidacion.Clear();

            this.btnNuevo.Enabled = true;
            this.btnGuardar.Visible = true;
            this.btnGuardar.Enabled = true;
            this.btnActualizar.Enabled = false;
            this.btnEliminar.Enabled = false;
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
            this.errValidacion.Clear();

            if (Guardar())
            {
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Visible = false;
                this.btnActualizar.Enabled = true;
                this.btnEliminar.Enabled = true;
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
            this.errValidacion.Clear();

            DialogResult result = MessageBox.Show("¿Desea actualizar la información del elemento actual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Actualizar())
                {
                    this.btnNuevo.Enabled = true;
                    this.btnGuardar.Visible = false;
                    this.btnActualizar.Enabled = true;
                    this.btnEliminar.Enabled = true;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.errValidacion.Clear();

            DialogResult result = MessageBox.Show("¿Desea eliminar el elemento actual? \r\nSi existen operaciones vinculadas a él en el sistema, no podra eliminarse.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Eliminar())
                {
                    this.btnNuevo.Enabled = true;
                    this.btnGuardar.Visible = false;
                    this.btnActualizar.Enabled = true;
                    this.btnEliminar.Enabled = true;
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
            this.errValidacion.Clear();

            Primero();

            this.btnNuevo.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
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
            this.errValidacion.Clear();

            Anterior();

            this.btnNuevo.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
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
            this.errValidacion.Clear();

            Siguiente();

            this.btnNuevo.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
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
            this.errValidacion.Clear();

            Ultimo();

            this.btnNuevo.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
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
            this.errValidacion.Clear();

            Buscar();

            this.btnNuevo.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
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
            this.errValidacion.Clear();

            Cancelar();
            Ultimo();

            this.btnNuevo.Enabled = true;
            this.btnGuardar.Visible = false;
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
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
        private void _frmBaseDM_VisibleChanged(object sender, EventArgs e)
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

        //public void mensaje(string operacionCorrecta)
        //{
        //    switch (operacionCorrecta)
        //    {
        //        case "guardar":
        //            this.lblMensaje.Text = "";
        //            this.lblMensaje.Text = "El registro fue guardado correctamente";
        //            this.lblSeparador.Visible = false;
        //            this.stsMensaje.BackColor = Color.LightGreen;
        //            break;
        //        case "actualizar":
        //            this.lblMensaje.Text = "";
        //            this.lblMensaje.Text = "El registro fue actualizado correctamente";
        //            this.lblSeparador.Visible = false;
        //            this.stsMensaje.BackColor = Color.LightGreen;
        //            break;
        //        case "eliminar":
        //            this.lblMensaje.Text = "";
        //            this.lblMensaje.Text = "El registro fue eliminado correctamente";
        //            this.lblSeparador.Visible = false;
        //            this.stsMensaje.BackColor = Color.LightGreen;
        //            break;
        //    }
        //    this.timer1.Stop();
        //    this.timer1.Start();
        //    this.stsMensaje.BackColor = Color.LightGreen;
        //}

        public void mensaje(string operacionCorrecta, string mensaje)
        {
            switch (operacionCorrecta)
            {
                case "guardar":
                    this.lblMensaje.Text = "";
                    this.lblMensaje.Text = "El registro fue guardado correctamente";
                    this.lblSeparador.Visible = false;
                    this.stsMensaje.BackColor = Color.LightGreen;
                    break;
                case "actualizar":
                    this.lblMensaje.Text = "";
                    this.lblMensaje.Text = "El registro fue actualizado correctamente";
                    this.lblSeparador.Visible = false;
                    this.stsMensaje.BackColor = Color.LightGreen;
                    break;
                case "eliminar":
                    this.lblMensaje.Text = "";
                    this.lblMensaje.Text = "El registro fue eliminado correctamente";
                    this.lblSeparador.Visible = false;
                    this.stsMensaje.BackColor = Color.LightGreen;
                    break;
                case "corregir":
                    this.lblMensaje.Text = "";
                    this.lblMensaje.Text = mensaje;
                    this.lblSeparador.Visible = false;
                    this.stsMensaje.BackColor = Color.Orange;
                    break;
                case "subsanar":
                    this.lblMensaje.Text = "";
                    this.lblMensaje.Text = "Corrija los campos indicados";
                    this.lblSeparador.Visible = false;
                    this.stsMensaje.BackColor = Color.Orange;
                    break;
            }
            this.timer1.Stop();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblMensaje.Text = "";
            this.stsMensaje.BackColor = Color.Empty;
            this.lblSeparador.Visible = true;
            this.timer1.Stop();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.stsMensaje.BackColor.ToString());
        }

        public virtual void ExportarExcel() { }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel(); 
        }
    }
}
