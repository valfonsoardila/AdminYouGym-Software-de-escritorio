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
using Logica;
using Entidades;

namespace UI
{
    public partial class FormRestaurarContraseña : Form
    {
        public readonly Validaciones validaciones;
        UsuarioService usuarioService;
        List<Usuario> usuarios;
        Usuario usuario;
        string nombreDeUsuario;
        string identificacion;
        string tipoId;
        string nombres;
        string apellidos;
        DateTime fechaDeNacimiento;
        string direccion;
        string sexo;
        string telefono;
        string rol;
        string correo;
        string nombreUsuario;
        string contraseña;
        string codigoUsuario;
        bool UsuarioValido;
        bool identificacionValida;
        public FormRestaurarContraseña()
        {
            usuarioService = new UsuarioService(ConfigConnection.ConnectionString);
            InitializeComponent();
            validaciones = new Validaciones();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormRestaurarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormInicioSesion login = new FormInicioSesion();
            login.Show();
            this.Hide();
        }
        private void MapearDatos()
        {
            nombreDeUsuario = textUsuario.Text;
            identificacion = textIdentificacion.Text;
        }
        private Usuario MapearDatosDeUsuario()
        {
            usuario = new Usuario();
            usuario.Nombres = nombres;
            usuario.Apellidos = apellidos;
            usuario.Rol = rol;
            usuario.CorreoElectronico = correo;
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contraseña = textContraseña.Text;
            usuario.CodigoUsuario = codigoUsuario;
            return usuario;
        }
        private void BuscarPorNombreDeUsuario()
        {
            BusquedaUsuarioRespuesta respuesta = new BusquedaUsuarioRespuesta();
            respuesta = usuarioService.BuscarPorNombreDeUsuario(nombreDeUsuario);
            if (respuesta.Usuario != null)
            {
                var usuario = new List<Usuario> { respuesta.Usuario };
                nombreDeUsuario = respuesta.Usuario.Nombres;
                UsuarioValido = true;
                labelAdvertencia.Visible = false;
                textContraseña.Enabled = true;
            }
            else
            {
                if (respuesta.Usuario == null)
                {
                    labelAdvertencia.Text = "El usuario no existe";
                    labelAdvertencia.Visible = true;
                }
            }
        }
        private void Limpiar()
        {
            textUsuario.Text = "";
            textContraseña.Text = "";
            textIdentificacion.Text = "";
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Usuario usuario = MapearDatosDeUsuario();
            var msg = usuarioService.Modificar(usuario);
            MessageBox.Show(msg, "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MapearDatos();
            if (textUsuario.Text == "")
            {
                labelAdvertencia.Text = "No ha llenado el campo usuario";
                labelAdvertencia.Visible = true;
            }
            else
            {
                if (textIdentificacion.Text == "")
                {
                    labelAdvertencia.Text = "No ha llenado el campo identificacion";
                    labelAdvertencia.Visible = true;
                }
                else
                {
                    BuscarPorNombreDeUsuario();
                    if (UsuarioValido == true)
                    {
                        labelContraseña.Enabled = true;
                        textContraseña.Enabled = true;
                        btnBuscar.Visible = false;
                        btnRestaurar.Visible = true;
                    }
                }
            }
        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "Contraseña")
            {
                textContraseña.Text = "";
                textContraseña.ForeColor = Color.Black;
                textContraseña.UseSystemPasswordChar = true;
            }
        }

        private void textContraseña_Leave(object sender, EventArgs e)
        {
            if (textContraseña.Text == "")
            {
                textContraseña.Text = "Contraseña";
                textContraseña.ForeColor = Color.Gray;
                textContraseña.UseSystemPasswordChar = false;
            }
        }

        private void iconSeePasword_Click(object sender, EventArgs e)
        {
            iconNoSeePasword.Visible = true;
            iconSeePasword.Visible = false;
            textContraseña.UseSystemPasswordChar = true;
        }

        private void iconNoSeePasword_Click(object sender, EventArgs e)
        {
            iconNoSeePasword.Visible = false;
            iconSeePasword.Visible = true;
            textContraseña.UseSystemPasswordChar = false;
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            if (textUsuario.Text != "")
            {
                if (validaciones.ValidacionUsuario(textUsuario.Text) == false)
                {
                    labelAdvertencia.Visible = true;
                    labelAdvertencia.Text = "Formato de usuario incorrecto";
                    textUsuario.ForeColor = Color.Maroon;
                }
                else
                {
                    labelAdvertencia.Visible = false;
                    textUsuario.ForeColor = Color.Black;
                }
            }
        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {
            if (textContraseña.Text != "")
            {
                if (validaciones.ValidacionContrasena(textContraseña.Text) == false)
                {
                    labelAdvertencia.Visible = true;
                    labelAdvertencia.Text = "la contraseña es minimo de 8";
                    textContraseña.ForeColor = Color.Maroon;
                }
                else
                {
                    labelAdvertencia.Visible = false;
                    textContraseña.ForeColor = Color.Black;
                }
            }
        }
    }
}
