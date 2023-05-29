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

namespace UI
{
    public partial class FormSumario : Form
    {
        public FormSumario()
        {
            InitializeComponent();
        }
        public void MostrarDatos()
        {

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void FormSumario_Load(object sender, EventArgs e)
        {
            Reloj.Interval = 1000; // Intervalo de 1 segundo
            Reloj.Start();
        }
    }
}
