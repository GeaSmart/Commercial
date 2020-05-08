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
    public partial class frmOP_Programacion : DevComponents.DotNetBar.Metro.MetroForm
    {        
        private ePROGRAMACION _oePROGRAMACION;

        public frmOP_Programacion()
        {
            InitializeComponent();
        }

        private void frmOP_Programacion_Load(object sender, EventArgs e)
        {
            //this.btnAgregar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("PROGRAMACION_CREAR"), (SharedData.Instance().Reglas ?? ""));
            //this.btnGuardar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("PROGRAMACION_CREAR"), (SharedData.Instance().Reglas ?? ""));
            //this.btnActualizar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("PROGRAMACION_MODIFICAR"), (SharedData.Instance().Reglas ?? ""));
            //this.btnEliminar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("PROGRAMACION_ELIMINAR"), (SharedData.Instance().Reglas ?? ""));

            Ultimo();

            this.btnAgregar.Enabled = true;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _cfgUtil.clearFields(this.gpbInformacion);
            this.picSum.Image = this.imlImagenes.Images["sum"];
            this.picSum2.Image = this.imlImagenes.Images["sum"];

            this.dgvDetalle.Rows.Clear();
            this.cmbEstado.Text = "ABIERTO";

            this.btnAgregar.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.btnActualizar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnPrimero.Enabled = false;
            this.btnAnterior.Enabled = false;
            this.btnSiguiente.Enabled = false;
            this.btnUltimo.Enabled = false;
            this.btnBuscar.Enabled = false;
            this.btnCancelar.Enabled = true;
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            Primero();

            this.btnAgregar.Enabled = true;
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

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Anterior();
            
            this.btnAgregar.Enabled = true;
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Siguiente();
            
            this.btnAgregar.Enabled = true;
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

        private void btnUltimo_Click(object sender, EventArgs e)
        {

            Ultimo();
            this.btnAgregar.Enabled = true;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();

            this.btnAgregar.Enabled = true;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Ultimo();

            this.btnAgregar.Enabled = true;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool rpta = false;
            try
            {
                if (_oePROGRAMACION == null) _oePROGRAMACION = new ePROGRAMACION();
                _oePROGRAMACION.PRG_fecha = Convert.ToDateTime(this.dtpfecha.Value.ToShortDateString());
                _oePROGRAMACION.PRG_comentario = this.txtComentario.Text;
                _oePROGRAMACION.PRG_ultima_mod = DateTime.Now;
                _oePROGRAMACION.PRG_estado = this.cmbEstado.Text.Substring(0, 1);
                
                List<eDETALLE_PROG> List = new List<eDETALLE_PROG>();
                for (int i = 0; i < this.dgvDetalle.RowCount - 1; i++)
                {
                    eDETALLE_PROG o = new eDETALLE_PROG();
                    o.PRG_fecha = Convert.ToDateTime(this.dtpfecha.Value.ToShortDateString());
                    o.CHO_codigo = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["CHO_codigo"].Value ?? string.Empty.ToString().ToUpper().Trim());
                    o.DPR_numero_viaje = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["DPR_numero_viaje"].Value ?? string.Empty.ToString().ToUpper().Trim());
                    o.DPR_zona_desde = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["DPR_zona_desde"].Value ?? string.Empty.ToString().ToUpper().Trim());
                    o.DPR_zona_hasta = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["DPR_zona_hasta"].Value ?? string.Empty.ToString().ToUpper().Trim());
                    o.DPR_peso = Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPR_peso"].Value.ToString());
                    o.DPR_numero_documentos = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["DPR_numero_pedidos"].Value ?? string.Empty.ToString().ToUpper().Trim());
                    o.DPR_cantidad_producto = Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPR_cantidad_producto"].Value.ToString());
                    o.VEH_placa = (this.dgvDetalle.Rows[i].Cells["VEH_placa"].Value ?? string.Empty).ToString().ToUpper().Trim();

                    List.Add(o);
                }
                
                if (balPROGRAMACION.insertarRegistroMaestroDetalle(_oePROGRAMACION, List))
                {
                    MessageBox.Show("El registro fue guardado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rpta = true;
                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\r\n" + ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //return rpta;

            if (rpta)
            {
                this.btnAgregar.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnActualizar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnPrimero.Enabled = true;
                this.btnAnterior.Enabled = true;
                this.btnSiguiente.Enabled = true;
                this.btnUltimo.Enabled = true;
                this.btnBuscar.Enabled = true;
                this.btnCancelar.Enabled = false;

                Ultimo();
            }
            else
            {
                //Ultimo();
            }
        }

        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IndiceFila = this.dgvDetalle.CurrentRow.Index;

            int indiceColumna = this.dgvDetalle.CurrentCell.ColumnIndex;
            string nombreColumna = this.dgvDetalle.Columns[indiceColumna].Name;
            InsertarFilaGrilla(IndiceFila, nombreColumna);
        }

        private void InsertarFilaGrilla(int indiceFila, string nombreColumna)
        {
            if (nombreColumna == "CHO_nombre_completo")
            {
                balCHOFER _obalCHOFER = new balCHOFER();

                _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", _obalCHOFER);
                DialogResult respuesta = ventana.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    eCHOFER oeCHOFER = new eCHOFER();
                    oeCHOFER.CHO_codigo = Convert.ToInt16(ventana.pk);
                    DataTable dt = balCHOFER.obtenerRegistroDetallado(oeCHOFER);

                    if (dt != null)
                    {
                        this.dgvDetalle["CHO_codigo", indiceFila].Value = dt.Rows[0]["CHO_codigo"].ToString();
                        this.dgvDetalle["CHO_nombre_completo", indiceFila].Value = dt.Rows[0]["CHO_nombre_completo"].ToString();
                        this.dgvDetalle["VEH_placa", indiceFila].Value = dt.Rows[0]["VEH_placa"].ToString();
                        this.dgvDetalle["VEH_tonelaje", indiceFila].Value = dt.Rows[0]["VEH_tonelaje"].ToString();
                        calcularNumeroViaje(indiceFila);
                        this.dgvDetalle.NotifyCurrentCellDirty(true);
                        this.dgvDetalle.NotifyCurrentCellDirty(false);                        
                    }
                }                
            }

            if (nombreColumna == "VEH_placa")
            {
                balVEHICULO _obalVEHICULO = new balVEHICULO();

                _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", _obalVEHICULO);
                DialogResult respuesta = ventana.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    eVEHICULO oeVEHICULO = new eVEHICULO();
                    oeVEHICULO.VEH_placa = ventana.pk;
                    DataTable dt = balVEHICULO.obtenerRegistro(oeVEHICULO);

                    if (dt != null)
                    {
                        this.dgvDetalle["VEH_placa", indiceFila].Value = dt.Rows[0]["VEH_placa"].ToString();
                        this.dgvDetalle["VEH_tonelaje", indiceFila].Value = dt.Rows[0]["VEH_tonelaje"].ToString();
                    }
                }
            }

            if (nombreColumna == "DPR_zona_desde")
            {
                balZONA _obalZONA = new balZONA();
                ePROGRAMACION oePROGRAMACION = new ePROGRAMACION();
                oePROGRAMACION.PRG_fecha = Convert.ToDateTime(this.dtpfecha.Value.ToShortDateString());

                _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistroP", _obalZONA, oePROGRAMACION);
                DialogResult respuesta = ventana.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    eZONA oeZONA = new eZONA();
                    oeZONA.ZON_codigo = Convert.ToInt16(ventana.pk);
                    DataTable dt = balZONA.obtenerRegistro(oeZONA);

                    if (dt != null)
                    {
                        this.dgvDetalle["DPR_zona_desde", indiceFila].Value = dt.Rows[0]["ZON_codigo"].ToString();
                    }
                    //
                    if (this.dgvDetalle["DPR_zona_hasta", indiceFila].Value != null)
                    {
                        DataTable dtInfo = new DataTable();
                        DateTime fecha = Convert.ToDateTime(this.dtpfecha.Value.ToShortDateString());
                        int desde = Convert.ToInt16(this.dgvDetalle["DPR_zona_desde", indiceFila].Value.ToString());
                        int hasta = Convert.ToInt16(this.dgvDetalle["DPR_zona_hasta", indiceFila].Value.ToString());
                        dtInfo = CompletarInformacionDirigida(fecha, desde, hasta);

                        this.dgvDetalle["DPR_peso", indiceFila].Value = dtInfo.Rows[0]["PESO"].ToString();
                        this.dgvDetalle["DPR_numero_pedidos", indiceFila].Value = dtInfo.Rows[0]["NDOC"].ToString();
                        this.dgvDetalle["DPR_cantidad_producto", indiceFila].Value = dtInfo.Rows[0]["CANPROD"].ToString();
                    }
                }
            }

            if (nombreColumna == "DPR_zona_hasta")
            {
                balZONA _obalZONA = new balZONA();
                ePROGRAMACION oePROGRAMACION = new ePROGRAMACION();
                oePROGRAMACION.PRG_fecha = Convert.ToDateTime(this.dtpfecha.Value.ToShortDateString());

                _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistroP", _obalZONA, oePROGRAMACION);
                DialogResult respuesta = ventana.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    eZONA oeZONA = new eZONA();
                    oeZONA.ZON_codigo = Convert.ToInt16(ventana.pk);
                    DataTable dt = balZONA.obtenerRegistro(oeZONA);

                    if (dt != null)
                    {
                        this.dgvDetalle["DPR_zona_hasta", indiceFila].Value = dt.Rows[0]["ZON_codigo"].ToString();
                    }
                    //
                    DataTable dtInfo = new DataTable();
                    DateTime fecha = Convert.ToDateTime(this.dtpfecha.Value.ToShortDateString());
                    int desde=Convert.ToInt16(this.dgvDetalle["DPR_zona_desde", indiceFila].Value.ToString());
                    int hasta=Convert.ToInt16(this.dgvDetalle["DPR_zona_hasta", indiceFila].Value.ToString());
                    dtInfo = CompletarInformacionDirigida(fecha, desde, hasta);
                    
                    this.dgvDetalle["DPR_peso", indiceFila].Value = dtInfo.Rows[0]["PESO"].ToString();
                    this.dgvDetalle["DPR_numero_pedidos", indiceFila].Value = dtInfo.Rows[0]["NDOC"].ToString();
                    this.dgvDetalle["DPR_cantidad_producto", indiceFila].Value = dtInfo.Rows[0]["CANPROD"].ToString();
                }
            }
        }

        private void calcularNumeroViaje(int numeroFila)
        {
            string chofer = this.dgvDetalle.Rows[numeroFila].Cells["CHO_codigo"].Value.ToString();

            List<string> pila = new List<string>();
            for (int i = 0; i < this.dgvDetalle.RowCount; i++)
            {
                if (this.dgvDetalle.Rows[i].Cells["CHO_codigo"].Value != null)
                pila.Add(this.dgvDetalle.Rows[i].Cells["CHO_codigo"].Value.ToString());
            }
            pila.Sort();

            int contador = 0;
            foreach (var item in pila.Distinct().ToList())
            {
                contador = 0;
                for (int i = 0; i < this.dgvDetalle.RowCount; i++)
                {
                    if (this.dgvDetalle.Rows[i].Cells["CHO_codigo"].Value != null)
                    {
                        if (item.ToString() == this.dgvDetalle.Rows[i].Cells["CHO_codigo"].Value.ToString())
                        {
                            contador++;
                        }
                    }
                }
                if (chofer == item.ToString())
                {
                    this.dgvDetalle.Rows[numeroFila].Cells["DPR_numero_viaje"].Value = contador;                    
                }                
            }            
        }

        private void calcularSumas()
        {
            double sumaPeso = 0, sumaProductos = 0;
            int sumaPedidos = 0;
            for (int i = 0; i < this.dgvDetalle.RowCount; i++)
            {
                if (this.dgvDetalle.Rows[i].Cells["DPR_peso"].Value != null)
                {
                    sumaPeso += Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPR_peso"].Value.ToString() ?? "0");                    
                }
                if(this.dgvDetalle.Rows[i].Cells["DPR_numero_pedidos"].Value != null)
                {
                    sumaPedidos += Convert.ToInt32(this.dgvDetalle.Rows[i].Cells["DPR_numero_pedidos"].Value.ToString() ?? "0");
                }
                if(this.dgvDetalle.Rows[i].Cells["DPR_cantidad_producto"].Value != null)
                {
                    sumaProductos += Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPR_cantidad_producto"].Value.ToString() ?? "0");
                }
            }
            this.txtSumaPeso.Text = sumaPeso.ToString();
            this.txtSumaPedidos.Text = sumaPedidos.ToString();
            this.txtSumaProductos.Text = sumaProductos.ToString();
        }

        private DataTable CompletarInformacionDirigida(DateTime fecha, int zonadesde, int zonahasta)
        {
            ePROGRAMACION oePROGRAMACION = new ePROGRAMACION();
            oePROGRAMACION.PRG_fecha = fecha;
            eDETALLE_PROG oeDETALLE_PROG = new eDETALLE_PROG();
            oeDETALLE_PROG.DPR_zona_desde = zonadesde;
            oeDETALLE_PROG.DPR_zona_hasta = zonahasta;
            balPROGRAMACION obalPROGRAMACION=new balPROGRAMACION();
            return obalPROGRAMACION.obtenerInformacionDirigida(oePROGRAMACION, oeDETALLE_PROG);
        }

        private void dgvDetalle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            _cfgUtil.enumerarFilasDatagridview(this.dgvDetalle, e);
            calcularSumas();

            eVENTA oeVENTA = new eVENTA();
            oeVENTA.VTA_fecha_contabilizacion = Convert.ToDateTime(this.dtpfecha.Value.ToShortDateString());

            int cantidadDocumentos = Convert.ToInt32(balVENTA.obtenerCantidadDocumentosDia(oeVENTA).Rows[0]["NUMDOC"].ToString());

            if (cantidadDocumentos > 0)
            {
                if (cantidadDocumentos == Convert.ToInt32(this.txtSumaPedidos.Text))
                {
                    this.picEstado.Image = imlImagenes.Images["ok"];
                }
                else
                {
                    this.picEstado.Image = imlImagenes.Images["warn"];
                }
            }
            else
            {
                this.picEstado.Image = null;
            }
        }

        private void txtSumaPeso_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSumaPeso.Text.Length > 0)
                txtSumaPeso.Text = string.Format("{0:#,##0.00}", double.Parse(txtSumaPeso.Text));
        }

        private void txtSumaProductos_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSumaProductos.Text.Length > 0)
                txtSumaProductos.Text = string.Format("{0:#,##0.00}", double.Parse(txtSumaProductos.Text));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea actualizar la información del elemento actual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool rpta = false;
                try
                {
                    if (_oePROGRAMACION == null) _oePROGRAMACION = new ePROGRAMACION();
                    _oePROGRAMACION.PRG_fecha = Convert.ToDateTime(this.dtpfecha.Value.ToShortDateString());
                    _oePROGRAMACION.PRG_comentario = this.txtComentario.Text;
                    _oePROGRAMACION.PRG_ultima_mod = DateTime.Now;
                    _oePROGRAMACION.PRG_estado = this.cmbEstado.Text.Substring(0, 1);

                    List<eDETALLE_PROG> List = new List<eDETALLE_PROG>();
                    for (int i = 0; i < this.dgvDetalle.RowCount - 1; i++)
                    {
                        eDETALLE_PROG o = new eDETALLE_PROG();
                        o.PRG_fecha = Convert.ToDateTime(this.dtpfecha.Value.ToShortDateString());
                        o.CHO_codigo = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["CHO_codigo"].Value ?? string.Empty.ToString().ToUpper().Trim());
                        o.DPR_numero_viaje = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["DPR_numero_viaje"].Value ?? string.Empty.ToString().ToUpper().Trim());
                        o.DPR_zona_desde = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["DPR_zona_desde"].Value ?? string.Empty.ToString().ToUpper().Trim());
                        o.DPR_zona_hasta = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["DPR_zona_hasta"].Value ?? string.Empty.ToString().ToUpper().Trim());
                        o.DPR_peso = Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPR_peso"].Value.ToString());
                        o.DPR_numero_documentos = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["DPR_numero_pedidos"].Value ?? string.Empty.ToString().ToUpper().Trim());
                        o.DPR_cantidad_producto = Convert.ToDouble(this.dgvDetalle.Rows[i].Cells["DPR_cantidad_producto"].Value.ToString());
                        o.VEH_placa = (this.dgvDetalle.Rows[i].Cells["VEH_placa"].Value ?? string.Empty).ToString().ToUpper().Trim();

                        List.Add(o);
                    }

                    if (balPROGRAMACION.actualizarRegistroMaestroDetalle(_oePROGRAMACION, List))
                    {
                        MessageBox.Show("El registro fue actualizado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rpta = true;
                    }
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado:\r\n" + ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (rpta)
                {
                    this.btnAgregar.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    this.btnActualizar.Enabled = true;
                    this.btnEliminar.Enabled = true;
                    this.btnPrimero.Enabled = true;
                    this.btnAnterior.Enabled = true;
                    this.btnSiguiente.Enabled = true;
                    this.btnUltimo.Enabled = true;
                    this.btnBuscar.Enabled = true;
                    this.btnCancelar.Enabled = false;

                    cargarDatos(balPROGRAMACION.obtenerRegistro(_oePROGRAMACION));
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar el elemento actual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool rpta = false;
                try
                {
                    if (_oePROGRAMACION == null) _oePROGRAMACION = new ePROGRAMACION();
                    _oePROGRAMACION.PRG_fecha = Convert.ToDateTime(this.dtpfecha.Value.ToShortDateString());

                    List<eDETALLE_PROG> List = new List<eDETALLE_PROG>();
                    for (int i = 0; i < this.dgvDetalle.RowCount - 1; i++)
                    {
                        eDETALLE_PROG o = new eDETALLE_PROG();
                        o.PRG_fecha = Convert.ToDateTime(this.dtpfecha.Value.ToShortDateString());
                        o.CHO_codigo = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["CHO_codigo"].Value ?? string.Empty.ToString().ToUpper().Trim());
                        o.DPR_numero_viaje = Convert.ToInt16(this.dgvDetalle.Rows[i].Cells["DPR_numero_viaje"].Value ?? string.Empty.ToString().ToUpper().Trim());

                        List.Add(o);
                    }
                    
                    if (balPROGRAMACION.eliminarRegistroMaestroDetalle(_oePROGRAMACION, List))
                    {
                        MessageBox.Show("El registro fue eliminado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rpta = true;
                    }
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado:\r\n" + ex.Message, "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (rpta)
                {
                    this.btnAgregar.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    this.btnActualizar.Enabled = true;
                    this.btnEliminar.Enabled = true;
                    this.btnPrimero.Enabled = true;
                    this.btnAnterior.Enabled = true;
                    this.btnSiguiente.Enabled = true;
                    this.btnUltimo.Enabled = true;
                    this.btnBuscar.Enabled = true;
                    this.btnCancelar.Enabled = false;

                    Ultimo();
                }
            }
        }

        private void cargarDatos(DataTable dt)
        {
            if (dt != null)
            {
                this.dtpfecha.Value = Convert.ToDateTime(dt.Rows[0]["PRG_fecha"].ToString());
                this.txtComentario.Text = dt.Rows[0]["PRG_comentario"].ToString();
                this.txtUltimaModificacion.Text = dt.Rows[0]["PRG_ultima_mod"].ToString();

                switch (dt.Rows[0]["PRG_estado"].ToString())
                {
                    case "A":
                        this.cmbEstado.Text = "ABIERTO";
                        break;
                    case "C":
                        this.cmbEstado.Text = "CERRADO";
                        break;
                }

                this.dgvDetalle.Rows.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.dgvDetalle.Rows.Add();

                    //this.dgvDetalle["PRG_fecha", i].Value = dt.Rows[i]["PRG_fecha"].ToString();
                    this.dgvDetalle["CHO_codigo", i].Value = dt.Rows[i]["CHO_codigo"].ToString();
                    this.dgvDetalle["CHO_nombre_completo", i].Value = dt.Rows[i]["CHO_nombre_completo"].ToString();
                    this.dgvDetalle["DPR_numero_viaje", i].Value = dt.Rows[i]["DPR_numero_viaje"].ToString();

                    this.dgvDetalle["DPR_zona_desde", i].Value = dt.Rows[i]["DPR_zona_desde"].ToString();
                    this.dgvDetalle["DPR_zona_hasta", i].Value = dt.Rows[i]["DPR_zona_hasta"].ToString();
                    this.dgvDetalle["DPR_peso", i].Value = dt.Rows[i]["DPR_peso"].ToString();
                    this.dgvDetalle["DPR_numero_pedidos", i].Value = dt.Rows[i]["DPR_numero_pedidos"].ToString();
                    this.dgvDetalle["DPR_cantidad_producto", i].Value = dt.Rows[i]["DPR_cantidad_producto"].ToString();
                    this.dgvDetalle["VEH_placa", i].Value = dt.Rows[i]["VEH_placa"].ToString();
                }
            }
            else
            {
                //tomado de AGREGAR y LOAD
                _cfgUtil.clearFields(this.gpbInformacion);
                this.picSum.Image = this.imlImagenes.Images["sum"];
                this.picSum2.Image = this.imlImagenes.Images["sum"];

                this.dgvDetalle.Rows.Clear();
                this.cmbEstado.Text = "ABIERTO";

                this.btnAgregar.Enabled = true;
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

        public void Primero()
        {
            cargarDatos(balPROGRAMACION.primerRegistro());
        }

        public void Anterior()
        {
            if (_oePROGRAMACION == null) _oePROGRAMACION = new ePROGRAMACION();
            _oePROGRAMACION.PRG_fecha = Convert.ToDateTime(this.dtpfecha.Value);
            cargarDatos(balPROGRAMACION.anteriorRegistro(_oePROGRAMACION));
        }

        public void Siguiente()
        {
            if (_oePROGRAMACION == null) _oePROGRAMACION = new ePROGRAMACION();
            _oePROGRAMACION.PRG_fecha = Convert.ToDateTime(this.dtpfecha.Value);
            cargarDatos(balPROGRAMACION.siguienteRegistro(_oePROGRAMACION));
        }

        public void Ultimo()
        {
            cargarDatos(balPROGRAMACION.ultimoRegistro());
        }

        public void Buscar()
        {
            balPROGRAMACION _obalPROGRAMACION = new balPROGRAMACION();
            _frmBusqueda ventana = new _frmBusqueda(false, "buscarRegistro", _obalPROGRAMACION);
            DialogResult respuesta = ventana.ShowDialog();
            if (respuesta == DialogResult.OK && ventana.pk.Trim().Length > 0)
            {
                if (_oePROGRAMACION == null) _oePROGRAMACION = new ePROGRAMACION();
                _oePROGRAMACION.PRG_fecha = Convert.ToDateTime(ventana.pk);
                DataTable dt = balPROGRAMACION.obtenerRegistro(_oePROGRAMACION);
                cargarDatos(dt);
            }
        }

    }
}
