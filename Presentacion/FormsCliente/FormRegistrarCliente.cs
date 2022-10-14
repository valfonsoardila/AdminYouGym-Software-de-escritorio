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
    public partial class FormRegistrarCliente : Form
    {
        Cliente cliente;
        List<Cliente> clientes;
        ClienteService clienteService;
        CajaRegistradoraService cajaRegistradoraService;
        List<CajaRegistradora> cajasRegistradoras;
        CajaRegistradora cajaRegistradora;
        int valorInscripcion = 30000;
        public FormRegistrarCliente()
        {
            clienteService = new ClienteService(ConfigConnection.ConnectionString);
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarListaCliente();
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
        private void ConsultarListaCliente()
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();
            respuesta = clienteService.ConsultarTodos();
            clientes = respuesta.Clientes.ToList();
            if (respuesta.Clientes.Count != 0)
            {
                btnModificarCliente.Enabled = true;
            }
            else
            {
                if (respuesta.Clientes.Count == 0)
                {
                    btnModificarCliente.Enabled = false;
                }
            }
        }
        private Cliente MapearCliente()
        {
            cliente = new Cliente();
            cliente.Identificacion = textIdentificacion.Text;
            cliente.TipoDeIdentificacion = comboTipoId.Text;
            cliente.Nombres = textNombres.Text;
            cliente.Apellidos = textApellidos.Text;
            cliente.FechaDeNacimiento = dateTimeFechaDeNacimiento.Value;
            cliente.Edad = int.Parse(textEdad.Text);
            cliente.Sexo = comboSexo.Text;
            cliente.Direccion = textDireccion.Text;
            cliente.Telefono = textTelefono.Text;
            cliente.CorreoElectronico = textCorreo.Text;
            cliente.Peso = double.Parse(textPeso.Text);
            cliente.Altura = double.Parse(textEstatura.Text);
            cliente.GenerarCodigoCliente();
            cliente.ObtenerIndiceMasaCorporal();
            cliente.ObtenerIndiceMasaOsea();
            cliente.ObtenerIndiceGrasaMuscular();
            cliente.ObtenerIndiceMasaMuscular();
            cliente.ObtenerIndiceMasaResidual();
            return cliente;
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
            textTelefono.Text = "";
            textCorreo.Text = "";
            textPeso.Text = "0";
            textEstatura.Text = "0";
        }
        private void dateTimeFechaDeNacimiento_Validated(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.FechaDeNacimiento = dateTimeFechaDeNacimiento.Value;
            cliente.CalcularEdad();
            textEdad.Text = cliente.Edad.ToString();
        }
        private void SumarInscripcionCliente()
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            string estado = "Abierta";
            respuesta = cajaRegistradoraService.BuscarPorEstado(estado);
            if (respuesta.CajaRegistradora != null)
            {
                CajaRegistradora cajaRegistradora = new CajaRegistradora();
                var cajasRegistradoras = new List<CajaRegistradora> { respuesta.CajaRegistradora };
                cajaRegistradora.IdCaja = respuesta.CajaRegistradora.IdCaja;
                cajaRegistradora.FechaDeApertura = respuesta.CajaRegistradora.FechaDeApertura;
                cajaRegistradora.FechaDeCierre = respuesta.CajaRegistradora.FechaDeCierre;
                cajaRegistradora.Estado = respuesta.CajaRegistradora.Estado;
                cajaRegistradora.Monto = (respuesta.CajaRegistradora.Monto)+(valorInscripcion);
                cajaRegistradoraService.ModificarCash(cajaRegistradora);
            }
        }
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearCliente();
            string mensaje = clienteService.Guardar(cliente);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            SumarInscripcionCliente();
            this.Close();
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Cliente cliente = MapearCliente();
                string mensaje = clienteService.Modificar(cliente);
                MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }
    }
}
