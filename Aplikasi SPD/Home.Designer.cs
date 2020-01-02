namespace Maya_KP
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.nm_instansi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nm_kota = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmb_komitmen = new System.Windows.Forms.ComboBox();
            this.txt_komitmen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.th_anggaran = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_masuk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_keluar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(208, 150);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(146, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Tahun Anggaran";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(208, 184);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(132, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Nama Instansi";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(208, 218);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(105, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Nama Kota";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(208, 252);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(248, 24);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Pejabat Pembuat Komitmen";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(208, 286);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(41, 24);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "NIP";
            // 
            // nm_instansi
            // 
            this.nm_instansi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nm_instansi.Depth = 0;
            this.nm_instansi.Enabled = false;
            this.nm_instansi.Hint = "";
            this.nm_instansi.Location = new System.Drawing.Point(494, 181);
            this.nm_instansi.MaxLength = 32767;
            this.nm_instansi.MouseState = MaterialSkin.MouseState.HOVER;
            this.nm_instansi.Name = "nm_instansi";
            this.nm_instansi.PasswordChar = '\0';
            this.nm_instansi.SelectedText = "";
            this.nm_instansi.SelectionLength = 0;
            this.nm_instansi.SelectionStart = 0;
            this.nm_instansi.Size = new System.Drawing.Size(606, 28);
            this.nm_instansi.TabIndex = 7;
            this.nm_instansi.TabStop = false;
            this.nm_instansi.Text = "Kementerian Kelautan dan Perikanan Prov. Sulteng";
            this.nm_instansi.UseSystemPasswordChar = false;
            // 
            // nm_kota
            // 
            this.nm_kota.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nm_kota.Depth = 0;
            this.nm_kota.Enabled = false;
            this.nm_kota.Hint = "";
            this.nm_kota.Location = new System.Drawing.Point(494, 215);
            this.nm_kota.MaxLength = 32767;
            this.nm_kota.MouseState = MaterialSkin.MouseState.HOVER;
            this.nm_kota.Name = "nm_kota";
            this.nm_kota.PasswordChar = '\0';
            this.nm_kota.SelectedText = "";
            this.nm_kota.SelectionLength = 0;
            this.nm_kota.SelectionStart = 0;
            this.nm_kota.Size = new System.Drawing.Size(94, 28);
            this.nm_kota.TabIndex = 8;
            this.nm_kota.TabStop = false;
            this.nm_kota.Text = "Palu";
            this.nm_kota.UseSystemPasswordChar = false;
            // 
            // cmb_komitmen
            // 
            this.cmb_komitmen.FormattingEnabled = true;
            this.cmb_komitmen.Location = new System.Drawing.Point(494, 253);
            this.cmb_komitmen.Name = "cmb_komitmen";
            this.cmb_komitmen.Size = new System.Drawing.Size(351, 24);
            this.cmb_komitmen.TabIndex = 9;
            this.cmb_komitmen.SelectedIndexChanged += new System.EventHandler(this.Cmb_komitmen_SelectedIndexChanged);
            // 
            // txt_komitmen
            // 
            this.txt_komitmen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_komitmen.Depth = 0;
            this.txt_komitmen.Enabled = false;
            this.txt_komitmen.Hint = "";
            this.txt_komitmen.Location = new System.Drawing.Point(494, 283);
            this.txt_komitmen.MaxLength = 32767;
            this.txt_komitmen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_komitmen.Name = "txt_komitmen";
            this.txt_komitmen.PasswordChar = '\0';
            this.txt_komitmen.SelectedText = "";
            this.txt_komitmen.SelectionLength = 0;
            this.txt_komitmen.SelectionStart = 0;
            this.txt_komitmen.Size = new System.Drawing.Size(351, 28);
            this.txt_komitmen.TabIndex = 10;
            this.txt_komitmen.TabStop = false;
            this.txt_komitmen.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::Maya_KP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Lucida Grande", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "APLIKASI SURAT PERJALANAN DINAS (SPD)";
            // 
            // th_anggaran
            // 
            this.th_anggaran.BackColor = System.Drawing.SystemColors.Window;
            this.th_anggaran.Depth = 0;
            this.th_anggaran.Enabled = false;
            this.th_anggaran.Hint = "";
            this.th_anggaran.Location = new System.Drawing.Point(494, 150);
            this.th_anggaran.MaxLength = 32767;
            this.th_anggaran.MouseState = MaterialSkin.MouseState.HOVER;
            this.th_anggaran.Name = "th_anggaran";
            this.th_anggaran.PasswordChar = '\0';
            this.th_anggaran.SelectedText = "";
            this.th_anggaran.SelectionLength = 0;
            this.th_anggaran.SelectionStart = 0;
            this.th_anggaran.Size = new System.Drawing.Size(94, 28);
            this.th_anggaran.TabIndex = 6;
            this.th_anggaran.TabStop = false;
            this.th_anggaran.UseSystemPasswordChar = false;
            // 
            // btn_masuk
            // 
            this.btn_masuk.AutoSize = true;
            this.btn_masuk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_masuk.Depth = 0;
            this.btn_masuk.Icon = null;
            this.btn_masuk.Location = new System.Drawing.Point(561, 326);
            this.btn_masuk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_masuk.Name = "btn_masuk";
            this.btn_masuk.Primary = true;
            this.btn_masuk.Size = new System.Drawing.Size(81, 36);
            this.btn_masuk.TabIndex = 15;
            this.btn_masuk.Text = "Masuk";
            this.btn_masuk.UseVisualStyleBackColor = true;
            this.btn_masuk.Click += new System.EventHandler(this.Btn_masuk_Click);
            // 
            // btn_keluar
            // 
            this.btn_keluar.AutoSize = true;
            this.btn_keluar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_keluar.Depth = 0;
            this.btn_keluar.Icon = null;
            this.btn_keluar.Location = new System.Drawing.Point(658, 326);
            this.btn_keluar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Primary = true;
            this.btn_keluar.Size = new System.Drawing.Size(85, 36);
            this.btn_keluar.TabIndex = 16;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.Btn_keluar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(851, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Edit";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(594, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Edit";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1124, 452);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.btn_masuk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_komitmen);
            this.Controls.Add(this.cmb_komitmen);
            this.Controls.Add(this.nm_kota);
            this.Controls.Add(this.nm_instansi);
            this.Controls.Add(this.th_anggaran);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialLabel materialLabel4;
        public MaterialSkin.Controls.MaterialLabel materialLabel5;
        public MaterialSkin.Controls.MaterialLabel materialLabel6;
        public MaterialSkin.Controls.MaterialSingleLineTextField nm_instansi;
        public MaterialSkin.Controls.MaterialSingleLineTextField nm_kota;
        public System.Windows.Forms.ComboBox cmb_komitmen;
        public MaterialSkin.Controls.MaterialSingleLineTextField txt_komitmen;
        private System.Windows.Forms.Label label1;
        public MaterialSkin.Controls.MaterialSingleLineTextField th_anggaran;
        private MaterialSkin.Controls.MaterialRaisedButton btn_masuk;
        private MaterialSkin.Controls.MaterialRaisedButton btn_keluar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}