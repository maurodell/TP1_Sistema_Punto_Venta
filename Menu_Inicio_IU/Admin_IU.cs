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
using BLL;
using Seguridad;
using System.Text.RegularExpressions;

namespace Menu_Inicio_IU
{
    public partial class Admin_IU : Form
    {
        BEClsAdministrador pEmpleadoAdmin;
        BEClsCajero pEmpleadoCaj;
        BLLUsuarios listaEmp;
        BLLClsAdministrador BLLAdmin;
        BLLClsCajero BLLCajero;
        BLLClsSucursal oBLLSuc;
        frmSucursales listSuc;
        ClsEncriptar passEncrip;
        BEClsEmpleado oBEEmp;
        DTOUser dtoUser;
        public Admin_IU()
        {
            InitializeComponent();
            listaEmp = new BLLUsuarios();
            oBLLSuc = new BLLClsSucursal();
            passEncrip = new ClsEncriptar();
            AcutalizarCmb();
            BLLAdmin = new BLLClsAdministrador();
            BLLCajero = new BLLClsCajero();
        }
        void AcutalizarCmb()
        {
            cmbSucursal.DataSource = null;
            cmbSucursal.DataSource = oBLLSuc.ListarTodos();
            cmbSucursal.ValueMember = "codigo";
            cmbSucursal.DisplayMember = "codigo";
            cmbSucursal.Refresh();
        }
        public void CargarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = listaEmp.ListarTodos();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
        public void CargarGrillaTodos()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = listaEmp.ListarFalse();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            int borradoDatos = 0;
            if (txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Las contraseñas no coincicen");
            }
            else
            {
                bool respuesta = Regex.IsMatch(txtDNI.Text, "^([0-9]+$)");
                if (respuesta == false)
                {
                    MessageBox.Show("No escribio un Número", "ERROR");
                }
                else
                {
                    if (txtNumCaj.Text.Equals(string.Empty))
                    {
                        pEmpleadoAdmin = new BEClsAdministrador();

                        pEmpleadoAdmin.Nombre = txtNombre.Text;
                        pEmpleadoAdmin.Apellido = txtApellido.Text;
                        pEmpleadoAdmin.DNI = Convert.ToInt32(txtDNI.Text);
                        pEmpleadoAdmin.Email = txtEmail.Text;
                        pEmpleadoAdmin.Sucursal = (BEClsSucursal)cmbSucursal.SelectedItem;
                        pEmpleadoAdmin.Pass = passEncrip.Encriptar(txtPass.Text);

                        if (BLLAdmin.Crear(pEmpleadoAdmin) == false)
                        {
                            MessageBox.Show("Existe un cliente con este DNI");
                            borradoDatos = 1;
                        }

                    }
                    else
                    {
                        pEmpleadoCaj = new BEClsCajero();

                        pEmpleadoCaj.Nombre = txtNombre.Text;
                        pEmpleadoCaj.Apellido = txtApellido.Text;
                        pEmpleadoCaj.DNI = Convert.ToInt32(txtDNI.Text);
                        pEmpleadoCaj.Email = txtEmail.Text;
                        pEmpleadoCaj.NumCaja = Convert.ToInt32(txtNumCaj.Text);
                        pEmpleadoCaj.Sucursal = (BEClsSucursal)cmbSucursal.SelectedItem;
                        pEmpleadoCaj.Pass = passEncrip.Encriptar(txtPass.Text);

                        if (BLLCajero.Crear(pEmpleadoCaj) == false)
                        {
                            MessageBox.Show("Existe un cliente con el mismo DNI");
                            borradoDatos = 1;
                        }
                    }

                    if (borradoDatos == 0)
                    {
                        CargarGrilla();
                        Limpiar();
                    }
                }
            }
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Desea eliminar el Empleado: " + txtNombre.Text + "", "Alerta!", MessageBoxButtons.YesNo);
                if (Resultado == DialogResult.Yes && dataGridView1.SelectedRows.Count > 0)
                {
                    if (BLLAdmin.Baja(oBEEmp.Codigo) == false)
                    {
                        MessageBox.Show("La Baja no se pudo realizar");
                    }
                    CargarGrilla();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumCaj.Text.Equals(string.Empty))
                {
                    pEmpleadoAdmin = new BEClsAdministrador();
                    pEmpleadoAdmin.Codigo = Convert.ToInt32(txtLegajo.Text);
                    pEmpleadoAdmin.Nombre = txtNombre.Text;
                    pEmpleadoAdmin.Apellido = txtApellido.Text;
                    pEmpleadoAdmin.DNI = Convert.ToInt32(txtDNI.Text);
                    pEmpleadoAdmin.Email = txtEmail.Text;
                    pEmpleadoAdmin.Sucursal = (BEClsSucursal)cmbSucursal.SelectedItem;
                    pEmpleadoAdmin.Pass = passEncrip.Encriptar(txtPass.Text);

                    if (BLLAdmin.Crear(pEmpleadoAdmin) == false)
                    {
                        MessageBox.Show("No se puede Modificar");
                    }
                }
                else
                {
                    pEmpleadoCaj = new BEClsCajero();
                    pEmpleadoCaj.Codigo = Convert.ToInt32(txtLegajo.Text);
                    pEmpleadoCaj.Nombre = txtNombre.Text;
                    pEmpleadoCaj.Apellido = txtApellido.Text;
                    pEmpleadoCaj.DNI = Convert.ToInt32(txtDNI.Text);
                    pEmpleadoCaj.Email = txtEmail.Text;
                    pEmpleadoCaj.NumCaja = Convert.ToInt32(txtNumCaj.Text);
                    pEmpleadoCaj.Sucursal = (BEClsSucursal)cmbSucursal.SelectedItem;
                    pEmpleadoCaj.Pass = passEncrip.Encriptar(txtPass.Text);

                    if (BLLCajero.Crear(pEmpleadoCaj) == false)
                    {
                        MessageBox.Show("No se puede Modificar");
                    }
                }
                CargarGrilla();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        private void Admin_IU_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarGrilla();
            ControlUser();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //verifica que txt de buscar apellido tenga texto y el de DNI este vacío
                if (txtBusApe.Text.Length > 0 && txtBusDni.Text.Equals(string.Empty))
                {
                    if (listaEmp.ListarXApellido(txtBusApe.Text).Count > 0)
                    {
                        this.dataGridView1.DataSource = null;
                        this.dataGridView1.DataSource = listaEmp.ListarXApellido(txtBusApe.Text);
                        this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                        this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                    }
                    else
                    {
                        MessageBox.Show("No se pueden encontrar registros");
                    }

                }
                //verifica que txt de buscar DNI tenga texto y el de Apellido este vacío
                else if (txtBusDni.Text.Length > 0 && txtBusApe.Text.Equals(string.Empty))
                {
                    //utilizo solo la BLL de Empleado Administrador
                    BEClsEmpleado buscado = BLLAdmin.LeerObjeto(Convert.ToInt32(txtBusDni.Text));
                    if (buscado == null) { MessageBox.Show("DNI no encontrado!"); }
                    else
                    {
                        MessageBox.Show($"Nombre: {buscado.Nombre}\n" +
                                        $"Apellido: {buscado.Apellido}\n" +
                                        $"Email: {buscado.Email}\n" +
                                        $"Id Sucursal: {buscado.Sucursal.Codigo}");
                    }
                }
                else { MessageBox.Show("Ingresar datos de forma correcta"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (BLLAdmin.Alta(oBEEmp.Codigo) == false)
                {
                    MessageBox.Show("El Alta no se pudo realizar");
                }
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtNumCaj.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtRePass.Text = string.Empty;
            txtNumCaj.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtBusApe.Text = string.Empty;
            txtBusDni.Text = string.Empty;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Limpiar();
            oBEEmp = (BEClsEmpleado)this.dataGridView1.CurrentRow.DataBoundItem;

            //Debo hacer esta comprobación para iniciarlizar un objeto Cajero y traerme el número de caja
            if (oBEEmp.Puesto == "Cajero")
            {
                pEmpleadoCaj = dataGridView1.SelectedRows[0].DataBoundItem as BEClsCajero;
                this.txtNumCaj.Text = pEmpleadoCaj.NumCaja.ToString();
            }
            //Si no es cajero completa los datos sin el Número Caja
            this.txtLegajo.Text = oBEEmp.Codigo.ToString();
            this.txtNombre.Text = oBEEmp.Nombre.ToString();
            this.txtApellido.Text = oBEEmp.Apellido.ToString();
            this.txtDNI.Text = oBEEmp.DNI.ToString();
            this.txtEmail.Text = oBEEmp.Email.ToString();
            this.cmbSucursal.SelectedValue = oBEEmp.Sucursal.Codigo;
            this.txtPass.Text = passEncrip.Desencriptar(oBEEmp.Pass.ToString());
        }
        public void ControlUser()
        {
            dtoUser = new DTOUser();

            if (dtoUser.VPU == "Cajero")
            {
                btnAlta.Enabled = false;
                btnBaja.Enabled = false;
                btnCrear.Enabled = false;
                btnMod.Enabled = false;
                btnSuc.Enabled = false;
            }
        }
        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnMosTodo_Click(object sender, EventArgs e)
        {
            CargarGrillaTodos();
        }

        private void btnMosOcultar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
