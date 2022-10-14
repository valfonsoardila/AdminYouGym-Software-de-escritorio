using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FormRegistrarEntrenador : Form
    {
        Entrenador entrenador;
        List<Entrenador> entrenadores;
        EntrenadorService entrenadorService;
        CajaRegistradoraService cajaRegistradoraService;
        List<CajaRegistradora> cajasRegistradoras;
        CajaRegistradora cajaRegistradora;
        public FormRegistrarEntrenador()
        {
            entrenadorService = new EntrenadorService(ConfigConnection.ConnectionString);
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void menuTop_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelRegistrarCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FormRegistrarEntrenador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void ConsultarListaCliente()
        {
            ConsultaEntrenadorRespuesta respuesta = new ConsultaEntrenadorRespuesta();
            respuesta = entrenadorService.ConsultarTodos();
            entrenadores = respuesta.Entrenadores.ToList();
            if (respuesta.Entrenadores.Count != 0)
            {
                btnModificarEntrenador.Enabled = true;
            }
            else
            {
                if (respuesta.Entrenadores.Count == 0)
                {
                    btnModificarEntrenador.Enabled = false;
                }
            }
        }
        private Entrenador MapearEntrenador()
        {
            entrenador = new Entrenador();
            entrenador.Identificacion = textIdentificacion.Text;
            entrenador.TipoDeIdentificacion = comboTipoId.Text;
            entrenador.Nombres = textNombres.Text;
            entrenador.Apellidos = textApellidos.Text;
            entrenador.FechaDeNacimiento = dateTimeFechaDeNacimiento.Value;
            entrenador.Edad = int.Parse(textEdad.Text);
            entrenador.Sexo = comboSexo.Text;
            entrenador.Direccion = textDireccion.Text;
            entrenador.CorreoElectronico = textCorreo.Text;
            entrenador.CodigoEntrenador = "No definido";
            entrenador.PagoDeSalario = 0;
            entrenador.HorasExtrasDeTrabajo = 0;
            entrenador.DiasDeTrabajo = 0;
            entrenador.MesesDeContrato = 0;
            entrenador.TipoDeContrato = "No definido";
            return entrenador;
        }
        private void LimpiarCampos()
        {
            textIdentificacion.Text = "";
            comboTipoId.Text = "";
            textNombres.Text = "";
            textApellidos.Text = "";
            dateTimeFechaDeNacimiento.Value = DateTime.Now;
            textEdad.Text = "0";
            comboSexo.Text = "";
            textDireccion.Text = "";
            textCorreo.Text = "";
        }
        private void dateTimeFechaDeNacimiento_Validated(object sender, EventArgs e)
        {
            Entrenador entrenador = new Entrenador();
            entrenador.FechaDeNacimiento = dateTimeFechaDeNacimiento.Value;
            entrenador.CalcularEdad();
            textEdad.Text = entrenador.Edad.ToString();
        }
        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            Entrenador entrenador = MapearEntrenador();
            string mensaje = entrenadorService.Guardar(entrenador);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnModificarEntrenador_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Entrenador entrenador = MapearEntrenador();
                string mensaje = entrenadorService.Modificar(entrenador);
                MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }
    }
}
