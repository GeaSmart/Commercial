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
    public partial class frmOP_Bonificaciones : _frmBaseTB
    {
        public frmOP_Bonificaciones()
        {
            InitializeComponent();
            tabla = "BONIFICACION";
            
            this.cmbCanal.ValueMember = "CAN_codigo";
            this.cmbCanal.DisplayMember = "CAN_nombre";
            this.cmbCanal.DataSource = balCANAL.poblar();
        }

        private void frmOP_Bonificaciones_Load(object sender, EventArgs e)
        {
            balProgram.sincronizarDescuentosEspeciales();
            balProgram.sincronizarBonificacionesEspeciales();
        }

        public override void Guardar()
        {
            eBONIFICACION oeBONIFICACION = new eBONIFICACION();

            int contadorInsertadosCorrectos = 0;
            int contadorInsertadosIncorrectos = 0;

            bool bandera = true;
            foreach (DataGridViewRow row in this.dgvListado.Rows)
            {
                if (!row.IsNewRow)
                {
                    if ((row.Cells["Cantidad_1"].Value == null ||
                        row.Cells["Cantidad_sub_1"].Value == null ||
                        row.Cells["Cantidad_2"].Value == null ||
                        row.Cells["Cantidad_sub_2"].Value == null ||
                        row.Cells["Cantidad_esp_2"].Value == null ||
                        row.Cells["Cantidad_esp_sub_2"].Value == null ||
                        row.Cells["PRO_codigo_1"].Value == null ||
                        row.Cells["PRO_codigo_2"].Value == null))
                    {
                        bandera = false;
                    }
                    else
                    {
                        if
                        ((Convert.ToInt16(row.Cells["Cantidad_1"].Value.ToString()) <= 0 &&
                        Convert.ToInt16(row.Cells["Cantidad_sub_1"].Value.ToString()) <= 0)
                        ||
                        (Convert.ToInt16(row.Cells["Cantidad_2"].Value.ToString()) <= 0 &&
                        Convert.ToInt16(row.Cells["Cantidad_sub_2"].Value.ToString()) <= 0)
                        ||
                        (Convert.ToInt16(row.Cells["Cantidad_esp_2"].Value.ToString()) <= 0 &&
                        Convert.ToInt16(row.Cells["Cantidad_esp_sub_2"].Value.ToString()) <= 0))
                        {
                            bandera = false;
                        }
                    }
                }
            }

            if (bandera)
            {
                string canal = this.cmbCanal.SelectedValue.ToString();
                DateTime u;
                oeBONIFICACION.CAN_codigo = canal;
                balBONIFICACION.eliminarTabla(oeBONIFICACION);

                foreach (DataGridViewRow row in this.dgvListado.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string BON_is_especial = row.Cells["BON_is_especial"].Value != null ? row.Cells["BON_is_especial"].Value.ToString() : "N";
                        string PRO_codigo_1 = row.Cells["PRO_codigo_1"].Value.ToString();
                        string PRO_codigo_2 = row.Cells["PRO_codigo_2"].Value.ToString();
                        int Cantidad_1 = Convert.ToInt16(row.Cells["Cantidad_1"].Value.ToString());
                        int Cantidad_sub_1 = Convert.ToInt16(row.Cells["Cantidad_sub_1"].Value.ToString());
                        int Cantidad_2 = Convert.ToInt16(row.Cells["Cantidad_2"].Value.ToString());
                        int Cantidad_sub_2 = Convert.ToInt16(row.Cells["Cantidad_sub_2"].Value.ToString());
                        int Cantidad_esp_2 = Convert.ToInt16(row.Cells["Cantidad_esp_2"].Value.ToString());
                        int Cantidad_esp_sub_2 = Convert.ToInt16(row.Cells["Cantidad_esp_sub_2"].Value.ToString());
                        DateTime? DSC_fecha_vencimiento = (row.Cells["BON_fecha_vencimiento"].Value != null) ? DateTime.TryParse(row.Cells["BON_fecha_vencimiento"].Value.ToString(), out u) ? Convert.ToDateTime(row.Cells["BON_fecha_vencimiento"].Value.ToString()) : (DateTime?)null : null;
                        
                        oeBONIFICACION.PRO_codigo = PRO_codigo_1;
                        oeBONIFICACION.BON_is_especial = BON_is_especial;
                        oeBONIFICACION.BON_cantidad_req = Cantidad_1;
                        oeBONIFICACION.BON_cantidad_req_submultiplo = Cantidad_sub_1;
                        oeBONIFICACION.BON_producto = PRO_codigo_2;
                        oeBONIFICACION.BON_cantidad_boni = Cantidad_2;
                        oeBONIFICACION.BON_cantidad_boni_submultiplo = Cantidad_sub_2;
                        oeBONIFICACION.BON_esp_cantidad_boni = Cantidad_esp_2;
                        oeBONIFICACION.BON_esp_cantidad_boni_submultiplo = Cantidad_esp_sub_2;
                        oeBONIFICACION.BON_fecha_vencimiento = DSC_fecha_vencimiento;

                        if (balBONIFICACION.actualizarTabla(oeBONIFICACION))
                        {
                            contadorInsertadosCorrectos++;
                        }
                        else
                        {
                            contadorInsertadosIncorrectos++;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los campos requeridos en la fila y valide que las cantidades sean mayores a cero.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            mensaje("guardar", contadorInsertadosCorrectos, contadorInsertadosIncorrectos);
            //MessageBox.Show("Resultados de la operación\r\n\r\nFilas insertadas: " + contadorInsertadosCorrectos + "\r\nErrores: " + contadorInsertadosIncorrectos, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void InsertarFilaGrilla(int indiceFila, string nombreColumna)
        {
            if (nombreColumna == "PRO_codigo_1")
            {
                balPRODUCTO _obalPRODUCTO = new balPRODUCTO();
                eCANAL oeCANAL = new eCANAL();
                oeCANAL.CAN_codigo = this.cmbCanal.SelectedValue.ToString();

                _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistroBonificacion", _obalPRODUCTO, oeCANAL);
                DialogResult respuesta = ventana.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    ePRODUCTO oePRODUCTO = new ePRODUCTO();
                    oePRODUCTO.PRO_codigo = ventana.pk;
                    DataTable dt = balPRODUCTO.obtenerRegistro(oePRODUCTO);

                    if (dt != null)
                    {
                        this.dgvListado["PRO_codigo_1", indiceFila].Value = dt.Rows[0]["PRO_codigo"].ToString();
                        this.dgvListado["PRO_descripcion_1", indiceFila].Value = dt.Rows[0]["PRO_descripcion"].ToString();
                    }
                    this.dgvListado.CurrentCell = this.dgvListado[dgvListado.Columns["Cantidad_1"].Index, indiceFila];
                }
            }

            if (nombreColumna == "PRO_codigo_2")
            {
                balPRODUCTO _obalPRODUCTO = new balPRODUCTO();
                eCANAL oeCANAL = new eCANAL();
                oeCANAL.CAN_codigo = this.cmbCanal.SelectedValue.ToString();

                _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", _obalPRODUCTO);
                DialogResult respuesta = ventana.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    ePRODUCTO oePRODUCTO = new ePRODUCTO();
                    oePRODUCTO.PRO_codigo = ventana.pk;
                    DataTable dt = balPRODUCTO.obtenerRegistro(oePRODUCTO);

                    if (dt != null)
                    {
                        this.dgvListado["PRO_codigo_2", indiceFila].Value = dt.Rows[0]["PRO_codigo"].ToString();
                        this.dgvListado["PRO_descripcion_2", indiceFila].Value = dt.Rows[0]["PRO_descripcion"].ToString();
                    }
                    this.dgvListado.CurrentCell = this.dgvListado[dgvListado.Columns["Cantidad_2"].Index, indiceFila];
                }
            }

            if (this.dgvListado["Cantidad_1", indiceFila].Value == null)
            this.dgvListado["Cantidad_1", indiceFila].Value = "0";

            if (this.dgvListado["Cantidad_sub_1", indiceFila].Value == null)
            this.dgvListado["Cantidad_sub_1", indiceFila].Value = "0";

            if (this.dgvListado["Cantidad_2", indiceFila].Value == null)
            this.dgvListado["Cantidad_2", indiceFila].Value = "0";

            if (this.dgvListado["Cantidad_sub_2", indiceFila].Value == null)
            this.dgvListado["Cantidad_sub_2", indiceFila].Value = "0";

            if (this.dgvListado["Cantidad_esp_2", indiceFila].Value == null)
                this.dgvListado["Cantidad_esp_2", indiceFila].Value = "0";

            if (this.dgvListado["Cantidad_esp_sub_2", indiceFila].Value == null)
                this.dgvListado["Cantidad_esp_sub_2", indiceFila].Value = "0";
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IndiceFila = this.dgvListado.CurrentRow.Index;

            int indiceColumna = this.dgvListado.CurrentCell.ColumnIndex;
            string nombreColumna = this.dgvListado.Columns[indiceColumna].Name;
            InsertarFilaGrilla(IndiceFila, nombreColumna);

            string colName = this.dgvListado.Columns[e.ColumnIndex].Name;
            if (colName == "BON_fecha_vencimiento")
            {
                Point punto = Cursor.Position;
                frm_EstablecerFecha o = new frm_EstablecerFecha(punto, "bonificaciones");

                DialogResult respuesta = o.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    this.dgvListado["BON_fecha_vencimiento", e.RowIndex].Value = o.pk;
                    this.dgvListado.RefreshEdit();
                }
            }
        }

        private void validarGrilla()
        {
            for (int i = 0; i < this.dgvListado.RowCount - 1; i++)
            {
                if (this.dgvListado["PRO_codigo_1", i].Value == null)
                {
                    this.dgvListado.Rows.RemoveAt(i);
                }
            }
        }
        
        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.dgvListado.Rows.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.dgvListado.Rows.Add();

                    this.dgvListado["BON_is_especial", i].Value = dt.Rows[i]["BON_is_especial"].ToString();

                    this.dgvListado["PRO_codigo_1", i].Value = dt.Rows[i]["PRO_codigo"].ToString();
                    this.dgvListado["PRO_descripcion_1", i].Value = dt.Rows[i]["PRO_descripcion"].ToString();
                    this.dgvListado["Cantidad_1", i].Value = dt.Rows[i]["BON_cantidad_req"].ToString();
                    this.dgvListado["Cantidad_sub_1", i].Value = dt.Rows[i]["BON_cantidad_req_submultiplo"].ToString();

                    this.dgvListado["PRO_codigo_2", i].Value = dt.Rows[i]["BON_producto"].ToString();
                    this.dgvListado["PRO_descripcion_2", i].Value = dt.Rows[i]["BON_pro_descripcion"].ToString();
                    this.dgvListado["Cantidad_2", i].Value = dt.Rows[i]["BON_cantidad_boni"].ToString();
                    this.dgvListado["Cantidad_sub_2", i].Value = dt.Rows[i]["BON_cantidad_boni_submultiplo"].ToString();
                    this.dgvListado["Cantidad_esp_2", i].Value = dt.Rows[i]["BON_esp_cantidad_boni"].ToString();
                    this.dgvListado["Cantidad_esp_sub_2", i].Value = dt.Rows[i]["BON_esp_cantidad_boni_submultiplo"].ToString();

                    this.dgvListado["BON_fecha_vencimiento", i].Value = dt.Rows[i]["BON_fecha_vencimiento"].ToString();
                }
            }
            else
            {
                this.dgvListado.Rows.Clear();
            }
        }

        private void eliminarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvListado.Rows[this.rowIndex].IsNewRow)
            {
                this.dgvListado.Rows.RemoveAt(this.rowIndex);
            }
        }

        private int rowIndex = 0;
        private void dgvListado_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                this.dgvListado.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvListado.CurrentCell = this.dgvListado.Rows[e.RowIndex].Cells[1];
                this.menuContextual.Show(this.dgvListado, e.Location);
                menuContextual.Show(Cursor.Position);
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvListado_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        private void dgvListado_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            _cfgUtil.enumerarFilasDatagridview(this.dgvListado, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
        }

        private void cmbCanal_SelectedIndexChanged(object sender, EventArgs e)
        {
            eCANAL oeCANAL = new eCANAL();
            oeCANAL.CAN_codigo = this.cmbCanal.SelectedValue.ToString();
            cargarDatos(balBONIFICACION.mostrarBonificacionPorGrupo(oeCANAL));
        }

        private void cmbCanal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eCANAL oeCANAL = new eCANAL();
            oeCANAL.CAN_codigo = this.cmbCanal.SelectedValue.ToString();
            cargarDatos(balBONIFICACION.mostrarBonificacionPorGrupo(oeCANAL));
        }

        private void btnGoCanal_Click(object sender, EventArgs e)
        {
            eCANAL o = new eCANAL();
            o.CAN_codigo = this.cmbCanal.SelectedValue != null ? this.cmbCanal.SelectedValue.ToString() : "";

            frmDM_Canal o2 = new frmDM_Canal(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvListado.Columns["PRO_descripcion_1"].Index)
            {
                int columna_codigo1 = this.dgvListado.Columns["PRO_codigo_1"].Index;
                string codigo = this.dgvListado[columna_codigo1, e.RowIndex].Value.ToString();
                ePRODUCTO o = new ePRODUCTO();
                o.PRO_codigo = codigo.Length > 0 ? codigo : "";

                frmDM_Producto o2 = new frmDM_Producto(o);
                o2.MdiParent = this.MdiParent;
                o2.Show();
            }
            if (e.ColumnIndex == this.dgvListado.Columns["PRO_descripcion_2"].Index)
            {
                int columna_codigo2 = this.dgvListado.Columns["PRO_codigo_2"].Index;
                string codigo = this.dgvListado[columna_codigo2, e.RowIndex].Value.ToString();
                ePRODUCTO o = new ePRODUCTO();
                o.PRO_codigo = codigo.Length > 0 ? codigo : "";

                frmDM_Producto o2 = new frmDM_Producto(o);
                o2.MdiParent = this.MdiParent;
                o2.Show();
            }
        }

        private void dgvListado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvListado.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dgvListado.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvListado_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvListado.RowCount > 0)
            {
                if (this.dgvListado.Columns["BON_is_especial"] != null)
                {
                    if (e.ColumnIndex == this.dgvListado.Columns["BON_is_especial"].Index)
                    {
                        formatearGrilla();
                    }
                }
            }
        }

        private void formatearGrilla()
        {
            foreach (DataGridViewRow fila in this.dgvListado.Rows)
            {
                string valor = this.dgvListado["BON_is_especial", fila.Index].Value != null ? this.dgvListado["BON_is_especial", fila.Index].Value.ToString() : "N";
                if (valor == "S")
                {
                    dgvListado.Rows[fila.Index].Cells["Cantidad_2"].Style.Font = new Font(this.dgvListado.Font, FontStyle.Regular);
                    dgvListado.Rows[fila.Index].Cells["Cantidad_sub_2"].Style.Font = new Font(this.dgvListado.Font, FontStyle.Regular);
                    dgvListado.Rows[fila.Index].Cells["Cantidad_esp_2"].Style.Font = new Font(this.dgvListado.Font, FontStyle.Bold);
                    dgvListado.Rows[fila.Index].Cells["Cantidad_esp_sub_2"].Style.Font = new Font(this.dgvListado.Font, FontStyle.Bold);
                }
                else
                {
                    dgvListado.Rows[fila.Index].Cells["Cantidad_2"].Style.Font = new Font(this.dgvListado.Font, FontStyle.Bold);
                    dgvListado.Rows[fila.Index].Cells["Cantidad_sub_2"].Style.Font = new Font(this.dgvListado.Font, FontStyle.Bold);
                    dgvListado.Rows[fila.Index].Cells["Cantidad_esp_2"].Style.Font = new Font(this.dgvListado.Font, FontStyle.Regular);
                    dgvListado.Rows[fila.Index].Cells["Cantidad_esp_sub_2"].Style.Font = new Font(this.dgvListado.Font, FontStyle.Regular);
                }
            }
        }

        private void dgvListado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            formatearGrilla();
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
