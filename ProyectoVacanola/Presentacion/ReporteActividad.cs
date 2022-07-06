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
    public partial class ReporteActividad : Form
    {
        public ReporteActividad()
        {
            InitializeComponent();
        }

        void Listar()
        {
            DataTable dt = new DataTable();
            clsNegocio np = new clsNegocio();
            dt = np.GetAllActividadConsumo();

            dgActividad.DataSource = dt;
            dgActividad.Refresh();
        }


        private void ReporteActividad_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
