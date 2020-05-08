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
    public partial class frmDM_Serie : _frmBaseDM
    {
        eSERIE _o;
        public frmDM_Serie(eSERIE o)
        {
            InitializeComponent();
            tabla = "SERIE";

            this.cmbTipoDocumento.ValueMember = "TDO_codigo";
            this.cmbTipoDocumento.DisplayMember = "TDO_nombre";
            this.cmbTipoDocumento.DataSource = balTIPO_DOCUMENTO.poblar();

            this._o = o;
        }

        private void frmDM_Serie_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtSerie.ReadOnly = true;
            this.cmbTipoDocumento.Enabled = false;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balSERIE.obtenerRegistro(_o)); }
        }

        public override void Nuevo()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.txtSerie.ReadOnly = false;
            this.cmbTipoDocumento.Enabled = true;
        }

        public override bool Guardar()
        {
            int u;
            bool rpta = false;
            try
            {
                eSERIE o = new eSERIE();
                o.SER_serie = this.txtSerie.Text;
                o.TDO_codigo = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";
                o.SER_correlativo_actual = Int32.TryParse(this.txtCorrelativoActual.Text, out u) ? Convert.ToInt32(this.txtCorrelativoActual.Text) : -1;
                o.SER_correlativo_desde = Convert.ToInt32(this.nudCorrelativoDesde.Value);
                o.SER_correlativo_hasta = Convert.ToInt32(this.nudCorrelativoHasta.Value);
                
                if (balSERIE.insertarRegistro(o))
                {
                    mensaje("guardar","");
                    //MessageBox.Show("El registro fue guardado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtSerie.ReadOnly = true;
                    this.cmbTipoDocumento.Enabled = false;
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
                eSERIE o = new eSERIE();
                o.SER_serie = this.txtSerie.Text;
                o.TDO_codigo = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";

                o.SER_correlativo_actual = Int32.TryParse(this.txtCorrelativoActual.Text, out u) ? Convert.ToInt32(this.txtCorrelativoActual.Text) : -1;
                o.SER_correlativo_desde = Convert.ToInt32(this.nudCorrelativoDesde.Value);
                o.SER_correlativo_hasta = Convert.ToInt32(this.nudCorrelativoHasta.Value);

                if (balSERIE.actualizarRegistro(o))
                {
                    mensaje("actualizar","");
                    //MessageBox.Show("El registro fue actualizado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtSerie.ReadOnly = true;
                    this.cmbTipoDocumento.Enabled = false;
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
                eSERIE o = new eSERIE();
                o.SER_serie = this.txtSerie.Text;
                o.TDO_codigo = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";

                if (balSERIE.eliminarRegistro(o))
                {
                    mensaje("eliminar","");
                    //MessageBox.Show("El registro fue eliminado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtSerie.ReadOnly = true;
                    this.cmbTipoDocumento.Enabled = false;
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
            cargarDatos(balSERIE.primerRegistro());
        }

        public override void Anterior()
        {
            eSERIE o = new eSERIE();
            o.SER_serie = this.txtSerie.Text;
            o.TDO_codigo = this.cmbTipoDocumento.Text;
            cargarDatos(balSERIE.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            eSERIE o = new eSERIE();
            o.SER_serie = this.txtSerie.Text;
            o.TDO_codigo = this.cmbTipoDocumento.Text;
            cargarDatos(balSERIE.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balSERIE.ultimoRegistro());
        }

        public override void Buscar()
        {
            eSERIE o = new eSERIE();
            balSERIE obalSERIE = new balSERIE();
            _frmBusqueda ventana = new _frmBusqueda(true, "buscarRegistro", obalSERIE);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.SER_serie = ventana.pk;
                o.TDO_codigo = ventana.pk_2;
                DataTable dt = balSERIE.obtenerRegistro(o);
                cargarDatos(dt);

                this.txtSerie.ReadOnly = true;
                this.cmbTipoDocumento.Enabled = false;
            }
        }

        public override void Cancelar()
        {
            this.txtSerie.ReadOnly = true;
            this.cmbTipoDocumento.Enabled = false;
        }

        public override void ExportarExcel()
        {
            _frmExportar o = new _frmExportar(balSERIE.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtSerie.Text = dt.Rows[0]["SER_serie"].ToString();
                this.cmbTipoDocumento.SelectedValue = dt.Rows[0]["TDO_codigo"].ToString();
                this.txtCorrelativoActual.Text = dt.Rows[0]["SER_correlativo_actual"].ToString();
                this.nudCorrelativoDesde.Value = Convert.ToInt32(dt.Rows[0]["SER_correlativo_desde"].ToString());
                this.nudCorrelativoHasta.Value = Convert.ToInt32(dt.Rows[0]["SER_correlativo_hasta"].ToString());
            }
            else
            {
                _cfgUtil.clearFields(this.gpbInformacion);
                this.txtSerie.ReadOnly = false;
                this.cmbTipoDocumento.Enabled = true;

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

        private void btnGoTipoDocumento_Click(object sender, EventArgs e)
        {
            eTIPO_DOCUMENTO o = new eTIPO_DOCUMENTO();
            o.TDO_codigo = this.cmbTipoDocumento.SelectedValue != null ? this.cmbTipoDocumento.SelectedValue.ToString() : "";

            frmDM_TipoDocumento o2 = new frmDM_TipoDocumento(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        //Refreso de combobox
        private void cmbTipoDocumento_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbTipoDocumento.SelectedValue != null)
            {
                valorSeleccionado = this.cmbTipoDocumento.SelectedValue.ToString();
            }
            this.cmbTipoDocumento.DataSource = balTIPO_DOCUMENTO.poblar();
            this.cmbTipoDocumento.SelectedValue = valorSeleccionado;            
        }
    }
}
