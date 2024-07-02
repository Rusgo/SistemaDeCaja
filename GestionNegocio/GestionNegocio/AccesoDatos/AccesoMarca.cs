using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNegocio.AccesoDatos
{
    internal class AccesoMarca
    {
        public static void CargarMarca(int id, string descrip)
        {
            SQLite.SqlHelper.ExecuteNonQuery("INSERT INTO Marcas (codigo, descripcion) VALUES (" + id.ToString() + ", '" + descrip + "')");
        }
        public static DataTable RecibirMarcas()
        {
            return SQLite.SqlHelper.Consulta("Select * from Marcas");
        }
        public static void eliminarMarca(int id)
        {
            SQLite.SqlHelper.ExecuteNonQuery("Delete from marcas where codigo = " + id.ToString());
        }
        public static void modificarMarca(int id, string desc)
        {
            SQLite.SqlHelper.ExecuteNonQuery("update marcas set descripcion = " + "'" + desc + "'" + " where codigo = " + id.ToString());
        }
    }
}
