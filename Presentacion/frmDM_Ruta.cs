﻿using System;
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
    public partial class frmDM_Ruta : _frmBaseDM
    {
        eRUTA _o;
        public frmDM_Ruta(eRUTA o)
        {
            InitializeComponent();
            tabla = "RUTA";

            this._o = o;
        }

        private void frmDM_Ruta_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balRUTA.obtenerRegistro(_o)); }
        }

        public override void Nuevo()
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.txtCodigo.ReadOnly = true;
        }

        public override bool Guardar()
        {
            bool rpta = false;
            try
            {
                eRUTA o = new eRUTA();
                o.RUT_nombre = String.IsNullOrWhiteSpace(this.txtNombre.Text.Trim()) ? "" : this.txtNombre.Text.Trim();

                if (balRUTA.insertarRegistro(o))
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
                eRUTA o = new eRUTA();
                o.RUT_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
                o.RUT_nombre = String.IsNullOrWhiteSpace(this.txtNombre.Text.Trim()) ? "" : this.txtNombre.Text.Trim();

                if (balRUTA.actualizarRegistro(o))
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
                eRUTA o = new eRUTA();
                o.RUT_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
                
                if (balRUTA.eliminarRegistro(o))
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
            cargarDatos(balRUTA.primerRegistro());
        }

        public override void Anterior()
        {
            int u;
            eRUTA o = new eRUTA();
            o.RUT_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balRUTA.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            int u;
            eRUTA o = new eRUTA();
            o.RUT_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out u) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balRUTA.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balRUTA.ultimoRegistro());
        }

        public override void Buscar()
        {
            eRUTA o = new eRUTA();
            balRUTA b = new balRUTA();
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                int u;
                o.RUT_codigo = Int32.TryParse(ventana.pk, out u) ? Convert.ToInt32(ventana.pk) : -1;
                DataTable dt = balRUTA.obtenerRegistro(o);
                cargarDatos(dt);
            }
        }

        public override void Cancelar()
        {
            this.txtCodigo.ReadOnly = true;
        }

        public override void ExportarExcel()
        {
            _frmExportar o = new _frmExportar(balRUTA.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["RUT_codigo"].ToString();
                this.txtNombre.Text = dt.Rows[0]["RUT_nombre"].ToString();
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
