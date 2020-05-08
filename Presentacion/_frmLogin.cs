using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Entidades;
using Negocios;
using System.Diagnostics;

namespace Presentacion
{
    public partial class _frmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        public DataTable data = new DataTable();
        _frmPrincipal _principal;

        _frmSplash sp = new _frmSplash();

        public _frmLogin(_frmPrincipal principal)
        {
            this._principal = principal;
                        
            InitializeComponent();
            
            sp.Show();
            timer1.Start();
        }
        
        private void _frmLogin_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Text = "ADMIN";
            this.txtContrasena.Text = "12345";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            eUSUARIO oeUSUARIO = new eUSUARIO();
            oeUSUARIO.USU_usuario = this.txtUsuario.Text.Trim();
            oeUSUARIO.USU_contrasena = this.txtContrasena.Text.Trim();
            balUSUARIO obalUSUARIO = new balUSUARIO();
            if (this.txtUsuario.Text.Length > 0 && this.txtContrasena.Text.Length > 0)
            {
                DataTable data = balUSUARIO.login(oeUSUARIO);                
                if (data.Rows.Count > 0)
                {
                    this._principal.menuStrip1.Enabled = true;
                    this._principal.strOperaciones.Enabled = true;
                    
                    //variables globales - patron singleton
                    SharedData.Instance().USU_usuario = data.Rows[0]["USU_usuario"].ToString();
                    SharedData.Instance().USU_nombre_completo = data.Rows[0]["USU_nombre_completo"].ToString();
                    SharedData.Instance().Perfil = data.Rows[0]["Perfil"].ToString();
                    SharedData.Instance().Reglas = data.Rows[0]["Reglas"].ToString();//.Split(',');

                    verificarPermisos();

                    this._principal.txtUsuario.Text = SharedData.Instance().USU_nombre_completo;
                    this._principal.txtPerfil.Text = "[" + SharedData.Instance().Perfil + "]";
                    //this.Hide();
                    this.Close();

                    balProgram.sincronizarDescuentosEspeciales();
                    balProgram.sincronizarBonificacionesEspeciales();
                }
                else
                {
                    
                    this.txtMensaje.Text = "El Usuario o la contraseña es incorrecta.";
                    this.txtMensaje.ForeColor = Color.White;
                    this.stsMensaje.BackColor = Color.OrangeRed;
                    this.timMensaje.Stop();
                    this.timMensaje.Start();
                }
            }
            else
            {
                
                this.txtMensaje.Text = "Ingrese todos los campos requeridos.";
                this.txtMensaje.ForeColor = Color.White;
                this.stsMensaje.BackColor = Color.Orange;
                this.timMensaje.Stop();
                this.timMensaje.Start();
            }
        }

        private void verificarPermisos()
        {
            this._principal.toolStripButton1.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("SOCIO_VER"), (SharedData.Instance().Reglas ?? ""));
            this._principal.toolStripButton2.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("PRODUCTO_VER"), (SharedData.Instance().Reglas ?? ""));
            this._principal.toolStripButton3.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("VENTA_VER"), (SharedData.Instance().Reglas ?? ""));
            this._principal.toolStripButton4.Visible = balUSUARIO.TieneRegla(SharedData.Instance().getPermiso("DETALLE_LISTA_PRECIO_VER"), (SharedData.Instance().Reglas ?? ""));
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && this.txtUsuario.Text.Length > 0)
                this.txtContrasena.Select();
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && this.txtContrasena.Text.Length > 0)
            {
                this.btnIngresar.PerformClick();
                this.txtContrasena.Text = String.Empty;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            sp.Close();

            _principal.WindowState = FormWindowState.Maximized;
            _principal.ShowInTaskbar = true;

            this.Show();
            timer1.Stop();
        }

        private void timMensaje_Tick(object sender, EventArgs e)
        {
            this.txtMensaje.Text = "Bienvenido, por favor ingrese sus credenciales";
            this.txtMensaje.ForeColor = Color.DimGray;
            this.stsMensaje.BackColor = Color.LightGreen;
            timMensaje.Stop();
        }
    }
}
