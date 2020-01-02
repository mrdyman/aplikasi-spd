using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maya_KP
{
    public partial class FrmDetailSPD : MaterialForm
    {
        public int id { get; set; }
        public int _total;
        public string nama1, nama2, nama3, tgl1, tgl2, tgl3, ket1, ket2, ket3;
        public string nomor, tgl_, asal_, tujuan_, pp, lokal, damri_, lain_, terbilang_, nmpejabat_, nip_;

        public string komitmens, nipss;

        private void MaterialRaisedButton4_Click(object sender, EventArgs e)
        {
            FrmPengRill frmpengrill = new FrmPengRill();
            frmpengrill.pid.Text = data_.Text;
            frmpengrill.pnama.Text = lblPNama.Text;
            frmpengrill.pnip.Text = lblNip.Text;
            frmpengrill.pjabatan.Text = lblJabatan.Text;
            frmpengrill.pnomor.Text = lblNoSurat.Text;
            frmpengrill.ptgl.Text = lblTglSurat.Text;
            frmpengrill.ptransportasi.Text = lblTransportLokal.Text;
            frmpengrill.Show();
        }

        private void MaterialRaisedButton3_Click(object sender, EventArgs e)
        {
            FrmKwitansi kwitansi = new FrmKwitansi();
            _Terbilang ter = new _Terbilang();
            spd = DbQuery.getSpdById(id);
            foreach (var s in spd)
            {
                kwitansi.kmaksud.Text = s.maksud;
                kwitansi.klama.Text = s.lama.ToString();
                kwitansi.ktglberangkat.Text = s.tgl_berangkat;
                kwitansi.ktglpulang.Text = s.tgl_kembali;
                kwitansi.ktujuan.Text = s.t_tujuan;
                kwitansi.ktgl.Text = s.tgl_tugas;
                kwitansi.knip.Text = s.nip;
            }
            kwitansi.ktotal_uang.Text = _total.ToString();
            terbilang_ = ter.Terbilang(_total).TrimStart() + " RUPIAH";
            kwitansi.kterbilang.Text = terbilang_.ToString();
            kwitansi.kpejabat.Text = lblPNama.Text;
            kwitansi.Show();
        }

        List<Spd> spd;
        List<Biaya> biaya;
        List<Pengikut> pengikut;

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            FrmRincian go = new FrmRincian();
            //go.Show();

            go.nmr.Text = lblNoSurat.Text;
            go.tgl_.Text = lblTglSurat.Text;
            go.asal_.Text = asal.Text;
            go.tujuan_.Text = tujuan.Text;
            go.lokal.Text = lblTransportLokal.Text;
            go.damri_.Text = lblDamri.Text;
            go.lain_.Text = lblLainLain.Text;
            go.total_.Text = total.Text;
            go.terbilang_.Text = terbilang.Text;
            go.nmpejabat_.Text =lblPNama.Text;
            go.nip_.Text = lblNip.Text;

            go.tbnosurat_.Text = data_.Text;
            go.pp.Text = lblTransportPP.Text;
            go.Show();
        }

        public FrmDetailSPD()
        {
            InitializeComponent();
        }

        private void FrmDetailSPD_Load(object sender, EventArgs e)
        {
            //hide label dan komponen passing data
            lblkomitmen.Visible = false;
            lblnip_komitmen.Visible = false;

            data_.Visible = false;
            lama.Visible = false;
            asal.Visible = false;
            tujuan.Visible = false;
            total.Visible = false;
            terbilang.Visible = false;

            Form1 _nm1 = new Form1();
            spd = DbQuery.getSpdById(id);
            foreach (var s in spd)
            {
                lblPNama.Text = s.p_nama;
                lblKode.Text = s.kode;
                lblNip.Text = s.nip;
                lblMaksud.Text = s.maksud;
                lblTB.Text = s.tb;
                lblTransportasi.Text = s.transport;
                lblTBerangkat.Text = s.t_berangkat;
                lblTTujuan.Text = s.t_tujuan;
                lblTNama.Text = s.penjabat;
                lblJabatan.Text = s.t_jabatan;
                lblTglBerangkat.Text = s.tgl_berangkat;
                lblTglKemabali.Text = s.tgl_kembali;
                lblLama.Text = s.lama.ToString();
                lblNoSurat.Text = s.no_surat;
                lblTglSurat.Text = s.tgl_tugas;
                lblAkun.Text = s.akun;

                tujuan.Text = s.t_tujuan;


                lblkomitmen.Text = komitmens;
                lblnip_komitmen.Text = nipss;
            }

            biaya = DbQuery.getBiayaBydata(id);
            foreach (var b in biaya)
            {
                lblUangHarian.Text = "Rp. "+ b.h_total.ToString();
                lblPenginapan.Text = "Rp. "+ b.p_total.ToString();
                lblTransportPP.Text = "Rp. " + b.transport_pp.ToString();
                lblTransportLokal.Text = "Rp. " + b.transport_loak.ToString();
                lblDamri.Text = "Rp. " + b.damri.ToString();
                lblLainLain.Text = "Rp. " + b.lain_lain.ToString();

                data_.Text = b.id.ToString();

                lama.Text = b.h_lama.ToString() + " Hari";
                _total = (b.h_total) + (b.p_total) + (b.transport_pp) + (b.transport_loak) + (b.damri) + (b.lain_lain);
                total.Text = " Rp." + _total.ToString("N0", CultureInfo.InvariantCulture);

                _Terbilang ter = new _Terbilang();
                terbilang.Text = ter.Terbilang(_total).TrimStart() +" RUPIAH";
            }

            pengikut = DbQuery.getPengikutByData(id);
            if(pengikut.ElementAtOrDefault(0) != null)
            {
                Pegawai p = DbQuery.GetPegawaiById(pengikut[0].pegawai);
                lblNPengikut1.Text = p.nama;
                lblTglPengikut1.Text = pengikut[0].t_lahir;
                lblKetPengikut1.Text = pengikut[0].ket;
            }

            if (pengikut.ElementAtOrDefault(1) != null)
            {
                Pegawai p = DbQuery.GetPegawaiById(pengikut[1].pegawai);
                lblNPengikut2.Text = p.nama;
                lblTglPengikut2.Text = pengikut[1].t_lahir;
                lblKetPengikut2.Text = pengikut[1].ket;
            }

            if (pengikut.ElementAtOrDefault(2) != null)
            {
                Pegawai p = DbQuery.GetPegawaiById(pengikut[2].pegawai);
                lblNPengikut3.Text = p.nama;
                lblTglPengikut3.Text = pengikut[2].t_lahir;
                lblKetPengikut3.Text = pengikut[2].ket;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            FrmSPD spd = new FrmSPD();
            spd.spd = this.spd;
            spd.biaya = this.biaya;
            spd.pengikut = this.pengikut;
            spd.aksi = "update";
            this.Close();
            spd.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var msgResult = MessageBox.Show("Data  Akan Dihapus!!!", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (msgResult == DialogResult.Yes)
            {
                int result = DbQuery.DeleteSPD(id);
                string msg = "Terjadi Kesalahan Pada Saat Menghapus Data";
                if (result > 0)
                {
                    msg = "Berhasil! Data Telah Dihapus";
                }
                MessageBox.Show(msg);
                if (Application.OpenForms["Form1"] != null)
                {
                    (Application.OpenForms["Form1"] as Form1).RefSpd();
                }
                this.Close();
            }
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MaterialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            nama1 = lblNPengikut1.Text;
            nama2 = lblNPengikut2.Text;
            nama3 = lblNPengikut3.Text;

            tgl1 = lblTglPengikut1.Text;
            tgl2 = lblTglPengikut2.Text;
            tgl3 = lblTglPengikut3.Text;

            ket1 = lblKetPengikut1.Text;
            ket2 = lblKetPengikut2.Text;
            ket3 = lblKetPengikut3.Text;

            Form1 go = new Form1 ();
            go.tbnomor.Text = lblNoSurat.Text;
         //   go.Show();

            go.nm1.Text = nama1;
            go.nm2.Text = nama2;
            go.nm3.Text = nama3;

            go.tgl1.Text = tgl1;
            go.tgl2.Text = tgl2;
            go.tgl3.Text = tgl3;

            go.ket1.Text = ket1;
            go.ket2.Text = ket2;
            go.ket3.Text = ket3;

            go.komitmen = komitmens;
            go.nip = nipss;

            go.Show();
            go.showlaporan();
        }
    }
}
