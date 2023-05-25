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
        public FormGestionEntrenador()
        {
            InitializeComponent();
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
    }
}
