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
    public partial class frmDM_Usuario : _frmBaseDM
    {
        eUSUARIO _o;

        public frmDM_Usuario(eUSUARIO o)
        {
            InitializeComponent();
            tabla = "USUARIO";

            this.cmbPerfil.DisplayMember = "PER_nombre";
            this.cmbPerfil.ValueMember = "PER_codigo";
            this.cmbPerfil.DataSource = balPERFIL.poblar();

            this._o = o;
        }

        private void frmDM_Usuario_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtUsuario.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balUSUARIO.obtenerRegistro(_o)); }
        }

        public override void Nuevo()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.txtUsuario.ReadOnly = false;
        }

        public override bool Guardar()
        {
            int u;
            bool rpta = false;
            try
            {
                eUSUARIO _oeUSUARIO = new eUSUARIO();
                _oeUSUARIO.USU_usuario = this.txtUsuario.Text;
                _oeUSUARIO.USU_contrasena = this.txtContrasena.Text;
                _oeUSUARIO.USU_dni = int.TryParse(this.txtDNI.Text, out u) ? this.txtDNI.Text : "";
                _oeUSUARIO.USU_nombre_completo = this.txtNombreCompleto.Text;
                _oeUSUARIO.USU_comentario = this.txtComentario.Text;
                _oeUSUARIO.PER_codigo = this.cmbPerfil.SelectedValue != null ? this.cmbPerfil.SelectedValue.ToString() : "";

                if (balUSUARIO.insertarRegistro(_oeUSUARIO))
                {
                    mensaje("guardar","");
                    //MessageBox.Show("El registro fue guardado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtUsuario.ReadOnly = true;
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
                eUSUARIO _oeUSUARIO = new eUSUARIO();
                _oeUSUARIO.USU_usuario = this.txtUsuario.Text;
                _oeUSUARIO.USU_contrasena = this.txtContrasena.Text;
                _oeUSUARIO.USU_dni = int.TryParse(this.txtDNI.Text, out u) ? this.txtDNI.Text : "";
                _oeUSUARIO.USU_nombre_completo = this.txtNombreCompleto.Text;
                _oeUSUARIO.USU_comentario = this.txtComentario.Text;
                _oeUSUARIO.PER_codigo = this.cmbPerfil.SelectedValue != null ? this.cmbPerfil.SelectedValue.ToString() : "";

                if (balUSUARIO.actualizarRegistro(_oeUSUARIO))
                {
                    mensaje("actualizar","");
                    //MessageBox.Show("El registro fue actualizado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtUsuario.ReadOnly = true;
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
                eUSUARIO _oeUSUARIO = new eUSUARIO();
                _oeUSUARIO.USU_usuario = this.txtUsuario.Text;

                if (balUSUARIO.eliminarRegistro(_oeUSUARIO))
                {
                    mensaje("eliminar","");
                    //MessageBox.Show("El registro fue eliminado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtUsuario.ReadOnly = true;
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
            cargarDatos(balUSUARIO.primerRegistro());
        }

        public override void Anterior()
        {
            eUSUARIO _oeUSUARIO = new eUSUARIO();
            _oeUSUARIO.USU_usuario = this.txtUsuario.Text;
            cargarDatos(balUSUARIO.anteriorRegistro(_oeUSUARIO));
        }

        public override void Siguiente()
        {
            eUSUARIO _oeUSUARIO = new eUSUARIO();
            _oeUSUARIO.USU_usuario = this.txtUsuario.Text;
            cargarDatos(balUSUARIO.siguienteRegistro(_oeUSUARIO));
        }

        public override void Ultimo()
        {
            cargarDatos(balUSUARIO.ultimoRegistro());
        }

        public override void Buscar()
        {
            eUSUARIO oeUSUARIO = new eUSUARIO();
            balUSUARIO obalUSUARIO = new balUSUARIO();
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", obalUSUARIO);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                oeUSUARIO.USU_usuario = ventana.pk;
                DataTable dt = balUSUARIO.obtenerRegistro(oeUSUARIO);
                cargarDatos(dt);
            }
        }

        public override void Cancelar()
        {
            this.txtUsuario.ReadOnly = true;
        }

        public override void ExportarExcel()
        {
            _frmExportar o = new _frmExportar(balUSUARIO.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtUsuario.Text = dt.Rows[0]["USU_usuario"].ToString();
                this.txtNombreCompleto.Text = dt.Rows[0]["USU_nombre_completo"].ToString();
                this.txtDNI.Text = dt.Rows[0]["USU_dni"].ToString();
                this.txtContrasena.Text = dt.Rows[0]["USU_contrasena"].ToString();
                this.txtComentario.Text = dt.Rows[0]["USU_comentario"].ToString();
                this.cmbPerfil.SelectedValue = dt.Rows[0]["PER_codigo"].ToString();
            }
            else
            {
                _cfgUtil.clearFields(this.gpbInformacion);
                this.txtUsuario.ReadOnly = false;

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

        private void btnGoPerfil_Click(object sender, EventArgs e)
        {
            ePERFIL o = new ePERFIL();
            o.PER_codigo = this.cmbPerfil.SelectedValue != null ? this.cmbPerfil.SelectedValue.ToString() : "";

            frmDM_Perfil o2 = new frmDM_Perfil(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        //Refresco de combobox
        private void cmbPerfil_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbPerfil.SelectedValue != null)
            {
                valorSeleccionado = this.cmbPerfil.SelectedValue.ToString();
            }
            this.cmbPerfil.DataSource = balPERFIL.poblar();
            this.cmbPerfil.SelectedValue = valorSeleccionado;
        }
    }
}
