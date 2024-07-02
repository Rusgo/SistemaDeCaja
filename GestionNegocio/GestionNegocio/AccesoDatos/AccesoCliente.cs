using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNegocio.AccesoDatos
{
    internal class AccesoCliente
    {
        public static void CargarCliente(int id, string nombre, string apellido, string direccion, string telefono)
        {
            SQLite.SqlHelper.ExecuteNonQuery("INSERT INTO cliente (documento, nombre, apellido, direccion, telefono, deuda) VALUES (" + id.ToString() + ", '" + nombre + "', '" + apellido+ "'" + ", '" + direccion + "','" + telefono + "'," + "0" + ")");
        }
        public static DataTable RecibirCliente()
        {
            return SQLite.SqlHelper.Consulta("Select * from cliente");
        }
        public static DataTable RecibirCliente(string documento)
        {
            return SQLite.SqlHelper.Consulta("Select * from cliente where documento = "+ documento);
        }
        public static void eliminarCliente(int id)
        {
            SQLite.SqlHelper.ExecuteNonQuery("Delete from cliente where documento = " + id.ToString());
        }
        public static void modificarCliente(int id, string nombre, string apellido, string direccion, string telefono)
        {
            SQLite.SqlHelper.ExecuteNonQuery("update cliente set documento = " + "'" + id + "', nombre = '"+ nombre+ "', direccion = '" + direccion+ "', apellido = '" + apellido + "', telefono = '"+ telefono+ "' where documento = " + id.ToString());
        }
        public static void AgregarDeudaCliente(int id, string monto)
        {
            SQLite.SqlHelper.ExecuteNonQuery("update cliente set deuda = (deuda + " + monto + ") where documento = " + id.ToString());
        }

    }
}
