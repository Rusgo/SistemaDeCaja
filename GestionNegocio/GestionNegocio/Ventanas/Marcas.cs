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
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void guardar()
        {
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            txt_codigo.Enabled = false;
            btn_guardar.Enabled = true;
        }

        private void modificar()
        {
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            btn_guardar.Enabled = false;
        }

        private int proximo_id()
        {
            if (dgv_marca.Rows.Count > 0)
            {
                DataGridViewRow fila_ultima = dgv_marca.Rows[dgv_marca.Rows.Count - 1];
                return int.Parse(fila_ultima.Cells[0].Value.ToString()) + 1;
            }
            else { return 0; }

        }
        
        private void Marcas_Load(object sender, EventArgs e)
        {
            recuperar_marcas();
            guardar();
            txt_codigo.Text = proximo_id().ToString();
            
        }

        public void limpiar_campos()
        {
            txt_codigo.Text = proximo_id().ToString();
            txt_desc.Text = "";
            guardar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            AccesoDatos.AccesoMarca.CargarMarca(int.Parse(txt_codigo.Text), txt_desc.Text);
            recuperar_marcas();
            limpiar_campos();
        }

        private void recuperar_marcas()
        {
            dgv_marca.DataSource = AccesoDatos.AccesoMarca.RecibirMarcas();
        }

        private void dgv_marca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0) { 
                DataGridViewRow fila = dgv_marca.Rows[indice];
                txt_codigo.Text = fila.Cells[0].Value.ToString();
                txt_desc.Text = fila.Cells[1].Value.ToString();
                modificar();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            AccesoDatos.AccesoMarca.modificarMarca(int.Parse(txt_codigo.Text), txt_desc.Text);
            recuperar_marcas();
            limpiar_campos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            AccesoDatos.AccesoMarca.eliminarMarca(int.Parse(txt_codigo.Text));
            recuperar_marcas();
            limpiar_campos();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            string consulta = "descripcion like ´%" + txt_filtro.Text + "%'";
            dgv_marca.DataSource = AccesoDatos.AccesoMarca.RecibirMarcas().Select(consulta).CopyToDataTable();
        }
    }
}
