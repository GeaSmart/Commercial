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
    public partial class frm_EstablecerFecha : Form
    {
        Point _p;
        string _caller = "";
        public DateTime pk;

        public frm_EstablecerFecha(Point p, string caller)
        {
            InitializeComponent();
            this._p = p;
            this._caller = caller;
        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(this.monFechaVencimiento.SelectionRange.Start.ToString());
            DateTime hora = Convert.ToDateTime("01/01/1990 " + this.nudHora.Value.ToString() + ":00:00");

            DateTime fechafinal = new DateTime(fecha.Year, fecha.Month, fecha.Day, hora.Hour, hora.Minute, 0);

            pk = fechafinal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOP_Descuentos_EstablecerVencimiento_Load(object sender, EventArgs e)
        {
            this.Location = _p;
            switch (_caller)
            {
                case "bonificaciones":
                    this.lblHora.Visible = true;
                    this.nudHora.Visible = true;
                    this.lblFormato.Visible = true;
                    break;
                case "descuento":
                    this.lblHora.Visible = true;
                    this.nudHora.Visible = true;
                    this.lblFormato.Visible = true;
                    break;
                case "compra":
                    this.lblHora.Visible = false;
                    this.nudHora.Visible = false;
                    this.lblFormato.Visible = false;
                    break;
            }
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
