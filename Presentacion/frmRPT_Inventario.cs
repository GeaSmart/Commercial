using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class frmRPT_Inventario : _frmBaseRPT
    {
        public frmRPT_Inventario()
        {
            InitializeComponent();
        }

        public frmRPT_Inventario(string filtro)
        {
            InitializeComponent();
            this.txtFiltrar.Text = filtro;
        }

        private void frmRPT_Inventario_Load(object sender, EventArgs e)
        {
            this.dgvStocks.DataSource = balSTOCK.obtenerInventario(this.txtFiltrar.Text);

            //this.dgvStocks.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.;
            this.dgvStocks.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //this.dgvStocks.Columns["Codigo"].ty
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            //this.dgvStocks.DataSource = null;

            DataTable dtt = new DataTable();
            dtt.Columns.Add("Codigo");
            dtt.Columns.Add("Producto");

            this.dgvStocks.DataSource = dtt;

            this.dgvStocks.DataSource = balSTOCK.obtenerInventario(this.txtFiltrar.Text);

            dtt = null;
        }

        public override void ExportarExcel()
        {
            _cfgUtil.exportarExcel(this.dgvStocks, "Inventario de stocks");
        }

        public override void ExportarPDF()
        {
            _cfgUtil.ExportarPdf(this.dgvStocks, "Inventario de stocks", "");
        }

        private void dgvStocks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //this.dgvStocks.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvStocks.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            double sumGeneral = 0;
            foreach (DataGridViewColumn col in this.dgvStocks.Columns)
            {
                string nomCol = this.dgvStocks.Columns[col.Index].Name;
                this.dgvStocks.Columns[col.Index].HeaderText = nomCol;

                double sum = 0;
                double u = 0;
                bool isAplicable = true;

                for (int i = 0; i < this.dgvStocks.RowCount; i++)
                {
                    if (double.TryParse(this.dgvStocks[col.Index, i].Value.ToString(), out u))
                    {
                        sum += Convert.ToDouble(this.dgvStocks[col.Index, i].Value.ToString());
                        dgvStocks.Columns[col.Index].HeaderCell.Style.Font = new Font("Tahoma", 8.75F, FontStyle.Bold);
                        //this.dgvStocks.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                    else
                    {
                        isAplicable = false;
                    }
                }
                sumGeneral += sum;
                if (isAplicable && this.dgvStocks.RowCount > 0)
                    this.dgvStocks.Columns[col.Index].HeaderText = nomCol + "\r\n" + string.Format("{0:n}", sum);
            }
            this.txtSumaGeneral.Text = string.Format("{0:n}", sumGeneral);

            if (this.dgvStocks.RowCount > 0)
            {
                this.lblNumeroFilas.Text = this.dgvStocks.RowCount.ToString() + " registro(s).";
            }
            else
            {
                this.lblNumeroFilas.Text = "No existen registros";
            }
        }

        private void dgvStocks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            _cfgUtil.enumerarFilasDatagridview(this.dgvStocks, e);
        }

        string nomCol = "";
        DataTable dt = null;
        private void dgvStocks_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 2)
            {
                nomCol = this.dgvStocks.Columns[e.ColumnIndex].Name;
                this.menuContextual.Show(this.dgvStocks, e.Location);
                menuContextual.Show(Cursor.Position);
            }
        }

        private void ocultarColumnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                dt = balSTOCK.obtenerInventario(this.txtFiltrar.Text);
            }
            dt.Columns.Remove(nomCol);
            this.dgvStocks.DataSource = dt;
        }

        public override void Imprimir()
        {
            _cfgUtil.Imprimir(this.dgvStocks, "Inventario de stocks","");
        }

        private void dgvStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvStocks.Columns["Codigo"].Index)
            {
                int columna_codigo = this.dgvStocks.Columns["Codigo"].Index;
                string codigo = this.dgvStocks[columna_codigo, e.RowIndex].Value.ToString();
                ePRODUCTO o = new ePRODUCTO();
                o.PRO_codigo = codigo.Length > 0 ? codigo : "";

                frmDM_Producto o2 = new frmDM_Producto(o);
                o2.MdiParent = this.MdiParent;
                o2.Show();
            }
        }
    }
}
