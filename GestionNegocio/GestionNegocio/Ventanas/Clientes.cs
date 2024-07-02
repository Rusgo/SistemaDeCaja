using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNegocio.Ventanas
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            cbo_filtro.SelectedItem = "Documento";
        }

        private void recuperar_cliente()
        {
            dgv_clientes.DataSource = AccesoDatos.AccesoCliente.RecibirCliente();
        }

        private void guardar()
        {
            txt_deuda.Visible = false;
            txt_deuda.Text = "";
            btn_cobrar.Visible = false;
            lbl_cobro.Visible = false;
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_guardar.Enabled = true;
        }

        private void modificar()
        {
            txt_deuda.Visible = true;
            btn_cobrar.Visible = true;
            lbl_cobro.Visible = true;
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            btn_guardar.Enabled = false;

        }

        public void limpiar_campos()
        {
            txt_documento.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_telefono.Text = "";
            txt_dire.Text = "";
            guardar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //modificar
            AccesoDatos.AccesoCliente.modificarCliente(int.Parse(txt_documento.Text), txt_nombre.Text, (txt_apellido.Text), (txt_dire.Text), (txt_telefono.Text));
            recuperar_cliente();
            limpiar_campos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //guardar
            if (txt_documento.Text != "")
            {
                AccesoDatos.AccesoCliente.CargarCliente(int.Parse(txt_documento.Text), txt_nombre.Text, (txt_apellido.Text), (txt_dire.Text), (txt_telefono.Text));
                recuperar_cliente();
                limpiar_campos();
            }
            else
            {
                MessageBox.Show("Ingrese un documento para identificar a la persona.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //eliminar
            AccesoDatos.AccesoCliente.eliminarCliente(int.Parse(txt_documento.Text));
            recuperar_cliente();
            limpiar_campos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //limpiar
            limpiar_campos();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            recuperar_cliente();
            guardar();
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow fila = dgv_clientes.Rows[indice];
                txt_documento.Text = fila.Cells[0].Value.ToString();
                txt_nombre.Text = fila.Cells[1].Value.ToString();
                txt_apellido.Text = fila.Cells[2].Value.ToString();
                txt_dire.Text = fila.Cells[3].Value.ToString();
                txt_telefono.Text = fila.Cells[4].Value.ToString();
                txt_deuda.Text = fila.Cells[5].Value.ToString().Remove(0,1);
                modificar();
            }
        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            string consulta = cbo_filtro.SelectedItem + " like '%" + txt_filtro.Text + "%'";
            DataTable da = AccesoDatos.AccesoCliente.RecibirCliente().Select(consulta).CopyToDataTable();
            if (da.Rows.Count > 0) { dgv_clientes.DataSource = da; }
            else { MessageBox.Show("No se encontraron clientes con esos datos..."); }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_deuda.Text != "") {
                AccesoDatos.AccesoCliente.AgregarDeudaCliente(int.Parse(txt_documento.Text), txt_deuda.Text.Replace(",", "."));
                SQLite.SqlHelper.ExecuteNonQuery("update venta set pagado = 1 where doc_cliente = " + txt_documento.Text);
                DataTable tabla = AccesoDatos.AccesoCliente.RecibirCliente((txt_documento.Text));
                if (0 <= float.Parse(tabla.Rows[0][5].ToString()) && float.Parse(tabla.Rows[0][5].ToString()) < 1)
                {
                    SQLite.SqlHelper.ExecuteNonQuery("update cliente set deuda = 0 where documento = " + txt_documento.Text);
                }

                recuperar_cliente();
                limpiar_campos();
            }
            
        }
    }
}
