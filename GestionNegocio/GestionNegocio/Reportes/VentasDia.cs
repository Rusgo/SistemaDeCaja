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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionNegocio.Reportes
{
    public partial class VentasDia : Form
    {
        public VentasDia()
        {
            InitializeComponent();
        }

        private void VentasDia_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string formatted = date.ToString("yyyy-MM-dd");
            DataTable tabla = SQLite.SqlHelper.Consulta("SELECT P.descripcion, sum(D.cantidad) as cantidad, D.precio, D.cod_producto FROM venta V JOIN detalleventa D ON V.id = D.id_venta JOIN producto P ON D.cod_producto = P.codigo WHERE V.fecha = '" + formatted + "' GROUP BY D.COD_PRODUCTO, D.precio");
            int A = tabla.Rows.Count;
            ReportDataSource ds = new ReportDataSource("DataSet1", tabla);

            DataTable tabla1 = SQLite.SqlHelper.Consulta("select sum(monto) from venta where pagado = 0 and fecha = '"+ formatted+"'");
            DataTable tablae = SQLite.SqlHelper.Consulta("select sum(monto) from venta where pagado = 1 and fecha ='" + formatted + "'");
            float fiado = 0;
            float efectivo = 0;
            if (tabla1.Rows[0][0].ToString() != "") { fiado = float.Parse(tabla1.Rows[0][0].ToString()); }
            if (tablae.Rows[0][0].ToString() != "") { efectivo = float.Parse(tablae.Rows[0][0].ToString()); }

            float total = (fiado + efectivo);

            ReportParameter[] parameters = new ReportParameter[]
            {
            new ReportParameter("Total", (total).ToString()),
            new ReportParameter("fecha", DateTime.Now.ToString()),
            new ReportParameter("fiado", fiado.ToString()),
            new ReportParameter("efectivo", efectivo.ToString())
            
            };
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
            reportViewer1.LocalReport.Refresh();
        }
    }
    }


