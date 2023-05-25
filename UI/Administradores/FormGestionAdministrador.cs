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
        public FormGestionAdministrador()
        {
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
    }
}
