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
    public partial class frmOP_NotaCredito : _frmBaseOP
    {
        eNOTA_CREDITO _o;
        //variables de entorno
        string _listaPrecio = "";
        string _canal = "";
        int _zona = 0;
        string _serie = "";

        double _IGVGrilla = 0;
        double _ISCGrilla = 0;

        private bool _isCrearNuevo = false;
        
        private balSOCIO _obalSOCIO = new balSOCIO();
        private eNOTA_CREDITO _oeNOTA_CREDITO;
        private balNOTA_CREDITO _obalNOTA_CREDITO = new balNOTA_CREDITO();
        private balDETALLE_NC _obalDETALLE_NC = new balDETALLE_NC();
        private balPRODUCTO _obalPRODUCTO = new balPRODUCTO();
        private balSERIE _obalSERIE = new balSERIE();
        
        public frmOP_NotaCredito(eNOTA_CREDITO o)
        {
            InitializeComponent();
            tabla = "NOTA_CREDITO";

            this.cmbMotivoDevolucion.ValueMember = "MDE_codigo";
            this.cmbMotivoDevolucion.DisplayMember = "MDE_descripcion";
            this.cmbMotivoDevolucion.DataSource = balMOTIVO_DEVOLUCION.poblar();
            
            this.cmbTipoDocumento.ValueMember = "TDO_codigo";
            this.cmbTipoDocumento.DisplayMember = "TDO_nombre";
            this.cmbTipoDocumento.DataSource = balTIPO_DOCUMENTO.poblar();
            this.cmbTipoDocumento.SelectedValue = "NCR";
            //MessageBox.Show(this.cmbTipoDocumento.SelectedValue.ToString());
            
            this.cmbSerie.ValueMember = "SER_serie";
            this.cmbSerie.DisplayMember = "SER_serie";
            this.cmbSerie.DataSource = balSERIE.poblar();
            
            this.cmbDocumentoOrigen.ValueMember = "VTA_serie_correlativo";
            this.cmbDocumentoOrigen.DisplayMember = "VTA_serie_correlativo";
            this.cmbDocumentoOrigen.DataSource = balVENTA.poblar();

            this._o = o;
        }

        private void frmOP_NotaCredito_Load(object sender, EventArgs e)
        {
            Ultimo();

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balNOTA_CREDITO.obtenerRegistro(_o)); }
        }

        public override void Crear()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.dgvDetalle.Rows.Clear();
            this.cmbEstado.Text = "ABIERTO";
            this.btnSocioNegocio.Focus();
            _isCrearNuevo = true;
        }

        public override bool Guardar()
        {
            bool rpta = false;
            double montoigv, montoisc, subtotal, totalLinea;
            try
            {
                int u;
                double d;
                eNOTA_CREDITO _oeNOTA_CREDITO = new eNOTA_CREDITO();
                _oeNOTA_CREDITO.NCR_serie_correlativo = String.IsNullOrWhiteSpace(this.txtSerieCorrelativo.Text.Trim()) ? "" : this.txtSerieCorrelativo.Text.Trim();
                _oeNOTA_CREDITO.NCR_fecha_contabilizacion = Convert.ToDateTime(this.dtpFechaContabilizacion.Value.ToShortDateString());
                _oeNOTA_CREDITO.TDO_codigo = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";
                _oeNOTA_CREDITO.SER_serie = this.cmbSerie.SelectedValue != null ? this.cmbSerie.SelectedValue.ToString() : "";
                _oeNOTA_CREDITO.NCR_correlativo = correlativo;
                _oeNOTA_CREDITO.VTA_serie_correlativo = this.cmbDocumentoOrigen.SelectedValue != null ? this.cmbDocumentoOrigen.SelectedValue.ToString() : "";
                _oeNOTA_CREDITO.SOC_codigo = Int32.TryParse(this.txtCodigoSocio.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigoSocio.Text.Trim()) : -1;
                _oeNOTA_CREDITO.NCR_soc_nombre_razon = String.IsNullOrWhiteSpace(this.txtNombreSocio.Text.Trim()) ? "" : this.txtNombreSocio.Text.Trim();
                _oeNOTA_CREDITO.NCR_subtotal = Double.TryParse(this.txtSubtotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtSubtotal.Text.Trim()) : -1;
                _oeNOTA_CREDITO.NCR_monto_igv = _IGVGrilla;
                _oeNOTA_CREDITO.NCR_monto_isc = _ISCGrilla;
                _oeNOTA_CREDITO.NCR_monto_total = Double.TryParse(this.txtMontoTotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtMontoTotal.Text.Trim()) : -1;
                _oeNOTA_CREDITO.NCR_monto_total_texto = "TXT";
                _oeNOTA_CREDITO.NCR_comentario = this.txtComentario.Text;
                _oeNOTA_CREDITO.NCR_estado = "A";
                _oeNOTA_CREDITO.MDE_codigo = this.cmbMotivoDevolucion.SelectedValue != null ? (Int32.TryParse(this.cmbMotivoDevolucion.SelectedValue.ToString().Trim(), out u) ? Convert.ToInt32(this.cmbMotivoDevolucion.SelectedValue.ToString().Trim()) : (int?)null) : null;

                List<eDETALLE_NC> List = new List<eDETALLE_NC>();
                for (int i = 0; i < this.dgvDetalle.RowCount - 1; i++)
                {
                    montoigv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim()) : -1;
                    montoisc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim()) : -1;
                    subtotal = Double.TryParse(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim()) : -1;
                    totalLinea = subtotal + montoigv + montoisc;

                    eDETALLE_NC o = new eDETALLE_NC();
                    o.NCR_serie_correlativo = String.IsNullOrWhiteSpace(this.txtSerieCorrelativo.Text.Trim()) ? "" : this.txtSerieCorrelativo.Text.Trim();
                    o.PRO_codigo = (this.dgvDetalle.Rows[i].Cells["PRO_codigo"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    //o.DVE_is_bonificacion = (this.dgvDetalle.Rows[i].Cells["DVE_is_bonificacion"].Value.ToString().Substring(0, 1) ?? "N").ToString().ToUpper().Trim();
                    o.DNC_pro_descripcion = (this.dgvDetalle.Rows[i].Cells["PRO_descripcion"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    o.DNC_pro_ume_multiplo = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim()) : -1;
                    o.DNC_cantidad = this.dgvDetalle.Rows[i].Cells["DNC_cantidad"].Value != null ? Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DNC_cantidad"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DNC_cantidad"].Value.ToString().Trim()) : -1 : -1;

                    o.DNC_cantidad_submultiplo = o.DNC_pro_ume_multiplo > 1 ?
                        this.dgvDetalle.Rows[i].Cells["DNC_cantidad_sub"].Value != null ?
                        Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DNC_cantidad_sub"].Value.ToString().Trim(), out u) ?
                        Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DNC_cantidad_sub"].Value.ToString().Trim())
                        : 0
                        : 0
                        : (int?)null;

                    o.DNC_precio_unitario = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DNC_precio_unitario"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DNC_precio_unitario"].Value.ToString().Trim()) : -1;
                    o.DNC_monto_subtotal = subtotal;


                    o.DNC_monto_descuento = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DNC_monto_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DNC_monto_descuento"].Value.ToString().Trim()) : -1;
                    o.DNC_porcentaje_descuento = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DNC_porcentaje_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DNC_porcentaje_descuento"].Value.ToString().Trim()) : -1;
                    o.DNC_monto_igv = montoigv;
                    o.DNC_monto_isc = montoisc;
                    o.DNC_porcentaje_igv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim()) : -1;
                    o.DNC_porcentaje_isc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim()) : -1;
                    o.DNC_monto_total_linea = subtotal + montoigv + montoisc;
                    o.DNC_memo = "";
                    o.DNC_numero_fila = i + 1;

                    List.Add(o);
                }

                if (checkGrilla())
                {
                    if (balNOTA_CREDITO.insertarRegistroMaestroDetalle(_oeNOTA_CREDITO, List))
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\r\n" + ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                eNOTA_CREDITO _oeNOTA_CREDITO = new eNOTA_CREDITO();
                _oeNOTA_CREDITO.NCR_serie_correlativo = String.IsNullOrWhiteSpace(this.txtSerieCorrelativo.Text.Trim()) ? "" : this.txtSerieCorrelativo.Text.Trim();
                _oeNOTA_CREDITO.NCR_fecha_contabilizacion = Convert.ToDateTime(this.dtpFechaContabilizacion.Value.ToShortDateString());
                _oeNOTA_CREDITO.TDO_codigo = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";
                _oeNOTA_CREDITO.SER_serie = this.cmbSerie.SelectedValue != null ? this.cmbSerie.SelectedValue.ToString() : "";
                _oeNOTA_CREDITO.NCR_correlativo = correlativo;
                _oeNOTA_CREDITO.VTA_serie_correlativo = this.cmbDocumentoOrigen.SelectedValue != null ? this.cmbDocumentoOrigen.SelectedValue.ToString() : "";
                _oeNOTA_CREDITO.SOC_codigo = Int32.TryParse(this.txtCodigoSocio.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigoSocio.Text.Trim()) : -1;
                _oeNOTA_CREDITO.NCR_soc_nombre_razon = String.IsNullOrWhiteSpace(this.txtNombreSocio.Text.Trim()) ? "" : this.txtNombreSocio.Text.Trim();
                _oeNOTA_CREDITO.NCR_subtotal = Double.TryParse(this.txtSubtotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtSubtotal.Text.Trim()) : -1;
                _oeNOTA_CREDITO.NCR_monto_igv = _IGVGrilla;
                _oeNOTA_CREDITO.NCR_monto_isc = _ISCGrilla;
                _oeNOTA_CREDITO.NCR_monto_total = Double.TryParse(this.txtMontoTotal.Text.Trim(), out d) ? Convert.ToDouble(this.txtMontoTotal.Text.Trim()) : -1;
                _oeNOTA_CREDITO.NCR_monto_total_texto = "EJEMPLO";
                _oeNOTA_CREDITO.NCR_comentario = this.txtComentario.Text;

                string estado = "";
                switch (this.cmbEstado.Text)
                {
                    case "ABIERTO": estado = "A"; break;                    
                    case "CERRADO": estado = "C"; break;
                    case "ANULADO": estado = "N"; break;
                }

                _oeNOTA_CREDITO.NCR_estado = estado;
                //_oeNOTA_CREDITO.MDE_codigo = this.cmbMotivoDevolucion.SelectedValue != null ? (Int32.TryParse(this.cmbMotivoDevolucion.Text.Trim(), out u) ? Convert.ToInt32(this.cmbMotivoDevolucion.Text.Trim()) : (int?)null) : null;
                _oeNOTA_CREDITO.MDE_codigo = this.cmbMotivoDevolucion.SelectedValue != null ? (Int32.TryParse(this.cmbMotivoDevolucion.SelectedValue.ToString().Trim(), out u) ? Convert.ToInt32(this.cmbMotivoDevolucion.SelectedValue.ToString().Trim()) : (int?)null) : null;
                List<eDETALLE_NC> List = new List<eDETALLE_NC>();
                for (int i = 0; i < this.dgvDetalle.RowCount - 1; i++)
                {
                    montoigv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoIGV"].Value.ToString().Trim()) : -1;
                    montoisc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["MontoISC"].Value.ToString().Trim()) : -1;
                    subtotal = Double.TryParse(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["Subtotal"].Value.ToString().Trim()) : -1;
                    totalLinea = subtotal + montoigv + montoisc;

                    eDETALLE_NC o = new eDETALLE_NC();
                    o.NCR_serie_correlativo = String.IsNullOrWhiteSpace(this.txtSerieCorrelativo.Text.Trim()) ? "" : this.txtSerieCorrelativo.Text.Trim();
                    o.PRO_codigo = (this.dgvDetalle.Rows[i].Cells["PRO_codigo"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    //o.DVE_is_bonificacion = (this.dgvDetalle.Rows[i].Cells["DVE_is_bonificacion"].Value.ToString().Substring(0, 1) ?? "N").ToString().ToUpper().Trim();
                    o.DNC_pro_descripcion = (this.dgvDetalle.Rows[i].Cells["PRO_descripcion"].Value ?? string.Empty).ToString().ToUpper().Trim();
                    o.DNC_pro_ume_multiplo = Int32.TryParse(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["Subunidades"].Value.ToString().Trim()) : -1;
                    o.DNC_cantidad = this.dgvDetalle.Rows[i].Cells["DNC_cantidad"].Value != null ? Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DNC_cantidad"].Value.ToString().Trim(), out u) ? Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DNC_cantidad"].Value.ToString().Trim()) : -1 : -1;

                    o.DNC_cantidad_submultiplo = o.DNC_pro_ume_multiplo > 1 ?
                        this.dgvDetalle.Rows[i].Cells["DNC_cantidad_sub"].Value != null ?
                        Int32.TryParse(this.dgvDetalle.Rows[i].Cells["DNC_cantidad_sub"].Value.ToString().Trim(), out u) ?
                        Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DNC_cantidad_sub"].Value.ToString().Trim())
                        : 0
                        : 0
                        : (int?)null;

                    o.DNC_precio_unitario = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DNC_precio_unitario"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DNC_precio_unitario"].Value.ToString().Trim()) : -1;
                    o.DNC_monto_subtotal = subtotal;


                    o.DNC_monto_descuento = Double.TryParse(this.dgvDetalle.Rows[i].Cells["DNC_monto_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DNC_monto_descuento"].Value.ToString().Trim()) : -1;
                    o.DNC_porcentaje_descuento = this.dgvDetalle.Rows[i].Cells["DNC_porcentaje_descuento"].Value != null ? Double.TryParse(this.dgvDetalle.Rows[i].Cells["DNC_porcentaje_descuento"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DNC_porcentaje_descuento"].Value.ToString().Trim()) : -1 : 0;
                    o.DNC_monto_igv = montoigv;
                    o.DNC_monto_isc = montoisc;
                    o.DNC_porcentaje_igv = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_igv"].Value.ToString().Trim()) : -1;
                    o.DNC_porcentaje_isc = Double.TryParse(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim(), out d) ? Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["PRO_porcentaje_isc"].Value.ToString().Trim()) : -1;
                    o.DNC_monto_total_linea = subtotal + montoigv + montoisc;
                    o.DNC_memo = "";
                    o.DNC_numero_fila = i + 1;

                    List.Add(o);
                }

                if (checkGrilla())
                {
                    if (balNOTA_CREDITO.actualizarRegistroMaestroDetalle(_oeNOTA_CREDITO, List))
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
            bool rpta = false;
            try
            {
                if (_oeNOTA_CREDITO == null) _oeNOTA_CREDITO = new eNOTA_CREDITO();
                _oeNOTA_CREDITO.NCR_serie_correlativo = this.txtSerieCorrelativo.Text;

                if (balNOTA_CREDITO.anularRegistro(_oeNOTA_CREDITO))
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
            cargarDatos(balNOTA_CREDITO.primerRegistro());
        }

        public override void Anterior()
        {
            eNOTA_CREDITO _oeNOTA_CREDITO = new eNOTA_CREDITO();
            _oeNOTA_CREDITO.NCR_serie_correlativo = this.txtSerieCorrelativo.Text;
            cargarDatos(balNOTA_CREDITO.anteriorRegistro(_oeNOTA_CREDITO));
        }

        public override void Siguiente()
        {
            eNOTA_CREDITO _oeNOTA_CREDITO = new eNOTA_CREDITO();
            _oeNOTA_CREDITO.NCR_serie_correlativo = this.txtSerieCorrelativo.Text;
            cargarDatos(balNOTA_CREDITO.siguienteRegistro(_oeNOTA_CREDITO));
        }

        public override void Ultimo()
        {
            cargarDatos(balNOTA_CREDITO.ultimoRegistro());
        }

        public override void Buscar()
        {
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", _obalNOTA_CREDITO);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                if (_oeNOTA_CREDITO == null) _oeNOTA_CREDITO = new eNOTA_CREDITO();
                _oeNOTA_CREDITO.NCR_serie_correlativo = ventana.pk;
                DataTable dt = balNOTA_CREDITO.obtenerRegistro(_oeNOTA_CREDITO);
                cargarDatos(dt);
            }
        }

        private void cargarDatos(DataTable dt)
        {
            short u;
            if (dt != null)
            {                
                this.dtpFechaContabilizacion.Text = dt.Rows[0]["NCR_fecha_contabilizacion"].ToString();
                this.cmbTipoDocumento.SelectedValue = dt.Rows[0]["TDO_codigo"].ToString();
                this.cmbSerie.SelectedValue = dt.Rows[0]["SER_serie"].ToString();
                this.txtSerieCorrelativo.Text = dt.Rows[0]["NCR_serie_correlativo"].ToString();
                //correlativo
                this.txtCodigoSocio.Text = dt.Rows[0]["SOC_codigo"].ToString();
                this.txtNombreSocio.Text = dt.Rows[0]["NCR_soc_nombre_razon"].ToString();
                this.txtSubtotal.Text = dt.Rows[0]["NCR_subtotal"].ToString();
                //PORC PERC
                //MONTO IGV
                //MONTO ISC
                this.txtImpuestos.Text = (Convert.ToDecimal(dt.Rows[0]["NCR_monto_igv"].ToString()) + Convert.ToDecimal(dt.Rows[0]["NCR_monto_isc"].ToString())).ToString();
                this.txtMontoTotal.Text = dt.Rows[0]["NCR_monto_total"].ToString();
                //MONTO TOTAL TXT
                this.txtComentario.Text = dt.Rows[0]["NCR_comentario"].ToString();

                switch (dt.Rows[0]["NCR_estado"].ToString())
                {
                    case "A": this.cmbEstado.Text = "ABIERTO"; break;
                    case "C": this.cmbEstado.Text = "CERRADO"; break;
                    case "N": this.cmbEstado.Text = "ANULADO"; break;
                }
                this.cmbDocumentoOrigen.SelectedValue = dt.Rows[0]["VTA_serie_correlativo"].ToString();
                this.cmbMotivoDevolucion.SelectedValue = Int16.TryParse(dt.Rows[0]["MDE_codigo"].ToString(), out u) ? Convert.ToInt16(dt.Rows[0]["MDE_codigo"].ToString()) : -1;
                
                this.dgvDetalle.Rows.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.dgvDetalle.Rows.Add();

                    this.dgvDetalle["PRO_codigo", i].Value = dt.Rows[i]["PRO_codigo"].ToString();                    
                    this.dgvDetalle["PRO_descripcion", i].Value = dt.Rows[i]["DNC_pro_descripcion"].ToString();
                    this.dgvDetalle["DNC_cantidad", i].Value = dt.Rows[i]["DNC_cantidad"].ToString();
                    if (Convert.ToInt16(dt.Rows[i]["DNC_pro_ume_multiplo"].ToString()) == 1)
                    {
                        this.dgvDetalle["DNC_cantidad_sub", i].ReadOnly = true;
                        this.dgvDetalle["DNC_cantidad_sub", i].Value = "";
                        this.dgvDetalle["DNC_cantidad_sub", i].Style.BackColor = SystemColors.InactiveCaption;
                    }
                    else
                    {
                        this.dgvDetalle["DNC_cantidad_sub", i].Value = dt.Rows[i]["DNC_cantidad_submultiplo"].ToString();
                    }
                    this.dgvDetalle["DNC_precio_unitario", i].Value = dt.Rows[i]["DNC_precio_unitario"].ToString();
                    this.dgvDetalle["DNC_porcentaje_descuento", i].Value = dt.Rows[i]["DNC_porcentaje_descuento"].ToString();
                    this.dgvDetalle["Subtotal", i].Value = dt.Rows[i]["DNC_monto_subtotal"].ToString();
                    this.dgvDetalle["PRO_porcentaje_igv", i].Value = dt.Rows[i]["DNC_porcentaje_igv"].ToString();
                    this.dgvDetalle["PRO_porcentaje_isc", i].Value = dt.Rows[i]["DNC_porcentaje_isc"].ToString();

                    string impuestos = (Convert.ToDouble(dt.Rows[i]["DNC_monto_igv"].ToString()) > 0) ? "IGV[" + dt.Rows[i]["DNC_porcentaje_igv"].ToString() + "] " : "";
                    impuestos += (Convert.ToDouble(dt.Rows[i]["DNC_monto_isc"].ToString()) > 0) ? "ISC[" + dt.Rows[i]["DNC_porcentaje_isc"].ToString() + "] " : "";


                    this.dgvDetalle["Impuestos", i].Value = impuestos;
                    this.dgvDetalle["MontoIGV", i].Value = dt.Rows[i]["DNC_monto_igv"].ToString();
                    this.dgvDetalle["MontoISC", i].Value = dt.Rows[i]["DNC_monto_isc"].ToString();
                    this.dgvDetalle["Subunidades", i].Value = dt.Rows[i]["DNC_pro_ume_multiplo"].ToString();                    
                    this.dgvDetalle["DNC_monto_descuento", i].Value = dt.Rows[i]["DNC_monto_descuento"].ToString();
                    this.dgvDetalle["isValido", i].Value = "S";

                    if (Convert.ToInt32(this.dgvDetalle["Subunidades", i].Value.ToString()) == 1)
                    {
                        this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, i].ReadOnly = true;
                        this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, i].Value = "";
                    }
                    else
                    {
                        this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, i].ReadOnly = false;
                    }                    
                }
            }
            else
            {
                _cfgUtil.clearFields(this.gpbInformacion);

                this.txtSerieCorrelativo.ReadOnly = true;
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

                        _listaPrecio = dt.Rows[0]["LPR_codigo"].ToString();
                        _canal = dt.Rows[0]["CAN_codigo"].ToString();
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
                        this.dgvDetalle["DNC_precio_unitario", indiceFila].Value = dt.Rows[0]["DLP_precio"].ToString();
                        this.dgvDetalle["DNC_porcentaje_descuento", indiceFila].Value = dt.Rows[0]["DSC_porcentaje"].ToString();
                        this.dgvDetalle["Impuestos", indiceFila].Value = impuestos;
                        this.dgvDetalle["PRO_porcentaje_IGV", indiceFila].Value = Convert.ToDouble(dt.Rows[0]["PorcentajeIGV"].ToString());
                        this.dgvDetalle["PRO_porcentaje_ISC", indiceFila].Value = Convert.ToDouble(dt.Rows[0]["PRO_porcentaje_ISC"].ToString());
                        this.dgvDetalle["Subunidades", indiceFila].Value = dt.Rows[0]["UME_multiplo"].ToString();

                        if (Convert.ToInt16(dt.Rows[0]["UME_multiplo"].ToString()) == 1)
                        {
                            this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, indiceFila].ReadOnly = true;
                            this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, indiceFila].Style.BackColor = SystemColors.InactiveCaption;
                            this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, indiceFila].Value = "";
                            //if (this.dgvDetalle[dgvDetalle.Columns["DVE_is_bonificacion"].Index, indiceFila].Value.ToString() == "NO")
                            //{
                            //    this.dgvDetalle[dgvDetalle.Columns["DVE_cantidad_sub"].Index, indiceFila].Style.BackColor = SystemColors.InactiveCaption;
                            //}
                            //else
                            //{
                            //    this.dgvDetalle[dgvDetalle.Columns["DVE_cantidad_sub"].Index, indiceFila].Style.BackColor = Color.Peru;
                            //}
                        }
                        else
                        {
                            this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, indiceFila].ReadOnly = false;
                            this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, indiceFila].Style.BackColor = SystemColors.Window;
                        }
                    }

                    //this.dgvDetalle.BeginEdit(false);

                    this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad"].Index, indiceFila].Value = 0;
                    //this.dgvDetalle.BeginEdit(false);

                    this.dgvDetalle.CurrentCell = this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad"].Index, indiceFila];
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
                    if (this.dgvDetalle["DNC_cantidad", fila.Index].Value != null)
                    {
                        if (Convert.ToInt32(this.dgvDetalle["DNC_cantidad", fila.Index].Value) >= 0)
                        {
                            subunidades = Convert.ToInt16(this.dgvDetalle["Subunidades", fila.Index].Value.ToString());
                            cantidad = Convert.ToInt32(this.dgvDetalle["DNC_cantidad", fila.Index].Value.ToString());
                            cantidad_sub = subunidades > 1 ? (this.dgvDetalle["DNC_cantidad_sub", fila.Index].Value != null ? Convert.ToInt32(this.dgvDetalle["DNC_cantidad_sub", fila.Index].Value.ToString()) : 0) : 0;                            
                            precio_unitario = Convert.ToDouble(this.dgvDetalle["DNC_precio_unitario", fila.Index].Value.ToString());
                            precio_subunidad = Convert.ToDouble(precio_unitario / subunidades);
                            porcentaje_descuento = this.dgvDetalle["DNC_porcentaje_descuento", fila.Index].Value != null ? Math.Round(Convert.ToDouble(this.dgvDetalle["DNC_porcentaje_descuento", fila.Index].Value.ToString()), 4) : 0;
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
                            this.dgvDetalle["DNC_monto_descuento", fila.Index].Value = monto_descuento;
                            this.dgvDetalle["isValido", fila.Index].Value = "S";
                            
                            if (Convert.ToInt32(this.dgvDetalle["Subunidades", fila.Index].Value) == 1)
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, fila.Index].ReadOnly = true;
                                this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, fila.Index].Value = "";
                            }
                            else
                            {
                                this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, fila.Index].ReadOnly = false;
                                this.dgvDetalle[dgvDetalle.Columns["DNC_cantidad_sub"].Index, fila.Index].Style.BackColor = SystemColors.Window;
                            }
                        }
                    }
                    else
                    {
                        this.dgvDetalle["isValido", fila.Index].Value = "N";
                    }
                }                
            }

            double resultado_subtotal = Math.Round(subtotalGrilla, 4);
            double resultado_impuestos = Math.Round(impuestosGrilla, 2);
            double resultado_montototal = Math.Round(resultado_subtotal + resultado_impuestos, 2);

            this.txtSubtotal.Text = resultado_subtotal.ToString();
            this.txtImpuestos.Text = resultado_impuestos.ToString();
            this.txtMontoTotal.Text = resultado_montototal.ToString();       
        }
                        
        int correlativo = 0;

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

        //COMBOS EVENTOS Y BOTONES
        private void cmbSerie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (_oeVENTA == null) _oeVENTA = new eVENTA();
            //_oeVENTA.TDO_codigo = this.cmbTipoDocumento.SelectedValue.ToString();
            //_oeVENTA.SER_serie = this.cmbSerie.SelectedValue.ToString();
            //DataTable dt = _obalVENTA.siguienteCorrelativo(_oeVENTA);
            //if (dt != null)
            //{
            //    this.txtSerieCorrelativo.Text = dt.Rows[0]["Concatenado"].ToString();
            //    _serie = dt.Rows[0]["SER_serie"].ToString();
            //    correlativo = Convert.ToInt32(dt.Rows[0]["Ser_correlativo"].ToString());
            //}
        }

        private void cmbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSerie.SelectedValue != null && _isCrearNuevo)
            {
                if (_oeNOTA_CREDITO == null) _oeNOTA_CREDITO = new eNOTA_CREDITO();
                _oeNOTA_CREDITO.TDO_codigo = this.cmbTipoDocumento.SelectedValue.ToString();
                _oeNOTA_CREDITO.SER_serie = this.cmbSerie.SelectedValue.ToString();
                DataTable dt = balVENTA.siguienteCorrelativo(_oeNOTA_CREDITO);
                if (dt != null)
                {
                    this.txtSerieCorrelativo.Text = dt.Rows[0]["Concatenado"].ToString();
                    _serie = dt.Rows[0]["SER_serie"].ToString();
                    correlativo = Convert.ToInt32(dt.Rows[0]["SER_correlativo"].ToString());
                }
            }
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoDocumento.SelectedIndex >= 0)
            {
                eTIPO_DOCUMENTO oeTIPO_DOCUMENTO = new eTIPO_DOCUMENTO();
                oeTIPO_DOCUMENTO.TDO_codigo = this.cmbTipoDocumento.SelectedValue.ToString();
                
                this.cmbSerie.DisplayMember = "SER_serie";
                this.cmbSerie.ValueMember = "SER_serie";
                this.cmbSerie.DataSource = balSERIE.CargarSeries(oeTIPO_DOCUMENTO);
            }
        }

        private void cmbTipoDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eTIPO_DOCUMENTO oeTIPO_DOCUMENTO = new eTIPO_DOCUMENTO();
            oeTIPO_DOCUMENTO.TDO_codigo = this.cmbTipoDocumento.SelectedValue.ToString();
            this.cmbSerie.DataSource = balSERIE.CargarSeries(oeTIPO_DOCUMENTO);
            this.cmbSerie.DisplayMember = "SER_serie";
            this.cmbSerie.ValueMember = "SER_serie";
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if ((keyData == Keys.Enter) && this.dgvDetalle.RowCount > 0 && this.txtCodigoSocio.Text.Length > 0 && this.dgvDetalle.CurrentRow != null)
            {
                int IndiceFila = this.dgvDetalle.CurrentRow.Index;
                if (this.dgvDetalle["DNC_cantidad", IndiceFila].Value != null || this.dgvDetalle["DNC_cantidad_sub", IndiceFila].Value != null)
                {
                    autocompletarCeldasGrilla(numeroFilasActual());
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

        private void dgvDetalle_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvDetalle.IsCurrentCellDirty)
            {
                if (this.dgvDetalle["PRO_codigo", this.dgvDetalle.CurrentRow.Index].Value != null)
                {
                    dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    ProcesarGrilla();
                    //this.dgvDetalle.BeginEdit(false);
                }
                else
                {
                    this.dgvDetalle.CancelEdit();
                }
                //this.dgvDetalle.BeginEdit(false);
            }
            //this.dgvDetalle.BeginEdit(false);
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
        
        private void btnGoMotivoDevolucion_Click(object sender, EventArgs e)
        {
            eMOTIVO_DEVOLUCION o = new eMOTIVO_DEVOLUCION();
            o.MDE_codigo = this.cmbMotivoDevolucion.SelectedValue != null ? Convert.ToInt32(this.cmbMotivoDevolucion.SelectedValue.ToString()) : -1;

            frmDM_MotivoDevolucion o2 = new frmDM_MotivoDevolucion(o);
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

        private void btnGoDocumentoOrigen_Click(object sender, EventArgs e)
        {
            eVENTA oeVENTA = new eVENTA();
            oeVENTA.VTA_serie_correlativo = this.cmbDocumentoOrigen.Text.Trim();
            frmOP_Venta o = new frmOP_Venta(oeVENTA);
            o.MdiParent = this.MdiParent;
            o.Show();
        }

        //Refresco combobox
        private void cmbDocumentoOrigen_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbDocumentoOrigen.SelectedValue != null)
            {
                valorSeleccionado = this.cmbDocumentoOrigen.SelectedValue.ToString();
            }
            this.cmbDocumentoOrigen.DataSource = balVENTA.poblar();
            this.cmbDocumentoOrigen.SelectedValue = valorSeleccionado;            
        }

        private void cmbMotivoDevolucion_DropDown(object sender, EventArgs e)
        {
            int valorSeleccionado = -1;
            if (this.cmbMotivoDevolucion.SelectedValue != null)
            {
                valorSeleccionado = Convert.ToInt32(this.cmbMotivoDevolucion.SelectedValue.ToString());
            }
            this.cmbMotivoDevolucion.DataSource = balMOTIVO_DEVOLUCION.poblar();
            this.cmbMotivoDevolucion.SelectedValue = valorSeleccionado;            
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

        private void cmbSerie_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbSerie.SelectedValue != null)
            {
                valorSeleccionado = this.cmbSerie.SelectedValue.ToString();
            }

            if (this.cmbTipoDocumento.SelectedIndex >= 0)
            {
                eTIPO_DOCUMENTO oeTIPO_DOCUMENTO = new eTIPO_DOCUMENTO();
                oeTIPO_DOCUMENTO.TDO_codigo = this.cmbTipoDocumento.SelectedValue.ToString();
            }
                           
            //this.cmbSerie.DataSource = balSERIE.CargarSeries(oeTIPO_DOCUMENTO);            
            this.cmbSerie.SelectedValue = valorSeleccionado;
        }
    }
}