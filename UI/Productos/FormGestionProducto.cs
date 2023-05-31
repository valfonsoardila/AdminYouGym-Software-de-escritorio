using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using Logica;
using Entidades;
using static System.Windows.Forms.AxHost;
using System.Windows.Controls;

namespace UI
{
    public partial class FormGestionProducto : Form
    {
        ProductoService productoService;
        GimnasioService gimnasioService;
        ArchivoRespaldoService archivoRespaldoService = new ArchivoRespaldoService();
        ProductoFacturaTxtService productoTxtService = new ProductoFacturaTxtService();
        ProductoVencidoTxtService productoVencidoTxtService = new ProductoVencidoTxtService();
        IdUsuarioTxtService idEmpleadoTxtService = new IdUsuarioTxtService();
        EmailService emailService = new EmailService();
        RutasTxtService rutasTxtService = new RutasTxtService();
        List<Producto> productos;
        List<Gimnasio> gimnasios;
        Producto producto;
        CajaRegistradoraService cajaRegistradoraService;
        //Variables
        public string idEmpleado;
        string[] ReferenciasProductosAVender = new string[100];
        int[] CantidadesProductosAVender = new int[100];
        string referencia;
        string rutasVendidos;
        string referenciaBotonDatagrid;
        int TotalSeleccion = 1;
        int cantidadDeRegistros = 20;
        int totalRegistros;
        int paginaSeleccionada = 0;
        int paginaSeleccion;
        int totalPaginas;
        int contador;
        int cantidadDrogueria;
        bool cajaAbierta;
        string referenciaProducto;
        int cantidadProducto;
        int cantidadARestar;
        string nombreProducto;
        string detalleProducto;
        double precioProducto;
        string loteProducto;
        string marcaProducto;
        string estadoProducto;
        DateTime fechaDeRegistro;
        DateTime fechaDeVencimiento;
        string viaProducto;
        string tipoProducto;
        double porcentajeDeVenta;
        double precioDeNegocio;
        double gananciaDeProducto;
        int cantidadEstante;
        int cantidadVitrinas;
        int cantidadNeveras;
        int cantidad;
        object sender;
        EventArgs e;
        int x;
        int i = 0;
        bool encontrado = false;
        public FormGestionProducto()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            gimnasioService = new GimnasioService(ConfigConnection.ConnectionString);
            InitializeComponent();
            IniciarOperaciones();
            ConsultarGimnasio();
        }
        private void IniciarOperaciones()
        {
            var idEmpleado = idEmpleadoTxtService.Consultar();
            if (idEmpleado.IdEmpleadoTxts[0].Identificacion == "1003377848")
            {
                btnRespaldarInventario.Visible = true;
                labelExportar.Visible = true;
            }
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
            Thread calcularEstadoAutomatico = new Thread(CalculoDeEstadoAutomatico);
            calcularEstadoAutomatico.Start();
        }
        public void CalculoDeEstadoAutomatico()
        {
            string referencia = "";
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            foreach (DataGridViewRow fila in dataGridProductos.Rows)
            {
                int i = 0;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (i == 6)
                    {
                        referencia = Convert.ToString(fila.Cells[6].Value);
                        respuesta = productoService.BuscarPorReferencia(referencia);
                        if (respuesta.Producto != null)
                        {
                            var producto = respuesta.Producto;
                            string mensaje = productoService.ModificarEstado(producto);
                        }
                    }
                    i = i + 1;
                }
            }
        }
        private void BuscarPorEstado()
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            string estado = "Abierta";
            respuesta = cajaRegistradoraService.BuscarPorEstado(estado);
            if (respuesta.CajaRegistradora != null)
            {
                var cajasRegistradoras = new List<Caja> { respuesta.CajaRegistradora };
                labelCash.Text = respuesta.CajaRegistradora.VentaDelDia.ToString();
                labelBase.Text = respuesta.CajaRegistradora.MontoInicial.ToString();
                cajaAbierta = true;
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
        private void ConsultarYLlenarGridDeProductos(int paginaSelecciona)
        {
            paginaSeleccionada = paginaSelecciona;
            BuscarPorEstado();
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            string ubicacion = comboFiltroUbicacion.Text;
            string estado = comboFiltroEstado.Text;
            string tipo = comboFiltroTipo.Text;
            if (ubicacion == "Todos" && estado == "Todos" && tipo == "Todos")
            {
                textTotal.Enabled = true;
                textCuarentena.Enabled = true;
                textVigentes.Enabled = true;
                dataGridProductos.DataSource = null;
                respuesta = productoService.ConsultarTodos();
                productos = respuesta.Productos.ToList();
                if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
                {
                    totalRegistros = productoService.Totalizar().Cuenta;
                    totalPaginas = (int)Math.Ceiling(decimal.Parse(totalRegistros.ToString()) / decimal.Parse(cantidadDeRegistros.ToString()));
                    dataGridProductos.DataSource = respuesta.Productos.OrderBy(d => d.Referencia).Skip(paginaSeleccionada * cantidadDeRegistros).Take(cantidadDeRegistros).ToList();
                    textNumeroPagina.Text = paginaSeleccionada.ToString();
                    dataGridProductos.ClearSelection();
                    Eliminar.Visible = true;
                    textTotal.Text = productoService.Totalizar().Cuenta.ToString();
                    textVigentes.Text = productoService.TotalizarTipo("Vigente").Cuenta.ToString();
                    textCuarentena.Text = productoService.TotalizarTipo("Cuarentena").Cuenta.ToString();
                    textVencido.Text = productoService.TotalizarTipo("Vencido").Cuenta.ToString();
                    MostrarAviso(false);
                }
                else
                {
                    if (respuesta.Productos == null || respuesta.Productos.Count == 0)
                    {
                        MostrarAviso(true);
                        Eliminar.Visible = false;
                    }
                }
            }
        }
        private void MostrarAviso(bool estado)
        {
            pictureAlerta.Visible = estado;
            labelAlerta.Visible = estado;
        }
        private void ConsultarGimnasio()
        {
            ConsultaGimnasioRespuesta respuesta = new ConsultaGimnasioRespuesta();
            respuesta = gimnasioService.ConsultarTodos();
            gimnasios = respuesta.Gimnasios.ToList();
            if (respuesta.Gimnasios.Count != 0 && respuesta.Gimnasios != null)
            {
                cantidadDrogueria = gimnasioService.Totalizar().Cuenta;
            }
        }
        private void BuscarPorReferencia()
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            string referencia = textSearchConsulta.Text;
            respuesta = productoService.BuscarPorReferencia(referencia);
            if (respuesta.Producto != null)
            {
                dataGridProductos.DataSource = null;
                var productos = new List<Producto> { respuesta.Producto };
                dataGridProductos.DataSource = productos;
                encontrado = true;
            }
            else
            {
                if (respuesta.Producto == null)
                {
                    //ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                }
            }
        }
        private void BuscarPorUbicacion()
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            string ubicacion = comboUbicacion.Text;
            respuesta = productoService.BuscarPorUbicacion(ubicacion);
            if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
            {
                dataGridProductos.DataSource = respuesta.Productos;
            }
            else
            {
                if (respuesta.Productos == null || respuesta.Productos.Count == 0)
                {
                    labelAlerta.Visible = true;
                    labelAlerta.Text = "No hay medicametos de este tipo";
                    string msg = "¡No se encontró medicamentos asociados!";
                    MessageBox.Show(msg, "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboFiltroEstado.Text = "Todos";
                    comboFiltroTipo.Text = "Todos";
                }
            }
        }
        private void BuscarPorTipo()
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            string tipo = comboFiltroTipo.Text;
            respuesta = productoService.BuscarPorTipo(tipo);
            if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
            {
                dataGridProductos.DataSource = respuesta.Productos;
            }
            else
            {
                if (respuesta.Productos == null || respuesta.Productos.Count == 0)
                {
                    labelAlerta.Visible = true;
                    labelAlerta.Text = "No hay medicametos de este tipo";
                    string msg = "¡No se encontró medicamentos asociados!";
                    MessageBox.Show(msg, "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboFiltroTipo.Text = "Todos";
                }
            }
        }
        private void GestionVender(string referencia, int cantidad)
        {
            TotalSeleccion = dataGridProductos.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Column1"].Value)).Count();
            if (cantidadDrogueria == 1)
            {
                if (cantidadEstante > 0)
                {
                    if (cajaAbierta == true)
                    {
                        if (TotalSeleccion >= 0)
                        {
                            //Obtener referencias de productos
                            foreach (DataGridViewRow row in dataGridProductos.Rows)
                            {
                                if (Convert.ToBoolean(row.Cells["Column1"].Value))
                                {
                                    ReferenciasProductosAVender[i] = referencia;
                                    CantidadesProductosAVender[i] = cantidad;
                                    dataGridProductos.CurrentRow.DefaultCellStyle.BackColor = Color.CadetBlue;
                                    i = i + 1;

                                }
                            }
                        }
                        else
                        {
                            if (TotalSeleccion == 0)
                            {
                                string mensaje = "No se ha cargado los productos para la factura";
                                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        string mensaje = "No hay caja abierta, asi que no se puede cargar productos a la factura";
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string mensaje = "No hay ubicaciones registradas por lo que tampoco hay productos registrados";
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string mensaje = "No se ha registrado datos de drogueria, asi que no se puede generar factura";
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Producto CalculosDefactura()
        {
            producto = new Producto();
            producto.Cantidad = cantidadProducto - cantidadARestar;
            producto.Referencia = referenciaProducto;
            producto.Nombre = nombreProducto;
            producto.Lote = loteProducto;
            producto.Marca = marcaProducto;
            producto.FechaDeRegistro = fechaDeRegistro;
            producto.FechaDeVencimiento = fechaDeVencimiento;
            producto.Detalle = detalleProducto;
            producto.Tipo = tipoProducto;
            producto.PrecioDeNegocio = precioDeNegocio;
            producto.PorcentajeDeVenta = porcentajeDeVenta;
            return producto;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            tabControlProducto.SelectedIndex = 1;
        }

        private void btnUpdateProducto_Click(object sender, EventArgs e)
        {
            tabControlProducto.SelectedIndex = 1;
        }

        private void btnVerVencidos_Click(object sender, EventArgs e)
        {
            tabControlProducto.SelectedIndex = 2;
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
        }

        private void btnVerVendios_Click(object sender, EventArgs e)
        {
            tabControlProducto.SelectedIndex = 3;
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
        }
        private void VaciarArreglos()
        {
            for (int i = 0; i < 100; i++)
            {
                ReferenciasProductosAVender[i] = null;
                CantidadesProductosAVender[i] = 0;
            }
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            MapearMedicamentosFactura();
            FormFacturaDeProducto frm = new FormFacturaDeProducto();
            frm.ShowDialog();
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
            VaciarArreglos();
            i = 0;
        }
        private void MapearMedicamentosFactura()
        {
            ObtenerRutaDeGuardado();
            string referenciaARrecorrer;
            int cantidadARecorrer;
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            for (int i = 0; i <= 100; i++)
            {
                referenciaARrecorrer = ReferenciasProductosAVender[i];
                cantidadARecorrer = CantidadesProductosAVender[i];
                bool exixtencia = productoTxtService.FiltroReferencia(referenciaARrecorrer);
                if (exixtencia == false)
                {
                    cantidad = cantidadARecorrer;
                    if (referenciaARrecorrer != null && cantidadARecorrer != 0)
                    {
                        respuesta = productoService.BuscarPorReferencia(referenciaARrecorrer);
                        if (cantidadARecorrer <= respuesta.Producto.Cantidad)
                        {
                            var productos = new List<Producto> { respuesta.Producto };
                            referenciaProducto = respuesta.Producto.Referencia;
                            cantidadProducto = respuesta.Producto.Cantidad;
                            cantidadARestar = cantidad;
                            nombreProducto = respuesta.Producto.Nombre;
                            detalleProducto = respuesta.Producto.Detalle;
                            precioProducto = respuesta.Producto.PrecioDeVenta;
                            marcaProducto = respuesta.Producto.Marca;
                            fechaDeRegistro = respuesta.Producto.FechaDeRegistro;
                            fechaDeVencimiento = respuesta.Producto.FechaDeVencimiento;
                            loteProducto = respuesta.Producto.Lote;
                            tipoProducto = respuesta.Producto.Tipo;
                            precioDeNegocio = respuesta.Producto.PrecioDeNegocio;
                            porcentajeDeVenta = respuesta.Producto.PorcentajeDeVenta;
                            ProductoFacturaTxt productoTxt = new ProductoFacturaTxt(cantidadARestar, referenciaProducto, nombreProducto, detalleProducto, precioProducto);
                            string mensaje = productoTxtService.Guardar(productoTxt);

                            Producto producto = CalculosDefactura();
                            mensaje = productoService.ModificarCantidad(producto);
                        }
                        else
                        {
                            if (cantidad > respuesta.Producto.Cantidad)
                            {
                                string mensaje = "La cantidad de " + respuesta.Producto.Nombre + " en inventario no es suficiente vuelva a ingresarlo";
                                MessageBox.Show(mensaje, "Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (referenciaARrecorrer == null || cantidadARecorrer == 0)
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void ObtenerRutaDeGuardado()
        {
            RutasTxtConsultaResponse rutasTxtConsultaResponse = rutasTxtService.Consultar();
            if (rutasTxtConsultaResponse.RutasTxts.Count > 0)
            {
                foreach (var item in rutasTxtConsultaResponse.RutasTxts)
                {
                    rutasVendidos = item.RutaFacturasVenta;
                }
            }
        }
        private void EliminarProducto(string referencia)
        {
            string mensaje = productoService.Eliminar(referencia);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Eliminar.Visible = false;
        }
        private void EliminarArchivo()
        {
            string mensaje = archivoRespaldoService.EliminarHistorial();
            if (mensaje == "Archivo eliminado satisfactoriamente")
            {
                string msg = "Backup de la base de datos completada";
                MessageBox.Show(msg, "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CargarAlCorreo()
        {
            EmailConsultaResponse emailConsultaResponse = emailService.Consultar();
            if (emailConsultaResponse.Emails.Count > 0)
            {
                DateTime fechaActual = DateTime.Now;
                string fecha = fechaActual.ToString("dd-MM-yyyy");
                foreach (var item in emailConsultaResponse.Emails)
                {
                    String servidor = "smtp.gmail.com";
                    int puerto = 587;
                    String user = item.CorreoElectronicoOrigen;
                    String password = item.Contraseña;
                    MimeMessage message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Backup", user));
                    message.To.Add(new MailboxAddress("Destino", user));
                    message.Subject = "Backup AdminPharm";
                    BodyBuilder messageBody = new BodyBuilder();
                    messageBody.Attachments.Add(@"BackupDB " + fecha + ".xlsx");
                    messageBody.HtmlBody = "<b></b>";
                    message.Body = messageBody.ToMessageBody();

                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.CheckCertificateRevocation = false;

                    smtpClient.Connect(servidor, puerto, MailKit.Security.SecureSocketOptions.StartTls);
                    smtpClient.Authenticate(user, password);

                    smtpClient.Send(message);
                    smtpClient.Disconnect(true);
                }
            }
            EliminarArchivo();
        }
        //Copia de seguridad
        private void btnRespaldarInventario_Click(object sender, EventArgs e)
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            EmailConsultaResponse emailConsultaResponse = emailService.Consultar();
            if (emailConsultaResponse.Emails.Count > 0)
            {
                DateTime fechaActual = DateTime.Now;
                string fecha = fechaActual.ToString("dd-MM-yyyy");
                SLDocument sl = new SLDocument();
                int cabezera = 1;
                sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Productos");
                sl.SetCellValue("A" + cabezera, "Cantidad");
                sl.SetCellValue("B" + cabezera, "Referencia");
                sl.SetCellValue("C" + cabezera, "Nombre");
                sl.SetCellValue("D" + cabezera, "Detalle");
                sl.SetCellValue("E" + cabezera, "Fecha_De_Registro");
                sl.SetCellValue("F" + cabezera, "Fecha_De_Vencimiento");
                sl.SetCellValue("G" + cabezera, "Lote");
                sl.SetCellValue("H" + cabezera, "Laboratorio");
                sl.SetCellValue("I" + cabezera, "Estado");
                sl.SetCellValue("J" + cabezera, "Tipo");
                sl.SetCellValue("K" + cabezera, "Via");
                sl.SetCellValue("L" + cabezera, "Unidad");
                sl.SetCellValue("M" + cabezera, "Blister");
                sl.SetCellValue("N" + cabezera, "Caja");
                sl.SetCellValue("O" + cabezera, "Porcentaje_De_Venta");
                sl.SetCellValue("P" + cabezera, "Precio_De_Negocio");
                sl.SetCellValue("Q" + cabezera, "Precio_De_Venta");
                sl.SetCellValue("R" + cabezera, "Ganancia_Por_Producto");
                sl.SetCellValue("S" + cabezera, "Ubicacion");
                respuesta = productoService.BuscarPorEstado("Cuarentena");
                if (respuesta.Productos != null && respuesta.Productos.Count != 0)
                {
                    var productos = new List<Producto>();
                    for (int i = 0; i < respuesta.Productos.Count; i++)
                    {
                        productos.Add(respuesta.Productos[i]);
                    }
                    respuesta = productoService.BuscarPorEstado("Vigente");
                    if (respuesta.Productos != null && respuesta.Productos.Count != 0)
                    {
                        for (int i = 0; i < respuesta.Productos.Count; i++)
                        {
                            productos.Add(respuesta.Productos[i]);
                        }
                    }
                    BusquedaProductoRespuesta respuestaBusqueda = new BusquedaProductoRespuesta();
                    cabezera = 2;
                    for (int i = 0; i < productos.Count; i++)
                    {
                        var celda = productos[i];
                        foreach (var j in celda.Referencia)
                        {
                            int indice = cabezera;
                            SLStyle estiloFecha = new SLStyle();
                            SLStyle estiloEntero = new SLStyle();
                            estiloFecha.FormatCode = "dd/MM/yyyy";
                            estiloEntero.FormatCode = "####";
                            sl.SetColumnStyle(5, 6, estiloFecha);
                            sl.SetColumnStyle(2, estiloEntero);
                            respuestaBusqueda = productoService.BuscarPorReferencia(celda.Referencia);
                            if (respuestaBusqueda.Producto != null)
                            {
                                sl.SetCellValue("A" + indice, respuestaBusqueda.Producto.Cantidad);
                                sl.SetCellValue("B" + indice, respuestaBusqueda.Producto.Referencia);
                                sl.SetCellValue("C" + indice, respuestaBusqueda.Producto.Nombre);
                                sl.SetCellValue("D" + indice, respuestaBusqueda.Producto.Detalle);
                                sl.SetCellValue("E" + indice, respuestaBusqueda.Producto.FechaDeRegistro);
                                sl.SetCellValue("F" + indice, respuestaBusqueda.Producto.FechaDeVencimiento);
                                sl.SetCellValue("G" + indice, respuestaBusqueda.Producto.Lote);
                                sl.SetCellValue("H" + indice, respuestaBusqueda.Producto.Marca);
                                sl.SetCellValue("I" + indice, respuestaBusqueda.Producto.Estado);
                                sl.SetCellValue("J" + indice, respuestaBusqueda.Producto.Tipo);
                                sl.SetCellValue("K" + indice, respuestaBusqueda.Producto.ValorPorUnidad);
                                sl.SetCellValue("L" + indice, respuestaBusqueda.Producto.ValorPorBlister);
                                sl.SetCellValue("M" + indice, respuestaBusqueda.Producto.ValorPorPaquete);
                                sl.SetCellValue("N" + indice, respuestaBusqueda.Producto.PorcentajeDeVenta);
                                sl.SetCellValue("O" + indice, respuestaBusqueda.Producto.PrecioDeNegocio);
                                sl.SetCellValue("P" + indice, respuestaBusqueda.Producto.PrecioDeVenta);
                                sl.SetCellValue("Q" + indice, respuestaBusqueda.Producto.GananciaPorProducto);
                                sl.SetCellValue("R" + indice, respuestaBusqueda.Producto.Ubicacion);
                                indice = indice + 1;
                            }
                        }
                        cabezera = cabezera + 1;
                    }
                    sl.SaveAs("BackupDB " + fecha + ".xlsx");
                    CargarAlCorreo();
                }
                else
                {
                    string mensaje = "Aun no ha dado una correo de guardado para backups";
                    MessageBox.Show(mensaje, "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void textSearchConsulta_Enter(object sender, EventArgs e)
        {
            if (textSearchConsulta.Text == "Buscar en existencia")
            {
                textSearchConsulta.Text = "";
            }
        }

        private void btnCloseSearchConsulta_Click(object sender, EventArgs e)
        {
            textSearchConsulta.Visible = false;
            btnCloseSearchConsulta.Visible = false;
            textSearchConsulta.Text = "Buscar en existencia";
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
        }

        private void btnSearchConsulta_Click(object sender, EventArgs e)
        {
            //BuscarPorReferencia();
            textSearchConsulta.Visible = true;
            btnCloseSearchConsulta.Visible = true;
            cantidadDeRegistros = int.Parse(textTotal.Text);
            totalPaginas = 0;
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
        }

        private void comboFiltroUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ubicacion = comboFiltroUbicacion.Text;
            if (ubicacion != "Todos")
            {
                ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
                respuesta = productoService.BuscarPorUbicacion(ubicacion);
                productos = respuesta.Productos.ToList();
                dataGridProductos.DataSource = null;
                if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
                {
                    dataGridProductos.DataSource = respuesta.Productos;
                    MostrarAviso(false);
                    comboFiltroTipo.Text = "Filtro tipo";
                }
                else
                {
                    if (respuesta.Productos == null || respuesta.Productos.Count == 0)
                    {
                        MostrarAviso(true);
                        Eliminar.Visible = false;
                        labelAlerta.Text = "No hay productos por ubicacion";
                    }
                }
            }
            else
            {
                if (ubicacion == "Todos")
                {
                    MostrarAviso(false);
                    ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                    comboFiltroTipo.Text = "Filtro tipo";
                }
            }
        }

        private void comboFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tipo = comboFiltroTipo.Text;
            if (Tipo != "Todos")
            {
                ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
                respuesta = productoService.BuscarPorTipo(Tipo);
                productos = respuesta.Productos.ToList();
                dataGridProductos.DataSource = null;
                if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
                {
                    dataGridProductos.DataSource = respuesta.Productos;
                    MostrarAviso(false);
                    comboFiltroUbicacion.Text = "Filtro ubicacion";
                }
                else
                {
                    if (respuesta.Productos == null || respuesta.Productos.Count == 0)
                    {
                        MostrarAviso(true);
                        Eliminar.Visible = false;
                        labelAlerta.Text = "No hay productos por tipo";
                    }
                }
            }
            else
            {
                if (Tipo == "Todos")
                {
                    MostrarAviso(false);
                    ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                    comboFiltroUbicacion.Text = "Filtro ubicacion";
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cantidadDeRegistros = 20;
            paginaSeleccionada = 0;
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
        }

        private void textNumeroPagina_Enter(object sender, EventArgs e)
        {
            if (textNumeroPagina.Text != "")
            {
                textNumeroPagina.Text = "";
            }
        }

        private void textNumeroPagina_Leave(object sender, EventArgs e)
        {
            if (textNumeroPagina.Text == "")
            {
                textNumeroPagina.Text = "0";
            }
        }

        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            paginaSeleccionada = paginaSeleccionada - 1;
            if (paginaSeleccionada <= totalPaginas && paginaSeleccionada >= 0)
            {
                textNumeroPagina.Text = paginaSeleccionada.ToString();
                IniciarOperaciones();
                if (paginaSeleccionada < 1)
                {
                    btnPaginaAnterior.Enabled = false;
                    string mensaje = "Llego al inicio de las paginas";
                    MessageBox.Show(mensaje, "Paginado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnPaginaAnterior.Enabled = false;
                    paginaSeleccionada = paginaSeleccionada + 1;
                }
            }
        }

        private void btnSiguientePagina_Click(object sender, EventArgs e)
        {
            paginaSeleccionada = paginaSeleccionada + 1;
            if (paginaSeleccionada <= totalPaginas)
            {
                IniciarOperaciones();
                btnPaginaAnterior.Enabled = true;
                if (paginaSeleccion == totalPaginas)
                {
                    string mensaje = "No hay mas paginas para mostrar";
                    MessageBox.Show(mensaje, "Paginado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSiguientePagina.Enabled = false;
                    paginaSeleccionada = paginaSeleccionada - 1;
                }
            }
        }
        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string referencia;
            if (dataGridProductos.DataSource != null)
            {
                if (dataGridProductos.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    referencia = Convert.ToString(dataGridProductos.CurrentRow.Cells["Referencia"].Value.ToString());
                    string nombre = Convert.ToString(dataGridProductos.CurrentRow.Cells["Nombre"].Value.ToString());
                    var respuesta = MessageBox.Show("Desea eliminar el producto " + nombre + "?", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        EliminarProducto(referencia);
                        ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                    }
                }
            }
            else
            {
                if (dataGridProductos.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textSearchConsulta_TextChanged(object sender, EventArgs e)
        {
            if (textSearchConsulta.Text != "")
            {
                BuscarPorReferencia();
                if (encontrado == false)
                {
                    dataGridProductos.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridProductos.Rows)
                    {
                        fila.Visible = false;
                    };
                    foreach (DataGridViewRow fila in dataGridProductos.Rows)
                    {
                        int i = 0;
                        foreach (DataGridViewCell celda in fila.Cells)
                        {
                            if (i == 8)
                            {
                                if ((celda.Value.ToString().ToUpper()).IndexOf(textSearchConsulta.Text.ToUpper()) == 0)
                                {
                                    fila.Visible = true;
                                    break;
                                }
                                else
                                {
                                    if ((celda.Value.ToString() == (textSearchConsulta.Text.ToUpper())))
                                    {
                                        fila.Visible = true;
                                        break;
                                    }
                                }
                            }
                            i = i + 1;
                        }
                    }
                }
            }
            else
            {
                if (textSearchConsulta.Text == "")
                {
                    ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                }
            }
        }

        private void textNumeroPagina_TextChanged(object sender, EventArgs e)
        {
            if (textNumeroPagina.Text != "")
            {
                paginaSeleccionada = int.Parse(textNumeroPagina.Text);
                ConsultarYLlenarGridDeProductos(paginaSeleccionada);
            }
        }

        private void dataGridProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridProductos.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        //Stock menor a 20
                        if (Convert.ToInt32(e.Value) >= 20)
                        {
                            e.CellStyle.BackColor = Color.DarkGreen;
                            e.CellStyle.ForeColor = Color.White;
                        }
                        //Stock menor a 20
                        if (Convert.ToInt32(e.Value) <= 20)
                        {
                            e.CellStyle.BackColor = Color.LightSalmon;
                            e.CellStyle.ForeColor = Color.Red;
                        }
                        //Stock menor a 10
                        if (Convert.ToInt32(e.Value) <= 10)
                        {
                            e.CellStyle.BackColor = Color.Salmon;
                            e.CellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                if (this.dataGridProductos.Columns[e.ColumnIndex].Name == "PrecioDeVenta")
                {
                    if (e.Value != null)
                    {
                        if (e.Value.GetType() != typeof(System.DBNull))
                        {
                            //Toda la columna
                            if (Convert.ToInt32(e.Value) != 0)
                            {
                                e.CellStyle.BackColor = Color.Yellow;
                                e.CellStyle.ForeColor = Color.Black;
                            }
                            //Resaltar casillas en 0
                            if (Convert.ToInt32(e.Value) == 0)
                            {
                                e.CellStyle.BackColor = Color.Salmon;
                                e.CellStyle.ForeColor = Color.Red;
                            }
                        }
                    }
                }
            }
            if (this.dataGridProductos.Columns[e.ColumnIndex].Name == "Ubicacion")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        //Toda la columna
                        if (Convert.ToString(e.Value) != "A")
                        {
                            e.CellStyle.BackColor = Color.Purple;
                            e.CellStyle.ForeColor = Color.White;
                        }

                    }
                }
            }
            if (this.dataGridProductos.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        //Stock vencidos
                        if (Convert.ToString(e.Value) == "Vencido")
                        {
                            e.CellStyle.BackColor = Color.DarkRed;
                            e.CellStyle.ForeColor = Color.White;
                        }

                    }
                }
            }
            if (this.dataGridProductos.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        //Stock vencidos
                        if (Convert.ToString(e.Value) == "Cuarentena")
                        {
                            e.CellStyle.BackColor = Color.BlueViolet;
                            e.CellStyle.ForeColor = Color.White;
                        }

                    }
                }
            }
        }

        private void dataGridProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nombre;
            if (dataGridProductos.DataSource != null)
            {
                if (dataGridProductos.Columns[e.ColumnIndex].Name == "Cash")
                {
                    referenciaBotonDatagrid = Convert.ToString(dataGridProductos.CurrentRow.Cells["Referencia"].Value.ToString());
                    nombre = Convert.ToString(dataGridProductos.CurrentRow.Cells["Nombre"].Value.ToString());
                    var respuesta = MessageBox.Show("Desea vender el producto " + nombre + "?", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        TotalSeleccion = 1;
                        CantidadesProductosAVender[0] = 1;
                        ReferenciasProductosAVender[0] = referenciaBotonDatagrid;
                        MapearMedicamentosFactura();
                        btnVender_Click(sender, e);
                        ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                    }
                }
                else
                {
                    if (dataGridProductos.Columns[e.ColumnIndex].Name == "Vencido")
                    {
                        BusquedaProductoRespuesta busqueda = new BusquedaProductoRespuesta();
                        referenciaBotonDatagrid = Convert.ToString(dataGridProductos.CurrentRow.Cells["Referencia"].Value.ToString());
                        nombre = Convert.ToString(dataGridProductos.CurrentRow.Cells["Nombre"].Value.ToString());
                        var respuesta = MessageBox.Show("Desea Sacar este producto de inventario " + nombre + "?", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            busqueda = productoService.BuscarPorReferencia(referenciaBotonDatagrid);
                            if (busqueda.Producto != null)
                            {
                                string estado = busqueda.Producto.Estado;
                                if (estado == "Vencido")
                                {
                                    referenciaProducto = busqueda.Producto.Referencia;
                                    cantidadProducto = busqueda.Producto.Cantidad;
                                    nombreProducto = busqueda.Producto.Nombre;
                                    detalleProducto = busqueda.Producto.Detalle;
                                    fechaDeRegistro = busqueda.Producto.FechaDeRegistro;
                                    fechaDeVencimiento = busqueda.Producto.FechaDeVencimiento;
                                    loteProducto = busqueda.Producto.Lote;
                                    marcaProducto = busqueda.Producto.Marca;
                                    estadoProducto = busqueda.Producto.Estado;
                                    tipoProducto = busqueda.Producto.Tipo;
                                    porcentajeDeVenta = busqueda.Producto.PorcentajeDeVenta;
                                    precioDeNegocio = busqueda.Producto.PrecioDeNegocio;
                                    precioProducto = busqueda.Producto.PrecioDeVenta;
                                    gananciaDeProducto = busqueda.Producto.GananciaPorProducto;
                                    ProductoVencidoTxt productoTxt = new ProductoVencidoTxt(
                                        cantidadProducto, referenciaProducto, nombreProducto, detalleProducto, fechaDeRegistro,
                                        fechaDeVencimiento, loteProducto, marcaProducto, estadoProducto, tipoProducto, viaProducto,
                                        porcentajeDeVenta, precioDeNegocio, precioProducto, gananciaDeProducto);
                                    productoVencidoTxtService.Guardar(productoTxt);
                                    productoService.Eliminar(referenciaProducto);
                                }
                                else
                                {
                                    if (estado != "Vencido")
                                    {
                                        string msg = "Solo se pueden sacar del inventario productos vencidos";
                                        MessageBox.Show(msg, "Vencidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                        }
                    }
                }
            }
            else
            {
                if (dataGridProductos.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            paginaSeleccionada = 0;
            cantidadDeRegistros = 20;
            CalculoDeEstadoAutomatico();
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
        }

        private void dataGridProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int valor = Convert.ToInt32(dataGridProductos.CurrentRow.Cells["CantidadVenta"].Value);
            string referencia = Convert.ToString(dataGridProductos.CurrentRow.Cells["Referencia"].Value);
            if (valor != 0)
            {
                if (dataGridProductos.Columns[e.ColumnIndex].Name == "CantidadVenta")
                {
                    GestionVender(referencia, valor);
                }
            }
        }

        private void textSearchConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarPorReferencia();
            }
        }
    }
}
