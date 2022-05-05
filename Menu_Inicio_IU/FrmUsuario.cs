﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using MPP;

namespace Menu_Inicio_IU
{
    public partial class FrmUsuario : Form
    {
        BEClsEmpleado pEmpleado;
        BEClsUsuario listaEmp;
        BLLClsEmpleadoABM empAMB;
        BLLClsSucursal oBLLSuc;
        frmSucursales listSuc;
        public FrmUsuario()
        {
            InitializeComponent();
            empAMB = new BLLClsEmpleadoABM();
            listaEmp = BEClsUsuario.Instanciar();
            oBLLSuc = new BLLClsSucursal();
            AcutalizarCmb();
        }
        public void AcutalizarCmb()
        {
            cmbSucursal.DataSource = null;
            cmbSucursal.DataSource = oBLLSuc.ListarTodos();
            cmbSucursal.ValueMember = "codigo";
            cmbSucursal.DisplayMember = "codigo";
            cmbSucursal.Refresh();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string puesto = cmbPuesto.Text.ToLower();

            if (puesto == "administrativo")
            {
                pEmpleado = new BEClsAdministrador();
                
            }
            else
            {
                pEmpleado = new BEClsCajero();
            }

            if (txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Las contraseñas no coincicen");
            }
            else
            {
                pEmpleado.Nombre = txtNombre.Text;
                pEmpleado.Apellido = txtApellido.Text;
                pEmpleado.Email = txtEmail.Text;
                pEmpleado.Sucursal = (BEClsSucursal)cmbSucursal.SelectedItem;
                pEmpleado.Pass = txtPass.Text;

                empAMB.Crear(pEmpleado);

                this.DialogResult = DialogResult.OK;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ModificarEmpleado(BEClsEmpleado empChange)
        {
            btnAceptar.Visible = false;
            btnCambiar.Visible = true;
            txtPass.Enabled = false;
            txtRePass.Enabled = false;
            txtLegajo.Visible = true;
            txtLegajo.Enabled = false;
            lblLeg.Visible = true;
            txtLegajo.Text = empChange.Codigo.ToString();

            txtNombre.Text = empChange.Nombre;
            txtApellido.Text = empChange.Apellido;
            txtEmail.Text = empChange.Email;
            cmbPuesto.SelectedItem = empChange.Puesto;
            cmbSucursal.SelectedItem = empChange.Sucursal;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            pEmpleado = new BEClsEmpleado();
            pEmpleado.Nombre = txtNombre.Text;
            pEmpleado.Apellido = txtApellido.Text;
            pEmpleado.Codigo = Convert.ToInt32(txtLegajo.Text);
            pEmpleado.Email = txtEmail.Text;
            pEmpleado.Sucursal = (BEClsSucursal)cmbSucursal.SelectedItem;
            pEmpleado.Puesto = cmbPuesto.SelectedItem.ToString();

            empAMB.Modificar(pEmpleado);
            this.DialogResult = DialogResult.OK;
        }

        private void btnSuc_Click(object sender, EventArgs e)
        {
            listSuc = new frmSucursales();
            DialogResult resp = listSuc.ShowDialog();
            if (resp == DialogResult.OK)
            {
                listSuc.Close();
            }
            AcutalizarCmb();
        }
    }
}
