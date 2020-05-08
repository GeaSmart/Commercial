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
    public partial class frmDM_Zona : _frmBaseDM
    {
        eZONA _o;
        public frmDM_Zona(eZONA o)
        {
            InitializeComponent();
            tabla = "ZONA";

            this.cmbRuta.ValueMember = "RUT_codigo";
            this.cmbRuta.DisplayMember = "RUT_nombre";            
            this.cmbRuta.DataSource = balRUTA.poblar();

            this._o = o;
        }

        private void frmDM_Zona_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;
            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balZONA.obtenerRegistro(_o)); }
        }

        public override void Nuevo()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.txtCodigo.ReadOnly = false;
        }

        public override bool Guardar()
        {
            int i;
            bool rpta = false;
            try
            {
                eZONA o = new eZONA();
                o.ZON_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
                o.ZON_nombre = this.txtNombre.Text.Trim();
                o.ZON_descripcion = this.txtDescripcion.Text.Trim();
                o.RUT_codigo = this.cmbRuta.SelectedValue != null ? (Int32.TryParse(this.cmbRuta.SelectedValue.ToString(), out i) ? Convert.ToInt32(this.cmbRuta.SelectedValue.ToString()) : -1) : -1;
                
                if (balZONA.insertarRegistro(o))
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
                eZONA o = new eZONA();
                o.ZON_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
                o.ZON_nombre = this.txtNombre.Text.Trim();
                o.ZON_descripcion = this.txtDescripcion.Text.Trim();
                o.RUT_codigo = this.cmbRuta.SelectedValue != null ? (Int32.TryParse(this.cmbRuta.SelectedValue.ToString(), out i) ? Convert.ToInt32(this.cmbRuta.SelectedValue.ToString()) : -1) : -1;

                if (balZONA.actualizarRegistro(o))
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
                eZONA o = new eZONA();
                o.ZON_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;

                if (balZONA.eliminarRegistro(o))
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
            cargarDatos(balZONA.primerRegistro());
        }

        public override void Anterior()
        {
            int u;
            eZONA o = new eZONA();
            o.ZON_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balZONA.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            int u;
            eZONA o = new eZONA();
            o.ZON_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balZONA.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balZONA.ultimoRegistro());
        }

        public override void Buscar()
        {
            eZONA o = new eZONA();
            balZONA b = new balZONA();
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                int u;
                o.ZON_codigo = Int32.TryParse(ventana.pk, out u) ? Convert.ToInt32(ventana.pk) : -1;
                DataTable dt = balZONA.obtenerRegistro(o);
                cargarDatos(dt);
            }
        }

        public override void Cancelar()
        {
            this.txtCodigo.ReadOnly = true;
        }

        public override void ExportarExcel()
        {
            _frmExportar o = new _frmExportar(balZONA.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            int i;
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["ZON_codigo"].ToString();
                this.txtNombre.Text = dt.Rows[0]["ZON_nombre"].ToString();
                this.cmbRuta.SelectedValue = Int32.TryParse(dt.Rows[0]["RUT_codigo"].ToString(), out i) ? Convert.ToInt32(dt.Rows[0]["RUT_codigo"].ToString()) : -1;
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

        private void btnGoRuta_Click(object sender, EventArgs e)
        {
            eRUTA o = new eRUTA();
            o.RUT_codigo = this.cmbRuta.SelectedValue != null ? Convert.ToInt32(this.cmbRuta.SelectedValue.ToString()) : -1;

            frmDM_Ruta o2 = new frmDM_Ruta(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        //Refresco de combobox
        private void cmbRuta_DropDown(object sender, EventArgs e)
        {
            int valorSeleccionado = -1;
            if (this.cmbRuta.SelectedValue != null)
            {
                valorSeleccionado = Convert.ToInt32(this.cmbRuta.SelectedValue.ToString());
            }
            this.cmbRuta.DataSource = balRUTA.poblar();
            this.cmbRuta.SelectedValue = valorSeleccionado;            
        }
    }
}
