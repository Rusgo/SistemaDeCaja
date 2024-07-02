using GestionNegocio.SQLite;
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
    public partial class Venta : Form
    {
        float vuelto = 0;
        float monto = 0;
        public Venta()
        {
            InitializeComponent();
            rd_no.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void txt_codigo_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txt_codigo.Text != "")
            {
             
                    DataTable tabla = AccesoDatos.AccesoProductos.ObtenerProducto(txt_codigo.Text);
                    foreach (DataRow fila in tabla.Rows)
                    {
                    bool valorEncontrado = false;

                    // Recorre las filas del DataGridView
                    foreach (DataGridViewRow fila2 in dataGridView1.Rows)
                    {
                        // Obtiene el valor en la celda de la columna "Nombre"
                        string valorCelda = fila2.Cells[0].Value.ToString();

                        // Compara el valor de la celda con el valor buscado
                        if (valorCelda.Equals(txt_codigo.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            string cant_ant = (fila2.Cells[3].Value).ToString();
                            fila2.Cells[3].Value = (int.Parse(cant_ant) + int.Parse(txt_cantidad_1.Text)).ToString();
                            fila2.Cells[4].Value = (int.Parse(fila2.Cells[3].Value.ToString())*float.Parse((fila[2].ToString()).ToString())).ToString();
                            valorEncontrado = true;
                            break; // Termina el bucle si se encuentra el valor
                        }
                    }
                    if (!valorEncontrado)
                        dataGridView1.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), txt_cantidad_1.Text, (int.Parse(txt_cantidad_1.Text) * float.Parse((fila[2].ToString()).ToString())));
                   
                    }

                txt_codigo.Text = "";
                txt_cantidad_1.Text = "1";

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            float total = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                total = total + (int.Parse(dr.Cells[3].Value.ToString()) * float.Parse(dr.Cells[2].Value.ToString()));
            }
            lbl_total.Text = "Total:$" + total.ToString();
            monto = total;
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[indice];
                dataGridView1.Rows.Remove(fila);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[indice];
                dataGridView1.Rows.Remove(fila);
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            float total = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                total = total + (int.Parse(dr.Cells[3].Value.ToString()) * float.Parse(dr.Cells[2].Value.ToString()));
            }
            lbl_total.Text = "Total:$" + total.ToString();
            monto = total;
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            float total = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                total = total + (int.Parse(dr.Cells[3].Value.ToString()) * float.Parse(dr.Cells[2].Value.ToString()));
            }
            lbl_total.Text = "Total:$" + total.ToString();
            monto = total;
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            carga_manual(e);
        }

        private void carga_manual(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txt_precio.Text != "")
            {

                dataGridView1.Rows.Add("",txt_nombre.Text, txt_precio.Text, txt_cantidad_2.Text, (int.Parse(txt_cantidad_2.Text) * float.Parse(txt_precio.Text)));
                txt_precio.Text = "";
                txt_nombre.Text = "";
                txt_cantidad_2.Text = "1";

            }
            
        }

        private void txt_cantidad_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            carga_manual(e);
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            carga_manual(e);
        }

        private void txt_consulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txt_consulta.Text != "")
            {
                DataTable tabla = AccesoDatos.AccesoProductos.ObtenerProducto(txt_consulta.Text);
                foreach (DataRow fila in tabla.Rows)
                {
                    MessageBox.Show("El precio del producto es de: $" + fila[2].ToString(), "Consulta de Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txt_consulta.Text = "";
            }
        }

        private void txt_efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txt_efectivo.Text != "")
            {
                float total = 0;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    total = total + (int.Parse(dr.Cells[3].Value.ToString()) * float.Parse(dr.Cells[2].Value.ToString()));
                }
                txt_vuelto.Text = "Vuelto:$" + ((total - float.Parse(txt_efectivo.Text))*-1).ToString();
                vuelto = ((total - float.Parse(txt_efectivo.Text)) * -1);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = AccesoDatos.AccesoProductos.ObtenerProducto(txt_consulta.Text);
            foreach (DataRow fila in tabla.Rows)
            {
                MessageBox.Show("El precio del producto es de: $" + fila[2].ToString(), "Consulta de Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_cantidad_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txt_codigo.Text != "")
            {
                DataTable tabla = AccesoDatos.AccesoProductos.ObtenerProducto(txt_codigo.Text);
                foreach (DataRow fila in tabla.Rows)
                {
                    bool valorEncontrado = false;

                    foreach (DataGridViewRow fila2 in dataGridView1.Rows)
                    {
                        // Obtiene el valor en la celda de la columna "Nombre"
                        string valorCelda = fila2.Cells[0].Value.ToString();

                        // Compara el valor de la celda con el valor buscado
                        if (valorCelda.Equals(txt_codigo.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            string cant_ant = (fila2.Cells[3].Value).ToString();
                            fila2.Cells[3].Value = (int.Parse(cant_ant) + int.Parse(txt_cantidad_1.Text)).ToString();
                            fila2.Cells[4].Value = (int.Parse(fila2.Cells[3].Value.ToString()) * float.Parse((fila[2].ToString()).ToString())).ToString();
                            break; // Termina el bucle si se encuentra el valor
                        }
                    }
                    if (valorEncontrado)
                        dataGridView1.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), txt_cantidad_1.Text, (int.Parse(txt_cantidad_1.Text) * float.Parse((fila[2].ToString()).ToString())));
                
                }
                txt_codigo.Text = "";
                txt_cantidad_1.Text = "1";
            }

                
            }
        

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            if (lbl_c.Text != "Nombre_Cliente:" || rd_no.Checked)
            {
                if (rd_si.Checked)
                {
                    
                    AccesoDatos.AccesoCliente.AgregarDeudaCliente(int.Parse(txt_dni.Text), (monto*-1).ToString().Replace(",", "."));
                    DataTable tabla = AccesoDatos.AccesoCliente.RecibirCliente((txt_dni.Text));
                    cargar_venta("0");
                    MessageBox.Show("El saldo Actual de  " + tabla.Rows[0][1] + " " + tabla.Rows[0][2] + " es de " + tabla.Rows[0][5] + "pesos");
                }
                else if (rd_no.Checked)
                {
                    cargar_venta("1");
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows.Remove(row);
                }
                monto = 0;
                lbl_c.Text = "Nombre_Cliente:";
            }
            else
            {
                MessageBox.Show("Ingrese un Usuario valido");
            }
            }
            catch (Exception ex) { MessageBox.Show("Ingrese un Usuario valido"); }
        }
        private void cargar_venta(string pagado) {
            if (dataGridView1.Rows.Count > 0)
            {
                DateTime date = DateTime.Now;
                string formatted = date.ToString("yyyy-MM-dd");
                SqlHelper.ExecuteNonQuery("insert into venta (fecha, doc_cliente, pagado, monto) values ( '" + formatted + "','" + txt_dni.Text + "', "+pagado+", " + (monto).ToString().Replace(",", ".") + ")");

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    string codigo= fila.Cells[0].Value.ToString();
                    //nombre
                    string nombre = fila.Cells[1].Value.ToString();
                    string precio = fila.Cells[2].Value.ToString().Replace(",", ".");
                    string cantidad = fila.Cells[3].Value.ToString();
                        if(codigo != "") {
                        string max = SqlHelper.Consulta("select max(id) from venta").Rows[0][0].ToString();
                        SqlHelper.ExecuteNonQuery("insert into detalleventa (id_venta, cod_producto ,cantidad , precio) values (" + max + ", '" + codigo + "'," + cantidad + "," + precio + ")");
                        }
                    else
                    {
                        
                        string max = SqlHelper.Consulta("select max(id) from venta").Rows[0][0].ToString();
                        SqlHelper.ExecuteNonQuery("insert into detalleventa (id_venta, cod_producto ,cantidad , precio) values (" + max + ", '" + nombre + "'," + cantidad + "," + precio + ")");
                    }
                    





                }
                
            }
        }
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter && txt_dni.Text != "")
                {
                    DataTable tabla = AccesoDatos.AccesoCliente.RecibirCliente(txt_dni.Text);
                    lbl_c.Text = "Nombre_Cliente: " + tabla.Rows[0][1] + " " + tabla.Rows[0][2];
                }
            }
            catch (Exception ex) { MessageBox.Show("Ingrese un Usuario valido"); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rd_no_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_no.Checked)
            {
                txt_vuelto.Enabled = true;
                txt_efectivo.Enabled = true;
                txt_vuelto.Text = "Vuelto:$";

            }
            else
            {
                txt_vuelto.Enabled = false;
                txt_efectivo.Enabled = false;
                txt_vuelto.Text = "Vuelto:$";
            }
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
