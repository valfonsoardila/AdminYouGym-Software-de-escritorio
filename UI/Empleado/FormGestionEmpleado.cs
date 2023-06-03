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
    public partial class FormGestionEmpleado : Form
    {
        EmpleadoService empleadoService;
        Empleado empleado;
        bool busquedaEmpleado = false;
        string idEmpleado;
        public FormGestionEmpleado()
        {
            empleadoService = new EmpleadoService(ConfigConnection.ConnectionString);
            InitializeComponent();
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
        //Consultar empleado
        private void CargarListaEmpleados()
        {
            ConsultaEmpleadoRespuesta respuesta = new ConsultaEmpleadoRespuesta();
            respuesta = empleadoService.ConsultarTodos();
            var empleados = respuesta.Empleados.ToList();
            if (empleados.Count != 0 || empleados != null)
            {
                dataGridEmpleados.DataSource = empleados;
                textTotal.Text = empleadoService.Totalizar().Cuenta.ToString();
                textHombres.Text = empleadoService.TotalizarTipo("M").Cuenta.ToString();
                textMujeres.Text = empleadoService.TotalizarTipo("F").Cuenta.ToString();
            }
        }
        private void EliminarRegistro(string id)
        {
            string mensaje = empleadoService.Eliminar(id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BuscarPorSexo(string sexo)
        {
            ConsultaEmpleadoRespuesta respuesta = new ConsultaEmpleadoRespuesta();
            respuesta = empleadoService.BuscarPorSexo(sexo);
            var registro = respuesta.Empleados.ToList();
            if (registro != null)
            {
                dataGridEmpleados.DataSource = null;
                dataGridEmpleados.DataSource = registro;
            }
            else
            {
                dataGridEmpleados.DataSource = null;
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
                CargarListaEmpleados();
                labelAlerta.Visible = false;
                pictureAlerta.Visible = false;
            }
        }
        private void dataGridEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (dataGridEmpleados.DataSource != null)
            {
                if (dataGridEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    id = Convert.ToString(dataGridEmpleados.CurrentRow.Cells["Identificacion"].Value.ToString());
                    string msg = "Desea eliminar este registro " + id + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarRegistro(id);
                        CargarListaEmpleados();
                    }
                }
            }
            else
            {
                if (dataGridEmpleados.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Regstrar empleado
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventanaCargar = new OpenFileDialog();
            DialogResult dr = ventanaCargar.ShowDialog();
            if (dr == DialogResult.OK)
            {
                picturePerfil.Image = Image.FromFile(ventanaCargar.FileName);
            }
        }
        private Empleado MapearDatosEmpleado()
        {
            empleado = new Empleado();
            empleado.Identificacion = textID.Text;
            empleado.TipoDeIdentificacion = comboTipoID.Text;
            empleado.Nombres = textNombres.Text;
            empleado.Apellidos = textApellidos.Text;
            empleado.FechaDeNacimiento = dateTimeFechaNacimiento.Value;
            empleado.Direccion = textDireccion.Text;
            empleado.Sexo = comboSexo.Text;
            empleado.Telefono = textTelefono.Text;
            empleado.CorreoElectronico = textCorreo.Text;
            empleado.Rol = "Empleado";
            using (MemoryStream ms = new MemoryStream())
            {
                picturePerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                empleado.ImagenPerfil = ms.ToArray();
            }
            return empleado;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Empleado empleado = MapearDatosEmpleado();
            string mensaje = empleadoService.Guardar(empleado);
            MessageBox.Show(mensaje, "Mensaje de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleado empleado = MapearDatosEmpleado();
            string mensaje = empleadoService.Modificar(empleado);
            MessageBox.Show(mensaje, "Mensaje de modificacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private void BuscarPorId(string busqueda)
        {
            BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
            respuesta = empleadoService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Empleado;
            if (buscado != null)
            {
                textID.Text = buscado.Identificacion;
                comboTipoID.Text = buscado.TipoDeIdentificacion;
                textNombres.Text = buscado.Nombres;
                textApellidos.Text = buscado.Apellidos;
                dateTimeFechaNacimiento.Value = buscado.FechaDeNacimiento;
                comboSexo.Text = buscado.Sexo;
                textDireccion.Text = buscado.Direccion;
                textTelefono.Text = buscado.Telefono;
                textCorreo.Text = buscado.CorreoElectronico;
                busquedaEmpleado = true;
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
            BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
            respuesta = empleadoService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.Empleado;
            if (buscado != null)
            {
                textID.Text = buscado.Identificacion;
                comboTipoID.Text = buscado.TipoDeIdentificacion;
                textNombres.Text = buscado.Nombres;
                textApellidos.Text = buscado.Apellidos;
                dateTimeFechaNacimiento.Value = buscado.FechaDeNacimiento;
                comboSexo.Text = buscado.Sexo;
                textDireccion.Text = buscado.Direccion;
                textTelefono.Text = buscado.Telefono;
                textCorreo.Text = buscado.CorreoElectronico;
                busquedaEmpleado = true;
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
                if (busquedaEmpleado == false)
                {
                    labelAlerta.Text = "No se encontraron los datos buscados";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
                else
                {
                    if (busquedaEmpleado == true)
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
                if (busquedaEmpleado == false)
                {
                    labelAlerta.Text = "No se encontraron los datos buscados";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
                else
                {
                    if (busquedaEmpleado == true)
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
