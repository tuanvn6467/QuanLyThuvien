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
    public partial class FrLstDocGia : Form
    {
        public FrLstDocGia()
        {
            InitializeComponent();
        }
        public static string strConn = Constants.Connection;
        public static void HienThiLstDocGia(DataGridView GrDocGia)
        {
            string strSQL = "SELECT * FROM LstDocGia";
            DataSet objDs = new DataSet();
            objDs = QuanLyThuVien.ClsSQL.SqlSelect(strSQL, strConn);
            GrDocGia.DataSource = objDs.Tables[0];
            GrDocGia.Columns["Ma_DocGia"].HeaderText = "Mã Độc Giả";
            GrDocGia.Columns["Ma_DocGia"].ReadOnly = true;
            GrDocGia.Columns["Ten_DocGia"].HeaderText = "Tên Độc Giả";
            GrDocGia.Columns["Ngay_Sinh"].HeaderText = "Ngày Sinh";
            GrDocGia.Columns["Dia_Chi"].HeaderText = "Địa Chỉ";
            GrDocGia.Columns["So_DienThoai"].HeaderText = "Số Điện Thoại";
            GrDocGia.Columns["Ngay_Lap"].HeaderText = "Ngày lập";
            GrDocGia.Columns["Ngay_HetHan"].HeaderText = "Ngày hết hạn";
            //Thay đổi độ rộng cột
            GrDocGia.Columns["Ma_DocGia"].Width = 100;
            GrDocGia.Columns["Ten_DocGia"].Width = 150;
            GrDocGia.Columns["Ngay_Sinh"].Width = 100;
            GrDocGia.Columns["Dia_Chi"].Width = 230;
            GrDocGia.Columns["So_DienThoai"].Width = 100;
            GrDocGia.Columns["Ngay_Lap"].Width = 100;
            GrDocGia.Columns["Ngay_HetHan"].Width = 100;
            //GrDocGia.Columns[GrDocGia.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //đặt nền cho tiêu đề
            GrDocGia.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            GrDocGia.EnableHeadersVisualStyles = false;
        }

        private void FrLstDocGia_Load(object sender, EventArgs e)
        {
            HienThiLstDocGia(GrDocGia);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrLstDocGiaEdit frm = new FrLstDocGiaEdit();
            frm.Tag = ""; //Tín hiệu cho biết thêm mới
            frm.ShowDialog();
            HienThiLstDocGia(GrDocGia);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrLstDocGiaEdit fr= new FrLstDocGiaEdit();
            fr= new FrLstDocGiaEdit();
            fr.Tag = this.GrDocGia.CurrentRow.Cells["Ma_DocGia"].Value.ToString(); //Tín hiệu sửa
            fr.txtMaDG.Text = this.GrDocGia.CurrentRow.Cells["Ma_DocGia"].Value.ToString();
            fr.txtTenDG.Text = this.GrDocGia.CurrentRow.Cells["Ten_DocGia"].Value.ToString();
            fr.txtDiaChi.Text = this.GrDocGia.CurrentRow.Cells["Dia_Chi"].Value.ToString();
            fr.txtSDT.Text = this.GrDocGia.CurrentRow.Cells["So_DienThoai"].Value.ToString();
            fr.txtNgaySinh.Text = this.GrDocGia.CurrentRow.Cells["Ngay_Sinh"].Value.ToString().Substring(0,10);
            fr.txtNgayLap.Text = this.GrDocGia.CurrentRow.Cells["Ngay_Lap"].Value.ToString().Substring(0,10);
            fr.txtNgayHetHan.Text = this.GrDocGia.CurrentRow.Cells["Ngay_HetHan"].Value.ToString().Substring(0,10);
            fr.ShowDialog();
            HienThiLstDocGia(GrDocGia);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strSQL = "DELETE FROM LstDocGia WHERE Ma_DocGia = '" + this.GrDocGia.CurrentRow.Cells["Ma_DocGia"].Value.ToString() + "'";
            if (QuanLyThuVien.ClsSQL.Connect(strConn) == true)
                QuanLyThuVien.ClsSQL.SqlExecute(strSQL, strConn);
            HienThiLstDocGia(GrDocGia);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrInDg frin = new FrInDg(GrDocGia.CurrentRow.Cells[0].Value.ToString());
            frin.ShowDialog();
        }

        private void GrDocGia_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }
}
