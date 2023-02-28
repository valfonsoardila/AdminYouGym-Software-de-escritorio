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

namespace Presentacion
{
    public partial class InicioResumen : Form
    {
        CajaRegistradoraService cajaRegistradoraService;
        ClienteService clienteService;
        EntrenadorService entrenadorService;
        PlanDeEjercicioService planDeEjercicioService;
        List<CajaRegistradora> cajasRegistradoras;

        Papelera papelera = new Papelera();
        PapeleraService papeleraService = new PapeleraService();

        public InicioResumen()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            clienteService = new ClienteService(ConfigConnection.ConnectionString);
            entrenadorService = new EntrenadorService(ConfigConnection.ConnectionString);
            planDeEjercicioService = new PlanDeEjercicioService(ConfigConnection.ConnectionString);
            InitializeComponent();
            MostrarDatos();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        public void ConsultarDatoCaja()
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            string estado = "Abierta";
            respuesta = cajaRegistradoraService.BuscarPorEstado(estado);
            if (respuesta.CajaRegistradora != null)
            {
                var cajasRegistradoras = new List<CajaRegistradora> { respuesta.CajaRegistradora };
                labelCaja.Text ="$" + respuesta.CajaRegistradora.Monto.ToString();
            }
            else
            {
                if (respuesta.CajaRegistradora == null)
                {
                    labelCaja.Text = "$0";
                }
            }
        }
        public void ConsultarDatoCliente()
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();
            respuesta = clienteService.ConsultarTodos();
            if (respuesta.Clientes != null)
            {
                labelClientes.Text= clienteService.Totalizar().Cuenta.ToString();
            }
            else
            {
                if (respuesta.Clientes == null)
                {
                    labelClientes.Text = "0";
                }
            }
        }
        public void ConsultarDatoEntrenador()
        {
            ConsultaEntrenadorRespuesta respuesta = new ConsultaEntrenadorRespuesta();
            respuesta = entrenadorService.ConsultarTodos();
            if (respuesta.Entrenadores != null)
            {
                labelEntrenador.Text= entrenadorService.Totalizar().Cuenta.ToString();
            }
            else
            {
                if (respuesta.Entrenadores == null)
                {
                    labelEntrenador.Text = "0";
                }
            }
        }
        public void ConsultarDatoPlanDeEjercicio()
        {
            ConsultaPlanDeEjercicioRespuesta respuesta = new ConsultaPlanDeEjercicioRespuesta();
            respuesta = planDeEjercicioService.ConsultarTodos();
            if (respuesta.PlanesDeEjercicios != null)
            {
                labelServicios.Text= planDeEjercicioService.Totalizar().Cuenta.ToString();
            }
            else
            {
                if (respuesta.PlanesDeEjercicios == null)
                {
                    labelServicios.Text = "0";
                }
            }
        }
        public void MostrarDatos()
        {
            ConsultarDatoCaja();
            ConsultarDatoCliente();
            ConsultarDatoEntrenador();
            ConsultarDatoPlanDeEjercicio();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            labelRefresh.Visible = true;
            labelPapelera.Visible = false;
        }
        private void iconPapelera_MouseHover(object sender, EventArgs e)
        {
            labelPapelera.Visible = true;
            labelRefresh.Visible = false;
        }
        private void ConsultarPapelera()
        {
            PapeleraConsultaResponse papeleraConsultaResponse = papeleraService.Consultar();
            if (papeleraConsultaResponse.Papeleras.Count > 0)
            {
                FormPapelera frm = new FormPapelera();
                frm.ShowDialog();
            }
            else
            {
                if (papeleraConsultaResponse.Papeleras.Count == 0)
                {
                    string mensaje = "No hay cajas en papelera disponibles";
                    MessageBox.Show(mensaje);
                }
            }
        }
        private void iconPapelera_Click(object sender, EventArgs e)
        {
            ConsultarPapelera();
        }
    }
}
