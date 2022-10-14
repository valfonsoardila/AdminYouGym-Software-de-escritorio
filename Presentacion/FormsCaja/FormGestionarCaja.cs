using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Logica;
using Entidades;

namespace Presentacion
{
    public partial class FormGestionarCaja : Form
    {
        CajaRegistradoraService cajaRegistradoraService;
        List<CajaRegistradora> cajasRegistradoras;
        CajaRegistradora cajaRegistradora;
        PapeleraService papeleraService = new PapeleraService();
        string idCajaAbierta;
        string fechaDeApertura;
        double montoCaja;
        public FormGestionarCaja()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            InitializeComponent();
            Inicializar();
            ConsultarYLlenarGridDeCajas();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Inicializar()
        {
            panelAviso.Visible = false;
            panelAviso.Top = 115;
            panelTittleDataGrid.Top = 115;
            DataGridCajas.Top = 141;
            panelSubDataGrid.Top = 486;
            btnAbrirCaja.Top = 515;
            btnCerrarCaja.Top = 515;
            btnHistorial.Top = 515;
        }
        private void BuscarPorEstado()
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            string estado="Abierta";
            respuesta = cajaRegistradoraService.BuscarPorEstado(estado);
            if (respuesta.CajaRegistradora != null)
            {   
                var cajasRegistradoras = new List<CajaRegistradora> { respuesta.CajaRegistradora };
                labelCash.Text = respuesta.CajaRegistradora.Monto.ToString();
                btnAbrirCaja.Enabled = false;
                btnCerrarCaja.Enabled = true;
                idCajaAbierta = respuesta.CajaRegistradora.IdCaja;
                fechaDeApertura = respuesta.CajaRegistradora.FechaDeApertura;
                montoCaja = respuesta.CajaRegistradora.Monto;
            }
            else
            {
                if (respuesta.CajaRegistradora == null)
                {
                    labelCash.Text = "0";
                }
            }
        }
        private void ConsultarYLlenarGridDeCajas()
        {
            BuscarPorEstado();
            ConsultaCajaRegistradoraRespuesta respuesta = new ConsultaCajaRegistradoraRespuesta();
            string tipo = comboEstado.Text;
            if (tipo == "Todos")
            {
                textTotal.Enabled = true;
                textTotalCajasAbiertas.Enabled = true;
                textTotalCajasCerradas.Enabled = true;
                DataGridCajas.DataSource = null;
                respuesta = cajaRegistradoraService.ConsultarTodos();
                cajasRegistradoras = respuesta.CajasRegistradoras.ToList();
                if (respuesta.CajasRegistradoras.Count != 0 && respuesta.CajasRegistradoras!=null)
                {
                    DataGridCajas.DataSource = respuesta.CajasRegistradoras;
                    Eliminar.Visible = true;
                    textTotal.Text = cajaRegistradoraService.Totalizar().Cuenta.ToString();
                    textTotalCajasAbiertas.Text = cajaRegistradoraService.TotalizarTipo("Abierta").Cuenta.ToString();
                    textTotalCajasCerradas.Text = cajaRegistradoraService.TotalizarTipo("Cerrada").Cuenta.ToString();
                }else
                {
                    if (respuesta.CajasRegistradoras == null|| respuesta.CajasRegistradoras.Count == 0)
                    {
                        MostrarAviso();
                        btnHistorial.Enabled = false;
                        Eliminar.Visible = false;
                    }
                }
            }
        }
        private void Limpiar()
        {
            textTotal.Text = "0";
            textTotalCajasAbiertas.Text = "0";
            textTotalCajasCerradas.Text = "0";
        }
        private void MostrarAviso()
        {
            DataGridCajas.DataSource = null;
            panelAviso.Visible = true;
            labelAviso.Text = "No hay datos registrados";
            panelAviso.Top = 115;
            panelTittleDataGrid.Top = 151;
            DataGridCajas.Top = 177;
            panelSubDataGrid.Top = 522;
            btnAbrirCaja.Top = 552;
            btnCerrarCaja.Top = 552;
            btnHistorial.Top = 552;
        }
        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from CAJA_REGISTRADORA where Estado='" + comboEstado.Text + "'";
            UpdateGrid(query, "CAJA_REGISTRADORA");
            if (comboEstado.Text == "Todos")
            {
                ConsultarYLlenarGridDeCajas();
                textTotal.Enabled = true;
                textTotalCajasAbiertas.Enabled = true;
                textTotalCajasCerradas.Enabled = true;
            }
        }
        public void UpdateGrid(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, new SqlConnection(Properties.Settings.Default.YouGymConnectionString));
            DataSet dad = new DataSet();
            ada.Fill(dad, tbl);
            DataGridCajas.DataSource = dad;
            DataGridCajas.DataMember = tbl;
        }
        private void btbAbrirCaja_Click(object sender, EventArgs e)
        {
            FormAbrirCaja frm = new FormAbrirCaja();
            frm.ShowDialog();
            Inicializar();
            ConsultarYLlenarGridDeCajas();
        }
        private CajaRegistradora MapearCaja()
        {
            cajaRegistradora = new CajaRegistradora();
            cajaRegistradora.IdCaja = idCajaAbierta;
            cajaRegistradora.FechaDeApertura = fechaDeApertura;
            cajaRegistradora.Monto = montoCaja;
            //Variables Para Mapear en txt
            string idCajaDelete, fechaDeAperturaDelete, fechaDeCierreDelete, estadoDelete;
            double montoDelete;
            idCajaDelete = cajaRegistradora.IdCaja;
            fechaDeAperturaDelete = cajaRegistradora.FechaDeApertura;
            //Llamamos al metodo cerrar caja para obtener los valores y guardar el txt
            cajaRegistradora.CerrarCaja();
            fechaDeCierreDelete = cajaRegistradora.FechaDeCierre;
            estadoDelete = cajaRegistradora.Estado;
            montoDelete = cajaRegistradora.Monto;
            Papelera papelera = new Papelera(idCajaDelete, fechaDeAperturaDelete, fechaDeCierreDelete, estadoDelete, montoDelete);
            string mensaje = papeleraService.Guardar(papelera);
            return cajaRegistradora;
        }
        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                CajaRegistradora cajaRegistradora=MapearCaja();
                string mensaje = cajaRegistradoraService.Modificar(cajaRegistradora);
                MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                ConsultarYLlenarGridDeCajas();
                btnAbrirCaja.Enabled = true;
                btnCerrarCaja.Enabled = false;
                btnHistorial.Enabled = true;
            }
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            string estado = "Cerrada";
            if (estado != "")
            {
                var respuesta = MessageBox.Show("¿Está seguro de eliminar el historial de cajas cerradas?", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    string mensaje = cajaRegistradoraService.EliminarHistorial(estado);
                    MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MostrarAviso();
                labelAviso.Text = "No hay cajas cerradas";
            }
            ConsultarYLlenarGridDeCajas();
            Limpiar();
        }
        private void EliminarCaja(string Id)
        {
            string mensaje = cajaRegistradoraService.Eliminar(Id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Eliminar.Visible = false;
            btnAbrirCaja.Enabled = true;
            btnCerrarCaja.Enabled = false;
        }
        private void DataGridCajas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id;
            if (DataGridCajas.DataSource != null)
            {
                if (btnCerrarCaja.Enabled == false)
                {
                    if (DataGridCajas.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        Id = Convert.ToString(DataGridCajas.CurrentRow.Cells["IdCaja"].Value.ToString());
                        string msg = "Desea eliminar este registro " + Id + "?";
                        var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (respuesta == DialogResult.OK)
                        {
                            EliminarCaja(Id);
                            ConsultarYLlenarGridDeCajas();
                        }
                    }
                }
                else
                {
                    if (btnCerrarCaja.Enabled == false)
                    {
                        Eliminar.Visible = false;
                    }
                }
            }
            else
            {
                if (DataGridCajas.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}