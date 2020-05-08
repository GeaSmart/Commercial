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
    public partial class frmDM_Impuesto : _frmBaseDM
    {
        eIMPUESTO _o;
        public frmDM_Impuesto(eIMPUESTO o)
        {
            InitializeComponent();
            tabla = "IMPUESTO";
            this._o = o;
        }

        private void frmDM_Impuesto_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balIMPUESTO.obtenerRegistro(_o)); }
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
                eIMPUESTO o = new eIMPUESTO();
                o.IMP_codigo = this.txtCodigo.Text.Trim();
                o.IMP_nombre = this.txtNombre.Text.Trim();
                o.IMP_nombre_corto = this.txtNombreCorto.Text.Trim();

                if (balIMPUESTO.insertarRegistro(o))
                {
                    mensaje("guardar","");
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
                eIMPUESTO o = new eIMPUESTO();
                o.IMP_codigo = this.txtCodigo.Text.Trim();
                o.IMP_nombre = this.txtNombre.Text.Trim();
                o.IMP_nombre_corto = this.txtNombreCorto.Text.Trim();

                if (balIMPUESTO.actualizarRegistro(o))
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
                eIMPUESTO o = new eIMPUESTO();
                o.IMP_codigo = this.txtCodigo.Text.Trim();

                if (balIMPUESTO.eliminarRegistro(o))
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
            cargarDatos(balIMPUESTO.primerRegistro());
        }

        public override void Anterior()
        {
            eIMPUESTO o = new eIMPUESTO();
            o.IMP_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balIMPUESTO.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            eIMPUESTO o = new eIMPUESTO();
            o.IMP_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balIMPUESTO.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balIMPUESTO.ultimoRegistro());
        }

        public override void Buscar()
        {
            eIMPUESTO o = new eIMPUESTO();
            balIMPUESTO b = new balIMPUESTO();

            _frmBusqueda ventana = new _frmBusqueda(true, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.IMP_codigo = ventana.pk;
                DataTable dt = balIMPUESTO.obtenerRegistro(o);
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
            _frmExportar o = new _frmExportar(balIMPUESTO.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["IMP_codigo"].ToString();
                this.txtNombre.Text = dt.Rows[0]["IMP_nombre"].ToString();
                this.txtNombreCorto.Text = dt.Rows[0]["IMP_nombre_corto"].ToString();
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

        private void lklDetalle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            eDETALLE_IMPUESTO o = new eDETALLE_IMPUESTO();
            o.IMP_codigo = this.txtCodigo.Text;
            frmOP_AsignacionImpuesto o2 = new frmOP_AsignacionImpuesto(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }
    }
}
