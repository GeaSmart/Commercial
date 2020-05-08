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
    public partial class frmDM_Socio : _frmBaseDM
    {
        eSOCIO _o;
        public frmDM_Socio(eSOCIO o)
        {
            InitializeComponent();
            tabla = "SOCIO";

            this.cmbListaPrecio.ValueMember = "LPR_codigo";
            this.cmbListaPrecio.DisplayMember = "LPR_nombre";
            this.cmbListaPrecio.DataSource = balLISTA_PRECIO.poblar();
            
            this.cmbTipoNegocio.ValueMember = "TNE_codigo";
            this.cmbTipoNegocio.DisplayMember = "TNE_nombre";
            this.cmbTipoNegocio.DataSource = balTIPO_NEGOCIO.poblar();
            
            this.cmbCanal.ValueMember = "CAN_codigo";
            this.cmbCanal.DisplayMember = "CAN_nombre";
            this.cmbCanal.DataSource = balCANAL.poblar();
            
            this.cmbUbigeo.ValueMember = "UBI_id";
            this.cmbUbigeo.DisplayMember = "UBI_distrito";
            this.cmbUbigeo.DataSource = balUBIGEO.poblar();
            
            this.cmbZona.ValueMember = "ZON_codigo";
            this.cmbZona.DisplayMember = "ZON_nombre";
            this.cmbZona.DataSource = balZONA.poblar();
            
            this.cmbTipoDocumentoVenta.ValueMember = "TDO_codigo";
            this.cmbTipoDocumentoVenta.DisplayMember = "TDO_nombre";
            this.cmbTipoDocumentoVenta.DataSource = balTIPO_DOCUMENTO.poblar();
            
            this.cmbCondicionPago.ValueMember = "CPA_codigo";
            this.cmbCondicionPago.DisplayMember = "CPA_descripcion";
            this.cmbCondicionPago.DataSource = balCONDICION_PAGO.poblar();
            
            this.cmbVendedor.ValueMember = "VEN_codigo";
            this.cmbVendedor.DisplayMember = "VEN_nombre_completo";
            this.cmbVendedor.DataSource = balVENDEDOR.poblar();

            this._o = o;
        }

        private void frmDM_Socio_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balSOCIO.obtenerRegistro(_o)); }
        }

        public override void Nuevo()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.chkPercepcion.Checked = false;
            this.cmbPorcentajePercepcion.Enabled = false;
            this.chkActivo.Checked = true;
            //this.cmbPorcentajePercepcion.SelectedIndex = -1;
        }

        public override bool Guardar()
        {
            double d;
            int i;
            bool rpta = false;
            try
            {
                eSOCIO o = new eSOCIO();
                //o.SOC_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
                o.SOC_tipo_socio = this.cmbTipoSocio.Text.Trim();
                o.SOC_apellido_paterno = this.txtApellidoPaterno.Text.Trim();
                o.SOC_apellido_materno = this.txtApellidoMaterno.Text.Trim();
                o.SOC_nombres = this.txtNombres.Text.Trim();
                o.SOC_nombre_razon_social = this.txtRazonSocial.Text.Trim();
                o.SOC_numero_documento = this.txtNumeroDocumento.Text.Trim();
                o.SOC_direccion = this.txtDireccion.Text.Trim();
                o.SOC_referencia_direccion = this.txtReferencia.Text.Trim();
                o.SOC_telefono_fijo = this.txtTelefonoFijo.Text.Trim();
                o.SOC_telefono_movil = this.txtTelefonoMovil.Text.Trim();
                o.SOC_email = this.txtEmail.Text.Trim();
                o.SOC_web = this.txtWeb.Text.Trim();
                o.SOC_is_agente_retencion = this.chkRetencion.Checked ? "S" : "N";
                o.SOC_is_agente_percepcion = this.chkPercepcion.Checked ? "S" : "N";
                o.SOC_porcentaje_percepcion = Double.TryParse(this.cmbPorcentajePercepcion.Text.Trim(), out d) ? Convert.ToDouble(this.cmbPorcentajePercepcion.Text.Trim()) : (double?)null;                
                o.SOC_is_validar_bonificacion = this.chkValidarBonificacion.Checked ? "S" : "N";
                o.SOC_is_bonificacion_personalizada = this.chkBoniPersonal.Checked ? "S" : "N";
                o.SOC_is_descuento_personalizado = this.chkDescuentoPersonal.Checked ? "S" : "N";
                o.SOC_is_key_account = this.chkKeyAcc.Checked ? "S" : "N";
                o.SOC_dias_credito = Int32.TryParse(this.cmbDiasCredito.Text.Trim(), out i) ? Convert.ToInt16(this.cmbDiasCredito.Text.Trim()) : -1;
                o.SOC_fecha_registro = Convert.ToDateTime(this.dtpFechaRegistro.Value.ToShortDateString());
                o.SOC_linea_credito = Double.TryParse(this.nudLineaCredito.Text.Trim(), out d) ? Convert.ToDouble(this.nudLineaCredito.Text.Trim()) : -1;
                o.SOC_tipo_persona = this.cmbTipoPersona.Text.Trim();
                o.SOC_is_activo = this.chkActivo.Checked ? "S" : "N";
                o.SOC_comentario = this.txtComentario.Text.Trim();
                o.SOC_tipo_documento_identidad = this.cmbTipoDocumentoId.Text.Trim();
                o.SOC_latitud = String.IsNullOrWhiteSpace(this.txtLatitud.Text.Trim()) ? (double?)null : Convert.ToDouble(this.txtLatitud.Text.Trim());
                o.SOC_longitud = String.IsNullOrWhiteSpace(this.txtLongitud.Text.Trim()) ? (double?)null : Convert.ToDouble(this.txtLongitud.Text.Trim());
                o.LPR_codigo = String.IsNullOrWhiteSpace(this.cmbListaPrecio.Text) ? null : this.cmbListaPrecio.SelectedValue.ToString();
                o.TNE_codigo = String.IsNullOrWhiteSpace(this.cmbTipoNegocio.Text) ? null : this.cmbTipoNegocio.SelectedValue.ToString();
                o.CAN_codigo = String.IsNullOrWhiteSpace(this.cmbCanal.Text) ? null : this.cmbCanal.SelectedValue.ToString();
                o.UBI_id = String.IsNullOrWhiteSpace(this.cmbUbigeo.Text) ? null : this.cmbUbigeo.SelectedValue.ToString();
                o.ZON_codigo = String.IsNullOrWhiteSpace(this.cmbZona.Text) ? -1 : Convert.ToInt32(this.cmbZona.SelectedValue.ToString().Trim());
                o.VEN_codigo = String.IsNullOrWhiteSpace(this.cmbVendedor.Text) ? (int?)null : Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString().Trim());
                
                o.TDO_codigo = String.IsNullOrWhiteSpace(this.cmbTipoDocumentoVenta.Text) ? null : this.cmbTipoDocumentoVenta.SelectedValue.ToString();
                o.CPA_codigo = String.IsNullOrWhiteSpace(this.cmbCondicionPago.Text) ? null : this.cmbCondicionPago.SelectedValue.ToString();

                if (balSOCIO.insertarRegistro(o))
                {
                    mensaje("guardar","");
                    //mensaje("guardar","");
                    //MessageBox.Show("El registro fue guardado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCodigo.ReadOnly = true;
                    rpta = true;
                }
            }
            catch (CustomException ex)
            {
                if (ex.tupla != null)
                {
                    foreach (Control c in this.gpbInformacion.Controls)
                    {
                        foreach (var item in ex.tupla)
                        {
                            if (c.Tag != null && c.Tag.ToString() == item.name)
                            {
                                errValidacion.SetError(c, item.message.ToString());
                            }
                        }
                        
                        foreach (Control x in c.Controls)
                        {
                            foreach (var item in ex.tupla)
                            {
                                if (x.Tag != null && x.Tag.ToString() == item.name)
                                {
                                    errValidacion.SetError(x, item.message.ToString());
                                }
                            }
                        }
                    }
                    mensaje("subsanar", "");
                }
                else
                {
                    mensaje("corregir", ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\r\n" + ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return rpta;
        }

        public override bool Actualizar()
        {
            double d;
            int i;
            bool rpta = false;
            try
            {
                eSOCIO o = new eSOCIO();
                o.SOC_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
                o.SOC_tipo_socio = this.cmbTipoSocio.Text.Trim();
                o.SOC_apellido_paterno = this.txtApellidoPaterno.Text.Trim();
                o.SOC_apellido_materno = this.txtApellidoMaterno.Text.Trim();
                o.SOC_nombres = this.txtNombres.Text.Trim();
                o.SOC_nombre_razon_social = this.txtRazonSocial.Text.Trim();
                o.SOC_numero_documento = this.txtNumeroDocumento.Text.Trim();
                o.SOC_direccion = this.txtDireccion.Text.Trim();
                o.SOC_referencia_direccion = this.txtReferencia.Text.Trim();
                o.SOC_telefono_fijo = this.txtTelefonoFijo.Text.Trim();
                o.SOC_telefono_movil = this.txtTelefonoMovil.Text.Trim();
                o.SOC_email = this.txtEmail.Text.Trim();
                o.SOC_web = this.txtWeb.Text.Trim();
                o.SOC_is_agente_retencion = this.chkRetencion.Checked ? "S" : "N";
                o.SOC_is_agente_percepcion = this.chkPercepcion.Checked ? "S" : "N";
                o.SOC_porcentaje_percepcion = Double.TryParse(this.cmbPorcentajePercepcion.Text.Trim(), out d) ? Convert.ToDouble(this.cmbPorcentajePercepcion.Text.Trim()) : (double?)null;
                o.SOC_is_validar_bonificacion = this.chkValidarBonificacion.Checked ? "S" : "N";
                o.SOC_is_bonificacion_personalizada = this.chkBoniPersonal.Checked ? "S" : "N";
                o.SOC_is_descuento_personalizado = this.chkDescuentoPersonal.Checked ? "S" : "N";
                o.SOC_is_key_account = this.chkKeyAcc.Checked ? "S" : "N";
                o.SOC_dias_credito = Int32.TryParse(this.cmbDiasCredito.Text.Trim(), out i) ? Convert.ToInt16(this.cmbDiasCredito.Text.Trim()) : -1;
                o.SOC_fecha_registro = Convert.ToDateTime(this.dtpFechaRegistro.Value.ToShortDateString());
                o.SOC_linea_credito = Double.TryParse(this.nudLineaCredito.Text.Trim(), out d) ? Convert.ToDouble(this.nudLineaCredito.Text.Trim()) : -1;
                o.SOC_tipo_persona = this.cmbTipoPersona.Text.Trim();
                o.SOC_is_activo = this.chkActivo.Checked ? "S" : "N";
                o.SOC_comentario = this.txtComentario.Text.Trim();
                o.SOC_tipo_documento_identidad = this.cmbTipoDocumentoId.Text.Trim();
                o.SOC_latitud = String.IsNullOrWhiteSpace(this.txtLatitud.Text.Trim()) ? (double?)null : Convert.ToDouble(this.txtLatitud.Text.Trim());
                o.SOC_longitud = String.IsNullOrWhiteSpace(this.txtLongitud.Text.Trim()) ? (double?)null : Convert.ToDouble(this.txtLongitud.Text.Trim());
                o.LPR_codigo = String.IsNullOrWhiteSpace(this.cmbListaPrecio.Text) ? null : this.cmbListaPrecio.SelectedValue.ToString();
                o.TNE_codigo = String.IsNullOrWhiteSpace(this.cmbTipoNegocio.Text) ? null : this.cmbTipoNegocio.SelectedValue.ToString();
                o.CAN_codigo = String.IsNullOrWhiteSpace(this.cmbCanal.Text) ? null : this.cmbCanal.SelectedValue.ToString();
                o.UBI_id = String.IsNullOrWhiteSpace(this.cmbUbigeo.Text) ? null : this.cmbUbigeo.SelectedValue.ToString();
                o.ZON_codigo = String.IsNullOrWhiteSpace(this.cmbZona.Text) ? -1 : Convert.ToInt32(this.cmbZona.SelectedValue.ToString().Trim());
                o.VEN_codigo = String.IsNullOrWhiteSpace(this.cmbVendedor.Text) ? (int?)null : Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString().Trim());
                o.TDO_codigo = String.IsNullOrWhiteSpace(this.cmbTipoDocumentoVenta.Text) ? null : this.cmbTipoDocumentoVenta.SelectedValue.ToString();
                o.CPA_codigo = String.IsNullOrWhiteSpace(this.cmbCondicionPago.Text) ? null : this.cmbCondicionPago.SelectedValue.ToString();

                if (balSOCIO.actualizarRegistro(o))
                {
                    mensaje("actualizar","");
                    //MessageBox.Show("El registro fue actualizado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCodigo.ReadOnly = true;
                    rpta = true;
                }
            }
            catch (CustomException ex)
            {
                if (ex.tupla != null)
                {
                    foreach (Control c in this.gpbInformacion.Controls)
                    {
                        foreach (var item in ex.tupla)
                        {
                            if (c.Tag != null && c.Tag.ToString() == item.name)
                            {
                                errValidacion.SetError(c, item.message.ToString());
                            }
                        }

                        foreach (Control x in c.Controls)
                        {
                            foreach (var item in ex.tupla)
                            {
                                if (x.Tag != null && x.Tag.ToString() == item.name)
                                {
                                    errValidacion.SetError(x, item.message.ToString());
                                }
                            }
                        }
                    }
                    mensaje("subsanar", "");
                }
                else
                {
                    mensaje("corregir", ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\r\n" + ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return rpta;
        }

        public override bool Eliminar()
        {
            int i;
            bool rpta = false;
            try
            {
                eSOCIO o = new eSOCIO();
                o.SOC_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;

                if (balSOCIO.eliminarRegistro(o))
                {
                    mensaje("eliminar","");
                    //MessageBox.Show("El registro fue eliminado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCodigo.ReadOnly = true;
                    rpta = true;
                }
            }
            catch (CustomException ex)
            {
                if (ex.tupla != null)
                {
                    foreach (Control c in this.gpbInformacion.Controls)
                    {
                        foreach (var item in ex.tupla)
                        {
                            if (c.Tag != null && c.Tag.ToString() == item.name)
                            {
                                errValidacion.SetError(c, item.message.ToString());
                            }
                        }

                        foreach (Control x in c.Controls)
                        {
                            foreach (var item in ex.tupla)
                            {
                                if (x.Tag != null && x.Tag.ToString() == item.name)
                                {
                                    errValidacion.SetError(x, item.message.ToString());
                                }
                            }
                        }
                    }
                    mensaje("subsanar", "");
                }
                else
                {
                    mensaje("corregir", ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\r\n" + ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return rpta;
        }

        public override void Primero()
        {
            cargarDatos(balSOCIO.primerRegistro());
        }

        public override void Anterior()
        {
            int u;
            eSOCIO o = new eSOCIO();
            o.SOC_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balSOCIO.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            int u;
            eSOCIO o = new eSOCIO();
            o.SOC_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balSOCIO.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balSOCIO.ultimoRegistro());
        }

        public override void Buscar()
        {
            int u;
            eSOCIO o = new eSOCIO();
            balSOCIO b = new balSOCIO();
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.SOC_codigo = Int32.TryParse(ventana.pk, out u) ? Convert.ToInt32(ventana.pk) : -1;
                DataTable dt = balSOCIO.obtenerRegistro(o);
                cargarDatos(dt);
            }
        }

        public override void Cancelar()
        {
            this.txtCodigo.ReadOnly = true;
        }

        public override void ExportarExcel()
        {
            _frmExportar o = new _frmExportar(balSOCIO.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            int u;
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["SOC_codigo"].ToString();
                this.cmbTipoSocio.Text = dt.Rows[0]["SOC_tipo_socio"].ToString();
                this.txtApellidoPaterno.Text = dt.Rows[0]["SOC_apellido_paterno"].ToString();
                this.txtApellidoMaterno.Text = dt.Rows[0]["SOC_apellido_materno"].ToString();
                this.txtNombres.Text = dt.Rows[0]["SOC_nombres"].ToString();
                this.txtRazonSocial.Text = dt.Rows[0]["SOC_nombre_razon_social"].ToString();
                this.txtNumeroDocumento.Text = dt.Rows[0]["SOC_numero_documento"].ToString();
                this.txtDireccion.Text = dt.Rows[0]["SOC_direccion"].ToString();
                this.txtReferencia.Text = dt.Rows[0]["SOC_referencia_direccion"].ToString();
                this.txtTelefonoFijo.Text = dt.Rows[0]["SOC_telefono_fijo"].ToString();
                this.txtTelefonoMovil.Text = dt.Rows[0]["SOC_telefono_movil"].ToString();
                this.txtEmail.Text = dt.Rows[0]["SOC_email"].ToString();
                this.txtWeb.Text = dt.Rows[0]["SOC_web"].ToString();
                this.chkRetencion.Checked = (dt.Rows[0]["SOC_is_agente_retencion"].ToString() == "S") ? true : false;
                this.chkPercepcion.Checked = (dt.Rows[0]["SOC_is_agente_percepcion"].ToString() == "S") ? true : false;
                this.cmbPorcentajePercepcion.Text = dt.Rows[0]["SOC_porcentaje_percepcion"].ToString();
                this.chkValidarBonificacion.Checked = (dt.Rows[0]["SOC_is_validar_bonificacion"].ToString() == "S") ? true : false;
                this.chkBoniPersonal.Checked = (dt.Rows[0]["SOC_is_bonificacion_personalizada"].ToString() == "S") ? true : false;
                this.chkDescuentoPersonal.Checked = (dt.Rows[0]["SOC_is_descuento_personalizado"].ToString() == "S") ? true : false;
                this.chkKeyAcc.Checked = (dt.Rows[0]["SOC_is_key_account"].ToString() == "S") ? true : false;
                this.cmbDiasCredito.Text = dt.Rows[0]["SOC_dias_credito"].ToString();
                this.dtpFechaRegistro.Text = dt.Rows[0]["SOC_fecha_registro"].ToString();
                this.nudLineaCredito.Text = dt.Rows[0]["SOC_linea_credito"].ToString();
                this.cmbTipoPersona.Text = dt.Rows[0]["SOC_tipo_persona"].ToString();
                this.chkActivo.Checked = (dt.Rows[0]["SOC_is_activo"].ToString() == "S") ? true : false;
                this.txtLatitud.Text = dt.Rows[0]["SOC_latitud"].ToString();
                this.txtLongitud.Text = dt.Rows[0]["SOC_longitud"].ToString();
                this.cmbListaPrecio.SelectedValue = dt.Rows[0]["LPR_codigo"].ToString();
                this.cmbTipoNegocio.SelectedValue = dt.Rows[0]["TNE_codigo"].ToString();
                this.cmbCanal.SelectedValue = dt.Rows[0]["CAN_codigo"].ToString();
                this.cmbUbigeo.SelectedValue = dt.Rows[0]["UBI_id"].ToString();
                this.cmbZona.SelectedValue = dt.Rows[0]["ZON_codigo"].ToString();
                this.txtComentario.Text = dt.Rows[0]["SOC_comentario"].ToString();
                this.cmbTipoDocumentoId.Text = dt.Rows[0]["SOC_tipo_documento_identidad"].ToString();
                //this.cmbVendedor.SelectedValue = dt.Rows[0]["VEN_codigo"].ToString();
                this.cmbVendedor.SelectedValue = Int32.TryParse(dt.Rows[0]["VEN_codigo"].ToString(), out u) ? Convert.ToInt32(dt.Rows[0]["VEN_codigo"].ToString()) : -1;
                this.cmbTipoDocumentoVenta.SelectedValue = dt.Rows[0]["TDO_codigo"].ToString();
                this.cmbCondicionPago.SelectedValue = dt.Rows[0]["CPA_codigo"].ToString();
            }
            else
            {
                _cfgUtil.clearFields(this.gpbInformacion);

                this.chkPercepcion.Checked = false;
                this.cmbPorcentajePercepcion.Enabled = false;
                this.cmbPorcentajePercepcion.SelectedIndex = -1;

                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnActualizar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnPrimero.Enabled = true;
                this.btnAnterior.Enabled = true;
                this.btnSiguiente.Enabled = true;
                this.btnUltimo.Enabled = true;
                this.btnBuscar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        private void chkPercepcion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPercepcion.Checked)
            {
                this.cmbPorcentajePercepcion.Enabled = true;
                this.cmbPorcentajePercepcion.Text = "2.00";
            }
            else
            {
                this.cmbPorcentajePercepcion.Enabled = false;
                this.cmbPorcentajePercepcion.SelectedIndex = -1;
            }
        }

        private void lnkGoogleMaps_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/?q=" + this.txtLatitud.Text + "," + this.txtLongitud.Text);
        }

        private void txtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {
            this.txtRazonSocial.Text = this.txtApellidoPaterno.Text + " " + this.txtApellidoMaterno.Text + ", " + this.txtNombres.Text;
        }

        private void txtApellidoMaterno_TextChanged(object sender, EventArgs e)
        {
            this.txtRazonSocial.Text = this.txtApellidoPaterno.Text + " " + this.txtApellidoMaterno.Text + ", " + this.txtNombres.Text;
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            this.txtRazonSocial.Text = this.txtApellidoPaterno.Text + " " + this.txtApellidoMaterno.Text + ", " + this.txtNombres.Text;
        }

        private void cmbTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoPersona.Text == "Natural")
            {
                this.txtRazonSocial.ReadOnly = true;
                this.txtApellidoPaterno.ReadOnly = false;
                this.txtApellidoMaterno.ReadOnly = false;
                this.txtNombres.ReadOnly = false;
            }
            else
            {
                this.txtRazonSocial.ReadOnly = false;
                this.txtApellidoPaterno.ReadOnly = true;
                this.txtApellidoMaterno.ReadOnly = true;
                this.txtNombres.ReadOnly = true;
            }
        }

        #region GOTO
        private void btnGoCanal_Click(object sender, EventArgs e)
        {
            eCANAL o = new eCANAL();
            o.CAN_codigo = this.cmbCanal.SelectedValue != null ? this.cmbCanal.SelectedValue.ToString() : "";

            frmDM_Canal o2 = new frmDM_Canal(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoDocumentoVenta_Click(object sender, EventArgs e)
        {
            eTIPO_DOCUMENTO o = new eTIPO_DOCUMENTO();
            o.TDO_codigo = this.cmbTipoDocumentoVenta.SelectedValue != null ? this.cmbTipoDocumentoVenta.SelectedValue.ToString() : "";

            frmDM_TipoDocumento o2 = new frmDM_TipoDocumento(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoTipoNegocio_Click(object sender, EventArgs e)
        {
            eTIPO_NEGOCIO o = new eTIPO_NEGOCIO();
            o.TNE_codigo = this.cmbTipoNegocio.SelectedValue != null ? this.cmbTipoNegocio.SelectedValue.ToString() : "";

            frmDM_TipoNegocio o2 = new frmDM_TipoNegocio(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoZona_Click(object sender, EventArgs e)
        {
            eZONA o = new eZONA();
            o.ZON_codigo = this.cmbZona.SelectedValue != null ? Convert.ToInt32(this.cmbZona.SelectedValue.ToString()) : -1;

            frmDM_Zona o2 = new frmDM_Zona(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoListaPrecios_Click(object sender, EventArgs e)
        {
            eLISTA_PRECIO o = new eLISTA_PRECIO();
            o.LPR_codigo = this.cmbListaPrecio.SelectedValue != null ? this.cmbListaPrecio.SelectedValue.ToString() : "";

            frmDM_ListaPrecio o2 = new frmDM_ListaPrecio(o);
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

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            eVENDEDOR o = new eVENDEDOR();
            o.VEN_codigo = this.cmbVendedor.SelectedValue != null ? Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString()) : -1;

            frmDM_Vendedor o2 = new frmDM_Vendedor(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }
        #endregion

        private void cmbTipoSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoSocio.Text == "PROVEEDOR")
            {
                this.gpbInformacionComercial.Visible = false;

                this.cmbTipoDocumentoId.SelectedIndex = -1;
                this.cmbCanal.SelectedIndex = 0;
                this.cmbTipoNegocio.SelectedIndex = 0;
                this.cmbListaPrecio.SelectedIndex = 0;
                this.cmbCondicionPago.SelectedIndex = -1;
                this.nudLineaCredito.Value = 0;
                this.cmbDiasCredito.SelectedIndex = 0;
                this.cmbVendedor.SelectedIndex = -1;
                this.cmbZona.SelectedIndex = 0;
                this.chkKeyAcc.Checked = false;
                this.chkValidarBonificacion.Checked = false;
                this.chkDescuentoPersonal.Checked = false;
                this.chkBoniPersonal.Checked = false;
                this.chkRetencion.Checked = false;
                this.chkPercepcion.Checked = false;
                this.cmbPorcentajePercepcion.SelectedIndex = 0;

                this.cmbTipoDocumentoId.Text = "RUC";                
            }
            else
            {
                this.gpbInformacionComercial.Visible = true;
                this.cmbTipoDocumentoId.SelectedIndex = -1;

                this.cmbCanal.SelectedIndex = -1;
                this.cmbTipoNegocio.SelectedIndex = -1;
                this.cmbListaPrecio.SelectedIndex = -1;
                this.cmbDiasCredito.SelectedIndex = -1;
                this.cmbZona.SelectedIndex = -1;
                this.cmbPorcentajePercepcion.SelectedIndex = -1;
            }
        }

        //Refreso de combobox
        private void cmbTipoDocumentoVenta_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbTipoDocumentoVenta.SelectedValue != null)
            {
                valorSeleccionado = this.cmbTipoDocumentoVenta.SelectedValue.ToString();
            }
            this.cmbTipoDocumentoVenta.DataSource = balTIPO_DOCUMENTO.poblar();
            this.cmbTipoDocumentoVenta.SelectedValue = valorSeleccionado;            
        }

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

        private void cmbTipoNegocio_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbTipoNegocio.SelectedValue != null)
            {
                valorSeleccionado = this.cmbTipoNegocio.SelectedValue.ToString();
            }
            this.cmbTipoNegocio.DataSource = balTIPO_NEGOCIO.poblar();
            this.cmbTipoNegocio.SelectedValue = valorSeleccionado;            
        }

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




        private void cmbVendedor_DropDown(object sender, EventArgs e)
        {
            int valorSeleccionado = -1;
            if (this.cmbVendedor.SelectedValue != null)
            {
                valorSeleccionado = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
            }
            this.cmbVendedor.DataSource = balVENDEDOR.poblar();
            this.cmbVendedor.SelectedValue = valorSeleccionado;            
        }

        private void cmbZona_DropDown(object sender, EventArgs e)
        {
            int valorSeleccionado = -1;
            if (this.cmbZona.SelectedValue != null)
            {
                valorSeleccionado = Convert.ToInt32(this.cmbZona.SelectedValue.ToString());
            }
            this.cmbZona.DataSource = balZONA.poblar();
            this.cmbZona.SelectedValue = valorSeleccionado;            
        }
    }
}
