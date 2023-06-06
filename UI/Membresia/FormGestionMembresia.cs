using DocumentFormat.OpenXml.Wordprocessing;
using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class FormMembresia : Form
    {
        ClienteService clienteService;
        Cliente cliente;
        MembresiaService membresiaService;
        Membresia membresia;
        PlanDeEjercicioService planDeEjercicioService;
        PlanDeEjercicio planDeEjercicio;
        CajaRegistradoraService cajaRegistradoraService;
        Caja cajaRegistradora;
        bool busquedaCliente = false;
        string idCajaAbierta;
        double montoActualCaja;
        double montoActualVenta;
        public FormMembresia()
        {
            clienteService = new ClienteService(ConfigConnection.ConnectionString);
            membresiaService = new MembresiaService(ConfigConnection.ConnectionString);
            planDeEjercicioService = new PlanDeEjercicioService(ConfigConnection.ConnectionString);
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            InitializeComponent();
            CargarListaMiembros();
            CargarDatosPlanes();
            ConsultarCajaAbierta();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMembership_Click(object sender, EventArgs e)
        {
            tabControlMembership.SelectedIndex = 1;
        }

        private void btnUpdateMembership_Click(object sender, EventArgs e)
        {
            tabControlMembership.SelectedIndex = 1;
        }
        //Consultar cliente
        public void ConsultarCajaAbierta()
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            string estado = "Abierta";
            respuesta = cajaRegistradoraService.BuscarPorEstado(estado);
            if (respuesta.CajaRegistradora != null)
            {
                var cajasRegistradoras = new List<Caja> { respuesta.CajaRegistradora };
                labelCash.Text = respuesta.CajaRegistradora.VentaDelDia.ToString();
                labelBase.Text = respuesta.CajaRegistradora.MontoInicial.ToString();
                idCajaAbierta = respuesta.CajaRegistradora.IdCaja;
                montoActualCaja = respuesta.CajaRegistradora.MontoFinal;
                montoActualVenta = respuesta.CajaRegistradora.VentaDelDia;
            }
            else
            {
                if (respuesta.CajaRegistradora == null)
                {
                    labelCash.Text = "Sin definir";
                    labelBase.Text = "Sin definir";
                }
            }
        }
        private void CargarDatosPlanes()
        {
            ConsultaPlanDeEjercicioRespuesta respuesta = new ConsultaPlanDeEjercicioRespuesta();
            respuesta = planDeEjercicioService.ConsultarPorEstados("Activo");
            var planesDeEjercicios = respuesta.PlanesDeEjercicios.ToList();
            if (planesDeEjercicios.Count > 0)
            {
                for (int i = 0; i < planesDeEjercicios.Count; i++)
                {
                    comboPlan.Items.Add(planesDeEjercicios[i].Objetivo);
                }
            }
        }
        private void CargarListaMiembros()
        {
            ConsultaMembresiaRespuesta respuesta = new ConsultaMembresiaRespuesta();
            respuesta = membresiaService.ConsultarTodos();
            var membresias = respuesta.Membresias.ToList();
            if (membresias.Count != 0 || membresias != null)
            {
                dataGridMiembro.DataSource = membresias;
                textTotal.Text = membresiaService.Totalizar().Cuenta.ToString();
                textHombres.Text = membresiaService.TotalizarTipoEstado("Activo").Cuenta.ToString();
                textMujeres.Text = membresiaService.TotalizarTipoEstado("Inactivo").Cuenta.ToString();
            }
        }
        private void EliminarRegistro(string id)
        {
            string mensaje = membresiaService.Eliminar(id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BuscarPorCategoria(string categoria)
        {
            BusquedaMembresiaRespuesta respuesta = new BusquedaMembresiaRespuesta();
            respuesta = membresiaService.BuscarPorCategoria(categoria);
            var membresia = respuesta.Membresia;
            if (membresia != null)
            {
                dataGridMiembro.DataSource = null;
                var membresias = new List<Membresia> { membresia };
                dataGridMiembro.DataSource = membresias;
            }
            else
            {
                dataGridMiembro.DataSource = null;
                labelAlerta.Text = "No hay registros con este filtro";
                labelAlerta.Visible = true;
                pictureAlerta.Visible = true;
            }
        }
        private void BuscarPorEstado(string estado)
        {

        }
        private void comboFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFiltroCategoria.Text != "" && comboFiltroCategoria.Text != "Filtro Sexo" && comboFiltroCategoria.Text != "Todos")
            {
                string categoria = comboFiltroCategoria.Text;
                BuscarPorCategoria(categoria);
            }
            else
            {
                CargarListaMiembros();
                labelAlerta.Visible = false;
                pictureAlerta.Visible = false;
            }
        }

        private void dataGridMiembro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int abono;
            string idMiembro;
            string nombre;
            int saldo;
            if (dataGridMiembro.DataSource != null)
            {
                if (dataGridMiembro.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    idMiembro = Convert.ToString(dataGridMiembro.CurrentRow.Cells["CodigoMiembro"].Value.ToString());
                    string msg = "Desea eliminar este registro " + idMiembro + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarRegistro(idMiembro);
                        CargarListaMiembros();
                    }
                }
                else
                {
                    if (dataGridMiembro.Columns[e.ColumnIndex].Name == "Deshacer")
                    {
                        idMiembro = Convert.ToString(dataGridMiembro.CurrentRow.Cells["CodigoMiembro"].Value);
                        nombre = Convert.ToString(dataGridMiembro.CurrentRow.Cells["Nombres"].Value);
                        if (idMiembro != null)
                        {
                            if (Convert.ToInt32(dataGridMiembro.CurrentRow.Cells["Abono"].Value) > 0)
                            {
                                abono = Convert.ToInt32(dataGridMiembro.CurrentRow.Cells["Abono"].Value);
                                string msg = "Desea eliminar al cliente " + nombre + " de las membresias?";
                                var respuesta = MessageBox.Show(msg, "Deshacer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (respuesta == DialogResult.OK)
                                {
                                    RestarACaja(abono);
                                    EliminarRegistro(idMiembro);
                                    CargarListaMiembros();
                                    ConsultarCajaAbierta();
                                }
                            }
                            else
                            {
                                if (Convert.ToInt32(dataGridMiembro.CurrentRow.Cells["Saldo"].Value) > 0)
                                {
                                    saldo = Convert.ToInt32(dataGridMiembro.CurrentRow.Cells["Saldo"].Value);
                                    string msg = "Desea eliminar al cliente " + nombre + " de las membresias?";
                                    var respuesta = MessageBox.Show(msg, "Deshacer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (respuesta == DialogResult.OK)
                                    {
                                        RestarACaja(saldo);
                                        EliminarRegistro(idMiembro);
                                        CargarListaMiembros();
                                        ConsultarCajaAbierta();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (dataGridMiembro.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void RestarACaja(int valor)
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            respuesta = cajaRegistradoraService.BuscarPorEstado("Abierta");
            var cajaRegistradoraBuscada = respuesta.CajaRegistradora;
            if (cajaRegistradoraBuscada != null)
            {
                double ventaDelDia = cajaRegistradoraBuscada.VentaDelDia;
                double cuadre = ventaDelDia - valor;
                cajaRegistradoraBuscada.VentaDelDia = cuadre;
                double montoFinal = cajaRegistradoraBuscada.MontoFinal;
                cajaRegistradoraBuscada.MontoFinal = montoFinal - valor;
                Caja NuevacajaRegistradora = cajaRegistradoraBuscada;
                cajaRegistradoraService.ModificarCash(NuevacajaRegistradora);
            }
            else
            {

            }
        }
        private void BuscarPorId(string busqueda)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            respuesta = clienteService.BuscarPorIdentificacion(busqueda);
            var clienteBuscado = respuesta.Cliente;
            if (clienteBuscado != null)
            {
                panelDatosMembresia.Enabled = true;
                panelReporte.Enabled = true;
                textNombres.Enabled = true;
                textApellidos.Enabled = true;
                textNombres.Text = clienteBuscado.Nombres;
                textApellidos.Text = clienteBuscado.Apellidos;
                comboEstado.Enabled = true;
                comboPlan.Enabled = true;
                busquedaCliente = true;
                using (MemoryStream ms = new MemoryStream(clienteBuscado.ImagenPerfil))
                {
                    // Carga la imagen desde el MemoryStream
                    Image imagen = Image.FromStream(ms);
                    // Asigna la imagen al control PictureBox
                    picturePerfil.Image = imagen;
                    ms.Dispose();
                }
                BusquedaMembresiaRespuesta respuestaMembresia = new BusquedaMembresiaRespuesta();
                respuestaMembresia = membresiaService.BuscarPorNombre(clienteBuscado.Nombres);
                var membresiaBuscada = respuestaMembresia.Membresia;
                if (membresiaBuscada != null)
                {
                    comboEstado.Text = membresiaBuscada.Estado;
                    textCodigoMiembro.Text = membresiaBuscada.CodigoMiembro;
                    comboCategoria.Text = membresiaBuscada.Categoria;
                    textValorMensual.Text = membresiaBuscada.ValorMensual.ToString();
                    textAbono.Text = membresiaBuscada.Abono.ToString();
                    textSaldo.Text = membresiaBuscada.Saldo.ToString();
                    btnModificarCliente.Enabled = true;
                    pictureCategoria.Visible = true;
                    if (membresia.Categoria == "Principiante")
                    {
                        pictureCategoria.Image = Resources.bronze_;
                    }
                    else
                    {
                        if (membresia.Categoria == "Elite")
                        {
                            pictureCategoria.Image = Resources.Silver_;
                        }
                        else
                        {
                            if (membresia.Categoria == "Profesional")
                            {
                                pictureCategoria.Image = Resources.Gold_;
                            }
                        }
                    }
                }
                else
                {
                    textCodigoMiembro.Text = clienteBuscado.CodigoCliente;
                    comboCategoria.Text = "No definida";
                    textValorMensual.Text = "0";
                    textAbono.Text = "0";
                    textSaldo.Text = "0";
                    comboEstado.Text = "Inactivo";
                }
            }
            else
            {
                textNombres.Text = "";
                textApellidos.Text = "";
                textCodigoMiembro.Text = "#";
                comboCategoria.Text = "No definida";
                textValorMensual.Text = "0";
                textAbono.Text = "0";
                textSaldo.Text = "0";
                comboPlan.Text = "Seleccione el plan";
                comboEstado.Text = "Seleccione estado";
                picturePerfil.Image = Resources.User;
                pictureCategoria.Visible = false;
                panelReporte.Enabled = false;
            }
        }
        private void BuscarPorNombre(string busqueda)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            respuesta = clienteService.BuscarPorIdentificacion(busqueda);
            var clienteBuscado = respuesta.Cliente;
            if (clienteBuscado != null)
            {
                panelDatosMembresia.Enabled = true;
                panelReporte.Enabled = true;
                textNombres.Enabled = true;
                textApellidos.Enabled = true;
                textNombres.Text = clienteBuscado.Nombres;
                textApellidos.Text = clienteBuscado.Apellidos;
                textCodigoMiembro.Text = clienteBuscado.CodigoCliente;
                comboEstado.Enabled = true;
                comboPlan.Enabled = true;
                busquedaCliente = true;
                using (MemoryStream ms = new MemoryStream(clienteBuscado.ImagenPerfil))
                {
                    // Carga la imagen desde el MemoryStream
                    Image imagen = Image.FromStream(ms);
                    // Asigna la imagen al control PictureBox
                    picturePerfil.Image = imagen;
                    ms.Dispose();
                }
                BusquedaMembresiaRespuesta respuestaMembresia = new BusquedaMembresiaRespuesta();
                respuestaMembresia = membresiaService.BuscarPorNombre(clienteBuscado.Nombres);
                var membresiaBuscada = respuestaMembresia.Membresia;
                if (membresiaBuscada != null)
                {
                    comboEstado.Text = membresiaBuscada.Estado;
                    textCodigoMiembro.Text = membresiaBuscada.CodigoMiembro;
                    comboCategoria.Text = membresiaBuscada.Categoria;
                    textValorMensual.Text = membresiaBuscada.ValorMensual.ToString();
                    textAbono.Text = membresiaBuscada.Abono.ToString();
                    textSaldo.Text = membresiaBuscada.Saldo.ToString();
                    labelCantidadCreditos.Text = membresiaBuscada.Creditos.ToString();
                    btnModificarCliente.Enabled = true;
                    if (membresia.Categoria == "Principiante")
                    {
                        pictureCategoria.Image = Resources.bronze_;
                    }
                    else
                    {
                        if (membresia.Categoria == "Elite")
                        {
                            pictureCategoria.Image = Resources.Silver_;
                        }
                        else
                        {
                            if (membresia.Categoria == "Profesional")
                            {
                                pictureCategoria.Image = Resources.Gold_;
                            }
                        }
                    }
                }
                else
                {
                    textCodigoMiembro.Text = clienteBuscado.CodigoCliente;
                    comboCategoria.Text = "No definida";
                    textValorMensual.Text = "0";
                    textAbono.Text = "0";
                    textSaldo.Text = "0";
                    comboEstado.Text = "Inactivo";
                }
            }
            else
            {
                textNombres.Text = "";
                textApellidos.Text = "";
                textCodigoMiembro.Text = "#";
                comboCategoria.Text = "No definida";
                textValorMensual.Text = "0";
                textAbono.Text = "0";
                textSaldo.Text = "0";
                comboPlan.Text = "Seleccione el plan";
                comboEstado.Text = "Seleccione estado";
                picturePerfil.Image = Resources.User;
                pictureCategoria.Visible = false;
                panelReporte.Enabled = false;
            }
        }
        //Registrar membresia
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textSearch.Text;
            if (textSearch.Text != "" && textSearch.Text != "Buscar")
            {
                BuscarPorId(busqueda);
                BuscarPorNombre(busqueda);
                if (busquedaCliente == false)
                {
                    labelAlerta.Text = "No se encontraron los datos buscados";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
                else
                {
                    if (busquedaCliente == true)
                    {
                        labelAlerta.Visible = false;
                        pictureAlerta.Visible = false;
                        panelReporte.Enabled = true;
                    }
                }
            }
        }

        private void textSearch_Enter(object sender, EventArgs e)
        {
            if (textSearch.Text == "Buscar")
            {
                textSearch.Text = "";
            }
        }

        private void textSearch_Leave(object sender, EventArgs e)
        {
            if (textSearch.Text == "")
            {
                textSearch.Text = "Buscar";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Visible = false;
            btnCloseSearch.Visible = true;
            textSearch.Visible = true;
        }

        private void btnCloseSearch_Click(object sender, EventArgs e)
        {
            btnCloseSearch.Visible = false;
            btnSearch.Visible = true;
            textSearch.Visible = false;
            textSearch.Text = "Buscar";
        }
        private Membresia MapearMiembro()
        {
            membresia = new Membresia();
            membresia.CodigoMiembro = textCodigoMiembro.Text;
            membresia.Categoria = comboCategoria.Text;
            membresia.Estado = comboEstado.Text;
            membresia.Nombres = textNombres.Text;
            membresia.Apellidos = textApellidos.Text;
            membresia.NombreDePlan = comboPlan.Text;
            membresia.Abono = Convert.ToInt32(textAbono.Text);
            return membresia;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (comboEstado.Text == "Activo" || comboEstado.Text == "Inactivo" && comboPlan.Text != "Seleccione el plan")
            {
                Membresia membresia = MapearMiembro();
                string mensaje = membresiaService.Guardar(membresia);
                if (mensaje == "Membresia registrada correctamente")
                {
                    MessageBox.Show(mensaje, "Mensaje de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    btnEnviarReporte.Visible = true;
                    CargarListaMiembros();
                    btnModificarCliente.Enabled = true;
                    SumarACaja();
                    //Limpiar();
                }
            }
        }
        private void SumarACaja()
        {
            if (textAbono.Text == "0")
            {
                BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
                string estado = "Abierta";
                respuesta = cajaRegistradoraService.BuscarPorEstado(estado);
                if (respuesta.CajaRegistradora != null)
                {
                    respuesta.CajaRegistradora.VentaDelDia = respuesta.CajaRegistradora.VentaDelDia + Convert.ToInt32(labelTotalAPagar.Text);
                    respuesta.CajaRegistradora.MontoFinal = respuesta.CajaRegistradora.MontoInicial + respuesta.CajaRegistradora.VentaDelDia;
                    Caja caja = respuesta.CajaRegistradora;
                    cajaRegistradoraService.ModificarCash(caja);
                    btnModificarCliente.Enabled = true;
                    ConsultarCajaAbierta();
                }
                else
                {
                    if (respuesta.CajaRegistradora == null)
                    {
                        labelCash.Text = "Sin definir";
                        labelBase.Text = "Sin definir";
                    }
                }
            }
            else
            {
                if (textAbono.Text != "0")
                {
                    BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
                    string estado = "Abierta";
                    respuesta = cajaRegistradoraService.BuscarPorEstado(estado);
                    if (respuesta.CajaRegistradora != null)
                    {
                        respuesta.CajaRegistradora.VentaDelDia = respuesta.CajaRegistradora.VentaDelDia + Convert.ToInt32(textAbono.Text);
                        respuesta.CajaRegistradora.MontoFinal = respuesta.CajaRegistradora.MontoInicial + respuesta.CajaRegistradora.VentaDelDia;
                        Caja caja = respuesta.CajaRegistradora;
                        cajaRegistradoraService.ModificarCash(caja);
                        ConsultarCajaAbierta();
                    }
                    else
                    {
                        if (respuesta.CajaRegistradora == null)
                        {
                            labelCash.Text = "Sin definir";
                            labelBase.Text = "Sin definir";
                        }
                    }
                }
            }
        }
        private void Limpiar()
        {
            comboCategoria.Text = "Seleccione categoria";
            textValorMensual.Text = "0";
            textAbono.Text = "0";
            textSaldo.Text = "0";
        }
        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            membresia = new Membresia();
            membresia.Categoria = comboCategoria.Text;
            membresia.ObtenerPizarraMiembro();
            labelValorMensualidad.Text = membresia.ValorMensual.ToString();
            textValorMensual.Text = membresia.ValorMensual.ToString();
            membresia.Abono = Convert.ToInt32(textAbono.Text);
            labelValorInscripcion.Text = membresia.ValorInscripcion.ToString();
            labelCantidadCreditos.Text = membresia.Creditos.ToString();
            textSaldo.Text = membresia.Saldo.ToString();
            int TotalAPagar = Convert.ToInt32(labelValorInscripcion.Text) + Convert.ToInt32(labelValorMensualidad.Text);
            labelTotalAPagar.Text = TotalAPagar.ToString();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (comboEstado.Text == "Activo" || comboEstado.Text == "Inactivo" && comboPlan.Text != "Seleccione el plan")
            {
                Membresia membresia = MapearMiembro();
                string mensaje = membresiaService.Modificar(membresia);
                MessageBox.Show(mensaje, "Mensaje de modificacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                labelValorInscripcion.Text = membresia.ValorInscripcion.ToString();
                labelValorMensualidad.Text = membresia.ValorMensual.ToString();
                labelCantidadCreditos.Text = membresia.Creditos.ToString();
                int Total = membresia.ValorInscripcion + membresia.ValorMensual;
                labelTotalAPagar.Text = Total.ToString();
                CargarListaMiembros();
            }
        }

        private void textAbono_Enter(object sender, EventArgs e)
        {
            if (textAbono.Text == "0")
            {
                textAbono.Text = "";
            }
        }

        private void textAbono_Leave(object sender, EventArgs e)
        {
            if (textAbono.Text == "")
            {
                textAbono.Text = "0";
            }
        }

        private void textAbono_TextChanged(object sender, EventArgs e)
        {
            if (textAbono.Text != "" && textAbono.Text != "0")
            {
                membresia = new Membresia();
                membresia.Categoria = comboCategoria.Text;
                membresia.Abono = Convert.ToInt32(textAbono.Text);
                membresia.ObtenerPizarraMiembro();
                labelValorMensualidad.Text = membresia.ValorMensual.ToString();
                textValorMensual.Text = membresia.ValorMensual.ToString();
                labelValorInscripcion.Text = membresia.ValorInscripcion.ToString();
                labelCantidadCreditos.Text = membresia.Creditos.ToString();
                textSaldo.Text = membresia.Saldo.ToString();
                int TotalAPagar = membresia.Saldo;
                labelTotalAPagar.Text = TotalAPagar.ToString();
            }
        }
    }
}
