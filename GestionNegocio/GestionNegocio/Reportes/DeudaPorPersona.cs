using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNegocio.Reportes
{
    public partial class DeudaPorPersona : Form
    {
        public DeudaPorPersona()
        {
            InitializeComponent();
        }

        private void DeudaPorPersona_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btn_buscat_Click(object sender, EventArgs e)
        {
            DataTable tabla = SQLite.SqlHelper.Consulta("SELECT P.descripcion, sum(D.cantidad) as cantidad, D.precio, D.cod_producto FROM venta V JOIN detalleventa D ON V.id = D.id_venta JOIN producto P ON D.cod_producto = P.codigo WHERE V.pagado = 0 AND V.doc_cliente = '" + textBox1.Text+ "' GROUP BY D.COD_PRODUCTO, D.precio");
            int A = tabla.Rows.Count;
            ReportDataSource ds = new ReportDataSource("DataSet2", tabla);
           ReportParameter[] parameters = new ReportParameter[]
{
            new ReportParameter("fecha", DateTime.Now.ToString()),
            new ReportParameter("doc", textBox1.Text)

};
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
            reportViewer1.LocalReport.Refresh();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
