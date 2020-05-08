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
    public partial class frmDM_Linea : _frmBaseDM
    {
        eLINEA _o;
        public frmDM_Linea(eLINEA o)
        {
            InitializeComponent();
            tabla = "LINEA";

            this.cmbCategoria.ValueMember = "CAT_codigo";
            this.cmbCategoria.DisplayMember = "CAT_nombre";
            this.cmbCategoria.DataSource = balCATEGORIA.poblar();

            this._o = o;            
        }

        private void frmDM_Linea_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balLINEA.obtenerRegistro(_o)); }
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
                eLINEA o = new eLINEA();
                o.LIN_codigo = this.txtCodigo.Text.Trim();
                o.LIN_nombre = this.txtNombre.Text.Trim();
                o.CAT_codigo = this.cmbCategoria.SelectedValue != null ? this.cmbCategoria.SelectedValue.ToString() : "";

                if (balLINEA.insertarRegistro(o))
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
                eLINEA o = new eLINEA();
                o.LIN_codigo = this.txtCodigo.Text.Trim();
                o.LIN_nombre = this.txtNombre.Text.Trim();
                o.CAT_codigo = this.cmbCategoria.SelectedValue != null ? this.cmbCategoria.SelectedValue.ToString() : "";

                if (balLINEA.actualizarRegistro(o))
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
                eLINEA o = new eLINEA();
                o.LIN_codigo = this.txtCodigo.Text.Trim();

                if (balLINEA.eliminarRegistro(o))
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
            cargarDatos(balLINEA.primerRegistro());
        }

        public override void Anterior()
        {
            eLINEA o = new eLINEA();
            o.LIN_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balLINEA.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            eLINEA o = new eLINEA();
            o.LIN_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balLINEA.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balLINEA.ultimoRegistro());
        }

        public override void Buscar()
        {
            eLINEA o = new eLINEA();
            balLINEA b = new balLINEA();

            _frmBusqueda ventana = new _frmBusqueda(true, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.LIN_codigo = ventana.pk;
                DataTable dt = balLINEA.obtenerRegistro(o);
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
            _frmExportar o = new _frmExportar(balLINEA.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["LIN_codigo"].ToString();
                this.txtNombre.Text = dt.Rows[0]["LIN_nombre"].ToString();
                this.cmbCategoria.SelectedValue = dt.Rows[0]["CAT_codigo"].ToString();
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

        private void btnGoCategoria_Click(object sender, EventArgs e)
        {
            eCATEGORIA o = new eCATEGORIA();
            o.CAT_codigo = this.cmbCategoria.SelectedValue != null ? this.cmbCategoria.SelectedValue.ToString() : "";

            frmDM_Categoria o2 = new frmDM_Categoria(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void cmbCategoria_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbCategoria.SelectedValue != null)
            {
                valorSeleccionado = this.cmbCategoria.SelectedValue.ToString();
            }
            this.cmbCategoria.DataSource = balCATEGORIA.poblar();
            this.cmbCategoria.SelectedValue = valorSeleccionado;
        }
    }
}
