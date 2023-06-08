using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using Logica;
using Entidades;
using System.Xml;

namespace UI
{
    public partial class FormAjustes : Form
    {
        EmailService emailService = new EmailService();
        CadenaConexionXMLService cadenaConexionService = new CadenaConexionXMLService();
        RutasTxtService rutasTxtService = new RutasTxtService();
        Email email = new Email();
        RutasTxt rutasTxt = new RutasTxt();
        CadenaConexionXML cadenaConexion = new CadenaConexionXML();
        GimnasioService gimnasioService;
        Gimnasio gimnasio;
        List<Gimnasio> gimnasios;
        string idGimnasio = "#Gym";
        string Server;
        string newServer;
        string connectionString;
        string originalConnection;
        string primeraCadena;
        string segundaCadenaModificada;
        string segundaCadenaOriginal;
        string RutaFacturasVenta;
        string RutaCierreDeCaja;
        string RutaProductosVendidos;
        public FormAjustes()
        {
            gimnasioService = new GimnasioService(ConfigConnection.ConnectionString);
            InitializeComponent();
            BuscarPorId();
            EncontrarCadenaDeConexion();
            EstablecerCarpetasRaiz(rutasTxtService);
            EstablecerCorreo();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BuscarPorId()
        {
            BusquedaGimnasioRespuesta respuesta = new BusquedaGimnasioRespuesta();
            respuesta = gimnasioService.BuscarPorId(idGimnasio);
            if (respuesta.Gimnasio != null)
            {
                var gimnasios = new List<Gimnasio> { respuesta.Gimnasio };
                dataGridInfoGimnasio.DataSource = gimnasios;
                textNombreGimnasio.Text = respuesta.Gimnasio.NombreGimnasio;
                textNIT.Text = respuesta.Gimnasio.NIT;
                textCamaraDeComercio.Text = respuesta.Gimnasio.CodigoDeCamara;
                textFraseDistintiva.Text = respuesta.Gimnasio.FraseDistintiva;
                comboRegimen.Text = respuesta.Gimnasio.Regimen;
                textPBX.Text = respuesta.Gimnasio.PBX;
                textDireccion.Text = respuesta.Gimnasio.Direccion;
                textTelefono.Text = respuesta.Gimnasio.Telefono;
                labelAdvertencia.Visible = false;
                btnRegistrarInfo.Enabled = false;
            }
            else
            {
                if (respuesta.Gimnasio == null)
                {
                    labelAdvertencia.Visible = true;
                    btnRegistrarInfo.Enabled = true;
                }
            }
        }
        private void Limpiar()
        {
            dataGridInfoGimnasio.DataSource = null;
            textNombreGimnasio.Text = "";
            textNIT.Text = "";
            textFraseDistintiva.Text = "";
            comboRegimen.Text = "";
            textPBX.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
        }
        private void ModificarCorreo()
        {
            EmailConsultaResponse emailConsultaResponse = emailService.Consultar();
            if (emailConsultaResponse.Emails.Count > 0)
            {
                foreach (var item in emailConsultaResponse.Emails)
                {
                    string correoOrigen = item.CorreoElectronicoOrigen.ToString();
                    email.CorreoElectronicoOrigen = textCorreo.Text;
                    email.CorreoElectronicoDestino = textCorreo.Text;
                    email.Contraseña = textContraseña.Text;
                    emailService.ModificarEmail(email, correoOrigen);
                }
            }
            else
            {
                if (emailConsultaResponse.Emails.Count == 0)
                {
                    email.CorreoElectronicoOrigen = textCorreo.Text;
                    email.CorreoElectronicoDestino = textCorreo.Text;
                    email.Contraseña = textContraseña.Text;
                    emailService.Guardar(email);
                }
            }
        }
        private void ModificarCarpetasRaiz(RutasTxtService rutasTxtService)
        {
            RutasTxtConsultaResponse rutasTxtConsultaResponse = rutasTxtService.Consultar();
            if (rutasTxtConsultaResponse.RutasTxts.Count > 0)
            {
                foreach (var item in rutasTxtConsultaResponse.RutasTxts)
                {
                    string referencia = item.Referencia.ToString();
                    rutasTxt.Referencia = item.Referencia;
                    rutasTxt.RutaCierreDeCaja = textRutaCierreDeCaja.Text;
                    rutasTxt.RutaFacturasVenta = textRutaFacturaVentas.Text;
                    rutasTxt.RutaProductosVendidos = textRutaVendido.Text;
                    rutasTxtService.ModificarRutasTxt(rutasTxt, referencia);
                }
            }
            else
            {
                if (rutasTxtConsultaResponse.RutasTxts.Count == 0)
                {
                    RutaCierreDeCaja = textRutaCierreDeCaja.Text;
                    RutaFacturasVenta = textRutaFacturaVentas.Text;
                    RutaProductosVendidos = textRutaVendido.Text;
                    rutasTxt.Referencia = 1;
                    rutasTxt.RutaCierreDeCaja = RutaCierreDeCaja;
                    rutasTxt.RutaFacturasVenta = RutaFacturasVenta;
                    rutasTxt.RutaProductosVendidos = RutaProductosVendidos;
                    rutasTxtService.Guardar(rutasTxt);
                }
            }
        }
        private void EstablecerCorreo()
        {
            EmailConsultaResponse emailConsultaResponse = emailService.Consultar();
            if (emailConsultaResponse.Emails.Count > 0)
            {
                foreach (var item in emailConsultaResponse.Emails)
                {
                    textCorreo.Text = item.CorreoElectronicoOrigen;
                    textContraseña.Text = item.Contraseña;
                }
            }
            else
            {
                if (emailConsultaResponse.Emails.Count == 0)
                {
                    if (textCorreo.Text != "" && textContraseña.Text != "")
                    {
                        email.CorreoElectronicoOrigen = textCorreo.Text;
                        email.Contraseña = textContraseña.Text;
                        email.CorreoElectronicoDestino = textCorreo.Text;
                        emailService.Guardar(email);
                    }
                }
            }
        }
        private void EstablecerCarpetasRaiz(RutasTxtService rutasTxtService)
        {
            RutasTxtConsultaResponse rutasTxtConsultaResponse = rutasTxtService.Consultar();
            if (rutasTxtConsultaResponse.RutasTxts.Count > 0)
            {
                foreach (var item in rutasTxtConsultaResponse.RutasTxts)
                {
                    textRutaCierreDeCaja.Text = item.RutaCierreDeCaja;
                    textRutaFacturaVentas.Text = item.RutaFacturasVenta;
                    textRutaVendido.Text = item.RutaProductosVendidos;
                    RutaCierreDeCaja = textRutaCierreDeCaja.Text;
                    RutaFacturasVenta = textRutaFacturaVentas.Text;
                    RutaProductosVendidos = textRutaVendido.Text;
                }
            }
            else
            {
                if (rutasTxtConsultaResponse.RutasTxts.Count == 0)
                {
                    if (textRutaCierreDeCaja.Text != "" && textRutaFacturaVentas.Text != "")
                    {
                        RutaCierreDeCaja = textRutaCierreDeCaja.Text;
                        RutaFacturasVenta = textRutaFacturaVentas.Text;
                        RutaProductosVendidos = textRutaVendido.Text;
                        rutasTxt.Referencia = 1;
                        rutasTxt.RutaCierreDeCaja = RutaCierreDeCaja;
                        rutasTxt.RutaFacturasVenta = RutaFacturasVenta;
                        rutasTxt.RutaProductosVendidos = RutaProductosVendidos;
                        rutasTxtService.Guardar(rutasTxt);
                    }
                }
            }
        }
        private Gimnasio MapearGimnasio()
        {
            gimnasio = new Gimnasio();
            gimnasio.IdGimnasio = "#Gym";
            gimnasio.NombreGimnasio = textNombreGimnasio.Text;
            gimnasio.NIT = textNIT.Text;
            gimnasio.CodigoDeCamara = textCamaraDeComercio.Text;
            gimnasio.FraseDistintiva = textFraseDistintiva.Text;
            gimnasio.Regimen = comboRegimen.Text;
            gimnasio.PBX = textPBX.Text;
            gimnasio.Direccion = textDireccion.Text;
            gimnasio.Telefono = textTelefono.Text;
            return gimnasio;
        }

        private void btnRegistrarInfo_Click(object sender, EventArgs e)
        {
            Gimnasio gimnasio = MapearGimnasio();
            string mensaje = gimnasioService.Guardar(gimnasio);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            BuscarPorId();
            ModificarCadenaConexion();
            EstablecerCarpetasRaiz(rutasTxtService);
            EstablecerCorreo();
        }
        private void btnEliminarInfo_Click(object sender, EventArgs e)
        {
            string mensaje = gimnasioService.Eliminar(idGimnasio);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }
        private void btnModificarInfo_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Gimnasio gimnasio = MapearGimnasio();
                string mensaje = gimnasioService.Modificar(gimnasio);
                MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                BuscarPorId();
                ModificarCadenaConexion();
                ModificarCarpetasRaiz(rutasTxtService);
                ModificarCorreo();
            }
        }

