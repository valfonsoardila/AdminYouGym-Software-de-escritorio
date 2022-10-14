using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;
namespace Presentacion
{
    public partial class FormPapelera : Form
    {
        Papelera papelera = new Papelera();
        PapeleraService papeleraService = new PapeleraService();
        public FormPapelera()
        {
            InitializeComponent();
            cargarArchivo(papeleraService);
        }
        //Abre el openFileDialog y captura la ruta del bloc de notas'
        public void cargarArchivo(PapeleraService papeleraService)
        {
            PapeleraConsultaResponse papeleraConsultaResponse = papeleraService.Consultar();
            if (papeleraConsultaResponse.Papeleras.Count>0)
            {
                foreach (var item in papeleraConsultaResponse.Papeleras)
                {
                    string idCaja=item.Id_CajaDelete;
                    string fechaApertura = item.FechaDeAperturaDelete;
                    string fechaCierre = item.FechaDeCierreDelete;
                    string estado = item.EstadoDelete;
                    double monto = item.MontoDelete;
                    dataGridHistorialCajas.Rows.Add(idCaja, fechaApertura, fechaCierre, estado, monto);
                }
            }
            else
            {
                if (papeleraConsultaResponse.Papeleras.Count == 0)
                {
                    dataGridHistorialCajas = null;
                }
            }
        }
        private void ConsultarPapelera()
        {
            PapeleraConsultaResponse papeleraConsultaResponse = papeleraService.Consultar();
            if (papeleraConsultaResponse.Encontrado == true)
            {
                foreach (var item in papeleraConsultaResponse.Papeleras)
                {
                    string idCaja = item.Id_CajaDelete;
                    string fechaApertura = item.FechaDeAperturaDelete;
                    string fechaCierre = item.FechaDeCierreDelete;
                    string estado = item.EstadoDelete;
                    double monto = item.MontoDelete;
                    dataGridHistorialCajas.Rows.Add(idCaja, fechaApertura, fechaCierre, estado, monto);
                }
            }
            else
            {
                string mensaje = papeleraConsultaResponse.Mensaje;
                MessageBox.Show(mensaje.ToString());
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnVaciarPapelera_Click(object sender, EventArgs e)
        {
            PapeleraService papeleraService = new PapeleraService();
            string mensaje=papeleraService.EliminarHistorial();
            MessageBox.Show(mensaje.ToString());
            dataGridHistorialCajas.DataSource = null;
            ConsultarPapelera();
        }
    }
}
