using System;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Maya_KP
{
    public partial class FrmKwitansi : MaterialForm
    {
        public FrmKwitansi()
        {
            InitializeComponent();
        }

        private void FrmKwitansi_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM biaya";
            DbQuery.ExecuteSQL(sql);
            DataTable dt = DbQuery.GetDataTable(sql);

            ReportDataSource reportDSDetail = new ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDSDetail);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("total_uang", ktotal_uang.Text));
            reportParameters.Add(new ReportParameter("kterbilang", kterbilang.Text));
            reportParameters.Add(new ReportParameter("ktujuan", ktujuan.Text));

            reportParameters.Add(new ReportParameter("kmaksud", kmaksud.Text));
            reportParameters.Add(new ReportParameter("klama", klama.Text));
            reportParameters.Add(new ReportParameter("ktgl_berangkat", ktglberangkat.Text));
            reportParameters.Add(new ReportParameter("ktgl_pulang", ktglpulang.Text));
            reportParameters.Add(new ReportParameter("ktgl", ktgl.Text));
            reportParameters.Add(new ReportParameter("kpejabat", kpejabat.Text));
            reportParameters.Add(new ReportParameter("knip", knip.Text));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            //this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2);
            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
           // this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

           // this.reportViewer1.RefreshReport();
        }
    }
}
