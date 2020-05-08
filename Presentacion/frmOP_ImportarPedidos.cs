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
    public partial class frmOP_ImportarPedidos : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmOP_ImportarPedidos()
        {
            InitializeComponent();
        }

        private void dgvCabecera_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            _cfgUtil.enumerarFilasDatagridview(this.dgvCabecera, e);
        }

        private void dgvDetalle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            _cfgUtil.enumerarFilasDatagridview(this.dgvDetalle, e);
        }

        private void cargarTabla()
        {
            DataTable dtCabecera = new DataTable();
            dtCabecera.Columns.Add("PED_numero");
            dtCabecera.Columns.Add("PED_fecha");
            dtCabecera.Columns.Add("PED_fecha_entrega");
            dtCabecera.Columns.Add("VEN_codigo");
            dtCabecera.Columns.Add("PED_nombre_vendedor");
            dtCabecera.Columns.Add("SOC_codigo");
            dtCabecera.Columns.Add("PED_soc_nombre_razon");
            dtCabecera.Columns.Add("PED_soc_direccion");
            dtCabecera.Columns.Add("PED_soc_zona");
            dtCabecera.Columns.Add("PED_subtotal");
            dtCabecera.Columns.Add("PED_porcentaje_igv");            
            dtCabecera.Columns.Add("PED_porcentaje_percepcion");
            dtCabecera.Columns.Add("PED_monto_igv");
            dtCabecera.Columns.Add("PED_monto_isc");
            dtCabecera.Columns.Add("PED_monto_percepcion");
            dtCabecera.Columns.Add("PED_monto_total");
            dtCabecera.Columns.Add("PED_comentario");
            dtCabecera.Columns.Add("PED_estado");
            dtCabecera.Columns.Add("CPA_codigo");
            dtCabecera.Columns.Add("PED_tdo_codigo");
        }

        public DataTable ConvertToDataTableCab(string filePath, int numberOfColumns, bool tieneCabecera)
        {
            DataTable dtCabecera = new DataTable();
            dtCabecera.Columns.Add("PED_numero");
            dtCabecera.Columns.Add("PED_fecha");
            dtCabecera.Columns.Add("PED_fecha_entrega");
            dtCabecera.Columns.Add("VEN_codigo");
            dtCabecera.Columns.Add("PED_nombre_vendedor");
            dtCabecera.Columns.Add("SOC_codigo");
            dtCabecera.Columns.Add("PED_soc_nombre_razon");
            dtCabecera.Columns.Add("PED_soc_direccion");
            dtCabecera.Columns.Add("PED_soc_zona");
            dtCabecera.Columns.Add("PED_subtotal");
            dtCabecera.Columns.Add("PED_porcentaje_igv");            
            dtCabecera.Columns.Add("PED_porcentaje_percepcion");
            dtCabecera.Columns.Add("PED_monto_igv");
            dtCabecera.Columns.Add("PED_monto_isc");
            dtCabecera.Columns.Add("PED_monto_percepcion");
            dtCabecera.Columns.Add("PED_monto_total");
            dtCabecera.Columns.Add("PED_comentario");
            dtCabecera.Columns.Add("PED_estado");
            dtCabecera.Columns.Add("CPA_codigo");
            dtCabecera.Columns.Add("PED_tdo_codigo");

            string[] lines;

            if (tieneCabecera)
            {
                lines = System.IO.File.ReadAllLines(filePath, Encoding.GetEncoding(1250)).Skip(1).ToArray();
            }
            else
            {
                lines = System.IO.File.ReadAllLines(filePath, Encoding.GetEncoding(1250));//.Skip(1).ToArray();
            }

            bool cantidadColCorrecta = true;
            int columnasOmitidas = 0;

            foreach (string line in lines)
            {
                var cols = line.Split('\t');

                DataRow dr = dtCabecera.NewRow();

                if (cols.Length == numberOfColumns)
                {
                    for (int cIndex = 0; cIndex < numberOfColumns; cIndex++)
                    {
                        dr[cIndex] = cols[cIndex];
                    }

                    dtCabecera.Rows.Add(dr);
                }
                else
                {
                    cantidadColCorrecta &= false;
                    columnasOmitidas++;
                }
            }

            if (!cantidadColCorrecta)
            {
                if (columnasOmitidas == lines.Length)
                {
                    MessageBox.Show("La cantidad de columnas de su archivo de texto no coincide con las permitidas, por favor revise su archivo TXT y vuelva a intentarlo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Se han omitido " + columnasOmitidas + " fila(s) de su archivo de texto seleccionado por no coincidir con el número de columnas permitidas, puede omitir esto y migrar sólo las correctas o revisar su archivo TXT y volver a intentarlo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return dtCabecera;
        }

        public DataTable ConvertToDataTableDet(string filePath, int numberOfColumns, bool tieneCabecera)
        {
            DataTable dtDetalle = new DataTable();
            dtDetalle.Columns.Add("PED_numero");
            dtDetalle.Columns.Add("PRO_codigo");
            dtDetalle.Columns.Add("DPE_is_bonificacion");
            dtDetalle.Columns.Add("DPE_pro_descripcion");
            dtDetalle.Columns.Add("DPE_cantidad");
            dtDetalle.Columns.Add("DPE_cantidad_submultiplo");
            dtDetalle.Columns.Add("DPE_precio_unitario");
            dtDetalle.Columns.Add("DPE_monto_subtotal");
            dtDetalle.Columns.Add("DPE_monto_descuento");
            dtDetalle.Columns.Add("DPE_porcentaje_descuento");
            dtDetalle.Columns.Add("DPE_monto_igv");
            dtDetalle.Columns.Add("DPE_monto_isc");
            dtDetalle.Columns.Add("DPE_porcentaje_isc");
            dtDetalle.Columns.Add("DPE_monto_total_linea");
            dtDetalle.Columns.Add("DPE_memo");

            string[] lines;

            if (tieneCabecera)
            {
                lines = System.IO.File.ReadAllLines(filePath, Encoding.GetEncoding(1250)).Skip(1).ToArray();
            }
            else
            {
                lines = System.IO.File.ReadAllLines(filePath, Encoding.GetEncoding(1250));//.Skip(1).ToArray();
            }

            bool cantidadColCorrecta = true;
            int columnasOmitidas = 0;

            foreach (string line in lines)
            {
                var cols = line.Split('\t');

                DataRow dr = dtDetalle.NewRow();
                if (cols.Length == numberOfColumns)
                {
                    for (int cIndex = 0; cIndex < numberOfColumns; cIndex++)
                    {
                        dr[cIndex] = cols[cIndex];                        
                    }
                    dtDetalle.Rows.Add(dr);
                }
                else
                {
                    cantidadColCorrecta &= false;
                    columnasOmitidas++;
                }                
            }

            if (!cantidadColCorrecta)
            {
                if (columnasOmitidas == lines.Length)
                {
                    MessageBox.Show("La cantidad de columnas de su archivo de texto no coincide con las permitidas, por favor revise su archivo TXT y vuelva a intentarlo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Se han omitido " + columnasOmitidas + " fila(s) de su archivo de texto seleccionado por no coincidir con el número de columnas permitidas, puede omitir esto y migrar sólo las correctas o revisar su archivo TXT y volver a intentarlo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return dtDetalle;
        }

        private void btnAbrirCabecera_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                String ruta = "";
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Archivo de Texto (Delimitado por tabulaciones) |*.txt";
                openfile1.Title = "Seleccione el archivo de Texto";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }
                this.txtRutaCabecera.Text = ruta;

                if (this.txtRutaCabecera.Text.Length > 0)
                {
                    this.dgvCabecera.DataSource = ConvertToDataTableCab(ruta, 20, false);
                }
                validarCabecera();
                validarDetalle();
            }
            catch (SystemException ex)
            {

            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void btnAbrirDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                String ruta = "";
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Archivo de Texto (Delimitado por tabulaciones) |*.txt";
                openfile1.Title = "Seleccione el archivo de Texto";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }
                this.txtRutaDetalle.Text = ruta;

                if (this.txtRutaDetalle.Text.Length > 0)
                {
                    this.dgvDetalle.DataSource = ConvertToDataTableDet(ruta, 15, false);
                }
                validarCabecera();
                validarDetalle();
            }
            catch (SystemException ex)
            {

            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }            
        }

        private void chkPrimeraFilaCab_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPrimeraFilaCab.Checked)
            {
                this.dgvCabecera.DataSource = ConvertToDataTableCab(this.txtRutaCabecera.Text, 20, true);
            }
            else
            {
                this.dgvCabecera.DataSource = ConvertToDataTableCab(this.txtRutaCabecera.Text, 20, false);
            }
        }

        private void chkPrimeraFilaDet_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPrimeraFilaDet.Checked)
            {
                this.dgvDetalle.DataSource = ConvertToDataTableDet(this.txtRutaDetalle.Text, 15, true);
            }
            else
            {
                this.dgvDetalle.DataSource = ConvertToDataTableDet(this.txtRutaDetalle.Text, 15, false);
            }
        }

        private void dgvCabecera_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.txtCabeceraFilas.Text = this.dgvCabecera.RowCount.ToString();
            cargarDTCab();
            //cargarDTDet();
            validarCabecera();
            validarDetalle();
        }

        private void dgvDetalle_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.txtDetalleFilas.Text = this.dgvDetalle.RowCount.ToString();
            cargarDTCab();
            cargarDTDet();
            validarCabecera();
            validarDetalle();
            
        }

        private void btnValidarCabecera_Click(object sender, EventArgs e)
        {
            validarCabecera();
        }

        private void btnValidarDetalle_Click(object sender, EventArgs e)
        {
            validarDetalle();
        }

        DataTable dtCab = new DataTable();
        
        private void validarCabecera()
        {
            try
            {
                dtCab.Columns.Clear();
                dtCab.Columns.Add();
                dtCab.Clear();

                int n = 0;
                DateTime d;
                double u;

                bool resultadoFila = false;
                bool resultadoRegistroExiste = false;

                int contadorErrores = 0;

                for (int i = 0; i < this.dgvCabecera.RowCount; i++)
                {
                    resultadoFila = true;
                    resultadoFila &= int.TryParse(this.dgvCabecera["PED_numero1", i].Value.ToString(), out n);
                    resultadoFila &= DateTime.TryParse(this.dgvCabecera["PED_fecha", i].Value.ToString(), out d);
                    resultadoFila &= DateTime.TryParse(this.dgvCabecera["PED_fecha_entrega", i].Value.ToString(), out d);
                    resultadoFila &= int.TryParse(this.dgvCabecera["VEN_codigo", i].Value.ToString(), out n);
                    resultadoFila &= this.dgvCabecera["PED_nombre_vendedor", i].Value.ToString().Length > 0;
                    resultadoFila &= int.TryParse(this.dgvCabecera["SOC_codigo", i].Value.ToString(), out n);
                    resultadoFila &= this.dgvCabecera["PED_soc_nombre_razon", i].Value.ToString().Length > 0;
                    resultadoFila &= this.dgvCabecera["PED_soc_direccion", i].Value.ToString().Length > 0;
                    resultadoFila &= int.TryParse(this.dgvCabecera["PED_soc_zona", i].Value.ToString(), out n);
                    resultadoFila &= double.TryParse(this.dgvCabecera["PED_subtotal", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvCabecera["PED_porcentaje_igv", i].Value.ToString(), out u);
                    //resultadoFila &= double.TryParse(this.dgvCabecera["PED_porcentaje_isc", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvCabecera["PED_porcentaje_percepcion", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvCabecera["PED_monto_igv", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvCabecera["PED_monto_isc", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvCabecera["PED_monto_percepcion", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvCabecera["PED_monto_total", i].Value.ToString(), out u);
                    //resultadoFila &= int.TryParse(this.dgvCabecera["PED_comentario", i].Value.ToString(), out n);
                    resultadoFila &= this.dgvCabecera["PED_estado", i].Value.ToString().Length == 1 && (this.dgvCabecera["PED_estado", i].Value.ToString() == "A");
                    resultadoFila &= this.dgvCabecera["CPA_codigo", i].Value.ToString().Length > 0;
                    resultadoFila &= this.dgvCabecera["PED_tdo_codigo", i].Value.ToString().Length == 3;

                    resultadoRegistroExiste = false;

                    if (resultadoFila)
                    {
                        int PED_numero = Convert.ToInt16(this.dgvCabecera["PED_numero1", i].Value.ToString());
                        bool bandera = false;

                        for (int t = 0; t < dtDet.Rows.Count; t++)
                        {
                            if (dtDet.Rows[t][0].ToString() == PED_numero.ToString())
                            {
                                bandera |= true;
                                break;
                            }
                        }

                        resultadoRegistroExiste = true;

                        ePEDIDO oePEDIDO = new ePEDIDO();
                        //balPEDIDO obalPEDIDO = new balPEDIDO();

                        eVENDEDOR oeVENDEDOR = new eVENDEDOR();
                        //balVENDEDOR obalVENDEDOR = new balVENDEDOR();

                        eSOCIO oeSOCIO = new eSOCIO();
                        //balSOCIO obalSOCIO = new balSOCIO();

                        eCONDICION_PAGO oeCONDICIONPAGO = new eCONDICION_PAGO();
                        //balCONDICION_PAGO obalCONDICIONPAGO = new balCONDICION_PAGO();

                        oePEDIDO.PED_numero = Convert.ToInt32(this.dgvCabecera["PED_numero1", i].Value.ToString());
                        oeVENDEDOR.VEN_codigo = Convert.ToInt16(this.dgvCabecera["VEN_codigo", i].Value.ToString());
                        oeSOCIO.SOC_codigo = Convert.ToInt16(this.dgvCabecera["SOC_codigo", i].Value.ToString());
                        oeCONDICIONPAGO.CPA_codigo = this.dgvCabecera["CPA_codigo", i].Value.ToString();

                        resultadoRegistroExiste &= balPEDIDO.obtenerRegistro(oePEDIDO) == null;
                        resultadoRegistroExiste &= balVENDEDOR.obtenerRegistro(oeVENDEDOR) != null;
                        resultadoRegistroExiste &= balSOCIO.obtenerRegistro(oeSOCIO) != null;
                        resultadoRegistroExiste &= balCONDICION_PAGO.obtenerRegistro(oeCONDICIONPAGO) != null;

                        resultadoRegistroExiste &= bandera;
                    }

                    if (resultadoRegistroExiste)
                    {
                        this.dgvCabecera["Check1", i].Style.BackColor = Color.LightGreen;
                        this.dgvCabecera["Check1", i].Value = "OK";

                        //Carga los PED_numero al datatable dtCab
                        DataRow dr = dtCab.NewRow();
                        dr[0] = this.dgvCabecera["PED_numero1", i].Value.ToString();
                        dtCab.Rows.Add(dr[0]);
                    }
                    else
                    {
                        this.dgvCabecera["Check1", i].Style.BackColor = Color.Orange;
                        this.dgvCabecera["Check1", i].Value = "Err";
                    }

                    if (this.dgvCabecera["Check1", i].Value.ToString() == "Err") contadorErrores++;
                }
                this.txtCabeceraErrores.Text = contadorErrores.ToString();
            }
            catch (SystemException ex)
            {

            }
            finally
            {
                this.Cursor = Cursors.Arrow;
                mostrarImagenEstado();
            }
        }

        DataTable dtDet = new DataTable();
        private void validarDetalle()
        {
            try
            {
                dtDet.Columns.Clear();
                dtDet.Columns.Add();
                dtDet.Clear();

                int n = 0;
                DateTime d;
                double u;

                bool resultadoFila = false;
                bool resultadoRegistroExiste = false;

                int contadorErrores = 0;

                for (int i = 0; i < this.dgvDetalle.RowCount; i++)
                {
                    resultadoFila = true;
                    resultadoFila &= int.TryParse(this.dgvDetalle["PED_numero2", i].Value.ToString(), out n);
                    resultadoFila &= this.dgvDetalle["PRO_codigo", i].Value.ToString().Length == 6;
                    resultadoFila &= this.dgvDetalle["DPE_is_bonificacion", i].Value.ToString().Length == 1;
                    resultadoFila &= this.dgvDetalle["DPE_pro_descripcion", i].Value.ToString().Length > 0;
                    resultadoFila &= int.TryParse(this.dgvDetalle["DPE_cantidad", i].Value.ToString(), out n);
                    resultadoFila &= int.TryParse(this.dgvDetalle["DPE_cantidad_submultiplo", i].Value.ToString(), out n);
                    resultadoFila &= double.TryParse(this.dgvDetalle["DPE_precio_unitario", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvDetalle["DPE_monto_subtotal", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvDetalle["DPE_monto_descuento", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvDetalle["DPE_porcentaje_descuento", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvDetalle["DPE_monto_igv", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvDetalle["DPE_monto_isc", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvDetalle["DPE_porcentaje_isc", i].Value.ToString(), out u);
                    resultadoFila &= double.TryParse(this.dgvDetalle["DPE_monto_total_linea", i].Value.ToString(), out u);

                    resultadoRegistroExiste = false;
                    bool bandera = false;
                    if (resultadoFila)
                    {
                        int PED_numero = Convert.ToInt16(this.dgvDetalle["PED_numero2", i].Value.ToString());
                        bandera = false;

                        for (int t = 0; t < dtCab.Rows.Count; t++)
                        {
                            if (dtCab.Rows[t][0].ToString() == PED_numero.ToString())
                            {
                                bandera |= true;
                                break;
                            }
                        }

                        resultadoRegistroExiste = true;

                        ePEDIDO oePEDIDO = new ePEDIDO();
                        //balPEDIDO obalPEDIDO = new balPEDIDO();
                        ePRODUCTO oePRODUCTO = new ePRODUCTO();
                        //balPRODUCTO obalPRODUCTO = new balPRODUCTO();

                        oePEDIDO.PED_numero = Convert.ToInt32(this.dgvDetalle["PED_numero2", i].Value.ToString());
                        oePRODUCTO.PRO_codigo = this.dgvDetalle["PRO_codigo", i].Value.ToString();

                        resultadoRegistroExiste &= balPEDIDO.obtenerRegistro(oePEDIDO) == null;
                        resultadoRegistroExiste &= balPRODUCTO.obtenerRegistro(oePRODUCTO) != null;
                    }

                    if (resultadoRegistroExiste)
                    {
                        //Carga los PED_numero al datatable dtDet
                        DataRow dr = dtDet.NewRow();
                        dr[0] = this.dgvDetalle["PED_numero2", i].Value.ToString();
                        dtDet.Rows.Add(dr[0]);

                        if (bandera)
                        {
                            this.dgvDetalle["Check2", i].Style.BackColor = Color.LightGreen;
                            this.dgvDetalle["Check2", i].Value = "OK";
                        }
                        else
                        {
                            this.dgvDetalle["Check2", i].Style.BackColor = Color.Orange;
                            this.dgvDetalle["Check2", i].Value = "Err";
                        }
                    }
                    else
                    {
                        this.dgvDetalle["Check2", i].Style.BackColor = Color.Orange;
                        this.dgvDetalle["Check2", i].Value = "Err";
                    }
                    
                    if (this.dgvDetalle["Check2", i].Value.ToString() == "Err") contadorErrores++;
                }
                this.txtDetalleErrores.Text = contadorErrores.ToString();
            }
            catch (SystemException ex)
            {

            }
            finally
            {
                this.Cursor = Cursors.Arrow;
                mostrarImagenEstado();
            }   
        }

        private void cargarDTCab()
        {
            //Carga los PED_numero al datatable dtDet
            dtCab.Clear();
            dtCab.Columns.Clear();
            dtCab.Columns.Add();
            
            for (int i = 0; i < this.dgvCabecera.RowCount; i++)
            {
                DataRow dr = dtCab.NewRow();
                dr[0] = this.dgvCabecera["PED_numero1", i].Value.ToString();
                dtCab.Rows.Add(dr[0]);
            }
            
        }

        private void cargarDTDet()
        {
            //Carga los PED_numero al datatable dtDet
            dtDet.Clear();
            dtDet.Columns.Clear();
            dtDet.Columns.Add();
            
            for (int i = 0; i < this.dgvDetalle.RowCount; i++)
            {
                DataRow dr = dtDet.NewRow();
                dr[0] = this.dgvDetalle["PED_numero2", i].Value.ToString();
                dtDet.Rows.Add(dr[0]);
            }
            
        }

        private void txtCabeceraFilas_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCabeceraFilas.Text.Length > 0)
                txtCabeceraFilas.Text = string.Format("{0:#,##0}", double.Parse(txtCabeceraFilas.Text));
        }

        private void txtDetalleFilas_TextChanged(object sender, EventArgs e)
        {
            if (this.txtDetalleFilas.Text.Length > 0)
                txtDetalleFilas.Text = string.Format("{0:#,##0}", double.Parse(txtDetalleFilas.Text));
        }

        private void txtCabeceraErrores_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCabeceraErrores.Text.Length > 0)
                txtCabeceraErrores.Text = string.Format("{0:#,##0}", double.Parse(txtCabeceraErrores.Text));
        }

        private void txtDetalleErrores_TextChanged(object sender, EventArgs e)
        {
            if (this.txtDetalleErrores.Text.Length > 0)
                txtDetalleErrores.Text = string.Format("{0:#,##0}", double.Parse(txtDetalleErrores.Text));
        }

        private void txtPedidosInsertados_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPedidosInsertados.Text.Length > 0)
                txtPedidosInsertados.Text = string.Format("{0:#,##0}", double.Parse(txtPedidosInsertados.Text));
        }

        private void txtPedidosNoinsertados_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPedidosNoinsertados.Text.Length > 0)
                txtPedidosNoinsertados.Text = string.Format("{0:#,##0}", double.Parse(txtPedidosNoinsertados.Text));
        }

        private void frmOP_ImportarPedidos_Load(object sender, EventArgs e)
        {
            this.btnImportar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("PEDIDO_IMPORTAR"), (SharedData.Instance().Reglas ?? ""));
        }

        private void mostrarImagenEstado()
        {
            int erroresCabecera = string.IsNullOrEmpty(this.txtCabeceraErrores.Text) ? 1 : Convert.ToInt32(this.txtCabeceraErrores.Text.Trim().Replace(",",""));
            int erroresDetalle = string.IsNullOrEmpty(this.txtDetalleErrores.Text) ? 1 : Convert.ToInt32(this.txtDetalleErrores.Text.Trim().Replace(",",""));

            if (erroresCabecera + erroresDetalle == 0)
            {
                this.picEstadoValidacion.Image = img.Images["ok"];
            }
            else
            {
                this.picEstadoValidacion.Image = img.Images["warn"];
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            int contadorIngresos = 0;
            int contadorNoIngresos = 0;

            ePEDIDO oePEDIDO = new ePEDIDO();

            try
            {
                for (int i = 0; i < this.dgvCabecera.RowCount; i++)
                {
                    if (this.dgvCabecera["Check1", i].Value.ToString() == "OK")
                    {
                        if (oePEDIDO == null) oePEDIDO = new ePEDIDO();
                        //balPEDIDO obalPEDIDO = new balPEDIDO();

                        oePEDIDO.PED_numero = Convert.ToInt32(this.dgvCabecera["PED_numero1", i].Value.ToString());
                        oePEDIDO.PED_fecha = Convert.ToDateTime(this.dgvCabecera["PED_fecha", i].Value.ToString());
                        oePEDIDO.PED_fecha_entrega = Convert.ToDateTime(this.dgvCabecera["PED_fecha_entrega", i].Value.ToString());
                        oePEDIDO.VEN_codigo = Convert.ToInt32(this.dgvCabecera["VEN_codigo", i].Value.ToString());
                        oePEDIDO.PED_nombre_vendedor = this.dgvCabecera["PED_nombre_vendedor", i].Value.ToString();
                        oePEDIDO.SOC_codigo = Convert.ToInt32(this.dgvCabecera["SOC_codigo", i].Value.ToString());
                        oePEDIDO.PED_soc_nombre_razon = this.dgvCabecera["PED_soc_nombre_razon", i].Value.ToString();
                        oePEDIDO.PED_soc_direccion = this.dgvCabecera["PED_soc_direccion", i].Value.ToString();
                        oePEDIDO.PED_soc_zona = Convert.ToInt32(this.dgvCabecera["PED_soc_zona", i].Value.ToString());
                        oePEDIDO.PED_subtotal = Convert.ToDouble(this.dgvCabecera["PED_subtotal", i].Value.ToString());                        
                        oePEDIDO.PED_porcentaje_percepcion = Convert.ToDouble(this.dgvCabecera["PED_porcentaje_percepcion", i].Value.ToString());
                        oePEDIDO.PED_monto_igv = Convert.ToDouble(this.dgvCabecera["PED_monto_igv", i].Value.ToString());
                        oePEDIDO.PED_monto_isc = Convert.ToDouble(this.dgvCabecera["PED_monto_isc", i].Value.ToString());
                        oePEDIDO.PED_monto_percepcion = Convert.ToDouble(this.dgvCabecera["PED_monto_percepcion", i].Value.ToString());
                        oePEDIDO.PED_monto_total = Convert.ToDouble(this.dgvCabecera["PED_monto_total", i].Value.ToString());
                        oePEDIDO.PED_comentario = this.dgvCabecera["PED_comentario", i].Value.ToString();
                        oePEDIDO.PED_estado = this.dgvCabecera["PED_estado", i].Value.ToString();
                        oePEDIDO.CPA_codigo = this.dgvCabecera["CPA_codigo", i].Value.ToString();
                        oePEDIDO.PED_tdo_codigo = this.dgvCabecera["PED_tdo_codigo", i].Value.ToString();

                        List<eDETALLE_PEDIDO> List = new List<eDETALLE_PEDIDO>();
                        for (int n = 0; n < this.dgvDetalle.RowCount; n++)
                        {
                            if (Convert.ToInt32(this.dgvDetalle["PED_numero2", n].Value.ToString()) == oePEDIDO.PED_numero)
                            {
                                eDETALLE_PEDIDO oeDETALLE_PEDIDO = new eDETALLE_PEDIDO();
                                oeDETALLE_PEDIDO.PED_numero = Convert.ToInt32(this.dgvDetalle["PED_numero2", n].Value.ToString());
                                oeDETALLE_PEDIDO.PRO_codigo = this.dgvDetalle["PRO_codigo", n].Value.ToString();
                                oeDETALLE_PEDIDO.DPE_is_bonificacion = this.dgvDetalle["DPE_is_bonificacion", n].Value.ToString();
                                oeDETALLE_PEDIDO.DPE_pro_descripcion = this.dgvDetalle["DPE_pro_descripcion", n].Value.ToString();
                                oeDETALLE_PEDIDO.DPE_cantidad = Convert.ToInt32(this.dgvDetalle["DPE_cantidad", n].Value.ToString());
                                oeDETALLE_PEDIDO.DPE_cantidad_submultiplo = Convert.ToInt32(this.dgvDetalle["DPE_cantidad_submultiplo", n].Value.ToString());
                                oeDETALLE_PEDIDO.DPE_precio_unitario = Convert.ToDouble(this.dgvDetalle["DPE_precio_unitario", n].Value.ToString());
                                oeDETALLE_PEDIDO.DPE_monto_subtotal = Convert.ToDouble(this.dgvDetalle["DPE_monto_subtotal", n].Value.ToString());
                                oeDETALLE_PEDIDO.DPE_monto_descuento = Convert.ToDouble(this.dgvDetalle["DPE_monto_descuento", n].Value.ToString());
                                oeDETALLE_PEDIDO.DPE_porcentaje_descuento = Convert.ToDouble(this.dgvDetalle["DPE_porcentaje_descuento", n].Value.ToString());
                                oeDETALLE_PEDIDO.DPE_monto_igv = Convert.ToDouble(this.dgvDetalle["DPE_monto_igv", n].Value.ToString());
                                oeDETALLE_PEDIDO.DPE_monto_isc = Convert.ToDouble(this.dgvDetalle["DPE_monto_isc", n].Value.ToString());
                                oeDETALLE_PEDIDO.DPE_porcentaje_igv = Convert.ToDouble(this.dgvDetalle["DPE_porcentaje_igv", n].Value.ToString());
                                oeDETALLE_PEDIDO.DPE_porcentaje_isc = Convert.ToDouble(this.dgvDetalle["DPE_porcentaje_isc", n].Value.ToString());
                                oeDETALLE_PEDIDO.DPE_monto_total_linea = Convert.ToDouble(this.dgvDetalle["DPE_monto_total_linea", n].Value.ToString());
                                oeDETALLE_PEDIDO.DPE_memo = this.dgvDetalle["DPE_memo", n].Value.ToString();
                                List.Add(oeDETALLE_PEDIDO);
                            }
                        }

                        if (balPEDIDO.insertarRegistroMaestroDetalle(oePEDIDO, List))
                        {
                            contadorIngresos++;
                        }
                        else
                        {
                            contadorNoIngresos++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message);
            }

            MessageBox.Show("Operacion completada, revise los resultados en el panel de resultados.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtPedidosInsertados.Text = contadorIngresos.ToString();
            this.txtPedidosNoinsertados.Text = contadorNoIngresos.ToString();            
        }

        int i = 0;
        private void frmOP_ImportarPedidos_VisibleChanged(object sender, EventArgs e)
        {
            i++;
            if (!balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("PEDIDO_IMPORTACION_VER"), (SharedData.Instance().Reglas ?? "")) && (i == 1))
            {
                this.Close();
                MessageBox.Show("Su usuario no tiene permiso para ver este formulario.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
