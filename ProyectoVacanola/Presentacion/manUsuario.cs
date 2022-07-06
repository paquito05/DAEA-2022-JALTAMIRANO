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
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void manUsuario_Load(object sender, EventArgs e)
        {

        }

        private void rbGuardar_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Guardar";
            txtID.Enabled = false;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            dtpFechaNaci.Enabled = true;
            cbRol.Enabled = true;
        }

        private void rbActualizar_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Actualizar";
            txtID.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            dtpFechaNaci.Enabled = true;
            cbRol.Enabled = true;
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Eliminar";
            txtID.Enabled = true;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            dtpFechaNaci.Enabled = false;
            cbRol.Enabled = false;

        }

        
    }
}
