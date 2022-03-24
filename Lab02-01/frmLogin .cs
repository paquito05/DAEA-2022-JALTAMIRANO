using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            String usuario = "samu";
            String password = "samu123";

            Console.WriteLine(usuario);
            Console.WriteLine(password);
            
            if (txtUsuario.Text.Equals(usuario) && txtPassword.Text.Equals(password)) 
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Password Incorrectos");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
