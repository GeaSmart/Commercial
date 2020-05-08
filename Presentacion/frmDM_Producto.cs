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
    public partial class frmDM_Producto : _frmBaseDM
    {
        ePRODUCTO _o;
        public frmDM_Producto(ePRODUCTO o)
        {
            InitializeComponent();
            tabla = "PRODUCTO";

            this.cmbFormato.ValueMember = "FOR_codigo";
            this.cmbFormato.DisplayMember = "FOR_nombre";
            this.cmbFormato.DataSource = balFORMATO.poblar();
            
            this.cmbUnidadMedida.ValueMember = "UME_codigo";
            this.cmbUnidadMedida.DisplayMember = "UME_descripcion";
            this.cmbUnidadMedida.DataSource = balUNIDAD_MEDIDA.poblar();
            
            this.cmbCategoria.ValueMember = "CAT_codigo";
            this.cmbCategoria.DisplayMember = "CAT_nombre";
            this.cmbCategoria.DataSource = balCATEGORIA.poblar();
            
            this.cmbLinea.DataSource = null;

            this.cmbMarca.ValueMember = "MAR_codigo";
            this.cmbMarca.DisplayMember = "MAR_nombre";
            this.cmbMarca.DataSource = balMARCA.poblar();

            this.cmbPack.ValueMember = "PRO_codigo";
            this.cmbPack.DisplayMember = "PRO_descripcion";
            this.cmbPack.DataSource = balPRODUCTO.poblarPacks();


            eDETALLE_IMPUESTO oDETALLE = new eDETALLE_IMPUESTO();
            oDETALLE.IMP_codigo = "ISC";
            this.cmbPorcentajeISC.ValueMember = "DIM_porcentaje";
            this.cmbPorcentajeISC.DisplayMember = "DIM_porcentaje";
            this.cmbPorcentajeISC.DataSource = balDETALLE_IMPUESTO.obtenerDetallePorImpuesto(oDETALLE);

            //this.cmbPorcentajeISC.ValueMember = "PRO_codigo";
            //this.cmbPorcentajeISC.DisplayMember = "PRO_descripcion";
            //this.cmbPorcentajeISC.DataSource = balPRODUCTO.poblarPacks();

            this._o = o;
        }

        private void frmDM_Producto_Load(object sender, EventArgs e)
        {
            Ultimo();
            this.txtCodigo.ReadOnly = true;

            if (this._o == null) { Ultimo(); }
            else { cargarDatos(balPRODUCTO.obtenerRegistro(_o)); }
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
                ePRODUCTO o = new ePRODUCTO();
                o.PRO_codigo = this.txtCodigo.Text.Trim();
                o.PRO_descripcion = this.txtDescripcion.Text.Trim();
                o.FOR_codigo = this.cmbFormato.SelectedValue != null ? this.cmbFormato.SelectedValue.ToString() : null;
                o.PRO_is_igv = this.chkIGV.Checked ? "S" : "N";
                o.PRO_porcentaje_isc = this.cmbPorcentajeISC.SelectedValue != null ? Convert.ToDouble(this.cmbPorcentajeISC.SelectedValue.ToString()) : -1;
                o.PRO_peso_kgr = Convert.ToDouble(this.nudPeso.Value);

                if (this.picImagen.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.picImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    o.PRO_imagen = ms.GetBuffer();
                }
                else { o.PRO_imagen = null; }

                o.PRO_is_activo = this.chkEstado.Checked ? "S" : "N";
                o.UME_codigo= this.cmbUnidadMedida.SelectedValue != null ? this.cmbUnidadMedida.SelectedValue.ToString() : "";
                o.LIN_codigo = this.cmbLinea.SelectedValue != null ? this.cmbLinea.SelectedValue.ToString() : "";
                o.MAR_codigo = this.cmbMarca.SelectedValue != null ? this.cmbMarca.SelectedValue.ToString() : "";
                o.PRO_codigo_pack = this.cmbPack.SelectedValue != null ? this.cmbPack.SelectedValue.ToString() : null;
                o.PRO_is_pack = this.chkIsPack.Checked ? "S" : "N";

                if (balPRODUCTO.insertarRegistro(o))
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
                ePRODUCTO o = new ePRODUCTO();
                o.PRO_codigo = this.txtCodigo.Text.Trim();
                o.PRO_descripcion = this.txtDescripcion.Text.Trim();
                o.FOR_codigo = this.cmbFormato.SelectedValue != null ? this.cmbFormato.SelectedValue.ToString() : null;
                o.PRO_is_igv = this.chkIGV.Checked ? "S" : "N";
                o.PRO_porcentaje_isc = this.cmbPorcentajeISC.SelectedValue != null ? Convert.ToDouble(this.cmbPorcentajeISC.SelectedValue.ToString()) : -1;
                o.PRO_peso_kgr = Convert.ToDouble(this.nudPeso.Value);

                if (this.picImagen.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.picImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    o.PRO_imagen = ms.GetBuffer();
                }
                else { o.PRO_imagen = null; }

                o.PRO_is_activo = this.chkEstado.Checked ? "S" : "N";
                o.UME_codigo = this.cmbUnidadMedida.SelectedValue != null ? this.cmbUnidadMedida.SelectedValue.ToString() : "";
                o.LIN_codigo = this.cmbLinea.SelectedValue != null ? this.cmbLinea.SelectedValue.ToString() : "";
                o.MAR_codigo = this.cmbMarca.SelectedValue != null ? this.cmbMarca.SelectedValue.ToString() : "";
                o.PRO_codigo_pack = this.cmbPack.SelectedValue != null ? this.cmbPack.SelectedValue.ToString() : null;
                o.PRO_is_pack = this.chkIsPack.Checked ? "S" : "N";

                if (balPRODUCTO.actualizarRegistro(o))
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
                ePRODUCTO o = new ePRODUCTO();
                o.PRO_codigo = this.txtCodigo.Text.Trim();

                if (balPRODUCTO.eliminarRegistro(o))
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
            cargarDatos(balPRODUCTO.primerRegistro());
        }

        public override void Anterior()
        {
            ePRODUCTO o = new ePRODUCTO();
            o.PRO_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balPRODUCTO.anteriorRegistro(o));
        }

        public override void Siguiente()
        {
            ePRODUCTO o = new ePRODUCTO();
            o.PRO_codigo = this.txtCodigo.Text.Trim();
            cargarDatos(balPRODUCTO.siguienteRegistro(o));
        }

        public override void Ultimo()
        {
            cargarDatos(balPRODUCTO.ultimoRegistro());
        }

        public override void Buscar()
        {
            ePRODUCTO o = new ePRODUCTO();
            balPRODUCTO b = new balPRODUCTO();

            _frmBusqueda ventana = new _frmBusqueda(true, "buscarRegistro", b);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                o.PRO_codigo = ventana.pk;
                DataTable dt = balPRODUCTO.obtenerRegistro(o);
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
            _frmExportar o = new _frmExportar(balPRODUCTO.poblar());
            o.ShowDialog();
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.cmbCategoria.SelectedValue = dt.Rows[0]["CAT_codigo"].ToString();
                this.txtCodigo.Text = dt.Rows[0]["PRO_codigo"].ToString();
                this.txtDescripcion.Text = dt.Rows[0]["PRO_descripcion"].ToString();
                this.cmbFormato.SelectedValue = dt.Rows[0]["FOR_codigo"].ToString();
                this.chkIGV.Checked = (dt.Rows[0]["PRO_is_igv"].ToString() == "S") ? true : false;
                this.cmbPorcentajeISC.SelectedValue = dt.Rows[0]["PRO_porcentaje_isc"].ToString();
                this.nudPeso.Text = dt.Rows[0]["PRO_peso_kgr"].ToString();
                this.cmbUnidadMedida.SelectedValue = dt.Rows[0]["UME_codigo"].ToString();

                cargarCategoria();

                this.cmbLinea.SelectedValue = dt.Rows[0]["LIN_codigo"].ToString();
                this.cmbMarca.SelectedValue = dt.Rows[0]["MAR_codigo"].ToString();
                this.chkEstado.Checked = (dt.Rows[0]["PRO_is_activo"].ToString() == "S") ? true : false;
                this.cmbPack.SelectedValue = dt.Rows[0]["PRO_codigo_pack"].ToString();
                this.chkIsPack.Checked = (dt.Rows[0]["PRO_is_pack"].ToString() == "S") ? true : false;

                if (dt.Rows[0]["PRO_imagen"].ToString().Length > 0)
                {
                    byte[] imagen = new byte[0];
                    imagen = (byte[])dt.Rows[0]["PRO_imagen"];
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

        private void cargarCategoria()
        {
            if (this.cmbCategoria.SelectedValue != null)
            {
                this.cmbLinea.ValueMember = "LIN_codigo";
                this.cmbLinea.DisplayMember = "LIN_nombre";
                this.cmbLinea.DataSource = balLINEA.mostrarPorCategoria(this.cmbCategoria.SelectedValue.ToString());
            }
            else
            {
                this.cmbLinea.DataSource = null;
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

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCategoria.SelectedValue != null)
            {
                this.cmbLinea.ValueMember = "LIN_codigo";
                this.cmbLinea.DisplayMember = "LIN_nombre";
                this.cmbLinea.DataSource = balLINEA.mostrarPorCategoria(this.cmbCategoria.SelectedValue.ToString());
            }
            else
            {
                this.cmbLinea.DataSource = null;
            }
        }

        private void lklListaPrecios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOP_ListaPrecios o = new frmOP_ListaPrecios(this.txtCodigo.Text);
            o.MdiParent = this.MdiParent;
            o.Show();
        }

        private void lklInventario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRPT_Inventario o = new frmRPT_Inventario(this.txtCodigo.Text);
            o.MdiParent = this.MdiParent;
            o.Show();
        }

        private void btnGoCategoria_Click(object sender, EventArgs e)
        {
            eCATEGORIA o = new eCATEGORIA();
            o.CAT_codigo = this.cmbCategoria.SelectedValue != null ? this.cmbCategoria.SelectedValue.ToString() : "";

            frmDM_Categoria o2 = new frmDM_Categoria(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoFormato_Click(object sender, EventArgs e)
        {
            eFORMATO o = new eFORMATO();
            o.FOR_codigo = this.cmbFormato.SelectedValue != null ? this.cmbFormato.SelectedValue.ToString() : "";

            frmDM_Formato o2 = new frmDM_Formato(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoUnidadMedida_Click(object sender, EventArgs e)
        {
            eUNIDAD_MEDIDA o = new eUNIDAD_MEDIDA();
            o.UME_codigo = this.cmbUnidadMedida.SelectedValue != null ? this.cmbUnidadMedida.SelectedValue.ToString() : "";

            frmDM_UnidadMedida o2 = new frmDM_UnidadMedida(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoLinea_Click(object sender, EventArgs e)
        {
            eLINEA o = new eLINEA();
            o.LIN_codigo = this.cmbLinea.SelectedValue != null ? this.cmbLinea.SelectedValue.ToString() : "";

            frmDM_Linea o2 = new frmDM_Linea(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoMarca_Click(object sender, EventArgs e)
        {
            eMARCA o = new eMARCA();
            o.MAR_codigo = this.cmbMarca.SelectedValue != null ? this.cmbMarca.SelectedValue.ToString() : "";

            frmDM_Marca o2 = new frmDM_Marca(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        //Refreso de combobox
        private void cmbFormato_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbFormato.SelectedValue != null)
            {
                valorSeleccionado = this.cmbFormato.SelectedValue.ToString();
            }
            this.cmbFormato.DataSource = balFORMATO.poblar();
            this.cmbFormato.SelectedValue = valorSeleccionado;            
        }

        private void cmbUnidadMedida_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbUnidadMedida.SelectedValue != null)
            {
                valorSeleccionado = this.cmbUnidadMedida.SelectedValue.ToString();
            }
            this.cmbUnidadMedida.DataSource = balUNIDAD_MEDIDA.poblar();
            this.cmbUnidadMedida.SelectedValue = valorSeleccionado;
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

        private void cmbLinea_DropDown(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue != null)
            {
                string valorSeleccionado = "";
                if (this.cmbLinea.SelectedValue != null)
                {
                    valorSeleccionado = this.cmbLinea.SelectedValue.ToString();
                }
                this.cmbLinea.DataSource = balLINEA.mostrarPorCategoria(this.cmbCategoria.SelectedValue.ToString());
                this.cmbLinea.SelectedValue = valorSeleccionado;
            }
        }

        private void cmbMarca_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbMarca.SelectedValue != null)
            {
                valorSeleccionado = this.cmbMarca.SelectedValue.ToString();
            }
            this.cmbMarca.DataSource = balMARCA.poblar();
            this.cmbMarca.SelectedValue = valorSeleccionado;            
        }

        private void cmbPack_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbPack.SelectedValue != null)
            {
                valorSeleccionado = this.cmbPack.SelectedValue.ToString();
            }
            this.cmbPack.DataSource = balPRODUCTO.poblarPacks();
            this.cmbPack.SelectedValue = valorSeleccionado;
        }
    }
}
