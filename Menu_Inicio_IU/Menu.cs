using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Inicio_IU
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_IU admin = new Admin_IU();
            admin.MdiParent = this;
            admin.Show();
        }

        private void crearNCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotaDeCredito NC = new frmNotaDeCredito();
            NC.MdiParent = this;
            NC.Show();
        }

        private void asignarResponsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignarNC AsignarNC = new frmAsignarNC();
            AsignarNC.MdiParent = this;
            AsignarNC.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
