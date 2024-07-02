using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNegocio
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DataTable tabla = SQLite.SqlHelper.Consulta("select codigo from validacion where codigo = '1'");
            }
            catch (Exception)
            {
               SQLite.SqlHelper.ExecuteNonQuery("CREATE TABLE validacion (codigo TEXT PRIMARY KEY)");
               SQLite.SqlHelper.ExecuteNonQuery("insert into validacion values('1')");
               SQLite.SqlHelper.ExecuteNonQuery("CREATE TABLE Producto (codigo TEXT PRIMARY KEY, precio_c floating, precio_v floating,marca_id Integer, descripcion TEXT,categoria_id INTEGER ,FOREIGN KEY(marca_id) REFERENCES Marcas (codigo), FOREIGN KEY(categoria_id) REFERENCES Categorias (codigo))");
               SQLite.SqlHelper.ExecuteNonQuery("CREATE TABLE Categorias (codigo INTEGER PRIMARY KEY, descripcion TEXT NOT NULL)");
               SQLite.SqlHelper.ExecuteNonQuery("CREATE TABLE Marcas (codigo INTEGER PRIMARY KEY, descripcion TEXT NOT NULL)");
               //SQLite.SqlHelper.ExecuteNonQuery("CREATE TABLE Cliente (documento INTEGER PRIMARY KEY, nombre TEXT NOT NULL,  apellido TEXT NOT NULL,  direccion TEXT NOT NULL,  telefono TEXT,  deuda floating)");
               SQLite.SqlHelper.ExecuteNonQuery("CREATE TABLE Cliente (documento TEXT PRIMARY KEY, nombre TEXT NOT NULL,  apellido TEXT NOT NULL,  direccion TEXT NOT NULL,  telefono TEXT,  deuda floating)");
               SQLite.SqlHelper.ExecuteNonQuery("CREATE TABLE Venta (id INTEGER PRIMARY KEY AUTOINCREMENT, fecha TEXT, doc_cliente TEXT, pagado INTEGER,monto FLOATING ,FOREIGN KEY(doc_cliente) References cliente (documento))");
               SQLite.SqlHelper.ExecuteNonQuery("CREATE TABLE DetalleVenta (id_venta INTEGER, cod_producto text ,cantidad Int, precio FLOATING , FOREIGN KEY(id_venta) References venta (id), FOREIGN KEY(cod_producto) References producto (CODIGO), PRIMARY KEY(id_venta, cod_producto))");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
