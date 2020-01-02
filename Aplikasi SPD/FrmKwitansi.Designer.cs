namespace Maya_KP
{
    partial class FrmKwitansi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Maya_KP.DataSet1();
            this.ktotal_uang = new MaterialSkin.Controls.MaterialLabel();
            this.kterbilang = new MaterialSkin.Controls.MaterialLabel();
            this.kmaksud = new MaterialSkin.Controls.MaterialLabel();
            this.klama = new MaterialSkin.Controls.MaterialLabel();
            this.ktglberangkat = new MaterialSkin.Controls.MaterialLabel();
            this.ktglpulang = new MaterialSkin.Controls.MaterialLabel();
            this.ktujuan = new MaterialSkin.Controls.MaterialLabel();
            this.ktgl = new MaterialSkin.Controls.MaterialLabel();
            this.kpejabat = new MaterialSkin.Controls.MaterialLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new Maya_KP.DataSet1TableAdapters.DataTable1TableAdapter();
            this.knip = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ktotal_uang
            // 
            this.ktotal_uang.AutoSize = true;
            this.ktotal_uang.Depth = 0;
            this.ktotal_uang.Font = new System.Drawing.Font("Roboto", 11F);
            this.ktotal_uang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ktotal_uang.Location = new System.Drawing.Point(926, 126);
            this.ktotal_uang.MouseState = MaterialSkin.MouseState.HOVER;
            this.ktotal_uang.Name = "ktotal_uang";
            this.ktotal_uang.Size = new System.Drawing.Size(98, 24);
            this.ktotal_uang.TabIndex = 0;
            this.ktotal_uang.Text = "total_uang";
            // 
            // kterbilang
            // 
            this.kterbilang.AutoSize = true;
            this.kterbilang.Depth = 0;
            this.kterbilang.Font = new System.Drawing.Font("Roboto", 11F);
            this.kterbilang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kterbilang.Location = new System.Drawing.Point(926, 150);
            this.kterbilang.MouseState = MaterialSkin.MouseState.HOVER;
            this.kterbilang.Name = "kterbilang";
            this.kterbilang.Size = new System.Drawing.Size(84, 24);
            this.kterbilang.TabIndex = 0;
            this.kterbilang.Text = "terbilang";
            // 
            // kmaksud
            // 
            this.kmaksud.AutoSize = true;
            this.kmaksud.Depth = 0;
            this.kmaksud.Font = new System.Drawing.Font("Roboto", 11F);
            this.kmaksud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kmaksud.Location = new System.Drawing.Point(926, 174);
            this.kmaksud.MouseState = MaterialSkin.MouseState.HOVER;
            this.kmaksud.Name = "kmaksud";
            this.kmaksud.Size = new System.Drawing.Size(78, 24);
            this.kmaksud.TabIndex = 0;
            this.kmaksud.Text = "maksud";
            // 
            // klama
            // 
            this.klama.AutoSize = true;
            this.klama.Depth = 0;
            this.klama.Font = new System.Drawing.Font("Roboto", 11F);
            this.klama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.klama.Location = new System.Drawing.Point(926, 198);
            this.klama.MouseState = MaterialSkin.MouseState.HOVER;
            this.klama.Name = "klama";
            this.klama.Size = new System.Drawing.Size(52, 24);
            this.klama.TabIndex = 0;
            this.klama.Text = "lama";
            // 
            // ktglberangkat
            // 
            this.ktglberangkat.AutoSize = true;
            this.ktglberangkat.Depth = 0;
            this.ktglberangkat.Font = new System.Drawing.Font("Roboto", 11F);
            this.ktglberangkat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ktglberangkat.Location = new System.Drawing.Point(926, 222);
            this.ktglberangkat.MouseState = MaterialSkin.MouseState.HOVER;
            this.ktglberangkat.Name = "ktglberangkat";
            this.ktglberangkat.Size = new System.Drawing.Size(125, 24);
            this.ktglberangkat.TabIndex = 0;
            this.ktglberangkat.Text = "tgl_berangkat";
            // 
            // ktglpulang
            // 
            this.ktglpulang.AutoSize = true;
            this.ktglpulang.Depth = 0;
            this.ktglpulang.Font = new System.Drawing.Font("Roboto", 11F);
            this.ktglpulang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ktglpulang.Location = new System.Drawing.Point(926, 246);
            this.ktglpulang.MouseState = MaterialSkin.MouseState.HOVER;
            this.ktglpulang.Name = "ktglpulang";
            this.ktglpulang.Size = new System.Drawing.Size(98, 24);
            this.ktglpulang.TabIndex = 0;
            this.ktglpulang.Text = "tgl_pulang";
            // 
            // ktujuan
            // 
            this.ktujuan.AutoSize = true;
            this.ktujuan.Depth = 0;
            this.ktujuan.Font = new System.Drawing.Font("Roboto", 11F);
            this.ktujuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ktujuan.Location = new System.Drawing.Point(926, 270);
            this.ktujuan.MouseState = MaterialSkin.MouseState.HOVER;
            this.ktujuan.Name = "ktujuan";
            this.ktujuan.Size = new System.Drawing.Size(61, 24);
            this.ktujuan.TabIndex = 0;
            this.ktujuan.Text = "tujuan";
            // 
            // ktgl
            // 
            this.ktgl.AutoSize = true;
            this.ktgl.Depth = 0;
            this.ktgl.Font = new System.Drawing.Font("Roboto", 11F);
            this.ktgl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ktgl.Location = new System.Drawing.Point(926, 294);
            this.ktgl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ktgl.Name = "ktgl";
            this.ktgl.Size = new System.Drawing.Size(32, 24);
            this.ktgl.TabIndex = 0;
            this.ktgl.Text = "tgl";
            // 
            // kpejabat
            // 
            this.kpejabat.AutoSize = true;
            this.kpejabat.Depth = 0;
            this.kpejabat.Font = new System.Drawing.Font("Roboto", 11F);
            this.kpejabat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kpejabat.Location = new System.Drawing.Point(926, 318);
            this.kpejabat.MouseState = MaterialSkin.MouseState.HOVER;
            this.kpejabat.Name = "kpejabat";
            this.kpejabat.Size = new System.Drawing.Size(73, 24);
            this.kpejabat.TabIndex = 0;
            this.kpejabat.Text = "pejabat";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Maya_KP.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(920, 656);
            this.reportViewer1.TabIndex = 1;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // knip
            // 
            this.knip.AutoSize = true;
            this.knip.Depth = 0;
            this.knip.Font = new System.Drawing.Font("Roboto", 11F);
            this.knip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.knip.Location = new System.Drawing.Point(926, 342);
            this.knip.MouseState = MaterialSkin.MouseState.HOVER;
            this.knip.Name = "knip";
            this.knip.Size = new System.Drawing.Size(36, 24);
            this.knip.TabIndex = 0;
            this.knip.Text = "nip";
            // 
            // FrmKwitansi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 741);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.knip);
            this.Controls.Add(this.kpejabat);
            this.Controls.Add(this.ktgl);
            this.Controls.Add(this.ktujuan);
            this.Controls.Add(this.ktglpulang);
            this.Controls.Add(this.ktglberangkat);
            this.Controls.Add(this.klama);
            this.Controls.Add(this.kmaksud);
            this.Controls.Add(this.kterbilang);
            this.Controls.Add(this.ktotal_uang);
            this.Name = "FrmKwitansi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CETAK KWITANSI";
            this.Load += new System.EventHandler(this.FrmKwitansi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        public MaterialSkin.Controls.MaterialLabel ktotal_uang;
        public MaterialSkin.Controls.MaterialLabel kterbilang;
        public MaterialSkin.Controls.MaterialLabel kmaksud;
        public MaterialSkin.Controls.MaterialLabel klama;
        public MaterialSkin.Controls.MaterialLabel ktglberangkat;
        public MaterialSkin.Controls.MaterialLabel ktglpulang;
        public MaterialSkin.Controls.MaterialLabel ktujuan;
        public MaterialSkin.Controls.MaterialLabel ktgl;
        public MaterialSkin.Controls.MaterialLabel kpejabat;
        public MaterialSkin.Controls.MaterialLabel knip;
    }
}