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

namespace Menu_Inicio_IU
{
    public partial class frmSucursales : Form
    {
        BEClsSucursal objBESuc;
        BLLClsSucursal objBLLSuc;
        
        public frmSucursales()
        {
            InitializeComponent();
            objBESuc = new BEClsSucursal();
            objBLLSuc = new BLLClsSucursal();
            txtCodSuc.Enabled = false;
        }
        void CargarGrilla()
        {
            this.dgvSuc.DataSource = null;
            this.dgvSuc.DataSource = objBLLSuc.ListarTodos();
            this.dgvSuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSuc.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
        void Limpiar()
        {
            txtDirSuc.Text = null;
            txtTelSuc.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAltaSuc_Click(object sender, EventArgs e)
        {
            try
            {
                objBESuc.Direccion = txtDirSuc.Text;
                objBESuc.Telefono = txtTelSuc.Text;
                objBLLSuc.Crear(objBESuc);
                CargarGrilla();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void btnBajaSuc_Click(object sender, EventArgs e)
        {
            BEClsSucursal objSucElimina = dgvSuc.SelectedRows[0].DataBoundItem as BEClsSucursal;
            DialogResult respuesta;
            respuesta = MessageBox.Show("Al eliminar la Sucursal, esta no dejara registros en la Base de datos,\n" +
                                        "Desea proseguir?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                if (objBLLSuc.Eliminar(objSucElimina) == false)
                {
                    MessageBox.Show("Para dar de baja la Localidad no debe estar asociada a ningun empleado");
                }
                else
                {
                    CargarGrilla();
                    Limpiar();
                }
            }
        }

        private void dgvSuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModSuc_Click(object sender, EventArgs e)
        {
            try
            {
                objBESuc.Direccion = txtDirSuc.Text;
                objBESuc.Telefono = txtTelSuc.Text;
                objBLLSuc.Modificar(objBESuc);
                CargarGrilla();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objBESuc = (BEClsSucursal)this.dgvSuc.CurrentRow.DataBoundItem;
            txtCodSuc.Text = objBESuc.Codigo.ToString();
            txtTelSuc.Text = objBESuc.Telefono.ToString();
            txtDirSuc.Text = objBESuc.Direccion.ToString();
            txtCodSuc.Enabled = false;
        }
    }
}
