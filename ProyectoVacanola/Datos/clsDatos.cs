using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{


    public class clsDatos
    {
        public SqlConnection conn;
        public clsDatos()
        {

            string str = "Server =DESKTOP-D3IMFSS\\LOCAL ; Database= ESTABLO; Integrated Security=true;";
            conn = new SqlConnection(str);
        }
    }
}
