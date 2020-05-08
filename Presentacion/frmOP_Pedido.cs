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
    public partial class frmOP_Pedido : _frmBaseOP
    {
        ePEDIDO _o;
        //variables de entorno
        string _listaPrecio = "";
        string _canal = "";
        string _isPercepcion = "N";
        double _porcentajePercepcion = 0.00;
        int _zona = 0;

        double _IGVGrilla = 0;
        double _ISCGrilla = 0;

        //private eSOCIO _oeSOCIO;
        private balSOCIO _obalSOCIO = new balSOCIO();
        
        private balPRODUCTO _obalPRODUCTO = new balPRODUCTO();
        
        private balSERIE _obalSERIE = new balSERIE();

        private bool isCrearNuevo = false;

        public frmOP_Pedido(ePEDIDO o)
        {
            InitializeComponent();
            tabla = "PEDIDO";

            this.cmbCodigoVendedor.ValueMember = "VEN_codigo";
            this.cmbCodigoVendedor.DisplayMember = "VEN_nombre_completo";
            this.cmbCodigoVendedor.DataSource = balVENDEDOR.poblar();
            
            this.cmbCondicionPago.ValueMember = "CPA_codigo";
            this.cmbCondicionPago.DisplayMember = "CPA_descripcion";
            this.cmbCondicionPago.DataSource = balCONDICION_PAGO.poblar();

            this.cmbTipoDocumento.ValueMember = "TDO_codigo";
            this.cmbTipoDocumento.DisplayMember = "TDO_nombre";
            this.cmbTipoDocumento.DataSource = balTIPO_DOCUMENTO.poblar();

            this._o = o;
        }

        private void frmOP_Venta_Load(object sender, EventArgs e)
        {
            Ultimo();

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balPEDIDO.obtenerRegistro(_o)); }
            balProgram.sincronizarDescuentosEspeciales();
            balProgram.sincronizarBonificacionesEspeciales();
        }

        public override void Crear()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.dgvDetalle.Rows.Clear();
            this.cmbEstado.Text = "ABIERTO";
            this.btnSocioNegocio.Focus();
            isCrearNuevo = true;
        }

        public override bool Guardar()
        {
            bool rpta = false;
            double montoigv, montoisc, subtotal, totalLinea;
            try
            {
                int u;
                double d;

                ePEDIDO oePEDIDO = new ePEDIDO();
                oePEDIDO.PED_numero = Int32.TryParse(this.txtNumeroPedido.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumeroPedido.Text.Trim()) : -1;
                oePEDIDO.PED_fecha = Convert.ToDateTime(this.dtpFechaPedido.Value.ToShortDateString());
                oePEDIDO.PED_fecha_entrega = Convert.ToDateTime(this.dtpFechaEntrega.Value.ToShortDateString());
                oePEDIDO.VEN_codigo = this.cmbCodigoVendedor.SelectedValue != null ? (Int32.TryParse(this.cmbCodigoVendedor.SelectedValue.ToString(), out u) ? Convert.ToInt32(this.cmbCodigoVendedor.SelectedValue.ToString()) : -1) : -1;
                oePEDIDO.PED_nombre_vendedor = String.IsNullOrWhiteSpace(this.cmbCodigoVendedor.Text.Trim()) ? null : this.cmbCodigoVendedor.Text.Trim();
                oePEDIDO.SOC_codigo = Int32.TryParse(this.txtCodigoSocio.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigoSocio.Text.Trim()) : -1;
                oePEDIDO.PED_soc_nombre_razon = String.IsNullOrWhiteSpace(this.txtNombreSocio.Text.Trim()) ? "" : this.txtNombreSocio.Text.Trim();
                oePEDIDO.PED_soc_direccion = String.IsNullOrWhiteSpace(this.txtNombreSocio.Text.Trim()) ? "" : this.txtNombreSocio.Text.Trim();
                oePEDIDO.PED_soc_zona = _zona;
                oePEDIDO.PED_subtotal = Double.TryParse(this.txtSubtotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtSubtotal.Text.Trim()) : -1;                
                oePEDIDO.PED_porcentaje_percepcion = _porcentajePercepcion;
                oePEDIDO.PED_monto_igv = _IGVGrilla;
                oePEDIDO.PED_monto_isc = _ISCGrilla;
                oePEDIDO.PED_monto_percepcion = Double.TryParse(this.txtPercepcion.Text.Trim(), out d) ? Convert.ToDouble(this.txtPercepcion.Text.Trim()) : -1;
                oePEDIDO.PED_monto_total = Double.TryParse(this.txtMontoTotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtMontoTotal.Text.Trim()) : -1;
                oePEDIDO.PED_comentario = this.txtComentario.Text;
                oePEDIDO.PED_estado = "A";
                oePEDIDO.CPA_codigo = this.cmbCondicionPago.SelectedValue != null ? this.cmbCondicionPago.SelectedValue.ToString() : "";
                oePEDIDO.PED_tdo_codigo = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";
                //oePEDIDO.PED_tdo_codigo = String.IsNullOrWhiteSpace(this.menuContextual2.Items["DocVenta"].Text.Trim()) ? "" : this.menuContextual2.Items["DocVenta"].Text.Trim();

                List<eDETALLE_PEDIDO> List = new List<eDETALLE_PEDIDO>();
                for (int i = 0; i < this.dgvDetalle.RowCount - 1; i++)
                {
                    montoigv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim()) : -1;
                    montoisc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim()) : -1;
                    subtotal = Double.TryParse(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim()) : -1;
                    totalLinea = subtotal + montoigv + montoisc;

                    eDETALLE_PEDIDO oeDETALLE_PEDIDO = new eDETALLE_PEDIDO();
                    oeDETALLE_PEDIDO.PED_numero = Int32.TryParse(this.txtNumeroPedido.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumeroPedido.Text.Trim()) : -1;
                    oeDETALLE_PEDIDO.PRO_codigo = (this.dgvDetalle.Rows[i].Cells["PRO_codigo"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    oeDETALLE_PEDIDO.DPE_is_bonificacion = (this.dgvDetalle.Rows[i].Cells["DPE_is_bonificacion"].Value.ToString().Substring(0, 1) ?? "N").ToString().ToUpper().Trim();
                    oeDETALLE_PEDIDO.DPE_pro_descripcion = (this.dgvDetalle.Rows[i].Cells["PRO_descripcion"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    oeDETALLE_PEDIDO.DPE_pro_ume_multiplo = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_cantidad = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DPE_cantidad"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DPE_cantidad"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_cantidad_submultiplo = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DPE_cantidad_submultiplo"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DPE_cantidad_submultiplo"].Value.ToString().Trim()) : (int?)null;
                    oeDETALLE_PEDIDO.DPE_precio_unitario = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DPE_precio_unitario"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPE_precio_unitario"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_monto_subtotal = subtotal;
                    oeDETALLE_PEDIDO.DPE_monto_descuento = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DPE_monto_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPE_monto_descuento"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_porcentaje_descuento = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DPE_porcentaje_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPE_porcentaje_descuento"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_monto_igv = montoigv;
                    oeDETALLE_PEDIDO.DPE_monto_isc = montoisc;
                    oeDETALLE_PEDIDO.DPE_porcentaje_igv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_porcentaje_isc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_monto_total_linea = subtotal + montoigv + montoisc;
                    oeDETALLE_PEDIDO.DPE_memo = "";
                    oeDETALLE_PEDIDO.DPE_numero_fila = i + 1;

                    List.Add(oeDETALLE_PEDIDO);
                }

                if (checkGrilla())
                {
                    if (balPEDIDO.insertarRegistroMaestroDetalle(oePEDIDO, List))
                    {
                        mensaje("guardar");
                        //MessageBox.Show("El registro fue guardado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rpta = true;
                    }
                }
                else
                {
                    MessageBox.Show("Corrija errores en las lineas detalle.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ocurrió un error inesperado:\r\n" + ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            return rpta;
        }

        public override bool Actualizar()
        {
            bool rpta = false;
            double montoigv, montoisc, subtotal, totalLinea;
            try
            {
                int u;
                double d;

                ePEDIDO oePEDIDO = new ePEDIDO();
                oePEDIDO.PED_numero = Int32.TryParse(this.txtNumeroPedido.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumeroPedido.Text.Trim()) : -1;
                oePEDIDO.PED_fecha = Convert.ToDateTime(this.dtpFechaPedido.Value.ToShortDateString());
                oePEDIDO.PED_fecha_entrega = Convert.ToDateTime(this.dtpFechaEntrega.Value.ToShortDateString());
                oePEDIDO.VEN_codigo = this.cmbCodigoVendedor.SelectedValue != null ? (Int32.TryParse(this.cmbCodigoVendedor.SelectedValue.ToString(), out u) ? Convert.ToInt32(this.cmbCodigoVendedor.SelectedValue.ToString()) : -1) : -1;
                oePEDIDO.PED_nombre_vendedor = String.IsNullOrWhiteSpace(this.cmbCodigoVendedor.Text.Trim()) ? null : this.cmbCodigoVendedor.Text.Trim();
                oePEDIDO.SOC_codigo = Int32.TryParse(this.txtCodigoSocio.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigoSocio.Text.Trim()) : -1;
                oePEDIDO.PED_soc_nombre_razon = String.IsNullOrWhiteSpace(this.txtNombreSocio.Text.Trim()) ? "" : this.txtNombreSocio.Text.Trim();
                oePEDIDO.PED_soc_direccion = String.IsNullOrWhiteSpace(this.txtNombreSocio.Text.Trim()) ? "" : this.txtNombreSocio.Text.Trim();
                oePEDIDO.PED_soc_zona = _zona;
                oePEDIDO.PED_subtotal = Double.TryParse(this.txtSubtotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtSubtotal.Text.Trim()) : -1;                
                oePEDIDO.PED_porcentaje_percepcion = _porcentajePercepcion;
                oePEDIDO.PED_monto_igv = _IGVGrilla;
                oePEDIDO.PED_monto_isc = _ISCGrilla;
                oePEDIDO.PED_monto_percepcion = Double.TryParse(this.txtPercepcion.Text.Trim(), out d) ? Convert.ToDouble(this.txtPercepcion.Text.Trim()) : -1;
                oePEDIDO.PED_monto_total = Double.TryParse(this.txtMontoTotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtMontoTotal.Text.Trim()) : -1;
                oePEDIDO.PED_comentario = this.txtComentario.Text;

                string estado = "";
                switch (this.cmbEstado.Text)
                {
                    case "ABIERTO": estado = "A"; break;
                    case "CERRADO": estado = "C"; break;
                    case "ANULADO": estado = "N"; break;
                }

                oePEDIDO.PED_estado = estado;

                oePEDIDO.CPA_codigo = this.cmbCondicionPago.SelectedValue != null ? this.cmbCondicionPago.SelectedValue.ToString() : "";
                //oePEDIDO.PED_tdo_codigo = String.IsNullOrWhiteSpace(this.menuContextual2.Items["DocVenta"].Text.Trim()) ? "" : this.menuContextual2.Items["DocVenta"].Text.Trim();
                oePEDIDO.PED_tdo_codigo = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";

                List<eDETALLE_PEDIDO> List = new List<eDETALLE_PEDIDO>();
                for (int i = 0; i < this.dgvDetalle.RowCount - 1; i++)
                {
                    montoigv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim()) : -1;
                    montoisc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim()) : -1;
                    subtotal = Double.TryParse(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim()) : -1;
                    totalLinea = subtotal + montoigv + montoisc;

                    eDETALLE_PEDIDO oeDETALLE_PEDIDO = new eDETALLE_PEDIDO();
                    oeDETALLE_PEDIDO.PED_numero = Int32.TryParse(this.txtNumeroPedido.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumeroPedido.Text.Trim()) : -1;
                    oeDETALLE_PEDIDO.PRO_codigo = (this.dgvDetalle.Rows[i].Cells["PRO_codigo"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    oeDETALLE_PEDIDO.DPE_is_bonificacion = (this.dgvDetalle.Rows[i].Cells["DPE_is_bonificacion"].Value.ToString().Substring(0, 1) ?? "N").ToString().ToUpper().Trim();
                    oeDETALLE_PEDIDO.DPE_pro_descripcion = (this.dgvDetalle.Rows[i].Cells["PRO_descripcion"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    oeDETALLE_PEDIDO.DPE_pro_ume_multiplo = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_cantidad = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DPE_cantidad"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DPE_cantidad"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_cantidad_submultiplo = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DPE_cantidad_submultiplo"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DPE_cantidad_submultiplo"].Value.ToString().Trim()) : (int?)null;
                    oeDETALLE_PEDIDO.DPE_precio_unitario = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DPE_precio_unitario"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPE_precio_unitario"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_monto_subtotal = subtotal;
                    oeDETALLE_PEDIDO.DPE_monto_descuento = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DPE_monto_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPE_monto_descuento"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_porcentaje_descuento = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DPE_porcentaje_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPE_porcentaje_descuento"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_monto_igv = montoigv;
                    oeDETALLE_PEDIDO.DPE_monto_isc = montoisc;
                    oeDETALLE_PEDIDO.DPE_porcentaje_igv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_porcentaje_isc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim()) : -1;
                    oeDETALLE_PEDIDO.DPE_monto_total_linea = subtotal + montoigv + montoisc;
                    oeDETALLE_PEDIDO.DPE_memo = "";
                    oeDETALLE_PEDIDO.DPE_numero_fila = i + 1;

                    List.Add(oeDETALLE_PEDIDO);
                }

                if (checkGrilla())
                {
                    if (balPEDIDO.actualizarRegistroMaestroDetalle(oePEDIDO, List))
                    {
                        mensaje("actualizar");
                        //MessageBox.Show("El registro fue actualizado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rpta = true;
                    }
                }
                else
                {
                    MessageBox.Show("Corrija errores en las lineas detalle.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\r\n" + ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return rpta;
        }
        
        public override bool Anular()
        {
            int u;
            bool rpta = false;
            try
            {
                ePEDIDO oePEDIDO = new ePEDIDO();
                oePEDIDO.PED_numero = Int32.TryParse(this.txtNumeroPedido.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumeroPedido.Text.Trim()) : -1;

                if (balPEDIDO.anularRegistro(oePEDIDO))
                {
                    mensaje("anular");
                    //MessageBox.Show("El documento fue anulado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rpta = true;
                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\r\n" + ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return rpta;
        }

        public override void Primero()
        {
            cargarDatos(balPEDIDO.primerRegistro());
        }

        public override void Anterior()
        {
            int u;
            ePEDIDO oePEDIDO = new ePEDIDO();
            oePEDIDO.PED_numero = Int32.TryParse(this.txtNumeroPedido.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumeroPedido.Text.Trim()) : -1;
            cargarDatos(balPEDIDO.anteriorRegistro(oePEDIDO));
        }

        public override void Siguiente()
        {
            int u;
            ePEDIDO oePEDIDO = new ePEDIDO();
            oePEDIDO.PED_numero = Int32.TryParse(this.txtNumeroPedido.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumeroPedido.Text.Trim()) : -1;
            cargarDatos(balPEDIDO.siguienteRegistro(oePEDIDO));
        }

        public override void Ultimo()
        {
            cargarDatos(balPEDIDO.ultimoRegistro());
        }

        public override void Buscar()
        {
            int u;
            balPEDIDO b = new balPEDIDO();
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ePEDIDO o = new ePEDIDO();
                o.PED_numero = Int32.TryParse(ventana.pk, out u) ? Convert.ToInt32(ventana.pk) : -1;//Convert.ToInt32(ventana.pk);
                DataTable dt = balPEDIDO.obtenerRegistro(o);
                cargarDatos(dt);
            }
        }

        private void cargarDatos(DataTable dt)
        {
            short u;
            if (dt != null)
            {
                this.txtCodigoSocio.Text = dt.Rows[0]["SOC_codigo"].ToString();
                this.txtNombreSocio.Text = dt.Rows[0]["PED_soc_nombre_razon"].ToString();
                this.txtDireccion.Text = dt.Rows[0]["PED_soc_direccion"].ToString();
                this.txtNumeroPedido.Text = dt.Rows[0]["PED_numero"].ToString();

                switch (dt.Rows[0]["PED_estado"].ToString())
                {
                    case "A":
                        this.cmbEstado.Text = "ABIERTO";
                        break;
                    case "C":
                        this.cmbEstado.Text = "CERRADO";
                        break;
                    case "N":
                        this.cmbEstado.Text = "ANULADO";
                        break;
                }

                this.dtpFechaPedido.Text = dt.Rows[0]["PED_fecha"].ToString();
                this.dtpFechaEntrega.Text = dt.Rows[0]["PED_fecha_entrega"].ToString();

                //ESTAS DOS LINEAS SE PONEN PARA QUE EL COMBO CHOFER Y VENDEDOR CARGUE SU PK, PERO LUEGO EL TXT ES RECARGADO
                this.cmbCodigoVendedor.SelectedValue = dt.Rows[0]["VEN_codigo"].ToString().Trim().Length > 0 ? dt.Rows[0]["VEN_codigo"].ToString() : "-1";

                this.txtVendedor.Text = dt.Rows[0]["PED_nombre_vendedor"].ToString();
                this.cmbCondicionPago.SelectedValue = dt.Rows[0]["CPA_codigo"].ToString();
                this.txtComentario.Text = dt.Rows[0]["PED_comentario"].ToString();
                this.txtSubtotal.Text = dt.Rows[0]["PED_subtotal"].ToString();
                this.txtImpuestos.Text = (Convert.ToDecimal(dt.Rows[0]["PED_monto_igv"].ToString()) + Convert.ToDecimal(dt.Rows[0]["PED_monto_isc"].ToString())).ToString();
                this.txtPercepcion.Text = dt.Rows[0]["PED_monto_percepcion"].ToString();
                this.txtMontoTotal.Text = dt.Rows[0]["PED_monto_total"].ToString();
                this.cmbTipoDocumento.SelectedValue = dt.Rows[0]["PED_tdo_codigo"].ToString();

                this.dgvDetalle.Rows.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.dgvDetalle.Rows.Add();

                    this.dgvDetalle["PRO_codigo", i].Value = dt.Rows[i]["PRO_codigo"].ToString();
                    this.dgvDetalle["DPE_is_bonificacion", i].Value = dt.Rows[i]["DPE_is_bonificacion"].ToString() == "S" ? "SI" : "NO";
                    this.dgvDetalle["PRO_descripcion", i].Value = dt.Rows[i]["DPE_pro_descripcion"].ToString();
                    this.dgvDetalle["Subunidades", i].Value = dt.Rows[i]["DPE_pro_ume_multiplo"].ToString();
                    this.dgvDetalle["DPE_cantidad", i].Value = dt.Rows[i]["DPE_cantidad"].ToString();

                    if (Convert.ToInt16(dt.Rows[i]["DPE_pro_ume_multiplo"].ToString()) == 1)
                    {
                        this.dgvDetalle["DPE_cantidad_submultiplo", i].ReadOnly = true;
                        this.dgvDetalle["DPE_cantidad_submultiplo", i].Value = "";
                        this.dgvDetalle["DPE_cantidad_submultiplo", i].Style.BackColor = SystemColors.InactiveCaption;
                    }
                    else
                    {
                        this.dgvDetalle["DPE_cantidad_submultiplo", i].Value = dt.Rows[i]["DPE_cantidad_submultiplo"].ToString();
                    }

                    this.dgvDetalle["DPE_precio_unitario", i].Value = dt.Rows[i]["DPE_precio_unitario"].ToString();
                    this.dgvDetalle["Subtotal", i].Value = dt.Rows[i]["DPE_monto_subtotal"].ToString();
                    this.dgvDetalle["DPE_monto_descuento", i].Value = dt.Rows[i]["DPE_monto_descuento"].ToString();
                    this.dgvDetalle["DPE_porcentaje_descuento", i].Value = dt.Rows[i]["DPE_porcentaje_descuento"].ToString();
                    this.dgvDetalle["MontoIGV", i].Value = dt.Rows[i]["DPE_monto_igv"].ToString();
                    this.dgvDetalle["MontoISC", i].Value = dt.Rows[i]["DPE_monto_isc"].ToString();

                    string impuestos = (Convert.ToDouble(dt.Rows[i]["DPE_monto_igv"].ToString()) > 0) ? "IGV[" + dt.Rows[i]["DPE_porcentaje_igv"].ToString() + "] " : "";
                    impuestos += (Convert.ToDouble(dt.Rows[i]["DPE_monto_isc"].ToString()) > 0) ? "ISC[" + dt.Rows[i]["DPE_porcentaje_isc"].ToString() + "] " : "";
                    
                    this.dgvDetalle["Impuestos", i].Value = impuestos;
                    this.dgvDetalle["PRO_porcentaje_igv", i].Value = dt.Rows[i]["DPE_porcentaje_igv"].ToString();
                    this.dgvDetalle["PRO_porcentaje_isc", i].Value = dt.Rows[i]["DPE_porcentaje_isc"].ToString();
                    
                    if (Convert.ToInt32(this.dgvDetalle["Subunidades", i].Value.ToString()) == 1)
                    {
                        this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, i].ReadOnly = true;
                        this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, i].Value = "";
                        if (dt.Rows[i]["DPE_is_bonificacion"].ToString() == "S")
                        {
                            this.dgvDetalle.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                            this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, i].Style.BackColor = Color.Peru;
                        }
                        else
                        {
                            this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, i].Style.BackColor = SystemColors.InactiveCaption;
                        }
                    }
                    else
                    {
                        this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, i].ReadOnly = false;
                        if (dt.Rows[i]["DPE_is_bonificacion"].ToString() == "S")
                        {
                            this.dgvDetalle.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        }
                        else
                        {

                        }
                    }
                    this.dgvDetalle["isValido", i].Value = "S";
                }
            }
            else
            {
                _cfgUtil.clearFields(this.gpbInformacion);
                
                this.btnCrear.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnActualizar.Enabled = true;
                this.btnAnular.Enabled = true;
                this.btnPrimero.Enabled = true;
                this.btnAnterior.Enabled = true;
                this.btnSiguiente.Enabled = true;
                this.btnUltimo.Enabled = true;
                this.btnBuscar.Enabled = true;
                this.btnCancelar.Enabled = false;

                this.dgvDetalle.Rows.Clear();
            }
        }

        private bool checkGrilla()
        {
            bool bandera = true;
            foreach (DataGridViewRow fila in this.dgvDetalle.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (this.dgvDetalle["isValido", fila.Index].Value.ToString() == "N")
                    {
                        bandera = false;
                    }
                }
            }
            return bandera;
        }
        
        private DataTable obtenerDatosProducto(int codigoSocio, string codigoProducto)
        {
            eSOCIO oeSOCIO = new eSOCIO();
            oeSOCIO.SOC_codigo = Convert.ToInt16(this.txtCodigoSocio.Text);

            ePRODUCTO oePRODUCTO = new ePRODUCTO();
            oePRODUCTO.PRO_codigo = codigoProducto;
            
            return balPRODUCTO.obtenerRegistroComplejo(oePRODUCTO, oeSOCIO);
        }
        
        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0 && this.dgvDetalle.Columns[e.ColumnIndex].Name == "PRO_codigo" && this.txtCodigoSocio.Text.Length > 0)
                {
                    int IndiceFila = this.dgvDetalle.CurrentRow.Index;
                    autocompletarCeldasGrilla(IndiceFila);
                }
            }
        }

        private void autocompletarCeldasGrilla(int indiceFila)
        {
            if (indiceFila == numeroFilasActual())
            {
                balPRODUCTO obalPRODUCTO = new balPRODUCTO();
                _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", obalPRODUCTO);
                DialogResult respuesta = ventana.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    DataTable dt = new DataTable();

                    ePRODUCTO oePRODUCTO = new ePRODUCTO();
                    oePRODUCTO.PRO_codigo = ventana.pk;
                    eSOCIO oeSOCIO = new eSOCIO();
                    oeSOCIO.SOC_codigo = Convert.ToInt32(this.txtCodigoSocio.Text);

                    dt = balPRODUCTO.obtenerRegistroComplejo(oePRODUCTO, oeSOCIO);

                    string impuestos = "";

                    if (dt.Rows.Count > 0)
                    {
                        impuestos = (Convert.ToDouble(dt.Rows[0]["PorcentajeIGV"].ToString()) > 0) ? "IGV[" + dt.Rows[0]["PorcentajeIGV"].ToString() + "] " : "";
                        impuestos += (Convert.ToDouble(dt.Rows[0]["PRO_porcentaje_isc"].ToString()) > 0) ? "ISC[" + dt.Rows[0]["PRO_porcentaje_isc"].ToString() + "] " : "";                         

                        this.dgvDetalle["PRO_codigo", indiceFila].Value = dt.Rows[0]["PRO_codigo"].ToString();
                        this.dgvDetalle["PRO_descripcion", indiceFila].Value = dt.Rows[0]["PRO_descripcion"].ToString();
                        this.dgvDetalle["DPE_precio_unitario", indiceFila].Value = dt.Rows[0]["DLP_precio"].ToString();
                        this.dgvDetalle["DPE_porcentaje_descuento", indiceFila].Value = dt.Rows[0]["DSC_porcentaje"].ToString();
                        this.dgvDetalle["Impuestos", indiceFila].Value = impuestos;
                        this.dgvDetalle["DPE_is_bonificacion", indiceFila].Value = "NO";
                        this.dgvDetalle["PRO_porcentaje_IGV", indiceFila].Value = Convert.ToDouble(dt.Rows[0]["PorcentajeIGV"].ToString());
                        this.dgvDetalle["PRO_porcentaje_ISC", indiceFila].Value = Convert.ToDouble(dt.Rows[0]["PRO_porcentaje_ISC"].ToString());
                        this.dgvDetalle["Subunidades", indiceFila].Value = dt.Rows[0]["UME_multiplo"].ToString();

                        if (Convert.ToInt16(dt.Rows[0]["UME_multiplo"].ToString()) == 1)
                        {
                            this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, indiceFila].ReadOnly = true;
                            this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, indiceFila].Value = "";
                            if (this.dgvDetalle[dgvDetalle.Columns["DPE_is_bonificacion"].Index, indiceFila].Value.ToString() == "NO")
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, indiceFila].Style.BackColor = SystemColors.InactiveCaption;
                            }
                            else
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, indiceFila].Style.BackColor = Color.Peru;
                            }
                        }
                        else
                        {
                            this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, indiceFila].ReadOnly = false;
                            this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, indiceFila].Style.BackColor = SystemColors.Window;
                        }
                    }

                    //this.dgvDetalle.BeginEdit(false);

                    this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad"].Index, indiceFila].Value = 0;
                    //this.dgvDetalle.BeginEdit(false);

                    this.dgvDetalle.CurrentCell = this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad"].Index, indiceFila];
                    //this.dgvDetalle.BeginEdit(false);

                    //MessageBox.Show("col " + this.dgvDetalle.CurrentCell.ColumnIndex + ", row " + this.dgvDetalle.CurrentCell.RowIndex);
                    //this.dgvDetalle.BeginEdit(false);

                    this.dgvDetalle["isValido", indiceFila].Value = "N";
                    //this.dgvDetalle.BeginEdit(false);
                }
            }
        }

        private void ProcesarGrilla()
        {
            double subtotalGrilla = 0;
            double impuestosGrilla = 0;

            int subunidades = 0;
            int cantidad = 0;
            int cantidad_sub = 0;
            double precio_unitario = 0;
            double precio_subunidad = 0;
            double porcentaje_descuento = 0;
            double monto_descuento = 0;
            double subtotalFila = 0;
            double subtotalFilaConIGV = 0;
            double IGVFila = 0;
            double ISCFila = 0;

            _IGVGrilla = 0;
            _ISCGrilla = 0;

            foreach (DataGridViewRow fila in this.dgvDetalle.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (this.dgvDetalle["DPE_cantidad", fila.Index].Value != null && this.dgvDetalle["DPE_is_bonificacion", fila.Index].Value.ToString() == "NO")
                    {
                        if (Convert.ToInt32(this.dgvDetalle["DPE_cantidad", fila.Index].Value) >= 0)
                        {
                            subunidades = Convert.ToInt16(this.dgvDetalle["Subunidades", fila.Index].Value.ToString());
                            cantidad = Convert.ToInt32(this.dgvDetalle["DPE_cantidad", fila.Index].Value.ToString());
                            cantidad_sub = subunidades > 1 ? (this.dgvDetalle["DPE_cantidad_submultiplo", fila.Index].Value != null ? Convert.ToInt32(this.dgvDetalle["DPE_cantidad_submultiplo", fila.Index].Value.ToString()) : 0) : 0;
                            precio_unitario = Convert.ToDouble(this.dgvDetalle["DPE_precio_unitario", fila.Index].Value.ToString());
                            precio_subunidad = Convert.ToDouble(precio_unitario / subunidades);
                            porcentaje_descuento = Math.Round(Convert.ToDouble(this.dgvDetalle["DPE_porcentaje_descuento", fila.Index].Value.ToString()), 4);
                            monto_descuento = (precio_unitario * cantidad + precio_subunidad * cantidad_sub) * (porcentaje_descuento / 100);                            
                            subtotalFila = (precio_unitario * cantidad + precio_subunidad * cantidad_sub) * (1 - porcentaje_descuento / 100);

                            subtotalFilaConIGV = Convert.ToDouble(subtotalFila * (1 + Convert.ToDouble(this.dgvDetalle["PRO_porcentaje_igv", fila.Index].Value.ToString())));
                            IGVFila = Math.Round(Convert.ToDouble(subtotalFila * Convert.ToDouble(this.dgvDetalle["PRO_porcentaje_igv", fila.Index].Value.ToString())), 2);
                            ISCFila = Math.Round(Convert.ToDouble(subtotalFilaConIGV * Convert.ToDouble(this.dgvDetalle["PRO_porcentaje_isc", fila.Index].Value.ToString())), 2);

                            subtotalGrilla += subtotalFila;
                            impuestosGrilla += IGVFila + ISCFila;

                            _IGVGrilla += IGVFila;
                            _ISCGrilla += ISCFila;

                            this.dgvDetalle["subtotal", fila.Index].Value = Math.Round(subtotalFila, 4);
                            this.dgvDetalle["MontoIGV", fila.Index].Value = IGVFila;
                            this.dgvDetalle["MontoISC", fila.Index].Value = ISCFila;
                            this.dgvDetalle["DPE_monto_descuento", fila.Index].Value = monto_descuento;
                            this.dgvDetalle["isValido", fila.Index].Value = "S";

                            if (Convert.ToInt32(this.dgvDetalle["Subunidades", fila.Index].Value) == 1)
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, fila.Index].ReadOnly = true;
                                this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, fila.Index].Value = "";
                            }
                            else
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, fila.Index].ReadOnly = false;
                                this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, fila.Index].Style.BackColor = SystemColors.Window;
                            }
                        }
                    }
                    else
                    {
                        this.dgvDetalle["isValido", fila.Index].Value = "N";
                    }
                }
            }

            double resultado_subtotal= Math.Round(subtotalGrilla, 4);
            double resultado_impuestos = Math.Round(impuestosGrilla, 2);
            double resultado_percepcion = Math.Round((resultado_subtotal + resultado_impuestos) * _porcentajePercepcion, 2);
            double resultado_montototal = Math.Round(resultado_subtotal + resultado_impuestos + resultado_percepcion, 2);
            
            this.txtSubtotal.Text = resultado_subtotal.ToString();
            this.txtImpuestos.Text = resultado_impuestos.ToString();
            this.txtPercepcion.Text = resultado_percepcion.ToString();
            this.txtMontoTotal.Text = resultado_montototal.ToString();
        }

        private void insertarBonificaciones()
        {
            DataTable filaBoni = new DataTable();
            DataTable tablaBoni = new DataTable();

            tablaBoni.Columns.Add("IsAplicable");
            tablaBoni.Columns.Add("PRO_codigo");
            tablaBoni.Columns.Add("PRO_descripcion");
            tablaBoni.Columns.Add("Unidades");
            tablaBoni.Columns.Add("Submultiplo");
            tablaBoni.Columns.Add("UME_multiplo");

            limpiarFilasBonificaciones();

            int u;
            foreach (DataGridViewRow fila in this.dgvDetalle.Rows)
            {
                if (!fila.IsNewRow && fila.Cells["PRO_codigo"].Value != null && fila.Cells["DPE_is_bonificacion"].Value.ToString() == "NO")
                {
                    eVENTA oeVENTA = new eVENTA();
                    eDETALLE_VENTA oeDETALLEVENTA = new eDETALLE_VENTA();
                    oeVENTA.SOC_codigo = Convert.ToInt16(this.txtCodigoSocio.Text);
                    oeDETALLEVENTA.PRO_codigo = this.dgvDetalle["PRO_codigo", fila.Index].Value.ToString();
                    oeDETALLEVENTA.DVE_cantidad = this.dgvDetalle["DPE_cantidad", fila.Index].Value != null ? (Int32.TryParse(this.dgvDetalle["DPE_cantidad", fila.Index].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle["DPE_cantidad", fila.Index].Value.ToString().Trim()) : 0) : 0;
                    oeDETALLEVENTA.DVE_cantidad_submultiplo = this.dgvDetalle["DPE_cantidad_submultiplo", fila.Index].Value != null ? (Int32.TryParse(this.dgvDetalle["DPE_cantidad_submultiplo", fila.Index].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle["DPE_cantidad_submultiplo", fila.Index].Value.ToString().Trim()) : 0) : 0;

                    filaBoni = balBONIFICACION.procesarReglas(oeVENTA, oeDETALLEVENTA);

                    tablaBoni.Rows.Add(
                            filaBoni.Rows[0]["IsAplicable"].ToString()
                        , filaBoni.Rows[0]["PRO_codigo"].ToString()
                        , filaBoni.Rows[0]["PRO_descripcion"].ToString()
                        , filaBoni.Rows[0]["Unidades"].ToString()
                        , filaBoni.Rows[0]["Submultiplo"].ToString()
                        , filaBoni.Rows[0]["UME_multiplo"].ToString());
                }
            }

            if (tablaBoni != null)
            {
                List<string> listaCodigoProducto = new List<string>();
                foreach (DataRow fila in tablaBoni.Rows)
                {
                    if (fila["IsAplicable"].ToString() == "S")
                    {
                        listaCodigoProducto.Add(fila["PRO_codigo"].ToString());
                    }
                }

                List<string> listita = listaCodigoProducto.Distinct().ToList();

                foreach (var filita in listita)
                {
                    string procodigo = "";
                    string prodescripcion = "";
                    int umemultiplo = 0;
                    int unidadesSuma = 0;
                    int subunidadesSuma = 0;

                    int enteros = 0;
                    int fracciones = 0;

                    foreach (DataRow fila in tablaBoni.Rows)
                    {
                        if (filita.ToString() == fila["PRO_codigo"].ToString())
                        {
                            procodigo = fila["PRO_codigo"].ToString();
                            prodescripcion = fila["PRO_descripcion"].ToString();
                            umemultiplo = Convert.ToInt32(fila["UME_multiplo"].ToString());
                            unidadesSuma += Convert.ToInt32(fila["Unidades"].ToString());
                            subunidadesSuma += Convert.ToInt32(fila["Submultiplo"].ToString());
                        }
                    }

                    if (subunidadesSuma >= umemultiplo)
                    {
                        enteros = subunidadesSuma / umemultiplo;
                        fracciones = subunidadesSuma % umemultiplo;
                        unidadesSuma += enteros;
                        subunidadesSuma = fracciones;
                    }

                    int indice = numeroFilasActual();

                    this.dgvDetalle.Rows.Add();
                    this.dgvDetalle.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                    this.dgvDetalle["PRO_codigo", indice].Value = procodigo;
                    this.dgvDetalle["PRO_descripcion", indice].Value = prodescripcion;
                    this.dgvDetalle["DPE_cantidad", indice].Value = unidadesSuma;
                    this.dgvDetalle["DPE_cantidad_submultiplo", indice].Value = subunidadesSuma;
                    this.dgvDetalle["DPE_precio_unitario", indice].Value = "0.00";
                    this.dgvDetalle["DPE_porcentaje_descuento", indice].Value = "0.00";
                    this.dgvDetalle["DPE_monto_descuento", indice].Value = "0.00";
                    this.dgvDetalle["Subtotal", indice].Value = "0.00";
                    this.dgvDetalle["Impuestos", indice].Value = "0.00";
                    this.dgvDetalle["PRO_porcentaje_igv", indice].Value = "0.00";
                    this.dgvDetalle["PRO_porcentaje_isc", indice].Value = "0.00";
                    this.dgvDetalle["MontoIGV", indice].Value = "0.00";
                    this.dgvDetalle["MontoISC", indice].Value = "0.00";
                    this.dgvDetalle["DPE_is_bonificacion", indice].Value = "SI";
                    this.dgvDetalle["Subunidades", indice].Value = umemultiplo;
                    this.dgvDetalle["isValido", indice].Value = "S";

                    if (Convert.ToInt32(this.dgvDetalle["Subunidades", indice].Value) == 1)
                    {
                        this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, indice].ReadOnly = true;
                        this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, indice].Value = "";
                        this.dgvDetalle[dgvDetalle.Columns["DPE_cantidad_submultiplo"].Index, indice].Style.BackColor = Color.Peru;
                    }
                }
            }
        }
        
        private void limpiarFilasBonificaciones()
        {
            var toBeDeleted = new List<DataGridViewRow>();

            for (int i = 0; i < this.dgvDetalle.RowCount - 1; i++)
            {
                if (this.dgvDetalle["DPE_is_bonificacion", i].Value.ToString() == "SI")
                {
                    DataGridViewRow row = this.dgvDetalle.Rows[i];
                    toBeDeleted.Add(row);
                }
            }
            toBeDeleted.ForEach(d => this.dgvDetalle.Rows.Remove(d));
        }
        
        private void dgvDetalle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            _cfgUtil.enumerarFilasDatagridview(this.dgvDetalle, e);
        }

        private int rowIndex = 0;
        private void dgvDetalle_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                this.dgvDetalle.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvDetalle.CurrentCell = this.dgvDetalle.Rows[e.RowIndex].Cells[1];
                this.menuContextual.Show(this.dgvDetalle, e.Location);
                menuContextual.Show(Cursor.Position);
            }
        }

        private void eliminarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvDetalle.Rows[this.rowIndex].IsNewRow)
            {
                this.dgvDetalle.Rows.RemoveAt(this.rowIndex);
                ProcesarGrilla();
                insertarBonificaciones();
            }
        }
        
        private void dgvDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
               
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if ((keyData == Keys.Enter) && this.dgvDetalle.RowCount > 0 && this.txtCodigoSocio.Text.Length > 0 && this.dgvDetalle.CurrentRow != null)
            {
                int IndiceFila = this.dgvDetalle.CurrentRow.Index;
                if (this.dgvDetalle["DPE_cantidad", IndiceFila].Value != null || this.dgvDetalle["DPE_cantidad_submultiplo", IndiceFila].Value != null)
                {
                    autocompletarCeldasGrilla(numeroFilasActual());
                    insertarBonificaciones();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private int numeroFilasActual()
        {
            int numeroFilas = 0;
            foreach (DataGridViewRow fila in this.dgvDetalle.Rows)
            {
                if (!fila.IsNewRow)
                    numeroFilas++;
            }
            return numeroFilas;
        }
        
        private void dgvDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+' && this.txtCodigoSocio.Text.Length > 0)
            {
                int IndiceFila = this.dgvDetalle.CurrentRow.Index;
                autocompletarCeldasGrilla(IndiceFila);
            }
        }

        private void txtMontoTotal_TextChanged(object sender, EventArgs e)
        {
            if (this.txtMontoTotal.Text.Length > 0)
            {
                txtMontoTotal.Text = string.Format("{0:#,##0.00}", double.Parse(txtMontoTotal.Text));
            }
        }

        private void txtPercepcion_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPercepcion.Text.Length > 0)
                txtPercepcion.Text = string.Format("{0:#,##0.00}", double.Parse(txtPercepcion.Text));
        }

        private void txtImpuestos_TextChanged(object sender, EventArgs e)
        {
            if (this.txtImpuestos.Text.Length > 0)
                txtImpuestos.Text = string.Format("{0:#,##0.00}", double.Parse(txtImpuestos.Text));
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSubtotal.Text.Length > 0)
                txtSubtotal.Text = string.Format("{0:#,##0.0000}", double.Parse(txtSubtotal.Text));
        }
                
        private void cmbCodigoVendedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.txtVendedor.Text = this.cmbCodigoVendedor.Text;
        }

        private void cmbCodigoVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtVendedor.Text = this.cmbCodigoVendedor.Text;
        }

        private void btnNullCmbVendedor_Click(object sender, EventArgs e)
        {
            this.cmbCodigoVendedor.SelectedIndex = -1;
        }

        private void dgvDetalle_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvDetalle.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                if (this.dgvDetalle["PRO_codigo", this.dgvDetalle.CurrentRow.Index].Value != null)
                {
                    dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    ProcesarGrilla();
                    insertarBonificaciones();
                }
                else
                {
                    this.dgvDetalle.CancelEdit();
                }
            }
        }

        private void menuContextual2_Opening(object sender, CancelEventArgs e)
        {
            this.menuDocVenta.Text = this.cmbTipoDocumento.Text;
        }

        private void menuDocVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("uX: " + SharedData.Instance().Reglas);
            //string[] colas = SharedData.Instance().Reglas;
            //foreach (var irtem in colas)
            //{
            //    MessageBox.Show("" + irtem.ToString());
            //}
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

        private void btnGoVendedor_Click(object sender, EventArgs e)
        {
            eVENDEDOR o = new eVENDEDOR();
            o.VEN_codigo = this.cmbCodigoVendedor.SelectedValue != null ? Convert.ToInt32(this.cmbCodigoVendedor.SelectedValue.ToString()) : -1;

            frmDM_Vendedor o2 = new frmDM_Vendedor(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoCondicionPago_Click(object sender, EventArgs e)
        {
            eCONDICION_PAGO o = new eCONDICION_PAGO();
            o.CPA_codigo = this.cmbCondicionPago.SelectedValue != null ? this.cmbCondicionPago.SelectedValue.ToString() : "";

            frmDM_CondicionPago o2 = new frmDM_CondicionPago(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoTipoDocumento_Click(object sender, EventArgs e)
        {
            eTIPO_DOCUMENTO o = new eTIPO_DOCUMENTO();
            o.TDO_codigo = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";

            frmDM_TipoDocumento o2 = new frmDM_TipoDocumento(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvDetalle.Columns["PRO_descripcion"].Index)
            {
                int columna_codigo1 = this.dgvDetalle.Columns["PRO_codigo"].Index;
                string codigo = this.dgvDetalle[columna_codigo1, e.RowIndex].Value.ToString();
                ePRODUCTO o = new ePRODUCTO();
                o.PRO_codigo = codigo.Length > 0 ? codigo : "";

                frmDM_Producto o2 = new frmDM_Producto(o);
                o2.MdiParent = this.MdiParent;
                o2.Show();
            }
        }

        private void btnSocioNegocio_Click(object sender, EventArgs e)
        {
            double d;
            int u;
            if (numeroFilasActual() == 0)
            {
                _frmBusqueda ventana = new _frmBusqueda(false, "buscarCliente", _obalSOCIO);
                DialogResult respuesta = ventana.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    eSOCIO _oeSOCIO = new eSOCIO();
                    _oeSOCIO.SOC_codigo = Int32.TryParse(ventana.pk.Trim(), out u) ? Convert.ToInt32(ventana.pk.Trim()) : -1;
                    DataTable dt = balSOCIO.obtenerRegistro(_oeSOCIO);
                    if (dt != null)
                    {
                        //this.cmbTipoDocumento.SelectedValue = dt.Rows[0]["TDO_codigo"].ToString();
                        //la serie se carga por defecto, pero implementar serie por defecto en tabla serie.
                        this.txtCodigoSocio.Text = dt.Rows[0]["SOC_codigo"].ToString();
                        this.txtNombreSocio.Text = dt.Rows[0]["SOC_nombre_razon_social"].ToString();
                        this.txtDireccion.Text = dt.Rows[0]["SOC_direccion"].ToString();
                        this.cmbCondicionPago.SelectedValue = dt.Rows[0]["CPA_codigo"].ToString();
                        this.cmbCodigoVendedor.SelectedValue = dt.Rows[0]["VEN_codigo"].ToString();

                        this.cmbTipoDocumento.SelectedValue = dt.Rows[0]["TDO_codigo"].ToString();

                        _listaPrecio = dt.Rows[0]["LPR_codigo"].ToString();
                        _canal = dt.Rows[0]["CAN_codigo"].ToString();
                        _isPercepcion = dt.Rows[0]["SOC_is_agente_percepcion"].ToString();
                        _porcentajePercepcion = Double.TryParse(dt.Rows[0]["SOC_porcentaje_percepcion"].ToString(), out d) ? Convert.ToDouble(dt.Rows[0]["SOC_porcentaje_percepcion"].ToString()) : 0;
                        _zona = Convert.ToInt32(dt.Rows[0]["ZON_codigo"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un socio de negocio válido.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("No es posible cambiar el socio de negocio cuando ya se han ingresado productos.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Refresco de combobox
        private void cmbCodigoVendedor_DropDown(object sender, EventArgs e)
        {
            int valorSeleccionado = -1;
            if (this.cmbCodigoVendedor.SelectedValue != null)
            {
                valorSeleccionado = Convert.ToInt32(this.cmbCodigoVendedor.SelectedValue.ToString());
            }
            this.cmbCodigoVendedor.DataSource = balVENDEDOR.poblar();
            this.cmbCodigoVendedor.SelectedValue = valorSeleccionado;            
        }

        private void cmbCondicionPago_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbCondicionPago.SelectedValue != null)
            {
                valorSeleccionado = this.cmbCondicionPago.SelectedValue.ToString();
            }
            this.cmbCondicionPago.DataSource = balCONDICION_PAGO.poblar();
            this.cmbCondicionPago.SelectedValue = valorSeleccionado;            
        }

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
    }
}