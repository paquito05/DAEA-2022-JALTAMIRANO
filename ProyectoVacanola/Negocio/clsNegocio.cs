using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Negocio
{
    public class clsNegocio
    {
        clsAnimal daoAnimal = new clsAnimal();
        clsProductos daoProductos = new clsProductos();
        clsCompra daoCompra = new clsCompra();
        clsConsumo daoConsumo = new clsConsumo();
        Login daoLogin = new Login();

        public DataTable GetAll()
        {

            return daoAnimal.GetAll();
        }

        



        public int CreateAnimal(string Nombre, string Sexo, string Color, DateTime FechaNaci)
        {
            return daoAnimal.Create(Nombre, Sexo, Color, FechaNaci);
        }

        public int UpdateAnimal(string id, string Nombre, string Sexo, string Color, DateTime FechaNaci)
        {
            return daoAnimal.Update(id, Nombre, Sexo, Color, FechaNaci);
        }

        public int DeleteAnimal(string id)
        {
            return daoAnimal.Delete(id);
        }



        ///////////////////////////////////////////////////
        /// Productos

        public DataTable GetAllProductos()
        {
            return daoProductos.GetAllProductos();
        }

        public DataTable GetAllProductosReporte()
        {

            return daoProductos.GetAllProductosReporte();
        }
        public int CreateProducto(string Nombre,string tipo_producto, Double peso_mililitros, String proveedor)
        {
            return daoProductos.CreateProducto
                (
                Nombre,
                tipo_producto,
                peso_mililitros,
                proveedor
                );
        }

        public int UpdateProducto(int id, int stock)
        {
            return daoProductos.UpdateProducto( id,  stock);
        }

        ///////////////////////////////////////////////////
        /// Compra
        /// 

        public int CreateCompra(DateTime fecha_compra, int cantidad, Double precio_bruto, Double precio_unitario, int IGV,
            Double precio_total, int producto_id)
        {
            return daoCompra.CreateCompra
                ( 
                fecha_compra,
                cantidad, 
                precio_bruto, 
                precio_unitario, 
                IGV,
                precio_total, 
                producto_id
                );
        }

        ///////////////////////////////////////////////////
        /// Consumo
        /// 

        public int CreateConsumo(int Cantidad, int productoID, DateTime fecha, String hora)
        {
            return daoConsumo.CreateConsumo(Cantidad, productoID, fecha, hora);
        }

        public int CreateActividadConsumo(int consumoID)
        {
            return daoConsumo.CreateActividadConsumo(consumoID);
        }

        public int UpdateProductoConsumo(int id, int stock)
        {
            return daoConsumo.UpdateProductoConsumo(id, stock);
        }
        public DataTable GetAllActividadConsumo()
        { 
            return daoConsumo.GetAllActividadConsumo();
        }

        ///////////////////////////////////////////////////
        /// Login
        /// 
        public bool LoginUsuario(String user, String pwd)
        {
            return daoLogin.LoginUsuario(user, pwd);
        }

}
}
