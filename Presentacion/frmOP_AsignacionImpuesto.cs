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
    public partial class frmOP_AsignacionImpuesto : _frmBaseTB
    {
        eDETALLE_IMPUESTO _o;
        public frmOP_AsignacionImpuesto(eDETALLE_IMPUESTO o)
        {
            InitializeComponent();
            tabla = "IMPUESTO";

            this._o = o;

            this.cmbImpuesto.ValueMember = "IMP_codigo";
            this.cmbImpuesto.DisplayMember = "IMP_nombre_corto";
            this.cmbImpuesto.DataSource = balIMPUESTO.poblar();
        }
        
        private void cargarDatos()
        {
            if (this.cmbImpuesto.SelectedValue.ToString() == "IGV")
            {
                this.dgvListado.AllowUserToAddRows = false;
            }
            else
            {
                this.dgvListado.AllowUserToAddRows = true;
            }

            eDETALLE_IMPUESTO o = new eDETALLE_IMPUESTO();
            o.IMP_codigo = this.cmbImpuesto.SelectedValue != null ? this.cmbImpuesto.SelectedValue.ToString() : "";
            this.dgvListado.DataSource = balDETALLE_IMPUESTO.obtenerDetallePorImpuesto(o);
        }

        public override void Guardar()
        {
            if (this.cmbImpuesto.SelectedValue != null)
            {
                eDETALLE_IMPUESTO o = new eDETALLE_IMPUESTO();
                o.IMP_codigo = this.cmbImpuesto.SelectedValue.ToString();
                int contadorInsertadosCorrectos = 0;
                int contadorInsertadosIncorrectos = 0;

                double u;
                balDETALLE_IMPUESTO.eliminarGrilla(o);

                foreach (DataGridViewRow row in this.dgvListado.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        o.DIM_porcentaje = row.Cells["DIM_porcentaje"].Value != null ? double.TryParse(row.Cells["DIM_porcentaje"].Value.ToString(), out u) ? Convert.ToDouble(row.Cells["DIM_porcentaje"].Value.ToString()) : -1 : -1;

                        try
                        {
                            if (balDETALLE_IMPUESTO.actualizarFila(o))
                                contadorInsertadosCorrectos++;
                            else contadorInsertadosIncorrectos++;
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
                mensaje("guardar", contadorInsertadosCorrectos, contadorInsertadosIncorrectos);
                cargarDatos();
            }
        }
                
        private void frmOP_AsignacionImpuesto_Load(object sender, EventArgs e)
        {
            if (this._o == null) { }
            else { this.cmbImpuesto.SelectedValue = _o.IMP_codigo; }
        }      

        private void cmbImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cmbImpuesto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnGoImpuesto_Click(object sender, EventArgs e)
        {
            eIMPUESTO o = new eIMPUESTO();
            o.IMP_codigo = this.cmbImpuesto.SelectedValue != null ? this.cmbImpuesto.SelectedValue.ToString() : "";

            frmDM_Impuesto o2 = new frmDM_Impuesto(o);
            o2.MdiParent = this.MdiParent;
            o2.Show();
        }

        private void dgvListado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvListado.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dgvListado.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private int rowIndex = 0;
        private void dgvListado_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                this.dgvListado.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvListado.CurrentCell = this.dgvListado.Rows[e.RowIndex].Cells["DIM_porcentaje"];
                this.menuContextual.Show(this.dgvListado, e.Location);
                menuContextual.Show(Cursor.Position);
            }
        }

        private void eliminarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvListado.Rows[this.rowIndex].IsNewRow)
            {
                this.dgvListado.Rows.RemoveAt(this.rowIndex);
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dgvListado_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        private void dgvListado_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Corrija los caracteres no válidos para continuar.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Refresco de combobox
        private void cmbImpuesto_DropDown(object sender, EventArgs e)
        {
            string valorSeleccionado = "";
            if (this.cmbImpuesto.SelectedValue != null)
            {
                valorSeleccionado = this.cmbImpuesto.SelectedValue.ToString();
            }
            this.cmbImpuesto.DataSource = balIMPUESTO.poblar();
            this.cmbImpuesto.SelectedValue = valorSeleccionado;
        }
    }
}
