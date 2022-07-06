using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class clsAnimal : clsDatos
    {


        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            conn.Open();

            String sql = "select animal_id,nombre,color,sexo,fecha_nacimiento from tbl_animal";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);

            conn.Close();

            return dt;
        }

        public int Create(string Nombre, string Sexo, string Color, DateTime FechaNaci)
        {
            conn.Open();
            String sp = "InsertAnimal";

            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@Color", Color);
            cmd.Parameters.AddWithValue("@FechaNaci", FechaNaci);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("Codigo", codigo);

            conn.Close();

            return codigo;
        }


        public int Update(string id,string Nombre, string Sexo, string Color, DateTime FechaNaci)
        {
            conn.Open();
            String sp = "updateAnimal";

            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@Color", Color);
            cmd.Parameters.AddWithValue("@FechaNaci", FechaNaci);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("Codigo", codigo);

            conn.Close();

            return codigo;
        }

        public int Delete(string id)
        {
            conn.Open();
            String sp = "DeleteAnimal";

            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("Codigo", codigo);

            conn.Close();

            return codigo;
        }
    }
}
