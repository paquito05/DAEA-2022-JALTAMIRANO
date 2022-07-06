using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class clsProductos : clsDatos
    {
        public DataTable GetAllProductos()
        {
            DataTable dt = new DataTable();

            conn.Open();

            String sql = "select producto_id,nombre,tipo_producto,peso_mililitros,proveedor from tbl_productos";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);

            conn.Close();

            return dt;
        }


        public DataTable GetAllProductosReporte()
        {
            DataTable dt = new DataTable();

            conn.Open();

            String sql = "select producto_id,nombre,stock,tipo_producto,peso_mililitros,proveedor from tbl_productos";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);

            conn.Close();

            return dt;
        }


        public int CreateProducto(string Nombre, string tipo_producto, Double peso_mililitros, String proveedor)
        {
            conn.Open();
            String sp = "InsertProducto";

            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", Nombre);
            cmd.Parameters.AddWithValue("@tipo_producto", tipo_producto);
            cmd.Parameters.AddWithValue("@peso_mililitros", peso_mililitros);
            cmd.Parameters.AddWithValue("@proveedor", proveedor);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("Codigo", codigo);

            conn.Close();

            return codigo;
        }

        public int UpdateProducto(int id, int stock )
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

    }
}
