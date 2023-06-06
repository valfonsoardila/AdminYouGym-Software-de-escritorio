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
    public partial class FormGestionAdministrador : Form
    {
        AdministradorService administradorService;
        Administrador administrador;
        bool busquedaAdministrador = false;
        string idAdministrador;
        public FormGestionAdministrador()
        {
            administradorService = new AdministradorService(ConfigConnection.ConnectionString);
            InitializeComponent();
            CargarListaAdministradores();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            tabControlAdmins.SelectedIndex = 1;
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            tabControlAdmins.SelectedIndex = 1;
        }
        //Consultar administrador
        private void CargarListaAdministradores()
        {
            ConsultaAdministradorRespuesta respuesta = new ConsultaAdministradorRespuesta();
            respuesta = administradorService.ConsultarTodos();
            var administradores = respuesta.Administradores.ToList();
            if (administradores.Count != 0 || administradores != null)
            {
                dataGridAdministrador.DataSource = administradores;
                textTotal.Text = administradorService.Totalizar().Cuenta.ToString();
                textHombres.Text = administradorService.TotalizarTipo("M").Cuenta.ToString();
                textMujeres.Text = administradorService.TotalizarTipo("F").Cuenta.ToString();
            }
        }
        private void EliminarRegistro(string id)
        {
            string mensaje = administradorService.Eliminar(id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BuscarPorSexo(string sexo)
        {
            BusquedaAdministradorRespuesta respuesta = new BusquedaAdministradorRespuesta();
            respuesta = administradorService.BuscarPorSexo(sexo);
            var registro = respuesta.Administrador;
            if (registro != null)
            {
                dataGridAdministrador.DataSource = null;
                var administradores = new List<Administrador> { registro };
                dataGridAdministrador.DataSource = administradores;
            }
            else
            {
                dataGridAdministrador.DataSource = null;
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
                CargarListaAdministradores();
                labelAlerta.Visible = false;
                pictureAlerta.Visible = false;
            }
        }

        private void dataGridAdministrador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (dataGridAdministrador.DataSource != null)
            {
                if (dataGridAdministrador.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    id = Convert.ToString(dataGridAdministrador.CurrentRow.Cells["Identificacion"].Value.ToString());
                    string msg = "Desea eliminar este registro " + id + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarRegistro(id);
                        CargarListaAdministradores();
                    }
                }
            }
            else
            {
                if (dataGridAdministrador.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Registrar Adminstrador
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventanaCargar = new OpenFileDialog();
            DialogResult dr = ventanaCargar.ShowDialog();
            if (dr == DialogResult.OK)
            {
                picturePerfil.Image = Image.FromFile(ventanaCargar.FileName);
            }
        }
        private Administrador MapearDatosAdministrador()
        {
            administrador = new Administrador();
            administrador.Identificacion = textID.Text;
            administrador.TipoDeIdentificacion = comboTipoID.Text;
            administrador.Nombres = textNombres.Text;
            administrador.Apellidos = textApellidos.Text;
            administrador.FechaDeNacimiento = dateTimeFechaDeNacimiento.Value;
            administrador.Direccion = textDireccion.Text;
            administrador.Sexo = comboSexo.Text;
            administrador.Telefono = textTelefono.Text;
            administrador.CorreoElectronico = textCorreo.Text;
            administrador.Rol = "Administrador";
            using (MemoryStream ms = new MemoryStream())
            {
                picturePerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                administrador.ImagenPerfil = ms.ToArray();
            }
            return administrador;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Administrador administrador = MapearDatosAdministrador();
            string mensaje = administradorService.Guardar(administrador);
            MessageBox.Show(mensaje, "Mensaje de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            CargarListaAdministradores();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Administrador administrador = MapearDatosAdministrador();
            string mensaje = administradorService.Modificar(administrador);
            MessageBox.Show(mensaje, "Mensaje de modificacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            CargarListaAdministradores();
        }
        private void BuscarPorId(string busqueda)
        {
            BusquedaAdministradorRespuesta respuesta = new BusquedaAdministradorRespuesta();
            respuesta = administradorService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Administrador;
            if (buscado != null)
            {
                textID.Text = buscado.Identificacion;
                comboTipoID.Text = buscado.TipoDeIdentificacion;
                textNombres.Text = buscado.Nombres;
                textApellidos.Text = buscado.Apellidos;
                dateTimeFechaDeNacimiento.Value = buscado.FechaDeNacimiento;
                comboSexo.Text = buscado.Sexo;
                textDireccion.Text = buscado.Direccion;
                textTelefono.Text = buscado.Telefono;
                textCorreo.Text = buscado.CorreoElectronico;
                busquedaAdministrador = true;
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
            BusquedaAdministradorRespuesta respuesta = new BusquedaAdministradorRespuesta();
            respuesta = administradorService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Administrador;
            if (buscado != null)
            {
                textID.Text = buscado.Identificacion;
                comboTipoID.Text = buscado.TipoDeIdentificacion;
                textNombres.Text = buscado.Nombres;
                textApellidos.Text = buscado.Apellidos;
                dateTimeFechaDeNacimiento.Value = buscado.FechaDeNacimiento;
                comboSexo.Text = buscado.Sexo;
                textDireccion.Text = buscado.Direccion;
                textTelefono.Text = buscado.Telefono;
                textCorreo.Text = buscado.CorreoElectronico;
                busquedaAdministrador = true;
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
                if (busquedaAdministrador == false)
                {
                    labelAlerta.Text = "No se encontraron los datos buscados";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
                else
                {
                    if (busquedaAdministrador == true)
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
                if (busquedaAdministrador == false)
                {
                    labelAlerta.Text = "No se encontraron los datos buscados";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
                else
                {
                    if (busquedaAdministrador == true)
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
    }
}
