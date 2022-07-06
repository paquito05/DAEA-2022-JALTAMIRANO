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
    public partial class regisAnimal : Form
    {
        public regisAnimal()
        {
            InitializeComponent();
        }

        private void rbGuardar_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Guardar";
            txtID.Enabled = false;
            txtNombre.Enabled = true;
            txtColor.Enabled = true;
            dtpFechaNaci.Enabled = true;
            rbMacho.Enabled = true;
            rbHembra.Enabled = true;
        }

        private void rbActualizar_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Actualizar";
            txtID.Enabled = true;
            txtNombre.Enabled = true;
            txtColor.Enabled = true;
            dtpFechaNaci.Enabled = true;
            rbMacho.Enabled = true;
            rbHembra.Enabled = true;
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Eliminar";
            txtID.Enabled = true;
            txtNombre.Enabled = false;
            txtColor.Enabled = false;
            dtpFechaNaci.Enabled = false;
            rbMacho.Enabled = false;
            rbHembra.Enabled = false;
        }

        void Listar()
        {
            DataTable dt = new DataTable();
            clsNegocio np = new clsNegocio();
            dt = np.GetAll();

            dgAnimales.DataSource = dt;
            dgAnimales.Refresh();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            clsNegocio CN = new clsNegocio();
            if (rbGuardar.Checked)
            {

                String Sexo = "";

                if (rbMacho.Checked)
                {
                    Sexo = "Macho";
                }
                else
                {
                    Sexo = "Hembra";
                }

                int codigo = CN.CreateAnimal(txtNombre.Text, Sexo, txtColor.Text, dtpFechaNaci.Value);
                MessageBox.Show("codigo" + codigo);

                txtNombre.Text = "";
                txtID.Text = "";
                txtColor.Text = "";

                Listar();
                

            }
            if (rbActualizar.Checked)
            {

                String Sexo = "";

                if (rbMacho.Checked)
                {
                    Sexo = "Macho";
                }
                else
                {
                    Sexo = "Hembra";
                }

                int codigo = CN.UpdateAnimal(txtID.Text, txtNombre.Text, Sexo, txtColor.Text, dtpFechaNaci.Value);
                MessageBox.Show("codigo" + codigo);

                txtNombre.Text = "";
                txtID.Text = "";
                txtColor.Text = "";

                Listar();
            }

            if (rbEliminar.Checked)
            {
                int codigo = CN.DeleteAnimal(txtID.Text);
                MessageBox.Show("codigo::  " + codigo);

                txtNombre.Text = "";
                txtID.Text = "";
                txtColor.Text = "";

                Listar();
            }
        }

        private void regisAnimal_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgAnimales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAnimales.SelectedRows.Count > 0)
            {

                txtID.Text = dgAnimales.SelectedRows[0].Cells[0].Value.ToString();
                txtNombre.Text = dgAnimales.SelectedRows[0].Cells[1].Value.ToString();
                txtColor.Text = dgAnimales.SelectedRows[0].Cells[2].Value.ToString();

                String Sexo = dgAnimales.SelectedRows[0].Cells[3].Value.ToString();

                if (Sexo.Equals("Macho"))
                {
                    rbMacho.Checked = true;
                }
                else
                {
                    rbHembra.Checked = true;
                }
                
                dtpFechaNaci.Text = dgAnimales.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
