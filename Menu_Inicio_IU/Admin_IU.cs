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
    public partial class Admin_IU : Form
    {
        FrmUsuario frmUser;
        BEClsUsuario listaEmp;
        BLLClsEmpleadoABM abmEmpleados;
        BEClsEmpleado oBEEmp;
        public Admin_IU()
        {
            InitializeComponent();
            listaEmp = BEClsUsuario.Instanciar();
            abmEmpleados = new BLLClsEmpleadoABM();
            oBEEmp = new BEClsEmpleado();
            txtBuscador.Text = "Ingresar Legajo";
        }
        public void CargarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = abmEmpleados.ListarTodos();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmUser = new FrmUsuario();
            DialogResult resp = frmUser.ShowDialog();
            if (resp == DialogResult.OK)
            {
                CargarGrilla();
                frmUser.Close();
            }
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            abmEmpleados = new BLLClsEmpleadoABM();
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    BEClsEmpleado objEmp = dataGridView1.SelectedRows[0].DataBoundItem as BEClsEmpleado;
                    abmEmpleados.Eliminar(objEmp);
                    CargarGrilla();
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
                frmUser = new FrmUsuario();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    BEClsEmpleado objEmp = dataGridView1.SelectedRows[0].DataBoundItem as BEClsEmpleado;
                    frmUser.ModificarEmpleado(objEmp);
                    DialogResult resp = frmUser.ShowDialog();
                    if (resp == DialogResult.OK)
                    {
                        CargarGrilla();
                        frmUser.Close();
                    }
                }
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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
        private void txtBuscador_MouseHover(object sender, EventArgs e)
        {
            txtBuscador.Text = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oBEEmp = (BEClsEmpleado)this.dataGridView1.CurrentRow.DataBoundItem;
            
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            abmEmpleados = new BLLClsEmpleadoABM();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BEClsEmpleado objEmp = dataGridView1.SelectedRows[0].DataBoundItem as BEClsEmpleado;
                abmEmpleados.Alta(objEmp);
                CargarGrilla();
            }
        }
    }
}
