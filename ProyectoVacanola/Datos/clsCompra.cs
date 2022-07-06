using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class clsCompra : clsDatos
    {
        public int CreateCompra(DateTime fecha_compra, int cantidad, Double precio_bruto, Double precio_unitario, int IGV,
            Double precio_total, int producto_id)
        {
            conn.Open();
            String sp = "InsertCompra";

            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fecha_compra", fecha_compra);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@precio_bruto", precio_bruto);
            cmd.Parameters.AddWithValue("@precio_unitario", precio_unitario);
            cmd.Parameters.AddWithValue("@IGV", IGV);
            cmd.Parameters.AddWithValue("@precio_total", precio_total);
            cmd.Parameters.AddWithValue("@producto_id", producto_id);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("Codigo", codigo);

            conn.Close();

            return codigo;
        }


    }
}
