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
    public partial class frmDM_CondicionPago : _frmBaseDM
    {
        eCONDICION_PAGO _o;
        public frmDM_CondicionPago(eCONDICION_PAGO o)
        {
            InitializeComponent();
            tabla = "CONDICION_PAGO";

            this._o = o;
        }

        private void frmDM_CondicionPago_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balCONDICION_PAGO.obtenerRegistro(_o)); }
        }

        public override void Nuevo()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.txtCodigo.ReadOnly = false;
        }

        public override bool Guardar()
        {
            bool rpta = false;
            try
            {
                eCONDICION_PAGO o = new eCONDICION_PAGO();
                o.CPA_codigo = this.txtCodigo.Text.Trim();
                o.CPA_descripcion = this.txtDescripcion.Text.Trim();
                o.CPA_dias_limite_pago = Convert.ToInt32(this.nudDiasLimite.Value);
                
                if (balCONDICION_PAGO.insertarRegistro(o))
                {
                    mensaje("guardar","");
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
            bool rpta = false;
            try
            {
                eCONDICION_PAGO o = new eCONDICION_PAGO();
                o.CPA_codigo = this.txtCodigo.Text.Trim();
                o.CPA_descripcion = this.txtDescripcion.Text.Trim();
                o.CPA_dias_limite_pago = Convert.ToInt32(this.nudDiasLimite.Value);

                if (balCONDICION_PAGO.actualizarRegistro(o))
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
            bool rpta = false;
            try
            {
                eCONDICION_PAGO o = new eCONDICION_PAGO();
                o.CPA_codigo = this.txtCodigo.Text.Trim();

                if (balCONDICION_PAGO.eliminarRegistro(o))
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
            cargarDatos(balCONDICION_PAGO.primerRegistro());
        }

        public override void Anterior()
        {
            eCONDICION_PAGO o = new eCONDICION_PAGO();
            o.CPA_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balCONDICION_PAGO.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            eCONDICION_PAGO o = new eCONDICION_PAGO();
            o.CPA_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balCONDICION_PAGO.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balCONDICION_PAGO.ultimoRegistro());
        }

        public override void Buscar()
        {
            eCONDICION_PAGO o = new eCONDICION_PAGO();
            balCONDICION_PAGO b = new balCONDICION_PAGO();

            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.CPA_codigo = ventana.pk;
                DataTable dt = balCONDICION_PAGO.obtenerRegistro(o);
                cargarDatos(dt);

                this.txtCodigo.ReadOnly = true;
            }
        }

        public override void Cancelar()
        {
            this.txtCodigo.ReadOnly = true;
        }

        public override void ExportarExcel()
        {
            _frmExportar o = new _frmExportar(balCONDICION_PAGO.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["CPA_codigo"].ToString();
                this.txtDescripcion.Text = dt.Rows[0]["CPA_descripcion"].ToString();
                this.nudDiasLimite.Value = Convert.ToInt32(dt.Rows[0]["CPA_dias_limite_pago"].ToString());
            }
            else
            {
                _cfgUtil.clearFields(this.gpbInformacion);
                this.txtCodigo.ReadOnly = false;

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
    }
}
