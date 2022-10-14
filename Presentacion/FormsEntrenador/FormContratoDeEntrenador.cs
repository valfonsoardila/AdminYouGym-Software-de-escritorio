using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FormServicioDeEntrenador : Form
    {
        EntrenadorService entrenadorService;
        Entrenador entrenador;
        List<Entrenador> entrenadores;
        public FormServicioDeEntrenador()
        {
            entrenadorService = new EntrenadorService(ConfigConnection.ConnectionString);
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void menuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormServicioDeEntrenador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBuscarIdentificacion_Click(object sender, EventArgs e)
        {
            BusquedaEntrenadorRespuesta respuesta = new BusquedaEntrenadorRespuesta();
            string id = textBuscar.Text;
            if (id != "")
            {
                respuesta = entrenadorService.BuscarPorIdentificacion(id);
                var entrenadores = new List<Entrenador> { respuesta.Entrenador };

                if (respuesta.Entrenador != null)
                {
                    MostrarDatosBuscados(respuesta.Entrenador);
                    panelDatosDeContrato.Enabled = true;
                    panelDatosDeEntrenador.Enabled = true;
                    btnContratar.Enabled = true;
                    btnGenerarContrato.Enabled = true;
                }
                else
                {
                    if (respuesta.Entrenador == null)
                    {
                        MessageBox.Show(respuesta.Mensaje, "Busqueda por identificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                string mensaje = "No se encuentra ningun id que concuerde a este registro";
                MessageBox.Show(mensaje, "Busqueda por identificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void MostrarDatosBuscados(Entrenador respuesta)
        {
            textIdentificacion.Text = respuesta.Identificacion.ToString();
            textNombre.Text = respuesta.Nombres.ToString()+" "+respuesta.Apellidos.ToString();
            textEdad.Text = respuesta.Edad.ToString();
            textSexo.Text = respuesta.Sexo.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnContratar_Click(object sender, EventArgs e)
        {
            BusquedaEntrenadorRespuesta respuesta = new BusquedaEntrenadorRespuesta();
            Entrenador entrenador = MapearContrato(respuesta.Entrenador);
            string mensaje = entrenadorService.Modificar(entrenador);
            MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private Entrenador MapearContrato(Entrenador respuesta)
        {
            entrenador = new Entrenador();
            entrenador.Identificacion = respuesta.Identificacion;
            entrenador.TipoDeIdentificacion = respuesta.TipoDeIdentificacion;
            entrenador.Nombres = respuesta.Nombres;
            entrenador.Apellidos = respuesta.Apellidos;
            entrenador.Edad = respuesta.Edad;
            entrenador.Sexo = respuesta.Sexo;
            entrenador.Direccion = respuesta.Direccion;
            entrenador.CorreoElectronico = respuesta.CorreoElectronico;
            entrenador.CodigoEntrenador = labelCodigoEntrenadorAsignado.Text;
            entrenador.TipoDeContrato = comboTipoContrato.Text;
            entrenador.HorasExtrasDeTrabajo = int.Parse(textCantidadHorasExtras.Text);
            entrenador.DiasDeTrabajo = int.Parse(textCantidadDiasTrabajo.Text);
            entrenador.MesesDeContrato = int.Parse(textCantidadMesesContrato.Text);
            entrenador.PagoDeSalario = int.Parse(textSueldo.Text);
            return entrenador;
        }
    }
}
