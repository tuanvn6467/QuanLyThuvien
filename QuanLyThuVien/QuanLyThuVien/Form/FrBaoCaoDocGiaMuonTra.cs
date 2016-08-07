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
    public partial class FrBaoCaoDocGiaMuonTra : Form
    {
        public FrBaoCaoDocGiaMuonTra()
        {
            InitializeComponent();
        }
        public static string strConn = Constants.Connection;
        public static void HienThiBaoCaoMuonTra(DataGridView GrDocGiaMuonSach)
        {
            DataTable dt = new DataTable();
            dt = Utils.get_ThongTinDocGiaMuonSach();
            GrDocGiaMuonSach.AutoGenerateColumns = false;
            GrDocGiaMuonSach.DataSource = dt;
        }

        private void FrLstDocGia_Load(object sender, EventArgs e)
        {
            HienThiBaoCaoMuonTra(this.GrDocGiaMuonSach);
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