        private void btnBuscarRutaFacturaVenta_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ruta = dialog.SelectedPath;
                textRutaFacturaVentas.Text = ruta;
            }
        }

        private void btnBuscarRutaCierreCaja_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ruta = dialog.SelectedPath;
                textRutaCierreDeCaja.Text = ruta;
            }
        }

        private void btnBuscarCadenaConexion_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ruta = dialog.SelectedPath;
                textCadenaConexion.Text = ruta;
            }
        }
        private void btnBuscarRutaVendido_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ruta = dialog.SelectedPath;
                textRutaVendido.Text = ruta;
            }
        }
        private void ModificarCadenaConexion()
        {
            if (textCadenaConexion.Text != "")
            {
                primeraCadena = "        <add name=" + '"' + "conexion" + '"' + " connectionString=" + '"';
                segundaCadenaModificada = "Server=" + newServer + ";Database=AdminPharm;Trusted_Connection = True; MultipleActiveResultSets = true" + '"' + " />";
                segundaCadenaOriginal = Server + '"' + " />";

                cadenaConexion.Cadena = primeraCadena + segundaCadenaModificada;
                originalConnection = primeraCadena + segundaCadenaOriginal;
                cadenaConexionService.Modificar(cadenaConexion, originalConnection);
            }
        }
        private void EncontrarCadenaDeConexion()
        {
            connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            labelConnectionString.Text = connectionString;
            XmlDocument xmlDocument = new XmlDocument();
            string configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath;
            xmlDocument.Load(configFile);
            foreach (XmlElement xmlElement in xmlDocument.DocumentElement)
            {
                if (xmlElement.Name.Equals("connectionStrings"))
                {
                    foreach (XmlNode node in xmlElement.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "conexion")
                        {
                            Server = node.Attributes[1].Value;
                        }
                    }
                }
            }
        }

        private void textCadenaConexion_TextChanged(object sender, EventArgs e)
        {
            newServer = textCadenaConexion.Text;
        }
    }
}
