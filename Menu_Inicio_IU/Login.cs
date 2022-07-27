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
using System.Text.RegularExpressions;
using BE;

namespace Menu_Inicio_IU
{
    public partial class Login : Form
    {
        public Login()
        {
            userLogin = new BLLLogin();
            frmMenu = new Menu();
            Descencriptar = new ClsEncriptar();
            dtoUser = new DTOUser();
            InitializeComponent();
        }
        BLLLogin userLogin;
        Menu frmMenu;
        ClsEncriptar Descencriptar;
        BEClsEmpleado user;
        DTOUser dtoUser;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuesta = Regex.IsMatch(txtEmail.Text, "^([\\w-]+\\.)*?[\\w-]+@[\\w-]+\\.([\\w-]+\\.)*?[\\w]+$");
                if (respuesta)
                {
                    user = userLogin.Get(txtEmail.Text);
                    if (user != null)
                    {
                        string passBD = Descencriptar.Desencriptar(user.Pass);
                        if (passBD.Equals(txtPass.Text))
                        {
                            dtoUser.VNN = user.Nombre;
                            dtoUser.VPU = user.Puesto;
                            this.Hide();
                            frmMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Password ingresado incorrecto!", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no registrado!", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("El Email ingresado es incorrecto", "ERROR");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnMostrarPass_MouseClick(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '\0';
        }

        private void btnOcultar_MouseClick(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    }
}
