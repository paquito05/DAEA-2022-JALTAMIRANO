using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class AgregarConsumo : Form
    {
        public AgregarConsumo()
        {
            InitializeComponent();
        }

        int stock = 0;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Listar()
        {
            DataTable dt = new DataTable();
            clsNegocio np = new clsNegocio();
            dt = np.GetAllProductosReporte();

            dgProductos.DataSource = dt;
            dgProductos.Refresh();
        }

        private void AgregarConsumo_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)

        {

            if (stock >= int.Parse(txtCantidad.Text))
            {
                String HORA = txtHora.Text + ":" + txtMinutos.Text;

                clsNegocio NG = new clsNegocio();
                int id = NG.CreateConsumo(int.Parse(txtCantidad.Text), int.Parse(txtProcutoID.Text), dtpFecha.Value, HORA);
                int updateProducto = NG.UpdateProductoConsumo(int.Parse(txtProcutoID.Text), stock - int.Parse(txtCantidad.Text));
                int idAConsumo = NG.CreateActividadConsumo(id);
                MessageBox.Show("Activadad Registrada");
            }
            else
            {
                MessageBox.Show("La cantidad ingresada no se cuenta en stock");

            }




        }

        private void dgProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count > 0)
            {
                txtProcutoID.Text = dgProductos.SelectedRows[0].Cells[0].Value.ToString();
                stock = int.Parse(dgProductos.SelectedRows[0].Cells[2].Value.ToString());
                Console.WriteLine(stock);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
