using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrBaoCaoDocGiaMuonTra1 : Form
    {
        public FrBaoCaoDocGiaMuonTra1()
        {
            InitializeComponent();
        }
        public static string strConn = Constants.Connection;

        private void FrLstDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetBaoCaoMuonTraDocGia.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetBaoCaoMuonTraDocGia.DataTable1);
            this.reportViewer1.RefreshReport();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //FrInDg frin = new FrInDg(GrDocGiaMuonSach.CurrentRow.Cells[0].Value.ToString());
            //frin.ShowDialog();
        }

        private void GrDocGia_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }
}
