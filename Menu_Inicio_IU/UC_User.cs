using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace Menu_Inicio_IU
{
    public partial class UC_User : UserControl
    {
        public UC_User()
        {
            dtoUser = new DTOUser();
            InitializeComponent();
        }
        DTOUser dtoUser;
        private void UC_User_Load(object sender, EventArgs e)
        {
            CargarUser();
        }
        void CargarUser()
        {
            if (dtoUser != null)
            {
                txtUserLogin.Text = dtoUser.VNN;
                txtPuestoLogin.Text = dtoUser.VPU;
            }
            
        }
    }
}
