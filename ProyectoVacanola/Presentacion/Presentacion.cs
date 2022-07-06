using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Negocio;

namespace Presentacion
{
    public partial class Presentacion : Form
    {


        //SQLConnection nos permite manejar el acceso al servidor
        SqlConnection conn;

        public Presentacion()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            try
            {

                clsNegocio NG = new clsNegocio();
                bool acceso = NG.LoginUsuario(txtUsuario.Text, txtPassword.Text);

                if (acceso == true)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectas");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor : \n" + ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMostarPassword_CheckedChanged(object sender, EventArgs e)
        {
            String Pass = txtPassword.Text;

            if (cbMostarPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = Pass;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = Pass;
            }
        }
    }
}
