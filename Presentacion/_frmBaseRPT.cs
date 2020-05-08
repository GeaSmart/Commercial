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
    public partial class _frmBaseRPT : DevComponents.DotNetBar.Metro.MetroForm
    {
        public string tabla = "";

        public _frmBaseRPT()
        {
            InitializeComponent();
        }

        private void _frmBaseDM_Load(object sender, EventArgs e)
        {
            this.btnExportar.Enabled = true;
            this.btnImprimir.Enabled = true;            

            verificarPermisos();
        }

        private void verificarPermisos()
        {
            //this.btnImprimir.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso(tabla + "_CREAR"), (SharedData.Instance().Reglas ?? ""));
            //this.btnActualizar.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso(tabla + "_MODIFICAR"), (SharedData.Instance().Reglas ?? ""));
            //this.btnAnular.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso(tabla + "_ANULAR"), (SharedData.Instance().Reglas ?? ""));
        }

        public virtual void ExportarExcel() { }
        public virtual void ExportarPDF() { }
        public virtual void Imprimir() { }
        
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        
        int i = 0;
        private void _frmBaseRPT_VisibleChanged(object sender, EventArgs e)
        {            
            i++;
            //MessageBox.Show(i.ToString());
            if (tabla.Length > 0)
            {
                if (!balUSUARIO.TieneRegla(SharedData.Instance().getPermiso((tabla ?? "") + "_VER"), (SharedData.Instance().Reglas ?? "")) && (i == 1))
                {
                    this.Close();
                    MessageBox.Show("Su usuario no tiene permiso para ver este formulario.", "SICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            ExportarPDF();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
    }
}
