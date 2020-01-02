using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace Maya_KP
{
    public partial class Form1 : MaterialForm
    {
        public string komitmen, nip;

     //   public string LabelText { get { return labelText; } set { labelText = value; } }
        public Form1()
        {
            InitializeComponent();

            //  Initialize MaterialSkinManager
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblkomitmen.Text = komitmen;
            lblnips.Text = nip;

            string sql = "SELECT * FROM v_data WHERE no_surat = '"+ tbnomor.Text +"'";
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
            reportParameters.Add(new ReportParameter("nm1", nm1.Text));
            reportParameters.Add(new ReportParameter("nm2", nm2.Text));
            reportParameters.Add(new ReportParameter("nm3", nm3.Text));
            reportParameters.Add(new ReportParameter("tgl1", tgl1.Text));
            reportParameters.Add(new ReportParameter("tgl2", tgl2.Text));
            reportParameters.Add(new ReportParameter("tgl3", tgl3.Text));
            reportParameters.Add(new ReportParameter("ket1", ket1.Text));
            reportParameters.Add(new ReportParameter("ket2", ket2.Text));
            reportParameters.Add(new ReportParameter("ket3", ket3.Text));
            reportParameters.Add(new ReportParameter("pembuat_komitmen", komitmen));
            reportParameters.Add(new ReportParameter("nip_komitmen", nip));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            //this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2);

            //sembunyikan label parameter
            nm1.Visible = false;
            nm2.Visible = false;
            nm3.Visible = false;

            tgl1.Visible = false;
            tgl2.Visible = false;
            tgl3.Visible = false;

            ket1.Visible = false;
            ket2.Visible = false;
            ket3.Visible = false;

            //hide label dari report spd
            lblkomitmen.Visible = false;
            lblnips.Visible = false;

            //hide label dari data spd
            lbl_pembuat_komitmen.Visible = false;
            lblnip_komitmen.Visible = false;

            // label3.Text = LabelText;
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
 //           this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            RefSpd();
  //          ReportParameterCollection reportParameters = new ReportParameterCollection();
    //        reportParameters.Add(new ReportParameter("ReportParameter1", fds.lblNPengikut1.Text));
      //      this.reportViewer1.LocalReport.SetParameters(reportParameters);
   //         this.reportViewer1.RefreshReport();
     //       this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            RefPegawai();  
        }

        public void RefPegawai()
        {
            mlvPegawai.Items.Clear();
            List<Pegawai> pegawai = DbQuery.GetPegawai();
            int j = 1;
            foreach (var p in pegawai)
            {
                ListViewItem i = new ListViewItem(j.ToString());
                i.SubItems.Add(p.id.ToString());
                i.SubItems.Add(p.nama.Trim());
                i.SubItems.Add(p.nip.Trim());
                i.SubItems.Add(p.bidang.Trim());
                i.SubItems.Add(p.seksi.Trim());
                i.SubItems.Add(p.jabatan.Trim());
                i.SubItems.Add(p.pangkat.Trim());
                mlvPegawai.Items.Add(i);
                j++;
            }
        }

        public void showlaporan()
        {
            mtbMain.SelectTab(2);
        }

        public void RefSpd()
        {
            mlvSpd.Items.Clear();
            List<Spd> spd = DbQuery.getSpd();
            int j = 1;
            foreach (var s in spd)
            {
                ListViewItem i = new ListViewItem(j.ToString());
                i.SubItems.Add(s.id.ToString());
                i.SubItems.Add(s.kode.Trim());
                i.SubItems.Add(s.p_nama.Trim());
                i.SubItems.Add(s.nip.Trim());
                i.SubItems.Add(s.t_tujuan.Trim());
                i.SubItems.Add(s.penjabat.Trim());
                i.SubItems.Add(s.t_jabatan.Trim());
                i.SubItems.Add(s.tgl_berangkat.Trim());
                mlvSpd.Items.Add(i);
                j++;
            }
        }

        public void RefPengeluaran()
        {
            Pengeluaran_.Items.Clear();
            List<Pengeluaran> pengeluaran = DbQuery.getPengeluaran();
            int j = 1;
            foreach (var p in pengeluaran)
            {
                ListViewItem i = new ListViewItem(j.ToString());
                i.SubItems.Add(p.Nama.ToString());
                i.SubItems.Add("Rp." + p.harian.ToString());
                i.SubItems.Add("Rp." + p.penginapan.ToString());
                i.SubItems.Add("Rp." + p.transport_pp.ToString());
                i.SubItems.Add("Rp." + p.transport_loak.ToString());
                i.SubItems.Add("Rp." + p.damri.ToString());
                i.SubItems.Add("Rp." + p.lain_lain.ToString());
                Pengeluaran_.Items.Add(i);
                j++;
            }
        }

        private void materialTabSelector1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mtbMain.SelectedIndex == 0)
            {

            }
            else if (mtbMain.SelectedIndex == 1)
            {
                RefPegawai();
            }
            else if (mtbMain.SelectedIndex == 2)
            {
              //  FrmDetailSPD asd = new FrmDetailSPD();
              //  ReportParameterCollection reportParameters = new ReportParameterCollection();
              //  reportParameters.Add(new ReportParameter("ReportParameter1", nm1.Text));
             //   reportParameters.Add(new ReportParameter("ReportParameter2", tgl1.Text));
              //  reportParameters.Add(new ReportParameter("ReportParameter3", ket1.Text));

             //   reportParameters.Add(new ReportParameter("ReportParameter4", nm2.Text));
               // reportParameters.Add(new ReportParameter("ReportParameter5", tgl2.Text));
             //   reportParameters.Add(new ReportParameter("ReportParameter6", ket2.Text));

             //   reportParameters.Add(new ReportParameter("ReportParameter7", nm3.Text));
                //reportParameters.Add(new ReportParameter("ReportParameter8", tgl3.Text));
              //  reportParameters.Add(new ReportParameter("ReportParameter9", ket3.Text));
              //  this.reportViewer1.LocalReport.SetParameters(reportParameters);
                this.reportViewer1.RefreshReport();
            } else if (mtbMain.SelectedIndex == 3)
            {
                RefPengeluaran();
            }
        }

        private void btnInputPegawai_Click(object sender, EventArgs e)
        {
            var frmPegawai = new FrmPegawai();
            frmPegawai._aksi = "insert";
            frmPegawai.ShowDialog();
        }

        private void btnUbahPegawai_Click(object sender, EventArgs e)
        {

        }

        private void mlvPegawai_DoubleClick(object sender, EventArgs e)
        {
            var frmAksi = new FrmAksi();
            frmAksi._id = Int32.Parse(mlvPegawai.SelectedItems[0].SubItems[1].Text);
            frmAksi._table = "pegawai";
            frmAksi.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtCariPegawai_TextChanged(object sender, EventArgs e)
        {
            mlvPegawai.Items.Clear();
            List<Pegawai> pegawai = DbQuery.GetPegawai(txtCariPegawai.Text);
            int j = 1;
            foreach (var p in pegawai)
            {
                ListViewItem i = new ListViewItem(j.ToString());
                i.SubItems.Add(p.id.ToString());
                i.SubItems.Add(p.nama.Trim());
                i.SubItems.Add(p.nip.Trim());
                i.SubItems.Add(p.bidang.Trim());
                i.SubItems.Add(p.seksi.Trim());
                i.SubItems.Add(p.jabatan.Trim());
                i.SubItems.Add(p.pangkat.Trim());
                mlvPegawai.Items.Add(i);
                j++;
            }
        }

        private void btnRefSpd_Click(object sender, EventArgs e)
        {
            RefSpd();
        }

        private void btnAddSpd_Click(object sender, EventArgs e)
        {
            FrmSPD spd = new FrmSPD();
            spd.aksi = "insert";
            spd.ShowDialog();
        }

        private void mlvSpd_DoubleClick(object sender, EventArgs e)
        {
            FrmDetailSPD dspd = new FrmDetailSPD();
            dspd.id = Int32.Parse(mlvSpd.SelectedItems[0].SubItems[1].Text);
            dspd.komitmens = komitmen;
            dspd.nipss = nip;
            dspd.ShowDialog();
        }

        private void txtSearchSpd_KeyUp(object sender, KeyEventArgs e)
        {
            mlvSpd.Items.Clear();
            List<Spd> spd = DbQuery.getSpd(txtSearchSpd.Text);
            int j = 1;
            foreach (var s in spd)
            {
                ListViewItem i = new ListViewItem(j.ToString());
                i.SubItems.Add(s.id.ToString());
                i.SubItems.Add(s.kode.Trim());
                i.SubItems.Add(s.p_nama.Trim());
                i.SubItems.Add(s.nip.Trim());
                i.SubItems.Add(s.t_tujuan.Trim());
                i.SubItems.Add(s.penjabat.Trim());
                i.SubItems.Add(s.t_jabatan.Trim());
                i.SubItems.Add(s.tgl_berangkat.Trim());
                mlvSpd.Items.Add(i);
                j++;
            }
        }

        private void txtSearchSpd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnrefresh_Click(object sender, EventArgs e)
        {
            RefSpd();
            this.reportViewer1.RefreshReport();
        }

        private void MaterialRaisedButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btnrefresh_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void MaterialRaisedButton1_Click_2(object sender, EventArgs e)
        {
            FrmRincianPengeluaran go = new FrmRincianPengeluaran();
            go.Show();
        }
    }
}
