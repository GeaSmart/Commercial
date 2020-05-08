using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class _frmPrincipal : DevComponents.DotNetBar.Metro.MetroForm
    {
        public DataTable _dt;
        public _frmPrincipal()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            this.menuStrip1.Enabled = false;
            this.strOperaciones.Enabled = false;
            _frmLogin o = new _frmLogin(this);
            o.MdiParent = this;
            o.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2 - this.Height / 2);
            this._dt = o.data;
        }

        private void _frmPrincipal_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = SystemColors.ControlLight;            
        }
         
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Usuario o = new frmDM_Usuario(null);
            o.MdiParent = this;
            o.Show();
        }
        
        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Socio o = new frmDM_Socio(null);
            o.MdiParent = this;
            o.Show();
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_UnidadMedida o = new frmDM_UnidadMedida(null);
            o.MdiParent = this;
            o.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Marca o = new frmDM_Marca(null);
            o.MdiParent = this;
            o.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Categoria o = new frmDM_Categoria(null);
            o.MdiParent = this;
            o.Show();
        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Linea o = new frmDM_Linea(null);
            o.MdiParent = this;
            o.Show();
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Formato o = new frmDM_Formato(null);
            o.MdiParent = this;
            o.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void asignarListaDePreciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOP_ListaPrecios o = new frmOP_ListaPrecios();
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmDM_Socio o = new frmDM_Socio(null);
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmDM_Producto o = new frmDM_Producto(null);
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmOP_Venta o = new frmOP_Venta(null);
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmOP_ListaPrecios o = new frmOP_ListaPrecios(null);
            o.MdiParent = this;
            o.Show();
        }

        private void bFManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tablaDeBonificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP_Bonificaciones o = new frmOP_Bonificaciones();
            o.MdiParent = this;
            o.Show();
        }

        private void tablaDeDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP_Descuentos o = new frmOP_Descuentos();
            o.MdiParent = this;
            o.Show();
        }

        private void importarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP_ImportarPedidos o = new frmOP_ImportarPedidos();
            o.MdiParent = this;
            o.Show();
        }

        private void programacionDeCargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP_Programacion o = new frmOP_Programacion();
            o.MdiParent = this;
            o.Show();
        }

        private void generaciónDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP_GeneracionDocumentos o = new frmOP_GeneracionDocumentos();
            o.MdiParent = this;
            o.Show();
        }

        private void tipoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_TipoDocumento o = new frmDM_TipoDocumento(null);
            o.MdiParent = this;
            o.Show();
        }

        private void seriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Serie o = new frmDM_Serie(null);
            o.MdiParent = this;
            o.Show();
        }

        private void tipoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_TipoVenta o = new frmDM_TipoVenta(null);
            o.MdiParent = this;
            o.Show();
        }

        private void condicionDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_CondicionPago o = new frmDM_CondicionPago(null);
            o.MdiParent = this;
            o.Show();
        }

        private void zonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Zona o = new frmDM_Zona(null);
            o.MdiParent = this;
            o.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Vehiculo o = new frmDM_Vehiculo(null);
            o.MdiParent = this;
            o.Show();
        }

        private void choferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Chofer o = new frmDM_Chofer(null);
            o.MdiParent = this;
            o.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Vendedor o = new frmDM_Vendedor(null);
            o.MdiParent = this;
            o.Show();
        }

        private void tIPONEGOCIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_TipoNegocio o = new frmDM_TipoNegocio(null);
            o.MdiParent = this;
            o.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Canal o = new frmDM_Canal(null);
            o.MdiParent = this;
            o.Show();
        }

        private void motivosDeDevolcuionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_MotivoDevolucion o = new frmDM_MotivoDevolucion(null);
            o.MdiParent = this;
            o.Show();
        }

        private void lISTADEPRECIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_ListaPrecio o = new frmDM_ListaPrecio(null);
            o.MdiParent = this;
            o.Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Almacen o = new frmDM_Almacen(null);
            o.MdiParent = this;
            o.Show();
        }

        private void listadoDeVisitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP_ListadoVisita o = new frmOP_ListadoVisita();
            o.MdiParent = this;
            o.Show();
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Ruta o = new frmDM_Ruta(null);
            o.MdiParent = this;
            o.Show();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOP_Pedido o = new frmOP_Pedido(null);
            o.MdiParent = this;
            o.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Perfil o = new frmDM_Perfil(null);
            o.MdiParent = this;
            o.Show();
        }

        private void asignacionDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP_AsignacionReglas o = new frmOP_AsignacionReglas();
            o.MdiParent = this;
            o.Show();
        }

        private void reporteDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRPT_Inventario o = new frmRPT_Inventario();
            o.MdiParent = this;
            o.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP_Pago o = new frmOP_Pago();
            o.MdiParent = this;
            o.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP_Compra o = new frmOP_Compra(null);
            o.MdiParent = this;
            o.Show();
        }

        private void notaDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP_NotaCredito o = new frmOP_NotaCredito(null);
            o.MdiParent = this;
            o.Show();
        }

        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Impuesto o = new frmDM_Impuesto(null);
            o.MdiParent = this;
            o.Show();
        }

        private void asignaciónDeImpuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP_AsignacionImpuesto o = new frmOP_AsignacionImpuesto(null);
            o.MdiParent = this;
            o.Show();
        }        
    }
}
