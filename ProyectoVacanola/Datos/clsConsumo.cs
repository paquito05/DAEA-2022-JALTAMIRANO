using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class clsConsumo : clsDatos
    {
        public int CreateConsumo(int Cantidad, int productoID, DateTime fecha, String hora)
        {
            conn.Open();
            String sp = "InsertConsumo";

            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@producto_id", productoID);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@hora", hora);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("Codigo", codigo);

            conn.Close();

            return codigo;
        }


        public int CreateActividadConsumo(int consumoID)
        {
            conn.Open();
            String sp = "InsertDiariaConsumo";

            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@consumo_id", consumoID);


            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("Codigo", codigo);

            conn.Close();

            return codigo;
        }

        public int UpdateProductoConsumo(int id, int stock)
        {
            conn.Open();
            String sp = "updateProducto";

            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@producto_id", id);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("Codigo", codigo);

            conn.Close();

            return codigo;
        }





        public DataTable GetAllActividadConsumo()
        {
            DataTable dt = new DataTable();

            conn.Open();

            String sql = "select a.actividad_id,p.nombre,c.cantidad,c.fecha,c.hora " +
                "from tbl_actividad_diaria a " +
                "join tbl_consumo c on a.consumo_id = c.consumo_id " +
                "join tbl_productos p on c.producto_id = p.producto_id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);

            conn.Close();

            return dt;
        }



        

    }
}
