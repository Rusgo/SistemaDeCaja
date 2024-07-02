using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;
using ExcelDataReader;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Management;
using System.Net.NetworkInformation;

namespace GestionNegocio.SQLite
{
    internal class SqlHelper
    {
        public static SQLiteConnection CrearConeccion()
        {
            return new SQLiteConnection("Data Source=bd_negocio.db;Version=3;");
        }
        public static void ExecuteNonQuery(string query)
        {
            using (SQLiteConnection connection = CrearConeccion())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static DataTable Consulta(string query)
        {
            DataTable tabla = new DataTable();
            using (SQLiteConnection connection = CrearConeccion())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command))
                    {
                        dataAdapter.Fill(tabla);
                    }

                }



                connection.Close();
            }
            return tabla;
        }

        public static DataTable Consulta2(string query)
        {
            DataTable tabla = new DataTable();
            //using (SQLiteConnection connection = CrearConeccion())
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=pre_producto.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command))
                    {
                        dataAdapter.Fill(tabla);
                    }

                }



                connection.Close();
            }
            return tabla;
        }
        public static void a()
        {
            DataTable tabla = SQLite.SqlHelper.Consulta2("select * from pre");
        }
        
        
    }
    }

