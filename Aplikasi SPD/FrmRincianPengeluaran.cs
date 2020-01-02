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
    public partial class FrmRincianPengeluaran : MaterialForm
    {
        public FrmRincianPengeluaran()
        {
            InitializeComponent();
        }

        private void FrmRincianPengeluaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable4' table. You can move, or remove it, as needed.
            this.DataTable4TableAdapter.Fill(this.DataSet1.DataTable4);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
