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
    public partial class Form2 : Form
    {
        public Form2(Form form)
        {
            InitializeComponent();
            form.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mac = GetMACAddress();
            if (textBox1.Text == "11221155") {
                SQLite.SqlHelper.ExecuteNonQuery("insert into validacion values('"+mac+"')");
                Form ventana = new Form1();
                ventana.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("clave invalida");
            }
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
