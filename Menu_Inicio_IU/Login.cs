using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Seguridad;

namespace Menu_Inicio_IU
{
    public partial class Login : Form
    {
        public Login()
        {
            userLogin = new BLLLogin();
            frmMenu = new Menu();
            Descencriptar = new ClsEncriptar();
            InitializeComponent();
        }
        BLLLogin userLogin;
        Menu frmMenu;
        ClsEncriptar Descencriptar;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string passBD = Descencriptar.Desencriptar(userLogin.Get(txtEmail.Text, txtPass.Text));
                if (passBD.Equals(txtPass.Text))
                {
                    this.Hide();
                    frmMenu.Show();
                }
                else
                {
                    MessageBox.Show("El password o Email ingresados son incorrectos!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
