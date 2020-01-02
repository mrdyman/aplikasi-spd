using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Maya_KP {
    public static class DbQuery {
        private static string connectionString;
        static DbQuery () {
            string executable = System.Reflection.Assembly.GetExecutingAssembly ().Location;
            string path = (System.IO.Path.GetDirectoryName (executable));
            AppDomain.CurrentDomain.SetData ("DataDirectory", path);
            connectionString = @"Data Source=|DataDirectory|\Databases\spd.db; Version=3; FailIfMissing=True; Foreign Keys=True;";
        }

        public static List<Pegawai> GetPegawai () {
            List<Pegawai> pegawai = new List<Pegawai> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    conn.Open ();
                    string query = "SELECT * FROM v_pegawai";
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Pegawai p = new Pegawai ();
                                p.id = Int32.Parse (reader["id"].ToString ());
                                p.nip = reader["nip"].ToString ();
                                p.nama = reader["nama"].ToString ();
                                p.tgl_lahir = reader["tgl_lahir"].ToString ();
                                p.bidang_id = reader["bidang_id"].ToString ();
                                p.bidang = reader["bidang"].ToString ();
                                p.seksi_id = reader["seksi_id"].ToString ();
                                p.seksi = reader["seksi"].ToString ();
                                p.jabatan_id = reader["jabatan_id"].ToString ();
                                p.jabatan = reader["jabatan"].ToString ();
                                p.pangkat = reader["pangkat"].ToString ();
                                pegawai.Add (p);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return pegawai;
        }

        public static List<Pegawai> GetPegawai (string cari) {
            List<Pegawai> pegawai = new List<Pegawai> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    conn.Open ();
                    string query = "SELECT * FROM v_pegawai WHERE nip like @nip or nama like @nama";
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        cmd.Prepare ();
                        cmd.Parameters.AddWithValue ("@nip", "%" + cari + "%");
                        cmd.Parameters.AddWithValue ("@nama", "%" + cari + "%");
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Pegawai p = new Pegawai ();
                                p.id = Int32.Parse (reader["id"].ToString ());
                                p.nip = reader["nip"].ToString ();
                                p.nama = reader["nama"].ToString ();
                                p.tgl_lahir = reader["tgl_lahir"].ToString ();
                                p.bidang_id = reader["bidang_id"].ToString ();
                                p.bidang = reader["bidang"].ToString ();
                                p.seksi_id = reader["seksi_id"].ToString ();
                                p.seksi = reader["seksi"].ToString ();
                                p.jabatan_id = reader["jabatan_id"].ToString ();
                                p.jabatan = reader["jabatan"].ToString ();
                                p.pangkat = reader["pangkat"].ToString ();
                                pegawai.Add (p);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return pegawai;
        }

        public static Pegawai GetPegawaiById (int id) {
            Pegawai p = new Pegawai ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    conn.Open ();
                    string query = "SELECT * FROM v_pegawai WHERE id = @id";
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        cmd.Prepare ();
                        cmd.Parameters.AddWithValue ("@id", id);
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                p.id = Int32.Parse (reader["id"].ToString ());
                                p.nip = reader["nip"].ToString ();
                                p.nama = reader["nama"].ToString ();
                                p.tgl_lahir = reader["tgl_lahir"].ToString ();
                                p.bidang_id = reader["bidang_id"].ToString ();
                                p.bidang = reader["bidang"].ToString ();
                                p.seksi_id = reader["seksi_id"].ToString ();
                                p.seksi = reader["seksi"].ToString ();
                                p.jabatan_id = reader["jabatan_id"].ToString ();
                                p.jabatan = reader["jabatan"].ToString ();
                                p.pangkat = reader["pangkat"].ToString ();
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return p;
        }

        public static List<Bidang> GetBidang () {
            List<Bidang> bidang = new List<Bidang> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    conn.Open ();
                    string query = "SELECT * FROM bidang";
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Bidang b = new Bidang ();
                                b.id = Int32.Parse (reader["id"].ToString ());
                                b.init = reader["Inisialisasi"].ToString ();
                                b.bidang = reader["Bidang"].ToString ();
                                bidang.Add (b);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }

            return bidang;
        }

        public static List<Seksi> GetSeksi () {
            List<Seksi> seksi = new List<Seksi> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    string query = "SELECT * FROM seksi";
                    conn.Open ();
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Seksi s = new Seksi ();
                                s.id = Int32.Parse (reader["id"].ToString ());
                                s.bidang = reader["Bidang"].ToString ();
                                s.seksi = reader["Seksi"].ToString ();
                                seksi.Add (s);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }

            return seksi;
        }

        public static List<Transport> GetTransport () {
            List<Transport> transport = new List<Transport> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    string query = "SELECT * FROM transportasi";
                    conn.Open ();
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Transport t = new Transport ();
                                t.id = Int32.Parse (reader["id"].ToString ());
                                t.transport = reader["jenis_kendaraan"].ToString ();
                                transport.Add (t);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return transport;
        }

        public static List<Provinsi> GetProvinsi () {
            List<Provinsi> provinsi = new List<Provinsi> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    string query = "SELECT * FROM provinsi";
                    conn.Open ();
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Provinsi t = new Provinsi ();
                                t.kode = reader["kode"].ToString ();
                                t.nama = reader["nama"].ToString ();
                                provinsi.Add (t);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return provinsi;
        }

        public static List<Kota> GetKota (string prv) {
            List<Kota> kota = new List<Kota> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    string query = "SELECT * FROM kota WHERE provinsi = @prv";
                    conn.Open ();
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        cmd.Prepare ();
                        cmd.Parameters.AddWithValue ("@prv", prv);
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Kota k = new Kota ();
                                k.id = Int32.Parse (reader["id"].ToString ());
                                k.provinsi = reader["provinsi"].ToString ();
                                k.kabupaten = reader["kabupaten"].ToString ();
                                kota.Add (k);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return kota;
        }

        public static List<Jabatan> GetJabatan () {
            List<Jabatan> jabatan = new List<Jabatan> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    string query = "SELECT * FROM jabatan";
                    conn.Open ();
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Jabatan j = new Jabatan ();
                                j.id = Int32.Parse (reader["id"].ToString ());
                                j.jabatan = reader["Jabatan"].ToString ();
                                jabatan.Add (j);
                            }
                        }
                    }
                    conn.Close ();

                }
            } catch (SQLiteException e) {
                throw;
            }

            return jabatan;
        }

        public static int InsertPegawai (Pegawai pegawai) {
            int r = -1;
            using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                conn.Open ();
                using (SQLiteCommand cmd = new SQLiteCommand (conn)) {
                    cmd.CommandText = "INSERT INTO pegawai (NIP, Nama, tgl_lahir, Bidang, Seksi, Jabatan, Pangkat) VALUES (@nip, @nama, @tgl_lahir, @bidang, @seksi, @jabatan, @pangkat)";
                    cmd.Prepare ();
                    cmd.Parameters.AddWithValue ("@nip", pegawai.nip);
                    cmd.Parameters.AddWithValue ("@nama", pegawai.nama);
                    cmd.Parameters.AddWithValue ("@tgl_lahir", pegawai.tgl_lahir);
                    cmd.Parameters.AddWithValue ("@bidang", Int32.Parse (pegawai.bidang_id));
                    cmd.Parameters.AddWithValue ("@seksi", Int32.Parse (pegawai.seksi_id));
                    cmd.Parameters.AddWithValue ("@jabatan", Int32.Parse (pegawai.jabatan_id));
                    cmd.Parameters.AddWithValue ("@pangkat", pegawai.pangkat);

                    try {
                        r = cmd.ExecuteNonQuery ();
                    } catch (SQLiteException e) {
                        throw;
                    }
                }
                conn.Close ();
            }
            return r;
        }

        public static int UpdatePegawai (Pegawai pegawai) {
            int r = -1;
            using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                conn.Open ();
                using (SQLiteCommand cmd = new SQLiteCommand (conn)) {
                    cmd.CommandText = "UPDATE pegawai SET NIP = @nip, Nama = @nama, tgl_lahir = @tgl_lahir, Bidang = @bidang, Seksi = @seksi, Jabatan = @jabatan, Pangkat = @pangkat WHERE id = @id";
                    cmd.Prepare ();
                    cmd.Parameters.AddWithValue ("@id", pegawai.id.ToString ());
                    cmd.Parameters.AddWithValue ("@nip", pegawai.nip);
                    cmd.Parameters.AddWithValue ("@nama", pegawai.nama);
                    cmd.Parameters.AddWithValue ("@tgl_lahir", pegawai.tgl_lahir);
                    cmd.Parameters.AddWithValue ("@bidang", Int32.Parse (pegawai.bidang_id));
                    cmd.Parameters.AddWithValue ("@seksi", Int32.Parse (pegawai.seksi_id));
                    cmd.Parameters.AddWithValue ("@jabatan", Int32.Parse (pegawai.jabatan_id));
                    cmd.Parameters.AddWithValue ("@pangkat", pegawai.pangkat);

                    try {
                        r = cmd.ExecuteNonQuery ();
                    } catch (SQLiteException e) {
                        throw;
                    }
                }
                conn.Close ();
            }
            return r;
        }

        public static int DeletePegawai (int id) {
            int r = -1;
            using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                conn.Open ();
                using (SQLiteCommand cmd = new SQLiteCommand (conn)) {
                    cmd.CommandText = "DELETE FROM pegawai WHERE id = @id";
                    cmd.Prepare ();
                    cmd.Parameters.AddWithValue ("@id", id.ToString ());
                    try {
                        r = cmd.ExecuteNonQuery ();
                    } catch (SQLiteException e) {
                        throw;
                    }
                }
                conn.Close ();
            }
            return r;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<Biaya> getBiayaBydata (int data) {
            List<Biaya> biaya = new List<Biaya> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    string query = "SELECT * FROM biaya WHERE data = @data";
                    conn.Open ();
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        cmd.Prepare ();
                        cmd.Parameters.AddWithValue ("@data", data);

                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Biaya t = new Biaya ();
                                t.id = Int32.Parse (reader["id"].ToString ());
                                t.harian = Int32.Parse (reader["harian"].ToString ());
                                t.h_lama = Int32.Parse (reader["h_lama"].ToString ());
                                t.h_total = Int32.Parse (reader["h_total"].ToString ());
                                t.penginapan = Int32.Parse (reader["penginapan"].ToString ());
                                t.p_lama = Int32.Parse (reader["p_lama"].ToString ());
                                t.p_total = Int32.Parse (reader["p_total"].ToString ());
                                t.transport_pp = Int32.Parse (reader["transport_pp"].ToString ());
                                t.transport_loak = Int32.Parse (reader["transport_loak"].ToString ());
                                t.damri = Int32.Parse (reader["damri"].ToString ());
                                t.lain_lain = Int32.Parse (reader["lain"].ToString ());
                                biaya.Add (t);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return biaya;
        }

        public static List<Pengeluaran> getPengeluaran()
        {

            List<Pengeluaran> pengeluaran = new List<Pengeluaran>();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM v_pengeluaran";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pengeluaran p = new Pengeluaran();
                                   p.Nama = reader["Nama"].ToString();
                                   p.harian = Int32.Parse(reader["harian"].ToString());
                                   p.penginapan = Int32.Parse(reader["penginapan"].ToString());
                                   p.transport_pp = Int32.Parse(reader["Transport_PP"].ToString());
                                   p.transport_loak = Int32.Parse(reader["Transport_Lokal"].ToString());
                                   p.damri = Int32.Parse(reader["Damri"].ToString());
                                   p.lain_lain = Int32.Parse(reader["Lain_Lain"].ToString());
                                pengeluaran.Add(p);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (SQLiteException e)
            {
                throw;
            }
            return pengeluaran;
        }

        public static List<Pengikut> getPengikutByData (int data) {
            List<Pengikut> pengikut = new List<Pengikut> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    string query = "SELECT * FROM pengikut WHERE data = @data";
                    conn.Open ();
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        cmd.Prepare ();
                        cmd.Parameters.AddWithValue ("@data", data);

                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Pengikut t = new Pengikut ();
                                t.id = Int32.Parse (reader["id"].ToString ());
                                t.pegawai = Int32.Parse (reader["pegawai"].ToString ());
                                t.ket = reader["ket"].ToString ();
                                t.t_lahir = reader["t_lahir"].ToString ();
                                pengikut.Add (t);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return pengikut;
        }

        public static List<Spd> getSpd () {
            List<Spd> spd = new List<Spd> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    conn.Open ();
                    string query = "SELECT * FROM v_data";
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Spd p = new Spd ();
                                p.id = Int32.Parse (reader["id"].ToString ());
                                p.kode = reader["kode"].ToString ();
                                p.p_nama = reader["p_nama"].ToString ();
                                p.nip = reader["nip"].ToString ();
                                p.t_tujuan = reader["t_tujuan"].ToString ();
                                p.penjabat = reader["penjabat"].ToString ();
                                p.t_jabatan = reader["t_jabatan"].ToString ();
                                p.tgl_berangkat = reader["tgl_berangkat"].ToString ();
                                spd.Add (p);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return spd;
        }

        public static List<Spd> getSpd (string cari) {
            List<Spd> spd = new List<Spd> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    conn.Open ();
                    string query = "SELECT * FROM v_data WHERE p_nama LIKE @nama OR nip LIKE @nip OR t_tujuan LIKE @tujuan";
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        cmd.Prepare ();
                        cmd.Parameters.AddWithValue ("@nip", "%" + cari + "%");
                        cmd.Parameters.AddWithValue ("@nama", "%" + cari + "%");
                        cmd.Parameters.AddWithValue ("@tujuan", "%" + cari + "%");
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Spd p = new Spd ();
                                p.id = Int32.Parse (reader["id"].ToString ());
                                p.kode = reader["kode"].ToString ();
                                p.p_nama = reader["p_nama"].ToString ();
                                p.nip = reader["nip"].ToString ();
                                p.t_tujuan = reader["t_tujuan"].ToString ();
                                p.penjabat = reader["penjabat"].ToString ();
                                p.t_jabatan = reader["t_jabatan"].ToString ();
                                p.tgl_berangkat = reader["tgl_berangkat"].ToString ();
                                spd.Add (p);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return spd;
        }

        public static List<Spd> getSpdById (int id) {
            List<Spd> spd = new List<Spd> ();
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    conn.Open ();
                    string query = "SELECT * FROM v_data WHERE id=@id";
                    using (SQLiteCommand cmd = new SQLiteCommand (query, conn)) {
                        cmd.Prepare ();
                        cmd.Parameters.AddWithValue ("@id", id);
                        using (SQLiteDataReader reader = cmd.ExecuteReader ()) {
                            while (reader.Read ()) {
                                Spd p = new Spd ();
                                p.id = Int32.Parse (reader["id"].ToString ());
                                p.kode = reader["kode"].ToString ();
                                p.pegawai_id = Int32.Parse (reader["pegawai_id"].ToString ());
                                p.p_nama = reader["p_nama"].ToString ();
                                p.nip = reader["nip"].ToString ();
                                p.tb = reader["tb"].ToString ();
                                p.maksud = reader["maksud"].ToString ();
                                p.transport = reader["transport"].ToString ();
                                p.trasport_id = Int32.Parse (reader["transport_id"].ToString ());
                                p.t_berangkat = reader["t_berangkat"].ToString ();
                                p.t_tujuan = reader["t_tujuan"].ToString ();
                                p.t_tujuan_id = Int32.Parse (reader["t_tujuan_id"].ToString ());
                                p.maksud = reader["maksud"].ToString ();
                                p.penjabat = reader["penjabat"].ToString ();
                                p.t_jabatan = reader["t_jabatan"].ToString ();
                                p.lama = Int32.Parse (reader["lama"].ToString ());
                                p.tgl_berangkat = reader["tgl_berangkat"].ToString ();
                                p.tgl_kembali = reader["tgl_kembali"].ToString ();
                                p.no_surat = reader["no_surat"].ToString ();
                                p.tgl_tugas = reader["tgl_tugas"].ToString ();
                                p.akun = reader["akun"].ToString ();
                                spd.Add (p);
                            }
                        }
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return spd;
        }

        public static int InsertSPD (Spd s, List<Pengikut> pengikut, Biaya b) {
            int r = -1;
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    conn.Open ();
                    using (SQLiteTransaction tr = conn.BeginTransaction ()) {
                        using (SQLiteCommand cmd = new SQLiteCommand (conn)) {
                            cmd.Transaction = tr;
                            cmd.CommandText = "INSERT INTO data (kode, pegawai, tb, maksud, transport, t_berangkat, t_tujuan, penjabat, jabatan, lama, tgl_berangkat, tgl_kembali, no_surat, tgl_tugas, akun) VALUES (@kode,@pegawai,@tb,@maksud,@transport,@t_berangkat,@t_tujuan,@penjabat,@jabatan,@lama,@tgl_berangkat,@tgl_kembali,@no_surat,@tgl_tugas,@akun); SELECT last_insert_rowid()";

                            cmd.Prepare ();
                            cmd.Parameters.AddWithValue ("@kode", s.kode);
                            cmd.Parameters.AddWithValue ("@pegawai", s.pegawai_id);
                            cmd.Parameters.AddWithValue ("@tb", s.tb);
                            cmd.Parameters.AddWithValue ("@maksud", s.maksud);
                            cmd.Parameters.AddWithValue ("@transport", s.trasport_id);
                            cmd.Parameters.AddWithValue ("@t_berangkat", s.t_berangkat_id);
                            cmd.Parameters.AddWithValue ("@t_tujuan", s.t_tujuan_id);
                            cmd.Parameters.AddWithValue ("@penjabat", s.penjabat);
                            cmd.Parameters.AddWithValue ("@jabatan", s.t_jabatan);
                            cmd.Parameters.AddWithValue ("@lama", s.lama);
                            cmd.Parameters.AddWithValue ("@tgl_berangkat", s.tgl_berangkat);
                            cmd.Parameters.AddWithValue ("@tgl_kembali", s.tgl_kembali);
                            cmd.Parameters.AddWithValue ("@no_surat", s.no_surat);
                            cmd.Parameters.AddWithValue ("@tgl_tugas", s.tgl_tugas);
                            cmd.Parameters.AddWithValue ("@akun", s.akun);
                            int id = Int32.Parse (cmd.ExecuteScalar ().ToString ());

                            cmd.CommandText = "INSERT INTO biaya(harian, h_lama, h_total, penginapan, p_lama, p_total, transport_pp, transport_loak, damri, lain, data) VALUES (@harian,@h_lama,@h_total,@penginapan,@p_lama,@p_total,@transport_pp,@transport_loak,@damri,@lain,@data)";
                            cmd.Prepare ();
                            cmd.Parameters.AddWithValue ("@harian", b.harian);
                            cmd.Parameters.AddWithValue ("@h_lama", b.h_lama);
                            cmd.Parameters.AddWithValue ("@h_total", b.h_total);
                            cmd.Parameters.AddWithValue ("@penginapan", b.penginapan);
                            cmd.Parameters.AddWithValue ("@p_lama", b.p_lama);
                            cmd.Parameters.AddWithValue ("@p_total", b.p_total);
                            cmd.Parameters.AddWithValue ("@transport_pp", b.transport_pp);
                            cmd.Parameters.AddWithValue ("@transport_loak", b.transport_loak);
                            cmd.Parameters.AddWithValue ("@damri", b.damri);
                            cmd.Parameters.AddWithValue ("@lain", b.lain_lain);
                            cmd.Parameters.AddWithValue ("@data", id);
                            cmd.ExecuteNonQuery ();

                            foreach (var p in pengikut) {
                                cmd.CommandText = "INSERT INTO pengikut (pegawai, ket, data, t_lahir) VALUES (@pegawai, @ket, @data, @t_lahir)";
                                cmd.Parameters.AddWithValue ("@pegawai", p.pegawai);
                                cmd.Parameters.AddWithValue ("@ket", p.ket);
                                cmd.Parameters.AddWithValue ("@data", id);
                                cmd.Parameters.AddWithValue ("@t_lahir", p.t_lahir);
                                cmd.ExecuteNonQuery ();
                            }
                        }
                        tr.Commit ();
                        r = 1;
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return r;
        }

        public static int UpdateSPD (Spd s, List<Pengikut> pengikut, Biaya b) {
            int r = -1;
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    conn.Open ();
                    using (SQLiteTransaction tr = conn.BeginTransaction ()) {
                        using (SQLiteCommand cmd = new SQLiteCommand (conn)) {
                            cmd.Transaction = tr;
                            cmd.CommandText = "UPDATE data SET kode=@kode, pegawai=@pegawai, tb=@tb, maksud=@maksud, transport=@transport, t_berangkat=@t_berangkat, t_tujuan=@t_tujuan, penjabat=@penjabat, jabatan=@jabatan, lama=@lama, tgl_berangkat=@tgl_berangkat, tgl_kembali=@tgl_kembali, no_surat=@no_surat, tgl_tugas=@tgl_tugas, akun=@akun WHERE id=@id";

                            cmd.Prepare ();
                            cmd.Parameters.AddWithValue ("@id", s.id);
                            cmd.Parameters.AddWithValue ("@kode", s.kode);
                            cmd.Parameters.AddWithValue ("@pegawai", s.pegawai_id);
                            cmd.Parameters.AddWithValue ("@tb", s.tb);
                            cmd.Parameters.AddWithValue ("@maksud", s.maksud);
                            cmd.Parameters.AddWithValue ("@transport", s.trasport_id);
                            cmd.Parameters.AddWithValue ("@t_berangkat", s.t_berangkat_id);
                            cmd.Parameters.AddWithValue ("@t_tujuan", s.t_tujuan_id);
                            cmd.Parameters.AddWithValue ("@penjabat", s.penjabat);
                            cmd.Parameters.AddWithValue ("@jabatan", s.t_jabatan);
                            cmd.Parameters.AddWithValue ("@lama", s.lama);
                            cmd.Parameters.AddWithValue ("@tgl_berangkat", s.tgl_berangkat);
                            cmd.Parameters.AddWithValue ("@tgl_kembali", s.tgl_kembali);
                            cmd.Parameters.AddWithValue ("@no_surat", s.no_surat);
                            cmd.Parameters.AddWithValue ("@tgl_tugas", s.tgl_tugas);
                            cmd.Parameters.AddWithValue ("@akun", s.akun);
                            cmd.ExecuteNonQuery ();

                            cmd.CommandText = "UPDATE biaya SET harian=@harian, h_lama=@h_lama, h_total=@h_total, penginapan=@penginapan, p_lama=@p_lama, p_total=@p_total, transport_pp=@transport_pp, transport_loak=@transport_loak, damri=@damri, lain=@lain WHERE id=@id";
                            cmd.Prepare ();
                            cmd.Parameters.AddWithValue ("@id", b.id);
                            cmd.Parameters.AddWithValue ("@harian", b.harian);
                            cmd.Parameters.AddWithValue ("@h_lama", b.h_lama);
                            cmd.Parameters.AddWithValue ("@h_total", b.h_total);
                            cmd.Parameters.AddWithValue ("@penginapan", b.penginapan);
                            cmd.Parameters.AddWithValue ("@p_lama", b.p_lama);
                            cmd.Parameters.AddWithValue ("@p_total", b.p_total);
                            cmd.Parameters.AddWithValue ("@transport_pp", b.transport_pp);
                            cmd.Parameters.AddWithValue ("@transport_loak", b.transport_loak);
                            cmd.Parameters.AddWithValue ("@damri", b.damri);
                            cmd.Parameters.AddWithValue ("@lain", b.lain_lain);
                            cmd.ExecuteNonQuery ();

                            foreach (var p in pengikut) {
                                cmd.CommandText = "INSERT INTO pengikut (pegawai, ket, data, tgl_lahir) VALUES (@pegawai, @ket, @data, @tgl_lahir)";
                                if (p.id != -1) {
                                    cmd.CommandText = "UPDATE pengikut SET pegawai=@pegawai, ket=@ket, data=@data, t_lahir=@t_lahir WHERE id=@id";
                                    cmd.Parameters.AddWithValue ("@id", p.id);
                                }
                                cmd.Parameters.AddWithValue ("@pegawai", p.pegawai);
                                cmd.Parameters.AddWithValue ("@ket", p.ket);
                                cmd.Parameters.AddWithValue ("@data", s.id);
                                cmd.Parameters.AddWithValue ("@t_lahir", p.t_lahir);
                                cmd.ExecuteNonQuery ();
                            }
                        }
                        tr.Commit ();
                        r = 1;
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return r;
        }

        public static int DeleteSPD (int id) {
            int r = -1;
            try {
                using (SQLiteConnection conn = new SQLiteConnection (connectionString)) {
                    conn.Open ();
                    using (SQLiteTransaction tr = conn.BeginTransaction ()) {
                        using (SQLiteCommand cmd = new SQLiteCommand (conn)) {
                            cmd.Transaction = tr;

                            cmd.CommandText = "DELETE FROM data WHERE id=@id";
                            cmd.Prepare ();
                            cmd.Parameters.AddWithValue ("@id", id);
                            cmd.ExecuteNonQuery ();

                            cmd.CommandText = "DELETE FROM biaya WHERE data=@data";
                            cmd.Prepare ();
                            cmd.Parameters.AddWithValue ("@data", id);
                            cmd.ExecuteNonQuery ();

                            cmd.CommandText = "DELETE FROM pengikut WHERE data=@data";
                            cmd.Prepare ();
                            cmd.Parameters.AddWithValue ("@data", id);
                            cmd.ExecuteNonQuery ();
                        }
                        tr.Commit ();
                        r = 1;
                    }
                    conn.Close ();
                }
            } catch (SQLiteException e) {
                throw;
            }
            return r;
        }

        public static DataSet GetDataSet (string sql) {
            SQLiteCommand cmd = new SQLiteCommand (sql, Connection);
            SQLiteDataAdapter adp = new SQLiteDataAdapter (cmd);

            DataSet ds = new DataSet ();
            adp.Fill (ds);
            Connection.Close ();

            return ds;
        }

        static SQLiteConnection _Connection = null;
        public static SQLiteConnection Connection {
            get {
                if (_Connection == null) {
                    _Connection = new SQLiteConnection (connectionString);
                    _Connection.Open ();

                    return _Connection;
                } else if (_Connection.State != System.Data.ConnectionState.Open) {
                    _Connection.Open ();

                    return _Connection;
                } else {
                    return _Connection;
                }
            }
        }

        public static DataTable GetDataTable (string sql) {
            Console.WriteLine (sql);
            DataSet ds = GetDataSet (sql);

            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }

        public static int ExecuteSQL (string sql) {
            SQLiteCommand cmd = new SQLiteCommand (sql, Connection);
            return cmd.ExecuteNonQuery ();
        }
    }
}