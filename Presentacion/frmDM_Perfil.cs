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
    public partial class frmDM_Perfil : _frmBaseDM
    {
        ePERFIL _o;

        public frmDM_Perfil(ePERFIL o)
        {
            InitializeComponent();
            tabla = "PERFIL";
            this._o = o;
        }

        private void frmDM_Perfil_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balPERFIL.obtenerRegistro(_o)); }
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
                ePERFIL _oePERFIL = new ePERFIL();
                _oePERFIL.PER_codigo = this.txtCodigo.Text.Trim();
                _oePERFIL.PER_nombre = this.txtNombre.Text.Trim();
                _oePERFIL.PER_descripcion = this.txtDescripcion.Text.Trim();
                _oePERFIL.PER_is_admin = this.chkIsAdmin.Checked ? "S" : "N";
                
                if (balPERFIL.insertarRegistro(_oePERFIL))
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
                ePERFIL _oePERFIL = new ePERFIL();
                _oePERFIL.PER_codigo = this.txtCodigo.Text.Trim();
                _oePERFIL.PER_nombre = this.txtNombre.Text.Trim();
                _oePERFIL.PER_descripcion = this.txtDescripcion.Text.Trim();
                _oePERFIL.PER_is_admin = this.chkIsAdmin.Checked ? "S" : "N";

                if (balPERFIL.actualizarRegistro(_oePERFIL))
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
                ePERFIL _oePERFIL = new ePERFIL();
                _oePERFIL.PER_codigo = this.txtCodigo.Text.Trim();

                if (balPERFIL.eliminarRegistro(_oePERFIL))
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
            cargarDatos(balPERFIL.primerRegistro());
        }

        public override void Anterior()
        {
            ePERFIL _oePERFIL = new ePERFIL();
            _oePERFIL.PER_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balPERFIL.anteriorRegistro(_oePERFIL));
        }

        public override void Siguiente()
        {
            ePERFIL _oePERFIL = new ePERFIL();
            _oePERFIL.PER_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balPERFIL.siguienteRegistro(_oePERFIL));
        }

        public override void Ultimo()
        {
            cargarDatos(balPERFIL.ultimoRegistro());
        }

        public override void Buscar()
        {
            ePERFIL oePERFIL = new ePERFIL();
            balPERFIL obalPERFIL = new balPERFIL();
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", obalPERFIL);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                oePERFIL.PER_codigo = ventana.pk;
                DataTable dt = balPERFIL.obtenerRegistro(oePERFIL);
                cargarDatos(dt);
            }
        }

        public override void Cancelar()
        {
            this.txtCodigo.ReadOnly = true;
        }

        public override void ExportarExcel()
        {
            _frmExportar o = new _frmExportar(balPERFIL.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["PER_codigo"].ToString();
                this.txtNombre.Text = dt.Rows[0]["PER_nombre"].ToString();
                this.txtDescripcion.Text = dt.Rows[0]["PER_descripcion"].ToString();
                this.chkIsAdmin.Checked = dt.Rows[0]["PER_is_admin"].ToString() == "S" ? true : false;
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
