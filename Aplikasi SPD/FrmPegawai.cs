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
    public partial class FrmPegawai : MaterialForm
    {
        public int _id { get; set; }
        public string _aksi { get; set; }
        public FrmPegawai()
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

        private void frmSPD_Load(object sender, EventArgs e)
        {
            //Fill Combobox bidang
            List<Bidang> bidang = DbQuery.GetBidang();
            Dictionary<int, string> dCmbBidang = new Dictionary<int, string>();
            dCmbBidang.Add(-1, "Pilih Bidang");
            foreach (var b in bidang)
            {
                dCmbBidang.Add(b.id, b.bidang);
            }
            cmbBidang.DataSource = new BindingSource(dCmbBidang, null);
            cmbBidang.DisplayMember = "Value";
            cmbBidang.ValueMember = "Key";

            //Fill Combobox Seksi
            List<Seksi> seksi = DbQuery.GetSeksi();
            Dictionary<int, string> dCmbSeksi = new Dictionary<int, string>();
            dCmbSeksi.Add(-1, "Pilih Seksi");
            foreach (var s in seksi)
            {
                dCmbSeksi.Add(s.id, s.seksi);
            }
            cmbSeksi.DataSource = new BindingSource(dCmbSeksi, null);
            cmbSeksi.DisplayMember = "Value";
            cmbSeksi.ValueMember = "Key";

            //Fill Combobox Jabatan
            List<Jabatan> jabatan = DbQuery.GetJabatan();
            Dictionary<int, string> dCmbJabatan = new Dictionary<int, string>();
            dCmbJabatan.Add(-1, "Pilih Seksi");
            foreach (var j in jabatan)
            {
                dCmbJabatan.Add(j.id, j.jabatan);
            }
            cmbJabatan.DataSource = new BindingSource(dCmbJabatan, null);
            cmbJabatan.DisplayMember = "Value";
            cmbJabatan.ValueMember = "Key";

            if(_aksi == "update")
            {
                Pegawai p = DbQuery.GetPegawaiById(_id);
                txtNama.Text = p.nama;
                txtNip.Text = p.nip;
                txtPangkat.Text = p.pangkat;
                cmbBidang.SelectedValue = Int32.Parse(p.bidang_id);
                cmbSeksi.SelectedValue = Int32.Parse(p.seksi_id);
                cmbJabatan.SelectedValue = Int32.Parse(p.jabatan_id);

                if(p.tgl_lahir != "")
                {
                    dtTglLahir.Value = DateTime.ParseExact(p.tgl_lahir, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                }
            }
        }

        private void frmSPD_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void cmbBidang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //int k = ((KeyValuePair<int, string>)cmbBidang.SelectedItem).Key;
            //string v = ((KeyValuePair<int, string>)cmbBidang.SelectedItem).Value;
            //MessageBox.Show(k.ToString() + " " + v);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int result = -1;
            Pegawai p = new Pegawai();
            p.nip = txtNip.Text;
            p.nama = txtNama.Text;
            p.tgl_lahir = dtTglLahir.Value.ToString("yyyy-MM-dd");
            p.bidang_id = ((KeyValuePair<int, string>)cmbBidang.SelectedItem).Key.ToString();
            p.seksi_id = ((KeyValuePair<int, string>)cmbSeksi.SelectedItem).Key.ToString();
            p.jabatan_id = ((KeyValuePair<int, string>)cmbJabatan.SelectedItem).Key.ToString();
            p.pangkat = txtPangkat.Text;

            if(_aksi == "insert")
            {
                result = DbQuery.InsertPegawai(p);
            }
            else if (_aksi == "update")
            {
                p.id = _id;
                result = DbQuery.UpdatePegawai(p);
            }
            string msg = "Terjadi Kesalahan Pada Saat Menyimpan Data";
            if (result > 0)
            {
                msg = "Berhasil! Data Telah Tersimpan";
            }
            MessageBox.Show(msg);
            if(Application.OpenForms["Form1"] != null)
            {
                (Application.OpenForms["Form1"] as Form1).RefPegawai();
            }
            this.Close();
        }
    }
}
