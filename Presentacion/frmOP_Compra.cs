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
    public partial class frmOP_Compra : _frmBaseOP
    {
        eCOMPRA _o;
        //variables de entorno
        string _listaPrecio = "";
        string _canal = "";
        string _isPercepcion = "N";
        double _porcentajePercepcion = 0.00;
        int _zona = 0;

        double _IGVGrilla = 0;
        double _ISCGrilla = 0;

        private balSOCIO _obalSOCIO = new balSOCIO();
        private balPRODUCTO _obalPRODUCTO = new balPRODUCTO();
        private bool isCrearNuevo = false;

        public frmOP_Compra(eCOMPRA o)
        {
            InitializeComponent();

            tabla = "COMPRA";

            this.cmbTipoDocumento.ValueMember = "TDO_codigo";
            this.cmbTipoDocumento.DisplayMember = "TDO_nombre";
            this.cmbTipoDocumento.DataSource = balTIPO_DOCUMENTO.poblar();

            this._o = o;
        }

        private void frmOP_Compra_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtNumero.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balCOMPRA.obtenerRegistro(_o)); }
        }

        public override void Crear()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.dgvDetalle.Rows.Clear();
            this.cmbEstado.Text = "ABIERTO";
            this.btnSocioNegocio.Focus();
        }

        public override bool Guardar()
        {
            bool rpta = false;
            double montoigv, montoisc, subtotal, totalLinea;
            //try
            //{
                int u;
                double d;

                eCOMPRA o = new eCOMPRA();
                o.COM_fecha_documento_origen = Convert.ToDateTime(this.dtpFechaDocumento.Value.ToShortDateString());
                o.COM_fecha_vencimiento = Convert.ToDateTime(this.dtpFechaVencimiento.Value.ToShortDateString());
                o.COM_documento_origen = String.IsNullOrWhiteSpace(this.txtDocumentoOrigen.Text.Trim()) ? "" : this.txtDocumentoOrigen.Text.Trim();
                o.COM_tipo_documento = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";
                o.SOC_codigo = Int32.TryParse(this.txtCodigoSocio.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigoSocio.Text.Trim()) : -1;
                o.COM_soc_nombre_razon = String.IsNullOrWhiteSpace(this.txtNombreSocio.Text.Trim()) ? "" : this.txtNombreSocio.Text.Trim();
                o.COM_subtotal = Double.TryParse(this.txtSubtotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtSubtotal.Text.Trim()) : -1;
                o.COM_porcentaje_percepcion = _porcentajePercepcion;
                o.COM_monto_igv = _IGVGrilla;
                o.COM_monto_isc = _ISCGrilla;
                o.COM_monto_percepcion = Double.TryParse(this.txtPercepcion.Text.Trim(), out d) ? Convert.ToDouble(this.txtPercepcion.Text.Trim()) : -1;
                o.COM_monto_total = Double.TryParse(this.txtMontoTotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtMontoTotal.Text.Trim()) : -1;
                o.COM_comentario = String.IsNullOrWhiteSpace(this.txtComentario.Text.Trim()) ? null : this.txtComentario.Text.Trim();
                o.COM_estado = "A";

                List<eDETALLE_COMPRA> List = new List<eDETALLE_COMPRA>();
                for (int i = 0; i < this.dgvDetalle.RowCount - 1; i++)
                {
                    montoigv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim()) : -1;
                    montoisc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim()) : -1;
                    subtotal = Double.TryParse(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim()) : -1;
                    totalLinea = subtotal + montoigv + montoisc;

                    eDETALLE_COMPRA oeDETALLE_COMPRA = new eDETALLE_COMPRA();
                    oeDETALLE_COMPRA.PRO_codigo = (this.dgvDetalle.Rows[i].Cells["PRO_codigo"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    oeDETALLE_COMPRA.DCO_is_bonificacion = (this.dgvDetalle.Rows[i].Cells["DCO_is_bonificacion"].Value.ToString().Substring(0, 1) ?? "N").ToString().ToUpper().Trim();
                    oeDETALLE_COMPRA.DCO_pro_descripcion = (this.dgvDetalle.Rows[i].Cells["PRO_descripcion"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    oeDETALLE_COMPRA.DCO_pro_ume_multiplo = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_cantidad = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DCO_cantidad"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DCO_cantidad"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_cantidad_submultiplo = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DCO_cantidad_submultiplo"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DCO_cantidad_submultiplo"].Value.ToString().Trim()) : (int?)null;
                    oeDETALLE_COMPRA.DCO_precio_unitario = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DCO_precio_unitario"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DCO_precio_unitario"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_monto_subtotal = subtotal;
                    oeDETALLE_COMPRA.DCO_monto_descuento = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DCO_monto_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DCO_monto_descuento"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_porcentaje_descuento = this.dgvDetalle.Rows[i].Cells["DCO_porcentaje_descuento"].Value != null ? Double.TryParse(this.dgvDetalle.Rows[i].Cells["DCO_porcentaje_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DCO_porcentaje_descuento"].Value.ToString().Trim()) : -1 : -1;
                    oeDETALLE_COMPRA.DCO_monto_igv = montoigv;
                    oeDETALLE_COMPRA.DCO_monto_isc = montoisc;
                    oeDETALLE_COMPRA.DCO_porcentaje_igv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_porcentaje_isc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_monto_total_linea = subtotal + montoigv + montoisc;
                    oeDETALLE_COMPRA.DCO_memo = "";
                    oeDETALLE_COMPRA.DCO_numero_fila = i + 1;
                    oeDETALLE_COMPRA.DCO_fecha_produccion = Convert.ToDateTime(this.dgvDetalle.Rows[i].Cells["Fecha_produccion"].Value.ToString().Trim());
                    oeDETALLE_COMPRA.DCO_fecha_vencimiento = Convert.ToDateTime(this.dgvDetalle.Rows[i].Cells["Fecha_vencimiento"].Value.ToString().Trim());

                    List.Add(oeDETALLE_COMPRA);
                }

                if (checkGrilla())
                {
                    if (balCOMPRA.insertarRegistroMaestroDetalle(o, List))
                    {
                        //MessageBox.Show("El registro fue guardado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mensaje("guardar");
                        this.txtNumero.ReadOnly = true;
                        rpta = true;
                    }
                }
                else
                {
                    MessageBox.Show("Corrija errores en las lineas detalle.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            //}
            //catch (CustomException ex)
            //{
            //    MessageBox.Show(ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
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

                eCOMPRA o = new eCOMPRA();
                o.COM_numero = Int32.TryParse(this.txtNumero.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumero.Text.Trim()) : -1;
                o.COM_fecha_documento_origen = Convert.ToDateTime(this.dtpFechaDocumento.Value.ToShortDateString());
                o.COM_fecha_vencimiento = Convert.ToDateTime(this.dtpFechaVencimiento.Value.ToShortDateString());
                o.COM_documento_origen = String.IsNullOrWhiteSpace(this.txtDocumentoOrigen.Text.Trim()) ? "" : this.txtDocumentoOrigen.Text.Trim();
                o.COM_tipo_documento = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";
                o.SOC_codigo = Int32.TryParse(this.txtCodigoSocio.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigoSocio.Text.Trim()) : -1;
                o.COM_soc_nombre_razon = String.IsNullOrWhiteSpace(this.txtNombreSocio.Text.Trim()) ? "" : this.txtNombreSocio.Text.Trim();
                o.COM_subtotal = Double.TryParse(this.txtSubtotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtSubtotal.Text.Trim()) : -1;
                o.COM_porcentaje_percepcion = _porcentajePercepcion;
                o.COM_monto_igv = _IGVGrilla;
                o.COM_monto_isc = _ISCGrilla;
                o.COM_monto_percepcion = Double.TryParse(this.txtPercepcion.Text.Trim(), out d) ? Convert.ToDouble(this.txtPercepcion.Text.Trim()) : -1;
                o.COM_monto_total = Double.TryParse(this.txtMontoTotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtMontoTotal.Text.Trim()) : -1;
                o.COM_comentario = String.IsNullOrWhiteSpace(this.txtComentario.Text.Trim()) ? null : this.txtComentario.Text.Trim();

                string estado = "";
                switch (this.cmbEstado.Text)
                {
                    case "ABIERTO": estado = "A"; break;
                    case "PAGADO": estado = "P"; break;
                    case "ANULADO": estado = "N"; break;
                }

                o.COM_estado = estado;

                List<eDETALLE_COMPRA> List = new List<eDETALLE_COMPRA>();
                for (int i = 0; i < this.dgvDetalle.RowCount - 1; i++)
                {
                    montoigv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim()) : -1;
                    montoisc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim()) : -1;
                    subtotal = Double.TryParse(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim()) : -1;
                    totalLinea = subtotal + montoigv + montoisc;

                    eDETALLE_COMPRA oeDETALLE_COMPRA = new eDETALLE_COMPRA();
                    oeDETALLE_COMPRA.COM_numero = Int32.TryParse(this.txtNumero.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumero.Text.Trim()) : -1;
                    oeDETALLE_COMPRA.PRO_codigo = (this.dgvDetalle.Rows[i].Cells["PRO_codigo"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    oeDETALLE_COMPRA.DCO_is_bonificacion = (this.dgvDetalle.Rows[i].Cells["DCO_is_bonificacion"].Value.ToString().Substring(0, 1) ?? "N").ToString().ToUpper().Trim();
                    oeDETALLE_COMPRA.DCO_pro_descripcion = (this.dgvDetalle.Rows[i].Cells["PRO_descripcion"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    oeDETALLE_COMPRA.DCO_pro_ume_multiplo = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_cantidad = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DCO_cantidad"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DCO_cantidad"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_cantidad_submultiplo = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DCO_cantidad_submultiplo"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DCO_cantidad_submultiplo"].Value.ToString().Trim()) : (int?)null;
                    oeDETALLE_COMPRA.DCO_precio_unitario = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DCO_precio_unitario"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DCO_precio_unitario"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_monto_subtotal = subtotal;
                    oeDETALLE_COMPRA.DCO_monto_descuento = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DCO_monto_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DCO_monto_descuento"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_porcentaje_descuento = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DCO_porcentaje_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DCO_porcentaje_descuento"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_monto_igv = montoigv;
                    oeDETALLE_COMPRA.DCO_monto_isc = montoisc;
                    oeDETALLE_COMPRA.DCO_porcentaje_igv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_porcentaje_isc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim()) : -1;
                    oeDETALLE_COMPRA.DCO_monto_total_linea = subtotal + montoigv + montoisc;
                    oeDETALLE_COMPRA.DCO_memo = "";
                    oeDETALLE_COMPRA.DCO_numero_fila = i + 1;
                    oeDETALLE_COMPRA.DCO_fecha_produccion = Convert.ToDateTime(this.dgvDetalle.Rows[i].Cells["Fecha_produccion"].Value.ToString().Trim());
                    oeDETALLE_COMPRA.DCO_fecha_vencimiento = Convert.ToDateTime(this.dgvDetalle.Rows[i].Cells["Fecha_vencimiento"].Value.ToString().Trim());

                    List.Add(oeDETALLE_COMPRA);
                }

                if (checkGrilla())
                {
                    if (balCOMPRA.actualizarRegistroMaestroDetalle(o, List))
                    {
                        //MessageBox.Show("El registro fue actualizado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mensaje("actualizar");
                        this.txtNumero.ReadOnly = true;
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
                eCOMPRA oeCOMPRA = new eCOMPRA();
                oeCOMPRA.COM_numero = Int32.TryParse(this.txtNumero.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumero.Text.Trim()) : -1;

                if (balCOMPRA.anularRegistro(oeCOMPRA))
                {
                    //MessageBox.Show("El documento fue anulado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mensaje("anular");
                    this.txtNumero.ReadOnly = true;
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
            cargarDatos(balCOMPRA.primerRegistro());
        }

        public override void Anterior()
        {
            int u;
            eCOMPRA oeCOMPRA = new eCOMPRA();
            oeCOMPRA.COM_numero = Int32.TryParse(this.txtNumero.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumero.Text.Trim()) : -1;
            cargarDatos(balCOMPRA.anteriorRegistro(oeCOMPRA));
        }

        public override void Siguiente()
        {
            int u;
            eCOMPRA oeCOMPRA = new eCOMPRA();
            oeCOMPRA.COM_numero = Int32.TryParse(this.txtNumero.Text.Trim(), out u) ? Convert.ToInt32(this.txtNumero.Text.Trim()) : -1;
            cargarDatos(balCOMPRA.siguienteRegistro(oeCOMPRA));
        }

        public override void Ultimo()
        {
            cargarDatos(balCOMPRA.ultimoRegistro());
        }

        public override void Buscar()
        {
            int u;
            balCOMPRA b = new balCOMPRA();
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                eCOMPRA o = new eCOMPRA();
                o.COM_numero = Int32.TryParse(ventana.pk, out u) ? Convert.ToInt32(ventana.pk) : -1;//Convert.ToInt32(ventana.pk);
                DataTable dt = balCOMPRA.obtenerRegistro(o);
                cargarDatos(dt);
            }
        }

        public override void Cancelar()
        {
            this.txtNumero.ReadOnly = true;
        }

        private void cargarDatos(DataTable dt)
        {
            short u;
            if (dt != null)
            {
                this.txtNumero.Text = dt.Rows[0]["COM_numero"].ToString();
                this.txtCodigoSocio.Text = dt.Rows[0]["SOC_codigo"].ToString();
                this.txtNombreSocio.Text = dt.Rows[0]["COM_soc_nombre_razon"].ToString();
                this.cmbTipoDocumento.SelectedValue = dt.Rows[0]["COM_tipo_documento"].ToString();
                this.txtDocumentoOrigen.Text = dt.Rows[0]["COM_documento_origen"].ToString();

                switch (dt.Rows[0]["COM_estado"].ToString())
                {
                    case "A":
                        this.cmbEstado.Text = "ABIERTO";
                        break;
                    case "P":
                        this.cmbEstado.Text = "PAGADO";
                        break;
                    case "N":
                        this.cmbEstado.Text = "ANULADO";
                        break;
                }
                this.dtpFechaDocumento.Text = dt.Rows[0]["COM_fecha_documento_origen"].ToString();
                this.dtpFechaVencimiento.Text = dt.Rows[0]["COM_fecha_vencimiento"].ToString();
                this.txtComentario.Text = dt.Rows[0]["COM_comentario"].ToString();
                this.txtSubtotal.Text = dt.Rows[0]["COM_subtotal"].ToString();
                this.txtImpuestos.Text = (Convert.ToDecimal(dt.Rows[0]["COM_monto_igv"].ToString()) + Convert.ToDecimal(dt.Rows[0]["COM_monto_isc"].ToString())).ToString();
                this.txtPercepcion.Text = dt.Rows[0]["COM_monto_percepcion"].ToString();
                this.txtMontoTotal.Text = dt.Rows[0]["COM_monto_total"].ToString();

                this.dgvDetalle.Rows.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.dgvDetalle.Rows.Add();
                    this.dgvDetalle["PRO_codigo", i].Value = dt.Rows[i]["PRO_codigo"].ToString();
                    this.dgvDetalle["PRO_descripcion", i].Value = dt.Rows[i]["DCO_pro_descripcion"].ToString();
                    this.dgvDetalle["DCO_cantidad", i].Value = dt.Rows[i]["DCO_cantidad"].ToString();
                    if (Convert.ToInt16(dt.Rows[i]["DCO_pro_ume_multiplo"].ToString()) == 1)
                    {
                        this.dgvDetalle["DCO_cantidad_submultiplo", i].ReadOnly = true;
                        this.dgvDetalle["DCO_cantidad_submultiplo", i].Value = "";
                        this.dgvDetalle["DCO_cantidad_submultiplo", i].Style.BackColor = SystemColors.InactiveCaption;
                    }
                    else
                    {
                        this.dgvDetalle["DCO_cantidad_submultiplo", i].Value = dt.Rows[i]["DCO_cantidad_submultiplo"].ToString();
                    }
                    this.dgvDetalle["DCO_precio_unitario", i].Value = dt.Rows[i]["DCO_precio_unitario"].ToString();
                    this.dgvDetalle["DCO_porcentaje_descuento", i].Value = dt.Rows[i]["DCO_porcentaje_descuento"].ToString();
                    this.dgvDetalle["Subtotal", i].Value = dt.Rows[i]["DCO_monto_subtotal"].ToString();
                    string impuestos = (Convert.ToDouble(dt.Rows[i]["DCO_monto_igv"].ToString()) > 0) ? "IGV[" + dt.Rows[i]["DCO_porcentaje_igv"].ToString() + "] " : "";
                    impuestos += (Convert.ToDouble(dt.Rows[i]["DCO_monto_isc"].ToString()) > 0) ? "ISC[" + dt.Rows[i]["DCO_porcentaje_isc"].ToString() + "] " : "";
                    this.dgvDetalle["Impuestos", i].Value = impuestos;
                    this.dgvDetalle["Fecha_produccion", i].Value = Convert.ToDateTime(dt.Rows[i]["DCO_fecha_produccion"].ToString()).ToShortDateString();
                    this.dgvDetalle["Fecha_vencimiento", i].Value = Convert.ToDateTime(dt.Rows[i]["DCO_fecha_vencimiento"].ToString()).ToShortDateString();
                    this.dgvDetalle["DCO_is_bonificacion", i].Value = dt.Rows[i]["DCO_is_bonificacion"].ToString() == "S" ? "SI" : "NO";
                    //this.dgvDetalle["PRO_is_igv", i].Value = (Convert.ToDouble(dt.Rows[i]["DCO_monto_igv"].ToString()) > 0) ? "S" : "N";
                    this.dgvDetalle["PRO_porcentaje_igv", i].Value = dt.Rows[i]["DCO_porcentaje_igv"].ToString();
                    this.dgvDetalle["PRO_porcentaje_isc", i].Value = dt.Rows[i]["DCO_porcentaje_isc"].ToString();
                    this.dgvDetalle["MontoIGV", i].Value = dt.Rows[i]["DCO_monto_igv"].ToString();
                    this.dgvDetalle["MontoISC", i].Value = dt.Rows[i]["DCO_monto_isc"].ToString();
                    this.dgvDetalle["Subunidades", i].Value = dt.Rows[i]["DCO_pro_ume_multiplo"].ToString();
                    this.dgvDetalle["DCO_monto_descuento", i].Value = dt.Rows[i]["DCO_monto_descuento"].ToString();
                    this.dgvDetalle["isValido", i].Value = "S";

                    if (Convert.ToInt32(this.dgvDetalle["Subunidades", i].Value.ToString()) == 1)
                    {
                        this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, i].ReadOnly = true;
                        this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, i].Value = "";
                        if (dt.Rows[i]["DCO_is_bonificacion"].ToString() == "S")
                        {
                            this.dgvDetalle.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                            this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, i].Style.BackColor = Color.Peru;
                        }
                        else
                        {
                            this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, i].Style.BackColor = SystemColors.InactiveCaption;
                        }
                    }
                    else
                    {
                        this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, i].ReadOnly = false;
                        if (dt.Rows[i]["DCO_is_bonificacion"].ToString() == "S")
                        {
                            this.dgvDetalle.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        }
                        else
                        {

                        }
                    }
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

        private void btnSocioNegocio_Click(object sender, EventArgs e)
        {
            double d;
            int u;
            if (numeroFilasActual() == 0)
            {
                _frmBusqueda ventana = new _frmBusqueda(false, "buscarProveedor", _obalSOCIO);
                DialogResult respuesta = ventana.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    eSOCIO _oeSOCIO = new eSOCIO();
                    _oeSOCIO.SOC_codigo = Int32.TryParse(ventana.pk.Trim(), out u) ? Convert.ToInt32(ventana.pk.Trim()) : -1;
                    DataTable dt = balSOCIO.obtenerRegistro(_oeSOCIO);
                    if (dt != null)
                    {
                        this.txtCodigoSocio.Text = dt.Rows[0]["SOC_codigo"].ToString();
                        this.txtNombreSocio.Text = dt.Rows[0]["SOC_nombre_razon_social"].ToString();
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

        private void btnGoSocio_Click(object sender, EventArgs e)
        {
            int u;
            eSOCIO o = new eSOCIO();
            o.SOC_codigo = Int32.TryParse(this.txtCodigoSocio.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigoSocio.Text.Trim()) : -1;

            frmDM_Socio o2 = new frmDM_Socio(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
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

            string colName = this.dgvDetalle.Columns[e.ColumnIndex].Name;
            if (colName == "Fecha_produccion")
            {
                Point punto = Cursor.Position;
                frm_EstablecerFecha o = new frm_EstablecerFecha(punto, "compra");

                DialogResult respuesta = o.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    this.dgvDetalle["Fecha_produccion", e.RowIndex].Value = Convert.ToDateTime(o.pk).ToShortDateString();
                    this.dgvDetalle.RefreshEdit();
                }
            }
            if (colName == "Fecha_vencimiento")
            {
                Point punto = Cursor.Position;
                frm_EstablecerFecha o = new frm_EstablecerFecha(punto, "compra");

                DialogResult respuesta = o.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    this.dgvDetalle["Fecha_vencimiento", e.RowIndex].Value = Convert.ToDateTime(o.pk).ToShortDateString();
                    this.dgvDetalle.RefreshEdit();
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
                        //impuestos += (dt.Rows[0]["PRO_is_igv"].ToString() == "S") ? "IGV[18] " : "";

                        this.dgvDetalle["PRO_codigo", indiceFila].Value = dt.Rows[0]["PRO_codigo"].ToString();
                        this.dgvDetalle["PRO_descripcion", indiceFila].Value = dt.Rows[0]["PRO_descripcion"].ToString();
                        this.dgvDetalle["DCO_precio_unitario", indiceFila].Value = 0;
                        this.dgvDetalle["Impuestos", indiceFila].Value = impuestos;
                        this.dgvDetalle["DCO_is_bonificacion", indiceFila].Value = "NO";
                        //this.dgvDetalle["PRO_is_IGV", indiceFila].Value = dt.Rows[0]["PRO_is_IGV"].ToString();
                        this.dgvDetalle["PRO_porcentaje_IGV", indiceFila].Value = Convert.ToDouble(dt.Rows[0]["PorcentajeIGV"].ToString());
                        this.dgvDetalle["PRO_porcentaje_ISC", indiceFila].Value = Convert.ToDouble(dt.Rows[0]["PRO_porcentaje_ISC"].ToString());
                        this.dgvDetalle["Subunidades", indiceFila].Value = dt.Rows[0]["UME_multiplo"].ToString();

                        if (Convert.ToInt16(dt.Rows[0]["UME_multiplo"].ToString()) == 1)
                        {
                            this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, indiceFila].ReadOnly = true;
                            this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, indiceFila].Value = "";
                            if (this.dgvDetalle[dgvDetalle.Columns["DCO_is_bonificacion"].Index, indiceFila].Value.ToString() == "NO")
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, indiceFila].Style.BackColor = SystemColors.InactiveCaption;
                            }
                            else
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, indiceFila].Style.BackColor = Color.Peru;
                            }
                        }
                        else
                        {
                            this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, indiceFila].ReadOnly = false;
                            this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, indiceFila].Style.BackColor = SystemColors.Window;
                        }
                    }

                    this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad"].Index, indiceFila].Value = 0;
                    this.dgvDetalle[dgvDetalle.Columns["DCO_porcentaje_descuento"].Index, indiceFila].Value = 0;
                    this.dgvDetalle[dgvDetalle.Columns["Fecha_produccion"].Index, indiceFila].Value = DateTime.Today.ToShortDateString();
                    this.dgvDetalle[dgvDetalle.Columns["Fecha_vencimiento"].Index, indiceFila].Value = DateTime.Today.ToShortDateString();

                    this.dgvDetalle.CurrentCell = this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad"].Index, indiceFila];
                    this.dgvDetalle["isValido", indiceFila].Value = "N";
                }
            }
        }

        private void ProcesarGrilla()
        {
            Double u;
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
                    if (this.dgvDetalle["DCO_cantidad", fila.Index].Value != null && this.dgvDetalle["DCO_is_bonificacion", fila.Index].Value.ToString() == "NO")
                    {
                        if (Convert.ToInt32(this.dgvDetalle["DCO_cantidad", fila.Index].Value) >= 0)
                        {
                            subunidades = Convert.ToInt16(this.dgvDetalle["Subunidades", fila.Index].Value.ToString());
                            cantidad = Convert.ToInt32(this.dgvDetalle["DCO_cantidad", fila.Index].Value.ToString());
                            cantidad_sub = subunidades > 1 ? (this.dgvDetalle["DCO_cantidad_submultiplo", fila.Index].Value != null ? Convert.ToInt32(this.dgvDetalle["DCO_cantidad_submultiplo", fila.Index].Value.ToString()) : 0) : 0;

                            precio_unitario = Convert.ToDouble(this.dgvDetalle["DCO_precio_unitario", fila.Index].Value.ToString());
                            precio_subunidad = Convert.ToDouble(precio_unitario / subunidades);
                            porcentaje_descuento = this.dgvDetalle["DCO_porcentaje_descuento", fila.Index].Value != null ? Double.TryParse(this.dgvDetalle["DCO_porcentaje_descuento", fila.Index].Value.ToString(), out u) ? Math.Round(Convert.ToDouble(this.dgvDetalle["DCO_porcentaje_descuento", fila.Index].Value.ToString()), 4) : 0 : 0;
                            monto_descuento = (precio_unitario * cantidad + precio_subunidad * cantidad_sub) * (porcentaje_descuento / 100);
                            subtotalFila = (precio_unitario * cantidad + precio_subunidad * cantidad_sub) * (1 - porcentaje_descuento / 100);

                            subtotalFilaConIGV = Convert.ToDouble(subtotalFila * (1 + Convert.ToDouble(this.dgvDetalle["PRO_porcentaje_igv", fila.Index].Value.ToString())));
                            //subtotalFilaConIGV = (this.dgvDetalle["PRO_is_igv", fila.Index].Value.ToString() == "S") ? Convert.ToDouble(subtotalFila * 1.18) : Convert.ToDouble(subtotalFila);
                            //IGVFila = (this.dgvDetalle["PRO_is_igv", fila.Index].Value.ToString() == "S") ? Math.Round(Convert.ToDouble(subtotalFila * 0.18), 2) : 0;
                            IGVFila = Math.Round(Convert.ToDouble(subtotalFila * Convert.ToDouble(this.dgvDetalle["PRO_porcentaje_igv", fila.Index].Value.ToString())), 2);
                            ISCFila = Math.Round(Convert.ToDouble(subtotalFilaConIGV * Convert.ToDouble(this.dgvDetalle["PRO_porcentaje_isc", fila.Index].Value.ToString())), 2);

                            subtotalGrilla += subtotalFila;
                            impuestosGrilla += IGVFila + ISCFila;

                            _IGVGrilla += IGVFila;
                            _ISCGrilla += ISCFila;

                            this.dgvDetalle["subtotal", fila.Index].Value = Math.Round(subtotalFila, 4);
                            this.dgvDetalle["MontoIGV", fila.Index].Value = IGVFila;
                            this.dgvDetalle["MontoISC", fila.Index].Value = ISCFila;
                            this.dgvDetalle["DCO_monto_descuento", fila.Index].Value = monto_descuento;
                            this.dgvDetalle["isValido", fila.Index].Value = "S";

                            if (Convert.ToInt32(this.dgvDetalle["Subunidades", fila.Index].Value) == 1)
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, fila.Index].ReadOnly = true;
                                this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, fila.Index].Value = "";
                            }
                            else
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, fila.Index].ReadOnly = false;
                                this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, fila.Index].Style.BackColor = SystemColors.Window;
                            }
                        }
                    }
                    else
                    {
                        this.dgvDetalle["isValido", fila.Index].Value = "N";
                    }
                    blanquearFilaBonificacion();
                }
            }

            double resultado_subtotal = Math.Round(subtotalGrilla, 4);
            double resultado_impuestos = Math.Round(impuestosGrilla, 2);
            double resultado_percepcion = Math.Round((resultado_subtotal + resultado_impuestos) * _porcentajePercepcion / 100, 2);
            double resultado_montototal = Math.Round(resultado_subtotal + resultado_impuestos + resultado_percepcion, 2);

            this.txtSubtotal.Text = resultado_subtotal.ToString();
            this.txtImpuestos.Text = resultado_impuestos.ToString();
            this.txtPercepcion.Text = resultado_percepcion.ToString();
            this.txtMontoTotal.Text = resultado_montototal.ToString();
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
                }
                else
                {
                    this.dgvDetalle.CancelEdit();
                }
            }
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

        private void blanquearFilaBonificacion()
        {
            foreach (DataGridViewRow fila in this.dgvDetalle.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (this.dgvDetalle["DCO_is_bonificacion", fila.Index].Value.ToString() == "SI")
                    {
                        this.dgvDetalle["DCO_precio_unitario", fila.Index].Value = 0;
                        this.dgvDetalle["DCO_porcentaje_descuento", fila.Index].Value = 0;
                        this.dgvDetalle["Subtotal", fila.Index].Value = 0;                        
                        this.dgvDetalle["Impuestos", fila.Index].Value = "";
                        this.dgvDetalle["MontoIGV", fila.Index].Value = 0;
                        this.dgvDetalle["MontoISC", fila.Index].Value = 0;
                        this.dgvDetalle["DCO_monto_descuento", fila.Index].Value = 0;
                        this.dgvDetalle["isValido", fila.Index].Value = "S";
                    }
                    else
                    {
                        //REEMPLAZAR
                        DataTable dt = new DataTable();

                        ePRODUCTO oePRODUCTO = new ePRODUCTO();
                        oePRODUCTO.PRO_codigo = this.dgvDetalle["PRO_codigo", fila.Index].Value.ToString();
                        eSOCIO oeSOCIO = new eSOCIO();
                        oeSOCIO.SOC_codigo = Convert.ToInt32(this.txtCodigoSocio.Text);

                        dt = balPRODUCTO.obtenerRegistroComplejo(oePRODUCTO, oeSOCIO);

                        string impuestos = "";

                        if (dt.Rows.Count > 0)
                        {
                            impuestos = (Convert.ToDouble(dt.Rows[0]["PorcentajeIGV"].ToString()) > 0) ? "IGV[" + dt.Rows[0]["PorcentajeIGV"].ToString() + "] " : "";
                            impuestos += (Convert.ToDouble(dt.Rows[0]["PRO_porcentaje_isc"].ToString()) > 0) ? "ISC[" + dt.Rows[0]["PRO_porcentaje_isc"].ToString() + "] " : "";
                                                        
                            this.dgvDetalle["PRO_descripcion", fila.Index].Value = dt.Rows[0]["PRO_descripcion"].ToString();
                            //this.dgvDetalle["DCO_precio_unitario", fila.Index].Value = dt.Rows[0]["DLP_precio"].ToString();
                            
                            
                            this.dgvDetalle["Impuestos", fila.Index].Value = impuestos;
                            this.dgvDetalle["DCO_is_bonificacion", fila.Index].Value = "NO";
                            //this.dgvDetalle["PRO_is_IGV", fila.Index].Value = dt.Rows[0]["PRO_is_IGV"].ToString();
                            this.dgvDetalle["PRO_porcentaje_IGV", fila.Index].Value = Convert.ToDouble(dt.Rows[0]["PorcentajeIGV"].ToString());
                            this.dgvDetalle["PRO_porcentaje_ISC", fila.Index].Value = Convert.ToDouble(dt.Rows[0]["PRO_porcentaje_ISC"].ToString());
                            this.dgvDetalle["Subunidades", fila.Index].Value = dt.Rows[0]["UME_multiplo"].ToString();

                            if (Convert.ToInt16(dt.Rows[0]["UME_multiplo"].ToString()) == 1)
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, fila.Index].ReadOnly = true;
                                this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, fila.Index].Value = "";
                                if (this.dgvDetalle[dgvDetalle.Columns["DCO_is_bonificacion"].Index, fila.Index].Value.ToString() == "NO")
                                {
                                    this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, fila.Index].Style.BackColor = SystemColors.InactiveCaption;
                                }
                                else
                                {
                                    this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, fila.Index].Style.BackColor = Color.Peru;
                                }
                            }
                            else
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, fila.Index].ReadOnly = false;
                                this.dgvDetalle[dgvDetalle.Columns["DCO_cantidad_submultiplo"].Index, fila.Index].Style.BackColor = SystemColors.Window;
                            }
                        }                        
                    }
                }
            }
        }

        private void eliminarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvDetalle.Rows[this.rowIndex].IsNewRow)
            {
                this.dgvDetalle.Rows.RemoveAt(this.rowIndex);
                ProcesarGrilla();
            }
        }

        private int rowIndex = 0;
        private void dgvDetalle_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                this.dgvDetalle.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvDetalle.CurrentCell = this.dgvDetalle.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgvDetalle, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }
}
