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
    public partial class frmDM_UnidadMedida : _frmBaseDM
    {
        eUNIDAD_MEDIDA _o;
        public frmDM_UnidadMedida(eUNIDAD_MEDIDA o)
        {
            InitializeComponent();
            tabla = "UNIDAD_MEDIDA";
            this._o = o;
        }

        private void frmDM_UnidadMedida_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balUNIDAD_MEDIDA.obtenerRegistro(_o)); }
        }

        public override void Nuevo()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.txtCodigo.ReadOnly = false;
        }

        public override bool Guardar()
        {
            int u;
            bool rpta = false;
            try
            {
                eUNIDAD_MEDIDA o = new eUNIDAD_MEDIDA();
                o.UME_codigo = this.txtCodigo.Text.Trim();
                o.UME_descripcion = this.txtDescripcion.Text.Trim();
                o.UME_descripcion_sunat = this.txtDescripcionSunat.Text.Trim();
                o.UME_multiplo = Int32.TryParse(this.nudMultiplo.Value.ToString(), out u) ? Convert.ToInt32(this.nudMultiplo.Value) : -1;
                
                if (balUNIDAD_MEDIDA.insertarRegistro(o))
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
            int u;
            bool rpta = false;
            try
            {
                eUNIDAD_MEDIDA o = new eUNIDAD_MEDIDA();
                o.UME_codigo = this.txtCodigo.Text.Trim();
                o.UME_descripcion = this.txtDescripcion.Text.Trim();
                o.UME_descripcion_sunat = this.txtDescripcionSunat.Text.Trim();
                o.UME_multiplo = Int32.TryParse(this.nudMultiplo.Value.ToString(), out u) ? Convert.ToInt32(this.nudMultiplo.Value) : -1;

                if (balUNIDAD_MEDIDA.actualizarRegistro(o))
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
            int u;
            bool rpta = false;
            try
            {
                eUNIDAD_MEDIDA o = new eUNIDAD_MEDIDA();
                o.UME_codigo = this.txtCodigo.Text.Trim();

                if (balUNIDAD_MEDIDA.eliminarRegistro(o))
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
            cargarDatos(balUNIDAD_MEDIDA.primerRegistro());
        }

        public override void Anterior()
        {
            eUNIDAD_MEDIDA o = new eUNIDAD_MEDIDA();
            o.UME_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balUNIDAD_MEDIDA.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            eUNIDAD_MEDIDA o = new eUNIDAD_MEDIDA();
            o.UME_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balUNIDAD_MEDIDA.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balUNIDAD_MEDIDA.ultimoRegistro());
        }

        public override void Buscar()
        {
            eUNIDAD_MEDIDA o = new eUNIDAD_MEDIDA();
            balUNIDAD_MEDIDA b = new balUNIDAD_MEDIDA();
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.UME_codigo = ventana.pk;
                DataTable dt = balUNIDAD_MEDIDA.obtenerRegistro(o);
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
            _frmExportar o = new _frmExportar(balUNIDAD_MEDIDA.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["UME_codigo"].ToString();
                this.txtDescripcion.Text = dt.Rows[0]["UME_descripcion"].ToString();
                this.txtDescripcionSunat.Text = dt.Rows[0]["UME_descripcion_sunat"].ToString();
                this.nudMultiplo.Value = Convert.ToInt32(dt.Rows[0]["UME_multiplo"].ToString());
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
