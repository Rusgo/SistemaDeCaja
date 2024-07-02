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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            cbo_filtro.SelectedItem = "codigo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cargar_combos()
        {
            cbo_marca.DataSource = AccesoDatos.AccesoMarca.RecibirMarcas();
            cbo_marca.DisplayMember = "Descripcion";
            cbo_marca.ValueMember = "codigo";
            cbo_categoria.DataSource = AccesoDatos.AccesoCategoria.RecibirCategorias();
            cbo_categoria.DisplayMember = "Descripcion";
            cbo_categoria.ValueMember = "codigo";
        }

        private void guardar()
        {
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            txt_codigo.Enabled = true;
            btn_guardar.Enabled = true;
        }

        private void modificar()
        {
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            btn_guardar.Enabled = false;
            txt_codigo.Enabled = false;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text != "")
            {
                try
                {
                    AccesoDatos.AccesoProductos.CargarProducto(txt_codigo.Text, txt_nombre.Text, (txt_preciov.Text), (txt_precioc.Text), int.Parse(cbo_marca.SelectedValue.ToString()), int.Parse(cbo_categoria.SelectedValue.ToString()));
                    recuperar_categorias();
                    limpiar_campos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Asegure que los datos cargados sean correctos, si el error persiste revise que el productoi no se encuentre cargado.");
                }
                
            }
            else
            {
                MessageBox.Show("Ingrese un Codigo");
            }
            
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            AccesoDatos.AccesoProductos.eliminarProducto(txt_codigo.Text);
            recuperar_categorias();
            limpiar_campos();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            AccesoDatos.AccesoProductos.modificarProducto(txt_codigo.Text, txt_nombre.Text, (txt_preciov.Text), (txt_precioc.Text), int.Parse(cbo_marca.SelectedValue.ToString()), int.Parse(cbo_categoria.SelectedValue.ToString()));
            recuperar_categorias();
            limpiar_campos();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            cargar_combos();
            recuperar_categorias();
            guardar();
        }
        private void recuperar_categorias()
        {
            dgv_productos.DataSource = AccesoDatos.AccesoProductos.RecibirProductos();
        }

        public void limpiar_campos()
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_precioc.Text = "";
            txt_preciov.Text = "";
            cbo_categoria.SelectedItem = "";
            cbo_marca.SelectedItem = "";
            guardar();
            recuperar_categorias();
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow fila = dgv_productos.Rows[indice];
                txt_codigo.Text = fila.Cells[0].Value.ToString();
                txt_nombre.Text = fila.Cells[1].Value.ToString();
                txt_preciov.Text = fila.Cells[2].Value.ToString();
                txt_precioc.Text = fila.Cells[3].Value.ToString();
                cbo_categoria.Text = fila.Cells[5].Value.ToString();
                cbo_marca.Text = fila.Cells[4].Value.ToString();
                modificar();
            }
        }

        private void dgv_productos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cargam_Click(object sender, EventArgs e)
        {
            Form ventana = new Marcas();
            ventana.Show();
        }

        private void btn_cargac_Click(object sender, EventArgs e)
        {
            Form ventana = new Categorias();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar_combos();
        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            
            string consulta = cbo_filtro.SelectedItem + " like '%" + txt_filtro.Text + "%'";
            DataTable da = AccesoDatos.AccesoProductos.RecibirProductos().Select(consulta).CopyToDataTable();
            if (da.Rows.Count > 0)
            { dgv_productos.DataSource = da; }
            else { MessageBox.Show("No se encontraron datos de ese producto..."); }
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    DataTable tabla = SQLite.SqlHelper.Consulta2("select NOMBREPRODUCTO from pre where CORBARRA = '" + txt_codigo.Text + "'");
                    txt_nombre.Text = tabla.Rows[0][0].ToString();
                }
                catch { }
                

            }
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
