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
    public partial class frmOP_Pago : _frmBaseTB
    {
        public frmOP_Pago()
        {
            InitializeComponent();

            this.btnGuardar.Text = "Pagar";

            this.cmbTipoVenta.DisplayMember = "TVE_descripcion";
            this.cmbTipoVenta.ValueMember = "TVE_codigo";
            this.cmbTipoVenta.DataSource = balTIPO_VENTA.poblar();

            this.cmbChofer.DisplayMember = "CHO_nombre_completo";
            this.cmbChofer.ValueMember = "CHO_codigo";
            this.cmbChofer.DataSource = balCHOFER.poblar();

            DataGridViewComboBoxColumn col = dgvPago.Columns["MPA_nombre"] as DataGridViewComboBoxColumn;
            col.DataSource = balMETODO_PAGO.poblar();
            col.DisplayMember = "MPA_nombre";
            col.ValueMember = "MPA_codigo";

            this.dgvSerie.DataSource = balSERIE.poblar();
            this.dgvCondicionPago.DataSource = balCONDICION_PAGO.poblar();

            this.dgvPago.Columns["Monto_pago"].ValueType = Type.GetType("System.Decimal");
        }

        private void frmOP_Pago_Load(object sender, EventArgs e)
        {
            this.chkTodoSerie.Checked = true;
            this.chkTodoCondicionPago.Checked = true;
        }

        private void cmbTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoVenta.Text == "PREVENTA")
            {
                this.label6.Visible = true;
                this.cmbChofer.Visible = true;
                this.btnGoChofer.Visible = true;
            }
            else
            {
                this.label6.Visible = false;
                this.cmbChofer.Visible = false;
                this.btnGoChofer.Visible = false;
            }
        }

        private void chkTodoSerie_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodoSerie.Checked)
            {
                foreach (DataGridViewRow fila in this.dgvSerie.Rows)
                {
                    this.dgvSerie["check", fila.Index].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow fila in this.dgvSerie.Rows)
                {
                    this.dgvSerie["check", fila.Index].Value = false;
                }
            }
        }

        private void chkTodoCondicionPago_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodoCondicionPago.Checked)
            {
                foreach (DataGridViewRow fila in this.dgvCondicionPago.Rows)
                {
                    this.dgvCondicionPago["check2", fila.Index].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow fila in this.dgvCondicionPago.Rows)
                {
                    this.dgvCondicionPago["check2", fila.Index].Value = false;
                }
            }
        }

        private void btnCargarDocumentos_Click(object sender, EventArgs e)
        {
            mostrarFilas();
            calcularSumas();
            bloquearFilas();
        }

        private void chkSeleccionarTodosPago_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionarTodosPago.Checked)
            {
                foreach (DataGridViewRow fila in this.dgvPago.Rows)
                {
                    if (this.dgvPago["VTA_estado", fila.Index].Value.ToString() == "ABIERTO")
                        this.dgvPago["checkPago", fila.Index].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow fila in this.dgvPago.Rows)
                {
                    if (this.dgvPago["VTA_estado", fila.Index].Value.ToString() == "ABIERTO")
                        this.dgvPago["checkPago", fila.Index].Value = false;
                }
            }
        }

        public override void Guardar()
        {
            bloquearFilas();

            int contadorInsertadosCorrectos = 0;
            int contadorInsertadosIncorrectos = 0;

            foreach (DataGridViewRow fila in this.dgvPago.Rows)
            {
                if (fila.Cells["checkPago"].Value != null)
                {
                    if (fila.Cells["checkPago"].Value.ToString() == "True")
                    {
                        ePAGO oePAGO = new ePAGO();
                        oePAGO.VTA_serie_correlativo = fila.Cells["VTA_serie_correlativo"].Value.ToString();
                        oePAGO.PAG_abono = Convert.ToDouble(fila.Cells["Monto_pago"].Value.ToString());
                        oePAGO.PAG_referencia = fila.Cells["PAG_referencia"].Value != null ? fila.Cells["PAG_referencia"].Value.ToString() : "";
                        oePAGO.MPA_codigo = fila.Cells["MPA_nombre"].Value != null ? fila.Cells["MPA_nombre"].Value.ToString() : "EFE";

                        if (balPAGO.pagarDocumento(oePAGO))
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
            mensaje("guardar", contadorInsertadosCorrectos, contadorInsertadosIncorrectos);
            //MessageBox.Show("Se actualizaron los " + contadorInsertadosCorrectos + " registros en la tabla de pagos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mostrarFilas();
            calcularSumas();
            bloquearFilas();
        }

        private void dgvPago_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvPago.IsCurrentCellDirty)
                dgvPago.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvPago_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvPago.RowCount > 0)
            {
                calcularSumas();
            }
        }

        private void mostrarFilas()
        {
            DateTime desde = Convert.ToDateTime(this.dtpDesde.Value.ToShortDateString());
            DateTime hasta = Convert.ToDateTime(this.dtpHasta.Value.ToShortDateString());
            eVENTA oeVENTA = new eVENTA();
            oeVENTA.TVE_codigo = this.cmbTipoVenta.SelectedValue.ToString();
            oeVENTA.CHO_codigo = Convert.ToInt32(this.cmbChofer.SelectedValue.ToString());
            string isSoloAbiertos = this.chkSoloAbiertos.Checked ? "S" : "N";

            DataTable series = new DataTable();
            series.Columns.Add("Value");

            foreach (DataGridViewRow fila in this.dgvSerie.Rows)
            {
                if (Convert.ToBoolean(fila.Cells["Check"].Value) == true)
                {
                    string serieFila = fila.Cells["SER_serie"].Value.ToString();
                    series.Rows.Add(serieFila);
                }
            }

            DataTable condicionesPago = new DataTable();
            condicionesPago.Columns.Add("Value");

            DataTable dtt = new DataTable();
            dtt.Columns.Add("VTA_serie_correlativo");
            dtt.Columns.Add("SOC_codigo");
            dtt.Columns.Add("SOC_nombre_razon_social");
            dtt.Columns.Add("VTA_fecha_vencimiento");
            dtt.Columns.Add("VTA_monto_total");
            dtt.Columns.Add("Pendiente_pago");
            dtt.Columns.Add("Monto_pago");
            dtt.Columns.Add("VTA_estado");
            dtt.Columns.Add("MPA_nombre");
            //dtt.Columns.Add("PAG_referencia");

            foreach (DataGridViewRow fila in this.dgvCondicionPago.Rows)
            {
                if (Convert.ToBoolean(fila.Cells["Check2"].Value) == true)
                {
                    string serieFila = fila.Cells["CPA_codigo"].Value.ToString();
                    condicionesPago.Rows.Add(serieFila);
                }
            }

            DataTable dt = balPAGO.mostrarListadoPagos(desde, hasta, oeVENTA, series, condicionesPago, isSoloAbiertos);
            if (dt != null)
            {
                this.dgvPago.DataSource = balPAGO.mostrarListadoPagos(desde, hasta, oeVENTA, series, condicionesPago, isSoloAbiertos);
            }
            else
            {
                this.dgvPago.DataSource = dtt;
            }
        }

        private void calcularSumas()
        {
            double totalTablaPendientes = 0;
            double totalFilasPendientes = 0;
            double totalFilasAbonos = 0;

            int cantidadFilas = 0;
            int cantidadFilasSeleccionadas = 0;
            
            foreach (DataGridViewRow fila in this.dgvPago.Rows)
            {
                totalTablaPendientes += Convert.ToDouble(fila.Cells["Pendiente_pago"].Value);
                cantidadFilas++;

                if (fila.Cells["checkPago"].Value != null && fila.Cells["checkPago"].Value.ToString() == "True")
                {
                    totalFilasPendientes += Convert.ToDouble(fila.Cells["Pendiente_pago"].Value);
                    totalFilasAbonos += Convert.ToDouble(fila.Cells["Monto_pago"].Value);

                    cantidadFilasSeleccionadas++;
                }
            }
            this.txtTotalTablaPendientes.Text = totalTablaPendientes.ToString();
            this.txtTotalFilasPendientes.Text = totalFilasPendientes.ToString();
            this.txtTotalFilasAbonos.Text = totalFilasAbonos.ToString();

            this.lblCantidadFilas.Text = cantidadFilas.ToString() + " filas.";
            this.lblCantidadFilasSeleccionadas.Text = cantidadFilasSeleccionadas.ToString() + " filas seleccionadas.";
        }
        
        private void bloquearFilas()
        {
            foreach (DataGridViewRow fila in this.dgvPago.Rows)
            {
                if (fila.Cells["VTA_estado"].Value != null && fila.Cells["VTA_estado"].Value.ToString() == "PAGADO")
                {
                    fila.ReadOnly = true;
                    fila.DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark;
                }
                else
                {
                    if (Convert.ToDouble(fila.Cells["Monto_pago"].Value.ToString()) > Convert.ToDouble(fila.Cells["Pendiente_pago"].Value.ToString()))
                    {
                        fila.Cells["Monto_pago"].Value = fila.Cells["Pendiente_pago"].Value.ToString();
                    }
                }
            }
        }
        
        private void txtTotalTablaPendientes_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalTablaPendientes.Text.Length > 0)
                txtTotalTablaPendientes.Text = string.Format("{0:#,##0.00}", double.Parse(txtTotalTablaPendientes.Text));
        }

        private void txtTotalFilasPendientes_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalFilasPendientes.Text.Length > 0)
                txtTotalFilasPendientes.Text = string.Format("{0:#,##0.00}", double.Parse(txtTotalFilasPendientes.Text));
        }

        private void txtTotalFilasAbonos_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalFilasAbonos.Text.Length > 0)
                txtTotalFilasAbonos.Text = string.Format("{0:#,##0.00}", double.Parse(txtTotalFilasAbonos.Text));
        }

        private void btnGoTipoVenta_Click(object sender, EventArgs e)
        {
            eTIPO_VENTA o = new eTIPO_VENTA();
            o.TVE_codigo = this.cmbTipoVenta.SelectedValue != null ? this.cmbTipoVenta.SelectedValue.ToString() : "";

            frmDM_TipoVenta o2 = new frmDM_TipoVenta(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoChofer_Click(object sender, EventArgs e)
        {
            eCHOFER o = new eCHOFER();
            o.CHO_codigo = this.cmbChofer.SelectedValue != null ? Convert.ToInt32(this.cmbChofer.SelectedValue.ToString()) : -1;

            frmDM_Chofer o2 = new frmDM_Chofer(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void dgvPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvPago.Columns["VTA_serie_correlativo"].Index)
            {                
                string correlativo = this.dgvPago[e.ColumnIndex, e.RowIndex].Value.ToString();
                eVENTA o = new eVENTA();
                o.VTA_serie_correlativo = correlativo;
                
                frmOP_Venta o2 = new frmOP_Venta(o);
                o2.MdiParent = this.MdiParent;
                o2.Show();
            }
        }

        //Refresco de combobox
        private void cmbChofer_DropDown(object sender, EventArgs e)
        {
            int valorSeleccionado = -1;
            if (this.cmbChofer.SelectedValue != null)
            {
                valorSeleccionado = Convert.ToInt32(this.cmbChofer.SelectedValue.ToString());
            }
            this.cmbChofer.DataSource = balCHOFER.poblar();
            this.cmbChofer.SelectedValue = valorSeleccionado;            
        }

        private void cmbTipoVenta_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbTipoVenta.SelectedValue != null)
            {
                valorSeleccionado = this.cmbTipoVenta.SelectedValue.ToString();
            }
            this.cmbTipoVenta.DataSource = balTIPO_VENTA.poblar();
            this.cmbTipoVenta.SelectedValue = valorSeleccionado;

        }
    }
}
