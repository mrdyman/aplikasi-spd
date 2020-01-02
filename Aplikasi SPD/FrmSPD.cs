using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maya_KP
{
    public partial class FrmSPD : MaterialForm
    {
        public string aksi { get; set; }
        public List<Spd> spd { get; set; }
        public List<Biaya> biaya { get; set; }
        public List<Pengikut> pengikut { get; set; }
        public FrmSPD()
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSPD_Load(object sender, EventArgs e)
        {
            List<Pegawai> pegawai = DbQuery.GetPegawai();
            Dictionary<int, string> dCmbPegawai = new Dictionary<int, string>();
            dCmbPegawai.Add(-1, "Pilih Pegawai");
            foreach (var p in pegawai)
            {
                dCmbPegawai.Add(p.id, p.nip + " | " + p.nama);
            }
            cmbPegawai.DataSource = new BindingSource(dCmbPegawai, null);
            cmbPegawai.DisplayMember = "Value";
            cmbPegawai.ValueMember = "Key";

            List<Transport> transport = DbQuery.GetTransport();
            Dictionary<int, string> dCmbTransport = new Dictionary<int, string>();
            dCmbTransport.Add(-1, "Pilih Transport");
            foreach (var t in transport)
            {
                dCmbTransport.Add(t.id, t.transport);
            }
            cmbTrasportasi.DataSource = new BindingSource(dCmbTransport, null);
            cmbTrasportasi.DisplayMember = "Value";
            cmbTrasportasi.ValueMember = "Key";
            
            Dictionary<int, string> dCmbKotaBerangkat = new Dictionary<int, string>();
            dCmbKotaBerangkat.Add(438, "Kota Palu");
            cmbBerangkat.DataSource = new BindingSource(dCmbKotaBerangkat, null);
            cmbBerangkat.DisplayMember = "Value";
            cmbBerangkat.ValueMember = "Key";

            List<Provinsi> provinsi = DbQuery.GetProvinsi();
            Dictionary<string, string> dCmbProvinsi = new Dictionary<string, string>();
            dCmbProvinsi.Add("", "Pilih Provinsi");
            foreach (var p in provinsi)
            {
                dCmbProvinsi.Add(p.kode, p.nama);
            }
            cmbProvinsi.DataSource = new BindingSource(dCmbProvinsi, null);
            cmbProvinsi.DisplayMember = "Value";
            cmbProvinsi.ValueMember = "Key";

            if(aksi == "update")
            {
                foreach (var s in spd)
                {
                    txtKode.Text = s.kode;
                    txtMaksud.Text = s.maksud;
                    txtPenjabat.Text = s.penjabat;
                    txtTJabatan.Text = s.t_jabatan;
                    txtLama.Text = s.lama.ToString();
                    txtNoSuratTuga.Text = s.no_surat;
                    txtAkun.Text = s.akun;
                    cmbTb.SelectedIndex = cmbTb.FindStringExact(s.tb);
                    cmbPegawai.SelectedValue = s.pegawai_id;
                    cmbTrasportasi.SelectedValue = s.trasport_id;
                    cmbTujuan.SelectedValue = s.t_tujuan_id;
                    if (s.tgl_berangkat != "")
                    {
                        dtTglBerangkat.Value = DateTime.ParseExact(s.tgl_berangkat, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    }
                    if (s.tgl_kembali != "")
                    {
                        dtTglKembali.Value = DateTime.ParseExact(s.tgl_kembali, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    }
                    if (s.tgl_tugas != "")
                    {
                        dtTglSurat.Value = DateTime.ParseExact(s.tgl_tugas, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    }

                    Dictionary<int, string> dCmbKotaTujuan = new Dictionary<int, string>();
                    dCmbKotaTujuan.Add(s.t_tujuan_id, s.t_tujuan);
                    cmbTujuan.DataSource = new BindingSource(dCmbKotaTujuan, null);
                    cmbTujuan.DisplayMember = "Value";
                    cmbTujuan.ValueMember = "Key";
                }

                foreach (var b in biaya)
                {
                    lbTotalHarian.Text = " = Rp" + b.h_total.ToString("N1", CultureInfo.InvariantCulture);
                    txtHarian.Text = b.harian.ToString();
                    txtHLama.Text = b.h_lama.ToString();
                    lblTotalPenginapan.Text = " = Rp" + b.p_total.ToString("N1", CultureInfo.InvariantCulture);
                    txtPenginapan.Text = b.penginapan.ToString();
                    txtP_lama.Text = b.p_lama.ToString();
                    txtTransport.Text = b.transport_pp.ToString();
                    txtLTransport.Text = b.transport_loak.ToString();
                    txtDamri.Text = b.damri.ToString();
                    txtLain_lain.Text = b.lain_lain.ToString();
                }

                if (pengikut.ElementAtOrDefault(0) != null)
                {
                    gpPengikut1.Enabled = true;
                    cbPengikut1.Checked = true;
                    cmbPengikut1.SelectedValue = pengikut[0].pegawai;
                    txtKetPengikut1.Text = pengikut[0].ket;
                }

                if (pengikut.ElementAtOrDefault(1) != null)
                {
                    gpPengikut2.Enabled = true;
                    cbPengikut2.Checked = true;
                    cmbPengikut2.SelectedValue = pengikut[1].pegawai;
                    txtKetPengikut2.Text = pengikut[1].ket;
                }

                if (pengikut.ElementAtOrDefault(2) != null)
                {
                    gpPengikut3.Enabled = true;
                    cbPengikut3.Checked = true;
                    cmbPengikut3.SelectedValue = pengikut[2].pegawai;
                    txtKetPengikut3.Text = pengikut[2].ket;
                }
            }
        }

        private void cmbProvinsi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbTujuan.Enabled = true;
            var prv = ((KeyValuePair<string, string>)cmbProvinsi.SelectedItem).Key.ToString();
            List<Kota> kota = DbQuery.GetKota(prv);
            Dictionary<int, string> dCmbKota = new Dictionary<int, string>();
            dCmbKota.Add(-1, "Pilih Kota");
            foreach (var k in kota)
            {
                dCmbKota.Add(k.id, k.kabupaten);
            }
            cmbTujuan.DataSource = new BindingSource(dCmbKota, null);
            cmbTujuan.DisplayMember = "Value";
            cmbTujuan.ValueMember = "Key";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Spd s = new Spd();
            List<Pengikut> p = new List<Pengikut>();
            Biaya b = new Biaya();

            s.kode = txtKode.Text;
            s.pegawai_id = ((KeyValuePair<int, string>)cmbPegawai.SelectedItem).Key;
            s.tb = cmbTb.SelectedItem.ToString();
            s.maksud = txtMaksud.Text;
            s.trasport_id = ((KeyValuePair<int, string>)cmbTrasportasi.SelectedItem).Key;
            s.t_berangkat_id = ((KeyValuePair<int, string>)cmbBerangkat.SelectedItem).Key;
            s.t_tujuan_id = ((KeyValuePair<int, string>)cmbTujuan.SelectedItem).Key;
            s.penjabat = txtPenjabat.Text;
            s.t_jabatan = txtTJabatan.Text;
            s.lama = Int32.Parse(txtLama.Text);
            s.tgl_berangkat = dtTglBerangkat.Value.ToString("yyyy-MM-dd");
            s.tgl_kembali = dtTglKembali.Value.ToString("yyyy-MM-dd");
            s.no_surat = txtNoSuratTuga.Text;
            s.tgl_tugas = dtTglSurat.Value.ToString("yyyy-MM-dd");
            s.akun = txtAkun.Text;

            if (cbPengikut1.Checked)
            {
                Pengikut p1 = new Pengikut();
                if (aksi == "update")
                {
                    p1.id = pengikut.ElementAtOrDefault(0) == null ? -1 : pengikut[0].id;
                }
                p1.pegawai = ((KeyValuePair<int, string>)cmbPengikut1.SelectedItem).Key;
                p1.ket = txtKetPengikut1.Text;
                p1.t_lahir = tgl_lahir.Text;
                p.Add(p1);
            }

            if (cbPengikut2.Checked)
            {
                Pengikut p2 = new Pengikut();
                if (aksi == "update")
                {
                    p2.id = pengikut.ElementAtOrDefault(1) == null ? -1 : pengikut[1].id;
                }
                p2.pegawai = ((KeyValuePair<int, string>)cmbPengikut2.SelectedItem).Key;
                p2.ket = txtKetPengikut2.Text;
                p2.t_lahir = tgl_lahir1.Text;
                p.Add(p2);
            }

            if (cbPengikut3.Checked)
            {
                Pengikut p3 = new Pengikut();
                if (aksi == "update")
                {
                    p3.id = pengikut.ElementAtOrDefault(2) == null ? -1 : pengikut[2].id;
                }
                p3.pegawai = ((KeyValuePair<int, string>)cmbPengikut3.SelectedItem).Key;
                p3.ket = txtKetPengikut3.Text;
                p3.t_lahir = tgl_lahir2.Text;
                p.Add(p3);
            }

            b.harian = string.IsNullOrEmpty(txtHarian.Text) ? 0 : int.Parse(txtHarian.Text) ;
            b.h_lama = string.IsNullOrEmpty(txtHLama.Text) ? 0 : int.Parse(txtHLama.Text);
            b.h_total = Int32.Parse(txtHLama.Text) * Int32.Parse(txtHarian.Text);
            b.penginapan = string.IsNullOrEmpty(txtPenginapan.Text) ? 0 : int.Parse(txtPenginapan.Text);
            b.p_lama = string.IsNullOrEmpty(txtP_lama.Text) ? 0 : int.Parse(txtP_lama.Text);
            b.p_total = Int32.Parse(txtP_lama.Text) * Int32.Parse(txtPenginapan.Text);
            b.transport_pp = string.IsNullOrEmpty(txtTransport.Text) ? 0 : int.Parse(txtTransport.Text);
            b.transport_loak = string.IsNullOrEmpty(txtLTransport.Text) ? 0 : int.Parse(txtLTransport.Text);
            b.damri = string.IsNullOrEmpty(txtLTransport.Text) ? 0 : int.Parse(txtDamri.Text);
            b.lain_lain = string.IsNullOrEmpty(txtLain_lain.Text) ? 0 : int.Parse(txtLain_lain.Text);
            int result = -1;
            if (aksi == "insert")
            {
                result = DbQuery.InsertSPD(s, p, b);
            }
            else if(aksi == "update")
            {
                foreach (var ss in spd)
                {
                    s.id = ss.id;
                }

                foreach (var bi in biaya)
                {
                    b.id = bi.id;
                }
                result = DbQuery.UpdateSPD(s, p, b);
            }
            string msg = "Terjadi Kesalahan Pada Saat Menyimpan Data";
            if (result > 0)
            {
                msg = "Berhasil! Data Telah Tersimpan";
            }
            MessageBox.Show(msg);
            if (Application.OpenForms["Form1"] != null)
            {
                (Application.OpenForms["Form1"] as Form1).RefSpd();
            }
            this.Close();
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtTglBerangkat_ValueChanged(object sender, EventArgs e)
        {
            HitungLamaPerjalanan();
        }

        void HitungLamaPerjalanan()
        {
            DateTime Tgl_Berangkat = dtTglBerangkat.Value.Date;
            DateTime Tgl_Pulang = dtTglKembali.Value.Date;

            TimeSpan lama = Tgl_Pulang - Tgl_Berangkat;
            int awal = 1;
            int hari = awal + lama.Days;
            txtLama.Text = hari.ToString();
        }

        private void cbPengikut1_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbPengikut1.Checked)
            {
                gpPengikut1.Enabled = true;
                List<Pegawai> pegawai = DbQuery.GetPegawai();
                Dictionary<int, string> dCmbPengikut1 = new Dictionary<int, string>();
                dCmbPengikut1.Add(-1, "Pilih Pegawai");
                foreach (var p in pegawai)
                {
                    dCmbPengikut1.Add(p.id, p.nip + " | " + p.nama);
                }
                cmbPengikut1.DataSource = new BindingSource(dCmbPengikut1, null);
                cmbPengikut1.DisplayMember = "Value";
                cmbPengikut1.ValueMember = "Key";
            }
            else
            {
                gpPengikut1.Enabled = false;
            }
        }

        private void cbPengikut2_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbPengikut2.Checked)
            {
                gpPengikut2.Enabled = true;
                List<Pegawai> pegawai = DbQuery.GetPegawai();
                Dictionary<int, string> dCmbPengikut2 = new Dictionary<int, string>();
                dCmbPengikut2.Add(-1, "Pilih Pegawai");
                foreach (var p in pegawai)
                {
                    dCmbPengikut2.Add(p.id, p.nip + " | " + p.nama);
                }
                cmbPengikut2.DataSource = new BindingSource(dCmbPengikut2, null);
                cmbPengikut2.DisplayMember = "Value";
                cmbPengikut2.ValueMember = "Key";
            }
            else
            {
                gpPengikut2.Enabled = false;
            }
        }

        private void cbPengikut3_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbPengikut3.Checked)
            {
                gpPengikut3.Enabled = true;
                List<Pegawai> pegawai = DbQuery.GetPegawai();
                Dictionary<int, string> dCmbPengikut3 = new Dictionary<int, string>();
                dCmbPengikut3.Add(-1, "Pilih Pegawai");
                foreach (var p in pegawai)
                {
                    dCmbPengikut3.Add(p.id, p.nip + " | " + p.nama);
                }
                cmbPengikut3.DataSource = new BindingSource(dCmbPengikut3, null);
                cmbPengikut3.DisplayMember = "Value";
                cmbPengikut3.ValueMember = "Key";
            }
            else
            {
                gpPengikut3 .Enabled = false;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                MessageBox.Show("Hanya Boleh Angka");
            }
        }

        private void OnlyNumberPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya Boleh Angka");
            }
            else
            {
                
            }
        }

        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (txtHLama.Text != "" && txtHarian.Text != "")
            {
                int sum = Int32.Parse(txtHLama.Text) * Int32.Parse(txtHarian.Text);
                lbTotalHarian.Text = " Rp. " + sum.ToString("N1", CultureInfo.InvariantCulture);   
            }
        }

        private void txtP_lama_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtP_lama.Text != "" && txtPenginapan.Text != "")
            {
                int sum = Int32.Parse(txtP_lama.Text) * Int32.Parse(txtPenginapan.Text);
                lblTotalPenginapan.Text = " Rp. " + sum.ToString("N1", CultureInfo.InvariantCulture);
            }
        }
    }
}
