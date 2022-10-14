using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//se importa la libreria para arrastrar formulario
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FormMenuPrincipal : Form
    {
        int cantidadFormularios = 4;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            Inicializar();
            CerrarMenuBar();
            /*quitar la barra de titulo*/
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        //Boton de control <Minimizar>
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Boton de control <Maximizar>
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        //Boton de control <Restaurar>
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        //Boton de control <Cerrar>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Boton <Abrir el bar de menu>
        private void menuBarAbierto_Click(object sender, EventArgs e)
        {
            if (SideBarWrapper.Width == 40)
            {
                AbrirMenuBar();  
            }
        }
        //Boton <Cerrar el bar de menu>
        private void menuBarCerrado_Click(object sender, EventArgs e)
        {
            if (SideBarWrapper.Width == 219)
            {
                CerrarMenuBar();
            }
        }
        //
        //Boton <Gestion de Cliente>
        private void btnGestionCliente_Click(object sender, EventArgs e)
        {
            menuBarAbierto_Click(sender, e);
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionarCliente>();
        }
        private void iconGestionCliente_Click(object sender, EventArgs e)
        {
            btnGestionCliente_Click(sender,e);
        }
        //
        //Boton <Gestion de Entrenador>
        private void btnGestionEntrenador_Click(object sender, EventArgs e)
        {
            menuBarAbierto_Click(sender, e);
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionarEntrenador>();
        }
        private void iconGestionEntrenador_Click(object sender, EventArgs e)
        {
            btnGestionEntrenador_Click(sender, e);
        }
        //
        //Boton <Gestion de caja>
        private void btnGestionCaja_Click(object sender, EventArgs e)
        {
            menuBarAbierto_Click(sender, e);
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionarCaja>();
        }
        private void iconGestionCaja_Click(object sender, EventArgs e)
        {
            btnGestionCaja_Click(sender,e);
        }
        //
        //Boton <Cerrar sesion>
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            menuBarAbierto_Click(sender, e);
            Application.Exit();
        }
        private void iconCerrarSesion_Click(object sender, EventArgs e)
        {
            btnCerrarSesion_Click(sender, e);
        }
        //
        //Funcion Inicializar
        private void Inicializar()
        {
            AbrirSumadorDelSistema();
            AbrirFormulario<FormGestionarCaja>();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
 
        }
        private void AbrirSumadorDelSistema()
        {
            AbrirFormulario<InicioResumen>();
        }
        //Funcion Abrir el menu bar
        private void AbrirMenuBar()
        {
            btnGestionCliente.Visible = true;
            btnGestionEntrenador.Visible = true;
            btnGestionServicios.Visible = true;
            btnGestionCaja.Visible = true;
            btnCerrarSesion.Visible = true;
            SideBarWrapper.Width = 219;
            menuBar.Width = 216;
            menuBarCerrado.Visible = true;
            menuBarAbierto.Visible = false;
            logoYougymMini.Visible = true;
        }
        //Funcion Cerrar el menu bar
        private void CerrarMenuBar()
        {
            btnGestionCliente.Visible = false;
            btnGestionEntrenador.Visible = false;
            btnGestionServicios.Visible = false;
            btnGestionCaja.Visible = false;
            btnCerrarSesion.Visible = false;
            SideBarWrapper.Width = 40;
            menuBar.Width = 38;
            menuBarCerrado.Visible = false;
            menuBarAbierto.Visible = true;
            logoYougymMini.Visible = false;
        }
        //funcion Abrir Formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedorInterno.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedorInterno.Controls.Add(formulario);
                panelContenedorInterno.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        //Funcion cerrar Formularios
        private void CerrarFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedorInterno.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario != null)
            {
                formulario.Close();
            }
        }
        private void CerrarFormularioSwicth(int FormularioCerrar)
        {
            switch (FormularioCerrar)
            {
                case 1:
                    CerrarFormulario<FormGestionarCliente>();
                    break;
                case 2:
                    CerrarFormulario<FormGestionarEntrenador>();
                    break;
                case 3:
                    CerrarFormulario<FormGestionarPlanEjercicio>();
                    break;
                case 4:
                    CerrarFormulario<FormGestionarCaja>();
                    break;
            }
        }
        //Cerrar los formularios abiertos
        private void CerrarFormulariosCiclo()
        {
            for (int i = 1; i <= cantidadFormularios; i++)
            {
                CerrarFormularioSwicth(i);
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void menuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedorInterno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelInfoLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
