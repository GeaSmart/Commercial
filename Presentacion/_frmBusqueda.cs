using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class _frmBusqueda : DevComponents.DotNetBar.Metro.MetroForm
    {
        public string pk = "";
        public string pk_2 = "";

        bool multiplePKs;
        string metodo;
        object instance1;
        object instance2;
                
        public _frmBusqueda(bool multiplePKs, string metodo, object obj1)
        {
            InitializeComponent();

            this.multiplePKs = multiplePKs;
            this.metodo = metodo;
            this.instance1 = obj1;            
        }

        public _frmBusqueda(bool multiplePKs, string metodo, object obj1, object obj2)
        {
            InitializeComponent();

            this.multiplePKs = multiplePKs;
            this.metodo = metodo;
            this.instance1 = obj1;
            this.instance2 = obj2;            
        }

        private void frmOP_Busqueda_Load(object sender, EventArgs e)
        {
            object[] prms;
            if (instance2 == null)
            {
                prms = new object[1];
                prms[0] = this.txtBusqueda.Text;
            }
            else
            {
                prms = new object[2];
                prms[0] = this.txtBusqueda.Text;
                prms[1] = instance2;                
            }

            var method = ((object)instance1).GetType().GetMethod(metodo);
            DataTable dt = (DataTable)method.Invoke(instance1, prms);
            this.dgvData.DataSource = dt;
            this.txtBusqueda.Select();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            object[] prms;
            if (instance2 == null)
            {
                prms = new object[1];
                prms[0] = this.txtBusqueda.Text;
            }
            else
            {
                prms = new object[2];
                prms[0] = this.txtBusqueda.Text;
                prms[1] = instance2;
            }

            var method = ((object)instance1).GetType().GetMethod(metodo);
            DataTable dt = (DataTable)method.Invoke(instance1, prms);
            this.dgvData.DataSource = dt;
            this.txtBusqueda.Select();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dgvData.RowCount > 0)
            {                
                pk = this.dgvData[0, this.dgvData.SelectedRows[0].Index].Value.ToString();

                if (multiplePKs)
                    pk_2 = this.dgvData[1, this.dgvData.SelectedRows[0].Index].Value.ToString();
            }
            else
            {
                this.Close();
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnSeleccionar.PerformClick();
        }

        private void dgvData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnSeleccionar.PerformClick();
            }
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.dgvData.RowCount > 0)
            {
                int nRow = this.dgvData.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Down)
                {
                    if (nRow < this.dgvData.RowCount - 1)
                    {
                        this.dgvData.Rows[nRow].Selected = false;
                        this.dgvData.Rows[++nRow].Selected = true;
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (nRow > 0)
                    {
                        this.dgvData.Rows[nRow].Selected = false;
                        this.dgvData.Rows[--nRow].Selected = true;
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    this.btnSeleccionar.PerformClick();
                }
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.txtBusqueda.Text.Length > 0 && this.dgvData.RowCount > 0)
            {
                this.txtBusqueda.Select();
                this.txtBusqueda.SelectionStart = this.txtBusqueda.Text.Length;
            }
        }

        private void dgvData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.label2.Text = this.dgvData.RowCount.ToString() + " registro(s).";
        }

        private void dgvData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.label2.Text = this.dgvData.RowCount.ToString() + " registro(s).";
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
