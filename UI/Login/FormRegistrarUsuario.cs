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
using UI.Properties;
using System.Windows.Interop;
using System.Drawing.Drawing2D;

namespace UI
{
    public partial class FormRegistrarUsuario : Form
    {
        public readonly Validaciones validaciones;
        UsuarioService usuarioService;
        EmpleadoService empleadoService;
        AdministradorService administradorService;
        List<Usuario> usuarios;
        Usuario usuario;
        Administrador administrador;
        Empleado empleado;
        string nombreDeUsuario;
        bool rolExistenteValidado;
        bool programadorExistenteValido;
        public FormRegistrarUsuario()
        {
            usuarioService = new UsuarioService(ConfigConnection.ConnectionString);
            administradorService = new AdministradorService(ConfigConnection.ConnectionString);
            empleadoService = new EmpleadoService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ImagenCircular();
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormRegistrarUsuario_MouseDown(object sender, MouseEventArgs e)
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
        private void ImagenCircular()
        {
            SetCircularPictureBox(picturePerfil);
        }
        private void SetCircularPictureBox(PictureBox pictureBox)
        {
            // Crear un objeto de región circular
            GraphicsPath circularPath = new GraphicsPath();
            circularPath.AddEllipse(0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
            Region circularRegion = new Region(circularPath);

            // Establecer la región circular al PictureBox
            pictureBox.Region = circularRegion;

            // Suscribirse al evento Paint del PictureBox
            pictureBox.Paint += picturePerfil_Paint;
        }
        private void BuscarPorRol()
        {
            //BusquedaUsuarioRespuesta respuesta = new BusquedaUsuarioRespuesta();
            //respuesta = usuarioService.BuscarPorNombreDeUsuario(programador);
            //if (respuesta.Usuario != null)
            //{
            //    var usuario = new List<Usuario> { respuesta.Usuario };
            //    rolExistenteValidado = true;
            //    programadorExistenteValido = true;
            //    labelAdvertencia.Text = "No puede registrarse como programador";
            //    labelAdvertencia.Visible = true;
            //}
            //else
            //{
            //    if (respuesta.Usuario == null)
            //    {
            //        rolExistenteValidado = false;
            //        labelAdvertencia.Visible = false;
            //    }
            //}
            string rol = comboRol.Text;
            ConsultaUsuarioRespuesta respuesta = new ConsultaUsuarioRespuesta();
            respuesta = usuarioService.BuscarPorRol(rol);
            usuarios = respuesta.Usuarios.ToList();
            if (respuesta.Usuarios != null && respuesta.Usuarios.Count != 0)
            {
                int rolProgramador = usuarioService.Totalizar().Cuenta;
                if (rol == "Programador" && rolProgramador > 1)
                {
                    rolExistenteValidado = true;
                    programadorExistenteValido = true;
                    labelAdvertencia.Text = "No puede registrarse como programador";
                    labelAdvertencia.Visible = true;
                }
            }
            else
            {
                if (respuesta.Usuarios == null || respuesta.Usuarios.Count == 0)
                {
                    programadorExistenteValido = false;
                    rolExistenteValidado = false;
                    labelAdvertencia.Visible = false;
                }
            }
        }
        private void BuscarPorNombreDeUsuario()
        {
            nombreDeUsuario = textUsuario.Text;
            BusquedaUsuarioRespuesta respuesta = new BusquedaUsuarioRespuesta();
            respuesta = usuarioService.BuscarPorNombreDeUsuario(nombreDeUsuario);
            if (respuesta.Usuario != null)
            {
                var usuario = new List<Usuario> { respuesta.Usuario };
                rolExistenteValidado = true;
                programadorExistenteValido = true;
                labelAdvertencia.Text = "El rol de administrador ya esta registrado";
                labelAdvertencia.Visible = true;
            }
            else
            {
                if (respuesta.Usuario == null)
                {
                    rolExistenteValidado = false;
                    labelAdvertencia.Visible = false;
                }
            }
        }
        private Usuario MapearUsuario()
        {
            usuario = new Usuario();
            usuario.Nombres = textNombre.Text;
            usuario.Apellidos = textApellido.Text;
            usuario.Rol = comboRol.Text;
            usuario.CorreoElectronico = textCorreo.Text;
            usuario.NombreUsuario = textUsuario.Text;
            usuario.Contraseña = textContraseña.Text;
            using (MemoryStream ms = new MemoryStream())
            {
                picturePerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                usuario.ImagenPerfil = ms.ToArray();
            }
            return usuario;
        }
        private Empleado MapearEmpleado()
        {
            empleado = new Empleado();
            empleado.Nombres = textNombre.Text;
            empleado.Apellidos = textApellido.Text;
            empleado.Identificacion = textIdentificacion.Text;
            empleado.TipoDeIdentificacion = comboTipoDeId.Text;
            empleado.FechaDeNacimiento = DateTime.Parse(dateTimeFechaDeNacimiento.Text);
            empleado.Sexo = comboSexo.Text;
            empleado.Direccion = textDireccion.Text;
            empleado.Telefono = textTelefono.Text;
            empleado.Rol = comboRol.Text;
            empleado.CorreoElectronico = textCorreo.Text;
            using (MemoryStream ms = new MemoryStream())
            {
                picturePerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                empleado.ImagenPerfil = ms.ToArray();
            }
            return empleado;
        }
        private Administrador MapearAdministrador()
        {
            administrador = new Administrador();
            administrador.Nombres = textNombre.Text;
            administrador.Apellidos = textApellido.Text;
            administrador.Identificacion = textIdentificacion.Text;
            administrador.TipoDeIdentificacion = comboTipoDeId.Text;
            administrador.FechaDeNacimiento = DateTime.Parse(dateTimeFechaDeNacimiento.Text);
            administrador.Sexo = comboSexo.Text;
            administrador.Direccion = textDireccion.Text;
            administrador.Telefono = textTelefono.Text;
            administrador.Rol = comboRol.Text;
            administrador.CorreoElectronico = textCorreo.Text;
            using (MemoryStream ms = new MemoryStream())
            {
                picturePerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                administrador.ImagenPerfil = ms.ToArray();
            }
            return administrador;
        }
        private void Limpiar()
        {
            textCorreo.Text = "";
            textUsuario.Text = "";
            textContraseña.Text = "";
            textIdentificacion.Text = "";
            comboTipoDeId.Text = "CC";
            comboRol.Text = "Administrador";
            textNombre.Text = "";
            textApellido.Text = "";
            dateTimeFechaDeNacimiento.Value = DateTime.Now;
            comboSexo.Text = "M";
            textDireccion.Text = "";
            textTelefono.Text = "";
            picturePerfil.Image = Resources.User;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var mesg = "";
            BuscarPorRol();
            BuscarPorNombreDeUsuario();
            if (programadorExistenteValido != true)
            {
                if (rolExistenteValidado != true)
                {
                    if (comboRol.Text == "Administrador")
                    {
                        Administrador administrador = MapearAdministrador();
                        mesg = administradorService.Guardar(administrador);
                        MessageBox.Show(mesg, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CrearSesionUsuario();
                        Limpiar();
                    }
                    else
                    {
                        if (comboRol.Text == "Empleado")
                        {
                            Empleado empleado = MapearEmpleado();
                            mesg = empleadoService.Guardar(empleado);
                            MessageBox.Show(mesg, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CrearSesionUsuario();
                            Limpiar();
                        }
                        else
                        {
                            CrearSesionUsuario();
                            Limpiar();
                        }
                    }
                }
                else
                {
                    string msg = "Formato del combo de roles incorrecto";
                    MessageBox.Show(msg, "Combo Roles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string msg = "Formato del combo de roles incorrecto";
                MessageBox.Show(msg, "Combo Roles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CrearSesionUsuario()
        {
            Usuario usuario = MapearUsuario();
            usuarioService.Guardar(usuario);
            //MessageBox.Show(mesg, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }
        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "Mayor a 6 caracteres")
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
                textContraseña.Text = "Mayor a 6 caracteres";
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

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "@Bryan10")
            {
                textUsuario.Text = "";
                textUsuario.ForeColor = Color.Black;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                textUsuario.Text = "@Bryan10";
                textUsuario.ForeColor = Color.Gray;
            }
        }

        private void textCorreo_Enter(object sender, EventArgs e)
        {
            if (textCorreo.Text == "@gmail.com")
            {
                textCorreo.Text = "";
                textCorreo.ForeColor = Color.Black;
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (textCorreo.Text == "")
            {
                textCorreo.Text = "@gmail.com";
                textCorreo.ForeColor = Color.Gray;
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventanaCargar = new OpenFileDialog();
            DialogResult dr = ventanaCargar.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (validaciones.ValidarImagen(ventanaCargar.FileName) == true)
                {
                    // La imagen cargada en picturePerfil es válida
                    picturePerfil.Image = Image.FromFile(ventanaCargar.FileName);
                    ImagenCircular();
                }
                else
                {
                    labelAdvertencia.Visible = true;
                    labelAdvertencia.Text = "Formato de imagen incorrecta";
                }
            }
        }

        private void picturePerfil_Paint(object sender, PaintEventArgs e)
        {
            // Dibujar el borde circular en el PictureBox
            PictureBox pictureBox = (PictureBox)sender;
            using (Pen pen = new Pen(Color.White, 2))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
            }
        }

        private void textCorreo_TextChanged(object sender, EventArgs e)
        {
            if (textCorreo.Text != "" && textCorreo.Text != "@gmail.com")
            {
                if (validaciones.ValidacionEmail(textCorreo.Text) == false)
                {
                    labelAdvertencia.Visible = true;
                    labelAdvertencia.Text = "Correo Invalido";
                    textCorreo.ForeColor = Color.Maroon;
                }
                else
                {
                    labelAdvertencia.Visible = false;
                    textCorreo.ForeColor = Color.Black;
                }
            }
        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
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

        private void textIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar la pulsación del carácter
            }
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar la pulsación del carácter
            }
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es una letra o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Cancelar la pulsación del carácter
            }
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es una letra o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Cancelar la pulsación del carácter
            }
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            if (textUsuario.Text != "")
            {
                if (validaciones.ValidacionUsuario(textUsuario.Text) == false)
                {
                    labelAdvertencia.Visible = true;
                    labelAdvertencia.Text = "formato de usuario incorrecto";
                    textContraseña.ForeColor = Color.Maroon;
                }
                else
                {
                    labelAdvertencia.Visible = true;
                    textContraseña.ForeColor = Color.Black;
                }
            }
        }
    }
}
