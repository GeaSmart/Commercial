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
    public partial class frmDM_Chofer : _frmBaseDM
    {
        eCHOFER _o;
        public frmDM_Chofer(eCHOFER o)
        {
            InitializeComponent();
            tabla = "CHOFER";

            this.cmbVehiculo.ValueMember = "VEH_placa";
            this.cmbVehiculo.DisplayMember = "VEH_nombre";
            this.cmbVehiculo.DataSource = balVEHICULO.poblar();

            this._o = o;
        }

        private void frmDM_Chofer_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balCHOFER.obtenerRegistro(_o)); }
        }

        public override void Nuevo()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            //this.txtCodigo.ReadOnly = false;
        }

        public override bool Guardar()
        {
            bool rpta = false;
            try
            {
                eCHOFER o = new eCHOFER();
                o.CHO_nombre_completo = this.txtNombreCompleto.Text.Trim();
                o.CHO_dni = this.txtDNI.Text.Trim();
                o.VEH_placa = this.cmbVehiculo.SelectedValue != null ? this.cmbVehiculo.SelectedValue.ToString() : "";
                o.CHO_licencia_conducir = this.txtLicencia.Text.Trim();
                
                if (balCHOFER.insertarRegistro(o))
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
                eCHOFER o = new eCHOFER();
                o.CHO_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
                o.CHO_nombre_completo = this.txtNombreCompleto.Text.Trim();
                o.CHO_dni = this.txtDNI.Text.Trim();
                o.VEH_placa = this.cmbVehiculo.SelectedValue != null ? this.cmbVehiculo.SelectedValue.ToString() : "";
                o.CHO_licencia_conducir = this.txtLicencia.Text.Trim();

                if (balCHOFER.actualizarRegistro(o))
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
                eCHOFER o = new eCHOFER();
                o.CHO_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;

                if (balCHOFER.eliminarRegistro(o))
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
            cargarDatos(balCHOFER.primerRegistro());
        }

        public override void Anterior()
        {
            int u;
            eCHOFER o = new eCHOFER();
            o.CHO_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balCHOFER.anteriorRegistro(o));            
        }

        public override void Siguiente()
        {
            int u;
            eCHOFER o = new eCHOFER();
            o.CHO_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(),out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balCHOFER.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balCHOFER.ultimoRegistro());
        }

        public override void Buscar()
        {
            int u;
            eCHOFER o = new eCHOFER();
            balCHOFER b = new balCHOFER();
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.CHO_codigo = Int32.TryParse(ventana.pk, out u) ? Convert.ToInt32(ventana.pk) : -1;
                DataTable dt = balCHOFER.obtenerRegistro(o);
                cargarDatos(dt);
            }
        }

        public override void Cancelar()
        {
            this.txtCodigo.ReadOnly = true;
        }

        public override void ExportarExcel()
        {
            _frmExportar o = new _frmExportar(balCHOFER.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["CHO_codigo"].ToString();
                this.txtNombreCompleto.Text = dt.Rows[0]["CHO_nombre_completo"].ToString();
                this.txtDNI.Text = dt.Rows[0]["CHO_dni"].ToString();
                this.cmbVehiculo.SelectedValue = dt.Rows[0]["VEH_placa"].ToString();
                this.txtLicencia.Text = dt.Rows[0]["CHO_licencia_conducir"].ToString();                
            }
            else
            {
                _cfgUtil.clearFields(this.gpbInformacion);
                //this.txtCodigo.ReadOnly = false;

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

        private void btnGoVehiculo_Click(object sender, EventArgs e)
        {
            eVEHICULO o = new eVEHICULO();
            o.VEH_placa = this.cmbVehiculo.SelectedValue != null ? this.cmbVehiculo.SelectedValue.ToString() : "";

            frmDM_Vehiculo o2 = new frmDM_Vehiculo(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        //Refresco de los combobox
        private void cmbVehiculo_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbVehiculo.SelectedValue != null)
            {
                valorSeleccionado = this.cmbVehiculo.SelectedValue.ToString();
            }
            this.cmbVehiculo.DataSource = balVEHICULO.poblar();
            this.cmbVehiculo.SelectedValue = valorSeleccionado;            
        }
    }
}
