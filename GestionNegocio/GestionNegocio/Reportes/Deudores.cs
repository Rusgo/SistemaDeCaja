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
    public partial class Deudores : Form
    {
        public Deudores()
        {
            InitializeComponent();
        }

        private void Deudores_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = SQLite.SqlHelper.Consulta("select * from cliente where deuda < 0");
            int A = tabla.Rows.Count;
            ReportDataSource ds = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter("fecha", DateTime.Now.ToString()));
            reportViewer1.LocalReport.Refresh();
        }
    }
}
