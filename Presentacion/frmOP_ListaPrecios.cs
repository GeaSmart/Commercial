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
    public partial class frmOP_ListaPrecios : _frmBaseTB
    {
        public frmOP_ListaPrecios()
        {
            InitializeComponent();
            tabla = "DETALLE_LISTA_PRECIO";
            
            this.cmbListaPrecio.ValueMember = "LPR_codigo";
            this.cmbListaPrecio.DisplayMember = "LPR_nombre";
            this.cmbListaPrecio.DataSource = balLISTA_PRECIO.poblar();
        }

        public frmOP_ListaPrecios(string codigoProducto)
        {
            InitializeComponent();

            this.cmbListaPrecio.ValueMember = "LPR_codigo";
            this.cmbListaPrecio.DisplayMember = "LPR_nombre";
            this.cmbListaPrecio.DataSource = balLISTA_PRECIO.poblar();
            
            this.txtFiltrar.Text = codigoProducto;
        }

        private void frmOP_AsignarListaPrecios_Load(object sender, EventArgs e)
        {
            //this.btnActualizar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("DETALLE_LISTA_PRECIO_MODIFICAR"), (SharedData.Instance().Reglas ?? ""));
        }

        private void cmbListaPrecio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eLISTA_PRECIO oeLISTAPRECIO = new eLISTA_PRECIO();
            oeLISTAPRECIO.LPR_codigo = this.cmbListaPrecio.SelectedValue.ToString();
            string filtro = this.txtFiltrar.Text;

            cargarDatos(balLISTA_PRECIO.mostrarListaPrecios(oeLISTAPRECIO, filtro));
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.dgvListado.DataSource = dt;                
            }
        }



        private void cmbListaPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            eLISTA_PRECIO oeLISTAPRECIO = new eLISTA_PRECIO();
            oeLISTAPRECIO.LPR_codigo = this.cmbListaPrecio.SelectedValue.ToString();
            string filtro = this.txtFiltrar.Text;

            cargarDatos(balLISTA_PRECIO.mostrarListaPrecios(oeLISTAPRECIO, filtro));
        }

        private void dgvListado_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            _cfgUtil.enumerarFilasDatagridview(this.dgvListado, e);
        }

        //private void btnActualizar_Click(object sender, EventArgs e)
        public override void Guardar()
        {
            eDETALLE_LISTA_PRECIO o = new eDETALLE_LISTA_PRECIO();

            int contadorInsertadosCorrectos = 0;
            int contadorInsertadosIncorrectos = 0;

            foreach (DataGridViewRow row in this.dgvListado.Rows)
            {
                if (row.Cells["DLP_precio"].Value.ToString().Length > 0)
                {
                    string listaprecio = this.cmbListaPrecio.SelectedValue.ToString();
                    string codigo = row.Cells["PRO_codigo"].Value.ToString();
                    double precio = Convert.ToDouble(row.Cells["DLP_precio"].Value.ToString());

                    o.LPR_codigo = listaprecio;
                    o.PRO_codigo = codigo;
                    o.DLP_precio = precio;

                    if (balDETALLE_LISTA_PRECIO.actualizarListaPrecios(o))
                    {
                        contadorInsertadosCorrectos++;
                    }
                    else
                    {  
                        contadorInsertadosIncorrectos++;
                    }
                }
            }
            mensaje("guardar", contadorInsertadosCorrectos, contadorInsertadosIncorrectos);
            //MessageBox.Show("Correctos: " + contadorInsertadosCorrectos + "\r\nIncorrectos: " + contadorInsertadosIncorrectos);
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            eLISTA_PRECIO oeLISTAPRECIO = new eLISTA_PRECIO();
            oeLISTAPRECIO.LPR_codigo = this.cmbListaPrecio.SelectedValue.ToString();
            string filtro = this.txtFiltrar.Text;

            cargarDatos(balLISTA_PRECIO.mostrarListaPrecios(oeLISTAPRECIO, filtro));
        }

        private void dgvListado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvListado.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dgvListado.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnGoListaPrecios_Click(object sender, EventArgs e)
        {
            eLISTA_PRECIO o = new eLISTA_PRECIO();
            o.LPR_codigo = this.cmbListaPrecio.SelectedValue != null ? this.cmbListaPrecio.SelectedValue.ToString() : "";

            frmDM_ListaPrecio o2 = new frmDM_ListaPrecio(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvListado.Columns["PRO_codigo"].Index)
            {
                int columna_codigo = this.dgvListado.Columns["PRO_codigo"].Index;
                string codigo = this.dgvListado[columna_codigo, e.RowIndex].Value.ToString();
                ePRODUCTO o = new ePRODUCTO();
                o.PRO_codigo = codigo.Length > 0 ? codigo : "";

                frmDM_Producto o2 = new frmDM_Producto(o);
                o2.MdiParent = this.MdiParent;
                o2.Show();
            }
        }

        //Refresco combobox
        private void cmbListaPrecio_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbListaPrecio.SelectedValue != null)
            {
                valorSeleccionado = this.cmbListaPrecio.SelectedValue.ToString();
            }
            this.cmbListaPrecio.DataSource = balLISTA_PRECIO.poblar();
            this.cmbListaPrecio.SelectedValue = valorSeleccionado;            
        }
    }
}
