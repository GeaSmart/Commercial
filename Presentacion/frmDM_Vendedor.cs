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
    public partial class frmDM_Vendedor : _frmBaseDM
    {
        eVENDEDOR _o;
        public frmDM_Vendedor(eVENDEDOR o)
        {
            InitializeComponent();
            tabla = "VENDEDOR";
            this._o = o;
        }

        private void frmDM_Vendedor_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balVENDEDOR.obtenerRegistro(_o)); }
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
                eVENDEDOR o = new eVENDEDOR();
                o.VEN_nombre_completo = this.txtNombreCompleto.Text.Trim();
                o.VEN_dni = this.txtDNI.Text.Trim();
                o.VEN_telefono = this.txtTelefono.Text.Trim();
                o.VEN_estado = this.chkEstado.Checked ? "S" : "N";
                o.VEN_comentario = this.txtComentario.Text.Trim();
                if (this.picImagen.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.picImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    o.VEN_imagen = ms.GetBuffer();
                }
                else { o.VEN_imagen = null; }

                if (balVENDEDOR.insertarRegistro(o))
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
                eVENDEDOR o = new eVENDEDOR();
                o.VEN_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
                o.VEN_nombre_completo = this.txtNombreCompleto.Text.Trim();
                o.VEN_dni = this.txtDNI.Text.Trim();
                o.VEN_telefono = this.txtTelefono.Text.Trim();
                o.VEN_estado = this.chkEstado.Checked ? "S" : "N";
                o.VEN_comentario = this.txtComentario.Text.Trim();
                if (this.picImagen.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.picImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    o.VEN_imagen = ms.GetBuffer();
                }
                else { o.VEN_imagen = null; }

                if (balVENDEDOR.actualizarRegistro(o))
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
            int i;
            bool rpta = false;
            try
            {
                eVENDEDOR o = new eVENDEDOR();
                o.VEN_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;

                if (balVENDEDOR.eliminarRegistro(o))
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
            cargarDatos(balVENDEDOR.primerRegistro());
        }

        public override void Anterior()
        {
            int i;
            eVENDEDOR o = new eVENDEDOR();
            o.VEN_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balVENDEDOR.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            int i;
            eVENDEDOR o = new eVENDEDOR();
            o.VEN_codigo = Int32.TryParse(this.txtCodigo.Text.Trim(), out i) ? Convert.ToInt32(this.txtCodigo.Text.Trim()) : -1;
            cargarDatos(balVENDEDOR.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balVENDEDOR.ultimoRegistro());
        }

        public override void Buscar()
        {
            int i;
            eVENDEDOR o = new eVENDEDOR();
            balVENDEDOR b = new balVENDEDOR();
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.VEN_codigo = Int32.TryParse(ventana.pk, out i) ? Convert.ToInt32(ventana.pk) : -1;
                DataTable dt = balVENDEDOR.obtenerRegistro(o);
                cargarDatos(dt);
            }
        }

        public override void Cancelar()
        {
            this.txtCodigo.ReadOnly = true;
        }

        public override void ExportarExcel()
        {
            _frmExportar o = new _frmExportar(balVENDEDOR.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.txtCodigo.Text = dt.Rows[0]["VEN_codigo"].ToString();
                this.txtNombreCompleto.Text = dt.Rows[0]["VEN_nombre_completo"].ToString();
                this.txtDNI.Text = dt.Rows[0]["VEN_dni"].ToString();
                this.txtTelefono.Text = dt.Rows[0]["VEN_telefono"].ToString();
                this.chkEstado.Checked = (dt.Rows[0]["VEN_estado"].ToString() == "S") ? true : false;
                this.txtComentario.Text = dt.Rows[0]["VEN_comentario"].ToString();
                
                if (dt.Rows[0]["VEN_imagen"].ToString().Length > 0)
                {
                    byte[] imagen = new byte[0];
                    imagen = (byte[])dt.Rows[0]["VEN_imagen"];
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(imagen);
                    this.picImagen.Image = Image.FromStream(ms);
                    this.btnBorrarImagen.Enabled = true;
                    this.btnExportarImagen.Enabled = true;
                }
                else
                {
                    this.picImagen.Image = null;
                    this.btnBorrarImagen.Enabled = false;
                    this.btnExportarImagen.Enabled = false;
                }
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

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            //Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Todas las imágenes|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|BMP|*.bmp|GIF|*.gif|JPEG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
            dialog.Title = "Seleccione fotografía";
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                picImagen.Image = _cfgUtil.ScaleImage(Image.FromFile(dialog.FileName), 210, 210);
            }
        }

        private void btnBorrarImagen_Click(object sender, EventArgs e)
        {
            this.picImagen.Image = null;
        }

        private void btnExportarImagen_Click(object sender, EventArgs e)
        {
            if (this.picImagen.Image != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Imagen Jpeg|*.jpg|Imagen Bitmap|*.bmp|Imagen Gif|*.gif";
                saveFileDialog1.Title = "Guardar imagen en equipo";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            this.picImagen.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case 2:
                            this.picImagen.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case 3:
                            this.picImagen.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                    }
                    fs.Close();
                }
            }
        }
    }
}
