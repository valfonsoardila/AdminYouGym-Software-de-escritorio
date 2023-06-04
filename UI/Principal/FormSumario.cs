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

namespace UI
{
    public partial class FormSumario : Form
    {
        CajaRegistradoraService cajaRegistradoraService;
        PlanDeEjercicioService planDeEjercicioService;
        ProductoService productoService;
        AdministradorService administradorService;
        MembresiaService membresiaService;
        EmpleadoService empleadoService;
        EntrenadorService entrenadorService;

        public FormSumario()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            planDeEjercicioService = new PlanDeEjercicioService(ConfigConnection.ConnectionString);
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            membresiaService = new MembresiaService(ConfigConnection.ConnectionString);
            entrenadorService = new EntrenadorService(ConfigConnection.ConnectionString);
            InitializeComponent();
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            CargarDatoCaja();
            CargarDatoPlanEjercicio();
            CargarDatoProducto();
            CargarDatoMiembros();
            CargarDatoEntrenador();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void FormSumario_Load(object sender, EventArgs e)
        {
            Reloj.Interval = 1000; // Intervalo de 1 segundo
            Reloj.Start();
        }
        private void CargarDatoCaja()
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            respuesta = cajaRegistradoraService.BuscarPorEstado("Abierta");
            var cajaBuscada = respuesta.CajaRegistradora;
            if (cajaBuscada!=null)
            {
                labelCaja.Text= cajaBuscada.VentaDelDia.ToString();
            }
            else
            {
                labelCaja.Text = "0";
            }
        }
        private void CargarDatoPlanEjercicio()
        {
            ConsultaPlanDeEjercicioRespuesta respuesta = new ConsultaPlanDeEjercicioRespuesta();
            respuesta = planDeEjercicioService.ConsultarTodos();
            var planesBuscados = respuesta.PlanesDeEjercicios.ToList();
            if (planesBuscados.Count > 0)
            {
                labelPlanes.Text= planesBuscados.Count.ToString();
            }
            else
            {
                labelPlanes.Text = "0";
            }
        }
        private void CargarDatoProducto()
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            respuesta = productoService.ConsultarTodos();
            var productosBuscados = respuesta.Productos.ToList();
            if (productosBuscados.Count > 0)
            {
                labelProductos.Text= productosBuscados.Count.ToString();
            }
            else
            {
                labelProductos.Text = "0";
            }
        }
        private void CargarDatoMiembros()
        {
            ConsultaMembresiaRespuesta respuesta = new ConsultaMembresiaRespuesta();
            respuesta = membresiaService.ConsultarTodos();
            var miembrosBuscados = respuesta.Membresias.ToList();
            if (miembrosBuscados.Count > 0)
            {
                labelMiembros.Text = miembrosBuscados.Count.ToString();
            }
            else
            {
                labelMiembros.Text = "0";
            }
        }
        private void CargarDatoEntrenador()
        {
            ConsultaEntrenadorRespuesta respuesta = new ConsultaEntrenadorRespuesta();
            respuesta = entrenadorService.ConsultarTodos();
            var entrenadoresBuscados = respuesta.Entrenadores.ToList();
            if (entrenadoresBuscados.Count > 0)
            {
                labelEntrenadores.Text = entrenadoresBuscados.Count.ToString();
            }
            else
            {
                labelEntrenadores.Text = "0";
            }
        }
    }
}
