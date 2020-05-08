using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class frmOP_AsignacionReglas : _frmBaseTB
    {
        public frmOP_AsignacionReglas()
        {
            InitializeComponent();
            tabla = "PERFIL_REGLA";

            this.cmbPerfil.ValueMember = "PER_codigo";
            this.cmbPerfil.DisplayMember = "PER_nombre";
            this.cmbPerfil.DataSource = balPERFIL.poblar();
        }

        public frmOP_AsignacionReglas(string codigoPerfil)
        {
            InitializeComponent();
            tabla = "PERFIL_REGLA";

            this.cmbPerfil.ValueMember = "PER_codigo";
            this.cmbPerfil.DisplayMember = "PER_nombre";
            this.cmbPerfil.DataSource = balPERFIL.poblar();

            this.txtFiltrar.Text = codigoPerfil;
        }


        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.dgvListado.DataSource = dt;
            }
        }

        private void dgvListado_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            _cfgUtil.enumerarFilasDatagridview(this.dgvListado, e);
        }


        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            ePERFIL o = new ePERFIL();
            o.PER_codigo = this.cmbPerfil.SelectedValue.ToString().Trim();
            string filtro = this.txtFiltrar.Text;

            cargarDatos(balPERFIL_REGLA.mostrarReglas(o, filtro));
        }

        private void cmbPerfil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.chkSeleccionarTodo.Checked = false;

            ePERFIL o = new ePERFIL();
            o.PER_codigo = this.cmbPerfil.SelectedValue.ToString().Trim();
            string filtro = this.txtFiltrar.Text;

            cargarDatos(balPERFIL_REGLA.mostrarReglas(o, filtro));
        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chkSeleccionarTodo.Checked = false;

            ePERFIL o = new ePERFIL();
            o.PER_codigo = this.cmbPerfil.SelectedValue.ToString().Trim();
            string filtro = this.txtFiltrar.Text;

            cargarDatos(balPERFIL_REGLA.mostrarReglas(o, filtro));
        }
        
        public override void Guardar()
        {
            ePERFIL_REGLA o = new ePERFIL_REGLA();

            int contadorInsertadosCorrectos = 0;
            int contadorInsertadosIncorrectos = 0;

            foreach (DataGridViewRow row in this.dgvListado.Rows)
            {
                string PER_codigo = this.cmbPerfil.SelectedValue.ToString();
                int REG_codigo = Convert.ToInt32(row.Cells["REG_codigo"].Value.ToString());
                string PRE_is_activo = row.Cells["PRE_is_activo"].Value.ToString();

                o.PER_codigo = PER_codigo;
                o.REG_codigo = REG_codigo;
                o.PRE_is_activo = PRE_is_activo;

                if (balPERFIL_REGLA.actualizarRegla(o))
                {
                    contadorInsertadosCorrectos++;
                }
                else
                {
                    contadorInsertadosIncorrectos++;
                }
            }

            //MessageBox.Show("Se  " + contadorInsertadosCorrectos + "\r\nIncorrectos: " + contadorInsertadosIncorrectos);
            mensaje("guardar", contadorInsertadosCorrectos, contadorInsertadosIncorrectos);
            SharedData.Instance().Reglas = balUSUARIO.refrescarReglas(SharedData.Instance().USU_usuario).Rows[0]["Reglas"].ToString();
        }

        private void dgvListado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvListado.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dgvListado.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void chkSeleccionarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionarTodo.Checked)
            {
                foreach (DataGridViewRow fila in this.dgvListado.Rows)
                {
                    fila.Cells["PRE_is_activo"].Value = "S";
                }
            }
            else
            {
                foreach (DataGridViewRow fila in this.dgvListado.Rows)
                {
                    fila.Cells["PRE_is_activo"].Value = "N";
                }
            }
        }

        private void frmOP_AsignacionReglas_Load(object sender, EventArgs e)
        {

        }

        private void btnGoPerfil_Click(object sender, EventArgs e)
        {
            ePERFIL o = new ePERFIL();
            o.PER_codigo = this.cmbPerfil.SelectedValue != null ? this.cmbPerfil.SelectedValue.ToString() : "";

            frmDM_Perfil o2 = new frmDM_Perfil(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        //Refresco de combobox
        private void cmbPerfil_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbPerfil.SelectedValue != null)
            {
                valorSeleccionado = this.cmbPerfil.SelectedValue.ToString();
            }
            this.cmbPerfil.DataSource = balPERFIL.poblar();
            this.cmbPerfil.SelectedValue = valorSeleccionado;            
        }
    }
}
