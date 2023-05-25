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
    public partial class FormMembresia : Form
    {
        public FormMembresia()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMembership_Click(object sender, EventArgs e)
        {
            tabControlMembership.SelectedIndex = 1;
        }

        private void btnUpdateMembership_Click(object sender, EventArgs e)
        {
            tabControlMembership.SelectedIndex = 1;
        }
    }
}
