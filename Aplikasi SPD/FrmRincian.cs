using System;
using System.Collections.Generic;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Maya_KP {
    public partial class FrmRincian : MaterialForm {
        public FrmRincian () {
            InitializeComponent ();
        }
        private void FrmRincian_Load (object sender, EventArgs e) {

            string sql = "SELECT * FROM biaya WHERE id='"+ tbnosurat_.Text +"'";
            DbQuery.ExecuteSQL(sql);
            DataTable dt = DbQuery.GetDataTable(sql);

            ReportDataSource reportDSDetail = new ReportDataSource("DataSet1", dt);
           this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDSDetail);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

            // TODO: This line of code loads data into the 'DataSet1.DataTable2' table. You can move, or remove it, as needed.
            //   this.DataTable2TableAdapter.Fill (this.DataSet1.DataTable2);

            ReportParameterCollection reportParameters = new ReportParameterCollection();
                     reportParameters.Add(new ReportParameter("no_surat", nmr.Text));
                   reportParameters.Add(new ReportParameter("tgl", tgl_.Text));
                 reportParameters.Add(new ReportParameter("asal", asal_.Text));
               reportParameters.Add(new ReportParameter("tujuan", tujuan_.Text));
                     reportParameters.Add(new ReportParameter("pp", pp.Text));
                   reportParameters.Add(new ReportParameter("lokal", lokal.Text));
                 reportParameters.Add(new ReportParameter("damri", damri_.Text));
               reportParameters.Add(new ReportParameter("lain", lain_.Text));
                 reportParameters.Add(new ReportParameter("total", total_.Text));
               reportParameters.Add(new ReportParameter("terbilang", terbilang_.Text));
                reportParameters.Add(new ReportParameter("nama_pejabat", nmpejabat_.Text));
              reportParameters.Add(new ReportParameter("nip", nip_.Text));
                this.reportViewer1.LocalReport.SetParameters(reportParameters);

            //this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2);
             this.reportViewer1.RefreshReport ();
        }

        private void ReportViewer1_Load (object sender, EventArgs e) {

        }

        private void DataTable2BindingSource_CurrentChanged (object sender, EventArgs e) {

        }

        private void Nmr_Click (object sender, EventArgs e) {

        }

        private void Tgl__Click (object sender, EventArgs e) {

        }

        private void Asal__Click (object sender, EventArgs e) {

        }

        private void Tujuan_Click (object sender, EventArgs e) {

        }

        private void Lokal_Click (object sender, EventArgs e) {

        }

        private void Damri_Click (object sender, EventArgs e) {

        }

        private void Lain_Click (object sender, EventArgs e) {

        }

        private void Total_Click (object sender, EventArgs e) {

        }

        private void Terbilang__Click (object sender, EventArgs e) {

        }

        private void Nmpejabat__Click (object sender, EventArgs e) {

        }

        private void Nip__Click (object sender, EventArgs e) {

        }
    }
}