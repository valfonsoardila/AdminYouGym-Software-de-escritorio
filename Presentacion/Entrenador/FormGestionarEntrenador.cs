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
    public partial class FormGestionarEntrenador : Form
    {
        EntrenadorService entrenadorService;
        List<Entrenador> entrenadores;
        Entrenador entrenador;
        CajaRegistradoraService cajaRegistradoraService;
        List<CajaRegistradora> cajasRegistradoras;
        CajaRegistradora cajaRegistradora;
        public FormGestionarEntrenador()
        {
            entrenadorService = new EntrenadorService(ConfigConnection.ConnectionString);
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            InitializeComponent();
            Inicializar();
            ConsultarListaEntrenadores();
            ActualizarCash();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Inicializar()
        {
            panelAviso.Visible = false;
            panelAviso.Top = 115;
            panelDatagridEntrenadores.Top = 115;
        }
        private void ConsultarListaEntrenadores()
        {
            if (comboSexo.Text == "Todos")
            {
                ConsultaEntrenadorRespuesta respuesta = new ConsultaEntrenadorRespuesta();
                textTotal.Enabled = true;
                textTotalHombres.Enabled = true;
                textTotalMujeres.Enabled = true;
                DataGridEntrenadores.DataSource = null;
                respuesta = entrenadorService.ConsultarTodos();
                entrenadores = respuesta.Entrenadores.ToList();
                if (respuesta.Entrenadores.Count != 0)
                {
                    DataGridEntrenadores.DataSource = respuesta.Entrenadores;
                    Eliminar.Visible = true;
                    textTotal.Text = entrenadorService.Totalizar().Cuenta.ToString();
                    textTotalHombres.Text = entrenadorService.TotalizarTipo("M").Cuenta.ToString();
                    textTotalMujeres.Text = entrenadorService.TotalizarTipo("F").Cuenta.ToString();

                }
                else
                {
                    if (respuesta.Entrenadores.Count == 0)
                    {
                        MostrarAvisoDatos();
                        Eliminar.Visible = false;
                    }
                }
            }
        }
        private void MostrarAvisoDatos()
        {
            DataGridEntrenadores.DataSource = null;
            panelAviso.Visible = true;
            labelAviso.Text = "No hay datos registrados";
            panelAviso.Top = 115;
            panelDatagridEntrenadores.Top = 151;
        }
        private void EliminarEntrenador(string id)
        {
            string mensaje = entrenadorService.Eliminar(id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            FormRegistrarEntrenador frm = new FormRegistrarEntrenador();
            frm.ShowDialog();
            ConsultarListaEntrenadores();
            Inicializar();
        }
        private void btnModificarEntrenador_Click(object sender, EventArgs e)
        {
            FormRegistrarEntrenador frm = new FormRegistrarEntrenador();
            frm.ShowDialog();
            ConsultarListaEntrenadores();
            Inicializar();
        }
        private void btnFirmarContrato_Click(object sender, EventArgs e)
        {
            FormServicioDeEntrenador frm = new FormServicioDeEntrenador();
            frm.ShowDialog();
            ConsultarListaEntrenadores();
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
                    btnRegistrarEntrenador.Enabled = false;
                    btnModificarEntrenador.Enabled = false;
                    labelCash.Text = "0";
                }
            }
        }

        private void DataGridEntrenadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id;
            if (DataGridEntrenadores.DataSource != null)
            {
                if (DataGridEntrenadores.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    Id = DataGridEntrenadores.CurrentRow.Cells["Identificacion"].Value.ToString();
                    string msg = "Desea eliminar este registro " + Id + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarEntrenador(Id);
                        ConsultarListaEntrenadores();
                    }
                }
                else
                {
                    if (DataGridEntrenadores.DataSource == null)
                    {
                        string msg = "No hay registros disponibles";
                        MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
