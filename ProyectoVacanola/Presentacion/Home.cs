using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Home : Form
    {


        public Home()
        {
            InitializeComponent();
        }


        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            manUsuario frmUsuario = new manUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();

        }

        private void registarAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            regisAnimal frmAnimal = new regisAnimal();
            frmAnimal.MdiParent = this;
            frmAnimal.Show();
        }

        private void reporteDeConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            reporteAnimal reporteAnimal = new reporteAnimal();
            reporteAnimal.MdiParent = this;
            reporteAnimal.Show();

        }

        private void mnuManProductos_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            manProductos manProductos = new manProductos();
            manProductos.MdiParent = this;
            manProductos.Show();
        }

        private void mnuProRegiCompra_Click(object sender, EventArgs e)
        {


            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            regisCompra regisCompra = new regisCompra();
            regisCompra.MdiParent = this;
            regisCompra.Show();
        }

        private void registrarConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            AgregarConsumo AgregarConsumo = new AgregarConsumo();
            AgregarConsumo.MdiParent = this;
            AgregarConsumo.Show();
        }

        private void reporteDeActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            ReporteActividad ReporteActividad = new ReporteActividad();
            ReporteActividad.MdiParent = this;
            ReporteActividad.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuReporCompra_Click(object sender, EventArgs e)
        {

        }
    }
}
