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
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FormServicioDeCliente : Form
    {
        ClienteService clienteService;
        public FormServicioDeCliente()
        {
            clienteService = new ClienteService(ConfigConnection.ConnectionString);
            InitializeComponent();
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
        private void panelRegistrarCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FormRegistrarCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Buscar por identificacion <Buscar>
        private void btnBuscarIdentificacion_Click(object sender, EventArgs e)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            string id = textBuscar.Text;
            if (id != "")
            {
                respuesta = clienteService.BuscarPorIdentificacion(id);
                var clientes = new List<Cliente> { respuesta.Cliente };

                if (respuesta.Cliente != null)
                {
                    ValidarEstadoClientePorImagen(respuesta.Cliente);
                    MostrarDatosBuscados(respuesta.Cliente);
                }
                else
                {
                    if (respuesta.Cliente == null)
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
        //Muestra los datos consultados por identificacion
        private void MostrarDatosBuscados(Cliente respuesta)
        {
            //Mostramos los datos
            textCodigoCliente.Text = respuesta.CodigoCliente;
            textNombres.Text = respuesta.Nombres;
            textApellidos.Text = respuesta.Apellidos;
            textSexo.Text = respuesta.Sexo;
            textClasificacion.Text = respuesta.ClasificacionPorPeso;
            textIndMC.Text = respuesta.IndiceDeMasaCorporal.ToString();
            textIndMO.Text = respuesta.IndiceDeMasaOsea.ToString();
            textIndGM.Text = respuesta.IndiceDeGrasaCorporal.ToString();
            textIndMM.Text = respuesta.IndiceDeMasaMuscular.ToString();
            textIndMR.Text = respuesta.IndiceDeMasaResidual.ToString();
        }
        //Validacion de Estado del Cliente a traves de imagen
        private void ValidarEstadoClientePorImagen(Cliente respuesta)
        {
            if (respuesta.Sexo == "M")
            {
                ValidarPesoMasculino(respuesta);
            }
            if (respuesta.Sexo == "F")
            {
                ValidarPesoFemenino(respuesta);
            }
        }
        private void ValidarPesoMasculino(Cliente respuesta)
        {
            if (respuesta.ClasificacionPorPeso == "Delgadez muy Severa" || respuesta.ClasificacionPorPeso == "Delgadez Severa" || respuesta.ClasificacionPorPeso == "Delgadez")
            {
                pictureBodyTest.Image = Properties.Resources.DelgadoM;
            }
            else
            {
                if (respuesta.ClasificacionPorPeso == "Peso Saludable")
                {
                    pictureBodyTest.Image = Properties.Resources.SaludableM;
                }
                else
                {
                    if (respuesta.ClasificacionPorPeso == "Sobrepeso" || respuesta.ClasificacionPorPeso == "Obesidad Moderada" || respuesta.ClasificacionPorPeso == "Obesidad Severa" || respuesta.ClasificacionPorPeso == "Obesidad Severa")
                    {
                        pictureBodyTest.Image = Properties.Resources.SobrePesoM;
                    }
                }
            }
        }
        private void ValidarPesoFemenino(Cliente respuesta)
        {
            if (respuesta.ClasificacionPorPeso == "Delgadez muy Severa" || respuesta.ClasificacionPorPeso == "Delgadez Severa" || respuesta.ClasificacionPorPeso == "Delgadez")
            {
                pictureBodyTest.Image = Properties.Resources.DelgadaF;
            }
            else
            {
                if (respuesta.ClasificacionPorPeso == "Peso Saludable")
                {
                    pictureBodyTest.Image = Properties.Resources.SaludableF;
                }
                else
                {
                    if (respuesta.ClasificacionPorPeso == "Sobrepeso" || respuesta.ClasificacionPorPeso == "Obesidad Moderada" || respuesta.ClasificacionPorPeso == "Obesidad Severa" || respuesta.ClasificacionPorPeso == "Obesidad Severa")
                    {
                        pictureBodyTest.Image = Properties.Resources.SobrePesoF;
                    }
                }
            }
        }

        private void btnLimpiarConsulta_Click(object sender, EventArgs e)
        {
            pictureBodyTest.Enabled = false;
            textBuscar.Text = "";
            textCodigoCliente.Text = "";
            textNombres.Text = "";
            textApellidos.Text = "";
            textSexo.Text = "";
            textClasificacion.Text = "";
            textIndMC.Text = "";
            textIndMO.Text = "";
            textIndGM.Text = "";
            textIndMM.Text = "";
            textIndMR.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
