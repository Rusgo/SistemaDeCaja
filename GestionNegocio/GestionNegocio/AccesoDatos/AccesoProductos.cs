using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GestionNegocio.AccesoDatos
{
    internal class AccesoProductos
    {
        public static void CargarProducto(string id, string nombre, string preciov, string precio_c, int marca, int categoria)
        {
            preciov = preciov.Replace(",", ".");
            precio_c = precio_c.Replace(",", ".");
            SQLite.SqlHelper.ExecuteNonQuery("INSERT INTO Producto VALUES ('" + id.ToString() + "'," + precio_c + ", " + preciov + "," + marca +  ", '" + nombre + "',"  + categoria + ")");
        }
        public static DataTable RecibirProductos()
        {
            return SQLite.SqlHelper.Consulta("Select P.codigo, P.descripcion, P.precio_v, P.precio_c, M.descripcion as marca, C.descripcion as categoria from Producto p join Marcas m on (p.marca_id = m.codigo) join categorias c on (p.categoria_id = c.codigo)");
        }
        public static void eliminarProducto(string id)
        {
            SQLite.SqlHelper.ExecuteNonQuery("Delete from Producto where codigo = " + id.ToString());
        }
        public static void modificarProducto(string id, string nombre, string preciov, string precio_c, int marca, int categ)
        {
            preciov = preciov.Replace(",", ".");
            precio_c = precio_c.Replace(",", ".");
            SQLite.SqlHelper.ExecuteNonQuery("update Producto set descripcion = " + "'" + nombre + "'," + "precio_v = "  + preciov  + "," + "precio_c = " + precio_c + "," + "categoria_id = " + categ + "," + "marca_id = " + marca + " where codigo = '" + id.ToString() + "'");
        }
        public static DataTable ObtenerProducto(string id)
        {
            return SQLite.SqlHelper.Consulta("select codigo, descripcion, precio_v from Producto where codigo = " + id.ToString());
        }
    }
}
