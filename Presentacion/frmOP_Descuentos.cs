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
    public partial class frmOP_Descuentos : _frmBaseTB
    {
        balSOCIO _obalSOCIO = new balSOCIO();
        eSOCIO _oeSOCIO = new eSOCIO();

        public frmOP_Descuentos()
        {
            InitializeComponent();
            
            this.dgvDescuentoGrupal.Columns["DSC_porcentaje"].ValueType = Type.GetType("System.Decimal");
            this.dgvDescuentoGrupal.Columns["DSC_esp_porcentaje"].ValueType = Type.GetType("System.Decimal");

            this.cmbCanal.ValueMember = "CAN_codigo";
            this.cmbCanal.DisplayMember = "CAN_nombre";
            this.cmbCanal.DataSource = balCANAL.poblar();
        }

        private void frmOP_Descuentos_Load(object sender, EventArgs e)
        {
            verificarPermisos();
        }

        private void btnSocio_Click(object sender, EventArgs e)
        {
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", _obalSOCIO);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                if (_oeSOCIO == null) _oeSOCIO = new eSOCIO();
                _oeSOCIO.SOC_codigo = Convert.ToInt32(ventana.pk);
                DataTable dt = balSOCIO.obtenerRegistro(_oeSOCIO);
                if (dt != null)
                {
                    this.txtCodigoSocio.Text = dt.Rows[0]["SOC_codigo"].ToString();
                    this.txtNombreSocio.Text = dt.Rows[0]["SOC_nombre_razon_social"].ToString();
                    this.dgvDescuentoSocio.DataSource = balPRODUCTO.poblarParaDescuentos();
                }
            }
        }

        private void cargarGrillaDescuentosP()
        {
            balDESCUENTO_P obalDESCUENTOP = new balDESCUENTO_P();
            eDESCUENTO_P oeDESCUENTOP = new eDESCUENTO_P();
            oeDESCUENTOP.SOC_codigo = Convert.ToInt16(this.txtCodigoSocio.Text);
            this.dgvDescuentoSocio.DataSource = obalDESCUENTOP.mostrarDescuentosPPorProducto(oeDESCUENTOP);
        }
                
        private void dgvDescuentoGrupal_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            _cfgUtil.enumerarFilasDatagridview(this.dgvDescuentoGrupal, e);
        }

        private void dgvDescuentoSocio_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            _cfgUtil.enumerarFilasDatagridview(this.dgvDescuentoSocio, e);
        }

        private void dgvDescuentoGrupal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {            
            mostrarDescuentosGrupales();
            formatearGrilla();
        }

        private void mostrarDescuentosGrupales()
        {
            foreach (DataGridViewRow fila in this.dgvDescuentoGrupal.Rows)
            {
                eDESCUENTO oeDESCUENTO = new eDESCUENTO();
                oeDESCUENTO.CAN_codigo = this.cmbCanal.SelectedValue.ToString();
                oeDESCUENTO.PRO_codigo = this.dgvDescuentoGrupal["PRO_codigo", fila.Index].Value.ToString();
                balDESCUENTO obalDESCUENTO = new balDESCUENTO();
                
                DataTable dt = obalDESCUENTO.mostrarDescuentosPorProducto(oeDESCUENTO);
                this.dgvDescuentoGrupal["DSC_is_especial", fila.Index].Value = dt.Rows[0]["DSC_is_especial"].ToString();
                this.dgvDescuentoGrupal["DSC_porcentaje", fila.Index].Value = dt.Rows[0]["DSC_porcentaje"].ToString();
                this.dgvDescuentoGrupal["DSC_esp_porcentaje", fila.Index].Value = dt.Rows[0]["DSC_esp_porcentaje"].ToString();
                this.dgvDescuentoGrupal["DSC_fecha_vencimiento", fila.Index].Value = dt.Rows[0]["DSC_fecha_vencimiento"].ToString();                
            }
        }

        private void mostrarDescuentosSocio()
        {
            foreach (DataGridViewRow fila in this.dgvDescuentoSocio.Rows)
            {
                eDESCUENTO_P oeDESCUENTOP = new eDESCUENTO_P();
                oeDESCUENTOP.SOC_codigo = Convert.ToInt16(this.txtCodigoSocio.Text);
                oeDESCUENTOP.PRO_codigo = this.dgvDescuentoSocio["PRO_codigo2", fila.Index].Value.ToString();
                balDESCUENTO_P obalDESCUENTOP = new balDESCUENTO_P();
                this.dgvDescuentoSocio["DSC_porcentaje2", fila.Index].Value = obalDESCUENTOP.mostrarDescuentosPPorProducto(oeDESCUENTOP).Rows[0][0].ToString();
            }
        }

        private void dgvDescuentoSocio_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            mostrarDescuentosSocio();
        }
        
        public override void Guardar()
        {
            if (tabDescuentos.SelectedTab == tabDescuentos.TabPages["Grupal"])//your specific tabname
            {
                eDESCUENTO oeDESCUENTO = new eDESCUENTO();
                balDESCUENTO obalDESCUENTO = new balDESCUENTO();

                int contadorInsertadosCorrectos = 0;
                int contadorInsertadosIncorrectos = 0;
                DateTime u;
                foreach (DataGridViewRow row in this.dgvDescuentoGrupal.Rows)
                {
                    string CAN_codigo = this.cmbCanal.SelectedValue.ToString();                    
                    string PRO_codigo = row.Cells["PRO_codigo"].Value.ToString();
                    string DSC_is_especial = row.Cells["DSC_is_especial"].Value.ToString();
                    double porcentaje = row.Cells["DSC_porcentaje"].Value != null ? Convert.ToDouble(row.Cells["DSC_porcentaje"].Value.ToString()) : 0;
                    double esp_porcentaje = row.Cells["DSC_esp_porcentaje"].Value != null ? Convert.ToDouble(row.Cells["DSC_esp_porcentaje"].Value.ToString()) : 0;

                    DateTime? DSC_fecha_vencimiento = (row.Cells["DSC_fecha_vencimiento"].Value != null) ? DateTime.TryParse(row.Cells["DSC_fecha_vencimiento"].Value.ToString(), out u) ? Convert.ToDateTime(row.Cells["DSC_fecha_vencimiento"].Value.ToString()) : (DateTime?)null : null;

                    oeDESCUENTO.CAN_codigo = CAN_codigo;
                    oeDESCUENTO.PRO_codigo = PRO_codigo;
                    oeDESCUENTO.DSC_is_especial = DSC_is_especial;
                    oeDESCUENTO.DSC_porcentaje = porcentaje;
                    oeDESCUENTO.DSC_esp_porcentaje = esp_porcentaje;
                    oeDESCUENTO.DSC_fecha_vencimiento = DSC_fecha_vencimiento;

                    if (balDESCUENTO.actualizarDescuento(oeDESCUENTO))
                    {
                        contadorInsertadosCorrectos++;
                    }
                    else
                    {
                        contadorInsertadosIncorrectos++;
                    }
                }
                mensaje("guardar", contadorInsertadosCorrectos, contadorInsertadosIncorrectos);
                //MessageBox.Show("Se actualizaron los " + contadorInsertadosCorrectos + " registros en la tabla de descuentos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarDescuentosGrupales();
            }
            else
            {
                eDESCUENTO_P oeDESCUENTOP = new eDESCUENTO_P();
                balDESCUENTO_P obalDESCUENTOP = new balDESCUENTO_P();

                int contadorInsertadosCorrectos = 0;
                int contadorInsertadosIncorrectos = 0;

                foreach (DataGridViewRow row in this.dgvDescuentoSocio.Rows)
                {
                    int SOC_codigo = Convert.ToInt16(this.txtCodigoSocio.Text);
                    string PRO_codigo = row.Cells["PRO_codigo2"].Value.ToString();
                    double porcentaje = row.Cells["DSC_porcentaje2"].Value != null ? Convert.ToDouble(row.Cells["DSC_porcentaje2"].Value.ToString()) : 0;

                    oeDESCUENTOP.SOC_codigo = SOC_codigo;
                    oeDESCUENTOP.PRO_codigo = PRO_codigo;
                    oeDESCUENTOP.DSC_porcentaje = porcentaje;

                    if (obalDESCUENTOP.actualizarDescuentoP(oeDESCUENTOP))
                    {
                        contadorInsertadosCorrectos++;
                    }
                    else
                    {
                        contadorInsertadosIncorrectos++;
                    }
                }
                mensaje("guardar", contadorInsertadosCorrectos, contadorInsertadosIncorrectos);
                //MessageBox.Show("Se actualizaron los " + contadorInsertadosCorrectos + " registros en la tabla de descuentos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarDescuentosSocio();
            }
        }

        private void cmbCanal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvDescuentoGrupal.DataSource = balPRODUCTO.poblarParaDescuentos();
        }

        private void cmbCanal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.dgvDescuentoGrupal.DataSource = balPRODUCTO.poblarParaDescuentos();
        }

        private void dgvDescuentoGrupal_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvDescuentoGrupal.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dgvDescuentoGrupal.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvDescuentoSocio_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvDescuentoSocio.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dgvDescuentoSocio.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void tabDescuentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificarPermisos();
        }

        private void verificarPermisos()
        {
            if (!balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("DESCUENTO_VER"), (SharedData.Instance().Reglas ?? "")))
            {
                this.tabDescuentos.TabPages.Remove(Grupal);
            }

            if (!balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("DESCUENTO_P_VER"), (SharedData.Instance().Reglas ?? "")))
            {
                this.tabDescuentos.TabPages.Remove(PorSocio);
            }

            if (tabDescuentos.SelectedTab == tabDescuentos.TabPages["Grupal"])
            {
                this.btnGuardar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("DESCUENTO_MODIFICAR"), (SharedData.Instance().Reglas ?? ""));
            }
            else
            {
                this.btnGuardar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("DESCUENTO_P_MODIFICAR"), (SharedData.Instance().Reglas ?? ""));
            }
        }
        
        private void dgvDescuentoGrupal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = this.dgvDescuentoGrupal.Columns[e.ColumnIndex].Name;
            if (colName == "DSC_fecha_vencimiento")
            {
                Point punto = Cursor.Position;
                frm_EstablecerFecha o = new frm_EstablecerFecha(punto, "descuento");
                
                DialogResult respuesta = o.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    this.dgvDescuentoGrupal["DSC_fecha_vencimiento", e.RowIndex].Value = o.pk;
                    this.dgvDescuentoGrupal.RefreshEdit();
                }
            }
        }

        private void chkSeleccionarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionarTodo.Checked)
            {
                for (int i = 0; i < this.dgvDescuentoGrupal.RowCount; i++)
                {
                    this.dgvDescuentoGrupal["DSC_is_especial", i].Value = "S";
                }
            }
            else
            {
                for (int i = 0; i < this.dgvDescuentoGrupal.RowCount; i++)
                {
                    this.dgvDescuentoGrupal["DSC_is_especial", i].Value = "N";
                }
            }
        }

        private void chkReplicarFecha_CheckedChanged(object sender, EventArgs e)
        {
            DateTime u;
            if (this.dgvDescuentoGrupal.RowCount > 0)
            {
                string fecha = DateTime.TryParse(this.dgvDescuentoGrupal["DSC_fecha_vencimiento", 0].Value.ToString(), out u) ? this.dgvDescuentoGrupal["DSC_fecha_vencimiento", 0].Value.ToString() : "";
                if (chkReplicarFecha.Checked)
                {
                    for (int i = 0; i < this.dgvDescuentoGrupal.RowCount; i++)
                    {
                        this.dgvDescuentoGrupal["DSC_fecha_vencimiento", i].Value = fecha;
                    }
                }
                else
                {
                    for (int i = 0; i < this.dgvDescuentoGrupal.RowCount; i++)
                    {
                        this.dgvDescuentoGrupal["DSC_fecha_vencimiento", i].Value = "";
                    }
                }
            }
        }

        private void dgvDescuentoGrupal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvDescuentoGrupal.CommitEdit(DataGridViewDataErrorContexts.Commit);
            //MessageBox.Show(e.ColumnIndex + " ROW:" + e.RowIndex);
            if (e.RowIndex >= 0 && e.ColumnIndex == this.dgvDescuentoGrupal.Columns["PRO_codigo"].Index)
            {
                string codigo = this.dgvDescuentoGrupal[e.ColumnIndex, e.RowIndex].Value.ToString();
                ePRODUCTO o = new ePRODUCTO();
                o.PRO_codigo = codigo.Length > 0 ? codigo : "";

                frmDM_Producto o2 = new frmDM_Producto(o);
                o2.MdiParent = this.MdiParent;
                o2.Show();
            }
        }

        private void dgvDescuentoGrupal_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDescuentoGrupal.RowCount > 0)
            {
                if (e.ColumnIndex == this.dgvDescuentoGrupal.Columns["DSC_is_especial"].Index)
                {
                    formatearGrilla();
                }
            }
        }

        private void formatearGrilla()
        {
            foreach (DataGridViewRow fila in this.dgvDescuentoGrupal.Rows)
            {                
                string valor = this.dgvDescuentoGrupal["DSC_is_especial", fila.Index].Value != null ? this.dgvDescuentoGrupal["DSC_is_especial", fila.Index].Value.ToString() : "N";
                if (valor == "S")
                {
                    dgvDescuentoGrupal.Rows[fila.Index].Cells["DSC_esp_porcentaje"].Style.Font = new Font(this.dgvDescuentoGrupal.Font, FontStyle.Bold);
                    dgvDescuentoGrupal.Rows[fila.Index].Cells["DSC_porcentaje"].Style.Font = new Font(this.dgvDescuentoGrupal.Font, FontStyle.Regular);
                }
                else
                {
                    dgvDescuentoGrupal.Rows[fila.Index].Cells["DSC_esp_porcentaje"].Style.Font = new Font(this.dgvDescuentoGrupal.Font, FontStyle.Regular);
                    dgvDescuentoGrupal.Rows[fila.Index].Cells["DSC_porcentaje"].Style.Font = new Font(this.dgvDescuentoGrupal.Font, FontStyle.Bold);
                }
            }
        }

        private void btnGoCanal_Click(object sender, EventArgs e)
        {
            eCANAL o = new eCANAL();
            o.CAN_codigo = this.cmbCanal.SelectedValue != null ? this.cmbCanal.SelectedValue.ToString() : "";

            frmDM_Canal o2 = new frmDM_Canal(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoSocio_Click(object sender, EventArgs e)
        {
            int u;
            eSOCIO o = new eSOCIO();
            o.SOC_codigo = Int32.TryParse(this.txtCodigoSocio.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigoSocio.Text.Trim()) : -1;

            frmDM_Socio o2 = new frmDM_Socio(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void dgvDescuentoSocio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvDescuentoSocio.Columns["PRO_codigo2"].Index)
            {
                string codigo = this.dgvDescuentoSocio[e.ColumnIndex, e.RowIndex].Value.ToString();
                ePRODUCTO o = new ePRODUCTO();
                o.PRO_codigo = codigo.Length > 0 ? codigo : "";

                frmDM_Producto o2 = new frmDM_Producto(o);
                o2.MdiParent = this.MdiParent;
                o2.Show();
            }
        }

        //Refresco de combobox
        private void cmbCanal_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbCanal.SelectedValue != null)
            {
                valorSeleccionado = this.cmbCanal.SelectedValue.ToString();
            }
            this.cmbCanal.DataSource = balCANAL.poblar();
            this.cmbCanal.SelectedValue = valorSeleccionado;            
        }
    }
}
