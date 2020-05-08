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
    public partial class frmDM_ListaPrecio : _frmBaseDM
    {
        eLISTA_PRECIO _o;
        public frmDM_ListaPrecio(eLISTA_PRECIO o)
        {
            InitializeComponent();
            tabla = "LISTA_PRECIO";
            this._o = o;
        }

        private void frmDM_ListaPrecio_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balLISTA_PRECIO.obtenerRegistro(_o)); }
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
                eLISTA_PRECIO o = new eLISTA_PRECIO();
                o.LPR_codigo = this.txtCodigo.Text.Trim();
                o.LPR_nombre = this.txtNombre.Text.Trim();
                o.LPR_is_activo = this.chkIsActivo.Checked ? "S" : "N";
                o.LPR_anotaciones = this.txtAnotaciones.Text.Trim();
                
                if (balLISTA_PRECIO.insertarRegistro(o))
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
                eLISTA_PRECIO o = new eLISTA_PRECIO();
                o.LPR_codigo = this.txtCodigo.Text.Trim();
                o.LPR_nombre = this.txtNombre.Text.Trim();
                o.LPR_is_activo = this.chkIsActivo.Checked ? "S" : "N";
                o.LPR_anotaciones = this.txtAnotaciones.Text.Trim();

                if (balLISTA_PRECIO.actualizarRegistro(o))
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
                eLISTA_PRECIO o = new eLISTA_PRECIO();
                o.LPR_codigo = this.txtCodigo.Text.Trim();

                if (balLISTA_PRECIO.eliminarRegistro(o))
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
            cargarDatos(balLISTA_PRECIO.primerRegistro());
        }

        public override void Anterior()
        {
            eLISTA_PRECIO o = new eLISTA_PRECIO();
            o.LPR_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balLISTA_PRECIO.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            eLISTA_PRECIO o = new eLISTA_PRECIO();
            o.LPR_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balLISTA_PRECIO.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balLISTA_PRECIO.ultimoRegistro());
        }

        public override void Buscar()
        {
            eLISTA_PRECIO o = new eLISTA_PRECIO();
            balLISTA_PRECIO b = new balLISTA_PRECIO();

            _frmBusqueda ventana = new _frmBusqueda(true, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.LPR_codigo = ventana.pk;
                DataTable dt = balLISTA_PRECIO.obtenerRegistro(o);
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
            _frmExportar o = new _frmExportar(balLISTA_PRECIO.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["LPR_codigo"].ToString();
                this.txtNombre.Text = dt.Rows[0]["LPR_nombre"].ToString();
                this.chkIsActivo.Checked = dt.Rows[0]["LPR_is_activo"].ToString() == "S" ? true : false;
                this.txtAnotaciones.Text = dt.Rows[0]["LPR_anotaciones"].ToString();
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
