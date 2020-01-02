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
    public partial class FrmPengRill : MaterialForm
    {
        public FrmPengRill()
        {
            InitializeComponent();
        }

        private void FrmPengRill_Load(object sender, EventArgs e)
        {


            string sql = "SELECT * FROM biaya WHERE id='" + pid.Text + "'";
            DbQuery.ExecuteSQL(sql);
            DataTable dt = DbQuery.GetDataTable(sql);

            ReportDataSource reportDSDetail = new ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDSDetail);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("pnama", pnama.Text));
            reportParameters.Add(new ReportParameter("pnip", pnip.Text));
            reportParameters.Add(new ReportParameter("pjabatan", pjabatan.Text));
            reportParameters.Add(new ReportParameter("pnomor", pnomor.Text));
            reportParameters.Add(new ReportParameter("ptgl", ptgl.Text));
            reportParameters.Add(new ReportParameter("ptransportasi", ptransportasi.Text));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            //this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
