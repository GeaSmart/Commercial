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
    public partial class frmOP_GeneracionDocumentos : DevComponents.DotNetBar.Metro.MetroForm
    {
        ePEDIDO oePEDIDO = new ePEDIDO();

        public frmOP_GeneracionDocumentos()
        {
            InitializeComponent();
            
            this.cmbTipoDocumento.ValueMember = "TDO_codigo";
            this.cmbTipoDocumento.DisplayMember = "TDO_nombre";
            this.cmbTipoDocumento.DataSource = balTIPO_DOCUMENTO.poblar();

            eSERIE oeSERIE = new eSERIE();
            oeSERIE.TDO_codigo = this.cmbTipoDocumento.SelectedValue.ToString();
            ePEDIDO oePEDIDO = new ePEDIDO();
            oePEDIDO.PED_fecha = Convert.ToDateTime(this.dtpFecha.Value.ToShortDateString());
            
            this.cmbSerie.ValueMember = "SER_serie";
            this.cmbSerie.DisplayMember = "SER_serie";
            this.cmbSerie.DataSource = balSERIE.obtenerSeriesPorTipoDocumento(oeSERIE,oePEDIDO);
        }

        private void frmOP_GeneracionDocumentos_Load(object sender, EventArgs e)
        {
            this.btnGenerar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("PEDIDO_GENERAR"), (SharedData.Instance().Reglas ?? ""));
            this.dgvOrigen.DataSource = dataOrigen();
            cargarDataDestino();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            this.dgvOrigen.DataSource = dataOrigen();
            cargarDataDestino();
        }

        private void dtpFecha_CloseUp(object sender, EventArgs e)
        {
            this.dgvOrigen.DataSource = dataOrigen();
            cargarDataDestino();
        }
        
        private void cmbTipoDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarDataDestino();
        }

        private void cmbSerie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarDataDestino();
        }

        private DataTable dataOrigen()
        {
            ePEDIDO oePEDIDO = new ePEDIDO();
            oePEDIDO.PED_fecha = Convert.ToDateTime(this.dtpFecha.Value.ToShortDateString());
            return balPEDIDO.obtenerInformacionGeneracion(oePEDIDO);
        }

        private void cargarDataDestino()
        {
            eSERIE oeSERIE = new eSERIE();
            oeSERIE.TDO_codigo = this.cmbTipoDocumento.SelectedValue.ToString();
            ePEDIDO oePEDIDO = new ePEDIDO();
            oePEDIDO.PED_fecha = Convert.ToDateTime(this.dtpFecha.Value.ToShortDateString());

            this.cmbSerie.ValueMember = "SER_serie";
            this.cmbSerie.DisplayMember = "SER_serie";
            this.cmbSerie.DataSource = balSERIE.obtenerSeriesPorTipoDocumento(oeSERIE, oePEDIDO);

            this.txtCantidadDocumentos.Text = balSERIE.obtenerSeriesPorTipoDocumento(oeSERIE, oePEDIDO).Rows[0]["CantidadDocumentos"].ToString();

            if (this.chkReasignacion.Checked)
            {
                this.txtCorrelativoInicial.Text = balSERIE.obtenerSeriesPorTipoDocumento(oeSERIE, oePEDIDO).Rows[0]["PrimerCorrPrev"].ToString();                
            }
            else
            {
                this.txtCorrelativoInicial.Text = balSERIE.obtenerSeriesPorTipoDocumento(oeSERIE, oePEDIDO).Rows[0]["PrimerCorrDisp"].ToString();
            }            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ePEDIDO oePEDIDO = new ePEDIDO();
            oePEDIDO.PED_fecha = Convert.ToDateTime(this.dtpFecha.Value.ToShortDateString());
            oePEDIDO.PED_fecha_entrega = Convert.ToDateTime(this.dtpFechaEntrega.Value.ToShortDateString());
            oePEDIDO.PED_tdo_codigo = this.cmbTipoDocumento.SelectedValue.ToString();
            string serie = this.cmbSerie.SelectedValue.ToString();
            int correlativoInicial = Convert.ToInt32(this.txtCorrelativoInicial.Text);
            
            int nro = balPEDIDO.generarDocumentosVenta(oePEDIDO, serie, correlativoInicial);

            MessageBox.Show("Se han generado correctamente los " + nro + " documentos de venta.","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);

            this.dgvOrigen.DataSource = dataOrigen();
            cargarDataDestino();
            checkGroupbox();
        }

        private void chkReasignacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReasignacion.Checked)
            {
                this.txtCorrelativoInicial.ReadOnly = false;
                this.gpbDestino.Enabled = true;
            }
            else
            {
                this.txtCorrelativoInicial.ReadOnly = true;
                this.gpbDestino.Enabled = false;
            }

            //this.dgvOrigen.DataSource = dataOrigen();
            cargarDataDestino();
        }

        private void SumaPedidos()
        {
            this.txtSumaPedidos.Text = "0";
            this.txtSumaPedidosAbiertos.Text = "0";

            int sumaPedidos = 0;
            int sumaPedidosAbiertos = 0;
            for (int i = 0; i < this.dgvOrigen.RowCount; i++)
            {
                sumaPedidosAbiertos += Convert.ToInt16(this.dgvOrigen.Rows[i].Cells["Abierto"].Value.ToString());
                sumaPedidos += Convert.ToInt16(this.dgvOrigen.Rows[i].Cells["Cerrado"].Value.ToString());                
            }
            this.txtSumaPedidos.Text = sumaPedidos.ToString();
            this.txtSumaPedidosAbiertos.Text = sumaPedidosAbiertos.ToString();
        }

        private void dgvOrigen_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SumaPedidos();
            checkGroupbox();
        }

        private void checkGroupbox()
        {
            this.chkReasignacion.Checked = false;
            if (!(Convert.ToInt16(this.txtSumaPedidosAbiertos.Text) > 0))
            {
                this.gpbDestino.Enabled = false;
            }
            else
            {
                this.gpbDestino.Enabled = true;
            }
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtLabeDocumento.Text = this.cmbTipoDocumento.Text;
        }

        private void cmbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDataDestino();
        }

        int i = 0;
        private void frmOP_GeneracionDocumentos_VisibleChanged(object sender, EventArgs e)
        {
            i++;
            if (!balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("PEDIDO_GENERACION_VER"), (SharedData.Instance().Reglas ?? "")) && (i == 1))
            {
                this.Close();
                MessageBox.Show("Su usuario no tiene permiso para ver este formulario.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGoTipoDocumento_Click(object sender, EventArgs e)
        {
            eTIPO_DOCUMENTO o = new eTIPO_DOCUMENTO();
            o.TDO_codigo = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";

            frmDM_TipoDocumento o2 = new frmDM_TipoDocumento(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoSerie_Click(object sender, EventArgs e)
        {
            eSERIE o = new eSERIE();
            o.SER_serie = this.cmbSerie.SelectedValue != null ? this.cmbSerie.SelectedValue.ToString() : "";
            o.TDO_codigo = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";

            frmDM_Serie o2 = new frmDM_Serie(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        //Refresco de combobox
        private void cmbTipoDocumento_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbTipoDocumento.SelectedValue != null)
            {
                valorSeleccionado = this.cmbTipoDocumento.SelectedValue.ToString();
            }
            this.cmbTipoDocumento.DataSource = balTIPO_DOCUMENTO.poblar();
            this.cmbTipoDocumento.SelectedValue = valorSeleccionado;

        }

        private void cmbSerie_DropDown(object sender, EventArgs e)
        {
            eSERIE oeSERIE = new eSERIE();
            oeSERIE.TDO_codigo = this.cmbTipoDocumento.SelectedValue.ToString();
            ePEDIDO oePEDIDO = new ePEDIDO();
            oePEDIDO.PED_fecha = Convert.ToDateTime(this.dtpFecha.Value.ToShortDateString());

            string valorSeleccionado = "";
            if (this.cmbSerie.SelectedValue != null)
            {
                valorSeleccionado = this.cmbSerie.SelectedValue.ToString();
            }
            this.cmbSerie.DataSource = balSERIE.obtenerSeriesPorTipoDocumento(oeSERIE, oePEDIDO);
            this.cmbSerie.SelectedValue = valorSeleccionado;
        }
    }
}
