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
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Menu_Inicio_IU
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
            BLLProveedor = new BLLClsProveedor();
            CargarGrilla();
            dtoUser = new DTOUser();
        }
        BLLClsProveedor BLLProveedor;
        BEClsProveedor BEProveedor;
        DTOUser dtoUser;
        public List<BEClsProveedor> LeerXML()
        {
           return BLLProveedor.ListarTodos();
        }
        private void CargarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = LeerXML();
        }
        private void CargarGrilla(List<BEClsProveedor> lista)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = lista;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            BEProveedor = new BEClsProveedor();
            if (txtId.Text != string.Empty)
            {
                bool respuesta = Regex.IsMatch(txtId.Text, "^([0-9]+$)");
                BEProveedor.Codigo = Convert.ToInt32(txtId.Text);
                BEProveedor.Nombre = txtNombre.Text;
                BEProveedor.Domicilio = txtDomicilio.Text;
                BEProveedor.Telefono = txtTelefono.Text;
                BEProveedor.Rubro = txtRubro.Text;

                BLLProveedor.Crear(BEProveedor);
                CargarGrilla();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Ingresar datos");
            }

        }
        void Limpiar()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtRubro.Text = null;
            txtTelefono.Text = string.Empty;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiar();
            BEProveedor = (BEClsProveedor)this.dataGridView1.CurrentRow.DataBoundItem;

            txtId.Text = BEProveedor.Codigo.ToString();
            txtNombre.Text = BEProveedor.Nombre;
            txtDomicilio.Text = BEProveedor.Domicilio;
            txtRubro.Text = BEProveedor.Rubro;
            txtTelefono.Text = BEProveedor.Telefono;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    BLLProveedor.Baja(Convert.ToInt32(txtId.Text));
                    CargarGrilla();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Seleccione el Proveedor a eliminar");
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
                if (txtId.Text != string.Empty)
                {
                    BEClsProveedor provMod = new BEClsProveedor();
                    provMod.Codigo = Convert.ToInt32(txtId.Text);
                    provMod.Nombre = txtNombre.Text;
                    provMod.Domicilio = txtDomicilio.Text;
                    provMod.Rubro = txtRubro.Text;
                    provMod.Telefono = txtTelefono.Text;

                    if (BLLProveedor.Modificar(provMod) != false)
                    {
                        CargarGrilla();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar al Proveedor");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el Proveedor a modificar");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text != string.Empty)
                {
                    List<BEClsProveedor> resLista = BLLProveedor.BuscarXNombre(txtBuscar.Text);
                    if (resLista != null)
                    {
                        CargarGrilla(resLista);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos");
                    }
                }
                else
                {
                    MessageBox.Show("Ingresé un nombre");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
