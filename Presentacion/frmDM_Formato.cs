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
    public partial class frmDM_Formato : _frmBaseDM
    {
        eFORMATO _o;
        public frmDM_Formato(eFORMATO o)
        {
            InitializeComponent();
            tabla = "FORMATO";
            this._o = o;
        }

        private void frmDM_Formato_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balFORMATO.obtenerRegistro(_o)); }
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
                eFORMATO o = new eFORMATO();
                o.FOR_codigo = this.txtCodigo.Text.Trim();
                o.FOR_nombre = this.txtNombre.Text.Trim();

                if (balFORMATO.insertarRegistro(o))
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
                eFORMATO o = new eFORMATO();
                o.FOR_codigo = this.txtCodigo.Text.Trim();
                o.FOR_nombre = this.txtNombre.Text.Trim();

                if (balFORMATO.actualizarRegistro(o))
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
                eFORMATO o = new eFORMATO();
                o.FOR_codigo = this.txtCodigo.Text.Trim();

                if (balFORMATO.eliminarRegistro(o))
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
            cargarDatos(balFORMATO.primerRegistro());
        }

        public override void Anterior()
        {
            eFORMATO o = new eFORMATO();
            o.FOR_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balFORMATO.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            eFORMATO o = new eFORMATO();
            o.FOR_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balFORMATO.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balFORMATO.ultimoRegistro());
        }

        public override void Buscar()
        {
            eFORMATO o = new eFORMATO();
            balFORMATO b = new balFORMATO();

            _frmBusqueda ventana = new _frmBusqueda(true, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.FOR_codigo = ventana.pk;
                DataTable dt = balFORMATO.obtenerRegistro(o);
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
            _frmExportar o = new _frmExportar(balFORMATO.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["FOR_codigo"].ToString();
                this.txtNombre.Text = dt.Rows[0]["FOR_nombre"].ToString();
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
