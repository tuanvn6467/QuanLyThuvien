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
    public partial class FrLstNhaXuatBanEdit : Form
    {
        public FrLstNhaXuatBanEdit()
        {
            InitializeComponent();
        }
        public static string strConn = Constants.Connection;

        private void button1_Click(object sender, EventArgs e)
        {
            string strSQL = "SET DATEFORMAT DMY; \r\n";
            if (this.Tag.ToString() == "")
            {
                //Ghi thêm
                strSQL = strSQL + "INSERT INTO LstNhaXuatBan(Ma_NhaXuatBan,Ten_NhaXuatBan,Dia_Chi) VALUES ('" + this.txtMaNXB.Text + "', N'" + this.txtTenNXB.Text + "', N'" + this.txtDiaChi.Text + "')";
            }
            else
            {
                //Ghi sửa
                strSQL = strSQL + "UPDATE LstNhaXuatBan SET Ma_NhaXuatBan = '" + this.txtMaNXB.Text + "', Ten_NhaXuatBan = N'" + this.txtTenNXB.Text + "', Dia_Chi = N'" + this.txtDiaChi.Text + "' where Ma_NhaXuatBan = '" + this.Tag + "'";
            }
            if (QuanLyThuVien.ClsSQL.SqlExecute(strSQL, strConn) == true)
                //MessageBox.Show("Them / sua thanh cong");
                this.Dispose();
            QuanLyThuVien.ClsSQL.Disconnect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
