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
    public partial class regisCompra : Form

    {

        public regisCompra() 
        {
            InitializeComponent();
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var a = lblPrecioTotal.Text.Split('.');

            Double total = 0.0;

            if (a.Length == 1) {

                total = Double.Parse(lblPrecioTotal.Text + .00);

            }



            clsNegocio CN = new clsNegocio();
            int id = CN.CreateCompra(
                dtpFechaCompra.Value,
                int.Parse(txtCantidad.Text),
                Double.Parse(txtPrecioBruto.Text), 
                Double.Parse(txtPrecioUnitario.Text),
                int.Parse(txtIGV.Text),
                total,
                
                int.Parse(txtProducto.Text)
              );

            CN.UpdateProducto(int.Parse(txtProducto.Text), int.Parse(txtCantidad.Text));

            MessageBox.Show("COMPRA INGRESADA ID: " + id);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

            if (txtCantidad.TextLength == 0)
                txtCantidad.Text = (0).ToString();
            if (txtPrecioUnitario.TextLength == 0)
                txtPrecioUnitario.Text = (0).ToString()
                    ;
            txtPrecioBruto.Text = (Double.Parse(txtCantidad.Text) * Double.Parse(txtPrecioUnitario.Text)).ToString();
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.TextLength == 0)
                txtCantidad.Text = (0).ToString();
            if (txtPrecioUnitario.TextLength == 0)
                txtPrecioUnitario.Text = (0).ToString()
                    ;
            txtPrecioBruto.Text = (Double.Parse(txtCantidad.Text) * Double.Parse(txtPrecioUnitario.Text)).ToString();
        }

        private void txtIGV_TextChanged(object sender, EventArgs e)
        {
            if (txtIGV.TextLength == 0)
                txtIGV.Text = (0).ToString();


            lblPrecioTotal.Text = ((Double.Parse(txtPrecioBruto.Text) * Double.Parse(txtIGV.Text))/100).ToString();
        }

        private void btnIrProductos_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.Show();
        }

        void Listar()
        {
            DataTable dt = new DataTable();
            clsNegocio np = new clsNegocio();
            dt = np.GetAllProductos();

            dgProductos.DataSource = dt;
            dgProductos.Refresh();
        }


        private void regisCompra_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgProductos_SelectionChanged(object sender, EventArgs e)
        {


            if (dgProductos.SelectedRows.Count > 0)
            {
                txtProducto.Text = dgProductos.SelectedRows[0].Cells[0].Value.ToString();
              
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            Listar();
        }

    }
}
