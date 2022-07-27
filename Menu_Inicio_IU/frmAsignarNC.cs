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
using BE;

namespace Menu_Inicio_IU
{
    public partial class frmAsignarNC : Form
    {
        public frmAsignarNC()
        {
            listaEmp = new BLLUsuarios();
            oBLLNC = new BLLClsNotaDeCredito();
            oBENC = new BEClsNotaDeCredito();
            InitializeComponent();
        }
        BLLUsuarios listaEmp;
        BLLClsNotaDeCredito oBLLNC;
        BEClsNotaDeCredito oBENC;
        BEClsEmpleado oBEEmp;
        BLLClsAdministrador BLLAdmin;
        BLLClsCajero BLLCajero;
        DTOUser dtoUser;
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void CargarGrilla()
        {
            this.dgvResp.DataSource = null;
            this.dgvResp.DataSource = listaEmp.ListarTodos();
            this.dgvResp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResp.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
        void CargarGrillaNotaCredito()
        {
            this.dgvAsigados.DataSource = null;
            this.dgvAsigados.DataSource = oBLLNC.ListarNC_Empleado(oBEEmp);
            this.dgvAsigados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAsigados.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
        public void AcutalizarCmb()
        {
            cmbListaNC.DataSource = null;
            cmbListaNC.DataSource = oBLLNC.ListarTodos();
            cmbListaNC.ValueMember = "codigo";
            cmbListaNC.DisplayMember = "Numero_Doc";
            cmbListaNC.Refresh();
        }
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                oBENC = (BEClsNotaDeCredito)cmbListaNC.SelectedItem;

                oBEEmp = (BEClsEmpleado)dgvResp.CurrentRow.DataBoundItem;

                if (oBEEmp != null && oBENC != null)
                {
                    //otra propuesta para ver si la nota de credito ya fue asignada en la MPP cuando hace AsociarEmpleadoNC
                    if (oBEEmp is BEClsCajero)
                    {
                        BLLCajero = new BLLClsCajero();
                        if (BLLCajero.AsociarEmpleadoNC(oBEEmp, oBENC) == false)
                        {
                            MessageBox.Show("Nota de Crédito ya Asignada!");
                        }
                    }
                    else
                    {
                        BLLAdmin = new BLLClsAdministrador();
                        if(BLLAdmin.AsociarEmpleadoNC(oBEEmp, oBENC) == false)
                        {
                            MessageBox.Show("Nota de Crédito ya Asignada!");
                        }
                    }
                }
                CargarGrillaNotaCredito();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmAsignarNC_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            AcutalizarCmb();
            ControlUser();
        }

        private void dgvResp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oBEEmp = (BEClsEmpleado)dgvResp.CurrentRow.DataBoundItem;
            dgvAsigados.DataSource = null;
            dgvAsigados.DataSource = oBLLNC.ListarNC_Empleado(oBEEmp);
            this.dgvAsigados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                oBENC = (BEClsNotaDeCredito)dgvAsigados.CurrentRow.DataBoundItem;

                oBEEmp = (BEClsEmpleado)dgvResp.CurrentRow.DataBoundItem;

                if (oBEEmp != null)
                {
                    BLLCajero = new BLLClsCajero();
                    BLLCajero.QuitarEmpleadoNC(oBENC);
                }
                CargarGrillaNotaCredito();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ControlUser()
        {
            dtoUser = new DTOUser();

            if (dtoUser.VPU == "Cajero")
            {
                btnAsignar.Enabled = false;
                btnQuitar.Enabled = false;
            }
        }
    }
}
