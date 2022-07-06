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
    public partial class reporteAnimal : Form
    {
        public reporteAnimal()
        {
            InitializeComponent();
        }


        void Listar()
        {
            DataTable dt = new DataTable();
            clsNegocio np = new clsNegocio();
            dt = np.GetAll();

            dgAnimales.DataSource = dt;
            dgAnimales.Refresh();
        }

        private void reporteAnimal_Load(object sender, EventArgs e)
        {
            Listar();
        }

    }
}
