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
    public partial class FormGestionProducto : Form
    {
        public FormGestionProducto()
        {
            InitializeComponent();
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
        }

        private void btnVerVendios_Click(object sender, EventArgs e)
        {
            tabControlProducto.SelectedIndex = 3;
        }
    }
}
