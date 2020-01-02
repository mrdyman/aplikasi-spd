using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Maya_KP
{
    public partial class Home : MaterialForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            th_anggaran.Text = currentYear;

            List<Pegawai> pegawai = DbQuery.GetPegawai();
            Dictionary<int, string> dCmbPegawai = new Dictionary<int, string>();
           // dCmbPegawai.Add(-1, "Pilih Pegawai");
            foreach (var p in pegawai)
            {
                dCmbPegawai.Add(p.id, p.nama);
            }
            cmb_komitmen.DataSource = new BindingSource(dCmbPegawai, null);
            cmb_komitmen.DisplayMember = "Value";
            cmb_komitmen.ValueMember = "Key";

            cmb_komitmen.Enabled = false;
        }

        private void Btn_keluar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Btn_masuk_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            //untuk mengirim data pembuat komitmen(kasubag) ke form 1
            form1.komitmen = cmb_komitmen.Text;
            form1.nip = txt_komitmen.Text;

            form1.lbl_pembuat_komitmen.Text = cmb_komitmen.Text;
            form1.lblnip_komitmen.Text = txt_komitmen.Text;
            form1.Show();
        }

        private void Cmb_komitmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            nip_njay();
        }

        void nip_njay()
        {
            if (cmb_komitmen.SelectedIndex == 0)
            {
                txt_komitmen.Text = "-";
            }

            if (cmb_komitmen.SelectedIndex == 0)
            {
                txt_komitmen.Text = "196303181990021001";
            }

            else if (cmb_komitmen.SelectedIndex == 1)
            {
                txt_komitmen.Text = "197010281992031005";
            }

            else if (cmb_komitmen.SelectedIndex == 2)
            {
                txt_komitmen.Text = "197504112006042021";
            }

            else if (cmb_komitmen.SelectedIndex == 3)
            {
                txt_komitmen.Text = "197205162000121001";
            }

            else if (cmb_komitmen.SelectedIndex == 4)
            {
                txt_komitmen.Text = "198005032008011020";
            }

            else if (cmb_komitmen.SelectedIndex == 5)
            {
                txt_komitmen.Text = "198412012009031003";
            }

            else if (cmb_komitmen.SelectedIndex == 6)
            {
                txt_komitmen.Text = "197110161994031007";
            }

            else if (cmb_komitmen.SelectedIndex == 7)
            {
                txt_komitmen.Text = "196204052007012005";
            }

            else if (cmb_komitmen.SelectedIndex == 8)
            {
                txt_komitmen.Text = "198103312010011001";
            }

            else if (cmb_komitmen.SelectedIndex == 9)
            {
                txt_komitmen.Text = "197507212001122002";
            }

            else if (cmb_komitmen.SelectedIndex == 10)
            {
                txt_komitmen.Text = "19740427010012001";
            }

            else if (cmb_komitmen.SelectedIndex == 11)
            {
                txt_komitmen.Text = "198407132011012009";
            }

            else if (cmb_komitmen.SelectedIndex == 12)
            {
                txt_komitmen.Text = "198501292014081002";
            }
            else if (cmb_komitmen.SelectedIndex == 13)
            {
                txt_komitmen.Text = "197106122009011006";
            }else
            {
                txt_komitmen.Text = "-";
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            cmb_komitmen.Enabled = true;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            th_anggaran.Enabled = true;
        }
    }
}
