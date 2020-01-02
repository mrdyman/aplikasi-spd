namespace Maya_KP
{
    partial class FrmRincian
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Maya_KP.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nmr = new MaterialSkin.Controls.MaterialLabel();
            this.tgl_ = new MaterialSkin.Controls.MaterialLabel();
            this.asal_ = new MaterialSkin.Controls.MaterialLabel();
            this.tujuan_ = new MaterialSkin.Controls.MaterialLabel();
            this.lokal = new MaterialSkin.Controls.MaterialLabel();
            this.damri_ = new MaterialSkin.Controls.MaterialLabel();
            this.lain_ = new MaterialSkin.Controls.MaterialLabel();
            this.total_ = new MaterialSkin.Controls.MaterialLabel();
            this.terbilang_ = new MaterialSkin.Controls.MaterialLabel();
            this.nmpejabat_ = new MaterialSkin.Controls.MaterialLabel();
            this.nip_ = new MaterialSkin.Controls.MaterialLabel();
            this.tbnosurat_ = new System.Windows.Forms.TextBox();
            this.DataTable2TableAdapter = new Maya_KP.DataSet1TableAdapters.DataTable2TableAdapter();
            this.pp = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.sisa_ = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.DataSet1;
            this.DataTable2BindingSource.CurrentChanged += new System.EventHandler(this.DataTable2BindingSource_CurrentChanged);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Maya_KP.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(987, 846);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // nmr
            // 
            this.nmr.AutoSize = true;
            this.nmr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nmr.Depth = 0;
            this.nmr.Font = new System.Drawing.Font("Roboto", 11F);
            this.nmr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nmr.Location = new System.Drawing.Point(993, 178);
            this.nmr.MouseState = MaterialSkin.MouseState.HOVER;
            this.nmr.Name = "nmr";
            this.nmr.Size = new System.Drawing.Size(65, 24);
            this.nmr.TabIndex = 1;
            this.nmr.Text = "nomor";
            this.nmr.Click += new System.EventHandler(this.Nmr_Click);
            // 
            // tgl_
            // 
            this.tgl_.AutoSize = true;
            this.tgl_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tgl_.Depth = 0;
            this.tgl_.Font = new System.Drawing.Font("Roboto", 11F);
            this.tgl_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tgl_.Location = new System.Drawing.Point(993, 202);
            this.tgl_.MouseState = MaterialSkin.MouseState.HOVER;
            this.tgl_.Name = "tgl_";
            this.tgl_.Size = new System.Drawing.Size(32, 24);
            this.tgl_.TabIndex = 2;
            this.tgl_.Text = "tgl";
            this.tgl_.Click += new System.EventHandler(this.Tgl__Click);
            // 
            // asal_
            // 
            this.asal_.AutoSize = true;
            this.asal_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.asal_.Depth = 0;
            this.asal_.Font = new System.Drawing.Font("Roboto", 11F);
            this.asal_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.asal_.Location = new System.Drawing.Point(993, 237);
            this.asal_.MouseState = MaterialSkin.MouseState.HOVER;
            this.asal_.Name = "asal_";
            this.asal_.Size = new System.Drawing.Size(91, 24);
            this.asal_.TabIndex = 3;
            this.asal_.Text = "Kota Palu";
            this.asal_.Click += new System.EventHandler(this.Asal__Click);
            // 
            // tujuan_
            // 
            this.tujuan_.AutoSize = true;
            this.tujuan_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tujuan_.Depth = 0;
            this.tujuan_.Font = new System.Drawing.Font("Roboto", 11F);
            this.tujuan_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tujuan_.Location = new System.Drawing.Point(1121, 237);
            this.tujuan_.MouseState = MaterialSkin.MouseState.HOVER;
            this.tujuan_.Name = "tujuan_";
            this.tujuan_.Size = new System.Drawing.Size(61, 24);
            this.tujuan_.TabIndex = 4;
            this.tujuan_.Text = "tujuan";
            this.tujuan_.Click += new System.EventHandler(this.Tujuan_Click);
            // 
            // lokal
            // 
            this.lokal.AutoSize = true;
            this.lokal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lokal.Depth = 0;
            this.lokal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lokal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lokal.Location = new System.Drawing.Point(993, 277);
            this.lokal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lokal.Name = "lokal";
            this.lokal.Size = new System.Drawing.Size(151, 24);
            this.lokal.TabIndex = 5;
            this.lokal.Text = "tranportasi_lokal";
            this.lokal.Click += new System.EventHandler(this.Lokal_Click);
            // 
            // damri_
            // 
            this.damri_.AutoSize = true;
            this.damri_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.damri_.Depth = 0;
            this.damri_.Font = new System.Drawing.Font("Roboto", 11F);
            this.damri_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.damri_.Location = new System.Drawing.Point(998, 318);
            this.damri_.MouseState = MaterialSkin.MouseState.HOVER;
            this.damri_.Name = "damri_";
            this.damri_.Size = new System.Drawing.Size(60, 24);
            this.damri_.TabIndex = 6;
            this.damri_.Text = "Damri";
            this.damri_.Click += new System.EventHandler(this.Damri_Click);
            // 
            // lain_
            // 
            this.lain_.AutoSize = true;
            this.lain_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lain_.Depth = 0;
            this.lain_.Font = new System.Drawing.Font("Roboto", 11F);
            this.lain_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lain_.Location = new System.Drawing.Point(998, 354);
            this.lain_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lain_.Name = "lain_";
            this.lain_.Size = new System.Drawing.Size(45, 24);
            this.lain_.TabIndex = 6;
            this.lain_.Text = "Lain";
            this.lain_.Click += new System.EventHandler(this.Lain_Click);
            // 
            // total_
            // 
            this.total_.AutoSize = true;
            this.total_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.total_.Depth = 0;
            this.total_.Font = new System.Drawing.Font("Roboto", 11F);
            this.total_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.total_.Location = new System.Drawing.Point(998, 378);
            this.total_.MouseState = MaterialSkin.MouseState.HOVER;
            this.total_.Name = "total_";
            this.total_.Size = new System.Drawing.Size(48, 24);
            this.total_.TabIndex = 6;
            this.total_.Text = "total";
            this.total_.Click += new System.EventHandler(this.Total_Click);
            // 
            // terbilang_
            // 
            this.terbilang_.AutoSize = true;
            this.terbilang_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.terbilang_.Depth = 0;
            this.terbilang_.Font = new System.Drawing.Font("Roboto", 11F);
            this.terbilang_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.terbilang_.Location = new System.Drawing.Point(998, 402);
            this.terbilang_.MouseState = MaterialSkin.MouseState.HOVER;
            this.terbilang_.Name = "terbilang_";
            this.terbilang_.Size = new System.Drawing.Size(84, 24);
            this.terbilang_.TabIndex = 6;
            this.terbilang_.Text = "terbilang";
            this.terbilang_.Click += new System.EventHandler(this.Terbilang__Click);
            // 
            // nmpejabat_
            // 
            this.nmpejabat_.AutoSize = true;
            this.nmpejabat_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nmpejabat_.Depth = 0;
            this.nmpejabat_.Font = new System.Drawing.Font("Roboto", 11F);
            this.nmpejabat_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nmpejabat_.Location = new System.Drawing.Point(998, 426);
            this.nmpejabat_.MouseState = MaterialSkin.MouseState.HOVER;
            this.nmpejabat_.Name = "nmpejabat_";
            this.nmpejabat_.Size = new System.Drawing.Size(129, 24);
            this.nmpejabat_.TabIndex = 6;
            this.nmpejabat_.Text = "nama_pejabat";
            this.nmpejabat_.Click += new System.EventHandler(this.Nmpejabat__Click);
            // 
            // nip_
            // 
            this.nip_.AutoSize = true;
            this.nip_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nip_.Depth = 0;
            this.nip_.Font = new System.Drawing.Font("Roboto", 11F);
            this.nip_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nip_.Location = new System.Drawing.Point(998, 450);
            this.nip_.MouseState = MaterialSkin.MouseState.HOVER;
            this.nip_.Name = "nip_";
            this.nip_.Size = new System.Drawing.Size(36, 24);
            this.nip_.TabIndex = 6;
            this.nip_.Text = "nip";
            this.nip_.Click += new System.EventHandler(this.Nip__Click);
            // 
            // tbnosurat_
            // 
            this.tbnosurat_.Location = new System.Drawing.Point(1138, 80);
            this.tbnosurat_.Multiline = true;
            this.tbnosurat_.Name = "tbnosurat_";
            this.tbnosurat_.Size = new System.Drawing.Size(160, 33);
            this.tbnosurat_.TabIndex = 7;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // pp
            // 
            this.pp.AutoSize = true;
            this.pp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pp.Depth = 0;
            this.pp.Font = new System.Drawing.Font("Roboto", 11F);
            this.pp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pp.Location = new System.Drawing.Point(1150, 277);
            this.pp.MouseState = MaterialSkin.MouseState.HOVER;
            this.pp.Name = "pp";
            this.pp.Size = new System.Drawing.Size(32, 24);
            this.pp.TabIndex = 5;
            this.pp.Text = "pp";
            this.pp.Click += new System.EventHandler(this.Lokal_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(787, 129);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(0, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Click += new System.EventHandler(this.Lokal_Click);
            // 
            // sisa_
            // 
            this.sisa_.AutoSize = true;
            this.sisa_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sisa_.Depth = 0;
            this.sisa_.Font = new System.Drawing.Font("Roboto", 11F);
            this.sisa_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sisa_.Location = new System.Drawing.Point(1134, 378);
            this.sisa_.MouseState = MaterialSkin.MouseState.HOVER;
            this.sisa_.Name = "sisa_";
            this.sisa_.Size = new System.Drawing.Size(45, 24);
            this.sisa_.TabIndex = 6;
            this.sisa_.Text = "sisa";
            this.sisa_.Click += new System.EventHandler(this.Total_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(1100, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(27, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "ID";
            this.materialLabel1.Click += new System.EventHandler(this.Nmr_Click);
            // 
            // FrmRincian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 942);
            this.Controls.Add(this.tbnosurat_);
            this.Controls.Add(this.nip_);
            this.Controls.Add(this.nmpejabat_);
            this.Controls.Add(this.terbilang_);
            this.Controls.Add(this.sisa_);
            this.Controls.Add(this.total_);
            this.Controls.Add(this.lain_);
            this.Controls.Add(this.damri_);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.pp);
            this.Controls.Add(this.lokal);
            this.Controls.Add(this.tujuan_);
            this.Controls.Add(this.asal_);
            this.Controls.Add(this.tgl_);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.nmr);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRincian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RINCIAN BIAYA";
            this.Load += new System.EventHandler(this.FrmRincian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
        public MaterialSkin.Controls.MaterialLabel nmr;
        public MaterialSkin.Controls.MaterialLabel tgl_;
        public MaterialSkin.Controls.MaterialLabel asal_;
        public MaterialSkin.Controls.MaterialLabel tujuan_;
        public MaterialSkin.Controls.MaterialLabel lokal;
        public MaterialSkin.Controls.MaterialLabel damri_;
        public MaterialSkin.Controls.MaterialLabel lain_;
        public MaterialSkin.Controls.MaterialLabel total_;
        public MaterialSkin.Controls.MaterialLabel terbilang_;
        public MaterialSkin.Controls.MaterialLabel nmpejabat_;
        public MaterialSkin.Controls.MaterialLabel nip_;
        public System.Windows.Forms.TextBox tbnosurat_;
        public MaterialSkin.Controls.MaterialLabel pp;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialLabel sisa_;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}