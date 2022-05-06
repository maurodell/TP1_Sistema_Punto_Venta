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
            oBLLEmp = new BLLClsEmpleadoABM();
            oBLLNC = new BLLClsNotaDeCredito();
            oBENC = new BEClsNotaDeCredito();
            oBEEmp = new BEClsEmpleado();
            InitializeComponent();
        }
        BLLClsEmpleadoABM oBLLEmp;
        BLLClsNotaDeCredito oBLLNC;
        BEClsNotaDeCredito oBENC;
        BEClsEmpleado oBEEmp;
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void CargarGrilla()
        {
            this.dgvResp.DataSource = null;
            this.dgvResp.DataSource = oBLLEmp.ListarTodos();
            this.dgvResp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResp.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
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

                if (oBEEmp.ListaNC.Count > 0)
                {
                    foreach (BEClsNotaDeCredito notaCred in oBEEmp.ListaNC)
                    {
                        if (notaCred.Codigo.Equals(oBENC.Codigo))
                        {
                            MessageBox.Show("La Nota de Crédito ya fue asignada");
                            break;
                        }
                        else
                        {
                            oBLLEmp.AsignarNC_Empleado(oBEEmp, oBENC);
                            break;
                        }
                    }
                }
                else
                {
                    oBLLEmp.AsignarNC_Empleado(oBEEmp, oBENC);
                }
                CargarGrilla();
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
        }

        private void dgvResp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oBEEmp = (BEClsEmpleado)dgvResp.CurrentRow.DataBoundItem;
            oBLLEmp.ListarNC_Empleado(oBEEmp);
            dgvAsigados.DataSource = null;
            dgvAsigados.DataSource = oBEEmp.ListaNC;
            this.dgvAsigados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }
    }
}
