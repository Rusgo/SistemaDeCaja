using GestionNegocio.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNegocio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventanas.Productos();
            ventana.Show();
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventanas.Categorias();
            ventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventanas.Venta();
            ventana.Show();
        }

        private void btn_marcas_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventanas.Marcas();
            ventana.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataTable tablita = SqlHelper.Consulta("select * from venta");
            foreach (DataRow dr in tablita.Rows)
            {
                MessageBox.Show(dr[0].ToString() + dr[1].ToString() + dr[2].ToString() + dr[3].ToString());
            }
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventanas.Clientes();
            ventana.Show();
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Reportes.ReporteProductos();
            ventana.Show();
        }

        private void reporteDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Reportes.Deudores();
            ventana.Show();
        }

        private void productosAdeudadosDePagoPorPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Reportes.DeudaPorPersona();
            ventana.Show();
        }

        private void ventasDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Reportes.VentasDia();
            ventana.Show();
        }

        private void ventasDelMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Reportes.VentasMes();
            ventana.Show();
        }

        private void sistemaCobroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventanas.Venta();
            ventana.Show();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventanas.Clientes();
            ventana.Show();
        }

        private void gestionarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventanas.Categorias();
            ventana.Show();
        }

        private void gestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventanas.Productos();
            ventana.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventanas.Marcas();
            ventana.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string mac = GetMACAddress();
            
            
            DataTable tabla = SQLite.SqlHelper.Consulta("select codigo from validacion where codigo = '" + mac + "'");
            if (tabla.Rows.Count == 0) { new Form2(this).Show(); }
        }

        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }
    }
}
