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

namespace UI
{
    public partial class FormGestionEntrenador : Form
    {
        EntrenadorService entrenadorService;
        Entrenador entrenador;
        bool busquedaEntrenador = false;
        string idEntrenador;
        public FormGestionEntrenador()
        {
            entrenadorService = new EntrenadorService(ConfigConnection.ConnectionString);
            InitializeComponent();
            CargarListaEntrenadores();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEntrenador_Click(object sender, EventArgs e)
        {
            tabControlEntrenador.SelectedIndex = 1;
        }

        private void btnUpdateEntrenador_Click(object sender, EventArgs e)
        {
            tabControlEntrenador.SelectedIndex = 1;
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            tabControlEntrenador.SelectedIndex = 2;
        }
        //Consultar entrenador
        private void CargarListaEntrenadores()
        {
            ConsultaEntrenadorRespuesta respuesta = new ConsultaEntrenadorRespuesta();
            respuesta = entrenadorService.ConsultarTodos();
            var entrenadores = respuesta.Entrenadores.ToList();
            if (entrenadores.Count != 0 || entrenadores != null)
            {
                dataGridEntrenadores.DataSource = entrenadores;
                textTotal.Text = entrenadorService.Totalizar().Cuenta.ToString();
                textHombres.Text = entrenadorService.TotalizarTipo("M").Cuenta.ToString();
                textMujeres.Text = entrenadorService.TotalizarTipo("F").Cuenta.ToString();
            }
        }
        private void EliminarRegistro(string id)
        {
            string mensaje = entrenadorService.Eliminar(id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BuscarPorSexo(string sexo)
        {
            BusquedaEntrenadorRespuesta respuesta = new BusquedaEntrenadorRespuesta();
            respuesta = entrenadorService.BuscarPorSexo(sexo);
            var registro = respuesta.Entrenador;
            if (registro != null)
            {
                dataGridEntrenadores.DataSource = null;
                var entrenadores = new List<Entrenador> { registro };
                dataGridEntrenadores.DataSource = entrenadores;
            }
            else
            {
                dataGridEntrenadores.DataSource = null;
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
                CargarListaEntrenadores();
                labelAlerta.Visible = false;
                pictureAlerta.Visible = false;
            }
        }
        private void dataGridEntrenadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (dataGridEntrenadores.DataSource != null)
            {
                if (dataGridEntrenadores.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    id = Convert.ToString(dataGridEntrenadores.CurrentRow.Cells["Identificacion"].Value.ToString());
                    string msg = "Desea eliminar este registro " + id + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarRegistro(id);
                        CargarListaEntrenadores();
                    }
                }
            }
            else
            {
                if (dataGridEntrenadores.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Registro entrenador
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventanaCargar = new OpenFileDialog();
            DialogResult dr = ventanaCargar.ShowDialog();
            if (dr == DialogResult.OK)
            {
                picturePerfil.Image = Image.FromFile(ventanaCargar.FileName);
            }
        }
        private Entrenador MapearDatosEntrenador()
        {
            entrenador = new Entrenador();
            entrenador.Identificacion = textID.Text;
            entrenador.TipoDeIdentificacion = comboTipoID.Text;
            entrenador.Nombres = textNombres.Text;
            entrenador.Apellidos = textApellidos.Text;
            entrenador.FechaDeNacimiento = dateTimeFechaDeNacimiento.Value;
            entrenador.Direccion = textDireccion.Text;
            entrenador.Sexo = comboSexoRegistro.Text;
            entrenador.Telefono = textTelefono.Text;
            entrenador.CorreoElectronico = textCorreo.Text;
            entrenador.HorasExtrasDeTrabajo = 0;
            entrenador.DiasDeTrabajo = 0;
            entrenador.MesesDeContrato = 0;
            entrenador.TipoDeContrato = "Ninguno";
            using (MemoryStream ms = new MemoryStream())
            {
                picturePerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                entrenador.ImagenPerfil = ms.ToArray();
            }
            return entrenador;
        }
        private void btnRegistrarEntrenador_Click_1(object sender, EventArgs e)
        {
            Entrenador entrenador = MapearDatosEntrenador();
            string mensaje = entrenadorService.Guardar(entrenador);
            MessageBox.Show(mensaje, "Mensaje de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private void btnModificarEntrenador_Click_1(object sender, EventArgs e)
        {
            Entrenador entrenador = MapearDatosEntrenador();
            string mensaje = entrenadorService.Modificar(entrenador);
            MessageBox.Show(mensaje, "Mensaje de modificacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }
        private void BuscarPorId(string busqueda)
        {
            BusquedaEntrenadorRespuesta respuesta = new BusquedaEntrenadorRespuesta();
            respuesta = entrenadorService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Entrenador;
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

                busquedaEntrenador = true;
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
            BusquedaEntrenadorRespuesta respuesta = new BusquedaEntrenadorRespuesta();
            respuesta = entrenadorService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Entrenador;
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
                busquedaEntrenador = true;
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
            string busqueda = textSearchContrato.Text;
            if (textSearchContrato.Text != "" && textSearchContrato.Text != "Buscar")
            {
                BuscarPorId(busqueda);
                BuscarPorNombre(busqueda);
                if (busquedaEntrenador == false)
                {
                    labelAlerta.Text = "No se encontraron los datos buscados";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
                else
                {
                    if (busquedaEntrenador == true)
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
            btnCloseSearchContrato.Visible = true;
            textSearch.Visible = true;
            string busqueda = textSearch.Text;
            if (textSearch.Text != "" && textSearch.Text != "Buscar")
            {
                BuscarPorId(busqueda);
                BuscarPorNombre(busqueda);
                if (busquedaEntrenador == false)
                {
                    labelAlerta.Text = "No se encontraron los datos buscados";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
                else
                {
                    if (busquedaEntrenador == true)
                    {
                        labelAlerta.Visible = false;
                        pictureAlerta.Visible = false;
                    }
                }
            }
        }

        private void btnCloseSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            btnCloseSearchContrato.Visible = false;
            textSearch.Visible = false;
            textSearch.Text = "Buscar";
            labelAlerta.Visible = false;
            pictureAlerta.Visible = false;
        }
        //Contrato entrenador
        private void BuscarPorIdContrato(string busqueda)
        {
            BusquedaEntrenadorRespuesta respuesta = new BusquedaEntrenadorRespuesta();
            respuesta = entrenadorService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Entrenador;
            if (buscado != null)
            {
                panelContrato.Enabled = true;
                idEntrenador = buscado.Identificacion;
                textNombresContrato.Text = buscado.Nombres;
                textApellidosContrato.Text = buscado.Apellidos;
                dateFechaNacimientoContrato.Value = buscado.FechaDeNacimiento;
                comboSexoContrato.Text = buscado.Sexo;
                busquedaEntrenador = true;
                using (MemoryStream ms = new MemoryStream(buscado.ImagenPerfil))
                {
                    // Carga la imagen desde el MemoryStream
                    Image imagen = Image.FromStream(ms);
                    // Asigna la imagen al control PictureBox
                    picturePerfilContrato.Image = imagen;
                }
            }
        }
        private void BuscarPorNombreContrato(string busqueda)
        {
            BusquedaEntrenadorRespuesta respuesta = new BusquedaEntrenadorRespuesta();
            respuesta = entrenadorService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Entrenador;
            if (buscado != null)
            {
                panelContrato.Enabled = true;
                idEntrenador = buscado.Identificacion;
                textNombresContrato.Text = buscado.Nombres;
                textApellidosContrato.Text = buscado.Apellidos;
                dateFechaNacimientoContrato.Value = buscado.FechaDeNacimiento;
                comboSexoContrato.Text = buscado.Sexo;
                busquedaEntrenador = true;
                using (MemoryStream ms = new MemoryStream(buscado.ImagenPerfil))
                {
                    // Carga la imagen desde el MemoryStream
                    Image imagen = Image.FromStream(ms);
                    // Asigna la imagen al control PictureBox
                    picturePerfilContrato.Image = imagen;
                }
            }
        }

        private void textSearchContrato_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textSearchContrato.Text;
            if (textSearchContrato.Text != "" && textSearchContrato.Text != "Buscar")
            {
                BuscarPorIdContrato(busqueda);
                BuscarPorNombreContrato(busqueda);
                if (busquedaEntrenador == false)
                {
                    labelAlerta.Text = "No se encontraron los datos buscados";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
                else
                {
                    if (busquedaEntrenador == true)
                    {
                        labelAlerta.Visible = false;
                        pictureAlerta.Visible = false;
                    }
                }
            }
        }

        private void textSearchContrato_Enter(object sender, EventArgs e)
        {
            if (textSearchContrato.Text == "Buscar")
            {
                textSearchContrato.Text = "";
            }
        }

        private void textSearchContrato_Leave(object sender, EventArgs e)
        {
            if (textSearchContrato.Text == "")
            {
                textSearchContrato.Text = "Buscar";
                labelAlerta.Visible = false;
                pictureAlerta.Visible = false;
            }
        }

        private void btnSearchContrato_Click(object sender, EventArgs e)
        {
            btnCloseSearchContrato.Visible = true;
            btnSearchContrato.Visible = false;
            textSearchContrato.Visible = true;
        }

        private void btnCloseSearchContrato_Click(object sender, EventArgs e)
        {
            btnCloseSearchContrato.Visible = false;
            btnSearchContrato.Visible = true;
            textSearchContrato.Visible = false;
            textSearchContrato.Text = "Buscar";
        }

        private void btnRegistrarContrato_Click(object sender, EventArgs e)
        {
            BusquedaEntrenadorRespuesta respuesta = new BusquedaEntrenadorRespuesta();
            respuesta = entrenadorService.BuscarPorIdentificacion(idEntrenador);
            var buscado = respuesta.Entrenador;
            if (buscado != null)
            {
                string mensaje = entrenadorService.Modificar(buscado);
                MessageBox.Show(mensaje, "Mensaje de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                CargarListaEntrenadores();
            }
        }
        private void btnModificarContrato_Click(object sender, EventArgs e)
        {
            BusquedaEntrenadorRespuesta respuesta = new BusquedaEntrenadorRespuesta();
            respuesta = entrenadorService.BuscarPorIdentificacion(idEntrenador);
            var buscado = respuesta.Entrenador;
            if (buscado != null)
            {
                buscado.TipoDeContrato = comboTipoContrato.Text;
                buscado.MesesDeContrato = Convert.ToInt32(textMesesContrato.Text);
                buscado.DiasDeTrabajo = Convert.ToInt32(textDiasContrato.Text);
                buscado.HorasExtrasDeTrabajo = Convert.ToInt32(textHorasExtrasContrato.Text);
                buscado.PagoDeSalario = Convert.ToInt32(labelPagoNomina.Text);
                string mensaje = entrenadorService.Modificar(buscado);
                MessageBox.Show(mensaje, "Mensaje de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                CargarListaEntrenadores();
            }
        }
    }
}
