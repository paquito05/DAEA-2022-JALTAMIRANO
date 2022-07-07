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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

       
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            clsNegocio CN = new clsNegocio();
            int id = CN.CreateProducto(txtNombre.Text,
                txtTipoProducto.Text,
                Double.Parse(txtPesoMililitros.Text),
                txtProveedor.Text);

            MessageBox.Show("EL PRODUCTO SE INGRESO ID: " + id);
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
