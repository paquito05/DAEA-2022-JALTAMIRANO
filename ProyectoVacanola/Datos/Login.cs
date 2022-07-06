using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class Login : clsDatos
    {
        public bool LoginUsuario(string user, String pws)
        {

            bool acceso = false;
            DataTable dt = new DataTable();

            conn.Open();

            String sql = "SELECT * FROM tbl_usuarios WHERE usuarios_nombres = '" +
                                user + "' AND usuarios_password = '" + pws + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
            int Nusuario = dt.Rows.Count;
            Console.WriteLine(Nusuario);

            if (Nusuario == 1)
            {
                acceso = true;
            }
            
            conn.Close();

            return acceso;
        }
    }
}
