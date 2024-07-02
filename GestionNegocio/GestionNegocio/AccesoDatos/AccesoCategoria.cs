using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNegocio.AccesoDatos
{
    internal class AccesoCategoria
    {
        public static void CargarCategoria(int id, string descrip)
        {
            SQLite.SqlHelper.ExecuteNonQuery("INSERT INTO Categorias (codigo, descripcion) VALUES (" + id.ToString() + ", '" + descrip + "')");
        }
        public static DataTable RecibirCategorias()
        {
            return SQLite.SqlHelper.Consulta("Select * from Categorias");
        }
        public static void eliminarCategoria(int id)
        {
            SQLite.SqlHelper.ExecuteNonQuery("Delete from Categorias where codigo = " + id.ToString());
        }
        public static void modificarCategoria(int id, string desc)
        {
            SQLite.SqlHelper.ExecuteNonQuery("update Categorias set descripcion = " + "'" + desc + "'" + " where codigo = " + id.ToString());
        }
    }
}
