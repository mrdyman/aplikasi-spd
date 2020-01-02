using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maya_KP
{
    public partial class FrmAksi : MaterialForm
    {
        public string _table { get; set; }
        public int _id { get; set; }

        public FrmAksi()
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

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if(_table == "pegawai")
            {
                FrmPegawai fp = new FrmPegawai();
                fp._aksi = "update";
                fp._id = _id;
                fp.ShowDialog();
                this.Close();
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if(_table == "pegawai")
            {
                Pegawai p = DbQuery.GetPegawaiById(_id);
                var msgResult = MessageBox.Show("Data " + p.nama + " Akan Dihapus!!!", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (msgResult == DialogResult.Yes)
                {
                    int result = DbQuery.DeletePegawai(_id);
                    string msg = "Terjadi Kesalahan Pada Saat Menghapus Data";
                    if (result > 0)
                    {
                        msg = "Berhasil! Data Telah Terhapus";
                    }
                    MessageBox.Show(msg);
                    if (Application.OpenForms["Form1"] != null)
                    {
                        (Application.OpenForms["Form1"] as Form1).RefPegawai();
                    }
                    this.Close();
                }
            }
        }
    }
}
