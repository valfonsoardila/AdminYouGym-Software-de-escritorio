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
    public partial class FormGestionarCliente : Form
    {
        ClienteService clienteService;
        List<Cliente> clientes;
        Cliente cliente;
        CajaRegistradoraService cajaRegistradoraService;
        List<CajaRegistradora> cajasRegistradoras;
        CajaRegistradora cajaRegistradora;
        public FormGestionarCliente()
        {
            clienteService = new ClienteService(ConfigConnection.ConnectionString);
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            InitializeComponent();
            Inicializar();
            ActualizarCash();
            ConsultarListaCliente();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Inicializar()
        {
            panelAviso.Visible = false;
            panelAviso.Top = 115;
            panelDatagridClientes.Top = 115;
        }
        private void ConsultarListaCliente()
        {
            if (comboSexo.Text=="Todos")
            {
                ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();
                textTotal.Enabled = true;
                textTotalHombres.Enabled = true;
                textTotalMujeres.Enabled = true;
                DataGridClientes.DataSource = null;
                respuesta = clienteService.ConsultarTodos();
                clientes = respuesta.Clientes.ToList();
                if (respuesta.Clientes.Count != 0)
                {
                    DataGridClientes.DataSource = respuesta.Clientes;
                    Eliminar.Visible = true;
                    textTotal.Text = clienteService.Totalizar().Cuenta.ToString();
                    textTotalHombres.Text = clienteService.TotalizarTipo("M").Cuenta.ToString();
                    textTotalMujeres.Text = clienteService.TotalizarTipo("F").Cuenta.ToString();

                }
                else
                {
                    if (respuesta.Clientes.Count == 0)
                    {
                        MostrarAvisoDatos();
                        Eliminar.Visible = false;
                    }
                }
            }
        }
        private void MostrarAvisoDatos()
        {
            DataGridClientes.DataSource = null;
            panelAviso.Visible = true;
            labelAviso.Text = "No hay datos registrados";
            panelAviso.Top = 115;
            panelDatagridClientes.Top = 151;
        }
        private void EliminarCliente(string id)
        {
            string mensaje = clienteService.Eliminar(id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            FormRegistrarCliente frm = new FormRegistrarCliente();
            frm.ShowDialog();
            ConsultarListaCliente();
            Inicializar();
            ActualizarCash();
        }
        private void ActualizarCash()
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            string estado = "Abierta";
            respuesta = cajaRegistradoraService.BuscarPorEstado(estado);
            if (respuesta.CajaRegistradora != null)
            {
                var cajasRegistradoras = new List<CajaRegistradora> { respuesta.CajaRegistradora };
                labelCash.Text = respuesta.CajaRegistradora.Monto.ToString();
            }
            else
            {
                if (respuesta.CajaRegistradora == null)
                {
                    btnInscribirCliente.Enabled = false;
                    btnModificarCliente.Enabled = false;
                    labelCash.Text = "0";
                }
            }
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            FormRegistrarCliente frm = new FormRegistrarCliente();
            frm.ShowDialog();
            ConsultarListaCliente();
            Inicializar();
        }
        private void btnObtenerProgreso_Click(object sender, EventArgs e)
        {
            FormServicioDeCliente frm = new FormServicioDeCliente();
            frm.ShowDialog();
            Inicializar();
            ConsultarListaCliente();
            Inicializar();
            ActualizarCash();
        }
        private void DataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id;
            if (DataGridClientes.DataSource != null)
            {
                if (DataGridClientes.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    Id = DataGridClientes.CurrentRow.Cells["Identificacion"].Value.ToString();
                    string msg = "Desea eliminar este registro " + Id + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarCliente(Id);
                        ConsultarListaCliente();
                    }
                }
                else
                {
                    if (DataGridClientes.DataSource == null)
                    {
                        string msg = "No hay registros disponibles";
                        MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }   
        }
    }
}
