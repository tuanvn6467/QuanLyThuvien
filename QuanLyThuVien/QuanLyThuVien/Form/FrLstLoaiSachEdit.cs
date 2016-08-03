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
    public partial class FrLstLoaiSachEdit : Form
    {
        public FrLstLoaiSachEdit()
        {
            InitializeComponent();
        }
        public static string strConn = Constants.Connection;


        
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            string strSQL= "SET DATEFORMAT DMY; \r\n";
            if (this.Tag.ToString() == "")
            {
                //Ghi thêm
                strSQL = strSQL+"INSERT INTO LoaiSach(Ma_LoaiSach,Ten_LoaiSach) VALUES ('" + this.txtMaLoaiSach.Text + "', N'" + this.txtTenMaLoaiSach.Text + "')";
            }
            else
            {
                //Ghi sửa
                strSQL = strSQL+"UPDATE LoaiSach SET Ma_LoaiSach = '" + this.txtMaLoaiSach.Text + "', Ten_LoaiSach = N'" + this.txtTenMaLoaiSach.Text + "' where Ma_LoaiSach = '" + this.Tag + "'";
            }
            if (QuanLyThuVien.ClsSQL.SqlExecute(strSQL, strConn) == true)
                //MessageBox.Show("Them / sua thanh cong");
                this.Dispose();
            QuanLyThuVien.ClsSQL.Disconnect();
              
        }
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
