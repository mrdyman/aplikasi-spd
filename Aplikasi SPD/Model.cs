using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya_KP
{
    public class Pegawai
    {
        public int id { get; set; }
        public string nip { get; set; }
        public string nama { get; set; }
        public string tgl_lahir { get; set; }
        public string bidang_id { get; set; }
        public string bidang { get; set; }
        public string seksi_id { get; set; }
        public string seksi { get; set; }
        public string jabatan_id { get; set; }
        public string jabatan { get; set; }
        public string pangkat { get; set; }
    }

    public class Bidang
    {
        public int id { get; set; }
        public string init { get; set; }
        public string bidang { get; set; } 
    }

    public class Seksi
    {
        public int id { get; set; }
        public string bidang { get; set; }
        public string seksi { get; set; }
    }

    public class Jabatan
    {
        public int id { get; set; }
        public string jabatan { get; set; }
    }

    public class Spd
    {
        public int id { get; set; }
        public string kode { get; set; }
        public int pegawai_id { get; set; }
        public string p_nama { get; set; }
        public string nip { get; set; }
        public string pangkat { get; set; }
        public string p_jabatan { get; set; }
        public string tb { get; set; }
        public string maksud { get; set; }
        public int trasport_id { get; set; }
        public string transport { get; set; }
        public int t_berangkat_id { get; set; }
        public string t_berangkat { get; set; }
        public int t_tujuan_id { get; set; }
        public string t_tujuan { get; set; }
        public string penjabat { get; set; }
        public string t_jabatan { get; set; }
        public int lama { get; set; }
        public string tgl_berangkat { get; set; }
        public string tgl_kembali { get; set; }
        public string no_surat { get; set; }
        public string tgl_tugas { get; set; }
        public string akun { get; set; }
    }

    public class Transport
    {
        public int id { get; set; }
        public string transport { get; set; }
    }

    public class Provinsi
    {
        public string kode { get; set; }
        public string nama { get; set; }
    }

    public class Kota
    {
        public int id { get; set; }
        public string provinsi { get; set; }
        public string kabupaten { get; set; }
    }

    public class Pengikut
    {
        public int id { get; set; }
        public int pegawai { get; set; }
        public string ket { get; set; }
        public int data { get; set; }

        public string t_lahir { get; set; }
    }

    public  class Biaya
    {
        public int id { get; set; }
        public int harian { get; set; }
        public int h_lama { get; set; }
        public int h_total { get; set; }
        public int penginapan { get; set; }
        public int p_lama { get; set; }
        public int p_total { get; set; }
        public int transport_pp { get; set; }
        public int transport_loak { get; set; }
        public int damri { get; set; }
        public int lain_lain { get; set; }
        public int data { get; set; }
    }


    public class Pengeluaran
    {
        public string Nama { get; set; }
        public int harian { get; set; }
        public int penginapan { get; set; }
        public int transport_pp { get; set; }
        public int transport_loak { get; set; }
        public int damri { get; set; }
        public int lain_lain { get; set; }
    }

    public class _Terbilang
    {
        public  string Terbilang(int x)
        {
            string[] bilangan = { "", "SATU", "DUA", "TIGA", "EMPAT", "LIMA", "ENAM", "TUJUH", "DELAPAN", "SEMBILAN", "SEPULUH", "SEBELAS" };
            string temp = string.Empty;

            if (x < 12)
            {
                temp = " " + bilangan[x];
            }
            else if (x < 20)
            {
                temp = Terbilang(x - 10) + " BELAS";
            }
            else if (x < 100)
            {
                temp = Terbilang(x / 10) + " PULUH" + Terbilang(x % 10);
            }
            else if (x < 200)
            {
                temp = " SERATUS" + Terbilang(x - 100);
            }
            else if (x < 1000)
            {
                temp = Terbilang(x / 100) + " RATUS" + Terbilang(x % 100);
            }
            else if (x < 2000)
            {
                temp = " SERIBU" + Terbilang(x - 1000);
            }
            else if (x < 1000000)
            {
                temp = Terbilang(x / 1000) + " RIBU" + Terbilang(x % 1000);
            }
            else if (x < 1000000000)
            {
                temp = Terbilang(x / 1000000) + " JUTA" +  Terbilang(x % 1000000);
            }

            return temp;
        }
    }
}