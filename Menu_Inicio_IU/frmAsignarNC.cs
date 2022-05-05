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
            InitializeComponent();
        }
        BLLClsEmpleadoABM oBLLEmp;
        BLLClsNotaDeCredito oBLLNC;
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
            CargarGrilla();
        }

        private void frmAsignarNC_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            AcutalizarCmb();
        }
    }
}
