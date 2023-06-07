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
using System.Windows;
using System.Windows.Interop;
using MessageBox = System.Windows.Forms.MessageBox;
using UI.Properties;
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Windows.Media;

namespace UI
{
    public partial class FormGestionCliente : Form
    {
        public readonly Validaciones validaciones;
        ClienteService clienteService;
        Cliente cliente;
        bool busquedaCliente = false;
        bool continuar = false;
        public FormGestionCliente()
        {
            clienteService = new ClienteService(ConfigConnection.ConnectionString);
            InitializeComponent();
            CargarListaClientes();
            validaciones = new Validaciones();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            tabControlCliente.SelectedIndex = 1;
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            tabControlCliente.SelectedIndex = 1;
        }

        private void btnProgreso_Click(object sender, EventArgs e)
        {
            tabControlCliente.SelectedIndex = 2;
        }
        //Consultar cliente
        private void CargarListaClientes()
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();
            respuesta = clienteService.ConsultarTodos();
            var clientes = respuesta.Clientes.ToList();
            if (clientes.Count != 0 || clientes != null)
            {
                dataGridClient.DataSource = clientes;
                textTotal.Text = clienteService.Totalizar().Cuenta.ToString();
                textHombres.Text = clienteService.TotalizarTipo("M").Cuenta.ToString();
                textMujeres.Text = clienteService.TotalizarTipo("F").Cuenta.ToString();
            }
        }
        private void EliminarRegistro(string id)
        {
            string mensaje = clienteService.Eliminar(id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BuscarPorSexo(string sexo)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            respuesta = clienteService.BuscarPorSexo(sexo);
            var registro = respuesta.Cliente;
            if (registro != null)
            {
                dataGridClient.DataSource = null;
                var clientes = new List<Cliente> { registro };
                dataGridClient.DataSource = clientes;
            }
            else
            {
                dataGridClient.DataSource = null;
                labelAlerta.Text = "No hay registros con este filtro";
                labelAlerta.Visible = true;
                pictureAlerta.Visible = true;
            }
        }
        private void comboFiltroSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFiltroSexo.Text != "" && comboFiltroSexo.Text != "Filtro Sexo" && comboFiltroSexo.Text != "Todos")
            {
                string sexo = comboFiltroSexo.Text;
                BuscarPorSexo(sexo);
            }
            else
            {
                CargarListaClientes();
                labelAlerta.Visible = false;
                pictureAlerta.Visible = false;
            }
        }
        private void dataGridClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (dataGridClient.DataSource != null)
            {
                if (dataGridClient.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    id = Convert.ToString(dataGridClient.CurrentRow.Cells["Identificacion"].Value.ToString());
                    string msg = "Desea eliminar este registro " + id + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarRegistro(id);
                        CargarListaClientes();
                    }
                }
            }
            else
            {
                if (dataGridClient.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Registrar cliente
        private Cliente MapearDatosCliente()
        {
            cliente = new Cliente();
            cliente.Identificacion = textID.Text;
            cliente.TipoDeIdentificacion = comboTipoID.Text;
            cliente.Nombres = textNombres.Text;
            cliente.Apellidos = textApellidos.Text;
            cliente.FechaDeNacimiento = dateTimeFechaDeNacimiento.Value;
            cliente.Direccion = textDireccion.Text;
            cliente.Sexo = comboSexoRegistro.Text;
            cliente.Telefono = textTelefono.Text;
            cliente.CorreoElectronico = textCorreo.Text;
            cliente.Peso = Convert.ToInt32(textPesoCorporal.Text);
            cliente.Altura = Convert.ToDouble(textEstaturaCorporal.Text);
            using (MemoryStream ms = new MemoryStream())
            {
                picturePerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cliente.ImagenPerfil = ms.ToArray();
            }
            return cliente;
        }
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventanaCargar = new OpenFileDialog();
            DialogResult dr = ventanaCargar.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (validaciones.ValidarImagen(ventanaCargar.FileName) == true)
                {
                    // La imagen cargada en picturePerfil es válida
                    picturePerfil.Image = Image.FromFile(ventanaCargar.FileName);
                }
                else
                {
                    labelAlerta.Visible = true;
                    labelAlerta.Text = "Formato de imagen incorrecta";
                }
            }
        }
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearDatosCliente();
            string mensaje = clienteService.Guardar(cliente);
            MessageBox.Show(mensaje, "Mensaje de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            CargarListaClientes();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearDatosCliente();
            string mensaje = clienteService.Modificar(cliente);
            MessageBox.Show(mensaje, "Mensaje de modificacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            CargarListaClientes();
        }
        private void BuscarPorId(string busqueda)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            respuesta = clienteService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Cliente;
            if (buscado != null)
            {
                textID.Text = buscado.Identificacion;
                comboTipoID.Text = buscado.TipoDeIdentificacion;
                textNombres.Text = buscado.Nombres;
                textApellidos.Text = buscado.Apellidos;
                dateTimeFechaDeNacimiento.Value = buscado.FechaDeNacimiento;
                comboSexoRegistro.Text = buscado.Sexo;
                textDireccion.Text = buscado.Direccion;
                textTelefono.Text = buscado.Telefono;
                textCorreo.Text = buscado.CorreoElectronico;
                textPesoCorporal.Text = buscado.Peso.ToString();
                textEstaturaCorporal.Text = buscado.Altura.ToString();
                busquedaCliente = true;
                using (MemoryStream ms = new MemoryStream(buscado.ImagenPerfil))
                {
                    // Carga la imagen desde el MemoryStream
                    Image imagen = Image.FromStream(ms);
                    // Asigna la imagen al control PictureBox
                    picturePerfil.Image = imagen;
                }
            }
        }
        private void BuscarPorNombre(string busqueda)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            respuesta = clienteService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Cliente;
            if (buscado != null)
            {
                textID.Text = buscado.Identificacion;
                comboTipoID.Text = buscado.TipoDeIdentificacion;
                textNombres.Text = buscado.Nombres;
                textApellidos.Text = buscado.Apellidos;
                dateTimeFechaDeNacimiento.Value = buscado.FechaDeNacimiento;
                comboSexoRegistro.Text = buscado.Sexo;
                textDireccion.Text = buscado.Direccion;
                textTelefono.Text = buscado.Telefono;
                textCorreo.Text = buscado.CorreoElectronico;
                textPesoCorporal.Text = buscado.Peso.ToString();
                textEstaturaCorporal.Text = buscado.Altura.ToString();
                busquedaCliente = true;
                using (MemoryStream ms = new MemoryStream(buscado.ImagenPerfil))
                {
                    // Carga la imagen desde el MemoryStream
                    Image imagen = Image.FromStream(ms);
                    // Asigna la imagen al control PictureBox
                    picturePerfil.Image = imagen;
                }
            }
        }
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
                labelAlerta.Visible = false;
                pictureAlerta.Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Visible = false;
            btnCloseTextSearch.Visible = true;
            textSearch.Visible = true;
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
                    }
                }
            }
        }

        private void btnCloseTextSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            btnCloseTextSearch.Visible = false;
            textSearch.Visible = false;
            textSearch.Text = "Buscar";
            labelAlerta.Visible = false;
            pictureAlerta.Visible = false;
        }
        //Progreso cliente
        private void BuscarPorIdProgreso(string busqueda)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            respuesta = clienteService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Cliente;
            if (buscado != null)
            {
                if (buscado.ClasificacionPorPeso == "Delgadez muy Severa")
                {
                    if (buscado.Sexo == "F")
                    {
                        pictureEstado.Image = Resources.DelgadaF;
                    }
                    else
                    {
                        pictureEstado.Image = Resources.DelgadoM;
                    }
                }
                else
                {
                    if (buscado.ClasificacionPorPeso == "Delgadez Severa")
                    {
                        if (buscado.Sexo == "F")
                        {
                            pictureEstado.Image = Resources.DelgadaF;
                        }
                        else
                        {
                            pictureEstado.Image = Resources.DelgadoM;
                        }
                    }
                    else
                    {
                        if (buscado.ClasificacionPorPeso == "Delgadez")
                        {
                            if (buscado.Sexo == "F")
                            {
                                pictureEstado.Image = Resources.DelgadaF;
                            }
                            else
                            {
                                pictureEstado.Image = Resources.DelgadoM;
                            }
                        }
                        else
                        {
                            if (buscado.ClasificacionPorPeso == "Peso Saludable")
                            {
                                if (buscado.Sexo == "F")
                                {
                                    pictureEstado.Image = Resources.SaludableF;
                                }
                                else
                                {
                                    pictureEstado.Image = Resources.SaludableM;
                                }
                            }
                            else
                            {
                                if (buscado.ClasificacionPorPeso == "Sobrepeso")
                                {
                                    if (buscado.Sexo == "F")
                                    {
                                        pictureEstado.Image = Resources.SobrePesoF;
                                    }
                                    else
                                    {
                                        pictureEstado.Image = Resources.SobrePesoM;
                                    }
                                }
                                else
                                {
                                    if (buscado.ClasificacionPorPeso == "Obesidad Moderada")
                                    {
                                        if (buscado.Sexo == "F")
                                        {
                                            pictureEstado.Image = Resources.SobrePesoF;
                                        }
                                        else
                                        {
                                            pictureEstado.Image = Resources.SobrePesoM;
                                        }
                                    }
                                    else
                                    {
                                        if (buscado.ClasificacionPorPeso == "Obesidad Severa")
                                        {
                                            if (buscado.Sexo == "F")
                                            {
                                                pictureEstado.Image = Resources.SobrePesoF;
                                            }
                                            else
                                            {
                                                pictureEstado.Image = Resources.SobrePesoM;
                                            }
                                        }
                                        else
                                        {
                                            if (buscado.ClasificacionPorPeso == "Obesidad muy Severa")
                                            {
                                                if (buscado.Sexo == "F")
                                                {
                                                    pictureEstado.Image = Resources.SobrePesoF;
                                                }
                                                else
                                                {
                                                    pictureEstado.Image = Resources.SobrePesoM;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                labelEstadoCliente.Text = buscado.ClasificacionPorPeso;
                textIndiceMasaCorporal.Text = buscado.IndiceDeMasaCorporal.ToString();
                textIndiceGrasaCorporal.Text = buscado.IndiceDeGrasaCorporal.ToString();
                textIndiceMasaMuscular.Text = buscado.IndiceDeMasaMuscular.ToString();
                textIndiceMasaResidual.Text = buscado.IndiceDeMasaResidual.ToString();
                textIndiceMasaOsea.Text = buscado.IndiceDeMasaOsea.ToString();
                busquedaCliente = true;
            }
        }
        private void BuscarPorNombreProgreso(string busqueda)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            respuesta = clienteService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Cliente;
            if (buscado != null)
            {
                if (buscado.ClasificacionPorPeso == "Delgadez muy Severa")
                {
                    if (buscado.Sexo == "F")
                    {
                        pictureEstado.Image = Resources.DelgadaF;
                    }
                    else
                    {
                        pictureEstado.Image = Resources.DelgadoM;
                    }
                }
                else
                {
                    if (buscado.ClasificacionPorPeso == "Delgadez Severa")
                    {
                        if (buscado.Sexo == "F")
                        {
                            pictureEstado.Image = Resources.DelgadaF;
                        }
                        else
                        {
                            pictureEstado.Image = Resources.DelgadoM;
                        }
                    }
                    else
                    {
                        if (buscado.ClasificacionPorPeso == "Delgadez")
                        {
                            if (buscado.Sexo == "F")
                            {
                                pictureEstado.Image = Resources.DelgadaF;
                            }
                            else
                            {
                                pictureEstado.Image = Resources.DelgadoM;
                            }
                        }
                        else
                        {
                            if (buscado.ClasificacionPorPeso == "Peso Saludable")
                            {
                                if (buscado.Sexo == "F")
                                {
                                    pictureEstado.Image = Resources.SaludableF;
                                }
                                else
                                {
                                    pictureEstado.Image = Resources.SaludableM;
                                }
                            }
                            else
                            {
                                if (buscado.ClasificacionPorPeso == "Sobrepeso")
                                {
                                    if (buscado.Sexo == "F")
                                    {
                                        pictureEstado.Image = Resources.SobrePesoF;
                                    }
                                    else
                                    {
                                        pictureEstado.Image = Resources.SobrePesoM;
                                    }
                                }
                                else
                                {
                                    if (buscado.ClasificacionPorPeso == "Obesidad Moderada")
                                    {
                                        if (buscado.Sexo == "F")
                                        {
                                            pictureEstado.Image = Resources.SobrePesoF;
                                        }
                                        else
                                        {
                                            pictureEstado.Image = Resources.SobrePesoM;
                                        }
                                    }
                                    else
                                    {
                                        if (buscado.ClasificacionPorPeso == "Obesidad Severa")
                                        {
                                            if (buscado.Sexo == "F")
                                            {
                                                pictureEstado.Image = Resources.SobrePesoF;
                                            }
                                            else
                                            {
                                                pictureEstado.Image = Resources.SobrePesoM;
                                            }
                                        }
                                        else
                                        {
                                            if (buscado.ClasificacionPorPeso == "Obesidad muy Severa")
                                            {
                                                if (buscado.Sexo == "F")
                                                {
                                                    pictureEstado.Image = Resources.SobrePesoF;
                                                }
                                                else
                                                {
                                                    pictureEstado.Image = Resources.SobrePesoM;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                labelEstadoCliente.Text = buscado.ClasificacionPorPeso;
                textIndiceMasaCorporal.Text = buscado.IndiceDeMasaCorporal.ToString();
                textIndiceGrasaCorporal.Text = buscado.IndiceDeGrasaCorporal.ToString();
                textIndiceMasaMuscular.Text = buscado.IndiceDeMasaMuscular.ToString();
                textIndiceMasaResidual.Text = buscado.IndiceDeMasaResidual.ToString();
                textIndiceMasaOsea.Text = buscado.IndiceDeMasaOsea.ToString();
                busquedaCliente = true;
            }
        }
        private void textSearchProgreso_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textSearchProgreso.Text;
            if (textSearchProgreso.Text != "" && textSearchProgreso.Text != "Buscar")
            {
                BuscarPorIdProgreso(busqueda);
                BuscarPorNombreProgreso(busqueda);
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
                    }
                }
            }
        }

        private void textSearchProgreso_Enter(object sender, EventArgs e)
        {
            if (textSearchProgreso.Text == "Buscar")
            {
                textSearchProgreso.Text = "";
            }
        }

        private void textSearchProgreso_Leave(object sender, EventArgs e)
        {
            if (textSearchProgreso.Text == "")
            {
                textSearchProgreso.Text = "Buscar";
                labelAlerta.Visible = false;
                pictureAlerta.Visible = false;
            }
        }

        private void btnSearchProgreso_Click(object sender, EventArgs e)
        {
            btnSearchProgreso.Visible = false;
            btnCloseSearchProgreso.Visible = true;
            textSearchProgreso.Visible = true;
            string busqueda = textSearchProgreso.Text;
            if (textSearchProgreso.Text != "" && textSearchProgreso.Text != "Buscar")
            {
                BuscarPorIdProgreso(busqueda);
                BuscarPorNombreProgreso(busqueda);
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
                    }
                }
            }
        }

        private void btnCloseSearchProgreso_Click(object sender, EventArgs e)
        {
            btnSearchProgreso.Visible = true;
            btnCloseSearchProgreso.Visible = false;
            textSearchProgreso.Visible = false;
            textSearchProgreso.Text = "Buscar";
            labelAlerta.Visible = false;
            pictureAlerta.Visible = false;
        }

        private void textNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es una letra o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Cancelar la pulsación del carácter
            }
        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar la pulsación del carácter
            }
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar la pulsación del carácter
            }
        }

        private void textPesoCorporal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar la pulsación del carácter
            }
        }

        private void textEstaturaCorporal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar la pulsación del carácter
            }
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {
            if (textID.Text != "")
            {
                if (validaciones.RangoCampos(textID, textID.Text, labelAlerta, 10) == false)
                {
                    pictureAlerta.Visible = true;
                    labelAlerta.Visible = true;
                }
                else
                {
                    pictureAlerta.Visible = false;
                    labelAlerta.Visible = false;
                }
            }
        }

        private void textNombres_TextChanged(object sender, EventArgs e)
        {
            if (textNombres.Text != "")
            {
                if (validaciones.RangoCampos(textNombres, textNombres.Text, labelAlerta, 2) == false)
                {
                    pictureAlerta.Visible = true;
                    labelAlerta.Visible = true;

                }
                else
                {
                    pictureAlerta.Visible = false;
                    labelAlerta.Visible = false;
                }
            }
        }

        private void textApellidos_TextChanged(object sender, EventArgs e)
        {
            if (textApellidos.Text != "")
            {
                if (validaciones.RangoCampos(textApellidos, textApellidos.Text, labelAlerta, 2) == false)
                {
                    pictureAlerta.Visible = true;
                    labelAlerta.Visible = true;
                }
                else
                {
                    pictureAlerta.Visible = false;
                    labelAlerta.Visible = false;
                }
            }
        }
    }
}
