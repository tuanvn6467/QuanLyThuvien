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
    public partial class FrLstTacGiaEdit : Form
    {
        public FrLstTacGiaEdit()
        {
            InitializeComponent();
        }
        public static string strConn = Constants.Connection;
        private void FrLstTacGiaEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            string strSQL = "SET DATEFORMAT DMY; \r\n";
            if (this.Tag.ToString() == "")
            {
                //Ghi thêm
                strSQL = strSQL + "INSERT INTO LstTacGia(Ma_TacGia,Ten_TacGia,Dia_Chi,Ngay_Sinh) VALUES ('" + this.txtMaTacGia.Text + "', N'" + this.txtTenTacGia.Text + "', N'" + this.txtDiaChi.Text + "','" + this.txtNS.Text + "')";
            }
            else
            {
                //Ghi sửa
                strSQL = strSQL + "UPDATE LstTacGia SET Ma_TacGia = '" + this.txtMaTacGia.Text + "', Ten_TacGia = N'" + this.txtTenTacGia.Text + "', Dia_Chi = N'" + this.txtDiaChi.Text + "',Ngay_Sinh = '" + this.txtNS.Text + "' where Ma_TacGia = '" + this.Tag + "'";
            }
            if (QuanLyThuVien.ClsSQL.SqlExecute(strSQL, strConn) == true)
                //MessageBox.Show("Them / sua thanh cong");
                this.Dispose();
            QuanLyThuVien.ClsSQL.Disconnect();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
