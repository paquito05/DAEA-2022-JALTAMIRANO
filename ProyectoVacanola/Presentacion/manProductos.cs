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
    public partial class manProductos : Form
    {
        public manProductos()
        {
            InitializeComponent();
        }



        void Listar()
        {
            DataTable dt = new DataTable();
            clsNegocio np = new clsNegocio();
            dt = np.GetAllProductosReporte();

            dgProductos.DataSource = dt;
            dgProductos.Refresh();
        }

        private void manProductos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
