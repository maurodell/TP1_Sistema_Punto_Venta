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
                CargarGrilla();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmNotaDeCredito_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNC.SelectedRows.Count > 0)
                {
                    BEClsNotaDeCredito objNc = dgvNC.SelectedRows[0].DataBoundItem as BEClsNotaDeCredito;
                    DialogResult Respuesta;
                    Respuesta = MessageBox.Show("¿Confirma la eleminación del Alumno?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Respuesta == DialogResult.Yes)
                    {
                        if (oBLLNC.Eliminar(objNc) == false)
                        { MessageBox.Show("Para dar de baja al Alumno no debe tener Materias Asociadas"); }
                        else
                        {   
                            CargarGrilla();
                            Limpiar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay Notas de Crédito");
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
