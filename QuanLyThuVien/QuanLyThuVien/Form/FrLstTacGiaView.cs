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
    public partial class FrLstTacGiaView : Form
    {
        public FrLstTacGiaView()
        {
            InitializeComponent();
        }
        public static string strConn = Constants.Connection;
        public static void HienThiLstTacGia(DataGridView GrTG)
        {
            string strSQL = "SELECT * FROM LstTacGia";
            DataSet objDs = new DataSet();
            objDs = QuanLyThuVien.ClsSQL.SqlSelect(strSQL, strConn);
            GrTG.DataSource = objDs.Tables[0];
            GrTG.Columns["Ma_TacGia"].HeaderText = "Mã Tác Giả";
            GrTG.Columns["Ten_TacGia"].HeaderText = "Tên Tác Giả";
            GrTG.Columns["Dia_Chi"].HeaderText = "Địa Chỉ";
            GrTG.Columns["Ngay_Sinh"].HeaderText = "Ngày Sinh";
            //Thay đổi độ rộng cột
            GrTG.Columns["Ma_TacGia"].Width = 100;
            GrTG.Columns["Ten_TacGia"].Width = 150;
            GrTG.Columns["Dia_Chi"].Width = 200;
            //GrNhaCC.Columns[GrNhaCC.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //đặt nền cho tiêu đề
            GrTG.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            GrTG.EnableHeadersVisualStyles = false;
        }

        private void FrLstTacGiaView_Load(object sender, EventArgs e)
        {
            HienThiLstTacGia(GrTG);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrLstTacGiaEdit frm = new FrLstTacGiaEdit();
            frm.Tag = ""; //Tín hiệu cho biết thêm mới
            frm.ShowDialog();
            HienThiLstTacGia(GrTG);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrLstTacGiaEdit fr = new FrLstTacGiaEdit();
            fr = new FrLstTacGiaEdit();
            fr.Tag = this.GrTG.CurrentRow.Cells["Ma_TacGia"].Value.ToString(); //Tín hiệu sửa
            fr.txtMaTacGia.Text = this.GrTG.CurrentRow.Cells["Ma_TacGia"].Value.ToString();
            fr.txtTenTacGia.Text = this.GrTG.CurrentRow.Cells["Ten_TacGia"].Value.ToString();
            fr.txtDiaChi.Text = this.GrTG.CurrentRow.Cells["Dia_Chi"].Value.ToString();
            fr.txtNS.Text = this.GrTG.CurrentRow.Cells["Ngay_Sinh"].Value.ToString().Substring(0, 10);
            fr.ShowDialog();
            HienThiLstTacGia(GrTG);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strSQL = "DELETE FROM LstTacGia WHERE Ma_TacGia = '" + this.GrTG.CurrentRow.Cells["Ma_TacGia"].Value.ToString() + "'";
            if (QuanLyThuVien.ClsSQL.Connect(strConn) == true)
                QuanLyThuVien.ClsSQL.SqlExecute(strSQL, strConn);
            HienThiLstTacGia(GrTG);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
