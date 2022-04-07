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

namespace lab03
{
    public partial class Form1 : Form
    {

        //SQLConection nos permite manejar el acceso al servidor
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Declara las variables para almacenar los valores de los TexBox
            //Y definimos una cadena de conexion
            String servidor = txtServidor.Text;
            String bd = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtPassword.Text;

            String str = "Server=" + servidor + ";DataBase=" + bd + ";";

            //La cadena de conexion cambia a funcion del estado del ChecBox

            if (chkAutenticación.Checked)

                str += "Integrated Security = true";

            else

                str += "User Id=" + user + ";Password=" + pwd + ";";



            //Abrir una conexion con el servidor, usando la cadena de conexion
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado Satisfactoriamente");
                btnDesconectar.Enabled = true;
                btnUsuario.Enabled = true;
                btnPersona.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar el servidor: \n" + ex.ToString());
            }
        }


        private void btnEstado_Click(object sender, EventArgs e)
        {

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Estado del Servidor: " + conn.State +
                        "\nVersión del Servidor: " + conn.ServerVersion +
                        "\nBase de datos" + conn.Database);
                }
                else
                {
                    MessageBox.Show("Estado del servidor: " + conn.State);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del servidor: \n" + ex.ToString());

            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    btnDesconectar.Enabled = false;
                    btnUsuario.Enabled = false;
                    btnPersona.Enabled = false;

                    MessageBox.Show("Conexion cerrada Satisfactoiamente");
                }
                else
                {
                    MessageBox.Show("La conexion ya esta cerrada");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cerrar la conexión: \n" + ex.ToString());

            }

        }

        private void chkAutenticación_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutenticación.Checked)
            {
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                txtPassword.Enabled = true;

            }
        }

        
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(conn);
            usuario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            frmPersona persona = new frmPersona(conn);
            persona.Show();

        }
    }
}
