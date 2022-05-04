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
    public partial class frmNotaDeCredito : Form
    {
        public frmNotaDeCredito()
        {
            oBLLNC = new BLLClsNotaDeCredito();
            oBENC = new BEClsNotaDeCredito();
            oBLLEmp = new BLLClsEmpleadoABM();
            InitializeComponent();
        }
        BLLClsNotaDeCredito oBLLNC;
        BEClsNotaDeCredito oBENC;
        BLLClsEmpleadoABM oBLLEmp;
        void CargarComboResponsable()
        {
            cmbEmpleado.DataSource = null;
            cmbEmpleado.DataSource = oBLLEmp.ListarTodos();
            cmbEmpleado.ValueMember = "codigo";
            cmbEmpleado.DisplayMember = "Nombre";
            cmbEmpleado.Refresh();
        }
        void CargarGrilla()
        {
            this.dgvNC.DataSource = null;
            this.dgvNC.DataSource = oBLLNC.ListarTodos();
            this.dgvNC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNC.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
        void Limpiar()
        {
            txtMonto.Text = string.Empty;
            txtNumFac.Text = string.Empty;
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                oBENC.Numero_doc = Convert.ToInt32(txtNumFac.Text);
                oBENC.Fecha = dtpFecha.Value;
                oBENC.Monto = Convert.ToDouble(txtMonto.Text);

                oBLLNC.Crear(oBENC);
                //CargarGrilla();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmNotaDeCredito_Load(object sender, EventArgs e)
        {
            CargarComboResponsable();
            //CargarGrilla();
        }
    }
}
