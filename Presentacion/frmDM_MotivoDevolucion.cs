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
    public partial class frmDM_MotivoDevolucion : _frmBaseDM
    {
        eMOTIVO_DEVOLUCION _o;
        public frmDM_MotivoDevolucion(eMOTIVO_DEVOLUCION o)
        {
            InitializeComponent();
            tabla = "MOTIVO_DEVOLUCION";
            this._o = o;
        }

        private void frmDM_MotivoDevolucion_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balMOTIVO_DEVOLUCION.obtenerRegistro(_o)); }
        }

        public override void Nuevo()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.txtCodigo.ReadOnly = true;
        }

        public override bool Guardar()
        {
            bool rpta = false;
            try
            {
                eMOTIVO_DEVOLUCION o = new eMOTIVO_DEVOLUCION();                
                o.MDE_descripcion = this.txtDescripcion.Text.Trim();
                o.MDE_is_activo = this.chkIsActivo.Checked ? "S" : "N";

                if (balMOTIVO_DEVOLUCION.insertarRegistro(o))
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
            int i;
            bool rpta = false;
            try
            {
                eMOTIVO_DEVOLUCION o = new eMOTIVO_DEVOLUCION();
                o.MDE_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
                o.MDE_descripcion = this.txtDescripcion.Text.Trim();
                o.MDE_is_activo = this.chkIsActivo.Checked ? "S" : "N";

                if (balMOTIVO_DEVOLUCION.actualizarRegistro(o))
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
            int i;
            bool rpta = false;
            try
            {
                eMOTIVO_DEVOLUCION o = new eMOTIVO_DEVOLUCION();
                o.MDE_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;

                if (balMOTIVO_DEVOLUCION.eliminarRegistro(o))
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
            cargarDatos(balMOTIVO_DEVOLUCION.primerRegistro());
        }

        public override void Anterior()
        {
            int i;
            eMOTIVO_DEVOLUCION o = new eMOTIVO_DEVOLUCION();
            o.MDE_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balMOTIVO_DEVOLUCION.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            int i;
            eMOTIVO_DEVOLUCION o = new eMOTIVO_DEVOLUCION();
            o.MDE_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balMOTIVO_DEVOLUCION.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balMOTIVO_DEVOLUCION.ultimoRegistro());
        }

        public override void Buscar()
        {
            int i;
            eMOTIVO_DEVOLUCION o = new eMOTIVO_DEVOLUCION();
            balMOTIVO_DEVOLUCION b = new balMOTIVO_DEVOLUCION();

            _frmBusqueda ventana = new _frmBusqueda(true, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.MDE_codigo = Int32.TryParse(ventana.pk, out i) ? Convert.ToInt32(ventana.pk) : -1;
                DataTable dt = balMOTIVO_DEVOLUCION.obtenerRegistro(o);
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
            _frmExportar o = new _frmExportar(balMOTIVO_DEVOLUCION.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["MDE_codigo"].ToString();
                this.txtDescripcion.Text = dt.Rows[0]["MDE_descripcion"].ToString();
                this.chkIsActivo.Checked = dt.Rows[0]["MDE_is_activo"].ToString() == "S" ? true : false;
            }
            else
            {
                _cfgUtil.clearFields(this.gpbInformacion);
                this.txtCodigo.ReadOnly = true;

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
