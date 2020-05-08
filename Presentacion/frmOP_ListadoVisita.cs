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
    public partial class frmOP_ListadoVisita : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmOP_ListadoVisita()
        {
            InitializeComponent();

            this.cmbVendedor.DisplayMember = "VEN_nombre_completo";
            this.cmbVendedor.ValueMember = "VEN_codigo";
            this.cmbVendedor.DataSource = balVENDEDOR.poblar();
        }
        
        private void frmOP_ListadoVisita_Load(object sender, EventArgs e)
        {
            this.btnAgregar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("VISITA_MODIFICAR"), (SharedData.Instance().Reglas ?? ""));
            cargarGrillaVisita();

            // Add the events to listen for
            //dgvListado.CellValueChanged +=
            //     new DataGridViewCellEventHandler(dgvListado_CellValueChanged);
            //dgvListado.CurrentCellDirtyStateChanged +=
            //     new EventHandler(dgvListado_CurrentCellDirtyStateChanged);
        }

        private void cargarComboRuta()
        {
            this.cmbRuta.DisplayMember = "RUT_nombre";
            this.cmbRuta.ValueMember = "RUT_codigo";
            this.cmbRuta.DataSource = balRUTA.poblar();
        }

        private void cargarComboZona()
        {
            int RUT_codigo = Convert.ToInt32(this.cmbRuta.SelectedValue.ToString());
            this.cmbZona.DisplayMember = "ZON_nombre";
            this.cmbZona.ValueMember = "ZON_codigo";
            this.cmbZona.DataSource = balZONA.mostrarNoAsignadas(RUT_codigo);
        }

        private void cargarGrillaVisita()
        {
            int VEN_codigo = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
            string filtro = this.txtFiltrar.Text;
            this.dgvListado.DataSource = balVISITA.listadoVisitasPorVendedor(VEN_codigo, filtro);
        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboRuta();
            cargarGrillaVisita();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //bool rpta = false;
            try
            {
                eVISITA oeVISITA = new eVISITA();
                oeVISITA.ZON_codigo = Convert.ToInt32(this.cmbZona.SelectedValue.ToString());
                oeVISITA.VEN_codigo = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
                oeVISITA.VIS_dia_semana = this.cmbDia.Text;
                oeVISITA.VIS_cantidad_clientes_activos = 0;
                oeVISITA.VIS_estado = "A";

                if (balVISITA.insertarRegistro(oeVISITA))
                {
                    MessageBox.Show("El registro fue guardado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarComboRuta();
                    cargarGrillaVisita();
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
        }
        
        private void dgvListado_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // My combobox column is the second one so I hard coded a 1, flavor to taste
            if (balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("VISITA_MODIFICAR"), (SharedData.Instance().Reglas ?? "")))
            {
                if (dgvListado.RowCount > 0 && e.ColumnIndex == 2)
                {
                    //MessageBox.Show(dgvListado.Rows[e.RowIndex].Cells["VIS_dia_semana"].Value.ToString());
                    try
                    {
                        eVISITA oeVISITA = new eVISITA();
                        oeVISITA.ZON_codigo = Convert.ToInt32(dgvListado.Rows[e.RowIndex].Cells["ZON_codigo"].Value.ToString());
                        oeVISITA.VEN_codigo = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
                        oeVISITA.VIS_dia_semana = dgvListado.Rows[e.RowIndex].Cells["VIS_dia_semana"].Value.ToString();
                        oeVISITA.VIS_cantidad_clientes_activos = 0;
                        oeVISITA.VIS_estado = "A";

                        if (balVISITA.actualizarRegistro(oeVISITA))
                        {
                            MessageBox.Show("El registro fue actualizado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarComboZona();
                            cargarGrillaVisita();
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
                }
            }
        }

        private void dgvListado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvListado.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dgvListado.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            cargarGrillaVisita();
        }

        private int rowIndex = 0;
        private void dgvListado_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                this.dgvListado.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvListado.CurrentCell = this.dgvListado.Rows[e.RowIndex].Cells[1];
                this.menuContextual.Show(this.dgvListado, e.Location);
                menuContextual.Show(Cursor.Position);
            }            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("VISITA_MODIFICAR"), (SharedData.Instance().Reglas ?? "")))
            {
                if (!this.dgvListado.Rows[this.rowIndex].IsNewRow)
                {
                    try
                    {
                        eVISITA oeVISITA = new eVISITA();
                        oeVISITA.ZON_codigo = Convert.ToInt32(dgvListado.Rows[rowIndex].Cells["ZON_codigo"].Value.ToString());
                        oeVISITA.VEN_codigo = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());

                        if (balVISITA.eliminarRegistro(oeVISITA))
                        {
                            MessageBox.Show("El registro fue eliminado correctamente.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarComboZona();
                            cargarGrillaVisita();
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
                }
            }
            else
            {
                MessageBox.Show("Su usuario no tiene permiso para realizar esta operación.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboZona();
        }

        int i = 0;
        private void frmOP_ListadoVisita_VisibleChanged(object sender, EventArgs e)
        {
            i++;
            if (!balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("VISITA_VER"), (SharedData.Instance().Reglas ?? "")) && (i == 1))
            {
                this.Close();
                MessageBox.Show("Su usuario no tiene permiso para ver este formulario.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
        
        private void imprimirGrillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cfgUtil.Imprimir(this.dgvListado, "Listado de visitas", "Vendedor: " + this.cmbVendedor.Text);
        }

        private void btnGoVendedor_Click(object sender, EventArgs e)
        {
            eVENDEDOR o = new eVENDEDOR();
            o.VEN_codigo = this.cmbVendedor.SelectedValue != null ? Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString()) : -1;

            frmDM_Vendedor o2 = new frmDM_Vendedor(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoRuta_Click(object sender, EventArgs e)
        {
            eRUTA o = new eRUTA();
            o.RUT_codigo = this.cmbRuta.SelectedValue != null ? Convert.ToInt32(this.cmbRuta.SelectedValue.ToString()) : -1;

            frmDM_Ruta o2 = new frmDM_Ruta(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void btnGoZona_Click(object sender, EventArgs e)
        {
            eZONA o = new eZONA();
            o.ZON_codigo = this.cmbZona.SelectedValue != null ? Convert.ToInt32(this.cmbZona.SelectedValue.ToString()) : -1;

            frmDM_Zona o2 = new frmDM_Zona(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        //Refresco combobox
        private void cmbVendedor_DropDown(object sender, EventArgs e)
        {
            int valorSeleccionado = -1;
            if (this.cmbVendedor.SelectedValue != null)
            {
                valorSeleccionado = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
            }
            this.cmbVendedor.DataSource = balVENDEDOR.poblar();
            this.cmbVendedor.SelectedValue = valorSeleccionado;            
        }

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

        private void cmbZona_DropDown(object sender, EventArgs e)
        {
            int valorSeleccionado = -1;
            if (this.cmbZona.SelectedValue != null)
            {
                valorSeleccionado = Convert.ToInt32(this.cmbZona.SelectedValue.ToString());
            }
            cargarComboZona();
            this.cmbZona.SelectedValue = valorSeleccionado;            
        }
    }
}
