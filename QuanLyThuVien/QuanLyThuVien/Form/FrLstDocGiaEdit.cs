using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class FrLstDocGiaEdit : Form
    {
        public FrLstDocGiaEdit()
        {
            InitializeComponent();
        }
        public static string strConn = Constants.Connection;

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            string strSQL = "SET DATEFORMAT DMY; \r\n";
            if (this.Tag.ToString() == "")
            {
                //Ghi thêm
                strSQL = strSQL + "INSERT INTO LstDocGia(Ma_DocGia,Ten_DocGia,Dia_Chi,So_DienThoai,Ngay_Sinh,Ngay_Lap,Ngay_HetHan) VALUES ('" + this.txtMaDG.Text + "', N'" + this.txtTenDG.Text + "', N'" + this.txtDiaChi.Text + "', '" + this.txtSDT.Text + "','" + this.txtNgaySinh.Text + "','" + this.txtNgayLap.Text + "','" + this.txtNgayHetHan.Text + "')";
            }
            else
            {
                //Ghi sửa
               strSQL = strSQL + "UPDATE LstDocGia SET Ma_DocGia = '" + this.txtMaDG.Text + "', Ten_DocGia = N'" + this.txtTenDG.Text + "', Dia_Chi = N'" + this.txtDiaChi.Text + "', So_DienThoai = '" + this.txtSDT.Text + "',Ngay_Sinh = '" + this.txtNgaySinh.Text + "',Ngay_Lap = '" + this.txtNgayLap.Text + "',Ngay_HetHan = '" + this.txtNgayHetHan.Text + "' where Ma_DocGia = '" + this.Tag + "'";
            }
            if (QuanLyThuVien.ClsSQL.SqlExecute(strSQL, strConn) == true)
                //MessageBox.Show("Them / sua thanh cong");
                this.Dispose();
            QuanLyThuVien.ClsSQL.Disconnect();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrLstDocGiaEdit_Load(object sender, EventArgs e)
        {

        }

    }
}
