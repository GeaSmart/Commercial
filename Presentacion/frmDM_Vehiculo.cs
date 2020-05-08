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
    public partial class frmDM_Vehiculo : _frmBaseDM
    {
        eVEHICULO _o;
        public frmDM_Vehiculo(eVEHICULO o)
        {
            InitializeComponent();
            tabla = "VEHICULO";
            this._o = o;
        }

        private void frmDM_Vehiculo_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtPlaca.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balVEHICULO.obtenerRegistro(_o)); }
        }

        public override void Nuevo()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.txtPlaca.ReadOnly = false;
        }

        public override bool Guardar()
        {
            bool rpta = false;
            try
            {
                eVEHICULO o = new eVEHICULO();
                o.VEH_placa = this.txtPlaca.Text.Trim();
                o.VEH_nombre = this.txtNombre.Text.Trim();
                o.VEH_tonelaje = Convert.ToDouble(this.nudTonelaje.Value);
                
                if (balVEHICULO.insertarRegistro(o))
                {
                    mensaje("guardar","");
                    //MessageBox.Show("El registro fue guardado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtPlaca.ReadOnly = true;
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
                eVEHICULO o = new eVEHICULO();
                o.VEH_placa = this.txtPlaca.Text.Trim();
                o.VEH_nombre = this.txtNombre.Text.Trim();
                o.VEH_tonelaje = Convert.ToDouble(this.nudTonelaje.Value);

                if (balVEHICULO.actualizarRegistro(o))
                {
                    mensaje("actualizar","");
                    //MessageBox.Show("El registro fue actualizado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtPlaca.ReadOnly = true;
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
                eVEHICULO o = new eVEHICULO();
                o.VEH_placa = this.txtPlaca.Text.Trim();

                if (balVEHICULO.eliminarRegistro(o))
                {
                    mensaje("eliminar","");
                    //MessageBox.Show("El registro fue eliminado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtPlaca.ReadOnly = true;
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
            cargarDatos(balVEHICULO.primerRegistro());
        }

        public override void Anterior()
        {
            eVEHICULO o = new eVEHICULO();
            o.VEH_placa = this.txtPlaca.Text.Trim();
            cargarDatos(balVEHICULO.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            eVEHICULO o = new eVEHICULO();
            o.VEH_placa = this.txtPlaca.Text.Trim();
            cargarDatos(balVEHICULO.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balVEHICULO.ultimoRegistro());
        }

        public override void Buscar()
        {
            eVEHICULO o = new eVEHICULO();
            balVEHICULO b = new balVEHICULO();
            
            _frmBusqueda ventana = new _frmBusqueda(true, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.VEH_placa = ventana.pk;
                DataTable dt = balVEHICULO.obtenerRegistro(o);
                cargarDatos(dt);

                this.txtPlaca.ReadOnly = true;
            }
        }

        public override void Cancelar()
        {
            this.txtPlaca.ReadOnly = true;
        }

        public override void ExportarExcel()
        {
            _frmExportar o = new _frmExportar(balVEHICULO.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtPlaca.Text = dt.Rows[0]["VEH_placa"].ToString();
                this.txtNombre.Text = dt.Rows[0]["VEH_nombre"].ToString();
                this.nudTonelaje.Text = dt.Rows[0]["VEH_tonelaje"].ToString();
            }
            else
            {
                _cfgUtil.clearFields(this.gpbInformacion);
                this.txtPlaca.ReadOnly = false;

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
