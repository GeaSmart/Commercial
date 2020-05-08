using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class _frmExportar : DevComponents.DotNetBar.Metro.MetroForm
    {
        DataTable _dt;

        public _frmExportar(DataTable dt)
        {
            InitializeComponent();
            this._dt = dt;
        }

        private void _frmExportar_Load(object sender, EventArgs e)
        {
            this.dgvExportar.DataSource = _dt;

            _cfgUtil.SetDoubleBuffered(this.dgvExportar);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            _cfgUtil.exportarExcel(this.dgvExportar, "Archivo");
        }
    }
}
